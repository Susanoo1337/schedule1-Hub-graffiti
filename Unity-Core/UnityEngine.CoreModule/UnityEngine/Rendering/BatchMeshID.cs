using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200020C RID: 524
	[StructLayout(2)]
	public struct BatchMeshID
	{
		// Token: 0x0600241F RID: 9247 RVA: 0x00091618 File Offset: 0x0008F818
		// Note: this type is marked as 'beforefieldinit'.
		static BatchMeshID()
		{
			Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchMeshID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr);
			BatchMeshID.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr, "Null");
			BatchMeshID.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr, "value");
			BatchMeshID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr, 100667202);
			BatchMeshID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr, 100667203);
			BatchMeshID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchMeshID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr, 100667204);
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x000916AC File Offset: 0x0008F8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchMeshID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x000916DC File Offset: 0x0008F8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290033, XrefRangeEnd = 1290038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchMeshID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x00091720 File Offset: 0x0008F920
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1246103, RefRangeEnd = 1246104, XrefRangeStart = 1246103, XrefRangeEnd = 1246104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(BatchMeshID other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchMeshID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchMeshID_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x00010A9D File Offset: 0x0000EC9D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr, ref this));
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06002424 RID: 9252 RVA: 0x00091760 File Offset: 0x0008F960
		// (set) Token: 0x06002425 RID: 9253 RVA: 0x00010AAF File Offset: 0x0000ECAF
		public unsafe static BatchMeshID Null
		{
			get
			{
				BatchMeshID result;
				IL2CPP.il2cpp_field_static_get_value(BatchMeshID.NativeFieldInfoPtr_Null, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BatchMeshID.NativeFieldInfoPtr_Null, (void*)(&value));
			}
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x0009177C File Offset: 0x0008F97C
		public int CompareTo(BatchMeshID other)
		{
			return this.value.CompareTo(other.value);
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x000917A0 File Offset: 0x0008F9A0
		public static bool operator ==(BatchMeshID a, BatchMeshID b)
		{
			return a.Equals(b);
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x000917BC File Offset: 0x0008F9BC
		public static bool operator !=(BatchMeshID a, BatchMeshID b)
		{
			return !a.Equals(b);
		}

		// Token: 0x04001E18 RID: 7704
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04001E19 RID: 7705
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04001E1A RID: 7706
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001E1B RID: 7707
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001E1C RID: 7708
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchMeshID_0;

		// Token: 0x04001E1D RID: 7709
		[FieldOffset(0)]
		public uint value;
	}
}
