using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x020001C2 RID: 450
	[StructLayout(2)]
	public struct PreUpdate
	{
		// Token: 0x060020A1 RID: 8353 RVA: 0x0000F145 File Offset: 0x0000D345
		// Note: this type is marked as 'beforefieldinit'.
		static PreUpdate()
		{
			Il2CppClassPointerStore<PreUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "PreUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr);
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x0000F16A File Offset: 0x0000D36A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, ref this));
		}

		// Token: 0x02000A69 RID: 2665
		[StructLayout(2)]
		public struct PhysicsUpdate
		{
			// Token: 0x06003D9F RID: 15775 RVA: 0x00017378 File Offset: 0x00015578
			// Note: this type is marked as 'beforefieldinit'.
			static PhysicsUpdate()
			{
				Il2CppClassPointerStore<PreUpdate.PhysicsUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "PhysicsUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.PhysicsUpdate>.NativeClassPtr);
			}

			// Token: 0x06003DA0 RID: 15776 RVA: 0x00017398 File Offset: 0x00015598
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.PhysicsUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A6A RID: 2666
		[StructLayout(2)]
		public struct Physics2DUpdate
		{
			// Token: 0x06003DA1 RID: 15777 RVA: 0x000173AA File Offset: 0x000155AA
			// Note: this type is marked as 'beforefieldinit'.
			static Physics2DUpdate()
			{
				Il2CppClassPointerStore<PreUpdate.Physics2DUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "Physics2DUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.Physics2DUpdate>.NativeClassPtr);
			}

			// Token: 0x06003DA2 RID: 15778 RVA: 0x000173CA File Offset: 0x000155CA
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.Physics2DUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A6B RID: 2667
		[StructLayout(2)]
		public struct PhysicsClothUpdate
		{
			// Token: 0x06003DA3 RID: 15779 RVA: 0x000173DC File Offset: 0x000155DC
			// Note: this type is marked as 'beforefieldinit'.
			static PhysicsClothUpdate()
			{
				Il2CppClassPointerStore<PreUpdate.PhysicsClothUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "PhysicsClothUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.PhysicsClothUpdate>.NativeClassPtr);
			}

			// Token: 0x06003DA4 RID: 15780 RVA: 0x000173FC File Offset: 0x000155FC
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.PhysicsClothUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A6C RID: 2668
		[StructLayout(2)]
		public struct CheckTexFieldInput
		{
			// Token: 0x06003DA5 RID: 15781 RVA: 0x0001740E File Offset: 0x0001560E
			// Note: this type is marked as 'beforefieldinit'.
			static CheckTexFieldInput()
			{
				Il2CppClassPointerStore<PreUpdate.CheckTexFieldInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "CheckTexFieldInput");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.CheckTexFieldInput>.NativeClassPtr);
			}

			// Token: 0x06003DA6 RID: 15782 RVA: 0x0001742E File Offset: 0x0001562E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.CheckTexFieldInput>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A6D RID: 2669
		[StructLayout(2)]
		public struct IMGUISendQueuedEvents
		{
			// Token: 0x06003DA7 RID: 15783 RVA: 0x00017440 File Offset: 0x00015640
			// Note: this type is marked as 'beforefieldinit'.
			static IMGUISendQueuedEvents()
			{
				Il2CppClassPointerStore<PreUpdate.IMGUISendQueuedEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "IMGUISendQueuedEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.IMGUISendQueuedEvents>.NativeClassPtr);
			}

			// Token: 0x06003DA8 RID: 15784 RVA: 0x00017460 File Offset: 0x00015660
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.IMGUISendQueuedEvents>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A6E RID: 2670
		[StructLayout(2)]
		public struct SendMouseEvents
		{
			// Token: 0x06003DA9 RID: 15785 RVA: 0x00017472 File Offset: 0x00015672
			// Note: this type is marked as 'beforefieldinit'.
			static SendMouseEvents()
			{
				Il2CppClassPointerStore<PreUpdate.SendMouseEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "SendMouseEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.SendMouseEvents>.NativeClassPtr);
			}

			// Token: 0x06003DAA RID: 15786 RVA: 0x00017492 File Offset: 0x00015692
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.SendMouseEvents>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A6F RID: 2671
		[StructLayout(2)]
		public struct AIUpdate
		{
			// Token: 0x06003DAB RID: 15787 RVA: 0x000174A4 File Offset: 0x000156A4
			// Note: this type is marked as 'beforefieldinit'.
			static AIUpdate()
			{
				Il2CppClassPointerStore<PreUpdate.AIUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "AIUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.AIUpdate>.NativeClassPtr);
			}

			// Token: 0x06003DAC RID: 15788 RVA: 0x000174C4 File Offset: 0x000156C4
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.AIUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A70 RID: 2672
		[StructLayout(2)]
		public struct WindUpdate
		{
			// Token: 0x06003DAD RID: 15789 RVA: 0x000174D6 File Offset: 0x000156D6
			// Note: this type is marked as 'beforefieldinit'.
			static WindUpdate()
			{
				Il2CppClassPointerStore<PreUpdate.WindUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "WindUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.WindUpdate>.NativeClassPtr);
			}

			// Token: 0x06003DAE RID: 15790 RVA: 0x000174F6 File Offset: 0x000156F6
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.WindUpdate>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A71 RID: 2673
		[StructLayout(2)]
		public struct UpdateVideo
		{
			// Token: 0x06003DAF RID: 15791 RVA: 0x00017508 File Offset: 0x00015708
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateVideo()
			{
				Il2CppClassPointerStore<PreUpdate.UpdateVideo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "UpdateVideo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.UpdateVideo>.NativeClassPtr);
			}

			// Token: 0x06003DB0 RID: 15792 RVA: 0x00017528 File Offset: 0x00015728
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.UpdateVideo>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000A72 RID: 2674
		[StructLayout(2)]
		public struct NewInputUpdate
		{
			// Token: 0x06003DB1 RID: 15793 RVA: 0x0001753A File Offset: 0x0001573A
			// Note: this type is marked as 'beforefieldinit'.
			static NewInputUpdate()
			{
				Il2CppClassPointerStore<PreUpdate.NewInputUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "NewInputUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate.NewInputUpdate>.NativeClassPtr);
			}

			// Token: 0x06003DB2 RID: 15794 RVA: 0x0001755A File Offset: 0x0001575A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate.NewInputUpdate>.NativeClassPtr, ref this));
			}
		}
	}
}
