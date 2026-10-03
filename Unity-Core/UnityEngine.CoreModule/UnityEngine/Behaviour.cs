using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200012D RID: 301
	public class Behaviour : Component
	{
		// Token: 0x060017AB RID: 6059 RVA: 0x00065E34 File Offset: 0x00064034
		// Note: this type is marked as 'beforefieldinit'.
		static Behaviour()
		{
			Il2CppClassPointerStore<Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Behaviour>.NativeClassPtr);
			Behaviour.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100665771);
			Behaviour.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100665772);
			Behaviour.NativeMethodInfoPtr_get_isActiveAndEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100665773);
			Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100665774);
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x00065EB4 File Offset: 0x000640B4
		// (set) Token: 0x060017AD RID: 6061 RVA: 0x00065EF0 File Offset: 0x000640F0
		public unsafe bool enabled
		{
			[CallerCount(144)]
			[CachedScanResults(RefRangeStart = 1247104, RefRangeEnd = 1247248, XrefRangeStart = 1247102, XrefRangeEnd = 1247104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(458)]
			[CachedScanResults(RefRangeStart = 1247250, RefRangeEnd = 1247708, XrefRangeStart = 1247248, XrefRangeEnd = 1247250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060017AE RID: 6062 RVA: 0x00065F30 File Offset: 0x00064130
		public unsafe bool isActiveAndEnabled
		{
			[CallerCount(63)]
			[CachedScanResults(RefRangeStart = 1247710, RefRangeEnd = 1247773, XrefRangeStart = 1247708, XrefRangeEnd = 1247710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_isActiveAndEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x00065F6C File Offset: 0x0006416C
		[CallerCount(1012)]
		[CachedScanResults(RefRangeStart = 1247777, RefRangeEnd = 1248789, XrefRangeStart = 1247773, XrefRangeEnd = 1247777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x0000BD6F File Offset: 0x00009F6F
		public Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040013F8 RID: 5112
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

		// Token: 0x040013F9 RID: 5113
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

		// Token: 0x040013FA RID: 5114
		private static readonly IntPtr NativeMethodInfoPtr_get_isActiveAndEnabled_Public_get_Boolean_0;

		// Token: 0x040013FB RID: 5115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
