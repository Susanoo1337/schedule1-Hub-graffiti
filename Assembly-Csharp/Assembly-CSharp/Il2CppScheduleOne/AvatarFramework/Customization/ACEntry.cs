using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020004AA RID: 1194
	public class ACEntry : MonoBehaviour
	{
		// Token: 0x06006D1C RID: 27932 RVA: 0x001F4138 File Offset: 0x001F2338
		// Note: this type is marked as 'beforefieldinit'.
		static ACEntry()
		{
			Il2CppClassPointerStore<ACEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACEntry>.NativeClassPtr);
			ACEntry.NativeFieldInfoPtr_DevOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACEntry>.NativeClassPtr, "DevOnly");
			ACEntry.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACEntry>.NativeClassPtr, 100677549);
			ACEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACEntry>.NativeClassPtr, 100677550);
		}

		// Token: 0x06006D1D RID: 27933 RVA: 0x001F41A4 File Offset: 0x001F23A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221845, XrefRangeEnd = 221851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACEntry.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D1E RID: 27934 RVA: 0x001F41D8 File Offset: 0x001F23D8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D1F RID: 27935 RVA: 0x00033808 File Offset: 0x00031A08
		public ACEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002199 RID: 8601
		// (get) Token: 0x06006D20 RID: 27936 RVA: 0x001F4214 File Offset: 0x001F2414
		// (set) Token: 0x06006D21 RID: 27937 RVA: 0x00033811 File Offset: 0x00031A11
		public unsafe bool DevOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACEntry.NativeFieldInfoPtr_DevOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACEntry.NativeFieldInfoPtr_DevOnly)) = value;
			}
		}

		// Token: 0x04004AF0 RID: 19184
		private static readonly IntPtr NativeFieldInfoPtr_DevOnly;

		// Token: 0x04004AF1 RID: 19185
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004AF2 RID: 19186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
