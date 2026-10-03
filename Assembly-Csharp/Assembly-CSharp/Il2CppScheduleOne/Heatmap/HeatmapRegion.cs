using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using UnityEngine;

namespace Il2CppScheduleOne.Heatmap
{
	// Token: 0x0200033C RID: 828
	public class HeatmapRegion : MonoBehaviour
	{
		// Token: 0x06004756 RID: 18262 RVA: 0x0016D858 File Offset: 0x0016BA58
		// Note: this type is marked as 'beforefieldinit'.
		static HeatmapRegion()
		{
			Il2CppClassPointerStore<HeatmapRegion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Heatmap", "HeatmapRegion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeatmapRegion>.NativeClassPtr);
			HeatmapRegion.NativeFieldInfoPtr__textureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatmapRegion>.NativeClassPtr, "_textureIndex");
			HeatmapRegion.NativeFieldInfoPtr__renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatmapRegion>.NativeClassPtr, "_renderer");
			HeatmapRegion.NativeMethodInfoPtr_Create_Public_Void_Grid_Int32_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatmapRegion>.NativeClassPtr, 100672438);
			HeatmapRegion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatmapRegion>.NativeClassPtr, 100672439);
		}

		// Token: 0x06004757 RID: 18263 RVA: 0x0016D8D8 File Offset: 0x0016BAD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166832, RefRangeEnd = 166833, XrefRangeStart = 166787, XrefRangeEnd = 166832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Create(Grid grid, int textureIndex, Material heatmapMat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textureIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(heatmapMat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeatmapRegion.NativeMethodInfoPtr_Create_Public_Void_Grid_Int32_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004758 RID: 18264 RVA: 0x0016D93C File Offset: 0x0016BB3C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeatmapRegion() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeatmapRegion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeatmapRegion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004759 RID: 18265 RVA: 0x00022D78 File Offset: 0x00020F78
		public HeatmapRegion(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700166F RID: 5743
		// (get) Token: 0x0600475A RID: 18266 RVA: 0x0016D978 File Offset: 0x0016BB78
		// (set) Token: 0x0600475B RID: 18267 RVA: 0x00022D81 File Offset: 0x00020F81
		public unsafe int _textureIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapRegion.NativeFieldInfoPtr__textureIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapRegion.NativeFieldInfoPtr__textureIndex)) = value;
			}
		}

		// Token: 0x17001670 RID: 5744
		// (get) Token: 0x0600475C RID: 18268 RVA: 0x0016D9A0 File Offset: 0x0016BBA0
		// (set) Token: 0x0600475D RID: 18269 RVA: 0x00022D9C File Offset: 0x00020F9C
		public unsafe MeshRenderer _renderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapRegion.NativeFieldInfoPtr__renderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapRegion.NativeFieldInfoPtr__renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003084 RID: 12420
		private static readonly IntPtr NativeFieldInfoPtr__textureIndex;

		// Token: 0x04003085 RID: 12421
		private static readonly IntPtr NativeFieldInfoPtr__renderer;

		// Token: 0x04003086 RID: 12422
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Void_Grid_Int32_Material_0;

		// Token: 0x04003087 RID: 12423
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
