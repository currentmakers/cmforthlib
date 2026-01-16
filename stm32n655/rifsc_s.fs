\
\ @file rifsc_s.fs
\ @brief Resource isolation framework security controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RIFSC RISC slave configuration register x
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant RIFSC_S_RIFSC_RISC_CR_GLOCK                      \ Global lock


\
\ @brief RIFSC RISC slave security configuration register 0
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC0                 \ security configuration for peripheral 0
$00000002 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC1                 \ security configuration for peripheral 1
$00000004 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC2                 \ security configuration for peripheral 2
$00000008 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC3                 \ security configuration for peripheral 3
$00000010 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC4                 \ security configuration for peripheral 4
$00000020 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC5                 \ security configuration for peripheral 5
$00000040 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC6                 \ security configuration for peripheral 6
$00000080 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC7                 \ security configuration for peripheral 7
$00000100 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC8                 \ security configuration for peripheral 8
$00000200 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC9                 \ security configuration for peripheral 9
$00000400 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC10                \ security configuration for peripheral 10
$00000800 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC11                \ security configuration for peripheral 11
$00001000 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC12                \ security configuration for peripheral 12
$00002000 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC13                \ security configuration for peripheral 13
$00004000 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC14                \ security configuration for peripheral 14
$00008000 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC15                \ security configuration for peripheral 15
$00010000 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC16                \ security configuration for peripheral 16
$00020000 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC17                \ security configuration for peripheral 17
$00040000 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC18                \ security configuration for peripheral 18
$00080000 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC19                \ security configuration for peripheral 19
$00100000 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC20                \ security configuration for peripheral 20
$00200000 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC21                \ security configuration for peripheral 21
$00400000 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC22                \ security configuration for peripheral 22
$00800000 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC23                \ security configuration for peripheral 23
$01000000 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC24                \ security configuration for peripheral 24
$02000000 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC25                \ security configuration for peripheral 25
$04000000 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC26                \ security configuration for peripheral 26
$08000000 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC27                \ security configuration for peripheral 27
$10000000 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC28                \ security configuration for peripheral 28
$20000000 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC29                \ security configuration for peripheral 29
$40000000 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC30                \ security configuration for peripheral 30
$80000000 constant RIFSC_S_RIFSC_RISC_SECCFGR0_SEC31                \ security configuration for peripheral 31


\
\ @brief RIFSC RISC slave security configuration register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC32                \ security configuration for peripheral 32
$00000002 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC33                \ security configuration for peripheral 33
$00000004 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC34                \ security configuration for peripheral 34
$00000008 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC35                \ security configuration for peripheral 35
$00000010 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC36                \ security configuration for peripheral 36
$00000020 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC37                \ security configuration for peripheral 37
$00000040 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC38                \ security configuration for peripheral 38
$00000080 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC39                \ security configuration for peripheral 39
$00000100 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC40                \ security configuration for peripheral 40
$00000200 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC41                \ security configuration for peripheral 41
$00000400 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC42                \ security configuration for peripheral 42
$00000800 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC43                \ security configuration for peripheral 43
$00001000 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC44                \ security configuration for peripheral 44
$00002000 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC45                \ security configuration for peripheral 45
$00004000 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC46                \ security configuration for peripheral 46
$00008000 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC47                \ security configuration for peripheral 47
$00010000 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC48                \ security configuration for peripheral 48
$00020000 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC49                \ security configuration for peripheral 49
$00040000 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC50                \ security configuration for peripheral 50
$00080000 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC51                \ security configuration for peripheral 51
$00100000 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC52                \ security configuration for peripheral 52
$00200000 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC53                \ security configuration for peripheral 53
$00400000 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC54                \ security configuration for peripheral 54
$00800000 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC55                \ security configuration for peripheral 55
$01000000 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC56                \ security configuration for peripheral 56
$02000000 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC57                \ security configuration for peripheral 57
$04000000 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC58                \ security configuration for peripheral 58
$08000000 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC59                \ security configuration for peripheral 59
$10000000 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC60                \ security configuration for peripheral 60
$20000000 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC61                \ security configuration for peripheral 61
$40000000 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC62                \ security configuration for peripheral 62
$80000000 constant RIFSC_S_RIFSC_RISC_SECCFGR1_SEC63                \ security configuration for peripheral 63


\
\ @brief RIFSC RISC slave security configuration register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC64                \ security configuration for peripheral 64
$00000002 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC65                \ security configuration for peripheral 65
$00000004 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC66                \ security configuration for peripheral 66
$00000008 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC67                \ security configuration for peripheral 67
$00000010 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC68                \ security configuration for peripheral 68
$00000020 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC69                \ security configuration for peripheral 69
$00000040 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC70                \ security configuration for peripheral 70
$00000080 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC71                \ security configuration for peripheral 71
$00000100 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC72                \ security configuration for peripheral 72
$00000200 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC73                \ security configuration for peripheral 73
$00000400 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC74                \ security configuration for peripheral 74
$00000800 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC75                \ security configuration for peripheral 75
$00001000 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC76                \ security configuration for peripheral 76
$00002000 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC77                \ security configuration for peripheral 77
$00004000 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC78                \ security configuration for peripheral 78
$00008000 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC79                \ security configuration for peripheral 79
$00010000 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC80                \ security configuration for peripheral 80
$00020000 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC81                \ security configuration for peripheral 81
$00040000 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC82                \ security configuration for peripheral 82
$00080000 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC83                \ security configuration for peripheral 83
$00100000 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC84                \ security configuration for peripheral 84
$00200000 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC85                \ security configuration for peripheral 85
$00400000 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC86                \ security configuration for peripheral 86
$00800000 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC87                \ security configuration for peripheral 87
$01000000 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC88                \ security configuration for peripheral 88
$02000000 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC89                \ security configuration for peripheral 89
$04000000 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC90                \ security configuration for peripheral 90
$08000000 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC91                \ security configuration for peripheral 91
$10000000 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC92                \ security configuration for peripheral 92
$20000000 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC93                \ security configuration for peripheral 93
$40000000 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC94                \ security configuration for peripheral 94
$80000000 constant RIFSC_S_RIFSC_RISC_SECCFGR2_SEC95                \ security configuration for peripheral 95


\
\ @brief RIFSC RISC slave security configuration register 3
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC96                \ security configuration for peripheral 96
$00000002 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC97                \ security configuration for peripheral 97
$00000004 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC98                \ security configuration for peripheral 98
$00000008 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC99                \ security configuration for peripheral 99
$00000010 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC100               \ security configuration for peripheral 100
$00000020 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC101               \ security configuration for peripheral 101
$00000040 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC102               \ security configuration for peripheral 102
$00000080 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC103               \ security configuration for peripheral 103
$00000100 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC104               \ security configuration for peripheral 104
$00000200 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC105               \ security configuration for peripheral 105
$00000400 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC106               \ security configuration for peripheral 106
$00000800 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC107               \ security configuration for peripheral 107
$00001000 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC108               \ security configuration for peripheral 108
$00002000 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC109               \ security configuration for peripheral 109
$00004000 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC110               \ security configuration for peripheral 110
$00008000 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC111               \ security configuration for peripheral 111
$00010000 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC112               \ security configuration for peripheral 112
$00020000 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC113               \ security configuration for peripheral 113
$00040000 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC114               \ security configuration for peripheral 114
$00080000 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC115               \ security configuration for peripheral 115
$00100000 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC116               \ security configuration for peripheral 116
$00200000 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC117               \ security configuration for peripheral 117
$00400000 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC118               \ security configuration for peripheral 118
$00800000 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC119               \ security configuration for peripheral 119
$01000000 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC120               \ security configuration for peripheral 120
$02000000 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC121               \ security configuration for peripheral 121
$04000000 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC122               \ security configuration for peripheral 122
$08000000 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC123               \ security configuration for peripheral 123
$10000000 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC124               \ security configuration for peripheral 124
$20000000 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC125               \ security configuration for peripheral 125
$40000000 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC126               \ security configuration for peripheral 126
$80000000 constant RIFSC_S_RIFSC_RISC_SECCFGR3_SEC127               \ security configuration for peripheral 127


\
\ @brief RIFSC RISC slave security configuration register 4
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC128               \ security configuration for peripheral 128
$00000002 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC129               \ security configuration for peripheral 129
$00000004 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC130               \ security configuration for peripheral 130
$00000008 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC131               \ security configuration for peripheral 131
$00000010 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC132               \ security configuration for peripheral 132
$00000020 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC133               \ security configuration for peripheral 133
$00000040 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC134               \ security configuration for peripheral 134
$00000080 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC135               \ security configuration for peripheral 135
$00000100 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC136               \ security configuration for peripheral 136
$00000200 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC137               \ security configuration for peripheral 137
$00000400 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC138               \ security configuration for peripheral 138
$00000800 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC139               \ security configuration for peripheral 139
$00001000 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC140               \ security configuration for peripheral 140
$00002000 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC141               \ security configuration for peripheral 141
$00004000 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC142               \ security configuration for peripheral 142
$00008000 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC143               \ security configuration for peripheral 143
$00010000 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC144               \ security configuration for peripheral 144
$00020000 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC145               \ security configuration for peripheral 145
$00040000 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC146               \ security configuration for peripheral 146
$00080000 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC147               \ security configuration for peripheral 147
$00100000 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC148               \ security configuration for peripheral 148
$00200000 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC149               \ security configuration for peripheral 149
$00400000 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC150               \ security configuration for peripheral 150
$00800000 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC151               \ security configuration for peripheral 151
$01000000 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC152               \ security configuration for peripheral 152
$02000000 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC153               \ security configuration for peripheral 153
$04000000 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC154               \ security configuration for peripheral 154
$08000000 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC155               \ security configuration for peripheral 155
$10000000 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC156               \ security configuration for peripheral 156
$20000000 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC157               \ security configuration for peripheral 157
$40000000 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC158               \ security configuration for peripheral 158
$80000000 constant RIFSC_S_RIFSC_RISC_SECCFGR4_SEC159               \ security configuration for peripheral 159


\
\ @brief RIFSC RISC slave security configuration register 5
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC160               \ security configuration for peripheral 160
$00000002 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC161               \ security configuration for peripheral 161
$00000004 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC162               \ security configuration for peripheral 162
$00000008 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC163               \ security configuration for peripheral 163
$00000010 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC164               \ security configuration for peripheral 164
$00000020 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC165               \ security configuration for peripheral 165
$00000040 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC166               \ security configuration for peripheral 166
$00000080 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC167               \ security configuration for peripheral 167
$00000100 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC168               \ security configuration for peripheral 168
$00000200 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC169               \ security configuration for peripheral 169
$00000400 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC170               \ security configuration for peripheral 170
$00000800 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC171               \ security configuration for peripheral 171
$00001000 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC172               \ security configuration for peripheral 172
$00002000 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC173               \ security configuration for peripheral 173
$00004000 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC174               \ security configuration for peripheral 174
$00008000 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC175               \ security configuration for peripheral 175
$00010000 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC176               \ security configuration for peripheral 176
$00020000 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC177               \ security configuration for peripheral 177
$00040000 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC178               \ security configuration for peripheral 178
$00080000 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC179               \ security configuration for peripheral 179
$00100000 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC180               \ security configuration for peripheral 180
$00200000 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC181               \ security configuration for peripheral 181
$00400000 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC182               \ security configuration for peripheral 182
$00800000 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC183               \ security configuration for peripheral 183
$01000000 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC184               \ security configuration for peripheral 184
$02000000 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC185               \ security configuration for peripheral 185
$04000000 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC186               \ security configuration for peripheral 186
$08000000 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC187               \ security configuration for peripheral 187
$10000000 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC188               \ security configuration for peripheral 188
$20000000 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC189               \ security configuration for peripheral 189
$40000000 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC190               \ security configuration for peripheral 190
$80000000 constant RIFSC_S_RIFSC_RISC_SECCFGR5_SEC191               \ security configuration for peripheral 191


\
\ @brief RIFSC RISFC slave privileged register 0
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV0               \ privileged-only access permission for peripheral 0
$00000002 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV1               \ privileged-only access permission for peripheral 1
$00000004 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV2               \ privileged-only access permission for peripheral 2
$00000008 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV3               \ privileged-only access permission for peripheral 3
$00000010 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV4               \ privileged-only access permission for peripheral 4
$00000020 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV5               \ privileged-only access permission for peripheral 5
$00000040 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV6               \ privileged-only access permission for peripheral 6
$00000080 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV7               \ privileged-only access permission for peripheral 7
$00000100 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV8               \ privileged-only access permission for peripheral 8
$00000200 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV9               \ privileged-only access permission for peripheral 9
$00000400 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV10              \ privileged-only access permission for peripheral 10
$00000800 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV11              \ privileged-only access permission for peripheral 11
$00001000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV12              \ privileged-only access permission for peripheral 12
$00002000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV13              \ privileged-only access permission for peripheral 13
$00004000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV14              \ privileged-only access permission for peripheral 14
$00008000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV15              \ privileged-only access permission for peripheral 15
$00010000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV16              \ privileged-only access permission for peripheral 16
$00020000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV17              \ privileged-only access permission for peripheral 17
$00040000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV18              \ privileged-only access permission for peripheral 18
$00080000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV19              \ privileged-only access permission for peripheral 19
$00100000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV20              \ privileged-only access permission for peripheral 20
$00200000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV21              \ privileged-only access permission for peripheral 21
$00400000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV22              \ privileged-only access permission for peripheral 22
$00800000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV23              \ privileged-only access permission for peripheral 23
$01000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV24              \ privileged-only access permission for peripheral 24
$02000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV25              \ privileged-only access permission for peripheral 25
$04000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV26              \ privileged-only access permission for peripheral 26
$08000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV27              \ privileged-only access permission for peripheral 27
$10000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV28              \ privileged-only access permission for peripheral 28
$20000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV29              \ privileged-only access permission for peripheral 29
$40000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV30              \ privileged-only access permission for peripheral 30
$80000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0_PRIV31              \ privileged-only access permission for peripheral 31


\
\ @brief RIFSC RISFC slave privileged register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV32              \ privileged-only access permission for peripheral 32
$00000002 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV33              \ privileged-only access permission for peripheral 33
$00000004 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV34              \ privileged-only access permission for peripheral 34
$00000008 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV35              \ privileged-only access permission for peripheral 35
$00000010 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV36              \ privileged-only access permission for peripheral 36
$00000020 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV37              \ privileged-only access permission for peripheral 37
$00000040 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV38              \ privileged-only access permission for peripheral 38
$00000080 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV39              \ privileged-only access permission for peripheral 39
$00000100 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV40              \ privileged-only access permission for peripheral 40
$00000200 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV41              \ privileged-only access permission for peripheral 41
$00000400 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV42              \ privileged-only access permission for peripheral 42
$00000800 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV43              \ privileged-only access permission for peripheral 43
$00001000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV44              \ privileged-only access permission for peripheral 44
$00002000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV45              \ privileged-only access permission for peripheral 45
$00004000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV46              \ privileged-only access permission for peripheral 46
$00008000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV47              \ privileged-only access permission for peripheral 47
$00010000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV48              \ privileged-only access permission for peripheral 48
$00020000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV49              \ privileged-only access permission for peripheral 49
$00040000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV50              \ privileged-only access permission for peripheral 50
$00080000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV51              \ privileged-only access permission for peripheral 51
$00100000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV52              \ privileged-only access permission for peripheral 52
$00200000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV53              \ privileged-only access permission for peripheral 53
$00400000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV54              \ privileged-only access permission for peripheral 54
$00800000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV55              \ privileged-only access permission for peripheral 55
$01000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV56              \ privileged-only access permission for peripheral 56
$02000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV57              \ privileged-only access permission for peripheral 57
$04000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV58              \ privileged-only access permission for peripheral 58
$08000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV59              \ privileged-only access permission for peripheral 59
$10000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV60              \ privileged-only access permission for peripheral 60
$20000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV61              \ privileged-only access permission for peripheral 61
$40000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV62              \ privileged-only access permission for peripheral 62
$80000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1_PRIV63              \ privileged-only access permission for peripheral 63


\
\ @brief RIFSC RISFC slave privileged register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV64              \ privileged-only access permission for peripheral 64
$00000002 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV65              \ privileged-only access permission for peripheral 65
$00000004 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV66              \ privileged-only access permission for peripheral 66
$00000008 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV67              \ privileged-only access permission for peripheral 67
$00000010 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV68              \ privileged-only access permission for peripheral 68
$00000020 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV69              \ privileged-only access permission for peripheral 69
$00000040 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV70              \ privileged-only access permission for peripheral 70
$00000080 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV71              \ privileged-only access permission for peripheral 71
$00000100 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV72              \ privileged-only access permission for peripheral 72
$00000200 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV73              \ privileged-only access permission for peripheral 73
$00000400 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV74              \ privileged-only access permission for peripheral 74
$00000800 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV75              \ privileged-only access permission for peripheral 75
$00001000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV76              \ privileged-only access permission for peripheral 76
$00002000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV77              \ privileged-only access permission for peripheral 77
$00004000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV78              \ privileged-only access permission for peripheral 78
$00008000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV79              \ privileged-only access permission for peripheral 79
$00010000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV80              \ privileged-only access permission for peripheral 80
$00020000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV81              \ privileged-only access permission for peripheral 81
$00040000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV82              \ privileged-only access permission for peripheral 82
$00080000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV83              \ privileged-only access permission for peripheral 83
$00100000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV84              \ privileged-only access permission for peripheral 84
$00200000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV85              \ privileged-only access permission for peripheral 85
$00400000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV86              \ privileged-only access permission for peripheral 86
$00800000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV87              \ privileged-only access permission for peripheral 87
$01000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV88              \ privileged-only access permission for peripheral 88
$02000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV89              \ privileged-only access permission for peripheral 89
$04000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV90              \ privileged-only access permission for peripheral 90
$08000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV91              \ privileged-only access permission for peripheral 91
$10000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV92              \ privileged-only access permission for peripheral 92
$20000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV93              \ privileged-only access permission for peripheral 93
$40000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV94              \ privileged-only access permission for peripheral 94
$80000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2_PRIV95              \ privileged-only access permission for peripheral 95


\
\ @brief RIFSC RISFC slave privileged register 3
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV96              \ privileged-only access permission for peripheral 96
$00000002 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV97              \ privileged-only access permission for peripheral 97
$00000004 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV98              \ privileged-only access permission for peripheral 98
$00000008 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV99              \ privileged-only access permission for peripheral 99
$00000010 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV100             \ privileged-only access permission for peripheral 100
$00000020 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV101             \ privileged-only access permission for peripheral 101
$00000040 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV102             \ privileged-only access permission for peripheral 102
$00000080 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV103             \ privileged-only access permission for peripheral 103
$00000100 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV104             \ privileged-only access permission for peripheral 104
$00000200 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV105             \ privileged-only access permission for peripheral 105
$00000400 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV106             \ privileged-only access permission for peripheral 106
$00000800 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV107             \ privileged-only access permission for peripheral 107
$00001000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV108             \ privileged-only access permission for peripheral 108
$00002000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV109             \ privileged-only access permission for peripheral 109
$00004000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV110             \ privileged-only access permission for peripheral 110
$00008000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV111             \ privileged-only access permission for peripheral 111
$00010000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV112             \ privileged-only access permission for peripheral 112
$00020000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV113             \ privileged-only access permission for peripheral 113
$00040000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV114             \ privileged-only access permission for peripheral 114
$00080000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV115             \ privileged-only access permission for peripheral 115
$00100000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV116             \ privileged-only access permission for peripheral 116
$00200000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV117             \ privileged-only access permission for peripheral 117
$00400000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV118             \ privileged-only access permission for peripheral 118
$00800000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV119             \ privileged-only access permission for peripheral 119
$01000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV120             \ privileged-only access permission for peripheral 120
$02000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV121             \ privileged-only access permission for peripheral 121
$04000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV122             \ privileged-only access permission for peripheral 122
$08000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV123             \ privileged-only access permission for peripheral 123
$10000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV124             \ privileged-only access permission for peripheral 124
$20000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV125             \ privileged-only access permission for peripheral 125
$40000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV126             \ privileged-only access permission for peripheral 126
$80000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR3_PRIV127             \ privileged-only access permission for peripheral 127


\
\ @brief RIFSC RISFC slave privileged register 4
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV128             \ privileged-only access permission for peripheral 128
$00000002 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV129             \ privileged-only access permission for peripheral 129
$00000004 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV130             \ privileged-only access permission for peripheral 130
$00000008 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV131             \ privileged-only access permission for peripheral 131
$00000010 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV132             \ privileged-only access permission for peripheral 132
$00000020 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV133             \ privileged-only access permission for peripheral 133
$00000040 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV134             \ privileged-only access permission for peripheral 134
$00000080 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV135             \ privileged-only access permission for peripheral 135
$00000100 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV136             \ privileged-only access permission for peripheral 136
$00000200 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV137             \ privileged-only access permission for peripheral 137
$00000400 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV138             \ privileged-only access permission for peripheral 138
$00000800 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV139             \ privileged-only access permission for peripheral 139
$00001000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV140             \ privileged-only access permission for peripheral 140
$00002000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV141             \ privileged-only access permission for peripheral 141
$00004000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV142             \ privileged-only access permission for peripheral 142
$00008000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV143             \ privileged-only access permission for peripheral 143
$00010000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV144             \ privileged-only access permission for peripheral 144
$00020000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV145             \ privileged-only access permission for peripheral 145
$00040000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV146             \ privileged-only access permission for peripheral 146
$00080000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV147             \ privileged-only access permission for peripheral 147
$00100000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV148             \ privileged-only access permission for peripheral 148
$00200000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV149             \ privileged-only access permission for peripheral 149
$00400000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV150             \ privileged-only access permission for peripheral 150
$00800000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV151             \ privileged-only access permission for peripheral 151
$01000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV152             \ privileged-only access permission for peripheral 152
$02000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV153             \ privileged-only access permission for peripheral 153
$04000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV154             \ privileged-only access permission for peripheral 154
$08000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV155             \ privileged-only access permission for peripheral 155
$10000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV156             \ privileged-only access permission for peripheral 156
$20000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV157             \ privileged-only access permission for peripheral 157
$40000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV158             \ privileged-only access permission for peripheral 158
$80000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4_PRIV159             \ privileged-only access permission for peripheral 159


\
\ @brief RIFSC RISFC slave privileged register 5
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV160             \ privileged-only access permission for peripheral 160
$00000002 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV161             \ privileged-only access permission for peripheral 161
$00000004 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV162             \ privileged-only access permission for peripheral 162
$00000008 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV163             \ privileged-only access permission for peripheral 163
$00000010 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV164             \ privileged-only access permission for peripheral 164
$00000020 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV165             \ privileged-only access permission for peripheral 165
$00000040 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV166             \ privileged-only access permission for peripheral 166
$00000080 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV167             \ privileged-only access permission for peripheral 167
$00000100 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV168             \ privileged-only access permission for peripheral 168
$00000200 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV169             \ privileged-only access permission for peripheral 169
$00000400 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV170             \ privileged-only access permission for peripheral 170
$00000800 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV171             \ privileged-only access permission for peripheral 171
$00001000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV172             \ privileged-only access permission for peripheral 172
$00002000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV173             \ privileged-only access permission for peripheral 173
$00004000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV174             \ privileged-only access permission for peripheral 174
$00008000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV175             \ privileged-only access permission for peripheral 175
$00010000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV176             \ privileged-only access permission for peripheral 176
$00020000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV177             \ privileged-only access permission for peripheral 177
$00040000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV178             \ privileged-only access permission for peripheral 178
$00080000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV179             \ privileged-only access permission for peripheral 179
$00100000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV180             \ privileged-only access permission for peripheral 180
$00200000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV181             \ privileged-only access permission for peripheral 181
$00400000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV182             \ privileged-only access permission for peripheral 182
$00800000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV183             \ privileged-only access permission for peripheral 183
$01000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV184             \ privileged-only access permission for peripheral 184
$02000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV185             \ privileged-only access permission for peripheral 185
$04000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV186             \ privileged-only access permission for peripheral 186
$08000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV187             \ privileged-only access permission for peripheral 187
$10000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV188             \ privileged-only access permission for peripheral 188
$20000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV189             \ privileged-only access permission for peripheral 189
$40000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV190             \ privileged-only access permission for peripheral 190
$80000000 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5_PRIV191             \ privileged-only access permission for peripheral 191


\
\ @brief RIFSC RISC slave resource configuration lock register 0
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK0             \ resource lock for peripheral 0
$00000002 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK1             \ resource lock for peripheral 1
$00000004 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK2             \ resource lock for peripheral 2
$00000008 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK3             \ resource lock for peripheral 3
$00000010 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK4             \ resource lock for peripheral 4
$00000020 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK5             \ resource lock for peripheral 5
$00000040 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK6             \ resource lock for peripheral 6
$00000080 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK7             \ resource lock for peripheral 7
$00000100 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK8             \ resource lock for peripheral 8
$00000200 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK9             \ resource lock for peripheral 9
$00000400 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK10            \ resource lock for peripheral 10
$00000800 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK11            \ resource lock for peripheral 11
$00001000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK12            \ resource lock for peripheral 12
$00002000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK13            \ resource lock for peripheral 13
$00004000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK14            \ resource lock for peripheral 14
$00008000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK15            \ resource lock for peripheral 15
$00010000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK16            \ resource lock for peripheral 16
$00020000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK17            \ resource lock for peripheral 17
$00040000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK18            \ resource lock for peripheral 18
$00080000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK19            \ resource lock for peripheral 19
$00100000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK20            \ resource lock for peripheral 20
$00200000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK21            \ resource lock for peripheral 21
$00400000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK22            \ resource lock for peripheral 22
$00800000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK23            \ resource lock for peripheral 23
$01000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK24            \ resource lock for peripheral 24
$02000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK25            \ resource lock for peripheral 25
$04000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK26            \ resource lock for peripheral 26
$08000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK27            \ resource lock for peripheral 27
$10000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK28            \ resource lock for peripheral 28
$20000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK29            \ resource lock for peripheral 29
$40000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK30            \ resource lock for peripheral 30
$80000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0_RLOCK31            \ resource lock for peripheral 31


\
\ @brief RIFSC RISC slave resource configuration lock register 1
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK32            \ resource lock for peripheral 32
$00000002 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK33            \ resource lock for peripheral 33
$00000004 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK34            \ resource lock for peripheral 34
$00000008 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK35            \ resource lock for peripheral 35
$00000010 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK36            \ resource lock for peripheral 36
$00000020 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK37            \ resource lock for peripheral 37
$00000040 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK38            \ resource lock for peripheral 38
$00000080 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK39            \ resource lock for peripheral 39
$00000100 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK40            \ resource lock for peripheral 40
$00000200 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK41            \ resource lock for peripheral 41
$00000400 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK42            \ resource lock for peripheral 42
$00000800 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK43            \ resource lock for peripheral 43
$00001000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK44            \ resource lock for peripheral 44
$00002000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK45            \ resource lock for peripheral 45
$00004000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK46            \ resource lock for peripheral 46
$00008000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK47            \ resource lock for peripheral 47
$00010000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK48            \ resource lock for peripheral 48
$00020000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK49            \ resource lock for peripheral 49
$00040000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK50            \ resource lock for peripheral 50
$00080000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK51            \ resource lock for peripheral 51
$00100000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK52            \ resource lock for peripheral 52
$00200000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK53            \ resource lock for peripheral 53
$00400000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK54            \ resource lock for peripheral 54
$00800000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK55            \ resource lock for peripheral 55
$01000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK56            \ resource lock for peripheral 56
$02000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK57            \ resource lock for peripheral 57
$04000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK58            \ resource lock for peripheral 58
$08000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK59            \ resource lock for peripheral 59
$10000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK60            \ resource lock for peripheral 60
$20000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK61            \ resource lock for peripheral 61
$40000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK62            \ resource lock for peripheral 62
$80000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1_RLOCK63            \ resource lock for peripheral 63


\
\ @brief RIFSC RISC slave resource configuration lock register 2
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK64            \ resource lock for peripheral 64
$00000002 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK65            \ resource lock for peripheral 65
$00000004 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK66            \ resource lock for peripheral 66
$00000008 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK67            \ resource lock for peripheral 67
$00000010 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK68            \ resource lock for peripheral 68
$00000020 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK69            \ resource lock for peripheral 69
$00000040 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK70            \ resource lock for peripheral 70
$00000080 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK71            \ resource lock for peripheral 71
$00000100 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK72            \ resource lock for peripheral 72
$00000200 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK73            \ resource lock for peripheral 73
$00000400 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK74            \ resource lock for peripheral 74
$00000800 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK75            \ resource lock for peripheral 75
$00001000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK76            \ resource lock for peripheral 76
$00002000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK77            \ resource lock for peripheral 77
$00004000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK78            \ resource lock for peripheral 78
$00008000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK79            \ resource lock for peripheral 79
$00010000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK80            \ resource lock for peripheral 80
$00020000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK81            \ resource lock for peripheral 81
$00040000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK82            \ resource lock for peripheral 82
$00080000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK83            \ resource lock for peripheral 83
$00100000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK84            \ resource lock for peripheral 84
$00200000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK85            \ resource lock for peripheral 85
$00400000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK86            \ resource lock for peripheral 86
$00800000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK87            \ resource lock for peripheral 87
$01000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK88            \ resource lock for peripheral 88
$02000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK89            \ resource lock for peripheral 89
$04000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK90            \ resource lock for peripheral 90
$08000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK91            \ resource lock for peripheral 91
$10000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK92            \ resource lock for peripheral 92
$20000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK93            \ resource lock for peripheral 93
$40000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK94            \ resource lock for peripheral 94
$80000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2_RLOCK95            \ resource lock for peripheral 95


\
\ @brief RIFSC RISC slave resource configuration lock register 3
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK96            \ resource lock for peripheral 96
$00000002 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK97            \ resource lock for peripheral 97
$00000004 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK98            \ resource lock for peripheral 98
$00000008 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK99            \ resource lock for peripheral 99
$00000010 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK100           \ resource lock for peripheral 100
$00000020 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK101           \ resource lock for peripheral 101
$00000040 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK102           \ resource lock for peripheral 102
$00000080 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK103           \ resource lock for peripheral 103
$00000100 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK104           \ resource lock for peripheral 104
$00000200 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK105           \ resource lock for peripheral 105
$00000400 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK106           \ resource lock for peripheral 106
$00000800 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK107           \ resource lock for peripheral 107
$00001000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK108           \ resource lock for peripheral 108
$00002000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK109           \ resource lock for peripheral 109
$00004000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK110           \ resource lock for peripheral 110
$00008000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK111           \ resource lock for peripheral 111
$00010000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK112           \ resource lock for peripheral 112
$00020000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK113           \ resource lock for peripheral 113
$00040000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK114           \ resource lock for peripheral 114
$00080000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK115           \ resource lock for peripheral 115
$00100000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK116           \ resource lock for peripheral 116
$00200000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK117           \ resource lock for peripheral 117
$00400000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK118           \ resource lock for peripheral 118
$00800000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK119           \ resource lock for peripheral 119
$01000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK120           \ resource lock for peripheral 120
$02000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK121           \ resource lock for peripheral 121
$04000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK122           \ resource lock for peripheral 122
$08000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK123           \ resource lock for peripheral 123
$10000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK124           \ resource lock for peripheral 124
$20000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK125           \ resource lock for peripheral 125
$40000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK126           \ resource lock for peripheral 126
$80000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3_RLOCK127           \ resource lock for peripheral 127


\
\ @brief RIFSC RISC slave resource configuration lock register 4
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK128           \ resource lock for peripheral 128
$00000002 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK129           \ resource lock for peripheral 129
$00000004 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK130           \ resource lock for peripheral 130
$00000008 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK131           \ resource lock for peripheral 131
$00000010 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK132           \ resource lock for peripheral 132
$00000020 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK133           \ resource lock for peripheral 133
$00000040 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK134           \ resource lock for peripheral 134
$00000080 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK135           \ resource lock for peripheral 135
$00000100 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK136           \ resource lock for peripheral 136
$00000200 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK137           \ resource lock for peripheral 137
$00000400 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK138           \ resource lock for peripheral 138
$00000800 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK139           \ resource lock for peripheral 139
$00001000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK140           \ resource lock for peripheral 140
$00002000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK141           \ resource lock for peripheral 141
$00004000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK142           \ resource lock for peripheral 142
$00008000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK143           \ resource lock for peripheral 143
$00010000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK144           \ resource lock for peripheral 144
$00020000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK145           \ resource lock for peripheral 145
$00040000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK146           \ resource lock for peripheral 146
$00080000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK147           \ resource lock for peripheral 147
$00100000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK148           \ resource lock for peripheral 148
$00200000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK149           \ resource lock for peripheral 149
$00400000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK150           \ resource lock for peripheral 150
$00800000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK151           \ resource lock for peripheral 151
$01000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK152           \ resource lock for peripheral 152
$02000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK153           \ resource lock for peripheral 153
$04000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK154           \ resource lock for peripheral 154
$08000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK155           \ resource lock for peripheral 155
$10000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK156           \ resource lock for peripheral 156
$20000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK157           \ resource lock for peripheral 157
$40000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK158           \ resource lock for peripheral 158
$80000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4_RLOCK159           \ resource lock for peripheral 159


\
\ @brief RIFSC RISC slave resource configuration lock register 5
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000001 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK160           \ resource lock for peripheral 160
$00000002 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK161           \ resource lock for peripheral 161
$00000004 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK162           \ resource lock for peripheral 162
$00000008 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK163           \ resource lock for peripheral 163
$00000010 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK164           \ resource lock for peripheral 164
$00000020 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK165           \ resource lock for peripheral 165
$00000040 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK166           \ resource lock for peripheral 166
$00000080 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK167           \ resource lock for peripheral 167
$00000100 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK168           \ resource lock for peripheral 168
$00000200 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK169           \ resource lock for peripheral 169
$00000400 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK170           \ resource lock for peripheral 170
$00000800 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK171           \ resource lock for peripheral 171
$00001000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK172           \ resource lock for peripheral 172
$00002000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK173           \ resource lock for peripheral 173
$00004000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK174           \ resource lock for peripheral 174
$00008000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK175           \ resource lock for peripheral 175
$00010000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK176           \ resource lock for peripheral 176
$00020000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK177           \ resource lock for peripheral 177
$00040000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK178           \ resource lock for peripheral 178
$00080000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK179           \ resource lock for peripheral 179
$00100000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK180           \ resource lock for peripheral 180
$00200000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK181           \ resource lock for peripheral 181
$00400000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK182           \ resource lock for peripheral 182
$00800000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK183           \ resource lock for peripheral 183
$01000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK184           \ resource lock for peripheral 184
$02000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK185           \ resource lock for peripheral 185
$04000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK186           \ resource lock for peripheral 186
$08000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK187           \ resource lock for peripheral 187
$10000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK188           \ resource lock for peripheral 188
$20000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK189           \ resource lock for peripheral 189
$40000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK190           \ resource lock for peripheral 190
$80000000 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5_RLOCK191           \ resource lock for peripheral 191


\
\ @brief RIFSC RIMC master configuration register
\ Address offset: 0xC00
\ Reset value: 0x00000710
\

$00000001 constant RIFSC_S_RIFSC_RIMC_CR_GLOCK                      \ global lock
$00000700 constant RIFSC_S_RIFSC_RIMC_CR_DAPCID                     \ debug access port compartment ID


\
\ @brief RIFSC RIMC master attribute register 0
\ Address offset: 0xC10
\ Reset value: 0x00000000
\

$00000070 constant RIFSC_S_RIFSC_RIMC_ATTR0_MCID                    \ master CID
$00000100 constant RIFSC_S_RIFSC_RIMC_ATTR0_MSEC                    \ master secure
$00000200 constant RIFSC_S_RIFSC_RIMC_ATTR0_MPRIV                   \ master privileged


\
\ @brief RIFSC RIMC master attribute register 1
\ Address offset: 0xC14
\ Reset value: 0x00000000
\

$00000070 constant RIFSC_S_RIFSC_RIMC_ATTR1_MCID                    \ master CID
$00000100 constant RIFSC_S_RIFSC_RIMC_ATTR1_MSEC                    \ master secure
$00000200 constant RIFSC_S_RIFSC_RIMC_ATTR1_MPRIV                   \ master privileged


\
\ @brief RIFSC RIMC master attribute register 2
\ Address offset: 0xC18
\ Reset value: 0x00000000
\

$00000070 constant RIFSC_S_RIFSC_RIMC_ATTR2_MCID                    \ master CID
$00000100 constant RIFSC_S_RIFSC_RIMC_ATTR2_MSEC                    \ master secure
$00000200 constant RIFSC_S_RIFSC_RIMC_ATTR2_MPRIV                   \ master privileged


\
\ @brief RIFSC RIMC master attribute register 3
\ Address offset: 0xC1C
\ Reset value: 0x00000000
\

$00000070 constant RIFSC_S_RIFSC_RIMC_ATTR3_MCID                    \ master CID
$00000100 constant RIFSC_S_RIFSC_RIMC_ATTR3_MSEC                    \ master secure
$00000200 constant RIFSC_S_RIFSC_RIMC_ATTR3_MPRIV                   \ master privileged


\
\ @brief RIFSC RIMC master attribute register 4
\ Address offset: 0xC20
\ Reset value: 0x00000000
\

$00000070 constant RIFSC_S_RIFSC_RIMC_ATTR4_MCID                    \ master CID
$00000100 constant RIFSC_S_RIFSC_RIMC_ATTR4_MSEC                    \ master secure
$00000200 constant RIFSC_S_RIFSC_RIMC_ATTR4_MPRIV                   \ master privileged


\
\ @brief RIFSC RIMC master attribute register 5
\ Address offset: 0xC24
\ Reset value: 0x00000000
\

$00000070 constant RIFSC_S_RIFSC_RIMC_ATTR5_MCID                    \ master CID
$00000100 constant RIFSC_S_RIFSC_RIMC_ATTR5_MSEC                    \ master secure
$00000200 constant RIFSC_S_RIFSC_RIMC_ATTR5_MPRIV                   \ master privileged


\
\ @brief RIFSC RIMC master attribute register 6
\ Address offset: 0xC28
\ Reset value: 0x00000000
\

$00000070 constant RIFSC_S_RIFSC_RIMC_ATTR6_MCID                    \ master CID
$00000100 constant RIFSC_S_RIFSC_RIMC_ATTR6_MSEC                    \ master secure
$00000200 constant RIFSC_S_RIFSC_RIMC_ATTR6_MPRIV                   \ master privileged


\
\ @brief RIFSC RIMC master attribute register 7
\ Address offset: 0xC2C
\ Reset value: 0x00000000
\

$00000070 constant RIFSC_S_RIFSC_RIMC_ATTR7_MCID                    \ master CID
$00000100 constant RIFSC_S_RIFSC_RIMC_ATTR7_MSEC                    \ master secure
$00000200 constant RIFSC_S_RIFSC_RIMC_ATTR7_MPRIV                   \ master privileged


\
\ @brief RIFSC RIMC master attribute register 8
\ Address offset: 0xC30
\ Reset value: 0x00000000
\

$00000070 constant RIFSC_S_RIFSC_RIMC_ATTR8_MCID                    \ master CID
$00000100 constant RIFSC_S_RIFSC_RIMC_ATTR8_MSEC                    \ master secure
$00000200 constant RIFSC_S_RIFSC_RIMC_ATTR8_MPRIV                   \ master privileged


\
\ @brief RIFSC RIMC master attribute register 9
\ Address offset: 0xC34
\ Reset value: 0x00000000
\

$00000070 constant RIFSC_S_RIFSC_RIMC_ATTR9_MCID                    \ master CID
$00000100 constant RIFSC_S_RIFSC_RIMC_ATTR9_MSEC                    \ master secure
$00000200 constant RIFSC_S_RIFSC_RIMC_ATTR9_MPRIV                   \ master privileged


\
\ @brief RIFSC RIMC master attribute register 10
\ Address offset: 0xC38
\ Reset value: 0x00000000
\

$00000070 constant RIFSC_S_RIFSC_RIMC_ATTR10_MCID                   \ master CID
$00000100 constant RIFSC_S_RIFSC_RIMC_ATTR10_MSEC                   \ master secure
$00000200 constant RIFSC_S_RIFSC_RIMC_ATTR10_MPRIV                  \ master privileged


\
\ @brief RIFSC RIMC master attribute register 11
\ Address offset: 0xC3C
\ Reset value: 0x00000000
\

$00000070 constant RIFSC_S_RIFSC_RIMC_ATTR11_MCID                   \ master CID
$00000100 constant RIFSC_S_RIFSC_RIMC_ATTR11_MSEC                   \ master secure
$00000200 constant RIFSC_S_RIFSC_RIMC_ATTR11_MPRIV                  \ master privileged


\
\ @brief RIFSC peripheral protection status register 0
\ Address offset: 0xFB0
\ Reset value: 0xFFFFFF7F
\

$00000001 constant RIFSC_S_RIFSC_PPSR0_PPEN0                        \ peripheral protection enable 0
$00000002 constant RIFSC_S_RIFSC_PPSR0_PPEN1                        \ peripheral protection enable 1
$00000004 constant RIFSC_S_RIFSC_PPSR0_PPEN2                        \ peripheral protection enable 2
$00000008 constant RIFSC_S_RIFSC_PPSR0_PPEN3                        \ peripheral protection enable 3
$00000010 constant RIFSC_S_RIFSC_PPSR0_PPEN4                        \ peripheral protection enable 4
$00000020 constant RIFSC_S_RIFSC_PPSR0_PPEN5                        \ peripheral protection enable 5
$00000040 constant RIFSC_S_RIFSC_PPSR0_PPEN6                        \ peripheral protection enable 6
$00000080 constant RIFSC_S_RIFSC_PPSR0_PPEN7                        \ peripheral protection enable 7
$00000100 constant RIFSC_S_RIFSC_PPSR0_PPEN8                        \ peripheral protection enable 8
$00000200 constant RIFSC_S_RIFSC_PPSR0_PPEN9                        \ peripheral protection enable 9
$00000400 constant RIFSC_S_RIFSC_PPSR0_PPEN10                       \ peripheral protection enable 10
$00000800 constant RIFSC_S_RIFSC_PPSR0_PPEN11                       \ peripheral protection enable 11
$00001000 constant RIFSC_S_RIFSC_PPSR0_PPEN12                       \ peripheral protection enable 12
$00002000 constant RIFSC_S_RIFSC_PPSR0_PPEN13                       \ peripheral protection enable 13
$00004000 constant RIFSC_S_RIFSC_PPSR0_PPEN14                       \ peripheral protection enable 14
$00008000 constant RIFSC_S_RIFSC_PPSR0_PPEN15                       \ peripheral protection enable 15
$00010000 constant RIFSC_S_RIFSC_PPSR0_PPEN16                       \ peripheral protection enable 16
$00020000 constant RIFSC_S_RIFSC_PPSR0_PPEN17                       \ peripheral protection enable 17
$00040000 constant RIFSC_S_RIFSC_PPSR0_PPEN18                       \ peripheral protection enable 18
$00080000 constant RIFSC_S_RIFSC_PPSR0_PPEN19                       \ peripheral protection enable 19
$00100000 constant RIFSC_S_RIFSC_PPSR0_PPEN20                       \ peripheral protection enable 20
$00200000 constant RIFSC_S_RIFSC_PPSR0_PPEN21                       \ peripheral protection enable 21
$00400000 constant RIFSC_S_RIFSC_PPSR0_PPEN22                       \ peripheral protection enable 22
$00800000 constant RIFSC_S_RIFSC_PPSR0_PPEN23                       \ peripheral protection enable 23
$01000000 constant RIFSC_S_RIFSC_PPSR0_PPEN24                       \ peripheral protection enable 24
$02000000 constant RIFSC_S_RIFSC_PPSR0_PPEN25                       \ peripheral protection enable 25
$04000000 constant RIFSC_S_RIFSC_PPSR0_PPEN26                       \ peripheral protection enable 26
$08000000 constant RIFSC_S_RIFSC_PPSR0_PPEN27                       \ peripheral protection enable 27
$10000000 constant RIFSC_S_RIFSC_PPSR0_PPEN28                       \ peripheral protection enable 28
$20000000 constant RIFSC_S_RIFSC_PPSR0_PPEN29                       \ peripheral protection enable 29
$40000000 constant RIFSC_S_RIFSC_PPSR0_PPEN30                       \ peripheral protection enable 30
$80000000 constant RIFSC_S_RIFSC_PPSR0_PPEN31                       \ peripheral protection enable 31


\
\ @brief RIFSC peripheral protection status register 1
\ Address offset: 0xFB4
\ Reset value: 0x77FFFFFF
\

$00000001 constant RIFSC_S_RIFSC_PPSR1_PPEN32                       \ peripheral protection enable 32
$00000002 constant RIFSC_S_RIFSC_PPSR1_PPEN33                       \ peripheral protection enable 33
$00000004 constant RIFSC_S_RIFSC_PPSR1_PPEN34                       \ peripheral protection enable 34
$00000008 constant RIFSC_S_RIFSC_PPSR1_PPEN35                       \ peripheral protection enable 35
$00000010 constant RIFSC_S_RIFSC_PPSR1_PPEN36                       \ peripheral protection enable 36
$00000020 constant RIFSC_S_RIFSC_PPSR1_PPEN37                       \ peripheral protection enable 37
$00000040 constant RIFSC_S_RIFSC_PPSR1_PPEN38                       \ peripheral protection enable 38
$00000080 constant RIFSC_S_RIFSC_PPSR1_PPEN39                       \ peripheral protection enable 39
$00000100 constant RIFSC_S_RIFSC_PPSR1_PPEN40                       \ peripheral protection enable 40
$00000200 constant RIFSC_S_RIFSC_PPSR1_PPEN41                       \ peripheral protection enable 41
$00000400 constant RIFSC_S_RIFSC_PPSR1_PPEN42                       \ peripheral protection enable 42
$00000800 constant RIFSC_S_RIFSC_PPSR1_PPEN43                       \ peripheral protection enable 43
$00001000 constant RIFSC_S_RIFSC_PPSR1_PPEN44                       \ peripheral protection enable 44
$00002000 constant RIFSC_S_RIFSC_PPSR1_PPEN45                       \ peripheral protection enable 45
$00004000 constant RIFSC_S_RIFSC_PPSR1_PPEN46                       \ peripheral protection enable 46
$00008000 constant RIFSC_S_RIFSC_PPSR1_PPEN47                       \ peripheral protection enable 47
$00010000 constant RIFSC_S_RIFSC_PPSR1_PPEN48                       \ peripheral protection enable 48
$00020000 constant RIFSC_S_RIFSC_PPSR1_PPEN49                       \ peripheral protection enable 49
$00040000 constant RIFSC_S_RIFSC_PPSR1_PPEN50                       \ peripheral protection enable 50
$00080000 constant RIFSC_S_RIFSC_PPSR1_PPEN51                       \ peripheral protection enable 51
$00100000 constant RIFSC_S_RIFSC_PPSR1_PPEN52                       \ peripheral protection enable 52
$00200000 constant RIFSC_S_RIFSC_PPSR1_PPEN53                       \ peripheral protection enable 53
$00400000 constant RIFSC_S_RIFSC_PPSR1_PPEN54                       \ peripheral protection enable 54
$00800000 constant RIFSC_S_RIFSC_PPSR1_PPEN55                       \ peripheral protection enable 55
$01000000 constant RIFSC_S_RIFSC_PPSR1_PPEN56                       \ peripheral protection enable 56
$02000000 constant RIFSC_S_RIFSC_PPSR1_PPEN57                       \ peripheral protection enable 57
$04000000 constant RIFSC_S_RIFSC_PPSR1_PPEN58                       \ peripheral protection enable 58
$08000000 constant RIFSC_S_RIFSC_PPSR1_PPEN59                       \ peripheral protection enable 59
$10000000 constant RIFSC_S_RIFSC_PPSR1_PPEN60                       \ peripheral protection enable 60
$20000000 constant RIFSC_S_RIFSC_PPSR1_PPEN61                       \ peripheral protection enable 61
$40000000 constant RIFSC_S_RIFSC_PPSR1_PPEN62                       \ peripheral protection enable 62
$80000000 constant RIFSC_S_RIFSC_PPSR1_PPEN63                       \ peripheral protection enable 63


\
\ @brief RIFSC peripheral protection status register 2
\ Address offset: 0xFB8
\ Reset value: 0xF7DFF03B
\

$00000001 constant RIFSC_S_RIFSC_PPSR2_PPEN64                       \ peripheral protection enable 64
$00000002 constant RIFSC_S_RIFSC_PPSR2_PPEN65                       \ peripheral protection enable 65
$00000004 constant RIFSC_S_RIFSC_PPSR2_PPEN66                       \ peripheral protection enable 66
$00000008 constant RIFSC_S_RIFSC_PPSR2_PPEN67                       \ peripheral protection enable 67
$00000010 constant RIFSC_S_RIFSC_PPSR2_PPEN68                       \ peripheral protection enable 68
$00000020 constant RIFSC_S_RIFSC_PPSR2_PPEN69                       \ peripheral protection enable 69
$00000040 constant RIFSC_S_RIFSC_PPSR2_PPEN70                       \ peripheral protection enable 70
$00000080 constant RIFSC_S_RIFSC_PPSR2_PPEN71                       \ peripheral protection enable 71
$00000100 constant RIFSC_S_RIFSC_PPSR2_PPEN72                       \ peripheral protection enable 72
$00000200 constant RIFSC_S_RIFSC_PPSR2_PPEN73                       \ peripheral protection enable 73
$00000400 constant RIFSC_S_RIFSC_PPSR2_PPEN74                       \ peripheral protection enable 74
$00000800 constant RIFSC_S_RIFSC_PPSR2_PPEN75                       \ peripheral protection enable 75
$00001000 constant RIFSC_S_RIFSC_PPSR2_PPEN76                       \ peripheral protection enable 76
$00002000 constant RIFSC_S_RIFSC_PPSR2_PPEN77                       \ peripheral protection enable 77
$00004000 constant RIFSC_S_RIFSC_PPSR2_PPEN78                       \ peripheral protection enable 78
$00008000 constant RIFSC_S_RIFSC_PPSR2_PPEN79                       \ peripheral protection enable 79
$00010000 constant RIFSC_S_RIFSC_PPSR2_PPEN80                       \ peripheral protection enable 80
$00020000 constant RIFSC_S_RIFSC_PPSR2_PPEN81                       \ peripheral protection enable 81
$00040000 constant RIFSC_S_RIFSC_PPSR2_PPEN82                       \ peripheral protection enable 82
$00080000 constant RIFSC_S_RIFSC_PPSR2_PPEN83                       \ peripheral protection enable 83
$00100000 constant RIFSC_S_RIFSC_PPSR2_PPEN84                       \ peripheral protection enable 84
$00200000 constant RIFSC_S_RIFSC_PPSR2_PPEN85                       \ peripheral protection enable 85
$00400000 constant RIFSC_S_RIFSC_PPSR2_PPEN86                       \ peripheral protection enable 86
$00800000 constant RIFSC_S_RIFSC_PPSR2_PPEN87                       \ peripheral protection enable 87
$01000000 constant RIFSC_S_RIFSC_PPSR2_PPEN88                       \ peripheral protection enable 88
$02000000 constant RIFSC_S_RIFSC_PPSR2_PPEN89                       \ peripheral protection enable 89
$04000000 constant RIFSC_S_RIFSC_PPSR2_PPEN90                       \ peripheral protection enable 90
$08000000 constant RIFSC_S_RIFSC_PPSR2_PPEN91                       \ peripheral protection enable 91
$10000000 constant RIFSC_S_RIFSC_PPSR2_PPEN92                       \ peripheral protection enable 92
$20000000 constant RIFSC_S_RIFSC_PPSR2_PPEN93                       \ peripheral protection enable 93
$40000000 constant RIFSC_S_RIFSC_PPSR2_PPEN94                       \ peripheral protection enable 94
$80000000 constant RIFSC_S_RIFSC_PPSR2_PPEN95                       \ peripheral protection enable 95


\
\ @brief RIFSC peripheral protection status register 3
\ Address offset: 0xFBC
\ Reset value: 0x000005FF
\

$00000001 constant RIFSC_S_RIFSC_PPSR3_PPEN96                       \ peripheral protection enable 96
$00000002 constant RIFSC_S_RIFSC_PPSR3_PPEN97                       \ peripheral protection enable 97
$00000004 constant RIFSC_S_RIFSC_PPSR3_PPEN98                       \ peripheral protection enable 98
$00000008 constant RIFSC_S_RIFSC_PPSR3_PPEN99                       \ peripheral protection enable 99
$00000010 constant RIFSC_S_RIFSC_PPSR3_PPEN100                      \ peripheral protection enable 100
$00000020 constant RIFSC_S_RIFSC_PPSR3_PPEN101                      \ peripheral protection enable 101
$00000040 constant RIFSC_S_RIFSC_PPSR3_PPEN102                      \ peripheral protection enable 102
$00000080 constant RIFSC_S_RIFSC_PPSR3_PPEN103                      \ peripheral protection enable 103
$00000100 constant RIFSC_S_RIFSC_PPSR3_PPEN104                      \ peripheral protection enable 104
$00000200 constant RIFSC_S_RIFSC_PPSR3_PPEN105                      \ peripheral protection enable 105
$00000400 constant RIFSC_S_RIFSC_PPSR3_PPEN106                      \ peripheral protection enable 106
$00000800 constant RIFSC_S_RIFSC_PPSR3_PPEN107                      \ peripheral protection enable 107
$00001000 constant RIFSC_S_RIFSC_PPSR3_PPEN108                      \ peripheral protection enable 108
$00002000 constant RIFSC_S_RIFSC_PPSR3_PPEN109                      \ peripheral protection enable 109
$00004000 constant RIFSC_S_RIFSC_PPSR3_PPEN110                      \ peripheral protection enable 110
$00008000 constant RIFSC_S_RIFSC_PPSR3_PPEN111                      \ peripheral protection enable 111
$00010000 constant RIFSC_S_RIFSC_PPSR3_PPEN112                      \ peripheral protection enable 112
$00020000 constant RIFSC_S_RIFSC_PPSR3_PPEN113                      \ peripheral protection enable 113
$00040000 constant RIFSC_S_RIFSC_PPSR3_PPEN114                      \ peripheral protection enable 114
$00080000 constant RIFSC_S_RIFSC_PPSR3_PPEN115                      \ peripheral protection enable 115
$00100000 constant RIFSC_S_RIFSC_PPSR3_PPEN116                      \ peripheral protection enable 116
$00200000 constant RIFSC_S_RIFSC_PPSR3_PPEN117                      \ peripheral protection enable 117
$00400000 constant RIFSC_S_RIFSC_PPSR3_PPEN118                      \ peripheral protection enable 118
$00800000 constant RIFSC_S_RIFSC_PPSR3_PPEN119                      \ peripheral protection enable 119
$01000000 constant RIFSC_S_RIFSC_PPSR3_PPEN120                      \ peripheral protection enable 120
$02000000 constant RIFSC_S_RIFSC_PPSR3_PPEN121                      \ peripheral protection enable 121
$04000000 constant RIFSC_S_RIFSC_PPSR3_PPEN122                      \ peripheral protection enable 122
$08000000 constant RIFSC_S_RIFSC_PPSR3_PPEN123                      \ peripheral protection enable 123
$10000000 constant RIFSC_S_RIFSC_PPSR3_PPEN124                      \ peripheral protection enable 124
$20000000 constant RIFSC_S_RIFSC_PPSR3_PPEN125                      \ peripheral protection enable 125
$40000000 constant RIFSC_S_RIFSC_PPSR3_PPEN126                      \ peripheral protection enable 126
$80000000 constant RIFSC_S_RIFSC_PPSR3_PPEN127                      \ peripheral protection enable 127


\
\ @brief RIFSC peripheral protection status register 4
\ Address offset: 0xFC0
\ Reset value: 0x3A0E382E
\

$00000001 constant RIFSC_S_RIFSC_PPSR4_PPEN128                      \ peripheral protection enable 128
$00000002 constant RIFSC_S_RIFSC_PPSR4_PPEN129                      \ peripheral protection enable 129
$00000004 constant RIFSC_S_RIFSC_PPSR4_PPEN130                      \ peripheral protection enable 130
$00000008 constant RIFSC_S_RIFSC_PPSR4_PPEN131                      \ peripheral protection enable 131
$00000010 constant RIFSC_S_RIFSC_PPSR4_PPEN132                      \ peripheral protection enable 132
$00000020 constant RIFSC_S_RIFSC_PPSR4_PPEN133                      \ peripheral protection enable 133
$00000040 constant RIFSC_S_RIFSC_PPSR4_PPEN134                      \ peripheral protection enable 134
$00000080 constant RIFSC_S_RIFSC_PPSR4_PPEN135                      \ peripheral protection enable 135
$00000100 constant RIFSC_S_RIFSC_PPSR4_PPEN136                      \ peripheral protection enable 136
$00000200 constant RIFSC_S_RIFSC_PPSR4_PPEN137                      \ peripheral protection enable 137
$00000400 constant RIFSC_S_RIFSC_PPSR4_PPEN138                      \ peripheral protection enable 138
$00000800 constant RIFSC_S_RIFSC_PPSR4_PPEN139                      \ peripheral protection enable 139
$00001000 constant RIFSC_S_RIFSC_PPSR4_PPEN140                      \ peripheral protection enable 140
$00002000 constant RIFSC_S_RIFSC_PPSR4_PPEN141                      \ peripheral protection enable 141
$00004000 constant RIFSC_S_RIFSC_PPSR4_PPEN142                      \ peripheral protection enable 142
$00008000 constant RIFSC_S_RIFSC_PPSR4_PPEN143                      \ peripheral protection enable 143
$00010000 constant RIFSC_S_RIFSC_PPSR4_PPEN144                      \ peripheral protection enable 144
$00020000 constant RIFSC_S_RIFSC_PPSR4_PPEN145                      \ peripheral protection enable 145
$00040000 constant RIFSC_S_RIFSC_PPSR4_PPEN146                      \ peripheral protection enable 146
$00080000 constant RIFSC_S_RIFSC_PPSR4_PPEN147                      \ peripheral protection enable 147
$00100000 constant RIFSC_S_RIFSC_PPSR4_PPEN148                      \ peripheral protection enable 148
$00200000 constant RIFSC_S_RIFSC_PPSR4_PPEN149                      \ peripheral protection enable 149
$00400000 constant RIFSC_S_RIFSC_PPSR4_PPEN150                      \ peripheral protection enable 150
$00800000 constant RIFSC_S_RIFSC_PPSR4_PPEN151                      \ peripheral protection enable 151
$01000000 constant RIFSC_S_RIFSC_PPSR4_PPEN152                      \ peripheral protection enable 152
$02000000 constant RIFSC_S_RIFSC_PPSR4_PPEN153                      \ peripheral protection enable 153
$04000000 constant RIFSC_S_RIFSC_PPSR4_PPEN154                      \ peripheral protection enable 154
$08000000 constant RIFSC_S_RIFSC_PPSR4_PPEN155                      \ peripheral protection enable 155
$10000000 constant RIFSC_S_RIFSC_PPSR4_PPEN156                      \ peripheral protection enable 156
$20000000 constant RIFSC_S_RIFSC_PPSR4_PPEN157                      \ peripheral protection enable 157
$40000000 constant RIFSC_S_RIFSC_PPSR4_PPEN158                      \ peripheral protection enable 158
$80000000 constant RIFSC_S_RIFSC_PPSR4_PPEN159                      \ peripheral protection enable 159


\
\ @brief RIFSC peripheral protection status register 5
\ Address offset: 0xFC4
\ Reset value: 0x3DDEEF7F
\

$00000001 constant RIFSC_S_RIFSC_PPSR5_PPEN160                      \ peripheral protection enable 160
$00000002 constant RIFSC_S_RIFSC_PPSR5_PPEN161                      \ peripheral protection enable 161
$00000004 constant RIFSC_S_RIFSC_PPSR5_PPEN162                      \ peripheral protection enable 162
$00000008 constant RIFSC_S_RIFSC_PPSR5_PPEN163                      \ peripheral protection enable 163
$00000010 constant RIFSC_S_RIFSC_PPSR5_PPEN164                      \ peripheral protection enable 164
$00000020 constant RIFSC_S_RIFSC_PPSR5_PPEN165                      \ peripheral protection enable 165
$00000040 constant RIFSC_S_RIFSC_PPSR5_PPEN166                      \ peripheral protection enable 166
$00000080 constant RIFSC_S_RIFSC_PPSR5_PPEN167                      \ peripheral protection enable 167
$00000100 constant RIFSC_S_RIFSC_PPSR5_PPEN168                      \ peripheral protection enable 168
$00000200 constant RIFSC_S_RIFSC_PPSR5_PPEN169                      \ peripheral protection enable 169
$00000400 constant RIFSC_S_RIFSC_PPSR5_PPEN170                      \ peripheral protection enable 170
$00000800 constant RIFSC_S_RIFSC_PPSR5_PPEN171                      \ peripheral protection enable 171
$00001000 constant RIFSC_S_RIFSC_PPSR5_PPEN172                      \ peripheral protection enable 172
$00002000 constant RIFSC_S_RIFSC_PPSR5_PPEN173                      \ peripheral protection enable 173
$00004000 constant RIFSC_S_RIFSC_PPSR5_PPEN174                      \ peripheral protection enable 174
$00008000 constant RIFSC_S_RIFSC_PPSR5_PPEN175                      \ peripheral protection enable 175
$00010000 constant RIFSC_S_RIFSC_PPSR5_PPEN176                      \ peripheral protection enable 176
$00020000 constant RIFSC_S_RIFSC_PPSR5_PPEN177                      \ peripheral protection enable 177
$00040000 constant RIFSC_S_RIFSC_PPSR5_PPEN178                      \ peripheral protection enable 178
$00080000 constant RIFSC_S_RIFSC_PPSR5_PPEN179                      \ peripheral protection enable 179
$00100000 constant RIFSC_S_RIFSC_PPSR5_PPEN180                      \ peripheral protection enable 180
$00200000 constant RIFSC_S_RIFSC_PPSR5_PPEN181                      \ peripheral protection enable 181
$00400000 constant RIFSC_S_RIFSC_PPSR5_PPEN182                      \ peripheral protection enable 182
$00800000 constant RIFSC_S_RIFSC_PPSR5_PPEN183                      \ peripheral protection enable 183
$01000000 constant RIFSC_S_RIFSC_PPSR5_PPEN184                      \ peripheral protection enable 184
$02000000 constant RIFSC_S_RIFSC_PPSR5_PPEN185                      \ peripheral protection enable 185
$04000000 constant RIFSC_S_RIFSC_PPSR5_PPEN186                      \ peripheral protection enable 186
$08000000 constant RIFSC_S_RIFSC_PPSR5_PPEN187                      \ peripheral protection enable 187
$10000000 constant RIFSC_S_RIFSC_PPSR5_PPEN188                      \ peripheral protection enable 188
$20000000 constant RIFSC_S_RIFSC_PPSR5_PPEN189                      \ peripheral protection enable 189
$40000000 constant RIFSC_S_RIFSC_PPSR5_PPEN190                      \ peripheral protection enable 190
$80000000 constant RIFSC_S_RIFSC_PPSR5_PPEN191                      \ peripheral protection enable 191


\
\ @brief Resource isolation framework security controller
\
$54024000 constant RIFSC_S_RIFSC_RISC_CR  \ offset: 0x00 : RIFSC RISC slave configuration register x
$54024010 constant RIFSC_S_RIFSC_RISC_SECCFGR0  \ offset: 0x10 : RIFSC RISC slave security configuration register 0
$54024014 constant RIFSC_S_RIFSC_RISC_SECCFGR1  \ offset: 0x14 : RIFSC RISC slave security configuration register 1
$54024018 constant RIFSC_S_RIFSC_RISC_SECCFGR2  \ offset: 0x18 : RIFSC RISC slave security configuration register 2
$5402401c constant RIFSC_S_RIFSC_RISC_SECCFGR3  \ offset: 0x1C : RIFSC RISC slave security configuration register 3
$54024020 constant RIFSC_S_RIFSC_RISC_SECCFGR4  \ offset: 0x20 : RIFSC RISC slave security configuration register 4
$54024024 constant RIFSC_S_RIFSC_RISC_SECCFGR5  \ offset: 0x24 : RIFSC RISC slave security configuration register 5
$54024030 constant RIFSC_S_RIFSC_RISC_PRIVCFGR0  \ offset: 0x30 : RIFSC RISFC slave privileged register 0
$54024034 constant RIFSC_S_RIFSC_RISC_PRIVCFGR1  \ offset: 0x34 : RIFSC RISFC slave privileged register 1
$54024038 constant RIFSC_S_RIFSC_RISC_PRIVCFGR2  \ offset: 0x38 : RIFSC RISFC slave privileged register 2
$5402403c constant RIFSC_S_RIFSC_RISC_PRIVCFGR3  \ offset: 0x3C : RIFSC RISFC slave privileged register 3
$54024040 constant RIFSC_S_RIFSC_RISC_PRIVCFGR4  \ offset: 0x40 : RIFSC RISFC slave privileged register 4
$54024044 constant RIFSC_S_RIFSC_RISC_PRIVCFGR5  \ offset: 0x44 : RIFSC RISFC slave privileged register 5
$54024050 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR0  \ offset: 0x50 : RIFSC RISC slave resource configuration lock register 0
$54024054 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR1  \ offset: 0x54 : RIFSC RISC slave resource configuration lock register 1
$54024058 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR2  \ offset: 0x58 : RIFSC RISC slave resource configuration lock register 2
$5402405c constant RIFSC_S_RIFSC_RISC_RCFGLOCKR3  \ offset: 0x5C : RIFSC RISC slave resource configuration lock register 3
$54024060 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR4  \ offset: 0x60 : RIFSC RISC slave resource configuration lock register 4
$54024064 constant RIFSC_S_RIFSC_RISC_RCFGLOCKR5  \ offset: 0x64 : RIFSC RISC slave resource configuration lock register 5
$54024c00 constant RIFSC_S_RIFSC_RIMC_CR  \ offset: 0xC00 : RIFSC RIMC master configuration register
$54024c10 constant RIFSC_S_RIFSC_RIMC_ATTR0  \ offset: 0xC10 : RIFSC RIMC master attribute register 0
$54024c14 constant RIFSC_S_RIFSC_RIMC_ATTR1  \ offset: 0xC14 : RIFSC RIMC master attribute register 1
$54024c18 constant RIFSC_S_RIFSC_RIMC_ATTR2  \ offset: 0xC18 : RIFSC RIMC master attribute register 2
$54024c1c constant RIFSC_S_RIFSC_RIMC_ATTR3  \ offset: 0xC1C : RIFSC RIMC master attribute register 3
$54024c20 constant RIFSC_S_RIFSC_RIMC_ATTR4  \ offset: 0xC20 : RIFSC RIMC master attribute register 4
$54024c24 constant RIFSC_S_RIFSC_RIMC_ATTR5  \ offset: 0xC24 : RIFSC RIMC master attribute register 5
$54024c28 constant RIFSC_S_RIFSC_RIMC_ATTR6  \ offset: 0xC28 : RIFSC RIMC master attribute register 6
$54024c2c constant RIFSC_S_RIFSC_RIMC_ATTR7  \ offset: 0xC2C : RIFSC RIMC master attribute register 7
$54024c30 constant RIFSC_S_RIFSC_RIMC_ATTR8  \ offset: 0xC30 : RIFSC RIMC master attribute register 8
$54024c34 constant RIFSC_S_RIFSC_RIMC_ATTR9  \ offset: 0xC34 : RIFSC RIMC master attribute register 9
$54024c38 constant RIFSC_S_RIFSC_RIMC_ATTR10  \ offset: 0xC38 : RIFSC RIMC master attribute register 10
$54024c3c constant RIFSC_S_RIFSC_RIMC_ATTR11  \ offset: 0xC3C : RIFSC RIMC master attribute register 11
$54024fb0 constant RIFSC_S_RIFSC_PPSR0  \ offset: 0xFB0 : RIFSC peripheral protection status register 0
$54024fb4 constant RIFSC_S_RIFSC_PPSR1  \ offset: 0xFB4 : RIFSC peripheral protection status register 1
$54024fb8 constant RIFSC_S_RIFSC_PPSR2  \ offset: 0xFB8 : RIFSC peripheral protection status register 2
$54024fbc constant RIFSC_S_RIFSC_PPSR3  \ offset: 0xFBC : RIFSC peripheral protection status register 3
$54024fc0 constant RIFSC_S_RIFSC_PPSR4  \ offset: 0xFC0 : RIFSC peripheral protection status register 4
$54024fc4 constant RIFSC_S_RIFSC_PPSR5  \ offset: 0xFC4 : RIFSC peripheral protection status register 5

