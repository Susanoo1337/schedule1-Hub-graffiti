using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002BA RID: 698
	public class LadderSizeSetter : MonoBehaviour
	{
		// Token: 0x0600362A RID: 13866 RVA: 0x0012F58C File Offset: 0x0012D78C
		// Note: this type is marked as 'beforefieldinit'.
		static LadderSizeSetter()
		{
			Il2CppClassPointerStore<LadderSizeSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "LadderSizeSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LadderSizeSetter>.NativeClassPtr);
			LadderSizeSetter.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LadderSizeSetter>.NativeClassPtr, "Size");
			LadderSizeSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LadderSizeSetter>.NativeClassPtr, 100670148);
		}

		// Token: 0x0600362B RID: 13867 RVA: 0x0012F5E4 File Offset: 0x0012D7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141991, XrefRangeEnd = 141992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LadderSizeSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LadderSizeSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LadderSizeSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x0001B883 File Offset: 0x00019A83
		public LadderSizeSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x0600362D RID: 13869 RVA: 0x0012F620 File Offset: 0x0012D820
		// (set) Token: 0x0600362E RID: 13870 RVA: 0x0001B88C File Offset: 0x00019A8C
		public unsafe Vector2 Size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadderSizeSetter.NativeFieldInfoPtr_Size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LadderSizeSetter.NativeFieldInfoPtr_Size)) = value;
			}
		}

		// Token: 0x04002445 RID: 9285
		private static readonly IntPtr NativeFieldInfoPtr_Size;

		// Token: 0x04002446 RID: 9286
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
