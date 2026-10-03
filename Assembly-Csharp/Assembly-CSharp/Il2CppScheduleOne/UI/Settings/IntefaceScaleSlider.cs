using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x0200078F RID: 1935
	public class IntefaceScaleSlider : SettingsSlider
	{
		// Token: 0x0600BC00 RID: 48128 RVA: 0x003048C0 File Offset: 0x00302AC0
		// Note: this type is marked as 'beforefieldinit'.
		static IntefaceScaleSlider()
		{
			Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "IntefaceScaleSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr);
			IntefaceScaleSlider.NativeFieldInfoPtr_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, "MULTIPLIER");
			IntefaceScaleSlider.NativeFieldInfoPtr_MinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, "MinScale");
			IntefaceScaleSlider.NativeFieldInfoPtr_MaxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, "MaxScale");
			IntefaceScaleSlider.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, 100687818);
			IntefaceScaleSlider.NativeMethodInfoPtr_OnDragEnd_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, 100687819);
			IntefaceScaleSlider.NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, 100687820);
			IntefaceScaleSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, 100687821);
		}

		// Token: 0x0600BC01 RID: 48129 RVA: 0x0030497C File Offset: 0x00302B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313539, XrefRangeEnd = 313547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntefaceScaleSlider.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC02 RID: 48130 RVA: 0x003049B8 File Offset: 0x00302BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313547, XrefRangeEnd = 313557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDragEnd(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntefaceScaleSlider.NativeMethodInfoPtr_OnDragEnd_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC03 RID: 48131 RVA: 0x00304A04 File Offset: 0x00302C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313557, XrefRangeEnd = 313562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetDisplayValue(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntefaceScaleSlider.NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600BC04 RID: 48132 RVA: 0x00304A54 File Offset: 0x00302C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntefaceScaleSlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntefaceScaleSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BC05 RID: 48133 RVA: 0x00057B0B File Offset: 0x00055D0B
		public IntefaceScaleSlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038D0 RID: 14544
		// (get) Token: 0x0600BC06 RID: 48134 RVA: 0x00304A90 File Offset: 0x00302C90
		// (set) Token: 0x0600BC07 RID: 48135 RVA: 0x00057B14 File Offset: 0x00055D14
		public unsafe static float MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(IntefaceScaleSlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntefaceScaleSlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x170038D1 RID: 14545
		// (get) Token: 0x0600BC08 RID: 48136 RVA: 0x00304AAC File Offset: 0x00302CAC
		// (set) Token: 0x0600BC09 RID: 48137 RVA: 0x00057B22 File Offset: 0x00055D22
		public unsafe static float MinScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(IntefaceScaleSlider.NativeFieldInfoPtr_MinScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntefaceScaleSlider.NativeFieldInfoPtr_MinScale, (void*)(&value));
			}
		}

		// Token: 0x170038D2 RID: 14546
		// (get) Token: 0x0600BC0A RID: 48138 RVA: 0x00304AC8 File Offset: 0x00302CC8
		// (set) Token: 0x0600BC0B RID: 48139 RVA: 0x00057B30 File Offset: 0x00055D30
		public unsafe static float MaxScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(IntefaceScaleSlider.NativeFieldInfoPtr_MaxScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntefaceScaleSlider.NativeFieldInfoPtr_MaxScale, (void*)(&value));
			}
		}

		// Token: 0x040080D6 RID: 32982
		private static readonly IntPtr NativeFieldInfoPtr_MULTIPLIER;

		// Token: 0x040080D7 RID: 32983
		private static readonly IntPtr NativeFieldInfoPtr_MinScale;

		// Token: 0x040080D8 RID: 32984
		private static readonly IntPtr NativeFieldInfoPtr_MaxScale;

		// Token: 0x040080D9 RID: 32985
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x040080DA RID: 32986
		private static readonly IntPtr NativeMethodInfoPtr_OnDragEnd_Protected_Virtual_Void_Single_0;

		// Token: 0x040080DB RID: 32987
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_String_Single_0;

		// Token: 0x040080DC RID: 32988
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
