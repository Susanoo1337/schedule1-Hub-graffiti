using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002BD RID: 701
	public class MapPositionUtility : Singleton<MapPositionUtility>
	{
		// Token: 0x06003664 RID: 13924 RVA: 0x0013007C File Offset: 0x0012E27C
		// Note: this type is marked as 'beforefieldinit'.
		static MapPositionUtility()
		{
			Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "MapPositionUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr);
			MapPositionUtility.NativeFieldInfoPtr_OriginPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, "OriginPoint");
			MapPositionUtility.NativeFieldInfoPtr_EdgePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, "EdgePoint");
			MapPositionUtility.NativeFieldInfoPtr_MapDimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, "MapDimensions");
			MapPositionUtility.NativeFieldInfoPtr__conversionFactor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, "<conversionFactor>k__BackingField");
			MapPositionUtility.NativeMethodInfoPtr_get_conversionFactor_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100670172);
			MapPositionUtility.NativeMethodInfoPtr_set_conversionFactor_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100670173);
			MapPositionUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100670174);
			MapPositionUtility.NativeMethodInfoPtr_GetMapPosition_Public_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100670175);
			MapPositionUtility.NativeMethodInfoPtr_Recalculate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100670176);
			MapPositionUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr, 100670177);
		}

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x06003665 RID: 13925 RVA: 0x00130174 File Offset: 0x0012E374
		// (set) Token: 0x06003666 RID: 13926 RVA: 0x001301B0 File Offset: 0x0012E3B0
		public unsafe float conversionFactor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapPositionUtility.NativeMethodInfoPtr_get_conversionFactor_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapPositionUtility.NativeMethodInfoPtr_set_conversionFactor_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003667 RID: 13927 RVA: 0x001301F0 File Offset: 0x0012E3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142207, XrefRangeEnd = 142217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapPositionUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003668 RID: 13928 RVA: 0x0013022C File Offset: 0x0012E42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142217, XrefRangeEnd = 142219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetMapPosition(Vector3 worldPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapPositionUtility.NativeMethodInfoPtr_GetMapPosition_Public_Vector2_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x00130278 File Offset: 0x0012E478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142219, XrefRangeEnd = 142226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Recalculate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapPositionUtility.NativeMethodInfoPtr_Recalculate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x001302AC File Offset: 0x0012E4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142226, XrefRangeEnd = 142229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapPositionUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapPositionUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapPositionUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600366B RID: 13931 RVA: 0x0001BA69 File Offset: 0x00019C69
		public MapPositionUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x0600366C RID: 13932 RVA: 0x001302E8 File Offset: 0x0012E4E8
		// (set) Token: 0x0600366D RID: 13933 RVA: 0x0001BA72 File Offset: 0x00019C72
		public unsafe Transform OriginPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_OriginPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_OriginPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x0600366E RID: 13934 RVA: 0x00130318 File Offset: 0x0012E518
		// (set) Token: 0x0600366F RID: 13935 RVA: 0x0001BA91 File Offset: 0x00019C91
		public unsafe Transform EdgePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_EdgePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_EdgePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x06003670 RID: 13936 RVA: 0x00130348 File Offset: 0x0012E548
		// (set) Token: 0x06003671 RID: 13937 RVA: 0x0001BAB0 File Offset: 0x00019CB0
		public unsafe float MapDimensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_MapDimensions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr_MapDimensions)) = value;
			}
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x06003672 RID: 13938 RVA: 0x00130370 File Offset: 0x0012E570
		// (set) Token: 0x06003673 RID: 13939 RVA: 0x0001BACB File Offset: 0x00019CCB
		public unsafe float _conversionFactor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr__conversionFactor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapPositionUtility.NativeFieldInfoPtr__conversionFactor_k__BackingField)) = value;
			}
		}

		// Token: 0x04002469 RID: 9321
		private static readonly IntPtr NativeFieldInfoPtr_OriginPoint;

		// Token: 0x0400246A RID: 9322
		private static readonly IntPtr NativeFieldInfoPtr_EdgePoint;

		// Token: 0x0400246B RID: 9323
		private static readonly IntPtr NativeFieldInfoPtr_MapDimensions;

		// Token: 0x0400246C RID: 9324
		private static readonly IntPtr NativeFieldInfoPtr__conversionFactor_k__BackingField;

		// Token: 0x0400246D RID: 9325
		private static readonly IntPtr NativeMethodInfoPtr_get_conversionFactor_Private_get_Single_0;

		// Token: 0x0400246E RID: 9326
		private static readonly IntPtr NativeMethodInfoPtr_set_conversionFactor_Private_set_Void_Single_0;

		// Token: 0x0400246F RID: 9327
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002470 RID: 9328
		private static readonly IntPtr NativeMethodInfoPtr_GetMapPosition_Public_Vector2_Vector3_0;

		// Token: 0x04002471 RID: 9329
		private static readonly IntPtr NativeMethodInfoPtr_Recalculate_Public_Void_0;

		// Token: 0x04002472 RID: 9330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
