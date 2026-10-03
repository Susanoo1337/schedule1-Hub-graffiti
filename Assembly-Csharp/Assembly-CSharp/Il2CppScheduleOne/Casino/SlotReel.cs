using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x02000436 RID: 1078
	public class SlotReel : MonoBehaviour
	{
		// Token: 0x0600606B RID: 24683 RVA: 0x001C94F4 File Offset: 0x001C76F4
		// Note: this type is marked as 'beforefieldinit'.
		static SlotReel()
		{
			Il2CppClassPointerStore<SlotReel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "SlotReel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlotReel>.NativeClassPtr);
			SlotReel.NativeFieldInfoPtr__IsSpinning_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "<IsSpinning>k__BackingField");
			SlotReel.NativeFieldInfoPtr__CurrentSymbol_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "<CurrentSymbol>k__BackingField");
			SlotReel.NativeFieldInfoPtr__CurrentRotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "<CurrentRotation>k__BackingField");
			SlotReel.NativeFieldInfoPtr_SymbolRotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "SymbolRotations");
			SlotReel.NativeFieldInfoPtr_SpinSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "SpinSpeed");
			SlotReel.NativeFieldInfoPtr_StopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "StopSound");
			SlotReel.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "onStart");
			SlotReel.NativeFieldInfoPtr_onStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "onStop");
			SlotReel.NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100675987);
			SlotReel.NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100675988);
			SlotReel.NativeMethodInfoPtr_get_CurrentSymbol_Public_get_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100675989);
			SlotReel.NativeMethodInfoPtr_set_CurrentSymbol_Private_set_Void_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100675990);
			SlotReel.NativeMethodInfoPtr_get_CurrentRotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100675991);
			SlotReel.NativeMethodInfoPtr_set_CurrentRotation_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100675992);
			SlotReel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100675993);
			SlotReel.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100675994);
			SlotReel.NativeMethodInfoPtr_Spin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100675995);
			SlotReel.NativeMethodInfoPtr_Stop_Public_Void_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100675996);
			SlotReel.NativeMethodInfoPtr_SetSymbol_Public_Void_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100675997);
			SlotReel.NativeMethodInfoPtr_SetReelRotation_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100675998);
			SlotReel.NativeMethodInfoPtr_GetSymbolRotation_Private_Single_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100675999);
			SlotReel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676000);
		}

		// Token: 0x17001DA9 RID: 7593
		// (get) Token: 0x0600606C RID: 24684 RVA: 0x001C96DC File Offset: 0x001C78DC
		// (set) Token: 0x0600606D RID: 24685 RVA: 0x001C9718 File Offset: 0x001C7918
		public unsafe bool IsSpinning
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DAA RID: 7594
		// (get) Token: 0x0600606E RID: 24686 RVA: 0x001C9758 File Offset: 0x001C7958
		// (set) Token: 0x0600606F RID: 24687 RVA: 0x001C9794 File Offset: 0x001C7994
		public unsafe SlotMachine.ESymbol CurrentSymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_get_CurrentSymbol_Public_get_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29041, RefRangeEnd = 29043, XrefRangeStart = 29041, XrefRangeEnd = 29043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_set_CurrentSymbol_Private_set_Void_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DAB RID: 7595
		// (get) Token: 0x06006070 RID: 24688 RVA: 0x001C97D4 File Offset: 0x001C79D4
		// (set) Token: 0x06006071 RID: 24689 RVA: 0x001C9810 File Offset: 0x001C7A10
		public unsafe float CurrentRotation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 55725, RefRangeEnd = 55726, XrefRangeStart = 55725, XrefRangeEnd = 55726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_get_CurrentRotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_set_CurrentRotation_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006072 RID: 24690 RVA: 0x001C9850 File Offset: 0x001C7A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205340, XrefRangeEnd = 205344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006073 RID: 24691 RVA: 0x001C9884 File Offset: 0x001C7A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205344, XrefRangeEnd = 205361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006074 RID: 24692 RVA: 0x001C98B8 File Offset: 0x001C7AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205361, XrefRangeEnd = 205362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Spin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_Spin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006075 RID: 24693 RVA: 0x001C98EC File Offset: 0x001C7AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205362, XrefRangeEnd = 205363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop(SlotMachine.ESymbol endSymbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endSymbol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_Stop_Public_Void_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006076 RID: 24694 RVA: 0x001C992C File Offset: 0x001C7B2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29041, RefRangeEnd = 29043, XrefRangeStart = 29041, XrefRangeEnd = 29043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSymbol(SlotMachine.ESymbol symbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref symbol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_SetSymbol_Public_Void_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006077 RID: 24695 RVA: 0x001C996C File Offset: 0x001C7B6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205367, RefRangeEnd = 205369, XrefRangeStart = 205363, XrefRangeEnd = 205367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReelRotation(float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_SetReelRotation_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006078 RID: 24696 RVA: 0x001C99AC File Offset: 0x001C7BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205369, XrefRangeEnd = 205373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSymbolRotation(SlotMachine.ESymbol symbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref symbol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_GetSymbolRotation_Private_Single_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006079 RID: 24697 RVA: 0x001C99F8 File Offset: 0x001C7BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205373, XrefRangeEnd = 205374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlotReel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlotReel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600607A RID: 24698 RVA: 0x0002D7BC File Offset: 0x0002B9BC
		public SlotReel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DA1 RID: 7585
		// (get) Token: 0x0600607B RID: 24699 RVA: 0x001C9A34 File Offset: 0x001C7C34
		// (set) Token: 0x0600607C RID: 24700 RVA: 0x0002D7C5 File Offset: 0x0002B9C5
		public unsafe bool _IsSpinning_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__IsSpinning_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__IsSpinning_k__BackingField)) = value;
			}
		}

		// Token: 0x17001DA2 RID: 7586
		// (get) Token: 0x0600607D RID: 24701 RVA: 0x001C9A5C File Offset: 0x001C7C5C
		// (set) Token: 0x0600607E RID: 24702 RVA: 0x0002D7E0 File Offset: 0x0002B9E0
		public unsafe SlotMachine.ESymbol _CurrentSymbol_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__CurrentSymbol_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__CurrentSymbol_k__BackingField)) = value;
			}
		}

		// Token: 0x17001DA3 RID: 7587
		// (get) Token: 0x0600607F RID: 24703 RVA: 0x001C9A84 File Offset: 0x001C7C84
		// (set) Token: 0x06006080 RID: 24704 RVA: 0x0002D7FB File Offset: 0x0002B9FB
		public unsafe float _CurrentRotation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__CurrentRotation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__CurrentRotation_k__BackingField)) = value;
			}
		}

		// Token: 0x17001DA4 RID: 7588
		// (get) Token: 0x06006081 RID: 24705 RVA: 0x001C9AAC File Offset: 0x001C7CAC
		// (set) Token: 0x06006082 RID: 24706 RVA: 0x0002D816 File Offset: 0x0002BA16
		public unsafe Il2CppReferenceArray<SlotReel.SymbolRotation> SymbolRotations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_SymbolRotations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SlotReel.SymbolRotation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_SymbolRotations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DA5 RID: 7589
		// (get) Token: 0x06006083 RID: 24707 RVA: 0x001C9ADC File Offset: 0x001C7CDC
		// (set) Token: 0x06006084 RID: 24708 RVA: 0x0002D835 File Offset: 0x0002BA35
		public unsafe float SpinSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_SpinSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_SpinSpeed)) = value;
			}
		}

		// Token: 0x17001DA6 RID: 7590
		// (get) Token: 0x06006085 RID: 24709 RVA: 0x001C9B04 File Offset: 0x001C7D04
		// (set) Token: 0x06006086 RID: 24710 RVA: 0x0002D850 File Offset: 0x0002BA50
		public unsafe AudioSourceController StopSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_StopSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_StopSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DA7 RID: 7591
		// (get) Token: 0x06006087 RID: 24711 RVA: 0x001C9B34 File Offset: 0x001C7D34
		// (set) Token: 0x06006088 RID: 24712 RVA: 0x0002D86F File Offset: 0x0002BA6F
		public unsafe UnityEvent onStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_onStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DA8 RID: 7592
		// (get) Token: 0x06006089 RID: 24713 RVA: 0x001C9B64 File Offset: 0x001C7D64
		// (set) Token: 0x0600608A RID: 24714 RVA: 0x0002D88E File Offset: 0x0002BA8E
		public unsafe UnityEvent onStop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_onStop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_onStop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004277 RID: 17015
		private static readonly IntPtr NativeFieldInfoPtr__IsSpinning_k__BackingField;

		// Token: 0x04004278 RID: 17016
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSymbol_k__BackingField;

		// Token: 0x04004279 RID: 17017
		private static readonly IntPtr NativeFieldInfoPtr__CurrentRotation_k__BackingField;

		// Token: 0x0400427A RID: 17018
		private static readonly IntPtr NativeFieldInfoPtr_SymbolRotations;

		// Token: 0x0400427B RID: 17019
		private static readonly IntPtr NativeFieldInfoPtr_SpinSpeed;

		// Token: 0x0400427C RID: 17020
		private static readonly IntPtr NativeFieldInfoPtr_StopSound;

		// Token: 0x0400427D RID: 17021
		private static readonly IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x0400427E RID: 17022
		private static readonly IntPtr NativeFieldInfoPtr_onStop;

		// Token: 0x0400427F RID: 17023
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0;

		// Token: 0x04004280 RID: 17024
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0;

		// Token: 0x04004281 RID: 17025
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSymbol_Public_get_ESymbol_0;

		// Token: 0x04004282 RID: 17026
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSymbol_Private_set_Void_ESymbol_0;

		// Token: 0x04004283 RID: 17027
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentRotation_Public_get_Single_0;

		// Token: 0x04004284 RID: 17028
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentRotation_Private_set_Void_Single_0;

		// Token: 0x04004285 RID: 17029
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004286 RID: 17030
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004287 RID: 17031
		private static readonly IntPtr NativeMethodInfoPtr_Spin_Public_Void_0;

		// Token: 0x04004288 RID: 17032
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_ESymbol_0;

		// Token: 0x04004289 RID: 17033
		private static readonly IntPtr NativeMethodInfoPtr_SetSymbol_Public_Void_ESymbol_0;

		// Token: 0x0400428A RID: 17034
		private static readonly IntPtr NativeMethodInfoPtr_SetReelRotation_Private_Void_Single_0;

		// Token: 0x0400428B RID: 17035
		private static readonly IntPtr NativeMethodInfoPtr_GetSymbolRotation_Private_Single_ESymbol_0;

		// Token: 0x0400428C RID: 17036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B2E RID: 2862
		[Serializable]
		public class SymbolRotation : Il2CppSystem.Object
		{
			// Token: 0x0600E66F RID: 58991 RVA: 0x00383C5C File Offset: 0x00381E5C
			// Note: this type is marked as 'beforefieldinit'.
			static SymbolRotation()
			{
				Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "SymbolRotation");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr);
				SlotReel.SymbolRotation.NativeFieldInfoPtr_Symbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr, "Symbol");
				SlotReel.SymbolRotation.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr, "Rotation");
				SlotReel.SymbolRotation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr, 100676001);
			}

			// Token: 0x0600E670 RID: 58992 RVA: 0x00383CC4 File Offset: 0x00381EC4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SymbolRotation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.SymbolRotation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E671 RID: 58993 RVA: 0x0006CAFE File Offset: 0x0006ACFE
			public SymbolRotation(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045F2 RID: 17906
			// (get) Token: 0x0600E672 RID: 58994 RVA: 0x00383D00 File Offset: 0x00381F00
			// (set) Token: 0x0600E673 RID: 58995 RVA: 0x0006CB07 File Offset: 0x0006AD07
			public unsafe SlotMachine.ESymbol Symbol
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.SymbolRotation.NativeFieldInfoPtr_Symbol);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.SymbolRotation.NativeFieldInfoPtr_Symbol)) = value;
				}
			}

			// Token: 0x170045F3 RID: 17907
			// (get) Token: 0x0600E674 RID: 58996 RVA: 0x00383D28 File Offset: 0x00381F28
			// (set) Token: 0x0600E675 RID: 58997 RVA: 0x0006CB22 File Offset: 0x0006AD22
			public unsafe float Rotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.SymbolRotation.NativeFieldInfoPtr_Rotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.SymbolRotation.NativeFieldInfoPtr_Rotation)) = value;
				}
			}

			// Token: 0x04009C78 RID: 40056
			private static readonly IntPtr NativeFieldInfoPtr_Symbol;

			// Token: 0x04009C79 RID: 40057
			private static readonly IntPtr NativeFieldInfoPtr_Rotation;

			// Token: 0x04009C7A RID: 40058
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
