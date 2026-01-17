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
    $00 constant CRYP_b224                      \ [0x00] b224
    $01 constant CRYP_b225                      \ [0x01] b225
    $02 constant CRYP_b226                      \ [0x02] b226
    $03 constant CRYP_b227                      \ [0x03] b227
    $04 constant CRYP_b228                      \ [0x04] b228
    $05 constant CRYP_b229                      \ [0x05] b229
    $06 constant CRYP_b230                      \ [0x06] b230
    $07 constant CRYP_b231                      \ [0x07] b231
    $08 constant CRYP_b232                      \ [0x08] b232
    $09 constant CRYP_b233                      \ [0x09] b233
    $0a constant CRYP_b234                      \ [0x0a] b234
    $0b constant CRYP_b235                      \ [0x0b] b235
    $0c constant CRYP_b236                      \ [0x0c] b236
    $0d constant CRYP_b237                      \ [0x0d] b237
    $0e constant CRYP_b238                      \ [0x0e] b238
    $0f constant CRYP_b239                      \ [0x0f] b239
    $10 constant CRYP_b240                      \ [0x10] b240
    $11 constant CRYP_b241                      \ [0x11] b241
    $12 constant CRYP_b242                      \ [0x12] b242
    $13 constant CRYP_b243                      \ [0x13] b243
    $14 constant CRYP_b244                      \ [0x14] b244
    $15 constant CRYP_b245                      \ [0x15] b245
    $16 constant CRYP_b246                      \ [0x16] b246
    $17 constant CRYP_b247                      \ [0x17] b247
    $18 constant CRYP_b248                      \ [0x18] b248
    $19 constant CRYP_b249                      \ [0x19] b249
    $1a constant CRYP_b250                      \ [0x1a] b250
    $1b constant CRYP_b251                      \ [0x1b] b251
    $1c constant CRYP_b252                      \ [0x1c] b252
    $1d constant CRYP_b253                      \ [0x1d] b253
    $1e constant CRYP_b254                      \ [0x1e] b254
    $1f constant CRYP_b255                      \ [0x1f] b255
  [then]


  [ifdef] CRYP_K0RR_DEF
    \
    \ @brief key registers
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_b192                      \ [0x00] b192
    $01 constant CRYP_b193                      \ [0x01] b193
    $02 constant CRYP_b194                      \ [0x02] b194
    $03 constant CRYP_b195                      \ [0x03] b195
    $04 constant CRYP_b196                      \ [0x04] b196
    $05 constant CRYP_b197                      \ [0x05] b197
    $06 constant CRYP_b198                      \ [0x06] b198
    $07 constant CRYP_b199                      \ [0x07] b199
    $08 constant CRYP_b200                      \ [0x08] b200
    $09 constant CRYP_b201                      \ [0x09] b201
    $0a constant CRYP_b202                      \ [0x0a] b202
    $0b constant CRYP_b203                      \ [0x0b] b203
    $0c constant CRYP_b204                      \ [0x0c] b204
    $0d constant CRYP_b205                      \ [0x0d] b205
    $0e constant CRYP_b206                      \ [0x0e] b206
    $0f constant CRYP_b207                      \ [0x0f] b207
    $10 constant CRYP_b208                      \ [0x10] b208
    $11 constant CRYP_b209                      \ [0x11] b209
    $12 constant CRYP_b210                      \ [0x12] b210
    $13 constant CRYP_b211                      \ [0x13] b211
    $14 constant CRYP_b212                      \ [0x14] b212
    $15 constant CRYP_b213                      \ [0x15] b213
    $16 constant CRYP_b214                      \ [0x16] b214
    $17 constant CRYP_b215                      \ [0x17] b215
    $18 constant CRYP_b216                      \ [0x18] b216
    $19 constant CRYP_b217                      \ [0x19] b217
    $1a constant CRYP_b218                      \ [0x1a] b218
    $1b constant CRYP_b219                      \ [0x1b] b219
    $1c constant CRYP_b220                      \ [0x1c] b220
    $1d constant CRYP_b221                      \ [0x1d] b221
    $1e constant CRYP_b222                      \ [0x1e] b222
    $1f constant CRYP_b223                      \ [0x1f] b223
  [then]


  [ifdef] CRYP_K1LR_DEF
    \
    \ @brief key registers
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_b160                      \ [0x00] b160
    $01 constant CRYP_b161                      \ [0x01] b161
    $02 constant CRYP_b162                      \ [0x02] b162
    $03 constant CRYP_b163                      \ [0x03] b163
    $04 constant CRYP_b164                      \ [0x04] b164
    $05 constant CRYP_b165                      \ [0x05] b165
    $06 constant CRYP_b166                      \ [0x06] b166
    $07 constant CRYP_b167                      \ [0x07] b167
    $08 constant CRYP_b168                      \ [0x08] b168
    $09 constant CRYP_b169                      \ [0x09] b169
    $0a constant CRYP_b170                      \ [0x0a] b170
    $0b constant CRYP_b171                      \ [0x0b] b171
    $0c constant CRYP_b172                      \ [0x0c] b172
    $0d constant CRYP_b173                      \ [0x0d] b173
    $0e constant CRYP_b174                      \ [0x0e] b174
    $0f constant CRYP_b175                      \ [0x0f] b175
    $10 constant CRYP_b176                      \ [0x10] b176
    $11 constant CRYP_b177                      \ [0x11] b177
    $12 constant CRYP_b178                      \ [0x12] b178
    $13 constant CRYP_b179                      \ [0x13] b179
    $14 constant CRYP_b180                      \ [0x14] b180
    $15 constant CRYP_b181                      \ [0x15] b181
    $16 constant CRYP_b182                      \ [0x16] b182
    $17 constant CRYP_b183                      \ [0x17] b183
    $18 constant CRYP_b184                      \ [0x18] b184
    $19 constant CRYP_b185                      \ [0x19] b185
    $1a constant CRYP_b186                      \ [0x1a] b186
    $1b constant CRYP_b187                      \ [0x1b] b187
    $1c constant CRYP_b188                      \ [0x1c] b188
    $1d constant CRYP_b189                      \ [0x1d] b189
    $1e constant CRYP_b190                      \ [0x1e] b190
    $1f constant CRYP_b191                      \ [0x1f] b191
  [then]


  [ifdef] CRYP_K1RR_DEF
    \
    \ @brief key registers
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_b128                      \ [0x00] b128
    $01 constant CRYP_b129                      \ [0x01] b129
    $02 constant CRYP_b130                      \ [0x02] b130
    $03 constant CRYP_b131                      \ [0x03] b131
    $04 constant CRYP_b132                      \ [0x04] b132
    $05 constant CRYP_b133                      \ [0x05] b133
    $06 constant CRYP_b134                      \ [0x06] b134
    $07 constant CRYP_b135                      \ [0x07] b135
    $08 constant CRYP_b136                      \ [0x08] b136
    $09 constant CRYP_b137                      \ [0x09] b137
    $0a constant CRYP_b138                      \ [0x0a] b138
    $0b constant CRYP_b139                      \ [0x0b] b139
    $0c constant CRYP_b140                      \ [0x0c] b140
    $0d constant CRYP_b141                      \ [0x0d] b141
    $0e constant CRYP_b142                      \ [0x0e] b142
    $0f constant CRYP_b143                      \ [0x0f] b143
    $10 constant CRYP_b144                      \ [0x10] b144
    $11 constant CRYP_b145                      \ [0x11] b145
    $12 constant CRYP_b146                      \ [0x12] b146
    $13 constant CRYP_b147                      \ [0x13] b147
    $14 constant CRYP_b148                      \ [0x14] b148
    $15 constant CRYP_b149                      \ [0x15] b149
    $16 constant CRYP_b150                      \ [0x16] b150
    $17 constant CRYP_b151                      \ [0x17] b151
    $18 constant CRYP_b152                      \ [0x18] b152
    $19 constant CRYP_b153                      \ [0x19] b153
    $1a constant CRYP_b154                      \ [0x1a] b154
    $1b constant CRYP_b155                      \ [0x1b] b155
    $1c constant CRYP_b156                      \ [0x1c] b156
    $1d constant CRYP_b157                      \ [0x1d] b157
    $1e constant CRYP_b158                      \ [0x1e] b158
    $1f constant CRYP_b159                      \ [0x1f] b159
  [then]


  [ifdef] CRYP_K2LR_DEF
    \
    \ @brief key registers
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_b96                       \ [0x00] b96
    $01 constant CRYP_b97                       \ [0x01] b97
    $02 constant CRYP_b98                       \ [0x02] b98
    $03 constant CRYP_b99                       \ [0x03] b99
    $04 constant CRYP_b100                      \ [0x04] b100
    $05 constant CRYP_b101                      \ [0x05] b101
    $06 constant CRYP_b102                      \ [0x06] b102
    $07 constant CRYP_b103                      \ [0x07] b103
    $08 constant CRYP_b104                      \ [0x08] b104
    $09 constant CRYP_b105                      \ [0x09] b105
    $0a constant CRYP_b106                      \ [0x0a] b106
    $0b constant CRYP_b107                      \ [0x0b] b107
    $0c constant CRYP_b108                      \ [0x0c] b108
    $0d constant CRYP_b109                      \ [0x0d] b109
    $0e constant CRYP_b110                      \ [0x0e] b110
    $0f constant CRYP_b111                      \ [0x0f] b111
    $10 constant CRYP_b112                      \ [0x10] b112
    $11 constant CRYP_b113                      \ [0x11] b113
    $12 constant CRYP_b114                      \ [0x12] b114
    $13 constant CRYP_b115                      \ [0x13] b115
    $14 constant CRYP_b116                      \ [0x14] b116
    $15 constant CRYP_b117                      \ [0x15] b117
    $16 constant CRYP_b118                      \ [0x16] b118
    $17 constant CRYP_b119                      \ [0x17] b119
    $18 constant CRYP_b120                      \ [0x18] b120
    $19 constant CRYP_b121                      \ [0x19] b121
    $1a constant CRYP_b122                      \ [0x1a] b122
    $1b constant CRYP_b123                      \ [0x1b] b123
    $1c constant CRYP_b124                      \ [0x1c] b124
    $1d constant CRYP_b125                      \ [0x1d] b125
    $1e constant CRYP_b126                      \ [0x1e] b126
    $1f constant CRYP_b127                      \ [0x1f] b127
  [then]


  [ifdef] CRYP_K2RR_DEF
    \
    \ @brief key registers
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_b64                       \ [0x00] b64
    $01 constant CRYP_b65                       \ [0x01] b65
    $02 constant CRYP_b66                       \ [0x02] b66
    $03 constant CRYP_b67                       \ [0x03] b67
    $04 constant CRYP_b68                       \ [0x04] b68
    $05 constant CRYP_b69                       \ [0x05] b69
    $06 constant CRYP_b70                       \ [0x06] b70
    $07 constant CRYP_b71                       \ [0x07] b71
    $08 constant CRYP_b72                       \ [0x08] b72
    $09 constant CRYP_b73                       \ [0x09] b73
    $0a constant CRYP_b74                       \ [0x0a] b74
    $0b constant CRYP_b75                       \ [0x0b] b75
    $0c constant CRYP_b76                       \ [0x0c] b76
    $0d constant CRYP_b77                       \ [0x0d] b77
    $0e constant CRYP_b78                       \ [0x0e] b78
    $0f constant CRYP_b79                       \ [0x0f] b79
    $10 constant CRYP_b80                       \ [0x10] b80
    $11 constant CRYP_b81                       \ [0x11] b81
    $12 constant CRYP_b82                       \ [0x12] b82
    $13 constant CRYP_b83                       \ [0x13] b83
    $14 constant CRYP_b84                       \ [0x14] b84
    $15 constant CRYP_b85                       \ [0x15] b85
    $16 constant CRYP_b86                       \ [0x16] b86
    $17 constant CRYP_b87                       \ [0x17] b87
    $18 constant CRYP_b88                       \ [0x18] b88
    $19 constant CRYP_b89                       \ [0x19] b89
    $1a constant CRYP_b90                       \ [0x1a] b90
    $1b constant CRYP_b91                       \ [0x1b] b91
    $1c constant CRYP_b92                       \ [0x1c] b92
    $1d constant CRYP_b93                       \ [0x1d] b93
    $1e constant CRYP_b94                       \ [0x1e] b94
    $1f constant CRYP_b95                       \ [0x1f] b95
  [then]


  [ifdef] CRYP_K3LR_DEF
    \
    \ @brief key registers
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_b32                       \ [0x00] b32
    $01 constant CRYP_b33                       \ [0x01] b33
    $02 constant CRYP_b34                       \ [0x02] b34
    $03 constant CRYP_b35                       \ [0x03] b35
    $04 constant CRYP_b36                       \ [0x04] b36
    $05 constant CRYP_b37                       \ [0x05] b37
    $06 constant CRYP_b38                       \ [0x06] b38
    $07 constant CRYP_b39                       \ [0x07] b39
    $08 constant CRYP_b40                       \ [0x08] b40
    $09 constant CRYP_b41                       \ [0x09] b41
    $0a constant CRYP_b42                       \ [0x0a] b42
    $0b constant CRYP_b43                       \ [0x0b] b43
    $0c constant CRYP_b44                       \ [0x0c] b44
    $0d constant CRYP_b45                       \ [0x0d] b45
    $0e constant CRYP_b46                       \ [0x0e] b46
    $0f constant CRYP_b47                       \ [0x0f] b47
    $10 constant CRYP_b48                       \ [0x10] b48
    $11 constant CRYP_b49                       \ [0x11] b49
    $12 constant CRYP_b50                       \ [0x12] b50
    $13 constant CRYP_b51                       \ [0x13] b51
    $14 constant CRYP_b52                       \ [0x14] b52
    $15 constant CRYP_b53                       \ [0x15] b53
    $16 constant CRYP_b54                       \ [0x16] b54
    $17 constant CRYP_b55                       \ [0x17] b55
    $18 constant CRYP_b56                       \ [0x18] b56
    $19 constant CRYP_b57                       \ [0x19] b57
    $1a constant CRYP_b58                       \ [0x1a] b58
    $1b constant CRYP_b59                       \ [0x1b] b59
    $1c constant CRYP_b60                       \ [0x1c] b60
    $1d constant CRYP_b61                       \ [0x1d] b61
    $1e constant CRYP_b62                       \ [0x1e] b62
    $1f constant CRYP_b63                       \ [0x1f] b63
  [then]


  [ifdef] CRYP_K3RR_DEF
    \
    \ @brief key registers
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_b0                        \ [0x00] b0
    $01 constant CRYP_b1                        \ [0x01] b1
    $02 constant CRYP_b2                        \ [0x02] b2
    $03 constant CRYP_b3                        \ [0x03] b3
    $04 constant CRYP_b4                        \ [0x04] b4
    $05 constant CRYP_b5                        \ [0x05] b5
    $06 constant CRYP_b6                        \ [0x06] b6
    $07 constant CRYP_b7                        \ [0x07] b7
    $08 constant CRYP_b8                        \ [0x08] b8
    $09 constant CRYP_b9                        \ [0x09] b9
    $0a constant CRYP_b10                       \ [0x0a] b10
    $0b constant CRYP_b11                       \ [0x0b] b11
    $0c constant CRYP_b12                       \ [0x0c] b12
    $0d constant CRYP_b13                       \ [0x0d] b13
    $0e constant CRYP_b14                       \ [0x0e] b14
    $0f constant CRYP_b15                       \ [0x0f] b15
    $10 constant CRYP_b16                       \ [0x10] b16
    $11 constant CRYP_b17                       \ [0x11] b17
    $12 constant CRYP_b18                       \ [0x12] b18
    $13 constant CRYP_b19                       \ [0x13] b19
    $14 constant CRYP_b20                       \ [0x14] b20
    $15 constant CRYP_b21                       \ [0x15] b21
    $16 constant CRYP_b22                       \ [0x16] b22
    $17 constant CRYP_b23                       \ [0x17] b23
    $18 constant CRYP_b24                       \ [0x18] b24
    $19 constant CRYP_b25                       \ [0x19] b25
    $1a constant CRYP_b26                       \ [0x1a] b26
    $1b constant CRYP_b27                       \ [0x1b] b27
    $1c constant CRYP_b28                       \ [0x1c] b28
    $1d constant CRYP_b29                       \ [0x1d] b29
    $1e constant CRYP_b30                       \ [0x1e] b30
    $1f constant CRYP_b31                       \ [0x1f] b31
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
