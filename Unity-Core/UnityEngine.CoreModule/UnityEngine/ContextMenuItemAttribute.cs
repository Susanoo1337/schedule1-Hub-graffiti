using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000109 RID: 265
	public class ContextMenuItemAttribute : PropertyAttribute
	{
		// Token: 0x06001674 RID: 5748 RVA: 0x00062634 File Offset: 0x00060834
		// Note: this type is marked as 'beforefieldinit'.
		static ContextMenuItemAttribute()
		{
			Il2CppClassPointerStore<ContextMenuItemAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ContextMenuItemAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextMenuItemAttribute>.NativeClassPtr);
			ContextMenuItemAttribute.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextMenuItemAttribute>.NativeClassPtr, "name");
			ContextMenuItemAttribute.NativeFieldInfoPtr_function = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextMenuItemAttribute>.NativeClassPtr, "function");
			ContextMenuItemAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextMenuItemAttribute>.NativeClassPtr, 100665668);
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x000626A0 File Offset: 0x000608A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 64342, RefRangeEnd = 64345, XrefRangeStart = 64342, XrefRangeEnd = 64345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextMenuItemAttribute(string name, string function) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextMenuItemAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(function);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextMenuItemAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x0000B422 File Offset: 0x00009622
		public ContextMenuItemAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001677 RID: 5751 RVA: 0x00062700 File Offset: 0x00060900
		// (set) Token: 0x06001678 RID: 5752 RVA: 0x0000B42B File Offset: 0x0000962B
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextMenuItemAttribute.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextMenuItemAttribute.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001679 RID: 5753 RVA: 0x00062728 File Offset: 0x00060928
		// (set) Token: 0x0600167A RID: 5754 RVA: 0x0000B44A File Offset: 0x0000964A
		public unsafe string function
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextMenuItemAttribute.NativeFieldInfoPtr_function);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextMenuItemAttribute.NativeFieldInfoPtr_function), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001352 RID: 4946
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001353 RID: 4947
		private static readonly IntPtr NativeFieldInfoPtr_function;

		// Token: 0x04001354 RID: 4948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
	}
}
