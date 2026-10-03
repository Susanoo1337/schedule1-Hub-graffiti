using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004EB RID: 1259
	public class MonoBehaviourEvents : MonoBehaviour
	{
		// Token: 0x06007240 RID: 29248 RVA: 0x00202C78 File Offset: 0x00200E78
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBehaviourEvents()
		{
			Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "MonoBehaviourEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr);
			MonoBehaviourEvents.NativeFieldInfoPtr_onAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, "onAwake");
			MonoBehaviourEvents.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, "onStart");
			MonoBehaviourEvents.NativeFieldInfoPtr_onUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, "onUpdate");
			MonoBehaviourEvents.NativeFieldInfoPtr_onEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, "onEnable");
			MonoBehaviourEvents.NativeFieldInfoPtr_onDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, "onDisable");
			MonoBehaviourEvents.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, 100678079);
			MonoBehaviourEvents.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, 100678080);
			MonoBehaviourEvents.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, 100678081);
			MonoBehaviourEvents.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, 100678082);
			MonoBehaviourEvents.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, 100678083);
			MonoBehaviourEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr, 100678084);
		}

		// Token: 0x06007241 RID: 29249 RVA: 0x00202D84 File Offset: 0x00200F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226235, XrefRangeEnd = 226236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourEvents.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007242 RID: 29250 RVA: 0x00202DB8 File Offset: 0x00200FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226236, XrefRangeEnd = 226237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourEvents.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007243 RID: 29251 RVA: 0x00202DEC File Offset: 0x00200FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226237, XrefRangeEnd = 226238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourEvents.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007244 RID: 29252 RVA: 0x00202E20 File Offset: 0x00201020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226238, XrefRangeEnd = 226239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourEvents.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007245 RID: 29253 RVA: 0x00202E54 File Offset: 0x00201054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226239, XrefRangeEnd = 226240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourEvents.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007246 RID: 29254 RVA: 0x00202E88 File Offset: 0x00201088
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBehaviourEvents() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBehaviourEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007247 RID: 29255 RVA: 0x0003653B File Offset: 0x0003473B
		public MonoBehaviourEvents(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002345 RID: 9029
		// (get) Token: 0x06007248 RID: 29256 RVA: 0x00202EC4 File Offset: 0x002010C4
		// (set) Token: 0x06007249 RID: 29257 RVA: 0x00036544 File Offset: 0x00034744
		public unsafe UnityEvent onAwake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onAwake);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onAwake), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002346 RID: 9030
		// (get) Token: 0x0600724A RID: 29258 RVA: 0x00202EF4 File Offset: 0x002010F4
		// (set) Token: 0x0600724B RID: 29259 RVA: 0x00036563 File Offset: 0x00034763
		public unsafe UnityEvent onStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002347 RID: 9031
		// (get) Token: 0x0600724C RID: 29260 RVA: 0x00202F24 File Offset: 0x00201124
		// (set) Token: 0x0600724D RID: 29261 RVA: 0x00036582 File Offset: 0x00034782
		public unsafe UnityEvent onUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002348 RID: 9032
		// (get) Token: 0x0600724E RID: 29262 RVA: 0x00202F54 File Offset: 0x00201154
		// (set) Token: 0x0600724F RID: 29263 RVA: 0x000365A1 File Offset: 0x000347A1
		public unsafe UnityEvent onEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onEnable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onEnable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002349 RID: 9033
		// (get) Token: 0x06007250 RID: 29264 RVA: 0x00202F84 File Offset: 0x00201184
		// (set) Token: 0x06007251 RID: 29265 RVA: 0x000365C0 File Offset: 0x000347C0
		public unsafe UnityEvent onDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onDisable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBehaviourEvents.NativeFieldInfoPtr_onDisable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E0A RID: 19978
		private static readonly IntPtr NativeFieldInfoPtr_onAwake;

		// Token: 0x04004E0B RID: 19979
		private static readonly IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x04004E0C RID: 19980
		private static readonly IntPtr NativeFieldInfoPtr_onUpdate;

		// Token: 0x04004E0D RID: 19981
		private static readonly IntPtr NativeFieldInfoPtr_onEnable;

		// Token: 0x04004E0E RID: 19982
		private static readonly IntPtr NativeFieldInfoPtr_onDisable;

		// Token: 0x04004E0F RID: 19983
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004E10 RID: 19984
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004E11 RID: 19985
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004E12 RID: 19986
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04004E13 RID: 19987
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04004E14 RID: 19988
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
