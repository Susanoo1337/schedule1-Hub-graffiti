using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020002C1 RID: 705
	public class DiagnosticSwitch
	{
		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06002CCA RID: 11466 RVA: 0x000ABAB8 File Offset: 0x000A9CB8
		public string name
		{
			get
			{
				IntPtr intPtr = DiagnosticSwitch.get_nameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06002CCB RID: 11467 RVA: 0x000ABADC File Offset: 0x000A9CDC
		public string description
		{
			get
			{
				IntPtr intPtr = DiagnosticSwitch.get_descriptionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06002CCC RID: 11468 RVA: 0x000ABB00 File Offset: 0x000A9D00
		public string owningModule
		{
			get
			{
				IntPtr intPtr = DiagnosticSwitch.get_owningModuleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06002CCD RID: 11469 RVA: 0x00013A4D File Offset: 0x00011C4D
		public DiagnosticSwitch.Flags flags
		{
			get
			{
				return DiagnosticSwitch.get_flagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06002CCE RID: 11470 RVA: 0x00013A5F File Offset: 0x00011C5F
		// (set) Token: 0x06002CCF RID: 11471 RVA: 0x00013A67 File Offset: 0x00011C67
		public Object value
		{
			get
			{
				return this.GetScriptingValue();
			}
			set
			{
				this.SetScriptingValue(value, false);
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06002CD0 RID: 11472 RVA: 0x000ABB24 File Offset: 0x000A9D24
		public Object defaultValue
		{
			get
			{
				IntPtr intPtr = DiagnosticSwitch.get_defaultValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06002CD1 RID: 11473 RVA: 0x000ABB50 File Offset: 0x000A9D50
		public Object minValue
		{
			get
			{
				IntPtr intPtr = DiagnosticSwitch.get_minValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06002CD2 RID: 11474 RVA: 0x000ABB7C File Offset: 0x000A9D7C
		public Object maxValue
		{
			get
			{
				IntPtr intPtr = DiagnosticSwitch.get_maxValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06002CD3 RID: 11475 RVA: 0x00013A72 File Offset: 0x00011C72
		// (set) Token: 0x06002CD4 RID: 11476 RVA: 0x00013A7A File Offset: 0x00011C7A
		public Object persistentValue
		{
			get
			{
				return this.GetScriptingPersistentValue();
			}
			set
			{
				this.SetScriptingValue(value, true);
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06002CD5 RID: 11477 RVA: 0x000ABBA8 File Offset: 0x000A9DA8
		public EnumInfo enumInfo
		{
			get
			{
				IntPtr intPtr = DiagnosticSwitch.get_enumInfoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnumInfo>(intPtr2) : null;
			}
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x000ABBD4 File Offset: 0x000A9DD4
		public Object GetScriptingValue()
		{
			IntPtr intPtr = DiagnosticSwitch.GetScriptingValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x000ABC00 File Offset: 0x000A9E00
		public Object GetScriptingPersistentValue()
		{
			IntPtr intPtr = DiagnosticSwitch.GetScriptingPersistentValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x00013A85 File Offset: 0x00011C85
		public void SetScriptingValue(Object value, bool setPersistent)
		{
			DiagnosticSwitch.SetScriptingValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value), setPersistent);
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06002CD9 RID: 11481 RVA: 0x00013A9E File Offset: 0x00011C9E
		public bool isSetToDefault
		{
			get
			{
				return Object.Equals(this.persistentValue, this.defaultValue);
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06002CDA RID: 11482 RVA: 0x00013AB1 File Offset: 0x00011CB1
		public bool needsRestart
		{
			get
			{
				return !Object.Equals(this.value, this.persistentValue);
			}
		}

		// Token: 0x0400270A RID: 9994
		private static readonly DiagnosticSwitch.get_nameDelegate get_nameDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_nameDelegate>("UnityEngine.DiagnosticSwitch::get_name");

		// Token: 0x0400270B RID: 9995
		private static readonly DiagnosticSwitch.get_descriptionDelegate get_descriptionDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_descriptionDelegate>("UnityEngine.DiagnosticSwitch::get_description");

		// Token: 0x0400270C RID: 9996
		private static readonly DiagnosticSwitch.get_owningModuleDelegate get_owningModuleDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_owningModuleDelegate>("UnityEngine.DiagnosticSwitch::get_owningModule");

		// Token: 0x0400270D RID: 9997
		private static readonly DiagnosticSwitch.get_flagsDelegate get_flagsDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_flagsDelegate>("UnityEngine.DiagnosticSwitch::get_flags");

		// Token: 0x0400270E RID: 9998
		private static readonly DiagnosticSwitch.get_defaultValueDelegate get_defaultValueDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_defaultValueDelegate>("UnityEngine.DiagnosticSwitch::get_defaultValue");

		// Token: 0x0400270F RID: 9999
		private static readonly DiagnosticSwitch.get_minValueDelegate get_minValueDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_minValueDelegate>("UnityEngine.DiagnosticSwitch::get_minValue");

		// Token: 0x04002710 RID: 10000
		private static readonly DiagnosticSwitch.get_maxValueDelegate get_maxValueDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_maxValueDelegate>("UnityEngine.DiagnosticSwitch::get_maxValue");

		// Token: 0x04002711 RID: 10001
		private static readonly DiagnosticSwitch.get_enumInfoDelegate get_enumInfoDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.get_enumInfoDelegate>("UnityEngine.DiagnosticSwitch::get_enumInfo");

		// Token: 0x04002712 RID: 10002
		private static readonly DiagnosticSwitch.GetScriptingValueDelegate GetScriptingValueDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.GetScriptingValueDelegate>("UnityEngine.DiagnosticSwitch::GetScriptingValue");

		// Token: 0x04002713 RID: 10003
		private static readonly DiagnosticSwitch.GetScriptingPersistentValueDelegate GetScriptingPersistentValueDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.GetScriptingPersistentValueDelegate>("UnityEngine.DiagnosticSwitch::GetScriptingPersistentValue");

		// Token: 0x04002714 RID: 10004
		private static readonly DiagnosticSwitch.SetScriptingValueDelegate SetScriptingValueDelegateField = IL2CPP.ResolveICall<DiagnosticSwitch.SetScriptingValueDelegate>("UnityEngine.DiagnosticSwitch::SetScriptingValue");

		// Token: 0x02000C7F RID: 3199
		public enum Flags
		{
			// Token: 0x04002C80 RID: 11392
			None,
			// Token: 0x04002C81 RID: 11393
			CanChangeAfterEngineStart,
			// Token: 0x04002C82 RID: 11394
			PropagateToAssetImportWorkerProcess
		}

		// Token: 0x02000C80 RID: 3200
		// (Invoke) Token: 0x0600419D RID: 16797
		private delegate IntPtr get_nameDelegate(IntPtr @this);

		// Token: 0x02000C81 RID: 3201
		// (Invoke) Token: 0x0600419F RID: 16799
		private delegate IntPtr get_descriptionDelegate(IntPtr @this);

		// Token: 0x02000C82 RID: 3202
		// (Invoke) Token: 0x060041A1 RID: 16801
		private delegate IntPtr get_owningModuleDelegate(IntPtr @this);

		// Token: 0x02000C83 RID: 3203
		// (Invoke) Token: 0x060041A3 RID: 16803
		private delegate DiagnosticSwitch.Flags get_flagsDelegate(IntPtr @this);

		// Token: 0x02000C84 RID: 3204
		// (Invoke) Token: 0x060041A5 RID: 16805
		private delegate IntPtr get_defaultValueDelegate(IntPtr @this);

		// Token: 0x02000C85 RID: 3205
		// (Invoke) Token: 0x060041A7 RID: 16807
		private delegate IntPtr get_minValueDelegate(IntPtr @this);

		// Token: 0x02000C86 RID: 3206
		// (Invoke) Token: 0x060041A9 RID: 16809
		private delegate IntPtr get_maxValueDelegate(IntPtr @this);

		// Token: 0x02000C87 RID: 3207
		// (Invoke) Token: 0x060041AB RID: 16811
		private delegate IntPtr get_enumInfoDelegate(IntPtr @this);

		// Token: 0x02000C88 RID: 3208
		// (Invoke) Token: 0x060041AD RID: 16813
		private delegate IntPtr GetScriptingValueDelegate(IntPtr @this);

		// Token: 0x02000C89 RID: 3209
		// (Invoke) Token: 0x060041AF RID: 16815
		private delegate IntPtr GetScriptingPersistentValueDelegate(IntPtr @this);

		// Token: 0x02000C8A RID: 3210
		// (Invoke) Token: 0x060041B1 RID: 16817
		private delegate void SetScriptingValueDelegate(IntPtr @this, IntPtr value, bool setPersistent);
	}
}
