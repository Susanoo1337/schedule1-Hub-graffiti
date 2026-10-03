using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using MelonLoader.Utils;

namespace HUB.Graffiti
{
	// Token: 0x02000007 RID: 7
	[NullableContext(1)]
	[Nullable(0)]
	internal static class DebugLog
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002E00 File Offset: 0x00001000
		static DebugLog()
		{
			try
			{
				if (!Directory.Exists(DebugLog.LogFolder))
				{
					Directory.CreateDirectory(DebugLog.LogFolder);
				}
			}
			catch
			{
			}
			string logFolder = DebugLog.LogFolder;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
			defaultInterpolatedStringHandler.AppendLiteral("graffiti_");
			defaultInterpolatedStringHandler.AppendFormatted<DateTime>(DateTime.Now, "yyyy-MM-dd");
			defaultInterpolatedStringHandler.AppendLiteral(".log");
			DebugLog.LogPath = Path.Combine(logFolder, defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002EA8 File Offset: 0x000010A8
		internal static void Log(string message)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
			defaultInterpolatedStringHandler.AppendLiteral("[");
			defaultInterpolatedStringHandler.AppendFormatted<DateTime>(DateTime.Now, "HH:mm:ss.fff");
			defaultInterpolatedStringHandler.AppendLiteral("] ");
			defaultInterpolatedStringHandler.AppendFormatted(message);
			string item = defaultInterpolatedStringHandler.ToStringAndClear();
			DebugLog._buffer.Add(item);
			if (DebugLog._buffer.Count > 500)
			{
				DebugLog._buffer.RemoveRange(0, DebugLog._buffer.Count - 500);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002F2E File Offset: 0x0000112E
		internal static void Log(string category, string message)
		{
			DebugLog.Log("[" + category + "] " + message);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002F46 File Offset: 0x00001146
		internal static void Update(float deltaTime)
		{
			if (DebugLog._buffer.Count == 0)
			{
				return;
			}
			DebugLog._flushTimer -= deltaTime;
			if (DebugLog._flushTimer > 0f)
			{
				return;
			}
			DebugLog._flushTimer = 10f;
			DebugLog.Flush();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002F80 File Offset: 0x00001180
		internal static void Flush()
		{
			if (DebugLog._buffer.Count == 0)
			{
				return;
			}
			try
			{
				List<string> contents = new List<string>(DebugLog._buffer);
				DebugLog._buffer.Clear();
				File.AppendAllLines(DebugLog.LogPath, contents);
			}
			catch
			{
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002FD0 File Offset: 0x000011D0
		internal static void Reset()
		{
			if (DebugLog._buffer.Count > 0)
			{
				DebugLog.Flush();
			}
			DebugLog._flushTimer = 0f;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002FEE File Offset: 0x000011EE
		internal static void LogSessionStart()
		{
			DebugLog.Log("========================================");
			DebugLog.Log("HUB - Graffiti v1.2.1 | Session started");
			DebugLog.Log("========================================");
		}

		// Token: 0x04000006 RID: 6
		internal static readonly string LogFolder = Path.Combine(MelonEnvironment.UserDataDirectory, "HUB_Graffiti", "logs");

		// Token: 0x04000007 RID: 7
		private static readonly string LogPath;

		// Token: 0x04000008 RID: 8
		private static readonly List<string> _buffer = new List<string>();

		// Token: 0x04000009 RID: 9
		private static float _flushTimer;

		// Token: 0x0400000A RID: 10
		private const float FLUSH_INTERVAL = 10f;

		// Token: 0x0400000B RID: 11
		private const int MAX_ENTRIES = 500;
	}
}
