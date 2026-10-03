using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Map;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000627 RID: 1575
	public class Jeremy : NPC
	{
		// Token: 0x060097AC RID: 38828 RVA: 0x0028BE98 File Offset: 0x0028A098
		// Note: this type is marked as 'beforefieldinit'.
		static Jeremy()
		{
			Il2CppClassPointerStore<Jeremy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Jeremy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Jeremy>.NativeClassPtr);
			Jeremy.NativeFieldInfoPtr_Dealership = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "Dealership");
			Jeremy.NativeFieldInfoPtr_Listings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "Listings");
			Jeremy.NativeFieldInfoPtr_GreetingDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "GreetingDialogue");
			Jeremy.NativeFieldInfoPtr_GreetedVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "GreetedVariable");
			Jeremy.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.JeremyAssembly-CSharp.dll_Excuted");
			Jeremy.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.JeremyAssembly-CSharp.dll_Excuted");
			Jeremy.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100683051);
			Jeremy.NativeMethodInfoPtr_Loaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100683052);
			Jeremy.NativeMethodInfoPtr_EnableGreeting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100683053);
			Jeremy.NativeMethodInfoPtr_SetGreeted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100683054);
			Jeremy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100683055);
			Jeremy.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100683056);
			Jeremy.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100683057);
			Jeremy.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100683058);
			Jeremy.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, 100683059);
		}

		// Token: 0x060097AD RID: 38829 RVA: 0x0028BFF4 File Offset: 0x0028A1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273187, XrefRangeEnd = 273200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jeremy.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097AE RID: 38830 RVA: 0x0028C030 File Offset: 0x0028A230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273200, XrefRangeEnd = 273229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Loaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.NativeMethodInfoPtr_Loaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097AF RID: 38831 RVA: 0x0028C064 File Offset: 0x0028A264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273229, XrefRangeEnd = 273241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableGreeting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.NativeMethodInfoPtr_EnableGreeting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097B0 RID: 38832 RVA: 0x0028C098 File Offset: 0x0028A298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273241, XrefRangeEnd = 273261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGreeted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.NativeMethodInfoPtr_SetGreeted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097B1 RID: 38833 RVA: 0x0028C0CC File Offset: 0x0028A2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273261, XrefRangeEnd = 273273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Jeremy() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Jeremy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097B2 RID: 38834 RVA: 0x0028C108 File Offset: 0x0028A308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jeremy.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097B3 RID: 38835 RVA: 0x0028C144 File Offset: 0x0028A344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jeremy.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097B4 RID: 38836 RVA: 0x0028C180 File Offset: 0x0028A380
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jeremy.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097B5 RID: 38837 RVA: 0x0028C1BC File Offset: 0x0028A3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jeremy.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060097B6 RID: 38838 RVA: 0x00046D9C File Offset: 0x00044F9C
		public Jeremy(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002EA4 RID: 11940
		// (get) Token: 0x060097B7 RID: 38839 RVA: 0x0028C1F8 File Offset: 0x0028A3F8
		// (set) Token: 0x060097B8 RID: 38840 RVA: 0x00046DA5 File Offset: 0x00044FA5
		public unsafe Dealership Dealership
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_Dealership);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealership>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_Dealership), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA5 RID: 11941
		// (get) Token: 0x060097B9 RID: 38841 RVA: 0x0028C228 File Offset: 0x0028A428
		// (set) Token: 0x060097BA RID: 38842 RVA: 0x00046DC4 File Offset: 0x00044FC4
		public unsafe List<Jeremy.DealershipListing> Listings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_Listings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Jeremy.DealershipListing>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_Listings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA6 RID: 11942
		// (get) Token: 0x060097BB RID: 38843 RVA: 0x0028C258 File Offset: 0x0028A458
		// (set) Token: 0x060097BC RID: 38844 RVA: 0x00046DE3 File Offset: 0x00044FE3
		public unsafe DialogueContainer GreetingDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_GreetingDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_GreetingDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EA7 RID: 11943
		// (get) Token: 0x060097BD RID: 38845 RVA: 0x0028C288 File Offset: 0x0028A488
		// (set) Token: 0x060097BE RID: 38846 RVA: 0x00046E02 File Offset: 0x00045002
		public unsafe string GreetedVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_GreetedVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_GreetedVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002EA8 RID: 11944
		// (get) Token: 0x060097BF RID: 38847 RVA: 0x0028C2B0 File Offset: 0x0028A4B0
		// (set) Token: 0x060097C0 RID: 38848 RVA: 0x00046E21 File Offset: 0x00045021
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002EA9 RID: 11945
		// (get) Token: 0x060097C1 RID: 38849 RVA: 0x0028C2D8 File Offset: 0x0028A4D8
		// (set) Token: 0x060097C2 RID: 38850 RVA: 0x00046E3C File Offset: 0x0004503C
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006842 RID: 26690
		private static readonly IntPtr NativeFieldInfoPtr_Dealership;

		// Token: 0x04006843 RID: 26691
		private static readonly IntPtr NativeFieldInfoPtr_Listings;

		// Token: 0x04006844 RID: 26692
		private static readonly IntPtr NativeFieldInfoPtr_GreetingDialogue;

		// Token: 0x04006845 RID: 26693
		private static readonly IntPtr NativeFieldInfoPtr_GreetedVariable;

		// Token: 0x04006846 RID: 26694
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006847 RID: 26695
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006848 RID: 26696
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006849 RID: 26697
		private static readonly IntPtr NativeMethodInfoPtr_Loaded_Private_Void_0;

		// Token: 0x0400684A RID: 26698
		private static readonly IntPtr NativeMethodInfoPtr_EnableGreeting_Private_Void_0;

		// Token: 0x0400684B RID: 26699
		private static readonly IntPtr NativeMethodInfoPtr_SetGreeted_Private_Void_0;

		// Token: 0x0400684C RID: 26700
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400684D RID: 26701
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400684E RID: 26702
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400684F RID: 26703
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006850 RID: 26704
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000C3D RID: 3133
		[Serializable]
		public class DealershipListing : Object
		{
			// Token: 0x0600EF5F RID: 61279 RVA: 0x0039D6EC File Offset: 0x0039B8EC
			// Note: this type is marked as 'beforefieldinit'.
			static DealershipListing()
			{
				Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Jeremy>.NativeClassPtr, "DealershipListing");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr);
				Jeremy.DealershipListing.NativeFieldInfoPtr_vehicleCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr, "vehicleCode");
				Jeremy.DealershipListing.NativeMethodInfoPtr_get_vehicleName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr, 100683060);
				Jeremy.DealershipListing.NativeMethodInfoPtr_get_price_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr, 100683061);
				Jeremy.DealershipListing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr, 100683062);
			}

			// Token: 0x17004891 RID: 18577
			// (get) Token: 0x0600EF60 RID: 61280 RVA: 0x0039D768 File Offset: 0x0039B968
			public unsafe string vehicleName
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 273174, RefRangeEnd = 273175, XrefRangeStart = 273169, XrefRangeEnd = 273174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.DealershipListing.NativeMethodInfoPtr_get_vehicleName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004892 RID: 18578
			// (get) Token: 0x0600EF61 RID: 61281 RVA: 0x0039D7A0 File Offset: 0x0039B9A0
			public unsafe float price
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 273180, RefRangeEnd = 273183, XrefRangeStart = 273175, XrefRangeEnd = 273180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.DealershipListing.NativeMethodInfoPtr_get_price_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600EF62 RID: 61282 RVA: 0x0039D7DC File Offset: 0x0039B9DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273183, XrefRangeEnd = 273187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DealershipListing() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Jeremy.DealershipListing>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jeremy.DealershipListing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF63 RID: 61283 RVA: 0x00070FF5 File Offset: 0x0006F1F5
			public DealershipListing(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004890 RID: 18576
			// (get) Token: 0x0600EF64 RID: 61284 RVA: 0x0039D818 File Offset: 0x0039BA18
			// (set) Token: 0x0600EF65 RID: 61285 RVA: 0x00070FFE File Offset: 0x0006F1FE
			public unsafe string vehicleCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.DealershipListing.NativeFieldInfoPtr_vehicleCode);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Jeremy.DealershipListing.NativeFieldInfoPtr_vehicleCode), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400A20F RID: 41487
			private static readonly IntPtr NativeFieldInfoPtr_vehicleCode;

			// Token: 0x0400A210 RID: 41488
			private static readonly IntPtr NativeMethodInfoPtr_get_vehicleName_Public_get_String_0;

			// Token: 0x0400A211 RID: 41489
			private static readonly IntPtr NativeMethodInfoPtr_get_price_Public_get_Single_0;

			// Token: 0x0400A212 RID: 41490
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
