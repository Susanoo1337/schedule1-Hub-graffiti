using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000278 RID: 632
	[Serializable]
	public class TrashItemData : Il2CppSystem.Object
	{
		// Token: 0x06003180 RID: 12672 RVA: 0x0011EA54 File Offset: 0x0011CC54
		// Note: this type is marked as 'beforefieldinit'.
		static TrashItemData()
		{
			Il2CppClassPointerStore<TrashItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TrashItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr);
			TrashItemData.NativeFieldInfoPtr_DataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, "DataType");
			TrashItemData.NativeFieldInfoPtr_TrashID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, "TrashID");
			TrashItemData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, "GUID");
			TrashItemData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, "Position");
			TrashItemData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, "Rotation");
			TrashItemData.NativeFieldInfoPtr_Contents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, "Contents");
			TrashItemData.NativeMethodInfoPtr__ctor_Public_Void_String_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr, 100669478);
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x0011EB10 File Offset: 0x0011CD10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135514, RefRangeEnd = 135515, XrefRangeStart = 135504, XrefRangeEnd = 135514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashItemData(string trashID, string guid, Vector3 position, Quaternion rotation) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItemData.NativeMethodInfoPtr__ctor_Public_Void_String_String_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x00019923 File Offset: 0x00017B23
		public TrashItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x06003183 RID: 12675 RVA: 0x0011EB8C File Offset: 0x0011CD8C
		// (set) Token: 0x06003184 RID: 12676 RVA: 0x0001992C File Offset: 0x00017B2C
		public unsafe string DataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_DataType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_DataType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x06003185 RID: 12677 RVA: 0x0011EBB4 File Offset: 0x0011CDB4
		// (set) Token: 0x06003186 RID: 12678 RVA: 0x0001994B File Offset: 0x00017B4B
		public unsafe string TrashID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_TrashID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_TrashID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x06003187 RID: 12679 RVA: 0x0011EBDC File Offset: 0x0011CDDC
		// (set) Token: 0x06003188 RID: 12680 RVA: 0x0001996A File Offset: 0x00017B6A
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x06003189 RID: 12681 RVA: 0x0011EC04 File Offset: 0x0011CE04
		// (set) Token: 0x0600318A RID: 12682 RVA: 0x00019989 File Offset: 0x00017B89
		public unsafe Vector3 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x0600318B RID: 12683 RVA: 0x0011EC2C File Offset: 0x0011CE2C
		// (set) Token: 0x0600318C RID: 12684 RVA: 0x000199A4 File Offset: 0x00017BA4
		public unsafe Quaternion Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x0600318D RID: 12685 RVA: 0x0011EC54 File Offset: 0x0011CE54
		// (set) Token: 0x0600318E RID: 12686 RVA: 0x000199BF File Offset: 0x00017BBF
		public unsafe TrashContentData Contents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Contents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContentData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItemData.NativeFieldInfoPtr_Contents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002105 RID: 8453
		private static readonly IntPtr NativeFieldInfoPtr_DataType;

		// Token: 0x04002106 RID: 8454
		private static readonly IntPtr NativeFieldInfoPtr_TrashID;

		// Token: 0x04002107 RID: 8455
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04002108 RID: 8456
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04002109 RID: 8457
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x0400210A RID: 8458
		private static readonly IntPtr NativeFieldInfoPtr_Contents;

		// Token: 0x0400210B RID: 8459
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Vector3_Quaternion_0;
	}
}
