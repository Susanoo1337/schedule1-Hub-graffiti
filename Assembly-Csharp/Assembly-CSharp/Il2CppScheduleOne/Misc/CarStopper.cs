using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.AI;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x020002F9 RID: 761
	public class CarStopper : MonoBehaviour
	{
		// Token: 0x06003C26 RID: 15398 RVA: 0x00146044 File Offset: 0x00144244
		// Note: this type is marked as 'beforefieldinit'.
		static CarStopper()
		{
			Il2CppClassPointerStore<CarStopper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "CarStopper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarStopper>.NativeClassPtr);
			CarStopper.NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, "isActive");
			CarStopper.NativeFieldInfoPtr_blocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, "blocker");
			CarStopper.NativeFieldInfoPtr_Obstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, "Obstacle");
			CarStopper.NativeFieldInfoPtr_moveTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, "moveTime");
			CarStopper.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, 100671004);
			CarStopper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, 100671005);
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x001460EC File Offset: 0x001442EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150856, XrefRangeEnd = 150861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CarStopper.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x00146128 File Offset: 0x00144328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CarStopper() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarStopper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarStopper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x0001DFE1 File Offset: 0x0001C1E1
		public CarStopper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x06003C2A RID: 15402 RVA: 0x00146164 File Offset: 0x00144364
		// (set) Token: 0x06003C2B RID: 15403 RVA: 0x0001DFEA File Offset: 0x0001C1EA
		public unsafe bool isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_isActive)) = value;
			}
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x06003C2C RID: 15404 RVA: 0x0014618C File Offset: 0x0014438C
		// (set) Token: 0x06003C2D RID: 15405 RVA: 0x0001E005 File Offset: 0x0001C205
		public unsafe Transform blocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_blocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_blocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x06003C2E RID: 15406 RVA: 0x001461BC File Offset: 0x001443BC
		// (set) Token: 0x06003C2F RID: 15407 RVA: 0x0001E024 File Offset: 0x0001C224
		public unsafe NavMeshObstacle Obstacle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_Obstacle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_Obstacle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x06003C30 RID: 15408 RVA: 0x001461EC File Offset: 0x001443EC
		// (set) Token: 0x06003C31 RID: 15409 RVA: 0x0001E043 File Offset: 0x0001C243
		public unsafe float moveTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_moveTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_moveTime)) = value;
			}
		}

		// Token: 0x04002895 RID: 10389
		private static readonly IntPtr NativeFieldInfoPtr_isActive;

		// Token: 0x04002896 RID: 10390
		private static readonly IntPtr NativeFieldInfoPtr_blocker;

		// Token: 0x04002897 RID: 10391
		private static readonly IntPtr NativeFieldInfoPtr_Obstacle;

		// Token: 0x04002898 RID: 10392
		private static readonly IntPtr NativeFieldInfoPtr_moveTime;

		// Token: 0x04002899 RID: 10393
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400289A RID: 10394
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
