using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000223 RID: 547
	[StructLayout(2)]
	public struct DepthState
	{
		// Token: 0x0600254D RID: 9549 RVA: 0x00094DF8 File Offset: 0x00092FF8
		// Note: this type is marked as 'beforefieldinit'.
		static DepthState()
		{
			Il2CppClassPointerStore<DepthState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "DepthState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthState>.NativeClassPtr);
			DepthState.NativeFieldInfoPtr_m_WriteEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthState>.NativeClassPtr, "m_WriteEnabled");
			DepthState.NativeFieldInfoPtr_m_CompareFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthState>.NativeClassPtr, "m_CompareFunction");
			DepthState.NativeMethodInfoPtr_get_defaultValue_Public_Static_get_DepthState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthState>.NativeClassPtr, 100667285);
			DepthState.NativeMethodInfoPtr__ctor_Public_Void_Boolean_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthState>.NativeClassPtr, 100667286);
			DepthState.NativeMethodInfoPtr_get_compareFunction_Public_get_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthState>.NativeClassPtr, 100667287);
			DepthState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DepthState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthState>.NativeClassPtr, 100667288);
			DepthState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthState>.NativeClassPtr, 100667289);
			DepthState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthState>.NativeClassPtr, 100667290);
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x0600254E RID: 9550 RVA: 0x00094EC8 File Offset: 0x000930C8
		public unsafe static DepthState defaultValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1290430, RefRangeEnd = 1290431, XrefRangeStart = 1290426, XrefRangeEnd = 1290430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthState.NativeMethodInfoPtr_get_defaultValue_Public_Static_get_DepthState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x00094EF8 File Offset: 0x000930F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1290435, RefRangeEnd = 1290438, XrefRangeStart = 1290431, XrefRangeEnd = 1290435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DepthState(bool writeEnabled = true, CompareFunction compareFunction = CompareFunction.Less)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref writeEnabled;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compareFunction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthState.NativeMethodInfoPtr__ctor_Public_Void_Boolean_CompareFunction_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06002550 RID: 9552 RVA: 0x00094F38 File Offset: 0x00093138
		// (set) Token: 0x06002557 RID: 9559 RVA: 0x000112AF File Offset: 0x0000F4AF
		public unsafe CompareFunction compareFunction
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1290438, RefRangeEnd = 1290439, XrefRangeStart = 1290438, XrefRangeEnd = 1290438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthState.NativeMethodInfoPtr_get_compareFunction_Public_get_CompareFunction_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_CompareFunction = (sbyte)value;
			}
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x00094F68 File Offset: 0x00093168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290439, RefRangeEnd = 1290440, XrefRangeStart = 1290439, XrefRangeEnd = 1290439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(DepthState other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DepthState_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x00094FA8 File Offset: 0x000931A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290440, XrefRangeEnd = 1290443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x00094FEC File Offset: 0x000931EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290445, RefRangeEnd = 1290446, XrefRangeStart = 1290443, XrefRangeEnd = 1290445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x0001128E File Offset: 0x0000F48E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DepthState>.NativeClassPtr, ref this));
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06002555 RID: 9557 RVA: 0x0009501C File Offset: 0x0009321C
		// (set) Token: 0x06002556 RID: 9558 RVA: 0x000112A0 File Offset: 0x0000F4A0
		public bool writeEnabled
		{
			get
			{
				return Convert.ToBoolean(this.m_WriteEnabled);
			}
			set
			{
				this.m_WriteEnabled = Convert.ToByte(value);
			}
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x0009503C File Offset: 0x0009323C
		public static bool operator ==(DepthState left, DepthState right)
		{
			return left.Equals(right);
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x00095058 File Offset: 0x00093258
		public static bool operator !=(DepthState left, DepthState right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04001FC8 RID: 8136
		private static readonly IntPtr NativeFieldInfoPtr_m_WriteEnabled;

		// Token: 0x04001FC9 RID: 8137
		private static readonly IntPtr NativeFieldInfoPtr_m_CompareFunction;

		// Token: 0x04001FCA RID: 8138
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultValue_Public_Static_get_DepthState_0;

		// Token: 0x04001FCB RID: 8139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_CompareFunction_0;

		// Token: 0x04001FCC RID: 8140
		private static readonly IntPtr NativeMethodInfoPtr_get_compareFunction_Public_get_CompareFunction_0;

		// Token: 0x04001FCD RID: 8141
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DepthState_0;

		// Token: 0x04001FCE RID: 8142
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001FCF RID: 8143
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001FD0 RID: 8144
		[FieldOffset(0)]
		public byte m_WriteEnabled;

		// Token: 0x04001FD1 RID: 8145
		[FieldOffset(1)]
		public sbyte m_CompareFunction;
	}
}
