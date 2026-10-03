using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ScriptableObjects
{
	// Token: 0x02000455 RID: 1109
	[Serializable]
	public class CallerID : ScriptableObject
	{
		// Token: 0x060064D7 RID: 25815 RVA: 0x001D8D60 File Offset: 0x001D6F60
		// Note: this type is marked as 'beforefieldinit'.
		static CallerID()
		{
			Il2CppClassPointerStore<CallerID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ScriptableObjects", "CallerID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallerID>.NativeClassPtr);
			CallerID.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallerID>.NativeClassPtr, "Name");
			CallerID.NativeFieldInfoPtr_ProfilePicture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallerID>.NativeClassPtr, "ProfilePicture");
			CallerID.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallerID>.NativeClassPtr, 100676544);
		}

		// Token: 0x060064D8 RID: 25816 RVA: 0x001D8DCC File Offset: 0x001D6FCC
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 79617, RefRangeEnd = 79648, XrefRangeStart = 79617, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallerID() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallerID>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallerID.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064D9 RID: 25817 RVA: 0x0002F7E9 File Offset: 0x0002D9E9
		public CallerID(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x060064DA RID: 25818 RVA: 0x001D8E08 File Offset: 0x001D7008
		// (set) Token: 0x060064DB RID: 25819 RVA: 0x0002F7F2 File Offset: 0x0002D9F2
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallerID.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallerID.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x060064DC RID: 25820 RVA: 0x001D8E30 File Offset: 0x001D7030
		// (set) Token: 0x060064DD RID: 25821 RVA: 0x0002F811 File Offset: 0x0002DA11
		public unsafe Sprite ProfilePicture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallerID.NativeFieldInfoPtr_ProfilePicture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallerID.NativeFieldInfoPtr_ProfilePicture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004587 RID: 17799
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04004588 RID: 17800
		private static readonly IntPtr NativeFieldInfoPtr_ProfilePicture;

		// Token: 0x04004589 RID: 17801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
