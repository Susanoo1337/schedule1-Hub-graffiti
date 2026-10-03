using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x02000130 RID: 304
	public class SkateboardEffects : MonoBehaviour
	{
		// Token: 0x06001E98 RID: 7832 RVA: 0x000DF6D8 File Offset: 0x000DD8D8
		// Note: this type is marked as 'beforefieldinit'.
		static SkateboardEffects()
		{
			Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "SkateboardEffects");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr);
			SkateboardEffects.NativeFieldInfoPtr_skateboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr, "skateboard");
			SkateboardEffects.NativeFieldInfoPtr_Trails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr, "Trails");
			SkateboardEffects.NativeFieldInfoPtr_trailsOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr, "trailsOpacity");
			SkateboardEffects.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr, 100667246);
			SkateboardEffects.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr, 100667247);
			SkateboardEffects.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr, 100667248);
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x000DF780 File Offset: 0x000DD980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105280, XrefRangeEnd = 105285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardEffects.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x000DF7B4 File Offset: 0x000DD9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105285, XrefRangeEnd = 105289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardEffects.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x000DF7E8 File Offset: 0x000DD9E8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkateboardEffects() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkateboardEffects>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardEffects.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x0001095F File Offset: 0x0000EB5F
		public SkateboardEffects(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06001E9D RID: 7837 RVA: 0x000DF824 File Offset: 0x000DDA24
		// (set) Token: 0x06001E9E RID: 7838 RVA: 0x00010968 File Offset: 0x0000EB68
		public unsafe Skateboard skateboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardEffects.NativeFieldInfoPtr_skateboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardEffects.NativeFieldInfoPtr_skateboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06001E9F RID: 7839 RVA: 0x000DF854 File Offset: 0x000DDA54
		// (set) Token: 0x06001EA0 RID: 7840 RVA: 0x00010987 File Offset: 0x0000EB87
		public unsafe Il2CppReferenceArray<TrailRenderer> Trails
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardEffects.NativeFieldInfoPtr_Trails);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrailRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardEffects.NativeFieldInfoPtr_Trails), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06001EA1 RID: 7841 RVA: 0x000DF884 File Offset: 0x000DDA84
		// (set) Token: 0x06001EA2 RID: 7842 RVA: 0x000109A6 File Offset: 0x0000EBA6
		public unsafe float trailsOpacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardEffects.NativeFieldInfoPtr_trailsOpacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardEffects.NativeFieldInfoPtr_trailsOpacity)) = value;
			}
		}

		// Token: 0x04001530 RID: 5424
		private static readonly IntPtr NativeFieldInfoPtr_skateboard;

		// Token: 0x04001531 RID: 5425
		private static readonly IntPtr NativeFieldInfoPtr_Trails;

		// Token: 0x04001532 RID: 5426
		private static readonly IntPtr NativeFieldInfoPtr_trailsOpacity;

		// Token: 0x04001533 RID: 5427
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001534 RID: 5428
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04001535 RID: 5429
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
