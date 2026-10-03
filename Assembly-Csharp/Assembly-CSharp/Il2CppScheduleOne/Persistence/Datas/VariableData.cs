using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027A RID: 634
	[Serializable]
	public class VariableData : SaveData
	{
		// Token: 0x06003194 RID: 12692 RVA: 0x0011ED58 File Offset: 0x0011CF58
		// Note: this type is marked as 'beforefieldinit'.
		static VariableData()
		{
			Il2CppClassPointerStore<VariableData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "VariableData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariableData>.NativeClassPtr);
			VariableData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableData>.NativeClassPtr, "Name");
			VariableData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableData>.NativeClassPtr, "Value");
			VariableData.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableData>.NativeClassPtr, 100669480);
			VariableData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableData>.NativeClassPtr, 100669481);
		}

		// Token: 0x06003195 RID: 12693 RVA: 0x0011EDD8 File Offset: 0x0011CFD8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 134800, RefRangeEnd = 134812, XrefRangeStart = 134800, XrefRangeEnd = 134812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VariableData(string name, string value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariableData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableData.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003196 RID: 12694 RVA: 0x0011EE38 File Offset: 0x0011D038
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135523, RefRangeEnd = 135524, XrefRangeStart = 135515, XrefRangeEnd = 135523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VariableData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariableData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003197 RID: 12695 RVA: 0x00019A06 File Offset: 0x00017C06
		public VariableData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x06003198 RID: 12696 RVA: 0x0011EE74 File Offset: 0x0011D074
		// (set) Token: 0x06003199 RID: 12697 RVA: 0x00019A0F File Offset: 0x00017C0F
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableData.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x0600319A RID: 12698 RVA: 0x0011EE9C File Offset: 0x0011D09C
		// (set) Token: 0x0600319B RID: 12699 RVA: 0x00019A2E File Offset: 0x00017C2E
		public unsafe string Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableData.NativeFieldInfoPtr_Value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableData.NativeFieldInfoPtr_Value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400210E RID: 8462
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x0400210F RID: 8463
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04002110 RID: 8464
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04002111 RID: 8465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
