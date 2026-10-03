using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200076D RID: 1901
	public class UISpawner : MonoBehaviour
	{
		// Token: 0x0600B904 RID: 47364 RVA: 0x002FB708 File Offset: 0x002F9908
		// Note: this type is marked as 'beforefieldinit'.
		static UISpawner()
		{
			Il2CppClassPointerStore<UISpawner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "UISpawner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISpawner>.NativeClassPtr);
			UISpawner.NativeFieldInfoPtr_SpawnArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "SpawnArea");
			UISpawner.NativeFieldInfoPtr_Prefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "Prefabs");
			UISpawner.NativeFieldInfoPtr_MinInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "MinInterval");
			UISpawner.NativeFieldInfoPtr_MaxInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "MaxInterval");
			UISpawner.NativeFieldInfoPtr_SpawnRateMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "SpawnRateMultiplier");
			UISpawner.NativeFieldInfoPtr_MinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "MinScale");
			UISpawner.NativeFieldInfoPtr_MaxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "MaxScale");
			UISpawner.NativeFieldInfoPtr_UniformScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "UniformScale");
			UISpawner.NativeFieldInfoPtr_nextSpawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "nextSpawnTime");
			UISpawner.NativeFieldInfoPtr_OnSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "OnSpawn");
			UISpawner.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, 100687488);
			UISpawner.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, 100687489);
			UISpawner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, 100687490);
		}

		// Token: 0x0600B905 RID: 47365 RVA: 0x002FB83C File Offset: 0x002F9A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309458, XrefRangeEnd = 309460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISpawner.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B906 RID: 47366 RVA: 0x002FB870 File Offset: 0x002F9A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309460, XrefRangeEnd = 309489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISpawner.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B907 RID: 47367 RVA: 0x002FB8A4 File Offset: 0x002F9AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309489, XrefRangeEnd = 309494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISpawner() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISpawner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISpawner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B908 RID: 47368 RVA: 0x00056134 File Offset: 0x00054334
		public UISpawner(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037E4 RID: 14308
		// (get) Token: 0x0600B909 RID: 47369 RVA: 0x002FB8E0 File Offset: 0x002F9AE0
		// (set) Token: 0x0600B90A RID: 47370 RVA: 0x0005613D File Offset: 0x0005433D
		public unsafe RectTransform SpawnArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_SpawnArea);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_SpawnArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037E5 RID: 14309
		// (get) Token: 0x0600B90B RID: 47371 RVA: 0x002FB910 File Offset: 0x002F9B10
		// (set) Token: 0x0600B90C RID: 47372 RVA: 0x0005615C File Offset: 0x0005435C
		public unsafe Il2CppReferenceArray<GameObject> Prefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_Prefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_Prefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037E6 RID: 14310
		// (get) Token: 0x0600B90D RID: 47373 RVA: 0x002FB940 File Offset: 0x002F9B40
		// (set) Token: 0x0600B90E RID: 47374 RVA: 0x0005617B File Offset: 0x0005437B
		public unsafe float MinInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MinInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MinInterval)) = value;
			}
		}

		// Token: 0x170037E7 RID: 14311
		// (get) Token: 0x0600B90F RID: 47375 RVA: 0x002FB968 File Offset: 0x002F9B68
		// (set) Token: 0x0600B910 RID: 47376 RVA: 0x00056196 File Offset: 0x00054396
		public unsafe float MaxInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MaxInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MaxInterval)) = value;
			}
		}

		// Token: 0x170037E8 RID: 14312
		// (get) Token: 0x0600B911 RID: 47377 RVA: 0x002FB990 File Offset: 0x002F9B90
		// (set) Token: 0x0600B912 RID: 47378 RVA: 0x000561B1 File Offset: 0x000543B1
		public unsafe float SpawnRateMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_SpawnRateMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_SpawnRateMultiplier)) = value;
			}
		}

		// Token: 0x170037E9 RID: 14313
		// (get) Token: 0x0600B913 RID: 47379 RVA: 0x002FB9B8 File Offset: 0x002F9BB8
		// (set) Token: 0x0600B914 RID: 47380 RVA: 0x000561CC File Offset: 0x000543CC
		public unsafe Vector2 MinScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MinScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MinScale)) = value;
			}
		}

		// Token: 0x170037EA RID: 14314
		// (get) Token: 0x0600B915 RID: 47381 RVA: 0x002FB9E0 File Offset: 0x002F9BE0
		// (set) Token: 0x0600B916 RID: 47382 RVA: 0x000561E7 File Offset: 0x000543E7
		public unsafe Vector2 MaxScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MaxScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MaxScale)) = value;
			}
		}

		// Token: 0x170037EB RID: 14315
		// (get) Token: 0x0600B917 RID: 47383 RVA: 0x002FBA08 File Offset: 0x002F9C08
		// (set) Token: 0x0600B918 RID: 47384 RVA: 0x00056202 File Offset: 0x00054402
		public unsafe bool UniformScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_UniformScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_UniformScale)) = value;
			}
		}

		// Token: 0x170037EC RID: 14316
		// (get) Token: 0x0600B919 RID: 47385 RVA: 0x002FBA30 File Offset: 0x002F9C30
		// (set) Token: 0x0600B91A RID: 47386 RVA: 0x0005621D File Offset: 0x0005441D
		public unsafe float nextSpawnTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_nextSpawnTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_nextSpawnTime)) = value;
			}
		}

		// Token: 0x170037ED RID: 14317
		// (get) Token: 0x0600B91B RID: 47387 RVA: 0x002FBA58 File Offset: 0x002F9C58
		// (set) Token: 0x0600B91C RID: 47388 RVA: 0x00056238 File Offset: 0x00054438
		public unsafe UnityEvent<GameObject> OnSpawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_OnSpawn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_OnSpawn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007EF5 RID: 32501
		private static readonly IntPtr NativeFieldInfoPtr_SpawnArea;

		// Token: 0x04007EF6 RID: 32502
		private static readonly IntPtr NativeFieldInfoPtr_Prefabs;

		// Token: 0x04007EF7 RID: 32503
		private static readonly IntPtr NativeFieldInfoPtr_MinInterval;

		// Token: 0x04007EF8 RID: 32504
		private static readonly IntPtr NativeFieldInfoPtr_MaxInterval;

		// Token: 0x04007EF9 RID: 32505
		private static readonly IntPtr NativeFieldInfoPtr_SpawnRateMultiplier;

		// Token: 0x04007EFA RID: 32506
		private static readonly IntPtr NativeFieldInfoPtr_MinScale;

		// Token: 0x04007EFB RID: 32507
		private static readonly IntPtr NativeFieldInfoPtr_MaxScale;

		// Token: 0x04007EFC RID: 32508
		private static readonly IntPtr NativeFieldInfoPtr_UniformScale;

		// Token: 0x04007EFD RID: 32509
		private static readonly IntPtr NativeFieldInfoPtr_nextSpawnTime;

		// Token: 0x04007EFE RID: 32510
		private static readonly IntPtr NativeFieldInfoPtr_OnSpawn;

		// Token: 0x04007EFF RID: 32511
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007F00 RID: 32512
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007F01 RID: 32513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
