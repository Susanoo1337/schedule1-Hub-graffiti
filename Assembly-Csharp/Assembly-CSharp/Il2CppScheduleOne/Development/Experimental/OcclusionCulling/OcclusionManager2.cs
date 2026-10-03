using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Diagnostics;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Il2CppScheduleOne.Development.Experimental.OcclusionCulling
{
	// Token: 0x02000708 RID: 1800
	public class OcclusionManager2 : MonoBehaviour
	{
		// Token: 0x0600ADA6 RID: 44454 RVA: 0x002D9E98 File Offset: 0x002D8098
		// Note: this type is marked as 'beforefieldinit'.
		static OcclusionManager2()
		{
			Il2CppClassPointerStore<OcclusionManager2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Development.Experimental.OcclusionCulling", "OcclusionManager2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OcclusionManager2>.NativeClassPtr);
			OcclusionManager2.NativeFieldInfoPtr__bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager2>.NativeClassPtr, "_bounds");
			OcclusionManager2.NativeFieldInfoPtr__cellSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager2>.NativeClassPtr, "_cellSize");
			OcclusionManager2.NativeFieldInfoPtr__maxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager2>.NativeClassPtr, "_maxDistance");
			OcclusionManager2.NativeFieldInfoPtr__inclusionZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager2>.NativeClassPtr, "_inclusionZones");
			OcclusionManager2.NativeFieldInfoPtr__occlusionObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager2>.NativeClassPtr, "_occlusionObjects");
			OcclusionManager2.NativeFieldInfoPtr__occlusionLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager2>.NativeClassPtr, "_occlusionLayerMask");
			OcclusionManager2.NativeFieldInfoPtr__visibilityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager2>.NativeClassPtr, "_visibilityData");
			OcclusionManager2.NativeFieldInfoPtr__cellsX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager2>.NativeClassPtr, "_cellsX");
			OcclusionManager2.NativeFieldInfoPtr__cellsY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager2>.NativeClassPtr, "_cellsY");
			OcclusionManager2.NativeFieldInfoPtr__cellsZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager2>.NativeClassPtr, "_cellsZ");
			OcclusionManager2.NativeFieldInfoPtr__totalCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager2>.NativeClassPtr, "_totalCells");
			OcclusionManager2.NativeFieldInfoPtr__bakeRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager2>.NativeClassPtr, "_bakeRoutine");
			OcclusionManager2.NativeMethodInfoPtr_RunOcclusionBake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager2>.NativeClassPtr, 100686204);
			OcclusionManager2.NativeMethodInfoPtr_DoOcclusionBakeRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager2>.NativeClassPtr, 100686205);
			OcclusionManager2.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager2>.NativeClassPtr, 100686206);
			OcclusionManager2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager2>.NativeClassPtr, 100686207);
		}

		// Token: 0x0600ADA7 RID: 44455 RVA: 0x002DA008 File Offset: 0x002D8208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297582, XrefRangeEnd = 297590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunOcclusionBake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager2.NativeMethodInfoPtr_RunOcclusionBake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADA8 RID: 44456 RVA: 0x002DA03C File Offset: 0x002D823C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297590, XrefRangeEnd = 297595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoOcclusionBakeRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager2.NativeMethodInfoPtr_DoOcclusionBakeRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600ADA9 RID: 44457 RVA: 0x002DA07C File Offset: 0x002D827C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297595, XrefRangeEnd = 297599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager2.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADAA RID: 44458 RVA: 0x002DA0B0 File Offset: 0x002D82B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297599, XrefRangeEnd = 297600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OcclusionManager2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OcclusionManager2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ADAB RID: 44459 RVA: 0x0004F681 File Offset: 0x0004D881
		public OcclusionManager2(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003410 RID: 13328
		// (get) Token: 0x0600ADAC RID: 44460 RVA: 0x002DA0EC File Offset: 0x002D82EC
		// (set) Token: 0x0600ADAD RID: 44461 RVA: 0x0004F68A File Offset: 0x0004D88A
		public unsafe Vector3 _bounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__bounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__bounds)) = value;
			}
		}

		// Token: 0x17003411 RID: 13329
		// (get) Token: 0x0600ADAE RID: 44462 RVA: 0x002DA114 File Offset: 0x002D8314
		// (set) Token: 0x0600ADAF RID: 44463 RVA: 0x0004F6A5 File Offset: 0x0004D8A5
		public unsafe float _cellSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__cellSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__cellSize)) = value;
			}
		}

		// Token: 0x17003412 RID: 13330
		// (get) Token: 0x0600ADB0 RID: 44464 RVA: 0x002DA13C File Offset: 0x002D833C
		// (set) Token: 0x0600ADB1 RID: 44465 RVA: 0x0004F6C0 File Offset: 0x0004D8C0
		public unsafe float _maxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__maxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__maxDistance)) = value;
			}
		}

		// Token: 0x17003413 RID: 13331
		// (get) Token: 0x0600ADB2 RID: 44466 RVA: 0x002DA164 File Offset: 0x002D8364
		// (set) Token: 0x0600ADB3 RID: 44467 RVA: 0x0004F6DB File Offset: 0x0004D8DB
		public unsafe List<Collider> _inclusionZones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__inclusionZones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__inclusionZones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003414 RID: 13332
		// (get) Token: 0x0600ADB4 RID: 44468 RVA: 0x002DA194 File Offset: 0x002D8394
		// (set) Token: 0x0600ADB5 RID: 44469 RVA: 0x0004F6FA File Offset: 0x0004D8FA
		public unsafe List<OcclusionObject> _occlusionObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__occlusionObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<OcclusionObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__occlusionObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003415 RID: 13333
		// (get) Token: 0x0600ADB6 RID: 44470 RVA: 0x002DA1C4 File Offset: 0x002D83C4
		// (set) Token: 0x0600ADB7 RID: 44471 RVA: 0x0004F719 File Offset: 0x0004D919
		public unsafe LayerMask _occlusionLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__occlusionLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__occlusionLayerMask)) = value;
			}
		}

		// Token: 0x17003416 RID: 13334
		// (get) Token: 0x0600ADB8 RID: 44472 RVA: 0x002DA1EC File Offset: 0x002D83EC
		// (set) Token: 0x0600ADB9 RID: 44473 RVA: 0x0004F734 File Offset: 0x0004D934
		public NativeArray<byte> _visibilityData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__visibilityData);
				return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__visibilityData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17003417 RID: 13335
		// (get) Token: 0x0600ADBA RID: 44474 RVA: 0x002DA21C File Offset: 0x002D841C
		// (set) Token: 0x0600ADBB RID: 44475 RVA: 0x0004F762 File Offset: 0x0004D962
		public unsafe int _cellsX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__cellsX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__cellsX)) = value;
			}
		}

		// Token: 0x17003418 RID: 13336
		// (get) Token: 0x0600ADBC RID: 44476 RVA: 0x002DA244 File Offset: 0x002D8444
		// (set) Token: 0x0600ADBD RID: 44477 RVA: 0x0004F77D File Offset: 0x0004D97D
		public unsafe int _cellsY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__cellsY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__cellsY)) = value;
			}
		}

		// Token: 0x17003419 RID: 13337
		// (get) Token: 0x0600ADBE RID: 44478 RVA: 0x002DA26C File Offset: 0x002D846C
		// (set) Token: 0x0600ADBF RID: 44479 RVA: 0x0004F798 File Offset: 0x0004D998
		public unsafe int _cellsZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__cellsZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__cellsZ)) = value;
			}
		}

		// Token: 0x1700341A RID: 13338
		// (get) Token: 0x0600ADC0 RID: 44480 RVA: 0x002DA294 File Offset: 0x002D8494
		// (set) Token: 0x0600ADC1 RID: 44481 RVA: 0x0004F7B3 File Offset: 0x0004D9B3
		public unsafe int _totalCells
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__totalCells);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__totalCells)) = value;
			}
		}

		// Token: 0x1700341B RID: 13339
		// (get) Token: 0x0600ADC2 RID: 44482 RVA: 0x002DA2BC File Offset: 0x002D84BC
		// (set) Token: 0x0600ADC3 RID: 44483 RVA: 0x0004F7CE File Offset: 0x0004D9CE
		public unsafe Coroutine _bakeRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__bakeRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2.NativeFieldInfoPtr__bakeRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040077EC RID: 30700
		private static readonly IntPtr NativeFieldInfoPtr__bounds;

		// Token: 0x040077ED RID: 30701
		private static readonly IntPtr NativeFieldInfoPtr__cellSize;

		// Token: 0x040077EE RID: 30702
		private static readonly IntPtr NativeFieldInfoPtr__maxDistance;

		// Token: 0x040077EF RID: 30703
		private static readonly IntPtr NativeFieldInfoPtr__inclusionZones;

		// Token: 0x040077F0 RID: 30704
		private static readonly IntPtr NativeFieldInfoPtr__occlusionObjects;

		// Token: 0x040077F1 RID: 30705
		private static readonly IntPtr NativeFieldInfoPtr__occlusionLayerMask;

		// Token: 0x040077F2 RID: 30706
		private static readonly IntPtr NativeFieldInfoPtr__visibilityData;

		// Token: 0x040077F3 RID: 30707
		private static readonly IntPtr NativeFieldInfoPtr__cellsX;

		// Token: 0x040077F4 RID: 30708
		private static readonly IntPtr NativeFieldInfoPtr__cellsY;

		// Token: 0x040077F5 RID: 30709
		private static readonly IntPtr NativeFieldInfoPtr__cellsZ;

		// Token: 0x040077F6 RID: 30710
		private static readonly IntPtr NativeFieldInfoPtr__totalCells;

		// Token: 0x040077F7 RID: 30711
		private static readonly IntPtr NativeFieldInfoPtr__bakeRoutine;

		// Token: 0x040077F8 RID: 30712
		private static readonly IntPtr NativeMethodInfoPtr_RunOcclusionBake_Public_Void_0;

		// Token: 0x040077F9 RID: 30713
		private static readonly IntPtr NativeMethodInfoPtr_DoOcclusionBakeRoutine_Private_IEnumerator_0;

		// Token: 0x040077FA RID: 30714
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040077FB RID: 30715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CAF RID: 3247
		[ObfuscatedName("ScheduleOne.Development.Experimental.OcclusionCulling.OcclusionManager2+<DoOcclusionBakeRoutine>d__13")]
		public sealed class _DoOcclusionBakeRoutine_d__13 : Il2CppSystem.Object
		{
			// Token: 0x0600F386 RID: 62342 RVA: 0x003A9E18 File Offset: 0x003A8018
			// Note: this type is marked as 'beforefieldinit'.
			static _DoOcclusionBakeRoutine_d__13()
			{
				Il2CppClassPointerStore<OcclusionManager2._DoOcclusionBakeRoutine_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OcclusionManager2>.NativeClassPtr, "<DoOcclusionBakeRoutine>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OcclusionManager2._DoOcclusionBakeRoutine_d__13>.NativeClassPtr);
				OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager2._DoOcclusionBakeRoutine_d__13>.NativeClassPtr, "<>1__state");
				OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager2._DoOcclusionBakeRoutine_d__13>.NativeClassPtr, "<>2__current");
				OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager2._DoOcclusionBakeRoutine_d__13>.NativeClassPtr, "<>4__this");
				OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr__stopwatch_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager2._DoOcclusionBakeRoutine_d__13>.NativeClassPtr, "<stopwatch>5__2");
				OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr__totalRays_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager2._DoOcclusionBakeRoutine_d__13>.NativeClassPtr, "<totalRays>5__3");
				OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr__commands_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager2._DoOcclusionBakeRoutine_d__13>.NativeClassPtr, "<commands>5__4");
				OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr__hits_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager2._DoOcclusionBakeRoutine_d__13>.NativeClassPtr, "<hits>5__5");
				OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr__objectCenters_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager2._DoOcclusionBakeRoutine_d__13>.NativeClassPtr, "<objectCenters>5__6");
				OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr__processHandle_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionManager2._DoOcclusionBakeRoutine_d__13>.NativeClassPtr, "<processHandle>5__7");
				OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager2._DoOcclusionBakeRoutine_d__13>.NativeClassPtr, 100686208);
				OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager2._DoOcclusionBakeRoutine_d__13>.NativeClassPtr, 100686209);
				OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager2._DoOcclusionBakeRoutine_d__13>.NativeClassPtr, 100686210);
				OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager2._DoOcclusionBakeRoutine_d__13>.NativeClassPtr, 100686211);
				OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager2._DoOcclusionBakeRoutine_d__13>.NativeClassPtr, 100686212);
				OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionManager2._DoOcclusionBakeRoutine_d__13>.NativeClassPtr, 100686213);
			}

			// Token: 0x0600F387 RID: 62343 RVA: 0x003A9F70 File Offset: 0x003A8170
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoOcclusionBakeRoutine_d__13(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OcclusionManager2._DoOcclusionBakeRoutine_d__13>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F388 RID: 62344 RVA: 0x003A9FB8 File Offset: 0x003A81B8
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F389 RID: 62345 RVA: 0x003A9FEC File Offset: 0x003A81EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297492, XrefRangeEnd = 297577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170049F1 RID: 18929
			// (get) Token: 0x0600F38A RID: 62346 RVA: 0x003AA028 File Offset: 0x003A8228
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F38B RID: 62347 RVA: 0x003AA068 File Offset: 0x003A8268
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297577, XrefRangeEnd = 297582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170049F2 RID: 18930
			// (get) Token: 0x0600F38C RID: 62348 RVA: 0x003AA09C File Offset: 0x003A829C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F38D RID: 62349 RVA: 0x00072F3D File Offset: 0x0007113D
			public _DoOcclusionBakeRoutine_d__13(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049E8 RID: 18920
			// (get) Token: 0x0600F38E RID: 62350 RVA: 0x003AA0DC File Offset: 0x003A82DC
			// (set) Token: 0x0600F38F RID: 62351 RVA: 0x00072F46 File Offset: 0x00071146
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170049E9 RID: 18921
			// (get) Token: 0x0600F390 RID: 62352 RVA: 0x003AA104 File Offset: 0x003A8304
			// (set) Token: 0x0600F391 RID: 62353 RVA: 0x00072F61 File Offset: 0x00071161
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049EA RID: 18922
			// (get) Token: 0x0600F392 RID: 62354 RVA: 0x003AA134 File Offset: 0x003A8334
			// (set) Token: 0x0600F393 RID: 62355 RVA: 0x00072F80 File Offset: 0x00071180
			public unsafe OcclusionManager2 __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OcclusionManager2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049EB RID: 18923
			// (get) Token: 0x0600F394 RID: 62356 RVA: 0x003AA164 File Offset: 0x003A8364
			// (set) Token: 0x0600F395 RID: 62357 RVA: 0x00072F9F File Offset: 0x0007119F
			public unsafe Stopwatch _stopwatch_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr__stopwatch_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stopwatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr__stopwatch_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049EC RID: 18924
			// (get) Token: 0x0600F396 RID: 62358 RVA: 0x003AA194 File Offset: 0x003A8394
			// (set) Token: 0x0600F397 RID: 62359 RVA: 0x00072FBE File Offset: 0x000711BE
			public unsafe int _totalRays_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr__totalRays_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr__totalRays_5__3)) = value;
				}
			}

			// Token: 0x170049ED RID: 18925
			// (get) Token: 0x0600F398 RID: 62360 RVA: 0x003AA1BC File Offset: 0x003A83BC
			// (set) Token: 0x0600F399 RID: 62361 RVA: 0x00072FD9 File Offset: 0x000711D9
			public NativeArray<RaycastCommand> _commands_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr__commands_5__4);
					return new NativeArray<RaycastCommand>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<RaycastCommand>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr__commands_5__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<RaycastCommand>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170049EE RID: 18926
			// (get) Token: 0x0600F39A RID: 62362 RVA: 0x003AA1EC File Offset: 0x003A83EC
			// (set) Token: 0x0600F39B RID: 62363 RVA: 0x00073007 File Offset: 0x00071207
			public NativeArray<RaycastHit> _hits_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr__hits_5__5);
					return new NativeArray<RaycastHit>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<RaycastHit>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr__hits_5__5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<RaycastHit>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170049EF RID: 18927
			// (get) Token: 0x0600F39C RID: 62364 RVA: 0x003AA21C File Offset: 0x003A841C
			// (set) Token: 0x0600F39D RID: 62365 RVA: 0x00073035 File Offset: 0x00071235
			public NativeArray<float3> _objectCenters_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr__objectCenters_5__6);
					return new NativeArray<float3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr__objectCenters_5__6), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float3>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170049F0 RID: 18928
			// (get) Token: 0x0600F39E RID: 62366 RVA: 0x003AA24C File Offset: 0x003A844C
			// (set) Token: 0x0600F39F RID: 62367 RVA: 0x00073063 File Offset: 0x00071263
			public unsafe JobHandle _processHandle_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr__processHandle_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OcclusionManager2._DoOcclusionBakeRoutine_d__13.NativeFieldInfoPtr__processHandle_5__7)) = value;
				}
			}

			// Token: 0x0400A4F4 RID: 42228
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A4F5 RID: 42229
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A4F6 RID: 42230
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A4F7 RID: 42231
			private static readonly IntPtr NativeFieldInfoPtr__stopwatch_5__2;

			// Token: 0x0400A4F8 RID: 42232
			private static readonly IntPtr NativeFieldInfoPtr__totalRays_5__3;

			// Token: 0x0400A4F9 RID: 42233
			private static readonly IntPtr NativeFieldInfoPtr__commands_5__4;

			// Token: 0x0400A4FA RID: 42234
			private static readonly IntPtr NativeFieldInfoPtr__hits_5__5;

			// Token: 0x0400A4FB RID: 42235
			private static readonly IntPtr NativeFieldInfoPtr__objectCenters_5__6;

			// Token: 0x0400A4FC RID: 42236
			private static readonly IntPtr NativeFieldInfoPtr__processHandle_5__7;

			// Token: 0x0400A4FD RID: 42237
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A4FE RID: 42238
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A4FF RID: 42239
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A500 RID: 42240
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A501 RID: 42241
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A502 RID: 42242
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
