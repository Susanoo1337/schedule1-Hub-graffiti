using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppVLB
{
	// Token: 0x02000044 RID: 68
	public class EffectPulse : EffectAbstractBase
	{
		// Token: 0x060004CB RID: 1227 RVA: 0x000894E0 File Offset: 0x000876E0
		// Note: this type is marked as 'beforefieldinit'.
		static EffectPulse()
		{
			Il2CppClassPointerStore<EffectPulse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "EffectPulse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr);
			EffectPulse.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, "ClassName");
			EffectPulse.NativeFieldInfoPtr_frequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, "frequency");
			EffectPulse.NativeFieldInfoPtr_intensityAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, "intensityAmplitude");
			EffectPulse.NativeMethodInfoPtr_InitFrom_Public_Virtual_Void_EffectAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, 100663783);
			EffectPulse.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, 100663784);
			EffectPulse.NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, 100663785);
			EffectPulse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, 100663786);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0008959C File Offset: 0x0008779C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69576, XrefRangeEnd = 69586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitFrom(EffectAbstractBase source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectPulse.NativeMethodInfoPtr_InitFrom_Public_Virtual_Void_EffectAbstractBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x000895EC File Offset: 0x000877EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69586, XrefRangeEnd = 69593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectPulse.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00089628 File Offset: 0x00087828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69593, XrefRangeEnd = 69598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CoUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse.NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00089668 File Offset: 0x00087868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69598, XrefRangeEnd = 69607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EffectPulse() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00004B3B File Offset: 0x00002D3B
		public EffectPulse(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x000896A4 File Offset: 0x000878A4
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00004B44 File Offset: 0x00002D44
		public new unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EffectPulse.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EffectPulse.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x000896C4 File Offset: 0x000878C4
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00004B56 File Offset: 0x00002D56
		public unsafe float frequency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse.NativeFieldInfoPtr_frequency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse.NativeFieldInfoPtr_frequency)) = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x000896EC File Offset: 0x000878EC
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00004B71 File Offset: 0x00002D71
		public unsafe MinMaxRangeFloat intensityAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse.NativeFieldInfoPtr_intensityAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse.NativeFieldInfoPtr_intensityAmplitude)) = value;
			}
		}

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeFieldInfoPtr_frequency;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeFieldInfoPtr_intensityAmplitude;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_InitFrom_Public_Virtual_Void_EffectAbstractBase_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_CoUpdate_Private_IEnumerator_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000873 RID: 2163
		[ObfuscatedName("VLB.EffectPulse+<CoUpdate>d__5")]
		public sealed class _CoUpdate_d__5 : Object
		{
			// Token: 0x0600D1D7 RID: 53719 RVA: 0x00347D40 File Offset: 0x00345F40
			// Note: this type is marked as 'beforefieldinit'.
			static _CoUpdate_d__5()
			{
				Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EffectPulse>.NativeClassPtr, "<CoUpdate>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr);
				EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, "<>1__state");
				EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, "<>2__current");
				EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, "<>4__this");
				EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr__t_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, "<t>5__2");
				EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, 100663787);
				EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, 100663788);
				EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, 100663789);
				EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, 100663790);
				EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, 100663791);
				EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr, 100663792);
			}

			// Token: 0x0600D1D8 RID: 53720 RVA: 0x00347E34 File Offset: 0x00346034
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CoUpdate_d__5(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectPulse._CoUpdate_d__5>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1D9 RID: 53721 RVA: 0x00347E7C File Offset: 0x0034607C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1DA RID: 53722 RVA: 0x00347EB0 File Offset: 0x003460B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69565, XrefRangeEnd = 69571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003FC6 RID: 16326
			// (get) Token: 0x0600D1DB RID: 53723 RVA: 0x00347EEC File Offset: 0x003460EC
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D1DC RID: 53724 RVA: 0x00347F2C File Offset: 0x0034612C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69571, XrefRangeEnd = 69576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003FC7 RID: 16327
			// (get) Token: 0x0600D1DD RID: 53725 RVA: 0x00347F60 File Offset: 0x00346160
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectPulse._CoUpdate_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D1DE RID: 53726 RVA: 0x00063545 File Offset: 0x00061745
			public _CoUpdate_d__5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FC2 RID: 16322
			// (get) Token: 0x0600D1DF RID: 53727 RVA: 0x00347FA0 File Offset: 0x003461A0
			// (set) Token: 0x0600D1E0 RID: 53728 RVA: 0x0006354E File Offset: 0x0006174E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FC3 RID: 16323
			// (get) Token: 0x0600D1E1 RID: 53729 RVA: 0x00347FC8 File Offset: 0x003461C8
			// (set) Token: 0x0600D1E2 RID: 53730 RVA: 0x00063569 File Offset: 0x00061769
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FC4 RID: 16324
			// (get) Token: 0x0600D1E3 RID: 53731 RVA: 0x00347FF8 File Offset: 0x003461F8
			// (set) Token: 0x0600D1E4 RID: 53732 RVA: 0x00063588 File Offset: 0x00061788
			public unsafe EffectPulse __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectPulse>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FC5 RID: 16325
			// (get) Token: 0x0600D1E5 RID: 53733 RVA: 0x00348028 File Offset: 0x00346228
			// (set) Token: 0x0600D1E6 RID: 53734 RVA: 0x000635A7 File Offset: 0x000617A7
			public unsafe float _t_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr__t_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectPulse._CoUpdate_d__5.NativeFieldInfoPtr__t_5__2)) = value;
				}
			}

			// Token: 0x04008EC6 RID: 36550
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008EC7 RID: 36551
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008EC8 RID: 36552
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008EC9 RID: 36553
			private static readonly IntPtr NativeFieldInfoPtr__t_5__2;

			// Token: 0x04008ECA RID: 36554
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008ECB RID: 36555
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008ECC RID: 36556
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008ECD RID: 36557
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008ECE RID: 36558
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008ECF RID: 36559
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
