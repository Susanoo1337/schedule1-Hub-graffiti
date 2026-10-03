using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x020000D8 RID: 216
	public class LODGroup : Component
	{
		// Token: 0x06000EE4 RID: 3812 RVA: 0x000427C8 File Offset: 0x000409C8
		// Note: this type is marked as 'beforefieldinit'.
		static LODGroup()
		{
			Il2CppClassPointerStore<LODGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LODGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LODGroup>.NativeClassPtr);
			LODGroup.NativeMethodInfoPtr_get_size_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroup>.NativeClassPtr, 100664623);
			LODGroup.NativeMethodInfoPtr_set_size_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroup>.NativeClassPtr, 100664624);
			LODGroup.NativeMethodInfoPtr_get_lodCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroup>.NativeClassPtr, 100664625);
			LODGroup.NativeMethodInfoPtr_RecalculateBounds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroup>.NativeClassPtr, 100664626);
			LODGroup.NativeMethodInfoPtr_GetLODs_Public_Il2CppReferenceArray_1_LOD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroup>.NativeClassPtr, 100664627);
			LODGroup.NativeMethodInfoPtr_SetLODs_Public_Void_Il2CppReferenceArray_1_LOD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroup>.NativeClassPtr, 100664628);
			LODGroup.NativeMethodInfoPtr_ForceLOD_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroup>.NativeClassPtr, 100664629);
			LODGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODGroup>.NativeClassPtr, 100664630);
			LODGroup.get_lastLODBillboardDelegateField = IL2CPP.ResolveICall<LODGroup.get_lastLODBillboardDelegate>("UnityEngine.LODGroup::get_lastLODBillboard");
			LODGroup.set_lastLODBillboardDelegateField = IL2CPP.ResolveICall<LODGroup.set_lastLODBillboardDelegate>("UnityEngine.LODGroup::set_lastLODBillboard");
			LODGroup.get_fadeModeDelegateField = IL2CPP.ResolveICall<LODGroup.get_fadeModeDelegate>("UnityEngine.LODGroup::get_fadeMode");
			LODGroup.set_fadeModeDelegateField = IL2CPP.ResolveICall<LODGroup.set_fadeModeDelegate>("UnityEngine.LODGroup::set_fadeMode");
			LODGroup.get_animateCrossFadingDelegateField = IL2CPP.ResolveICall<LODGroup.get_animateCrossFadingDelegate>("UnityEngine.LODGroup::get_animateCrossFading");
			LODGroup.set_animateCrossFadingDelegateField = IL2CPP.ResolveICall<LODGroup.set_animateCrossFadingDelegate>("UnityEngine.LODGroup::set_animateCrossFading");
			LODGroup.get_enabledDelegateField = IL2CPP.ResolveICall<LODGroup.get_enabledDelegate>("UnityEngine.LODGroup::get_enabled");
			LODGroup.set_enabledDelegateField = IL2CPP.ResolveICall<LODGroup.set_enabledDelegate>("UnityEngine.LODGroup::set_enabled");
			LODGroup.get_crossFadeAnimationDurationDelegateField = IL2CPP.ResolveICall<LODGroup.get_crossFadeAnimationDurationDelegate>("UnityEngine.LODGroup::get_crossFadeAnimationDuration");
			LODGroup.set_crossFadeAnimationDurationDelegateField = IL2CPP.ResolveICall<LODGroup.set_crossFadeAnimationDurationDelegate>("UnityEngine.LODGroup::set_crossFadeAnimationDuration");
			LODGroup.get_localReferencePoint_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.get_localReferencePoint_InjectedDelegate>("UnityEngine.LODGroup::get_localReferencePoint_Injected");
			LODGroup.set_localReferencePoint_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.set_localReferencePoint_InjectedDelegate>("UnityEngine.LODGroup::set_localReferencePoint_Injected");
			LODGroup.get_worldReferencePoint_InjectedDelegateField = IL2CPP.ResolveICall<LODGroup.get_worldReferencePoint_InjectedDelegate>("UnityEngine.LODGroup::get_worldReferencePoint_Injected");
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x0004295C File Offset: 0x00040B5C
		// (set) Token: 0x06000EE6 RID: 3814 RVA: 0x00042998 File Offset: 0x00040B98
		public unsafe float size
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1238253, RefRangeEnd = 1238254, XrefRangeStart = 1238251, XrefRangeEnd = 1238253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODGroup.NativeMethodInfoPtr_get_size_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1238256, RefRangeEnd = 1238257, XrefRangeStart = 1238254, XrefRangeEnd = 1238256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODGroup.NativeMethodInfoPtr_set_size_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x000429D8 File Offset: 0x00040BD8
		public unsafe int lodCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1238259, RefRangeEnd = 1238260, XrefRangeStart = 1238257, XrefRangeEnd = 1238259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODGroup.NativeMethodInfoPtr_get_lodCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x00042A14 File Offset: 0x00040C14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1238262, RefRangeEnd = 1238264, XrefRangeStart = 1238260, XrefRangeEnd = 1238262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODGroup.NativeMethodInfoPtr_RecalculateBounds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x00042A48 File Offset: 0x00040C48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238266, RefRangeEnd = 1238267, XrefRangeStart = 1238264, XrefRangeEnd = 1238266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<LOD> GetLODs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODGroup.NativeMethodInfoPtr_GetLODs_Public_Il2CppReferenceArray_1_LOD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LOD>>(intPtr3) : null;
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x00042A88 File Offset: 0x00040C88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238269, RefRangeEnd = 1238270, XrefRangeStart = 1238267, XrefRangeEnd = 1238269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLODs(Il2CppReferenceArray<LOD> lods)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lods);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODGroup.NativeMethodInfoPtr_SetLODs_Public_Void_Il2CppReferenceArray_1_LOD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x00042ACC File Offset: 0x00040CCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238272, RefRangeEnd = 1238273, XrefRangeStart = 1238270, XrefRangeEnd = 1238272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceLOD(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODGroup.NativeMethodInfoPtr_ForceLOD_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x00042B0C File Offset: 0x00040D0C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LODGroup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LODGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LODGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x0000909F File Offset: 0x0000729F
		public LODGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x00042B48 File Offset: 0x00040D48
		// (set) Token: 0x06000EEF RID: 3823 RVA: 0x000090A8 File Offset: 0x000072A8
		public Vector3 localReferencePoint
		{
			get
			{
				Vector3 result;
				this.get_localReferencePoint_Injected(out result);
				return result;
			}
			set
			{
				this.set_localReferencePoint_Injected(ref value);
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x000090B2 File Offset: 0x000072B2
		// (set) Token: 0x06000EF1 RID: 3825 RVA: 0x000090C4 File Offset: 0x000072C4
		public bool lastLODBillboard
		{
			get
			{
				return LODGroup.get_lastLODBillboardDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LODGroup.set_lastLODBillboardDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x000090D7 File Offset: 0x000072D7
		// (set) Token: 0x06000EF3 RID: 3827 RVA: 0x000090E9 File Offset: 0x000072E9
		public LODFadeMode fadeMode
		{
			get
			{
				return LODGroup.get_fadeModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LODGroup.set_fadeModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x000090FC File Offset: 0x000072FC
		// (set) Token: 0x06000EF5 RID: 3829 RVA: 0x0000910E File Offset: 0x0000730E
		public bool animateCrossFading
		{
			get
			{
				return LODGroup.get_animateCrossFadingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LODGroup.set_animateCrossFadingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x00009121 File Offset: 0x00007321
		// (set) Token: 0x06000EF7 RID: 3831 RVA: 0x00009133 File Offset: 0x00007333
		public bool enabled
		{
			get
			{
				return LODGroup.get_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LODGroup.set_enabledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00009146 File Offset: 0x00007346
		public void SetLODS(Il2CppReferenceArray<LOD> lods)
		{
			this.SetLODs(lods);
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x00009151 File Offset: 0x00007351
		// (set) Token: 0x06000EFA RID: 3834 RVA: 0x0000915D File Offset: 0x0000735D
		public static float crossFadeAnimationDuration
		{
			get
			{
				return LODGroup.get_crossFadeAnimationDurationDelegateField();
			}
			set
			{
				LODGroup.set_crossFadeAnimationDurationDelegateField(value);
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x00042B60 File Offset: 0x00040D60
		public Vector3 worldReferencePoint
		{
			get
			{
				Vector3 result;
				this.get_worldReferencePoint_Injected(out result);
				return result;
			}
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0000916A File Offset: 0x0000736A
		public void get_localReferencePoint_Injected(out Vector3 ret)
		{
			LODGroup.get_localReferencePoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x0000917D File Offset: 0x0000737D
		public void set_localReferencePoint_Injected(ref Vector3 value)
		{
			LODGroup.set_localReferencePoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x00009190 File Offset: 0x00007390
		public void get_worldReferencePoint_Injected(out Vector3 ret)
		{
			LODGroup.get_worldReferencePoint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Single_0;

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Single_0;

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeMethodInfoPtr_get_lodCount_Public_get_Int32_0;

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateBounds_Public_Void_0;

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeMethodInfoPtr_GetLODs_Public_Il2CppReferenceArray_1_LOD_0;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeMethodInfoPtr_SetLODs_Public_Void_Il2CppReferenceArray_1_LOD_0;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeMethodInfoPtr_ForceLOD_Public_Void_Int32_0;

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C0D RID: 3085
		private static readonly LODGroup.get_lastLODBillboardDelegate get_lastLODBillboardDelegateField;

		// Token: 0x04000C0E RID: 3086
		private static readonly LODGroup.set_lastLODBillboardDelegate set_lastLODBillboardDelegateField;

		// Token: 0x04000C0F RID: 3087
		private static readonly LODGroup.get_fadeModeDelegate get_fadeModeDelegateField;

		// Token: 0x04000C10 RID: 3088
		private static readonly LODGroup.set_fadeModeDelegate set_fadeModeDelegateField;

		// Token: 0x04000C11 RID: 3089
		private static readonly LODGroup.get_animateCrossFadingDelegate get_animateCrossFadingDelegateField;

		// Token: 0x04000C12 RID: 3090
		private static readonly LODGroup.set_animateCrossFadingDelegate set_animateCrossFadingDelegateField;

		// Token: 0x04000C13 RID: 3091
		private static readonly LODGroup.get_enabledDelegate get_enabledDelegateField;

		// Token: 0x04000C14 RID: 3092
		private static readonly LODGroup.set_enabledDelegate set_enabledDelegateField;

		// Token: 0x04000C15 RID: 3093
		private static readonly LODGroup.get_crossFadeAnimationDurationDelegate get_crossFadeAnimationDurationDelegateField;

		// Token: 0x04000C16 RID: 3094
		private static readonly LODGroup.set_crossFadeAnimationDurationDelegate set_crossFadeAnimationDurationDelegateField;

		// Token: 0x04000C17 RID: 3095
		private static readonly LODGroup.get_localReferencePoint_InjectedDelegate get_localReferencePoint_InjectedDelegateField;

		// Token: 0x04000C18 RID: 3096
		private static readonly LODGroup.set_localReferencePoint_InjectedDelegate set_localReferencePoint_InjectedDelegateField;

		// Token: 0x04000C19 RID: 3097
		private static readonly LODGroup.get_worldReferencePoint_InjectedDelegate get_worldReferencePoint_InjectedDelegateField;

		// Token: 0x02000778 RID: 1912
		// (Invoke) Token: 0x06003798 RID: 14232
		private delegate bool get_lastLODBillboardDelegate(IntPtr @this);

		// Token: 0x02000779 RID: 1913
		// (Invoke) Token: 0x0600379A RID: 14234
		private delegate void set_lastLODBillboardDelegate(IntPtr @this, bool value);

		// Token: 0x0200077A RID: 1914
		// (Invoke) Token: 0x0600379C RID: 14236
		private delegate LODFadeMode get_fadeModeDelegate(IntPtr @this);

		// Token: 0x0200077B RID: 1915
		// (Invoke) Token: 0x0600379E RID: 14238
		private delegate void set_fadeModeDelegate(IntPtr @this, LODFadeMode value);

		// Token: 0x0200077C RID: 1916
		// (Invoke) Token: 0x060037A0 RID: 14240
		private delegate bool get_animateCrossFadingDelegate(IntPtr @this);

		// Token: 0x0200077D RID: 1917
		// (Invoke) Token: 0x060037A2 RID: 14242
		private delegate void set_animateCrossFadingDelegate(IntPtr @this, bool value);

		// Token: 0x0200077E RID: 1918
		// (Invoke) Token: 0x060037A4 RID: 14244
		private delegate bool get_enabledDelegate(IntPtr @this);

		// Token: 0x0200077F RID: 1919
		// (Invoke) Token: 0x060037A6 RID: 14246
		private delegate void set_enabledDelegate(IntPtr @this, bool value);

		// Token: 0x02000780 RID: 1920
		// (Invoke) Token: 0x060037A8 RID: 14248
		private delegate float get_crossFadeAnimationDurationDelegate();

		// Token: 0x02000781 RID: 1921
		// (Invoke) Token: 0x060037AA RID: 14250
		private delegate void set_crossFadeAnimationDurationDelegate(float value);

		// Token: 0x02000782 RID: 1922
		// (Invoke) Token: 0x060037AC RID: 14252
		private delegate void get_localReferencePoint_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000783 RID: 1923
		// (Invoke) Token: 0x060037AE RID: 14254
		private delegate void set_localReferencePoint_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000784 RID: 1924
		// (Invoke) Token: 0x060037B0 RID: 14256
		private delegate void get_worldReferencePoint_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
