using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000241 RID: 577
	[Serializable]
	public class MoveItemData : Object
	{
		// Token: 0x06002F91 RID: 12177 RVA: 0x00118F40 File Offset: 0x00117140
		// Note: this type is marked as 'beforefieldinit'.
		static MoveItemData()
		{
			Il2CppClassPointerStore<MoveItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MoveItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr);
			MoveItemData.NativeFieldInfoPtr_TemplateItemJSON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr, "TemplateItemJSON");
			MoveItemData.NativeFieldInfoPtr_GrabbedItemQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr, "GrabbedItemQuantity");
			MoveItemData.NativeFieldInfoPtr_SourceGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr, "SourceGUID");
			MoveItemData.NativeFieldInfoPtr_DestinationGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr, "DestinationGUID");
			MoveItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Guid_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr, 100669415);
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x00118FD4 File Offset: 0x001171D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135040, RefRangeEnd = 135041, XrefRangeStart = 135031, XrefRangeEnd = 135040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveItemData(string templateItemJson, int grabbedItemQuantity, Guid sourceGUID, Guid destinationGUID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(templateItemJson);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref grabbedItemQuantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceGUID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationGUID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Guid_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F93 RID: 12179 RVA: 0x0001848A File Offset: 0x0001668A
		public MoveItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06002F94 RID: 12180 RVA: 0x0011904C File Offset: 0x0011724C
		// (set) Token: 0x06002F95 RID: 12181 RVA: 0x00018493 File Offset: 0x00016693
		public unsafe string TemplateItemJSON
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_TemplateItemJSON);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_TemplateItemJSON), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06002F96 RID: 12182 RVA: 0x00119074 File Offset: 0x00117274
		// (set) Token: 0x06002F97 RID: 12183 RVA: 0x000184B2 File Offset: 0x000166B2
		public unsafe int GrabbedItemQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_GrabbedItemQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_GrabbedItemQuantity)) = value;
			}
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06002F98 RID: 12184 RVA: 0x0011909C File Offset: 0x0011729C
		// (set) Token: 0x06002F99 RID: 12185 RVA: 0x000184CD File Offset: 0x000166CD
		public unsafe string SourceGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_SourceGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_SourceGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x06002F9A RID: 12186 RVA: 0x001190C4 File Offset: 0x001172C4
		// (set) Token: 0x06002F9B RID: 12187 RVA: 0x000184EC File Offset: 0x000166EC
		public unsafe string DestinationGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_DestinationGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_DestinationGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002025 RID: 8229
		private static readonly IntPtr NativeFieldInfoPtr_TemplateItemJSON;

		// Token: 0x04002026 RID: 8230
		private static readonly IntPtr NativeFieldInfoPtr_GrabbedItemQuantity;

		// Token: 0x04002027 RID: 8231
		private static readonly IntPtr NativeFieldInfoPtr_SourceGUID;

		// Token: 0x04002028 RID: 8232
		private static readonly IntPtr NativeFieldInfoPtr_DestinationGUID;

		// Token: 0x04002029 RID: 8233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Guid_Guid_0;
	}
}
