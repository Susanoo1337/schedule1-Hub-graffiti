using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000091 RID: 145
	[StructLayout(2)]
	public struct RefreshRate
	{
		// Token: 0x060007DC RID: 2012 RVA: 0x0002FE78 File Offset: 0x0002E078
		// Note: this type is marked as 'beforefieldinit'.
		static RefreshRate()
		{
			Il2CppClassPointerStore<RefreshRate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RefreshRate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr);
			RefreshRate.NativeFieldInfoPtr_numerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr, "numerator");
			RefreshRate.NativeFieldInfoPtr_denominator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr, "denominator");
			RefreshRate.NativeMethodInfoPtr_get_value_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr, 100664137);
			RefreshRate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RefreshRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr, 100664138);
			RefreshRate.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RefreshRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr, 100664139);
			RefreshRate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr, 100664140);
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x0002FF20 File Offset: 0x0002E120
		public unsafe double value
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefreshRate.NativeMethodInfoPtr_get_value_Public_get_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0002FF50 File Offset: 0x0002E150
		[CallerCount(0)]
		public unsafe bool Equals(RefreshRate other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefreshRate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RefreshRate_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0002FF90 File Offset: 0x0002E190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233654, XrefRangeEnd = 1233655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(RefreshRate other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefreshRate.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RefreshRate_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0002FFD0 File Offset: 0x0002E1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233655, XrefRangeEnd = 1233660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefreshRate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x000057EE File Offset: 0x000039EE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr, ref this));
		}

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeFieldInfoPtr_numerator;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeFieldInfoPtr_denominator;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Double_0;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RefreshRate_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RefreshRate_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400065C RID: 1628
		[FieldOffset(0)]
		public uint numerator;

		// Token: 0x0400065D RID: 1629
		[FieldOffset(4)]
		public uint denominator;
	}
}
