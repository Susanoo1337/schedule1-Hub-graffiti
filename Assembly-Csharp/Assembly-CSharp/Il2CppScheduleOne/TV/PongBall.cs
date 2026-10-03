using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x020000FE RID: 254
	public class PongBall : MonoBehaviour
	{
		// Token: 0x0600184E RID: 6222 RVA: 0x000CB968 File Offset: 0x000C9B68
		// Note: this type is marked as 'beforefieldinit'.
		static PongBall()
		{
			Il2CppClassPointerStore<PongBall>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "PongBall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PongBall>.NativeClassPtr);
			PongBall.NativeFieldInfoPtr_Game = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongBall>.NativeClassPtr, "Game");
			PongBall.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongBall>.NativeClassPtr, "Rect");
			PongBall.NativeFieldInfoPtr_RB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongBall>.NativeClassPtr, "RB");
			PongBall.NativeFieldInfoPtr_RandomForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongBall>.NativeClassPtr, "RandomForce");
			PongBall.NativeFieldInfoPtr_onHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PongBall>.NativeClassPtr, "onHit");
			PongBall.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongBall>.NativeClassPtr, 100666596);
			PongBall.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongBall>.NativeClassPtr, 100666597);
			PongBall.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PongBall>.NativeClassPtr, 100666598);
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x000CBA38 File Offset: 0x000C9C38
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongBall.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x000CBA6C File Offset: 0x000C9C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98183, XrefRangeEnd = 98214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongBall.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x000CBAB0 File Offset: 0x000C9CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98214, XrefRangeEnd = 98215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PongBall() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PongBall>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PongBall.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x0000D533 File Offset: 0x0000B733
		public PongBall(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06001853 RID: 6227 RVA: 0x000CBAEC File Offset: 0x000C9CEC
		// (set) Token: 0x06001854 RID: 6228 RVA: 0x0000D53C File Offset: 0x0000B73C
		public unsafe Pong Game
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_Game);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pong>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_Game), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x000CBB1C File Offset: 0x000C9D1C
		// (set) Token: 0x06001856 RID: 6230 RVA: 0x0000D55B File Offset: 0x0000B75B
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06001857 RID: 6231 RVA: 0x000CBB4C File Offset: 0x000C9D4C
		// (set) Token: 0x06001858 RID: 6232 RVA: 0x0000D57A File Offset: 0x0000B77A
		public unsafe Rigidbody RB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_RB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_RB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06001859 RID: 6233 RVA: 0x000CBB7C File Offset: 0x000C9D7C
		// (set) Token: 0x0600185A RID: 6234 RVA: 0x0000D599 File Offset: 0x0000B799
		public unsafe float RandomForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_RandomForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_RandomForce)) = value;
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x000CBBA4 File Offset: 0x000C9DA4
		// (set) Token: 0x0600185C RID: 6236 RVA: 0x0000D5B4 File Offset: 0x0000B7B4
		public unsafe UnityEvent onHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_onHit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PongBall.NativeFieldInfoPtr_onHit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010E4 RID: 4324
		private static readonly IntPtr NativeFieldInfoPtr_Game;

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeFieldInfoPtr_RB;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeFieldInfoPtr_RandomForce;

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeFieldInfoPtr_onHit;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
