using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x020005AB RID: 1451
	public class LabOvenButton : MonoBehaviour
	{
		// Token: 0x060088D5 RID: 35029 RVA: 0x00254854 File Offset: 0x00252A54
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenButton()
		{
			Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "LabOvenButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr);
			LabOvenButton.NativeFieldInfoPtr_ANIMATION_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "ANIMATION_TIME");
			LabOvenButton.NativeFieldInfoPtr__Pressed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "<Pressed>k__BackingField");
			LabOvenButton.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "Button");
			LabOvenButton.NativeFieldInfoPtr_PressedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "PressedTransform");
			LabOvenButton.NativeFieldInfoPtr_DepressedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "DepressedTransform");
			LabOvenButton.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "Light");
			LabOvenButton.NativeFieldInfoPtr_Clickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "Clickable");
			LabOvenButton.NativeFieldInfoPtr_animationTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "animationTimer");
			LabOvenButton.NativeFieldInfoPtr_animationStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "animationStartPos");
			LabOvenButton.NativeFieldInfoPtr_animationEndPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, "animationEndPos");
			LabOvenButton.NativeMethodInfoPtr_get_Pressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100680950);
			LabOvenButton.NativeMethodInfoPtr_set_Pressed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100680951);
			LabOvenButton.NativeMethodInfoPtr_get_IsInteractable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100680952);
			LabOvenButton.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100680953);
			LabOvenButton.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100680954);
			LabOvenButton.NativeMethodInfoPtr_Press_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100680955);
			LabOvenButton.NativeMethodInfoPtr_SetPressed_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100680956);
			LabOvenButton.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100680957);
			LabOvenButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr, 100680958);
		}

		// Token: 0x17002A69 RID: 10857
		// (get) Token: 0x060088D6 RID: 35030 RVA: 0x00254A00 File Offset: 0x00252C00
		// (set) Token: 0x060088D7 RID: 35031 RVA: 0x00254A3C File Offset: 0x00252C3C
		public unsafe bool Pressed
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_get_Pressed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_set_Pressed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002A6A RID: 10858
		// (get) Token: 0x060088D8 RID: 35032 RVA: 0x00254A7C File Offset: 0x00252C7C
		public unsafe bool IsInteractable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 255351, RefRangeEnd = 255352, XrefRangeStart = 255351, XrefRangeEnd = 255351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_get_IsInteractable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060088D9 RID: 35033 RVA: 0x00254AB8 File Offset: 0x00252CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255352, XrefRangeEnd = 255363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088DA RID: 35034 RVA: 0x00254AEC File Offset: 0x00252CEC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 255363, RefRangeEnd = 255368, XrefRangeStart = 255363, XrefRangeEnd = 255363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool interactable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref interactable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088DB RID: 35035 RVA: 0x00254B2C File Offset: 0x00252D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255368, XrefRangeEnd = 255371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Press(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_Press_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088DC RID: 35036 RVA: 0x00254B6C File Offset: 0x00252D6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255375, RefRangeEnd = 255376, XrefRangeStart = 255371, XrefRangeEnd = 255375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPressed(bool pressed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pressed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_SetPressed_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088DD RID: 35037 RVA: 0x00254BAC File Offset: 0x00252DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255376, XrefRangeEnd = 255379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088DE RID: 35038 RVA: 0x00254BE0 File Offset: 0x00252DE0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenButton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060088DF RID: 35039 RVA: 0x00040D8A File Offset: 0x0003EF8A
		public LabOvenButton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A5F RID: 10847
		// (get) Token: 0x060088E0 RID: 35040 RVA: 0x00254C1C File Offset: 0x00252E1C
		// (set) Token: 0x060088E1 RID: 35041 RVA: 0x00040D93 File Offset: 0x0003EF93
		public unsafe static float ANIMATION_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LabOvenButton.NativeFieldInfoPtr_ANIMATION_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LabOvenButton.NativeFieldInfoPtr_ANIMATION_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002A60 RID: 10848
		// (get) Token: 0x060088E2 RID: 35042 RVA: 0x00254C38 File Offset: 0x00252E38
		// (set) Token: 0x060088E3 RID: 35043 RVA: 0x00040DA1 File Offset: 0x0003EFA1
		public unsafe bool _Pressed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr__Pressed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr__Pressed_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A61 RID: 10849
		// (get) Token: 0x060088E4 RID: 35044 RVA: 0x00254C60 File Offset: 0x00252E60
		// (set) Token: 0x060088E5 RID: 35045 RVA: 0x00040DBC File Offset: 0x0003EFBC
		public unsafe Transform Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A62 RID: 10850
		// (get) Token: 0x060088E6 RID: 35046 RVA: 0x00254C90 File Offset: 0x00252E90
		// (set) Token: 0x060088E7 RID: 35047 RVA: 0x00040DDB File Offset: 0x0003EFDB
		public unsafe Transform PressedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_PressedTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_PressedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A63 RID: 10851
		// (get) Token: 0x060088E8 RID: 35048 RVA: 0x00254CC0 File Offset: 0x00252EC0
		// (set) Token: 0x060088E9 RID: 35049 RVA: 0x00040DFA File Offset: 0x0003EFFA
		public unsafe Transform DepressedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_DepressedTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_DepressedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A64 RID: 10852
		// (get) Token: 0x060088EA RID: 35050 RVA: 0x00254CF0 File Offset: 0x00252EF0
		// (set) Token: 0x060088EB RID: 35051 RVA: 0x00040E19 File Offset: 0x0003F019
		public unsafe ToggleableLight Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A65 RID: 10853
		// (get) Token: 0x060088EC RID: 35052 RVA: 0x00254D20 File Offset: 0x00252F20
		// (set) Token: 0x060088ED RID: 35053 RVA: 0x00040E38 File Offset: 0x0003F038
		public unsafe Clickable Clickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Clickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_Clickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A66 RID: 10854
		// (get) Token: 0x060088EE RID: 35054 RVA: 0x00254D50 File Offset: 0x00252F50
		// (set) Token: 0x060088EF RID: 35055 RVA: 0x00040E57 File Offset: 0x0003F057
		public unsafe float animationTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_animationTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_animationTimer)) = value;
			}
		}

		// Token: 0x17002A67 RID: 10855
		// (get) Token: 0x060088F0 RID: 35056 RVA: 0x00254D78 File Offset: 0x00252F78
		// (set) Token: 0x060088F1 RID: 35057 RVA: 0x00040E72 File Offset: 0x0003F072
		public unsafe Vector3 animationStartPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_animationStartPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_animationStartPos)) = value;
			}
		}

		// Token: 0x17002A68 RID: 10856
		// (get) Token: 0x060088F2 RID: 35058 RVA: 0x00254DA0 File Offset: 0x00252FA0
		// (set) Token: 0x060088F3 RID: 35059 RVA: 0x00040E8D File Offset: 0x0003F08D
		public unsafe Vector3 animationEndPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_animationEndPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenButton.NativeFieldInfoPtr_animationEndPos)) = value;
			}
		}

		// Token: 0x04005DA6 RID: 23974
		private static readonly IntPtr NativeFieldInfoPtr_ANIMATION_TIME;

		// Token: 0x04005DA7 RID: 23975
		private static readonly IntPtr NativeFieldInfoPtr__Pressed_k__BackingField;

		// Token: 0x04005DA8 RID: 23976
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x04005DA9 RID: 23977
		private static readonly IntPtr NativeFieldInfoPtr_PressedTransform;

		// Token: 0x04005DAA RID: 23978
		private static readonly IntPtr NativeFieldInfoPtr_DepressedTransform;

		// Token: 0x04005DAB RID: 23979
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04005DAC RID: 23980
		private static readonly IntPtr NativeFieldInfoPtr_Clickable;

		// Token: 0x04005DAD RID: 23981
		private static readonly IntPtr NativeFieldInfoPtr_animationTimer;

		// Token: 0x04005DAE RID: 23982
		private static readonly IntPtr NativeFieldInfoPtr_animationStartPos;

		// Token: 0x04005DAF RID: 23983
		private static readonly IntPtr NativeFieldInfoPtr_animationEndPos;

		// Token: 0x04005DB0 RID: 23984
		private static readonly IntPtr NativeMethodInfoPtr_get_Pressed_Public_get_Boolean_0;

		// Token: 0x04005DB1 RID: 23985
		private static readonly IntPtr NativeMethodInfoPtr_set_Pressed_Private_set_Void_Boolean_0;

		// Token: 0x04005DB2 RID: 23986
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInteractable_Public_get_Boolean_0;

		// Token: 0x04005DB3 RID: 23987
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005DB4 RID: 23988
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x04005DB5 RID: 23989
		private static readonly IntPtr NativeMethodInfoPtr_Press_Public_Void_RaycastHit_0;

		// Token: 0x04005DB6 RID: 23990
		private static readonly IntPtr NativeMethodInfoPtr_SetPressed_Public_Void_Boolean_0;

		// Token: 0x04005DB7 RID: 23991
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005DB8 RID: 23992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
