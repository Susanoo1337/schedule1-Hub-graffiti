using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000550 RID: 1360
	[Serializable]
	public class PropertyContainer : Object
	{
		// Token: 0x06007BE7 RID: 31719 RVA: 0x00223654 File Offset: 0x00221854
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyContainer()
		{
			Il2CppClassPointerStore<PropertyContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "PropertyContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyContainer>.NativeClassPtr);
			PropertyContainer.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyContainer>.NativeClassPtr, "Property");
			PropertyContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyContainer>.NativeClassPtr, 100679211);
		}

		// Token: 0x06007BE8 RID: 31720 RVA: 0x002236AC File Offset: 0x002218AC
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BE9 RID: 31721 RVA: 0x0003B02B File Offset: 0x0003922B
		public PropertyContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700265A RID: 9818
		// (get) Token: 0x06007BEA RID: 31722 RVA: 0x002236E8 File Offset: 0x002218E8
		// (set) Token: 0x06007BEB RID: 31723 RVA: 0x0003B034 File Offset: 0x00039234
		public unsafe EProperty Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyContainer.NativeFieldInfoPtr_Property);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyContainer.NativeFieldInfoPtr_Property)) = value;
			}
		}

		// Token: 0x04005483 RID: 21635
		private static readonly IntPtr NativeFieldInfoPtr_Property;

		// Token: 0x04005484 RID: 21636
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
