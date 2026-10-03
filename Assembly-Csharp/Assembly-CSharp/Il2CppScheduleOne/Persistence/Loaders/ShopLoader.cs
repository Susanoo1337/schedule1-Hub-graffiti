using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001D0 RID: 464
	public class ShopLoader : Loader
	{
		// Token: 0x06002C79 RID: 11385 RVA: 0x0010EC44 File Offset: 0x0010CE44
		// Note: this type is marked as 'beforefieldinit'.
		static ShopLoader()
		{
			Il2CppClassPointerStore<ShopLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "ShopLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopLoader>.NativeClassPtr);
			ShopLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLoader>.NativeClassPtr, 100669065);
			ShopLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLoader>.NativeClassPtr, 100669066);
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x0010EC9C File Offset: 0x0010CE9C
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x0010ECD8 File Offset: 0x0010CED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129769, XrefRangeEnd = 129788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x00016DC6 File Offset: 0x00014FC6
		public ShopLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E89 RID: 7817
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E8A RID: 7818
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x020009BE RID: 2494
		[ObfuscatedName("ScheduleOne.Persistence.Loaders.ShopLoader+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x0600DBA2 RID: 56226 RVA: 0x00365CF8 File Offset: 0x00363EF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<ShopLoader.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopLoader>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopLoader.__c__DisplayClass1_0>.NativeClassPtr);
				ShopLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopLoader.__c__DisplayClass1_0>.NativeClassPtr, "data");
				ShopLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLoader.__c__DisplayClass1_0>.NativeClassPtr, 100669067);
				ShopLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopLoader.__c__DisplayClass1_0>.NativeClassPtr, 100669068);
			}

			// Token: 0x0600DBA3 RID: 56227 RVA: 0x00365D60 File Offset: 0x00363F60
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopLoader.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DBA4 RID: 56228 RVA: 0x00365D9C File Offset: 0x00363F9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129767, XrefRangeEnd = 129769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Load_b__0(ShopInterface x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopLoader.__c__DisplayClass1_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DBA5 RID: 56229 RVA: 0x00067448 File Offset: 0x00065648
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004300 RID: 17152
			// (get) Token: 0x0600DBA6 RID: 56230 RVA: 0x00365DEC File Offset: 0x00363FEC
			// (set) Token: 0x0600DBA7 RID: 56231 RVA: 0x00067451 File Offset: 0x00065651
			public unsafe ShopData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopLoader.__c__DisplayClass1_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095FD RID: 38397
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x040095FE RID: 38398
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095FF RID: 38399
			private static readonly IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ShopInterface_0;
		}
	}
}
