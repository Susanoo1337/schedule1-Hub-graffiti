using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200020B RID: 523
	[StructLayout(2)]
	public struct BatchMaterialID
	{
		// Token: 0x06002415 RID: 9237 RVA: 0x00091454 File Offset: 0x0008F654
		// Note: this type is marked as 'beforefieldinit'.
		static BatchMaterialID()
		{
			Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchMaterialID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr);
			BatchMaterialID.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr, "Null");
			BatchMaterialID.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr, "value");
			BatchMaterialID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr, 100667198);
			BatchMaterialID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr, 100667199);
			BatchMaterialID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchMaterialID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr, 100667200);
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x000914E8 File Offset: 0x0008F6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchMaterialID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x00091518 File Offset: 0x0008F718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290028, XrefRangeEnd = 1290033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchMaterialID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x0009155C File Offset: 0x0008F75C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1246103, RefRangeEnd = 1246104, XrefRangeStart = 1246103, XrefRangeEnd = 1246104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(BatchMaterialID other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchMaterialID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchMaterialID_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x00010A7D File Offset: 0x0000EC7D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr, ref this));
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x0600241A RID: 9242 RVA: 0x0009159C File Offset: 0x0008F79C
		// (set) Token: 0x0600241B RID: 9243 RVA: 0x00010A8F File Offset: 0x0000EC8F
		public unsafe static BatchMaterialID Null
		{
			get
			{
				BatchMaterialID result;
				IL2CPP.il2cpp_field_static_get_value(BatchMaterialID.NativeFieldInfoPtr_Null, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BatchMaterialID.NativeFieldInfoPtr_Null, (void*)(&value));
			}
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x000915B8 File Offset: 0x0008F7B8
		public int CompareTo(BatchMaterialID other)
		{
			return this.value.CompareTo(other.value);
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x000915DC File Offset: 0x0008F7DC
		public static bool operator ==(BatchMaterialID a, BatchMaterialID b)
		{
			return a.Equals(b);
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x000915F8 File Offset: 0x0008F7F8
		public static bool operator !=(BatchMaterialID a, BatchMaterialID b)
		{
			return !a.Equals(b);
		}

		// Token: 0x04001E12 RID: 7698
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04001E13 RID: 7699
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04001E14 RID: 7700
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001E15 RID: 7701
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001E16 RID: 7702
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchMaterialID_0;

		// Token: 0x04001E17 RID: 7703
		[FieldOffset(0)]
		public uint value;
	}
}
