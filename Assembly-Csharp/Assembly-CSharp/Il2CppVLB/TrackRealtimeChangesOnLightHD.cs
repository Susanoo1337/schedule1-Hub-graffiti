using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200005B RID: 91
	public class TrackRealtimeChangesOnLightHD : MonoBehaviour
	{
		// Token: 0x0600051B RID: 1307 RVA: 0x0008A740 File Offset: 0x00088940
		// Note: this type is marked as 'beforefieldinit'.
		static TrackRealtimeChangesOnLightHD()
		{
			Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "TrackRealtimeChangesOnLightHD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr);
			TrackRealtimeChangesOnLightHD.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr, "ClassName");
			TrackRealtimeChangesOnLightHD.NativeFieldInfoPtr_m_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr, "m_Master");
			TrackRealtimeChangesOnLightHD.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr, 100663834);
			TrackRealtimeChangesOnLightHD.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr, 100663835);
			TrackRealtimeChangesOnLightHD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr, 100663836);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0008A7D4 File Offset: 0x000889D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70125, XrefRangeEnd = 70129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackRealtimeChangesOnLightHD.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0008A808 File Offset: 0x00088A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70129, XrefRangeEnd = 70131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackRealtimeChangesOnLightHD.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0008A83C File Offset: 0x00088A3C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackRealtimeChangesOnLightHD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackRealtimeChangesOnLightHD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00004CC5 File Offset: 0x00002EC5
		public TrackRealtimeChangesOnLightHD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x0008A878 File Offset: 0x00088A78
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00004CCE File Offset: 0x00002ECE
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TrackRealtimeChangesOnLightHD.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrackRealtimeChangesOnLightHD.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x0008A898 File Offset: 0x00088A98
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x00004CE0 File Offset: 0x00002EE0
		public unsafe VolumetricLightBeamHD m_Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackRealtimeChangesOnLightHD.NativeFieldInfoPtr_m_Master);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamHD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackRealtimeChangesOnLightHD.NativeFieldInfoPtr_m_Master), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeFieldInfoPtr_m_Master;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
