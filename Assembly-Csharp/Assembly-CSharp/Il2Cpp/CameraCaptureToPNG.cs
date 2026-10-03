using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000011 RID: 17
	public class CameraCaptureToPNG : MonoBehaviour
	{
		// Token: 0x060000DD RID: 221 RVA: 0x0007E2FC File Offset: 0x0007C4FC
		// Note: this type is marked as 'beforefieldinit'.
		static CameraCaptureToPNG()
		{
			Il2CppClassPointerStore<CameraCaptureToPNG>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CameraCaptureToPNG");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraCaptureToPNG>.NativeClassPtr);
			CameraCaptureToPNG.NativeFieldInfoPtr_targetCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraCaptureToPNG>.NativeClassPtr, "targetCamera");
			CameraCaptureToPNG.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraCaptureToPNG>.NativeClassPtr, "width");
			CameraCaptureToPNG.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraCaptureToPNG>.NativeClassPtr, "height");
			CameraCaptureToPNG.NativeFieldInfoPtr_captureKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraCaptureToPNG>.NativeClassPtr, "captureKey");
			CameraCaptureToPNG.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCaptureToPNG>.NativeClassPtr, 100663380);
			CameraCaptureToPNG.NativeMethodInfoPtr_CaptureCameraView_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCaptureToPNG>.NativeClassPtr, 100663381);
			CameraCaptureToPNG.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCaptureToPNG>.NativeClassPtr, 100663382);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0007E3B8 File Offset: 0x0007C5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65641, XrefRangeEnd = 65648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraCaptureToPNG.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0007E3EC File Offset: 0x0007C5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65648, XrefRangeEnd = 65653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CaptureCameraView()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraCaptureToPNG.NativeMethodInfoPtr_CaptureCameraView_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0007E42C File Offset: 0x0007C62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65653, XrefRangeEnd = 65654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraCaptureToPNG() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraCaptureToPNG>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraCaptureToPNG.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000027C3 File Offset: 0x000009C3
		public CameraCaptureToPNG(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x0007E468 File Offset: 0x0007C668
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x000027CC File Offset: 0x000009CC
		public unsafe Camera targetCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraCaptureToPNG.NativeFieldInfoPtr_targetCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraCaptureToPNG.NativeFieldInfoPtr_targetCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0007E498 File Offset: 0x0007C698
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x000027EB File Offset: 0x000009EB
		public unsafe int width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraCaptureToPNG.NativeFieldInfoPtr_width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraCaptureToPNG.NativeFieldInfoPtr_width)) = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0007E4C0 File Offset: 0x0007C6C0
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00002806 File Offset: 0x00000A06
		public unsafe int height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraCaptureToPNG.NativeFieldInfoPtr_height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraCaptureToPNG.NativeFieldInfoPtr_height)) = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0007E4E8 File Offset: 0x0007C6E8
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00002821 File Offset: 0x00000A21
		public unsafe KeyCode captureKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraCaptureToPNG.NativeFieldInfoPtr_captureKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraCaptureToPNG.NativeFieldInfoPtr_captureKey)) = value;
			}
		}

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr_targetCamera;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr_captureKey;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_CaptureCameraView_Private_IEnumerator_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000851 RID: 2129
		[ObfuscatedName("CameraCaptureToPNG+<CaptureCameraView>d__5")]
		public sealed class _CaptureCameraView_d__5 : Il2CppSystem.Object
		{
			// Token: 0x0600CFA6 RID: 53158 RVA: 0x00342E54 File Offset: 0x00341054
			// Note: this type is marked as 'beforefieldinit'.
			static _CaptureCameraView_d__5()
			{
				Il2CppClassPointerStore<CameraCaptureToPNG._CaptureCameraView_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraCaptureToPNG>.NativeClassPtr, "<CaptureCameraView>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraCaptureToPNG._CaptureCameraView_d__5>.NativeClassPtr);
				CameraCaptureToPNG._CaptureCameraView_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraCaptureToPNG._CaptureCameraView_d__5>.NativeClassPtr, "<>1__state");
				CameraCaptureToPNG._CaptureCameraView_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraCaptureToPNG._CaptureCameraView_d__5>.NativeClassPtr, "<>2__current");
				CameraCaptureToPNG._CaptureCameraView_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraCaptureToPNG._CaptureCameraView_d__5>.NativeClassPtr, "<>4__this");
				CameraCaptureToPNG._CaptureCameraView_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCaptureToPNG._CaptureCameraView_d__5>.NativeClassPtr, 100663383);
				CameraCaptureToPNG._CaptureCameraView_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCaptureToPNG._CaptureCameraView_d__5>.NativeClassPtr, 100663384);
				CameraCaptureToPNG._CaptureCameraView_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCaptureToPNG._CaptureCameraView_d__5>.NativeClassPtr, 100663385);
				CameraCaptureToPNG._CaptureCameraView_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCaptureToPNG._CaptureCameraView_d__5>.NativeClassPtr, 100663386);
				CameraCaptureToPNG._CaptureCameraView_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCaptureToPNG._CaptureCameraView_d__5>.NativeClassPtr, 100663387);
				CameraCaptureToPNG._CaptureCameraView_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCaptureToPNG._CaptureCameraView_d__5>.NativeClassPtr, 100663388);
			}

			// Token: 0x0600CFA7 RID: 53159 RVA: 0x00342F34 File Offset: 0x00341134
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CaptureCameraView_d__5(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraCaptureToPNG._CaptureCameraView_d__5>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraCaptureToPNG._CaptureCameraView_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFA8 RID: 53160 RVA: 0x00342F7C File Offset: 0x0034117C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraCaptureToPNG._CaptureCameraView_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFA9 RID: 53161 RVA: 0x00342FB0 File Offset: 0x003411B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65623, XrefRangeEnd = 65636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraCaptureToPNG._CaptureCameraView_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003EE7 RID: 16103
			// (get) Token: 0x0600CFAA RID: 53162 RVA: 0x00342FEC File Offset: 0x003411EC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraCaptureToPNG._CaptureCameraView_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CFAB RID: 53163 RVA: 0x0034302C File Offset: 0x0034122C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65636, XrefRangeEnd = 65641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraCaptureToPNG._CaptureCameraView_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003EE8 RID: 16104
			// (get) Token: 0x0600CFAC RID: 53164 RVA: 0x00343060 File Offset: 0x00341260
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraCaptureToPNG._CaptureCameraView_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CFAD RID: 53165 RVA: 0x000624D1 File Offset: 0x000606D1
			public _CaptureCameraView_d__5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EE4 RID: 16100
			// (get) Token: 0x0600CFAE RID: 53166 RVA: 0x003430A0 File Offset: 0x003412A0
			// (set) Token: 0x0600CFAF RID: 53167 RVA: 0x000624DA File Offset: 0x000606DA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraCaptureToPNG._CaptureCameraView_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraCaptureToPNG._CaptureCameraView_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003EE5 RID: 16101
			// (get) Token: 0x0600CFB0 RID: 53168 RVA: 0x003430C8 File Offset: 0x003412C8
			// (set) Token: 0x0600CFB1 RID: 53169 RVA: 0x000624F5 File Offset: 0x000606F5
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraCaptureToPNG._CaptureCameraView_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraCaptureToPNG._CaptureCameraView_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EE6 RID: 16102
			// (get) Token: 0x0600CFB2 RID: 53170 RVA: 0x003430F8 File Offset: 0x003412F8
			// (set) Token: 0x0600CFB3 RID: 53171 RVA: 0x00062514 File Offset: 0x00060714
			public unsafe CameraCaptureToPNG __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraCaptureToPNG._CaptureCameraView_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraCaptureToPNG>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraCaptureToPNG._CaptureCameraView_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D93 RID: 36243
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008D94 RID: 36244
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008D95 RID: 36245
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D96 RID: 36246
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008D97 RID: 36247
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D98 RID: 36248
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008D99 RID: 36249
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008D9A RID: 36250
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D9B RID: 36251
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
