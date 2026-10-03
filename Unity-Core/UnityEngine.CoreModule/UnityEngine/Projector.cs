using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x020002D3 RID: 723
	public sealed class Projector : Behaviour
	{
		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06002D02 RID: 11522 RVA: 0x00013CB7 File Offset: 0x00011EB7
		// (set) Token: 0x06002D03 RID: 11523 RVA: 0x00013CC9 File Offset: 0x00011EC9
		public float nearClipPlane
		{
			get
			{
				return Projector.get_nearClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_nearClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06002D04 RID: 11524 RVA: 0x00013CDC File Offset: 0x00011EDC
		// (set) Token: 0x06002D05 RID: 11525 RVA: 0x00013CEE File Offset: 0x00011EEE
		public float farClipPlane
		{
			get
			{
				return Projector.get_farClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_farClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06002D06 RID: 11526 RVA: 0x00013D01 File Offset: 0x00011F01
		// (set) Token: 0x06002D07 RID: 11527 RVA: 0x00013D13 File Offset: 0x00011F13
		public float fieldOfView
		{
			get
			{
				return Projector.get_fieldOfViewDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_fieldOfViewDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06002D08 RID: 11528 RVA: 0x00013D26 File Offset: 0x00011F26
		// (set) Token: 0x06002D09 RID: 11529 RVA: 0x00013D38 File Offset: 0x00011F38
		public float aspectRatio
		{
			get
			{
				return Projector.get_aspectRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_aspectRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06002D0A RID: 11530 RVA: 0x00013D4B File Offset: 0x00011F4B
		// (set) Token: 0x06002D0B RID: 11531 RVA: 0x00013D5D File Offset: 0x00011F5D
		public bool orthographic
		{
			get
			{
				return Projector.get_orthographicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_orthographicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06002D0C RID: 11532 RVA: 0x00013D70 File Offset: 0x00011F70
		// (set) Token: 0x06002D0D RID: 11533 RVA: 0x00013D82 File Offset: 0x00011F82
		public float orthographicSize
		{
			get
			{
				return Projector.get_orthographicSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_orthographicSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06002D0E RID: 11534 RVA: 0x00013D95 File Offset: 0x00011F95
		// (set) Token: 0x06002D0F RID: 11535 RVA: 0x00013DA7 File Offset: 0x00011FA7
		public int ignoreLayers
		{
			get
			{
				return Projector.get_ignoreLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_ignoreLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06002D10 RID: 11536 RVA: 0x000ABE1C File Offset: 0x000AA01C
		// (set) Token: 0x06002D11 RID: 11537 RVA: 0x00013DBA File Offset: 0x00011FBA
		public Material material
		{
			get
			{
				IntPtr intPtr = Projector.get_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				Projector.set_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002742 RID: 10050
		private static readonly Projector.get_nearClipPlaneDelegate get_nearClipPlaneDelegateField = IL2CPP.ResolveICall<Projector.get_nearClipPlaneDelegate>("UnityEngine.Projector::get_nearClipPlane");

		// Token: 0x04002743 RID: 10051
		private static readonly Projector.set_nearClipPlaneDelegate set_nearClipPlaneDelegateField = IL2CPP.ResolveICall<Projector.set_nearClipPlaneDelegate>("UnityEngine.Projector::set_nearClipPlane");

		// Token: 0x04002744 RID: 10052
		private static readonly Projector.get_farClipPlaneDelegate get_farClipPlaneDelegateField = IL2CPP.ResolveICall<Projector.get_farClipPlaneDelegate>("UnityEngine.Projector::get_farClipPlane");

		// Token: 0x04002745 RID: 10053
		private static readonly Projector.set_farClipPlaneDelegate set_farClipPlaneDelegateField = IL2CPP.ResolveICall<Projector.set_farClipPlaneDelegate>("UnityEngine.Projector::set_farClipPlane");

		// Token: 0x04002746 RID: 10054
		private static readonly Projector.get_fieldOfViewDelegate get_fieldOfViewDelegateField = IL2CPP.ResolveICall<Projector.get_fieldOfViewDelegate>("UnityEngine.Projector::get_fieldOfView");

		// Token: 0x04002747 RID: 10055
		private static readonly Projector.set_fieldOfViewDelegate set_fieldOfViewDelegateField = IL2CPP.ResolveICall<Projector.set_fieldOfViewDelegate>("UnityEngine.Projector::set_fieldOfView");

		// Token: 0x04002748 RID: 10056
		private static readonly Projector.get_aspectRatioDelegate get_aspectRatioDelegateField = IL2CPP.ResolveICall<Projector.get_aspectRatioDelegate>("UnityEngine.Projector::get_aspectRatio");

		// Token: 0x04002749 RID: 10057
		private static readonly Projector.set_aspectRatioDelegate set_aspectRatioDelegateField = IL2CPP.ResolveICall<Projector.set_aspectRatioDelegate>("UnityEngine.Projector::set_aspectRatio");

		// Token: 0x0400274A RID: 10058
		private static readonly Projector.get_orthographicDelegate get_orthographicDelegateField = IL2CPP.ResolveICall<Projector.get_orthographicDelegate>("UnityEngine.Projector::get_orthographic");

		// Token: 0x0400274B RID: 10059
		private static readonly Projector.set_orthographicDelegate set_orthographicDelegateField = IL2CPP.ResolveICall<Projector.set_orthographicDelegate>("UnityEngine.Projector::set_orthographic");

		// Token: 0x0400274C RID: 10060
		private static readonly Projector.get_orthographicSizeDelegate get_orthographicSizeDelegateField = IL2CPP.ResolveICall<Projector.get_orthographicSizeDelegate>("UnityEngine.Projector::get_orthographicSize");

		// Token: 0x0400274D RID: 10061
		private static readonly Projector.set_orthographicSizeDelegate set_orthographicSizeDelegateField = IL2CPP.ResolveICall<Projector.set_orthographicSizeDelegate>("UnityEngine.Projector::set_orthographicSize");

		// Token: 0x0400274E RID: 10062
		private static readonly Projector.get_ignoreLayersDelegate get_ignoreLayersDelegateField = IL2CPP.ResolveICall<Projector.get_ignoreLayersDelegate>("UnityEngine.Projector::get_ignoreLayers");

		// Token: 0x0400274F RID: 10063
		private static readonly Projector.set_ignoreLayersDelegate set_ignoreLayersDelegateField = IL2CPP.ResolveICall<Projector.set_ignoreLayersDelegate>("UnityEngine.Projector::set_ignoreLayers");

		// Token: 0x04002750 RID: 10064
		private static readonly Projector.get_materialDelegate get_materialDelegateField = IL2CPP.ResolveICall<Projector.get_materialDelegate>("UnityEngine.Projector::get_material");

		// Token: 0x04002751 RID: 10065
		private static readonly Projector.set_materialDelegate set_materialDelegateField = IL2CPP.ResolveICall<Projector.set_materialDelegate>("UnityEngine.Projector::set_material");

		// Token: 0x02000C9E RID: 3230
		// (Invoke) Token: 0x060041D9 RID: 16857
		private delegate float get_nearClipPlaneDelegate(IntPtr @this);

		// Token: 0x02000C9F RID: 3231
		// (Invoke) Token: 0x060041DB RID: 16859
		private delegate void set_nearClipPlaneDelegate(IntPtr @this, float value);

		// Token: 0x02000CA0 RID: 3232
		// (Invoke) Token: 0x060041DD RID: 16861
		private delegate float get_farClipPlaneDelegate(IntPtr @this);

		// Token: 0x02000CA1 RID: 3233
		// (Invoke) Token: 0x060041DF RID: 16863
		private delegate void set_farClipPlaneDelegate(IntPtr @this, float value);

		// Token: 0x02000CA2 RID: 3234
		// (Invoke) Token: 0x060041E1 RID: 16865
		private delegate float get_fieldOfViewDelegate(IntPtr @this);

		// Token: 0x02000CA3 RID: 3235
		// (Invoke) Token: 0x060041E3 RID: 16867
		private delegate void set_fieldOfViewDelegate(IntPtr @this, float value);

		// Token: 0x02000CA4 RID: 3236
		// (Invoke) Token: 0x060041E5 RID: 16869
		private delegate float get_aspectRatioDelegate(IntPtr @this);

		// Token: 0x02000CA5 RID: 3237
		// (Invoke) Token: 0x060041E7 RID: 16871
		private delegate void set_aspectRatioDelegate(IntPtr @this, float value);

		// Token: 0x02000CA6 RID: 3238
		// (Invoke) Token: 0x060041E9 RID: 16873
		private delegate bool get_orthographicDelegate(IntPtr @this);

		// Token: 0x02000CA7 RID: 3239
		// (Invoke) Token: 0x060041EB RID: 16875
		private delegate void set_orthographicDelegate(IntPtr @this, bool value);

		// Token: 0x02000CA8 RID: 3240
		// (Invoke) Token: 0x060041ED RID: 16877
		private delegate float get_orthographicSizeDelegate(IntPtr @this);

		// Token: 0x02000CA9 RID: 3241
		// (Invoke) Token: 0x060041EF RID: 16879
		private delegate void set_orthographicSizeDelegate(IntPtr @this, float value);

		// Token: 0x02000CAA RID: 3242
		// (Invoke) Token: 0x060041F1 RID: 16881
		private delegate int get_ignoreLayersDelegate(IntPtr @this);

		// Token: 0x02000CAB RID: 3243
		// (Invoke) Token: 0x060041F3 RID: 16883
		private delegate void set_ignoreLayersDelegate(IntPtr @this, int value);

		// Token: 0x02000CAC RID: 3244
		// (Invoke) Token: 0x060041F5 RID: 16885
		private delegate IntPtr get_materialDelegate(IntPtr @this);

		// Token: 0x02000CAD RID: 3245
		// (Invoke) Token: 0x060041F7 RID: 16887
		private delegate void set_materialDelegate(IntPtr @this, IntPtr value);
	}
}
