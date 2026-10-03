using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000539 RID: 1337
	public class IngredientModule : ItemModule
	{
		// Token: 0x0600799F RID: 31135 RVA: 0x0021B504 File Offset: 0x00219704
		// Note: this type is marked as 'beforefieldinit'.
		static IngredientModule()
		{
			Il2CppClassPointerStore<IngredientModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "IngredientModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IngredientModule>.NativeClassPtr);
			IngredientModule.NativeFieldInfoPtr_Pieces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientModule>.NativeClassPtr, "Pieces");
			IngredientModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientModule>.NativeClassPtr, 100678928);
			IngredientModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientModule>.NativeClassPtr, 100678929);
		}

		// Token: 0x060079A0 RID: 31136 RVA: 0x0021B570 File Offset: 0x00219770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233861, XrefRangeEnd = 233869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActivateModule(StationItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IngredientModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079A1 RID: 31137 RVA: 0x0021B5C0 File Offset: 0x002197C0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IngredientModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IngredientModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079A2 RID: 31138 RVA: 0x00039EC6 File Offset: 0x000380C6
		public IngredientModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002597 RID: 9623
		// (get) Token: 0x060079A3 RID: 31139 RVA: 0x0021B5FC File Offset: 0x002197FC
		// (set) Token: 0x060079A4 RID: 31140 RVA: 0x00039ECF File Offset: 0x000380CF
		public unsafe Il2CppReferenceArray<IngredientPiece> Pieces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientModule.NativeFieldInfoPtr_Pieces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IngredientPiece>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientModule.NativeFieldInfoPtr_Pieces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040052DF RID: 21215
		private static readonly IntPtr NativeFieldInfoPtr_Pieces;

		// Token: 0x040052E0 RID: 21216
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0;

		// Token: 0x040052E1 RID: 21217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
