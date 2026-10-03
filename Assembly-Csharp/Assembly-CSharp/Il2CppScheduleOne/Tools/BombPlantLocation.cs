using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004D3 RID: 1235
	public class BombPlantLocation : MonoBehaviour
	{
		// Token: 0x0600710A RID: 28938 RVA: 0x001FF188 File Offset: 0x001FD388
		// Note: this type is marked as 'beforefieldinit'.
		static BombPlantLocation()
		{
			Il2CppClassPointerStore<BombPlantLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "BombPlantLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BombPlantLocation>.NativeClassPtr);
			BombPlantLocation.NativeFieldInfoPtr_COUNTDOWN_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombPlantLocation>.NativeClassPtr, "COUNTDOWN_TIME");
			BombPlantLocation.NativeFieldInfoPtr_BEEP_INTERVAL_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombPlantLocation>.NativeClassPtr, "BEEP_INTERVAL_MAX");
			BombPlantLocation.NativeFieldInfoPtr_BEEP_INTERVAL_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombPlantLocation>.NativeClassPtr, "BEEP_INTERVAL_MIN");
			BombPlantLocation.NativeFieldInfoPtr__BombPlanted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombPlantLocation>.NativeClassPtr, "<BombPlanted>k__BackingField");
			BombPlantLocation.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombPlantLocation>.NativeClassPtr, "IntObj");
			BombPlantLocation.NativeFieldInfoPtr_BombModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombPlantLocation>.NativeClassPtr, "BombModel");
			BombPlantLocation.NativeFieldInfoPtr_onPlantBomb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombPlantLocation>.NativeClassPtr, "onPlantBomb");
			BombPlantLocation.NativeFieldInfoPtr_onBeep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombPlantLocation>.NativeClassPtr, "onBeep");
			BombPlantLocation.NativeFieldInfoPtr_onDetonate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombPlantLocation>.NativeClassPtr, "onDetonate");
			BombPlantLocation.NativeMethodInfoPtr_get_BombPlanted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombPlantLocation>.NativeClassPtr, 100677901);
			BombPlantLocation.NativeMethodInfoPtr_set_BombPlanted_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombPlantLocation>.NativeClassPtr, 100677902);
			BombPlantLocation.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombPlantLocation>.NativeClassPtr, 100677903);
			BombPlantLocation.NativeMethodInfoPtr_Hovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombPlantLocation>.NativeClassPtr, 100677904);
			BombPlantLocation.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombPlantLocation>.NativeClassPtr, 100677905);
			BombPlantLocation.NativeMethodInfoPtr_PlantBomb_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombPlantLocation>.NativeClassPtr, 100677906);
			BombPlantLocation.NativeMethodInfoPtr_CanPlantBomb_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombPlantLocation>.NativeClassPtr, 100677907);
			BombPlantLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombPlantLocation>.NativeClassPtr, 100677908);
			BombPlantLocation.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombPlantLocation>.NativeClassPtr, 100677909);
		}

		// Token: 0x170022FA RID: 8954
		// (get) Token: 0x0600710B RID: 28939 RVA: 0x001FF320 File Offset: 0x001FD520
		// (set) Token: 0x0600710C RID: 28940 RVA: 0x001FF35C File Offset: 0x001FD55C
		public unsafe bool BombPlanted
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombPlantLocation.NativeMethodInfoPtr_get_BombPlanted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombPlantLocation.NativeMethodInfoPtr_set_BombPlanted_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600710D RID: 28941 RVA: 0x001FF39C File Offset: 0x001FD59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225116, XrefRangeEnd = 225132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombPlantLocation.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600710E RID: 28942 RVA: 0x001FF3D0 File Offset: 0x001FD5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225132, XrefRangeEnd = 225134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombPlantLocation.NativeMethodInfoPtr_Hovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600710F RID: 28943 RVA: 0x001FF404 File Offset: 0x001FD604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225134, XrefRangeEnd = 225136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombPlantLocation.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007110 RID: 28944 RVA: 0x001FF438 File Offset: 0x001FD638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225155, RefRangeEnd = 225156, XrefRangeStart = 225136, XrefRangeEnd = 225155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlantBomb()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombPlantLocation.NativeMethodInfoPtr_PlantBomb_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007111 RID: 28945 RVA: 0x001FF46C File Offset: 0x001FD66C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 225163, RefRangeEnd = 225165, XrefRangeStart = 225156, XrefRangeEnd = 225163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanPlantBomb()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombPlantLocation.NativeMethodInfoPtr_CanPlantBomb_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007112 RID: 28946 RVA: 0x001FF4A8 File Offset: 0x001FD6A8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BombPlantLocation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BombPlantLocation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombPlantLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007113 RID: 28947 RVA: 0x001FF4E4 File Offset: 0x001FD6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225165, XrefRangeEnd = 225170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombPlantLocation.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06007114 RID: 28948 RVA: 0x00035C74 File Offset: 0x00033E74
		public BombPlantLocation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022F1 RID: 8945
		// (get) Token: 0x06007115 RID: 28949 RVA: 0x001FF524 File Offset: 0x001FD724
		// (set) Token: 0x06007116 RID: 28950 RVA: 0x00035C7D File Offset: 0x00033E7D
		public unsafe static float COUNTDOWN_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BombPlantLocation.NativeFieldInfoPtr_COUNTDOWN_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BombPlantLocation.NativeFieldInfoPtr_COUNTDOWN_TIME, (void*)(&value));
			}
		}

		// Token: 0x170022F2 RID: 8946
		// (get) Token: 0x06007117 RID: 28951 RVA: 0x001FF540 File Offset: 0x001FD740
		// (set) Token: 0x06007118 RID: 28952 RVA: 0x00035C8B File Offset: 0x00033E8B
		public unsafe static float BEEP_INTERVAL_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BombPlantLocation.NativeFieldInfoPtr_BEEP_INTERVAL_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BombPlantLocation.NativeFieldInfoPtr_BEEP_INTERVAL_MAX, (void*)(&value));
			}
		}

		// Token: 0x170022F3 RID: 8947
		// (get) Token: 0x06007119 RID: 28953 RVA: 0x001FF55C File Offset: 0x001FD75C
		// (set) Token: 0x0600711A RID: 28954 RVA: 0x00035C99 File Offset: 0x00033E99
		public unsafe static float BEEP_INTERVAL_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BombPlantLocation.NativeFieldInfoPtr_BEEP_INTERVAL_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BombPlantLocation.NativeFieldInfoPtr_BEEP_INTERVAL_MIN, (void*)(&value));
			}
		}

		// Token: 0x170022F4 RID: 8948
		// (get) Token: 0x0600711B RID: 28955 RVA: 0x001FF578 File Offset: 0x001FD778
		// (set) Token: 0x0600711C RID: 28956 RVA: 0x00035CA7 File Offset: 0x00033EA7
		public unsafe bool _BombPlanted_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.NativeFieldInfoPtr__BombPlanted_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.NativeFieldInfoPtr__BombPlanted_k__BackingField)) = value;
			}
		}

		// Token: 0x170022F5 RID: 8949
		// (get) Token: 0x0600711D RID: 28957 RVA: 0x001FF5A0 File Offset: 0x001FD7A0
		// (set) Token: 0x0600711E RID: 28958 RVA: 0x00035CC2 File Offset: 0x00033EC2
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022F6 RID: 8950
		// (get) Token: 0x0600711F RID: 28959 RVA: 0x001FF5D0 File Offset: 0x001FD7D0
		// (set) Token: 0x06007120 RID: 28960 RVA: 0x00035CE1 File Offset: 0x00033EE1
		public unsafe GameObject BombModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.NativeFieldInfoPtr_BombModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.NativeFieldInfoPtr_BombModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022F7 RID: 8951
		// (get) Token: 0x06007121 RID: 28961 RVA: 0x001FF600 File Offset: 0x001FD800
		// (set) Token: 0x06007122 RID: 28962 RVA: 0x00035D00 File Offset: 0x00033F00
		public unsafe UnityEvent onPlantBomb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.NativeFieldInfoPtr_onPlantBomb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.NativeFieldInfoPtr_onPlantBomb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022F8 RID: 8952
		// (get) Token: 0x06007123 RID: 28963 RVA: 0x001FF630 File Offset: 0x001FD830
		// (set) Token: 0x06007124 RID: 28964 RVA: 0x00035D1F File Offset: 0x00033F1F
		public unsafe UnityEvent onBeep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.NativeFieldInfoPtr_onBeep);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.NativeFieldInfoPtr_onBeep), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022F9 RID: 8953
		// (get) Token: 0x06007125 RID: 28965 RVA: 0x001FF660 File Offset: 0x001FD860
		// (set) Token: 0x06007126 RID: 28966 RVA: 0x00035D3E File Offset: 0x00033F3E
		public unsafe UnityEvent onDetonate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.NativeFieldInfoPtr_onDetonate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.NativeFieldInfoPtr_onDetonate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D4E RID: 19790
		private static readonly IntPtr NativeFieldInfoPtr_COUNTDOWN_TIME;

		// Token: 0x04004D4F RID: 19791
		private static readonly IntPtr NativeFieldInfoPtr_BEEP_INTERVAL_MAX;

		// Token: 0x04004D50 RID: 19792
		private static readonly IntPtr NativeFieldInfoPtr_BEEP_INTERVAL_MIN;

		// Token: 0x04004D51 RID: 19793
		private static readonly IntPtr NativeFieldInfoPtr__BombPlanted_k__BackingField;

		// Token: 0x04004D52 RID: 19794
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04004D53 RID: 19795
		private static readonly IntPtr NativeFieldInfoPtr_BombModel;

		// Token: 0x04004D54 RID: 19796
		private static readonly IntPtr NativeFieldInfoPtr_onPlantBomb;

		// Token: 0x04004D55 RID: 19797
		private static readonly IntPtr NativeFieldInfoPtr_onBeep;

		// Token: 0x04004D56 RID: 19798
		private static readonly IntPtr NativeFieldInfoPtr_onDetonate;

		// Token: 0x04004D57 RID: 19799
		private static readonly IntPtr NativeMethodInfoPtr_get_BombPlanted_Public_get_Boolean_0;

		// Token: 0x04004D58 RID: 19800
		private static readonly IntPtr NativeMethodInfoPtr_set_BombPlanted_Private_set_Void_Boolean_0;

		// Token: 0x04004D59 RID: 19801
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004D5A RID: 19802
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Private_Void_0;

		// Token: 0x04004D5B RID: 19803
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x04004D5C RID: 19804
		private static readonly IntPtr NativeMethodInfoPtr_PlantBomb_Public_Void_0;

		// Token: 0x04004D5D RID: 19805
		private static readonly IntPtr NativeMethodInfoPtr_CanPlantBomb_Private_Boolean_0;

		// Token: 0x04004D5E RID: 19806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004D5F RID: 19807
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B89 RID: 2953
		[ObfuscatedName("ScheduleOne.Tools.BombPlantLocation+<<PlantBomb>g__Detonate|15_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600E968 RID: 59752 RVA: 0x0038C3F0 File Offset: 0x0038A5F0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique()
			{
				Il2CppClassPointerStore<BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BombPlantLocation>.NativeClassPtr, "<<PlantBomb>g__Detonate|15_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique>.NativeClassPtr);
				BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique>.NativeClassPtr, "<>1__state");
				BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique>.NativeClassPtr, "<>2__current");
				BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique>.NativeClassPtr, "<>4__this");
				BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeFieldInfoPtr__t_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique>.NativeClassPtr, "<t>5__2");
				BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeFieldInfoPtr__timeSinceLastBeep_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique>.NativeClassPtr, "<timeSinceLastBeep>5__3");
				BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeFieldInfoPtr__beepTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique>.NativeClassPtr, "<beepTime>5__4");
				BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique>.NativeClassPtr, 100677910);
				BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique>.NativeClassPtr, 100677911);
				BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique>.NativeClassPtr, 100677912);
				BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique>.NativeClassPtr, 100677913);
				BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique>.NativeClassPtr, 100677914);
				BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique>.NativeClassPtr, 100677915);
			}

			// Token: 0x0600E969 RID: 59753 RVA: 0x0038C50C File Offset: 0x0038A70C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E96A RID: 59754 RVA: 0x0038C554 File Offset: 0x0038A754
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E96B RID: 59755 RVA: 0x0038C588 File Offset: 0x0038A788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225101, XrefRangeEnd = 225111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170046D5 RID: 18133
			// (get) Token: 0x0600E96C RID: 59756 RVA: 0x0038C5C4 File Offset: 0x0038A7C4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E96D RID: 59757 RVA: 0x0038C604 File Offset: 0x0038A804
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225111, XrefRangeEnd = 225116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170046D6 RID: 18134
			// (get) Token: 0x0600E96E RID: 59758 RVA: 0x0038C638 File Offset: 0x0038A838
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E96F RID: 59759 RVA: 0x0006E20A File Offset: 0x0006C40A
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046CF RID: 18127
			// (get) Token: 0x0600E970 RID: 59760 RVA: 0x0038C678 File Offset: 0x0038A878
			// (set) Token: 0x0600E971 RID: 59761 RVA: 0x0006E213 File Offset: 0x0006C413
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170046D0 RID: 18128
			// (get) Token: 0x0600E972 RID: 59762 RVA: 0x0038C6A0 File Offset: 0x0038A8A0
			// (set) Token: 0x0600E973 RID: 59763 RVA: 0x0006E22E File Offset: 0x0006C42E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046D1 RID: 18129
			// (get) Token: 0x0600E974 RID: 59764 RVA: 0x0038C6D0 File Offset: 0x0038A8D0
			// (set) Token: 0x0600E975 RID: 59765 RVA: 0x0006E24D File Offset: 0x0006C44D
			public unsafe BombPlantLocation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BombPlantLocation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046D2 RID: 18130
			// (get) Token: 0x0600E976 RID: 59766 RVA: 0x0038C700 File Offset: 0x0038A900
			// (set) Token: 0x0600E977 RID: 59767 RVA: 0x0006E26C File Offset: 0x0006C46C
			public unsafe float _t_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeFieldInfoPtr__t_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeFieldInfoPtr__t_5__2)) = value;
				}
			}

			// Token: 0x170046D3 RID: 18131
			// (get) Token: 0x0600E978 RID: 59768 RVA: 0x0038C728 File Offset: 0x0038A928
			// (set) Token: 0x0600E979 RID: 59769 RVA: 0x0006E287 File Offset: 0x0006C487
			public unsafe float _timeSinceLastBeep_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeFieldInfoPtr__timeSinceLastBeep_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeFieldInfoPtr__timeSinceLastBeep_5__3)) = value;
				}
			}

			// Token: 0x170046D4 RID: 18132
			// (get) Token: 0x0600E97A RID: 59770 RVA: 0x0038C750 File Offset: 0x0038A950
			// (set) Token: 0x0600E97B RID: 59771 RVA: 0x0006E2A2 File Offset: 0x0006C4A2
			public unsafe float _beepTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeFieldInfoPtr__beepTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BombPlantLocation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoSiSiObSiObUnique.NativeFieldInfoPtr__beepTime_5__4)) = value;
				}
			}

			// Token: 0x04009E4D RID: 40525
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009E4E RID: 40526
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009E4F RID: 40527
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009E50 RID: 40528
			private static readonly IntPtr NativeFieldInfoPtr__t_5__2;

			// Token: 0x04009E51 RID: 40529
			private static readonly IntPtr NativeFieldInfoPtr__timeSinceLastBeep_5__3;

			// Token: 0x04009E52 RID: 40530
			private static readonly IntPtr NativeFieldInfoPtr__beepTime_5__4;

			// Token: 0x04009E53 RID: 40531
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009E54 RID: 40532
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009E55 RID: 40533
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009E56 RID: 40534
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009E57 RID: 40535
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009E58 RID: 40536
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
