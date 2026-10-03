using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Gamepad
{
	// Token: 0x020006EB RID: 1771
	public static class HapticsHandler : Object
	{
		// Token: 0x0600AAC6 RID: 43718 RVA: 0x002D134C File Offset: 0x002CF54C
		// Note: this type is marked as 'beforefieldinit'.
		static HapticsHandler()
		{
			Il2CppClassPointerStore<HapticsHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Gamepad", "HapticsHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HapticsHandler>.NativeClassPtr);
			HapticsHandler.NativeFieldInfoPtr__hapticsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsHandler>.NativeClassPtr, "_hapticsManager");
			HapticsHandler.NativeMethodInfoPtr_SetManager_Public_Static_Void_IHapticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsHandler>.NativeClassPtr, 100685924);
			HapticsHandler.NativeMethodInfoPtr_RemoveManager_Public_Static_Void_IHapticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsHandler>.NativeClassPtr, 100685925);
			HapticsHandler.NativeMethodInfoPtr_Begin_Public_Static_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsHandler>.NativeClassPtr, 100685926);
			HapticsHandler.NativeMethodInfoPtr_Begin_Public_Static_Void_HapticsData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsHandler>.NativeClassPtr, 100685927);
			HapticsHandler.NativeMethodInfoPtr_End_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsHandler>.NativeClassPtr, 100685928);
			HapticsHandler.NativeMethodInfoPtr_Cancel_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsHandler>.NativeClassPtr, 100685929);
			HapticsHandler.NativeMethodInfoPtr_SetMultiplier_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsHandler>.NativeClassPtr, 100685930);
			HapticsHandler.NativeMethodInfoPtr_ForceToMultiplier_Public_Static_Single_EHapticImpact_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsHandler>.NativeClassPtr, 100685931);
			HapticsHandler.NativeMethodInfoPtr_IsManagerValid_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsHandler>.NativeClassPtr, 100685932);
		}

		// Token: 0x0600AAC7 RID: 43719 RVA: 0x002D1444 File Offset: 0x002CF644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294623, XrefRangeEnd = 294627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetManager(IHapticsManager hapticsManager)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(hapticsManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsHandler.NativeMethodInfoPtr_SetManager_Public_Static_Void_IHapticsManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AAC8 RID: 43720 RVA: 0x002D147C File Offset: 0x002CF67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294627, XrefRangeEnd = 294631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveManager(IHapticsManager hapticsManager)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(hapticsManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsHandler.NativeMethodInfoPtr_RemoveManager_Public_Static_Void_IHapticsManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AAC9 RID: 43721 RVA: 0x002D14B4 File Offset: 0x002CF6B4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 294637, RefRangeEnd = 294644, XrefRangeStart = 294631, XrefRangeEnd = 294637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Begin(string preset, float intensityMultiplier = 1f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(preset);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intensityMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsHandler.NativeMethodInfoPtr_Begin_Public_Static_Void_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AACA RID: 43722 RVA: 0x002D14F8 File Offset: 0x002CF6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294644, XrefRangeEnd = 294650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Begin(HapticsData data, float intensityMultiplier = 1f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intensityMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsHandler.NativeMethodInfoPtr_Begin_Public_Static_Void_HapticsData_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AACB RID: 43723 RVA: 0x002D153C File Offset: 0x002CF73C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 294656, RefRangeEnd = 294659, XrefRangeStart = 294650, XrefRangeEnd = 294656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void End()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsHandler.NativeMethodInfoPtr_End_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AACC RID: 43724 RVA: 0x002D1564 File Offset: 0x002CF764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294659, XrefRangeEnd = 294665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Cancel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsHandler.NativeMethodInfoPtr_Cancel_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AACD RID: 43725 RVA: 0x002D158C File Offset: 0x002CF78C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 294671, RefRangeEnd = 294674, XrefRangeStart = 294665, XrefRangeEnd = 294671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMultiplier(float multiplier)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsHandler.NativeMethodInfoPtr_SetMultiplier_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AACE RID: 43726 RVA: 0x002D15C0 File Offset: 0x002CF7C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294681, RefRangeEnd = 294683, XrefRangeStart = 294674, XrefRangeEnd = 294681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ForceToMultiplier(EHapticImpact impact, float force)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref impact;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsHandler.NativeMethodInfoPtr_ForceToMultiplier_Public_Static_Single_EHapticImpact_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AACF RID: 43727 RVA: 0x002D160C File Offset: 0x002CF80C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 294687, RefRangeEnd = 294694, XrefRangeStart = 294683, XrefRangeEnd = 294687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsManagerValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsHandler.NativeMethodInfoPtr_IsManagerValid_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AAD0 RID: 43728 RVA: 0x0004DDF3 File Offset: 0x0004BFF3
		public HapticsHandler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003317 RID: 13079
		// (get) Token: 0x0600AAD1 RID: 43729 RVA: 0x002D163C File Offset: 0x002CF83C
		// (set) Token: 0x0600AAD2 RID: 43730 RVA: 0x0004DDFC File Offset: 0x0004BFFC
		public unsafe static IHapticsManager _hapticsManager
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HapticsHandler.NativeFieldInfoPtr__hapticsManager, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHapticsManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HapticsHandler.NativeFieldInfoPtr__hapticsManager, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007602 RID: 30210
		private static readonly IntPtr NativeFieldInfoPtr__hapticsManager;

		// Token: 0x04007603 RID: 30211
		private static readonly IntPtr NativeMethodInfoPtr_SetManager_Public_Static_Void_IHapticsManager_0;

		// Token: 0x04007604 RID: 30212
		private static readonly IntPtr NativeMethodInfoPtr_RemoveManager_Public_Static_Void_IHapticsManager_0;

		// Token: 0x04007605 RID: 30213
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Static_Void_String_Single_0;

		// Token: 0x04007606 RID: 30214
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Static_Void_HapticsData_Single_0;

		// Token: 0x04007607 RID: 30215
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Static_Void_0;

		// Token: 0x04007608 RID: 30216
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Static_Void_0;

		// Token: 0x04007609 RID: 30217
		private static readonly IntPtr NativeMethodInfoPtr_SetMultiplier_Public_Static_Void_Single_0;

		// Token: 0x0400760A RID: 30218
		private static readonly IntPtr NativeMethodInfoPtr_ForceToMultiplier_Public_Static_Single_EHapticImpact_Single_0;

		// Token: 0x0400760B RID: 30219
		private static readonly IntPtr NativeMethodInfoPtr_IsManagerValid_Private_Static_Boolean_0;
	}
}
