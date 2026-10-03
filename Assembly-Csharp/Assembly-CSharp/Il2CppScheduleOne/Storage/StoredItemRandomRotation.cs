using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000531 RID: 1329
	public class StoredItemRandomRotation : MonoBehaviour
	{
		// Token: 0x060078D8 RID: 30936 RVA: 0x00218ED8 File Offset: 0x002170D8
		// Note: this type is marked as 'beforefieldinit'.
		static StoredItemRandomRotation()
		{
			Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StoredItemRandomRotation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr);
			StoredItemRandomRotation.NativeFieldInfoPtr_ItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr, "ItemContainer");
			StoredItemRandomRotation.NativeMethodInfoPtr_ApplyRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr, 100678845);
			StoredItemRandomRotation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr, 100678846);
		}

		// Token: 0x060078D9 RID: 30937 RVA: 0x00218F44 File Offset: 0x00217144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233382, XrefRangeEnd = 233386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItemRandomRotation.NativeMethodInfoPtr_ApplyRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078DA RID: 30938 RVA: 0x00218F78 File Offset: 0x00217178
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoredItemRandomRotation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItemRandomRotation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItemRandomRotation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078DB RID: 30939 RVA: 0x00039856 File Offset: 0x00037A56
		public StoredItemRandomRotation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002550 RID: 9552
		// (get) Token: 0x060078DC RID: 30940 RVA: 0x00218FB4 File Offset: 0x002171B4
		// (set) Token: 0x060078DD RID: 30941 RVA: 0x0003985F File Offset: 0x00037A5F
		public unsafe Transform ItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItemRandomRotation.NativeFieldInfoPtr_ItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItemRandomRotation.NativeFieldInfoPtr_ItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005260 RID: 21088
		private static readonly IntPtr NativeFieldInfoPtr_ItemContainer;

		// Token: 0x04005261 RID: 21089
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRotation_Public_Void_0;

		// Token: 0x04005262 RID: 21090
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
