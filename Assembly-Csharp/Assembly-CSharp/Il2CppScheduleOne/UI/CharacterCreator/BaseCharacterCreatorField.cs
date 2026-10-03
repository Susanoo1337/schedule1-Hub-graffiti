using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Customization;
using UnityEngine;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x0200081B RID: 2075
	public class BaseCharacterCreatorField : MonoBehaviour
	{
		// Token: 0x0600C9D8 RID: 51672 RVA: 0x0032EBB4 File Offset: 0x0032CDB4
		// Note: this type is marked as 'beforefieldinit'.
		static BaseCharacterCreatorField()
		{
			Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "BaseCharacterCreatorField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr);
			BaseCharacterCreatorField.NativeFieldInfoPtr_PropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, "PropertyName");
			BaseCharacterCreatorField.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, "Category");
			BaseCharacterCreatorField.NativeFieldInfoPtr_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, "Creator");
			BaseCharacterCreatorField.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, 100689343);
			BaseCharacterCreatorField.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, 100689344);
			BaseCharacterCreatorField.NativeMethodInfoPtr_ApplyValue_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, 100689345);
			BaseCharacterCreatorField.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, 100689346);
			BaseCharacterCreatorField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, 100689347);
		}

		// Token: 0x0600C9D9 RID: 51673 RVA: 0x0032EC84 File Offset: 0x0032CE84
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCharacterCreatorField.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C9DA RID: 51674 RVA: 0x0032ECC0 File Offset: 0x0032CEC0
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCharacterCreatorField.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C9DB RID: 51675 RVA: 0x0032ECFC File Offset: 0x0032CEFC
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCharacterCreatorField.NativeMethodInfoPtr_ApplyValue_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C9DC RID: 51676 RVA: 0x0032ED38 File Offset: 0x0032CF38
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(bool applyValue = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref applyValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCharacterCreatorField.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C9DD RID: 51677 RVA: 0x0032ED84 File Offset: 0x0032CF84
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseCharacterCreatorField() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseCharacterCreatorField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C9DE RID: 51678 RVA: 0x0005FAA2 File Offset: 0x0005DCA2
		public BaseCharacterCreatorField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003D50 RID: 15696
		// (get) Token: 0x0600C9DF RID: 51679 RVA: 0x0032EDC0 File Offset: 0x0032CFC0
		// (set) Token: 0x0600C9E0 RID: 51680 RVA: 0x0005FAAB File Offset: 0x0005DCAB
		public unsafe string PropertyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_PropertyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_PropertyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003D51 RID: 15697
		// (get) Token: 0x0600C9E1 RID: 51681 RVA: 0x0032EDE8 File Offset: 0x0032CFE8
		// (set) Token: 0x0600C9E2 RID: 51682 RVA: 0x0005FACA File Offset: 0x0005DCCA
		public unsafe CharacterCreator.ECategory Category
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_Category);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_Category)) = value;
			}
		}

		// Token: 0x17003D52 RID: 15698
		// (get) Token: 0x0600C9E3 RID: 51683 RVA: 0x0032EE10 File Offset: 0x0032D010
		// (set) Token: 0x0600C9E4 RID: 51684 RVA: 0x0005FAE5 File Offset: 0x0005DCE5
		public unsafe CharacterCreator Creator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_Creator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCreator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_Creator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400897C RID: 35196
		private static readonly IntPtr NativeFieldInfoPtr_PropertyName;

		// Token: 0x0400897D RID: 35197
		private static readonly IntPtr NativeFieldInfoPtr_Category;

		// Token: 0x0400897E RID: 35198
		private static readonly IntPtr NativeFieldInfoPtr_Creator;

		// Token: 0x0400897F RID: 35199
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04008980 RID: 35200
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04008981 RID: 35201
		private static readonly IntPtr NativeMethodInfoPtr_ApplyValue_Public_Virtual_New_Void_0;

		// Token: 0x04008982 RID: 35202
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04008983 RID: 35203
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
