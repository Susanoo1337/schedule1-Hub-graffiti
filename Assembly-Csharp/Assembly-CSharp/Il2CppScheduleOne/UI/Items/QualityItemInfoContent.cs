using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppTMPro;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x0200082E RID: 2094
	public class QualityItemInfoContent : ItemInfoContent
	{
		// Token: 0x0600CB9E RID: 52126 RVA: 0x003345EC File Offset: 0x003327EC
		// Note: this type is marked as 'beforefieldinit'.
		static QualityItemInfoContent()
		{
			Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "QualityItemInfoContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr);
			QualityItemInfoContent.NativeFieldInfoPtr_Star = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr, "Star");
			QualityItemInfoContent.NativeFieldInfoPtr_QualityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr, "QualityLabel");
			QualityItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr, 100689547);
			QualityItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr, 100689548);
		}

		// Token: 0x0600CB9F RID: 52127 RVA: 0x0033466C File Offset: 0x0033286C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334253, RefRangeEnd = 334254, XrefRangeStart = 334239, XrefRangeEnd = 334253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CBA0 RID: 52128 RVA: 0x003346BC File Offset: 0x003328BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemInfoContent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityItemInfoContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CBA1 RID: 52129 RVA: 0x000609D7 File Offset: 0x0005EBD7
		public QualityItemInfoContent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003DDA RID: 15834
		// (get) Token: 0x0600CBA2 RID: 52130 RVA: 0x003346F8 File Offset: 0x003328F8
		// (set) Token: 0x0600CBA3 RID: 52131 RVA: 0x000609E0 File Offset: 0x0005EBE0
		public unsafe Image Star
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemInfoContent.NativeFieldInfoPtr_Star);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemInfoContent.NativeFieldInfoPtr_Star), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DDB RID: 15835
		// (get) Token: 0x0600CBA4 RID: 52132 RVA: 0x00334728 File Offset: 0x00332928
		// (set) Token: 0x0600CBA5 RID: 52133 RVA: 0x000609FF File Offset: 0x0005EBFF
		public unsafe TextMeshProUGUI QualityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemInfoContent.NativeFieldInfoPtr_QualityLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemInfoContent.NativeFieldInfoPtr_QualityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008A9E RID: 35486
		private static readonly IntPtr NativeFieldInfoPtr_Star;

		// Token: 0x04008A9F RID: 35487
		private static readonly IntPtr NativeFieldInfoPtr_QualityLabel;

		// Token: 0x04008AA0 RID: 35488
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04008AA1 RID: 35489
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
