using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x020001B7 RID: 439
	public class SaveRequest : Object
	{
		// Token: 0x06002BE5 RID: 11237 RVA: 0x0010C390 File Offset: 0x0010A590
		// Note: this type is marked as 'beforefieldinit'.
		static SaveRequest()
		{
			Il2CppClassPointerStore<SaveRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "SaveRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr);
			SaveRequest.NativeFieldInfoPtr_Saveable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, "Saveable");
			SaveRequest.NativeFieldInfoPtr_ParentFolderPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, "ParentFolderPath");
			SaveRequest.NativeFieldInfoPtr__SaveString_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, "<SaveString>k__BackingField");
			SaveRequest.NativeMethodInfoPtr_get_SaveString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, 100668966);
			SaveRequest.NativeMethodInfoPtr_set_SaveString_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, 100668967);
			SaveRequest.NativeMethodInfoPtr__ctor_Public_Void_ISaveable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, 100668968);
			SaveRequest.NativeMethodInfoPtr_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, 100668969);
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06002BE6 RID: 11238 RVA: 0x0010C44C File Offset: 0x0010A64C
		// (set) Token: 0x06002BE7 RID: 11239 RVA: 0x0010C484 File Offset: 0x0010A684
		public unsafe string SaveString
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveRequest.NativeMethodInfoPtr_get_SaveString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveRequest.NativeMethodInfoPtr_set_SaveString_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x0010C4C8 File Offset: 0x0010A6C8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 128100, RefRangeEnd = 128107, XrefRangeStart = 128066, XrefRangeEnd = 128100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveRequest(ISaveable saveable, string parentFolderPath) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveRequest.NativeMethodInfoPtr__ctor_Public_Void_ISaveable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x0010C528 File Offset: 0x0010A728
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128119, RefRangeEnd = 128120, XrefRangeStart = 128107, XrefRangeEnd = 128119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveRequest.NativeMethodInfoPtr_Complete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x00016C2B File Offset: 0x00014E2B
		public SaveRequest(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06002BEB RID: 11243 RVA: 0x0010C55C File Offset: 0x0010A75C
		// (set) Token: 0x06002BEC RID: 11244 RVA: 0x00016C34 File Offset: 0x00014E34
		public unsafe ISaveable Saveable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveRequest.NativeFieldInfoPtr_Saveable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISaveable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveRequest.NativeFieldInfoPtr_Saveable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06002BED RID: 11245 RVA: 0x0010C58C File Offset: 0x0010A78C
		// (set) Token: 0x06002BEE RID: 11246 RVA: 0x00016C53 File Offset: 0x00014E53
		public unsafe string ParentFolderPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveRequest.NativeFieldInfoPtr_ParentFolderPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveRequest.NativeFieldInfoPtr_ParentFolderPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06002BEF RID: 11247 RVA: 0x0010C5B4 File Offset: 0x0010A7B4
		// (set) Token: 0x06002BF0 RID: 11248 RVA: 0x00016C72 File Offset: 0x00014E72
		public unsafe string _SaveString_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveRequest.NativeFieldInfoPtr__SaveString_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveRequest.NativeFieldInfoPtr__SaveString_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001E2D RID: 7725
		private static readonly IntPtr NativeFieldInfoPtr_Saveable;

		// Token: 0x04001E2E RID: 7726
		private static readonly IntPtr NativeFieldInfoPtr_ParentFolderPath;

		// Token: 0x04001E2F RID: 7727
		private static readonly IntPtr NativeFieldInfoPtr__SaveString_k__BackingField;

		// Token: 0x04001E30 RID: 7728
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveString_Public_get_String_0;

		// Token: 0x04001E31 RID: 7729
		private static readonly IntPtr NativeMethodInfoPtr_set_SaveString_Private_set_Void_String_0;

		// Token: 0x04001E32 RID: 7730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISaveable_String_0;

		// Token: 0x04001E33 RID: 7731
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_0;
	}
}
