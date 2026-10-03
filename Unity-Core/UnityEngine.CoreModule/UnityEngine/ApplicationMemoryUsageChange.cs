using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200006C RID: 108
	[StructLayout(2)]
	public struct ApplicationMemoryUsageChange
	{
		// Token: 0x06000408 RID: 1032 RVA: 0x00023E9C File Offset: 0x0002209C
		// Note: this type is marked as 'beforefieldinit'.
		static ApplicationMemoryUsageChange()
		{
			Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ApplicationMemoryUsageChange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr);
			ApplicationMemoryUsageChange.NativeFieldInfoPtr__memoryUsage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr, "<memoryUsage>k__BackingField");
			ApplicationMemoryUsageChange.NativeMethodInfoPtr_set_memoryUsage_Private_set_Void_ApplicationMemoryUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr, 100663710);
			ApplicationMemoryUsageChange.NativeMethodInfoPtr__ctor_Public_Void_ApplicationMemoryUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr, 100663711);
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00003EA4 File Offset: 0x000020A4
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x00023F08 File Offset: 0x00022108
		public unsafe ApplicationMemoryUsage memoryUsage
		{
			get
			{
				return this._memoryUsage_k__BackingField;
			}
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 54922, RefRangeEnd = 54944, XrefRangeStart = 54922, XrefRangeEnd = 54944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationMemoryUsageChange.NativeMethodInfoPtr_set_memoryUsage_Private_set_Void_ApplicationMemoryUsage_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00023F3C File Offset: 0x0002213C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 54922, RefRangeEnd = 54944, XrefRangeStart = 54922, XrefRangeEnd = 54944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ApplicationMemoryUsageChange(ApplicationMemoryUsage usage)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref usage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationMemoryUsageChange.NativeMethodInfoPtr__ctor_Public_Void_ApplicationMemoryUsage_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00003E92 File Offset: 0x00002092
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr, ref this));
		}

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeFieldInfoPtr__memoryUsage_k__BackingField;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_set_memoryUsage_Private_set_Void_ApplicationMemoryUsage_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ApplicationMemoryUsage_0;

		// Token: 0x0400031B RID: 795
		[FieldOffset(0)]
		public ApplicationMemoryUsage _memoryUsage_k__BackingField;
	}
}
