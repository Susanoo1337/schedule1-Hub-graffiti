using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x02000291 RID: 657
	public class AutoNetworkStart : MonoBehaviour
	{
		// Token: 0x06003230 RID: 12848 RVA: 0x00120D18 File Offset: 0x0011EF18
		// Note: this type is marked as 'beforefieldinit'.
		static AutoNetworkStart()
		{
			Il2CppClassPointerStore<AutoNetworkStart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "AutoNetworkStart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoNetworkStart>.NativeClassPtr);
			AutoNetworkStart.NativeFieldInfoPtr__autoStartType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoNetworkStart>.NativeClassPtr, "_autoStartType");
			AutoNetworkStart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoNetworkStart>.NativeClassPtr, 100669541);
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x00120D70 File Offset: 0x0011EF70
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoNetworkStart() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoNetworkStart>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoNetworkStart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x00019E2C File Offset: 0x0001802C
		public AutoNetworkStart(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x06003233 RID: 12851 RVA: 0x00120DAC File Offset: 0x0011EFAC
		// (set) Token: 0x06003234 RID: 12852 RVA: 0x00019E35 File Offset: 0x00018035
		public unsafe AutoNetworkStart.EAutoStartType _autoStartType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoNetworkStart.NativeFieldInfoPtr__autoStartType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoNetworkStart.NativeFieldInfoPtr__autoStartType)) = value;
			}
		}

		// Token: 0x04002166 RID: 8550
		private static readonly IntPtr NativeFieldInfoPtr__autoStartType;

		// Token: 0x04002167 RID: 8551
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009F6 RID: 2550
		[OriginalName("Assembly-CSharp.dll", "", "EAutoStartType")]
		public enum EAutoStartType
		{
			// Token: 0x040096BC RID: 38588
			Disabled,
			// Token: 0x040096BD RID: 38589
			Host,
			// Token: 0x040096BE RID: 38590
			Server,
			// Token: 0x040096BF RID: 38591
			Client
		}
	}
}
