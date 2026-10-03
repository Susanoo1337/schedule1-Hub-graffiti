using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Instancing
{
	// Token: 0x02000339 RID: 825
	public class InstancingManager : Singleton<InstancingManager>
	{
		// Token: 0x06004701 RID: 18177 RVA: 0x0016C790 File Offset: 0x0016A990
		// Note: this type is marked as 'beforefieldinit'.
		static InstancingManager()
		{
			Il2CppClassPointerStore<InstancingManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Instancing", "InstancingManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstancingManager>.NativeClassPtr);
			InstancingManager.NativeFieldInfoPtr_BackedInstanceObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancingManager>.NativeClassPtr, "BackedInstanceObjects");
			InstancingManager.NativeFieldInfoPtr__instancingShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancingManager>.NativeClassPtr, "_instancingShader");
			InstancingManager.NativeFieldInfoPtr__drawInstancedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancingManager>.NativeClassPtr, "_drawInstancedObjects");
			InstancingManager.NativeFieldInfoPtr__boundsRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancingManager>.NativeClassPtr, "_boundsRadius");
			InstancingManager.NativeFieldInfoPtr__instanceBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancingManager>.NativeClassPtr, "_instanceBuffers");
			InstancingManager.NativeFieldInfoPtr__kernelID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancingManager>.NativeClassPtr, "_kernelID");
			InstancingManager.NativeFieldInfoPtr__mainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancingManager>.NativeClassPtr, "_mainCamera");
			InstancingManager.NativeFieldInfoPtr__frustumPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancingManager>.NativeClassPtr, "_frustumPlanes");
			InstancingManager.NativeFieldInfoPtr__lodBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancingManager>.NativeClassPtr, "_lodBias");
			InstancingManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstancingManager>.NativeClassPtr, 100672402);
			InstancingManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstancingManager>.NativeClassPtr, 100672403);
			InstancingManager.NativeMethodInfoPtr_UpdateAndDrawInstances_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstancingManager>.NativeClassPtr, 100672404);
			InstancingManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstancingManager>.NativeClassPtr, 100672405);
			InstancingManager.NativeMethodInfoPtr_ReleaseBuffer_Private_Void_byref_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstancingManager>.NativeClassPtr, 100672406);
			InstancingManager.NativeMethodInfoPtr_EnableInstancing_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstancingManager>.NativeClassPtr, 100672407);
			InstancingManager.NativeMethodInfoPtr_DisableInstancing_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstancingManager>.NativeClassPtr, 100672408);
			InstancingManager.NativeMethodInfoPtr_TryAssignCamera_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstancingManager>.NativeClassPtr, 100672409);
			InstancingManager.NativeMethodInfoPtr_UpdateQualitySettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstancingManager>.NativeClassPtr, 100672410);
			InstancingManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstancingManager>.NativeClassPtr, 100672411);
		}

		// Token: 0x06004702 RID: 18178 RVA: 0x0016C93C File Offset: 0x0016AB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166191, XrefRangeEnd = 166255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InstancingManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004703 RID: 18179 RVA: 0x0016C978 File Offset: 0x0016AB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166255, XrefRangeEnd = 166265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstancingManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004704 RID: 18180 RVA: 0x0016C9AC File Offset: 0x0016ABAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166310, RefRangeEnd = 166311, XrefRangeStart = 166265, XrefRangeEnd = 166310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAndDrawInstances()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstancingManager.NativeMethodInfoPtr_UpdateAndDrawInstances_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004705 RID: 18181 RVA: 0x0016C9E0 File Offset: 0x0016ABE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166311, XrefRangeEnd = 166319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InstancingManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004706 RID: 18182 RVA: 0x0016CA1C File Offset: 0x0016AC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166319, XrefRangeEnd = 166321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseBuffer(ref ComputeBuffer buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(InstancingManager.NativeMethodInfoPtr_ReleaseBuffer_Private_Void_byref_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			buffer = ((intPtr4 == 0) ? null : new ComputeBuffer(intPtr4));
		}

		// Token: 0x06004707 RID: 18183 RVA: 0x0016CA74 File Offset: 0x0016AC74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166321, RefRangeEnd = 166322, XrefRangeStart = 166321, XrefRangeEnd = 166321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableInstancing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstancingManager.NativeMethodInfoPtr_EnableInstancing_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004708 RID: 18184 RVA: 0x0016CAA8 File Offset: 0x0016ACA8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 166322, RefRangeEnd = 166327, XrefRangeStart = 166322, XrefRangeEnd = 166322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableInstancing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstancingManager.NativeMethodInfoPtr_DisableInstancing_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004709 RID: 18185 RVA: 0x0016CADC File Offset: 0x0016ACDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166327, XrefRangeEnd = 166336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAssignCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstancingManager.NativeMethodInfoPtr_TryAssignCamera_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600470A RID: 18186 RVA: 0x0016CB18 File Offset: 0x0016AD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166336, XrefRangeEnd = 166337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateQualitySettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstancingManager.NativeMethodInfoPtr_UpdateQualitySettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600470B RID: 18187 RVA: 0x0016CB4C File Offset: 0x0016AD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166337, XrefRangeEnd = 166344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstancingManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstancingManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstancingManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600470C RID: 18188 RVA: 0x00022ADF File Offset: 0x00020CDF
		public InstancingManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x0600470D RID: 18189 RVA: 0x0016CB88 File Offset: 0x0016AD88
		// (set) Token: 0x0600470E RID: 18190 RVA: 0x00022AE8 File Offset: 0x00020CE8
		public unsafe List<InstanceObjectData> BackedInstanceObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.NativeFieldInfoPtr_BackedInstanceObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InstanceObjectData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.NativeFieldInfoPtr_BackedInstanceObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x0600470F RID: 18191 RVA: 0x0016CBB8 File Offset: 0x0016ADB8
		// (set) Token: 0x06004710 RID: 18192 RVA: 0x00022B07 File Offset: 0x00020D07
		public unsafe ComputeShader _instancingShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.NativeFieldInfoPtr__instancingShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.NativeFieldInfoPtr__instancingShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x06004711 RID: 18193 RVA: 0x0016CBE8 File Offset: 0x0016ADE8
		// (set) Token: 0x06004712 RID: 18194 RVA: 0x00022B26 File Offset: 0x00020D26
		public unsafe bool _drawInstancedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.NativeFieldInfoPtr__drawInstancedObjects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.NativeFieldInfoPtr__drawInstancedObjects)) = value;
			}
		}

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x06004713 RID: 18195 RVA: 0x0016CC10 File Offset: 0x0016AE10
		// (set) Token: 0x06004714 RID: 18196 RVA: 0x00022B41 File Offset: 0x00020D41
		public unsafe float _boundsRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.NativeFieldInfoPtr__boundsRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.NativeFieldInfoPtr__boundsRadius)) = value;
			}
		}

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x06004715 RID: 18197 RVA: 0x0016CC38 File Offset: 0x0016AE38
		// (set) Token: 0x06004716 RID: 18198 RVA: 0x00022B5C File Offset: 0x00020D5C
		public unsafe Il2CppReferenceArray<InstancingManager.InstanceBuffer> _instanceBuffers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.NativeFieldInfoPtr__instanceBuffers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InstancingManager.InstanceBuffer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.NativeFieldInfoPtr__instanceBuffers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x06004717 RID: 18199 RVA: 0x0016CC68 File Offset: 0x0016AE68
		// (set) Token: 0x06004718 RID: 18200 RVA: 0x00022B7B File Offset: 0x00020D7B
		public unsafe int _kernelID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.NativeFieldInfoPtr__kernelID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.NativeFieldInfoPtr__kernelID)) = value;
			}
		}

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x06004719 RID: 18201 RVA: 0x0016CC90 File Offset: 0x0016AE90
		// (set) Token: 0x0600471A RID: 18202 RVA: 0x00022B96 File Offset: 0x00020D96
		public unsafe Camera _mainCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.NativeFieldInfoPtr__mainCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.NativeFieldInfoPtr__mainCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x0600471B RID: 18203 RVA: 0x0016CCC0 File Offset: 0x0016AEC0
		// (set) Token: 0x0600471C RID: 18204 RVA: 0x00022BB5 File Offset: 0x00020DB5
		public unsafe Il2CppStructArray<Vector4> _frustumPlanes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.NativeFieldInfoPtr__frustumPlanes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.NativeFieldInfoPtr__frustumPlanes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x0600471D RID: 18205 RVA: 0x0016CCF0 File Offset: 0x0016AEF0
		// (set) Token: 0x0600471E RID: 18206 RVA: 0x00022BD4 File Offset: 0x00020DD4
		public unsafe float _lodBias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.NativeFieldInfoPtr__lodBias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.NativeFieldInfoPtr__lodBias)) = value;
			}
		}

		// Token: 0x0400304C RID: 12364
		private static readonly IntPtr NativeFieldInfoPtr_BackedInstanceObjects;

		// Token: 0x0400304D RID: 12365
		private static readonly IntPtr NativeFieldInfoPtr__instancingShader;

		// Token: 0x0400304E RID: 12366
		private static readonly IntPtr NativeFieldInfoPtr__drawInstancedObjects;

		// Token: 0x0400304F RID: 12367
		private static readonly IntPtr NativeFieldInfoPtr__boundsRadius;

		// Token: 0x04003050 RID: 12368
		private static readonly IntPtr NativeFieldInfoPtr__instanceBuffers;

		// Token: 0x04003051 RID: 12369
		private static readonly IntPtr NativeFieldInfoPtr__kernelID;

		// Token: 0x04003052 RID: 12370
		private static readonly IntPtr NativeFieldInfoPtr__mainCamera;

		// Token: 0x04003053 RID: 12371
		private static readonly IntPtr NativeFieldInfoPtr__frustumPlanes;

		// Token: 0x04003054 RID: 12372
		private static readonly IntPtr NativeFieldInfoPtr__lodBias;

		// Token: 0x04003055 RID: 12373
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003056 RID: 12374
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04003057 RID: 12375
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAndDrawInstances_Private_Void_0;

		// Token: 0x04003058 RID: 12376
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04003059 RID: 12377
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseBuffer_Private_Void_byref_ComputeBuffer_0;

		// Token: 0x0400305A RID: 12378
		private static readonly IntPtr NativeMethodInfoPtr_EnableInstancing_Public_Void_0;

		// Token: 0x0400305B RID: 12379
		private static readonly IntPtr NativeMethodInfoPtr_DisableInstancing_Public_Void_0;

		// Token: 0x0400305C RID: 12380
		private static readonly IntPtr NativeMethodInfoPtr_TryAssignCamera_Public_Boolean_0;

		// Token: 0x0400305D RID: 12381
		private static readonly IntPtr NativeMethodInfoPtr_UpdateQualitySettings_Private_Void_0;

		// Token: 0x0400305E RID: 12382
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A66 RID: 2662
		public class InstanceBuffer : Il2CppSystem.Object
		{
			// Token: 0x0600E0C7 RID: 57543 RVA: 0x00373DF4 File Offset: 0x00371FF4
			// Note: this type is marked as 'beforefieldinit'.
			static InstanceBuffer()
			{
				Il2CppClassPointerStore<InstancingManager.InstanceBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstancingManager>.NativeClassPtr, "InstanceBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstancingManager.InstanceBuffer>.NativeClassPtr);
				InstancingManager.InstanceBuffer.NativeFieldInfoPtr_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancingManager.InstanceBuffer>.NativeClassPtr, "Buffer");
				InstancingManager.InstanceBuffer.NativeFieldInfoPtr_Args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancingManager.InstanceBuffer>.NativeClassPtr, "Args");
				InstancingManager.InstanceBuffer.NativeFieldInfoPtr_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancingManager.InstanceBuffer>.NativeClassPtr, "Mesh");
				InstancingManager.InstanceBuffer.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstancingManager.InstanceBuffer>.NativeClassPtr, "Material");
				InstancingManager.InstanceBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Mesh_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstancingManager.InstanceBuffer>.NativeClassPtr, 100672412);
			}

			// Token: 0x0600E0C8 RID: 57544 RVA: 0x00373E84 File Offset: 0x00372084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166174, XrefRangeEnd = 166191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InstanceBuffer(int maxInstances, Mesh mesh, Material material) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstancingManager.InstanceBuffer>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref maxInstances;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mesh);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstancingManager.InstanceBuffer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Mesh_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0C9 RID: 57545 RVA: 0x00069ED7 File Offset: 0x000680D7
			public InstanceBuffer(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700446B RID: 17515
			// (get) Token: 0x0600E0CA RID: 57546 RVA: 0x00373EF0 File Offset: 0x003720F0
			// (set) Token: 0x0600E0CB RID: 57547 RVA: 0x00069EE0 File Offset: 0x000680E0
			public unsafe ComputeBuffer Buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.InstanceBuffer.NativeFieldInfoPtr_Buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.InstanceBuffer.NativeFieldInfoPtr_Buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700446C RID: 17516
			// (get) Token: 0x0600E0CC RID: 57548 RVA: 0x00373F20 File Offset: 0x00372120
			// (set) Token: 0x0600E0CD RID: 57549 RVA: 0x00069EFF File Offset: 0x000680FF
			public unsafe ComputeBuffer Args
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.InstanceBuffer.NativeFieldInfoPtr_Args);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.InstanceBuffer.NativeFieldInfoPtr_Args), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700446D RID: 17517
			// (get) Token: 0x0600E0CE RID: 57550 RVA: 0x00373F50 File Offset: 0x00372150
			// (set) Token: 0x0600E0CF RID: 57551 RVA: 0x00069F1E File Offset: 0x0006811E
			public unsafe Mesh Mesh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.InstanceBuffer.NativeFieldInfoPtr_Mesh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.InstanceBuffer.NativeFieldInfoPtr_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700446E RID: 17518
			// (get) Token: 0x0600E0D0 RID: 57552 RVA: 0x00373F80 File Offset: 0x00372180
			// (set) Token: 0x0600E0D1 RID: 57553 RVA: 0x00069F3D File Offset: 0x0006813D
			public unsafe Material Material
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.InstanceBuffer.NativeFieldInfoPtr_Material);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstancingManager.InstanceBuffer.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040098FF RID: 39167
			private static readonly IntPtr NativeFieldInfoPtr_Buffer;

			// Token: 0x04009900 RID: 39168
			private static readonly IntPtr NativeFieldInfoPtr_Args;

			// Token: 0x04009901 RID: 39169
			private static readonly IntPtr NativeFieldInfoPtr_Mesh;

			// Token: 0x04009902 RID: 39170
			private static readonly IntPtr NativeFieldInfoPtr_Material;

			// Token: 0x04009903 RID: 39171
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Mesh_Material_0;
		}
	}
}
