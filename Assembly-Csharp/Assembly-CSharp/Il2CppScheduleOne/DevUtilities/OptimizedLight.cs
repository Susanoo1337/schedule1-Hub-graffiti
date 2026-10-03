using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003FB RID: 1019
	public class OptimizedLight : MonoBehaviour
	{
		// Token: 0x06005A6A RID: 23146 RVA: 0x001B3400 File Offset: 0x001B1600
		// Note: this type is marked as 'beforefieldinit'.
		static OptimizedLight()
		{
			Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "OptimizedLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr);
			OptimizedLight.NativeFieldInfoPtr__Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "_Enabled");
			OptimizedLight.NativeFieldInfoPtr__DisabledForOptimization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "_DisabledForOptimization");
			OptimizedLight.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "MaxDistance");
			OptimizedLight.NativeFieldInfoPtr__Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "_Light");
			OptimizedLight.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "_transform");
			OptimizedLight.NativeFieldInfoPtr_OnEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "OnEnabled");
			OptimizedLight.NativeFieldInfoPtr_OnDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "OnDisabled");
			OptimizedLight.NativeFieldInfoPtr_culled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "culled");
			OptimizedLight.NativeFieldInfoPtr_maxDistanceSquared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "maxDistanceSquared");
			OptimizedLight.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675117);
			OptimizedLight.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675118);
			OptimizedLight.NativeMethodInfoPtr_get_DisabledForOptimization_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675119);
			OptimizedLight.NativeMethodInfoPtr_set_DisabledForOptimization_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675120);
			OptimizedLight.NativeMethodInfoPtr_add_OnEnabled_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675121);
			OptimizedLight.NativeMethodInfoPtr_remove_OnEnabled_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675122);
			OptimizedLight.NativeMethodInfoPtr_add_OnDisabled_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675123);
			OptimizedLight.NativeMethodInfoPtr_remove_OnDisabled_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675124);
			OptimizedLight.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675125);
			OptimizedLight.NativeMethodInfoPtr_Start_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675126);
			OptimizedLight.NativeMethodInfoPtr_OnDestroy_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675127);
			OptimizedLight.NativeMethodInfoPtr_UpdateCull_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675128);
			OptimizedLight.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675129);
			OptimizedLight.NativeMethodInfoPtr_UpdateLightState_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675130);
			OptimizedLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675131);
			OptimizedLight.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675132);
		}

		// Token: 0x17001BF0 RID: 7152
		// (get) Token: 0x06005A6B RID: 23147 RVA: 0x001B3624 File Offset: 0x001B1824
		// (set) Token: 0x06005A6C RID: 23148 RVA: 0x001B3660 File Offset: 0x001B1860
		public unsafe bool Enabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 195565, RefRangeEnd = 195575, XrefRangeStart = 195558, XrefRangeEnd = 195565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001BF1 RID: 7153
		// (get) Token: 0x06005A6D RID: 23149 RVA: 0x001B36A0 File Offset: 0x001B18A0
		// (set) Token: 0x06005A6E RID: 23150 RVA: 0x001B36DC File Offset: 0x001B18DC
		public unsafe bool DisabledForOptimization
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_get_DisabledForOptimization_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195575, XrefRangeEnd = 195576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_set_DisabledForOptimization_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005A6F RID: 23151 RVA: 0x001B371C File Offset: 0x001B191C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195580, RefRangeEnd = 195582, XrefRangeStart = 195576, XrefRangeEnd = 195580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnEnabled(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_add_OnEnabled_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A70 RID: 23152 RVA: 0x001B3760 File Offset: 0x001B1960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195582, XrefRangeEnd = 195586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnEnabled(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_remove_OnEnabled_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A71 RID: 23153 RVA: 0x001B37A4 File Offset: 0x001B19A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195590, RefRangeEnd = 195592, XrefRangeStart = 195586, XrefRangeEnd = 195590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnDisabled(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_add_OnDisabled_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A72 RID: 23154 RVA: 0x001B37E8 File Offset: 0x001B19E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195592, XrefRangeEnd = 195596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnDisabled(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_remove_OnDisabled_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A73 RID: 23155 RVA: 0x001B382C File Offset: 0x001B1A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195596, XrefRangeEnd = 195603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptimizedLight.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A74 RID: 23156 RVA: 0x001B3868 File Offset: 0x001B1A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195603, XrefRangeEnd = 195627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_Start_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A75 RID: 23157 RVA: 0x001B389C File Offset: 0x001B1A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195627, XrefRangeEnd = 195641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_OnDestroy_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A76 RID: 23158 RVA: 0x001B38D0 File Offset: 0x001B1AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195641, XrefRangeEnd = 195648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_UpdateCull_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A77 RID: 23159 RVA: 0x001B3904 File Offset: 0x001B1B04
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 195565, RefRangeEnd = 195575, XrefRangeStart = 195565, XrefRangeEnd = 195575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A78 RID: 23160 RVA: 0x001B3944 File Offset: 0x001B1B44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 195654, RefRangeEnd = 195658, XrefRangeStart = 195648, XrefRangeEnd = 195654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLightState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_UpdateLightState_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A79 RID: 23161 RVA: 0x001B3978 File Offset: 0x001B1B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195658, XrefRangeEnd = 195659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptimizedLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A7A RID: 23162 RVA: 0x001B39B4 File Offset: 0x001B1BB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195701, RefRangeEnd = 195702, XrefRangeStart = 195659, XrefRangeEnd = 195701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A7B RID: 23163 RVA: 0x0002AD98 File Offset: 0x00028F98
		public OptimizedLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BE7 RID: 7143
		// (get) Token: 0x06005A7C RID: 23164 RVA: 0x001B39E8 File Offset: 0x001B1BE8
		// (set) Token: 0x06005A7D RID: 23165 RVA: 0x0002ADA1 File Offset: 0x00028FA1
		public unsafe bool _Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr__Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr__Enabled)) = value;
			}
		}

		// Token: 0x17001BE8 RID: 7144
		// (get) Token: 0x06005A7E RID: 23166 RVA: 0x001B3A10 File Offset: 0x001B1C10
		// (set) Token: 0x06005A7F RID: 23167 RVA: 0x0002ADBC File Offset: 0x00028FBC
		public unsafe bool _DisabledForOptimization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr__DisabledForOptimization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr__DisabledForOptimization)) = value;
			}
		}

		// Token: 0x17001BE9 RID: 7145
		// (get) Token: 0x06005A80 RID: 23168 RVA: 0x001B3A38 File Offset: 0x001B1C38
		// (set) Token: 0x06005A81 RID: 23169 RVA: 0x0002ADD7 File Offset: 0x00028FD7
		public unsafe float MaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_MaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_MaxDistance)) = value;
			}
		}

		// Token: 0x17001BEA RID: 7146
		// (get) Token: 0x06005A82 RID: 23170 RVA: 0x001B3A60 File Offset: 0x001B1C60
		// (set) Token: 0x06005A83 RID: 23171 RVA: 0x0002ADF2 File Offset: 0x00028FF2
		public unsafe Light _Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr__Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr__Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BEB RID: 7147
		// (get) Token: 0x06005A84 RID: 23172 RVA: 0x001B3A90 File Offset: 0x001B1C90
		// (set) Token: 0x06005A85 RID: 23173 RVA: 0x0002AE11 File Offset: 0x00029011
		public unsafe Transform _transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr__transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BEC RID: 7148
		// (get) Token: 0x06005A86 RID: 23174 RVA: 0x001B3AC0 File Offset: 0x001B1CC0
		// (set) Token: 0x06005A87 RID: 23175 RVA: 0x0002AE30 File Offset: 0x00029030
		public unsafe Action OnEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_OnEnabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_OnEnabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BED RID: 7149
		// (get) Token: 0x06005A88 RID: 23176 RVA: 0x001B3AF0 File Offset: 0x001B1CF0
		// (set) Token: 0x06005A89 RID: 23177 RVA: 0x0002AE4F File Offset: 0x0002904F
		public unsafe Action OnDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_OnDisabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_OnDisabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BEE RID: 7150
		// (get) Token: 0x06005A8A RID: 23178 RVA: 0x001B3B20 File Offset: 0x001B1D20
		// (set) Token: 0x06005A8B RID: 23179 RVA: 0x0002AE6E File Offset: 0x0002906E
		public unsafe bool culled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_culled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_culled)) = value;
			}
		}

		// Token: 0x17001BEF RID: 7151
		// (get) Token: 0x06005A8C RID: 23180 RVA: 0x001B3B48 File Offset: 0x001B1D48
		// (set) Token: 0x06005A8D RID: 23181 RVA: 0x0002AE89 File Offset: 0x00029089
		public unsafe float maxDistanceSquared
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_maxDistanceSquared);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_maxDistanceSquared)) = value;
			}
		}

		// Token: 0x04003E08 RID: 15880
		private static readonly IntPtr NativeFieldInfoPtr__Enabled;

		// Token: 0x04003E09 RID: 15881
		private static readonly IntPtr NativeFieldInfoPtr__DisabledForOptimization;

		// Token: 0x04003E0A RID: 15882
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistance;

		// Token: 0x04003E0B RID: 15883
		private static readonly IntPtr NativeFieldInfoPtr__Light;

		// Token: 0x04003E0C RID: 15884
		private static readonly IntPtr NativeFieldInfoPtr__transform;

		// Token: 0x04003E0D RID: 15885
		private static readonly IntPtr NativeFieldInfoPtr_OnEnabled;

		// Token: 0x04003E0E RID: 15886
		private static readonly IntPtr NativeFieldInfoPtr_OnDisabled;

		// Token: 0x04003E0F RID: 15887
		private static readonly IntPtr NativeFieldInfoPtr_culled;

		// Token: 0x04003E10 RID: 15888
		private static readonly IntPtr NativeFieldInfoPtr_maxDistanceSquared;

		// Token: 0x04003E11 RID: 15889
		private static readonly IntPtr NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0;

		// Token: 0x04003E12 RID: 15890
		private static readonly IntPtr NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0;

		// Token: 0x04003E13 RID: 15891
		private static readonly IntPtr NativeMethodInfoPtr_get_DisabledForOptimization_Public_get_Boolean_0;

		// Token: 0x04003E14 RID: 15892
		private static readonly IntPtr NativeMethodInfoPtr_set_DisabledForOptimization_Public_set_Void_Boolean_0;

		// Token: 0x04003E15 RID: 15893
		private static readonly IntPtr NativeMethodInfoPtr_add_OnEnabled_Public_add_Void_Action_0;

		// Token: 0x04003E16 RID: 15894
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnEnabled_Public_rem_Void_Action_0;

		// Token: 0x04003E17 RID: 15895
		private static readonly IntPtr NativeMethodInfoPtr_add_OnDisabled_Public_add_Void_Action_0;

		// Token: 0x04003E18 RID: 15896
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnDisabled_Public_rem_Void_Action_0;

		// Token: 0x04003E19 RID: 15897
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0;

		// Token: 0x04003E1A RID: 15898
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_1;

		// Token: 0x04003E1B RID: 15899
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_1;

		// Token: 0x04003E1C RID: 15900
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCull_Private_Void_1;

		// Token: 0x04003E1D RID: 15901
		private static readonly IntPtr NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0;

		// Token: 0x04003E1E RID: 15902
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLightState_Private_Void_1;

		// Token: 0x04003E1F RID: 15903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003E20 RID: 15904
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;
	}
}
