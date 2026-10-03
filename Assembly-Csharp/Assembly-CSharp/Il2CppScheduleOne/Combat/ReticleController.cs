using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x020006F8 RID: 1784
	public class ReticleController : MonoBehaviour
	{
		// Token: 0x0600ABE3 RID: 44003 RVA: 0x002D3FD8 File Offset: 0x002D21D8
		// Note: this type is marked as 'beforefieldinit'.
		static ReticleController()
		{
			Il2CppClassPointerStore<ReticleController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "ReticleController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReticleController>.NativeClassPtr);
			ReticleController.NativeFieldInfoPtr__reticleUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleController>.NativeClassPtr, "_reticleUI");
			ReticleController.NativeFieldInfoPtr__fadeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleController>.NativeClassPtr, "_fadeDuration");
			ReticleController.NativeFieldInfoPtr__isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleController>.NativeClassPtr, "_isActive");
			ReticleController.NativeFieldInfoPtr__fadeCo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleController>.NativeClassPtr, "_fadeCo");
			ReticleController.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleController>.NativeClassPtr, 100685987);
			ReticleController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleController>.NativeClassPtr, 100685988);
			ReticleController.NativeMethodInfoPtr_ShowReticle_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleController>.NativeClassPtr, 100685989);
			ReticleController.NativeMethodInfoPtr_HideReticle_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleController>.NativeClassPtr, 100685990);
			ReticleController.NativeMethodInfoPtr_SetReticle_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleController>.NativeClassPtr, 100685991);
			ReticleController.NativeMethodInfoPtr_DoRecticleFade_Private_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleController>.NativeClassPtr, 100685992);
			ReticleController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleController>.NativeClassPtr, 100685993);
		}

		// Token: 0x17003385 RID: 13189
		// (get) Token: 0x0600ABE4 RID: 44004 RVA: 0x002D40E4 File Offset: 0x002D22E4
		public unsafe bool IsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleController.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600ABE5 RID: 44005 RVA: 0x002D4120 File Offset: 0x002D2320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295164, XrefRangeEnd = 295165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABE6 RID: 44006 RVA: 0x002D4154 File Offset: 0x002D2354
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295176, RefRangeEnd = 295177, XrefRangeStart = 295165, XrefRangeEnd = 295176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowReticle(float duration = -1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleController.NativeMethodInfoPtr_ShowReticle_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABE7 RID: 44007 RVA: 0x002D4194 File Offset: 0x002D2394
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295188, RefRangeEnd = 295189, XrefRangeStart = 295177, XrefRangeEnd = 295188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideReticle(float duration = -1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleController.NativeMethodInfoPtr_HideReticle_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABE8 RID: 44008 RVA: 0x002D41D4 File Offset: 0x002D23D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295190, RefRangeEnd = 295191, XrefRangeStart = 295189, XrefRangeEnd = 295190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReticle(float spreadAngle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref spreadAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleController.NativeMethodInfoPtr_SetReticle_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABE9 RID: 44009 RVA: 0x002D4214 File Offset: 0x002D2414
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295196, RefRangeEnd = 295198, XrefRangeStart = 295191, XrefRangeEnd = 295196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoRecticleFade(float endAlpha, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endAlpha;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleController.NativeMethodInfoPtr_DoRecticleFade_Private_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600ABEA RID: 44010 RVA: 0x002D4270 File Offset: 0x002D2470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295198, XrefRangeEnd = 295199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReticleController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReticleController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ABEB RID: 44011 RVA: 0x0004E96D File Offset: 0x0004CB6D
		public ReticleController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003381 RID: 13185
		// (get) Token: 0x0600ABEC RID: 44012 RVA: 0x002D42AC File Offset: 0x002D24AC
		// (set) Token: 0x0600ABED RID: 44013 RVA: 0x0004E976 File Offset: 0x0004CB76
		public unsafe ReticleUI _reticleUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleController.NativeFieldInfoPtr__reticleUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReticleUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleController.NativeFieldInfoPtr__reticleUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003382 RID: 13186
		// (get) Token: 0x0600ABEE RID: 44014 RVA: 0x002D42DC File Offset: 0x002D24DC
		// (set) Token: 0x0600ABEF RID: 44015 RVA: 0x0004E995 File Offset: 0x0004CB95
		public unsafe float _fadeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleController.NativeFieldInfoPtr__fadeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleController.NativeFieldInfoPtr__fadeDuration)) = value;
			}
		}

		// Token: 0x17003383 RID: 13187
		// (get) Token: 0x0600ABF0 RID: 44016 RVA: 0x002D4304 File Offset: 0x002D2504
		// (set) Token: 0x0600ABF1 RID: 44017 RVA: 0x0004E9B0 File Offset: 0x0004CBB0
		public unsafe bool _isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleController.NativeFieldInfoPtr__isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleController.NativeFieldInfoPtr__isActive)) = value;
			}
		}

		// Token: 0x17003384 RID: 13188
		// (get) Token: 0x0600ABF2 RID: 44018 RVA: 0x002D432C File Offset: 0x002D252C
		// (set) Token: 0x0600ABF3 RID: 44019 RVA: 0x0004E9CB File Offset: 0x0004CBCB
		public unsafe Coroutine _fadeCo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleController.NativeFieldInfoPtr__fadeCo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleController.NativeFieldInfoPtr__fadeCo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040076A2 RID: 30370
		private static readonly IntPtr NativeFieldInfoPtr__reticleUI;

		// Token: 0x040076A3 RID: 30371
		private static readonly IntPtr NativeFieldInfoPtr__fadeDuration;

		// Token: 0x040076A4 RID: 30372
		private static readonly IntPtr NativeFieldInfoPtr__isActive;

		// Token: 0x040076A5 RID: 30373
		private static readonly IntPtr NativeFieldInfoPtr__fadeCo;

		// Token: 0x040076A6 RID: 30374
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

		// Token: 0x040076A7 RID: 30375
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040076A8 RID: 30376
		private static readonly IntPtr NativeMethodInfoPtr_ShowReticle_Public_Void_Single_0;

		// Token: 0x040076A9 RID: 30377
		private static readonly IntPtr NativeMethodInfoPtr_HideReticle_Public_Void_Single_0;

		// Token: 0x040076AA RID: 30378
		private static readonly IntPtr NativeMethodInfoPtr_SetReticle_Public_Void_Single_0;

		// Token: 0x040076AB RID: 30379
		private static readonly IntPtr NativeMethodInfoPtr_DoRecticleFade_Private_IEnumerator_Single_Single_0;

		// Token: 0x040076AC RID: 30380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CA8 RID: 3240
		[ObfuscatedName("ScheduleOne.Combat.ReticleController+<DoRecticleFade>d__10")]
		public sealed class _DoRecticleFade_d__10 : Il2CppSystem.Object
		{
			// Token: 0x0600F32B RID: 62251 RVA: 0x003A8D80 File Offset: 0x003A6F80
			// Note: this type is marked as 'beforefieldinit'.
			static _DoRecticleFade_d__10()
			{
				Il2CppClassPointerStore<ReticleController._DoRecticleFade_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReticleController>.NativeClassPtr, "<DoRecticleFade>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReticleController._DoRecticleFade_d__10>.NativeClassPtr);
				ReticleController._DoRecticleFade_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleController._DoRecticleFade_d__10>.NativeClassPtr, "<>1__state");
				ReticleController._DoRecticleFade_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleController._DoRecticleFade_d__10>.NativeClassPtr, "<>2__current");
				ReticleController._DoRecticleFade_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleController._DoRecticleFade_d__10>.NativeClassPtr, "<>4__this");
				ReticleController._DoRecticleFade_d__10.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleController._DoRecticleFade_d__10>.NativeClassPtr, "duration");
				ReticleController._DoRecticleFade_d__10.NativeFieldInfoPtr_endAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleController._DoRecticleFade_d__10>.NativeClassPtr, "endAlpha");
				ReticleController._DoRecticleFade_d__10.NativeFieldInfoPtr__startAlpha_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleController._DoRecticleFade_d__10>.NativeClassPtr, "<startAlpha>5__2");
				ReticleController._DoRecticleFade_d__10.NativeFieldInfoPtr__elapsed_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReticleController._DoRecticleFade_d__10>.NativeClassPtr, "<elapsed>5__3");
				ReticleController._DoRecticleFade_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleController._DoRecticleFade_d__10>.NativeClassPtr, 100685994);
				ReticleController._DoRecticleFade_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleController._DoRecticleFade_d__10>.NativeClassPtr, 100685995);
				ReticleController._DoRecticleFade_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleController._DoRecticleFade_d__10>.NativeClassPtr, 100685996);
				ReticleController._DoRecticleFade_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleController._DoRecticleFade_d__10>.NativeClassPtr, 100685997);
				ReticleController._DoRecticleFade_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleController._DoRecticleFade_d__10>.NativeClassPtr, 100685998);
				ReticleController._DoRecticleFade_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReticleController._DoRecticleFade_d__10>.NativeClassPtr, 100685999);
			}

			// Token: 0x0600F32C RID: 62252 RVA: 0x003A8EB0 File Offset: 0x003A70B0
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoRecticleFade_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReticleController._DoRecticleFade_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleController._DoRecticleFade_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F32D RID: 62253 RVA: 0x003A8EF8 File Offset: 0x003A70F8
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleController._DoRecticleFade_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F32E RID: 62254 RVA: 0x003A8F2C File Offset: 0x003A712C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295152, XrefRangeEnd = 295159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleController._DoRecticleFade_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170049CF RID: 18895
			// (get) Token: 0x0600F32F RID: 62255 RVA: 0x003A8F68 File Offset: 0x003A7168
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleController._DoRecticleFade_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F330 RID: 62256 RVA: 0x003A8FA8 File Offset: 0x003A71A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295159, XrefRangeEnd = 295164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleController._DoRecticleFade_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170049D0 RID: 18896
			// (get) Token: 0x0600F331 RID: 62257 RVA: 0x003A8FDC File Offset: 0x003A71DC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReticleController._DoRecticleFade_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F332 RID: 62258 RVA: 0x00072C39 File Offset: 0x00070E39
			public _DoRecticleFade_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049C8 RID: 18888
			// (get) Token: 0x0600F333 RID: 62259 RVA: 0x003A901C File Offset: 0x003A721C
			// (set) Token: 0x0600F334 RID: 62260 RVA: 0x00072C42 File Offset: 0x00070E42
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleController._DoRecticleFade_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleController._DoRecticleFade_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170049C9 RID: 18889
			// (get) Token: 0x0600F335 RID: 62261 RVA: 0x003A9044 File Offset: 0x003A7244
			// (set) Token: 0x0600F336 RID: 62262 RVA: 0x00072C5D File Offset: 0x00070E5D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleController._DoRecticleFade_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleController._DoRecticleFade_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049CA RID: 18890
			// (get) Token: 0x0600F337 RID: 62263 RVA: 0x003A9074 File Offset: 0x003A7274
			// (set) Token: 0x0600F338 RID: 62264 RVA: 0x00072C7C File Offset: 0x00070E7C
			public unsafe ReticleController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleController._DoRecticleFade_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReticleController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleController._DoRecticleFade_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049CB RID: 18891
			// (get) Token: 0x0600F339 RID: 62265 RVA: 0x003A90A4 File Offset: 0x003A72A4
			// (set) Token: 0x0600F33A RID: 62266 RVA: 0x00072C9B File Offset: 0x00070E9B
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleController._DoRecticleFade_d__10.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleController._DoRecticleFade_d__10.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x170049CC RID: 18892
			// (get) Token: 0x0600F33B RID: 62267 RVA: 0x003A90CC File Offset: 0x003A72CC
			// (set) Token: 0x0600F33C RID: 62268 RVA: 0x00072CB6 File Offset: 0x00070EB6
			public unsafe float endAlpha
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleController._DoRecticleFade_d__10.NativeFieldInfoPtr_endAlpha);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleController._DoRecticleFade_d__10.NativeFieldInfoPtr_endAlpha)) = value;
				}
			}

			// Token: 0x170049CD RID: 18893
			// (get) Token: 0x0600F33D RID: 62269 RVA: 0x003A90F4 File Offset: 0x003A72F4
			// (set) Token: 0x0600F33E RID: 62270 RVA: 0x00072CD1 File Offset: 0x00070ED1
			public unsafe float _startAlpha_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleController._DoRecticleFade_d__10.NativeFieldInfoPtr__startAlpha_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleController._DoRecticleFade_d__10.NativeFieldInfoPtr__startAlpha_5__2)) = value;
				}
			}

			// Token: 0x170049CE RID: 18894
			// (get) Token: 0x0600F33F RID: 62271 RVA: 0x003A911C File Offset: 0x003A731C
			// (set) Token: 0x0600F340 RID: 62272 RVA: 0x00072CEC File Offset: 0x00070EEC
			public unsafe float _elapsed_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleController._DoRecticleFade_d__10.NativeFieldInfoPtr__elapsed_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReticleController._DoRecticleFade_d__10.NativeFieldInfoPtr__elapsed_5__3)) = value;
				}
			}

			// Token: 0x0400A4BB RID: 42171
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A4BC RID: 42172
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A4BD RID: 42173
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A4BE RID: 42174
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x0400A4BF RID: 42175
			private static readonly IntPtr NativeFieldInfoPtr_endAlpha;

			// Token: 0x0400A4C0 RID: 42176
			private static readonly IntPtr NativeFieldInfoPtr__startAlpha_5__2;

			// Token: 0x0400A4C1 RID: 42177
			private static readonly IntPtr NativeFieldInfoPtr__elapsed_5__3;

			// Token: 0x0400A4C2 RID: 42178
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A4C3 RID: 42179
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A4C4 RID: 42180
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A4C5 RID: 42181
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A4C6 RID: 42182
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A4C7 RID: 42183
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
