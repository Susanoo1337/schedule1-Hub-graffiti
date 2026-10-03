using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000406 RID: 1030
	public class StaggeredCallbackUtility : Singleton<StaggeredCallbackUtility>
	{
		// Token: 0x06005B1D RID: 23325 RVA: 0x001B58D4 File Offset: 0x001B3AD4
		// Note: this type is marked as 'beforefieldinit'.
		static StaggeredCallbackUtility()
		{
			Il2CppClassPointerStore<StaggeredCallbackUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "StaggeredCallbackUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaggeredCallbackUtility>.NativeClassPtr);
			StaggeredCallbackUtility.NativeMethodInfoPtr_InvokeStaggered_Public_Void_Int32_Single_Action_1_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaggeredCallbackUtility>.NativeClassPtr, 100675190);
			StaggeredCallbackUtility.NativeMethodInfoPtr_InvokeStaggered_Public_Void_Int32_Int32_Action_1_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaggeredCallbackUtility>.NativeClassPtr, 100675191);
			StaggeredCallbackUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaggeredCallbackUtility>.NativeClassPtr, 100675192);
		}

		// Token: 0x06005B1E RID: 23326 RVA: 0x001B5940 File Offset: 0x001B3B40
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 196724, RefRangeEnd = 196730, XrefRangeStart = 196707, XrefRangeEnd = 196724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeStaggered(int totalCalls, float totalTime, Action<int> callback, Action onComplete = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref totalCalls;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaggeredCallbackUtility.NativeMethodInfoPtr_InvokeStaggered_Public_Void_Int32_Single_Action_1_Int32_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B1F RID: 23327 RVA: 0x001B59B4 File Offset: 0x001B3BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196730, XrefRangeEnd = 196743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeStaggered(int totalCalls, int callsPerSecond, Action<int> callback, Action onComplete = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref totalCalls;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callsPerSecond;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaggeredCallbackUtility.NativeMethodInfoPtr_InvokeStaggered_Public_Void_Int32_Int32_Action_1_Int32_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B20 RID: 23328 RVA: 0x001B5A28 File Offset: 0x001B3C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196743, XrefRangeEnd = 196746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StaggeredCallbackUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaggeredCallbackUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaggeredCallbackUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B21 RID: 23329 RVA: 0x0002B261 File Offset: 0x00029461
		public StaggeredCallbackUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003E79 RID: 15993
		private static readonly IntPtr NativeMethodInfoPtr_InvokeStaggered_Public_Void_Int32_Single_Action_1_Int32_Action_0;

		// Token: 0x04003E7A RID: 15994
		private static readonly IntPtr NativeMethodInfoPtr_InvokeStaggered_Public_Void_Int32_Int32_Action_1_Int32_Action_0;

		// Token: 0x04003E7B RID: 15995
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AEC RID: 2796
		[ObfuscatedName("ScheduleOne.DevUtilities.StaggeredCallbackUtility+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x0600E4F8 RID: 58616 RVA: 0x0037FC0C File Offset: 0x0037DE0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StaggeredCallbackUtility>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0>.NativeClassPtr);
				StaggeredCallbackUtility.__c__DisplayClass1_0.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0>.NativeClassPtr, "onComplete");
				StaggeredCallbackUtility.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0>.NativeClassPtr, 100675193);
				StaggeredCallbackUtility.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Action_1_Int32_Int32_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0>.NativeClassPtr, 100675194);
			}

			// Token: 0x0600E4F9 RID: 58617 RVA: 0x0037FC74 File Offset: 0x0037DE74
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaggeredCallbackUtility.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4FA RID: 58618 RVA: 0x0037FCB0 File Offset: 0x0037DEB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196701, XrefRangeEnd = 196707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Action_1_Int32_Int32_Int32_PDM_0(Action<int> cb, int total, int perSecond)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref total;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref perSecond;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaggeredCallbackUtility.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Action_1_Int32_Int32_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E4FB RID: 58619 RVA: 0x0006BF18 File Offset: 0x0006A118
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004598 RID: 17816
			// (get) Token: 0x0600E4FC RID: 58620 RVA: 0x0037FD1C File Offset: 0x0037DF1C
			// (set) Token: 0x0600E4FD RID: 58621 RVA: 0x0006BF21 File Offset: 0x0006A121
			public unsafe Action onComplete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaggeredCallbackUtility.__c__DisplayClass1_0.NativeFieldInfoPtr_onComplete);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaggeredCallbackUtility.__c__DisplayClass1_0.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B72 RID: 39794
			private static readonly IntPtr NativeFieldInfoPtr_onComplete;

			// Token: 0x04009B73 RID: 39795
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B74 RID: 39796
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Action_1_Int32_Int32_Int32_PDM_0;

			// Token: 0x02000DD3 RID: 3539
			[ObfuscatedName("ScheduleOne.DevUtilities.StaggeredCallbackUtility+<>c__DisplayClass1_0+<<InvokeStaggered>g__InvokeStaggeredRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique : Object
			{
				// Token: 0x0600FF6A RID: 65386 RVA: 0x003CBC84 File Offset: 0x003C9E84
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique()
				{
					Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0>.NativeClassPtr, "<<InvokeStaggered>g__InvokeStaggeredRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique>.NativeClassPtr);
					StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique>.NativeClassPtr, "<>1__state");
					StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique>.NativeClassPtr, "<>2__current");
					StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr_perSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique>.NativeClassPtr, "perSecond");
					StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr_cb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique>.NativeClassPtr, "cb");
					StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr_total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique>.NativeClassPtr, "total");
					StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique>.NativeClassPtr, "<>4__this");
					StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr__interval_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique>.NativeClassPtr, "<interval>5__2");
					StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr__timeOnLastCall_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique>.NativeClassPtr, "<timeOnLastCall>5__3");
					StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique>.NativeClassPtr, "<i>5__4");
					StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique>.NativeClassPtr, 100675195);
					StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique>.NativeClassPtr, 100675196);
					StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique>.NativeClassPtr, 100675197);
					StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique>.NativeClassPtr, 100675198);
					StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique>.NativeClassPtr, 100675199);
					StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique>.NativeClassPtr, 100675200);
				}

				// Token: 0x0600FF6B RID: 65387 RVA: 0x003CBDDC File Offset: 0x003C9FDC
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FF6C RID: 65388 RVA: 0x003CBE24 File Offset: 0x003CA024
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FF6D RID: 65389 RVA: 0x003CBE58 File Offset: 0x003CA058
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196687, XrefRangeEnd = 196696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004DC7 RID: 19911
				// (get) Token: 0x0600FF6E RID: 65390 RVA: 0x003CBE94 File Offset: 0x003CA094
				public unsafe Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FF6F RID: 65391 RVA: 0x003CBED4 File Offset: 0x003CA0D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196696, XrefRangeEnd = 196701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004DC8 RID: 19912
				// (get) Token: 0x0600FF70 RID: 65392 RVA: 0x003CBF08 File Offset: 0x003CA108
				public unsafe Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FF71 RID: 65393 RVA: 0x0007902F File Offset: 0x0007722F
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004DBE RID: 19902
				// (get) Token: 0x0600FF72 RID: 65394 RVA: 0x003CBF48 File Offset: 0x003CA148
				// (set) Token: 0x0600FF73 RID: 65395 RVA: 0x00079038 File Offset: 0x00077238
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004DBF RID: 19903
				// (get) Token: 0x0600FF74 RID: 65396 RVA: 0x003CBF70 File Offset: 0x003CA170
				// (set) Token: 0x0600FF75 RID: 65397 RVA: 0x00079053 File Offset: 0x00077253
				public unsafe Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DC0 RID: 19904
				// (get) Token: 0x0600FF76 RID: 65398 RVA: 0x003CBFA0 File Offset: 0x003CA1A0
				// (set) Token: 0x0600FF77 RID: 65399 RVA: 0x00079072 File Offset: 0x00077272
				public unsafe int perSecond
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr_perSecond);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr_perSecond)) = value;
					}
				}

				// Token: 0x17004DC1 RID: 19905
				// (get) Token: 0x0600FF78 RID: 65400 RVA: 0x003CBFC8 File Offset: 0x003CA1C8
				// (set) Token: 0x0600FF79 RID: 65401 RVA: 0x0007908D File Offset: 0x0007728D
				public unsafe Action<int> cb
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr_cb);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr_cb), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DC2 RID: 19906
				// (get) Token: 0x0600FF7A RID: 65402 RVA: 0x003CBFF8 File Offset: 0x003CA1F8
				// (set) Token: 0x0600FF7B RID: 65403 RVA: 0x000790AC File Offset: 0x000772AC
				public unsafe int total
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr_total);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr_total)) = value;
					}
				}

				// Token: 0x17004DC3 RID: 19907
				// (get) Token: 0x0600FF7C RID: 65404 RVA: 0x003CC020 File Offset: 0x003CA220
				// (set) Token: 0x0600FF7D RID: 65405 RVA: 0x000790C7 File Offset: 0x000772C7
				public unsafe StaggeredCallbackUtility.__c__DisplayClass1_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaggeredCallbackUtility.__c__DisplayClass1_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DC4 RID: 19908
				// (get) Token: 0x0600FF7E RID: 65406 RVA: 0x003CC050 File Offset: 0x003CA250
				// (set) Token: 0x0600FF7F RID: 65407 RVA: 0x000790E6 File Offset: 0x000772E6
				public unsafe float _interval_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr__interval_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr__interval_5__2)) = value;
					}
				}

				// Token: 0x17004DC5 RID: 19909
				// (get) Token: 0x0600FF80 RID: 65408 RVA: 0x003CC078 File Offset: 0x003CA278
				// (set) Token: 0x0600FF81 RID: 65409 RVA: 0x00079101 File Offset: 0x00077301
				public unsafe float _timeOnLastCall_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr__timeOnLastCall_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr__timeOnLastCall_5__3)) = value;
					}
				}

				// Token: 0x17004DC6 RID: 19910
				// (get) Token: 0x0600FF82 RID: 65410 RVA: 0x003CC0A0 File Offset: 0x003CA2A0
				// (set) Token: 0x0600FF83 RID: 65411 RVA: 0x0007911C File Offset: 0x0007731C
				public unsafe int _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaggeredCallbackUtility.__c__DisplayClass1_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObpeInAc1cbtoSiInUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x0400AC18 RID: 44056
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AC19 RID: 44057
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AC1A RID: 44058
				private static readonly IntPtr NativeFieldInfoPtr_perSecond;

				// Token: 0x0400AC1B RID: 44059
				private static readonly IntPtr NativeFieldInfoPtr_cb;

				// Token: 0x0400AC1C RID: 44060
				private static readonly IntPtr NativeFieldInfoPtr_total;

				// Token: 0x0400AC1D RID: 44061
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AC1E RID: 44062
				private static readonly IntPtr NativeFieldInfoPtr__interval_5__2;

				// Token: 0x0400AC1F RID: 44063
				private static readonly IntPtr NativeFieldInfoPtr__timeOnLastCall_5__3;

				// Token: 0x0400AC20 RID: 44064
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x0400AC21 RID: 44065
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AC22 RID: 44066
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC23 RID: 44067
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AC24 RID: 44068
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AC25 RID: 44069
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC26 RID: 44070
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
