using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Il2Cpp
{
	// Token: 0x02000006 RID: 6
	public class EventTriggerContact : MonoBehaviour
	{
		// Token: 0x0600003D RID: 61 RVA: 0x0007C360 File Offset: 0x0007A560
		// Note: this type is marked as 'beforefieldinit'.
		static EventTriggerContact()
		{
			Il2CppClassPointerStore<EventTriggerContact>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "EventTriggerContact");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventTriggerContact>.NativeClassPtr);
			EventTriggerContact.NativeFieldInfoPtr_selectedImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTriggerContact>.NativeClassPtr, "selectedImage");
			EventTriggerContact.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTriggerContact>.NativeClassPtr, 100663311);
			EventTriggerContact.NativeMethodInfoPtr_TestFunc_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTriggerContact>.NativeClassPtr, 100663312);
			EventTriggerContact.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTriggerContact>.NativeClassPtr, 100663313);
			EventTriggerContact.NativeMethodInfoPtr__Awake_b__1_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTriggerContact>.NativeClassPtr, 100663314);
			EventTriggerContact.NativeMethodInfoPtr__Awake_b__1_1_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTriggerContact>.NativeClassPtr, 100663315);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0007C408 File Offset: 0x0007A608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64881, XrefRangeEnd = 64924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventTriggerContact.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0007C43C File Offset: 0x0007A63C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 64930, RefRangeEnd = 64932, XrefRangeStart = 64924, XrefRangeEnd = 64930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TestFunc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventTriggerContact.NativeMethodInfoPtr_TestFunc_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0007C470 File Offset: 0x0007A670
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventTriggerContact() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventTriggerContact>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventTriggerContact.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0007C4AC File Offset: 0x0007A6AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64932, XrefRangeEnd = 64933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__1_0(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventTriggerContact.NativeMethodInfoPtr__Awake_b__1_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0007C4F0 File Offset: 0x0007A6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__1_1(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventTriggerContact.NativeMethodInfoPtr__Awake_b__1_1_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000022A1 File Offset: 0x000004A1
		public EventTriggerContact(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0007C534 File Offset: 0x0007A734
		// (set) Token: 0x06000045 RID: 69 RVA: 0x000022AA File Offset: 0x000004AA
		public unsafe GameObject selectedImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventTriggerContact.NativeFieldInfoPtr_selectedImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventTriggerContact.NativeFieldInfoPtr_selectedImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_selectedImage;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_TestFunc_Public_Void_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__1_0_Private_Void_BaseEventData_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__1_1_Private_Void_BaseEventData_0;
	}
}
