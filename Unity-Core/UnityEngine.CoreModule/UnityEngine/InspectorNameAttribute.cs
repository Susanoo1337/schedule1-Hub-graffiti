using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200010A RID: 266
	public class InspectorNameAttribute : PropertyAttribute
	{
		// Token: 0x0600167B RID: 5755 RVA: 0x00062750 File Offset: 0x00060950
		// Note: this type is marked as 'beforefieldinit'.
		static InspectorNameAttribute()
		{
			Il2CppClassPointerStore<InspectorNameAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "InspectorNameAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InspectorNameAttribute>.NativeClassPtr);
			InspectorNameAttribute.NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectorNameAttribute>.NativeClassPtr, "displayName");
			InspectorNameAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectorNameAttribute>.NativeClassPtr, 100665669);
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x000627A8 File Offset: 0x000609A8
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 31934, RefRangeEnd = 31959, XrefRangeStart = 31934, XrefRangeEnd = 31959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InspectorNameAttribute(string displayName) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InspectorNameAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InspectorNameAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x0000B469 File Offset: 0x00009669
		public InspectorNameAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x000627F4 File Offset: 0x000609F4
		// (set) Token: 0x0600167F RID: 5759 RVA: 0x0000B472 File Offset: 0x00009672
		public unsafe string displayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InspectorNameAttribute.NativeFieldInfoPtr_displayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InspectorNameAttribute.NativeFieldInfoPtr_displayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001355 RID: 4949
		private static readonly IntPtr NativeFieldInfoPtr_displayName;

		// Token: 0x04001356 RID: 4950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
