using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	// Token: 0x0200021A RID: 538
	public class BatchRendererGroup : Object
	{
		// Token: 0x0600246B RID: 9323 RVA: 0x00092318 File Offset: 0x00090518
		// Note: this type is marked as 'beforefieldinit'.
		static BatchRendererGroup()
		{
			Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchRendererGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr);
			BatchRendererGroup.NativeFieldInfoPtr_m_GroupHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, "m_GroupHandle");
			BatchRendererGroup.NativeFieldInfoPtr_m_PerformCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, "m_PerformCulling");
			BatchRendererGroup.NativeMethodInfoPtr_InvokeOnPerformCulling_Private_Static_Void_BatchRendererGroup_byref_BatchRendererCullingOutput_byref_LODParameters_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, 100667210);
			BatchRendererGroup.SetPickingMaterialDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetPickingMaterialDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetPickingMaterial");
			BatchRendererGroup.SetErrorMaterialDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetErrorMaterialDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetErrorMaterial");
			BatchRendererGroup.SetLoadingMaterialDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetLoadingMaterialDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetLoadingMaterial");
			BatchRendererGroup.SetEnabledViewTypesDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetEnabledViewTypesDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetEnabledViewTypes");
			BatchRendererGroup.GetBufferTargetDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetBufferTargetDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetBufferTarget");
			BatchRendererGroup.GetConstantBufferMaxWindowSizeDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetConstantBufferMaxWindowSizeDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetConstantBufferMaxWindowSize");
			BatchRendererGroup.GetConstantBufferOffsetAlignmentDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetConstantBufferOffsetAlignmentDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetConstantBufferOffsetAlignment");
			BatchRendererGroup.CreateDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.CreateDelegate>("UnityEngine.Rendering.BatchRendererGroup::Create");
			BatchRendererGroup.DestroyDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.DestroyDelegate>("UnityEngine.Rendering.BatchRendererGroup::Destroy");
			BatchRendererGroup.RemoveDrawCommandBatch_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.RemoveDrawCommandBatch_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::RemoveDrawCommandBatch_Injected");
			BatchRendererGroup.RegisterMaterial_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.RegisterMaterial_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::RegisterMaterial_Injected");
			BatchRendererGroup.RegisterMaterial_InstanceID_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.RegisterMaterial_InstanceID_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::RegisterMaterial_InstanceID_Injected");
			BatchRendererGroup.UnregisterMaterial_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.UnregisterMaterial_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::UnregisterMaterial_Injected");
			BatchRendererGroup.GetRegisteredMaterial_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetRegisteredMaterial_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetRegisteredMaterial_Injected");
			BatchRendererGroup.RegisterMesh_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.RegisterMesh_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::RegisterMesh_Injected");
			BatchRendererGroup.RegisterMesh_InstanceID_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.RegisterMesh_InstanceID_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::RegisterMesh_InstanceID_Injected");
			BatchRendererGroup.UnregisterMesh_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.UnregisterMesh_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::UnregisterMesh_Injected");
			BatchRendererGroup.GetRegisteredMesh_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.GetRegisteredMesh_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::GetRegisteredMesh_Injected");
			BatchRendererGroup.SetGlobalBounds_InjectedDelegateField = IL2CPP.ResolveICall<BatchRendererGroup.SetGlobalBounds_InjectedDelegate>("UnityEngine.Rendering.BatchRendererGroup::SetGlobalBounds_Injected");
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x000924A4 File Offset: 0x000906A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290058, XrefRangeEnd = 1290070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters, IntPtr userContext)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &context;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lodParameters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRendererGroup.NativeMethodInfoPtr_InvokeOnPerformCulling_Private_Static_Void_BatchRendererGroup_byref_BatchRendererCullingOutput_byref_LODParameters_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x00010DD2 File Offset: 0x0000EFD2
		public BatchRendererGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x0600246E RID: 9326 RVA: 0x00092504 File Offset: 0x00090704
		// (set) Token: 0x0600246F RID: 9327 RVA: 0x00010DDB File Offset: 0x0000EFDB
		public unsafe IntPtr m_GroupHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRendererGroup.NativeFieldInfoPtr_m_GroupHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRendererGroup.NativeFieldInfoPtr_m_GroupHandle)) = value;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06002470 RID: 9328 RVA: 0x0009252C File Offset: 0x0009072C
		// (set) Token: 0x06002471 RID: 9329 RVA: 0x00010DF6 File Offset: 0x0000EFF6
		public unsafe BatchRendererGroup.OnPerformCulling m_PerformCulling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRendererGroup.NativeFieldInfoPtr_m_PerformCulling);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BatchRendererGroup.OnPerformCulling>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BatchRendererGroup.NativeFieldInfoPtr_m_PerformCulling), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x00010E15 File Offset: 0x0000F015
		public void Dispose()
		{
			BatchRendererGroup.Destroy(this.m_GroupHandle);
			this.m_GroupHandle = IntPtr.Zero;
		}

		// Token: 0x06002473 RID: 9331 RVA: 0x00010E2F File Offset: 0x0000F02F
		public void RemoveDrawCommandBatch(BatchID batchID)
		{
			this.RemoveDrawCommandBatch_Injected(ref batchID);
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x00010E39 File Offset: 0x0000F039
		public void RemoveBatch(BatchID batchID)
		{
			this.RemoveDrawCommandBatch(batchID);
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x0009255C File Offset: 0x0009075C
		public BatchMaterialID RegisterMaterial(Material material)
		{
			BatchMaterialID result;
			this.RegisterMaterial_Injected(material, out result);
			return result;
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x00010E44 File Offset: 0x0000F044
		public BatchMaterialID RegisterMaterial(int materialInstanceID)
		{
			return this.RegisterMaterial_InstanceID(materialInstanceID);
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x00092574 File Offset: 0x00090774
		public BatchMaterialID RegisterMaterial_InstanceID(int materialInstanceID)
		{
			BatchMaterialID result;
			this.RegisterMaterial_InstanceID_Injected(materialInstanceID, out result);
			return result;
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x00010E4D File Offset: 0x0000F04D
		public void UnregisterMaterial(BatchMaterialID material)
		{
			this.UnregisterMaterial_Injected(ref material);
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x00010E57 File Offset: 0x0000F057
		public Material GetRegisteredMaterial(BatchMaterialID material)
		{
			return this.GetRegisteredMaterial_Injected(ref material);
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x0009258C File Offset: 0x0009078C
		public BatchMeshID RegisterMesh(Mesh mesh)
		{
			BatchMeshID result;
			this.RegisterMesh_Injected(mesh, out result);
			return result;
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x00010E61 File Offset: 0x0000F061
		public BatchMeshID RegisterMesh(int meshInstanceID)
		{
			return this.RegisterMesh_InstanceID(meshInstanceID);
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x000925A4 File Offset: 0x000907A4
		public BatchMeshID RegisterMesh_InstanceID(int meshInstanceID)
		{
			BatchMeshID result;
			this.RegisterMesh_InstanceID_Injected(meshInstanceID, out result);
			return result;
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x00010E6A File Offset: 0x0000F06A
		public void UnregisterMesh(BatchMeshID mesh)
		{
			this.UnregisterMesh_Injected(ref mesh);
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x00010E74 File Offset: 0x0000F074
		public Mesh GetRegisteredMesh(BatchMeshID mesh)
		{
			return this.GetRegisteredMesh_Injected(ref mesh);
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x00010E7E File Offset: 0x0000F07E
		public void SetGlobalBounds(Bounds bounds)
		{
			this.SetGlobalBounds_Injected(ref bounds);
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x00010E88 File Offset: 0x0000F088
		public void SetPickingMaterial(Material material)
		{
			BatchRendererGroup.SetPickingMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(material));
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x00010EA0 File Offset: 0x0000F0A0
		public void SetErrorMaterial(Material material)
		{
			BatchRendererGroup.SetErrorMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(material));
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x00010EB8 File Offset: 0x0000F0B8
		public void SetLoadingMaterial(Material material)
		{
			BatchRendererGroup.SetLoadingMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(material));
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x00010ED0 File Offset: 0x0000F0D0
		public void SetEnabledViewTypes(Il2CppStructArray<BatchCullingViewType> viewTypes)
		{
			BatchRendererGroup.SetEnabledViewTypesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(viewTypes));
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x00010EE8 File Offset: 0x0000F0E8
		public static BatchBufferTarget GetBufferTarget()
		{
			return BatchRendererGroup.GetBufferTargetDelegateField();
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06002485 RID: 9349 RVA: 0x00010EF4 File Offset: 0x0000F0F4
		public static BatchBufferTarget BufferTarget
		{
			get
			{
				return BatchRendererGroup.GetBufferTarget();
			}
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x00010EFB File Offset: 0x0000F0FB
		public static int GetConstantBufferMaxWindowSize()
		{
			return BatchRendererGroup.GetConstantBufferMaxWindowSizeDelegateField();
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x00010F07 File Offset: 0x0000F107
		public static int GetConstantBufferOffsetAlignment()
		{
			return BatchRendererGroup.GetConstantBufferOffsetAlignmentDelegateField();
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x00010F13 File Offset: 0x0000F113
		public unsafe static IntPtr Create(BatchRendererGroup group, void* userContext)
		{
			return BatchRendererGroup.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(group), userContext);
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x00010F26 File Offset: 0x0000F126
		public static void Destroy(IntPtr groupHandle)
		{
			BatchRendererGroup.DestroyDelegateField(groupHandle);
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x00010F33 File Offset: 0x0000F133
		public void RemoveDrawCommandBatch_Injected(ref BatchID batchID)
		{
			BatchRendererGroup.RemoveDrawCommandBatch_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref batchID);
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x00010F46 File Offset: 0x0000F146
		public void RegisterMaterial_Injected(Material material, out BatchMaterialID ret)
		{
			BatchRendererGroup.RegisterMaterial_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(material), out ret);
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x00010F5F File Offset: 0x0000F15F
		public void RegisterMaterial_InstanceID_Injected(int materialInstanceID, out BatchMaterialID ret)
		{
			BatchRendererGroup.RegisterMaterial_InstanceID_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), materialInstanceID, out ret);
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x00010F73 File Offset: 0x0000F173
		public void UnregisterMaterial_Injected(ref BatchMaterialID material)
		{
			BatchRendererGroup.UnregisterMaterial_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref material);
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x000925BC File Offset: 0x000907BC
		public Material GetRegisteredMaterial_Injected(ref BatchMaterialID material)
		{
			IntPtr intPtr = BatchRendererGroup.GetRegisteredMaterial_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref material);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x00010F86 File Offset: 0x0000F186
		public void RegisterMesh_Injected(Mesh mesh, out BatchMeshID ret)
		{
			BatchRendererGroup.RegisterMesh_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mesh), out ret);
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x00010F9F File Offset: 0x0000F19F
		public void RegisterMesh_InstanceID_Injected(int meshInstanceID, out BatchMeshID ret)
		{
			BatchRendererGroup.RegisterMesh_InstanceID_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), meshInstanceID, out ret);
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x00010FB3 File Offset: 0x0000F1B3
		public void UnregisterMesh_Injected(ref BatchMeshID mesh)
		{
			BatchRendererGroup.UnregisterMesh_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref mesh);
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x000925EC File Offset: 0x000907EC
		public Mesh GetRegisteredMesh_Injected(ref BatchMeshID mesh)
		{
			IntPtr intPtr = BatchRendererGroup.GetRegisteredMesh_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref mesh);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x00010FC6 File Offset: 0x0000F1C6
		public void SetGlobalBounds_Injected(ref Bounds bounds)
		{
			BatchRendererGroup.SetGlobalBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref bounds);
		}

		// Token: 0x04001EAA RID: 7850
		private static readonly IntPtr NativeFieldInfoPtr_m_GroupHandle;

		// Token: 0x04001EAB RID: 7851
		private static readonly IntPtr NativeFieldInfoPtr_m_PerformCulling;

		// Token: 0x04001EAC RID: 7852
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnPerformCulling_Private_Static_Void_BatchRendererGroup_byref_BatchRendererCullingOutput_byref_LODParameters_IntPtr_0;

		// Token: 0x04001EAD RID: 7853
		private static readonly BatchRendererGroup.SetPickingMaterialDelegate SetPickingMaterialDelegateField;

		// Token: 0x04001EAE RID: 7854
		private static readonly BatchRendererGroup.SetErrorMaterialDelegate SetErrorMaterialDelegateField;

		// Token: 0x04001EAF RID: 7855
		private static readonly BatchRendererGroup.SetLoadingMaterialDelegate SetLoadingMaterialDelegateField;

		// Token: 0x04001EB0 RID: 7856
		private static readonly BatchRendererGroup.SetEnabledViewTypesDelegate SetEnabledViewTypesDelegateField;

		// Token: 0x04001EB1 RID: 7857
		private static readonly BatchRendererGroup.GetBufferTargetDelegate GetBufferTargetDelegateField;

		// Token: 0x04001EB2 RID: 7858
		private static readonly BatchRendererGroup.GetConstantBufferMaxWindowSizeDelegate GetConstantBufferMaxWindowSizeDelegateField;

		// Token: 0x04001EB3 RID: 7859
		private static readonly BatchRendererGroup.GetConstantBufferOffsetAlignmentDelegate GetConstantBufferOffsetAlignmentDelegateField;

		// Token: 0x04001EB4 RID: 7860
		private static readonly BatchRendererGroup.CreateDelegate CreateDelegateField;

		// Token: 0x04001EB5 RID: 7861
		private static readonly BatchRendererGroup.DestroyDelegate DestroyDelegateField;

		// Token: 0x04001EB6 RID: 7862
		private static readonly BatchRendererGroup.RemoveDrawCommandBatch_InjectedDelegate RemoveDrawCommandBatch_InjectedDelegateField;

		// Token: 0x04001EB7 RID: 7863
		private static readonly BatchRendererGroup.RegisterMaterial_InjectedDelegate RegisterMaterial_InjectedDelegateField;

		// Token: 0x04001EB8 RID: 7864
		private static readonly BatchRendererGroup.RegisterMaterial_InstanceID_InjectedDelegate RegisterMaterial_InstanceID_InjectedDelegateField;

		// Token: 0x04001EB9 RID: 7865
		private static readonly BatchRendererGroup.UnregisterMaterial_InjectedDelegate UnregisterMaterial_InjectedDelegateField;

		// Token: 0x04001EBA RID: 7866
		private static readonly BatchRendererGroup.GetRegisteredMaterial_InjectedDelegate GetRegisteredMaterial_InjectedDelegateField;

		// Token: 0x04001EBB RID: 7867
		private static readonly BatchRendererGroup.RegisterMesh_InjectedDelegate RegisterMesh_InjectedDelegateField;

		// Token: 0x04001EBC RID: 7868
		private static readonly BatchRendererGroup.RegisterMesh_InstanceID_InjectedDelegate RegisterMesh_InstanceID_InjectedDelegateField;

		// Token: 0x04001EBD RID: 7869
		private static readonly BatchRendererGroup.UnregisterMesh_InjectedDelegate UnregisterMesh_InjectedDelegateField;

		// Token: 0x04001EBE RID: 7870
		private static readonly BatchRendererGroup.GetRegisteredMesh_InjectedDelegate GetRegisteredMesh_InjectedDelegateField;

		// Token: 0x04001EBF RID: 7871
		private static readonly BatchRendererGroup.SetGlobalBounds_InjectedDelegate SetGlobalBounds_InjectedDelegateField;

		// Token: 0x02000B48 RID: 2888
		public sealed class OnPerformCulling : MulticastDelegate
		{
			// Token: 0x06003F75 RID: 16245 RVA: 0x0001841F File Offset: 0x0001661F
			// Note: this type is marked as 'beforefieldinit'.
			static OnPerformCulling()
			{
				Il2CppClassPointerStore<BatchRendererGroup.OnPerformCulling>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BatchRendererGroup>.NativeClassPtr, "OnPerformCulling");
				BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup.OnPerformCulling>.NativeClassPtr, 100667211);
				BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr_Invoke_Public_Virtual_New_JobHandle_BatchRendererGroup_BatchCullingContext_BatchCullingOutput_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroup.OnPerformCulling>.NativeClassPtr, 100667212);
			}

			// Token: 0x06003F76 RID: 16246 RVA: 0x000B4EA8 File Offset: 0x000B30A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290048, XrefRangeEnd = 1290058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnPerformCulling(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchRendererGroup.OnPerformCulling>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F77 RID: 16247 RVA: 0x000B4F04 File Offset: 0x000B3104
			[CallerCount(0)]
			public unsafe Unity.Jobs.JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, BatchCullingOutput cullingOutput, IntPtr userContext)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererGroup);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cullingContext));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cullingOutput));
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchRendererGroup.OnPerformCulling.NativeMethodInfoPtr_Invoke_Public_Virtual_New_JobHandle_BatchRendererGroup_BatchCullingContext_BatchCullingOutput_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003F78 RID: 16248 RVA: 0x0001845D File Offset: 0x0001665D
			public OnPerformCulling(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003F79 RID: 16249 RVA: 0x00018466 File Offset: 0x00016666
			public static implicit operator BatchRendererGroup.OnPerformCulling(Func<BatchRendererGroup, BatchCullingContext, BatchCullingOutput, IntPtr, Unity.Jobs.JobHandle> A_0)
			{
				return DelegateSupport.ConvertDelegate<BatchRendererGroup.OnPerformCulling>(A_0);
			}

			// Token: 0x06003F7A RID: 16250 RVA: 0x0001846E File Offset: 0x0001666E
			public static BatchRendererGroup.OnPerformCulling operator +(BatchRendererGroup.OnPerformCulling A_0, BatchRendererGroup.OnPerformCulling A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<BatchRendererGroup.OnPerformCulling>();
			}

			// Token: 0x06003F7B RID: 16251 RVA: 0x0001847C File Offset: 0x0001667C
			public static BatchRendererGroup.OnPerformCulling operator -(BatchRendererGroup.OnPerformCulling A_0, BatchRendererGroup.OnPerformCulling A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<BatchRendererGroup.OnPerformCulling>();
				}
				return result;
			}

			// Token: 0x04002BCB RID: 11211
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002BCC RID: 11212
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_JobHandle_BatchRendererGroup_BatchCullingContext_BatchCullingOutput_IntPtr_0;
		}

		// Token: 0x02000B49 RID: 2889
		// (Invoke) Token: 0x06003F7D RID: 16253
		private delegate void SetPickingMaterialDelegate(IntPtr @this, IntPtr material);

		// Token: 0x02000B4A RID: 2890
		// (Invoke) Token: 0x06003F7F RID: 16255
		private delegate void SetErrorMaterialDelegate(IntPtr @this, IntPtr material);

		// Token: 0x02000B4B RID: 2891
		// (Invoke) Token: 0x06003F81 RID: 16257
		private delegate void SetLoadingMaterialDelegate(IntPtr @this, IntPtr material);

		// Token: 0x02000B4C RID: 2892
		// (Invoke) Token: 0x06003F83 RID: 16259
		private delegate void SetEnabledViewTypesDelegate(IntPtr @this, IntPtr viewTypes);

		// Token: 0x02000B4D RID: 2893
		// (Invoke) Token: 0x06003F85 RID: 16261
		private delegate BatchBufferTarget GetBufferTargetDelegate();

		// Token: 0x02000B4E RID: 2894
		// (Invoke) Token: 0x06003F87 RID: 16263
		private delegate int GetConstantBufferMaxWindowSizeDelegate();

		// Token: 0x02000B4F RID: 2895
		// (Invoke) Token: 0x06003F89 RID: 16265
		private delegate int GetConstantBufferOffsetAlignmentDelegate();

		// Token: 0x02000B50 RID: 2896
		// (Invoke) Token: 0x06003F8B RID: 16267
		private delegate IntPtr CreateDelegate(IntPtr group, IntPtr userContext);

		// Token: 0x02000B51 RID: 2897
		// (Invoke) Token: 0x06003F8D RID: 16269
		private delegate void DestroyDelegate(IntPtr groupHandle);

		// Token: 0x02000B52 RID: 2898
		// (Invoke) Token: 0x06003F8F RID: 16271
		private delegate void RemoveDrawCommandBatch_InjectedDelegate(IntPtr @this, IntPtr batchID);

		// Token: 0x02000B53 RID: 2899
		// (Invoke) Token: 0x06003F91 RID: 16273
		private delegate void RegisterMaterial_InjectedDelegate(IntPtr @this, IntPtr material, [Out] IntPtr ret);

		// Token: 0x02000B54 RID: 2900
		// (Invoke) Token: 0x06003F93 RID: 16275
		private delegate void RegisterMaterial_InstanceID_InjectedDelegate(IntPtr @this, int materialInstanceID, [Out] IntPtr ret);

		// Token: 0x02000B55 RID: 2901
		// (Invoke) Token: 0x06003F95 RID: 16277
		private delegate void UnregisterMaterial_InjectedDelegate(IntPtr @this, IntPtr material);

		// Token: 0x02000B56 RID: 2902
		// (Invoke) Token: 0x06003F97 RID: 16279
		private delegate IntPtr GetRegisteredMaterial_InjectedDelegate(IntPtr @this, IntPtr material);

		// Token: 0x02000B57 RID: 2903
		// (Invoke) Token: 0x06003F99 RID: 16281
		private delegate void RegisterMesh_InjectedDelegate(IntPtr @this, IntPtr mesh, [Out] IntPtr ret);

		// Token: 0x02000B58 RID: 2904
		// (Invoke) Token: 0x06003F9B RID: 16283
		private delegate void RegisterMesh_InstanceID_InjectedDelegate(IntPtr @this, int meshInstanceID, [Out] IntPtr ret);

		// Token: 0x02000B59 RID: 2905
		// (Invoke) Token: 0x06003F9D RID: 16285
		private delegate void UnregisterMesh_InjectedDelegate(IntPtr @this, IntPtr mesh);

		// Token: 0x02000B5A RID: 2906
		// (Invoke) Token: 0x06003F9F RID: 16287
		private delegate IntPtr GetRegisteredMesh_InjectedDelegate(IntPtr @this, IntPtr mesh);

		// Token: 0x02000B5B RID: 2907
		// (Invoke) Token: 0x06003FA1 RID: 16289
		private delegate void SetGlobalBounds_InjectedDelegate(IntPtr @this, IntPtr bounds);
	}
}
