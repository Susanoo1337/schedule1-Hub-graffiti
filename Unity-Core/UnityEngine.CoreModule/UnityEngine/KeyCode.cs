using System;

namespace UnityEngine
{
	// Token: 0x020000EC RID: 236
	public enum KeyCode
	{
		// Token: 0x04000F4E RID: 3918
		None,
		// Token: 0x04000F4F RID: 3919
		Backspace = 8,
		// Token: 0x04000F50 RID: 3920
		Delete = 127,
		// Token: 0x04000F51 RID: 3921
		Tab = 9,
		// Token: 0x04000F52 RID: 3922
		Clear = 12,
		// Token: 0x04000F53 RID: 3923
		Return,
		// Token: 0x04000F54 RID: 3924
		Pause = 19,
		// Token: 0x04000F55 RID: 3925
		Escape = 27,
		// Token: 0x04000F56 RID: 3926
		Space = 32,
		// Token: 0x04000F57 RID: 3927
		Keypad0 = 256,
		// Token: 0x04000F58 RID: 3928
		Keypad1,
		// Token: 0x04000F59 RID: 3929
		Keypad2,
		// Token: 0x04000F5A RID: 3930
		Keypad3,
		// Token: 0x04000F5B RID: 3931
		Keypad4,
		// Token: 0x04000F5C RID: 3932
		Keypad5,
		// Token: 0x04000F5D RID: 3933
		Keypad6,
		// Token: 0x04000F5E RID: 3934
		Keypad7,
		// Token: 0x04000F5F RID: 3935
		Keypad8,
		// Token: 0x04000F60 RID: 3936
		Keypad9,
		// Token: 0x04000F61 RID: 3937
		KeypadPeriod,
		// Token: 0x04000F62 RID: 3938
		KeypadDivide,
		// Token: 0x04000F63 RID: 3939
		KeypadMultiply,
		// Token: 0x04000F64 RID: 3940
		KeypadMinus,
		// Token: 0x04000F65 RID: 3941
		KeypadPlus,
		// Token: 0x04000F66 RID: 3942
		KeypadEnter,
		// Token: 0x04000F67 RID: 3943
		KeypadEquals,
		// Token: 0x04000F68 RID: 3944
		UpArrow,
		// Token: 0x04000F69 RID: 3945
		DownArrow,
		// Token: 0x04000F6A RID: 3946
		RightArrow,
		// Token: 0x04000F6B RID: 3947
		LeftArrow,
		// Token: 0x04000F6C RID: 3948
		Insert,
		// Token: 0x04000F6D RID: 3949
		Home,
		// Token: 0x04000F6E RID: 3950
		End,
		// Token: 0x04000F6F RID: 3951
		PageUp,
		// Token: 0x04000F70 RID: 3952
		PageDown,
		// Token: 0x04000F71 RID: 3953
		F1,
		// Token: 0x04000F72 RID: 3954
		F2,
		// Token: 0x04000F73 RID: 3955
		F3,
		// Token: 0x04000F74 RID: 3956
		F4,
		// Token: 0x04000F75 RID: 3957
		F5,
		// Token: 0x04000F76 RID: 3958
		F6,
		// Token: 0x04000F77 RID: 3959
		F7,
		// Token: 0x04000F78 RID: 3960
		F8,
		// Token: 0x04000F79 RID: 3961
		F9,
		// Token: 0x04000F7A RID: 3962
		F10,
		// Token: 0x04000F7B RID: 3963
		F11,
		// Token: 0x04000F7C RID: 3964
		F12,
		// Token: 0x04000F7D RID: 3965
		F13,
		// Token: 0x04000F7E RID: 3966
		F14,
		// Token: 0x04000F7F RID: 3967
		F15,
		// Token: 0x04000F80 RID: 3968
		Alpha0 = 48,
		// Token: 0x04000F81 RID: 3969
		Alpha1,
		// Token: 0x04000F82 RID: 3970
		Alpha2,
		// Token: 0x04000F83 RID: 3971
		Alpha3,
		// Token: 0x04000F84 RID: 3972
		Alpha4,
		// Token: 0x04000F85 RID: 3973
		Alpha5,
		// Token: 0x04000F86 RID: 3974
		Alpha6,
		// Token: 0x04000F87 RID: 3975
		Alpha7,
		// Token: 0x04000F88 RID: 3976
		Alpha8,
		// Token: 0x04000F89 RID: 3977
		Alpha9,
		// Token: 0x04000F8A RID: 3978
		Exclaim = 33,
		// Token: 0x04000F8B RID: 3979
		DoubleQuote,
		// Token: 0x04000F8C RID: 3980
		Hash,
		// Token: 0x04000F8D RID: 3981
		Dollar,
		// Token: 0x04000F8E RID: 3982
		Percent,
		// Token: 0x04000F8F RID: 3983
		Ampersand,
		// Token: 0x04000F90 RID: 3984
		Quote,
		// Token: 0x04000F91 RID: 3985
		LeftParen,
		// Token: 0x04000F92 RID: 3986
		RightParen,
		// Token: 0x04000F93 RID: 3987
		Asterisk,
		// Token: 0x04000F94 RID: 3988
		Plus,
		// Token: 0x04000F95 RID: 3989
		Comma,
		// Token: 0x04000F96 RID: 3990
		Minus,
		// Token: 0x04000F97 RID: 3991
		Period,
		// Token: 0x04000F98 RID: 3992
		Slash,
		// Token: 0x04000F99 RID: 3993
		Colon = 58,
		// Token: 0x04000F9A RID: 3994
		Semicolon,
		// Token: 0x04000F9B RID: 3995
		Less,
		// Token: 0x04000F9C RID: 3996
		Equals,
		// Token: 0x04000F9D RID: 3997
		Greater,
		// Token: 0x04000F9E RID: 3998
		Question,
		// Token: 0x04000F9F RID: 3999
		At,
		// Token: 0x04000FA0 RID: 4000
		LeftBracket = 91,
		// Token: 0x04000FA1 RID: 4001
		Backslash,
		// Token: 0x04000FA2 RID: 4002
		RightBracket,
		// Token: 0x04000FA3 RID: 4003
		Caret,
		// Token: 0x04000FA4 RID: 4004
		Underscore,
		// Token: 0x04000FA5 RID: 4005
		BackQuote,
		// Token: 0x04000FA6 RID: 4006
		A,
		// Token: 0x04000FA7 RID: 4007
		B,
		// Token: 0x04000FA8 RID: 4008
		C,
		// Token: 0x04000FA9 RID: 4009
		D,
		// Token: 0x04000FAA RID: 4010
		E,
		// Token: 0x04000FAB RID: 4011
		F,
		// Token: 0x04000FAC RID: 4012
		G,
		// Token: 0x04000FAD RID: 4013
		H,
		// Token: 0x04000FAE RID: 4014
		I,
		// Token: 0x04000FAF RID: 4015
		J,
		// Token: 0x04000FB0 RID: 4016
		K,
		// Token: 0x04000FB1 RID: 4017
		L,
		// Token: 0x04000FB2 RID: 4018
		M,
		// Token: 0x04000FB3 RID: 4019
		N,
		// Token: 0x04000FB4 RID: 4020
		O,
		// Token: 0x04000FB5 RID: 4021
		P,
		// Token: 0x04000FB6 RID: 4022
		Q,
		// Token: 0x04000FB7 RID: 4023
		R,
		// Token: 0x04000FB8 RID: 4024
		S,
		// Token: 0x04000FB9 RID: 4025
		T,
		// Token: 0x04000FBA RID: 4026
		U,
		// Token: 0x04000FBB RID: 4027
		V,
		// Token: 0x04000FBC RID: 4028
		W,
		// Token: 0x04000FBD RID: 4029
		X,
		// Token: 0x04000FBE RID: 4030
		Y,
		// Token: 0x04000FBF RID: 4031
		Z,
		// Token: 0x04000FC0 RID: 4032
		LeftCurlyBracket,
		// Token: 0x04000FC1 RID: 4033
		Pipe,
		// Token: 0x04000FC2 RID: 4034
		RightCurlyBracket,
		// Token: 0x04000FC3 RID: 4035
		Tilde,
		// Token: 0x04000FC4 RID: 4036
		Numlock = 300,
		// Token: 0x04000FC5 RID: 4037
		CapsLock,
		// Token: 0x04000FC6 RID: 4038
		ScrollLock,
		// Token: 0x04000FC7 RID: 4039
		RightShift,
		// Token: 0x04000FC8 RID: 4040
		LeftShift,
		// Token: 0x04000FC9 RID: 4041
		RightControl,
		// Token: 0x04000FCA RID: 4042
		LeftControl,
		// Token: 0x04000FCB RID: 4043
		RightAlt,
		// Token: 0x04000FCC RID: 4044
		LeftAlt,
		// Token: 0x04000FCD RID: 4045
		LeftMeta = 310,
		// Token: 0x04000FCE RID: 4046
		LeftCommand = 310,
		// Token: 0x04000FCF RID: 4047
		LeftApple = 310,
		// Token: 0x04000FD0 RID: 4048
		LeftWindows,
		// Token: 0x04000FD1 RID: 4049
		RightMeta = 309,
		// Token: 0x04000FD2 RID: 4050
		RightCommand = 309,
		// Token: 0x04000FD3 RID: 4051
		RightApple = 309,
		// Token: 0x04000FD4 RID: 4052
		RightWindows = 312,
		// Token: 0x04000FD5 RID: 4053
		AltGr,
		// Token: 0x04000FD6 RID: 4054
		Help = 315,
		// Token: 0x04000FD7 RID: 4055
		Print,
		// Token: 0x04000FD8 RID: 4056
		SysReq,
		// Token: 0x04000FD9 RID: 4057
		Break,
		// Token: 0x04000FDA RID: 4058
		Menu,
		// Token: 0x04000FDB RID: 4059
		F16 = 670,
		// Token: 0x04000FDC RID: 4060
		F17,
		// Token: 0x04000FDD RID: 4061
		F18,
		// Token: 0x04000FDE RID: 4062
		F19,
		// Token: 0x04000FDF RID: 4063
		F20,
		// Token: 0x04000FE0 RID: 4064
		F21,
		// Token: 0x04000FE1 RID: 4065
		F22,
		// Token: 0x04000FE2 RID: 4066
		F23,
		// Token: 0x04000FE3 RID: 4067
		F24,
		// Token: 0x04000FE4 RID: 4068
		Mouse0 = 323,
		// Token: 0x04000FE5 RID: 4069
		Mouse1,
		// Token: 0x04000FE6 RID: 4070
		Mouse2,
		// Token: 0x04000FE7 RID: 4071
		Mouse3,
		// Token: 0x04000FE8 RID: 4072
		Mouse4,
		// Token: 0x04000FE9 RID: 4073
		Mouse5,
		// Token: 0x04000FEA RID: 4074
		Mouse6,
		// Token: 0x04000FEB RID: 4075
		JoystickButton0,
		// Token: 0x04000FEC RID: 4076
		JoystickButton1,
		// Token: 0x04000FED RID: 4077
		JoystickButton2,
		// Token: 0x04000FEE RID: 4078
		JoystickButton3,
		// Token: 0x04000FEF RID: 4079
		JoystickButton4,
		// Token: 0x04000FF0 RID: 4080
		JoystickButton5,
		// Token: 0x04000FF1 RID: 4081
		JoystickButton6,
		// Token: 0x04000FF2 RID: 4082
		JoystickButton7,
		// Token: 0x04000FF3 RID: 4083
		JoystickButton8,
		// Token: 0x04000FF4 RID: 4084
		JoystickButton9,
		// Token: 0x04000FF5 RID: 4085
		JoystickButton10,
		// Token: 0x04000FF6 RID: 4086
		JoystickButton11,
		// Token: 0x04000FF7 RID: 4087
		JoystickButton12,
		// Token: 0x04000FF8 RID: 4088
		JoystickButton13,
		// Token: 0x04000FF9 RID: 4089
		JoystickButton14,
		// Token: 0x04000FFA RID: 4090
		JoystickButton15,
		// Token: 0x04000FFB RID: 4091
		JoystickButton16,
		// Token: 0x04000FFC RID: 4092
		JoystickButton17,
		// Token: 0x04000FFD RID: 4093
		JoystickButton18,
		// Token: 0x04000FFE RID: 4094
		JoystickButton19,
		// Token: 0x04000FFF RID: 4095
		Joystick1Button0,
		// Token: 0x04001000 RID: 4096
		Joystick1Button1,
		// Token: 0x04001001 RID: 4097
		Joystick1Button2,
		// Token: 0x04001002 RID: 4098
		Joystick1Button3,
		// Token: 0x04001003 RID: 4099
		Joystick1Button4,
		// Token: 0x04001004 RID: 4100
		Joystick1Button5,
		// Token: 0x04001005 RID: 4101
		Joystick1Button6,
		// Token: 0x04001006 RID: 4102
		Joystick1Button7,
		// Token: 0x04001007 RID: 4103
		Joystick1Button8,
		// Token: 0x04001008 RID: 4104
		Joystick1Button9,
		// Token: 0x04001009 RID: 4105
		Joystick1Button10,
		// Token: 0x0400100A RID: 4106
		Joystick1Button11,
		// Token: 0x0400100B RID: 4107
		Joystick1Button12,
		// Token: 0x0400100C RID: 4108
		Joystick1Button13,
		// Token: 0x0400100D RID: 4109
		Joystick1Button14,
		// Token: 0x0400100E RID: 4110
		Joystick1Button15,
		// Token: 0x0400100F RID: 4111
		Joystick1Button16,
		// Token: 0x04001010 RID: 4112
		Joystick1Button17,
		// Token: 0x04001011 RID: 4113
		Joystick1Button18,
		// Token: 0x04001012 RID: 4114
		Joystick1Button19,
		// Token: 0x04001013 RID: 4115
		Joystick2Button0,
		// Token: 0x04001014 RID: 4116
		Joystick2Button1,
		// Token: 0x04001015 RID: 4117
		Joystick2Button2,
		// Token: 0x04001016 RID: 4118
		Joystick2Button3,
		// Token: 0x04001017 RID: 4119
		Joystick2Button4,
		// Token: 0x04001018 RID: 4120
		Joystick2Button5,
		// Token: 0x04001019 RID: 4121
		Joystick2Button6,
		// Token: 0x0400101A RID: 4122
		Joystick2Button7,
		// Token: 0x0400101B RID: 4123
		Joystick2Button8,
		// Token: 0x0400101C RID: 4124
		Joystick2Button9,
		// Token: 0x0400101D RID: 4125
		Joystick2Button10,
		// Token: 0x0400101E RID: 4126
		Joystick2Button11,
		// Token: 0x0400101F RID: 4127
		Joystick2Button12,
		// Token: 0x04001020 RID: 4128
		Joystick2Button13,
		// Token: 0x04001021 RID: 4129
		Joystick2Button14,
		// Token: 0x04001022 RID: 4130
		Joystick2Button15,
		// Token: 0x04001023 RID: 4131
		Joystick2Button16,
		// Token: 0x04001024 RID: 4132
		Joystick2Button17,
		// Token: 0x04001025 RID: 4133
		Joystick2Button18,
		// Token: 0x04001026 RID: 4134
		Joystick2Button19,
		// Token: 0x04001027 RID: 4135
		Joystick3Button0,
		// Token: 0x04001028 RID: 4136
		Joystick3Button1,
		// Token: 0x04001029 RID: 4137
		Joystick3Button2,
		// Token: 0x0400102A RID: 4138
		Joystick3Button3,
		// Token: 0x0400102B RID: 4139
		Joystick3Button4,
		// Token: 0x0400102C RID: 4140
		Joystick3Button5,
		// Token: 0x0400102D RID: 4141
		Joystick3Button6,
		// Token: 0x0400102E RID: 4142
		Joystick3Button7,
		// Token: 0x0400102F RID: 4143
		Joystick3Button8,
		// Token: 0x04001030 RID: 4144
		Joystick3Button9,
		// Token: 0x04001031 RID: 4145
		Joystick3Button10,
		// Token: 0x04001032 RID: 4146
		Joystick3Button11,
		// Token: 0x04001033 RID: 4147
		Joystick3Button12,
		// Token: 0x04001034 RID: 4148
		Joystick3Button13,
		// Token: 0x04001035 RID: 4149
		Joystick3Button14,
		// Token: 0x04001036 RID: 4150
		Joystick3Button15,
		// Token: 0x04001037 RID: 4151
		Joystick3Button16,
		// Token: 0x04001038 RID: 4152
		Joystick3Button17,
		// Token: 0x04001039 RID: 4153
		Joystick3Button18,
		// Token: 0x0400103A RID: 4154
		Joystick3Button19,
		// Token: 0x0400103B RID: 4155
		Joystick4Button0,
		// Token: 0x0400103C RID: 4156
		Joystick4Button1,
		// Token: 0x0400103D RID: 4157
		Joystick4Button2,
		// Token: 0x0400103E RID: 4158
		Joystick4Button3,
		// Token: 0x0400103F RID: 4159
		Joystick4Button4,
		// Token: 0x04001040 RID: 4160
		Joystick4Button5,
		// Token: 0x04001041 RID: 4161
		Joystick4Button6,
		// Token: 0x04001042 RID: 4162
		Joystick4Button7,
		// Token: 0x04001043 RID: 4163
		Joystick4Button8,
		// Token: 0x04001044 RID: 4164
		Joystick4Button9,
		// Token: 0x04001045 RID: 4165
		Joystick4Button10,
		// Token: 0x04001046 RID: 4166
		Joystick4Button11,
		// Token: 0x04001047 RID: 4167
		Joystick4Button12,
		// Token: 0x04001048 RID: 4168
		Joystick4Button13,
		// Token: 0x04001049 RID: 4169
		Joystick4Button14,
		// Token: 0x0400104A RID: 4170
		Joystick4Button15,
		// Token: 0x0400104B RID: 4171
		Joystick4Button16,
		// Token: 0x0400104C RID: 4172
		Joystick4Button17,
		// Token: 0x0400104D RID: 4173
		Joystick4Button18,
		// Token: 0x0400104E RID: 4174
		Joystick4Button19,
		// Token: 0x0400104F RID: 4175
		Joystick5Button0,
		// Token: 0x04001050 RID: 4176
		Joystick5Button1,
		// Token: 0x04001051 RID: 4177
		Joystick5Button2,
		// Token: 0x04001052 RID: 4178
		Joystick5Button3,
		// Token: 0x04001053 RID: 4179
		Joystick5Button4,
		// Token: 0x04001054 RID: 4180
		Joystick5Button5,
		// Token: 0x04001055 RID: 4181
		Joystick5Button6,
		// Token: 0x04001056 RID: 4182
		Joystick5Button7,
		// Token: 0x04001057 RID: 4183
		Joystick5Button8,
		// Token: 0x04001058 RID: 4184
		Joystick5Button9,
		// Token: 0x04001059 RID: 4185
		Joystick5Button10,
		// Token: 0x0400105A RID: 4186
		Joystick5Button11,
		// Token: 0x0400105B RID: 4187
		Joystick5Button12,
		// Token: 0x0400105C RID: 4188
		Joystick5Button13,
		// Token: 0x0400105D RID: 4189
		Joystick5Button14,
		// Token: 0x0400105E RID: 4190
		Joystick5Button15,
		// Token: 0x0400105F RID: 4191
		Joystick5Button16,
		// Token: 0x04001060 RID: 4192
		Joystick5Button17,
		// Token: 0x04001061 RID: 4193
		Joystick5Button18,
		// Token: 0x04001062 RID: 4194
		Joystick5Button19,
		// Token: 0x04001063 RID: 4195
		Joystick6Button0,
		// Token: 0x04001064 RID: 4196
		Joystick6Button1,
		// Token: 0x04001065 RID: 4197
		Joystick6Button2,
		// Token: 0x04001066 RID: 4198
		Joystick6Button3,
		// Token: 0x04001067 RID: 4199
		Joystick6Button4,
		// Token: 0x04001068 RID: 4200
		Joystick6Button5,
		// Token: 0x04001069 RID: 4201
		Joystick6Button6,
		// Token: 0x0400106A RID: 4202
		Joystick6Button7,
		// Token: 0x0400106B RID: 4203
		Joystick6Button8,
		// Token: 0x0400106C RID: 4204
		Joystick6Button9,
		// Token: 0x0400106D RID: 4205
		Joystick6Button10,
		// Token: 0x0400106E RID: 4206
		Joystick6Button11,
		// Token: 0x0400106F RID: 4207
		Joystick6Button12,
		// Token: 0x04001070 RID: 4208
		Joystick6Button13,
		// Token: 0x04001071 RID: 4209
		Joystick6Button14,
		// Token: 0x04001072 RID: 4210
		Joystick6Button15,
		// Token: 0x04001073 RID: 4211
		Joystick6Button16,
		// Token: 0x04001074 RID: 4212
		Joystick6Button17,
		// Token: 0x04001075 RID: 4213
		Joystick6Button18,
		// Token: 0x04001076 RID: 4214
		Joystick6Button19,
		// Token: 0x04001077 RID: 4215
		Joystick7Button0,
		// Token: 0x04001078 RID: 4216
		Joystick7Button1,
		// Token: 0x04001079 RID: 4217
		Joystick7Button2,
		// Token: 0x0400107A RID: 4218
		Joystick7Button3,
		// Token: 0x0400107B RID: 4219
		Joystick7Button4,
		// Token: 0x0400107C RID: 4220
		Joystick7Button5,
		// Token: 0x0400107D RID: 4221
		Joystick7Button6,
		// Token: 0x0400107E RID: 4222
		Joystick7Button7,
		// Token: 0x0400107F RID: 4223
		Joystick7Button8,
		// Token: 0x04001080 RID: 4224
		Joystick7Button9,
		// Token: 0x04001081 RID: 4225
		Joystick7Button10,
		// Token: 0x04001082 RID: 4226
		Joystick7Button11,
		// Token: 0x04001083 RID: 4227
		Joystick7Button12,
		// Token: 0x04001084 RID: 4228
		Joystick7Button13,
		// Token: 0x04001085 RID: 4229
		Joystick7Button14,
		// Token: 0x04001086 RID: 4230
		Joystick7Button15,
		// Token: 0x04001087 RID: 4231
		Joystick7Button16,
		// Token: 0x04001088 RID: 4232
		Joystick7Button17,
		// Token: 0x04001089 RID: 4233
		Joystick7Button18,
		// Token: 0x0400108A RID: 4234
		Joystick7Button19,
		// Token: 0x0400108B RID: 4235
		Joystick8Button0,
		// Token: 0x0400108C RID: 4236
		Joystick8Button1,
		// Token: 0x0400108D RID: 4237
		Joystick8Button2,
		// Token: 0x0400108E RID: 4238
		Joystick8Button3,
		// Token: 0x0400108F RID: 4239
		Joystick8Button4,
		// Token: 0x04001090 RID: 4240
		Joystick8Button5,
		// Token: 0x04001091 RID: 4241
		Joystick8Button6,
		// Token: 0x04001092 RID: 4242
		Joystick8Button7,
		// Token: 0x04001093 RID: 4243
		Joystick8Button8,
		// Token: 0x04001094 RID: 4244
		Joystick8Button9,
		// Token: 0x04001095 RID: 4245
		Joystick8Button10,
		// Token: 0x04001096 RID: 4246
		Joystick8Button11,
		// Token: 0x04001097 RID: 4247
		Joystick8Button12,
		// Token: 0x04001098 RID: 4248
		Joystick8Button13,
		// Token: 0x04001099 RID: 4249
		Joystick8Button14,
		// Token: 0x0400109A RID: 4250
		Joystick8Button15,
		// Token: 0x0400109B RID: 4251
		Joystick8Button16,
		// Token: 0x0400109C RID: 4252
		Joystick8Button17,
		// Token: 0x0400109D RID: 4253
		Joystick8Button18,
		// Token: 0x0400109E RID: 4254
		Joystick8Button19
	}
}
