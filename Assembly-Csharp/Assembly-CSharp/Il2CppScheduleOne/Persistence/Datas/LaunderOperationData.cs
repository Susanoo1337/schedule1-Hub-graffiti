using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200021A RID: 538
	[Serializable]
	public class LaunderOperationData : SaveData
	{
		// Token: 0x06002E66 RID: 11878 RVA: 0x00115BBC File Offset: 0x00113DBC
		// Note: this type is marked as 'beforefieldinit'.
		static LaunderOperationData()
		{
			Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "LaunderOperationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr);
			LaunderOperationData.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr, "Amount");
			LaunderOperationData.NativeFieldInfoPtr_MinutesSinceStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr, "MinutesSinceStarted");
			LaunderOperationData.NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr, 100669374);
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x00115C28 File Offset: 0x00113E28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134780, RefRangeEnd = 134781, XrefRangeStart = 134779, XrefRangeEnd = 134780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LaunderOperationData(float amount, int minutesSinceStarted) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaunderOperationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderOperationData.NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x000178B9 File Offset: 0x00015AB9
		public LaunderOperationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06002E69 RID: 11881 RVA: 0x00115C80 File Offset: 0x00113E80
		// (set) Token: 0x06002E6A RID: 11882 RVA: 0x000178C2 File Offset: 0x00015AC2
		public unsafe float Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderOperationData.NativeFieldInfoPtr_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderOperationData.NativeFieldInfoPtr_Amount)) = value;
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06002E6B RID: 11883 RVA: 0x00115CA8 File Offset: 0x00113EA8
		// (set) Token: 0x06002E6C RID: 11884 RVA: 0x000178DD File Offset: 0x00015ADD
		public unsafe int MinutesSinceStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderOperationData.NativeFieldInfoPtr_MinutesSinceStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderOperationData.NativeFieldInfoPtr_MinutesSinceStarted)) = value;
			}
		}

		// Token: 0x04001FA2 RID: 8098
		private static readonly IntPtr NativeFieldInfoPtr_Amount;

		// Token: 0x04001FA3 RID: 8099
		private static readonly IntPtr NativeFieldInfoPtr_MinutesSinceStarted;

		// Token: 0x04001FA4 RID: 8100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Int32_0;
	}
}
