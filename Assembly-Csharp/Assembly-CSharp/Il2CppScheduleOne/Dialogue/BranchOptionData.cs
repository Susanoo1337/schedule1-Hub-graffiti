using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003D2 RID: 978
	[Serializable]
	public class BranchOptionData : Object
	{
		// Token: 0x060057DA RID: 22490 RVA: 0x001ABB64 File Offset: 0x001A9D64
		// Note: this type is marked as 'beforefieldinit'.
		static BranchOptionData()
		{
			Il2CppClassPointerStore<BranchOptionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "BranchOptionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BranchOptionData>.NativeClassPtr);
			BranchOptionData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchOptionData>.NativeClassPtr, "Guid");
			BranchOptionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchOptionData>.NativeClassPtr, 100674852);
		}

		// Token: 0x060057DB RID: 22491 RVA: 0x001ABBBC File Offset: 0x001A9DBC
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchOptionData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BranchOptionData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchOptionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057DC RID: 22492 RVA: 0x0002978E File Offset: 0x0002798E
		public BranchOptionData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x060057DD RID: 22493 RVA: 0x001ABBF8 File Offset: 0x001A9DF8
		// (set) Token: 0x060057DE RID: 22494 RVA: 0x00029797 File Offset: 0x00027997
		public unsafe string Guid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchOptionData.NativeFieldInfoPtr_Guid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BranchOptionData.NativeFieldInfoPtr_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003C7F RID: 15487
		private static readonly IntPtr NativeFieldInfoPtr_Guid;

		// Token: 0x04003C80 RID: 15488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
