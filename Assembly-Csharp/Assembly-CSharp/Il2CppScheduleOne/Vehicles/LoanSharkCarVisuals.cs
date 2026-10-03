using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020000CE RID: 206
	public class LoanSharkCarVisuals : MonoBehaviour
	{
		// Token: 0x060013FC RID: 5116 RVA: 0x000BEAC4 File Offset: 0x000BCCC4
		// Note: this type is marked as 'beforefieldinit'.
		static LoanSharkCarVisuals()
		{
			Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "LoanSharkCarVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr);
			LoanSharkCarVisuals.NativeFieldInfoPtr_Note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr, "Note");
			LoanSharkCarVisuals.NativeFieldInfoPtr_BulletHoleDecals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr, "BulletHoleDecals");
			LoanSharkCarVisuals.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr, 100666198);
			LoanSharkCarVisuals.NativeMethodInfoPtr_Configure_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr, 100666199);
			LoanSharkCarVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr, 100666200);
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x000BEB58 File Offset: 0x000BCD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93511, XrefRangeEnd = 93516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoanSharkCarVisuals.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x000BEB8C File Offset: 0x000BCD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93516, XrefRangeEnd = 93519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Configure(bool enabled, bool noteVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref noteVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoanSharkCarVisuals.NativeMethodInfoPtr_Configure_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x000BEBD8 File Offset: 0x000BCDD8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoanSharkCarVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoanSharkCarVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoanSharkCarVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x0000AFCC File Offset: 0x000091CC
		public LoanSharkCarVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x000BEC14 File Offset: 0x000BCE14
		// (set) Token: 0x06001402 RID: 5122 RVA: 0x0000AFD5 File Offset: 0x000091D5
		public unsafe GameObject Note
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoanSharkCarVisuals.NativeFieldInfoPtr_Note);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoanSharkCarVisuals.NativeFieldInfoPtr_Note), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x000BEC44 File Offset: 0x000BCE44
		// (set) Token: 0x06001404 RID: 5124 RVA: 0x0000AFF4 File Offset: 0x000091F4
		public unsafe GameObject BulletHoleDecals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoanSharkCarVisuals.NativeFieldInfoPtr_BulletHoleDecals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoanSharkCarVisuals.NativeFieldInfoPtr_BulletHoleDecals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeFieldInfoPtr_Note;

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeFieldInfoPtr_BulletHoleDecals;

		// Token: 0x04000E28 RID: 3624
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000E29 RID: 3625
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000E2A RID: 3626
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
