using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x020004C4 RID: 1220
	public class AvatarGun : AvatarRangedWeapon
	{
		// Token: 0x06006FC3 RID: 28611 RVA: 0x001FB8C0 File Offset: 0x001F9AC0
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarGun()
		{
			Il2CppClassPointerStore<AvatarGun>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "AvatarGun");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarGun>.NativeClassPtr);
			AvatarGun.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarGun>.NativeClassPtr, "Anim");
			AvatarGun.NativeFieldInfoPtr_ShellParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarGun>.NativeClassPtr, "ShellParticles");
			AvatarGun.NativeFieldInfoPtr_SmokeParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarGun>.NativeClassPtr, "SmokeParticles");
			AvatarGun.NativeFieldInfoPtr_FlashObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarGun>.NativeClassPtr, "FlashObject");
			AvatarGun.NativeFieldInfoPtr_RayPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarGun>.NativeClassPtr, "RayPrefab");
			AvatarGun.NativeFieldInfoPtr_flashRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarGun>.NativeClassPtr, "flashRoutine");
			AvatarGun.NativeMethodInfoPtr_Shoot_Protected_Virtual_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarGun>.NativeClassPtr, 100677776);
			AvatarGun.NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarGun>.NativeClassPtr, 100677777);
			AvatarGun.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarGun>.NativeClassPtr, 100677778);
		}

		// Token: 0x06006FC4 RID: 28612 RVA: 0x001FB9A4 File Offset: 0x001F9BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224115, XrefRangeEnd = 224151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Shoot(Vector3 endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarGun.NativeMethodInfoPtr_Shoot_Protected_Virtual_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FC5 RID: 28613 RVA: 0x001FB9F0 File Offset: 0x001F9BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224151, XrefRangeEnd = 224156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Flash(Vector3 endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarGun.NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006FC6 RID: 28614 RVA: 0x001FBA3C File Offset: 0x001F9C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224156, XrefRangeEnd = 224157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarGun() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarGun>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarGun.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006FC7 RID: 28615 RVA: 0x00035008 File Offset: 0x00033208
		public AvatarGun(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002283 RID: 8835
		// (get) Token: 0x06006FC8 RID: 28616 RVA: 0x001FBA78 File Offset: 0x001F9C78
		// (set) Token: 0x06006FC9 RID: 28617 RVA: 0x00035011 File Offset: 0x00033211
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarGun.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarGun.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002284 RID: 8836
		// (get) Token: 0x06006FCA RID: 28618 RVA: 0x001FBAA8 File Offset: 0x001F9CA8
		// (set) Token: 0x06006FCB RID: 28619 RVA: 0x00035030 File Offset: 0x00033230
		public unsafe ParticleSystem ShellParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarGun.NativeFieldInfoPtr_ShellParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarGun.NativeFieldInfoPtr_ShellParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002285 RID: 8837
		// (get) Token: 0x06006FCC RID: 28620 RVA: 0x001FBAD8 File Offset: 0x001F9CD8
		// (set) Token: 0x06006FCD RID: 28621 RVA: 0x0003504F File Offset: 0x0003324F
		public unsafe ParticleSystem SmokeParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarGun.NativeFieldInfoPtr_SmokeParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarGun.NativeFieldInfoPtr_SmokeParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002286 RID: 8838
		// (get) Token: 0x06006FCE RID: 28622 RVA: 0x001FBB08 File Offset: 0x001F9D08
		// (set) Token: 0x06006FCF RID: 28623 RVA: 0x0003506E File Offset: 0x0003326E
		public unsafe Transform FlashObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarGun.NativeFieldInfoPtr_FlashObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarGun.NativeFieldInfoPtr_FlashObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002287 RID: 8839
		// (get) Token: 0x06006FD0 RID: 28624 RVA: 0x001FBB38 File Offset: 0x001F9D38
		// (set) Token: 0x06006FD1 RID: 28625 RVA: 0x0003508D File Offset: 0x0003328D
		public unsafe GameObject RayPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarGun.NativeFieldInfoPtr_RayPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarGun.NativeFieldInfoPtr_RayPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002288 RID: 8840
		// (get) Token: 0x06006FD2 RID: 28626 RVA: 0x001FBB68 File Offset: 0x001F9D68
		// (set) Token: 0x06006FD3 RID: 28627 RVA: 0x000350AC File Offset: 0x000332AC
		public unsafe Coroutine flashRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarGun.NativeFieldInfoPtr_flashRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarGun.NativeFieldInfoPtr_flashRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C88 RID: 19592
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04004C89 RID: 19593
		private static readonly IntPtr NativeFieldInfoPtr_ShellParticles;

		// Token: 0x04004C8A RID: 19594
		private static readonly IntPtr NativeFieldInfoPtr_SmokeParticles;

		// Token: 0x04004C8B RID: 19595
		private static readonly IntPtr NativeFieldInfoPtr_FlashObject;

		// Token: 0x04004C8C RID: 19596
		private static readonly IntPtr NativeFieldInfoPtr_RayPrefab;

		// Token: 0x04004C8D RID: 19597
		private static readonly IntPtr NativeFieldInfoPtr_flashRoutine;

		// Token: 0x04004C8E RID: 19598
		private static readonly IntPtr NativeMethodInfoPtr_Shoot_Protected_Virtual_Void_Vector3_0;

		// Token: 0x04004C8F RID: 19599
		private static readonly IntPtr NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0;

		// Token: 0x04004C90 RID: 19600
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B81 RID: 2945
		[ObfuscatedName("ScheduleOne.AvatarFramework.Equipping.AvatarGun+<Flash>d__7")]
		public sealed class _Flash_d__7 : Il2CppSystem.Object
		{
			// Token: 0x0600E90B RID: 59659 RVA: 0x0038B408 File Offset: 0x00389608
			// Note: this type is marked as 'beforefieldinit'.
			static _Flash_d__7()
			{
				Il2CppClassPointerStore<AvatarGun._Flash_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarGun>.NativeClassPtr, "<Flash>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarGun._Flash_d__7>.NativeClassPtr);
				AvatarGun._Flash_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarGun._Flash_d__7>.NativeClassPtr, "<>1__state");
				AvatarGun._Flash_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarGun._Flash_d__7>.NativeClassPtr, "<>2__current");
				AvatarGun._Flash_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarGun._Flash_d__7>.NativeClassPtr, "<>4__this");
				AvatarGun._Flash_d__7.NativeFieldInfoPtr_endPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarGun._Flash_d__7>.NativeClassPtr, "endPoint");
				AvatarGun._Flash_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarGun._Flash_d__7>.NativeClassPtr, 100677779);
				AvatarGun._Flash_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarGun._Flash_d__7>.NativeClassPtr, 100677780);
				AvatarGun._Flash_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarGun._Flash_d__7>.NativeClassPtr, 100677781);
				AvatarGun._Flash_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarGun._Flash_d__7>.NativeClassPtr, 100677782);
				AvatarGun._Flash_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarGun._Flash_d__7>.NativeClassPtr, 100677783);
				AvatarGun._Flash_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarGun._Flash_d__7>.NativeClassPtr, 100677784);
			}

			// Token: 0x0600E90C RID: 59660 RVA: 0x0038B4FC File Offset: 0x003896FC
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Flash_d__7(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarGun._Flash_d__7>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarGun._Flash_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E90D RID: 59661 RVA: 0x0038B544 File Offset: 0x00389744
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarGun._Flash_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E90E RID: 59662 RVA: 0x0038B578 File Offset: 0x00389778
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224069, XrefRangeEnd = 224110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarGun._Flash_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170046B2 RID: 18098
			// (get) Token: 0x0600E90F RID: 59663 RVA: 0x0038B5B4 File Offset: 0x003897B4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarGun._Flash_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E910 RID: 59664 RVA: 0x0038B5F4 File Offset: 0x003897F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224110, XrefRangeEnd = 224115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarGun._Flash_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170046B3 RID: 18099
			// (get) Token: 0x0600E911 RID: 59665 RVA: 0x0038B628 File Offset: 0x00389828
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarGun._Flash_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E912 RID: 59666 RVA: 0x0006DECC File Offset: 0x0006C0CC
			public _Flash_d__7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046AE RID: 18094
			// (get) Token: 0x0600E913 RID: 59667 RVA: 0x0038B668 File Offset: 0x00389868
			// (set) Token: 0x0600E914 RID: 59668 RVA: 0x0006DED5 File Offset: 0x0006C0D5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarGun._Flash_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarGun._Flash_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170046AF RID: 18095
			// (get) Token: 0x0600E915 RID: 59669 RVA: 0x0038B690 File Offset: 0x00389890
			// (set) Token: 0x0600E916 RID: 59670 RVA: 0x0006DEF0 File Offset: 0x0006C0F0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarGun._Flash_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarGun._Flash_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046B0 RID: 18096
			// (get) Token: 0x0600E917 RID: 59671 RVA: 0x0038B6C0 File Offset: 0x003898C0
			// (set) Token: 0x0600E918 RID: 59672 RVA: 0x0006DF0F File Offset: 0x0006C10F
			public unsafe AvatarGun __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarGun._Flash_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarGun>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarGun._Flash_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046B1 RID: 18097
			// (get) Token: 0x0600E919 RID: 59673 RVA: 0x0038B6F0 File Offset: 0x003898F0
			// (set) Token: 0x0600E91A RID: 59674 RVA: 0x0006DF2E File Offset: 0x0006C12E
			public unsafe Vector3 endPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarGun._Flash_d__7.NativeFieldInfoPtr_endPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarGun._Flash_d__7.NativeFieldInfoPtr_endPoint)) = value;
				}
			}

			// Token: 0x04009E15 RID: 40469
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009E16 RID: 40470
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009E17 RID: 40471
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009E18 RID: 40472
			private static readonly IntPtr NativeFieldInfoPtr_endPoint;

			// Token: 0x04009E19 RID: 40473
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009E1A RID: 40474
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009E1B RID: 40475
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009E1C RID: 40476
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009E1D RID: 40477
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009E1E RID: 40478
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
