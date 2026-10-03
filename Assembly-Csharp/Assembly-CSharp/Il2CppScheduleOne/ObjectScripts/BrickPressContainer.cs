using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200059E RID: 1438
	public class BrickPressContainer : MonoBehaviour
	{
		// Token: 0x060083CC RID: 33740 RVA: 0x0024081C File Offset: 0x0023EA1C
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressContainer()
		{
			Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "BrickPressContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr);
			BrickPressContainer.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, "Visuals");
			BrickPressContainer.NativeFieldInfoPtr_ContentsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, "ContentsContainer");
			BrickPressContainer.NativeFieldInfoPtr_Contents_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, "Contents_Min");
			BrickPressContainer.NativeFieldInfoPtr_Contents_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, "Contents_Max");
			BrickPressContainer.NativeMethodInfoPtr_SetContents_Public_Void_ProductItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, 100680265);
			BrickPressContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr, 100680266);
		}

		// Token: 0x060083CD RID: 33741 RVA: 0x002408C4 File Offset: 0x0023EAC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248470, RefRangeEnd = 248471, XrefRangeStart = 248459, XrefRangeEnd = 248470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContents(ProductItemInstance product, float fillLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressContainer.NativeMethodInfoPtr_SetContents_Public_Void_ProductItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083CE RID: 33742 RVA: 0x00240914 File Offset: 0x0023EB14
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060083CF RID: 33743 RVA: 0x0003E8FA File Offset: 0x0003CAFA
		public BrickPressContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028B4 RID: 10420
		// (get) Token: 0x060083D0 RID: 33744 RVA: 0x00240950 File Offset: 0x0023EB50
		// (set) Token: 0x060083D1 RID: 33745 RVA: 0x0003E903 File Offset: 0x0003CB03
		public unsafe MultiTypeVisualsSetter Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiTypeVisualsSetter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028B5 RID: 10421
		// (get) Token: 0x060083D2 RID: 33746 RVA: 0x00240980 File Offset: 0x0023EB80
		// (set) Token: 0x060083D3 RID: 33747 RVA: 0x0003E922 File Offset: 0x0003CB22
		public unsafe Transform ContentsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_ContentsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_ContentsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028B6 RID: 10422
		// (get) Token: 0x060083D4 RID: 33748 RVA: 0x002409B0 File Offset: 0x0023EBB0
		// (set) Token: 0x060083D5 RID: 33749 RVA: 0x0003E941 File Offset: 0x0003CB41
		public unsafe Transform Contents_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Contents_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Contents_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028B7 RID: 10423
		// (get) Token: 0x060083D6 RID: 33750 RVA: 0x002409E0 File Offset: 0x0023EBE0
		// (set) Token: 0x060083D7 RID: 33751 RVA: 0x0003E960 File Offset: 0x0003CB60
		public unsafe Transform Contents_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Contents_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressContainer.NativeFieldInfoPtr_Contents_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040059F0 RID: 23024
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x040059F1 RID: 23025
		private static readonly IntPtr NativeFieldInfoPtr_ContentsContainer;

		// Token: 0x040059F2 RID: 23026
		private static readonly IntPtr NativeFieldInfoPtr_Contents_Min;

		// Token: 0x040059F3 RID: 23027
		private static readonly IntPtr NativeFieldInfoPtr_Contents_Max;

		// Token: 0x040059F4 RID: 23028
		private static readonly IntPtr NativeMethodInfoPtr_SetContents_Public_Void_ProductItemInstance_Single_0;

		// Token: 0x040059F5 RID: 23029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
