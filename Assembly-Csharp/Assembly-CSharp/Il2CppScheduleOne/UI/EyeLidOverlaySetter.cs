using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000730 RID: 1840
	public class EyeLidOverlaySetter : MonoBehaviour
	{
		// Token: 0x0600B17F RID: 45439 RVA: 0x002E569C File Offset: 0x002E389C
		// Note: this type is marked as 'beforefieldinit'.
		static EyeLidOverlaySetter()
		{
			Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "EyeLidOverlaySetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr);
			EyeLidOverlaySetter.NativeFieldInfoPtr_OpenOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr, "OpenOverride");
			EyeLidOverlaySetter.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr, 100686635);
			EyeLidOverlaySetter.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr, 100686636);
			EyeLidOverlaySetter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr, 100686637);
			EyeLidOverlaySetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr, 100686638);
		}

		// Token: 0x0600B180 RID: 45440 RVA: 0x002E5730 File Offset: 0x002E3930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301040, XrefRangeEnd = 301047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeLidOverlaySetter.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B181 RID: 45441 RVA: 0x002E5764 File Offset: 0x002E3964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301047, XrefRangeEnd = 301054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeLidOverlaySetter.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B182 RID: 45442 RVA: 0x002E5798 File Offset: 0x002E3998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301054, XrefRangeEnd = 301062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeLidOverlaySetter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B183 RID: 45443 RVA: 0x002E57CC File Offset: 0x002E39CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 68082, RefRangeEnd = 68086, XrefRangeStart = 68082, XrefRangeEnd = 68086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EyeLidOverlaySetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyeLidOverlaySetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeLidOverlaySetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B184 RID: 45444 RVA: 0x0005197D File Offset: 0x0004FB7D
		public EyeLidOverlaySetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003559 RID: 13657
		// (get) Token: 0x0600B185 RID: 45445 RVA: 0x002E5808 File Offset: 0x002E3A08
		// (set) Token: 0x0600B186 RID: 45446 RVA: 0x00051986 File Offset: 0x0004FB86
		public unsafe float OpenOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeLidOverlaySetter.NativeFieldInfoPtr_OpenOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeLidOverlaySetter.NativeFieldInfoPtr_OpenOverride)) = value;
			}
		}

		// Token: 0x04007A4C RID: 31308
		private static readonly IntPtr NativeFieldInfoPtr_OpenOverride;

		// Token: 0x04007A4D RID: 31309
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04007A4E RID: 31310
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04007A4F RID: 31311
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007A50 RID: 31312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
