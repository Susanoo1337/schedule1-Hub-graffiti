using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200051F RID: 1311
	public class PourableAdditive : Pourable
	{
		// Token: 0x060076F9 RID: 30457 RVA: 0x00211A88 File Offset: 0x0020FC88
		// Note: this type is marked as 'beforefieldinit'.
		static PourableAdditive()
		{
			Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "PourableAdditive");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr);
			PourableAdditive.NativeFieldInfoPtr_NormalizedAmountForSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, "NormalizedAmountForSuccess");
			PourableAdditive.NativeFieldInfoPtr_AdditiveDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, "AdditiveDefinition");
			PourableAdditive.NativeFieldInfoPtr_LiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, "LiquidColor");
			PourableAdditive.NativeFieldInfoPtr_pouredAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, "pouredAmount");
			PourableAdditive.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, 100678579);
			PourableAdditive.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, 100678580);
		}

		// Token: 0x060076FA RID: 30458 RVA: 0x00211B30 File Offset: 0x0020FD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230397, XrefRangeEnd = 230398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PourAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableAdditive.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076FB RID: 30459 RVA: 0x00211B7C File Offset: 0x0020FD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourableAdditive() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableAdditive.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076FC RID: 30460 RVA: 0x00038CD2 File Offset: 0x00036ED2
		public PourableAdditive(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024CD RID: 9421
		// (get) Token: 0x060076FD RID: 30461 RVA: 0x00211BB8 File Offset: 0x0020FDB8
		// (set) Token: 0x060076FE RID: 30462 RVA: 0x00038CDB File Offset: 0x00036EDB
		public unsafe static float NormalizedAmountForSuccess
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PourableAdditive.NativeFieldInfoPtr_NormalizedAmountForSuccess, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PourableAdditive.NativeFieldInfoPtr_NormalizedAmountForSuccess, (void*)(&value));
			}
		}

		// Token: 0x170024CE RID: 9422
		// (get) Token: 0x060076FF RID: 30463 RVA: 0x00211BD4 File Offset: 0x0020FDD4
		// (set) Token: 0x06007700 RID: 30464 RVA: 0x00038CE9 File Offset: 0x00036EE9
		public unsafe AdditiveDefinition AdditiveDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_AdditiveDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdditiveDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_AdditiveDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024CF RID: 9423
		// (get) Token: 0x06007701 RID: 30465 RVA: 0x00211C04 File Offset: 0x0020FE04
		// (set) Token: 0x06007702 RID: 30466 RVA: 0x00038D08 File Offset: 0x00036F08
		public unsafe Color LiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_LiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_LiquidColor)) = value;
			}
		}

		// Token: 0x170024D0 RID: 9424
		// (get) Token: 0x06007703 RID: 30467 RVA: 0x00211C2C File Offset: 0x0020FE2C
		// (set) Token: 0x06007704 RID: 30468 RVA: 0x00038D23 File Offset: 0x00036F23
		public unsafe float pouredAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_pouredAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_pouredAmount)) = value;
			}
		}

		// Token: 0x04005107 RID: 20743
		private static readonly IntPtr NativeFieldInfoPtr_NormalizedAmountForSuccess;

		// Token: 0x04005108 RID: 20744
		private static readonly IntPtr NativeFieldInfoPtr_AdditiveDefinition;

		// Token: 0x04005109 RID: 20745
		private static readonly IntPtr NativeFieldInfoPtr_LiquidColor;

		// Token: 0x0400510A RID: 20746
		private static readonly IntPtr NativeFieldInfoPtr_pouredAmount;

		// Token: 0x0400510B RID: 20747
		private static readonly IntPtr NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0;

		// Token: 0x0400510C RID: 20748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
