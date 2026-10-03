using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200071D RID: 1821
	public class CanvasDistanceFade : MonoBehaviour
	{
		// Token: 0x0600AFBD RID: 44989 RVA: 0x002DFDD8 File Offset: 0x002DDFD8
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasDistanceFade()
		{
			Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CanvasDistanceFade");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr);
			CanvasDistanceFade.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr, "CanvasGroup");
			CanvasDistanceFade.NativeFieldInfoPtr_MinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr, "MinDistance");
			CanvasDistanceFade.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr, "MaxDistance");
			CanvasDistanceFade.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr, 100686403);
			CanvasDistanceFade.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr, 100686404);
		}

		// Token: 0x0600AFBE RID: 44990 RVA: 0x002DFE6C File Offset: 0x002DE06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299275, XrefRangeEnd = 299292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasDistanceFade.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AFBF RID: 44991 RVA: 0x002DFEA0 File Offset: 0x002DE0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299292, XrefRangeEnd = 299293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanvasDistanceFade() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasDistanceFade.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AFC0 RID: 44992 RVA: 0x00050A8F File Offset: 0x0004EC8F
		public CanvasDistanceFade(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170034C8 RID: 13512
		// (get) Token: 0x0600AFC1 RID: 44993 RVA: 0x002DFEDC File Offset: 0x002DE0DC
		// (set) Token: 0x0600AFC2 RID: 44994 RVA: 0x00050A98 File Offset: 0x0004EC98
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034C9 RID: 13513
		// (get) Token: 0x0600AFC3 RID: 44995 RVA: 0x002DFF0C File Offset: 0x002DE10C
		// (set) Token: 0x0600AFC4 RID: 44996 RVA: 0x00050AB7 File Offset: 0x0004ECB7
		public unsafe float MinDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_MinDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_MinDistance)) = value;
			}
		}

		// Token: 0x170034CA RID: 13514
		// (get) Token: 0x0600AFC5 RID: 44997 RVA: 0x002DFF34 File Offset: 0x002DE134
		// (set) Token: 0x0600AFC6 RID: 44998 RVA: 0x00050AD2 File Offset: 0x0004ECD2
		public unsafe float MaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_MaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_MaxDistance)) = value;
			}
		}

		// Token: 0x0400792E RID: 31022
		private static readonly IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x0400792F RID: 31023
		private static readonly IntPtr NativeFieldInfoPtr_MinDistance;

		// Token: 0x04007930 RID: 31024
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistance;

		// Token: 0x04007931 RID: 31025
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x04007932 RID: 31026
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
