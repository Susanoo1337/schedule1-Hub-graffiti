using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x020003B0 RID: 944
	public class SlidingDoor : MonoBehaviour
	{
		// Token: 0x060055C6 RID: 21958 RVA: 0x001A4208 File Offset: 0x001A2408
		// Note: this type is marked as 'beforefieldinit'.
		static SlidingDoor()
		{
			Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "SlidingDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr);
			SlidingDoor.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "<IsOpen>k__BackingField");
			SlidingDoor.NativeFieldInfoPtr_DoorTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "DoorTransform");
			SlidingDoor.NativeFieldInfoPtr_ClosedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "ClosedPosition");
			SlidingDoor.NativeFieldInfoPtr_OpenPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "OpenPosition");
			SlidingDoor.NativeFieldInfoPtr_SlideDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "SlideDuration");
			SlidingDoor.NativeFieldInfoPtr_SlideCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "SlideCurve");
			SlidingDoor.NativeFieldInfoPtr_MoveRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "MoveRoutine");
			SlidingDoor.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, 100674535);
			SlidingDoor.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, 100674536);
			SlidingDoor.NativeMethodInfoPtr_Opened_Public_Virtual_New_Void_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, 100674537);
			SlidingDoor.NativeMethodInfoPtr_Closed_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, 100674538);
			SlidingDoor.NativeMethodInfoPtr_Move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, 100674539);
			SlidingDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, 100674540);
			SlidingDoor.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, 100674541);
		}

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x060055C7 RID: 21959 RVA: 0x001A4350 File Offset: 0x001A2550
		// (set) Token: 0x060055C8 RID: 21960 RVA: 0x001A438C File Offset: 0x001A258C
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060055C9 RID: 21961 RVA: 0x001A43CC File Offset: 0x001A25CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189596, XrefRangeEnd = 189597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Opened(EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref openSide;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlidingDoor.NativeMethodInfoPtr_Opened_Public_Virtual_New_Void_EDoorSide_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055CA RID: 21962 RVA: 0x001A4418 File Offset: 0x001A2618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189597, XrefRangeEnd = 189598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Closed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlidingDoor.NativeMethodInfoPtr_Closed_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055CB RID: 21963 RVA: 0x001A4454 File Offset: 0x001A2654
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 189606, RefRangeEnd = 189608, XrefRangeStart = 189598, XrefRangeEnd = 189606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.NativeMethodInfoPtr_Move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055CC RID: 21964 RVA: 0x001A4488 File Offset: 0x001A2688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189608, XrefRangeEnd = 189609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlidingDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055CD RID: 21965 RVA: 0x001A44C4 File Offset: 0x001A26C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189609, XrefRangeEnd = 189614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060055CE RID: 21966 RVA: 0x00028884 File Offset: 0x00026A84
		public SlidingDoor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x060055CF RID: 21967 RVA: 0x001A4504 File Offset: 0x001A2704
		// (set) Token: 0x060055D0 RID: 21968 RVA: 0x0002888D File Offset: 0x00026A8D
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x060055D1 RID: 21969 RVA: 0x001A452C File Offset: 0x001A272C
		// (set) Token: 0x060055D2 RID: 21970 RVA: 0x000288A8 File Offset: 0x00026AA8
		public unsafe Transform DoorTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_DoorTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_DoorTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A92 RID: 6802
		// (get) Token: 0x060055D3 RID: 21971 RVA: 0x001A455C File Offset: 0x001A275C
		// (set) Token: 0x060055D4 RID: 21972 RVA: 0x000288C7 File Offset: 0x00026AC7
		public unsafe Transform ClosedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_ClosedPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_ClosedPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x060055D5 RID: 21973 RVA: 0x001A458C File Offset: 0x001A278C
		// (set) Token: 0x060055D6 RID: 21974 RVA: 0x000288E6 File Offset: 0x00026AE6
		public unsafe Transform OpenPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_OpenPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_OpenPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x060055D7 RID: 21975 RVA: 0x001A45BC File Offset: 0x001A27BC
		// (set) Token: 0x060055D8 RID: 21976 RVA: 0x00028905 File Offset: 0x00026B05
		public unsafe float SlideDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_SlideDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_SlideDuration)) = value;
			}
		}

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x060055D9 RID: 21977 RVA: 0x001A45E4 File Offset: 0x001A27E4
		// (set) Token: 0x060055DA RID: 21978 RVA: 0x00028920 File Offset: 0x00026B20
		public unsafe AnimationCurve SlideCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_SlideCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_SlideCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x060055DB RID: 21979 RVA: 0x001A4614 File Offset: 0x001A2814
		// (set) Token: 0x060055DC RID: 21980 RVA: 0x0002893F File Offset: 0x00026B3F
		public unsafe Coroutine MoveRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_MoveRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.NativeFieldInfoPtr_MoveRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B1D RID: 15133
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04003B1E RID: 15134
		private static readonly IntPtr NativeFieldInfoPtr_DoorTransform;

		// Token: 0x04003B1F RID: 15135
		private static readonly IntPtr NativeFieldInfoPtr_ClosedPosition;

		// Token: 0x04003B20 RID: 15136
		private static readonly IntPtr NativeFieldInfoPtr_OpenPosition;

		// Token: 0x04003B21 RID: 15137
		private static readonly IntPtr NativeFieldInfoPtr_SlideDuration;

		// Token: 0x04003B22 RID: 15138
		private static readonly IntPtr NativeFieldInfoPtr_SlideCurve;

		// Token: 0x04003B23 RID: 15139
		private static readonly IntPtr NativeFieldInfoPtr_MoveRoutine;

		// Token: 0x04003B24 RID: 15140
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04003B25 RID: 15141
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04003B26 RID: 15142
		private static readonly IntPtr NativeMethodInfoPtr_Opened_Public_Virtual_New_Void_EDoorSide_0;

		// Token: 0x04003B27 RID: 15143
		private static readonly IntPtr NativeMethodInfoPtr_Closed_Public_Virtual_New_Void_0;

		// Token: 0x04003B28 RID: 15144
		private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Void_0;

		// Token: 0x04003B29 RID: 15145
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003B2A RID: 15146
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000AB7 RID: 2743
		[ObfuscatedName("ScheduleOne.Doors.SlidingDoor+<<Move>g__Move|12_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600E362 RID: 58210 RVA: 0x0037B2D0 File Offset: 0x003794D0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique()
			{
				Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlidingDoor>.NativeClassPtr, "<<Move>g__Move|12_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr);
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, "<>1__state");
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, "<>2__current");
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, "<>4__this");
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__start_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, "<start>5__2");
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__end_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, "<end>5__3");
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, "<i>5__4");
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, 100674542);
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, 100674543);
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, 100674544);
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, 100674545);
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, 100674546);
				SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr, 100674547);
			}

			// Token: 0x0600E363 RID: 58211 RVA: 0x0037B3EC File Offset: 0x003795EC
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E364 RID: 58212 RVA: 0x0037B434 File Offset: 0x00379634
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E365 RID: 58213 RVA: 0x0037B468 File Offset: 0x00379668
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189575, XrefRangeEnd = 189591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004530 RID: 17712
			// (get) Token: 0x0600E366 RID: 58214 RVA: 0x0037B4A4 File Offset: 0x003796A4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E367 RID: 58215 RVA: 0x0037B4E4 File Offset: 0x003796E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189591, XrefRangeEnd = 189596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004531 RID: 17713
			// (get) Token: 0x0600E368 RID: 58216 RVA: 0x0037B518 File Offset: 0x00379718
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E369 RID: 58217 RVA: 0x0006B331 File Offset: 0x00069531
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700452A RID: 17706
			// (get) Token: 0x0600E36A RID: 58218 RVA: 0x0037B558 File Offset: 0x00379758
			// (set) Token: 0x0600E36B RID: 58219 RVA: 0x0006B33A File Offset: 0x0006953A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700452B RID: 17707
			// (get) Token: 0x0600E36C RID: 58220 RVA: 0x0037B580 File Offset: 0x00379780
			// (set) Token: 0x0600E36D RID: 58221 RVA: 0x0006B355 File Offset: 0x00069555
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700452C RID: 17708
			// (get) Token: 0x0600E36E RID: 58222 RVA: 0x0037B5B0 File Offset: 0x003797B0
			// (set) Token: 0x0600E36F RID: 58223 RVA: 0x0006B374 File Offset: 0x00069574
			public unsafe SlidingDoor __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlidingDoor>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700452D RID: 17709
			// (get) Token: 0x0600E370 RID: 58224 RVA: 0x0037B5E0 File Offset: 0x003797E0
			// (set) Token: 0x0600E371 RID: 58225 RVA: 0x0006B393 File Offset: 0x00069593
			public unsafe Vector3 _start_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__start_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__start_5__2)) = value;
				}
			}

			// Token: 0x1700452E RID: 17710
			// (get) Token: 0x0600E372 RID: 58226 RVA: 0x0037B608 File Offset: 0x00379808
			// (set) Token: 0x0600E373 RID: 58227 RVA: 0x0006B3AE File Offset: 0x000695AE
			public unsafe Vector3 _end_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__end_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__end_5__3)) = value;
				}
			}

			// Token: 0x1700452F RID: 17711
			// (get) Token: 0x0600E374 RID: 58228 RVA: 0x0037B630 File Offset: 0x00379830
			// (set) Token: 0x0600E375 RID: 58229 RVA: 0x0006B3C9 File Offset: 0x000695C9
			public unsafe float _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlidingDoor.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlVeSiVeObObUnique.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x04009A95 RID: 39573
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009A96 RID: 39574
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009A97 RID: 39575
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009A98 RID: 39576
			private static readonly IntPtr NativeFieldInfoPtr__start_5__2;

			// Token: 0x04009A99 RID: 39577
			private static readonly IntPtr NativeFieldInfoPtr__end_5__3;

			// Token: 0x04009A9A RID: 39578
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x04009A9B RID: 39579
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009A9C RID: 39580
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009A9D RID: 39581
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009A9E RID: 39582
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009A9F RID: 39583
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009AA0 RID: 39584
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
