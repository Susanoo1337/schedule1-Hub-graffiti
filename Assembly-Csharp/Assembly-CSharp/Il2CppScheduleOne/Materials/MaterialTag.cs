using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Core;
using UnityEngine;

namespace Il2CppScheduleOne.Materials
{
	// Token: 0x020002A9 RID: 681
	public class MaterialTag : MonoBehaviour
	{
		// Token: 0x06003445 RID: 13381 RVA: 0x00129138 File Offset: 0x00127338
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialTag()
		{
			Il2CppClassPointerStore<MaterialTag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Materials", "MaterialTag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialTag>.NativeClassPtr);
			MaterialTag.NativeFieldInfoPtr_MaterialType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialTag>.NativeClassPtr, "MaterialType");
			MaterialTag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialTag>.NativeClassPtr, 100669912);
		}

		// Token: 0x06003446 RID: 13382 RVA: 0x00129190 File Offset: 0x00127390
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialTag() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialTag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialTag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x0001AAA1 File Offset: 0x00018CA1
		public MaterialTag(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x06003448 RID: 13384 RVA: 0x001291CC File Offset: 0x001273CC
		// (set) Token: 0x06003449 RID: 13385 RVA: 0x0001AAAA File Offset: 0x00018CAA
		public unsafe EMaterialType MaterialType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialTag.NativeFieldInfoPtr_MaterialType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialTag.NativeFieldInfoPtr_MaterialType)) = value;
			}
		}

		// Token: 0x040022F7 RID: 8951
		private static readonly IntPtr NativeFieldInfoPtr_MaterialType;

		// Token: 0x040022F8 RID: 8952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
