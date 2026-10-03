using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000211 RID: 529
	[StructLayout(2)]
	public struct BatchPackedCullingViewID
	{
		// Token: 0x06002429 RID: 9257 RVA: 0x000917DC File Offset: 0x0008F9DC
		// Note: this type is marked as 'beforefieldinit'.
		static BatchPackedCullingViewID()
		{
			Il2CppClassPointerStore<BatchPackedCullingViewID>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchPackedCullingViewID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchPackedCullingViewID>.NativeClassPtr);
			BatchPackedCullingViewID.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchPackedCullingViewID>.NativeClassPtr, "handle");
			BatchPackedCullingViewID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchPackedCullingViewID>.NativeClassPtr, 100667206);
			BatchPackedCullingViewID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchPackedCullingViewID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchPackedCullingViewID>.NativeClassPtr, 100667207);
			BatchPackedCullingViewID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchPackedCullingViewID>.NativeClassPtr, 100667208);
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x0009185C File Offset: 0x0008FA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290038, XrefRangeEnd = 1290039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchPackedCullingViewID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x0009188C File Offset: 0x0008FA8C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1290039, RefRangeEnd = 1290045, XrefRangeStart = 1290039, XrefRangeEnd = 1290039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(BatchPackedCullingViewID other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchPackedCullingViewID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchPackedCullingViewID_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x000918CC File Offset: 0x0008FACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290045, XrefRangeEnd = 1290048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchPackedCullingViewID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x00010ABD File Offset: 0x0000ECBD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchPackedCullingViewID>.NativeClassPtr, ref this));
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x00091910 File Offset: 0x0008FB10
		public static bool operator ==(BatchPackedCullingViewID lhs, BatchPackedCullingViewID rhs)
		{
			return lhs.Equals(rhs);
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x0009192C File Offset: 0x0008FB2C
		public static bool operator !=(BatchPackedCullingViewID lhs, BatchPackedCullingViewID rhs)
		{
			return !lhs.Equals(rhs);
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x0009194C File Offset: 0x0008FB4C
		public int GetInstanceID()
		{
			return (int)(this.handle & (ulong)-1);
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x00091968 File Offset: 0x0008FB68
		public int GetSliceIndex()
		{
			return (int)(this.handle >> 32);
		}

		// Token: 0x04001E32 RID: 7730
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x04001E33 RID: 7731
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001E34 RID: 7732
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchPackedCullingViewID_0;

		// Token: 0x04001E35 RID: 7733
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001E36 RID: 7734
		[FieldOffset(0)]
		public ulong handle;
	}
}
