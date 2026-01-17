\
\ @file cryp.fs
\ @brief Cryptographic processor
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] CRYP_DEF

  [ifdef] CRYP_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $02 constant CRYP_ALGODIR                   \ [0x02] Algorithm direction
    $03 constant CRYP_ALGOMODE0                 \ [0x03 : 3] Algorithm mode
    $06 constant CRYP_DATATYPE                  \ [0x06 : 2] Data type selection
    $08 constant CRYP_KEYSIZE                   \ [0x08 : 2] Key size selection (AES mode only)
    $0e constant CRYP_FFLUSH                    \ [0x0e] FIFO flush
    $0f constant CRYP_CRYPEN                    \ [0x0f] Cryptographic processor enable
    $10 constant CRYP_GCM_CCMPH                 \ [0x10 : 2] GCM_CCMPH
    $13 constant CRYP_ALGOMODE3                 \ [0x13] ALGOMODE
  [then]


  [ifdef] CRYP_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x04
    \ Reset value: 0x00000003
    \
    $00 constant CRYP_IFEM                      \ [0x00] Input FIFO empty
    $01 constant CRYP_IFNF                      \ [0x01] Input FIFO not full
    $02 constant CRYP_OFNE                      \ [0x02] Output FIFO not empty
    $03 constant CRYP_OFFU                      \ [0x03] Output FIFO full
    $04 constant CRYP_BUSY                      \ [0x04] Busy bit
  [then]


  [ifdef] CRYP_DIN_DEF
    \
    \ @brief data input register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_DATAIN                    \ [0x00 : 32] Data input
  [then]


  [ifdef] CRYP_DOUT_DEF
    \
    \ @brief data output register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_DATAOUT                   \ [0x00 : 32] Data output
  [then]


  [ifdef] CRYP_DMACR_DEF
    \
    \ @brief DMA control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_DIEN                      \ [0x00] DMA input enable
    $01 constant CRYP_DOEN                      \ [0x01] DMA output enable
  [then]


  [ifdef] CRYP_IMSCR_DEF
    \
    \ @brief interrupt mask set/clear register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_INIM                      \ [0x00] Input FIFO service interrupt mask
    $01 constant CRYP_OUTIM                     \ [0x01] Output FIFO service interrupt mask
  [then]


  [ifdef] CRYP_RISR_DEF
    \
    \ @brief raw interrupt status register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant CRYP_INRIS                     \ [0x00] Input FIFO service raw interrupt status
    $01 constant CRYP_OUTRIS                    \ [0x01] Output FIFO service raw interrupt status
  [then]


  [ifdef] CRYP_MISR_DEF
    \
    \ @brief masked interrupt status register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_INMIS                     \ [0x00] Input FIFO service masked interrupt status
    $01 constant CRYP_OUTMIS                    \ [0x01] Output FIFO service masked interrupt status
  [then]


  [ifdef] CRYP_K0LR_DEF
    \
    \ @brief key registers
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K224                      \ [0x00] K224
    $01 constant CRYP_K225                      \ [0x01] K225
    $02 constant CRYP_K226                      \ [0x02] K226
    $03 constant CRYP_K227                      \ [0x03] K227
    $04 constant CRYP_K228                      \ [0x04] K228
    $05 constant CRYP_K229                      \ [0x05] K229
    $06 constant CRYP_K230                      \ [0x06] K230
    $07 constant CRYP_K231                      \ [0x07] K231
    $08 constant CRYP_K232                      \ [0x08] K232
    $09 constant CRYP_K233                      \ [0x09] K233
    $0a constant CRYP_K234                      \ [0x0a] K234
    $0b constant CRYP_K235                      \ [0x0b] K235
    $0c constant CRYP_K236                      \ [0x0c] K236
    $0d constant CRYP_K237                      \ [0x0d] K237
    $0e constant CRYP_K238                      \ [0x0e] K238
    $0f constant CRYP_K239                      \ [0x0f] K239
    $10 constant CRYP_K240                      \ [0x10] K240
    $11 constant CRYP_K241                      \ [0x11] K241
    $12 constant CRYP_K242                      \ [0x12] K242
    $13 constant CRYP_K243                      \ [0x13] K243
    $14 constant CRYP_K244                      \ [0x14] K244
    $15 constant CRYP_K245                      \ [0x15] K245
    $16 constant CRYP_K246                      \ [0x16] K246
    $17 constant CRYP_K247                      \ [0x17] K247
    $18 constant CRYP_K248                      \ [0x18] K248
    $19 constant CRYP_K249                      \ [0x19] K249
    $1a constant CRYP_K250                      \ [0x1a] K250
    $1b constant CRYP_K251                      \ [0x1b] K251
    $1c constant CRYP_K252                      \ [0x1c] K252
    $1d constant CRYP_K253                      \ [0x1d] K253
    $1e constant CRYP_K254                      \ [0x1e] K254
    $1f constant CRYP_K255                      \ [0x1f] K255
  [then]


  [ifdef] CRYP_K0RR_DEF
    \
    \ @brief key registers
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K192                      \ [0x00] K192
    $01 constant CRYP_K193                      \ [0x01] K193
    $02 constant CRYP_K194                      \ [0x02] K194
    $03 constant CRYP_K195                      \ [0x03] K195
    $04 constant CRYP_K196                      \ [0x04] K196
    $05 constant CRYP_K197                      \ [0x05] K197
    $06 constant CRYP_K198                      \ [0x06] K198
    $07 constant CRYP_K199                      \ [0x07] K199
    $08 constant CRYP_K200                      \ [0x08] K200
    $09 constant CRYP_K201                      \ [0x09] K201
    $0a constant CRYP_K202                      \ [0x0a] K202
    $0b constant CRYP_K203                      \ [0x0b] K203
    $0c constant CRYP_K204                      \ [0x0c] K204
    $0d constant CRYP_K205                      \ [0x0d] K205
    $0e constant CRYP_K206                      \ [0x0e] K206
    $0f constant CRYP_K207                      \ [0x0f] K207
    $10 constant CRYP_K208                      \ [0x10] K208
    $11 constant CRYP_K209                      \ [0x11] K209
    $12 constant CRYP_K210                      \ [0x12] K210
    $13 constant CRYP_K211                      \ [0x13] K211
    $14 constant CRYP_K212                      \ [0x14] K212
    $15 constant CRYP_K213                      \ [0x15] K213
    $16 constant CRYP_K214                      \ [0x16] K214
    $17 constant CRYP_K215                      \ [0x17] K215
    $18 constant CRYP_K216                      \ [0x18] K216
    $19 constant CRYP_K217                      \ [0x19] K217
    $1a constant CRYP_K218                      \ [0x1a] K218
    $1b constant CRYP_K219                      \ [0x1b] K219
    $1c constant CRYP_K220                      \ [0x1c] K220
    $1d constant CRYP_K221                      \ [0x1d] K221
    $1e constant CRYP_K222                      \ [0x1e] K222
    $1f constant CRYP_K223                      \ [0x1f] K223
  [then]


  [ifdef] CRYP_K1LR_DEF
    \
    \ @brief key registers
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K160                      \ [0x00] K160
    $01 constant CRYP_K161                      \ [0x01] K161
    $02 constant CRYP_K162                      \ [0x02] K162
    $03 constant CRYP_K163                      \ [0x03] K163
    $04 constant CRYP_K164                      \ [0x04] K164
    $05 constant CRYP_K165                      \ [0x05] K165
    $06 constant CRYP_K166                      \ [0x06] K166
    $07 constant CRYP_K167                      \ [0x07] K167
    $08 constant CRYP_K168                      \ [0x08] K168
    $09 constant CRYP_K169                      \ [0x09] K169
    $0a constant CRYP_K170                      \ [0x0a] K170
    $0b constant CRYP_K171                      \ [0x0b] K171
    $0c constant CRYP_K172                      \ [0x0c] K172
    $0d constant CRYP_K173                      \ [0x0d] K173
    $0e constant CRYP_K174                      \ [0x0e] K174
    $0f constant CRYP_K175                      \ [0x0f] K175
    $10 constant CRYP_K176                      \ [0x10] K176
    $11 constant CRYP_K177                      \ [0x11] K177
    $12 constant CRYP_K178                      \ [0x12] K178
    $13 constant CRYP_K179                      \ [0x13] K179
    $14 constant CRYP_K180                      \ [0x14] K180
    $15 constant CRYP_K181                      \ [0x15] K181
    $16 constant CRYP_K182                      \ [0x16] K182
    $17 constant CRYP_K183                      \ [0x17] K183
    $18 constant CRYP_K184                      \ [0x18] K184
    $19 constant CRYP_K185                      \ [0x19] K185
    $1a constant CRYP_K186                      \ [0x1a] K186
    $1b constant CRYP_K187                      \ [0x1b] K187
    $1c constant CRYP_K188                      \ [0x1c] K188
    $1d constant CRYP_K189                      \ [0x1d] K189
    $1e constant CRYP_K190                      \ [0x1e] K190
    $1f constant CRYP_K191                      \ [0x1f] K191
  [then]


  [ifdef] CRYP_K1RR_DEF
    \
    \ @brief key registers
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K128                      \ [0x00] K128
    $01 constant CRYP_K129                      \ [0x01] K129
    $02 constant CRYP_K130                      \ [0x02] K130
    $03 constant CRYP_K131                      \ [0x03] K131
    $04 constant CRYP_K132                      \ [0x04] K132
    $05 constant CRYP_K133                      \ [0x05] K133
    $06 constant CRYP_K134                      \ [0x06] K134
    $07 constant CRYP_K135                      \ [0x07] K135
    $08 constant CRYP_K136                      \ [0x08] K136
    $09 constant CRYP_K137                      \ [0x09] K137
    $0a constant CRYP_K138                      \ [0x0a] K138
    $0b constant CRYP_K139                      \ [0x0b] K139
    $0c constant CRYP_K140                      \ [0x0c] K140
    $0d constant CRYP_K141                      \ [0x0d] K141
    $0e constant CRYP_K142                      \ [0x0e] K142
    $0f constant CRYP_K143                      \ [0x0f] K143
    $10 constant CRYP_K144                      \ [0x10] K144
    $11 constant CRYP_K145                      \ [0x11] K145
    $12 constant CRYP_K146                      \ [0x12] K146
    $13 constant CRYP_K147                      \ [0x13] K147
    $14 constant CRYP_K148                      \ [0x14] K148
    $15 constant CRYP_K149                      \ [0x15] K149
    $16 constant CRYP_K150                      \ [0x16] K150
    $17 constant CRYP_K151                      \ [0x17] K151
    $18 constant CRYP_K152                      \ [0x18] K152
    $19 constant CRYP_K153                      \ [0x19] K153
    $1a constant CRYP_K154                      \ [0x1a] K154
    $1b constant CRYP_K155                      \ [0x1b] K155
    $1c constant CRYP_K156                      \ [0x1c] K156
    $1d constant CRYP_K157                      \ [0x1d] K157
    $1e constant CRYP_K158                      \ [0x1e] K158
    $1f constant CRYP_K159                      \ [0x1f] K159
  [then]


  [ifdef] CRYP_K2LR_DEF
    \
    \ @brief key registers
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K96                       \ [0x00] K96
    $01 constant CRYP_K97                       \ [0x01] K97
    $02 constant CRYP_K98                       \ [0x02] K98
    $03 constant CRYP_K99                       \ [0x03] K99
    $04 constant CRYP_K100                      \ [0x04] K100
    $05 constant CRYP_K101                      \ [0x05] K101
    $06 constant CRYP_K102                      \ [0x06] K102
    $07 constant CRYP_K103                      \ [0x07] K103
    $08 constant CRYP_K104                      \ [0x08] K104
    $09 constant CRYP_K105                      \ [0x09] K105
    $0a constant CRYP_K106                      \ [0x0a] K106
    $0b constant CRYP_K107                      \ [0x0b] K107
    $0c constant CRYP_K108                      \ [0x0c] K108
    $0d constant CRYP_K109                      \ [0x0d] K109
    $0e constant CRYP_K110                      \ [0x0e] K110
    $0f constant CRYP_K111                      \ [0x0f] K111
    $10 constant CRYP_K112                      \ [0x10] K112
    $11 constant CRYP_K113                      \ [0x11] K113
    $12 constant CRYP_K114                      \ [0x12] K114
    $13 constant CRYP_K115                      \ [0x13] K115
    $14 constant CRYP_K116                      \ [0x14] K116
    $15 constant CRYP_K117                      \ [0x15] K117
    $16 constant CRYP_K118                      \ [0x16] K118
    $17 constant CRYP_K119                      \ [0x17] K119
    $18 constant CRYP_K120                      \ [0x18] K120
    $19 constant CRYP_K121                      \ [0x19] K121
    $1a constant CRYP_K122                      \ [0x1a] K122
    $1b constant CRYP_K123                      \ [0x1b] K123
    $1c constant CRYP_K124                      \ [0x1c] K124
    $1d constant CRYP_K125                      \ [0x1d] K125
    $1e constant CRYP_K126                      \ [0x1e] K126
    $1f constant CRYP_K127                      \ [0x1f] K127
  [then]


  [ifdef] CRYP_K2RR_DEF
    \
    \ @brief key registers
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K64                       \ [0x00] K64
    $01 constant CRYP_K65                       \ [0x01] K65
    $02 constant CRYP_K66                       \ [0x02] K66
    $03 constant CRYP_K67                       \ [0x03] K67
    $04 constant CRYP_K68                       \ [0x04] K68
    $05 constant CRYP_K69                       \ [0x05] K69
    $06 constant CRYP_K70                       \ [0x06] K70
    $07 constant CRYP_K71                       \ [0x07] K71
    $08 constant CRYP_K72                       \ [0x08] K72
    $09 constant CRYP_K73                       \ [0x09] K73
    $0a constant CRYP_K74                       \ [0x0a] K74
    $0b constant CRYP_K75                       \ [0x0b] K75
    $0c constant CRYP_K76                       \ [0x0c] K76
    $0d constant CRYP_K77                       \ [0x0d] K77
    $0e constant CRYP_K78                       \ [0x0e] K78
    $0f constant CRYP_K79                       \ [0x0f] K79
    $10 constant CRYP_K80                       \ [0x10] K80
    $11 constant CRYP_K81                       \ [0x11] K81
    $12 constant CRYP_K82                       \ [0x12] K82
    $13 constant CRYP_K83                       \ [0x13] K83
    $14 constant CRYP_K84                       \ [0x14] K84
    $15 constant CRYP_K85                       \ [0x15] K85
    $16 constant CRYP_K86                       \ [0x16] K86
    $17 constant CRYP_K87                       \ [0x17] K87
    $18 constant CRYP_K88                       \ [0x18] K88
    $19 constant CRYP_K89                       \ [0x19] K89
    $1a constant CRYP_K90                       \ [0x1a] K90
    $1b constant CRYP_K91                       \ [0x1b] K91
    $1c constant CRYP_K92                       \ [0x1c] K92
    $1d constant CRYP_K93                       \ [0x1d] K93
    $1e constant CRYP_K94                       \ [0x1e] K94
    $1f constant CRYP_K95                       \ [0x1f] K95
  [then]


  [ifdef] CRYP_K3LR_DEF
    \
    \ @brief key registers
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K32                       \ [0x00] K32
    $01 constant CRYP_K33                       \ [0x01] K33
    $02 constant CRYP_K34                       \ [0x02] K34
    $03 constant CRYP_K35                       \ [0x03] K35
    $04 constant CRYP_K36                       \ [0x04] K36
    $05 constant CRYP_K37                       \ [0x05] K37
    $06 constant CRYP_K38                       \ [0x06] K38
    $07 constant CRYP_K39                       \ [0x07] K39
    $08 constant CRYP_K40                       \ [0x08] K40
    $09 constant CRYP_K41                       \ [0x09] K41
    $0a constant CRYP_K42                       \ [0x0a] K42
    $0b constant CRYP_K43                       \ [0x0b] K43
    $0c constant CRYP_K44                       \ [0x0c] K44
    $0d constant CRYP_K45                       \ [0x0d] K45
    $0e constant CRYP_K46                       \ [0x0e] K46
    $0f constant CRYP_K47                       \ [0x0f] K47
    $10 constant CRYP_K48                       \ [0x10] K48
    $11 constant CRYP_K49                       \ [0x11] K49
    $12 constant CRYP_K50                       \ [0x12] K50
    $13 constant CRYP_K51                       \ [0x13] K51
    $14 constant CRYP_K52                       \ [0x14] K52
    $15 constant CRYP_K53                       \ [0x15] K53
    $16 constant CRYP_K54                       \ [0x16] K54
    $17 constant CRYP_K55                       \ [0x17] K55
    $18 constant CRYP_K56                       \ [0x18] K56
    $19 constant CRYP_K57                       \ [0x19] K57
    $1a constant CRYP_K58                       \ [0x1a] K58
    $1b constant CRYP_K59                       \ [0x1b] K59
    $1c constant CRYP_K60                       \ [0x1c] K60
    $1d constant CRYP_K61                       \ [0x1d] K61
    $1e constant CRYP_K62                       \ [0x1e] K62
    $1f constant CRYP_K63                       \ [0x1f] K63
  [then]


  [ifdef] CRYP_K3RR_DEF
    \
    \ @brief key registers
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K0                        \ [0x00] K0
    $01 constant CRYP_K1                        \ [0x01] K1
    $02 constant CRYP_K2                        \ [0x02] K2
    $03 constant CRYP_K3                        \ [0x03] K3
    $04 constant CRYP_K4                        \ [0x04] K4
    $05 constant CRYP_K5                        \ [0x05] K5
    $06 constant CRYP_K6                        \ [0x06] K6
    $07 constant CRYP_K7                        \ [0x07] K7
    $08 constant CRYP_K8                        \ [0x08] K8
    $09 constant CRYP_K9                        \ [0x09] K9
    $0a constant CRYP_K10                       \ [0x0a] K10
    $0b constant CRYP_K11                       \ [0x0b] K11
    $0c constant CRYP_K12                       \ [0x0c] K12
    $0d constant CRYP_K13                       \ [0x0d] K13
    $0e constant CRYP_K14                       \ [0x0e] K14
    $0f constant CRYP_K15                       \ [0x0f] K15
    $10 constant CRYP_K16                       \ [0x10] K16
    $11 constant CRYP_K17                       \ [0x11] K17
    $12 constant CRYP_K18                       \ [0x12] K18
    $13 constant CRYP_K19                       \ [0x13] K19
    $14 constant CRYP_K20                       \ [0x14] K20
    $15 constant CRYP_K21                       \ [0x15] K21
    $16 constant CRYP_K22                       \ [0x16] K22
    $17 constant CRYP_K23                       \ [0x17] K23
    $18 constant CRYP_K24                       \ [0x18] K24
    $19 constant CRYP_K25                       \ [0x19] K25
    $1a constant CRYP_K26                       \ [0x1a] K26
    $1b constant CRYP_K27                       \ [0x1b] K27
    $1c constant CRYP_K28                       \ [0x1c] K28
    $1d constant CRYP_K29                       \ [0x1d] K29
    $1e constant CRYP_K30                       \ [0x1e] K30
    $1f constant CRYP_K31                       \ [0x1f] K31
  [then]


  [ifdef] CRYP_IV0LR_DEF
    \
    \ @brief initialization vector registers
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IV31                      \ [0x00] IV31
    $01 constant CRYP_IV30                      \ [0x01] IV30
    $02 constant CRYP_IV29                      \ [0x02] IV29
    $03 constant CRYP_IV28                      \ [0x03] IV28
    $04 constant CRYP_IV27                      \ [0x04] IV27
    $05 constant CRYP_IV26                      \ [0x05] IV26
    $06 constant CRYP_IV25                      \ [0x06] IV25
    $07 constant CRYP_IV24                      \ [0x07] IV24
    $08 constant CRYP_IV23                      \ [0x08] IV23
    $09 constant CRYP_IV22                      \ [0x09] IV22
    $0a constant CRYP_IV21                      \ [0x0a] IV21
    $0b constant CRYP_IV20                      \ [0x0b] IV20
    $0c constant CRYP_IV19                      \ [0x0c] IV19
    $0d constant CRYP_IV18                      \ [0x0d] IV18
    $0e constant CRYP_IV17                      \ [0x0e] IV17
    $0f constant CRYP_IV16                      \ [0x0f] IV16
    $10 constant CRYP_IV15                      \ [0x10] IV15
    $11 constant CRYP_IV14                      \ [0x11] IV14
    $12 constant CRYP_IV13                      \ [0x12] IV13
    $13 constant CRYP_IV12                      \ [0x13] IV12
    $14 constant CRYP_IV11                      \ [0x14] IV11
    $15 constant CRYP_IV10                      \ [0x15] IV10
    $16 constant CRYP_IV9                       \ [0x16] IV9
    $17 constant CRYP_IV8                       \ [0x17] IV8
    $18 constant CRYP_IV7                       \ [0x18] IV7
    $19 constant CRYP_IV6                       \ [0x19] IV6
    $1a constant CRYP_IV5                       \ [0x1a] IV5
    $1b constant CRYP_IV4                       \ [0x1b] IV4
    $1c constant CRYP_IV3                       \ [0x1c] IV3
    $1d constant CRYP_IV2                       \ [0x1d] IV2
    $1e constant CRYP_IV1                       \ [0x1e] IV1
    $1f constant CRYP_IV0                       \ [0x1f] IV0
  [then]


  [ifdef] CRYP_IV0RR_DEF
    \
    \ @brief initialization vector registers
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IV63                      \ [0x00] IV63
    $01 constant CRYP_IV62                      \ [0x01] IV62
    $02 constant CRYP_IV61                      \ [0x02] IV61
    $03 constant CRYP_IV60                      \ [0x03] IV60
    $04 constant CRYP_IV59                      \ [0x04] IV59
    $05 constant CRYP_IV58                      \ [0x05] IV58
    $06 constant CRYP_IV57                      \ [0x06] IV57
    $07 constant CRYP_IV56                      \ [0x07] IV56
    $08 constant CRYP_IV55                      \ [0x08] IV55
    $09 constant CRYP_IV54                      \ [0x09] IV54
    $0a constant CRYP_IV53                      \ [0x0a] IV53
    $0b constant CRYP_IV52                      \ [0x0b] IV52
    $0c constant CRYP_IV51                      \ [0x0c] IV51
    $0d constant CRYP_IV50                      \ [0x0d] IV50
    $0e constant CRYP_IV49                      \ [0x0e] IV49
    $0f constant CRYP_IV48                      \ [0x0f] IV48
    $10 constant CRYP_IV47                      \ [0x10] IV47
    $11 constant CRYP_IV46                      \ [0x11] IV46
    $12 constant CRYP_IV45                      \ [0x12] IV45
    $13 constant CRYP_IV44                      \ [0x13] IV44
    $14 constant CRYP_IV43                      \ [0x14] IV43
    $15 constant CRYP_IV42                      \ [0x15] IV42
    $16 constant CRYP_IV41                      \ [0x16] IV41
    $17 constant CRYP_IV40                      \ [0x17] IV40
    $18 constant CRYP_IV39                      \ [0x18] IV39
    $19 constant CRYP_IV38                      \ [0x19] IV38
    $1a constant CRYP_IV37                      \ [0x1a] IV37
    $1b constant CRYP_IV36                      \ [0x1b] IV36
    $1c constant CRYP_IV35                      \ [0x1c] IV35
    $1d constant CRYP_IV34                      \ [0x1d] IV34
    $1e constant CRYP_IV33                      \ [0x1e] IV33
    $1f constant CRYP_IV32                      \ [0x1f] IV32
  [then]


  [ifdef] CRYP_IV1LR_DEF
    \
    \ @brief initialization vector registers
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IV95                      \ [0x00] IV95
    $01 constant CRYP_IV94                      \ [0x01] IV94
    $02 constant CRYP_IV93                      \ [0x02] IV93
    $03 constant CRYP_IV92                      \ [0x03] IV92
    $04 constant CRYP_IV91                      \ [0x04] IV91
    $05 constant CRYP_IV90                      \ [0x05] IV90
    $06 constant CRYP_IV89                      \ [0x06] IV89
    $07 constant CRYP_IV88                      \ [0x07] IV88
    $08 constant CRYP_IV87                      \ [0x08] IV87
    $09 constant CRYP_IV86                      \ [0x09] IV86
    $0a constant CRYP_IV85                      \ [0x0a] IV85
    $0b constant CRYP_IV84                      \ [0x0b] IV84
    $0c constant CRYP_IV83                      \ [0x0c] IV83
    $0d constant CRYP_IV82                      \ [0x0d] IV82
    $0e constant CRYP_IV81                      \ [0x0e] IV81
    $0f constant CRYP_IV80                      \ [0x0f] IV80
    $10 constant CRYP_IV79                      \ [0x10] IV79
    $11 constant CRYP_IV78                      \ [0x11] IV78
    $12 constant CRYP_IV77                      \ [0x12] IV77
    $13 constant CRYP_IV76                      \ [0x13] IV76
    $14 constant CRYP_IV75                      \ [0x14] IV75
    $15 constant CRYP_IV74                      \ [0x15] IV74
    $16 constant CRYP_IV73                      \ [0x16] IV73
    $17 constant CRYP_IV72                      \ [0x17] IV72
    $18 constant CRYP_IV71                      \ [0x18] IV71
    $19 constant CRYP_IV70                      \ [0x19] IV70
    $1a constant CRYP_IV69                      \ [0x1a] IV69
    $1b constant CRYP_IV68                      \ [0x1b] IV68
    $1c constant CRYP_IV67                      \ [0x1c] IV67
    $1d constant CRYP_IV66                      \ [0x1d] IV66
    $1e constant CRYP_IV65                      \ [0x1e] IV65
    $1f constant CRYP_IV64                      \ [0x1f] IV64
  [then]


  [ifdef] CRYP_IV1RR_DEF
    \
    \ @brief initialization vector registers
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IV127                     \ [0x00] IV127
    $01 constant CRYP_IV126                     \ [0x01] IV126
    $02 constant CRYP_IV125                     \ [0x02] IV125
    $03 constant CRYP_IV124                     \ [0x03] IV124
    $04 constant CRYP_IV123                     \ [0x04] IV123
    $05 constant CRYP_IV122                     \ [0x05] IV122
    $06 constant CRYP_IV121                     \ [0x06] IV121
    $07 constant CRYP_IV120                     \ [0x07] IV120
    $08 constant CRYP_IV119                     \ [0x08] IV119
    $09 constant CRYP_IV118                     \ [0x09] IV118
    $0a constant CRYP_IV117                     \ [0x0a] IV117
    $0b constant CRYP_IV116                     \ [0x0b] IV116
    $0c constant CRYP_IV115                     \ [0x0c] IV115
    $0d constant CRYP_IV114                     \ [0x0d] IV114
    $0e constant CRYP_IV113                     \ [0x0e] IV113
    $0f constant CRYP_IV112                     \ [0x0f] IV112
    $10 constant CRYP_IV111                     \ [0x10] IV111
    $11 constant CRYP_IV110                     \ [0x11] IV110
    $12 constant CRYP_IV109                     \ [0x12] IV109
    $13 constant CRYP_IV108                     \ [0x13] IV108
    $14 constant CRYP_IV107                     \ [0x14] IV107
    $15 constant CRYP_IV106                     \ [0x15] IV106
    $16 constant CRYP_IV105                     \ [0x16] IV105
    $17 constant CRYP_IV104                     \ [0x17] IV104
    $18 constant CRYP_IV103                     \ [0x18] IV103
    $19 constant CRYP_IV102                     \ [0x19] IV102
    $1a constant CRYP_IV101                     \ [0x1a] IV101
    $1b constant CRYP_IV100                     \ [0x1b] IV100
    $1c constant CRYP_IV99                      \ [0x1c] IV99
    $1d constant CRYP_IV98                      \ [0x1d] IV98
    $1e constant CRYP_IV97                      \ [0x1e] IV97
    $1f constant CRYP_IV96                      \ [0x1f] IV96
  [then]


  [ifdef] CRYP_CSGCMCCM0R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM0                 \ [0x00 : 32] CSGCMCCM0
  [then]


  [ifdef] CRYP_CSGCMCCM1R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM1                 \ [0x00 : 32] CSGCMCCM1
  [then]


  [ifdef] CRYP_CSGCMCCM2R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM2                 \ [0x00 : 32] CSGCMCCM2
  [then]


  [ifdef] CRYP_CSGCMCCM3R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM3                 \ [0x00 : 32] CSGCMCCM3
  [then]


  [ifdef] CRYP_CSGCMCCM4R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM4                 \ [0x00 : 32] CSGCMCCM4
  [then]


  [ifdef] CRYP_CSGCMCCM5R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM5                 \ [0x00 : 32] CSGCMCCM5
  [then]


  [ifdef] CRYP_CSGCMCCM6R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM6                 \ [0x00 : 32] CSGCMCCM6
  [then]


  [ifdef] CRYP_CSGCMCCM7R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM7                 \ [0x00 : 32] CSGCMCCM7
  [then]


  [ifdef] CRYP_CSGCM0R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM0                    \ [0x00 : 32] CSGCM0
  [then]


  [ifdef] CRYP_CSGCM1R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM1                    \ [0x00 : 32] CSGCM1
  [then]


  [ifdef] CRYP_CSGCM2R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM2                    \ [0x00 : 32] CSGCM2
  [then]


  [ifdef] CRYP_CSGCM3R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM3                    \ [0x00 : 32] CSGCM3
  [then]


  [ifdef] CRYP_CSGCM4R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM4                    \ [0x00 : 32] CSGCM4
  [then]


  [ifdef] CRYP_CSGCM5R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM5                    \ [0x00 : 32] CSGCM5
  [then]


  [ifdef] CRYP_CSGCM6R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM6                    \ [0x00 : 32] CSGCM6
  [then]


  [ifdef] CRYP_CSGCM7R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM7                    \ [0x00 : 32] CSGCM7
  [then]

  \
  \ @brief Cryptographic processor
  \
  $00 constant CRYP_CR                  \ control register
  $04 constant CRYP_SR                  \ status register
  $08 constant CRYP_DIN                 \ data input register
  $0C constant CRYP_DOUT                \ data output register
  $10 constant CRYP_DMACR               \ DMA control register
  $14 constant CRYP_IMSCR               \ interrupt mask set/clear register
  $18 constant CRYP_RISR                \ raw interrupt status register
  $1C constant CRYP_MISR                \ masked interrupt status register
  $20 constant CRYP_K0LR                \ key registers
  $24 constant CRYP_K0RR                \ key registers
  $28 constant CRYP_K1LR                \ key registers
  $2C constant CRYP_K1RR                \ key registers
  $30 constant CRYP_K2LR                \ key registers
  $34 constant CRYP_K2RR                \ key registers
  $38 constant CRYP_K3LR                \ key registers
  $3C constant CRYP_K3RR                \ key registers
  $40 constant CRYP_IV0LR               \ initialization vector registers
  $44 constant CRYP_IV0RR               \ initialization vector registers
  $48 constant CRYP_IV1LR               \ initialization vector registers
  $4C constant CRYP_IV1RR               \ initialization vector registers
  $50 constant CRYP_CSGCMCCM0R          \ context swap register
  $54 constant CRYP_CSGCMCCM1R          \ context swap register
  $58 constant CRYP_CSGCMCCM2R          \ context swap register
  $5C constant CRYP_CSGCMCCM3R          \ context swap register
  $60 constant CRYP_CSGCMCCM4R          \ context swap register
  $64 constant CRYP_CSGCMCCM5R          \ context swap register
  $68 constant CRYP_CSGCMCCM6R          \ context swap register
  $6C constant CRYP_CSGCMCCM7R          \ context swap register
  $70 constant CRYP_CSGCM0R             \ context swap register
  $74 constant CRYP_CSGCM1R             \ context swap register
  $78 constant CRYP_CSGCM2R             \ context swap register
  $7C constant CRYP_CSGCM3R             \ context swap register
  $80 constant CRYP_CSGCM4R             \ context swap register
  $84 constant CRYP_CSGCM5R             \ context swap register
  $88 constant CRYP_CSGCM6R             \ context swap register
  $8C constant CRYP_CSGCM7R             \ context swap register

: CRYP_DEF ; [then]
