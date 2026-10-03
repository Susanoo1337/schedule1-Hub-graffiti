using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000108 RID: 264
	public class PropertyAttribute : Attribute
	{
		// Token: 0x0600166F RID: 5743 RVA: 0x0000B3C6 File Offset: 0x000095C6
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyAttribute()
		{
			Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PropertyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr);
			PropertyAttribute.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr, 100665667);
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x000625F8 File Offset: 0x000607F8
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyAttribute.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x0000B3FF File Offset: 0x000095FF
		public PropertyAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001672 RID: 5746 RVA: 0x0000B408 File Offset: 0x00009608
		// (set) Token: 0x06001673 RID: 5747 RVA: 0x0000B415 File Offset: 0x00009615
		public int order
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x04001351 RID: 4945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
