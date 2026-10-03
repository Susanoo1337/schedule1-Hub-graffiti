using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020002FB RID: 763
	public sealed class Ping
	{
		// Token: 0x06002D3E RID: 11582 RVA: 0x000AC298 File Offset: 0x000AA498
		public ~Ping()
		{
			this.DestroyPing();
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x00013FE7 File Offset: 0x000121E7
		public void DestroyPing()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002D40 RID: 11584 RVA: 0x00013FF4 File Offset: 0x000121F4
		public static void Internal_Destroy(IntPtr ptr)
		{
			Ping.Internal_DestroyDelegateField(ptr);
		}

		// Token: 0x06002D41 RID: 11585 RVA: 0x00014001 File Offset: 0x00012201
		public static IntPtr Internal_Create(string address)
		{
			return Ping.Internal_CreateDelegateField(IL2CPP.ManagedStringToIl2Cpp(address));
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06002D42 RID: 11586 RVA: 0x00014013 File Offset: 0x00012213
		public bool isDone
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06002D43 RID: 11587 RVA: 0x00014020 File Offset: 0x00012220
		public bool Internal_IsDone()
		{
			return Ping.Internal_IsDoneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06002D44 RID: 11588 RVA: 0x00014032 File Offset: 0x00012232
		public int time
		{
			get
			{
				return Ping.get_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06002D45 RID: 11589 RVA: 0x000AC2C8 File Offset: 0x000AA4C8
		public string ip
		{
			get
			{
				IntPtr intPtr = Ping.get_ipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x040027F9 RID: 10233
		private static readonly Ping.Internal_DestroyDelegate Internal_DestroyDelegateField = IL2CPP.ResolveICall<Ping.Internal_DestroyDelegate>("UnityEngine.Ping::Internal_Destroy");

		// Token: 0x040027FA RID: 10234
		private static readonly Ping.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<Ping.Internal_CreateDelegate>("UnityEngine.Ping::Internal_Create");

		// Token: 0x040027FB RID: 10235
		private static readonly Ping.Internal_IsDoneDelegate Internal_IsDoneDelegateField = IL2CPP.ResolveICall<Ping.Internal_IsDoneDelegate>("UnityEngine.Ping::Internal_IsDone");

		// Token: 0x040027FC RID: 10236
		private static readonly Ping.get_timeDelegate get_timeDelegateField = IL2CPP.ResolveICall<Ping.get_timeDelegate>("UnityEngine.Ping::get_time");

		// Token: 0x040027FD RID: 10237
		private static readonly Ping.get_ipDelegate get_ipDelegateField = IL2CPP.ResolveICall<Ping.get_ipDelegate>("UnityEngine.Ping::get_ip");

		// Token: 0x02000CC3 RID: 3267
		// (Invoke) Token: 0x06004223 RID: 16931
		private delegate void Internal_DestroyDelegate(IntPtr ptr);

		// Token: 0x02000CC4 RID: 3268
		// (Invoke) Token: 0x06004225 RID: 16933
		private delegate IntPtr Internal_CreateDelegate(IntPtr address);

		// Token: 0x02000CC5 RID: 3269
		// (Invoke) Token: 0x06004227 RID: 16935
		private delegate bool Internal_IsDoneDelegate(IntPtr @this);

		// Token: 0x02000CC6 RID: 3270
		// (Invoke) Token: 0x06004229 RID: 16937
		private delegate int get_timeDelegate(IntPtr @this);

		// Token: 0x02000CC7 RID: 3271
		// (Invoke) Token: 0x0600422B RID: 16939
		private delegate IntPtr get_ipDelegate(IntPtr @this);
	}
}
