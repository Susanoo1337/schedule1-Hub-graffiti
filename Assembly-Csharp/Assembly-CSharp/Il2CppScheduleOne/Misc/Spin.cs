using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x020002FE RID: 766
	public class Spin : MonoBehaviour
	{
		// Token: 0x06003CAB RID: 15531 RVA: 0x001477EC File Offset: 0x001459EC
		// Note: this type is marked as 'beforefieldinit'.
		static Spin()
		{
			Il2CppClassPointerStore<Spin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "Spin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spin>.NativeClassPtr);
			Spin.NativeFieldInfoPtr_Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spin>.NativeClassPtr, "Axis");
			Spin.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spin>.NativeClassPtr, "Speed");
			Spin.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spin>.NativeClassPtr, 100671045);
			Spin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spin>.NativeClassPtr, 100671046);
		}

		// Token: 0x06003CAC RID: 15532 RVA: 0x0014786C File Offset: 0x00145A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151392, XrefRangeEnd = 151395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spin.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CAD RID: 15533 RVA: 0x001478A0 File Offset: 0x00145AA0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spin() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CAE RID: 15534 RVA: 0x0001E4D0 File Offset: 0x0001C6D0
		public Spin(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x06003CAF RID: 15535 RVA: 0x001478DC File Offset: 0x00145ADC
		// (set) Token: 0x06003CB0 RID: 15536 RVA: 0x0001E4D9 File Offset: 0x0001C6D9
		public unsafe Vector3 Axis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spin.NativeFieldInfoPtr_Axis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spin.NativeFieldInfoPtr_Axis)) = value;
			}
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x06003CB1 RID: 15537 RVA: 0x00147904 File Offset: 0x00145B04
		// (set) Token: 0x06003CB2 RID: 15538 RVA: 0x0001E4F4 File Offset: 0x0001C6F4
		public unsafe float Speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spin.NativeFieldInfoPtr_Speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spin.NativeFieldInfoPtr_Speed)) = value;
			}
		}

		// Token: 0x040028E5 RID: 10469
		private static readonly IntPtr NativeFieldInfoPtr_Axis;

		// Token: 0x040028E6 RID: 10470
		private static readonly IntPtr NativeFieldInfoPtr_Speed;

		// Token: 0x040028E7 RID: 10471
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040028E8 RID: 10472
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
