using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using UnityEngine;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000106 RID: 262
	public class TVInteractable : MonoBehaviour
	{
		// Token: 0x06001968 RID: 6504 RVA: 0x000CEB08 File Offset: 0x000CCD08
		// Note: this type is marked as 'beforefieldinit'.
		static TVInteractable()
		{
			Il2CppClassPointerStore<TVInteractable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "TVInteractable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVInteractable>.NativeClassPtr);
			TVInteractable.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInteractable>.NativeClassPtr, "IntObj");
			TVInteractable.NativeFieldInfoPtr_Interface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInteractable>.NativeClassPtr, "Interface");
			TVInteractable.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInteractable>.NativeClassPtr, 100666684);
			TVInteractable.NativeMethodInfoPtr_Hovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInteractable>.NativeClassPtr, 100666685);
			TVInteractable.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInteractable>.NativeClassPtr, 100666686);
			TVInteractable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInteractable>.NativeClassPtr, 100666687);
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x000CEBB0 File Offset: 0x000CCDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98982, XrefRangeEnd = 98996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInteractable.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x000CEBE4 File Offset: 0x000CCDE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98996, XrefRangeEnd = 98997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInteractable.NativeMethodInfoPtr_Hovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x000CEC18 File Offset: 0x000CCE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98997, XrefRangeEnd = 98998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInteractable.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x000CEC4C File Offset: 0x000CCE4C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TVInteractable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVInteractable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInteractable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x0000DFB7 File Offset: 0x0000C1B7
		public TVInteractable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x000CEC88 File Offset: 0x000CCE88
		// (set) Token: 0x0600196F RID: 6511 RVA: 0x0000DFC0 File Offset: 0x0000C1C0
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInteractable.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInteractable.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001970 RID: 6512 RVA: 0x000CECB8 File Offset: 0x000CCEB8
		// (set) Token: 0x06001971 RID: 6513 RVA: 0x0000DFDF File Offset: 0x0000C1DF
		public unsafe TVInterface Interface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInteractable.NativeFieldInfoPtr_Interface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInteractable.NativeFieldInfoPtr_Interface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001191 RID: 4497
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeFieldInfoPtr_Interface;

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Private_Void_0;

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
