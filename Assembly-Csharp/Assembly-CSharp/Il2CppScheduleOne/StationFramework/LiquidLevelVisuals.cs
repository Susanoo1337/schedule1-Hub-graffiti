using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x0200053D RID: 1341
	public class LiquidLevelVisuals : MonoBehaviour
	{
		// Token: 0x060079F7 RID: 31223 RVA: 0x0021C5FC File Offset: 0x0021A7FC
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidLevelVisuals()
		{
			Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "LiquidLevelVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr);
			LiquidLevelVisuals.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, "Container");
			LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, "LiquidSurface");
			LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, "LiquidSurface_Min");
			LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, "LiquidSurface_Max");
			LiquidLevelVisuals.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, 100678966);
			LiquidLevelVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr, 100678967);
		}

		// Token: 0x060079F8 RID: 31224 RVA: 0x0021C6A4 File Offset: 0x0021A8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234054, XrefRangeEnd = 234067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidLevelVisuals.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079F9 RID: 31225 RVA: 0x0021C6D8 File Offset: 0x0021A8D8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidLevelVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidLevelVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidLevelVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079FA RID: 31226 RVA: 0x0003A195 File Offset: 0x00038395
		public LiquidLevelVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025B5 RID: 9653
		// (get) Token: 0x060079FB RID: 31227 RVA: 0x0021C714 File Offset: 0x0021A914
		// (set) Token: 0x060079FC RID: 31228 RVA: 0x0003A19E File Offset: 0x0003839E
		public unsafe LiquidContainer Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025B6 RID: 9654
		// (get) Token: 0x060079FD RID: 31229 RVA: 0x0021C744 File Offset: 0x0021A944
		// (set) Token: 0x060079FE RID: 31230 RVA: 0x0003A1BD File Offset: 0x000383BD
		public unsafe Transform LiquidSurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025B7 RID: 9655
		// (get) Token: 0x060079FF RID: 31231 RVA: 0x0021C774 File Offset: 0x0021A974
		// (set) Token: 0x06007A00 RID: 31232 RVA: 0x0003A1DC File Offset: 0x000383DC
		public unsafe Transform LiquidSurface_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025B8 RID: 9656
		// (get) Token: 0x06007A01 RID: 31233 RVA: 0x0021C7A4 File Offset: 0x0021A9A4
		// (set) Token: 0x06007A02 RID: 31234 RVA: 0x0003A1FB File Offset: 0x000383FB
		public unsafe Transform LiquidSurface_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidLevelVisuals.NativeFieldInfoPtr_LiquidSurface_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005317 RID: 21271
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005318 RID: 21272
		private static readonly IntPtr NativeFieldInfoPtr_LiquidSurface;

		// Token: 0x04005319 RID: 21273
		private static readonly IntPtr NativeFieldInfoPtr_LiquidSurface_Min;

		// Token: 0x0400531A RID: 21274
		private static readonly IntPtr NativeFieldInfoPtr_LiquidSurface_Max;

		// Token: 0x0400531B RID: 21275
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400531C RID: 21276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
