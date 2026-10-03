using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Decoration
{
	// Token: 0x02000108 RID: 264
	public class RockerSwitch : MonoBehaviour
	{
		// Token: 0x06001996 RID: 6550 RVA: 0x000CF388 File Offset: 0x000CD588
		// Note: this type is marked as 'beforefieldinit'.
		static RockerSwitch()
		{
			Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Decoration", "RockerSwitch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr);
			RockerSwitch.NativeFieldInfoPtr_ButtonMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, "ButtonMesh");
			RockerSwitch.NativeFieldInfoPtr_ButtonTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, "ButtonTransform");
			RockerSwitch.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, "Light");
			RockerSwitch.NativeFieldInfoPtr_isOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, "isOn");
			RockerSwitch.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, 100666700);
			RockerSwitch.NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, 100666701);
			RockerSwitch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr, 100666702);
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x000CF444 File Offset: 0x000CD644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99163, XrefRangeEnd = 99166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockerSwitch.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x000CF478 File Offset: 0x000CD678
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99169, RefRangeEnd = 99171, XrefRangeStart = 99166, XrefRangeEnd = 99169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOn(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockerSwitch.NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x000CF4B8 File Offset: 0x000CD6B8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RockerSwitch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RockerSwitch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RockerSwitch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x0000E136 File Offset: 0x0000C336
		public RockerSwitch(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x0600199B RID: 6555 RVA: 0x000CF4F4 File Offset: 0x000CD6F4
		// (set) Token: 0x0600199C RID: 6556 RVA: 0x0000E13F File Offset: 0x0000C33F
		public unsafe MeshRenderer ButtonMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_ButtonMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_ButtonMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x0600199D RID: 6557 RVA: 0x000CF524 File Offset: 0x000CD724
		// (set) Token: 0x0600199E RID: 6558 RVA: 0x0000E15E File Offset: 0x0000C35E
		public unsafe Transform ButtonTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_ButtonTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_ButtonTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x0600199F RID: 6559 RVA: 0x000CF554 File Offset: 0x000CD754
		// (set) Token: 0x060019A0 RID: 6560 RVA: 0x0000E17D File Offset: 0x0000C37D
		public unsafe Light Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x000CF584 File Offset: 0x000CD784
		// (set) Token: 0x060019A2 RID: 6562 RVA: 0x0000E19C File Offset: 0x0000C39C
		public unsafe bool isOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_isOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RockerSwitch.NativeFieldInfoPtr_isOn)) = value;
			}
		}

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeFieldInfoPtr_ButtonMesh;

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeFieldInfoPtr_ButtonTransform;

		// Token: 0x040011B0 RID: 4528
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x040011B1 RID: 4529
		private static readonly IntPtr NativeFieldInfoPtr_isOn;

		// Token: 0x040011B2 RID: 4530
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040011B3 RID: 4531
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0;

		// Token: 0x040011B4 RID: 4532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
