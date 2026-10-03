using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000279 RID: 633
	[Serializable]
	public class VariableCollectionData : SaveData
	{
		// Token: 0x0600318F RID: 12687 RVA: 0x0011EC84 File Offset: 0x0011CE84
		// Note: this type is marked as 'beforefieldinit'.
		static VariableCollectionData()
		{
			Il2CppClassPointerStore<VariableCollectionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "VariableCollectionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariableCollectionData>.NativeClassPtr);
			VariableCollectionData.NativeFieldInfoPtr_Variables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableCollectionData>.NativeClassPtr, "Variables");
			VariableCollectionData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableCollectionData>.NativeClassPtr, 100669479);
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x0011ECDC File Offset: 0x0011CEDC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 134314, RefRangeEnd = 134323, XrefRangeStart = 134314, XrefRangeEnd = 134323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VariableCollectionData(Il2CppReferenceArray<VariableData> variables) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariableCollectionData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(variables);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableCollectionData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_VariableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x000199DE File Offset: 0x00017BDE
		public VariableCollectionData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x06003192 RID: 12690 RVA: 0x0011ED28 File Offset: 0x0011CF28
		// (set) Token: 0x06003193 RID: 12691 RVA: 0x000199E7 File Offset: 0x00017BE7
		public unsafe Il2CppReferenceArray<VariableData> Variables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCollectionData.NativeFieldInfoPtr_Variables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VariableData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCollectionData.NativeFieldInfoPtr_Variables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400210C RID: 8460
		private static readonly IntPtr NativeFieldInfoPtr_Variables;

		// Token: 0x0400210D RID: 8461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_VariableData_0;
	}
}
