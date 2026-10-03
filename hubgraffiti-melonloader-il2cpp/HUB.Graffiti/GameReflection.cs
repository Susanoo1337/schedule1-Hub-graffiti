using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace HUB.Graffiti
{
	/// <summary>
	/// Late-bound access to game members whose exact shape we can't rely on at compile time.
	/// Everything here fails soft (returns null) so a game update degrades a feature instead of
	/// breaking the whole mod.
	/// </summary>
	internal static class GameReflection
	{
		private const BindingFlags InstanceFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
		private const BindingFlags StaticFlags = BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;

		private static readonly Dictionary<string, Type> _typeCache = new Dictionary<string, Type>();
		private static readonly HashSet<Type> _loggedTypes = new HashSet<Type>();

		internal static Type FindType(string fullName)
		{
			if (_typeCache.TryGetValue(fullName, out Type cached))
			{
				return cached;
			}
			Type found = null;
			foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
			{
				try
				{
					found = assembly.GetType(fullName, false);
				}
				catch
				{
				}
				if (found != null)
				{
					break;
				}
			}
			// Only cache hits: the interop assemblies may not be loaded yet on an early call.
			if (found != null)
			{
				_typeCache[fullName] = found;
			}
			return found;
		}

		internal static object GetStaticProperty(Type type, string name)
		{
			for (Type t = type; t != null; t = t.BaseType)
			{
				try
				{
					PropertyInfo prop = t.GetProperty(name, StaticFlags);
					if (prop != null)
					{
						return prop.GetValue(null);
					}
				}
				catch (Exception ex)
				{
					DebugLog.Log("Reflect", type.Name + "." + name + " read failed: " + Unwrap(ex).Message);
					return null;
				}
			}
			return null;
		}

		internal static object GetProperty(object target, string name)
		{
			if (target == null)
			{
				return null;
			}
			try
			{
				PropertyInfo prop = target.GetType().GetProperty(name, InstanceFlags);
				if (prop != null)
				{
					return prop.GetValue(target);
				}
				FieldInfo field = target.GetType().GetField(name, InstanceFlags);
				return field?.GetValue(target);
			}
			catch (Exception ex)
			{
				DebugLog.Log("Reflect", target.GetType().Name + "." + name + " read failed: " + Unwrap(ex).Message);
				return null;
			}
		}

		/// <summary>
		/// Invokes the first parameterless instance method found from <paramref name="names"/>.
		/// Returns the name that ran, or null if none exist or all of them threw.
		/// </summary>
		internal static string TryInvokeFirst(object target, params string[] names)
		{
			if (target == null)
			{
				return null;
			}
			Type type = target.GetType();
			foreach (string name in names)
			{
				MethodInfo method;
				try
				{
					method = type.GetMethod(name, BindingFlags.Instance | BindingFlags.Public, null, Type.EmptyTypes, null);
				}
				catch
				{
					continue;
				}
				if (method == null)
				{
					continue;
				}
				try
				{
					method.Invoke(target, null);
					return name;
				}
				catch (Exception ex)
				{
					DebugLog.Log("Reflect", type.Name + "." + name + "() threw: " + Unwrap(ex).Message);
				}
			}
			return null;
		}

		/// <summary>
		/// Writes the type's method names that contain any of the keywords to the debug log, once per type.
		/// Used to see what a game version exposes when a best-effort call finds nothing.
		/// </summary>
		internal static void LogMethodsOnce(object target, params string[] keywords)
		{
			if (target == null)
			{
				return;
			}
			Type type = target.GetType();
			if (!_loggedTypes.Add(type))
			{
				return;
			}
			try
			{
				IEnumerable<string> names = type.GetMethods(InstanceFlags)
					.Select(m => m.Name)
					.Where(n => keywords.Any(k => n.IndexOf(k, StringComparison.OrdinalIgnoreCase) >= 0))
					.Distinct()
					.OrderBy(n => n);
				DebugLog.Log("Reflect", type.FullName + " candidate methods: " + string.Join(", ", names));
			}
			catch (Exception ex)
			{
				DebugLog.Log("Reflect", "Method listing failed: " + ex.Message);
			}
		}

		private static Exception Unwrap(Exception ex)
		{
			return ex is TargetInvocationException tie && tie.InnerException != null ? tie.InnerException : ex;
		}
	}
}
