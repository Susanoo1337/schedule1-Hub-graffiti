using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScheduleOne.Gamepad
{
	// Token: 0x020006ED RID: 1773
	public class IHapticsManager : Il2CppObjectBase
	{
		// Token: 0x0600AB01 RID: 43777 RVA: 0x002D1EFC File Offset: 0x002D00FC
		// Note: this type is marked as 'beforefieldinit'.
		static IHapticsManager()
		{
			Il2CppClassPointerStore<IHapticsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Gamepad", "IHapticsManager");
			IHapticsManager.NativeFieldInfoPtr_PRESET_ACTION_PUNCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IHapticsManager>.NativeClassPtr, "PRESET_ACTION_PUNCH");
			IHapticsManager.NativeFieldInfoPtr_PRESET_IMPACT_PUNCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IHapticsManager>.NativeClassPtr, "PRESET_IMPACT_PUNCH");
			IHapticsManager.NativeFieldInfoPtr_PRESET_ACTION_STAB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IHapticsManager>.NativeClassPtr, "PRESET_ACTION_STAB");
			IHapticsManager.NativeFieldInfoPtr_PRESET_IMPACT_STAB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IHapticsManager>.NativeClassPtr, "PRESET_IMPACT_STAB");
			IHapticsManager.NativeFieldInfoPtr_PRESET_ACTION_BAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IHapticsManager>.NativeClassPtr, "PRESET_ACTION_BAT");
			IHapticsManager.NativeFieldInfoPtr_PRESET_IMPACT_BAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IHapticsManager>.NativeClassPtr, "PRESET_IMPACT_BAT");
			IHapticsManager.NativeFieldInfoPtr_PRESET_ACTION_BULLET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IHapticsManager>.NativeClassPtr, "PRESET_ACTION_BULLET");
			IHapticsManager.NativeFieldInfoPtr_PRESET_IMPACT_BULLET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IHapticsManager>.NativeClassPtr, "PRESET_IMPACT_BULLET");
			IHapticsManager.NativeFieldInfoPtr_PRESET_EXPLOSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IHapticsManager>.NativeClassPtr, "PRESET_EXPLOSION");
			IHapticsManager.NativeMethodInfoPtr_Begin_Public_Abstract_Virtual_New_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHapticsManager>.NativeClassPtr, 100685953);
			IHapticsManager.NativeMethodInfoPtr_Begin_Public_Abstract_Virtual_New_Void_HapticsData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHapticsManager>.NativeClassPtr, 100685954);
			IHapticsManager.NativeMethodInfoPtr_End_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHapticsManager>.NativeClassPtr, 100685955);
			IHapticsManager.NativeMethodInfoPtr_Cancel_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHapticsManager>.NativeClassPtr, 100685956);
			IHapticsManager.NativeMethodInfoPtr_SetMultiplier_Public_Abstract_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHapticsManager>.NativeClassPtr, 100685957);
			IHapticsManager.NativeMethodInfoPtr_ForceToMultiplier_Public_Abstract_Virtual_New_Single_EHapticImpact_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHapticsManager>.NativeClassPtr, 100685958);
		}

		// Token: 0x0600AB02 RID: 43778 RVA: 0x002D2050 File Offset: 0x002D0250
		[CallerCount(0)]
		public unsafe virtual void Begin(string preset, float intensityMultiplier = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(preset);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intensityMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHapticsManager.NativeMethodInfoPtr_Begin_Public_Abstract_Virtual_New_Void_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB03 RID: 43779 RVA: 0x002D20AC File Offset: 0x002D02AC
		[CallerCount(0)]
		public unsafe virtual void Begin(HapticsData data, float intensityMultiplier = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intensityMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHapticsManager.NativeMethodInfoPtr_Begin_Public_Abstract_Virtual_New_Void_HapticsData_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB04 RID: 43780 RVA: 0x002D2108 File Offset: 0x002D0308
		[CallerCount(0)]
		public unsafe virtual void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHapticsManager.NativeMethodInfoPtr_End_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB05 RID: 43781 RVA: 0x002D2144 File Offset: 0x002D0344
		[CallerCount(0)]
		public unsafe virtual void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHapticsManager.NativeMethodInfoPtr_Cancel_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB06 RID: 43782 RVA: 0x002D2180 File Offset: 0x002D0380
		[CallerCount(0)]
		public unsafe virtual void SetMultiplier(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHapticsManager.NativeMethodInfoPtr_SetMultiplier_Public_Abstract_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AB07 RID: 43783 RVA: 0x002D21CC File Offset: 0x002D03CC
		[CallerCount(0)]
		public unsafe virtual float ForceToMultiplier(EHapticImpact impact, float force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref impact;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHapticsManager.NativeMethodInfoPtr_ForceToMultiplier_Public_Abstract_Virtual_New_Single_EHapticImpact_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AB08 RID: 43784 RVA: 0x0004DFC4 File Offset: 0x0004C1C4
		public IHapticsManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003327 RID: 13095
		// (get) Token: 0x0600AB09 RID: 43785 RVA: 0x002D2230 File Offset: 0x002D0430
		// (set) Token: 0x0600AB0A RID: 43786 RVA: 0x0004DFCD File Offset: 0x0004C1CD
		public unsafe static string PRESET_ACTION_PUNCH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IHapticsManager.NativeFieldInfoPtr_PRESET_ACTION_PUNCH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IHapticsManager.NativeFieldInfoPtr_PRESET_ACTION_PUNCH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003328 RID: 13096
		// (get) Token: 0x0600AB0B RID: 43787 RVA: 0x002D2250 File Offset: 0x002D0450
		// (set) Token: 0x0600AB0C RID: 43788 RVA: 0x0004DFDF File Offset: 0x0004C1DF
		public unsafe static string PRESET_IMPACT_PUNCH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IHapticsManager.NativeFieldInfoPtr_PRESET_IMPACT_PUNCH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IHapticsManager.NativeFieldInfoPtr_PRESET_IMPACT_PUNCH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003329 RID: 13097
		// (get) Token: 0x0600AB0D RID: 43789 RVA: 0x002D2270 File Offset: 0x002D0470
		// (set) Token: 0x0600AB0E RID: 43790 RVA: 0x0004DFF1 File Offset: 0x0004C1F1
		public unsafe static string PRESET_ACTION_STAB
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IHapticsManager.NativeFieldInfoPtr_PRESET_ACTION_STAB, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IHapticsManager.NativeFieldInfoPtr_PRESET_ACTION_STAB, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700332A RID: 13098
		// (get) Token: 0x0600AB0F RID: 43791 RVA: 0x002D2290 File Offset: 0x002D0490
		// (set) Token: 0x0600AB10 RID: 43792 RVA: 0x0004E003 File Offset: 0x0004C203
		public unsafe static string PRESET_IMPACT_STAB
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IHapticsManager.NativeFieldInfoPtr_PRESET_IMPACT_STAB, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IHapticsManager.NativeFieldInfoPtr_PRESET_IMPACT_STAB, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700332B RID: 13099
		// (get) Token: 0x0600AB11 RID: 43793 RVA: 0x002D22B0 File Offset: 0x002D04B0
		// (set) Token: 0x0600AB12 RID: 43794 RVA: 0x0004E015 File Offset: 0x0004C215
		public unsafe static string PRESET_ACTION_BAT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IHapticsManager.NativeFieldInfoPtr_PRESET_ACTION_BAT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IHapticsManager.NativeFieldInfoPtr_PRESET_ACTION_BAT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700332C RID: 13100
		// (get) Token: 0x0600AB13 RID: 43795 RVA: 0x002D22D0 File Offset: 0x002D04D0
		// (set) Token: 0x0600AB14 RID: 43796 RVA: 0x0004E027 File Offset: 0x0004C227
		public unsafe static string PRESET_IMPACT_BAT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IHapticsManager.NativeFieldInfoPtr_PRESET_IMPACT_BAT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IHapticsManager.NativeFieldInfoPtr_PRESET_IMPACT_BAT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700332D RID: 13101
		// (get) Token: 0x0600AB15 RID: 43797 RVA: 0x002D22F0 File Offset: 0x002D04F0
		// (set) Token: 0x0600AB16 RID: 43798 RVA: 0x0004E039 File Offset: 0x0004C239
		public unsafe static string PRESET_ACTION_BULLET
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IHapticsManager.NativeFieldInfoPtr_PRESET_ACTION_BULLET, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IHapticsManager.NativeFieldInfoPtr_PRESET_ACTION_BULLET, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700332E RID: 13102
		// (get) Token: 0x0600AB17 RID: 43799 RVA: 0x002D2310 File Offset: 0x002D0510
		// (set) Token: 0x0600AB18 RID: 43800 RVA: 0x0004E04B File Offset: 0x0004C24B
		public unsafe static string PRESET_IMPACT_BULLET
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IHapticsManager.NativeFieldInfoPtr_PRESET_IMPACT_BULLET, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IHapticsManager.NativeFieldInfoPtr_PRESET_IMPACT_BULLET, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700332F RID: 13103
		// (get) Token: 0x0600AB19 RID: 43801 RVA: 0x002D2330 File Offset: 0x002D0530
		// (set) Token: 0x0600AB1A RID: 43802 RVA: 0x0004E05D File Offset: 0x0004C25D
		public unsafe static string PRESET_EXPLOSION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IHapticsManager.NativeFieldInfoPtr_PRESET_EXPLOSION, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IHapticsManager.NativeFieldInfoPtr_PRESET_EXPLOSION, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04007629 RID: 30249
		private static readonly IntPtr NativeFieldInfoPtr_PRESET_ACTION_PUNCH;

		// Token: 0x0400762A RID: 30250
		private static readonly IntPtr NativeFieldInfoPtr_PRESET_IMPACT_PUNCH;

		// Token: 0x0400762B RID: 30251
		private static readonly IntPtr NativeFieldInfoPtr_PRESET_ACTION_STAB;

		// Token: 0x0400762C RID: 30252
		private static readonly IntPtr NativeFieldInfoPtr_PRESET_IMPACT_STAB;

		// Token: 0x0400762D RID: 30253
		private static readonly IntPtr NativeFieldInfoPtr_PRESET_ACTION_BAT;

		// Token: 0x0400762E RID: 30254
		private static readonly IntPtr NativeFieldInfoPtr_PRESET_IMPACT_BAT;

		// Token: 0x0400762F RID: 30255
		private static readonly IntPtr NativeFieldInfoPtr_PRESET_ACTION_BULLET;

		// Token: 0x04007630 RID: 30256
		private static readonly IntPtr NativeFieldInfoPtr_PRESET_IMPACT_BULLET;

		// Token: 0x04007631 RID: 30257
		private static readonly IntPtr NativeFieldInfoPtr_PRESET_EXPLOSION;

		// Token: 0x04007632 RID: 30258
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Abstract_Virtual_New_Void_String_Single_0;

		// Token: 0x04007633 RID: 30259
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Abstract_Virtual_New_Void_HapticsData_Single_0;

		// Token: 0x04007634 RID: 30260
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04007635 RID: 30261
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04007636 RID: 30262
		private static readonly IntPtr NativeMethodInfoPtr_SetMultiplier_Public_Abstract_Virtual_New_Void_Single_0;

		// Token: 0x04007637 RID: 30263
		private static readonly IntPtr NativeMethodInfoPtr_ForceToMultiplier_Public_Abstract_Virtual_New_Single_EHapticImpact_Single_0;
	}
}
