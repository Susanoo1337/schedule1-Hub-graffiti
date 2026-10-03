using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Device
{
	// Token: 0x0200035B RID: 859
	public static class Screen
	{
		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06002E50 RID: 11856 RVA: 0x000149FE File Offset: 0x00012BFE
		// (set) Token: 0x06002E51 RID: 11857 RVA: 0x00014A05 File Offset: 0x00012C05
		public static float brightness
		{
			get
			{
				return Screen.brightness;
			}
			set
			{
				Screen.brightness = value;
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06002E52 RID: 11858 RVA: 0x00014A0E File Offset: 0x00012C0E
		// (set) Token: 0x06002E53 RID: 11859 RVA: 0x00014A15 File Offset: 0x00012C15
		public static bool autorotateToLandscapeLeft
		{
			get
			{
				return Screen.autorotateToLandscapeLeft;
			}
			set
			{
				Screen.autorotateToLandscapeLeft = value;
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06002E54 RID: 11860 RVA: 0x00014A1E File Offset: 0x00012C1E
		// (set) Token: 0x06002E55 RID: 11861 RVA: 0x00014A25 File Offset: 0x00012C25
		public static bool autorotateToLandscapeRight
		{
			get
			{
				return Screen.autorotateToLandscapeRight;
			}
			set
			{
				Screen.autorotateToLandscapeRight = value;
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06002E56 RID: 11862 RVA: 0x00014A2E File Offset: 0x00012C2E
		// (set) Token: 0x06002E57 RID: 11863 RVA: 0x00014A35 File Offset: 0x00012C35
		public static bool autorotateToPortrait
		{
			get
			{
				return Screen.autorotateToPortrait;
			}
			set
			{
				Screen.autorotateToPortrait = value;
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06002E58 RID: 11864 RVA: 0x00014A3E File Offset: 0x00012C3E
		// (set) Token: 0x06002E59 RID: 11865 RVA: 0x00014A45 File Offset: 0x00012C45
		public static bool autorotateToPortraitUpsideDown
		{
			get
			{
				return Screen.autorotateToPortraitUpsideDown;
			}
			set
			{
				Screen.autorotateToPortraitUpsideDown = value;
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06002E5A RID: 11866 RVA: 0x00014A4E File Offset: 0x00012C4E
		public static Resolution currentResolution
		{
			get
			{
				return Screen.currentResolution;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06002E5B RID: 11867 RVA: 0x00014A55 File Offset: 0x00012C55
		public static Il2CppStructArray<Rect> cutouts
		{
			get
			{
				return Screen.cutouts;
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06002E5C RID: 11868 RVA: 0x00014A5C File Offset: 0x00012C5C
		public static float dpi
		{
			get
			{
				return Screen.dpi;
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06002E5D RID: 11869 RVA: 0x00014A63 File Offset: 0x00012C63
		// (set) Token: 0x06002E5E RID: 11870 RVA: 0x00014A6A File Offset: 0x00012C6A
		public static bool fullScreen
		{
			get
			{
				return Screen.fullScreen;
			}
			set
			{
				Screen.fullScreen = value;
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06002E5F RID: 11871 RVA: 0x00014A73 File Offset: 0x00012C73
		// (set) Token: 0x06002E60 RID: 11872 RVA: 0x00014A7A File Offset: 0x00012C7A
		public static FullScreenMode fullScreenMode
		{
			get
			{
				return Screen.fullScreenMode;
			}
			set
			{
				Screen.fullScreenMode = value;
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06002E61 RID: 11873 RVA: 0x00014A83 File Offset: 0x00012C83
		public static int height
		{
			get
			{
				return Screen.height;
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06002E62 RID: 11874 RVA: 0x00014A8A File Offset: 0x00012C8A
		public static int width
		{
			get
			{
				return Screen.width;
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06002E63 RID: 11875 RVA: 0x00014A91 File Offset: 0x00012C91
		// (set) Token: 0x06002E64 RID: 11876 RVA: 0x00014A98 File Offset: 0x00012C98
		public static ScreenOrientation orientation
		{
			get
			{
				return Screen.orientation;
			}
			set
			{
				Screen.orientation = value;
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06002E65 RID: 11877 RVA: 0x00014AA1 File Offset: 0x00012CA1
		public static Il2CppStructArray<Resolution> resolutions
		{
			get
			{
				return Screen.resolutions;
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06002E66 RID: 11878 RVA: 0x00014AA8 File Offset: 0x00012CA8
		public static Rect safeArea
		{
			get
			{
				return Screen.safeArea;
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06002E67 RID: 11879 RVA: 0x00014AAF File Offset: 0x00012CAF
		// (set) Token: 0x06002E68 RID: 11880 RVA: 0x00014AB6 File Offset: 0x00012CB6
		public static int sleepTimeout
		{
			get
			{
				return Screen.sleepTimeout;
			}
			set
			{
				Screen.sleepTimeout = value;
			}
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x00014ABF File Offset: 0x00012CBF
		public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate)
		{
			Screen.SetResolution(width, height, fullscreenMode, preferredRefreshRate);
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x000AD3DC File Offset: 0x000AB5DC
		public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate)
		{
			bool flag = preferredRefreshRate < 0;
			if (flag)
			{
				preferredRefreshRate = 0;
			}
			Screen.SetResolution(width, height, fullscreenMode, new RefreshRate
			{
				numerator = (uint)preferredRefreshRate,
				denominator = 1U
			});
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x000AD418 File Offset: 0x000AB618
		public static void SetResolution(int width, int height, FullScreenMode fullscreenMode)
		{
			Screen.SetResolution(width, height, fullscreenMode, new RefreshRate
			{
				numerator = 0U,
				denominator = 1U
			});
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x000AD448 File Offset: 0x000AB648
		public static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate)
		{
			bool flag = preferredRefreshRate < 0;
			if (flag)
			{
				preferredRefreshRate = 0;
			}
			Screen.SetResolution(width, height, fullscreen ? FullScreenMode.FullScreenWindow : FullScreenMode.Windowed, new RefreshRate
			{
				numerator = (uint)preferredRefreshRate,
				denominator = 1U
			});
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x000AD48C File Offset: 0x000AB68C
		public static void SetResolution(int width, int height, bool fullscreen)
		{
			Screen.SetResolution(width, height, fullscreen ? FullScreenMode.FullScreenWindow : FullScreenMode.Windowed, new RefreshRate
			{
				numerator = 0U,
				denominator = 1U
			});
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06002E6E RID: 11886 RVA: 0x00014ACC File Offset: 0x00012CCC
		public static Vector2Int mainWindowPosition
		{
			get
			{
				return Screen.mainWindowPosition;
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06002E6F RID: 11887 RVA: 0x00014AD3 File Offset: 0x00012CD3
		public static DisplayInfo mainWindowDisplayInfo
		{
			get
			{
				return Screen.mainWindowDisplayInfo;
			}
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x00014ADA File Offset: 0x00012CDA
		public static void GetDisplayLayout(List<DisplayInfo> displayLayout)
		{
			Screen.GetDisplayLayout(displayLayout);
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x00014AE3 File Offset: 0x00012CE3
		public static AsyncOperation MoveMainWindowTo([In] ref DisplayInfo display, Vector2Int position)
		{
			return Screen.MoveMainWindowTo(ref display, position);
		}
	}
}
