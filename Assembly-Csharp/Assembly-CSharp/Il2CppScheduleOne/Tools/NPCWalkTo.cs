using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004ED RID: 1261
	public class NPCWalkTo : MonoBehaviour
	{
		// Token: 0x0600725A RID: 29274 RVA: 0x00203108 File Offset: 0x00201308
		// Note: this type is marked as 'beforefieldinit'.
		static NPCWalkTo()
		{
			Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "NPCWalkTo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr);
			NPCWalkTo.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr, "Target");
			NPCWalkTo.NativeFieldInfoPtr_RepathRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr, "RepathRate");
			NPCWalkTo.NativeFieldInfoPtr_timeSinceLastPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr, "timeSinceLastPath");
			NPCWalkTo.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr, 100678087);
			NPCWalkTo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr, 100678088);
		}

		// Token: 0x0600725B RID: 29275 RVA: 0x0020319C File Offset: 0x0020139C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226268, XrefRangeEnd = 226274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCWalkTo.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600725C RID: 29276 RVA: 0x002031D0 File Offset: 0x002013D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226274, XrefRangeEnd = 226275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCWalkTo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCWalkTo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCWalkTo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600725D RID: 29277 RVA: 0x00036622 File Offset: 0x00034822
		public NPCWalkTo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700234C RID: 9036
		// (get) Token: 0x0600725E RID: 29278 RVA: 0x0020320C File Offset: 0x0020140C
		// (set) Token: 0x0600725F RID: 29279 RVA: 0x0003662B File Offset: 0x0003482B
		public unsafe Transform Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700234D RID: 9037
		// (get) Token: 0x06007260 RID: 29280 RVA: 0x0020323C File Offset: 0x0020143C
		// (set) Token: 0x06007261 RID: 29281 RVA: 0x0003664A File Offset: 0x0003484A
		public unsafe float RepathRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_RepathRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_RepathRate)) = value;
			}
		}

		// Token: 0x1700234E RID: 9038
		// (get) Token: 0x06007262 RID: 29282 RVA: 0x00203264 File Offset: 0x00201464
		// (set) Token: 0x06007263 RID: 29283 RVA: 0x00036665 File Offset: 0x00034865
		public unsafe float timeSinceLastPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_timeSinceLastPath);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCWalkTo.NativeFieldInfoPtr_timeSinceLastPath)) = value;
			}
		}

		// Token: 0x04004E19 RID: 19993
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x04004E1A RID: 19994
		private static readonly IntPtr NativeFieldInfoPtr_RepathRate;

		// Token: 0x04004E1B RID: 19995
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastPath;

		// Token: 0x04004E1C RID: 19996
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004E1D RID: 19997
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
