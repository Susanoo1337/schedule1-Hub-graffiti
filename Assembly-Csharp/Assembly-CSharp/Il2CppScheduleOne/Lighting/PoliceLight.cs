using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003DE RID: 990
	public class PoliceLight : MonoBehaviour
	{
		// Token: 0x06005889 RID: 22665 RVA: 0x001AD964 File Offset: 0x001ABB64
		// Note: this type is marked as 'beforefieldinit'.
		static PoliceLight()
		{
			Il2CppClassPointerStore<PoliceLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "PoliceLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr);
			PoliceLight.NativeFieldInfoPtr_IsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "IsOn");
			PoliceLight.NativeFieldInfoPtr_RedMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "RedMeshes");
			PoliceLight.NativeFieldInfoPtr_BlueMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "BlueMeshes");
			PoliceLight.NativeFieldInfoPtr_RedLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "RedLights");
			PoliceLight.NativeFieldInfoPtr_BlueLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "BlueLights");
			PoliceLight.NativeFieldInfoPtr_Siren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "Siren");
			PoliceLight.NativeFieldInfoPtr_CycleDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "CycleDuration");
			PoliceLight.NativeFieldInfoPtr_RedOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "RedOffMat");
			PoliceLight.NativeFieldInfoPtr_RedOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "RedOnMat");
			PoliceLight.NativeFieldInfoPtr_BlueOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "BlueOffMat");
			PoliceLight.NativeFieldInfoPtr_BlueOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "BlueOnMat");
			PoliceLight.NativeFieldInfoPtr_RedBrightnessCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "RedBrightnessCurve");
			PoliceLight.NativeFieldInfoPtr_BlueBrightnessCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "BlueBrightnessCurve");
			PoliceLight.NativeFieldInfoPtr_LightBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "LightBrightness");
			PoliceLight.NativeFieldInfoPtr_cycleRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "cycleRoutine");
			PoliceLight.NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, 100674920);
			PoliceLight.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, 100674921);
			PoliceLight.NativeMethodInfoPtr_CycleCoroutine_Protected_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, 100674922);
			PoliceLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, 100674923);
		}

		// Token: 0x0600588A RID: 22666 RVA: 0x001ADB10 File Offset: 0x001ABD10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOn(bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight.NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600588B RID: 22667 RVA: 0x001ADB50 File Offset: 0x001ABD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193275, XrefRangeEnd = 193277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600588C RID: 22668 RVA: 0x001ADB84 File Offset: 0x001ABD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193277, XrefRangeEnd = 193282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CycleCoroutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight.NativeMethodInfoPtr_CycleCoroutine_Protected_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600588D RID: 22669 RVA: 0x001ADBC4 File Offset: 0x001ABDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193282, XrefRangeEnd = 193283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600588E RID: 22670 RVA: 0x00029D9D File Offset: 0x00027F9D
		public PoliceLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B48 RID: 6984
		// (get) Token: 0x0600588F RID: 22671 RVA: 0x001ADC00 File Offset: 0x001ABE00
		// (set) Token: 0x06005890 RID: 22672 RVA: 0x00029DA6 File Offset: 0x00027FA6
		public unsafe bool IsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_IsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_IsOn)) = value;
			}
		}

		// Token: 0x17001B49 RID: 6985
		// (get) Token: 0x06005891 RID: 22673 RVA: 0x001ADC28 File Offset: 0x001ABE28
		// (set) Token: 0x06005892 RID: 22674 RVA: 0x00029DC1 File Offset: 0x00027FC1
		public unsafe Il2CppReferenceArray<MeshRenderer> RedMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B4A RID: 6986
		// (get) Token: 0x06005893 RID: 22675 RVA: 0x001ADC58 File Offset: 0x001ABE58
		// (set) Token: 0x06005894 RID: 22676 RVA: 0x00029DE0 File Offset: 0x00027FE0
		public unsafe Il2CppReferenceArray<MeshRenderer> BlueMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B4B RID: 6987
		// (get) Token: 0x06005895 RID: 22677 RVA: 0x001ADC88 File Offset: 0x001ABE88
		// (set) Token: 0x06005896 RID: 22678 RVA: 0x00029DFF File Offset: 0x00027FFF
		public unsafe Il2CppReferenceArray<OptimizedLight> RedLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedLights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OptimizedLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedLights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B4C RID: 6988
		// (get) Token: 0x06005897 RID: 22679 RVA: 0x001ADCB8 File Offset: 0x001ABEB8
		// (set) Token: 0x06005898 RID: 22680 RVA: 0x00029E1E File Offset: 0x0002801E
		public unsafe Il2CppReferenceArray<OptimizedLight> BlueLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueLights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OptimizedLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueLights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B4D RID: 6989
		// (get) Token: 0x06005899 RID: 22681 RVA: 0x001ADCE8 File Offset: 0x001ABEE8
		// (set) Token: 0x0600589A RID: 22682 RVA: 0x00029E3D File Offset: 0x0002803D
		public unsafe AudioSourceController Siren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_Siren);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_Siren), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B4E RID: 6990
		// (get) Token: 0x0600589B RID: 22683 RVA: 0x001ADD18 File Offset: 0x001ABF18
		// (set) Token: 0x0600589C RID: 22684 RVA: 0x00029E5C File Offset: 0x0002805C
		public unsafe float CycleDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_CycleDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_CycleDuration)) = value;
			}
		}

		// Token: 0x17001B4F RID: 6991
		// (get) Token: 0x0600589D RID: 22685 RVA: 0x001ADD40 File Offset: 0x001ABF40
		// (set) Token: 0x0600589E RID: 22686 RVA: 0x00029E77 File Offset: 0x00028077
		public unsafe Material RedOffMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedOffMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B50 RID: 6992
		// (get) Token: 0x0600589F RID: 22687 RVA: 0x001ADD70 File Offset: 0x001ABF70
		// (set) Token: 0x060058A0 RID: 22688 RVA: 0x00029E96 File Offset: 0x00028096
		public unsafe Material RedOnMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedOnMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x060058A1 RID: 22689 RVA: 0x001ADDA0 File Offset: 0x001ABFA0
		// (set) Token: 0x060058A2 RID: 22690 RVA: 0x00029EB5 File Offset: 0x000280B5
		public unsafe Material BlueOffMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueOffMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B52 RID: 6994
		// (get) Token: 0x060058A3 RID: 22691 RVA: 0x001ADDD0 File Offset: 0x001ABFD0
		// (set) Token: 0x060058A4 RID: 22692 RVA: 0x00029ED4 File Offset: 0x000280D4
		public unsafe Material BlueOnMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueOnMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B53 RID: 6995
		// (get) Token: 0x060058A5 RID: 22693 RVA: 0x001ADE00 File Offset: 0x001AC000
		// (set) Token: 0x060058A6 RID: 22694 RVA: 0x00029EF3 File Offset: 0x000280F3
		public unsafe AnimationCurve RedBrightnessCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedBrightnessCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedBrightnessCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B54 RID: 6996
		// (get) Token: 0x060058A7 RID: 22695 RVA: 0x001ADE30 File Offset: 0x001AC030
		// (set) Token: 0x060058A8 RID: 22696 RVA: 0x00029F12 File Offset: 0x00028112
		public unsafe AnimationCurve BlueBrightnessCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueBrightnessCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueBrightnessCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B55 RID: 6997
		// (get) Token: 0x060058A9 RID: 22697 RVA: 0x001ADE60 File Offset: 0x001AC060
		// (set) Token: 0x060058AA RID: 22698 RVA: 0x00029F31 File Offset: 0x00028131
		public unsafe float LightBrightness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_LightBrightness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_LightBrightness)) = value;
			}
		}

		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x060058AB RID: 22699 RVA: 0x001ADE88 File Offset: 0x001AC088
		// (set) Token: 0x060058AC RID: 22700 RVA: 0x00029F4C File Offset: 0x0002814C
		public unsafe Coroutine cycleRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_cycleRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_cycleRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003CE3 RID: 15587
		private static readonly IntPtr NativeFieldInfoPtr_IsOn;

		// Token: 0x04003CE4 RID: 15588
		private static readonly IntPtr NativeFieldInfoPtr_RedMeshes;

		// Token: 0x04003CE5 RID: 15589
		private static readonly IntPtr NativeFieldInfoPtr_BlueMeshes;

		// Token: 0x04003CE6 RID: 15590
		private static readonly IntPtr NativeFieldInfoPtr_RedLights;

		// Token: 0x04003CE7 RID: 15591
		private static readonly IntPtr NativeFieldInfoPtr_BlueLights;

		// Token: 0x04003CE8 RID: 15592
		private static readonly IntPtr NativeFieldInfoPtr_Siren;

		// Token: 0x04003CE9 RID: 15593
		private static readonly IntPtr NativeFieldInfoPtr_CycleDuration;

		// Token: 0x04003CEA RID: 15594
		private static readonly IntPtr NativeFieldInfoPtr_RedOffMat;

		// Token: 0x04003CEB RID: 15595
		private static readonly IntPtr NativeFieldInfoPtr_RedOnMat;

		// Token: 0x04003CEC RID: 15596
		private static readonly IntPtr NativeFieldInfoPtr_BlueOffMat;

		// Token: 0x04003CED RID: 15597
		private static readonly IntPtr NativeFieldInfoPtr_BlueOnMat;

		// Token: 0x04003CEE RID: 15598
		private static readonly IntPtr NativeFieldInfoPtr_RedBrightnessCurve;

		// Token: 0x04003CEF RID: 15599
		private static readonly IntPtr NativeFieldInfoPtr_BlueBrightnessCurve;

		// Token: 0x04003CF0 RID: 15600
		private static readonly IntPtr NativeFieldInfoPtr_LightBrightness;

		// Token: 0x04003CF1 RID: 15601
		private static readonly IntPtr NativeFieldInfoPtr_cycleRoutine;

		// Token: 0x04003CF2 RID: 15602
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0;

		// Token: 0x04003CF3 RID: 15603
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04003CF4 RID: 15604
		private static readonly IntPtr NativeMethodInfoPtr_CycleCoroutine_Protected_IEnumerator_0;

		// Token: 0x04003CF5 RID: 15605
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000ADA RID: 2778
		[ObfuscatedName("ScheduleOne.Lighting.PoliceLight+<CycleCoroutine>d__17")]
		public sealed class _CycleCoroutine_d__17 : Il2CppSystem.Object
		{
			// Token: 0x0600E492 RID: 58514 RVA: 0x0037E93C File Offset: 0x0037CB3C
			// Note: this type is marked as 'beforefieldinit'.
			static _CycleCoroutine_d__17()
			{
				Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "<CycleCoroutine>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr);
				PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, "<>1__state");
				PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, "<>2__current");
				PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, "<>4__this");
				PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr__time_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, "<time>5__2");
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100674924);
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100674925);
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100674926);
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100674927);
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100674928);
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100674929);
			}

			// Token: 0x0600E493 RID: 58515 RVA: 0x0037EA30 File Offset: 0x0037CC30
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CycleCoroutine_d__17(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E494 RID: 58516 RVA: 0x0037EA78 File Offset: 0x0037CC78
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E495 RID: 58517 RVA: 0x0037EAAC File Offset: 0x0037CCAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193214, XrefRangeEnd = 193270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004580 RID: 17792
			// (get) Token: 0x0600E496 RID: 58518 RVA: 0x0037EAE8 File Offset: 0x0037CCE8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E497 RID: 58519 RVA: 0x0037EB28 File Offset: 0x0037CD28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193270, XrefRangeEnd = 193275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004581 RID: 17793
			// (get) Token: 0x0600E498 RID: 58520 RVA: 0x0037EB5C File Offset: 0x0037CD5C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E499 RID: 58521 RVA: 0x0006BC3B File Offset: 0x00069E3B
			public _CycleCoroutine_d__17(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700457C RID: 17788
			// (get) Token: 0x0600E49A RID: 58522 RVA: 0x0037EB9C File Offset: 0x0037CD9C
			// (set) Token: 0x0600E49B RID: 58523 RVA: 0x0006BC44 File Offset: 0x00069E44
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700457D RID: 17789
			// (get) Token: 0x0600E49C RID: 58524 RVA: 0x0037EBC4 File Offset: 0x0037CDC4
			// (set) Token: 0x0600E49D RID: 58525 RVA: 0x0006BC5F File Offset: 0x00069E5F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700457E RID: 17790
			// (get) Token: 0x0600E49E RID: 58526 RVA: 0x0037EBF4 File Offset: 0x0037CDF4
			// (set) Token: 0x0600E49F RID: 58527 RVA: 0x0006BC7E File Offset: 0x00069E7E
			public unsafe PoliceLight __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceLight>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700457F RID: 17791
			// (get) Token: 0x0600E4A0 RID: 58528 RVA: 0x0037EC24 File Offset: 0x0037CE24
			// (set) Token: 0x0600E4A1 RID: 58529 RVA: 0x0006BC9D File Offset: 0x00069E9D
			public unsafe float _time_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr__time_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr__time_5__2)) = value;
				}
			}

			// Token: 0x04009B38 RID: 39736
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009B39 RID: 39737
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009B3A RID: 39738
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009B3B RID: 39739
			private static readonly IntPtr NativeFieldInfoPtr__time_5__2;

			// Token: 0x04009B3C RID: 39740
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009B3D RID: 39741
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009B3E RID: 39742
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009B3F RID: 39743
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009B40 RID: 39744
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009B41 RID: 39745
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
