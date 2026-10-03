using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x0200046A RID: 1130
	public class Surface : MonoBehaviour
	{
		// Token: 0x060065FB RID: 26107 RVA: 0x001DCB40 File Offset: 0x001DAD40
		// Note: this type is marked as 'beforefieldinit'.
		static Surface()
		{
			Il2CppClassPointerStore<Surface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "Surface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Surface>.NativeClassPtr);
			Surface.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Surface>.NativeClassPtr, "<GUID>k__BackingField");
			Surface.NativeFieldInfoPtr__ParentProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Surface>.NativeClassPtr, "<ParentProperty>k__BackingField");
			Surface.NativeFieldInfoPtr_SurfaceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Surface>.NativeClassPtr, "SurfaceType");
			Surface.NativeFieldInfoPtr_ValidFaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Surface>.NativeClassPtr, "ValidFaces");
			Surface.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Surface>.NativeClassPtr, "BakedGUID");
			Surface.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676672);
			Surface.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676673);
			Surface.NativeMethodInfoPtr_get_Container_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676674);
			Surface.NativeMethodInfoPtr_get_ParentProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676675);
			Surface.NativeMethodInfoPtr_set_ParentProperty_Private_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676676);
			Surface.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676677);
			Surface.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676678);
			Surface.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676679);
			Surface.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676680);
			Surface.NativeMethodInfoPtr_GetRelativePosition_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676681);
			Surface.NativeMethodInfoPtr_GetRelativeRotation_Public_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676682);
			Surface.NativeMethodInfoPtr_IsFrontFace_Public_Boolean_Vector3_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676683);
			Surface.NativeMethodInfoPtr_IsPointValid_Public_Boolean_Vector3_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676684);
			Surface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Surface>.NativeClassPtr, 100676685);
		}

		// Token: 0x17001F37 RID: 7991
		// (get) Token: 0x060065FC RID: 26108 RVA: 0x001DCCEC File Offset: 0x001DAEEC
		// (set) Token: 0x060065FD RID: 26109 RVA: 0x001DCD28 File Offset: 0x001DAF28
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F38 RID: 7992
		// (get) Token: 0x060065FE RID: 26110 RVA: 0x001DCD68 File Offset: 0x001DAF68
		public unsafe Transform Container
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101084, RefRangeEnd = 101085, XrefRangeStart = 101084, XrefRangeEnd = 101085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_get_Container_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17001F39 RID: 7993
		// (get) Token: 0x060065FF RID: 26111 RVA: 0x001DCDA8 File Offset: 0x001DAFA8
		// (set) Token: 0x06006600 RID: 26112 RVA: 0x001DCDE8 File Offset: 0x001DAFE8
		public unsafe Property ParentProperty
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_get_ParentProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_set_ParentProperty_Private_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006601 RID: 26113 RVA: 0x001DCE2C File Offset: 0x001DB02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213367, XrefRangeEnd = 213370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006602 RID: 26114 RVA: 0x001DCE60 File Offset: 0x001DB060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213370, XrefRangeEnd = 213412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006603 RID: 26115 RVA: 0x001DCE94 File Offset: 0x001DB094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213412, XrefRangeEnd = 213441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Surface.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006604 RID: 26116 RVA: 0x001DCED0 File Offset: 0x001DB0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213441, XrefRangeEnd = 213445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006605 RID: 26117 RVA: 0x001DCF10 File Offset: 0x001DB110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213445, XrefRangeEnd = 213447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetRelativePosition(Vector3 worldPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_GetRelativePosition_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006606 RID: 26118 RVA: 0x001DCF5C File Offset: 0x001DB15C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213450, RefRangeEnd = 213451, XrefRangeStart = 213447, XrefRangeEnd = 213450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion GetRelativeRotation(Quaternion worldRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_GetRelativeRotation_Public_Quaternion_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006607 RID: 26119 RVA: 0x001DCFA8 File Offset: 0x001DB1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213451, XrefRangeEnd = 213453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFrontFace(Vector3 point, Collider collider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_IsFrontFace_Public_Boolean_Vector3_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006608 RID: 26120 RVA: 0x001DD004 File Offset: 0x001DB204
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213491, RefRangeEnd = 213493, XrefRangeStart = 213453, XrefRangeEnd = 213491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointValid(Vector3 point, Collider hitCollider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hitCollider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr_IsPointValid_Public_Boolean_Vector3_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006609 RID: 26121 RVA: 0x001DD060 File Offset: 0x001DB260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213493, XrefRangeEnd = 213510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Surface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Surface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Surface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600660A RID: 26122 RVA: 0x00030075 File Offset: 0x0002E275
		public Surface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F32 RID: 7986
		// (get) Token: 0x0600660B RID: 26123 RVA: 0x001DD09C File Offset: 0x001DB29C
		// (set) Token: 0x0600660C RID: 26124 RVA: 0x0003007E File Offset: 0x0002E27E
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F33 RID: 7987
		// (get) Token: 0x0600660D RID: 26125 RVA: 0x001DD0C4 File Offset: 0x001DB2C4
		// (set) Token: 0x0600660E RID: 26126 RVA: 0x00030099 File Offset: 0x0002E299
		public unsafe Property _ParentProperty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr__ParentProperty_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr__ParentProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F34 RID: 7988
		// (get) Token: 0x0600660F RID: 26127 RVA: 0x001DD0F4 File Offset: 0x001DB2F4
		// (set) Token: 0x06006610 RID: 26128 RVA: 0x000300B8 File Offset: 0x0002E2B8
		public unsafe Surface.ESurfaceType SurfaceType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_SurfaceType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_SurfaceType)) = value;
			}
		}

		// Token: 0x17001F35 RID: 7989
		// (get) Token: 0x06006611 RID: 26129 RVA: 0x001DD11C File Offset: 0x001DB31C
		// (set) Token: 0x06006612 RID: 26130 RVA: 0x000300D3 File Offset: 0x0002E2D3
		public unsafe List<Surface.EFace> ValidFaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_ValidFaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Surface.EFace>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_ValidFaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F36 RID: 7990
		// (get) Token: 0x06006613 RID: 26131 RVA: 0x001DD14C File Offset: 0x001DB34C
		// (set) Token: 0x06006614 RID: 26132 RVA: 0x000300F2 File Offset: 0x0002E2F2
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Surface.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004640 RID: 17984
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04004641 RID: 17985
		private static readonly IntPtr NativeFieldInfoPtr__ParentProperty_k__BackingField;

		// Token: 0x04004642 RID: 17986
		private static readonly IntPtr NativeFieldInfoPtr_SurfaceType;

		// Token: 0x04004643 RID: 17987
		private static readonly IntPtr NativeFieldInfoPtr_ValidFaces;

		// Token: 0x04004644 RID: 17988
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04004645 RID: 17989
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04004646 RID: 17990
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04004647 RID: 17991
		private static readonly IntPtr NativeMethodInfoPtr_get_Container_Public_get_Transform_0;

		// Token: 0x04004648 RID: 17992
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentProperty_Public_get_Property_0;

		// Token: 0x04004649 RID: 17993
		private static readonly IntPtr NativeMethodInfoPtr_set_ParentProperty_Private_set_Void_Property_0;

		// Token: 0x0400464A RID: 17994
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x0400464B RID: 17995
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x0400464C RID: 17996
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400464D RID: 17997
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x0400464E RID: 17998
		private static readonly IntPtr NativeMethodInfoPtr_GetRelativePosition_Public_Vector3_Vector3_0;

		// Token: 0x0400464F RID: 17999
		private static readonly IntPtr NativeMethodInfoPtr_GetRelativeRotation_Public_Quaternion_Quaternion_0;

		// Token: 0x04004650 RID: 18000
		private static readonly IntPtr NativeMethodInfoPtr_IsFrontFace_Public_Boolean_Vector3_Collider_0;

		// Token: 0x04004651 RID: 18001
		private static readonly IntPtr NativeMethodInfoPtr_IsPointValid_Public_Boolean_Vector3_Collider_0;

		// Token: 0x04004652 RID: 18002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B44 RID: 2884
		[OriginalName("Assembly-CSharp.dll", "", "ESurfaceType")]
		public enum ESurfaceType
		{
			// Token: 0x04009CDB RID: 40155
			Wall,
			// Token: 0x04009CDC RID: 40156
			Roof
		}

		// Token: 0x02000B45 RID: 2885
		[OriginalName("Assembly-CSharp.dll", "", "EFace")]
		public enum EFace
		{
			// Token: 0x04009CDE RID: 40158
			Front,
			// Token: 0x04009CDF RID: 40159
			Back,
			// Token: 0x04009CE0 RID: 40160
			Top,
			// Token: 0x04009CE1 RID: 40161
			Bottom,
			// Token: 0x04009CE2 RID: 40162
			Left,
			// Token: 0x04009CE3 RID: 40163
			Right
		}
	}
}
