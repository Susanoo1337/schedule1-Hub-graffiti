using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x0200029D RID: 669
	public class NetworkConditionalObject : MonoBehaviour
	{
		// Token: 0x060032C4 RID: 12996 RVA: 0x00123090 File Offset: 0x00121290
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkConditionalObject()
		{
			Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "NetworkConditionalObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr);
			NetworkConditionalObject.NativeFieldInfoPtr_condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr, "condition");
			NetworkConditionalObject.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr, 100669642);
			NetworkConditionalObject.NativeMethodInfoPtr_Check_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr, 100669643);
			NetworkConditionalObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr, 100669644);
		}

		// Token: 0x060032C5 RID: 12997 RVA: 0x00123110 File Offset: 0x00121310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136966, XrefRangeEnd = 137001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkConditionalObject.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x00123144 File Offset: 0x00121344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137001, XrefRangeEnd = 137004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Check()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkConditionalObject.NativeMethodInfoPtr_Check_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x00123178 File Offset: 0x00121378
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkConditionalObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkConditionalObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkConditionalObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032C8 RID: 13000 RVA: 0x0001A138 File Offset: 0x00018338
		public NetworkConditionalObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x060032C9 RID: 13001 RVA: 0x001231B4 File Offset: 0x001213B4
		// (set) Token: 0x060032CA RID: 13002 RVA: 0x0001A141 File Offset: 0x00018341
		public unsafe NetworkConditionalObject.ECondition condition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkConditionalObject.NativeFieldInfoPtr_condition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkConditionalObject.NativeFieldInfoPtr_condition)) = value;
			}
		}

		// Token: 0x040021D9 RID: 8665
		private static readonly IntPtr NativeFieldInfoPtr_condition;

		// Token: 0x040021DA RID: 8666
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040021DB RID: 8667
		private static readonly IntPtr NativeMethodInfoPtr_Check_Public_Void_0;

		// Token: 0x040021DC RID: 8668
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009FB RID: 2555
		[OriginalName("Assembly-CSharp.dll", "", "ECondition")]
		public enum ECondition
		{
			// Token: 0x040096D4 RID: 38612
			All,
			// Token: 0x040096D5 RID: 38613
			HostOnly
		}
	}
}
