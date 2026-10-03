using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x0200018D RID: 397
	public sealed class SemanticMeaning : ValueType
	{
		// Token: 0x06001E3D RID: 7741 RVA: 0x0007B2F0 File Offset: 0x000794F0
		// Note: this type is marked as 'beforefieldinit'.
		static SemanticMeaning()
		{
			Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "SemanticMeaning");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr);
			SemanticMeaning.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr, "key");
			SemanticMeaning.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr, "values");
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x0000E3B6 File Offset: 0x0000C5B6
		public SemanticMeaning(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x0000E3BF File Offset: 0x0000C5BF
		public SemanticMeaning() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr))
		{
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x0007B348 File Offset: 0x00079548
		// (set) Token: 0x06001E41 RID: 7745 RVA: 0x0000E3D1 File Offset: 0x0000C5D1
		public unsafe string key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemanticMeaning.NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemanticMeaning.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x0007B370 File Offset: 0x00079570
		// (set) Token: 0x06001E43 RID: 7747 RVA: 0x0000E3F0 File Offset: 0x0000C5F0
		public unsafe Il2CppStringArray values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemanticMeaning.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemanticMeaning.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018B5 RID: 6325
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x040018B6 RID: 6326
		private static readonly IntPtr NativeFieldInfoPtr_values;
	}
}
