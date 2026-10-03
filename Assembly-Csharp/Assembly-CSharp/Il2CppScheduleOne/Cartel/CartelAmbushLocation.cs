using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Cartel
{
	// Token: 0x02000449 RID: 1097
	public class CartelAmbushLocation : MonoBehaviour
	{
		// Token: 0x0600633F RID: 25407 RVA: 0x001D332C File Offset: 0x001D152C
		// Note: this type is marked as 'beforefieldinit'.
		static CartelAmbushLocation()
		{
			Il2CppClassPointerStore<CartelAmbushLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cartel", "CartelAmbushLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelAmbushLocation>.NativeClassPtr);
			CartelAmbushLocation.NativeFieldInfoPtr_REQUIRED_AMBUSH_POINTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelAmbushLocation>.NativeClassPtr, "REQUIRED_AMBUSH_POINTS");
			CartelAmbushLocation.NativeFieldInfoPtr_DetectionRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelAmbushLocation>.NativeClassPtr, "DetectionRadius");
			CartelAmbushLocation.NativeFieldInfoPtr_AmbushPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelAmbushLocation>.NativeClassPtr, "AmbushPoints");
			CartelAmbushLocation.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelAmbushLocation>.NativeClassPtr, 100676339);
			CartelAmbushLocation.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelAmbushLocation>.NativeClassPtr, 100676340);
			CartelAmbushLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelAmbushLocation>.NativeClassPtr, 100676341);
		}

		// Token: 0x06006340 RID: 25408 RVA: 0x001D33D4 File Offset: 0x001D15D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209202, XrefRangeEnd = 209252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelAmbushLocation.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006341 RID: 25409 RVA: 0x001D3408 File Offset: 0x001D1608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209252, XrefRangeEnd = 209264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelAmbushLocation.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006342 RID: 25410 RVA: 0x001D343C File Offset: 0x001D163C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209264, XrefRangeEnd = 209265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelAmbushLocation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelAmbushLocation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelAmbushLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006343 RID: 25411 RVA: 0x0002ED06 File Offset: 0x0002CF06
		public CartelAmbushLocation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E7B RID: 7803
		// (get) Token: 0x06006344 RID: 25412 RVA: 0x001D3478 File Offset: 0x001D1678
		// (set) Token: 0x06006345 RID: 25413 RVA: 0x0002ED0F File Offset: 0x0002CF0F
		public unsafe static int REQUIRED_AMBUSH_POINTS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CartelAmbushLocation.NativeFieldInfoPtr_REQUIRED_AMBUSH_POINTS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CartelAmbushLocation.NativeFieldInfoPtr_REQUIRED_AMBUSH_POINTS, (void*)(&value));
			}
		}

		// Token: 0x17001E7C RID: 7804
		// (get) Token: 0x06006346 RID: 25414 RVA: 0x001D3494 File Offset: 0x001D1694
		// (set) Token: 0x06006347 RID: 25415 RVA: 0x0002ED1D File Offset: 0x0002CF1D
		public unsafe float DetectionRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelAmbushLocation.NativeFieldInfoPtr_DetectionRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelAmbushLocation.NativeFieldInfoPtr_DetectionRadius)) = value;
			}
		}

		// Token: 0x17001E7D RID: 7805
		// (get) Token: 0x06006348 RID: 25416 RVA: 0x001D34BC File Offset: 0x001D16BC
		// (set) Token: 0x06006349 RID: 25417 RVA: 0x0002ED38 File Offset: 0x0002CF38
		public unsafe Il2CppReferenceArray<Transform> AmbushPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelAmbushLocation.NativeFieldInfoPtr_AmbushPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelAmbushLocation.NativeFieldInfoPtr_AmbushPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400446B RID: 17515
		private static readonly IntPtr NativeFieldInfoPtr_REQUIRED_AMBUSH_POINTS;

		// Token: 0x0400446C RID: 17516
		private static readonly IntPtr NativeFieldInfoPtr_DetectionRadius;

		// Token: 0x0400446D RID: 17517
		private static readonly IntPtr NativeFieldInfoPtr_AmbushPoints;

		// Token: 0x0400446E RID: 17518
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400446F RID: 17519
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04004470 RID: 17520
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B3A RID: 2874
		[ObfuscatedName("ScheduleOne.Cartel.CartelAmbushLocation+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E6CF RID: 59087 RVA: 0x00384D40 File Offset: 0x00382F40
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CartelAmbushLocation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CartelAmbushLocation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelAmbushLocation.__c>.NativeClassPtr);
				CartelAmbushLocation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelAmbushLocation.__c>.NativeClassPtr, "<>9");
				CartelAmbushLocation.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelAmbushLocation.__c>.NativeClassPtr, "<>9__3_0");
				CartelAmbushLocation.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelAmbushLocation.__c>.NativeClassPtr, "<>9__3_1");
				CartelAmbushLocation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelAmbushLocation.__c>.NativeClassPtr, 100676343);
				CartelAmbushLocation.__c.NativeMethodInfoPtr__Awake_b__3_0_Internal_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelAmbushLocation.__c>.NativeClassPtr, 100676344);
				CartelAmbushLocation.__c.NativeMethodInfoPtr__Awake_b__3_1_Internal_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelAmbushLocation.__c>.NativeClassPtr, 100676345);
			}

			// Token: 0x0600E6D0 RID: 59088 RVA: 0x00384DE4 File Offset: 0x00382FE4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelAmbushLocation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelAmbushLocation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E6D1 RID: 59089 RVA: 0x00384E20 File Offset: 0x00383020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209194, XrefRangeEnd = 209198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Awake_b__3_0(Transform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelAmbushLocation.__c.NativeMethodInfoPtr__Awake_b__3_0_Internal_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E6D2 RID: 59090 RVA: 0x00384E70 File Offset: 0x00383070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209198, XrefRangeEnd = 209202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Awake_b__3_1(Transform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelAmbushLocation.__c.NativeMethodInfoPtr__Awake_b__3_1_Internal_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E6D3 RID: 59091 RVA: 0x0006CDCE File Offset: 0x0006AFCE
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700460D RID: 17933
			// (get) Token: 0x0600E6D4 RID: 59092 RVA: 0x00384EC0 File Offset: 0x003830C0
			// (set) Token: 0x0600E6D5 RID: 59093 RVA: 0x0006CDD7 File Offset: 0x0006AFD7
			public unsafe static CartelAmbushLocation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CartelAmbushLocation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelAmbushLocation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CartelAmbushLocation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700460E RID: 17934
			// (get) Token: 0x0600E6D6 RID: 59094 RVA: 0x00384EE8 File Offset: 0x003830E8
			// (set) Token: 0x0600E6D7 RID: 59095 RVA: 0x0006CDE9 File Offset: 0x0006AFE9
			public unsafe static Func<Transform, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CartelAmbushLocation.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Transform, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CartelAmbushLocation.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700460F RID: 17935
			// (get) Token: 0x0600E6D8 RID: 59096 RVA: 0x00384F10 File Offset: 0x00383110
			// (set) Token: 0x0600E6D9 RID: 59097 RVA: 0x0006CDFB File Offset: 0x0006AFFB
			public unsafe static Func<Transform, bool> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CartelAmbushLocation.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Transform, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CartelAmbushLocation.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009CAE RID: 40110
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009CAF RID: 40111
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04009CB0 RID: 40112
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x04009CB1 RID: 40113
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009CB2 RID: 40114
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__3_0_Internal_Boolean_Transform_0;

			// Token: 0x04009CB3 RID: 40115
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__3_1_Internal_Boolean_Transform_0;
		}
	}
}
