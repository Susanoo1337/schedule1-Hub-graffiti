using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000731 RID: 1841
	public class Flipboard : MonoBehaviour
	{
		// Token: 0x0600B187 RID: 45447 RVA: 0x002E5830 File Offset: 0x002E3A30
		// Note: this type is marked as 'beforefieldinit'.
		static Flipboard()
		{
			Il2CppClassPointerStore<Flipboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "Flipboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Flipboard>.NativeClassPtr);
			Flipboard.NativeFieldInfoPtr_Sprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "Sprites");
			Flipboard.NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "Image");
			Flipboard.NativeFieldInfoPtr_FlipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "FlipTime");
			Flipboard.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "SpeedMultiplier");
			Flipboard.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "time");
			Flipboard.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "index");
			Flipboard.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, 100686639);
			Flipboard.NativeMethodInfoPtr_SetIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, 100686640);
			Flipboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, 100686641);
		}

		// Token: 0x0600B188 RID: 45448 RVA: 0x002E5914 File Offset: 0x002E3B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301062, XrefRangeEnd = 301064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flipboard.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B189 RID: 45449 RVA: 0x002E5948 File Offset: 0x002E3B48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301067, RefRangeEnd = 301068, XrefRangeStart = 301064, XrefRangeEnd = 301067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flipboard.NativeMethodInfoPtr_SetIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B18A RID: 45450 RVA: 0x002E5988 File Offset: 0x002E3B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301068, XrefRangeEnd = 301069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Flipboard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Flipboard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flipboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B18B RID: 45451 RVA: 0x000519A1 File Offset: 0x0004FBA1
		public Flipboard(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700355A RID: 13658
		// (get) Token: 0x0600B18C RID: 45452 RVA: 0x002E59C4 File Offset: 0x002E3BC4
		// (set) Token: 0x0600B18D RID: 45453 RVA: 0x000519AA File Offset: 0x0004FBAA
		public unsafe Il2CppReferenceArray<Sprite> Sprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_Sprites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_Sprites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700355B RID: 13659
		// (get) Token: 0x0600B18E RID: 45454 RVA: 0x002E59F4 File Offset: 0x002E3BF4
		// (set) Token: 0x0600B18F RID: 45455 RVA: 0x000519C9 File Offset: 0x0004FBC9
		public unsafe Image Image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_Image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700355C RID: 13660
		// (get) Token: 0x0600B190 RID: 45456 RVA: 0x002E5A24 File Offset: 0x002E3C24
		// (set) Token: 0x0600B191 RID: 45457 RVA: 0x000519E8 File Offset: 0x0004FBE8
		public unsafe float FlipTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_FlipTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_FlipTime)) = value;
			}
		}

		// Token: 0x1700355D RID: 13661
		// (get) Token: 0x0600B192 RID: 45458 RVA: 0x002E5A4C File Offset: 0x002E3C4C
		// (set) Token: 0x0600B193 RID: 45459 RVA: 0x00051A03 File Offset: 0x0004FC03
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x1700355E RID: 13662
		// (get) Token: 0x0600B194 RID: 45460 RVA: 0x002E5A74 File Offset: 0x002E3C74
		// (set) Token: 0x0600B195 RID: 45461 RVA: 0x00051A1E File Offset: 0x0004FC1E
		public unsafe float time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_time)) = value;
			}
		}

		// Token: 0x1700355F RID: 13663
		// (get) Token: 0x0600B196 RID: 45462 RVA: 0x002E5A9C File Offset: 0x002E3C9C
		// (set) Token: 0x0600B197 RID: 45463 RVA: 0x00051A39 File Offset: 0x0004FC39
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x04007A51 RID: 31313
		private static readonly IntPtr NativeFieldInfoPtr_Sprites;

		// Token: 0x04007A52 RID: 31314
		private static readonly IntPtr NativeFieldInfoPtr_Image;

		// Token: 0x04007A53 RID: 31315
		private static readonly IntPtr NativeFieldInfoPtr_FlipTime;

		// Token: 0x04007A54 RID: 31316
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x04007A55 RID: 31317
		private static readonly IntPtr NativeFieldInfoPtr_time;

		// Token: 0x04007A56 RID: 31318
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04007A57 RID: 31319
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04007A58 RID: 31320
		private static readonly IntPtr NativeMethodInfoPtr_SetIndex_Public_Void_Int32_0;

		// Token: 0x04007A59 RID: 31321
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
