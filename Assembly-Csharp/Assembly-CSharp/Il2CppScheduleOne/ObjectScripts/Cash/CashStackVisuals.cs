using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.Cash
{
	// Token: 0x020005C1 RID: 1473
	public class CashStackVisuals : MonoBehaviour
	{
		// Token: 0x06008F26 RID: 36646 RVA: 0x0026CB28 File Offset: 0x0026AD28
		// Note: this type is marked as 'beforefieldinit'.
		static CashStackVisuals()
		{
			Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.Cash", "CashStackVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr);
			CashStackVisuals.NativeFieldInfoPtr_MAX_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, "MAX_AMOUNT");
			CashStackVisuals.NativeFieldInfoPtr_Visuals_Under100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, "Visuals_Under100");
			CashStackVisuals.NativeFieldInfoPtr_Notes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, "Notes");
			CashStackVisuals.NativeFieldInfoPtr_Visuals_Over100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, "Visuals_Over100");
			CashStackVisuals.NativeFieldInfoPtr_Bills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, "Bills");
			CashStackVisuals.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, 100681862);
			CashStackVisuals.NativeMethodInfoPtr_ShowAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, 100681863);
			CashStackVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr, 100681864);
		}

		// Token: 0x06008F27 RID: 36647 RVA: 0x0026CBF8 File Offset: 0x0026ADF8
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashStackVisuals.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F28 RID: 36648 RVA: 0x0026CC2C File Offset: 0x0026AE2C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 263088, RefRangeEnd = 263092, XrefRangeStart = 263072, XrefRangeEnd = 263088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashStackVisuals.NativeMethodInfoPtr_ShowAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F29 RID: 36649 RVA: 0x0026CC6C File Offset: 0x0026AE6C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashStackVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashStackVisuals>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashStackVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F2A RID: 36650 RVA: 0x00043A18 File Offset: 0x00041C18
		public CashStackVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C62 RID: 11362
		// (get) Token: 0x06008F2B RID: 36651 RVA: 0x0026CCA8 File Offset: 0x0026AEA8
		// (set) Token: 0x06008F2C RID: 36652 RVA: 0x00043A21 File Offset: 0x00041C21
		public unsafe static float MAX_AMOUNT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CashStackVisuals.NativeFieldInfoPtr_MAX_AMOUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CashStackVisuals.NativeFieldInfoPtr_MAX_AMOUNT, (void*)(&value));
			}
		}

		// Token: 0x17002C63 RID: 11363
		// (get) Token: 0x06008F2D RID: 36653 RVA: 0x0026CCC4 File Offset: 0x0026AEC4
		// (set) Token: 0x06008F2E RID: 36654 RVA: 0x00043A2F File Offset: 0x00041C2F
		public unsafe GameObject Visuals_Under100
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Visuals_Under100);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Visuals_Under100), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C64 RID: 11364
		// (get) Token: 0x06008F2F RID: 36655 RVA: 0x0026CCF4 File Offset: 0x0026AEF4
		// (set) Token: 0x06008F30 RID: 36656 RVA: 0x00043A4E File Offset: 0x00041C4E
		public unsafe Il2CppReferenceArray<GameObject> Notes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Notes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Notes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C65 RID: 11365
		// (get) Token: 0x06008F31 RID: 36657 RVA: 0x0026CD24 File Offset: 0x0026AF24
		// (set) Token: 0x06008F32 RID: 36658 RVA: 0x00043A6D File Offset: 0x00041C6D
		public unsafe GameObject Visuals_Over100
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Visuals_Over100);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Visuals_Over100), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C66 RID: 11366
		// (get) Token: 0x06008F33 RID: 36659 RVA: 0x0026CD54 File Offset: 0x0026AF54
		// (set) Token: 0x06008F34 RID: 36660 RVA: 0x00043A8C File Offset: 0x00041C8C
		public unsafe Il2CppReferenceArray<GameObject> Bills
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Bills);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashStackVisuals.NativeFieldInfoPtr_Bills), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006248 RID: 25160
		private static readonly IntPtr NativeFieldInfoPtr_MAX_AMOUNT;

		// Token: 0x04006249 RID: 25161
		private static readonly IntPtr NativeFieldInfoPtr_Visuals_Under100;

		// Token: 0x0400624A RID: 25162
		private static readonly IntPtr NativeFieldInfoPtr_Notes;

		// Token: 0x0400624B RID: 25163
		private static readonly IntPtr NativeFieldInfoPtr_Visuals_Over100;

		// Token: 0x0400624C RID: 25164
		private static readonly IntPtr NativeFieldInfoPtr_Bills;

		// Token: 0x0400624D RID: 25165
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400624E RID: 25166
		private static readonly IntPtr NativeMethodInfoPtr_ShowAmount_Public_Void_Single_0;

		// Token: 0x0400624F RID: 25167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
