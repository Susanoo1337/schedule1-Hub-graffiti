using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200026C RID: 620
	[Serializable]
	public class SerializedSaveData : Object
	{
		// Token: 0x06003115 RID: 12565 RVA: 0x0011D970 File Offset: 0x0011BB70
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedSaveData()
		{
			Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "SerializedSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr);
			SerializedSaveData.NativeFieldInfoPtr__DataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, "_DataType");
			SerializedSaveData.NativeFieldInfoPtr_DataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, "DataType");
			SerializedSaveData.NativeFieldInfoPtr__DataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, "_DataVersion");
			SerializedSaveData.NativeFieldInfoPtr_DataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, "DataVersion");
			SerializedSaveData.NativeMethodInfoPtr_get_Version_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, 100669463);
			SerializedSaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, 100669464);
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x06003116 RID: 12566 RVA: 0x0011DA18 File Offset: 0x0011BC18
		public unsafe string Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135435, XrefRangeEnd = 135439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedSaveData.NativeMethodInfoPtr_get_Version_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x0011DA50 File Offset: 0x0011BC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135439, XrefRangeEnd = 135444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedSaveData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedSaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x000194C2 File Offset: 0x000176C2
		public SerializedSaveData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x06003119 RID: 12569 RVA: 0x0011DA8C File Offset: 0x0011BC8C
		// (set) Token: 0x0600311A RID: 12570 RVA: 0x000194CB File Offset: 0x000176CB
		public unsafe static string _DataType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializedSaveData.NativeFieldInfoPtr__DataType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializedSaveData.NativeFieldInfoPtr__DataType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x0600311B RID: 12571 RVA: 0x0011DAAC File Offset: 0x0011BCAC
		// (set) Token: 0x0600311C RID: 12572 RVA: 0x000194DD File Offset: 0x000176DD
		public unsafe string DataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSaveData.NativeFieldInfoPtr_DataType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSaveData.NativeFieldInfoPtr_DataType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x0600311D RID: 12573 RVA: 0x0011DAD4 File Offset: 0x0011BCD4
		// (set) Token: 0x0600311E RID: 12574 RVA: 0x000194FC File Offset: 0x000176FC
		public unsafe static int _DataVersion
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SerializedSaveData.NativeFieldInfoPtr__DataVersion, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializedSaveData.NativeFieldInfoPtr__DataVersion, (void*)(&value));
			}
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x0600311F RID: 12575 RVA: 0x0011DAF0 File Offset: 0x0011BCF0
		// (set) Token: 0x06003120 RID: 12576 RVA: 0x0001950A File Offset: 0x0001770A
		public unsafe int DataVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSaveData.NativeFieldInfoPtr_DataVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSaveData.NativeFieldInfoPtr_DataVersion)) = value;
			}
		}

		// Token: 0x040020D4 RID: 8404
		private static readonly IntPtr NativeFieldInfoPtr__DataType;

		// Token: 0x040020D5 RID: 8405
		private static readonly IntPtr NativeFieldInfoPtr_DataType;

		// Token: 0x040020D6 RID: 8406
		private static readonly IntPtr NativeFieldInfoPtr__DataVersion;

		// Token: 0x040020D7 RID: 8407
		private static readonly IntPtr NativeFieldInfoPtr_DataVersion;

		// Token: 0x040020D8 RID: 8408
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_String_0;

		// Token: 0x040020D9 RID: 8409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
