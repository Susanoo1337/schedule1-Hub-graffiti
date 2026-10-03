using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x020003AD RID: 941
	public class RollerDoor : MonoBehaviour
	{
		// Token: 0x06005595 RID: 21909 RVA: 0x001A38D8 File Offset: 0x001A1AD8
		// Note: this type is marked as 'beforefieldinit'.
		static RollerDoor()
		{
			Il2CppClassPointerStore<RollerDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "RollerDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr);
			RollerDoor.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "<IsOpen>k__BackingField");
			RollerDoor.NativeFieldInfoPtr_Door = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "Door");
			RollerDoor.NativeFieldInfoPtr_LocalPos_Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "LocalPos_Open");
			RollerDoor.NativeFieldInfoPtr_LocalPos_Closed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "LocalPos_Closed");
			RollerDoor.NativeFieldInfoPtr_LerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "LerpTime");
			RollerDoor.NativeFieldInfoPtr_Blocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "Blocker");
			RollerDoor.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "startPos");
			RollerDoor.NativeFieldInfoPtr_timeSinceValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, "timeSinceValueChange");
			RollerDoor.NativeMethodInfoPtr_get_IsOpen_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100674518);
			RollerDoor.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100674519);
			RollerDoor.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100674520);
			RollerDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100674521);
			RollerDoor.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100674522);
			RollerDoor.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100674523);
			RollerDoor.NativeMethodInfoPtr_CanOpen_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100674524);
			RollerDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr, 100674525);
		}

		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x06005596 RID: 21910 RVA: 0x001A3A48 File Offset: 0x001A1C48
		// (set) Token: 0x06005597 RID: 21911 RVA: 0x001A3A84 File Offset: 0x001A1C84
		public unsafe virtual bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_get_IsOpen_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005598 RID: 21912 RVA: 0x001A3AC4 File Offset: 0x001A1CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189477, XrefRangeEnd = 189479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005599 RID: 21913 RVA: 0x001A3AF8 File Offset: 0x001A1CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189479, XrefRangeEnd = 189491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600559A RID: 21914 RVA: 0x001A3B2C File Offset: 0x001A1D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189491, XrefRangeEnd = 189492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600559B RID: 21915 RVA: 0x001A3B60 File Offset: 0x001A1D60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189493, RefRangeEnd = 189494, XrefRangeStart = 189492, XrefRangeEnd = 189493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600559C RID: 21916 RVA: 0x001A3B94 File Offset: 0x001A1D94
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RollerDoor.NativeMethodInfoPtr_CanOpen_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600559D RID: 21917 RVA: 0x001A3BDC File Offset: 0x001A1DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189494, XrefRangeEnd = 189497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RollerDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RollerDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollerDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600559E RID: 21918 RVA: 0x000286FA File Offset: 0x000268FA
		public RollerDoor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x0600559F RID: 21919 RVA: 0x001A3C18 File Offset: 0x001A1E18
		// (set) Token: 0x060055A0 RID: 21920 RVA: 0x00028703 File Offset: 0x00026903
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x060055A1 RID: 21921 RVA: 0x001A3C40 File Offset: 0x001A1E40
		// (set) Token: 0x060055A2 RID: 21922 RVA: 0x0002871E File Offset: 0x0002691E
		public unsafe Transform Door
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_Door);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_Door), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x060055A3 RID: 21923 RVA: 0x001A3C70 File Offset: 0x001A1E70
		// (set) Token: 0x060055A4 RID: 21924 RVA: 0x0002873D File Offset: 0x0002693D
		public unsafe Vector3 LocalPos_Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LocalPos_Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LocalPos_Open)) = value;
			}
		}

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x060055A5 RID: 21925 RVA: 0x001A3C98 File Offset: 0x001A1E98
		// (set) Token: 0x060055A6 RID: 21926 RVA: 0x00028758 File Offset: 0x00026958
		public unsafe Vector3 LocalPos_Closed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LocalPos_Closed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LocalPos_Closed)) = value;
			}
		}

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x060055A7 RID: 21927 RVA: 0x001A3CC0 File Offset: 0x001A1EC0
		// (set) Token: 0x060055A8 RID: 21928 RVA: 0x00028773 File Offset: 0x00026973
		public unsafe float LerpTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LerpTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_LerpTime)) = value;
			}
		}

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x060055A9 RID: 21929 RVA: 0x001A3CE8 File Offset: 0x001A1EE8
		// (set) Token: 0x060055AA RID: 21930 RVA: 0x0002878E File Offset: 0x0002698E
		public unsafe GameObject Blocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_Blocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_Blocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A88 RID: 6792
		// (get) Token: 0x060055AB RID: 21931 RVA: 0x001A3D18 File Offset: 0x001A1F18
		// (set) Token: 0x060055AC RID: 21932 RVA: 0x000287AD File Offset: 0x000269AD
		public unsafe Vector3 startPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_startPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_startPos)) = value;
			}
		}

		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x060055AD RID: 21933 RVA: 0x001A3D40 File Offset: 0x001A1F40
		// (set) Token: 0x060055AE RID: 21934 RVA: 0x000287C8 File Offset: 0x000269C8
		public unsafe float timeSinceValueChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_timeSinceValueChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollerDoor.NativeFieldInfoPtr_timeSinceValueChange)) = value;
			}
		}

		// Token: 0x04003AFF RID: 15103
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04003B00 RID: 15104
		private static readonly IntPtr NativeFieldInfoPtr_Door;

		// Token: 0x04003B01 RID: 15105
		private static readonly IntPtr NativeFieldInfoPtr_LocalPos_Open;

		// Token: 0x04003B02 RID: 15106
		private static readonly IntPtr NativeFieldInfoPtr_LocalPos_Closed;

		// Token: 0x04003B03 RID: 15107
		private static readonly IntPtr NativeFieldInfoPtr_LerpTime;

		// Token: 0x04003B04 RID: 15108
		private static readonly IntPtr NativeFieldInfoPtr_Blocker;

		// Token: 0x04003B05 RID: 15109
		private static readonly IntPtr NativeFieldInfoPtr_startPos;

		// Token: 0x04003B06 RID: 15110
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceValueChange;

		// Token: 0x04003B07 RID: 15111
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003B08 RID: 15112
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04003B09 RID: 15113
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003B0A RID: 15114
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04003B0B RID: 15115
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04003B0C RID: 15116
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04003B0D RID: 15117
		private static readonly IntPtr NativeMethodInfoPtr_CanOpen_Protected_Virtual_New_Boolean_0;

		// Token: 0x04003B0E RID: 15118
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
