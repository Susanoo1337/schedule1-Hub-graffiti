using System;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200030C RID: 780
	public struct SnapAxisFilter
	{
		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06002D64 RID: 11620 RVA: 0x000AC410 File Offset: 0x000AA610
		public float x
		{
			get
			{
				return ((this.m_Mask & SnapAxis.X) == SnapAxis.X) ? 1f : 0f;
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06002D65 RID: 11621 RVA: 0x000AC43C File Offset: 0x000AA63C
		public float y
		{
			get
			{
				return ((this.m_Mask & SnapAxis.Y) == SnapAxis.Y) ? 1f : 0f;
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06002D66 RID: 11622 RVA: 0x000AC468 File Offset: 0x000AA668
		public float z
		{
			get
			{
				return ((this.m_Mask & SnapAxis.Z) == SnapAxis.Z) ? 1f : 0f;
			}
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x000AC494 File Offset: 0x000AA694
		public override string ToString()
		{
			return String.Format("{{{0}, {1}, {2}}}", this.x, this.y, this.z);
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06002D68 RID: 11624 RVA: 0x000AC4D4 File Offset: 0x000AA6D4
		public int active
		{
			get
			{
				int num = 0;
				bool flag = (this.m_Mask & SnapAxis.X) > SnapAxis.None;
				if (flag)
				{
					num++;
				}
				bool flag2 = (this.m_Mask & SnapAxis.Y) > SnapAxis.None;
				if (flag2)
				{
					num++;
				}
				bool flag3 = (this.m_Mask & SnapAxis.Z) > SnapAxis.None;
				if (flag3)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x000AC524 File Offset: 0x000AA724
		public static implicit operator Vector3(SnapAxisFilter mask)
		{
			return new Vector3(mask.x, mask.y, mask.z);
		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x000AC550 File Offset: 0x000AA750
		public static explicit operator SnapAxisFilter(Vector3 v)
		{
			return new SnapAxisFilter(v);
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x000AC568 File Offset: 0x000AA768
		public static explicit operator SnapAxis(SnapAxisFilter mask)
		{
			return mask.m_Mask;
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x000AC580 File Offset: 0x000AA780
		public static SnapAxisFilter operator |(SnapAxisFilter left, SnapAxisFilter right)
		{
			return new SnapAxisFilter(left.m_Mask | right.m_Mask);
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x000AC5A4 File Offset: 0x000AA7A4
		public static SnapAxisFilter operator &(SnapAxisFilter left, SnapAxisFilter right)
		{
			return new SnapAxisFilter(left.m_Mask & right.m_Mask);
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x000AC5C8 File Offset: 0x000AA7C8
		public static SnapAxisFilter operator ^(SnapAxisFilter left, SnapAxisFilter right)
		{
			return new SnapAxisFilter(left.m_Mask ^ right.m_Mask);
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x000AC5EC File Offset: 0x000AA7EC
		public static SnapAxisFilter operator ~(SnapAxisFilter left)
		{
			return new SnapAxisFilter(~left.m_Mask);
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x000AC60C File Offset: 0x000AA80C
		public static Vector3 operator *(SnapAxisFilter mask, float value)
		{
			return new Vector3(mask.x * value, mask.y * value, mask.z * value);
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x000AC640 File Offset: 0x000AA840
		public static Vector3 operator *(SnapAxisFilter mask, Vector3 right)
		{
			return new Vector3(mask.x * right.x, mask.y * right.y, mask.z * right.z);
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x000AC684 File Offset: 0x000AA884
		public static Vector3 operator *(Quaternion rotation, SnapAxisFilter mask)
		{
			int active = mask.active;
			bool flag = active > 2;
			Vector3 result;
			if (flag)
			{
				result = mask;
			}
			else
			{
				Vector3 vector = rotation * mask;
				vector = new Vector3(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z));
				bool flag2 = active > 1;
				if (flag2)
				{
					result = new Vector3((float)((vector.x > vector.y || vector.x > vector.z) ? 1 : 0), (float)((vector.y > vector.x || vector.y > vector.z) ? 1 : 0), (float)((vector.z > vector.x || vector.z > vector.y) ? 1 : 0));
				}
				else
				{
					result = new Vector3((float)((vector.x > vector.y && vector.x > vector.z) ? 1 : 0), (float)((vector.y > vector.z && vector.y > vector.x) ? 1 : 0), (float)((vector.z > vector.x && vector.z > vector.y) ? 1 : 0));
				}
			}
			return result;
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x000AC7C8 File Offset: 0x000AA9C8
		public static bool operator ==(SnapAxisFilter left, SnapAxisFilter right)
		{
			return left.m_Mask == right.m_Mask;
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x000AC7E8 File Offset: 0x000AA9E8
		public static bool operator !=(SnapAxisFilter left, SnapAxisFilter right)
		{
			return !(left == right);
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06002D75 RID: 11637 RVA: 0x000AC804 File Offset: 0x000AAA04
		// (set) Token: 0x06002D76 RID: 11638 RVA: 0x000AC840 File Offset: 0x000AAA40
		public float Item
		{
			get
			{
				bool flag = i < 0 || i > 2;
				if (flag)
				{
					throw new IndexOutOfRangeException();
				}
				return (float)(SnapAxis.X & this.m_Mask >> (i & 31)) * 1f;
			}
			set
			{
				bool flag = i < 0 || i > 2;
				if (flag)
				{
					throw new IndexOutOfRangeException();
				}
				this.m_Mask &= (SnapAxis)(~(SnapAxis)(1 << i));
				this.m_Mask |= (SnapAxis)(((value > 0f) ? 1 : 0) << (i & 31));
			}
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x000AC898 File Offset: 0x000AAA98
		public bool Equals(SnapAxisFilter other)
		{
			return this.m_Mask == other.m_Mask;
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x000AC8B8 File Offset: 0x000AAAB8
		public override bool Equals(Object obj)
		{
			bool flag = obj == null;
			return !flag && obj is SnapAxisFilter && this.Equals((SnapAxisFilter)obj);
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x000AC8F0 File Offset: 0x000AAAF0
		public override int GetHashCode()
		{
			return this.m_Mask.GetHashCode();
		}

		// Token: 0x04002827 RID: 10279
		public const SnapAxis X = SnapAxis.X;

		// Token: 0x04002828 RID: 10280
		public const SnapAxis Y = SnapAxis.Y;

		// Token: 0x04002829 RID: 10281
		public const SnapAxis Z = SnapAxis.Z;

		// Token: 0x0400282A RID: 10282
		public SnapAxis m_Mask;
	}
}
