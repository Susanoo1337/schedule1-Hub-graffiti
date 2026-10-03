using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Effects.MixMaps
{
	// Token: 0x020006CD RID: 1741
	[Serializable]
	public class MixerMapEffect : Il2CppSystem.Object
	{
		// Token: 0x0600A767 RID: 42855 RVA: 0x002C642C File Offset: 0x002C462C
		// Note: this type is marked as 'beforefieldinit'.
		static MixerMapEffect()
		{
			Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Effects.MixMaps", "MixerMapEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr);
			MixerMapEffect.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr, "Position");
			MixerMapEffect.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr, "Radius");
			MixerMapEffect.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr, "Property");
			MixerMapEffect.NativeMethodInfoPtr_IsPointInEffect_Public_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr, 100685539);
			MixerMapEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr, 100685540);
		}

		// Token: 0x0600A768 RID: 42856 RVA: 0x002C64C0 File Offset: 0x002C46C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290945, XrefRangeEnd = 290950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointInEffect(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapEffect.NativeMethodInfoPtr_IsPointInEffect_Public_Boolean_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A769 RID: 42857 RVA: 0x002C650C File Offset: 0x002C470C
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixerMapEffect() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixerMapEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A76A RID: 42858 RVA: 0x0004C18C File Offset: 0x0004A38C
		public MixerMapEffect(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031FB RID: 12795
		// (get) Token: 0x0600A76B RID: 42859 RVA: 0x002C6548 File Offset: 0x002C4748
		// (set) Token: 0x0600A76C RID: 42860 RVA: 0x0004C195 File Offset: 0x0004A395
		public unsafe Vector2 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapEffect.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapEffect.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x170031FC RID: 12796
		// (get) Token: 0x0600A76D RID: 42861 RVA: 0x002C6570 File Offset: 0x002C4770
		// (set) Token: 0x0600A76E RID: 42862 RVA: 0x0004C1B0 File Offset: 0x0004A3B0
		public unsafe float Radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapEffect.NativeFieldInfoPtr_Radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapEffect.NativeFieldInfoPtr_Radius)) = value;
			}
		}

		// Token: 0x170031FD RID: 12797
		// (get) Token: 0x0600A76F RID: 42863 RVA: 0x002C6598 File Offset: 0x002C4798
		// (set) Token: 0x0600A770 RID: 42864 RVA: 0x0004C1CB File Offset: 0x0004A3CB
		public unsafe Effect Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapEffect.NativeFieldInfoPtr_Property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Effect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapEffect.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040073C2 RID: 29634
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x040073C3 RID: 29635
		private static readonly IntPtr NativeFieldInfoPtr_Radius;

		// Token: 0x040073C4 RID: 29636
		private static readonly IntPtr NativeFieldInfoPtr_Property;

		// Token: 0x040073C5 RID: 29637
		private static readonly IntPtr NativeMethodInfoPtr_IsPointInEffect_Public_Boolean_Vector2_0;

		// Token: 0x040073C6 RID: 29638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
