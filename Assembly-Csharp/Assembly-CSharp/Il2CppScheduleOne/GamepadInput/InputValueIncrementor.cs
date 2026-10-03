using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.GamepadInput
{
	// Token: 0x0200070D RID: 1805
	public class InputValueIncrementor : MonoBehaviour
	{
		// Token: 0x0600AE20 RID: 44576 RVA: 0x002DB260 File Offset: 0x002D9460
		// Note: this type is marked as 'beforefieldinit'.
		static InputValueIncrementor()
		{
			Il2CppClassPointerStore<InputValueIncrementor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.GamepadInput", "InputValueIncrementor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputValueIncrementor>.NativeClassPtr);
			InputValueIncrementor.NativeFieldInfoPtr__inputValueRamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputValueIncrementor>.NativeClassPtr, "_inputValueRamp");
			InputValueIncrementor.NativeFieldInfoPtr__singleValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputValueIncrementor>.NativeClassPtr, "_singleValue");
			InputValueIncrementor.NativeFieldInfoPtr__multiValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputValueIncrementor>.NativeClassPtr, "_multiValue");
			InputValueIncrementor.NativeMethodInfoPtr_IncrementSingle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputValueIncrementor>.NativeClassPtr, 100686237);
			InputValueIncrementor.NativeMethodInfoPtr_IncrementMulti_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputValueIncrementor>.NativeClassPtr, 100686238);
			InputValueIncrementor.NativeMethodInfoPtr_DecrementSingle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputValueIncrementor>.NativeClassPtr, 100686239);
			InputValueIncrementor.NativeMethodInfoPtr_DecrementMulti_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputValueIncrementor>.NativeClassPtr, 100686240);
			InputValueIncrementor.NativeMethodInfoPtr_Set_Private_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputValueIncrementor>.NativeClassPtr, 100686241);
			InputValueIncrementor.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputValueIncrementor>.NativeClassPtr, 100686242);
			InputValueIncrementor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputValueIncrementor>.NativeClassPtr, 100686243);
		}

		// Token: 0x0600AE21 RID: 44577 RVA: 0x002DB358 File Offset: 0x002D9558
		[CallerCount(0)]
		public unsafe void IncrementSingle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputValueIncrementor.NativeMethodInfoPtr_IncrementSingle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE22 RID: 44578 RVA: 0x002DB38C File Offset: 0x002D958C
		[CallerCount(0)]
		public unsafe void IncrementMulti()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputValueIncrementor.NativeMethodInfoPtr_IncrementMulti_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE23 RID: 44579 RVA: 0x002DB3C0 File Offset: 0x002D95C0
		[CallerCount(0)]
		public unsafe void DecrementSingle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputValueIncrementor.NativeMethodInfoPtr_DecrementSingle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE24 RID: 44580 RVA: 0x002DB3F4 File Offset: 0x002D95F4
		[CallerCount(0)]
		public unsafe void DecrementMulti()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputValueIncrementor.NativeMethodInfoPtr_DecrementMulti_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE25 RID: 44581 RVA: 0x002DB428 File Offset: 0x002D9628
		[CallerCount(0)]
		public unsafe void Set(float value, int direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputValueIncrementor.NativeMethodInfoPtr_Set_Private_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE26 RID: 44582 RVA: 0x002DB474 File Offset: 0x002D9674
		[CallerCount(0)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputValueIncrementor.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE27 RID: 44583 RVA: 0x002DB4A8 File Offset: 0x002D96A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297882, XrefRangeEnd = 297883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputValueIncrementor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputValueIncrementor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputValueIncrementor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE28 RID: 44584 RVA: 0x0004FBA4 File Offset: 0x0004DDA4
		public InputValueIncrementor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003440 RID: 13376
		// (get) Token: 0x0600AE29 RID: 44585 RVA: 0x002DB4E4 File Offset: 0x002D96E4
		// (set) Token: 0x0600AE2A RID: 44586 RVA: 0x0004FBAD File Offset: 0x0004DDAD
		public unsafe InputValueRamp _inputValueRamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueIncrementor.NativeFieldInfoPtr__inputValueRamp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputValueRamp>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueIncrementor.NativeFieldInfoPtr__inputValueRamp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003441 RID: 13377
		// (get) Token: 0x0600AE2B RID: 44587 RVA: 0x002DB514 File Offset: 0x002D9714
		// (set) Token: 0x0600AE2C RID: 44588 RVA: 0x0004FBCC File Offset: 0x0004DDCC
		public unsafe float _singleValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueIncrementor.NativeFieldInfoPtr__singleValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueIncrementor.NativeFieldInfoPtr__singleValue)) = value;
			}
		}

		// Token: 0x17003442 RID: 13378
		// (get) Token: 0x0600AE2D RID: 44589 RVA: 0x002DB53C File Offset: 0x002D973C
		// (set) Token: 0x0600AE2E RID: 44590 RVA: 0x0004FBE7 File Offset: 0x0004DDE7
		public unsafe float _multiValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueIncrementor.NativeFieldInfoPtr__multiValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputValueIncrementor.NativeFieldInfoPtr__multiValue)) = value;
			}
		}

		// Token: 0x0400782F RID: 30767
		private static readonly IntPtr NativeFieldInfoPtr__inputValueRamp;

		// Token: 0x04007830 RID: 30768
		private static readonly IntPtr NativeFieldInfoPtr__singleValue;

		// Token: 0x04007831 RID: 30769
		private static readonly IntPtr NativeFieldInfoPtr__multiValue;

		// Token: 0x04007832 RID: 30770
		private static readonly IntPtr NativeMethodInfoPtr_IncrementSingle_Public_Void_0;

		// Token: 0x04007833 RID: 30771
		private static readonly IntPtr NativeMethodInfoPtr_IncrementMulti_Public_Void_0;

		// Token: 0x04007834 RID: 30772
		private static readonly IntPtr NativeMethodInfoPtr_DecrementSingle_Public_Void_0;

		// Token: 0x04007835 RID: 30773
		private static readonly IntPtr NativeMethodInfoPtr_DecrementMulti_Public_Void_0;

		// Token: 0x04007836 RID: 30774
		private static readonly IntPtr NativeMethodInfoPtr_Set_Private_Void_Single_Int32_0;

		// Token: 0x04007837 RID: 30775
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x04007838 RID: 30776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
