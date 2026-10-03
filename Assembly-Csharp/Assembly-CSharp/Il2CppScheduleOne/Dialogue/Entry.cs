using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003C6 RID: 966
	[Serializable]
	public sealed class Entry : ValueType
	{
		// Token: 0x0600571A RID: 22298 RVA: 0x001A9004 File Offset: 0x001A7204
		// Note: this type is marked as 'beforefieldinit'.
		static Entry()
		{
			Il2CppClassPointerStore<Entry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "Entry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entry>.NativeClassPtr);
			Entry.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entry>.NativeClassPtr, "Key");
			Entry.NativeFieldInfoPtr_Chains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entry>.NativeClassPtr, "Chains");
			Entry.NativeMethodInfoPtr_GetRandomChain_Public_DialogueChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entry>.NativeClassPtr, 100674736);
			Entry.NativeMethodInfoPtr_GetRandomLine_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entry>.NativeClassPtr, 100674737);
		}

		// Token: 0x0600571B RID: 22299 RVA: 0x001A9084 File Offset: 0x001A7284
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191743, RefRangeEnd = 191744, XrefRangeStart = 191742, XrefRangeEnd = 191743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChain GetRandomChain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entry.NativeMethodInfoPtr_GetRandomChain_Public_DialogueChain_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueChain>(intPtr3) : null;
		}

		// Token: 0x0600571C RID: 22300 RVA: 0x001A90C8 File Offset: 0x001A72C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191745, RefRangeEnd = 191746, XrefRangeStart = 191744, XrefRangeEnd = 191745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetRandomLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entry.NativeMethodInfoPtr_GetRandomLine_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600571D RID: 22301 RVA: 0x0002920C File Offset: 0x0002740C
		public Entry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600571E RID: 22302 RVA: 0x00029215 File Offset: 0x00027415
		public Entry() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entry>.NativeClassPtr))
		{
		}

		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x0600571F RID: 22303 RVA: 0x001A9104 File Offset: 0x001A7304
		// (set) Token: 0x06005720 RID: 22304 RVA: 0x00029227 File Offset: 0x00027427
		public unsafe string Key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entry.NativeFieldInfoPtr_Key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entry.NativeFieldInfoPtr_Key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x06005721 RID: 22305 RVA: 0x001A912C File Offset: 0x001A732C
		// (set) Token: 0x06005722 RID: 22306 RVA: 0x00029246 File Offset: 0x00027446
		public unsafe Il2CppReferenceArray<DialogueChain> Chains
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entry.NativeFieldInfoPtr_Chains);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogueChain>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entry.NativeFieldInfoPtr_Chains), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BF8 RID: 15352
		private static readonly IntPtr NativeFieldInfoPtr_Key;

		// Token: 0x04003BF9 RID: 15353
		private static readonly IntPtr NativeFieldInfoPtr_Chains;

		// Token: 0x04003BFA RID: 15354
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomChain_Public_DialogueChain_0;

		// Token: 0x04003BFB RID: 15355
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomLine_Public_String_0;
	}
}
