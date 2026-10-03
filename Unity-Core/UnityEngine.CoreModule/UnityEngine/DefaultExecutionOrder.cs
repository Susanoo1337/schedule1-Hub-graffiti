using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200012A RID: 298
	public class DefaultExecutionOrder : Attribute
	{
		// Token: 0x060017A0 RID: 6048 RVA: 0x00065CE0 File Offset: 0x00063EE0
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultExecutionOrder()
		{
			Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "DefaultExecutionOrder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr);
			DefaultExecutionOrder.NativeFieldInfoPtr_m_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr, "m_Order");
			DefaultExecutionOrder.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr, 100665768);
			DefaultExecutionOrder.NativeMethodInfoPtr_get_order_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr, 100665769);
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x00065D4C File Offset: 0x00063F4C
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 385934, RefRangeEnd = 385962, XrefRangeStart = 385934, XrefRangeEnd = 385962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultExecutionOrder(int order) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultExecutionOrder.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060017A2 RID: 6050 RVA: 0x00065D94 File Offset: 0x00063F94
		public unsafe int order
		{
			[CallerCount(49)]
			[CachedScanResults(RefRangeStart = 669546, RefRangeEnd = 669595, XrefRangeStart = 669546, XrefRangeEnd = 669595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultExecutionOrder.NativeMethodInfoPtr_get_order_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x0000BCDB File Offset: 0x00009EDB
		public DefaultExecutionOrder(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060017A4 RID: 6052 RVA: 0x00065DD0 File Offset: 0x00063FD0
		// (set) Token: 0x060017A5 RID: 6053 RVA: 0x0000BCE4 File Offset: 0x00009EE4
		public unsafe int m_Order
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultExecutionOrder.NativeFieldInfoPtr_m_Order);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultExecutionOrder.NativeFieldInfoPtr_m_Order)) = value;
			}
		}

		// Token: 0x040013F4 RID: 5108
		private static readonly IntPtr NativeFieldInfoPtr_m_Order;

		// Token: 0x040013F5 RID: 5109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040013F6 RID: 5110
		private static readonly IntPtr NativeMethodInfoPtr_get_order_Public_get_Int32_0;
	}
}
