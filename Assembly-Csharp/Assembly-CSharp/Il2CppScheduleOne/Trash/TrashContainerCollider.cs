using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x0200048B RID: 1163
	public class TrashContainerCollider : MonoBehaviour
	{
		// Token: 0x060068D0 RID: 26832 RVA: 0x001E5B94 File Offset: 0x001E3D94
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContainerCollider()
		{
			Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashContainerCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr);
			TrashContainerCollider.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr, "Container");
			TrashContainerCollider.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr, 100677013);
			TrashContainerCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr, 100677014);
		}

		// Token: 0x060068D1 RID: 26833 RVA: 0x001E5C00 File Offset: 0x001E3E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216872, XrefRangeEnd = 216881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerCollider.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068D2 RID: 26834 RVA: 0x001E5C44 File Offset: 0x001E3E44
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainerCollider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContainerCollider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068D3 RID: 26835 RVA: 0x00031525 File Offset: 0x0002F725
		public TrashContainerCollider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002008 RID: 8200
		// (get) Token: 0x060068D4 RID: 26836 RVA: 0x001E5C80 File Offset: 0x001E3E80
		// (set) Token: 0x060068D5 RID: 26837 RVA: 0x0003152E File Offset: 0x0002F72E
		public unsafe TrashContainer Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerCollider.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerCollider.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004818 RID: 18456
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04004819 RID: 18457
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0;

		// Token: 0x0400481A RID: 18458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
