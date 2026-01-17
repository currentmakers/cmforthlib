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
    $00 constant CRYP_k224                      \ [0x00] k224
    $01 constant CRYP_k225                      \ [0x01] k225
    $02 constant CRYP_k226                      \ [0x02] k226
    $03 constant CRYP_k227                      \ [0x03] k227
    $04 constant CRYP_k228                      \ [0x04] k228
    $05 constant CRYP_k229                      \ [0x05] k229
    $06 constant CRYP_k230                      \ [0x06] k230
    $07 constant CRYP_k231                      \ [0x07] k231
    $08 constant CRYP_k232                      \ [0x08] k232
    $09 constant CRYP_k233                      \ [0x09] k233
    $0a constant CRYP_k234                      \ [0x0a] k234
    $0b constant CRYP_k235                      \ [0x0b] k235
    $0c constant CRYP_k236                      \ [0x0c] k236
    $0d constant CRYP_k237                      \ [0x0d] k237
    $0e constant CRYP_k238                      \ [0x0e] k238
    $0f constant CRYP_k239                      \ [0x0f] k239
    $10 constant CRYP_k240                      \ [0x10] k240
    $11 constant CRYP_k241                      \ [0x11] k241
    $12 constant CRYP_k242                      \ [0x12] k242
    $13 constant CRYP_k243                      \ [0x13] k243
    $14 constant CRYP_k244                      \ [0x14] k244
    $15 constant CRYP_k245                      \ [0x15] k245
    $16 constant CRYP_k246                      \ [0x16] k246
    $17 constant CRYP_k247                      \ [0x17] k247
    $18 constant CRYP_k248                      \ [0x18] k248
    $19 constant CRYP_k249                      \ [0x19] k249
    $1a constant CRYP_k250                      \ [0x1a] k250
    $1b constant CRYP_k251                      \ [0x1b] k251
    $1c constant CRYP_k252                      \ [0x1c] k252
    $1d constant CRYP_k253                      \ [0x1d] k253
    $1e constant CRYP_k254                      \ [0x1e] k254
    $1f constant CRYP_k255                      \ [0x1f] k255
  [then]


  [ifdef] CRYP_K0RR_DEF
    \
    \ @brief key registers
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_k192                      \ [0x00] k192
    $01 constant CRYP_k193                      \ [0x01] k193
    $02 constant CRYP_k194                      \ [0x02] k194
    $03 constant CRYP_k195                      \ [0x03] k195
    $04 constant CRYP_k196                      \ [0x04] k196
    $05 constant CRYP_k197                      \ [0x05] k197
    $06 constant CRYP_k198                      \ [0x06] k198
    $07 constant CRYP_k199                      \ [0x07] k199
    $08 constant CRYP_k200                      \ [0x08] k200
    $09 constant CRYP_k201                      \ [0x09] k201
    $0a constant CRYP_k202                      \ [0x0a] k202
    $0b constant CRYP_k203                      \ [0x0b] k203
    $0c constant CRYP_k204                      \ [0x0c] k204
    $0d constant CRYP_k205                      \ [0x0d] k205
    $0e constant CRYP_k206                      \ [0x0e] k206
    $0f constant CRYP_k207                      \ [0x0f] k207
    $10 constant CRYP_k208                      \ [0x10] k208
    $11 constant CRYP_k209                      \ [0x11] k209
    $12 constant CRYP_k210                      \ [0x12] k210
    $13 constant CRYP_k211                      \ [0x13] k211
    $14 constant CRYP_k212                      \ [0x14] k212
    $15 constant CRYP_k213                      \ [0x15] k213
    $16 constant CRYP_k214                      \ [0x16] k214
    $17 constant CRYP_k215                      \ [0x17] k215
    $18 constant CRYP_k216                      \ [0x18] k216
    $19 constant CRYP_k217                      \ [0x19] k217
    $1a constant CRYP_k218                      \ [0x1a] k218
    $1b constant CRYP_k219                      \ [0x1b] k219
    $1c constant CRYP_k220                      \ [0x1c] k220
    $1d constant CRYP_k221                      \ [0x1d] k221
    $1e constant CRYP_k222                      \ [0x1e] k222
    $1f constant CRYP_k223                      \ [0x1f] k223
  [then]


  [ifdef] CRYP_K1LR_DEF
    \
    \ @brief key registers
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_k160                      \ [0x00] k160
    $01 constant CRYP_k161                      \ [0x01] k161
    $02 constant CRYP_k162                      \ [0x02] k162
    $03 constant CRYP_k163                      \ [0x03] k163
    $04 constant CRYP_k164                      \ [0x04] k164
    $05 constant CRYP_k165                      \ [0x05] k165
    $06 constant CRYP_k166                      \ [0x06] k166
    $07 constant CRYP_k167                      \ [0x07] k167
    $08 constant CRYP_k168                      \ [0x08] k168
    $09 constant CRYP_k169                      \ [0x09] k169
    $0a constant CRYP_k170                      \ [0x0a] k170
    $0b constant CRYP_k171                      \ [0x0b] k171
    $0c constant CRYP_k172                      \ [0x0c] k172
    $0d constant CRYP_k173                      \ [0x0d] k173
    $0e constant CRYP_k174                      \ [0x0e] k174
    $0f constant CRYP_k175                      \ [0x0f] k175
    $10 constant CRYP_k176                      \ [0x10] k176
    $11 constant CRYP_k177                      \ [0x11] k177
    $12 constant CRYP_k178                      \ [0x12] k178
    $13 constant CRYP_k179                      \ [0x13] k179
    $14 constant CRYP_k180                      \ [0x14] k180
    $15 constant CRYP_k181                      \ [0x15] k181
    $16 constant CRYP_k182                      \ [0x16] k182
    $17 constant CRYP_k183                      \ [0x17] k183
    $18 constant CRYP_k184                      \ [0x18] k184
    $19 constant CRYP_k185                      \ [0x19] k185
    $1a constant CRYP_k186                      \ [0x1a] k186
    $1b constant CRYP_k187                      \ [0x1b] k187
    $1c constant CRYP_k188                      \ [0x1c] k188
    $1d constant CRYP_k189                      \ [0x1d] k189
    $1e constant CRYP_k190                      \ [0x1e] k190
    $1f constant CRYP_k191                      \ [0x1f] k191
  [then]


  [ifdef] CRYP_K1RR_DEF
    \
    \ @brief key registers
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_k128                      \ [0x00] k128
    $01 constant CRYP_k129                      \ [0x01] k129
    $02 constant CRYP_k130                      \ [0x02] k130
    $03 constant CRYP_k131                      \ [0x03] k131
    $04 constant CRYP_k132                      \ [0x04] k132
    $05 constant CRYP_k133                      \ [0x05] k133
    $06 constant CRYP_k134                      \ [0x06] k134
    $07 constant CRYP_k135                      \ [0x07] k135
    $08 constant CRYP_k136                      \ [0x08] k136
    $09 constant CRYP_k137                      \ [0x09] k137
    $0a constant CRYP_k138                      \ [0x0a] k138
    $0b constant CRYP_k139                      \ [0x0b] k139
    $0c constant CRYP_k140                      \ [0x0c] k140
    $0d constant CRYP_k141                      \ [0x0d] k141
    $0e constant CRYP_k142                      \ [0x0e] k142
    $0f constant CRYP_k143                      \ [0x0f] k143
    $10 constant CRYP_k144                      \ [0x10] k144
    $11 constant CRYP_k145                      \ [0x11] k145
    $12 constant CRYP_k146                      \ [0x12] k146
    $13 constant CRYP_k147                      \ [0x13] k147
    $14 constant CRYP_k148                      \ [0x14] k148
    $15 constant CRYP_k149                      \ [0x15] k149
    $16 constant CRYP_k150                      \ [0x16] k150
    $17 constant CRYP_k151                      \ [0x17] k151
    $18 constant CRYP_k152                      \ [0x18] k152
    $19 constant CRYP_k153                      \ [0x19] k153
    $1a constant CRYP_k154                      \ [0x1a] k154
    $1b constant CRYP_k155                      \ [0x1b] k155
    $1c constant CRYP_k156                      \ [0x1c] k156
    $1d constant CRYP_k157                      \ [0x1d] k157
    $1e constant CRYP_k158                      \ [0x1e] k158
    $1f constant CRYP_k159                      \ [0x1f] k159
  [then]


  [ifdef] CRYP_K2LR_DEF
    \
    \ @brief key registers
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_k96                       \ [0x00] k96
    $01 constant CRYP_k97                       \ [0x01] k97
    $02 constant CRYP_k98                       \ [0x02] k98
    $03 constant CRYP_k99                       \ [0x03] k99
    $04 constant CRYP_k100                      \ [0x04] k100
    $05 constant CRYP_k101                      \ [0x05] k101
    $06 constant CRYP_k102                      \ [0x06] k102
    $07 constant CRYP_k103                      \ [0x07] k103
    $08 constant CRYP_k104                      \ [0x08] k104
    $09 constant CRYP_k105                      \ [0x09] k105
    $0a constant CRYP_k106                      \ [0x0a] k106
    $0b constant CRYP_k107                      \ [0x0b] k107
    $0c constant CRYP_k108                      \ [0x0c] k108
    $0d constant CRYP_k109                      \ [0x0d] k109
    $0e constant CRYP_k110                      \ [0x0e] k110
    $0f constant CRYP_k111                      \ [0x0f] k111
    $10 constant CRYP_k112                      \ [0x10] k112
    $11 constant CRYP_k113                      \ [0x11] k113
    $12 constant CRYP_k114                      \ [0x12] k114
    $13 constant CRYP_k115                      \ [0x13] k115
    $14 constant CRYP_k116                      \ [0x14] k116
    $15 constant CRYP_k117                      \ [0x15] k117
    $16 constant CRYP_k118                      \ [0x16] k118
    $17 constant CRYP_k119                      \ [0x17] k119
    $18 constant CRYP_k120                      \ [0x18] k120
    $19 constant CRYP_b121                      \ [0x19] b121
    $1a constant CRYP_k122                      \ [0x1a] k122
    $1b constant CRYP_k123                      \ [0x1b] k123
    $1c constant CRYP_k124                      \ [0x1c] k124
    $1d constant CRYP_k125                      \ [0x1d] k125
    $1e constant CRYP_k126                      \ [0x1e] k126
    $1f constant CRYP_k127                      \ [0x1f] k127
  [then]


  [ifdef] CRYP_K2RR_DEF
    \
    \ @brief key registers
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_k64                       \ [0x00] k64
    $01 constant CRYP_k65                       \ [0x01] k65
    $02 constant CRYP_k66                       \ [0x02] k66
    $03 constant CRYP_k67                       \ [0x03] k67
    $04 constant CRYP_k68                       \ [0x04] k68
    $05 constant CRYP_k69                       \ [0x05] k69
    $06 constant CRYP_k70                       \ [0x06] k70
    $07 constant CRYP_k71                       \ [0x07] k71
    $08 constant CRYP_k72                       \ [0x08] k72
    $09 constant CRYP_k73                       \ [0x09] k73
    $0a constant CRYP_k74                       \ [0x0a] k74
    $0b constant CRYP_k75                       \ [0x0b] k75
    $0c constant CRYP_k76                       \ [0x0c] k76
    $0d constant CRYP_k77                       \ [0x0d] k77
    $0e constant CRYP_k78                       \ [0x0e] k78
    $0f constant CRYP_k79                       \ [0x0f] k79
    $10 constant CRYP_k80                       \ [0x10] k80
    $11 constant CRYP_k81                       \ [0x11] k81
    $12 constant CRYP_k82                       \ [0x12] k82
    $13 constant CRYP_k83                       \ [0x13] k83
    $14 constant CRYP_k84                       \ [0x14] k84
    $15 constant CRYP_k85                       \ [0x15] k85
    $16 constant CRYP_k86                       \ [0x16] k86
    $17 constant CRYP_k87                       \ [0x17] k87
    $18 constant CRYP_k88                       \ [0x18] k88
    $19 constant CRYP_k89                       \ [0x19] k89
    $1a constant CRYP_k90                       \ [0x1a] k90
    $1b constant CRYP_k91                       \ [0x1b] k91
    $1c constant CRYP_k92                       \ [0x1c] k92
    $1d constant CRYP_k93                       \ [0x1d] k93
    $1e constant CRYP_k94                       \ [0x1e] k94
    $1f constant CRYP_k95                       \ [0x1f] k95
  [then]


  [ifdef] CRYP_K3LR_DEF
    \
    \ @brief key registers
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_k32                       \ [0x00] k32
    $01 constant CRYP_k33                       \ [0x01] k33
    $02 constant CRYP_k34                       \ [0x02] k34
    $03 constant CRYP_k35                       \ [0x03] k35
    $04 constant CRYP_k36                       \ [0x04] k36
    $05 constant CRYP_k37                       \ [0x05] k37
    $06 constant CRYP_k38                       \ [0x06] k38
    $07 constant CRYP_k39                       \ [0x07] k39
    $08 constant CRYP_k40                       \ [0x08] k40
    $09 constant CRYP_k41                       \ [0x09] k41
    $0a constant CRYP_k42                       \ [0x0a] k42
    $0b constant CRYP_k43                       \ [0x0b] k43
    $0c constant CRYP_k44                       \ [0x0c] k44
    $0d constant CRYP_k45                       \ [0x0d] k45
    $0e constant CRYP_k46                       \ [0x0e] k46
    $0f constant CRYP_k47                       \ [0x0f] k47
    $10 constant CRYP_k48                       \ [0x10] k48
    $11 constant CRYP_k49                       \ [0x11] k49
    $12 constant CRYP_k50                       \ [0x12] k50
    $13 constant CRYP_k51                       \ [0x13] k51
    $14 constant CRYP_k52                       \ [0x14] k52
    $15 constant CRYP_k53                       \ [0x15] k53
    $16 constant CRYP_k54                       \ [0x16] k54
    $17 constant CRYP_k55                       \ [0x17] k55
    $18 constant CRYP_k56                       \ [0x18] k56
    $19 constant CRYP_k57                       \ [0x19] k57
    $1a constant CRYP_k58                       \ [0x1a] k58
    $1b constant CRYP_k59                       \ [0x1b] k59
    $1c constant CRYP_k60                       \ [0x1c] k60
    $1d constant CRYP_k61                       \ [0x1d] k61
    $1e constant CRYP_k62                       \ [0x1e] k62
    $1f constant CRYP_k63                       \ [0x1f] k63
  [then]


  [ifdef] CRYP_K3RR_DEF
    \
    \ @brief key registers
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_k0                        \ [0x00] k0
    $01 constant CRYP_k1                        \ [0x01] k1
    $02 constant CRYP_k2                        \ [0x02] k2
    $03 constant CRYP_k3                        \ [0x03] k3
    $04 constant CRYP_k4                        \ [0x04] k4
    $05 constant CRYP_k5                        \ [0x05] k5
    $06 constant CRYP_k6                        \ [0x06] k6
    $07 constant CRYP_k7                        \ [0x07] k7
    $08 constant CRYP_k8                        \ [0x08] k8
    $09 constant CRYP_k9                        \ [0x09] k9
    $0a constant CRYP_k10                       \ [0x0a] k10
    $0b constant CRYP_k11                       \ [0x0b] k11
    $0c constant CRYP_k12                       \ [0x0c] k12
    $0d constant CRYP_k13                       \ [0x0d] k13
    $0e constant CRYP_k14                       \ [0x0e] k14
    $0f constant CRYP_k15                       \ [0x0f] k15
    $10 constant CRYP_k16                       \ [0x10] k16
    $11 constant CRYP_k17                       \ [0x11] k17
    $12 constant CRYP_k18                       \ [0x12] k18
    $13 constant CRYP_k19                       \ [0x13] k19
    $14 constant CRYP_k20                       \ [0x14] k20
    $15 constant CRYP_k21                       \ [0x15] k21
    $16 constant CRYP_k22                       \ [0x16] k22
    $17 constant CRYP_k23                       \ [0x17] k23
    $18 constant CRYP_k24                       \ [0x18] k24
    $19 constant CRYP_k25                       \ [0x19] k25
    $1a constant CRYP_k26                       \ [0x1a] k26
    $1b constant CRYP_k27                       \ [0x1b] k27
    $1c constant CRYP_k28                       \ [0x1c] k28
    $1d constant CRYP_k29                       \ [0x1d] k29
    $1e constant CRYP_k30                       \ [0x1e] k30
    $1f constant CRYP_k31                       \ [0x1f] k31
  [then]


  [ifdef] CRYP_IV0LR_DEF
    \
    \ @brief Initialization vector register 0L
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
    \ @brief initialization vector register 0R
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
    \ @brief Initialization vector register 1L
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
    \ @brief Initialization vector register 1R
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
    $00 constant CRYP_CSGCMCCM0R                \ [0x00 : 32] CSGCMCCM0R
  [then]


  [ifdef] CRYP_CSGCMCCM1R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM1R                \ [0x00 : 32] CSGCMCCM1R
  [then]


  [ifdef] CRYP_CSGCMCCM2R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM2R                \ [0x00 : 32] CSGCMCCM2R
  [then]


  [ifdef] CRYP_CSGCMCCM3R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM3R                \ [0x00 : 32] CSGCMCCM3R
  [then]


  [ifdef] CRYP_CSGCMCCM4R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM4R                \ [0x00 : 32] CSGCMCCM4R
  [then]


  [ifdef] CRYP_CSGCMCCM5R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM5R                \ [0x00 : 32] CSGCMCCM5R
  [then]


  [ifdef] CRYP_CSGCMCCM6R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM6R                \ [0x00 : 32] CSGCMCCM6R
  [then]


  [ifdef] CRYP_CSGCMCCM7R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM7R                \ [0x00 : 32] CSGCMCCM7R
  [then]


  [ifdef] CRYP_CSGCM0R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM0R                   \ [0x00 : 32] CSGCM0R
  [then]


  [ifdef] CRYP_CSGCM1R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM1R                   \ [0x00 : 32] CSGCM1R
  [then]


  [ifdef] CRYP_CSGCM2R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM2R                   \ [0x00 : 32] CSGCM2R
  [then]


  [ifdef] CRYP_CSGCM3R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM3R                   \ [0x00 : 32] CSGCM3R
  [then]


  [ifdef] CRYP_CSGCM4R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM4R                   \ [0x00 : 32] CSGCM4R
  [then]


  [ifdef] CRYP_CSGCM5R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM5R                   \ [0x00 : 32] CSGCM5R
  [then]


  [ifdef] CRYP_CSGCM6R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM6R                   \ [0x00 : 32] CSGCM6R
  [then]


  [ifdef] CRYP_CSGCM7R_DEF
    \
    \ @brief context swap register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM7R                   \ [0x00 : 32] CSGCM7R
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
  $40 constant CRYP_IV0LR               \ Initialization vector register 0L
  $44 constant CRYP_IV0RR               \ initialization vector register 0R
  $48 constant CRYP_IV1LR               \ Initialization vector register 1L
  $4C constant CRYP_IV1RR               \ Initialization vector register 1R
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
