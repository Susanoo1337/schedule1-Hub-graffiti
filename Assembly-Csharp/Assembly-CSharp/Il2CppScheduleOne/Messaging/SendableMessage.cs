using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x020002A8 RID: 680
	public class SendableMessage : Object
	{
		// Token: 0x0600342F RID: 13359 RVA: 0x00128D44 File Offset: 0x00126F44
		// Note: this type is marked as 'beforefieldinit'.
		static SendableMessage()
		{
			Il2CppClassPointerStore<SendableMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "SendableMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr);
			SendableMessage.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "Text");
			SendableMessage.NativeFieldInfoPtr_ShouldShowCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "ShouldShowCheck");
			SendableMessage.NativeFieldInfoPtr_IsValidCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "IsValidCheck");
			SendableMessage.NativeFieldInfoPtr_onSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "onSelected");
			SendableMessage.NativeFieldInfoPtr_onSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "onSent");
			SendableMessage.NativeFieldInfoPtr_conversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "conversation");
			SendableMessage.NativeFieldInfoPtr_disableDefaultSendBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "disableDefaultSendBehaviour");
			SendableMessage.NativeFieldInfoPtr_sentIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "sentIDs");
			SendableMessage.NativeMethodInfoPtr__ctor_Public_Void_String_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, 100669900);
			SendableMessage.NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, 100669901);
			SendableMessage.NativeMethodInfoPtr_IsValid_Public_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, 100669902);
			SendableMessage.NativeMethodInfoPtr_Send_Public_Virtual_New_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, 100669903);
		}

		// Token: 0x06003430 RID: 13360 RVA: 0x00128E64 File Offset: 0x00127064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139863, XrefRangeEnd = 139873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SendableMessage(string text, MSGConversation conversation) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conversation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.NativeMethodInfoPtr__ctor_Public_Void_String_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x00128EC4 File Offset: 0x001270C4
		[CallerCount(0)]
		public unsafe virtual bool ShouldShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SendableMessage.NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003432 RID: 13362 RVA: 0x00128F0C File Offset: 0x0012710C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139873, XrefRangeEnd = 139877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsValid(out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SendableMessage.NativeMethodInfoPtr_IsValid_Public_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x00128F70 File Offset: 0x00127170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139877, XrefRangeEnd = 139891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Send(bool network, int id = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SendableMessage.NativeMethodInfoPtr_Send_Public_Virtual_New_Void_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x0001A9A4 File Offset: 0x00018BA4
		public SendableMessage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x06003435 RID: 13365 RVA: 0x00128FC8 File Offset: 0x001271C8
		// (set) Token: 0x06003436 RID: 13366 RVA: 0x0001A9AD File Offset: 0x00018BAD
		public unsafe string Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x06003437 RID: 13367 RVA: 0x00128FF0 File Offset: 0x001271F0
		// (set) Token: 0x06003438 RID: 13368 RVA: 0x0001A9CC File Offset: 0x00018BCC
		public unsafe SendableMessage.BoolCheck ShouldShowCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_ShouldShowCheck);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendableMessage.BoolCheck>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_ShouldShowCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x06003439 RID: 13369 RVA: 0x00129020 File Offset: 0x00127220
		// (set) Token: 0x0600343A RID: 13370 RVA: 0x0001A9EB File Offset: 0x00018BEB
		public unsafe SendableMessage.ValidityCheck IsValidCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_IsValidCheck);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendableMessage.ValidityCheck>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_IsValidCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x0600343B RID: 13371 RVA: 0x00129050 File Offset: 0x00127250
		// (set) Token: 0x0600343C RID: 13372 RVA: 0x0001AA0A File Offset: 0x00018C0A
		public unsafe Action onSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_onSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_onSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x0600343D RID: 13373 RVA: 0x00129080 File Offset: 0x00127280
		// (set) Token: 0x0600343E RID: 13374 RVA: 0x0001AA29 File Offset: 0x00018C29
		public unsafe Action onSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_onSent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_onSent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x0600343F RID: 13375 RVA: 0x001290B0 File Offset: 0x001272B0
		// (set) Token: 0x06003440 RID: 13376 RVA: 0x0001AA48 File Offset: 0x00018C48
		public unsafe MSGConversation conversation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_conversation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_conversation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x06003441 RID: 13377 RVA: 0x001290E0 File Offset: 0x001272E0
		// (set) Token: 0x06003442 RID: 13378 RVA: 0x0001AA67 File Offset: 0x00018C67
		public unsafe bool disableDefaultSendBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_disableDefaultSendBehaviour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_disableDefaultSendBehaviour)) = value;
			}
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x06003443 RID: 13379 RVA: 0x00129108 File Offset: 0x00127308
		// (set) Token: 0x06003444 RID: 13380 RVA: 0x0001AA82 File Offset: 0x00018C82
		public unsafe List<int> sentIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_sentIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendableMessage.NativeFieldInfoPtr_sentIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040022EB RID: 8939
		private static readonly IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x040022EC RID: 8940
		private static readonly IntPtr NativeFieldInfoPtr_ShouldShowCheck;

		// Token: 0x040022ED RID: 8941
		private static readonly IntPtr NativeFieldInfoPtr_IsValidCheck;

		// Token: 0x040022EE RID: 8942
		private static readonly IntPtr NativeFieldInfoPtr_onSelected;

		// Token: 0x040022EF RID: 8943
		private static readonly IntPtr NativeFieldInfoPtr_onSent;

		// Token: 0x040022F0 RID: 8944
		private static readonly IntPtr NativeFieldInfoPtr_conversation;

		// Token: 0x040022F1 RID: 8945
		private static readonly IntPtr NativeFieldInfoPtr_disableDefaultSendBehaviour;

		// Token: 0x040022F2 RID: 8946
		private static readonly IntPtr NativeFieldInfoPtr_sentIDs;

		// Token: 0x040022F3 RID: 8947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_MSGConversation_0;

		// Token: 0x040022F4 RID: 8948
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0;

		// Token: 0x040022F5 RID: 8949
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Virtual_New_Boolean_byref_String_0;

		// Token: 0x040022F6 RID: 8950
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_New_Void_Boolean_Int32_0;

		// Token: 0x02000A09 RID: 2569
		public sealed class BoolCheck : MulticastDelegate
		{
			// Token: 0x0600DDAC RID: 56748 RVA: 0x0036B4B4 File Offset: 0x003696B4
			// Note: this type is marked as 'beforefieldinit'.
			static BoolCheck()
			{
				Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "BoolCheck");
				SendableMessage.BoolCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr, 100669904);
				SendableMessage.BoolCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr, 100669905);
				SendableMessage.BoolCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr, 100669906);
				SendableMessage.BoolCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr, 100669907);
			}

			// Token: 0x0600DDAD RID: 56749 RVA: 0x0036B528 File Offset: 0x00369728
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 139847, RefRangeEnd = 139848, XrefRangeStart = 139837, XrefRangeEnd = 139847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BoolCheck(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendableMessage.BoolCheck>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.BoolCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDAE RID: 56750 RVA: 0x0036B584 File Offset: 0x00369784
			[CallerCount(0)]
			public unsafe bool Invoke(SendableMessage message)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.BoolCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DDAF RID: 56751 RVA: 0x0036B5D4 File Offset: 0x003697D4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71797, RefRangeEnd = 71798, XrefRangeStart = 71797, XrefRangeEnd = 71798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(SendableMessage message, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.BoolCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600DDB0 RID: 56752 RVA: 0x0036B648 File Offset: 0x00369848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.BoolCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DDB1 RID: 56753 RVA: 0x000685A3 File Offset: 0x000667A3
			public BoolCheck(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600DDB2 RID: 56754 RVA: 0x000685AC File Offset: 0x000667AC
			public static implicit operator SendableMessage.BoolCheck(Func<SendableMessage, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<SendableMessage.BoolCheck>(A_0);
			}

			// Token: 0x0600DDB3 RID: 56755 RVA: 0x000685B4 File Offset: 0x000667B4
			public static SendableMessage.BoolCheck operator +(SendableMessage.BoolCheck A_0, SendableMessage.BoolCheck A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<SendableMessage.BoolCheck>();
			}

			// Token: 0x0600DDB4 RID: 56756 RVA: 0x000685C2 File Offset: 0x000667C2
			public static SendableMessage.BoolCheck operator -(SendableMessage.BoolCheck A_0, SendableMessage.BoolCheck A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<SendableMessage.BoolCheck>();
				}
				return result;
			}

			// Token: 0x04009715 RID: 38677
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04009716 RID: 38678
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_0;

			// Token: 0x04009717 RID: 38679
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_AsyncCallback_Object_0;

			// Token: 0x04009718 RID: 38680
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;
		}

		// Token: 0x02000A0A RID: 2570
		public sealed class ValidityCheck : MulticastDelegate
		{
			// Token: 0x0600DDB5 RID: 56757 RVA: 0x0036B698 File Offset: 0x00369898
			// Note: this type is marked as 'beforefieldinit'.
			static ValidityCheck()
			{
				Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SendableMessage>.NativeClassPtr, "ValidityCheck");
				SendableMessage.ValidityCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr, 100669908);
				SendableMessage.ValidityCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr, 100669909);
				SendableMessage.ValidityCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_byref_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr, 100669910);
				SendableMessage.ValidityCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr, 100669911);
			}

			// Token: 0x0600DDB6 RID: 56758 RVA: 0x0036B70C File Offset: 0x0036990C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 139858, RefRangeEnd = 139860, XrefRangeStart = 139848, XrefRangeEnd = 139858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValidityCheck(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendableMessage.ValidityCheck>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendableMessage.ValidityCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDB7 RID: 56759 RVA: 0x0036B768 File Offset: 0x00369968
			[CallerCount(0)]
			public unsafe bool Invoke(SendableMessage message, out string invalidReason)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SendableMessage.ValidityCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600DDB8 RID: 56760 RVA: 0x0036B7D0 File Offset: 0x003699D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139860, XrefRangeEnd = 139861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(SendableMessage message, out string invalidReason, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SendableMessage.ValidityCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_byref_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
			}

			// Token: 0x0600DDB9 RID: 56761 RVA: 0x0036B860 File Offset: 0x00369A60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139861, XrefRangeEnd = 139863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(out string invalidReason, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SendableMessage.ValidityCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600DDBA RID: 56762 RVA: 0x000685D3 File Offset: 0x000667D3
			public ValidityCheck(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009719 RID: 38681
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400971A RID: 38682
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SendableMessage_byref_String_0;

			// Token: 0x0400971B RID: 38683
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SendableMessage_byref_String_AsyncCallback_Object_0;

			// Token: 0x0400971C RID: 38684
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0;
		}
	}
}
