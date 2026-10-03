using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x0200029B RID: 667
	public class LocalMultiplayerTool : MonoBehaviour
	{
		// Token: 0x060032A6 RID: 12966 RVA: 0x00122890 File Offset: 0x00120A90
		// Note: this type is marked as 'beforefieldinit'.
		static LocalMultiplayerTool()
		{
			Il2CppClassPointerStore<LocalMultiplayerTool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "LocalMultiplayerTool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalMultiplayerTool>.NativeClassPtr);
			LocalMultiplayerTool.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalMultiplayerTool>.NativeClassPtr, 100669620);
			LocalMultiplayerTool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalMultiplayerTool>.NativeClassPtr, 100669621);
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x001228E8 File Offset: 0x00120AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136915, XrefRangeEnd = 136933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalMultiplayerTool.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x0012291C File Offset: 0x00120B1C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalMultiplayerTool() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalMultiplayerTool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalMultiplayerTool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x0001A0E8 File Offset: 0x000182E8
		public LocalMultiplayerTool(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040021C1 RID: 8641
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040021C2 RID: 8642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
