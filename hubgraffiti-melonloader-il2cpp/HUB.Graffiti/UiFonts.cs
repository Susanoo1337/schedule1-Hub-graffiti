using UnityEngine;

namespace HUB.Graffiti
{
	internal static class UiFonts
	{
		private static Font _builtin;
		private static bool _resolved;

		/// <summary>
		/// Unity's built-in UI font. Unity 2022.2+ renamed Arial.ttf to LegacyRuntime.ttf and throws for the
		/// old name, which left every label in the sticker picker without a font.
		/// </summary>
		internal static Font Builtin
		{
			get
			{
				if (_resolved && _builtin != null)
				{
					return _builtin;
				}
				_resolved = true;
				foreach (string name in new[] { "LegacyRuntime.ttf", "Arial.ttf" })
				{
					try
					{
						_builtin = Resources.GetBuiltinResource<Font>(name);
					}
					catch
					{
						_builtin = null;
					}
					if (_builtin != null)
					{
						break;
					}
				}
				return _builtin;
			}
		}
	}
}
