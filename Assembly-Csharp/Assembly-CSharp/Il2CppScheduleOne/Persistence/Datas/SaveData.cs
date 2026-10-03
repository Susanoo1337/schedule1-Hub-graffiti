using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200026B RID: 619
	[Serializable]
	public class SaveData : Object
	{
		// Token: 0x0600310A RID: 12554 RVA: 0x0011D77C File Offset: 0x0011B97C
		// Note: this type is marked as 'beforefieldinit'.
		static SaveData()
		{
			Il2CppClassPointerStore<SaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "SaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveData>.NativeClassPtr);
			SaveData.NativeFieldInfoPtr_DataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "DataType");
			SaveData.NativeFieldInfoPtr_DataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "DataVersion");
			SaveData.NativeFieldInfoPtr_GameVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "GameVersion");
			SaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveData>.NativeClassPtr, 100669460);
			SaveData.NativeMethodInfoPtr_GetDataVersion_Protected_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveData>.NativeClassPtr, 100669461);
			SaveData.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveData>.NativeClassPtr, 100669462);
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x0011D824 File Offset: 0x0011BA24
		[CallerCount(120)]
		[CachedScanResults(RefRangeStart = 135303, RefRangeEnd = 135423, XrefRangeStart = 135289, XrefRangeEnd = 135303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x0011D860 File Offset: 0x0011BA60
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetDataVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SaveData.NativeMethodInfoPtr_GetDataVersion_Protected_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600310D RID: 12557 RVA: 0x0011D8A8 File Offset: 0x0011BAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135423, XrefRangeEnd = 135435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetJson(bool prettyPrint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref prettyPrint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SaveData.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600310E RID: 12558 RVA: 0x00019460 File Offset: 0x00017660
		public SaveData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x0600310F RID: 12559 RVA: 0x0011D8F8 File Offset: 0x0011BAF8
		// (set) Token: 0x06003110 RID: 12560 RVA: 0x00019469 File Offset: 0x00017669
		public unsafe string DataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_DataType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_DataType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x06003111 RID: 12561 RVA: 0x0011D920 File Offset: 0x0011BB20
		// (set) Token: 0x06003112 RID: 12562 RVA: 0x00019488 File Offset: 0x00017688
		public unsafe int DataVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_DataVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_DataVersion)) = value;
			}
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x06003113 RID: 12563 RVA: 0x0011D948 File Offset: 0x0011BB48
		// (set) Token: 0x06003114 RID: 12564 RVA: 0x000194A3 File Offset: 0x000176A3
		public unsafe string GameVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_GameVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_GameVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040020CE RID: 8398
		private static readonly IntPtr NativeFieldInfoPtr_DataType;

		// Token: 0x040020CF RID: 8399
		private static readonly IntPtr NativeFieldInfoPtr_DataVersion;

		// Token: 0x040020D0 RID: 8400
		private static readonly IntPtr NativeFieldInfoPtr_GameVersion;

		// Token: 0x040020D1 RID: 8401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040020D2 RID: 8402
		private static readonly IntPtr NativeMethodInfoPtr_GetDataVersion_Protected_Virtual_New_Int32_0;

		// Token: 0x040020D3 RID: 8403
		private static readonly IntPtr NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0;
	}
}
