using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000756 RID: 1878
	public class PropagateDrag : MonoBehaviour
	{
		// Token: 0x0600B72A RID: 46890 RVA: 0x002F5E44 File Offset: 0x002F4044
		// Note: this type is marked as 'beforefieldinit'.
		static PropagateDrag()
		{
			Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PropagateDrag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr);
			PropagateDrag.NativeFieldInfoPtr_ScrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, "ScrollView");
			PropagateDrag.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100687256);
			PropagateDrag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100687257);
			PropagateDrag.NativeMethodInfoPtr__Start_b__1_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100687258);
			PropagateDrag.NativeMethodInfoPtr__Start_b__1_1_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100687259);
			PropagateDrag.NativeMethodInfoPtr__Start_b__1_2_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100687260);
			PropagateDrag.NativeMethodInfoPtr__Start_b__1_3_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100687261);
			PropagateDrag.NativeMethodInfoPtr__Start_b__1_4_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr, 100687262);
		}

		// Token: 0x0600B72B RID: 46891 RVA: 0x002F5F14 File Offset: 0x002F4114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307536, XrefRangeEnd = 307619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B72C RID: 46892 RVA: 0x002F5F48 File Offset: 0x002F4148
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropagateDrag() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropagateDrag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B72D RID: 46893 RVA: 0x002F5F84 File Offset: 0x002F4184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307619, XrefRangeEnd = 307623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__1_0(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__Start_b__1_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B72E RID: 46894 RVA: 0x002F5FC8 File Offset: 0x002F41C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307623, XrefRangeEnd = 307627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__1_1(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__Start_b__1_1_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B72F RID: 46895 RVA: 0x002F600C File Offset: 0x002F420C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307627, XrefRangeEnd = 307631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__1_2(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__Start_b__1_2_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B730 RID: 46896 RVA: 0x002F6050 File Offset: 0x002F4250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307631, XrefRangeEnd = 307635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__1_3(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__Start_b__1_3_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B731 RID: 46897 RVA: 0x002F6094 File Offset: 0x002F4294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307635, XrefRangeEnd = 307639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__1_4(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropagateDrag.NativeMethodInfoPtr__Start_b__1_4_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B732 RID: 46898 RVA: 0x0005508E File Offset: 0x0005328E
		public PropagateDrag(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700374F RID: 14159
		// (get) Token: 0x0600B733 RID: 46899 RVA: 0x002F60D8 File Offset: 0x002F42D8
		// (set) Token: 0x0600B734 RID: 46900 RVA: 0x00055097 File Offset: 0x00053297
		public unsafe ScrollRect ScrollView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropagateDrag.NativeFieldInfoPtr_ScrollView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropagateDrag.NativeFieldInfoPtr_ScrollView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007DD4 RID: 32212
		private static readonly IntPtr NativeFieldInfoPtr_ScrollView;

		// Token: 0x04007DD5 RID: 32213
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007DD6 RID: 32214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007DD7 RID: 32215
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_0_Private_Void_BaseEventData_0;

		// Token: 0x04007DD8 RID: 32216
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_1_Private_Void_BaseEventData_0;

		// Token: 0x04007DD9 RID: 32217
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_2_Private_Void_BaseEventData_0;

		// Token: 0x04007DDA RID: 32218
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_3_Private_Void_BaseEventData_0;

		// Token: 0x04007DDB RID: 32219
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_4_Private_Void_BaseEventData_0;
	}
}
