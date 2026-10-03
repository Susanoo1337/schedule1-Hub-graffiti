using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.Property;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000235 RID: 565
	[Serializable]
	public class ManorData : PropertyData
	{
		// Token: 0x06002F1A RID: 12058 RVA: 0x00117A18 File Offset: 0x00115C18
		// Note: this type is marked as 'beforefieldinit'.
		static ManorData()
		{
			Il2CppClassPointerStore<ManorData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ManorData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManorData>.NativeClassPtr);
			ManorData.NativeFieldInfoPtr_ManorState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorData>.NativeClassPtr, "ManorState");
			ManorData.NativeFieldInfoPtr_DaysSinceStateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorData>.NativeClassPtr, "DaysSinceStateChange");
			ManorData.NativeFieldInfoPtr_TunnelDug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorData>.NativeClassPtr, "TunnelDug");
			ManorData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_DynamicSaveData_Il2CppReferenceArray_1_DynamicSaveData_EManorState_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorData>.NativeClassPtr, 100669402);
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x00117A98 File Offset: 0x00115C98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134977, RefRangeEnd = 134978, XrefRangeStart = 134971, XrefRangeEnd = 134977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManorData(string propertyCode, bool isOwned, Il2CppStructArray<bool> switchStates, Il2CppStructArray<bool> toggleableStates, Il2CppReferenceArray<DynamicSaveData> employees, Il2CppReferenceArray<DynamicSaveData> objects, Manor.EManorState state, int daysSinceStateChange, bool tunnelDug) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManorData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOwned;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(switchStates);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toggleableStates);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(employees);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref daysSinceStateChange;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tunnelDug;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_DynamicSaveData_Il2CppReferenceArray_1_DynamicSaveData_EManorState_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x00017F83 File Offset: 0x00016183
		public ManorData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x06002F1D RID: 12061 RVA: 0x00117B68 File Offset: 0x00115D68
		// (set) Token: 0x06002F1E RID: 12062 RVA: 0x00017F8C File Offset: 0x0001618C
		public unsafe Manor.EManorState ManorState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorData.NativeFieldInfoPtr_ManorState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorData.NativeFieldInfoPtr_ManorState)) = value;
			}
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x06002F1F RID: 12063 RVA: 0x00117B90 File Offset: 0x00115D90
		// (set) Token: 0x06002F20 RID: 12064 RVA: 0x00017FA7 File Offset: 0x000161A7
		public unsafe int DaysSinceStateChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorData.NativeFieldInfoPtr_DaysSinceStateChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorData.NativeFieldInfoPtr_DaysSinceStateChange)) = value;
			}
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x06002F21 RID: 12065 RVA: 0x00117BB8 File Offset: 0x00115DB8
		// (set) Token: 0x06002F22 RID: 12066 RVA: 0x00017FC2 File Offset: 0x000161C2
		public unsafe bool TunnelDug
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorData.NativeFieldInfoPtr_TunnelDug);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorData.NativeFieldInfoPtr_TunnelDug)) = value;
			}
		}

		// Token: 0x04001FEF RID: 8175
		private static readonly IntPtr NativeFieldInfoPtr_ManorState;

		// Token: 0x04001FF0 RID: 8176
		private static readonly IntPtr NativeFieldInfoPtr_DaysSinceStateChange;

		// Token: 0x04001FF1 RID: 8177
		private static readonly IntPtr NativeFieldInfoPtr_TunnelDug;

		// Token: 0x04001FF2 RID: 8178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStructArray_1_Boolean_Il2CppStructArray_1_Boolean_Il2CppReferenceArray_1_DynamicSaveData_Il2CppReferenceArray_1_DynamicSaveData_EManorState_Int32_Boolean_0;
	}
}
