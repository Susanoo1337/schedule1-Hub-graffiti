using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Animation;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003E9 RID: 1001
	public class CameraOrbit : MonoBehaviour
	{
		// Token: 0x0600593D RID: 22845 RVA: 0x001AF858 File Offset: 0x001ADA58
		// Note: this type is marked as 'beforefieldinit'.
		static CameraOrbit()
		{
			Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "CameraOrbit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr);
			CameraOrbit.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "target");
			CameraOrbit.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "cam");
			CameraOrbit.NativeFieldInfoPtr_raycaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "raycaster");
			CameraOrbit.NativeFieldInfoPtr_LookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "LookAt");
			CameraOrbit.NativeFieldInfoPtr_targetdistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "targetdistance");
			CameraOrbit.NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "xSpeed");
			CameraOrbit.NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "ySpeed");
			CameraOrbit.NativeFieldInfoPtr_sideOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "sideOffset");
			CameraOrbit.NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "yMinLimit");
			CameraOrbit.NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "yMaxLimit");
			CameraOrbit.NativeFieldInfoPtr_distanceMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "distanceMin");
			CameraOrbit.NativeFieldInfoPtr_distanceMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "distanceMax");
			CameraOrbit.NativeFieldInfoPtr_ScrollSensativity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "ScrollSensativity");
			CameraOrbit.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "rb");
			CameraOrbit.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "x");
			CameraOrbit.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "y");
			CameraOrbit.NativeFieldInfoPtr_targetx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "targetx");
			CameraOrbit.NativeFieldInfoPtr_targety = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "targety");
			CameraOrbit.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "distance");
			CameraOrbit.NativeFieldInfoPtr_hoveringUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "hoveringUI");
			CameraOrbit.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100674993);
			CameraOrbit.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100674994);
			CameraOrbit.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100674995);
			CameraOrbit.NativeMethodInfoPtr_ClampAngle_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100674996);
			CameraOrbit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100674997);
		}

		// Token: 0x0600593E RID: 22846 RVA: 0x001AFA7C File Offset: 0x001ADC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193916, XrefRangeEnd = 193927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbit.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600593F RID: 22847 RVA: 0x001AFAB0 File Offset: 0x001ADCB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193927, XrefRangeEnd = 193946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbit.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005940 RID: 22848 RVA: 0x001AFAE4 File Offset: 0x001ADCE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193946, XrefRangeEnd = 194007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbit.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005941 RID: 22849 RVA: 0x001AFB18 File Offset: 0x001ADD18
		[CallerCount(0)]
		public unsafe static float ClampAngle(float angle, float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbit.NativeMethodInfoPtr_ClampAngle_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005942 RID: 22850 RVA: 0x001AFB74 File Offset: 0x001ADD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194007, XrefRangeEnd = 194008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraOrbit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005943 RID: 22851 RVA: 0x0002A41B File Offset: 0x0002861B
		public CameraOrbit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x06005944 RID: 22852 RVA: 0x001AFBB0 File Offset: 0x001ADDB0
		// (set) Token: 0x06005945 RID: 22853 RVA: 0x0002A424 File Offset: 0x00028624
		public unsafe Transform target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x06005946 RID: 22854 RVA: 0x001AFBE0 File Offset: 0x001ADDE0
		// (set) Token: 0x06005947 RID: 22855 RVA: 0x0002A443 File Offset: 0x00028643
		public unsafe Transform cam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_cam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x06005948 RID: 22856 RVA: 0x001AFC10 File Offset: 0x001ADE10
		// (set) Token: 0x06005949 RID: 22857 RVA: 0x0002A462 File Offset: 0x00028662
		public unsafe GraphicRaycaster raycaster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_raycaster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicRaycaster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_raycaster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x0600594A RID: 22858 RVA: 0x001AFC40 File Offset: 0x001ADE40
		// (set) Token: 0x0600594B RID: 22859 RVA: 0x0002A481 File Offset: 0x00028681
		public unsafe AvatarLookController LookAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_LookAt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarLookController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_LookAt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B87 RID: 7047
		// (get) Token: 0x0600594C RID: 22860 RVA: 0x001AFC70 File Offset: 0x001ADE70
		// (set) Token: 0x0600594D RID: 22861 RVA: 0x0002A4A0 File Offset: 0x000286A0
		public unsafe float targetdistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targetdistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targetdistance)) = value;
			}
		}

		// Token: 0x17001B88 RID: 7048
		// (get) Token: 0x0600594E RID: 22862 RVA: 0x001AFC98 File Offset: 0x001ADE98
		// (set) Token: 0x0600594F RID: 22863 RVA: 0x0002A4BB File Offset: 0x000286BB
		public unsafe float xSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_xSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_xSpeed)) = value;
			}
		}

		// Token: 0x17001B89 RID: 7049
		// (get) Token: 0x06005950 RID: 22864 RVA: 0x001AFCC0 File Offset: 0x001ADEC0
		// (set) Token: 0x06005951 RID: 22865 RVA: 0x0002A4D6 File Offset: 0x000286D6
		public unsafe float ySpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_ySpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_ySpeed)) = value;
			}
		}

		// Token: 0x17001B8A RID: 7050
		// (get) Token: 0x06005952 RID: 22866 RVA: 0x001AFCE8 File Offset: 0x001ADEE8
		// (set) Token: 0x06005953 RID: 22867 RVA: 0x0002A4F1 File Offset: 0x000286F1
		public unsafe float sideOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_sideOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_sideOffset)) = value;
			}
		}

		// Token: 0x17001B8B RID: 7051
		// (get) Token: 0x06005954 RID: 22868 RVA: 0x001AFD10 File Offset: 0x001ADF10
		// (set) Token: 0x06005955 RID: 22869 RVA: 0x0002A50C File Offset: 0x0002870C
		public unsafe float yMinLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_yMinLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_yMinLimit)) = value;
			}
		}

		// Token: 0x17001B8C RID: 7052
		// (get) Token: 0x06005956 RID: 22870 RVA: 0x001AFD38 File Offset: 0x001ADF38
		// (set) Token: 0x06005957 RID: 22871 RVA: 0x0002A527 File Offset: 0x00028727
		public unsafe float yMaxLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_yMaxLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_yMaxLimit)) = value;
			}
		}

		// Token: 0x17001B8D RID: 7053
		// (get) Token: 0x06005958 RID: 22872 RVA: 0x001AFD60 File Offset: 0x001ADF60
		// (set) Token: 0x06005959 RID: 22873 RVA: 0x0002A542 File Offset: 0x00028742
		public unsafe float distanceMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distanceMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distanceMin)) = value;
			}
		}

		// Token: 0x17001B8E RID: 7054
		// (get) Token: 0x0600595A RID: 22874 RVA: 0x001AFD88 File Offset: 0x001ADF88
		// (set) Token: 0x0600595B RID: 22875 RVA: 0x0002A55D File Offset: 0x0002875D
		public unsafe float distanceMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distanceMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distanceMax)) = value;
			}
		}

		// Token: 0x17001B8F RID: 7055
		// (get) Token: 0x0600595C RID: 22876 RVA: 0x001AFDB0 File Offset: 0x001ADFB0
		// (set) Token: 0x0600595D RID: 22877 RVA: 0x0002A578 File Offset: 0x00028778
		public unsafe float ScrollSensativity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_ScrollSensativity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_ScrollSensativity)) = value;
			}
		}

		// Token: 0x17001B90 RID: 7056
		// (get) Token: 0x0600595E RID: 22878 RVA: 0x001AFDD8 File Offset: 0x001ADFD8
		// (set) Token: 0x0600595F RID: 22879 RVA: 0x0002A593 File Offset: 0x00028793
		public unsafe Rigidbody rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B91 RID: 7057
		// (get) Token: 0x06005960 RID: 22880 RVA: 0x001AFE08 File Offset: 0x001AE008
		// (set) Token: 0x06005961 RID: 22881 RVA: 0x0002A5B2 File Offset: 0x000287B2
		public unsafe float x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17001B92 RID: 7058
		// (get) Token: 0x06005962 RID: 22882 RVA: 0x001AFE30 File Offset: 0x001AE030
		// (set) Token: 0x06005963 RID: 22883 RVA: 0x0002A5CD File Offset: 0x000287CD
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17001B93 RID: 7059
		// (get) Token: 0x06005964 RID: 22884 RVA: 0x001AFE58 File Offset: 0x001AE058
		// (set) Token: 0x06005965 RID: 22885 RVA: 0x0002A5E8 File Offset: 0x000287E8
		public unsafe float targetx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targetx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targetx)) = value;
			}
		}

		// Token: 0x17001B94 RID: 7060
		// (get) Token: 0x06005966 RID: 22886 RVA: 0x001AFE80 File Offset: 0x001AE080
		// (set) Token: 0x06005967 RID: 22887 RVA: 0x0002A603 File Offset: 0x00028803
		public unsafe float targety
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targety);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targety)) = value;
			}
		}

		// Token: 0x17001B95 RID: 7061
		// (get) Token: 0x06005968 RID: 22888 RVA: 0x001AFEA8 File Offset: 0x001AE0A8
		// (set) Token: 0x06005969 RID: 22889 RVA: 0x0002A61E File Offset: 0x0002881E
		public unsafe float distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distance)) = value;
			}
		}

		// Token: 0x17001B96 RID: 7062
		// (get) Token: 0x0600596A RID: 22890 RVA: 0x001AFED0 File Offset: 0x001AE0D0
		// (set) Token: 0x0600596B RID: 22891 RVA: 0x0002A639 File Offset: 0x00028839
		public unsafe bool hoveringUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_hoveringUI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_hoveringUI)) = value;
			}
		}

		// Token: 0x04003D4B RID: 15691
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x04003D4C RID: 15692
		private static readonly IntPtr NativeFieldInfoPtr_cam;

		// Token: 0x04003D4D RID: 15693
		private static readonly IntPtr NativeFieldInfoPtr_raycaster;

		// Token: 0x04003D4E RID: 15694
		private static readonly IntPtr NativeFieldInfoPtr_LookAt;

		// Token: 0x04003D4F RID: 15695
		private static readonly IntPtr NativeFieldInfoPtr_targetdistance;

		// Token: 0x04003D50 RID: 15696
		private static readonly IntPtr NativeFieldInfoPtr_xSpeed;

		// Token: 0x04003D51 RID: 15697
		private static readonly IntPtr NativeFieldInfoPtr_ySpeed;

		// Token: 0x04003D52 RID: 15698
		private static readonly IntPtr NativeFieldInfoPtr_sideOffset;

		// Token: 0x04003D53 RID: 15699
		private static readonly IntPtr NativeFieldInfoPtr_yMinLimit;

		// Token: 0x04003D54 RID: 15700
		private static readonly IntPtr NativeFieldInfoPtr_yMaxLimit;

		// Token: 0x04003D55 RID: 15701
		private static readonly IntPtr NativeFieldInfoPtr_distanceMin;

		// Token: 0x04003D56 RID: 15702
		private static readonly IntPtr NativeFieldInfoPtr_distanceMax;

		// Token: 0x04003D57 RID: 15703
		private static readonly IntPtr NativeFieldInfoPtr_ScrollSensativity;

		// Token: 0x04003D58 RID: 15704
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x04003D59 RID: 15705
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04003D5A RID: 15706
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04003D5B RID: 15707
		private static readonly IntPtr NativeFieldInfoPtr_targetx;

		// Token: 0x04003D5C RID: 15708
		private static readonly IntPtr NativeFieldInfoPtr_targety;

		// Token: 0x04003D5D RID: 15709
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x04003D5E RID: 15710
		private static readonly IntPtr NativeFieldInfoPtr_hoveringUI;

		// Token: 0x04003D5F RID: 15711
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003D60 RID: 15712
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04003D61 RID: 15713
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04003D62 RID: 15714
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04003D63 RID: 15715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
