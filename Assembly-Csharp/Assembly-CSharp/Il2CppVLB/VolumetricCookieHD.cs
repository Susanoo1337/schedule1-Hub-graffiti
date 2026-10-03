using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200005C RID: 92
	public class VolumetricCookieHD : MonoBehaviour
	{
		// Token: 0x06000524 RID: 1316 RVA: 0x0008A8C8 File Offset: 0x00088AC8
		// Note: this type is marked as 'beforefieldinit'.
		static VolumetricCookieHD()
		{
			Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "VolumetricCookieHD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr);
			VolumetricCookieHD.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, "ClassName");
			VolumetricCookieHD.NativeFieldInfoPtr_m_Contribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, "m_Contribution");
			VolumetricCookieHD.NativeFieldInfoPtr_m_CookieTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, "m_CookieTexture");
			VolumetricCookieHD.NativeFieldInfoPtr_m_Channel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, "m_Channel");
			VolumetricCookieHD.NativeFieldInfoPtr_m_Negative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, "m_Negative");
			VolumetricCookieHD.NativeFieldInfoPtr_m_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, "m_Translation");
			VolumetricCookieHD.NativeFieldInfoPtr_m_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, "m_Rotation");
			VolumetricCookieHD.NativeFieldInfoPtr_m_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, "m_Scale");
			VolumetricCookieHD.NativeFieldInfoPtr_m_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, "m_Master");
			VolumetricCookieHD.NativeMethodInfoPtr_get_contribution_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663837);
			VolumetricCookieHD.NativeMethodInfoPtr_set_contribution_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663838);
			VolumetricCookieHD.NativeMethodInfoPtr_get_cookieTexture_Public_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663839);
			VolumetricCookieHD.NativeMethodInfoPtr_set_cookieTexture_Public_set_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663840);
			VolumetricCookieHD.NativeMethodInfoPtr_get_channel_Public_get_CookieChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663841);
			VolumetricCookieHD.NativeMethodInfoPtr_set_channel_Public_set_Void_CookieChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663842);
			VolumetricCookieHD.NativeMethodInfoPtr_get_negative_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663843);
			VolumetricCookieHD.NativeMethodInfoPtr_set_negative_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663844);
			VolumetricCookieHD.NativeMethodInfoPtr_get_translation_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663845);
			VolumetricCookieHD.NativeMethodInfoPtr_set_translation_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663846);
			VolumetricCookieHD.NativeMethodInfoPtr_get_rotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663847);
			VolumetricCookieHD.NativeMethodInfoPtr_set_rotation_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663848);
			VolumetricCookieHD.NativeMethodInfoPtr_get_scale_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663849);
			VolumetricCookieHD.NativeMethodInfoPtr_set_scale_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663850);
			VolumetricCookieHD.NativeMethodInfoPtr_SetDirty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663851);
			VolumetricCookieHD.NativeMethodInfoPtr_ApplyMaterialProperties_Public_Static_Void_VolumetricCookieHD_BeamGeometryHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663852);
			VolumetricCookieHD.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663853);
			VolumetricCookieHD.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663854);
			VolumetricCookieHD.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663855);
			VolumetricCookieHD.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663856);
			VolumetricCookieHD.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663857);
			VolumetricCookieHD.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663858);
			VolumetricCookieHD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100663859);
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x0008AB78 File Offset: 0x00088D78
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x0008ABB4 File Offset: 0x00088DB4
		public unsafe float contribution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_get_contribution_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70131, XrefRangeEnd = 70132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_set_contribution_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0008ABF4 File Offset: 0x00088DF4
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x0008AC34 File Offset: 0x00088E34
		public unsafe Texture cookieTexture
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_get_cookieTexture_Public_get_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70132, XrefRangeEnd = 70138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_set_cookieTexture_Public_set_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x0008AC78 File Offset: 0x00088E78
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x0008ACB4 File Offset: 0x00088EB4
		public unsafe CookieChannel channel
		{
			[CallerCount(149)]
			[CachedScanResults(RefRangeStart = 35494, RefRangeEnd = 35643, XrefRangeStart = 35494, XrefRangeEnd = 35643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_get_channel_Public_get_CookieChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70138, XrefRangeEnd = 70139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_set_channel_Public_set_Void_CookieChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x0008ACF4 File Offset: 0x00088EF4
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x0008AD30 File Offset: 0x00088F30
		public unsafe bool negative
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_get_negative_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70139, XrefRangeEnd = 70140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_set_negative_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x0008AD70 File Offset: 0x00088F70
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x0008ADAC File Offset: 0x00088FAC
		public unsafe Vector2 translation
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 2980, RefRangeEnd = 2987, XrefRangeStart = 2980, XrefRangeEnd = 2987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_get_translation_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70140, XrefRangeEnd = 70141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_set_translation_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x0008ADEC File Offset: 0x00088FEC
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x0008AE28 File Offset: 0x00089028
		public unsafe float rotation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29133, RefRangeEnd = 29134, XrefRangeStart = 29133, XrefRangeEnd = 29134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_get_rotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70141, XrefRangeEnd = 70142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_set_rotation_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x0008AE68 File Offset: 0x00089068
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x0008AEA4 File Offset: 0x000890A4
		public unsafe Vector2 scale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_get_scale_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70142, XrefRangeEnd = 70143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_set_scale_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0008AEE4 File Offset: 0x000890E4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 70148, RefRangeEnd = 70160, XrefRangeStart = 70143, XrefRangeEnd = 70148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_SetDirty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0008AF18 File Offset: 0x00089118
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70181, RefRangeEnd = 70182, XrefRangeStart = 70160, XrefRangeEnd = 70181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyMaterialProperties(VolumetricCookieHD instance, BeamGeometryHD geom)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(geom);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_ApplyMaterialProperties_Public_Static_Void_VolumetricCookieHD_BeamGeometryHD_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0008AF60 File Offset: 0x00089160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70182, XrefRangeEnd = 70186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0008AF94 File Offset: 0x00089194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70186, XrefRangeEnd = 70187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0008AFC8 File Offset: 0x000891C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0008AFFC File Offset: 0x000891FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0008B030 File Offset: 0x00089230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70187, XrefRangeEnd = 70192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0008B064 File Offset: 0x00089264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70192, XrefRangeEnd = 70197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0008B098 File Offset: 0x00089298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70197, XrefRangeEnd = 70203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumetricCookieHD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00004CFF File Offset: 0x00002EFF
		public VolumetricCookieHD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x0008B0D4 File Offset: 0x000892D4
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x00004D08 File Offset: 0x00002F08
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VolumetricCookieHD.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumetricCookieHD.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x0008B0F4 File Offset: 0x000892F4
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00004D1A File Offset: 0x00002F1A
		public unsafe float m_Contribution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Contribution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Contribution)) = value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x0008B11C File Offset: 0x0008931C
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x00004D35 File Offset: 0x00002F35
		public unsafe Texture m_CookieTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_CookieTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_CookieTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x0008B14C File Offset: 0x0008934C
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00004D54 File Offset: 0x00002F54
		public unsafe CookieChannel m_Channel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Channel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Channel)) = value;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x0008B174 File Offset: 0x00089374
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00004D6F File Offset: 0x00002F6F
		public unsafe bool m_Negative
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Negative);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Negative)) = value;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0008B19C File Offset: 0x0008939C
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00004D8A File Offset: 0x00002F8A
		public unsafe Vector2 m_Translation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Translation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Translation)) = value;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x0008B1C4 File Offset: 0x000893C4
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x00004DA5 File Offset: 0x00002FA5
		public unsafe float m_Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Rotation)) = value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x0008B1EC File Offset: 0x000893EC
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x00004DC0 File Offset: 0x00002FC0
		public unsafe Vector2 m_Scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Scale)) = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0008B214 File Offset: 0x00089414
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x00004DDB File Offset: 0x00002FDB
		public unsafe VolumetricLightBeamHD m_Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Master);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamHD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Master), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeFieldInfoPtr_m_Contribution;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeFieldInfoPtr_m_CookieTexture;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeFieldInfoPtr_m_Channel;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeFieldInfoPtr_m_Negative;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeFieldInfoPtr_m_Translation;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeFieldInfoPtr_m_Rotation;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeFieldInfoPtr_m_Scale;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeFieldInfoPtr_m_Master;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_get_contribution_Public_get_Single_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_set_contribution_Public_set_Void_Single_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_get_cookieTexture_Public_get_Texture_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_set_cookieTexture_Public_set_Void_Texture_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_get_channel_Public_get_CookieChannel_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_set_channel_Public_set_Void_CookieChannel_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_get_negative_Public_get_Boolean_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_set_negative_Public_set_Void_Boolean_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_get_translation_Public_get_Vector2_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_set_translation_Public_set_Void_Vector2_0;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Single_0;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr_set_rotation_Public_set_Void_Single_0;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr_get_scale_Public_get_Vector2_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_set_scale_Public_set_Void_Vector2_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Private_Void_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMaterialProperties_Public_Static_Void_VolumetricCookieHD_BeamGeometryHD_0;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Private_Void_0;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
