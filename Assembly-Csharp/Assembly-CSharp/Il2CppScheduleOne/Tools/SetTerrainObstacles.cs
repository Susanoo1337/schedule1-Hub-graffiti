using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004FD RID: 1277
	public class SetTerrainObstacles : MonoBehaviour
	{
		// Token: 0x0600732E RID: 29486 RVA: 0x00205B90 File Offset: 0x00203D90
		// Note: this type is marked as 'beforefieldinit'.
		static SetTerrainObstacles()
		{
			Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SetTerrainObstacles");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr);
			SetTerrainObstacles.NativeFieldInfoPtr_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "Bounds");
			SetTerrainObstacles.NativeFieldInfoPtr_Obstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "Obstacle");
			SetTerrainObstacles.NativeFieldInfoPtr_terrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "terrain");
			SetTerrainObstacles.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "width");
			SetTerrainObstacles.NativeFieldInfoPtr_lenght = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "lenght");
			SetTerrainObstacles.NativeFieldInfoPtr_hight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "hight");
			SetTerrainObstacles.NativeFieldInfoPtr_isError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, "isError");
			SetTerrainObstacles.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, 100678187);
			SetTerrainObstacles.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr, 100678188);
		}

		// Token: 0x0600732F RID: 29487 RVA: 0x00205C74 File Offset: 0x00203E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227171, XrefRangeEnd = 227321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTerrainObstacles.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007330 RID: 29488 RVA: 0x00205CA8 File Offset: 0x00203EA8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetTerrainObstacles() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetTerrainObstacles>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTerrainObstacles.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007331 RID: 29489 RVA: 0x00036BEC File Offset: 0x00034DEC
		public SetTerrainObstacles(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700237E RID: 9086
		// (get) Token: 0x06007332 RID: 29490 RVA: 0x00205CE4 File Offset: 0x00203EE4
		// (set) Token: 0x06007333 RID: 29491 RVA: 0x00036BF5 File Offset: 0x00034DF5
		public unsafe BoxCollider Bounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_Bounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_Bounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700237F RID: 9087
		// (get) Token: 0x06007334 RID: 29492 RVA: 0x00205D14 File Offset: 0x00203F14
		// (set) Token: 0x06007335 RID: 29493 RVA: 0x00036C14 File Offset: 0x00034E14
		public unsafe Il2CppStructArray<TreeInstance> Obstacle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_Obstacle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TreeInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_Obstacle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002380 RID: 9088
		// (get) Token: 0x06007336 RID: 29494 RVA: 0x00205D44 File Offset: 0x00203F44
		// (set) Token: 0x06007337 RID: 29495 RVA: 0x00036C33 File Offset: 0x00034E33
		public unsafe Terrain terrain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_terrain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Terrain>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_terrain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002381 RID: 9089
		// (get) Token: 0x06007338 RID: 29496 RVA: 0x00205D74 File Offset: 0x00203F74
		// (set) Token: 0x06007339 RID: 29497 RVA: 0x00036C52 File Offset: 0x00034E52
		public unsafe float width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_width)) = value;
			}
		}

		// Token: 0x17002382 RID: 9090
		// (get) Token: 0x0600733A RID: 29498 RVA: 0x00205D9C File Offset: 0x00203F9C
		// (set) Token: 0x0600733B RID: 29499 RVA: 0x00036C6D File Offset: 0x00034E6D
		public unsafe float lenght
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_lenght);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_lenght)) = value;
			}
		}

		// Token: 0x17002383 RID: 9091
		// (get) Token: 0x0600733C RID: 29500 RVA: 0x00205DC4 File Offset: 0x00203FC4
		// (set) Token: 0x0600733D RID: 29501 RVA: 0x00036C88 File Offset: 0x00034E88
		public unsafe float hight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_hight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_hight)) = value;
			}
		}

		// Token: 0x17002384 RID: 9092
		// (get) Token: 0x0600733E RID: 29502 RVA: 0x00205DEC File Offset: 0x00203FEC
		// (set) Token: 0x0600733F RID: 29503 RVA: 0x00036CA3 File Offset: 0x00034EA3
		public unsafe bool isError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_isError);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTerrainObstacles.NativeFieldInfoPtr_isError)) = value;
			}
		}

		// Token: 0x04004E9E RID: 20126
		private static readonly IntPtr NativeFieldInfoPtr_Bounds;

		// Token: 0x04004E9F RID: 20127
		private static readonly IntPtr NativeFieldInfoPtr_Obstacle;

		// Token: 0x04004EA0 RID: 20128
		private static readonly IntPtr NativeFieldInfoPtr_terrain;

		// Token: 0x04004EA1 RID: 20129
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x04004EA2 RID: 20130
		private static readonly IntPtr NativeFieldInfoPtr_lenght;

		// Token: 0x04004EA3 RID: 20131
		private static readonly IntPtr NativeFieldInfoPtr_hight;

		// Token: 0x04004EA4 RID: 20132
		private static readonly IntPtr NativeFieldInfoPtr_isError;

		// Token: 0x04004EA5 RID: 20133
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004EA6 RID: 20134
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
