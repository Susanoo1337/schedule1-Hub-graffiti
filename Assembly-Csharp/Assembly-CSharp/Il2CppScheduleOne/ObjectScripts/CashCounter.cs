using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x020005BE RID: 1470
	public class CashCounter : MonoBehaviour
	{
		// Token: 0x06008EC5 RID: 36549 RVA: 0x0026B724 File Offset: 0x00269924
		// Note: this type is marked as 'beforefieldinit'.
		static CashCounter()
		{
			Il2CppClassPointerStore<CashCounter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "CashCounter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashCounter>.NativeClassPtr);
			CashCounter.NativeFieldInfoPtr_NoteLerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "NoteLerpTime");
			CashCounter.NativeFieldInfoPtr_IsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "IsOn");
			CashCounter.NativeFieldInfoPtr_UpperNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "UpperNotes");
			CashCounter.NativeFieldInfoPtr_LowerNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "LowerNotes");
			CashCounter.NativeFieldInfoPtr_NoteStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "NoteStartPoint");
			CashCounter.NativeFieldInfoPtr_NoteEndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "NoteEndPoint");
			CashCounter.NativeFieldInfoPtr_MovingNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "MovingNotes");
			CashCounter.NativeFieldInfoPtr_Audio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "Audio");
			CashCounter.NativeFieldInfoPtr_lerping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "lerping");
			CashCounter.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, 100681819);
			CashCounter.NativeMethodInfoPtr_LerpNote_Private_IEnumerator_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, 100681820);
			CashCounter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, 100681821);
		}

		// Token: 0x06008EC6 RID: 36550 RVA: 0x0026B844 File Offset: 0x00269A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262805, XrefRangeEnd = 262815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashCounter.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EC7 RID: 36551 RVA: 0x0026B880 File Offset: 0x00269A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262815, XrefRangeEnd = 262821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LerpNote(Transform note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter.NativeMethodInfoPtr_LerpNote_Private_IEnumerator_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008EC8 RID: 36552 RVA: 0x0026B8D0 File Offset: 0x00269AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262821, XrefRangeEnd = 262829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashCounter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashCounter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EC9 RID: 36553 RVA: 0x000436FE File Offset: 0x000418FE
		public CashCounter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C40 RID: 11328
		// (get) Token: 0x06008ECA RID: 36554 RVA: 0x0026B90C File Offset: 0x00269B0C
		// (set) Token: 0x06008ECB RID: 36555 RVA: 0x00043707 File Offset: 0x00041907
		public unsafe static float NoteLerpTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CashCounter.NativeFieldInfoPtr_NoteLerpTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CashCounter.NativeFieldInfoPtr_NoteLerpTime, (void*)(&value));
			}
		}

		// Token: 0x17002C41 RID: 11329
		// (get) Token: 0x06008ECC RID: 36556 RVA: 0x0026B928 File Offset: 0x00269B28
		// (set) Token: 0x06008ECD RID: 36557 RVA: 0x00043715 File Offset: 0x00041915
		public unsafe bool IsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_IsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_IsOn)) = value;
			}
		}

		// Token: 0x17002C42 RID: 11330
		// (get) Token: 0x06008ECE RID: 36558 RVA: 0x0026B950 File Offset: 0x00269B50
		// (set) Token: 0x06008ECF RID: 36559 RVA: 0x00043730 File Offset: 0x00041930
		public unsafe GameObject UpperNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_UpperNotes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_UpperNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C43 RID: 11331
		// (get) Token: 0x06008ED0 RID: 36560 RVA: 0x0026B980 File Offset: 0x00269B80
		// (set) Token: 0x06008ED1 RID: 36561 RVA: 0x0004374F File Offset: 0x0004194F
		public unsafe GameObject LowerNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_LowerNotes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_LowerNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C44 RID: 11332
		// (get) Token: 0x06008ED2 RID: 36562 RVA: 0x0026B9B0 File Offset: 0x00269BB0
		// (set) Token: 0x06008ED3 RID: 36563 RVA: 0x0004376E File Offset: 0x0004196E
		public unsafe Transform NoteStartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_NoteStartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_NoteStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C45 RID: 11333
		// (get) Token: 0x06008ED4 RID: 36564 RVA: 0x0026B9E0 File Offset: 0x00269BE0
		// (set) Token: 0x06008ED5 RID: 36565 RVA: 0x0004378D File Offset: 0x0004198D
		public unsafe Transform NoteEndPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_NoteEndPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_NoteEndPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C46 RID: 11334
		// (get) Token: 0x06008ED6 RID: 36566 RVA: 0x0026BA10 File Offset: 0x00269C10
		// (set) Token: 0x06008ED7 RID: 36567 RVA: 0x000437AC File Offset: 0x000419AC
		public unsafe List<Transform> MovingNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_MovingNotes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_MovingNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C47 RID: 11335
		// (get) Token: 0x06008ED8 RID: 36568 RVA: 0x0026BA40 File Offset: 0x00269C40
		// (set) Token: 0x06008ED9 RID: 36569 RVA: 0x000437CB File Offset: 0x000419CB
		public unsafe AudioSourceController Audio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_Audio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_Audio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C48 RID: 11336
		// (get) Token: 0x06008EDA RID: 36570 RVA: 0x0026BA70 File Offset: 0x00269C70
		// (set) Token: 0x06008EDB RID: 36571 RVA: 0x000437EA File Offset: 0x000419EA
		public unsafe bool lerping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_lerping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter.NativeFieldInfoPtr_lerping)) = value;
			}
		}

		// Token: 0x04006208 RID: 25096
		private static readonly IntPtr NativeFieldInfoPtr_NoteLerpTime;

		// Token: 0x04006209 RID: 25097
		private static readonly IntPtr NativeFieldInfoPtr_IsOn;

		// Token: 0x0400620A RID: 25098
		private static readonly IntPtr NativeFieldInfoPtr_UpperNotes;

		// Token: 0x0400620B RID: 25099
		private static readonly IntPtr NativeFieldInfoPtr_LowerNotes;

		// Token: 0x0400620C RID: 25100
		private static readonly IntPtr NativeFieldInfoPtr_NoteStartPoint;

		// Token: 0x0400620D RID: 25101
		private static readonly IntPtr NativeFieldInfoPtr_NoteEndPoint;

		// Token: 0x0400620E RID: 25102
		private static readonly IntPtr NativeFieldInfoPtr_MovingNotes;

		// Token: 0x0400620F RID: 25103
		private static readonly IntPtr NativeFieldInfoPtr_Audio;

		// Token: 0x04006210 RID: 25104
		private static readonly IntPtr NativeFieldInfoPtr_lerping;

		// Token: 0x04006211 RID: 25105
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04006212 RID: 25106
		private static readonly IntPtr NativeMethodInfoPtr_LerpNote_Private_IEnumerator_Transform_0;

		// Token: 0x04006213 RID: 25107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C1C RID: 3100
		[ObfuscatedName("ScheduleOne.ObjectScripts.CashCounter+<LerpNote>d__10")]
		public sealed class _LerpNote_d__10 : Il2CppSystem.Object
		{
			// Token: 0x0600EE51 RID: 61009 RVA: 0x0039A634 File Offset: 0x00398834
			// Note: this type is marked as 'beforefieldinit'.
			static _LerpNote_d__10()
			{
				Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CashCounter>.NativeClassPtr, "<LerpNote>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr);
				CashCounter._LerpNote_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, "<>1__state");
				CashCounter._LerpNote_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, "<>2__current");
				CashCounter._LerpNote_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, "<>4__this");
				CashCounter._LerpNote_d__10.NativeFieldInfoPtr_note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, "note");
				CashCounter._LerpNote_d__10.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, "<i>5__2");
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100681822);
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100681823);
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100681824);
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100681825);
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100681826);
				CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr, 100681827);
			}

			// Token: 0x0600EE52 RID: 61010 RVA: 0x0039A73C File Offset: 0x0039893C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LerpNote_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashCounter._LerpNote_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE53 RID: 61011 RVA: 0x0039A784 File Offset: 0x00398984
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE54 RID: 61012 RVA: 0x0039A7B8 File Offset: 0x003989B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262776, XrefRangeEnd = 262800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004846 RID: 18502
			// (get) Token: 0x0600EE55 RID: 61013 RVA: 0x0039A7F4 File Offset: 0x003989F4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EE56 RID: 61014 RVA: 0x0039A834 File Offset: 0x00398A34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262800, XrefRangeEnd = 262805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004847 RID: 18503
			// (get) Token: 0x0600EE57 RID: 61015 RVA: 0x0039A868 File Offset: 0x00398A68
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashCounter._LerpNote_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EE58 RID: 61016 RVA: 0x000707CC File Offset: 0x0006E9CC
			public _LerpNote_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004841 RID: 18497
			// (get) Token: 0x0600EE59 RID: 61017 RVA: 0x0039A8A8 File Offset: 0x00398AA8
			// (set) Token: 0x0600EE5A RID: 61018 RVA: 0x000707D5 File Offset: 0x0006E9D5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004842 RID: 18498
			// (get) Token: 0x0600EE5B RID: 61019 RVA: 0x0039A8D0 File Offset: 0x00398AD0
			// (set) Token: 0x0600EE5C RID: 61020 RVA: 0x000707F0 File Offset: 0x0006E9F0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004843 RID: 18499
			// (get) Token: 0x0600EE5D RID: 61021 RVA: 0x0039A900 File Offset: 0x00398B00
			// (set) Token: 0x0600EE5E RID: 61022 RVA: 0x0007080F File Offset: 0x0006EA0F
			public unsafe CashCounter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashCounter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004844 RID: 18500
			// (get) Token: 0x0600EE5F RID: 61023 RVA: 0x0039A930 File Offset: 0x00398B30
			// (set) Token: 0x0600EE60 RID: 61024 RVA: 0x0007082E File Offset: 0x0006EA2E
			public unsafe Transform note
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr_note);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr_note), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004845 RID: 18501
			// (get) Token: 0x0600EE61 RID: 61025 RVA: 0x0039A960 File Offset: 0x00398B60
			// (set) Token: 0x0600EE62 RID: 61026 RVA: 0x0007084D File Offset: 0x0006EA4D
			public unsafe float _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashCounter._LerpNote_d__10.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x0400A160 RID: 41312
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A161 RID: 41313
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A162 RID: 41314
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A163 RID: 41315
			private static readonly IntPtr NativeFieldInfoPtr_note;

			// Token: 0x0400A164 RID: 41316
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x0400A165 RID: 41317
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A166 RID: 41318
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A167 RID: 41319
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A168 RID: 41320
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A169 RID: 41321
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A16A RID: 41322
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
