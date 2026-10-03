using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x0200053E RID: 1342
	public class LiquidVolumeCollider : MonoBehaviour
	{
		// Token: 0x06007A03 RID: 31235 RVA: 0x0021C7D4 File Offset: 0x0021A9D4
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidVolumeCollider()
		{
			Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "LiquidVolumeCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr);
			LiquidVolumeCollider.NativeFieldInfoPtr_LiquidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr, "LiquidContainer");
			LiquidVolumeCollider.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr, 100678968);
			LiquidVolumeCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr, 100678969);
		}

		// Token: 0x06007A04 RID: 31236 RVA: 0x0021C840 File Offset: 0x0021AA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234067, XrefRangeEnd = 234075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeCollider.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A05 RID: 31237 RVA: 0x0021C874 File Offset: 0x0021AA74
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidVolumeCollider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A06 RID: 31238 RVA: 0x0003A21A File Offset: 0x0003841A
		public LiquidVolumeCollider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025B9 RID: 9657
		// (get) Token: 0x06007A07 RID: 31239 RVA: 0x0021C8B0 File Offset: 0x0021AAB0
		// (set) Token: 0x06007A08 RID: 31240 RVA: 0x0003A223 File Offset: 0x00038423
		public unsafe LiquidContainer LiquidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeCollider.NativeFieldInfoPtr_LiquidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeCollider.NativeFieldInfoPtr_LiquidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400531D RID: 21277
		private static readonly IntPtr NativeFieldInfoPtr_LiquidContainer;

		// Token: 0x0400531E RID: 21278
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400531F RID: 21279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
