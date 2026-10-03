using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

namespace Unity.Profiling
{
	// Token: 0x02000019 RID: 25
	[StructLayout(2)]
	public struct ProfilerCategory
	{
		// Token: 0x0600009C RID: 156 RVA: 0x0001A658 File Offset: 0x00018858
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilerCategory()
		{
			Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", "ProfilerCategory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr);
			ProfilerCategory.NativeFieldInfoPtr_m_CategoryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, "m_CategoryId");
			ProfilerCategory.NativeMethodInfoPtr__ctor_Internal_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, 100663369);
			ProfilerCategory.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, 100663370);
			ProfilerCategory.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, 100663371);
			ProfilerCategory.NativeMethodInfoPtr_get_Scripts_Public_Static_get_ProfilerCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, 100663372);
			ProfilerCategory.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_ProfilerCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, 100663373);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0001A700 File Offset: 0x00018900
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389034, RefRangeEnd = 389035, XrefRangeStart = 389034, XrefRangeEnd = 389035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilerCategory(ushort category)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerCategory.NativeMethodInfoPtr__ctor_Internal_Void_UInt16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0001A734 File Offset: 0x00018934
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1225195, RefRangeEnd = 1225196, XrefRangeStart = 1225184, XrefRangeEnd = 1225195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerCategory.NativeMethodInfoPtr_get_Name_Public_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0001A760 File Offset: 0x00018960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225196, XrefRangeEnd = 1225197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerCategory.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0001A78C File Offset: 0x0001898C
		public unsafe static ProfilerCategory Scripts
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 70633, RefRangeEnd = 70636, XrefRangeStart = 70633, XrefRangeEnd = 70636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerCategory.NativeMethodInfoPtr_get_Scripts_Public_Static_get_ProfilerCategory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0001A7BC File Offset: 0x000189BC
		[CallerCount(0)]
		public unsafe static implicit operator ushort(ProfilerCategory category)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerCategory.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_ProfilerCategory_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002527 File Offset: 0x00000727
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerCategory>.NativeClassPtr, ref this));
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00002539 File Offset: 0x00000739
		public UnityEngine.Color32 Color
		{
			get
			{
				return Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.GetCategoryDescription(this.m_CategoryId).Color;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000254B File Offset: 0x0000074B
		public static ProfilerCategory Render
		{
			get
			{
				return new ProfilerCategory(0);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002553 File Offset: 0x00000753
		public static ProfilerCategory Gui
		{
			get
			{
				return new ProfilerCategory(4);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000255B File Offset: 0x0000075B
		public static ProfilerCategory Physics
		{
			get
			{
				return new ProfilerCategory(5);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00002563 File Offset: 0x00000763
		public static ProfilerCategory Physics2D
		{
			get
			{
				return new ProfilerCategory(33);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000256C File Offset: 0x0000076C
		public static ProfilerCategory Animation
		{
			get
			{
				return new ProfilerCategory(6);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00002574 File Offset: 0x00000774
		public static ProfilerCategory Ai
		{
			get
			{
				return new ProfilerCategory(7);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0000257C File Offset: 0x0000077C
		public static ProfilerCategory Audio
		{
			get
			{
				return new ProfilerCategory(8);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00002584 File Offset: 0x00000784
		public static ProfilerCategory Video
		{
			get
			{
				return new ProfilerCategory(11);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000258D File Offset: 0x0000078D
		public static ProfilerCategory Particles
		{
			get
			{
				return new ProfilerCategory(12);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00002596 File Offset: 0x00000796
		public static ProfilerCategory Lighting
		{
			get
			{
				return new ProfilerCategory(13);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000259F File Offset: 0x0000079F
		public static ProfilerCategory Network
		{
			get
			{
				return new ProfilerCategory(14);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000AF RID: 175 RVA: 0x000025A8 File Offset: 0x000007A8
		public static ProfilerCategory Loading
		{
			get
			{
				return new ProfilerCategory(15);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000025B1 File Offset: 0x000007B1
		public static ProfilerCategory Vr
		{
			get
			{
				return new ProfilerCategory(22);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x000025BA File Offset: 0x000007BA
		public static ProfilerCategory Input
		{
			get
			{
				return new ProfilerCategory(30);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000025C3 File Offset: 0x000007C3
		public static ProfilerCategory Memory
		{
			get
			{
				return new ProfilerCategory(23);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x000025CC File Offset: 0x000007CC
		public static ProfilerCategory VirtualTexturing
		{
			get
			{
				return new ProfilerCategory(31);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000025D5 File Offset: 0x000007D5
		public static ProfilerCategory FileIO
		{
			get
			{
				return new ProfilerCategory(25);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x000025DE File Offset: 0x000007DE
		public static ProfilerCategory Internal
		{
			get
			{
				return new ProfilerCategory(24);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x000025E7 File Offset: 0x000007E7
		public static ProfilerCategory Any
		{
			get
			{
				return new ProfilerCategory(ushort.MaxValue);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000025F3 File Offset: 0x000007F3
		public static ProfilerCategory GPU
		{
			get
			{
				return new ProfilerCategory(32);
			}
		}

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_m_CategoryId;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UInt16_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_get_Scripts_Public_Static_get_ProfilerCategory_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_ProfilerCategory_0;

		// Token: 0x04000073 RID: 115
		[FieldOffset(0)]
		public readonly ushort m_CategoryId;
	}
}
