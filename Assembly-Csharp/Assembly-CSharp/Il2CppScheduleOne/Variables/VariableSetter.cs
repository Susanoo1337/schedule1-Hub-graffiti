using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x020000FC RID: 252
	[Serializable]
	public class VariableSetter : Object
	{
		// Token: 0x060017F9 RID: 6137 RVA: 0x000CAABC File Offset: 0x000C8CBC
		// Note: this type is marked as 'beforefieldinit'.
		static VariableSetter()
		{
			Il2CppClassPointerStore<VariableSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "VariableSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr);
			VariableSetter.NativeFieldInfoPtr_VariableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr, "VariableName");
			VariableSetter.NativeFieldInfoPtr_NewValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr, "NewValue");
			VariableSetter.NativeMethodInfoPtr_Execute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr, 100666573);
			VariableSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr, 100666574);
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x000CAB3C File Offset: 0x000C8D3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98078, RefRangeEnd = 98079, XrefRangeStart = 98073, XrefRangeEnd = 98078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableSetter.NativeMethodInfoPtr_Execute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x000CAB70 File Offset: 0x000C8D70
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VariableSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariableSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x0000D1D6 File Offset: 0x0000B3D6
		public VariableSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x000CABAC File Offset: 0x000C8DAC
		// (set) Token: 0x060017FE RID: 6142 RVA: 0x0000D1DF File Offset: 0x0000B3DF
		public unsafe string VariableName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableSetter.NativeFieldInfoPtr_VariableName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableSetter.NativeFieldInfoPtr_VariableName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x000CABD4 File Offset: 0x000C8DD4
		// (set) Token: 0x06001800 RID: 6144 RVA: 0x0000D1FE File Offset: 0x0000B3FE
		public unsafe string NewValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableSetter.NativeFieldInfoPtr_NewValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableSetter.NativeFieldInfoPtr_NewValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeFieldInfoPtr_VariableName;

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeFieldInfoPtr_NewValue;

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Void_0;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
