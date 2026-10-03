using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000257 RID: 599
	public sealed class PlayableBinding : ValueType
	{
		// Token: 0x06002956 RID: 10582 RVA: 0x000A131C File Offset: 0x0009F51C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableBinding()
		{
			Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableBinding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr);
			PlayableBinding.NativeFieldInfoPtr_m_StreamName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "m_StreamName");
			PlayableBinding.NativeFieldInfoPtr_m_SourceObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "m_SourceObject");
			PlayableBinding.NativeFieldInfoPtr_m_SourceBindingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "m_SourceBindingType");
			PlayableBinding.NativeFieldInfoPtr_m_CreateOutputMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "m_CreateOutputMethod");
			PlayableBinding.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "None");
			PlayableBinding.NativeFieldInfoPtr_DefaultDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "DefaultDuration");
			PlayableBinding.NativeMethodInfoPtr_get_sourceObject_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, 100667712);
			PlayableBinding.NativeMethodInfoPtr_CreateOutput_Internal_PlayableOutput_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, 100667713);
			PlayableBinding.NativeMethodInfoPtr_CreateInternal_Internal_Static_PlayableBinding_String_Object_Type_CreateOutputMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, 100667714);
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06002957 RID: 10583 RVA: 0x000A1400 File Offset: 0x0009F600
		// (set) Token: 0x0600296A RID: 10602 RVA: 0x000128E5 File Offset: 0x00010AE5
		public unsafe Object sourceObject
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 537050, RefRangeEnd = 537070, XrefRangeStart = 537050, XrefRangeEnd = 537070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableBinding.NativeMethodInfoPtr_get_sourceObject_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			set
			{
				this.m_SourceObject = value;
			}
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x000A1444 File Offset: 0x0009F644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1292752, RefRangeEnd = 1292753, XrefRangeStart = 1292744, XrefRangeEnd = 1292752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableOutput CreateOutput(PlayableGraph graph)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableBinding.NativeMethodInfoPtr_CreateOutput_Internal_PlayableOutput_PlayableGraph_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x000A1494 File Offset: 0x0009F694
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1292757, RefRangeEnd = 1292759, XrefRangeStart = 1292753, XrefRangeEnd = 1292757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayableBinding CreateInternal(string name, Object sourceObject, Type sourceType, PlayableBinding.CreateOutputMethod createFunction)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createFunction);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayableBinding.NativeMethodInfoPtr_CreateInternal_Internal_Static_PlayableBinding_String_Object_Type_CreateOutputMethod_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new PlayableBinding(pointer);
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x00012824 File Offset: 0x00010A24
		public PlayableBinding(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x0001282D File Offset: 0x00010A2D
		public PlayableBinding() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr))
		{
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x0600295C RID: 10588 RVA: 0x000A1508 File Offset: 0x0009F708
		// (set) Token: 0x0600295D RID: 10589 RVA: 0x0001283F File Offset: 0x00010A3F
		public unsafe string m_StreamName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_StreamName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_StreamName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x0600295E RID: 10590 RVA: 0x000A1530 File Offset: 0x0009F730
		// (set) Token: 0x0600295F RID: 10591 RVA: 0x0001285E File Offset: 0x00010A5E
		public unsafe Object m_SourceObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_SourceObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_SourceObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06002960 RID: 10592 RVA: 0x000A1560 File Offset: 0x0009F760
		// (set) Token: 0x06002961 RID: 10593 RVA: 0x0001287D File Offset: 0x00010A7D
		public unsafe Type m_SourceBindingType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_SourceBindingType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_SourceBindingType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06002962 RID: 10594 RVA: 0x000A1590 File Offset: 0x0009F790
		// (set) Token: 0x06002963 RID: 10595 RVA: 0x0001289C File Offset: 0x00010A9C
		public unsafe PlayableBinding.CreateOutputMethod m_CreateOutputMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_CreateOutputMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayableBinding.CreateOutputMethod>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_CreateOutputMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06002964 RID: 10596 RVA: 0x000A15C0 File Offset: 0x0009F7C0
		// (set) Token: 0x06002965 RID: 10597 RVA: 0x000128BB File Offset: 0x00010ABB
		public unsafe static Il2CppReferenceArray<PlayableBinding> None
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayableBinding.NativeFieldInfoPtr_None, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayableBinding>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayableBinding.NativeFieldInfoPtr_None, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06002966 RID: 10598 RVA: 0x000A15E8 File Offset: 0x0009F7E8
		// (set) Token: 0x06002967 RID: 10599 RVA: 0x000128CD File Offset: 0x00010ACD
		public unsafe static double DefaultDuration
		{
			get
			{
				double result;
				IL2CPP.il2cpp_field_static_get_value(PlayableBinding.NativeFieldInfoPtr_DefaultDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayableBinding.NativeFieldInfoPtr_DefaultDuration, (void*)(&value));
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06002968 RID: 10600 RVA: 0x000A1604 File Offset: 0x0009F804
		// (set) Token: 0x06002969 RID: 10601 RVA: 0x000128DB File Offset: 0x00010ADB
		public string streamName
		{
			get
			{
				return this.m_StreamName;
			}
			set
			{
				this.m_StreamName = value;
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x0600296B RID: 10603 RVA: 0x000A161C File Offset: 0x0009F81C
		public Type outputTargetType
		{
			get
			{
				return this.m_SourceBindingType;
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x0600296C RID: 10604 RVA: 0x000A1634 File Offset: 0x0009F834
		// (set) Token: 0x0600296D RID: 10605 RVA: 0x000128EF File Offset: 0x00010AEF
		public Type sourceBindingType
		{
			get
			{
				return this.m_SourceBindingType;
			}
			set
			{
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x0600296E RID: 10606 RVA: 0x000A164C File Offset: 0x0009F84C
		// (set) Token: 0x0600296F RID: 10607 RVA: 0x000128F2 File Offset: 0x00010AF2
		public DataStreamType streamType
		{
			get
			{
				return DataStreamType.None;
			}
			set
			{
			}
		}

		// Token: 0x0400231F RID: 8991
		private static readonly IntPtr NativeFieldInfoPtr_m_StreamName;

		// Token: 0x04002320 RID: 8992
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceObject;

		// Token: 0x04002321 RID: 8993
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceBindingType;

		// Token: 0x04002322 RID: 8994
		private static readonly IntPtr NativeFieldInfoPtr_m_CreateOutputMethod;

		// Token: 0x04002323 RID: 8995
		private static readonly IntPtr NativeFieldInfoPtr_None;

		// Token: 0x04002324 RID: 8996
		private static readonly IntPtr NativeFieldInfoPtr_DefaultDuration;

		// Token: 0x04002325 RID: 8997
		private static readonly IntPtr NativeMethodInfoPtr_get_sourceObject_Public_get_Object_0;

		// Token: 0x04002326 RID: 8998
		private static readonly IntPtr NativeMethodInfoPtr_CreateOutput_Internal_PlayableOutput_PlayableGraph_0;

		// Token: 0x04002327 RID: 8999
		private static readonly IntPtr NativeMethodInfoPtr_CreateInternal_Internal_Static_PlayableBinding_String_Object_Type_CreateOutputMethod_0;

		// Token: 0x02000B99 RID: 2969
		public sealed class CreateOutputMethod : MulticastDelegate
		{
			// Token: 0x06004015 RID: 16405 RVA: 0x000186F0 File Offset: 0x000168F0
			// Note: this type is marked as 'beforefieldinit'.
			static CreateOutputMethod()
			{
				Il2CppClassPointerStore<PlayableBinding.CreateOutputMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "CreateOutputMethod");
				PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding.CreateOutputMethod>.NativeClassPtr, 100667716);
				PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_PlayableOutput_PlayableGraph_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding.CreateOutputMethod>.NativeClassPtr, 100667717);
			}

			// Token: 0x06004016 RID: 16406 RVA: 0x000B5258 File Offset: 0x000B3458
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1292741, RefRangeEnd = 1292744, XrefRangeStart = 1292738, XrefRangeEnd = 1292741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CreateOutputMethod(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayableBinding.CreateOutputMethod>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004017 RID: 16407 RVA: 0x000B52B4 File Offset: 0x000B34B4
			[CallerCount(0)]
			public unsafe PlayableOutput Invoke(PlayableGraph graph, string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref graph;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_PlayableOutput_PlayableGraph_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004018 RID: 16408 RVA: 0x0001872E File Offset: 0x0001692E
			public CreateOutputMethod(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06004019 RID: 16409 RVA: 0x00018737 File Offset: 0x00016937
			public static implicit operator PlayableBinding.CreateOutputMethod(Func<PlayableGraph, string, PlayableOutput> A_0)
			{
				return DelegateSupport.ConvertDelegate<PlayableBinding.CreateOutputMethod>(A_0);
			}

			// Token: 0x0600401A RID: 16410 RVA: 0x0001873F File Offset: 0x0001693F
			public static PlayableBinding.CreateOutputMethod operator +(PlayableBinding.CreateOutputMethod A_0, PlayableBinding.CreateOutputMethod A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PlayableBinding.CreateOutputMethod>();
			}

			// Token: 0x0600401B RID: 16411 RVA: 0x0001874D File Offset: 0x0001694D
			public static PlayableBinding.CreateOutputMethod operator -(PlayableBinding.CreateOutputMethod A_0, PlayableBinding.CreateOutputMethod A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<PlayableBinding.CreateOutputMethod>();
				}
				return result;
			}

			// Token: 0x04002BFA RID: 11258
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002BFB RID: 11259
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_PlayableOutput_PlayableGraph_String_0;
		}
	}
}
