using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000262 RID: 610
	[StructLayout(2)]
	public struct ScriptPlayableOutput
	{
		// Token: 0x06002AB7 RID: 10935 RVA: 0x000A6780 File Offset: 0x000A4980
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptPlayableOutput()
		{
			Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "ScriptPlayableOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr);
			ScriptPlayableOutput.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, "m_Handle");
			ScriptPlayableOutput.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayableOutput_PlayableGraph_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, 100667898);
			ScriptPlayableOutput.NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, 100667899);
			ScriptPlayableOutput.NativeMethodInfoPtr_get_Null_Public_Static_get_ScriptPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, 100667900);
			ScriptPlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, 100667901);
			ScriptPlayableOutput.NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_ScriptPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, 100667902);
		}

		// Token: 0x06002AB8 RID: 10936 RVA: 0x000A6828 File Offset: 0x000A4A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294015, XrefRangeEnd = 1294027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptPlayableOutput Create(PlayableGraph graph, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayableOutput.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayableOutput_PlayableGraph_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x000A6878 File Offset: 0x000A4A78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1294040, RefRangeEnd = 1294044, XrefRangeStart = 1294027, XrefRangeEnd = 1294040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptPlayableOutput(PlayableOutputHandle handle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayableOutput.NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06002ABA RID: 10938 RVA: 0x000A68AC File Offset: 0x000A4AAC
		public unsafe static ScriptPlayableOutput Null
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294044, XrefRangeEnd = 1294052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayableOutput.NativeMethodInfoPtr_get_Null_Public_Static_get_ScriptPlayableOutput_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x000A68DC File Offset: 0x000A4ADC
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 1223500, RefRangeEnd = 1223547, XrefRangeStart = 1223500, XrefRangeEnd = 1223547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableOutputHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x000A690C File Offset: 0x000A4B0C
		[CallerCount(0)]
		public unsafe static implicit operator PlayableOutput(ScriptPlayableOutput output)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref output;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayableOutput.NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_ScriptPlayableOutput_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ABD RID: 10941 RVA: 0x00012DAF File Offset: 0x00010FAF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x06002ABE RID: 10942 RVA: 0x000A694C File Offset: 0x000A4B4C
		public static explicit operator ScriptPlayableOutput(PlayableOutput output)
		{
			return new ScriptPlayableOutput(output.GetHandle());
		}

		// Token: 0x0400241A RID: 9242
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x0400241B RID: 9243
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ScriptPlayableOutput_PlayableGraph_String_0;

		// Token: 0x0400241C RID: 9244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0;

		// Token: 0x0400241D RID: 9245
		private static readonly IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_ScriptPlayableOutput_0;

		// Token: 0x0400241E RID: 9246
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0;

		// Token: 0x0400241F RID: 9247
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_ScriptPlayableOutput_0;

		// Token: 0x04002420 RID: 9248
		[FieldOffset(0)]
		public PlayableOutputHandle m_Handle;
	}
}
