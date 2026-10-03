using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x02000493 RID: 1171
	public class Accessory : MonoBehaviour
	{
		// Token: 0x060069FD RID: 27133 RVA: 0x001EA8AC File Offset: 0x001E8AAC
		// Note: this type is marked as 'beforefieldinit'.
		static Accessory()
		{
			Il2CppClassPointerStore<Accessory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "Accessory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Accessory>.NativeClassPtr);
			Accessory.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "Name");
			Accessory.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "AssetPath");
			Accessory.NativeFieldInfoPtr_ReduceFootSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "ReduceFootSize");
			Accessory.NativeFieldInfoPtr_FootSizeReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "FootSizeReduction");
			Accessory.NativeFieldInfoPtr_ShouldBlockHair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "ShouldBlockHair");
			Accessory.NativeFieldInfoPtr_ColorAllMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "ColorAllMeshes");
			Accessory.NativeFieldInfoPtr_meshesToColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "meshesToColor");
			Accessory.NativeFieldInfoPtr_skinnedMeshesToColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "skinnedMeshesToColor");
			Accessory.NativeFieldInfoPtr_skinnedMeshesToBind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "skinnedMeshesToBind");
			Accessory.NativeFieldInfoPtr_shapeKeyMeshRends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Accessory>.NativeClassPtr, "shapeKeyMeshRends");
			Accessory.NativeMethodInfoPtr_ApplyColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Accessory>.NativeClassPtr, 100677192);
			Accessory.NativeMethodInfoPtr_ApplyShapeKeys_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Accessory>.NativeClassPtr, 100677193);
			Accessory.NativeMethodInfoPtr_BindBones_Public_Void_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Accessory>.NativeClassPtr, 100677194);
			Accessory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Accessory>.NativeClassPtr, 100677195);
		}

		// Token: 0x060069FE RID: 27134 RVA: 0x001EA9F4 File Offset: 0x001E8BF4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 218920, RefRangeEnd = 218925, XrefRangeStart = 218910, XrefRangeEnd = 218920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyColor(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Accessory.NativeMethodInfoPtr_ApplyColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069FF RID: 27135 RVA: 0x001EAA34 File Offset: 0x001E8C34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218930, RefRangeEnd = 218932, XrefRangeStart = 218925, XrefRangeEnd = 218930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyShapeKeys(float gender, float weight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gender;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Accessory.NativeMethodInfoPtr_ApplyShapeKeys_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A00 RID: 27136 RVA: 0x001EAA80 File Offset: 0x001E8C80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218934, RefRangeEnd = 218935, XrefRangeStart = 218932, XrefRangeEnd = 218934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BindBones(Il2CppReferenceArray<Transform> bones)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bones);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Accessory.NativeMethodInfoPtr_BindBones_Public_Void_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A01 RID: 27137 RVA: 0x001EAAC4 File Offset: 0x001E8CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218935, XrefRangeEnd = 218936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Accessory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Accessory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Accessory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A02 RID: 27138 RVA: 0x00031C30 File Offset: 0x0002FE30
		public Accessory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002062 RID: 8290
		// (get) Token: 0x06006A03 RID: 27139 RVA: 0x001EAB00 File Offset: 0x001E8D00
		// (set) Token: 0x06006A04 RID: 27140 RVA: 0x00031C39 File Offset: 0x0002FE39
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002063 RID: 8291
		// (get) Token: 0x06006A05 RID: 27141 RVA: 0x001EAB28 File Offset: 0x001E8D28
		// (set) Token: 0x06006A06 RID: 27142 RVA: 0x00031C58 File Offset: 0x0002FE58
		public unsafe string AssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_AssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002064 RID: 8292
		// (get) Token: 0x06006A07 RID: 27143 RVA: 0x001EAB50 File Offset: 0x001E8D50
		// (set) Token: 0x06006A08 RID: 27144 RVA: 0x00031C77 File Offset: 0x0002FE77
		public unsafe bool ReduceFootSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ReduceFootSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ReduceFootSize)) = value;
			}
		}

		// Token: 0x17002065 RID: 8293
		// (get) Token: 0x06006A09 RID: 27145 RVA: 0x001EAB78 File Offset: 0x001E8D78
		// (set) Token: 0x06006A0A RID: 27146 RVA: 0x00031C92 File Offset: 0x0002FE92
		public unsafe float FootSizeReduction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_FootSizeReduction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_FootSizeReduction)) = value;
			}
		}

		// Token: 0x17002066 RID: 8294
		// (get) Token: 0x06006A0B RID: 27147 RVA: 0x001EABA0 File Offset: 0x001E8DA0
		// (set) Token: 0x06006A0C RID: 27148 RVA: 0x00031CAD File Offset: 0x0002FEAD
		public unsafe bool ShouldBlockHair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ShouldBlockHair);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ShouldBlockHair)) = value;
			}
		}

		// Token: 0x17002067 RID: 8295
		// (get) Token: 0x06006A0D RID: 27149 RVA: 0x001EABC8 File Offset: 0x001E8DC8
		// (set) Token: 0x06006A0E RID: 27150 RVA: 0x00031CC8 File Offset: 0x0002FEC8
		public unsafe bool ColorAllMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ColorAllMeshes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_ColorAllMeshes)) = value;
			}
		}

		// Token: 0x17002068 RID: 8296
		// (get) Token: 0x06006A0F RID: 27151 RVA: 0x001EABF0 File Offset: 0x001E8DF0
		// (set) Token: 0x06006A10 RID: 27152 RVA: 0x00031CE3 File Offset: 0x0002FEE3
		public unsafe Il2CppReferenceArray<MeshRenderer> meshesToColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_meshesToColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_meshesToColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002069 RID: 8297
		// (get) Token: 0x06006A11 RID: 27153 RVA: 0x001EAC20 File Offset: 0x001E8E20
		// (set) Token: 0x06006A12 RID: 27154 RVA: 0x00031D02 File Offset: 0x0002FF02
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> skinnedMeshesToColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_skinnedMeshesToColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_skinnedMeshesToColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700206A RID: 8298
		// (get) Token: 0x06006A13 RID: 27155 RVA: 0x001EAC50 File Offset: 0x001E8E50
		// (set) Token: 0x06006A14 RID: 27156 RVA: 0x00031D21 File Offset: 0x0002FF21
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> skinnedMeshesToBind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_skinnedMeshesToBind);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_skinnedMeshesToBind), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700206B RID: 8299
		// (get) Token: 0x06006A15 RID: 27157 RVA: 0x001EAC80 File Offset: 0x001E8E80
		// (set) Token: 0x06006A16 RID: 27158 RVA: 0x00031D40 File Offset: 0x0002FF40
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> shapeKeyMeshRends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_shapeKeyMeshRends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Accessory.NativeFieldInfoPtr_shapeKeyMeshRends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040048F4 RID: 18676
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040048F5 RID: 18677
		private static readonly IntPtr NativeFieldInfoPtr_AssetPath;

		// Token: 0x040048F6 RID: 18678
		private static readonly IntPtr NativeFieldInfoPtr_ReduceFootSize;

		// Token: 0x040048F7 RID: 18679
		private static readonly IntPtr NativeFieldInfoPtr_FootSizeReduction;

		// Token: 0x040048F8 RID: 18680
		private static readonly IntPtr NativeFieldInfoPtr_ShouldBlockHair;

		// Token: 0x040048F9 RID: 18681
		private static readonly IntPtr NativeFieldInfoPtr_ColorAllMeshes;

		// Token: 0x040048FA RID: 18682
		private static readonly IntPtr NativeFieldInfoPtr_meshesToColor;

		// Token: 0x040048FB RID: 18683
		private static readonly IntPtr NativeFieldInfoPtr_skinnedMeshesToColor;

		// Token: 0x040048FC RID: 18684
		private static readonly IntPtr NativeFieldInfoPtr_skinnedMeshesToBind;

		// Token: 0x040048FD RID: 18685
		private static readonly IntPtr NativeFieldInfoPtr_shapeKeyMeshRends;

		// Token: 0x040048FE RID: 18686
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColor_Public_Void_Color_0;

		// Token: 0x040048FF RID: 18687
		private static readonly IntPtr NativeMethodInfoPtr_ApplyShapeKeys_Public_Void_Single_Single_0;

		// Token: 0x04004900 RID: 18688
		private static readonly IntPtr NativeMethodInfoPtr_BindBones_Public_Void_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04004901 RID: 18689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
