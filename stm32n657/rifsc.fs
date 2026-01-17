\
\ @file rifsc.fs
\ @brief Resource isolation framework security controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RIFSC_DEF

  [ifdef] RIFSC_RIFSC_RISC_CR_DEF
    \
    \ @brief RIFSC RISC slave configuration register x
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant RIFSC_GLOCK                    \ [0x00] Global lock
  [then]


  [ifdef] RIFSC_RIFSC_RISC_SECCFGR0_DEF
    \
    \ @brief RIFSC RISC slave security configuration register 0
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant RIFSC_SEC0                     \ [0x00] security configuration for peripheral 0
    $01 constant RIFSC_SEC1                     \ [0x01] security configuration for peripheral 1
    $02 constant RIFSC_SEC2                     \ [0x02] security configuration for peripheral 2
    $03 constant RIFSC_SEC3                     \ [0x03] security configuration for peripheral 3
    $04 constant RIFSC_SEC4                     \ [0x04] security configuration for peripheral 4
    $05 constant RIFSC_SEC5                     \ [0x05] security configuration for peripheral 5
    $06 constant RIFSC_SEC6                     \ [0x06] security configuration for peripheral 6
    $07 constant RIFSC_SEC7                     \ [0x07] security configuration for peripheral 7
    $08 constant RIFSC_SEC8                     \ [0x08] security configuration for peripheral 8
    $09 constant RIFSC_SEC9                     \ [0x09] security configuration for peripheral 9
    $0a constant RIFSC_SEC10                    \ [0x0a] security configuration for peripheral 10
    $0b constant RIFSC_SEC11                    \ [0x0b] security configuration for peripheral 11
    $0c constant RIFSC_SEC12                    \ [0x0c] security configuration for peripheral 12
    $0d constant RIFSC_SEC13                    \ [0x0d] security configuration for peripheral 13
    $0e constant RIFSC_SEC14                    \ [0x0e] security configuration for peripheral 14
    $0f constant RIFSC_SEC15                    \ [0x0f] security configuration for peripheral 15
    $10 constant RIFSC_SEC16                    \ [0x10] security configuration for peripheral 16
    $11 constant RIFSC_SEC17                    \ [0x11] security configuration for peripheral 17
    $12 constant RIFSC_SEC18                    \ [0x12] security configuration for peripheral 18
    $13 constant RIFSC_SEC19                    \ [0x13] security configuration for peripheral 19
    $14 constant RIFSC_SEC20                    \ [0x14] security configuration for peripheral 20
    $15 constant RIFSC_SEC21                    \ [0x15] security configuration for peripheral 21
    $16 constant RIFSC_SEC22                    \ [0x16] security configuration for peripheral 22
    $17 constant RIFSC_SEC23                    \ [0x17] security configuration for peripheral 23
    $18 constant RIFSC_SEC24                    \ [0x18] security configuration for peripheral 24
    $19 constant RIFSC_SEC25                    \ [0x19] security configuration for peripheral 25
    $1a constant RIFSC_SEC26                    \ [0x1a] security configuration for peripheral 26
    $1b constant RIFSC_SEC27                    \ [0x1b] security configuration for peripheral 27
    $1c constant RIFSC_SEC28                    \ [0x1c] security configuration for peripheral 28
    $1d constant RIFSC_SEC29                    \ [0x1d] security configuration for peripheral 29
    $1e constant RIFSC_SEC30                    \ [0x1e] security configuration for peripheral 30
    $1f constant RIFSC_SEC31                    \ [0x1f] security configuration for peripheral 31
  [then]


  [ifdef] RIFSC_RIFSC_RISC_SECCFGR1_DEF
    \
    \ @brief RIFSC RISC slave security configuration register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant RIFSC_SEC32                    \ [0x00] security configuration for peripheral 32
    $01 constant RIFSC_SEC33                    \ [0x01] security configuration for peripheral 33
    $02 constant RIFSC_SEC34                    \ [0x02] security configuration for peripheral 34
    $03 constant RIFSC_SEC35                    \ [0x03] security configuration for peripheral 35
    $04 constant RIFSC_SEC36                    \ [0x04] security configuration for peripheral 36
    $05 constant RIFSC_SEC37                    \ [0x05] security configuration for peripheral 37
    $06 constant RIFSC_SEC38                    \ [0x06] security configuration for peripheral 38
    $07 constant RIFSC_SEC39                    \ [0x07] security configuration for peripheral 39
    $08 constant RIFSC_SEC40                    \ [0x08] security configuration for peripheral 40
    $09 constant RIFSC_SEC41                    \ [0x09] security configuration for peripheral 41
    $0a constant RIFSC_SEC42                    \ [0x0a] security configuration for peripheral 42
    $0b constant RIFSC_SEC43                    \ [0x0b] security configuration for peripheral 43
    $0c constant RIFSC_SEC44                    \ [0x0c] security configuration for peripheral 44
    $0d constant RIFSC_SEC45                    \ [0x0d] security configuration for peripheral 45
    $0e constant RIFSC_SEC46                    \ [0x0e] security configuration for peripheral 46
    $0f constant RIFSC_SEC47                    \ [0x0f] security configuration for peripheral 47
    $10 constant RIFSC_SEC48                    \ [0x10] security configuration for peripheral 48
    $11 constant RIFSC_SEC49                    \ [0x11] security configuration for peripheral 49
    $12 constant RIFSC_SEC50                    \ [0x12] security configuration for peripheral 50
    $13 constant RIFSC_SEC51                    \ [0x13] security configuration for peripheral 51
    $14 constant RIFSC_SEC52                    \ [0x14] security configuration for peripheral 52
    $15 constant RIFSC_SEC53                    \ [0x15] security configuration for peripheral 53
    $16 constant RIFSC_SEC54                    \ [0x16] security configuration for peripheral 54
    $17 constant RIFSC_SEC55                    \ [0x17] security configuration for peripheral 55
    $18 constant RIFSC_SEC56                    \ [0x18] security configuration for peripheral 56
    $19 constant RIFSC_SEC57                    \ [0x19] security configuration for peripheral 57
    $1a constant RIFSC_SEC58                    \ [0x1a] security configuration for peripheral 58
    $1b constant RIFSC_SEC59                    \ [0x1b] security configuration for peripheral 59
    $1c constant RIFSC_SEC60                    \ [0x1c] security configuration for peripheral 60
    $1d constant RIFSC_SEC61                    \ [0x1d] security configuration for peripheral 61
    $1e constant RIFSC_SEC62                    \ [0x1e] security configuration for peripheral 62
    $1f constant RIFSC_SEC63                    \ [0x1f] security configuration for peripheral 63
  [then]


  [ifdef] RIFSC_RIFSC_RISC_SECCFGR2_DEF
    \
    \ @brief RIFSC RISC slave security configuration register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RIFSC_SEC64                    \ [0x00] security configuration for peripheral 64
    $01 constant RIFSC_SEC65                    \ [0x01] security configuration for peripheral 65
    $02 constant RIFSC_SEC66                    \ [0x02] security configuration for peripheral 66
    $03 constant RIFSC_SEC67                    \ [0x03] security configuration for peripheral 67
    $04 constant RIFSC_SEC68                    \ [0x04] security configuration for peripheral 68
    $05 constant RIFSC_SEC69                    \ [0x05] security configuration for peripheral 69
    $06 constant RIFSC_SEC70                    \ [0x06] security configuration for peripheral 70
    $07 constant RIFSC_SEC71                    \ [0x07] security configuration for peripheral 71
    $08 constant RIFSC_SEC72                    \ [0x08] security configuration for peripheral 72
    $09 constant RIFSC_SEC73                    \ [0x09] security configuration for peripheral 73
    $0a constant RIFSC_SEC74                    \ [0x0a] security configuration for peripheral 74
    $0b constant RIFSC_SEC75                    \ [0x0b] security configuration for peripheral 75
    $0c constant RIFSC_SEC76                    \ [0x0c] security configuration for peripheral 76
    $0d constant RIFSC_SEC77                    \ [0x0d] security configuration for peripheral 77
    $0e constant RIFSC_SEC78                    \ [0x0e] security configuration for peripheral 78
    $0f constant RIFSC_SEC79                    \ [0x0f] security configuration for peripheral 79
    $10 constant RIFSC_SEC80                    \ [0x10] security configuration for peripheral 80
    $11 constant RIFSC_SEC81                    \ [0x11] security configuration for peripheral 81
    $12 constant RIFSC_SEC82                    \ [0x12] security configuration for peripheral 82
    $13 constant RIFSC_SEC83                    \ [0x13] security configuration for peripheral 83
    $14 constant RIFSC_SEC84                    \ [0x14] security configuration for peripheral 84
    $15 constant RIFSC_SEC85                    \ [0x15] security configuration for peripheral 85
    $16 constant RIFSC_SEC86                    \ [0x16] security configuration for peripheral 86
    $17 constant RIFSC_SEC87                    \ [0x17] security configuration for peripheral 87
    $18 constant RIFSC_SEC88                    \ [0x18] security configuration for peripheral 88
    $19 constant RIFSC_SEC89                    \ [0x19] security configuration for peripheral 89
    $1a constant RIFSC_SEC90                    \ [0x1a] security configuration for peripheral 90
    $1b constant RIFSC_SEC91                    \ [0x1b] security configuration for peripheral 91
    $1c constant RIFSC_SEC92                    \ [0x1c] security configuration for peripheral 92
    $1d constant RIFSC_SEC93                    \ [0x1d] security configuration for peripheral 93
    $1e constant RIFSC_SEC94                    \ [0x1e] security configuration for peripheral 94
    $1f constant RIFSC_SEC95                    \ [0x1f] security configuration for peripheral 95
  [then]


  [ifdef] RIFSC_RIFSC_RISC_SECCFGR3_DEF
    \
    \ @brief RIFSC RISC slave security configuration register 3
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant RIFSC_SEC96                    \ [0x00] security configuration for peripheral 96
    $01 constant RIFSC_SEC97                    \ [0x01] security configuration for peripheral 97
    $02 constant RIFSC_SEC98                    \ [0x02] security configuration for peripheral 98
    $03 constant RIFSC_SEC99                    \ [0x03] security configuration for peripheral 99
    $04 constant RIFSC_SEC100                   \ [0x04] security configuration for peripheral 100
    $05 constant RIFSC_SEC101                   \ [0x05] security configuration for peripheral 101
    $06 constant RIFSC_SEC102                   \ [0x06] security configuration for peripheral 102
    $07 constant RIFSC_SEC103                   \ [0x07] security configuration for peripheral 103
    $08 constant RIFSC_SEC104                   \ [0x08] security configuration for peripheral 104
    $09 constant RIFSC_SEC105                   \ [0x09] security configuration for peripheral 105
    $0a constant RIFSC_SEC106                   \ [0x0a] security configuration for peripheral 106
    $0b constant RIFSC_SEC107                   \ [0x0b] security configuration for peripheral 107
    $0c constant RIFSC_SEC108                   \ [0x0c] security configuration for peripheral 108
    $0d constant RIFSC_SEC109                   \ [0x0d] security configuration for peripheral 109
    $0e constant RIFSC_SEC110                   \ [0x0e] security configuration for peripheral 110
    $0f constant RIFSC_SEC111                   \ [0x0f] security configuration for peripheral 111
    $10 constant RIFSC_SEC112                   \ [0x10] security configuration for peripheral 112
    $11 constant RIFSC_SEC113                   \ [0x11] security configuration for peripheral 113
    $12 constant RIFSC_SEC114                   \ [0x12] security configuration for peripheral 114
    $13 constant RIFSC_SEC115                   \ [0x13] security configuration for peripheral 115
    $14 constant RIFSC_SEC116                   \ [0x14] security configuration for peripheral 116
    $15 constant RIFSC_SEC117                   \ [0x15] security configuration for peripheral 117
    $16 constant RIFSC_SEC118                   \ [0x16] security configuration for peripheral 118
    $17 constant RIFSC_SEC119                   \ [0x17] security configuration for peripheral 119
    $18 constant RIFSC_SEC120                   \ [0x18] security configuration for peripheral 120
    $19 constant RIFSC_SEC121                   \ [0x19] security configuration for peripheral 121
    $1a constant RIFSC_SEC122                   \ [0x1a] security configuration for peripheral 122
    $1b constant RIFSC_SEC123                   \ [0x1b] security configuration for peripheral 123
    $1c constant RIFSC_SEC124                   \ [0x1c] security configuration for peripheral 124
    $1d constant RIFSC_SEC125                   \ [0x1d] security configuration for peripheral 125
    $1e constant RIFSC_SEC126                   \ [0x1e] security configuration for peripheral 126
    $1f constant RIFSC_SEC127                   \ [0x1f] security configuration for peripheral 127
  [then]


  [ifdef] RIFSC_RIFSC_RISC_SECCFGR4_DEF
    \
    \ @brief RIFSC RISC slave security configuration register 4
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant RIFSC_SEC128                   \ [0x00] security configuration for peripheral 128
    $01 constant RIFSC_SEC129                   \ [0x01] security configuration for peripheral 129
    $02 constant RIFSC_SEC130                   \ [0x02] security configuration for peripheral 130
    $03 constant RIFSC_SEC131                   \ [0x03] security configuration for peripheral 131
    $04 constant RIFSC_SEC132                   \ [0x04] security configuration for peripheral 132
    $05 constant RIFSC_SEC133                   \ [0x05] security configuration for peripheral 133
    $06 constant RIFSC_SEC134                   \ [0x06] security configuration for peripheral 134
    $07 constant RIFSC_SEC135                   \ [0x07] security configuration for peripheral 135
    $08 constant RIFSC_SEC136                   \ [0x08] security configuration for peripheral 136
    $09 constant RIFSC_SEC137                   \ [0x09] security configuration for peripheral 137
    $0a constant RIFSC_SEC138                   \ [0x0a] security configuration for peripheral 138
    $0b constant RIFSC_SEC139                   \ [0x0b] security configuration for peripheral 139
    $0c constant RIFSC_SEC140                   \ [0x0c] security configuration for peripheral 140
    $0d constant RIFSC_SEC141                   \ [0x0d] security configuration for peripheral 141
    $0e constant RIFSC_SEC142                   \ [0x0e] security configuration for peripheral 142
    $0f constant RIFSC_SEC143                   \ [0x0f] security configuration for peripheral 143
    $10 constant RIFSC_SEC144                   \ [0x10] security configuration for peripheral 144
    $11 constant RIFSC_SEC145                   \ [0x11] security configuration for peripheral 145
    $12 constant RIFSC_SEC146                   \ [0x12] security configuration for peripheral 146
    $13 constant RIFSC_SEC147                   \ [0x13] security configuration for peripheral 147
    $14 constant RIFSC_SEC148                   \ [0x14] security configuration for peripheral 148
    $15 constant RIFSC_SEC149                   \ [0x15] security configuration for peripheral 149
    $16 constant RIFSC_SEC150                   \ [0x16] security configuration for peripheral 150
    $17 constant RIFSC_SEC151                   \ [0x17] security configuration for peripheral 151
    $18 constant RIFSC_SEC152                   \ [0x18] security configuration for peripheral 152
    $19 constant RIFSC_SEC153                   \ [0x19] security configuration for peripheral 153
    $1a constant RIFSC_SEC154                   \ [0x1a] security configuration for peripheral 154
    $1b constant RIFSC_SEC155                   \ [0x1b] security configuration for peripheral 155
    $1c constant RIFSC_SEC156                   \ [0x1c] security configuration for peripheral 156
    $1d constant RIFSC_SEC157                   \ [0x1d] security configuration for peripheral 157
    $1e constant RIFSC_SEC158                   \ [0x1e] security configuration for peripheral 158
    $1f constant RIFSC_SEC159                   \ [0x1f] security configuration for peripheral 159
  [then]


  [ifdef] RIFSC_RIFSC_RISC_SECCFGR5_DEF
    \
    \ @brief RIFSC RISC slave security configuration register 5
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant RIFSC_SEC160                   \ [0x00] security configuration for peripheral 160
    $01 constant RIFSC_SEC161                   \ [0x01] security configuration for peripheral 161
    $02 constant RIFSC_SEC162                   \ [0x02] security configuration for peripheral 162
    $03 constant RIFSC_SEC163                   \ [0x03] security configuration for peripheral 163
    $04 constant RIFSC_SEC164                   \ [0x04] security configuration for peripheral 164
    $05 constant RIFSC_SEC165                   \ [0x05] security configuration for peripheral 165
    $06 constant RIFSC_SEC166                   \ [0x06] security configuration for peripheral 166
    $07 constant RIFSC_SEC167                   \ [0x07] security configuration for peripheral 167
    $08 constant RIFSC_SEC168                   \ [0x08] security configuration for peripheral 168
    $09 constant RIFSC_SEC169                   \ [0x09] security configuration for peripheral 169
    $0a constant RIFSC_SEC170                   \ [0x0a] security configuration for peripheral 170
    $0b constant RIFSC_SEC171                   \ [0x0b] security configuration for peripheral 171
    $0c constant RIFSC_SEC172                   \ [0x0c] security configuration for peripheral 172
    $0d constant RIFSC_SEC173                   \ [0x0d] security configuration for peripheral 173
    $0e constant RIFSC_SEC174                   \ [0x0e] security configuration for peripheral 174
    $0f constant RIFSC_SEC175                   \ [0x0f] security configuration for peripheral 175
    $10 constant RIFSC_SEC176                   \ [0x10] security configuration for peripheral 176
    $11 constant RIFSC_SEC177                   \ [0x11] security configuration for peripheral 177
    $12 constant RIFSC_SEC178                   \ [0x12] security configuration for peripheral 178
    $13 constant RIFSC_SEC179                   \ [0x13] security configuration for peripheral 179
    $14 constant RIFSC_SEC180                   \ [0x14] security configuration for peripheral 180
    $15 constant RIFSC_SEC181                   \ [0x15] security configuration for peripheral 181
    $16 constant RIFSC_SEC182                   \ [0x16] security configuration for peripheral 182
    $17 constant RIFSC_SEC183                   \ [0x17] security configuration for peripheral 183
    $18 constant RIFSC_SEC184                   \ [0x18] security configuration for peripheral 184
    $19 constant RIFSC_SEC185                   \ [0x19] security configuration for peripheral 185
    $1a constant RIFSC_SEC186                   \ [0x1a] security configuration for peripheral 186
    $1b constant RIFSC_SEC187                   \ [0x1b] security configuration for peripheral 187
    $1c constant RIFSC_SEC188                   \ [0x1c] security configuration for peripheral 188
    $1d constant RIFSC_SEC189                   \ [0x1d] security configuration for peripheral 189
    $1e constant RIFSC_SEC190                   \ [0x1e] security configuration for peripheral 190
    $1f constant RIFSC_SEC191                   \ [0x1f] security configuration for peripheral 191
  [then]


  [ifdef] RIFSC_RIFSC_RISC_PRIVCFGR0_DEF
    \
    \ @brief RIFSC RISFC slave privileged register 0
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant RIFSC_PRIV0                    \ [0x00] privileged-only access permission for peripheral 0
    $01 constant RIFSC_PRIV1                    \ [0x01] privileged-only access permission for peripheral 1
    $02 constant RIFSC_PRIV2                    \ [0x02] privileged-only access permission for peripheral 2
    $03 constant RIFSC_PRIV3                    \ [0x03] privileged-only access permission for peripheral 3
    $04 constant RIFSC_PRIV4                    \ [0x04] privileged-only access permission for peripheral 4
    $05 constant RIFSC_PRIV5                    \ [0x05] privileged-only access permission for peripheral 5
    $06 constant RIFSC_PRIV6                    \ [0x06] privileged-only access permission for peripheral 6
    $07 constant RIFSC_PRIV7                    \ [0x07] privileged-only access permission for peripheral 7
    $08 constant RIFSC_PRIV8                    \ [0x08] privileged-only access permission for peripheral 8
    $09 constant RIFSC_PRIV9                    \ [0x09] privileged-only access permission for peripheral 9
    $0a constant RIFSC_PRIV10                   \ [0x0a] privileged-only access permission for peripheral 10
    $0b constant RIFSC_PRIV11                   \ [0x0b] privileged-only access permission for peripheral 11
    $0c constant RIFSC_PRIV12                   \ [0x0c] privileged-only access permission for peripheral 12
    $0d constant RIFSC_PRIV13                   \ [0x0d] privileged-only access permission for peripheral 13
    $0e constant RIFSC_PRIV14                   \ [0x0e] privileged-only access permission for peripheral 14
    $0f constant RIFSC_PRIV15                   \ [0x0f] privileged-only access permission for peripheral 15
    $10 constant RIFSC_PRIV16                   \ [0x10] privileged-only access permission for peripheral 16
    $11 constant RIFSC_PRIV17                   \ [0x11] privileged-only access permission for peripheral 17
    $12 constant RIFSC_PRIV18                   \ [0x12] privileged-only access permission for peripheral 18
    $13 constant RIFSC_PRIV19                   \ [0x13] privileged-only access permission for peripheral 19
    $14 constant RIFSC_PRIV20                   \ [0x14] privileged-only access permission for peripheral 20
    $15 constant RIFSC_PRIV21                   \ [0x15] privileged-only access permission for peripheral 21
    $16 constant RIFSC_PRIV22                   \ [0x16] privileged-only access permission for peripheral 22
    $17 constant RIFSC_PRIV23                   \ [0x17] privileged-only access permission for peripheral 23
    $18 constant RIFSC_PRIV24                   \ [0x18] privileged-only access permission for peripheral 24
    $19 constant RIFSC_PRIV25                   \ [0x19] privileged-only access permission for peripheral 25
    $1a constant RIFSC_PRIV26                   \ [0x1a] privileged-only access permission for peripheral 26
    $1b constant RIFSC_PRIV27                   \ [0x1b] privileged-only access permission for peripheral 27
    $1c constant RIFSC_PRIV28                   \ [0x1c] privileged-only access permission for peripheral 28
    $1d constant RIFSC_PRIV29                   \ [0x1d] privileged-only access permission for peripheral 29
    $1e constant RIFSC_PRIV30                   \ [0x1e] privileged-only access permission for peripheral 30
    $1f constant RIFSC_PRIV31                   \ [0x1f] privileged-only access permission for peripheral 31
  [then]


  [ifdef] RIFSC_RIFSC_RISC_PRIVCFGR1_DEF
    \
    \ @brief RIFSC RISFC slave privileged register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant RIFSC_PRIV32                   \ [0x00] privileged-only access permission for peripheral 32
    $01 constant RIFSC_PRIV33                   \ [0x01] privileged-only access permission for peripheral 33
    $02 constant RIFSC_PRIV34                   \ [0x02] privileged-only access permission for peripheral 34
    $03 constant RIFSC_PRIV35                   \ [0x03] privileged-only access permission for peripheral 35
    $04 constant RIFSC_PRIV36                   \ [0x04] privileged-only access permission for peripheral 36
    $05 constant RIFSC_PRIV37                   \ [0x05] privileged-only access permission for peripheral 37
    $06 constant RIFSC_PRIV38                   \ [0x06] privileged-only access permission for peripheral 38
    $07 constant RIFSC_PRIV39                   \ [0x07] privileged-only access permission for peripheral 39
    $08 constant RIFSC_PRIV40                   \ [0x08] privileged-only access permission for peripheral 40
    $09 constant RIFSC_PRIV41                   \ [0x09] privileged-only access permission for peripheral 41
    $0a constant RIFSC_PRIV42                   \ [0x0a] privileged-only access permission for peripheral 42
    $0b constant RIFSC_PRIV43                   \ [0x0b] privileged-only access permission for peripheral 43
    $0c constant RIFSC_PRIV44                   \ [0x0c] privileged-only access permission for peripheral 44
    $0d constant RIFSC_PRIV45                   \ [0x0d] privileged-only access permission for peripheral 45
    $0e constant RIFSC_PRIV46                   \ [0x0e] privileged-only access permission for peripheral 46
    $0f constant RIFSC_PRIV47                   \ [0x0f] privileged-only access permission for peripheral 47
    $10 constant RIFSC_PRIV48                   \ [0x10] privileged-only access permission for peripheral 48
    $11 constant RIFSC_PRIV49                   \ [0x11] privileged-only access permission for peripheral 49
    $12 constant RIFSC_PRIV50                   \ [0x12] privileged-only access permission for peripheral 50
    $13 constant RIFSC_PRIV51                   \ [0x13] privileged-only access permission for peripheral 51
    $14 constant RIFSC_PRIV52                   \ [0x14] privileged-only access permission for peripheral 52
    $15 constant RIFSC_PRIV53                   \ [0x15] privileged-only access permission for peripheral 53
    $16 constant RIFSC_PRIV54                   \ [0x16] privileged-only access permission for peripheral 54
    $17 constant RIFSC_PRIV55                   \ [0x17] privileged-only access permission for peripheral 55
    $18 constant RIFSC_PRIV56                   \ [0x18] privileged-only access permission for peripheral 56
    $19 constant RIFSC_PRIV57                   \ [0x19] privileged-only access permission for peripheral 57
    $1a constant RIFSC_PRIV58                   \ [0x1a] privileged-only access permission for peripheral 58
    $1b constant RIFSC_PRIV59                   \ [0x1b] privileged-only access permission for peripheral 59
    $1c constant RIFSC_PRIV60                   \ [0x1c] privileged-only access permission for peripheral 60
    $1d constant RIFSC_PRIV61                   \ [0x1d] privileged-only access permission for peripheral 61
    $1e constant RIFSC_PRIV62                   \ [0x1e] privileged-only access permission for peripheral 62
    $1f constant RIFSC_PRIV63                   \ [0x1f] privileged-only access permission for peripheral 63
  [then]


  [ifdef] RIFSC_RIFSC_RISC_PRIVCFGR2_DEF
    \
    \ @brief RIFSC RISFC slave privileged register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant RIFSC_PRIV64                   \ [0x00] privileged-only access permission for peripheral 64
    $01 constant RIFSC_PRIV65                   \ [0x01] privileged-only access permission for peripheral 65
    $02 constant RIFSC_PRIV66                   \ [0x02] privileged-only access permission for peripheral 66
    $03 constant RIFSC_PRIV67                   \ [0x03] privileged-only access permission for peripheral 67
    $04 constant RIFSC_PRIV68                   \ [0x04] privileged-only access permission for peripheral 68
    $05 constant RIFSC_PRIV69                   \ [0x05] privileged-only access permission for peripheral 69
    $06 constant RIFSC_PRIV70                   \ [0x06] privileged-only access permission for peripheral 70
    $07 constant RIFSC_PRIV71                   \ [0x07] privileged-only access permission for peripheral 71
    $08 constant RIFSC_PRIV72                   \ [0x08] privileged-only access permission for peripheral 72
    $09 constant RIFSC_PRIV73                   \ [0x09] privileged-only access permission for peripheral 73
    $0a constant RIFSC_PRIV74                   \ [0x0a] privileged-only access permission for peripheral 74
    $0b constant RIFSC_PRIV75                   \ [0x0b] privileged-only access permission for peripheral 75
    $0c constant RIFSC_PRIV76                   \ [0x0c] privileged-only access permission for peripheral 76
    $0d constant RIFSC_PRIV77                   \ [0x0d] privileged-only access permission for peripheral 77
    $0e constant RIFSC_PRIV78                   \ [0x0e] privileged-only access permission for peripheral 78
    $0f constant RIFSC_PRIV79                   \ [0x0f] privileged-only access permission for peripheral 79
    $10 constant RIFSC_PRIV80                   \ [0x10] privileged-only access permission for peripheral 80
    $11 constant RIFSC_PRIV81                   \ [0x11] privileged-only access permission for peripheral 81
    $12 constant RIFSC_PRIV82                   \ [0x12] privileged-only access permission for peripheral 82
    $13 constant RIFSC_PRIV83                   \ [0x13] privileged-only access permission for peripheral 83
    $14 constant RIFSC_PRIV84                   \ [0x14] privileged-only access permission for peripheral 84
    $15 constant RIFSC_PRIV85                   \ [0x15] privileged-only access permission for peripheral 85
    $16 constant RIFSC_PRIV86                   \ [0x16] privileged-only access permission for peripheral 86
    $17 constant RIFSC_PRIV87                   \ [0x17] privileged-only access permission for peripheral 87
    $18 constant RIFSC_PRIV88                   \ [0x18] privileged-only access permission for peripheral 88
    $19 constant RIFSC_PRIV89                   \ [0x19] privileged-only access permission for peripheral 89
    $1a constant RIFSC_PRIV90                   \ [0x1a] privileged-only access permission for peripheral 90
    $1b constant RIFSC_PRIV91                   \ [0x1b] privileged-only access permission for peripheral 91
    $1c constant RIFSC_PRIV92                   \ [0x1c] privileged-only access permission for peripheral 92
    $1d constant RIFSC_PRIV93                   \ [0x1d] privileged-only access permission for peripheral 93
    $1e constant RIFSC_PRIV94                   \ [0x1e] privileged-only access permission for peripheral 94
    $1f constant RIFSC_PRIV95                   \ [0x1f] privileged-only access permission for peripheral 95
  [then]


  [ifdef] RIFSC_RIFSC_RISC_PRIVCFGR3_DEF
    \
    \ @brief RIFSC RISFC slave privileged register 3
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant RIFSC_PRIV96                   \ [0x00] privileged-only access permission for peripheral 96
    $01 constant RIFSC_PRIV97                   \ [0x01] privileged-only access permission for peripheral 97
    $02 constant RIFSC_PRIV98                   \ [0x02] privileged-only access permission for peripheral 98
    $03 constant RIFSC_PRIV99                   \ [0x03] privileged-only access permission for peripheral 99
    $04 constant RIFSC_PRIV100                  \ [0x04] privileged-only access permission for peripheral 100
    $05 constant RIFSC_PRIV101                  \ [0x05] privileged-only access permission for peripheral 101
    $06 constant RIFSC_PRIV102                  \ [0x06] privileged-only access permission for peripheral 102
    $07 constant RIFSC_PRIV103                  \ [0x07] privileged-only access permission for peripheral 103
    $08 constant RIFSC_PRIV104                  \ [0x08] privileged-only access permission for peripheral 104
    $09 constant RIFSC_PRIV105                  \ [0x09] privileged-only access permission for peripheral 105
    $0a constant RIFSC_PRIV106                  \ [0x0a] privileged-only access permission for peripheral 106
    $0b constant RIFSC_PRIV107                  \ [0x0b] privileged-only access permission for peripheral 107
    $0c constant RIFSC_PRIV108                  \ [0x0c] privileged-only access permission for peripheral 108
    $0d constant RIFSC_PRIV109                  \ [0x0d] privileged-only access permission for peripheral 109
    $0e constant RIFSC_PRIV110                  \ [0x0e] privileged-only access permission for peripheral 110
    $0f constant RIFSC_PRIV111                  \ [0x0f] privileged-only access permission for peripheral 111
    $10 constant RIFSC_PRIV112                  \ [0x10] privileged-only access permission for peripheral 112
    $11 constant RIFSC_PRIV113                  \ [0x11] privileged-only access permission for peripheral 113
    $12 constant RIFSC_PRIV114                  \ [0x12] privileged-only access permission for peripheral 114
    $13 constant RIFSC_PRIV115                  \ [0x13] privileged-only access permission for peripheral 115
    $14 constant RIFSC_PRIV116                  \ [0x14] privileged-only access permission for peripheral 116
    $15 constant RIFSC_PRIV117                  \ [0x15] privileged-only access permission for peripheral 117
    $16 constant RIFSC_PRIV118                  \ [0x16] privileged-only access permission for peripheral 118
    $17 constant RIFSC_PRIV119                  \ [0x17] privileged-only access permission for peripheral 119
    $18 constant RIFSC_PRIV120                  \ [0x18] privileged-only access permission for peripheral 120
    $19 constant RIFSC_PRIV121                  \ [0x19] privileged-only access permission for peripheral 121
    $1a constant RIFSC_PRIV122                  \ [0x1a] privileged-only access permission for peripheral 122
    $1b constant RIFSC_PRIV123                  \ [0x1b] privileged-only access permission for peripheral 123
    $1c constant RIFSC_PRIV124                  \ [0x1c] privileged-only access permission for peripheral 124
    $1d constant RIFSC_PRIV125                  \ [0x1d] privileged-only access permission for peripheral 125
    $1e constant RIFSC_PRIV126                  \ [0x1e] privileged-only access permission for peripheral 126
    $1f constant RIFSC_PRIV127                  \ [0x1f] privileged-only access permission for peripheral 127
  [then]


  [ifdef] RIFSC_RIFSC_RISC_PRIVCFGR4_DEF
    \
    \ @brief RIFSC RISFC slave privileged register 4
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant RIFSC_PRIV128                  \ [0x00] privileged-only access permission for peripheral 128
    $01 constant RIFSC_PRIV129                  \ [0x01] privileged-only access permission for peripheral 129
    $02 constant RIFSC_PRIV130                  \ [0x02] privileged-only access permission for peripheral 130
    $03 constant RIFSC_PRIV131                  \ [0x03] privileged-only access permission for peripheral 131
    $04 constant RIFSC_PRIV132                  \ [0x04] privileged-only access permission for peripheral 132
    $05 constant RIFSC_PRIV133                  \ [0x05] privileged-only access permission for peripheral 133
    $06 constant RIFSC_PRIV134                  \ [0x06] privileged-only access permission for peripheral 134
    $07 constant RIFSC_PRIV135                  \ [0x07] privileged-only access permission for peripheral 135
    $08 constant RIFSC_PRIV136                  \ [0x08] privileged-only access permission for peripheral 136
    $09 constant RIFSC_PRIV137                  \ [0x09] privileged-only access permission for peripheral 137
    $0a constant RIFSC_PRIV138                  \ [0x0a] privileged-only access permission for peripheral 138
    $0b constant RIFSC_PRIV139                  \ [0x0b] privileged-only access permission for peripheral 139
    $0c constant RIFSC_PRIV140                  \ [0x0c] privileged-only access permission for peripheral 140
    $0d constant RIFSC_PRIV141                  \ [0x0d] privileged-only access permission for peripheral 141
    $0e constant RIFSC_PRIV142                  \ [0x0e] privileged-only access permission for peripheral 142
    $0f constant RIFSC_PRIV143                  \ [0x0f] privileged-only access permission for peripheral 143
    $10 constant RIFSC_PRIV144                  \ [0x10] privileged-only access permission for peripheral 144
    $11 constant RIFSC_PRIV145                  \ [0x11] privileged-only access permission for peripheral 145
    $12 constant RIFSC_PRIV146                  \ [0x12] privileged-only access permission for peripheral 146
    $13 constant RIFSC_PRIV147                  \ [0x13] privileged-only access permission for peripheral 147
    $14 constant RIFSC_PRIV148                  \ [0x14] privileged-only access permission for peripheral 148
    $15 constant RIFSC_PRIV149                  \ [0x15] privileged-only access permission for peripheral 149
    $16 constant RIFSC_PRIV150                  \ [0x16] privileged-only access permission for peripheral 150
    $17 constant RIFSC_PRIV151                  \ [0x17] privileged-only access permission for peripheral 151
    $18 constant RIFSC_PRIV152                  \ [0x18] privileged-only access permission for peripheral 152
    $19 constant RIFSC_PRIV153                  \ [0x19] privileged-only access permission for peripheral 153
    $1a constant RIFSC_PRIV154                  \ [0x1a] privileged-only access permission for peripheral 154
    $1b constant RIFSC_PRIV155                  \ [0x1b] privileged-only access permission for peripheral 155
    $1c constant RIFSC_PRIV156                  \ [0x1c] privileged-only access permission for peripheral 156
    $1d constant RIFSC_PRIV157                  \ [0x1d] privileged-only access permission for peripheral 157
    $1e constant RIFSC_PRIV158                  \ [0x1e] privileged-only access permission for peripheral 158
    $1f constant RIFSC_PRIV159                  \ [0x1f] privileged-only access permission for peripheral 159
  [then]


  [ifdef] RIFSC_RIFSC_RISC_PRIVCFGR5_DEF
    \
    \ @brief RIFSC RISFC slave privileged register 5
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant RIFSC_PRIV160                  \ [0x00] privileged-only access permission for peripheral 160
    $01 constant RIFSC_PRIV161                  \ [0x01] privileged-only access permission for peripheral 161
    $02 constant RIFSC_PRIV162                  \ [0x02] privileged-only access permission for peripheral 162
    $03 constant RIFSC_PRIV163                  \ [0x03] privileged-only access permission for peripheral 163
    $04 constant RIFSC_PRIV164                  \ [0x04] privileged-only access permission for peripheral 164
    $05 constant RIFSC_PRIV165                  \ [0x05] privileged-only access permission for peripheral 165
    $06 constant RIFSC_PRIV166                  \ [0x06] privileged-only access permission for peripheral 166
    $07 constant RIFSC_PRIV167                  \ [0x07] privileged-only access permission for peripheral 167
    $08 constant RIFSC_PRIV168                  \ [0x08] privileged-only access permission for peripheral 168
    $09 constant RIFSC_PRIV169                  \ [0x09] privileged-only access permission for peripheral 169
    $0a constant RIFSC_PRIV170                  \ [0x0a] privileged-only access permission for peripheral 170
    $0b constant RIFSC_PRIV171                  \ [0x0b] privileged-only access permission for peripheral 171
    $0c constant RIFSC_PRIV172                  \ [0x0c] privileged-only access permission for peripheral 172
    $0d constant RIFSC_PRIV173                  \ [0x0d] privileged-only access permission for peripheral 173
    $0e constant RIFSC_PRIV174                  \ [0x0e] privileged-only access permission for peripheral 174
    $0f constant RIFSC_PRIV175                  \ [0x0f] privileged-only access permission for peripheral 175
    $10 constant RIFSC_PRIV176                  \ [0x10] privileged-only access permission for peripheral 176
    $11 constant RIFSC_PRIV177                  \ [0x11] privileged-only access permission for peripheral 177
    $12 constant RIFSC_PRIV178                  \ [0x12] privileged-only access permission for peripheral 178
    $13 constant RIFSC_PRIV179                  \ [0x13] privileged-only access permission for peripheral 179
    $14 constant RIFSC_PRIV180                  \ [0x14] privileged-only access permission for peripheral 180
    $15 constant RIFSC_PRIV181                  \ [0x15] privileged-only access permission for peripheral 181
    $16 constant RIFSC_PRIV182                  \ [0x16] privileged-only access permission for peripheral 182
    $17 constant RIFSC_PRIV183                  \ [0x17] privileged-only access permission for peripheral 183
    $18 constant RIFSC_PRIV184                  \ [0x18] privileged-only access permission for peripheral 184
    $19 constant RIFSC_PRIV185                  \ [0x19] privileged-only access permission for peripheral 185
    $1a constant RIFSC_PRIV186                  \ [0x1a] privileged-only access permission for peripheral 186
    $1b constant RIFSC_PRIV187                  \ [0x1b] privileged-only access permission for peripheral 187
    $1c constant RIFSC_PRIV188                  \ [0x1c] privileged-only access permission for peripheral 188
    $1d constant RIFSC_PRIV189                  \ [0x1d] privileged-only access permission for peripheral 189
    $1e constant RIFSC_PRIV190                  \ [0x1e] privileged-only access permission for peripheral 190
    $1f constant RIFSC_PRIV191                  \ [0x1f] privileged-only access permission for peripheral 191
  [then]


  [ifdef] RIFSC_RIFSC_RISC_RCFGLOCKR0_DEF
    \
    \ @brief RIFSC RISC slave resource configuration lock register 0
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RIFSC_RLOCK0                   \ [0x00] resource lock for peripheral 0
    $01 constant RIFSC_RLOCK1                   \ [0x01] resource lock for peripheral 1
    $02 constant RIFSC_RLOCK2                   \ [0x02] resource lock for peripheral 2
    $03 constant RIFSC_RLOCK3                   \ [0x03] resource lock for peripheral 3
    $04 constant RIFSC_RLOCK4                   \ [0x04] resource lock for peripheral 4
    $05 constant RIFSC_RLOCK5                   \ [0x05] resource lock for peripheral 5
    $06 constant RIFSC_RLOCK6                   \ [0x06] resource lock for peripheral 6
    $07 constant RIFSC_RLOCK7                   \ [0x07] resource lock for peripheral 7
    $08 constant RIFSC_RLOCK8                   \ [0x08] resource lock for peripheral 8
    $09 constant RIFSC_RLOCK9                   \ [0x09] resource lock for peripheral 9
    $0a constant RIFSC_RLOCK10                  \ [0x0a] resource lock for peripheral 10
    $0b constant RIFSC_RLOCK11                  \ [0x0b] resource lock for peripheral 11
    $0c constant RIFSC_RLOCK12                  \ [0x0c] resource lock for peripheral 12
    $0d constant RIFSC_RLOCK13                  \ [0x0d] resource lock for peripheral 13
    $0e constant RIFSC_RLOCK14                  \ [0x0e] resource lock for peripheral 14
    $0f constant RIFSC_RLOCK15                  \ [0x0f] resource lock for peripheral 15
    $10 constant RIFSC_RLOCK16                  \ [0x10] resource lock for peripheral 16
    $11 constant RIFSC_RLOCK17                  \ [0x11] resource lock for peripheral 17
    $12 constant RIFSC_RLOCK18                  \ [0x12] resource lock for peripheral 18
    $13 constant RIFSC_RLOCK19                  \ [0x13] resource lock for peripheral 19
    $14 constant RIFSC_RLOCK20                  \ [0x14] resource lock for peripheral 20
    $15 constant RIFSC_RLOCK21                  \ [0x15] resource lock for peripheral 21
    $16 constant RIFSC_RLOCK22                  \ [0x16] resource lock for peripheral 22
    $17 constant RIFSC_RLOCK23                  \ [0x17] resource lock for peripheral 23
    $18 constant RIFSC_RLOCK24                  \ [0x18] resource lock for peripheral 24
    $19 constant RIFSC_RLOCK25                  \ [0x19] resource lock for peripheral 25
    $1a constant RIFSC_RLOCK26                  \ [0x1a] resource lock for peripheral 26
    $1b constant RIFSC_RLOCK27                  \ [0x1b] resource lock for peripheral 27
    $1c constant RIFSC_RLOCK28                  \ [0x1c] resource lock for peripheral 28
    $1d constant RIFSC_RLOCK29                  \ [0x1d] resource lock for peripheral 29
    $1e constant RIFSC_RLOCK30                  \ [0x1e] resource lock for peripheral 30
    $1f constant RIFSC_RLOCK31                  \ [0x1f] resource lock for peripheral 31
  [then]


  [ifdef] RIFSC_RIFSC_RISC_RCFGLOCKR1_DEF
    \
    \ @brief RIFSC RISC slave resource configuration lock register 1
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RIFSC_RLOCK32                  \ [0x00] resource lock for peripheral 32
    $01 constant RIFSC_RLOCK33                  \ [0x01] resource lock for peripheral 33
    $02 constant RIFSC_RLOCK34                  \ [0x02] resource lock for peripheral 34
    $03 constant RIFSC_RLOCK35                  \ [0x03] resource lock for peripheral 35
    $04 constant RIFSC_RLOCK36                  \ [0x04] resource lock for peripheral 36
    $05 constant RIFSC_RLOCK37                  \ [0x05] resource lock for peripheral 37
    $06 constant RIFSC_RLOCK38                  \ [0x06] resource lock for peripheral 38
    $07 constant RIFSC_RLOCK39                  \ [0x07] resource lock for peripheral 39
    $08 constant RIFSC_RLOCK40                  \ [0x08] resource lock for peripheral 40
    $09 constant RIFSC_RLOCK41                  \ [0x09] resource lock for peripheral 41
    $0a constant RIFSC_RLOCK42                  \ [0x0a] resource lock for peripheral 42
    $0b constant RIFSC_RLOCK43                  \ [0x0b] resource lock for peripheral 43
    $0c constant RIFSC_RLOCK44                  \ [0x0c] resource lock for peripheral 44
    $0d constant RIFSC_RLOCK45                  \ [0x0d] resource lock for peripheral 45
    $0e constant RIFSC_RLOCK46                  \ [0x0e] resource lock for peripheral 46
    $0f constant RIFSC_RLOCK47                  \ [0x0f] resource lock for peripheral 47
    $10 constant RIFSC_RLOCK48                  \ [0x10] resource lock for peripheral 48
    $11 constant RIFSC_RLOCK49                  \ [0x11] resource lock for peripheral 49
    $12 constant RIFSC_RLOCK50                  \ [0x12] resource lock for peripheral 50
    $13 constant RIFSC_RLOCK51                  \ [0x13] resource lock for peripheral 51
    $14 constant RIFSC_RLOCK52                  \ [0x14] resource lock for peripheral 52
    $15 constant RIFSC_RLOCK53                  \ [0x15] resource lock for peripheral 53
    $16 constant RIFSC_RLOCK54                  \ [0x16] resource lock for peripheral 54
    $17 constant RIFSC_RLOCK55                  \ [0x17] resource lock for peripheral 55
    $18 constant RIFSC_RLOCK56                  \ [0x18] resource lock for peripheral 56
    $19 constant RIFSC_RLOCK57                  \ [0x19] resource lock for peripheral 57
    $1a constant RIFSC_RLOCK58                  \ [0x1a] resource lock for peripheral 58
    $1b constant RIFSC_RLOCK59                  \ [0x1b] resource lock for peripheral 59
    $1c constant RIFSC_RLOCK60                  \ [0x1c] resource lock for peripheral 60
    $1d constant RIFSC_RLOCK61                  \ [0x1d] resource lock for peripheral 61
    $1e constant RIFSC_RLOCK62                  \ [0x1e] resource lock for peripheral 62
    $1f constant RIFSC_RLOCK63                  \ [0x1f] resource lock for peripheral 63
  [then]


  [ifdef] RIFSC_RIFSC_RISC_RCFGLOCKR2_DEF
    \
    \ @brief RIFSC RISC slave resource configuration lock register 2
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RIFSC_RLOCK64                  \ [0x00] resource lock for peripheral 64
    $01 constant RIFSC_RLOCK65                  \ [0x01] resource lock for peripheral 65
    $02 constant RIFSC_RLOCK66                  \ [0x02] resource lock for peripheral 66
    $03 constant RIFSC_RLOCK67                  \ [0x03] resource lock for peripheral 67
    $04 constant RIFSC_RLOCK68                  \ [0x04] resource lock for peripheral 68
    $05 constant RIFSC_RLOCK69                  \ [0x05] resource lock for peripheral 69
    $06 constant RIFSC_RLOCK70                  \ [0x06] resource lock for peripheral 70
    $07 constant RIFSC_RLOCK71                  \ [0x07] resource lock for peripheral 71
    $08 constant RIFSC_RLOCK72                  \ [0x08] resource lock for peripheral 72
    $09 constant RIFSC_RLOCK73                  \ [0x09] resource lock for peripheral 73
    $0a constant RIFSC_RLOCK74                  \ [0x0a] resource lock for peripheral 74
    $0b constant RIFSC_RLOCK75                  \ [0x0b] resource lock for peripheral 75
    $0c constant RIFSC_RLOCK76                  \ [0x0c] resource lock for peripheral 76
    $0d constant RIFSC_RLOCK77                  \ [0x0d] resource lock for peripheral 77
    $0e constant RIFSC_RLOCK78                  \ [0x0e] resource lock for peripheral 78
    $0f constant RIFSC_RLOCK79                  \ [0x0f] resource lock for peripheral 79
    $10 constant RIFSC_RLOCK80                  \ [0x10] resource lock for peripheral 80
    $11 constant RIFSC_RLOCK81                  \ [0x11] resource lock for peripheral 81
    $12 constant RIFSC_RLOCK82                  \ [0x12] resource lock for peripheral 82
    $13 constant RIFSC_RLOCK83                  \ [0x13] resource lock for peripheral 83
    $14 constant RIFSC_RLOCK84                  \ [0x14] resource lock for peripheral 84
    $15 constant RIFSC_RLOCK85                  \ [0x15] resource lock for peripheral 85
    $16 constant RIFSC_RLOCK86                  \ [0x16] resource lock for peripheral 86
    $17 constant RIFSC_RLOCK87                  \ [0x17] resource lock for peripheral 87
    $18 constant RIFSC_RLOCK88                  \ [0x18] resource lock for peripheral 88
    $19 constant RIFSC_RLOCK89                  \ [0x19] resource lock for peripheral 89
    $1a constant RIFSC_RLOCK90                  \ [0x1a] resource lock for peripheral 90
    $1b constant RIFSC_RLOCK91                  \ [0x1b] resource lock for peripheral 91
    $1c constant RIFSC_RLOCK92                  \ [0x1c] resource lock for peripheral 92
    $1d constant RIFSC_RLOCK93                  \ [0x1d] resource lock for peripheral 93
    $1e constant RIFSC_RLOCK94                  \ [0x1e] resource lock for peripheral 94
    $1f constant RIFSC_RLOCK95                  \ [0x1f] resource lock for peripheral 95
  [then]


  [ifdef] RIFSC_RIFSC_RISC_RCFGLOCKR3_DEF
    \
    \ @brief RIFSC RISC slave resource configuration lock register 3
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant RIFSC_RLOCK96                  \ [0x00] resource lock for peripheral 96
    $01 constant RIFSC_RLOCK97                  \ [0x01] resource lock for peripheral 97
    $02 constant RIFSC_RLOCK98                  \ [0x02] resource lock for peripheral 98
    $03 constant RIFSC_RLOCK99                  \ [0x03] resource lock for peripheral 99
    $04 constant RIFSC_RLOCK100                 \ [0x04] resource lock for peripheral 100
    $05 constant RIFSC_RLOCK101                 \ [0x05] resource lock for peripheral 101
    $06 constant RIFSC_RLOCK102                 \ [0x06] resource lock for peripheral 102
    $07 constant RIFSC_RLOCK103                 \ [0x07] resource lock for peripheral 103
    $08 constant RIFSC_RLOCK104                 \ [0x08] resource lock for peripheral 104
    $09 constant RIFSC_RLOCK105                 \ [0x09] resource lock for peripheral 105
    $0a constant RIFSC_RLOCK106                 \ [0x0a] resource lock for peripheral 106
    $0b constant RIFSC_RLOCK107                 \ [0x0b] resource lock for peripheral 107
    $0c constant RIFSC_RLOCK108                 \ [0x0c] resource lock for peripheral 108
    $0d constant RIFSC_RLOCK109                 \ [0x0d] resource lock for peripheral 109
    $0e constant RIFSC_RLOCK110                 \ [0x0e] resource lock for peripheral 110
    $0f constant RIFSC_RLOCK111                 \ [0x0f] resource lock for peripheral 111
    $10 constant RIFSC_RLOCK112                 \ [0x10] resource lock for peripheral 112
    $11 constant RIFSC_RLOCK113                 \ [0x11] resource lock for peripheral 113
    $12 constant RIFSC_RLOCK114                 \ [0x12] resource lock for peripheral 114
    $13 constant RIFSC_RLOCK115                 \ [0x13] resource lock for peripheral 115
    $14 constant RIFSC_RLOCK116                 \ [0x14] resource lock for peripheral 116
    $15 constant RIFSC_RLOCK117                 \ [0x15] resource lock for peripheral 117
    $16 constant RIFSC_RLOCK118                 \ [0x16] resource lock for peripheral 118
    $17 constant RIFSC_RLOCK119                 \ [0x17] resource lock for peripheral 119
    $18 constant RIFSC_RLOCK120                 \ [0x18] resource lock for peripheral 120
    $19 constant RIFSC_RLOCK121                 \ [0x19] resource lock for peripheral 121
    $1a constant RIFSC_RLOCK122                 \ [0x1a] resource lock for peripheral 122
    $1b constant RIFSC_RLOCK123                 \ [0x1b] resource lock for peripheral 123
    $1c constant RIFSC_RLOCK124                 \ [0x1c] resource lock for peripheral 124
    $1d constant RIFSC_RLOCK125                 \ [0x1d] resource lock for peripheral 125
    $1e constant RIFSC_RLOCK126                 \ [0x1e] resource lock for peripheral 126
    $1f constant RIFSC_RLOCK127                 \ [0x1f] resource lock for peripheral 127
  [then]


  [ifdef] RIFSC_RIFSC_RISC_RCFGLOCKR4_DEF
    \
    \ @brief RIFSC RISC slave resource configuration lock register 4
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant RIFSC_RLOCK128                 \ [0x00] resource lock for peripheral 128
    $01 constant RIFSC_RLOCK129                 \ [0x01] resource lock for peripheral 129
    $02 constant RIFSC_RLOCK130                 \ [0x02] resource lock for peripheral 130
    $03 constant RIFSC_RLOCK131                 \ [0x03] resource lock for peripheral 131
    $04 constant RIFSC_RLOCK132                 \ [0x04] resource lock for peripheral 132
    $05 constant RIFSC_RLOCK133                 \ [0x05] resource lock for peripheral 133
    $06 constant RIFSC_RLOCK134                 \ [0x06] resource lock for peripheral 134
    $07 constant RIFSC_RLOCK135                 \ [0x07] resource lock for peripheral 135
    $08 constant RIFSC_RLOCK136                 \ [0x08] resource lock for peripheral 136
    $09 constant RIFSC_RLOCK137                 \ [0x09] resource lock for peripheral 137
    $0a constant RIFSC_RLOCK138                 \ [0x0a] resource lock for peripheral 138
    $0b constant RIFSC_RLOCK139                 \ [0x0b] resource lock for peripheral 139
    $0c constant RIFSC_RLOCK140                 \ [0x0c] resource lock for peripheral 140
    $0d constant RIFSC_RLOCK141                 \ [0x0d] resource lock for peripheral 141
    $0e constant RIFSC_RLOCK142                 \ [0x0e] resource lock for peripheral 142
    $0f constant RIFSC_RLOCK143                 \ [0x0f] resource lock for peripheral 143
    $10 constant RIFSC_RLOCK144                 \ [0x10] resource lock for peripheral 144
    $11 constant RIFSC_RLOCK145                 \ [0x11] resource lock for peripheral 145
    $12 constant RIFSC_RLOCK146                 \ [0x12] resource lock for peripheral 146
    $13 constant RIFSC_RLOCK147                 \ [0x13] resource lock for peripheral 147
    $14 constant RIFSC_RLOCK148                 \ [0x14] resource lock for peripheral 148
    $15 constant RIFSC_RLOCK149                 \ [0x15] resource lock for peripheral 149
    $16 constant RIFSC_RLOCK150                 \ [0x16] resource lock for peripheral 150
    $17 constant RIFSC_RLOCK151                 \ [0x17] resource lock for peripheral 151
    $18 constant RIFSC_RLOCK152                 \ [0x18] resource lock for peripheral 152
    $19 constant RIFSC_RLOCK153                 \ [0x19] resource lock for peripheral 153
    $1a constant RIFSC_RLOCK154                 \ [0x1a] resource lock for peripheral 154
    $1b constant RIFSC_RLOCK155                 \ [0x1b] resource lock for peripheral 155
    $1c constant RIFSC_RLOCK156                 \ [0x1c] resource lock for peripheral 156
    $1d constant RIFSC_RLOCK157                 \ [0x1d] resource lock for peripheral 157
    $1e constant RIFSC_RLOCK158                 \ [0x1e] resource lock for peripheral 158
    $1f constant RIFSC_RLOCK159                 \ [0x1f] resource lock for peripheral 159
  [then]


  [ifdef] RIFSC_RIFSC_RISC_RCFGLOCKR5_DEF
    \
    \ @brief RIFSC RISC slave resource configuration lock register 5
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant RIFSC_RLOCK160                 \ [0x00] resource lock for peripheral 160
    $01 constant RIFSC_RLOCK161                 \ [0x01] resource lock for peripheral 161
    $02 constant RIFSC_RLOCK162                 \ [0x02] resource lock for peripheral 162
    $03 constant RIFSC_RLOCK163                 \ [0x03] resource lock for peripheral 163
    $04 constant RIFSC_RLOCK164                 \ [0x04] resource lock for peripheral 164
    $05 constant RIFSC_RLOCK165                 \ [0x05] resource lock for peripheral 165
    $06 constant RIFSC_RLOCK166                 \ [0x06] resource lock for peripheral 166
    $07 constant RIFSC_RLOCK167                 \ [0x07] resource lock for peripheral 167
    $08 constant RIFSC_RLOCK168                 \ [0x08] resource lock for peripheral 168
    $09 constant RIFSC_RLOCK169                 \ [0x09] resource lock for peripheral 169
    $0a constant RIFSC_RLOCK170                 \ [0x0a] resource lock for peripheral 170
    $0b constant RIFSC_RLOCK171                 \ [0x0b] resource lock for peripheral 171
    $0c constant RIFSC_RLOCK172                 \ [0x0c] resource lock for peripheral 172
    $0d constant RIFSC_RLOCK173                 \ [0x0d] resource lock for peripheral 173
    $0e constant RIFSC_RLOCK174                 \ [0x0e] resource lock for peripheral 174
    $0f constant RIFSC_RLOCK175                 \ [0x0f] resource lock for peripheral 175
    $10 constant RIFSC_RLOCK176                 \ [0x10] resource lock for peripheral 176
    $11 constant RIFSC_RLOCK177                 \ [0x11] resource lock for peripheral 177
    $12 constant RIFSC_RLOCK178                 \ [0x12] resource lock for peripheral 178
    $13 constant RIFSC_RLOCK179                 \ [0x13] resource lock for peripheral 179
    $14 constant RIFSC_RLOCK180                 \ [0x14] resource lock for peripheral 180
    $15 constant RIFSC_RLOCK181                 \ [0x15] resource lock for peripheral 181
    $16 constant RIFSC_RLOCK182                 \ [0x16] resource lock for peripheral 182
    $17 constant RIFSC_RLOCK183                 \ [0x17] resource lock for peripheral 183
    $18 constant RIFSC_RLOCK184                 \ [0x18] resource lock for peripheral 184
    $19 constant RIFSC_RLOCK185                 \ [0x19] resource lock for peripheral 185
    $1a constant RIFSC_RLOCK186                 \ [0x1a] resource lock for peripheral 186
    $1b constant RIFSC_RLOCK187                 \ [0x1b] resource lock for peripheral 187
    $1c constant RIFSC_RLOCK188                 \ [0x1c] resource lock for peripheral 188
    $1d constant RIFSC_RLOCK189                 \ [0x1d] resource lock for peripheral 189
    $1e constant RIFSC_RLOCK190                 \ [0x1e] resource lock for peripheral 190
    $1f constant RIFSC_RLOCK191                 \ [0x1f] resource lock for peripheral 191
  [then]


  [ifdef] RIFSC_RIFSC_RIMC_CR_DEF
    \
    \ @brief RIFSC RIMC master configuration register
    \ Address offset: 0xC00
    \ Reset value: 0x00000710
    \
    $00 constant RIFSC_GLOCK                    \ [0x00] global lock
    $08 constant RIFSC_DAPCID                   \ [0x08 : 3] debug access port compartment ID
  [then]


  [ifdef] RIFSC_RIFSC_RIMC_ATTR0_DEF
    \
    \ @brief RIFSC RIMC master attribute register 0
    \ Address offset: 0xC10
    \ Reset value: 0x00000000
    \
    $04 constant RIFSC_MCID                     \ [0x04 : 3] master CID
    $08 constant RIFSC_MSEC                     \ [0x08] master secure
    $09 constant RIFSC_MPRIV                    \ [0x09] master privileged
  [then]


  [ifdef] RIFSC_RIFSC_RIMC_ATTR1_DEF
    \
    \ @brief RIFSC RIMC master attribute register 1
    \ Address offset: 0xC14
    \ Reset value: 0x00000000
    \
    $04 constant RIFSC_MCID                     \ [0x04 : 3] master CID
    $08 constant RIFSC_MSEC                     \ [0x08] master secure
    $09 constant RIFSC_MPRIV                    \ [0x09] master privileged
  [then]


  [ifdef] RIFSC_RIFSC_RIMC_ATTR2_DEF
    \
    \ @brief RIFSC RIMC master attribute register 2
    \ Address offset: 0xC18
    \ Reset value: 0x00000000
    \
    $04 constant RIFSC_MCID                     \ [0x04 : 3] master CID
    $08 constant RIFSC_MSEC                     \ [0x08] master secure
    $09 constant RIFSC_MPRIV                    \ [0x09] master privileged
  [then]


  [ifdef] RIFSC_RIFSC_RIMC_ATTR3_DEF
    \
    \ @brief RIFSC RIMC master attribute register 3
    \ Address offset: 0xC1C
    \ Reset value: 0x00000000
    \
    $04 constant RIFSC_MCID                     \ [0x04 : 3] master CID
    $08 constant RIFSC_MSEC                     \ [0x08] master secure
    $09 constant RIFSC_MPRIV                    \ [0x09] master privileged
  [then]


  [ifdef] RIFSC_RIFSC_RIMC_ATTR4_DEF
    \
    \ @brief RIFSC RIMC master attribute register 4
    \ Address offset: 0xC20
    \ Reset value: 0x00000000
    \
    $04 constant RIFSC_MCID                     \ [0x04 : 3] master CID
    $08 constant RIFSC_MSEC                     \ [0x08] master secure
    $09 constant RIFSC_MPRIV                    \ [0x09] master privileged
  [then]


  [ifdef] RIFSC_RIFSC_RIMC_ATTR5_DEF
    \
    \ @brief RIFSC RIMC master attribute register 5
    \ Address offset: 0xC24
    \ Reset value: 0x00000000
    \
    $04 constant RIFSC_MCID                     \ [0x04 : 3] master CID
    $08 constant RIFSC_MSEC                     \ [0x08] master secure
    $09 constant RIFSC_MPRIV                    \ [0x09] master privileged
  [then]


  [ifdef] RIFSC_RIFSC_RIMC_ATTR6_DEF
    \
    \ @brief RIFSC RIMC master attribute register 6
    \ Address offset: 0xC28
    \ Reset value: 0x00000000
    \
    $04 constant RIFSC_MCID                     \ [0x04 : 3] master CID
    $08 constant RIFSC_MSEC                     \ [0x08] master secure
    $09 constant RIFSC_MPRIV                    \ [0x09] master privileged
  [then]


  [ifdef] RIFSC_RIFSC_RIMC_ATTR7_DEF
    \
    \ @brief RIFSC RIMC master attribute register 7
    \ Address offset: 0xC2C
    \ Reset value: 0x00000000
    \
    $04 constant RIFSC_MCID                     \ [0x04 : 3] master CID
    $08 constant RIFSC_MSEC                     \ [0x08] master secure
    $09 constant RIFSC_MPRIV                    \ [0x09] master privileged
  [then]


  [ifdef] RIFSC_RIFSC_RIMC_ATTR8_DEF
    \
    \ @brief RIFSC RIMC master attribute register 8
    \ Address offset: 0xC30
    \ Reset value: 0x00000000
    \
    $04 constant RIFSC_MCID                     \ [0x04 : 3] master CID
    $08 constant RIFSC_MSEC                     \ [0x08] master secure
    $09 constant RIFSC_MPRIV                    \ [0x09] master privileged
  [then]


  [ifdef] RIFSC_RIFSC_RIMC_ATTR9_DEF
    \
    \ @brief RIFSC RIMC master attribute register 9
    \ Address offset: 0xC34
    \ Reset value: 0x00000000
    \
    $04 constant RIFSC_MCID                     \ [0x04 : 3] master CID
    $08 constant RIFSC_MSEC                     \ [0x08] master secure
    $09 constant RIFSC_MPRIV                    \ [0x09] master privileged
  [then]


  [ifdef] RIFSC_RIFSC_RIMC_ATTR10_DEF
    \
    \ @brief RIFSC RIMC master attribute register 10
    \ Address offset: 0xC38
    \ Reset value: 0x00000000
    \
    $04 constant RIFSC_MCID                     \ [0x04 : 3] master CID
    $08 constant RIFSC_MSEC                     \ [0x08] master secure
    $09 constant RIFSC_MPRIV                    \ [0x09] master privileged
  [then]


  [ifdef] RIFSC_RIFSC_RIMC_ATTR11_DEF
    \
    \ @brief RIFSC RIMC master attribute register 11
    \ Address offset: 0xC3C
    \ Reset value: 0x00000000
    \
    $04 constant RIFSC_MCID                     \ [0x04 : 3] master CID
    $08 constant RIFSC_MSEC                     \ [0x08] master secure
    $09 constant RIFSC_MPRIV                    \ [0x09] master privileged
  [then]


  [ifdef] RIFSC_RIFSC_PPSR0_DEF
    \
    \ @brief RIFSC peripheral protection status register 0
    \ Address offset: 0xFB0
    \ Reset value: 0xFFFFFF7F
    \
    $00 constant RIFSC_PPEN0                    \ [0x00] peripheral protection enable 0
    $01 constant RIFSC_PPEN1                    \ [0x01] peripheral protection enable 1
    $02 constant RIFSC_PPEN2                    \ [0x02] peripheral protection enable 2
    $03 constant RIFSC_PPEN3                    \ [0x03] peripheral protection enable 3
    $04 constant RIFSC_PPEN4                    \ [0x04] peripheral protection enable 4
    $05 constant RIFSC_PPEN5                    \ [0x05] peripheral protection enable 5
    $06 constant RIFSC_PPEN6                    \ [0x06] peripheral protection enable 6
    $07 constant RIFSC_PPEN7                    \ [0x07] peripheral protection enable 7
    $08 constant RIFSC_PPEN8                    \ [0x08] peripheral protection enable 8
    $09 constant RIFSC_PPEN9                    \ [0x09] peripheral protection enable 9
    $0a constant RIFSC_PPEN10                   \ [0x0a] peripheral protection enable 10
    $0b constant RIFSC_PPEN11                   \ [0x0b] peripheral protection enable 11
    $0c constant RIFSC_PPEN12                   \ [0x0c] peripheral protection enable 12
    $0d constant RIFSC_PPEN13                   \ [0x0d] peripheral protection enable 13
    $0e constant RIFSC_PPEN14                   \ [0x0e] peripheral protection enable 14
    $0f constant RIFSC_PPEN15                   \ [0x0f] peripheral protection enable 15
    $10 constant RIFSC_PPEN16                   \ [0x10] peripheral protection enable 16
    $11 constant RIFSC_PPEN17                   \ [0x11] peripheral protection enable 17
    $12 constant RIFSC_PPEN18                   \ [0x12] peripheral protection enable 18
    $13 constant RIFSC_PPEN19                   \ [0x13] peripheral protection enable 19
    $14 constant RIFSC_PPEN20                   \ [0x14] peripheral protection enable 20
    $15 constant RIFSC_PPEN21                   \ [0x15] peripheral protection enable 21
    $16 constant RIFSC_PPEN22                   \ [0x16] peripheral protection enable 22
    $17 constant RIFSC_PPEN23                   \ [0x17] peripheral protection enable 23
    $18 constant RIFSC_PPEN24                   \ [0x18] peripheral protection enable 24
    $19 constant RIFSC_PPEN25                   \ [0x19] peripheral protection enable 25
    $1a constant RIFSC_PPEN26                   \ [0x1a] peripheral protection enable 26
    $1b constant RIFSC_PPEN27                   \ [0x1b] peripheral protection enable 27
    $1c constant RIFSC_PPEN28                   \ [0x1c] peripheral protection enable 28
    $1d constant RIFSC_PPEN29                   \ [0x1d] peripheral protection enable 29
    $1e constant RIFSC_PPEN30                   \ [0x1e] peripheral protection enable 30
    $1f constant RIFSC_PPEN31                   \ [0x1f] peripheral protection enable 31
  [then]


  [ifdef] RIFSC_RIFSC_PPSR1_DEF
    \
    \ @brief RIFSC peripheral protection status register 1
    \ Address offset: 0xFB4
    \ Reset value: 0x77FFFFFF
    \
    $00 constant RIFSC_PPEN32                   \ [0x00] peripheral protection enable 32
    $01 constant RIFSC_PPEN33                   \ [0x01] peripheral protection enable 33
    $02 constant RIFSC_PPEN34                   \ [0x02] peripheral protection enable 34
    $03 constant RIFSC_PPEN35                   \ [0x03] peripheral protection enable 35
    $04 constant RIFSC_PPEN36                   \ [0x04] peripheral protection enable 36
    $05 constant RIFSC_PPEN37                   \ [0x05] peripheral protection enable 37
    $06 constant RIFSC_PPEN38                   \ [0x06] peripheral protection enable 38
    $07 constant RIFSC_PPEN39                   \ [0x07] peripheral protection enable 39
    $08 constant RIFSC_PPEN40                   \ [0x08] peripheral protection enable 40
    $09 constant RIFSC_PPEN41                   \ [0x09] peripheral protection enable 41
    $0a constant RIFSC_PPEN42                   \ [0x0a] peripheral protection enable 42
    $0b constant RIFSC_PPEN43                   \ [0x0b] peripheral protection enable 43
    $0c constant RIFSC_PPEN44                   \ [0x0c] peripheral protection enable 44
    $0d constant RIFSC_PPEN45                   \ [0x0d] peripheral protection enable 45
    $0e constant RIFSC_PPEN46                   \ [0x0e] peripheral protection enable 46
    $0f constant RIFSC_PPEN47                   \ [0x0f] peripheral protection enable 47
    $10 constant RIFSC_PPEN48                   \ [0x10] peripheral protection enable 48
    $11 constant RIFSC_PPEN49                   \ [0x11] peripheral protection enable 49
    $12 constant RIFSC_PPEN50                   \ [0x12] peripheral protection enable 50
    $13 constant RIFSC_PPEN51                   \ [0x13] peripheral protection enable 51
    $14 constant RIFSC_PPEN52                   \ [0x14] peripheral protection enable 52
    $15 constant RIFSC_PPEN53                   \ [0x15] peripheral protection enable 53
    $16 constant RIFSC_PPEN54                   \ [0x16] peripheral protection enable 54
    $17 constant RIFSC_PPEN55                   \ [0x17] peripheral protection enable 55
    $18 constant RIFSC_PPEN56                   \ [0x18] peripheral protection enable 56
    $19 constant RIFSC_PPEN57                   \ [0x19] peripheral protection enable 57
    $1a constant RIFSC_PPEN58                   \ [0x1a] peripheral protection enable 58
    $1b constant RIFSC_PPEN59                   \ [0x1b] peripheral protection enable 59
    $1c constant RIFSC_PPEN60                   \ [0x1c] peripheral protection enable 60
    $1d constant RIFSC_PPEN61                   \ [0x1d] peripheral protection enable 61
    $1e constant RIFSC_PPEN62                   \ [0x1e] peripheral protection enable 62
    $1f constant RIFSC_PPEN63                   \ [0x1f] peripheral protection enable 63
  [then]


  [ifdef] RIFSC_RIFSC_PPSR2_DEF
    \
    \ @brief RIFSC peripheral protection status register 2
    \ Address offset: 0xFB8
    \ Reset value: 0xF7DFF03B
    \
    $00 constant RIFSC_PPEN64                   \ [0x00] peripheral protection enable 64
    $01 constant RIFSC_PPEN65                   \ [0x01] peripheral protection enable 65
    $02 constant RIFSC_PPEN66                   \ [0x02] peripheral protection enable 66
    $03 constant RIFSC_PPEN67                   \ [0x03] peripheral protection enable 67
    $04 constant RIFSC_PPEN68                   \ [0x04] peripheral protection enable 68
    $05 constant RIFSC_PPEN69                   \ [0x05] peripheral protection enable 69
    $06 constant RIFSC_PPEN70                   \ [0x06] peripheral protection enable 70
    $07 constant RIFSC_PPEN71                   \ [0x07] peripheral protection enable 71
    $08 constant RIFSC_PPEN72                   \ [0x08] peripheral protection enable 72
    $09 constant RIFSC_PPEN73                   \ [0x09] peripheral protection enable 73
    $0a constant RIFSC_PPEN74                   \ [0x0a] peripheral protection enable 74
    $0b constant RIFSC_PPEN75                   \ [0x0b] peripheral protection enable 75
    $0c constant RIFSC_PPEN76                   \ [0x0c] peripheral protection enable 76
    $0d constant RIFSC_PPEN77                   \ [0x0d] peripheral protection enable 77
    $0e constant RIFSC_PPEN78                   \ [0x0e] peripheral protection enable 78
    $0f constant RIFSC_PPEN79                   \ [0x0f] peripheral protection enable 79
    $10 constant RIFSC_PPEN80                   \ [0x10] peripheral protection enable 80
    $11 constant RIFSC_PPEN81                   \ [0x11] peripheral protection enable 81
    $12 constant RIFSC_PPEN82                   \ [0x12] peripheral protection enable 82
    $13 constant RIFSC_PPEN83                   \ [0x13] peripheral protection enable 83
    $14 constant RIFSC_PPEN84                   \ [0x14] peripheral protection enable 84
    $15 constant RIFSC_PPEN85                   \ [0x15] peripheral protection enable 85
    $16 constant RIFSC_PPEN86                   \ [0x16] peripheral protection enable 86
    $17 constant RIFSC_PPEN87                   \ [0x17] peripheral protection enable 87
    $18 constant RIFSC_PPEN88                   \ [0x18] peripheral protection enable 88
    $19 constant RIFSC_PPEN89                   \ [0x19] peripheral protection enable 89
    $1a constant RIFSC_PPEN90                   \ [0x1a] peripheral protection enable 90
    $1b constant RIFSC_PPEN91                   \ [0x1b] peripheral protection enable 91
    $1c constant RIFSC_PPEN92                   \ [0x1c] peripheral protection enable 92
    $1d constant RIFSC_PPEN93                   \ [0x1d] peripheral protection enable 93
    $1e constant RIFSC_PPEN94                   \ [0x1e] peripheral protection enable 94
    $1f constant RIFSC_PPEN95                   \ [0x1f] peripheral protection enable 95
  [then]


  [ifdef] RIFSC_RIFSC_PPSR3_DEF
    \
    \ @brief RIFSC peripheral protection status register 3
    \ Address offset: 0xFBC
    \ Reset value: 0x000005FF
    \
    $00 constant RIFSC_PPEN96                   \ [0x00] peripheral protection enable 96
    $01 constant RIFSC_PPEN97                   \ [0x01] peripheral protection enable 97
    $02 constant RIFSC_PPEN98                   \ [0x02] peripheral protection enable 98
    $03 constant RIFSC_PPEN99                   \ [0x03] peripheral protection enable 99
    $04 constant RIFSC_PPEN100                  \ [0x04] peripheral protection enable 100
    $05 constant RIFSC_PPEN101                  \ [0x05] peripheral protection enable 101
    $06 constant RIFSC_PPEN102                  \ [0x06] peripheral protection enable 102
    $07 constant RIFSC_PPEN103                  \ [0x07] peripheral protection enable 103
    $08 constant RIFSC_PPEN104                  \ [0x08] peripheral protection enable 104
    $09 constant RIFSC_PPEN105                  \ [0x09] peripheral protection enable 105
    $0a constant RIFSC_PPEN106                  \ [0x0a] peripheral protection enable 106
    $0b constant RIFSC_PPEN107                  \ [0x0b] peripheral protection enable 107
    $0c constant RIFSC_PPEN108                  \ [0x0c] peripheral protection enable 108
    $0d constant RIFSC_PPEN109                  \ [0x0d] peripheral protection enable 109
    $0e constant RIFSC_PPEN110                  \ [0x0e] peripheral protection enable 110
    $0f constant RIFSC_PPEN111                  \ [0x0f] peripheral protection enable 111
    $10 constant RIFSC_PPEN112                  \ [0x10] peripheral protection enable 112
    $11 constant RIFSC_PPEN113                  \ [0x11] peripheral protection enable 113
    $12 constant RIFSC_PPEN114                  \ [0x12] peripheral protection enable 114
    $13 constant RIFSC_PPEN115                  \ [0x13] peripheral protection enable 115
    $14 constant RIFSC_PPEN116                  \ [0x14] peripheral protection enable 116
    $15 constant RIFSC_PPEN117                  \ [0x15] peripheral protection enable 117
    $16 constant RIFSC_PPEN118                  \ [0x16] peripheral protection enable 118
    $17 constant RIFSC_PPEN119                  \ [0x17] peripheral protection enable 119
    $18 constant RIFSC_PPEN120                  \ [0x18] peripheral protection enable 120
    $19 constant RIFSC_PPEN121                  \ [0x19] peripheral protection enable 121
    $1a constant RIFSC_PPEN122                  \ [0x1a] peripheral protection enable 122
    $1b constant RIFSC_PPEN123                  \ [0x1b] peripheral protection enable 123
    $1c constant RIFSC_PPEN124                  \ [0x1c] peripheral protection enable 124
    $1d constant RIFSC_PPEN125                  \ [0x1d] peripheral protection enable 125
    $1e constant RIFSC_PPEN126                  \ [0x1e] peripheral protection enable 126
    $1f constant RIFSC_PPEN127                  \ [0x1f] peripheral protection enable 127
  [then]


  [ifdef] RIFSC_RIFSC_PPSR4_DEF
    \
    \ @brief RIFSC peripheral protection status register 4
    \ Address offset: 0xFC0
    \ Reset value: 0x3A0E382E
    \
    $00 constant RIFSC_PPEN128                  \ [0x00] peripheral protection enable 128
    $01 constant RIFSC_PPEN129                  \ [0x01] peripheral protection enable 129
    $02 constant RIFSC_PPEN130                  \ [0x02] peripheral protection enable 130
    $03 constant RIFSC_PPEN131                  \ [0x03] peripheral protection enable 131
    $04 constant RIFSC_PPEN132                  \ [0x04] peripheral protection enable 132
    $05 constant RIFSC_PPEN133                  \ [0x05] peripheral protection enable 133
    $06 constant RIFSC_PPEN134                  \ [0x06] peripheral protection enable 134
    $07 constant RIFSC_PPEN135                  \ [0x07] peripheral protection enable 135
    $08 constant RIFSC_PPEN136                  \ [0x08] peripheral protection enable 136
    $09 constant RIFSC_PPEN137                  \ [0x09] peripheral protection enable 137
    $0a constant RIFSC_PPEN138                  \ [0x0a] peripheral protection enable 138
    $0b constant RIFSC_PPEN139                  \ [0x0b] peripheral protection enable 139
    $0c constant RIFSC_PPEN140                  \ [0x0c] peripheral protection enable 140
    $0d constant RIFSC_PPEN141                  \ [0x0d] peripheral protection enable 141
    $0e constant RIFSC_PPEN142                  \ [0x0e] peripheral protection enable 142
    $0f constant RIFSC_PPEN143                  \ [0x0f] peripheral protection enable 143
    $10 constant RIFSC_PPEN144                  \ [0x10] peripheral protection enable 144
    $11 constant RIFSC_PPEN145                  \ [0x11] peripheral protection enable 145
    $12 constant RIFSC_PPEN146                  \ [0x12] peripheral protection enable 146
    $13 constant RIFSC_PPEN147                  \ [0x13] peripheral protection enable 147
    $14 constant RIFSC_PPEN148                  \ [0x14] peripheral protection enable 148
    $15 constant RIFSC_PPEN149                  \ [0x15] peripheral protection enable 149
    $16 constant RIFSC_PPEN150                  \ [0x16] peripheral protection enable 150
    $17 constant RIFSC_PPEN151                  \ [0x17] peripheral protection enable 151
    $18 constant RIFSC_PPEN152                  \ [0x18] peripheral protection enable 152
    $19 constant RIFSC_PPEN153                  \ [0x19] peripheral protection enable 153
    $1a constant RIFSC_PPEN154                  \ [0x1a] peripheral protection enable 154
    $1b constant RIFSC_PPEN155                  \ [0x1b] peripheral protection enable 155
    $1c constant RIFSC_PPEN156                  \ [0x1c] peripheral protection enable 156
    $1d constant RIFSC_PPEN157                  \ [0x1d] peripheral protection enable 157
    $1e constant RIFSC_PPEN158                  \ [0x1e] peripheral protection enable 158
    $1f constant RIFSC_PPEN159                  \ [0x1f] peripheral protection enable 159
  [then]


  [ifdef] RIFSC_RIFSC_PPSR5_DEF
    \
    \ @brief RIFSC peripheral protection status register 5
    \ Address offset: 0xFC4
    \ Reset value: 0x3DDEEF7F
    \
    $00 constant RIFSC_PPEN160                  \ [0x00] peripheral protection enable 160
    $01 constant RIFSC_PPEN161                  \ [0x01] peripheral protection enable 161
    $02 constant RIFSC_PPEN162                  \ [0x02] peripheral protection enable 162
    $03 constant RIFSC_PPEN163                  \ [0x03] peripheral protection enable 163
    $04 constant RIFSC_PPEN164                  \ [0x04] peripheral protection enable 164
    $05 constant RIFSC_PPEN165                  \ [0x05] peripheral protection enable 165
    $06 constant RIFSC_PPEN166                  \ [0x06] peripheral protection enable 166
    $07 constant RIFSC_PPEN167                  \ [0x07] peripheral protection enable 167
    $08 constant RIFSC_PPEN168                  \ [0x08] peripheral protection enable 168
    $09 constant RIFSC_PPEN169                  \ [0x09] peripheral protection enable 169
    $0a constant RIFSC_PPEN170                  \ [0x0a] peripheral protection enable 170
    $0b constant RIFSC_PPEN171                  \ [0x0b] peripheral protection enable 171
    $0c constant RIFSC_PPEN172                  \ [0x0c] peripheral protection enable 172
    $0d constant RIFSC_PPEN173                  \ [0x0d] peripheral protection enable 173
    $0e constant RIFSC_PPEN174                  \ [0x0e] peripheral protection enable 174
    $0f constant RIFSC_PPEN175                  \ [0x0f] peripheral protection enable 175
    $10 constant RIFSC_PPEN176                  \ [0x10] peripheral protection enable 176
    $11 constant RIFSC_PPEN177                  \ [0x11] peripheral protection enable 177
    $12 constant RIFSC_PPEN178                  \ [0x12] peripheral protection enable 178
    $13 constant RIFSC_PPEN179                  \ [0x13] peripheral protection enable 179
    $14 constant RIFSC_PPEN180                  \ [0x14] peripheral protection enable 180
    $15 constant RIFSC_PPEN181                  \ [0x15] peripheral protection enable 181
    $16 constant RIFSC_PPEN182                  \ [0x16] peripheral protection enable 182
    $17 constant RIFSC_PPEN183                  \ [0x17] peripheral protection enable 183
    $18 constant RIFSC_PPEN184                  \ [0x18] peripheral protection enable 184
    $19 constant RIFSC_PPEN185                  \ [0x19] peripheral protection enable 185
    $1a constant RIFSC_PPEN186                  \ [0x1a] peripheral protection enable 186
    $1b constant RIFSC_PPEN187                  \ [0x1b] peripheral protection enable 187
    $1c constant RIFSC_PPEN188                  \ [0x1c] peripheral protection enable 188
    $1d constant RIFSC_PPEN189                  \ [0x1d] peripheral protection enable 189
    $1e constant RIFSC_PPEN190                  \ [0x1e] peripheral protection enable 190
    $1f constant RIFSC_PPEN191                  \ [0x1f] peripheral protection enable 191
  [then]

  \
  \ @brief Resource isolation framework security controller
  \
  $00 constant RIFSC_RIFSC_RISC_CR      \ RIFSC RISC slave configuration register x
  $10 constant RIFSC_RIFSC_RISC_SECCFGR0    \ RIFSC RISC slave security configuration register 0
  $14 constant RIFSC_RIFSC_RISC_SECCFGR1    \ RIFSC RISC slave security configuration register 1
  $18 constant RIFSC_RIFSC_RISC_SECCFGR2    \ RIFSC RISC slave security configuration register 2
  $1C constant RIFSC_RIFSC_RISC_SECCFGR3    \ RIFSC RISC slave security configuration register 3
  $20 constant RIFSC_RIFSC_RISC_SECCFGR4    \ RIFSC RISC slave security configuration register 4
  $24 constant RIFSC_RIFSC_RISC_SECCFGR5    \ RIFSC RISC slave security configuration register 5
  $30 constant RIFSC_RIFSC_RISC_PRIVCFGR0    \ RIFSC RISFC slave privileged register 0
  $34 constant RIFSC_RIFSC_RISC_PRIVCFGR1    \ RIFSC RISFC slave privileged register 1
  $38 constant RIFSC_RIFSC_RISC_PRIVCFGR2    \ RIFSC RISFC slave privileged register 2
  $3C constant RIFSC_RIFSC_RISC_PRIVCFGR3    \ RIFSC RISFC slave privileged register 3
  $40 constant RIFSC_RIFSC_RISC_PRIVCFGR4    \ RIFSC RISFC slave privileged register 4
  $44 constant RIFSC_RIFSC_RISC_PRIVCFGR5    \ RIFSC RISFC slave privileged register 5
  $50 constant RIFSC_RIFSC_RISC_RCFGLOCKR0    \ RIFSC RISC slave resource configuration lock register 0
  $54 constant RIFSC_RIFSC_RISC_RCFGLOCKR1    \ RIFSC RISC slave resource configuration lock register 1
  $58 constant RIFSC_RIFSC_RISC_RCFGLOCKR2    \ RIFSC RISC slave resource configuration lock register 2
  $5C constant RIFSC_RIFSC_RISC_RCFGLOCKR3    \ RIFSC RISC slave resource configuration lock register 3
  $60 constant RIFSC_RIFSC_RISC_RCFGLOCKR4    \ RIFSC RISC slave resource configuration lock register 4
  $64 constant RIFSC_RIFSC_RISC_RCFGLOCKR5    \ RIFSC RISC slave resource configuration lock register 5
  $C00 constant RIFSC_RIFSC_RIMC_CR     \ RIFSC RIMC master configuration register
  $C10 constant RIFSC_RIFSC_RIMC_ATTR0  \ RIFSC RIMC master attribute register 0
  $C14 constant RIFSC_RIFSC_RIMC_ATTR1  \ RIFSC RIMC master attribute register 1
  $C18 constant RIFSC_RIFSC_RIMC_ATTR2  \ RIFSC RIMC master attribute register 2
  $C1C constant RIFSC_RIFSC_RIMC_ATTR3  \ RIFSC RIMC master attribute register 3
  $C20 constant RIFSC_RIFSC_RIMC_ATTR4  \ RIFSC RIMC master attribute register 4
  $C24 constant RIFSC_RIFSC_RIMC_ATTR5  \ RIFSC RIMC master attribute register 5
  $C28 constant RIFSC_RIFSC_RIMC_ATTR6  \ RIFSC RIMC master attribute register 6
  $C2C constant RIFSC_RIFSC_RIMC_ATTR7  \ RIFSC RIMC master attribute register 7
  $C30 constant RIFSC_RIFSC_RIMC_ATTR8  \ RIFSC RIMC master attribute register 8
  $C34 constant RIFSC_RIFSC_RIMC_ATTR9  \ RIFSC RIMC master attribute register 9
  $C38 constant RIFSC_RIFSC_RIMC_ATTR10 \ RIFSC RIMC master attribute register 10
  $C3C constant RIFSC_RIFSC_RIMC_ATTR11 \ RIFSC RIMC master attribute register 11
  $FB0 constant RIFSC_RIFSC_PPSR0       \ RIFSC peripheral protection status register 0
  $FB4 constant RIFSC_RIFSC_PPSR1       \ RIFSC peripheral protection status register 1
  $FB8 constant RIFSC_RIFSC_PPSR2       \ RIFSC peripheral protection status register 2
  $FBC constant RIFSC_RIFSC_PPSR3       \ RIFSC peripheral protection status register 3
  $FC0 constant RIFSC_RIFSC_PPSR4       \ RIFSC peripheral protection status register 4
  $FC4 constant RIFSC_RIFSC_PPSR5       \ RIFSC peripheral protection status register 5

: RIFSC_DEF ; [then]
