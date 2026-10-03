using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000207 RID: 519
	public class GameData : SaveData
	{
		// Token: 0x06002DF3 RID: 11763 RVA: 0x00114688 File Offset: 0x00112888
		// Note: this type is marked as 'beforefieldinit'.
		static GameData()
		{
			Il2CppClassPointerStore<GameData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "GameData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameData>.NativeClassPtr);
			GameData.NativeFieldInfoPtr_OrganisationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameData>.NativeClassPtr, "OrganisationName");
			GameData.NativeFieldInfoPtr_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameData>.NativeClassPtr, "Seed");
			GameData.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameData>.NativeClassPtr, "Settings");
			GameData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_GameSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameData>.NativeClassPtr, 100669333);
			GameData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameData>.NativeClassPtr, 100669334);
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x0011471C File Offset: 0x0011291C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 134580, RefRangeEnd = 134586, XrefRangeStart = 134577, XrefRangeEnd = 134580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameData(string organisationName, int seed, GameSettings settings) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(organisationName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_GameSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x00114788 File Offset: 0x00112988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134591, RefRangeEnd = 134592, XrefRangeStart = 134586, XrefRangeEnd = 134591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x00017435 File Offset: 0x00015635
		public GameData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06002DF7 RID: 11767 RVA: 0x001147C4 File Offset: 0x001129C4
		// (set) Token: 0x06002DF8 RID: 11768 RVA: 0x0001743E File Offset: 0x0001563E
		public unsafe string OrganisationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_OrganisationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_OrganisationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06002DF9 RID: 11769 RVA: 0x001147EC File Offset: 0x001129EC
		// (set) Token: 0x06002DFA RID: 11770 RVA: 0x0001745D File Offset: 0x0001565D
		public unsafe int Seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_Seed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_Seed)) = value;
			}
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06002DFB RID: 11771 RVA: 0x00114814 File Offset: 0x00112A14
		// (set) Token: 0x06002DFC RID: 11772 RVA: 0x00017478 File Offset: 0x00015678
		public unsafe GameSettings Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameData.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F6D RID: 8045
		private static readonly IntPtr NativeFieldInfoPtr_OrganisationName;

		// Token: 0x04001F6E RID: 8046
		private static readonly IntPtr NativeFieldInfoPtr_Seed;

		// Token: 0x04001F6F RID: 8047
		private static readonly IntPtr NativeFieldInfoPtr_Settings;

		// Token: 0x04001F70 RID: 8048
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_GameSettings_0;

		// Token: 0x04001F71 RID: 8049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
