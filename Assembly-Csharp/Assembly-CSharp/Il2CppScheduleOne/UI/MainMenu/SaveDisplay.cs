using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence;
using UnityEngine;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020007FD RID: 2045
	public class SaveDisplay : MonoBehaviour
	{
		// Token: 0x0600C6DB RID: 50907 RVA: 0x00325A0C File Offset: 0x00323C0C
		// Note: this type is marked as 'beforefieldinit'.
		static SaveDisplay()
		{
			Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "SaveDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr);
			SaveDisplay.NativeFieldInfoPtr_Slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, "Slots");
			SaveDisplay.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100689049);
			SaveDisplay.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100689050);
			SaveDisplay.NativeMethodInfoPtr_SetDisplayedSave_Public_Void_Int32_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100689051);
			SaveDisplay.NativeMethodInfoPtr_RoundToDecimalPlaces_Private_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100689052);
			SaveDisplay.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100689053);
			SaveDisplay.NativeMethodInfoPtr_GetTimeLabel_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100689054);
			SaveDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr, 100689055);
		}

		// Token: 0x0600C6DC RID: 50908 RVA: 0x00325ADC File Offset: 0x00323CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328126, XrefRangeEnd = 328145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6DD RID: 50909 RVA: 0x00325B10 File Offset: 0x00323D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328145, XrefRangeEnd = 328153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6DE RID: 50910 RVA: 0x00325B44 File Offset: 0x00323D44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328230, RefRangeEnd = 328232, XrefRangeStart = 328153, XrefRangeEnd = 328230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedSave(int index, SaveInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_SetDisplayedSave_Public_Void_Int32_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6DF RID: 50911 RVA: 0x00325B94 File Offset: 0x00323D94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328238, RefRangeEnd = 328240, XrefRangeStart = 328232, XrefRangeEnd = 328238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float RoundToDecimalPlaces(float value, int decimalPlaces)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decimalPlaces;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_RoundToDecimalPlaces_Private_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C6E0 RID: 50912 RVA: 0x00325BEC File Offset: 0x00323DEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328240, RefRangeEnd = 328242, XrefRangeStart = 328240, XrefRangeEnd = 328240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(double value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C6E1 RID: 50913 RVA: 0x00325C2C File Offset: 0x00323E2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328249, RefRangeEnd = 328251, XrefRangeStart = 328242, XrefRangeEnd = 328249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTimeLabel(int hours)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hours;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr_GetTimeLabel_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600C6E2 RID: 50914 RVA: 0x00325C70 File Offset: 0x00323E70
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6E3 RID: 50915 RVA: 0x0005DE60 File Offset: 0x0005C060
		public SaveDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C59 RID: 15449
		// (get) Token: 0x0600C6E4 RID: 50916 RVA: 0x00325CAC File Offset: 0x00323EAC
		// (set) Token: 0x0600C6E5 RID: 50917 RVA: 0x0005DE69 File Offset: 0x0005C069
		public unsafe Il2CppReferenceArray<RectTransform> Slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveDisplay.NativeFieldInfoPtr_Slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveDisplay.NativeFieldInfoPtr_Slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400879B RID: 34715
		private static readonly IntPtr NativeFieldInfoPtr_Slots;

		// Token: 0x0400879C RID: 34716
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x0400879D RID: 34717
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x0400879E RID: 34718
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedSave_Public_Void_Int32_SaveInfo_0;

		// Token: 0x0400879F RID: 34719
		private static readonly IntPtr NativeMethodInfoPtr_RoundToDecimalPlaces_Private_Single_Single_Int32_0;

		// Token: 0x040087A0 RID: 34720
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0;

		// Token: 0x040087A1 RID: 34721
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeLabel_Private_String_Int32_0;

		// Token: 0x040087A2 RID: 34722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
