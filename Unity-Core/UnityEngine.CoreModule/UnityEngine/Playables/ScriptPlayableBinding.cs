using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000261 RID: 609
	public static class ScriptPlayableBinding : Object
	{
		// Token: 0x06002AB3 RID: 10931 RVA: 0x000A6678 File Offset: 0x000A4878
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptPlayableBinding()
		{
			Il2CppClassPointerStore<ScriptPlayableBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "ScriptPlayableBinding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptPlayableBinding>.NativeClassPtr);
			ScriptPlayableBinding.NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableBinding>.NativeClassPtr, 100667896);
			ScriptPlayableBinding.NativeMethodInfoPtr_CreateScriptOutput_Private_Static_PlayableOutput_PlayableGraph_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableBinding>.NativeClassPtr, 100667897);
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x000A66D0 File Offset: 0x000A48D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1294002, RefRangeEnd = 1294004, XrefRangeStart = 1293987, XrefRangeEnd = 1294002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayableBinding Create(string name, Object key, Type type)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ScriptPlayableBinding.NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_Type_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new PlayableBinding(pointer);
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x000A6730 File Offset: 0x000A4930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294004, XrefRangeEnd = 1294015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayableOutput CreateScriptOutput(PlayableGraph graph, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayableBinding.NativeMethodInfoPtr_CreateScriptOutput_Private_Static_PlayableOutput_PlayableGraph_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x00012DA6 File Offset: 0x00010FA6
		public ScriptPlayableBinding(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002418 RID: 9240
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_Type_0;

		// Token: 0x04002419 RID: 9241
		private static readonly IntPtr NativeMethodInfoPtr_CreateScriptOutput_Private_Static_PlayableOutput_PlayableGraph_String_0;
	}
}
