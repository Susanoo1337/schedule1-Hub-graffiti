using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using UnityEngine;

namespace Il2CppScheduleOne.Interaction
{
	// Token: 0x02000334 RID: 820
	public class IUsableInteractableObject : InteractableObject
	{
		// Token: 0x06004691 RID: 18065 RVA: 0x0016B374 File Offset: 0x00169574
		// Note: this type is marked as 'beforefieldinit'.
		static IUsableInteractableObject()
		{
			Il2CppClassPointerStore<IUsableInteractableObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Interaction", "IUsableInteractableObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IUsableInteractableObject>.NativeClassPtr);
			IUsableInteractableObject.NativeFieldInfoPtr__iUsableMonoBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUsableInteractableObject>.NativeClassPtr, "_iUsableMonoBehaviour");
			IUsableInteractableObject.NativeFieldInfoPtr__defaultMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUsableInteractableObject>.NativeClassPtr, "_defaultMessage");
			IUsableInteractableObject.NativeFieldInfoPtr__iUsable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IUsableInteractableObject>.NativeClassPtr, "_iUsable");
			IUsableInteractableObject.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsableInteractableObject>.NativeClassPtr, 100672369);
			IUsableInteractableObject.NativeMethodInfoPtr_Hovered_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsableInteractableObject>.NativeClassPtr, 100672370);
			IUsableInteractableObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsableInteractableObject>.NativeClassPtr, 100672371);
		}

		// Token: 0x06004692 RID: 18066 RVA: 0x0016B41C File Offset: 0x0016961C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165810, XrefRangeEnd = 165817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IUsableInteractableObject.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004693 RID: 18067 RVA: 0x0016B450 File Offset: 0x00169650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165817, XrefRangeEnd = 165837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsableInteractableObject.NativeMethodInfoPtr_Hovered_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004694 RID: 18068 RVA: 0x0016B48C File Offset: 0x0016968C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165332, RefRangeEnd = 165333, XrefRangeStart = 165332, XrefRangeEnd = 165333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IUsableInteractableObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IUsableInteractableObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IUsableInteractableObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004695 RID: 18069 RVA: 0x000226BA File Offset: 0x000208BA
		public IUsableInteractableObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x06004696 RID: 18070 RVA: 0x0016B4C8 File Offset: 0x001696C8
		// (set) Token: 0x06004697 RID: 18071 RVA: 0x000226C3 File Offset: 0x000208C3
		public unsafe MonoBehaviour _iUsableMonoBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUsableInteractableObject.NativeFieldInfoPtr__iUsableMonoBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUsableInteractableObject.NativeFieldInfoPtr__iUsableMonoBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x06004698 RID: 18072 RVA: 0x0016B4F8 File Offset: 0x001696F8
		// (set) Token: 0x06004699 RID: 18073 RVA: 0x000226E2 File Offset: 0x000208E2
		public unsafe string _defaultMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUsableInteractableObject.NativeFieldInfoPtr__defaultMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUsableInteractableObject.NativeFieldInfoPtr__defaultMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x0600469A RID: 18074 RVA: 0x0016B520 File Offset: 0x00169720
		// (set) Token: 0x0600469B RID: 18075 RVA: 0x00022701 File Offset: 0x00020901
		public unsafe IUsable _iUsable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUsableInteractableObject.NativeFieldInfoPtr__iUsable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IUsable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IUsableInteractableObject.NativeFieldInfoPtr__iUsable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003009 RID: 12297
		private static readonly IntPtr NativeFieldInfoPtr__iUsableMonoBehaviour;

		// Token: 0x0400300A RID: 12298
		private static readonly IntPtr NativeFieldInfoPtr__defaultMessage;

		// Token: 0x0400300B RID: 12299
		private static readonly IntPtr NativeFieldInfoPtr__iUsable;

		// Token: 0x0400300C RID: 12300
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400300D RID: 12301
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Virtual_Void_0;

		// Token: 0x0400300E RID: 12302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
