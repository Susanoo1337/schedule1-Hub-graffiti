using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000506 RID: 1286
	public class InputFieldAttachment : MonoBehaviour
	{
		// Token: 0x060073C9 RID: 29641 RVA: 0x002073E8 File Offset: 0x002055E8
		// Note: this type is marked as 'beforefieldinit'.
		static InputFieldAttachment()
		{
			Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "InputFieldAttachment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr);
			InputFieldAttachment.NativeFieldInfoPtr__isTyping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, "_isTyping");
			InputFieldAttachment.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, 100678237);
			InputFieldAttachment.NativeMethodInfoPtr_EditStart_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, 100678238);
			InputFieldAttachment.NativeMethodInfoPtr_EndEdit_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, 100678239);
			InputFieldAttachment.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, 100678240);
			InputFieldAttachment.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, 100678241);
			InputFieldAttachment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, 100678242);
		}

		// Token: 0x060073CA RID: 29642 RVA: 0x002074A4 File Offset: 0x002056A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227679, XrefRangeEnd = 227760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073CB RID: 29643 RVA: 0x002074D8 File Offset: 0x002056D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227760, XrefRangeEnd = 227773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EditStart(string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.NativeMethodInfoPtr_EditStart_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073CC RID: 29644 RVA: 0x0020751C File Offset: 0x0020571C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227773, XrefRangeEnd = 227781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndEdit(string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.NativeMethodInfoPtr_EndEdit_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073CD RID: 29645 RVA: 0x00207560 File Offset: 0x00205760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227781, XrefRangeEnd = 227788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073CE RID: 29646 RVA: 0x00207594 File Offset: 0x00205794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227788, XrefRangeEnd = 227795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073CF RID: 29647 RVA: 0x002075C8 File Offset: 0x002057C8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputFieldAttachment() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073D0 RID: 29648 RVA: 0x000371C5 File Offset: 0x000353C5
		public InputFieldAttachment(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023B4 RID: 9140
		// (get) Token: 0x060073D1 RID: 29649 RVA: 0x00207604 File Offset: 0x00205804
		// (set) Token: 0x060073D2 RID: 29650 RVA: 0x000371CE File Offset: 0x000353CE
		public unsafe bool _isTyping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldAttachment.NativeFieldInfoPtr__isTyping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldAttachment.NativeFieldInfoPtr__isTyping)) = value;
			}
		}

		// Token: 0x04004EF3 RID: 20211
		private static readonly IntPtr NativeFieldInfoPtr__isTyping;

		// Token: 0x04004EF4 RID: 20212
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004EF5 RID: 20213
		private static readonly IntPtr NativeMethodInfoPtr_EditStart_Private_Void_String_0;

		// Token: 0x04004EF6 RID: 20214
		private static readonly IntPtr NativeMethodInfoPtr_EndEdit_Private_Void_String_0;

		// Token: 0x04004EF7 RID: 20215
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04004EF8 RID: 20216
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04004EF9 RID: 20217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BA5 RID: 2981
		[ObfuscatedName("ScheduleOne.Tools.InputFieldAttachment+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EA6A RID: 60010 RVA: 0x0038F354 File Offset: 0x0038D554
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass1_0>.NativeClassPtr);
				InputFieldAttachment.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
				InputFieldAttachment.__c__DisplayClass1_0.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass1_0>.NativeClassPtr, "inputField");
				InputFieldAttachment.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass1_0>.NativeClassPtr, 100678243);
				InputFieldAttachment.__c__DisplayClass1_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass1_0>.NativeClassPtr, 100678244);
				InputFieldAttachment.__c__DisplayClass1_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass1_0>.NativeClassPtr, 100678245);
			}

			// Token: 0x0600EA6B RID: 60011 RVA: 0x0038F3E4 File Offset: 0x0038D5E4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA6C RID: 60012 RVA: 0x0038F420 File Offset: 0x0038D620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227659, XrefRangeEnd = 227672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.__c__DisplayClass1_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA6D RID: 60013 RVA: 0x0038F464 File Offset: 0x0038D664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227672, XrefRangeEnd = 227679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__1(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.__c__DisplayClass1_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA6E RID: 60014 RVA: 0x0006E92F File Offset: 0x0006CB2F
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700471A RID: 18202
			// (get) Token: 0x0600EA6F RID: 60015 RVA: 0x0038F4A8 File Offset: 0x0038D6A8
			// (set) Token: 0x0600EA70 RID: 60016 RVA: 0x0006E938 File Offset: 0x0006CB38
			public unsafe InputFieldAttachment __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldAttachment.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputFieldAttachment>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldAttachment.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700471B RID: 18203
			// (get) Token: 0x0600EA71 RID: 60017 RVA: 0x0038F4D8 File Offset: 0x0038D6D8
			// (set) Token: 0x0600EA72 RID: 60018 RVA: 0x0006E957 File Offset: 0x0006CB57
			public unsafe InputField inputField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldAttachment.__c__DisplayClass1_0.NativeFieldInfoPtr_inputField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldAttachment.__c__DisplayClass1_0.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009EE3 RID: 40675
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009EE4 RID: 40676
			private static readonly IntPtr NativeFieldInfoPtr_inputField;

			// Token: 0x04009EE5 RID: 40677
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009EE6 RID: 40678
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_BaseEventData_0;

			// Token: 0x04009EE7 RID: 40679
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__1_Internal_Void_BaseEventData_0;
		}
	}
}
