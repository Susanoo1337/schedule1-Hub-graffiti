using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x02000041 RID: 65
	public class EffectAbstractBase : MonoBehaviour
	{
		// Token: 0x06000483 RID: 1155 RVA: 0x00088760 File Offset: 0x00086960
		// Note: this type is marked as 'beforefieldinit'.
		static EffectAbstractBase()
		{
			Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "EffectAbstractBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr);
			EffectAbstractBase.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "ClassName");
			EffectAbstractBase.NativeFieldInfoPtr_componentsToChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "componentsToChange");
			EffectAbstractBase.NativeFieldInfoPtr_restoreIntensityOnDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "restoreIntensityOnDisable");
			EffectAbstractBase.NativeFieldInfoPtr_m_Beam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "m_Beam");
			EffectAbstractBase.NativeFieldInfoPtr_m_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "m_Light");
			EffectAbstractBase.NativeFieldInfoPtr_m_Particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "m_Particles");
			EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityBeamInside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "m_BaseIntensityBeamInside");
			EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityBeamOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "m_BaseIntensityBeamOutside");
			EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, "m_BaseIntensityLight");
			EffectAbstractBase.NativeMethodInfoPtr_get_restoreBaseIntensity_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100663741);
			EffectAbstractBase.NativeMethodInfoPtr_set_restoreBaseIntensity_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100663742);
			EffectAbstractBase.NativeMethodInfoPtr_InitFrom_Public_Virtual_New_Void_EffectAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100663743);
			EffectAbstractBase.NativeMethodInfoPtr_GetIntensity_Private_Void_VolumetricLightBeamSD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100663744);
			EffectAbstractBase.NativeMethodInfoPtr_GetIntensity_Private_Void_VolumetricLightBeamHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100663745);
			EffectAbstractBase.NativeMethodInfoPtr_SetIntensity_Private_Void_VolumetricLightBeamSD_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100663746);
			EffectAbstractBase.NativeMethodInfoPtr_SetIntensity_Private_Void_VolumetricLightBeamHD_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100663747);
			EffectAbstractBase.NativeMethodInfoPtr_SetAdditiveIntensity_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100663748);
			EffectAbstractBase.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100663749);
			EffectAbstractBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100663750);
			EffectAbstractBase.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100663751);
			EffectAbstractBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr, 100663752);
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x00088934 File Offset: 0x00086B34
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00088970 File Offset: 0x00086B70
		public unsafe bool restoreBaseIntensity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_get_restoreBaseIntensity_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_set_restoreBaseIntensity_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x000889B0 File Offset: 0x00086BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69376, XrefRangeEnd = 69380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitFrom(EffectAbstractBase Source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(Source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectAbstractBase.NativeMethodInfoPtr_InitFrom_Public_Virtual_New_Void_EffectAbstractBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00088A00 File Offset: 0x00086C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69380, XrefRangeEnd = 69384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetIntensity(VolumetricLightBeamSD beam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_GetIntensity_Private_Void_VolumetricLightBeamSD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00088A44 File Offset: 0x00086C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69384, XrefRangeEnd = 69388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetIntensity(VolumetricLightBeamHD beam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_GetIntensity_Private_Void_VolumetricLightBeamHD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00088A88 File Offset: 0x00086C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69388, XrefRangeEnd = 69392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIntensity(VolumetricLightBeamSD beam, float additive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beam);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_SetIntensity_Private_Void_VolumetricLightBeamSD_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00088AD8 File Offset: 0x00086CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69392, XrefRangeEnd = 69399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIntensity(VolumetricLightBeamHD beam, float additive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beam);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_SetIntensity_Private_Void_VolumetricLightBeamHD_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00088B28 File Offset: 0x00086D28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 69427, RefRangeEnd = 69430, XrefRangeStart = 69399, XrefRangeEnd = 69427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAdditiveIntensity(float additive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref additive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_SetAdditiveIntensity_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00088B68 File Offset: 0x00086D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69430, XrefRangeEnd = 69461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00088B9C File Offset: 0x00086D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69461, XrefRangeEnd = 69462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectAbstractBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00088BD8 File Offset: 0x00086DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69462, XrefRangeEnd = 69464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00088C0C File Offset: 0x00086E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69464, XrefRangeEnd = 69465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EffectAbstractBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectAbstractBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectAbstractBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x000048F0 File Offset: 0x00002AF0
		public EffectAbstractBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00088C48 File Offset: 0x00086E48
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x000048F9 File Offset: 0x00002AF9
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EffectAbstractBase.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EffectAbstractBase.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00088C68 File Offset: 0x00086E68
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x0000490B File Offset: 0x00002B0B
		public unsafe EffectAbstractBase.ComponentsToChange componentsToChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_componentsToChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_componentsToChange)) = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00088C90 File Offset: 0x00086E90
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00004926 File Offset: 0x00002B26
		public unsafe bool restoreIntensityOnDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_restoreIntensityOnDisable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_restoreIntensityOnDisable)) = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00088CB8 File Offset: 0x00086EB8
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x00004941 File Offset: 0x00002B41
		public unsafe VolumetricLightBeamAbstractBase m_Beam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_Beam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamAbstractBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_Beam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00088CE8 File Offset: 0x00086EE8
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00004960 File Offset: 0x00002B60
		public unsafe Light m_Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00088D18 File Offset: 0x00086F18
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x0000497F File Offset: 0x00002B7F
		public unsafe VolumetricDustParticles m_Particles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_Particles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricDustParticles>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_Particles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00088D48 File Offset: 0x00086F48
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x0000499E File Offset: 0x00002B9E
		public unsafe float m_BaseIntensityBeamInside
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityBeamInside);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityBeamInside)) = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00088D70 File Offset: 0x00086F70
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x000049B9 File Offset: 0x00002BB9
		public unsafe float m_BaseIntensityBeamOutside
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityBeamOutside);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityBeamOutside)) = value;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00088D98 File Offset: 0x00086F98
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x000049D4 File Offset: 0x00002BD4
		public unsafe float m_BaseIntensityLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityLight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectAbstractBase.NativeFieldInfoPtr_m_BaseIntensityLight)) = value;
			}
		}

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeFieldInfoPtr_componentsToChange;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeFieldInfoPtr_restoreIntensityOnDisable;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeFieldInfoPtr_m_Beam;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeFieldInfoPtr_m_Light;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeFieldInfoPtr_m_Particles;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseIntensityBeamInside;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseIntensityBeamOutside;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseIntensityLight;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_get_restoreBaseIntensity_Public_get_Boolean_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_set_restoreBaseIntensity_Public_set_Void_Boolean_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_InitFrom_Public_Virtual_New_Void_EffectAbstractBase_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_GetIntensity_Private_Void_VolumetricLightBeamSD_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_GetIntensity_Private_Void_VolumetricLightBeamHD_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_SetIntensity_Private_Void_VolumetricLightBeamSD_Single_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_SetIntensity_Private_Void_VolumetricLightBeamHD_Single_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_SetAdditiveIntensity_Protected_Void_Single_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200086F RID: 2159
		[OriginalName("Assembly-CSharp.dll", "", "ComponentsToChange")]
		[Flags]
		public enum ComponentsToChange
		{
			// Token: 0x04008EA2 RID: 36514
			UnityLight = 1,
			// Token: 0x04008EA3 RID: 36515
			VolumetricLightBeam = 2,
			// Token: 0x04008EA4 RID: 36516
			VolumetricDustParticles = 4
		}
	}
}
