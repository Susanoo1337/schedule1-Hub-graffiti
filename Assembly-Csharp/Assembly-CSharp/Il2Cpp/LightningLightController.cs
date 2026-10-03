using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200000E RID: 14
	public class LightningLightController : MonoBehaviour
	{
		// Token: 0x060000BE RID: 190 RVA: 0x0007DC84 File Offset: 0x0007BE84
		// Note: this type is marked as 'beforefieldinit'.
		static LightningLightController()
		{
			Il2CppClassPointerStore<LightningLightController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LightningLightController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningLightController>.NativeClassPtr);
			LightningLightController.NativeFieldInfoPtr_lightEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLightController>.NativeClassPtr, "lightEntries");
			LightningLightController.NativeFieldInfoPtr_minTimeBetweenStrikes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLightController>.NativeClassPtr, "minTimeBetweenStrikes");
			LightningLightController.NativeFieldInfoPtr_maxTimeBetweenStrikes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLightController>.NativeClassPtr, "maxTimeBetweenStrikes");
			LightningLightController.NativeFieldInfoPtr__strikeCo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLightController>.NativeClassPtr, "_strikeCo");
			LightningLightController.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningLightController>.NativeClassPtr, 100663354);
			LightningLightController.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningLightController>.NativeClassPtr, 100663355);
			LightningLightController.NativeMethodInfoPtr_DoStrikeRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningLightController>.NativeClassPtr, 100663356);
			LightningLightController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningLightController>.NativeClassPtr, 100663357);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0007DD54 File Offset: 0x0007BF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65365, XrefRangeEnd = 65381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningLightController.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0007DD88 File Offset: 0x0007BF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65381, XrefRangeEnd = 65383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningLightController.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0007DDBC File Offset: 0x0007BFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65383, XrefRangeEnd = 65388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoStrikeRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningLightController.NativeMethodInfoPtr_DoStrikeRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0007DDFC File Offset: 0x0007BFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65388, XrefRangeEnd = 65389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightningLightController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningLightController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningLightController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000026E8 File Offset: 0x000008E8
		public LightningLightController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0007DE38 File Offset: 0x0007C038
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x000026F1 File Offset: 0x000008F1
		public unsafe Il2CppReferenceArray<LightningLightController.LightEntry> lightEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController.NativeFieldInfoPtr_lightEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LightningLightController.LightEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController.NativeFieldInfoPtr_lightEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0007DE68 File Offset: 0x0007C068
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002710 File Offset: 0x00000910
		public unsafe float minTimeBetweenStrikes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController.NativeFieldInfoPtr_minTimeBetweenStrikes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController.NativeFieldInfoPtr_minTimeBetweenStrikes)) = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0007DE90 File Offset: 0x0007C090
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000272B File Offset: 0x0000092B
		public unsafe float maxTimeBetweenStrikes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController.NativeFieldInfoPtr_maxTimeBetweenStrikes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController.NativeFieldInfoPtr_maxTimeBetweenStrikes)) = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0007DEB8 File Offset: 0x0007C0B8
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00002746 File Offset: 0x00000946
		public unsafe Coroutine _strikeCo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController.NativeFieldInfoPtr__strikeCo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController.NativeFieldInfoPtr__strikeCo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_lightEntries;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_minTimeBetweenStrikes;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_maxTimeBetweenStrikes;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr__strikeCo;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_DoStrikeRoutine_Private_IEnumerator_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200084E RID: 2126
		[Serializable]
		public class LightEntry : Il2CppSystem.Object
		{
			// Token: 0x0600CF6D RID: 53101 RVA: 0x00342514 File Offset: 0x00340714
			// Note: this type is marked as 'beforefieldinit'.
			static LightEntry()
			{
				Il2CppClassPointerStore<LightningLightController.LightEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningLightController>.NativeClassPtr, "LightEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningLightController.LightEntry>.NativeClassPtr);
				LightningLightController.LightEntry.NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLightController.LightEntry>.NativeClassPtr, "light");
				LightningLightController.LightEntry.NativeFieldInfoPtr_flashCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLightController.LightEntry>.NativeClassPtr, "flashCurve");
				LightningLightController.LightEntry.NativeFieldInfoPtr_maxIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLightController.LightEntry>.NativeClassPtr, "maxIntensity");
				LightningLightController.LightEntry.NativeFieldInfoPtr_strikeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLightController.LightEntry>.NativeClassPtr, "strikeDuration");
				LightningLightController.LightEntry.NativeFieldInfoPtr_startDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLightController.LightEntry>.NativeClassPtr, "startDelay");
				LightningLightController.LightEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningLightController.LightEntry>.NativeClassPtr, 100663358);
			}

			// Token: 0x0600CF6E RID: 53102 RVA: 0x003425B8 File Offset: 0x003407B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65265, XrefRangeEnd = 65266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LightEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningLightController.LightEntry>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningLightController.LightEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF6F RID: 53103 RVA: 0x0006229D File Offset: 0x0006049D
			public LightEntry(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ECD RID: 16077
			// (get) Token: 0x0600CF70 RID: 53104 RVA: 0x003425F4 File Offset: 0x003407F4
			// (set) Token: 0x0600CF71 RID: 53105 RVA: 0x000622A6 File Offset: 0x000604A6
			public unsafe Light light
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController.LightEntry.NativeFieldInfoPtr_light);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController.LightEntry.NativeFieldInfoPtr_light), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003ECE RID: 16078
			// (get) Token: 0x0600CF72 RID: 53106 RVA: 0x00342624 File Offset: 0x00340824
			// (set) Token: 0x0600CF73 RID: 53107 RVA: 0x000622C5 File Offset: 0x000604C5
			public unsafe AnimationCurve flashCurve
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController.LightEntry.NativeFieldInfoPtr_flashCurve);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController.LightEntry.NativeFieldInfoPtr_flashCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003ECF RID: 16079
			// (get) Token: 0x0600CF74 RID: 53108 RVA: 0x00342654 File Offset: 0x00340854
			// (set) Token: 0x0600CF75 RID: 53109 RVA: 0x000622E4 File Offset: 0x000604E4
			public unsafe float maxIntensity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController.LightEntry.NativeFieldInfoPtr_maxIntensity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController.LightEntry.NativeFieldInfoPtr_maxIntensity)) = value;
				}
			}

			// Token: 0x17003ED0 RID: 16080
			// (get) Token: 0x0600CF76 RID: 53110 RVA: 0x0034267C File Offset: 0x0034087C
			// (set) Token: 0x0600CF77 RID: 53111 RVA: 0x000622FF File Offset: 0x000604FF
			public unsafe float strikeDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController.LightEntry.NativeFieldInfoPtr_strikeDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController.LightEntry.NativeFieldInfoPtr_strikeDuration)) = value;
				}
			}

			// Token: 0x17003ED1 RID: 16081
			// (get) Token: 0x0600CF78 RID: 53112 RVA: 0x003426A4 File Offset: 0x003408A4
			// (set) Token: 0x0600CF79 RID: 53113 RVA: 0x0006231A File Offset: 0x0006051A
			public unsafe float startDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController.LightEntry.NativeFieldInfoPtr_startDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController.LightEntry.NativeFieldInfoPtr_startDelay)) = value;
				}
			}

			// Token: 0x04008D73 RID: 36211
			private static readonly IntPtr NativeFieldInfoPtr_light;

			// Token: 0x04008D74 RID: 36212
			private static readonly IntPtr NativeFieldInfoPtr_flashCurve;

			// Token: 0x04008D75 RID: 36213
			private static readonly IntPtr NativeFieldInfoPtr_maxIntensity;

			// Token: 0x04008D76 RID: 36214
			private static readonly IntPtr NativeFieldInfoPtr_strikeDuration;

			// Token: 0x04008D77 RID: 36215
			private static readonly IntPtr NativeFieldInfoPtr_startDelay;

			// Token: 0x04008D78 RID: 36216
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200084F RID: 2127
		[ObfuscatedName("LightningLightController+<DoStrikeRoutine>d__7")]
		public sealed class _DoStrikeRoutine_d__7 : Il2CppSystem.Object
		{
			// Token: 0x0600CF7A RID: 53114 RVA: 0x003426CC File Offset: 0x003408CC
			// Note: this type is marked as 'beforefieldinit'.
			static _DoStrikeRoutine_d__7()
			{
				Il2CppClassPointerStore<LightningLightController._DoStrikeRoutine_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightningLightController>.NativeClassPtr, "<DoStrikeRoutine>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningLightController._DoStrikeRoutine_d__7>.NativeClassPtr);
				LightningLightController._DoStrikeRoutine_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLightController._DoStrikeRoutine_d__7>.NativeClassPtr, "<>1__state");
				LightningLightController._DoStrikeRoutine_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLightController._DoStrikeRoutine_d__7>.NativeClassPtr, "<>2__current");
				LightningLightController._DoStrikeRoutine_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLightController._DoStrikeRoutine_d__7>.NativeClassPtr, "<>4__this");
				LightningLightController._DoStrikeRoutine_d__7.NativeFieldInfoPtr__elapsedTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningLightController._DoStrikeRoutine_d__7>.NativeClassPtr, "<elapsedTime>5__2");
				LightningLightController._DoStrikeRoutine_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningLightController._DoStrikeRoutine_d__7>.NativeClassPtr, 100663359);
				LightningLightController._DoStrikeRoutine_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningLightController._DoStrikeRoutine_d__7>.NativeClassPtr, 100663360);
				LightningLightController._DoStrikeRoutine_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningLightController._DoStrikeRoutine_d__7>.NativeClassPtr, 100663361);
				LightningLightController._DoStrikeRoutine_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningLightController._DoStrikeRoutine_d__7>.NativeClassPtr, 100663362);
				LightningLightController._DoStrikeRoutine_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningLightController._DoStrikeRoutine_d__7>.NativeClassPtr, 100663363);
				LightningLightController._DoStrikeRoutine_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningLightController._DoStrikeRoutine_d__7>.NativeClassPtr, 100663364);
			}

			// Token: 0x0600CF7B RID: 53115 RVA: 0x003427C0 File Offset: 0x003409C0
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65266, XrefRangeEnd = 65267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoStrikeRoutine_d__7(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningLightController._DoStrikeRoutine_d__7>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningLightController._DoStrikeRoutine_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF7C RID: 53116 RVA: 0x00342808 File Offset: 0x00340A08
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningLightController._DoStrikeRoutine_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF7D RID: 53117 RVA: 0x0034283C File Offset: 0x00340A3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65350, XrefRangeEnd = 65360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningLightController._DoStrikeRoutine_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003ED6 RID: 16086
			// (get) Token: 0x0600CF7E RID: 53118 RVA: 0x00342878 File Offset: 0x00340A78
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningLightController._DoStrikeRoutine_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF7F RID: 53119 RVA: 0x003428B8 File Offset: 0x00340AB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65360, XrefRangeEnd = 65365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningLightController._DoStrikeRoutine_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003ED7 RID: 16087
			// (get) Token: 0x0600CF80 RID: 53120 RVA: 0x003428EC File Offset: 0x00340AEC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightningLightController._DoStrikeRoutine_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF81 RID: 53121 RVA: 0x00062335 File Offset: 0x00060535
			public _DoStrikeRoutine_d__7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ED2 RID: 16082
			// (get) Token: 0x0600CF82 RID: 53122 RVA: 0x0034292C File Offset: 0x00340B2C
			// (set) Token: 0x0600CF83 RID: 53123 RVA: 0x0006233E File Offset: 0x0006053E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController._DoStrikeRoutine_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController._DoStrikeRoutine_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003ED3 RID: 16083
			// (get) Token: 0x0600CF84 RID: 53124 RVA: 0x00342954 File Offset: 0x00340B54
			// (set) Token: 0x0600CF85 RID: 53125 RVA: 0x00062359 File Offset: 0x00060559
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController._DoStrikeRoutine_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController._DoStrikeRoutine_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003ED4 RID: 16084
			// (get) Token: 0x0600CF86 RID: 53126 RVA: 0x00342984 File Offset: 0x00340B84
			// (set) Token: 0x0600CF87 RID: 53127 RVA: 0x00062378 File Offset: 0x00060578
			public unsafe LightningLightController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController._DoStrikeRoutine_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightningLightController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController._DoStrikeRoutine_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003ED5 RID: 16085
			// (get) Token: 0x0600CF88 RID: 53128 RVA: 0x003429B4 File Offset: 0x00340BB4
			// (set) Token: 0x0600CF89 RID: 53129 RVA: 0x00062397 File Offset: 0x00060597
			public unsafe float _elapsedTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController._DoStrikeRoutine_d__7.NativeFieldInfoPtr__elapsedTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightningLightController._DoStrikeRoutine_d__7.NativeFieldInfoPtr__elapsedTime_5__2)) = value;
				}
			}

			// Token: 0x04008D79 RID: 36217
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008D7A RID: 36218
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008D7B RID: 36219
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D7C RID: 36220
			private static readonly IntPtr NativeFieldInfoPtr__elapsedTime_5__2;

			// Token: 0x04008D7D RID: 36221
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008D7E RID: 36222
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D7F RID: 36223
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008D80 RID: 36224
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008D81 RID: 36225
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D82 RID: 36226
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
