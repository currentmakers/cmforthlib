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

$00000001 constant CRYP_K0LR_B224                                   \ b224
$00000002 constant CRYP_K0LR_B225                                   \ b225
$00000004 constant CRYP_K0LR_B226                                   \ b226
$00000008 constant CRYP_K0LR_B227                                   \ b227
$00000010 constant CRYP_K0LR_B228                                   \ b228
$00000020 constant CRYP_K0LR_B229                                   \ b229
$00000040 constant CRYP_K0LR_B230                                   \ b230
$00000080 constant CRYP_K0LR_B231                                   \ b231
$00000100 constant CRYP_K0LR_B232                                   \ b232
$00000200 constant CRYP_K0LR_B233                                   \ b233
$00000400 constant CRYP_K0LR_B234                                   \ b234
$00000800 constant CRYP_K0LR_B235                                   \ b235
$00001000 constant CRYP_K0LR_B236                                   \ b236
$00002000 constant CRYP_K0LR_B237                                   \ b237
$00004000 constant CRYP_K0LR_B238                                   \ b238
$00008000 constant CRYP_K0LR_B239                                   \ b239
$00010000 constant CRYP_K0LR_B240                                   \ b240
$00020000 constant CRYP_K0LR_B241                                   \ b241
$00040000 constant CRYP_K0LR_B242                                   \ b242
$00080000 constant CRYP_K0LR_B243                                   \ b243
$00100000 constant CRYP_K0LR_B244                                   \ b244
$00200000 constant CRYP_K0LR_B245                                   \ b245
$00400000 constant CRYP_K0LR_B246                                   \ b246
$00800000 constant CRYP_K0LR_B247                                   \ b247
$01000000 constant CRYP_K0LR_B248                                   \ b248
$02000000 constant CRYP_K0LR_B249                                   \ b249
$04000000 constant CRYP_K0LR_B250                                   \ b250
$08000000 constant CRYP_K0LR_B251                                   \ b251
$10000000 constant CRYP_K0LR_B252                                   \ b252
$20000000 constant CRYP_K0LR_B253                                   \ b253
$40000000 constant CRYP_K0LR_B254                                   \ b254
$80000000 constant CRYP_K0LR_B255                                   \ b255


\
\ @brief key registers
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant CRYP_K0RR_B192                                   \ b192
$00000002 constant CRYP_K0RR_B193                                   \ b193
$00000004 constant CRYP_K0RR_B194                                   \ b194
$00000008 constant CRYP_K0RR_B195                                   \ b195
$00000010 constant CRYP_K0RR_B196                                   \ b196
$00000020 constant CRYP_K0RR_B197                                   \ b197
$00000040 constant CRYP_K0RR_B198                                   \ b198
$00000080 constant CRYP_K0RR_B199                                   \ b199
$00000100 constant CRYP_K0RR_B200                                   \ b200
$00000200 constant CRYP_K0RR_B201                                   \ b201
$00000400 constant CRYP_K0RR_B202                                   \ b202
$00000800 constant CRYP_K0RR_B203                                   \ b203
$00001000 constant CRYP_K0RR_B204                                   \ b204
$00002000 constant CRYP_K0RR_B205                                   \ b205
$00004000 constant CRYP_K0RR_B206                                   \ b206
$00008000 constant CRYP_K0RR_B207                                   \ b207
$00010000 constant CRYP_K0RR_B208                                   \ b208
$00020000 constant CRYP_K0RR_B209                                   \ b209
$00040000 constant CRYP_K0RR_B210                                   \ b210
$00080000 constant CRYP_K0RR_B211                                   \ b211
$00100000 constant CRYP_K0RR_B212                                   \ b212
$00200000 constant CRYP_K0RR_B213                                   \ b213
$00400000 constant CRYP_K0RR_B214                                   \ b214
$00800000 constant CRYP_K0RR_B215                                   \ b215
$01000000 constant CRYP_K0RR_B216                                   \ b216
$02000000 constant CRYP_K0RR_B217                                   \ b217
$04000000 constant CRYP_K0RR_B218                                   \ b218
$08000000 constant CRYP_K0RR_B219                                   \ b219
$10000000 constant CRYP_K0RR_B220                                   \ b220
$20000000 constant CRYP_K0RR_B221                                   \ b221
$40000000 constant CRYP_K0RR_B222                                   \ b222
$80000000 constant CRYP_K0RR_B223                                   \ b223


\
\ @brief key registers
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant CRYP_K1LR_B160                                   \ b160
$00000002 constant CRYP_K1LR_B161                                   \ b161
$00000004 constant CRYP_K1LR_B162                                   \ b162
$00000008 constant CRYP_K1LR_B163                                   \ b163
$00000010 constant CRYP_K1LR_B164                                   \ b164
$00000020 constant CRYP_K1LR_B165                                   \ b165
$00000040 constant CRYP_K1LR_B166                                   \ b166
$00000080 constant CRYP_K1LR_B167                                   \ b167
$00000100 constant CRYP_K1LR_B168                                   \ b168
$00000200 constant CRYP_K1LR_B169                                   \ b169
$00000400 constant CRYP_K1LR_B170                                   \ b170
$00000800 constant CRYP_K1LR_B171                                   \ b171
$00001000 constant CRYP_K1LR_B172                                   \ b172
$00002000 constant CRYP_K1LR_B173                                   \ b173
$00004000 constant CRYP_K1LR_B174                                   \ b174
$00008000 constant CRYP_K1LR_B175                                   \ b175
$00010000 constant CRYP_K1LR_B176                                   \ b176
$00020000 constant CRYP_K1LR_B177                                   \ b177
$00040000 constant CRYP_K1LR_B178                                   \ b178
$00080000 constant CRYP_K1LR_B179                                   \ b179
$00100000 constant CRYP_K1LR_B180                                   \ b180
$00200000 constant CRYP_K1LR_B181                                   \ b181
$00400000 constant CRYP_K1LR_B182                                   \ b182
$00800000 constant CRYP_K1LR_B183                                   \ b183
$01000000 constant CRYP_K1LR_B184                                   \ b184
$02000000 constant CRYP_K1LR_B185                                   \ b185
$04000000 constant CRYP_K1LR_B186                                   \ b186
$08000000 constant CRYP_K1LR_B187                                   \ b187
$10000000 constant CRYP_K1LR_B188                                   \ b188
$20000000 constant CRYP_K1LR_B189                                   \ b189
$40000000 constant CRYP_K1LR_B190                                   \ b190
$80000000 constant CRYP_K1LR_B191                                   \ b191


\
\ @brief key registers
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant CRYP_K1RR_B128                                   \ b128
$00000002 constant CRYP_K1RR_B129                                   \ b129
$00000004 constant CRYP_K1RR_B130                                   \ b130
$00000008 constant CRYP_K1RR_B131                                   \ b131
$00000010 constant CRYP_K1RR_B132                                   \ b132
$00000020 constant CRYP_K1RR_B133                                   \ b133
$00000040 constant CRYP_K1RR_B134                                   \ b134
$00000080 constant CRYP_K1RR_B135                                   \ b135
$00000100 constant CRYP_K1RR_B136                                   \ b136
$00000200 constant CRYP_K1RR_B137                                   \ b137
$00000400 constant CRYP_K1RR_B138                                   \ b138
$00000800 constant CRYP_K1RR_B139                                   \ b139
$00001000 constant CRYP_K1RR_B140                                   \ b140
$00002000 constant CRYP_K1RR_B141                                   \ b141
$00004000 constant CRYP_K1RR_B142                                   \ b142
$00008000 constant CRYP_K1RR_B143                                   \ b143
$00010000 constant CRYP_K1RR_B144                                   \ b144
$00020000 constant CRYP_K1RR_B145                                   \ b145
$00040000 constant CRYP_K1RR_B146                                   \ b146
$00080000 constant CRYP_K1RR_B147                                   \ b147
$00100000 constant CRYP_K1RR_B148                                   \ b148
$00200000 constant CRYP_K1RR_B149                                   \ b149
$00400000 constant CRYP_K1RR_B150                                   \ b150
$00800000 constant CRYP_K1RR_B151                                   \ b151
$01000000 constant CRYP_K1RR_B152                                   \ b152
$02000000 constant CRYP_K1RR_B153                                   \ b153
$04000000 constant CRYP_K1RR_B154                                   \ b154
$08000000 constant CRYP_K1RR_B155                                   \ b155
$10000000 constant CRYP_K1RR_B156                                   \ b156
$20000000 constant CRYP_K1RR_B157                                   \ b157
$40000000 constant CRYP_K1RR_B158                                   \ b158
$80000000 constant CRYP_K1RR_B159                                   \ b159


\
\ @brief key registers
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant CRYP_K2LR_B96                                    \ b96
$00000002 constant CRYP_K2LR_B97                                    \ b97
$00000004 constant CRYP_K2LR_B98                                    \ b98
$00000008 constant CRYP_K2LR_B99                                    \ b99
$00000010 constant CRYP_K2LR_B100                                   \ b100
$00000020 constant CRYP_K2LR_B101                                   \ b101
$00000040 constant CRYP_K2LR_B102                                   \ b102
$00000080 constant CRYP_K2LR_B103                                   \ b103
$00000100 constant CRYP_K2LR_B104                                   \ b104
$00000200 constant CRYP_K2LR_B105                                   \ b105
$00000400 constant CRYP_K2LR_B106                                   \ b106
$00000800 constant CRYP_K2LR_B107                                   \ b107
$00001000 constant CRYP_K2LR_B108                                   \ b108
$00002000 constant CRYP_K2LR_B109                                   \ b109
$00004000 constant CRYP_K2LR_B110                                   \ b110
$00008000 constant CRYP_K2LR_B111                                   \ b111
$00010000 constant CRYP_K2LR_B112                                   \ b112
$00020000 constant CRYP_K2LR_B113                                   \ b113
$00040000 constant CRYP_K2LR_B114                                   \ b114
$00080000 constant CRYP_K2LR_B115                                   \ b115
$00100000 constant CRYP_K2LR_B116                                   \ b116
$00200000 constant CRYP_K2LR_B117                                   \ b117
$00400000 constant CRYP_K2LR_B118                                   \ b118
$00800000 constant CRYP_K2LR_B119                                   \ b119
$01000000 constant CRYP_K2LR_B120                                   \ b120
$02000000 constant CRYP_K2LR_B121                                   \ b121
$04000000 constant CRYP_K2LR_B122                                   \ b122
$08000000 constant CRYP_K2LR_B123                                   \ b123
$10000000 constant CRYP_K2LR_B124                                   \ b124
$20000000 constant CRYP_K2LR_B125                                   \ b125
$40000000 constant CRYP_K2LR_B126                                   \ b126
$80000000 constant CRYP_K2LR_B127                                   \ b127


\
\ @brief key registers
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant CRYP_K2RR_B64                                    \ b64
$00000002 constant CRYP_K2RR_B65                                    \ b65
$00000004 constant CRYP_K2RR_B66                                    \ b66
$00000008 constant CRYP_K2RR_B67                                    \ b67
$00000010 constant CRYP_K2RR_B68                                    \ b68
$00000020 constant CRYP_K2RR_B69                                    \ b69
$00000040 constant CRYP_K2RR_B70                                    \ b70
$00000080 constant CRYP_K2RR_B71                                    \ b71
$00000100 constant CRYP_K2RR_B72                                    \ b72
$00000200 constant CRYP_K2RR_B73                                    \ b73
$00000400 constant CRYP_K2RR_B74                                    \ b74
$00000800 constant CRYP_K2RR_B75                                    \ b75
$00001000 constant CRYP_K2RR_B76                                    \ b76
$00002000 constant CRYP_K2RR_B77                                    \ b77
$00004000 constant CRYP_K2RR_B78                                    \ b78
$00008000 constant CRYP_K2RR_B79                                    \ b79
$00010000 constant CRYP_K2RR_B80                                    \ b80
$00020000 constant CRYP_K2RR_B81                                    \ b81
$00040000 constant CRYP_K2RR_B82                                    \ b82
$00080000 constant CRYP_K2RR_B83                                    \ b83
$00100000 constant CRYP_K2RR_B84                                    \ b84
$00200000 constant CRYP_K2RR_B85                                    \ b85
$00400000 constant CRYP_K2RR_B86                                    \ b86
$00800000 constant CRYP_K2RR_B87                                    \ b87
$01000000 constant CRYP_K2RR_B88                                    \ b88
$02000000 constant CRYP_K2RR_B89                                    \ b89
$04000000 constant CRYP_K2RR_B90                                    \ b90
$08000000 constant CRYP_K2RR_B91                                    \ b91
$10000000 constant CRYP_K2RR_B92                                    \ b92
$20000000 constant CRYP_K2RR_B93                                    \ b93
$40000000 constant CRYP_K2RR_B94                                    \ b94
$80000000 constant CRYP_K2RR_B95                                    \ b95


\
\ @brief key registers
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant CRYP_K3LR_B32                                    \ b32
$00000002 constant CRYP_K3LR_B33                                    \ b33
$00000004 constant CRYP_K3LR_B34                                    \ b34
$00000008 constant CRYP_K3LR_B35                                    \ b35
$00000010 constant CRYP_K3LR_B36                                    \ b36
$00000020 constant CRYP_K3LR_B37                                    \ b37
$00000040 constant CRYP_K3LR_B38                                    \ b38
$00000080 constant CRYP_K3LR_B39                                    \ b39
$00000100 constant CRYP_K3LR_B40                                    \ b40
$00000200 constant CRYP_K3LR_B41                                    \ b41
$00000400 constant CRYP_K3LR_B42                                    \ b42
$00000800 constant CRYP_K3LR_B43                                    \ b43
$00001000 constant CRYP_K3LR_B44                                    \ b44
$00002000 constant CRYP_K3LR_B45                                    \ b45
$00004000 constant CRYP_K3LR_B46                                    \ b46
$00008000 constant CRYP_K3LR_B47                                    \ b47
$00010000 constant CRYP_K3LR_B48                                    \ b48
$00020000 constant CRYP_K3LR_B49                                    \ b49
$00040000 constant CRYP_K3LR_B50                                    \ b50
$00080000 constant CRYP_K3LR_B51                                    \ b51
$00100000 constant CRYP_K3LR_B52                                    \ b52
$00200000 constant CRYP_K3LR_B53                                    \ b53
$00400000 constant CRYP_K3LR_B54                                    \ b54
$00800000 constant CRYP_K3LR_B55                                    \ b55
$01000000 constant CRYP_K3LR_B56                                    \ b56
$02000000 constant CRYP_K3LR_B57                                    \ b57
$04000000 constant CRYP_K3LR_B58                                    \ b58
$08000000 constant CRYP_K3LR_B59                                    \ b59
$10000000 constant CRYP_K3LR_B60                                    \ b60
$20000000 constant CRYP_K3LR_B61                                    \ b61
$40000000 constant CRYP_K3LR_B62                                    \ b62
$80000000 constant CRYP_K3LR_B63                                    \ b63


\
\ @brief key registers
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant CRYP_K3RR_B0                                     \ b0
$00000002 constant CRYP_K3RR_B1                                     \ b1
$00000004 constant CRYP_K3RR_B2                                     \ b2
$00000008 constant CRYP_K3RR_B3                                     \ b3
$00000010 constant CRYP_K3RR_B4                                     \ b4
$00000020 constant CRYP_K3RR_B5                                     \ b5
$00000040 constant CRYP_K3RR_B6                                     \ b6
$00000080 constant CRYP_K3RR_B7                                     \ b7
$00000100 constant CRYP_K3RR_B8                                     \ b8
$00000200 constant CRYP_K3RR_B9                                     \ b9
$00000400 constant CRYP_K3RR_B10                                    \ b10
$00000800 constant CRYP_K3RR_B11                                    \ b11
$00001000 constant CRYP_K3RR_B12                                    \ b12
$00002000 constant CRYP_K3RR_B13                                    \ b13
$00004000 constant CRYP_K3RR_B14                                    \ b14
$00008000 constant CRYP_K3RR_B15                                    \ b15
$00010000 constant CRYP_K3RR_B16                                    \ b16
$00020000 constant CRYP_K3RR_B17                                    \ b17
$00040000 constant CRYP_K3RR_B18                                    \ b18
$00080000 constant CRYP_K3RR_B19                                    \ b19
$00100000 constant CRYP_K3RR_B20                                    \ b20
$00200000 constant CRYP_K3RR_B21                                    \ b21
$00400000 constant CRYP_K3RR_B22                                    \ b22
$00800000 constant CRYP_K3RR_B23                                    \ b23
$01000000 constant CRYP_K3RR_B24                                    \ b24
$02000000 constant CRYP_K3RR_B25                                    \ b25
$04000000 constant CRYP_K3RR_B26                                    \ b26
$08000000 constant CRYP_K3RR_B27                                    \ b27
$10000000 constant CRYP_K3RR_B28                                    \ b28
$20000000 constant CRYP_K3RR_B29                                    \ b29
$40000000 constant CRYP_K3RR_B30                                    \ b30
$80000000 constant CRYP_K3RR_B31                                    \ b31


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

$00000000 constant CRYP_CSGCMCCM0R_CSGCMCCM0R                       \ CSGCMCCM0R


\
\ @brief context swap register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCMCCM1R_CSGCMCCM1R                       \ CSGCMCCM1R


\
\ @brief context swap register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCMCCM2R_CSGCMCCM2R                       \ CSGCMCCM2R


\
\ @brief context swap register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCMCCM3R_CSGCMCCM3R                       \ CSGCMCCM3R


\
\ @brief context swap register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCMCCM4R_CSGCMCCM4R                       \ CSGCMCCM4R


\
\ @brief context swap register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCMCCM5R_CSGCMCCM5R                       \ CSGCMCCM5R


\
\ @brief context swap register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCMCCM6R_CSGCMCCM6R                       \ CSGCMCCM6R


\
\ @brief context swap register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCMCCM7R_CSGCMCCM7R                       \ CSGCMCCM7R


\
\ @brief context swap register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCM0R_CSGCM0R                             \ CSGCM0R


\
\ @brief context swap register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCM1R_CSGCM1R                             \ CSGCM1R


\
\ @brief context swap register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCM2R_CSGCM2R                             \ CSGCM2R


\
\ @brief context swap register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCM3R_CSGCM3R                             \ CSGCM3R


\
\ @brief context swap register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCM4R_CSGCM4R                             \ CSGCM4R


\
\ @brief context swap register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCM5R_CSGCM5R                             \ CSGCM5R


\
\ @brief context swap register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCM6R_CSGCM6R                             \ CSGCM6R


\
\ @brief context swap register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_CSGCM7R_CSGCM7R                             \ CSGCM7R


\
\ @brief Cryptographic processor
\
$50060000 constant CRYP_CR        \ offset: 0x00 : control register
$50060004 constant CRYP_SR        \ offset: 0x04 : status register
$50060008 constant CRYP_DIN       \ offset: 0x08 : data input register
$5006000c constant CRYP_DOUT      \ offset: 0x0C : data output register
$50060010 constant CRYP_DMACR     \ offset: 0x10 : DMA control register
$50060014 constant CRYP_IMSCR     \ offset: 0x14 : interrupt mask set/clear register
$50060018 constant CRYP_RISR      \ offset: 0x18 : raw interrupt status register
$5006001c constant CRYP_MISR      \ offset: 0x1C : masked interrupt status register
$50060020 constant CRYP_K0LR      \ offset: 0x20 : key registers
$50060024 constant CRYP_K0RR      \ offset: 0x24 : key registers
$50060028 constant CRYP_K1LR      \ offset: 0x28 : key registers
$5006002c constant CRYP_K1RR      \ offset: 0x2C : key registers
$50060030 constant CRYP_K2LR      \ offset: 0x30 : key registers
$50060034 constant CRYP_K2RR      \ offset: 0x34 : key registers
$50060038 constant CRYP_K3LR      \ offset: 0x38 : key registers
$5006003c constant CRYP_K3RR      \ offset: 0x3C : key registers
$50060040 constant CRYP_IV0LR     \ offset: 0x40 : initialization vector registers
$50060044 constant CRYP_IV0RR     \ offset: 0x44 : initialization vector registers
$50060048 constant CRYP_IV1LR     \ offset: 0x48 : initialization vector registers
$5006004c constant CRYP_IV1RR     \ offset: 0x4C : initialization vector registers
$50060050 constant CRYP_CSGCMCCM0R  \ offset: 0x50 : context swap register
$50060054 constant CRYP_CSGCMCCM1R  \ offset: 0x54 : context swap register
$50060058 constant CRYP_CSGCMCCM2R  \ offset: 0x58 : context swap register
$5006005c constant CRYP_CSGCMCCM3R  \ offset: 0x5C : context swap register
$50060060 constant CRYP_CSGCMCCM4R  \ offset: 0x60 : context swap register
$50060064 constant CRYP_CSGCMCCM5R  \ offset: 0x64 : context swap register
$50060068 constant CRYP_CSGCMCCM6R  \ offset: 0x68 : context swap register
$5006006c constant CRYP_CSGCMCCM7R  \ offset: 0x6C : context swap register
$50060070 constant CRYP_CSGCM0R   \ offset: 0x70 : context swap register
$50060074 constant CRYP_CSGCM1R   \ offset: 0x74 : context swap register
$50060078 constant CRYP_CSGCM2R   \ offset: 0x78 : context swap register
$5006007c constant CRYP_CSGCM3R   \ offset: 0x7C : context swap register
$50060080 constant CRYP_CSGCM4R   \ offset: 0x80 : context swap register
$50060084 constant CRYP_CSGCM5R   \ offset: 0x84 : context swap register
$50060088 constant CRYP_CSGCM6R   \ offset: 0x88 : context swap register
$5006008c constant CRYP_CSGCM7R   \ offset: 0x8C : context swap register

