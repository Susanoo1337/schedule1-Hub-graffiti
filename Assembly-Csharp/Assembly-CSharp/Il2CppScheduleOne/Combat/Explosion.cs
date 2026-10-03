using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x020006FC RID: 1788
	public class Explosion : MonoBehaviour
	{
		// Token: 0x0600AC15 RID: 44053 RVA: 0x002D4B40 File Offset: 0x002D2D40
		// Note: this type is marked as 'beforefieldinit'.
		static Explosion()
		{
			Il2CppClassPointerStore<Explosion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "Explosion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Explosion>.NativeClassPtr);
			Explosion.NativeFieldInfoPtr_Sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Explosion>.NativeClassPtr, "Sound");
			Explosion.NativeMethodInfoPtr_Initialize_Public_Void_Vector3_ExplosionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Explosion>.NativeClassPtr, 100686015);
			Explosion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Explosion>.NativeClassPtr, 100686016);
		}

		// Token: 0x0600AC16 RID: 44054 RVA: 0x002D4BAC File Offset: 0x002D2DAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295470, RefRangeEnd = 295471, XrefRangeStart = 295368, XrefRangeEnd = 295470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Vector3 origin, ExplosionData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Explosion.NativeMethodInfoPtr_Initialize_Public_Void_Vector3_ExplosionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC17 RID: 44055 RVA: 0x002D4BF8 File Offset: 0x002D2DF8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Explosion() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Explosion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Explosion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC18 RID: 44056 RVA: 0x0004EAD7 File Offset: 0x0004CCD7
		public Explosion(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700338E RID: 13198
		// (get) Token: 0x0600AC19 RID: 44057 RVA: 0x002D4C34 File Offset: 0x002D2E34
		// (set) Token: 0x0600AC1A RID: 44058 RVA: 0x0004EAE0 File Offset: 0x0004CCE0
		public unsafe AudioSourceController Sound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_Sound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_Sound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040076CC RID: 30412
		private static readonly IntPtr NativeFieldInfoPtr_Sound;

		// Token: 0x040076CD RID: 30413
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Vector3_ExplosionData_0;

		// Token: 0x040076CE RID: 30414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
