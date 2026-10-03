using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x0200081E RID: 2078
	public class CharacterCreatorMenu : MonoBehaviour
	{
		// Token: 0x0600CA05 RID: 51717 RVA: 0x0032F560 File Offset: 0x0032D760
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreatorMenu()
		{
			Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "CharacterCreatorMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr);
			CharacterCreatorMenu.NativeFieldInfoPtr_Windows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "Windows");
			CharacterCreatorMenu.NativeFieldInfoPtr_CategoryLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "CategoryLabel");
			CharacterCreatorMenu.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "BackButton");
			CharacterCreatorMenu.NativeFieldInfoPtr_NextButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "NextButton");
			CharacterCreatorMenu.NativeFieldInfoPtr__cyclerController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "_cyclerController");
			CharacterCreatorMenu.NativeFieldInfoPtr__screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "_screen");
			CharacterCreatorMenu.NativeFieldInfoPtr_openWindowIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "openWindowIndex");
			CharacterCreatorMenu.NativeFieldInfoPtr_openWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "openWindow");
			CharacterCreatorMenu.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, 100689361);
			CharacterCreatorMenu.NativeMethodInfoPtr_OpenWindow_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, 100689362);
			CharacterCreatorMenu.NativeMethodInfoPtr_HandleCycleEvent_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, 100689363);
			CharacterCreatorMenu.NativeMethodInfoPtr_Back_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, 100689364);
			CharacterCreatorMenu.NativeMethodInfoPtr_Next_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, 100689365);
			CharacterCreatorMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, 100689366);
		}

		// Token: 0x0600CA06 RID: 51718 RVA: 0x0032F6A8 File Offset: 0x0032D8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332040, XrefRangeEnd = 332069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA07 RID: 51719 RVA: 0x0032F6DC File Offset: 0x0032D8DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 332084, RefRangeEnd = 332088, XrefRangeStart = 332069, XrefRangeEnd = 332084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenWindow(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.NativeMethodInfoPtr_OpenWindow_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA08 RID: 51720 RVA: 0x0032F71C File Offset: 0x0032D91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332088, XrefRangeEnd = 332090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleCycleEvent(int dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.NativeMethodInfoPtr_HandleCycleEvent_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA09 RID: 51721 RVA: 0x0032F75C File Offset: 0x0032D95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332090, XrefRangeEnd = 332091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.NativeMethodInfoPtr_Back_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA0A RID: 51722 RVA: 0x0032F790 File Offset: 0x0032D990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332091, XrefRangeEnd = 332092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Next()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.NativeMethodInfoPtr_Next_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA0B RID: 51723 RVA: 0x0032F7C4 File Offset: 0x0032D9C4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreatorMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA0C RID: 51724 RVA: 0x0005FBFD File Offset: 0x0005DDFD
		public CharacterCreatorMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003D5D RID: 15709
		// (get) Token: 0x0600CA0D RID: 51725 RVA: 0x0032F800 File Offset: 0x0032DA00
		// (set) Token: 0x0600CA0E RID: 51726 RVA: 0x0005FC06 File Offset: 0x0005DE06
		public unsafe Il2CppReferenceArray<CharacterCreatorMenu.Window> Windows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_Windows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterCreatorMenu.Window>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_Windows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D5E RID: 15710
		// (get) Token: 0x0600CA0F RID: 51727 RVA: 0x0032F830 File Offset: 0x0032DA30
		// (set) Token: 0x0600CA10 RID: 51728 RVA: 0x0005FC25 File Offset: 0x0005DE25
		public unsafe TextMeshProUGUI CategoryLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_CategoryLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_CategoryLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D5F RID: 15711
		// (get) Token: 0x0600CA11 RID: 51729 RVA: 0x0032F860 File Offset: 0x0032DA60
		// (set) Token: 0x0600CA12 RID: 51730 RVA: 0x0005FC44 File Offset: 0x0005DE44
		public unsafe Button BackButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_BackButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D60 RID: 15712
		// (get) Token: 0x0600CA13 RID: 51731 RVA: 0x0032F890 File Offset: 0x0032DA90
		// (set) Token: 0x0600CA14 RID: 51732 RVA: 0x0005FC63 File Offset: 0x0005DE63
		public unsafe Button NextButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_NextButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_NextButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D61 RID: 15713
		// (get) Token: 0x0600CA15 RID: 51733 RVA: 0x0032F8C0 File Offset: 0x0032DAC0
		// (set) Token: 0x0600CA16 RID: 51734 RVA: 0x0005FC82 File Offset: 0x0005DE82
		public unsafe CyclerController _cyclerController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr__cyclerController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CyclerController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr__cyclerController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D62 RID: 15714
		// (get) Token: 0x0600CA17 RID: 51735 RVA: 0x0032F8F0 File Offset: 0x0032DAF0
		// (set) Token: 0x0600CA18 RID: 51736 RVA: 0x0005FCA1 File Offset: 0x0005DEA1
		public unsafe UIScreen _screen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr__screen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr__screen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D63 RID: 15715
		// (get) Token: 0x0600CA19 RID: 51737 RVA: 0x0032F920 File Offset: 0x0032DB20
		// (set) Token: 0x0600CA1A RID: 51738 RVA: 0x0005FCC0 File Offset: 0x0005DEC0
		public unsafe int openWindowIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_openWindowIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_openWindowIndex)) = value;
			}
		}

		// Token: 0x17003D64 RID: 15716
		// (get) Token: 0x0600CA1B RID: 51739 RVA: 0x0032F948 File Offset: 0x0032DB48
		// (set) Token: 0x0600CA1C RID: 51740 RVA: 0x0005FCDB File Offset: 0x0005DEDB
		public unsafe CharacterCreatorMenu.Window openWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_openWindow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCreatorMenu.Window>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_openWindow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008997 RID: 35223
		private static readonly IntPtr NativeFieldInfoPtr_Windows;

		// Token: 0x04008998 RID: 35224
		private static readonly IntPtr NativeFieldInfoPtr_CategoryLabel;

		// Token: 0x04008999 RID: 35225
		private static readonly IntPtr NativeFieldInfoPtr_BackButton;

		// Token: 0x0400899A RID: 35226
		private static readonly IntPtr NativeFieldInfoPtr_NextButton;

		// Token: 0x0400899B RID: 35227
		private static readonly IntPtr NativeFieldInfoPtr__cyclerController;

		// Token: 0x0400899C RID: 35228
		private static readonly IntPtr NativeFieldInfoPtr__screen;

		// Token: 0x0400899D RID: 35229
		private static readonly IntPtr NativeFieldInfoPtr_openWindowIndex;

		// Token: 0x0400899E RID: 35230
		private static readonly IntPtr NativeFieldInfoPtr_openWindow;

		// Token: 0x0400899F RID: 35231
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040089A0 RID: 35232
		private static readonly IntPtr NativeMethodInfoPtr_OpenWindow_Public_Void_Int32_0;

		// Token: 0x040089A1 RID: 35233
		private static readonly IntPtr NativeMethodInfoPtr_HandleCycleEvent_Private_Void_Int32_0;

		// Token: 0x040089A2 RID: 35234
		private static readonly IntPtr NativeMethodInfoPtr_Back_Private_Void_0;

		// Token: 0x040089A3 RID: 35235
		private static readonly IntPtr NativeMethodInfoPtr_Next_Private_Void_0;

		// Token: 0x040089A4 RID: 35236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D7E RID: 3454
		[Serializable]
		public class Window : Il2CppSystem.Object
		{
			// Token: 0x0600FBDD RID: 64477 RVA: 0x003C1AC4 File Offset: 0x003BFCC4
			// Note: this type is marked as 'beforefieldinit'.
			static Window()
			{
				Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "Window");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr);
				CharacterCreatorMenu.Window.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr, "Name");
				CharacterCreatorMenu.Window.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr, "Container");
				CharacterCreatorMenu.Window.NativeFieldInfoPtr_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr, "Panel");
				CharacterCreatorMenu.Window.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr, 100689367);
				CharacterCreatorMenu.Window.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr, 100689368);
				CharacterCreatorMenu.Window.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr, 100689369);
			}

			// Token: 0x0600FBDE RID: 64478 RVA: 0x003C1B68 File Offset: 0x003BFD68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332034, XrefRangeEnd = 332037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Open()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.Window.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FBDF RID: 64479 RVA: 0x003C1B9C File Offset: 0x003BFD9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332037, XrefRangeEnd = 332040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Close()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.Window.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FBE0 RID: 64480 RVA: 0x003C1BD0 File Offset: 0x003BFDD0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Window() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.Window.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FBE1 RID: 64481 RVA: 0x0007737A File Offset: 0x0007557A
			public Window(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C8B RID: 19595
			// (get) Token: 0x0600FBE2 RID: 64482 RVA: 0x003C1C0C File Offset: 0x003BFE0C
			// (set) Token: 0x0600FBE3 RID: 64483 RVA: 0x00077383 File Offset: 0x00075583
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.Window.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.Window.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004C8C RID: 19596
			// (get) Token: 0x0600FBE4 RID: 64484 RVA: 0x003C1C34 File Offset: 0x003BFE34
			// (set) Token: 0x0600FBE5 RID: 64485 RVA: 0x000773A2 File Offset: 0x000755A2
			public unsafe RectTransform Container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.Window.NativeFieldInfoPtr_Container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.Window.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C8D RID: 19597
			// (get) Token: 0x0600FBE6 RID: 64486 RVA: 0x003C1C64 File Offset: 0x003BFE64
			// (set) Token: 0x0600FBE7 RID: 64487 RVA: 0x000773C1 File Offset: 0x000755C1
			public unsafe UIPanel Panel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.Window.NativeFieldInfoPtr_Panel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.Window.NativeFieldInfoPtr_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A9E5 RID: 43493
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x0400A9E6 RID: 43494
			private static readonly IntPtr NativeFieldInfoPtr_Container;

			// Token: 0x0400A9E7 RID: 43495
			private static readonly IntPtr NativeFieldInfoPtr_Panel;

			// Token: 0x0400A9E8 RID: 43496
			private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

			// Token: 0x0400A9E9 RID: 43497
			private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

			// Token: 0x0400A9EA RID: 43498
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
