using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Relation
{
	// Token: 0x020005E4 RID: 1508
	public class NPCUnlockedVariable : MonoBehaviour
	{
		// Token: 0x060094B8 RID: 38072 RVA: 0x00282C90 File Offset: 0x00280E90
		// Note: this type is marked as 'beforefieldinit'.
		static NPCUnlockedVariable()
		{
			Il2CppClassPointerStore<NPCUnlockedVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Relation", "NPCUnlockedVariable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCUnlockedVariable>.NativeClassPtr);
			NPCUnlockedVariable.NativeFieldInfoPtr_VariableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCUnlockedVariable>.NativeClassPtr, "VariableName");
			NPCUnlockedVariable.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCUnlockedVariable>.NativeClassPtr, 100682747);
			NPCUnlockedVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCUnlockedVariable>.NativeClassPtr, 100682748);
			NPCUnlockedVariable.NativeMethodInfoPtr_Method_Private_Void_EUnlockType_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCUnlockedVariable>.NativeClassPtr, 100682749);
		}

		// Token: 0x060094B9 RID: 38073 RVA: 0x00282D10 File Offset: 0x00280F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271977, XrefRangeEnd = 271987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCUnlockedVariable.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094BA RID: 38074 RVA: 0x00282D44 File Offset: 0x00280F44
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCUnlockedVariable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCUnlockedVariable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCUnlockedVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094BB RID: 38075 RVA: 0x00282D80 File Offset: 0x00280F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271987, XrefRangeEnd = 271999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_EUnlockType_Boolean_PDM_0(NPCRelationData.EUnlockType unlockType, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref unlockType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCUnlockedVariable.NativeMethodInfoPtr_Method_Private_Void_EUnlockType_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094BC RID: 38076 RVA: 0x00045903 File Offset: 0x00043B03
		public NPCUnlockedVariable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DF0 RID: 11760
		// (get) Token: 0x060094BD RID: 38077 RVA: 0x00282DCC File Offset: 0x00280FCC
		// (set) Token: 0x060094BE RID: 38078 RVA: 0x0004590C File Offset: 0x00043B0C
		public unsafe string VariableName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCUnlockedVariable.NativeFieldInfoPtr_VariableName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCUnlockedVariable.NativeFieldInfoPtr_VariableName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400667B RID: 26235
		private static readonly IntPtr NativeFieldInfoPtr_VariableName;

		// Token: 0x0400667C RID: 26236
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400667D RID: 26237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400667E RID: 26238
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_EUnlockType_Boolean_PDM_0;
	}
}
