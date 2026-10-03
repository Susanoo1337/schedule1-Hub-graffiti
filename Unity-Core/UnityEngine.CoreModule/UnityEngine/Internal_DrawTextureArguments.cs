using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000A1 RID: 161
	public sealed class Internal_DrawTextureArguments : ValueType
	{
		// Token: 0x060009B4 RID: 2484 RVA: 0x00035FC8 File Offset: 0x000341C8
		// Note: this type is marked as 'beforefieldinit'.
		static Internal_DrawTextureArguments()
		{
			Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Internal_DrawTextureArguments");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr);
			Internal_DrawTextureArguments.NativeFieldInfoPtr_screenRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "screenRect");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_sourceRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "sourceRect");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_leftBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "leftBorder");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_rightBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "rightBorder");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_topBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "topBorder");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_bottomBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "bottomBorder");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_leftBorderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "leftBorderColor");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_rightBorderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "rightBorderColor");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_topBorderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "topBorderColor");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_bottomBorderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "bottomBorderColor");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "color");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_borderWidths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "borderWidths");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_cornerRadiuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "cornerRadiuses");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_smoothCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "smoothCorners");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_pass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "pass");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "texture");
			Internal_DrawTextureArguments.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr, "mat");
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0000626C File Offset: 0x0000446C
		public Internal_DrawTextureArguments(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00006275 File Offset: 0x00004475
		public Internal_DrawTextureArguments() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Internal_DrawTextureArguments>.NativeClassPtr))
		{
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x0003614C File Offset: 0x0003434C
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x00006287 File Offset: 0x00004487
		public unsafe Rect screenRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_screenRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_screenRect)) = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x00036174 File Offset: 0x00034374
		// (set) Token: 0x060009BA RID: 2490 RVA: 0x000062A2 File Offset: 0x000044A2
		public unsafe Rect sourceRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_sourceRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_sourceRect)) = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x0003619C File Offset: 0x0003439C
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x000062BD File Offset: 0x000044BD
		public unsafe int leftBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_leftBorder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_leftBorder)) = value;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x000361C4 File Offset: 0x000343C4
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x000062D8 File Offset: 0x000044D8
		public unsafe int rightBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_rightBorder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_rightBorder)) = value;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x000361EC File Offset: 0x000343EC
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x000062F3 File Offset: 0x000044F3
		public unsafe int topBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_topBorder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_topBorder)) = value;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x00036214 File Offset: 0x00034414
		// (set) Token: 0x060009C2 RID: 2498 RVA: 0x0000630E File Offset: 0x0000450E
		public unsafe int bottomBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_bottomBorder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_bottomBorder)) = value;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x0003623C File Offset: 0x0003443C
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x00006329 File Offset: 0x00004529
		public unsafe Color leftBorderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_leftBorderColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_leftBorderColor)) = value;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x00036264 File Offset: 0x00034464
		// (set) Token: 0x060009C6 RID: 2502 RVA: 0x00006344 File Offset: 0x00004544
		public unsafe Color rightBorderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_rightBorderColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_rightBorderColor)) = value;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x0003628C File Offset: 0x0003448C
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x0000635F File Offset: 0x0000455F
		public unsafe Color topBorderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_topBorderColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_topBorderColor)) = value;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x000362B4 File Offset: 0x000344B4
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x0000637A File Offset: 0x0000457A
		public unsafe Color bottomBorderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_bottomBorderColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_bottomBorderColor)) = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x000362DC File Offset: 0x000344DC
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x00006395 File Offset: 0x00004595
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x00036304 File Offset: 0x00034504
		// (set) Token: 0x060009CE RID: 2510 RVA: 0x000063B0 File Offset: 0x000045B0
		public unsafe Vector4 borderWidths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_borderWidths);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_borderWidths)) = value;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x0003632C File Offset: 0x0003452C
		// (set) Token: 0x060009D0 RID: 2512 RVA: 0x000063CB File Offset: 0x000045CB
		public unsafe Vector4 cornerRadiuses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_cornerRadiuses);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_cornerRadiuses)) = value;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x00036354 File Offset: 0x00034554
		// (set) Token: 0x060009D2 RID: 2514 RVA: 0x000063E6 File Offset: 0x000045E6
		public unsafe bool smoothCorners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_smoothCorners);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_smoothCorners)) = value;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x0003637C File Offset: 0x0003457C
		// (set) Token: 0x060009D4 RID: 2516 RVA: 0x00006401 File Offset: 0x00004601
		public unsafe int pass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_pass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_pass)) = value;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x000363A4 File Offset: 0x000345A4
		// (set) Token: 0x060009D6 RID: 2518 RVA: 0x0000641C File Offset: 0x0000461C
		public unsafe Texture texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x000363D4 File Offset: 0x000345D4
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x0000643B File Offset: 0x0000463B
		public unsafe Material mat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_mat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Internal_DrawTextureArguments.NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeFieldInfoPtr_screenRect;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeFieldInfoPtr_sourceRect;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeFieldInfoPtr_leftBorder;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeFieldInfoPtr_rightBorder;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeFieldInfoPtr_topBorder;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeFieldInfoPtr_bottomBorder;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeFieldInfoPtr_leftBorderColor;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeFieldInfoPtr_rightBorderColor;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeFieldInfoPtr_topBorderColor;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeFieldInfoPtr_bottomBorderColor;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeFieldInfoPtr_borderWidths;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeFieldInfoPtr_cornerRadiuses;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeFieldInfoPtr_smoothCorners;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeFieldInfoPtr_pass;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeFieldInfoPtr_texture;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeFieldInfoPtr_mat;
	}
}
