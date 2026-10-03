using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000037 RID: 55
	public class MaterialChanger : MonoBehaviour
	{
		// Token: 0x060003A1 RID: 929 RVA: 0x00085C3C File Offset: 0x00083E3C
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialChanger()
		{
			Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MaterialChanger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr);
			MaterialChanger.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, "_value");
			MaterialChanger.NativeFieldInfoPtr__changeMaterialSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, "_changeMaterialSetting");
			MaterialChanger.NativeFieldInfoPtr__renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, "_renderers");
			MaterialChanger.NativeFieldInfoPtr__propBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, "_propBlock");
			MaterialChanger.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, 100663652);
			MaterialChanger.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, 100663653);
			MaterialChanger.NativeMethodInfoPtr_FindAllMaterialInChild_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, 100663654);
			MaterialChanger.NativeMethodInfoPtr_SetNewValueForAllMaterial_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, 100663655);
			MaterialChanger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr, 100663656);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00085D20 File Offset: 0x00083F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68494, XrefRangeEnd = 68500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialChanger.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00085D54 File Offset: 0x00083F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68500, XrefRangeEnd = 68514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialChanger.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00085D88 File Offset: 0x00083F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FindAllMaterialInChild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialChanger.NativeMethodInfoPtr_FindAllMaterialInChild_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00085DBC File Offset: 0x00083FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68514, XrefRangeEnd = 68523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNewValueForAllMaterial(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialChanger.NativeMethodInfoPtr_SetNewValueForAllMaterial_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00085DFC File Offset: 0x00083FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68523, XrefRangeEnd = 68528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialChanger() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialChanger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialChanger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00004145 File Offset: 0x00002345
		public MaterialChanger(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00085E38 File Offset: 0x00084038
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x0000414E File Offset: 0x0000234E
		public unsafe float _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__value)) = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00085E60 File Offset: 0x00084060
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00004169 File Offset: 0x00002369
		public unsafe string _changeMaterialSetting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__changeMaterialSetting);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__changeMaterialSetting), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060003AC RID: 940 RVA: 0x00085E88 File Offset: 0x00084088
		// (set) Token: 0x060003AD RID: 941 RVA: 0x00004188 File Offset: 0x00002388
		public unsafe Il2CppReferenceArray<Renderer> _renderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__renderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__renderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060003AE RID: 942 RVA: 0x00085EB8 File Offset: 0x000840B8
		// (set) Token: 0x060003AF RID: 943 RVA: 0x000041A7 File Offset: 0x000023A7
		public unsafe MaterialPropertyBlock _propBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__propBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialChanger.NativeFieldInfoPtr__propBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeFieldInfoPtr__changeMaterialSetting;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeFieldInfoPtr__renderers;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeFieldInfoPtr__propBlock;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_FindAllMaterialInChild_Private_Void_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_SetNewValueForAllMaterial_Private_Void_Single_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
