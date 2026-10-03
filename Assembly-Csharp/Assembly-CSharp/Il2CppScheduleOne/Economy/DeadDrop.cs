using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000392 RID: 914
	public class DeadDrop : MonoBehaviour
	{
		// Token: 0x0600524A RID: 21066 RVA: 0x00196FE4 File Offset: 0x001951E4
		// Note: this type is marked as 'beforefieldinit'.
		static DeadDrop()
		{
			Il2CppClassPointerStore<DeadDrop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "DeadDrop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr);
			DeadDrop.NativeFieldInfoPtr_DeadDrops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "DeadDrops");
			DeadDrop.NativeFieldInfoPtr_DeadDropName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "DeadDropName");
			DeadDrop.NativeFieldInfoPtr_DeadDropDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "DeadDropDescription");
			DeadDrop.NativeFieldInfoPtr_Region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "Region");
			DeadDrop.NativeFieldInfoPtr_Storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "Storage");
			DeadDrop.NativeFieldInfoPtr_PoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "PoI");
			DeadDrop.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "Light");
			DeadDrop.NativeFieldInfoPtr_ItemCountVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "ItemCountVariable");
			DeadDrop.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "<GUID>k__BackingField");
			DeadDrop.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "BakedGUID");
			DeadDrop.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674044);
			DeadDrop.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674045);
			DeadDrop.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674046);
			DeadDrop.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674047);
			DeadDrop.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674048);
			DeadDrop.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674049);
			DeadDrop.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674050);
			DeadDrop.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674051);
			DeadDrop.NativeMethodInfoPtr_GetRandomEmptyDrop_Public_Static_DeadDrop_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674052);
			DeadDrop.NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674053);
			DeadDrop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674054);
		}

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x0600524B RID: 21067 RVA: 0x001971B8 File Offset: 0x001953B8
		// (set) Token: 0x0600524C RID: 21068 RVA: 0x001971F4 File Offset: 0x001953F4
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600524D RID: 21069 RVA: 0x00197234 File Offset: 0x00195434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183436, XrefRangeEnd = 183439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600524E RID: 21070 RVA: 0x00197268 File Offset: 0x00195468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183439, XrefRangeEnd = 183453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeadDrop.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600524F RID: 21071 RVA: 0x001972A4 File Offset: 0x001954A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183453, XrefRangeEnd = 183456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005250 RID: 21072 RVA: 0x001972D8 File Offset: 0x001954D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183456, XrefRangeEnd = 183488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeadDrop.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005251 RID: 21073 RVA: 0x00197314 File Offset: 0x00195514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183488, XrefRangeEnd = 183492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005252 RID: 21074 RVA: 0x00197354 File Offset: 0x00195554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183492, XrefRangeEnd = 183500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005253 RID: 21075 RVA: 0x00197388 File Offset: 0x00195588
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183551, RefRangeEnd = 183552, XrefRangeStart = 183500, XrefRangeEnd = 183551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DeadDrop GetRandomEmptyDrop(Vector3 origin)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_GetRandomEmptyDrop_Public_Static_DeadDrop_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeadDrop>(intPtr3) : null;
		}

		// Token: 0x06005254 RID: 21076 RVA: 0x001973C8 File Offset: 0x001955C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183552, XrefRangeEnd = 183565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDeadDrop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005255 RID: 21077 RVA: 0x001973FC File Offset: 0x001955FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183565, XrefRangeEnd = 183571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeadDrop() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005256 RID: 21078 RVA: 0x00027298 File Offset: 0x00025498
		public DeadDrop(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x06005257 RID: 21079 RVA: 0x00197438 File Offset: 0x00195638
		// (set) Token: 0x06005258 RID: 21080 RVA: 0x000272A1 File Offset: 0x000254A1
		public unsafe static List<DeadDrop> DeadDrops
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DeadDrop.NativeFieldInfoPtr_DeadDrops, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DeadDrop>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeadDrop.NativeFieldInfoPtr_DeadDrops, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x06005259 RID: 21081 RVA: 0x00197460 File Offset: 0x00195660
		// (set) Token: 0x0600525A RID: 21082 RVA: 0x000272B3 File Offset: 0x000254B3
		public unsafe string DeadDropName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_DeadDropName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_DeadDropName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x0600525B RID: 21083 RVA: 0x00197488 File Offset: 0x00195688
		// (set) Token: 0x0600525C RID: 21084 RVA: 0x000272D2 File Offset: 0x000254D2
		public unsafe string DeadDropDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_DeadDropDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_DeadDropDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x0600525D RID: 21085 RVA: 0x001974B0 File Offset: 0x001956B0
		// (set) Token: 0x0600525E RID: 21086 RVA: 0x000272F1 File Offset: 0x000254F1
		public unsafe EMapRegion Region
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_Region);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_Region)) = value;
			}
		}

		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x0600525F RID: 21087 RVA: 0x001974D8 File Offset: 0x001956D8
		// (set) Token: 0x06005260 RID: 21088 RVA: 0x0002730C File Offset: 0x0002550C
		public unsafe WorldStorageEntity Storage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_Storage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldStorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_Storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x06005261 RID: 21089 RVA: 0x00197508 File Offset: 0x00195708
		// (set) Token: 0x06005262 RID: 21090 RVA: 0x0002732B File Offset: 0x0002552B
		public unsafe POI PoI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_PoI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_PoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x06005263 RID: 21091 RVA: 0x00197538 File Offset: 0x00195738
		// (set) Token: 0x06005264 RID: 21092 RVA: 0x0002734A File Offset: 0x0002554A
		public unsafe OptimizedLight Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x06005265 RID: 21093 RVA: 0x00197568 File Offset: 0x00195768
		// (set) Token: 0x06005266 RID: 21094 RVA: 0x00027369 File Offset: 0x00025569
		public unsafe string ItemCountVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_ItemCountVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_ItemCountVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x06005267 RID: 21095 RVA: 0x00197590 File Offset: 0x00195790
		// (set) Token: 0x06005268 RID: 21096 RVA: 0x00027388 File Offset: 0x00025588
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x06005269 RID: 21097 RVA: 0x001975B8 File Offset: 0x001957B8
		// (set) Token: 0x0600526A RID: 21098 RVA: 0x000273A3 File Offset: 0x000255A3
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400387D RID: 14461
		private static readonly IntPtr NativeFieldInfoPtr_DeadDrops;

		// Token: 0x0400387E RID: 14462
		private static readonly IntPtr NativeFieldInfoPtr_DeadDropName;

		// Token: 0x0400387F RID: 14463
		private static readonly IntPtr NativeFieldInfoPtr_DeadDropDescription;

		// Token: 0x04003880 RID: 14464
		private static readonly IntPtr NativeFieldInfoPtr_Region;

		// Token: 0x04003881 RID: 14465
		private static readonly IntPtr NativeFieldInfoPtr_Storage;

		// Token: 0x04003882 RID: 14466
		private static readonly IntPtr NativeFieldInfoPtr_PoI;

		// Token: 0x04003883 RID: 14467
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04003884 RID: 14468
		private static readonly IntPtr NativeFieldInfoPtr_ItemCountVariable;

		// Token: 0x04003885 RID: 14469
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04003886 RID: 14470
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04003887 RID: 14471
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04003888 RID: 14472
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04003889 RID: 14473
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x0400388A RID: 14474
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400388B RID: 14475
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400388C RID: 14476
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x0400388D RID: 14477
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x0400388E RID: 14478
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x0400388F RID: 14479
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomEmptyDrop_Public_Static_DeadDrop_Vector3_0;

		// Token: 0x04003890 RID: 14480
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0;

		// Token: 0x04003891 RID: 14481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AA7 RID: 2727
		[ObfuscatedName("ScheduleOne.Economy.DeadDrop+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E2D8 RID: 58072 RVA: 0x003799A8 File Offset: 0x00377BA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr);
				DeadDrop.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr, "<>9");
				DeadDrop.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr, "<>9__19_0");
				DeadDrop.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr, 100674057);
				DeadDrop.__c.NativeMethodInfoPtr__GetRandomEmptyDrop_b__19_0_Internal_Boolean_DeadDrop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr, 100674058);
			}

			// Token: 0x0600E2D9 RID: 58073 RVA: 0x00379A24 File Offset: 0x00377C24
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E2DA RID: 58074 RVA: 0x00379A60 File Offset: 0x00377C60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183430, XrefRangeEnd = 183431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRandomEmptyDrop_b__19_0(DeadDrop drop)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(drop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.__c.NativeMethodInfoPtr__GetRandomEmptyDrop_b__19_0_Internal_Boolean_DeadDrop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E2DB RID: 58075 RVA: 0x0006AF59 File Offset: 0x00069159
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004502 RID: 17666
			// (get) Token: 0x0600E2DC RID: 58076 RVA: 0x00379AB0 File Offset: 0x00377CB0
			// (set) Token: 0x0600E2DD RID: 58077 RVA: 0x0006AF62 File Offset: 0x00069162
			public unsafe static DeadDrop.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeadDrop.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeadDrop.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeadDrop.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004503 RID: 17667
			// (get) Token: 0x0600E2DE RID: 58078 RVA: 0x00379AD8 File Offset: 0x00377CD8
			// (set) Token: 0x0600E2DF RID: 58079 RVA: 0x0006AF74 File Offset: 0x00069174
			public unsafe static Func<DeadDrop, bool> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeadDrop.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DeadDrop, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeadDrop.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A3D RID: 39485
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009A3E RID: 39486
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x04009A3F RID: 39487
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A40 RID: 39488
			private static readonly IntPtr NativeMethodInfoPtr__GetRandomEmptyDrop_b__19_0_Internal_Boolean_DeadDrop_0;
		}

		// Token: 0x02000AA8 RID: 2728
		[ObfuscatedName("ScheduleOne.Economy.DeadDrop+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E2E0 RID: 58080 RVA: 0x00379B00 File Offset: 0x00377D00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<DeadDrop.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeadDrop.__c__DisplayClass19_0>.NativeClassPtr);
				DeadDrop.__c__DisplayClass19_0.NativeFieldInfoPtr_origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop.__c__DisplayClass19_0>.NativeClassPtr, "origin");
				DeadDrop.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop.__c__DisplayClass19_0>.NativeClassPtr, 100674059);
				DeadDrop.__c__DisplayClass19_0.NativeMethodInfoPtr__GetRandomEmptyDrop_b__1_Internal_Single_DeadDrop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop.__c__DisplayClass19_0>.NativeClassPtr, 100674060);
			}

			// Token: 0x0600E2E1 RID: 58081 RVA: 0x00379B68 File Offset: 0x00377D68
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeadDrop.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E2E2 RID: 58082 RVA: 0x00379BA4 File Offset: 0x00377DA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183431, XrefRangeEnd = 183436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetRandomEmptyDrop_b__1(DeadDrop drop)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(drop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.__c__DisplayClass19_0.NativeMethodInfoPtr__GetRandomEmptyDrop_b__1_Internal_Single_DeadDrop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E2E3 RID: 58083 RVA: 0x0006AF86 File Offset: 0x00069186
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004504 RID: 17668
			// (get) Token: 0x0600E2E4 RID: 58084 RVA: 0x00379BF4 File Offset: 0x00377DF4
			// (set) Token: 0x0600E2E5 RID: 58085 RVA: 0x0006AF8F File Offset: 0x0006918F
			public unsafe Vector3 origin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.__c__DisplayClass19_0.NativeFieldInfoPtr_origin);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.__c__DisplayClass19_0.NativeFieldInfoPtr_origin)) = value;
				}
			}

			// Token: 0x04009A41 RID: 39489
			private static readonly IntPtr NativeFieldInfoPtr_origin;

			// Token: 0x04009A42 RID: 39490
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A43 RID: 39491
			private static readonly IntPtr NativeMethodInfoPtr__GetRandomEmptyDrop_b__1_Internal_Single_DeadDrop_0;
		}
	}
}
