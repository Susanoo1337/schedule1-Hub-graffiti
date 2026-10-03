using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004E8 RID: 1256
	public class ImpactDetector : MonoBehaviour
	{
		// Token: 0x06007229 RID: 29225 RVA: 0x00202808 File Offset: 0x00200A08
		// Note: this type is marked as 'beforefieldinit'.
		static ImpactDetector()
		{
			Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ImpactDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr);
			ImpactDetector.NativeFieldInfoPtr_DestroyScriptOnImpact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr, "DestroyScriptOnImpact");
			ImpactDetector.NativeFieldInfoPtr_onImpact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr, "onImpact");
			ImpactDetector.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr, 100678070);
			ImpactDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr, 100678071);
		}

		// Token: 0x0600722A RID: 29226 RVA: 0x00202888 File Offset: 0x00200A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226209, XrefRangeEnd = 226214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpactDetector.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600722B RID: 29227 RVA: 0x002028CC File Offset: 0x00200ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226214, XrefRangeEnd = 226220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImpactDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpactDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600722C RID: 29228 RVA: 0x000364AC File Offset: 0x000346AC
		public ImpactDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002341 RID: 9025
		// (get) Token: 0x0600722D RID: 29229 RVA: 0x00202908 File Offset: 0x00200B08
		// (set) Token: 0x0600722E RID: 29230 RVA: 0x000364B5 File Offset: 0x000346B5
		public unsafe bool DestroyScriptOnImpact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactDetector.NativeFieldInfoPtr_DestroyScriptOnImpact);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactDetector.NativeFieldInfoPtr_DestroyScriptOnImpact)) = value;
			}
		}

		// Token: 0x17002342 RID: 9026
		// (get) Token: 0x0600722F RID: 29231 RVA: 0x00202930 File Offset: 0x00200B30
		// (set) Token: 0x06007230 RID: 29232 RVA: 0x000364D0 File Offset: 0x000346D0
		public unsafe UnityEvent onImpact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactDetector.NativeFieldInfoPtr_onImpact);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactDetector.NativeFieldInfoPtr_onImpact), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004DFD RID: 19965
		private static readonly IntPtr NativeFieldInfoPtr_DestroyScriptOnImpact;

		// Token: 0x04004DFE RID: 19966
		private static readonly IntPtr NativeFieldInfoPtr_onImpact;

		// Token: 0x04004DFF RID: 19967
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;

		// Token: 0x04004E00 RID: 19968
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
