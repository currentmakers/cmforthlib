\
\ @file cryp.fs
\ @brief Cryptographic processor
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000004 constant CRYP_CR_ALGODIR                                  \ Algorithm direction
$00000038 constant CRYP_CR_ALGOMODE0                                \ Algorithm mode
$000000c0 constant CRYP_CR_DATATYPE                                 \ Data type selection
$00000300 constant CRYP_CR_KEYSIZE                                  \ Key size selection (AES mode only)
$00004000 constant CRYP_CR_FFLUSH                                   \ FIFO flush
$00008000 constant CRYP_CR_CRYPEN                                   \ Cryptographic processor enable
$00030000 constant CRYP_CR_GCM_CCMPH                                \ GCM_CCMPH
$00080000 constant CRYP_CR_ALGOMODE3                                \ ALGOMODE


\
\ @brief status register
\ Address offset: 0x04
\ Reset value: 0x00000003
\

$00000001 constant CRYP_SR_IFEM                                     \ Input FIFO empty
$00000002 constant CRYP_SR_IFNF                                     \ Input FIFO not full
$00000004 constant CRYP_SR_OFNE                                     \ Output FIFO not empty
$00000008 constant CRYP_SR_OFFU                                     \ Output FIFO full
$00000010 constant CRYP_SR_BUSY                                     \ Busy bit


\
\ @brief data input register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant CRYP_DIN_DATAIN                                  \ Data input


\
\ @brief data output register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_DOUT_DATAOUT                                \ Data output


\
\ @brief DMA control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant CRYP_DMACR_DIEN                                  \ DMA input enable
$00000002 constant CRYP_DMACR_DOEN                                  \ DMA output enable


\
\ @brief interrupt mask set/clear register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant CRYP_IMSCR_INIM                                  \ Input FIFO service interrupt mask
$00000002 constant CRYP_IMSCR_OUTIM                                 \ Output FIFO service interrupt mask


\
\ @brief raw interrupt status register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$00000001 constant CRYP_RISR_INRIS                                  \ Input FIFO service raw interrupt status
$00000002 constant CRYP_RISR_OUTRIS                                 \ Output FIFO service raw interrupt status


\
\ @brief masked interrupt status register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant CRYP_MISR_INMIS                                  \ Input FIFO service masked interrupt status
$00000002 constant CRYP_MISR_OUTMIS                                 \ Output FIFO service masked interrupt status


\
\ @brief key registers
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant CRYP_K0LR_K224                                   \ K224
$00000002 constant CRYP_K0LR_K225                                   \ K225
$00000004 constant CRYP_K0LR_K226                                   \ K226
$00000008 constant CRYP_K0LR_K227                                   \ K227
$00000010 constant CRYP_K0LR_K228                                   \ K228
$00000020 constant CRYP_K0LR_K229                                   \ K229
$00000040 constant CRYP_K0LR_K230                                   \ K230
$00000080 constant CRYP_K0LR_K231                                   \ K231
$00000100 constant CRYP_K0LR_K232                                   \ K232
$00000200 constant CRYP_K0LR_K233                                   \ K233
$00000400 constant CRYP_K0LR_K234                                   \ K234
$00000800 constant CRYP_K0LR_K235                                   \ K235
$00001000 constant CRYP_K0LR_K236                                   \ K236
$00002000 constant CRYP_K0LR_K237                                   \ K237
$00004000 constant CRYP_K0LR_K238                                   \ K238
$00008000 constant CRYP_K0LR_K239                                   \ K239
$00010000 constant CRYP_K0LR_K240                                   \ K240
$00020000 constant CRYP_K0LR_K241                                   \ K241
$00040000 constant CRYP_K0LR_K242                                   \ K242
$00080000 constant CRYP_K0LR_K243                                   \ K243
$00100000 constant CRYP_K0LR_K244                                   \ K244
$00200000 constant CRYP_K0LR_K245                                   \ K245
$00400000 constant CRYP_K0LR_K246                                   \ K246
$00800000 constant CRYP_K0LR_K247                                   \ K247
$01000000 constant CRYP_K0LR_K248                                   \ K248
$02000000 constant CRYP_K0LR_K249                                   \ K249
$04000000 constant CRYP_K0LR_K250                                   \ K250
$08000000 constant CRYP_K0LR_K251                                   \ K251
$10000000 constant CRYP_K0LR_K252                                   \ K252
$20000000 constant CRYP_K0LR_K253                                   \ K253
$40000000 constant CRYP_K0LR_K254                                   \ K254
$80000000 constant CRYP_K0LR_K255                                   \ K255


\
\ @brief key registers
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant CRYP_K0RR_K192                                   \ K192
$00000002 constant CRYP_K0RR_K193                                   \ K193
$00000004 constant CRYP_K0RR_K194                                   \ K194
$00000008 constant CRYP_K0RR_K195                                   \ K195
$00000010 constant CRYP_K0RR_K196                                   \ K196
$00000020 constant CRYP_K0RR_K197                                   \ K197
$00000040 constant CRYP_K0RR_K198                                   \ K198
$00000080 constant CRYP_K0RR_K199                                   \ K199
$00000100 constant CRYP_K0RR_K200                                   \ K200
$00000200 constant CRYP_K0RR_K201                                   \ K201
$00000400 constant CRYP_K0RR_K202                                   \ K202
$00000800 constant CRYP_K0RR_K203                                   \ K203
$00001000 constant CRYP_K0RR_K204                                   \ K204
$00002000 constant CRYP_K0RR_K205                                   \ K205
$00004000 constant CRYP_K0RR_K206                                   \ K206
$00008000 constant CRYP_K0RR_K207                                   \ K207
$00010000 constant CRYP_K0RR_K208                                   \ K208
$00020000 constant CRYP_K0RR_K209                                   \ K209
$00040000 constant CRYP_K0RR_K210                                   \ K210
$00080000 constant CRYP_K0RR_K211                                   \ K211
$00100000 constant CRYP_K0RR_K212                                   \ K212
$00200000 constant CRYP_K0RR_K213                                   \ K213
$00400000 constant CRYP_K0RR_K214                                   \ K214
$00800000 constant CRYP_K0RR_K215                                   \ K215
$01000000 constant CRYP_K0RR_K216                                   \ K216
$02000000 constant CRYP_K0RR_K217                                   \ K217
$04000000 constant CRYP_K0RR_K218                                   \ K218
$08000000 constant CRYP_K0RR_K219                                   \ K219
$10000000 constant CRYP_K0RR_K220                                   \ K220
$20000000 constant CRYP_K0RR_K221                                   \ K221
$40000000 constant CRYP_K0RR_K222                                   \ K222
$80000000 constant CRYP_K0RR_K223                                   \ K223


\
\ @brief key registers
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant CRYP_K1LR_K160                                   \ K160
$00000002 constant CRYP_K1LR_K161                                   \ K161
$00000004 constant CRYP_K1LR_K162                                   \ K162
$00000008 constant CRYP_K1LR_K163                                   \ K163
$00000010 constant CRYP_K1LR_K164                                   \ K164
$00000020 constant CRYP_K1LR_K165                                   \ K165
$00000040 constant CRYP_K1LR_K166                                   \ K166
$00000080 constant CRYP_K1LR_K167                                   \ K167
$00000100 constant CRYP_K1LR_K168                                   \ K168
$00000200 constant CRYP_K1LR_K169                                   \ K169
$00000400 constant CRYP_K1LR_K170                                   \ K170
$00000800 constant CRYP_K1LR_K171                                   \ K171
$00001000 constant CRYP_K1LR_K172                                   \ K172
$00002000 constant CRYP_K1LR_K173                                   \ K173
$00004000 constant CRYP_K1LR_K174                                   \ K174
$00008000 constant CRYP_K1LR_K175                                   \ K175
$00010000 constant CRYP_K1LR_K176                                   \ K176
$00020000 constant CRYP_K1LR_K177                                   \ K177
$00040000 constant CRYP_K1LR_K178                                   \ K178
$00080000 constant CRYP_K1LR_K179                                   \ K179
$00100000 constant CRYP_K1LR_K180                                   \ K180
$00200000 constant CRYP_K1LR_K181                                   \ K181
$00400000 constant CRYP_K1LR_K182                                   \ K182
$00800000 constant CRYP_K1LR_K183                                   \ K183
$01000000 constant CRYP_K1LR_K184                                   \ K184
$02000000 constant CRYP_K1LR_K185                                   \ K185
$04000000 constant CRYP_K1LR_K186                                   \ K186
$08000000 constant CRYP_K1LR_K187                                   \ K187
$10000000 constant CRYP_K1LR_K188                                   \ K188
$20000000 constant CRYP_K1LR_K189                                   \ K189
$40000000 constant CRYP_K1LR_K190                                   \ K190
$80000000 constant CRYP_K1LR_K191                                   \ K191


\
\ @brief key registers
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant CRYP_K1RR_K128                                   \ K128
$00000002 constant CRYP_K1RR_K129                                   \ K129
$00000004 constant CRYP_K1RR_K130                                   \ K130
$00000008 constant CRYP_K1RR_K131                                   \ K131
$00000010 constant CRYP_K1RR_K132                                   \ K132
$00000020 constant CRYP_K1RR_K133                                   \ K133
$00000040 constant CRYP_K1RR_K134                                   \ K134
$00000080 constant CRYP_K1RR_K135                                   \ K135
$00000100 constant CRYP_K1RR_K136                                   \ K136
$00000200 constant CRYP_K1RR_K137                                   \ K137
$00000400 constant CRYP_K1RR_K138                                   \ K138
$00000800 constant CRYP_K1RR_K139                                   \ K139
$00001000 constant CRYP_K1RR_K140                                   \ K140
$00002000 constant CRYP_K1RR_K141                                   \ K141
$00004000 constant CRYP_K1RR_K142                                   \ K142
$00008000 constant CRYP_K1RR_K143                                   \ K143
$00010000 constant CRYP_K1RR_K144                                   \ K144
$00020000 constant CRYP_K1RR_K145                                   \ K145
$00040000 constant CRYP_K1RR_K146                                   \ K146
$00080000 constant CRYP_K1RR_K147                                   \ K147
$00100000 constant CRYP_K1RR_K148                                   \ K148
$00200000 constant CRYP_K1RR_K149                                   \ K149
$00400000 constant CRYP_K1RR_K150                                   \ K150
$00800000 constant CRYP_K1RR_K151                                   \ K151
$01000000 constant CRYP_K1RR_K152                                   \ K152
$02000000 constant CRYP_K1RR_K153                                   \ K153
$04000000 constant CRYP_K1RR_K154                                   \ K154
$08000000 constant CRYP_K1RR_K155                                   \ K155
$10000000 constant CRYP_K1RR_K156                                   \ K156
$20000000 constant CRYP_K1RR_K157                                   \ K157
$40000000 constant CRYP_K1RR_K158                                   \ K158
$80000000 constant CRYP_K1RR_K159                                   \ K159


\
\ @brief key registers
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant CRYP_K2LR_K96                                    \ K96
$00000002 constant CRYP_K2LR_K97                                    \ K97
$00000004 constant CRYP_K2LR_K98                                    \ K98
$00000008 constant CRYP_K2LR_K99                                    \ K99
$00000010 constant CRYP_K2LR_K100                                   \ K100
$00000020 constant CRYP_K2LR_K101                                   \ K101
$00000040 constant CRYP_K2LR_K102                                   \ K102
$00000080 constant CRYP_K2LR_K103                                   \ K103
$00000100 constant CRYP_K2LR_K104                                   \ K104
$00000200 constant CRYP_K2LR_K105                                   \ K105
$00000400 constant CRYP_K2LR_K106                                   \ K106
$00000800 constant CRYP_K2LR_K107                                   \ K107
$00001000 constant CRYP_K2LR_K108                                   \ K108
$00002000 constant CRYP_K2LR_K109                                   \ K109
$00004000 constant CRYP_K2LR_K110                                   \ K110
$00008000 constant CRYP_K2LR_K111                                   \ K111
$00010000 constant CRYP_K2LR_K112                                   \ K112
$00020000 constant CRYP_K2LR_K113                                   \ K113
$00040000 constant CRYP_K2LR_K114                                   \ K114
$00080000 constant CRYP_K2LR_K115                                   \ K115
$00100000 constant CRYP_K2LR_K116                                   \ K116
$00200000 constant CRYP_K2LR_K117                                   \ K117
$00400000 constant CRYP_K2LR_K118                                   \ K118
$00800000 constant CRYP_K2LR_K119                                   \ K119
$01000000 constant CRYP_K2LR_K120                                   \ K120
$02000000 constant CRYP_K2LR_K121                                   \ K121
$04000000 constant CRYP_K2LR_K122                                   \ K122
$08000000 constant CRYP_K2LR_K123                                   \ K123
$10000000 constant CRYP_K2LR_K124                                   \ K124
$20000000 constant CRYP_K2LR_K125                                   \ K125
$40000000 constant CRYP_K2LR_K126                                   \ K126
$80000000 constant CRYP_K2LR_K127                                   \ K127


\
\ @brief key registers
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant CRYP_K2RR_K64                                    \ K64
$00000002 constant CRYP_K2RR_K65                                    \ K65
$00000004 constant CRYP_K2RR_K66                                    \ K66
$00000008 constant CRYP_K2RR_K67                                    \ K67
$00000010 constant CRYP_K2RR_K68                                    \ K68
$00000020 constant CRYP_K2RR_K69                                    \ K69
$00000040 constant CRYP_K2RR_K70                                    \ K70
$00000080 constant CRYP_K2RR_K71                                    \ K71
$00000100 constant CRYP_K2RR_K72                                    \ K72
$00000200 constant CRYP_K2RR_K73                                    \ K73
$00000400 constant CRYP_K2RR_K74                                    \ K74
$00000800 constant CRYP_K2RR_K75                                    \ K75
$00001000 constant CRYP_K2RR_K76                                    \ K76
$00002000 constant CRYP_K2RR_K77                                    \ K77
$00004000 constant CRYP_K2RR_K78                                    \ K78
$00008000 constant CRYP_K2RR_K79                                    \ K79
$00010000 constant CRYP_K2RR_K80                                    \ K80
$00020000 constant CRYP_K2RR_K81                                    \ K81
$00040000 constant CRYP_K2RR_K82                                    \ K82
$00080000 constant CRYP_K2RR_K83                                    \ K83
$00100000 constant CRYP_K2RR_K84                                    \ K84
$00200000 constant CRYP_K2RR_K85                                    \ K85
$00400000 constant CRYP_K2RR_K86                                    \ K86
$00800000 constant CRYP_K2RR_K87                                    \ K87
$01000000 constant CRYP_K2RR_K88                                    \ K88
$02000000 constant CRYP_K2RR_K89                                    \ K89
$04000000 constant CRYP_K2RR_K90                                    \ K90
$08000000 constant CRYP_K2RR_K91                                    \ K91
$10000000 constant CRYP_K2RR_K92                                    \ K92
$20000000 constant CRYP_K2RR_K93                                    \ K93
$40000000 constant CRYP_K2RR_K94                                    \ K94
$80000000 constant CRYP_K2RR_K95                                    \ K95


\
\ @brief key registers
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant CRYP_K3LR_K32                                    \ K32
$00000002 constant CRYP_K3LR_K33                                    \ K33
$00000004 constant CRYP_K3LR_K34                                    \ K34
$00000008 constant CRYP_K3LR_K35                                    \ K35
$00000010 constant CRYP_K3LR_K36                                    \ K36
$00000020 constant CRYP_K3LR_K37                                    \ K37
$00000040 constant CRYP_K3LR_K38                                    \ K38
$00000080 constant CRYP_K3LR_K39                                    \ K39
$00000100 constant CRYP_K3LR_K40                                    \ K40
$00000200 constant CRYP_K3LR_K41                                    \ K41
$00000400 constant CRYP_K3LR_K42                                    \ K42
$00000800 constant CRYP_K3LR_K43                                    \ K43
$00001000 constant CRYP_K3LR_K44                                    \ K44
$00002000 constant CRYP_K3LR_K45                                    \ K45
$00004000 constant CRYP_K3LR_K46                                    \ K46
$00008000 constant CRYP_K3LR_K47                                    \ K47
$00010000 constant CRYP_K3LR_K48                                    \ K48
$00020000 constant CRYP_K3LR_K49                                    \ K49
$00040000 constant CRYP_K3LR_K50                                    \ K50
$00080000 constant CRYP_K3LR_K51                                    \ K51
$00100000 constant CRYP_K3LR_K52                                    \ K52
$00200000 constant CRYP_K3LR_K53                                    \ K53
$00400000 constant CRYP_K3LR_K54                                    \ K54
$00800000 constant CRYP_K3LR_K55                                    \ K55
$01000000 constant CRYP_K3LR_K56                                    \ K56
$02000000 constant CRYP_K3LR_K57                                    \ K57
$04000000 constant CRYP_K3LR_K58                                    \ K58
$08000000 constant CRYP_K3LR_K59                                    \ K59
$10000000 constant CRYP_K3LR_K60                                    \ K60
$20000000 constant CRYP_K3LR_K61                                    \ K61
$40000000 constant CRYP_K3LR_K62                                    \ K62
$80000000 constant CRYP_K3LR_K63                                    \ K63


\
\ @brief key registers
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant CRYP_K3RR_K0                                     \ K0
$00000002 constant CRYP_K3RR_K1                                     \ K1
$00000004 constant CRYP_K3RR_K2                                     \ K2
$00000008 constant CRYP_K3RR_K3                                     \ K3
$00000010 constant CRYP_K3RR_K4                                     \ K4
$00000020 constant CRYP_K3RR_K5                                     \ K5
$00000040 constant CRYP_K3RR_K6                                     \ K6
$00000080 constant CRYP_K3RR_K7                                     \ K7
$00000100 constant CRYP_K3RR_K8                                     \ K8
$00000200 constant CRYP_K3RR_K9                                     \ K9
$00000400 constant CRYP_K3RR_K10                                    \ K10
$00000800 constant CRYP_K3RR_K11                                    \ K11
$00001000 constant CRYP_K3RR_K12                                    \ K12
$00002000 constant CRYP_K3RR_K13                                    \ K13
$00004000 constant CRYP_K3RR_K14                                    \ K14
$00008000 constant CRYP_K3RR_K15                                    \ K15
$00010000 constant CRYP_K3RR_K16                                    \ K16
$00020000 constant CRYP_K3RR_K17                                    \ K17
$00040000 constant CRYP_K3RR_K18                                    \ K18
$00080000 constant CRYP_K3RR_K19                                    \ K19
$00100000 constant CRYP_K3RR_K20                                    \ K20
$00200000 constant CRYP_K3RR_K21                                    \ K21
$00400000 constant CRYP_K3RR_K22                                    \ K22
$00800000 constant CRYP_K3RR_K23                                    \ K23
$01000000 constant CRYP_K3RR_K24                                    \ K24
$02000000 constant CRYP_K3RR_K25                                    \ K25
$04000000 constant CRYP_K3RR_K26                                    \ K26
$08000000 constant CRYP_K3RR_K27                                    \ K27
$10000000 constant CRYP_K3RR_K28                                    \ K28
$20000000 constant CRYP_K3RR_K29                                    \ K29
$40000000 constant CRYP_K3RR_K30                                    \ K30
$80000000 constant CRYP_K3RR_K31                                    \ K31


\
\ @brief initialization vector registers
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant CRYP_IV0LR_IV31                                  \ IV31
$00000002 constant CRYP_IV0LR_IV30                                  \ IV30
$00000004 constant CRYP_IV0LR_IV29                                  \ IV29
$00000008 constant CRYP_IV0LR_IV28                                  \ IV28
$00000010 constant CRYP_IV0LR_IV27                                  \ IV27
$00000020 constant CRYP_IV0LR_IV26                                  \ IV26
$00000040 constant CRYP_IV0LR_IV25                                  \ IV25
$00000080 constant CRYP_IV0LR_IV24                                  \ IV24
$00000100 constant CRYP_IV0LR_IV23                                  \ IV23
$00000200 constant CRYP_IV0LR_IV22                                  \ IV22
$00000400 constant CRYP_IV0LR_IV21                                  \ IV21
$00000800 constant CRYP_IV0LR_IV20                                  \ IV20
$00001000 constant CRYP_IV0LR_IV19                                  \ IV19
$00002000 constant CRYP_IV0LR_IV18                                  \ IV18
$00004000 constant CRYP_IV0LR_IV17                                  \ IV17
$00008000 constant CRYP_IV0LR_IV16                                  \ IV16
$00010000 constant CRYP_IV0LR_IV15                                  \ IV15
$00020000 constant CRYP_IV0LR_IV14                                  \ IV14
$00040000 constant CRYP_IV0LR_IV13                                  \ IV13
$00080000 constant CRYP_IV0LR_IV12                                  \ IV12
$00100000 constant CRYP_IV0LR_IV11                                  \ IV11
$00200000 constant CRYP_IV0LR_IV10                                  \ IV10
$00400000 constant CRYP_IV0LR_IV9                                   \ IV9
$00800000 constant CRYP_IV0LR_IV8                                   \ IV8
$01000000 constant CRYP_IV0LR_IV7                                   \ IV7
$02000000 constant CRYP_IV0LR_IV6                                   \ IV6
$04000000 constant CRYP_IV0LR_IV5                                   \ IV5
$08000000 constant CRYP_IV0LR_IV4                                   \ IV4
$10000000 constant CRYP_IV0LR_IV3                                   \ IV3
$20000000 constant CRYP_IV0LR_IV2                                   \ IV2
$40000000 constant CRYP_IV0LR_IV1                                   \ IV1
$80000000 constant CRYP_IV0LR_IV0                                   \ IV0


\
\ @brief initialization vector registers
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant CRYP_IV0RR_IV63                                  \ IV63
$00000002 constant CRYP_IV0RR_IV62                                  \ IV62
$00000004 constant CRYP_IV0RR_IV61                                  \ IV61
$00000008 constant CRYP_IV0RR_IV60                                  \ IV60
$00000010 constant CRYP_IV0RR_IV59                                  \ IV59
$00000020 constant CRYP_IV0RR_IV58                                  \ IV58
$00000040 constant CRYP_IV0RR_IV57                                  \ IV57
$00000080 constant CRYP_IV0RR_IV56                                  \ IV56
$00000100 constant CRYP_IV0RR_IV55                                  \ IV55
$00000200 constant CRYP_IV0RR_IV54                                  \ IV54
$00000400 constant CRYP_IV0RR_IV53                                  \ IV53
$00000800 constant CRYP_IV0RR_IV52                                  \ IV52
$00001000 constant CRYP_IV0RR_IV51                                  \ IV51
$00002000 constant CRYP_IV0RR_IV50                                  \ IV50
$00004000 constant CRYP_IV0RR_IV49                                  \ IV49
$00008000 constant CRYP_IV0RR_IV48                                  \ IV48
$00010000 constant CRYP_IV0RR_IV47                                  \ IV47
$00020000 constant CRYP_IV0RR_IV46                                  \ IV46
$00040000 constant CRYP_IV0RR_IV45                                  \ IV45
$00080000 constant CRYP_IV0RR_IV44                                  \ IV44
$00100000 constant CRYP_IV0RR_IV43                                  \ IV43
$00200000 constant CRYP_IV0RR_IV42                                  \ IV42
$00400000 constant CRYP_IV0RR_IV41                                  \ IV41
$00800000 constant CRYP_IV0RR_IV40                                  \ IV40
$01000000 constant CRYP_IV0RR_IV39                                  \ IV39
$02000000 constant CRYP_IV0RR_IV38                                  \ IV38
$04000000 constant CRYP_IV0RR_IV37                                  \ IV37
$08000000 constant CRYP_IV0RR_IV36                                  \ IV36
$10000000 constant CRYP_IV0RR_IV35                                  \ IV35
$20000000 constant CRYP_IV0RR_IV34                                  \ IV34
$40000000 constant CRYP_IV0RR_IV33                                  \ IV33
$80000000 constant CRYP_IV0RR_IV32                                  \ IV32


\
\ @brief initialization vector registers
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant CRYP_IV1LR_IV95                                  \ IV95
$00000002 constant CRYP_IV1LR_IV94                                  \ IV94
$00000004 constant CRYP_IV1LR_IV93                                  \ IV93
$00000008 constant CRYP_IV1LR_IV92                                  \ IV92
$00000010 constant CRYP_IV1LR_IV91                                  \ IV91
$00000020 constant CRYP_IV1LR_IV90                                  \ IV90
$00000040 constant CRYP_IV1LR_IV89                                  \ IV89
$00000080 constant CRYP_IV1LR_IV88                                  \ IV88
$00000100 constant CRYP_IV1LR_IV87                                  \ IV87
$00000200 constant CRYP_IV1LR_IV86                                  \ IV86
$00000400 constant CRYP_IV1LR_IV85                                  \ IV85
$00000800 constant CRYP_IV1LR_IV84                                  \ IV84
$00001000 constant CRYP_IV1LR_IV83                                  \ IV83
$00002000 constant CRYP_IV1LR_IV82                                  \ IV82
$00004000 constant CRYP_IV1LR_IV81                                  \ IV81
$00008000 constant CRYP_IV1LR_IV80                                  \ IV80
$00010000 constant CRYP_IV1LR_IV79                                  \ IV79
$00020000 constant CRYP_IV1LR_IV78                                  \ IV78
$00040000 constant CRYP_IV1LR_IV77                                  \ IV77
$00080000 constant CRYP_IV1LR_IV76                                  \ IV76
$00100000 constant CRYP_IV1LR_IV75                                  \ IV75
$00200000 constant CRYP_IV1LR_IV74                                  \ IV74
$00400000 constant CRYP_IV1LR_IV73                                  \ IV73
$00800000 constant CRYP_IV1LR_IV72                                  \ IV72
$01000000 constant CRYP_IV1LR_IV71                                  \ IV71
$02000000 constant CRYP_IV1LR_IV70                                  \ IV70
$04000000 constant CRYP_IV1LR_IV69                                  \ IV69
$08000000 constant CRYP_IV1LR_IV68                                  \ IV68
$10000000 constant CRYP_IV1LR_IV67                                  \ IV67
$20000000 constant CRYP_IV1LR_IV66                                  \ IV66
$40000000 constant CRYP_IV1LR_IV65                                  \ IV65
$80000000 constant CRYP_IV1LR_IV64                                  \ IV64


\
\ @brief initialization vector registers
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant CRYP_IV1RR_IV127                                 \ IV127
$00000002 constant CRYP_IV1RR_IV126                                 \ IV126
$00000004 constant CRYP_IV1RR_IV125                                 \ IV125
$00000008 constant CRYP_IV1RR_IV124                                 \ IV124
$00000010 constant CRYP_IV1RR_IV123                                 \ IV123
$00000020 constant CRYP_IV1RR_IV122                                 \ IV122
$00000040 constant CRYP_IV1RR_IV121                                 \ IV121
$00000080 constant CRYP_IV1RR_IV120                                 \ IV120
$00000100 constant CRYP_IV1RR_IV119                                 \ IV119
$00000200 constant CRYP_IV1RR_IV118                                 \ IV118
$00000400 constant CRYP_IV1RR_IV117                                 \ IV117
$00000800 constant CRYP_IV1RR_IV116                                 \ IV116
$00001000 constant CRYP_IV1RR_IV115                                 \ IV115
$00002000 constant CRYP_IV1RR_IV114                                 \ IV114
$00004000 constant CRYP_IV1RR_IV113                                 \ IV113
$00008000 constant CRYP_IV1RR_IV112                                 \ IV112
$00010000 constant CRYP_IV1RR_IV111                                 \ IV111
$00020000 constant CRYP_IV1RR_IV110                                 \ IV110
$00040000 constant CRYP_IV1RR_IV109                                 \ IV109
$00080000 constant CRYP_IV1RR_IV108                                 \ IV108
$00100000 constant CRYP_IV1RR_IV107                                 \ IV107
$00200000 constant CRYP_IV1RR_IV106                                 \ IV106
$00400000 constant CRYP_IV1RR_IV105                                 \ IV105
$00800000 constant CRYP_IV1RR_IV104                                 \ IV104
$01000000 constant CRYP_IV1RR_IV103                                 \ IV103
$02000000 constant CRYP_IV1RR_IV102                                 \ IV102
$04000000 constant CRYP_IV1RR_IV101                                 \ IV101
$08000000 constant CRYP_IV1RR_IV100                                 \ IV100
$10000000 constant CRYP_IV1RR_IV99                                  \ IV99
$20000000 constant CRYP_IV1RR_IV98                                  \ IV98
$40000000 constant CRYP_IV1RR_IV97                                  \ IV97
$80000000 constant CRYP_IV1RR_IV96                                  \ IV96


\
\ @brief context swap register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCMCCM0R_CSGCMCCM0                        \ CSGCMCCM0


\
\ @brief context swap register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCMCCM1R_CSGCMCCM1                        \ CSGCMCCM1


\
\ @brief context swap register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCMCCM2R_CSGCMCCM2                        \ CSGCMCCM2


\
\ @brief context swap register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCMCCM3R_CSGCMCCM3                        \ CSGCMCCM3


\
\ @brief context swap register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCMCCM4R_CSGCMCCM4                        \ CSGCMCCM4


\
\ @brief context swap register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCMCCM5R_CSGCMCCM5                        \ CSGCMCCM5


\
\ @brief context swap register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCMCCM6R_CSGCMCCM6                        \ CSGCMCCM6


\
\ @brief context swap register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCMCCM7R_CSGCMCCM7                        \ CSGCMCCM7


\
\ @brief context swap register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCM0R_CSGCM0                              \ CSGCM0


\
\ @brief context swap register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCM1R_CSGCM1                              \ CSGCM1


\
\ @brief context swap register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCM2R_CSGCM2                              \ CSGCM2


\
\ @brief context swap register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCM3R_CSGCM3                              \ CSGCM3


\
\ @brief context swap register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCM4R_CSGCM4                              \ CSGCM4


\
\ @brief context swap register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCM5R_CSGCM5                              \ CSGCM5


\
\ @brief context swap register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCM6R_CSGCM6                              \ CSGCM6


\
\ @brief context swap register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCM7R_CSGCM7                              \ CSGCM7


\
\ @brief Cryptographic processor
\
$48021000 constant CRYP_CR        \ offset: 0x00 : control register
$48021004 constant CRYP_SR        \ offset: 0x04 : status register
$48021008 constant CRYP_DIN       \ offset: 0x08 : data input register
$4802100c constant CRYP_DOUT      \ offset: 0x0C : data output register
$48021010 constant CRYP_DMACR     \ offset: 0x10 : DMA control register
$48021014 constant CRYP_IMSCR     \ offset: 0x14 : interrupt mask set/clear register
$48021018 constant CRYP_RISR      \ offset: 0x18 : raw interrupt status register
$4802101c constant CRYP_MISR      \ offset: 0x1C : masked interrupt status register
$48021020 constant CRYP_K0LR      \ offset: 0x20 : key registers
$48021024 constant CRYP_K0RR      \ offset: 0x24 : key registers
$48021028 constant CRYP_K1LR      \ offset: 0x28 : key registers
$4802102c constant CRYP_K1RR      \ offset: 0x2C : key registers
$48021030 constant CRYP_K2LR      \ offset: 0x30 : key registers
$48021034 constant CRYP_K2RR      \ offset: 0x34 : key registers
$48021038 constant CRYP_K3LR      \ offset: 0x38 : key registers
$4802103c constant CRYP_K3RR      \ offset: 0x3C : key registers
$48021040 constant CRYP_IV0LR     \ offset: 0x40 : initialization vector registers
$48021044 constant CRYP_IV0RR     \ offset: 0x44 : initialization vector registers
$48021048 constant CRYP_IV1LR     \ offset: 0x48 : initialization vector registers
$4802104c constant CRYP_IV1RR     \ offset: 0x4C : initialization vector registers
$48021050 constant CRYP_CSGCMCCM0R  \ offset: 0x50 : context swap register
$48021054 constant CRYP_CSGCMCCM1R  \ offset: 0x54 : context swap register
$48021058 constant CRYP_CSGCMCCM2R  \ offset: 0x58 : context swap register
$4802105c constant CRYP_CSGCMCCM3R  \ offset: 0x5C : context swap register
$48021060 constant CRYP_CSGCMCCM4R  \ offset: 0x60 : context swap register
$48021064 constant CRYP_CSGCMCCM5R  \ offset: 0x64 : context swap register
$48021068 constant CRYP_CSGCMCCM6R  \ offset: 0x68 : context swap register
$4802106c constant CRYP_CSGCMCCM7R  \ offset: 0x6C : context swap register
$48021070 constant CRYP_CSGCM0R   \ offset: 0x70 : context swap register
$48021074 constant CRYP_CSGCM1R   \ offset: 0x74 : context swap register
$48021078 constant CRYP_CSGCM2R   \ offset: 0x78 : context swap register
$4802107c constant CRYP_CSGCM3R   \ offset: 0x7C : context swap register
$48021080 constant CRYP_CSGCM4R   \ offset: 0x80 : context swap register
$48021084 constant CRYP_CSGCM5R   \ offset: 0x84 : context swap register
$48021088 constant CRYP_CSGCM6R   \ offset: 0x88 : context swap register
$4802108c constant CRYP_CSGCM7R   \ offset: 0x8C : context swap register

