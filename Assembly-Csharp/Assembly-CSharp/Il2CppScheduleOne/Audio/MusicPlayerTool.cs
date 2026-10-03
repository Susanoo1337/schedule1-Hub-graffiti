using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x0200047A RID: 1146
	public class MusicPlayerTool : MonoBehaviour
	{
		// Token: 0x0600677E RID: 26494 RVA: 0x001E145C File Offset: 0x001DF65C
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerTool()
		{
			Il2CppClassPointerStore<MusicPlayerTool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "MusicPlayerTool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerTool>.NativeClassPtr);
			MusicPlayerTool.NativeMethodInfoPtr_PlayTrack_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerTool>.NativeClassPtr, 100676828);
			MusicPlayerTool.NativeMethodInfoPtr_StopTracks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerTool>.NativeClassPtr, 100676829);
			MusicPlayerTool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerTool>.NativeClassPtr, 100676830);
		}

		// Token: 0x0600677F RID: 26495 RVA: 0x001E14C8 File Offset: 0x001DF6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215162, XrefRangeEnd = 215186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayTrack(string trackName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trackName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerTool.NativeMethodInfoPtr_PlayTrack_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006780 RID: 26496 RVA: 0x001E150C File Offset: 0x001DF70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215186, XrefRangeEnd = 215192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopTracks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerTool.NativeMethodInfoPtr_StopTracks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006781 RID: 26497 RVA: 0x001E1540 File Offset: 0x001DF740
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicPlayerTool() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicPlayerTool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerTool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006782 RID: 26498 RVA: 0x00030CA1 File Offset: 0x0002EEA1
		public MusicPlayerTool(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004737 RID: 18231
		private static readonly IntPtr NativeMethodInfoPtr_PlayTrack_Public_Void_String_0;

		// Token: 0x04004738 RID: 18232
		private static readonly IntPtr NativeMethodInfoPtr_StopTracks_Public_Void_0;

		// Token: 0x04004739 RID: 18233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
