using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.EntityFramework
{
	// Token: 0x02000375 RID: 885
	public class IProceduralTileContainer : Il2CppObjectBase
	{
		// Token: 0x06004C16 RID: 19478 RVA: 0x000249B4 File Offset: 0x00022BB4
		// Note: this type is marked as 'beforefieldinit'.
		static IProceduralTileContainer()
		{
			Il2CppClassPointerStore<IProceduralTileContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.EntityFramework", "IProceduralTileContainer");
			IProceduralTileContainer.NativeMethodInfoPtr_get_ProceduralTiles_Public_Abstract_Virtual_New_get_List_1_ProceduralTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IProceduralTileContainer>.NativeClassPtr, 100673104);
		}

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x06004C17 RID: 19479 RVA: 0x0017F36C File Offset: 0x0017D56C
		public unsafe virtual List<ProceduralTile> ProceduralTiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IProceduralTileContainer.NativeMethodInfoPtr_get_ProceduralTiles_Public_Abstract_Virtual_New_get_List_1_ProceduralTile_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProceduralTile>>(intPtr3) : null;
			}
		}

		// Token: 0x06004C18 RID: 19480 RVA: 0x000249E3 File Offset: 0x00022BE3
		public IProceduralTileContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040033F2 RID: 13298
		private static readonly IntPtr NativeMethodInfoPtr_get_ProceduralTiles_Public_Abstract_Virtual_New_get_List_1_ProceduralTile_0;
	}
}
