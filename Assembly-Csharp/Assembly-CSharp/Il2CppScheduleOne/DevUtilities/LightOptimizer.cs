using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003F3 RID: 1011
	public class LightOptimizer : MonoBehaviour
	{
		// Token: 0x060059EC RID: 23020 RVA: 0x001B19A8 File Offset: 0x001AFBA8
		// Note: this type is marked as 'beforefieldinit'.
		static LightOptimizer()
		{
			Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "LightOptimizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr);
			LightOptimizer.NativeFieldInfoPtr_LightsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, "LightsEnabled");
			LightOptimizer.NativeFieldInfoPtr_activationZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, "activationZones");
			LightOptimizer.NativeFieldInfoPtr_viewPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, "viewPoints");
			LightOptimizer.NativeFieldInfoPtr_checkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, "checkRange");
			LightOptimizer.NativeFieldInfoPtr_lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, "lights");
			LightOptimizer.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675062);
			LightOptimizer.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675063);
			LightOptimizer.NativeMethodInfoPtr_ApplyLights_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675064);
			LightOptimizer.NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675065);
			LightOptimizer.NativeMethodInfoPtr_Is01_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675066);
			LightOptimizer.NativeMethodInfoPtr_LightsEnabled_True_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675067);
			LightOptimizer.NativeMethodInfoPtr_LightsEnabled_False_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675068);
			LightOptimizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675069);
		}

		// Token: 0x060059ED RID: 23021 RVA: 0x001B1ADC File Offset: 0x001AFCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194609, XrefRangeEnd = 194614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060059EE RID: 23022 RVA: 0x001B1B10 File Offset: 0x001AFD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194614, XrefRangeEnd = 194642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060059EF RID: 23023 RVA: 0x001B1B44 File Offset: 0x001AFD44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194649, RefRangeEnd = 194650, XrefRangeStart = 194642, XrefRangeEnd = 194649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyLights()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_ApplyLights_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060059F0 RID: 23024 RVA: 0x001B1B78 File Offset: 0x001AFD78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194676, RefRangeEnd = 194677, XrefRangeStart = 194650, XrefRangeEnd = 194676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PointInCameraView(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060059F1 RID: 23025 RVA: 0x001B1BC4 File Offset: 0x001AFDC4
		[CallerCount(0)]
		public unsafe bool Is01(float a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_Is01_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060059F2 RID: 23026 RVA: 0x001B1C10 File Offset: 0x001AFE10
		[CallerCount(0)]
		public unsafe void LightsEnabled_True()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_LightsEnabled_True_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060059F3 RID: 23027 RVA: 0x001B1C44 File Offset: 0x001AFE44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194677, RefRangeEnd = 194678, XrefRangeStart = 194677, XrefRangeEnd = 194677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LightsEnabled_False()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_LightsEnabled_False_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060059F4 RID: 23028 RVA: 0x001B1C78 File Offset: 0x001AFE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194678, XrefRangeEnd = 194679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightOptimizer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060059F5 RID: 23029 RVA: 0x0002AA76 File Offset: 0x00028C76
		public LightOptimizer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BBF RID: 7103
		// (get) Token: 0x060059F6 RID: 23030 RVA: 0x001B1CB4 File Offset: 0x001AFEB4
		// (set) Token: 0x060059F7 RID: 23031 RVA: 0x0002AA7F File Offset: 0x00028C7F
		public unsafe bool LightsEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_LightsEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_LightsEnabled)) = value;
			}
		}

		// Token: 0x17001BC0 RID: 7104
		// (get) Token: 0x060059F8 RID: 23032 RVA: 0x001B1CDC File Offset: 0x001AFEDC
		// (set) Token: 0x060059F9 RID: 23033 RVA: 0x0002AA9A File Offset: 0x00028C9A
		public unsafe Il2CppReferenceArray<BoxCollider> activationZones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_activationZones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoxCollider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_activationZones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x060059FA RID: 23034 RVA: 0x001B1D0C File Offset: 0x001AFF0C
		// (set) Token: 0x060059FB RID: 23035 RVA: 0x0002AAB9 File Offset: 0x00028CB9
		public unsafe Il2CppReferenceArray<Transform> viewPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_viewPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_viewPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x060059FC RID: 23036 RVA: 0x001B1D3C File Offset: 0x001AFF3C
		// (set) Token: 0x060059FD RID: 23037 RVA: 0x0002AAD8 File Offset: 0x00028CD8
		public unsafe float checkRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_checkRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_checkRange)) = value;
			}
		}

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x060059FE RID: 23038 RVA: 0x001B1D64 File Offset: 0x001AFF64
		// (set) Token: 0x060059FF RID: 23039 RVA: 0x0002AAF3 File Offset: 0x00028CF3
		public unsafe Il2CppReferenceArray<OptimizedLight> lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OptimizedLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003DB6 RID: 15798
		private static readonly IntPtr NativeFieldInfoPtr_LightsEnabled;

		// Token: 0x04003DB7 RID: 15799
		private static readonly IntPtr NativeFieldInfoPtr_activationZones;

		// Token: 0x04003DB8 RID: 15800
		private static readonly IntPtr NativeFieldInfoPtr_viewPoints;

		// Token: 0x04003DB9 RID: 15801
		private static readonly IntPtr NativeFieldInfoPtr_checkRange;

		// Token: 0x04003DBA RID: 15802
		private static readonly IntPtr NativeFieldInfoPtr_lights;

		// Token: 0x04003DBB RID: 15803
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04003DBC RID: 15804
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x04003DBD RID: 15805
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLights_Public_Void_0;

		// Token: 0x04003DBE RID: 15806
		private static readonly IntPtr NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0;

		// Token: 0x04003DBF RID: 15807
		private static readonly IntPtr NativeMethodInfoPtr_Is01_Public_Boolean_Single_0;

		// Token: 0x04003DC0 RID: 15808
		private static readonly IntPtr NativeMethodInfoPtr_LightsEnabled_True_Public_Void_0;

		// Token: 0x04003DC1 RID: 15809
		private static readonly IntPtr NativeMethodInfoPtr_LightsEnabled_False_Public_Void_0;

		// Token: 0x04003DC2 RID: 15810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
