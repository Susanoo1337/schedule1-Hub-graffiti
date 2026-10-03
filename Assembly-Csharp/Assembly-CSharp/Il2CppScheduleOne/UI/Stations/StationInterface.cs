using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x02000784 RID: 1924
	public class StationInterface<T> : Singleton<T> where T : Singleton<T>
	{
		// Token: 0x0600BB92 RID: 48018 RVA: 0x00303138 File Offset: 0x00301338
		// Note: this type is marked as 'beforefieldinit'.
		static StationInterface()
		{
			Il2CppClassPointerStore<StationInterface<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "StationInterface`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationInterface<T>>.NativeClassPtr);
			StationInterface<T>.NativeFieldInfoPtr_OpenLerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationInterface<T>>.NativeClassPtr, "OpenLerpTime");
			StationInterface<T>.NativeFieldInfoPtr_CloseLerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationInterface<T>>.NativeClassPtr, "CloseLerpTime");
			StationInterface<T>.NativeFieldInfoPtr__canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationInterface<T>>.NativeClassPtr, "_canvas");
			StationInterface<T>.NativeFieldInfoPtr__container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationInterface<T>>.NativeClassPtr, "_container");
			StationInterface<T>.NativeFieldInfoPtr__uiScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationInterface<T>>.NativeClassPtr, "_uiScreen");
			StationInterface<T>.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationInterface<T>>.NativeClassPtr, "<IsOpen>k__BackingField");
			StationInterface<T>.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationInterface<T>>.NativeClassPtr, 100687766);
			StationInterface<T>.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationInterface<T>>.NativeClassPtr, 100687767);
			StationInterface<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationInterface<T>>.NativeClassPtr, 100687768);
			StationInterface<T>.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationInterface<T>>.NativeClassPtr, 100687769);
			StationInterface<T>.NativeMethodInfoPtr_OnOpen_Protected_Virtual_New_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationInterface<T>>.NativeClassPtr, 100687770);
			StationInterface<T>.NativeMethodInfoPtr_OnClose_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationInterface<T>>.NativeClassPtr, 100687771);
			StationInterface<T>.NativeMethodInfoPtr_GetFoV_Protected_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationInterface<T>>.NativeClassPtr, 100687772);
			StationInterface<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationInterface<T>>.NativeClassPtr, 100687773);
		}

		// Token: 0x170038C1 RID: 14529
		// (get) Token: 0x0600BB93 RID: 48019 RVA: 0x003032BC File Offset: 0x003014BC
		// (set) Token: 0x0600BB94 RID: 48020 RVA: 0x003032F8 File Offset: 0x003014F8
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationInterface<T>.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationInterface<T>.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600BB95 RID: 48021 RVA: 0x00303338 File Offset: 0x00301538
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 312985, RefRangeEnd = 312992, XrefRangeStart = 312981, XrefRangeEnd = 312985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StationInterface<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB96 RID: 48022 RVA: 0x00303374 File Offset: 0x00301574
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313002, RefRangeEnd = 313003, XrefRangeStart = 312992, XrefRangeEnd = 313002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StationInterface<T>.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB97 RID: 48023 RVA: 0x003033B0 File Offset: 0x003015B0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 313035, RefRangeEnd = 313047, XrefRangeStart = 313003, XrefRangeEnd = 313035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnOpen(Transform cameraAlignment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cameraAlignment);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StationInterface<T>.NativeMethodInfoPtr_OnOpen_Protected_Virtual_New_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB98 RID: 48024 RVA: 0x00303400 File Offset: 0x00301600
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 313074, RefRangeEnd = 313085, XrefRangeStart = 313047, XrefRangeEnd = 313074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StationInterface<T>.NativeMethodInfoPtr_OnClose_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB99 RID: 48025 RVA: 0x0030343C File Offset: 0x0030163C
		[CallerCount(0)]
		public unsafe virtual float GetFoV()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StationInterface<T>.NativeMethodInfoPtr_GetFoV_Protected_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600BB9A RID: 48026 RVA: 0x00303484 File Offset: 0x00301684
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 313089, RefRangeEnd = 313097, XrefRangeStart = 313085, XrefRangeEnd = 313089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationInterface<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationInterface<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB9B RID: 48027 RVA: 0x000578D6 File Offset: 0x00055AD6
		public StationInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038BB RID: 14523
		// (get) Token: 0x0600BB9C RID: 48028 RVA: 0x003034C0 File Offset: 0x003016C0
		// (set) Token: 0x0600BB9D RID: 48029 RVA: 0x000578DF File Offset: 0x00055ADF
		public unsafe static float OpenLerpTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StationInterface<T>.NativeFieldInfoPtr_OpenLerpTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StationInterface<T>.NativeFieldInfoPtr_OpenLerpTime, (void*)(&value));
			}
		}

		// Token: 0x170038BC RID: 14524
		// (get) Token: 0x0600BB9E RID: 48030 RVA: 0x003034DC File Offset: 0x003016DC
		// (set) Token: 0x0600BB9F RID: 48031 RVA: 0x000578ED File Offset: 0x00055AED
		public unsafe static float CloseLerpTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StationInterface<T>.NativeFieldInfoPtr_CloseLerpTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StationInterface<T>.NativeFieldInfoPtr_CloseLerpTime, (void*)(&value));
			}
		}

		// Token: 0x170038BD RID: 14525
		// (get) Token: 0x0600BBA0 RID: 48032 RVA: 0x003034F8 File Offset: 0x003016F8
		// (set) Token: 0x0600BBA1 RID: 48033 RVA: 0x000578FB File Offset: 0x00055AFB
		public unsafe Canvas _canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationInterface<T>.NativeFieldInfoPtr__canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationInterface<T>.NativeFieldInfoPtr__canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038BE RID: 14526
		// (get) Token: 0x0600BBA2 RID: 48034 RVA: 0x00303528 File Offset: 0x00301728
		// (set) Token: 0x0600BBA3 RID: 48035 RVA: 0x0005791A File Offset: 0x00055B1A
		public unsafe RectTransform _container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationInterface<T>.NativeFieldInfoPtr__container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationInterface<T>.NativeFieldInfoPtr__container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038BF RID: 14527
		// (get) Token: 0x0600BBA4 RID: 48036 RVA: 0x00303558 File Offset: 0x00301758
		// (set) Token: 0x0600BBA5 RID: 48037 RVA: 0x00057939 File Offset: 0x00055B39
		public unsafe UIScreen _uiScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationInterface<T>.NativeFieldInfoPtr__uiScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationInterface<T>.NativeFieldInfoPtr__uiScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038C0 RID: 14528
		// (get) Token: 0x0600BBA6 RID: 48038 RVA: 0x00303588 File Offset: 0x00301788
		// (set) Token: 0x0600BBA7 RID: 48039 RVA: 0x00057958 File Offset: 0x00055B58
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationInterface<T>.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationInterface<T>.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x04008090 RID: 32912
		private static readonly IntPtr NativeFieldInfoPtr_OpenLerpTime;

		// Token: 0x04008091 RID: 32913
		private static readonly IntPtr NativeFieldInfoPtr_CloseLerpTime;

		// Token: 0x04008092 RID: 32914
		private static readonly IntPtr NativeFieldInfoPtr__canvas;

		// Token: 0x04008093 RID: 32915
		private static readonly IntPtr NativeFieldInfoPtr__container;

		// Token: 0x04008094 RID: 32916
		private static readonly IntPtr NativeFieldInfoPtr__uiScreen;

		// Token: 0x04008095 RID: 32917
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04008096 RID: 32918
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04008097 RID: 32919
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04008098 RID: 32920
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04008099 RID: 32921
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400809A RID: 32922
		private static readonly IntPtr NativeMethodInfoPtr_OnOpen_Protected_Virtual_New_Void_Transform_0;

		// Token: 0x0400809B RID: 32923
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Protected_Virtual_New_Void_0;

		// Token: 0x0400809C RID: 32924
		private static readonly IntPtr NativeMethodInfoPtr_GetFoV_Protected_Virtual_New_Single_0;

		// Token: 0x0400809D RID: 32925
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
