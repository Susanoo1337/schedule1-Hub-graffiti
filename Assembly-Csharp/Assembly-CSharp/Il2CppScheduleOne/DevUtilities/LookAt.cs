using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003F6 RID: 1014
	public class LookAt : MonoBehaviour
	{
		// Token: 0x06005A0E RID: 23054 RVA: 0x001B1FC0 File Offset: 0x001B01C0
		// Note: this type is marked as 'beforefieldinit'.
		static LookAt()
		{
			Il2CppClassPointerStore<LookAt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "LookAt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LookAt>.NativeClassPtr);
			LookAt.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAt>.NativeClassPtr, "Target");
			LookAt.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAt>.NativeClassPtr, 100675074);
			LookAt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAt>.NativeClassPtr, 100675075);
		}

		// Token: 0x06005A0F RID: 23055 RVA: 0x001B202C File Offset: 0x001B022C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194763, XrefRangeEnd = 194769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAt.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A10 RID: 23056 RVA: 0x001B2060 File Offset: 0x001B0260
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LookAt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LookAt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A11 RID: 23057 RVA: 0x0002ABB6 File Offset: 0x00028DB6
		public LookAt(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x06005A12 RID: 23058 RVA: 0x001B209C File Offset: 0x001B029C
		// (set) Token: 0x06005A13 RID: 23059 RVA: 0x0002ABBF File Offset: 0x00028DBF
		public unsafe Transform Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAt.NativeFieldInfoPtr_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAt.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003DCA RID: 15818
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x04003DCB RID: 15819
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04003DCC RID: 15820
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
