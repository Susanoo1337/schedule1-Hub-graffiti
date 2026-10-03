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
	// Token: 0x02000026 RID: 38
	public class CanvasSampleOpenFileText : MonoBehaviour
	{
		// Token: 0x060001D4 RID: 468 RVA: 0x000813A4 File Offset: 0x0007F5A4
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasSampleOpenFileText()
		{
			Il2CppClassPointerStore<CanvasSampleOpenFileText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CanvasSampleOpenFileText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasSampleOpenFileText>.NativeClassPtr);
			CanvasSampleOpenFileText.NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasSampleOpenFileText>.NativeClassPtr, "output");
			CanvasSampleOpenFileText.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileText>.NativeClassPtr, 100663521);
			CanvasSampleOpenFileText.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileText>.NativeClassPtr, 100663522);
			CanvasSampleOpenFileText.NativeMethodInfoPtr_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileText>.NativeClassPtr, 100663523);
			CanvasSampleOpenFileText.NativeMethodInfoPtr_OutputRoutine_Private_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileText>.NativeClassPtr, 100663524);
			CanvasSampleOpenFileText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileText>.NativeClassPtr, 100663525);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0008144C File Offset: 0x0007F64C
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileText.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00081490 File Offset: 0x0007F690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67227, XrefRangeEnd = 67238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileText.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000814C4 File Offset: 0x0007F6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67238, XrefRangeEnd = 67260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileText.NativeMethodInfoPtr_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000814F8 File Offset: 0x0007F6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67260, XrefRangeEnd = 67266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OutputRoutine(string url)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileText.NativeMethodInfoPtr_OutputRoutine_Private_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00081548 File Offset: 0x0007F748
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanvasSampleOpenFileText() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasSampleOpenFileText>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002EC3 File Offset: 0x000010C3
		public CanvasSampleOpenFileText(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00081584 File Offset: 0x0007F784
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00002ECC File Offset: 0x000010CC
		public unsafe Text output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileText.NativeFieldInfoPtr_output);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileText.NativeFieldInfoPtr_output), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeFieldInfoPtr_output;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_OnClick_Private_Void_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_OutputRoutine_Private_IEnumerator_String_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000860 RID: 2144
		[ObfuscatedName("CanvasSampleOpenFileText+<OutputRoutine>d__4")]
		public sealed class _OutputRoutine_d__4 : Il2CppSystem.Object
		{
			// Token: 0x0600D02A RID: 53290 RVA: 0x0034476C File Offset: 0x0034296C
			// Note: this type is marked as 'beforefieldinit'.
			static _OutputRoutine_d__4()
			{
				Il2CppClassPointerStore<CanvasSampleOpenFileText._OutputRoutine_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanvasSampleOpenFileText>.NativeClassPtr, "<OutputRoutine>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasSampleOpenFileText._OutputRoutine_d__4>.NativeClassPtr);
				CanvasSampleOpenFileText._OutputRoutine_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasSampleOpenFileText._OutputRoutine_d__4>.NativeClassPtr, "<>1__state");
				CanvasSampleOpenFileText._OutputRoutine_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasSampleOpenFileText._OutputRoutine_d__4>.NativeClassPtr, "<>2__current");
				CanvasSampleOpenFileText._OutputRoutine_d__4.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasSampleOpenFileText._OutputRoutine_d__4>.NativeClassPtr, "url");
				CanvasSampleOpenFileText._OutputRoutine_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasSampleOpenFileText._OutputRoutine_d__4>.NativeClassPtr, "<>4__this");
				CanvasSampleOpenFileText._OutputRoutine_d__4.NativeFieldInfoPtr__loader_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasSampleOpenFileText._OutputRoutine_d__4>.NativeClassPtr, "<loader>5__2");
				CanvasSampleOpenFileText._OutputRoutine_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileText._OutputRoutine_d__4>.NativeClassPtr, 100663526);
				CanvasSampleOpenFileText._OutputRoutine_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileText._OutputRoutine_d__4>.NativeClassPtr, 100663527);
				CanvasSampleOpenFileText._OutputRoutine_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileText._OutputRoutine_d__4>.NativeClassPtr, 100663528);
				CanvasSampleOpenFileText._OutputRoutine_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileText._OutputRoutine_d__4>.NativeClassPtr, 100663529);
				CanvasSampleOpenFileText._OutputRoutine_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileText._OutputRoutine_d__4>.NativeClassPtr, 100663530);
				CanvasSampleOpenFileText._OutputRoutine_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileText._OutputRoutine_d__4>.NativeClassPtr, 100663531);
			}

			// Token: 0x0600D02B RID: 53291 RVA: 0x00344874 File Offset: 0x00342A74
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OutputRoutine_d__4(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasSampleOpenFileText._OutputRoutine_d__4>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileText._OutputRoutine_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D02C RID: 53292 RVA: 0x003448BC File Offset: 0x00342ABC
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileText._OutputRoutine_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D02D RID: 53293 RVA: 0x003448F0 File Offset: 0x00342AF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67216, XrefRangeEnd = 67222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileText._OutputRoutine_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F0B RID: 16139
			// (get) Token: 0x0600D02E RID: 53294 RVA: 0x0034492C File Offset: 0x00342B2C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileText._OutputRoutine_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D02F RID: 53295 RVA: 0x0034496C File Offset: 0x00342B6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67222, XrefRangeEnd = 67227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileText._OutputRoutine_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F0C RID: 16140
			// (get) Token: 0x0600D030 RID: 53296 RVA: 0x003449A0 File Offset: 0x00342BA0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileText._OutputRoutine_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D031 RID: 53297 RVA: 0x00062866 File Offset: 0x00060A66
			public _OutputRoutine_d__4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F06 RID: 16134
			// (get) Token: 0x0600D032 RID: 53298 RVA: 0x003449E0 File Offset: 0x00342BE0
			// (set) Token: 0x0600D033 RID: 53299 RVA: 0x0006286F File Offset: 0x00060A6F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileText._OutputRoutine_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileText._OutputRoutine_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F07 RID: 16135
			// (get) Token: 0x0600D034 RID: 53300 RVA: 0x00344A08 File Offset: 0x00342C08
			// (set) Token: 0x0600D035 RID: 53301 RVA: 0x0006288A File Offset: 0x00060A8A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileText._OutputRoutine_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileText._OutputRoutine_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F08 RID: 16136
			// (get) Token: 0x0600D036 RID: 53302 RVA: 0x00344A38 File Offset: 0x00342C38
			// (set) Token: 0x0600D037 RID: 53303 RVA: 0x000628A9 File Offset: 0x00060AA9
			public unsafe string url
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileText._OutputRoutine_d__4.NativeFieldInfoPtr_url);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileText._OutputRoutine_d__4.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F09 RID: 16137
			// (get) Token: 0x0600D038 RID: 53304 RVA: 0x00344A60 File Offset: 0x00342C60
			// (set) Token: 0x0600D039 RID: 53305 RVA: 0x000628C8 File Offset: 0x00060AC8
			public unsafe CanvasSampleOpenFileText __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileText._OutputRoutine_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasSampleOpenFileText>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileText._OutputRoutine_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F0A RID: 16138
			// (get) Token: 0x0600D03A RID: 53306 RVA: 0x00344A90 File Offset: 0x00342C90
			// (set) Token: 0x0600D03B RID: 53307 RVA: 0x000628E7 File Offset: 0x00060AE7
			public unsafe WWW _loader_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileText._OutputRoutine_d__4.NativeFieldInfoPtr__loader_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WWW>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileText._OutputRoutine_d__4.NativeFieldInfoPtr__loader_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DE5 RID: 36325
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008DE6 RID: 36326
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008DE7 RID: 36327
			private static readonly IntPtr NativeFieldInfoPtr_url;

			// Token: 0x04008DE8 RID: 36328
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008DE9 RID: 36329
			private static readonly IntPtr NativeFieldInfoPtr__loader_5__2;

			// Token: 0x04008DEA RID: 36330
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008DEB RID: 36331
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DEC RID: 36332
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008DED RID: 36333
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008DEE RID: 36334
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DEF RID: 36335
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
