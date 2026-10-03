using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x020005A8 RID: 1448
	[Serializable]
	public class DryingOperation : Object
	{
		// Token: 0x060086C1 RID: 34497 RVA: 0x0024BAF4 File Offset: 0x00249CF4
		// Note: this type is marked as 'beforefieldinit'.
		static DryingOperation()
		{
			Il2CppClassPointerStore<DryingOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "DryingOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr);
			DryingOperation.NativeFieldInfoPtr_ItemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, "ItemID");
			DryingOperation.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, "Quantity");
			DryingOperation.NativeFieldInfoPtr_StartQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, "StartQuality");
			DryingOperation.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, "Time");
			DryingOperation.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EQuality_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, 100680632);
			DryingOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, 100680633);
			DryingOperation.NativeMethodInfoPtr_IncreaseQuality_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, 100680634);
			DryingOperation.NativeMethodInfoPtr_GetQualityItemInstance_Public_QualityItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, 100680635);
			DryingOperation.NativeMethodInfoPtr_GetQuality_Public_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, 100680636);
		}

		// Token: 0x060086C2 RID: 34498 RVA: 0x0024BBD8 File Offset: 0x00249DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252022, XrefRangeEnd = 252024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingOperation(string itemID, int quantity, EQuality startQuality, float time) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startQuality;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperation.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EQuality_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086C3 RID: 34499 RVA: 0x0024BC50 File Offset: 0x00249E50
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingOperation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086C4 RID: 34500 RVA: 0x0024BC8C File Offset: 0x00249E8C
		[CallerCount(0)]
		public unsafe void IncreaseQuality()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperation.NativeMethodInfoPtr_IncreaseQuality_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086C5 RID: 34501 RVA: 0x0024BCC0 File Offset: 0x00249EC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252028, RefRangeEnd = 252029, XrefRangeStart = 252024, XrefRangeEnd = 252028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemInstance GetQualityItemInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperation.NativeMethodInfoPtr_GetQualityItemInstance_Public_QualityItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QualityItemInstance>(intPtr3) : null;
		}

		// Token: 0x060086C6 RID: 34502 RVA: 0x0024BD00 File Offset: 0x00249F00
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 252029, RefRangeEnd = 252034, XrefRangeStart = 252029, XrefRangeEnd = 252029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EQuality GetQuality()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperation.NativeMethodInfoPtr_GetQuality_Public_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060086C7 RID: 34503 RVA: 0x0003FFF2 File Offset: 0x0003E1F2
		public DryingOperation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029B6 RID: 10678
		// (get) Token: 0x060086C8 RID: 34504 RVA: 0x0024BD3C File Offset: 0x00249F3C
		// (set) Token: 0x060086C9 RID: 34505 RVA: 0x0003FFFB File Offset: 0x0003E1FB
		public unsafe string ItemID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_ItemID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_ItemID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029B7 RID: 10679
		// (get) Token: 0x060086CA RID: 34506 RVA: 0x0024BD64 File Offset: 0x00249F64
		// (set) Token: 0x060086CB RID: 34507 RVA: 0x0004001A File Offset: 0x0003E21A
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x170029B8 RID: 10680
		// (get) Token: 0x060086CC RID: 34508 RVA: 0x0024BD8C File Offset: 0x00249F8C
		// (set) Token: 0x060086CD RID: 34509 RVA: 0x00040035 File Offset: 0x0003E235
		public unsafe EQuality StartQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_StartQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_StartQuality)) = value;
			}
		}

		// Token: 0x170029B9 RID: 10681
		// (get) Token: 0x060086CE RID: 34510 RVA: 0x0024BDB4 File Offset: 0x00249FB4
		// (set) Token: 0x060086CF RID: 34511 RVA: 0x00040050 File Offset: 0x0003E250
		public unsafe float Time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_Time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_Time)) = value;
			}
		}

		// Token: 0x04005C0D RID: 23565
		private static readonly IntPtr NativeFieldInfoPtr_ItemID;

		// Token: 0x04005C0E RID: 23566
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x04005C0F RID: 23567
		private static readonly IntPtr NativeFieldInfoPtr_StartQuality;

		// Token: 0x04005C10 RID: 23568
		private static readonly IntPtr NativeFieldInfoPtr_Time;

		// Token: 0x04005C11 RID: 23569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EQuality_Single_0;

		// Token: 0x04005C12 RID: 23570
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005C13 RID: 23571
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseQuality_Public_Void_0;

		// Token: 0x04005C14 RID: 23572
		private static readonly IntPtr NativeMethodInfoPtr_GetQualityItemInstance_Public_QualityItemInstance_0;

		// Token: 0x04005C15 RID: 23573
		private static readonly IntPtr NativeMethodInfoPtr_GetQuality_Public_EQuality_0;
	}
}
