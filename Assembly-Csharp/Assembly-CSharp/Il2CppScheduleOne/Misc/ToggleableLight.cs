using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x020002F7 RID: 759
	public class ToggleableLight : MonoBehaviour
	{
		// Token: 0x06003C09 RID: 15369 RVA: 0x00145B18 File Offset: 0x00143D18
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleableLight()
		{
			Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "ToggleableLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr);
			ToggleableLight.NativeFieldInfoPtr__isOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "_isOn");
			ToggleableLight.NativeFieldInfoPtr_lightSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "lightSources");
			ToggleableLight.NativeFieldInfoPtr_lightSurfacesMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "lightSurfacesMeshes");
			ToggleableLight.NativeFieldInfoPtr_MaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "MaterialIndex");
			ToggleableLight.NativeFieldInfoPtr_lightOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "lightOnMat");
			ToggleableLight.NativeFieldInfoPtr_lightOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "lightOffMat");
			ToggleableLight.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "state");
			ToggleableLight.NativeMethodInfoPtr_get_isOn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100670995);
			ToggleableLight.NativeMethodInfoPtr_set_isOn_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100670996);
			ToggleableLight.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100670997);
			ToggleableLight.NativeMethodInfoPtr_TurnOn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100670998);
			ToggleableLight.NativeMethodInfoPtr_TurnOff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100670999);
			ToggleableLight.NativeMethodInfoPtr_SetLights_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100671000);
			ToggleableLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100671001);
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x06003C0A RID: 15370 RVA: 0x00145C60 File Offset: 0x00143E60
		// (set) Token: 0x06003C0B RID: 15371 RVA: 0x00145C9C File Offset: 0x00143E9C
		public unsafe bool isOn
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableLight.NativeMethodInfoPtr_get_isOn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 150831, RefRangeEnd = 150855, XrefRangeStart = 150831, XrefRangeEnd = 150831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableLight.NativeMethodInfoPtr_set_isOn_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x00145CDC File Offset: 0x00143EDC
		[CallerCount(0)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableLight.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C0D RID: 15373 RVA: 0x00145D18 File Offset: 0x00143F18
		[CallerCount(0)]
		public unsafe void TurnOn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableLight.NativeMethodInfoPtr_TurnOn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C0E RID: 15374 RVA: 0x00145D4C File Offset: 0x00143F4C
		[CallerCount(0)]
		public unsafe void TurnOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableLight.NativeMethodInfoPtr_TurnOff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C0F RID: 15375 RVA: 0x00145D80 File Offset: 0x00143F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150855, XrefRangeEnd = 150856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLights()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableLight.NativeMethodInfoPtr_SetLights_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C10 RID: 15376 RVA: 0x00145DBC File Offset: 0x00143FBC
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleableLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C11 RID: 15377 RVA: 0x0001DEE3 File Offset: 0x0001C0E3
		public ToggleableLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x06003C12 RID: 15378 RVA: 0x00145DF8 File Offset: 0x00143FF8
		// (set) Token: 0x06003C13 RID: 15379 RVA: 0x0001DEEC File Offset: 0x0001C0EC
		public unsafe bool _isOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr__isOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr__isOn)) = value;
			}
		}

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x06003C14 RID: 15380 RVA: 0x00145E20 File Offset: 0x00144020
		// (set) Token: 0x06003C15 RID: 15381 RVA: 0x0001DF07 File Offset: 0x0001C107
		public unsafe Il2CppReferenceArray<OptimizedLight> lightSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OptimizedLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x06003C16 RID: 15382 RVA: 0x00145E50 File Offset: 0x00144050
		// (set) Token: 0x06003C17 RID: 15383 RVA: 0x0001DF26 File Offset: 0x0001C126
		public unsafe Il2CppReferenceArray<MeshRenderer> lightSurfacesMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightSurfacesMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightSurfacesMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x06003C18 RID: 15384 RVA: 0x00145E80 File Offset: 0x00144080
		// (set) Token: 0x06003C19 RID: 15385 RVA: 0x0001DF45 File Offset: 0x0001C145
		public unsafe int MaterialIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_MaterialIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_MaterialIndex)) = value;
			}
		}

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x06003C1A RID: 15386 RVA: 0x00145EA8 File Offset: 0x001440A8
		// (set) Token: 0x06003C1B RID: 15387 RVA: 0x0001DF60 File Offset: 0x0001C160
		public unsafe Material lightOnMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightOnMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x06003C1C RID: 15388 RVA: 0x00145ED8 File Offset: 0x001440D8
		// (set) Token: 0x06003C1D RID: 15389 RVA: 0x0001DF7F File Offset: 0x0001C17F
		public unsafe Material lightOffMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightOffMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x06003C1E RID: 15390 RVA: 0x00145F08 File Offset: 0x00144108
		// (set) Token: 0x06003C1F RID: 15391 RVA: 0x0001DF9E File Offset: 0x0001C19E
		public unsafe ToggleableLight.State state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x04002884 RID: 10372
		private static readonly IntPtr NativeFieldInfoPtr__isOn;

		// Token: 0x04002885 RID: 10373
		private static readonly IntPtr NativeFieldInfoPtr_lightSources;

		// Token: 0x04002886 RID: 10374
		private static readonly IntPtr NativeFieldInfoPtr_lightSurfacesMeshes;

		// Token: 0x04002887 RID: 10375
		private static readonly IntPtr NativeFieldInfoPtr_MaterialIndex;

		// Token: 0x04002888 RID: 10376
		private static readonly IntPtr NativeFieldInfoPtr_lightOnMat;

		// Token: 0x04002889 RID: 10377
		private static readonly IntPtr NativeFieldInfoPtr_lightOffMat;

		// Token: 0x0400288A RID: 10378
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x0400288B RID: 10379
		private static readonly IntPtr NativeMethodInfoPtr_get_isOn_Public_get_Boolean_0;

		// Token: 0x0400288C RID: 10380
		private static readonly IntPtr NativeMethodInfoPtr_set_isOn_Public_set_Void_Boolean_0;

		// Token: 0x0400288D RID: 10381
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400288E RID: 10382
		private static readonly IntPtr NativeMethodInfoPtr_TurnOn_Public_Void_0;

		// Token: 0x0400288F RID: 10383
		private static readonly IntPtr NativeMethodInfoPtr_TurnOff_Public_Void_0;

		// Token: 0x04002890 RID: 10384
		private static readonly IntPtr NativeMethodInfoPtr_SetLights_Protected_Virtual_New_Void_0;

		// Token: 0x04002891 RID: 10385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A3A RID: 2618
		[OriginalName("Assembly-CSharp.dll", "", "State")]
		public enum State
		{
			// Token: 0x04009814 RID: 38932
			NotInitialized,
			// Token: 0x04009815 RID: 38933
			On,
			// Token: 0x04009816 RID: 38934
			Off
		}
	}
}
