using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Serialization;

namespace UnityEngine.Serialization
{
	// Token: 0x02000321 RID: 801
	public class ListSerializationSurrogate
	{
		// Token: 0x06002DA8 RID: 11688 RVA: 0x000ACE30 File Offset: 0x000AB030
		public void GetObjectData(Object obj, SerializationInfo info, StreamingContext context)
		{
			IList list = obj.Cast<IList>();
			info.AddValue("_size", list.Count);
			info.AddValue("_items", ListSerializationSurrogate.ArrayFromGenericList(list));
			info.AddValue("_version", 0);
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x000ACE78 File Offset: 0x000AB078
		public Object SetObjectData(Object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
		{
			IList list = Activator.CreateInstance(obj.GetType()).Cast<IList>();
			int @int = info.GetInt32("_size");
			bool flag = @int == 0;
			Object result;
			if (flag)
			{
				result = list;
			}
			else
			{
				IEnumerator enumerator = info.GetValue("_items", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<IEnumerable>())).Cast<IEnumerable>().GetEnumerator();
				for (int i = 0; i < @int; i++)
				{
					bool flag2 = !enumerator.MoveNext();
					if (flag2)
					{
						throw new InvalidOperationException();
					}
					list.Add(enumerator.Current);
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x00014408 File Offset: 0x00012608
		public static Array ArrayFromGenericList(IList list)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
