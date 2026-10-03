using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200036E RID: 878
	public sealed class RayTracingShader : Object
	{
		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06002F17 RID: 12055 RVA: 0x000150FD File Offset: 0x000132FD
		public float maxRecursionDepth
		{
			get
			{
				return RayTracingShader.get_maxRecursionDepthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x0001510F File Offset: 0x0001330F
		public void SetFloat(int nameID, float val)
		{
			RayTracingShader.SetFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, val);
		}

		// Token: 0x06002F19 RID: 12057 RVA: 0x00015123 File Offset: 0x00013323
		public void SetInt(int nameID, int val)
		{
			RayTracingShader.SetIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, val);
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x00015137 File Offset: 0x00013337
		public void SetVector(int nameID, Vector4 val)
		{
			this.SetVector_Injected(nameID, ref val);
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x00015142 File Offset: 0x00013342
		public void SetMatrix(int nameID, Matrix4x4 val)
		{
			this.SetMatrix_Injected(nameID, ref val);
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x0001514D File Offset: 0x0001334D
		public void SetFloatArray(int nameID, Il2CppStructArray<float> values)
		{
			RayTracingShader.SetFloatArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x00015166 File Offset: 0x00013366
		public void SetIntArray(int nameID, Il2CppStructArray<int> values)
		{
			RayTracingShader.SetIntArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06002F1E RID: 12062 RVA: 0x0001517F File Offset: 0x0001337F
		public void SetVectorArray(int nameID, Il2CppStructArray<Vector4> values)
		{
			RayTracingShader.SetVectorArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x00015198 File Offset: 0x00013398
		public void SetMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			RayTracingShader.SetMatrixArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06002F20 RID: 12064 RVA: 0x000151B1 File Offset: 0x000133B1
		public void SetTexture(int nameID, Texture texture)
		{
			RayTracingShader.SetTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(texture));
		}

		// Token: 0x06002F21 RID: 12065 RVA: 0x000151CA File Offset: 0x000133CA
		public void SetBuffer(int nameID, ComputeBuffer buffer)
		{
			RayTracingShader.SetBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x06002F22 RID: 12066 RVA: 0x000151E3 File Offset: 0x000133E3
		public void SetGraphicsBuffer(int nameID, GraphicsBuffer buffer)
		{
			RayTracingShader.SetGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x000151FC File Offset: 0x000133FC
		public void SetConstantComputeBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
		{
			RayTracingShader.SetConstantComputeBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer), offset, size);
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x00015218 File Offset: 0x00013418
		public void SetConstantGraphicsBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			RayTracingShader.SetConstantGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer), offset, size);
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x00015234 File Offset: 0x00013434
		public void SetAccelerationStructure(int nameID, RayTracingAccelerationStructure accelerationStructure)
		{
			RayTracingShader.SetAccelerationStructureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(accelerationStructure));
		}

		// Token: 0x06002F26 RID: 12070 RVA: 0x0001524D File Offset: 0x0001344D
		public void SetShaderPass(string passName)
		{
			RayTracingShader.SetShaderPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(passName));
		}

		// Token: 0x06002F27 RID: 12071 RVA: 0x00015265 File Offset: 0x00013465
		public void SetTextureFromGlobal(int nameID, int globalTextureNameID)
		{
			RayTracingShader.SetTextureFromGlobalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, globalTextureNameID);
		}

		// Token: 0x06002F28 RID: 12072 RVA: 0x00015279 File Offset: 0x00013479
		public void Dispatch(string rayGenFunctionName, int width, int height, int depth, [Optional] Camera camera)
		{
			RayTracingShader.DispatchDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(rayGenFunctionName), width, height, depth, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x0001529C File Offset: 0x0001349C
		public void SetBuffer(int nameID, GraphicsBuffer buffer)
		{
			this.SetGraphicsBuffer(nameID, buffer);
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x000152A8 File Offset: 0x000134A8
		public void SetFloat(string name, float val)
		{
			this.SetFloat(Shader.PropertyToID(name), val);
		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x000152B9 File Offset: 0x000134B9
		public void SetInt(string name, int val)
		{
			this.SetInt(Shader.PropertyToID(name), val);
		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x000152CA File Offset: 0x000134CA
		public void SetVector(string name, Vector4 val)
		{
			this.SetVector(Shader.PropertyToID(name), val);
		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x000152DB File Offset: 0x000134DB
		public void SetMatrix(string name, Matrix4x4 val)
		{
			this.SetMatrix(Shader.PropertyToID(name), val);
		}

		// Token: 0x06002F2E RID: 12078 RVA: 0x000152EC File Offset: 0x000134EC
		public void SetVectorArray(string name, Il2CppStructArray<Vector4> values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x000152FD File Offset: 0x000134FD
		public void SetMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x0001530E File Offset: 0x0001350E
		public void SetFloats(string name, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06002F31 RID: 12081 RVA: 0x0001531F File Offset: 0x0001351F
		public void SetFloats(string name, params float[] values)
		{
			this.SetFloats(name, new Il2CppStructArray<float>(values));
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x0001532E File Offset: 0x0001352E
		public void SetFloats(int nameID, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(nameID, values);
		}

		// Token: 0x06002F33 RID: 12083 RVA: 0x0001533A File Offset: 0x0001353A
		public void SetFloats(int nameID, params float[] values)
		{
			this.SetFloats(nameID, new Il2CppStructArray<float>(values));
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x00015349 File Offset: 0x00013549
		public void SetInts(string name, Il2CppStructArray<int> values)
		{
			this.SetIntArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x0001535A File Offset: 0x0001355A
		public void SetInts(string name, params int[] values)
		{
			this.SetInts(name, new Il2CppStructArray<int>(values));
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x00015369 File Offset: 0x00013569
		public void SetInts(int nameID, Il2CppStructArray<int> values)
		{
			this.SetIntArray(nameID, values);
		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x00015375 File Offset: 0x00013575
		public void SetInts(int nameID, params int[] values)
		{
			this.SetInts(nameID, new Il2CppStructArray<int>(values));
		}

		// Token: 0x06002F38 RID: 12088 RVA: 0x00015384 File Offset: 0x00013584
		public void SetBool(string name, bool val)
		{
			this.SetInt(Shader.PropertyToID(name), val ? 1 : 0);
		}

		// Token: 0x06002F39 RID: 12089 RVA: 0x0001539B File Offset: 0x0001359B
		public void SetBool(int nameID, bool val)
		{
			this.SetInt(nameID, val ? 1 : 0);
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x000153AD File Offset: 0x000135AD
		public void SetTexture(string name, Texture texture)
		{
			this.SetTexture(Shader.PropertyToID(name), texture);
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x000153BE File Offset: 0x000135BE
		public void SetBuffer(string name, ComputeBuffer buffer)
		{
			this.SetBuffer(Shader.PropertyToID(name), buffer);
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x000153CF File Offset: 0x000135CF
		public void SetBuffer(string name, GraphicsBuffer buffer)
		{
			this.SetBuffer(Shader.PropertyToID(name), buffer);
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x000153E0 File Offset: 0x000135E0
		public void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
		{
			this.SetConstantComputeBuffer(nameID, buffer, offset, size);
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x000153EF File Offset: 0x000135EF
		public void SetConstantBuffer(string name, ComputeBuffer buffer, int offset, int size)
		{
			this.SetConstantComputeBuffer(Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x00015403 File Offset: 0x00013603
		public void SetConstantBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			this.SetConstantGraphicsBuffer(nameID, buffer, offset, size);
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x00015412 File Offset: 0x00013612
		public void SetConstantBuffer(string name, GraphicsBuffer buffer, int offset, int size)
		{
			this.SetConstantGraphicsBuffer(Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x00015426 File Offset: 0x00013626
		public void SetAccelerationStructure(string name, RayTracingAccelerationStructure accelerationStructure)
		{
			this.SetAccelerationStructure(Shader.PropertyToID(name), accelerationStructure);
		}

		// Token: 0x06002F42 RID: 12098 RVA: 0x00015437 File Offset: 0x00013637
		public void SetTextureFromGlobal(string name, string globalTextureName)
		{
			this.SetTextureFromGlobal(Shader.PropertyToID(name), Shader.PropertyToID(globalTextureName));
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x0001544D File Offset: 0x0001364D
		public void SetVector_Injected(int nameID, ref Vector4 val)
		{
			RayTracingShader.SetVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref val);
		}

		// Token: 0x06002F44 RID: 12100 RVA: 0x00015461 File Offset: 0x00013661
		public void SetMatrix_Injected(int nameID, ref Matrix4x4 val)
		{
			RayTracingShader.SetMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref val);
		}

		// Token: 0x04002998 RID: 10648
		private static readonly RayTracingShader.get_maxRecursionDepthDelegate get_maxRecursionDepthDelegateField = IL2CPP.ResolveICall<RayTracingShader.get_maxRecursionDepthDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::get_maxRecursionDepth");

		// Token: 0x04002999 RID: 10649
		private static readonly RayTracingShader.SetFloatDelegate SetFloatDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetFloatDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetFloat");

		// Token: 0x0400299A RID: 10650
		private static readonly RayTracingShader.SetIntDelegate SetIntDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetIntDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetInt");

		// Token: 0x0400299B RID: 10651
		private static readonly RayTracingShader.SetFloatArrayDelegate SetFloatArrayDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetFloatArrayDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetFloatArray");

		// Token: 0x0400299C RID: 10652
		private static readonly RayTracingShader.SetIntArrayDelegate SetIntArrayDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetIntArrayDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetIntArray");

		// Token: 0x0400299D RID: 10653
		private static readonly RayTracingShader.SetVectorArrayDelegate SetVectorArrayDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetVectorArrayDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetVectorArray");

		// Token: 0x0400299E RID: 10654
		private static readonly RayTracingShader.SetMatrixArrayDelegate SetMatrixArrayDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetMatrixArrayDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetMatrixArray");

		// Token: 0x0400299F RID: 10655
		private static readonly RayTracingShader.SetTextureDelegate SetTextureDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetTextureDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetTexture");

		// Token: 0x040029A0 RID: 10656
		private static readonly RayTracingShader.SetBufferDelegate SetBufferDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetBufferDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetBuffer");

		// Token: 0x040029A1 RID: 10657
		private static readonly RayTracingShader.SetGraphicsBufferDelegate SetGraphicsBufferDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetGraphicsBufferDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetGraphicsBuffer");

		// Token: 0x040029A2 RID: 10658
		private static readonly RayTracingShader.SetConstantComputeBufferDelegate SetConstantComputeBufferDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetConstantComputeBufferDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetConstantComputeBuffer");

		// Token: 0x040029A3 RID: 10659
		private static readonly RayTracingShader.SetConstantGraphicsBufferDelegate SetConstantGraphicsBufferDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetConstantGraphicsBufferDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetConstantGraphicsBuffer");

		// Token: 0x040029A4 RID: 10660
		private static readonly RayTracingShader.SetAccelerationStructureDelegate SetAccelerationStructureDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetAccelerationStructureDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetAccelerationStructure");

		// Token: 0x040029A5 RID: 10661
		private static readonly RayTracingShader.SetShaderPassDelegate SetShaderPassDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetShaderPassDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetShaderPass");

		// Token: 0x040029A6 RID: 10662
		private static readonly RayTracingShader.SetTextureFromGlobalDelegate SetTextureFromGlobalDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetTextureFromGlobalDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetTextureFromGlobal");

		// Token: 0x040029A7 RID: 10663
		private static readonly RayTracingShader.DispatchDelegate DispatchDelegateField = IL2CPP.ResolveICall<RayTracingShader.DispatchDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::Dispatch");

		// Token: 0x040029A8 RID: 10664
		private static readonly RayTracingShader.SetVector_InjectedDelegate SetVector_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetVector_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetVector_Injected");

		// Token: 0x040029A9 RID: 10665
		private static readonly RayTracingShader.SetMatrix_InjectedDelegate SetMatrix_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetMatrix_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetMatrix_Injected");

		// Token: 0x02000D2D RID: 3373
		// (Invoke) Token: 0x060042EF RID: 17135
		private delegate float get_maxRecursionDepthDelegate(IntPtr @this);

		// Token: 0x02000D2E RID: 3374
		// (Invoke) Token: 0x060042F1 RID: 17137
		private delegate void SetFloatDelegate(IntPtr @this, int nameID, float val);

		// Token: 0x02000D2F RID: 3375
		// (Invoke) Token: 0x060042F3 RID: 17139
		private delegate void SetIntDelegate(IntPtr @this, int nameID, int val);

		// Token: 0x02000D30 RID: 3376
		// (Invoke) Token: 0x060042F5 RID: 17141
		private delegate void SetFloatArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000D31 RID: 3377
		// (Invoke) Token: 0x060042F7 RID: 17143
		private delegate void SetIntArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000D32 RID: 3378
		// (Invoke) Token: 0x060042F9 RID: 17145
		private delegate void SetVectorArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000D33 RID: 3379
		// (Invoke) Token: 0x060042FB RID: 17147
		private delegate void SetMatrixArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000D34 RID: 3380
		// (Invoke) Token: 0x060042FD RID: 17149
		private delegate void SetTextureDelegate(IntPtr @this, int nameID, IntPtr texture);

		// Token: 0x02000D35 RID: 3381
		// (Invoke) Token: 0x060042FF RID: 17151
		private delegate void SetBufferDelegate(IntPtr @this, int nameID, IntPtr buffer);

		// Token: 0x02000D36 RID: 3382
		// (Invoke) Token: 0x06004301 RID: 17153
		private delegate void SetGraphicsBufferDelegate(IntPtr @this, int nameID, IntPtr buffer);

		// Token: 0x02000D37 RID: 3383
		// (Invoke) Token: 0x06004303 RID: 17155
		private delegate void SetConstantComputeBufferDelegate(IntPtr @this, int nameID, IntPtr buffer, int offset, int size);

		// Token: 0x02000D38 RID: 3384
		// (Invoke) Token: 0x06004305 RID: 17157
		private delegate void SetConstantGraphicsBufferDelegate(IntPtr @this, int nameID, IntPtr buffer, int offset, int size);

		// Token: 0x02000D39 RID: 3385
		// (Invoke) Token: 0x06004307 RID: 17159
		private delegate void SetAccelerationStructureDelegate(IntPtr @this, int nameID, IntPtr accelerationStructure);

		// Token: 0x02000D3A RID: 3386
		// (Invoke) Token: 0x06004309 RID: 17161
		private delegate void SetShaderPassDelegate(IntPtr @this, IntPtr passName);

		// Token: 0x02000D3B RID: 3387
		// (Invoke) Token: 0x0600430B RID: 17163
		private delegate void SetTextureFromGlobalDelegate(IntPtr @this, int nameID, int globalTextureNameID);

		// Token: 0x02000D3C RID: 3388
		// (Invoke) Token: 0x0600430D RID: 17165
		private delegate void DispatchDelegate(IntPtr @this, IntPtr rayGenFunctionName, int width, int height, int depth, IntPtr camera);

		// Token: 0x02000D3D RID: 3389
		// (Invoke) Token: 0x0600430F RID: 17167
		private delegate void SetVector_InjectedDelegate(IntPtr @this, int nameID, IntPtr val);

		// Token: 0x02000D3E RID: 3390
		// (Invoke) Token: 0x06004311 RID: 17169
		private delegate void SetMatrix_InjectedDelegate(IntPtr @this, int nameID, IntPtr val);
	}
}
