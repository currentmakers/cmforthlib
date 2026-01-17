\
\ @file gtzc_mpcbb2.fs
\ @brief GTZC_MPCBB2
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GTZC_MPCBB2_DEF

  [ifdef] GTZC_MPCBB2_MPCBB2_CR_DEF
    \
    \ @brief MPCBB control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GTZC_MPCBB2_LCK                \ [0x00] LCK
    $1e constant GTZC_MPCBB2_INVSECSTATE        \ [0x1e] INVSECSTATE
    $1f constant GTZC_MPCBB2_SRWILADIS          \ [0x1f] SRWILADIS
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_LCKVTR1_DEF
    \
    \ @brief MPCBB control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GTZC_MPCBB2_LCKSB0             \ [0x00] LCKSB0
    $01 constant GTZC_MPCBB2_LCKSB1             \ [0x01] LCKSB1
    $02 constant GTZC_MPCBB2_LCKSB2             \ [0x02] LCKSB2
    $03 constant GTZC_MPCBB2_LCKSB3             \ [0x03] LCKSB3
    $04 constant GTZC_MPCBB2_LCKSB4             \ [0x04] LCKSB4
    $05 constant GTZC_MPCBB2_LCKSB5             \ [0x05] LCKSB5
    $06 constant GTZC_MPCBB2_LCKSB6             \ [0x06] LCKSB6
    $07 constant GTZC_MPCBB2_LCKSB7             \ [0x07] LCKSB7
    $08 constant GTZC_MPCBB2_LCKSB8             \ [0x08] LCKSB8
    $09 constant GTZC_MPCBB2_LCKSB9             \ [0x09] LCKSB9
    $0a constant GTZC_MPCBB2_LCKSB10            \ [0x0a] LCKSB10
    $0b constant GTZC_MPCBB2_LCKSB11            \ [0x0b] LCKSB11
    $0c constant GTZC_MPCBB2_LCKSB12            \ [0x0c] LCKSB12
    $0d constant GTZC_MPCBB2_LCKSB13            \ [0x0d] LCKSB13
    $0e constant GTZC_MPCBB2_LCKSB14            \ [0x0e] LCKSB14
    $0f constant GTZC_MPCBB2_LCKSB15            \ [0x0f] LCKSB15
    $10 constant GTZC_MPCBB2_LCKSB16            \ [0x10] LCKSB16
    $11 constant GTZC_MPCBB2_LCKSB17            \ [0x11] LCKSB17
    $12 constant GTZC_MPCBB2_LCKSB18            \ [0x12] LCKSB18
    $13 constant GTZC_MPCBB2_LCKSB19            \ [0x13] LCKSB19
    $14 constant GTZC_MPCBB2_LCKSB20            \ [0x14] LCKSB20
    $15 constant GTZC_MPCBB2_LCKSB21            \ [0x15] LCKSB21
    $16 constant GTZC_MPCBB2_LCKSB22            \ [0x16] LCKSB22
    $17 constant GTZC_MPCBB2_LCKSB23            \ [0x17] LCKSB23
    $18 constant GTZC_MPCBB2_LCKSB24            \ [0x18] LCKSB24
    $19 constant GTZC_MPCBB2_LCKSB25            \ [0x19] LCKSB25
    $1a constant GTZC_MPCBB2_LCKSB26            \ [0x1a] LCKSB26
    $1b constant GTZC_MPCBB2_LCKSB27            \ [0x1b] LCKSB27
    $1c constant GTZC_MPCBB2_LCKSB28            \ [0x1c] LCKSB28
    $1d constant GTZC_MPCBB2_LCKSB29            \ [0x1d] LCKSB29
    $1e constant GTZC_MPCBB2_LCKSB30            \ [0x1e] LCKSB30
    $1f constant GTZC_MPCBB2_LCKSB31            \ [0x1f] LCKSB31
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_LCKVTR2_DEF
    \
    \ @brief MPCBB control register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GTZC_MPCBB2_LCKSB32            \ [0x00] LCKSB32
    $01 constant GTZC_MPCBB2_LCKSB33            \ [0x01] LCKSB33
    $02 constant GTZC_MPCBB2_LCKSB34            \ [0x02] LCKSB34
    $03 constant GTZC_MPCBB2_LCKSB35            \ [0x03] LCKSB35
    $04 constant GTZC_MPCBB2_LCKSB36            \ [0x04] LCKSB36
    $05 constant GTZC_MPCBB2_LCKSB37            \ [0x05] LCKSB37
    $06 constant GTZC_MPCBB2_LCKSB38            \ [0x06] LCKSB38
    $07 constant GTZC_MPCBB2_LCKSB39            \ [0x07] LCKSB39
    $08 constant GTZC_MPCBB2_LCKSB40            \ [0x08] LCKSB40
    $09 constant GTZC_MPCBB2_LCKSB41            \ [0x09] LCKSB41
    $0a constant GTZC_MPCBB2_LCKSB42            \ [0x0a] LCKSB42
    $0b constant GTZC_MPCBB2_LCKSB43            \ [0x0b] LCKSB43
    $0c constant GTZC_MPCBB2_LCKSB44            \ [0x0c] LCKSB44
    $0d constant GTZC_MPCBB2_LCKSB45            \ [0x0d] LCKSB45
    $0e constant GTZC_MPCBB2_LCKSB46            \ [0x0e] LCKSB46
    $0f constant GTZC_MPCBB2_LCKSB47            \ [0x0f] LCKSB47
    $10 constant GTZC_MPCBB2_LCKSB48            \ [0x10] LCKSB48
    $11 constant GTZC_MPCBB2_LCKSB49            \ [0x11] LCKSB49
    $12 constant GTZC_MPCBB2_LCKSB50            \ [0x12] LCKSB50
    $13 constant GTZC_MPCBB2_LCKSB51            \ [0x13] LCKSB51
    $14 constant GTZC_MPCBB2_LCKSB52            \ [0x14] LCKSB52
    $15 constant GTZC_MPCBB2_LCKSB53            \ [0x15] LCKSB53
    $16 constant GTZC_MPCBB2_LCKSB54            \ [0x16] LCKSB54
    $17 constant GTZC_MPCBB2_LCKSB55            \ [0x17] LCKSB55
    $18 constant GTZC_MPCBB2_LCKSB56            \ [0x18] LCKSB56
    $19 constant GTZC_MPCBB2_LCKSB57            \ [0x19] LCKSB57
    $1a constant GTZC_MPCBB2_LCKSB58            \ [0x1a] LCKSB58
    $1b constant GTZC_MPCBB2_LCKSB59            \ [0x1b] LCKSB59
    $1c constant GTZC_MPCBB2_LCKSB60            \ [0x1c] LCKSB60
    $1d constant GTZC_MPCBB2_LCKSB61            \ [0x1d] LCKSB61
    $1e constant GTZC_MPCBB2_LCKSB62            \ [0x1e] LCKSB62
    $1f constant GTZC_MPCBB2_LCKSB63            \ [0x1f] LCKSB63
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR0_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x100
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B0                 \ [0x00] B0
    $01 constant GTZC_MPCBB2_B1                 \ [0x01] B1
    $02 constant GTZC_MPCBB2_B2                 \ [0x02] B2
    $03 constant GTZC_MPCBB2_B3                 \ [0x03] B3
    $04 constant GTZC_MPCBB2_B4                 \ [0x04] B4
    $05 constant GTZC_MPCBB2_B5                 \ [0x05] B5
    $06 constant GTZC_MPCBB2_B6                 \ [0x06] B6
    $07 constant GTZC_MPCBB2_B7                 \ [0x07] B7
    $08 constant GTZC_MPCBB2_B8                 \ [0x08] B8
    $09 constant GTZC_MPCBB2_B9                 \ [0x09] B9
    $0a constant GTZC_MPCBB2_B10                \ [0x0a] B10
    $0b constant GTZC_MPCBB2_B11                \ [0x0b] B11
    $0c constant GTZC_MPCBB2_B12                \ [0x0c] B12
    $0d constant GTZC_MPCBB2_B13                \ [0x0d] B13
    $0e constant GTZC_MPCBB2_B14                \ [0x0e] B14
    $0f constant GTZC_MPCBB2_B15                \ [0x0f] B15
    $10 constant GTZC_MPCBB2_B16                \ [0x10] B16
    $11 constant GTZC_MPCBB2_B17                \ [0x11] B17
    $12 constant GTZC_MPCBB2_B18                \ [0x12] B18
    $13 constant GTZC_MPCBB2_B19                \ [0x13] B19
    $14 constant GTZC_MPCBB2_B20                \ [0x14] B20
    $15 constant GTZC_MPCBB2_B21                \ [0x15] B21
    $16 constant GTZC_MPCBB2_B22                \ [0x16] B22
    $17 constant GTZC_MPCBB2_B23                \ [0x17] B23
    $18 constant GTZC_MPCBB2_B24                \ [0x18] B24
    $19 constant GTZC_MPCBB2_B25                \ [0x19] B25
    $1a constant GTZC_MPCBB2_B26                \ [0x1a] B26
    $1b constant GTZC_MPCBB2_B27                \ [0x1b] B27
    $1c constant GTZC_MPCBB2_B28                \ [0x1c] B28
    $1d constant GTZC_MPCBB2_B29                \ [0x1d] B29
    $1e constant GTZC_MPCBB2_B30                \ [0x1e] B30
    $1f constant GTZC_MPCBB2_B31                \ [0x1f] B31
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR1_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x104
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B32                \ [0x00] B32
    $01 constant GTZC_MPCBB2_B33                \ [0x01] B33
    $02 constant GTZC_MPCBB2_B34                \ [0x02] B34
    $03 constant GTZC_MPCBB2_B35                \ [0x03] B35
    $04 constant GTZC_MPCBB2_B36                \ [0x04] B36
    $05 constant GTZC_MPCBB2_B37                \ [0x05] B37
    $06 constant GTZC_MPCBB2_B38                \ [0x06] B38
    $07 constant GTZC_MPCBB2_B39                \ [0x07] B39
    $08 constant GTZC_MPCBB2_B40                \ [0x08] B40
    $09 constant GTZC_MPCBB2_B41                \ [0x09] B41
    $0a constant GTZC_MPCBB2_B42                \ [0x0a] B42
    $0b constant GTZC_MPCBB2_B43                \ [0x0b] B43
    $0c constant GTZC_MPCBB2_B44                \ [0x0c] B44
    $0d constant GTZC_MPCBB2_B45                \ [0x0d] B45
    $0e constant GTZC_MPCBB2_B46                \ [0x0e] B46
    $0f constant GTZC_MPCBB2_B47                \ [0x0f] B47
    $10 constant GTZC_MPCBB2_B48                \ [0x10] B48
    $11 constant GTZC_MPCBB2_B49                \ [0x11] B49
    $12 constant GTZC_MPCBB2_B50                \ [0x12] B50
    $13 constant GTZC_MPCBB2_B51                \ [0x13] B51
    $14 constant GTZC_MPCBB2_B52                \ [0x14] B52
    $15 constant GTZC_MPCBB2_B53                \ [0x15] B53
    $16 constant GTZC_MPCBB2_B54                \ [0x16] B54
    $17 constant GTZC_MPCBB2_B55                \ [0x17] B55
    $18 constant GTZC_MPCBB2_B56                \ [0x18] B56
    $19 constant GTZC_MPCBB2_B57                \ [0x19] B57
    $1a constant GTZC_MPCBB2_B58                \ [0x1a] B58
    $1b constant GTZC_MPCBB2_B59                \ [0x1b] B59
    $1c constant GTZC_MPCBB2_B60                \ [0x1c] B60
    $1d constant GTZC_MPCBB2_B61                \ [0x1d] B61
    $1e constant GTZC_MPCBB2_B62                \ [0x1e] B62
    $1f constant GTZC_MPCBB2_B63                \ [0x1f] B63
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR2_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x108
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B64                \ [0x00] B64
    $01 constant GTZC_MPCBB2_B65                \ [0x01] B65
    $02 constant GTZC_MPCBB2_B66                \ [0x02] B66
    $03 constant GTZC_MPCBB2_B67                \ [0x03] B67
    $04 constant GTZC_MPCBB2_B68                \ [0x04] B68
    $05 constant GTZC_MPCBB2_B69                \ [0x05] B69
    $06 constant GTZC_MPCBB2_B70                \ [0x06] B70
    $07 constant GTZC_MPCBB2_B71                \ [0x07] B71
    $08 constant GTZC_MPCBB2_B72                \ [0x08] B72
    $09 constant GTZC_MPCBB2_B73                \ [0x09] B73
    $0a constant GTZC_MPCBB2_B74                \ [0x0a] B74
    $0b constant GTZC_MPCBB2_B75                \ [0x0b] B75
    $0c constant GTZC_MPCBB2_B76                \ [0x0c] B76
    $0d constant GTZC_MPCBB2_B77                \ [0x0d] B77
    $0e constant GTZC_MPCBB2_B78                \ [0x0e] B78
    $0f constant GTZC_MPCBB2_B79                \ [0x0f] B79
    $10 constant GTZC_MPCBB2_B80                \ [0x10] B80
    $11 constant GTZC_MPCBB2_B81                \ [0x11] B81
    $12 constant GTZC_MPCBB2_B82                \ [0x12] B82
    $13 constant GTZC_MPCBB2_B83                \ [0x13] B83
    $14 constant GTZC_MPCBB2_B84                \ [0x14] B84
    $15 constant GTZC_MPCBB2_B85                \ [0x15] B85
    $16 constant GTZC_MPCBB2_B86                \ [0x16] B86
    $17 constant GTZC_MPCBB2_B87                \ [0x17] B87
    $18 constant GTZC_MPCBB2_B88                \ [0x18] B88
    $19 constant GTZC_MPCBB2_B89                \ [0x19] B89
    $1a constant GTZC_MPCBB2_B90                \ [0x1a] B90
    $1b constant GTZC_MPCBB2_B91                \ [0x1b] B91
    $1c constant GTZC_MPCBB2_B92                \ [0x1c] B92
    $1d constant GTZC_MPCBB2_B93                \ [0x1d] B93
    $1e constant GTZC_MPCBB2_B94                \ [0x1e] B94
    $1f constant GTZC_MPCBB2_B95                \ [0x1f] B95
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR3_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x10C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B96                \ [0x00] B96
    $01 constant GTZC_MPCBB2_B97                \ [0x01] B97
    $02 constant GTZC_MPCBB2_B98                \ [0x02] B98
    $03 constant GTZC_MPCBB2_B99                \ [0x03] B99
    $04 constant GTZC_MPCBB2_B100               \ [0x04] B100
    $05 constant GTZC_MPCBB2_B101               \ [0x05] B101
    $06 constant GTZC_MPCBB2_B102               \ [0x06] B102
    $07 constant GTZC_MPCBB2_B103               \ [0x07] B103
    $08 constant GTZC_MPCBB2_B104               \ [0x08] B104
    $09 constant GTZC_MPCBB2_B105               \ [0x09] B105
    $0a constant GTZC_MPCBB2_B106               \ [0x0a] B106
    $0b constant GTZC_MPCBB2_B107               \ [0x0b] B107
    $0c constant GTZC_MPCBB2_B108               \ [0x0c] B108
    $0d constant GTZC_MPCBB2_B109               \ [0x0d] B109
    $0e constant GTZC_MPCBB2_B110               \ [0x0e] B110
    $0f constant GTZC_MPCBB2_B111               \ [0x0f] B111
    $10 constant GTZC_MPCBB2_B112               \ [0x10] B112
    $11 constant GTZC_MPCBB2_B113               \ [0x11] B113
    $12 constant GTZC_MPCBB2_B114               \ [0x12] B114
    $13 constant GTZC_MPCBB2_B115               \ [0x13] B115
    $14 constant GTZC_MPCBB2_B116               \ [0x14] B116
    $15 constant GTZC_MPCBB2_B117               \ [0x15] B117
    $16 constant GTZC_MPCBB2_B118               \ [0x16] B118
    $17 constant GTZC_MPCBB2_B119               \ [0x17] B119
    $18 constant GTZC_MPCBB2_B120               \ [0x18] B120
    $19 constant GTZC_MPCBB2_B121               \ [0x19] B121
    $1a constant GTZC_MPCBB2_B122               \ [0x1a] B122
    $1b constant GTZC_MPCBB2_B123               \ [0x1b] B123
    $1c constant GTZC_MPCBB2_B124               \ [0x1c] B124
    $1d constant GTZC_MPCBB2_B125               \ [0x1d] B125
    $1e constant GTZC_MPCBB2_B126               \ [0x1e] B126
    $1f constant GTZC_MPCBB2_B127               \ [0x1f] B127
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR4_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x110
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B128               \ [0x00] B128
    $01 constant GTZC_MPCBB2_B129               \ [0x01] B129
    $02 constant GTZC_MPCBB2_B130               \ [0x02] B130
    $03 constant GTZC_MPCBB2_B131               \ [0x03] B131
    $04 constant GTZC_MPCBB2_B132               \ [0x04] B132
    $05 constant GTZC_MPCBB2_B133               \ [0x05] B133
    $06 constant GTZC_MPCBB2_B134               \ [0x06] B134
    $07 constant GTZC_MPCBB2_B135               \ [0x07] B135
    $08 constant GTZC_MPCBB2_B136               \ [0x08] B136
    $09 constant GTZC_MPCBB2_B137               \ [0x09] B137
    $0a constant GTZC_MPCBB2_B138               \ [0x0a] B138
    $0b constant GTZC_MPCBB2_B139               \ [0x0b] B139
    $0c constant GTZC_MPCBB2_B140               \ [0x0c] B140
    $0d constant GTZC_MPCBB2_B141               \ [0x0d] B141
    $0e constant GTZC_MPCBB2_B142               \ [0x0e] B142
    $0f constant GTZC_MPCBB2_B143               \ [0x0f] B143
    $10 constant GTZC_MPCBB2_B144               \ [0x10] B144
    $11 constant GTZC_MPCBB2_B145               \ [0x11] B145
    $12 constant GTZC_MPCBB2_B146               \ [0x12] B146
    $13 constant GTZC_MPCBB2_B147               \ [0x13] B147
    $14 constant GTZC_MPCBB2_B148               \ [0x14] B148
    $15 constant GTZC_MPCBB2_B149               \ [0x15] B149
    $16 constant GTZC_MPCBB2_B150               \ [0x16] B150
    $17 constant GTZC_MPCBB2_B151               \ [0x17] B151
    $18 constant GTZC_MPCBB2_B152               \ [0x18] B152
    $19 constant GTZC_MPCBB2_B153               \ [0x19] B153
    $1a constant GTZC_MPCBB2_B154               \ [0x1a] B154
    $1b constant GTZC_MPCBB2_B155               \ [0x1b] B155
    $1c constant GTZC_MPCBB2_B156               \ [0x1c] B156
    $1d constant GTZC_MPCBB2_B157               \ [0x1d] B157
    $1e constant GTZC_MPCBB2_B158               \ [0x1e] B158
    $1f constant GTZC_MPCBB2_B159               \ [0x1f] B159
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR5_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x114
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B160               \ [0x00] B160
    $01 constant GTZC_MPCBB2_B161               \ [0x01] B161
    $02 constant GTZC_MPCBB2_B162               \ [0x02] B162
    $03 constant GTZC_MPCBB2_B163               \ [0x03] B163
    $04 constant GTZC_MPCBB2_B164               \ [0x04] B164
    $05 constant GTZC_MPCBB2_B165               \ [0x05] B165
    $06 constant GTZC_MPCBB2_B166               \ [0x06] B166
    $07 constant GTZC_MPCBB2_B167               \ [0x07] B167
    $08 constant GTZC_MPCBB2_B168               \ [0x08] B168
    $09 constant GTZC_MPCBB2_B169               \ [0x09] B169
    $0a constant GTZC_MPCBB2_B170               \ [0x0a] B170
    $0b constant GTZC_MPCBB2_B171               \ [0x0b] B171
    $0c constant GTZC_MPCBB2_B172               \ [0x0c] B172
    $0d constant GTZC_MPCBB2_B173               \ [0x0d] B173
    $0e constant GTZC_MPCBB2_B174               \ [0x0e] B174
    $0f constant GTZC_MPCBB2_B175               \ [0x0f] B175
    $10 constant GTZC_MPCBB2_B176               \ [0x10] B176
    $11 constant GTZC_MPCBB2_B177               \ [0x11] B177
    $12 constant GTZC_MPCBB2_B178               \ [0x12] B178
    $13 constant GTZC_MPCBB2_B179               \ [0x13] B179
    $14 constant GTZC_MPCBB2_B180               \ [0x14] B180
    $15 constant GTZC_MPCBB2_B181               \ [0x15] B181
    $16 constant GTZC_MPCBB2_B182               \ [0x16] B182
    $17 constant GTZC_MPCBB2_B183               \ [0x17] B183
    $18 constant GTZC_MPCBB2_B184               \ [0x18] B184
    $19 constant GTZC_MPCBB2_B185               \ [0x19] B185
    $1a constant GTZC_MPCBB2_B186               \ [0x1a] B186
    $1b constant GTZC_MPCBB2_B187               \ [0x1b] B187
    $1c constant GTZC_MPCBB2_B188               \ [0x1c] B188
    $1d constant GTZC_MPCBB2_B189               \ [0x1d] B189
    $1e constant GTZC_MPCBB2_B190               \ [0x1e] B190
    $1f constant GTZC_MPCBB2_B191               \ [0x1f] B191
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR6_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x118
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B192               \ [0x00] B192
    $01 constant GTZC_MPCBB2_B193               \ [0x01] B193
    $02 constant GTZC_MPCBB2_B194               \ [0x02] B194
    $03 constant GTZC_MPCBB2_B195               \ [0x03] B195
    $04 constant GTZC_MPCBB2_B196               \ [0x04] B196
    $05 constant GTZC_MPCBB2_B197               \ [0x05] B197
    $06 constant GTZC_MPCBB2_B198               \ [0x06] B198
    $07 constant GTZC_MPCBB2_B199               \ [0x07] B199
    $08 constant GTZC_MPCBB2_B200               \ [0x08] B200
    $09 constant GTZC_MPCBB2_B201               \ [0x09] B201
    $0a constant GTZC_MPCBB2_B202               \ [0x0a] B202
    $0b constant GTZC_MPCBB2_B203               \ [0x0b] B203
    $0c constant GTZC_MPCBB2_B204               \ [0x0c] B204
    $0d constant GTZC_MPCBB2_B205               \ [0x0d] B205
    $0e constant GTZC_MPCBB2_B206               \ [0x0e] B206
    $0f constant GTZC_MPCBB2_B207               \ [0x0f] B207
    $10 constant GTZC_MPCBB2_B208               \ [0x10] B208
    $11 constant GTZC_MPCBB2_B209               \ [0x11] B209
    $12 constant GTZC_MPCBB2_B210               \ [0x12] B210
    $13 constant GTZC_MPCBB2_B211               \ [0x13] B211
    $14 constant GTZC_MPCBB2_B212               \ [0x14] B212
    $15 constant GTZC_MPCBB2_B213               \ [0x15] B213
    $16 constant GTZC_MPCBB2_B214               \ [0x16] B214
    $17 constant GTZC_MPCBB2_B215               \ [0x17] B215
    $18 constant GTZC_MPCBB2_B216               \ [0x18] B216
    $19 constant GTZC_MPCBB2_B217               \ [0x19] B217
    $1a constant GTZC_MPCBB2_B218               \ [0x1a] B218
    $1b constant GTZC_MPCBB2_B219               \ [0x1b] B219
    $1c constant GTZC_MPCBB2_B220               \ [0x1c] B220
    $1d constant GTZC_MPCBB2_B221               \ [0x1d] B221
    $1e constant GTZC_MPCBB2_B222               \ [0x1e] B222
    $1f constant GTZC_MPCBB2_B223               \ [0x1f] B223
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR7_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x11C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B224               \ [0x00] B224
    $01 constant GTZC_MPCBB2_B225               \ [0x01] B225
    $02 constant GTZC_MPCBB2_B226               \ [0x02] B226
    $03 constant GTZC_MPCBB2_B227               \ [0x03] B227
    $04 constant GTZC_MPCBB2_B228               \ [0x04] B228
    $05 constant GTZC_MPCBB2_B229               \ [0x05] B229
    $06 constant GTZC_MPCBB2_B230               \ [0x06] B230
    $07 constant GTZC_MPCBB2_B231               \ [0x07] B231
    $08 constant GTZC_MPCBB2_B232               \ [0x08] B232
    $09 constant GTZC_MPCBB2_B233               \ [0x09] B233
    $0a constant GTZC_MPCBB2_B234               \ [0x0a] B234
    $0b constant GTZC_MPCBB2_B235               \ [0x0b] B235
    $0c constant GTZC_MPCBB2_B236               \ [0x0c] B236
    $0d constant GTZC_MPCBB2_B237               \ [0x0d] B237
    $0e constant GTZC_MPCBB2_B238               \ [0x0e] B238
    $0f constant GTZC_MPCBB2_B239               \ [0x0f] B239
    $10 constant GTZC_MPCBB2_B240               \ [0x10] B240
    $11 constant GTZC_MPCBB2_B241               \ [0x11] B241
    $12 constant GTZC_MPCBB2_B242               \ [0x12] B242
    $13 constant GTZC_MPCBB2_B243               \ [0x13] B243
    $14 constant GTZC_MPCBB2_B244               \ [0x14] B244
    $15 constant GTZC_MPCBB2_B245               \ [0x15] B245
    $16 constant GTZC_MPCBB2_B246               \ [0x16] B246
    $17 constant GTZC_MPCBB2_B247               \ [0x17] B247
    $18 constant GTZC_MPCBB2_B248               \ [0x18] B248
    $19 constant GTZC_MPCBB2_B249               \ [0x19] B249
    $1a constant GTZC_MPCBB2_B250               \ [0x1a] B250
    $1b constant GTZC_MPCBB2_B251               \ [0x1b] B251
    $1c constant GTZC_MPCBB2_B252               \ [0x1c] B252
    $1d constant GTZC_MPCBB2_B253               \ [0x1d] B253
    $1e constant GTZC_MPCBB2_B254               \ [0x1e] B254
    $1f constant GTZC_MPCBB2_B255               \ [0x1f] B255
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR8_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x120
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B256               \ [0x00] B256
    $01 constant GTZC_MPCBB2_B257               \ [0x01] B257
    $02 constant GTZC_MPCBB2_B258               \ [0x02] B258
    $03 constant GTZC_MPCBB2_B259               \ [0x03] B259
    $04 constant GTZC_MPCBB2_B260               \ [0x04] B260
    $05 constant GTZC_MPCBB2_B261               \ [0x05] B261
    $06 constant GTZC_MPCBB2_B262               \ [0x06] B262
    $07 constant GTZC_MPCBB2_B263               \ [0x07] B263
    $08 constant GTZC_MPCBB2_B264               \ [0x08] B264
    $09 constant GTZC_MPCBB2_B265               \ [0x09] B265
    $0a constant GTZC_MPCBB2_B266               \ [0x0a] B266
    $0b constant GTZC_MPCBB2_B267               \ [0x0b] B267
    $0c constant GTZC_MPCBB2_B268               \ [0x0c] B268
    $0d constant GTZC_MPCBB2_B269               \ [0x0d] B269
    $0e constant GTZC_MPCBB2_B270               \ [0x0e] B270
    $0f constant GTZC_MPCBB2_B271               \ [0x0f] B271
    $10 constant GTZC_MPCBB2_B272               \ [0x10] B272
    $11 constant GTZC_MPCBB2_B273               \ [0x11] B273
    $12 constant GTZC_MPCBB2_B274               \ [0x12] B274
    $13 constant GTZC_MPCBB2_B275               \ [0x13] B275
    $14 constant GTZC_MPCBB2_B276               \ [0x14] B276
    $15 constant GTZC_MPCBB2_B277               \ [0x15] B277
    $16 constant GTZC_MPCBB2_B278               \ [0x16] B278
    $17 constant GTZC_MPCBB2_B279               \ [0x17] B279
    $18 constant GTZC_MPCBB2_B280               \ [0x18] B280
    $19 constant GTZC_MPCBB2_B281               \ [0x19] B281
    $1a constant GTZC_MPCBB2_B282               \ [0x1a] B282
    $1b constant GTZC_MPCBB2_B283               \ [0x1b] B283
    $1c constant GTZC_MPCBB2_B284               \ [0x1c] B284
    $1d constant GTZC_MPCBB2_B285               \ [0x1d] B285
    $1e constant GTZC_MPCBB2_B286               \ [0x1e] B286
    $1f constant GTZC_MPCBB2_B287               \ [0x1f] B287
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR9_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x124
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B288               \ [0x00] B288
    $01 constant GTZC_MPCBB2_B289               \ [0x01] B289
    $02 constant GTZC_MPCBB2_B290               \ [0x02] B290
    $03 constant GTZC_MPCBB2_B291               \ [0x03] B291
    $04 constant GTZC_MPCBB2_B292               \ [0x04] B292
    $05 constant GTZC_MPCBB2_B293               \ [0x05] B293
    $06 constant GTZC_MPCBB2_B294               \ [0x06] B294
    $07 constant GTZC_MPCBB2_B295               \ [0x07] B295
    $08 constant GTZC_MPCBB2_B296               \ [0x08] B296
    $09 constant GTZC_MPCBB2_B297               \ [0x09] B297
    $0a constant GTZC_MPCBB2_B298               \ [0x0a] B298
    $0b constant GTZC_MPCBB2_B299               \ [0x0b] B299
    $0c constant GTZC_MPCBB2_B300               \ [0x0c] B300
    $0d constant GTZC_MPCBB2_B301               \ [0x0d] B301
    $0e constant GTZC_MPCBB2_B302               \ [0x0e] B302
    $0f constant GTZC_MPCBB2_B303               \ [0x0f] B303
    $10 constant GTZC_MPCBB2_B304               \ [0x10] B304
    $11 constant GTZC_MPCBB2_B305               \ [0x11] B305
    $12 constant GTZC_MPCBB2_B306               \ [0x12] B306
    $13 constant GTZC_MPCBB2_B307               \ [0x13] B307
    $14 constant GTZC_MPCBB2_B308               \ [0x14] B308
    $15 constant GTZC_MPCBB2_B309               \ [0x15] B309
    $16 constant GTZC_MPCBB2_B310               \ [0x16] B310
    $17 constant GTZC_MPCBB2_B311               \ [0x17] B311
    $18 constant GTZC_MPCBB2_B312               \ [0x18] B312
    $19 constant GTZC_MPCBB2_B313               \ [0x19] B313
    $1a constant GTZC_MPCBB2_B314               \ [0x1a] B314
    $1b constant GTZC_MPCBB2_B315               \ [0x1b] B315
    $1c constant GTZC_MPCBB2_B316               \ [0x1c] B316
    $1d constant GTZC_MPCBB2_B317               \ [0x1d] B317
    $1e constant GTZC_MPCBB2_B318               \ [0x1e] B318
    $1f constant GTZC_MPCBB2_B319               \ [0x1f] B319
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR10_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x128
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B320               \ [0x00] B320
    $01 constant GTZC_MPCBB2_B321               \ [0x01] B321
    $02 constant GTZC_MPCBB2_B322               \ [0x02] B322
    $03 constant GTZC_MPCBB2_B323               \ [0x03] B323
    $04 constant GTZC_MPCBB2_B324               \ [0x04] B324
    $05 constant GTZC_MPCBB2_B325               \ [0x05] B325
    $06 constant GTZC_MPCBB2_B326               \ [0x06] B326
    $07 constant GTZC_MPCBB2_B327               \ [0x07] B327
    $08 constant GTZC_MPCBB2_B328               \ [0x08] B328
    $09 constant GTZC_MPCBB2_B329               \ [0x09] B329
    $0a constant GTZC_MPCBB2_B330               \ [0x0a] B330
    $0b constant GTZC_MPCBB2_B331               \ [0x0b] B331
    $0c constant GTZC_MPCBB2_B332               \ [0x0c] B332
    $0d constant GTZC_MPCBB2_B333               \ [0x0d] B333
    $0e constant GTZC_MPCBB2_B334               \ [0x0e] B334
    $0f constant GTZC_MPCBB2_B335               \ [0x0f] B335
    $10 constant GTZC_MPCBB2_B336               \ [0x10] B336
    $11 constant GTZC_MPCBB2_B337               \ [0x11] B337
    $12 constant GTZC_MPCBB2_B338               \ [0x12] B338
    $13 constant GTZC_MPCBB2_B339               \ [0x13] B339
    $14 constant GTZC_MPCBB2_B340               \ [0x14] B340
    $15 constant GTZC_MPCBB2_B341               \ [0x15] B341
    $16 constant GTZC_MPCBB2_B342               \ [0x16] B342
    $17 constant GTZC_MPCBB2_B343               \ [0x17] B343
    $18 constant GTZC_MPCBB2_B344               \ [0x18] B344
    $19 constant GTZC_MPCBB2_B345               \ [0x19] B345
    $1a constant GTZC_MPCBB2_B346               \ [0x1a] B346
    $1b constant GTZC_MPCBB2_B347               \ [0x1b] B347
    $1c constant GTZC_MPCBB2_B348               \ [0x1c] B348
    $1d constant GTZC_MPCBB2_B349               \ [0x1d] B349
    $1e constant GTZC_MPCBB2_B350               \ [0x1e] B350
    $1f constant GTZC_MPCBB2_B351               \ [0x1f] B351
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR11_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x12C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B352               \ [0x00] B352
    $01 constant GTZC_MPCBB2_B353               \ [0x01] B353
    $02 constant GTZC_MPCBB2_B354               \ [0x02] B354
    $03 constant GTZC_MPCBB2_B355               \ [0x03] B355
    $04 constant GTZC_MPCBB2_B356               \ [0x04] B356
    $05 constant GTZC_MPCBB2_B357               \ [0x05] B357
    $06 constant GTZC_MPCBB2_B358               \ [0x06] B358
    $07 constant GTZC_MPCBB2_B359               \ [0x07] B359
    $08 constant GTZC_MPCBB2_B360               \ [0x08] B360
    $09 constant GTZC_MPCBB2_B361               \ [0x09] B361
    $0a constant GTZC_MPCBB2_B362               \ [0x0a] B362
    $0b constant GTZC_MPCBB2_B363               \ [0x0b] B363
    $0c constant GTZC_MPCBB2_B364               \ [0x0c] B364
    $0d constant GTZC_MPCBB2_B365               \ [0x0d] B365
    $0e constant GTZC_MPCBB2_B366               \ [0x0e] B366
    $0f constant GTZC_MPCBB2_B367               \ [0x0f] B367
    $10 constant GTZC_MPCBB2_B368               \ [0x10] B368
    $11 constant GTZC_MPCBB2_B369               \ [0x11] B369
    $12 constant GTZC_MPCBB2_B370               \ [0x12] B370
    $13 constant GTZC_MPCBB2_B371               \ [0x13] B371
    $14 constant GTZC_MPCBB2_B372               \ [0x14] B372
    $15 constant GTZC_MPCBB2_B373               \ [0x15] B373
    $16 constant GTZC_MPCBB2_B374               \ [0x16] B374
    $17 constant GTZC_MPCBB2_B375               \ [0x17] B375
    $18 constant GTZC_MPCBB2_B376               \ [0x18] B376
    $19 constant GTZC_MPCBB2_B377               \ [0x19] B377
    $1a constant GTZC_MPCBB2_B378               \ [0x1a] B378
    $1b constant GTZC_MPCBB2_B379               \ [0x1b] B379
    $1c constant GTZC_MPCBB2_B380               \ [0x1c] B380
    $1d constant GTZC_MPCBB2_B381               \ [0x1d] B381
    $1e constant GTZC_MPCBB2_B382               \ [0x1e] B382
    $1f constant GTZC_MPCBB2_B383               \ [0x1f] B383
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR12_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x130
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B384               \ [0x00] B384
    $01 constant GTZC_MPCBB2_B385               \ [0x01] B385
    $02 constant GTZC_MPCBB2_B386               \ [0x02] B386
    $03 constant GTZC_MPCBB2_B387               \ [0x03] B387
    $04 constant GTZC_MPCBB2_B388               \ [0x04] B388
    $05 constant GTZC_MPCBB2_B389               \ [0x05] B389
    $06 constant GTZC_MPCBB2_B390               \ [0x06] B390
    $07 constant GTZC_MPCBB2_B391               \ [0x07] B391
    $08 constant GTZC_MPCBB2_B392               \ [0x08] B392
    $09 constant GTZC_MPCBB2_B393               \ [0x09] B393
    $0a constant GTZC_MPCBB2_B394               \ [0x0a] B394
    $0b constant GTZC_MPCBB2_B395               \ [0x0b] B395
    $0c constant GTZC_MPCBB2_B396               \ [0x0c] B396
    $0d constant GTZC_MPCBB2_B397               \ [0x0d] B397
    $0e constant GTZC_MPCBB2_B398               \ [0x0e] B398
    $0f constant GTZC_MPCBB2_B399               \ [0x0f] B399
    $10 constant GTZC_MPCBB2_B400               \ [0x10] B400
    $11 constant GTZC_MPCBB2_B401               \ [0x11] B401
    $12 constant GTZC_MPCBB2_B402               \ [0x12] B402
    $13 constant GTZC_MPCBB2_B403               \ [0x13] B403
    $14 constant GTZC_MPCBB2_B404               \ [0x14] B404
    $15 constant GTZC_MPCBB2_B405               \ [0x15] B405
    $16 constant GTZC_MPCBB2_B406               \ [0x16] B406
    $17 constant GTZC_MPCBB2_B407               \ [0x17] B407
    $18 constant GTZC_MPCBB2_B408               \ [0x18] B408
    $19 constant GTZC_MPCBB2_B409               \ [0x19] B409
    $1a constant GTZC_MPCBB2_B410               \ [0x1a] B410
    $1b constant GTZC_MPCBB2_B411               \ [0x1b] B411
    $1c constant GTZC_MPCBB2_B412               \ [0x1c] B412
    $1d constant GTZC_MPCBB2_B413               \ [0x1d] B413
    $1e constant GTZC_MPCBB2_B414               \ [0x1e] B414
    $1f constant GTZC_MPCBB2_B415               \ [0x1f] B415
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR13_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x134
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B416               \ [0x00] B416
    $01 constant GTZC_MPCBB2_B417               \ [0x01] B417
    $02 constant GTZC_MPCBB2_B418               \ [0x02] B418
    $03 constant GTZC_MPCBB2_B419               \ [0x03] B419
    $04 constant GTZC_MPCBB2_B420               \ [0x04] B420
    $05 constant GTZC_MPCBB2_B421               \ [0x05] B421
    $06 constant GTZC_MPCBB2_B422               \ [0x06] B422
    $07 constant GTZC_MPCBB2_B423               \ [0x07] B423
    $08 constant GTZC_MPCBB2_B424               \ [0x08] B424
    $09 constant GTZC_MPCBB2_B425               \ [0x09] B425
    $0a constant GTZC_MPCBB2_B426               \ [0x0a] B426
    $0b constant GTZC_MPCBB2_B427               \ [0x0b] B427
    $0c constant GTZC_MPCBB2_B428               \ [0x0c] B428
    $0d constant GTZC_MPCBB2_B429               \ [0x0d] B429
    $0e constant GTZC_MPCBB2_B430               \ [0x0e] B430
    $0f constant GTZC_MPCBB2_B431               \ [0x0f] B431
    $10 constant GTZC_MPCBB2_B432               \ [0x10] B432
    $11 constant GTZC_MPCBB2_B433               \ [0x11] B433
    $12 constant GTZC_MPCBB2_B434               \ [0x12] B434
    $13 constant GTZC_MPCBB2_B435               \ [0x13] B435
    $14 constant GTZC_MPCBB2_B436               \ [0x14] B436
    $15 constant GTZC_MPCBB2_B437               \ [0x15] B437
    $16 constant GTZC_MPCBB2_B438               \ [0x16] B438
    $17 constant GTZC_MPCBB2_B439               \ [0x17] B439
    $18 constant GTZC_MPCBB2_B440               \ [0x18] B440
    $19 constant GTZC_MPCBB2_B441               \ [0x19] B441
    $1a constant GTZC_MPCBB2_B442               \ [0x1a] B442
    $1b constant GTZC_MPCBB2_B443               \ [0x1b] B443
    $1c constant GTZC_MPCBB2_B444               \ [0x1c] B444
    $1d constant GTZC_MPCBB2_B445               \ [0x1d] B445
    $1e constant GTZC_MPCBB2_B446               \ [0x1e] B446
    $1f constant GTZC_MPCBB2_B447               \ [0x1f] B447
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR14_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x138
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B448               \ [0x00] B448
    $01 constant GTZC_MPCBB2_B449               \ [0x01] B449
    $02 constant GTZC_MPCBB2_B450               \ [0x02] B450
    $03 constant GTZC_MPCBB2_B451               \ [0x03] B451
    $04 constant GTZC_MPCBB2_B452               \ [0x04] B452
    $05 constant GTZC_MPCBB2_B453               \ [0x05] B453
    $06 constant GTZC_MPCBB2_B454               \ [0x06] B454
    $07 constant GTZC_MPCBB2_B455               \ [0x07] B455
    $08 constant GTZC_MPCBB2_B456               \ [0x08] B456
    $09 constant GTZC_MPCBB2_B457               \ [0x09] B457
    $0a constant GTZC_MPCBB2_B458               \ [0x0a] B458
    $0b constant GTZC_MPCBB2_B459               \ [0x0b] B459
    $0c constant GTZC_MPCBB2_B460               \ [0x0c] B460
    $0d constant GTZC_MPCBB2_B461               \ [0x0d] B461
    $0e constant GTZC_MPCBB2_B462               \ [0x0e] B462
    $0f constant GTZC_MPCBB2_B463               \ [0x0f] B463
    $10 constant GTZC_MPCBB2_B464               \ [0x10] B464
    $11 constant GTZC_MPCBB2_B465               \ [0x11] B465
    $12 constant GTZC_MPCBB2_B466               \ [0x12] B466
    $13 constant GTZC_MPCBB2_B467               \ [0x13] B467
    $14 constant GTZC_MPCBB2_B468               \ [0x14] B468
    $15 constant GTZC_MPCBB2_B469               \ [0x15] B469
    $16 constant GTZC_MPCBB2_B470               \ [0x16] B470
    $17 constant GTZC_MPCBB2_B471               \ [0x17] B471
    $18 constant GTZC_MPCBB2_B472               \ [0x18] B472
    $19 constant GTZC_MPCBB2_B473               \ [0x19] B473
    $1a constant GTZC_MPCBB2_B474               \ [0x1a] B474
    $1b constant GTZC_MPCBB2_B475               \ [0x1b] B475
    $1c constant GTZC_MPCBB2_B476               \ [0x1c] B476
    $1d constant GTZC_MPCBB2_B477               \ [0x1d] B477
    $1e constant GTZC_MPCBB2_B478               \ [0x1e] B478
    $1f constant GTZC_MPCBB2_B479               \ [0x1f] B479
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR15_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x13C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B480               \ [0x00] B480
    $01 constant GTZC_MPCBB2_B481               \ [0x01] B481
    $02 constant GTZC_MPCBB2_B482               \ [0x02] B482
    $03 constant GTZC_MPCBB2_B483               \ [0x03] B483
    $04 constant GTZC_MPCBB2_B484               \ [0x04] B484
    $05 constant GTZC_MPCBB2_B485               \ [0x05] B485
    $06 constant GTZC_MPCBB2_B486               \ [0x06] B486
    $07 constant GTZC_MPCBB2_B487               \ [0x07] B487
    $08 constant GTZC_MPCBB2_B488               \ [0x08] B488
    $09 constant GTZC_MPCBB2_B489               \ [0x09] B489
    $0a constant GTZC_MPCBB2_B490               \ [0x0a] B490
    $0b constant GTZC_MPCBB2_B491               \ [0x0b] B491
    $0c constant GTZC_MPCBB2_B492               \ [0x0c] B492
    $0d constant GTZC_MPCBB2_B493               \ [0x0d] B493
    $0e constant GTZC_MPCBB2_B494               \ [0x0e] B494
    $0f constant GTZC_MPCBB2_B495               \ [0x0f] B495
    $10 constant GTZC_MPCBB2_B496               \ [0x10] B496
    $11 constant GTZC_MPCBB2_B497               \ [0x11] B497
    $12 constant GTZC_MPCBB2_B498               \ [0x12] B498
    $13 constant GTZC_MPCBB2_B499               \ [0x13] B499
    $14 constant GTZC_MPCBB2_B500               \ [0x14] B500
    $15 constant GTZC_MPCBB2_B501               \ [0x15] B501
    $16 constant GTZC_MPCBB2_B502               \ [0x16] B502
    $17 constant GTZC_MPCBB2_B503               \ [0x17] B503
    $18 constant GTZC_MPCBB2_B504               \ [0x18] B504
    $19 constant GTZC_MPCBB2_B505               \ [0x19] B505
    $1a constant GTZC_MPCBB2_B506               \ [0x1a] B506
    $1b constant GTZC_MPCBB2_B507               \ [0x1b] B507
    $1c constant GTZC_MPCBB2_B508               \ [0x1c] B508
    $1d constant GTZC_MPCBB2_B509               \ [0x1d] B509
    $1e constant GTZC_MPCBB2_B510               \ [0x1e] B510
    $1f constant GTZC_MPCBB2_B511               \ [0x1f] B511
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR16_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x140
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B512               \ [0x00] B512
    $01 constant GTZC_MPCBB2_B513               \ [0x01] B513
    $02 constant GTZC_MPCBB2_B514               \ [0x02] B514
    $03 constant GTZC_MPCBB2_B515               \ [0x03] B515
    $04 constant GTZC_MPCBB2_B516               \ [0x04] B516
    $05 constant GTZC_MPCBB2_B517               \ [0x05] B517
    $06 constant GTZC_MPCBB2_B518               \ [0x06] B518
    $07 constant GTZC_MPCBB2_B519               \ [0x07] B519
    $08 constant GTZC_MPCBB2_B520               \ [0x08] B520
    $09 constant GTZC_MPCBB2_B521               \ [0x09] B521
    $0a constant GTZC_MPCBB2_B522               \ [0x0a] B522
    $0b constant GTZC_MPCBB2_B523               \ [0x0b] B523
    $0c constant GTZC_MPCBB2_B524               \ [0x0c] B524
    $0d constant GTZC_MPCBB2_B525               \ [0x0d] B525
    $0e constant GTZC_MPCBB2_B526               \ [0x0e] B526
    $0f constant GTZC_MPCBB2_B527               \ [0x0f] B527
    $10 constant GTZC_MPCBB2_B528               \ [0x10] B528
    $11 constant GTZC_MPCBB2_B529               \ [0x11] B529
    $12 constant GTZC_MPCBB2_B530               \ [0x12] B530
    $13 constant GTZC_MPCBB2_B531               \ [0x13] B531
    $14 constant GTZC_MPCBB2_B532               \ [0x14] B532
    $15 constant GTZC_MPCBB2_B533               \ [0x15] B533
    $16 constant GTZC_MPCBB2_B534               \ [0x16] B534
    $17 constant GTZC_MPCBB2_B535               \ [0x17] B535
    $18 constant GTZC_MPCBB2_B536               \ [0x18] B536
    $19 constant GTZC_MPCBB2_B537               \ [0x19] B537
    $1a constant GTZC_MPCBB2_B538               \ [0x1a] B538
    $1b constant GTZC_MPCBB2_B539               \ [0x1b] B539
    $1c constant GTZC_MPCBB2_B540               \ [0x1c] B540
    $1d constant GTZC_MPCBB2_B541               \ [0x1d] B541
    $1e constant GTZC_MPCBB2_B542               \ [0x1e] B542
    $1f constant GTZC_MPCBB2_B543               \ [0x1f] B543
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR17_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x144
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B544               \ [0x00] B544
    $01 constant GTZC_MPCBB2_B545               \ [0x01] B545
    $02 constant GTZC_MPCBB2_B546               \ [0x02] B546
    $03 constant GTZC_MPCBB2_B547               \ [0x03] B547
    $04 constant GTZC_MPCBB2_B548               \ [0x04] B548
    $05 constant GTZC_MPCBB2_B549               \ [0x05] B549
    $06 constant GTZC_MPCBB2_B550               \ [0x06] B550
    $07 constant GTZC_MPCBB2_B551               \ [0x07] B551
    $08 constant GTZC_MPCBB2_B552               \ [0x08] B552
    $09 constant GTZC_MPCBB2_B553               \ [0x09] B553
    $0a constant GTZC_MPCBB2_B554               \ [0x0a] B554
    $0b constant GTZC_MPCBB2_B555               \ [0x0b] B555
    $0c constant GTZC_MPCBB2_B556               \ [0x0c] B556
    $0d constant GTZC_MPCBB2_B557               \ [0x0d] B557
    $0e constant GTZC_MPCBB2_B558               \ [0x0e] B558
    $0f constant GTZC_MPCBB2_B559               \ [0x0f] B559
    $10 constant GTZC_MPCBB2_B560               \ [0x10] B560
    $11 constant GTZC_MPCBB2_B561               \ [0x11] B561
    $12 constant GTZC_MPCBB2_B562               \ [0x12] B562
    $13 constant GTZC_MPCBB2_B563               \ [0x13] B563
    $14 constant GTZC_MPCBB2_B564               \ [0x14] B564
    $15 constant GTZC_MPCBB2_B565               \ [0x15] B565
    $16 constant GTZC_MPCBB2_B566               \ [0x16] B566
    $17 constant GTZC_MPCBB2_B567               \ [0x17] B567
    $18 constant GTZC_MPCBB2_B568               \ [0x18] B568
    $19 constant GTZC_MPCBB2_B569               \ [0x19] B569
    $1a constant GTZC_MPCBB2_B570               \ [0x1a] B570
    $1b constant GTZC_MPCBB2_B571               \ [0x1b] B571
    $1c constant GTZC_MPCBB2_B572               \ [0x1c] B572
    $1d constant GTZC_MPCBB2_B573               \ [0x1d] B573
    $1e constant GTZC_MPCBB2_B574               \ [0x1e] B574
    $1f constant GTZC_MPCBB2_B575               \ [0x1f] B575
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR18_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x148
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B576               \ [0x00] B576
    $01 constant GTZC_MPCBB2_B577               \ [0x01] B577
    $02 constant GTZC_MPCBB2_B578               \ [0x02] B578
    $03 constant GTZC_MPCBB2_B579               \ [0x03] B579
    $04 constant GTZC_MPCBB2_B580               \ [0x04] B580
    $05 constant GTZC_MPCBB2_B581               \ [0x05] B581
    $06 constant GTZC_MPCBB2_B582               \ [0x06] B582
    $07 constant GTZC_MPCBB2_B583               \ [0x07] B583
    $08 constant GTZC_MPCBB2_B584               \ [0x08] B584
    $09 constant GTZC_MPCBB2_B585               \ [0x09] B585
    $0a constant GTZC_MPCBB2_B586               \ [0x0a] B586
    $0b constant GTZC_MPCBB2_B587               \ [0x0b] B587
    $0c constant GTZC_MPCBB2_B588               \ [0x0c] B588
    $0d constant GTZC_MPCBB2_B589               \ [0x0d] B589
    $0e constant GTZC_MPCBB2_B590               \ [0x0e] B590
    $0f constant GTZC_MPCBB2_B591               \ [0x0f] B591
    $10 constant GTZC_MPCBB2_B592               \ [0x10] B592
    $11 constant GTZC_MPCBB2_B593               \ [0x11] B593
    $12 constant GTZC_MPCBB2_B594               \ [0x12] B594
    $13 constant GTZC_MPCBB2_B595               \ [0x13] B595
    $14 constant GTZC_MPCBB2_B596               \ [0x14] B596
    $15 constant GTZC_MPCBB2_B597               \ [0x15] B597
    $16 constant GTZC_MPCBB2_B598               \ [0x16] B598
    $17 constant GTZC_MPCBB2_B599               \ [0x17] B599
    $18 constant GTZC_MPCBB2_B600               \ [0x18] B600
    $19 constant GTZC_MPCBB2_B601               \ [0x19] B601
    $1a constant GTZC_MPCBB2_B602               \ [0x1a] B602
    $1b constant GTZC_MPCBB2_B603               \ [0x1b] B603
    $1c constant GTZC_MPCBB2_B604               \ [0x1c] B604
    $1d constant GTZC_MPCBB2_B605               \ [0x1d] B605
    $1e constant GTZC_MPCBB2_B606               \ [0x1e] B606
    $1f constant GTZC_MPCBB2_B607               \ [0x1f] B607
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR19_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x14C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B608               \ [0x00] B608
    $01 constant GTZC_MPCBB2_B609               \ [0x01] B609
    $02 constant GTZC_MPCBB2_B610               \ [0x02] B610
    $03 constant GTZC_MPCBB2_B611               \ [0x03] B611
    $04 constant GTZC_MPCBB2_B612               \ [0x04] B612
    $05 constant GTZC_MPCBB2_B613               \ [0x05] B613
    $06 constant GTZC_MPCBB2_B614               \ [0x06] B614
    $07 constant GTZC_MPCBB2_B615               \ [0x07] B615
    $08 constant GTZC_MPCBB2_B616               \ [0x08] B616
    $09 constant GTZC_MPCBB2_B617               \ [0x09] B617
    $0a constant GTZC_MPCBB2_B618               \ [0x0a] B618
    $0b constant GTZC_MPCBB2_B619               \ [0x0b] B619
    $0c constant GTZC_MPCBB2_B620               \ [0x0c] B620
    $0d constant GTZC_MPCBB2_B621               \ [0x0d] B621
    $0e constant GTZC_MPCBB2_B622               \ [0x0e] B622
    $0f constant GTZC_MPCBB2_B623               \ [0x0f] B623
    $10 constant GTZC_MPCBB2_B624               \ [0x10] B624
    $11 constant GTZC_MPCBB2_B625               \ [0x11] B625
    $12 constant GTZC_MPCBB2_B626               \ [0x12] B626
    $13 constant GTZC_MPCBB2_B627               \ [0x13] B627
    $14 constant GTZC_MPCBB2_B628               \ [0x14] B628
    $15 constant GTZC_MPCBB2_B629               \ [0x15] B629
    $16 constant GTZC_MPCBB2_B630               \ [0x16] B630
    $17 constant GTZC_MPCBB2_B631               \ [0x17] B631
    $18 constant GTZC_MPCBB2_B632               \ [0x18] B632
    $19 constant GTZC_MPCBB2_B633               \ [0x19] B633
    $1a constant GTZC_MPCBB2_B634               \ [0x1a] B634
    $1b constant GTZC_MPCBB2_B635               \ [0x1b] B635
    $1c constant GTZC_MPCBB2_B636               \ [0x1c] B636
    $1d constant GTZC_MPCBB2_B637               \ [0x1d] B637
    $1e constant GTZC_MPCBB2_B638               \ [0x1e] B638
    $1f constant GTZC_MPCBB2_B639               \ [0x1f] B639
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR20_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x150
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B640               \ [0x00] B640
    $01 constant GTZC_MPCBB2_B641               \ [0x01] B641
    $02 constant GTZC_MPCBB2_B642               \ [0x02] B642
    $03 constant GTZC_MPCBB2_B643               \ [0x03] B643
    $04 constant GTZC_MPCBB2_B644               \ [0x04] B644
    $05 constant GTZC_MPCBB2_B645               \ [0x05] B645
    $06 constant GTZC_MPCBB2_B646               \ [0x06] B646
    $07 constant GTZC_MPCBB2_B647               \ [0x07] B647
    $08 constant GTZC_MPCBB2_B648               \ [0x08] B648
    $09 constant GTZC_MPCBB2_B649               \ [0x09] B649
    $0a constant GTZC_MPCBB2_B650               \ [0x0a] B650
    $0b constant GTZC_MPCBB2_B651               \ [0x0b] B651
    $0c constant GTZC_MPCBB2_B652               \ [0x0c] B652
    $0d constant GTZC_MPCBB2_B653               \ [0x0d] B653
    $0e constant GTZC_MPCBB2_B654               \ [0x0e] B654
    $0f constant GTZC_MPCBB2_B655               \ [0x0f] B655
    $10 constant GTZC_MPCBB2_B656               \ [0x10] B656
    $11 constant GTZC_MPCBB2_B657               \ [0x11] B657
    $12 constant GTZC_MPCBB2_B658               \ [0x12] B658
    $13 constant GTZC_MPCBB2_B659               \ [0x13] B659
    $14 constant GTZC_MPCBB2_B660               \ [0x14] B660
    $15 constant GTZC_MPCBB2_B661               \ [0x15] B661
    $16 constant GTZC_MPCBB2_B662               \ [0x16] B662
    $17 constant GTZC_MPCBB2_B663               \ [0x17] B663
    $18 constant GTZC_MPCBB2_B664               \ [0x18] B664
    $19 constant GTZC_MPCBB2_B665               \ [0x19] B665
    $1a constant GTZC_MPCBB2_B666               \ [0x1a] B666
    $1b constant GTZC_MPCBB2_B667               \ [0x1b] B667
    $1c constant GTZC_MPCBB2_B668               \ [0x1c] B668
    $1d constant GTZC_MPCBB2_B669               \ [0x1d] B669
    $1e constant GTZC_MPCBB2_B670               \ [0x1e] B670
    $1f constant GTZC_MPCBB2_B671               \ [0x1f] B671
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR21_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x154
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B672               \ [0x00] B672
    $01 constant GTZC_MPCBB2_B673               \ [0x01] B673
    $02 constant GTZC_MPCBB2_B674               \ [0x02] B674
    $03 constant GTZC_MPCBB2_B675               \ [0x03] B675
    $04 constant GTZC_MPCBB2_B676               \ [0x04] B676
    $05 constant GTZC_MPCBB2_B677               \ [0x05] B677
    $06 constant GTZC_MPCBB2_B678               \ [0x06] B678
    $07 constant GTZC_MPCBB2_B679               \ [0x07] B679
    $08 constant GTZC_MPCBB2_B680               \ [0x08] B680
    $09 constant GTZC_MPCBB2_B681               \ [0x09] B681
    $0a constant GTZC_MPCBB2_B682               \ [0x0a] B682
    $0b constant GTZC_MPCBB2_B683               \ [0x0b] B683
    $0c constant GTZC_MPCBB2_B684               \ [0x0c] B684
    $0d constant GTZC_MPCBB2_B685               \ [0x0d] B685
    $0e constant GTZC_MPCBB2_B686               \ [0x0e] B686
    $0f constant GTZC_MPCBB2_B687               \ [0x0f] B687
    $10 constant GTZC_MPCBB2_B688               \ [0x10] B688
    $11 constant GTZC_MPCBB2_B689               \ [0x11] B689
    $12 constant GTZC_MPCBB2_B690               \ [0x12] B690
    $13 constant GTZC_MPCBB2_B691               \ [0x13] B691
    $14 constant GTZC_MPCBB2_B692               \ [0x14] B692
    $15 constant GTZC_MPCBB2_B693               \ [0x15] B693
    $16 constant GTZC_MPCBB2_B694               \ [0x16] B694
    $17 constant GTZC_MPCBB2_B695               \ [0x17] B695
    $18 constant GTZC_MPCBB2_B696               \ [0x18] B696
    $19 constant GTZC_MPCBB2_B697               \ [0x19] B697
    $1a constant GTZC_MPCBB2_B698               \ [0x1a] B698
    $1b constant GTZC_MPCBB2_B699               \ [0x1b] B699
    $1c constant GTZC_MPCBB2_B700               \ [0x1c] B700
    $1d constant GTZC_MPCBB2_B701               \ [0x1d] B701
    $1e constant GTZC_MPCBB2_B702               \ [0x1e] B702
    $1f constant GTZC_MPCBB2_B703               \ [0x1f] B703
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR22_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x158
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B704               \ [0x00] B704
    $01 constant GTZC_MPCBB2_B705               \ [0x01] B705
    $02 constant GTZC_MPCBB2_B706               \ [0x02] B706
    $03 constant GTZC_MPCBB2_B707               \ [0x03] B707
    $04 constant GTZC_MPCBB2_B708               \ [0x04] B708
    $05 constant GTZC_MPCBB2_B709               \ [0x05] B709
    $06 constant GTZC_MPCBB2_B710               \ [0x06] B710
    $07 constant GTZC_MPCBB2_B711               \ [0x07] B711
    $08 constant GTZC_MPCBB2_B712               \ [0x08] B712
    $09 constant GTZC_MPCBB2_B713               \ [0x09] B713
    $0a constant GTZC_MPCBB2_B714               \ [0x0a] B714
    $0b constant GTZC_MPCBB2_B715               \ [0x0b] B715
    $0c constant GTZC_MPCBB2_B716               \ [0x0c] B716
    $0d constant GTZC_MPCBB2_B717               \ [0x0d] B717
    $0e constant GTZC_MPCBB2_B718               \ [0x0e] B718
    $0f constant GTZC_MPCBB2_B719               \ [0x0f] B719
    $10 constant GTZC_MPCBB2_B720               \ [0x10] B720
    $11 constant GTZC_MPCBB2_B721               \ [0x11] B721
    $12 constant GTZC_MPCBB2_B722               \ [0x12] B722
    $13 constant GTZC_MPCBB2_B723               \ [0x13] B723
    $14 constant GTZC_MPCBB2_B724               \ [0x14] B724
    $15 constant GTZC_MPCBB2_B725               \ [0x15] B725
    $16 constant GTZC_MPCBB2_B726               \ [0x16] B726
    $17 constant GTZC_MPCBB2_B727               \ [0x17] B727
    $18 constant GTZC_MPCBB2_B728               \ [0x18] B728
    $19 constant GTZC_MPCBB2_B729               \ [0x19] B729
    $1a constant GTZC_MPCBB2_B730               \ [0x1a] B730
    $1b constant GTZC_MPCBB2_B731               \ [0x1b] B731
    $1c constant GTZC_MPCBB2_B732               \ [0x1c] B732
    $1d constant GTZC_MPCBB2_B733               \ [0x1d] B733
    $1e constant GTZC_MPCBB2_B734               \ [0x1e] B734
    $1f constant GTZC_MPCBB2_B735               \ [0x1f] B735
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR23_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x15C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B736               \ [0x00] B736
    $01 constant GTZC_MPCBB2_B737               \ [0x01] B737
    $02 constant GTZC_MPCBB2_B738               \ [0x02] B738
    $03 constant GTZC_MPCBB2_B739               \ [0x03] B739
    $04 constant GTZC_MPCBB2_B740               \ [0x04] B740
    $05 constant GTZC_MPCBB2_B741               \ [0x05] B741
    $06 constant GTZC_MPCBB2_B742               \ [0x06] B742
    $07 constant GTZC_MPCBB2_B743               \ [0x07] B743
    $08 constant GTZC_MPCBB2_B744               \ [0x08] B744
    $09 constant GTZC_MPCBB2_B745               \ [0x09] B745
    $0a constant GTZC_MPCBB2_B746               \ [0x0a] B746
    $0b constant GTZC_MPCBB2_B747               \ [0x0b] B747
    $0c constant GTZC_MPCBB2_B748               \ [0x0c] B748
    $0d constant GTZC_MPCBB2_B749               \ [0x0d] B749
    $0e constant GTZC_MPCBB2_B750               \ [0x0e] B750
    $0f constant GTZC_MPCBB2_B751               \ [0x0f] B751
    $10 constant GTZC_MPCBB2_B752               \ [0x10] B752
    $11 constant GTZC_MPCBB2_B753               \ [0x11] B753
    $12 constant GTZC_MPCBB2_B754               \ [0x12] B754
    $13 constant GTZC_MPCBB2_B755               \ [0x13] B755
    $14 constant GTZC_MPCBB2_B756               \ [0x14] B756
    $15 constant GTZC_MPCBB2_B757               \ [0x15] B757
    $16 constant GTZC_MPCBB2_B758               \ [0x16] B758
    $17 constant GTZC_MPCBB2_B759               \ [0x17] B759
    $18 constant GTZC_MPCBB2_B760               \ [0x18] B760
    $19 constant GTZC_MPCBB2_B761               \ [0x19] B761
    $1a constant GTZC_MPCBB2_B762               \ [0x1a] B762
    $1b constant GTZC_MPCBB2_B763               \ [0x1b] B763
    $1c constant GTZC_MPCBB2_B764               \ [0x1c] B764
    $1d constant GTZC_MPCBB2_B765               \ [0x1d] B765
    $1e constant GTZC_MPCBB2_B766               \ [0x1e] B766
    $1f constant GTZC_MPCBB2_B767               \ [0x1f] B767
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR24_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x160
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B768               \ [0x00] B768
    $01 constant GTZC_MPCBB2_B769               \ [0x01] B769
    $02 constant GTZC_MPCBB2_B770               \ [0x02] B770
    $03 constant GTZC_MPCBB2_B771               \ [0x03] B771
    $04 constant GTZC_MPCBB2_B772               \ [0x04] B772
    $05 constant GTZC_MPCBB2_B773               \ [0x05] B773
    $06 constant GTZC_MPCBB2_B774               \ [0x06] B774
    $07 constant GTZC_MPCBB2_B775               \ [0x07] B775
    $08 constant GTZC_MPCBB2_B776               \ [0x08] B776
    $09 constant GTZC_MPCBB2_B777               \ [0x09] B777
    $0a constant GTZC_MPCBB2_B778               \ [0x0a] B778
    $0b constant GTZC_MPCBB2_B779               \ [0x0b] B779
    $0c constant GTZC_MPCBB2_B780               \ [0x0c] B780
    $0d constant GTZC_MPCBB2_B781               \ [0x0d] B781
    $0e constant GTZC_MPCBB2_B782               \ [0x0e] B782
    $0f constant GTZC_MPCBB2_B783               \ [0x0f] B783
    $10 constant GTZC_MPCBB2_B784               \ [0x10] B784
    $11 constant GTZC_MPCBB2_B785               \ [0x11] B785
    $12 constant GTZC_MPCBB2_B786               \ [0x12] B786
    $13 constant GTZC_MPCBB2_B787               \ [0x13] B787
    $14 constant GTZC_MPCBB2_B788               \ [0x14] B788
    $15 constant GTZC_MPCBB2_B789               \ [0x15] B789
    $16 constant GTZC_MPCBB2_B790               \ [0x16] B790
    $17 constant GTZC_MPCBB2_B791               \ [0x17] B791
    $18 constant GTZC_MPCBB2_B792               \ [0x18] B792
    $19 constant GTZC_MPCBB2_B793               \ [0x19] B793
    $1a constant GTZC_MPCBB2_B794               \ [0x1a] B794
    $1b constant GTZC_MPCBB2_B795               \ [0x1b] B795
    $1c constant GTZC_MPCBB2_B796               \ [0x1c] B796
    $1d constant GTZC_MPCBB2_B797               \ [0x1d] B797
    $1e constant GTZC_MPCBB2_B798               \ [0x1e] B798
    $1f constant GTZC_MPCBB2_B799               \ [0x1f] B799
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR25_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x164
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B800               \ [0x00] B800
    $01 constant GTZC_MPCBB2_B801               \ [0x01] B801
    $02 constant GTZC_MPCBB2_B802               \ [0x02] B802
    $03 constant GTZC_MPCBB2_B803               \ [0x03] B803
    $04 constant GTZC_MPCBB2_B804               \ [0x04] B804
    $05 constant GTZC_MPCBB2_B805               \ [0x05] B805
    $06 constant GTZC_MPCBB2_B806               \ [0x06] B806
    $07 constant GTZC_MPCBB2_B807               \ [0x07] B807
    $08 constant GTZC_MPCBB2_B808               \ [0x08] B808
    $09 constant GTZC_MPCBB2_B809               \ [0x09] B809
    $0a constant GTZC_MPCBB2_B810               \ [0x0a] B810
    $0b constant GTZC_MPCBB2_B811               \ [0x0b] B811
    $0c constant GTZC_MPCBB2_B812               \ [0x0c] B812
    $0d constant GTZC_MPCBB2_B813               \ [0x0d] B813
    $0e constant GTZC_MPCBB2_B814               \ [0x0e] B814
    $0f constant GTZC_MPCBB2_B815               \ [0x0f] B815
    $10 constant GTZC_MPCBB2_B816               \ [0x10] B816
    $11 constant GTZC_MPCBB2_B817               \ [0x11] B817
    $12 constant GTZC_MPCBB2_B818               \ [0x12] B818
    $13 constant GTZC_MPCBB2_B819               \ [0x13] B819
    $14 constant GTZC_MPCBB2_B820               \ [0x14] B820
    $15 constant GTZC_MPCBB2_B821               \ [0x15] B821
    $16 constant GTZC_MPCBB2_B822               \ [0x16] B822
    $17 constant GTZC_MPCBB2_B823               \ [0x17] B823
    $18 constant GTZC_MPCBB2_B824               \ [0x18] B824
    $19 constant GTZC_MPCBB2_B825               \ [0x19] B825
    $1a constant GTZC_MPCBB2_B826               \ [0x1a] B826
    $1b constant GTZC_MPCBB2_B827               \ [0x1b] B827
    $1c constant GTZC_MPCBB2_B828               \ [0x1c] B828
    $1d constant GTZC_MPCBB2_B829               \ [0x1d] B829
    $1e constant GTZC_MPCBB2_B830               \ [0x1e] B830
    $1f constant GTZC_MPCBB2_B831               \ [0x1f] B831
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR26_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x168
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B832               \ [0x00] B832
    $01 constant GTZC_MPCBB2_B833               \ [0x01] B833
    $02 constant GTZC_MPCBB2_B834               \ [0x02] B834
    $03 constant GTZC_MPCBB2_B835               \ [0x03] B835
    $04 constant GTZC_MPCBB2_B836               \ [0x04] B836
    $05 constant GTZC_MPCBB2_B837               \ [0x05] B837
    $06 constant GTZC_MPCBB2_B838               \ [0x06] B838
    $07 constant GTZC_MPCBB2_B839               \ [0x07] B839
    $08 constant GTZC_MPCBB2_B840               \ [0x08] B840
    $09 constant GTZC_MPCBB2_B841               \ [0x09] B841
    $0a constant GTZC_MPCBB2_B842               \ [0x0a] B842
    $0b constant GTZC_MPCBB2_B843               \ [0x0b] B843
    $0c constant GTZC_MPCBB2_B844               \ [0x0c] B844
    $0d constant GTZC_MPCBB2_B845               \ [0x0d] B845
    $0e constant GTZC_MPCBB2_B846               \ [0x0e] B846
    $0f constant GTZC_MPCBB2_B847               \ [0x0f] B847
    $10 constant GTZC_MPCBB2_B848               \ [0x10] B848
    $11 constant GTZC_MPCBB2_B849               \ [0x11] B849
    $12 constant GTZC_MPCBB2_B850               \ [0x12] B850
    $13 constant GTZC_MPCBB2_B851               \ [0x13] B851
    $14 constant GTZC_MPCBB2_B852               \ [0x14] B852
    $15 constant GTZC_MPCBB2_B853               \ [0x15] B853
    $16 constant GTZC_MPCBB2_B854               \ [0x16] B854
    $17 constant GTZC_MPCBB2_B855               \ [0x17] B855
    $18 constant GTZC_MPCBB2_B856               \ [0x18] B856
    $19 constant GTZC_MPCBB2_B857               \ [0x19] B857
    $1a constant GTZC_MPCBB2_B858               \ [0x1a] B858
    $1b constant GTZC_MPCBB2_B859               \ [0x1b] B859
    $1c constant GTZC_MPCBB2_B860               \ [0x1c] B860
    $1d constant GTZC_MPCBB2_B861               \ [0x1d] B861
    $1e constant GTZC_MPCBB2_B862               \ [0x1e] B862
    $1f constant GTZC_MPCBB2_B863               \ [0x1f] B863
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR27_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x16C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B864               \ [0x00] B864
    $01 constant GTZC_MPCBB2_B865               \ [0x01] B865
    $02 constant GTZC_MPCBB2_B866               \ [0x02] B866
    $03 constant GTZC_MPCBB2_B867               \ [0x03] B867
    $04 constant GTZC_MPCBB2_B868               \ [0x04] B868
    $05 constant GTZC_MPCBB2_B869               \ [0x05] B869
    $06 constant GTZC_MPCBB2_B870               \ [0x06] B870
    $07 constant GTZC_MPCBB2_B871               \ [0x07] B871
    $08 constant GTZC_MPCBB2_B872               \ [0x08] B872
    $09 constant GTZC_MPCBB2_B873               \ [0x09] B873
    $0a constant GTZC_MPCBB2_B874               \ [0x0a] B874
    $0b constant GTZC_MPCBB2_B875               \ [0x0b] B875
    $0c constant GTZC_MPCBB2_B876               \ [0x0c] B876
    $0d constant GTZC_MPCBB2_B877               \ [0x0d] B877
    $0e constant GTZC_MPCBB2_B878               \ [0x0e] B878
    $0f constant GTZC_MPCBB2_B879               \ [0x0f] B879
    $10 constant GTZC_MPCBB2_B880               \ [0x10] B880
    $11 constant GTZC_MPCBB2_B881               \ [0x11] B881
    $12 constant GTZC_MPCBB2_B882               \ [0x12] B882
    $13 constant GTZC_MPCBB2_B883               \ [0x13] B883
    $14 constant GTZC_MPCBB2_B884               \ [0x14] B884
    $15 constant GTZC_MPCBB2_B885               \ [0x15] B885
    $16 constant GTZC_MPCBB2_B886               \ [0x16] B886
    $17 constant GTZC_MPCBB2_B887               \ [0x17] B887
    $18 constant GTZC_MPCBB2_B888               \ [0x18] B888
    $19 constant GTZC_MPCBB2_B889               \ [0x19] B889
    $1a constant GTZC_MPCBB2_B890               \ [0x1a] B890
    $1b constant GTZC_MPCBB2_B891               \ [0x1b] B891
    $1c constant GTZC_MPCBB2_B892               \ [0x1c] B892
    $1d constant GTZC_MPCBB2_B893               \ [0x1d] B893
    $1e constant GTZC_MPCBB2_B894               \ [0x1e] B894
    $1f constant GTZC_MPCBB2_B895               \ [0x1f] B895
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR28_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x170
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B896               \ [0x00] B896
    $01 constant GTZC_MPCBB2_B897               \ [0x01] B897
    $02 constant GTZC_MPCBB2_B898               \ [0x02] B898
    $03 constant GTZC_MPCBB2_B899               \ [0x03] B899
    $04 constant GTZC_MPCBB2_B900               \ [0x04] B900
    $05 constant GTZC_MPCBB2_B901               \ [0x05] B901
    $06 constant GTZC_MPCBB2_B902               \ [0x06] B902
    $07 constant GTZC_MPCBB2_B903               \ [0x07] B903
    $08 constant GTZC_MPCBB2_B904               \ [0x08] B904
    $09 constant GTZC_MPCBB2_B905               \ [0x09] B905
    $0a constant GTZC_MPCBB2_B906               \ [0x0a] B906
    $0b constant GTZC_MPCBB2_B907               \ [0x0b] B907
    $0c constant GTZC_MPCBB2_B908               \ [0x0c] B908
    $0d constant GTZC_MPCBB2_B909               \ [0x0d] B909
    $0e constant GTZC_MPCBB2_B910               \ [0x0e] B910
    $0f constant GTZC_MPCBB2_B911               \ [0x0f] B911
    $10 constant GTZC_MPCBB2_B912               \ [0x10] B912
    $11 constant GTZC_MPCBB2_B913               \ [0x11] B913
    $12 constant GTZC_MPCBB2_B914               \ [0x12] B914
    $13 constant GTZC_MPCBB2_B915               \ [0x13] B915
    $14 constant GTZC_MPCBB2_B916               \ [0x14] B916
    $15 constant GTZC_MPCBB2_B917               \ [0x15] B917
    $16 constant GTZC_MPCBB2_B918               \ [0x16] B918
    $17 constant GTZC_MPCBB2_B919               \ [0x17] B919
    $18 constant GTZC_MPCBB2_B920               \ [0x18] B920
    $19 constant GTZC_MPCBB2_B921               \ [0x19] B921
    $1a constant GTZC_MPCBB2_B922               \ [0x1a] B922
    $1b constant GTZC_MPCBB2_B923               \ [0x1b] B923
    $1c constant GTZC_MPCBB2_B924               \ [0x1c] B924
    $1d constant GTZC_MPCBB2_B925               \ [0x1d] B925
    $1e constant GTZC_MPCBB2_B926               \ [0x1e] B926
    $1f constant GTZC_MPCBB2_B927               \ [0x1f] B927
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR29_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x174
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B928               \ [0x00] B928
    $01 constant GTZC_MPCBB2_B929               \ [0x01] B929
    $02 constant GTZC_MPCBB2_B930               \ [0x02] B930
    $03 constant GTZC_MPCBB2_B931               \ [0x03] B931
    $04 constant GTZC_MPCBB2_B932               \ [0x04] B932
    $05 constant GTZC_MPCBB2_B933               \ [0x05] B933
    $06 constant GTZC_MPCBB2_B934               \ [0x06] B934
    $07 constant GTZC_MPCBB2_B935               \ [0x07] B935
    $08 constant GTZC_MPCBB2_B936               \ [0x08] B936
    $09 constant GTZC_MPCBB2_B937               \ [0x09] B937
    $0a constant GTZC_MPCBB2_B938               \ [0x0a] B938
    $0b constant GTZC_MPCBB2_B939               \ [0x0b] B939
    $0c constant GTZC_MPCBB2_B940               \ [0x0c] B940
    $0d constant GTZC_MPCBB2_B941               \ [0x0d] B941
    $0e constant GTZC_MPCBB2_B942               \ [0x0e] B942
    $0f constant GTZC_MPCBB2_B943               \ [0x0f] B943
    $10 constant GTZC_MPCBB2_B944               \ [0x10] B944
    $11 constant GTZC_MPCBB2_B945               \ [0x11] B945
    $12 constant GTZC_MPCBB2_B946               \ [0x12] B946
    $13 constant GTZC_MPCBB2_B947               \ [0x13] B947
    $14 constant GTZC_MPCBB2_B948               \ [0x14] B948
    $15 constant GTZC_MPCBB2_B949               \ [0x15] B949
    $16 constant GTZC_MPCBB2_B950               \ [0x16] B950
    $17 constant GTZC_MPCBB2_B951               \ [0x17] B951
    $18 constant GTZC_MPCBB2_B952               \ [0x18] B952
    $19 constant GTZC_MPCBB2_B953               \ [0x19] B953
    $1a constant GTZC_MPCBB2_B954               \ [0x1a] B954
    $1b constant GTZC_MPCBB2_B955               \ [0x1b] B955
    $1c constant GTZC_MPCBB2_B956               \ [0x1c] B956
    $1d constant GTZC_MPCBB2_B957               \ [0x1d] B957
    $1e constant GTZC_MPCBB2_B958               \ [0x1e] B958
    $1f constant GTZC_MPCBB2_B959               \ [0x1f] B959
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR30_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x178
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B960               \ [0x00] B960
    $01 constant GTZC_MPCBB2_B961               \ [0x01] B961
    $02 constant GTZC_MPCBB2_B962               \ [0x02] B962
    $03 constant GTZC_MPCBB2_B963               \ [0x03] B963
    $04 constant GTZC_MPCBB2_B964               \ [0x04] B964
    $05 constant GTZC_MPCBB2_B965               \ [0x05] B965
    $06 constant GTZC_MPCBB2_B966               \ [0x06] B966
    $07 constant GTZC_MPCBB2_B967               \ [0x07] B967
    $08 constant GTZC_MPCBB2_B968               \ [0x08] B968
    $09 constant GTZC_MPCBB2_B969               \ [0x09] B969
    $0a constant GTZC_MPCBB2_B970               \ [0x0a] B970
    $0b constant GTZC_MPCBB2_B971               \ [0x0b] B971
    $0c constant GTZC_MPCBB2_B972               \ [0x0c] B972
    $0d constant GTZC_MPCBB2_B973               \ [0x0d] B973
    $0e constant GTZC_MPCBB2_B974               \ [0x0e] B974
    $0f constant GTZC_MPCBB2_B975               \ [0x0f] B975
    $10 constant GTZC_MPCBB2_B976               \ [0x10] B976
    $11 constant GTZC_MPCBB2_B977               \ [0x11] B977
    $12 constant GTZC_MPCBB2_B978               \ [0x12] B978
    $13 constant GTZC_MPCBB2_B979               \ [0x13] B979
    $14 constant GTZC_MPCBB2_B980               \ [0x14] B980
    $15 constant GTZC_MPCBB2_B981               \ [0x15] B981
    $16 constant GTZC_MPCBB2_B982               \ [0x16] B982
    $17 constant GTZC_MPCBB2_B983               \ [0x17] B983
    $18 constant GTZC_MPCBB2_B984               \ [0x18] B984
    $19 constant GTZC_MPCBB2_B985               \ [0x19] B985
    $1a constant GTZC_MPCBB2_B986               \ [0x1a] B986
    $1b constant GTZC_MPCBB2_B987               \ [0x1b] B987
    $1c constant GTZC_MPCBB2_B988               \ [0x1c] B988
    $1d constant GTZC_MPCBB2_B989               \ [0x1d] B989
    $1e constant GTZC_MPCBB2_B990               \ [0x1e] B990
    $1f constant GTZC_MPCBB2_B991               \ [0x1f] B991
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR31_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x17C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B992               \ [0x00] B992
    $01 constant GTZC_MPCBB2_B993               \ [0x01] B993
    $02 constant GTZC_MPCBB2_B994               \ [0x02] B994
    $03 constant GTZC_MPCBB2_B995               \ [0x03] B995
    $04 constant GTZC_MPCBB2_B996               \ [0x04] B996
    $05 constant GTZC_MPCBB2_B997               \ [0x05] B997
    $06 constant GTZC_MPCBB2_B998               \ [0x06] B998
    $07 constant GTZC_MPCBB2_B999               \ [0x07] B999
    $08 constant GTZC_MPCBB2_B1000              \ [0x08] B1000
    $09 constant GTZC_MPCBB2_B1001              \ [0x09] B1001
    $0a constant GTZC_MPCBB2_B1002              \ [0x0a] B1002
    $0b constant GTZC_MPCBB2_B1003              \ [0x0b] B1003
    $0c constant GTZC_MPCBB2_B1004              \ [0x0c] B1004
    $0d constant GTZC_MPCBB2_B1005              \ [0x0d] B1005
    $0e constant GTZC_MPCBB2_B1006              \ [0x0e] B1006
    $0f constant GTZC_MPCBB2_B1007              \ [0x0f] B1007
    $10 constant GTZC_MPCBB2_B1008              \ [0x10] B1008
    $11 constant GTZC_MPCBB2_B1009              \ [0x11] B1009
    $12 constant GTZC_MPCBB2_B1010              \ [0x12] B1010
    $13 constant GTZC_MPCBB2_B1011              \ [0x13] B1011
    $14 constant GTZC_MPCBB2_B1012              \ [0x14] B1012
    $15 constant GTZC_MPCBB2_B1013              \ [0x15] B1013
    $16 constant GTZC_MPCBB2_B1014              \ [0x16] B1014
    $17 constant GTZC_MPCBB2_B1015              \ [0x17] B1015
    $18 constant GTZC_MPCBB2_B1016              \ [0x18] B1016
    $19 constant GTZC_MPCBB2_B1017              \ [0x19] B1017
    $1a constant GTZC_MPCBB2_B1018              \ [0x1a] B1018
    $1b constant GTZC_MPCBB2_B1019              \ [0x1b] B1019
    $1c constant GTZC_MPCBB2_B1020              \ [0x1c] B1020
    $1d constant GTZC_MPCBB2_B1021              \ [0x1d] B1021
    $1e constant GTZC_MPCBB2_B1022              \ [0x1e] B1022
    $1f constant GTZC_MPCBB2_B1023              \ [0x1f] B1023
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR32_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x180
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1024              \ [0x00] B1024
    $01 constant GTZC_MPCBB2_B1025              \ [0x01] B1025
    $02 constant GTZC_MPCBB2_B1026              \ [0x02] B1026
    $03 constant GTZC_MPCBB2_B1027              \ [0x03] B1027
    $04 constant GTZC_MPCBB2_B1028              \ [0x04] B1028
    $05 constant GTZC_MPCBB2_B1029              \ [0x05] B1029
    $06 constant GTZC_MPCBB2_B1030              \ [0x06] B1030
    $07 constant GTZC_MPCBB2_B1031              \ [0x07] B1031
    $08 constant GTZC_MPCBB2_B1032              \ [0x08] B1032
    $09 constant GTZC_MPCBB2_B1033              \ [0x09] B1033
    $0a constant GTZC_MPCBB2_B1034              \ [0x0a] B1034
    $0b constant GTZC_MPCBB2_B1035              \ [0x0b] B1035
    $0c constant GTZC_MPCBB2_B1036              \ [0x0c] B1036
    $0d constant GTZC_MPCBB2_B1037              \ [0x0d] B1037
    $0e constant GTZC_MPCBB2_B1038              \ [0x0e] B1038
    $0f constant GTZC_MPCBB2_B1039              \ [0x0f] B1039
    $10 constant GTZC_MPCBB2_B1040              \ [0x10] B1040
    $11 constant GTZC_MPCBB2_B1041              \ [0x11] B1041
    $12 constant GTZC_MPCBB2_B1042              \ [0x12] B1042
    $13 constant GTZC_MPCBB2_B1043              \ [0x13] B1043
    $14 constant GTZC_MPCBB2_B1044              \ [0x14] B1044
    $15 constant GTZC_MPCBB2_B1045              \ [0x15] B1045
    $16 constant GTZC_MPCBB2_B1046              \ [0x16] B1046
    $17 constant GTZC_MPCBB2_B1047              \ [0x17] B1047
    $18 constant GTZC_MPCBB2_B1048              \ [0x18] B1048
    $19 constant GTZC_MPCBB2_B1049              \ [0x19] B1049
    $1a constant GTZC_MPCBB2_B1050              \ [0x1a] B1050
    $1b constant GTZC_MPCBB2_B1051              \ [0x1b] B1051
    $1c constant GTZC_MPCBB2_B1052              \ [0x1c] B1052
    $1d constant GTZC_MPCBB2_B1053              \ [0x1d] B1053
    $1e constant GTZC_MPCBB2_B1054              \ [0x1e] B1054
    $1f constant GTZC_MPCBB2_B1055              \ [0x1f] B1055
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR33_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x184
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1056              \ [0x00] B1056
    $01 constant GTZC_MPCBB2_B1057              \ [0x01] B1057
    $02 constant GTZC_MPCBB2_B1058              \ [0x02] B1058
    $03 constant GTZC_MPCBB2_B1059              \ [0x03] B1059
    $04 constant GTZC_MPCBB2_B1060              \ [0x04] B1060
    $05 constant GTZC_MPCBB2_B1061              \ [0x05] B1061
    $06 constant GTZC_MPCBB2_B1062              \ [0x06] B1062
    $07 constant GTZC_MPCBB2_B1063              \ [0x07] B1063
    $08 constant GTZC_MPCBB2_B1064              \ [0x08] B1064
    $09 constant GTZC_MPCBB2_B1065              \ [0x09] B1065
    $0a constant GTZC_MPCBB2_B1066              \ [0x0a] B1066
    $0b constant GTZC_MPCBB2_B1067              \ [0x0b] B1067
    $0c constant GTZC_MPCBB2_B1068              \ [0x0c] B1068
    $0d constant GTZC_MPCBB2_B1069              \ [0x0d] B1069
    $0e constant GTZC_MPCBB2_B1070              \ [0x0e] B1070
    $0f constant GTZC_MPCBB2_B1071              \ [0x0f] B1071
    $10 constant GTZC_MPCBB2_B1072              \ [0x10] B1072
    $11 constant GTZC_MPCBB2_B1073              \ [0x11] B1073
    $12 constant GTZC_MPCBB2_B1074              \ [0x12] B1074
    $13 constant GTZC_MPCBB2_B1075              \ [0x13] B1075
    $14 constant GTZC_MPCBB2_B1076              \ [0x14] B1076
    $15 constant GTZC_MPCBB2_B1077              \ [0x15] B1077
    $16 constant GTZC_MPCBB2_B1078              \ [0x16] B1078
    $17 constant GTZC_MPCBB2_B1079              \ [0x17] B1079
    $18 constant GTZC_MPCBB2_B1080              \ [0x18] B1080
    $19 constant GTZC_MPCBB2_B1081              \ [0x19] B1081
    $1a constant GTZC_MPCBB2_B1082              \ [0x1a] B1082
    $1b constant GTZC_MPCBB2_B1083              \ [0x1b] B1083
    $1c constant GTZC_MPCBB2_B1084              \ [0x1c] B1084
    $1d constant GTZC_MPCBB2_B1085              \ [0x1d] B1085
    $1e constant GTZC_MPCBB2_B1086              \ [0x1e] B1086
    $1f constant GTZC_MPCBB2_B1087              \ [0x1f] B1087
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR34_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x188
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1088              \ [0x00] B1088
    $01 constant GTZC_MPCBB2_B1089              \ [0x01] B1089
    $02 constant GTZC_MPCBB2_B1090              \ [0x02] B1090
    $03 constant GTZC_MPCBB2_B1091              \ [0x03] B1091
    $04 constant GTZC_MPCBB2_B1092              \ [0x04] B1092
    $05 constant GTZC_MPCBB2_B1093              \ [0x05] B1093
    $06 constant GTZC_MPCBB2_B1094              \ [0x06] B1094
    $07 constant GTZC_MPCBB2_B1095              \ [0x07] B1095
    $08 constant GTZC_MPCBB2_B1096              \ [0x08] B1096
    $09 constant GTZC_MPCBB2_B1097              \ [0x09] B1097
    $0a constant GTZC_MPCBB2_B1098              \ [0x0a] B1098
    $0b constant GTZC_MPCBB2_B1099              \ [0x0b] B1099
    $0c constant GTZC_MPCBB2_B1100              \ [0x0c] B1100
    $0d constant GTZC_MPCBB2_B1101              \ [0x0d] B1101
    $0e constant GTZC_MPCBB2_B1102              \ [0x0e] B1102
    $0f constant GTZC_MPCBB2_B1103              \ [0x0f] B1103
    $10 constant GTZC_MPCBB2_B1104              \ [0x10] B1104
    $11 constant GTZC_MPCBB2_B1105              \ [0x11] B1105
    $12 constant GTZC_MPCBB2_B1106              \ [0x12] B1106
    $13 constant GTZC_MPCBB2_B1107              \ [0x13] B1107
    $14 constant GTZC_MPCBB2_B1108              \ [0x14] B1108
    $15 constant GTZC_MPCBB2_B1109              \ [0x15] B1109
    $16 constant GTZC_MPCBB2_B1110              \ [0x16] B1110
    $17 constant GTZC_MPCBB2_B1111              \ [0x17] B1111
    $18 constant GTZC_MPCBB2_B1112              \ [0x18] B1112
    $19 constant GTZC_MPCBB2_B1113              \ [0x19] B1113
    $1a constant GTZC_MPCBB2_B1114              \ [0x1a] B1114
    $1b constant GTZC_MPCBB2_B1115              \ [0x1b] B1115
    $1c constant GTZC_MPCBB2_B1116              \ [0x1c] B1116
    $1d constant GTZC_MPCBB2_B1117              \ [0x1d] B1117
    $1e constant GTZC_MPCBB2_B1118              \ [0x1e] B1118
    $1f constant GTZC_MPCBB2_B1119              \ [0x1f] B1119
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR35_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x18C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1120              \ [0x00] B1120
    $01 constant GTZC_MPCBB2_B1121              \ [0x01] B1121
    $02 constant GTZC_MPCBB2_B1122              \ [0x02] B1122
    $03 constant GTZC_MPCBB2_B1123              \ [0x03] B1123
    $04 constant GTZC_MPCBB2_B1124              \ [0x04] B1124
    $05 constant GTZC_MPCBB2_B1125              \ [0x05] B1125
    $06 constant GTZC_MPCBB2_B1126              \ [0x06] B1126
    $07 constant GTZC_MPCBB2_B1127              \ [0x07] B1127
    $08 constant GTZC_MPCBB2_B1128              \ [0x08] B1128
    $09 constant GTZC_MPCBB2_B1129              \ [0x09] B1129
    $0a constant GTZC_MPCBB2_B1130              \ [0x0a] B1130
    $0b constant GTZC_MPCBB2_B1131              \ [0x0b] B1131
    $0c constant GTZC_MPCBB2_B1132              \ [0x0c] B1132
    $0d constant GTZC_MPCBB2_B1133              \ [0x0d] B1133
    $0e constant GTZC_MPCBB2_B1134              \ [0x0e] B1134
    $0f constant GTZC_MPCBB2_B1135              \ [0x0f] B1135
    $10 constant GTZC_MPCBB2_B1136              \ [0x10] B1136
    $11 constant GTZC_MPCBB2_B1137              \ [0x11] B1137
    $12 constant GTZC_MPCBB2_B1138              \ [0x12] B1138
    $13 constant GTZC_MPCBB2_B1139              \ [0x13] B1139
    $14 constant GTZC_MPCBB2_B1140              \ [0x14] B1140
    $15 constant GTZC_MPCBB2_B1141              \ [0x15] B1141
    $16 constant GTZC_MPCBB2_B1142              \ [0x16] B1142
    $17 constant GTZC_MPCBB2_B1143              \ [0x17] B1143
    $18 constant GTZC_MPCBB2_B1144              \ [0x18] B1144
    $19 constant GTZC_MPCBB2_B1145              \ [0x19] B1145
    $1a constant GTZC_MPCBB2_B1146              \ [0x1a] B1146
    $1b constant GTZC_MPCBB2_B1147              \ [0x1b] B1147
    $1c constant GTZC_MPCBB2_B1148              \ [0x1c] B1148
    $1d constant GTZC_MPCBB2_B1149              \ [0x1d] B1149
    $1e constant GTZC_MPCBB2_B1150              \ [0x1e] B1150
    $1f constant GTZC_MPCBB2_B1151              \ [0x1f] B1151
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR36_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x190
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1152              \ [0x00] B1152
    $01 constant GTZC_MPCBB2_B1153              \ [0x01] B1153
    $02 constant GTZC_MPCBB2_B1154              \ [0x02] B1154
    $03 constant GTZC_MPCBB2_B1155              \ [0x03] B1155
    $04 constant GTZC_MPCBB2_B1156              \ [0x04] B1156
    $05 constant GTZC_MPCBB2_B1157              \ [0x05] B1157
    $06 constant GTZC_MPCBB2_B1158              \ [0x06] B1158
    $07 constant GTZC_MPCBB2_B1159              \ [0x07] B1159
    $08 constant GTZC_MPCBB2_B1160              \ [0x08] B1160
    $09 constant GTZC_MPCBB2_B1161              \ [0x09] B1161
    $0a constant GTZC_MPCBB2_B1162              \ [0x0a] B1162
    $0b constant GTZC_MPCBB2_B1163              \ [0x0b] B1163
    $0c constant GTZC_MPCBB2_B1164              \ [0x0c] B1164
    $0d constant GTZC_MPCBB2_B1165              \ [0x0d] B1165
    $0e constant GTZC_MPCBB2_B1166              \ [0x0e] B1166
    $0f constant GTZC_MPCBB2_B1167              \ [0x0f] B1167
    $10 constant GTZC_MPCBB2_B1168              \ [0x10] B1168
    $11 constant GTZC_MPCBB2_B1169              \ [0x11] B1169
    $12 constant GTZC_MPCBB2_B1170              \ [0x12] B1170
    $13 constant GTZC_MPCBB2_B1171              \ [0x13] B1171
    $14 constant GTZC_MPCBB2_B1172              \ [0x14] B1172
    $15 constant GTZC_MPCBB2_B1173              \ [0x15] B1173
    $16 constant GTZC_MPCBB2_B1174              \ [0x16] B1174
    $17 constant GTZC_MPCBB2_B1175              \ [0x17] B1175
    $18 constant GTZC_MPCBB2_B1176              \ [0x18] B1176
    $19 constant GTZC_MPCBB2_B1177              \ [0x19] B1177
    $1a constant GTZC_MPCBB2_B1178              \ [0x1a] B1178
    $1b constant GTZC_MPCBB2_B1179              \ [0x1b] B1179
    $1c constant GTZC_MPCBB2_B1180              \ [0x1c] B1180
    $1d constant GTZC_MPCBB2_B1181              \ [0x1d] B1181
    $1e constant GTZC_MPCBB2_B1182              \ [0x1e] B1182
    $1f constant GTZC_MPCBB2_B1183              \ [0x1f] B1183
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR37_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x194
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1184              \ [0x00] B1184
    $01 constant GTZC_MPCBB2_B1185              \ [0x01] B1185
    $02 constant GTZC_MPCBB2_B1186              \ [0x02] B1186
    $03 constant GTZC_MPCBB2_B1187              \ [0x03] B1187
    $04 constant GTZC_MPCBB2_B1188              \ [0x04] B1188
    $05 constant GTZC_MPCBB2_B1189              \ [0x05] B1189
    $06 constant GTZC_MPCBB2_B1190              \ [0x06] B1190
    $07 constant GTZC_MPCBB2_B1191              \ [0x07] B1191
    $08 constant GTZC_MPCBB2_B1192              \ [0x08] B1192
    $09 constant GTZC_MPCBB2_B1193              \ [0x09] B1193
    $0a constant GTZC_MPCBB2_B1194              \ [0x0a] B1194
    $0b constant GTZC_MPCBB2_B1195              \ [0x0b] B1195
    $0c constant GTZC_MPCBB2_B1196              \ [0x0c] B1196
    $0d constant GTZC_MPCBB2_B1197              \ [0x0d] B1197
    $0e constant GTZC_MPCBB2_B1198              \ [0x0e] B1198
    $0f constant GTZC_MPCBB2_B1199              \ [0x0f] B1199
    $10 constant GTZC_MPCBB2_B1200              \ [0x10] B1200
    $11 constant GTZC_MPCBB2_B1201              \ [0x11] B1201
    $12 constant GTZC_MPCBB2_B1202              \ [0x12] B1202
    $13 constant GTZC_MPCBB2_B1203              \ [0x13] B1203
    $14 constant GTZC_MPCBB2_B1204              \ [0x14] B1204
    $15 constant GTZC_MPCBB2_B1205              \ [0x15] B1205
    $16 constant GTZC_MPCBB2_B1206              \ [0x16] B1206
    $17 constant GTZC_MPCBB2_B1207              \ [0x17] B1207
    $18 constant GTZC_MPCBB2_B1208              \ [0x18] B1208
    $19 constant GTZC_MPCBB2_B1209              \ [0x19] B1209
    $1a constant GTZC_MPCBB2_B1210              \ [0x1a] B1210
    $1b constant GTZC_MPCBB2_B1211              \ [0x1b] B1211
    $1c constant GTZC_MPCBB2_B1212              \ [0x1c] B1212
    $1d constant GTZC_MPCBB2_B1213              \ [0x1d] B1213
    $1e constant GTZC_MPCBB2_B1214              \ [0x1e] B1214
    $1f constant GTZC_MPCBB2_B1215              \ [0x1f] B1215
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR38_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x198
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1216              \ [0x00] B1216
    $01 constant GTZC_MPCBB2_B1217              \ [0x01] B1217
    $02 constant GTZC_MPCBB2_B1218              \ [0x02] B1218
    $03 constant GTZC_MPCBB2_B1219              \ [0x03] B1219
    $04 constant GTZC_MPCBB2_B1220              \ [0x04] B1220
    $05 constant GTZC_MPCBB2_B1221              \ [0x05] B1221
    $06 constant GTZC_MPCBB2_B1222              \ [0x06] B1222
    $07 constant GTZC_MPCBB2_B1223              \ [0x07] B1223
    $08 constant GTZC_MPCBB2_B1224              \ [0x08] B1224
    $09 constant GTZC_MPCBB2_B1225              \ [0x09] B1225
    $0a constant GTZC_MPCBB2_B1226              \ [0x0a] B1226
    $0b constant GTZC_MPCBB2_B1227              \ [0x0b] B1227
    $0c constant GTZC_MPCBB2_B1228              \ [0x0c] B1228
    $0d constant GTZC_MPCBB2_B1229              \ [0x0d] B1229
    $0e constant GTZC_MPCBB2_B1230              \ [0x0e] B1230
    $0f constant GTZC_MPCBB2_B1231              \ [0x0f] B1231
    $10 constant GTZC_MPCBB2_B1232              \ [0x10] B1232
    $11 constant GTZC_MPCBB2_B1233              \ [0x11] B1233
    $12 constant GTZC_MPCBB2_B1234              \ [0x12] B1234
    $13 constant GTZC_MPCBB2_B1235              \ [0x13] B1235
    $14 constant GTZC_MPCBB2_B1236              \ [0x14] B1236
    $15 constant GTZC_MPCBB2_B1237              \ [0x15] B1237
    $16 constant GTZC_MPCBB2_B1238              \ [0x16] B1238
    $17 constant GTZC_MPCBB2_B1239              \ [0x17] B1239
    $18 constant GTZC_MPCBB2_B1240              \ [0x18] B1240
    $19 constant GTZC_MPCBB2_B1241              \ [0x19] B1241
    $1a constant GTZC_MPCBB2_B1242              \ [0x1a] B1242
    $1b constant GTZC_MPCBB2_B1243              \ [0x1b] B1243
    $1c constant GTZC_MPCBB2_B1244              \ [0x1c] B1244
    $1d constant GTZC_MPCBB2_B1245              \ [0x1d] B1245
    $1e constant GTZC_MPCBB2_B1246              \ [0x1e] B1246
    $1f constant GTZC_MPCBB2_B1247              \ [0x1f] B1247
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR39_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x19C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1248              \ [0x00] B1248
    $01 constant GTZC_MPCBB2_B1249              \ [0x01] B1249
    $02 constant GTZC_MPCBB2_B1250              \ [0x02] B1250
    $03 constant GTZC_MPCBB2_B1251              \ [0x03] B1251
    $04 constant GTZC_MPCBB2_B1252              \ [0x04] B1252
    $05 constant GTZC_MPCBB2_B1253              \ [0x05] B1253
    $06 constant GTZC_MPCBB2_B1254              \ [0x06] B1254
    $07 constant GTZC_MPCBB2_B1255              \ [0x07] B1255
    $08 constant GTZC_MPCBB2_B1256              \ [0x08] B1256
    $09 constant GTZC_MPCBB2_B1257              \ [0x09] B1257
    $0a constant GTZC_MPCBB2_B1258              \ [0x0a] B1258
    $0b constant GTZC_MPCBB2_B1259              \ [0x0b] B1259
    $0c constant GTZC_MPCBB2_B1260              \ [0x0c] B1260
    $0d constant GTZC_MPCBB2_B1261              \ [0x0d] B1261
    $0e constant GTZC_MPCBB2_B1262              \ [0x0e] B1262
    $0f constant GTZC_MPCBB2_B1263              \ [0x0f] B1263
    $10 constant GTZC_MPCBB2_B1264              \ [0x10] B1264
    $11 constant GTZC_MPCBB2_B1265              \ [0x11] B1265
    $12 constant GTZC_MPCBB2_B1266              \ [0x12] B1266
    $13 constant GTZC_MPCBB2_B1267              \ [0x13] B1267
    $14 constant GTZC_MPCBB2_B1268              \ [0x14] B1268
    $15 constant GTZC_MPCBB2_B1269              \ [0x15] B1269
    $16 constant GTZC_MPCBB2_B1270              \ [0x16] B1270
    $17 constant GTZC_MPCBB2_B1271              \ [0x17] B1271
    $18 constant GTZC_MPCBB2_B1272              \ [0x18] B1272
    $19 constant GTZC_MPCBB2_B1273              \ [0x19] B1273
    $1a constant GTZC_MPCBB2_B1274              \ [0x1a] B1274
    $1b constant GTZC_MPCBB2_B1275              \ [0x1b] B1275
    $1c constant GTZC_MPCBB2_B1276              \ [0x1c] B1276
    $1d constant GTZC_MPCBB2_B1277              \ [0x1d] B1277
    $1e constant GTZC_MPCBB2_B1278              \ [0x1e] B1278
    $1f constant GTZC_MPCBB2_B1279              \ [0x1f] B1279
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR40_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1A0
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1280              \ [0x00] B1280
    $01 constant GTZC_MPCBB2_B1281              \ [0x01] B1281
    $02 constant GTZC_MPCBB2_B1282              \ [0x02] B1282
    $03 constant GTZC_MPCBB2_B1283              \ [0x03] B1283
    $04 constant GTZC_MPCBB2_B1284              \ [0x04] B1284
    $05 constant GTZC_MPCBB2_B1285              \ [0x05] B1285
    $06 constant GTZC_MPCBB2_B1286              \ [0x06] B1286
    $07 constant GTZC_MPCBB2_B1287              \ [0x07] B1287
    $08 constant GTZC_MPCBB2_B1288              \ [0x08] B1288
    $09 constant GTZC_MPCBB2_B1289              \ [0x09] B1289
    $0a constant GTZC_MPCBB2_B1290              \ [0x0a] B1290
    $0b constant GTZC_MPCBB2_B1291              \ [0x0b] B1291
    $0c constant GTZC_MPCBB2_B1292              \ [0x0c] B1292
    $0d constant GTZC_MPCBB2_B1293              \ [0x0d] B1293
    $0e constant GTZC_MPCBB2_B1294              \ [0x0e] B1294
    $0f constant GTZC_MPCBB2_B1295              \ [0x0f] B1295
    $10 constant GTZC_MPCBB2_B1296              \ [0x10] B1296
    $11 constant GTZC_MPCBB2_B1297              \ [0x11] B1297
    $12 constant GTZC_MPCBB2_B1298              \ [0x12] B1298
    $13 constant GTZC_MPCBB2_B1299              \ [0x13] B1299
    $14 constant GTZC_MPCBB2_B1300              \ [0x14] B1300
    $15 constant GTZC_MPCBB2_B1301              \ [0x15] B1301
    $16 constant GTZC_MPCBB2_B1302              \ [0x16] B1302
    $17 constant GTZC_MPCBB2_B1303              \ [0x17] B1303
    $18 constant GTZC_MPCBB2_B1304              \ [0x18] B1304
    $19 constant GTZC_MPCBB2_B1305              \ [0x19] B1305
    $1a constant GTZC_MPCBB2_B1306              \ [0x1a] B1306
    $1b constant GTZC_MPCBB2_B1307              \ [0x1b] B1307
    $1c constant GTZC_MPCBB2_B1308              \ [0x1c] B1308
    $1d constant GTZC_MPCBB2_B1309              \ [0x1d] B1309
    $1e constant GTZC_MPCBB2_B1310              \ [0x1e] B1310
    $1f constant GTZC_MPCBB2_B1311              \ [0x1f] B1311
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR41_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1A4
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1312              \ [0x00] B1312
    $01 constant GTZC_MPCBB2_B1313              \ [0x01] B1313
    $02 constant GTZC_MPCBB2_B1314              \ [0x02] B1314
    $03 constant GTZC_MPCBB2_B1315              \ [0x03] B1315
    $04 constant GTZC_MPCBB2_B1316              \ [0x04] B1316
    $05 constant GTZC_MPCBB2_B1317              \ [0x05] B1317
    $06 constant GTZC_MPCBB2_B1318              \ [0x06] B1318
    $07 constant GTZC_MPCBB2_B1319              \ [0x07] B1319
    $08 constant GTZC_MPCBB2_B1320              \ [0x08] B1320
    $09 constant GTZC_MPCBB2_B1321              \ [0x09] B1321
    $0a constant GTZC_MPCBB2_B1322              \ [0x0a] B1322
    $0b constant GTZC_MPCBB2_B1323              \ [0x0b] B1323
    $0c constant GTZC_MPCBB2_B1324              \ [0x0c] B1324
    $0d constant GTZC_MPCBB2_B1325              \ [0x0d] B1325
    $0e constant GTZC_MPCBB2_B1326              \ [0x0e] B1326
    $0f constant GTZC_MPCBB2_B1327              \ [0x0f] B1327
    $10 constant GTZC_MPCBB2_B1328              \ [0x10] B1328
    $11 constant GTZC_MPCBB2_B1329              \ [0x11] B1329
    $12 constant GTZC_MPCBB2_B1330              \ [0x12] B1330
    $13 constant GTZC_MPCBB2_B1331              \ [0x13] B1331
    $14 constant GTZC_MPCBB2_B1332              \ [0x14] B1332
    $15 constant GTZC_MPCBB2_B1333              \ [0x15] B1333
    $16 constant GTZC_MPCBB2_B1334              \ [0x16] B1334
    $17 constant GTZC_MPCBB2_B1335              \ [0x17] B1335
    $18 constant GTZC_MPCBB2_B1336              \ [0x18] B1336
    $19 constant GTZC_MPCBB2_B1337              \ [0x19] B1337
    $1a constant GTZC_MPCBB2_B1338              \ [0x1a] B1338
    $1b constant GTZC_MPCBB2_B1339              \ [0x1b] B1339
    $1c constant GTZC_MPCBB2_B1340              \ [0x1c] B1340
    $1d constant GTZC_MPCBB2_B1341              \ [0x1d] B1341
    $1e constant GTZC_MPCBB2_B1342              \ [0x1e] B1342
    $1f constant GTZC_MPCBB2_B1343              \ [0x1f] B1343
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR42_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1A8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1344              \ [0x00] B1344
    $01 constant GTZC_MPCBB2_B1345              \ [0x01] B1345
    $02 constant GTZC_MPCBB2_B1346              \ [0x02] B1346
    $03 constant GTZC_MPCBB2_B1347              \ [0x03] B1347
    $04 constant GTZC_MPCBB2_B1348              \ [0x04] B1348
    $05 constant GTZC_MPCBB2_B1349              \ [0x05] B1349
    $06 constant GTZC_MPCBB2_B1350              \ [0x06] B1350
    $07 constant GTZC_MPCBB2_B1351              \ [0x07] B1351
    $08 constant GTZC_MPCBB2_B1352              \ [0x08] B1352
    $09 constant GTZC_MPCBB2_B1353              \ [0x09] B1353
    $0a constant GTZC_MPCBB2_B1354              \ [0x0a] B1354
    $0b constant GTZC_MPCBB2_B1355              \ [0x0b] B1355
    $0c constant GTZC_MPCBB2_B1356              \ [0x0c] B1356
    $0d constant GTZC_MPCBB2_B1357              \ [0x0d] B1357
    $0e constant GTZC_MPCBB2_B1358              \ [0x0e] B1358
    $0f constant GTZC_MPCBB2_B1359              \ [0x0f] B1359
    $10 constant GTZC_MPCBB2_B1360              \ [0x10] B1360
    $11 constant GTZC_MPCBB2_B1361              \ [0x11] B1361
    $12 constant GTZC_MPCBB2_B1362              \ [0x12] B1362
    $13 constant GTZC_MPCBB2_B1363              \ [0x13] B1363
    $14 constant GTZC_MPCBB2_B1364              \ [0x14] B1364
    $15 constant GTZC_MPCBB2_B1365              \ [0x15] B1365
    $16 constant GTZC_MPCBB2_B1366              \ [0x16] B1366
    $17 constant GTZC_MPCBB2_B1367              \ [0x17] B1367
    $18 constant GTZC_MPCBB2_B1368              \ [0x18] B1368
    $19 constant GTZC_MPCBB2_B1369              \ [0x19] B1369
    $1a constant GTZC_MPCBB2_B1370              \ [0x1a] B1370
    $1b constant GTZC_MPCBB2_B1371              \ [0x1b] B1371
    $1c constant GTZC_MPCBB2_B1372              \ [0x1c] B1372
    $1d constant GTZC_MPCBB2_B1373              \ [0x1d] B1373
    $1e constant GTZC_MPCBB2_B1374              \ [0x1e] B1374
    $1f constant GTZC_MPCBB2_B1375              \ [0x1f] B1375
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR43_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1AC
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1376              \ [0x00] B1376
    $01 constant GTZC_MPCBB2_B1377              \ [0x01] B1377
    $02 constant GTZC_MPCBB2_B1378              \ [0x02] B1378
    $03 constant GTZC_MPCBB2_B1379              \ [0x03] B1379
    $04 constant GTZC_MPCBB2_B1380              \ [0x04] B1380
    $05 constant GTZC_MPCBB2_B1381              \ [0x05] B1381
    $06 constant GTZC_MPCBB2_B1382              \ [0x06] B1382
    $07 constant GTZC_MPCBB2_B1383              \ [0x07] B1383
    $08 constant GTZC_MPCBB2_B1384              \ [0x08] B1384
    $09 constant GTZC_MPCBB2_B1385              \ [0x09] B1385
    $0a constant GTZC_MPCBB2_B1386              \ [0x0a] B1386
    $0b constant GTZC_MPCBB2_B1387              \ [0x0b] B1387
    $0c constant GTZC_MPCBB2_B1388              \ [0x0c] B1388
    $0d constant GTZC_MPCBB2_B1389              \ [0x0d] B1389
    $0e constant GTZC_MPCBB2_B1390              \ [0x0e] B1390
    $0f constant GTZC_MPCBB2_B1391              \ [0x0f] B1391
    $10 constant GTZC_MPCBB2_B1392              \ [0x10] B1392
    $11 constant GTZC_MPCBB2_B1393              \ [0x11] B1393
    $12 constant GTZC_MPCBB2_B1394              \ [0x12] B1394
    $13 constant GTZC_MPCBB2_B1395              \ [0x13] B1395
    $14 constant GTZC_MPCBB2_B1396              \ [0x14] B1396
    $15 constant GTZC_MPCBB2_B1397              \ [0x15] B1397
    $16 constant GTZC_MPCBB2_B1398              \ [0x16] B1398
    $17 constant GTZC_MPCBB2_B1399              \ [0x17] B1399
    $18 constant GTZC_MPCBB2_B1400              \ [0x18] B1400
    $19 constant GTZC_MPCBB2_B1401              \ [0x19] B1401
    $1a constant GTZC_MPCBB2_B1402              \ [0x1a] B1402
    $1b constant GTZC_MPCBB2_B1403              \ [0x1b] B1403
    $1c constant GTZC_MPCBB2_B1404              \ [0x1c] B1404
    $1d constant GTZC_MPCBB2_B1405              \ [0x1d] B1405
    $1e constant GTZC_MPCBB2_B1406              \ [0x1e] B1406
    $1f constant GTZC_MPCBB2_B1407              \ [0x1f] B1407
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR44_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1B0
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1408              \ [0x00] B1408
    $01 constant GTZC_MPCBB2_B1409              \ [0x01] B1409
    $02 constant GTZC_MPCBB2_B1410              \ [0x02] B1410
    $03 constant GTZC_MPCBB2_B1411              \ [0x03] B1411
    $04 constant GTZC_MPCBB2_B1412              \ [0x04] B1412
    $05 constant GTZC_MPCBB2_B1413              \ [0x05] B1413
    $06 constant GTZC_MPCBB2_B1414              \ [0x06] B1414
    $07 constant GTZC_MPCBB2_B1415              \ [0x07] B1415
    $08 constant GTZC_MPCBB2_B1416              \ [0x08] B1416
    $09 constant GTZC_MPCBB2_B1417              \ [0x09] B1417
    $0a constant GTZC_MPCBB2_B1418              \ [0x0a] B1418
    $0b constant GTZC_MPCBB2_B1419              \ [0x0b] B1419
    $0c constant GTZC_MPCBB2_B1420              \ [0x0c] B1420
    $0d constant GTZC_MPCBB2_B1421              \ [0x0d] B1421
    $0e constant GTZC_MPCBB2_B1422              \ [0x0e] B1422
    $0f constant GTZC_MPCBB2_B1423              \ [0x0f] B1423
    $10 constant GTZC_MPCBB2_B1424              \ [0x10] B1424
    $11 constant GTZC_MPCBB2_B1425              \ [0x11] B1425
    $12 constant GTZC_MPCBB2_B1426              \ [0x12] B1426
    $13 constant GTZC_MPCBB2_B1427              \ [0x13] B1427
    $14 constant GTZC_MPCBB2_B1428              \ [0x14] B1428
    $15 constant GTZC_MPCBB2_B1429              \ [0x15] B1429
    $16 constant GTZC_MPCBB2_B1430              \ [0x16] B1430
    $17 constant GTZC_MPCBB2_B1431              \ [0x17] B1431
    $18 constant GTZC_MPCBB2_B1432              \ [0x18] B1432
    $19 constant GTZC_MPCBB2_B1433              \ [0x19] B1433
    $1a constant GTZC_MPCBB2_B1434              \ [0x1a] B1434
    $1b constant GTZC_MPCBB2_B1435              \ [0x1b] B1435
    $1c constant GTZC_MPCBB2_B1436              \ [0x1c] B1436
    $1d constant GTZC_MPCBB2_B1437              \ [0x1d] B1437
    $1e constant GTZC_MPCBB2_B1438              \ [0x1e] B1438
    $1f constant GTZC_MPCBB2_B1439              \ [0x1f] B1439
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR45_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1B4
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1440              \ [0x00] B1440
    $01 constant GTZC_MPCBB2_B1441              \ [0x01] B1441
    $02 constant GTZC_MPCBB2_B1442              \ [0x02] B1442
    $03 constant GTZC_MPCBB2_B1443              \ [0x03] B1443
    $04 constant GTZC_MPCBB2_B1444              \ [0x04] B1444
    $05 constant GTZC_MPCBB2_B1445              \ [0x05] B1445
    $06 constant GTZC_MPCBB2_B1446              \ [0x06] B1446
    $07 constant GTZC_MPCBB2_B1447              \ [0x07] B1447
    $08 constant GTZC_MPCBB2_B1448              \ [0x08] B1448
    $09 constant GTZC_MPCBB2_B1449              \ [0x09] B1449
    $0a constant GTZC_MPCBB2_B1450              \ [0x0a] B1450
    $0b constant GTZC_MPCBB2_B1451              \ [0x0b] B1451
    $0c constant GTZC_MPCBB2_B1452              \ [0x0c] B1452
    $0d constant GTZC_MPCBB2_B1453              \ [0x0d] B1453
    $0e constant GTZC_MPCBB2_B1454              \ [0x0e] B1454
    $0f constant GTZC_MPCBB2_B1455              \ [0x0f] B1455
    $10 constant GTZC_MPCBB2_B1456              \ [0x10] B1456
    $11 constant GTZC_MPCBB2_B1457              \ [0x11] B1457
    $12 constant GTZC_MPCBB2_B1458              \ [0x12] B1458
    $13 constant GTZC_MPCBB2_B1459              \ [0x13] B1459
    $14 constant GTZC_MPCBB2_B1460              \ [0x14] B1460
    $15 constant GTZC_MPCBB2_B1461              \ [0x15] B1461
    $16 constant GTZC_MPCBB2_B1462              \ [0x16] B1462
    $17 constant GTZC_MPCBB2_B1463              \ [0x17] B1463
    $18 constant GTZC_MPCBB2_B1464              \ [0x18] B1464
    $19 constant GTZC_MPCBB2_B1465              \ [0x19] B1465
    $1a constant GTZC_MPCBB2_B1466              \ [0x1a] B1466
    $1b constant GTZC_MPCBB2_B1467              \ [0x1b] B1467
    $1c constant GTZC_MPCBB2_B1468              \ [0x1c] B1468
    $1d constant GTZC_MPCBB2_B1469              \ [0x1d] B1469
    $1e constant GTZC_MPCBB2_B1470              \ [0x1e] B1470
    $1f constant GTZC_MPCBB2_B1471              \ [0x1f] B1471
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR46_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1B8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1472              \ [0x00] B1472
    $01 constant GTZC_MPCBB2_B1473              \ [0x01] B1473
    $02 constant GTZC_MPCBB2_B1474              \ [0x02] B1474
    $03 constant GTZC_MPCBB2_B1475              \ [0x03] B1475
    $04 constant GTZC_MPCBB2_B1476              \ [0x04] B1476
    $05 constant GTZC_MPCBB2_B1477              \ [0x05] B1477
    $06 constant GTZC_MPCBB2_B1478              \ [0x06] B1478
    $07 constant GTZC_MPCBB2_B1479              \ [0x07] B1479
    $08 constant GTZC_MPCBB2_B1480              \ [0x08] B1480
    $09 constant GTZC_MPCBB2_B1481              \ [0x09] B1481
    $0a constant GTZC_MPCBB2_B1482              \ [0x0a] B1482
    $0b constant GTZC_MPCBB2_B1483              \ [0x0b] B1483
    $0c constant GTZC_MPCBB2_B1484              \ [0x0c] B1484
    $0d constant GTZC_MPCBB2_B1485              \ [0x0d] B1485
    $0e constant GTZC_MPCBB2_B1486              \ [0x0e] B1486
    $0f constant GTZC_MPCBB2_B1487              \ [0x0f] B1487
    $10 constant GTZC_MPCBB2_B1488              \ [0x10] B1488
    $11 constant GTZC_MPCBB2_B1489              \ [0x11] B1489
    $12 constant GTZC_MPCBB2_B1490              \ [0x12] B1490
    $13 constant GTZC_MPCBB2_B1491              \ [0x13] B1491
    $14 constant GTZC_MPCBB2_B1492              \ [0x14] B1492
    $15 constant GTZC_MPCBB2_B1493              \ [0x15] B1493
    $16 constant GTZC_MPCBB2_B1494              \ [0x16] B1494
    $17 constant GTZC_MPCBB2_B1495              \ [0x17] B1495
    $18 constant GTZC_MPCBB2_B1496              \ [0x18] B1496
    $19 constant GTZC_MPCBB2_B1497              \ [0x19] B1497
    $1a constant GTZC_MPCBB2_B1498              \ [0x1a] B1498
    $1b constant GTZC_MPCBB2_B1499              \ [0x1b] B1499
    $1c constant GTZC_MPCBB2_B1500              \ [0x1c] B1500
    $1d constant GTZC_MPCBB2_B1501              \ [0x1d] B1501
    $1e constant GTZC_MPCBB2_B1502              \ [0x1e] B1502
    $1f constant GTZC_MPCBB2_B1503              \ [0x1f] B1503
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR47_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1BC
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1504              \ [0x00] B1504
    $01 constant GTZC_MPCBB2_B1505              \ [0x01] B1505
    $02 constant GTZC_MPCBB2_B1506              \ [0x02] B1506
    $03 constant GTZC_MPCBB2_B1507              \ [0x03] B1507
    $04 constant GTZC_MPCBB2_B1508              \ [0x04] B1508
    $05 constant GTZC_MPCBB2_B1509              \ [0x05] B1509
    $06 constant GTZC_MPCBB2_B1510              \ [0x06] B1510
    $07 constant GTZC_MPCBB2_B1511              \ [0x07] B1511
    $08 constant GTZC_MPCBB2_B1512              \ [0x08] B1512
    $09 constant GTZC_MPCBB2_B1513              \ [0x09] B1513
    $0a constant GTZC_MPCBB2_B1514              \ [0x0a] B1514
    $0b constant GTZC_MPCBB2_B1515              \ [0x0b] B1515
    $0c constant GTZC_MPCBB2_B1516              \ [0x0c] B1516
    $0d constant GTZC_MPCBB2_B1517              \ [0x0d] B1517
    $0e constant GTZC_MPCBB2_B1518              \ [0x0e] B1518
    $0f constant GTZC_MPCBB2_B1519              \ [0x0f] B1519
    $10 constant GTZC_MPCBB2_B1520              \ [0x10] B1520
    $11 constant GTZC_MPCBB2_B1521              \ [0x11] B1521
    $12 constant GTZC_MPCBB2_B1522              \ [0x12] B1522
    $13 constant GTZC_MPCBB2_B1523              \ [0x13] B1523
    $14 constant GTZC_MPCBB2_B1524              \ [0x14] B1524
    $15 constant GTZC_MPCBB2_B1525              \ [0x15] B1525
    $16 constant GTZC_MPCBB2_B1526              \ [0x16] B1526
    $17 constant GTZC_MPCBB2_B1527              \ [0x17] B1527
    $18 constant GTZC_MPCBB2_B1528              \ [0x18] B1528
    $19 constant GTZC_MPCBB2_B1529              \ [0x19] B1529
    $1a constant GTZC_MPCBB2_B1530              \ [0x1a] B1530
    $1b constant GTZC_MPCBB2_B1531              \ [0x1b] B1531
    $1c constant GTZC_MPCBB2_B1532              \ [0x1c] B1532
    $1d constant GTZC_MPCBB2_B1533              \ [0x1d] B1533
    $1e constant GTZC_MPCBB2_B1534              \ [0x1e] B1534
    $1f constant GTZC_MPCBB2_B1535              \ [0x1f] B1535
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR48_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1C0
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1536              \ [0x00] B1536
    $01 constant GTZC_MPCBB2_B1537              \ [0x01] B1537
    $02 constant GTZC_MPCBB2_B1538              \ [0x02] B1538
    $03 constant GTZC_MPCBB2_B1539              \ [0x03] B1539
    $04 constant GTZC_MPCBB2_B1540              \ [0x04] B1540
    $05 constant GTZC_MPCBB2_B1541              \ [0x05] B1541
    $06 constant GTZC_MPCBB2_B1542              \ [0x06] B1542
    $07 constant GTZC_MPCBB2_B1543              \ [0x07] B1543
    $08 constant GTZC_MPCBB2_B1544              \ [0x08] B1544
    $09 constant GTZC_MPCBB2_B1545              \ [0x09] B1545
    $0a constant GTZC_MPCBB2_B1546              \ [0x0a] B1546
    $0b constant GTZC_MPCBB2_B1547              \ [0x0b] B1547
    $0c constant GTZC_MPCBB2_B1548              \ [0x0c] B1548
    $0d constant GTZC_MPCBB2_B1549              \ [0x0d] B1549
    $0e constant GTZC_MPCBB2_B1550              \ [0x0e] B1550
    $0f constant GTZC_MPCBB2_B1551              \ [0x0f] B1551
    $10 constant GTZC_MPCBB2_B1552              \ [0x10] B1552
    $11 constant GTZC_MPCBB2_B1553              \ [0x11] B1553
    $12 constant GTZC_MPCBB2_B1554              \ [0x12] B1554
    $13 constant GTZC_MPCBB2_B1555              \ [0x13] B1555
    $14 constant GTZC_MPCBB2_B1556              \ [0x14] B1556
    $15 constant GTZC_MPCBB2_B1557              \ [0x15] B1557
    $16 constant GTZC_MPCBB2_B1558              \ [0x16] B1558
    $17 constant GTZC_MPCBB2_B1559              \ [0x17] B1559
    $18 constant GTZC_MPCBB2_B1560              \ [0x18] B1560
    $19 constant GTZC_MPCBB2_B1561              \ [0x19] B1561
    $1a constant GTZC_MPCBB2_B1562              \ [0x1a] B1562
    $1b constant GTZC_MPCBB2_B1563              \ [0x1b] B1563
    $1c constant GTZC_MPCBB2_B1564              \ [0x1c] B1564
    $1d constant GTZC_MPCBB2_B1565              \ [0x1d] B1565
    $1e constant GTZC_MPCBB2_B1566              \ [0x1e] B1566
    $1f constant GTZC_MPCBB2_B1567              \ [0x1f] B1567
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR49_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1C4
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1568              \ [0x00] B1568
    $01 constant GTZC_MPCBB2_B1569              \ [0x01] B1569
    $02 constant GTZC_MPCBB2_B1570              \ [0x02] B1570
    $03 constant GTZC_MPCBB2_B1571              \ [0x03] B1571
    $04 constant GTZC_MPCBB2_B1572              \ [0x04] B1572
    $05 constant GTZC_MPCBB2_B1573              \ [0x05] B1573
    $06 constant GTZC_MPCBB2_B1574              \ [0x06] B1574
    $07 constant GTZC_MPCBB2_B1575              \ [0x07] B1575
    $08 constant GTZC_MPCBB2_B1576              \ [0x08] B1576
    $09 constant GTZC_MPCBB2_B1577              \ [0x09] B1577
    $0a constant GTZC_MPCBB2_B1578              \ [0x0a] B1578
    $0b constant GTZC_MPCBB2_B1579              \ [0x0b] B1579
    $0c constant GTZC_MPCBB2_B1580              \ [0x0c] B1580
    $0d constant GTZC_MPCBB2_B1581              \ [0x0d] B1581
    $0e constant GTZC_MPCBB2_B1582              \ [0x0e] B1582
    $0f constant GTZC_MPCBB2_B1583              \ [0x0f] B1583
    $10 constant GTZC_MPCBB2_B1584              \ [0x10] B1584
    $11 constant GTZC_MPCBB2_B1585              \ [0x11] B1585
    $12 constant GTZC_MPCBB2_B1586              \ [0x12] B1586
    $13 constant GTZC_MPCBB2_B1587              \ [0x13] B1587
    $14 constant GTZC_MPCBB2_B1588              \ [0x14] B1588
    $15 constant GTZC_MPCBB2_B1589              \ [0x15] B1589
    $16 constant GTZC_MPCBB2_B1590              \ [0x16] B1590
    $17 constant GTZC_MPCBB2_B1591              \ [0x17] B1591
    $18 constant GTZC_MPCBB2_B1592              \ [0x18] B1592
    $19 constant GTZC_MPCBB2_B1593              \ [0x19] B1593
    $1a constant GTZC_MPCBB2_B1594              \ [0x1a] B1594
    $1b constant GTZC_MPCBB2_B1595              \ [0x1b] B1595
    $1c constant GTZC_MPCBB2_B1596              \ [0x1c] B1596
    $1d constant GTZC_MPCBB2_B1597              \ [0x1d] B1597
    $1e constant GTZC_MPCBB2_B1598              \ [0x1e] B1598
    $1f constant GTZC_MPCBB2_B1599              \ [0x1f] B1599
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR50_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1C8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1600              \ [0x00] B1600
    $01 constant GTZC_MPCBB2_B1601              \ [0x01] B1601
    $02 constant GTZC_MPCBB2_B1602              \ [0x02] B1602
    $03 constant GTZC_MPCBB2_B1603              \ [0x03] B1603
    $04 constant GTZC_MPCBB2_B1604              \ [0x04] B1604
    $05 constant GTZC_MPCBB2_B1605              \ [0x05] B1605
    $06 constant GTZC_MPCBB2_B1606              \ [0x06] B1606
    $07 constant GTZC_MPCBB2_B1607              \ [0x07] B1607
    $08 constant GTZC_MPCBB2_B1608              \ [0x08] B1608
    $09 constant GTZC_MPCBB2_B1609              \ [0x09] B1609
    $0a constant GTZC_MPCBB2_B1610              \ [0x0a] B1610
    $0b constant GTZC_MPCBB2_B1611              \ [0x0b] B1611
    $0c constant GTZC_MPCBB2_B1612              \ [0x0c] B1612
    $0d constant GTZC_MPCBB2_B1613              \ [0x0d] B1613
    $0e constant GTZC_MPCBB2_B1614              \ [0x0e] B1614
    $0f constant GTZC_MPCBB2_B1615              \ [0x0f] B1615
    $10 constant GTZC_MPCBB2_B1616              \ [0x10] B1616
    $11 constant GTZC_MPCBB2_B1617              \ [0x11] B1617
    $12 constant GTZC_MPCBB2_B1618              \ [0x12] B1618
    $13 constant GTZC_MPCBB2_B1619              \ [0x13] B1619
    $14 constant GTZC_MPCBB2_B1620              \ [0x14] B1620
    $15 constant GTZC_MPCBB2_B1621              \ [0x15] B1621
    $16 constant GTZC_MPCBB2_B1622              \ [0x16] B1622
    $17 constant GTZC_MPCBB2_B1623              \ [0x17] B1623
    $18 constant GTZC_MPCBB2_B1624              \ [0x18] B1624
    $19 constant GTZC_MPCBB2_B1625              \ [0x19] B1625
    $1a constant GTZC_MPCBB2_B1626              \ [0x1a] B1626
    $1b constant GTZC_MPCBB2_B1627              \ [0x1b] B1627
    $1c constant GTZC_MPCBB2_B1628              \ [0x1c] B1628
    $1d constant GTZC_MPCBB2_B1629              \ [0x1d] B1629
    $1e constant GTZC_MPCBB2_B1630              \ [0x1e] B1630
    $1f constant GTZC_MPCBB2_B1631              \ [0x1f] B1631
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR51_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1CC
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1632              \ [0x00] B1632
    $01 constant GTZC_MPCBB2_B1633              \ [0x01] B1633
    $02 constant GTZC_MPCBB2_B1634              \ [0x02] B1634
    $03 constant GTZC_MPCBB2_B1635              \ [0x03] B1635
    $04 constant GTZC_MPCBB2_B1636              \ [0x04] B1636
    $05 constant GTZC_MPCBB2_B1637              \ [0x05] B1637
    $06 constant GTZC_MPCBB2_B1638              \ [0x06] B1638
    $07 constant GTZC_MPCBB2_B1639              \ [0x07] B1639
    $08 constant GTZC_MPCBB2_B1640              \ [0x08] B1640
    $09 constant GTZC_MPCBB2_B1641              \ [0x09] B1641
    $0a constant GTZC_MPCBB2_B1642              \ [0x0a] B1642
    $0b constant GTZC_MPCBB2_B1643              \ [0x0b] B1643
    $0c constant GTZC_MPCBB2_B1644              \ [0x0c] B1644
    $0d constant GTZC_MPCBB2_B1645              \ [0x0d] B1645
    $0e constant GTZC_MPCBB2_B1646              \ [0x0e] B1646
    $0f constant GTZC_MPCBB2_B1647              \ [0x0f] B1647
    $10 constant GTZC_MPCBB2_B1648              \ [0x10] B1648
    $11 constant GTZC_MPCBB2_B1649              \ [0x11] B1649
    $12 constant GTZC_MPCBB2_B1650              \ [0x12] B1650
    $13 constant GTZC_MPCBB2_B1651              \ [0x13] B1651
    $14 constant GTZC_MPCBB2_B1652              \ [0x14] B1652
    $15 constant GTZC_MPCBB2_B1653              \ [0x15] B1653
    $16 constant GTZC_MPCBB2_B1654              \ [0x16] B1654
    $17 constant GTZC_MPCBB2_B1655              \ [0x17] B1655
    $18 constant GTZC_MPCBB2_B1656              \ [0x18] B1656
    $19 constant GTZC_MPCBB2_B1657              \ [0x19] B1657
    $1a constant GTZC_MPCBB2_B1658              \ [0x1a] B1658
    $1b constant GTZC_MPCBB2_B1659              \ [0x1b] B1659
    $1c constant GTZC_MPCBB2_B1660              \ [0x1c] B1660
    $1d constant GTZC_MPCBB2_B1661              \ [0x1d] B1661
    $1e constant GTZC_MPCBB2_B1662              \ [0x1e] B1662
    $1f constant GTZC_MPCBB2_B1663              \ [0x1f] B1663
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR52_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1D0
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1664              \ [0x00] B1664
    $01 constant GTZC_MPCBB2_B1665              \ [0x01] B1665
    $02 constant GTZC_MPCBB2_B1666              \ [0x02] B1666
    $03 constant GTZC_MPCBB2_B1667              \ [0x03] B1667
    $04 constant GTZC_MPCBB2_B1668              \ [0x04] B1668
    $05 constant GTZC_MPCBB2_B1669              \ [0x05] B1669
    $06 constant GTZC_MPCBB2_B1670              \ [0x06] B1670
    $07 constant GTZC_MPCBB2_B1671              \ [0x07] B1671
    $08 constant GTZC_MPCBB2_B1672              \ [0x08] B1672
    $09 constant GTZC_MPCBB2_B1673              \ [0x09] B1673
    $0a constant GTZC_MPCBB2_B1674              \ [0x0a] B1674
    $0b constant GTZC_MPCBB2_B1675              \ [0x0b] B1675
    $0c constant GTZC_MPCBB2_B1676              \ [0x0c] B1676
    $0d constant GTZC_MPCBB2_B1677              \ [0x0d] B1677
    $0e constant GTZC_MPCBB2_B1678              \ [0x0e] B1678
    $0f constant GTZC_MPCBB2_B1679              \ [0x0f] B1679
    $10 constant GTZC_MPCBB2_B1680              \ [0x10] B1680
    $11 constant GTZC_MPCBB2_B1681              \ [0x11] B1681
    $12 constant GTZC_MPCBB2_B1682              \ [0x12] B1682
    $13 constant GTZC_MPCBB2_B1683              \ [0x13] B1683
    $14 constant GTZC_MPCBB2_B1684              \ [0x14] B1684
    $15 constant GTZC_MPCBB2_B1685              \ [0x15] B1685
    $16 constant GTZC_MPCBB2_B1686              \ [0x16] B1686
    $17 constant GTZC_MPCBB2_B1687              \ [0x17] B1687
    $18 constant GTZC_MPCBB2_B1688              \ [0x18] B1688
    $19 constant GTZC_MPCBB2_B1689              \ [0x19] B1689
    $1a constant GTZC_MPCBB2_B1690              \ [0x1a] B1690
    $1b constant GTZC_MPCBB2_B1691              \ [0x1b] B1691
    $1c constant GTZC_MPCBB2_B1692              \ [0x1c] B1692
    $1d constant GTZC_MPCBB2_B1693              \ [0x1d] B1693
    $1e constant GTZC_MPCBB2_B1694              \ [0x1e] B1694
    $1f constant GTZC_MPCBB2_B1695              \ [0x1f] B1695
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR53_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1D4
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1696              \ [0x00] B1696
    $01 constant GTZC_MPCBB2_B1697              \ [0x01] B1697
    $02 constant GTZC_MPCBB2_B1698              \ [0x02] B1698
    $03 constant GTZC_MPCBB2_B1699              \ [0x03] B1699
    $04 constant GTZC_MPCBB2_B1700              \ [0x04] B1700
    $05 constant GTZC_MPCBB2_B1701              \ [0x05] B1701
    $06 constant GTZC_MPCBB2_B1702              \ [0x06] B1702
    $07 constant GTZC_MPCBB2_B1703              \ [0x07] B1703
    $08 constant GTZC_MPCBB2_B1704              \ [0x08] B1704
    $09 constant GTZC_MPCBB2_B1705              \ [0x09] B1705
    $0a constant GTZC_MPCBB2_B1706              \ [0x0a] B1706
    $0b constant GTZC_MPCBB2_B1707              \ [0x0b] B1707
    $0c constant GTZC_MPCBB2_B1708              \ [0x0c] B1708
    $0d constant GTZC_MPCBB2_B1709              \ [0x0d] B1709
    $0e constant GTZC_MPCBB2_B1710              \ [0x0e] B1710
    $0f constant GTZC_MPCBB2_B1711              \ [0x0f] B1711
    $10 constant GTZC_MPCBB2_B1712              \ [0x10] B1712
    $11 constant GTZC_MPCBB2_B1713              \ [0x11] B1713
    $12 constant GTZC_MPCBB2_B1714              \ [0x12] B1714
    $13 constant GTZC_MPCBB2_B1715              \ [0x13] B1715
    $14 constant GTZC_MPCBB2_B1716              \ [0x14] B1716
    $15 constant GTZC_MPCBB2_B1717              \ [0x15] B1717
    $16 constant GTZC_MPCBB2_B1718              \ [0x16] B1718
    $17 constant GTZC_MPCBB2_B1719              \ [0x17] B1719
    $18 constant GTZC_MPCBB2_B1720              \ [0x18] B1720
    $19 constant GTZC_MPCBB2_B1721              \ [0x19] B1721
    $1a constant GTZC_MPCBB2_B1722              \ [0x1a] B1722
    $1b constant GTZC_MPCBB2_B1723              \ [0x1b] B1723
    $1c constant GTZC_MPCBB2_B1724              \ [0x1c] B1724
    $1d constant GTZC_MPCBB2_B1725              \ [0x1d] B1725
    $1e constant GTZC_MPCBB2_B1726              \ [0x1e] B1726
    $1f constant GTZC_MPCBB2_B1727              \ [0x1f] B1727
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR54_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1D8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1728              \ [0x00] B1728
    $01 constant GTZC_MPCBB2_B1729              \ [0x01] B1729
    $02 constant GTZC_MPCBB2_B1730              \ [0x02] B1730
    $03 constant GTZC_MPCBB2_B1731              \ [0x03] B1731
    $04 constant GTZC_MPCBB2_B1732              \ [0x04] B1732
    $05 constant GTZC_MPCBB2_B1733              \ [0x05] B1733
    $06 constant GTZC_MPCBB2_B1734              \ [0x06] B1734
    $07 constant GTZC_MPCBB2_B1735              \ [0x07] B1735
    $08 constant GTZC_MPCBB2_B1736              \ [0x08] B1736
    $09 constant GTZC_MPCBB2_B1737              \ [0x09] B1737
    $0a constant GTZC_MPCBB2_B1738              \ [0x0a] B1738
    $0b constant GTZC_MPCBB2_B1739              \ [0x0b] B1739
    $0c constant GTZC_MPCBB2_B1740              \ [0x0c] B1740
    $0d constant GTZC_MPCBB2_B1741              \ [0x0d] B1741
    $0e constant GTZC_MPCBB2_B1742              \ [0x0e] B1742
    $0f constant GTZC_MPCBB2_B1743              \ [0x0f] B1743
    $10 constant GTZC_MPCBB2_B1744              \ [0x10] B1744
    $11 constant GTZC_MPCBB2_B1745              \ [0x11] B1745
    $12 constant GTZC_MPCBB2_B1746              \ [0x12] B1746
    $13 constant GTZC_MPCBB2_B1747              \ [0x13] B1747
    $14 constant GTZC_MPCBB2_B1748              \ [0x14] B1748
    $15 constant GTZC_MPCBB2_B1749              \ [0x15] B1749
    $16 constant GTZC_MPCBB2_B1750              \ [0x16] B1750
    $17 constant GTZC_MPCBB2_B1751              \ [0x17] B1751
    $18 constant GTZC_MPCBB2_B1752              \ [0x18] B1752
    $19 constant GTZC_MPCBB2_B1753              \ [0x19] B1753
    $1a constant GTZC_MPCBB2_B1754              \ [0x1a] B1754
    $1b constant GTZC_MPCBB2_B1755              \ [0x1b] B1755
    $1c constant GTZC_MPCBB2_B1756              \ [0x1c] B1756
    $1d constant GTZC_MPCBB2_B1757              \ [0x1d] B1757
    $1e constant GTZC_MPCBB2_B1758              \ [0x1e] B1758
    $1f constant GTZC_MPCBB2_B1759              \ [0x1f] B1759
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR55_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1DC
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1760              \ [0x00] B1760
    $01 constant GTZC_MPCBB2_B1761              \ [0x01] B1761
    $02 constant GTZC_MPCBB2_B1762              \ [0x02] B1762
    $03 constant GTZC_MPCBB2_B1763              \ [0x03] B1763
    $04 constant GTZC_MPCBB2_B1764              \ [0x04] B1764
    $05 constant GTZC_MPCBB2_B1765              \ [0x05] B1765
    $06 constant GTZC_MPCBB2_B1766              \ [0x06] B1766
    $07 constant GTZC_MPCBB2_B1767              \ [0x07] B1767
    $08 constant GTZC_MPCBB2_B1768              \ [0x08] B1768
    $09 constant GTZC_MPCBB2_B1769              \ [0x09] B1769
    $0a constant GTZC_MPCBB2_B1770              \ [0x0a] B1770
    $0b constant GTZC_MPCBB2_B1771              \ [0x0b] B1771
    $0c constant GTZC_MPCBB2_B1772              \ [0x0c] B1772
    $0d constant GTZC_MPCBB2_B1773              \ [0x0d] B1773
    $0e constant GTZC_MPCBB2_B1774              \ [0x0e] B1774
    $0f constant GTZC_MPCBB2_B1775              \ [0x0f] B1775
    $10 constant GTZC_MPCBB2_B1776              \ [0x10] B1776
    $11 constant GTZC_MPCBB2_B1777              \ [0x11] B1777
    $12 constant GTZC_MPCBB2_B1778              \ [0x12] B1778
    $13 constant GTZC_MPCBB2_B1779              \ [0x13] B1779
    $14 constant GTZC_MPCBB2_B1780              \ [0x14] B1780
    $15 constant GTZC_MPCBB2_B1781              \ [0x15] B1781
    $16 constant GTZC_MPCBB2_B1782              \ [0x16] B1782
    $17 constant GTZC_MPCBB2_B1783              \ [0x17] B1783
    $18 constant GTZC_MPCBB2_B1784              \ [0x18] B1784
    $19 constant GTZC_MPCBB2_B1785              \ [0x19] B1785
    $1a constant GTZC_MPCBB2_B1786              \ [0x1a] B1786
    $1b constant GTZC_MPCBB2_B1787              \ [0x1b] B1787
    $1c constant GTZC_MPCBB2_B1788              \ [0x1c] B1788
    $1d constant GTZC_MPCBB2_B1789              \ [0x1d] B1789
    $1e constant GTZC_MPCBB2_B1790              \ [0x1e] B1790
    $1f constant GTZC_MPCBB2_B1791              \ [0x1f] B1791
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR56_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1E0
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1792              \ [0x00] B1792
    $01 constant GTZC_MPCBB2_B1793              \ [0x01] B1793
    $02 constant GTZC_MPCBB2_B1794              \ [0x02] B1794
    $03 constant GTZC_MPCBB2_B1795              \ [0x03] B1795
    $04 constant GTZC_MPCBB2_B1796              \ [0x04] B1796
    $05 constant GTZC_MPCBB2_B1797              \ [0x05] B1797
    $06 constant GTZC_MPCBB2_B1798              \ [0x06] B1798
    $07 constant GTZC_MPCBB2_B1799              \ [0x07] B1799
    $08 constant GTZC_MPCBB2_B1800              \ [0x08] B1800
    $09 constant GTZC_MPCBB2_B1801              \ [0x09] B1801
    $0a constant GTZC_MPCBB2_B1802              \ [0x0a] B1802
    $0b constant GTZC_MPCBB2_B1803              \ [0x0b] B1803
    $0c constant GTZC_MPCBB2_B1804              \ [0x0c] B1804
    $0d constant GTZC_MPCBB2_B1805              \ [0x0d] B1805
    $0e constant GTZC_MPCBB2_B1806              \ [0x0e] B1806
    $0f constant GTZC_MPCBB2_B1807              \ [0x0f] B1807
    $10 constant GTZC_MPCBB2_B1808              \ [0x10] B1808
    $11 constant GTZC_MPCBB2_B1809              \ [0x11] B1809
    $12 constant GTZC_MPCBB2_B1810              \ [0x12] B1810
    $13 constant GTZC_MPCBB2_B1811              \ [0x13] B1811
    $14 constant GTZC_MPCBB2_B1812              \ [0x14] B1812
    $15 constant GTZC_MPCBB2_B1813              \ [0x15] B1813
    $16 constant GTZC_MPCBB2_B1814              \ [0x16] B1814
    $17 constant GTZC_MPCBB2_B1815              \ [0x17] B1815
    $18 constant GTZC_MPCBB2_B1816              \ [0x18] B1816
    $19 constant GTZC_MPCBB2_B1817              \ [0x19] B1817
    $1a constant GTZC_MPCBB2_B1818              \ [0x1a] B1818
    $1b constant GTZC_MPCBB2_B1819              \ [0x1b] B1819
    $1c constant GTZC_MPCBB2_B1820              \ [0x1c] B1820
    $1d constant GTZC_MPCBB2_B1821              \ [0x1d] B1821
    $1e constant GTZC_MPCBB2_B1822              \ [0x1e] B1822
    $1f constant GTZC_MPCBB2_B1823              \ [0x1f] B1823
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR57_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1E4
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1824              \ [0x00] B1824
    $01 constant GTZC_MPCBB2_B1825              \ [0x01] B1825
    $02 constant GTZC_MPCBB2_B1826              \ [0x02] B1826
    $03 constant GTZC_MPCBB2_B1827              \ [0x03] B1827
    $04 constant GTZC_MPCBB2_B1828              \ [0x04] B1828
    $05 constant GTZC_MPCBB2_B1829              \ [0x05] B1829
    $06 constant GTZC_MPCBB2_B1830              \ [0x06] B1830
    $07 constant GTZC_MPCBB2_B1831              \ [0x07] B1831
    $08 constant GTZC_MPCBB2_B1832              \ [0x08] B1832
    $09 constant GTZC_MPCBB2_B1833              \ [0x09] B1833
    $0a constant GTZC_MPCBB2_B1834              \ [0x0a] B1834
    $0b constant GTZC_MPCBB2_B1835              \ [0x0b] B1835
    $0c constant GTZC_MPCBB2_B1836              \ [0x0c] B1836
    $0d constant GTZC_MPCBB2_B1837              \ [0x0d] B1837
    $0e constant GTZC_MPCBB2_B1838              \ [0x0e] B1838
    $0f constant GTZC_MPCBB2_B1839              \ [0x0f] B1839
    $10 constant GTZC_MPCBB2_B1840              \ [0x10] B1840
    $11 constant GTZC_MPCBB2_B1841              \ [0x11] B1841
    $12 constant GTZC_MPCBB2_B1842              \ [0x12] B1842
    $13 constant GTZC_MPCBB2_B1843              \ [0x13] B1843
    $14 constant GTZC_MPCBB2_B1844              \ [0x14] B1844
    $15 constant GTZC_MPCBB2_B1845              \ [0x15] B1845
    $16 constant GTZC_MPCBB2_B1846              \ [0x16] B1846
    $17 constant GTZC_MPCBB2_B1847              \ [0x17] B1847
    $18 constant GTZC_MPCBB2_B1848              \ [0x18] B1848
    $19 constant GTZC_MPCBB2_B1849              \ [0x19] B1849
    $1a constant GTZC_MPCBB2_B1850              \ [0x1a] B1850
    $1b constant GTZC_MPCBB2_B1851              \ [0x1b] B1851
    $1c constant GTZC_MPCBB2_B1852              \ [0x1c] B1852
    $1d constant GTZC_MPCBB2_B1853              \ [0x1d] B1853
    $1e constant GTZC_MPCBB2_B1854              \ [0x1e] B1854
    $1f constant GTZC_MPCBB2_B1855              \ [0x1f] B1855
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR58_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1E8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1856              \ [0x00] B1856
    $01 constant GTZC_MPCBB2_B1857              \ [0x01] B1857
    $02 constant GTZC_MPCBB2_B1858              \ [0x02] B1858
    $03 constant GTZC_MPCBB2_B1859              \ [0x03] B1859
    $04 constant GTZC_MPCBB2_B1860              \ [0x04] B1860
    $05 constant GTZC_MPCBB2_B1861              \ [0x05] B1861
    $06 constant GTZC_MPCBB2_B1862              \ [0x06] B1862
    $07 constant GTZC_MPCBB2_B1863              \ [0x07] B1863
    $08 constant GTZC_MPCBB2_B1864              \ [0x08] B1864
    $09 constant GTZC_MPCBB2_B1865              \ [0x09] B1865
    $0a constant GTZC_MPCBB2_B1866              \ [0x0a] B1866
    $0b constant GTZC_MPCBB2_B1867              \ [0x0b] B1867
    $0c constant GTZC_MPCBB2_B1868              \ [0x0c] B1868
    $0d constant GTZC_MPCBB2_B1869              \ [0x0d] B1869
    $0e constant GTZC_MPCBB2_B1870              \ [0x0e] B1870
    $0f constant GTZC_MPCBB2_B1871              \ [0x0f] B1871
    $10 constant GTZC_MPCBB2_B1872              \ [0x10] B1872
    $11 constant GTZC_MPCBB2_B1873              \ [0x11] B1873
    $12 constant GTZC_MPCBB2_B1874              \ [0x12] B1874
    $13 constant GTZC_MPCBB2_B1875              \ [0x13] B1875
    $14 constant GTZC_MPCBB2_B1876              \ [0x14] B1876
    $15 constant GTZC_MPCBB2_B1877              \ [0x15] B1877
    $16 constant GTZC_MPCBB2_B1878              \ [0x16] B1878
    $17 constant GTZC_MPCBB2_B1879              \ [0x17] B1879
    $18 constant GTZC_MPCBB2_B1880              \ [0x18] B1880
    $19 constant GTZC_MPCBB2_B1881              \ [0x19] B1881
    $1a constant GTZC_MPCBB2_B1882              \ [0x1a] B1882
    $1b constant GTZC_MPCBB2_B1883              \ [0x1b] B1883
    $1c constant GTZC_MPCBB2_B1884              \ [0x1c] B1884
    $1d constant GTZC_MPCBB2_B1885              \ [0x1d] B1885
    $1e constant GTZC_MPCBB2_B1886              \ [0x1e] B1886
    $1f constant GTZC_MPCBB2_B1887              \ [0x1f] B1887
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR59_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1EC
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1888              \ [0x00] B1888
    $01 constant GTZC_MPCBB2_B1889              \ [0x01] B1889
    $02 constant GTZC_MPCBB2_B1890              \ [0x02] B1890
    $03 constant GTZC_MPCBB2_B1891              \ [0x03] B1891
    $04 constant GTZC_MPCBB2_B1892              \ [0x04] B1892
    $05 constant GTZC_MPCBB2_B1893              \ [0x05] B1893
    $06 constant GTZC_MPCBB2_B1894              \ [0x06] B1894
    $07 constant GTZC_MPCBB2_B1895              \ [0x07] B1895
    $08 constant GTZC_MPCBB2_B1896              \ [0x08] B1896
    $09 constant GTZC_MPCBB2_B1897              \ [0x09] B1897
    $0a constant GTZC_MPCBB2_B1898              \ [0x0a] B1898
    $0b constant GTZC_MPCBB2_B1899              \ [0x0b] B1899
    $0c constant GTZC_MPCBB2_B1900              \ [0x0c] B1900
    $0d constant GTZC_MPCBB2_B1901              \ [0x0d] B1901
    $0e constant GTZC_MPCBB2_B1902              \ [0x0e] B1902
    $0f constant GTZC_MPCBB2_B1903              \ [0x0f] B1903
    $10 constant GTZC_MPCBB2_B1904              \ [0x10] B1904
    $11 constant GTZC_MPCBB2_B1905              \ [0x11] B1905
    $12 constant GTZC_MPCBB2_B1906              \ [0x12] B1906
    $13 constant GTZC_MPCBB2_B1907              \ [0x13] B1907
    $14 constant GTZC_MPCBB2_B1908              \ [0x14] B1908
    $15 constant GTZC_MPCBB2_B1909              \ [0x15] B1909
    $16 constant GTZC_MPCBB2_B1910              \ [0x16] B1910
    $17 constant GTZC_MPCBB2_B1911              \ [0x17] B1911
    $18 constant GTZC_MPCBB2_B1912              \ [0x18] B1912
    $19 constant GTZC_MPCBB2_B1913              \ [0x19] B1913
    $1a constant GTZC_MPCBB2_B1914              \ [0x1a] B1914
    $1b constant GTZC_MPCBB2_B1915              \ [0x1b] B1915
    $1c constant GTZC_MPCBB2_B1916              \ [0x1c] B1916
    $1d constant GTZC_MPCBB2_B1917              \ [0x1d] B1917
    $1e constant GTZC_MPCBB2_B1918              \ [0x1e] B1918
    $1f constant GTZC_MPCBB2_B1919              \ [0x1f] B1919
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR60_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1F0
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1920              \ [0x00] B1920
    $01 constant GTZC_MPCBB2_B1921              \ [0x01] B1921
    $02 constant GTZC_MPCBB2_B1922              \ [0x02] B1922
    $03 constant GTZC_MPCBB2_B1923              \ [0x03] B1923
    $04 constant GTZC_MPCBB2_B1924              \ [0x04] B1924
    $05 constant GTZC_MPCBB2_B1925              \ [0x05] B1925
    $06 constant GTZC_MPCBB2_B1926              \ [0x06] B1926
    $07 constant GTZC_MPCBB2_B1927              \ [0x07] B1927
    $08 constant GTZC_MPCBB2_B1928              \ [0x08] B1928
    $09 constant GTZC_MPCBB2_B1929              \ [0x09] B1929
    $0a constant GTZC_MPCBB2_B1930              \ [0x0a] B1930
    $0b constant GTZC_MPCBB2_B1931              \ [0x0b] B1931
    $0c constant GTZC_MPCBB2_B1932              \ [0x0c] B1932
    $0d constant GTZC_MPCBB2_B1933              \ [0x0d] B1933
    $0e constant GTZC_MPCBB2_B1934              \ [0x0e] B1934
    $0f constant GTZC_MPCBB2_B1935              \ [0x0f] B1935
    $10 constant GTZC_MPCBB2_B1936              \ [0x10] B1936
    $11 constant GTZC_MPCBB2_B1937              \ [0x11] B1937
    $12 constant GTZC_MPCBB2_B1938              \ [0x12] B1938
    $13 constant GTZC_MPCBB2_B1939              \ [0x13] B1939
    $14 constant GTZC_MPCBB2_B1940              \ [0x14] B1940
    $15 constant GTZC_MPCBB2_B1941              \ [0x15] B1941
    $16 constant GTZC_MPCBB2_B1942              \ [0x16] B1942
    $17 constant GTZC_MPCBB2_B1943              \ [0x17] B1943
    $18 constant GTZC_MPCBB2_B1944              \ [0x18] B1944
    $19 constant GTZC_MPCBB2_B1945              \ [0x19] B1945
    $1a constant GTZC_MPCBB2_B1946              \ [0x1a] B1946
    $1b constant GTZC_MPCBB2_B1947              \ [0x1b] B1947
    $1c constant GTZC_MPCBB2_B1948              \ [0x1c] B1948
    $1d constant GTZC_MPCBB2_B1949              \ [0x1d] B1949
    $1e constant GTZC_MPCBB2_B1950              \ [0x1e] B1950
    $1f constant GTZC_MPCBB2_B1951              \ [0x1f] B1951
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR61_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1F4
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1952              \ [0x00] B1952
    $01 constant GTZC_MPCBB2_B1953              \ [0x01] B1953
    $02 constant GTZC_MPCBB2_B1954              \ [0x02] B1954
    $03 constant GTZC_MPCBB2_B1955              \ [0x03] B1955
    $04 constant GTZC_MPCBB2_B1956              \ [0x04] B1956
    $05 constant GTZC_MPCBB2_B1957              \ [0x05] B1957
    $06 constant GTZC_MPCBB2_B1958              \ [0x06] B1958
    $07 constant GTZC_MPCBB2_B1959              \ [0x07] B1959
    $08 constant GTZC_MPCBB2_B1960              \ [0x08] B1960
    $09 constant GTZC_MPCBB2_B1961              \ [0x09] B1961
    $0a constant GTZC_MPCBB2_B1962              \ [0x0a] B1962
    $0b constant GTZC_MPCBB2_B1963              \ [0x0b] B1963
    $0c constant GTZC_MPCBB2_B1964              \ [0x0c] B1964
    $0d constant GTZC_MPCBB2_B1965              \ [0x0d] B1965
    $0e constant GTZC_MPCBB2_B1966              \ [0x0e] B1966
    $0f constant GTZC_MPCBB2_B1967              \ [0x0f] B1967
    $10 constant GTZC_MPCBB2_B1968              \ [0x10] B1968
    $11 constant GTZC_MPCBB2_B1969              \ [0x11] B1969
    $12 constant GTZC_MPCBB2_B1970              \ [0x12] B1970
    $13 constant GTZC_MPCBB2_B1971              \ [0x13] B1971
    $14 constant GTZC_MPCBB2_B1972              \ [0x14] B1972
    $15 constant GTZC_MPCBB2_B1973              \ [0x15] B1973
    $16 constant GTZC_MPCBB2_B1974              \ [0x16] B1974
    $17 constant GTZC_MPCBB2_B1975              \ [0x17] B1975
    $18 constant GTZC_MPCBB2_B1976              \ [0x18] B1976
    $19 constant GTZC_MPCBB2_B1977              \ [0x19] B1977
    $1a constant GTZC_MPCBB2_B1978              \ [0x1a] B1978
    $1b constant GTZC_MPCBB2_B1979              \ [0x1b] B1979
    $1c constant GTZC_MPCBB2_B1980              \ [0x1c] B1980
    $1d constant GTZC_MPCBB2_B1981              \ [0x1d] B1981
    $1e constant GTZC_MPCBB2_B1982              \ [0x1e] B1982
    $1f constant GTZC_MPCBB2_B1983              \ [0x1f] B1983
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR62_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1F8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B1984              \ [0x00] B1984
    $01 constant GTZC_MPCBB2_B1985              \ [0x01] B1985
    $02 constant GTZC_MPCBB2_B1986              \ [0x02] B1986
    $03 constant GTZC_MPCBB2_B1987              \ [0x03] B1987
    $04 constant GTZC_MPCBB2_B1988              \ [0x04] B1988
    $05 constant GTZC_MPCBB2_B1989              \ [0x05] B1989
    $06 constant GTZC_MPCBB2_B1990              \ [0x06] B1990
    $07 constant GTZC_MPCBB2_B1991              \ [0x07] B1991
    $08 constant GTZC_MPCBB2_B1992              \ [0x08] B1992
    $09 constant GTZC_MPCBB2_B1993              \ [0x09] B1993
    $0a constant GTZC_MPCBB2_B1994              \ [0x0a] B1994
    $0b constant GTZC_MPCBB2_B1995              \ [0x0b] B1995
    $0c constant GTZC_MPCBB2_B1996              \ [0x0c] B1996
    $0d constant GTZC_MPCBB2_B1997              \ [0x0d] B1997
    $0e constant GTZC_MPCBB2_B1998              \ [0x0e] B1998
    $0f constant GTZC_MPCBB2_B1999              \ [0x0f] B1999
    $10 constant GTZC_MPCBB2_B2000              \ [0x10] B2000
    $11 constant GTZC_MPCBB2_B2001              \ [0x11] B2001
    $12 constant GTZC_MPCBB2_B2002              \ [0x12] B2002
    $13 constant GTZC_MPCBB2_B2003              \ [0x13] B2003
    $14 constant GTZC_MPCBB2_B2004              \ [0x14] B2004
    $15 constant GTZC_MPCBB2_B2005              \ [0x15] B2005
    $16 constant GTZC_MPCBB2_B2006              \ [0x16] B2006
    $17 constant GTZC_MPCBB2_B2007              \ [0x17] B2007
    $18 constant GTZC_MPCBB2_B2008              \ [0x18] B2008
    $19 constant GTZC_MPCBB2_B2009              \ [0x19] B2009
    $1a constant GTZC_MPCBB2_B2010              \ [0x1a] B2010
    $1b constant GTZC_MPCBB2_B2011              \ [0x1b] B2011
    $1c constant GTZC_MPCBB2_B2012              \ [0x1c] B2012
    $1d constant GTZC_MPCBB2_B2013              \ [0x1d] B2013
    $1e constant GTZC_MPCBB2_B2014              \ [0x1e] B2014
    $1f constant GTZC_MPCBB2_B2015              \ [0x1f] B2015
  [then]


  [ifdef] GTZC_MPCBB2_MPCBB2_VCTR63_DEF
    \
    \ @brief MPCBBx vector register
    \ Address offset: 0x1FC
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GTZC_MPCBB2_B2016              \ [0x00] B2016
    $01 constant GTZC_MPCBB2_B2017              \ [0x01] B2017
    $02 constant GTZC_MPCBB2_B2018              \ [0x02] B2018
    $03 constant GTZC_MPCBB2_B2019              \ [0x03] B2019
    $04 constant GTZC_MPCBB2_B2020              \ [0x04] B2020
    $05 constant GTZC_MPCBB2_B2021              \ [0x05] B2021
    $06 constant GTZC_MPCBB2_B2022              \ [0x06] B2022
    $07 constant GTZC_MPCBB2_B2023              \ [0x07] B2023
    $08 constant GTZC_MPCBB2_B2024              \ [0x08] B2024
    $09 constant GTZC_MPCBB2_B2025              \ [0x09] B2025
    $0a constant GTZC_MPCBB2_B2026              \ [0x0a] B2026
    $0b constant GTZC_MPCBB2_B2027              \ [0x0b] B2027
    $0c constant GTZC_MPCBB2_B2028              \ [0x0c] B2028
    $0d constant GTZC_MPCBB2_B2029              \ [0x0d] B2029
    $0e constant GTZC_MPCBB2_B2030              \ [0x0e] B2030
    $0f constant GTZC_MPCBB2_B2031              \ [0x0f] B2031
    $10 constant GTZC_MPCBB2_B2032              \ [0x10] B2032
    $11 constant GTZC_MPCBB2_B2033              \ [0x11] B2033
    $12 constant GTZC_MPCBB2_B2034              \ [0x12] B2034
    $13 constant GTZC_MPCBB2_B2035              \ [0x13] B2035
    $14 constant GTZC_MPCBB2_B2036              \ [0x14] B2036
    $15 constant GTZC_MPCBB2_B2037              \ [0x15] B2037
    $16 constant GTZC_MPCBB2_B2038              \ [0x16] B2038
    $17 constant GTZC_MPCBB2_B2039              \ [0x17] B2039
    $18 constant GTZC_MPCBB2_B2040              \ [0x18] B2040
    $19 constant GTZC_MPCBB2_B2041              \ [0x19] B2041
    $1a constant GTZC_MPCBB2_B2042              \ [0x1a] B2042
    $1b constant GTZC_MPCBB2_B2043              \ [0x1b] B2043
    $1c constant GTZC_MPCBB2_B2044              \ [0x1c] B2044
    $1d constant GTZC_MPCBB2_B2045              \ [0x1d] B2045
    $1e constant GTZC_MPCBB2_B2046              \ [0x1e] B2046
    $1f constant GTZC_MPCBB2_B2047              \ [0x1f] B2047
  [then]

  \
  \ @brief GTZC_MPCBB2
  \
  $00 constant GTZC_MPCBB2_MPCBB2_CR    \ MPCBB control register
  $10 constant GTZC_MPCBB2_MPCBB2_LCKVTR1    \ MPCBB control register
  $14 constant GTZC_MPCBB2_MPCBB2_LCKVTR2    \ MPCBB control register
  $100 constant GTZC_MPCBB2_MPCBB2_VCTR0    \ MPCBBx vector register
  $104 constant GTZC_MPCBB2_MPCBB2_VCTR1    \ MPCBBx vector register
  $108 constant GTZC_MPCBB2_MPCBB2_VCTR2    \ MPCBBx vector register
  $10C constant GTZC_MPCBB2_MPCBB2_VCTR3    \ MPCBBx vector register
  $110 constant GTZC_MPCBB2_MPCBB2_VCTR4    \ MPCBBx vector register
  $114 constant GTZC_MPCBB2_MPCBB2_VCTR5    \ MPCBBx vector register
  $118 constant GTZC_MPCBB2_MPCBB2_VCTR6    \ MPCBBx vector register
  $11C constant GTZC_MPCBB2_MPCBB2_VCTR7    \ MPCBBx vector register
  $120 constant GTZC_MPCBB2_MPCBB2_VCTR8    \ MPCBBx vector register
  $124 constant GTZC_MPCBB2_MPCBB2_VCTR9    \ MPCBBx vector register
  $128 constant GTZC_MPCBB2_MPCBB2_VCTR10    \ MPCBBx vector register
  $12C constant GTZC_MPCBB2_MPCBB2_VCTR11    \ MPCBBx vector register
  $130 constant GTZC_MPCBB2_MPCBB2_VCTR12    \ MPCBBx vector register
  $134 constant GTZC_MPCBB2_MPCBB2_VCTR13    \ MPCBBx vector register
  $138 constant GTZC_MPCBB2_MPCBB2_VCTR14    \ MPCBBx vector register
  $13C constant GTZC_MPCBB2_MPCBB2_VCTR15    \ MPCBBx vector register
  $140 constant GTZC_MPCBB2_MPCBB2_VCTR16    \ MPCBBx vector register
  $144 constant GTZC_MPCBB2_MPCBB2_VCTR17    \ MPCBBx vector register
  $148 constant GTZC_MPCBB2_MPCBB2_VCTR18    \ MPCBBx vector register
  $14C constant GTZC_MPCBB2_MPCBB2_VCTR19    \ MPCBBx vector register
  $150 constant GTZC_MPCBB2_MPCBB2_VCTR20    \ MPCBBx vector register
  $154 constant GTZC_MPCBB2_MPCBB2_VCTR21    \ MPCBBx vector register
  $158 constant GTZC_MPCBB2_MPCBB2_VCTR22    \ MPCBBx vector register
  $15C constant GTZC_MPCBB2_MPCBB2_VCTR23    \ MPCBBx vector register
  $160 constant GTZC_MPCBB2_MPCBB2_VCTR24    \ MPCBBx vector register
  $164 constant GTZC_MPCBB2_MPCBB2_VCTR25    \ MPCBBx vector register
  $168 constant GTZC_MPCBB2_MPCBB2_VCTR26    \ MPCBBx vector register
  $16C constant GTZC_MPCBB2_MPCBB2_VCTR27    \ MPCBBx vector register
  $170 constant GTZC_MPCBB2_MPCBB2_VCTR28    \ MPCBBx vector register
  $174 constant GTZC_MPCBB2_MPCBB2_VCTR29    \ MPCBBx vector register
  $178 constant GTZC_MPCBB2_MPCBB2_VCTR30    \ MPCBBx vector register
  $17C constant GTZC_MPCBB2_MPCBB2_VCTR31    \ MPCBBx vector register
  $180 constant GTZC_MPCBB2_MPCBB2_VCTR32    \ MPCBBx vector register
  $184 constant GTZC_MPCBB2_MPCBB2_VCTR33    \ MPCBBx vector register
  $188 constant GTZC_MPCBB2_MPCBB2_VCTR34    \ MPCBBx vector register
  $18C constant GTZC_MPCBB2_MPCBB2_VCTR35    \ MPCBBx vector register
  $190 constant GTZC_MPCBB2_MPCBB2_VCTR36    \ MPCBBx vector register
  $194 constant GTZC_MPCBB2_MPCBB2_VCTR37    \ MPCBBx vector register
  $198 constant GTZC_MPCBB2_MPCBB2_VCTR38    \ MPCBBx vector register
  $19C constant GTZC_MPCBB2_MPCBB2_VCTR39    \ MPCBBx vector register
  $1A0 constant GTZC_MPCBB2_MPCBB2_VCTR40    \ MPCBBx vector register
  $1A4 constant GTZC_MPCBB2_MPCBB2_VCTR41    \ MPCBBx vector register
  $1A8 constant GTZC_MPCBB2_MPCBB2_VCTR42    \ MPCBBx vector register
  $1AC constant GTZC_MPCBB2_MPCBB2_VCTR43    \ MPCBBx vector register
  $1B0 constant GTZC_MPCBB2_MPCBB2_VCTR44    \ MPCBBx vector register
  $1B4 constant GTZC_MPCBB2_MPCBB2_VCTR45    \ MPCBBx vector register
  $1B8 constant GTZC_MPCBB2_MPCBB2_VCTR46    \ MPCBBx vector register
  $1BC constant GTZC_MPCBB2_MPCBB2_VCTR47    \ MPCBBx vector register
  $1C0 constant GTZC_MPCBB2_MPCBB2_VCTR48    \ MPCBBx vector register
  $1C4 constant GTZC_MPCBB2_MPCBB2_VCTR49    \ MPCBBx vector register
  $1C8 constant GTZC_MPCBB2_MPCBB2_VCTR50    \ MPCBBx vector register
  $1CC constant GTZC_MPCBB2_MPCBB2_VCTR51    \ MPCBBx vector register
  $1D0 constant GTZC_MPCBB2_MPCBB2_VCTR52    \ MPCBBx vector register
  $1D4 constant GTZC_MPCBB2_MPCBB2_VCTR53    \ MPCBBx vector register
  $1D8 constant GTZC_MPCBB2_MPCBB2_VCTR54    \ MPCBBx vector register
  $1DC constant GTZC_MPCBB2_MPCBB2_VCTR55    \ MPCBBx vector register
  $1E0 constant GTZC_MPCBB2_MPCBB2_VCTR56    \ MPCBBx vector register
  $1E4 constant GTZC_MPCBB2_MPCBB2_VCTR57    \ MPCBBx vector register
  $1E8 constant GTZC_MPCBB2_MPCBB2_VCTR58    \ MPCBBx vector register
  $1EC constant GTZC_MPCBB2_MPCBB2_VCTR59    \ MPCBBx vector register
  $1F0 constant GTZC_MPCBB2_MPCBB2_VCTR60    \ MPCBBx vector register
  $1F4 constant GTZC_MPCBB2_MPCBB2_VCTR61    \ MPCBBx vector register
  $1F8 constant GTZC_MPCBB2_MPCBB2_VCTR62    \ MPCBBx vector register
  $1FC constant GTZC_MPCBB2_MPCBB2_VCTR63    \ MPCBBx vector register

: GTZC_MPCBB2_DEF ; [then]
