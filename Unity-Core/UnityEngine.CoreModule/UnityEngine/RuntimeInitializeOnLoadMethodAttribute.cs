using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000146 RID: 326
	public class RuntimeInitializeOnLoadMethodAttribute : UnityEngine.Scripting.PreserveAttribute
	{
		// Token: 0x060018F9 RID: 6393 RVA: 0x0006AC68 File Offset: 0x00068E68
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeInitializeOnLoadMethodAttribute()
		{
			Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RuntimeInitializeOnLoadMethodAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr);
			RuntimeInitializeOnLoadMethodAttribute.NativeFieldInfoPtr_m_LoadType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr, "m_LoadType");
			RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr, 100665946);
			RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_RuntimeInitializeLoadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr, 100665947);
			RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr_set_loadType_Private_set_Void_RuntimeInitializeLoadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr, 100665948);
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x0006ACE8 File Offset: 0x00068EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260510, XrefRangeEnd = 1260511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeInitializeOnLoadMethodAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x0006AD24 File Offset: 0x00068F24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1132577, RefRangeEnd = 1132578, XrefRangeStart = 1132577, XrefRangeEnd = 1132578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref loadType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_RuntimeInitializeLoadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x0006ADD4 File Offset: 0x00068FD4
		// (set) Token: 0x060018FC RID: 6396 RVA: 0x0006AD6C File Offset: 0x00068F6C
		public unsafe RuntimeInitializeLoadType loadType
		{
			get
			{
				return this.m_LoadType;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 29051, RefRangeEnd = 29056, XrefRangeStart = 29051, XrefRangeEnd = 29056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr_set_loadType_Private_set_Void_RuntimeInitializeLoadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x0000C3C2 File Offset: 0x0000A5C2
		public RuntimeInitializeOnLoadMethodAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x0006ADAC File Offset: 0x00068FAC
		// (set) Token: 0x060018FF RID: 6399 RVA: 0x0000C3CB File Offset: 0x0000A5CB
		public unsafe RuntimeInitializeLoadType m_LoadType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeInitializeOnLoadMethodAttribute.NativeFieldInfoPtr_m_LoadType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeInitializeOnLoadMethodAttribute.NativeFieldInfoPtr_m_LoadType)) = value;
			}
		}

		// Token: 0x040014DC RID: 5340
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadType;

		// Token: 0x040014DD RID: 5341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040014DE RID: 5342
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RuntimeInitializeLoadType_0;

		// Token: 0x040014DF RID: 5343
		private static readonly IntPtr NativeMethodInfoPtr_set_loadType_Private_set_Void_RuntimeInitializeLoadType_0;
	}
}
