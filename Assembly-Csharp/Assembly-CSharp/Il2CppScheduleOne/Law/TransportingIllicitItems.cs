using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x0200030F RID: 783
	[Serializable]
	public class TransportingIllicitItems : Crime
	{
		// Token: 0x06003DB3 RID: 15795 RVA: 0x0014B33C File Offset: 0x0014953C
		// Note: this type is marked as 'beforefieldinit'.
		static TransportingIllicitItems()
		{
			Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "TransportingIllicitItems");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr);
			TransportingIllicitItems.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr, "<CrimeName>k__BackingField");
			TransportingIllicitItems.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr, 100671171);
			TransportingIllicitItems.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr, 100671172);
			TransportingIllicitItems.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr, 100671173);
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x06003DB4 RID: 15796 RVA: 0x0014B3BC File Offset: 0x001495BC
		// (set) Token: 0x06003DB5 RID: 15797 RVA: 0x0014B400 File Offset: 0x00149600
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransportingIllicitItems.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransportingIllicitItems.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x0014B450 File Offset: 0x00149650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152289, RefRangeEnd = 152290, XrefRangeStart = 152280, XrefRangeEnd = 152289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransportingIllicitItems() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransportingIllicitItems.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB7 RID: 15799 RVA: 0x0001EB3A File Offset: 0x0001CD3A
		public TransportingIllicitItems(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x06003DB8 RID: 15800 RVA: 0x0014B48C File Offset: 0x0014968C
		// (set) Token: 0x06003DB9 RID: 15801 RVA: 0x0001EB43 File Offset: 0x0001CD43
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransportingIllicitItems.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransportingIllicitItems.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040029A7 RID: 10663
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040029A8 RID: 10664
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040029A9 RID: 10665
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040029AA RID: 10666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
