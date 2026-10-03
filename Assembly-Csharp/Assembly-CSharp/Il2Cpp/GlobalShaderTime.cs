using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000008 RID: 8
	public class GlobalShaderTime : MonoBehaviour
	{
		// Token: 0x06000051 RID: 81 RVA: 0x0007C7AC File Offset: 0x0007A9AC
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalShaderTime()
		{
			Il2CppClassPointerStore<GlobalShaderTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GlobalShaderTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalShaderTime>.NativeClassPtr);
			GlobalShaderTime.NativeFieldInfoPtr_GlobalShaderTimeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalShaderTime>.NativeClassPtr, "GlobalShaderTimeId");
			GlobalShaderTime.NativeFieldInfoPtr__generalTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalShaderTime>.NativeClassPtr, "_generalTimer");
			GlobalShaderTime.NativeFieldInfoPtr_WindIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalShaderTime>.NativeClassPtr, "WindIntensity");
			GlobalShaderTime.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalShaderTime>.NativeClassPtr, 100663321);
			GlobalShaderTime.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalShaderTime>.NativeClassPtr, 100663322);
			GlobalShaderTime.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalShaderTime>.NativeClassPtr, 100663323);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0007C854 File Offset: 0x0007AA54
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalShaderTime.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0007C888 File Offset: 0x0007AA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64978, XrefRangeEnd = 64989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalShaderTime.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0007C8BC File Offset: 0x0007AABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64989, XrefRangeEnd = 64990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GlobalShaderTime() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalShaderTime>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalShaderTime.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002310 File Offset: 0x00000510
		public GlobalShaderTime(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0007C8F8 File Offset: 0x0007AAF8
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002319 File Offset: 0x00000519
		public unsafe static int GlobalShaderTimeId
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GlobalShaderTime.NativeFieldInfoPtr_GlobalShaderTimeId, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalShaderTime.NativeFieldInfoPtr_GlobalShaderTimeId, (void*)(&value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0007C914 File Offset: 0x0007AB14
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002327 File Offset: 0x00000527
		public unsafe float _generalTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalShaderTime.NativeFieldInfoPtr__generalTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalShaderTime.NativeFieldInfoPtr__generalTimer)) = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0007C93C File Offset: 0x0007AB3C
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002342 File Offset: 0x00000542
		public unsafe float WindIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalShaderTime.NativeFieldInfoPtr_WindIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GlobalShaderTime.NativeFieldInfoPtr_WindIntensity)) = value;
			}
		}

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_GlobalShaderTimeId;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr__generalTimer;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_WindIntensity;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
