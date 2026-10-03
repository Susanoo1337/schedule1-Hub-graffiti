using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x020003A5 RID: 933
	public class DealerStaticDoor : StaticDoor
	{
		// Token: 0x060054E7 RID: 21735 RVA: 0x001A14E4 File Offset: 0x0019F6E4
		// Note: this type is marked as 'beforefieldinit'.
		static DealerStaticDoor()
		{
			Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "DealerStaticDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr);
			DealerStaticDoor.NativeFieldInfoPtr_Dealer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr, "Dealer");
			DealerStaticDoor.NativeMethodInfoPtr_IsKnockValid_Protected_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr, 100674444);
			DealerStaticDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr, 100674445);
		}

		// Token: 0x060054E8 RID: 21736 RVA: 0x001A1550 File Offset: 0x0019F750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188983, XrefRangeEnd = 188998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsKnockValid(out string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealerStaticDoor.NativeMethodInfoPtr_IsKnockValid_Protected_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			message = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060054E9 RID: 21737 RVA: 0x001A15B4 File Offset: 0x0019F7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188998, XrefRangeEnd = 188999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealerStaticDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerStaticDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054EA RID: 21738 RVA: 0x0002819D File Offset: 0x0002639D
		public DealerStaticDoor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x060054EB RID: 21739 RVA: 0x001A15F0 File Offset: 0x0019F7F0
		// (set) Token: 0x060054EC RID: 21740 RVA: 0x000281A6 File Offset: 0x000263A6
		public unsafe Dealer Dealer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerStaticDoor.NativeFieldInfoPtr_Dealer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerStaticDoor.NativeFieldInfoPtr_Dealer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A84 RID: 14980
		private static readonly IntPtr NativeFieldInfoPtr_Dealer;

		// Token: 0x04003A85 RID: 14981
		private static readonly IntPtr NativeMethodInfoPtr_IsKnockValid_Protected_Virtual_Boolean_byref_String_0;

		// Token: 0x04003A86 RID: 14982
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
