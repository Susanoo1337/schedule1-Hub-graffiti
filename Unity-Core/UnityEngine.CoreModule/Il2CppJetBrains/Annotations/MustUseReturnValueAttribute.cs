using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppJetBrains.Annotations
{
	// Token: 0x02000062 RID: 98
	public sealed class MustUseReturnValueAttribute : Attribute
	{
		// Token: 0x0600031E RID: 798 RVA: 0x000039B9 File Offset: 0x00001BB9
		// Note: this type is marked as 'beforefieldinit'.
		static MustUseReturnValueAttribute()
		{
			Il2CppClassPointerStore<MustUseReturnValueAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "JetBrains.Annotations", "MustUseReturnValueAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MustUseReturnValueAttribute>.NativeClassPtr);
			MustUseReturnValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MustUseReturnValueAttribute>.NativeClassPtr, 100663604);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000212AC File Offset: 0x0001F4AC
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MustUseReturnValueAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MustUseReturnValueAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MustUseReturnValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x000039F2 File Offset: 0x00001BF2
		public MustUseReturnValueAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000321 RID: 801 RVA: 0x000039FB File Offset: 0x00001BFB
		public string Justification
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
