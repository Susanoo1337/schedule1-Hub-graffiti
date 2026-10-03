using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003DF RID: 991
	public class ReflectionProbeUpdater : MonoBehaviour
	{
		// Token: 0x060058AD RID: 22701 RVA: 0x001ADEB8 File Offset: 0x001AC0B8
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionProbeUpdater()
		{
			Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "ReflectionProbeUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr);
			ReflectionProbeUpdater.NativeFieldInfoPtr_Probe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, "Probe");
			ReflectionProbeUpdater.NativeFieldInfoPtr_renderQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, "renderQueue");
			ReflectionProbeUpdater.NativeFieldInfoPtr_RenderRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, "RenderRoutine");
			ReflectionProbeUpdater.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, 100674930);
			ReflectionProbeUpdater.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, 100674931);
			ReflectionProbeUpdater.NativeMethodInfoPtr_UpdateProbe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, 100674932);
			ReflectionProbeUpdater.NativeMethodInfoPtr_ProcessQueue_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, 100674933);
			ReflectionProbeUpdater.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, 100674934);
		}

		// Token: 0x060058AE RID: 22702 RVA: 0x001ADF88 File Offset: 0x001AC188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193310, XrefRangeEnd = 193318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058AF RID: 22703 RVA: 0x001ADFBC File Offset: 0x001AC1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193318, XrefRangeEnd = 193362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058B0 RID: 22704 RVA: 0x001ADFF0 File Offset: 0x001AC1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193362, XrefRangeEnd = 193375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateProbe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater.NativeMethodInfoPtr_UpdateProbe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058B1 RID: 22705 RVA: 0x001AE024 File Offset: 0x001AC224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193375, XrefRangeEnd = 193379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ProcessQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater.NativeMethodInfoPtr_ProcessQueue_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060058B2 RID: 22706 RVA: 0x001AE064 File Offset: 0x001AC264
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionProbeUpdater() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058B3 RID: 22707 RVA: 0x00029F6B File Offset: 0x0002816B
		public ReflectionProbeUpdater(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x060058B4 RID: 22708 RVA: 0x001AE0A0 File Offset: 0x001AC2A0
		// (set) Token: 0x060058B5 RID: 22709 RVA: 0x00029F74 File Offset: 0x00028174
		public unsafe ReflectionProbe Probe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater.NativeFieldInfoPtr_Probe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionProbe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater.NativeFieldInfoPtr_Probe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x060058B6 RID: 22710 RVA: 0x001AE0D0 File Offset: 0x001AC2D0
		// (set) Token: 0x060058B7 RID: 22711 RVA: 0x00029F93 File Offset: 0x00028193
		public unsafe static List<ReflectionProbe> renderQueue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionProbeUpdater.NativeFieldInfoPtr_renderQueue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ReflectionProbe>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionProbeUpdater.NativeFieldInfoPtr_renderQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B59 RID: 7001
		// (get) Token: 0x060058B8 RID: 22712 RVA: 0x001AE0F8 File Offset: 0x001AC2F8
		// (set) Token: 0x060058B9 RID: 22713 RVA: 0x00029FA5 File Offset: 0x000281A5
		public unsafe static Coroutine RenderRoutine
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionProbeUpdater.NativeFieldInfoPtr_RenderRoutine, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionProbeUpdater.NativeFieldInfoPtr_RenderRoutine, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003CF6 RID: 15606
		private static readonly IntPtr NativeFieldInfoPtr_Probe;

		// Token: 0x04003CF7 RID: 15607
		private static readonly IntPtr NativeFieldInfoPtr_renderQueue;

		// Token: 0x04003CF8 RID: 15608
		private static readonly IntPtr NativeFieldInfoPtr_RenderRoutine;

		// Token: 0x04003CF9 RID: 15609
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04003CFA RID: 15610
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003CFB RID: 15611
		private static readonly IntPtr NativeMethodInfoPtr_UpdateProbe_Private_Void_0;

		// Token: 0x04003CFC RID: 15612
		private static readonly IntPtr NativeMethodInfoPtr_ProcessQueue_Private_IEnumerator_0;

		// Token: 0x04003CFD RID: 15613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000ADB RID: 2779
		[ObfuscatedName("ScheduleOne.Lighting.ReflectionProbeUpdater+<ProcessQueue>d__6")]
		public sealed class _ProcessQueue_d__6 : Il2CppSystem.Object
		{
			// Token: 0x0600E4A2 RID: 58530 RVA: 0x0037EC4C File Offset: 0x0037CE4C
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessQueue_d__6()
			{
				Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionProbeUpdater>.NativeClassPtr, "<ProcessQueue>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, "<>1__state");
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, "<>2__current");
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__renderDuration_Frames_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, "<renderDuration_Frames>5__2");
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, "<i>5__3");
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100674936);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100674937);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100674938);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100674939);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100674940);
				ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr, 100674941);
			}

			// Token: 0x0600E4A3 RID: 58531 RVA: 0x0037ED40 File Offset: 0x0037CF40
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ProcessQueue_d__6(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionProbeUpdater._ProcessQueue_d__6>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4A4 RID: 58532 RVA: 0x0037ED88 File Offset: 0x0037CF88
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4A5 RID: 58533 RVA: 0x0037EDBC File Offset: 0x0037CFBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193283, XrefRangeEnd = 193305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004586 RID: 17798
			// (get) Token: 0x0600E4A6 RID: 58534 RVA: 0x0037EDF8 File Offset: 0x0037CFF8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E4A7 RID: 58535 RVA: 0x0037EE38 File Offset: 0x0037D038
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193305, XrefRangeEnd = 193310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004587 RID: 17799
			// (get) Token: 0x0600E4A8 RID: 58536 RVA: 0x0037EE6C File Offset: 0x0037D06C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbeUpdater._ProcessQueue_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E4A9 RID: 58537 RVA: 0x0006BCB8 File Offset: 0x00069EB8
			public _ProcessQueue_d__6(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004582 RID: 17794
			// (get) Token: 0x0600E4AA RID: 58538 RVA: 0x0037EEAC File Offset: 0x0037D0AC
			// (set) Token: 0x0600E4AB RID: 58539 RVA: 0x0006BCC1 File Offset: 0x00069EC1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004583 RID: 17795
			// (get) Token: 0x0600E4AC RID: 58540 RVA: 0x0037EED4 File Offset: 0x0037D0D4
			// (set) Token: 0x0600E4AD RID: 58541 RVA: 0x0006BCDC File Offset: 0x00069EDC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004584 RID: 17796
			// (get) Token: 0x0600E4AE RID: 58542 RVA: 0x0037EF04 File Offset: 0x0037D104
			// (set) Token: 0x0600E4AF RID: 58543 RVA: 0x0006BCFB File Offset: 0x00069EFB
			public unsafe int _renderDuration_Frames_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__renderDuration_Frames_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__renderDuration_Frames_5__2)) = value;
				}
			}

			// Token: 0x17004585 RID: 17797
			// (get) Token: 0x0600E4B0 RID: 58544 RVA: 0x0037EF2C File Offset: 0x0037D12C
			// (set) Token: 0x0600E4B1 RID: 58545 RVA: 0x0006BD16 File Offset: 0x00069F16
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionProbeUpdater._ProcessQueue_d__6.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04009B42 RID: 39746
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009B43 RID: 39747
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009B44 RID: 39748
			private static readonly IntPtr NativeFieldInfoPtr__renderDuration_Frames_5__2;

			// Token: 0x04009B45 RID: 39749
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04009B46 RID: 39750
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009B47 RID: 39751
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009B48 RID: 39752
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009B49 RID: 39753
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009B4A RID: 39754
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009B4B RID: 39755
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
