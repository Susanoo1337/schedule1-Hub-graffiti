using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000821 RID: 2081
	public class CharacterCreatorToggle : CharacterCreatorField<int>
	{
		// Token: 0x0600CA37 RID: 51767 RVA: 0x0032FE38 File Offset: 0x0032E038
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreatorToggle()
		{
			Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "CharacterCreatorToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr);
			CharacterCreatorToggle.NativeFieldInfoPtr_Button1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, "Button1");
			CharacterCreatorToggle.NativeFieldInfoPtr_Button2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, "Button2");
			CharacterCreatorToggle.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, 100689383);
			CharacterCreatorToggle.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, 100689384);
			CharacterCreatorToggle.NativeMethodInfoPtr_OnButton1_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, 100689385);
			CharacterCreatorToggle.NativeMethodInfoPtr_OnButton2_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, 100689386);
			CharacterCreatorToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, 100689387);
		}

		// Token: 0x0600CA38 RID: 51768 RVA: 0x0032FEF4 File Offset: 0x0032E0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332251, XrefRangeEnd = 332265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorToggle.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA39 RID: 51769 RVA: 0x0032FF30 File Offset: 0x0032E130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332265, XrefRangeEnd = 332272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorToggle.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA3A RID: 51770 RVA: 0x0032FF6C File Offset: 0x0032E16C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332272, XrefRangeEnd = 332273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnButton1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorToggle.NativeMethodInfoPtr_OnButton1_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA3B RID: 51771 RVA: 0x0032FFA0 File Offset: 0x0032E1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332273, XrefRangeEnd = 332274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnButton2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorToggle.NativeMethodInfoPtr_OnButton2_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA3C RID: 51772 RVA: 0x0032FFD4 File Offset: 0x0032E1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332274, XrefRangeEnd = 332277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreatorToggle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA3D RID: 51773 RVA: 0x0005FDE1 File Offset: 0x0005DFE1
		public CharacterCreatorToggle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003D6C RID: 15724
		// (get) Token: 0x0600CA3E RID: 51774 RVA: 0x00330010 File Offset: 0x0032E210
		// (set) Token: 0x0600CA3F RID: 51775 RVA: 0x0005FDEA File Offset: 0x0005DFEA
		public unsafe Button Button1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorToggle.NativeFieldInfoPtr_Button1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorToggle.NativeFieldInfoPtr_Button1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D6D RID: 15725
		// (get) Token: 0x0600CA40 RID: 51776 RVA: 0x00330040 File Offset: 0x0032E240
		// (set) Token: 0x0600CA41 RID: 51777 RVA: 0x0005FE09 File Offset: 0x0005E009
		public unsafe Button Button2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorToggle.NativeFieldInfoPtr_Button2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorToggle.NativeFieldInfoPtr_Button2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040089B4 RID: 35252
		private static readonly IntPtr NativeFieldInfoPtr_Button1;

		// Token: 0x040089B5 RID: 35253
		private static readonly IntPtr NativeFieldInfoPtr_Button2;

		// Token: 0x040089B6 RID: 35254
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040089B7 RID: 35255
		private static readonly IntPtr NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0;

		// Token: 0x040089B8 RID: 35256
		private static readonly IntPtr NativeMethodInfoPtr_OnButton1_Public_Void_0;

		// Token: 0x040089B9 RID: 35257
		private static readonly IntPtr NativeMethodInfoPtr_OnButton2_Public_Void_0;

		// Token: 0x040089BA RID: 35258
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
