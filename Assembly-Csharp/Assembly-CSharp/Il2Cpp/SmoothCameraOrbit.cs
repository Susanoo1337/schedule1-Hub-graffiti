using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200002E RID: 46
	public class SmoothCameraOrbit : MonoBehaviour
	{
		// Token: 0x06000223 RID: 547 RVA: 0x00082264 File Offset: 0x00080464
		// Note: this type is marked as 'beforefieldinit'.
		static SmoothCameraOrbit()
		{
			Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SmoothCameraOrbit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr);
			SmoothCameraOrbit.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "target");
			SmoothCameraOrbit.NativeFieldInfoPtr_targetOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "targetOffset");
			SmoothCameraOrbit.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "distance");
			SmoothCameraOrbit.NativeFieldInfoPtr_maxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "maxDistance");
			SmoothCameraOrbit.NativeFieldInfoPtr_minDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "minDistance");
			SmoothCameraOrbit.NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "xSpeed");
			SmoothCameraOrbit.NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "ySpeed");
			SmoothCameraOrbit.NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "yMinLimit");
			SmoothCameraOrbit.NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "yMaxLimit");
			SmoothCameraOrbit.NativeFieldInfoPtr_zoomRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "zoomRate");
			SmoothCameraOrbit.NativeFieldInfoPtr_panSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "panSpeed");
			SmoothCameraOrbit.NativeFieldInfoPtr_zoomDampening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "zoomDampening");
			SmoothCameraOrbit.NativeFieldInfoPtr_autoRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "autoRotate");
			SmoothCameraOrbit.NativeFieldInfoPtr_autoRotateSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "autoRotateSpeed");
			SmoothCameraOrbit.NativeFieldInfoPtr_xDeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "xDeg");
			SmoothCameraOrbit.NativeFieldInfoPtr_yDeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "yDeg");
			SmoothCameraOrbit.NativeFieldInfoPtr_currentDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "currentDistance");
			SmoothCameraOrbit.NativeFieldInfoPtr_desiredDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "desiredDistance");
			SmoothCameraOrbit.NativeFieldInfoPtr_currentRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "currentRotation");
			SmoothCameraOrbit.NativeFieldInfoPtr_desiredRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "desiredRotation");
			SmoothCameraOrbit.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "rotation");
			SmoothCameraOrbit.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "position");
			SmoothCameraOrbit.NativeFieldInfoPtr_idleTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "idleTimer");
			SmoothCameraOrbit.NativeFieldInfoPtr_idleSmooth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, "idleSmooth");
			SmoothCameraOrbit.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, 100663564);
			SmoothCameraOrbit.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, 100663565);
			SmoothCameraOrbit.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, 100663566);
			SmoothCameraOrbit.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, 100663567);
			SmoothCameraOrbit.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, 100663568);
			SmoothCameraOrbit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr, 100663569);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000824EC File Offset: 0x000806EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67458, XrefRangeEnd = 67459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothCameraOrbit.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00082520 File Offset: 0x00080720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothCameraOrbit.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00082554 File Offset: 0x00080754
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 67499, RefRangeEnd = 67501, XrefRangeStart = 67459, XrefRangeEnd = 67499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothCameraOrbit.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00082588 File Offset: 0x00080788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67501, XrefRangeEnd = 67541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothCameraOrbit.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000825BC File Offset: 0x000807BC
		[CallerCount(0)]
		public unsafe static float ClampAngle(float angle, float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothCameraOrbit.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00082618 File Offset: 0x00080818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67541, XrefRangeEnd = 67542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmoothCameraOrbit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothCameraOrbit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothCameraOrbit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00003108 File Offset: 0x00001308
		public SmoothCameraOrbit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00082654 File Offset: 0x00080854
		// (set) Token: 0x0600022C RID: 556 RVA: 0x00003111 File Offset: 0x00001311
		public unsafe Transform target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00082684 File Offset: 0x00080884
		// (set) Token: 0x0600022E RID: 558 RVA: 0x00003130 File Offset: 0x00001330
		public unsafe Vector3 targetOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_targetOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_targetOffset)) = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600022F RID: 559 RVA: 0x000826AC File Offset: 0x000808AC
		// (set) Token: 0x06000230 RID: 560 RVA: 0x0000314B File Offset: 0x0000134B
		public unsafe float distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_distance)) = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000231 RID: 561 RVA: 0x000826D4 File Offset: 0x000808D4
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00003166 File Offset: 0x00001366
		public unsafe float maxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_maxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_maxDistance)) = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000233 RID: 563 RVA: 0x000826FC File Offset: 0x000808FC
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00003181 File Offset: 0x00001381
		public unsafe float minDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_minDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_minDistance)) = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00082724 File Offset: 0x00080924
		// (set) Token: 0x06000236 RID: 566 RVA: 0x0000319C File Offset: 0x0000139C
		public unsafe float xSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_xSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_xSpeed)) = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0008274C File Offset: 0x0008094C
		// (set) Token: 0x06000238 RID: 568 RVA: 0x000031B7 File Offset: 0x000013B7
		public unsafe float ySpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_ySpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_ySpeed)) = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00082774 File Offset: 0x00080974
		// (set) Token: 0x0600023A RID: 570 RVA: 0x000031D2 File Offset: 0x000013D2
		public unsafe int yMinLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_yMinLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_yMinLimit)) = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0008279C File Offset: 0x0008099C
		// (set) Token: 0x0600023C RID: 572 RVA: 0x000031ED File Offset: 0x000013ED
		public unsafe int yMaxLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_yMaxLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_yMaxLimit)) = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600023D RID: 573 RVA: 0x000827C4 File Offset: 0x000809C4
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00003208 File Offset: 0x00001408
		public unsafe int zoomRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_zoomRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_zoomRate)) = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600023F RID: 575 RVA: 0x000827EC File Offset: 0x000809EC
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00003223 File Offset: 0x00001423
		public unsafe float panSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_panSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_panSpeed)) = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00082814 File Offset: 0x00080A14
		// (set) Token: 0x06000242 RID: 578 RVA: 0x0000323E File Offset: 0x0000143E
		public unsafe float zoomDampening
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_zoomDampening);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_zoomDampening)) = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0008283C File Offset: 0x00080A3C
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00003259 File Offset: 0x00001459
		public unsafe float autoRotate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_autoRotate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_autoRotate)) = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00082864 File Offset: 0x00080A64
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00003274 File Offset: 0x00001474
		public unsafe float autoRotateSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_autoRotateSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_autoRotateSpeed)) = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000247 RID: 583 RVA: 0x0008288C File Offset: 0x00080A8C
		// (set) Token: 0x06000248 RID: 584 RVA: 0x0000328F File Offset: 0x0000148F
		public unsafe float xDeg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_xDeg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_xDeg)) = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000249 RID: 585 RVA: 0x000828B4 File Offset: 0x00080AB4
		// (set) Token: 0x0600024A RID: 586 RVA: 0x000032AA File Offset: 0x000014AA
		public unsafe float yDeg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_yDeg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_yDeg)) = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600024B RID: 587 RVA: 0x000828DC File Offset: 0x00080ADC
		// (set) Token: 0x0600024C RID: 588 RVA: 0x000032C5 File Offset: 0x000014C5
		public unsafe float currentDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_currentDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_currentDistance)) = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00082904 File Offset: 0x00080B04
		// (set) Token: 0x0600024E RID: 590 RVA: 0x000032E0 File Offset: 0x000014E0
		public unsafe float desiredDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_desiredDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_desiredDistance)) = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0008292C File Offset: 0x00080B2C
		// (set) Token: 0x06000250 RID: 592 RVA: 0x000032FB File Offset: 0x000014FB
		public unsafe Quaternion currentRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_currentRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_currentRotation)) = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00082954 File Offset: 0x00080B54
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00003316 File Offset: 0x00001516
		public unsafe Quaternion desiredRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_desiredRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_desiredRotation)) = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0008297C File Offset: 0x00080B7C
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00003331 File Offset: 0x00001531
		public unsafe Quaternion rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000255 RID: 597 RVA: 0x000829A4 File Offset: 0x00080BA4
		// (set) Token: 0x06000256 RID: 598 RVA: 0x0000334C File Offset: 0x0000154C
		public unsafe Vector3 position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000257 RID: 599 RVA: 0x000829CC File Offset: 0x00080BCC
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00003367 File Offset: 0x00001567
		public unsafe float idleTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_idleTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_idleTimer)) = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000259 RID: 601 RVA: 0x000829F4 File Offset: 0x00080BF4
		// (set) Token: 0x0600025A RID: 602 RVA: 0x00003382 File Offset: 0x00001582
		public unsafe float idleSmooth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_idleSmooth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothCameraOrbit.NativeFieldInfoPtr_idleSmooth)) = value;
			}
		}

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeFieldInfoPtr_targetOffset;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeFieldInfoPtr_maxDistance;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeFieldInfoPtr_minDistance;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeFieldInfoPtr_xSpeed;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeFieldInfoPtr_ySpeed;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeFieldInfoPtr_yMinLimit;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr_yMaxLimit;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr_zoomRate;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr_panSpeed;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeFieldInfoPtr_zoomDampening;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeFieldInfoPtr_autoRotate;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeFieldInfoPtr_autoRotateSpeed;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeFieldInfoPtr_xDeg;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeFieldInfoPtr_yDeg;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeFieldInfoPtr_currentDistance;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeFieldInfoPtr_desiredDistance;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr_currentRotation;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr_desiredRotation;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeFieldInfoPtr_idleTimer;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeFieldInfoPtr_idleSmooth;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
