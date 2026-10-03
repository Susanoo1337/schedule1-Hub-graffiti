using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne
{
	// Token: 0x0200009A RID: 154
	public class InputDescriptorData : ScriptableObject
	{
		// Token: 0x06000D3E RID: 3390 RVA: 0x000A7980 File Offset: 0x000A5B80
		// Note: this type is marked as 'beforefieldinit'.
		static InputDescriptorData()
		{
			Il2CppClassPointerStore<InputDescriptorData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "InputDescriptorData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDescriptorData>.NativeClassPtr);
			InputDescriptorData.NativeFieldInfoPtr_inputActionReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDescriptorData>.NativeClassPtr, "inputActionReference");
			InputDescriptorData.NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDescriptorData>.NativeClassPtr, "displayName");
			InputDescriptorData.NativeMethodInfoPtr_get_InputActionReference_Public_get_InputActionReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDescriptorData>.NativeClassPtr, 100664980);
			InputDescriptorData.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDescriptorData>.NativeClassPtr, 100664981);
			InputDescriptorData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDescriptorData>.NativeClassPtr, 100664982);
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x000A7A14 File Offset: 0x000A5C14
		public unsafe InputActionReference InputActionReference
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDescriptorData.NativeMethodInfoPtr_get_InputActionReference_Public_get_InputActionReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr3) : null;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x000A7A54 File Offset: 0x000A5C54
		public unsafe string DisplayName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDescriptorData.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x000A7A8C File Offset: 0x000A5C8C
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 79617, RefRangeEnd = 79648, XrefRangeStart = 79616, XrefRangeEnd = 79617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputDescriptorData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDescriptorData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDescriptorData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x000080FB File Offset: 0x000062FB
		public InputDescriptorData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x000A7AC8 File Offset: 0x000A5CC8
		// (set) Token: 0x06000D44 RID: 3396 RVA: 0x00008104 File Offset: 0x00006304
		public unsafe InputActionReference inputActionReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDescriptorData.NativeFieldInfoPtr_inputActionReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDescriptorData.NativeFieldInfoPtr_inputActionReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x000A7AF8 File Offset: 0x000A5CF8
		// (set) Token: 0x06000D46 RID: 3398 RVA: 0x00008123 File Offset: 0x00006323
		public unsafe string displayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDescriptorData.NativeFieldInfoPtr_displayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDescriptorData.NativeFieldInfoPtr_displayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeFieldInfoPtr_inputActionReference;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeFieldInfoPtr_displayName;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeMethodInfoPtr_get_InputActionReference_Public_get_InputActionReference_0;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_String_0;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
