using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x02000496 RID: 1174
	[Serializable]
	public class AvatarLayer : ScriptableObject
	{
		// Token: 0x06006B1F RID: 27423 RVA: 0x001EE320 File Offset: 0x001EC520
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarLayer()
		{
			Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "AvatarLayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr);
			AvatarLayer.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "Name");
			AvatarLayer.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "AssetPath");
			AvatarLayer.NativeFieldInfoPtr_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "Texture");
			AvatarLayer.NativeFieldInfoPtr_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "Normal");
			AvatarLayer.NativeFieldInfoPtr_Normal_DefaultImportType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "Normal_DefaultImportType");
			AvatarLayer.NativeFieldInfoPtr_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "Order");
			AvatarLayer.NativeFieldInfoPtr_CombinedMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, "CombinedMaterial");
			AvatarLayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr, 100677318);
		}

		// Token: 0x06006B20 RID: 27424 RVA: 0x001EE3F0 File Offset: 0x001EC5F0
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 79617, RefRangeEnd = 79648, XrefRangeStart = 79617, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarLayer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarLayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarLayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B21 RID: 27425 RVA: 0x000326E1 File Offset: 0x000308E1
		public AvatarLayer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020C8 RID: 8392
		// (get) Token: 0x06006B22 RID: 27426 RVA: 0x001EE42C File Offset: 0x001EC62C
		// (set) Token: 0x06006B23 RID: 27427 RVA: 0x000326EA File Offset: 0x000308EA
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170020C9 RID: 8393
		// (get) Token: 0x06006B24 RID: 27428 RVA: 0x001EE454 File Offset: 0x001EC654
		// (set) Token: 0x06006B25 RID: 27429 RVA: 0x00032709 File Offset: 0x00030909
		public unsafe string AssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_AssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170020CA RID: 8394
		// (get) Token: 0x06006B26 RID: 27430 RVA: 0x001EE47C File Offset: 0x001EC67C
		// (set) Token: 0x06006B27 RID: 27431 RVA: 0x00032728 File Offset: 0x00030928
		public unsafe Texture2D Texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020CB RID: 8395
		// (get) Token: 0x06006B28 RID: 27432 RVA: 0x001EE4AC File Offset: 0x001EC6AC
		// (set) Token: 0x06006B29 RID: 27433 RVA: 0x00032747 File Offset: 0x00030947
		public unsafe Texture2D Normal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Normal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Normal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020CC RID: 8396
		// (get) Token: 0x06006B2A RID: 27434 RVA: 0x001EE4DC File Offset: 0x001EC6DC
		// (set) Token: 0x06006B2B RID: 27435 RVA: 0x00032766 File Offset: 0x00030966
		public unsafe Texture2D Normal_DefaultImportType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Normal_DefaultImportType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Normal_DefaultImportType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020CD RID: 8397
		// (get) Token: 0x06006B2C RID: 27436 RVA: 0x001EE50C File Offset: 0x001EC70C
		// (set) Token: 0x06006B2D RID: 27437 RVA: 0x00032785 File Offset: 0x00030985
		public unsafe int Order
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Order);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_Order)) = value;
			}
		}

		// Token: 0x170020CE RID: 8398
		// (get) Token: 0x06006B2E RID: 27438 RVA: 0x001EE534 File Offset: 0x001EC734
		// (set) Token: 0x06006B2F RID: 27439 RVA: 0x000327A0 File Offset: 0x000309A0
		public unsafe Material CombinedMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_CombinedMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarLayer.NativeFieldInfoPtr_CombinedMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040049B3 RID: 18867
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040049B4 RID: 18868
		private static readonly IntPtr NativeFieldInfoPtr_AssetPath;

		// Token: 0x040049B5 RID: 18869
		private static readonly IntPtr NativeFieldInfoPtr_Texture;

		// Token: 0x040049B6 RID: 18870
		private static readonly IntPtr NativeFieldInfoPtr_Normal;

		// Token: 0x040049B7 RID: 18871
		private static readonly IntPtr NativeFieldInfoPtr_Normal_DefaultImportType;

		// Token: 0x040049B8 RID: 18872
		private static readonly IntPtr NativeFieldInfoPtr_Order;

		// Token: 0x040049B9 RID: 18873
		private static readonly IntPtr NativeFieldInfoPtr_CombinedMaterial;

		// Token: 0x040049BA RID: 18874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
