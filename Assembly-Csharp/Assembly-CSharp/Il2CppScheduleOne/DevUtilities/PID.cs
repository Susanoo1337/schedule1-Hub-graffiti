using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003FD RID: 1021
	[Serializable]
	public class PID : Object
	{
		// Token: 0x06005A92 RID: 23186 RVA: 0x001B3C7C File Offset: 0x001B1E7C
		// Note: this type is marked as 'beforefieldinit'.
		static PID()
		{
			Il2CppClassPointerStore<PID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PID>.NativeClassPtr);
			PID.NativeFieldInfoPtr_pFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID>.NativeClassPtr, "pFactor");
			PID.NativeFieldInfoPtr_iFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID>.NativeClassPtr, "iFactor");
			PID.NativeFieldInfoPtr_dFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID>.NativeClassPtr, "dFactor");
			PID.NativeFieldInfoPtr_integral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID>.NativeClassPtr, "integral");
			PID.NativeFieldInfoPtr_lastError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PID>.NativeClassPtr, "lastError");
			PID.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PID>.NativeClassPtr, 100675135);
			PID.NativeMethodInfoPtr_Update_Public_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PID>.NativeClassPtr, 100675136);
		}

		// Token: 0x06005A93 RID: 23187 RVA: 0x001B3D38 File Offset: 0x001B1F38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195737, RefRangeEnd = 195739, XrefRangeStart = 195736, XrefRangeEnd = 195737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PID(float pFactor, float iFactor, float dFactor) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PID>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pFactor;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iFactor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PID.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A94 RID: 23188 RVA: 0x001B3D9C File Offset: 0x001B1F9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 195739, RefRangeEnd = 195742, XrefRangeStart = 195739, XrefRangeEnd = 195739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Update(float setpoint, float actual, float timeFrame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref setpoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actual;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeFrame;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PID.NativeMethodInfoPtr_Update_Public_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005A95 RID: 23189 RVA: 0x0002AEAD File Offset: 0x000290AD
		public PID(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BF2 RID: 7154
		// (get) Token: 0x06005A96 RID: 23190 RVA: 0x001B3E04 File Offset: 0x001B2004
		// (set) Token: 0x06005A97 RID: 23191 RVA: 0x0002AEB6 File Offset: 0x000290B6
		public unsafe float pFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_pFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_pFactor)) = value;
			}
		}

		// Token: 0x17001BF3 RID: 7155
		// (get) Token: 0x06005A98 RID: 23192 RVA: 0x001B3E2C File Offset: 0x001B202C
		// (set) Token: 0x06005A99 RID: 23193 RVA: 0x0002AED1 File Offset: 0x000290D1
		public unsafe float iFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_iFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_iFactor)) = value;
			}
		}

		// Token: 0x17001BF4 RID: 7156
		// (get) Token: 0x06005A9A RID: 23194 RVA: 0x001B3E54 File Offset: 0x001B2054
		// (set) Token: 0x06005A9B RID: 23195 RVA: 0x0002AEEC File Offset: 0x000290EC
		public unsafe float dFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_dFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_dFactor)) = value;
			}
		}

		// Token: 0x17001BF5 RID: 7157
		// (get) Token: 0x06005A9C RID: 23196 RVA: 0x001B3E7C File Offset: 0x001B207C
		// (set) Token: 0x06005A9D RID: 23197 RVA: 0x0002AF07 File Offset: 0x00029107
		public unsafe float integral
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_integral);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_integral)) = value;
			}
		}

		// Token: 0x17001BF6 RID: 7158
		// (get) Token: 0x06005A9E RID: 23198 RVA: 0x001B3EA4 File Offset: 0x001B20A4
		// (set) Token: 0x06005A9F RID: 23199 RVA: 0x0002AF22 File Offset: 0x00029122
		public unsafe float lastError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_lastError);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PID.NativeFieldInfoPtr_lastError)) = value;
			}
		}

		// Token: 0x04003E23 RID: 15907
		private static readonly IntPtr NativeFieldInfoPtr_pFactor;

		// Token: 0x04003E24 RID: 15908
		private static readonly IntPtr NativeFieldInfoPtr_iFactor;

		// Token: 0x04003E25 RID: 15909
		private static readonly IntPtr NativeFieldInfoPtr_dFactor;

		// Token: 0x04003E26 RID: 15910
		private static readonly IntPtr NativeFieldInfoPtr_integral;

		// Token: 0x04003E27 RID: 15911
		private static readonly IntPtr NativeFieldInfoPtr_lastError;

		// Token: 0x04003E28 RID: 15912
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

		// Token: 0x04003E29 RID: 15913
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Single_Single_Single_Single_0;
	}
}
