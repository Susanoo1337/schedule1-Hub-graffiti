using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000513 RID: 1299
	public class GrowContainerCameraHandler : MonoBehaviour
	{
		// Token: 0x060075D4 RID: 30164 RVA: 0x0020E3DC File Offset: 0x0020C5DC
		// Note: this type is marked as 'beforefieldinit'.
		static GrowContainerCameraHandler()
		{
			Il2CppClassPointerStore<GrowContainerCameraHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "GrowContainerCameraHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrowContainerCameraHandler>.NativeClassPtr);
			GrowContainerCameraHandler.NativeFieldInfoPtr_RotateCameraContainerToFacePlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerCameraHandler>.NativeClassPtr, "RotateCameraContainerToFacePlayer");
			GrowContainerCameraHandler.NativeFieldInfoPtr_SnapRotationToRightAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerCameraHandler>.NativeClassPtr, "SnapRotationToRightAngles");
			GrowContainerCameraHandler.NativeFieldInfoPtr__midshotCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerCameraHandler>.NativeClassPtr, "_midshotCamera");
			GrowContainerCameraHandler.NativeFieldInfoPtr__closeupCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerCameraHandler>.NativeClassPtr, "_closeupCamera");
			GrowContainerCameraHandler.NativeFieldInfoPtr__fullshotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerCameraHandler>.NativeClassPtr, "_fullshotContainer");
			GrowContainerCameraHandler.NativeFieldInfoPtr__birdsEyeCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerCameraHandler>.NativeClassPtr, "_birdsEyeCamera");
			GrowContainerCameraHandler.NativeFieldInfoPtr__debugCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerCameraHandler>.NativeClassPtr, "_debugCameraPosition");
			GrowContainerCameraHandler.NativeMethodInfoPtr_PositionCameraContainer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerCameraHandler>.NativeClassPtr, 100678466);
			GrowContainerCameraHandler.NativeMethodInfoPtr_GetCameraPosition_Public_Transform_ECameraPosition_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerCameraHandler>.NativeClassPtr, 100678467);
			GrowContainerCameraHandler.NativeMethodInfoPtr_SetCameraPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerCameraHandler>.NativeClassPtr, 100678468);
			GrowContainerCameraHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerCameraHandler>.NativeClassPtr, 100678469);
		}

		// Token: 0x060075D5 RID: 30165 RVA: 0x0020E4E8 File Offset: 0x0020C6E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229623, RefRangeEnd = 229625, XrefRangeStart = 229599, XrefRangeEnd = 229623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PositionCameraContainer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerCameraHandler.NativeMethodInfoPtr_PositionCameraContainer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075D6 RID: 30166 RVA: 0x0020E51C File Offset: 0x0020C71C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 229626, RefRangeEnd = 229632, XrefRangeStart = 229625, XrefRangeEnd = 229626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetCameraPosition(GrowContainerCameraHandler.ECameraPosition pos, bool autoPosition = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerCameraHandler.NativeMethodInfoPtr_GetCameraPosition_Public_Transform_ECameraPosition_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x060075D7 RID: 30167 RVA: 0x0020E578 File Offset: 0x0020C778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229632, XrefRangeEnd = 229644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCameraPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerCameraHandler.NativeMethodInfoPtr_SetCameraPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075D8 RID: 30168 RVA: 0x0020E5AC File Offset: 0x0020C7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229644, XrefRangeEnd = 229645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GrowContainerCameraHandler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrowContainerCameraHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerCameraHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075D9 RID: 30169 RVA: 0x000382F5 File Offset: 0x000364F5
		public GrowContainerCameraHandler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002465 RID: 9317
		// (get) Token: 0x060075DA RID: 30170 RVA: 0x0020E5E8 File Offset: 0x0020C7E8
		// (set) Token: 0x060075DB RID: 30171 RVA: 0x000382FE File Offset: 0x000364FE
		public unsafe bool RotateCameraContainerToFacePlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerCameraHandler.NativeFieldInfoPtr_RotateCameraContainerToFacePlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerCameraHandler.NativeFieldInfoPtr_RotateCameraContainerToFacePlayer)) = value;
			}
		}

		// Token: 0x17002466 RID: 9318
		// (get) Token: 0x060075DC RID: 30172 RVA: 0x0020E610 File Offset: 0x0020C810
		// (set) Token: 0x060075DD RID: 30173 RVA: 0x00038319 File Offset: 0x00036519
		public unsafe bool SnapRotationToRightAngles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerCameraHandler.NativeFieldInfoPtr_SnapRotationToRightAngles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerCameraHandler.NativeFieldInfoPtr_SnapRotationToRightAngles)) = value;
			}
		}

		// Token: 0x17002467 RID: 9319
		// (get) Token: 0x060075DE RID: 30174 RVA: 0x0020E638 File Offset: 0x0020C838
		// (set) Token: 0x060075DF RID: 30175 RVA: 0x00038334 File Offset: 0x00036534
		public unsafe Transform _midshotCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerCameraHandler.NativeFieldInfoPtr__midshotCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerCameraHandler.NativeFieldInfoPtr__midshotCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002468 RID: 9320
		// (get) Token: 0x060075E0 RID: 30176 RVA: 0x0020E668 File Offset: 0x0020C868
		// (set) Token: 0x060075E1 RID: 30177 RVA: 0x00038353 File Offset: 0x00036553
		public unsafe Transform _closeupCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerCameraHandler.NativeFieldInfoPtr__closeupCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerCameraHandler.NativeFieldInfoPtr__closeupCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002469 RID: 9321
		// (get) Token: 0x060075E2 RID: 30178 RVA: 0x0020E698 File Offset: 0x0020C898
		// (set) Token: 0x060075E3 RID: 30179 RVA: 0x00038372 File Offset: 0x00036572
		public unsafe Transform _fullshotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerCameraHandler.NativeFieldInfoPtr__fullshotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerCameraHandler.NativeFieldInfoPtr__fullshotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700246A RID: 9322
		// (get) Token: 0x060075E4 RID: 30180 RVA: 0x0020E6C8 File Offset: 0x0020C8C8
		// (set) Token: 0x060075E5 RID: 30181 RVA: 0x00038391 File Offset: 0x00036591
		public unsafe Transform _birdsEyeCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerCameraHandler.NativeFieldInfoPtr__birdsEyeCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerCameraHandler.NativeFieldInfoPtr__birdsEyeCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700246B RID: 9323
		// (get) Token: 0x060075E6 RID: 30182 RVA: 0x0020E6F8 File Offset: 0x0020C8F8
		// (set) Token: 0x060075E7 RID: 30183 RVA: 0x000383B0 File Offset: 0x000365B0
		public unsafe GrowContainerCameraHandler.ECameraPosition _debugCameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerCameraHandler.NativeFieldInfoPtr__debugCameraPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerCameraHandler.NativeFieldInfoPtr__debugCameraPosition)) = value;
			}
		}

		// Token: 0x04005052 RID: 20562
		private static readonly IntPtr NativeFieldInfoPtr_RotateCameraContainerToFacePlayer;

		// Token: 0x04005053 RID: 20563
		private static readonly IntPtr NativeFieldInfoPtr_SnapRotationToRightAngles;

		// Token: 0x04005054 RID: 20564
		private static readonly IntPtr NativeFieldInfoPtr__midshotCamera;

		// Token: 0x04005055 RID: 20565
		private static readonly IntPtr NativeFieldInfoPtr__closeupCamera;

		// Token: 0x04005056 RID: 20566
		private static readonly IntPtr NativeFieldInfoPtr__fullshotContainer;

		// Token: 0x04005057 RID: 20567
		private static readonly IntPtr NativeFieldInfoPtr__birdsEyeCamera;

		// Token: 0x04005058 RID: 20568
		private static readonly IntPtr NativeFieldInfoPtr__debugCameraPosition;

		// Token: 0x04005059 RID: 20569
		private static readonly IntPtr NativeMethodInfoPtr_PositionCameraContainer_Public_Void_0;

		// Token: 0x0400505A RID: 20570
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraPosition_Public_Transform_ECameraPosition_Boolean_0;

		// Token: 0x0400505B RID: 20571
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraPosition_Private_Void_0;

		// Token: 0x0400505C RID: 20572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BAB RID: 2987
		[OriginalName("Assembly-CSharp.dll", "", "ECameraPosition")]
		public enum ECameraPosition
		{
			// Token: 0x04009F05 RID: 40709
			Closeup,
			// Token: 0x04009F06 RID: 40710
			Midshot,
			// Token: 0x04009F07 RID: 40711
			Fullshot,
			// Token: 0x04009F08 RID: 40712
			BirdsEye
		}
	}
}
