using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Clothing;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200020D RID: 525
	[Serializable]
	public class ClothingData : ItemData
	{
		// Token: 0x06002E29 RID: 11817 RVA: 0x00115174 File Offset: 0x00113374
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingData()
		{
			Il2CppClassPointerStore<ClothingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ClothingData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingData>.NativeClassPtr);
			ClothingData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingData>.NativeClassPtr, "Color");
			ClothingData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingData>.NativeClassPtr, 100669361);
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x001151CC File Offset: 0x001133CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134757, RefRangeEnd = 134759, XrefRangeStart = 134755, XrefRangeEnd = 134757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingData(string iD, int quantity, EClothingColor color) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EClothingColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x000175EE File Offset: 0x000157EE
		public ClothingData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06002E2C RID: 11820 RVA: 0x00115234 File Offset: 0x00113434
		// (set) Token: 0x06002E2D RID: 11821 RVA: 0x000175F7 File Offset: 0x000157F7
		public unsafe EClothingColor Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingData.NativeFieldInfoPtr_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingData.NativeFieldInfoPtr_Color)) = value;
			}
		}

		// Token: 0x04001F8A RID: 8074
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x04001F8B RID: 8075
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EClothingColor_0;
	}
}
