using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003F0 RID: 1008
	public class IconGenerator : Singleton<IconGenerator>
	{
		// Token: 0x060059C9 RID: 22985 RVA: 0x001B13B0 File Offset: 0x001AF5B0
		// Note: this type is marked as 'beforefieldinit'.
		static IconGenerator()
		{
			Il2CppClassPointerStore<IconGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "IconGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr);
			IconGenerator.NativeFieldInfoPtr_IconSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "IconSize");
			IconGenerator.NativeFieldInfoPtr_OutputPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "OutputPath");
			IconGenerator.NativeFieldInfoPtr_ModifyLighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "ModifyLighting");
			IconGenerator.NativeFieldInfoPtr_Registry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "Registry");
			IconGenerator.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "CameraPosition");
			IconGenerator.NativeFieldInfoPtr_MainContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "MainContainer");
			IconGenerator.NativeFieldInfoPtr_ItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "ItemContainer");
			IconGenerator.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "Canvas");
			IconGenerator.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "Visuals");
			IconGenerator.NativeFieldInfoPtr_rendererData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "rendererData");
			IconGenerator.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, 100675046);
			IconGenerator.NativeMethodInfoPtr_GenerateIcon_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, 100675047);
			IconGenerator.NativeMethodInfoPtr_GeneratePackagingIcon_Public_Texture2D_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, 100675048);
			IconGenerator.NativeMethodInfoPtr_GetTexture_Public_Texture2D_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, 100675049);
			IconGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, 100675050);
		}

		// Token: 0x060059CA RID: 22986 RVA: 0x001B150C File Offset: 0x001AF70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194369, XrefRangeEnd = 194386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IconGenerator.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060059CB RID: 22987 RVA: 0x001B1548 File Offset: 0x001AF748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194386, XrefRangeEnd = 194424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.NativeMethodInfoPtr_GenerateIcon_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060059CC RID: 22988 RVA: 0x001B157C File Offset: 0x001AF77C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194480, RefRangeEnd = 194481, XrefRangeStart = 194424, XrefRangeEnd = 194480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GeneratePackagingIcon(string packagingID, string productID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.NativeMethodInfoPtr_GeneratePackagingIcon_Public_Texture2D_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x060059CD RID: 22989 RVA: 0x001B15E0 File Offset: 0x001AF7E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 194542, RefRangeEnd = 194546, XrefRangeStart = 194481, XrefRangeEnd = 194542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GetTexture(Transform model)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(model);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.NativeMethodInfoPtr_GetTexture_Public_Texture2D_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x060059CE RID: 22990 RVA: 0x001B1630 File Offset: 0x001AF830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194546, XrefRangeEnd = 194549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IconGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060059CF RID: 22991 RVA: 0x0002A8F4 File Offset: 0x00028AF4
		public IconGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BB5 RID: 7093
		// (get) Token: 0x060059D0 RID: 22992 RVA: 0x001B166C File Offset: 0x001AF86C
		// (set) Token: 0x060059D1 RID: 22993 RVA: 0x0002A8FD File Offset: 0x00028AFD
		public unsafe int IconSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_IconSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_IconSize)) = value;
			}
		}

		// Token: 0x17001BB6 RID: 7094
		// (get) Token: 0x060059D2 RID: 22994 RVA: 0x001B1694 File Offset: 0x001AF894
		// (set) Token: 0x060059D3 RID: 22995 RVA: 0x0002A918 File Offset: 0x00028B18
		public unsafe string OutputPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_OutputPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_OutputPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x060059D4 RID: 22996 RVA: 0x001B16BC File Offset: 0x001AF8BC
		// (set) Token: 0x060059D5 RID: 22997 RVA: 0x0002A937 File Offset: 0x00028B37
		public unsafe bool ModifyLighting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_ModifyLighting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_ModifyLighting)) = value;
			}
		}

		// Token: 0x17001BB8 RID: 7096
		// (get) Token: 0x060059D6 RID: 22998 RVA: 0x001B16E4 File Offset: 0x001AF8E4
		// (set) Token: 0x060059D7 RID: 22999 RVA: 0x0002A952 File Offset: 0x00028B52
		public unsafe Registry Registry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Registry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Registry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Registry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BB9 RID: 7097
		// (get) Token: 0x060059D8 RID: 23000 RVA: 0x001B1714 File Offset: 0x001AF914
		// (set) Token: 0x060059D9 RID: 23001 RVA: 0x0002A971 File Offset: 0x00028B71
		public unsafe Camera CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BBA RID: 7098
		// (get) Token: 0x060059DA RID: 23002 RVA: 0x001B1744 File Offset: 0x001AF944
		// (set) Token: 0x060059DB RID: 23003 RVA: 0x0002A990 File Offset: 0x00028B90
		public unsafe Transform MainContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_MainContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_MainContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BBB RID: 7099
		// (get) Token: 0x060059DC RID: 23004 RVA: 0x001B1774 File Offset: 0x001AF974
		// (set) Token: 0x060059DD RID: 23005 RVA: 0x0002A9AF File Offset: 0x00028BAF
		public unsafe Transform ItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_ItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_ItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BBC RID: 7100
		// (get) Token: 0x060059DE RID: 23006 RVA: 0x001B17A4 File Offset: 0x001AF9A4
		// (set) Token: 0x060059DF RID: 23007 RVA: 0x0002A9CE File Offset: 0x00028BCE
		public unsafe GameObject Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BBD RID: 7101
		// (get) Token: 0x060059E0 RID: 23008 RVA: 0x001B17D4 File Offset: 0x001AF9D4
		// (set) Token: 0x060059E1 RID: 23009 RVA: 0x0002A9ED File Offset: 0x00028BED
		public unsafe List<IconGenerator.PackagingVisuals> Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IconGenerator.PackagingVisuals>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BBE RID: 7102
		// (get) Token: 0x060059E2 RID: 23010 RVA: 0x001B1804 File Offset: 0x001AFA04
		// (set) Token: 0x060059E3 RID: 23011 RVA: 0x0002AA0C File Offset: 0x00028C0C
		public unsafe UniversalRendererData rendererData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_rendererData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalRendererData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_rendererData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003DA3 RID: 15779
		private static readonly IntPtr NativeFieldInfoPtr_IconSize;

		// Token: 0x04003DA4 RID: 15780
		private static readonly IntPtr NativeFieldInfoPtr_OutputPath;

		// Token: 0x04003DA5 RID: 15781
		private static readonly IntPtr NativeFieldInfoPtr_ModifyLighting;

		// Token: 0x04003DA6 RID: 15782
		private static readonly IntPtr NativeFieldInfoPtr_Registry;

		// Token: 0x04003DA7 RID: 15783
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x04003DA8 RID: 15784
		private static readonly IntPtr NativeFieldInfoPtr_MainContainer;

		// Token: 0x04003DA9 RID: 15785
		private static readonly IntPtr NativeFieldInfoPtr_ItemContainer;

		// Token: 0x04003DAA RID: 15786
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04003DAB RID: 15787
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04003DAC RID: 15788
		private static readonly IntPtr NativeFieldInfoPtr_rendererData;

		// Token: 0x04003DAD RID: 15789
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003DAE RID: 15790
		private static readonly IntPtr NativeMethodInfoPtr_GenerateIcon_Public_Void_0;

		// Token: 0x04003DAF RID: 15791
		private static readonly IntPtr NativeMethodInfoPtr_GeneratePackagingIcon_Public_Texture2D_String_String_0;

		// Token: 0x04003DB0 RID: 15792
		private static readonly IntPtr NativeMethodInfoPtr_GetTexture_Public_Texture2D_Transform_0;

		// Token: 0x04003DB1 RID: 15793
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AE3 RID: 2787
		[Serializable]
		public class PackagingVisuals : Il2CppSystem.Object
		{
			// Token: 0x0600E4D2 RID: 58578 RVA: 0x0037F504 File Offset: 0x0037D704
			// Note: this type is marked as 'beforefieldinit'.
			static PackagingVisuals()
			{
				Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "PackagingVisuals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr);
				IconGenerator.PackagingVisuals.NativeFieldInfoPtr_PackagingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr, "PackagingID");
				IconGenerator.PackagingVisuals.NativeFieldInfoPtr_ProductVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr, "ProductVisuals");
				IconGenerator.PackagingVisuals.NativeFieldInfoPtr_TopLevelTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr, "TopLevelTransform");
				IconGenerator.PackagingVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr, 100675051);
			}

			// Token: 0x0600E4D3 RID: 58579 RVA: 0x0037F580 File Offset: 0x0037D780
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PackagingVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.PackagingVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4D4 RID: 58580 RVA: 0x0006BE11 File Offset: 0x0006A011
			public PackagingVisuals(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004590 RID: 17808
			// (get) Token: 0x0600E4D5 RID: 58581 RVA: 0x0037F5BC File Offset: 0x0037D7BC
			// (set) Token: 0x0600E4D6 RID: 58582 RVA: 0x0006BE1A File Offset: 0x0006A01A
			public unsafe string PackagingID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.PackagingVisuals.NativeFieldInfoPtr_PackagingID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.PackagingVisuals.NativeFieldInfoPtr_PackagingID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004591 RID: 17809
			// (get) Token: 0x0600E4D7 RID: 58583 RVA: 0x0037F5E4 File Offset: 0x0037D7E4
			// (set) Token: 0x0600E4D8 RID: 58584 RVA: 0x0006BE39 File Offset: 0x0006A039
			public unsafe MultiTypeVisualsSetter ProductVisuals
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.PackagingVisuals.NativeFieldInfoPtr_ProductVisuals);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiTypeVisualsSetter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.PackagingVisuals.NativeFieldInfoPtr_ProductVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004592 RID: 17810
			// (get) Token: 0x0600E4D9 RID: 58585 RVA: 0x0037F614 File Offset: 0x0037D814
			// (set) Token: 0x0600E4DA RID: 58586 RVA: 0x0006BE58 File Offset: 0x0006A058
			public unsafe Transform TopLevelTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.PackagingVisuals.NativeFieldInfoPtr_TopLevelTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.PackagingVisuals.NativeFieldInfoPtr_TopLevelTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B5E RID: 39774
			private static readonly IntPtr NativeFieldInfoPtr_PackagingID;

			// Token: 0x04009B5F RID: 39775
			private static readonly IntPtr NativeFieldInfoPtr_ProductVisuals;

			// Token: 0x04009B60 RID: 39776
			private static readonly IntPtr NativeFieldInfoPtr_TopLevelTransform;

			// Token: 0x04009B61 RID: 39777
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AE4 RID: 2788
		[ObfuscatedName("ScheduleOne.DevUtilities.IconGenerator+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E4DB RID: 58587 RVA: 0x0037F644 File Offset: 0x0037D844
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IconGenerator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconGenerator.__c>.NativeClassPtr);
				IconGenerator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator.__c>.NativeClassPtr, "<>9");
				IconGenerator.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator.__c>.NativeClassPtr, "<>9__14_0");
				IconGenerator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator.__c>.NativeClassPtr, 100675053);
				IconGenerator.__c.NativeMethodInfoPtr__GetTexture_b__14_0_Internal_Boolean_ScriptableRendererFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator.__c>.NativeClassPtr, 100675054);
			}

			// Token: 0x0600E4DC RID: 58588 RVA: 0x0037F6C0 File Offset: 0x0037D8C0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconGenerator.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4DD RID: 58589 RVA: 0x0037F6FC File Offset: 0x0037D8FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194362, XrefRangeEnd = 194367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetTexture_b__14_0(ScriptableRendererFeature x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.__c.NativeMethodInfoPtr__GetTexture_b__14_0_Internal_Boolean_ScriptableRendererFeature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E4DE RID: 58590 RVA: 0x0006BE77 File Offset: 0x0006A077
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004593 RID: 17811
			// (get) Token: 0x0600E4DF RID: 58591 RVA: 0x0037F74C File Offset: 0x0037D94C
			// (set) Token: 0x0600E4E0 RID: 58592 RVA: 0x0006BE80 File Offset: 0x0006A080
			public unsafe static IconGenerator.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IconGenerator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IconGenerator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IconGenerator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004594 RID: 17812
			// (get) Token: 0x0600E4E1 RID: 58593 RVA: 0x0037F774 File Offset: 0x0037D974
			// (set) Token: 0x0600E4E2 RID: 58594 RVA: 0x0006BE92 File Offset: 0x0006A092
			public unsafe static Predicate<ScriptableRendererFeature> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IconGenerator.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ScriptableRendererFeature>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IconGenerator.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B62 RID: 39778
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009B63 RID: 39779
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04009B64 RID: 39780
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B65 RID: 39781
			private static readonly IntPtr NativeMethodInfoPtr__GetTexture_b__14_0_Internal_Boolean_ScriptableRendererFeature_0;
		}

		// Token: 0x02000AE5 RID: 2789
		[ObfuscatedName("ScheduleOne.DevUtilities.IconGenerator+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E4E3 RID: 58595 RVA: 0x0037F79C File Offset: 0x0037D99C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<IconGenerator.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconGenerator.__c__DisplayClass13_0>.NativeClassPtr);
				IconGenerator.__c__DisplayClass13_0.NativeFieldInfoPtr_packagingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator.__c__DisplayClass13_0>.NativeClassPtr, "packagingID");
				IconGenerator.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator.__c__DisplayClass13_0>.NativeClassPtr, 100675055);
				IconGenerator.__c__DisplayClass13_0.NativeMethodInfoPtr__GeneratePackagingIcon_b__0_Internal_Boolean_PackagingVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator.__c__DisplayClass13_0>.NativeClassPtr, 100675056);
			}

			// Token: 0x0600E4E4 RID: 58596 RVA: 0x0037F804 File Offset: 0x0037DA04
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconGenerator.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4E5 RID: 58597 RVA: 0x0037F840 File Offset: 0x0037DA40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194367, XrefRangeEnd = 194369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GeneratePackagingIcon_b__0(IconGenerator.PackagingVisuals x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.__c__DisplayClass13_0.NativeMethodInfoPtr__GeneratePackagingIcon_b__0_Internal_Boolean_PackagingVisuals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E4E6 RID: 58598 RVA: 0x0006BEA4 File Offset: 0x0006A0A4
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004595 RID: 17813
			// (get) Token: 0x0600E4E7 RID: 58599 RVA: 0x0037F890 File Offset: 0x0037DA90
			// (set) Token: 0x0600E4E8 RID: 58600 RVA: 0x0006BEAD File Offset: 0x0006A0AD
			public unsafe string packagingID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.__c__DisplayClass13_0.NativeFieldInfoPtr_packagingID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.__c__DisplayClass13_0.NativeFieldInfoPtr_packagingID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009B66 RID: 39782
			private static readonly IntPtr NativeFieldInfoPtr_packagingID;

			// Token: 0x04009B67 RID: 39783
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B68 RID: 39784
			private static readonly IntPtr NativeMethodInfoPtr__GeneratePackagingIcon_b__0_Internal_Boolean_PackagingVisuals_0;
		}
	}
}
