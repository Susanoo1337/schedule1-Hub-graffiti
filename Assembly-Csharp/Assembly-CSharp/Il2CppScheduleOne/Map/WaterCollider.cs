using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002CB RID: 715
	public class WaterCollider : MonoBehaviour
	{
		// Token: 0x0600380D RID: 14349 RVA: 0x00135BA4 File Offset: 0x00133DA4
		// Note: this type is marked as 'beforefieldinit'.
		static WaterCollider()
		{
			Il2CppClassPointerStore<WaterCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "WaterCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterCollider>.NativeClassPtr);
			WaterCollider.NativeFieldInfoPtr_localPlayerBeingWarped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterCollider>.NativeClassPtr, "localPlayerBeingWarped");
			WaterCollider.NativeFieldInfoPtr_warpedVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterCollider>.NativeClassPtr, "warpedVehicles");
			WaterCollider.NativeFieldInfoPtr_SplashSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterCollider>.NativeClassPtr, "SplashSound");
			WaterCollider.NativeFieldInfoPtr_OverrideWarpPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterCollider>.NativeClassPtr, "OverrideWarpPoint");
			WaterCollider.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterCollider>.NativeClassPtr, 100670383);
			WaterCollider.NativeMethodInfoPtr_WarpPlayer_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterCollider>.NativeClassPtr, 100670384);
			WaterCollider.NativeMethodInfoPtr_WarpVehicle_Private_IEnumerator_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterCollider>.NativeClassPtr, 100670385);
			WaterCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterCollider>.NativeClassPtr, 100670386);
		}

		// Token: 0x0600380E RID: 14350 RVA: 0x00135C74 File Offset: 0x00133E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144319, XrefRangeEnd = 144361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterCollider.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600380F RID: 14351 RVA: 0x00135CB8 File Offset: 0x00133EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144361, XrefRangeEnd = 144366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WarpPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterCollider.NativeMethodInfoPtr_WarpPlayer_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003810 RID: 14352 RVA: 0x00135CF8 File Offset: 0x00133EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144366, XrefRangeEnd = 144372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WarpVehicle(LandVehicle veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterCollider.NativeMethodInfoPtr_WarpVehicle_Private_IEnumerator_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003811 RID: 14353 RVA: 0x00135D48 File Offset: 0x00133F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144372, XrefRangeEnd = 144380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaterCollider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterCollider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003812 RID: 14354 RVA: 0x0001C6AD File Offset: 0x0001A8AD
		public WaterCollider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x06003813 RID: 14355 RVA: 0x00135D84 File Offset: 0x00133F84
		// (set) Token: 0x06003814 RID: 14356 RVA: 0x0001C6B6 File Offset: 0x0001A8B6
		public unsafe bool localPlayerBeingWarped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider.NativeFieldInfoPtr_localPlayerBeingWarped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider.NativeFieldInfoPtr_localPlayerBeingWarped)) = value;
			}
		}

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x06003815 RID: 14357 RVA: 0x00135DAC File Offset: 0x00133FAC
		// (set) Token: 0x06003816 RID: 14358 RVA: 0x0001C6D1 File Offset: 0x0001A8D1
		public unsafe List<LandVehicle> warpedVehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider.NativeFieldInfoPtr_warpedVehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider.NativeFieldInfoPtr_warpedVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x06003817 RID: 14359 RVA: 0x00135DDC File Offset: 0x00133FDC
		// (set) Token: 0x06003818 RID: 14360 RVA: 0x0001C6F0 File Offset: 0x0001A8F0
		public unsafe AudioSourceController SplashSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider.NativeFieldInfoPtr_SplashSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider.NativeFieldInfoPtr_SplashSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x06003819 RID: 14361 RVA: 0x00135E0C File Offset: 0x0013400C
		// (set) Token: 0x0600381A RID: 14362 RVA: 0x0001C70F File Offset: 0x0001A90F
		public unsafe Transform OverrideWarpPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider.NativeFieldInfoPtr_OverrideWarpPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider.NativeFieldInfoPtr_OverrideWarpPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400258E RID: 9614
		private static readonly IntPtr NativeFieldInfoPtr_localPlayerBeingWarped;

		// Token: 0x0400258F RID: 9615
		private static readonly IntPtr NativeFieldInfoPtr_warpedVehicles;

		// Token: 0x04002590 RID: 9616
		private static readonly IntPtr NativeFieldInfoPtr_SplashSound;

		// Token: 0x04002591 RID: 9617
		private static readonly IntPtr NativeFieldInfoPtr_OverrideWarpPoint;

		// Token: 0x04002592 RID: 9618
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

		// Token: 0x04002593 RID: 9619
		private static readonly IntPtr NativeMethodInfoPtr_WarpPlayer_Private_IEnumerator_0;

		// Token: 0x04002594 RID: 9620
		private static readonly IntPtr NativeMethodInfoPtr_WarpVehicle_Private_IEnumerator_LandVehicle_0;

		// Token: 0x04002595 RID: 9621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A20 RID: 2592
		[ObfuscatedName("ScheduleOne.Map.WaterCollider+<WarpPlayer>d__5")]
		public sealed class _WarpPlayer_d__5 : Il2CppSystem.Object
		{
			// Token: 0x0600DE7E RID: 56958 RVA: 0x0036DAA8 File Offset: 0x0036BCA8
			// Note: this type is marked as 'beforefieldinit'.
			static _WarpPlayer_d__5()
			{
				Il2CppClassPointerStore<WaterCollider._WarpPlayer_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaterCollider>.NativeClassPtr, "<WarpPlayer>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterCollider._WarpPlayer_d__5>.NativeClassPtr);
				WaterCollider._WarpPlayer_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterCollider._WarpPlayer_d__5>.NativeClassPtr, "<>1__state");
				WaterCollider._WarpPlayer_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterCollider._WarpPlayer_d__5>.NativeClassPtr, "<>2__current");
				WaterCollider._WarpPlayer_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterCollider._WarpPlayer_d__5>.NativeClassPtr, "<>4__this");
				WaterCollider._WarpPlayer_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterCollider._WarpPlayer_d__5>.NativeClassPtr, 100670387);
				WaterCollider._WarpPlayer_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterCollider._WarpPlayer_d__5>.NativeClassPtr, 100670388);
				WaterCollider._WarpPlayer_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterCollider._WarpPlayer_d__5>.NativeClassPtr, 100670389);
				WaterCollider._WarpPlayer_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterCollider._WarpPlayer_d__5>.NativeClassPtr, 100670390);
				WaterCollider._WarpPlayer_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterCollider._WarpPlayer_d__5>.NativeClassPtr, 100670391);
				WaterCollider._WarpPlayer_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterCollider._WarpPlayer_d__5>.NativeClassPtr, 100670392);
			}

			// Token: 0x0600DE7F RID: 56959 RVA: 0x0036DB88 File Offset: 0x0036BD88
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WarpPlayer_d__5(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterCollider._WarpPlayer_d__5>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterCollider._WarpPlayer_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE80 RID: 56960 RVA: 0x0036DBD0 File Offset: 0x0036BDD0
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterCollider._WarpPlayer_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE81 RID: 56961 RVA: 0x0036DC04 File Offset: 0x0036BE04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144294, XrefRangeEnd = 144301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterCollider._WarpPlayer_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043BF RID: 17343
			// (get) Token: 0x0600DE82 RID: 56962 RVA: 0x0036DC40 File Offset: 0x0036BE40
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterCollider._WarpPlayer_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE83 RID: 56963 RVA: 0x0036DC80 File Offset: 0x0036BE80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144301, XrefRangeEnd = 144306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterCollider._WarpPlayer_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043C0 RID: 17344
			// (get) Token: 0x0600DE84 RID: 56964 RVA: 0x0036DCB4 File Offset: 0x0036BEB4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterCollider._WarpPlayer_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE85 RID: 56965 RVA: 0x00068BF1 File Offset: 0x00066DF1
			public _WarpPlayer_d__5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043BC RID: 17340
			// (get) Token: 0x0600DE86 RID: 56966 RVA: 0x0036DCF4 File Offset: 0x0036BEF4
			// (set) Token: 0x0600DE87 RID: 56967 RVA: 0x00068BFA File Offset: 0x00066DFA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider._WarpPlayer_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider._WarpPlayer_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043BD RID: 17341
			// (get) Token: 0x0600DE88 RID: 56968 RVA: 0x0036DD1C File Offset: 0x0036BF1C
			// (set) Token: 0x0600DE89 RID: 56969 RVA: 0x00068C15 File Offset: 0x00066E15
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider._WarpPlayer_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider._WarpPlayer_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043BE RID: 17342
			// (get) Token: 0x0600DE8A RID: 56970 RVA: 0x0036DD4C File Offset: 0x0036BF4C
			// (set) Token: 0x0600DE8B RID: 56971 RVA: 0x00068C34 File Offset: 0x00066E34
			public unsafe WaterCollider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider._WarpPlayer_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaterCollider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider._WarpPlayer_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009797 RID: 38807
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009798 RID: 38808
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009799 RID: 38809
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400979A RID: 38810
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400979B RID: 38811
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400979C RID: 38812
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400979D RID: 38813
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400979E RID: 38814
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400979F RID: 38815
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A21 RID: 2593
		[ObfuscatedName("ScheduleOne.Map.WaterCollider+<WarpVehicle>d__6")]
		public sealed class _WarpVehicle_d__6 : Il2CppSystem.Object
		{
			// Token: 0x0600DE8C RID: 56972 RVA: 0x0036DD7C File Offset: 0x0036BF7C
			// Note: this type is marked as 'beforefieldinit'.
			static _WarpVehicle_d__6()
			{
				Il2CppClassPointerStore<WaterCollider._WarpVehicle_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WaterCollider>.NativeClassPtr, "<WarpVehicle>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterCollider._WarpVehicle_d__6>.NativeClassPtr);
				WaterCollider._WarpVehicle_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterCollider._WarpVehicle_d__6>.NativeClassPtr, "<>1__state");
				WaterCollider._WarpVehicle_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterCollider._WarpVehicle_d__6>.NativeClassPtr, "<>2__current");
				WaterCollider._WarpVehicle_d__6.NativeFieldInfoPtr_veh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterCollider._WarpVehicle_d__6>.NativeClassPtr, "veh");
				WaterCollider._WarpVehicle_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterCollider._WarpVehicle_d__6>.NativeClassPtr, "<>4__this");
				WaterCollider._WarpVehicle_d__6.NativeFieldInfoPtr__faded_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterCollider._WarpVehicle_d__6>.NativeClassPtr, "<faded>5__2");
				WaterCollider._WarpVehicle_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterCollider._WarpVehicle_d__6>.NativeClassPtr, 100670393);
				WaterCollider._WarpVehicle_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterCollider._WarpVehicle_d__6>.NativeClassPtr, 100670394);
				WaterCollider._WarpVehicle_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterCollider._WarpVehicle_d__6>.NativeClassPtr, 100670395);
				WaterCollider._WarpVehicle_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterCollider._WarpVehicle_d__6>.NativeClassPtr, 100670396);
				WaterCollider._WarpVehicle_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterCollider._WarpVehicle_d__6>.NativeClassPtr, 100670397);
				WaterCollider._WarpVehicle_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterCollider._WarpVehicle_d__6>.NativeClassPtr, 100670398);
			}

			// Token: 0x0600DE8D RID: 56973 RVA: 0x0036DE84 File Offset: 0x0036C084
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WarpVehicle_d__6(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterCollider._WarpVehicle_d__6>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterCollider._WarpVehicle_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE8E RID: 56974 RVA: 0x0036DECC File Offset: 0x0036C0CC
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterCollider._WarpVehicle_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE8F RID: 56975 RVA: 0x0036DF00 File Offset: 0x0036C100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144306, XrefRangeEnd = 144314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterCollider._WarpVehicle_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043C6 RID: 17350
			// (get) Token: 0x0600DE90 RID: 56976 RVA: 0x0036DF3C File Offset: 0x0036C13C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterCollider._WarpVehicle_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE91 RID: 56977 RVA: 0x0036DF7C File Offset: 0x0036C17C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144314, XrefRangeEnd = 144319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterCollider._WarpVehicle_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043C7 RID: 17351
			// (get) Token: 0x0600DE92 RID: 56978 RVA: 0x0036DFB0 File Offset: 0x0036C1B0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterCollider._WarpVehicle_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE93 RID: 56979 RVA: 0x00068C53 File Offset: 0x00066E53
			public _WarpVehicle_d__6(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043C1 RID: 17345
			// (get) Token: 0x0600DE94 RID: 56980 RVA: 0x0036DFF0 File Offset: 0x0036C1F0
			// (set) Token: 0x0600DE95 RID: 56981 RVA: 0x00068C5C File Offset: 0x00066E5C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider._WarpVehicle_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider._WarpVehicle_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043C2 RID: 17346
			// (get) Token: 0x0600DE96 RID: 56982 RVA: 0x0036E018 File Offset: 0x0036C218
			// (set) Token: 0x0600DE97 RID: 56983 RVA: 0x00068C77 File Offset: 0x00066E77
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider._WarpVehicle_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider._WarpVehicle_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043C3 RID: 17347
			// (get) Token: 0x0600DE98 RID: 56984 RVA: 0x0036E048 File Offset: 0x0036C248
			// (set) Token: 0x0600DE99 RID: 56985 RVA: 0x00068C96 File Offset: 0x00066E96
			public unsafe LandVehicle veh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider._WarpVehicle_d__6.NativeFieldInfoPtr_veh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider._WarpVehicle_d__6.NativeFieldInfoPtr_veh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043C4 RID: 17348
			// (get) Token: 0x0600DE9A RID: 56986 RVA: 0x0036E078 File Offset: 0x0036C278
			// (set) Token: 0x0600DE9B RID: 56987 RVA: 0x00068CB5 File Offset: 0x00066EB5
			public unsafe WaterCollider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider._WarpVehicle_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaterCollider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider._WarpVehicle_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043C5 RID: 17349
			// (get) Token: 0x0600DE9C RID: 56988 RVA: 0x0036E0A8 File Offset: 0x0036C2A8
			// (set) Token: 0x0600DE9D RID: 56989 RVA: 0x00068CD4 File Offset: 0x00066ED4
			public unsafe bool _faded_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider._WarpVehicle_d__6.NativeFieldInfoPtr__faded_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterCollider._WarpVehicle_d__6.NativeFieldInfoPtr__faded_5__2)) = value;
				}
			}

			// Token: 0x040097A0 RID: 38816
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040097A1 RID: 38817
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040097A2 RID: 38818
			private static readonly IntPtr NativeFieldInfoPtr_veh;

			// Token: 0x040097A3 RID: 38819
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040097A4 RID: 38820
			private static readonly IntPtr NativeFieldInfoPtr__faded_5__2;

			// Token: 0x040097A5 RID: 38821
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040097A6 RID: 38822
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040097A7 RID: 38823
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040097A8 RID: 38824
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040097A9 RID: 38825
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040097AA RID: 38826
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
