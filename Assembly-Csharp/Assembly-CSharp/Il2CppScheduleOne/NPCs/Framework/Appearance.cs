using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005E8 RID: 1512
	[Serializable]
	public class Appearance : Il2CppSystem.Object
	{
		// Token: 0x060094F1 RID: 38129 RVA: 0x002839B4 File Offset: 0x00281BB4
		// Note: this type is marked as 'beforefieldinit'.
		static Appearance()
		{
			Il2CppClassPointerStore<Appearance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "Appearance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Appearance>.NativeClassPtr);
			Appearance.NativeFieldInfoPtr_AvatarSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Appearance>.NativeClassPtr, "AvatarSettings");
			Appearance.NativeFieldInfoPtr_Mugshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Appearance>.NativeClassPtr, "Mugshot");
			Appearance.NativeFieldInfoPtr_ChristmasAppearance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Appearance>.NativeClassPtr, "ChristmasAppearance");
			Appearance.NativeMethodInfoPtr_GetCopy_Public_Appearance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Appearance>.NativeClassPtr, 100682793);
			Appearance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Appearance>.NativeClassPtr, 100682794);
		}

		// Token: 0x060094F2 RID: 38130 RVA: 0x00283A48 File Offset: 0x00281C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272204, XrefRangeEnd = 272211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Appearance GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Appearance.NativeMethodInfoPtr_GetCopy_Public_Appearance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Appearance>(intPtr3) : null;
		}

		// Token: 0x060094F3 RID: 38131 RVA: 0x00283A88 File Offset: 0x00281C88
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Appearance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Appearance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Appearance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094F4 RID: 38132 RVA: 0x00045A32 File Offset: 0x00043C32
		public Appearance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DFA RID: 11770
		// (get) Token: 0x060094F5 RID: 38133 RVA: 0x00283AC4 File Offset: 0x00281CC4
		// (set) Token: 0x060094F6 RID: 38134 RVA: 0x00045A3B File Offset: 0x00043C3B
		public unsafe AvatarSettings AvatarSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Appearance.NativeFieldInfoPtr_AvatarSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Appearance.NativeFieldInfoPtr_AvatarSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DFB RID: 11771
		// (get) Token: 0x060094F7 RID: 38135 RVA: 0x00283AF4 File Offset: 0x00281CF4
		// (set) Token: 0x060094F8 RID: 38136 RVA: 0x00045A5A File Offset: 0x00043C5A
		public unsafe Sprite Mugshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Appearance.NativeFieldInfoPtr_Mugshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Appearance.NativeFieldInfoPtr_Mugshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DFC RID: 11772
		// (get) Token: 0x060094F9 RID: 38137 RVA: 0x00283B24 File Offset: 0x00281D24
		// (set) Token: 0x060094FA RID: 38138 RVA: 0x00045A79 File Offset: 0x00043C79
		public unsafe AvatarSettings ChristmasAppearance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Appearance.NativeFieldInfoPtr_ChristmasAppearance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Appearance.NativeFieldInfoPtr_ChristmasAppearance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040066A3 RID: 26275
		private static readonly IntPtr NativeFieldInfoPtr_AvatarSettings;

		// Token: 0x040066A4 RID: 26276
		private static readonly IntPtr NativeFieldInfoPtr_Mugshot;

		// Token: 0x040066A5 RID: 26277
		private static readonly IntPtr NativeFieldInfoPtr_ChristmasAppearance;

		// Token: 0x040066A6 RID: 26278
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Appearance_0;

		// Token: 0x040066A7 RID: 26279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
