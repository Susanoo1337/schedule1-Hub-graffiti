using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x020001A0 RID: 416
	public class InvokableCallList : Object
	{
		// Token: 0x06001F21 RID: 7969 RVA: 0x0007F250 File Offset: 0x0007D450
		// Note: this type is marked as 'beforefieldinit'.
		static InvokableCallList()
		{
			Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "InvokableCallList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr);
			InvokableCallList.NativeFieldInfoPtr_m_PersistentCalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, "m_PersistentCalls");
			InvokableCallList.NativeFieldInfoPtr_m_RuntimeCalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, "m_RuntimeCalls");
			InvokableCallList.NativeFieldInfoPtr_m_ExecutingCalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, "m_ExecutingCalls");
			InvokableCallList.NativeFieldInfoPtr_m_NeedsUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, "m_NeedsUpdate");
			InvokableCallList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100666679);
			InvokableCallList.NativeMethodInfoPtr_AddPersistentInvokableCall_Public_Void_BaseInvokableCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100666680);
			InvokableCallList.NativeMethodInfoPtr_AddListener_Public_Void_BaseInvokableCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100666681);
			InvokableCallList.NativeMethodInfoPtr_RemoveListener_Public_Void_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100666682);
			InvokableCallList.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100666683);
			InvokableCallList.NativeMethodInfoPtr_ClearPersistent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100666684);
			InvokableCallList.NativeMethodInfoPtr_PrepareInvoke_Public_List_1_BaseInvokableCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100666685);
			InvokableCallList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100666686);
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001F22 RID: 7970 RVA: 0x0007F370 File Offset: 0x0007D570
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283529, XrefRangeEnd = 1283530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x0007F3AC File Offset: 0x0007D5AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1283533, RefRangeEnd = 1283534, XrefRangeStart = 1283530, XrefRangeEnd = 1283533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPersistentInvokableCall(BaseInvokableCall call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_AddPersistentInvokableCall_Public_Void_BaseInvokableCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x0007F3F0 File Offset: 0x0007D5F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1283537, RefRangeEnd = 1283540, XrefRangeStart = 1283534, XrefRangeEnd = 1283537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddListener(BaseInvokableCall call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_AddListener_Public_Void_BaseInvokableCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x0007F434 File Offset: 0x0007D634
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1283574, RefRangeEnd = 1283576, XrefRangeStart = 1283540, XrefRangeEnd = 1283574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveListener(Object targetObj, MethodInfo method)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_RemoveListener_Public_Void_Object_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x0007F488 File Offset: 0x0007D688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283576, XrefRangeEnd = 1283585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x0007F4BC File Offset: 0x0007D6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283585, XrefRangeEnd = 1283594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPersistent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_ClearPersistent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x0007F4F0 File Offset: 0x0007D6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283594, XrefRangeEnd = 1283601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<BaseInvokableCall> PrepareInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_PrepareInvoke_Public_List_1_BaseInvokableCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<BaseInvokableCall>>(intPtr3) : null;
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x0007F530 File Offset: 0x0007D730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283601, XrefRangeEnd = 1283619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvokableCallList() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x0000E80F File Offset: 0x0000CA0F
		public InvokableCallList(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001F2B RID: 7979 RVA: 0x0007F56C File Offset: 0x0007D76C
		// (set) Token: 0x06001F2C RID: 7980 RVA: 0x0000E818 File Offset: 0x0000CA18
		public unsafe List<BaseInvokableCall> m_PersistentCalls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_PersistentCalls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseInvokableCall>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_PersistentCalls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001F2D RID: 7981 RVA: 0x0007F59C File Offset: 0x0007D79C
		// (set) Token: 0x06001F2E RID: 7982 RVA: 0x0000E837 File Offset: 0x0000CA37
		public unsafe List<BaseInvokableCall> m_RuntimeCalls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_RuntimeCalls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseInvokableCall>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_RuntimeCalls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001F2F RID: 7983 RVA: 0x0007F5CC File Offset: 0x0007D7CC
		// (set) Token: 0x06001F30 RID: 7984 RVA: 0x0000E856 File Offset: 0x0000CA56
		public unsafe List<BaseInvokableCall> m_ExecutingCalls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_ExecutingCalls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseInvokableCall>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_ExecutingCalls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001F31 RID: 7985 RVA: 0x0007F5FC File Offset: 0x0007D7FC
		// (set) Token: 0x06001F32 RID: 7986 RVA: 0x0000E875 File Offset: 0x0000CA75
		public unsafe bool m_NeedsUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_NeedsUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_NeedsUpdate)) = value;
			}
		}

		// Token: 0x04001966 RID: 6502
		private static readonly IntPtr NativeFieldInfoPtr_m_PersistentCalls;

		// Token: 0x04001967 RID: 6503
		private static readonly IntPtr NativeFieldInfoPtr_m_RuntimeCalls;

		// Token: 0x04001968 RID: 6504
		private static readonly IntPtr NativeFieldInfoPtr_m_ExecutingCalls;

		// Token: 0x04001969 RID: 6505
		private static readonly IntPtr NativeFieldInfoPtr_m_NeedsUpdate;

		// Token: 0x0400196A RID: 6506
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x0400196B RID: 6507
		private static readonly IntPtr NativeMethodInfoPtr_AddPersistentInvokableCall_Public_Void_BaseInvokableCall_0;

		// Token: 0x0400196C RID: 6508
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Void_BaseInvokableCall_0;

		// Token: 0x0400196D RID: 6509
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_Object_MethodInfo_0;

		// Token: 0x0400196E RID: 6510
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400196F RID: 6511
		private static readonly IntPtr NativeMethodInfoPtr_ClearPersistent_Public_Void_0;

		// Token: 0x04001970 RID: 6512
		private static readonly IntPtr NativeMethodInfoPtr_PrepareInvoke_Public_List_1_BaseInvokableCall_0;

		// Token: 0x04001971 RID: 6513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
