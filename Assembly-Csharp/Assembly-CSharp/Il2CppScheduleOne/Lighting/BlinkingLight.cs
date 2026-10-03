using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Misc;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003D9 RID: 985
	public class BlinkingLight : MonoBehaviour
	{
		// Token: 0x06005837 RID: 22583 RVA: 0x001ACB54 File Offset: 0x001AAD54
		// Note: this type is marked as 'beforefieldinit'.
		static BlinkingLight()
		{
			Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "BlinkingLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr);
			BlinkingLight.NativeFieldInfoPtr_IsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "IsOn");
			BlinkingLight.NativeFieldInfoPtr_OnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "OnTime");
			BlinkingLight.NativeFieldInfoPtr_OffTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "OffTime");
			BlinkingLight.NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "light");
			BlinkingLight.NativeFieldInfoPtr_blinkRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "blinkRoutine");
			BlinkingLight.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, 100674890);
			BlinkingLight.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, 100674891);
			BlinkingLight.NativeMethodInfoPtr_Blink_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, 100674892);
			BlinkingLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, 100674893);
		}

		// Token: 0x06005838 RID: 22584 RVA: 0x001ACC38 File Offset: 0x001AAE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192997, XrefRangeEnd = 193001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005839 RID: 22585 RVA: 0x001ACC6C File Offset: 0x001AAE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193001, XrefRangeEnd = 193008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600583A RID: 22586 RVA: 0x001ACCA0 File Offset: 0x001AAEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193008, XrefRangeEnd = 193013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Blink()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight.NativeMethodInfoPtr_Blink_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600583B RID: 22587 RVA: 0x001ACCE0 File Offset: 0x001AAEE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193013, XrefRangeEnd = 193014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlinkingLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600583C RID: 22588 RVA: 0x00029AD9 File Offset: 0x00027CD9
		public BlinkingLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B30 RID: 6960
		// (get) Token: 0x0600583D RID: 22589 RVA: 0x001ACD1C File Offset: 0x001AAF1C
		// (set) Token: 0x0600583E RID: 22590 RVA: 0x00029AE2 File Offset: 0x00027CE2
		public unsafe bool IsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_IsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_IsOn)) = value;
			}
		}

		// Token: 0x17001B31 RID: 6961
		// (get) Token: 0x0600583F RID: 22591 RVA: 0x001ACD44 File Offset: 0x001AAF44
		// (set) Token: 0x06005840 RID: 22592 RVA: 0x00029AFD File Offset: 0x00027CFD
		public unsafe float OnTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_OnTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_OnTime)) = value;
			}
		}

		// Token: 0x17001B32 RID: 6962
		// (get) Token: 0x06005841 RID: 22593 RVA: 0x001ACD6C File Offset: 0x001AAF6C
		// (set) Token: 0x06005842 RID: 22594 RVA: 0x00029B18 File Offset: 0x00027D18
		public unsafe float OffTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_OffTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_OffTime)) = value;
			}
		}

		// Token: 0x17001B33 RID: 6963
		// (get) Token: 0x06005843 RID: 22595 RVA: 0x001ACD94 File Offset: 0x001AAF94
		// (set) Token: 0x06005844 RID: 22596 RVA: 0x00029B33 File Offset: 0x00027D33
		public unsafe ToggleableLight light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B34 RID: 6964
		// (get) Token: 0x06005845 RID: 22597 RVA: 0x001ACDC4 File Offset: 0x001AAFC4
		// (set) Token: 0x06005846 RID: 22598 RVA: 0x00029B52 File Offset: 0x00027D52
		public unsafe Coroutine blinkRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_blinkRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight.NativeFieldInfoPtr_blinkRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003CB3 RID: 15539
		private static readonly IntPtr NativeFieldInfoPtr_IsOn;

		// Token: 0x04003CB4 RID: 15540
		private static readonly IntPtr NativeFieldInfoPtr_OnTime;

		// Token: 0x04003CB5 RID: 15541
		private static readonly IntPtr NativeFieldInfoPtr_OffTime;

		// Token: 0x04003CB6 RID: 15542
		private static readonly IntPtr NativeFieldInfoPtr_light;

		// Token: 0x04003CB7 RID: 15543
		private static readonly IntPtr NativeFieldInfoPtr_blinkRoutine;

		// Token: 0x04003CB8 RID: 15544
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003CB9 RID: 15545
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04003CBA RID: 15546
		private static readonly IntPtr NativeMethodInfoPtr_Blink_Private_IEnumerator_0;

		// Token: 0x04003CBB RID: 15547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AD9 RID: 2777
		[ObfuscatedName("ScheduleOne.Lighting.BlinkingLight+<Blink>d__7")]
		public sealed class _Blink_d__7 : Il2CppSystem.Object
		{
			// Token: 0x0600E484 RID: 58500 RVA: 0x0037E668 File Offset: 0x0037C868
			// Note: this type is marked as 'beforefieldinit'.
			static _Blink_d__7()
			{
				Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlinkingLight>.NativeClassPtr, "<Blink>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr);
				BlinkingLight._Blink_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, "<>1__state");
				BlinkingLight._Blink_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, "<>2__current");
				BlinkingLight._Blink_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, "<>4__this");
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100674894);
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100674895);
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100674896);
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100674897);
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100674898);
				BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr, 100674899);
			}

			// Token: 0x0600E485 RID: 58501 RVA: 0x0037E748 File Offset: 0x0037C948
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Blink_d__7(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlinkingLight._Blink_d__7>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E486 RID: 58502 RVA: 0x0037E790 File Offset: 0x0037C990
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E487 RID: 58503 RVA: 0x0037E7C4 File Offset: 0x0037C9C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192991, XrefRangeEnd = 192992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700457A RID: 17786
			// (get) Token: 0x0600E488 RID: 58504 RVA: 0x0037E800 File Offset: 0x0037CA00
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E489 RID: 58505 RVA: 0x0037E840 File Offset: 0x0037CA40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192992, XrefRangeEnd = 192997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700457B RID: 17787
			// (get) Token: 0x0600E48A RID: 58506 RVA: 0x0037E874 File Offset: 0x0037CA74
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlinkingLight._Blink_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E48B RID: 58507 RVA: 0x0006BBD9 File Offset: 0x00069DD9
			public _Blink_d__7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004577 RID: 17783
			// (get) Token: 0x0600E48C RID: 58508 RVA: 0x0037E8B4 File Offset: 0x0037CAB4
			// (set) Token: 0x0600E48D RID: 58509 RVA: 0x0006BBE2 File Offset: 0x00069DE2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004578 RID: 17784
			// (get) Token: 0x0600E48E RID: 58510 RVA: 0x0037E8DC File Offset: 0x0037CADC
			// (set) Token: 0x0600E48F RID: 58511 RVA: 0x0006BBFD File Offset: 0x00069DFD
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004579 RID: 17785
			// (get) Token: 0x0600E490 RID: 58512 RVA: 0x0037E90C File Offset: 0x0037CB0C
			// (set) Token: 0x0600E491 RID: 58513 RVA: 0x0006BC1C File Offset: 0x00069E1C
			public unsafe BlinkingLight __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlinkingLight>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlinkingLight._Blink_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B2F RID: 39727
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009B30 RID: 39728
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009B31 RID: 39729
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009B32 RID: 39730
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009B33 RID: 39731
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009B34 RID: 39732
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009B35 RID: 39733
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009B36 RID: 39734
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009B37 RID: 39735
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
