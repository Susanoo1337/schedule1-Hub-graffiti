using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x020002A7 RID: 679
	[Serializable]
	public class Response : Object
	{
		// Token: 0x06003423 RID: 13347 RVA: 0x00128B38 File Offset: 0x00126D38
		// Note: this type is marked as 'beforefieldinit'.
		static Response()
		{
			Il2CppClassPointerStore<Response>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "Response");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Response>.NativeClassPtr);
			Response.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Response>.NativeClassPtr, "text");
			Response.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Response>.NativeClassPtr, "label");
			Response.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Response>.NativeClassPtr, "callback");
			Response.NativeFieldInfoPtr_disableDefaultResponseBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Response>.NativeClassPtr, "disableDefaultResponseBehaviour");
			Response.NativeMethodInfoPtr__ctor_Public_Void_String_String_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Response>.NativeClassPtr, 100669898);
			Response.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Response>.NativeClassPtr, 100669899);
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x00128BE0 File Offset: 0x00126DE0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 139832, RefRangeEnd = 139837, XrefRangeStart = 139828, XrefRangeEnd = 139832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Response(string _text, string _label, Action _callback = null, bool _disableDefaultResponseBehaviour = false) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Response>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_label);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _disableDefaultResponseBehaviour;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Response.NativeMethodInfoPtr__ctor_Public_Void_String_String_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x00128C60 File Offset: 0x00126E60
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Response() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Response>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Response.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x0001A923 File Offset: 0x00018B23
		public Response(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x06003427 RID: 13351 RVA: 0x00128C9C File Offset: 0x00126E9C
		// (set) Token: 0x06003428 RID: 13352 RVA: 0x0001A92C File Offset: 0x00018B2C
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x06003429 RID: 13353 RVA: 0x00128CC4 File Offset: 0x00126EC4
		// (set) Token: 0x0600342A RID: 13354 RVA: 0x0001A94B File Offset: 0x00018B4B
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x0600342B RID: 13355 RVA: 0x00128CEC File Offset: 0x00126EEC
		// (set) Token: 0x0600342C RID: 13356 RVA: 0x0001A96A File Offset: 0x00018B6A
		public unsafe Action callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x0600342D RID: 13357 RVA: 0x00128D1C File Offset: 0x00126F1C
		// (set) Token: 0x0600342E RID: 13358 RVA: 0x0001A989 File Offset: 0x00018B89
		public unsafe bool disableDefaultResponseBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_disableDefaultResponseBehaviour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_disableDefaultResponseBehaviour)) = value;
			}
		}

		// Token: 0x040022E5 RID: 8933
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x040022E6 RID: 8934
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x040022E7 RID: 8935
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x040022E8 RID: 8936
		private static readonly IntPtr NativeFieldInfoPtr_disableDefaultResponseBehaviour;

		// Token: 0x040022E9 RID: 8937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Action_Boolean_0;

		// Token: 0x040022EA RID: 8938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
