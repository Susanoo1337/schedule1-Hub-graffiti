using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004D8 RID: 1240
	public class CombatNPCDetector : MonoBehaviour
	{
		// Token: 0x06007156 RID: 29014 RVA: 0x001FFFC4 File Offset: 0x001FE1C4
		// Note: this type is marked as 'beforefieldinit'.
		static CombatNPCDetector()
		{
			Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "CombatNPCDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr);
			CombatNPCDetector.NativeFieldInfoPtr_DetectOnlyInCombat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, "DetectOnlyInCombat");
			CombatNPCDetector.NativeFieldInfoPtr_onDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, "onDetected");
			CombatNPCDetector.NativeFieldInfoPtr_ContactTimeForDetection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, "ContactTimeForDetection");
			CombatNPCDetector.NativeFieldInfoPtr_npcInContact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, "npcInContact");
			CombatNPCDetector.NativeFieldInfoPtr_contactTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, "contactTime");
			CombatNPCDetector.NativeFieldInfoPtr_detectionRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, "detectionRoutine");
			CombatNPCDetector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, 100677944);
			CombatNPCDetector.NativeMethodInfoPtr_UpdateWhileDetected_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, 100677945);
			CombatNPCDetector.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, 100677946);
			CombatNPCDetector.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, 100677947);
			CombatNPCDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, 100677948);
		}

		// Token: 0x06007157 RID: 29015 RVA: 0x002000D0 File Offset: 0x001FE2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225385, XrefRangeEnd = 225398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007158 RID: 29016 RVA: 0x00200104 File Offset: 0x001FE304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225403, RefRangeEnd = 225404, XrefRangeStart = 225398, XrefRangeEnd = 225403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator UpdateWhileDetected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector.NativeMethodInfoPtr_UpdateWhileDetected_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06007159 RID: 29017 RVA: 0x00200144 File Offset: 0x001FE344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225404, XrefRangeEnd = 225422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600715A RID: 29018 RVA: 0x00200188 File Offset: 0x001FE388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225422, XrefRangeEnd = 225435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerExit(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600715B RID: 29019 RVA: 0x002001CC File Offset: 0x001FE3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225435, XrefRangeEnd = 225436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CombatNPCDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600715C RID: 29020 RVA: 0x00035E92 File Offset: 0x00034092
		public CombatNPCDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002308 RID: 8968
		// (get) Token: 0x0600715D RID: 29021 RVA: 0x00200208 File Offset: 0x001FE408
		// (set) Token: 0x0600715E RID: 29022 RVA: 0x00035E9B File Offset: 0x0003409B
		public unsafe bool DetectOnlyInCombat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_DetectOnlyInCombat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_DetectOnlyInCombat)) = value;
			}
		}

		// Token: 0x17002309 RID: 8969
		// (get) Token: 0x0600715F RID: 29023 RVA: 0x00200230 File Offset: 0x001FE430
		// (set) Token: 0x06007160 RID: 29024 RVA: 0x00035EB6 File Offset: 0x000340B6
		public unsafe UnityEvent onDetected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_onDetected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_onDetected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700230A RID: 8970
		// (get) Token: 0x06007161 RID: 29025 RVA: 0x00200260 File Offset: 0x001FE460
		// (set) Token: 0x06007162 RID: 29026 RVA: 0x00035ED5 File Offset: 0x000340D5
		public unsafe float ContactTimeForDetection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_ContactTimeForDetection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_ContactTimeForDetection)) = value;
			}
		}

		// Token: 0x1700230B RID: 8971
		// (get) Token: 0x06007163 RID: 29027 RVA: 0x00200288 File Offset: 0x001FE488
		// (set) Token: 0x06007164 RID: 29028 RVA: 0x00035EF0 File Offset: 0x000340F0
		public unsafe NPC npcInContact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_npcInContact);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_npcInContact), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700230C RID: 8972
		// (get) Token: 0x06007165 RID: 29029 RVA: 0x002002B8 File Offset: 0x001FE4B8
		// (set) Token: 0x06007166 RID: 29030 RVA: 0x00035F0F File Offset: 0x0003410F
		public unsafe float contactTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_contactTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_contactTime)) = value;
			}
		}

		// Token: 0x1700230D RID: 8973
		// (get) Token: 0x06007167 RID: 29031 RVA: 0x002002E0 File Offset: 0x001FE4E0
		// (set) Token: 0x06007168 RID: 29032 RVA: 0x00035F2A File Offset: 0x0003412A
		public unsafe Coroutine detectionRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_detectionRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector.NativeFieldInfoPtr_detectionRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D7D RID: 19837
		private static readonly IntPtr NativeFieldInfoPtr_DetectOnlyInCombat;

		// Token: 0x04004D7E RID: 19838
		private static readonly IntPtr NativeFieldInfoPtr_onDetected;

		// Token: 0x04004D7F RID: 19839
		private static readonly IntPtr NativeFieldInfoPtr_ContactTimeForDetection;

		// Token: 0x04004D80 RID: 19840
		private static readonly IntPtr NativeFieldInfoPtr_npcInContact;

		// Token: 0x04004D81 RID: 19841
		private static readonly IntPtr NativeFieldInfoPtr_contactTime;

		// Token: 0x04004D82 RID: 19842
		private static readonly IntPtr NativeFieldInfoPtr_detectionRoutine;

		// Token: 0x04004D83 RID: 19843
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004D84 RID: 19844
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWhileDetected_Private_IEnumerator_0;

		// Token: 0x04004D85 RID: 19845
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

		// Token: 0x04004D86 RID: 19846
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0;

		// Token: 0x04004D87 RID: 19847
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B8E RID: 2958
		[ObfuscatedName("ScheduleOne.Tools.CombatNPCDetector+<UpdateWhileDetected>d__7")]
		public sealed class _UpdateWhileDetected_d__7 : Il2CppSystem.Object
		{
			// Token: 0x0600E99C RID: 59804 RVA: 0x0038CCF8 File Offset: 0x0038AEF8
			// Note: this type is marked as 'beforefieldinit'.
			static _UpdateWhileDetected_d__7()
			{
				Il2CppClassPointerStore<CombatNPCDetector._UpdateWhileDetected_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatNPCDetector>.NativeClassPtr, "<UpdateWhileDetected>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatNPCDetector._UpdateWhileDetected_d__7>.NativeClassPtr);
				CombatNPCDetector._UpdateWhileDetected_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector._UpdateWhileDetected_d__7>.NativeClassPtr, "<>1__state");
				CombatNPCDetector._UpdateWhileDetected_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector._UpdateWhileDetected_d__7>.NativeClassPtr, "<>2__current");
				CombatNPCDetector._UpdateWhileDetected_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatNPCDetector._UpdateWhileDetected_d__7>.NativeClassPtr, "<>4__this");
				CombatNPCDetector._UpdateWhileDetected_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector._UpdateWhileDetected_d__7>.NativeClassPtr, 100677949);
				CombatNPCDetector._UpdateWhileDetected_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector._UpdateWhileDetected_d__7>.NativeClassPtr, 100677950);
				CombatNPCDetector._UpdateWhileDetected_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector._UpdateWhileDetected_d__7>.NativeClassPtr, 100677951);
				CombatNPCDetector._UpdateWhileDetected_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector._UpdateWhileDetected_d__7>.NativeClassPtr, 100677952);
				CombatNPCDetector._UpdateWhileDetected_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector._UpdateWhileDetected_d__7>.NativeClassPtr, 100677953);
				CombatNPCDetector._UpdateWhileDetected_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatNPCDetector._UpdateWhileDetected_d__7>.NativeClassPtr, 100677954);
			}

			// Token: 0x0600E99D RID: 59805 RVA: 0x0038CDD8 File Offset: 0x0038AFD8
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UpdateWhileDetected_d__7(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatNPCDetector._UpdateWhileDetected_d__7>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector._UpdateWhileDetected_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E99E RID: 59806 RVA: 0x0038CE20 File Offset: 0x0038B020
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector._UpdateWhileDetected_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E99F RID: 59807 RVA: 0x0038CE54 File Offset: 0x0038B054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225373, XrefRangeEnd = 225380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector._UpdateWhileDetected_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170046E2 RID: 18146
			// (get) Token: 0x0600E9A0 RID: 59808 RVA: 0x0038CE90 File Offset: 0x0038B090
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector._UpdateWhileDetected_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E9A1 RID: 59809 RVA: 0x0038CED0 File Offset: 0x0038B0D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225380, XrefRangeEnd = 225385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector._UpdateWhileDetected_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170046E3 RID: 18147
			// (get) Token: 0x0600E9A2 RID: 59810 RVA: 0x0038CF04 File Offset: 0x0038B104
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatNPCDetector._UpdateWhileDetected_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E9A3 RID: 59811 RVA: 0x0006E3AA File Offset: 0x0006C5AA
			public _UpdateWhileDetected_d__7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046DF RID: 18143
			// (get) Token: 0x0600E9A4 RID: 59812 RVA: 0x0038CF44 File Offset: 0x0038B144
			// (set) Token: 0x0600E9A5 RID: 59813 RVA: 0x0006E3B3 File Offset: 0x0006C5B3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector._UpdateWhileDetected_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector._UpdateWhileDetected_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170046E0 RID: 18144
			// (get) Token: 0x0600E9A6 RID: 59814 RVA: 0x0038CF6C File Offset: 0x0038B16C
			// (set) Token: 0x0600E9A7 RID: 59815 RVA: 0x0006E3CE File Offset: 0x0006C5CE
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector._UpdateWhileDetected_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector._UpdateWhileDetected_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046E1 RID: 18145
			// (get) Token: 0x0600E9A8 RID: 59816 RVA: 0x0038CF9C File Offset: 0x0038B19C
			// (set) Token: 0x0600E9A9 RID: 59817 RVA: 0x0006E3ED File Offset: 0x0006C5ED
			public unsafe CombatNPCDetector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector._UpdateWhileDetected_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatNPCDetector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatNPCDetector._UpdateWhileDetected_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009E69 RID: 40553
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009E6A RID: 40554
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009E6B RID: 40555
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009E6C RID: 40556
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009E6D RID: 40557
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009E6E RID: 40558
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009E6F RID: 40559
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009E70 RID: 40560
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009E71 RID: 40561
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
