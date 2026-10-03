using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.NPCs.Responses;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Employees
{
	// Token: 0x02000383 RID: 899
	public class NPCResponses_Employee : NPCResponses
	{
		// Token: 0x06004F73 RID: 20339 RVA: 0x0018D0F8 File Offset: 0x0018B2F8
		// Note: this type is marked as 'beforefieldinit'.
		static NPCResponses_Employee()
		{
			Il2CppClassPointerStore<NPCResponses_Employee>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Employees", "NPCResponses_Employee");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCResponses_Employee>.NativeClassPtr);
			NPCResponses_Employee.NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Employee>.NativeClassPtr, 100673646);
			NPCResponses_Employee.NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Employee>.NativeClassPtr, 100673647);
			NPCResponses_Employee.NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Employee>.NativeClassPtr, 100673648);
			NPCResponses_Employee.NativeMethodInfoPtr_Ow_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Employee>.NativeClassPtr, 100673649);
			NPCResponses_Employee.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Employee>.NativeClassPtr, 100673650);
		}

		// Token: 0x06004F74 RID: 20340 RVA: 0x0018D18C File Offset: 0x0018B38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178379, XrefRangeEnd = 178381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Employee.NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F75 RID: 20341 RVA: 0x0018D1EC File Offset: 0x0018B3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178381, XrefRangeEnd = 178383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Employee.NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F76 RID: 20342 RVA: 0x0018D24C File Offset: 0x0018B44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Employee.NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F77 RID: 20343 RVA: 0x0018D2AC File Offset: 0x0018B4AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 178391, RefRangeEnd = 178394, XrefRangeStart = 178383, XrefRangeEnd = 178391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Ow(Player perpetrator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses_Employee.NativeMethodInfoPtr_Ow_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F78 RID: 20344 RVA: 0x0018D2F0 File Offset: 0x0018B4F0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCResponses_Employee() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCResponses_Employee>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses_Employee.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F79 RID: 20345 RVA: 0x00025E72 File Offset: 0x00024072
		public NPCResponses_Employee(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003686 RID: 13958
		private static readonly IntPtr NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_Void_Player_Impact_0;

		// Token: 0x04003687 RID: 13959
		private static readonly IntPtr NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_Void_Player_Impact_0;

		// Token: 0x04003688 RID: 13960
		private static readonly IntPtr NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_Void_Player_Impact_0;

		// Token: 0x04003689 RID: 13961
		private static readonly IntPtr NativeMethodInfoPtr_Ow_Private_Void_Player_0;

		// Token: 0x0400368A RID: 13962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
