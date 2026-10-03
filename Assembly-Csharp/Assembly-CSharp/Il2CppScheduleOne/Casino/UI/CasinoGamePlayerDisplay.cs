using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Casino.UI
{
	// Token: 0x02000439 RID: 1081
	public class CasinoGamePlayerDisplay : MonoBehaviour
	{
		// Token: 0x060060EF RID: 24815 RVA: 0x001CAD14 File Offset: 0x001C8F14
		// Note: this type is marked as 'beforefieldinit'.
		static CasinoGamePlayerDisplay()
		{
			Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino.UI", "CasinoGamePlayerDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr);
			CasinoGamePlayerDisplay.NativeFieldInfoPtr_BindedPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, "BindedPlayers");
			CasinoGamePlayerDisplay.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, "TitleLabel");
			CasinoGamePlayerDisplay.NativeFieldInfoPtr_PlayerEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, "PlayerEntries");
			CasinoGamePlayerDisplay.NativeMethodInfoPtr_RefreshPlayers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, 100676028);
			CasinoGamePlayerDisplay.NativeMethodInfoPtr_RefreshScores_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, 100676029);
			CasinoGamePlayerDisplay.NativeMethodInfoPtr_Bind_Public_Void_CasinoGamePlayers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, 100676030);
			CasinoGamePlayerDisplay.NativeMethodInfoPtr_Unbind_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, 100676031);
			CasinoGamePlayerDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, 100676032);
		}

		// Token: 0x060060F0 RID: 24816 RVA: 0x001CADE4 File Offset: 0x001C8FE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205812, RefRangeEnd = 205813, XrefRangeStart = 205758, XrefRangeEnd = 205812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerDisplay.NativeMethodInfoPtr_RefreshPlayers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060F1 RID: 24817 RVA: 0x001CAE18 File Offset: 0x001C9018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205813, XrefRangeEnd = 205827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshScores()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerDisplay.NativeMethodInfoPtr_RefreshScores_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060F2 RID: 24818 RVA: 0x001CAE4C File Offset: 0x001C904C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205843, RefRangeEnd = 205845, XrefRangeStart = 205827, XrefRangeEnd = 205843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(CasinoGamePlayers players)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(players);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerDisplay.NativeMethodInfoPtr_Bind_Public_Void_CasinoGamePlayers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060F3 RID: 24819 RVA: 0x001CAE90 File Offset: 0x001C9090
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205863, RefRangeEnd = 205865, XrefRangeStart = 205845, XrefRangeEnd = 205863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unbind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerDisplay.NativeMethodInfoPtr_Unbind_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060F4 RID: 24820 RVA: 0x001CAEC4 File Offset: 0x001C90C4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayerDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060F5 RID: 24821 RVA: 0x0002DCFC File Offset: 0x0002BEFC
		public CasinoGamePlayerDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DD0 RID: 7632
		// (get) Token: 0x060060F6 RID: 24822 RVA: 0x001CAF00 File Offset: 0x001C9100
		// (set) Token: 0x060060F7 RID: 24823 RVA: 0x0002DD05 File Offset: 0x0002BF05
		public unsafe CasinoGamePlayers BindedPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_BindedPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_BindedPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DD1 RID: 7633
		// (get) Token: 0x060060F8 RID: 24824 RVA: 0x001CAF30 File Offset: 0x001C9130
		// (set) Token: 0x060060F9 RID: 24825 RVA: 0x0002DD24 File Offset: 0x0002BF24
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DD2 RID: 7634
		// (get) Token: 0x060060FA RID: 24826 RVA: 0x001CAF60 File Offset: 0x001C9160
		// (set) Token: 0x060060FB RID: 24827 RVA: 0x0002DD43 File Offset: 0x0002BF43
		public unsafe Il2CppReferenceArray<RectTransform> PlayerEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_PlayerEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_PlayerEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040042CA RID: 17098
		private static readonly IntPtr NativeFieldInfoPtr_BindedPlayers;

		// Token: 0x040042CB RID: 17099
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x040042CC RID: 17100
		private static readonly IntPtr NativeFieldInfoPtr_PlayerEntries;

		// Token: 0x040042CD RID: 17101
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPlayers_Public_Void_0;

		// Token: 0x040042CE RID: 17102
		private static readonly IntPtr NativeMethodInfoPtr_RefreshScores_Public_Void_0;

		// Token: 0x040042CF RID: 17103
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_CasinoGamePlayers_0;

		// Token: 0x040042D0 RID: 17104
		private static readonly IntPtr NativeMethodInfoPtr_Unbind_Public_Void_0;

		// Token: 0x040042D1 RID: 17105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
