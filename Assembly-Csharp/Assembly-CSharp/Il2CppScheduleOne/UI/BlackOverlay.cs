using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000719 RID: 1817
	public class BlackOverlay : Singleton<BlackOverlay>
	{
		// Token: 0x0600AF36 RID: 44854 RVA: 0x002DE5AC File Offset: 0x002DC7AC
		// Note: this type is marked as 'beforefieldinit'.
		static BlackOverlay()
		{
			Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "BlackOverlay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr);
			BlackOverlay.NativeFieldInfoPtr__isShown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, "<isShown>k__BackingField");
			BlackOverlay.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, "canvas");
			BlackOverlay.NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, "group");
			BlackOverlay.NativeFieldInfoPtr_fadeRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, "fadeRoutine");
			BlackOverlay.NativeMethodInfoPtr_get_isShown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100686338);
			BlackOverlay.NativeMethodInfoPtr_set_isShown_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100686339);
			BlackOverlay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100686340);
			BlackOverlay.NativeMethodInfoPtr_Open_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100686341);
			BlackOverlay.NativeMethodInfoPtr_Close_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100686342);
			BlackOverlay.NativeMethodInfoPtr_Fade_Private_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100686343);
			BlackOverlay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, 100686344);
		}

		// Token: 0x1700349B RID: 13467
		// (get) Token: 0x0600AF37 RID: 44855 RVA: 0x002DE6B8 File Offset: 0x002DC8B8
		// (set) Token: 0x0600AF38 RID: 44856 RVA: 0x002DE6F4 File Offset: 0x002DC8F4
		public unsafe bool isShown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr_get_isShown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 33070, RefRangeEnd = 33090, XrefRangeStart = 33070, XrefRangeEnd = 33090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr_set_isShown_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600AF39 RID: 44857 RVA: 0x002DE734 File Offset: 0x002DC934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298718, XrefRangeEnd = 298724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackOverlay.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF3A RID: 44858 RVA: 0x002DE770 File Offset: 0x002DC970
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 298730, RefRangeEnd = 298735, XrefRangeStart = 298724, XrefRangeEnd = 298730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(float fadeTime = 0.5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr_Open_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF3B RID: 44859 RVA: 0x002DE7B0 File Offset: 0x002DC9B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 298739, RefRangeEnd = 298746, XrefRangeStart = 298735, XrefRangeEnd = 298739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(float fadeTime = 0.5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr_Close_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF3C RID: 44860 RVA: 0x002DE7F0 File Offset: 0x002DC9F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298751, RefRangeEnd = 298753, XrefRangeStart = 298746, XrefRangeEnd = 298751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Fade(float endOpacity, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endOpacity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr_Fade_Private_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600AF3D RID: 44861 RVA: 0x002DE84C File Offset: 0x002DCA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298753, XrefRangeEnd = 298756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlackOverlay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF3E RID: 44862 RVA: 0x0005053D File Offset: 0x0004E73D
		public BlackOverlay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003497 RID: 13463
		// (get) Token: 0x0600AF3F RID: 44863 RVA: 0x002DE888 File Offset: 0x002DCA88
		// (set) Token: 0x0600AF40 RID: 44864 RVA: 0x00050546 File Offset: 0x0004E746
		public unsafe bool _isShown_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr__isShown_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr__isShown_k__BackingField)) = value;
			}
		}

		// Token: 0x17003498 RID: 13464
		// (get) Token: 0x0600AF41 RID: 44865 RVA: 0x002DE8B0 File Offset: 0x002DCAB0
		// (set) Token: 0x0600AF42 RID: 44866 RVA: 0x00050561 File Offset: 0x0004E761
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003499 RID: 13465
		// (get) Token: 0x0600AF43 RID: 44867 RVA: 0x002DE8E0 File Offset: 0x002DCAE0
		// (set) Token: 0x0600AF44 RID: 44868 RVA: 0x00050580 File Offset: 0x0004E780
		public unsafe CanvasGroup group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700349A RID: 13466
		// (get) Token: 0x0600AF45 RID: 44869 RVA: 0x002DE910 File Offset: 0x002DCB10
		// (set) Token: 0x0600AF46 RID: 44870 RVA: 0x0005059F File Offset: 0x0004E79F
		public unsafe Coroutine fadeRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_fadeRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay.NativeFieldInfoPtr_fadeRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040078DC RID: 30940
		private static readonly IntPtr NativeFieldInfoPtr__isShown_k__BackingField;

		// Token: 0x040078DD RID: 30941
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x040078DE RID: 30942
		private static readonly IntPtr NativeFieldInfoPtr_group;

		// Token: 0x040078DF RID: 30943
		private static readonly IntPtr NativeFieldInfoPtr_fadeRoutine;

		// Token: 0x040078E0 RID: 30944
		private static readonly IntPtr NativeMethodInfoPtr_get_isShown_Public_get_Boolean_0;

		// Token: 0x040078E1 RID: 30945
		private static readonly IntPtr NativeMethodInfoPtr_set_isShown_Protected_set_Void_Boolean_0;

		// Token: 0x040078E2 RID: 30946
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040078E3 RID: 30947
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_Single_0;

		// Token: 0x040078E4 RID: 30948
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Single_0;

		// Token: 0x040078E5 RID: 30949
		private static readonly IntPtr NativeMethodInfoPtr_Fade_Private_IEnumerator_Single_Single_0;

		// Token: 0x040078E6 RID: 30950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CB3 RID: 3251
		[ObfuscatedName("ScheduleOne.UI.BlackOverlay+<Fade>d__10")]
		public sealed class _Fade_d__10 : Il2CppSystem.Object
		{
			// Token: 0x0600F3BA RID: 62394 RVA: 0x003AA704 File Offset: 0x003A8904
			// Note: this type is marked as 'beforefieldinit'.
			static _Fade_d__10()
			{
				Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackOverlay>.NativeClassPtr, "<Fade>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr);
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "<>1__state");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "<>2__current");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "<>4__this");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr_endOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "endOpacity");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr_fadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "fadeTime");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr__start_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "<start>5__2");
				BlackOverlay._Fade_d__10.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, "<i>5__3");
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100686345);
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100686346);
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100686347);
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100686348);
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100686349);
				BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr, 100686350);
			}

			// Token: 0x0600F3BB RID: 62395 RVA: 0x003AA834 File Offset: 0x003A8A34
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Fade_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackOverlay._Fade_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3BC RID: 62396 RVA: 0x003AA87C File Offset: 0x003A8A7C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3BD RID: 62397 RVA: 0x003AA8B0 File Offset: 0x003A8AB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298703, XrefRangeEnd = 298713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004A03 RID: 18947
			// (get) Token: 0x0600F3BE RID: 62398 RVA: 0x003AA8EC File Offset: 0x003A8AEC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F3BF RID: 62399 RVA: 0x003AA92C File Offset: 0x003A8B2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298713, XrefRangeEnd = 298718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004A04 RID: 18948
			// (get) Token: 0x0600F3C0 RID: 62400 RVA: 0x003AA960 File Offset: 0x003A8B60
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackOverlay._Fade_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F3C1 RID: 62401 RVA: 0x00073159 File Offset: 0x00071359
			public _Fade_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049FC RID: 18940
			// (get) Token: 0x0600F3C2 RID: 62402 RVA: 0x003AA9A0 File Offset: 0x003A8BA0
			// (set) Token: 0x0600F3C3 RID: 62403 RVA: 0x00073162 File Offset: 0x00071362
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170049FD RID: 18941
			// (get) Token: 0x0600F3C4 RID: 62404 RVA: 0x003AA9C8 File Offset: 0x003A8BC8
			// (set) Token: 0x0600F3C5 RID: 62405 RVA: 0x0007317D File Offset: 0x0007137D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049FE RID: 18942
			// (get) Token: 0x0600F3C6 RID: 62406 RVA: 0x003AA9F8 File Offset: 0x003A8BF8
			// (set) Token: 0x0600F3C7 RID: 62407 RVA: 0x0007319C File Offset: 0x0007139C
			public unsafe BlackOverlay __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackOverlay>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049FF RID: 18943
			// (get) Token: 0x0600F3C8 RID: 62408 RVA: 0x003AAA28 File Offset: 0x003A8C28
			// (set) Token: 0x0600F3C9 RID: 62409 RVA: 0x000731BB File Offset: 0x000713BB
			public unsafe float endOpacity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr_endOpacity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr_endOpacity)) = value;
				}
			}

			// Token: 0x17004A00 RID: 18944
			// (get) Token: 0x0600F3CA RID: 62410 RVA: 0x003AAA50 File Offset: 0x003A8C50
			// (set) Token: 0x0600F3CB RID: 62411 RVA: 0x000731D6 File Offset: 0x000713D6
			public unsafe float fadeTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr_fadeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr_fadeTime)) = value;
				}
			}

			// Token: 0x17004A01 RID: 18945
			// (get) Token: 0x0600F3CC RID: 62412 RVA: 0x003AAA78 File Offset: 0x003A8C78
			// (set) Token: 0x0600F3CD RID: 62413 RVA: 0x000731F1 File Offset: 0x000713F1
			public unsafe float _start_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr__start_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr__start_5__2)) = value;
				}
			}

			// Token: 0x17004A02 RID: 18946
			// (get) Token: 0x0600F3CE RID: 62414 RVA: 0x003AAAA0 File Offset: 0x003A8CA0
			// (set) Token: 0x0600F3CF RID: 62415 RVA: 0x0007320C File Offset: 0x0007140C
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackOverlay._Fade_d__10.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x0400A515 RID: 42261
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A516 RID: 42262
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A517 RID: 42263
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A518 RID: 42264
			private static readonly IntPtr NativeFieldInfoPtr_endOpacity;

			// Token: 0x0400A519 RID: 42265
			private static readonly IntPtr NativeFieldInfoPtr_fadeTime;

			// Token: 0x0400A51A RID: 42266
			private static readonly IntPtr NativeFieldInfoPtr__start_5__2;

			// Token: 0x0400A51B RID: 42267
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400A51C RID: 42268
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A51D RID: 42269
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A51E RID: 42270
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A51F RID: 42271
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A520 RID: 42272
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A521 RID: 42273
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
