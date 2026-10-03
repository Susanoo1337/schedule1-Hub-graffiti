using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200017B RID: 379
	public class Sprayable : Draggable
	{
		// Token: 0x06002662 RID: 9826 RVA: 0x000FA05C File Offset: 0x000F825C
		// Note: this type is marked as 'beforefieldinit'.
		static Sprayable()
		{
			Il2CppClassPointerStore<Sprayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "Sprayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sprayable>.NativeClassPtr);
			Sprayable.NativeFieldInfoPtr__sprayOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprayable>.NativeClassPtr, "_sprayOrigin");
			Sprayable.NativeFieldInfoPtr__drawGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprayable>.NativeClassPtr, "_drawGizmos");
			Sprayable.NativeFieldInfoPtr__onSuccessfulSpray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprayable>.NativeClassPtr, "_onSuccessfulSpray");
			Sprayable.NativeFieldInfoPtr_onSpray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprayable>.NativeClassPtr, "onSpray");
			Sprayable.NativeFieldInfoPtr__sprayRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprayable>.NativeClassPtr, "_sprayRadius");
			Sprayable.NativeFieldInfoPtr__sprayDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprayable>.NativeClassPtr, "_sprayDistance");
			Sprayable.NativeFieldInfoPtr__currentTargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprayable>.NativeClassPtr, "_currentTargetPosition");
			Sprayable.NativeMethodInfoPtr_Initialise_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprayable>.NativeClassPtr, 100668235);
			Sprayable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprayable>.NativeClassPtr, 100668236);
			Sprayable.NativeMethodInfoPtr_Spray_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprayable>.NativeClassPtr, 100668237);
			Sprayable.NativeMethodInfoPtr_SetCurrentTarget_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprayable>.NativeClassPtr, 100668238);
			Sprayable.NativeMethodInfoPtr_DoesHitTarget_Private_Boolean_Vector3_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprayable>.NativeClassPtr, 100668239);
			Sprayable.NativeMethodInfoPtr_SubscribeToSuccessfulSpray_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprayable>.NativeClassPtr, 100668240);
			Sprayable.NativeMethodInfoPtr_UnsubscribeFromSuccessfulSpray_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprayable>.NativeClassPtr, 100668241);
			Sprayable.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprayable>.NativeClassPtr, 100668242);
			Sprayable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprayable>.NativeClassPtr, 100668243);
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x000FA1CC File Offset: 0x000F83CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117591, RefRangeEnd = 117592, XrefRangeStart = 117591, XrefRangeEnd = 117591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialise(float sprayRadius, float sprayDistance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sprayRadius;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sprayDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprayable.NativeMethodInfoPtr_Initialise_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x000FA218 File Offset: 0x000F8418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117592, XrefRangeEnd = 117600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sprayable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x000FA254 File Offset: 0x000F8454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117604, RefRangeEnd = 117605, XrefRangeStart = 117600, XrefRangeEnd = 117604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Spray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprayable.NativeMethodInfoPtr_Spray_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x000FA288 File Offset: 0x000F8488
		[CallerCount(0)]
		public unsafe void SetCurrentTarget(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprayable.NativeMethodInfoPtr_SetCurrentTarget_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x000FA2C8 File Offset: 0x000F84C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117605, XrefRangeEnd = 117607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesHitTarget(Vector3 rayOrigin, Vector3 rayDirection, Vector3 sphereCenter, float sphereRadius, float maxDistance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rayOrigin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rayDirection;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sphereCenter;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sphereRadius;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprayable.NativeMethodInfoPtr_DoesHitTarget_Private_Boolean_Vector3_Vector3_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x000FA34C File Offset: 0x000F854C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117615, RefRangeEnd = 117616, XrefRangeStart = 117607, XrefRangeEnd = 117615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubscribeToSuccessfulSpray(Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprayable.NativeMethodInfoPtr_SubscribeToSuccessfulSpray_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x000FA390 File Offset: 0x000F8590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117624, RefRangeEnd = 117625, XrefRangeStart = 117616, XrefRangeEnd = 117624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsubscribeFromSuccessfulSpray(Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprayable.NativeMethodInfoPtr_UnsubscribeFromSuccessfulSpray_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x000FA3D4 File Offset: 0x000F85D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117625, XrefRangeEnd = 117627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprayable.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x000FA408 File Offset: 0x000F8608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117627, XrefRangeEnd = 117628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprayable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sprayable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprayable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x000143EC File Offset: 0x000125EC
		public Sprayable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x0600266D RID: 9837 RVA: 0x000FA444 File Offset: 0x000F8644
		// (set) Token: 0x0600266E RID: 9838 RVA: 0x000143F5 File Offset: 0x000125F5
		public unsafe Transform _sprayOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprayable.NativeFieldInfoPtr__sprayOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprayable.NativeFieldInfoPtr__sprayOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x0600266F RID: 9839 RVA: 0x000FA474 File Offset: 0x000F8674
		// (set) Token: 0x06002670 RID: 9840 RVA: 0x00014414 File Offset: 0x00012614
		public unsafe bool _drawGizmos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprayable.NativeFieldInfoPtr__drawGizmos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprayable.NativeFieldInfoPtr__drawGizmos)) = value;
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x06002671 RID: 9841 RVA: 0x000FA49C File Offset: 0x000F869C
		// (set) Token: 0x06002672 RID: 9842 RVA: 0x0001442F File Offset: 0x0001262F
		public unsafe Action _onSuccessfulSpray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprayable.NativeFieldInfoPtr__onSuccessfulSpray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprayable.NativeFieldInfoPtr__onSuccessfulSpray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x06002673 RID: 9843 RVA: 0x000FA4CC File Offset: 0x000F86CC
		// (set) Token: 0x06002674 RID: 9844 RVA: 0x0001444E File Offset: 0x0001264E
		public unsafe UnityEvent onSpray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprayable.NativeFieldInfoPtr_onSpray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprayable.NativeFieldInfoPtr_onSpray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06002675 RID: 9845 RVA: 0x000FA4FC File Offset: 0x000F86FC
		// (set) Token: 0x06002676 RID: 9846 RVA: 0x0001446D File Offset: 0x0001266D
		public unsafe float _sprayRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprayable.NativeFieldInfoPtr__sprayRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprayable.NativeFieldInfoPtr__sprayRadius)) = value;
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06002677 RID: 9847 RVA: 0x000FA524 File Offset: 0x000F8724
		// (set) Token: 0x06002678 RID: 9848 RVA: 0x00014488 File Offset: 0x00012688
		public unsafe float _sprayDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprayable.NativeFieldInfoPtr__sprayDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprayable.NativeFieldInfoPtr__sprayDistance)) = value;
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06002679 RID: 9849 RVA: 0x000FA54C File Offset: 0x000F874C
		// (set) Token: 0x0600267A RID: 9850 RVA: 0x000144A3 File Offset: 0x000126A3
		public unsafe Vector3 _currentTargetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprayable.NativeFieldInfoPtr__currentTargetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprayable.NativeFieldInfoPtr__currentTargetPosition)) = value;
			}
		}

		// Token: 0x04001A76 RID: 6774
		private static readonly IntPtr NativeFieldInfoPtr__sprayOrigin;

		// Token: 0x04001A77 RID: 6775
		private static readonly IntPtr NativeFieldInfoPtr__drawGizmos;

		// Token: 0x04001A78 RID: 6776
		private static readonly IntPtr NativeFieldInfoPtr__onSuccessfulSpray;

		// Token: 0x04001A79 RID: 6777
		private static readonly IntPtr NativeFieldInfoPtr_onSpray;

		// Token: 0x04001A7A RID: 6778
		private static readonly IntPtr NativeFieldInfoPtr__sprayRadius;

		// Token: 0x04001A7B RID: 6779
		private static readonly IntPtr NativeFieldInfoPtr__sprayDistance;

		// Token: 0x04001A7C RID: 6780
		private static readonly IntPtr NativeFieldInfoPtr__currentTargetPosition;

		// Token: 0x04001A7D RID: 6781
		private static readonly IntPtr NativeMethodInfoPtr_Initialise_Public_Void_Single_Single_0;

		// Token: 0x04001A7E RID: 6782
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04001A7F RID: 6783
		private static readonly IntPtr NativeMethodInfoPtr_Spray_Private_Void_0;

		// Token: 0x04001A80 RID: 6784
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentTarget_Public_Void_Vector3_0;

		// Token: 0x04001A81 RID: 6785
		private static readonly IntPtr NativeMethodInfoPtr_DoesHitTarget_Private_Boolean_Vector3_Vector3_Vector3_Single_Single_0;

		// Token: 0x04001A82 RID: 6786
		private static readonly IntPtr NativeMethodInfoPtr_SubscribeToSuccessfulSpray_Public_Void_Action_0;

		// Token: 0x04001A83 RID: 6787
		private static readonly IntPtr NativeMethodInfoPtr_UnsubscribeFromSuccessfulSpray_Public_Void_Action_0;

		// Token: 0x04001A84 RID: 6788
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04001A85 RID: 6789
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
