using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000769 RID: 1897
	public class RectTransformLerpList : RectTransformLerp
	{
		// Token: 0x0600B8BD RID: 47293 RVA: 0x002FAAB4 File Offset: 0x002F8CB4
		// Note: this type is marked as 'beforefieldinit'.
		static RectTransformLerpList()
		{
			Il2CppClassPointerStore<RectTransformLerpList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "RectTransformLerpList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectTransformLerpList>.NativeClassPtr);
			RectTransformLerpList.NativeFieldInfoPtr__targetPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransformLerpList>.NativeClassPtr, "_targetPositions");
			RectTransformLerpList.NativeFieldInfoPtr__scaleDurationWithDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransformLerpList>.NativeClassPtr, "_scaleDurationWithDistance");
			RectTransformLerpList.NativeFieldInfoPtr__lerpLocalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransformLerpList>.NativeClassPtr, "_lerpLocalPosition");
			RectTransformLerpList.NativeFieldInfoPtr__lerpScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransformLerpList>.NativeClassPtr, "_lerpScale");
			RectTransformLerpList.NativeFieldInfoPtr__longestDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransformLerpList>.NativeClassPtr, "_longestDistance");
			RectTransformLerpList.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformLerpList>.NativeClassPtr, 100687465);
			RectTransformLerpList.NativeMethodInfoPtr_LerpTo_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformLerpList>.NativeClassPtr, 100687466);
			RectTransformLerpList.NativeMethodInfoPtr_LerpTo_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformLerpList>.NativeClassPtr, 100687467);
			RectTransformLerpList.NativeMethodInfoPtr_GetDurationMultiplier_Private_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformLerpList>.NativeClassPtr, 100687468);
			RectTransformLerpList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransformLerpList>.NativeClassPtr, 100687469);
		}

		// Token: 0x0600B8BE RID: 47294 RVA: 0x002FABAC File Offset: 0x002F8DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309330, XrefRangeEnd = 309339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectTransformLerpList.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8BF RID: 47295 RVA: 0x002FABE8 File Offset: 0x002F8DE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309363, RefRangeEnd = 309364, XrefRangeStart = 309339, XrefRangeEnd = 309363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpTo(int index, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformLerpList.NativeMethodInfoPtr_LerpTo_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8C0 RID: 47296 RVA: 0x002FAC34 File Offset: 0x002F8E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309364, XrefRangeEnd = 309365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpTo(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformLerpList.NativeMethodInfoPtr_LerpTo_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8C1 RID: 47297 RVA: 0x002FAC74 File Offset: 0x002F8E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309365, XrefRangeEnd = 309372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetDurationMultiplier(Vector2 start, Vector2 end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformLerpList.NativeMethodInfoPtr_GetDurationMultiplier_Private_Single_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B8C2 RID: 47298 RVA: 0x002FACCC File Offset: 0x002F8ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309372, XrefRangeEnd = 309373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectTransformLerpList() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectTransformLerpList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransformLerpList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B8C3 RID: 47299 RVA: 0x00055E9A File Offset: 0x0005409A
		public RectTransformLerpList(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037CD RID: 14285
		// (get) Token: 0x0600B8C4 RID: 47300 RVA: 0x002FAD08 File Offset: 0x002F8F08
		// (set) Token: 0x0600B8C5 RID: 47301 RVA: 0x00055EA3 File Offset: 0x000540A3
		public unsafe Il2CppReferenceArray<RectTransform> _targetPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformLerpList.NativeFieldInfoPtr__targetPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformLerpList.NativeFieldInfoPtr__targetPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037CE RID: 14286
		// (get) Token: 0x0600B8C6 RID: 47302 RVA: 0x002FAD38 File Offset: 0x002F8F38
		// (set) Token: 0x0600B8C7 RID: 47303 RVA: 0x00055EC2 File Offset: 0x000540C2
		public unsafe bool _scaleDurationWithDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformLerpList.NativeFieldInfoPtr__scaleDurationWithDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformLerpList.NativeFieldInfoPtr__scaleDurationWithDistance)) = value;
			}
		}

		// Token: 0x170037CF RID: 14287
		// (get) Token: 0x0600B8C8 RID: 47304 RVA: 0x002FAD60 File Offset: 0x002F8F60
		// (set) Token: 0x0600B8C9 RID: 47305 RVA: 0x00055EDD File Offset: 0x000540DD
		public unsafe bool _lerpLocalPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformLerpList.NativeFieldInfoPtr__lerpLocalPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformLerpList.NativeFieldInfoPtr__lerpLocalPosition)) = value;
			}
		}

		// Token: 0x170037D0 RID: 14288
		// (get) Token: 0x0600B8CA RID: 47306 RVA: 0x002FAD88 File Offset: 0x002F8F88
		// (set) Token: 0x0600B8CB RID: 47307 RVA: 0x00055EF8 File Offset: 0x000540F8
		public unsafe bool _lerpScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformLerpList.NativeFieldInfoPtr__lerpScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformLerpList.NativeFieldInfoPtr__lerpScale)) = value;
			}
		}

		// Token: 0x170037D1 RID: 14289
		// (get) Token: 0x0600B8CC RID: 47308 RVA: 0x002FADB0 File Offset: 0x002F8FB0
		// (set) Token: 0x0600B8CD RID: 47309 RVA: 0x00055F13 File Offset: 0x00054113
		public unsafe float _longestDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformLerpList.NativeFieldInfoPtr__longestDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectTransformLerpList.NativeFieldInfoPtr__longestDistance)) = value;
			}
		}

		// Token: 0x04007ECC RID: 32460
		private static readonly IntPtr NativeFieldInfoPtr__targetPositions;

		// Token: 0x04007ECD RID: 32461
		private static readonly IntPtr NativeFieldInfoPtr__scaleDurationWithDistance;

		// Token: 0x04007ECE RID: 32462
		private static readonly IntPtr NativeFieldInfoPtr__lerpLocalPosition;

		// Token: 0x04007ECF RID: 32463
		private static readonly IntPtr NativeFieldInfoPtr__lerpScale;

		// Token: 0x04007ED0 RID: 32464
		private static readonly IntPtr NativeFieldInfoPtr__longestDistance;

		// Token: 0x04007ED1 RID: 32465
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007ED2 RID: 32466
		private static readonly IntPtr NativeMethodInfoPtr_LerpTo_Public_Void_Int32_Single_0;

		// Token: 0x04007ED3 RID: 32467
		private static readonly IntPtr NativeMethodInfoPtr_LerpTo_Public_Void_Int32_0;

		// Token: 0x04007ED4 RID: 32468
		private static readonly IntPtr NativeMethodInfoPtr_GetDurationMultiplier_Private_Single_Vector2_Vector2_0;

		// Token: 0x04007ED5 RID: 32469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
