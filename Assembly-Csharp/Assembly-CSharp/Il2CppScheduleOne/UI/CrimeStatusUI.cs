using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200074D RID: 1869
	public class CrimeStatusUI : MonoBehaviour
	{
		// Token: 0x0600B63D RID: 46653 RVA: 0x002F354C File Offset: 0x002F174C
		// Note: this type is marked as 'beforefieldinit'.
		static CrimeStatusUI()
		{
			Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CrimeStatusUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr);
			CrimeStatusUI.NativeFieldInfoPtr_SmallTextSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "SmallTextSize");
			CrimeStatusUI.NativeFieldInfoPtr_LargeTextSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "LargeTextSize");
			CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "CrimeStatusContainer");
			CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "CrimeStatusGroup");
			CrimeStatusUI.NativeFieldInfoPtr_BodysearchLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "BodysearchLabel");
			CrimeStatusUI.NativeFieldInfoPtr_InvestigatingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "InvestigatingMask");
			CrimeStatusUI.NativeFieldInfoPtr_UnderArrestMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "UnderArrestMask");
			CrimeStatusUI.NativeFieldInfoPtr_WantedMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "WantedMask");
			CrimeStatusUI.NativeFieldInfoPtr_WantedDeadMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "WantedDeadMask");
			CrimeStatusUI.NativeFieldInfoPtr_ArrestProgressContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "ArrestProgressContainer");
			CrimeStatusUI.NativeFieldInfoPtr_animateText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "animateText");
			CrimeStatusUI.NativeFieldInfoPtr_routine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "routine");
			CrimeStatusUI.NativeMethodInfoPtr_UpdateStatus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, 100687141);
			CrimeStatusUI.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, 100687142);
			CrimeStatusUI.NativeMethodInfoPtr_Routine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, 100687143);
			CrimeStatusUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, 100687144);
		}

		// Token: 0x0600B63E RID: 46654 RVA: 0x002F36BC File Offset: 0x002F18BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 306474, RefRangeEnd = 306476, XrefRangeStart = 306431, XrefRangeEnd = 306474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI.NativeMethodInfoPtr_UpdateStatus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B63F RID: 46655 RVA: 0x002F36F0 File Offset: 0x002F18F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306476, XrefRangeEnd = 306484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B640 RID: 46656 RVA: 0x002F3724 File Offset: 0x002F1924
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 306489, RefRangeEnd = 306491, XrefRangeStart = 306484, XrefRangeEnd = 306489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Routine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI.NativeMethodInfoPtr_Routine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B641 RID: 46657 RVA: 0x002F3764 File Offset: 0x002F1964
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CrimeStatusUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B642 RID: 46658 RVA: 0x00054783 File Offset: 0x00052983
		public CrimeStatusUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170036FC RID: 14076
		// (get) Token: 0x0600B643 RID: 46659 RVA: 0x002F37A0 File Offset: 0x002F19A0
		// (set) Token: 0x0600B644 RID: 46660 RVA: 0x0005478C File Offset: 0x0005298C
		public unsafe static float SmallTextSize
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CrimeStatusUI.NativeFieldInfoPtr_SmallTextSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CrimeStatusUI.NativeFieldInfoPtr_SmallTextSize, (void*)(&value));
			}
		}

		// Token: 0x170036FD RID: 14077
		// (get) Token: 0x0600B645 RID: 46661 RVA: 0x002F37BC File Offset: 0x002F19BC
		// (set) Token: 0x0600B646 RID: 46662 RVA: 0x0005479A File Offset: 0x0005299A
		public unsafe static float LargeTextSize
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CrimeStatusUI.NativeFieldInfoPtr_LargeTextSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CrimeStatusUI.NativeFieldInfoPtr_LargeTextSize, (void*)(&value));
			}
		}

		// Token: 0x170036FE RID: 14078
		// (get) Token: 0x0600B647 RID: 46663 RVA: 0x002F37D8 File Offset: 0x002F19D8
		// (set) Token: 0x0600B648 RID: 46664 RVA: 0x000547A8 File Offset: 0x000529A8
		public unsafe RectTransform CrimeStatusContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170036FF RID: 14079
		// (get) Token: 0x0600B649 RID: 46665 RVA: 0x002F3808 File Offset: 0x002F1A08
		// (set) Token: 0x0600B64A RID: 46666 RVA: 0x000547C7 File Offset: 0x000529C7
		public unsafe CanvasGroup CrimeStatusGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_CrimeStatusGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003700 RID: 14080
		// (get) Token: 0x0600B64B RID: 46667 RVA: 0x002F3838 File Offset: 0x002F1A38
		// (set) Token: 0x0600B64C RID: 46668 RVA: 0x000547E6 File Offset: 0x000529E6
		public unsafe GameObject BodysearchLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_BodysearchLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_BodysearchLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003701 RID: 14081
		// (get) Token: 0x0600B64D RID: 46669 RVA: 0x002F3868 File Offset: 0x002F1A68
		// (set) Token: 0x0600B64E RID: 46670 RVA: 0x00054805 File Offset: 0x00052A05
		public unsafe Image InvestigatingMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_InvestigatingMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_InvestigatingMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003702 RID: 14082
		// (get) Token: 0x0600B64F RID: 46671 RVA: 0x002F3898 File Offset: 0x002F1A98
		// (set) Token: 0x0600B650 RID: 46672 RVA: 0x00054824 File Offset: 0x00052A24
		public unsafe Image UnderArrestMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_UnderArrestMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_UnderArrestMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003703 RID: 14083
		// (get) Token: 0x0600B651 RID: 46673 RVA: 0x002F38C8 File Offset: 0x002F1AC8
		// (set) Token: 0x0600B652 RID: 46674 RVA: 0x00054843 File Offset: 0x00052A43
		public unsafe Image WantedMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_WantedMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_WantedMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003704 RID: 14084
		// (get) Token: 0x0600B653 RID: 46675 RVA: 0x002F38F8 File Offset: 0x002F1AF8
		// (set) Token: 0x0600B654 RID: 46676 RVA: 0x00054862 File Offset: 0x00052A62
		public unsafe Image WantedDeadMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_WantedDeadMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_WantedDeadMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003705 RID: 14085
		// (get) Token: 0x0600B655 RID: 46677 RVA: 0x002F3928 File Offset: 0x002F1B28
		// (set) Token: 0x0600B656 RID: 46678 RVA: 0x00054881 File Offset: 0x00052A81
		public unsafe GameObject ArrestProgressContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_ArrestProgressContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_ArrestProgressContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003706 RID: 14086
		// (get) Token: 0x0600B657 RID: 46679 RVA: 0x002F3958 File Offset: 0x002F1B58
		// (set) Token: 0x0600B658 RID: 46680 RVA: 0x000548A0 File Offset: 0x00052AA0
		public unsafe bool animateText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_animateText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_animateText)) = value;
			}
		}

		// Token: 0x17003707 RID: 14087
		// (get) Token: 0x0600B659 RID: 46681 RVA: 0x002F3980 File Offset: 0x002F1B80
		// (set) Token: 0x0600B65A RID: 46682 RVA: 0x000548BB File Offset: 0x00052ABB
		public unsafe Coroutine routine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_routine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI.NativeFieldInfoPtr_routine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007D47 RID: 32071
		private static readonly IntPtr NativeFieldInfoPtr_SmallTextSize;

		// Token: 0x04007D48 RID: 32072
		private static readonly IntPtr NativeFieldInfoPtr_LargeTextSize;

		// Token: 0x04007D49 RID: 32073
		private static readonly IntPtr NativeFieldInfoPtr_CrimeStatusContainer;

		// Token: 0x04007D4A RID: 32074
		private static readonly IntPtr NativeFieldInfoPtr_CrimeStatusGroup;

		// Token: 0x04007D4B RID: 32075
		private static readonly IntPtr NativeFieldInfoPtr_BodysearchLabel;

		// Token: 0x04007D4C RID: 32076
		private static readonly IntPtr NativeFieldInfoPtr_InvestigatingMask;

		// Token: 0x04007D4D RID: 32077
		private static readonly IntPtr NativeFieldInfoPtr_UnderArrestMask;

		// Token: 0x04007D4E RID: 32078
		private static readonly IntPtr NativeFieldInfoPtr_WantedMask;

		// Token: 0x04007D4F RID: 32079
		private static readonly IntPtr NativeFieldInfoPtr_WantedDeadMask;

		// Token: 0x04007D50 RID: 32080
		private static readonly IntPtr NativeFieldInfoPtr_ArrestProgressContainer;

		// Token: 0x04007D51 RID: 32081
		private static readonly IntPtr NativeFieldInfoPtr_animateText;

		// Token: 0x04007D52 RID: 32082
		private static readonly IntPtr NativeFieldInfoPtr_routine;

		// Token: 0x04007D53 RID: 32083
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStatus_Public_Void_0;

		// Token: 0x04007D54 RID: 32084
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04007D55 RID: 32085
		private static readonly IntPtr NativeMethodInfoPtr_Routine_Private_IEnumerator_0;

		// Token: 0x04007D56 RID: 32086
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CE4 RID: 3300
		[ObfuscatedName("ScheduleOne.UI.CrimeStatusUI+<Routine>d__14")]
		public sealed class _Routine_d__14 : Il2CppSystem.Object
		{
			// Token: 0x0600F5F0 RID: 62960 RVA: 0x003B087C File Offset: 0x003AEA7C
			// Note: this type is marked as 'beforefieldinit'.
			static _Routine_d__14()
			{
				Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CrimeStatusUI>.NativeClassPtr, "<Routine>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr);
				CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, "<>1__state");
				CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, "<>2__current");
				CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, "<>4__this");
				CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, "<lerpTime>5__2");
				CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__t_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, "<t>5__3");
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100687145);
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100687146);
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100687147);
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100687148);
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100687149);
				CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr, 100687150);
			}

			// Token: 0x0600F5F1 RID: 62961 RVA: 0x003B0984 File Offset: 0x003AEB84
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Routine_d__14(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrimeStatusUI._Routine_d__14>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F5F2 RID: 62962 RVA: 0x003B09CC File Offset: 0x003AEBCC
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F5F3 RID: 62963 RVA: 0x003B0A00 File Offset: 0x003AEC00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306409, XrefRangeEnd = 306426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004AC4 RID: 19140
			// (get) Token: 0x0600F5F4 RID: 62964 RVA: 0x003B0A3C File Offset: 0x003AEC3C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F5F5 RID: 62965 RVA: 0x003B0A7C File Offset: 0x003AEC7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306426, XrefRangeEnd = 306431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004AC5 RID: 19141
			// (get) Token: 0x0600F5F6 RID: 62966 RVA: 0x003B0AB0 File Offset: 0x003AECB0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrimeStatusUI._Routine_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F5F7 RID: 62967 RVA: 0x0007446D File Offset: 0x0007266D
			public _Routine_d__14(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004ABF RID: 19135
			// (get) Token: 0x0600F5F8 RID: 62968 RVA: 0x003B0AF0 File Offset: 0x003AECF0
			// (set) Token: 0x0600F5F9 RID: 62969 RVA: 0x00074476 File Offset: 0x00072676
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004AC0 RID: 19136
			// (get) Token: 0x0600F5FA RID: 62970 RVA: 0x003B0B18 File Offset: 0x003AED18
			// (set) Token: 0x0600F5FB RID: 62971 RVA: 0x00074491 File Offset: 0x00072691
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AC1 RID: 19137
			// (get) Token: 0x0600F5FC RID: 62972 RVA: 0x003B0B48 File Offset: 0x003AED48
			// (set) Token: 0x0600F5FD RID: 62973 RVA: 0x000744B0 File Offset: 0x000726B0
			public unsafe CrimeStatusUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CrimeStatusUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AC2 RID: 19138
			// (get) Token: 0x0600F5FE RID: 62974 RVA: 0x003B0B78 File Offset: 0x003AED78
			// (set) Token: 0x0600F5FF RID: 62975 RVA: 0x000744CF File Offset: 0x000726CF
			public unsafe float _lerpTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__lerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__lerpTime_5__2)) = value;
				}
			}

			// Token: 0x17004AC3 RID: 19139
			// (get) Token: 0x0600F600 RID: 62976 RVA: 0x003B0BA0 File Offset: 0x003AEDA0
			// (set) Token: 0x0600F601 RID: 62977 RVA: 0x000744EA File Offset: 0x000726EA
			public unsafe float _t_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__t_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrimeStatusUI._Routine_d__14.NativeFieldInfoPtr__t_5__3)) = value;
				}
			}

			// Token: 0x0400A66A RID: 42602
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A66B RID: 42603
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A66C RID: 42604
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A66D RID: 42605
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__2;

			// Token: 0x0400A66E RID: 42606
			private static readonly IntPtr NativeFieldInfoPtr__t_5__3;

			// Token: 0x0400A66F RID: 42607
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A670 RID: 42608
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A671 RID: 42609
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A672 RID: 42610
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A673 RID: 42611
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A674 RID: 42612
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
