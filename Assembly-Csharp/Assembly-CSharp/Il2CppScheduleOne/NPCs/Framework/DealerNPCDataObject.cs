using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x02000601 RID: 1537
	public class DealerNPCDataObject : GenericNPCDataObject<DealerNPCData>
	{
		// Token: 0x060095D0 RID: 38352 RVA: 0x00285E68 File Offset: 0x00284068
		// Note: this type is marked as 'beforefieldinit'.
		static DealerNPCDataObject()
		{
			Il2CppClassPointerStore<DealerNPCDataObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "DealerNPCDataObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerNPCDataObject>.NativeClassPtr);
			DealerNPCDataObject.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerNPCDataObject>.NativeClassPtr, 100682845);
			DealerNPCDataObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerNPCDataObject>.NativeClassPtr, 100682846);
		}

		// Token: 0x060095D1 RID: 38353 RVA: 0x00285EC0 File Offset: 0x002840C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272349, XrefRangeEnd = 272358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealerNPCDataObject.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095D2 RID: 38354 RVA: 0x00285EFC File Offset: 0x002840FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272358, XrefRangeEnd = 272361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealerNPCDataObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerNPCDataObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerNPCDataObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095D3 RID: 38355 RVA: 0x000461F2 File Offset: 0x000443F2
		public DealerNPCDataObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04006713 RID: 26387
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04006714 RID: 26388
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
