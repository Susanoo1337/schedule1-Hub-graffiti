using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne
{
	// Token: 0x020000B6 RID: 182
	public class UISwitchInputModeDetector : MonoBehaviour
	{
		// Token: 0x0600107D RID: 4221 RVA: 0x000B24DC File Offset: 0x000B06DC
		// Note: this type is marked as 'beforefieldinit'.
		static UISwitchInputModeDetector()
		{
			Il2CppClassPointerStore<UISwitchInputModeDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UISwitchInputModeDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISwitchInputModeDetector>.NativeClassPtr);
			UISwitchInputModeDetector.NativeFieldInfoPtr_OnInputModeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISwitchInputModeDetector>.NativeClassPtr, "OnInputModeChanged");
			UISwitchInputModeDetector.NativeFieldInfoPtr_OnInputModeChangedToController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISwitchInputModeDetector>.NativeClassPtr, "OnInputModeChangedToController");
			UISwitchInputModeDetector.NativeFieldInfoPtr_OnInputModeChangedToMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISwitchInputModeDetector>.NativeClassPtr, "OnInputModeChangedToMouse");
			UISwitchInputModeDetector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISwitchInputModeDetector>.NativeClassPtr, 100665386);
			UISwitchInputModeDetector.NativeMethodInfoPtr_OnControlsChanged_Private_Void_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISwitchInputModeDetector>.NativeClassPtr, 100665387);
			UISwitchInputModeDetector.NativeMethodInfoPtr_SwitchMode_Private_Void_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISwitchInputModeDetector>.NativeClassPtr, 100665388);
			UISwitchInputModeDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISwitchInputModeDetector>.NativeClassPtr, 100665389);
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x000B2598 File Offset: 0x000B0798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85005, XrefRangeEnd = 85030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISwitchInputModeDetector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x000B25CC File Offset: 0x000B07CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85030, XrefRangeEnd = 85033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnControlsChanged(GameInput.InputDeviceType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISwitchInputModeDetector.NativeMethodInfoPtr_OnControlsChanged_Private_Void_InputDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x000B260C File Offset: 0x000B080C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85033, XrefRangeEnd = 85035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchMode(GameInput.InputDeviceType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISwitchInputModeDetector.NativeMethodInfoPtr_SwitchMode_Private_Void_InputDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x000B264C File Offset: 0x000B084C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISwitchInputModeDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISwitchInputModeDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISwitchInputModeDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x000099F6 File Offset: 0x00007BF6
		public UISwitchInputModeDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001083 RID: 4227 RVA: 0x000B2688 File Offset: 0x000B0888
		// (set) Token: 0x06001084 RID: 4228 RVA: 0x000099FF File Offset: 0x00007BFF
		public unsafe UnityEvent OnInputModeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISwitchInputModeDetector.NativeFieldInfoPtr_OnInputModeChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISwitchInputModeDetector.NativeFieldInfoPtr_OnInputModeChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001085 RID: 4229 RVA: 0x000B26B8 File Offset: 0x000B08B8
		// (set) Token: 0x06001086 RID: 4230 RVA: 0x00009A1E File Offset: 0x00007C1E
		public unsafe UnityEvent OnInputModeChangedToController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISwitchInputModeDetector.NativeFieldInfoPtr_OnInputModeChangedToController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISwitchInputModeDetector.NativeFieldInfoPtr_OnInputModeChangedToController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001087 RID: 4231 RVA: 0x000B26E8 File Offset: 0x000B08E8
		// (set) Token: 0x06001088 RID: 4232 RVA: 0x00009A3D File Offset: 0x00007C3D
		public unsafe UnityEvent OnInputModeChangedToMouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISwitchInputModeDetector.NativeFieldInfoPtr_OnInputModeChangedToMouse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISwitchInputModeDetector.NativeFieldInfoPtr_OnInputModeChangedToMouse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeFieldInfoPtr_OnInputModeChanged;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeFieldInfoPtr_OnInputModeChangedToController;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeFieldInfoPtr_OnInputModeChangedToMouse;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr_OnControlsChanged_Private_Void_InputDeviceType_0;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr_SwitchMode_Private_Void_InputDeviceType_0;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
