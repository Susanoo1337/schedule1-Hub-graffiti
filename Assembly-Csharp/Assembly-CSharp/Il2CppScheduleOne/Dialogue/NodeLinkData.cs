using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003D6 RID: 982
	[Serializable]
	public class NodeLinkData : Object
	{
		// Token: 0x0600580F RID: 22543 RVA: 0x001AC4EC File Offset: 0x001AA6EC
		// Note: this type is marked as 'beforefieldinit'.
		static NodeLinkData()
		{
			Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "NodeLinkData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr);
			NodeLinkData.NativeFieldInfoPtr_BaseDialogueOrBranchNodeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr, "BaseDialogueOrBranchNodeGuid");
			NodeLinkData.NativeFieldInfoPtr_BaseChoiceOrOptionGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr, "BaseChoiceOrOptionGUID");
			NodeLinkData.NativeFieldInfoPtr_TargetNodeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr, "TargetNodeGuid");
			NodeLinkData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr, 100674877);
		}

		// Token: 0x06005810 RID: 22544 RVA: 0x001AC56C File Offset: 0x001AA76C
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NodeLinkData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodeLinkData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005811 RID: 22545 RVA: 0x00029973 File Offset: 0x00027B73
		public NodeLinkData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B24 RID: 6948
		// (get) Token: 0x06005812 RID: 22546 RVA: 0x001AC5A8 File Offset: 0x001AA7A8
		// (set) Token: 0x06005813 RID: 22547 RVA: 0x0002997C File Offset: 0x00027B7C
		public unsafe string BaseDialogueOrBranchNodeGuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_BaseDialogueOrBranchNodeGuid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_BaseDialogueOrBranchNodeGuid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B25 RID: 6949
		// (get) Token: 0x06005814 RID: 22548 RVA: 0x001AC5D0 File Offset: 0x001AA7D0
		// (set) Token: 0x06005815 RID: 22549 RVA: 0x0002999B File Offset: 0x00027B9B
		public unsafe string BaseChoiceOrOptionGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_BaseChoiceOrOptionGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_BaseChoiceOrOptionGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B26 RID: 6950
		// (get) Token: 0x06005816 RID: 22550 RVA: 0x001AC5F8 File Offset: 0x001AA7F8
		// (set) Token: 0x06005817 RID: 22551 RVA: 0x000299BA File Offset: 0x00027BBA
		public unsafe string TargetNodeGuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_TargetNodeGuid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_TargetNodeGuid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003C9D RID: 15517
		private static readonly IntPtr NativeFieldInfoPtr_BaseDialogueOrBranchNodeGuid;

		// Token: 0x04003C9E RID: 15518
		private static readonly IntPtr NativeFieldInfoPtr_BaseChoiceOrOptionGUID;

		// Token: 0x04003C9F RID: 15519
		private static readonly IntPtr NativeFieldInfoPtr_TargetNodeGuid;

		// Token: 0x04003CA0 RID: 15520
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
