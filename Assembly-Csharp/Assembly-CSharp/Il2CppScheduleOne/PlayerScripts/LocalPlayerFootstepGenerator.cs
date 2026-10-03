using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x02000324 RID: 804
	public class LocalPlayerFootstepGenerator : GenericFootstepDetector
	{
		// Token: 0x06003F3D RID: 16189 RVA: 0x0014FCDC File Offset: 0x0014DEDC
		// Note: this type is marked as 'beforefieldinit'.
		static LocalPlayerFootstepGenerator()
		{
			Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "LocalPlayerFootstepGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr);
			LocalPlayerFootstepGenerator.NativeFieldInfoPtr_DistancePerStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, "DistancePerStep");
			LocalPlayerFootstepGenerator.NativeFieldInfoPtr__movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, "_movement");
			LocalPlayerFootstepGenerator.NativeFieldInfoPtr__currentDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, "_currentDistance");
			LocalPlayerFootstepGenerator.NativeFieldInfoPtr__lastFramePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, "_lastFramePosition");
			LocalPlayerFootstepGenerator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, 100671321);
			LocalPlayerFootstepGenerator.NativeMethodInfoPtr_LateUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, 100671322);
			LocalPlayerFootstepGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, 100671323);
		}

		// Token: 0x06003F3E RID: 16190 RVA: 0x0014FD98 File Offset: 0x0014DF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153501, XrefRangeEnd = 153505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerFootstepGenerator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x0014FDCC File Offset: 0x0014DFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153505, XrefRangeEnd = 153515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerFootstepGenerator.NativeMethodInfoPtr_LateUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F40 RID: 16192 RVA: 0x0014FE00 File Offset: 0x0014E000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153515, XrefRangeEnd = 153521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalPlayerFootstepGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerFootstepGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F41 RID: 16193 RVA: 0x0001F6D0 File Offset: 0x0001D8D0
		public LocalPlayerFootstepGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x06003F42 RID: 16194 RVA: 0x0014FE3C File Offset: 0x0014E03C
		// (set) Token: 0x06003F43 RID: 16195 RVA: 0x0001F6D9 File Offset: 0x0001D8D9
		public unsafe static float DistancePerStep
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_DistancePerStep, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_DistancePerStep, (void*)(&value));
			}
		}

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x06003F44 RID: 16196 RVA: 0x0014FE58 File Offset: 0x0014E058
		// (set) Token: 0x06003F45 RID: 16197 RVA: 0x0001F6E7 File Offset: 0x0001D8E7
		public unsafe PlayerMovement _movement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr__movement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerMovement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr__movement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x06003F46 RID: 16198 RVA: 0x0014FE88 File Offset: 0x0014E088
		// (set) Token: 0x06003F47 RID: 16199 RVA: 0x0001F706 File Offset: 0x0001D906
		public unsafe float _currentDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr__currentDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr__currentDistance)) = value;
			}
		}

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x06003F48 RID: 16200 RVA: 0x0014FEB0 File Offset: 0x0014E0B0
		// (set) Token: 0x06003F49 RID: 16201 RVA: 0x0001F721 File Offset: 0x0001D921
		public unsafe Vector3 _lastFramePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr__lastFramePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr__lastFramePosition)) = value;
			}
		}

		// Token: 0x04002A9B RID: 10907
		private static readonly IntPtr NativeFieldInfoPtr_DistancePerStep;

		// Token: 0x04002A9C RID: 10908
		private static readonly IntPtr NativeFieldInfoPtr__movement;

		// Token: 0x04002A9D RID: 10909
		private static readonly IntPtr NativeFieldInfoPtr__currentDistance;

		// Token: 0x04002A9E RID: 10910
		private static readonly IntPtr NativeFieldInfoPtr__lastFramePosition;

		// Token: 0x04002A9F RID: 10911
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002AA0 RID: 10912
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Void_0;

		// Token: 0x04002AA1 RID: 10913
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
