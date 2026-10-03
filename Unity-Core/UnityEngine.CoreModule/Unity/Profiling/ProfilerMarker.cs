using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

namespace Unity.Profiling
{
	// Token: 0x0200001B RID: 27
	[StructLayout(2)]
	public struct ProfilerMarker
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x0001A7FC File Offset: 0x000189FC
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilerMarker()
		{
			Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", "ProfilerMarker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr);
			ProfilerMarker.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, "m_Ptr");
			ProfilerMarker.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, 100663374);
			ProfilerMarker.NativeMethodInfoPtr__ctor_Public_Void_ProfilerCategory_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, 100663375);
			ProfilerMarker.NativeMethodInfoPtr_Auto_Public_AutoScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, 100663376);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0001A87C File Offset: 0x00018A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225200, XrefRangeEnd = 1225202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilerMarker(string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerMarker.NativeMethodInfoPtr__ctor_Public_Void_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0001A8B4 File Offset: 0x00018AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225202, XrefRangeEnd = 1225204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilerMarker(ProfilerCategory category, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerMarker.NativeMethodInfoPtr__ctor_Public_Void_ProfilerCategory_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0001A8F8 File Offset: 0x00018AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225204, XrefRangeEnd = 1225207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilerMarker.AutoScope Auto()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerMarker.NativeMethodInfoPtr_Auto_Public_AutoScope_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000025FC File Offset: 0x000007FC
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, ref this));
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000260E File Offset: 0x0000080E
		public IntPtr Handle
		{
			get
			{
				return this.m_Ptr;
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002616 File Offset: 0x00000816
		public void Begin()
		{
			Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.BeginSample(this.m_Ptr);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002625 File Offset: 0x00000825
		public void Begin(UnityEngine.Object contextUnityObject)
		{
			Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.Internal_BeginWithObject(this.m_Ptr, contextUnityObject);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002635 File Offset: 0x00000835
		public void End()
		{
			Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.EndSample(this.m_Ptr);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002644 File Offset: 0x00000844
		public void GetName(ref string name)
		{
			name = Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility.Internal_GetName(this.m_Ptr);
		}

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ProfilerCategory_String_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_Auto_Public_AutoScope_0;

		// Token: 0x0400008A RID: 138
		[NonSerialized]
		[FieldOffset(0)]
		public readonly IntPtr m_Ptr;

		// Token: 0x02000393 RID: 915
		[StructLayout(2)]
		public struct AutoScope
		{
			// Token: 0x06002FB4 RID: 12212 RVA: 0x000AE440 File Offset: 0x000AC640
			// Note: this type is marked as 'beforefieldinit'.
			static AutoScope()
			{
				Il2CppClassPointerStore<ProfilerMarker.AutoScope>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProfilerMarker>.NativeClassPtr, "AutoScope");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerMarker.AutoScope>.NativeClassPtr);
				ProfilerMarker.AutoScope.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerMarker.AutoScope>.NativeClassPtr, "m_Ptr");
				ProfilerMarker.AutoScope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerMarker.AutoScope>.NativeClassPtr, 100663378);
			}

			// Token: 0x06002FB5 RID: 12213 RVA: 0x000AE494 File Offset: 0x000AC694
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225197, XrefRangeEnd = 1225200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerMarker.AutoScope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FB6 RID: 12214 RVA: 0x0001571A File Offset: 0x0001391A
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerMarker.AutoScope>.NativeClassPtr, ref this));
			}

			// Token: 0x040029CF RID: 10703
			private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

			// Token: 0x040029D0 RID: 10704
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x040029D1 RID: 10705
			[FieldOffset(0)]
			public readonly IntPtr m_Ptr;
		}
	}
}
