using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x02000485 RID: 1157
	public class StartLoopStopAudio : MonoBehaviour
	{
		// Token: 0x0600681D RID: 26653 RVA: 0x001E3270 File Offset: 0x001E1470
		// Note: this type is marked as 'beforefieldinit'.
		static StartLoopStopAudio()
		{
			Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "StartLoopStopAudio");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr);
			StartLoopStopAudio.NativeFieldInfoPtr__fadeLoopIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "_fadeLoopIn");
			StartLoopStopAudio.NativeFieldInfoPtr__fadeLoopOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "_fadeLoopOut");
			StartLoopStopAudio.NativeFieldInfoPtr__startSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "_startSound");
			StartLoopStopAudio.NativeFieldInfoPtr__loopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "_loopSound");
			StartLoopStopAudio.NativeFieldInfoPtr__stopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "_stopSound");
			StartLoopStopAudio.NativeFieldInfoPtr__audioRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "_audioRoutine");
			StartLoopStopAudio.NativeFieldInfoPtr__isRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "_isRunning");
			StartLoopStopAudio.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100676904);
			StartLoopStopAudio.NativeMethodInfoPtr_StartAudio_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100676905);
			StartLoopStopAudio.NativeMethodInfoPtr_StopAudio_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100676906);
			StartLoopStopAudio.NativeMethodInfoPtr_StartAudioRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100676907);
			StartLoopStopAudio.NativeMethodInfoPtr_StopAudioRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100676908);
			StartLoopStopAudio.NativeMethodInfoPtr_TryStartAudio_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100676909);
			StartLoopStopAudio.NativeMethodInfoPtr_TryStopAudio_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100676910);
			StartLoopStopAudio.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100676911);
		}

		// Token: 0x0600681E RID: 26654 RVA: 0x001E33CC File Offset: 0x001E15CC
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600681F RID: 26655 RVA: 0x001E3400 File Offset: 0x001E1600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215850, RefRangeEnd = 215851, XrefRangeStart = 215849, XrefRangeEnd = 215850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartAudio()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr_StartAudio_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006820 RID: 26656 RVA: 0x001E3434 File Offset: 0x001E1634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215852, RefRangeEnd = 215853, XrefRangeStart = 215851, XrefRangeEnd = 215852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAudio()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr_StopAudio_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006821 RID: 26657 RVA: 0x001E3468 File Offset: 0x001E1668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215853, XrefRangeEnd = 215858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator StartAudioRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr_StartAudioRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006822 RID: 26658 RVA: 0x001E34A8 File Offset: 0x001E16A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215858, XrefRangeEnd = 215863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator StopAudioRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr_StopAudioRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006823 RID: 26659 RVA: 0x001E34E8 File Offset: 0x001E16E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215881, RefRangeEnd = 215882, XrefRangeStart = 215863, XrefRangeEnd = 215881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryStartAudio()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr_TryStartAudio_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006824 RID: 26660 RVA: 0x001E351C File Offset: 0x001E171C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215900, RefRangeEnd = 215901, XrefRangeStart = 215882, XrefRangeEnd = 215900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryStopAudio()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr_TryStopAudio_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006825 RID: 26661 RVA: 0x001E3550 File Offset: 0x001E1750
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartLoopStopAudio() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006826 RID: 26662 RVA: 0x000310BD File Offset: 0x0002F2BD
		public StartLoopStopAudio(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FDA RID: 8154
		// (get) Token: 0x06006827 RID: 26663 RVA: 0x001E358C File Offset: 0x001E178C
		// (set) Token: 0x06006828 RID: 26664 RVA: 0x000310C6 File Offset: 0x0002F2C6
		public unsafe bool _fadeLoopIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr__fadeLoopIn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr__fadeLoopIn)) = value;
			}
		}

		// Token: 0x17001FDB RID: 8155
		// (get) Token: 0x06006829 RID: 26665 RVA: 0x001E35B4 File Offset: 0x001E17B4
		// (set) Token: 0x0600682A RID: 26666 RVA: 0x000310E1 File Offset: 0x0002F2E1
		public unsafe bool _fadeLoopOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr__fadeLoopOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr__fadeLoopOut)) = value;
			}
		}

		// Token: 0x17001FDC RID: 8156
		// (get) Token: 0x0600682B RID: 26667 RVA: 0x001E35DC File Offset: 0x001E17DC
		// (set) Token: 0x0600682C RID: 26668 RVA: 0x000310FC File Offset: 0x0002F2FC
		public unsafe AudioSourceController _startSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr__startSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr__startSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FDD RID: 8157
		// (get) Token: 0x0600682D RID: 26669 RVA: 0x001E360C File Offset: 0x001E180C
		// (set) Token: 0x0600682E RID: 26670 RVA: 0x0003111B File Offset: 0x0002F31B
		public unsafe AudioSourceController _loopSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr__loopSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr__loopSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FDE RID: 8158
		// (get) Token: 0x0600682F RID: 26671 RVA: 0x001E363C File Offset: 0x001E183C
		// (set) Token: 0x06006830 RID: 26672 RVA: 0x0003113A File Offset: 0x0002F33A
		public unsafe AudioSourceController _stopSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr__stopSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr__stopSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FDF RID: 8159
		// (get) Token: 0x06006831 RID: 26673 RVA: 0x001E366C File Offset: 0x001E186C
		// (set) Token: 0x06006832 RID: 26674 RVA: 0x00031159 File Offset: 0x0002F359
		public unsafe Coroutine _audioRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr__audioRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr__audioRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE0 RID: 8160
		// (get) Token: 0x06006833 RID: 26675 RVA: 0x001E369C File Offset: 0x001E189C
		// (set) Token: 0x06006834 RID: 26676 RVA: 0x00031178 File Offset: 0x0002F378
		public unsafe bool _isRunning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr__isRunning);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr__isRunning)) = value;
			}
		}

		// Token: 0x04004799 RID: 18329
		private static readonly IntPtr NativeFieldInfoPtr__fadeLoopIn;

		// Token: 0x0400479A RID: 18330
		private static readonly IntPtr NativeFieldInfoPtr__fadeLoopOut;

		// Token: 0x0400479B RID: 18331
		private static readonly IntPtr NativeFieldInfoPtr__startSound;

		// Token: 0x0400479C RID: 18332
		private static readonly IntPtr NativeFieldInfoPtr__loopSound;

		// Token: 0x0400479D RID: 18333
		private static readonly IntPtr NativeFieldInfoPtr__stopSound;

		// Token: 0x0400479E RID: 18334
		private static readonly IntPtr NativeFieldInfoPtr__audioRoutine;

		// Token: 0x0400479F RID: 18335
		private static readonly IntPtr NativeFieldInfoPtr__isRunning;

		// Token: 0x040047A0 RID: 18336
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040047A1 RID: 18337
		private static readonly IntPtr NativeMethodInfoPtr_StartAudio_Public_Void_0;

		// Token: 0x040047A2 RID: 18338
		private static readonly IntPtr NativeMethodInfoPtr_StopAudio_Public_Void_0;

		// Token: 0x040047A3 RID: 18339
		private static readonly IntPtr NativeMethodInfoPtr_StartAudioRoutine_Private_IEnumerator_0;

		// Token: 0x040047A4 RID: 18340
		private static readonly IntPtr NativeMethodInfoPtr_StopAudioRoutine_Private_IEnumerator_0;

		// Token: 0x040047A5 RID: 18341
		private static readonly IntPtr NativeMethodInfoPtr_TryStartAudio_Private_Void_0;

		// Token: 0x040047A6 RID: 18342
		private static readonly IntPtr NativeMethodInfoPtr_TryStopAudio_Private_Void_0;

		// Token: 0x040047A7 RID: 18343
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B51 RID: 2897
		[ObfuscatedName("ScheduleOne.Audio.StartLoopStopAudio+<StartAudioRoutine>d__10")]
		public sealed class _StartAudioRoutine_d__10 : Il2CppSystem.Object
		{
			// Token: 0x0600E779 RID: 59257 RVA: 0x00386C08 File Offset: 0x00384E08
			// Note: this type is marked as 'beforefieldinit'.
			static _StartAudioRoutine_d__10()
			{
				Il2CppClassPointerStore<StartLoopStopAudio._StartAudioRoutine_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "<StartAudioRoutine>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartLoopStopAudio._StartAudioRoutine_d__10>.NativeClassPtr);
				StartLoopStopAudio._StartAudioRoutine_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio._StartAudioRoutine_d__10>.NativeClassPtr, "<>1__state");
				StartLoopStopAudio._StartAudioRoutine_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio._StartAudioRoutine_d__10>.NativeClassPtr, "<>2__current");
				StartLoopStopAudio._StartAudioRoutine_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio._StartAudioRoutine_d__10>.NativeClassPtr, "<>4__this");
				StartLoopStopAudio._StartAudioRoutine_d__10.NativeFieldInfoPtr__timer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio._StartAudioRoutine_d__10>.NativeClassPtr, "<timer>5__2");
				StartLoopStopAudio._StartAudioRoutine_d__10.NativeFieldInfoPtr__duration_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio._StartAudioRoutine_d__10>.NativeClassPtr, "<duration>5__3");
				StartLoopStopAudio._StartAudioRoutine_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio._StartAudioRoutine_d__10>.NativeClassPtr, 100676912);
				StartLoopStopAudio._StartAudioRoutine_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio._StartAudioRoutine_d__10>.NativeClassPtr, 100676913);
				StartLoopStopAudio._StartAudioRoutine_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio._StartAudioRoutine_d__10>.NativeClassPtr, 100676914);
				StartLoopStopAudio._StartAudioRoutine_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio._StartAudioRoutine_d__10>.NativeClassPtr, 100676915);
				StartLoopStopAudio._StartAudioRoutine_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio._StartAudioRoutine_d__10>.NativeClassPtr, 100676916);
				StartLoopStopAudio._StartAudioRoutine_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio._StartAudioRoutine_d__10>.NativeClassPtr, 100676917);
			}

			// Token: 0x0600E77A RID: 59258 RVA: 0x00386D10 File Offset: 0x00384F10
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _StartAudioRoutine_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartLoopStopAudio._StartAudioRoutine_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio._StartAudioRoutine_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E77B RID: 59259 RVA: 0x00386D58 File Offset: 0x00384F58
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio._StartAudioRoutine_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E77C RID: 59260 RVA: 0x00386D8C File Offset: 0x00384F8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215831, XrefRangeEnd = 215834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio._StartAudioRoutine_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004641 RID: 17985
			// (get) Token: 0x0600E77D RID: 59261 RVA: 0x00386DC8 File Offset: 0x00384FC8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio._StartAudioRoutine_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E77E RID: 59262 RVA: 0x00386E08 File Offset: 0x00385008
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215834, XrefRangeEnd = 215839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio._StartAudioRoutine_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004642 RID: 17986
			// (get) Token: 0x0600E77F RID: 59263 RVA: 0x00386E3C File Offset: 0x0038503C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio._StartAudioRoutine_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E780 RID: 59264 RVA: 0x0006D2BD File Offset: 0x0006B4BD
			public _StartAudioRoutine_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700463C RID: 17980
			// (get) Token: 0x0600E781 RID: 59265 RVA: 0x00386E7C File Offset: 0x0038507C
			// (set) Token: 0x0600E782 RID: 59266 RVA: 0x0006D2C6 File Offset: 0x0006B4C6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio._StartAudioRoutine_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio._StartAudioRoutine_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700463D RID: 17981
			// (get) Token: 0x0600E783 RID: 59267 RVA: 0x00386EA4 File Offset: 0x003850A4
			// (set) Token: 0x0600E784 RID: 59268 RVA: 0x0006D2E1 File Offset: 0x0006B4E1
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio._StartAudioRoutine_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio._StartAudioRoutine_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700463E RID: 17982
			// (get) Token: 0x0600E785 RID: 59269 RVA: 0x00386ED4 File Offset: 0x003850D4
			// (set) Token: 0x0600E786 RID: 59270 RVA: 0x0006D300 File Offset: 0x0006B500
			public unsafe StartLoopStopAudio __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio._StartAudioRoutine_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartLoopStopAudio>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio._StartAudioRoutine_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700463F RID: 17983
			// (get) Token: 0x0600E787 RID: 59271 RVA: 0x00386F04 File Offset: 0x00385104
			// (set) Token: 0x0600E788 RID: 59272 RVA: 0x0006D31F File Offset: 0x0006B51F
			public unsafe float _timer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio._StartAudioRoutine_d__10.NativeFieldInfoPtr__timer_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio._StartAudioRoutine_d__10.NativeFieldInfoPtr__timer_5__2)) = value;
				}
			}

			// Token: 0x17004640 RID: 17984
			// (get) Token: 0x0600E789 RID: 59273 RVA: 0x00386F2C File Offset: 0x0038512C
			// (set) Token: 0x0600E78A RID: 59274 RVA: 0x0006D33A File Offset: 0x0006B53A
			public unsafe float _duration_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio._StartAudioRoutine_d__10.NativeFieldInfoPtr__duration_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio._StartAudioRoutine_d__10.NativeFieldInfoPtr__duration_5__3)) = value;
				}
			}

			// Token: 0x04009D1C RID: 40220
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009D1D RID: 40221
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009D1E RID: 40222
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009D1F RID: 40223
			private static readonly IntPtr NativeFieldInfoPtr__timer_5__2;

			// Token: 0x04009D20 RID: 40224
			private static readonly IntPtr NativeFieldInfoPtr__duration_5__3;

			// Token: 0x04009D21 RID: 40225
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009D22 RID: 40226
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009D23 RID: 40227
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009D24 RID: 40228
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009D25 RID: 40229
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009D26 RID: 40230
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B52 RID: 2898
		[ObfuscatedName("ScheduleOne.Audio.StartLoopStopAudio+<StopAudioRoutine>d__11")]
		public sealed class _StopAudioRoutine_d__11 : Il2CppSystem.Object
		{
			// Token: 0x0600E78B RID: 59275 RVA: 0x00386F54 File Offset: 0x00385154
			// Note: this type is marked as 'beforefieldinit'.
			static _StopAudioRoutine_d__11()
			{
				Il2CppClassPointerStore<StartLoopStopAudio._StopAudioRoutine_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "<StopAudioRoutine>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartLoopStopAudio._StopAudioRoutine_d__11>.NativeClassPtr);
				StartLoopStopAudio._StopAudioRoutine_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio._StopAudioRoutine_d__11>.NativeClassPtr, "<>1__state");
				StartLoopStopAudio._StopAudioRoutine_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio._StopAudioRoutine_d__11>.NativeClassPtr, "<>2__current");
				StartLoopStopAudio._StopAudioRoutine_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio._StopAudioRoutine_d__11>.NativeClassPtr, "<>4__this");
				StartLoopStopAudio._StopAudioRoutine_d__11.NativeFieldInfoPtr__timer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio._StopAudioRoutine_d__11>.NativeClassPtr, "<timer>5__2");
				StartLoopStopAudio._StopAudioRoutine_d__11.NativeFieldInfoPtr__duration_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio._StopAudioRoutine_d__11>.NativeClassPtr, "<duration>5__3");
				StartLoopStopAudio._StopAudioRoutine_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio._StopAudioRoutine_d__11>.NativeClassPtr, 100676918);
				StartLoopStopAudio._StopAudioRoutine_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio._StopAudioRoutine_d__11>.NativeClassPtr, 100676919);
				StartLoopStopAudio._StopAudioRoutine_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio._StopAudioRoutine_d__11>.NativeClassPtr, 100676920);
				StartLoopStopAudio._StopAudioRoutine_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio._StopAudioRoutine_d__11>.NativeClassPtr, 100676921);
				StartLoopStopAudio._StopAudioRoutine_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio._StopAudioRoutine_d__11>.NativeClassPtr, 100676922);
				StartLoopStopAudio._StopAudioRoutine_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio._StopAudioRoutine_d__11>.NativeClassPtr, 100676923);
			}

			// Token: 0x0600E78C RID: 59276 RVA: 0x0038705C File Offset: 0x0038525C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _StopAudioRoutine_d__11(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartLoopStopAudio._StopAudioRoutine_d__11>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio._StopAudioRoutine_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E78D RID: 59277 RVA: 0x003870A4 File Offset: 0x003852A4
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio._StopAudioRoutine_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E78E RID: 59278 RVA: 0x003870D8 File Offset: 0x003852D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215839, XrefRangeEnd = 215844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio._StopAudioRoutine_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004648 RID: 17992
			// (get) Token: 0x0600E78F RID: 59279 RVA: 0x00387114 File Offset: 0x00385314
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio._StopAudioRoutine_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E790 RID: 59280 RVA: 0x00387154 File Offset: 0x00385354
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215844, XrefRangeEnd = 215849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio._StopAudioRoutine_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004649 RID: 17993
			// (get) Token: 0x0600E791 RID: 59281 RVA: 0x00387188 File Offset: 0x00385388
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio._StopAudioRoutine_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E792 RID: 59282 RVA: 0x0006D355 File Offset: 0x0006B555
			public _StopAudioRoutine_d__11(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004643 RID: 17987
			// (get) Token: 0x0600E793 RID: 59283 RVA: 0x003871C8 File Offset: 0x003853C8
			// (set) Token: 0x0600E794 RID: 59284 RVA: 0x0006D35E File Offset: 0x0006B55E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio._StopAudioRoutine_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio._StopAudioRoutine_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004644 RID: 17988
			// (get) Token: 0x0600E795 RID: 59285 RVA: 0x003871F0 File Offset: 0x003853F0
			// (set) Token: 0x0600E796 RID: 59286 RVA: 0x0006D379 File Offset: 0x0006B579
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio._StopAudioRoutine_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio._StopAudioRoutine_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004645 RID: 17989
			// (get) Token: 0x0600E797 RID: 59287 RVA: 0x00387220 File Offset: 0x00385420
			// (set) Token: 0x0600E798 RID: 59288 RVA: 0x0006D398 File Offset: 0x0006B598
			public unsafe StartLoopStopAudio __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio._StopAudioRoutine_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartLoopStopAudio>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio._StopAudioRoutine_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004646 RID: 17990
			// (get) Token: 0x0600E799 RID: 59289 RVA: 0x00387250 File Offset: 0x00385450
			// (set) Token: 0x0600E79A RID: 59290 RVA: 0x0006D3B7 File Offset: 0x0006B5B7
			public unsafe float _timer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio._StopAudioRoutine_d__11.NativeFieldInfoPtr__timer_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio._StopAudioRoutine_d__11.NativeFieldInfoPtr__timer_5__2)) = value;
				}
			}

			// Token: 0x17004647 RID: 17991
			// (get) Token: 0x0600E79B RID: 59291 RVA: 0x00387278 File Offset: 0x00385478
			// (set) Token: 0x0600E79C RID: 59292 RVA: 0x0006D3D2 File Offset: 0x0006B5D2
			public unsafe float _duration_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio._StopAudioRoutine_d__11.NativeFieldInfoPtr__duration_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio._StopAudioRoutine_d__11.NativeFieldInfoPtr__duration_5__3)) = value;
				}
			}

			// Token: 0x04009D27 RID: 40231
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009D28 RID: 40232
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009D29 RID: 40233
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009D2A RID: 40234
			private static readonly IntPtr NativeFieldInfoPtr__timer_5__2;

			// Token: 0x04009D2B RID: 40235
			private static readonly IntPtr NativeFieldInfoPtr__duration_5__3;

			// Token: 0x04009D2C RID: 40236
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009D2D RID: 40237
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009D2E RID: 40238
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009D2F RID: 40239
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009D30 RID: 40240
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009D31 RID: 40241
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
