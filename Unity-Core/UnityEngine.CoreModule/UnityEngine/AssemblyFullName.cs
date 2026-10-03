using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000131 RID: 305
	public sealed class AssemblyFullName : ValueType
	{
		// Token: 0x060017C6 RID: 6086 RVA: 0x0006655C File Offset: 0x0006475C
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyFullName()
		{
			Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AssemblyFullName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr);
			AssemblyFullName.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr, "Name");
			AssemblyFullName.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr, "Version");
			AssemblyFullName.NativeFieldInfoPtr_PublicKeyToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr, "PublicKeyToken");
			AssemblyFullName.NativeFieldInfoPtr_Culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr, "Culture");
			AssemblyFullName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr, 100665785);
			AssemblyFullName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr, 100665786);
			AssemblyFullName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr, 100665787);
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x00066618 File Offset: 0x00064818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248864, XrefRangeEnd = 1248871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyFullName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x0006666C File Offset: 0x0006486C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248871, XrefRangeEnd = 1248877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyFullName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x000666B0 File Offset: 0x000648B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248877, XrefRangeEnd = 1248897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyFullName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x0000BDC9 File Offset: 0x00009FC9
		public AssemblyFullName(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x0000BDD2 File Offset: 0x00009FD2
		public AssemblyFullName() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr))
		{
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x000666EC File Offset: 0x000648EC
		// (set) Token: 0x060017CD RID: 6093 RVA: 0x0000BDE4 File Offset: 0x00009FE4
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x00066714 File Offset: 0x00064914
		// (set) Token: 0x060017CF RID: 6095 RVA: 0x0000BE03 File Offset: 0x0000A003
		public unsafe AssemblyVersion Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_Version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_Version)) = value;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x0006673C File Offset: 0x0006493C
		// (set) Token: 0x060017D1 RID: 6097 RVA: 0x0000BE1E File Offset: 0x0000A01E
		public unsafe string PublicKeyToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_PublicKeyToken);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_PublicKeyToken), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060017D2 RID: 6098 RVA: 0x00066764 File Offset: 0x00064964
		// (set) Token: 0x060017D3 RID: 6099 RVA: 0x0000BE3D File Offset: 0x0000A03D
		public unsafe string Culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_Culture);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_Culture), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400140D RID: 5133
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x0400140E RID: 5134
		private static readonly IntPtr NativeFieldInfoPtr_Version;

		// Token: 0x0400140F RID: 5135
		private static readonly IntPtr NativeFieldInfoPtr_PublicKeyToken;

		// Token: 0x04001410 RID: 5136
		private static readonly IntPtr NativeFieldInfoPtr_Culture;

		// Token: 0x04001411 RID: 5137
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001412 RID: 5138
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001413 RID: 5139
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
