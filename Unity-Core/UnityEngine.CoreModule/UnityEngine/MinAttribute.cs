using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200010F RID: 271
	public sealed class MinAttribute : PropertyAttribute
	{
		// Token: 0x06001697 RID: 5783 RVA: 0x00062BE0 File Offset: 0x00060DE0
		// Note: this type is marked as 'beforefieldinit'.
		static MinAttribute()
		{
			Il2CppClassPointerStore<MinAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MinAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinAttribute>.NativeClassPtr);
			MinAttribute.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinAttribute>.NativeClassPtr, "min");
			MinAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinAttribute>.NativeClassPtr, 100665675);
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x00062C38 File Offset: 0x00060E38
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1246054, RefRangeEnd = 1246062, XrefRangeStart = 1246054, XrefRangeEnd = 1246062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinAttribute(float min) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref min;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x0000B544 File Offset: 0x00009744
		public MinAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x0600169A RID: 5786 RVA: 0x00062C80 File Offset: 0x00060E80
		// (set) Token: 0x0600169B RID: 5787 RVA: 0x0000B54D File Offset: 0x0000974D
		public unsafe float min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinAttribute.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinAttribute.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x04001361 RID: 4961
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04001362 RID: 4962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
	}
}
