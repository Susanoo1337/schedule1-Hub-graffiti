using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x0200032C RID: 812
	public class PlayerTeleporter : MonoBehaviour
	{
		// Token: 0x06004510 RID: 17680 RVA: 0x00166C08 File Offset: 0x00164E08
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerTeleporter()
		{
			Il2CppClassPointerStore<PlayerTeleporter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerTeleporter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTeleporter>.NativeClassPtr);
			PlayerTeleporter.NativeMethodInfoPtr_Teleport_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleporter>.NativeClassPtr, 100672236);
			PlayerTeleporter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTeleporter>.NativeClassPtr, 100672237);
		}

		// Token: 0x06004511 RID: 17681 RVA: 0x00166C60 File Offset: 0x00164E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164324, XrefRangeEnd = 164343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Teleport(Transform destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTeleporter.NativeMethodInfoPtr_Teleport_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004512 RID: 17682 RVA: 0x00166CA4 File Offset: 0x00164EA4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerTeleporter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTeleporter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTeleporter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004513 RID: 17683 RVA: 0x0002196E File Offset: 0x0001FB6E
		public PlayerTeleporter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002F11 RID: 12049
		private static readonly IntPtr NativeMethodInfoPtr_Teleport_Public_Void_Transform_0;

		// Token: 0x04002F12 RID: 12050
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
