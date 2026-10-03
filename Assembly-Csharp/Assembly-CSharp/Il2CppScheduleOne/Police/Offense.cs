using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Police
{
	// Token: 0x0200043E RID: 1086
	public class Offense : Object
	{
		// Token: 0x0600616F RID: 24943 RVA: 0x001CCA70 File Offset: 0x001CAC70
		// Note: this type is marked as 'beforefieldinit'.
		static Offense()
		{
			Il2CppClassPointerStore<Offense>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Police", "Offense");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Offense>.NativeClassPtr);
			Offense.NativeFieldInfoPtr_charges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offense>.NativeClassPtr, "charges");
			Offense.NativeFieldInfoPtr_penalties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offense>.NativeClassPtr, "penalties");
			Offense.NativeMethodInfoPtr__ctor_Public_Void_List_1_Charge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offense>.NativeClassPtr, 100676094);
		}

		// Token: 0x06006170 RID: 24944 RVA: 0x001CCADC File Offset: 0x001CACDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206482, XrefRangeEnd = 206501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Offense(List<Offense.Charge> _charges) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Offense>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_charges);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Offense.NativeMethodInfoPtr__ctor_Public_Void_List_1_Charge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006171 RID: 24945 RVA: 0x0002E0C7 File Offset: 0x0002C2C7
		public Offense(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DF1 RID: 7665
		// (get) Token: 0x06006172 RID: 24946 RVA: 0x001CCB28 File Offset: 0x001CAD28
		// (set) Token: 0x06006173 RID: 24947 RVA: 0x0002E0D0 File Offset: 0x0002C2D0
		public unsafe List<Offense.Charge> charges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.NativeFieldInfoPtr_charges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Offense.Charge>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.NativeFieldInfoPtr_charges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DF2 RID: 7666
		// (get) Token: 0x06006174 RID: 24948 RVA: 0x001CCB58 File Offset: 0x001CAD58
		// (set) Token: 0x06006175 RID: 24949 RVA: 0x0002E0EF File Offset: 0x0002C2EF
		public unsafe List<string> penalties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.NativeFieldInfoPtr_penalties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.NativeFieldInfoPtr_penalties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004322 RID: 17186
		private static readonly IntPtr NativeFieldInfoPtr_charges;

		// Token: 0x04004323 RID: 17187
		private static readonly IntPtr NativeFieldInfoPtr_penalties;

		// Token: 0x04004324 RID: 17188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_Charge_0;

		// Token: 0x02000B31 RID: 2865
		public class Charge : Object
		{
			// Token: 0x0600E68C RID: 59020 RVA: 0x00384168 File Offset: 0x00382368
			// Note: this type is marked as 'beforefieldinit'.
			static Charge()
			{
				Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Offense>.NativeClassPtr, "Charge");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr);
				Offense.Charge.NativeFieldInfoPtr_chargeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr, "chargeName");
				Offense.Charge.NativeFieldInfoPtr_crimeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr, "crimeIndex");
				Offense.Charge.NativeFieldInfoPtr_quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr, "quantity");
				Offense.Charge.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr, 100676095);
			}

			// Token: 0x0600E68D RID: 59021 RVA: 0x003841E4 File Offset: 0x003823E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206476, XrefRangeEnd = 206482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Charge(string _chargeName, int _crimeIndex, int _quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Offense.Charge>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_chargeName);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _crimeIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Offense.Charge.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E68E RID: 59022 RVA: 0x0006CBE2 File Offset: 0x0006ADE2
			public Charge(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045FB RID: 17915
			// (get) Token: 0x0600E68F RID: 59023 RVA: 0x0038424C File Offset: 0x0038244C
			// (set) Token: 0x0600E690 RID: 59024 RVA: 0x0006CBEB File Offset: 0x0006ADEB
			public unsafe string chargeName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_chargeName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_chargeName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170045FC RID: 17916
			// (get) Token: 0x0600E691 RID: 59025 RVA: 0x00384274 File Offset: 0x00382474
			// (set) Token: 0x0600E692 RID: 59026 RVA: 0x0006CC0A File Offset: 0x0006AE0A
			public unsafe int crimeIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_crimeIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_crimeIndex)) = value;
				}
			}

			// Token: 0x170045FD RID: 17917
			// (get) Token: 0x0600E693 RID: 59027 RVA: 0x0038429C File Offset: 0x0038249C
			// (set) Token: 0x0600E694 RID: 59028 RVA: 0x0006CC25 File Offset: 0x0006AE25
			public unsafe int quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Offense.Charge.NativeFieldInfoPtr_quantity)) = value;
				}
			}

			// Token: 0x04009C88 RID: 40072
			private static readonly IntPtr NativeFieldInfoPtr_chargeName;

			// Token: 0x04009C89 RID: 40073
			private static readonly IntPtr NativeFieldInfoPtr_crimeIndex;

			// Token: 0x04009C8A RID: 40074
			private static readonly IntPtr NativeFieldInfoPtr_quantity;

			// Token: 0x04009C8B RID: 40075
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0;
		}
	}
}
