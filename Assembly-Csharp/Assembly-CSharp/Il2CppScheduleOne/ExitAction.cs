using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne
{
	// Token: 0x020000BE RID: 190
	public class ExitAction : Object
	{
		// Token: 0x0600112D RID: 4397 RVA: 0x000B4A28 File Offset: 0x000B2C28
		// Note: this type is marked as 'beforefieldinit'.
		static ExitAction()
		{
			Il2CppClassPointerStore<ExitAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "ExitAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExitAction>.NativeClassPtr);
			ExitAction.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, "<Type>k__BackingField");
			ExitAction.NativeFieldInfoPtr_used = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, "used");
			ExitAction.NativeMethodInfoPtr_get_Type_Public_get_ExitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, 100665807);
			ExitAction.NativeMethodInfoPtr_set_Type_Private_set_Void_ExitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, 100665808);
			ExitAction.NativeMethodInfoPtr_get_Used_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, 100665809);
			ExitAction.NativeMethodInfoPtr_set_Used_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, 100665810);
			ExitAction.NativeMethodInfoPtr__ctor_Public_Void_ExitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, 100665811);
			ExitAction.NativeMethodInfoPtr_Use_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, 100665812);
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x0600112E RID: 4398 RVA: 0x000B4AF8 File Offset: 0x000B2CF8
		// (set) Token: 0x0600112F RID: 4399 RVA: 0x000B4B34 File Offset: 0x000B2D34
		public unsafe ExitType Type
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29049, RefRangeEnd = 29051, XrefRangeStart = 29049, XrefRangeEnd = 29051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitAction.NativeMethodInfoPtr_get_Type_Public_get_ExitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 29051, RefRangeEnd = 29056, XrefRangeStart = 29051, XrefRangeEnd = 29056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitAction.NativeMethodInfoPtr_set_Type_Private_set_Void_ExitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x000B4B74 File Offset: 0x000B2D74
		// (set) Token: 0x06001131 RID: 4401 RVA: 0x000B4BB0 File Offset: 0x000B2DB0
		public unsafe bool Used
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitAction.NativeMethodInfoPtr_get_Used_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 89314, RefRangeEnd = 89352, XrefRangeStart = 89314, XrefRangeEnd = 89314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitAction.NativeMethodInfoPtr_set_Used_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x000B4BF0 File Offset: 0x000B2DF0
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExitAction(ExitType type) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExitAction>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitAction.NativeMethodInfoPtr__ctor_Public_Void_ExitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x000B4C38 File Offset: 0x000B2E38
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 89352, RefRangeEnd = 89362, XrefRangeStart = 89352, XrefRangeEnd = 89352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Use()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitAction.NativeMethodInfoPtr_Use_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x00009ECF File Offset: 0x000080CF
		public ExitAction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001135 RID: 4405 RVA: 0x000B4C6C File Offset: 0x000B2E6C
		// (set) Token: 0x06001136 RID: 4406 RVA: 0x00009ED8 File Offset: 0x000080D8
		public unsafe ExitType _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitAction.NativeFieldInfoPtr__Type_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitAction.NativeFieldInfoPtr__Type_k__BackingField)) = value;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x000B4C94 File Offset: 0x000B2E94
		// (set) Token: 0x06001138 RID: 4408 RVA: 0x00009EF3 File Offset: 0x000080F3
		public unsafe bool used
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitAction.NativeFieldInfoPtr_used);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitAction.NativeFieldInfoPtr_used)) = value;
			}
		}

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeFieldInfoPtr_used;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_ExitType_0;

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Private_set_Void_ExitType_0;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeMethodInfoPtr_get_Used_Public_get_Boolean_0;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeMethodInfoPtr_set_Used_Public_set_Void_Boolean_0;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ExitType_0;

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeMethodInfoPtr_Use_Public_Void_0;
	}
}
