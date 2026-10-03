using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x02000169 RID: 361
	public class PropertyDisposalArea : MonoBehaviour
	{
		// Token: 0x06002440 RID: 9280 RVA: 0x000F303C File Offset: 0x000F123C
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyDisposalArea()
		{
			Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "PropertyDisposalArea");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr);
			PropertyDisposalArea.NativeFieldInfoPtr_StandPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr, "StandPoint");
			PropertyDisposalArea.NativeFieldInfoPtr_TrashDropPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr, "TrashDropPoint");
			PropertyDisposalArea.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr, 100667987);
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x000F30A8 File Offset: 0x000F12A8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyDisposalArea() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyDisposalArea>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDisposalArea.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x000132EB File Offset: 0x000114EB
		public PropertyDisposalArea(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06002443 RID: 9283 RVA: 0x000F30E4 File Offset: 0x000F12E4
		// (set) Token: 0x06002444 RID: 9284 RVA: 0x000132F4 File Offset: 0x000114F4
		public unsafe Transform StandPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDisposalArea.NativeFieldInfoPtr_StandPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDisposalArea.NativeFieldInfoPtr_StandPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x06002445 RID: 9285 RVA: 0x000F3114 File Offset: 0x000F1314
		// (set) Token: 0x06002446 RID: 9286 RVA: 0x00013313 File Offset: 0x00011513
		public unsafe Transform TrashDropPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDisposalArea.NativeFieldInfoPtr_TrashDropPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDisposalArea.NativeFieldInfoPtr_TrashDropPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400190A RID: 6410
		private static readonly IntPtr NativeFieldInfoPtr_StandPoint;

		// Token: 0x0400190B RID: 6411
		private static readonly IntPtr NativeFieldInfoPtr_TrashDropPoint;

		// Token: 0x0400190C RID: 6412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
