using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x02000318 RID: 792
	[Serializable]
	public class CurfewInstance : Object
	{
		// Token: 0x06003DF2 RID: 15858 RVA: 0x0014C074 File Offset: 0x0014A274
		// Note: this type is marked as 'beforefieldinit'.
		static CurfewInstance()
		{
			Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "CurfewInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr);
			CurfewInstance.NativeFieldInfoPtr_ActiveInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, "ActiveInstance");
			CurfewInstance.NativeFieldInfoPtr_IntensityRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, "IntensityRequirement");
			CurfewInstance.NativeFieldInfoPtr__Enabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, "<Enabled>k__BackingField");
			CurfewInstance.NativeFieldInfoPtr_shouldDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, "shouldDisable");
			CurfewInstance.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100671198);
			CurfewInstance.NativeMethodInfoPtr_set_Enabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100671199);
			CurfewInstance.NativeMethodInfoPtr_Evaluate_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100671200);
			CurfewInstance.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100671201);
			CurfewInstance.NativeMethodInfoPtr_Enable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100671202);
			CurfewInstance.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100671203);
			CurfewInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr, 100671204);
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x06003DF3 RID: 15859 RVA: 0x0014C180 File Offset: 0x0014A380
		// (set) Token: 0x06003DF4 RID: 15860 RVA: 0x0014C1BC File Offset: 0x0014A3BC
		public unsafe bool Enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_set_Enabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x0014C1FC File Offset: 0x0014A3FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 152408, RefRangeEnd = 152411, XrefRangeStart = 152380, XrefRangeEnd = 152408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate(bool ignoreSleepReq = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ignoreSleepReq;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_Evaluate_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DF6 RID: 15862 RVA: 0x0014C23C File Offset: 0x0014A43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152411, XrefRangeEnd = 152419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DF7 RID: 15863 RVA: 0x0014C270 File Offset: 0x0014A470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152419, XrefRangeEnd = 152441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_Enable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x0014C2A4 File Offset: 0x0014A4A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152468, RefRangeEnd = 152469, XrefRangeStart = 152441, XrefRangeEnd = 152468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DF9 RID: 15865 RVA: 0x0014C2D8 File Offset: 0x0014A4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152469, XrefRangeEnd = 152470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CurfewInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurfewInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x0001ECA2 File Offset: 0x0001CEA2
		public CurfewInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x06003DFB RID: 15867 RVA: 0x0014C314 File Offset: 0x0014A514
		// (set) Token: 0x06003DFC RID: 15868 RVA: 0x0001ECAB File Offset: 0x0001CEAB
		public unsafe static CurfewInstance ActiveInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CurfewInstance.NativeFieldInfoPtr_ActiveInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CurfewInstance>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CurfewInstance.NativeFieldInfoPtr_ActiveInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x06003DFD RID: 15869 RVA: 0x0014C33C File Offset: 0x0014A53C
		// (set) Token: 0x06003DFE RID: 15870 RVA: 0x0001ECBD File Offset: 0x0001CEBD
		public unsafe int IntensityRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr_IntensityRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr_IntensityRequirement)) = value;
			}
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x06003DFF RID: 15871 RVA: 0x0014C364 File Offset: 0x0014A564
		// (set) Token: 0x06003E00 RID: 15872 RVA: 0x0001ECD8 File Offset: 0x0001CED8
		public unsafe bool _Enabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr__Enabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr__Enabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x06003E01 RID: 15873 RVA: 0x0014C38C File Offset: 0x0014A58C
		// (set) Token: 0x06003E02 RID: 15874 RVA: 0x0001ECF3 File Offset: 0x0001CEF3
		public unsafe bool shouldDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr_shouldDisable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewInstance.NativeFieldInfoPtr_shouldDisable)) = value;
			}
		}

		// Token: 0x040029CB RID: 10699
		private static readonly IntPtr NativeFieldInfoPtr_ActiveInstance;

		// Token: 0x040029CC RID: 10700
		private static readonly IntPtr NativeFieldInfoPtr_IntensityRequirement;

		// Token: 0x040029CD RID: 10701
		private static readonly IntPtr NativeFieldInfoPtr__Enabled_k__BackingField;

		// Token: 0x040029CE RID: 10702
		private static readonly IntPtr NativeFieldInfoPtr_shouldDisable;

		// Token: 0x040029CF RID: 10703
		private static readonly IntPtr NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0;

		// Token: 0x040029D0 RID: 10704
		private static readonly IntPtr NativeMethodInfoPtr_set_Enabled_Protected_set_Void_Boolean_0;

		// Token: 0x040029D1 RID: 10705
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_Boolean_0;

		// Token: 0x040029D2 RID: 10706
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x040029D3 RID: 10707
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_0;

		// Token: 0x040029D4 RID: 10708
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x040029D5 RID: 10709
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
