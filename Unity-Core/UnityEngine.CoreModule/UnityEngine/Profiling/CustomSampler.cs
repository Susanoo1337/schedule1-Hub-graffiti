using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Unity.Profiling.LowLevel.Unsafe;

namespace UnityEngine.Profiling
{
	// Token: 0x02000181 RID: 385
	public sealed class CustomSampler : Sampler
	{
		// Token: 0x06001DC3 RID: 7619 RVA: 0x00079F00 File Offset: 0x00078100
		// Note: this type is marked as 'beforefieldinit'.
		static CustomSampler()
		{
			Il2CppClassPointerStore<CustomSampler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Profiling", "CustomSampler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomSampler>.NativeClassPtr);
			CustomSampler.NativeFieldInfoPtr_s_InvalidCustomSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSampler>.NativeClassPtr, "s_InvalidCustomSampler");
			CustomSampler.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSampler>.NativeClassPtr, 100666470);
			CustomSampler.NativeMethodInfoPtr_Create_Public_Static_CustomSampler_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSampler>.NativeClassPtr, 100666472);
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x00079F6C File Offset: 0x0007816C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282390, XrefRangeEnd = 1282398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomSampler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomSampler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSampler.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x00079FA8 File Offset: 0x000781A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1282407, RefRangeEnd = 1282412, XrefRangeStart = 1282398, XrefRangeEnd = 1282407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CustomSampler Create(string name, bool collectGpuData = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref collectGpuData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomSampler.NativeMethodInfoPtr_Create_Public_Static_CustomSampler_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomSampler>(intPtr3) : null;
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x0000E030 File Offset: 0x0000C230
		public CustomSampler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x00079FFC File Offset: 0x000781FC
		// (set) Token: 0x06001DC8 RID: 7624 RVA: 0x0000E039 File Offset: 0x0000C239
		public unsafe static CustomSampler s_InvalidCustomSampler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CustomSampler.NativeFieldInfoPtr_s_InvalidCustomSampler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CustomSampler.NativeFieldInfoPtr_s_InvalidCustomSampler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x0000E04B File Offset: 0x0000C24B
		public void Begin()
		{
			Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.BeginSample(base.m_Ptr);
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x0000E05A File Offset: 0x0000C25A
		public void Begin(Object targetObject)
		{
			Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.Internal_BeginWithObject(base.m_Ptr, targetObject);
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x0000E06A File Offset: 0x0000C26A
		public void End()
		{
			Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.EndSample(base.m_Ptr);
		}

		// Token: 0x04001850 RID: 6224
		private static readonly IntPtr NativeFieldInfoPtr_s_InvalidCustomSampler;

		// Token: 0x04001851 RID: 6225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001852 RID: 6226
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_CustomSampler_String_Boolean_0;
	}
}
