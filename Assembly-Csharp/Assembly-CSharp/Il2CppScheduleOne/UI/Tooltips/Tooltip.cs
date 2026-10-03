using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Tooltips
{
	// Token: 0x02000777 RID: 1911
	public class Tooltip : MonoBehaviour
	{
		// Token: 0x0600B9FE RID: 47614 RVA: 0x002FE328 File Offset: 0x002FC528
		// Note: this type is marked as 'beforefieldinit'.
		static Tooltip()
		{
			Il2CppClassPointerStore<Tooltip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Tooltips", "Tooltip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tooltip>.NativeClassPtr);
			Tooltip.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, "text");
			Tooltip.NativeFieldInfoPtr_labelOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, "labelOffset");
			Tooltip.NativeFieldInfoPtr_LabelOriginRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, "LabelOriginRect");
			Tooltip.NativeFieldInfoPtr__isWorldspace_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, "<isWorldspace>k__BackingField");
			Tooltip.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, "canvas");
			Tooltip.NativeMethodInfoPtr_get_labelPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, 100687588);
			Tooltip.NativeMethodInfoPtr_get_isWorldspace_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, 100687589);
			Tooltip.NativeMethodInfoPtr_set_isWorldspace_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, 100687590);
			Tooltip.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, 100687591);
			Tooltip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tooltip>.NativeClassPtr, 100687592);
		}

		// Token: 0x1700383D RID: 14397
		// (get) Token: 0x0600B9FF RID: 47615 RVA: 0x002FE420 File Offset: 0x002FC620
		public unsafe Vector3 labelPosition
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 310572, RefRangeEnd = 310574, XrefRangeStart = 310569, XrefRangeEnd = 310572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tooltip.NativeMethodInfoPtr_get_labelPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700383E RID: 14398
		// (get) Token: 0x0600BA00 RID: 47616 RVA: 0x002FE45C File Offset: 0x002FC65C
		// (set) Token: 0x0600BA01 RID: 47617 RVA: 0x002FE498 File Offset: 0x002FC698
		public unsafe bool isWorldspace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tooltip.NativeMethodInfoPtr_get_isWorldspace_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tooltip.NativeMethodInfoPtr_set_isWorldspace_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600BA02 RID: 47618 RVA: 0x002FE4D8 File Offset: 0x002FC6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310574, XrefRangeEnd = 310602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tooltip.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA03 RID: 47619 RVA: 0x002FE514 File Offset: 0x002FC714
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tooltip() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tooltip>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tooltip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA04 RID: 47620 RVA: 0x00056A80 File Offset: 0x00054C80
		public Tooltip(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003838 RID: 14392
		// (get) Token: 0x0600BA05 RID: 47621 RVA: 0x002FE550 File Offset: 0x002FC750
		// (set) Token: 0x0600BA06 RID: 47622 RVA: 0x00056A89 File Offset: 0x00054C89
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003839 RID: 14393
		// (get) Token: 0x0600BA07 RID: 47623 RVA: 0x002FE578 File Offset: 0x002FC778
		// (set) Token: 0x0600BA08 RID: 47624 RVA: 0x00056AA8 File Offset: 0x00054CA8
		public unsafe Vector2 labelOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_labelOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_labelOffset)) = value;
			}
		}

		// Token: 0x1700383A RID: 14394
		// (get) Token: 0x0600BA09 RID: 47625 RVA: 0x002FE5A0 File Offset: 0x002FC7A0
		// (set) Token: 0x0600BA0A RID: 47626 RVA: 0x00056AC3 File Offset: 0x00054CC3
		public unsafe RectTransform LabelOriginRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_LabelOriginRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_LabelOriginRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700383B RID: 14395
		// (get) Token: 0x0600BA0B RID: 47627 RVA: 0x002FE5D0 File Offset: 0x002FC7D0
		// (set) Token: 0x0600BA0C RID: 47628 RVA: 0x00056AE2 File Offset: 0x00054CE2
		public unsafe bool _isWorldspace_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr__isWorldspace_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr__isWorldspace_k__BackingField)) = value;
			}
		}

		// Token: 0x1700383C RID: 14396
		// (get) Token: 0x0600BA0D RID: 47629 RVA: 0x002FE5F8 File Offset: 0x002FC7F8
		// (set) Token: 0x0600BA0E RID: 47630 RVA: 0x00056AFD File Offset: 0x00054CFD
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tooltip.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007F8B RID: 32651
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04007F8C RID: 32652
		private static readonly IntPtr NativeFieldInfoPtr_labelOffset;

		// Token: 0x04007F8D RID: 32653
		private static readonly IntPtr NativeFieldInfoPtr_LabelOriginRect;

		// Token: 0x04007F8E RID: 32654
		private static readonly IntPtr NativeFieldInfoPtr__isWorldspace_k__BackingField;

		// Token: 0x04007F8F RID: 32655
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04007F90 RID: 32656
		private static readonly IntPtr NativeMethodInfoPtr_get_labelPosition_Public_get_Vector3_0;

		// Token: 0x04007F91 RID: 32657
		private static readonly IntPtr NativeMethodInfoPtr_get_isWorldspace_Public_get_Boolean_0;

		// Token: 0x04007F92 RID: 32658
		private static readonly IntPtr NativeMethodInfoPtr_set_isWorldspace_Private_set_Void_Boolean_0;

		// Token: 0x04007F93 RID: 32659
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04007F94 RID: 32660
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
