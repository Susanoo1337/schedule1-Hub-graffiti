using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000121 RID: 289
	public sealed class RequireComponent : Attribute
	{
		// Token: 0x0600175C RID: 5980 RVA: 0x00065280 File Offset: 0x00063480
		// Note: this type is marked as 'beforefieldinit'.
		static RequireComponent()
		{
			Il2CppClassPointerStore<RequireComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RequireComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr);
			RequireComponent.NativeFieldInfoPtr_m_Type0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr, "m_Type0");
			RequireComponent.NativeFieldInfoPtr_m_Type1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr, "m_Type1");
			RequireComponent.NativeFieldInfoPtr_m_Type2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr, "m_Type2");
			RequireComponent.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr, 100665751);
			RequireComponent.NativeMethodInfoPtr__ctor_Public_Void_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr, 100665752);
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x00065314 File Offset: 0x00063514
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 31934, RefRangeEnd = 31959, XrefRangeStart = 31934, XrefRangeEnd = 31959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequireComponent(Type requiredComponent) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(requiredComponent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequireComponent.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x00065360 File Offset: 0x00063560
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 64342, RefRangeEnd = 64345, XrefRangeStart = 64342, XrefRangeEnd = 64345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequireComponent(Type requiredComponent, Type requiredComponent2) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(requiredComponent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requiredComponent2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequireComponent.NativeMethodInfoPtr__ctor_Public_Void_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x0000B9F0 File Offset: 0x00009BF0
		public RequireComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x000653C0 File Offset: 0x000635C0
		// (set) Token: 0x06001761 RID: 5985 RVA: 0x0000B9F9 File Offset: 0x00009BF9
		public unsafe Type m_Type0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x000653F0 File Offset: 0x000635F0
		// (set) Token: 0x06001763 RID: 5987 RVA: 0x0000BA18 File Offset: 0x00009C18
		public unsafe Type m_Type1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001764 RID: 5988 RVA: 0x00065420 File Offset: 0x00063620
		// (set) Token: 0x06001765 RID: 5989 RVA: 0x0000BA37 File Offset: 0x00009C37
		public unsafe Type m_Type2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013D5 RID: 5077
		private static readonly IntPtr NativeFieldInfoPtr_m_Type0;

		// Token: 0x040013D6 RID: 5078
		private static readonly IntPtr NativeFieldInfoPtr_m_Type1;

		// Token: 0x040013D7 RID: 5079
		private static readonly IntPtr NativeFieldInfoPtr_m_Type2;

		// Token: 0x040013D8 RID: 5080
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x040013D9 RID: 5081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Type_0;
	}
}
