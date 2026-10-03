using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x020000F5 RID: 245
	[Serializable]
	public class Condition : Object
	{
		// Token: 0x06001775 RID: 6005 RVA: 0x000C8AD0 File Offset: 0x000C6CD0
		// Note: this type is marked as 'beforefieldinit'.
		static Condition()
		{
			Il2CppClassPointerStore<Condition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "Condition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Condition>.NativeClassPtr);
			Condition.NativeFieldInfoPtr_VariableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Condition>.NativeClassPtr, "VariableName");
			Condition.NativeFieldInfoPtr_Operator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Condition>.NativeClassPtr, "Operator");
			Condition.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Condition>.NativeClassPtr, "Value");
			Condition.NativeMethodInfoPtr_Evaluate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100666517);
			Condition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100666518);
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x000C8B64 File Offset: 0x000C6D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97214, XrefRangeEnd = 97231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_Evaluate_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x000C8BA0 File Offset: 0x000C6DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97231, XrefRangeEnd = 97240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Condition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Condition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x0000CE2D File Offset: 0x0000B02D
		public Condition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001779 RID: 6009 RVA: 0x000C8BDC File Offset: 0x000C6DDC
		// (set) Token: 0x0600177A RID: 6010 RVA: 0x0000CE36 File Offset: 0x0000B036
		public unsafe string VariableName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_VariableName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_VariableName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x0600177B RID: 6011 RVA: 0x000C8C04 File Offset: 0x000C6E04
		// (set) Token: 0x0600177C RID: 6012 RVA: 0x0000CE55 File Offset: 0x0000B055
		public unsafe Condition.EConditionType Operator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_Operator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_Operator)) = value;
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x000C8C2C File Offset: 0x000C6E2C
		// (set) Token: 0x0600177E RID: 6014 RVA: 0x0000CE70 File Offset: 0x0000B070
		public unsafe string Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_Value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_Value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001059 RID: 4185
		private static readonly IntPtr NativeFieldInfoPtr_VariableName;

		// Token: 0x0400105A RID: 4186
		private static readonly IntPtr NativeFieldInfoPtr_Operator;

		// Token: 0x0400105B RID: 4187
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Boolean_0;

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000936 RID: 2358
		[OriginalName("Assembly-CSharp.dll", "", "EConditionType")]
		public enum EConditionType
		{
			// Token: 0x04009349 RID: 37705
			GreaterThan,
			// Token: 0x0400934A RID: 37706
			LessThan,
			// Token: 0x0400934B RID: 37707
			EqualTo,
			// Token: 0x0400934C RID: 37708
			NotEqualTo,
			// Token: 0x0400934D RID: 37709
			GreaterThanOrEqualTo,
			// Token: 0x0400934E RID: 37710
			LessThanOrEqualTo
		}
	}
}
