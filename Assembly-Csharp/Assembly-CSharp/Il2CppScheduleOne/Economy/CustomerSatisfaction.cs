using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000398 RID: 920
	public class CustomerSatisfaction : Object
	{
		// Token: 0x06005382 RID: 21378 RVA: 0x0019C408 File Offset: 0x0019A608
		// Note: this type is marked as 'beforefieldinit'.
		static CustomerSatisfaction()
		{
			Il2CppClassPointerStore<CustomerSatisfaction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "CustomerSatisfaction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerSatisfaction>.NativeClassPtr);
			CustomerSatisfaction.NativeMethodInfoPtr_GetRelationshipChange_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSatisfaction>.NativeClassPtr, 100674255);
			CustomerSatisfaction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSatisfaction>.NativeClassPtr, 100674256);
		}

		// Token: 0x06005383 RID: 21379 RVA: 0x0019C460 File Offset: 0x0019A660
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186522, RefRangeEnd = 186523, XrefRangeStart = 186522, XrefRangeEnd = 186522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetRelationshipChange(float satisfaction)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref satisfaction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSatisfaction.NativeMethodInfoPtr_GetRelationshipChange_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005384 RID: 21380 RVA: 0x0019C4A0 File Offset: 0x0019A6A0
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerSatisfaction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerSatisfaction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSatisfaction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005385 RID: 21381 RVA: 0x0002788F File Offset: 0x00025A8F
		public CustomerSatisfaction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400397F RID: 14719
		private static readonly IntPtr NativeMethodInfoPtr_GetRelationshipChange_Public_Static_Single_Single_0;

		// Token: 0x04003980 RID: 14720
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
