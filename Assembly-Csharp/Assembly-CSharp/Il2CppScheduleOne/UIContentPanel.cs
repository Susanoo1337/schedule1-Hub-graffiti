using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne
{
	// Token: 0x0200009E RID: 158
	public class UIContentPanel : UIPanel
	{
		// Token: 0x06000D92 RID: 3474 RVA: 0x000A893C File Offset: 0x000A6B3C
		// Note: this type is marked as 'beforefieldinit'.
		static UIContentPanel()
		{
			Il2CppClassPointerStore<UIContentPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UIContentPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIContentPanel>.NativeClassPtr);
			UIContentPanel.NativeFieldInfoPtr_uiPanelNavigationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIContentPanel>.NativeClassPtr, "uiPanelNavigationType");
			UIContentPanel.NativeFieldInfoPtr_contentPanelType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIContentPanel>.NativeClassPtr, "contentPanelType");
			UIContentPanel.NativeFieldInfoPtr_navigationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIContentPanel>.NativeClassPtr, "navigationSettings");
			UIContentPanel.NativeMethodInfoPtr_DetectInput_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIContentPanel>.NativeClassPtr, 100665026);
			UIContentPanel.NativeMethodInfoPtr_Navigate_Protected_Virtual_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIContentPanel>.NativeClassPtr, 100665027);
			UIContentPanel.NativeMethodInfoPtr_NavigateToSelectable_Private_Boolean_UISelectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIContentPanel>.NativeClassPtr, 100665028);
			UIContentPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIContentPanel>.NativeClassPtr, 100665029);
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x000A89F8 File Offset: 0x000A6BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80461, XrefRangeEnd = 80494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DetectInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIContentPanel.NativeMethodInfoPtr_DetectInput_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x000A8A34 File Offset: 0x000A6C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80494, XrefRangeEnd = 80509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Navigate(Vector2 navDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref navDir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIContentPanel.NativeMethodInfoPtr_Navigate_Protected_Virtual_Boolean_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x000A8A88 File Offset: 0x000A6C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80509, XrefRangeEnd = 80513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NavigateToSelectable(UISelectable target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIContentPanel.NativeMethodInfoPtr_NavigateToSelectable_Private_Boolean_UISelectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x000A8AD8 File Offset: 0x000A6CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80513, XrefRangeEnd = 80519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIContentPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIContentPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIContentPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x0000834D File Offset: 0x0000654D
		public UIContentPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x000A8B14 File Offset: 0x000A6D14
		// (set) Token: 0x06000D99 RID: 3481 RVA: 0x00008356 File Offset: 0x00006556
		public unsafe UIPanel.UINavigationType uiPanelNavigationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIContentPanel.NativeFieldInfoPtr_uiPanelNavigationType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIContentPanel.NativeFieldInfoPtr_uiPanelNavigationType)) = value;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000D9A RID: 3482 RVA: 0x000A8B3C File Offset: 0x000A6D3C
		// (set) Token: 0x06000D9B RID: 3483 RVA: 0x00008371 File Offset: 0x00006571
		public unsafe UIContentPanel.EContentPanelType contentPanelType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIContentPanel.NativeFieldInfoPtr_contentPanelType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIContentPanel.NativeFieldInfoPtr_contentPanelType)) = value;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x000A8B64 File Offset: 0x000A6D64
		// (set) Token: 0x06000D9D RID: 3485 RVA: 0x0000838C File Offset: 0x0000658C
		public unsafe UIContentPanel.NavigationSettings navigationSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIContentPanel.NativeFieldInfoPtr_navigationSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIContentPanel.NavigationSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIContentPanel.NativeFieldInfoPtr_navigationSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeFieldInfoPtr_uiPanelNavigationType;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeFieldInfoPtr_contentPanelType;

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeFieldInfoPtr_navigationSettings;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeMethodInfoPtr_DetectInput_Protected_Virtual_Void_0;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeMethodInfoPtr_Navigate_Protected_Virtual_Boolean_Vector2_0;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeMethodInfoPtr_NavigateToSelectable_Private_Boolean_UISelectable_0;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008B3 RID: 2227
		[Serializable]
		public class NavigationSettings : Il2CppSystem.Object
		{
			// Token: 0x0600D43D RID: 54333 RVA: 0x0034E0B8 File Offset: 0x0034C2B8
			// Note: this type is marked as 'beforefieldinit'.
			static NavigationSettings()
			{
				Il2CppClassPointerStore<UIContentPanel.NavigationSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIContentPanel>.NativeClassPtr, "NavigationSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIContentPanel.NavigationSettings>.NativeClassPtr);
				UIContentPanel.NavigationSettings.NativeFieldInfoPtr_NavigationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIContentPanel.NavigationSettings>.NativeClassPtr, "NavigationThreshold");
				UIContentPanel.NavigationSettings.NativeFieldInfoPtr_DirectionWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIContentPanel.NavigationSettings>.NativeClassPtr, "DirectionWeight");
				UIContentPanel.NavigationSettings.NativeFieldInfoPtr_DistanceWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIContentPanel.NavigationSettings>.NativeClassPtr, "DistanceWeight");
				UIContentPanel.NavigationSettings.NativeFieldInfoPtr_DirectionMatchThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIContentPanel.NavigationSettings>.NativeClassPtr, "DirectionMatchThreshold");
				UIContentPanel.NavigationSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIContentPanel.NavigationSettings>.NativeClassPtr, 100665030);
			}

			// Token: 0x0600D43E RID: 54334 RVA: 0x0034E148 File Offset: 0x0034C348
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 80460, RefRangeEnd = 80461, XrefRangeStart = 80459, XrefRangeEnd = 80460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NavigationSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIContentPanel.NavigationSettings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIContentPanel.NavigationSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D43F RID: 54335 RVA: 0x000645AE File Offset: 0x000627AE
			public NavigationSettings(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700409A RID: 16538
			// (get) Token: 0x0600D440 RID: 54336 RVA: 0x0034E184 File Offset: 0x0034C384
			// (set) Token: 0x0600D441 RID: 54337 RVA: 0x000645B7 File Offset: 0x000627B7
			public unsafe float NavigationThreshold
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIContentPanel.NavigationSettings.NativeFieldInfoPtr_NavigationThreshold);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIContentPanel.NavigationSettings.NativeFieldInfoPtr_NavigationThreshold)) = value;
				}
			}

			// Token: 0x1700409B RID: 16539
			// (get) Token: 0x0600D442 RID: 54338 RVA: 0x0034E1AC File Offset: 0x0034C3AC
			// (set) Token: 0x0600D443 RID: 54339 RVA: 0x000645D2 File Offset: 0x000627D2
			public unsafe float DirectionWeight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIContentPanel.NavigationSettings.NativeFieldInfoPtr_DirectionWeight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIContentPanel.NavigationSettings.NativeFieldInfoPtr_DirectionWeight)) = value;
				}
			}

			// Token: 0x1700409C RID: 16540
			// (get) Token: 0x0600D444 RID: 54340 RVA: 0x0034E1D4 File Offset: 0x0034C3D4
			// (set) Token: 0x0600D445 RID: 54341 RVA: 0x000645ED File Offset: 0x000627ED
			public unsafe float DistanceWeight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIContentPanel.NavigationSettings.NativeFieldInfoPtr_DistanceWeight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIContentPanel.NavigationSettings.NativeFieldInfoPtr_DistanceWeight)) = value;
				}
			}

			// Token: 0x1700409D RID: 16541
			// (get) Token: 0x0600D446 RID: 54342 RVA: 0x0034E1FC File Offset: 0x0034C3FC
			// (set) Token: 0x0600D447 RID: 54343 RVA: 0x00064608 File Offset: 0x00062808
			public unsafe float DirectionMatchThreshold
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIContentPanel.NavigationSettings.NativeFieldInfoPtr_DirectionMatchThreshold);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIContentPanel.NavigationSettings.NativeFieldInfoPtr_DirectionMatchThreshold)) = value;
				}
			}

			// Token: 0x04009083 RID: 36995
			private static readonly IntPtr NativeFieldInfoPtr_NavigationThreshold;

			// Token: 0x04009084 RID: 36996
			private static readonly IntPtr NativeFieldInfoPtr_DirectionWeight;

			// Token: 0x04009085 RID: 36997
			private static readonly IntPtr NativeFieldInfoPtr_DistanceWeight;

			// Token: 0x04009086 RID: 36998
			private static readonly IntPtr NativeFieldInfoPtr_DirectionMatchThreshold;

			// Token: 0x04009087 RID: 36999
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008B4 RID: 2228
		[OriginalName("Assembly-CSharp.dll", "", "EContentPanelType")]
		public enum EContentPanelType
		{
			// Token: 0x04009089 RID: 37001
			Grid,
			// Token: 0x0400908A RID: 37002
			Vertical,
			// Token: 0x0400908B RID: 37003
			Horizontal
		}
	}
}
