using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000503 RID: 1283
	public class ViewmodelEquippableTransformSetter : MonoBehaviour
	{
		// Token: 0x060073A0 RID: 29600 RVA: 0x00206DA0 File Offset: 0x00204FA0
		// Note: this type is marked as 'beforefieldinit'.
		static ViewmodelEquippableTransformSetter()
		{
			Il2CppClassPointerStore<ViewmodelEquippableTransformSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ViewmodelEquippableTransformSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViewmodelEquippableTransformSetter>.NativeClassPtr);
			ViewmodelEquippableTransformSetter.NativeFieldInfoPtr_lastRecordedLocalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelEquippableTransformSetter>.NativeClassPtr, "lastRecordedLocalPosition");
			ViewmodelEquippableTransformSetter.NativeFieldInfoPtr_lastRecordedLocalEulerAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelEquippableTransformSetter>.NativeClassPtr, "lastRecordedLocalEulerAngles");
			ViewmodelEquippableTransformSetter.NativeFieldInfoPtr_lastRecordedLocalScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelEquippableTransformSetter>.NativeClassPtr, "lastRecordedLocalScale");
			ViewmodelEquippableTransformSetter.NativeFieldInfoPtr_transformChangedApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelEquippableTransformSetter>.NativeClassPtr, "transformChangedApplied");
			ViewmodelEquippableTransformSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelEquippableTransformSetter>.NativeClassPtr, 100678227);
		}

		// Token: 0x060073A1 RID: 29601 RVA: 0x00206E34 File Offset: 0x00205034
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ViewmodelEquippableTransformSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViewmodelEquippableTransformSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelEquippableTransformSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073A2 RID: 29602 RVA: 0x0003706F File Offset: 0x0003526F
		public ViewmodelEquippableTransformSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023A7 RID: 9127
		// (get) Token: 0x060073A3 RID: 29603 RVA: 0x00206E70 File Offset: 0x00205070
		// (set) Token: 0x060073A4 RID: 29604 RVA: 0x00037078 File Offset: 0x00035278
		public unsafe static Vector3 lastRecordedLocalPosition
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(ViewmodelEquippableTransformSetter.NativeFieldInfoPtr_lastRecordedLocalPosition, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ViewmodelEquippableTransformSetter.NativeFieldInfoPtr_lastRecordedLocalPosition, (void*)(&value));
			}
		}

		// Token: 0x170023A8 RID: 9128
		// (get) Token: 0x060073A5 RID: 29605 RVA: 0x00206E8C File Offset: 0x0020508C
		// (set) Token: 0x060073A6 RID: 29606 RVA: 0x00037086 File Offset: 0x00035286
		public unsafe static Vector3 lastRecordedLocalEulerAngles
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(ViewmodelEquippableTransformSetter.NativeFieldInfoPtr_lastRecordedLocalEulerAngles, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ViewmodelEquippableTransformSetter.NativeFieldInfoPtr_lastRecordedLocalEulerAngles, (void*)(&value));
			}
		}

		// Token: 0x170023A9 RID: 9129
		// (get) Token: 0x060073A7 RID: 29607 RVA: 0x00206EA8 File Offset: 0x002050A8
		// (set) Token: 0x060073A8 RID: 29608 RVA: 0x00037094 File Offset: 0x00035294
		public unsafe static Vector3 lastRecordedLocalScale
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(ViewmodelEquippableTransformSetter.NativeFieldInfoPtr_lastRecordedLocalScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ViewmodelEquippableTransformSetter.NativeFieldInfoPtr_lastRecordedLocalScale, (void*)(&value));
			}
		}

		// Token: 0x170023AA RID: 9130
		// (get) Token: 0x060073A9 RID: 29609 RVA: 0x00206EC4 File Offset: 0x002050C4
		// (set) Token: 0x060073AA RID: 29610 RVA: 0x000370A2 File Offset: 0x000352A2
		public unsafe static bool transformChangedApplied
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(ViewmodelEquippableTransformSetter.NativeFieldInfoPtr_transformChangedApplied, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ViewmodelEquippableTransformSetter.NativeFieldInfoPtr_transformChangedApplied, (void*)(&value));
			}
		}

		// Token: 0x04004EDD RID: 20189
		private static readonly IntPtr NativeFieldInfoPtr_lastRecordedLocalPosition;

		// Token: 0x04004EDE RID: 20190
		private static readonly IntPtr NativeFieldInfoPtr_lastRecordedLocalEulerAngles;

		// Token: 0x04004EDF RID: 20191
		private static readonly IntPtr NativeFieldInfoPtr_lastRecordedLocalScale;

		// Token: 0x04004EE0 RID: 20192
		private static readonly IntPtr NativeFieldInfoPtr_transformChangedApplied;

		// Token: 0x04004EE1 RID: 20193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
