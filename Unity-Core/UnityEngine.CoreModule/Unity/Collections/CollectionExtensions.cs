using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Unity.Collections
{
	// Token: 0x0200029B RID: 667
	public static class CollectionExtensions
	{
		// Token: 0x06002C84 RID: 11396 RVA: 0x000AB504 File Offset: 0x000A9704
		public static void AddSorted<T>(List<T> list, T item, [Optional] IComparer<T> comparer)
		{
			bool flag = list == null;
			if (flag)
			{
				throw new ArgumentNullException("list must not be null.");
			}
			if (comparer == null)
			{
				comparer = Comparer<T>.Default;
			}
			bool flag2 = list.Count == 0;
			if (flag2)
			{
				list.Add(item);
			}
			else
			{
				bool flag3 = comparer.Compare(list[list.Count - 1], item) <= 0;
				if (flag3)
				{
					list.Add(item);
				}
				else
				{
					bool flag4 = comparer.Compare(list[0], item) >= 0;
					if (flag4)
					{
						list.Insert(0, item);
					}
					else
					{
						int num = list.BinarySearch(item, comparer);
						bool flag5 = num < 0;
						if (flag5)
						{
							num = ~num;
						}
						list.Insert(num, item);
					}
				}
			}
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x000AB5B8 File Offset: 0x000A97B8
		public static bool ContainsByEquals<T>(IEnumerable<T> collection, T element)
		{
			bool flag = collection == null;
			if (flag)
			{
				throw new ArgumentNullException("collection must not be null.");
			}
			foreach (T t in collection)
			{
				bool flag2 = t.Equals(element);
				if (flag2)
				{
					return true;
				}
			}
			return false;
		}
	}
}
