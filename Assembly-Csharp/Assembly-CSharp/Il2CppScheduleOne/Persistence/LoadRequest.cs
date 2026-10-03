using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x020001B1 RID: 433
	public class LoadRequest : Object
	{
		// Token: 0x06002B4B RID: 11083 RVA: 0x0010A67C File Offset: 0x0010887C
		// Note: this type is marked as 'beforefieldinit'.
		static LoadRequest()
		{
			Il2CppClassPointerStore<LoadRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "LoadRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr);
			LoadRequest.NativeFieldInfoPtr_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr, "Path");
			LoadRequest.NativeFieldInfoPtr_Loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr, "Loader");
			LoadRequest.NativeFieldInfoPtr__IsDone_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr, "<IsDone>k__BackingField");
			LoadRequest.NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr, 100668906);
			LoadRequest.NativeMethodInfoPtr_set_IsDone_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr, 100668907);
			LoadRequest.NativeMethodInfoPtr__ctor_Public_Void_String_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr, 100668908);
			LoadRequest.NativeMethodInfoPtr_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr, 100668909);
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06002B4C RID: 11084 RVA: 0x0010A738 File Offset: 0x00108938
		// (set) Token: 0x06002B4D RID: 11085 RVA: 0x0010A774 File Offset: 0x00108974
		public unsafe bool IsDone
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadRequest.NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadRequest.NativeMethodInfoPtr_set_IsDone_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x0010A7B4 File Offset: 0x001089B4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 127259, RefRangeEnd = 127269, XrefRangeStart = 127243, XrefRangeEnd = 127259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadRequest(string filePath, Loader loader) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadRequest>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadRequest.NativeMethodInfoPtr__ctor_Public_Void_String_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x0010A814 File Offset: 0x00108A14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127274, RefRangeEnd = 127276, XrefRangeStart = 127269, XrefRangeEnd = 127274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadRequest.NativeMethodInfoPtr_Complete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x00016759 File Offset: 0x00014959
		public LoadRequest(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06002B51 RID: 11089 RVA: 0x0010A848 File Offset: 0x00108A48
		// (set) Token: 0x06002B52 RID: 11090 RVA: 0x00016762 File Offset: 0x00014962
		public unsafe string Path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadRequest.NativeFieldInfoPtr_Path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadRequest.NativeFieldInfoPtr_Path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06002B53 RID: 11091 RVA: 0x0010A870 File Offset: 0x00108A70
		// (set) Token: 0x06002B54 RID: 11092 RVA: 0x00016781 File Offset: 0x00014981
		public unsafe Loader Loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadRequest.NativeFieldInfoPtr_Loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadRequest.NativeFieldInfoPtr_Loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06002B55 RID: 11093 RVA: 0x0010A8A0 File Offset: 0x00108AA0
		// (set) Token: 0x06002B56 RID: 11094 RVA: 0x000167A0 File Offset: 0x000149A0
		public unsafe bool _IsDone_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadRequest.NativeFieldInfoPtr__IsDone_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadRequest.NativeFieldInfoPtr__IsDone_k__BackingField)) = value;
			}
		}

		// Token: 0x04001DCC RID: 7628
		private static readonly IntPtr NativeFieldInfoPtr_Path;

		// Token: 0x04001DCD RID: 7629
		private static readonly IntPtr NativeFieldInfoPtr_Loader;

		// Token: 0x04001DCE RID: 7630
		private static readonly IntPtr NativeFieldInfoPtr__IsDone_k__BackingField;

		// Token: 0x04001DCF RID: 7631
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0;

		// Token: 0x04001DD0 RID: 7632
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDone_Private_set_Void_Boolean_0;

		// Token: 0x04001DD1 RID: 7633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Loader_0;

		// Token: 0x04001DD2 RID: 7634
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_0;
	}
}
