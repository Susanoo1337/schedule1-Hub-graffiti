using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x0200015E RID: 350
	public class StateMachine : MonoBehaviour
	{
		// Token: 0x0600227F RID: 8831 RVA: 0x000ECBD4 File Offset: 0x000EADD4
		// Note: this type is marked as 'beforefieldinit'.
		static StateMachine()
		{
			Il2CppClassPointerStore<StateMachine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "StateMachine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachine>.NativeClassPtr);
			StateMachine.NativeFieldInfoPtr_OnStateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachine>.NativeClassPtr, "OnStateChange");
			StateMachine.NativeFieldInfoPtr_stateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachine>.NativeClassPtr, "stateChanged");
			StateMachine.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachine>.NativeClassPtr, 100667743);
			StateMachine.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachine>.NativeClassPtr, 100667744);
			StateMachine.NativeMethodInfoPtr_Clean_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachine>.NativeClassPtr, 100667745);
			StateMachine.NativeMethodInfoPtr_ChangeState_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachine>.NativeClassPtr, 100667746);
			StateMachine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachine>.NativeClassPtr, 100667747);
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x000ECC90 File Offset: 0x000EAE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111679, XrefRangeEnd = 111691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachine.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x000ECCC4 File Offset: 0x000EAEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111691, XrefRangeEnd = 111694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachine.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x000ECCF8 File Offset: 0x000EAEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111694, XrefRangeEnd = 111704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachine.NativeMethodInfoPtr_Clean_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x000ECD2C File Offset: 0x000EAF2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 111706, RefRangeEnd = 111709, XrefRangeStart = 111704, XrefRangeEnd = 111706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ChangeState()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachine.NativeMethodInfoPtr_ChangeState_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x000ECD54 File Offset: 0x000EAF54
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateMachine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x000126A7 File Offset: 0x000108A7
		public StateMachine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06002286 RID: 8838 RVA: 0x000ECD90 File Offset: 0x000EAF90
		// (set) Token: 0x06002287 RID: 8839 RVA: 0x000126B0 File Offset: 0x000108B0
		public unsafe static Action OnStateChange
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StateMachine.NativeFieldInfoPtr_OnStateChange, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StateMachine.NativeFieldInfoPtr_OnStateChange, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06002288 RID: 8840 RVA: 0x000ECDB8 File Offset: 0x000EAFB8
		// (set) Token: 0x06002289 RID: 8841 RVA: 0x000126C2 File Offset: 0x000108C2
		public unsafe static bool stateChanged
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(StateMachine.NativeFieldInfoPtr_stateChanged, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StateMachine.NativeFieldInfoPtr_stateChanged, (void*)(&value));
			}
		}

		// Token: 0x040017CD RID: 6093
		private static readonly IntPtr NativeFieldInfoPtr_OnStateChange;

		// Token: 0x040017CE RID: 6094
		private static readonly IntPtr NativeFieldInfoPtr_stateChanged;

		// Token: 0x040017CF RID: 6095
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040017D0 RID: 6096
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040017D1 RID: 6097
		private static readonly IntPtr NativeMethodInfoPtr_Clean_Private_Void_0;

		// Token: 0x040017D2 RID: 6098
		private static readonly IntPtr NativeMethodInfoPtr_ChangeState_Public_Static_Void_0;

		// Token: 0x040017D3 RID: 6099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
