using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Playables
{
	// Token: 0x0200025D RID: 605
	[StructLayout(2)]
	public struct PlayableOutput
	{
		// Token: 0x06002A53 RID: 10835 RVA: 0x000A4C80 File Offset: 0x000A2E80
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableOutput()
		{
			Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr);
			PlayableOutput.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, "m_Handle");
			PlayableOutput.NativeFieldInfoPtr_m_NullPlayableOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, "m_NullPlayableOutput");
			PlayableOutput.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, 100667839);
			PlayableOutput.NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, 100667840);
			PlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, 100667841);
			PlayableOutput.NativeMethodInfoPtr_IsPlayableOutputOfType_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, 100667842);
			PlayableOutput.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, 100667843);
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06002A54 RID: 10836 RVA: 0x000A4D3C File Offset: 0x000A2F3C
		public unsafe static PlayableOutput Null
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293547, XrefRangeEnd = 1293551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutput.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutput_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x000A4D6C File Offset: 0x000A2F6C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 29012, RefRangeEnd = 29030, XrefRangeStart = 29012, XrefRangeEnd = 29030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableOutput(PlayableOutputHandle handle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutput.NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x000A4DA0 File Offset: 0x000A2FA0
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 1223500, RefRangeEnd = 1223547, XrefRangeStart = 1223500, XrefRangeEnd = 1223547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableOutputHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x000A4DD0 File Offset: 0x000A2FD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293569, RefRangeEnd = 1293570, XrefRangeStart = 1293551, XrefRangeEnd = 1293569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayableOutputOfType<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutput.MethodInfoStoreGeneric_IsPlayableOutputOfType_Public_Boolean_0<T>.Pointer, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A58 RID: 10840 RVA: 0x000A4E00 File Offset: 0x000A3000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293570, XrefRangeEnd = 1293581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(PlayableOutput other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutput.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutput_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x00012C90 File Offset: 0x00010E90
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06002A5A RID: 10842 RVA: 0x000A4E40 File Offset: 0x000A3040
		// (set) Token: 0x06002A5B RID: 10843 RVA: 0x00012CA2 File Offset: 0x00010EA2
		public unsafe static PlayableOutput m_NullPlayableOutput
		{
			get
			{
				PlayableOutput result;
				IL2CPP.il2cpp_field_static_get_value(PlayableOutput.NativeFieldInfoPtr_m_NullPlayableOutput, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayableOutput.NativeFieldInfoPtr_m_NullPlayableOutput, (void*)(&value));
			}
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x000A4E5C File Offset: 0x000A305C
		public Type GetPlayableOutputType()
		{
			return this.GetHandle().GetPlayableOutputType();
		}

		// Token: 0x040023D2 RID: 9170
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040023D3 RID: 9171
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayableOutput;

		// Token: 0x040023D4 RID: 9172
		private static readonly IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutput_0;

		// Token: 0x040023D5 RID: 9173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0;

		// Token: 0x040023D6 RID: 9174
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0;

		// Token: 0x040023D7 RID: 9175
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayableOutputOfType_Public_Boolean_0;

		// Token: 0x040023D8 RID: 9176
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutput_0;

		// Token: 0x040023D9 RID: 9177
		[FieldOffset(0)]
		public PlayableOutputHandle m_Handle;

		// Token: 0x02000BD6 RID: 3030
		private sealed class MethodInfoStoreGeneric_IsPlayableOutputOfType_Public_Boolean_0<T>
		{
			// Token: 0x04002C16 RID: 11286
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutput.NativeMethodInfoPtr_IsPlayableOutputOfType_Public_Boolean_0, Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
