using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200023F RID: 575
	[StructLayout(2)]
	public struct StencilState
	{
		// Token: 0x06002752 RID: 10066 RVA: 0x0009BD60 File Offset: 0x00099F60
		// Note: this type is marked as 'beforefieldinit'.
		static StencilState()
		{
			Il2CppClassPointerStore<StencilState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "StencilState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StencilState>.NativeClassPtr);
			StencilState.NativeFieldInfoPtr_m_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_Enabled");
			StencilState.NativeFieldInfoPtr_m_ReadMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_ReadMask");
			StencilState.NativeFieldInfoPtr_m_WriteMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_WriteMask");
			StencilState.NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_Padding");
			StencilState.NativeFieldInfoPtr_m_CompareFunctionFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_CompareFunctionFront");
			StencilState.NativeFieldInfoPtr_m_PassOperationFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_PassOperationFront");
			StencilState.NativeFieldInfoPtr_m_FailOperationFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_FailOperationFront");
			StencilState.NativeFieldInfoPtr_m_ZFailOperationFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_ZFailOperationFront");
			StencilState.NativeFieldInfoPtr_m_CompareFunctionBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_CompareFunctionBack");
			StencilState.NativeFieldInfoPtr_m_PassOperationBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_PassOperationBack");
			StencilState.NativeFieldInfoPtr_m_FailOperationBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_FailOperationBack");
			StencilState.NativeFieldInfoPtr_m_ZFailOperationBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_ZFailOperationBack");
			StencilState.NativeMethodInfoPtr_get_defaultValue_Public_Static_get_StencilState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667539);
			StencilState.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Byte_Byte_CompareFunction_StencilOp_StencilOp_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667540);
			StencilState.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Byte_Byte_CompareFunction_StencilOp_StencilOp_StencilOp_CompareFunction_StencilOp_StencilOp_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667541);
			StencilState.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667542);
			StencilState.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667543);
			StencilState.NativeMethodInfoPtr_get_readMask_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667544);
			StencilState.NativeMethodInfoPtr_set_readMask_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667545);
			StencilState.NativeMethodInfoPtr_get_writeMask_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667546);
			StencilState.NativeMethodInfoPtr_set_writeMask_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667547);
			StencilState.NativeMethodInfoPtr_SetCompareFunction_Public_Void_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667548);
			StencilState.NativeMethodInfoPtr_SetPassOperation_Public_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667549);
			StencilState.NativeMethodInfoPtr_SetFailOperation_Public_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667550);
			StencilState.NativeMethodInfoPtr_SetZFailOperation_Public_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667551);
			StencilState.NativeMethodInfoPtr_get_compareFunctionFront_Public_get_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667552);
			StencilState.NativeMethodInfoPtr_set_compareFunctionFront_Public_set_Void_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667553);
			StencilState.NativeMethodInfoPtr_get_passOperationFront_Public_get_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667554);
			StencilState.NativeMethodInfoPtr_set_passOperationFront_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667555);
			StencilState.NativeMethodInfoPtr_get_failOperationFront_Public_get_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667556);
			StencilState.NativeMethodInfoPtr_set_failOperationFront_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667557);
			StencilState.NativeMethodInfoPtr_get_zFailOperationFront_Public_get_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667558);
			StencilState.NativeMethodInfoPtr_set_zFailOperationFront_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667559);
			StencilState.NativeMethodInfoPtr_get_compareFunctionBack_Public_get_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667560);
			StencilState.NativeMethodInfoPtr_set_compareFunctionBack_Public_set_Void_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667561);
			StencilState.NativeMethodInfoPtr_get_passOperationBack_Public_get_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667562);
			StencilState.NativeMethodInfoPtr_set_passOperationBack_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667563);
			StencilState.NativeMethodInfoPtr_get_failOperationBack_Public_get_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667564);
			StencilState.NativeMethodInfoPtr_set_failOperationBack_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667565);
			StencilState.NativeMethodInfoPtr_get_zFailOperationBack_Public_get_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667566);
			StencilState.NativeMethodInfoPtr_set_zFailOperationBack_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667567);
			StencilState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StencilState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667568);
			StencilState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667569);
			StencilState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100667570);
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06002753 RID: 10067 RVA: 0x0009C100 File Offset: 0x0009A300
		public unsafe static StencilState defaultValue
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1291930, RefRangeEnd = 1291933, XrefRangeStart = 1291926, XrefRangeEnd = 1291930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_defaultValue_Public_Static_get_StencilState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x0009C130 File Offset: 0x0009A330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291933, XrefRangeEnd = 1291934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StencilState(bool enabled = true, byte readMask = 255, byte writeMask = 255, CompareFunction compareFunction = CompareFunction.Always, StencilOp passOperation = StencilOp.Keep, StencilOp failOperation = StencilOp.Keep, StencilOp zFailOperation = StencilOp.Keep)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readMask;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compareFunction;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passOperation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref failOperation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zFailOperation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Byte_Byte_CompareFunction_StencilOp_StencilOp_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x0009C1B8 File Offset: 0x0009A3B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1291938, RefRangeEnd = 1291942, XrefRangeStart = 1291934, XrefRangeEnd = 1291938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StencilState(bool enabled, byte readMask, byte writeMask, CompareFunction compareFunctionFront, StencilOp passOperationFront, StencilOp failOperationFront, StencilOp zFailOperationFront, CompareFunction compareFunctionBack, StencilOp passOperationBack, StencilOp failOperationBack, StencilOp zFailOperationBack)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readMask;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeMask;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compareFunctionFront;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passOperationFront;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref failOperationFront;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zFailOperationFront;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compareFunctionBack;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passOperationBack;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref failOperationBack;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zFailOperationBack;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Byte_Byte_CompareFunction_StencilOp_StencilOp_StencilOp_CompareFunction_StencilOp_StencilOp_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06002756 RID: 10070 RVA: 0x0009C27C File Offset: 0x0009A47C
		// (set) Token: 0x06002757 RID: 10071 RVA: 0x0009C2AC File Offset: 0x0009A4AC
		public unsafe bool enabled
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1291946, RefRangeEnd = 1291949, XrefRangeStart = 1291942, XrefRangeEnd = 1291946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1291953, RefRangeEnd = 1291957, XrefRangeStart = 1291949, XrefRangeEnd = 1291953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06002758 RID: 10072 RVA: 0x0009C2E0 File Offset: 0x0009A4E0
		// (set) Token: 0x06002759 RID: 10073 RVA: 0x0009C310 File Offset: 0x0009A510
		public unsafe byte readMask
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1291957, RefRangeEnd = 1291959, XrefRangeStart = 1291957, XrefRangeEnd = 1291957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_readMask_Public_get_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1041432, RefRangeEnd = 1041433, XrefRangeStart = 1041432, XrefRangeEnd = 1041433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_readMask_Public_set_Void_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x0600275A RID: 10074 RVA: 0x0009C344 File Offset: 0x0009A544
		// (set) Token: 0x0600275B RID: 10075 RVA: 0x0009C374 File Offset: 0x0009A574
		public unsafe byte writeMask
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1291959, RefRangeEnd = 1291961, XrefRangeStart = 1291959, XrefRangeEnd = 1291959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_writeMask_Public_get_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1041351, RefRangeEnd = 1041353, XrefRangeStart = 1041351, XrefRangeEnd = 1041353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_writeMask_Public_set_Void_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x0009C3A8 File Offset: 0x0009A5A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1291961, RefRangeEnd = 1291964, XrefRangeStart = 1291961, XrefRangeEnd = 1291961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCompareFunction(CompareFunction value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_SetCompareFunction_Public_Void_CompareFunction_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x0009C3DC File Offset: 0x0009A5DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1291964, RefRangeEnd = 1291967, XrefRangeStart = 1291964, XrefRangeEnd = 1291964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPassOperation(StencilOp value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_SetPassOperation_Public_Void_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x0009C410 File Offset: 0x0009A610
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1291967, RefRangeEnd = 1291970, XrefRangeStart = 1291967, XrefRangeEnd = 1291967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFailOperation(StencilOp value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_SetFailOperation_Public_Void_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x0009C444 File Offset: 0x0009A644
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1291970, RefRangeEnd = 1291973, XrefRangeStart = 1291970, XrefRangeEnd = 1291970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZFailOperation(StencilOp value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_SetZFailOperation_Public_Void_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06002760 RID: 10080 RVA: 0x0009C478 File Offset: 0x0009A678
		// (set) Token: 0x06002761 RID: 10081 RVA: 0x0009C4A8 File Offset: 0x0009A6A8
		public unsafe CompareFunction compareFunctionFront
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1291973, RefRangeEnd = 1291977, XrefRangeStart = 1291973, XrefRangeEnd = 1291973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_compareFunctionFront_Public_get_CompareFunction_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1041377, RefRangeEnd = 1041378, XrefRangeStart = 1041377, XrefRangeEnd = 1041378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_compareFunctionFront_Public_set_Void_CompareFunction_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06002762 RID: 10082 RVA: 0x0009C4DC File Offset: 0x0009A6DC
		// (set) Token: 0x06002763 RID: 10083 RVA: 0x0009C50C File Offset: 0x0009A70C
		public unsafe StencilOp passOperationFront
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1291977, RefRangeEnd = 1291979, XrefRangeStart = 1291977, XrefRangeEnd = 1291977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_passOperationFront_Public_get_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1291979, RefRangeEnd = 1291980, XrefRangeStart = 1291979, XrefRangeEnd = 1291979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_passOperationFront_Public_set_Void_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06002764 RID: 10084 RVA: 0x0009C540 File Offset: 0x0009A740
		// (set) Token: 0x06002765 RID: 10085 RVA: 0x0009C570 File Offset: 0x0009A770
		public unsafe StencilOp failOperationFront
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1291980, RefRangeEnd = 1291982, XrefRangeStart = 1291980, XrefRangeEnd = 1291980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_failOperationFront_Public_get_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1291982, RefRangeEnd = 1291983, XrefRangeStart = 1291982, XrefRangeEnd = 1291982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_failOperationFront_Public_set_Void_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06002766 RID: 10086 RVA: 0x0009C5A4 File Offset: 0x0009A7A4
		// (set) Token: 0x06002767 RID: 10087 RVA: 0x0009C5D4 File Offset: 0x0009A7D4
		public unsafe StencilOp zFailOperationFront
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1291983, RefRangeEnd = 1291985, XrefRangeStart = 1291983, XrefRangeEnd = 1291983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_zFailOperationFront_Public_get_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1291985, RefRangeEnd = 1291986, XrefRangeStart = 1291985, XrefRangeEnd = 1291985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_zFailOperationFront_Public_set_Void_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06002768 RID: 10088 RVA: 0x0009C608 File Offset: 0x0009A808
		// (set) Token: 0x06002769 RID: 10089 RVA: 0x0009C638 File Offset: 0x0009A838
		public unsafe CompareFunction compareFunctionBack
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1291986, RefRangeEnd = 1291990, XrefRangeStart = 1291986, XrefRangeEnd = 1291986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_compareFunctionBack_Public_get_CompareFunction_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29038, RefRangeEnd = 29039, XrefRangeStart = 29038, XrefRangeEnd = 29039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_compareFunctionBack_Public_set_Void_CompareFunction_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x0600276A RID: 10090 RVA: 0x0009C66C File Offset: 0x0009A86C
		// (set) Token: 0x0600276B RID: 10091 RVA: 0x0009C69C File Offset: 0x0009A89C
		public unsafe StencilOp passOperationBack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1291990, RefRangeEnd = 1291992, XrefRangeStart = 1291990, XrefRangeEnd = 1291990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_passOperationBack_Public_get_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1120628, RefRangeEnd = 1120629, XrefRangeStart = 1120628, XrefRangeEnd = 1120629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_passOperationBack_Public_set_Void_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x0600276C RID: 10092 RVA: 0x0009C6D0 File Offset: 0x0009A8D0
		// (set) Token: 0x0600276D RID: 10093 RVA: 0x0009C700 File Offset: 0x0009A900
		public unsafe StencilOp failOperationBack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1291992, RefRangeEnd = 1291994, XrefRangeStart = 1291992, XrefRangeEnd = 1291992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_failOperationBack_Public_get_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1120629, RefRangeEnd = 1120630, XrefRangeStart = 1120629, XrefRangeEnd = 1120630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_failOperationBack_Public_set_Void_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x0600276E RID: 10094 RVA: 0x0009C734 File Offset: 0x0009A934
		// (set) Token: 0x0600276F RID: 10095 RVA: 0x0009C764 File Offset: 0x0009A964
		public unsafe StencilOp zFailOperationBack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1291994, RefRangeEnd = 1291996, XrefRangeStart = 1291994, XrefRangeEnd = 1291994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_get_zFailOperationBack_Public_get_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1291996, RefRangeEnd = 1291997, XrefRangeStart = 1291996, XrefRangeEnd = 1291996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_zFailOperationBack_Public_set_Void_StencilOp_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x0009C798 File Offset: 0x0009A998
		[CallerCount(0)]
		public unsafe bool Equals(StencilState other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StencilState_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x0009C7D8 File Offset: 0x0009A9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291997, XrefRangeEnd = 1291999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x0009C81C File Offset: 0x0009AA1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1292010, RefRangeEnd = 1292011, XrefRangeStart = 1291999, XrefRangeEnd = 1292010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x00011AD8 File Offset: 0x0000FCD8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StencilState>.NativeClassPtr, ref this));
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x0009C84C File Offset: 0x0009AA4C
		public static bool operator ==(StencilState left, StencilState right)
		{
			return left.Equals(right);
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x0009C868 File Offset: 0x0009AA68
		public static bool operator !=(StencilState left, StencilState right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040021A9 RID: 8617
		private static readonly IntPtr NativeFieldInfoPtr_m_Enabled;

		// Token: 0x040021AA RID: 8618
		private static readonly IntPtr NativeFieldInfoPtr_m_ReadMask;

		// Token: 0x040021AB RID: 8619
		private static readonly IntPtr NativeFieldInfoPtr_m_WriteMask;

		// Token: 0x040021AC RID: 8620
		private static readonly IntPtr NativeFieldInfoPtr_m_Padding;

		// Token: 0x040021AD RID: 8621
		private static readonly IntPtr NativeFieldInfoPtr_m_CompareFunctionFront;

		// Token: 0x040021AE RID: 8622
		private static readonly IntPtr NativeFieldInfoPtr_m_PassOperationFront;

		// Token: 0x040021AF RID: 8623
		private static readonly IntPtr NativeFieldInfoPtr_m_FailOperationFront;

		// Token: 0x040021B0 RID: 8624
		private static readonly IntPtr NativeFieldInfoPtr_m_ZFailOperationFront;

		// Token: 0x040021B1 RID: 8625
		private static readonly IntPtr NativeFieldInfoPtr_m_CompareFunctionBack;

		// Token: 0x040021B2 RID: 8626
		private static readonly IntPtr NativeFieldInfoPtr_m_PassOperationBack;

		// Token: 0x040021B3 RID: 8627
		private static readonly IntPtr NativeFieldInfoPtr_m_FailOperationBack;

		// Token: 0x040021B4 RID: 8628
		private static readonly IntPtr NativeFieldInfoPtr_m_ZFailOperationBack;

		// Token: 0x040021B5 RID: 8629
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultValue_Public_Static_get_StencilState_0;

		// Token: 0x040021B6 RID: 8630
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Byte_Byte_CompareFunction_StencilOp_StencilOp_StencilOp_0;

		// Token: 0x040021B7 RID: 8631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Byte_Byte_CompareFunction_StencilOp_StencilOp_StencilOp_CompareFunction_StencilOp_StencilOp_StencilOp_0;

		// Token: 0x040021B8 RID: 8632
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

		// Token: 0x040021B9 RID: 8633
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

		// Token: 0x040021BA RID: 8634
		private static readonly IntPtr NativeMethodInfoPtr_get_readMask_Public_get_Byte_0;

		// Token: 0x040021BB RID: 8635
		private static readonly IntPtr NativeMethodInfoPtr_set_readMask_Public_set_Void_Byte_0;

		// Token: 0x040021BC RID: 8636
		private static readonly IntPtr NativeMethodInfoPtr_get_writeMask_Public_get_Byte_0;

		// Token: 0x040021BD RID: 8637
		private static readonly IntPtr NativeMethodInfoPtr_set_writeMask_Public_set_Void_Byte_0;

		// Token: 0x040021BE RID: 8638
		private static readonly IntPtr NativeMethodInfoPtr_SetCompareFunction_Public_Void_CompareFunction_0;

		// Token: 0x040021BF RID: 8639
		private static readonly IntPtr NativeMethodInfoPtr_SetPassOperation_Public_Void_StencilOp_0;

		// Token: 0x040021C0 RID: 8640
		private static readonly IntPtr NativeMethodInfoPtr_SetFailOperation_Public_Void_StencilOp_0;

		// Token: 0x040021C1 RID: 8641
		private static readonly IntPtr NativeMethodInfoPtr_SetZFailOperation_Public_Void_StencilOp_0;

		// Token: 0x040021C2 RID: 8642
		private static readonly IntPtr NativeMethodInfoPtr_get_compareFunctionFront_Public_get_CompareFunction_0;

		// Token: 0x040021C3 RID: 8643
		private static readonly IntPtr NativeMethodInfoPtr_set_compareFunctionFront_Public_set_Void_CompareFunction_0;

		// Token: 0x040021C4 RID: 8644
		private static readonly IntPtr NativeMethodInfoPtr_get_passOperationFront_Public_get_StencilOp_0;

		// Token: 0x040021C5 RID: 8645
		private static readonly IntPtr NativeMethodInfoPtr_set_passOperationFront_Public_set_Void_StencilOp_0;

		// Token: 0x040021C6 RID: 8646
		private static readonly IntPtr NativeMethodInfoPtr_get_failOperationFront_Public_get_StencilOp_0;

		// Token: 0x040021C7 RID: 8647
		private static readonly IntPtr NativeMethodInfoPtr_set_failOperationFront_Public_set_Void_StencilOp_0;

		// Token: 0x040021C8 RID: 8648
		private static readonly IntPtr NativeMethodInfoPtr_get_zFailOperationFront_Public_get_StencilOp_0;

		// Token: 0x040021C9 RID: 8649
		private static readonly IntPtr NativeMethodInfoPtr_set_zFailOperationFront_Public_set_Void_StencilOp_0;

		// Token: 0x040021CA RID: 8650
		private static readonly IntPtr NativeMethodInfoPtr_get_compareFunctionBack_Public_get_CompareFunction_0;

		// Token: 0x040021CB RID: 8651
		private static readonly IntPtr NativeMethodInfoPtr_set_compareFunctionBack_Public_set_Void_CompareFunction_0;

		// Token: 0x040021CC RID: 8652
		private static readonly IntPtr NativeMethodInfoPtr_get_passOperationBack_Public_get_StencilOp_0;

		// Token: 0x040021CD RID: 8653
		private static readonly IntPtr NativeMethodInfoPtr_set_passOperationBack_Public_set_Void_StencilOp_0;

		// Token: 0x040021CE RID: 8654
		private static readonly IntPtr NativeMethodInfoPtr_get_failOperationBack_Public_get_StencilOp_0;

		// Token: 0x040021CF RID: 8655
		private static readonly IntPtr NativeMethodInfoPtr_set_failOperationBack_Public_set_Void_StencilOp_0;

		// Token: 0x040021D0 RID: 8656
		private static readonly IntPtr NativeMethodInfoPtr_get_zFailOperationBack_Public_get_StencilOp_0;

		// Token: 0x040021D1 RID: 8657
		private static readonly IntPtr NativeMethodInfoPtr_set_zFailOperationBack_Public_set_Void_StencilOp_0;

		// Token: 0x040021D2 RID: 8658
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StencilState_0;

		// Token: 0x040021D3 RID: 8659
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040021D4 RID: 8660
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040021D5 RID: 8661
		[FieldOffset(0)]
		public byte m_Enabled;

		// Token: 0x040021D6 RID: 8662
		[FieldOffset(1)]
		public byte m_ReadMask;

		// Token: 0x040021D7 RID: 8663
		[FieldOffset(2)]
		public byte m_WriteMask;

		// Token: 0x040021D8 RID: 8664
		[FieldOffset(3)]
		public byte m_Padding;

		// Token: 0x040021D9 RID: 8665
		[FieldOffset(4)]
		public byte m_CompareFunctionFront;

		// Token: 0x040021DA RID: 8666
		[FieldOffset(5)]
		public byte m_PassOperationFront;

		// Token: 0x040021DB RID: 8667
		[FieldOffset(6)]
		public byte m_FailOperationFront;

		// Token: 0x040021DC RID: 8668
		[FieldOffset(7)]
		public byte m_ZFailOperationFront;

		// Token: 0x040021DD RID: 8669
		[FieldOffset(8)]
		public byte m_CompareFunctionBack;

		// Token: 0x040021DE RID: 8670
		[FieldOffset(9)]
		public byte m_PassOperationBack;

		// Token: 0x040021DF RID: 8671
		[FieldOffset(10)]
		public byte m_FailOperationBack;

		// Token: 0x040021E0 RID: 8672
		[FieldOffset(11)]
		public byte m_ZFailOperationBack;
	}
}
