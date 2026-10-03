using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005EA RID: 1514
	[Serializable]
	public class BasicInfo : Object
	{
		// Token: 0x06009501 RID: 38145 RVA: 0x00283C78 File Offset: 0x00281E78
		// Note: this type is marked as 'beforefieldinit'.
		static BasicInfo()
		{
			Il2CppClassPointerStore<BasicInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "BasicInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicInfo>.NativeClassPtr);
			BasicInfo.NativeFieldInfoPtr_FirstName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicInfo>.NativeClassPtr, "FirstName");
			BasicInfo.NativeFieldInfoPtr_HasLastName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicInfo>.NativeClassPtr, "HasLastName");
			BasicInfo.NativeFieldInfoPtr_LastName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicInfo>.NativeClassPtr, "LastName");
			BasicInfo.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicInfo>.NativeClassPtr, "ID");
			BasicInfo.NativeMethodInfoPtr_GetCopy_Public_BasicInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicInfo>.NativeClassPtr, 100682797);
			BasicInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicInfo>.NativeClassPtr, 100682798);
		}

		// Token: 0x06009502 RID: 38146 RVA: 0x00283D20 File Offset: 0x00281F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272214, XrefRangeEnd = 272221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicInfo GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicInfo.NativeMethodInfoPtr_GetCopy_Public_BasicInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BasicInfo>(intPtr3) : null;
		}

		// Token: 0x06009503 RID: 38147 RVA: 0x00283D60 File Offset: 0x00281F60
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicInfo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009504 RID: 38148 RVA: 0x00045AC0 File Offset: 0x00043CC0
		public BasicInfo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DFE RID: 11774
		// (get) Token: 0x06009505 RID: 38149 RVA: 0x00283D9C File Offset: 0x00281F9C
		// (set) Token: 0x06009506 RID: 38150 RVA: 0x00045AC9 File Offset: 0x00043CC9
		public unsafe string FirstName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicInfo.NativeFieldInfoPtr_FirstName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicInfo.NativeFieldInfoPtr_FirstName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002DFF RID: 11775
		// (get) Token: 0x06009507 RID: 38151 RVA: 0x00283DC4 File Offset: 0x00281FC4
		// (set) Token: 0x06009508 RID: 38152 RVA: 0x00045AE8 File Offset: 0x00043CE8
		public unsafe bool HasLastName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicInfo.NativeFieldInfoPtr_HasLastName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicInfo.NativeFieldInfoPtr_HasLastName)) = value;
			}
		}

		// Token: 0x17002E00 RID: 11776
		// (get) Token: 0x06009509 RID: 38153 RVA: 0x00283DEC File Offset: 0x00281FEC
		// (set) Token: 0x0600950A RID: 38154 RVA: 0x00045B03 File Offset: 0x00043D03
		public unsafe string LastName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicInfo.NativeFieldInfoPtr_LastName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicInfo.NativeFieldInfoPtr_LastName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002E01 RID: 11777
		// (get) Token: 0x0600950B RID: 38155 RVA: 0x00283E14 File Offset: 0x00282014
		// (set) Token: 0x0600950C RID: 38156 RVA: 0x00045B22 File Offset: 0x00043D22
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicInfo.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicInfo.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040066AB RID: 26283
		private static readonly IntPtr NativeFieldInfoPtr_FirstName;

		// Token: 0x040066AC RID: 26284
		private static readonly IntPtr NativeFieldInfoPtr_HasLastName;

		// Token: 0x040066AD RID: 26285
		private static readonly IntPtr NativeFieldInfoPtr_LastName;

		// Token: 0x040066AE RID: 26286
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x040066AF RID: 26287
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_BasicInfo_0;

		// Token: 0x040066B0 RID: 26288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
