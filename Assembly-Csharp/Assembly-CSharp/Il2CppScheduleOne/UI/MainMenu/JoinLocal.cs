using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020007F7 RID: 2039
	public class JoinLocal : MonoBehaviour
	{
		// Token: 0x0600C684 RID: 50820 RVA: 0x00324A18 File Offset: 0x00322C18
		// Note: this type is marked as 'beforefieldinit'.
		static JoinLocal()
		{
			Il2CppClassPointerStore<JoinLocal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "JoinLocal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinLocal>.NativeClassPtr);
			JoinLocal.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLocal>.NativeClassPtr, 100689011);
			JoinLocal.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLocal>.NativeClassPtr, 100689012);
			JoinLocal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLocal>.NativeClassPtr, 100689013);
		}

		// Token: 0x0600C685 RID: 50821 RVA: 0x00324A84 File Offset: 0x00322C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327809, XrefRangeEnd = 327821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinLocal.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C686 RID: 50822 RVA: 0x00324AB8 File Offset: 0x00322CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327821, XrefRangeEnd = 327829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinLocal.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C687 RID: 50823 RVA: 0x00324AEC File Offset: 0x00322CEC
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JoinLocal() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoinLocal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinLocal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C688 RID: 50824 RVA: 0x0005DBA0 File Offset: 0x0005BDA0
		public JoinLocal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04008767 RID: 34663
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04008768 RID: 34664
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x04008769 RID: 34665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
