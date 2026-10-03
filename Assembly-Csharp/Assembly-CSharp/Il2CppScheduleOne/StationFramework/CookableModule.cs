using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000537 RID: 1335
	public class CookableModule : ItemModule
	{
		// Token: 0x0600797B RID: 31099 RVA: 0x0021AEA4 File Offset: 0x002190A4
		// Note: this type is marked as 'beforefieldinit'.
		static CookableModule()
		{
			Il2CppClassPointerStore<CookableModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "CookableModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookableModule>.NativeClassPtr);
			CookableModule.NativeFieldInfoPtr_CookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "CookTime");
			CookableModule.NativeFieldInfoPtr_CookType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "CookType");
			CookableModule.NativeFieldInfoPtr_Product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "Product");
			CookableModule.NativeFieldInfoPtr_ProductQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "ProductQuantity");
			CookableModule.NativeFieldInfoPtr_ProductShardPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "ProductShardPrefab");
			CookableModule.NativeFieldInfoPtr_LiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "LiquidColor");
			CookableModule.NativeFieldInfoPtr_SolidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "SolidColor");
			CookableModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, 100678907);
		}

		// Token: 0x0600797C RID: 31100 RVA: 0x0021AF74 File Offset: 0x00219174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233740, XrefRangeEnd = 233741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookableModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookableModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookableModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600797D RID: 31101 RVA: 0x00039D7B File Offset: 0x00037F7B
		public CookableModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700258B RID: 9611
		// (get) Token: 0x0600797E RID: 31102 RVA: 0x0021AFB0 File Offset: 0x002191B0
		// (set) Token: 0x0600797F RID: 31103 RVA: 0x00039D84 File Offset: 0x00037F84
		public unsafe int CookTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_CookTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_CookTime)) = value;
			}
		}

		// Token: 0x1700258C RID: 9612
		// (get) Token: 0x06007980 RID: 31104 RVA: 0x0021AFD8 File Offset: 0x002191D8
		// (set) Token: 0x06007981 RID: 31105 RVA: 0x00039D9F File Offset: 0x00037F9F
		public unsafe CookableModule.ECookableType CookType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_CookType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_CookType)) = value;
			}
		}

		// Token: 0x1700258D RID: 9613
		// (get) Token: 0x06007982 RID: 31106 RVA: 0x0021B000 File Offset: 0x00219200
		// (set) Token: 0x06007983 RID: 31107 RVA: 0x00039DBA File Offset: 0x00037FBA
		public unsafe StorableItemDefinition Product
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_Product);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_Product), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700258E RID: 9614
		// (get) Token: 0x06007984 RID: 31108 RVA: 0x0021B030 File Offset: 0x00219230
		// (set) Token: 0x06007985 RID: 31109 RVA: 0x00039DD9 File Offset: 0x00037FD9
		public unsafe int ProductQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_ProductQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_ProductQuantity)) = value;
			}
		}

		// Token: 0x1700258F RID: 9615
		// (get) Token: 0x06007986 RID: 31110 RVA: 0x0021B058 File Offset: 0x00219258
		// (set) Token: 0x06007987 RID: 31111 RVA: 0x00039DF4 File Offset: 0x00037FF4
		public unsafe Rigidbody ProductShardPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_ProductShardPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_ProductShardPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002590 RID: 9616
		// (get) Token: 0x06007988 RID: 31112 RVA: 0x0021B088 File Offset: 0x00219288
		// (set) Token: 0x06007989 RID: 31113 RVA: 0x00039E13 File Offset: 0x00038013
		public unsafe Color LiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_LiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_LiquidColor)) = value;
			}
		}

		// Token: 0x17002591 RID: 9617
		// (get) Token: 0x0600798A RID: 31114 RVA: 0x0021B0B0 File Offset: 0x002192B0
		// (set) Token: 0x0600798B RID: 31115 RVA: 0x00039E2E File Offset: 0x0003802E
		public unsafe Color SolidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_SolidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_SolidColor)) = value;
			}
		}

		// Token: 0x040052CA RID: 21194
		private static readonly IntPtr NativeFieldInfoPtr_CookTime;

		// Token: 0x040052CB RID: 21195
		private static readonly IntPtr NativeFieldInfoPtr_CookType;

		// Token: 0x040052CC RID: 21196
		private static readonly IntPtr NativeFieldInfoPtr_Product;

		// Token: 0x040052CD RID: 21197
		private static readonly IntPtr NativeFieldInfoPtr_ProductQuantity;

		// Token: 0x040052CE RID: 21198
		private static readonly IntPtr NativeFieldInfoPtr_ProductShardPrefab;

		// Token: 0x040052CF RID: 21199
		private static readonly IntPtr NativeFieldInfoPtr_LiquidColor;

		// Token: 0x040052D0 RID: 21200
		private static readonly IntPtr NativeFieldInfoPtr_SolidColor;

		// Token: 0x040052D1 RID: 21201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BB3 RID: 2995
		[OriginalName("Assembly-CSharp.dll", "", "ECookableType")]
		public enum ECookableType
		{
			// Token: 0x04009F3F RID: 40767
			Liquid,
			// Token: 0x04009F40 RID: 40768
			Solid
		}
	}
}
