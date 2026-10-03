using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020000AC RID: 172
	public sealed class OcclusionArea : Component
	{
		// Token: 0x06000E09 RID: 3593 RVA: 0x00040D00 File Offset: 0x0003EF00
		// Note: this type is marked as 'beforefieldinit'.
		static OcclusionArea()
		{
			Il2CppClassPointerStore<OcclusionArea>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "OcclusionArea");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OcclusionArea>.NativeClassPtr);
			OcclusionArea.get_center_InjectedDelegateField = IL2CPP.ResolveICall<OcclusionArea.get_center_InjectedDelegate>("UnityEngine.OcclusionArea::get_center_Injected");
			OcclusionArea.set_center_InjectedDelegateField = IL2CPP.ResolveICall<OcclusionArea.set_center_InjectedDelegate>("UnityEngine.OcclusionArea::set_center_Injected");
			OcclusionArea.get_size_InjectedDelegateField = IL2CPP.ResolveICall<OcclusionArea.get_size_InjectedDelegate>("UnityEngine.OcclusionArea::get_size_Injected");
			OcclusionArea.set_size_InjectedDelegateField = IL2CPP.ResolveICall<OcclusionArea.set_size_InjectedDelegate>("UnityEngine.OcclusionArea::set_size_Injected");
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00008774 File Offset: 0x00006974
		public OcclusionArea(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x00040D6C File Offset: 0x0003EF6C
		// (set) Token: 0x06000E0C RID: 3596 RVA: 0x0000877D File Offset: 0x0000697D
		public Vector3 center
		{
			get
			{
				Vector3 result;
				this.get_center_Injected(out result);
				return result;
			}
			set
			{
				this.set_center_Injected(ref value);
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x00040D84 File Offset: 0x0003EF84
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x00008787 File Offset: 0x00006987
		public Vector3 size
		{
			get
			{
				Vector3 result;
				this.get_size_Injected(out result);
				return result;
			}
			set
			{
				this.set_size_Injected(ref value);
			}
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00008791 File Offset: 0x00006991
		public void get_center_Injected(out Vector3 ret)
		{
			OcclusionArea.get_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x000087A4 File Offset: 0x000069A4
		public void set_center_Injected(ref Vector3 value)
		{
			OcclusionArea.set_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x000087B7 File Offset: 0x000069B7
		public void get_size_Injected(out Vector3 ret)
		{
			OcclusionArea.get_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x000087CA File Offset: 0x000069CA
		public void set_size_Injected(ref Vector3 value)
		{
			OcclusionArea.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000A53 RID: 2643
		private static readonly OcclusionArea.get_center_InjectedDelegate get_center_InjectedDelegateField;

		// Token: 0x04000A54 RID: 2644
		private static readonly OcclusionArea.set_center_InjectedDelegate set_center_InjectedDelegateField;

		// Token: 0x04000A55 RID: 2645
		private static readonly OcclusionArea.get_size_InjectedDelegate get_size_InjectedDelegateField;

		// Token: 0x04000A56 RID: 2646
		private static readonly OcclusionArea.set_size_InjectedDelegate set_size_InjectedDelegateField;

		// Token: 0x02000705 RID: 1797
		// (Invoke) Token: 0x060036BE RID: 14014
		private delegate void get_center_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000706 RID: 1798
		// (Invoke) Token: 0x060036C0 RID: 14016
		private delegate void set_center_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000707 RID: 1799
		// (Invoke) Token: 0x060036C2 RID: 14018
		private delegate void get_size_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000708 RID: 1800
		// (Invoke) Token: 0x060036C4 RID: 14020
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
