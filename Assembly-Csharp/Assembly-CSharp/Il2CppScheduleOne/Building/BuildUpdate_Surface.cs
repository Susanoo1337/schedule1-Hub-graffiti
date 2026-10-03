using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x02000467 RID: 1127
	public class BuildUpdate_Surface : BuildUpdate_Base
	{
		// Token: 0x060065D1 RID: 26065 RVA: 0x001DC35C File Offset: 0x001DA55C
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_Surface()
		{
			Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_Surface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr);
			BuildUpdate_Surface.NativeFieldInfoPtr_GhostModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "GhostModel");
			BuildUpdate_Surface.NativeFieldInfoPtr_BuildableItemClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "BuildableItemClass");
			BuildUpdate_Surface.NativeFieldInfoPtr_ItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "ItemInstance");
			BuildUpdate_Surface.NativeFieldInfoPtr_CurrentRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "CurrentRotation");
			BuildUpdate_Surface.NativeFieldInfoPtr_DetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "DetectionMask");
			BuildUpdate_Surface.NativeFieldInfoPtr_validPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "validPosition");
			BuildUpdate_Surface.NativeFieldInfoPtr_currentGhostMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "currentGhostMaterial");
			BuildUpdate_Surface.NativeFieldInfoPtr_hoveredValidSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, "hoveredValidSurface");
			BuildUpdate_Surface.NativeMethodInfoPtr_get_detectionRange_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676658);
			BuildUpdate_Surface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676659);
			BuildUpdate_Surface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676660);
			BuildUpdate_Surface.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676661);
			BuildUpdate_Surface.NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676662);
			BuildUpdate_Surface.NativeMethodInfoPtr_IsSurfaceValidForItem_Private_Boolean_Surface_Collider_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676663);
			BuildUpdate_Surface.NativeMethodInfoPtr_CheckRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676664);
			BuildUpdate_Surface.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676665);
			BuildUpdate_Surface.NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676666);
			BuildUpdate_Surface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr, 100676667);
		}

		// Token: 0x17001F2E RID: 7982
		// (get) Token: 0x060065D2 RID: 26066 RVA: 0x001DC4F4 File Offset: 0x001DA6F4
		public unsafe float detectionRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr_get_detectionRange_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060065D3 RID: 26067 RVA: 0x001DC530 File Offset: 0x001DA730
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 33113, RefRangeEnd = 33120, XrefRangeStart = 33113, XrefRangeEnd = 33120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Surface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D4 RID: 26068 RVA: 0x001DC56C File Offset: 0x001DA76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213094, XrefRangeEnd = 213101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Surface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D5 RID: 26069 RVA: 0x001DC5A8 File Offset: 0x001DA7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213101, XrefRangeEnd = 213193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Surface.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D6 RID: 26070 RVA: 0x001DC5E4 File Offset: 0x001DA7E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213253, RefRangeEnd = 213254, XrefRangeStart = 213193, XrefRangeEnd = 213253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PositionObjectInFrontOfPlayer(float dist, bool sanitizeForward)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dist;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sanitizeForward;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D7 RID: 26071 RVA: 0x001DC630 File Offset: 0x001DA830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213254, XrefRangeEnd = 213265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSurfaceValidForItem(Surface surface, Collider hitCollider, Vector3 hitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(surface);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hitCollider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr_IsSurfaceValidForItem_Private_Boolean_Surface_Collider_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065D8 RID: 26072 RVA: 0x001DC6A0 File Offset: 0x001DA8A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213283, RefRangeEnd = 213284, XrefRangeStart = 213265, XrefRangeEnd = 213283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr_CheckRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065D9 RID: 26073 RVA: 0x001DC6D4 File Offset: 0x001DA8D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213301, RefRangeEnd = 213302, XrefRangeStart = 213284, XrefRangeEnd = 213301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065DA RID: 26074 RVA: 0x001DC708 File Offset: 0x001DA908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213302, XrefRangeEnd = 213332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Place()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Surface.NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065DB RID: 26075 RVA: 0x001DC744 File Offset: 0x001DA944
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_Surface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_Surface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Surface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065DC RID: 26076 RVA: 0x0002FEE0 File Offset: 0x0002E0E0
		public BuildUpdate_Surface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F26 RID: 7974
		// (get) Token: 0x060065DD RID: 26077 RVA: 0x001DC780 File Offset: 0x001DA980
		// (set) Token: 0x060065DE RID: 26078 RVA: 0x0002FEE9 File Offset: 0x0002E0E9
		public unsafe GameObject GhostModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_GhostModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_GhostModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F27 RID: 7975
		// (get) Token: 0x060065DF RID: 26079 RVA: 0x001DC7B0 File Offset: 0x001DA9B0
		// (set) Token: 0x060065E0 RID: 26080 RVA: 0x0002FF08 File Offset: 0x0002E108
		public unsafe SurfaceItem BuildableItemClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_BuildableItemClass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SurfaceItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_BuildableItemClass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F28 RID: 7976
		// (get) Token: 0x060065E1 RID: 26081 RVA: 0x001DC7E0 File Offset: 0x001DA9E0
		// (set) Token: 0x060065E2 RID: 26082 RVA: 0x0002FF27 File Offset: 0x0002E127
		public unsafe ItemInstance ItemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_ItemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_ItemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F29 RID: 7977
		// (get) Token: 0x060065E3 RID: 26083 RVA: 0x001DC810 File Offset: 0x001DAA10
		// (set) Token: 0x060065E4 RID: 26084 RVA: 0x0002FF46 File Offset: 0x0002E146
		public unsafe float CurrentRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_CurrentRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_CurrentRotation)) = value;
			}
		}

		// Token: 0x17001F2A RID: 7978
		// (get) Token: 0x060065E5 RID: 26085 RVA: 0x001DC838 File Offset: 0x001DAA38
		// (set) Token: 0x060065E6 RID: 26086 RVA: 0x0002FF61 File Offset: 0x0002E161
		public unsafe LayerMask DetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_DetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_DetectionMask)) = value;
			}
		}

		// Token: 0x17001F2B RID: 7979
		// (get) Token: 0x060065E7 RID: 26087 RVA: 0x001DC860 File Offset: 0x001DAA60
		// (set) Token: 0x060065E8 RID: 26088 RVA: 0x0002FF7C File Offset: 0x0002E17C
		public unsafe bool validPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_validPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_validPosition)) = value;
			}
		}

		// Token: 0x17001F2C RID: 7980
		// (get) Token: 0x060065E9 RID: 26089 RVA: 0x001DC888 File Offset: 0x001DAA88
		// (set) Token: 0x060065EA RID: 26090 RVA: 0x0002FF97 File Offset: 0x0002E197
		public unsafe Material currentGhostMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_currentGhostMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_currentGhostMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F2D RID: 7981
		// (get) Token: 0x060065EB RID: 26091 RVA: 0x001DC8B8 File Offset: 0x001DAAB8
		// (set) Token: 0x060065EC RID: 26092 RVA: 0x0002FFB6 File Offset: 0x0002E1B6
		public unsafe Surface hoveredValidSurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_hoveredValidSurface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Surface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Surface.NativeFieldInfoPtr_hoveredValidSurface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004627 RID: 17959
		private static readonly IntPtr NativeFieldInfoPtr_GhostModel;

		// Token: 0x04004628 RID: 17960
		private static readonly IntPtr NativeFieldInfoPtr_BuildableItemClass;

		// Token: 0x04004629 RID: 17961
		private static readonly IntPtr NativeFieldInfoPtr_ItemInstance;

		// Token: 0x0400462A RID: 17962
		private static readonly IntPtr NativeFieldInfoPtr_CurrentRotation;

		// Token: 0x0400462B RID: 17963
		private static readonly IntPtr NativeFieldInfoPtr_DetectionMask;

		// Token: 0x0400462C RID: 17964
		private static readonly IntPtr NativeFieldInfoPtr_validPosition;

		// Token: 0x0400462D RID: 17965
		private static readonly IntPtr NativeFieldInfoPtr_currentGhostMaterial;

		// Token: 0x0400462E RID: 17966
		private static readonly IntPtr NativeFieldInfoPtr_hoveredValidSurface;

		// Token: 0x0400462F RID: 17967
		private static readonly IntPtr NativeMethodInfoPtr_get_detectionRange_Private_get_Single_0;

		// Token: 0x04004630 RID: 17968
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04004631 RID: 17969
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004632 RID: 17970
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004633 RID: 17971
		private static readonly IntPtr NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_0;

		// Token: 0x04004634 RID: 17972
		private static readonly IntPtr NativeMethodInfoPtr_IsSurfaceValidForItem_Private_Boolean_Surface_Collider_Vector3_0;

		// Token: 0x04004635 RID: 17973
		private static readonly IntPtr NativeMethodInfoPtr_CheckRotation_Protected_Void_0;

		// Token: 0x04004636 RID: 17974
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0;

		// Token: 0x04004637 RID: 17975
		private static readonly IntPtr NativeMethodInfoPtr_Place_Protected_Virtual_New_Void_0;

		// Token: 0x04004638 RID: 17976
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
