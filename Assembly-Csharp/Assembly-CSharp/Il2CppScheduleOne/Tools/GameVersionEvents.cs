using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004E4 RID: 1252
	public class GameVersionEvents : MonoBehaviour
	{
		// Token: 0x060071E5 RID: 29157 RVA: 0x00201AB8 File Offset: 0x001FFCB8
		// Note: this type is marked as 'beforefieldinit'.
		static GameVersionEvents()
		{
			Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "GameVersionEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr);
			GameVersionEvents.NativeFieldInfoPtr_onFullGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr, "onFullGame");
			GameVersionEvents.NativeFieldInfoPtr_onDemoGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr, "onDemoGame");
			GameVersionEvents.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr, 100678034);
			GameVersionEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr, 100678035);
		}

		// Token: 0x060071E6 RID: 29158 RVA: 0x00201B38 File Offset: 0x001FFD38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameVersionEvents.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071E7 RID: 29159 RVA: 0x00201B6C File Offset: 0x001FFD6C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameVersionEvents() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameVersionEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameVersionEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071E8 RID: 29160 RVA: 0x000362D0 File Offset: 0x000344D0
		public GameVersionEvents(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700232D RID: 9005
		// (get) Token: 0x060071E9 RID: 29161 RVA: 0x00201BA8 File Offset: 0x001FFDA8
		// (set) Token: 0x060071EA RID: 29162 RVA: 0x000362D9 File Offset: 0x000344D9
		public unsafe UnityEvent onFullGame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameVersionEvents.NativeFieldInfoPtr_onFullGame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameVersionEvents.NativeFieldInfoPtr_onFullGame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700232E RID: 9006
		// (get) Token: 0x060071EB RID: 29163 RVA: 0x00201BD8 File Offset: 0x001FFDD8
		// (set) Token: 0x060071EC RID: 29164 RVA: 0x000362F8 File Offset: 0x000344F8
		public unsafe UnityEvent onDemoGame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameVersionEvents.NativeFieldInfoPtr_onDemoGame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameVersionEvents.NativeFieldInfoPtr_onDemoGame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004DD2 RID: 19922
		private static readonly IntPtr NativeFieldInfoPtr_onFullGame;

		// Token: 0x04004DD3 RID: 19923
		private static readonly IntPtr NativeFieldInfoPtr_onDemoGame;

		// Token: 0x04004DD4 RID: 19924
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004DD5 RID: 19925
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
