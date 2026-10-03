using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x0200038C RID: 908
	public class ProximityCircle : MonoBehaviour
	{
		// Token: 0x06005088 RID: 20616 RVA: 0x00190164 File Offset: 0x0018E364
		// Note: this type is marked as 'beforefieldinit'.
		static ProximityCircle()
		{
			Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "ProximityCircle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr);
			ProximityCircle.NativeFieldInfoPtr_Circle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, "Circle");
			ProximityCircle.NativeFieldInfoPtr_enabledThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, "enabledThisFrame");
			ProximityCircle.NativeFieldInfoPtr_materialInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, "materialInstance");
			ProximityCircle.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, 100673740);
			ProximityCircle.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, 100673741);
			ProximityCircle.NativeMethodInfoPtr_SetRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, 100673742);
			ProximityCircle.NativeMethodInfoPtr_SetAlpha_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, 100673743);
			ProximityCircle.NativeMethodInfoPtr_SetColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, 100673744);
			ProximityCircle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, 100673745);
		}

		// Token: 0x06005089 RID: 20617 RVA: 0x00190248 File Offset: 0x0018E448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179190, XrefRangeEnd = 179199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProximityCircle.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600508A RID: 20618 RVA: 0x0019027C File Offset: 0x0018E47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179199, XrefRangeEnd = 179201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProximityCircle.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600508B RID: 20619 RVA: 0x001902B0 File Offset: 0x0018E4B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 179202, RefRangeEnd = 179204, XrefRangeStart = 179201, XrefRangeEnd = 179202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRadius(float rad)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rad;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProximityCircle.NativeMethodInfoPtr_SetRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600508C RID: 20620 RVA: 0x001902F0 File Offset: 0x0018E4F0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 179207, RefRangeEnd = 179214, XrefRangeStart = 179204, XrefRangeEnd = 179207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProximityCircle.NativeMethodInfoPtr_SetAlpha_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600508D RID: 20621 RVA: 0x00190330 File Offset: 0x0018E530
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 179215, RefRangeEnd = 179219, XrefRangeStart = 179214, XrefRangeEnd = 179215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProximityCircle.NativeMethodInfoPtr_SetColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600508E RID: 20622 RVA: 0x00190370 File Offset: 0x0018E570
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProximityCircle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProximityCircle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600508F RID: 20623 RVA: 0x000268F9 File Offset: 0x00024AF9
		public ProximityCircle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x06005090 RID: 20624 RVA: 0x001903AC File Offset: 0x0018E5AC
		// (set) Token: 0x06005091 RID: 20625 RVA: 0x00026902 File Offset: 0x00024B02
		public unsafe DecalProjector Circle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProximityCircle.NativeFieldInfoPtr_Circle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalProjector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProximityCircle.NativeFieldInfoPtr_Circle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x06005092 RID: 20626 RVA: 0x001903DC File Offset: 0x0018E5DC
		// (set) Token: 0x06005093 RID: 20627 RVA: 0x00026921 File Offset: 0x00024B21
		public unsafe bool enabledThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProximityCircle.NativeFieldInfoPtr_enabledThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProximityCircle.NativeFieldInfoPtr_enabledThisFrame)) = value;
			}
		}

		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x06005094 RID: 20628 RVA: 0x00190404 File Offset: 0x0018E604
		// (set) Token: 0x06005095 RID: 20629 RVA: 0x0002693C File Offset: 0x00024B3C
		public unsafe Material materialInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProximityCircle.NativeFieldInfoPtr_materialInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProximityCircle.NativeFieldInfoPtr_materialInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003729 RID: 14121
		private static readonly IntPtr NativeFieldInfoPtr_Circle;

		// Token: 0x0400372A RID: 14122
		private static readonly IntPtr NativeFieldInfoPtr_enabledThisFrame;

		// Token: 0x0400372B RID: 14123
		private static readonly IntPtr NativeFieldInfoPtr_materialInstance;

		// Token: 0x0400372C RID: 14124
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400372D RID: 14125
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400372E RID: 14126
		private static readonly IntPtr NativeMethodInfoPtr_SetRadius_Public_Void_Single_0;

		// Token: 0x0400372F RID: 14127
		private static readonly IntPtr NativeMethodInfoPtr_SetAlpha_Public_Void_Single_0;

		// Token: 0x04003730 RID: 14128
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Color_0;

		// Token: 0x04003731 RID: 14129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
