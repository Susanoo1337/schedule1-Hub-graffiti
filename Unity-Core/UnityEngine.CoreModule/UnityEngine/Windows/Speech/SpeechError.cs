using System;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x0200018B RID: 395
	public enum SpeechError
	{
		// Token: 0x040018A2 RID: 6306
		NoError,
		// Token: 0x040018A3 RID: 6307
		TopicLanguageNotSupported,
		// Token: 0x040018A4 RID: 6308
		GrammarLanguageMismatch,
		// Token: 0x040018A5 RID: 6309
		GrammarCompilationFailure,
		// Token: 0x040018A6 RID: 6310
		AudioQualityFailure,
		// Token: 0x040018A7 RID: 6311
		PauseLimitExceeded,
		// Token: 0x040018A8 RID: 6312
		TimeoutExceeded,
		// Token: 0x040018A9 RID: 6313
		NetworkFailure,
		// Token: 0x040018AA RID: 6314
		MicrophoneUnavailable,
		// Token: 0x040018AB RID: 6315
		UnknownError
	}
}
