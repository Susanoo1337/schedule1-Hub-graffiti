using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.AvatarFramework.Animation;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Other
{
	// Token: 0x020006A2 RID: 1698
	public class SprayPaint : MonoBehaviour
	{
		// Token: 0x0600A59B RID: 42395 RVA: 0x002BF2C0 File Offset: 0x002BD4C0
		// Note: this type is marked as 'beforefieldinit'.
		static SprayPaint()
		{
			Il2CppClassPointerStore<SprayPaint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Other", "SprayPaint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SprayPaint>.NativeClassPtr);
			SprayPaint.NativeFieldInfoPtr__npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayPaint>.NativeClassPtr, "_npc");
			SprayPaint.NativeFieldInfoPtr__sprayPaintPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayPaint>.NativeClassPtr, "_sprayPaintPrefab");
			SprayPaint.NativeFieldInfoPtr__anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayPaint>.NativeClassPtr, "_anim");
			SprayPaint.NativeFieldInfoPtr__spraySound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayPaint>.NativeClassPtr, "_spraySound");
			SprayPaint.NativeFieldInfoPtr__sprayPaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayPaint>.NativeClassPtr, "_sprayPaint");
			SprayPaint.NativeFieldInfoPtr__sprayEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayPaint>.NativeClassPtr, "_sprayEffect");
			SprayPaint.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayPaint>.NativeClassPtr, 100685262);
			SprayPaint.NativeMethodInfoPtr_Begin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayPaint>.NativeClassPtr, 100685263);
			SprayPaint.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayPaint>.NativeClassPtr, 100685264);
			SprayPaint.NativeMethodInfoPtr_SetEffect_Public_Void_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayPaint>.NativeClassPtr, 100685265);
			SprayPaint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayPaint>.NativeClassPtr, 100685266);
		}

		// Token: 0x0600A59C RID: 42396 RVA: 0x002BF3CC File Offset: 0x002BD5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289643, XrefRangeEnd = 289658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SprayPaint.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A59D RID: 42397 RVA: 0x002BF400 File Offset: 0x002BD600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289672, RefRangeEnd = 289673, XrefRangeStart = 289658, XrefRangeEnd = 289672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SprayPaint.NativeMethodInfoPtr_Begin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A59E RID: 42398 RVA: 0x002BF434 File Offset: 0x002BD634
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289684, RefRangeEnd = 289686, XrefRangeStart = 289673, XrefRangeEnd = 289684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SprayPaint.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A59F RID: 42399 RVA: 0x002BF468 File Offset: 0x002BD668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289693, RefRangeEnd = 289694, XrefRangeStart = 289686, XrefRangeEnd = 289693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEffect(bool value, Color colour = default(Color))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colour;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SprayPaint.NativeMethodInfoPtr_SetEffect_Public_Void_Boolean_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5A0 RID: 42400 RVA: 0x002BF4B4 File Offset: 0x002BD6B4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SprayPaint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SprayPaint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SprayPaint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5A1 RID: 42401 RVA: 0x0004B9B8 File Offset: 0x00049BB8
		public SprayPaint(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031B5 RID: 12725
		// (get) Token: 0x0600A5A2 RID: 42402 RVA: 0x002BF4F0 File Offset: 0x002BD6F0
		// (set) Token: 0x0600A5A3 RID: 42403 RVA: 0x0004B9C1 File Offset: 0x00049BC1
		public unsafe NPC _npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayPaint.NativeFieldInfoPtr__npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayPaint.NativeFieldInfoPtr__npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031B6 RID: 12726
		// (get) Token: 0x0600A5A4 RID: 42404 RVA: 0x002BF520 File Offset: 0x002BD720
		// (set) Token: 0x0600A5A5 RID: 42405 RVA: 0x0004B9E0 File Offset: 0x00049BE0
		public unsafe AvatarEquippable _sprayPaintPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayPaint.NativeFieldInfoPtr__sprayPaintPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayPaint.NativeFieldInfoPtr__sprayPaintPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031B7 RID: 12727
		// (get) Token: 0x0600A5A6 RID: 42406 RVA: 0x002BF550 File Offset: 0x002BD750
		// (set) Token: 0x0600A5A7 RID: 42407 RVA: 0x0004B9FF File Offset: 0x00049BFF
		public unsafe AvatarAnimation _anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayPaint.NativeFieldInfoPtr__anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayPaint.NativeFieldInfoPtr__anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031B8 RID: 12728
		// (get) Token: 0x0600A5A8 RID: 42408 RVA: 0x002BF580 File Offset: 0x002BD780
		// (set) Token: 0x0600A5A9 RID: 42409 RVA: 0x0004BA1E File Offset: 0x00049C1E
		public unsafe AudioSourceController _spraySound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayPaint.NativeFieldInfoPtr__spraySound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayPaint.NativeFieldInfoPtr__spraySound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031B9 RID: 12729
		// (get) Token: 0x0600A5AA RID: 42410 RVA: 0x002BF5B0 File Offset: 0x002BD7B0
		// (set) Token: 0x0600A5AB RID: 42411 RVA: 0x0004BA3D File Offset: 0x00049C3D
		public unsafe AvatarEquippable _sprayPaint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayPaint.NativeFieldInfoPtr__sprayPaint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayPaint.NativeFieldInfoPtr__sprayPaint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031BA RID: 12730
		// (get) Token: 0x0600A5AC RID: 42412 RVA: 0x002BF5E0 File Offset: 0x002BD7E0
		// (set) Token: 0x0600A5AD RID: 42413 RVA: 0x0004BA5C File Offset: 0x00049C5C
		public unsafe ParticleSystem _sprayEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayPaint.NativeFieldInfoPtr__sprayEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayPaint.NativeFieldInfoPtr__sprayEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400728E RID: 29326
		private static readonly IntPtr NativeFieldInfoPtr__npc;

		// Token: 0x0400728F RID: 29327
		private static readonly IntPtr NativeFieldInfoPtr__sprayPaintPrefab;

		// Token: 0x04007290 RID: 29328
		private static readonly IntPtr NativeFieldInfoPtr__anim;

		// Token: 0x04007291 RID: 29329
		private static readonly IntPtr NativeFieldInfoPtr__spraySound;

		// Token: 0x04007292 RID: 29330
		private static readonly IntPtr NativeFieldInfoPtr__sprayPaint;

		// Token: 0x04007293 RID: 29331
		private static readonly IntPtr NativeFieldInfoPtr__sprayEffect;

		// Token: 0x04007294 RID: 29332
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007295 RID: 29333
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Void_0;

		// Token: 0x04007296 RID: 29334
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x04007297 RID: 29335
		private static readonly IntPtr NativeMethodInfoPtr_SetEffect_Public_Void_Boolean_Color_0;

		// Token: 0x04007298 RID: 29336
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
