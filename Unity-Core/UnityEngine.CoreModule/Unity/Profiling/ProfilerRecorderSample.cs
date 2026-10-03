using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Profiling
{
	// Token: 0x0200001F RID: 31
	[StructLayout(2)]
	public struct ProfilerRecorderSample
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x0001A928 File Offset: 0x00018B28
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilerRecorderSample()
		{
			Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", "ProfilerRecorderSample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr);
			ProfilerRecorderSample.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr, "value");
			ProfilerRecorderSample.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr, "count");
			ProfilerRecorderSample.NativeFieldInfoPtr_refValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr, "refValue");
			ProfilerRecorderSample.NativeMethodInfoPtr_get_Count_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr, 100663379);
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0001A9A8 File Offset: 0x00018BA8
		public unsafe long Count
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 29707, RefRangeEnd = 29711, XrefRangeStart = 29707, XrefRangeEnd = 29711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderSample.NativeMethodInfoPtr_get_Count_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002654 File Offset: 0x00000854
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerRecorderSample>.NativeClassPtr, ref this));
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00002666 File Offset: 0x00000866
		public long Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr_refValue;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int64_0;

		// Token: 0x040000A3 RID: 163
		[FieldOffset(0)]
		public long value;

		// Token: 0x040000A4 RID: 164
		[FieldOffset(8)]
		public long count;

		// Token: 0x040000A5 RID: 165
		[FieldOffset(16)]
		public long refValue;
	}
}
