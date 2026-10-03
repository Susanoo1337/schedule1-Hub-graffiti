using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling.LowLevel.Unsafe;

namespace UnityEngine.Profiling
{
	// Token: 0x02000180 RID: 384
	public class Sampler : Object
	{
		// Token: 0x06001DB7 RID: 7607 RVA: 0x00079C30 File Offset: 0x00077E30
		// Note: this type is marked as 'beforefieldinit'.
		static Sampler()
		{
			Il2CppClassPointerStore<Sampler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Profiling", "Sampler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sampler>.NativeClassPtr);
			Sampler.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "m_Ptr");
			Sampler.NativeFieldInfoPtr_s_InvalidSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sampler>.NativeClassPtr, "s_InvalidSampler");
			Sampler.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100666466);
			Sampler.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100666467);
			Sampler.NativeMethodInfoPtr_GetRecorder_Public_Recorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sampler>.NativeClassPtr, 100666468);
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x00079CC4 File Offset: 0x00077EC4
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sampler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sampler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x00079D00 File Offset: 0x00077F00
		public unsafe bool isValid
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1282374, RefRangeEnd = 1282376, XrefRangeStart = 1282373, XrefRangeEnd = 1282374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x00079D3C File Offset: 0x00077F3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1282386, RefRangeEnd = 1282390, XrefRangeStart = 1282376, XrefRangeEnd = 1282386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Recorder GetRecorder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sampler.NativeMethodInfoPtr_GetRecorder_Public_Recorder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Recorder>(intPtr3) : null;
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x0000DFFA File Offset: 0x0000C1FA
		public Sampler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001DBC RID: 7612 RVA: 0x00079D7C File Offset: 0x00077F7C
		// (set) Token: 0x06001DBD RID: 7613 RVA: 0x0000E003 File Offset: 0x0000C203
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sampler.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001DBE RID: 7614 RVA: 0x00079DA4 File Offset: 0x00077FA4
		// (set) Token: 0x06001DBF RID: 7615 RVA: 0x0000E01E File Offset: 0x0000C21E
		public unsafe static Sampler s_InvalidSampler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Sampler.NativeFieldInfoPtr_s_InvalidSampler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Sampler.NativeFieldInfoPtr_s_InvalidSampler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x00079DCC File Offset: 0x00077FCC
		public static Sampler Get(string name)
		{
			IntPtr marker = Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.GetMarker(name);
			bool flag = marker == IntPtr.Zero;
			Sampler result;
			if (flag)
			{
				result = Sampler.s_InvalidSampler;
			}
			else
			{
				result = new Sampler(marker);
			}
			return result;
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x00079E04 File Offset: 0x00078004
		public static int GetNames(List<string> names)
		{
			List<Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle> list = new List<Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle>();
			Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle.GetAvailable(list);
			bool flag = names != null;
			if (flag)
			{
				bool flag2 = names.Count < list.Count;
				if (flag2)
				{
					names.Capacity = list.Count;
					for (int i = names.Count; i < list.Count; i++)
					{
						names.Add(null);
					}
				}
				int num = 0;
				List<Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle>.Enumerator enumerator = list.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle = enumerator.Current;
						names[num] = Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle.GetDescription(handle).Name;
						num++;
					}
				}
				finally
				{
					enumerator.Dispose();
				}
			}
			return list.Count;
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x00079EE0 File Offset: 0x000780E0
		public string name
		{
			get
			{
				return Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.Internal_GetName(this.m_Ptr);
			}
		}

		// Token: 0x0400184B RID: 6219
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x0400184C RID: 6220
		private static readonly IntPtr NativeFieldInfoPtr_s_InvalidSampler;

		// Token: 0x0400184D RID: 6221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400184E RID: 6222
		private static readonly IntPtr NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0;

		// Token: 0x0400184F RID: 6223
		private static readonly IntPtr NativeMethodInfoPtr_GetRecorder_Public_Recorder_0;
	}
}
