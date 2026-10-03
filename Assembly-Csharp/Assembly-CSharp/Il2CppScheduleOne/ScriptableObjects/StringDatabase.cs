using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ScriptableObjects
{
	// Token: 0x02000457 RID: 1111
	[Serializable]
	public class StringDatabase : ScriptableObject
	{
		// Token: 0x060064E8 RID: 25832 RVA: 0x001D8FF4 File Offset: 0x001D71F4
		// Note: this type is marked as 'beforefieldinit'.
		static StringDatabase()
		{
			Il2CppClassPointerStore<StringDatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ScriptableObjects", "StringDatabase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringDatabase>.NativeClassPtr);
			StringDatabase.NativeFieldInfoPtr_Strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringDatabase>.NativeClassPtr, "Strings");
			StringDatabase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringDatabase>.NativeClassPtr, 100676550);
		}

		// Token: 0x060064E9 RID: 25833 RVA: 0x001D904C File Offset: 0x001D724C
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 79617, RefRangeEnd = 79648, XrefRangeStart = 79617, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringDatabase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringDatabase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringDatabase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064EA RID: 25834 RVA: 0x0002F896 File Offset: 0x0002DA96
		public StringDatabase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EEE RID: 7918
		// (get) Token: 0x060064EB RID: 25835 RVA: 0x001D9088 File Offset: 0x001D7288
		// (set) Token: 0x060064EC RID: 25836 RVA: 0x0002F89F File Offset: 0x0002DA9F
		public unsafe Il2CppStringArray Strings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringDatabase.NativeFieldInfoPtr_Strings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringDatabase.NativeFieldInfoPtr_Strings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400458F RID: 17807
		private static readonly IntPtr NativeFieldInfoPtr_Strings;

		// Token: 0x04004590 RID: 17808
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
