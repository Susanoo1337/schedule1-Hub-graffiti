using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004FF RID: 1279
	public class SmoothRotate : MonoBehaviour
	{
		// Token: 0x06007368 RID: 29544 RVA: 0x0020652C File Offset: 0x0020472C
		// Note: this type is marked as 'beforefieldinit'.
		static SmoothRotate()
		{
			Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SmoothRotate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr);
			SmoothRotate.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, "Active");
			SmoothRotate.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, "Speed");
			SmoothRotate.NativeFieldInfoPtr_Aceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, "Aceleration");
			SmoothRotate.NativeFieldInfoPtr_Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, "Axis");
			SmoothRotate.NativeFieldInfoPtr_currentSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, "currentSpeed");
			SmoothRotate.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, 100678217);
			SmoothRotate.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, 100678218);
			SmoothRotate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr, 100678219);
		}

		// Token: 0x06007369 RID: 29545 RVA: 0x002065FC File Offset: 0x002047FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227521, XrefRangeEnd = 227530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothRotate.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600736A RID: 29546 RVA: 0x00206630 File Offset: 0x00204830
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothRotate.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600736B RID: 29547 RVA: 0x00206670 File Offset: 0x00204870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227530, XrefRangeEnd = 227533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmoothRotate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothRotate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothRotate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600736C RID: 29548 RVA: 0x00036E2E File Offset: 0x0003502E
		public SmoothRotate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002394 RID: 9108
		// (get) Token: 0x0600736D RID: 29549 RVA: 0x002066AC File Offset: 0x002048AC
		// (set) Token: 0x0600736E RID: 29550 RVA: 0x00036E37 File Offset: 0x00035037
		public unsafe bool Active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Active)) = value;
			}
		}

		// Token: 0x17002395 RID: 9109
		// (get) Token: 0x0600736F RID: 29551 RVA: 0x002066D4 File Offset: 0x002048D4
		// (set) Token: 0x06007370 RID: 29552 RVA: 0x00036E52 File Offset: 0x00035052
		public unsafe float Speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Speed)) = value;
			}
		}

		// Token: 0x17002396 RID: 9110
		// (get) Token: 0x06007371 RID: 29553 RVA: 0x002066FC File Offset: 0x002048FC
		// (set) Token: 0x06007372 RID: 29554 RVA: 0x00036E6D File Offset: 0x0003506D
		public unsafe float Aceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Aceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Aceleration)) = value;
			}
		}

		// Token: 0x17002397 RID: 9111
		// (get) Token: 0x06007373 RID: 29555 RVA: 0x00206724 File Offset: 0x00204924
		// (set) Token: 0x06007374 RID: 29556 RVA: 0x00036E88 File Offset: 0x00035088
		public unsafe Vector3 Axis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Axis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_Axis)) = value;
			}
		}

		// Token: 0x17002398 RID: 9112
		// (get) Token: 0x06007375 RID: 29557 RVA: 0x0020674C File Offset: 0x0020494C
		// (set) Token: 0x06007376 RID: 29558 RVA: 0x00036EA3 File Offset: 0x000350A3
		public unsafe float currentSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_currentSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothRotate.NativeFieldInfoPtr_currentSpeed)) = value;
			}
		}

		// Token: 0x04004EC0 RID: 20160
		private static readonly IntPtr NativeFieldInfoPtr_Active;

		// Token: 0x04004EC1 RID: 20161
		private static readonly IntPtr NativeFieldInfoPtr_Speed;

		// Token: 0x04004EC2 RID: 20162
		private static readonly IntPtr NativeFieldInfoPtr_Aceleration;

		// Token: 0x04004EC3 RID: 20163
		private static readonly IntPtr NativeFieldInfoPtr_Axis;

		// Token: 0x04004EC4 RID: 20164
		private static readonly IntPtr NativeFieldInfoPtr_currentSpeed;

		// Token: 0x04004EC5 RID: 20165
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004EC6 RID: 20166
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

		// Token: 0x04004EC7 RID: 20167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
