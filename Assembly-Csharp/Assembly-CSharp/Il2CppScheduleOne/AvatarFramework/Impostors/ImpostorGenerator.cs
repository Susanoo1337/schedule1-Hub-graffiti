using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Impostors
{
	// Token: 0x020004A3 RID: 1187
	public class ImpostorGenerator : MonoBehaviour
	{
		// Token: 0x06006C9E RID: 27806 RVA: 0x001F2B4C File Offset: 0x001F0D4C
		// Note: this type is marked as 'beforefieldinit'.
		static ImpostorGenerator()
		{
			Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Impostors", "ImpostorGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr);
			ImpostorGenerator.NativeFieldInfoPtr_ImpostorCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr, "ImpostorCamera");
			ImpostorGenerator.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr, "Avatar");
			ImpostorGenerator.NativeFieldInfoPtr_GenerationQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr, "GenerationQueue");
			ImpostorGenerator.NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr, "output");
			ImpostorGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr, 100677489);
		}

		// Token: 0x06006C9F RID: 27807 RVA: 0x001F2BE0 File Offset: 0x001F0DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221337, XrefRangeEnd = 221345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImpostorGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpostorGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpostorGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CA0 RID: 27808 RVA: 0x000333AC File Offset: 0x000315AC
		public ImpostorGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700216D RID: 8557
		// (get) Token: 0x06006CA1 RID: 27809 RVA: 0x001F2C1C File Offset: 0x001F0E1C
		// (set) Token: 0x06006CA2 RID: 27810 RVA: 0x000333B5 File Offset: 0x000315B5
		public unsafe Camera ImpostorCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_ImpostorCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_ImpostorCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700216E RID: 8558
		// (get) Token: 0x06006CA3 RID: 27811 RVA: 0x001F2C4C File Offset: 0x001F0E4C
		// (set) Token: 0x06006CA4 RID: 27812 RVA: 0x000333D4 File Offset: 0x000315D4
		public unsafe Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700216F RID: 8559
		// (get) Token: 0x06006CA5 RID: 27813 RVA: 0x001F2C7C File Offset: 0x001F0E7C
		// (set) Token: 0x06006CA6 RID: 27814 RVA: 0x000333F3 File Offset: 0x000315F3
		public unsafe List<AvatarSettings> GenerationQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_GenerationQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AvatarSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_GenerationQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002170 RID: 8560
		// (get) Token: 0x06006CA7 RID: 27815 RVA: 0x001F2CAC File Offset: 0x001F0EAC
		// (set) Token: 0x06006CA8 RID: 27816 RVA: 0x00033412 File Offset: 0x00031612
		public unsafe Texture2D output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_output);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpostorGenerator.NativeFieldInfoPtr_output), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004AA9 RID: 19113
		private static readonly IntPtr NativeFieldInfoPtr_ImpostorCamera;

		// Token: 0x04004AAA RID: 19114
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04004AAB RID: 19115
		private static readonly IntPtr NativeFieldInfoPtr_GenerationQueue;

		// Token: 0x04004AAC RID: 19116
		private static readonly IntPtr NativeFieldInfoPtr_output;

		// Token: 0x04004AAD RID: 19117
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
