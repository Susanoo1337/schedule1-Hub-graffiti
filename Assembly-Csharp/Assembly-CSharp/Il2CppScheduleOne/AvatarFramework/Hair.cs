using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x0200049F RID: 1183
	public class Hair : Accessory
	{
		// Token: 0x06006C61 RID: 27745 RVA: 0x001F1F5C File Offset: 0x001F015C
		// Note: this type is marked as 'beforefieldinit'.
		static Hair()
		{
			Il2CppClassPointerStore<Hair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "Hair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hair>.NativeClassPtr);
			Hair.NativeFieldInfoPtr__BlockedByHat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hair>.NativeClassPtr, "<BlockedByHat>k__BackingField");
			Hair.NativeFieldInfoPtr_hairToHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hair>.NativeClassPtr, "hairToHide");
			Hair.NativeMethodInfoPtr_get_BlockedByHat_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100677457);
			Hair.NativeMethodInfoPtr_set_BlockedByHat_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100677458);
			Hair.NativeMethodInfoPtr_SetBlockedByHat_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100677459);
			Hair.NativeMethodInfoPtr_BlockHair_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100677460);
			Hair.NativeMethodInfoPtr_UnBlockHair_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100677461);
			Hair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100677462);
		}

		// Token: 0x1700215E RID: 8542
		// (get) Token: 0x06006C62 RID: 27746 RVA: 0x001F202C File Offset: 0x001F022C
		// (set) Token: 0x06006C63 RID: 27747 RVA: 0x001F2068 File Offset: 0x001F0268
		public unsafe bool BlockedByHat
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hair.NativeMethodInfoPtr_get_BlockedByHat_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hair.NativeMethodInfoPtr_set_BlockedByHat_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006C64 RID: 27748 RVA: 0x001F20A8 File Offset: 0x001F02A8
		[CallerCount(0)]
		public unsafe void SetBlockedByHat(bool blocked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref blocked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hair.NativeMethodInfoPtr_SetBlockedByHat_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C65 RID: 27749 RVA: 0x001F20E8 File Offset: 0x001F02E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221194, XrefRangeEnd = 221196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BlockHair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hair.NativeMethodInfoPtr_BlockHair_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C66 RID: 27750 RVA: 0x001F2124 File Offset: 0x001F0324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221196, XrefRangeEnd = 221198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnBlockHair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hair.NativeMethodInfoPtr_UnBlockHair_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C67 RID: 27751 RVA: 0x001F2160 File Offset: 0x001F0360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hair() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hair>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C68 RID: 27752 RVA: 0x000331C3 File Offset: 0x000313C3
		public Hair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700215C RID: 8540
		// (get) Token: 0x06006C69 RID: 27753 RVA: 0x001F219C File Offset: 0x001F039C
		// (set) Token: 0x06006C6A RID: 27754 RVA: 0x000331CC File Offset: 0x000313CC
		public unsafe bool _BlockedByHat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hair.NativeFieldInfoPtr__BlockedByHat_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hair.NativeFieldInfoPtr__BlockedByHat_k__BackingField)) = value;
			}
		}

		// Token: 0x1700215D RID: 8541
		// (get) Token: 0x06006C6B RID: 27755 RVA: 0x001F21C4 File Offset: 0x001F03C4
		// (set) Token: 0x06006C6C RID: 27756 RVA: 0x000331E7 File Offset: 0x000313E7
		public unsafe Il2CppReferenceArray<GameObject> hairToHide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hair.NativeFieldInfoPtr_hairToHide);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hair.NativeFieldInfoPtr_hairToHide), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004A83 RID: 19075
		private static readonly IntPtr NativeFieldInfoPtr__BlockedByHat_k__BackingField;

		// Token: 0x04004A84 RID: 19076
		private static readonly IntPtr NativeFieldInfoPtr_hairToHide;

		// Token: 0x04004A85 RID: 19077
		private static readonly IntPtr NativeMethodInfoPtr_get_BlockedByHat_Public_get_Boolean_0;

		// Token: 0x04004A86 RID: 19078
		private static readonly IntPtr NativeMethodInfoPtr_set_BlockedByHat_Protected_set_Void_Boolean_0;

		// Token: 0x04004A87 RID: 19079
		private static readonly IntPtr NativeMethodInfoPtr_SetBlockedByHat_Public_Void_Boolean_0;

		// Token: 0x04004A88 RID: 19080
		private static readonly IntPtr NativeMethodInfoPtr_BlockHair_Protected_Virtual_New_Void_0;

		// Token: 0x04004A89 RID: 19081
		private static readonly IntPtr NativeMethodInfoPtr_UnBlockHair_Protected_Virtual_New_Void_0;

		// Token: 0x04004A8A RID: 19082
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
