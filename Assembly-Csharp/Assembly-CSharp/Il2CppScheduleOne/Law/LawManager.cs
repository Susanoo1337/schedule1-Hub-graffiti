using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Police;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x0200031C RID: 796
	public class LawManager : Singleton<LawManager>
	{
		// Token: 0x06003EA5 RID: 16037 RVA: 0x0014E3AC File Offset: 0x0014C5AC
		// Note: this type is marked as 'beforefieldinit'.
		static LawManager()
		{
			Il2CppClassPointerStore<LawManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "LawManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LawManager>.NativeClassPtr);
			LawManager.NativeFieldInfoPtr_OfficerDispatchMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawManager>.NativeClassPtr, "OfficerDispatchMin");
			LawManager.NativeFieldInfoPtr_OfficerDispatchMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawManager>.NativeClassPtr, "OfficerDispatchMax");
			LawManager.NativeFieldInfoPtr_DISPATCH_VEHICLE_USE_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawManager>.NativeClassPtr, "DISPATCH_VEHICLE_USE_THRESHOLD");
			LawManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager>.NativeClassPtr, 100671267);
			LawManager.NativeMethodInfoPtr_PoliceCalled_Public_Void_Player_Crime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager>.NativeClassPtr, 100671268);
			LawManager.NativeMethodInfoPtr_StartFootpatrol_Public_PatrolGroup_FootPatrolRoute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager>.NativeClassPtr, 100671269);
			LawManager.NativeMethodInfoPtr_StartVehiclePatrol_Public_PoliceOfficer_VehiclePatrolRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager>.NativeClassPtr, 100671270);
			LawManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager>.NativeClassPtr, 100671271);
		}

		// Token: 0x06003EA6 RID: 16038 RVA: 0x0014E47C File Offset: 0x0014C67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152828, XrefRangeEnd = 152854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EA7 RID: 16039 RVA: 0x0014E4B8 File Offset: 0x0014C6B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 152875, RefRangeEnd = 152878, XrefRangeStart = 152854, XrefRangeEnd = 152875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PoliceCalled(Player target, Crime crime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(crime);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.NativeMethodInfoPtr_PoliceCalled_Public_Void_Player_Crime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EA8 RID: 16040 RVA: 0x0014E50C File Offset: 0x0014C70C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152906, RefRangeEnd = 152907, XrefRangeStart = 152878, XrefRangeEnd = 152906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PatrolGroup StartFootpatrol(FootPatrolRoute route, int requestedMembers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestedMembers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.NativeMethodInfoPtr_StartFootpatrol_Public_PatrolGroup_FootPatrolRoute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PatrolGroup>(intPtr3) : null;
		}

		// Token: 0x06003EA9 RID: 16041 RVA: 0x0014E56C File Offset: 0x0014C76C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 152921, RefRangeEnd = 152923, XrefRangeStart = 152907, XrefRangeEnd = 152921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceOfficer StartVehiclePatrol(VehiclePatrolRoute route)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.NativeMethodInfoPtr_StartVehiclePatrol_Public_PoliceOfficer_VehiclePatrolRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr3) : null;
		}

		// Token: 0x06003EAA RID: 16042 RVA: 0x0014E5BC File Offset: 0x0014C7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152923, XrefRangeEnd = 152926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LawManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LawManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EAB RID: 16043 RVA: 0x0001F221 File Offset: 0x0001D421
		public LawManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x06003EAC RID: 16044 RVA: 0x0014E5F8 File Offset: 0x0014C7F8
		// (set) Token: 0x06003EAD RID: 16045 RVA: 0x0001F22A File Offset: 0x0001D42A
		public unsafe static int OfficerDispatchMin
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LawManager.NativeFieldInfoPtr_OfficerDispatchMin, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LawManager.NativeFieldInfoPtr_OfficerDispatchMin, (void*)(&value));
			}
		}

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x06003EAE RID: 16046 RVA: 0x0014E614 File Offset: 0x0014C814
		// (set) Token: 0x06003EAF RID: 16047 RVA: 0x0001F238 File Offset: 0x0001D438
		public unsafe static int OfficerDispatchMax
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LawManager.NativeFieldInfoPtr_OfficerDispatchMax, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LawManager.NativeFieldInfoPtr_OfficerDispatchMax, (void*)(&value));
			}
		}

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x06003EB0 RID: 16048 RVA: 0x0014E630 File Offset: 0x0014C830
		// (set) Token: 0x06003EB1 RID: 16049 RVA: 0x0001F246 File Offset: 0x0001D446
		public unsafe static float DISPATCH_VEHICLE_USE_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LawManager.NativeFieldInfoPtr_DISPATCH_VEHICLE_USE_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LawManager.NativeFieldInfoPtr_DISPATCH_VEHICLE_USE_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x04002A43 RID: 10819
		private static readonly IntPtr NativeFieldInfoPtr_OfficerDispatchMin;

		// Token: 0x04002A44 RID: 10820
		private static readonly IntPtr NativeFieldInfoPtr_OfficerDispatchMax;

		// Token: 0x04002A45 RID: 10821
		private static readonly IntPtr NativeFieldInfoPtr_DISPATCH_VEHICLE_USE_THRESHOLD;

		// Token: 0x04002A46 RID: 10822
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002A47 RID: 10823
		private static readonly IntPtr NativeMethodInfoPtr_PoliceCalled_Public_Void_Player_Crime_0;

		// Token: 0x04002A48 RID: 10824
		private static readonly IntPtr NativeMethodInfoPtr_StartFootpatrol_Public_PatrolGroup_FootPatrolRoute_Int32_0;

		// Token: 0x04002A49 RID: 10825
		private static readonly IntPtr NativeMethodInfoPtr_StartVehiclePatrol_Public_PoliceOfficer_VehiclePatrolRoute_0;

		// Token: 0x04002A4A RID: 10826
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A3F RID: 2623
		[ObfuscatedName("ScheduleOne.Law.LawManager+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600DF65 RID: 57189 RVA: 0x0037015C File Offset: 0x0036E35C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LawManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr);
				LawManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr, "<>9");
				LawManager.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr, "<>9__3_0");
				LawManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr, 100671274);
				LawManager.__c.NativeMethodInfoPtr__Start_b__3_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr, 100671275);
			}

			// Token: 0x0600DF66 RID: 57190 RVA: 0x003701D8 File Offset: 0x0036E3D8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LawManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF67 RID: 57191 RVA: 0x00370214 File Offset: 0x0036E414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152822, XrefRangeEnd = 152828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__3_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawManager.__c.NativeMethodInfoPtr__Start_b__3_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF68 RID: 57192 RVA: 0x0006934C File Offset: 0x0006754C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043FD RID: 17405
			// (get) Token: 0x0600DF69 RID: 57193 RVA: 0x00370248 File Offset: 0x0036E448
			// (set) Token: 0x0600DF6A RID: 57194 RVA: 0x00069355 File Offset: 0x00067555
			public unsafe static LawManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LawManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LawManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043FE RID: 17406
			// (get) Token: 0x0600DF6B RID: 57195 RVA: 0x00370270 File Offset: 0x0036E470
			// (set) Token: 0x0600DF6C RID: 57196 RVA: 0x00069367 File Offset: 0x00067567
			public unsafe static UnityAction __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LawManager.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LawManager.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009827 RID: 38951
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009828 RID: 38952
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04009829 RID: 38953
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400982A RID: 38954
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__3_0_Internal_Void_0;
		}
	}
}
