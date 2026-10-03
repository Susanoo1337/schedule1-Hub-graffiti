using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x0200019F RID: 415
	public class VisionObscurer : MonoBehaviour
	{
		// Token: 0x06002A07 RID: 10759 RVA: 0x00105EF4 File Offset: 0x001040F4
		// Note: this type is marked as 'beforefieldinit'.
		static VisionObscurer()
		{
			Il2CppClassPointerStore<VisionObscurer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "VisionObscurer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionObscurer>.NativeClassPtr);
			VisionObscurer.NativeFieldInfoPtr_ObscuranceAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionObscurer>.NativeClassPtr, "ObscuranceAmount");
			VisionObscurer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionObscurer>.NativeClassPtr, 100668662);
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x00105F4C File Offset: 0x0010414C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123677, XrefRangeEnd = 123678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisionObscurer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionObscurer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionObscurer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x00016003 File Offset: 0x00014203
		public VisionObscurer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06002A0A RID: 10762 RVA: 0x00105F88 File Offset: 0x00104188
		// (set) Token: 0x06002A0B RID: 10763 RVA: 0x0001600C File Offset: 0x0001420C
		public unsafe float ObscuranceAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionObscurer.NativeFieldInfoPtr_ObscuranceAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionObscurer.NativeFieldInfoPtr_ObscuranceAmount)) = value;
			}
		}

		// Token: 0x04001CE8 RID: 7400
		private static readonly IntPtr NativeFieldInfoPtr_ObscuranceAmount;

		// Token: 0x04001CE9 RID: 7401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
