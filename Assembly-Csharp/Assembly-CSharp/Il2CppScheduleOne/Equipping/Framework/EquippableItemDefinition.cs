using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Core.Equipping.Framework;

namespace Il2CppScheduleOne.Equipping.Framework
{
	// Token: 0x02000590 RID: 1424
	public class EquippableItemDefinition : GenericEquippableItemDefinition<EquippableData>
	{
		// Token: 0x0600818C RID: 33164 RVA: 0x0003DA11 File Offset: 0x0003BC11
		// Note: this type is marked as 'beforefieldinit'.
		static EquippableItemDefinition()
		{
			Il2CppClassPointerStore<EquippableItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping.Framework", "EquippableItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquippableItemDefinition>.NativeClassPtr);
			EquippableItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquippableItemDefinition>.NativeClassPtr, 100679935);
		}

		// Token: 0x0600818D RID: 33165 RVA: 0x00237A60 File Offset: 0x00235C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245297, XrefRangeEnd = 245300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EquippableItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquippableItemDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquippableItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600818E RID: 33166 RVA: 0x0003DA4A File Offset: 0x0003BC4A
		public EquippableItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005849 RID: 22601
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
