using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Unity.Profiling.LowLevel.Unsafe
{
	// Token: 0x02000027 RID: 39
	[StructLayout(2)]
	public struct ProfilerCategoryDescription
	{
		// Token: 0x06000133 RID: 307 RVA: 0x0001BBA4 File Offset: 0x00019DA4
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilerCategoryDescription()
		{
			Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.LowLevel.Unsafe", "ProfilerCategoryDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr);
			ProfilerCategoryDescription.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, "Id");
			ProfilerCategoryDescription.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, "Flags");
			ProfilerCategoryDescription.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, "Color");
			ProfilerCategoryDescription.NativeFieldInfoPtr_reserved0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, "reserved0");
			ProfilerCategoryDescription.NativeFieldInfoPtr_NameUtf8Len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, "NameUtf8Len");
			ProfilerCategoryDescription.NativeFieldInfoPtr_NameUtf8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, "NameUtf8");
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002929 File Offset: 0x00000B29
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, ref this));
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0000293B File Offset: 0x00000B3B
		public string Name
		{
			get
			{
				return ProfilerUnsafeUtility.Utf8ToString(this.NameUtf8, this.NameUtf8Len);
			}
		}

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr_Flags;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeFieldInfoPtr_reserved0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeFieldInfoPtr_NameUtf8Len;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeFieldInfoPtr_NameUtf8;

		// Token: 0x04000108 RID: 264
		[FieldOffset(0)]
		public readonly ushort Id;

		// Token: 0x04000109 RID: 265
		[FieldOffset(2)]
		public readonly ushort Flags;

		// Token: 0x0400010A RID: 266
		[FieldOffset(4)]
		public readonly UnityEngine.Color32 Color;

		// Token: 0x0400010B RID: 267
		[FieldOffset(8)]
		public readonly int reserved0;

		// Token: 0x0400010C RID: 268
		[FieldOffset(12)]
		public readonly int NameUtf8Len;

		// Token: 0x0400010D RID: 269
		[FieldOffset(16)]
		public readonly IntPtr NameUtf8;
	}
}
