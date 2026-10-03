using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000F2 RID: 242
	[StructLayout(2)]
	public struct Color32
	{
		// Token: 0x06001365 RID: 4965 RVA: 0x00056614 File Offset: 0x00054814
		// Note: this type is marked as 'beforefieldinit'.
		static Color32()
		{
			Il2CppClassPointerStore<Color32>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Color32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Color32>.NativeClassPtr);
			Color32.NativeFieldInfoPtr_rgba = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color32>.NativeClassPtr, "rgba");
			Color32.NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color32>.NativeClassPtr, "r");
			Color32.NativeFieldInfoPtr_g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color32>.NativeClassPtr, "g");
			Color32.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color32>.NativeClassPtr, "b");
			Color32.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color32>.NativeClassPtr, "a");
			Color32.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100665244);
			Color32.NativeMethodInfoPtr_op_Implicit_Public_Static_Color32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100665245);
			Color32.NativeMethodInfoPtr_op_Implicit_Public_Static_Color_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100665246);
			Color32.NativeMethodInfoPtr_Lerp_Public_Static_Color32_Color32_Color32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100665247);
			Color32.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100665248);
			Color32.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100665249);
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x00056720 File Offset: 0x00054920
		[CallerCount(0)]
		public unsafe Color32(byte r, byte g, byte b, byte a)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref r;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_Byte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x0005677C File Offset: 0x0005497C
		[CallerCount(133)]
		[CachedScanResults(RefRangeStart = 1242174, RefRangeEnd = 1242307, XrefRangeStart = 1242166, XrefRangeEnd = 1242174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Color32(Color c)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr_op_Implicit_Public_Static_Color32_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x000567BC File Offset: 0x000549BC
		[CallerCount(0)]
		public unsafe static implicit operator Color(Color32 c)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr_op_Implicit_Public_Static_Color_Color32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x000567FC File Offset: 0x000549FC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1242308, RefRangeEnd = 1242319, XrefRangeStart = 1242307, XrefRangeEnd = 1242308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 Lerp(Color32 a, Color32 b, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr_Lerp_Public_Static_Color32_Color32_Color32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x00056858 File Offset: 0x00054A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242319, XrefRangeEnd = 1242320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x00056884 File Offset: 0x00054A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242320, XrefRangeEnd = 1242352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x0000A79B File Offset: 0x0000899B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Color32>.NativeClassPtr, ref this));
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x000568D4 File Offset: 0x00054AD4
		public static Color32 LerpUnclamped(Color32 a, Color32 b, float t)
		{
			return new Color32((byte)((float)a.r + (float)(b.r - a.r) * t), (byte)((float)a.g + (float)(b.g - a.g) * t), (byte)((float)a.b + (float)(b.b - a.b) * t), (byte)((float)a.a + (float)(b.a - a.a) * t));
		}

		// Token: 0x1700041C RID: 1052
		public byte this[int index]
		{
			get
			{
				byte result;
				switch (index)
				{
				case 0:
					result = this.r;
					break;
				case 1:
					result = this.g;
					break;
				case 2:
					result = this.b;
					break;
				case 3:
					result = this.a;
					break;
				default:
					throw new IndexOutOfRangeException(String.Concat("Invalid Color32 index(", index.ToString(), ")!"));
				}
				return result;
			}
			set
			{
				switch (index)
				{
				case 0:
					this.r = value;
					break;
				case 1:
					this.g = value;
					break;
				case 2:
					this.b = value;
					break;
				case 3:
					this.a = value;
					break;
				default:
					throw new IndexOutOfRangeException(String.Concat("Invalid Color32 index(", index.ToString(), ")!"));
				}
			}
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00056A28 File Offset: 0x00054C28
		public bool InternalEquals(Color32 other)
		{
			return this.rgba == other.rgba;
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x00056A48 File Offset: 0x00054C48
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeFieldInfoPtr_rgba;

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeFieldInfoPtr_r;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeFieldInfoPtr_g;

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeFieldInfoPtr_b;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeFieldInfoPtr_a;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_Byte_0;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Color32_Color_0;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Color_Color32_0;

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Color32_Color32_Color32_Single_0;

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001103 RID: 4355
		[FieldOffset(0)]
		public int rgba;

		// Token: 0x04001104 RID: 4356
		[FieldOffset(0)]
		public byte r;

		// Token: 0x04001105 RID: 4357
		[FieldOffset(1)]
		public byte g;

		// Token: 0x04001106 RID: 4358
		[FieldOffset(2)]
		public byte b;

		// Token: 0x04001107 RID: 4359
		[FieldOffset(3)]
		public byte a;
	}
}
