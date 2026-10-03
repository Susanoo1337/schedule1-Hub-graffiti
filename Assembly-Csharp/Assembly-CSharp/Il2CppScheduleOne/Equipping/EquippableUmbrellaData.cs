using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Equipping.Framework;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x0200057A RID: 1402
	public class EquippableUmbrellaData : EquippableData
	{
		// Token: 0x06007FCA RID: 32714 RVA: 0x002324CC File Offset: 0x002306CC
		// Note: this type is marked as 'beforefieldinit'.
		static EquippableUmbrellaData()
		{
			Il2CppClassPointerStore<EquippableUmbrellaData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "EquippableUmbrellaData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquippableUmbrellaData>.NativeClassPtr);
			EquippableUmbrellaData.NativeFieldInfoPtr_CanopyColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableUmbrellaData>.NativeClassPtr, "CanopyColor");
			EquippableUmbrellaData.NativeFieldInfoPtr_CanopyDecal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableUmbrellaData>.NativeClassPtr, "CanopyDecal");
			EquippableUmbrellaData.NativeFieldInfoPtr_CanopyDecalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquippableUmbrellaData>.NativeClassPtr, "CanopyDecalColor");
			EquippableUmbrellaData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippableUmbrellaData>.NativeClassPtr, 100679756);
		}

		// Token: 0x06007FCB RID: 32715 RVA: 0x0023254C File Offset: 0x0023074C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 199973, RefRangeEnd = 199979, XrefRangeStart = 199973, XrefRangeEnd = 199979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EquippableUmbrellaData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquippableUmbrellaData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippableUmbrellaData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FCC RID: 32716 RVA: 0x0003CB49 File Offset: 0x0003AD49
		public EquippableUmbrellaData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002778 RID: 10104
		// (get) Token: 0x06007FCD RID: 32717 RVA: 0x00232588 File Offset: 0x00230788
		// (set) Token: 0x06007FCE RID: 32718 RVA: 0x0003CB52 File Offset: 0x0003AD52
		public unsafe Gradient CanopyColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippableUmbrellaData.NativeFieldInfoPtr_CanopyColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippableUmbrellaData.NativeFieldInfoPtr_CanopyColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002779 RID: 10105
		// (get) Token: 0x06007FCF RID: 32719 RVA: 0x002325B8 File Offset: 0x002307B8
		// (set) Token: 0x06007FD0 RID: 32720 RVA: 0x0003CB71 File Offset: 0x0003AD71
		public unsafe Texture2D CanopyDecal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippableUmbrellaData.NativeFieldInfoPtr_CanopyDecal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippableUmbrellaData.NativeFieldInfoPtr_CanopyDecal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700277A RID: 10106
		// (get) Token: 0x06007FD1 RID: 32721 RVA: 0x002325E8 File Offset: 0x002307E8
		// (set) Token: 0x06007FD2 RID: 32722 RVA: 0x0003CB90 File Offset: 0x0003AD90
		public unsafe Color CanopyDecalColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippableUmbrellaData.NativeFieldInfoPtr_CanopyDecalColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquippableUmbrellaData.NativeFieldInfoPtr_CanopyDecalColor)) = value;
			}
		}

		// Token: 0x04005733 RID: 22323
		private static readonly IntPtr NativeFieldInfoPtr_CanopyColor;

		// Token: 0x04005734 RID: 22324
		private static readonly IntPtr NativeFieldInfoPtr_CanopyDecal;

		// Token: 0x04005735 RID: 22325
		private static readonly IntPtr NativeFieldInfoPtr_CanopyDecalColor;

		// Token: 0x04005736 RID: 22326
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
