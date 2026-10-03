using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Development
{
	// Token: 0x02000705 RID: 1797
	public class DevTesting : MonoBehaviour
	{
		// Token: 0x0600AD4F RID: 44367 RVA: 0x002D8EBC File Offset: 0x002D70BC
		// Note: this type is marked as 'beforefieldinit'.
		static DevTesting()
		{
			Il2CppClassPointerStore<DevTesting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Development", "DevTesting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DevTesting>.NativeClassPtr);
			DevTesting.NativeFieldInfoPtr__example = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DevTesting>.NativeClassPtr, "_example");
			DevTesting.NativeFieldInfoPtr__temp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DevTesting>.NativeClassPtr, "_temp");
			DevTesting.NativeMethodInfoPtr_GetRequiredSize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevTesting>.NativeClassPtr, 100686181);
			DevTesting.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevTesting>.NativeClassPtr, 100686182);
			DevTesting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevTesting>.NativeClassPtr, 100686183);
		}

		// Token: 0x0600AD50 RID: 44368 RVA: 0x002D8F50 File Offset: 0x002D7150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296924, XrefRangeEnd = 296937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRequiredSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DevTesting.NativeMethodInfoPtr_GetRequiredSize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD51 RID: 44369 RVA: 0x002D8F84 File Offset: 0x002D7184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296937, XrefRangeEnd = 296944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DevTesting.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD52 RID: 44370 RVA: 0x002D8FB8 File Offset: 0x002D71B8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DevTesting() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DevTesting>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DevTesting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AD53 RID: 44371 RVA: 0x0004F32F File Offset: 0x0004D52F
		public DevTesting(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170033F3 RID: 13299
		// (get) Token: 0x0600AD54 RID: 44372 RVA: 0x002D8FF4 File Offset: 0x002D71F4
		// (set) Token: 0x0600AD55 RID: 44373 RVA: 0x0004F338 File Offset: 0x0004D538
		public unsafe string _example
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DevTesting.NativeFieldInfoPtr__example);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DevTesting.NativeFieldInfoPtr__example), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170033F4 RID: 13300
		// (get) Token: 0x0600AD56 RID: 44374 RVA: 0x002D901C File Offset: 0x002D721C
		// (set) Token: 0x0600AD57 RID: 44375 RVA: 0x0004F357 File Offset: 0x0004D557
		public unsafe TextMeshProUGUI _temp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DevTesting.NativeFieldInfoPtr__temp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DevTesting.NativeFieldInfoPtr__temp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040077B8 RID: 30648
		private static readonly IntPtr NativeFieldInfoPtr__example;

		// Token: 0x040077B9 RID: 30649
		private static readonly IntPtr NativeFieldInfoPtr__temp;

		// Token: 0x040077BA RID: 30650
		private static readonly IntPtr NativeMethodInfoPtr_GetRequiredSize_Private_Void_0;

		// Token: 0x040077BB RID: 30651
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040077BC RID: 30652
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
