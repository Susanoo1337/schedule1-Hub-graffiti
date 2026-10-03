using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Profiling.Memory
{
	// Token: 0x02000029 RID: 41
	public class MemorySnapshotMetadata : Object
	{
		// Token: 0x0600015A RID: 346 RVA: 0x0001C2E0 File Offset: 0x0001A4E0
		// Note: this type is marked as 'beforefieldinit'.
		static MemorySnapshotMetadata()
		{
			Il2CppClassPointerStore<MemorySnapshotMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.Memory", "MemorySnapshotMetadata");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemorySnapshotMetadata>.NativeClassPtr);
			MemorySnapshotMetadata.NativeFieldInfoPtr__Description_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemorySnapshotMetadata>.NativeClassPtr, "<Description>k__BackingField");
			MemorySnapshotMetadata.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemorySnapshotMetadata>.NativeClassPtr, "<Data>k__BackingField");
			MemorySnapshotMetadata.NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemorySnapshotMetadata>.NativeClassPtr, 100663426);
			MemorySnapshotMetadata.NativeMethodInfoPtr_set_Description_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemorySnapshotMetadata>.NativeClassPtr, 100663427);
			MemorySnapshotMetadata.NativeMethodInfoPtr_get_Data_Internal_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemorySnapshotMetadata>.NativeClassPtr, 100663428);
			MemorySnapshotMetadata.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemorySnapshotMetadata>.NativeClassPtr, 100663429);
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0001C388 File Offset: 0x0001A588
		// (set) Token: 0x0600015C RID: 348 RVA: 0x0001C3C0 File Offset: 0x0001A5C0
		public unsafe string Description
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 3712, RefRangeEnd = 3724, XrefRangeStart = 3712, XrefRangeEnd = 3724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemorySnapshotMetadata.NativeMethodInfoPtr_get_Description_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29107, RefRangeEnd = 29109, XrefRangeStart = 29107, XrefRangeEnd = 29109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemorySnapshotMetadata.NativeMethodInfoPtr_set_Description_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600015D RID: 349 RVA: 0x0001C404 File Offset: 0x0001A604
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00002AA1 File Offset: 0x00000CA1
		public unsafe Il2CppStructArray<byte> Data
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemorySnapshotMetadata.NativeMethodInfoPtr_get_Data_Internal_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			set
			{
				this._Data_k__BackingField = value;
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0001C444 File Offset: 0x0001A644
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemorySnapshotMetadata() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemorySnapshotMetadata>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemorySnapshotMetadata.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002A5A File Offset: 0x00000C5A
		public MemorySnapshotMetadata(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0001C480 File Offset: 0x0001A680
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00002A63 File Offset: 0x00000C63
		public unsafe string _Description_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemorySnapshotMetadata.NativeFieldInfoPtr__Description_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemorySnapshotMetadata.NativeFieldInfoPtr__Description_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0001C4A8 File Offset: 0x0001A6A8
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00002A82 File Offset: 0x00000C82
		public unsafe Il2CppStructArray<byte> _Data_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemorySnapshotMetadata.NativeFieldInfoPtr__Data_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemorySnapshotMetadata.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeFieldInfoPtr__Description_k__BackingField;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeFieldInfoPtr__Data_k__BackingField;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_set_Description_Public_set_Void_String_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Internal_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
