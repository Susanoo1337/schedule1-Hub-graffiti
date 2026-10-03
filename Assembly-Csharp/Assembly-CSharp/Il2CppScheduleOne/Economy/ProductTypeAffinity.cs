using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppSystem;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200038F RID: 911
	[Serializable]
	public class ProductTypeAffinity : Object
	{
		// Token: 0x06005210 RID: 21008 RVA: 0x00196694 File Offset: 0x00194894
		// Note: this type is marked as 'beforefieldinit'.
		static ProductTypeAffinity()
		{
			Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "ProductTypeAffinity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr);
			ProductTypeAffinity.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr, "DrugType");
			ProductTypeAffinity.NativeFieldInfoPtr_Affinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr, "Affinity");
			ProductTypeAffinity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr, 100674027);
		}

		// Token: 0x06005211 RID: 21009 RVA: 0x00196700 File Offset: 0x00194900
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductTypeAffinity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductTypeAffinity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005212 RID: 21010 RVA: 0x00027051 File Offset: 0x00025251
		public ProductTypeAffinity(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x06005213 RID: 21011 RVA: 0x0019673C File Offset: 0x0019493C
		// (set) Token: 0x06005214 RID: 21012 RVA: 0x0002705A File Offset: 0x0002525A
		public unsafe EDrugType DrugType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeAffinity.NativeFieldInfoPtr_DrugType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeAffinity.NativeFieldInfoPtr_DrugType)) = value;
			}
		}

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x06005215 RID: 21013 RVA: 0x00196764 File Offset: 0x00194964
		// (set) Token: 0x06005216 RID: 21014 RVA: 0x00027075 File Offset: 0x00025275
		public unsafe float Affinity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeAffinity.NativeFieldInfoPtr_Affinity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeAffinity.NativeFieldInfoPtr_Affinity)) = value;
			}
		}

		// Token: 0x0400385D RID: 14429
		private static readonly IntPtr NativeFieldInfoPtr_DrugType;

		// Token: 0x0400385E RID: 14430
		private static readonly IntPtr NativeFieldInfoPtr_Affinity;

		// Token: 0x0400385F RID: 14431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
