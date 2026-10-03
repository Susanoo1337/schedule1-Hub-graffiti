using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004F2 RID: 1266
	public class PhysicsEvents : MonoBehaviour
	{
		// Token: 0x060072B7 RID: 29367 RVA: 0x00204510 File Offset: 0x00202710
		// Note: this type is marked as 'beforefieldinit'.
		static PhysicsEvents()
		{
			Il2CppClassPointerStore<PhysicsEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "PhysicsEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsEvents>.NativeClassPtr);
			PhysicsEvents.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsEvents>.NativeClassPtr, "DEBUG");
			PhysicsEvents.NativeFieldInfoPtr_OnTriggerEnterEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsEvents>.NativeClassPtr, "OnTriggerEnterEvent");
			PhysicsEvents.NativeFieldInfoPtr_OnTriggerExitEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsEvents>.NativeClassPtr, "OnTriggerExitEvent");
			PhysicsEvents.NativeFieldInfoPtr_OnCollisionEnterEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsEvents>.NativeClassPtr, "OnCollisionEnterEvent");
			PhysicsEvents.NativeFieldInfoPtr_OnCollisionExitEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsEvents>.NativeClassPtr, "OnCollisionExitEvent");
			PhysicsEvents.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsEvents>.NativeClassPtr, 100678138);
			PhysicsEvents.NativeMethodInfoPtr_OnTriggerExit_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsEvents>.NativeClassPtr, 100678139);
			PhysicsEvents.NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsEvents>.NativeClassPtr, 100678140);
			PhysicsEvents.NativeMethodInfoPtr_OnCollisionExit_Public_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsEvents>.NativeClassPtr, 100678141);
			PhysicsEvents.NativeMethodInfoPtr_GetHierarchyString_Private_Static_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsEvents>.NativeClassPtr, 100678142);
			PhysicsEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsEvents>.NativeClassPtr, 100678143);
		}

		// Token: 0x060072B8 RID: 29368 RVA: 0x0020461C File Offset: 0x0020281C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226722, XrefRangeEnd = 226738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsEvents.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072B9 RID: 29369 RVA: 0x00204660 File Offset: 0x00202860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226738, XrefRangeEnd = 226754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerExit(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsEvents.NativeMethodInfoPtr_OnTriggerExit_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072BA RID: 29370 RVA: 0x002046A4 File Offset: 0x002028A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226754, XrefRangeEnd = 226771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsEvents.NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072BB RID: 29371 RVA: 0x002046E8 File Offset: 0x002028E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226771, XrefRangeEnd = 226788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionExit(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsEvents.NativeMethodInfoPtr_OnCollisionExit_Public_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072BC RID: 29372 RVA: 0x0020472C File Offset: 0x0020292C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 226813, RefRangeEnd = 226817, XrefRangeStart = 226788, XrefRangeEnd = 226813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetHierarchyString(Transform transform)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsEvents.NativeMethodInfoPtr_GetHierarchyString_Private_Static_String_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060072BD RID: 29373 RVA: 0x00204768 File Offset: 0x00202968
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhysicsEvents() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhysicsEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060072BE RID: 29374 RVA: 0x0003687D File Offset: 0x00034A7D
		public PhysicsEvents(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002360 RID: 9056
		// (get) Token: 0x060072BF RID: 29375 RVA: 0x002047A4 File Offset: 0x002029A4
		// (set) Token: 0x060072C0 RID: 29376 RVA: 0x00036886 File Offset: 0x00034A86
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsEvents.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsEvents.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x17002361 RID: 9057
		// (get) Token: 0x060072C1 RID: 29377 RVA: 0x002047CC File Offset: 0x002029CC
		// (set) Token: 0x060072C2 RID: 29378 RVA: 0x000368A1 File Offset: 0x00034AA1
		public unsafe UnityEvent<Collider> OnTriggerEnterEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsEvents.NativeFieldInfoPtr_OnTriggerEnterEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsEvents.NativeFieldInfoPtr_OnTriggerEnterEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002362 RID: 9058
		// (get) Token: 0x060072C3 RID: 29379 RVA: 0x002047FC File Offset: 0x002029FC
		// (set) Token: 0x060072C4 RID: 29380 RVA: 0x000368C0 File Offset: 0x00034AC0
		public unsafe UnityEvent<Collider> OnTriggerExitEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsEvents.NativeFieldInfoPtr_OnTriggerExitEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsEvents.NativeFieldInfoPtr_OnTriggerExitEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002363 RID: 9059
		// (get) Token: 0x060072C5 RID: 29381 RVA: 0x0020482C File Offset: 0x00202A2C
		// (set) Token: 0x060072C6 RID: 29382 RVA: 0x000368DF File Offset: 0x00034ADF
		public unsafe UnityEvent<Collision> OnCollisionEnterEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsEvents.NativeFieldInfoPtr_OnCollisionEnterEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Collision>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsEvents.NativeFieldInfoPtr_OnCollisionEnterEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002364 RID: 9060
		// (get) Token: 0x060072C7 RID: 29383 RVA: 0x0020485C File Offset: 0x00202A5C
		// (set) Token: 0x060072C8 RID: 29384 RVA: 0x000368FE File Offset: 0x00034AFE
		public unsafe UnityEvent<Collision> OnCollisionExitEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsEvents.NativeFieldInfoPtr_OnCollisionExitEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Collision>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsEvents.NativeFieldInfoPtr_OnCollisionExitEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E58 RID: 20056
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04004E59 RID: 20057
		private static readonly IntPtr NativeFieldInfoPtr_OnTriggerEnterEvent;

		// Token: 0x04004E5A RID: 20058
		private static readonly IntPtr NativeFieldInfoPtr_OnTriggerExitEvent;

		// Token: 0x04004E5B RID: 20059
		private static readonly IntPtr NativeFieldInfoPtr_OnCollisionEnterEvent;

		// Token: 0x04004E5C RID: 20060
		private static readonly IntPtr NativeFieldInfoPtr_OnCollisionExitEvent;

		// Token: 0x04004E5D RID: 20061
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0;

		// Token: 0x04004E5E RID: 20062
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit_Public_Void_Collider_0;

		// Token: 0x04004E5F RID: 20063
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0;

		// Token: 0x04004E60 RID: 20064
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionExit_Public_Void_Collision_0;

		// Token: 0x04004E61 RID: 20065
		private static readonly IntPtr NativeMethodInfoPtr_GetHierarchyString_Private_Static_String_Transform_0;

		// Token: 0x04004E62 RID: 20066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BA1 RID: 2977
		[ObfuscatedName("ScheduleOne.Tools.PhysicsEvents+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600EA3B RID: 59963 RVA: 0x0038EAB4 File Offset: 0x0038CCB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PhysicsEvents.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhysicsEvents>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsEvents.__c>.NativeClassPtr);
				PhysicsEvents.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsEvents.__c>.NativeClassPtr, "<>9");
				PhysicsEvents.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsEvents.__c>.NativeClassPtr, "<>9__9_0");
				PhysicsEvents.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsEvents.__c>.NativeClassPtr, 100678145);
				PhysicsEvents.__c.NativeMethodInfoPtr__GetHierarchyString_b__9_0_Internal_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsEvents.__c>.NativeClassPtr, 100678146);
			}

			// Token: 0x0600EA3C RID: 59964 RVA: 0x0038EB30 File Offset: 0x0038CD30
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhysicsEvents.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsEvents.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA3D RID: 59965 RVA: 0x0038EB6C File Offset: 0x0038CD6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226720, XrefRangeEnd = 226722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetHierarchyString_b__9_0(Transform t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsEvents.__c.NativeMethodInfoPtr__GetHierarchyString_b__9_0_Internal_String_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EA3E RID: 59966 RVA: 0x0006E80B File Offset: 0x0006CA0B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700470D RID: 18189
			// (get) Token: 0x0600EA3F RID: 59967 RVA: 0x0038EBB4 File Offset: 0x0038CDB4
			// (set) Token: 0x0600EA40 RID: 59968 RVA: 0x0006E814 File Offset: 0x0006CA14
			public unsafe static PhysicsEvents.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PhysicsEvents.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicsEvents.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PhysicsEvents.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700470E RID: 18190
			// (get) Token: 0x0600EA41 RID: 59969 RVA: 0x0038EBDC File Offset: 0x0038CDDC
			// (set) Token: 0x0600EA42 RID: 59970 RVA: 0x0006E826 File Offset: 0x0006CA26
			public unsafe static Func<Transform, string> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PhysicsEvents.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Transform, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PhysicsEvents.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009EC9 RID: 40649
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009ECA RID: 40650
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04009ECB RID: 40651
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009ECC RID: 40652
			private static readonly IntPtr NativeMethodInfoPtr__GetHierarchyString_b__9_0_Internal_String_Transform_0;
		}
	}
}
