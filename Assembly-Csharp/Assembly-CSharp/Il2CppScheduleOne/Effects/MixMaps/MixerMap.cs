using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Effects.MixMaps
{
	// Token: 0x020006CC RID: 1740
	[Serializable]
	public class MixerMap : ScriptableObject
	{
		// Token: 0x0600A75E RID: 42846 RVA: 0x002C6268 File Offset: 0x002C4468
		// Note: this type is marked as 'beforefieldinit'.
		static MixerMap()
		{
			Il2CppClassPointerStore<MixerMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Effects.MixMaps", "MixerMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixerMap>.NativeClassPtr);
			MixerMap.NativeFieldInfoPtr_MapRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMap>.NativeClassPtr, "MapRadius");
			MixerMap.NativeFieldInfoPtr_Effects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMap>.NativeClassPtr, "Effects");
			MixerMap.NativeMethodInfoPtr_GetEffectAtPoint_Public_MixerMapEffect_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMap>.NativeClassPtr, 100685536);
			MixerMap.NativeMethodInfoPtr_GetEffect_Public_MixerMapEffect_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMap>.NativeClassPtr, 100685537);
			MixerMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMap>.NativeClassPtr, 100685538);
		}

		// Token: 0x0600A75F RID: 42847 RVA: 0x002C62FC File Offset: 0x002C44FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290933, RefRangeEnd = 290934, XrefRangeStart = 290915, XrefRangeEnd = 290933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixerMapEffect GetEffectAtPoint(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMap.NativeMethodInfoPtr_GetEffectAtPoint_Public_MixerMapEffect_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MixerMapEffect>(intPtr3) : null;
		}

		// Token: 0x0600A760 RID: 42848 RVA: 0x002C6348 File Offset: 0x002C4548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290934, XrefRangeEnd = 290945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixerMapEffect GetEffect(Effect property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMap.NativeMethodInfoPtr_GetEffect_Public_MixerMapEffect_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MixerMapEffect>(intPtr3) : null;
		}

		// Token: 0x0600A761 RID: 42849 RVA: 0x002C6398 File Offset: 0x002C4598
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 79617, RefRangeEnd = 79648, XrefRangeStart = 79617, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixerMap() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixerMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A762 RID: 42850 RVA: 0x0004C149 File Offset: 0x0004A349
		public MixerMap(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031F9 RID: 12793
		// (get) Token: 0x0600A763 RID: 42851 RVA: 0x002C63D4 File Offset: 0x002C45D4
		// (set) Token: 0x0600A764 RID: 42852 RVA: 0x0004C152 File Offset: 0x0004A352
		public unsafe float MapRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMap.NativeFieldInfoPtr_MapRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMap.NativeFieldInfoPtr_MapRadius)) = value;
			}
		}

		// Token: 0x170031FA RID: 12794
		// (get) Token: 0x0600A765 RID: 42853 RVA: 0x002C63FC File Offset: 0x002C45FC
		// (set) Token: 0x0600A766 RID: 42854 RVA: 0x0004C16D File Offset: 0x0004A36D
		public unsafe List<MixerMapEffect> Effects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMap.NativeFieldInfoPtr_Effects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MixerMapEffect>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMap.NativeFieldInfoPtr_Effects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040073BD RID: 29629
		private static readonly IntPtr NativeFieldInfoPtr_MapRadius;

		// Token: 0x040073BE RID: 29630
		private static readonly IntPtr NativeFieldInfoPtr_Effects;

		// Token: 0x040073BF RID: 29631
		private static readonly IntPtr NativeMethodInfoPtr_GetEffectAtPoint_Public_MixerMapEffect_Vector2_0;

		// Token: 0x040073C0 RID: 29632
		private static readonly IntPtr NativeMethodInfoPtr_GetEffect_Public_MixerMapEffect_Effect_0;

		// Token: 0x040073C1 RID: 29633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
