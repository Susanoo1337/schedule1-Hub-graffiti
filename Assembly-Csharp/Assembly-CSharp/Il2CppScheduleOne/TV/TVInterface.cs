using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x02000107 RID: 263
	public class TVInterface : MonoBehaviour
	{
		// Token: 0x06001972 RID: 6514 RVA: 0x000CECE8 File Offset: 0x000CCEE8
		// Note: this type is marked as 'beforefieldinit'.
		static TVInterface()
		{
			Il2CppClassPointerStore<TVInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "TVInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVInterface>.NativeClassPtr);
			TVInterface.NativeFieldInfoPtr_OPEN_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "OPEN_TIME");
			TVInterface.NativeFieldInfoPtr_FOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "FOV");
			TVInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			TVInterface.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "Players");
			TVInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "Canvas");
			TVInterface.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "CameraPosition");
			TVInterface.NativeFieldInfoPtr_HomeScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "HomeScreen");
			TVInterface.NativeFieldInfoPtr_TimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "TimeLabel");
			TVInterface.NativeFieldInfoPtr_Daylabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "Daylabel");
			TVInterface.NativeFieldInfoPtr_onPlayerAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "onPlayerAdded");
			TVInterface.NativeFieldInfoPtr_onPlayerRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, "onPlayerRemoved");
			TVInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666688);
			TVInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666689);
			TVInterface.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666690);
			TVInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666691);
			TVInterface.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666692);
			TVInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666693);
			TVInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666694);
			TVInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666695);
			TVInterface.NativeMethodInfoPtr_CanOpen_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666696);
			TVInterface.NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666697);
			TVInterface.NativeMethodInfoPtr_RemovePlayer_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666698);
			TVInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVInterface>.NativeClassPtr, 100666699);
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x000CEEE4 File Offset: 0x000CD0E4
		// (set) Token: 0x06001974 RID: 6516 RVA: 0x000CEF20 File Offset: 0x000CD120
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x000CEF60 File Offset: 0x000CD160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98998, XrefRangeEnd = 99022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x000CEF94 File Offset: 0x000CD194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99022, XrefRangeEnd = 99037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x000CEFC8 File Offset: 0x000CD1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99037, XrefRangeEnd = 99051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x000CEFFC File Offset: 0x000CD1FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99085, RefRangeEnd = 99086, XrefRangeStart = 99051, XrefRangeEnd = 99085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x000CF030 File Offset: 0x000CD230
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99116, RefRangeEnd = 99118, XrefRangeStart = 99086, XrefRangeEnd = 99116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x000CF064 File Offset: 0x000CD264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99118, XrefRangeEnd = 99123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x000CF0A8 File Offset: 0x000CD2A8
		[CallerCount(0)]
		public unsafe bool CanOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_CanOpen_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x000CF0E4 File Offset: 0x000CD2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99123, XrefRangeEnd = 99134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x000CF128 File Offset: 0x000CD328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99134, XrefRangeEnd = 99143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr_RemovePlayer_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x000CF16C File Offset: 0x000CD36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99143, XrefRangeEnd = 99163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TVInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x0000DFFE File Offset: 0x0000C1FE
		public TVInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001980 RID: 6528 RVA: 0x000CF1A8 File Offset: 0x000CD3A8
		// (set) Token: 0x06001981 RID: 6529 RVA: 0x0000E007 File Offset: 0x0000C207
		public unsafe static float OPEN_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TVInterface.NativeFieldInfoPtr_OPEN_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TVInterface.NativeFieldInfoPtr_OPEN_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x000CF1C4 File Offset: 0x000CD3C4
		// (set) Token: 0x06001983 RID: 6531 RVA: 0x0000E015 File Offset: 0x0000C215
		public unsafe static float FOV
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TVInterface.NativeFieldInfoPtr_FOV, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TVInterface.NativeFieldInfoPtr_FOV, (void*)(&value));
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001984 RID: 6532 RVA: 0x000CF1E0 File Offset: 0x000CD3E0
		// (set) Token: 0x06001985 RID: 6533 RVA: 0x0000E023 File Offset: 0x0000C223
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001986 RID: 6534 RVA: 0x000CF208 File Offset: 0x000CD408
		// (set) Token: 0x06001987 RID: 6535 RVA: 0x0000E03E File Offset: 0x0000C23E
		public unsafe List<Player> Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_Players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001988 RID: 6536 RVA: 0x000CF238 File Offset: 0x000CD438
		// (set) Token: 0x06001989 RID: 6537 RVA: 0x0000E05D File Offset: 0x0000C25D
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x0600198A RID: 6538 RVA: 0x000CF268 File Offset: 0x000CD468
		// (set) Token: 0x0600198B RID: 6539 RVA: 0x0000E07C File Offset: 0x0000C27C
		public unsafe Transform CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x0600198C RID: 6540 RVA: 0x000CF298 File Offset: 0x000CD498
		// (set) Token: 0x0600198D RID: 6541 RVA: 0x0000E09B File Offset: 0x0000C29B
		public unsafe TVHomeScreen HomeScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_HomeScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVHomeScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_HomeScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x0600198E RID: 6542 RVA: 0x000CF2C8 File Offset: 0x000CD4C8
		// (set) Token: 0x0600198F RID: 6543 RVA: 0x0000E0BA File Offset: 0x0000C2BA
		public unsafe TextMeshPro TimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_TimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_TimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001990 RID: 6544 RVA: 0x000CF2F8 File Offset: 0x000CD4F8
		// (set) Token: 0x06001991 RID: 6545 RVA: 0x0000E0D9 File Offset: 0x0000C2D9
		public unsafe TextMeshPro Daylabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_Daylabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_Daylabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001992 RID: 6546 RVA: 0x000CF328 File Offset: 0x000CD528
		// (set) Token: 0x06001993 RID: 6547 RVA: 0x0000E0F8 File Offset: 0x0000C2F8
		public unsafe UnityEvent<Player> onPlayerAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_onPlayerAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_onPlayerAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001994 RID: 6548 RVA: 0x000CF358 File Offset: 0x000CD558
		// (set) Token: 0x06001995 RID: 6549 RVA: 0x0000E117 File Offset: 0x0000C317
		public unsafe UnityEvent<Player> onPlayerRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_onPlayerRemoved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVInterface.NativeFieldInfoPtr_onPlayerRemoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeFieldInfoPtr_OPEN_TIME;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeFieldInfoPtr_FOV;

		// Token: 0x04001199 RID: 4505
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400119A RID: 4506
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x0400119B RID: 4507
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeFieldInfoPtr_HomeScreen;

		// Token: 0x0400119E RID: 4510
		private static readonly IntPtr NativeFieldInfoPtr_TimeLabel;

		// Token: 0x0400119F RID: 4511
		private static readonly IntPtr NativeFieldInfoPtr_Daylabel;

		// Token: 0x040011A0 RID: 4512
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerAdded;

		// Token: 0x040011A1 RID: 4513
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerRemoved;

		// Token: 0x040011A2 RID: 4514
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040011A3 RID: 4515
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x040011A4 RID: 4516
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040011A5 RID: 4517
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040011A6 RID: 4518
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x040011A7 RID: 4519
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x040011A8 RID: 4520
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040011A9 RID: 4521
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040011AA RID: 4522
		private static readonly IntPtr NativeMethodInfoPtr_CanOpen_Public_Boolean_0;

		// Token: 0x040011AB RID: 4523
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0;

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeMethodInfoPtr_RemovePlayer_Public_Void_Player_0;

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
