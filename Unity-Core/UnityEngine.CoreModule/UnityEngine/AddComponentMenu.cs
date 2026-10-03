using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000122 RID: 290
	public sealed class AddComponentMenu : Attribute
	{
		// Token: 0x06001766 RID: 5990 RVA: 0x00065450 File Offset: 0x00063650
		// Note: this type is marked as 'beforefieldinit'.
		static AddComponentMenu()
		{
			Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AddComponentMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr);
			AddComponentMenu.NativeFieldInfoPtr_m_AddComponentMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, "m_AddComponentMenu");
			AddComponentMenu.NativeFieldInfoPtr_m_Ordering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, "m_Ordering");
			AddComponentMenu.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, 100665753);
			AddComponentMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, 100665754);
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x000654D0 File Offset: 0x000636D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247086, XrefRangeEnd = 1247088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddComponentMenu(string menuName) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(menuName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddComponentMenu.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x0006551C File Offset: 0x0006371C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 583921, RefRangeEnd = 583926, XrefRangeStart = 583921, XrefRangeEnd = 583926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddComponentMenu(string menuName, int order) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(menuName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddComponentMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x0000BA56 File Offset: 0x00009C56
		public AddComponentMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x00065578 File Offset: 0x00063778
		// (set) Token: 0x0600176B RID: 5995 RVA: 0x0000BA5F File Offset: 0x00009C5F
		public unsafe string m_AddComponentMenu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddComponentMenu.NativeFieldInfoPtr_m_AddComponentMenu);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddComponentMenu.NativeFieldInfoPtr_m_AddComponentMenu), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x000655A0 File Offset: 0x000637A0
		// (set) Token: 0x0600176D RID: 5997 RVA: 0x0000BA7E File Offset: 0x00009C7E
		public unsafe int m_Ordering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddComponentMenu.NativeFieldInfoPtr_m_Ordering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddComponentMenu.NativeFieldInfoPtr_m_Ordering)) = value;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x0600176E RID: 5998 RVA: 0x000655C8 File Offset: 0x000637C8
		public string componentMenu
		{
			get
			{
				return this.m_AddComponentMenu;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x0600176F RID: 5999 RVA: 0x000655E0 File Offset: 0x000637E0
		public int componentOrder
		{
			get
			{
				return this.m_Ordering;
			}
		}

		// Token: 0x040013DA RID: 5082
		private static readonly IntPtr NativeFieldInfoPtr_m_AddComponentMenu;

		// Token: 0x040013DB RID: 5083
		private static readonly IntPtr NativeFieldInfoPtr_m_Ordering;

		// Token: 0x040013DC RID: 5084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040013DD RID: 5085
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;
	}
}
