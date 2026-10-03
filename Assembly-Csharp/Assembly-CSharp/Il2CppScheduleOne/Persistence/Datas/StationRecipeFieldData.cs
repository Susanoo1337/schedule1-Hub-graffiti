using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000233 RID: 563
	[Serializable]
	public class StationRecipeFieldData : Object
	{
		// Token: 0x06002F10 RID: 12048 RVA: 0x00117880 File Offset: 0x00115A80
		// Note: this type is marked as 'beforefieldinit'.
		static StationRecipeFieldData()
		{
			Il2CppClassPointerStore<StationRecipeFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "StationRecipeFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeFieldData>.NativeClassPtr);
			StationRecipeFieldData.NativeFieldInfoPtr_RecipeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldData>.NativeClassPtr, "RecipeID");
			StationRecipeFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldData>.NativeClassPtr, 100669400);
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x001178D8 File Offset: 0x00115AD8
		[CallerCount(203)]
		[CachedScanResults(RefRangeStart = 19776, RefRangeEnd = 19979, XrefRangeStart = 19776, XrefRangeEnd = 19979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipeFieldData(string recipeID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeFieldData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(recipeID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F12 RID: 12050 RVA: 0x00017F33 File Offset: 0x00016133
		public StationRecipeFieldData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06002F13 RID: 12051 RVA: 0x00117924 File Offset: 0x00115B24
		// (set) Token: 0x06002F14 RID: 12052 RVA: 0x00017F3C File Offset: 0x0001613C
		public unsafe string RecipeID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldData.NativeFieldInfoPtr_RecipeID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldData.NativeFieldInfoPtr_RecipeID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001FEB RID: 8171
		private static readonly IntPtr NativeFieldInfoPtr_RecipeID;

		// Token: 0x04001FEC RID: 8172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
