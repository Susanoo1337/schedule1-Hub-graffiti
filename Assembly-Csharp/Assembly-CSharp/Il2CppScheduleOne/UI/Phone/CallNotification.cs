using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ScriptableObjects;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020007AA RID: 1962
	public class CallNotification : Singleton<CallNotification>
	{
		// Token: 0x0600BE68 RID: 48744 RVA: 0x0030C06C File Offset: 0x0030A26C
		// Note: this type is marked as 'beforefieldinit'.
		static CallNotification()
		{
			Il2CppClassPointerStore<CallNotification>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "CallNotification");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallNotification>.NativeClassPtr);
			CallNotification.NativeFieldInfoPtr_TIME_PER_CHAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "TIME_PER_CHAR");
			CallNotification.NativeFieldInfoPtr__ActiveCallData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "<ActiveCallData>k__BackingField");
			CallNotification.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "<IsOpen>k__BackingField");
			CallNotification.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "Container");
			CallNotification.NativeFieldInfoPtr_ProfilePicture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "ProfilePicture");
			CallNotification.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "Group");
			CallNotification.NativeFieldInfoPtr_slideRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "slideRoutine");
			CallNotification.NativeMethodInfoPtr_get_ActiveCallData_Public_get_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, 100688123);
			CallNotification.NativeMethodInfoPtr_set_ActiveCallData_Private_set_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, 100688124);
			CallNotification.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, 100688125);
			CallNotification.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, 100688126);
			CallNotification.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, 100688127);
			CallNotification.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_CallerID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, 100688128);
			CallNotification.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, 100688129);
		}

		// Token: 0x17003989 RID: 14729
		// (get) Token: 0x0600BE69 RID: 48745 RVA: 0x0030C1B4 File Offset: 0x0030A3B4
		// (set) Token: 0x0600BE6A RID: 48746 RVA: 0x0030C1F4 File Offset: 0x0030A3F4
		public unsafe PhoneCallData ActiveCallData
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.NativeMethodInfoPtr_get_ActiveCallData_Public_get_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.NativeMethodInfoPtr_set_ActiveCallData_Private_set_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700398A RID: 14730
		// (get) Token: 0x0600BE6B RID: 48747 RVA: 0x0030C238 File Offset: 0x0030A438
		// (set) Token: 0x0600BE6C RID: 48748 RVA: 0x0030C274 File Offset: 0x0030A474
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600BE6D RID: 48749 RVA: 0x0030C2B4 File Offset: 0x0030A4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316910, XrefRangeEnd = 316918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallNotification.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE6E RID: 48750 RVA: 0x0030C2F0 File Offset: 0x0030A4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316918, XrefRangeEnd = 316933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool visible, CallerID caller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caller);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_CallerID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE6F RID: 48751 RVA: 0x0030C340 File Offset: 0x0030A540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316933, XrefRangeEnd = 316936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallNotification() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallNotification>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BE70 RID: 48752 RVA: 0x00058EFF File Offset: 0x000570FF
		public CallNotification(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003982 RID: 14722
		// (get) Token: 0x0600BE71 RID: 48753 RVA: 0x0030C37C File Offset: 0x0030A57C
		// (set) Token: 0x0600BE72 RID: 48754 RVA: 0x00058F08 File Offset: 0x00057108
		public unsafe static float TIME_PER_CHAR
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CallNotification.NativeFieldInfoPtr_TIME_PER_CHAR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallNotification.NativeFieldInfoPtr_TIME_PER_CHAR, (void*)(&value));
			}
		}

		// Token: 0x17003983 RID: 14723
		// (get) Token: 0x0600BE73 RID: 48755 RVA: 0x0030C398 File Offset: 0x0030A598
		// (set) Token: 0x0600BE74 RID: 48756 RVA: 0x00058F16 File Offset: 0x00057116
		public unsafe PhoneCallData _ActiveCallData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr__ActiveCallData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr__ActiveCallData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003984 RID: 14724
		// (get) Token: 0x0600BE75 RID: 48757 RVA: 0x0030C3C8 File Offset: 0x0030A5C8
		// (set) Token: 0x0600BE76 RID: 48758 RVA: 0x00058F35 File Offset: 0x00057135
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003985 RID: 14725
		// (get) Token: 0x0600BE77 RID: 48759 RVA: 0x0030C3F0 File Offset: 0x0030A5F0
		// (set) Token: 0x0600BE78 RID: 48760 RVA: 0x00058F50 File Offset: 0x00057150
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003986 RID: 14726
		// (get) Token: 0x0600BE79 RID: 48761 RVA: 0x0030C420 File Offset: 0x0030A620
		// (set) Token: 0x0600BE7A RID: 48762 RVA: 0x00058F6F File Offset: 0x0005716F
		public unsafe Image ProfilePicture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_ProfilePicture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_ProfilePicture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003987 RID: 14727
		// (get) Token: 0x0600BE7B RID: 48763 RVA: 0x0030C450 File Offset: 0x0030A650
		// (set) Token: 0x0600BE7C RID: 48764 RVA: 0x00058F8E File Offset: 0x0005718E
		public unsafe CanvasGroup Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003988 RID: 14728
		// (get) Token: 0x0600BE7D RID: 48765 RVA: 0x0030C480 File Offset: 0x0030A680
		// (set) Token: 0x0600BE7E RID: 48766 RVA: 0x00058FAD File Offset: 0x000571AD
		public unsafe Coroutine slideRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_slideRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_slideRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400825E RID: 33374
		private static readonly IntPtr NativeFieldInfoPtr_TIME_PER_CHAR;

		// Token: 0x0400825F RID: 33375
		private static readonly IntPtr NativeFieldInfoPtr__ActiveCallData_k__BackingField;

		// Token: 0x04008260 RID: 33376
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04008261 RID: 33377
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04008262 RID: 33378
		private static readonly IntPtr NativeFieldInfoPtr_ProfilePicture;

		// Token: 0x04008263 RID: 33379
		private static readonly IntPtr NativeFieldInfoPtr_Group;

		// Token: 0x04008264 RID: 33380
		private static readonly IntPtr NativeFieldInfoPtr_slideRoutine;

		// Token: 0x04008265 RID: 33381
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveCallData_Public_get_PhoneCallData_0;

		// Token: 0x04008266 RID: 33382
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveCallData_Private_set_Void_PhoneCallData_0;

		// Token: 0x04008267 RID: 33383
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04008268 RID: 33384
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04008269 RID: 33385
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400826A RID: 33386
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_CallerID_0;

		// Token: 0x0400826B RID: 33387
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D24 RID: 3364
		[ObfuscatedName("ScheduleOne.UI.Phone.CallNotification+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F891 RID: 63633 RVA: 0x003B83F0 File Offset: 0x003B65F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr);
				CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr, "visible");
				CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr_caller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr, "caller");
				CallNotification.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr, 100688130);
				CallNotification.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr, 100688131);
			}

			// Token: 0x0600F892 RID: 63634 RVA: 0x003B8480 File Offset: 0x003B6680
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F893 RID: 63635 RVA: 0x003B84BC File Offset: 0x003B66BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316905, XrefRangeEnd = 316910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F894 RID: 63636 RVA: 0x00075881 File Offset: 0x00073A81
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B8F RID: 19343
			// (get) Token: 0x0600F895 RID: 63637 RVA: 0x003B84FC File Offset: 0x003B66FC
			// (set) Token: 0x0600F896 RID: 63638 RVA: 0x0007588A File Offset: 0x00073A8A
			public unsafe bool visible
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr_visible);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr_visible)) = value;
				}
			}

			// Token: 0x17004B90 RID: 19344
			// (get) Token: 0x0600F897 RID: 63639 RVA: 0x003B8524 File Offset: 0x003B6724
			// (set) Token: 0x0600F898 RID: 63640 RVA: 0x000758A5 File Offset: 0x00073AA5
			public unsafe CallNotification __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallNotification>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B91 RID: 19345
			// (get) Token: 0x0600F899 RID: 63641 RVA: 0x003B8554 File Offset: 0x003B6754
			// (set) Token: 0x0600F89A RID: 63642 RVA: 0x000758C4 File Offset: 0x00073AC4
			public unsafe CallerID caller
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr_caller);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallerID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr_caller), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7FC RID: 43004
			private static readonly IntPtr NativeFieldInfoPtr_visible;

			// Token: 0x0400A7FD RID: 43005
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A7FE RID: 43006
			private static readonly IntPtr NativeFieldInfoPtr_caller;

			// Token: 0x0400A7FF RID: 43007
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A800 RID: 43008
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000E15 RID: 3605
			[ObfuscatedName("ScheduleOne.UI.Phone.CallNotification+<>c__DisplayClass14_0+<<SetIsOpen>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique : Il2CppSystem.Object
			{
				// Token: 0x060103C7 RID: 66503 RVA: 0x003D8E2C File Offset: 0x003D702C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique()
				{
					Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr, "<<SetIsOpen>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr);
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<>1__state");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<>2__current");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<>4__this");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startX_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<startX>5__2");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endX_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<endX>5__3");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startAlpha_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<startAlpha>5__4");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endAlpha_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<endAlpha>5__5");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__lerpTime_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<lerpTime>5__6");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__i_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<i>5__7");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100688132);
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100688133);
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100688134);
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100688135);
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100688136);
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100688137);
				}

				// Token: 0x060103C8 RID: 66504 RVA: 0x003D8F84 File Offset: 0x003D7184
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060103C9 RID: 66505 RVA: 0x003D8FCC File Offset: 0x003D71CC
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060103CA RID: 66506 RVA: 0x003D9000 File Offset: 0x003D7200
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316872, XrefRangeEnd = 316900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004F71 RID: 20337
				// (get) Token: 0x060103CB RID: 66507 RVA: 0x003D903C File Offset: 0x003D723C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060103CC RID: 66508 RVA: 0x003D907C File Offset: 0x003D727C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316900, XrefRangeEnd = 316905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004F72 RID: 20338
				// (get) Token: 0x060103CD RID: 66509 RVA: 0x003D90B0 File Offset: 0x003D72B0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060103CE RID: 66510 RVA: 0x0007B3C2 File Offset: 0x000795C2
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004F68 RID: 20328
				// (get) Token: 0x060103CF RID: 66511 RVA: 0x003D90F0 File Offset: 0x003D72F0
				// (set) Token: 0x060103D0 RID: 66512 RVA: 0x0007B3CB File Offset: 0x000795CB
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004F69 RID: 20329
				// (get) Token: 0x060103D1 RID: 66513 RVA: 0x003D9118 File Offset: 0x003D7318
				// (set) Token: 0x060103D2 RID: 66514 RVA: 0x0007B3E6 File Offset: 0x000795E6
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F6A RID: 20330
				// (get) Token: 0x060103D3 RID: 66515 RVA: 0x003D9148 File Offset: 0x003D7348
				// (set) Token: 0x060103D4 RID: 66516 RVA: 0x0007B405 File Offset: 0x00079605
				public unsafe CallNotification.__c__DisplayClass14_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallNotification.__c__DisplayClass14_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F6B RID: 20331
				// (get) Token: 0x060103D5 RID: 66517 RVA: 0x003D9178 File Offset: 0x003D7378
				// (set) Token: 0x060103D6 RID: 66518 RVA: 0x0007B424 File Offset: 0x00079624
				public unsafe float _startX_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startX_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startX_5__2)) = value;
					}
				}

				// Token: 0x17004F6C RID: 20332
				// (get) Token: 0x060103D7 RID: 66519 RVA: 0x003D91A0 File Offset: 0x003D73A0
				// (set) Token: 0x060103D8 RID: 66520 RVA: 0x0007B43F File Offset: 0x0007963F
				public unsafe float _endX_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endX_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endX_5__3)) = value;
					}
				}

				// Token: 0x17004F6D RID: 20333
				// (get) Token: 0x060103D9 RID: 66521 RVA: 0x003D91C8 File Offset: 0x003D73C8
				// (set) Token: 0x060103DA RID: 66522 RVA: 0x0007B45A File Offset: 0x0007965A
				public unsafe float _startAlpha_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startAlpha_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startAlpha_5__4)) = value;
					}
				}

				// Token: 0x17004F6E RID: 20334
				// (get) Token: 0x060103DB RID: 66523 RVA: 0x003D91F0 File Offset: 0x003D73F0
				// (set) Token: 0x060103DC RID: 66524 RVA: 0x0007B475 File Offset: 0x00079675
				public unsafe float _endAlpha_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endAlpha_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endAlpha_5__5)) = value;
					}
				}

				// Token: 0x17004F6F RID: 20335
				// (get) Token: 0x060103DD RID: 66525 RVA: 0x003D9218 File Offset: 0x003D7418
				// (set) Token: 0x060103DE RID: 66526 RVA: 0x0007B490 File Offset: 0x00079690
				public unsafe float _lerpTime_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__lerpTime_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__lerpTime_5__6)) = value;
					}
				}

				// Token: 0x17004F70 RID: 20336
				// (get) Token: 0x060103DF RID: 66527 RVA: 0x003D9240 File Offset: 0x003D7440
				// (set) Token: 0x060103E0 RID: 66528 RVA: 0x0007B4AB File Offset: 0x000796AB
				public unsafe float _i_5__7
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__i_5__7);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__i_5__7)) = value;
					}
				}

				// Token: 0x0400AECB RID: 44747
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AECC RID: 44748
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AECD RID: 44749
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AECE RID: 44750
				private static readonly IntPtr NativeFieldInfoPtr__startX_5__2;

				// Token: 0x0400AECF RID: 44751
				private static readonly IntPtr NativeFieldInfoPtr__endX_5__3;

				// Token: 0x0400AED0 RID: 44752
				private static readonly IntPtr NativeFieldInfoPtr__startAlpha_5__4;

				// Token: 0x0400AED1 RID: 44753
				private static readonly IntPtr NativeFieldInfoPtr__endAlpha_5__5;

				// Token: 0x0400AED2 RID: 44754
				private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__6;

				// Token: 0x0400AED3 RID: 44755
				private static readonly IntPtr NativeFieldInfoPtr__i_5__7;

				// Token: 0x0400AED4 RID: 44756
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AED5 RID: 44757
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AED6 RID: 44758
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AED7 RID: 44759
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AED8 RID: 44760
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AED9 RID: 44761
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
