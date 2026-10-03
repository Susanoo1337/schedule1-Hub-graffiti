using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x0200008C RID: 140
	public sealed class BillboardAsset : Object
	{
		// Token: 0x06000775 RID: 1909 RVA: 0x0002F1F8 File Offset: 0x0002D3F8
		// Note: this type is marked as 'beforefieldinit'.
		static BillboardAsset()
		{
			Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BillboardAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BillboardAsset>.NativeClassPtr);
			BillboardAsset.Internal_CreateDelegateField = IL2CPP.ResolveICall<BillboardAsset.Internal_CreateDelegate>("UnityEngine.BillboardAsset::Internal_Create");
			BillboardAsset.get_widthDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_widthDelegate>("UnityEngine.BillboardAsset::get_width");
			BillboardAsset.set_widthDelegateField = IL2CPP.ResolveICall<BillboardAsset.set_widthDelegate>("UnityEngine.BillboardAsset::set_width");
			BillboardAsset.get_heightDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_heightDelegate>("UnityEngine.BillboardAsset::get_height");
			BillboardAsset.set_heightDelegateField = IL2CPP.ResolveICall<BillboardAsset.set_heightDelegate>("UnityEngine.BillboardAsset::set_height");
			BillboardAsset.get_bottomDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_bottomDelegate>("UnityEngine.BillboardAsset::get_bottom");
			BillboardAsset.set_bottomDelegateField = IL2CPP.ResolveICall<BillboardAsset.set_bottomDelegate>("UnityEngine.BillboardAsset::set_bottom");
			BillboardAsset.get_imageCountDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_imageCountDelegate>("UnityEngine.BillboardAsset::get_imageCount");
			BillboardAsset.get_vertexCountDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_vertexCountDelegate>("UnityEngine.BillboardAsset::get_vertexCount");
			BillboardAsset.get_indexCountDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_indexCountDelegate>("UnityEngine.BillboardAsset::get_indexCount");
			BillboardAsset.get_materialDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_materialDelegate>("UnityEngine.BillboardAsset::get_material");
			BillboardAsset.set_materialDelegateField = IL2CPP.ResolveICall<BillboardAsset.set_materialDelegate>("UnityEngine.BillboardAsset::set_material");
			BillboardAsset.GetImageTexCoordsDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetImageTexCoordsDelegate>("UnityEngine.BillboardAsset::GetImageTexCoords");
			BillboardAsset.GetImageTexCoordsInternalDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetImageTexCoordsInternalDelegate>("UnityEngine.BillboardAsset::GetImageTexCoordsInternal");
			BillboardAsset.SetImageTexCoordsDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetImageTexCoordsDelegate>("UnityEngine.BillboardAsset::SetImageTexCoords");
			BillboardAsset.SetImageTexCoordsInternalListDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetImageTexCoordsInternalListDelegate>("UnityEngine.BillboardAsset::SetImageTexCoordsInternalList");
			BillboardAsset.GetVerticesDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetVerticesDelegate>("UnityEngine.BillboardAsset::GetVertices");
			BillboardAsset.GetVerticesInternalDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetVerticesInternalDelegate>("UnityEngine.BillboardAsset::GetVerticesInternal");
			BillboardAsset.SetVerticesDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetVerticesDelegate>("UnityEngine.BillboardAsset::SetVertices");
			BillboardAsset.SetVerticesInternalListDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetVerticesInternalListDelegate>("UnityEngine.BillboardAsset::SetVerticesInternalList");
			BillboardAsset.GetIndicesDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetIndicesDelegate>("UnityEngine.BillboardAsset::GetIndices");
			BillboardAsset.GetIndicesInternalDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetIndicesInternalDelegate>("UnityEngine.BillboardAsset::GetIndicesInternal");
			BillboardAsset.SetIndicesDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetIndicesDelegate>("UnityEngine.BillboardAsset::SetIndices");
			BillboardAsset.SetIndicesInternalListDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetIndicesInternalListDelegate>("UnityEngine.BillboardAsset::SetIndicesInternalList");
			BillboardAsset.MakeMaterialPropertiesDelegateField = IL2CPP.ResolveICall<BillboardAsset.MakeMaterialPropertiesDelegate>("UnityEngine.BillboardAsset::MakeMaterialProperties");
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00005409 File Offset: 0x00003609
		public BillboardAsset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00005412 File Offset: 0x00003612
		public static void Internal_Create(BillboardAsset obj)
		{
			BillboardAsset.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj));
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x00005424 File Offset: 0x00003624
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x00005436 File Offset: 0x00003636
		public float width
		{
			get
			{
				return BillboardAsset.get_widthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BillboardAsset.set_widthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x00005449 File Offset: 0x00003649
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x0000545B File Offset: 0x0000365B
		public float height
		{
			get
			{
				return BillboardAsset.get_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BillboardAsset.set_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x0000546E File Offset: 0x0000366E
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x00005480 File Offset: 0x00003680
		public float bottom
		{
			get
			{
				return BillboardAsset.get_bottomDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BillboardAsset.set_bottomDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x00005493 File Offset: 0x00003693
		public int imageCount
		{
			get
			{
				return BillboardAsset.get_imageCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x000054A5 File Offset: 0x000036A5
		public int vertexCount
		{
			get
			{
				return BillboardAsset.get_vertexCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x000054B7 File Offset: 0x000036B7
		public int indexCount
		{
			get
			{
				return BillboardAsset.get_indexCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x0002F3A0 File Offset: 0x0002D5A0
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x000054C9 File Offset: 0x000036C9
		public Material material
		{
			get
			{
				IntPtr intPtr = BillboardAsset.get_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				BillboardAsset.set_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0002F3CC File Offset: 0x0002D5CC
		public void GetImageTexCoords(List<Vector4> imageTexCoords)
		{
			bool flag = imageTexCoords == null;
			if (flag)
			{
				throw new ArgumentNullException("imageTexCoords");
			}
			this.GetImageTexCoordsInternal(imageTexCoords);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0002F3F8 File Offset: 0x0002D5F8
		public Il2CppStructArray<Vector4> GetImageTexCoords()
		{
			IntPtr intPtr = BillboardAsset.GetImageTexCoordsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x000054E1 File Offset: 0x000036E1
		public void GetImageTexCoordsInternal(Object list)
		{
			BillboardAsset.GetImageTexCoordsInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x0002F424 File Offset: 0x0002D624
		public void SetImageTexCoords(List<Vector4> imageTexCoords)
		{
			bool flag = imageTexCoords == null;
			if (flag)
			{
				throw new ArgumentNullException("imageTexCoords");
			}
			this.SetImageTexCoordsInternalList(imageTexCoords);
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x000054F9 File Offset: 0x000036F9
		public void SetImageTexCoords(Il2CppStructArray<Vector4> imageTexCoords)
		{
			BillboardAsset.SetImageTexCoordsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(imageTexCoords));
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00005511 File Offset: 0x00003711
		public void SetImageTexCoordsInternalList(Object list)
		{
			BillboardAsset.SetImageTexCoordsInternalListDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0002F450 File Offset: 0x0002D650
		public void GetVertices(List<Vector2> vertices)
		{
			bool flag = vertices == null;
			if (flag)
			{
				throw new ArgumentNullException("vertices");
			}
			this.GetVerticesInternal(vertices);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x0002F47C File Offset: 0x0002D67C
		public Il2CppStructArray<Vector2> GetVertices()
		{
			IntPtr intPtr = BillboardAsset.GetVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00005529 File Offset: 0x00003729
		public void GetVerticesInternal(Object list)
		{
			BillboardAsset.GetVerticesInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0002F4A8 File Offset: 0x0002D6A8
		public void SetVertices(List<Vector2> vertices)
		{
			bool flag = vertices == null;
			if (flag)
			{
				throw new ArgumentNullException("vertices");
			}
			this.SetVerticesInternalList(vertices);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00005541 File Offset: 0x00003741
		public void SetVertices(Il2CppStructArray<Vector2> vertices)
		{
			BillboardAsset.SetVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(vertices));
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00005559 File Offset: 0x00003759
		public void SetVerticesInternalList(Object list)
		{
			BillboardAsset.SetVerticesInternalListDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0002F4D4 File Offset: 0x0002D6D4
		public void GetIndices(List<ushort> indices)
		{
			bool flag = indices == null;
			if (flag)
			{
				throw new ArgumentNullException("indices");
			}
			this.GetIndicesInternal(indices);
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0002F500 File Offset: 0x0002D700
		public Il2CppStructArray<ushort> GetIndices()
		{
			IntPtr intPtr = BillboardAsset.GetIndicesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00005571 File Offset: 0x00003771
		public void GetIndicesInternal(Object list)
		{
			BillboardAsset.GetIndicesInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0002F52C File Offset: 0x0002D72C
		public void SetIndices(List<ushort> indices)
		{
			bool flag = indices == null;
			if (flag)
			{
				throw new ArgumentNullException("indices");
			}
			this.SetIndicesInternalList(indices);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00005589 File Offset: 0x00003789
		public void SetIndices(Il2CppStructArray<ushort> indices)
		{
			BillboardAsset.SetIndicesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(indices));
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x000055A1 File Offset: 0x000037A1
		public void SetIndicesInternalList(Object list)
		{
			BillboardAsset.SetIndicesInternalListDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x000055B9 File Offset: 0x000037B9
		public void MakeMaterialProperties(MaterialPropertyBlock properties, Camera camera)
		{
			BillboardAsset.MakeMaterialPropertiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(properties), IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x04000618 RID: 1560
		private static readonly BillboardAsset.Internal_CreateDelegate Internal_CreateDelegateField;

		// Token: 0x04000619 RID: 1561
		private static readonly BillboardAsset.get_widthDelegate get_widthDelegateField;

		// Token: 0x0400061A RID: 1562
		private static readonly BillboardAsset.set_widthDelegate set_widthDelegateField;

		// Token: 0x0400061B RID: 1563
		private static readonly BillboardAsset.get_heightDelegate get_heightDelegateField;

		// Token: 0x0400061C RID: 1564
		private static readonly BillboardAsset.set_heightDelegate set_heightDelegateField;

		// Token: 0x0400061D RID: 1565
		private static readonly BillboardAsset.get_bottomDelegate get_bottomDelegateField;

		// Token: 0x0400061E RID: 1566
		private static readonly BillboardAsset.set_bottomDelegate set_bottomDelegateField;

		// Token: 0x0400061F RID: 1567
		private static readonly BillboardAsset.get_imageCountDelegate get_imageCountDelegateField;

		// Token: 0x04000620 RID: 1568
		private static readonly BillboardAsset.get_vertexCountDelegate get_vertexCountDelegateField;

		// Token: 0x04000621 RID: 1569
		private static readonly BillboardAsset.get_indexCountDelegate get_indexCountDelegateField;

		// Token: 0x04000622 RID: 1570
		private static readonly BillboardAsset.get_materialDelegate get_materialDelegateField;

		// Token: 0x04000623 RID: 1571
		private static readonly BillboardAsset.set_materialDelegate set_materialDelegateField;

		// Token: 0x04000624 RID: 1572
		private static readonly BillboardAsset.GetImageTexCoordsDelegate GetImageTexCoordsDelegateField;

		// Token: 0x04000625 RID: 1573
		private static readonly BillboardAsset.GetImageTexCoordsInternalDelegate GetImageTexCoordsInternalDelegateField;

		// Token: 0x04000626 RID: 1574
		private static readonly BillboardAsset.SetImageTexCoordsDelegate SetImageTexCoordsDelegateField;

		// Token: 0x04000627 RID: 1575
		private static readonly BillboardAsset.SetImageTexCoordsInternalListDelegate SetImageTexCoordsInternalListDelegateField;

		// Token: 0x04000628 RID: 1576
		private static readonly BillboardAsset.GetVerticesDelegate GetVerticesDelegateField;

		// Token: 0x04000629 RID: 1577
		private static readonly BillboardAsset.GetVerticesInternalDelegate GetVerticesInternalDelegateField;

		// Token: 0x0400062A RID: 1578
		private static readonly BillboardAsset.SetVerticesDelegate SetVerticesDelegateField;

		// Token: 0x0400062B RID: 1579
		private static readonly BillboardAsset.SetVerticesInternalListDelegate SetVerticesInternalListDelegateField;

		// Token: 0x0400062C RID: 1580
		private static readonly BillboardAsset.GetIndicesDelegate GetIndicesDelegateField;

		// Token: 0x0400062D RID: 1581
		private static readonly BillboardAsset.GetIndicesInternalDelegate GetIndicesInternalDelegateField;

		// Token: 0x0400062E RID: 1582
		private static readonly BillboardAsset.SetIndicesDelegate SetIndicesDelegateField;

		// Token: 0x0400062F RID: 1583
		private static readonly BillboardAsset.SetIndicesInternalListDelegate SetIndicesInternalListDelegateField;

		// Token: 0x04000630 RID: 1584
		private static readonly BillboardAsset.MakeMaterialPropertiesDelegate MakeMaterialPropertiesDelegateField;

		// Token: 0x020004F6 RID: 1270
		// (Invoke) Token: 0x060032A1 RID: 12961
		private delegate void Internal_CreateDelegate(IntPtr obj);

		// Token: 0x020004F7 RID: 1271
		// (Invoke) Token: 0x060032A3 RID: 12963
		private delegate float get_widthDelegate(IntPtr @this);

		// Token: 0x020004F8 RID: 1272
		// (Invoke) Token: 0x060032A5 RID: 12965
		private delegate void set_widthDelegate(IntPtr @this, float value);

		// Token: 0x020004F9 RID: 1273
		// (Invoke) Token: 0x060032A7 RID: 12967
		private delegate float get_heightDelegate(IntPtr @this);

		// Token: 0x020004FA RID: 1274
		// (Invoke) Token: 0x060032A9 RID: 12969
		private delegate void set_heightDelegate(IntPtr @this, float value);

		// Token: 0x020004FB RID: 1275
		// (Invoke) Token: 0x060032AB RID: 12971
		private delegate float get_bottomDelegate(IntPtr @this);

		// Token: 0x020004FC RID: 1276
		// (Invoke) Token: 0x060032AD RID: 12973
		private delegate void set_bottomDelegate(IntPtr @this, float value);

		// Token: 0x020004FD RID: 1277
		// (Invoke) Token: 0x060032AF RID: 12975
		private delegate int get_imageCountDelegate(IntPtr @this);

		// Token: 0x020004FE RID: 1278
		// (Invoke) Token: 0x060032B1 RID: 12977
		private delegate int get_vertexCountDelegate(IntPtr @this);

		// Token: 0x020004FF RID: 1279
		// (Invoke) Token: 0x060032B3 RID: 12979
		private delegate int get_indexCountDelegate(IntPtr @this);

		// Token: 0x02000500 RID: 1280
		// (Invoke) Token: 0x060032B5 RID: 12981
		private delegate IntPtr get_materialDelegate(IntPtr @this);

		// Token: 0x02000501 RID: 1281
		// (Invoke) Token: 0x060032B7 RID: 12983
		private delegate void set_materialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000502 RID: 1282
		// (Invoke) Token: 0x060032B9 RID: 12985
		private delegate IntPtr GetImageTexCoordsDelegate(IntPtr @this);

		// Token: 0x02000503 RID: 1283
		// (Invoke) Token: 0x060032BB RID: 12987
		private delegate void GetImageTexCoordsInternalDelegate(IntPtr @this, IntPtr list);

		// Token: 0x02000504 RID: 1284
		// (Invoke) Token: 0x060032BD RID: 12989
		private delegate void SetImageTexCoordsDelegate(IntPtr @this, IntPtr imageTexCoords);

		// Token: 0x02000505 RID: 1285
		// (Invoke) Token: 0x060032BF RID: 12991
		private delegate void SetImageTexCoordsInternalListDelegate(IntPtr @this, IntPtr list);

		// Token: 0x02000506 RID: 1286
		// (Invoke) Token: 0x060032C1 RID: 12993
		private delegate IntPtr GetVerticesDelegate(IntPtr @this);

		// Token: 0x02000507 RID: 1287
		// (Invoke) Token: 0x060032C3 RID: 12995
		private delegate void GetVerticesInternalDelegate(IntPtr @this, IntPtr list);

		// Token: 0x02000508 RID: 1288
		// (Invoke) Token: 0x060032C5 RID: 12997
		private delegate void SetVerticesDelegate(IntPtr @this, IntPtr vertices);

		// Token: 0x02000509 RID: 1289
		// (Invoke) Token: 0x060032C7 RID: 12999
		private delegate void SetVerticesInternalListDelegate(IntPtr @this, IntPtr list);

		// Token: 0x0200050A RID: 1290
		// (Invoke) Token: 0x060032C9 RID: 13001
		private delegate IntPtr GetIndicesDelegate(IntPtr @this);

		// Token: 0x0200050B RID: 1291
		// (Invoke) Token: 0x060032CB RID: 13003
		private delegate void GetIndicesInternalDelegate(IntPtr @this, IntPtr list);

		// Token: 0x0200050C RID: 1292
		// (Invoke) Token: 0x060032CD RID: 13005
		private delegate void SetIndicesDelegate(IntPtr @this, IntPtr indices);

		// Token: 0x0200050D RID: 1293
		// (Invoke) Token: 0x060032CF RID: 13007
		private delegate void SetIndicesInternalListDelegate(IntPtr @this, IntPtr list);

		// Token: 0x0200050E RID: 1294
		// (Invoke) Token: 0x060032D1 RID: 13009
		private delegate void MakeMaterialPropertiesDelegate(IntPtr @this, IntPtr properties, IntPtr camera);
	}
}
