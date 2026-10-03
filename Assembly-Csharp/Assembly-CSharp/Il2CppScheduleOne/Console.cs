using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne
{
	// Token: 0x020000BA RID: 186
	public class Console : Singleton<Console>
	{
		// Token: 0x060010EF RID: 4335 RVA: 0x000B3B38 File Offset: 0x000B1D38
		// Note: this type is marked as 'beforefieldinit'.
		static Console()
		{
			Il2CppClassPointerStore<Console>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "Console");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console>.NativeClassPtr);
			Console.NativeFieldInfoPtr_TeleportPointsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "TeleportPointsContainer");
			Console.NativeFieldInfoPtr_LabelledGameObjectList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "LabelledGameObjectList");
			Console.NativeFieldInfoPtr_startupCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "startupCommands");
			Console.NativeFieldInfoPtr_Commands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "Commands");
			Console.NativeFieldInfoPtr_commands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "commands");
			Console.NativeFieldInfoPtr_keyBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "keyBindings");
			Console.NativeMethodInfoPtr_get_player_Private_Static_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100665428);
			Console.NativeMethodInfoPtr_LogCommandError_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100665429);
			Console.NativeMethodInfoPtr_LogUnrecognizedFormat_Private_Static_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100665430);
			Console.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100665431);
			Console.NativeMethodInfoPtr_AddCommand_Private_Void_ConsoleCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100665432);
			Console.NativeMethodInfoPtr_RunStartupCommands_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100665433);
			Console.NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100665434);
			Console.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100665435);
			Console.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100665436);
			Console.NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100665437);
			Console.NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100665438);
			Console.NativeMethodInfoPtr_AddBinding_Public_Void_KeyCode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100665439);
			Console.NativeMethodInfoPtr_RemoveBinding_Public_Void_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100665440);
			Console.NativeMethodInfoPtr_ClearBindings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100665441);
			Console.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100665442);
			Console.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100665443);
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x060010F0 RID: 4336 RVA: 0x000B3D20 File Offset: 0x000B1F20
		public unsafe static Player player
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87134, XrefRangeEnd = 87138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_get_player_Private_Static_get_Player_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x000B3D54 File Offset: 0x000B1F54
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 87145, RefRangeEnd = 87150, XrefRangeStart = 87138, XrefRangeEnd = 87145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogCommandError(string error)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_LogCommandError_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x000B3D8C File Offset: 0x000B1F8C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 87171, RefRangeEnd = 87184, XrefRangeStart = 87150, XrefRangeEnd = 87171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogUnrecognizedFormat(Il2CppStringArray correctExamples)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(correctExamples);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_LogUnrecognizedFormat_Private_Static_Void_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x000B3DC4 File Offset: 0x000B1FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87184, XrefRangeEnd = 87548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x000B3E00 File Offset: 0x000B2000
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 87565, RefRangeEnd = 87628, XrefRangeStart = 87548, XrefRangeEnd = 87565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCommand(Console.ConsoleCommand command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_AddCommand_Private_Void_ConsoleCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x000B3E44 File Offset: 0x000B2044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87628, XrefRangeEnd = 87667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunStartupCommands()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_RunStartupCommands_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x000B3E78 File Offset: 0x000B2078
		[CallerCount(336)]
		[CachedScanResults(RefRangeStart = 87671, RefRangeEnd = 88007, XrefRangeStart = 87667, XrefRangeEnd = 87671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(Il2CppSystem.Object message, UnityEngine.Object context = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x000B3EC0 File Offset: 0x000B20C0
		[CallerCount(334)]
		[CachedScanResults(RefRangeStart = 88011, RefRangeEnd = 88345, XrefRangeStart = 88007, XrefRangeEnd = 88011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarning(Il2CppSystem.Object message, UnityEngine.Object context = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x000B3F08 File Offset: 0x000B2108
		[CallerCount(256)]
		[CachedScanResults(RefRangeStart = 88349, RefRangeEnd = 88605, XrefRangeStart = 88345, XrefRangeEnd = 88349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(Il2CppSystem.Object message, UnityEngine.Object context = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x000B3F50 File Offset: 0x000B2150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88643, RefRangeEnd = 88644, XrefRangeStart = 88605, XrefRangeEnd = 88643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SubmitCommand(List<string> args)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_List_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x000B3F88 File Offset: 0x000B2188
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 88660, RefRangeEnd = 88663, XrefRangeStart = 88644, XrefRangeEnd = 88660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SubmitCommand(string args)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x000B3FC0 File Offset: 0x000B21C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88663, XrefRangeEnd = 88689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBinding(KeyCode key, string command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(command);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_AddBinding_Public_Void_KeyCode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x000B4010 File Offset: 0x000B2210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88689, XrefRangeEnd = 88705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveBinding(KeyCode key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_RemoveBinding_Public_Void_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x000B4050 File Offset: 0x000B2250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88705, XrefRangeEnd = 88718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearBindings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_ClearBindings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x000B4084 File Offset: 0x000B2284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88718, XrefRangeEnd = 88747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x000B40B8 File Offset: 0x000B22B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88747, XrefRangeEnd = 88764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Console() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x00009D98 File Offset: 0x00007F98
		public Console(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x000B40F4 File Offset: 0x000B22F4
		// (set) Token: 0x06001102 RID: 4354 RVA: 0x00009DA1 File Offset: 0x00007FA1
		public unsafe Transform TeleportPointsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_TeleportPointsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_TeleportPointsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x000B4124 File Offset: 0x000B2324
		// (set) Token: 0x06001104 RID: 4356 RVA: 0x00009DC0 File Offset: 0x00007FC0
		public unsafe List<Console.LabelledGameObject> LabelledGameObjectList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_LabelledGameObjectList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Console.LabelledGameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_LabelledGameObjectList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x000B4154 File Offset: 0x000B2354
		// (set) Token: 0x06001106 RID: 4358 RVA: 0x00009DDF File Offset: 0x00007FDF
		public unsafe List<string> startupCommands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_startupCommands);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_startupCommands), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x000B4184 File Offset: 0x000B2384
		// (set) Token: 0x06001108 RID: 4360 RVA: 0x00009DFE File Offset: 0x00007FFE
		public unsafe static List<Console.ConsoleCommand> Commands
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_Commands, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Console.ConsoleCommand>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_Commands, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x000B41AC File Offset: 0x000B23AC
		// (set) Token: 0x0600110A RID: 4362 RVA: 0x00009E10 File Offset: 0x00008010
		public unsafe static Dictionary<string, Console.ConsoleCommand> commands
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_commands, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Console.ConsoleCommand>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_commands, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x000B41D4 File Offset: 0x000B23D4
		// (set) Token: 0x0600110C RID: 4364 RVA: 0x00009E22 File Offset: 0x00008022
		public unsafe Dictionary<KeyCode, string> keyBindings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_keyBindings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<KeyCode, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.NativeFieldInfoPtr_keyBindings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeFieldInfoPtr_TeleportPointsContainer;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeFieldInfoPtr_LabelledGameObjectList;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeFieldInfoPtr_startupCommands;

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeFieldInfoPtr_Commands;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeFieldInfoPtr_commands;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeFieldInfoPtr_keyBindings;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr_get_player_Private_Static_get_Player_0;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeMethodInfoPtr_LogCommandError_Private_Static_Void_String_0;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr_LogUnrecognizedFormat_Private_Static_Void_Il2CppStringArray_0;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeMethodInfoPtr_AddCommand_Private_Void_ConsoleCommand_0;

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeMethodInfoPtr_RunStartupCommands_Private_Void_0;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0;

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0;

		// Token: 0x04000BD9 RID: 3033
		private static readonly IntPtr NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_List_1_String_0;

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeMethodInfoPtr_SubmitCommand_Public_Static_Void_String_0;

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeMethodInfoPtr_AddBinding_Public_Void_KeyCode_String_0;

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeMethodInfoPtr_RemoveBinding_Public_Void_KeyCode_0;

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeMethodInfoPtr_ClearBindings_Public_Void_0;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008CE RID: 2254
		public class ConsoleCommand : Il2CppSystem.Object
		{
			// Token: 0x0600D4FC RID: 54524 RVA: 0x00350158 File Offset: 0x0034E358
			// Note: this type is marked as 'beforefieldinit'.
			static ConsoleCommand()
			{
				Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ConsoleCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr);
				Console.ConsoleCommand.NativeMethodInfoPtr_get_CommandWord_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr, 100665445);
				Console.ConsoleCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr, 100665446);
				Console.ConsoleCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr, 100665447);
				Console.ConsoleCommand.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr, 100665448);
				Console.ConsoleCommand.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr, 100665449);
			}

			// Token: 0x170040D8 RID: 16600
			// (get) Token: 0x0600D4FD RID: 54525 RVA: 0x003501E8 File Offset: 0x0034E3E8
			public unsafe virtual string CommandWord
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ConsoleCommand.NativeMethodInfoPtr_get_CommandWord_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040D9 RID: 16601
			// (get) Token: 0x0600D4FE RID: 54526 RVA: 0x0035022C File Offset: 0x0034E42C
			public unsafe virtual string CommandDescription
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ConsoleCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040DA RID: 16602
			// (get) Token: 0x0600D4FF RID: 54527 RVA: 0x00350270 File Offset: 0x0034E470
			public unsafe virtual string ExampleUsage
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ConsoleCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D500 RID: 54528 RVA: 0x003502B4 File Offset: 0x0034E4B4
			[CallerCount(0)]
			public unsafe virtual void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ConsoleCommand.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D501 RID: 54529 RVA: 0x00350304 File Offset: 0x0034E504
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConsoleCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ConsoleCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ConsoleCommand.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D502 RID: 54530 RVA: 0x00064C55 File Offset: 0x00062E55
			public ConsoleCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400910E RID: 37134
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Abstract_Virtual_New_get_String_0;

			// Token: 0x0400910F RID: 37135
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Abstract_Virtual_New_get_String_0;

			// Token: 0x04009110 RID: 37136
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Abstract_Virtual_New_get_String_0;

			// Token: 0x04009111 RID: 37137
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_List_1_String_0;

			// Token: 0x04009112 RID: 37138
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
		}

		// Token: 0x020008CF RID: 2255
		public class SetTimeCommand : Console.ConsoleCommand
		{
			// Token: 0x0600D503 RID: 54531 RVA: 0x00350340 File Offset: 0x0034E540
			// Note: this type is marked as 'beforefieldinit'.
			static SetTimeCommand()
			{
				Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetTimeCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr);
				Console.SetTimeCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr, 100665450);
				Console.SetTimeCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr, 100665451);
				Console.SetTimeCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr, 100665452);
				Console.SetTimeCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr, 100665453);
				Console.SetTimeCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr, 100665454);
			}

			// Token: 0x170040DB RID: 16603
			// (get) Token: 0x0600D504 RID: 54532 RVA: 0x003503D0 File Offset: 0x0034E5D0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85339, XrefRangeEnd = 85341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040DC RID: 16604
			// (get) Token: 0x0600D505 RID: 54533 RVA: 0x00350414 File Offset: 0x0034E614
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85341, XrefRangeEnd = 85343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040DD RID: 16605
			// (get) Token: 0x0600D506 RID: 54534 RVA: 0x00350458 File Offset: 0x0034E658
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85343, XrefRangeEnd = 85345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D507 RID: 54535 RVA: 0x0035049C File Offset: 0x0034E69C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85345, XrefRangeEnd = 85387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D508 RID: 54536 RVA: 0x003504EC File Offset: 0x0034E6EC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetTimeCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetTimeCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetTimeCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D509 RID: 54537 RVA: 0x00064C5E File Offset: 0x00062E5E
			public SetTimeCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009113 RID: 37139
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009114 RID: 37140
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009115 RID: 37141
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009116 RID: 37142
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009117 RID: 37143
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008D0 RID: 2256
		public class SpawnVehicleCommand : Console.ConsoleCommand
		{
			// Token: 0x0600D50A RID: 54538 RVA: 0x00350528 File Offset: 0x0034E728
			// Note: this type is marked as 'beforefieldinit'.
			static SpawnVehicleCommand()
			{
				Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SpawnVehicleCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr);
				Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr, 100665455);
				Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr, 100665456);
				Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr, 100665457);
				Console.SpawnVehicleCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr, 100665458);
				Console.SpawnVehicleCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr, 100665459);
			}

			// Token: 0x170040DE RID: 16606
			// (get) Token: 0x0600D50B RID: 54539 RVA: 0x003505B8 File Offset: 0x0034E7B8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85387, XrefRangeEnd = 85389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040DF RID: 16607
			// (get) Token: 0x0600D50C RID: 54540 RVA: 0x003505FC File Offset: 0x0034E7FC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85389, XrefRangeEnd = 85391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040E0 RID: 16608
			// (get) Token: 0x0600D50D RID: 54541 RVA: 0x00350640 File Offset: 0x0034E840
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85391, XrefRangeEnd = 85393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SpawnVehicleCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D50E RID: 54542 RVA: 0x00350684 File Offset: 0x0034E884
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85393, XrefRangeEnd = 85450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SpawnVehicleCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D50F RID: 54543 RVA: 0x003506D4 File Offset: 0x0034E8D4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpawnVehicleCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SpawnVehicleCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SpawnVehicleCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D510 RID: 54544 RVA: 0x00064C67 File Offset: 0x00062E67
			public SpawnVehicleCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009118 RID: 37144
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009119 RID: 37145
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400911A RID: 37146
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400911B RID: 37147
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400911C RID: 37148
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008D1 RID: 2257
		public class AddItemToInventoryCommand : Console.ConsoleCommand
		{
			// Token: 0x0600D511 RID: 54545 RVA: 0x00350710 File Offset: 0x0034E910
			// Note: this type is marked as 'beforefieldinit'.
			static AddItemToInventoryCommand()
			{
				Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "AddItemToInventoryCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr);
				Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr, 100665460);
				Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr, 100665461);
				Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr, 100665462);
				Console.AddItemToInventoryCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr, 100665463);
				Console.AddItemToInventoryCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr, 100665464);
			}

			// Token: 0x170040E1 RID: 16609
			// (get) Token: 0x0600D512 RID: 54546 RVA: 0x003507A0 File Offset: 0x0034E9A0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85450, XrefRangeEnd = 85452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040E2 RID: 16610
			// (get) Token: 0x0600D513 RID: 54547 RVA: 0x003507E4 File Offset: 0x0034E9E4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85452, XrefRangeEnd = 85454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040E3 RID: 16611
			// (get) Token: 0x0600D514 RID: 54548 RVA: 0x00350828 File Offset: 0x0034EA28
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85454, XrefRangeEnd = 85456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddItemToInventoryCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D515 RID: 54549 RVA: 0x0035086C File Offset: 0x0034EA6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85456, XrefRangeEnd = 85493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddItemToInventoryCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D516 RID: 54550 RVA: 0x003508BC File Offset: 0x0034EABC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddItemToInventoryCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.AddItemToInventoryCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.AddItemToInventoryCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D517 RID: 54551 RVA: 0x00064C70 File Offset: 0x00062E70
			public AddItemToInventoryCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400911D RID: 37149
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400911E RID: 37150
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400911F RID: 37151
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009120 RID: 37152
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009121 RID: 37153
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008D2 RID: 2258
		public class ClearInventoryCommand : Console.ConsoleCommand
		{
			// Token: 0x0600D518 RID: 54552 RVA: 0x003508F8 File Offset: 0x0034EAF8
			// Note: this type is marked as 'beforefieldinit'.
			static ClearInventoryCommand()
			{
				Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ClearInventoryCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr);
				Console.ClearInventoryCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr, 100665465);
				Console.ClearInventoryCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr, 100665466);
				Console.ClearInventoryCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr, 100665467);
				Console.ClearInventoryCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr, 100665468);
				Console.ClearInventoryCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr, 100665469);
			}

			// Token: 0x170040E4 RID: 16612
			// (get) Token: 0x0600D519 RID: 54553 RVA: 0x00350988 File Offset: 0x0034EB88
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85493, XrefRangeEnd = 85495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearInventoryCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040E5 RID: 16613
			// (get) Token: 0x0600D51A RID: 54554 RVA: 0x003509CC File Offset: 0x0034EBCC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85495, XrefRangeEnd = 85497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearInventoryCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040E6 RID: 16614
			// (get) Token: 0x0600D51B RID: 54555 RVA: 0x00350A10 File Offset: 0x0034EC10
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85497, XrefRangeEnd = 85499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearInventoryCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D51C RID: 54556 RVA: 0x00350A54 File Offset: 0x0034EC54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85499, XrefRangeEnd = 85514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearInventoryCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D51D RID: 54557 RVA: 0x00350AA4 File Offset: 0x0034ECA4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClearInventoryCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ClearInventoryCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ClearInventoryCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D51E RID: 54558 RVA: 0x00064C79 File Offset: 0x00062E79
			public ClearInventoryCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009122 RID: 37154
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009123 RID: 37155
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009124 RID: 37156
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009125 RID: 37157
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009126 RID: 37158
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008D3 RID: 2259
		public class ChangeCashCommand : Console.ConsoleCommand
		{
			// Token: 0x0600D51F RID: 54559 RVA: 0x00350AE0 File Offset: 0x0034ECE0
			// Note: this type is marked as 'beforefieldinit'.
			static ChangeCashCommand()
			{
				Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ChangeCashCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr);
				Console.ChangeCashCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr, 100665470);
				Console.ChangeCashCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr, 100665471);
				Console.ChangeCashCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr, 100665472);
				Console.ChangeCashCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr, 100665473);
				Console.ChangeCashCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr, 100665474);
			}

			// Token: 0x170040E7 RID: 16615
			// (get) Token: 0x0600D520 RID: 54560 RVA: 0x00350B70 File Offset: 0x0034ED70
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85514, XrefRangeEnd = 85516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeCashCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040E8 RID: 16616
			// (get) Token: 0x0600D521 RID: 54561 RVA: 0x00350BB4 File Offset: 0x0034EDB4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85516, XrefRangeEnd = 85518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeCashCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040E9 RID: 16617
			// (get) Token: 0x0600D522 RID: 54562 RVA: 0x00350BF8 File Offset: 0x0034EDF8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85518, XrefRangeEnd = 85520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeCashCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D523 RID: 54563 RVA: 0x00350C3C File Offset: 0x0034EE3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85520, XrefRangeEnd = 85549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeCashCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D524 RID: 54564 RVA: 0x00350C8C File Offset: 0x0034EE8C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ChangeCashCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ChangeCashCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ChangeCashCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D525 RID: 54565 RVA: 0x00064C82 File Offset: 0x00062E82
			public ChangeCashCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009127 RID: 37159
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009128 RID: 37160
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009129 RID: 37161
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400912A RID: 37162
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400912B RID: 37163
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008D4 RID: 2260
		public class ChangeOnlineBalanceCommand : Console.ConsoleCommand
		{
			// Token: 0x0600D526 RID: 54566 RVA: 0x00350CC8 File Offset: 0x0034EEC8
			// Note: this type is marked as 'beforefieldinit'.
			static ChangeOnlineBalanceCommand()
			{
				Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ChangeOnlineBalanceCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr);
				Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr, 100665475);
				Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr, 100665476);
				Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr, 100665477);
				Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr, 100665478);
				Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr, 100665479);
			}

			// Token: 0x170040EA RID: 16618
			// (get) Token: 0x0600D527 RID: 54567 RVA: 0x00350D58 File Offset: 0x0034EF58
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85549, XrefRangeEnd = 85551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040EB RID: 16619
			// (get) Token: 0x0600D528 RID: 54568 RVA: 0x00350D9C File Offset: 0x0034EF9C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85551, XrefRangeEnd = 85553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040EC RID: 16620
			// (get) Token: 0x0600D529 RID: 54569 RVA: 0x00350DE0 File Offset: 0x0034EFE0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85553, XrefRangeEnd = 85555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D52A RID: 54570 RVA: 0x00350E24 File Offset: 0x0034F024
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85555, XrefRangeEnd = 85586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D52B RID: 54571 RVA: 0x00350E74 File Offset: 0x0034F074
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ChangeOnlineBalanceCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ChangeOnlineBalanceCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ChangeOnlineBalanceCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D52C RID: 54572 RVA: 0x00064C8B File Offset: 0x00062E8B
			public ChangeOnlineBalanceCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400912C RID: 37164
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400912D RID: 37165
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400912E RID: 37166
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400912F RID: 37167
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009130 RID: 37168
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008D5 RID: 2261
		public class SetMoveSpeedCommand : Console.ConsoleCommand
		{
			// Token: 0x0600D52D RID: 54573 RVA: 0x00350EB0 File Offset: 0x0034F0B0
			// Note: this type is marked as 'beforefieldinit'.
			static SetMoveSpeedCommand()
			{
				Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetMoveSpeedCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr);
				Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr, 100665480);
				Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr, 100665481);
				Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr, 100665482);
				Console.SetMoveSpeedCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr, 100665483);
				Console.SetMoveSpeedCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr, 100665484);
			}

			// Token: 0x170040ED RID: 16621
			// (get) Token: 0x0600D52E RID: 54574 RVA: 0x00350F40 File Offset: 0x0034F140
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85586, XrefRangeEnd = 85588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040EE RID: 16622
			// (get) Token: 0x0600D52F RID: 54575 RVA: 0x00350F84 File Offset: 0x0034F184
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85588, XrefRangeEnd = 85590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040EF RID: 16623
			// (get) Token: 0x0600D530 RID: 54576 RVA: 0x00350FC8 File Offset: 0x0034F1C8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85590, XrefRangeEnd = 85592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetMoveSpeedCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D531 RID: 54577 RVA: 0x0035100C File Offset: 0x0034F20C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85592, XrefRangeEnd = 85610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetMoveSpeedCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D532 RID: 54578 RVA: 0x0035105C File Offset: 0x0034F25C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetMoveSpeedCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetMoveSpeedCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetMoveSpeedCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D533 RID: 54579 RVA: 0x00064C94 File Offset: 0x00062E94
			public SetMoveSpeedCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009131 RID: 37169
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009132 RID: 37170
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009133 RID: 37171
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009134 RID: 37172
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009135 RID: 37173
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008D6 RID: 2262
		public class SetJumpMultiplier : Console.ConsoleCommand
		{
			// Token: 0x0600D534 RID: 54580 RVA: 0x00351098 File Offset: 0x0034F298
			// Note: this type is marked as 'beforefieldinit'.
			static SetJumpMultiplier()
			{
				Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetJumpMultiplier");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr);
				Console.SetJumpMultiplier.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr, 100665485);
				Console.SetJumpMultiplier.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr, 100665486);
				Console.SetJumpMultiplier.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr, 100665487);
				Console.SetJumpMultiplier.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr, 100665488);
				Console.SetJumpMultiplier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr, 100665489);
			}

			// Token: 0x170040F0 RID: 16624
			// (get) Token: 0x0600D535 RID: 54581 RVA: 0x00351128 File Offset: 0x0034F328
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85610, XrefRangeEnd = 85612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetJumpMultiplier.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040F1 RID: 16625
			// (get) Token: 0x0600D536 RID: 54582 RVA: 0x0035116C File Offset: 0x0034F36C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85612, XrefRangeEnd = 85614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetJumpMultiplier.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040F2 RID: 16626
			// (get) Token: 0x0600D537 RID: 54583 RVA: 0x003511B0 File Offset: 0x0034F3B0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85614, XrefRangeEnd = 85616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetJumpMultiplier.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D538 RID: 54584 RVA: 0x003511F4 File Offset: 0x0034F3F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85616, XrefRangeEnd = 85634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetJumpMultiplier.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D539 RID: 54585 RVA: 0x00351244 File Offset: 0x0034F444
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetJumpMultiplier() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetJumpMultiplier>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetJumpMultiplier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D53A RID: 54586 RVA: 0x00064C9D File Offset: 0x00062E9D
			public SetJumpMultiplier(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009136 RID: 37174
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009137 RID: 37175
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009138 RID: 37176
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009139 RID: 37177
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400913A RID: 37178
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008D7 RID: 2263
		public class SetPropertyOwned : Console.ConsoleCommand
		{
			// Token: 0x0600D53B RID: 54587 RVA: 0x00351280 File Offset: 0x0034F480
			// Note: this type is marked as 'beforefieldinit'.
			static SetPropertyOwned()
			{
				Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetPropertyOwned");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr);
				Console.SetPropertyOwned.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, 100665490);
				Console.SetPropertyOwned.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, 100665491);
				Console.SetPropertyOwned.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, 100665492);
				Console.SetPropertyOwned.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, 100665493);
				Console.SetPropertyOwned.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, 100665494);
			}

			// Token: 0x170040F3 RID: 16627
			// (get) Token: 0x0600D53C RID: 54588 RVA: 0x00351310 File Offset: 0x0034F510
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85637, XrefRangeEnd = 85639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetPropertyOwned.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040F4 RID: 16628
			// (get) Token: 0x0600D53D RID: 54589 RVA: 0x00351354 File Offset: 0x0034F554
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85639, XrefRangeEnd = 85641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetPropertyOwned.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040F5 RID: 16629
			// (get) Token: 0x0600D53E RID: 54590 RVA: 0x00351398 File Offset: 0x0034F598
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85641, XrefRangeEnd = 85643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetPropertyOwned.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D53F RID: 54591 RVA: 0x003513DC File Offset: 0x0034F5DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85643, XrefRangeEnd = 85672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetPropertyOwned.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D540 RID: 54592 RVA: 0x0035142C File Offset: 0x0034F62C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetPropertyOwned() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetPropertyOwned.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D541 RID: 54593 RVA: 0x00064CA6 File Offset: 0x00062EA6
			public SetPropertyOwned(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400913B RID: 37179
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400913C RID: 37180
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400913D RID: 37181
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400913E RID: 37182
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400913F RID: 37183
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000DAD RID: 3501
			[ObfuscatedName("ScheduleOne.Console+SetPropertyOwned+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
			{
				// Token: 0x0600FD2B RID: 64811 RVA: 0x003C4E50 File Offset: 0x003C3050
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console.SetPropertyOwned>.NativeClassPtr, "<>c__DisplayClass6_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr);
					Console.SetPropertyOwned.__c__DisplayClass6_0.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr, "code");
					Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr, 100665495);
					Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr, 100665496);
					Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__1_Internal_Boolean_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr, 100665497);
				}

				// Token: 0x0600FD2C RID: 64812 RVA: 0x003C4ECC File Offset: 0x003C30CC
				[CallerCount(2575)]
				[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetPropertyOwned.__c__DisplayClass6_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FD2D RID: 64813 RVA: 0x003C4F08 File Offset: 0x003C3108
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85634, XrefRangeEnd = 85637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Execute_b__0(Property x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600FD2E RID: 64814 RVA: 0x003C4F58 File Offset: 0x003C3158
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Execute_b__1(Business x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetPropertyOwned.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__1_Internal_Boolean_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600FD2F RID: 64815 RVA: 0x00077E41 File Offset: 0x00076041
				public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004CEF RID: 19695
				// (get) Token: 0x0600FD30 RID: 64816 RVA: 0x003C4FA8 File Offset: 0x003C31A8
				// (set) Token: 0x0600FD31 RID: 64817 RVA: 0x00077E4A File Offset: 0x0007604A
				public unsafe string code
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.SetPropertyOwned.__c__DisplayClass6_0.NativeFieldInfoPtr_code);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.SetPropertyOwned.__c__DisplayClass6_0.NativeFieldInfoPtr_code), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x0400AAB7 RID: 43703
				private static readonly IntPtr NativeFieldInfoPtr_code;

				// Token: 0x0400AAB8 RID: 43704
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400AAB9 RID: 43705
				private static readonly IntPtr NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0;

				// Token: 0x0400AABA RID: 43706
				private static readonly IntPtr NativeMethodInfoPtr__Execute_b__1_Internal_Boolean_Business_0;
			}
		}

		// Token: 0x020008D8 RID: 2264
		public class Teleport : Console.ConsoleCommand
		{
			// Token: 0x0600D542 RID: 54594 RVA: 0x00351468 File Offset: 0x0034F668
			// Note: this type is marked as 'beforefieldinit'.
			static Teleport()
			{
				Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Teleport");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr);
				Console.Teleport.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr, 100665498);
				Console.Teleport.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr, 100665499);
				Console.Teleport.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr, 100665500);
				Console.Teleport.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr, 100665501);
				Console.Teleport.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr, 100665502);
			}

			// Token: 0x170040F6 RID: 16630
			// (get) Token: 0x0600D543 RID: 54595 RVA: 0x003514F8 File Offset: 0x0034F6F8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85672, XrefRangeEnd = 85674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Teleport.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040F7 RID: 16631
			// (get) Token: 0x0600D544 RID: 54596 RVA: 0x0035153C File Offset: 0x0034F73C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85674, XrefRangeEnd = 85676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Teleport.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040F8 RID: 16632
			// (get) Token: 0x0600D545 RID: 54597 RVA: 0x00351580 File Offset: 0x0034F780
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85676, XrefRangeEnd = 85678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Teleport.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D546 RID: 54598 RVA: 0x003515C4 File Offset: 0x0034F7C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85678, XrefRangeEnd = 85704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Teleport.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D547 RID: 54599 RVA: 0x00351614 File Offset: 0x0034F814
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Teleport() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Teleport>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Teleport.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D548 RID: 54600 RVA: 0x00064CAF File Offset: 0x00062EAF
			public Teleport(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009140 RID: 37184
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009141 RID: 37185
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009142 RID: 37186
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009143 RID: 37187
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009144 RID: 37188
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008D9 RID: 2265
		public class PackageProduct : Console.ConsoleCommand
		{
			// Token: 0x0600D549 RID: 54601 RVA: 0x00351650 File Offset: 0x0034F850
			// Note: this type is marked as 'beforefieldinit'.
			static PackageProduct()
			{
				Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "PackageProduct");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr);
				Console.PackageProduct.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr, 100665503);
				Console.PackageProduct.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr, 100665504);
				Console.PackageProduct.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr, 100665505);
				Console.PackageProduct.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr, 100665506);
				Console.PackageProduct.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr, 100665507);
			}

			// Token: 0x170040F9 RID: 16633
			// (get) Token: 0x0600D54A RID: 54602 RVA: 0x003516E0 File Offset: 0x0034F8E0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85704, XrefRangeEnd = 85706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PackageProduct.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040FA RID: 16634
			// (get) Token: 0x0600D54B RID: 54603 RVA: 0x00351724 File Offset: 0x0034F924
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85706, XrefRangeEnd = 85708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PackageProduct.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040FB RID: 16635
			// (get) Token: 0x0600D54C RID: 54604 RVA: 0x00351768 File Offset: 0x0034F968
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85708, XrefRangeEnd = 85710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PackageProduct.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D54D RID: 54605 RVA: 0x003517AC File Offset: 0x0034F9AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85710, XrefRangeEnd = 85775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PackageProduct.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D54E RID: 54606 RVA: 0x003517FC File Offset: 0x0034F9FC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PackageProduct() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.PackageProduct>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.PackageProduct.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D54F RID: 54607 RVA: 0x00064CB8 File Offset: 0x00062EB8
			public PackageProduct(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009145 RID: 37189
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009146 RID: 37190
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009147 RID: 37191
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009148 RID: 37192
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009149 RID: 37193
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008DA RID: 2266
		public class SetStaminaReserve : Console.ConsoleCommand
		{
			// Token: 0x0600D550 RID: 54608 RVA: 0x00351838 File Offset: 0x0034FA38
			// Note: this type is marked as 'beforefieldinit'.
			static SetStaminaReserve()
			{
				Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetStaminaReserve");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr);
				Console.SetStaminaReserve.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr, 100665508);
				Console.SetStaminaReserve.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr, 100665509);
				Console.SetStaminaReserve.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr, 100665510);
				Console.SetStaminaReserve.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr, 100665511);
				Console.SetStaminaReserve.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr, 100665512);
			}

			// Token: 0x170040FC RID: 16636
			// (get) Token: 0x0600D551 RID: 54609 RVA: 0x003518C8 File Offset: 0x0034FAC8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85775, XrefRangeEnd = 85777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetStaminaReserve.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040FD RID: 16637
			// (get) Token: 0x0600D552 RID: 54610 RVA: 0x0035190C File Offset: 0x0034FB0C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85777, XrefRangeEnd = 85779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetStaminaReserve.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170040FE RID: 16638
			// (get) Token: 0x0600D553 RID: 54611 RVA: 0x00351950 File Offset: 0x0034FB50
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85779, XrefRangeEnd = 85781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetStaminaReserve.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D554 RID: 54612 RVA: 0x00351994 File Offset: 0x0034FB94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85781, XrefRangeEnd = 85803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetStaminaReserve.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D555 RID: 54613 RVA: 0x003519E4 File Offset: 0x0034FBE4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetStaminaReserve() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetStaminaReserve>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetStaminaReserve.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D556 RID: 54614 RVA: 0x00064CC1 File Offset: 0x00062EC1
			public SetStaminaReserve(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400914A RID: 37194
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400914B RID: 37195
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400914C RID: 37196
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400914D RID: 37197
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400914E RID: 37198
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008DB RID: 2267
		public class SetWeather : Console.ConsoleCommand
		{
			// Token: 0x0600D557 RID: 54615 RVA: 0x00351A20 File Offset: 0x0034FC20
			// Note: this type is marked as 'beforefieldinit'.
			static SetWeather()
			{
				Il2CppClassPointerStore<Console.SetWeather>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetWeather");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetWeather>.NativeClassPtr);
				Console.SetWeather.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetWeather>.NativeClassPtr, 100665513);
				Console.SetWeather.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetWeather>.NativeClassPtr, 100665514);
				Console.SetWeather.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetWeather>.NativeClassPtr, 100665515);
				Console.SetWeather.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetWeather>.NativeClassPtr, 100665516);
				Console.SetWeather.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetWeather>.NativeClassPtr, 100665517);
			}

			// Token: 0x170040FF RID: 16639
			// (get) Token: 0x0600D558 RID: 54616 RVA: 0x00351AB0 File Offset: 0x0034FCB0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85803, XrefRangeEnd = 85805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetWeather.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004100 RID: 16640
			// (get) Token: 0x0600D559 RID: 54617 RVA: 0x00351AF4 File Offset: 0x0034FCF4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85805, XrefRangeEnd = 85807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetWeather.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004101 RID: 16641
			// (get) Token: 0x0600D55A RID: 54618 RVA: 0x00351B38 File Offset: 0x0034FD38
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85807, XrefRangeEnd = 85809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetWeather.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D55B RID: 54619 RVA: 0x00351B7C File Offset: 0x0034FD7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85809, XrefRangeEnd = 85830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetWeather.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D55C RID: 54620 RVA: 0x00351BCC File Offset: 0x0034FDCC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetWeather() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetWeather>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetWeather.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D55D RID: 54621 RVA: 0x00064CCA File Offset: 0x00062ECA
			public SetWeather(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400914F RID: 37199
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009150 RID: 37200
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009151 RID: 37201
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009152 RID: 37202
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009153 RID: 37203
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008DC RID: 2268
		public class TriggerLightning : Console.ConsoleCommand
		{
			// Token: 0x0600D55E RID: 54622 RVA: 0x00351C08 File Offset: 0x0034FE08
			// Note: this type is marked as 'beforefieldinit'.
			static TriggerLightning()
			{
				Il2CppClassPointerStore<Console.TriggerLightning>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "TriggerLightning");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.TriggerLightning>.NativeClassPtr);
				Console.TriggerLightning.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.TriggerLightning>.NativeClassPtr, 100665518);
				Console.TriggerLightning.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.TriggerLightning>.NativeClassPtr, 100665519);
				Console.TriggerLightning.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.TriggerLightning>.NativeClassPtr, 100665520);
				Console.TriggerLightning.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.TriggerLightning>.NativeClassPtr, 100665521);
				Console.TriggerLightning.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.TriggerLightning>.NativeClassPtr, 100665522);
			}

			// Token: 0x17004102 RID: 16642
			// (get) Token: 0x0600D55F RID: 54623 RVA: 0x00351C98 File Offset: 0x0034FE98
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85830, XrefRangeEnd = 85832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.TriggerLightning.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004103 RID: 16643
			// (get) Token: 0x0600D560 RID: 54624 RVA: 0x00351CDC File Offset: 0x0034FEDC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85832, XrefRangeEnd = 85834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.TriggerLightning.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004104 RID: 16644
			// (get) Token: 0x0600D561 RID: 54625 RVA: 0x00351D20 File Offset: 0x0034FF20
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85834, XrefRangeEnd = 85836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.TriggerLightning.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D562 RID: 54626 RVA: 0x00351D64 File Offset: 0x0034FF64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85836, XrefRangeEnd = 85861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.TriggerLightning.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D563 RID: 54627 RVA: 0x00351DB4 File Offset: 0x0034FFB4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TriggerLightning() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.TriggerLightning>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.TriggerLightning.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D564 RID: 54628 RVA: 0x00064CD3 File Offset: 0x00062ED3
			public TriggerLightning(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009154 RID: 37204
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009155 RID: 37205
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009156 RID: 37206
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009157 RID: 37207
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009158 RID: 37208
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008DD RID: 2269
		public class TriggerDistantThunder : Console.ConsoleCommand
		{
			// Token: 0x0600D565 RID: 54629 RVA: 0x00351DF0 File Offset: 0x0034FFF0
			// Note: this type is marked as 'beforefieldinit'.
			static TriggerDistantThunder()
			{
				Il2CppClassPointerStore<Console.TriggerDistantThunder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "TriggerDistantThunder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.TriggerDistantThunder>.NativeClassPtr);
				Console.TriggerDistantThunder.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.TriggerDistantThunder>.NativeClassPtr, 100665523);
				Console.TriggerDistantThunder.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.TriggerDistantThunder>.NativeClassPtr, 100665524);
				Console.TriggerDistantThunder.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.TriggerDistantThunder>.NativeClassPtr, 100665525);
				Console.TriggerDistantThunder.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.TriggerDistantThunder>.NativeClassPtr, 100665526);
				Console.TriggerDistantThunder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.TriggerDistantThunder>.NativeClassPtr, 100665527);
			}

			// Token: 0x17004105 RID: 16645
			// (get) Token: 0x0600D566 RID: 54630 RVA: 0x00351E80 File Offset: 0x00350080
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85861, XrefRangeEnd = 85863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.TriggerDistantThunder.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004106 RID: 16646
			// (get) Token: 0x0600D567 RID: 54631 RVA: 0x00351EC4 File Offset: 0x003500C4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85863, XrefRangeEnd = 85865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.TriggerDistantThunder.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004107 RID: 16647
			// (get) Token: 0x0600D568 RID: 54632 RVA: 0x00351F08 File Offset: 0x00350108
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85865, XrefRangeEnd = 85867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.TriggerDistantThunder.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D569 RID: 54633 RVA: 0x00351F4C File Offset: 0x0035014C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85867, XrefRangeEnd = 85868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.TriggerDistantThunder.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D56A RID: 54634 RVA: 0x00351F9C File Offset: 0x0035019C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TriggerDistantThunder() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.TriggerDistantThunder>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.TriggerDistantThunder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D56B RID: 54635 RVA: 0x00064CDC File Offset: 0x00062EDC
			public TriggerDistantThunder(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009159 RID: 37209
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400915A RID: 37210
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400915B RID: 37211
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400915C RID: 37212
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400915D RID: 37213
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008DE RID: 2270
		public class EnablePhysics : Console.ConsoleCommand
		{
			// Token: 0x0600D56C RID: 54636 RVA: 0x00351FD8 File Offset: 0x003501D8
			// Note: this type is marked as 'beforefieldinit'.
			static EnablePhysics()
			{
				Il2CppClassPointerStore<Console.EnablePhysics>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "EnablePhysics");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.EnablePhysics>.NativeClassPtr);
				Console.EnablePhysics.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EnablePhysics>.NativeClassPtr, 100665528);
				Console.EnablePhysics.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EnablePhysics>.NativeClassPtr, 100665529);
				Console.EnablePhysics.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EnablePhysics>.NativeClassPtr, 100665530);
				Console.EnablePhysics.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EnablePhysics>.NativeClassPtr, 100665531);
				Console.EnablePhysics.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EnablePhysics>.NativeClassPtr, 100665532);
			}

			// Token: 0x17004108 RID: 16648
			// (get) Token: 0x0600D56D RID: 54637 RVA: 0x00352068 File Offset: 0x00350268
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85868, XrefRangeEnd = 85870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EnablePhysics.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004109 RID: 16649
			// (get) Token: 0x0600D56E RID: 54638 RVA: 0x003520AC File Offset: 0x003502AC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85870, XrefRangeEnd = 85872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EnablePhysics.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700410A RID: 16650
			// (get) Token: 0x0600D56F RID: 54639 RVA: 0x003520F0 File Offset: 0x003502F0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85872, XrefRangeEnd = 85874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EnablePhysics.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D570 RID: 54640 RVA: 0x00352134 File Offset: 0x00350334
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85874, XrefRangeEnd = 85887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EnablePhysics.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D571 RID: 54641 RVA: 0x00352184 File Offset: 0x00350384
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EnablePhysics() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.EnablePhysics>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.EnablePhysics.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D572 RID: 54642 RVA: 0x00064CE5 File Offset: 0x00062EE5
			public EnablePhysics(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400915E RID: 37214
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400915F RID: 37215
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009160 RID: 37216
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009161 RID: 37217
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009162 RID: 37218
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008DF RID: 2271
		public class DisablePhysics : Console.ConsoleCommand
		{
			// Token: 0x0600D573 RID: 54643 RVA: 0x003521C0 File Offset: 0x003503C0
			// Note: this type is marked as 'beforefieldinit'.
			static DisablePhysics()
			{
				Il2CppClassPointerStore<Console.DisablePhysics>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "DisablePhysics");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.DisablePhysics>.NativeClassPtr);
				Console.DisablePhysics.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisablePhysics>.NativeClassPtr, 100665533);
				Console.DisablePhysics.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisablePhysics>.NativeClassPtr, 100665534);
				Console.DisablePhysics.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisablePhysics>.NativeClassPtr, 100665535);
				Console.DisablePhysics.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisablePhysics>.NativeClassPtr, 100665536);
				Console.DisablePhysics.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisablePhysics>.NativeClassPtr, 100665537);
			}

			// Token: 0x1700410B RID: 16651
			// (get) Token: 0x0600D574 RID: 54644 RVA: 0x00352250 File Offset: 0x00350450
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85887, XrefRangeEnd = 85889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisablePhysics.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700410C RID: 16652
			// (get) Token: 0x0600D575 RID: 54645 RVA: 0x00352294 File Offset: 0x00350494
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85889, XrefRangeEnd = 85891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisablePhysics.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700410D RID: 16653
			// (get) Token: 0x0600D576 RID: 54646 RVA: 0x003522D8 File Offset: 0x003504D8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85891, XrefRangeEnd = 85893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisablePhysics.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D577 RID: 54647 RVA: 0x0035231C File Offset: 0x0035051C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85893, XrefRangeEnd = 85906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisablePhysics.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D578 RID: 54648 RVA: 0x0035236C File Offset: 0x0035056C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DisablePhysics() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.DisablePhysics>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.DisablePhysics.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D579 RID: 54649 RVA: 0x00064CEE File Offset: 0x00062EEE
			public DisablePhysics(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009163 RID: 37219
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009164 RID: 37220
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009165 RID: 37221
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009166 RID: 37222
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009167 RID: 37223
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008E0 RID: 2272
		public class EnableOcclusion : Console.ConsoleCommand
		{
			// Token: 0x0600D57A RID: 54650 RVA: 0x003523A8 File Offset: 0x003505A8
			// Note: this type is marked as 'beforefieldinit'.
			static EnableOcclusion()
			{
				Il2CppClassPointerStore<Console.EnableOcclusion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "EnableOcclusion");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.EnableOcclusion>.NativeClassPtr);
				Console.EnableOcclusion.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EnableOcclusion>.NativeClassPtr, 100665538);
				Console.EnableOcclusion.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EnableOcclusion>.NativeClassPtr, 100665539);
				Console.EnableOcclusion.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EnableOcclusion>.NativeClassPtr, 100665540);
				Console.EnableOcclusion.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EnableOcclusion>.NativeClassPtr, 100665541);
				Console.EnableOcclusion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EnableOcclusion>.NativeClassPtr, 100665542);
			}

			// Token: 0x1700410E RID: 16654
			// (get) Token: 0x0600D57B RID: 54651 RVA: 0x00352438 File Offset: 0x00350638
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85906, XrefRangeEnd = 85908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EnableOcclusion.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700410F RID: 16655
			// (get) Token: 0x0600D57C RID: 54652 RVA: 0x0035247C File Offset: 0x0035067C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85908, XrefRangeEnd = 85910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EnableOcclusion.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004110 RID: 16656
			// (get) Token: 0x0600D57D RID: 54653 RVA: 0x003524C0 File Offset: 0x003506C0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85910, XrefRangeEnd = 85912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EnableOcclusion.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D57E RID: 54654 RVA: 0x00352504 File Offset: 0x00350704
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85912, XrefRangeEnd = 85927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EnableOcclusion.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D57F RID: 54655 RVA: 0x00352554 File Offset: 0x00350754
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EnableOcclusion() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.EnableOcclusion>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.EnableOcclusion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D580 RID: 54656 RVA: 0x00064CF7 File Offset: 0x00062EF7
			public EnableOcclusion(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009168 RID: 37224
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009169 RID: 37225
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400916A RID: 37226
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400916B RID: 37227
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400916C RID: 37228
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008E1 RID: 2273
		public class DisableOcclusion : Console.ConsoleCommand
		{
			// Token: 0x0600D581 RID: 54657 RVA: 0x00352590 File Offset: 0x00350790
			// Note: this type is marked as 'beforefieldinit'.
			static DisableOcclusion()
			{
				Il2CppClassPointerStore<Console.DisableOcclusion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "DisableOcclusion");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.DisableOcclusion>.NativeClassPtr);
				Console.DisableOcclusion.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableOcclusion>.NativeClassPtr, 100665543);
				Console.DisableOcclusion.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableOcclusion>.NativeClassPtr, 100665544);
				Console.DisableOcclusion.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableOcclusion>.NativeClassPtr, 100665545);
				Console.DisableOcclusion.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableOcclusion>.NativeClassPtr, 100665546);
				Console.DisableOcclusion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableOcclusion>.NativeClassPtr, 100665547);
			}

			// Token: 0x17004111 RID: 16657
			// (get) Token: 0x0600D582 RID: 54658 RVA: 0x00352620 File Offset: 0x00350820
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85927, XrefRangeEnd = 85929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableOcclusion.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004112 RID: 16658
			// (get) Token: 0x0600D583 RID: 54659 RVA: 0x00352664 File Offset: 0x00350864
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85929, XrefRangeEnd = 85931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableOcclusion.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004113 RID: 16659
			// (get) Token: 0x0600D584 RID: 54660 RVA: 0x003526A8 File Offset: 0x003508A8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85931, XrefRangeEnd = 85933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableOcclusion.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D585 RID: 54661 RVA: 0x003526EC File Offset: 0x003508EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85933, XrefRangeEnd = 85948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableOcclusion.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D586 RID: 54662 RVA: 0x0035273C File Offset: 0x0035093C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DisableOcclusion() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.DisableOcclusion>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.DisableOcclusion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D587 RID: 54663 RVA: 0x00064D00 File Offset: 0x00062F00
			public DisableOcclusion(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400916D RID: 37229
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400916E RID: 37230
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400916F RID: 37231
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009170 RID: 37232
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009171 RID: 37233
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008E2 RID: 2274
		public class EnableTerrain : Console.ConsoleCommand
		{
			// Token: 0x0600D588 RID: 54664 RVA: 0x00352778 File Offset: 0x00350978
			// Note: this type is marked as 'beforefieldinit'.
			static EnableTerrain()
			{
				Il2CppClassPointerStore<Console.EnableTerrain>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "EnableTerrain");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.EnableTerrain>.NativeClassPtr);
				Console.EnableTerrain.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EnableTerrain>.NativeClassPtr, 100665548);
				Console.EnableTerrain.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EnableTerrain>.NativeClassPtr, 100665549);
				Console.EnableTerrain.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EnableTerrain>.NativeClassPtr, 100665550);
				Console.EnableTerrain.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EnableTerrain>.NativeClassPtr, 100665551);
				Console.EnableTerrain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EnableTerrain>.NativeClassPtr, 100665552);
			}

			// Token: 0x17004114 RID: 16660
			// (get) Token: 0x0600D589 RID: 54665 RVA: 0x00352808 File Offset: 0x00350A08
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85948, XrefRangeEnd = 85950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EnableTerrain.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004115 RID: 16661
			// (get) Token: 0x0600D58A RID: 54666 RVA: 0x0035284C File Offset: 0x00350A4C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85950, XrefRangeEnd = 85952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EnableTerrain.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004116 RID: 16662
			// (get) Token: 0x0600D58B RID: 54667 RVA: 0x00352890 File Offset: 0x00350A90
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85952, XrefRangeEnd = 85954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EnableTerrain.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D58C RID: 54668 RVA: 0x003528D4 File Offset: 0x00350AD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85954, XrefRangeEnd = 85966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EnableTerrain.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D58D RID: 54669 RVA: 0x00352924 File Offset: 0x00350B24
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EnableTerrain() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.EnableTerrain>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.EnableTerrain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D58E RID: 54670 RVA: 0x00064D09 File Offset: 0x00062F09
			public EnableTerrain(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009172 RID: 37234
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009173 RID: 37235
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009174 RID: 37236
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009175 RID: 37237
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009176 RID: 37238
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008E3 RID: 2275
		public class DisableTerrain : Console.ConsoleCommand
		{
			// Token: 0x0600D58F RID: 54671 RVA: 0x00352960 File Offset: 0x00350B60
			// Note: this type is marked as 'beforefieldinit'.
			static DisableTerrain()
			{
				Il2CppClassPointerStore<Console.DisableTerrain>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "DisableTerrain");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.DisableTerrain>.NativeClassPtr);
				Console.DisableTerrain.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableTerrain>.NativeClassPtr, 100665553);
				Console.DisableTerrain.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableTerrain>.NativeClassPtr, 100665554);
				Console.DisableTerrain.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableTerrain>.NativeClassPtr, 100665555);
				Console.DisableTerrain.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableTerrain>.NativeClassPtr, 100665556);
				Console.DisableTerrain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableTerrain>.NativeClassPtr, 100665557);
			}

			// Token: 0x17004117 RID: 16663
			// (get) Token: 0x0600D590 RID: 54672 RVA: 0x003529F0 File Offset: 0x00350BF0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85966, XrefRangeEnd = 85968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableTerrain.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004118 RID: 16664
			// (get) Token: 0x0600D591 RID: 54673 RVA: 0x00352A34 File Offset: 0x00350C34
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85968, XrefRangeEnd = 85970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableTerrain.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004119 RID: 16665
			// (get) Token: 0x0600D592 RID: 54674 RVA: 0x00352A78 File Offset: 0x00350C78
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85970, XrefRangeEnd = 85972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableTerrain.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D593 RID: 54675 RVA: 0x00352ABC File Offset: 0x00350CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85972, XrefRangeEnd = 85984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableTerrain.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D594 RID: 54676 RVA: 0x00352B0C File Offset: 0x00350D0C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DisableTerrain() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.DisableTerrain>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.DisableTerrain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D595 RID: 54677 RVA: 0x00064D12 File Offset: 0x00062F12
			public DisableTerrain(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009177 RID: 37239
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009178 RID: 37240
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009179 RID: 37241
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400917A RID: 37242
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400917B RID: 37243
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008E4 RID: 2276
		public class EnableInstancing : Console.ConsoleCommand
		{
			// Token: 0x0600D596 RID: 54678 RVA: 0x00352B48 File Offset: 0x00350D48
			// Note: this type is marked as 'beforefieldinit'.
			static EnableInstancing()
			{
				Il2CppClassPointerStore<Console.EnableInstancing>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "EnableInstancing");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.EnableInstancing>.NativeClassPtr);
				Console.EnableInstancing.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EnableInstancing>.NativeClassPtr, 100665558);
				Console.EnableInstancing.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EnableInstancing>.NativeClassPtr, 100665559);
				Console.EnableInstancing.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EnableInstancing>.NativeClassPtr, 100665560);
				Console.EnableInstancing.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EnableInstancing>.NativeClassPtr, 100665561);
				Console.EnableInstancing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EnableInstancing>.NativeClassPtr, 100665562);
			}

			// Token: 0x1700411A RID: 16666
			// (get) Token: 0x0600D597 RID: 54679 RVA: 0x00352BD8 File Offset: 0x00350DD8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85984, XrefRangeEnd = 85986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EnableInstancing.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700411B RID: 16667
			// (get) Token: 0x0600D598 RID: 54680 RVA: 0x00352C1C File Offset: 0x00350E1C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85986, XrefRangeEnd = 85988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EnableInstancing.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700411C RID: 16668
			// (get) Token: 0x0600D599 RID: 54681 RVA: 0x00352C60 File Offset: 0x00350E60
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85988, XrefRangeEnd = 85990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EnableInstancing.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D59A RID: 54682 RVA: 0x00352CA4 File Offset: 0x00350EA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85990, XrefRangeEnd = 86005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EnableInstancing.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D59B RID: 54683 RVA: 0x00352CF4 File Offset: 0x00350EF4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EnableInstancing() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.EnableInstancing>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.EnableInstancing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D59C RID: 54684 RVA: 0x00064D1B File Offset: 0x00062F1B
			public EnableInstancing(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400917C RID: 37244
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400917D RID: 37245
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400917E RID: 37246
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400917F RID: 37247
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009180 RID: 37248
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008E5 RID: 2277
		public class DisableInstancing : Console.ConsoleCommand
		{
			// Token: 0x0600D59D RID: 54685 RVA: 0x00352D30 File Offset: 0x00350F30
			// Note: this type is marked as 'beforefieldinit'.
			static DisableInstancing()
			{
				Il2CppClassPointerStore<Console.DisableInstancing>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "DisableInstancing");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.DisableInstancing>.NativeClassPtr);
				Console.DisableInstancing.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableInstancing>.NativeClassPtr, 100665563);
				Console.DisableInstancing.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableInstancing>.NativeClassPtr, 100665564);
				Console.DisableInstancing.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableInstancing>.NativeClassPtr, 100665565);
				Console.DisableInstancing.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableInstancing>.NativeClassPtr, 100665566);
				Console.DisableInstancing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableInstancing>.NativeClassPtr, 100665567);
			}

			// Token: 0x1700411D RID: 16669
			// (get) Token: 0x0600D59E RID: 54686 RVA: 0x00352DC0 File Offset: 0x00350FC0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86005, XrefRangeEnd = 86007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableInstancing.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700411E RID: 16670
			// (get) Token: 0x0600D59F RID: 54687 RVA: 0x00352E04 File Offset: 0x00351004
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86007, XrefRangeEnd = 86009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableInstancing.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700411F RID: 16671
			// (get) Token: 0x0600D5A0 RID: 54688 RVA: 0x00352E48 File Offset: 0x00351048
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86009, XrefRangeEnd = 86011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableInstancing.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D5A1 RID: 54689 RVA: 0x00352E8C File Offset: 0x0035108C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86011, XrefRangeEnd = 86026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableInstancing.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5A2 RID: 54690 RVA: 0x00352EDC File Offset: 0x003510DC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DisableInstancing() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.DisableInstancing>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.DisableInstancing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5A3 RID: 54691 RVA: 0x00064D24 File Offset: 0x00062F24
			public DisableInstancing(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009181 RID: 37249
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009182 RID: 37250
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009183 RID: 37251
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009184 RID: 37252
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009185 RID: 37253
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008E6 RID: 2278
		public class RaisedWanted : Console.ConsoleCommand
		{
			// Token: 0x0600D5A4 RID: 54692 RVA: 0x00352F18 File Offset: 0x00351118
			// Note: this type is marked as 'beforefieldinit'.
			static RaisedWanted()
			{
				Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "RaisedWanted");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr);
				Console.RaisedWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr, 100665568);
				Console.RaisedWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr, 100665569);
				Console.RaisedWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr, 100665570);
				Console.RaisedWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr, 100665571);
				Console.RaisedWanted.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr, 100665572);
			}

			// Token: 0x17004120 RID: 16672
			// (get) Token: 0x0600D5A5 RID: 54693 RVA: 0x00352FA8 File Offset: 0x003511A8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86026, XrefRangeEnd = 86028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.RaisedWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004121 RID: 16673
			// (get) Token: 0x0600D5A6 RID: 54694 RVA: 0x00352FEC File Offset: 0x003511EC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86028, XrefRangeEnd = 86030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.RaisedWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004122 RID: 16674
			// (get) Token: 0x0600D5A7 RID: 54695 RVA: 0x00353030 File Offset: 0x00351230
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86030, XrefRangeEnd = 86032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.RaisedWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D5A8 RID: 54696 RVA: 0x00353074 File Offset: 0x00351274
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86032, XrefRangeEnd = 86069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.RaisedWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5A9 RID: 54697 RVA: 0x003530C4 File Offset: 0x003512C4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RaisedWanted() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.RaisedWanted>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.RaisedWanted.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5AA RID: 54698 RVA: 0x00064D2D File Offset: 0x00062F2D
			public RaisedWanted(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009186 RID: 37254
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009187 RID: 37255
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009188 RID: 37256
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009189 RID: 37257
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400918A RID: 37258
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008E7 RID: 2279
		public class LowerWanted : Console.ConsoleCommand
		{
			// Token: 0x0600D5AB RID: 54699 RVA: 0x00353100 File Offset: 0x00351300
			// Note: this type is marked as 'beforefieldinit'.
			static LowerWanted()
			{
				Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "LowerWanted");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr);
				Console.LowerWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr, 100665573);
				Console.LowerWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr, 100665574);
				Console.LowerWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr, 100665575);
				Console.LowerWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr, 100665576);
				Console.LowerWanted.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr, 100665577);
			}

			// Token: 0x17004123 RID: 16675
			// (get) Token: 0x0600D5AC RID: 54700 RVA: 0x00353190 File Offset: 0x00351390
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86069, XrefRangeEnd = 86071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.LowerWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004124 RID: 16676
			// (get) Token: 0x0600D5AD RID: 54701 RVA: 0x003531D4 File Offset: 0x003513D4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86071, XrefRangeEnd = 86073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.LowerWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004125 RID: 16677
			// (get) Token: 0x0600D5AE RID: 54702 RVA: 0x00353218 File Offset: 0x00351418
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86073, XrefRangeEnd = 86075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.LowerWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D5AF RID: 54703 RVA: 0x0035325C File Offset: 0x0035145C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86075, XrefRangeEnd = 86090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.LowerWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5B0 RID: 54704 RVA: 0x003532AC File Offset: 0x003514AC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LowerWanted() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.LowerWanted>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.LowerWanted.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5B1 RID: 54705 RVA: 0x00064D36 File Offset: 0x00062F36
			public LowerWanted(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400918B RID: 37259
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400918C RID: 37260
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400918D RID: 37261
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400918E RID: 37262
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400918F RID: 37263
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008E8 RID: 2280
		public class ClearWanted : Console.ConsoleCommand
		{
			// Token: 0x0600D5B2 RID: 54706 RVA: 0x003532E8 File Offset: 0x003514E8
			// Note: this type is marked as 'beforefieldinit'.
			static ClearWanted()
			{
				Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ClearWanted");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr);
				Console.ClearWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr, 100665578);
				Console.ClearWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr, 100665579);
				Console.ClearWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr, 100665580);
				Console.ClearWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr, 100665581);
				Console.ClearWanted.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr, 100665582);
			}

			// Token: 0x17004126 RID: 16678
			// (get) Token: 0x0600D5B3 RID: 54707 RVA: 0x00353378 File Offset: 0x00351578
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86090, XrefRangeEnd = 86092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearWanted.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004127 RID: 16679
			// (get) Token: 0x0600D5B4 RID: 54708 RVA: 0x003533BC File Offset: 0x003515BC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86092, XrefRangeEnd = 86094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearWanted.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004128 RID: 16680
			// (get) Token: 0x0600D5B5 RID: 54709 RVA: 0x00353400 File Offset: 0x00351600
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86094, XrefRangeEnd = 86096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearWanted.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D5B6 RID: 54710 RVA: 0x00353444 File Offset: 0x00351644
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86096, XrefRangeEnd = 86116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearWanted.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5B7 RID: 54711 RVA: 0x00353494 File Offset: 0x00351694
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClearWanted() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ClearWanted>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ClearWanted.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5B8 RID: 54712 RVA: 0x00064D3F File Offset: 0x00062F3F
			public ClearWanted(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009190 RID: 37264
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009191 RID: 37265
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009192 RID: 37266
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009193 RID: 37267
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009194 RID: 37268
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008E9 RID: 2281
		public class SetHealth : Console.ConsoleCommand
		{
			// Token: 0x0600D5B9 RID: 54713 RVA: 0x003534D0 File Offset: 0x003516D0
			// Note: this type is marked as 'beforefieldinit'.
			static SetHealth()
			{
				Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetHealth");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr);
				Console.SetHealth.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr, 100665583);
				Console.SetHealth.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr, 100665584);
				Console.SetHealth.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr, 100665585);
				Console.SetHealth.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr, 100665586);
				Console.SetHealth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr, 100665587);
			}

			// Token: 0x17004129 RID: 16681
			// (get) Token: 0x0600D5BA RID: 54714 RVA: 0x00353560 File Offset: 0x00351760
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86116, XrefRangeEnd = 86118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetHealth.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700412A RID: 16682
			// (get) Token: 0x0600D5BB RID: 54715 RVA: 0x003535A4 File Offset: 0x003517A4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86118, XrefRangeEnd = 86120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetHealth.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700412B RID: 16683
			// (get) Token: 0x0600D5BC RID: 54716 RVA: 0x003535E8 File Offset: 0x003517E8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86120, XrefRangeEnd = 86122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetHealth.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D5BD RID: 54717 RVA: 0x0035362C File Offset: 0x0035182C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86122, XrefRangeEnd = 86149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetHealth.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5BE RID: 54718 RVA: 0x0035367C File Offset: 0x0035187C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetHealth() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetHealth>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetHealth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5BF RID: 54719 RVA: 0x00064D48 File Offset: 0x00062F48
			public SetHealth(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009195 RID: 37269
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009196 RID: 37270
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009197 RID: 37271
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009198 RID: 37272
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009199 RID: 37273
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008EA RID: 2282
		public class FreeCamCommand : Console.ConsoleCommand
		{
			// Token: 0x0600D5C0 RID: 54720 RVA: 0x003536B8 File Offset: 0x003518B8
			// Note: this type is marked as 'beforefieldinit'.
			static FreeCamCommand()
			{
				Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "FreeCamCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr);
				Console.FreeCamCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr, 100665588);
				Console.FreeCamCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr, 100665589);
				Console.FreeCamCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr, 100665590);
				Console.FreeCamCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr, 100665591);
				Console.FreeCamCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr, 100665592);
			}

			// Token: 0x1700412C RID: 16684
			// (get) Token: 0x0600D5C1 RID: 54721 RVA: 0x00353748 File Offset: 0x00351948
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86149, XrefRangeEnd = 86151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.FreeCamCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700412D RID: 16685
			// (get) Token: 0x0600D5C2 RID: 54722 RVA: 0x0035378C File Offset: 0x0035198C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86151, XrefRangeEnd = 86153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.FreeCamCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700412E RID: 16686
			// (get) Token: 0x0600D5C3 RID: 54723 RVA: 0x003537D0 File Offset: 0x003519D0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86153, XrefRangeEnd = 86155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.FreeCamCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D5C4 RID: 54724 RVA: 0x00353814 File Offset: 0x00351A14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86155, XrefRangeEnd = 86168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.FreeCamCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5C5 RID: 54725 RVA: 0x00353864 File Offset: 0x00351A64
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FreeCamCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.FreeCamCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.FreeCamCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5C6 RID: 54726 RVA: 0x00064D51 File Offset: 0x00062F51
			public FreeCamCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400919A RID: 37274
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400919B RID: 37275
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400919C RID: 37276
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400919D RID: 37277
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400919E RID: 37278
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008EB RID: 2283
		public class Save : Console.ConsoleCommand
		{
			// Token: 0x0600D5C7 RID: 54727 RVA: 0x003538A0 File Offset: 0x00351AA0
			// Note: this type is marked as 'beforefieldinit'.
			static Save()
			{
				Il2CppClassPointerStore<Console.Save>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Save");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Save>.NativeClassPtr);
				Console.Save.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Save>.NativeClassPtr, 100665593);
				Console.Save.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Save>.NativeClassPtr, 100665594);
				Console.Save.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Save>.NativeClassPtr, 100665595);
				Console.Save.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Save>.NativeClassPtr, 100665596);
				Console.Save.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Save>.NativeClassPtr, 100665597);
			}

			// Token: 0x1700412F RID: 16687
			// (get) Token: 0x0600D5C8 RID: 54728 RVA: 0x00353930 File Offset: 0x00351B30
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86168, XrefRangeEnd = 86170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Save.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004130 RID: 16688
			// (get) Token: 0x0600D5C9 RID: 54729 RVA: 0x00353974 File Offset: 0x00351B74
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86170, XrefRangeEnd = 86172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Save.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004131 RID: 16689
			// (get) Token: 0x0600D5CA RID: 54730 RVA: 0x003539B8 File Offset: 0x00351BB8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86172, XrefRangeEnd = 86174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Save.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D5CB RID: 54731 RVA: 0x003539FC File Offset: 0x00351BFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86174, XrefRangeEnd = 86189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Save.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5CC RID: 54732 RVA: 0x00353A4C File Offset: 0x00351C4C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Save() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Save>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Save.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5CD RID: 54733 RVA: 0x00064D5A File Offset: 0x00062F5A
			public Save(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400919F RID: 37279
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040091A0 RID: 37280
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040091A1 RID: 37281
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040091A2 RID: 37282
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040091A3 RID: 37283
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008EC RID: 2284
		public class SetTimeScale : Console.ConsoleCommand
		{
			// Token: 0x0600D5CE RID: 54734 RVA: 0x00353A88 File Offset: 0x00351C88
			// Note: this type is marked as 'beforefieldinit'.
			static SetTimeScale()
			{
				Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetTimeScale");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr);
				Console.SetTimeScale.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr, 100665598);
				Console.SetTimeScale.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr, 100665599);
				Console.SetTimeScale.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr, 100665600);
				Console.SetTimeScale.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr, 100665601);
				Console.SetTimeScale.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr, 100665602);
			}

			// Token: 0x17004132 RID: 16690
			// (get) Token: 0x0600D5CF RID: 54735 RVA: 0x00353B18 File Offset: 0x00351D18
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86189, XrefRangeEnd = 86191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeScale.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004133 RID: 16691
			// (get) Token: 0x0600D5D0 RID: 54736 RVA: 0x00353B5C File Offset: 0x00351D5C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86191, XrefRangeEnd = 86193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeScale.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004134 RID: 16692
			// (get) Token: 0x0600D5D1 RID: 54737 RVA: 0x00353BA0 File Offset: 0x00351DA0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86193, XrefRangeEnd = 86195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeScale.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D5D2 RID: 54738 RVA: 0x00353BE4 File Offset: 0x00351DE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86195, XrefRangeEnd = 86216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetTimeScale.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5D3 RID: 54739 RVA: 0x00353C34 File Offset: 0x00351E34
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetTimeScale() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetTimeScale>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetTimeScale.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5D4 RID: 54740 RVA: 0x00064D63 File Offset: 0x00062F63
			public SetTimeScale(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040091A4 RID: 37284
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040091A5 RID: 37285
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040091A6 RID: 37286
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040091A7 RID: 37287
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040091A8 RID: 37288
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008ED RID: 2285
		public class SetVariableValue : Console.ConsoleCommand
		{
			// Token: 0x0600D5D5 RID: 54741 RVA: 0x00353C70 File Offset: 0x00351E70
			// Note: this type is marked as 'beforefieldinit'.
			static SetVariableValue()
			{
				Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetVariableValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr);
				Console.SetVariableValue.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr, 100665603);
				Console.SetVariableValue.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr, 100665604);
				Console.SetVariableValue.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr, 100665605);
				Console.SetVariableValue.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr, 100665606);
				Console.SetVariableValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr, 100665607);
			}

			// Token: 0x17004135 RID: 16693
			// (get) Token: 0x0600D5D6 RID: 54742 RVA: 0x00353D00 File Offset: 0x00351F00
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86216, XrefRangeEnd = 86218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetVariableValue.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004136 RID: 16694
			// (get) Token: 0x0600D5D7 RID: 54743 RVA: 0x00353D44 File Offset: 0x00351F44
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86218, XrefRangeEnd = 86220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetVariableValue.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004137 RID: 16695
			// (get) Token: 0x0600D5D8 RID: 54744 RVA: 0x00353D88 File Offset: 0x00351F88
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86220, XrefRangeEnd = 86222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetVariableValue.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D5D9 RID: 54745 RVA: 0x00353DCC File Offset: 0x00351FCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86222, XrefRangeEnd = 86244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetVariableValue.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5DA RID: 54746 RVA: 0x00353E1C File Offset: 0x0035201C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetVariableValue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetVariableValue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetVariableValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5DB RID: 54747 RVA: 0x00064D6C File Offset: 0x00062F6C
			public SetVariableValue(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040091A9 RID: 37289
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040091AA RID: 37290
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040091AB RID: 37291
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040091AC RID: 37292
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040091AD RID: 37293
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008EE RID: 2286
		public class SetQuestState : Console.ConsoleCommand
		{
			// Token: 0x0600D5DC RID: 54748 RVA: 0x00353E58 File Offset: 0x00352058
			// Note: this type is marked as 'beforefieldinit'.
			static SetQuestState()
			{
				Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetQuestState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr);
				Console.SetQuestState.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr, 100665608);
				Console.SetQuestState.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr, 100665609);
				Console.SetQuestState.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr, 100665610);
				Console.SetQuestState.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr, 100665611);
				Console.SetQuestState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr, 100665612);
			}

			// Token: 0x17004138 RID: 16696
			// (get) Token: 0x0600D5DD RID: 54749 RVA: 0x00353EE8 File Offset: 0x003520E8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86244, XrefRangeEnd = 86246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestState.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004139 RID: 16697
			// (get) Token: 0x0600D5DE RID: 54750 RVA: 0x00353F2C File Offset: 0x0035212C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86246, XrefRangeEnd = 86248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestState.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700413A RID: 16698
			// (get) Token: 0x0600D5DF RID: 54751 RVA: 0x00353F70 File Offset: 0x00352170
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86248, XrefRangeEnd = 86250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestState.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D5E0 RID: 54752 RVA: 0x00353FB4 File Offset: 0x003521B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86250, XrefRangeEnd = 86295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestState.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5E1 RID: 54753 RVA: 0x00354004 File Offset: 0x00352204
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetQuestState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetQuestState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetQuestState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5E2 RID: 54754 RVA: 0x00064D75 File Offset: 0x00062F75
			public SetQuestState(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040091AE RID: 37294
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040091AF RID: 37295
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040091B0 RID: 37296
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040091B1 RID: 37297
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040091B2 RID: 37298
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008EF RID: 2287
		public class SetQuestEntryState : Console.ConsoleCommand
		{
			// Token: 0x0600D5E3 RID: 54755 RVA: 0x00354040 File Offset: 0x00352240
			// Note: this type is marked as 'beforefieldinit'.
			static SetQuestEntryState()
			{
				Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetQuestEntryState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr);
				Console.SetQuestEntryState.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr, 100665613);
				Console.SetQuestEntryState.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr, 100665614);
				Console.SetQuestEntryState.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr, 100665615);
				Console.SetQuestEntryState.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr, 100665616);
				Console.SetQuestEntryState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr, 100665617);
			}

			// Token: 0x1700413B RID: 16699
			// (get) Token: 0x0600D5E4 RID: 54756 RVA: 0x003540D0 File Offset: 0x003522D0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86295, XrefRangeEnd = 86297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestEntryState.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700413C RID: 16700
			// (get) Token: 0x0600D5E5 RID: 54757 RVA: 0x00354114 File Offset: 0x00352314
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86297, XrefRangeEnd = 86299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestEntryState.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700413D RID: 16701
			// (get) Token: 0x0600D5E6 RID: 54758 RVA: 0x00354158 File Offset: 0x00352358
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86299, XrefRangeEnd = 86301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestEntryState.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D5E7 RID: 54759 RVA: 0x0035419C File Offset: 0x0035239C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86301, XrefRangeEnd = 86363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuestEntryState.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5E8 RID: 54760 RVA: 0x003541EC File Offset: 0x003523EC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetQuestEntryState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetQuestEntryState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetQuestEntryState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5E9 RID: 54761 RVA: 0x00064D7E File Offset: 0x00062F7E
			public SetQuestEntryState(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040091B3 RID: 37299
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040091B4 RID: 37300
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040091B5 RID: 37301
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040091B6 RID: 37302
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040091B7 RID: 37303
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008F0 RID: 2288
		public class SetEmotion : Console.ConsoleCommand
		{
			// Token: 0x0600D5EA RID: 54762 RVA: 0x00354228 File Offset: 0x00352428
			// Note: this type is marked as 'beforefieldinit'.
			static SetEmotion()
			{
				Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetEmotion");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr);
				Console.SetEmotion.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr, 100665618);
				Console.SetEmotion.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr, 100665619);
				Console.SetEmotion.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr, 100665620);
				Console.SetEmotion.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr, 100665621);
				Console.SetEmotion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr, 100665622);
			}

			// Token: 0x1700413E RID: 16702
			// (get) Token: 0x0600D5EB RID: 54763 RVA: 0x003542B8 File Offset: 0x003524B8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86363, XrefRangeEnd = 86365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEmotion.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700413F RID: 16703
			// (get) Token: 0x0600D5EC RID: 54764 RVA: 0x003542FC File Offset: 0x003524FC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86365, XrefRangeEnd = 86367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEmotion.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004140 RID: 16704
			// (get) Token: 0x0600D5ED RID: 54765 RVA: 0x00354340 File Offset: 0x00352540
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86367, XrefRangeEnd = 86369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEmotion.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D5EE RID: 54766 RVA: 0x00354384 File Offset: 0x00352584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86369, XrefRangeEnd = 86400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetEmotion.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5EF RID: 54767 RVA: 0x003543D4 File Offset: 0x003525D4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetEmotion() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetEmotion>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetEmotion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5F0 RID: 54768 RVA: 0x00064D87 File Offset: 0x00062F87
			public SetEmotion(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040091B8 RID: 37304
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040091B9 RID: 37305
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040091BA RID: 37306
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040091BB RID: 37307
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040091BC RID: 37308
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008F1 RID: 2289
		public class SetUnlocked : Console.ConsoleCommand
		{
			// Token: 0x0600D5F1 RID: 54769 RVA: 0x00354410 File Offset: 0x00352610
			// Note: this type is marked as 'beforefieldinit'.
			static SetUnlocked()
			{
				Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetUnlocked");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr);
				Console.SetUnlocked.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr, 100665623);
				Console.SetUnlocked.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr, 100665624);
				Console.SetUnlocked.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr, 100665625);
				Console.SetUnlocked.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr, 100665626);
				Console.SetUnlocked.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr, 100665627);
			}

			// Token: 0x17004141 RID: 16705
			// (get) Token: 0x0600D5F2 RID: 54770 RVA: 0x003544A0 File Offset: 0x003526A0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86400, XrefRangeEnd = 86402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetUnlocked.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004142 RID: 16706
			// (get) Token: 0x0600D5F3 RID: 54771 RVA: 0x003544E4 File Offset: 0x003526E4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86402, XrefRangeEnd = 86404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetUnlocked.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004143 RID: 16707
			// (get) Token: 0x0600D5F4 RID: 54772 RVA: 0x00354528 File Offset: 0x00352728
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86404, XrefRangeEnd = 86406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetUnlocked.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D5F5 RID: 54773 RVA: 0x0035456C File Offset: 0x0035276C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86406, XrefRangeEnd = 86436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetUnlocked.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5F6 RID: 54774 RVA: 0x003545BC File Offset: 0x003527BC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetUnlocked() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetUnlocked>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetUnlocked.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5F7 RID: 54775 RVA: 0x00064D90 File Offset: 0x00062F90
			public SetUnlocked(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040091BD RID: 37309
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040091BE RID: 37310
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040091BF RID: 37311
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040091C0 RID: 37312
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040091C1 RID: 37313
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008F2 RID: 2290
		public class SetRelationship : Console.ConsoleCommand
		{
			// Token: 0x0600D5F8 RID: 54776 RVA: 0x003545F8 File Offset: 0x003527F8
			// Note: this type is marked as 'beforefieldinit'.
			static SetRelationship()
			{
				Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetRelationship");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr);
				Console.SetRelationship.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr, 100665628);
				Console.SetRelationship.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr, 100665629);
				Console.SetRelationship.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr, 100665630);
				Console.SetRelationship.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr, 100665631);
				Console.SetRelationship.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr, 100665632);
			}

			// Token: 0x17004144 RID: 16708
			// (get) Token: 0x0600D5F9 RID: 54777 RVA: 0x00354688 File Offset: 0x00352888
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86436, XrefRangeEnd = 86438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetRelationship.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004145 RID: 16709
			// (get) Token: 0x0600D5FA RID: 54778 RVA: 0x003546CC File Offset: 0x003528CC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86438, XrefRangeEnd = 86440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetRelationship.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004146 RID: 16710
			// (get) Token: 0x0600D5FB RID: 54779 RVA: 0x00354710 File Offset: 0x00352910
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86440, XrefRangeEnd = 86442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetRelationship.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D5FC RID: 54780 RVA: 0x00354754 File Offset: 0x00352954
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86442, XrefRangeEnd = 86466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetRelationship.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5FD RID: 54781 RVA: 0x003547A4 File Offset: 0x003529A4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetRelationship() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetRelationship>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetRelationship.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D5FE RID: 54782 RVA: 0x00064D99 File Offset: 0x00062F99
			public SetRelationship(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040091C2 RID: 37314
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040091C3 RID: 37315
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040091C4 RID: 37316
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040091C5 RID: 37317
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040091C6 RID: 37318
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008F3 RID: 2291
		public class AddEmployeeCommand : Console.ConsoleCommand
		{
			// Token: 0x0600D5FF RID: 54783 RVA: 0x003547E0 File Offset: 0x003529E0
			// Note: this type is marked as 'beforefieldinit'.
			static AddEmployeeCommand()
			{
				Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "AddEmployeeCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr);
				Console.AddEmployeeCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, 100665633);
				Console.AddEmployeeCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, 100665634);
				Console.AddEmployeeCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, 100665635);
				Console.AddEmployeeCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, 100665636);
				Console.AddEmployeeCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, 100665637);
			}

			// Token: 0x17004147 RID: 16711
			// (get) Token: 0x0600D600 RID: 54784 RVA: 0x00354870 File Offset: 0x00352A70
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86466, XrefRangeEnd = 86468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddEmployeeCommand.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004148 RID: 16712
			// (get) Token: 0x0600D601 RID: 54785 RVA: 0x003548B4 File Offset: 0x00352AB4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86468, XrefRangeEnd = 86470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddEmployeeCommand.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004149 RID: 16713
			// (get) Token: 0x0600D602 RID: 54786 RVA: 0x003548F8 File Offset: 0x00352AF8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86470, XrefRangeEnd = 86472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddEmployeeCommand.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D603 RID: 54787 RVA: 0x0035493C File Offset: 0x00352B3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86472, XrefRangeEnd = 86502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.AddEmployeeCommand.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D604 RID: 54788 RVA: 0x0035498C File Offset: 0x00352B8C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddEmployeeCommand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.AddEmployeeCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D605 RID: 54789 RVA: 0x00064DA2 File Offset: 0x00062FA2
			public AddEmployeeCommand(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040091C7 RID: 37319
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040091C8 RID: 37320
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040091C9 RID: 37321
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040091CA RID: 37322
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040091CB RID: 37323
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000DAE RID: 3502
			[ObfuscatedName("ScheduleOne.Console+AddEmployeeCommand+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
			{
				// Token: 0x0600FD32 RID: 64818 RVA: 0x003C4FD0 File Offset: 0x003C31D0
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console.AddEmployeeCommand>.NativeClassPtr, "<>c__DisplayClass6_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr);
					Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr, "code");
					Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr, 100665638);
					Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr, 100665639);
				}

				// Token: 0x0600FD33 RID: 64819 RVA: 0x003C5038 File Offset: 0x003C3238
				[CallerCount(2575)]
				[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.AddEmployeeCommand.__c__DisplayClass6_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FD34 RID: 64820 RVA: 0x003C5074 File Offset: 0x003C3274
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Execute_b__0(Property x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600FD35 RID: 64821 RVA: 0x00077E69 File Offset: 0x00076069
				public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004CF0 RID: 19696
				// (get) Token: 0x0600FD36 RID: 64822 RVA: 0x003C50C4 File Offset: 0x003C32C4
				// (set) Token: 0x0600FD37 RID: 64823 RVA: 0x00077E72 File Offset: 0x00076072
				public unsafe string code
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeFieldInfoPtr_code);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.AddEmployeeCommand.__c__DisplayClass6_0.NativeFieldInfoPtr_code), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x0400AABB RID: 43707
				private static readonly IntPtr NativeFieldInfoPtr_code;

				// Token: 0x0400AABC RID: 43708
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400AABD RID: 43709
				private static readonly IntPtr NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_Property_0;
			}
		}

		// Token: 0x020008F4 RID: 2292
		public class SetDiscovered : Console.ConsoleCommand
		{
			// Token: 0x0600D606 RID: 54790 RVA: 0x003549C8 File Offset: 0x00352BC8
			// Note: this type is marked as 'beforefieldinit'.
			static SetDiscovered()
			{
				Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetDiscovered");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr);
				Console.SetDiscovered.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr, 100665640);
				Console.SetDiscovered.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr, 100665641);
				Console.SetDiscovered.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr, 100665642);
				Console.SetDiscovered.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr, 100665643);
				Console.SetDiscovered.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr, 100665644);
			}

			// Token: 0x1700414A RID: 16714
			// (get) Token: 0x0600D607 RID: 54791 RVA: 0x00354A58 File Offset: 0x00352C58
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86502, XrefRangeEnd = 86504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetDiscovered.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700414B RID: 16715
			// (get) Token: 0x0600D608 RID: 54792 RVA: 0x00354A9C File Offset: 0x00352C9C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86504, XrefRangeEnd = 86506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetDiscovered.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700414C RID: 16716
			// (get) Token: 0x0600D609 RID: 54793 RVA: 0x00354AE0 File Offset: 0x00352CE0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86506, XrefRangeEnd = 86508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetDiscovered.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D60A RID: 54794 RVA: 0x00354B24 File Offset: 0x00352D24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86508, XrefRangeEnd = 86552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetDiscovered.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D60B RID: 54795 RVA: 0x00354B74 File Offset: 0x00352D74
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetDiscovered() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetDiscovered>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetDiscovered.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D60C RID: 54796 RVA: 0x00064DAB File Offset: 0x00062FAB
			public SetDiscovered(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040091CC RID: 37324
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040091CD RID: 37325
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040091CE RID: 37326
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040091CF RID: 37327
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040091D0 RID: 37328
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008F5 RID: 2293
		public class GrowPlants : Console.ConsoleCommand
		{
			// Token: 0x0600D60D RID: 54797 RVA: 0x00354BB0 File Offset: 0x00352DB0
			// Note: this type is marked as 'beforefieldinit'.
			static GrowPlants()
			{
				Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "GrowPlants");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr);
				Console.GrowPlants.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr, 100665645);
				Console.GrowPlants.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr, 100665646);
				Console.GrowPlants.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr, 100665647);
				Console.GrowPlants.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr, 100665648);
				Console.GrowPlants.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr, 100665649);
			}

			// Token: 0x1700414D RID: 16717
			// (get) Token: 0x0600D60E RID: 54798 RVA: 0x00354C40 File Offset: 0x00352E40
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86552, XrefRangeEnd = 86554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GrowPlants.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700414E RID: 16718
			// (get) Token: 0x0600D60F RID: 54799 RVA: 0x00354C84 File Offset: 0x00352E84
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86554, XrefRangeEnd = 86556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GrowPlants.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700414F RID: 16719
			// (get) Token: 0x0600D610 RID: 54800 RVA: 0x00354CC8 File Offset: 0x00352EC8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86556, XrefRangeEnd = 86558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GrowPlants.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D611 RID: 54801 RVA: 0x00354D0C File Offset: 0x00352F0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86558, XrefRangeEnd = 86573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GrowPlants.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D612 RID: 54802 RVA: 0x00354D5C File Offset: 0x00352F5C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GrowPlants() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.GrowPlants>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.GrowPlants.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D613 RID: 54803 RVA: 0x00064DB4 File Offset: 0x00062FB4
			public GrowPlants(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040091D1 RID: 37329
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040091D2 RID: 37330
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040091D3 RID: 37331
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040091D4 RID: 37332
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040091D5 RID: 37333
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008F6 RID: 2294
		public class SetLawIntensity : Console.ConsoleCommand
		{
			// Token: 0x0600D614 RID: 54804 RVA: 0x00354D98 File Offset: 0x00352F98
			// Note: this type is marked as 'beforefieldinit'.
			static SetLawIntensity()
			{
				Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetLawIntensity");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr);
				Console.SetLawIntensity.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr, 100665650);
				Console.SetLawIntensity.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr, 100665651);
				Console.SetLawIntensity.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr, 100665652);
				Console.SetLawIntensity.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr, 100665653);
				Console.SetLawIntensity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr, 100665654);
			}

			// Token: 0x17004150 RID: 16720
			// (get) Token: 0x0600D615 RID: 54805 RVA: 0x00354E28 File Offset: 0x00353028
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86573, XrefRangeEnd = 86575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetLawIntensity.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004151 RID: 16721
			// (get) Token: 0x0600D616 RID: 54806 RVA: 0x00354E6C File Offset: 0x0035306C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86575, XrefRangeEnd = 86577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetLawIntensity.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004152 RID: 16722
			// (get) Token: 0x0600D617 RID: 54807 RVA: 0x00354EB0 File Offset: 0x003530B0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86577, XrefRangeEnd = 86579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetLawIntensity.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D618 RID: 54808 RVA: 0x00354EF4 File Offset: 0x003530F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86579, XrefRangeEnd = 86598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetLawIntensity.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D619 RID: 54809 RVA: 0x00354F44 File Offset: 0x00353144
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetLawIntensity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetLawIntensity>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetLawIntensity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D61A RID: 54810 RVA: 0x00064DBD File Offset: 0x00062FBD
			public SetLawIntensity(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040091D6 RID: 37334
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040091D7 RID: 37335
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040091D8 RID: 37336
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040091D9 RID: 37337
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040091DA RID: 37338
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008F7 RID: 2295
		public class SetQuality : Console.ConsoleCommand
		{
			// Token: 0x0600D61B RID: 54811 RVA: 0x00354F80 File Offset: 0x00353180
			// Note: this type is marked as 'beforefieldinit'.
			static SetQuality()
			{
				Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetQuality");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr);
				Console.SetQuality.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr, 100665655);
				Console.SetQuality.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr, 100665656);
				Console.SetQuality.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr, 100665657);
				Console.SetQuality.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr, 100665658);
				Console.SetQuality.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr, 100665659);
			}

			// Token: 0x17004153 RID: 16723
			// (get) Token: 0x0600D61C RID: 54812 RVA: 0x00355010 File Offset: 0x00353210
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86598, XrefRangeEnd = 86600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuality.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004154 RID: 16724
			// (get) Token: 0x0600D61D RID: 54813 RVA: 0x00355054 File Offset: 0x00353254
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86600, XrefRangeEnd = 86602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuality.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004155 RID: 16725
			// (get) Token: 0x0600D61E RID: 54814 RVA: 0x00355098 File Offset: 0x00353298
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86602, XrefRangeEnd = 86604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuality.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D61F RID: 54815 RVA: 0x003550DC File Offset: 0x003532DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86604, XrefRangeEnd = 86623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuality.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D620 RID: 54816 RVA: 0x0035512C File Offset: 0x0035332C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetQuality() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetQuality>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetQuality.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D621 RID: 54817 RVA: 0x00064DC6 File Offset: 0x00062FC6
			public SetQuality(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040091DB RID: 37339
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040091DC RID: 37340
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040091DD RID: 37341
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040091DE RID: 37342
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040091DF RID: 37343
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008F8 RID: 2296
		public class SetQuantity : Console.ConsoleCommand
		{
			// Token: 0x0600D622 RID: 54818 RVA: 0x00355168 File Offset: 0x00353368
			// Note: this type is marked as 'beforefieldinit'.
			static SetQuantity()
			{
				Il2CppClassPointerStore<Console.SetQuantity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetQuantity");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetQuantity>.NativeClassPtr);
				Console.SetQuantity.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuantity>.NativeClassPtr, 100665660);
				Console.SetQuantity.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuantity>.NativeClassPtr, 100665661);
				Console.SetQuantity.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuantity>.NativeClassPtr, 100665662);
				Console.SetQuantity.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuantity>.NativeClassPtr, 100665663);
				Console.SetQuantity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetQuantity>.NativeClassPtr, 100665664);
			}

			// Token: 0x17004156 RID: 16726
			// (get) Token: 0x0600D623 RID: 54819 RVA: 0x003551F8 File Offset: 0x003533F8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86623, XrefRangeEnd = 86625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuantity.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004157 RID: 16727
			// (get) Token: 0x0600D624 RID: 54820 RVA: 0x0035523C File Offset: 0x0035343C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86625, XrefRangeEnd = 86627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuantity.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004158 RID: 16728
			// (get) Token: 0x0600D625 RID: 54821 RVA: 0x00355280 File Offset: 0x00353480
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86627, XrefRangeEnd = 86629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuantity.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D626 RID: 54822 RVA: 0x003552C4 File Offset: 0x003534C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86629, XrefRangeEnd = 86643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetQuantity.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D627 RID: 54823 RVA: 0x00355314 File Offset: 0x00353514
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetQuantity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetQuantity>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetQuantity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D628 RID: 54824 RVA: 0x00064DCF File Offset: 0x00062FCF
			public SetQuantity(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040091E0 RID: 37344
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040091E1 RID: 37345
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040091E2 RID: 37346
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040091E3 RID: 37347
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040091E4 RID: 37348
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008F9 RID: 2297
		public class Bind : Console.ConsoleCommand
		{
			// Token: 0x0600D629 RID: 54825 RVA: 0x00355350 File Offset: 0x00353550
			// Note: this type is marked as 'beforefieldinit'.
			static Bind()
			{
				Il2CppClassPointerStore<Console.Bind>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Bind");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr);
				Console.Bind.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr, 100665665);
				Console.Bind.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr, 100665666);
				Console.Bind.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr, 100665667);
				Console.Bind.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr, 100665668);
				Console.Bind.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr, 100665669);
			}

			// Token: 0x17004159 RID: 16729
			// (get) Token: 0x0600D62A RID: 54826 RVA: 0x003553E0 File Offset: 0x003535E0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86643, XrefRangeEnd = 86645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Bind.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700415A RID: 16730
			// (get) Token: 0x0600D62B RID: 54827 RVA: 0x00355424 File Offset: 0x00353624
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86645, XrefRangeEnd = 86647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Bind.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700415B RID: 16731
			// (get) Token: 0x0600D62C RID: 54828 RVA: 0x00355468 File Offset: 0x00353668
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86647, XrefRangeEnd = 86649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Bind.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D62D RID: 54829 RVA: 0x003554AC File Offset: 0x003536AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86649, XrefRangeEnd = 86666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Bind.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D62E RID: 54830 RVA: 0x003554FC File Offset: 0x003536FC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Bind() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Bind>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Bind.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D62F RID: 54831 RVA: 0x00064DD8 File Offset: 0x00062FD8
			public Bind(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040091E5 RID: 37349
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040091E6 RID: 37350
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040091E7 RID: 37351
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040091E8 RID: 37352
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040091E9 RID: 37353
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008FA RID: 2298
		public class Unbind : Console.ConsoleCommand
		{
			// Token: 0x0600D630 RID: 54832 RVA: 0x00355538 File Offset: 0x00353738
			// Note: this type is marked as 'beforefieldinit'.
			static Unbind()
			{
				Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Unbind");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr);
				Console.Unbind.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr, 100665670);
				Console.Unbind.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr, 100665671);
				Console.Unbind.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr, 100665672);
				Console.Unbind.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr, 100665673);
				Console.Unbind.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr, 100665674);
			}

			// Token: 0x1700415C RID: 16732
			// (get) Token: 0x0600D631 RID: 54833 RVA: 0x003555C8 File Offset: 0x003537C8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86666, XrefRangeEnd = 86668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Unbind.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700415D RID: 16733
			// (get) Token: 0x0600D632 RID: 54834 RVA: 0x0035560C File Offset: 0x0035380C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86668, XrefRangeEnd = 86670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Unbind.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700415E RID: 16734
			// (get) Token: 0x0600D633 RID: 54835 RVA: 0x00355650 File Offset: 0x00353850
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86670, XrefRangeEnd = 86672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Unbind.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D634 RID: 54836 RVA: 0x00355694 File Offset: 0x00353894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86672, XrefRangeEnd = 86687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Unbind.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D635 RID: 54837 RVA: 0x003556E4 File Offset: 0x003538E4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Unbind() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Unbind>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Unbind.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D636 RID: 54838 RVA: 0x00064DE1 File Offset: 0x00062FE1
			public Unbind(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040091EA RID: 37354
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040091EB RID: 37355
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040091EC RID: 37356
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040091ED RID: 37357
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040091EE RID: 37358
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008FB RID: 2299
		public class ClearBinds : Console.ConsoleCommand
		{
			// Token: 0x0600D637 RID: 54839 RVA: 0x00355720 File Offset: 0x00353920
			// Note: this type is marked as 'beforefieldinit'.
			static ClearBinds()
			{
				Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ClearBinds");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr);
				Console.ClearBinds.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr, 100665675);
				Console.ClearBinds.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr, 100665676);
				Console.ClearBinds.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr, 100665677);
				Console.ClearBinds.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr, 100665678);
				Console.ClearBinds.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr, 100665679);
			}

			// Token: 0x1700415F RID: 16735
			// (get) Token: 0x0600D638 RID: 54840 RVA: 0x003557B0 File Offset: 0x003539B0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86687, XrefRangeEnd = 86689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearBinds.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004160 RID: 16736
			// (get) Token: 0x0600D639 RID: 54841 RVA: 0x003557F4 File Offset: 0x003539F4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86689, XrefRangeEnd = 86691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearBinds.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004161 RID: 16737
			// (get) Token: 0x0600D63A RID: 54842 RVA: 0x00355838 File Offset: 0x00353A38
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86691, XrefRangeEnd = 86693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearBinds.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D63B RID: 54843 RVA: 0x0035587C File Offset: 0x00353A7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86693, XrefRangeEnd = 86710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearBinds.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D63C RID: 54844 RVA: 0x003558CC File Offset: 0x00353ACC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClearBinds() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ClearBinds>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ClearBinds.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D63D RID: 54845 RVA: 0x00064DEA File Offset: 0x00062FEA
			public ClearBinds(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040091EF RID: 37359
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040091F0 RID: 37360
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040091F1 RID: 37361
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040091F2 RID: 37362
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040091F3 RID: 37363
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008FC RID: 2300
		public class HideUI : Console.ConsoleCommand
		{
			// Token: 0x0600D63E RID: 54846 RVA: 0x00355908 File Offset: 0x00353B08
			// Note: this type is marked as 'beforefieldinit'.
			static HideUI()
			{
				Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "HideUI");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr);
				Console.HideUI.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr, 100665680);
				Console.HideUI.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr, 100665681);
				Console.HideUI.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr, 100665682);
				Console.HideUI.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr, 100665683);
				Console.HideUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr, 100665684);
			}

			// Token: 0x17004162 RID: 16738
			// (get) Token: 0x0600D63F RID: 54847 RVA: 0x00355998 File Offset: 0x00353B98
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86710, XrefRangeEnd = 86712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideUI.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004163 RID: 16739
			// (get) Token: 0x0600D640 RID: 54848 RVA: 0x003559DC File Offset: 0x00353BDC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86712, XrefRangeEnd = 86714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideUI.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004164 RID: 16740
			// (get) Token: 0x0600D641 RID: 54849 RVA: 0x00355A20 File Offset: 0x00353C20
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86714, XrefRangeEnd = 86716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideUI.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D642 RID: 54850 RVA: 0x00355A64 File Offset: 0x00353C64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86716, XrefRangeEnd = 86722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideUI.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D643 RID: 54851 RVA: 0x00355AB4 File Offset: 0x00353CB4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HideUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.HideUI>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.HideUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D644 RID: 54852 RVA: 0x00064DF3 File Offset: 0x00062FF3
			public HideUI(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040091F4 RID: 37364
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040091F5 RID: 37365
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040091F6 RID: 37366
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040091F7 RID: 37367
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040091F8 RID: 37368
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008FD RID: 2301
		public class GiveXP : Console.ConsoleCommand
		{
			// Token: 0x0600D645 RID: 54853 RVA: 0x00355AF0 File Offset: 0x00353CF0
			// Note: this type is marked as 'beforefieldinit'.
			static GiveXP()
			{
				Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "GiveXP");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr);
				Console.GiveXP.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr, 100665685);
				Console.GiveXP.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr, 100665686);
				Console.GiveXP.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr, 100665687);
				Console.GiveXP.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr, 100665688);
				Console.GiveXP.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr, 100665689);
			}

			// Token: 0x17004165 RID: 16741
			// (get) Token: 0x0600D646 RID: 54854 RVA: 0x00355B80 File Offset: 0x00353D80
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86722, XrefRangeEnd = 86724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GiveXP.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004166 RID: 16742
			// (get) Token: 0x0600D647 RID: 54855 RVA: 0x00355BC4 File Offset: 0x00353DC4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86724, XrefRangeEnd = 86726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GiveXP.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004167 RID: 16743
			// (get) Token: 0x0600D648 RID: 54856 RVA: 0x00355C08 File Offset: 0x00353E08
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86726, XrefRangeEnd = 86728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GiveXP.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D649 RID: 54857 RVA: 0x00355C4C File Offset: 0x00353E4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86728, XrefRangeEnd = 86749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.GiveXP.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D64A RID: 54858 RVA: 0x00355C9C File Offset: 0x00353E9C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GiveXP() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.GiveXP>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.GiveXP.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D64B RID: 54859 RVA: 0x00064DFC File Offset: 0x00062FFC
			public GiveXP(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040091F9 RID: 37369
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040091FA RID: 37370
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x040091FB RID: 37371
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x040091FC RID: 37372
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x040091FD RID: 37373
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008FE RID: 2302
		public class Disable : Console.ConsoleCommand
		{
			// Token: 0x0600D64C RID: 54860 RVA: 0x00355CD8 File Offset: 0x00353ED8
			// Note: this type is marked as 'beforefieldinit'.
			static Disable()
			{
				Il2CppClassPointerStore<Console.Disable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Disable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr);
				Console.Disable.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, 100665690);
				Console.Disable.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, 100665691);
				Console.Disable.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, 100665692);
				Console.Disable.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, 100665693);
				Console.Disable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, 100665694);
			}

			// Token: 0x17004168 RID: 16744
			// (get) Token: 0x0600D64D RID: 54861 RVA: 0x00355D68 File Offset: 0x00353F68
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86752, XrefRangeEnd = 86754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Disable.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004169 RID: 16745
			// (get) Token: 0x0600D64E RID: 54862 RVA: 0x00355DAC File Offset: 0x00353FAC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86754, XrefRangeEnd = 86756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Disable.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700416A RID: 16746
			// (get) Token: 0x0600D64F RID: 54863 RVA: 0x00355DF0 File Offset: 0x00353FF0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86756, XrefRangeEnd = 86758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Disable.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D650 RID: 54864 RVA: 0x00355E34 File Offset: 0x00354034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86758, XrefRangeEnd = 86809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Disable.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D651 RID: 54865 RVA: 0x00355E84 File Offset: 0x00354084
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Disable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Disable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D652 RID: 54866 RVA: 0x00064E05 File Offset: 0x00063005
			public Disable(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040091FE RID: 37374
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x040091FF RID: 37375
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009200 RID: 37376
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009201 RID: 37377
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009202 RID: 37378
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000DAF RID: 3503
			[ObfuscatedName("ScheduleOne.Console+Disable+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
			{
				// Token: 0x0600FD38 RID: 64824 RVA: 0x003C50EC File Offset: 0x003C32EC
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console.Disable>.NativeClassPtr, "<>c__DisplayClass6_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr);
					Console.Disable.__c__DisplayClass6_0.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr, "code");
					Console.Disable.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr, 100665695);
					Console.Disable.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr, 100665696);
				}

				// Token: 0x0600FD39 RID: 64825 RVA: 0x003C5154 File Offset: 0x003C3354
				[CallerCount(2575)]
				[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Disable.__c__DisplayClass6_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Disable.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FD3A RID: 64826 RVA: 0x003C5190 File Offset: 0x003C3390
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86749, XrefRangeEnd = 86752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Execute_b__0(Console.LabelledGameObject x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Disable.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600FD3B RID: 64827 RVA: 0x00077E91 File Offset: 0x00076091
				public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004CF1 RID: 19697
				// (get) Token: 0x0600FD3C RID: 64828 RVA: 0x003C51E0 File Offset: 0x003C33E0
				// (set) Token: 0x0600FD3D RID: 64829 RVA: 0x00077E9A File Offset: 0x0007609A
				public unsafe string code
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.Disable.__c__DisplayClass6_0.NativeFieldInfoPtr_code);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.Disable.__c__DisplayClass6_0.NativeFieldInfoPtr_code), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x0400AABE RID: 43710
				private static readonly IntPtr NativeFieldInfoPtr_code;

				// Token: 0x0400AABF RID: 43711
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400AAC0 RID: 43712
				private static readonly IntPtr NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0;
			}
		}

		// Token: 0x020008FF RID: 2303
		public class Enable : Console.ConsoleCommand
		{
			// Token: 0x0600D653 RID: 54867 RVA: 0x00355EC0 File Offset: 0x003540C0
			// Note: this type is marked as 'beforefieldinit'.
			static Enable()
			{
				Il2CppClassPointerStore<Console.Enable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "Enable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr);
				Console.Enable.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, 100665697);
				Console.Enable.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, 100665698);
				Console.Enable.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, 100665699);
				Console.Enable.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, 100665700);
				Console.Enable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, 100665701);
			}

			// Token: 0x1700416B RID: 16747
			// (get) Token: 0x0600D654 RID: 54868 RVA: 0x00355F50 File Offset: 0x00354150
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86809, XrefRangeEnd = 86811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Enable.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700416C RID: 16748
			// (get) Token: 0x0600D655 RID: 54869 RVA: 0x00355F94 File Offset: 0x00354194
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86811, XrefRangeEnd = 86813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Enable.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700416D RID: 16749
			// (get) Token: 0x0600D656 RID: 54870 RVA: 0x00355FD8 File Offset: 0x003541D8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86813, XrefRangeEnd = 86815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Enable.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D657 RID: 54871 RVA: 0x0035601C File Offset: 0x0035421C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86815, XrefRangeEnd = 86857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.Enable.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D658 RID: 54872 RVA: 0x0035606C File Offset: 0x0035426C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Enable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D659 RID: 54873 RVA: 0x00064E0E File Offset: 0x0006300E
			public Enable(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009203 RID: 37379
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009204 RID: 37380
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009205 RID: 37381
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009206 RID: 37382
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009207 RID: 37383
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000DB0 RID: 3504
			[ObfuscatedName("ScheduleOne.Console+Enable+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
			{
				// Token: 0x0600FD3E RID: 64830 RVA: 0x003C5208 File Offset: 0x003C3408
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console.Enable>.NativeClassPtr, "<>c__DisplayClass6_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr);
					Console.Enable.__c__DisplayClass6_0.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr, "code");
					Console.Enable.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr, 100665702);
					Console.Enable.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr, 100665703);
				}

				// Token: 0x0600FD3F RID: 64831 RVA: 0x003C5270 File Offset: 0x003C3470
				[CallerCount(2575)]
				[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.Enable.__c__DisplayClass6_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Enable.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FD40 RID: 64832 RVA: 0x003C52AC File Offset: 0x003C34AC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _Execute_b__0(Console.LabelledGameObject x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.Enable.__c__DisplayClass6_0.NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600FD41 RID: 64833 RVA: 0x00077EB9 File Offset: 0x000760B9
				public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004CF2 RID: 19698
				// (get) Token: 0x0600FD42 RID: 64834 RVA: 0x003C52FC File Offset: 0x003C34FC
				// (set) Token: 0x0600FD43 RID: 64835 RVA: 0x00077EC2 File Offset: 0x000760C2
				public unsafe string code
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.Enable.__c__DisplayClass6_0.NativeFieldInfoPtr_code);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.Enable.__c__DisplayClass6_0.NativeFieldInfoPtr_code), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x0400AAC1 RID: 43713
				private static readonly IntPtr NativeFieldInfoPtr_code;

				// Token: 0x0400AAC2 RID: 43714
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400AAC3 RID: 43715
				private static readonly IntPtr NativeMethodInfoPtr__Execute_b__0_Internal_Boolean_LabelledGameObject_0;
			}
		}

		// Token: 0x02000900 RID: 2304
		public class EndTutorial : Console.ConsoleCommand
		{
			// Token: 0x0600D65A RID: 54874 RVA: 0x003560A8 File Offset: 0x003542A8
			// Note: this type is marked as 'beforefieldinit'.
			static EndTutorial()
			{
				Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "EndTutorial");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr);
				Console.EndTutorial.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr, 100665704);
				Console.EndTutorial.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr, 100665705);
				Console.EndTutorial.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr, 100665706);
				Console.EndTutorial.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr, 100665707);
				Console.EndTutorial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr, 100665708);
			}

			// Token: 0x1700416E RID: 16750
			// (get) Token: 0x0600D65B RID: 54875 RVA: 0x00356138 File Offset: 0x00354338
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86857, XrefRangeEnd = 86859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EndTutorial.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700416F RID: 16751
			// (get) Token: 0x0600D65C RID: 54876 RVA: 0x0035617C File Offset: 0x0035437C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86859, XrefRangeEnd = 86861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EndTutorial.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004170 RID: 16752
			// (get) Token: 0x0600D65D RID: 54877 RVA: 0x003561C0 File Offset: 0x003543C0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86861, XrefRangeEnd = 86863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EndTutorial.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D65E RID: 54878 RVA: 0x00356204 File Offset: 0x00354404
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86863, XrefRangeEnd = 86869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.EndTutorial.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D65F RID: 54879 RVA: 0x00356254 File Offset: 0x00354454
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EndTutorial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.EndTutorial>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.EndTutorial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D660 RID: 54880 RVA: 0x00064E17 File Offset: 0x00063017
			public EndTutorial(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009208 RID: 37384
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009209 RID: 37385
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400920A RID: 37386
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400920B RID: 37387
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400920C RID: 37388
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000901 RID: 2305
		public class DisableNPCAsset : Console.ConsoleCommand
		{
			// Token: 0x0600D661 RID: 54881 RVA: 0x00356290 File Offset: 0x00354490
			// Note: this type is marked as 'beforefieldinit'.
			static DisableNPCAsset()
			{
				Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "DisableNPCAsset");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr);
				Console.DisableNPCAsset.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr, 100665709);
				Console.DisableNPCAsset.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr, 100665710);
				Console.DisableNPCAsset.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr, 100665711);
				Console.DisableNPCAsset.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr, 100665712);
				Console.DisableNPCAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr, 100665713);
			}

			// Token: 0x17004171 RID: 16753
			// (get) Token: 0x0600D662 RID: 54882 RVA: 0x00356320 File Offset: 0x00354520
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86869, XrefRangeEnd = 86871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableNPCAsset.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004172 RID: 16754
			// (get) Token: 0x0600D663 RID: 54883 RVA: 0x00356364 File Offset: 0x00354564
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86871, XrefRangeEnd = 86873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableNPCAsset.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004173 RID: 16755
			// (get) Token: 0x0600D664 RID: 54884 RVA: 0x003563A8 File Offset: 0x003545A8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86873, XrefRangeEnd = 86875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableNPCAsset.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D665 RID: 54885 RVA: 0x003563EC File Offset: 0x003545EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86875, XrefRangeEnd = 86918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableNPCAsset.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D666 RID: 54886 RVA: 0x0035643C File Offset: 0x0035463C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DisableNPCAsset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.DisableNPCAsset>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.DisableNPCAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D667 RID: 54887 RVA: 0x00064E20 File Offset: 0x00063020
			public DisableNPCAsset(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400920D RID: 37389
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400920E RID: 37390
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400920F RID: 37391
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009210 RID: 37392
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009211 RID: 37393
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000902 RID: 2306
		public class ShowFPS : Console.ConsoleCommand
		{
			// Token: 0x0600D668 RID: 54888 RVA: 0x00356478 File Offset: 0x00354678
			// Note: this type is marked as 'beforefieldinit'.
			static ShowFPS()
			{
				Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ShowFPS");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr);
				Console.ShowFPS.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr, 100665714);
				Console.ShowFPS.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr, 100665715);
				Console.ShowFPS.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr, 100665716);
				Console.ShowFPS.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr, 100665717);
				Console.ShowFPS.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr, 100665718);
			}

			// Token: 0x17004174 RID: 16756
			// (get) Token: 0x0600D669 RID: 54889 RVA: 0x00356508 File Offset: 0x00354708
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86918, XrefRangeEnd = 86920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ShowFPS.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004175 RID: 16757
			// (get) Token: 0x0600D66A RID: 54890 RVA: 0x0035654C File Offset: 0x0035474C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86920, XrefRangeEnd = 86922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ShowFPS.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004176 RID: 16758
			// (get) Token: 0x0600D66B RID: 54891 RVA: 0x00356590 File Offset: 0x00354790
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86922, XrefRangeEnd = 86924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ShowFPS.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D66C RID: 54892 RVA: 0x003565D4 File Offset: 0x003547D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86924, XrefRangeEnd = 86931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ShowFPS.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D66D RID: 54893 RVA: 0x00356624 File Offset: 0x00354824
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ShowFPS() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ShowFPS>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ShowFPS.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D66E RID: 54894 RVA: 0x00064E29 File Offset: 0x00063029
			public ShowFPS(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009212 RID: 37394
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009213 RID: 37395
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009214 RID: 37396
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009215 RID: 37397
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009216 RID: 37398
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000903 RID: 2307
		public class HideFPS : Console.ConsoleCommand
		{
			// Token: 0x0600D66F RID: 54895 RVA: 0x00356660 File Offset: 0x00354860
			// Note: this type is marked as 'beforefieldinit'.
			static HideFPS()
			{
				Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "HideFPS");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr);
				Console.HideFPS.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr, 100665719);
				Console.HideFPS.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr, 100665720);
				Console.HideFPS.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr, 100665721);
				Console.HideFPS.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr, 100665722);
				Console.HideFPS.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr, 100665723);
			}

			// Token: 0x17004177 RID: 16759
			// (get) Token: 0x0600D670 RID: 54896 RVA: 0x003566F0 File Offset: 0x003548F0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86931, XrefRangeEnd = 86933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideFPS.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004178 RID: 16760
			// (get) Token: 0x0600D671 RID: 54897 RVA: 0x00356734 File Offset: 0x00354934
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86933, XrefRangeEnd = 86935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideFPS.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004179 RID: 16761
			// (get) Token: 0x0600D672 RID: 54898 RVA: 0x00356778 File Offset: 0x00354978
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86935, XrefRangeEnd = 86937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideFPS.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D673 RID: 54899 RVA: 0x003567BC File Offset: 0x003549BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86937, XrefRangeEnd = 86944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.HideFPS.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D674 RID: 54900 RVA: 0x0035680C File Offset: 0x00354A0C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HideFPS() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.HideFPS>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.HideFPS.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D675 RID: 54901 RVA: 0x00064E32 File Offset: 0x00063032
			public HideFPS(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009217 RID: 37399
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009218 RID: 37400
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009219 RID: 37401
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400921A RID: 37402
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400921B RID: 37403
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000904 RID: 2308
		public class ClearTrash : Console.ConsoleCommand
		{
			// Token: 0x0600D676 RID: 54902 RVA: 0x00356848 File Offset: 0x00354A48
			// Note: this type is marked as 'beforefieldinit'.
			static ClearTrash()
			{
				Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ClearTrash");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr);
				Console.ClearTrash.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr, 100665724);
				Console.ClearTrash.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr, 100665725);
				Console.ClearTrash.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr, 100665726);
				Console.ClearTrash.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr, 100665727);
				Console.ClearTrash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr, 100665728);
			}

			// Token: 0x1700417A RID: 16762
			// (get) Token: 0x0600D677 RID: 54903 RVA: 0x003568D8 File Offset: 0x00354AD8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86944, XrefRangeEnd = 86946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearTrash.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700417B RID: 16763
			// (get) Token: 0x0600D678 RID: 54904 RVA: 0x0035691C File Offset: 0x00354B1C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86946, XrefRangeEnd = 86948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearTrash.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700417C RID: 16764
			// (get) Token: 0x0600D679 RID: 54905 RVA: 0x00356960 File Offset: 0x00354B60
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86948, XrefRangeEnd = 86950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearTrash.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D67A RID: 54906 RVA: 0x003569A4 File Offset: 0x00354BA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86950, XrefRangeEnd = 86956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ClearTrash.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D67B RID: 54907 RVA: 0x003569F4 File Offset: 0x00354BF4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClearTrash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ClearTrash>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ClearTrash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D67C RID: 54908 RVA: 0x00064E3B File Offset: 0x0006303B
			public ClearTrash(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400921C RID: 37404
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400921D RID: 37405
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400921E RID: 37406
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400921F RID: 37407
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009220 RID: 37408
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000905 RID: 2309
		public class PlayCutscene : Console.ConsoleCommand
		{
			// Token: 0x0600D67D RID: 54909 RVA: 0x00356A30 File Offset: 0x00354C30
			// Note: this type is marked as 'beforefieldinit'.
			static PlayCutscene()
			{
				Il2CppClassPointerStore<Console.PlayCutscene>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "PlayCutscene");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.PlayCutscene>.NativeClassPtr);
				Console.PlayCutscene.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PlayCutscene>.NativeClassPtr, 100665729);
				Console.PlayCutscene.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PlayCutscene>.NativeClassPtr, 100665730);
				Console.PlayCutscene.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PlayCutscene>.NativeClassPtr, 100665731);
				Console.PlayCutscene.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PlayCutscene>.NativeClassPtr, 100665732);
				Console.PlayCutscene.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.PlayCutscene>.NativeClassPtr, 100665733);
			}

			// Token: 0x1700417D RID: 16765
			// (get) Token: 0x0600D67E RID: 54910 RVA: 0x00356AC0 File Offset: 0x00354CC0
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86956, XrefRangeEnd = 86958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PlayCutscene.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700417E RID: 16766
			// (get) Token: 0x0600D67F RID: 54911 RVA: 0x00356B04 File Offset: 0x00354D04
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86958, XrefRangeEnd = 86960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PlayCutscene.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700417F RID: 16767
			// (get) Token: 0x0600D680 RID: 54912 RVA: 0x00356B48 File Offset: 0x00354D48
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86960, XrefRangeEnd = 86962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PlayCutscene.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D681 RID: 54913 RVA: 0x00356B8C File Offset: 0x00354D8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86962, XrefRangeEnd = 86974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.PlayCutscene.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D682 RID: 54914 RVA: 0x00356BDC File Offset: 0x00354DDC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayCutscene() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.PlayCutscene>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.PlayCutscene.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D683 RID: 54915 RVA: 0x00064E44 File Offset: 0x00063044
			public PlayCutscene(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009221 RID: 37409
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009222 RID: 37410
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009223 RID: 37411
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009224 RID: 37412
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009225 RID: 37413
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000906 RID: 2310
		public class SetGravityMultiplier : Console.ConsoleCommand
		{
			// Token: 0x0600D684 RID: 54916 RVA: 0x00356C18 File Offset: 0x00354E18
			// Note: this type is marked as 'beforefieldinit'.
			static SetGravityMultiplier()
			{
				Il2CppClassPointerStore<Console.SetGravityMultiplier>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetGravityMultiplier");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetGravityMultiplier>.NativeClassPtr);
				Console.SetGravityMultiplier.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetGravityMultiplier>.NativeClassPtr, 100665734);
				Console.SetGravityMultiplier.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetGravityMultiplier>.NativeClassPtr, 100665735);
				Console.SetGravityMultiplier.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetGravityMultiplier>.NativeClassPtr, 100665736);
				Console.SetGravityMultiplier.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetGravityMultiplier>.NativeClassPtr, 100665737);
				Console.SetGravityMultiplier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetGravityMultiplier>.NativeClassPtr, 100665738);
			}

			// Token: 0x17004180 RID: 16768
			// (get) Token: 0x0600D685 RID: 54917 RVA: 0x00356CA8 File Offset: 0x00354EA8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86974, XrefRangeEnd = 86976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetGravityMultiplier.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004181 RID: 16769
			// (get) Token: 0x0600D686 RID: 54918 RVA: 0x00356CEC File Offset: 0x00354EEC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86976, XrefRangeEnd = 86978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetGravityMultiplier.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004182 RID: 16770
			// (get) Token: 0x0600D687 RID: 54919 RVA: 0x00356D30 File Offset: 0x00354F30
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86978, XrefRangeEnd = 86980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetGravityMultiplier.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D688 RID: 54920 RVA: 0x00356D74 File Offset: 0x00354F74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86980, XrefRangeEnd = 86992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetGravityMultiplier.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D689 RID: 54921 RVA: 0x00356DC4 File Offset: 0x00354FC4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetGravityMultiplier() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetGravityMultiplier>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetGravityMultiplier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D68A RID: 54922 RVA: 0x00064E4D File Offset: 0x0006304D
			public SetGravityMultiplier(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009226 RID: 37414
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009227 RID: 37415
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009228 RID: 37416
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009229 RID: 37417
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400922A RID: 37418
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000907 RID: 2311
		public class SetRegionUnlocked : Console.ConsoleCommand
		{
			// Token: 0x0600D68B RID: 54923 RVA: 0x00356E00 File Offset: 0x00355000
			// Note: this type is marked as 'beforefieldinit'.
			static SetRegionUnlocked()
			{
				Il2CppClassPointerStore<Console.SetRegionUnlocked>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetRegionUnlocked");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetRegionUnlocked>.NativeClassPtr);
				Console.SetRegionUnlocked.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRegionUnlocked>.NativeClassPtr, 100665739);
				Console.SetRegionUnlocked.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRegionUnlocked>.NativeClassPtr, 100665740);
				Console.SetRegionUnlocked.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRegionUnlocked>.NativeClassPtr, 100665741);
				Console.SetRegionUnlocked.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRegionUnlocked>.NativeClassPtr, 100665742);
				Console.SetRegionUnlocked.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetRegionUnlocked>.NativeClassPtr, 100665743);
			}

			// Token: 0x17004183 RID: 16771
			// (get) Token: 0x0600D68C RID: 54924 RVA: 0x00356E90 File Offset: 0x00355090
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86992, XrefRangeEnd = 86994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetRegionUnlocked.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004184 RID: 16772
			// (get) Token: 0x0600D68D RID: 54925 RVA: 0x00356ED4 File Offset: 0x003550D4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86994, XrefRangeEnd = 86996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetRegionUnlocked.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004185 RID: 16773
			// (get) Token: 0x0600D68E RID: 54926 RVA: 0x00356F18 File Offset: 0x00355118
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86996, XrefRangeEnd = 86998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetRegionUnlocked.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D68F RID: 54927 RVA: 0x00356F5C File Offset: 0x0035515C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86998, XrefRangeEnd = 87016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetRegionUnlocked.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D690 RID: 54928 RVA: 0x00356FAC File Offset: 0x003551AC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetRegionUnlocked() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetRegionUnlocked>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetRegionUnlocked.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D691 RID: 54929 RVA: 0x00064E56 File Offset: 0x00063056
			public SetRegionUnlocked(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400922B RID: 37419
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400922C RID: 37420
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400922D RID: 37421
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400922E RID: 37422
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400922F RID: 37423
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000908 RID: 2312
		public class ForceSleep : Console.ConsoleCommand
		{
			// Token: 0x0600D692 RID: 54930 RVA: 0x00356FE8 File Offset: 0x003551E8
			// Note: this type is marked as 'beforefieldinit'.
			static ForceSleep()
			{
				Il2CppClassPointerStore<Console.ForceSleep>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "ForceSleep");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.ForceSleep>.NativeClassPtr);
				Console.ForceSleep.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ForceSleep>.NativeClassPtr, 100665744);
				Console.ForceSleep.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ForceSleep>.NativeClassPtr, 100665745);
				Console.ForceSleep.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ForceSleep>.NativeClassPtr, 100665746);
				Console.ForceSleep.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ForceSleep>.NativeClassPtr, 100665747);
				Console.ForceSleep.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.ForceSleep>.NativeClassPtr, 100665748);
			}

			// Token: 0x17004186 RID: 16774
			// (get) Token: 0x0600D693 RID: 54931 RVA: 0x00357078 File Offset: 0x00355278
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87016, XrefRangeEnd = 87018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ForceSleep.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004187 RID: 16775
			// (get) Token: 0x0600D694 RID: 54932 RVA: 0x003570BC File Offset: 0x003552BC
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87018, XrefRangeEnd = 87020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ForceSleep.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004188 RID: 16776
			// (get) Token: 0x0600D695 RID: 54933 RVA: 0x00357100 File Offset: 0x00355300
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87020, XrefRangeEnd = 87022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ForceSleep.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D696 RID: 54934 RVA: 0x00357144 File Offset: 0x00355344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87022, XrefRangeEnd = 87028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.ForceSleep.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D697 RID: 54935 RVA: 0x00357194 File Offset: 0x00355394
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ForceSleep() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.ForceSleep>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.ForceSleep.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D698 RID: 54936 RVA: 0x00064E5F File Offset: 0x0006305F
			public ForceSleep(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009230 RID: 37424
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009231 RID: 37425
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009232 RID: 37426
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009233 RID: 37427
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009234 RID: 37428
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000909 RID: 2313
		public class DestroyNPCs : Console.ConsoleCommand
		{
			// Token: 0x0600D699 RID: 54937 RVA: 0x003571D0 File Offset: 0x003553D0
			// Note: this type is marked as 'beforefieldinit'.
			static DestroyNPCs()
			{
				Il2CppClassPointerStore<Console.DestroyNPCs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "DestroyNPCs");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.DestroyNPCs>.NativeClassPtr);
				Console.DestroyNPCs.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DestroyNPCs>.NativeClassPtr, 100665749);
				Console.DestroyNPCs.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DestroyNPCs>.NativeClassPtr, 100665750);
				Console.DestroyNPCs.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DestroyNPCs>.NativeClassPtr, 100665751);
				Console.DestroyNPCs.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DestroyNPCs>.NativeClassPtr, 100665752);
				Console.DestroyNPCs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DestroyNPCs>.NativeClassPtr, 100665753);
			}

			// Token: 0x17004189 RID: 16777
			// (get) Token: 0x0600D69A RID: 54938 RVA: 0x00357260 File Offset: 0x00355460
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87028, XrefRangeEnd = 87030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DestroyNPCs.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700418A RID: 16778
			// (get) Token: 0x0600D69B RID: 54939 RVA: 0x003572A4 File Offset: 0x003554A4
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87030, XrefRangeEnd = 87032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DestroyNPCs.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700418B RID: 16779
			// (get) Token: 0x0600D69C RID: 54940 RVA: 0x003572E8 File Offset: 0x003554E8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87032, XrefRangeEnd = 87034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DestroyNPCs.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D69D RID: 54941 RVA: 0x0035732C File Offset: 0x0035552C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87034, XrefRangeEnd = 87046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DestroyNPCs.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D69E RID: 54942 RVA: 0x0035737C File Offset: 0x0035557C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DestroyNPCs() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.DestroyNPCs>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.DestroyNPCs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D69F RID: 54943 RVA: 0x00064E68 File Offset: 0x00063068
			public DestroyNPCs(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009235 RID: 37429
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009236 RID: 37430
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009237 RID: 37431
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009238 RID: 37432
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009239 RID: 37433
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200090A RID: 2314
		public class SetDayDuration : Console.ConsoleCommand
		{
			// Token: 0x0600D6A0 RID: 54944 RVA: 0x003573B8 File Offset: 0x003555B8
			// Note: this type is marked as 'beforefieldinit'.
			static SetDayDuration()
			{
				Il2CppClassPointerStore<Console.SetDayDuration>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetDayDuration");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetDayDuration>.NativeClassPtr);
				Console.SetDayDuration.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDayDuration>.NativeClassPtr, 100665754);
				Console.SetDayDuration.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDayDuration>.NativeClassPtr, 100665755);
				Console.SetDayDuration.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDayDuration>.NativeClassPtr, 100665756);
				Console.SetDayDuration.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDayDuration>.NativeClassPtr, 100665757);
				Console.SetDayDuration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetDayDuration>.NativeClassPtr, 100665758);
			}

			// Token: 0x1700418C RID: 16780
			// (get) Token: 0x0600D6A1 RID: 54945 RVA: 0x00357448 File Offset: 0x00355648
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87046, XrefRangeEnd = 87048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetDayDuration.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700418D RID: 16781
			// (get) Token: 0x0600D6A2 RID: 54946 RVA: 0x0035748C File Offset: 0x0035568C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87048, XrefRangeEnd = 87050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetDayDuration.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700418E RID: 16782
			// (get) Token: 0x0600D6A3 RID: 54947 RVA: 0x003574D0 File Offset: 0x003556D0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87050, XrefRangeEnd = 87052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetDayDuration.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D6A4 RID: 54948 RVA: 0x00357514 File Offset: 0x00355714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87052, XrefRangeEnd = 87063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetDayDuration.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6A5 RID: 54949 RVA: 0x00357564 File Offset: 0x00355764
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetDayDuration() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetDayDuration>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetDayDuration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6A6 RID: 54950 RVA: 0x00064E71 File Offset: 0x00063071
			public SetDayDuration(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400923A RID: 37434
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400923B RID: 37435
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400923C RID: 37436
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400923D RID: 37437
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400923E RID: 37438
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200090B RID: 2315
		public class SetPoliceIgnorePlayers : Console.ConsoleCommand
		{
			// Token: 0x0600D6A7 RID: 54951 RVA: 0x003575A0 File Offset: 0x003557A0
			// Note: this type is marked as 'beforefieldinit'.
			static SetPoliceIgnorePlayers()
			{
				Il2CppClassPointerStore<Console.SetPoliceIgnorePlayers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "SetPoliceIgnorePlayers");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.SetPoliceIgnorePlayers>.NativeClassPtr);
				Console.SetPoliceIgnorePlayers.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPoliceIgnorePlayers>.NativeClassPtr, 100665759);
				Console.SetPoliceIgnorePlayers.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPoliceIgnorePlayers>.NativeClassPtr, 100665760);
				Console.SetPoliceIgnorePlayers.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPoliceIgnorePlayers>.NativeClassPtr, 100665761);
				Console.SetPoliceIgnorePlayers.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPoliceIgnorePlayers>.NativeClassPtr, 100665762);
				Console.SetPoliceIgnorePlayers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.SetPoliceIgnorePlayers>.NativeClassPtr, 100665763);
			}

			// Token: 0x1700418F RID: 16783
			// (get) Token: 0x0600D6A8 RID: 54952 RVA: 0x00357630 File Offset: 0x00355830
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87063, XrefRangeEnd = 87065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetPoliceIgnorePlayers.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004190 RID: 16784
			// (get) Token: 0x0600D6A9 RID: 54953 RVA: 0x00357674 File Offset: 0x00355874
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87065, XrefRangeEnd = 87067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetPoliceIgnorePlayers.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004191 RID: 16785
			// (get) Token: 0x0600D6AA RID: 54954 RVA: 0x003576B8 File Offset: 0x003558B8
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87067, XrefRangeEnd = 87069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetPoliceIgnorePlayers.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D6AB RID: 54955 RVA: 0x003576FC File Offset: 0x003558FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87069, XrefRangeEnd = 87095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.SetPoliceIgnorePlayers.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6AC RID: 54956 RVA: 0x0035774C File Offset: 0x0035594C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetPoliceIgnorePlayers() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.SetPoliceIgnorePlayers>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.SetPoliceIgnorePlayers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6AD RID: 54957 RVA: 0x00064E7A File Offset: 0x0006307A
			public SetPoliceIgnorePlayers(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400923F RID: 37439
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009240 RID: 37440
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009241 RID: 37441
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009242 RID: 37442
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009243 RID: 37443
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200090C RID: 2316
		public class DisableMeshes : Console.ConsoleCommand
		{
			// Token: 0x0600D6AE RID: 54958 RVA: 0x00357788 File Offset: 0x00355988
			// Note: this type is marked as 'beforefieldinit'.
			static DisableMeshes()
			{
				Il2CppClassPointerStore<Console.DisableMeshes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "DisableMeshes");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.DisableMeshes>.NativeClassPtr);
				Console.DisableMeshes.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableMeshes>.NativeClassPtr, 100665764);
				Console.DisableMeshes.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableMeshes>.NativeClassPtr, 100665765);
				Console.DisableMeshes.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableMeshes>.NativeClassPtr, 100665766);
				Console.DisableMeshes.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableMeshes>.NativeClassPtr, 100665767);
				Console.DisableMeshes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableMeshes>.NativeClassPtr, 100665768);
			}

			// Token: 0x17004192 RID: 16786
			// (get) Token: 0x0600D6AF RID: 54959 RVA: 0x00357818 File Offset: 0x00355A18
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87095, XrefRangeEnd = 87097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableMeshes.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004193 RID: 16787
			// (get) Token: 0x0600D6B0 RID: 54960 RVA: 0x0035785C File Offset: 0x00355A5C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87097, XrefRangeEnd = 87099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableMeshes.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004194 RID: 16788
			// (get) Token: 0x0600D6B1 RID: 54961 RVA: 0x003578A0 File Offset: 0x00355AA0
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87099, XrefRangeEnd = 87101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableMeshes.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D6B2 RID: 54962 RVA: 0x003578E4 File Offset: 0x00355AE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87101, XrefRangeEnd = 87109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableMeshes.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6B3 RID: 54963 RVA: 0x00357934 File Offset: 0x00355B34
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DisableMeshes() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.DisableMeshes>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.DisableMeshes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6B4 RID: 54964 RVA: 0x00064E83 File Offset: 0x00063083
			public DisableMeshes(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009244 RID: 37444
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x04009245 RID: 37445
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009246 RID: 37446
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009247 RID: 37447
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009248 RID: 37448
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200090D RID: 2317
		public class DisableNPCs : Console.ConsoleCommand
		{
			// Token: 0x0600D6B5 RID: 54965 RVA: 0x00357970 File Offset: 0x00355B70
			// Note: this type is marked as 'beforefieldinit'.
			static DisableNPCs()
			{
				Il2CppClassPointerStore<Console.DisableNPCs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "DisableNPCs");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.DisableNPCs>.NativeClassPtr);
				Console.DisableNPCs.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCs>.NativeClassPtr, 100665769);
				Console.DisableNPCs.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCs>.NativeClassPtr, 100665770);
				Console.DisableNPCs.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCs>.NativeClassPtr, 100665771);
				Console.DisableNPCs.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCs>.NativeClassPtr, 100665772);
				Console.DisableNPCs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.DisableNPCs>.NativeClassPtr, 100665773);
			}

			// Token: 0x17004195 RID: 16789
			// (get) Token: 0x0600D6B6 RID: 54966 RVA: 0x00357A00 File Offset: 0x00355C00
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87109, XrefRangeEnd = 87111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableNPCs.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004196 RID: 16790
			// (get) Token: 0x0600D6B7 RID: 54967 RVA: 0x00357A44 File Offset: 0x00355C44
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87111, XrefRangeEnd = 87113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableNPCs.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004197 RID: 16791
			// (get) Token: 0x0600D6B8 RID: 54968 RVA: 0x00357A88 File Offset: 0x00355C88
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87113, XrefRangeEnd = 87115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableNPCs.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D6B9 RID: 54969 RVA: 0x00357ACC File Offset: 0x00355CCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87115, XrefRangeEnd = 87124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.DisableNPCs.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6BA RID: 54970 RVA: 0x00357B1C File Offset: 0x00355D1C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DisableNPCs() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.DisableNPCs>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.DisableNPCs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6BB RID: 54971 RVA: 0x00064E8C File Offset: 0x0006308C
			public DisableNPCs(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009249 RID: 37449
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400924A RID: 37450
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x0400924B RID: 37451
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x0400924C RID: 37452
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x0400924D RID: 37453
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200090E RID: 2318
		public class QuitGame : Console.ConsoleCommand
		{
			// Token: 0x0600D6BC RID: 54972 RVA: 0x00357B58 File Offset: 0x00355D58
			// Note: this type is marked as 'beforefieldinit'.
			static QuitGame()
			{
				Il2CppClassPointerStore<Console.QuitGame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "QuitGame");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.QuitGame>.NativeClassPtr);
				Console.QuitGame.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.QuitGame>.NativeClassPtr, 100665774);
				Console.QuitGame.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.QuitGame>.NativeClassPtr, 100665775);
				Console.QuitGame.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.QuitGame>.NativeClassPtr, 100665776);
				Console.QuitGame.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.QuitGame>.NativeClassPtr, 100665777);
				Console.QuitGame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.QuitGame>.NativeClassPtr, 100665778);
			}

			// Token: 0x17004198 RID: 16792
			// (get) Token: 0x0600D6BD RID: 54973 RVA: 0x00357BE8 File Offset: 0x00355DE8
			public unsafe override string CommandWord
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87124, XrefRangeEnd = 87126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.QuitGame.NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004199 RID: 16793
			// (get) Token: 0x0600D6BE RID: 54974 RVA: 0x00357C2C File Offset: 0x00355E2C
			public unsafe override string CommandDescription
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87126, XrefRangeEnd = 87128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.QuitGame.NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700419A RID: 16794
			// (get) Token: 0x0600D6BF RID: 54975 RVA: 0x00357C70 File Offset: 0x00355E70
			public unsafe override string ExampleUsage
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87128, XrefRangeEnd = 87130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.QuitGame.NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600D6C0 RID: 54976 RVA: 0x00357CB4 File Offset: 0x00355EB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87130, XrefRangeEnd = 87134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(List<string> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Console.QuitGame.NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6C1 RID: 54977 RVA: 0x00357D04 File Offset: 0x00355F04
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe QuitGame() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.QuitGame>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.QuitGame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6C2 RID: 54978 RVA: 0x00064E95 File Offset: 0x00063095
			public QuitGame(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400924E RID: 37454
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandWord_Public_Virtual_get_String_0;

			// Token: 0x0400924F RID: 37455
			private static readonly IntPtr NativeMethodInfoPtr_get_CommandDescription_Public_Virtual_get_String_0;

			// Token: 0x04009250 RID: 37456
			private static readonly IntPtr NativeMethodInfoPtr_get_ExampleUsage_Public_Virtual_get_String_0;

			// Token: 0x04009251 RID: 37457
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_List_1_String_0;

			// Token: 0x04009252 RID: 37458
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200090F RID: 2319
		[Serializable]
		public class LabelledGameObject : Il2CppSystem.Object
		{
			// Token: 0x0600D6C3 RID: 54979 RVA: 0x00357D40 File Offset: 0x00355F40
			// Note: this type is marked as 'beforefieldinit'.
			static LabelledGameObject()
			{
				Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "LabelledGameObject");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr);
				Console.LabelledGameObject.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr, "Label");
				Console.LabelledGameObject.NativeFieldInfoPtr_GameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr, "GameObject");
				Console.LabelledGameObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr, 100665779);
			}

			// Token: 0x0600D6C4 RID: 54980 RVA: 0x00357DA8 File Offset: 0x00355FA8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LabelledGameObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.LabelledGameObject>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.LabelledGameObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6C5 RID: 54981 RVA: 0x00064E9E File Offset: 0x0006309E
			public LabelledGameObject(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700419B RID: 16795
			// (get) Token: 0x0600D6C6 RID: 54982 RVA: 0x00357DE4 File Offset: 0x00355FE4
			// (set) Token: 0x0600D6C7 RID: 54983 RVA: 0x00064EA7 File Offset: 0x000630A7
			public unsafe string Label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.LabelledGameObject.NativeFieldInfoPtr_Label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.LabelledGameObject.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700419C RID: 16796
			// (get) Token: 0x0600D6C8 RID: 54984 RVA: 0x00357E0C File Offset: 0x0035600C
			// (set) Token: 0x0600D6C9 RID: 54985 RVA: 0x00064EC6 File Offset: 0x000630C6
			public unsafe GameObject GameObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.LabelledGameObject.NativeFieldInfoPtr_GameObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Console.LabelledGameObject.NativeFieldInfoPtr_GameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009253 RID: 37459
			private static readonly IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x04009254 RID: 37460
			private static readonly IntPtr NativeFieldInfoPtr_GameObject;

			// Token: 0x04009255 RID: 37461
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
