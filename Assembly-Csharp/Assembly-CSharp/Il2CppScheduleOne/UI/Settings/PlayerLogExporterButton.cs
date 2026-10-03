using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000793 RID: 1939
	public class PlayerLogExporterButton : MonoBehaviour
	{
		// Token: 0x0600BC25 RID: 48165 RVA: 0x003050E4 File Offset: 0x003032E4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerLogExporterButton()
		{
			Il2CppClassPointerStore<PlayerLogExporterButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "PlayerLogExporterButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLogExporterButton>.NativeClassPtr);
			PlayerLogExporterButton.NativeFieldInfoPtr__exportPreviousLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLogExporterButton>.NativeClassPtr, "_exportPreviousLog");
			PlayerLogExporterButton.NativeFieldInfoPtr_OnSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLogExporterButton>.NativeClassPtr, "OnSuccess");
			PlayerLogExporterButton.NativeFieldInfoPtr__button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLogExporterButton>.NativeClassPtr, "_button");
			PlayerLogExporterButton.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLogExporterButton>.NativeClassPtr, 100687845);
			PlayerLogExporterButton.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLogExporterButton>.NativeClassPtr, 100687846);
			PlayerLogExporterButton.NativeMethodInfoPtr_OnButtonClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLogExporterButton>.NativeClassPtr, 100687847);
			PlayerLogExporterButton.NativeMethodInfoPtr_Success_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLogExporterButton>.NativeClassPtr, 100687848);
			PlayerLogExporterButton.NativeMethodInfoPtr_DoesLogExist_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLogExporterButton>.NativeClassPtr, 100687849);
			PlayerLogExporterButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLogExporterButton>.NativeClassPtr, 100687850);
		}

		// Token: 0x0600BC26 RID: 48166 RVA: 0x003051C8 File Offset: 0x003033C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313772, XrefRangeEnd = 313784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLogExporterButton.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC27 RID: 48167 RVA: 0x003051FC File Offset: 0x003033FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313784, XrefRangeEnd = 313791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLogExporterButton.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC28 RID: 48168 RVA: 0x00305230 File Offset: 0x00303430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313791, XrefRangeEnd = 313801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnButtonClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLogExporterButton.NativeMethodInfoPtr_OnButtonClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC29 RID: 48169 RVA: 0x00305264 File Offset: 0x00303464
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLogExporterButton.NativeMethodInfoPtr_Success_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC2A RID: 48170 RVA: 0x00305298 File Offset: 0x00303498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313801, XrefRangeEnd = 313806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesLogExist()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLogExporterButton.NativeMethodInfoPtr_DoesLogExist_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600BC2B RID: 48171 RVA: 0x003052D4 File Offset: 0x003034D4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerLogExporterButton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLogExporterButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLogExporterButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC2C RID: 48172 RVA: 0x00057B78 File Offset: 0x00055D78
		public PlayerLogExporterButton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038D4 RID: 14548
		// (get) Token: 0x0600BC2D RID: 48173 RVA: 0x00305310 File Offset: 0x00303510
		// (set) Token: 0x0600BC2E RID: 48174 RVA: 0x00057B81 File Offset: 0x00055D81
		public unsafe bool _exportPreviousLog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLogExporterButton.NativeFieldInfoPtr__exportPreviousLog);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLogExporterButton.NativeFieldInfoPtr__exportPreviousLog)) = value;
			}
		}

		// Token: 0x170038D5 RID: 14549
		// (get) Token: 0x0600BC2F RID: 48175 RVA: 0x00305338 File Offset: 0x00303538
		// (set) Token: 0x0600BC30 RID: 48176 RVA: 0x00057B9C File Offset: 0x00055D9C
		public unsafe UnityEvent OnSuccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLogExporterButton.NativeFieldInfoPtr_OnSuccess);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLogExporterButton.NativeFieldInfoPtr_OnSuccess), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038D6 RID: 14550
		// (get) Token: 0x0600BC31 RID: 48177 RVA: 0x00305368 File Offset: 0x00303568
		// (set) Token: 0x0600BC32 RID: 48178 RVA: 0x00057BBB File Offset: 0x00055DBB
		public unsafe Button _button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLogExporterButton.NativeFieldInfoPtr__button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLogExporterButton.NativeFieldInfoPtr__button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040080EF RID: 33007
		private static readonly IntPtr NativeFieldInfoPtr__exportPreviousLog;

		// Token: 0x040080F0 RID: 33008
		private static readonly IntPtr NativeFieldInfoPtr_OnSuccess;

		// Token: 0x040080F1 RID: 33009
		private static readonly IntPtr NativeFieldInfoPtr__button;

		// Token: 0x040080F2 RID: 33010
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040080F3 RID: 33011
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040080F4 RID: 33012
		private static readonly IntPtr NativeMethodInfoPtr_OnButtonClick_Private_Void_0;

		// Token: 0x040080F5 RID: 33013
		private static readonly IntPtr NativeMethodInfoPtr_Success_Private_Void_0;

		// Token: 0x040080F6 RID: 33014
		private static readonly IntPtr NativeMethodInfoPtr_DoesLogExist_Private_Boolean_0;

		// Token: 0x040080F7 RID: 33015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
