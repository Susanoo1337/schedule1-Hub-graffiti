using System;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x0200018C RID: 396
	public enum DictationCompletionCause
	{
		// Token: 0x040018AD RID: 6317
		Complete,
		// Token: 0x040018AE RID: 6318
		AudioQualityFailure,
		// Token: 0x040018AF RID: 6319
		Canceled,
		// Token: 0x040018B0 RID: 6320
		TimeoutExceeded,
		// Token: 0x040018B1 RID: 6321
		PauseLimitExceeded,
		// Token: 0x040018B2 RID: 6322
		NetworkFailure,
		// Token: 0x040018B3 RID: 6323
		MicrophoneUnavailable,
		// Token: 0x040018B4 RID: 6324
		UnknownError
	}
}
