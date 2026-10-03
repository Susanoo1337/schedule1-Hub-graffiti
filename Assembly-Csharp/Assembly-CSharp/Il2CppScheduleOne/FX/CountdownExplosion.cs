using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x02000385 RID: 901
	public class CountdownExplosion : MonoBehaviour
	{
		// Token: 0x06004F88 RID: 20360 RVA: 0x0018D52C File Offset: 0x0018B72C
		// Note: this type is marked as 'beforefieldinit'.
		static CountdownExplosion()
		{
			Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "CountdownExplosion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr);
			CountdownExplosion.NativeFieldInfoPtr_COUNTDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "COUNTDOWN");
			CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "TICK_SPACING_MAX");
			CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "TICK_SPACING_MIN");
			CountdownExplosion.NativeFieldInfoPtr_TickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "TickSound");
			CountdownExplosion.NativeFieldInfoPtr_countdownRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "countdownRoutine");
			CountdownExplosion.NativeMethodInfoPtr_Trigger_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, 100673653);
			CountdownExplosion.NativeMethodInfoPtr_StopCountdown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, 100673654);
			CountdownExplosion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, 100673655);
			CountdownExplosion.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, 100673656);
		}

		// Token: 0x06004F89 RID: 20361 RVA: 0x0018D610 File Offset: 0x0018B810
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178435, RefRangeEnd = 178436, XrefRangeStart = 178423, XrefRangeEnd = 178435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Trigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.NativeMethodInfoPtr_Trigger_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F8A RID: 20362 RVA: 0x0018D644 File Offset: 0x0018B844
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 178441, RefRangeEnd = 178442, XrefRangeStart = 178436, XrefRangeEnd = 178441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCountdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.NativeMethodInfoPtr_StopCountdown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F8B RID: 20363 RVA: 0x0018D678 File Offset: 0x0018B878
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CountdownExplosion() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F8C RID: 20364 RVA: 0x0018D6B4 File Offset: 0x0018B8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178442, XrefRangeEnd = 178447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004F8D RID: 20365 RVA: 0x00025F0B File Offset: 0x0002410B
		public CountdownExplosion(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018C5 RID: 6341
		// (get) Token: 0x06004F8E RID: 20366 RVA: 0x0018D6F4 File Offset: 0x0018B8F4
		// (set) Token: 0x06004F8F RID: 20367 RVA: 0x00025F14 File Offset: 0x00024114
		public unsafe static float COUNTDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CountdownExplosion.NativeFieldInfoPtr_COUNTDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CountdownExplosion.NativeFieldInfoPtr_COUNTDOWN, (void*)(&value));
			}
		}

		// Token: 0x170018C6 RID: 6342
		// (get) Token: 0x06004F90 RID: 20368 RVA: 0x0018D710 File Offset: 0x0018B910
		// (set) Token: 0x06004F91 RID: 20369 RVA: 0x00025F22 File Offset: 0x00024122
		public unsafe static float TICK_SPACING_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MAX, (void*)(&value));
			}
		}

		// Token: 0x170018C7 RID: 6343
		// (get) Token: 0x06004F92 RID: 20370 RVA: 0x0018D72C File Offset: 0x0018B92C
		// (set) Token: 0x06004F93 RID: 20371 RVA: 0x00025F30 File Offset: 0x00024130
		public unsafe static float TICK_SPACING_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CountdownExplosion.NativeFieldInfoPtr_TICK_SPACING_MIN, (void*)(&value));
			}
		}

		// Token: 0x170018C8 RID: 6344
		// (get) Token: 0x06004F94 RID: 20372 RVA: 0x0018D748 File Offset: 0x0018B948
		// (set) Token: 0x06004F95 RID: 20373 RVA: 0x00025F3E File Offset: 0x0002413E
		public unsafe AudioSourceController TickSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.NativeFieldInfoPtr_TickSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.NativeFieldInfoPtr_TickSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018C9 RID: 6345
		// (get) Token: 0x06004F96 RID: 20374 RVA: 0x0018D778 File Offset: 0x0018B978
		// (set) Token: 0x06004F97 RID: 20375 RVA: 0x00025F5D File Offset: 0x0002415D
		public unsafe Coroutine countdownRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.NativeFieldInfoPtr_countdownRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.NativeFieldInfoPtr_countdownRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003692 RID: 13970
		private static readonly IntPtr NativeFieldInfoPtr_COUNTDOWN;

		// Token: 0x04003693 RID: 13971
		private static readonly IntPtr NativeFieldInfoPtr_TICK_SPACING_MAX;

		// Token: 0x04003694 RID: 13972
		private static readonly IntPtr NativeFieldInfoPtr_TICK_SPACING_MIN;

		// Token: 0x04003695 RID: 13973
		private static readonly IntPtr NativeFieldInfoPtr_TickSound;

		// Token: 0x04003696 RID: 13974
		private static readonly IntPtr NativeFieldInfoPtr_countdownRoutine;

		// Token: 0x04003697 RID: 13975
		private static readonly IntPtr NativeMethodInfoPtr_Trigger_Public_Void_0;

		// Token: 0x04003698 RID: 13976
		private static readonly IntPtr NativeMethodInfoPtr_StopCountdown_Public_Void_0;

		// Token: 0x04003699 RID: 13977
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400369A RID: 13978
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000A8D RID: 2701
		[ObfuscatedName("ScheduleOne.FX.CountdownExplosion+<<Trigger>g__Routine|5_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600E1F5 RID: 57845 RVA: 0x003773F4 File Offset: 0x003755F4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique()
			{
				Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CountdownExplosion>.NativeClassPtr, "<<Trigger>g__Routine|5_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, "<>1__state");
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, "<>2__current");
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, "<>4__this");
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__timeUntilNextTick_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, "<timeUntilNextTick>5__2");
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, "<i>5__3");
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100673657);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100673658);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100673659);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100673660);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100673661);
				CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr, 100673662);
			}

			// Token: 0x0600E1F6 RID: 57846 RVA: 0x003774FC File Offset: 0x003756FC
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E1F7 RID: 57847 RVA: 0x00377544 File Offset: 0x00375744
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E1F8 RID: 57848 RVA: 0x00377578 File Offset: 0x00375778
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178403, XrefRangeEnd = 178418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044C7 RID: 17607
			// (get) Token: 0x0600E1F9 RID: 57849 RVA: 0x003775B4 File Offset: 0x003757B4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E1FA RID: 57850 RVA: 0x003775F4 File Offset: 0x003757F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178418, XrefRangeEnd = 178423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044C8 RID: 17608
			// (get) Token: 0x0600E1FB RID: 57851 RVA: 0x00377628 File Offset: 0x00375828
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E1FC RID: 57852 RVA: 0x0006A7C3 File Offset: 0x000689C3
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044C2 RID: 17602
			// (get) Token: 0x0600E1FD RID: 57853 RVA: 0x00377668 File Offset: 0x00375868
			// (set) Token: 0x0600E1FE RID: 57854 RVA: 0x0006A7CC File Offset: 0x000689CC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044C3 RID: 17603
			// (get) Token: 0x0600E1FF RID: 57855 RVA: 0x00377690 File Offset: 0x00375890
			// (set) Token: 0x0600E200 RID: 57856 RVA: 0x0006A7E7 File Offset: 0x000689E7
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044C4 RID: 17604
			// (get) Token: 0x0600E201 RID: 57857 RVA: 0x003776C0 File Offset: 0x003758C0
			// (set) Token: 0x0600E202 RID: 57858 RVA: 0x0006A806 File Offset: 0x00068A06
			public unsafe CountdownExplosion __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CountdownExplosion>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044C5 RID: 17605
			// (get) Token: 0x0600E203 RID: 57859 RVA: 0x003776F0 File Offset: 0x003758F0
			// (set) Token: 0x0600E204 RID: 57860 RVA: 0x0006A825 File Offset: 0x00068A25
			public unsafe float _timeUntilNextTick_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__timeUntilNextTick_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__timeUntilNextTick_5__2)) = value;
				}
			}

			// Token: 0x170044C6 RID: 17606
			// (get) Token: 0x0600E205 RID: 57861 RVA: 0x00377718 File Offset: 0x00375918
			// (set) Token: 0x0600E206 RID: 57862 RVA: 0x0006A840 File Offset: 0x00068A40
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CountdownExplosion.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040099C6 RID: 39366
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040099C7 RID: 39367
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040099C8 RID: 39368
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040099C9 RID: 39369
			private static readonly IntPtr NativeFieldInfoPtr__timeUntilNextTick_5__2;

			// Token: 0x040099CA RID: 39370
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040099CB RID: 39371
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040099CC RID: 39372
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040099CD RID: 39373
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040099CE RID: 39374
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040099CF RID: 39375
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040099D0 RID: 39376
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
