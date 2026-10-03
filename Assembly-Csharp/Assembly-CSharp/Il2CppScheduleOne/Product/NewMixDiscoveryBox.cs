using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Effects;
using Il2CppScheduleOne.Interaction;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000557 RID: 1367
	public class NewMixDiscoveryBox : MonoBehaviour
	{
		// Token: 0x06007C36 RID: 31798 RVA: 0x00224830 File Offset: 0x00222A30
		// Note: this type is marked as 'beforefieldinit'.
		static NewMixDiscoveryBox()
		{
			Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "NewMixDiscoveryBox");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr);
			NewMixDiscoveryBox.NativeFieldInfoPtr_isOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "isOpen");
			NewMixDiscoveryBox.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "CameraPosition");
			NewMixDiscoveryBox.NativeFieldInfoPtr_PropertiesText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "PropertiesText");
			NewMixDiscoveryBox.NativeFieldInfoPtr_Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "Animation");
			NewMixDiscoveryBox.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "IntObj");
			NewMixDiscoveryBox.NativeFieldInfoPtr_Lid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "Lid");
			NewMixDiscoveryBox.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "Visuals");
			NewMixDiscoveryBox.NativeFieldInfoPtr_closedLidPose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "closedLidPose");
			NewMixDiscoveryBox.NativeFieldInfoPtr_currentMix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "currentMix");
			NewMixDiscoveryBox.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679249);
			NewMixDiscoveryBox.NativeMethodInfoPtr_ShowProduct_Public_Void_ProductDefinition_List_1_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679250);
			NewMixDiscoveryBox.NativeMethodInfoPtr_CloseCase_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679251);
			NewMixDiscoveryBox.NativeMethodInfoPtr_OpenCase_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679252);
			NewMixDiscoveryBox.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679253);
			NewMixDiscoveryBox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679254);
		}

		// Token: 0x06007C37 RID: 31799 RVA: 0x0022498C File Offset: 0x00222B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236480, XrefRangeEnd = 236498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C38 RID: 31800 RVA: 0x002249C0 File Offset: 0x00222BC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236545, RefRangeEnd = 236546, XrefRangeStart = 236498, XrefRangeEnd = 236545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowProduct(ProductDefinition baseDefinition, List<Effect> properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseDefinition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr_ShowProduct_Public_Void_ProductDefinition_List_1_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C39 RID: 31801 RVA: 0x00224A14 File Offset: 0x00222C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236546, XrefRangeEnd = 236548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseCase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr_CloseCase_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C3A RID: 31802 RVA: 0x00224A48 File Offset: 0x00222C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236548, XrefRangeEnd = 236552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenCase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr_OpenCase_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C3B RID: 31803 RVA: 0x00224A7C File Offset: 0x00222C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236552, XrefRangeEnd = 236557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C3C RID: 31804 RVA: 0x00224AB0 File Offset: 0x00222CB0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewMixDiscoveryBox() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C3D RID: 31805 RVA: 0x0003B21F File Offset: 0x0003941F
		public NewMixDiscoveryBox(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700266C RID: 9836
		// (get) Token: 0x06007C3E RID: 31806 RVA: 0x00224AEC File Offset: 0x00222CEC
		// (set) Token: 0x06007C3F RID: 31807 RVA: 0x0003B228 File Offset: 0x00039428
		public unsafe bool isOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_isOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_isOpen)) = value;
			}
		}

		// Token: 0x1700266D RID: 9837
		// (get) Token: 0x06007C40 RID: 31808 RVA: 0x00224B14 File Offset: 0x00222D14
		// (set) Token: 0x06007C41 RID: 31809 RVA: 0x0003B243 File Offset: 0x00039443
		public unsafe Transform CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700266E RID: 9838
		// (get) Token: 0x06007C42 RID: 31810 RVA: 0x00224B44 File Offset: 0x00222D44
		// (set) Token: 0x06007C43 RID: 31811 RVA: 0x0003B262 File Offset: 0x00039462
		public unsafe TextMeshPro PropertiesText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_PropertiesText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_PropertiesText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700266F RID: 9839
		// (get) Token: 0x06007C44 RID: 31812 RVA: 0x00224B74 File Offset: 0x00222D74
		// (set) Token: 0x06007C45 RID: 31813 RVA: 0x0003B281 File Offset: 0x00039481
		public unsafe Animation Animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002670 RID: 9840
		// (get) Token: 0x06007C46 RID: 31814 RVA: 0x00224BA4 File Offset: 0x00222DA4
		// (set) Token: 0x06007C47 RID: 31815 RVA: 0x0003B2A0 File Offset: 0x000394A0
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002671 RID: 9841
		// (get) Token: 0x06007C48 RID: 31816 RVA: 0x00224BD4 File Offset: 0x00222DD4
		// (set) Token: 0x06007C49 RID: 31817 RVA: 0x0003B2BF File Offset: 0x000394BF
		public unsafe Transform Lid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Lid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Lid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002672 RID: 9842
		// (get) Token: 0x06007C4A RID: 31818 RVA: 0x00224C04 File Offset: 0x00222E04
		// (set) Token: 0x06007C4B RID: 31819 RVA: 0x0003B2DE File Offset: 0x000394DE
		public unsafe MultiTypeVisualsSetter Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiTypeVisualsSetter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002673 RID: 9843
		// (get) Token: 0x06007C4C RID: 31820 RVA: 0x00224C34 File Offset: 0x00222E34
		// (set) Token: 0x06007C4D RID: 31821 RVA: 0x0003B2FD File Offset: 0x000394FD
		public unsafe Pose closedLidPose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_closedLidPose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_closedLidPose)) = value;
			}
		}

		// Token: 0x17002674 RID: 9844
		// (get) Token: 0x06007C4E RID: 31822 RVA: 0x00224C5C File Offset: 0x00222E5C
		// (set) Token: 0x06007C4F RID: 31823 RVA: 0x0003B318 File Offset: 0x00039518
		public unsafe NewMixOperation currentMix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_currentMix);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NewMixOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_currentMix), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040054B5 RID: 21685
		private static readonly IntPtr NativeFieldInfoPtr_isOpen;

		// Token: 0x040054B6 RID: 21686
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x040054B7 RID: 21687
		private static readonly IntPtr NativeFieldInfoPtr_PropertiesText;

		// Token: 0x040054B8 RID: 21688
		private static readonly IntPtr NativeFieldInfoPtr_Animation;

		// Token: 0x040054B9 RID: 21689
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x040054BA RID: 21690
		private static readonly IntPtr NativeFieldInfoPtr_Lid;

		// Token: 0x040054BB RID: 21691
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x040054BC RID: 21692
		private static readonly IntPtr NativeFieldInfoPtr_closedLidPose;

		// Token: 0x040054BD RID: 21693
		private static readonly IntPtr NativeFieldInfoPtr_currentMix;

		// Token: 0x040054BE RID: 21694
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040054BF RID: 21695
		private static readonly IntPtr NativeMethodInfoPtr_ShowProduct_Public_Void_ProductDefinition_List_1_Effect_0;

		// Token: 0x040054C0 RID: 21696
		private static readonly IntPtr NativeMethodInfoPtr_CloseCase_Private_Void_0;

		// Token: 0x040054C1 RID: 21697
		private static readonly IntPtr NativeMethodInfoPtr_OpenCase_Private_Void_0;

		// Token: 0x040054C2 RID: 21698
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x040054C3 RID: 21699
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
