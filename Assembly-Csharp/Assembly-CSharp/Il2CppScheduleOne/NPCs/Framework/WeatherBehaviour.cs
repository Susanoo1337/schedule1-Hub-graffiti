using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.NPCs.Framework
{
	// Token: 0x020005FE RID: 1534
	[Serializable]
	public class WeatherBehaviour : Object
	{
		// Token: 0x060095AD RID: 38317 RVA: 0x002858C8 File Offset: 0x00283AC8
		// Note: this type is marked as 'beforefieldinit'.
		static WeatherBehaviour()
		{
			Il2CppClassPointerStore<WeatherBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Framework", "WeatherBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeatherBehaviour>.NativeClassPtr);
			WeatherBehaviour.NativeFieldInfoPtr_UseUmbrellaChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherBehaviour>.NativeClassPtr, "UseUmbrellaChance");
			WeatherBehaviour.NativeFieldInfoPtr_RainTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherBehaviour>.NativeClassPtr, "RainTolerance");
			WeatherBehaviour.NativeFieldInfoPtr_MaxWalkSpeedInRainMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeatherBehaviour>.NativeClassPtr, "MaxWalkSpeedInRainMultiplier");
			WeatherBehaviour.NativeMethodInfoPtr_GetCopy_Public_WeatherBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherBehaviour>.NativeClassPtr, 100682838);
			WeatherBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeatherBehaviour>.NativeClassPtr, 100682839);
		}

		// Token: 0x060095AE RID: 38318 RVA: 0x0028595C File Offset: 0x00283B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272317, XrefRangeEnd = 272321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeatherBehaviour GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherBehaviour.NativeMethodInfoPtr_GetCopy_Public_WeatherBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeatherBehaviour>(intPtr3) : null;
		}

		// Token: 0x060095AF RID: 38319 RVA: 0x0028599C File Offset: 0x00283B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272321, XrefRangeEnd = 272322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeatherBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeatherBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeatherBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060095B0 RID: 38320 RVA: 0x0004609A File Offset: 0x0004429A
		public WeatherBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E2C RID: 11820
		// (get) Token: 0x060095B1 RID: 38321 RVA: 0x002859D8 File Offset: 0x00283BD8
		// (set) Token: 0x060095B2 RID: 38322 RVA: 0x000460A3 File Offset: 0x000442A3
		public unsafe float UseUmbrellaChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherBehaviour.NativeFieldInfoPtr_UseUmbrellaChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherBehaviour.NativeFieldInfoPtr_UseUmbrellaChance)) = value;
			}
		}

		// Token: 0x17002E2D RID: 11821
		// (get) Token: 0x060095B3 RID: 38323 RVA: 0x00285A00 File Offset: 0x00283C00
		// (set) Token: 0x060095B4 RID: 38324 RVA: 0x000460BE File Offset: 0x000442BE
		public unsafe float RainTolerance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherBehaviour.NativeFieldInfoPtr_RainTolerance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherBehaviour.NativeFieldInfoPtr_RainTolerance)) = value;
			}
		}

		// Token: 0x17002E2E RID: 11822
		// (get) Token: 0x060095B5 RID: 38325 RVA: 0x00285A28 File Offset: 0x00283C28
		// (set) Token: 0x060095B6 RID: 38326 RVA: 0x000460D9 File Offset: 0x000442D9
		public unsafe float MaxWalkSpeedInRainMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherBehaviour.NativeFieldInfoPtr_MaxWalkSpeedInRainMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeatherBehaviour.NativeFieldInfoPtr_MaxWalkSpeedInRainMultiplier)) = value;
			}
		}

		// Token: 0x04006701 RID: 26369
		private static readonly IntPtr NativeFieldInfoPtr_UseUmbrellaChance;

		// Token: 0x04006702 RID: 26370
		private static readonly IntPtr NativeFieldInfoPtr_RainTolerance;

		// Token: 0x04006703 RID: 26371
		private static readonly IntPtr NativeFieldInfoPtr_MaxWalkSpeedInRainMultiplier;

		// Token: 0x04006704 RID: 26372
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_WeatherBehaviour_0;

		// Token: 0x04006705 RID: 26373
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
