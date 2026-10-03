using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp
{
	// Token: 0x02000010 RID: 16
	public class ActionList : Object
	{
		// Token: 0x060000CC RID: 204 RVA: 0x0007DEE8 File Offset: 0x0007C0E8
		// Note: this type is marked as 'beforefieldinit'.
		static ActionList()
		{
			Il2CppClassPointerStore<ActionList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ActionList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionList>.NativeClassPtr);
			ActionList.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionList>.NativeClassPtr, "list");
			ActionList.NativeFieldInfoPtr__shuffleCallbackList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionList>.NativeClassPtr, "_shuffleCallbackList");
			ActionList.NativeFieldInfoPtr__shuffleBeforeNextInvoke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionList>.NativeClassPtr, "_shuffleBeforeNextInvoke");
			ActionList.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionList>.NativeClassPtr, 100663365);
			ActionList.NativeMethodInfoPtr_InvokeAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionList>.NativeClassPtr, 100663366);
			ActionList.NativeMethodInfoPtr_InvokeAllStaggered_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionList>.NativeClassPtr, 100663367);
			ActionList.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionList>.NativeClassPtr, 100663368);
			ActionList.NativeMethodInfoPtr_Add_Private_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionList>.NativeClassPtr, 100663369);
			ActionList.NativeMethodInfoPtr_Remove_Private_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionList>.NativeClassPtr, 100663370);
			ActionList.NativeMethodInfoPtr_op_Addition_Public_Static_ActionList_ActionList_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionList>.NativeClassPtr, 100663371);
			ActionList.NativeMethodInfoPtr_op_Subtraction_Public_Static_ActionList_ActionList_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionList>.NativeClassPtr, 100663372);
			ActionList.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionList>.NativeClassPtr, 100663373);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0007E008 File Offset: 0x0007C208
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 65426, RefRangeEnd = 65429, XrefRangeStart = 65418, XrefRangeEnd = 65426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionList(bool shuffleCallbackList = false) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionList>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shuffleCallbackList;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionList.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0007E050 File Offset: 0x0007C250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65429, XrefRangeEnd = 65443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionList.NativeMethodInfoPtr_InvokeAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0007E084 File Offset: 0x0007C284
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 65457, RefRangeEnd = 65462, XrefRangeStart = 65443, XrefRangeEnd = 65457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeAllStaggered(float staggerTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref staggerTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionList.NativeMethodInfoPtr_InvokeAllStaggered_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0007E0C4 File Offset: 0x0007C2C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 65464, RefRangeEnd = 65466, XrefRangeStart = 65462, XrefRangeEnd = 65464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionList.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0007E0F8 File Offset: 0x0007C2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65466, XrefRangeEnd = 65471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionList.NativeMethodInfoPtr_Add_Private_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0007E13C File Offset: 0x0007C33C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65471, XrefRangeEnd = 65475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionList.NativeMethodInfoPtr_Remove_Private_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0007E180 File Offset: 0x0007C380
		[CallerCount(69)]
		[CachedScanResults(RefRangeStart = 65480, RefRangeEnd = 65549, XrefRangeStart = 65475, XrefRangeEnd = 65480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ActionList operator +(ActionList list, Action action)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionList.NativeMethodInfoPtr_op_Addition_Public_Static_ActionList_ActionList_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionList>(intPtr3) : null;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0007E1D8 File Offset: 0x0007C3D8
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 65552, RefRangeEnd = 65618, XrefRangeStart = 65549, XrefRangeEnd = 65552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ActionList operator -(ActionList list, Action action)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionList.NativeMethodInfoPtr_op_Subtraction_Public_Static_ActionList_ActionList_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionList>(intPtr3) : null;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0007E230 File Offset: 0x0007C430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65618, XrefRangeEnd = 65623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_Single_PDM_0(float staggerTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref staggerTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionList.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002765 File Offset: 0x00000965
		public ActionList(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0007E27C File Offset: 0x0007C47C
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x0000276E File Offset: 0x0000096E
		public unsafe List<Action> list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.NativeFieldInfoPtr_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0007E2AC File Offset: 0x0007C4AC
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0000278D File Offset: 0x0000098D
		public unsafe bool _shuffleCallbackList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.NativeFieldInfoPtr__shuffleCallbackList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.NativeFieldInfoPtr__shuffleCallbackList)) = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0007E2D4 File Offset: 0x0007C4D4
		// (set) Token: 0x060000DC RID: 220 RVA: 0x000027A8 File Offset: 0x000009A8
		public unsafe bool _shuffleBeforeNextInvoke
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.NativeFieldInfoPtr__shuffleBeforeNextInvoke);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.NativeFieldInfoPtr__shuffleBeforeNextInvoke)) = value;
			}
		}

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_list;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr__shuffleCallbackList;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr__shuffleBeforeNextInvoke;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_InvokeAll_Public_Void_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_InvokeAllStaggered_Public_Void_Single_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_Add_Private_Void_Action_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Private_Void_Action_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_ActionList_ActionList_Action_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_ActionList_ActionList_Action_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0;

		// Token: 0x02000850 RID: 2128
		[ObfuscatedName("ActionList+<<InvokeAllStaggered>g__StaggeredInvoke|5_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique : Object
		{
			// Token: 0x0600CF8A RID: 53130 RVA: 0x003429DC File Offset: 0x00340BDC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique()
			{
				Il2CppClassPointerStore<ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionList>.NativeClassPtr, "<<InvokeAllStaggered>g__StaggeredInvoke|5_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique>.NativeClassPtr);
				ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique>.NativeClassPtr, "<>1__state");
				ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique>.NativeClassPtr, "<>2__current");
				ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique>.NativeClassPtr, "<>4__this");
				ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr_staggerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique>.NativeClassPtr, "staggerTime");
				ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr__listenerCount_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique>.NativeClassPtr, "<listenerCount>5__2");
				ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr__perDelay_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique>.NativeClassPtr, "<perDelay>5__3");
				ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr__waitOverflow_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique>.NativeClassPtr, "<waitOverflow>5__4");
				ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr__timeOnWaitStart_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique>.NativeClassPtr, "<timeOnWaitStart>5__5");
				ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr__loopsSinceLastWait_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique>.NativeClassPtr, "<loopsSinceLastWait>5__6");
				ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr__i_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique>.NativeClassPtr, "<i>5__7");
				ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique>.NativeClassPtr, 100663374);
				ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique>.NativeClassPtr, 100663375);
				ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique>.NativeClassPtr, 100663376);
				ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique>.NativeClassPtr, 100663377);
				ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique>.NativeClassPtr, 100663378);
				ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique>.NativeClassPtr, 100663379);
			}

			// Token: 0x0600CF8B RID: 53131 RVA: 0x00342B48 File Offset: 0x00340D48
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF8C RID: 53132 RVA: 0x00342B90 File Offset: 0x00340D90
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF8D RID: 53133 RVA: 0x00342BC4 File Offset: 0x00340DC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65389, XrefRangeEnd = 65413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003EE2 RID: 16098
			// (get) Token: 0x0600CF8E RID: 53134 RVA: 0x00342C00 File Offset: 0x00340E00
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF8F RID: 53135 RVA: 0x00342C40 File Offset: 0x00340E40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65413, XrefRangeEnd = 65418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003EE3 RID: 16099
			// (get) Token: 0x0600CF90 RID: 53136 RVA: 0x00342C74 File Offset: 0x00340E74
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF91 RID: 53137 RVA: 0x000623B2 File Offset: 0x000605B2
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ED8 RID: 16088
			// (get) Token: 0x0600CF92 RID: 53138 RVA: 0x00342CB4 File Offset: 0x00340EB4
			// (set) Token: 0x0600CF93 RID: 53139 RVA: 0x000623BB File Offset: 0x000605BB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003ED9 RID: 16089
			// (get) Token: 0x0600CF94 RID: 53140 RVA: 0x00342CDC File Offset: 0x00340EDC
			// (set) Token: 0x0600CF95 RID: 53141 RVA: 0x000623D6 File Offset: 0x000605D6
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EDA RID: 16090
			// (get) Token: 0x0600CF96 RID: 53142 RVA: 0x00342D0C File Offset: 0x00340F0C
			// (set) Token: 0x0600CF97 RID: 53143 RVA: 0x000623F5 File Offset: 0x000605F5
			public unsafe ActionList __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EDB RID: 16091
			// (get) Token: 0x0600CF98 RID: 53144 RVA: 0x00342D3C File Offset: 0x00340F3C
			// (set) Token: 0x0600CF99 RID: 53145 RVA: 0x00062414 File Offset: 0x00060614
			public unsafe float staggerTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr_staggerTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr_staggerTime)) = value;
				}
			}

			// Token: 0x17003EDC RID: 16092
			// (get) Token: 0x0600CF9A RID: 53146 RVA: 0x00342D64 File Offset: 0x00340F64
			// (set) Token: 0x0600CF9B RID: 53147 RVA: 0x0006242F File Offset: 0x0006062F
			public unsafe int _listenerCount_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr__listenerCount_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr__listenerCount_5__2)) = value;
				}
			}

			// Token: 0x17003EDD RID: 16093
			// (get) Token: 0x0600CF9C RID: 53148 RVA: 0x00342D8C File Offset: 0x00340F8C
			// (set) Token: 0x0600CF9D RID: 53149 RVA: 0x0006244A File Offset: 0x0006064A
			public unsafe float _perDelay_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr__perDelay_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr__perDelay_5__3)) = value;
				}
			}

			// Token: 0x17003EDE RID: 16094
			// (get) Token: 0x0600CF9E RID: 53150 RVA: 0x00342DB4 File Offset: 0x00340FB4
			// (set) Token: 0x0600CF9F RID: 53151 RVA: 0x00062465 File Offset: 0x00060665
			public unsafe float _waitOverflow_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr__waitOverflow_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr__waitOverflow_5__4)) = value;
				}
			}

			// Token: 0x17003EDF RID: 16095
			// (get) Token: 0x0600CFA0 RID: 53152 RVA: 0x00342DDC File Offset: 0x00340FDC
			// (set) Token: 0x0600CFA1 RID: 53153 RVA: 0x00062480 File Offset: 0x00060680
			public unsafe float _timeOnWaitStart_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr__timeOnWaitStart_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr__timeOnWaitStart_5__5)) = value;
				}
			}

			// Token: 0x17003EE0 RID: 16096
			// (get) Token: 0x0600CFA2 RID: 53154 RVA: 0x00342E04 File Offset: 0x00341004
			// (set) Token: 0x0600CFA3 RID: 53155 RVA: 0x0006249B File Offset: 0x0006069B
			public unsafe int _loopsSinceLastWait_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr__loopsSinceLastWait_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr__loopsSinceLastWait_5__6)) = value;
				}
			}

			// Token: 0x17003EE1 RID: 16097
			// (get) Token: 0x0600CFA4 RID: 53156 RVA: 0x00342E2C File Offset: 0x0034102C
			// (set) Token: 0x0600CFA5 RID: 53157 RVA: 0x000624B6 File Offset: 0x000606B6
			public unsafe int _i_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr__i_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionList.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAcSistInSiObSiInUnique.NativeFieldInfoPtr__i_5__7)) = value;
				}
			}

			// Token: 0x04008D83 RID: 36227
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008D84 RID: 36228
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008D85 RID: 36229
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D86 RID: 36230
			private static readonly IntPtr NativeFieldInfoPtr_staggerTime;

			// Token: 0x04008D87 RID: 36231
			private static readonly IntPtr NativeFieldInfoPtr__listenerCount_5__2;

			// Token: 0x04008D88 RID: 36232
			private static readonly IntPtr NativeFieldInfoPtr__perDelay_5__3;

			// Token: 0x04008D89 RID: 36233
			private static readonly IntPtr NativeFieldInfoPtr__waitOverflow_5__4;

			// Token: 0x04008D8A RID: 36234
			private static readonly IntPtr NativeFieldInfoPtr__timeOnWaitStart_5__5;

			// Token: 0x04008D8B RID: 36235
			private static readonly IntPtr NativeFieldInfoPtr__loopsSinceLastWait_5__6;

			// Token: 0x04008D8C RID: 36236
			private static readonly IntPtr NativeFieldInfoPtr__i_5__7;

			// Token: 0x04008D8D RID: 36237
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008D8E RID: 36238
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D8F RID: 36239
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008D90 RID: 36240
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008D91 RID: 36241
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D92 RID: 36242
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
