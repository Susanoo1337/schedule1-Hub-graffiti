using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x020000FA RID: 250
	[Serializable]
	public class VariableCreator : Object
	{
		// Token: 0x060017A9 RID: 6057 RVA: 0x000C9674 File Offset: 0x000C7874
		// Note: this type is marked as 'beforefieldinit'.
		static VariableCreator()
		{
			Il2CppClassPointerStore<VariableCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "VariableCreator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr);
			VariableCreator.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr, "Name");
			VariableCreator.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr, "Type");
			VariableCreator.NativeFieldInfoPtr_InitialValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr, "InitialValue");
			VariableCreator.NativeFieldInfoPtr_Persistent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr, "Persistent");
			VariableCreator.NativeFieldInfoPtr_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr, "Mode");
			VariableCreator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr, 100666531);
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x000C971C File Offset: 0x000C791C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97349, XrefRangeEnd = 97353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VariableCreator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariableCreator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableCreator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x0000CFD1 File Offset: 0x0000B1D1
		public VariableCreator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x000C9758 File Offset: 0x000C7958
		// (set) Token: 0x060017AD RID: 6061 RVA: 0x0000CFDA File Offset: 0x0000B1DA
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x060017AE RID: 6062 RVA: 0x000C9780 File Offset: 0x000C7980
		// (set) Token: 0x060017AF RID: 6063 RVA: 0x0000CFF9 File Offset: 0x0000B1F9
		public unsafe VariableDatabase.EVariableType Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Type)) = value;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x060017B0 RID: 6064 RVA: 0x000C97A8 File Offset: 0x000C79A8
		// (set) Token: 0x060017B1 RID: 6065 RVA: 0x0000D014 File Offset: 0x0000B214
		public unsafe string InitialValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_InitialValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_InitialValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x000C97D0 File Offset: 0x000C79D0
		// (set) Token: 0x060017B3 RID: 6067 RVA: 0x0000D033 File Offset: 0x0000B233
		public unsafe bool Persistent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Persistent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Persistent)) = value;
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x000C97F8 File Offset: 0x000C79F8
		// (set) Token: 0x060017B5 RID: 6069 RVA: 0x0000D04E File Offset: 0x0000B24E
		public unsafe EVariableMode Mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableCreator.NativeFieldInfoPtr_Mode)) = value;
			}
		}

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeFieldInfoPtr_InitialValue;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeFieldInfoPtr_Persistent;

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeFieldInfoPtr_Mode;

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
