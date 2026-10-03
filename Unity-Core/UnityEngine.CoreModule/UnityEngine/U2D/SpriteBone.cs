using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.U2D
{
	// Token: 0x02000179 RID: 377
	[Serializable]
	public sealed class SpriteBone : ValueType
	{
		// Token: 0x06001D06 RID: 7430 RVA: 0x000784A0 File Offset: 0x000766A0
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteBone()
		{
			Il2CppClassPointerStore<SpriteBone>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "SpriteBone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr);
			SpriteBone.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_Name");
			SpriteBone.NativeFieldInfoPtr_m_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_Guid");
			SpriteBone.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_Position");
			SpriteBone.NativeFieldInfoPtr_m_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_Rotation");
			SpriteBone.NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_Length");
			SpriteBone.NativeFieldInfoPtr_m_ParentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_ParentId");
			SpriteBone.NativeFieldInfoPtr_m_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, "m_Color");
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x0000DA30 File Offset: 0x0000BC30
		public SpriteBone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x0000DA39 File Offset: 0x0000BC39
		public SpriteBone() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr))
		{
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x0007855C File Offset: 0x0007675C
		// (set) Token: 0x06001D0A RID: 7434 RVA: 0x0000DA4B File Offset: 0x0000BC4B
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x00078584 File Offset: 0x00076784
		// (set) Token: 0x06001D0C RID: 7436 RVA: 0x0000DA6A File Offset: 0x0000BC6A
		public unsafe string m_Guid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Guid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x000785AC File Offset: 0x000767AC
		// (set) Token: 0x06001D0E RID: 7438 RVA: 0x0000DA89 File Offset: 0x0000BC89
		public unsafe Vector3 m_Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Position)) = value;
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x000785D4 File Offset: 0x000767D4
		// (set) Token: 0x06001D10 RID: 7440 RVA: 0x0000DAA4 File Offset: 0x0000BCA4
		public unsafe Quaternion m_Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Rotation)) = value;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x000785FC File Offset: 0x000767FC
		// (set) Token: 0x06001D12 RID: 7442 RVA: 0x0000DABF File Offset: 0x0000BCBF
		public unsafe float m_Length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Length)) = value;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x00078624 File Offset: 0x00076824
		// (set) Token: 0x06001D14 RID: 7444 RVA: 0x0000DADA File Offset: 0x0000BCDA
		public unsafe int m_ParentId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_ParentId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_ParentId)) = value;
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x0007864C File Offset: 0x0007684C
		// (set) Token: 0x06001D16 RID: 7446 RVA: 0x0000DAF5 File Offset: 0x0000BCF5
		public unsafe Color32 m_Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Color)) = value;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x00078674 File Offset: 0x00076874
		// (set) Token: 0x06001D18 RID: 7448 RVA: 0x0000DB10 File Offset: 0x0000BD10
		public string name
		{
			get
			{
				return this.m_Name;
			}
			set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x0007868C File Offset: 0x0007688C
		// (set) Token: 0x06001D1A RID: 7450 RVA: 0x0000DB1A File Offset: 0x0000BD1A
		public string guid
		{
			get
			{
				return this.m_Guid;
			}
			set
			{
				this.m_Guid = value;
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x000786A4 File Offset: 0x000768A4
		// (set) Token: 0x06001D1C RID: 7452 RVA: 0x0000DB24 File Offset: 0x0000BD24
		public Vector3 position
		{
			get
			{
				return this.m_Position;
			}
			set
			{
				this.m_Position = value;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x000786BC File Offset: 0x000768BC
		// (set) Token: 0x06001D1E RID: 7454 RVA: 0x0000DB2E File Offset: 0x0000BD2E
		public Quaternion rotation
		{
			get
			{
				return this.m_Rotation;
			}
			set
			{
				this.m_Rotation = value;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x000786D4 File Offset: 0x000768D4
		// (set) Token: 0x06001D20 RID: 7456 RVA: 0x0000DB38 File Offset: 0x0000BD38
		public float length
		{
			get
			{
				return this.m_Length;
			}
			set
			{
				this.m_Length = value;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x000786EC File Offset: 0x000768EC
		// (set) Token: 0x06001D22 RID: 7458 RVA: 0x0000DB42 File Offset: 0x0000BD42
		public int parentId
		{
			get
			{
				return this.m_ParentId;
			}
			set
			{
				this.m_ParentId = value;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x00078704 File Offset: 0x00076904
		// (set) Token: 0x06001D24 RID: 7460 RVA: 0x0000DB4C File Offset: 0x0000BD4C
		public Color32 color
		{
			get
			{
				return this.m_Color;
			}
			set
			{
				this.m_Color = value;
			}
		}

		// Token: 0x040017E8 RID: 6120
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x040017E9 RID: 6121
		private static readonly IntPtr NativeFieldInfoPtr_m_Guid;

		// Token: 0x040017EA RID: 6122
		private static readonly IntPtr NativeFieldInfoPtr_m_Position;

		// Token: 0x040017EB RID: 6123
		private static readonly IntPtr NativeFieldInfoPtr_m_Rotation;

		// Token: 0x040017EC RID: 6124
		private static readonly IntPtr NativeFieldInfoPtr_m_Length;

		// Token: 0x040017ED RID: 6125
		private static readonly IntPtr NativeFieldInfoPtr_m_ParentId;

		// Token: 0x040017EE RID: 6126
		private static readonly IntPtr NativeFieldInfoPtr_m_Color;
	}
}
