using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004D5 RID: 1237
	public class CashPile : MonoBehaviour
	{
		// Token: 0x0600712D RID: 28973 RVA: 0x001FF794 File Offset: 0x001FD994
		// Note: this type is marked as 'beforefieldinit'.
		static CashPile()
		{
			Il2CppClassPointerStore<CashPile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "CashPile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashPile>.NativeClassPtr);
			CashPile.NativeFieldInfoPtr_MAX_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashPile>.NativeClassPtr, "MAX_AMOUNT");
			CashPile.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashPile>.NativeClassPtr, "Container");
			CashPile.NativeFieldInfoPtr_CashInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashPile>.NativeClassPtr, "CashInstances");
			CashPile.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPile>.NativeClassPtr, 100677918);
			CashPile.NativeMethodInfoPtr_SetDisplayedAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPile>.NativeClassPtr, 100677919);
			CashPile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashPile>.NativeClassPtr, 100677920);
		}

		// Token: 0x0600712E RID: 28974 RVA: 0x001FF83C File Offset: 0x001FDA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225185, XrefRangeEnd = 225196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashPile.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600712F RID: 28975 RVA: 0x001FF870 File Offset: 0x001FDA70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225203, RefRangeEnd = 225204, XrefRangeStart = 225196, XrefRangeEnd = 225203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashPile.NativeMethodInfoPtr_SetDisplayedAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007130 RID: 28976 RVA: 0x001FF8B0 File Offset: 0x001FDAB0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashPile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashPile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashPile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007131 RID: 28977 RVA: 0x00035D81 File Offset: 0x00033F81
		public CashPile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022FC RID: 8956
		// (get) Token: 0x06007132 RID: 28978 RVA: 0x001FF8EC File Offset: 0x001FDAEC
		// (set) Token: 0x06007133 RID: 28979 RVA: 0x00035D8A File Offset: 0x00033F8A
		public unsafe static float MAX_AMOUNT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CashPile.NativeFieldInfoPtr_MAX_AMOUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CashPile.NativeFieldInfoPtr_MAX_AMOUNT, (void*)(&value));
			}
		}

		// Token: 0x170022FD RID: 8957
		// (get) Token: 0x06007134 RID: 28980 RVA: 0x001FF908 File Offset: 0x001FDB08
		// (set) Token: 0x06007135 RID: 28981 RVA: 0x00035D98 File Offset: 0x00033F98
		public unsafe Transform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPile.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPile.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022FE RID: 8958
		// (get) Token: 0x06007136 RID: 28982 RVA: 0x001FF938 File Offset: 0x001FDB38
		// (set) Token: 0x06007137 RID: 28983 RVA: 0x00035DB7 File Offset: 0x00033FB7
		public unsafe Il2CppReferenceArray<Transform> CashInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPile.NativeFieldInfoPtr_CashInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashPile.NativeFieldInfoPtr_CashInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D63 RID: 19811
		private static readonly IntPtr NativeFieldInfoPtr_MAX_AMOUNT;

		// Token: 0x04004D64 RID: 19812
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04004D65 RID: 19813
		private static readonly IntPtr NativeFieldInfoPtr_CashInstances;

		// Token: 0x04004D66 RID: 19814
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004D67 RID: 19815
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedAmount_Public_Void_Single_0;

		// Token: 0x04004D68 RID: 19816
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
