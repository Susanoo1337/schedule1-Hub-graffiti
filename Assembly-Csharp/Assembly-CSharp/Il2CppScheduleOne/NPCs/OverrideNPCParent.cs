using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020005DC RID: 1500
	public class OverrideNPCParent : MonoBehaviour
	{
		// Token: 0x060093E9 RID: 37865 RVA: 0x0027FACC File Offset: 0x0027DCCC
		// Note: this type is marked as 'beforefieldinit'.
		static OverrideNPCParent()
		{
			Il2CppClassPointerStore<OverrideNPCParent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "OverrideNPCParent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverrideNPCParent>.NativeClassPtr);
			OverrideNPCParent.NativeFieldInfoPtr_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverrideNPCParent>.NativeClassPtr, "Parent");
			OverrideNPCParent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverrideNPCParent>.NativeClassPtr, 100682615);
		}

		// Token: 0x060093EA RID: 37866 RVA: 0x0027FB24 File Offset: 0x0027DD24
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OverrideNPCParent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverrideNPCParent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverrideNPCParent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060093EB RID: 37867 RVA: 0x000454EB File Offset: 0x000436EB
		public OverrideNPCParent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DB7 RID: 11703
		// (get) Token: 0x060093EC RID: 37868 RVA: 0x0027FB60 File Offset: 0x0027DD60
		// (set) Token: 0x060093ED RID: 37869 RVA: 0x000454F4 File Offset: 0x000436F4
		public unsafe Transform Parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverrideNPCParent.NativeFieldInfoPtr_Parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OverrideNPCParent.NativeFieldInfoPtr_Parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040065DD RID: 26077
		private static readonly IntPtr NativeFieldInfoPtr_Parent;

		// Token: 0x040065DE RID: 26078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
