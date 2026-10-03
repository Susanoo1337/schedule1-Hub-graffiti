using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Instancing
{
	// Token: 0x02000337 RID: 823
	public class InstanceObjectData : ScriptableObject
	{
		// Token: 0x060046DD RID: 18141 RVA: 0x0016C278 File Offset: 0x0016A478
		// Note: this type is marked as 'beforefieldinit'.
		static InstanceObjectData()
		{
			Il2CppClassPointerStore<InstanceObjectData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Instancing", "InstanceObjectData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceObjectData>.NativeClassPtr);
			InstanceObjectData.NativeFieldInfoPtr_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceObjectData>.NativeClassPtr, "Mesh");
			InstanceObjectData.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceObjectData>.NativeClassPtr, "Material");
			InstanceObjectData.NativeFieldInfoPtr_TextureResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceObjectData>.NativeClassPtr, "TextureResolution");
			InstanceObjectData.NativeFieldInfoPtr_InstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceObjectData>.NativeClassPtr, "InstanceCount");
			InstanceObjectData.NativeFieldInfoPtr_PositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceObjectData>.NativeClassPtr, "PositionOffset");
			InstanceObjectData.NativeFieldInfoPtr_MinMaxLodDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceObjectData>.NativeClassPtr, "MinMaxLodDistance");
			InstanceObjectData.NativeFieldInfoPtr_PositionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceObjectData>.NativeClassPtr, "PositionData");
			InstanceObjectData.NativeFieldInfoPtr_RotationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceObjectData>.NativeClassPtr, "RotationData");
			InstanceObjectData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceObjectData>.NativeClassPtr, 100672397);
		}

		// Token: 0x060046DE RID: 18142 RVA: 0x0016C35C File Offset: 0x0016A55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166103, XrefRangeEnd = 166106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstanceObjectData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstanceObjectData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstanceObjectData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046DF RID: 18143 RVA: 0x0002293C File Offset: 0x00020B3C
		public InstanceObjectData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x060046E0 RID: 18144 RVA: 0x0016C398 File Offset: 0x0016A598
		// (set) Token: 0x060046E1 RID: 18145 RVA: 0x00022945 File Offset: 0x00020B45
		public unsafe Mesh Mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceObjectData.NativeFieldInfoPtr_Mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceObjectData.NativeFieldInfoPtr_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x060046E2 RID: 18146 RVA: 0x0016C3C8 File Offset: 0x0016A5C8
		// (set) Token: 0x060046E3 RID: 18147 RVA: 0x00022964 File Offset: 0x00020B64
		public unsafe Material Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceObjectData.NativeFieldInfoPtr_Material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceObjectData.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x060046E4 RID: 18148 RVA: 0x0016C3F8 File Offset: 0x0016A5F8
		// (set) Token: 0x060046E5 RID: 18149 RVA: 0x00022983 File Offset: 0x00020B83
		public unsafe int TextureResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceObjectData.NativeFieldInfoPtr_TextureResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceObjectData.NativeFieldInfoPtr_TextureResolution)) = value;
			}
		}

		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x060046E6 RID: 18150 RVA: 0x0016C420 File Offset: 0x0016A620
		// (set) Token: 0x060046E7 RID: 18151 RVA: 0x0002299E File Offset: 0x00020B9E
		public unsafe int InstanceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceObjectData.NativeFieldInfoPtr_InstanceCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceObjectData.NativeFieldInfoPtr_InstanceCount)) = value;
			}
		}

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x060046E8 RID: 18152 RVA: 0x0016C448 File Offset: 0x0016A648
		// (set) Token: 0x060046E9 RID: 18153 RVA: 0x000229B9 File Offset: 0x00020BB9
		public unsafe Vector3 PositionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceObjectData.NativeFieldInfoPtr_PositionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceObjectData.NativeFieldInfoPtr_PositionOffset)) = value;
			}
		}

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x060046EA RID: 18154 RVA: 0x0016C470 File Offset: 0x0016A670
		// (set) Token: 0x060046EB RID: 18155 RVA: 0x000229D4 File Offset: 0x00020BD4
		public unsafe Vector2Int MinMaxLodDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceObjectData.NativeFieldInfoPtr_MinMaxLodDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceObjectData.NativeFieldInfoPtr_MinMaxLodDistance)) = value;
			}
		}

		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x060046EC RID: 18156 RVA: 0x0016C498 File Offset: 0x0016A698
		// (set) Token: 0x060046ED RID: 18157 RVA: 0x000229EF File Offset: 0x00020BEF
		public unsafe Texture2D PositionData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceObjectData.NativeFieldInfoPtr_PositionData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceObjectData.NativeFieldInfoPtr_PositionData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x060046EE RID: 18158 RVA: 0x0016C4C8 File Offset: 0x0016A6C8
		// (set) Token: 0x060046EF RID: 18159 RVA: 0x00022A0E File Offset: 0x00020C0E
		public unsafe Texture2D RotationData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceObjectData.NativeFieldInfoPtr_RotationData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstanceObjectData.NativeFieldInfoPtr_RotationData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400303A RID: 12346
		private static readonly IntPtr NativeFieldInfoPtr_Mesh;

		// Token: 0x0400303B RID: 12347
		private static readonly IntPtr NativeFieldInfoPtr_Material;

		// Token: 0x0400303C RID: 12348
		private static readonly IntPtr NativeFieldInfoPtr_TextureResolution;

		// Token: 0x0400303D RID: 12349
		private static readonly IntPtr NativeFieldInfoPtr_InstanceCount;

		// Token: 0x0400303E RID: 12350
		private static readonly IntPtr NativeFieldInfoPtr_PositionOffset;

		// Token: 0x0400303F RID: 12351
		private static readonly IntPtr NativeFieldInfoPtr_MinMaxLodDistance;

		// Token: 0x04003040 RID: 12352
		private static readonly IntPtr NativeFieldInfoPtr_PositionData;

		// Token: 0x04003041 RID: 12353
		private static readonly IntPtr NativeFieldInfoPtr_RotationData;

		// Token: 0x04003042 RID: 12354
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
