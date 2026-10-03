using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ScriptableObjects;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004F1 RID: 1265
	public class PhoneCallUtility : MonoBehaviour
	{
		// Token: 0x060072B0 RID: 29360 RVA: 0x00204340 File Offset: 0x00202540
		// Note: this type is marked as 'beforefieldinit'.
		static PhoneCallUtility()
		{
			Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "PhoneCallUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr);
			PhoneCallUtility.NativeMethodInfoPtr_PromptCall_Public_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678133);
			PhoneCallUtility.NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678134);
			PhoneCallUtility.NativeMethodInfoPtr_SetQueuedCall_Public_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678135);
			PhoneCallUtility.NativeMethodInfoPtr_ClearCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678136);
			PhoneCallUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678137);
		}

		// Token: 0x060072B1 RID: 29361 RVA: 0x002043D4 File Offset: 0x002025D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226696, XrefRangeEnd = 226702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PromptCall(PhoneCallData callData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr_PromptCall_Public_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072B2 RID: 29362 RVA: 0x00204418 File Offset: 0x00202618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226702, XrefRangeEnd = 226708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartCall(PhoneCallData callData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072B3 RID: 29363 RVA: 0x0020445C File Offset: 0x0020265C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226708, XrefRangeEnd = 226714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQueuedCall(PhoneCallData callData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr_SetQueuedCall_Public_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072B4 RID: 29364 RVA: 0x002044A0 File Offset: 0x002026A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226714, XrefRangeEnd = 226720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr_ClearCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072B5 RID: 29365 RVA: 0x002044D4 File Offset: 0x002026D4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhoneCallUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072B6 RID: 29366 RVA: 0x00036874 File Offset: 0x00034A74
		public PhoneCallUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004E53 RID: 20051
		private static readonly IntPtr NativeMethodInfoPtr_PromptCall_Public_Void_PhoneCallData_0;

		// Token: 0x04004E54 RID: 20052
		private static readonly IntPtr NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_0;

		// Token: 0x04004E55 RID: 20053
		private static readonly IntPtr NativeMethodInfoPtr_SetQueuedCall_Public_Void_PhoneCallData_0;

		// Token: 0x04004E56 RID: 20054
		private static readonly IntPtr NativeMethodInfoPtr_ClearCall_Public_Void_0;

		// Token: 0x04004E57 RID: 20055
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
