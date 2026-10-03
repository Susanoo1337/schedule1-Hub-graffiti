using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Cartel
{
	// Token: 0x02000452 RID: 1106
	public class GoonPool : MonoBehaviour
	{
		// Token: 0x0600647A RID: 25722 RVA: 0x001D7B98 File Offset: 0x001D5D98
		// Note: this type is marked as 'beforefieldinit'.
		static GoonPool()
		{
			Il2CppClassPointerStore<GoonPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cartel", "GoonPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoonPool>.NativeClassPtr);
			GoonPool.NativeFieldInfoPtr_MALE_CHANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoonPool>.NativeClassPtr, "MALE_CHANCE");
			GoonPool.NativeFieldInfoPtr_goons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoonPool>.NativeClassPtr, "goons");
			GoonPool.NativeFieldInfoPtr_exitBuildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoonPool>.NativeClassPtr, "exitBuildings");
			GoonPool.NativeFieldInfoPtr_MaleBaseAppearances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoonPool>.NativeClassPtr, "MaleBaseAppearances");
			GoonPool.NativeFieldInfoPtr_FemaleBaseAppearances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoonPool>.NativeClassPtr, "FemaleBaseAppearances");
			GoonPool.NativeFieldInfoPtr_MaleClothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoonPool>.NativeClassPtr, "MaleClothing");
			GoonPool.NativeFieldInfoPtr_FemaleClothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoonPool>.NativeClassPtr, "FemaleClothing");
			GoonPool.NativeFieldInfoPtr_MaleVoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoonPool>.NativeClassPtr, "MaleVoices");
			GoonPool.NativeFieldInfoPtr_FemaleVoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoonPool>.NativeClassPtr, "FemaleVoices");
			GoonPool.NativeFieldInfoPtr_SkinTones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoonPool>.NativeClassPtr, "SkinTones");
			GoonPool.NativeFieldInfoPtr_HairColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoonPool>.NativeClassPtr, "HairColors");
			GoonPool.NativeFieldInfoPtr_spawnedGoons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoonPool>.NativeClassPtr, "spawnedGoons");
			GoonPool.NativeFieldInfoPtr_unspawnedGoons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoonPool>.NativeClassPtr, "unspawnedGoons");
			GoonPool.NativeMethodInfoPtr_get_UnspawnedGoonCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoonPool>.NativeClassPtr, 100676507);
			GoonPool.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoonPool>.NativeClassPtr, 100676508);
			GoonPool.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoonPool>.NativeClassPtr, 100676509);
			GoonPool.NativeMethodInfoPtr_SpawnMultipleGoons_Public_List_1_CartelGoon_Vector3_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoonPool>.NativeClassPtr, 100676510);
			GoonPool.NativeMethodInfoPtr_GetRandomAppearance_Public_CartelGoonAppearance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoonPool>.NativeClassPtr, 100676511);
			GoonPool.NativeMethodInfoPtr_SpawnGoon_Public_CartelGoon_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoonPool>.NativeClassPtr, 100676512);
			GoonPool.NativeMethodInfoPtr_ReturnToPool_Public_Void_CartelGoon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoonPool>.NativeClassPtr, 100676513);
			GoonPool.NativeMethodInfoPtr_GetNearestExitBuilding_Public_NPCEnterableBuilding_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoonPool>.NativeClassPtr, 100676514);
			GoonPool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoonPool>.NativeClassPtr, 100676515);
		}

		// Token: 0x17001ED8 RID: 7896
		// (get) Token: 0x0600647B RID: 25723 RVA: 0x001D7D80 File Offset: 0x001D5F80
		public unsafe int UnspawnedGoonCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211057, XrefRangeEnd = 211058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoonPool.NativeMethodInfoPtr_get_UnspawnedGoonCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600647C RID: 25724 RVA: 0x001D7DBC File Offset: 0x001D5FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211058, XrefRangeEnd = 211076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoonPool.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600647D RID: 25725 RVA: 0x001D7DF8 File Offset: 0x001D5FF8
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoonPool.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600647E RID: 25726 RVA: 0x001D7E2C File Offset: 0x001D602C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211103, RefRangeEnd = 211104, XrefRangeStart = 211076, XrefRangeEnd = 211103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<CartelGoon> SpawnMultipleGoons(Vector3 spawnPoint, int requestedAmount, bool setAsGoonMates = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref spawnPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestedAmount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setAsGoonMates;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoonPool.NativeMethodInfoPtr_SpawnMultipleGoons_Public_List_1_CartelGoon_Vector3_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CartelGoon>>(intPtr3) : null;
		}

		// Token: 0x0600647F RID: 25727 RVA: 0x001D7E94 File Offset: 0x001D6094
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211119, RefRangeEnd = 211122, XrefRangeStart = 211104, XrefRangeEnd = 211119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelGoonAppearance GetRandomAppearance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoonPool.NativeMethodInfoPtr_GetRandomAppearance_Public_CartelGoonAppearance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CartelGoonAppearance>(intPtr3) : null;
		}

		// Token: 0x06006480 RID: 25728 RVA: 0x001D7ED4 File Offset: 0x001D60D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211135, RefRangeEnd = 211137, XrefRangeStart = 211122, XrefRangeEnd = 211135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelGoon SpawnGoon(Vector3 spawnPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref spawnPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoonPool.NativeMethodInfoPtr_SpawnGoon_Public_CartelGoon_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CartelGoon>(intPtr3) : null;
		}

		// Token: 0x06006481 RID: 25729 RVA: 0x001D7F20 File Offset: 0x001D6120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211137, XrefRangeEnd = 211162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnToPool(CartelGoon goon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(goon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoonPool.NativeMethodInfoPtr_ReturnToPool_Public_Void_CartelGoon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006482 RID: 25730 RVA: 0x001D7F64 File Offset: 0x001D6164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211172, RefRangeEnd = 211173, XrefRangeStart = 211162, XrefRangeEnd = 211172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCEnterableBuilding GetNearestExitBuilding(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoonPool.NativeMethodInfoPtr_GetNearestExitBuilding_Public_NPCEnterableBuilding_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCEnterableBuilding>(intPtr3) : null;
		}

		// Token: 0x06006483 RID: 25731 RVA: 0x001D7FB0 File Offset: 0x001D61B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211173, XrefRangeEnd = 211186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoonPool() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoonPool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoonPool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006484 RID: 25732 RVA: 0x0002F4B2 File Offset: 0x0002D6B2
		public GoonPool(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001ECB RID: 7883
		// (get) Token: 0x06006485 RID: 25733 RVA: 0x001D7FEC File Offset: 0x001D61EC
		// (set) Token: 0x06006486 RID: 25734 RVA: 0x0002F4BB File Offset: 0x0002D6BB
		public unsafe static float MALE_CHANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GoonPool.NativeFieldInfoPtr_MALE_CHANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoonPool.NativeFieldInfoPtr_MALE_CHANCE, (void*)(&value));
			}
		}

		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x06006487 RID: 25735 RVA: 0x001D8008 File Offset: 0x001D6208
		// (set) Token: 0x06006488 RID: 25736 RVA: 0x0002F4C9 File Offset: 0x0002D6C9
		public unsafe Il2CppReferenceArray<CartelGoon> goons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_goons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CartelGoon>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_goons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ECD RID: 7885
		// (get) Token: 0x06006489 RID: 25737 RVA: 0x001D8038 File Offset: 0x001D6238
		// (set) Token: 0x0600648A RID: 25738 RVA: 0x0002F4E8 File Offset: 0x0002D6E8
		public unsafe Il2CppReferenceArray<NPCEnterableBuilding> exitBuildings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_exitBuildings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NPCEnterableBuilding>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_exitBuildings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ECE RID: 7886
		// (get) Token: 0x0600648B RID: 25739 RVA: 0x001D8068 File Offset: 0x001D6268
		// (set) Token: 0x0600648C RID: 25740 RVA: 0x0002F507 File Offset: 0x0002D707
		public unsafe Il2CppReferenceArray<AvatarSettings> MaleBaseAppearances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_MaleBaseAppearances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AvatarSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_MaleBaseAppearances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ECF RID: 7887
		// (get) Token: 0x0600648D RID: 25741 RVA: 0x001D8098 File Offset: 0x001D6298
		// (set) Token: 0x0600648E RID: 25742 RVA: 0x0002F526 File Offset: 0x0002D726
		public unsafe Il2CppReferenceArray<AvatarSettings> FemaleBaseAppearances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_FemaleBaseAppearances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AvatarSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_FemaleBaseAppearances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED0 RID: 7888
		// (get) Token: 0x0600648F RID: 25743 RVA: 0x001D80C8 File Offset: 0x001D62C8
		// (set) Token: 0x06006490 RID: 25744 RVA: 0x0002F545 File Offset: 0x0002D745
		public unsafe Il2CppReferenceArray<AvatarSettings> MaleClothing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_MaleClothing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AvatarSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_MaleClothing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x06006491 RID: 25745 RVA: 0x001D80F8 File Offset: 0x001D62F8
		// (set) Token: 0x06006492 RID: 25746 RVA: 0x0002F564 File Offset: 0x0002D764
		public unsafe Il2CppReferenceArray<AvatarSettings> FemaleClothing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_FemaleClothing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AvatarSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_FemaleClothing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED2 RID: 7890
		// (get) Token: 0x06006493 RID: 25747 RVA: 0x001D8128 File Offset: 0x001D6328
		// (set) Token: 0x06006494 RID: 25748 RVA: 0x0002F583 File Offset: 0x0002D783
		public unsafe Il2CppReferenceArray<VODatabase> MaleVoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_MaleVoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VODatabase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_MaleVoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED3 RID: 7891
		// (get) Token: 0x06006495 RID: 25749 RVA: 0x001D8158 File Offset: 0x001D6358
		// (set) Token: 0x06006496 RID: 25750 RVA: 0x0002F5A2 File Offset: 0x0002D7A2
		public unsafe Il2CppReferenceArray<VODatabase> FemaleVoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_FemaleVoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VODatabase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_FemaleVoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED4 RID: 7892
		// (get) Token: 0x06006497 RID: 25751 RVA: 0x001D8188 File Offset: 0x001D6388
		// (set) Token: 0x06006498 RID: 25752 RVA: 0x0002F5C1 File Offset: 0x0002D7C1
		public unsafe Il2CppStructArray<Color> SkinTones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_SkinTones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_SkinTones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED5 RID: 7893
		// (get) Token: 0x06006499 RID: 25753 RVA: 0x001D81B8 File Offset: 0x001D63B8
		// (set) Token: 0x0600649A RID: 25754 RVA: 0x0002F5E0 File Offset: 0x0002D7E0
		public unsafe Il2CppStructArray<Color> HairColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_HairColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_HairColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED6 RID: 7894
		// (get) Token: 0x0600649B RID: 25755 RVA: 0x001D81E8 File Offset: 0x001D63E8
		// (set) Token: 0x0600649C RID: 25756 RVA: 0x0002F5FF File Offset: 0x0002D7FF
		public unsafe List<CartelGoon> spawnedGoons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_spawnedGoons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CartelGoon>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_spawnedGoons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED7 RID: 7895
		// (get) Token: 0x0600649D RID: 25757 RVA: 0x001D8218 File Offset: 0x001D6418
		// (set) Token: 0x0600649E RID: 25758 RVA: 0x0002F61E File Offset: 0x0002D81E
		public unsafe List<CartelGoon> unspawnedGoons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_unspawnedGoons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CartelGoon>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoonPool.NativeFieldInfoPtr_unspawnedGoons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400454C RID: 17740
		private static readonly IntPtr NativeFieldInfoPtr_MALE_CHANCE;

		// Token: 0x0400454D RID: 17741
		private static readonly IntPtr NativeFieldInfoPtr_goons;

		// Token: 0x0400454E RID: 17742
		private static readonly IntPtr NativeFieldInfoPtr_exitBuildings;

		// Token: 0x0400454F RID: 17743
		private static readonly IntPtr NativeFieldInfoPtr_MaleBaseAppearances;

		// Token: 0x04004550 RID: 17744
		private static readonly IntPtr NativeFieldInfoPtr_FemaleBaseAppearances;

		// Token: 0x04004551 RID: 17745
		private static readonly IntPtr NativeFieldInfoPtr_MaleClothing;

		// Token: 0x04004552 RID: 17746
		private static readonly IntPtr NativeFieldInfoPtr_FemaleClothing;

		// Token: 0x04004553 RID: 17747
		private static readonly IntPtr NativeFieldInfoPtr_MaleVoices;

		// Token: 0x04004554 RID: 17748
		private static readonly IntPtr NativeFieldInfoPtr_FemaleVoices;

		// Token: 0x04004555 RID: 17749
		private static readonly IntPtr NativeFieldInfoPtr_SkinTones;

		// Token: 0x04004556 RID: 17750
		private static readonly IntPtr NativeFieldInfoPtr_HairColors;

		// Token: 0x04004557 RID: 17751
		private static readonly IntPtr NativeFieldInfoPtr_spawnedGoons;

		// Token: 0x04004558 RID: 17752
		private static readonly IntPtr NativeFieldInfoPtr_unspawnedGoons;

		// Token: 0x04004559 RID: 17753
		private static readonly IntPtr NativeMethodInfoPtr_get_UnspawnedGoonCount_Public_get_Int32_0;

		// Token: 0x0400455A RID: 17754
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400455B RID: 17755
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400455C RID: 17756
		private static readonly IntPtr NativeMethodInfoPtr_SpawnMultipleGoons_Public_List_1_CartelGoon_Vector3_Int32_Boolean_0;

		// Token: 0x0400455D RID: 17757
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomAppearance_Public_CartelGoonAppearance_0;

		// Token: 0x0400455E RID: 17758
		private static readonly IntPtr NativeMethodInfoPtr_SpawnGoon_Public_CartelGoon_Vector3_0;

		// Token: 0x0400455F RID: 17759
		private static readonly IntPtr NativeMethodInfoPtr_ReturnToPool_Public_Void_CartelGoon_0;

		// Token: 0x04004560 RID: 17760
		private static readonly IntPtr NativeMethodInfoPtr_GetNearestExitBuilding_Public_NPCEnterableBuilding_Vector3_0;

		// Token: 0x04004561 RID: 17761
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
