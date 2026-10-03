using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppVLB
{
	// Token: 0x02000042 RID: 66
	public class EffectFlicker : EffectAbstractBase
	{
		// Token: 0x060004A3 RID: 1187 RVA: 0x00088DC0 File Offset: 0x00086FC0
		// Note: this type is marked as 'beforefieldinit'.
		static EffectFlicker()
		{
			Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "EffectFlicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr);
			EffectFlicker.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "ClassName");
			EffectFlicker.NativeFieldInfoPtr_frequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "frequency");
			EffectFlicker.NativeFieldInfoPtr_performPauses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "performPauses");
			EffectFlicker.NativeFieldInfoPtr_flickeringDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "flickeringDuration");
			EffectFlicker.NativeFieldInfoPtr_pauseDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "pauseDuration");
			EffectFlicker.NativeFieldInfoPtr_restoreIntensityOnPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "restoreIntensityOnPause");
			EffectFlicker.NativeFieldInfoPtr_intensityAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "intensityAmplitude");
			EffectFlicker.NativeFieldInfoPtr_smoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "smoothing");
			EffectFlicker.NativeFieldInfoPtr_m_CurrentAdditiveIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "m_CurrentAdditiveIntensity");
			EffectFlicker.NativeMethodInfoPtr_InitFrom_Public_Virtual_Void_EffectAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, 100663753);
			EffectFlicker.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, 100663754);
			EffectFlicker.NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, 100663755);
			EffectFlicker.NativeMethodInfoPtr_CoFlicker_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, 100663756);
			EffectFlicker.NativeMethodInfoPtr_CoChangeIntensity_Private_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, 100663757);
			EffectFlicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, 100663758);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00088F1C File Offset: 0x0008711C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69492, XrefRangeEnd = 69502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitFrom(EffectAbstractBase source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectFlicker.NativeMethodInfoPtr_InitFrom_Public_Virtual_Void_EffectAbstractBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00088F6C File Offset: 0x0008716C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69502, XrefRangeEnd = 69509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectFlicker.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00088FA8 File Offset: 0x000871A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69509, XrefRangeEnd = 69514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CoUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker.NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00088FE8 File Offset: 0x000871E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69514, XrefRangeEnd = 69519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CoFlicker()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker.NativeMethodInfoPtr_CoFlicker_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00089028 File Offset: 0x00087228
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69524, RefRangeEnd = 69525, XrefRangeStart = 69519, XrefRangeEnd = 69524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CoChangeIntensity(float expectedDuration, float nextIntensity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref expectedDuration;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextIntensity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker.NativeMethodInfoPtr_CoChangeIntensity_Private_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00089084 File Offset: 0x00087284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69525, XrefRangeEnd = 69532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EffectFlicker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x000049EF File Offset: 0x00002BEF
		public EffectFlicker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x000890C0 File Offset: 0x000872C0
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x000049F8 File Offset: 0x00002BF8
		public new unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EffectFlicker.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EffectFlicker.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x000890E0 File Offset: 0x000872E0
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x00004A0A File Offset: 0x00002C0A
		public unsafe float frequency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_frequency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_frequency)) = value;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00089108 File Offset: 0x00087308
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x00004A25 File Offset: 0x00002C25
		public unsafe bool performPauses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_performPauses);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_performPauses)) = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00089130 File Offset: 0x00087330
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x00004A40 File Offset: 0x00002C40
		public unsafe MinMaxRangeFloat flickeringDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_flickeringDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_flickeringDuration)) = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00089158 File Offset: 0x00087358
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x00004A5B File Offset: 0x00002C5B
		public unsafe MinMaxRangeFloat pauseDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_pauseDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_pauseDuration)) = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00089180 File Offset: 0x00087380
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00004A76 File Offset: 0x00002C76
		public unsafe bool restoreIntensityOnPause
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_restoreIntensityOnPause);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_restoreIntensityOnPause)) = value;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x000891A8 File Offset: 0x000873A8
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00004A91 File Offset: 0x00002C91
		public unsafe MinMaxRangeFloat intensityAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_intensityAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_intensityAmplitude)) = value;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x000891D0 File Offset: 0x000873D0
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00004AAC File Offset: 0x00002CAC
		public unsafe float smoothing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_smoothing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_smoothing)) = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x000891F8 File Offset: 0x000873F8
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x00004AC7 File Offset: 0x00002CC7
		public unsafe float m_CurrentAdditiveIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_m_CurrentAdditiveIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker.NativeFieldInfoPtr_m_CurrentAdditiveIntensity)) = value;
			}
		}

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeFieldInfoPtr_frequency;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeFieldInfoPtr_performPauses;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeFieldInfoPtr_flickeringDuration;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeFieldInfoPtr_pauseDuration;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeFieldInfoPtr_restoreIntensityOnPause;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeFieldInfoPtr_intensityAmplitude;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeFieldInfoPtr_smoothing;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentAdditiveIntensity;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr_InitFrom_Public_Virtual_Void_EffectAbstractBase_0;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_CoFlicker_Private_IEnumerator_0;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr_CoChangeIntensity_Private_IEnumerator_Single_Single_0;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000870 RID: 2160
		[ObfuscatedName("VLB.EffectFlicker+<CoChangeIntensity>d__13")]
		public sealed class _CoChangeIntensity_d__13 : Object
		{
			// Token: 0x0600D1A1 RID: 53665 RVA: 0x0034735C File Offset: 0x0034555C
			// Note: this type is marked as 'beforefieldinit'.
			static _CoChangeIntensity_d__13()
			{
				Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "<CoChangeIntensity>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr);
				EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, "<>1__state");
				EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, "<>2__current");
				EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, "<>4__this");
				EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr_nextIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, "nextIntensity");
				EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr_expectedDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, "expectedDuration");
				EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr__velocity_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, "<velocity>5__2");
				EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr__t_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, "<t>5__3");
				EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, 100663759);
				EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, 100663760);
				EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, 100663761);
				EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, 100663762);
				EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, 100663763);
				EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr, 100663764);
			}

			// Token: 0x0600D1A2 RID: 53666 RVA: 0x0034748C File Offset: 0x0034568C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CoChangeIntensity_d__13(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectFlicker._CoChangeIntensity_d__13>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1A3 RID: 53667 RVA: 0x003474D4 File Offset: 0x003456D4
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1A4 RID: 53668 RVA: 0x00347508 File Offset: 0x00345708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69465, XrefRangeEnd = 69471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003FB4 RID: 16308
			// (get) Token: 0x0600D1A5 RID: 53669 RVA: 0x00347544 File Offset: 0x00345744
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D1A6 RID: 53670 RVA: 0x00347584 File Offset: 0x00345784
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69471, XrefRangeEnd = 69476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003FB5 RID: 16309
			// (get) Token: 0x0600D1A7 RID: 53671 RVA: 0x003475B8 File Offset: 0x003457B8
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoChangeIntensity_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D1A8 RID: 53672 RVA: 0x0006337D File Offset: 0x0006157D
			public _CoChangeIntensity_d__13(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FAD RID: 16301
			// (get) Token: 0x0600D1A9 RID: 53673 RVA: 0x003475F8 File Offset: 0x003457F8
			// (set) Token: 0x0600D1AA RID: 53674 RVA: 0x00063386 File Offset: 0x00061586
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FAE RID: 16302
			// (get) Token: 0x0600D1AB RID: 53675 RVA: 0x00347620 File Offset: 0x00345820
			// (set) Token: 0x0600D1AC RID: 53676 RVA: 0x000633A1 File Offset: 0x000615A1
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FAF RID: 16303
			// (get) Token: 0x0600D1AD RID: 53677 RVA: 0x00347650 File Offset: 0x00345850
			// (set) Token: 0x0600D1AE RID: 53678 RVA: 0x000633C0 File Offset: 0x000615C0
			public unsafe EffectFlicker __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectFlicker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FB0 RID: 16304
			// (get) Token: 0x0600D1AF RID: 53679 RVA: 0x00347680 File Offset: 0x00345880
			// (set) Token: 0x0600D1B0 RID: 53680 RVA: 0x000633DF File Offset: 0x000615DF
			public unsafe float nextIntensity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr_nextIntensity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr_nextIntensity)) = value;
				}
			}

			// Token: 0x17003FB1 RID: 16305
			// (get) Token: 0x0600D1B1 RID: 53681 RVA: 0x003476A8 File Offset: 0x003458A8
			// (set) Token: 0x0600D1B2 RID: 53682 RVA: 0x000633FA File Offset: 0x000615FA
			public unsafe float expectedDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr_expectedDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr_expectedDuration)) = value;
				}
			}

			// Token: 0x17003FB2 RID: 16306
			// (get) Token: 0x0600D1B3 RID: 53683 RVA: 0x003476D0 File Offset: 0x003458D0
			// (set) Token: 0x0600D1B4 RID: 53684 RVA: 0x00063415 File Offset: 0x00061615
			public unsafe float _velocity_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr__velocity_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr__velocity_5__2)) = value;
				}
			}

			// Token: 0x17003FB3 RID: 16307
			// (get) Token: 0x0600D1B5 RID: 53685 RVA: 0x003476F8 File Offset: 0x003458F8
			// (set) Token: 0x0600D1B6 RID: 53686 RVA: 0x00063430 File Offset: 0x00061630
			public unsafe float _t_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr__t_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoChangeIntensity_d__13.NativeFieldInfoPtr__t_5__3)) = value;
				}
			}

			// Token: 0x04008EA5 RID: 36517
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008EA6 RID: 36518
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008EA7 RID: 36519
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008EA8 RID: 36520
			private static readonly IntPtr NativeFieldInfoPtr_nextIntensity;

			// Token: 0x04008EA9 RID: 36521
			private static readonly IntPtr NativeFieldInfoPtr_expectedDuration;

			// Token: 0x04008EAA RID: 36522
			private static readonly IntPtr NativeFieldInfoPtr__velocity_5__2;

			// Token: 0x04008EAB RID: 36523
			private static readonly IntPtr NativeFieldInfoPtr__t_5__3;

			// Token: 0x04008EAC RID: 36524
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008EAD RID: 36525
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008EAE RID: 36526
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008EAF RID: 36527
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008EB0 RID: 36528
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008EB1 RID: 36529
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000871 RID: 2161
		[ObfuscatedName("VLB.EffectFlicker+<CoFlicker>d__12")]
		public sealed class _CoFlicker_d__12 : Object
		{
			// Token: 0x0600D1B7 RID: 53687 RVA: 0x00347720 File Offset: 0x00345920
			// Note: this type is marked as 'beforefieldinit'.
			static _CoFlicker_d__12()
			{
				Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "<CoFlicker>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr);
				EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, "<>1__state");
				EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, "<>2__current");
				EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, "<>4__this");
				EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr__remainingDuration_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, "<remainingDuration>5__2");
				EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr__freqDuration_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, "<freqDuration>5__3");
				EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, 100663765);
				EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, 100663766);
				EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, 100663767);
				EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, 100663768);
				EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, 100663769);
				EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr, 100663770);
			}

			// Token: 0x0600D1B8 RID: 53688 RVA: 0x00347828 File Offset: 0x00345A28
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CoFlicker_d__12(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectFlicker._CoFlicker_d__12>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1B9 RID: 53689 RVA: 0x00347870 File Offset: 0x00345A70
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1BA RID: 53690 RVA: 0x003478A4 File Offset: 0x00345AA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69476, XrefRangeEnd = 69482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003FBB RID: 16315
			// (get) Token: 0x0600D1BB RID: 53691 RVA: 0x003478E0 File Offset: 0x00345AE0
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D1BC RID: 53692 RVA: 0x00347920 File Offset: 0x00345B20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69482, XrefRangeEnd = 69487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003FBC RID: 16316
			// (get) Token: 0x0600D1BD RID: 53693 RVA: 0x00347954 File Offset: 0x00345B54
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoFlicker_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D1BE RID: 53694 RVA: 0x0006344B File Offset: 0x0006164B
			public _CoFlicker_d__12(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FB6 RID: 16310
			// (get) Token: 0x0600D1BF RID: 53695 RVA: 0x00347994 File Offset: 0x00345B94
			// (set) Token: 0x0600D1C0 RID: 53696 RVA: 0x00063454 File Offset: 0x00061654
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FB7 RID: 16311
			// (get) Token: 0x0600D1C1 RID: 53697 RVA: 0x003479BC File Offset: 0x00345BBC
			// (set) Token: 0x0600D1C2 RID: 53698 RVA: 0x0006346F File Offset: 0x0006166F
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FB8 RID: 16312
			// (get) Token: 0x0600D1C3 RID: 53699 RVA: 0x003479EC File Offset: 0x00345BEC
			// (set) Token: 0x0600D1C4 RID: 53700 RVA: 0x0006348E File Offset: 0x0006168E
			public unsafe EffectFlicker __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectFlicker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FB9 RID: 16313
			// (get) Token: 0x0600D1C5 RID: 53701 RVA: 0x00347A1C File Offset: 0x00345C1C
			// (set) Token: 0x0600D1C6 RID: 53702 RVA: 0x000634AD File Offset: 0x000616AD
			public unsafe float _remainingDuration_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr__remainingDuration_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr__remainingDuration_5__2)) = value;
				}
			}

			// Token: 0x17003FBA RID: 16314
			// (get) Token: 0x0600D1C7 RID: 53703 RVA: 0x00347A44 File Offset: 0x00345C44
			// (set) Token: 0x0600D1C8 RID: 53704 RVA: 0x000634C8 File Offset: 0x000616C8
			public unsafe float _freqDuration_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr__freqDuration_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoFlicker_d__12.NativeFieldInfoPtr__freqDuration_5__3)) = value;
				}
			}

			// Token: 0x04008EB2 RID: 36530
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008EB3 RID: 36531
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008EB4 RID: 36532
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008EB5 RID: 36533
			private static readonly IntPtr NativeFieldInfoPtr__remainingDuration_5__2;

			// Token: 0x04008EB6 RID: 36534
			private static readonly IntPtr NativeFieldInfoPtr__freqDuration_5__3;

			// Token: 0x04008EB7 RID: 36535
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008EB8 RID: 36536
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008EB9 RID: 36537
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008EBA RID: 36538
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008EBB RID: 36539
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008EBC RID: 36540
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000872 RID: 2162
		[ObfuscatedName("VLB.EffectFlicker+<CoUpdate>d__11")]
		public sealed class _CoUpdate_d__11 : Object
		{
			// Token: 0x0600D1C9 RID: 53705 RVA: 0x00347A6C File Offset: 0x00345C6C
			// Note: this type is marked as 'beforefieldinit'.
			static _CoUpdate_d__11()
			{
				Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EffectFlicker>.NativeClassPtr, "<CoUpdate>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr);
				EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, "<>1__state");
				EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, "<>2__current");
				EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, "<>4__this");
				EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, 100663771);
				EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, 100663772);
				EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, 100663773);
				EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, 100663774);
				EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, 100663775);
				EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr, 100663776);
			}

			// Token: 0x0600D1CA RID: 53706 RVA: 0x00347B4C File Offset: 0x00345D4C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CoUpdate_d__11(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectFlicker._CoUpdate_d__11>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1CB RID: 53707 RVA: 0x00347B94 File Offset: 0x00345D94
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1CC RID: 53708 RVA: 0x00347BC8 File Offset: 0x00345DC8
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003FC0 RID: 16320
			// (get) Token: 0x0600D1CD RID: 53709 RVA: 0x00347C04 File Offset: 0x00345E04
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D1CE RID: 53710 RVA: 0x00347C44 File Offset: 0x00345E44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69487, XrefRangeEnd = 69492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003FC1 RID: 16321
			// (get) Token: 0x0600D1CF RID: 53711 RVA: 0x00347C78 File Offset: 0x00345E78
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectFlicker._CoUpdate_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D1D0 RID: 53712 RVA: 0x000634E3 File Offset: 0x000616E3
			public _CoUpdate_d__11(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FBD RID: 16317
			// (get) Token: 0x0600D1D1 RID: 53713 RVA: 0x00347CB8 File Offset: 0x00345EB8
			// (set) Token: 0x0600D1D2 RID: 53714 RVA: 0x000634EC File Offset: 0x000616EC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FBE RID: 16318
			// (get) Token: 0x0600D1D3 RID: 53715 RVA: 0x00347CE0 File Offset: 0x00345EE0
			// (set) Token: 0x0600D1D4 RID: 53716 RVA: 0x00063507 File Offset: 0x00061707
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FBF RID: 16319
			// (get) Token: 0x0600D1D5 RID: 53717 RVA: 0x00347D10 File Offset: 0x00345F10
			// (set) Token: 0x0600D1D6 RID: 53718 RVA: 0x00063526 File Offset: 0x00061726
			public unsafe EffectFlicker __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectFlicker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectFlicker._CoUpdate_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EBD RID: 36541
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008EBE RID: 36542
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008EBF RID: 36543
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008EC0 RID: 36544
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008EC1 RID: 36545
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008EC2 RID: 36546
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008EC3 RID: 36547
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008EC4 RID: 36548
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008EC5 RID: 36549
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
