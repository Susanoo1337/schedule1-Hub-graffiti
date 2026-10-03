using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x0200055F RID: 1375
	public static class ProductQuantities : Object
	{
		// Token: 0x06007E00 RID: 32256 RVA: 0x0022C920 File Offset: 0x0022AB20
		// Note: this type is marked as 'beforefieldinit'.
		static ProductQuantities()
		{
			Il2CppClassPointerStore<ProductQuantities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductQuantities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductQuantities>.NativeClassPtr);
			ProductQuantities.NativeFieldInfoPtr_BagQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductQuantities>.NativeClassPtr, "BagQuantity");
			ProductQuantities.NativeFieldInfoPtr_JarQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductQuantities>.NativeClassPtr, "JarQuantity");
			ProductQuantities.NativeFieldInfoPtr_BrickQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductQuantities>.NativeClassPtr, "BrickQuantity");
		}

		// Token: 0x06007E01 RID: 32257 RVA: 0x0003BCDD File Offset: 0x00039EDD
		public ProductQuantities(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026EC RID: 9964
		// (get) Token: 0x06007E02 RID: 32258 RVA: 0x0022C98C File Offset: 0x0022AB8C
		// (set) Token: 0x06007E03 RID: 32259 RVA: 0x0003BCE6 File Offset: 0x00039EE6
		public unsafe static int BagQuantity
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ProductQuantities.NativeFieldInfoPtr_BagQuantity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProductQuantities.NativeFieldInfoPtr_BagQuantity, (void*)(&value));
			}
		}

		// Token: 0x170026ED RID: 9965
		// (get) Token: 0x06007E04 RID: 32260 RVA: 0x0022C9A8 File Offset: 0x0022ABA8
		// (set) Token: 0x06007E05 RID: 32261 RVA: 0x0003BCF4 File Offset: 0x00039EF4
		public unsafe static int JarQuantity
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ProductQuantities.NativeFieldInfoPtr_JarQuantity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProductQuantities.NativeFieldInfoPtr_JarQuantity, (void*)(&value));
			}
		}

		// Token: 0x170026EE RID: 9966
		// (get) Token: 0x06007E06 RID: 32262 RVA: 0x0022C9C4 File Offset: 0x0022ABC4
		// (set) Token: 0x06007E07 RID: 32263 RVA: 0x0003BD02 File Offset: 0x00039F02
		public unsafe static int BrickQuantity
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ProductQuantities.NativeFieldInfoPtr_BrickQuantity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProductQuantities.NativeFieldInfoPtr_BrickQuantity, (void*)(&value));
			}
		}

		// Token: 0x04005612 RID: 22034
		private static readonly IntPtr NativeFieldInfoPtr_BagQuantity;

		// Token: 0x04005613 RID: 22035
		private static readonly IntPtr NativeFieldInfoPtr_JarQuantity;

		// Token: 0x04005614 RID: 22036
		private static readonly IntPtr NativeFieldInfoPtr_BrickQuantity;
	}
}
