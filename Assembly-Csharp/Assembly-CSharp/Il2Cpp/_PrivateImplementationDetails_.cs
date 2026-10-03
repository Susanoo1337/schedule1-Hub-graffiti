using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000845 RID: 2117
	[ObfuscatedName("<PrivateImplementationDetails>")]
	public sealed class _PrivateImplementationDetails_ : Object
	{
		// Token: 0x0600CE42 RID: 52802 RVA: 0x0033CCF8 File Offset: 0x0033AEF8
		// Note: this type is marked as 'beforefieldinit'.
		static _PrivateImplementationDetails_()
		{
			Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "<PrivateImplementationDetails>");
			_PrivateImplementationDetails_.NativeFieldInfoPtr__0A0EC6D4742068B4D88C6145B8224EF1DC240C8A305CDFC50C3AAF9121E6875D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "0A0EC6D4742068B4D88C6145B8224EF1DC240C8A305CDFC50C3AAF9121E6875D");
			_PrivateImplementationDetails_.NativeFieldInfoPtr__25B47F67A702E9A42CCCA33C60CD5692FF6324DF631931A3395DE22722C2E32A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "25B47F67A702E9A42CCCA33C60CD5692FF6324DF631931A3395DE22722C2E32A");
			_PrivateImplementationDetails_.NativeFieldInfoPtr__391C790A82C9FF8530A643C6E15299EB894534F79E38378A202F608383460A94 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "391C790A82C9FF8530A643C6E15299EB894534F79E38378A202F608383460A94");
			_PrivateImplementationDetails_.NativeFieldInfoPtr__47AE6576DFB191228A85E1CDEFC179FDD55C57A29E49BBEC089424F2E25E0DB9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "47AE6576DFB191228A85E1CDEFC179FDD55C57A29E49BBEC089424F2E25E0DB9");
			_PrivateImplementationDetails_.NativeFieldInfoPtr__5DBD49C4016CBE51C0048D71FC5FE2D5DD89EF577D1E135E71749D588A3A8657 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "5DBD49C4016CBE51C0048D71FC5FE2D5DD89EF577D1E135E71749D588A3A8657");
			_PrivateImplementationDetails_.NativeFieldInfoPtr__94AC9E3B5D2EA6FEB03FFE0856EF4600428609A1F4EF30123CB4E73B6CCB8CD5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "94AC9E3B5D2EA6FEB03FFE0856EF4600428609A1F4EF30123CB4E73B6CCB8CD5");
			_PrivateImplementationDetails_.NativeFieldInfoPtr__9A2689BE663AB3D504CCED78A84BD0EFCC3B3FC9FEB7BBD3994346E3CF839714 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "9A2689BE663AB3D504CCED78A84BD0EFCC3B3FC9FEB7BBD3994346E3CF839714");
			_PrivateImplementationDetails_.NativeFieldInfoPtr__9DA4162EA99B4798E939E3F6921620101CA0DD4619C45124BFAE0089D39ABC2C = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "9DA4162EA99B4798E939E3F6921620101CA0DD4619C45124BFAE0089D39ABC2C");
			_PrivateImplementationDetails_.NativeFieldInfoPtr_C0CC9FEDCEBB7BCD0CCC17C932D1E4E01ED5D967405854219C43EA9BDECD468E = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "C0CC9FEDCEBB7BCD0CCC17C932D1E4E01ED5D967405854219C43EA9BDECD468E");
			_PrivateImplementationDetails_.NativeFieldInfoPtr_CB905ABE3A65F90015E71BBAE44A0992AC4097FC01B222EAE0775D782A894045 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "CB905ABE3A65F90015E71BBAE44A0992AC4097FC01B222EAE0775D782A894045");
			_PrivateImplementationDetails_.NativeFieldInfoPtr_F186F2262AE48F2AA4F90C9A6B35913B0F6B0B895423B6267252259BFD357D3B = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "F186F2262AE48F2AA4F90C9A6B35913B0F6B0B895423B6267252259BFD357D3B");
			_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, 100689843);
		}

		// Token: 0x0600CE43 RID: 52803 RVA: 0x0033CE10 File Offset: 0x0033B010
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 64704, RefRangeEnd = 64731, XrefRangeStart = 64704, XrefRangeEnd = 64731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ComputeStringHash(string s)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CE44 RID: 52804 RVA: 0x0006201C File Offset: 0x0006021C
		public _PrivateImplementationDetails_(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003EB7 RID: 16055
		// (get) Token: 0x0600CE45 RID: 52805 RVA: 0x0033CE54 File Offset: 0x0033B054
		// (set) Token: 0x0600CE46 RID: 52806 RVA: 0x00062025 File Offset: 0x00060225
		public unsafe static _PrivateImplementationDetails_.ValueTypeNPrivateSealed0 _0A0EC6D4742068B4D88C6145B8224EF1DC240C8A305CDFC50C3AAF9121E6875D
		{
			get
			{
				_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 result;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__0A0EC6D4742068B4D88C6145B8224EF1DC240C8A305CDFC50C3AAF9121E6875D, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__0A0EC6D4742068B4D88C6145B8224EF1DC240C8A305CDFC50C3AAF9121E6875D, (void*)(&value));
			}
		}

		// Token: 0x17003EB8 RID: 16056
		// (get) Token: 0x0600CE47 RID: 52807 RVA: 0x0033CE70 File Offset: 0x0033B070
		// (set) Token: 0x0600CE48 RID: 52808 RVA: 0x00062033 File Offset: 0x00060233
		public unsafe static _PrivateImplementationDetails_.ValueTypeNPrivateSealed6 _25B47F67A702E9A42CCCA33C60CD5692FF6324DF631931A3395DE22722C2E32A
		{
			get
			{
				_PrivateImplementationDetails_.ValueTypeNPrivateSealed6 result;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__25B47F67A702E9A42CCCA33C60CD5692FF6324DF631931A3395DE22722C2E32A, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__25B47F67A702E9A42CCCA33C60CD5692FF6324DF631931A3395DE22722C2E32A, (void*)(&value));
			}
		}

		// Token: 0x17003EB9 RID: 16057
		// (get) Token: 0x0600CE49 RID: 52809 RVA: 0x0033CE8C File Offset: 0x0033B08C
		// (set) Token: 0x0600CE4A RID: 52810 RVA: 0x00062041 File Offset: 0x00060241
		public unsafe static _PrivateImplementationDetails_.ValueTypeNPrivateSealed2 _391C790A82C9FF8530A643C6E15299EB894534F79E38378A202F608383460A94
		{
			get
			{
				_PrivateImplementationDetails_.ValueTypeNPrivateSealed2 result;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__391C790A82C9FF8530A643C6E15299EB894534F79E38378A202F608383460A94, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__391C790A82C9FF8530A643C6E15299EB894534F79E38378A202F608383460A94, (void*)(&value));
			}
		}

		// Token: 0x17003EBA RID: 16058
		// (get) Token: 0x0600CE4B RID: 52811 RVA: 0x0033CEA8 File Offset: 0x0033B0A8
		// (set) Token: 0x0600CE4C RID: 52812 RVA: 0x0006204F File Offset: 0x0006024F
		public unsafe static _PrivateImplementationDetails_.ValueTypeNPrivateSealed0 _47AE6576DFB191228A85E1CDEFC179FDD55C57A29E49BBEC089424F2E25E0DB9
		{
			get
			{
				_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 result;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__47AE6576DFB191228A85E1CDEFC179FDD55C57A29E49BBEC089424F2E25E0DB9, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__47AE6576DFB191228A85E1CDEFC179FDD55C57A29E49BBEC089424F2E25E0DB9, (void*)(&value));
			}
		}

		// Token: 0x17003EBB RID: 16059
		// (get) Token: 0x0600CE4D RID: 52813 RVA: 0x0033CEC4 File Offset: 0x0033B0C4
		// (set) Token: 0x0600CE4E RID: 52814 RVA: 0x0006205D File Offset: 0x0006025D
		public unsafe static _PrivateImplementationDetails_.ValueTypeNPrivateSealed4 _5DBD49C4016CBE51C0048D71FC5FE2D5DD89EF577D1E135E71749D588A3A8657
		{
			get
			{
				_PrivateImplementationDetails_.ValueTypeNPrivateSealed4 result;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__5DBD49C4016CBE51C0048D71FC5FE2D5DD89EF577D1E135E71749D588A3A8657, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__5DBD49C4016CBE51C0048D71FC5FE2D5DD89EF577D1E135E71749D588A3A8657, (void*)(&value));
			}
		}

		// Token: 0x17003EBC RID: 16060
		// (get) Token: 0x0600CE4F RID: 52815 RVA: 0x0033CEE0 File Offset: 0x0033B0E0
		// (set) Token: 0x0600CE50 RID: 52816 RVA: 0x0006206B File Offset: 0x0006026B
		public unsafe static _PrivateImplementationDetails_.ValueTypeNPrivateSealed1 _94AC9E3B5D2EA6FEB03FFE0856EF4600428609A1F4EF30123CB4E73B6CCB8CD5
		{
			get
			{
				_PrivateImplementationDetails_.ValueTypeNPrivateSealed1 result;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__94AC9E3B5D2EA6FEB03FFE0856EF4600428609A1F4EF30123CB4E73B6CCB8CD5, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__94AC9E3B5D2EA6FEB03FFE0856EF4600428609A1F4EF30123CB4E73B6CCB8CD5, (void*)(&value));
			}
		}

		// Token: 0x17003EBD RID: 16061
		// (get) Token: 0x0600CE51 RID: 52817 RVA: 0x0033CEFC File Offset: 0x0033B0FC
		// (set) Token: 0x0600CE52 RID: 52818 RVA: 0x00062079 File Offset: 0x00060279
		public unsafe static _PrivateImplementationDetails_.ValueTypeNPrivateSealed5 _9A2689BE663AB3D504CCED78A84BD0EFCC3B3FC9FEB7BBD3994346E3CF839714
		{
			get
			{
				_PrivateImplementationDetails_.ValueTypeNPrivateSealed5 result;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__9A2689BE663AB3D504CCED78A84BD0EFCC3B3FC9FEB7BBD3994346E3CF839714, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__9A2689BE663AB3D504CCED78A84BD0EFCC3B3FC9FEB7BBD3994346E3CF839714, (void*)(&value));
			}
		}

		// Token: 0x17003EBE RID: 16062
		// (get) Token: 0x0600CE53 RID: 52819 RVA: 0x0033CF18 File Offset: 0x0033B118
		// (set) Token: 0x0600CE54 RID: 52820 RVA: 0x00062087 File Offset: 0x00060287
		public unsafe static int _9DA4162EA99B4798E939E3F6921620101CA0DD4619C45124BFAE0089D39ABC2C
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__9DA4162EA99B4798E939E3F6921620101CA0DD4619C45124BFAE0089D39ABC2C, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__9DA4162EA99B4798E939E3F6921620101CA0DD4619C45124BFAE0089D39ABC2C, (void*)(&value));
			}
		}

		// Token: 0x17003EBF RID: 16063
		// (get) Token: 0x0600CE55 RID: 52821 RVA: 0x0033CF34 File Offset: 0x0033B134
		// (set) Token: 0x0600CE56 RID: 52822 RVA: 0x00062095 File Offset: 0x00060295
		public unsafe static _PrivateImplementationDetails_.ValueTypeNPrivateSealed3 C0CC9FEDCEBB7BCD0CCC17C932D1E4E01ED5D967405854219C43EA9BDECD468E
		{
			get
			{
				_PrivateImplementationDetails_.ValueTypeNPrivateSealed3 result;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_C0CC9FEDCEBB7BCD0CCC17C932D1E4E01ED5D967405854219C43EA9BDECD468E, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_C0CC9FEDCEBB7BCD0CCC17C932D1E4E01ED5D967405854219C43EA9BDECD468E, (void*)(&value));
			}
		}

		// Token: 0x17003EC0 RID: 16064
		// (get) Token: 0x0600CE57 RID: 52823 RVA: 0x0033CF50 File Offset: 0x0033B150
		// (set) Token: 0x0600CE58 RID: 52824 RVA: 0x000620A3 File Offset: 0x000602A3
		public unsafe static _PrivateImplementationDetails_.ValueTypeNPrivateSealed0 CB905ABE3A65F90015E71BBAE44A0992AC4097FC01B222EAE0775D782A894045
		{
			get
			{
				_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 result;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_CB905ABE3A65F90015E71BBAE44A0992AC4097FC01B222EAE0775D782A894045, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_CB905ABE3A65F90015E71BBAE44A0992AC4097FC01B222EAE0775D782A894045, (void*)(&value));
			}
		}

		// Token: 0x17003EC1 RID: 16065
		// (get) Token: 0x0600CE59 RID: 52825 RVA: 0x0033CF6C File Offset: 0x0033B16C
		// (set) Token: 0x0600CE5A RID: 52826 RVA: 0x000620B1 File Offset: 0x000602B1
		public unsafe static _PrivateImplementationDetails_.ValueTypeNPrivateSealed0 F186F2262AE48F2AA4F90C9A6B35913B0F6B0B895423B6267252259BFD357D3B
		{
			get
			{
				_PrivateImplementationDetails_.ValueTypeNPrivateSealed0 result;
				IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_F186F2262AE48F2AA4F90C9A6B35913B0F6B0B895423B6267252259BFD357D3B, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_F186F2262AE48F2AA4F90C9A6B35913B0F6B0B895423B6267252259BFD357D3B, (void*)(&value));
			}
		}

		// Token: 0x04008C6B RID: 35947
		private static readonly IntPtr NativeFieldInfoPtr__0A0EC6D4742068B4D88C6145B8224EF1DC240C8A305CDFC50C3AAF9121E6875D;

		// Token: 0x04008C6C RID: 35948
		private static readonly IntPtr NativeFieldInfoPtr__25B47F67A702E9A42CCCA33C60CD5692FF6324DF631931A3395DE22722C2E32A;

		// Token: 0x04008C6D RID: 35949
		private static readonly IntPtr NativeFieldInfoPtr__391C790A82C9FF8530A643C6E15299EB894534F79E38378A202F608383460A94;

		// Token: 0x04008C6E RID: 35950
		private static readonly IntPtr NativeFieldInfoPtr__47AE6576DFB191228A85E1CDEFC179FDD55C57A29E49BBEC089424F2E25E0DB9;

		// Token: 0x04008C6F RID: 35951
		private static readonly IntPtr NativeFieldInfoPtr__5DBD49C4016CBE51C0048D71FC5FE2D5DD89EF577D1E135E71749D588A3A8657;

		// Token: 0x04008C70 RID: 35952
		private static readonly IntPtr NativeFieldInfoPtr__94AC9E3B5D2EA6FEB03FFE0856EF4600428609A1F4EF30123CB4E73B6CCB8CD5;

		// Token: 0x04008C71 RID: 35953
		private static readonly IntPtr NativeFieldInfoPtr__9A2689BE663AB3D504CCED78A84BD0EFCC3B3FC9FEB7BBD3994346E3CF839714;

		// Token: 0x04008C72 RID: 35954
		private static readonly IntPtr NativeFieldInfoPtr__9DA4162EA99B4798E939E3F6921620101CA0DD4619C45124BFAE0089D39ABC2C;

		// Token: 0x04008C73 RID: 35955
		private static readonly IntPtr NativeFieldInfoPtr_C0CC9FEDCEBB7BCD0CCC17C932D1E4E01ED5D967405854219C43EA9BDECD468E;

		// Token: 0x04008C74 RID: 35956
		private static readonly IntPtr NativeFieldInfoPtr_CB905ABE3A65F90015E71BBAE44A0992AC4097FC01B222EAE0775D782A894045;

		// Token: 0x04008C75 RID: 35957
		private static readonly IntPtr NativeFieldInfoPtr_F186F2262AE48F2AA4F90C9A6B35913B0F6B0B895423B6267252259BFD357D3B;

		// Token: 0x04008C76 RID: 35958
		private static readonly IntPtr NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0;

		// Token: 0x02000D98 RID: 3480
		[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=12")]
		[StructLayout(2)]
		public struct ValueTypeNPrivateSealed0
		{
			// Token: 0x0600FCB2 RID: 64690 RVA: 0x000779A3 File Offset: 0x00075BA3
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeNPrivateSealed0()
			{
				Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=12");
			}

			// Token: 0x0600FCB3 RID: 64691 RVA: 0x000779B9 File Offset: 0x00075BB9
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000D99 RID: 3481
		[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=20")]
		[StructLayout(2)]
		public struct ValueTypeNPrivateSealed1
		{
			// Token: 0x0600FCB4 RID: 64692 RVA: 0x000779CB File Offset: 0x00075BCB
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeNPrivateSealed1()
			{
				Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=20");
			}

			// Token: 0x0600FCB5 RID: 64693 RVA: 0x000779E1 File Offset: 0x00075BE1
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000D9A RID: 3482
		[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=24")]
		[StructLayout(2)]
		public struct ValueTypeNPrivateSealed2
		{
			// Token: 0x0600FCB6 RID: 64694 RVA: 0x000779F3 File Offset: 0x00075BF3
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeNPrivateSealed2()
			{
				Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=24");
			}

			// Token: 0x0600FCB7 RID: 64695 RVA: 0x00077A09 File Offset: 0x00075C09
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed2>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000D9B RID: 3483
		[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=32")]
		[StructLayout(2)]
		public struct ValueTypeNPrivateSealed3
		{
			// Token: 0x0600FCB8 RID: 64696 RVA: 0x00077A1B File Offset: 0x00075C1B
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeNPrivateSealed3()
			{
				Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=32");
			}

			// Token: 0x0600FCB9 RID: 64697 RVA: 0x00077A31 File Offset: 0x00075C31
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed3>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000D9C RID: 3484
		[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=80")]
		[StructLayout(2)]
		public struct ValueTypeNPrivateSealed4
		{
			// Token: 0x0600FCBA RID: 64698 RVA: 0x00077A43 File Offset: 0x00075C43
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeNPrivateSealed4()
			{
				Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=80");
			}

			// Token: 0x0600FCBB RID: 64699 RVA: 0x00077A59 File Offset: 0x00075C59
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed4>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000D9D RID: 3485
		[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=98344")]
		[StructLayout(2)]
		public struct ValueTypeNPrivateSealed5
		{
			// Token: 0x0600FCBC RID: 64700 RVA: 0x00077A6B File Offset: 0x00075C6B
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeNPrivateSealed5()
			{
				Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=98344");
			}

			// Token: 0x0600FCBD RID: 64701 RVA: 0x00077A81 File Offset: 0x00075C81
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed5>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000D9E RID: 3486
		[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=115808")]
		[StructLayout(2)]
		public struct ValueTypeNPrivateSealed6
		{
			// Token: 0x0600FCBE RID: 64702 RVA: 0x00077A93 File Offset: 0x00075C93
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeNPrivateSealed6()
			{
				Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=115808");
			}

			// Token: 0x0600FCBF RID: 64703 RVA: 0x00077AA9 File Offset: 0x00075CA9
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed6>.NativeClassPtr, ref this));
			}
		}
	}
}
