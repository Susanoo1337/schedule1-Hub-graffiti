using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppScheduleOne
{
	// Token: 0x02000099 RID: 153
	public class InputDescriptor : MonoBehaviour
	{
		// Token: 0x06000D32 RID: 3378 RVA: 0x000A7700 File Offset: 0x000A5900
		// Note: this type is marked as 'beforefieldinit'.
		static InputDescriptor()
		{
			Il2CppClassPointerStore<InputDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "InputDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDescriptor>.NativeClassPtr);
			InputDescriptor.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDescriptor>.NativeClassPtr, "data");
			InputDescriptor.NativeFieldInfoPtr_uiTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDescriptor>.NativeClassPtr, "uiTrigger");
			InputDescriptor.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDescriptor>.NativeClassPtr, 100664974);
			InputDescriptor.NativeMethodInfoPtr_DetectTriggerInput_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDescriptor>.NativeClassPtr, 100664975);
			InputDescriptor.NativeMethodInfoPtr_OnReset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDescriptor>.NativeClassPtr, 100664976);
			InputDescriptor.NativeMethodInfoPtr_GetInputTriggered_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDescriptor>.NativeClassPtr, 100664977);
			InputDescriptor.NativeMethodInfoPtr_GetInputValue_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDescriptor>.NativeClassPtr, 100664978);
			InputDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDescriptor>.NativeClassPtr, 100664979);
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x000A77D0 File Offset: 0x000A59D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79579, XrefRangeEnd = 79604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDescriptor.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x000A7804 File Offset: 0x000A5A04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79605, RefRangeEnd = 79606, XrefRangeStart = 79604, XrefRangeEnd = 79605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetectTriggerInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDescriptor.NativeMethodInfoPtr_DetectTriggerInput_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x000A7838 File Offset: 0x000A5A38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79607, RefRangeEnd = 79609, XrefRangeStart = 79606, XrefRangeEnd = 79607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnReset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDescriptor.NativeMethodInfoPtr_OnReset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x000A786C File Offset: 0x000A5A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79609, XrefRangeEnd = 79612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetInputTriggered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDescriptor.NativeMethodInfoPtr_GetInputTriggered_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x000A78A8 File Offset: 0x000A5AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79612, XrefRangeEnd = 79616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetInputValue<T>() where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDescriptor.MethodInfoStoreGeneric_GetInputValue_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x000A78E4 File Offset: 0x000A5AE4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputDescriptor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x000080B4 File Offset: 0x000062B4
		public InputDescriptor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x000A7920 File Offset: 0x000A5B20
		// (set) Token: 0x06000D3B RID: 3387 RVA: 0x000080BD File Offset: 0x000062BD
		public unsafe InputDescriptorData data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDescriptor.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDescriptorData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDescriptor.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x000A7950 File Offset: 0x000A5B50
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x000080DC File Offset: 0x000062DC
		public unsafe UITrigger uiTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDescriptor.NativeFieldInfoPtr_uiTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UITrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDescriptor.NativeFieldInfoPtr_uiTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeFieldInfoPtr_uiTrigger;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeMethodInfoPtr_DetectTriggerInput_Public_Void_0;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr_OnReset_Public_Void_0;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeMethodInfoPtr_GetInputTriggered_Public_Boolean_0;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr_GetInputValue_Public_T_0;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008B0 RID: 2224
		private sealed class MethodInfoStoreGeneric_GetInputValue_Public_T_0<T>
		{
			// Token: 0x0400906C RID: 36972
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(InputDescriptor.NativeMethodInfoPtr_GetInputValue_Public_T_0, Il2CppClassPointerStore<InputDescriptor>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
