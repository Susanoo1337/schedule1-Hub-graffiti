using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI;
using UnityEngine;

namespace Il2CppScheduleOne.CustomUI
{
	// Token: 0x02000841 RID: 2113
	public class UICycler : MonoBehaviour
	{
		// Token: 0x0600CDFD RID: 52733 RVA: 0x0033C148 File Offset: 0x0033A348
		// Note: this type is marked as 'beforefieldinit'.
		static UICycler()
		{
			Il2CppClassPointerStore<UICycler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.CustomUI", "UICycler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UICycler>.NativeClassPtr);
			UICycler.NativeFieldInfoPtr__tabController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICycler>.NativeClassPtr, "_tabController");
			UICycler.NativeFieldInfoPtr__currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICycler>.NativeClassPtr, "_currentIndex");
			UICycler.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UICycler>.NativeClassPtr, 100689824);
			UICycler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UICycler>.NativeClassPtr, 100689825);
		}

		// Token: 0x0600CDFE RID: 52734 RVA: 0x0033C1C8 File Offset: 0x0033A3C8
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UICycler.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CDFF RID: 52735 RVA: 0x0033C1FC File Offset: 0x0033A3FC
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UICycler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UICycler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UICycler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CE00 RID: 52736 RVA: 0x00061E08 File Offset: 0x00060008
		public UICycler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003EA2 RID: 16034
		// (get) Token: 0x0600CE01 RID: 52737 RVA: 0x0033C238 File Offset: 0x0033A438
		// (set) Token: 0x0600CE02 RID: 52738 RVA: 0x00061E11 File Offset: 0x00060011
		public unsafe TabController _tabController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICycler.NativeFieldInfoPtr__tabController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TabController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICycler.NativeFieldInfoPtr__tabController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003EA3 RID: 16035
		// (get) Token: 0x0600CE03 RID: 52739 RVA: 0x0033C268 File Offset: 0x0033A468
		// (set) Token: 0x0600CE04 RID: 52740 RVA: 0x00061E30 File Offset: 0x00060030
		public unsafe int _currentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICycler.NativeFieldInfoPtr__currentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UICycler.NativeFieldInfoPtr__currentIndex)) = value;
			}
		}

		// Token: 0x04008C43 RID: 35907
		private static readonly IntPtr NativeFieldInfoPtr__tabController;

		// Token: 0x04008C44 RID: 35908
		private static readonly IntPtr NativeFieldInfoPtr__currentIndex;

		// Token: 0x04008C45 RID: 35909
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04008C46 RID: 35910
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
