using System;

namespace UnityEngine.Assertions.Must
{
	// Token: 0x0200036F RID: 879
	public static class MustExtensions
	{
		// Token: 0x06002F45 RID: 12101 RVA: 0x00015475 File Offset: 0x00013675
		public static void MustBeTrue(bool value)
		{
			Assert.IsTrue(value);
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x0001547F File Offset: 0x0001367F
		public static void MustBeTrue(bool value, string message)
		{
			Assert.IsTrue(value, message);
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x0001548A File Offset: 0x0001368A
		public static void MustBeFalse(bool value)
		{
			Assert.IsFalse(value);
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x00015494 File Offset: 0x00013694
		public static void MustBeFalse(bool value, string message)
		{
			Assert.IsFalse(value, message);
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x0001549F File Offset: 0x0001369F
		public static void MustBeApproximatelyEqual(float actual, float expected)
		{
			Assert.AreApproximatelyEqual(actual, expected);
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x000154AA File Offset: 0x000136AA
		public static void MustBeApproximatelyEqual(float actual, float expected, string message)
		{
			Assert.AreApproximatelyEqual(actual, expected, message);
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x000154B6 File Offset: 0x000136B6
		public static void MustBeApproximatelyEqual(float actual, float expected, float tolerance)
		{
			Assert.AreApproximatelyEqual(actual, expected, tolerance);
		}

		// Token: 0x06002F4C RID: 12108 RVA: 0x000154C2 File Offset: 0x000136C2
		public static void MustBeApproximatelyEqual(float actual, float expected, float tolerance, string message)
		{
			Assert.AreApproximatelyEqual(expected, actual, tolerance, message);
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x000154CF File Offset: 0x000136CF
		public static void MustNotBeApproximatelyEqual(float actual, float expected)
		{
			Assert.AreNotApproximatelyEqual(expected, actual);
		}

		// Token: 0x06002F4E RID: 12110 RVA: 0x000154DA File Offset: 0x000136DA
		public static void MustNotBeApproximatelyEqual(float actual, float expected, string message)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, message);
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x000154E6 File Offset: 0x000136E6
		public static void MustNotBeApproximatelyEqual(float actual, float expected, float tolerance)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, tolerance);
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x000154F2 File Offset: 0x000136F2
		public static void MustNotBeApproximatelyEqual(float actual, float expected, float tolerance, string message)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, tolerance, message);
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x000154FF File Offset: 0x000136FF
		public static void MustBeEqual<T>(T actual, T expected)
		{
			Assert.AreEqual<T>(actual, expected);
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x0001550A File Offset: 0x0001370A
		public static void MustBeEqual<T>(T actual, T expected, string message)
		{
			Assert.AreEqual<T>(expected, actual, message);
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x00015516 File Offset: 0x00013716
		public static void MustNotBeEqual<T>(T actual, T expected)
		{
			Assert.AreNotEqual<T>(actual, expected);
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x00015521 File Offset: 0x00013721
		public static void MustNotBeEqual<T>(T actual, T expected, string message)
		{
			Assert.AreNotEqual<T>(expected, actual, message);
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x0001552D File Offset: 0x0001372D
		public static void MustBeNull<T>(T expected) where T : class
		{
			Assert.IsNull<T>(expected);
		}

		// Token: 0x06002F56 RID: 12118 RVA: 0x00015537 File Offset: 0x00013737
		public static void MustBeNull<T>(T expected, string message) where T : class
		{
			Assert.IsNull<T>(expected, message);
		}

		// Token: 0x06002F57 RID: 12119 RVA: 0x00015542 File Offset: 0x00013742
		public static void MustNotBeNull<T>(T expected) where T : class
		{
			Assert.IsNotNull<T>(expected);
		}

		// Token: 0x06002F58 RID: 12120 RVA: 0x0001554C File Offset: 0x0001374C
		public static void MustNotBeNull<T>(T expected, string message) where T : class
		{
			Assert.IsNotNull<T>(expected, message);
		}
	}
}
