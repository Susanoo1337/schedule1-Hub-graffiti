using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Core.Weather;

namespace Il2CppScheduleOne.Weather
{
	// Token: 0x020006D0 RID: 1744
	public class CloudController : WeatherEffectController
	{
		// Token: 0x0600A788 RID: 42888 RVA: 0x002C69D4 File Offset: 0x002C4BD4
		// Note: this type is marked as 'beforefieldinit'.
		static CloudController()
		{
			Il2CppClassPointerStore<CloudController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Weather", "CloudController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloudController>.NativeClassPtr);
			CloudController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Weather.CloudControllerAssembly-CSharp.dll_Excuted");
			CloudController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Weather.CloudControllerAssembly-CSharp.dll_Excuted");
			CloudController.NativeMethodInfoPtr_Initialise_Public_Void_WeatherVolume_CloudSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudController>.NativeClassPtr, 100685551);
			CloudController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudController>.NativeClassPtr, 100685552);
			CloudController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudController>.NativeClassPtr, 100685553);
			CloudController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudController>.NativeClassPtr, 100685554);
			CloudController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudController>.NativeClassPtr, 100685555);
			CloudController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudController>.NativeClassPtr, 100685556);
		}

		// Token: 0x0600A789 RID: 42889 RVA: 0x002C6AA4 File Offset: 0x002C4CA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291040, RefRangeEnd = 291041, XrefRangeStart = 291039, XrefRangeEnd = 291040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialise(WeatherVolume mainVolume, CloudSettings cloudSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mainVolume);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cloudSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloudController.NativeMethodInfoPtr_Initialise_Public_Void_WeatherVolume_CloudSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A78A RID: 42890 RVA: 0x002C6AF8 File Offset: 0x002C4CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291041, XrefRangeEnd = 291042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CloudController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloudController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloudController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A78B RID: 42891 RVA: 0x002C6B34 File Offset: 0x002C4D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291042, XrefRangeEnd = 291043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CloudController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A78C RID: 42892 RVA: 0x002C6B70 File Offset: 0x002C4D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291043, XrefRangeEnd = 291044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CloudController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A78D RID: 42893 RVA: 0x002C6BAC File Offset: 0x002C4DAC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CloudController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A78E RID: 42894 RVA: 0x002C6BE8 File Offset: 0x002C4DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291044, XrefRangeEnd = 291045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CloudController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A78F RID: 42895 RVA: 0x0004C2AE File Offset: 0x0004A4AE
		public CloudController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003205 RID: 12805
		// (get) Token: 0x0600A790 RID: 42896 RVA: 0x002C6C24 File Offset: 0x002C4E24
		// (set) Token: 0x0600A791 RID: 42897 RVA: 0x0004C2B7 File Offset: 0x0004A4B7
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloudController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloudController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003206 RID: 12806
		// (get) Token: 0x0600A792 RID: 42898 RVA: 0x002C6C4C File Offset: 0x002C4E4C
		// (set) Token: 0x0600A793 RID: 42899 RVA: 0x0004C2D2 File Offset: 0x0004A4D2
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloudController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloudController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040073D4 RID: 29652
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040073D5 RID: 29653
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040073D6 RID: 29654
		private static readonly IntPtr NativeMethodInfoPtr_Initialise_Public_Void_WeatherVolume_CloudSettings_0;

		// Token: 0x040073D7 RID: 29655
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040073D8 RID: 29656
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040073D9 RID: 29657
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040073DA RID: 29658
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040073DB RID: 29659
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
