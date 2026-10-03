using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x020000AD RID: 173
	public sealed class LensFlare : Behaviour
	{
		// Token: 0x06000E13 RID: 3603 RVA: 0x00040D9C File Offset: 0x0003EF9C
		// Note: this type is marked as 'beforefieldinit'.
		static LensFlare()
		{
			Il2CppClassPointerStore<LensFlare>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LensFlare");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensFlare>.NativeClassPtr);
			LensFlare.get_brightnessDelegateField = IL2CPP.ResolveICall<LensFlare.get_brightnessDelegate>("UnityEngine.LensFlare::get_brightness");
			LensFlare.set_brightnessDelegateField = IL2CPP.ResolveICall<LensFlare.set_brightnessDelegate>("UnityEngine.LensFlare::set_brightness");
			LensFlare.get_fadeSpeedDelegateField = IL2CPP.ResolveICall<LensFlare.get_fadeSpeedDelegate>("UnityEngine.LensFlare::get_fadeSpeed");
			LensFlare.set_fadeSpeedDelegateField = IL2CPP.ResolveICall<LensFlare.set_fadeSpeedDelegate>("UnityEngine.LensFlare::set_fadeSpeed");
			LensFlare.get_flareDelegateField = IL2CPP.ResolveICall<LensFlare.get_flareDelegate>("UnityEngine.LensFlare::get_flare");
			LensFlare.set_flareDelegateField = IL2CPP.ResolveICall<LensFlare.set_flareDelegate>("UnityEngine.LensFlare::set_flare");
			LensFlare.get_color_InjectedDelegateField = IL2CPP.ResolveICall<LensFlare.get_color_InjectedDelegate>("UnityEngine.LensFlare::get_color_Injected");
			LensFlare.set_color_InjectedDelegateField = IL2CPP.ResolveICall<LensFlare.set_color_InjectedDelegate>("UnityEngine.LensFlare::set_color_Injected");
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x000087DD File Offset: 0x000069DD
		public LensFlare(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000E15 RID: 3605 RVA: 0x000087E6 File Offset: 0x000069E6
		// (set) Token: 0x06000E16 RID: 3606 RVA: 0x000087F8 File Offset: 0x000069F8
		public float brightness
		{
			get
			{
				return LensFlare.get_brightnessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LensFlare.set_brightnessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000E17 RID: 3607 RVA: 0x0000880B File Offset: 0x00006A0B
		// (set) Token: 0x06000E18 RID: 3608 RVA: 0x0000881D File Offset: 0x00006A1D
		public float fadeSpeed
		{
			get
			{
				return LensFlare.get_fadeSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LensFlare.set_fadeSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x00040E44 File Offset: 0x0003F044
		// (set) Token: 0x06000E1A RID: 3610 RVA: 0x00008830 File Offset: 0x00006A30
		public Color color
		{
			get
			{
				Color result;
				this.get_color_Injected(out result);
				return result;
			}
			set
			{
				this.set_color_Injected(ref value);
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x00040E5C File Offset: 0x0003F05C
		// (set) Token: 0x06000E1C RID: 3612 RVA: 0x0000883A File Offset: 0x00006A3A
		public Flare flare
		{
			get
			{
				IntPtr intPtr = LensFlare.get_flareDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Flare>(intPtr2) : null;
			}
			set
			{
				LensFlare.set_flareDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00008852 File Offset: 0x00006A52
		public void get_color_Injected(out Color ret)
		{
			LensFlare.get_color_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00008865 File Offset: 0x00006A65
		public void set_color_Injected(ref Color value)
		{
			LensFlare.set_color_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000A57 RID: 2647
		private static readonly LensFlare.get_brightnessDelegate get_brightnessDelegateField;

		// Token: 0x04000A58 RID: 2648
		private static readonly LensFlare.set_brightnessDelegate set_brightnessDelegateField;

		// Token: 0x04000A59 RID: 2649
		private static readonly LensFlare.get_fadeSpeedDelegate get_fadeSpeedDelegateField;

		// Token: 0x04000A5A RID: 2650
		private static readonly LensFlare.set_fadeSpeedDelegate set_fadeSpeedDelegateField;

		// Token: 0x04000A5B RID: 2651
		private static readonly LensFlare.get_flareDelegate get_flareDelegateField;

		// Token: 0x04000A5C RID: 2652
		private static readonly LensFlare.set_flareDelegate set_flareDelegateField;

		// Token: 0x04000A5D RID: 2653
		private static readonly LensFlare.get_color_InjectedDelegate get_color_InjectedDelegateField;

		// Token: 0x04000A5E RID: 2654
		private static readonly LensFlare.set_color_InjectedDelegate set_color_InjectedDelegateField;

		// Token: 0x02000709 RID: 1801
		// (Invoke) Token: 0x060036C6 RID: 14022
		private delegate float get_brightnessDelegate(IntPtr @this);

		// Token: 0x0200070A RID: 1802
		// (Invoke) Token: 0x060036C8 RID: 14024
		private delegate void set_brightnessDelegate(IntPtr @this, float value);

		// Token: 0x0200070B RID: 1803
		// (Invoke) Token: 0x060036CA RID: 14026
		private delegate float get_fadeSpeedDelegate(IntPtr @this);

		// Token: 0x0200070C RID: 1804
		// (Invoke) Token: 0x060036CC RID: 14028
		private delegate void set_fadeSpeedDelegate(IntPtr @this, float value);

		// Token: 0x0200070D RID: 1805
		// (Invoke) Token: 0x060036CE RID: 14030
		private delegate IntPtr get_flareDelegate(IntPtr @this);

		// Token: 0x0200070E RID: 1806
		// (Invoke) Token: 0x060036D0 RID: 14032
		private delegate void set_flareDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200070F RID: 1807
		// (Invoke) Token: 0x060036D2 RID: 14034
		private delegate void get_color_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000710 RID: 1808
		// (Invoke) Token: 0x060036D4 RID: 14036
		private delegate void set_color_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
