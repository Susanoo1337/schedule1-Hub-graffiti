using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Effects.MixMaps
{
	// Token: 0x020006CF RID: 1743
	public class MixMapEffect : MonoBehaviour
	{
		// Token: 0x0600A77F RID: 42879 RVA: 0x002C683C File Offset: 0x002C4A3C
		// Note: this type is marked as 'beforefieldinit'.
		static MixMapEffect()
		{
			Il2CppClassPointerStore<MixMapEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Effects.MixMaps", "MixMapEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixMapEffect>.NativeClassPtr);
			MixMapEffect.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixMapEffect>.NativeClassPtr, "Property");
			MixMapEffect.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixMapEffect>.NativeClassPtr, "Radius");
			MixMapEffect.NativeMethodInfoPtr_get_Position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixMapEffect>.NativeClassPtr, 100685548);
			MixMapEffect.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixMapEffect>.NativeClassPtr, 100685549);
			MixMapEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixMapEffect>.NativeClassPtr, 100685550);
		}

		// Token: 0x17003204 RID: 12804
		// (get) Token: 0x0600A780 RID: 42880 RVA: 0x002C68D0 File Offset: 0x002C4AD0
		public unsafe Vector2 Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291029, XrefRangeEnd = 291033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixMapEffect.NativeMethodInfoPtr_get_Position_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600A781 RID: 42881 RVA: 0x002C690C File Offset: 0x002C4B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291033, XrefRangeEnd = 291039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixMapEffect.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A782 RID: 42882 RVA: 0x002C6940 File Offset: 0x002C4B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixMapEffect() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixMapEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixMapEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A783 RID: 42883 RVA: 0x0004C26B File Offset: 0x0004A46B
		public MixMapEffect(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003202 RID: 12802
		// (get) Token: 0x0600A784 RID: 42884 RVA: 0x002C697C File Offset: 0x002C4B7C
		// (set) Token: 0x0600A785 RID: 42885 RVA: 0x0004C274 File Offset: 0x0004A474
		public unsafe Effect Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixMapEffect.NativeFieldInfoPtr_Property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Effect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixMapEffect.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003203 RID: 12803
		// (get) Token: 0x0600A786 RID: 42886 RVA: 0x002C69AC File Offset: 0x002C4BAC
		// (set) Token: 0x0600A787 RID: 42887 RVA: 0x0004C293 File Offset: 0x0004A493
		public unsafe float Radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixMapEffect.NativeFieldInfoPtr_Radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixMapEffect.NativeFieldInfoPtr_Radius)) = value;
			}
		}

		// Token: 0x040073CF RID: 29647
		private static readonly IntPtr NativeFieldInfoPtr_Property;

		// Token: 0x040073D0 RID: 29648
		private static readonly IntPtr NativeFieldInfoPtr_Radius;

		// Token: 0x040073D1 RID: 29649
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector2_0;

		// Token: 0x040073D2 RID: 29650
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;

		// Token: 0x040073D3 RID: 29651
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
