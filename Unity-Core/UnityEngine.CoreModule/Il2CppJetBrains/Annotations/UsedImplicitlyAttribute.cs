using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppJetBrains.Annotations
{
	// Token: 0x0200005E RID: 94
	public sealed class UsedImplicitlyAttribute : Attribute
	{
		// Token: 0x06000311 RID: 785 RVA: 0x0002110C File Offset: 0x0001F30C
		// Note: this type is marked as 'beforefieldinit'.
		static UsedImplicitlyAttribute()
		{
			Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "JetBrains.Annotations", "UsedImplicitlyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr);
			UsedImplicitlyAttribute.NativeFieldInfoPtr__UseKindFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr, "<UseKindFlags>k__BackingField");
			UsedImplicitlyAttribute.NativeFieldInfoPtr__TargetFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr, "<TargetFlags>k__BackingField");
			UsedImplicitlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr, 100663601);
			UsedImplicitlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_ImplicitUseKindFlags_ImplicitUseTargetFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr, 100663602);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0002118C File Offset: 0x0001F38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226623, XrefRangeEnd = 1226624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UsedImplicitlyAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UsedImplicitlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x000211C8 File Offset: 0x0001F3C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref useKindFlags;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UsedImplicitlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_ImplicitUseKindFlags_ImplicitUseTargetFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00003928 File Offset: 0x00001B28
		public UsedImplicitlyAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00021220 File Offset: 0x0001F420
		// (set) Token: 0x06000316 RID: 790 RVA: 0x00003931 File Offset: 0x00001B31
		public unsafe ImplicitUseKindFlags _UseKindFlags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsedImplicitlyAttribute.NativeFieldInfoPtr__UseKindFlags_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsedImplicitlyAttribute.NativeFieldInfoPtr__UseKindFlags_k__BackingField)) = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00021248 File Offset: 0x0001F448
		// (set) Token: 0x06000318 RID: 792 RVA: 0x0000394C File Offset: 0x00001B4C
		public unsafe ImplicitUseTargetFlags _TargetFlags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsedImplicitlyAttribute.NativeFieldInfoPtr__TargetFlags_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsedImplicitlyAttribute.NativeFieldInfoPtr__TargetFlags_k__BackingField)) = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00003967 File Offset: 0x00001B67
		public ImplicitUseKindFlags UseKindFlags
		{
			get
			{
				return this._UseKindFlags_k__BackingField;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0000396F File Offset: 0x00001B6F
		public ImplicitUseTargetFlags TargetFlags
		{
			get
			{
				return this._TargetFlags_k__BackingField;
			}
		}

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeFieldInfoPtr__UseKindFlags_k__BackingField;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeFieldInfoPtr__TargetFlags_k__BackingField;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ImplicitUseKindFlags_ImplicitUseTargetFlags_0;
	}
}
