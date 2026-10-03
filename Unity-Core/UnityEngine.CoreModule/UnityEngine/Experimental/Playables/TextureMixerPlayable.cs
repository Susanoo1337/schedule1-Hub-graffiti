using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x02000275 RID: 629
	[StructLayout(2)]
	public struct TextureMixerPlayable
	{
		// Token: 0x06002B23 RID: 11043 RVA: 0x000A826C File Offset: 0x000A646C
		// Note: this type is marked as 'beforefieldinit'.
		static TextureMixerPlayable()
		{
			Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", "TextureMixerPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr);
			TextureMixerPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, "m_Handle");
			TextureMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, 100667946);
			TextureMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextureMixerPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, 100667947);
			TextureMixerPlayable.CreateTextureMixerPlayableInternalDelegateField = IL2CPP.ResolveICall<TextureMixerPlayable.CreateTextureMixerPlayableInternalDelegate>("UnityEngine.Experimental.Playables.TextureMixerPlayable::CreateTextureMixerPlayableInternal");
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x000A82E8 File Offset: 0x000A64E8
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 1223500, RefRangeEnd = 1223547, XrefRangeStart = 1223500, XrefRangeEnd = 1223547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Playables.PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureMixerPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x000A8318 File Offset: 0x000A6518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294346, XrefRangeEnd = 1294354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(TextureMixerPlayable other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureMixerPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextureMixerPlayable_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x00012FAC File Offset: 0x000111AC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextureMixerPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x000A8358 File Offset: 0x000A6558
		public static TextureMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph)
		{
			UnityEngine.Playables.PlayableHandle playableHandle = TextureMixerPlayable.CreateHandle(graph);
			return new TextureMixerPlayable(playableHandle);
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x000A8378 File Offset: 0x000A6578
		public static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph)
		{
			UnityEngine.Playables.PlayableHandle @null = UnityEngine.Playables.PlayableHandle.Null;
			bool flag = !TextureMixerPlayable.CreateTextureMixerPlayableInternal(ref graph, ref @null);
			UnityEngine.Playables.PlayableHandle result;
			if (flag)
			{
				result = UnityEngine.Playables.PlayableHandle.Null;
			}
			else
			{
				result = @null;
			}
			return result;
		}

		// Token: 0x06002B29 RID: 11049 RVA: 0x000A83AC File Offset: 0x000A65AC
		public static implicit operator UnityEngine.Playables.Playable(TextureMixerPlayable playable)
		{
			return new UnityEngine.Playables.Playable(playable.GetHandle());
		}

		// Token: 0x06002B2A RID: 11050 RVA: 0x000A83CC File Offset: 0x000A65CC
		public static explicit operator TextureMixerPlayable(UnityEngine.Playables.Playable playable)
		{
			return new TextureMixerPlayable(playable.GetHandle());
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x00012FBE File Offset: 0x000111BE
		public static bool CreateTextureMixerPlayableInternal(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle)
		{
			return TextureMixerPlayable.CreateTextureMixerPlayableInternalDelegateField(ref graph, ref handle);
		}

		// Token: 0x04002524 RID: 9508
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04002525 RID: 9509
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x04002526 RID: 9510
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextureMixerPlayable_0;

		// Token: 0x04002527 RID: 9511
		[FieldOffset(0)]
		public UnityEngine.Playables.PlayableHandle m_Handle;

		// Token: 0x04002528 RID: 9512
		private static readonly TextureMixerPlayable.CreateTextureMixerPlayableInternalDelegate CreateTextureMixerPlayableInternalDelegateField;

		// Token: 0x02000BF5 RID: 3061
		// (Invoke) Token: 0x060040B6 RID: 16566
		private delegate bool CreateTextureMixerPlayableInternalDelegate(IntPtr graph, IntPtr handle);
	}
}
