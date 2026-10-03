using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200010C RID: 268
	public class SpaceAttribute : PropertyAttribute
	{
		// Token: 0x06001685 RID: 5765 RVA: 0x000628E8 File Offset: 0x00060AE8
		// Note: this type is marked as 'beforefieldinit'.
		static SpaceAttribute()
		{
			Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SpaceAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr);
			SpaceAttribute.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr, "height");
			SpaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr, 100665671);
			SpaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr, 100665672);
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00062954 File Offset: 0x00060B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1246052, XrefRangeEnd = 1246053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpaceAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00062990 File Offset: 0x00060B90
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1246054, RefRangeEnd = 1246062, XrefRangeStart = 1246053, XrefRangeEnd = 1246054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpaceAttribute(float height) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x0000B4B9 File Offset: 0x000096B9
		public SpaceAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001689 RID: 5769 RVA: 0x000629D8 File Offset: 0x00060BD8
		// (set) Token: 0x0600168A RID: 5770 RVA: 0x0000B4C2 File Offset: 0x000096C2
		public unsafe float height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpaceAttribute.NativeFieldInfoPtr_height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpaceAttribute.NativeFieldInfoPtr_height)) = value;
			}
		}

		// Token: 0x04001359 RID: 4953
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x0400135A RID: 4954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400135B RID: 4955
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
	}
}
