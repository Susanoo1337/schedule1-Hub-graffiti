using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007F1 RID: 2033
	public class WorldspaceUIElement : MonoBehaviour
	{
		// Token: 0x0600C627 RID: 50727 RVA: 0x003238B8 File Offset: 0x00321AB8
		// Note: this type is marked as 'beforefieldinit'.
		static WorldspaceUIElement()
		{
			Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "WorldspaceUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr);
			WorldspaceUIElement.NativeFieldInfoPtr_TRANSITION_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "TRANSITION_TIME");
			WorldspaceUIElement.NativeFieldInfoPtr__IsEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "<IsEnabled>k__BackingField");
			WorldspaceUIElement.NativeFieldInfoPtr_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "RectTransform");
			WorldspaceUIElement.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "Container");
			WorldspaceUIElement.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "TitleLabel");
			WorldspaceUIElement.NativeFieldInfoPtr_AssignedWorkerDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "AssignedWorkerDisplay");
			WorldspaceUIElement.NativeFieldInfoPtr_scaleRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "scaleRoutine");
			WorldspaceUIElement.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100688963);
			WorldspaceUIElement.NativeMethodInfoPtr_set_IsEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100688964);
			WorldspaceUIElement.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100688965);
			WorldspaceUIElement.NativeMethodInfoPtr_Show_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100688966);
			WorldspaceUIElement.NativeMethodInfoPtr_Hide_Public_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100688967);
			WorldspaceUIElement.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100688968);
			WorldspaceUIElement.NativeMethodInfoPtr_UpdatePosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100688969);
			WorldspaceUIElement.NativeMethodInfoPtr_SetInternalScale_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100688970);
			WorldspaceUIElement.NativeMethodInfoPtr_SetScale_Private_Void_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100688971);
			WorldspaceUIElement.NativeMethodInfoPtr_HoverStart_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100688972);
			WorldspaceUIElement.NativeMethodInfoPtr_HoverEnd_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100688973);
			WorldspaceUIElement.NativeMethodInfoPtr_SetAssignedNPC_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100688974);
			WorldspaceUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, 100688975);
		}

		// Token: 0x17003C2C RID: 15404
		// (get) Token: 0x0600C628 RID: 50728 RVA: 0x00323A78 File Offset: 0x00321C78
		// (set) Token: 0x0600C629 RID: 50729 RVA: 0x00323AB4 File Offset: 0x00321CB4
		public unsafe bool IsEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.NativeMethodInfoPtr_set_IsEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003C2D RID: 15405
		// (get) Token: 0x0600C62A RID: 50730 RVA: 0x00323AF4 File Offset: 0x00321CF4
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327497, XrefRangeEnd = 327504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600C62B RID: 50731 RVA: 0x00323B30 File Offset: 0x00321D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327504, XrefRangeEnd = 327518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Show()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldspaceUIElement.NativeMethodInfoPtr_Show_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C62C RID: 50732 RVA: 0x00323B6C File Offset: 0x00321D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327518, XrefRangeEnd = 327538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hide(Action callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldspaceUIElement.NativeMethodInfoPtr_Hide_Public_Virtual_New_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C62D RID: 50733 RVA: 0x00323BBC File Offset: 0x00321DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327538, XrefRangeEnd = 327543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldspaceUIElement.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C62E RID: 50734 RVA: 0x00323BF8 File Offset: 0x00321DF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327557, RefRangeEnd = 327558, XrefRangeStart = 327543, XrefRangeEnd = 327557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePosition(Vector3 worldSpacePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldSpacePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.NativeMethodInfoPtr_UpdatePosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C62F RID: 50735 RVA: 0x00323C38 File Offset: 0x00321E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327558, XrefRangeEnd = 327566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetInternalScale(float scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldspaceUIElement.NativeMethodInfoPtr_SetInternalScale_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C630 RID: 50736 RVA: 0x00323C84 File Offset: 0x00321E84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 327595, RefRangeEnd = 327597, XrefRangeStart = 327566, XrefRangeEnd = 327595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScale(float scale, Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scale;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.NativeMethodInfoPtr_SetScale_Private_Void_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C631 RID: 50737 RVA: 0x00323CD4 File Offset: 0x00321ED4
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HoverStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldspaceUIElement.NativeMethodInfoPtr_HoverStart_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C632 RID: 50738 RVA: 0x00323D10 File Offset: 0x00321F10
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HoverEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldspaceUIElement.NativeMethodInfoPtr_HoverEnd_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C633 RID: 50739 RVA: 0x00323D4C File Offset: 0x00321F4C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 327605, RefRangeEnd = 327615, XrefRangeStart = 327597, XrefRangeEnd = 327605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAssignedNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.NativeMethodInfoPtr_SetAssignedNPC_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C634 RID: 50740 RVA: 0x00323D90 File Offset: 0x00321F90
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspaceUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C635 RID: 50741 RVA: 0x0005D895 File Offset: 0x0005BA95
		public WorldspaceUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C25 RID: 15397
		// (get) Token: 0x0600C636 RID: 50742 RVA: 0x00323DCC File Offset: 0x00321FCC
		// (set) Token: 0x0600C637 RID: 50743 RVA: 0x0005D89E File Offset: 0x0005BA9E
		public unsafe static float TRANSITION_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WorldspaceUIElement.NativeFieldInfoPtr_TRANSITION_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorldspaceUIElement.NativeFieldInfoPtr_TRANSITION_TIME, (void*)(&value));
			}
		}

		// Token: 0x17003C26 RID: 15398
		// (get) Token: 0x0600C638 RID: 50744 RVA: 0x00323DE8 File Offset: 0x00321FE8
		// (set) Token: 0x0600C639 RID: 50745 RVA: 0x0005D8AC File Offset: 0x0005BAAC
		public unsafe bool _IsEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr__IsEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr__IsEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17003C27 RID: 15399
		// (get) Token: 0x0600C63A RID: 50746 RVA: 0x00323E10 File Offset: 0x00322010
		// (set) Token: 0x0600C63B RID: 50747 RVA: 0x0005D8C7 File Offset: 0x0005BAC7
		public unsafe RectTransform RectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_RectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C28 RID: 15400
		// (get) Token: 0x0600C63C RID: 50748 RVA: 0x00323E40 File Offset: 0x00322040
		// (set) Token: 0x0600C63D RID: 50749 RVA: 0x0005D8E6 File Offset: 0x0005BAE6
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C29 RID: 15401
		// (get) Token: 0x0600C63E RID: 50750 RVA: 0x00323E70 File Offset: 0x00322070
		// (set) Token: 0x0600C63F RID: 50751 RVA: 0x0005D905 File Offset: 0x0005BB05
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C2A RID: 15402
		// (get) Token: 0x0600C640 RID: 50752 RVA: 0x00323EA0 File Offset: 0x003220A0
		// (set) Token: 0x0600C641 RID: 50753 RVA: 0x0005D924 File Offset: 0x0005BB24
		public unsafe AssignedWorkerDisplay AssignedWorkerDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_AssignedWorkerDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssignedWorkerDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_AssignedWorkerDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C2B RID: 15403
		// (get) Token: 0x0600C642 RID: 50754 RVA: 0x00323ED0 File Offset: 0x003220D0
		// (set) Token: 0x0600C643 RID: 50755 RVA: 0x0005D943 File Offset: 0x0005BB43
		public unsafe Coroutine scaleRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_scaleRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.NativeFieldInfoPtr_scaleRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400872F RID: 34607
		private static readonly IntPtr NativeFieldInfoPtr_TRANSITION_TIME;

		// Token: 0x04008730 RID: 34608
		private static readonly IntPtr NativeFieldInfoPtr__IsEnabled_k__BackingField;

		// Token: 0x04008731 RID: 34609
		private static readonly IntPtr NativeFieldInfoPtr_RectTransform;

		// Token: 0x04008732 RID: 34610
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04008733 RID: 34611
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x04008734 RID: 34612
		private static readonly IntPtr NativeFieldInfoPtr_AssignedWorkerDisplay;

		// Token: 0x04008735 RID: 34613
		private static readonly IntPtr NativeFieldInfoPtr_scaleRoutine;

		// Token: 0x04008736 RID: 34614
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0;

		// Token: 0x04008737 RID: 34615
		private static readonly IntPtr NativeMethodInfoPtr_set_IsEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04008738 RID: 34616
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x04008739 RID: 34617
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Virtual_New_Void_0;

		// Token: 0x0400873A RID: 34618
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Virtual_New_Void_Action_0;

		// Token: 0x0400873B RID: 34619
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0;

		// Token: 0x0400873C RID: 34620
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePosition_Public_Void_Vector3_0;

		// Token: 0x0400873D RID: 34621
		private static readonly IntPtr NativeMethodInfoPtr_SetInternalScale_Public_Virtual_New_Void_Single_0;

		// Token: 0x0400873E RID: 34622
		private static readonly IntPtr NativeMethodInfoPtr_SetScale_Private_Void_Single_Action_0;

		// Token: 0x0400873F RID: 34623
		private static readonly IntPtr NativeMethodInfoPtr_HoverStart_Public_Virtual_New_Void_0;

		// Token: 0x04008740 RID: 34624
		private static readonly IntPtr NativeMethodInfoPtr_HoverEnd_Public_Virtual_New_Void_0;

		// Token: 0x04008741 RID: 34625
		private static readonly IntPtr NativeMethodInfoPtr_SetAssignedNPC_Public_Void_NPC_0;

		// Token: 0x04008742 RID: 34626
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D65 RID: 3429
		[ObfuscatedName("ScheduleOne.UI.Management.WorldspaceUIElement+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FAF0 RID: 64240 RVA: 0x003BF138 File Offset: 0x003BD338
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr);
				WorldspaceUIElement.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				WorldspaceUIElement.__c__DisplayClass13_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr, "callback");
				WorldspaceUIElement.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr, 100688976);
				WorldspaceUIElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Hide_b__0_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr, 100688977);
				WorldspaceUIElement.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr, 100688978);
			}

			// Token: 0x0600FAF1 RID: 64241 RVA: 0x003BF1C8 File Offset: 0x003BD3C8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FAF2 RID: 64242 RVA: 0x003BF204 File Offset: 0x003BD404
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327472, XrefRangeEnd = 327474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Hide_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass13_0.NativeMethodInfoPtr__Hide_b__0_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FAF3 RID: 64243 RVA: 0x003BF238 File Offset: 0x003BD438
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FAF4 RID: 64244 RVA: 0x00076B3B File Offset: 0x00074D3B
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C3E RID: 19518
			// (get) Token: 0x0600FAF5 RID: 64245 RVA: 0x003BF26C File Offset: 0x003BD46C
			// (set) Token: 0x0600FAF6 RID: 64246 RVA: 0x00076B44 File Offset: 0x00074D44
			public unsafe WorldspaceUIElement __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C3F RID: 19519
			// (get) Token: 0x0600FAF7 RID: 64247 RVA: 0x003BF29C File Offset: 0x003BD49C
			// (set) Token: 0x0600FAF8 RID: 64248 RVA: 0x00076B63 File Offset: 0x00074D63
			public unsafe Action callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass13_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass13_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A954 RID: 43348
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A955 RID: 43349
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x0400A956 RID: 43350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A957 RID: 43351
			private static readonly IntPtr NativeMethodInfoPtr__Hide_b__0_Internal_Void_1;

			// Token: 0x0400A958 RID: 43352
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;
		}

		// Token: 0x02000D66 RID: 3430
		[ObfuscatedName("ScheduleOne.UI.Management.WorldspaceUIElement+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FAF9 RID: 64249 RVA: 0x003BF2CC File Offset: 0x003BD4CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldspaceUIElement>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr);
				WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_startScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, "startScale");
				WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, "scale");
				WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, "duration");
				WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, "callback");
				WorldspaceUIElement.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, 100688979);
				WorldspaceUIElement.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, 100688980);
			}

			// Token: 0x0600FAFA RID: 64250 RVA: 0x003BF384 File Offset: 0x003BD584
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FAFB RID: 64251 RVA: 0x003BF3C0 File Offset: 0x003BD5C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327492, XrefRangeEnd = 327497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600FAFC RID: 64252 RVA: 0x00076B82 File Offset: 0x00074D82
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C40 RID: 19520
			// (get) Token: 0x0600FAFD RID: 64253 RVA: 0x003BF400 File Offset: 0x003BD600
			// (set) Token: 0x0600FAFE RID: 64254 RVA: 0x00076B8B File Offset: 0x00074D8B
			public unsafe WorldspaceUIElement __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C41 RID: 19521
			// (get) Token: 0x0600FAFF RID: 64255 RVA: 0x003BF430 File Offset: 0x003BD630
			// (set) Token: 0x0600FB00 RID: 64256 RVA: 0x00076BAA File Offset: 0x00074DAA
			public unsafe float startScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_startScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_startScale)) = value;
				}
			}

			// Token: 0x17004C42 RID: 19522
			// (get) Token: 0x0600FB01 RID: 64257 RVA: 0x003BF458 File Offset: 0x003BD658
			// (set) Token: 0x0600FB02 RID: 64258 RVA: 0x00076BC5 File Offset: 0x00074DC5
			public unsafe float scale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_scale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_scale)) = value;
				}
			}

			// Token: 0x17004C43 RID: 19523
			// (get) Token: 0x0600FB03 RID: 64259 RVA: 0x003BF480 File Offset: 0x003BD680
			// (set) Token: 0x0600FB04 RID: 64260 RVA: 0x00076BE0 File Offset: 0x00074DE0
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x17004C44 RID: 19524
			// (get) Token: 0x0600FB05 RID: 64261 RVA: 0x003BF4A8 File Offset: 0x003BD6A8
			// (set) Token: 0x0600FB06 RID: 64262 RVA: 0x00076BFB File Offset: 0x00074DFB
			public unsafe Action callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A959 RID: 43353
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A95A RID: 43354
			private static readonly IntPtr NativeFieldInfoPtr_startScale;

			// Token: 0x0400A95B RID: 43355
			private static readonly IntPtr NativeFieldInfoPtr_scale;

			// Token: 0x0400A95C RID: 43356
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x0400A95D RID: 43357
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x0400A95E RID: 43358
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A95F RID: 43359
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000E19 RID: 3609
			[ObfuscatedName("ScheduleOne.UI.Management.WorldspaceUIElement+<>c__DisplayClass17_0+<<SetScale>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601041D RID: 66589 RVA: 0x003D9D00 File Offset: 0x003D7F00
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0>.NativeClassPtr, "<<SetScale>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100688981);
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100688982);
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100688983);
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100688984);
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100688985);
					WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100688986);
				}

				// Token: 0x0601041E RID: 66590 RVA: 0x003D9DF4 File Offset: 0x003D7FF4
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601041F RID: 66591 RVA: 0x003D9E3C File Offset: 0x003D803C
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06010420 RID: 66592 RVA: 0x003D9E70 File Offset: 0x003D8070
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327474, XrefRangeEnd = 327487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004F8F RID: 20367
				// (get) Token: 0x06010421 RID: 66593 RVA: 0x003D9EAC File Offset: 0x003D80AC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010422 RID: 66594 RVA: 0x003D9EEC File Offset: 0x003D80EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327487, XrefRangeEnd = 327492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004F90 RID: 20368
				// (get) Token: 0x06010423 RID: 66595 RVA: 0x003D9F20 File Offset: 0x003D8120
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010424 RID: 66596 RVA: 0x0007B6DF File Offset: 0x000798DF
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004F8B RID: 20363
				// (get) Token: 0x06010425 RID: 66597 RVA: 0x003D9F60 File Offset: 0x003D8160
				// (set) Token: 0x06010426 RID: 66598 RVA: 0x0007B6E8 File Offset: 0x000798E8
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004F8C RID: 20364
				// (get) Token: 0x06010427 RID: 66599 RVA: 0x003D9F88 File Offset: 0x003D8188
				// (set) Token: 0x06010428 RID: 66600 RVA: 0x0007B703 File Offset: 0x00079903
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F8D RID: 20365
				// (get) Token: 0x06010429 RID: 66601 RVA: 0x003D9FB8 File Offset: 0x003D81B8
				// (set) Token: 0x0601042A RID: 66602 RVA: 0x0007B722 File Offset: 0x00079922
				public unsafe WorldspaceUIElement.__c__DisplayClass17_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement.__c__DisplayClass17_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F8E RID: 20366
				// (get) Token: 0x0601042B RID: 66603 RVA: 0x003D9FE8 File Offset: 0x003D81E8
				// (set) Token: 0x0601042C RID: 66604 RVA: 0x0007B741 File Offset: 0x00079941
				public unsafe float _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceUIElement.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x0400AEFE RID: 44798
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AEFF RID: 44799
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AF00 RID: 44800
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AF01 RID: 44801
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x0400AF02 RID: 44802
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AF03 RID: 44803
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AF04 RID: 44804
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AF05 RID: 44805
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AF06 RID: 44806
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AF07 RID: 44807
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
