using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Delivery
{
	// Token: 0x02000419 RID: 1049
	[Serializable]
	public class DeliveryInstance : Object
	{
		// Token: 0x06005C5E RID: 23646 RVA: 0x001B9878 File Offset: 0x001B7A78
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryInstance()
		{
			Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Delivery", "DeliveryInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr);
			DeliveryInstance.NativeFieldInfoPtr_DeliveryID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "DeliveryID");
			DeliveryInstance.NativeFieldInfoPtr_StoreName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "StoreName");
			DeliveryInstance.NativeFieldInfoPtr_DestinationCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "DestinationCode");
			DeliveryInstance.NativeFieldInfoPtr_LoadingDockIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "LoadingDockIndex");
			DeliveryInstance.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "Items");
			DeliveryInstance.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "Status");
			DeliveryInstance.NativeFieldInfoPtr_TimeUntilArrival = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "TimeUntilArrival");
			DeliveryInstance.NativeFieldInfoPtr__ActiveVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "<ActiveVehicle>k__BackingField");
			DeliveryInstance.NativeFieldInfoPtr_onDeliveryCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, "onDeliveryCompleted");
			DeliveryInstance.NativeMethodInfoPtr_get_ActiveVehicle_Public_get_DeliveryVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675355);
			DeliveryInstance.NativeMethodInfoPtr_set_ActiveVehicle_Private_set_Void_DeliveryVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675356);
			DeliveryInstance.NativeMethodInfoPtr_get_Destination_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675357);
			DeliveryInstance.NativeMethodInfoPtr_get_LoadingDock_Public_get_LoadingDock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675358);
			DeliveryInstance.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_Il2CppReferenceArray_1_StringIntPair_EDeliveryStatus_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675359);
			DeliveryInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675360);
			DeliveryInstance.NativeMethodInfoPtr_GetTimeStatus_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675361);
			DeliveryInstance.NativeMethodInfoPtr_SetStatus_Public_Void_EDeliveryStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675362);
			DeliveryInstance.NativeMethodInfoPtr_AddItemsToDeliveryVehicle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675363);
			DeliveryInstance.NativeMethodInfoPtr_GetReceipt_Public_DeliveryReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675364);
			DeliveryInstance.NativeMethodInfoPtr_OnTimePass_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr, 100675365);
		}

		// Token: 0x17001C88 RID: 7304
		// (get) Token: 0x06005C5F RID: 23647 RVA: 0x001B9A38 File Offset: 0x001B7C38
		// (set) Token: 0x06005C60 RID: 23648 RVA: 0x001B9A78 File Offset: 0x001B7C78
		public unsafe DeliveryVehicle ActiveVehicle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30474, RefRangeEnd = 30475, XrefRangeStart = 30474, XrefRangeEnd = 30475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_get_ActiveVehicle_Public_get_DeliveryVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryVehicle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_set_ActiveVehicle_Private_set_Void_DeliveryVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C89 RID: 7305
		// (get) Token: 0x06005C61 RID: 23649 RVA: 0x001B9ABC File Offset: 0x001B7CBC
		public unsafe Property Destination
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 198466, RefRangeEnd = 198473, XrefRangeStart = 198460, XrefRangeEnd = 198466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_get_Destination_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
		}

		// Token: 0x17001C8A RID: 7306
		// (get) Token: 0x06005C62 RID: 23650 RVA: 0x001B9AFC File Offset: 0x001B7CFC
		public unsafe LoadingDock LoadingDock
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198473, XrefRangeEnd = 198474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_get_LoadingDock_Public_get_LoadingDock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LoadingDock>(intPtr3) : null;
			}
		}

		// Token: 0x06005C63 RID: 23651 RVA: 0x001B9B3C File Offset: 0x001B7D3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198479, RefRangeEnd = 198480, XrefRangeStart = 198474, XrefRangeEnd = 198479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryInstance(string deliveryID, string storeName, string destinationCode, int loadingDockIndex, Il2CppReferenceArray<StringIntPair> items, EDeliveryStatus status, int timeUntilArrival) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(deliveryID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(storeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destinationCode);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadingDockIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeUntilArrival;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_Il2CppReferenceArray_1_StringIntPair_EDeliveryStatus_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C64 RID: 23652 RVA: 0x001B9BE8 File Offset: 0x001B7DE8
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C65 RID: 23653 RVA: 0x001B9C24 File Offset: 0x001B7E24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198480, RefRangeEnd = 198481, XrefRangeStart = 198480, XrefRangeEnd = 198480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTimeStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_GetTimeStatus_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005C66 RID: 23654 RVA: 0x001B9C60 File Offset: 0x001B7E60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198523, RefRangeEnd = 198525, XrefRangeStart = 198481, XrefRangeEnd = 198523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStatus(EDeliveryStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_SetStatus_Public_Void_EDeliveryStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C67 RID: 23655 RVA: 0x001B9CA0 File Offset: 0x001B7EA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198534, RefRangeEnd = 198535, XrefRangeStart = 198525, XrefRangeEnd = 198534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItemsToDeliveryVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_AddItemsToDeliveryVehicle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C68 RID: 23656 RVA: 0x001B9CD4 File Offset: 0x001B7ED4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198543, RefRangeEnd = 198544, XrefRangeStart = 198535, XrefRangeEnd = 198543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryReceipt GetReceipt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_GetReceipt_Public_DeliveryReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryReceipt>(intPtr3) : null;
		}

		// Token: 0x06005C69 RID: 23657 RVA: 0x001B9D14 File Offset: 0x001B7F14
		[CallerCount(0)]
		public unsafe void OnTimePass(int minutes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minutes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryInstance.NativeMethodInfoPtr_OnTimePass_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C6A RID: 23658 RVA: 0x0002BC93 File Offset: 0x00029E93
		public DeliveryInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C7F RID: 7295
		// (get) Token: 0x06005C6B RID: 23659 RVA: 0x001B9D54 File Offset: 0x001B7F54
		// (set) Token: 0x06005C6C RID: 23660 RVA: 0x0002BC9C File Offset: 0x00029E9C
		public unsafe string DeliveryID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_DeliveryID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_DeliveryID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C80 RID: 7296
		// (get) Token: 0x06005C6D RID: 23661 RVA: 0x001B9D7C File Offset: 0x001B7F7C
		// (set) Token: 0x06005C6E RID: 23662 RVA: 0x0002BCBB File Offset: 0x00029EBB
		public unsafe string StoreName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_StoreName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_StoreName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C81 RID: 7297
		// (get) Token: 0x06005C6F RID: 23663 RVA: 0x001B9DA4 File Offset: 0x001B7FA4
		// (set) Token: 0x06005C70 RID: 23664 RVA: 0x0002BCDA File Offset: 0x00029EDA
		public unsafe string DestinationCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_DestinationCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_DestinationCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C82 RID: 7298
		// (get) Token: 0x06005C71 RID: 23665 RVA: 0x001B9DCC File Offset: 0x001B7FCC
		// (set) Token: 0x06005C72 RID: 23666 RVA: 0x0002BCF9 File Offset: 0x00029EF9
		public unsafe int LoadingDockIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_LoadingDockIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_LoadingDockIndex)) = value;
			}
		}

		// Token: 0x17001C83 RID: 7299
		// (get) Token: 0x06005C73 RID: 23667 RVA: 0x001B9DF4 File Offset: 0x001B7FF4
		// (set) Token: 0x06005C74 RID: 23668 RVA: 0x0002BD14 File Offset: 0x00029F14
		public unsafe Il2CppReferenceArray<StringIntPair> Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C84 RID: 7300
		// (get) Token: 0x06005C75 RID: 23669 RVA: 0x001B9E24 File Offset: 0x001B8024
		// (set) Token: 0x06005C76 RID: 23670 RVA: 0x0002BD33 File Offset: 0x00029F33
		public unsafe EDeliveryStatus Status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_Status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_Status)) = value;
			}
		}

		// Token: 0x17001C85 RID: 7301
		// (get) Token: 0x06005C77 RID: 23671 RVA: 0x001B9E4C File Offset: 0x001B804C
		// (set) Token: 0x06005C78 RID: 23672 RVA: 0x0002BD4E File Offset: 0x00029F4E
		public unsafe int TimeUntilArrival
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_TimeUntilArrival);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_TimeUntilArrival)) = value;
			}
		}

		// Token: 0x17001C86 RID: 7302
		// (get) Token: 0x06005C79 RID: 23673 RVA: 0x001B9E74 File Offset: 0x001B8074
		// (set) Token: 0x06005C7A RID: 23674 RVA: 0x0002BD69 File Offset: 0x00029F69
		public unsafe DeliveryVehicle _ActiveVehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr__ActiveVehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr__ActiveVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C87 RID: 7303
		// (get) Token: 0x06005C7B RID: 23675 RVA: 0x001B9EA4 File Offset: 0x001B80A4
		// (set) Token: 0x06005C7C RID: 23676 RVA: 0x0002BD88 File Offset: 0x00029F88
		public unsafe UnityEvent onDeliveryCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_onDeliveryCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryInstance.NativeFieldInfoPtr_onDeliveryCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003F5B RID: 16219
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryID;

		// Token: 0x04003F5C RID: 16220
		private static readonly IntPtr NativeFieldInfoPtr_StoreName;

		// Token: 0x04003F5D RID: 16221
		private static readonly IntPtr NativeFieldInfoPtr_DestinationCode;

		// Token: 0x04003F5E RID: 16222
		private static readonly IntPtr NativeFieldInfoPtr_LoadingDockIndex;

		// Token: 0x04003F5F RID: 16223
		private static readonly IntPtr NativeFieldInfoPtr_Items;

		// Token: 0x04003F60 RID: 16224
		private static readonly IntPtr NativeFieldInfoPtr_Status;

		// Token: 0x04003F61 RID: 16225
		private static readonly IntPtr NativeFieldInfoPtr_TimeUntilArrival;

		// Token: 0x04003F62 RID: 16226
		private static readonly IntPtr NativeFieldInfoPtr__ActiveVehicle_k__BackingField;

		// Token: 0x04003F63 RID: 16227
		private static readonly IntPtr NativeFieldInfoPtr_onDeliveryCompleted;

		// Token: 0x04003F64 RID: 16228
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveVehicle_Public_get_DeliveryVehicle_0;

		// Token: 0x04003F65 RID: 16229
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveVehicle_Private_set_Void_DeliveryVehicle_0;

		// Token: 0x04003F66 RID: 16230
		private static readonly IntPtr NativeMethodInfoPtr_get_Destination_Public_get_Property_0;

		// Token: 0x04003F67 RID: 16231
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadingDock_Public_get_LoadingDock_0;

		// Token: 0x04003F68 RID: 16232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_Il2CppReferenceArray_1_StringIntPair_EDeliveryStatus_Int32_0;

		// Token: 0x04003F69 RID: 16233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003F6A RID: 16234
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeStatus_Public_Int32_0;

		// Token: 0x04003F6B RID: 16235
		private static readonly IntPtr NativeMethodInfoPtr_SetStatus_Public_Void_EDeliveryStatus_0;

		// Token: 0x04003F6C RID: 16236
		private static readonly IntPtr NativeMethodInfoPtr_AddItemsToDeliveryVehicle_Public_Void_0;

		// Token: 0x04003F6D RID: 16237
		private static readonly IntPtr NativeMethodInfoPtr_GetReceipt_Public_DeliveryReceipt_0;

		// Token: 0x04003F6E RID: 16238
		private static readonly IntPtr NativeMethodInfoPtr_OnTimePass_Public_Void_Int32_0;
	}
}
