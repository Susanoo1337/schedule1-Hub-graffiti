using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2Cpp
{
	// Token: 0x02000025 RID: 37
	public class CanvasSampleOpenFileImage : MonoBehaviour
	{
		// Token: 0x060001CB RID: 459 RVA: 0x00081194 File Offset: 0x0007F394
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasSampleOpenFileImage()
		{
			Il2CppClassPointerStore<CanvasSampleOpenFileImage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CanvasSampleOpenFileImage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasSampleOpenFileImage>.NativeClassPtr);
			CanvasSampleOpenFileImage.NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasSampleOpenFileImage>.NativeClassPtr, "output");
			CanvasSampleOpenFileImage.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileImage>.NativeClassPtr, 100663510);
			CanvasSampleOpenFileImage.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileImage>.NativeClassPtr, 100663511);
			CanvasSampleOpenFileImage.NativeMethodInfoPtr_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileImage>.NativeClassPtr, 100663512);
			CanvasSampleOpenFileImage.NativeMethodInfoPtr_OutputRoutine_Private_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileImage>.NativeClassPtr, 100663513);
			CanvasSampleOpenFileImage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileImage>.NativeClassPtr, 100663514);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0008123C File Offset: 0x0007F43C
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileImage.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00081280 File Offset: 0x0007F480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67177, XrefRangeEnd = 67188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileImage.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000812B4 File Offset: 0x0007F4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67188, XrefRangeEnd = 67210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileImage.NativeMethodInfoPtr_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000812E8 File Offset: 0x0007F4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67210, XrefRangeEnd = 67216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OutputRoutine(string url)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileImage.NativeMethodInfoPtr_OutputRoutine_Private_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00081338 File Offset: 0x0007F538
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanvasSampleOpenFileImage() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasSampleOpenFileImage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileImage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002E9B File Offset: 0x0000109B
		public CanvasSampleOpenFileImage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00081374 File Offset: 0x0007F574
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00002EA4 File Offset: 0x000010A4
		public unsafe RawImage output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileImage.NativeFieldInfoPtr_output);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RawImage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileImage.NativeFieldInfoPtr_output), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeFieldInfoPtr_output;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_OnClick_Private_Void_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_OutputRoutine_Private_IEnumerator_String_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200085F RID: 2143
		[ObfuscatedName("CanvasSampleOpenFileImage+<OutputRoutine>d__4")]
		public sealed class _OutputRoutine_d__4 : Il2CppSystem.Object
		{
			// Token: 0x0600D018 RID: 53272 RVA: 0x00344418 File Offset: 0x00342618
			// Note: this type is marked as 'beforefieldinit'.
			static _OutputRoutine_d__4()
			{
				Il2CppClassPointerStore<CanvasSampleOpenFileImage._OutputRoutine_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanvasSampleOpenFileImage>.NativeClassPtr, "<OutputRoutine>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasSampleOpenFileImage._OutputRoutine_d__4>.NativeClassPtr);
				CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasSampleOpenFileImage._OutputRoutine_d__4>.NativeClassPtr, "<>1__state");
				CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasSampleOpenFileImage._OutputRoutine_d__4>.NativeClassPtr, "<>2__current");
				CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasSampleOpenFileImage._OutputRoutine_d__4>.NativeClassPtr, "url");
				CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasSampleOpenFileImage._OutputRoutine_d__4>.NativeClassPtr, "<>4__this");
				CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeFieldInfoPtr__loader_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasSampleOpenFileImage._OutputRoutine_d__4>.NativeClassPtr, "<loader>5__2");
				CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileImage._OutputRoutine_d__4>.NativeClassPtr, 100663515);
				CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileImage._OutputRoutine_d__4>.NativeClassPtr, 100663516);
				CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileImage._OutputRoutine_d__4>.NativeClassPtr, 100663517);
				CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileImage._OutputRoutine_d__4>.NativeClassPtr, 100663518);
				CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileImage._OutputRoutine_d__4>.NativeClassPtr, 100663519);
				CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileImage._OutputRoutine_d__4>.NativeClassPtr, 100663520);
			}

			// Token: 0x0600D019 RID: 53273 RVA: 0x00344520 File Offset: 0x00342720
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OutputRoutine_d__4(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasSampleOpenFileImage._OutputRoutine_d__4>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D01A RID: 53274 RVA: 0x00344568 File Offset: 0x00342768
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D01B RID: 53275 RVA: 0x0034459C File Offset: 0x0034279C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67166, XrefRangeEnd = 67172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F04 RID: 16132
			// (get) Token: 0x0600D01C RID: 53276 RVA: 0x003445D8 File Offset: 0x003427D8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D01D RID: 53277 RVA: 0x00344618 File Offset: 0x00342818
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67172, XrefRangeEnd = 67177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F05 RID: 16133
			// (get) Token: 0x0600D01E RID: 53278 RVA: 0x0034464C File Offset: 0x0034284C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D01F RID: 53279 RVA: 0x000627C6 File Offset: 0x000609C6
			public _OutputRoutine_d__4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EFF RID: 16127
			// (get) Token: 0x0600D020 RID: 53280 RVA: 0x0034468C File Offset: 0x0034288C
			// (set) Token: 0x0600D021 RID: 53281 RVA: 0x000627CF File Offset: 0x000609CF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F00 RID: 16128
			// (get) Token: 0x0600D022 RID: 53282 RVA: 0x003446B4 File Offset: 0x003428B4
			// (set) Token: 0x0600D023 RID: 53283 RVA: 0x000627EA File Offset: 0x000609EA
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F01 RID: 16129
			// (get) Token: 0x0600D024 RID: 53284 RVA: 0x003446E4 File Offset: 0x003428E4
			// (set) Token: 0x0600D025 RID: 53285 RVA: 0x00062809 File Offset: 0x00060A09
			public unsafe string url
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeFieldInfoPtr_url);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F02 RID: 16130
			// (get) Token: 0x0600D026 RID: 53286 RVA: 0x0034470C File Offset: 0x0034290C
			// (set) Token: 0x0600D027 RID: 53287 RVA: 0x00062828 File Offset: 0x00060A28
			public unsafe CanvasSampleOpenFileImage __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasSampleOpenFileImage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F03 RID: 16131
			// (get) Token: 0x0600D028 RID: 53288 RVA: 0x0034473C File Offset: 0x0034293C
			// (set) Token: 0x0600D029 RID: 53289 RVA: 0x00062847 File Offset: 0x00060A47
			public unsafe WWW _loader_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeFieldInfoPtr__loader_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WWW>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileImage._OutputRoutine_d__4.NativeFieldInfoPtr__loader_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DDA RID: 36314
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008DDB RID: 36315
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008DDC RID: 36316
			private static readonly IntPtr NativeFieldInfoPtr_url;

			// Token: 0x04008DDD RID: 36317
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008DDE RID: 36318
			private static readonly IntPtr NativeFieldInfoPtr__loader_5__2;

			// Token: 0x04008DDF RID: 36319
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008DE0 RID: 36320
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DE1 RID: 36321
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008DE2 RID: 36322
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008DE3 RID: 36323
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DE4 RID: 36324
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
