using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x020000EC RID: 236
	public class Sensor : MonoBehaviour
	{
		// Token: 0x0600164A RID: 5706 RVA: 0x000C5874 File Offset: 0x000C3A74
		// Note: this type is marked as 'beforefieldinit'.
		static Sensor()
		{
			Il2CppClassPointerStore<Sensor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "Sensor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sensor>.NativeClassPtr);
			Sensor.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "Enabled");
			Sensor.NativeFieldInfoPtr_obstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "obstruction");
			Sensor.NativeFieldInfoPtr_obstructionDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "obstructionDistance");
			Sensor.NativeFieldInfoPtr_checkRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "checkRate");
			Sensor.NativeFieldInfoPtr_minDetectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "minDetectionRange");
			Sensor.NativeFieldInfoPtr_maxDetectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "maxDetectionRange");
			Sensor.NativeFieldInfoPtr_checkRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "checkRadius");
			Sensor.NativeFieldInfoPtr_checkMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "checkMask");
			Sensor.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "vehicle");
			Sensor.NativeFieldInfoPtr_calculatedDetectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "calculatedDetectionRange");
			Sensor.NativeFieldInfoPtr_hit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "hit");
			Sensor.NativeFieldInfoPtr_hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sensor>.NativeClassPtr, "hits");
			Sensor.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensor>.NativeClassPtr, 100666432);
			Sensor.NativeMethodInfoPtr_Check_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensor>.NativeClassPtr, 100666433);
			Sensor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensor>.NativeClassPtr, 100666434);
			Sensor.NativeMethodInfoPtr__Check_b__13_0_Private_Single_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sensor>.NativeClassPtr, 100666435);
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x000C59E4 File Offset: 0x000C3BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95801, XrefRangeEnd = 95808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sensor.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x000C5A20 File Offset: 0x000C3C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95808, XrefRangeEnd = 95911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Check()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sensor.NativeMethodInfoPtr_Check_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x000C5A54 File Offset: 0x000C3C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95911, XrefRangeEnd = 95919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sensor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sensor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sensor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x000C5A90 File Offset: 0x000C3C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95919, XrefRangeEnd = 95925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _Check_b__13_0(RaycastHit x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sensor.NativeMethodInfoPtr__Check_b__13_0_Private_Single_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x0000C320 File Offset: 0x0000A520
		public Sensor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x000C5ADC File Offset: 0x000C3CDC
		// (set) Token: 0x06001651 RID: 5713 RVA: 0x0000C329 File Offset: 0x0000A529
		public unsafe bool Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_Enabled)) = value;
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06001652 RID: 5714 RVA: 0x000C5B04 File Offset: 0x000C3D04
		// (set) Token: 0x06001653 RID: 5715 RVA: 0x0000C344 File Offset: 0x0000A544
		public unsafe Collider obstruction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_obstruction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_obstruction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06001654 RID: 5716 RVA: 0x000C5B34 File Offset: 0x000C3D34
		// (set) Token: 0x06001655 RID: 5717 RVA: 0x0000C363 File Offset: 0x0000A563
		public unsafe float obstructionDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_obstructionDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_obstructionDistance)) = value;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06001656 RID: 5718 RVA: 0x000C5B5C File Offset: 0x000C3D5C
		// (set) Token: 0x06001657 RID: 5719 RVA: 0x0000C37E File Offset: 0x0000A57E
		public unsafe static float checkRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Sensor.NativeFieldInfoPtr_checkRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Sensor.NativeFieldInfoPtr_checkRate, (void*)(&value));
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001658 RID: 5720 RVA: 0x000C5B78 File Offset: 0x000C3D78
		// (set) Token: 0x06001659 RID: 5721 RVA: 0x0000C38C File Offset: 0x0000A58C
		public unsafe float minDetectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_minDetectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_minDetectionRange)) = value;
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x0600165A RID: 5722 RVA: 0x000C5BA0 File Offset: 0x000C3DA0
		// (set) Token: 0x0600165B RID: 5723 RVA: 0x0000C3A7 File Offset: 0x0000A5A7
		public unsafe float maxDetectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_maxDetectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_maxDetectionRange)) = value;
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x0600165C RID: 5724 RVA: 0x000C5BC8 File Offset: 0x000C3DC8
		// (set) Token: 0x0600165D RID: 5725 RVA: 0x0000C3C2 File Offset: 0x0000A5C2
		public unsafe float checkRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_checkRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_checkRadius)) = value;
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x0600165E RID: 5726 RVA: 0x000C5BF0 File Offset: 0x000C3DF0
		// (set) Token: 0x0600165F RID: 5727 RVA: 0x0000C3DD File Offset: 0x0000A5DD
		public unsafe LayerMask checkMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_checkMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_checkMask)) = value;
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06001660 RID: 5728 RVA: 0x000C5C18 File Offset: 0x000C3E18
		// (set) Token: 0x06001661 RID: 5729 RVA: 0x0000C3F8 File Offset: 0x0000A5F8
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06001662 RID: 5730 RVA: 0x000C5C48 File Offset: 0x000C3E48
		// (set) Token: 0x06001663 RID: 5731 RVA: 0x0000C417 File Offset: 0x0000A617
		public unsafe float calculatedDetectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_calculatedDetectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_calculatedDetectionRange)) = value;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06001664 RID: 5732 RVA: 0x000C5C70 File Offset: 0x000C3E70
		// (set) Token: 0x06001665 RID: 5733 RVA: 0x0000C432 File Offset: 0x0000A632
		public unsafe RaycastHit hit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_hit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_hit)) = value;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06001666 RID: 5734 RVA: 0x000C5C98 File Offset: 0x000C3E98
		// (set) Token: 0x06001667 RID: 5735 RVA: 0x0000C44D File Offset: 0x0000A64D
		public unsafe List<RaycastHit> hits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_hits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RaycastHit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sensor.NativeFieldInfoPtr_hits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeFieldInfoPtr_Enabled;

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeFieldInfoPtr_obstruction;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeFieldInfoPtr_obstructionDistance;

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeFieldInfoPtr_checkRate;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeFieldInfoPtr_minDetectionRange;

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeFieldInfoPtr_maxDetectionRange;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeFieldInfoPtr_checkRadius;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeFieldInfoPtr_checkMask;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeFieldInfoPtr_calculatedDetectionRange;

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeFieldInfoPtr_hit;

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeFieldInfoPtr_hits;

		// Token: 0x04000FA9 RID: 4009
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04000FAA RID: 4010
		private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Void_0;

		// Token: 0x04000FAB RID: 4011
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000FAC RID: 4012
		private static readonly IntPtr NativeMethodInfoPtr__Check_b__13_0_Private_Single_RaycastHit_0;
	}
}
