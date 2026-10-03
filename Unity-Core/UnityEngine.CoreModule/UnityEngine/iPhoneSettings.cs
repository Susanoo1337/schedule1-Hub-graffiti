using System;

namespace UnityEngine
{
	// Token: 0x02000312 RID: 786
	public class iPhoneSettings
	{
		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06002D84 RID: 11652 RVA: 0x000ACAF0 File Offset: 0x000AACF0
		public static bool verticalOrientation
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06002D85 RID: 11653 RVA: 0x000ACB04 File Offset: 0x000AAD04
		public static bool screenCanDarken
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x00014292 File Offset: 0x00012492
		public static void StartLocationServiceUpdates(float desiredAccuracyInMeters, float updateDistanceInMeters)
		{
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x00014295 File Offset: 0x00012495
		public static void StartLocationServiceUpdates(float desiredAccuracyInMeters)
		{
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x00014298 File Offset: 0x00012498
		public static void StartLocationServiceUpdates()
		{
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x0001429B File Offset: 0x0001249B
		public static void StopLocationServiceUpdates()
		{
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06002D8A RID: 11658 RVA: 0x000ACB18 File Offset: 0x000AAD18
		public static bool locationServiceEnabledByUser
		{
			get
			{
				return false;
			}
		}
	}
}
