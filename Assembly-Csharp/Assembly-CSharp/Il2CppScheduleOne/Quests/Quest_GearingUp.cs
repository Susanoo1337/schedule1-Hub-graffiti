using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppSystem;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x0200014E RID: 334
	public class Quest_GearingUp : Quest
	{
		// Token: 0x060021B2 RID: 8626 RVA: 0x000EA7B0 File Offset: 0x000E89B0
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_GearingUp()
		{
			Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_GearingUp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr);
			Quest_GearingUp.NativeFieldInfoPtr_WaitForDropEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, "WaitForDropEntry");
			Quest_GearingUp.NativeFieldInfoPtr_CollectDropEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, "CollectDropEntry");
			Quest_GearingUp.NativeFieldInfoPtr_Supplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, "Supplier");
			Quest_GearingUp.NativeFieldInfoPtr_setCollectionPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, "setCollectionPosition");
			Quest_GearingUp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, 100667664);
			Quest_GearingUp.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, 100667665);
			Quest_GearingUp.NativeMethodInfoPtr_DropReady_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, 100667666);
			Quest_GearingUp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, 100667667);
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x000EA880 File Offset: 0x000E8A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110913, XrefRangeEnd = 110922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_GearingUp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x000EA8BC File Offset: 0x000E8ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110922, XrefRangeEnd = 110957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_GearingUp.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x000EA8F8 File Offset: 0x000E8AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110957, XrefRangeEnd = 110958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_GearingUp.NativeMethodInfoPtr_DropReady_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x000EA92C File Offset: 0x000E8B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110958, XrefRangeEnd = 110962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_GearingUp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_GearingUp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x00011F8D File Offset: 0x0001018D
		public Quest_GearingUp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x060021B8 RID: 8632 RVA: 0x000EA968 File Offset: 0x000E8B68
		// (set) Token: 0x060021B9 RID: 8633 RVA: 0x00011F96 File Offset: 0x00010196
		public unsafe QuestEntry WaitForDropEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_WaitForDropEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_WaitForDropEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x060021BA RID: 8634 RVA: 0x000EA998 File Offset: 0x000E8B98
		// (set) Token: 0x060021BB RID: 8635 RVA: 0x00011FB5 File Offset: 0x000101B5
		public unsafe QuestEntry CollectDropEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_CollectDropEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_CollectDropEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x060021BC RID: 8636 RVA: 0x000EA9C8 File Offset: 0x000E8BC8
		// (set) Token: 0x060021BD RID: 8637 RVA: 0x00011FD4 File Offset: 0x000101D4
		public unsafe Supplier Supplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_Supplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_Supplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x060021BE RID: 8638 RVA: 0x000EA9F8 File Offset: 0x000E8BF8
		// (set) Token: 0x060021BF RID: 8639 RVA: 0x00011FF3 File Offset: 0x000101F3
		public unsafe bool setCollectionPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_setCollectionPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GearingUp.NativeFieldInfoPtr_setCollectionPosition)) = value;
			}
		}

		// Token: 0x04001758 RID: 5976
		private static readonly IntPtr NativeFieldInfoPtr_WaitForDropEntry;

		// Token: 0x04001759 RID: 5977
		private static readonly IntPtr NativeFieldInfoPtr_CollectDropEntry;

		// Token: 0x0400175A RID: 5978
		private static readonly IntPtr NativeFieldInfoPtr_Supplier;

		// Token: 0x0400175B RID: 5979
		private static readonly IntPtr NativeFieldInfoPtr_setCollectionPosition;

		// Token: 0x0400175C RID: 5980
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400175D RID: 5981
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0;

		// Token: 0x0400175E RID: 5982
		private static readonly IntPtr NativeMethodInfoPtr_DropReady_Private_Void_0;

		// Token: 0x0400175F RID: 5983
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200096D RID: 2413
		[ObfuscatedName("ScheduleOne.Quests.Quest_GearingUp+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600D961 RID: 55649 RVA: 0x0035F3F0 File Offset: 0x0035D5F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest_GearingUp>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr);
				Quest_GearingUp.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr, "<>9");
				Quest_GearingUp.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr, "<>9__5_0");
				Quest_GearingUp.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr, 100667669);
				Quest_GearingUp.__c.NativeMethodInfoPtr__OnUncappedMinPass_b__5_0_Internal_Boolean_DeadDrop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr, 100667670);
			}

			// Token: 0x0600D962 RID: 55650 RVA: 0x0035F46C File Offset: 0x0035D66C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_GearingUp.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_GearingUp.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D963 RID: 55651 RVA: 0x0035F4A8 File Offset: 0x0035D6A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110912, XrefRangeEnd = 110913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnUncappedMinPass_b__5_0(DeadDrop x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_GearingUp.__c.NativeMethodInfoPtr__OnUncappedMinPass_b__5_0_Internal_Boolean_DeadDrop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D964 RID: 55652 RVA: 0x00066395 File Offset: 0x00064595
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004262 RID: 16994
			// (get) Token: 0x0600D965 RID: 55653 RVA: 0x0035F4F8 File Offset: 0x0035D6F8
			// (set) Token: 0x0600D966 RID: 55654 RVA: 0x0006639E File Offset: 0x0006459E
			public unsafe static Quest_GearingUp.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest_GearingUp.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest_GearingUp.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest_GearingUp.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004263 RID: 16995
			// (get) Token: 0x0600D967 RID: 55655 RVA: 0x0035F520 File Offset: 0x0035D720
			// (set) Token: 0x0600D968 RID: 55656 RVA: 0x000663B0 File Offset: 0x000645B0
			public unsafe static Predicate<DeadDrop> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest_GearingUp.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<DeadDrop>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest_GearingUp.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009464 RID: 37988
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009465 RID: 37989
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04009466 RID: 37990
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009467 RID: 37991
			private static readonly IntPtr NativeMethodInfoPtr__OnUncappedMinPass_b__5_0_Internal_Boolean_DeadDrop_0;
		}
	}
}
