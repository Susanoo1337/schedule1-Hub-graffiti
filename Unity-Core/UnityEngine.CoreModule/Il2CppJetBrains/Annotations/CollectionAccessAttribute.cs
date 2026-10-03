using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppJetBrains.Annotations
{
	// Token: 0x02000063 RID: 99
	public sealed class CollectionAccessAttribute : Attribute
	{
		// Token: 0x06000322 RID: 802 RVA: 0x000212E8 File Offset: 0x0001F4E8
		// Note: this type is marked as 'beforefieldinit'.
		static CollectionAccessAttribute()
		{
			Il2CppClassPointerStore<CollectionAccessAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "JetBrains.Annotations", "CollectionAccessAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionAccessAttribute>.NativeClassPtr);
			CollectionAccessAttribute.NativeFieldInfoPtr__CollectionAccessType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionAccessAttribute>.NativeClassPtr, "<CollectionAccessType>k__BackingField");
			CollectionAccessAttribute.NativeMethodInfoPtr__ctor_Public_Void_CollectionAccessType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionAccessAttribute>.NativeClassPtr, 100663605);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00021340 File Offset: 0x0001F540
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 385934, RefRangeEnd = 385962, XrefRangeStart = 385934, XrefRangeEnd = 385962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CollectionAccessAttribute(CollectionAccessType collectionAccessType) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectionAccessAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref collectionAccessType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionAccessAttribute.NativeMethodInfoPtr__ctor_Public_Void_CollectionAccessType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00003A08 File Offset: 0x00001C08
		public CollectionAccessAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00021388 File Offset: 0x0001F588
		// (set) Token: 0x06000326 RID: 806 RVA: 0x00003A11 File Offset: 0x00001C11
		public unsafe CollectionAccessType _CollectionAccessType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectionAccessAttribute.NativeFieldInfoPtr__CollectionAccessType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectionAccessAttribute.NativeFieldInfoPtr__CollectionAccessType_k__BackingField)) = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00003A2C File Offset: 0x00001C2C
		public CollectionAccessType CollectionAccessType
		{
			get
			{
				return this._CollectionAccessType_k__BackingField;
			}
		}

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeFieldInfoPtr__CollectionAccessType_k__BackingField;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CollectionAccessType_0;
	}
}
