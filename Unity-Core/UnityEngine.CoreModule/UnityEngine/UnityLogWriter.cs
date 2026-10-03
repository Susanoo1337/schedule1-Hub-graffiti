using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace UnityEngine
{
	// Token: 0x020000F0 RID: 240
	public class UnityLogWriter : TextWriter
	{
		// Token: 0x0600132D RID: 4909 RVA: 0x00055408 File Offset: 0x00053608
		// Note: this type is marked as 'beforefieldinit'.
		static UnityLogWriter()
		{
			Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "UnityLogWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr);
			UnityLogWriter.NativeMethodInfoPtr_WriteStringToUnityLog_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100665198);
			UnityLogWriter.NativeMethodInfoPtr_WriteStringToUnityLogImpl_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100665199);
			UnityLogWriter.NativeMethodInfoPtr_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100665200);
			UnityLogWriter.NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100665201);
			UnityLogWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100665202);
			UnityLogWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100665203);
			UnityLogWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100665204);
			UnityLogWriter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr, 100665205);
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x000554D8 File Offset: 0x000536D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242035, XrefRangeEnd = 1242037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteStringToUnityLog(string s)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityLogWriter.NativeMethodInfoPtr_WriteStringToUnityLog_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x00055510 File Offset: 0x00053710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242037, XrefRangeEnd = 1242039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteStringToUnityLogImpl(string s)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityLogWriter.NativeMethodInfoPtr_WriteStringToUnityLogImpl_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x00055548 File Offset: 0x00053748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1242050, RefRangeEnd = 1242051, XrefRangeStart = 1242039, XrefRangeEnd = 1242050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityLogWriter.NativeMethodInfoPtr_Init_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x00055570 File Offset: 0x00053770
		public unsafe override Encoding Encoding
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242051, XrefRangeEnd = 1242052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityLogWriter.NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x000555BC File Offset: 0x000537BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242052, XrefRangeEnd = 1242058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityLogWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x00055608 File Offset: 0x00053808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242058, XrefRangeEnd = 1242060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityLogWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x00055658 File Offset: 0x00053858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242060, XrefRangeEnd = 1242063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Il2CppStructArray<char> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityLogWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x000556C4 File Offset: 0x000538C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242063, XrefRangeEnd = 1242067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityLogWriter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityLogWriter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityLogWriter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x0000A780 File Offset: 0x00008980
		public UnityLogWriter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeMethodInfoPtr_WriteStringToUnityLog_Public_Static_Void_String_0;

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeMethodInfoPtr_WriteStringToUnityLogImpl_Private_Static_Void_String_0;

		// Token: 0x040010C4 RID: 4292
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_0;

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0;

		// Token: 0x040010C6 RID: 4294
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0;

		// Token: 0x040010C7 RID: 4295
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0;

		// Token: 0x040010C8 RID: 4296
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040010C9 RID: 4297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
