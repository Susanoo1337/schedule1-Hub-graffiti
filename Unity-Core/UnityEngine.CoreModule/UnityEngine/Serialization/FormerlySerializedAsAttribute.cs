using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Serialization
{
	// Token: 0x020001AC RID: 428
	public class FormerlySerializedAsAttribute : Attribute
	{
		// Token: 0x06001FB8 RID: 8120 RVA: 0x0008261C File Offset: 0x0008081C
		// Note: this type is marked as 'beforefieldinit'.
		static FormerlySerializedAsAttribute()
		{
			Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Serialization", "FormerlySerializedAsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr);
			FormerlySerializedAsAttribute.NativeFieldInfoPtr_m_oldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr, "m_oldName");
			FormerlySerializedAsAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr, 100666767);
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x00082674 File Offset: 0x00080874
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 31934, RefRangeEnd = 31959, XrefRangeStart = 31934, XrefRangeEnd = 31959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormerlySerializedAsAttribute(string oldName) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormerlySerializedAsAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x0000EAAA File Offset: 0x0000CCAA
		public FormerlySerializedAsAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001FBB RID: 8123 RVA: 0x000826C0 File Offset: 0x000808C0
		// (set) Token: 0x06001FBC RID: 8124 RVA: 0x0000EAB3 File Offset: 0x0000CCB3
		public unsafe string m_oldName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormerlySerializedAsAttribute.NativeFieldInfoPtr_m_oldName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormerlySerializedAsAttribute.NativeFieldInfoPtr_m_oldName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001FBD RID: 8125 RVA: 0x000826E8 File Offset: 0x000808E8
		public string oldName
		{
			get
			{
				return this.m_oldName;
			}
		}

		// Token: 0x040019CA RID: 6602
		private static readonly IntPtr NativeFieldInfoPtr_m_oldName;

		// Token: 0x040019CB RID: 6603
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
