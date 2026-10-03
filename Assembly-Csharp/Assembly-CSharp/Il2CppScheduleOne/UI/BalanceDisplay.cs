using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000718 RID: 1816
	public class BalanceDisplay : MonoBehaviour
	{
		// Token: 0x0600AF30 RID: 44848 RVA: 0x002DE494 File Offset: 0x002DC694
		// Note: this type is marked as 'beforefieldinit'.
		static BalanceDisplay()
		{
			Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "BalanceDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr);
			BalanceDisplay.NativeFieldInfoPtr_BalanceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, "BalanceLabel");
			BalanceDisplay.NativeMethodInfoPtr_SetBalance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100686336);
			BalanceDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr, 100686337);
		}

		// Token: 0x0600AF31 RID: 44849 RVA: 0x002DE500 File Offset: 0x002DC700
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 298698, RefRangeEnd = 298703, XrefRangeStart = 298693, XrefRangeEnd = 298698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBalance(float balance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref balance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr_SetBalance_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF32 RID: 44850 RVA: 0x002DE540 File Offset: 0x002DC740
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BalanceDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BalanceDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BalanceDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AF33 RID: 44851 RVA: 0x00050515 File Offset: 0x0004E715
		public BalanceDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003496 RID: 13462
		// (get) Token: 0x0600AF34 RID: 44852 RVA: 0x002DE57C File Offset: 0x002DC77C
		// (set) Token: 0x0600AF35 RID: 44853 RVA: 0x0005051E File Offset: 0x0004E71E
		public unsafe TextMeshProUGUI BalanceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr_BalanceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BalanceDisplay.NativeFieldInfoPtr_BalanceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040078D9 RID: 30937
		private static readonly IntPtr NativeFieldInfoPtr_BalanceLabel;

		// Token: 0x040078DA RID: 30938
		private static readonly IntPtr NativeMethodInfoPtr_SetBalance_Public_Void_Single_0;

		// Token: 0x040078DB RID: 30939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
