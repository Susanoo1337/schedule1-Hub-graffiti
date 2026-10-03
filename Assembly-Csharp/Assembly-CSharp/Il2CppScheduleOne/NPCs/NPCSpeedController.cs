using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020005DB RID: 1499
	public class NPCSpeedController : MonoBehaviour
	{
		// Token: 0x060093D4 RID: 37844 RVA: 0x0027F600 File Offset: 0x0027D800
		// Note: this type is marked as 'beforefieldinit'.
		static NPCSpeedController()
		{
			Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCSpeedController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr);
			NPCSpeedController.NativeFieldInfoPtr_DefaultNormalizedSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "DefaultNormalizedSpeed");
			NPCSpeedController.NativeFieldInfoPtr__SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "_SpeedMultiplier");
			NPCSpeedController.NativeFieldInfoPtr__ActiveSpeedControl_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "<ActiveSpeedControl>k__BackingField");
			NPCSpeedController.NativeFieldInfoPtr_speedControlStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "speedControlStack");
			NPCSpeedController.NativeMethodInfoPtr_get_SpeedMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100682597);
			NPCSpeedController.NativeMethodInfoPtr_set_SpeedMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100682598);
			NPCSpeedController.NativeMethodInfoPtr_get_ActiveSpeedControl_Public_get_SpeedControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100682599);
			NPCSpeedController.NativeMethodInfoPtr_set_ActiveSpeedControl_Private_set_Void_SpeedControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100682600);
			NPCSpeedController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100682601);
			NPCSpeedController.NativeMethodInfoPtr_AddSpeedControl_Public_Void_SpeedControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100682602);
			NPCSpeedController.NativeMethodInfoPtr_GetSpeedControl_Public_SpeedControl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100682603);
			NPCSpeedController.NativeMethodInfoPtr_DoesSpeedControlExist_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100682604);
			NPCSpeedController.NativeMethodInfoPtr_RemoveSpeedControl_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100682605);
			NPCSpeedController.NativeMethodInfoPtr_UpdateActiveSpeedControl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100682606);
			NPCSpeedController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, 100682607);
		}

		// Token: 0x17002DB5 RID: 11701
		// (get) Token: 0x060093D5 RID: 37845 RVA: 0x0027F75C File Offset: 0x0027D95C
		// (set) Token: 0x060093D6 RID: 37846 RVA: 0x0027F798 File Offset: 0x0027D998
		public unsafe float SpeedMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_get_SpeedMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 270725, RefRangeEnd = 270735, XrefRangeStart = 270724, XrefRangeEnd = 270725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_set_SpeedMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DB6 RID: 11702
		// (get) Token: 0x060093D7 RID: 37847 RVA: 0x0027F7D8 File Offset: 0x0027D9D8
		// (set) Token: 0x060093D8 RID: 37848 RVA: 0x0027F818 File Offset: 0x0027DA18
		public unsafe NPCSpeedController.SpeedControl ActiveSpeedControl
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_get_ActiveSpeedControl_Public_get_SpeedControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCSpeedController.SpeedControl>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_set_ActiveSpeedControl_Private_set_Void_SpeedControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060093D9 RID: 37849 RVA: 0x0027F85C File Offset: 0x0027DA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270735, XrefRangeEnd = 270743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093DA RID: 37850 RVA: 0x0027F890 File Offset: 0x0027DA90
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 270775, RefRangeEnd = 270799, XrefRangeStart = 270743, XrefRangeEnd = 270775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSpeedControl(NPCSpeedController.SpeedControl control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(control);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_AddSpeedControl_Public_Void_SpeedControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093DB RID: 37851 RVA: 0x0027F8D4 File Offset: 0x0027DAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270799, XrefRangeEnd = 270814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCSpeedController.SpeedControl GetSpeedControl(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_GetSpeedControl_Public_SpeedControl_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCSpeedController.SpeedControl>(intPtr3) : null;
		}

		// Token: 0x060093DC RID: 37852 RVA: 0x0027F924 File Offset: 0x0027DB24
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 270828, RefRangeEnd = 270833, XrefRangeStart = 270814, XrefRangeEnd = 270828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesSpeedControlExist(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_DoesSpeedControlExist_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060093DD RID: 37853 RVA: 0x0027F974 File Offset: 0x0027DB74
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 270851, RefRangeEnd = 270876, XrefRangeStart = 270833, XrefRangeEnd = 270851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSpeedControl(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_RemoveSpeedControl_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093DE RID: 37854 RVA: 0x0027F9B8 File Offset: 0x0027DBB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 270881, RefRangeEnd = 270884, XrefRangeStart = 270876, XrefRangeEnd = 270881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateActiveSpeedControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr_UpdateActiveSpeedControl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093DF RID: 37855 RVA: 0x0027F9EC File Offset: 0x0027DBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270884, XrefRangeEnd = 270892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCSpeedController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093E0 RID: 37856 RVA: 0x0004547B File Offset: 0x0004367B
		public NPCSpeedController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DB1 RID: 11697
		// (get) Token: 0x060093E1 RID: 37857 RVA: 0x0027FA28 File Offset: 0x0027DC28
		// (set) Token: 0x060093E2 RID: 37858 RVA: 0x00045484 File Offset: 0x00043684
		public unsafe static float DefaultNormalizedSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCSpeedController.NativeFieldInfoPtr_DefaultNormalizedSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCSpeedController.NativeFieldInfoPtr_DefaultNormalizedSpeed, (void*)(&value));
			}
		}

		// Token: 0x17002DB2 RID: 11698
		// (get) Token: 0x060093E3 RID: 37859 RVA: 0x0027FA44 File Offset: 0x0027DC44
		// (set) Token: 0x060093E4 RID: 37860 RVA: 0x00045492 File Offset: 0x00043692
		public unsafe float _SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr__SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr__SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17002DB3 RID: 11699
		// (get) Token: 0x060093E5 RID: 37861 RVA: 0x0027FA6C File Offset: 0x0027DC6C
		// (set) Token: 0x060093E6 RID: 37862 RVA: 0x000454AD File Offset: 0x000436AD
		public unsafe NPCSpeedController.SpeedControl _ActiveSpeedControl_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr__ActiveSpeedControl_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSpeedController.SpeedControl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr__ActiveSpeedControl_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DB4 RID: 11700
		// (get) Token: 0x060093E7 RID: 37863 RVA: 0x0027FA9C File Offset: 0x0027DC9C
		// (set) Token: 0x060093E8 RID: 37864 RVA: 0x000454CC File Offset: 0x000436CC
		public unsafe List<NPCSpeedController.SpeedControl> speedControlStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_speedControlStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCSpeedController.SpeedControl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.NativeFieldInfoPtr_speedControlStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040065CE RID: 26062
		private static readonly IntPtr NativeFieldInfoPtr_DefaultNormalizedSpeed;

		// Token: 0x040065CF RID: 26063
		private static readonly IntPtr NativeFieldInfoPtr__SpeedMultiplier;

		// Token: 0x040065D0 RID: 26064
		private static readonly IntPtr NativeFieldInfoPtr__ActiveSpeedControl_k__BackingField;

		// Token: 0x040065D1 RID: 26065
		private static readonly IntPtr NativeFieldInfoPtr_speedControlStack;

		// Token: 0x040065D2 RID: 26066
		private static readonly IntPtr NativeMethodInfoPtr_get_SpeedMultiplier_Public_get_Single_0;

		// Token: 0x040065D3 RID: 26067
		private static readonly IntPtr NativeMethodInfoPtr_set_SpeedMultiplier_Public_set_Void_Single_0;

		// Token: 0x040065D4 RID: 26068
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveSpeedControl_Public_get_SpeedControl_0;

		// Token: 0x040065D5 RID: 26069
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveSpeedControl_Private_set_Void_SpeedControl_0;

		// Token: 0x040065D6 RID: 26070
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040065D7 RID: 26071
		private static readonly IntPtr NativeMethodInfoPtr_AddSpeedControl_Public_Void_SpeedControl_0;

		// Token: 0x040065D8 RID: 26072
		private static readonly IntPtr NativeMethodInfoPtr_GetSpeedControl_Public_SpeedControl_String_0;

		// Token: 0x040065D9 RID: 26073
		private static readonly IntPtr NativeMethodInfoPtr_DoesSpeedControlExist_Public_Boolean_String_0;

		// Token: 0x040065DA RID: 26074
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSpeedControl_Public_Void_String_0;

		// Token: 0x040065DB RID: 26075
		private static readonly IntPtr NativeMethodInfoPtr_UpdateActiveSpeedControl_Private_Void_0;

		// Token: 0x040065DC RID: 26076
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C2C RID: 3116
		[Serializable]
		public class SpeedControl : Il2CppSystem.Object
		{
			// Token: 0x0600EEE4 RID: 61156 RVA: 0x0039C05C File Offset: 0x0039A25C
			// Note: this type is marked as 'beforefieldinit'.
			static SpeedControl()
			{
				Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "SpeedControl");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr);
				NPCSpeedController.SpeedControl.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr, "id");
				NPCSpeedController.SpeedControl.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr, "priority");
				NPCSpeedController.SpeedControl.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr, "speed");
				NPCSpeedController.SpeedControl.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr, 100682608);
			}

			// Token: 0x0600EEE5 RID: 61157 RVA: 0x0039C0D8 File Offset: 0x0039A2D8
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 270703, RefRangeEnd = 270724, XrefRangeStart = 270701, XrefRangeEnd = 270703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpeedControl(string id, int priority, float speed) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSpeedController.SpeedControl>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.SpeedControl.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEE6 RID: 61158 RVA: 0x00070C81 File Offset: 0x0006EE81
			public SpeedControl(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700486E RID: 18542
			// (get) Token: 0x0600EEE7 RID: 61159 RVA: 0x0039C140 File Offset: 0x0039A340
			// (set) Token: 0x0600EEE8 RID: 61160 RVA: 0x00070C8A File Offset: 0x0006EE8A
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700486F RID: 18543
			// (get) Token: 0x0600EEE9 RID: 61161 RVA: 0x0039C168 File Offset: 0x0039A368
			// (set) Token: 0x0600EEEA RID: 61162 RVA: 0x00070CA9 File Offset: 0x0006EEA9
			public unsafe int priority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_priority)) = value;
				}
			}

			// Token: 0x17004870 RID: 18544
			// (get) Token: 0x0600EEEB RID: 61163 RVA: 0x0039C190 File Offset: 0x0039A390
			// (set) Token: 0x0600EEEC RID: 61164 RVA: 0x00070CC4 File Offset: 0x0006EEC4
			public unsafe float speed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_speed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.SpeedControl.NativeFieldInfoPtr_speed)) = value;
				}
			}

			// Token: 0x0400A1BE RID: 41406
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x0400A1BF RID: 41407
			private static readonly IntPtr NativeFieldInfoPtr_priority;

			// Token: 0x0400A1C0 RID: 41408
			private static readonly IntPtr NativeFieldInfoPtr_speed;

			// Token: 0x0400A1C1 RID: 41409
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0;
		}

		// Token: 0x02000C2D RID: 3117
		[ObfuscatedName("ScheduleOne.NPCs.NPCSpeedController+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EEED RID: 61165 RVA: 0x0039C1B8 File Offset: 0x0039A3B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr);
				NPCSpeedController.__c__DisplayClass12_0.NativeFieldInfoPtr_control = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr, "control");
				NPCSpeedController.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr, 100682609);
				NPCSpeedController.__c__DisplayClass12_0.NativeMethodInfoPtr__AddSpeedControl_b__0_Internal_Boolean_SpeedControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr, 100682610);
			}

			// Token: 0x0600EEEE RID: 61166 RVA: 0x0039C220 File Offset: 0x0039A420
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEEF RID: 61167 RVA: 0x0039C25C File Offset: 0x0039A45C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddSpeedControl_b__0(NPCSpeedController.SpeedControl x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass12_0.NativeMethodInfoPtr__AddSpeedControl_b__0_Internal_Boolean_SpeedControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EEF0 RID: 61168 RVA: 0x00070CDF File Offset: 0x0006EEDF
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004871 RID: 18545
			// (get) Token: 0x0600EEF1 RID: 61169 RVA: 0x0039C2AC File Offset: 0x0039A4AC
			// (set) Token: 0x0600EEF2 RID: 61170 RVA: 0x00070CE8 File Offset: 0x0006EEE8
			public unsafe NPCSpeedController.SpeedControl control
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass12_0.NativeFieldInfoPtr_control);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSpeedController.SpeedControl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass12_0.NativeFieldInfoPtr_control), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A1C2 RID: 41410
			private static readonly IntPtr NativeFieldInfoPtr_control;

			// Token: 0x0400A1C3 RID: 41411
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A1C4 RID: 41412
			private static readonly IntPtr NativeMethodInfoPtr__AddSpeedControl_b__0_Internal_Boolean_SpeedControl_0;
		}

		// Token: 0x02000C2E RID: 3118
		[ObfuscatedName("ScheduleOne.NPCs.NPCSpeedController+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EEF3 RID: 61171 RVA: 0x0039C2DC File Offset: 0x0039A4DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass13_0>.NativeClassPtr);
				NPCSpeedController.__c__DisplayClass13_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass13_0>.NativeClassPtr, "id");
				NPCSpeedController.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass13_0>.NativeClassPtr, 100682611);
				NPCSpeedController.__c__DisplayClass13_0.NativeMethodInfoPtr__GetSpeedControl_b__0_Internal_Boolean_SpeedControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass13_0>.NativeClassPtr, 100682612);
			}

			// Token: 0x0600EEF4 RID: 61172 RVA: 0x0039C344 File Offset: 0x0039A544
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEF5 RID: 61173 RVA: 0x0039C380 File Offset: 0x0039A580
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetSpeedControl_b__0(NPCSpeedController.SpeedControl x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass13_0.NativeMethodInfoPtr__GetSpeedControl_b__0_Internal_Boolean_SpeedControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EEF6 RID: 61174 RVA: 0x00070D07 File Offset: 0x0006EF07
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004872 RID: 18546
			// (get) Token: 0x0600EEF7 RID: 61175 RVA: 0x0039C3D0 File Offset: 0x0039A5D0
			// (set) Token: 0x0600EEF8 RID: 61176 RVA: 0x00070D10 File Offset: 0x0006EF10
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass13_0.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass13_0.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400A1C5 RID: 41413
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x0400A1C6 RID: 41414
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A1C7 RID: 41415
			private static readonly IntPtr NativeMethodInfoPtr__GetSpeedControl_b__0_Internal_Boolean_SpeedControl_0;
		}

		// Token: 0x02000C2F RID: 3119
		[ObfuscatedName("ScheduleOne.NPCs.NPCSpeedController+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EEF9 RID: 61177 RVA: 0x0039C3F8 File Offset: 0x0039A5F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCSpeedController>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass15_0>.NativeClassPtr);
				NPCSpeedController.__c__DisplayClass15_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass15_0>.NativeClassPtr, "id");
				NPCSpeedController.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass15_0>.NativeClassPtr, 100682613);
				NPCSpeedController.__c__DisplayClass15_0.NativeMethodInfoPtr__RemoveSpeedControl_b__0_Internal_Boolean_SpeedControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass15_0>.NativeClassPtr, 100682614);
			}

			// Token: 0x0600EEFA RID: 61178 RVA: 0x0039C460 File Offset: 0x0039A660
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSpeedController.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EEFB RID: 61179 RVA: 0x0039C49C File Offset: 0x0039A69C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveSpeedControl_b__0(NPCSpeedController.SpeedControl x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSpeedController.__c__DisplayClass15_0.NativeMethodInfoPtr__RemoveSpeedControl_b__0_Internal_Boolean_SpeedControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EEFC RID: 61180 RVA: 0x00070D2F File Offset: 0x0006EF2F
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004873 RID: 18547
			// (get) Token: 0x0600EEFD RID: 61181 RVA: 0x0039C4EC File Offset: 0x0039A6EC
			// (set) Token: 0x0600EEFE RID: 61182 RVA: 0x00070D38 File Offset: 0x0006EF38
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass15_0.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSpeedController.__c__DisplayClass15_0.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400A1C8 RID: 41416
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x0400A1C9 RID: 41417
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A1CA RID: 41418
			private static readonly IntPtr NativeMethodInfoPtr__RemoveSpeedControl_b__0_Internal_Boolean_SpeedControl_0;
		}
	}
}
