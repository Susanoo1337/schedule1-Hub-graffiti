using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000206 RID: 518
	[Serializable]
	public class FootprintMatchData : Il2CppSystem.Object
	{
		// Token: 0x06002DEA RID: 11754 RVA: 0x00114528 File Offset: 0x00112728
		// Note: this type is marked as 'beforefieldinit'.
		static FootprintMatchData()
		{
			Il2CppClassPointerStore<FootprintMatchData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "FootprintMatchData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootprintMatchData>.NativeClassPtr);
			FootprintMatchData.NativeFieldInfoPtr_TileOwnerGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintMatchData>.NativeClassPtr, "TileOwnerGUID");
			FootprintMatchData.NativeFieldInfoPtr_TileIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintMatchData>.NativeClassPtr, "TileIndex");
			FootprintMatchData.NativeFieldInfoPtr_FootprintCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintMatchData>.NativeClassPtr, "FootprintCoordinate");
			FootprintMatchData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintMatchData>.NativeClassPtr, 100669332);
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x001145A8 File Offset: 0x001127A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134576, RefRangeEnd = 134577, XrefRangeStart = 134574, XrefRangeEnd = 134576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootprintMatchData(string tileOwnerGUID, int tileIndex, Vector2 footprintCoordinate) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootprintMatchData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tileOwnerGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tileIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref footprintCoordinate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootprintMatchData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DEC RID: 11756 RVA: 0x000173D7 File Offset: 0x000155D7
		public FootprintMatchData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x06002DED RID: 11757 RVA: 0x00114610 File Offset: 0x00112810
		// (set) Token: 0x06002DEE RID: 11758 RVA: 0x000173E0 File Offset: 0x000155E0
		public unsafe string TileOwnerGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintMatchData.NativeFieldInfoPtr_TileOwnerGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintMatchData.NativeFieldInfoPtr_TileOwnerGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06002DEF RID: 11759 RVA: 0x00114638 File Offset: 0x00112838
		// (set) Token: 0x06002DF0 RID: 11760 RVA: 0x000173FF File Offset: 0x000155FF
		public unsafe int TileIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintMatchData.NativeFieldInfoPtr_TileIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintMatchData.NativeFieldInfoPtr_TileIndex)) = value;
			}
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x06002DF1 RID: 11761 RVA: 0x00114660 File Offset: 0x00112860
		// (set) Token: 0x06002DF2 RID: 11762 RVA: 0x0001741A File Offset: 0x0001561A
		public unsafe Vector2 FootprintCoordinate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintMatchData.NativeFieldInfoPtr_FootprintCoordinate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintMatchData.NativeFieldInfoPtr_FootprintCoordinate)) = value;
			}
		}

		// Token: 0x04001F69 RID: 8041
		private static readonly IntPtr NativeFieldInfoPtr_TileOwnerGUID;

		// Token: 0x04001F6A RID: 8042
		private static readonly IntPtr NativeFieldInfoPtr_TileIndex;

		// Token: 0x04001F6B RID: 8043
		private static readonly IntPtr NativeFieldInfoPtr_FootprintCoordinate;

		// Token: 0x04001F6C RID: 8044
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Vector2_0;
	}
}
