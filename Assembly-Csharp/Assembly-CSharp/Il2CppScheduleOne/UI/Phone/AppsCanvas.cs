using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020007A8 RID: 1960
	public class AppsCanvas : PlayerSingleton<AppsCanvas>
	{
		// Token: 0x0600BE11 RID: 48657 RVA: 0x0030AEA8 File Offset: 0x003090A8
		// Note: this type is marked as 'beforefieldinit'.
		static AppsCanvas()
		{
			Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "AppsCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr);
			AppsCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			AppsCanvas.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, "canvas");
			AppsCanvas.NativeFieldInfoPtr_delayedSetOpenRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, "delayedSetOpenRoutine");
			AppsCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100688076);
			AppsCanvas.NativeMethodInfoPtr_set_isOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100688077);
			AppsCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100688078);
			AppsCanvas.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100688079);
			AppsCanvas.NativeMethodInfoPtr_PhoneOpened_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100688080);
			AppsCanvas.NativeMethodInfoPtr_PhoneClosed_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100688081);
			AppsCanvas.NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100688082);
			AppsCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100688083);
			AppsCanvas.NativeMethodInfoPtr_SetCanvasActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100688084);
			AppsCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100688085);
		}

		// Token: 0x17003969 RID: 14697
		// (get) Token: 0x0600BE12 RID: 48658 RVA: 0x0030AFDC File Offset: 0x003091DC
		// (set) Token: 0x0600BE13 RID: 48659 RVA: 0x0030B018 File Offset: 0x00309218
		public unsafe bool isOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_set_isOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600BE14 RID: 48660 RVA: 0x0030B058 File Offset: 0x00309258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316538, XrefRangeEnd = 316544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppsCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE15 RID: 48661 RVA: 0x0030B094 File Offset: 0x00309294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316544, XrefRangeEnd = 316575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref IsOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppsCanvas.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE16 RID: 48662 RVA: 0x0030B0E0 File Offset: 0x003092E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316575, XrefRangeEnd = 316577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PhoneOpened()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_PhoneOpened_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE17 RID: 48663 RVA: 0x0030B114 File Offset: 0x00309314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316577, XrefRangeEnd = 316584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PhoneClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_PhoneClosed_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE18 RID: 48664 RVA: 0x0030B148 File Offset: 0x00309348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316584, XrefRangeEnd = 316589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedSetCanvasActive(bool active, float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600BE19 RID: 48665 RVA: 0x0030B1A4 File Offset: 0x003093A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316592, RefRangeEnd = 316593, XrefRangeStart = 316589, XrefRangeEnd = 316592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref o;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE1A RID: 48666 RVA: 0x0030B1E4 File Offset: 0x003093E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316593, XrefRangeEnd = 316596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanvasActive(bool a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_SetCanvasActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE1B RID: 48667 RVA: 0x0030B224 File Offset: 0x00309424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316596, XrefRangeEnd = 316599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppsCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE1C RID: 48668 RVA: 0x00058C0B File Offset: 0x00056E0B
		public AppsCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003966 RID: 14694
		// (get) Token: 0x0600BE1D RID: 48669 RVA: 0x0030B260 File Offset: 0x00309460
		// (set) Token: 0x0600BE1E RID: 48670 RVA: 0x00058C14 File Offset: 0x00056E14
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003967 RID: 14695
		// (get) Token: 0x0600BE1F RID: 48671 RVA: 0x0030B288 File Offset: 0x00309488
		// (set) Token: 0x0600BE20 RID: 48672 RVA: 0x00058C2F File Offset: 0x00056E2F
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003968 RID: 14696
		// (get) Token: 0x0600BE21 RID: 48673 RVA: 0x0030B2B8 File Offset: 0x003094B8
		// (set) Token: 0x0600BE22 RID: 48674 RVA: 0x00058C4E File Offset: 0x00056E4E
		public unsafe Coroutine delayedSetOpenRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr_delayedSetOpenRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr_delayedSetOpenRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008224 RID: 33316
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04008225 RID: 33317
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04008226 RID: 33318
		private static readonly IntPtr NativeFieldInfoPtr_delayedSetOpenRoutine;

		// Token: 0x04008227 RID: 33319
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04008228 RID: 33320
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Private_set_Void_Boolean_0;

		// Token: 0x04008229 RID: 33321
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400822A RID: 33322
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400822B RID: 33323
		private static readonly IntPtr NativeMethodInfoPtr_PhoneOpened_Protected_Void_0;

		// Token: 0x0400822C RID: 33324
		private static readonly IntPtr NativeMethodInfoPtr_PhoneClosed_Protected_Void_0;

		// Token: 0x0400822D RID: 33325
		private static readonly IntPtr NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0;

		// Token: 0x0400822E RID: 33326
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x0400822F RID: 33327
		private static readonly IntPtr NativeMethodInfoPtr_SetCanvasActive_Private_Void_Boolean_0;

		// Token: 0x04008230 RID: 33328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D22 RID: 3362
		[ObfuscatedName("ScheduleOne.UI.Phone.AppsCanvas+<DelayedSetCanvasActive>d__10")]
		public sealed class _DelayedSetCanvasActive_d__10 : Il2CppSystem.Object
		{
			// Token: 0x0600F875 RID: 63605 RVA: 0x003B7F18 File Offset: 0x003B6118
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedSetCanvasActive_d__10()
			{
				Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, "<DelayedSetCanvasActive>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, "<>1__state");
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, "<>2__current");
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, "delay");
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, "<>4__this");
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, "active");
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100688086);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100688087);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100688088);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100688089);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100688090);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100688091);
			}

			// Token: 0x0600F876 RID: 63606 RVA: 0x003B8020 File Offset: 0x003B6220
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedSetCanvasActive_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F877 RID: 63607 RVA: 0x003B8068 File Offset: 0x003B6268
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F878 RID: 63608 RVA: 0x003B809C File Offset: 0x003B629C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316528, XrefRangeEnd = 316533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004B8A RID: 19338
			// (get) Token: 0x0600F879 RID: 63609 RVA: 0x003B80D8 File Offset: 0x003B62D8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F87A RID: 63610 RVA: 0x003B8118 File Offset: 0x003B6318
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316533, XrefRangeEnd = 316538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004B8B RID: 19339
			// (get) Token: 0x0600F87B RID: 63611 RVA: 0x003B814C File Offset: 0x003B634C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F87C RID: 63612 RVA: 0x0007578B File Offset: 0x0007398B
			public _DelayedSetCanvasActive_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B85 RID: 19333
			// (get) Token: 0x0600F87D RID: 63613 RVA: 0x003B818C File Offset: 0x003B638C
			// (set) Token: 0x0600F87E RID: 63614 RVA: 0x00075794 File Offset: 0x00073994
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004B86 RID: 19334
			// (get) Token: 0x0600F87F RID: 63615 RVA: 0x003B81B4 File Offset: 0x003B63B4
			// (set) Token: 0x0600F880 RID: 63616 RVA: 0x000757AF File Offset: 0x000739AF
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B87 RID: 19335
			// (get) Token: 0x0600F881 RID: 63617 RVA: 0x003B81E4 File Offset: 0x003B63E4
			// (set) Token: 0x0600F882 RID: 63618 RVA: 0x000757CE File Offset: 0x000739CE
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x17004B88 RID: 19336
			// (get) Token: 0x0600F883 RID: 63619 RVA: 0x003B820C File Offset: 0x003B640C
			// (set) Token: 0x0600F884 RID: 63620 RVA: 0x000757E9 File Offset: 0x000739E9
			public unsafe AppsCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppsCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B89 RID: 19337
			// (get) Token: 0x0600F885 RID: 63621 RVA: 0x003B823C File Offset: 0x003B643C
			// (set) Token: 0x0600F886 RID: 63622 RVA: 0x00075808 File Offset: 0x00073A08
			public unsafe bool active
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_active);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_active)) = value;
				}
			}

			// Token: 0x0400A7EC RID: 42988
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A7ED RID: 42989
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A7EE RID: 42990
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x0400A7EF RID: 42991
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A7F0 RID: 42992
			private static readonly IntPtr NativeFieldInfoPtr_active;

			// Token: 0x0400A7F1 RID: 42993
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A7F2 RID: 42994
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A7F3 RID: 42995
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A7F4 RID: 42996
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A7F5 RID: 42997
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A7F6 RID: 42998
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
