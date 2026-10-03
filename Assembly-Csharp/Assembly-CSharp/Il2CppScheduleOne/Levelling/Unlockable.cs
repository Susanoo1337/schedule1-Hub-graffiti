using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Levelling
{
	// Token: 0x02000302 RID: 770
	public class Unlockable : Il2CppSystem.Object
	{
		// Token: 0x06003D2A RID: 15658 RVA: 0x00149928 File Offset: 0x00147B28
		// Note: this type is marked as 'beforefieldinit'.
		static Unlockable()
		{
			Il2CppClassPointerStore<Unlockable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Levelling", "Unlockable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Unlockable>.NativeClassPtr);
			Unlockable.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unlockable>.NativeClassPtr, "Rank");
			Unlockable.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unlockable>.NativeClassPtr, "Title");
			Unlockable.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Unlockable>.NativeClassPtr, "Icon");
			Unlockable.NativeMethodInfoPtr__ctor_Public_Void_FullRank_String_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Unlockable>.NativeClassPtr, 100671126);
		}

		// Token: 0x06003D2B RID: 15659 RVA: 0x001499A8 File Offset: 0x00147BA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 152030, RefRangeEnd = 152033, XrefRangeStart = 152027, XrefRangeEnd = 152030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Unlockable(FullRank rank, string title, Sprite icon) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Unlockable>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rank;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(icon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Unlockable.NativeMethodInfoPtr__ctor_Public_Void_FullRank_String_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D2C RID: 15660 RVA: 0x0001E70F File Offset: 0x0001C90F
		public Unlockable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x06003D2D RID: 15661 RVA: 0x00149A14 File Offset: 0x00147C14
		// (set) Token: 0x06003D2E RID: 15662 RVA: 0x0001E718 File Offset: 0x0001C918
		public unsafe FullRank Rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Rank)) = value;
			}
		}

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x06003D2F RID: 15663 RVA: 0x00149A3C File Offset: 0x00147C3C
		// (set) Token: 0x06003D30 RID: 15664 RVA: 0x0001E733 File Offset: 0x0001C933
		public unsafe string Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x06003D31 RID: 15665 RVA: 0x00149A64 File Offset: 0x00147C64
		// (set) Token: 0x06003D32 RID: 15666 RVA: 0x0001E752 File Offset: 0x0001C952
		public unsafe Sprite Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Unlockable.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002959 RID: 10585
		private static readonly IntPtr NativeFieldInfoPtr_Rank;

		// Token: 0x0400295A RID: 10586
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x0400295B RID: 10587
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x0400295C RID: 10588
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FullRank_String_Sprite_0;
	}
}
