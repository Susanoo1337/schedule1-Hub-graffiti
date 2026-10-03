using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020002FC RID: 764
	public class DrivenPropertyManager
	{
		// Token: 0x06002D47 RID: 11591 RVA: 0x00014082 File Offset: 0x00012282
		public static void RegisterProperty(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.RegisterPropertyPartial(driver, target, propertyPath);
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x0001408E File Offset: 0x0001228E
		public static void TryRegisterProperty(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.TryRegisterPropertyPartial(driver, target, propertyPath);
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x0001409A File Offset: 0x0001229A
		public static void UnregisterProperty(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.UnregisterPropertyPartial(driver, target, propertyPath);
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x000140A6 File Offset: 0x000122A6
		public static void UnregisterProperties(Object driver)
		{
			DrivenPropertyManager.UnregisterPropertiesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(driver));
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x000140B8 File Offset: 0x000122B8
		public static void RegisterPropertyPartial(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.RegisterPropertyPartialDelegateField(IL2CPP.Il2CppObjectBaseToPtr(driver), IL2CPP.Il2CppObjectBaseToPtr(target), IL2CPP.ManagedStringToIl2Cpp(propertyPath));
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x000140D6 File Offset: 0x000122D6
		public static void TryRegisterPropertyPartial(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.TryRegisterPropertyPartialDelegateField(IL2CPP.Il2CppObjectBaseToPtr(driver), IL2CPP.Il2CppObjectBaseToPtr(target), IL2CPP.ManagedStringToIl2Cpp(propertyPath));
		}

		// Token: 0x06002D4D RID: 11597 RVA: 0x000140F4 File Offset: 0x000122F4
		public static void UnregisterPropertyPartial(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.UnregisterPropertyPartialDelegateField(IL2CPP.Il2CppObjectBaseToPtr(driver), IL2CPP.Il2CppObjectBaseToPtr(target), IL2CPP.ManagedStringToIl2Cpp(propertyPath));
		}

		// Token: 0x040027FE RID: 10238
		private static readonly DrivenPropertyManager.UnregisterPropertiesDelegate UnregisterPropertiesDelegateField = IL2CPP.ResolveICall<DrivenPropertyManager.UnregisterPropertiesDelegate>("UnityEngine.DrivenPropertyManager::UnregisterProperties");

		// Token: 0x040027FF RID: 10239
		private static readonly DrivenPropertyManager.RegisterPropertyPartialDelegate RegisterPropertyPartialDelegateField = IL2CPP.ResolveICall<DrivenPropertyManager.RegisterPropertyPartialDelegate>("UnityEngine.DrivenPropertyManager::RegisterPropertyPartial");

		// Token: 0x04002800 RID: 10240
		private static readonly DrivenPropertyManager.TryRegisterPropertyPartialDelegate TryRegisterPropertyPartialDelegateField = IL2CPP.ResolveICall<DrivenPropertyManager.TryRegisterPropertyPartialDelegate>("UnityEngine.DrivenPropertyManager::TryRegisterPropertyPartial");

		// Token: 0x04002801 RID: 10241
		private static readonly DrivenPropertyManager.UnregisterPropertyPartialDelegate UnregisterPropertyPartialDelegateField = IL2CPP.ResolveICall<DrivenPropertyManager.UnregisterPropertyPartialDelegate>("UnityEngine.DrivenPropertyManager::UnregisterPropertyPartial");

		// Token: 0x02000CC8 RID: 3272
		// (Invoke) Token: 0x0600422D RID: 16941
		private delegate void UnregisterPropertiesDelegate(IntPtr driver);

		// Token: 0x02000CC9 RID: 3273
		// (Invoke) Token: 0x0600422F RID: 16943
		private delegate void RegisterPropertyPartialDelegate(IntPtr driver, IntPtr target, IntPtr propertyPath);

		// Token: 0x02000CCA RID: 3274
		// (Invoke) Token: 0x06004231 RID: 16945
		private delegate void TryRegisterPropertyPartialDelegate(IntPtr driver, IntPtr target, IntPtr propertyPath);

		// Token: 0x02000CCB RID: 3275
		// (Invoke) Token: 0x06004233 RID: 16947
		private delegate void UnregisterPropertyPartialDelegate(IntPtr driver, IntPtr target, IntPtr propertyPath);
	}
}
