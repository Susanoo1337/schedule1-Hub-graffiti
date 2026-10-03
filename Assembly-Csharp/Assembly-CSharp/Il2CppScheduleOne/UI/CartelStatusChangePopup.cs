using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000721 RID: 1825
	public class CartelStatusChangePopup : MonoBehaviour
	{
		// Token: 0x0600AFFB RID: 45051 RVA: 0x002E0878 File Offset: 0x002DEA78
		// Note: this type is marked as 'beforefieldinit'.
		static CartelStatusChangePopup()
		{
			Il2CppClassPointerStore<CartelStatusChangePopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CartelStatusChangePopup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelStatusChangePopup>.NativeClassPtr);
			CartelStatusChangePopup.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelStatusChangePopup>.NativeClassPtr, "Anim");
			CartelStatusChangePopup.NativeFieldInfoPtr_OldStatusLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelStatusChangePopup>.NativeClassPtr, "OldStatusLabel");
			CartelStatusChangePopup.NativeFieldInfoPtr_NewStatusLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelStatusChangePopup>.NativeClassPtr, "NewStatusLabel");
			CartelStatusChangePopup.NativeFieldInfoPtr_UnknownColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelStatusChangePopup>.NativeClassPtr, "UnknownColor");
			CartelStatusChangePopup.NativeFieldInfoPtr_TrucedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelStatusChangePopup>.NativeClassPtr, "TrucedColor");
			CartelStatusChangePopup.NativeFieldInfoPtr_HostileColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelStatusChangePopup>.NativeClassPtr, "HostileColor");
			CartelStatusChangePopup.NativeFieldInfoPtr_DefeatedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelStatusChangePopup>.NativeClassPtr, "DefeatedColor");
			CartelStatusChangePopup.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelStatusChangePopup>.NativeClassPtr, 100686443);
			CartelStatusChangePopup.NativeMethodInfoPtr_Show_Public_Void_ECartelStatus_ECartelStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelStatusChangePopup>.NativeClassPtr, 100686444);
			CartelStatusChangePopup.NativeMethodInfoPtr_GetColor_Private_Color_ECartelStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelStatusChangePopup>.NativeClassPtr, 100686445);
			CartelStatusChangePopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelStatusChangePopup>.NativeClassPtr, 100686446);
			CartelStatusChangePopup.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelStatusChangePopup>.NativeClassPtr, 100686447);
		}

		// Token: 0x0600AFFC RID: 45052 RVA: 0x002E0998 File Offset: 0x002DEB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299540, XrefRangeEnd = 299560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelStatusChangePopup.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AFFD RID: 45053 RVA: 0x002E09CC File Offset: 0x002DEBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299560, XrefRangeEnd = 299585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Show(ECartelStatus oldStatus, ECartelStatus newStatus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldStatus;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newStatus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelStatusChangePopup.NativeMethodInfoPtr_Show_Public_Void_ECartelStatus_ECartelStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AFFE RID: 45054 RVA: 0x002E0A18 File Offset: 0x002DEC18
		[CallerCount(0)]
		public unsafe Color GetColor(ECartelStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelStatusChangePopup.NativeMethodInfoPtr_GetColor_Private_Color_ECartelStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AFFF RID: 45055 RVA: 0x002E0A64 File Offset: 0x002DEC64
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelStatusChangePopup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelStatusChangePopup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelStatusChangePopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B000 RID: 45056 RVA: 0x002E0AA0 File Offset: 0x002DECA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299585, XrefRangeEnd = 299590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelStatusChangePopup.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B001 RID: 45057 RVA: 0x00050C96 File Offset: 0x0004EE96
		public CartelStatusChangePopup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170034DC RID: 13532
		// (get) Token: 0x0600B002 RID: 45058 RVA: 0x002E0AE0 File Offset: 0x002DECE0
		// (set) Token: 0x0600B003 RID: 45059 RVA: 0x00050C9F File Offset: 0x0004EE9F
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelStatusChangePopup.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelStatusChangePopup.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034DD RID: 13533
		// (get) Token: 0x0600B004 RID: 45060 RVA: 0x002E0B10 File Offset: 0x002DED10
		// (set) Token: 0x0600B005 RID: 45061 RVA: 0x00050CBE File Offset: 0x0004EEBE
		public unsafe TextMeshProUGUI OldStatusLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelStatusChangePopup.NativeFieldInfoPtr_OldStatusLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelStatusChangePopup.NativeFieldInfoPtr_OldStatusLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034DE RID: 13534
		// (get) Token: 0x0600B006 RID: 45062 RVA: 0x002E0B40 File Offset: 0x002DED40
		// (set) Token: 0x0600B007 RID: 45063 RVA: 0x00050CDD File Offset: 0x0004EEDD
		public unsafe TextMeshProUGUI NewStatusLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelStatusChangePopup.NativeFieldInfoPtr_NewStatusLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelStatusChangePopup.NativeFieldInfoPtr_NewStatusLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034DF RID: 13535
		// (get) Token: 0x0600B008 RID: 45064 RVA: 0x002E0B70 File Offset: 0x002DED70
		// (set) Token: 0x0600B009 RID: 45065 RVA: 0x00050CFC File Offset: 0x0004EEFC
		public unsafe Color UnknownColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelStatusChangePopup.NativeFieldInfoPtr_UnknownColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelStatusChangePopup.NativeFieldInfoPtr_UnknownColor)) = value;
			}
		}

		// Token: 0x170034E0 RID: 13536
		// (get) Token: 0x0600B00A RID: 45066 RVA: 0x002E0B98 File Offset: 0x002DED98
		// (set) Token: 0x0600B00B RID: 45067 RVA: 0x00050D17 File Offset: 0x0004EF17
		public unsafe Color TrucedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelStatusChangePopup.NativeFieldInfoPtr_TrucedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelStatusChangePopup.NativeFieldInfoPtr_TrucedColor)) = value;
			}
		}

		// Token: 0x170034E1 RID: 13537
		// (get) Token: 0x0600B00C RID: 45068 RVA: 0x002E0BC0 File Offset: 0x002DEDC0
		// (set) Token: 0x0600B00D RID: 45069 RVA: 0x00050D32 File Offset: 0x0004EF32
		public unsafe Color HostileColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelStatusChangePopup.NativeFieldInfoPtr_HostileColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelStatusChangePopup.NativeFieldInfoPtr_HostileColor)) = value;
			}
		}

		// Token: 0x170034E2 RID: 13538
		// (get) Token: 0x0600B00E RID: 45070 RVA: 0x002E0BE8 File Offset: 0x002DEDE8
		// (set) Token: 0x0600B00F RID: 45071 RVA: 0x00050D4D File Offset: 0x0004EF4D
		public unsafe Color DefeatedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelStatusChangePopup.NativeFieldInfoPtr_DefeatedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelStatusChangePopup.NativeFieldInfoPtr_DefeatedColor)) = value;
			}
		}

		// Token: 0x04007952 RID: 31058
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04007953 RID: 31059
		private static readonly IntPtr NativeFieldInfoPtr_OldStatusLabel;

		// Token: 0x04007954 RID: 31060
		private static readonly IntPtr NativeFieldInfoPtr_NewStatusLabel;

		// Token: 0x04007955 RID: 31061
		private static readonly IntPtr NativeFieldInfoPtr_UnknownColor;

		// Token: 0x04007956 RID: 31062
		private static readonly IntPtr NativeFieldInfoPtr_TrucedColor;

		// Token: 0x04007957 RID: 31063
		private static readonly IntPtr NativeFieldInfoPtr_HostileColor;

		// Token: 0x04007958 RID: 31064
		private static readonly IntPtr NativeFieldInfoPtr_DefeatedColor;

		// Token: 0x04007959 RID: 31065
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400795A RID: 31066
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_ECartelStatus_ECartelStatus_0;

		// Token: 0x0400795B RID: 31067
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Private_Color_ECartelStatus_0;

		// Token: 0x0400795C RID: 31068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400795D RID: 31069
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000CBA RID: 3258
		[ObfuscatedName("ScheduleOne.UI.CartelStatusChangePopup+<<Show>g__Routine|8_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600F410 RID: 62480 RVA: 0x003AB5AC File Offset: 0x003A97AC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique()
			{
				Il2CppClassPointerStore<CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CartelStatusChangePopup>.NativeClassPtr, "<<Show>g__Routine|8_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique>.NativeClassPtr);
				CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique>.NativeClassPtr, "<>1__state");
				CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique>.NativeClassPtr, "<>2__current");
				CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique>.NativeClassPtr, "<>4__this");
				CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique>.NativeClassPtr, 100686448);
				CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique>.NativeClassPtr, 100686449);
				CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique>.NativeClassPtr, 100686450);
				CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique>.NativeClassPtr, 100686451);
				CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique>.NativeClassPtr, 100686452);
				CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique>.NativeClassPtr, 100686453);
			}

			// Token: 0x0600F411 RID: 62481 RVA: 0x003AB68C File Offset: 0x003A988C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F412 RID: 62482 RVA: 0x003AB6D4 File Offset: 0x003A98D4
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F413 RID: 62483 RVA: 0x003AB708 File Offset: 0x003A9908
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299524, XrefRangeEnd = 299530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004A19 RID: 18969
			// (get) Token: 0x0600F414 RID: 62484 RVA: 0x003AB744 File Offset: 0x003A9944
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F415 RID: 62485 RVA: 0x003AB784 File Offset: 0x003A9984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299530, XrefRangeEnd = 299535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004A1A RID: 18970
			// (get) Token: 0x0600F416 RID: 62486 RVA: 0x003AB7B8 File Offset: 0x003A99B8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F417 RID: 62487 RVA: 0x0007341C File Offset: 0x0007161C
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A16 RID: 18966
			// (get) Token: 0x0600F418 RID: 62488 RVA: 0x003AB7F8 File Offset: 0x003A99F8
			// (set) Token: 0x0600F419 RID: 62489 RVA: 0x00073425 File Offset: 0x00071625
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004A17 RID: 18967
			// (get) Token: 0x0600F41A RID: 62490 RVA: 0x003AB820 File Offset: 0x003A9A20
			// (set) Token: 0x0600F41B RID: 62491 RVA: 0x00073440 File Offset: 0x00071640
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A18 RID: 18968
			// (get) Token: 0x0600F41C RID: 62492 RVA: 0x003AB850 File Offset: 0x003A9A50
			// (set) Token: 0x0600F41D RID: 62493 RVA: 0x0007345F File Offset: 0x0007165F
			public unsafe CartelStatusChangePopup __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelStatusChangePopup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelStatusChangePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A545 RID: 42309
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A546 RID: 42310
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A547 RID: 42311
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A548 RID: 42312
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A549 RID: 42313
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A54A RID: 42314
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A54B RID: 42315
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A54C RID: 42316
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A54D RID: 42317
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000CBB RID: 3259
		[ObfuscatedName("ScheduleOne.UI.CartelStatusChangePopup+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F41E RID: 62494 RVA: 0x003AB880 File Offset: 0x003A9A80
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CartelStatusChangePopup.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CartelStatusChangePopup>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelStatusChangePopup.__c>.NativeClassPtr);
				CartelStatusChangePopup.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelStatusChangePopup.__c>.NativeClassPtr, "<>9");
				CartelStatusChangePopup.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelStatusChangePopup.__c>.NativeClassPtr, "<>9__8_1");
				CartelStatusChangePopup.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelStatusChangePopup.__c>.NativeClassPtr, 100686455);
				CartelStatusChangePopup.__c.NativeMethodInfoPtr__Show_b__8_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelStatusChangePopup.__c>.NativeClassPtr, 100686456);
			}

			// Token: 0x0600F41F RID: 62495 RVA: 0x003AB8FC File Offset: 0x003A9AFC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelStatusChangePopup.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelStatusChangePopup.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F420 RID: 62496 RVA: 0x003AB938 File Offset: 0x003A9B38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299535, XrefRangeEnd = 299540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Show_b__8_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelStatusChangePopup.__c.NativeMethodInfoPtr__Show_b__8_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F421 RID: 62497 RVA: 0x0007347E File Offset: 0x0007167E
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A1B RID: 18971
			// (get) Token: 0x0600F422 RID: 62498 RVA: 0x003AB974 File Offset: 0x003A9B74
			// (set) Token: 0x0600F423 RID: 62499 RVA: 0x00073487 File Offset: 0x00071687
			public unsafe static CartelStatusChangePopup.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CartelStatusChangePopup.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelStatusChangePopup.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CartelStatusChangePopup.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A1C RID: 18972
			// (get) Token: 0x0600F424 RID: 62500 RVA: 0x003AB99C File Offset: 0x003A9B9C
			// (set) Token: 0x0600F425 RID: 62501 RVA: 0x00073499 File Offset: 0x00071699
			public unsafe static Func<bool> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CartelStatusChangePopup.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CartelStatusChangePopup.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A54E RID: 42318
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A54F RID: 42319
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x0400A550 RID: 42320
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A551 RID: 42321
			private static readonly IntPtr NativeMethodInfoPtr__Show_b__8_1_Internal_Boolean_0;
		}
	}
}
