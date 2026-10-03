using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000D7 RID: 215
	public sealed class LOD : ValueType
	{
		// Token: 0x06000EDB RID: 3803 RVA: 0x000426DC File Offset: 0x000408DC
		// Note: this type is marked as 'beforefieldinit'.
		static LOD()
		{
			Il2CppClassPointerStore<LOD>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LOD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LOD>.NativeClassPtr);
			LOD.NativeFieldInfoPtr_screenRelativeTransitionHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LOD>.NativeClassPtr, "screenRelativeTransitionHeight");
			LOD.NativeFieldInfoPtr_fadeTransitionWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LOD>.NativeClassPtr, "fadeTransitionWidth");
			LOD.NativeFieldInfoPtr_renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LOD>.NativeClassPtr, "renderers");
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0000902F File Offset: 0x0000722F
		public LOD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x00009038 File Offset: 0x00007238
		public LOD() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LOD>.NativeClassPtr))
		{
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x00042748 File Offset: 0x00040948
		// (set) Token: 0x06000EDF RID: 3807 RVA: 0x0000904A File Offset: 0x0000724A
		public unsafe float screenRelativeTransitionHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LOD.NativeFieldInfoPtr_screenRelativeTransitionHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LOD.NativeFieldInfoPtr_screenRelativeTransitionHeight)) = value;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x00042770 File Offset: 0x00040970
		// (set) Token: 0x06000EE1 RID: 3809 RVA: 0x00009065 File Offset: 0x00007265
		public unsafe float fadeTransitionWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LOD.NativeFieldInfoPtr_fadeTransitionWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LOD.NativeFieldInfoPtr_fadeTransitionWidth)) = value;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x00042798 File Offset: 0x00040998
		// (set) Token: 0x06000EE3 RID: 3811 RVA: 0x00009080 File Offset: 0x00007280
		public unsafe Il2CppReferenceArray<Renderer> renderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LOD.NativeFieldInfoPtr_renderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LOD.NativeFieldInfoPtr_renderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeFieldInfoPtr_screenRelativeTransitionHeight;

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeFieldInfoPtr_fadeTransitionWidth;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeFieldInfoPtr_renderers;
	}
}
