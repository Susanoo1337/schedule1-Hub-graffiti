using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2CppVLB
{
	// Token: 0x02000061 RID: 97
	public static class MaterialManager : Il2CppSystem.Object
	{
		// Token: 0x0600063E RID: 1598 RVA: 0x0008EA58 File Offset: 0x0008CC58
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialManager()
		{
			Il2CppClassPointerStore<MaterialManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "MaterialManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr);
			MaterialManager.NativeFieldInfoPtr_materialPropertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "materialPropertyBlock");
			MaterialManager.NativeFieldInfoPtr_BlendingMode_SrcFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "BlendingMode_SrcFactor");
			MaterialManager.NativeFieldInfoPtr_BlendingMode_DstFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "BlendingMode_DstFactor");
			MaterialManager.NativeFieldInfoPtr_BlendingMode_AlphaAsBlack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "BlendingMode_AlphaAsBlack");
			MaterialManager.NativeFieldInfoPtr_ms_MaterialsGroupSD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "ms_MaterialsGroupSD");
			MaterialManager.NativeFieldInfoPtr_ms_MaterialsGroupHD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "ms_MaterialsGroupHD");
			MaterialManager.NativeMethodInfoPtr_NewMaterialPersistent_Public_Static_Material_Shader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664005);
			MaterialManager.NativeMethodInfoPtr_GetInstancedMaterial_Public_Static_Material_UInt32_byref_StaticPropertiesSD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664006);
			MaterialManager.NativeMethodInfoPtr_GetInstancedMaterial_Public_Static_Material_UInt32_byref_StaticPropertiesHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664007);
			MaterialManager.NativeMethodInfoPtr_GetInstancedMaterial_Private_Static_Material_Hashtable_UInt32_byref_IStaticProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664008);
			MaterialManager.NativeMethodInfoPtr_SetBlendingMode_Private_Static_Void_Material_Int32_BlendMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664009);
			MaterialManager.NativeMethodInfoPtr_SetStencilRef_Private_Static_Void_Material_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664010);
			MaterialManager.NativeMethodInfoPtr_SetStencilComp_Private_Static_Void_Material_Int32_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664011);
			MaterialManager.NativeMethodInfoPtr_SetStencilOp_Private_Static_Void_Material_Int32_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664012);
			MaterialManager.NativeMethodInfoPtr_SetCull_Private_Static_Void_Material_Int32_CullMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664013);
			MaterialManager.NativeMethodInfoPtr_SetZWrite_Private_Static_Void_Material_Int32_ZWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664014);
			MaterialManager.NativeMethodInfoPtr_SetZTest_Private_Static_Void_Material_Int32_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100664015);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0008EBDC File Offset: 0x0008CDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71044, XrefRangeEnd = 71055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gpuInstanced;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_NewMaterialPersistent_Public_Static_Material_Shader_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0008EC30 File Offset: 0x0008CE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71055, XrefRangeEnd = 71063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetInstancedMaterial(uint groupID, ref MaterialManager.StaticPropertiesSD staticProps)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref groupID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &staticProps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_GetInstancedMaterial_Public_Static_Material_UInt32_byref_StaticPropertiesSD_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0008EC80 File Offset: 0x0008CE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71063, XrefRangeEnd = 71071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetInstancedMaterial(uint groupID, ref MaterialManager.StaticPropertiesHD staticProps)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref groupID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &staticProps;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_GetInstancedMaterial_Public_Static_Material_UInt32_byref_StaticPropertiesHD_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0008ECD0 File Offset: 0x0008CED0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 71106, RefRangeEnd = 71110, XrefRangeStart = 71071, XrefRangeEnd = 71106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetInstancedMaterial(Hashtable groups, uint groupID, ref MaterialManager.IStaticProperties staticProps)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(groups);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref groupID;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(staticProps);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_GetInstancedMaterial_Private_Static_Material_Hashtable_UInt32_byref_IStaticProperties_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			staticProps = ((intPtr4 == 0) ? null : new MaterialManager.IStaticProperties(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Material>(intPtr5) : null;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0008ED4C File Offset: 0x0008CF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71110, XrefRangeEnd = 71158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetBlendingMode(this Material mat, int nameID, BlendMode value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_SetBlendingMode_Private_Static_Void_Material_Int32_BlendMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0008EDA0 File Offset: 0x0008CFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetStencilRef(this Material mat, int nameID, int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_SetStencilRef_Private_Static_Void_Material_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0008EDF4 File Offset: 0x0008CFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetStencilComp(this Material mat, int nameID, CompareFunction value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_SetStencilComp_Private_Static_Void_Material_Int32_CompareFunction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0008EE48 File Offset: 0x0008D048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetStencilOp(this Material mat, int nameID, StencilOp value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_SetStencilOp_Private_Static_Void_Material_Int32_StencilOp_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0008EE9C File Offset: 0x0008D09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCull(this Material mat, int nameID, CullMode value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_SetCull_Private_Static_Void_Material_Int32_CullMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0008EEF0 File Offset: 0x0008D0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetZWrite(this Material mat, int nameID, MaterialManager.ZWrite value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_SetZWrite_Private_Static_Void_Material_Int32_ZWrite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0008EF44 File Offset: 0x0008D144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetZTest(this Material mat, int nameID, CompareFunction value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_SetZTest_Private_Static_Void_Material_Int32_CompareFunction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00005307 File Offset: 0x00003507
		public MaterialManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x0008EF98 File Offset: 0x0008D198
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x00005310 File Offset: 0x00003510
		public unsafe static MaterialPropertyBlock materialPropertyBlock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_materialPropertyBlock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_materialPropertyBlock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x0008EFC0 File Offset: 0x0008D1C0
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x00005322 File Offset: 0x00003522
		public unsafe static Il2CppStructArray<BlendMode> BlendingMode_SrcFactor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_SrcFactor, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<BlendMode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_SrcFactor, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x0008EFE8 File Offset: 0x0008D1E8
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x00005334 File Offset: 0x00003534
		public unsafe static Il2CppStructArray<BlendMode> BlendingMode_DstFactor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_DstFactor, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<BlendMode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_DstFactor, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x0008F010 File Offset: 0x0008D210
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x00005346 File Offset: 0x00003546
		public unsafe static Il2CppStructArray<bool> BlendingMode_AlphaAsBlack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_AlphaAsBlack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_AlphaAsBlack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x0008F038 File Offset: 0x0008D238
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x00005358 File Offset: 0x00003558
		public unsafe static Hashtable ms_MaterialsGroupSD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_ms_MaterialsGroupSD, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_ms_MaterialsGroupSD, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x0008F060 File Offset: 0x0008D260
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x0000536A File Offset: 0x0000356A
		public unsafe static Hashtable ms_MaterialsGroupHD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_ms_MaterialsGroupHD, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_ms_MaterialsGroupHD, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeFieldInfoPtr_materialPropertyBlock;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeFieldInfoPtr_BlendingMode_SrcFactor;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeFieldInfoPtr_BlendingMode_DstFactor;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeFieldInfoPtr_BlendingMode_AlphaAsBlack;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeFieldInfoPtr_ms_MaterialsGroupSD;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeFieldInfoPtr_ms_MaterialsGroupHD;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_NewMaterialPersistent_Public_Static_Material_Shader_Boolean_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_GetInstancedMaterial_Public_Static_Material_UInt32_byref_StaticPropertiesSD_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_GetInstancedMaterial_Public_Static_Material_UInt32_byref_StaticPropertiesHD_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_GetInstancedMaterial_Private_Static_Material_Hashtable_UInt32_byref_IStaticProperties_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_SetBlendingMode_Private_Static_Void_Material_Int32_BlendMode_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_SetStencilRef_Private_Static_Void_Material_Int32_Int32_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_SetStencilComp_Private_Static_Void_Material_Int32_CompareFunction_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr_SetStencilOp_Private_Static_Void_Material_Int32_StencilOp_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_SetCull_Private_Static_Void_Material_Int32_CullMode_0;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr_SetZWrite_Private_Static_Void_Material_Int32_ZWrite_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr_SetZTest_Private_Static_Void_Material_Int32_CompareFunction_0;

		// Token: 0x02000877 RID: 2167
		[OriginalName("Assembly-CSharp.dll", "", "BlendingMode")]
		public enum BlendingMode
		{
			// Token: 0x04008EDD RID: 36573
			Additive,
			// Token: 0x04008EDE RID: 36574
			SoftAdditive,
			// Token: 0x04008EDF RID: 36575
			TraditionalTransparency,
			// Token: 0x04008EE0 RID: 36576
			Count
		}

		// Token: 0x02000878 RID: 2168
		[OriginalName("Assembly-CSharp.dll", "", "ColorGradient")]
		public enum ColorGradient
		{
			// Token: 0x04008EE2 RID: 36578
			Off,
			// Token: 0x04008EE3 RID: 36579
			MatrixLow,
			// Token: 0x04008EE4 RID: 36580
			MatrixHigh,
			// Token: 0x04008EE5 RID: 36581
			Count
		}

		// Token: 0x02000879 RID: 2169
		[OriginalName("Assembly-CSharp.dll", "", "Noise3D")]
		public enum Noise3D
		{
			// Token: 0x04008EE7 RID: 36583
			Off,
			// Token: 0x04008EE8 RID: 36584
			On,
			// Token: 0x04008EE9 RID: 36585
			Count
		}

		// Token: 0x0200087A RID: 2170
		public static class SD : Il2CppSystem.Object
		{
			// Token: 0x0600D1EF RID: 53743 RVA: 0x000635EF File Offset: 0x000617EF
			// Note: this type is marked as 'beforefieldinit'.
			static SD()
			{
				Il2CppClassPointerStore<MaterialManager.SD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "SD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialManager.SD>.NativeClassPtr);
			}

			// Token: 0x0600D1F0 RID: 53744 RVA: 0x0006360F File Offset: 0x0006180F
			public SD(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x02000DA4 RID: 3492
			[OriginalName("Assembly-CSharp.dll", "", "DepthBlend")]
			public enum DepthBlend
			{
				// Token: 0x0400AA86 RID: 43654
				Off,
				// Token: 0x0400AA87 RID: 43655
				On,
				// Token: 0x0400AA88 RID: 43656
				Count
			}

			// Token: 0x02000DA5 RID: 3493
			[OriginalName("Assembly-CSharp.dll", "", "DynamicOcclusion")]
			public enum DynamicOcclusion
			{
				// Token: 0x0400AA8A RID: 43658
				Off,
				// Token: 0x0400AA8B RID: 43659
				ClippingPlane,
				// Token: 0x0400AA8C RID: 43660
				DepthTexture,
				// Token: 0x0400AA8D RID: 43661
				Count
			}

			// Token: 0x02000DA6 RID: 3494
			[OriginalName("Assembly-CSharp.dll", "", "MeshSkewing")]
			public enum MeshSkewing
			{
				// Token: 0x0400AA8F RID: 43663
				Off,
				// Token: 0x0400AA90 RID: 43664
				On,
				// Token: 0x0400AA91 RID: 43665
				Count
			}

			// Token: 0x02000DA7 RID: 3495
			[OriginalName("Assembly-CSharp.dll", "", "ShaderAccuracy")]
			public enum ShaderAccuracy
			{
				// Token: 0x0400AA93 RID: 43667
				Fast,
				// Token: 0x0400AA94 RID: 43668
				High,
				// Token: 0x0400AA95 RID: 43669
				Count
			}
		}

		// Token: 0x0200087B RID: 2171
		public static class HD : Il2CppSystem.Object
		{
			// Token: 0x0600D1F1 RID: 53745 RVA: 0x00063618 File Offset: 0x00061818
			// Note: this type is marked as 'beforefieldinit'.
			static HD()
			{
				Il2CppClassPointerStore<MaterialManager.HD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "HD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialManager.HD>.NativeClassPtr);
			}

			// Token: 0x0600D1F2 RID: 53746 RVA: 0x00063638 File Offset: 0x00061838
			public HD(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x02000DA8 RID: 3496
			[OriginalName("Assembly-CSharp.dll", "", "Attenuation")]
			public enum Attenuation
			{
				// Token: 0x0400AA97 RID: 43671
				Linear,
				// Token: 0x0400AA98 RID: 43672
				Quadratic,
				// Token: 0x0400AA99 RID: 43673
				Count
			}

			// Token: 0x02000DA9 RID: 3497
			[OriginalName("Assembly-CSharp.dll", "", "Shadow")]
			public enum Shadow
			{
				// Token: 0x0400AA9B RID: 43675
				Off,
				// Token: 0x0400AA9C RID: 43676
				On,
				// Token: 0x0400AA9D RID: 43677
				Count
			}

			// Token: 0x02000DAA RID: 3498
			[OriginalName("Assembly-CSharp.dll", "", "Cookie")]
			public enum Cookie
			{
				// Token: 0x0400AA9F RID: 43679
				Off,
				// Token: 0x0400AAA0 RID: 43680
				SingleChannel,
				// Token: 0x0400AAA1 RID: 43681
				RGBA,
				// Token: 0x0400AAA2 RID: 43682
				Count
			}
		}

		// Token: 0x0200087C RID: 2172
		public class IStaticProperties : Il2CppObjectBase
		{
			// Token: 0x0600D1F3 RID: 53747 RVA: 0x0034819C File Offset: 0x0034639C
			// Note: this type is marked as 'beforefieldinit'.
			static IStaticProperties()
			{
				Il2CppClassPointerStore<MaterialManager.IStaticProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "IStaticProperties");
				MaterialManager.IStaticProperties.NativeMethodInfoPtr_GetPropertiesCount_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.IStaticProperties>.NativeClassPtr, 100664017);
				MaterialManager.IStaticProperties.NativeMethodInfoPtr_GetMaterialID_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.IStaticProperties>.NativeClassPtr, 100664018);
				MaterialManager.IStaticProperties.NativeMethodInfoPtr_ApplyToMaterial_Public_Abstract_Virtual_New_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.IStaticProperties>.NativeClassPtr, 100664019);
				MaterialManager.IStaticProperties.NativeMethodInfoPtr_GetShaderMode_Public_Abstract_Virtual_New_ShaderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.IStaticProperties>.NativeClassPtr, 100664020);
			}

			// Token: 0x0600D1F4 RID: 53748 RVA: 0x00348210 File Offset: 0x00346410
			[CallerCount(0)]
			public unsafe virtual int GetPropertiesCount()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialManager.IStaticProperties.NativeMethodInfoPtr_GetPropertiesCount_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D1F5 RID: 53749 RVA: 0x00348258 File Offset: 0x00346458
			[CallerCount(0)]
			public unsafe virtual int GetMaterialID()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialManager.IStaticProperties.NativeMethodInfoPtr_GetMaterialID_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D1F6 RID: 53750 RVA: 0x003482A0 File Offset: 0x003464A0
			[CallerCount(0)]
			public unsafe virtual void ApplyToMaterial(Material mat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialManager.IStaticProperties.NativeMethodInfoPtr_ApplyToMaterial_Public_Abstract_Virtual_New_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1F7 RID: 53751 RVA: 0x003482F0 File Offset: 0x003464F0
			[CallerCount(0)]
			public unsafe virtual ShaderMode GetShaderMode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialManager.IStaticProperties.NativeMethodInfoPtr_GetShaderMode_Public_Abstract_Virtual_New_ShaderMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D1F8 RID: 53752 RVA: 0x00063641 File Offset: 0x00061841
			public IStaticProperties(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04008EEA RID: 36586
			private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesCount_Public_Abstract_Virtual_New_Int32_0;

			// Token: 0x04008EEB RID: 36587
			private static readonly IntPtr NativeMethodInfoPtr_GetMaterialID_Public_Abstract_Virtual_New_Int32_0;

			// Token: 0x04008EEC RID: 36588
			private static readonly IntPtr NativeMethodInfoPtr_ApplyToMaterial_Public_Abstract_Virtual_New_Void_Material_0;

			// Token: 0x04008EED RID: 36589
			private static readonly IntPtr NativeMethodInfoPtr_GetShaderMode_Public_Abstract_Virtual_New_ShaderMode_0;
		}

		// Token: 0x0200087D RID: 2173
		[StructLayout(2)]
		public struct StaticPropertiesSD
		{
			// Token: 0x0600D1F9 RID: 53753 RVA: 0x00348338 File Offset: 0x00346538
			// Note: this type is marked as 'beforefieldinit'.
			static StaticPropertiesSD()
			{
				Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "StaticPropertiesSD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr);
				MaterialManager.StaticPropertiesSD.NativeFieldInfoPtr_blendingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, "blendingMode");
				MaterialManager.StaticPropertiesSD.NativeFieldInfoPtr_noise3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, "noise3D");
				MaterialManager.StaticPropertiesSD.NativeFieldInfoPtr_depthBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, "depthBlend");
				MaterialManager.StaticPropertiesSD.NativeFieldInfoPtr_colorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, "colorGradient");
				MaterialManager.StaticPropertiesSD.NativeFieldInfoPtr_dynamicOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, "dynamicOcclusion");
				MaterialManager.StaticPropertiesSD.NativeFieldInfoPtr_meshSkewing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, "meshSkewing");
				MaterialManager.StaticPropertiesSD.NativeFieldInfoPtr_shaderAccuracy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, "shaderAccuracy");
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_GetShaderMode_Public_Virtual_Final_New_ShaderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664021);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_staticPropertiesCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664022);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_GetPropertiesCount_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664023);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_blendingModeID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664024);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_noise3DID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664025);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_depthBlendID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664026);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_colorGradientID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664027);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_dynamicOcclusionID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664028);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_meshSkewingID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664029);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_shaderAccuracyID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664030);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_GetMaterialID_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664031);
				MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_ApplyToMaterial_Public_Virtual_Final_New_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, 100664032);
			}

			// Token: 0x0600D1FA RID: 53754 RVA: 0x003484E0 File Offset: 0x003466E0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ShaderMode GetShaderMode()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_GetShaderMode_Public_Virtual_Final_New_ShaderMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003FCA RID: 16330
			// (get) Token: 0x0600D1FB RID: 53755 RVA: 0x00348510 File Offset: 0x00346710
			public unsafe static int staticPropertiesCount
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_staticPropertiesCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600D1FC RID: 53756 RVA: 0x00348540 File Offset: 0x00346740
			[CallerCount(0)]
			public unsafe int GetPropertiesCount()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_GetPropertiesCount_Public_Virtual_Final_New_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003FCB RID: 16331
			// (get) Token: 0x0600D1FD RID: 53757 RVA: 0x00348570 File Offset: 0x00346770
			public unsafe int blendingModeID
			{
				[CallerCount(501)]
				[CachedScanResults(RefRangeStart = 40619, RefRangeEnd = 41120, XrefRangeStart = 40619, XrefRangeEnd = 41120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_blendingModeID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003FCC RID: 16332
			// (get) Token: 0x0600D1FE RID: 53758 RVA: 0x003485A0 File Offset: 0x003467A0
			public unsafe int noise3DID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70909, XrefRangeEnd = 70910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_noise3DID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003FCD RID: 16333
			// (get) Token: 0x0600D1FF RID: 53759 RVA: 0x003485D0 File Offset: 0x003467D0
			public unsafe int depthBlendID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70910, XrefRangeEnd = 70911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_depthBlendID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003FCE RID: 16334
			// (get) Token: 0x0600D200 RID: 53760 RVA: 0x00348600 File Offset: 0x00346800
			public unsafe int colorGradientID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70911, XrefRangeEnd = 70912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_colorGradientID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003FCF RID: 16335
			// (get) Token: 0x0600D201 RID: 53761 RVA: 0x00348630 File Offset: 0x00346830
			public unsafe int dynamicOcclusionID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70912, XrefRangeEnd = 70913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_dynamicOcclusionID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003FD0 RID: 16336
			// (get) Token: 0x0600D202 RID: 53762 RVA: 0x00348660 File Offset: 0x00346860
			public unsafe int meshSkewingID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70913, XrefRangeEnd = 70914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_meshSkewingID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003FD1 RID: 16337
			// (get) Token: 0x0600D203 RID: 53763 RVA: 0x00348690 File Offset: 0x00346890
			public unsafe int shaderAccuracyID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70914, XrefRangeEnd = 70915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_get_shaderAccuracyID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600D204 RID: 53764 RVA: 0x003486C0 File Offset: 0x003468C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70915, XrefRangeEnd = 70927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetMaterialID()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_GetMaterialID_Public_Virtual_Final_New_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D205 RID: 53765 RVA: 0x003486F0 File Offset: 0x003468F0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70971, RefRangeEnd = 70972, XrefRangeStart = 70927, XrefRangeEnd = 70971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ApplyToMaterial(Material mat)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesSD.NativeMethodInfoPtr_ApplyToMaterial_Public_Virtual_Final_New_Void_Material_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D206 RID: 53766 RVA: 0x0006364A File Offset: 0x0006184A
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialManager.StaticPropertiesSD>.NativeClassPtr, ref this));
			}

			// Token: 0x04008EEE RID: 36590
			private static readonly IntPtr NativeFieldInfoPtr_blendingMode;

			// Token: 0x04008EEF RID: 36591
			private static readonly IntPtr NativeFieldInfoPtr_noise3D;

			// Token: 0x04008EF0 RID: 36592
			private static readonly IntPtr NativeFieldInfoPtr_depthBlend;

			// Token: 0x04008EF1 RID: 36593
			private static readonly IntPtr NativeFieldInfoPtr_colorGradient;

			// Token: 0x04008EF2 RID: 36594
			private static readonly IntPtr NativeFieldInfoPtr_dynamicOcclusion;

			// Token: 0x04008EF3 RID: 36595
			private static readonly IntPtr NativeFieldInfoPtr_meshSkewing;

			// Token: 0x04008EF4 RID: 36596
			private static readonly IntPtr NativeFieldInfoPtr_shaderAccuracy;

			// Token: 0x04008EF5 RID: 36597
			private static readonly IntPtr NativeMethodInfoPtr_GetShaderMode_Public_Virtual_Final_New_ShaderMode_0;

			// Token: 0x04008EF6 RID: 36598
			private static readonly IntPtr NativeMethodInfoPtr_get_staticPropertiesCount_Public_Static_get_Int32_0;

			// Token: 0x04008EF7 RID: 36599
			private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesCount_Public_Virtual_Final_New_Int32_0;

			// Token: 0x04008EF8 RID: 36600
			private static readonly IntPtr NativeMethodInfoPtr_get_blendingModeID_Private_get_Int32_0;

			// Token: 0x04008EF9 RID: 36601
			private static readonly IntPtr NativeMethodInfoPtr_get_noise3DID_Private_get_Int32_0;

			// Token: 0x04008EFA RID: 36602
			private static readonly IntPtr NativeMethodInfoPtr_get_depthBlendID_Private_get_Int32_0;

			// Token: 0x04008EFB RID: 36603
			private static readonly IntPtr NativeMethodInfoPtr_get_colorGradientID_Private_get_Int32_0;

			// Token: 0x04008EFC RID: 36604
			private static readonly IntPtr NativeMethodInfoPtr_get_dynamicOcclusionID_Private_get_Int32_0;

			// Token: 0x04008EFD RID: 36605
			private static readonly IntPtr NativeMethodInfoPtr_get_meshSkewingID_Private_get_Int32_0;

			// Token: 0x04008EFE RID: 36606
			private static readonly IntPtr NativeMethodInfoPtr_get_shaderAccuracyID_Private_get_Int32_0;

			// Token: 0x04008EFF RID: 36607
			private static readonly IntPtr NativeMethodInfoPtr_GetMaterialID_Public_Virtual_Final_New_Int32_0;

			// Token: 0x04008F00 RID: 36608
			private static readonly IntPtr NativeMethodInfoPtr_ApplyToMaterial_Public_Virtual_Final_New_Void_Material_0;

			// Token: 0x04008F01 RID: 36609
			[FieldOffset(0)]
			public MaterialManager.BlendingMode blendingMode;

			// Token: 0x04008F02 RID: 36610
			[FieldOffset(4)]
			public MaterialManager.Noise3D noise3D;

			// Token: 0x04008F03 RID: 36611
			[FieldOffset(8)]
			public MaterialManager.SD.DepthBlend depthBlend;

			// Token: 0x04008F04 RID: 36612
			[FieldOffset(12)]
			public MaterialManager.ColorGradient colorGradient;

			// Token: 0x04008F05 RID: 36613
			[FieldOffset(16)]
			public MaterialManager.SD.DynamicOcclusion dynamicOcclusion;

			// Token: 0x04008F06 RID: 36614
			[FieldOffset(20)]
			public MaterialManager.SD.MeshSkewing meshSkewing;

			// Token: 0x04008F07 RID: 36615
			[FieldOffset(24)]
			public MaterialManager.SD.ShaderAccuracy shaderAccuracy;
		}

		// Token: 0x0200087E RID: 2174
		[StructLayout(2)]
		public struct StaticPropertiesHD
		{
			// Token: 0x0600D207 RID: 53767 RVA: 0x00348728 File Offset: 0x00346928
			// Note: this type is marked as 'beforefieldinit'.
			static StaticPropertiesHD()
			{
				Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "StaticPropertiesHD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr);
				MaterialManager.StaticPropertiesHD.NativeFieldInfoPtr_blendingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, "blendingMode");
				MaterialManager.StaticPropertiesHD.NativeFieldInfoPtr_attenuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, "attenuation");
				MaterialManager.StaticPropertiesHD.NativeFieldInfoPtr_noise3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, "noise3D");
				MaterialManager.StaticPropertiesHD.NativeFieldInfoPtr_colorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, "colorGradient");
				MaterialManager.StaticPropertiesHD.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, "shadow");
				MaterialManager.StaticPropertiesHD.NativeFieldInfoPtr_cookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, "cookie");
				MaterialManager.StaticPropertiesHD.NativeFieldInfoPtr_raymarchingQualityIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, "raymarchingQualityIndex");
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_GetShaderMode_Public_Virtual_Final_New_ShaderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664033);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_staticPropertiesCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664034);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_GetPropertiesCount_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664035);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_blendingModeID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664036);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_attenuationID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664037);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_noise3DID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664038);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_colorGradientID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664039);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_dynamicOcclusionID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664040);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_cookieID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664041);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_raymarchingQualityID_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664042);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_GetMaterialID_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664043);
				MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_ApplyToMaterial_Public_Virtual_Final_New_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, 100664044);
			}

			// Token: 0x0600D208 RID: 53768 RVA: 0x003488D0 File Offset: 0x00346AD0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 70633, RefRangeEnd = 70636, XrefRangeStart = 70633, XrefRangeEnd = 70636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ShaderMode GetShaderMode()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_GetShaderMode_Public_Virtual_Final_New_ShaderMode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003FD2 RID: 16338
			// (get) Token: 0x0600D209 RID: 53769 RVA: 0x00348900 File Offset: 0x00346B00
			public unsafe static int staticPropertiesCount
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70972, XrefRangeEnd = 70973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_staticPropertiesCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600D20A RID: 53770 RVA: 0x00348930 File Offset: 0x00346B30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetPropertiesCount()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_GetPropertiesCount_Public_Virtual_Final_New_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003FD3 RID: 16339
			// (get) Token: 0x0600D20B RID: 53771 RVA: 0x00348960 File Offset: 0x00346B60
			public unsafe int blendingModeID
			{
				[CallerCount(501)]
				[CachedScanResults(RefRangeStart = 40619, RefRangeEnd = 41120, XrefRangeStart = 40619, XrefRangeEnd = 41120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_blendingModeID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003FD4 RID: 16340
			// (get) Token: 0x0600D20C RID: 53772 RVA: 0x00348990 File Offset: 0x00346B90
			public unsafe int attenuationID
			{
				[CallerCount(120)]
				[CachedScanResults(RefRangeStart = 54296, RefRangeEnd = 54416, XrefRangeStart = 54296, XrefRangeEnd = 54416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_attenuationID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003FD5 RID: 16341
			// (get) Token: 0x0600D20D RID: 53773 RVA: 0x003489C0 File Offset: 0x00346BC0
			public unsafe int noise3DID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70973, XrefRangeEnd = 70974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_noise3DID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003FD6 RID: 16342
			// (get) Token: 0x0600D20E RID: 53774 RVA: 0x003489F0 File Offset: 0x00346BF0
			public unsafe int colorGradientID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_colorGradientID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003FD7 RID: 16343
			// (get) Token: 0x0600D20F RID: 53775 RVA: 0x00348A20 File Offset: 0x00346C20
			public unsafe int dynamicOcclusionID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70974, XrefRangeEnd = 70975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_dynamicOcclusionID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003FD8 RID: 16344
			// (get) Token: 0x0600D210 RID: 53776 RVA: 0x00348A50 File Offset: 0x00346C50
			public unsafe int cookieID
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70975, XrefRangeEnd = 70976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_cookieID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003FD9 RID: 16345
			// (get) Token: 0x0600D211 RID: 53777 RVA: 0x00348A80 File Offset: 0x00346C80
			public unsafe int raymarchingQualityID
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 3891, RefRangeEnd = 3894, XrefRangeStart = 3891, XrefRangeEnd = 3894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_get_raymarchingQualityID_Private_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600D212 RID: 53778 RVA: 0x00348AB0 File Offset: 0x00346CB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70976, XrefRangeEnd = 70986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetMaterialID()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_GetMaterialID_Public_Virtual_Final_New_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D213 RID: 53779 RVA: 0x00348AE0 File Offset: 0x00346CE0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71038, RefRangeEnd = 71039, XrefRangeStart = 70986, XrefRangeEnd = 71038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ApplyToMaterial(Material mat)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticPropertiesHD.NativeMethodInfoPtr_ApplyToMaterial_Public_Virtual_Final_New_Void_Material_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D214 RID: 53780 RVA: 0x0006365C File Offset: 0x0006185C
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialManager.StaticPropertiesHD>.NativeClassPtr, ref this));
			}

			// Token: 0x04008F08 RID: 36616
			private static readonly IntPtr NativeFieldInfoPtr_blendingMode;

			// Token: 0x04008F09 RID: 36617
			private static readonly IntPtr NativeFieldInfoPtr_attenuation;

			// Token: 0x04008F0A RID: 36618
			private static readonly IntPtr NativeFieldInfoPtr_noise3D;

			// Token: 0x04008F0B RID: 36619
			private static readonly IntPtr NativeFieldInfoPtr_colorGradient;

			// Token: 0x04008F0C RID: 36620
			private static readonly IntPtr NativeFieldInfoPtr_shadow;

			// Token: 0x04008F0D RID: 36621
			private static readonly IntPtr NativeFieldInfoPtr_cookie;

			// Token: 0x04008F0E RID: 36622
			private static readonly IntPtr NativeFieldInfoPtr_raymarchingQualityIndex;

			// Token: 0x04008F0F RID: 36623
			private static readonly IntPtr NativeMethodInfoPtr_GetShaderMode_Public_Virtual_Final_New_ShaderMode_0;

			// Token: 0x04008F10 RID: 36624
			private static readonly IntPtr NativeMethodInfoPtr_get_staticPropertiesCount_Public_Static_get_Int32_0;

			// Token: 0x04008F11 RID: 36625
			private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesCount_Public_Virtual_Final_New_Int32_0;

			// Token: 0x04008F12 RID: 36626
			private static readonly IntPtr NativeMethodInfoPtr_get_blendingModeID_Private_get_Int32_0;

			// Token: 0x04008F13 RID: 36627
			private static readonly IntPtr NativeMethodInfoPtr_get_attenuationID_Private_get_Int32_0;

			// Token: 0x04008F14 RID: 36628
			private static readonly IntPtr NativeMethodInfoPtr_get_noise3DID_Private_get_Int32_0;

			// Token: 0x04008F15 RID: 36629
			private static readonly IntPtr NativeMethodInfoPtr_get_colorGradientID_Private_get_Int32_0;

			// Token: 0x04008F16 RID: 36630
			private static readonly IntPtr NativeMethodInfoPtr_get_dynamicOcclusionID_Private_get_Int32_0;

			// Token: 0x04008F17 RID: 36631
			private static readonly IntPtr NativeMethodInfoPtr_get_cookieID_Private_get_Int32_0;

			// Token: 0x04008F18 RID: 36632
			private static readonly IntPtr NativeMethodInfoPtr_get_raymarchingQualityID_Private_get_Int32_0;

			// Token: 0x04008F19 RID: 36633
			private static readonly IntPtr NativeMethodInfoPtr_GetMaterialID_Public_Virtual_Final_New_Int32_0;

			// Token: 0x04008F1A RID: 36634
			private static readonly IntPtr NativeMethodInfoPtr_ApplyToMaterial_Public_Virtual_Final_New_Void_Material_0;

			// Token: 0x04008F1B RID: 36635
			[FieldOffset(0)]
			public MaterialManager.BlendingMode blendingMode;

			// Token: 0x04008F1C RID: 36636
			[FieldOffset(4)]
			public MaterialManager.HD.Attenuation attenuation;

			// Token: 0x04008F1D RID: 36637
			[FieldOffset(8)]
			public MaterialManager.Noise3D noise3D;

			// Token: 0x04008F1E RID: 36638
			[FieldOffset(12)]
			public MaterialManager.ColorGradient colorGradient;

			// Token: 0x04008F1F RID: 36639
			[FieldOffset(16)]
			public MaterialManager.HD.Shadow shadow;

			// Token: 0x04008F20 RID: 36640
			[FieldOffset(20)]
			public MaterialManager.HD.Cookie cookie;

			// Token: 0x04008F21 RID: 36641
			[FieldOffset(24)]
			public int raymarchingQualityIndex;
		}

		// Token: 0x0200087F RID: 2175
		public class MaterialsGroup : Il2CppSystem.Object
		{
			// Token: 0x0600D215 RID: 53781 RVA: 0x00348B18 File Offset: 0x00346D18
			// Note: this type is marked as 'beforefieldinit'.
			static MaterialsGroup()
			{
				Il2CppClassPointerStore<MaterialManager.MaterialsGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "MaterialsGroup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialManager.MaterialsGroup>.NativeClassPtr);
				MaterialManager.MaterialsGroup.NativeFieldInfoPtr_materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.MaterialsGroup>.NativeClassPtr, "materials");
				MaterialManager.MaterialsGroup.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.MaterialsGroup>.NativeClassPtr, 100664045);
			}

			// Token: 0x0600D216 RID: 53782 RVA: 0x00348B6C File Offset: 0x00346D6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71039, XrefRangeEnd = 71044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MaterialsGroup(int count) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialManager.MaterialsGroup>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.MaterialsGroup.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D217 RID: 53783 RVA: 0x0006366E File Offset: 0x0006186E
			public MaterialsGroup(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FDA RID: 16346
			// (get) Token: 0x0600D218 RID: 53784 RVA: 0x00348BB4 File Offset: 0x00346DB4
			// (set) Token: 0x0600D219 RID: 53785 RVA: 0x00063677 File Offset: 0x00061877
			public unsafe Il2CppReferenceArray<Material> materials
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialManager.MaterialsGroup.NativeFieldInfoPtr_materials);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialManager.MaterialsGroup.NativeFieldInfoPtr_materials), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F22 RID: 36642
			private static readonly IntPtr NativeFieldInfoPtr_materials;

			// Token: 0x04008F23 RID: 36643
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}

		// Token: 0x02000880 RID: 2176
		[OriginalName("Assembly-CSharp.dll", "", "ZWrite")]
		public enum ZWrite
		{
			// Token: 0x04008F25 RID: 36645
			Off,
			// Token: 0x04008F26 RID: 36646
			On
		}
	}
}
