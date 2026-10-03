using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200076F RID: 1903
	public static class UnitsUtility : Object
	{
		// Token: 0x0600B92A RID: 47402 RVA: 0x002FBD00 File Offset: 0x002F9F00
		// Note: this type is marked as 'beforefieldinit'.
		static UnitsUtility()
		{
			Il2CppClassPointerStore<UnitsUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "UnitsUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitsUtility>.NativeClassPtr);
			UnitsUtility.NativeMethodInfoPtr_FormatShortDistance_Public_Static_String_Single_ERoundingType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitsUtility>.NativeClassPtr, 100687496);
			UnitsUtility.NativeMethodInfoPtr_FormatSpeed_Public_Static_String_Single_ERoundingType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitsUtility>.NativeClassPtr, 100687497);
			UnitsUtility.NativeMethodInfoPtr_RoundValue_Private_Static_Single_Single_ERoundingType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitsUtility>.NativeClassPtr, 100687498);
		}

		// Token: 0x0600B92B RID: 47403 RVA: 0x002FBD6C File Offset: 0x002F9F6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309521, RefRangeEnd = 309522, XrefRangeStart = 309501, XrefRangeEnd = 309521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatShortDistance(float meters, UnitsUtility.ERoundingType roundingType = UnitsUtility.ERoundingType.Nearest, int decimalPoints = 0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref meters;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref roundingType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decimalPoints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitsUtility.NativeMethodInfoPtr_FormatShortDistance_Public_Static_String_Single_ERoundingType_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600B92C RID: 47404 RVA: 0x002FBDC0 File Offset: 0x002F9FC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309541, RefRangeEnd = 309542, XrefRangeStart = 309522, XrefRangeEnd = 309541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatSpeed(float metersPerSecond, UnitsUtility.ERoundingType roundingType = UnitsUtility.ERoundingType.Nearest, int decimalPoints = 1)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref metersPerSecond;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref roundingType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decimalPoints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitsUtility.NativeMethodInfoPtr_FormatSpeed_Public_Static_String_Single_ERoundingType_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600B92D RID: 47405 RVA: 0x002FBE14 File Offset: 0x002FA014
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309544, RefRangeEnd = 309545, XrefRangeStart = 309542, XrefRangeEnd = 309544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float RoundValue(float value, UnitsUtility.ERoundingType roundingType, int decimalPoints)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref roundingType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decimalPoints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitsUtility.NativeMethodInfoPtr_RoundValue_Private_Static_Single_Single_ERoundingType_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B92E RID: 47406 RVA: 0x000562B9 File Offset: 0x000544B9
		public UnitsUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04007F0A RID: 32522
		private static readonly IntPtr NativeMethodInfoPtr_FormatShortDistance_Public_Static_String_Single_ERoundingType_Int32_0;

		// Token: 0x04007F0B RID: 32523
		private static readonly IntPtr NativeMethodInfoPtr_FormatSpeed_Public_Static_String_Single_ERoundingType_Int32_0;

		// Token: 0x04007F0C RID: 32524
		private static readonly IntPtr NativeMethodInfoPtr_RoundValue_Private_Static_Single_Single_ERoundingType_Int32_0;

		// Token: 0x02000CFC RID: 3324
		[OriginalName("Assembly-CSharp.dll", "", "ERoundingType")]
		public enum ERoundingType
		{
			// Token: 0x0400A724 RID: 42788
			None,
			// Token: 0x0400A725 RID: 42789
			Nearest,
			// Token: 0x0400A726 RID: 42790
			Up,
			// Token: 0x0400A727 RID: 42791
			Down
		}
	}
}
