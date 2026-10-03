using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000130 RID: 304
	[StructLayout(2)]
	public struct AssemblyVersion
	{
		// Token: 0x060017BD RID: 6077 RVA: 0x00066224 File Offset: 0x00064424
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyVersion()
		{
			Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AssemblyVersion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr);
			AssemblyVersion.NativeFieldInfoPtr_major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, "major");
			AssemblyVersion.NativeFieldInfoPtr_minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, "minor");
			AssemblyVersion.NativeFieldInfoPtr_build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, "build");
			AssemblyVersion.NativeFieldInfoPtr_revision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, "revision");
			AssemblyVersion.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AssemblyVersion_AssemblyVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, 100665781);
			AssemblyVersion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, 100665782);
			AssemblyVersion.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, 100665783);
			AssemblyVersion.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, 100665784);
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x000662F4 File Offset: 0x000644F4
		[CallerCount(0)]
		public unsafe static bool operator ==(AssemblyVersion lhs, AssemblyVersion rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyVersion.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AssemblyVersion_AssemblyVersion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x00066340 File Offset: 0x00064540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248831, XrefRangeEnd = 1248854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyVersion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x0006636C File Offset: 0x0006456C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248854, XrefRangeEnd = 1248857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyVersion.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x000663B0 File Offset: 0x000645B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1248863, RefRangeEnd = 1248864, XrefRangeStart = 1248857, XrefRangeEnd = 1248863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyVersion.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x0000BDB7 File Offset: 0x00009FB7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, ref this));
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x000663E0 File Offset: 0x000645E0
		public static bool operator !=(AssemblyVersion lhs, AssemblyVersion rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x000663FC File Offset: 0x000645FC
		public static bool operator <(AssemblyVersion lhs, AssemblyVersion rhs)
		{
			bool flag = lhs.major != rhs.major;
			bool result;
			if (flag)
			{
				result = (lhs.major < rhs.major);
			}
			else
			{
				bool flag2 = lhs.minor != rhs.minor;
				if (flag2)
				{
					result = (lhs.minor < rhs.minor);
				}
				else
				{
					bool flag3 = lhs.build != rhs.build;
					if (flag3)
					{
						result = (lhs.build < rhs.build);
					}
					else
					{
						bool flag4 = lhs.revision != rhs.revision;
						result = (flag4 && lhs.revision < rhs.revision);
					}
				}
			}
			return result;
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x000664AC File Offset: 0x000646AC
		public static bool operator >(AssemblyVersion lhs, AssemblyVersion rhs)
		{
			bool flag = lhs.major != rhs.major;
			bool result;
			if (flag)
			{
				result = (lhs.major > rhs.major);
			}
			else
			{
				bool flag2 = lhs.minor != rhs.minor;
				if (flag2)
				{
					result = (lhs.minor > rhs.minor);
				}
				else
				{
					bool flag3 = lhs.build != rhs.build;
					if (flag3)
					{
						result = (lhs.build > rhs.build);
					}
					else
					{
						bool flag4 = lhs.revision != rhs.revision;
						result = (flag4 && lhs.revision > rhs.revision);
					}
				}
			}
			return result;
		}

		// Token: 0x04001401 RID: 5121
		private static readonly IntPtr NativeFieldInfoPtr_major;

		// Token: 0x04001402 RID: 5122
		private static readonly IntPtr NativeFieldInfoPtr_minor;

		// Token: 0x04001403 RID: 5123
		private static readonly IntPtr NativeFieldInfoPtr_build;

		// Token: 0x04001404 RID: 5124
		private static readonly IntPtr NativeFieldInfoPtr_revision;

		// Token: 0x04001405 RID: 5125
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AssemblyVersion_AssemblyVersion_0;

		// Token: 0x04001406 RID: 5126
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001407 RID: 5127
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001408 RID: 5128
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001409 RID: 5129
		[FieldOffset(0)]
		public ushort major;

		// Token: 0x0400140A RID: 5130
		[FieldOffset(2)]
		public ushort minor;

		// Token: 0x0400140B RID: 5131
		[FieldOffset(4)]
		public ushort build;

		// Token: 0x0400140C RID: 5132
		[FieldOffset(6)]
		public ushort revision;
	}
}
