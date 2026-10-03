using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000558 RID: 1368
	[Serializable]
	public class NewMixOperation : Object
	{
		// Token: 0x06007C50 RID: 31824 RVA: 0x00224C8C File Offset: 0x00222E8C
		// Note: this type is marked as 'beforefieldinit'.
		static NewMixOperation()
		{
			Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "NewMixOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr);
			NewMixOperation.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr, "ProductID");
			NewMixOperation.NativeFieldInfoPtr_IngredientID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr, "IngredientID");
			NewMixOperation.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr, 100679255);
			NewMixOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr, 100679256);
		}

		// Token: 0x06007C51 RID: 31825 RVA: 0x00224D0C File Offset: 0x00222F0C
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 100943, RefRangeEnd = 100996, XrefRangeStart = 100943, XrefRangeEnd = 100996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewMixOperation(string productID, string ingredientID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ingredientID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixOperation.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C52 RID: 31826 RVA: 0x00224D6C File Offset: 0x00222F6C
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewMixOperation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C53 RID: 31827 RVA: 0x0003B337 File Offset: 0x00039537
		public NewMixOperation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002675 RID: 9845
		// (get) Token: 0x06007C54 RID: 31828 RVA: 0x00224DA8 File Offset: 0x00222FA8
		// (set) Token: 0x06007C55 RID: 31829 RVA: 0x0003B340 File Offset: 0x00039540
		public unsafe string ProductID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixOperation.NativeFieldInfoPtr_ProductID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixOperation.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002676 RID: 9846
		// (get) Token: 0x06007C56 RID: 31830 RVA: 0x00224DD0 File Offset: 0x00222FD0
		// (set) Token: 0x06007C57 RID: 31831 RVA: 0x0003B35F File Offset: 0x0003955F
		public unsafe string IngredientID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixOperation.NativeFieldInfoPtr_IngredientID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixOperation.NativeFieldInfoPtr_IngredientID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040054C4 RID: 21700
		private static readonly IntPtr NativeFieldInfoPtr_ProductID;

		// Token: 0x040054C5 RID: 21701
		private static readonly IntPtr NativeFieldInfoPtr_IngredientID;

		// Token: 0x040054C6 RID: 21702
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040054C7 RID: 21703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
