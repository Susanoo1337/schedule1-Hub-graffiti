using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.State;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000773 RID: 1907
	public class WorldspaceDialogueRenderer : MonoBehaviour
	{
		// Token: 0x0600B97F RID: 47487 RVA: 0x002FCD3C File Offset: 0x002FAF3C
		// Note: this type is marked as 'beforefieldinit'.
		static WorldspaceDialogueRenderer()
		{
			Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "WorldspaceDialogueRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr);
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_FadeDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "FadeDist");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr__IsVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "<IsVisible>k__BackingField");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr__ShownText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "<ShownText>k__BackingField");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "MaxRange");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_BaseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "BaseScale");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Scale");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Padding");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_WorldSpaceOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "WorldSpaceOffset");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Canvas");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "CanvasGroup");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Background");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Text");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Anim");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr__localOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "_localOffset");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr__currentOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "_currentOpacity");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr__hideCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "_hideCoroutine");
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100687540);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_set_IsVisible_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100687541);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_get_ShownText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100687542);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_set_ShownText_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100687543);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100687544);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100687545);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_OnStateChange_Private_Void_IState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100687546);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100687547);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100687548);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_UpdatePosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100687549);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_ShowText_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100687550);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_HideText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100687551);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_SetOpacity_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100687552);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100687553);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100687554);
		}

		// Token: 0x1700381B RID: 14363
		// (get) Token: 0x0600B980 RID: 47488 RVA: 0x002FCFD8 File Offset: 0x002FB1D8
		// (set) Token: 0x0600B981 RID: 47489 RVA: 0x002FD014 File Offset: 0x002FB214
		public unsafe bool IsVisible
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_set_IsVisible_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700381C RID: 14364
		// (get) Token: 0x0600B982 RID: 47490 RVA: 0x002FD054 File Offset: 0x002FB254
		// (set) Token: 0x0600B983 RID: 47491 RVA: 0x002FD08C File Offset: 0x002FB28C
		public unsafe string ShownText
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_get_ShownText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_set_ShownText_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B984 RID: 47492 RVA: 0x002FD0D0 File Offset: 0x002FB2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309936, XrefRangeEnd = 309951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B985 RID: 47493 RVA: 0x002FD104 File Offset: 0x002FB304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309951, XrefRangeEnd = 309966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B986 RID: 47494 RVA: 0x002FD138 File Offset: 0x002FB338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309966, XrefRangeEnd = 309974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnStateChange(IState newState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newState);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_OnStateChange_Private_Void_IState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B987 RID: 47495 RVA: 0x002FD17C File Offset: 0x002FB37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309974, XrefRangeEnd = 310009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B988 RID: 47496 RVA: 0x002FD1B0 File Offset: 0x002FB3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310009, XrefRangeEnd = 310010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B989 RID: 47497 RVA: 0x002FD1E4 File Offset: 0x002FB3E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310043, RefRangeEnd = 310045, XrefRangeStart = 310010, XrefRangeEnd = 310043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_UpdatePosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B98A RID: 47498 RVA: 0x002FD218 File Offset: 0x002FB418
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 310086, RefRangeEnd = 310095, XrefRangeStart = 310045, XrefRangeEnd = 310086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowText(string text, float duration = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_ShowText_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B98B RID: 47499 RVA: 0x002FD268 File Offset: 0x002FB468
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310100, RefRangeEnd = 310102, XrefRangeStart = 310095, XrefRangeEnd = 310100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_HideText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B98C RID: 47500 RVA: 0x002FD29C File Offset: 0x002FB49C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310106, RefRangeEnd = 310108, XrefRangeStart = 310102, XrefRangeEnd = 310106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOpacity(float op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref op;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_SetOpacity_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B98D RID: 47501 RVA: 0x002FD2DC File Offset: 0x002FB4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310108, XrefRangeEnd = 310116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspaceDialogueRenderer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B98E RID: 47502 RVA: 0x002FD318 File Offset: 0x002FB518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310116, XrefRangeEnd = 310121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_Single_PDM_0(float dur)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dur;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B98F RID: 47503 RVA: 0x000565AC File Offset: 0x000547AC
		public WorldspaceDialogueRenderer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700380B RID: 14347
		// (get) Token: 0x0600B990 RID: 47504 RVA: 0x002FD364 File Offset: 0x002FB564
		// (set) Token: 0x0600B991 RID: 47505 RVA: 0x000565B5 File Offset: 0x000547B5
		public unsafe static float FadeDist
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WorldspaceDialogueRenderer.NativeFieldInfoPtr_FadeDist, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorldspaceDialogueRenderer.NativeFieldInfoPtr_FadeDist, (void*)(&value));
			}
		}

		// Token: 0x1700380C RID: 14348
		// (get) Token: 0x0600B992 RID: 47506 RVA: 0x002FD380 File Offset: 0x002FB580
		// (set) Token: 0x0600B993 RID: 47507 RVA: 0x000565C3 File Offset: 0x000547C3
		public unsafe bool _IsVisible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr__IsVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr__IsVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x1700380D RID: 14349
		// (get) Token: 0x0600B994 RID: 47508 RVA: 0x002FD3A8 File Offset: 0x002FB5A8
		// (set) Token: 0x0600B995 RID: 47509 RVA: 0x000565DE File Offset: 0x000547DE
		public unsafe string _ShownText_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr__ShownText_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr__ShownText_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700380E RID: 14350
		// (get) Token: 0x0600B996 RID: 47510 RVA: 0x002FD3D0 File Offset: 0x002FB5D0
		// (set) Token: 0x0600B997 RID: 47511 RVA: 0x000565FD File Offset: 0x000547FD
		public unsafe float MaxRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_MaxRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_MaxRange)) = value;
			}
		}

		// Token: 0x1700380F RID: 14351
		// (get) Token: 0x0600B998 RID: 47512 RVA: 0x002FD3F8 File Offset: 0x002FB5F8
		// (set) Token: 0x0600B999 RID: 47513 RVA: 0x00056618 File Offset: 0x00054818
		public unsafe float BaseScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_BaseScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_BaseScale)) = value;
			}
		}

		// Token: 0x17003810 RID: 14352
		// (get) Token: 0x0600B99A RID: 47514 RVA: 0x002FD420 File Offset: 0x002FB620
		// (set) Token: 0x0600B99B RID: 47515 RVA: 0x00056633 File Offset: 0x00054833
		public unsafe AnimationCurve Scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Scale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Scale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003811 RID: 14353
		// (get) Token: 0x0600B99C RID: 47516 RVA: 0x002FD450 File Offset: 0x002FB650
		// (set) Token: 0x0600B99D RID: 47517 RVA: 0x00056652 File Offset: 0x00054852
		public unsafe Vector2 Padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Padding)) = value;
			}
		}

		// Token: 0x17003812 RID: 14354
		// (get) Token: 0x0600B99E RID: 47518 RVA: 0x002FD478 File Offset: 0x002FB678
		// (set) Token: 0x0600B99F RID: 47519 RVA: 0x0005666D File Offset: 0x0005486D
		public unsafe Vector3 WorldSpaceOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_WorldSpaceOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_WorldSpaceOffset)) = value;
			}
		}

		// Token: 0x17003813 RID: 14355
		// (get) Token: 0x0600B9A0 RID: 47520 RVA: 0x002FD4A0 File Offset: 0x002FB6A0
		// (set) Token: 0x0600B9A1 RID: 47521 RVA: 0x00056688 File Offset: 0x00054888
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003814 RID: 14356
		// (get) Token: 0x0600B9A2 RID: 47522 RVA: 0x002FD4D0 File Offset: 0x002FB6D0
		// (set) Token: 0x0600B9A3 RID: 47523 RVA: 0x000566A7 File Offset: 0x000548A7
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003815 RID: 14357
		// (get) Token: 0x0600B9A4 RID: 47524 RVA: 0x002FD500 File Offset: 0x002FB700
		// (set) Token: 0x0600B9A5 RID: 47525 RVA: 0x000566C6 File Offset: 0x000548C6
		public unsafe RectTransform Background
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Background);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Background), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003816 RID: 14358
		// (get) Token: 0x0600B9A6 RID: 47526 RVA: 0x002FD530 File Offset: 0x002FB730
		// (set) Token: 0x0600B9A7 RID: 47527 RVA: 0x000566E5 File Offset: 0x000548E5
		public unsafe TextMeshProUGUI Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003817 RID: 14359
		// (get) Token: 0x0600B9A8 RID: 47528 RVA: 0x002FD560 File Offset: 0x002FB760
		// (set) Token: 0x0600B9A9 RID: 47529 RVA: 0x00056704 File Offset: 0x00054904
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003818 RID: 14360
		// (get) Token: 0x0600B9AA RID: 47530 RVA: 0x002FD590 File Offset: 0x002FB790
		// (set) Token: 0x0600B9AB RID: 47531 RVA: 0x00056723 File Offset: 0x00054923
		public unsafe Vector3 _localOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr__localOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr__localOffset)) = value;
			}
		}

		// Token: 0x17003819 RID: 14361
		// (get) Token: 0x0600B9AC RID: 47532 RVA: 0x002FD5B8 File Offset: 0x002FB7B8
		// (set) Token: 0x0600B9AD RID: 47533 RVA: 0x0005673E File Offset: 0x0005493E
		public unsafe float _currentOpacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr__currentOpacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr__currentOpacity)) = value;
			}
		}

		// Token: 0x1700381A RID: 14362
		// (get) Token: 0x0600B9AE RID: 47534 RVA: 0x002FD5E0 File Offset: 0x002FB7E0
		// (set) Token: 0x0600B9AF RID: 47535 RVA: 0x00056759 File Offset: 0x00054959
		public unsafe Coroutine _hideCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr__hideCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr__hideCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007F3F RID: 32575
		private static readonly IntPtr NativeFieldInfoPtr_FadeDist;

		// Token: 0x04007F40 RID: 32576
		private static readonly IntPtr NativeFieldInfoPtr__IsVisible_k__BackingField;

		// Token: 0x04007F41 RID: 32577
		private static readonly IntPtr NativeFieldInfoPtr__ShownText_k__BackingField;

		// Token: 0x04007F42 RID: 32578
		private static readonly IntPtr NativeFieldInfoPtr_MaxRange;

		// Token: 0x04007F43 RID: 32579
		private static readonly IntPtr NativeFieldInfoPtr_BaseScale;

		// Token: 0x04007F44 RID: 32580
		private static readonly IntPtr NativeFieldInfoPtr_Scale;

		// Token: 0x04007F45 RID: 32581
		private static readonly IntPtr NativeFieldInfoPtr_Padding;

		// Token: 0x04007F46 RID: 32582
		private static readonly IntPtr NativeFieldInfoPtr_WorldSpaceOffset;

		// Token: 0x04007F47 RID: 32583
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04007F48 RID: 32584
		private static readonly IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x04007F49 RID: 32585
		private static readonly IntPtr NativeFieldInfoPtr_Background;

		// Token: 0x04007F4A RID: 32586
		private static readonly IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x04007F4B RID: 32587
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04007F4C RID: 32588
		private static readonly IntPtr NativeFieldInfoPtr__localOffset;

		// Token: 0x04007F4D RID: 32589
		private static readonly IntPtr NativeFieldInfoPtr__currentOpacity;

		// Token: 0x04007F4E RID: 32590
		private static readonly IntPtr NativeFieldInfoPtr__hideCoroutine;

		// Token: 0x04007F4F RID: 32591
		private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x04007F50 RID: 32592
		private static readonly IntPtr NativeMethodInfoPtr_set_IsVisible_Private_set_Void_Boolean_0;

		// Token: 0x04007F51 RID: 32593
		private static readonly IntPtr NativeMethodInfoPtr_get_ShownText_Public_get_String_0;

		// Token: 0x04007F52 RID: 32594
		private static readonly IntPtr NativeMethodInfoPtr_set_ShownText_Private_set_Void_String_0;

		// Token: 0x04007F53 RID: 32595
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007F54 RID: 32596
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04007F55 RID: 32597
		private static readonly IntPtr NativeMethodInfoPtr_OnStateChange_Private_Void_IState_0;

		// Token: 0x04007F56 RID: 32598
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007F57 RID: 32599
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04007F58 RID: 32600
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePosition_Private_Void_0;

		// Token: 0x04007F59 RID: 32601
		private static readonly IntPtr NativeMethodInfoPtr_ShowText_Public_Void_String_Single_0;

		// Token: 0x04007F5A RID: 32602
		private static readonly IntPtr NativeMethodInfoPtr_HideText_Public_Void_0;

		// Token: 0x04007F5B RID: 32603
		private static readonly IntPtr NativeMethodInfoPtr_SetOpacity_Private_Void_Single_0;

		// Token: 0x04007F5C RID: 32604
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007F5D RID: 32605
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0;

		// Token: 0x02000D00 RID: 3328
		[ObfuscatedName("ScheduleOne.UI.WorldspaceDialogueRenderer+<<ShowText>g__Wait|28_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600F747 RID: 63303 RVA: 0x003B47F4 File Offset: 0x003B29F4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique()
			{
				Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "<<ShowText>g__Wait|28_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, "<>1__state");
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, "<>2__current");
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr_dur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, "dur");
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, "<>4__this");
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100687555);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100687556);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100687557);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100687558);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100687559);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100687560);
			}

			// Token: 0x0600F748 RID: 63304 RVA: 0x003B48E8 File Offset: 0x003B2AE8
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F749 RID: 63305 RVA: 0x003B4930 File Offset: 0x003B2B30
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F74A RID: 63306 RVA: 0x003B4964 File Offset: 0x003B2B64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309925, XrefRangeEnd = 309931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004B36 RID: 19254
			// (get) Token: 0x0600F74B RID: 63307 RVA: 0x003B49A0 File Offset: 0x003B2BA0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F74C RID: 63308 RVA: 0x003B49E0 File Offset: 0x003B2BE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309931, XrefRangeEnd = 309936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004B37 RID: 19255
			// (get) Token: 0x0600F74D RID: 63309 RVA: 0x003B4A14 File Offset: 0x003B2C14
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F74E RID: 63310 RVA: 0x00074EE4 File Offset: 0x000730E4
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B32 RID: 19250
			// (get) Token: 0x0600F74F RID: 63311 RVA: 0x003B4A54 File Offset: 0x003B2C54
			// (set) Token: 0x0600F750 RID: 63312 RVA: 0x00074EED File Offset: 0x000730ED
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004B33 RID: 19251
			// (get) Token: 0x0600F751 RID: 63313 RVA: 0x003B4A7C File Offset: 0x003B2C7C
			// (set) Token: 0x0600F752 RID: 63314 RVA: 0x00074F08 File Offset: 0x00073108
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B34 RID: 19252
			// (get) Token: 0x0600F753 RID: 63315 RVA: 0x003B4AAC File Offset: 0x003B2CAC
			// (set) Token: 0x0600F754 RID: 63316 RVA: 0x00074F27 File Offset: 0x00073127
			public unsafe float dur
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr_dur);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr_dur)) = value;
				}
			}

			// Token: 0x17004B35 RID: 19253
			// (get) Token: 0x0600F755 RID: 63317 RVA: 0x003B4AD4 File Offset: 0x003B2CD4
			// (set) Token: 0x0600F756 RID: 63318 RVA: 0x00074F42 File Offset: 0x00073142
			public unsafe WorldspaceDialogueRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceDialogueRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A73E RID: 42814
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A73F RID: 42815
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A740 RID: 42816
			private static readonly IntPtr NativeFieldInfoPtr_dur;

			// Token: 0x0400A741 RID: 42817
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A742 RID: 42818
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A743 RID: 42819
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A744 RID: 42820
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A745 RID: 42821
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A746 RID: 42822
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A747 RID: 42823
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
