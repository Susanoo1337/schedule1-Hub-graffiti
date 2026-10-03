using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000074 RID: 116
	public class BootConfigData : Object
	{
		// Token: 0x0600040D RID: 1037 RVA: 0x00023F70 File Offset: 0x00022170
		// Note: this type is marked as 'beforefieldinit'.
		static BootConfigData()
		{
			Il2CppClassPointerStore<BootConfigData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BootConfigData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BootConfigData>.NativeClassPtr);
			BootConfigData.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BootConfigData>.NativeClassPtr, "m_Ptr");
			BootConfigData.NativeMethodInfoPtr_WrapBootConfigData_Private_Static_BootConfigData_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BootConfigData>.NativeClassPtr, 100663712);
			BootConfigData.AppendDelegateField = IL2CPP.ResolveICall<BootConfigData.AppendDelegate>("UnityEngine.BootConfigData::Append");
			BootConfigData.SetDelegateField = IL2CPP.ResolveICall<BootConfigData.SetDelegate>("UnityEngine.BootConfigData::Set");
			BootConfigData.GetValueDelegateField = IL2CPP.ResolveICall<BootConfigData.GetValueDelegate>("UnityEngine.BootConfigData::GetValue");
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00023FF8 File Offset: 0x000221F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228309, XrefRangeEnd = 1228314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BootConfigData WrapBootConfigData(IntPtr nativeHandle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nativeHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BootConfigData.NativeMethodInfoPtr_WrapBootConfigData_Private_Static_BootConfigData_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BootConfigData>(intPtr3) : null;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00003EAC File Offset: 0x000020AC
		public BootConfigData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00024038 File Offset: 0x00022238
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x00003EB5 File Offset: 0x000020B5
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BootConfigData.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BootConfigData.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00003ED0 File Offset: 0x000020D0
		public void AddKey(string key)
		{
			this.Append(key, null);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00024060 File Offset: 0x00022260
		public string Get(string key)
		{
			return this.GetValue(key, 0);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0002407C File Offset: 0x0002227C
		public string Get(string key, int index)
		{
			return this.GetValue(key, index);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00003EDC File Offset: 0x000020DC
		public void Append(string key, string value)
		{
			BootConfigData.AppendDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), IL2CPP.ManagedStringToIl2Cpp(value));
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00003EFA File Offset: 0x000020FA
		public void Set(string key, string value)
		{
			BootConfigData.SetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), IL2CPP.ManagedStringToIl2Cpp(value));
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00024098 File Offset: 0x00022298
		public string GetValue(string key, int index)
		{
			IntPtr intPtr = BootConfigData.GetValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), index);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_WrapBootConfigData_Private_Static_BootConfigData_IntPtr_0;

		// Token: 0x04000396 RID: 918
		private static readonly BootConfigData.AppendDelegate AppendDelegateField;

		// Token: 0x04000397 RID: 919
		private static readonly BootConfigData.SetDelegate SetDelegateField;

		// Token: 0x04000398 RID: 920
		private static readonly BootConfigData.GetValueDelegate GetValueDelegateField;

		// Token: 0x02000421 RID: 1057
		// (Invoke) Token: 0x060030EE RID: 12526
		private delegate void AppendDelegate(IntPtr @this, IntPtr key, IntPtr value);

		// Token: 0x02000422 RID: 1058
		// (Invoke) Token: 0x060030F0 RID: 12528
		private delegate void SetDelegate(IntPtr @this, IntPtr key, IntPtr value);

		// Token: 0x02000423 RID: 1059
		// (Invoke) Token: 0x060030F2 RID: 12530
		private delegate IntPtr GetValueDelegate(IntPtr @this, IntPtr key, int index);
	}
}
