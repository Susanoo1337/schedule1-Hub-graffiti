using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Profiling.LowLevel.Unsafe
{
	// Token: 0x02000025 RID: 37
	[StructLayout(2)]
	public struct ProfilerRecorderDescription
	{
		// Token: 0x06000119 RID: 281 RVA: 0x0001B720 File Offset: 0x00019920
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilerRecorderDescription()
		{
			Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.LowLevel.Unsafe", "ProfilerRecorderDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr);
			ProfilerRecorderDescription.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, "category");
			ProfilerRecorderDescription.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, "flags");
			ProfilerRecorderDescription.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, "dataType");
			ProfilerRecorderDescription.NativeFieldInfoPtr_unitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, "unitType");
			ProfilerRecorderDescription.NativeFieldInfoPtr_reserved0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, "reserved0");
			ProfilerRecorderDescription.NativeFieldInfoPtr_nameUtf8Len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, "nameUtf8Len");
			ProfilerRecorderDescription.NativeFieldInfoPtr_nameUtf8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, "nameUtf8");
			ProfilerRecorderDescription.NativeMethodInfoPtr_get_Flags_Public_get_MarkerFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, 100663408);
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600011A RID: 282 RVA: 0x0001B7F0 File Offset: 0x000199F0
		public unsafe MarkerFlags Flags
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderDescription.NativeMethodInfoPtr_get_Flags_Public_get_MarkerFlags_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002894 File Offset: 0x00000A94
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, ref this));
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600011C RID: 284 RVA: 0x000028A6 File Offset: 0x00000AA6
		public ProfilerCategory Category
		{
			get
			{
				return this.category;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600011D RID: 285 RVA: 0x000028AE File Offset: 0x00000AAE
		public ProfilerMarkerDataType DataType
		{
			get
			{
				return this.dataType;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600011E RID: 286 RVA: 0x000028B6 File Offset: 0x00000AB6
		public ProfilerMarkerDataUnit UnitType
		{
			get
			{
				return this.unitType;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600011F RID: 287 RVA: 0x000028BE File Offset: 0x00000ABE
		public int NameUtf8Len
		{
			get
			{
				return this.nameUtf8Len;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000120 RID: 288 RVA: 0x000028C6 File Offset: 0x00000AC6
		public unsafe byte* NameUtf8
		{
			get
			{
				return this.nameUtf8;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000121 RID: 289 RVA: 0x000028CE File Offset: 0x00000ACE
		public string Name
		{
			get
			{
				return ProfilerUnsafeUtility.Utf8ToString(this.nameUtf8, this.nameUtf8Len);
			}
		}

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeFieldInfoPtr_category;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeFieldInfoPtr_unitType;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr_reserved0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr_nameUtf8Len;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeFieldInfoPtr_nameUtf8;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_get_Flags_Public_get_MarkerFlags_0;

		// Token: 0x040000EE RID: 238
		[FieldOffset(0)]
		public readonly ProfilerCategory category;

		// Token: 0x040000EF RID: 239
		[FieldOffset(2)]
		public readonly MarkerFlags flags;

		// Token: 0x040000F0 RID: 240
		[FieldOffset(4)]
		public readonly ProfilerMarkerDataType dataType;

		// Token: 0x040000F1 RID: 241
		[FieldOffset(5)]
		public readonly ProfilerMarkerDataUnit unitType;

		// Token: 0x040000F2 RID: 242
		[FieldOffset(8)]
		public readonly int reserved0;

		// Token: 0x040000F3 RID: 243
		[FieldOffset(12)]
		public readonly int nameUtf8Len;

		// Token: 0x040000F4 RID: 244
		[FieldOffset(16)]
		public readonly IntPtr nameUtf8;
	}
}
