using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200010B RID: 267
	public class TooltipAttribute : PropertyAttribute
	{
		// Token: 0x06001680 RID: 5760 RVA: 0x0006281C File Offset: 0x00060A1C
		// Note: this type is marked as 'beforefieldinit'.
		static TooltipAttribute()
		{
			Il2CppClassPointerStore<TooltipAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TooltipAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipAttribute>.NativeClassPtr);
			TooltipAttribute.NativeFieldInfoPtr_tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipAttribute>.NativeClassPtr, "tooltip");
			TooltipAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipAttribute>.NativeClassPtr, 100665670);
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00062874 File Offset: 0x00060A74
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 31934, RefRangeEnd = 31959, XrefRangeStart = 31934, XrefRangeEnd = 31959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TooltipAttribute(string tooltip) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x0000B491 File Offset: 0x00009691
		public TooltipAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001683 RID: 5763 RVA: 0x000628C0 File Offset: 0x00060AC0
		// (set) Token: 0x06001684 RID: 5764 RVA: 0x0000B49A File Offset: 0x0000969A
		public unsafe string tooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipAttribute.NativeFieldInfoPtr_tooltip);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipAttribute.NativeFieldInfoPtr_tooltip), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001357 RID: 4951
		private static readonly IntPtr NativeFieldInfoPtr_tooltip;

		// Token: 0x04001358 RID: 4952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
