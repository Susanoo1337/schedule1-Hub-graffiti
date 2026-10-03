using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200020A RID: 522
	[StructLayout(2)]
	public struct BatchID
	{
		// Token: 0x0600240B RID: 9227 RVA: 0x00091290 File Offset: 0x0008F490
		// Note: this type is marked as 'beforefieldinit'.
		static BatchID()
		{
			Il2CppClassPointerStore<BatchID>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchID>.NativeClassPtr);
			BatchID.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchID>.NativeClassPtr, "Null");
			BatchID.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchID>.NativeClassPtr, "value");
			BatchID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchID>.NativeClassPtr, 100667194);
			BatchID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchID>.NativeClassPtr, 100667195);
			BatchID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchID>.NativeClassPtr, 100667196);
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x00091324 File Offset: 0x0008F524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290020, XrefRangeEnd = 1290023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x00091354 File Offset: 0x0008F554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290023, XrefRangeEnd = 1290028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x00091398 File Offset: 0x0008F598
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1246103, RefRangeEnd = 1246104, XrefRangeStart = 1246103, XrefRangeEnd = 1246104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(BatchID other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchID_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x00010A5D File Offset: 0x0000EC5D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchID>.NativeClassPtr, ref this));
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06002410 RID: 9232 RVA: 0x000913D8 File Offset: 0x0008F5D8
		// (set) Token: 0x06002411 RID: 9233 RVA: 0x00010A6F File Offset: 0x0000EC6F
		public unsafe static BatchID Null
		{
			get
			{
				BatchID result;
				IL2CPP.il2cpp_field_static_get_value(BatchID.NativeFieldInfoPtr_Null, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BatchID.NativeFieldInfoPtr_Null, (void*)(&value));
			}
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x000913F4 File Offset: 0x0008F5F4
		public int CompareTo(BatchID other)
		{
			return this.value.CompareTo(other.value);
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x00091418 File Offset: 0x0008F618
		public static bool operator ==(BatchID a, BatchID b)
		{
			return a.Equals(b);
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x00091434 File Offset: 0x0008F634
		public static bool operator !=(BatchID a, BatchID b)
		{
			return !a.Equals(b);
		}

		// Token: 0x04001E0C RID: 7692
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04001E0D RID: 7693
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04001E0E RID: 7694
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001E0F RID: 7695
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001E10 RID: 7696
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchID_0;

		// Token: 0x04001E11 RID: 7697
		[FieldOffset(0)]
		public uint value;
	}
}
