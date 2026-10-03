using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Platform
{
	// Token: 0x020001A8 RID: 424
	[Serializable]
	public sealed class SteamSessionAuthTicket : ValueType
	{
		// Token: 0x06002A6B RID: 10859 RVA: 0x00107198 File Offset: 0x00105398
		// Note: this type is marked as 'beforefieldinit'.
		static SteamSessionAuthTicket()
		{
			Il2CppClassPointerStore<SteamSessionAuthTicket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Platform", "SteamSessionAuthTicket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamSessionAuthTicket>.NativeClassPtr);
			SteamSessionAuthTicket.NativeFieldInfoPtr_Bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamSessionAuthTicket>.NativeClassPtr, "Bytes");
			SteamSessionAuthTicket.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamSessionAuthTicket>.NativeClassPtr, "Size");
			SteamSessionAuthTicket.NativeFieldInfoPtr_SteamId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamSessionAuthTicket>.NativeClassPtr, "SteamId");
			SteamSessionAuthTicket.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamSessionAuthTicket>.NativeClassPtr, 100668713);
			SteamSessionAuthTicket.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamSessionAuthTicket>.NativeClassPtr, 100668714);
			SteamSessionAuthTicket.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamSessionAuthTicket>.NativeClassPtr, 100668715);
			SteamSessionAuthTicket.NativeMethodInfoPtr_get_Invalid_Public_Static_get_SteamSessionAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamSessionAuthTicket>.NativeClassPtr, 100668716);
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x00107254 File Offset: 0x00105454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124270, XrefRangeEnd = 124271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamSessionAuthTicket(Il2CppStructArray<byte> ticket, uint size, ulong steamId) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamSessionAuthTicket>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ticket);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamSessionAuthTicket.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_UInt32_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x001072C0 File Offset: 0x001054C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124277, RefRangeEnd = 124278, XrefRangeStart = 124271, XrefRangeEnd = 124277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamSessionAuthTicket.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x00107314 File Offset: 0x00105514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124278, XrefRangeEnd = 124284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamSessionAuthTicket.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06002A6F RID: 10863 RVA: 0x00107358 File Offset: 0x00105558
		public unsafe static SteamSessionAuthTicket Invalid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124284, XrefRangeEnd = 124285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SteamSessionAuthTicket.NativeMethodInfoPtr_get_Invalid_Public_Static_get_SteamSessionAuthTicket_0, 0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new SteamSessionAuthTicket(pointer);
			}
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x00016223 File Offset: 0x00014423
		public SteamSessionAuthTicket(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x0001622C File Offset: 0x0001442C
		public SteamSessionAuthTicket() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamSessionAuthTicket>.NativeClassPtr))
		{
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06002A72 RID: 10866 RVA: 0x00107384 File Offset: 0x00105584
		// (set) Token: 0x06002A73 RID: 10867 RVA: 0x0001623E File Offset: 0x0001443E
		public unsafe Il2CppStructArray<byte> Bytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamSessionAuthTicket.NativeFieldInfoPtr_Bytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamSessionAuthTicket.NativeFieldInfoPtr_Bytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x06002A74 RID: 10868 RVA: 0x001073B4 File Offset: 0x001055B4
		// (set) Token: 0x06002A75 RID: 10869 RVA: 0x0001625D File Offset: 0x0001445D
		public unsafe uint Size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamSessionAuthTicket.NativeFieldInfoPtr_Size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamSessionAuthTicket.NativeFieldInfoPtr_Size)) = value;
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06002A76 RID: 10870 RVA: 0x001073DC File Offset: 0x001055DC
		// (set) Token: 0x06002A77 RID: 10871 RVA: 0x00016278 File Offset: 0x00014478
		public unsafe ulong SteamId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamSessionAuthTicket.NativeFieldInfoPtr_SteamId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamSessionAuthTicket.NativeFieldInfoPtr_SteamId)) = value;
			}
		}

		// Token: 0x04001D2A RID: 7466
		private static readonly IntPtr NativeFieldInfoPtr_Bytes;

		// Token: 0x04001D2B RID: 7467
		private static readonly IntPtr NativeFieldInfoPtr_Size;

		// Token: 0x04001D2C RID: 7468
		private static readonly IntPtr NativeFieldInfoPtr_SteamId;

		// Token: 0x04001D2D RID: 7469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_UInt32_UInt64_0;

		// Token: 0x04001D2E RID: 7470
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001D2F RID: 7471
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001D30 RID: 7472
		private static readonly IntPtr NativeMethodInfoPtr_get_Invalid_Public_Static_get_SteamSessionAuthTicket_0;
	}
}
