using System;
using System.Collections.Generic;
using System.IO;
using MelonLoader.Utils;

namespace HUB.Graffiti
{
	/// <summary>Buffered file log in UserData/HUB_Graffiti/logs, flushed every few seconds.</summary>
	internal static class DebugLog
	{
		private const float FlushInterval = 10f;
		private const int MaxEntries = 500;

		internal static readonly string LogFolder = Path.Combine(MelonEnvironment.UserDataDirectory, "HUB_Graffiti", "logs");

		private static readonly string LogPath;
		private static readonly List<string> _buffer = new List<string>();
		private static float _flushTimer;

		static DebugLog()
		{
			try
			{
				Directory.CreateDirectory(LogFolder);
			}
			catch
			{
			}
			LogPath = Path.Combine(LogFolder, "graffiti_" + DateTime.Now.ToString("yyyy-MM-dd") + ".log");
		}

		internal static void Log(string message)
		{
			_buffer.Add("[" + DateTime.Now.ToString("HH:mm:ss.fff") + "] " + message);
			if (_buffer.Count > MaxEntries)
			{
				_buffer.RemoveRange(0, _buffer.Count - MaxEntries);
			}
		}

		internal static void Log(string category, string message)
		{
			Log("[" + category + "] " + message);
		}

		internal static void Update(float deltaTime)
		{
			if (_buffer.Count == 0)
			{
				return;
			}
			_flushTimer -= deltaTime;
			if (_flushTimer > 0f)
			{
				return;
			}
			_flushTimer = FlushInterval;
			Flush();
		}

		internal static void Flush()
		{
			if (_buffer.Count == 0)
			{
				return;
			}
			try
			{
				List<string> lines = new List<string>(_buffer);
				_buffer.Clear();
				File.AppendAllLines(LogPath, lines);
			}
			catch
			{
			}
		}

		internal static void Reset()
		{
			Flush();
			_flushTimer = 0f;
		}

		internal static void LogSessionStart()
		{
			Log("========================================");
			Log(GraffitiMod.ModName + " v" + GraffitiMod.ModVersion + " | Session started");
			Log("========================================");
		}
	}
}
