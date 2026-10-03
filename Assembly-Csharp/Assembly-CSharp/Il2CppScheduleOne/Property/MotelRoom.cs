using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x02000166 RID: 358
	public class MotelRoom : Property
	{
		// Token: 0x0600235B RID: 9051 RVA: 0x000EFDA0 File Offset: 0x000EDFA0
		// Note: this type is marked as 'beforefieldinit'.
		static MotelRoom()
		{
			Il2CppClassPointerStore<MotelRoom>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "MotelRoom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr);
			MotelRoom.NativeFieldInfoPtr_pots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, "pots");
			MotelRoom.NativeFieldInfoPtr_packagingStations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, "packagingStations");
			MotelRoom.NativeFieldInfoPtr_mixingStations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, "mixingStations");
			MotelRoom.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.MotelRoomAssembly-CSharp.dll_Excuted");
			MotelRoom.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.MotelRoomAssembly-CSharp.dll_Excuted");
			MotelRoom.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, 100667856);
			MotelRoom.NativeMethodInfoPtr_UpdateVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, 100667857);
			MotelRoom.NativeMethodInfoPtr_CanDeliverToProperty_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, 100667858);
			MotelRoom.NativeMethodInfoPtr_BuildableItemRemoved_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, 100667859);
			MotelRoom.NativeMethodInfoPtr_BuildableItemAdded_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, 100667860);
			MotelRoom.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, 100667861);
			MotelRoom.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, 100667862);
			MotelRoom.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, 100667863);
			MotelRoom.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, 100667864);
			MotelRoom.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, 100667865);
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x000EFEFC File Offset: 0x000EE0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112733, XrefRangeEnd = 112750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MotelRoom.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x000EFF38 File Offset: 0x000EE138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112750, XrefRangeEnd = 112837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotelRoom.NativeMethodInfoPtr_UpdateVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x000EFF6C File Offset: 0x000EE16C
		[CallerCount(170)]
		[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanDeliverToProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MotelRoom.NativeMethodInfoPtr_CanDeliverToProperty_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x000EFFB4 File Offset: 0x000EE1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112837, XrefRangeEnd = 112852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildableItemRemoved(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotelRoom.NativeMethodInfoPtr_BuildableItemRemoved_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x000EFFF8 File Offset: 0x000EE1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112852, XrefRangeEnd = 112867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildableItemAdded(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotelRoom.NativeMethodInfoPtr_BuildableItemAdded_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x000F003C File Offset: 0x000EE23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112867, XrefRangeEnd = 112892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MotelRoom() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotelRoom.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002362 RID: 9058 RVA: 0x000F0078 File Offset: 0x000EE278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112892, XrefRangeEnd = 112893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MotelRoom.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x000F00B4 File Offset: 0x000EE2B4
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MotelRoom.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x000F00F0 File Offset: 0x000EE2F0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MotelRoom.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x000F012C File Offset: 0x000EE32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MotelRoom.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x00012C40 File Offset: 0x00010E40
		public MotelRoom(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06002367 RID: 9063 RVA: 0x000F0168 File Offset: 0x000EE368
		// (set) Token: 0x06002368 RID: 9064 RVA: 0x00012C49 File Offset: 0x00010E49
		public unsafe List<Pot> pots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotelRoom.NativeFieldInfoPtr_pots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Pot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotelRoom.NativeFieldInfoPtr_pots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06002369 RID: 9065 RVA: 0x000F0198 File Offset: 0x000EE398
		// (set) Token: 0x0600236A RID: 9066 RVA: 0x00012C68 File Offset: 0x00010E68
		public unsafe List<PackagingStation> packagingStations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotelRoom.NativeFieldInfoPtr_packagingStations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PackagingStation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotelRoom.NativeFieldInfoPtr_packagingStations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x000F01C8 File Offset: 0x000EE3C8
		// (set) Token: 0x0600236C RID: 9068 RVA: 0x00012C87 File Offset: 0x00010E87
		public unsafe List<MixingStation> mixingStations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotelRoom.NativeFieldInfoPtr_mixingStations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MixingStation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotelRoom.NativeFieldInfoPtr_mixingStations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x000F01F8 File Offset: 0x000EE3F8
		// (set) Token: 0x0600236E RID: 9070 RVA: 0x00012CA6 File Offset: 0x00010EA6
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotelRoom.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotelRoom.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x0600236F RID: 9071 RVA: 0x000F0220 File Offset: 0x000EE420
		// (set) Token: 0x06002370 RID: 9072 RVA: 0x00012CC1 File Offset: 0x00010EC1
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotelRoom.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MotelRoom.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04001867 RID: 6247
		private static readonly IntPtr NativeFieldInfoPtr_pots;

		// Token: 0x04001868 RID: 6248
		private static readonly IntPtr NativeFieldInfoPtr_packagingStations;

		// Token: 0x04001869 RID: 6249
		private static readonly IntPtr NativeFieldInfoPtr_mixingStations;

		// Token: 0x0400186A RID: 6250
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400186B RID: 6251
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400186C RID: 6252
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400186D RID: 6253
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVariables_Private_Void_0;

		// Token: 0x0400186E RID: 6254
		private static readonly IntPtr NativeMethodInfoPtr_CanDeliverToProperty_Public_Virtual_Boolean_0;

		// Token: 0x0400186F RID: 6255
		private static readonly IntPtr NativeMethodInfoPtr_BuildableItemRemoved_Private_Void_BuildableItem_0;

		// Token: 0x04001870 RID: 6256
		private static readonly IntPtr NativeMethodInfoPtr_BuildableItemAdded_Private_Void_BuildableItem_0;

		// Token: 0x04001871 RID: 6257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001872 RID: 6258
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04001873 RID: 6259
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04001874 RID: 6260
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04001875 RID: 6261
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000975 RID: 2421
		[ObfuscatedName("ScheduleOne.Property.MotelRoom+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600D9A3 RID: 55715 RVA: 0x00360008 File Offset: 0x0035E208
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MotelRoom.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MotelRoom>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotelRoom.__c>.NativeClassPtr);
				MotelRoom.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotelRoom.__c>.NativeClassPtr, "<>9");
				MotelRoom.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotelRoom.__c>.NativeClassPtr, "<>9__4_0");
				MotelRoom.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotelRoom.__c>.NativeClassPtr, 100667867);
				MotelRoom.__c.NativeMethodInfoPtr__UpdateVariables_b__4_0_Internal_Boolean_AdditiveDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotelRoom.__c>.NativeClassPtr, 100667868);
			}

			// Token: 0x0600D9A4 RID: 55716 RVA: 0x00360084 File Offset: 0x0035E284
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotelRoom.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotelRoom.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9A5 RID: 55717 RVA: 0x003600C0 File Offset: 0x0035E2C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112729, XrefRangeEnd = 112733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateVariables_b__4_0(AdditiveDefinition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MotelRoom.__c.NativeMethodInfoPtr__UpdateVariables_b__4_0_Internal_Boolean_AdditiveDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D9A6 RID: 55718 RVA: 0x00066535 File Offset: 0x00064735
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004275 RID: 17013
			// (get) Token: 0x0600D9A7 RID: 55719 RVA: 0x00360110 File Offset: 0x0035E310
			// (set) Token: 0x0600D9A8 RID: 55720 RVA: 0x0006653E File Offset: 0x0006473E
			public unsafe static MotelRoom.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MotelRoom.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MotelRoom.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotelRoom.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004276 RID: 17014
			// (get) Token: 0x0600D9A9 RID: 55721 RVA: 0x00360138 File Offset: 0x0035E338
			// (set) Token: 0x0600D9AA RID: 55722 RVA: 0x00066550 File Offset: 0x00064750
			public unsafe static Predicate<AdditiveDefinition> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MotelRoom.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<AdditiveDefinition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MotelRoom.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400948D RID: 38029
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400948E RID: 38030
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x0400948F RID: 38031
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009490 RID: 38032
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVariables_b__4_0_Internal_Boolean_AdditiveDefinition_0;
		}
	}
}
