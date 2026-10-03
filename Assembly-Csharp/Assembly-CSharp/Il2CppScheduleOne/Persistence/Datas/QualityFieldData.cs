using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200022F RID: 559
	[Serializable]
	public class QualityFieldData : Object
	{
		// Token: 0x06002EFC RID: 12028 RVA: 0x00117528 File Offset: 0x00115728
		// Note: this type is marked as 'beforefieldinit'.
		static QualityFieldData()
		{
			Il2CppClassPointerStore<QualityFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "QualityFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityFieldData>.NativeClassPtr);
			QualityFieldData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldData>.NativeClassPtr, "Value");
			QualityFieldData.NativeMethodInfoPtr__ctor_Public_Void_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldData>.NativeClassPtr, 100669396);
		}

		// Token: 0x06002EFD RID: 12029 RVA: 0x00117580 File Offset: 0x00115780
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityFieldData(EQuality value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityFieldData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldData.NativeMethodInfoPtr__ctor_Public_Void_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EFE RID: 12030 RVA: 0x00017E97 File Offset: 0x00016097
		public QualityFieldData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06002EFF RID: 12031 RVA: 0x001175C8 File Offset: 0x001157C8
		// (set) Token: 0x06002F00 RID: 12032 RVA: 0x00017EA0 File Offset: 0x000160A0
		public unsafe EQuality Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldData.NativeFieldInfoPtr_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldData.NativeFieldInfoPtr_Value)) = value;
			}
		}

		// Token: 0x04001FE3 RID: 8163
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001FE4 RID: 8164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EQuality_0;
	}
}
