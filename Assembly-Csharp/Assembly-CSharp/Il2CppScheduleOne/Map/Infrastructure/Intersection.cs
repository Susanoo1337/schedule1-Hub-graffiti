using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map.Infrastructure
{
	// Token: 0x020002CD RID: 717
	public class Intersection : MonoBehaviour
	{
		// Token: 0x06003843 RID: 14403 RVA: 0x001367DC File Offset: 0x001349DC
		// Note: this type is marked as 'beforefieldinit'.
		static Intersection()
		{
			Il2CppClassPointerStore<Intersection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map.Infrastructure", "Intersection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Intersection>.NativeClassPtr);
			Intersection.NativeFieldInfoPtr_AmberTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "AmberTime");
			Intersection.NativeFieldInfoPtr_path1Lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path1Lights");
			Intersection.NativeFieldInfoPtr_path2Lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path2Lights");
			Intersection.NativeFieldInfoPtr_path1Obstacles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path1Obstacles");
			Intersection.NativeFieldInfoPtr_path2Obstacles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path2Obstacles");
			Intersection.NativeFieldInfoPtr_path1Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path1Time");
			Intersection.NativeFieldInfoPtr_path2Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "path2Time");
			Intersection.NativeFieldInfoPtr_timeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "timeOffset");
			Intersection.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection>.NativeClassPtr, 100670423);
			Intersection.NativeMethodInfoPtr_Run_Protected_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection>.NativeClassPtr, 100670424);
			Intersection.NativeMethodInfoPtr_SetPath1Lights_Protected_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection>.NativeClassPtr, 100670425);
			Intersection.NativeMethodInfoPtr_SetPath2Lights_Protected_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection>.NativeClassPtr, 100670426);
			Intersection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection>.NativeClassPtr, 100670427);
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x00136910 File Offset: 0x00134B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144683, XrefRangeEnd = 144694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Intersection.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x0013694C File Offset: 0x00134B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144694, XrefRangeEnd = 144699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection.NativeMethodInfoPtr_Run_Protected_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003846 RID: 14406 RVA: 0x0013698C File Offset: 0x00134B8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 144748, RefRangeEnd = 144749, XrefRangeStart = 144699, XrefRangeEnd = 144748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPath1Lights(TrafficLight.State state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection.NativeMethodInfoPtr_SetPath1Lights_Protected_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003847 RID: 14407 RVA: 0x001369CC File Offset: 0x00134BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144749, XrefRangeEnd = 144798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPath2Lights(TrafficLight.State state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection.NativeMethodInfoPtr_SetPath2Lights_Protected_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x00136A0C File Offset: 0x00134C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144798, XrefRangeEnd = 144823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Intersection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Intersection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x0001C83D File Offset: 0x0001AA3D
		public Intersection(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x0600384A RID: 14410 RVA: 0x00136A48 File Offset: 0x00134C48
		// (set) Token: 0x0600384B RID: 14411 RVA: 0x0001C846 File Offset: 0x0001AA46
		public unsafe static float AmberTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Intersection.NativeFieldInfoPtr_AmberTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Intersection.NativeFieldInfoPtr_AmberTime, (void*)(&value));
			}
		}

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x0600384C RID: 14412 RVA: 0x00136A64 File Offset: 0x00134C64
		// (set) Token: 0x0600384D RID: 14413 RVA: 0x0001C854 File Offset: 0x0001AA54
		public unsafe List<TrafficLight> path1Lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrafficLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x0600384E RID: 14414 RVA: 0x00136A94 File Offset: 0x00134C94
		// (set) Token: 0x0600384F RID: 14415 RVA: 0x0001C873 File Offset: 0x0001AA73
		public unsafe List<TrafficLight> path2Lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrafficLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x06003850 RID: 14416 RVA: 0x00136AC4 File Offset: 0x00134CC4
		// (set) Token: 0x06003851 RID: 14417 RVA: 0x0001C892 File Offset: 0x0001AA92
		public unsafe List<GameObject> path1Obstacles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Obstacles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Obstacles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x06003852 RID: 14418 RVA: 0x00136AF4 File Offset: 0x00134CF4
		// (set) Token: 0x06003853 RID: 14419 RVA: 0x0001C8B1 File Offset: 0x0001AAB1
		public unsafe List<GameObject> path2Obstacles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Obstacles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Obstacles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x06003854 RID: 14420 RVA: 0x00136B24 File Offset: 0x00134D24
		// (set) Token: 0x06003855 RID: 14421 RVA: 0x0001C8D0 File Offset: 0x0001AAD0
		public unsafe float path1Time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path1Time)) = value;
			}
		}

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06003856 RID: 14422 RVA: 0x00136B4C File Offset: 0x00134D4C
		// (set) Token: 0x06003857 RID: 14423 RVA: 0x0001C8EB File Offset: 0x0001AAEB
		public unsafe float path2Time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_path2Time)) = value;
			}
		}

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x06003858 RID: 14424 RVA: 0x00136B74 File Offset: 0x00134D74
		// (set) Token: 0x06003859 RID: 14425 RVA: 0x0001C906 File Offset: 0x0001AB06
		public unsafe float timeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_timeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection.NativeFieldInfoPtr_timeOffset)) = value;
			}
		}

		// Token: 0x040025B3 RID: 9651
		private static readonly IntPtr NativeFieldInfoPtr_AmberTime;

		// Token: 0x040025B4 RID: 9652
		private static readonly IntPtr NativeFieldInfoPtr_path1Lights;

		// Token: 0x040025B5 RID: 9653
		private static readonly IntPtr NativeFieldInfoPtr_path2Lights;

		// Token: 0x040025B6 RID: 9654
		private static readonly IntPtr NativeFieldInfoPtr_path1Obstacles;

		// Token: 0x040025B7 RID: 9655
		private static readonly IntPtr NativeFieldInfoPtr_path2Obstacles;

		// Token: 0x040025B8 RID: 9656
		private static readonly IntPtr NativeFieldInfoPtr_path1Time;

		// Token: 0x040025B9 RID: 9657
		private static readonly IntPtr NativeFieldInfoPtr_path2Time;

		// Token: 0x040025BA RID: 9658
		private static readonly IntPtr NativeFieldInfoPtr_timeOffset;

		// Token: 0x040025BB RID: 9659
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040025BC RID: 9660
		private static readonly IntPtr NativeMethodInfoPtr_Run_Protected_IEnumerator_0;

		// Token: 0x040025BD RID: 9661
		private static readonly IntPtr NativeMethodInfoPtr_SetPath1Lights_Protected_Void_State_0;

		// Token: 0x040025BE RID: 9662
		private static readonly IntPtr NativeMethodInfoPtr_SetPath2Lights_Protected_Void_State_0;

		// Token: 0x040025BF RID: 9663
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A24 RID: 2596
		[ObfuscatedName("ScheduleOne.Map.Infrastructure.Intersection+<Run>d__9")]
		public sealed class _Run_d__9 : Il2CppSystem.Object
		{
			// Token: 0x0600DEA6 RID: 56998 RVA: 0x0036E228 File Offset: 0x0036C428
			// Note: this type is marked as 'beforefieldinit'.
			static _Run_d__9()
			{
				Il2CppClassPointerStore<Intersection._Run_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Intersection>.NativeClassPtr, "<Run>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Intersection._Run_d__9>.NativeClassPtr);
				Intersection._Run_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection._Run_d__9>.NativeClassPtr, "<>1__state");
				Intersection._Run_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection._Run_d__9>.NativeClassPtr, "<>2__current");
				Intersection._Run_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intersection._Run_d__9>.NativeClassPtr, "<>4__this");
				Intersection._Run_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__9>.NativeClassPtr, 100670428);
				Intersection._Run_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__9>.NativeClassPtr, 100670429);
				Intersection._Run_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__9>.NativeClassPtr, 100670430);
				Intersection._Run_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__9>.NativeClassPtr, 100670431);
				Intersection._Run_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__9>.NativeClassPtr, 100670432);
				Intersection._Run_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intersection._Run_d__9>.NativeClassPtr, 100670433);
			}

			// Token: 0x0600DEA7 RID: 56999 RVA: 0x0036E308 File Offset: 0x0036C508
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Run_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Intersection._Run_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEA8 RID: 57000 RVA: 0x0036E350 File Offset: 0x0036C550
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEA9 RID: 57001 RVA: 0x0036E384 File Offset: 0x0036C584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144670, XrefRangeEnd = 144678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043CD RID: 17357
			// (get) Token: 0x0600DEAA RID: 57002 RVA: 0x0036E3C0 File Offset: 0x0036C5C0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DEAB RID: 57003 RVA: 0x0036E400 File Offset: 0x0036C600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144678, XrefRangeEnd = 144683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043CE RID: 17358
			// (get) Token: 0x0600DEAC RID: 57004 RVA: 0x0036E434 File Offset: 0x0036C634
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intersection._Run_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DEAD RID: 57005 RVA: 0x00068D1C File Offset: 0x00066F1C
			public _Run_d__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043CA RID: 17354
			// (get) Token: 0x0600DEAE RID: 57006 RVA: 0x0036E474 File Offset: 0x0036C674
			// (set) Token: 0x0600DEAF RID: 57007 RVA: 0x00068D25 File Offset: 0x00066F25
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043CB RID: 17355
			// (get) Token: 0x0600DEB0 RID: 57008 RVA: 0x0036E49C File Offset: 0x0036C69C
			// (set) Token: 0x0600DEB1 RID: 57009 RVA: 0x00068D40 File Offset: 0x00066F40
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043CC RID: 17356
			// (get) Token: 0x0600DEB2 RID: 57010 RVA: 0x0036E4CC File Offset: 0x0036C6CC
			// (set) Token: 0x0600DEB3 RID: 57011 RVA: 0x00068D5F File Offset: 0x00066F5F
			public unsafe Intersection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Intersection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intersection._Run_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097B3 RID: 38835
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040097B4 RID: 38836
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040097B5 RID: 38837
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040097B6 RID: 38838
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040097B7 RID: 38839
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040097B8 RID: 38840
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040097B9 RID: 38841
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040097BA RID: 38842
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040097BB RID: 38843
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
