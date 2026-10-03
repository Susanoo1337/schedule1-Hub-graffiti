using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020001FF RID: 511
	[Serializable]
	public class AvatarAppearanceData : SaveData
	{
		// Token: 0x06002D89 RID: 11657 RVA: 0x00113324 File Offset: 0x00111524
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarAppearanceData()
		{
			Il2CppClassPointerStore<AvatarAppearanceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "AvatarAppearanceData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarAppearanceData>.NativeClassPtr);
			AvatarAppearanceData.NativeFieldInfoPtr_AvatarSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarAppearanceData>.NativeClassPtr, "AvatarSettings");
			AvatarAppearanceData.NativeMethodInfoPtr__ctor_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarAppearanceData>.NativeClassPtr, 100669313);
		}

		// Token: 0x06002D8A RID: 11658 RVA: 0x0011337C File Offset: 0x0011157C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 134314, RefRangeEnd = 134323, XrefRangeStart = 134312, XrefRangeEnd = 134314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarAppearanceData(AvatarSettings avatarSettings) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarAppearanceData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(avatarSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarAppearanceData.NativeMethodInfoPtr__ctor_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x00016FE9 File Offset: 0x000151E9
		public AvatarAppearanceData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06002D8C RID: 11660 RVA: 0x001133C8 File Offset: 0x001115C8
		// (set) Token: 0x06002D8D RID: 11661 RVA: 0x00016FF2 File Offset: 0x000151F2
		public unsafe AvatarSettings AvatarSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAppearanceData.NativeFieldInfoPtr_AvatarSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarAppearanceData.NativeFieldInfoPtr_AvatarSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F37 RID: 7991
		private static readonly IntPtr NativeFieldInfoPtr_AvatarSettings;

		// Token: 0x04001F38 RID: 7992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AvatarSettings_0;
	}
}
