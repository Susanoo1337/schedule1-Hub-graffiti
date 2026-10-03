using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000411 RID: 1041
	[Serializable]
	public class GameSettings : Object
	{
		// Token: 0x06005B87 RID: 23431 RVA: 0x001B6DA8 File Offset: 0x001B4FA8
		// Note: this type is marked as 'beforefieldinit'.
		static GameSettings()
		{
			Il2CppClassPointerStore<GameSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "GameSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameSettings>.NativeClassPtr);
			GameSettings.NativeFieldInfoPtr_ConsoleEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "ConsoleEnabled");
			GameSettings.NativeFieldInfoPtr_UseRandomizedMixMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, "UseRandomizedMixMaps");
			GameSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSettings>.NativeClassPtr, 100675251);
		}

		// Token: 0x06005B88 RID: 23432 RVA: 0x001B6E14 File Offset: 0x001B5014
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B89 RID: 23433 RVA: 0x0002B58A File Offset: 0x0002978A
		public GameSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C32 RID: 7218
		// (get) Token: 0x06005B8A RID: 23434 RVA: 0x001B6E50 File Offset: 0x001B5050
		// (set) Token: 0x06005B8B RID: 23435 RVA: 0x0002B593 File Offset: 0x00029793
		public unsafe bool ConsoleEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettings.NativeFieldInfoPtr_ConsoleEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettings.NativeFieldInfoPtr_ConsoleEnabled)) = value;
			}
		}

		// Token: 0x17001C33 RID: 7219
		// (get) Token: 0x06005B8C RID: 23436 RVA: 0x001B6E78 File Offset: 0x001B5078
		// (set) Token: 0x06005B8D RID: 23437 RVA: 0x0002B5AE File Offset: 0x000297AE
		public unsafe bool UseRandomizedMixMaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettings.NativeFieldInfoPtr_UseRandomizedMixMaps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSettings.NativeFieldInfoPtr_UseRandomizedMixMaps)) = value;
			}
		}

		// Token: 0x04003EC8 RID: 16072
		private static readonly IntPtr NativeFieldInfoPtr_ConsoleEnabled;

		// Token: 0x04003EC9 RID: 16073
		private static readonly IntPtr NativeFieldInfoPtr_UseRandomizedMixMaps;

		// Token: 0x04003ECA RID: 16074
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
