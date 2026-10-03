using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000556 RID: 1366
	[Serializable]
	public class MixRecipeData : Object
	{
		// Token: 0x06007C2D RID: 31789 RVA: 0x002246C8 File Offset: 0x002228C8
		// Note: this type is marked as 'beforefieldinit'.
		static MixRecipeData()
		{
			Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "MixRecipeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr);
			MixRecipeData.NativeFieldInfoPtr_Product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr, "Product");
			MixRecipeData.NativeFieldInfoPtr_Mixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr, "Mixer");
			MixRecipeData.NativeFieldInfoPtr_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr, "Output");
			MixRecipeData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr, 100679248);
		}

		// Token: 0x06007C2E RID: 31790 RVA: 0x00224748 File Offset: 0x00222948
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 29770, RefRangeEnd = 29775, XrefRangeStart = 29770, XrefRangeEnd = 29775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixRecipeData(string product, string mixer, string output) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mixer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixRecipeData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C2F RID: 31791 RVA: 0x0003B1B9 File Offset: 0x000393B9
		public MixRecipeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002669 RID: 9833
		// (get) Token: 0x06007C30 RID: 31792 RVA: 0x002247B8 File Offset: 0x002229B8
		// (set) Token: 0x06007C31 RID: 31793 RVA: 0x0003B1C2 File Offset: 0x000393C2
		public unsafe string Product
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Product);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Product), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700266A RID: 9834
		// (get) Token: 0x06007C32 RID: 31794 RVA: 0x002247E0 File Offset: 0x002229E0
		// (set) Token: 0x06007C33 RID: 31795 RVA: 0x0003B1E1 File Offset: 0x000393E1
		public unsafe string Mixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Mixer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Mixer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700266B RID: 9835
		// (get) Token: 0x06007C34 RID: 31796 RVA: 0x00224808 File Offset: 0x00222A08
		// (set) Token: 0x06007C35 RID: 31797 RVA: 0x0003B200 File Offset: 0x00039400
		public unsafe string Output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Output);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Output), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040054B1 RID: 21681
		private static readonly IntPtr NativeFieldInfoPtr_Product;

		// Token: 0x040054B2 RID: 21682
		private static readonly IntPtr NativeFieldInfoPtr_Mixer;

		// Token: 0x040054B3 RID: 21683
		private static readonly IntPtr NativeFieldInfoPtr_Output;

		// Token: 0x040054B4 RID: 21684
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;
	}
}
