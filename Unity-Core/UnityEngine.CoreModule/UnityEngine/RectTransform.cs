using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200016E RID: 366
	public sealed class RectTransform : Transform
	{
		// Token: 0x06001BC1 RID: 7105 RVA: 0x000737D4 File Offset: 0x000719D4
		// Note: this type is marked as 'beforefieldinit'.
		static RectTransform()
		{
			Il2CppClassPointerStore<RectTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RectTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectTransform>.NativeClassPtr);
			RectTransform.NativeFieldInfoPtr_reapplyDrivenProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, "reapplyDrivenProperties");
			RectTransform.NativeMethodInfoPtr_add_reapplyDrivenProperties_Public_Static_add_Void_ReapplyDrivenProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666259);
			RectTransform.NativeMethodInfoPtr_remove_reapplyDrivenProperties_Public_Static_rem_Void_ReapplyDrivenProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666260);
			RectTransform.NativeMethodInfoPtr_get_rect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666261);
			RectTransform.NativeMethodInfoPtr_get_anchorMin_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666262);
			RectTransform.NativeMethodInfoPtr_set_anchorMin_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666263);
			RectTransform.NativeMethodInfoPtr_get_anchorMax_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666264);
			RectTransform.NativeMethodInfoPtr_set_anchorMax_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666265);
			RectTransform.NativeMethodInfoPtr_get_anchoredPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666266);
			RectTransform.NativeMethodInfoPtr_set_anchoredPosition_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666267);
			RectTransform.NativeMethodInfoPtr_get_sizeDelta_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666268);
			RectTransform.NativeMethodInfoPtr_set_sizeDelta_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666269);
			RectTransform.NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666270);
			RectTransform.NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666271);
			RectTransform.NativeMethodInfoPtr_set_anchoredPosition3D_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666272);
			RectTransform.NativeMethodInfoPtr_get_offsetMin_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666273);
			RectTransform.NativeMethodInfoPtr_set_offsetMin_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666274);
			RectTransform.NativeMethodInfoPtr_get_offsetMax_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666275);
			RectTransform.NativeMethodInfoPtr_set_offsetMax_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666276);
			RectTransform.NativeMethodInfoPtr_GetLocalCorners_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666277);
			RectTransform.NativeMethodInfoPtr_GetWorldCorners_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666278);
			RectTransform.NativeMethodInfoPtr_SetSizeWithCurrentAnchors_Public_Void_Axis_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666279);
			RectTransform.NativeMethodInfoPtr_SendReapplyDrivenProperties_Internal_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666280);
			RectTransform.NativeMethodInfoPtr_GetParentSize_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666281);
			RectTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666282);
			RectTransform.NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666283);
			RectTransform.NativeMethodInfoPtr_get_anchorMin_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666284);
			RectTransform.NativeMethodInfoPtr_set_anchorMin_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666285);
			RectTransform.NativeMethodInfoPtr_get_anchorMax_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666286);
			RectTransform.NativeMethodInfoPtr_set_anchorMax_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666287);
			RectTransform.NativeMethodInfoPtr_get_anchoredPosition_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666288);
			RectTransform.NativeMethodInfoPtr_set_anchoredPosition_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666289);
			RectTransform.NativeMethodInfoPtr_get_sizeDelta_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666290);
			RectTransform.NativeMethodInfoPtr_set_sizeDelta_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666291);
			RectTransform.NativeMethodInfoPtr_get_pivot_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666292);
			RectTransform.NativeMethodInfoPtr_set_pivot_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666293);
			RectTransform.get_drivenByObjectDelegateField = IL2CPP.ResolveICall<RectTransform.get_drivenByObjectDelegate>("UnityEngine.RectTransform::get_drivenByObject");
			RectTransform.set_drivenByObjectDelegateField = IL2CPP.ResolveICall<RectTransform.set_drivenByObjectDelegate>("UnityEngine.RectTransform::set_drivenByObject");
			RectTransform.get_drivenPropertiesDelegateField = IL2CPP.ResolveICall<RectTransform.get_drivenPropertiesDelegate>("UnityEngine.RectTransform::get_drivenProperties");
			RectTransform.set_drivenPropertiesDelegateField = IL2CPP.ResolveICall<RectTransform.set_drivenPropertiesDelegate>("UnityEngine.RectTransform::set_drivenProperties");
			RectTransform.ForceUpdateRectTransformsDelegateField = IL2CPP.ResolveICall<RectTransform.ForceUpdateRectTransformsDelegate>("UnityEngine.RectTransform::ForceUpdateRectTransforms");
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x00073B20 File Offset: 0x00071D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273649, XrefRangeEnd = 1273656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_add_reapplyDrivenProperties_Public_Static_add_Void_ReapplyDrivenProperties_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x00073B58 File Offset: 0x00071D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273656, XrefRangeEnd = 1273663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_remove_reapplyDrivenProperties_Public_Static_rem_Void_ReapplyDrivenProperties_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x00073B90 File Offset: 0x00071D90
		public unsafe Rect rect
		{
			[CallerCount(123)]
			[CachedScanResults(RefRangeStart = 1273665, RefRangeEnd = 1273788, XrefRangeStart = 1273663, XrefRangeEnd = 1273665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_rect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x00073BCC File Offset: 0x00071DCC
		// (set) Token: 0x06001BC6 RID: 7110 RVA: 0x00073C08 File Offset: 0x00071E08
		public unsafe Vector2 anchorMin
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 1273790, RefRangeEnd = 1273811, XrefRangeStart = 1273788, XrefRangeEnd = 1273790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchorMin_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(67)]
			[CachedScanResults(RefRangeStart = 1273813, RefRangeEnd = 1273880, XrefRangeStart = 1273811, XrefRangeEnd = 1273813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchorMin_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x00073C48 File Offset: 0x00071E48
		// (set) Token: 0x06001BC8 RID: 7112 RVA: 0x00073C84 File Offset: 0x00071E84
		public unsafe Vector2 anchorMax
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 1273882, RefRangeEnd = 1273900, XrefRangeStart = 1273880, XrefRangeEnd = 1273882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchorMax_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(69)]
			[CachedScanResults(RefRangeStart = 1273902, RefRangeEnd = 1273971, XrefRangeStart = 1273900, XrefRangeEnd = 1273902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchorMax_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001BC9 RID: 7113 RVA: 0x00073CC4 File Offset: 0x00071EC4
		// (set) Token: 0x06001BCA RID: 7114 RVA: 0x00073D00 File Offset: 0x00071F00
		public unsafe Vector2 anchoredPosition
		{
			[CallerCount(124)]
			[CachedScanResults(RefRangeStart = 1273973, RefRangeEnd = 1274097, XrefRangeStart = 1273971, XrefRangeEnd = 1273973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchoredPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(128)]
			[CachedScanResults(RefRangeStart = 1274099, RefRangeEnd = 1274227, XrefRangeStart = 1274097, XrefRangeEnd = 1274099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchoredPosition_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001BCB RID: 7115 RVA: 0x00073D40 File Offset: 0x00071F40
		// (set) Token: 0x06001BCC RID: 7116 RVA: 0x00073D7C File Offset: 0x00071F7C
		public unsafe Vector2 sizeDelta
		{
			[CallerCount(93)]
			[CachedScanResults(RefRangeStart = 1274229, RefRangeEnd = 1274322, XrefRangeStart = 1274227, XrefRangeEnd = 1274229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_sizeDelta_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(95)]
			[CachedScanResults(RefRangeStart = 1274324, RefRangeEnd = 1274419, XrefRangeStart = 1274322, XrefRangeEnd = 1274324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_sizeDelta_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001BCD RID: 7117 RVA: 0x00073DBC File Offset: 0x00071FBC
		// (set) Token: 0x06001BCE RID: 7118 RVA: 0x00073DF8 File Offset: 0x00071FF8
		public unsafe Vector2 pivot
		{
			[CallerCount(47)]
			[CachedScanResults(RefRangeStart = 1274421, RefRangeEnd = 1274468, XrefRangeStart = 1274419, XrefRangeEnd = 1274421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 1274470, RefRangeEnd = 1274502, XrefRangeStart = 1274468, XrefRangeEnd = 1274470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x000743DC File Offset: 0x000725DC
		// (set) Token: 0x06001BCF RID: 7119 RVA: 0x00073E38 File Offset: 0x00072038
		public unsafe Vector3 anchoredPosition3D
		{
			get
			{
				Vector2 anchoredPosition = this.anchoredPosition;
				return new Vector3(anchoredPosition.x, anchoredPosition.y, base.localPosition.z);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1274508, RefRangeEnd = 1274509, XrefRangeStart = 1274502, XrefRangeEnd = 1274508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchoredPosition3D_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x00073E78 File Offset: 0x00072078
		// (set) Token: 0x06001BD1 RID: 7121 RVA: 0x00073EB4 File Offset: 0x000720B4
		public unsafe Vector2 offsetMin
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1274515, RefRangeEnd = 1274520, XrefRangeStart = 1274509, XrefRangeEnd = 1274515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_offsetMin_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 1274538, RefRangeEnd = 1274555, XrefRangeStart = 1274520, XrefRangeEnd = 1274538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_offsetMin_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x00073EF4 File Offset: 0x000720F4
		// (set) Token: 0x06001BD3 RID: 7123 RVA: 0x00073F30 File Offset: 0x00072130
		public unsafe Vector2 offsetMax
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1274563, RefRangeEnd = 1274566, XrefRangeStart = 1274555, XrefRangeEnd = 1274563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_offsetMax_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1274584, RefRangeEnd = 1274596, XrefRangeStart = 1274566, XrefRangeEnd = 1274584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_offsetMax_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x00073F70 File Offset: 0x00072170
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1274600, RefRangeEnd = 1274602, XrefRangeStart = 1274596, XrefRangeEnd = 1274600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetLocalCorners(Il2CppStructArray<Vector3> fourCornersArray)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(fourCornersArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_GetLocalCorners_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x00073FB4 File Offset: 0x000721B4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1274618, RefRangeEnd = 1274632, XrefRangeStart = 1274602, XrefRangeEnd = 1274618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetWorldCorners(Il2CppStructArray<Vector3> fourCornersArray)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(fourCornersArray);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_GetWorldCorners_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x00073FF8 File Offset: 0x000721F8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1274662, RefRangeEnd = 1274669, XrefRangeStart = 1274632, XrefRangeEnd = 1274662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSizeWithCurrentAnchors(RectTransform.Axis axis, float size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref axis;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_SetSizeWithCurrentAnchors_Public_Void_Axis_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x00074044 File Offset: 0x00072244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274669, XrefRangeEnd = 1274671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendReapplyDrivenProperties(RectTransform driven)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(driven);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_SendReapplyDrivenProperties_Internal_Static_Void_RectTransform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x0007407C File Offset: 0x0007227C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274671, XrefRangeEnd = 1274687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetParentSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_GetParentSize_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x000740B8 File Offset: 0x000722B8
		[CallerCount(1012)]
		[CachedScanResults(RefRangeStart = 1247777, RefRangeEnd = 1248789, XrefRangeStart = 1247777, XrefRangeEnd = 1248789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectTransform() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectTransform>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x000740F4 File Offset: 0x000722F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274687, XrefRangeEnd = 1274689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_rect_Injected(out Rect ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x00074134 File Offset: 0x00072334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274689, XrefRangeEnd = 1274691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_anchorMin_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchorMin_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x00074174 File Offset: 0x00072374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274691, XrefRangeEnd = 1274693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_anchorMin_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchorMin_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x000741B4 File Offset: 0x000723B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274693, XrefRangeEnd = 1274695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_anchorMax_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchorMax_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x000741F4 File Offset: 0x000723F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274695, XrefRangeEnd = 1274697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_anchorMax_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchorMax_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x00074234 File Offset: 0x00072434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274697, XrefRangeEnd = 1274699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_anchoredPosition_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchoredPosition_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x00074274 File Offset: 0x00072474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274699, XrefRangeEnd = 1274701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_anchoredPosition_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchoredPosition_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x000742B4 File Offset: 0x000724B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274701, XrefRangeEnd = 1274703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_sizeDelta_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_sizeDelta_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x000742F4 File Offset: 0x000724F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274703, XrefRangeEnd = 1274705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_sizeDelta_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_sizeDelta_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x00074334 File Offset: 0x00072534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274705, XrefRangeEnd = 1274707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_pivot_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_pivot_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x00074374 File Offset: 0x00072574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274707, XrefRangeEnd = 1274709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_pivot_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_pivot_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x0000D2E9 File Offset: 0x0000B4E9
		public RectTransform(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x000743B4 File Offset: 0x000725B4
		// (set) Token: 0x06001BE7 RID: 7143 RVA: 0x0000D2F2 File Offset: 0x0000B4F2
		public unsafe static RectTransform.ReapplyDrivenProperties reapplyDrivenProperties
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RectTransform.NativeFieldInfoPtr_reapplyDrivenProperties, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform.ReapplyDrivenProperties>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RectTransform.NativeFieldInfoPtr_reapplyDrivenProperties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x00074414 File Offset: 0x00072614
		// (set) Token: 0x06001BEA RID: 7146 RVA: 0x0000D304 File Offset: 0x0000B504
		public Object drivenByObject
		{
			get
			{
				IntPtr intPtr = RectTransform.get_drivenByObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				RectTransform.set_drivenByObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001BEB RID: 7147 RVA: 0x0000D31C File Offset: 0x0000B51C
		// (set) Token: 0x06001BEC RID: 7148 RVA: 0x0000D32E File Offset: 0x0000B52E
		public DrivenTransformProperties drivenProperties
		{
			get
			{
				return RectTransform.get_drivenPropertiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RectTransform.set_drivenPropertiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x0000D341 File Offset: 0x0000B541
		public void ForceUpdateRectTransforms()
		{
			RectTransform.ForceUpdateRectTransformsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x00074440 File Offset: 0x00072640
		public void SetInsetAndSizeFromParentEdge(RectTransform.Edge edge, float inset, float size)
		{
			int index = (edge == RectTransform.Edge.Top || edge == RectTransform.Edge.Bottom) ? 1 : 0;
			bool flag = edge == RectTransform.Edge.Top || edge == RectTransform.Edge.Right;
			float value = (float)(flag ? 1 : 0);
			Vector2 vector = this.anchorMin;
			vector[index] = value;
			this.anchorMin = vector;
			vector = this.anchorMax;
			vector[index] = value;
			this.anchorMax = vector;
			Vector2 sizeDelta = this.sizeDelta;
			sizeDelta[index] = size;
			this.sizeDelta = sizeDelta;
			Vector2 anchoredPosition = this.anchoredPosition;
			anchoredPosition[index] = (flag ? (-inset - size * (1f - this.pivot[index])) : (inset + size * this.pivot[index]));
			this.anchoredPosition = anchoredPosition;
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x0007450C File Offset: 0x0007270C
		public Rect GetRectInParentSpace()
		{
			Rect rect = this.rect;
			Vector2 vector = this.offsetMin + Vector2.Scale(this.pivot, rect.size);
			bool flag = base.transform.parent;
			if (flag)
			{
				RectTransform component = base.transform.parent.GetComponent<RectTransform>();
				bool flag2 = component;
				if (flag2)
				{
					vector += Vector2.Scale(this.anchorMin, component.rect.size);
				}
			}
			rect.x += vector.x;
			rect.y += vector.y;
			return rect;
		}

		// Token: 0x040016EC RID: 5868
		private static readonly IntPtr NativeFieldInfoPtr_reapplyDrivenProperties;

		// Token: 0x040016ED RID: 5869
		private static readonly IntPtr NativeMethodInfoPtr_add_reapplyDrivenProperties_Public_Static_add_Void_ReapplyDrivenProperties_0;

		// Token: 0x040016EE RID: 5870
		private static readonly IntPtr NativeMethodInfoPtr_remove_reapplyDrivenProperties_Public_Static_rem_Void_ReapplyDrivenProperties_0;

		// Token: 0x040016EF RID: 5871
		private static readonly IntPtr NativeMethodInfoPtr_get_rect_Public_get_Rect_0;

		// Token: 0x040016F0 RID: 5872
		private static readonly IntPtr NativeMethodInfoPtr_get_anchorMin_Public_get_Vector2_0;

		// Token: 0x040016F1 RID: 5873
		private static readonly IntPtr NativeMethodInfoPtr_set_anchorMin_Public_set_Void_Vector2_0;

		// Token: 0x040016F2 RID: 5874
		private static readonly IntPtr NativeMethodInfoPtr_get_anchorMax_Public_get_Vector2_0;

		// Token: 0x040016F3 RID: 5875
		private static readonly IntPtr NativeMethodInfoPtr_set_anchorMax_Public_set_Void_Vector2_0;

		// Token: 0x040016F4 RID: 5876
		private static readonly IntPtr NativeMethodInfoPtr_get_anchoredPosition_Public_get_Vector2_0;

		// Token: 0x040016F5 RID: 5877
		private static readonly IntPtr NativeMethodInfoPtr_set_anchoredPosition_Public_set_Void_Vector2_0;

		// Token: 0x040016F6 RID: 5878
		private static readonly IntPtr NativeMethodInfoPtr_get_sizeDelta_Public_get_Vector2_0;

		// Token: 0x040016F7 RID: 5879
		private static readonly IntPtr NativeMethodInfoPtr_set_sizeDelta_Public_set_Void_Vector2_0;

		// Token: 0x040016F8 RID: 5880
		private static readonly IntPtr NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0;

		// Token: 0x040016F9 RID: 5881
		private static readonly IntPtr NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0;

		// Token: 0x040016FA RID: 5882
		private static readonly IntPtr NativeMethodInfoPtr_set_anchoredPosition3D_Public_set_Void_Vector3_0;

		// Token: 0x040016FB RID: 5883
		private static readonly IntPtr NativeMethodInfoPtr_get_offsetMin_Public_get_Vector2_0;

		// Token: 0x040016FC RID: 5884
		private static readonly IntPtr NativeMethodInfoPtr_set_offsetMin_Public_set_Void_Vector2_0;

		// Token: 0x040016FD RID: 5885
		private static readonly IntPtr NativeMethodInfoPtr_get_offsetMax_Public_get_Vector2_0;

		// Token: 0x040016FE RID: 5886
		private static readonly IntPtr NativeMethodInfoPtr_set_offsetMax_Public_set_Void_Vector2_0;

		// Token: 0x040016FF RID: 5887
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalCorners_Public_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04001700 RID: 5888
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldCorners_Public_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04001701 RID: 5889
		private static readonly IntPtr NativeMethodInfoPtr_SetSizeWithCurrentAnchors_Public_Void_Axis_Single_0;

		// Token: 0x04001702 RID: 5890
		private static readonly IntPtr NativeMethodInfoPtr_SendReapplyDrivenProperties_Internal_Static_Void_RectTransform_0;

		// Token: 0x04001703 RID: 5891
		private static readonly IntPtr NativeMethodInfoPtr_GetParentSize_Private_Vector2_0;

		// Token: 0x04001704 RID: 5892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001705 RID: 5893
		private static readonly IntPtr NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0;

		// Token: 0x04001706 RID: 5894
		private static readonly IntPtr NativeMethodInfoPtr_get_anchorMin_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04001707 RID: 5895
		private static readonly IntPtr NativeMethodInfoPtr_set_anchorMin_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04001708 RID: 5896
		private static readonly IntPtr NativeMethodInfoPtr_get_anchorMax_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04001709 RID: 5897
		private static readonly IntPtr NativeMethodInfoPtr_set_anchorMax_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x0400170A RID: 5898
		private static readonly IntPtr NativeMethodInfoPtr_get_anchoredPosition_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x0400170B RID: 5899
		private static readonly IntPtr NativeMethodInfoPtr_set_anchoredPosition_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x0400170C RID: 5900
		private static readonly IntPtr NativeMethodInfoPtr_get_sizeDelta_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x0400170D RID: 5901
		private static readonly IntPtr NativeMethodInfoPtr_set_sizeDelta_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x0400170E RID: 5902
		private static readonly IntPtr NativeMethodInfoPtr_get_pivot_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x0400170F RID: 5903
		private static readonly IntPtr NativeMethodInfoPtr_set_pivot_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04001710 RID: 5904
		private static readonly RectTransform.get_drivenByObjectDelegate get_drivenByObjectDelegateField;

		// Token: 0x04001711 RID: 5905
		private static readonly RectTransform.set_drivenByObjectDelegate set_drivenByObjectDelegateField;

		// Token: 0x04001712 RID: 5906
		private static readonly RectTransform.get_drivenPropertiesDelegate get_drivenPropertiesDelegateField;

		// Token: 0x04001713 RID: 5907
		private static readonly RectTransform.set_drivenPropertiesDelegate set_drivenPropertiesDelegateField;

		// Token: 0x04001714 RID: 5908
		private static readonly RectTransform.ForceUpdateRectTransformsDelegate ForceUpdateRectTransformsDelegateField;

		// Token: 0x02000975 RID: 2421
		[OriginalName("UnityEngine.CoreModule.dll", "", "Axis")]
		public enum Axis
		{
			// Token: 0x04002B5A RID: 11098
			Horizontal,
			// Token: 0x04002B5B RID: 11099
			Vertical
		}

		// Token: 0x02000976 RID: 2422
		public sealed class ReapplyDrivenProperties : MulticastDelegate
		{
			// Token: 0x06003B61 RID: 15201 RVA: 0x00015FF7 File Offset: 0x000141F7
			// Note: this type is marked as 'beforefieldinit'.
			static ReapplyDrivenProperties()
			{
				Il2CppClassPointerStore<RectTransform.ReapplyDrivenProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, "ReapplyDrivenProperties");
				RectTransform.ReapplyDrivenProperties.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform.ReapplyDrivenProperties>.NativeClassPtr, 100666294);
				RectTransform.ReapplyDrivenProperties.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform.ReapplyDrivenProperties>.NativeClassPtr, 100666295);
			}

			// Token: 0x06003B62 RID: 15202 RVA: 0x000B3078 File Offset: 0x000B1278
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 73307, RefRangeEnd = 73313, XrefRangeStart = 73307, XrefRangeEnd = 73313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReapplyDrivenProperties(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectTransform.ReapplyDrivenProperties>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.ReapplyDrivenProperties.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B63 RID: 15203 RVA: 0x000B30D4 File Offset: 0x000B12D4
			[CallerCount(0)]
			public unsafe void Invoke(RectTransform driven)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(driven);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.ReapplyDrivenProperties.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B64 RID: 15204 RVA: 0x00016035 File Offset: 0x00014235
			public ReapplyDrivenProperties(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003B65 RID: 15205 RVA: 0x0001603E File Offset: 0x0001423E
			public static implicit operator RectTransform.ReapplyDrivenProperties(Action<RectTransform> A_0)
			{
				return DelegateSupport.ConvertDelegate<RectTransform.ReapplyDrivenProperties>(A_0);
			}

			// Token: 0x06003B66 RID: 15206 RVA: 0x00016046 File Offset: 0x00014246
			public static RectTransform.ReapplyDrivenProperties operator +(RectTransform.ReapplyDrivenProperties A_0, RectTransform.ReapplyDrivenProperties A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RectTransform.ReapplyDrivenProperties>();
			}

			// Token: 0x06003B67 RID: 15207 RVA: 0x00016054 File Offset: 0x00014254
			public static RectTransform.ReapplyDrivenProperties operator -(RectTransform.ReapplyDrivenProperties A_0, RectTransform.ReapplyDrivenProperties A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<RectTransform.ReapplyDrivenProperties>();
				}
				return result;
			}

			// Token: 0x04002B5C RID: 11100
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B5D RID: 11101
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RectTransform_0;
		}

		// Token: 0x02000977 RID: 2423
		public enum Edge
		{
			// Token: 0x04002B5F RID: 11103
			Left,
			// Token: 0x04002B60 RID: 11104
			Right,
			// Token: 0x04002B61 RID: 11105
			Top,
			// Token: 0x04002B62 RID: 11106
			Bottom
		}

		// Token: 0x02000978 RID: 2424
		// (Invoke) Token: 0x06003B69 RID: 15209
		private delegate IntPtr get_drivenByObjectDelegate(IntPtr @this);

		// Token: 0x02000979 RID: 2425
		// (Invoke) Token: 0x06003B6B RID: 15211
		private delegate void set_drivenByObjectDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200097A RID: 2426
		// (Invoke) Token: 0x06003B6D RID: 15213
		private delegate DrivenTransformProperties get_drivenPropertiesDelegate(IntPtr @this);

		// Token: 0x0200097B RID: 2427
		// (Invoke) Token: 0x06003B6F RID: 15215
		private delegate void set_drivenPropertiesDelegate(IntPtr @this, DrivenTransformProperties value);

		// Token: 0x0200097C RID: 2428
		// (Invoke) Token: 0x06003B71 RID: 15217
		private delegate void ForceUpdateRectTransformsDelegate(IntPtr @this);
	}
}
