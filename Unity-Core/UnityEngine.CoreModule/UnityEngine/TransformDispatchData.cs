using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine
{
	// Token: 0x02000101 RID: 257
	public sealed class TransformDispatchData : ValueType
	{
		// Token: 0x060015E5 RID: 5605 RVA: 0x00060EC8 File Offset: 0x0005F0C8
		// Note: this type is marked as 'beforefieldinit'.
		static TransformDispatchData()
		{
			Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TransformDispatchData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr);
			TransformDispatchData.NativeFieldInfoPtr_transformedID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, "transformedID");
			TransformDispatchData.NativeFieldInfoPtr_parentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, "parentID");
			TransformDispatchData.NativeFieldInfoPtr_localToWorldMatrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, "localToWorldMatrices");
			TransformDispatchData.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, "positions");
			TransformDispatchData.NativeFieldInfoPtr_rotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, "rotations");
			TransformDispatchData.NativeFieldInfoPtr_scales = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, "scales");
			TransformDispatchData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, 100665613);
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00060F84 File Offset: 0x0005F184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245765, XrefRangeEnd = 1245781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformDispatchData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x0000AEB1 File Offset: 0x000090B1
		public TransformDispatchData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x0000AEBA File Offset: 0x000090BA
		public TransformDispatchData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr))
		{
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060015E9 RID: 5609 RVA: 0x00060FBC File Offset: 0x0005F1BC
		// (set) Token: 0x060015EA RID: 5610 RVA: 0x0000AECC File Offset: 0x000090CC
		public Unity.Collections.NativeArray<int> transformedID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_transformedID);
				return new Unity.Collections.NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_transformedID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060015EB RID: 5611 RVA: 0x00060FEC File Offset: 0x0005F1EC
		// (set) Token: 0x060015EC RID: 5612 RVA: 0x0000AEFA File Offset: 0x000090FA
		public Unity.Collections.NativeArray<int> parentID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_parentID);
				return new Unity.Collections.NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_parentID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060015ED RID: 5613 RVA: 0x0006101C File Offset: 0x0005F21C
		// (set) Token: 0x060015EE RID: 5614 RVA: 0x0000AF28 File Offset: 0x00009128
		public Unity.Collections.NativeArray<Matrix4x4> localToWorldMatrices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_localToWorldMatrices);
				return new Unity.Collections.NativeArray<Matrix4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<Matrix4x4>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_localToWorldMatrices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<Matrix4x4>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x0006104C File Offset: 0x0005F24C
		// (set) Token: 0x060015F0 RID: 5616 RVA: 0x0000AF56 File Offset: 0x00009156
		public Unity.Collections.NativeArray<Vector3> positions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_positions);
				return new Unity.Collections.NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<Vector3>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_positions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<Vector3>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x0006107C File Offset: 0x0005F27C
		// (set) Token: 0x060015F2 RID: 5618 RVA: 0x0000AF84 File Offset: 0x00009184
		public Unity.Collections.NativeArray<Quaternion> rotations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_rotations);
				return new Unity.Collections.NativeArray<Quaternion>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<Quaternion>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_rotations), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<Quaternion>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060015F3 RID: 5619 RVA: 0x000610AC File Offset: 0x0005F2AC
		// (set) Token: 0x060015F4 RID: 5620 RVA: 0x0000AFB2 File Offset: 0x000091B2
		public Unity.Collections.NativeArray<Vector3> scales
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_scales);
				return new Unity.Collections.NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<Vector3>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_scales), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<Vector3>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04001309 RID: 4873
		private static readonly IntPtr NativeFieldInfoPtr_transformedID;

		// Token: 0x0400130A RID: 4874
		private static readonly IntPtr NativeFieldInfoPtr_parentID;

		// Token: 0x0400130B RID: 4875
		private static readonly IntPtr NativeFieldInfoPtr_localToWorldMatrices;

		// Token: 0x0400130C RID: 4876
		private static readonly IntPtr NativeFieldInfoPtr_positions;

		// Token: 0x0400130D RID: 4877
		private static readonly IntPtr NativeFieldInfoPtr_rotations;

		// Token: 0x0400130E RID: 4878
		private static readonly IntPtr NativeFieldInfoPtr_scales;

		// Token: 0x0400130F RID: 4879
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
