using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000745 RID: 1861
	public class NotificationsManager : Singleton<NotificationsManager>
	{
		// Token: 0x0600B4AE RID: 46254 RVA: 0x002EEAFC File Offset: 0x002ECCFC
		// Note: this type is marked as 'beforefieldinit'.
		static NotificationsManager()
		{
			Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "NotificationsManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr);
			NotificationsManager.NativeFieldInfoPtr_MAX_NOTIFICATIONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, "MAX_NOTIFICATIONS");
			NotificationsManager.NativeFieldInfoPtr_EntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, "EntryContainer");
			NotificationsManager.NativeFieldInfoPtr_Sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, "Sound");
			NotificationsManager.NativeFieldInfoPtr_NotificationPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, "NotificationPrefab");
			NotificationsManager.NativeFieldInfoPtr_coroutines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, "coroutines");
			NotificationsManager.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, "entries");
			NotificationsManager.NativeMethodInfoPtr_SendNotification_Public_Void_String_String_Sprite_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, 100686971);
			NotificationsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, 100686972);
		}

		// Token: 0x0600B4AF RID: 46255 RVA: 0x002EEBCC File Offset: 0x002ECDCC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 304416, RefRangeEnd = 304424, XrefRangeStart = 304339, XrefRangeEnd = 304416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendNotification(string title, string subtitle, Sprite icon, float duration = 5f, bool playSound = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subtitle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(icon);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playSound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.NativeMethodInfoPtr_SendNotification_Public_Void_String_String_Sprite_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4B0 RID: 46256 RVA: 0x002EEC50 File Offset: 0x002ECE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304424, XrefRangeEnd = 304441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotificationsManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4B1 RID: 46257 RVA: 0x000538DD File Offset: 0x00051ADD
		public NotificationsManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003675 RID: 13941
		// (get) Token: 0x0600B4B2 RID: 46258 RVA: 0x002EEC8C File Offset: 0x002ECE8C
		// (set) Token: 0x0600B4B3 RID: 46259 RVA: 0x000538E6 File Offset: 0x00051AE6
		public unsafe static int MAX_NOTIFICATIONS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NotificationsManager.NativeFieldInfoPtr_MAX_NOTIFICATIONS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NotificationsManager.NativeFieldInfoPtr_MAX_NOTIFICATIONS, (void*)(&value));
			}
		}

		// Token: 0x17003676 RID: 13942
		// (get) Token: 0x0600B4B4 RID: 46260 RVA: 0x002EECA8 File Offset: 0x002ECEA8
		// (set) Token: 0x0600B4B5 RID: 46261 RVA: 0x000538F4 File Offset: 0x00051AF4
		public unsafe RectTransform EntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_EntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_EntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003677 RID: 13943
		// (get) Token: 0x0600B4B6 RID: 46262 RVA: 0x002EECD8 File Offset: 0x002ECED8
		// (set) Token: 0x0600B4B7 RID: 46263 RVA: 0x00053913 File Offset: 0x00051B13
		public unsafe AudioSourceController Sound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_Sound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_Sound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003678 RID: 13944
		// (get) Token: 0x0600B4B8 RID: 46264 RVA: 0x002EED08 File Offset: 0x002ECF08
		// (set) Token: 0x0600B4B9 RID: 46265 RVA: 0x00053932 File Offset: 0x00051B32
		public unsafe GameObject NotificationPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_NotificationPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_NotificationPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003679 RID: 13945
		// (get) Token: 0x0600B4BA RID: 46266 RVA: 0x002EED38 File Offset: 0x002ECF38
		// (set) Token: 0x0600B4BB RID: 46267 RVA: 0x00053951 File Offset: 0x00051B51
		public unsafe Dictionary<RectTransform, Coroutine> coroutines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_coroutines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<RectTransform, Coroutine>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_coroutines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700367A RID: 13946
		// (get) Token: 0x0600B4BC RID: 46268 RVA: 0x002EED68 File Offset: 0x002ECF68
		// (set) Token: 0x0600B4BD RID: 46269 RVA: 0x00053970 File Offset: 0x00051B70
		public unsafe List<RectTransform> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007C47 RID: 31815
		private static readonly IntPtr NativeFieldInfoPtr_MAX_NOTIFICATIONS;

		// Token: 0x04007C48 RID: 31816
		private static readonly IntPtr NativeFieldInfoPtr_EntryContainer;

		// Token: 0x04007C49 RID: 31817
		private static readonly IntPtr NativeFieldInfoPtr_Sound;

		// Token: 0x04007C4A RID: 31818
		private static readonly IntPtr NativeFieldInfoPtr_NotificationPrefab;

		// Token: 0x04007C4B RID: 31819
		private static readonly IntPtr NativeFieldInfoPtr_coroutines;

		// Token: 0x04007C4C RID: 31820
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x04007C4D RID: 31821
		private static readonly IntPtr NativeMethodInfoPtr_SendNotification_Public_Void_String_String_Sprite_Single_Boolean_0;

		// Token: 0x04007C4E RID: 31822
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CD8 RID: 3288
		[ObfuscatedName("ScheduleOne.UI.NotificationsManager+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F584 RID: 62852 RVA: 0x003AF518 File Offset: 0x003AD718
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotificationsManager>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0>.NativeClassPtr);
				NotificationsManager.__c__DisplayClass6_0.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0>.NativeClassPtr, "container");
				NotificationsManager.__c__DisplayClass6_0.NativeFieldInfoPtr_startX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0>.NativeClassPtr, "startX");
				NotificationsManager.__c__DisplayClass6_0.NativeFieldInfoPtr_endX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0>.NativeClassPtr, "endX");
				NotificationsManager.__c__DisplayClass6_0.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0>.NativeClassPtr, "lerpTime");
				NotificationsManager.__c__DisplayClass6_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0>.NativeClassPtr, "duration");
				NotificationsManager.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				NotificationsManager.__c__DisplayClass6_0.NativeFieldInfoPtr_newEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0>.NativeClassPtr, "newEntry");
				NotificationsManager.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0>.NativeClassPtr, 100686973);
				NotificationsManager.__c__DisplayClass6_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0>.NativeClassPtr, 100686974);
			}

			// Token: 0x0600F585 RID: 62853 RVA: 0x003AF5F8 File Offset: 0x003AD7F8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F586 RID: 62854 RVA: 0x003AF634 File Offset: 0x003AD834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304334, XrefRangeEnd = 304339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass6_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F587 RID: 62855 RVA: 0x000740C8 File Offset: 0x000722C8
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A97 RID: 19095
			// (get) Token: 0x0600F588 RID: 62856 RVA: 0x003AF674 File Offset: 0x003AD874
			// (set) Token: 0x0600F589 RID: 62857 RVA: 0x000740D1 File Offset: 0x000722D1
			public unsafe RectTransform container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass6_0.NativeFieldInfoPtr_container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass6_0.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A98 RID: 19096
			// (get) Token: 0x0600F58A RID: 62858 RVA: 0x003AF6A4 File Offset: 0x003AD8A4
			// (set) Token: 0x0600F58B RID: 62859 RVA: 0x000740F0 File Offset: 0x000722F0
			public unsafe float startX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass6_0.NativeFieldInfoPtr_startX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass6_0.NativeFieldInfoPtr_startX)) = value;
				}
			}

			// Token: 0x17004A99 RID: 19097
			// (get) Token: 0x0600F58C RID: 62860 RVA: 0x003AF6CC File Offset: 0x003AD8CC
			// (set) Token: 0x0600F58D RID: 62861 RVA: 0x0007410B File Offset: 0x0007230B
			public unsafe float endX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass6_0.NativeFieldInfoPtr_endX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass6_0.NativeFieldInfoPtr_endX)) = value;
				}
			}

			// Token: 0x17004A9A RID: 19098
			// (get) Token: 0x0600F58E RID: 62862 RVA: 0x003AF6F4 File Offset: 0x003AD8F4
			// (set) Token: 0x0600F58F RID: 62863 RVA: 0x00074126 File Offset: 0x00072326
			public unsafe float lerpTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass6_0.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass6_0.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x17004A9B RID: 19099
			// (get) Token: 0x0600F590 RID: 62864 RVA: 0x003AF71C File Offset: 0x003AD91C
			// (set) Token: 0x0600F591 RID: 62865 RVA: 0x00074141 File Offset: 0x00072341
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass6_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass6_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x17004A9C RID: 19100
			// (get) Token: 0x0600F592 RID: 62866 RVA: 0x003AF744 File Offset: 0x003AD944
			// (set) Token: 0x0600F593 RID: 62867 RVA: 0x0007415C File Offset: 0x0007235C
			public unsafe NotificationsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NotificationsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A9D RID: 19101
			// (get) Token: 0x0600F594 RID: 62868 RVA: 0x003AF774 File Offset: 0x003AD974
			// (set) Token: 0x0600F595 RID: 62869 RVA: 0x0007417B File Offset: 0x0007237B
			public unsafe RectTransform newEntry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass6_0.NativeFieldInfoPtr_newEntry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass6_0.NativeFieldInfoPtr_newEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A617 RID: 42519
			private static readonly IntPtr NativeFieldInfoPtr_container;

			// Token: 0x0400A618 RID: 42520
			private static readonly IntPtr NativeFieldInfoPtr_startX;

			// Token: 0x0400A619 RID: 42521
			private static readonly IntPtr NativeFieldInfoPtr_endX;

			// Token: 0x0400A61A RID: 42522
			private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x0400A61B RID: 42523
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x0400A61C RID: 42524
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A61D RID: 42525
			private static readonly IntPtr NativeFieldInfoPtr_newEntry;

			// Token: 0x0400A61E RID: 42526
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A61F RID: 42527
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000E0D RID: 3597
			[ObfuscatedName("ScheduleOne.UI.NotificationsManager+<>c__DisplayClass6_0+<<SendNotification>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06010328 RID: 66344 RVA: 0x003D71D0 File Offset: 0x003D53D0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0>.NativeClassPtr, "<<SendNotification>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
					NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100686975);
					NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100686976);
					NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100686977);
					NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100686978);
					NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100686979);
					NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100686980);
				}

				// Token: 0x06010329 RID: 66345 RVA: 0x003D72C4 File Offset: 0x003D54C4
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601032A RID: 66346 RVA: 0x003D730C File Offset: 0x003D550C
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601032B RID: 66347 RVA: 0x003D7340 File Offset: 0x003D5540
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304314, XrefRangeEnd = 304329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004F2D RID: 20269
				// (get) Token: 0x0601032C RID: 66348 RVA: 0x003D737C File Offset: 0x003D557C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601032D RID: 66349 RVA: 0x003D73BC File Offset: 0x003D55BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304329, XrefRangeEnd = 304334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004F2E RID: 20270
				// (get) Token: 0x0601032E RID: 66350 RVA: 0x003D73F0 File Offset: 0x003D55F0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601032F RID: 66351 RVA: 0x0007AE2A File Offset: 0x0007902A
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004F29 RID: 20265
				// (get) Token: 0x06010330 RID: 66352 RVA: 0x003D7430 File Offset: 0x003D5630
				// (set) Token: 0x06010331 RID: 66353 RVA: 0x0007AE33 File Offset: 0x00079033
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004F2A RID: 20266
				// (get) Token: 0x06010332 RID: 66354 RVA: 0x003D7458 File Offset: 0x003D5658
				// (set) Token: 0x06010333 RID: 66355 RVA: 0x0007AE4E File Offset: 0x0007904E
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F2B RID: 20267
				// (get) Token: 0x06010334 RID: 66356 RVA: 0x003D7488 File Offset: 0x003D5688
				// (set) Token: 0x06010335 RID: 66357 RVA: 0x0007AE6D File Offset: 0x0007906D
				public unsafe NotificationsManager.__c__DisplayClass6_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<NotificationsManager.__c__DisplayClass6_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F2C RID: 20268
				// (get) Token: 0x06010336 RID: 66358 RVA: 0x003D74B8 File Offset: 0x003D56B8
				// (set) Token: 0x06010337 RID: 66359 RVA: 0x0007AE8C File Offset: 0x0007908C
				public unsafe float _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsManager.__c__DisplayClass6_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x0400AE6B RID: 44651
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AE6C RID: 44652
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AE6D RID: 44653
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AE6E RID: 44654
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x0400AE6F RID: 44655
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AE70 RID: 44656
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AE71 RID: 44657
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AE72 RID: 44658
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AE73 RID: 44659
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AE74 RID: 44660
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
