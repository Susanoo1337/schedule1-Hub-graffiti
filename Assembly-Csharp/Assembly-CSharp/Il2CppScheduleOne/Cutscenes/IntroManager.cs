using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Customization;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.State;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Cutscenes
{
	// Token: 0x02000421 RID: 1057
	public class IntroManager : Singleton<IntroManager>
	{
		// Token: 0x06005D66 RID: 23910 RVA: 0x001BD2F8 File Offset: 0x001BB4F8
		// Note: this type is marked as 'beforefieldinit'.
		static IntroManager()
		{
			Il2CppClassPointerStore<IntroManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cutscenes", "IntroManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntroManager>.NativeClassPtr);
			IntroManager.NativeFieldInfoPtr_SkipInputTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "SkipInputTime");
			IntroManager.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "<IsPlaying>k__BackingField");
			IntroManager.NativeFieldInfoPtr_CurrentStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "CurrentStep");
			IntroManager.NativeFieldInfoPtr_TimeOfDayOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "TimeOfDayOverride");
			IntroManager.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "Container");
			IntroManager.NativeFieldInfoPtr_PlayerInitialPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "PlayerInitialPosition");
			IntroManager.NativeFieldInfoPtr_PlayerInitialPosition_AfterRVExplosion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "PlayerInitialPosition_AfterRVExplosion");
			IntroManager.NativeFieldInfoPtr_CameraContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "CameraContainer");
			IntroManager.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "Anim");
			IntroManager.NativeFieldInfoPtr_SkipContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "SkipContainer");
			IntroManager.NativeFieldInfoPtr_SkipDial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "SkipDial");
			IntroManager.NativeFieldInfoPtr_DisableDuringIntro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "DisableDuringIntro");
			IntroManager.NativeFieldInfoPtr_rv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "rv");
			IntroManager.NativeFieldInfoPtr_onIntroDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "onIntroDone");
			IntroManager.NativeFieldInfoPtr_onIntroDoneAsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "onIntroDoneAsServer");
			IntroManager.NativeFieldInfoPtr_MusicName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "MusicName");
			IntroManager.NativeFieldInfoPtr_currentSkipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "currentSkipTime");
			IntroManager.NativeFieldInfoPtr_depressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "depressed");
			IntroManager.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "_state");
			IntroManager.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100675487);
			IntroManager.NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100675488);
			IntroManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100675489);
			IntroManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100675490);
			IntroManager.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100675491);
			IntroManager.NativeMethodInfoPtr_PlayMusic_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100675492);
			IntroManager.NativeMethodInfoPtr_CharacterCreationDone_Public_Void_BasicAvatarSettings_List_1_ClothingInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100675493);
			IntroManager.NativeMethodInfoPtr_PassedStep_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100675494);
			IntroManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100675495);
			IntroManager.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100675496);
			IntroManager.NativeMethodInfoPtr__Play_b__24_2_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100675497);
		}

		// Token: 0x17001CED RID: 7405
		// (get) Token: 0x06005D67 RID: 23911 RVA: 0x001BD580 File Offset: 0x001BB780
		// (set) Token: 0x06005D68 RID: 23912 RVA: 0x001BD5BC File Offset: 0x001BB7BC
		public unsafe bool IsPlaying
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 33070, RefRangeEnd = 33090, XrefRangeStart = 33070, XrefRangeEnd = 33090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005D69 RID: 23913 RVA: 0x001BD5FC File Offset: 0x001BB7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199792, XrefRangeEnd = 199798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntroManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D6A RID: 23914 RVA: 0x001BD638 File Offset: 0x001BB838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199798, XrefRangeEnd = 199826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D6B RID: 23915 RVA: 0x001BD66C File Offset: 0x001BB86C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199872, RefRangeEnd = 199873, XrefRangeStart = 199826, XrefRangeEnd = 199872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D6C RID: 23916 RVA: 0x001BD6A0 File Offset: 0x001BB8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199873, XrefRangeEnd = 199879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayMusic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_PlayMusic_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D6D RID: 23917 RVA: 0x001BD6D4 File Offset: 0x001BB8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199879, XrefRangeEnd = 199892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CharacterCreationDone(BasicAvatarSettings avatar, List<ClothingInstance> clothes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(avatar);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clothes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_CharacterCreationDone_Public_Void_BasicAvatarSettings_List_1_ClothingInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D6E RID: 23918 RVA: 0x001BD728 File Offset: 0x001BB928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165205, RefRangeEnd = 165206, XrefRangeStart = 165205, XrefRangeEnd = 165206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PassedStep(int stepIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stepIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_PassedStep_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D6F RID: 23919 RVA: 0x001BD768 File Offset: 0x001BB968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199892, XrefRangeEnd = 199895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntroManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntroManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D70 RID: 23920 RVA: 0x001BD7A4 File Offset: 0x001BB9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199895, XrefRangeEnd = 199900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005D71 RID: 23921 RVA: 0x001BD7E4 File Offset: 0x001BB9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199900, XrefRangeEnd = 199901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Play_b__24_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr__Play_b__24_2_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005D72 RID: 23922 RVA: 0x0002C45F File Offset: 0x0002A65F
		public IntroManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CDA RID: 7386
		// (get) Token: 0x06005D73 RID: 23923 RVA: 0x001BD820 File Offset: 0x001BBA20
		// (set) Token: 0x06005D74 RID: 23924 RVA: 0x0002C468 File Offset: 0x0002A668
		public unsafe static float SkipInputTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(IntroManager.NativeFieldInfoPtr_SkipInputTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntroManager.NativeFieldInfoPtr_SkipInputTime, (void*)(&value));
			}
		}

		// Token: 0x17001CDB RID: 7387
		// (get) Token: 0x06005D75 RID: 23925 RVA: 0x001BD83C File Offset: 0x001BBA3C
		// (set) Token: 0x06005D76 RID: 23926 RVA: 0x0002C476 File Offset: 0x0002A676
		public unsafe bool _IsPlaying_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr__IsPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr__IsPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x17001CDC RID: 7388
		// (get) Token: 0x06005D77 RID: 23927 RVA: 0x001BD864 File Offset: 0x001BBA64
		// (set) Token: 0x06005D78 RID: 23928 RVA: 0x0002C491 File Offset: 0x0002A691
		public unsafe int CurrentStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_CurrentStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_CurrentStep)) = value;
			}
		}

		// Token: 0x17001CDD RID: 7389
		// (get) Token: 0x06005D79 RID: 23929 RVA: 0x001BD88C File Offset: 0x001BBA8C
		// (set) Token: 0x06005D7A RID: 23930 RVA: 0x0002C4AC File Offset: 0x0002A6AC
		public unsafe int TimeOfDayOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_TimeOfDayOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_TimeOfDayOverride)) = value;
			}
		}

		// Token: 0x17001CDE RID: 7390
		// (get) Token: 0x06005D7B RID: 23931 RVA: 0x001BD8B4 File Offset: 0x001BBAB4
		// (set) Token: 0x06005D7C RID: 23932 RVA: 0x0002C4C7 File Offset: 0x0002A6C7
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CDF RID: 7391
		// (get) Token: 0x06005D7D RID: 23933 RVA: 0x001BD8E4 File Offset: 0x001BBAE4
		// (set) Token: 0x06005D7E RID: 23934 RVA: 0x0002C4E6 File Offset: 0x0002A6E6
		public unsafe Transform PlayerInitialPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_PlayerInitialPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_PlayerInitialPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CE0 RID: 7392
		// (get) Token: 0x06005D7F RID: 23935 RVA: 0x001BD914 File Offset: 0x001BBB14
		// (set) Token: 0x06005D80 RID: 23936 RVA: 0x0002C505 File Offset: 0x0002A705
		public unsafe Transform PlayerInitialPosition_AfterRVExplosion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_PlayerInitialPosition_AfterRVExplosion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_PlayerInitialPosition_AfterRVExplosion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CE1 RID: 7393
		// (get) Token: 0x06005D81 RID: 23937 RVA: 0x001BD944 File Offset: 0x001BBB44
		// (set) Token: 0x06005D82 RID: 23938 RVA: 0x0002C524 File Offset: 0x0002A724
		public unsafe Transform CameraContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_CameraContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_CameraContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CE2 RID: 7394
		// (get) Token: 0x06005D83 RID: 23939 RVA: 0x001BD974 File Offset: 0x001BBB74
		// (set) Token: 0x06005D84 RID: 23940 RVA: 0x0002C543 File Offset: 0x0002A743
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CE3 RID: 7395
		// (get) Token: 0x06005D85 RID: 23941 RVA: 0x001BD9A4 File Offset: 0x001BBBA4
		// (set) Token: 0x06005D86 RID: 23942 RVA: 0x0002C562 File Offset: 0x0002A762
		public unsafe GameObject SkipContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_SkipContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_SkipContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CE4 RID: 7396
		// (get) Token: 0x06005D87 RID: 23943 RVA: 0x001BD9D4 File Offset: 0x001BBBD4
		// (set) Token: 0x06005D88 RID: 23944 RVA: 0x0002C581 File Offset: 0x0002A781
		public unsafe Image SkipDial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_SkipDial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_SkipDial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CE5 RID: 7397
		// (get) Token: 0x06005D89 RID: 23945 RVA: 0x001BDA04 File Offset: 0x001BBC04
		// (set) Token: 0x06005D8A RID: 23946 RVA: 0x0002C5A0 File Offset: 0x0002A7A0
		public unsafe Il2CppReferenceArray<GameObject> DisableDuringIntro
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_DisableDuringIntro);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_DisableDuringIntro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CE6 RID: 7398
		// (get) Token: 0x06005D8B RID: 23947 RVA: 0x001BDA34 File Offset: 0x001BBC34
		// (set) Token: 0x06005D8C RID: 23948 RVA: 0x0002C5BF File Offset: 0x0002A7BF
		public unsafe RV rv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_rv);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RV>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_rv), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CE7 RID: 7399
		// (get) Token: 0x06005D8D RID: 23949 RVA: 0x001BDA64 File Offset: 0x001BBC64
		// (set) Token: 0x06005D8E RID: 23950 RVA: 0x0002C5DE File Offset: 0x0002A7DE
		public unsafe UnityEvent onIntroDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_onIntroDone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_onIntroDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CE8 RID: 7400
		// (get) Token: 0x06005D8F RID: 23951 RVA: 0x001BDA94 File Offset: 0x001BBC94
		// (set) Token: 0x06005D90 RID: 23952 RVA: 0x0002C5FD File Offset: 0x0002A7FD
		public unsafe UnityEvent onIntroDoneAsServer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_onIntroDoneAsServer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_onIntroDoneAsServer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CE9 RID: 7401
		// (get) Token: 0x06005D91 RID: 23953 RVA: 0x001BDAC4 File Offset: 0x001BBCC4
		// (set) Token: 0x06005D92 RID: 23954 RVA: 0x0002C61C File Offset: 0x0002A81C
		public unsafe string MusicName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_MusicName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_MusicName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CEA RID: 7402
		// (get) Token: 0x06005D93 RID: 23955 RVA: 0x001BDAEC File Offset: 0x001BBCEC
		// (set) Token: 0x06005D94 RID: 23956 RVA: 0x0002C63B File Offset: 0x0002A83B
		public unsafe float currentSkipTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_currentSkipTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_currentSkipTime)) = value;
			}
		}

		// Token: 0x17001CEB RID: 7403
		// (get) Token: 0x06005D95 RID: 23957 RVA: 0x001BDB14 File Offset: 0x001BBD14
		// (set) Token: 0x06005D96 RID: 23958 RVA: 0x0002C656 File Offset: 0x0002A856
		public unsafe bool depressed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_depressed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_depressed)) = value;
			}
		}

		// Token: 0x17001CEC RID: 7404
		// (get) Token: 0x06005D97 RID: 23959 RVA: 0x001BDB3C File Offset: 0x001BBD3C
		// (set) Token: 0x06005D98 RID: 23960 RVA: 0x0002C671 File Offset: 0x0002A871
		public unsafe State _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr__state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<State>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr__state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004013 RID: 16403
		private static readonly IntPtr NativeFieldInfoPtr_SkipInputTime;

		// Token: 0x04004014 RID: 16404
		private static readonly IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;

		// Token: 0x04004015 RID: 16405
		private static readonly IntPtr NativeFieldInfoPtr_CurrentStep;

		// Token: 0x04004016 RID: 16406
		private static readonly IntPtr NativeFieldInfoPtr_TimeOfDayOverride;

		// Token: 0x04004017 RID: 16407
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04004018 RID: 16408
		private static readonly IntPtr NativeFieldInfoPtr_PlayerInitialPosition;

		// Token: 0x04004019 RID: 16409
		private static readonly IntPtr NativeFieldInfoPtr_PlayerInitialPosition_AfterRVExplosion;

		// Token: 0x0400401A RID: 16410
		private static readonly IntPtr NativeFieldInfoPtr_CameraContainer;

		// Token: 0x0400401B RID: 16411
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x0400401C RID: 16412
		private static readonly IntPtr NativeFieldInfoPtr_SkipContainer;

		// Token: 0x0400401D RID: 16413
		private static readonly IntPtr NativeFieldInfoPtr_SkipDial;

		// Token: 0x0400401E RID: 16414
		private static readonly IntPtr NativeFieldInfoPtr_DisableDuringIntro;

		// Token: 0x0400401F RID: 16415
		private static readonly IntPtr NativeFieldInfoPtr_rv;

		// Token: 0x04004020 RID: 16416
		private static readonly IntPtr NativeFieldInfoPtr_onIntroDone;

		// Token: 0x04004021 RID: 16417
		private static readonly IntPtr NativeFieldInfoPtr_onIntroDoneAsServer;

		// Token: 0x04004022 RID: 16418
		private static readonly IntPtr NativeFieldInfoPtr_MusicName;

		// Token: 0x04004023 RID: 16419
		private static readonly IntPtr NativeFieldInfoPtr_currentSkipTime;

		// Token: 0x04004024 RID: 16420
		private static readonly IntPtr NativeFieldInfoPtr_depressed;

		// Token: 0x04004025 RID: 16421
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x04004026 RID: 16422
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x04004027 RID: 16423
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0;

		// Token: 0x04004028 RID: 16424
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004029 RID: 16425
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400402A RID: 16426
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x0400402B RID: 16427
		private static readonly IntPtr NativeMethodInfoPtr_PlayMusic_Private_Void_0;

		// Token: 0x0400402C RID: 16428
		private static readonly IntPtr NativeMethodInfoPtr_CharacterCreationDone_Public_Void_BasicAvatarSettings_List_1_ClothingInstance_0;

		// Token: 0x0400402D RID: 16429
		private static readonly IntPtr NativeMethodInfoPtr_PassedStep_Public_Void_Int32_0;

		// Token: 0x0400402E RID: 16430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400402F RID: 16431
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04004030 RID: 16432
		private static readonly IntPtr NativeMethodInfoPtr__Play_b__24_2_Private_Boolean_0;

		// Token: 0x02000B08 RID: 2824
		[ObfuscatedName("ScheduleOne.Cutscenes.IntroManager+<<Play>g__Wait|24_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600E598 RID: 58776 RVA: 0x003816D4 File Offset: 0x0037F8D4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique()
			{
				Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "<<Play>g__Wait|24_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr);
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>1__state");
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>2__current");
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>4__this");
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100675498);
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100675499);
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100675500);
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100675501);
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100675502);
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100675503);
			}

			// Token: 0x0600E599 RID: 58777 RVA: 0x003817B4 File Offset: 0x0037F9B4
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E59A RID: 58778 RVA: 0x003817FC File Offset: 0x0037F9FC
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E59B RID: 58779 RVA: 0x00381830 File Offset: 0x0037FA30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199584, XrefRangeEnd = 199695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170045BF RID: 17855
			// (get) Token: 0x0600E59C RID: 58780 RVA: 0x0038186C File Offset: 0x0037FA6C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E59D RID: 58781 RVA: 0x003818AC File Offset: 0x0037FAAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199695, XrefRangeEnd = 199700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170045C0 RID: 17856
			// (get) Token: 0x0600E59E RID: 58782 RVA: 0x003818E0 File Offset: 0x0037FAE0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E59F RID: 58783 RVA: 0x0006C44F File Offset: 0x0006A64F
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045BC RID: 17852
			// (get) Token: 0x0600E5A0 RID: 58784 RVA: 0x00381920 File Offset: 0x0037FB20
			// (set) Token: 0x0600E5A1 RID: 58785 RVA: 0x0006C458 File Offset: 0x0006A658
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170045BD RID: 17853
			// (get) Token: 0x0600E5A2 RID: 58786 RVA: 0x00381948 File Offset: 0x0037FB48
			// (set) Token: 0x0600E5A3 RID: 58787 RVA: 0x0006C473 File Offset: 0x0006A673
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045BE RID: 17854
			// (get) Token: 0x0600E5A4 RID: 58788 RVA: 0x00381978 File Offset: 0x0037FB78
			// (set) Token: 0x0600E5A5 RID: 58789 RVA: 0x0006C492 File Offset: 0x0006A692
			public unsafe IntroManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntroManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BD3 RID: 39891
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009BD4 RID: 39892
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009BD5 RID: 39893
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009BD6 RID: 39894
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009BD7 RID: 39895
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009BD8 RID: 39896
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009BD9 RID: 39897
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009BDA RID: 39898
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009BDB RID: 39899
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B09 RID: 2825
		[ObfuscatedName("ScheduleOne.Cutscenes.IntroManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E5A6 RID: 58790 RVA: 0x003819A8 File Offset: 0x0037FBA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IntroManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntroManager.__c>.NativeClassPtr);
				IntroManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.__c>.NativeClassPtr, "<>9");
				IntroManager.__c.NativeFieldInfoPtr___9__24_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.__c>.NativeClassPtr, "<>9__24_1");
				IntroManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c>.NativeClassPtr, 100675505);
				IntroManager.__c.NativeMethodInfoPtr__Play_b__24_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c>.NativeClassPtr, 100675506);
			}

			// Token: 0x0600E5A7 RID: 58791 RVA: 0x00381A24 File Offset: 0x0037FC24
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntroManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5A8 RID: 58792 RVA: 0x00381A60 File Offset: 0x0037FC60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199700, XrefRangeEnd = 199704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Play_b__24_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c.NativeMethodInfoPtr__Play_b__24_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E5A9 RID: 58793 RVA: 0x0006C4B1 File Offset: 0x0006A6B1
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045C1 RID: 17857
			// (get) Token: 0x0600E5AA RID: 58794 RVA: 0x00381A9C File Offset: 0x0037FC9C
			// (set) Token: 0x0600E5AB RID: 58795 RVA: 0x0006C4BA File Offset: 0x0006A6BA
			public unsafe static IntroManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IntroManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntroManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IntroManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045C2 RID: 17858
			// (get) Token: 0x0600E5AC RID: 58796 RVA: 0x00381AC4 File Offset: 0x0037FCC4
			// (set) Token: 0x0600E5AD RID: 58797 RVA: 0x0006C4CC File Offset: 0x0006A6CC
			public unsafe static Func<bool> __9__24_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IntroManager.__c.NativeFieldInfoPtr___9__24_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IntroManager.__c.NativeFieldInfoPtr___9__24_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BDC RID: 39900
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009BDD RID: 39901
			private static readonly IntPtr NativeFieldInfoPtr___9__24_1;

			// Token: 0x04009BDE RID: 39902
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BDF RID: 39903
			private static readonly IntPtr NativeMethodInfoPtr__Play_b__24_1_Internal_Boolean_0;
		}

		// Token: 0x02000B0A RID: 2826
		[ObfuscatedName("ScheduleOne.Cutscenes.IntroManager+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E5AE RID: 58798 RVA: 0x00381AEC File Offset: 0x0037FCEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<IntroManager.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntroManager.__c__DisplayClass26_0>.NativeClassPtr);
				IntroManager.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
				IntroManager.__c__DisplayClass26_0.NativeFieldInfoPtr_clothes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.__c__DisplayClass26_0>.NativeClassPtr, "clothes");
				IntroManager.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass26_0>.NativeClassPtr, 100675507);
				IntroManager.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass26_0>.NativeClassPtr, 100675508);
			}

			// Token: 0x0600E5AF RID: 58799 RVA: 0x00381B68 File Offset: 0x0037FD68
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntroManager.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E5B0 RID: 58800 RVA: 0x00381BA4 File Offset: 0x0037FDA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199787, XrefRangeEnd = 199792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E5B1 RID: 58801 RVA: 0x0006C4DE File Offset: 0x0006A6DE
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045C3 RID: 17859
			// (get) Token: 0x0600E5B2 RID: 58802 RVA: 0x00381BE4 File Offset: 0x0037FDE4
			// (set) Token: 0x0600E5B3 RID: 58803 RVA: 0x0006C4E7 File Offset: 0x0006A6E7
			public unsafe IntroManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntroManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045C4 RID: 17860
			// (get) Token: 0x0600E5B4 RID: 58804 RVA: 0x00381C14 File Offset: 0x0037FE14
			// (set) Token: 0x0600E5B5 RID: 58805 RVA: 0x0006C506 File Offset: 0x0006A706
			public unsafe List<ClothingInstance> clothes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass26_0.NativeFieldInfoPtr_clothes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ClothingInstance>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass26_0.NativeFieldInfoPtr_clothes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BE0 RID: 39904
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009BE1 RID: 39905
			private static readonly IntPtr NativeFieldInfoPtr_clothes;

			// Token: 0x04009BE2 RID: 39906
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BE3 RID: 39907
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DD5 RID: 3541
			[ObfuscatedName("ScheduleOne.Cutscenes.IntroManager+<>c__DisplayClass26_0+<<CharacterCreationDone>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FF92 RID: 65426 RVA: 0x003CC39C File Offset: 0x003CA59C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntroManager.__c__DisplayClass26_0>.NativeClassPtr, "<<CharacterCreationDone>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675509);
					IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675510);
					IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675511);
					IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675512);
					IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675513);
					IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675514);
				}

				// Token: 0x0600FF93 RID: 65427 RVA: 0x003CC47C File Offset: 0x003CA67C
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FF94 RID: 65428 RVA: 0x003CC4C4 File Offset: 0x003CA6C4
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FF95 RID: 65429 RVA: 0x003CC4F8 File Offset: 0x003CA6F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199704, XrefRangeEnd = 199782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004DD1 RID: 19921
				// (get) Token: 0x0600FF96 RID: 65430 RVA: 0x003CC534 File Offset: 0x003CA734
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FF97 RID: 65431 RVA: 0x003CC574 File Offset: 0x003CA774
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199782, XrefRangeEnd = 199787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004DD2 RID: 19922
				// (get) Token: 0x0600FF98 RID: 65432 RVA: 0x003CC5A8 File Offset: 0x003CA7A8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FF99 RID: 65433 RVA: 0x00079199 File Offset: 0x00077399
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004DCE RID: 19918
				// (get) Token: 0x0600FF9A RID: 65434 RVA: 0x003CC5E8 File Offset: 0x003CA7E8
				// (set) Token: 0x0600FF9B RID: 65435 RVA: 0x000791A2 File Offset: 0x000773A2
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004DCF RID: 19919
				// (get) Token: 0x0600FF9C RID: 65436 RVA: 0x003CC610 File Offset: 0x003CA810
				// (set) Token: 0x0600FF9D RID: 65437 RVA: 0x000791BD File Offset: 0x000773BD
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DD0 RID: 19920
				// (get) Token: 0x0600FF9E RID: 65438 RVA: 0x003CC640 File Offset: 0x003CA840
				// (set) Token: 0x0600FF9F RID: 65439 RVA: 0x000791DC File Offset: 0x000773DC
				public unsafe IntroManager.__c__DisplayClass26_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntroManager.__c__DisplayClass26_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AC30 RID: 44080
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AC31 RID: 44081
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AC32 RID: 44082
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AC33 RID: 44083
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AC34 RID: 44084
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC35 RID: 44085
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AC36 RID: 44086
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AC37 RID: 44087
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC38 RID: 44088
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
