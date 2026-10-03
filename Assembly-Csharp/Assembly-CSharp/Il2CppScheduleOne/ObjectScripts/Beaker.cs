using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.StationFramework;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x020005A2 RID: 1442
	public class Beaker : StationItem
	{
		// Token: 0x0600850A RID: 34058 RVA: 0x0024569C File Offset: 0x0024389C
		// Note: this type is marked as 'beforefieldinit'.
		static Beaker()
		{
			Il2CppClassPointerStore<Beaker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Beaker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Beaker>.NativeClassPtr);
			Beaker.NativeFieldInfoPtr_ClampAngle_MaxLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "ClampAngle_MaxLiquid");
			Beaker.NativeFieldInfoPtr_ClampAngle_MinLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "ClampAngle_MinLiquid");
			Beaker.NativeFieldInfoPtr_AngleToPour_MaxLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "AngleToPour_MaxLiquid");
			Beaker.NativeFieldInfoPtr_AngleToPour_MinLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "AngleToPour_MinLiquid");
			Beaker.NativeFieldInfoPtr_Draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Draggable");
			Beaker.NativeFieldInfoPtr_Constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Constraint");
			Beaker.NativeFieldInfoPtr_ConcaveCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "ConcaveCollider");
			Beaker.NativeFieldInfoPtr_ConvexCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "ConvexCollider");
			Beaker.NativeFieldInfoPtr_CenterOfMass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "CenterOfMass");
			Beaker.NativeFieldInfoPtr_Joint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Joint");
			Beaker.NativeFieldInfoPtr_Anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Anchor");
			Beaker.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Container");
			Beaker.NativeFieldInfoPtr_Fillable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Fillable");
			Beaker.NativeFieldInfoPtr_Pourable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Pourable");
			Beaker.NativeFieldInfoPtr_FilterPaper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "FilterPaper");
			Beaker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Beaker>.NativeClassPtr, 100680432);
			Beaker.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Beaker>.NativeClassPtr, 100680433);
			Beaker.NativeMethodInfoPtr_SetStatic_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Beaker>.NativeClassPtr, 100680434);
			Beaker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Beaker>.NativeClassPtr, 100680435);
		}

		// Token: 0x0600850B RID: 34059 RVA: 0x00245848 File Offset: 0x00243A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250143, XrefRangeEnd = 250148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Beaker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600850C RID: 34060 RVA: 0x0024587C File Offset: 0x00243A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250148, XrefRangeEnd = 250153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Beaker.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600850D RID: 34061 RVA: 0x002458B0 File Offset: 0x00243AB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 250157, RefRangeEnd = 250158, XrefRangeStart = 250153, XrefRangeEnd = 250157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStatic(bool stat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Beaker.NativeMethodInfoPtr_SetStatic_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600850E RID: 34062 RVA: 0x002458F0 File Offset: 0x00243AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250158, XrefRangeEnd = 250159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Beaker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Beaker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Beaker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600850F RID: 34063 RVA: 0x0003F22E File Offset: 0x0003D42E
		public Beaker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700291E RID: 10526
		// (get) Token: 0x06008510 RID: 34064 RVA: 0x0024592C File Offset: 0x00243B2C
		// (set) Token: 0x06008511 RID: 34065 RVA: 0x0003F237 File Offset: 0x0003D437
		public unsafe float ClampAngle_MaxLiquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ClampAngle_MaxLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ClampAngle_MaxLiquid)) = value;
			}
		}

		// Token: 0x1700291F RID: 10527
		// (get) Token: 0x06008512 RID: 34066 RVA: 0x00245954 File Offset: 0x00243B54
		// (set) Token: 0x06008513 RID: 34067 RVA: 0x0003F252 File Offset: 0x0003D452
		public unsafe float ClampAngle_MinLiquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ClampAngle_MinLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ClampAngle_MinLiquid)) = value;
			}
		}

		// Token: 0x17002920 RID: 10528
		// (get) Token: 0x06008514 RID: 34068 RVA: 0x0024597C File Offset: 0x00243B7C
		// (set) Token: 0x06008515 RID: 34069 RVA: 0x0003F26D File Offset: 0x0003D46D
		public unsafe float AngleToPour_MaxLiquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_AngleToPour_MaxLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_AngleToPour_MaxLiquid)) = value;
			}
		}

		// Token: 0x17002921 RID: 10529
		// (get) Token: 0x06008516 RID: 34070 RVA: 0x002459A4 File Offset: 0x00243BA4
		// (set) Token: 0x06008517 RID: 34071 RVA: 0x0003F288 File Offset: 0x0003D488
		public unsafe float AngleToPour_MinLiquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_AngleToPour_MinLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_AngleToPour_MinLiquid)) = value;
			}
		}

		// Token: 0x17002922 RID: 10530
		// (get) Token: 0x06008518 RID: 34072 RVA: 0x002459CC File Offset: 0x00243BCC
		// (set) Token: 0x06008519 RID: 34073 RVA: 0x0003F2A3 File Offset: 0x0003D4A3
		public unsafe Draggable Draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002923 RID: 10531
		// (get) Token: 0x0600851A RID: 34074 RVA: 0x002459FC File Offset: 0x00243BFC
		// (set) Token: 0x0600851B RID: 34075 RVA: 0x0003F2C2 File Offset: 0x0003D4C2
		public unsafe DraggableConstraint Constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Constraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Constraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002924 RID: 10532
		// (get) Token: 0x0600851C RID: 34076 RVA: 0x00245A2C File Offset: 0x00243C2C
		// (set) Token: 0x0600851D RID: 34077 RVA: 0x0003F2E1 File Offset: 0x0003D4E1
		public unsafe Collider ConcaveCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ConcaveCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ConcaveCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002925 RID: 10533
		// (get) Token: 0x0600851E RID: 34078 RVA: 0x00245A5C File Offset: 0x00243C5C
		// (set) Token: 0x0600851F RID: 34079 RVA: 0x0003F300 File Offset: 0x0003D500
		public unsafe Collider ConvexCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ConvexCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ConvexCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002926 RID: 10534
		// (get) Token: 0x06008520 RID: 34080 RVA: 0x00245A8C File Offset: 0x00243C8C
		// (set) Token: 0x06008521 RID: 34081 RVA: 0x0003F31F File Offset: 0x0003D51F
		public unsafe Transform CenterOfMass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_CenterOfMass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_CenterOfMass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002927 RID: 10535
		// (get) Token: 0x06008522 RID: 34082 RVA: 0x00245ABC File Offset: 0x00243CBC
		// (set) Token: 0x06008523 RID: 34083 RVA: 0x0003F33E File Offset: 0x0003D53E
		public unsafe ConfigurableJoint Joint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Joint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurableJoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Joint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002928 RID: 10536
		// (get) Token: 0x06008524 RID: 34084 RVA: 0x00245AEC File Offset: 0x00243CEC
		// (set) Token: 0x06008525 RID: 34085 RVA: 0x0003F35D File Offset: 0x0003D55D
		public unsafe Rigidbody Anchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Anchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Anchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002929 RID: 10537
		// (get) Token: 0x06008526 RID: 34086 RVA: 0x00245B1C File Offset: 0x00243D1C
		// (set) Token: 0x06008527 RID: 34087 RVA: 0x0003F37C File Offset: 0x0003D57C
		public unsafe LiquidContainer Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700292A RID: 10538
		// (get) Token: 0x06008528 RID: 34088 RVA: 0x00245B4C File Offset: 0x00243D4C
		// (set) Token: 0x06008529 RID: 34089 RVA: 0x0003F39B File Offset: 0x0003D59B
		public unsafe Fillable Fillable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Fillable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Fillable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Fillable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700292B RID: 10539
		// (get) Token: 0x0600852A RID: 34090 RVA: 0x00245B7C File Offset: 0x00243D7C
		// (set) Token: 0x0600852B RID: 34091 RVA: 0x0003F3BA File Offset: 0x0003D5BA
		public unsafe PourableModule Pourable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Pourable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PourableModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Pourable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700292C RID: 10540
		// (get) Token: 0x0600852C RID: 34092 RVA: 0x00245BAC File Offset: 0x00243DAC
		// (set) Token: 0x0600852D RID: 34093 RVA: 0x0003F3D9 File Offset: 0x0003D5D9
		public unsafe GameObject FilterPaper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_FilterPaper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_FilterPaper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005AD8 RID: 23256
		private static readonly IntPtr NativeFieldInfoPtr_ClampAngle_MaxLiquid;

		// Token: 0x04005AD9 RID: 23257
		private static readonly IntPtr NativeFieldInfoPtr_ClampAngle_MinLiquid;

		// Token: 0x04005ADA RID: 23258
		private static readonly IntPtr NativeFieldInfoPtr_AngleToPour_MaxLiquid;

		// Token: 0x04005ADB RID: 23259
		private static readonly IntPtr NativeFieldInfoPtr_AngleToPour_MinLiquid;

		// Token: 0x04005ADC RID: 23260
		private static readonly IntPtr NativeFieldInfoPtr_Draggable;

		// Token: 0x04005ADD RID: 23261
		private static readonly IntPtr NativeFieldInfoPtr_Constraint;

		// Token: 0x04005ADE RID: 23262
		private static readonly IntPtr NativeFieldInfoPtr_ConcaveCollider;

		// Token: 0x04005ADF RID: 23263
		private static readonly IntPtr NativeFieldInfoPtr_ConvexCollider;

		// Token: 0x04005AE0 RID: 23264
		private static readonly IntPtr NativeFieldInfoPtr_CenterOfMass;

		// Token: 0x04005AE1 RID: 23265
		private static readonly IntPtr NativeFieldInfoPtr_Joint;

		// Token: 0x04005AE2 RID: 23266
		private static readonly IntPtr NativeFieldInfoPtr_Anchor;

		// Token: 0x04005AE3 RID: 23267
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005AE4 RID: 23268
		private static readonly IntPtr NativeFieldInfoPtr_Fillable;

		// Token: 0x04005AE5 RID: 23269
		private static readonly IntPtr NativeFieldInfoPtr_Pourable;

		// Token: 0x04005AE6 RID: 23270
		private static readonly IntPtr NativeFieldInfoPtr_FilterPaper;

		// Token: 0x04005AE7 RID: 23271
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005AE8 RID: 23272
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005AE9 RID: 23273
		private static readonly IntPtr NativeMethodInfoPtr_SetStatic_Public_Void_Boolean_0;

		// Token: 0x04005AEA RID: 23274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
