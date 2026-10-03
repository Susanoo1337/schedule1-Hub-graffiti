using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000715 RID: 1813
	public class QualitySetter : MonoBehaviour
	{
		// Token: 0x0600AEB5 RID: 44725 RVA: 0x002DCD80 File Offset: 0x002DAF80
		// Note: this type is marked as 'beforefieldinit'.
		static QualitySetter()
		{
			Il2CppClassPointerStore<QualitySetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "QualitySetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr);
			QualitySetter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr, 100686286);
			QualitySetter.NativeMethodInfoPtr_SetQuality_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr, 100686287);
			QualitySetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr, 100686288);
			QualitySetter.NativeMethodInfoPtr__Awake_b__0_0_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr, 100686289);
		}

		// Token: 0x0600AEB6 RID: 44726 RVA: 0x002DCE00 File Offset: 0x002DB000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298069, XrefRangeEnd = 298082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySetter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEB7 RID: 44727 RVA: 0x002DCE34 File Offset: 0x002DB034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298082, XrefRangeEnd = 298091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuality(int quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySetter.NativeMethodInfoPtr_SetQuality_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEB8 RID: 44728 RVA: 0x002DCE74 File Offset: 0x002DB074
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualitySetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualitySetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEB9 RID: 44729 RVA: 0x002DCEB0 File Offset: 0x002DB0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298091, XrefRangeEnd = 298100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__0_0(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualitySetter.NativeMethodInfoPtr__Awake_b__0_0_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEBA RID: 44730 RVA: 0x00050081 File Offset: 0x0004E281
		public QualitySetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400788A RID: 30858
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400788B RID: 30859
		private static readonly IntPtr NativeMethodInfoPtr_SetQuality_Private_Void_Int32_0;

		// Token: 0x0400788C RID: 30860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400788D RID: 30861
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_0_Private_Void_Int32_0;
	}
}
