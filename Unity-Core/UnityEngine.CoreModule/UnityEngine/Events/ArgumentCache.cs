using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Events
{
	// Token: 0x02000195 RID: 405
	[Serializable]
	public class ArgumentCache : Object
	{
		// Token: 0x06001E8B RID: 7819 RVA: 0x0007C2A0 File Offset: 0x0007A4A0
		// Note: this type is marked as 'beforefieldinit'.
		static ArgumentCache()
		{
			Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "ArgumentCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr);
			ArgumentCache.NativeFieldInfoPtr_m_ObjectArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_ObjectArgument");
			ArgumentCache.NativeFieldInfoPtr_m_ObjectArgumentAssemblyTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_ObjectArgumentAssemblyTypeName");
			ArgumentCache.NativeFieldInfoPtr_m_IntArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_IntArgument");
			ArgumentCache.NativeFieldInfoPtr_m_FloatArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_FloatArgument");
			ArgumentCache.NativeFieldInfoPtr_m_StringArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_StringArgument");
			ArgumentCache.NativeFieldInfoPtr_m_BoolArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_BoolArgument");
			ArgumentCache.NativeMethodInfoPtr_get_unityObjectArgument_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100666587);
			ArgumentCache.NativeMethodInfoPtr_set_unityObjectArgument_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100666588);
			ArgumentCache.NativeMethodInfoPtr_get_unityObjectArgumentAssemblyTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100666589);
			ArgumentCache.NativeMethodInfoPtr_get_intArgument_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100666590);
			ArgumentCache.NativeMethodInfoPtr_set_intArgument_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100666591);
			ArgumentCache.NativeMethodInfoPtr_get_floatArgument_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100666592);
			ArgumentCache.NativeMethodInfoPtr_set_floatArgument_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100666593);
			ArgumentCache.NativeMethodInfoPtr_get_stringArgument_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100666594);
			ArgumentCache.NativeMethodInfoPtr_set_stringArgument_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100666595);
			ArgumentCache.NativeMethodInfoPtr_get_boolArgument_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100666596);
			ArgumentCache.NativeMethodInfoPtr_set_boolArgument_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100666597);
			ArgumentCache.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100666598);
			ArgumentCache.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100666599);
			ArgumentCache.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100666600);
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x0007C460 File Offset: 0x0007A660
		// (set) Token: 0x06001E8D RID: 7821 RVA: 0x0007C4A0 File Offset: 0x0007A6A0
		public unsafe Object unityObjectArgument
		{
			[CallerCount(179)]
			[CachedScanResults(RefRangeStart = 666825, RefRangeEnd = 667004, XrefRangeStart = 666825, XrefRangeEnd = 667004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_unityObjectArgument_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282737, XrefRangeEnd = 1282748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_set_unityObjectArgument_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x0007C4E4 File Offset: 0x0007A6E4
		public unsafe string unityObjectArgumentAssemblyTypeName
		{
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 667990, RefRangeEnd = 668022, XrefRangeStart = 667990, XrefRangeEnd = 668022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_unityObjectArgumentAssemblyTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001E8F RID: 7823 RVA: 0x0007C51C File Offset: 0x0007A71C
		// (set) Token: 0x06001E90 RID: 7824 RVA: 0x0007C558 File Offset: 0x0007A758
		public unsafe int intArgument
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1282748, RefRangeEnd = 1282757, XrefRangeStart = 1282748, XrefRangeEnd = 1282748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_intArgument_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29057, RefRangeEnd = 29058, XrefRangeStart = 29057, XrefRangeEnd = 29058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_set_intArgument_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001E91 RID: 7825 RVA: 0x0007C598 File Offset: 0x0007A798
		// (set) Token: 0x06001E92 RID: 7826 RVA: 0x0007C5D4 File Offset: 0x0007A7D4
		public unsafe float floatArgument
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1282757, RefRangeEnd = 1282765, XrefRangeStart = 1282757, XrefRangeEnd = 1282757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_floatArgument_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 29058, RefRangeEnd = 29072, XrefRangeStart = 29058, XrefRangeEnd = 29072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_set_floatArgument_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001E93 RID: 7827 RVA: 0x0007C614 File Offset: 0x0007A814
		// (set) Token: 0x06001E94 RID: 7828 RVA: 0x0007C64C File Offset: 0x0007A84C
		public unsafe string stringArgument
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 669368, RefRangeEnd = 669372, XrefRangeStart = 669368, XrefRangeEnd = 669372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_stringArgument_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_set_stringArgument_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001E95 RID: 7829 RVA: 0x0007C690 File Offset: 0x0007A890
		// (set) Token: 0x06001E96 RID: 7830 RVA: 0x0007C6CC File Offset: 0x0007A8CC
		public unsafe bool boolArgument
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1282765, RefRangeEnd = 1282766, XrefRangeStart = 1282765, XrefRangeEnd = 1282765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_boolArgument_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_set_boolArgument_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x0007C70C File Offset: 0x0007A90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282766, XrefRangeEnd = 1282768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x0007C740 File Offset: 0x0007A940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x0007C774 File Offset: 0x0007A974
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentCache() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x0000E59B File Offset: 0x0000C79B
		public ArgumentCache(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001E9B RID: 7835 RVA: 0x0007C7B0 File Offset: 0x0007A9B0
		// (set) Token: 0x06001E9C RID: 7836 RVA: 0x0000E5A4 File Offset: 0x0000C7A4
		public unsafe Object m_ObjectArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_ObjectArgument);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_ObjectArgument), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001E9D RID: 7837 RVA: 0x0007C7E0 File Offset: 0x0007A9E0
		// (set) Token: 0x06001E9E RID: 7838 RVA: 0x0000E5C3 File Offset: 0x0000C7C3
		public unsafe string m_ObjectArgumentAssemblyTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_ObjectArgumentAssemblyTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_ObjectArgumentAssemblyTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001E9F RID: 7839 RVA: 0x0007C808 File Offset: 0x0007AA08
		// (set) Token: 0x06001EA0 RID: 7840 RVA: 0x0000E5E2 File Offset: 0x0000C7E2
		public unsafe int m_IntArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_IntArgument);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_IntArgument)) = value;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001EA1 RID: 7841 RVA: 0x0007C830 File Offset: 0x0007AA30
		// (set) Token: 0x06001EA2 RID: 7842 RVA: 0x0000E5FD File Offset: 0x0000C7FD
		public unsafe float m_FloatArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_FloatArgument);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_FloatArgument)) = value;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001EA3 RID: 7843 RVA: 0x0007C858 File Offset: 0x0007AA58
		// (set) Token: 0x06001EA4 RID: 7844 RVA: 0x0000E618 File Offset: 0x0000C818
		public unsafe string m_StringArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_StringArgument);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_StringArgument), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001EA5 RID: 7845 RVA: 0x0007C880 File Offset: 0x0007AA80
		// (set) Token: 0x06001EA6 RID: 7846 RVA: 0x0000E637 File Offset: 0x0000C837
		public unsafe bool m_BoolArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_BoolArgument);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_BoolArgument)) = value;
			}
		}

		// Token: 0x040018F3 RID: 6387
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectArgument;

		// Token: 0x040018F4 RID: 6388
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectArgumentAssemblyTypeName;

		// Token: 0x040018F5 RID: 6389
		private static readonly IntPtr NativeFieldInfoPtr_m_IntArgument;

		// Token: 0x040018F6 RID: 6390
		private static readonly IntPtr NativeFieldInfoPtr_m_FloatArgument;

		// Token: 0x040018F7 RID: 6391
		private static readonly IntPtr NativeFieldInfoPtr_m_StringArgument;

		// Token: 0x040018F8 RID: 6392
		private static readonly IntPtr NativeFieldInfoPtr_m_BoolArgument;

		// Token: 0x040018F9 RID: 6393
		private static readonly IntPtr NativeMethodInfoPtr_get_unityObjectArgument_Public_get_Object_0;

		// Token: 0x040018FA RID: 6394
		private static readonly IntPtr NativeMethodInfoPtr_set_unityObjectArgument_Public_set_Void_Object_0;

		// Token: 0x040018FB RID: 6395
		private static readonly IntPtr NativeMethodInfoPtr_get_unityObjectArgumentAssemblyTypeName_Public_get_String_0;

		// Token: 0x040018FC RID: 6396
		private static readonly IntPtr NativeMethodInfoPtr_get_intArgument_Public_get_Int32_0;

		// Token: 0x040018FD RID: 6397
		private static readonly IntPtr NativeMethodInfoPtr_set_intArgument_Public_set_Void_Int32_0;

		// Token: 0x040018FE RID: 6398
		private static readonly IntPtr NativeMethodInfoPtr_get_floatArgument_Public_get_Single_0;

		// Token: 0x040018FF RID: 6399
		private static readonly IntPtr NativeMethodInfoPtr_set_floatArgument_Public_set_Void_Single_0;

		// Token: 0x04001900 RID: 6400
		private static readonly IntPtr NativeMethodInfoPtr_get_stringArgument_Public_get_String_0;

		// Token: 0x04001901 RID: 6401
		private static readonly IntPtr NativeMethodInfoPtr_set_stringArgument_Public_set_Void_String_0;

		// Token: 0x04001902 RID: 6402
		private static readonly IntPtr NativeMethodInfoPtr_get_boolArgument_Public_get_Boolean_0;

		// Token: 0x04001903 RID: 6403
		private static readonly IntPtr NativeMethodInfoPtr_set_boolArgument_Public_set_Void_Boolean_0;

		// Token: 0x04001904 RID: 6404
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001905 RID: 6405
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001906 RID: 6406
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
