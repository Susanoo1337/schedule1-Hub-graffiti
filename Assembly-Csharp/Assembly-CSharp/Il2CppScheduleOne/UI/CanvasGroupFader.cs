using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200071E RID: 1822
	public class CanvasGroupFader : MonoBehaviour
	{
		// Token: 0x0600AFC7 RID: 44999 RVA: 0x002DFF5C File Offset: 0x002DE15C
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasGroupFader()
		{
			Il2CppClassPointerStore<CanvasGroupFader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CanvasGroupFader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasGroupFader>.NativeClassPtr);
			CanvasGroupFader.NativeFieldInfoPtr__defaultFadeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasGroupFader>.NativeClassPtr, "_defaultFadeDuration");
			CanvasGroupFader.NativeFieldInfoPtr__scaleDurationWithFadeAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasGroupFader>.NativeClassPtr, "_scaleDurationWithFadeAmount");
			CanvasGroupFader.NativeFieldInfoPtr__canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasGroupFader>.NativeClassPtr, "_canvasGroup");
			CanvasGroupFader.NativeFieldInfoPtr__fadeRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasGroupFader>.NativeClassPtr, "_fadeRoutine");
			CanvasGroupFader.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroupFader>.NativeClassPtr, 100686405);
			CanvasGroupFader.NativeMethodInfoPtr_FadeTo_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroupFader>.NativeClassPtr, 100686406);
			CanvasGroupFader.NativeMethodInfoPtr_FadeTo_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroupFader>.NativeClassPtr, 100686407);
			CanvasGroupFader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroupFader>.NativeClassPtr, 100686408);
		}

		// Token: 0x0600AFC8 RID: 45000 RVA: 0x002E002C File Offset: 0x002DE22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299309, XrefRangeEnd = 299313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroupFader.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AFC9 RID: 45001 RVA: 0x002E0060 File Offset: 0x002DE260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299313, XrefRangeEnd = 299314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeTo(float targetAlpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetAlpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroupFader.NativeMethodInfoPtr_FadeTo_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AFCA RID: 45002 RVA: 0x002E00A0 File Offset: 0x002DE2A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299336, RefRangeEnd = 299337, XrefRangeStart = 299314, XrefRangeEnd = 299336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeTo(float targetAlpha, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetAlpha;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroupFader.NativeMethodInfoPtr_FadeTo_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AFCB RID: 45003 RVA: 0x002E00EC File Offset: 0x002DE2EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299337, XrefRangeEnd = 299338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanvasGroupFader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasGroupFader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroupFader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AFCC RID: 45004 RVA: 0x00050AED File Offset: 0x0004ECED
		public CanvasGroupFader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170034CB RID: 13515
		// (get) Token: 0x0600AFCD RID: 45005 RVA: 0x002E0128 File Offset: 0x002DE328
		// (set) Token: 0x0600AFCE RID: 45006 RVA: 0x00050AF6 File Offset: 0x0004ECF6
		public unsafe float _defaultFadeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.NativeFieldInfoPtr__defaultFadeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.NativeFieldInfoPtr__defaultFadeDuration)) = value;
			}
		}

		// Token: 0x170034CC RID: 13516
		// (get) Token: 0x0600AFCF RID: 45007 RVA: 0x002E0150 File Offset: 0x002DE350
		// (set) Token: 0x0600AFD0 RID: 45008 RVA: 0x00050B11 File Offset: 0x0004ED11
		public unsafe bool _scaleDurationWithFadeAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.NativeFieldInfoPtr__scaleDurationWithFadeAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.NativeFieldInfoPtr__scaleDurationWithFadeAmount)) = value;
			}
		}

		// Token: 0x170034CD RID: 13517
		// (get) Token: 0x0600AFD1 RID: 45009 RVA: 0x002E0178 File Offset: 0x002DE378
		// (set) Token: 0x0600AFD2 RID: 45010 RVA: 0x00050B2C File Offset: 0x0004ED2C
		public unsafe CanvasGroup _canvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.NativeFieldInfoPtr__canvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.NativeFieldInfoPtr__canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034CE RID: 13518
		// (get) Token: 0x0600AFD3 RID: 45011 RVA: 0x002E01A8 File Offset: 0x002DE3A8
		// (set) Token: 0x0600AFD4 RID: 45012 RVA: 0x00050B4B File Offset: 0x0004ED4B
		public unsafe Coroutine _fadeRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.NativeFieldInfoPtr__fadeRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.NativeFieldInfoPtr__fadeRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007933 RID: 31027
		private static readonly IntPtr NativeFieldInfoPtr__defaultFadeDuration;

		// Token: 0x04007934 RID: 31028
		private static readonly IntPtr NativeFieldInfoPtr__scaleDurationWithFadeAmount;

		// Token: 0x04007935 RID: 31029
		private static readonly IntPtr NativeFieldInfoPtr__canvasGroup;

		// Token: 0x04007936 RID: 31030
		private static readonly IntPtr NativeFieldInfoPtr__fadeRoutine;

		// Token: 0x04007937 RID: 31031
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007938 RID: 31032
		private static readonly IntPtr NativeMethodInfoPtr_FadeTo_Public_Void_Single_0;

		// Token: 0x04007939 RID: 31033
		private static readonly IntPtr NativeMethodInfoPtr_FadeTo_Public_Void_Single_Single_0;

		// Token: 0x0400793A RID: 31034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CB7 RID: 3255
		[ObfuscatedName("ScheduleOne.UI.CanvasGroupFader+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F3EC RID: 62444 RVA: 0x003AAFFC File Offset: 0x003A91FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanvasGroupFader>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0>.NativeClassPtr);
				CanvasGroupFader.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				CanvasGroupFader.__c__DisplayClass6_0.NativeFieldInfoPtr_targetAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0>.NativeClassPtr, "targetAlpha");
				CanvasGroupFader.__c__DisplayClass6_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0>.NativeClassPtr, "duration");
				CanvasGroupFader.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0>.NativeClassPtr, 100686409);
				CanvasGroupFader.__c__DisplayClass6_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0>.NativeClassPtr, 100686410);
			}

			// Token: 0x0600F3ED RID: 62445 RVA: 0x003AB08C File Offset: 0x003A928C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroupFader.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3EE RID: 62446 RVA: 0x003AB0C8 File Offset: 0x003A92C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299304, XrefRangeEnd = 299309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroupFader.__c__DisplayClass6_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F3EF RID: 62447 RVA: 0x000732F4 File Offset: 0x000714F4
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A0B RID: 18955
			// (get) Token: 0x0600F3F0 RID: 62448 RVA: 0x003AB108 File Offset: 0x003A9308
			// (set) Token: 0x0600F3F1 RID: 62449 RVA: 0x000732FD File Offset: 0x000714FD
			public unsafe CanvasGroupFader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroupFader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A0C RID: 18956
			// (get) Token: 0x0600F3F2 RID: 62450 RVA: 0x003AB138 File Offset: 0x003A9338
			// (set) Token: 0x0600F3F3 RID: 62451 RVA: 0x0007331C File Offset: 0x0007151C
			public unsafe float targetAlpha
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.__c__DisplayClass6_0.NativeFieldInfoPtr_targetAlpha);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.__c__DisplayClass6_0.NativeFieldInfoPtr_targetAlpha)) = value;
				}
			}

			// Token: 0x17004A0D RID: 18957
			// (get) Token: 0x0600F3F4 RID: 62452 RVA: 0x003AB160 File Offset: 0x003A9360
			// (set) Token: 0x0600F3F5 RID: 62453 RVA: 0x00073337 File Offset: 0x00071537
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.__c__DisplayClass6_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.__c__DisplayClass6_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x0400A532 RID: 42290
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A533 RID: 42291
			private static readonly IntPtr NativeFieldInfoPtr_targetAlpha;

			// Token: 0x0400A534 RID: 42292
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x0400A535 RID: 42293
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A536 RID: 42294
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000E05 RID: 3589
			[ObfuscatedName("ScheduleOne.UI.CanvasGroupFader+<>c__DisplayClass6_0+<<FadeTo>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601029A RID: 66202 RVA: 0x003D57A4 File Offset: 0x003D39A4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique()
				{
					Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0>.NativeClassPtr, "<<FadeTo>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr);
					CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>1__state");
					CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>2__current");
					CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>4__this");
					CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startAlpha_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<startAlpha>5__2");
					CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<i>5__3");
					CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100686411);
					CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100686412);
					CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100686413);
					CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100686414);
					CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100686415);
					CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100686416);
				}

				// Token: 0x0601029B RID: 66203 RVA: 0x003D58AC File Offset: 0x003D3AAC
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601029C RID: 66204 RVA: 0x003D58F4 File Offset: 0x003D3AF4
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601029D RID: 66205 RVA: 0x003D5928 File Offset: 0x003D3B28
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299293, XrefRangeEnd = 299299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004EF7 RID: 20215
				// (get) Token: 0x0601029E RID: 66206 RVA: 0x003D5964 File Offset: 0x003D3B64
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601029F RID: 66207 RVA: 0x003D59A4 File Offset: 0x003D3BA4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299299, XrefRangeEnd = 299304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004EF8 RID: 20216
				// (get) Token: 0x060102A0 RID: 66208 RVA: 0x003D59D8 File Offset: 0x003D3BD8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060102A1 RID: 66209 RVA: 0x0007A981 File Offset: 0x00078B81
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004EF2 RID: 20210
				// (get) Token: 0x060102A2 RID: 66210 RVA: 0x003D5A18 File Offset: 0x003D3C18
				// (set) Token: 0x060102A3 RID: 66211 RVA: 0x0007A98A File Offset: 0x00078B8A
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004EF3 RID: 20211
				// (get) Token: 0x060102A4 RID: 66212 RVA: 0x003D5A40 File Offset: 0x003D3C40
				// (set) Token: 0x060102A5 RID: 66213 RVA: 0x0007A9A5 File Offset: 0x00078BA5
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004EF4 RID: 20212
				// (get) Token: 0x060102A6 RID: 66214 RVA: 0x003D5A70 File Offset: 0x003D3C70
				// (set) Token: 0x060102A7 RID: 66215 RVA: 0x0007A9C4 File Offset: 0x00078BC4
				public unsafe CanvasGroupFader.__c__DisplayClass6_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroupFader.__c__DisplayClass6_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004EF5 RID: 20213
				// (get) Token: 0x060102A8 RID: 66216 RVA: 0x003D5AA0 File Offset: 0x003D3CA0
				// (set) Token: 0x060102A9 RID: 66217 RVA: 0x0007A9E3 File Offset: 0x00078BE3
				public unsafe float _startAlpha_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startAlpha_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startAlpha_5__2)) = value;
					}
				}

				// Token: 0x17004EF6 RID: 20214
				// (get) Token: 0x060102AA RID: 66218 RVA: 0x003D5AC8 File Offset: 0x003D3CC8
				// (set) Token: 0x060102AB RID: 66219 RVA: 0x0007A9FE File Offset: 0x00078BFE
				public unsafe float _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasGroupFader.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x0400AE14 RID: 44564
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AE15 RID: 44565
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AE16 RID: 44566
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AE17 RID: 44567
				private static readonly IntPtr NativeFieldInfoPtr__startAlpha_5__2;

				// Token: 0x0400AE18 RID: 44568
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x0400AE19 RID: 44569
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AE1A RID: 44570
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AE1B RID: 44571
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AE1C RID: 44572
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AE1D RID: 44573
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AE1E RID: 44574
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
