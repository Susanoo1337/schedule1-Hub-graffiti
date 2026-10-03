using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Sprites
{
	// Token: 0x02000176 RID: 374
	public sealed class DataUtility : Object
	{
		// Token: 0x06001CF9 RID: 7417 RVA: 0x0007824C File Offset: 0x0007644C
		// Note: this type is marked as 'beforefieldinit'.
		static DataUtility()
		{
			Il2CppClassPointerStore<DataUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Sprites", "DataUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataUtility>.NativeClassPtr);
			DataUtility.NativeMethodInfoPtr_GetInnerUV_Public_Static_Vector4_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataUtility>.NativeClassPtr, 100666429);
			DataUtility.NativeMethodInfoPtr_GetOuterUV_Public_Static_Vector4_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataUtility>.NativeClassPtr, 100666430);
			DataUtility.NativeMethodInfoPtr_GetPadding_Public_Static_Vector4_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataUtility>.NativeClassPtr, 100666431);
			DataUtility.NativeMethodInfoPtr_GetMinSize_Public_Static_Vector2_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataUtility>.NativeClassPtr, 100666432);
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x000782CC File Offset: 0x000764CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1282200, RefRangeEnd = 1282202, XrefRangeStart = 1282198, XrefRangeEnd = 1282200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetInnerUV(Sprite sprite)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataUtility.NativeMethodInfoPtr_GetInnerUV_Public_Static_Vector4_Sprite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x00078310 File Offset: 0x00076510
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1282204, RefRangeEnd = 1282208, XrefRangeStart = 1282202, XrefRangeEnd = 1282204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetOuterUV(Sprite sprite)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataUtility.NativeMethodInfoPtr_GetOuterUV_Public_Static_Vector4_Sprite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x00078354 File Offset: 0x00076554
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1282210, RefRangeEnd = 1282212, XrefRangeStart = 1282208, XrefRangeEnd = 1282210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetPadding(Sprite sprite)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataUtility.NativeMethodInfoPtr_GetPadding_Public_Static_Vector4_Sprite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x00078398 File Offset: 0x00076598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282212, XrefRangeEnd = 1282220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 GetMinSize(Sprite sprite)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataUtility.NativeMethodInfoPtr_GetMinSize_Public_Static_Vector2_Sprite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x0000D9D0 File Offset: 0x0000BBD0
		public DataUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040017E1 RID: 6113
		private static readonly IntPtr NativeMethodInfoPtr_GetInnerUV_Public_Static_Vector4_Sprite_0;

		// Token: 0x040017E2 RID: 6114
		private static readonly IntPtr NativeMethodInfoPtr_GetOuterUV_Public_Static_Vector4_Sprite_0;

		// Token: 0x040017E3 RID: 6115
		private static readonly IntPtr NativeMethodInfoPtr_GetPadding_Public_Static_Vector4_Sprite_0;

		// Token: 0x040017E4 RID: 6116
		private static readonly IntPtr NativeMethodInfoPtr_GetMinSize_Public_Static_Vector2_Sprite_0;
	}
}
