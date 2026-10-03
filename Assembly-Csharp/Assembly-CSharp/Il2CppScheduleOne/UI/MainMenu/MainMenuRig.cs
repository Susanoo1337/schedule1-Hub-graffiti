using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.AvatarFramework.Customization;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020007FA RID: 2042
	public class MainMenuRig : MonoBehaviour
	{
		// Token: 0x0600C69C RID: 50844 RVA: 0x00324EE0 File Offset: 0x003230E0
		// Note: this type is marked as 'beforefieldinit'.
		static MainMenuRig()
		{
			Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "MainMenuRig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr);
			MainMenuRig.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, "Avatar");
			MainMenuRig.NativeFieldInfoPtr_DefaultSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, "DefaultSettings");
			MainMenuRig.NativeFieldInfoPtr_CashPiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, "CashPiles");
			MainMenuRig.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, 100689022);
			MainMenuRig.NativeMethodInfoPtr_LoadStuff_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, 100689023);
			MainMenuRig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, 100689024);
		}

		// Token: 0x0600C69D RID: 50845 RVA: 0x00324F88 File Offset: 0x00323188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327863, XrefRangeEnd = 327875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuRig.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C69E RID: 50846 RVA: 0x00324FBC File Offset: 0x003231BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327875, XrefRangeEnd = 327916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadStuff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuRig.NativeMethodInfoPtr_LoadStuff_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C69F RID: 50847 RVA: 0x00324FF0 File Offset: 0x003231F0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MainMenuRig() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuRig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C6A0 RID: 50848 RVA: 0x0005DC37 File Offset: 0x0005BE37
		public MainMenuRig(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C44 RID: 15428
		// (get) Token: 0x0600C6A1 RID: 50849 RVA: 0x0032502C File Offset: 0x0032322C
		// (set) Token: 0x0600C6A2 RID: 50850 RVA: 0x0005DC40 File Offset: 0x0005BE40
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C45 RID: 15429
		// (get) Token: 0x0600C6A3 RID: 50851 RVA: 0x0032505C File Offset: 0x0032325C
		// (set) Token: 0x0600C6A4 RID: 50852 RVA: 0x0005DC5F File Offset: 0x0005BE5F
		public unsafe BasicAvatarSettings DefaultSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_DefaultSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_DefaultSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C46 RID: 15430
		// (get) Token: 0x0600C6A5 RID: 50853 RVA: 0x0032508C File Offset: 0x0032328C
		// (set) Token: 0x0600C6A6 RID: 50854 RVA: 0x0005DC7E File Offset: 0x0005BE7E
		public unsafe Il2CppReferenceArray<CashPile> CashPiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_CashPiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CashPile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_CashPiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008775 RID: 34677
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04008776 RID: 34678
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSettings;

		// Token: 0x04008777 RID: 34679
		private static readonly IntPtr NativeFieldInfoPtr_CashPiles;

		// Token: 0x04008778 RID: 34680
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04008779 RID: 34681
		private static readonly IntPtr NativeMethodInfoPtr_LoadStuff_Private_Void_0;

		// Token: 0x0400877A RID: 34682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
