using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000260 RID: 608
	public sealed class ScriptPlayable<T> : ValueType where T : class, new()
	{
		// Token: 0x06002A9E RID: 10910 RVA: 0x000A6000 File Offset: 0x000A4200
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptPlayable()
		{
			Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "ScriptPlayable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr);
			ScriptPlayable<T>.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, "m_Handle");
			ScriptPlayable<T>.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, "m_NullPlayable");
			ScriptPlayable<T>.NativeMethodInfoPtr_get_Null_Public_Static_get_ScriptPlayable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100667881);
			ScriptPlayable<T>.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_T_PlayableGraph_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100667882);
			ScriptPlayable<T>.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_T_PlayableGraph_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100667883);
			ScriptPlayable<T>.NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100667884);
			ScriptPlayable<T>.NativeMethodInfoPtr_CreateScriptInstance_Private_Static_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100667885);
			ScriptPlayable<T>.NativeMethodInfoPtr_CloneScriptInstance_Private_Static_Object_IPlayableBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100667886);
			ScriptPlayable<T>.NativeMethodInfoPtr_CloneScriptInstanceFromEngineObject_Private_Static_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100667887);
			ScriptPlayable<T>.NativeMethodInfoPtr_CloneScriptInstanceFromIClonable_Private_Static_Object_ICloneable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100667888);
			ScriptPlayable<T>.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100667889);
			ScriptPlayable<T>.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100667890);
			ScriptPlayable<T>.NativeMethodInfoPtr_GetBehaviour_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100667891);
			ScriptPlayable<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_ScriptPlayable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100667892);
			ScriptPlayable<T>.NativeMethodInfoPtr_op_Explicit_Public_Static_ScriptPlayable_1_T_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100667893);
			ScriptPlayable<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptPlayable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100667894);
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06002A9F RID: 10911 RVA: 0x000A61AC File Offset: 0x000A43AC
		public unsafe static ScriptPlayable<T> Null
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1293807, RefRangeEnd = 1293812, XrefRangeStart = 1293802, XrefRangeEnd = 1293807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_get_Null_Public_Static_get_ScriptPlayable_1_T_0, 0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ScriptPlayable<T>(pointer);
			}
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x000A61D8 File Offset: 0x000A43D8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1293819, RefRangeEnd = 1293831, XrefRangeStart = 1293812, XrefRangeEnd = 1293819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptPlayable<T> Create(PlayableGraph graph, int inputCount = 0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_T_PlayableGraph_Int32_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ScriptPlayable<T>(pointer);
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x000A6220 File Offset: 0x000A4420
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1293838, RefRangeEnd = 1293840, XrefRangeStart = 1293831, XrefRangeEnd = 1293838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptPlayable<T> Create(PlayableGraph graph, T template, int inputCount = 0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = template;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref template;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_T_PlayableGraph_T_Int32_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ScriptPlayable<T>(pointer);
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x000A62C4 File Offset: 0x000A44C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1293876, RefRangeEnd = 1293878, XrefRangeStart = 1293840, XrefRangeEnd = 1293876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayableHandle CreateHandle(PlayableGraph graph, T template, int inputCount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = template;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref template;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_T_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x000A636C File Offset: 0x000A456C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293888, RefRangeEnd = 1293889, XrefRangeStart = 1293878, XrefRangeEnd = 1293888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateScriptInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_CreateScriptInstance_Private_Static_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x000A63A0 File Offset: 0x000A45A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293904, RefRangeEnd = 1293905, XrefRangeStart = 1293889, XrefRangeEnd = 1293904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CloneScriptInstance(IPlayableBehaviour source)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_CloneScriptInstance_Private_Static_Object_IPlayableBehaviour_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x000A63E4 File Offset: 0x000A45E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293905, XrefRangeEnd = 1293912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CloneScriptInstanceFromEngineObject(Object source)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_CloneScriptInstanceFromEngineObject_Private_Static_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x000A6428 File Offset: 0x000A4628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293912, XrefRangeEnd = 1293916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CloneScriptInstanceFromIClonable(ICloneable source)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_CloneScriptInstanceFromIClonable_Private_Static_Object_ICloneable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x000A646C File Offset: 0x000A466C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1293928, RefRangeEnd = 1293931, XrefRangeStart = 1293916, XrefRangeEnd = 1293928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptPlayable(PlayableHandle handle) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x000A64B8 File Offset: 0x000A46B8
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 1223500, RefRangeEnd = 1223547, XrefRangeStart = 1223500, XrefRangeEnd = 1223547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableHandle GetHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x000A64FC File Offset: 0x000A46FC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1293936, RefRangeEnd = 1293952, XrefRangeStart = 1293931, XrefRangeEnd = 1293936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_GetBehaviour_Public_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x000A653C File Offset: 0x000A473C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1293957, RefRangeEnd = 1293970, XrefRangeStart = 1293952, XrefRangeEnd = 1293957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Playable(ScriptPlayable<T> playable)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(playable));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_ScriptPlayable_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x000A6584 File Offset: 0x000A4784
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293976, RefRangeEnd = 1293977, XrefRangeStart = 1293970, XrefRangeEnd = 1293976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ScriptPlayable<T>(Playable playable)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playable;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_op_Explicit_Public_Static_ScriptPlayable_1_T_Playable_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ScriptPlayable<T>(pointer);
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x000A65BC File Offset: 0x000A47BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293986, RefRangeEnd = 1293987, XrefRangeStart = 1293977, XrefRangeEnd = 1293986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ScriptPlayable<T> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptPlayable_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x00012D59 File Offset: 0x00010F59
		public ScriptPlayable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x00012D62 File Offset: 0x00010F62
		public ScriptPlayable() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr))
		{
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06002AAF RID: 10927 RVA: 0x000A6614 File Offset: 0x000A4814
		// (set) Token: 0x06002AB0 RID: 10928 RVA: 0x00012D74 File Offset: 0x00010F74
		public unsafe PlayableHandle m_Handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptPlayable<T>.NativeFieldInfoPtr_m_Handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptPlayable<T>.NativeFieldInfoPtr_m_Handle)) = value;
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06002AB1 RID: 10929 RVA: 0x000A663C File Offset: 0x000A483C
		// (set) Token: 0x06002AB2 RID: 10930 RVA: 0x00012D8F File Offset: 0x00010F8F
		public unsafe static ScriptPlayable<T> m_NullPlayable
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(ScriptPlayable<T>.NativeFieldInfoPtr_m_NullPlayable, intPtr);
				return new ScriptPlayable<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptPlayable<T>.NativeFieldInfoPtr_m_NullPlayable, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x04002408 RID: 9224
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04002409 RID: 9225
		private static readonly IntPtr NativeFieldInfoPtr_m_NullPlayable;

		// Token: 0x0400240A RID: 9226
		private static readonly IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_ScriptPlayable_1_T_0;

		// Token: 0x0400240B RID: 9227
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_T_PlayableGraph_Int32_0;

		// Token: 0x0400240C RID: 9228
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_T_PlayableGraph_T_Int32_0;

		// Token: 0x0400240D RID: 9229
		private static readonly IntPtr NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_T_Int32_0;

		// Token: 0x0400240E RID: 9230
		private static readonly IntPtr NativeMethodInfoPtr_CreateScriptInstance_Private_Static_Object_0;

		// Token: 0x0400240F RID: 9231
		private static readonly IntPtr NativeMethodInfoPtr_CloneScriptInstance_Private_Static_Object_IPlayableBehaviour_0;

		// Token: 0x04002410 RID: 9232
		private static readonly IntPtr NativeMethodInfoPtr_CloneScriptInstanceFromEngineObject_Private_Static_Object_Object_0;

		// Token: 0x04002411 RID: 9233
		private static readonly IntPtr NativeMethodInfoPtr_CloneScriptInstanceFromIClonable_Private_Static_Object_ICloneable_0;

		// Token: 0x04002412 RID: 9234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

		// Token: 0x04002413 RID: 9235
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x04002414 RID: 9236
		private static readonly IntPtr NativeMethodInfoPtr_GetBehaviour_Public_T_0;

		// Token: 0x04002415 RID: 9237
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_ScriptPlayable_1_T_0;

		// Token: 0x04002416 RID: 9238
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_ScriptPlayable_1_T_Playable_0;

		// Token: 0x04002417 RID: 9239
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptPlayable_1_T_0;
	}
}
