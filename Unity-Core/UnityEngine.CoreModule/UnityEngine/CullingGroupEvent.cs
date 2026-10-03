using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000078 RID: 120
	[StructLayout(2)]
	public struct CullingGroupEvent
	{
		// Token: 0x06000531 RID: 1329 RVA: 0x00027780 File Offset: 0x00025980
		// Note: this type is marked as 'beforefieldinit'.
		static CullingGroupEvent()
		{
			Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CullingGroupEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr);
			CullingGroupEvent.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, "m_Index");
			CullingGroupEvent.NativeFieldInfoPtr_m_PrevState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, "m_PrevState");
			CullingGroupEvent.NativeFieldInfoPtr_m_ThisState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, "m_ThisState");
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00004715 File Offset: 0x00002915
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, ref this));
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x000277EC File Offset: 0x000259EC
		public int index
		{
			get
			{
				return this.m_Index;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00027804 File Offset: 0x00025A04
		public bool isVisible
		{
			get
			{
				return (this.m_ThisState & 128) > 0;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00027828 File Offset: 0x00025A28
		public bool wasVisible
		{
			get
			{
				return (this.m_PrevState & 128) > 0;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x0002784C File Offset: 0x00025A4C
		public bool hasBecomeVisible
		{
			get
			{
				return this.isVisible && !this.wasVisible;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00027874 File Offset: 0x00025A74
		public bool hasBecomeInvisible
		{
			get
			{
				return !this.isVisible && this.wasVisible;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x00027898 File Offset: 0x00025A98
		public int currentDistance
		{
			get
			{
				return (int)(this.m_ThisState & 127);
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x000278B4 File Offset: 0x00025AB4
		public int previousDistance
		{
			get
			{
				return (int)(this.m_PrevState & 127);
			}
		}

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeFieldInfoPtr_m_Index;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevState;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeFieldInfoPtr_m_ThisState;

		// Token: 0x04000488 RID: 1160
		[FieldOffset(0)]
		public int m_Index;

		// Token: 0x04000489 RID: 1161
		[FieldOffset(4)]
		public byte m_PrevState;

		// Token: 0x0400048A RID: 1162
		[FieldOffset(5)]
		public byte m_ThisState;

		// Token: 0x0400048B RID: 1163
		public const byte kIsVisibleMask = 128;

		// Token: 0x0400048C RID: 1164
		public const byte kDistanceMask = 127;
	}
}
