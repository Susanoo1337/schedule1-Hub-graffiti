using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSFB
{
	// Token: 0x0200007E RID: 126
	public class WindowWrapper : Object
	{
		// Token: 0x06000958 RID: 2392 RVA: 0x00099C80 File Offset: 0x00097E80
		// Note: this type is marked as 'beforefieldinit'.
		static WindowWrapper()
		{
			Il2CppClassPointerStore<WindowWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SFB", "WindowWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowWrapper>.NativeClassPtr);
			WindowWrapper.NativeFieldInfoPtr__hwnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowWrapper>.NativeClassPtr, "_hwnd");
			WindowWrapper.NativeMethodInfoPtr_get_Handle_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowWrapper>.NativeClassPtr, 100664496);
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x00099CD8 File Offset: 0x00097ED8
		public unsafe virtual IntPtr Handle
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 3712, RefRangeEnd = 3724, XrefRangeStart = 3712, XrefRangeEnd = 3724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowWrapper.NativeMethodInfoPtr_get_Handle_Public_Virtual_Final_New_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x000064DE File Offset: 0x000046DE
		public WindowWrapper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x00099D14 File Offset: 0x00097F14
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x000064E7 File Offset: 0x000046E7
		public unsafe IntPtr _hwnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowWrapper.NativeFieldInfoPtr__hwnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowWrapper.NativeFieldInfoPtr__hwnd)) = value;
			}
		}

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeFieldInfoPtr__hwnd;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_Virtual_Final_New_get_IntPtr_0;
	}
}
