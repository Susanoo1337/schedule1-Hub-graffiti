using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Playables
{
	// Token: 0x02000253 RID: 595
	[StructLayout(2)]
	public struct Playable
	{
		// Token: 0x06002931 RID: 10545 RVA: 0x000A08EC File Offset: 0x0009EAEC
		// Note: this type is marked as 'beforefieldinit'.
		static Playable()
		{
			Il2CppClassPointerStore<Playable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "Playable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Playable>.NativeClassPtr);
			Playable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Playable>.NativeClassPtr, "m_Handle");
			Playable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Playable>.NativeClassPtr, "m_NullPlayable");
			Playable.NativeMethodInfoPtr_get_Null_Public_Static_get_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Playable>.NativeClassPtr, 100667686);
			Playable.NativeMethodInfoPtr_Create_Public_Static_Playable_PlayableGraph_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Playable>.NativeClassPtr, 100667687);
			Playable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Playable>.NativeClassPtr, 100667688);
			Playable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Playable>.NativeClassPtr, 100667689);
			Playable.NativeMethodInfoPtr_IsPlayableOfType_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Playable>.NativeClassPtr, 100667690);
			Playable.NativeMethodInfoPtr_GetPlayableType_Public_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Playable>.NativeClassPtr, 100667691);
			Playable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Playable>.NativeClassPtr, 100667692);
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06002932 RID: 10546 RVA: 0x000A09D0 File Offset: 0x0009EBD0
		public unsafe static Playable Null
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1292662, RefRangeEnd = 1292671, XrefRangeStart = 1292658, XrefRangeEnd = 1292662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Playable.NativeMethodInfoPtr_get_Null_Public_Static_get_Playable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x000A0A00 File Offset: 0x0009EC00
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1292679, RefRangeEnd = 1292686, XrefRangeStart = 1292671, XrefRangeEnd = 1292679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Playable Create(PlayableGraph graph, int inputCount = 0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Playable.NativeMethodInfoPtr_Create_Public_Static_Playable_PlayableGraph_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x000A0A4C File Offset: 0x0009EC4C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 29012, RefRangeEnd = 29030, XrefRangeStart = 29012, XrefRangeEnd = 29030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Playable(PlayableHandle handle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Playable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x000A0A80 File Offset: 0x0009EC80
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 1223500, RefRangeEnd = 1223547, XrefRangeStart = 1223500, XrefRangeEnd = 1223547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Playable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x000A0AB0 File Offset: 0x0009ECB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1292695, RefRangeEnd = 1292699, XrefRangeStart = 1292686, XrefRangeEnd = 1292695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayableOfType<T>() where T : new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Playable.MethodInfoStoreGeneric_IsPlayableOfType_Public_Boolean_0<T>.Pointer, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x000A0AE0 File Offset: 0x0009ECE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1292710, RefRangeEnd = 1292712, XrefRangeStart = 1292699, XrefRangeEnd = 1292710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetPlayableType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Playable.NativeMethodInfoPtr_GetPlayableType_Public_Type_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x000A0B14 File Offset: 0x0009ED14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292712, XrefRangeEnd = 1292723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Playable other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Playable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Playable_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x000127E3 File Offset: 0x000109E3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Playable>.NativeClassPtr, ref this));
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x0600293A RID: 10554 RVA: 0x000A0B54 File Offset: 0x0009ED54
		// (set) Token: 0x0600293B RID: 10555 RVA: 0x000127F5 File Offset: 0x000109F5
		public unsafe static Playable m_NullPlayable
		{
			get
			{
				Playable result;
				IL2CPP.il2cpp_field_static_get_value(Playable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Playable.NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
			}
		}

		// Token: 0x04002303 RID: 8963
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04002304 RID: 8964
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x04002305 RID: 8965
		private static readonly IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_Playable_0;

		// Token: 0x04002306 RID: 8966
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Playable_PlayableGraph_Int32_0;

		// Token: 0x04002307 RID: 8967
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x04002308 RID: 8968
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x04002309 RID: 8969
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayableOfType_Public_Boolean_0;

		// Token: 0x0400230A RID: 8970
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayableType_Public_Type_0;

		// Token: 0x0400230B RID: 8971
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Playable_0;

		// Token: 0x0400230C RID: 8972
		[FieldOffset(0)]
		public PlayableHandle m_Handle;

		// Token: 0x02000B98 RID: 2968
		private sealed class MethodInfoStoreGeneric_IsPlayableOfType_Public_Boolean_0<T>
		{
			// Token: 0x04002BF9 RID: 11257
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Playable.NativeMethodInfoPtr_IsPlayableOfType_Public_Boolean_0, Il2CppClassPointerStore<Playable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
