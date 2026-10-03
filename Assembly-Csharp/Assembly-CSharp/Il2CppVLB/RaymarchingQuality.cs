using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppVLB
{
	// Token: 0x0200005A RID: 90
	[Serializable]
	public class RaymarchingQuality : Object
	{
		// Token: 0x06000508 RID: 1288 RVA: 0x0008A38C File Offset: 0x0008858C
		// Note: this type is marked as 'beforefieldinit'.
		static RaymarchingQuality()
		{
			Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "RaymarchingQuality");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr);
			RaymarchingQuality.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, "name");
			RaymarchingQuality.NativeFieldInfoPtr_stepCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, "stepCount");
			RaymarchingQuality.NativeFieldInfoPtr__UniqueID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, "_UniqueID");
			RaymarchingQuality.NativeFieldInfoPtr_ms_DefaultInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, "ms_DefaultInstance");
			RaymarchingQuality.NativeFieldInfoPtr_kRandomUniqueIdMinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, "kRandomUniqueIdMinRange");
			RaymarchingQuality.NativeMethodInfoPtr_get_uniqueID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, 100663826);
			RaymarchingQuality.NativeMethodInfoPtr_get_hasValidUniqueID_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, 100663827);
			RaymarchingQuality.NativeMethodInfoPtr_get_defaultInstance_Public_Static_get_RaymarchingQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, 100663828);
			RaymarchingQuality.NativeMethodInfoPtr__ctor_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, 100663829);
			RaymarchingQuality.NativeMethodInfoPtr_New_Public_Static_RaymarchingQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, 100663830);
			RaymarchingQuality.NativeMethodInfoPtr_New_Public_Static_RaymarchingQuality_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, 100663831);
			RaymarchingQuality.NativeMethodInfoPtr_HasRaymarchingQualityWithSameUniqueID_Private_Static_Boolean_Il2CppReferenceArray_1_RaymarchingQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr, 100663832);
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x0008A4AC File Offset: 0x000886AC
		public unsafe int uniqueID
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 36888, RefRangeEnd = 36892, XrefRangeStart = 36888, XrefRangeEnd = 36892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaymarchingQuality.NativeMethodInfoPtr_get_uniqueID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x0008A4E8 File Offset: 0x000886E8
		public unsafe bool hasValidUniqueID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaymarchingQuality.NativeMethodInfoPtr_get_hasValidUniqueID_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x0008A524 File Offset: 0x00088724
		public unsafe static RaymarchingQuality defaultInstance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70094, XrefRangeEnd = 70098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaymarchingQuality.NativeMethodInfoPtr_get_defaultInstance_Public_Static_get_RaymarchingQuality_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RaymarchingQuality>(intPtr3) : null;
			}
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0008A558 File Offset: 0x00088758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70098, XrefRangeEnd = 70103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RaymarchingQuality(int uniqueID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RaymarchingQuality>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref uniqueID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaymarchingQuality.NativeMethodInfoPtr__ctor_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0008A5A0 File Offset: 0x000887A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70103, XrefRangeEnd = 70112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaymarchingQuality New()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaymarchingQuality.NativeMethodInfoPtr_New_Public_Static_RaymarchingQuality_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RaymarchingQuality>(intPtr3) : null;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0008A5D4 File Offset: 0x000887D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 70121, RefRangeEnd = 70124, XrefRangeStart = 70112, XrefRangeEnd = 70121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaymarchingQuality New(string name, int forcedUniqueID, int stepCount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forcedUniqueID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stepCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaymarchingQuality.NativeMethodInfoPtr_New_Public_Static_RaymarchingQuality_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RaymarchingQuality>(intPtr3) : null;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0008A634 File Offset: 0x00088834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70124, XrefRangeEnd = 70125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasRaymarchingQualityWithSameUniqueID(Il2CppReferenceArray<RaymarchingQuality> values, int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaymarchingQuality.NativeMethodInfoPtr_HasRaymarchingQualityWithSameUniqueID_Private_Static_Boolean_Il2CppReferenceArray_1_RaymarchingQuality_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00004C47 File Offset: 0x00002E47
		public RaymarchingQuality(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x0008A684 File Offset: 0x00088884
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x00004C50 File Offset: 0x00002E50
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaymarchingQuality.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaymarchingQuality.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x0008A6AC File Offset: 0x000888AC
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x00004C6F File Offset: 0x00002E6F
		public unsafe int stepCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaymarchingQuality.NativeFieldInfoPtr_stepCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaymarchingQuality.NativeFieldInfoPtr_stepCount)) = value;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x0008A6D4 File Offset: 0x000888D4
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x00004C8A File Offset: 0x00002E8A
		public unsafe int _UniqueID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaymarchingQuality.NativeFieldInfoPtr__UniqueID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaymarchingQuality.NativeFieldInfoPtr__UniqueID)) = value;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x0008A6FC File Offset: 0x000888FC
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x00004CA5 File Offset: 0x00002EA5
		public unsafe static RaymarchingQuality ms_DefaultInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RaymarchingQuality.NativeFieldInfoPtr_ms_DefaultInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RaymarchingQuality>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RaymarchingQuality.NativeFieldInfoPtr_ms_DefaultInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0008A724 File Offset: 0x00088924
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x00004CB7 File Offset: 0x00002EB7
		public unsafe static int kRandomUniqueIdMinRange
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RaymarchingQuality.NativeFieldInfoPtr_kRandomUniqueIdMinRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RaymarchingQuality.NativeFieldInfoPtr_kRandomUniqueIdMinRange, (void*)(&value));
			}
		}

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeFieldInfoPtr_stepCount;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeFieldInfoPtr__UniqueID;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeFieldInfoPtr_ms_DefaultInstance;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeFieldInfoPtr_kRandomUniqueIdMinRange;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_get_uniqueID_Public_get_Int32_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_get_hasValidUniqueID_Public_get_Boolean_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultInstance_Public_Static_get_RaymarchingQuality_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_RaymarchingQuality_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Static_RaymarchingQuality_String_Int32_Int32_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr_HasRaymarchingQualityWithSameUniqueID_Private_Static_Boolean_Il2CppReferenceArray_1_RaymarchingQuality_Int32_0;
	}
}
