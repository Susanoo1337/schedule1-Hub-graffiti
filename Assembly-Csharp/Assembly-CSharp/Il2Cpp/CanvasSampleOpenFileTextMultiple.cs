using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2Cpp
{
	// Token: 0x02000027 RID: 39
	public class CanvasSampleOpenFileTextMultiple : MonoBehaviour
	{
		// Token: 0x060001DD RID: 477 RVA: 0x000815B4 File Offset: 0x0007F7B4
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasSampleOpenFileTextMultiple()
		{
			Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CanvasSampleOpenFileTextMultiple");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple>.NativeClassPtr);
			CanvasSampleOpenFileTextMultiple.NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple>.NativeClassPtr, "output");
			CanvasSampleOpenFileTextMultiple.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple>.NativeClassPtr, 100663532);
			CanvasSampleOpenFileTextMultiple.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple>.NativeClassPtr, 100663533);
			CanvasSampleOpenFileTextMultiple.NativeMethodInfoPtr_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple>.NativeClassPtr, 100663534);
			CanvasSampleOpenFileTextMultiple.NativeMethodInfoPtr_OutputRoutine_Private_IEnumerator_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple>.NativeClassPtr, 100663535);
			CanvasSampleOpenFileTextMultiple.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple>.NativeClassPtr, 100663536);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0008165C File Offset: 0x0007F85C
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileTextMultiple.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000816A0 File Offset: 0x0007F8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67286, XrefRangeEnd = 67297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileTextMultiple.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000816D4 File Offset: 0x0007F8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67297, XrefRangeEnd = 67332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileTextMultiple.NativeMethodInfoPtr_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00081708 File Offset: 0x0007F908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67332, XrefRangeEnd = 67338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OutputRoutine(Il2CppStringArray urlArr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(urlArr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileTextMultiple.NativeMethodInfoPtr_OutputRoutine_Private_IEnumerator_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00081758 File Offset: 0x0007F958
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanvasSampleOpenFileTextMultiple() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileTextMultiple.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002EEB File Offset: 0x000010EB
		public CanvasSampleOpenFileTextMultiple(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00081794 File Offset: 0x0007F994
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00002EF4 File Offset: 0x000010F4
		public unsafe Text output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileTextMultiple.NativeFieldInfoPtr_output);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileTextMultiple.NativeFieldInfoPtr_output), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeFieldInfoPtr_output;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_OnClick_Private_Void_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_OutputRoutine_Private_IEnumerator_Il2CppStringArray_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000861 RID: 2145
		[ObfuscatedName("CanvasSampleOpenFileTextMultiple+<OutputRoutine>d__4")]
		public sealed class _OutputRoutine_d__4 : Il2CppSystem.Object
		{
			// Token: 0x0600D03C RID: 53308 RVA: 0x00344AC0 File Offset: 0x00342CC0
			// Note: this type is marked as 'beforefieldinit'.
			static _OutputRoutine_d__4()
			{
				Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple>.NativeClassPtr, "<OutputRoutine>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4>.NativeClassPtr);
				CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4>.NativeClassPtr, "<>1__state");
				CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4>.NativeClassPtr, "<>2__current");
				CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeFieldInfoPtr_urlArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4>.NativeClassPtr, "urlArr");
				CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4>.NativeClassPtr, "<>4__this");
				CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeFieldInfoPtr__outputText_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4>.NativeClassPtr, "<outputText>5__2");
				CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4>.NativeClassPtr, "<i>5__3");
				CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeFieldInfoPtr__loader_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4>.NativeClassPtr, "<loader>5__4");
				CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4>.NativeClassPtr, 100663537);
				CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4>.NativeClassPtr, 100663538);
				CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4>.NativeClassPtr, 100663539);
				CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4>.NativeClassPtr, 100663540);
				CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4>.NativeClassPtr, 100663541);
				CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4>.NativeClassPtr, 100663542);
			}

			// Token: 0x0600D03D RID: 53309 RVA: 0x00344BF0 File Offset: 0x00342DF0
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OutputRoutine_d__4(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D03E RID: 53310 RVA: 0x00344C38 File Offset: 0x00342E38
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D03F RID: 53311 RVA: 0x00344C6C File Offset: 0x00342E6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67266, XrefRangeEnd = 67281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F14 RID: 16148
			// (get) Token: 0x0600D040 RID: 53312 RVA: 0x00344CA8 File Offset: 0x00342EA8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D041 RID: 53313 RVA: 0x00344CE8 File Offset: 0x00342EE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67281, XrefRangeEnd = 67286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F15 RID: 16149
			// (get) Token: 0x0600D042 RID: 53314 RVA: 0x00344D1C File Offset: 0x00342F1C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D043 RID: 53315 RVA: 0x00062906 File Offset: 0x00060B06
			public _OutputRoutine_d__4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F0D RID: 16141
			// (get) Token: 0x0600D044 RID: 53316 RVA: 0x00344D5C File Offset: 0x00342F5C
			// (set) Token: 0x0600D045 RID: 53317 RVA: 0x0006290F File Offset: 0x00060B0F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F0E RID: 16142
			// (get) Token: 0x0600D046 RID: 53318 RVA: 0x00344D84 File Offset: 0x00342F84
			// (set) Token: 0x0600D047 RID: 53319 RVA: 0x0006292A File Offset: 0x00060B2A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F0F RID: 16143
			// (get) Token: 0x0600D048 RID: 53320 RVA: 0x00344DB4 File Offset: 0x00342FB4
			// (set) Token: 0x0600D049 RID: 53321 RVA: 0x00062949 File Offset: 0x00060B49
			public unsafe Il2CppStringArray urlArr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeFieldInfoPtr_urlArr);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeFieldInfoPtr_urlArr), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F10 RID: 16144
			// (get) Token: 0x0600D04A RID: 53322 RVA: 0x00344DE4 File Offset: 0x00342FE4
			// (set) Token: 0x0600D04B RID: 53323 RVA: 0x00062968 File Offset: 0x00060B68
			public unsafe CanvasSampleOpenFileTextMultiple __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasSampleOpenFileTextMultiple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F11 RID: 16145
			// (get) Token: 0x0600D04C RID: 53324 RVA: 0x00344E14 File Offset: 0x00343014
			// (set) Token: 0x0600D04D RID: 53325 RVA: 0x00062987 File Offset: 0x00060B87
			public unsafe string _outputText_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeFieldInfoPtr__outputText_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeFieldInfoPtr__outputText_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F12 RID: 16146
			// (get) Token: 0x0600D04E RID: 53326 RVA: 0x00344E3C File Offset: 0x0034303C
			// (set) Token: 0x0600D04F RID: 53327 RVA: 0x000629A6 File Offset: 0x00060BA6
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x17003F13 RID: 16147
			// (get) Token: 0x0600D050 RID: 53328 RVA: 0x00344E64 File Offset: 0x00343064
			// (set) Token: 0x0600D051 RID: 53329 RVA: 0x000629C1 File Offset: 0x00060BC1
			public unsafe WWW _loader_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeFieldInfoPtr__loader_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WWW>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasSampleOpenFileTextMultiple._OutputRoutine_d__4.NativeFieldInfoPtr__loader_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DF0 RID: 36336
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008DF1 RID: 36337
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008DF2 RID: 36338
			private static readonly IntPtr NativeFieldInfoPtr_urlArr;

			// Token: 0x04008DF3 RID: 36339
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008DF4 RID: 36340
			private static readonly IntPtr NativeFieldInfoPtr__outputText_5__2;

			// Token: 0x04008DF5 RID: 36341
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04008DF6 RID: 36342
			private static readonly IntPtr NativeFieldInfoPtr__loader_5__4;

			// Token: 0x04008DF7 RID: 36343
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008DF8 RID: 36344
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DF9 RID: 36345
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008DFA RID: 36346
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008DFB RID: 36347
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DFC RID: 36348
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
