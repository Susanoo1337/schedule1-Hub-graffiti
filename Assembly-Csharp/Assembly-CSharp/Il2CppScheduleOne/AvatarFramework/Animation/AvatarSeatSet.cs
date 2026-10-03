using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x020004BF RID: 1215
	public class AvatarSeatSet : MonoBehaviour
	{
		// Token: 0x06006F7C RID: 28540 RVA: 0x001FAAF0 File Offset: 0x001F8CF0
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarSeatSet()
		{
			Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarSeatSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr);
			AvatarSeatSet.NativeFieldInfoPtr_Seats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr, "Seats");
			AvatarSeatSet.NativeMethodInfoPtr_GetFirstFreeSeat_Public_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr, 100677740);
			AvatarSeatSet.NativeMethodInfoPtr_GetRandomFreeSeat_Public_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr, 100677741);
			AvatarSeatSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr, 100677742);
		}

		// Token: 0x06006F7D RID: 28541 RVA: 0x001FAB70 File Offset: 0x001F8D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223763, XrefRangeEnd = 223770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSeat GetFirstFreeSeat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeatSet.NativeMethodInfoPtr_GetFirstFreeSeat_Public_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarSeat>(intPtr3) : null;
		}

		// Token: 0x06006F7E RID: 28542 RVA: 0x001FABB0 File Offset: 0x001F8DB0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 223802, RefRangeEnd = 223809, XrefRangeStart = 223770, XrefRangeEnd = 223802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSeat GetRandomFreeSeat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeatSet.NativeMethodInfoPtr_GetRandomFreeSeat_Public_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarSeat>(intPtr3) : null;
		}

		// Token: 0x06006F7F RID: 28543 RVA: 0x001FABF0 File Offset: 0x001F8DF0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSeatSet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeatSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F80 RID: 28544 RVA: 0x00034DE8 File Offset: 0x00032FE8
		public AvatarSeatSet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002272 RID: 8818
		// (get) Token: 0x06006F81 RID: 28545 RVA: 0x001FAC2C File Offset: 0x001F8E2C
		// (set) Token: 0x06006F82 RID: 28546 RVA: 0x00034DF1 File Offset: 0x00032FF1
		public unsafe Il2CppReferenceArray<AvatarSeat> Seats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeatSet.NativeFieldInfoPtr_Seats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AvatarSeat>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeatSet.NativeFieldInfoPtr_Seats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004C5C RID: 19548
		private static readonly IntPtr NativeFieldInfoPtr_Seats;

		// Token: 0x04004C5D RID: 19549
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstFreeSeat_Public_AvatarSeat_0;

		// Token: 0x04004C5E RID: 19550
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomFreeSeat_Public_AvatarSeat_0;

		// Token: 0x04004C5F RID: 19551
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B7D RID: 2941
		[ObfuscatedName("ScheduleOne.AvatarFramework.Animation.AvatarSeatSet+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E8F5 RID: 59637 RVA: 0x0038AFDC File Offset: 0x003891DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr);
				AvatarSeatSet.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr, "<>9");
				AvatarSeatSet.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr, "<>9__2_0");
				AvatarSeatSet.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr, 100677744);
				AvatarSeatSet.__c.NativeMethodInfoPtr__GetRandomFreeSeat_b__2_0_Internal_Boolean_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr, 100677745);
			}

			// Token: 0x0600E8F6 RID: 59638 RVA: 0x0038B058 File Offset: 0x00389258
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeatSet.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E8F7 RID: 59639 RVA: 0x0038B094 File Offset: 0x00389294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223759, XrefRangeEnd = 223763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRandomFreeSeat_b__2_0(AvatarSeat x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeatSet.__c.NativeMethodInfoPtr__GetRandomFreeSeat_b__2_0_Internal_Boolean_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E8F8 RID: 59640 RVA: 0x0006DE3D File Offset: 0x0006C03D
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046A7 RID: 18087
			// (get) Token: 0x0600E8F9 RID: 59641 RVA: 0x0038B0E4 File Offset: 0x003892E4
			// (set) Token: 0x0600E8FA RID: 59642 RVA: 0x0006DE46 File Offset: 0x0006C046
			public unsafe static AvatarSeatSet.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarSeatSet.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSeatSet.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarSeatSet.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046A8 RID: 18088
			// (get) Token: 0x0600E8FB RID: 59643 RVA: 0x0038B10C File Offset: 0x0038930C
			// (set) Token: 0x0600E8FC RID: 59644 RVA: 0x0006DE58 File Offset: 0x0006C058
			public unsafe static Func<AvatarSeat, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarSeatSet.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AvatarSeat, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarSeatSet.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009E02 RID: 40450
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009E03 RID: 40451
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04009E04 RID: 40452
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009E05 RID: 40453
			private static readonly IntPtr NativeMethodInfoPtr__GetRandomFreeSeat_b__2_0_Internal_Boolean_AvatarSeat_0;
		}
	}
}
