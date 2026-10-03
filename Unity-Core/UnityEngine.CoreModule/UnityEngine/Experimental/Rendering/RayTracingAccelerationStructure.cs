using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200036C RID: 876
	public sealed class RayTracingAccelerationStructure
	{
		// Token: 0x06002EF2 RID: 12018 RVA: 0x000AD744 File Offset: 0x000AB944
		public ~RayTracingAccelerationStructure()
		{
			this.Dispose(false);
		}

		// Token: 0x06002EF3 RID: 12019 RVA: 0x00014F22 File Offset: 0x00013122
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06002EF4 RID: 12020 RVA: 0x00014F34 File Offset: 0x00013134
		public void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002EF5 RID: 12021 RVA: 0x00014F41 File Offset: 0x00013141
		public static void Destroy(RayTracingAccelerationStructure accelStruct)
		{
			RayTracingAccelerationStructure.DestroyDelegateField(IL2CPP.Il2CppObjectBaseToPtr(accelStruct));
		}

		// Token: 0x06002EF6 RID: 12022 RVA: 0x00014F53 File Offset: 0x00013153
		public void Release()
		{
			this.Dispose();
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x00014F5D File Offset: 0x0001315D
		public void Build()
		{
			this.Build(Vector3.zero);
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x00014F6C File Offset: 0x0001316C
		public void AddInstance(Renderer targetRenderer, Il2CppStructArray<RayTracingSubMeshFlags> subMeshFlags, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] uint id)
		{
			this.AddInstanceSubMeshFlagsArray(targetRenderer, subMeshFlags, enableTriangleCulling, frontTriangleCounterClockwise, mask, id);
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x000AD778 File Offset: 0x000AB978
		public int AddInstance(GraphicsBuffer aabbBuffer, uint aabbCount, bool dynamicData, Matrix4x4 matrix, Material material, bool opaqueMaterial, MaterialPropertyBlock properties, [Optional] uint mask, [Optional] uint id)
		{
			return this.AddInstance_Procedural(aabbBuffer, aabbCount, dynamicData, matrix, material, opaqueMaterial, properties, mask, id);
		}

		// Token: 0x06002EFA RID: 12026 RVA: 0x00014F7F File Offset: 0x0001317F
		public void RemoveInstance(Renderer targetRenderer)
		{
			this.RemoveInstance_Renderer(targetRenderer);
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x00014F8A File Offset: 0x0001318A
		public void RemoveInstance(int handle)
		{
			this.RemoveInstance_InstanceID(handle);
		}

		// Token: 0x06002EFC RID: 12028 RVA: 0x00014F95 File Offset: 0x00013195
		public void UpdateInstanceTransform(Renderer renderer)
		{
			this.UpdateInstanceTransform_Renderer(renderer);
		}

		// Token: 0x06002EFD RID: 12029 RVA: 0x00014FA0 File Offset: 0x000131A0
		public void UpdateInstanceTransform(int handle, Matrix4x4 matrix)
		{
			this.UpdateInstanceTransform_InstanceID(handle, matrix);
		}

		// Token: 0x06002EFE RID: 12030 RVA: 0x00014FAC File Offset: 0x000131AC
		public void Update()
		{
			this.Build(Vector3.zero);
		}

		// Token: 0x06002EFF RID: 12031 RVA: 0x00014FBB File Offset: 0x000131BB
		public void Update(Vector3 relativeOrigin)
		{
			this.Update_Injected(ref relativeOrigin);
		}

		// Token: 0x06002F00 RID: 12032 RVA: 0x000AD7A0 File Offset: 0x000AB9A0
		public void AddInstance(Renderer targetRenderer, [Optional] Il2CppStructArray<bool> subMeshMask, [Optional] Il2CppStructArray<bool> subMeshTransparencyFlags, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] uint id)
		{
			RayTracingAccelerationStructure.AddInstanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targetRenderer), IL2CPP.Il2CppObjectBaseToPtr(subMeshMask), IL2CPP.Il2CppObjectBaseToPtr(subMeshTransparencyFlags), enableTriangleCulling, frontTriangleCounterClockwise, mask, id);
		}

		// Token: 0x06002F01 RID: 12033 RVA: 0x000AD7D8 File Offset: 0x000AB9D8
		public void AddInstance(GraphicsBuffer aabbBuffer, uint numElements, Material material, bool isCutOff, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] bool reuseBounds, [Optional] uint id)
		{
			this.AddInstance_Procedural_Deprecated(aabbBuffer, numElements, material, Matrix4x4.identity, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds, id);
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x000AD804 File Offset: 0x000ABA04
		public void AddInstance(GraphicsBuffer aabbBuffer, uint numElements, Material material, Matrix4x4 instanceTransform, bool isCutOff, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] bool reuseBounds, [Optional] uint id)
		{
			this.AddInstance_Procedural_Deprecated(aabbBuffer, numElements, material, instanceTransform, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds, id);
		}

		// Token: 0x06002F03 RID: 12035 RVA: 0x00014FC5 File Offset: 0x000131C5
		public void Build(Vector3 relativeOrigin)
		{
			this.Build_Injected(ref relativeOrigin);
		}

		// Token: 0x06002F04 RID: 12036 RVA: 0x000AD82C File Offset: 0x000ABA2C
		public void AddInstance_Procedural_Deprecated(GraphicsBuffer aabbBuffer, uint numElements, Material material, Matrix4x4 instanceTransform, bool isCutOff, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] bool reuseBounds, [Optional] uint id)
		{
			this.AddInstance_Procedural_Deprecated_Injected(aabbBuffer, numElements, material, ref instanceTransform, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds, id);
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x000AD850 File Offset: 0x000ABA50
		public int AddInstance_Procedural(GraphicsBuffer aabbBuffer, uint aabbCount, bool dynamicData, Matrix4x4 matrix, Material material, bool opaqueMaterial, MaterialPropertyBlock properties, [Optional] uint mask, [Optional] uint id)
		{
			return this.AddInstance_Procedural_Injected(aabbBuffer, aabbCount, dynamicData, ref matrix, material, opaqueMaterial, properties, mask, id);
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x00014FCF File Offset: 0x000131CF
		public void RemoveInstance_Renderer(Renderer targetRenderer)
		{
			RayTracingAccelerationStructure.RemoveInstance_RendererDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targetRenderer));
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x00014FE7 File Offset: 0x000131E7
		public void RemoveInstance_InstanceID(int instanceID)
		{
			RayTracingAccelerationStructure.RemoveInstance_InstanceIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), instanceID);
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x00014FFA File Offset: 0x000131FA
		public void UpdateInstanceTransform_Renderer(Renderer renderer)
		{
			RayTracingAccelerationStructure.UpdateInstanceTransform_RendererDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(renderer));
		}

		// Token: 0x06002F09 RID: 12041 RVA: 0x00015012 File Offset: 0x00013212
		public void UpdateInstanceTransform_InstanceID(int instanceID, Matrix4x4 matrix)
		{
			this.UpdateInstanceTransform_InstanceID_Injected(instanceID, ref matrix);
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x0001501D File Offset: 0x0001321D
		public void UpdateInstanceMask(Renderer renderer, uint mask)
		{
			RayTracingAccelerationStructure.UpdateInstanceMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(renderer), mask);
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x00015036 File Offset: 0x00013236
		public void UpdateInstanceID(Renderer renderer, uint instanceID)
		{
			RayTracingAccelerationStructure.UpdateInstanceIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(renderer), instanceID);
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x0001504F File Offset: 0x0001324F
		public void UpdateInstancePropertyBlock(int handle, MaterialPropertyBlock properties)
		{
			RayTracingAccelerationStructure.UpdateInstancePropertyBlockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), handle, IL2CPP.Il2CppObjectBaseToPtr(properties));
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x00015068 File Offset: 0x00013268
		public ulong GetSize()
		{
			return RayTracingAccelerationStructure.GetSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06002F0E RID: 12046 RVA: 0x0001507A File Offset: 0x0001327A
		public uint GetInstanceCount()
		{
			return RayTracingAccelerationStructure.GetInstanceCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06002F0F RID: 12047 RVA: 0x0001508C File Offset: 0x0001328C
		public void ClearInstances()
		{
			RayTracingAccelerationStructure.ClearInstancesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x0001509E File Offset: 0x0001329E
		public void AddInstanceSubMeshFlagsArray(Renderer targetRenderer, Il2CppStructArray<RayTracingSubMeshFlags> subMeshFlags, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] uint id)
		{
			RayTracingAccelerationStructure.AddInstanceSubMeshFlagsArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(targetRenderer), IL2CPP.Il2CppObjectBaseToPtr(subMeshFlags), enableTriangleCulling, frontTriangleCounterClockwise, mask, id);
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x000150C3 File Offset: 0x000132C3
		public void Update_Injected(ref Vector3 relativeOrigin)
		{
			RayTracingAccelerationStructure.Update_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref relativeOrigin);
		}

		// Token: 0x06002F12 RID: 12050 RVA: 0x000150D6 File Offset: 0x000132D6
		public void Build_Injected(ref Vector3 relativeOrigin)
		{
			RayTracingAccelerationStructure.Build_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref relativeOrigin);
		}

		// Token: 0x06002F13 RID: 12051 RVA: 0x000AD874 File Offset: 0x000ABA74
		public void AddInstance_Procedural_Deprecated_Injected(GraphicsBuffer aabbBuffer, uint numElements, Material material, ref Matrix4x4 instanceTransform, bool isCutOff, [Optional] bool enableTriangleCulling, [Optional] bool frontTriangleCounterClockwise, [Optional] uint mask, [Optional] bool reuseBounds, [Optional] uint id)
		{
			RayTracingAccelerationStructure.AddInstance_Procedural_Deprecated_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(aabbBuffer), numElements, IL2CPP.Il2CppObjectBaseToPtr(material), ref instanceTransform, isCutOff, enableTriangleCulling, frontTriangleCounterClockwise, mask, reuseBounds, id);
		}

		// Token: 0x06002F14 RID: 12052 RVA: 0x000AD8AC File Offset: 0x000ABAAC
		public int AddInstance_Procedural_Injected(GraphicsBuffer aabbBuffer, uint aabbCount, bool dynamicData, ref Matrix4x4 matrix, Material material, bool opaqueMaterial, MaterialPropertyBlock properties, [Optional] uint mask, [Optional] uint id)
		{
			return RayTracingAccelerationStructure.AddInstance_Procedural_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(aabbBuffer), aabbCount, dynamicData, ref matrix, IL2CPP.Il2CppObjectBaseToPtr(material), opaqueMaterial, IL2CPP.Il2CppObjectBaseToPtr(properties), mask, id);
		}

		// Token: 0x06002F15 RID: 12053 RVA: 0x000150E9 File Offset: 0x000132E9
		public void UpdateInstanceTransform_InstanceID_Injected(int instanceID, ref Matrix4x4 matrix)
		{
			RayTracingAccelerationStructure.UpdateInstanceTransform_InstanceID_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), instanceID, ref matrix);
		}

		// Token: 0x04002987 RID: 10631
		private static readonly RayTracingAccelerationStructure.DestroyDelegate DestroyDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.DestroyDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::Destroy");

		// Token: 0x04002988 RID: 10632
		private static readonly RayTracingAccelerationStructure.AddInstanceDelegate AddInstanceDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.AddInstanceDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::AddInstance");

		// Token: 0x04002989 RID: 10633
		private static readonly RayTracingAccelerationStructure.RemoveInstance_RendererDelegate RemoveInstance_RendererDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.RemoveInstance_RendererDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::RemoveInstance_Renderer");

		// Token: 0x0400298A RID: 10634
		private static readonly RayTracingAccelerationStructure.RemoveInstance_InstanceIDDelegate RemoveInstance_InstanceIDDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.RemoveInstance_InstanceIDDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::RemoveInstance_InstanceID");

		// Token: 0x0400298B RID: 10635
		private static readonly RayTracingAccelerationStructure.UpdateInstanceTransform_RendererDelegate UpdateInstanceTransform_RendererDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.UpdateInstanceTransform_RendererDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::UpdateInstanceTransform_Renderer");

		// Token: 0x0400298C RID: 10636
		private static readonly RayTracingAccelerationStructure.UpdateInstanceMaskDelegate UpdateInstanceMaskDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.UpdateInstanceMaskDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::UpdateInstanceMask");

		// Token: 0x0400298D RID: 10637
		private static readonly RayTracingAccelerationStructure.UpdateInstanceIDDelegate UpdateInstanceIDDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.UpdateInstanceIDDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::UpdateInstanceID");

		// Token: 0x0400298E RID: 10638
		private static readonly RayTracingAccelerationStructure.UpdateInstancePropertyBlockDelegate UpdateInstancePropertyBlockDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.UpdateInstancePropertyBlockDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::UpdateInstancePropertyBlock");

		// Token: 0x0400298F RID: 10639
		private static readonly RayTracingAccelerationStructure.GetSizeDelegate GetSizeDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.GetSizeDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::GetSize");

		// Token: 0x04002990 RID: 10640
		private static readonly RayTracingAccelerationStructure.GetInstanceCountDelegate GetInstanceCountDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.GetInstanceCountDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::GetInstanceCount");

		// Token: 0x04002991 RID: 10641
		private static readonly RayTracingAccelerationStructure.ClearInstancesDelegate ClearInstancesDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.ClearInstancesDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::ClearInstances");

		// Token: 0x04002992 RID: 10642
		private static readonly RayTracingAccelerationStructure.AddInstanceSubMeshFlagsArrayDelegate AddInstanceSubMeshFlagsArrayDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.AddInstanceSubMeshFlagsArrayDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::AddInstanceSubMeshFlagsArray");

		// Token: 0x04002993 RID: 10643
		private static readonly RayTracingAccelerationStructure.Update_InjectedDelegate Update_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.Update_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::Update_Injected");

		// Token: 0x04002994 RID: 10644
		private static readonly RayTracingAccelerationStructure.Build_InjectedDelegate Build_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.Build_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::Build_Injected");

		// Token: 0x04002995 RID: 10645
		private static readonly RayTracingAccelerationStructure.AddInstance_Procedural_Deprecated_InjectedDelegate AddInstance_Procedural_Deprecated_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.AddInstance_Procedural_Deprecated_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::AddInstance_Procedural_Deprecated_Injected");

		// Token: 0x04002996 RID: 10646
		private static readonly RayTracingAccelerationStructure.AddInstance_Procedural_InjectedDelegate AddInstance_Procedural_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.AddInstance_Procedural_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::AddInstance_Procedural_Injected");

		// Token: 0x04002997 RID: 10647
		private static readonly RayTracingAccelerationStructure.UpdateInstanceTransform_InstanceID_InjectedDelegate UpdateInstanceTransform_InstanceID_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingAccelerationStructure.UpdateInstanceTransform_InstanceID_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure::UpdateInstanceTransform_InstanceID_Injected");

		// Token: 0x02000D1A RID: 3354
		public enum RayTracingModeMask
		{
			// Token: 0x04002C8B RID: 11403
			Nothing,
			// Token: 0x04002C8C RID: 11404
			Static = 2,
			// Token: 0x04002C8D RID: 11405
			DynamicTransform = 4,
			// Token: 0x04002C8E RID: 11406
			DynamicGeometry = 8,
			// Token: 0x04002C8F RID: 11407
			Everything = 14
		}

		// Token: 0x02000D1B RID: 3355
		public enum ManagementMode
		{
			// Token: 0x04002C91 RID: 11409
			Manual,
			// Token: 0x04002C92 RID: 11410
			Automatic
		}

		// Token: 0x02000D1C RID: 3356
		// (Invoke) Token: 0x060042CD RID: 17101
		private delegate void DestroyDelegate(IntPtr accelStruct);

		// Token: 0x02000D1D RID: 3357
		// (Invoke) Token: 0x060042CF RID: 17103
		private delegate void AddInstanceDelegate(IntPtr @this, IntPtr targetRenderer, IntPtr subMeshMask, IntPtr subMeshTransparencyFlags, bool enableTriangleCulling, bool frontTriangleCounterClockwise, uint mask, uint id);

		// Token: 0x02000D1E RID: 3358
		// (Invoke) Token: 0x060042D1 RID: 17105
		private delegate void RemoveInstance_RendererDelegate(IntPtr @this, IntPtr targetRenderer);

		// Token: 0x02000D1F RID: 3359
		// (Invoke) Token: 0x060042D3 RID: 17107
		private delegate void RemoveInstance_InstanceIDDelegate(IntPtr @this, int instanceID);

		// Token: 0x02000D20 RID: 3360
		// (Invoke) Token: 0x060042D5 RID: 17109
		private delegate void UpdateInstanceTransform_RendererDelegate(IntPtr @this, IntPtr renderer);

		// Token: 0x02000D21 RID: 3361
		// (Invoke) Token: 0x060042D7 RID: 17111
		private delegate void UpdateInstanceMaskDelegate(IntPtr @this, IntPtr renderer, uint mask);

		// Token: 0x02000D22 RID: 3362
		// (Invoke) Token: 0x060042D9 RID: 17113
		private delegate void UpdateInstanceIDDelegate(IntPtr @this, IntPtr renderer, uint instanceID);

		// Token: 0x02000D23 RID: 3363
		// (Invoke) Token: 0x060042DB RID: 17115
		private delegate void UpdateInstancePropertyBlockDelegate(IntPtr @this, int handle, IntPtr properties);

		// Token: 0x02000D24 RID: 3364
		// (Invoke) Token: 0x060042DD RID: 17117
		private delegate ulong GetSizeDelegate(IntPtr @this);

		// Token: 0x02000D25 RID: 3365
		// (Invoke) Token: 0x060042DF RID: 17119
		private delegate uint GetInstanceCountDelegate(IntPtr @this);

		// Token: 0x02000D26 RID: 3366
		// (Invoke) Token: 0x060042E1 RID: 17121
		private delegate void ClearInstancesDelegate(IntPtr @this);

		// Token: 0x02000D27 RID: 3367
		// (Invoke) Token: 0x060042E3 RID: 17123
		private delegate void AddInstanceSubMeshFlagsArrayDelegate(IntPtr @this, IntPtr targetRenderer, IntPtr subMeshFlags, bool enableTriangleCulling, bool frontTriangleCounterClockwise, uint mask, uint id);

		// Token: 0x02000D28 RID: 3368
		// (Invoke) Token: 0x060042E5 RID: 17125
		private delegate void Update_InjectedDelegate(IntPtr @this, IntPtr relativeOrigin);

		// Token: 0x02000D29 RID: 3369
		// (Invoke) Token: 0x060042E7 RID: 17127
		private delegate void Build_InjectedDelegate(IntPtr @this, IntPtr relativeOrigin);

		// Token: 0x02000D2A RID: 3370
		// (Invoke) Token: 0x060042E9 RID: 17129
		private delegate void AddInstance_Procedural_Deprecated_InjectedDelegate(IntPtr @this, IntPtr aabbBuffer, uint numElements, IntPtr material, IntPtr instanceTransform, bool isCutOff, bool enableTriangleCulling, bool frontTriangleCounterClockwise, uint mask, bool reuseBounds, uint id);

		// Token: 0x02000D2B RID: 3371
		// (Invoke) Token: 0x060042EB RID: 17131
		private delegate int AddInstance_Procedural_InjectedDelegate(IntPtr @this, IntPtr aabbBuffer, uint aabbCount, bool dynamicData, IntPtr matrix, IntPtr material, bool opaqueMaterial, IntPtr properties, uint mask, uint id);

		// Token: 0x02000D2C RID: 3372
		// (Invoke) Token: 0x060042ED RID: 17133
		private delegate void UpdateInstanceTransform_InstanceID_InjectedDelegate(IntPtr @this, int instanceID, IntPtr matrix);
	}
}
