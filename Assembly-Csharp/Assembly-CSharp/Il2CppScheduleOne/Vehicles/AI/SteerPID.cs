using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x020000ED RID: 237
	public class SteerPID : Object
	{
		// Token: 0x06001668 RID: 5736 RVA: 0x000C5CC8 File Offset: 0x000C3EC8
		// Note: this type is marked as 'beforefieldinit'.
		static SteerPID()
		{
			Il2CppClassPointerStore<SteerPID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "SteerPID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteerPID>.NativeClassPtr);
			SteerPID.NativeFieldInfoPtr_error_old = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteerPID>.NativeClassPtr, "error_old");
			SteerPID.NativeFieldInfoPtr_error_sum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteerPID>.NativeClassPtr, "error_sum");
			SteerPID.NativeMethodInfoPtr_GetNewValue_Public_Single_Single_PID_Parameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteerPID>.NativeClassPtr, 100666436);
			SteerPID.NativeMethodInfoPtr_AddValueToAverage_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteerPID>.NativeClassPtr, 100666437);
			SteerPID.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteerPID>.NativeClassPtr, 100666438);
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x000C5D5C File Offset: 0x000C3F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95925, XrefRangeEnd = 95927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetNewValue(float error, PID_Parameters pid_parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref error;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pid_parameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteerPID.NativeMethodInfoPtr_GetNewValue_Public_Single_Single_PID_Parameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x000C5DB4 File Offset: 0x000C3FB4
		[CallerCount(0)]
		public unsafe static float AddValueToAverage(float oldAverage, float valueToAdd, float count)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldAverage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueToAdd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteerPID.NativeMethodInfoPtr_AddValueToAverage_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x000C5E10 File Offset: 0x000C4010
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteerPID() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteerPID>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteerPID.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x0000C46C File Offset: 0x0000A66C
		public SteerPID(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x0600166D RID: 5741 RVA: 0x000C5E4C File Offset: 0x000C404C
		// (set) Token: 0x0600166E RID: 5742 RVA: 0x0000C475 File Offset: 0x0000A675
		public unsafe float error_old
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteerPID.NativeFieldInfoPtr_error_old);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteerPID.NativeFieldInfoPtr_error_old)) = value;
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x0600166F RID: 5743 RVA: 0x000C5E74 File Offset: 0x000C4074
		// (set) Token: 0x06001670 RID: 5744 RVA: 0x0000C490 File Offset: 0x0000A690
		public unsafe float error_sum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteerPID.NativeFieldInfoPtr_error_sum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteerPID.NativeFieldInfoPtr_error_sum)) = value;
			}
		}

		// Token: 0x04000FAD RID: 4013
		private static readonly IntPtr NativeFieldInfoPtr_error_old;

		// Token: 0x04000FAE RID: 4014
		private static readonly IntPtr NativeFieldInfoPtr_error_sum;

		// Token: 0x04000FAF RID: 4015
		private static readonly IntPtr NativeMethodInfoPtr_GetNewValue_Public_Single_Single_PID_Parameters_0;

		// Token: 0x04000FB0 RID: 4016
		private static readonly IntPtr NativeMethodInfoPtr_AddValueToAverage_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04000FB1 RID: 4017
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
