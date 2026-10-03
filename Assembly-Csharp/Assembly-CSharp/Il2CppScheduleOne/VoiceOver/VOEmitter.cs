using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.NPCs.Framework;
using UnityEngine;

namespace Il2CppScheduleOne.VoiceOver
{
	// Token: 0x020000CB RID: 203
	public class VOEmitter : MonoBehaviour
	{
		// Token: 0x06001247 RID: 4679 RVA: 0x000B846C File Offset: 0x000B666C
		// Note: this type is marked as 'beforefieldinit'.
		static VOEmitter()
		{
			Il2CppClassPointerStore<VOEmitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.VoiceOver", "VOEmitter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr);
			VOEmitter.NativeFieldInfoPtr_PitchVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, "PitchVariation");
			VOEmitter.NativeFieldInfoPtr__runtimePitchMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, "_runtimePitchMultiplier");
			VOEmitter.NativeFieldInfoPtr__audioSourceController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, "_audioSourceController");
			VOEmitter.NativeFieldInfoPtr__defaultVODatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, "_defaultVODatabase");
			VOEmitter.NativeFieldInfoPtr__currentDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, "_currentDatabase");
			VOEmitter.NativeFieldInfoPtr__defaultDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, "_defaultDatabase");
			VOEmitter.NativeFieldInfoPtr__defaultPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, "_defaultPitch");
			VOEmitter.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, 100665966);
			VOEmitter.NativeMethodInfoPtr_Initialize_Public_Void_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, 100665967);
			VOEmitter.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, 100665968);
			VOEmitter.NativeMethodInfoPtr_SetRuntimePitchMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, 100665969);
			VOEmitter.NativeMethodInfoPtr_SetDatabase_Public_Void_VODatabase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, 100665970);
			VOEmitter.NativeMethodInfoPtr_SetDefaultPitch_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, 100665971);
			VOEmitter.NativeMethodInfoPtr_ResetDatabase_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, 100665972);
			VOEmitter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr, 100665973);
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x000B85C8 File Offset: 0x000B67C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91030, XrefRangeEnd = 91034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VOEmitter.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x000B8604 File Offset: 0x000B6804
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91038, RefRangeEnd = 91040, XrefRangeStart = 91034, XrefRangeEnd = 91038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(NPCData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VOEmitter.NativeMethodInfoPtr_Initialize_Public_Void_NPCData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x000B8648 File Offset: 0x000B6848
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91080, RefRangeEnd = 91082, XrefRangeStart = 91040, XrefRangeEnd = 91080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Play(EVOLineType lineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lineType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VOEmitter.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_EVOLineType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x000B8694 File Offset: 0x000B6894
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29040, RefRangeEnd = 29041, XrefRangeStart = 29040, XrefRangeEnd = 29041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRuntimePitchMultiplier(float pitchMultiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pitchMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VOEmitter.NativeMethodInfoPtr_SetRuntimePitchMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x000B86D4 File Offset: 0x000B68D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 91084, RefRangeEnd = 91088, XrefRangeStart = 91082, XrefRangeEnd = 91084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDatabase(VODatabase database, bool writeDefault = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(database);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeDefault;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VOEmitter.NativeMethodInfoPtr_SetDatabase_Public_Void_VODatabase_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x000B8724 File Offset: 0x000B6924
		[CallerCount(0)]
		public unsafe void SetDefaultPitch(float pitch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pitch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VOEmitter.NativeMethodInfoPtr_SetDefaultPitch_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x000B8764 File Offset: 0x000B6964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91089, RefRangeEnd = 91090, XrefRangeStart = 91088, XrefRangeEnd = 91089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetDatabase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VOEmitter.NativeMethodInfoPtr_ResetDatabase_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x000B8798 File Offset: 0x000B6998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VOEmitter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VOEmitter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VOEmitter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x0000A435 File Offset: 0x00008635
		public VOEmitter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x000B87D4 File Offset: 0x000B69D4
		// (set) Token: 0x06001252 RID: 4690 RVA: 0x0000A43E File Offset: 0x0000863E
		public unsafe static float PitchVariation
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VOEmitter.NativeFieldInfoPtr_PitchVariation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VOEmitter.NativeFieldInfoPtr_PitchVariation, (void*)(&value));
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x000B87F0 File Offset: 0x000B69F0
		// (set) Token: 0x06001254 RID: 4692 RVA: 0x0000A44C File Offset: 0x0000864C
		public unsafe float _runtimePitchMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr__runtimePitchMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr__runtimePitchMultiplier)) = value;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x000B8818 File Offset: 0x000B6A18
		// (set) Token: 0x06001256 RID: 4694 RVA: 0x0000A467 File Offset: 0x00008667
		public unsafe AudioSourceController _audioSourceController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr__audioSourceController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr__audioSourceController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x000B8848 File Offset: 0x000B6A48
		// (set) Token: 0x06001258 RID: 4696 RVA: 0x0000A486 File Offset: 0x00008686
		public unsafe VODatabase _defaultVODatabase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr__defaultVODatabase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VODatabase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr__defaultVODatabase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x000B8878 File Offset: 0x000B6A78
		// (set) Token: 0x0600125A RID: 4698 RVA: 0x0000A4A5 File Offset: 0x000086A5
		public unsafe VODatabase _currentDatabase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr__currentDatabase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VODatabase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr__currentDatabase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x000B88A8 File Offset: 0x000B6AA8
		// (set) Token: 0x0600125C RID: 4700 RVA: 0x0000A4C4 File Offset: 0x000086C4
		public unsafe VODatabase _defaultDatabase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr__defaultDatabase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VODatabase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr__defaultDatabase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x000B88D8 File Offset: 0x000B6AD8
		// (set) Token: 0x0600125E RID: 4702 RVA: 0x0000A4E3 File Offset: 0x000086E3
		public unsafe float _defaultPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr__defaultPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VOEmitter.NativeFieldInfoPtr__defaultPitch)) = value;
			}
		}

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeFieldInfoPtr_PitchVariation;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeFieldInfoPtr__runtimePitchMultiplier;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeFieldInfoPtr__audioSourceController;

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeFieldInfoPtr__defaultVODatabase;

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeFieldInfoPtr__currentDatabase;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeFieldInfoPtr__defaultDatabase;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeFieldInfoPtr__defaultPitch;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_NPCData_0;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_New_Void_EVOLineType_0;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeMethodInfoPtr_SetRuntimePitchMultiplier_Public_Void_Single_0;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeMethodInfoPtr_SetDatabase_Public_Void_VODatabase_Boolean_0;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultPitch_Public_Void_Single_0;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeMethodInfoPtr_ResetDatabase_Public_Void_0;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
