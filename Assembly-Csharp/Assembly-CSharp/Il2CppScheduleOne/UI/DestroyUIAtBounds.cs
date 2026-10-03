using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000766 RID: 1894
	public class DestroyUIAtBounds : MonoBehaviour
	{
		// Token: 0x0600B88F RID: 47247 RVA: 0x002FA2B4 File Offset: 0x002F84B4
		// Note: this type is marked as 'beforefieldinit'.
		static DestroyUIAtBounds()
		{
			Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DestroyUIAtBounds");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr);
			DestroyUIAtBounds.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr, "Rect");
			DestroyUIAtBounds.NativeFieldInfoPtr_MinBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr, "MinBounds");
			DestroyUIAtBounds.NativeFieldInfoPtr_MaxBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr, "MaxBounds");
			DestroyUIAtBounds.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr, 100687437);
			DestroyUIAtBounds.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr, 100687438);
		}

		// Token: 0x0600B890 RID: 47248 RVA: 0x002FA348 File Offset: 0x002F8548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309178, XrefRangeEnd = 309187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DestroyUIAtBounds.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B891 RID: 47249 RVA: 0x002FA37C File Offset: 0x002F857C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309187, XrefRangeEnd = 309188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DestroyUIAtBounds() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DestroyUIAtBounds.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B892 RID: 47250 RVA: 0x00055CE5 File Offset: 0x00053EE5
		public DestroyUIAtBounds(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037BF RID: 14271
		// (get) Token: 0x0600B893 RID: 47251 RVA: 0x002FA3B8 File Offset: 0x002F85B8
		// (set) Token: 0x0600B894 RID: 47252 RVA: 0x00055CEE File Offset: 0x00053EEE
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037C0 RID: 14272
		// (get) Token: 0x0600B895 RID: 47253 RVA: 0x002FA3E8 File Offset: 0x002F85E8
		// (set) Token: 0x0600B896 RID: 47254 RVA: 0x00055D0D File Offset: 0x00053F0D
		public unsafe Vector2 MinBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_MinBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_MinBounds)) = value;
			}
		}

		// Token: 0x170037C1 RID: 14273
		// (get) Token: 0x0600B897 RID: 47255 RVA: 0x002FA410 File Offset: 0x002F8610
		// (set) Token: 0x0600B898 RID: 47256 RVA: 0x00055D28 File Offset: 0x00053F28
		public unsafe Vector2 MaxBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_MaxBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_MaxBounds)) = value;
			}
		}

		// Token: 0x04007EB2 RID: 32434
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04007EB3 RID: 32435
		private static readonly IntPtr NativeFieldInfoPtr_MinBounds;

		// Token: 0x04007EB4 RID: 32436
		private static readonly IntPtr NativeFieldInfoPtr_MaxBounds;

		// Token: 0x04007EB5 RID: 32437
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04007EB6 RID: 32438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
