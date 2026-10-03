using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppFishySteamworks
{
	// Token: 0x02000092 RID: 146
	public sealed class LocalPacket : ValueType
	{
		// Token: 0x06000C5E RID: 3166 RVA: 0x000A4274 File Offset: 0x000A2474
		// Note: this type is marked as 'beforefieldinit'.
		static LocalPacket()
		{
			Il2CppClassPointerStore<LocalPacket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishySteamworks", "LocalPacket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalPacket>.NativeClassPtr);
			LocalPacket.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPacket>.NativeClassPtr, "Data");
			LocalPacket.NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPacket>.NativeClassPtr, "Length");
			LocalPacket.NativeFieldInfoPtr_Channel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPacket>.NativeClassPtr, "Channel");
			LocalPacket.NativeMethodInfoPtr__ctor_Public_Void_ArraySegment_1_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPacket>.NativeClassPtr, 100664852);
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x000A42F4 File Offset: 0x000A24F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78444, XrefRangeEnd = 78456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalPacket(ArraySegment<byte> data, byte channel) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalPacket>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPacket.NativeMethodInfoPtr__ctor_Public_Void_ArraySegment_1_Byte_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00007B63 File Offset: 0x00005D63
		public LocalPacket(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00007B6C File Offset: 0x00005D6C
		public LocalPacket() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalPacket>.NativeClassPtr))
		{
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x000A4358 File Offset: 0x000A2558
		// (set) Token: 0x06000C63 RID: 3171 RVA: 0x00007B7E File Offset: 0x00005D7E
		public unsafe Il2CppStructArray<byte> Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPacket.NativeFieldInfoPtr_Data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPacket.NativeFieldInfoPtr_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x000A4388 File Offset: 0x000A2588
		// (set) Token: 0x06000C65 RID: 3173 RVA: 0x00007B9D File Offset: 0x00005D9D
		public unsafe int Length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPacket.NativeFieldInfoPtr_Length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPacket.NativeFieldInfoPtr_Length)) = value;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x000A43B0 File Offset: 0x000A25B0
		// (set) Token: 0x06000C67 RID: 3175 RVA: 0x00007BB8 File Offset: 0x00005DB8
		public unsafe byte Channel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPacket.NativeFieldInfoPtr_Channel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPacket.NativeFieldInfoPtr_Channel)) = value;
			}
		}

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeFieldInfoPtr_Data;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeFieldInfoPtr_Length;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeFieldInfoPtr_Channel;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArraySegment_1_Byte_Byte_0;
	}
}
