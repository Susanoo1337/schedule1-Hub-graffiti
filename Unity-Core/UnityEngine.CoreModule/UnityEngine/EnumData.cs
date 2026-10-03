using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000136 RID: 310
	public sealed class EnumData : ValueType
	{
		// Token: 0x0600181A RID: 6170 RVA: 0x000677D4 File Offset: 0x000659D4
		// Note: this type is marked as 'beforefieldinit'.
		static EnumData()
		{
			Il2CppClassPointerStore<EnumData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "EnumData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumData>.NativeClassPtr);
			EnumData.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, "values");
			EnumData.NativeFieldInfoPtr_flagValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, "flagValues");
			EnumData.NativeFieldInfoPtr_displayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, "displayNames");
			EnumData.NativeFieldInfoPtr_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, "names");
			EnumData.NativeFieldInfoPtr_tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, "tooltip");
			EnumData.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, "flags");
			EnumData.NativeFieldInfoPtr_underlyingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, "underlyingType");
			EnumData.NativeFieldInfoPtr_unsigned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, "unsigned");
			EnumData.NativeFieldInfoPtr_serializable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, "serializable");
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x0000BF5D File Offset: 0x0000A15D
		public EnumData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x0000BF66 File Offset: 0x0000A166
		public EnumData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumData>.NativeClassPtr))
		{
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x0600181D RID: 6173 RVA: 0x000678B8 File Offset: 0x00065AB8
		// (set) Token: 0x0600181E RID: 6174 RVA: 0x0000BF78 File Offset: 0x0000A178
		public unsafe Il2CppReferenceArray<Enum> values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Enum>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x000678E8 File Offset: 0x00065AE8
		// (set) Token: 0x06001820 RID: 6176 RVA: 0x0000BF97 File Offset: 0x0000A197
		public unsafe Il2CppStructArray<int> flagValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_flagValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_flagValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x00067918 File Offset: 0x00065B18
		// (set) Token: 0x06001822 RID: 6178 RVA: 0x0000BFB6 File Offset: 0x0000A1B6
		public unsafe Il2CppStringArray displayNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_displayNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_displayNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001823 RID: 6179 RVA: 0x00067948 File Offset: 0x00065B48
		// (set) Token: 0x06001824 RID: 6180 RVA: 0x0000BFD5 File Offset: 0x0000A1D5
		public unsafe Il2CppStringArray names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001825 RID: 6181 RVA: 0x00067978 File Offset: 0x00065B78
		// (set) Token: 0x06001826 RID: 6182 RVA: 0x0000BFF4 File Offset: 0x0000A1F4
		public unsafe Il2CppStringArray tooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_tooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_tooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06001827 RID: 6183 RVA: 0x000679A8 File Offset: 0x00065BA8
		// (set) Token: 0x06001828 RID: 6184 RVA: 0x0000C013 File Offset: 0x0000A213
		public unsafe bool flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001829 RID: 6185 RVA: 0x000679D0 File Offset: 0x00065BD0
		// (set) Token: 0x0600182A RID: 6186 RVA: 0x0000C02E File Offset: 0x0000A22E
		public unsafe Type underlyingType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_underlyingType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_underlyingType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x0600182B RID: 6187 RVA: 0x00067A00 File Offset: 0x00065C00
		// (set) Token: 0x0600182C RID: 6188 RVA: 0x0000C04D File Offset: 0x0000A24D
		public unsafe bool unsigned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_unsigned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_unsigned)) = value;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x00067A28 File Offset: 0x00065C28
		// (set) Token: 0x0600182E RID: 6190 RVA: 0x0000C068 File Offset: 0x0000A268
		public unsafe bool serializable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_serializable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_serializable)) = value;
			}
		}

		// Token: 0x0400143E RID: 5182
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x0400143F RID: 5183
		private static readonly IntPtr NativeFieldInfoPtr_flagValues;

		// Token: 0x04001440 RID: 5184
		private static readonly IntPtr NativeFieldInfoPtr_displayNames;

		// Token: 0x04001441 RID: 5185
		private static readonly IntPtr NativeFieldInfoPtr_names;

		// Token: 0x04001442 RID: 5186
		private static readonly IntPtr NativeFieldInfoPtr_tooltip;

		// Token: 0x04001443 RID: 5187
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04001444 RID: 5188
		private static readonly IntPtr NativeFieldInfoPtr_underlyingType;

		// Token: 0x04001445 RID: 5189
		private static readonly IntPtr NativeFieldInfoPtr_unsigned;

		// Token: 0x04001446 RID: 5190
		private static readonly IntPtr NativeFieldInfoPtr_serializable;
	}
}
