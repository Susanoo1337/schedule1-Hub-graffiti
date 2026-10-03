using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

namespace Il2Cpp
{
	// Token: 0x02000002 RID: 2
	public class VirtualMouseDebugger : MonoBehaviour
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0007B98C File Offset: 0x00079B8C
		// Note: this type is marked as 'beforefieldinit'.
		static VirtualMouseDebugger()
		{
			Il2CppClassPointerStore<VirtualMouseDebugger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "VirtualMouseDebugger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VirtualMouseDebugger>.NativeClassPtr);
			VirtualMouseDebugger.NativeFieldInfoPtr_msg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseDebugger>.NativeClassPtr, "msg");
			VirtualMouseDebugger.NativeFieldInfoPtr_vmi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseDebugger>.NativeClassPtr, "vmi");
			VirtualMouseDebugger.NativeFieldInfoPtr_systemMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseDebugger>.NativeClassPtr, "systemMouse");
			VirtualMouseDebugger.NativeFieldInfoPtr_virtualMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseDebugger>.NativeClassPtr, "virtualMouse");
			VirtualMouseDebugger.NativeFieldInfoPtr_sb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseDebugger>.NativeClassPtr, "sb");
			VirtualMouseDebugger.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseDebugger>.NativeClassPtr, 100663297);
			VirtualMouseDebugger.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseDebugger>.NativeClassPtr, 100663298);
			VirtualMouseDebugger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseDebugger>.NativeClassPtr, 100663299);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0007BA5C File Offset: 0x00079C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64731, XrefRangeEnd = 64746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VirtualMouseDebugger.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0007BA90 File Offset: 0x00079C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64746, XrefRangeEnd = 64806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VirtualMouseDebugger.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0007BAC4 File Offset: 0x00079CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64806, XrefRangeEnd = 64812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VirtualMouseDebugger() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VirtualMouseDebugger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VirtualMouseDebugger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		public VirtualMouseDebugger(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0007BB00 File Offset: 0x00079D00
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe TMP_Text msg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualMouseDebugger.NativeFieldInfoPtr_msg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualMouseDebugger.NativeFieldInfoPtr_msg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0007BB30 File Offset: 0x00079D30
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002078 File Offset: 0x00000278
		public unsafe VirtualMouseInput vmi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualMouseDebugger.NativeFieldInfoPtr_vmi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VirtualMouseInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualMouseDebugger.NativeFieldInfoPtr_vmi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0007BB60 File Offset: 0x00079D60
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002097 File Offset: 0x00000297
		public unsafe Mouse systemMouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualMouseDebugger.NativeFieldInfoPtr_systemMouse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mouse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualMouseDebugger.NativeFieldInfoPtr_systemMouse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0007BB90 File Offset: 0x00079D90
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000020B6 File Offset: 0x000002B6
		public unsafe Mouse virtualMouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualMouseDebugger.NativeFieldInfoPtr_virtualMouse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mouse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualMouseDebugger.NativeFieldInfoPtr_virtualMouse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0007BBC0 File Offset: 0x00079DC0
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000020D5 File Offset: 0x000002D5
		public unsafe StringBuilder sb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualMouseDebugger.NativeFieldInfoPtr_sb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VirtualMouseDebugger.NativeFieldInfoPtr_sb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_msg;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_vmi;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_systemMouse;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_virtualMouse;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_sb;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
