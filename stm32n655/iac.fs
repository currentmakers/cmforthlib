\
\ @file iac.fs
\ @brief Illegal access controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] IAC_DEF

  [ifdef] IAC_IAC_IER0_DEF
    \
    \ @brief IAC interrupt enable register 0
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant IAC_IAIE0                      \ [0x00] illegal access interrupt enable for peripheral 0
    $01 constant IAC_IAIE1                      \ [0x01] illegal access interrupt enable for peripheral 1
    $02 constant IAC_IAIE2                      \ [0x02] illegal access interrupt enable for peripheral 2
    $03 constant IAC_IAIE3                      \ [0x03] illegal access interrupt enable for peripheral 3
    $04 constant IAC_IAIE4                      \ [0x04] illegal access interrupt enable for peripheral 4
    $05 constant IAC_IAIE5                      \ [0x05] illegal access interrupt enable for peripheral 5
    $06 constant IAC_IAIE6                      \ [0x06] illegal access interrupt enable for peripheral 6
    $07 constant IAC_IAIE7                      \ [0x07] illegal access interrupt enable for peripheral 7
    $08 constant IAC_IAIE8                      \ [0x08] illegal access interrupt enable for peripheral 8
    $09 constant IAC_IAIE9                      \ [0x09] illegal access interrupt enable for peripheral 9
    $0a constant IAC_IAIE10                     \ [0x0a] illegal access interrupt enable for peripheral 10
    $0b constant IAC_IAIE11                     \ [0x0b] illegal access interrupt enable for peripheral 11
    $0c constant IAC_IAIE12                     \ [0x0c] illegal access interrupt enable for peripheral 12
    $0d constant IAC_IAIE13                     \ [0x0d] illegal access interrupt enable for peripheral 13
    $0e constant IAC_IAIE14                     \ [0x0e] illegal access interrupt enable for peripheral 14
    $0f constant IAC_IAIE15                     \ [0x0f] illegal access interrupt enable for peripheral 15
    $10 constant IAC_IAIE16                     \ [0x10] illegal access interrupt enable for peripheral 16
    $11 constant IAC_IAIE17                     \ [0x11] illegal access interrupt enable for peripheral 17
    $12 constant IAC_IAIE18                     \ [0x12] illegal access interrupt enable for peripheral 18
    $13 constant IAC_IAIE19                     \ [0x13] illegal access interrupt enable for peripheral 19
    $14 constant IAC_IAIE20                     \ [0x14] illegal access interrupt enable for peripheral 20
    $15 constant IAC_IAIE21                     \ [0x15] illegal access interrupt enable for peripheral 21
    $16 constant IAC_IAIE22                     \ [0x16] illegal access interrupt enable for peripheral 22
    $17 constant IAC_IAIE23                     \ [0x17] illegal access interrupt enable for peripheral 23
    $18 constant IAC_IAIE24                     \ [0x18] illegal access interrupt enable for peripheral 24
    $19 constant IAC_IAIE25                     \ [0x19] illegal access interrupt enable for peripheral 25
    $1a constant IAC_IAIE26                     \ [0x1a] illegal access interrupt enable for peripheral 26
    $1b constant IAC_IAIE27                     \ [0x1b] illegal access interrupt enable for peripheral 27
    $1c constant IAC_IAIE28                     \ [0x1c] illegal access interrupt enable for peripheral 28
    $1d constant IAC_IAIE29                     \ [0x1d] illegal access interrupt enable for peripheral 29
    $1e constant IAC_IAIE30                     \ [0x1e] illegal access interrupt enable for peripheral 30
    $1f constant IAC_IAIE31                     \ [0x1f] illegal access interrupt enable for peripheral 31
  [then]


  [ifdef] IAC_IAC_IER1_DEF
    \
    \ @brief IAC interrupt enable register 1
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant IAC_IAIE32                     \ [0x00] illegal access interrupt enable for peripheral 32
    $01 constant IAC_IAIE33                     \ [0x01] illegal access interrupt enable for peripheral 33
    $02 constant IAC_IAIE34                     \ [0x02] illegal access interrupt enable for peripheral 34
    $03 constant IAC_IAIE35                     \ [0x03] illegal access interrupt enable for peripheral 35
    $04 constant IAC_IAIE36                     \ [0x04] illegal access interrupt enable for peripheral 36
    $05 constant IAC_IAIE37                     \ [0x05] illegal access interrupt enable for peripheral 37
    $06 constant IAC_IAIE38                     \ [0x06] illegal access interrupt enable for peripheral 38
    $07 constant IAC_IAIE39                     \ [0x07] illegal access interrupt enable for peripheral 39
    $08 constant IAC_IAIE40                     \ [0x08] illegal access interrupt enable for peripheral 40
    $09 constant IAC_IAIE41                     \ [0x09] illegal access interrupt enable for peripheral 41
    $0a constant IAC_IAIE42                     \ [0x0a] illegal access interrupt enable for peripheral 42
    $0b constant IAC_IAIE43                     \ [0x0b] illegal access interrupt enable for peripheral 43
    $0c constant IAC_IAIE44                     \ [0x0c] illegal access interrupt enable for peripheral 44
    $0d constant IAC_IAIE45                     \ [0x0d] illegal access interrupt enable for peripheral 45
    $0e constant IAC_IAIE46                     \ [0x0e] illegal access interrupt enable for peripheral 46
    $0f constant IAC_IAIE47                     \ [0x0f] illegal access interrupt enable for peripheral 47
    $10 constant IAC_IAIE48                     \ [0x10] illegal access interrupt enable for peripheral 48
    $11 constant IAC_IAIE49                     \ [0x11] illegal access interrupt enable for peripheral 49
    $12 constant IAC_IAIE50                     \ [0x12] illegal access interrupt enable for peripheral 50
    $13 constant IAC_IAIE51                     \ [0x13] illegal access interrupt enable for peripheral 51
    $14 constant IAC_IAIE52                     \ [0x14] illegal access interrupt enable for peripheral 52
    $15 constant IAC_IAIE53                     \ [0x15] illegal access interrupt enable for peripheral 53
    $16 constant IAC_IAIE54                     \ [0x16] illegal access interrupt enable for peripheral 54
    $17 constant IAC_IAIE55                     \ [0x17] illegal access interrupt enable for peripheral 55
    $18 constant IAC_IAIE56                     \ [0x18] illegal access interrupt enable for peripheral 56
    $19 constant IAC_IAIE57                     \ [0x19] illegal access interrupt enable for peripheral 57
    $1a constant IAC_IAIE58                     \ [0x1a] illegal access interrupt enable for peripheral 58
    $1b constant IAC_IAIE59                     \ [0x1b] illegal access interrupt enable for peripheral 59
    $1c constant IAC_IAIE60                     \ [0x1c] illegal access interrupt enable for peripheral 60
    $1d constant IAC_IAIE61                     \ [0x1d] illegal access interrupt enable for peripheral 61
    $1e constant IAC_IAIE62                     \ [0x1e] illegal access interrupt enable for peripheral 62
    $1f constant IAC_IAIE63                     \ [0x1f] illegal access interrupt enable for peripheral 63
  [then]


  [ifdef] IAC_IAC_IER2_DEF
    \
    \ @brief IAC interrupt enable register 2
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant IAC_IAIE64                     \ [0x00] illegal access interrupt enable for peripheral 64
    $01 constant IAC_IAIE65                     \ [0x01] illegal access interrupt enable for peripheral 65
    $02 constant IAC_IAIE66                     \ [0x02] illegal access interrupt enable for peripheral 66
    $03 constant IAC_IAIE67                     \ [0x03] illegal access interrupt enable for peripheral 67
    $04 constant IAC_IAIE68                     \ [0x04] illegal access interrupt enable for peripheral 68
    $05 constant IAC_IAIE69                     \ [0x05] illegal access interrupt enable for peripheral 69
    $06 constant IAC_IAIE70                     \ [0x06] illegal access interrupt enable for peripheral 70
    $07 constant IAC_IAIE71                     \ [0x07] illegal access interrupt enable for peripheral 71
    $08 constant IAC_IAIE72                     \ [0x08] illegal access interrupt enable for peripheral 72
    $09 constant IAC_IAIE73                     \ [0x09] illegal access interrupt enable for peripheral 73
    $0a constant IAC_IAIE74                     \ [0x0a] illegal access interrupt enable for peripheral 74
    $0b constant IAC_IAIE75                     \ [0x0b] illegal access interrupt enable for peripheral 75
    $0c constant IAC_IAIE76                     \ [0x0c] illegal access interrupt enable for peripheral 76
    $0d constant IAC_IAIE77                     \ [0x0d] illegal access interrupt enable for peripheral 77
    $0e constant IAC_IAIE78                     \ [0x0e] illegal access interrupt enable for peripheral 78
    $0f constant IAC_IAIE79                     \ [0x0f] illegal access interrupt enable for peripheral 79
    $10 constant IAC_IAIE80                     \ [0x10] illegal access interrupt enable for peripheral 80
    $11 constant IAC_IAIE81                     \ [0x11] illegal access interrupt enable for peripheral 81
    $12 constant IAC_IAIE82                     \ [0x12] illegal access interrupt enable for peripheral 82
    $13 constant IAC_IAIE83                     \ [0x13] illegal access interrupt enable for peripheral 83
    $14 constant IAC_IAIE84                     \ [0x14] illegal access interrupt enable for peripheral 84
    $15 constant IAC_IAIE85                     \ [0x15] illegal access interrupt enable for peripheral 85
    $16 constant IAC_IAIE86                     \ [0x16] illegal access interrupt enable for peripheral 86
    $17 constant IAC_IAIE87                     \ [0x17] illegal access interrupt enable for peripheral 87
    $18 constant IAC_IAIE88                     \ [0x18] illegal access interrupt enable for peripheral 88
    $19 constant IAC_IAIE89                     \ [0x19] illegal access interrupt enable for peripheral 89
    $1a constant IAC_IAIE90                     \ [0x1a] illegal access interrupt enable for peripheral 90
    $1b constant IAC_IAIE91                     \ [0x1b] illegal access interrupt enable for peripheral 91
    $1c constant IAC_IAIE92                     \ [0x1c] illegal access interrupt enable for peripheral 92
    $1d constant IAC_IAIE93                     \ [0x1d] illegal access interrupt enable for peripheral 93
    $1e constant IAC_IAIE94                     \ [0x1e] illegal access interrupt enable for peripheral 94
    $1f constant IAC_IAIE95                     \ [0x1f] illegal access interrupt enable for peripheral 95
  [then]


  [ifdef] IAC_IAC_IER3_DEF
    \
    \ @brief IAC interrupt enable register 3
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant IAC_IAIE96                     \ [0x00] illegal access interrupt enable for peripheral 96
    $01 constant IAC_IAIE97                     \ [0x01] illegal access interrupt enable for peripheral 97
    $02 constant IAC_IAIE98                     \ [0x02] illegal access interrupt enable for peripheral 98
    $03 constant IAC_IAIE99                     \ [0x03] illegal access interrupt enable for peripheral 99
    $04 constant IAC_IAIE100                    \ [0x04] illegal access interrupt enable for peripheral 100
    $05 constant IAC_IAIE101                    \ [0x05] illegal access interrupt enable for peripheral 101
    $06 constant IAC_IAIE102                    \ [0x06] illegal access interrupt enable for peripheral 102
    $07 constant IAC_IAIE103                    \ [0x07] illegal access interrupt enable for peripheral 103
    $08 constant IAC_IAIE104                    \ [0x08] illegal access interrupt enable for peripheral 104
    $09 constant IAC_IAIE105                    \ [0x09] illegal access interrupt enable for peripheral 105
    $0a constant IAC_IAIE106                    \ [0x0a] illegal access interrupt enable for peripheral 106
    $0b constant IAC_IAIE107                    \ [0x0b] illegal access interrupt enable for peripheral 107
    $0c constant IAC_IAIE108                    \ [0x0c] illegal access interrupt enable for peripheral 108
    $0d constant IAC_IAIE109                    \ [0x0d] illegal access interrupt enable for peripheral 109
    $0e constant IAC_IAIE110                    \ [0x0e] illegal access interrupt enable for peripheral 110
    $0f constant IAC_IAIE111                    \ [0x0f] illegal access interrupt enable for peripheral 111
    $10 constant IAC_IAIE112                    \ [0x10] illegal access interrupt enable for peripheral 112
    $11 constant IAC_IAIE113                    \ [0x11] illegal access interrupt enable for peripheral 113
    $12 constant IAC_IAIE114                    \ [0x12] illegal access interrupt enable for peripheral 114
    $13 constant IAC_IAIE115                    \ [0x13] illegal access interrupt enable for peripheral 115
    $14 constant IAC_IAIE116                    \ [0x14] illegal access interrupt enable for peripheral 116
    $15 constant IAC_IAIE117                    \ [0x15] illegal access interrupt enable for peripheral 117
    $16 constant IAC_IAIE118                    \ [0x16] illegal access interrupt enable for peripheral 118
    $17 constant IAC_IAIE119                    \ [0x17] illegal access interrupt enable for peripheral 119
    $18 constant IAC_IAIE120                    \ [0x18] illegal access interrupt enable for peripheral 120
    $19 constant IAC_IAIE121                    \ [0x19] illegal access interrupt enable for peripheral 121
    $1a constant IAC_IAIE122                    \ [0x1a] illegal access interrupt enable for peripheral 122
    $1b constant IAC_IAIE123                    \ [0x1b] illegal access interrupt enable for peripheral 123
    $1c constant IAC_IAIE124                    \ [0x1c] illegal access interrupt enable for peripheral 124
    $1d constant IAC_IAIE125                    \ [0x1d] illegal access interrupt enable for peripheral 125
    $1e constant IAC_IAIE126                    \ [0x1e] illegal access interrupt enable for peripheral 126
    $1f constant IAC_IAIE127                    \ [0x1f] illegal access interrupt enable for peripheral 127
  [then]


  [ifdef] IAC_IAC_IER4_DEF
    \
    \ @brief IAC interrupt enable register 4
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant IAC_IAIE128                    \ [0x00] illegal access interrupt enable for peripheral 128
    $01 constant IAC_IAIE129                    \ [0x01] illegal access interrupt enable for peripheral 129
    $02 constant IAC_IAIE130                    \ [0x02] illegal access interrupt enable for peripheral 130
    $03 constant IAC_IAIE131                    \ [0x03] illegal access interrupt enable for peripheral 131
    $04 constant IAC_IAIE132                    \ [0x04] illegal access interrupt enable for peripheral 132
    $05 constant IAC_IAIE133                    \ [0x05] illegal access interrupt enable for peripheral 133
    $06 constant IAC_IAIE134                    \ [0x06] illegal access interrupt enable for peripheral 134
    $07 constant IAC_IAIE135                    \ [0x07] illegal access interrupt enable for peripheral 135
    $08 constant IAC_IAIE136                    \ [0x08] illegal access interrupt enable for peripheral 136
    $09 constant IAC_IAIE137                    \ [0x09] illegal access interrupt enable for peripheral 137
    $0a constant IAC_IAIE138                    \ [0x0a] illegal access interrupt enable for peripheral 138
    $0b constant IAC_IAIE139                    \ [0x0b] illegal access interrupt enable for peripheral 139
    $0c constant IAC_IAIE140                    \ [0x0c] illegal access interrupt enable for peripheral 140
    $0d constant IAC_IAIE141                    \ [0x0d] illegal access interrupt enable for peripheral 141
    $0e constant IAC_IAIE142                    \ [0x0e] illegal access interrupt enable for peripheral 142
    $0f constant IAC_IAIE143                    \ [0x0f] illegal access interrupt enable for peripheral 143
    $10 constant IAC_IAIE144                    \ [0x10] illegal access interrupt enable for peripheral 144
    $11 constant IAC_IAIE145                    \ [0x11] illegal access interrupt enable for peripheral 145
    $12 constant IAC_IAIE146                    \ [0x12] illegal access interrupt enable for peripheral 146
    $13 constant IAC_IAIE147                    \ [0x13] illegal access interrupt enable for peripheral 147
    $14 constant IAC_IAIE148                    \ [0x14] illegal access interrupt enable for peripheral 148
    $15 constant IAC_IAIE149                    \ [0x15] illegal access interrupt enable for peripheral 149
    $16 constant IAC_IAIE150                    \ [0x16] illegal access interrupt enable for peripheral 150
    $17 constant IAC_IAIE151                    \ [0x17] illegal access interrupt enable for peripheral 151
    $18 constant IAC_IAIE152                    \ [0x18] illegal access interrupt enable for peripheral 152
    $19 constant IAC_IAIE153                    \ [0x19] illegal access interrupt enable for peripheral 153
    $1a constant IAC_IAIE154                    \ [0x1a] illegal access interrupt enable for peripheral 154
    $1b constant IAC_IAIE155                    \ [0x1b] illegal access interrupt enable for peripheral 155
    $1c constant IAC_IAIE156                    \ [0x1c] illegal access interrupt enable for peripheral 156
    $1d constant IAC_IAIE157                    \ [0x1d] illegal access interrupt enable for peripheral 157
    $1e constant IAC_IAIE158                    \ [0x1e] illegal access interrupt enable for peripheral 158
    $1f constant IAC_IAIE159                    \ [0x1f] illegal access interrupt enable for peripheral 159
  [then]


  [ifdef] IAC_IAC_IER5_DEF
    \
    \ @brief IAC interrupt enable register 5
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant IAC_IAIE160                    \ [0x00] illegal access interrupt enable for peripheral 160
    $01 constant IAC_IAIE161                    \ [0x01] illegal access interrupt enable for peripheral 161
    $02 constant IAC_IAIE162                    \ [0x02] illegal access interrupt enable for peripheral 162
    $03 constant IAC_IAIE163                    \ [0x03] illegal access interrupt enable for peripheral 163
    $04 constant IAC_IAIE164                    \ [0x04] illegal access interrupt enable for peripheral 164
    $05 constant IAC_IAIE165                    \ [0x05] illegal access interrupt enable for peripheral 165
    $06 constant IAC_IAIE166                    \ [0x06] illegal access interrupt enable for peripheral 166
    $07 constant IAC_IAIE167                    \ [0x07] illegal access interrupt enable for peripheral 167
    $08 constant IAC_IAIE168                    \ [0x08] illegal access interrupt enable for peripheral 168
    $09 constant IAC_IAIE169                    \ [0x09] illegal access interrupt enable for peripheral 169
    $0a constant IAC_IAIE170                    \ [0x0a] illegal access interrupt enable for peripheral 170
    $0b constant IAC_IAIE171                    \ [0x0b] illegal access interrupt enable for peripheral 171
    $0c constant IAC_IAIE172                    \ [0x0c] illegal access interrupt enable for peripheral 172
    $0d constant IAC_IAIE173                    \ [0x0d] illegal access interrupt enable for peripheral 173
    $0e constant IAC_IAIE174                    \ [0x0e] illegal access interrupt enable for peripheral 174
    $0f constant IAC_IAIE175                    \ [0x0f] illegal access interrupt enable for peripheral 175
    $10 constant IAC_IAIE176                    \ [0x10] illegal access interrupt enable for peripheral 176
    $11 constant IAC_IAIE177                    \ [0x11] illegal access interrupt enable for peripheral 177
    $12 constant IAC_IAIE178                    \ [0x12] illegal access interrupt enable for peripheral 178
    $13 constant IAC_IAIE179                    \ [0x13] illegal access interrupt enable for peripheral 179
    $14 constant IAC_IAIE180                    \ [0x14] illegal access interrupt enable for peripheral 180
    $15 constant IAC_IAIE181                    \ [0x15] illegal access interrupt enable for peripheral 181
    $16 constant IAC_IAIE182                    \ [0x16] illegal access interrupt enable for peripheral 182
    $17 constant IAC_IAIE183                    \ [0x17] illegal access interrupt enable for peripheral 183
    $18 constant IAC_IAIE184                    \ [0x18] illegal access interrupt enable for peripheral 184
    $19 constant IAC_IAIE185                    \ [0x19] illegal access interrupt enable for peripheral 185
    $1a constant IAC_IAIE186                    \ [0x1a] illegal access interrupt enable for peripheral 186
    $1b constant IAC_IAIE187                    \ [0x1b] illegal access interrupt enable for peripheral 187
    $1c constant IAC_IAIE188                    \ [0x1c] illegal access interrupt enable for peripheral 188
    $1d constant IAC_IAIE189                    \ [0x1d] illegal access interrupt enable for peripheral 189
    $1e constant IAC_IAIE190                    \ [0x1e] illegal access interrupt enable for peripheral 190
    $1f constant IAC_IAIE191                    \ [0x1f] illegal access interrupt enable for peripheral 191
  [then]


  [ifdef] IAC_IAC_ISR0_DEF
    \
    \ @brief IAC interrupt status register 0
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant IAC_IAF0                       \ [0x00] illegal access interrupt enable for peripheral 0
    $01 constant IAC_IAF1                       \ [0x01] illegal access interrupt enable for peripheral 1
    $02 constant IAC_IAF2                       \ [0x02] illegal access interrupt enable for peripheral 2
    $03 constant IAC_IAF3                       \ [0x03] illegal access interrupt enable for peripheral 3
    $04 constant IAC_IAF4                       \ [0x04] illegal access interrupt enable for peripheral 4
    $05 constant IAC_IAF5                       \ [0x05] illegal access interrupt enable for peripheral 5
    $06 constant IAC_IAF6                       \ [0x06] illegal access interrupt enable for peripheral 6
    $07 constant IAC_IAF7                       \ [0x07] illegal access interrupt enable for peripheral 7
    $08 constant IAC_IAF8                       \ [0x08] illegal access interrupt enable for peripheral 8
    $09 constant IAC_IAF9                       \ [0x09] illegal access interrupt enable for peripheral 9
    $0a constant IAC_IAF10                      \ [0x0a] illegal access interrupt enable for peripheral 10
    $0b constant IAC_IAF11                      \ [0x0b] illegal access interrupt enable for peripheral 11
    $0c constant IAC_IAF12                      \ [0x0c] illegal access interrupt enable for peripheral 12
    $0d constant IAC_IAF13                      \ [0x0d] illegal access interrupt enable for peripheral 13
    $0e constant IAC_IAF14                      \ [0x0e] illegal access interrupt enable for peripheral 14
    $0f constant IAC_IAF15                      \ [0x0f] illegal access interrupt enable for peripheral 15
    $10 constant IAC_IAF16                      \ [0x10] illegal access interrupt enable for peripheral 16
    $11 constant IAC_IAF17                      \ [0x11] illegal access interrupt enable for peripheral 17
    $12 constant IAC_IAF18                      \ [0x12] illegal access interrupt enable for peripheral 18
    $13 constant IAC_IAF19                      \ [0x13] illegal access interrupt enable for peripheral 19
    $14 constant IAC_IAF20                      \ [0x14] illegal access interrupt enable for peripheral 20
    $15 constant IAC_IAF21                      \ [0x15] illegal access interrupt enable for peripheral 21
    $16 constant IAC_IAF22                      \ [0x16] illegal access interrupt enable for peripheral 22
    $17 constant IAC_IAF23                      \ [0x17] illegal access interrupt enable for peripheral 23
    $18 constant IAC_IAF24                      \ [0x18] illegal access interrupt enable for peripheral 24
    $19 constant IAC_IAF25                      \ [0x19] illegal access interrupt enable for peripheral 25
    $1a constant IAC_IAF26                      \ [0x1a] illegal access interrupt enable for peripheral 26
    $1b constant IAC_IAF27                      \ [0x1b] illegal access interrupt enable for peripheral 27
    $1c constant IAC_IAF28                      \ [0x1c] illegal access interrupt enable for peripheral 28
    $1d constant IAC_IAF29                      \ [0x1d] illegal access interrupt enable for peripheral 29
    $1e constant IAC_IAF30                      \ [0x1e] illegal access interrupt enable for peripheral 30
    $1f constant IAC_IAF31                      \ [0x1f] illegal access interrupt enable for peripheral 31
  [then]


  [ifdef] IAC_IAC_ISR1_DEF
    \
    \ @brief IAC interrupt status register 1
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant IAC_IAF32                      \ [0x00] illegal access interrupt enable for peripheral 32
    $01 constant IAC_IAF33                      \ [0x01] illegal access interrupt enable for peripheral 33
    $02 constant IAC_IAF34                      \ [0x02] illegal access interrupt enable for peripheral 34
    $03 constant IAC_IAF35                      \ [0x03] illegal access interrupt enable for peripheral 35
    $04 constant IAC_IAF36                      \ [0x04] illegal access interrupt enable for peripheral 36
    $05 constant IAC_IAF37                      \ [0x05] illegal access interrupt enable for peripheral 37
    $06 constant IAC_IAF38                      \ [0x06] illegal access interrupt enable for peripheral 38
    $07 constant IAC_IAF39                      \ [0x07] illegal access interrupt enable for peripheral 39
    $08 constant IAC_IAF40                      \ [0x08] illegal access interrupt enable for peripheral 40
    $09 constant IAC_IAF41                      \ [0x09] illegal access interrupt enable for peripheral 41
    $0a constant IAC_IAF42                      \ [0x0a] illegal access interrupt enable for peripheral 42
    $0b constant IAC_IAF43                      \ [0x0b] illegal access interrupt enable for peripheral 43
    $0c constant IAC_IAF44                      \ [0x0c] illegal access interrupt enable for peripheral 44
    $0d constant IAC_IAF45                      \ [0x0d] illegal access interrupt enable for peripheral 45
    $0e constant IAC_IAF46                      \ [0x0e] illegal access interrupt enable for peripheral 46
    $0f constant IAC_IAF47                      \ [0x0f] illegal access interrupt enable for peripheral 47
    $10 constant IAC_IAF48                      \ [0x10] illegal access interrupt enable for peripheral 48
    $11 constant IAC_IAF49                      \ [0x11] illegal access interrupt enable for peripheral 49
    $12 constant IAC_IAF50                      \ [0x12] illegal access interrupt enable for peripheral 50
    $13 constant IAC_IAF51                      \ [0x13] illegal access interrupt enable for peripheral 51
    $14 constant IAC_IAF52                      \ [0x14] illegal access interrupt enable for peripheral 52
    $15 constant IAC_IAF53                      \ [0x15] illegal access interrupt enable for peripheral 53
    $16 constant IAC_IAF54                      \ [0x16] illegal access interrupt enable for peripheral 54
    $17 constant IAC_IAF55                      \ [0x17] illegal access interrupt enable for peripheral 55
    $18 constant IAC_IAF56                      \ [0x18] illegal access interrupt enable for peripheral 56
    $19 constant IAC_IAF57                      \ [0x19] illegal access interrupt enable for peripheral 57
    $1a constant IAC_IAF58                      \ [0x1a] illegal access interrupt enable for peripheral 58
    $1b constant IAC_IAF59                      \ [0x1b] illegal access interrupt enable for peripheral 59
    $1c constant IAC_IAF60                      \ [0x1c] illegal access interrupt enable for peripheral 60
    $1d constant IAC_IAF61                      \ [0x1d] illegal access interrupt enable for peripheral 61
    $1e constant IAC_IAF62                      \ [0x1e] illegal access interrupt enable for peripheral 62
    $1f constant IAC_IAF63                      \ [0x1f] illegal access interrupt enable for peripheral 63
  [then]


  [ifdef] IAC_IAC_ISR2_DEF
    \
    \ @brief IAC interrupt status register 2
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant IAC_IAF64                      \ [0x00] illegal access interrupt enable for peripheral 64
    $01 constant IAC_IAF65                      \ [0x01] illegal access interrupt enable for peripheral 65
    $02 constant IAC_IAF66                      \ [0x02] illegal access interrupt enable for peripheral 66
    $03 constant IAC_IAF67                      \ [0x03] illegal access interrupt enable for peripheral 67
    $04 constant IAC_IAF68                      \ [0x04] illegal access interrupt enable for peripheral 68
    $05 constant IAC_IAF69                      \ [0x05] illegal access interrupt enable for peripheral 69
    $06 constant IAC_IAF70                      \ [0x06] illegal access interrupt enable for peripheral 70
    $07 constant IAC_IAF71                      \ [0x07] illegal access interrupt enable for peripheral 71
    $08 constant IAC_IAF72                      \ [0x08] illegal access interrupt enable for peripheral 72
    $09 constant IAC_IAF73                      \ [0x09] illegal access interrupt enable for peripheral 73
    $0a constant IAC_IAF74                      \ [0x0a] illegal access interrupt enable for peripheral 74
    $0b constant IAC_IAF75                      \ [0x0b] illegal access interrupt enable for peripheral 75
    $0c constant IAC_IAF76                      \ [0x0c] illegal access interrupt enable for peripheral 76
    $0d constant IAC_IAF77                      \ [0x0d] illegal access interrupt enable for peripheral 77
    $0e constant IAC_IAF78                      \ [0x0e] illegal access interrupt enable for peripheral 78
    $0f constant IAC_IAF79                      \ [0x0f] illegal access interrupt enable for peripheral 79
    $10 constant IAC_IAF80                      \ [0x10] illegal access interrupt enable for peripheral 80
    $11 constant IAC_IAF81                      \ [0x11] illegal access interrupt enable for peripheral 81
    $12 constant IAC_IAF82                      \ [0x12] illegal access interrupt enable for peripheral 82
    $13 constant IAC_IAF83                      \ [0x13] illegal access interrupt enable for peripheral 83
    $14 constant IAC_IAF84                      \ [0x14] illegal access interrupt enable for peripheral 84
    $15 constant IAC_IAF85                      \ [0x15] illegal access interrupt enable for peripheral 85
    $16 constant IAC_IAF86                      \ [0x16] illegal access interrupt enable for peripheral 86
    $17 constant IAC_IAF87                      \ [0x17] illegal access interrupt enable for peripheral 87
    $18 constant IAC_IAF88                      \ [0x18] illegal access interrupt enable for peripheral 88
    $19 constant IAC_IAF89                      \ [0x19] illegal access interrupt enable for peripheral 89
    $1a constant IAC_IAF90                      \ [0x1a] illegal access interrupt enable for peripheral 90
    $1b constant IAC_IAF91                      \ [0x1b] illegal access interrupt enable for peripheral 91
    $1c constant IAC_IAF92                      \ [0x1c] illegal access interrupt enable for peripheral 92
    $1d constant IAC_IAF93                      \ [0x1d] illegal access interrupt enable for peripheral 93
    $1e constant IAC_IAF94                      \ [0x1e] illegal access interrupt enable for peripheral 94
    $1f constant IAC_IAF95                      \ [0x1f] illegal access interrupt enable for peripheral 95
  [then]


  [ifdef] IAC_IAC_ISR3_DEF
    \
    \ @brief IAC interrupt status register 3
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant IAC_IAF96                      \ [0x00] illegal access interrupt enable for peripheral 96
    $01 constant IAC_IAF97                      \ [0x01] illegal access interrupt enable for peripheral 97
    $02 constant IAC_IAF98                      \ [0x02] illegal access interrupt enable for peripheral 98
    $03 constant IAC_IAF99                      \ [0x03] illegal access interrupt enable for peripheral 99
    $04 constant IAC_IAF100                     \ [0x04] illegal access interrupt enable for peripheral 100
    $05 constant IAC_IAF101                     \ [0x05] illegal access interrupt enable for peripheral 101
    $06 constant IAC_IAF102                     \ [0x06] illegal access interrupt enable for peripheral 102
    $07 constant IAC_IAF103                     \ [0x07] illegal access interrupt enable for peripheral 103
    $08 constant IAC_IAF104                     \ [0x08] illegal access interrupt enable for peripheral 104
    $09 constant IAC_IAF105                     \ [0x09] illegal access interrupt enable for peripheral 105
    $0a constant IAC_IAF106                     \ [0x0a] illegal access interrupt enable for peripheral 106
    $0b constant IAC_IAF107                     \ [0x0b] illegal access interrupt enable for peripheral 107
    $0c constant IAC_IAF108                     \ [0x0c] illegal access interrupt enable for peripheral 108
    $0d constant IAC_IAF109                     \ [0x0d] illegal access interrupt enable for peripheral 109
    $0e constant IAC_IAF110                     \ [0x0e] illegal access interrupt enable for peripheral 110
    $0f constant IAC_IAF111                     \ [0x0f] illegal access interrupt enable for peripheral 111
    $10 constant IAC_IAF112                     \ [0x10] illegal access interrupt enable for peripheral 112
    $11 constant IAC_IAF113                     \ [0x11] illegal access interrupt enable for peripheral 113
    $12 constant IAC_IAF114                     \ [0x12] illegal access interrupt enable for peripheral 114
    $13 constant IAC_IAF115                     \ [0x13] illegal access interrupt enable for peripheral 115
    $14 constant IAC_IAF116                     \ [0x14] illegal access interrupt enable for peripheral 116
    $15 constant IAC_IAF117                     \ [0x15] illegal access interrupt enable for peripheral 117
    $16 constant IAC_IAF118                     \ [0x16] illegal access interrupt enable for peripheral 118
    $17 constant IAC_IAF119                     \ [0x17] illegal access interrupt enable for peripheral 119
    $18 constant IAC_IAF120                     \ [0x18] illegal access interrupt enable for peripheral 120
    $19 constant IAC_IAF121                     \ [0x19] illegal access interrupt enable for peripheral 121
    $1a constant IAC_IAF122                     \ [0x1a] illegal access interrupt enable for peripheral 122
    $1b constant IAC_IAF123                     \ [0x1b] illegal access interrupt enable for peripheral 123
    $1c constant IAC_IAF124                     \ [0x1c] illegal access interrupt enable for peripheral 124
    $1d constant IAC_IAF125                     \ [0x1d] illegal access interrupt enable for peripheral 125
    $1e constant IAC_IAF126                     \ [0x1e] illegal access interrupt enable for peripheral 126
    $1f constant IAC_IAF127                     \ [0x1f] illegal access interrupt enable for peripheral 127
  [then]


  [ifdef] IAC_IAC_ISR4_DEF
    \
    \ @brief IAC interrupt status register 4
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant IAC_IAF128                     \ [0x00] illegal access interrupt enable for peripheral 128
    $01 constant IAC_IAF129                     \ [0x01] illegal access interrupt enable for peripheral 129
    $02 constant IAC_IAF130                     \ [0x02] illegal access interrupt enable for peripheral 130
    $03 constant IAC_IAF131                     \ [0x03] illegal access interrupt enable for peripheral 131
    $04 constant IAC_IAF132                     \ [0x04] illegal access interrupt enable for peripheral 132
    $05 constant IAC_IAF133                     \ [0x05] illegal access interrupt enable for peripheral 133
    $06 constant IAC_IAF134                     \ [0x06] illegal access interrupt enable for peripheral 134
    $07 constant IAC_IAF135                     \ [0x07] illegal access interrupt enable for peripheral 135
    $08 constant IAC_IAF136                     \ [0x08] illegal access interrupt enable for peripheral 136
    $09 constant IAC_IAF137                     \ [0x09] illegal access interrupt enable for peripheral 137
    $0a constant IAC_IAF138                     \ [0x0a] illegal access interrupt enable for peripheral 138
    $0b constant IAC_IAF139                     \ [0x0b] illegal access interrupt enable for peripheral 139
    $0c constant IAC_IAF140                     \ [0x0c] illegal access interrupt enable for peripheral 140
    $0d constant IAC_IAF141                     \ [0x0d] illegal access interrupt enable for peripheral 141
    $0e constant IAC_IAF142                     \ [0x0e] illegal access interrupt enable for peripheral 142
    $0f constant IAC_IAF143                     \ [0x0f] illegal access interrupt enable for peripheral 143
    $10 constant IAC_IAF144                     \ [0x10] illegal access interrupt enable for peripheral 144
    $11 constant IAC_IAF145                     \ [0x11] illegal access interrupt enable for peripheral 145
    $12 constant IAC_IAF146                     \ [0x12] illegal access interrupt enable for peripheral 146
    $13 constant IAC_IAF147                     \ [0x13] illegal access interrupt enable for peripheral 147
    $14 constant IAC_IAF148                     \ [0x14] illegal access interrupt enable for peripheral 148
    $15 constant IAC_IAF149                     \ [0x15] illegal access interrupt enable for peripheral 149
    $16 constant IAC_IAF150                     \ [0x16] illegal access interrupt enable for peripheral 150
    $17 constant IAC_IAF151                     \ [0x17] illegal access interrupt enable for peripheral 151
    $18 constant IAC_IAF152                     \ [0x18] illegal access interrupt enable for peripheral 152
    $19 constant IAC_IAF153                     \ [0x19] illegal access interrupt enable for peripheral 153
    $1a constant IAC_IAF154                     \ [0x1a] illegal access interrupt enable for peripheral 154
    $1b constant IAC_IAF155                     \ [0x1b] illegal access interrupt enable for peripheral 155
    $1c constant IAC_IAF156                     \ [0x1c] illegal access interrupt enable for peripheral 156
    $1d constant IAC_IAF157                     \ [0x1d] illegal access interrupt enable for peripheral 157
    $1e constant IAC_IAF158                     \ [0x1e] illegal access interrupt enable for peripheral 158
    $1f constant IAC_IAF159                     \ [0x1f] illegal access interrupt enable for peripheral 159
  [then]


  [ifdef] IAC_IAC_ISR5_DEF
    \
    \ @brief IAC interrupt status register 5
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant IAC_IAF160                     \ [0x00] illegal access interrupt enable for peripheral 160
    $01 constant IAC_IAF161                     \ [0x01] illegal access interrupt enable for peripheral 161
    $02 constant IAC_IAF162                     \ [0x02] illegal access interrupt enable for peripheral 162
    $03 constant IAC_IAF163                     \ [0x03] illegal access interrupt enable for peripheral 163
    $04 constant IAC_IAF164                     \ [0x04] illegal access interrupt enable for peripheral 164
    $05 constant IAC_IAF165                     \ [0x05] illegal access interrupt enable for peripheral 165
    $06 constant IAC_IAF166                     \ [0x06] illegal access interrupt enable for peripheral 166
    $07 constant IAC_IAF167                     \ [0x07] illegal access interrupt enable for peripheral 167
    $08 constant IAC_IAF168                     \ [0x08] illegal access interrupt enable for peripheral 168
    $09 constant IAC_IAF169                     \ [0x09] illegal access interrupt enable for peripheral 169
    $0a constant IAC_IAF170                     \ [0x0a] illegal access interrupt enable for peripheral 170
    $0b constant IAC_IAF171                     \ [0x0b] illegal access interrupt enable for peripheral 171
    $0c constant IAC_IAF172                     \ [0x0c] illegal access interrupt enable for peripheral 172
    $0d constant IAC_IAF173                     \ [0x0d] illegal access interrupt enable for peripheral 173
    $0e constant IAC_IAF174                     \ [0x0e] illegal access interrupt enable for peripheral 174
    $0f constant IAC_IAF175                     \ [0x0f] illegal access interrupt enable for peripheral 175
    $10 constant IAC_IAF176                     \ [0x10] illegal access interrupt enable for peripheral 176
    $11 constant IAC_IAF177                     \ [0x11] illegal access interrupt enable for peripheral 177
    $12 constant IAC_IAF178                     \ [0x12] illegal access interrupt enable for peripheral 178
    $13 constant IAC_IAF179                     \ [0x13] illegal access interrupt enable for peripheral 179
    $14 constant IAC_IAF180                     \ [0x14] illegal access interrupt enable for peripheral 180
    $15 constant IAC_IAF181                     \ [0x15] illegal access interrupt enable for peripheral 181
    $16 constant IAC_IAF182                     \ [0x16] illegal access interrupt enable for peripheral 182
    $17 constant IAC_IAF183                     \ [0x17] illegal access interrupt enable for peripheral 183
    $18 constant IAC_IAF184                     \ [0x18] illegal access interrupt enable for peripheral 184
    $19 constant IAC_IAF185                     \ [0x19] illegal access interrupt enable for peripheral 185
    $1a constant IAC_IAF186                     \ [0x1a] illegal access interrupt enable for peripheral 186
    $1b constant IAC_IAF187                     \ [0x1b] illegal access interrupt enable for peripheral 187
    $1c constant IAC_IAF188                     \ [0x1c] illegal access interrupt enable for peripheral 188
    $1d constant IAC_IAF189                     \ [0x1d] illegal access interrupt enable for peripheral 189
    $1e constant IAC_IAF190                     \ [0x1e] illegal access interrupt enable for peripheral 190
    $1f constant IAC_IAF191                     \ [0x1f] illegal access interrupt enable for peripheral 191
  [then]


  [ifdef] IAC_IAC_ICR0_DEF
    \
    \ @brief IAC interrupt clear register 0
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant IAC_IAF0                       \ [0x00] illegal access flag clear for peripheral 0
    $01 constant IAC_IAF1                       \ [0x01] illegal access flag clear for peripheral 1
    $02 constant IAC_IAF2                       \ [0x02] illegal access flag clear for peripheral 2
    $03 constant IAC_IAF3                       \ [0x03] illegal access flag clear for peripheral 3
    $04 constant IAC_IAF4                       \ [0x04] illegal access flag clear for peripheral 4
    $05 constant IAC_IAF5                       \ [0x05] illegal access flag clear for peripheral 5
    $06 constant IAC_IAF6                       \ [0x06] illegal access flag clear for peripheral 6
    $07 constant IAC_IAF7                       \ [0x07] illegal access flag clear for peripheral 7
    $08 constant IAC_IAF8                       \ [0x08] illegal access flag clear for peripheral 8
    $09 constant IAC_IAF9                       \ [0x09] illegal access flag clear for peripheral 9
    $0a constant IAC_IAF10                      \ [0x0a] illegal access flag clear for peripheral 10
    $0b constant IAC_IAF11                      \ [0x0b] illegal access flag clear for peripheral 11
    $0c constant IAC_IAF12                      \ [0x0c] illegal access flag clear for peripheral 12
    $0d constant IAC_IAF13                      \ [0x0d] illegal access flag clear for peripheral 13
    $0e constant IAC_IAF14                      \ [0x0e] illegal access flag clear for peripheral 14
    $0f constant IAC_IAF15                      \ [0x0f] illegal access flag clear for peripheral 15
    $10 constant IAC_IAF16                      \ [0x10] illegal access flag clear for peripheral 16
    $11 constant IAC_IAF17                      \ [0x11] illegal access flag clear for peripheral 17
    $12 constant IAC_IAF18                      \ [0x12] illegal access flag clear for peripheral 18
    $13 constant IAC_IAF19                      \ [0x13] illegal access flag clear for peripheral 19
    $14 constant IAC_IAF20                      \ [0x14] illegal access flag clear for peripheral 20
    $15 constant IAC_IAF21                      \ [0x15] illegal access flag clear for peripheral 21
    $16 constant IAC_IAF22                      \ [0x16] illegal access flag clear for peripheral 22
    $17 constant IAC_IAF23                      \ [0x17] illegal access flag clear for peripheral 23
    $18 constant IAC_IAF24                      \ [0x18] illegal access flag clear for peripheral 24
    $19 constant IAC_IAF25                      \ [0x19] illegal access flag clear for peripheral 25
    $1a constant IAC_IAF26                      \ [0x1a] illegal access flag clear for peripheral 26
    $1b constant IAC_IAF27                      \ [0x1b] illegal access flag clear for peripheral 27
    $1c constant IAC_IAF28                      \ [0x1c] illegal access flag clear for peripheral 28
    $1d constant IAC_IAF29                      \ [0x1d] illegal access flag clear for peripheral 29
    $1e constant IAC_IAF30                      \ [0x1e] illegal access flag clear for peripheral 30
    $1f constant IAC_IAF31                      \ [0x1f] illegal access flag clear for peripheral 31
  [then]


  [ifdef] IAC_IAC_ICR1_DEF
    \
    \ @brief IAC interrupt clear register 1
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant IAC_IAF32                      \ [0x00] illegal access flag clear for peripheral 32
    $01 constant IAC_IAF33                      \ [0x01] illegal access flag clear for peripheral 33
    $02 constant IAC_IAF34                      \ [0x02] illegal access flag clear for peripheral 34
    $03 constant IAC_IAF35                      \ [0x03] illegal access flag clear for peripheral 35
    $04 constant IAC_IAF36                      \ [0x04] illegal access flag clear for peripheral 36
    $05 constant IAC_IAF37                      \ [0x05] illegal access flag clear for peripheral 37
    $06 constant IAC_IAF38                      \ [0x06] illegal access flag clear for peripheral 38
    $07 constant IAC_IAF39                      \ [0x07] illegal access flag clear for peripheral 39
    $08 constant IAC_IAF40                      \ [0x08] illegal access flag clear for peripheral 40
    $09 constant IAC_IAF41                      \ [0x09] illegal access flag clear for peripheral 41
    $0a constant IAC_IAF42                      \ [0x0a] illegal access flag clear for peripheral 42
    $0b constant IAC_IAF43                      \ [0x0b] illegal access flag clear for peripheral 43
    $0c constant IAC_IAF44                      \ [0x0c] illegal access flag clear for peripheral 44
    $0d constant IAC_IAF45                      \ [0x0d] illegal access flag clear for peripheral 45
    $0e constant IAC_IAF46                      \ [0x0e] illegal access flag clear for peripheral 46
    $0f constant IAC_IAF47                      \ [0x0f] illegal access flag clear for peripheral 47
    $10 constant IAC_IAF48                      \ [0x10] illegal access flag clear for peripheral 48
    $11 constant IAC_IAF49                      \ [0x11] illegal access flag clear for peripheral 49
    $12 constant IAC_IAF50                      \ [0x12] illegal access flag clear for peripheral 50
    $13 constant IAC_IAF51                      \ [0x13] illegal access flag clear for peripheral 51
    $14 constant IAC_IAF52                      \ [0x14] illegal access flag clear for peripheral 52
    $15 constant IAC_IAF53                      \ [0x15] illegal access flag clear for peripheral 53
    $16 constant IAC_IAF54                      \ [0x16] illegal access flag clear for peripheral 54
    $17 constant IAC_IAF55                      \ [0x17] illegal access flag clear for peripheral 55
    $18 constant IAC_IAF56                      \ [0x18] illegal access flag clear for peripheral 56
    $19 constant IAC_IAF57                      \ [0x19] illegal access flag clear for peripheral 57
    $1a constant IAC_IAF58                      \ [0x1a] illegal access flag clear for peripheral 58
    $1b constant IAC_IAF59                      \ [0x1b] illegal access flag clear for peripheral 59
    $1c constant IAC_IAF60                      \ [0x1c] illegal access flag clear for peripheral 60
    $1d constant IAC_IAF61                      \ [0x1d] illegal access flag clear for peripheral 61
    $1e constant IAC_IAF62                      \ [0x1e] illegal access flag clear for peripheral 62
    $1f constant IAC_IAF63                      \ [0x1f] illegal access flag clear for peripheral 63
  [then]


  [ifdef] IAC_IAC_ICR2_DEF
    \
    \ @brief IAC interrupt clear register 2
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant IAC_IAF64                      \ [0x00] illegal access flag clear for peripheral 64
    $01 constant IAC_IAF65                      \ [0x01] illegal access flag clear for peripheral 65
    $02 constant IAC_IAF66                      \ [0x02] illegal access flag clear for peripheral 66
    $03 constant IAC_IAF67                      \ [0x03] illegal access flag clear for peripheral 67
    $04 constant IAC_IAF68                      \ [0x04] illegal access flag clear for peripheral 68
    $05 constant IAC_IAF69                      \ [0x05] illegal access flag clear for peripheral 69
    $06 constant IAC_IAF70                      \ [0x06] illegal access flag clear for peripheral 70
    $07 constant IAC_IAF71                      \ [0x07] illegal access flag clear for peripheral 71
    $08 constant IAC_IAF72                      \ [0x08] illegal access flag clear for peripheral 72
    $09 constant IAC_IAF73                      \ [0x09] illegal access flag clear for peripheral 73
    $0a constant IAC_IAF74                      \ [0x0a] illegal access flag clear for peripheral 74
    $0b constant IAC_IAF75                      \ [0x0b] illegal access flag clear for peripheral 75
    $0c constant IAC_IAF76                      \ [0x0c] illegal access flag clear for peripheral 76
    $0d constant IAC_IAF77                      \ [0x0d] illegal access flag clear for peripheral 77
    $0e constant IAC_IAF78                      \ [0x0e] illegal access flag clear for peripheral 78
    $0f constant IAC_IAF79                      \ [0x0f] illegal access flag clear for peripheral 79
    $10 constant IAC_IAF80                      \ [0x10] illegal access flag clear for peripheral 80
    $11 constant IAC_IAF81                      \ [0x11] illegal access flag clear for peripheral 81
    $12 constant IAC_IAF82                      \ [0x12] illegal access flag clear for peripheral 82
    $13 constant IAC_IAF83                      \ [0x13] illegal access flag clear for peripheral 83
    $14 constant IAC_IAF84                      \ [0x14] illegal access flag clear for peripheral 84
    $15 constant IAC_IAF85                      \ [0x15] illegal access flag clear for peripheral 85
    $16 constant IAC_IAF86                      \ [0x16] illegal access flag clear for peripheral 86
    $17 constant IAC_IAF87                      \ [0x17] illegal access flag clear for peripheral 87
    $18 constant IAC_IAF88                      \ [0x18] illegal access flag clear for peripheral 88
    $19 constant IAC_IAF89                      \ [0x19] illegal access flag clear for peripheral 89
    $1a constant IAC_IAF90                      \ [0x1a] illegal access flag clear for peripheral 90
    $1b constant IAC_IAF91                      \ [0x1b] illegal access flag clear for peripheral 91
    $1c constant IAC_IAF92                      \ [0x1c] illegal access flag clear for peripheral 92
    $1d constant IAC_IAF93                      \ [0x1d] illegal access flag clear for peripheral 93
    $1e constant IAC_IAF94                      \ [0x1e] illegal access flag clear for peripheral 94
    $1f constant IAC_IAF95                      \ [0x1f] illegal access flag clear for peripheral 95
  [then]


  [ifdef] IAC_IAC_ICR3_DEF
    \
    \ @brief IAC interrupt clear register 3
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant IAC_IAF96                      \ [0x00] illegal access flag clear for peripheral 96
    $01 constant IAC_IAF97                      \ [0x01] illegal access flag clear for peripheral 97
    $02 constant IAC_IAF98                      \ [0x02] illegal access flag clear for peripheral 98
    $03 constant IAC_IAF99                      \ [0x03] illegal access flag clear for peripheral 99
    $04 constant IAC_IAF100                     \ [0x04] illegal access flag clear for peripheral 100
    $05 constant IAC_IAF101                     \ [0x05] illegal access flag clear for peripheral 101
    $06 constant IAC_IAF102                     \ [0x06] illegal access flag clear for peripheral 102
    $07 constant IAC_IAF103                     \ [0x07] illegal access flag clear for peripheral 103
    $08 constant IAC_IAF104                     \ [0x08] illegal access flag clear for peripheral 104
    $09 constant IAC_IAF105                     \ [0x09] illegal access flag clear for peripheral 105
    $0a constant IAC_IAF106                     \ [0x0a] illegal access flag clear for peripheral 106
    $0b constant IAC_IAF107                     \ [0x0b] illegal access flag clear for peripheral 107
    $0c constant IAC_IAF108                     \ [0x0c] illegal access flag clear for peripheral 108
    $0d constant IAC_IAF109                     \ [0x0d] illegal access flag clear for peripheral 109
    $0e constant IAC_IAF110                     \ [0x0e] illegal access flag clear for peripheral 110
    $0f constant IAC_IAF111                     \ [0x0f] illegal access flag clear for peripheral 111
    $10 constant IAC_IAF112                     \ [0x10] illegal access flag clear for peripheral 112
    $11 constant IAC_IAF113                     \ [0x11] illegal access flag clear for peripheral 113
    $12 constant IAC_IAF114                     \ [0x12] illegal access flag clear for peripheral 114
    $13 constant IAC_IAF115                     \ [0x13] illegal access flag clear for peripheral 115
    $14 constant IAC_IAF116                     \ [0x14] illegal access flag clear for peripheral 116
    $15 constant IAC_IAF117                     \ [0x15] illegal access flag clear for peripheral 117
    $16 constant IAC_IAF118                     \ [0x16] illegal access flag clear for peripheral 118
    $17 constant IAC_IAF119                     \ [0x17] illegal access flag clear for peripheral 119
    $18 constant IAC_IAF120                     \ [0x18] illegal access flag clear for peripheral 120
    $19 constant IAC_IAF121                     \ [0x19] illegal access flag clear for peripheral 121
    $1a constant IAC_IAF122                     \ [0x1a] illegal access flag clear for peripheral 122
    $1b constant IAC_IAF123                     \ [0x1b] illegal access flag clear for peripheral 123
    $1c constant IAC_IAF124                     \ [0x1c] illegal access flag clear for peripheral 124
    $1d constant IAC_IAF125                     \ [0x1d] illegal access flag clear for peripheral 125
    $1e constant IAC_IAF126                     \ [0x1e] illegal access flag clear for peripheral 126
    $1f constant IAC_IAF127                     \ [0x1f] illegal access flag clear for peripheral 127
  [then]


  [ifdef] IAC_IAC_ICR4_DEF
    \
    \ @brief IAC interrupt clear register 4
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant IAC_IAF128                     \ [0x00] illegal access flag clear for peripheral 128
    $01 constant IAC_IAF129                     \ [0x01] illegal access flag clear for peripheral 129
    $02 constant IAC_IAF130                     \ [0x02] illegal access flag clear for peripheral 130
    $03 constant IAC_IAF131                     \ [0x03] illegal access flag clear for peripheral 131
    $04 constant IAC_IAF132                     \ [0x04] illegal access flag clear for peripheral 132
    $05 constant IAC_IAF133                     \ [0x05] illegal access flag clear for peripheral 133
    $06 constant IAC_IAF134                     \ [0x06] illegal access flag clear for peripheral 134
    $07 constant IAC_IAF135                     \ [0x07] illegal access flag clear for peripheral 135
    $08 constant IAC_IAF136                     \ [0x08] illegal access flag clear for peripheral 136
    $09 constant IAC_IAF137                     \ [0x09] illegal access flag clear for peripheral 137
    $0a constant IAC_IAF138                     \ [0x0a] illegal access flag clear for peripheral 138
    $0b constant IAC_IAF139                     \ [0x0b] illegal access flag clear for peripheral 139
    $0c constant IAC_IAF140                     \ [0x0c] illegal access flag clear for peripheral 140
    $0d constant IAC_IAF141                     \ [0x0d] illegal access flag clear for peripheral 141
    $0e constant IAC_IAF142                     \ [0x0e] illegal access flag clear for peripheral 142
    $0f constant IAC_IAF143                     \ [0x0f] illegal access flag clear for peripheral 143
    $10 constant IAC_IAF144                     \ [0x10] illegal access flag clear for peripheral 144
    $11 constant IAC_IAF145                     \ [0x11] illegal access flag clear for peripheral 145
    $12 constant IAC_IAF146                     \ [0x12] illegal access flag clear for peripheral 146
    $13 constant IAC_IAF147                     \ [0x13] illegal access flag clear for peripheral 147
    $14 constant IAC_IAF148                     \ [0x14] illegal access flag clear for peripheral 148
    $15 constant IAC_IAF149                     \ [0x15] illegal access flag clear for peripheral 149
    $16 constant IAC_IAF150                     \ [0x16] illegal access flag clear for peripheral 150
    $17 constant IAC_IAF151                     \ [0x17] illegal access flag clear for peripheral 151
    $18 constant IAC_IAF152                     \ [0x18] illegal access flag clear for peripheral 152
    $19 constant IAC_IAF153                     \ [0x19] illegal access flag clear for peripheral 153
    $1a constant IAC_IAF154                     \ [0x1a] illegal access flag clear for peripheral 154
    $1b constant IAC_IAF155                     \ [0x1b] illegal access flag clear for peripheral 155
    $1c constant IAC_IAF156                     \ [0x1c] illegal access flag clear for peripheral 156
    $1d constant IAC_IAF157                     \ [0x1d] illegal access flag clear for peripheral 157
    $1e constant IAC_IAF158                     \ [0x1e] illegal access flag clear for peripheral 158
    $1f constant IAC_IAF159                     \ [0x1f] illegal access flag clear for peripheral 159
  [then]


  [ifdef] IAC_IAC_ICR5_DEF
    \
    \ @brief IAC interrupt clear register 5
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant IAC_IAF160                     \ [0x00] illegal access flag clear for peripheral 160
    $01 constant IAC_IAF161                     \ [0x01] illegal access flag clear for peripheral 161
    $02 constant IAC_IAF162                     \ [0x02] illegal access flag clear for peripheral 162
    $03 constant IAC_IAF163                     \ [0x03] illegal access flag clear for peripheral 163
    $04 constant IAC_IAF164                     \ [0x04] illegal access flag clear for peripheral 164
    $05 constant IAC_IAF165                     \ [0x05] illegal access flag clear for peripheral 165
    $06 constant IAC_IAF166                     \ [0x06] illegal access flag clear for peripheral 166
    $07 constant IAC_IAF167                     \ [0x07] illegal access flag clear for peripheral 167
    $08 constant IAC_IAF168                     \ [0x08] illegal access flag clear for peripheral 168
    $09 constant IAC_IAF169                     \ [0x09] illegal access flag clear for peripheral 169
    $0a constant IAC_IAF170                     \ [0x0a] illegal access flag clear for peripheral 170
    $0b constant IAC_IAF171                     \ [0x0b] illegal access flag clear for peripheral 171
    $0c constant IAC_IAF172                     \ [0x0c] illegal access flag clear for peripheral 172
    $0d constant IAC_IAF173                     \ [0x0d] illegal access flag clear for peripheral 173
    $0e constant IAC_IAF174                     \ [0x0e] illegal access flag clear for peripheral 174
    $0f constant IAC_IAF175                     \ [0x0f] illegal access flag clear for peripheral 175
    $10 constant IAC_IAF176                     \ [0x10] illegal access flag clear for peripheral 176
    $11 constant IAC_IAF177                     \ [0x11] illegal access flag clear for peripheral 177
    $12 constant IAC_IAF178                     \ [0x12] illegal access flag clear for peripheral 178
    $13 constant IAC_IAF179                     \ [0x13] illegal access flag clear for peripheral 179
    $14 constant IAC_IAF180                     \ [0x14] illegal access flag clear for peripheral 180
    $15 constant IAC_IAF181                     \ [0x15] illegal access flag clear for peripheral 181
    $16 constant IAC_IAF182                     \ [0x16] illegal access flag clear for peripheral 182
    $17 constant IAC_IAF183                     \ [0x17] illegal access flag clear for peripheral 183
    $18 constant IAC_IAF184                     \ [0x18] illegal access flag clear for peripheral 184
    $19 constant IAC_IAF185                     \ [0x19] illegal access flag clear for peripheral 185
    $1a constant IAC_IAF186                     \ [0x1a] illegal access flag clear for peripheral 186
    $1b constant IAC_IAF187                     \ [0x1b] illegal access flag clear for peripheral 187
    $1c constant IAC_IAF188                     \ [0x1c] illegal access flag clear for peripheral 188
    $1d constant IAC_IAF189                     \ [0x1d] illegal access flag clear for peripheral 189
    $1e constant IAC_IAF190                     \ [0x1e] illegal access flag clear for peripheral 190
    $1f constant IAC_IAF191                     \ [0x1f] illegal access flag clear for peripheral 191
  [then]


  [ifdef] IAC_IAC_IISR0_DEF
    \
    \ @brief IAC ILAC input status register 0
    \ Address offset: 0x36C
    \ Reset value: 0xFFFFFF7F
    \
    $00 constant IAC_ILACIN0                    \ [0x00] illegal access input 0
    $01 constant IAC_ILACIN1                    \ [0x01] illegal access input 1
    $02 constant IAC_ILACIN2                    \ [0x02] illegal access input 2
    $03 constant IAC_ILACIN3                    \ [0x03] illegal access input 3
    $04 constant IAC_ILACIN4                    \ [0x04] illegal access input 4
    $05 constant IAC_ILACIN5                    \ [0x05] illegal access input 5
    $06 constant IAC_ILACIN6                    \ [0x06] illegal access input 6
    $07 constant IAC_ILACIN7                    \ [0x07] illegal access input 7
    $08 constant IAC_ILACIN8                    \ [0x08] illegal access input 8
    $09 constant IAC_ILACIN9                    \ [0x09] illegal access input 9
    $0a constant IAC_ILACIN10                   \ [0x0a] illegal access input 10
    $0b constant IAC_ILACIN11                   \ [0x0b] illegal access input 11
    $0c constant IAC_ILACIN12                   \ [0x0c] illegal access input 12
    $0d constant IAC_ILACIN13                   \ [0x0d] illegal access input 13
    $0e constant IAC_ILACIN14                   \ [0x0e] illegal access input 14
    $0f constant IAC_ILACIN15                   \ [0x0f] illegal access input 15
    $10 constant IAC_ILACIN16                   \ [0x10] illegal access input 16
    $11 constant IAC_ILACIN17                   \ [0x11] illegal access input 17
    $12 constant IAC_ILACIN18                   \ [0x12] illegal access input 18
    $13 constant IAC_ILACIN19                   \ [0x13] illegal access input 19
    $14 constant IAC_ILACIN20                   \ [0x14] illegal access input 20
    $15 constant IAC_ILACIN21                   \ [0x15] illegal access input 21
    $16 constant IAC_ILACIN22                   \ [0x16] illegal access input 22
    $17 constant IAC_ILACIN23                   \ [0x17] illegal access input 23
    $18 constant IAC_ILACIN24                   \ [0x18] illegal access input 24
    $19 constant IAC_ILACIN25                   \ [0x19] illegal access input 25
    $1a constant IAC_ILACIN26                   \ [0x1a] illegal access input 26
    $1b constant IAC_ILACIN27                   \ [0x1b] illegal access input 27
    $1c constant IAC_ILACIN28                   \ [0x1c] illegal access input 28
    $1d constant IAC_ILACIN29                   \ [0x1d] illegal access input 29
    $1e constant IAC_ILACIN30                   \ [0x1e] illegal access input 30
    $1f constant IAC_ILACIN31                   \ [0x1f] illegal access input 31
  [then]


  [ifdef] IAC_IAC_IISR1_DEF
    \
    \ @brief IAC ILAC input status register 1
    \ Address offset: 0x370
    \ Reset value: 0x77FFFFFF
    \
    $00 constant IAC_ILACIN32                   \ [0x00] illegal access input 32
    $01 constant IAC_ILACIN33                   \ [0x01] illegal access input 33
    $02 constant IAC_ILACIN34                   \ [0x02] illegal access input 34
    $03 constant IAC_ILACIN35                   \ [0x03] illegal access input 35
    $04 constant IAC_ILACIN36                   \ [0x04] illegal access input 36
    $05 constant IAC_ILACIN37                   \ [0x05] illegal access input 37
    $06 constant IAC_ILACIN38                   \ [0x06] illegal access input 38
    $07 constant IAC_ILACIN39                   \ [0x07] illegal access input 39
    $08 constant IAC_ILACIN40                   \ [0x08] illegal access input 40
    $09 constant IAC_ILACIN41                   \ [0x09] illegal access input 41
    $0a constant IAC_ILACIN42                   \ [0x0a] illegal access input 42
    $0b constant IAC_ILACIN43                   \ [0x0b] illegal access input 43
    $0c constant IAC_ILACIN44                   \ [0x0c] illegal access input 44
    $0d constant IAC_ILACIN45                   \ [0x0d] illegal access input 45
    $0e constant IAC_ILACIN46                   \ [0x0e] illegal access input 46
    $0f constant IAC_ILACIN47                   \ [0x0f] illegal access input 47
    $10 constant IAC_ILACIN48                   \ [0x10] illegal access input 48
    $11 constant IAC_ILACIN49                   \ [0x11] illegal access input 49
    $12 constant IAC_ILACIN50                   \ [0x12] illegal access input 50
    $13 constant IAC_ILACIN51                   \ [0x13] illegal access input 51
    $14 constant IAC_ILACIN52                   \ [0x14] illegal access input 52
    $15 constant IAC_ILACIN53                   \ [0x15] illegal access input 53
    $16 constant IAC_ILACIN54                   \ [0x16] illegal access input 54
    $17 constant IAC_ILACIN55                   \ [0x17] illegal access input 55
    $18 constant IAC_ILACIN56                   \ [0x18] illegal access input 56
    $19 constant IAC_ILACIN57                   \ [0x19] illegal access input 57
    $1a constant IAC_ILACIN58                   \ [0x1a] illegal access input 58
    $1b constant IAC_ILACIN59                   \ [0x1b] illegal access input 59
    $1c constant IAC_ILACIN60                   \ [0x1c] illegal access input 60
    $1d constant IAC_ILACIN61                   \ [0x1d] illegal access input 61
    $1e constant IAC_ILACIN62                   \ [0x1e] illegal access input 62
    $1f constant IAC_ILACIN63                   \ [0x1f] illegal access input 63
  [then]


  [ifdef] IAC_IAC_IISR2_DEF
    \
    \ @brief IAC ILAC input status register 2
    \ Address offset: 0x374
    \ Reset value: 0x77DFF03B
    \
    $00 constant IAC_ILACIN64                   \ [0x00] illegal access input 64
    $01 constant IAC_ILACIN65                   \ [0x01] illegal access input 65
    $02 constant IAC_ILACIN66                   \ [0x02] illegal access input 66
    $03 constant IAC_ILACIN67                   \ [0x03] illegal access input 67
    $04 constant IAC_ILACIN68                   \ [0x04] illegal access input 68
    $05 constant IAC_ILACIN69                   \ [0x05] illegal access input 69
    $06 constant IAC_ILACIN70                   \ [0x06] illegal access input 70
    $07 constant IAC_ILACIN71                   \ [0x07] illegal access input 71
    $08 constant IAC_ILACIN72                   \ [0x08] illegal access input 72
    $09 constant IAC_ILACIN73                   \ [0x09] illegal access input 73
    $0a constant IAC_ILACIN74                   \ [0x0a] illegal access input 74
    $0b constant IAC_ILACIN75                   \ [0x0b] illegal access input 75
    $0c constant IAC_ILACIN76                   \ [0x0c] illegal access input 76
    $0d constant IAC_ILACIN77                   \ [0x0d] illegal access input 77
    $0e constant IAC_ILACIN78                   \ [0x0e] illegal access input 78
    $0f constant IAC_ILACIN79                   \ [0x0f] illegal access input 79
    $10 constant IAC_ILACIN80                   \ [0x10] illegal access input 80
    $11 constant IAC_ILACIN81                   \ [0x11] illegal access input 81
    $12 constant IAC_ILACIN82                   \ [0x12] illegal access input 82
    $13 constant IAC_ILACIN83                   \ [0x13] illegal access input 83
    $14 constant IAC_ILACIN84                   \ [0x14] illegal access input 84
    $15 constant IAC_ILACIN85                   \ [0x15] illegal access input 85
    $16 constant IAC_ILACIN86                   \ [0x16] illegal access input 86
    $17 constant IAC_ILACIN87                   \ [0x17] illegal access input 87
    $18 constant IAC_ILACIN88                   \ [0x18] illegal access input 88
    $19 constant IAC_ILACIN89                   \ [0x19] illegal access input 89
    $1a constant IAC_ILACIN90                   \ [0x1a] illegal access input 90
    $1b constant IAC_ILACIN91                   \ [0x1b] illegal access input 91
    $1c constant IAC_ILACIN92                   \ [0x1c] illegal access input 92
    $1d constant IAC_ILACIN93                   \ [0x1d] illegal access input 93
    $1e constant IAC_ILACIN94                   \ [0x1e] illegal access input 94
    $1f constant IAC_ILACIN95                   \ [0x1f] illegal access input 95
  [then]


  [ifdef] IAC_IAC_IISR3_DEF
    \
    \ @brief IAC ILAC input status register 3
    \ Address offset: 0x378
    \ Reset value: 0x000005FF
    \
    $00 constant IAC_ILACIN96                   \ [0x00] illegal access input 96
    $01 constant IAC_ILACIN97                   \ [0x01] illegal access input 97
    $02 constant IAC_ILACIN98                   \ [0x02] illegal access input 98
    $03 constant IAC_ILACIN99                   \ [0x03] illegal access input 99
    $04 constant IAC_ILACIN100                  \ [0x04] illegal access input 100
    $05 constant IAC_ILACIN101                  \ [0x05] illegal access input 101
    $06 constant IAC_ILACIN102                  \ [0x06] illegal access input 102
    $07 constant IAC_ILACIN103                  \ [0x07] illegal access input 103
    $08 constant IAC_ILACIN104                  \ [0x08] illegal access input 104
    $09 constant IAC_ILACIN105                  \ [0x09] illegal access input 105
    $0a constant IAC_ILACIN106                  \ [0x0a] illegal access input 106
    $0b constant IAC_ILACIN107                  \ [0x0b] illegal access input 107
    $0c constant IAC_ILACIN108                  \ [0x0c] illegal access input 108
    $0d constant IAC_ILACIN109                  \ [0x0d] illegal access input 109
    $0e constant IAC_ILACIN110                  \ [0x0e] illegal access input 110
    $0f constant IAC_ILACIN111                  \ [0x0f] illegal access input 111
    $10 constant IAC_ILACIN112                  \ [0x10] illegal access input 112
    $11 constant IAC_ILACIN113                  \ [0x11] illegal access input 113
    $12 constant IAC_ILACIN114                  \ [0x12] illegal access input 114
    $13 constant IAC_ILACIN115                  \ [0x13] illegal access input 115
    $14 constant IAC_ILACIN116                  \ [0x14] illegal access input 116
    $15 constant IAC_ILACIN117                  \ [0x15] illegal access input 117
    $16 constant IAC_ILACIN118                  \ [0x16] illegal access input 118
    $17 constant IAC_ILACIN119                  \ [0x17] illegal access input 119
    $18 constant IAC_ILACIN120                  \ [0x18] illegal access input 120
    $19 constant IAC_ILACIN121                  \ [0x19] illegal access input 121
    $1a constant IAC_ILACIN122                  \ [0x1a] illegal access input 122
    $1b constant IAC_ILACIN123                  \ [0x1b] illegal access input 123
    $1c constant IAC_ILACIN124                  \ [0x1c] illegal access input 124
    $1d constant IAC_ILACIN125                  \ [0x1d] illegal access input 125
    $1e constant IAC_ILACIN126                  \ [0x1e] illegal access input 126
    $1f constant IAC_ILACIN127                  \ [0x1f] illegal access input 127
  [then]


  [ifdef] IAC_IAC_IISR4_DEF
    \
    \ @brief IAC ILAC input status register 4
    \ Address offset: 0x37C
    \ Reset value: 0x7BEFFFEF
    \
    $00 constant IAC_ILACIN128                  \ [0x00] illegal access input 128
    $01 constant IAC_ILACIN129                  \ [0x01] illegal access input 129
    $02 constant IAC_ILACIN130                  \ [0x02] illegal access input 130
    $03 constant IAC_ILACIN131                  \ [0x03] illegal access input 131
    $04 constant IAC_ILACIN132                  \ [0x04] illegal access input 132
    $05 constant IAC_ILACIN133                  \ [0x05] illegal access input 133
    $06 constant IAC_ILACIN134                  \ [0x06] illegal access input 134
    $07 constant IAC_ILACIN135                  \ [0x07] illegal access input 135
    $08 constant IAC_ILACIN136                  \ [0x08] illegal access input 136
    $09 constant IAC_ILACIN137                  \ [0x09] illegal access input 137
    $0a constant IAC_ILACIN138                  \ [0x0a] illegal access input 138
    $0b constant IAC_ILACIN139                  \ [0x0b] illegal access input 139
    $0c constant IAC_ILACIN140                  \ [0x0c] illegal access input 140
    $0d constant IAC_ILACIN141                  \ [0x0d] illegal access input 141
    $0e constant IAC_ILACIN142                  \ [0x0e] illegal access input 142
    $0f constant IAC_ILACIN143                  \ [0x0f] illegal access input 143
    $10 constant IAC_ILACIN144                  \ [0x10] illegal access input 144
    $11 constant IAC_ILACIN145                  \ [0x11] illegal access input 145
    $12 constant IAC_ILACIN146                  \ [0x12] illegal access input 146
    $13 constant IAC_ILACIN147                  \ [0x13] illegal access input 147
    $14 constant IAC_ILACIN148                  \ [0x14] illegal access input 148
    $15 constant IAC_ILACIN149                  \ [0x15] illegal access input 149
    $16 constant IAC_ILACIN150                  \ [0x16] illegal access input 150
    $17 constant IAC_ILACIN151                  \ [0x17] illegal access input 151
    $18 constant IAC_ILACIN152                  \ [0x18] illegal access input 152
    $19 constant IAC_ILACIN153                  \ [0x19] illegal access input 153
    $1a constant IAC_ILACIN154                  \ [0x1a] illegal access input 154
    $1b constant IAC_ILACIN155                  \ [0x1b] illegal access input 155
    $1c constant IAC_ILACIN156                  \ [0x1c] illegal access input 156
    $1d constant IAC_ILACIN157                  \ [0x1d] illegal access input 157
    $1e constant IAC_ILACIN158                  \ [0x1e] illegal access input 158
    $1f constant IAC_ILACIN159                  \ [0x1f] illegal access input 159
  [then]


  [ifdef] IAC_IAC_IISR5_DEF
    \
    \ @brief IAC ILAC input status register 5
    \ Address offset: 0x384
    \ Reset value: 0x00000000
    \
    $00 constant IAC_ILACIN128                  \ [0x00] illegal access input 128
    $01 constant IAC_ILACIN129                  \ [0x01] illegal access input 129
    $02 constant IAC_ILACIN130                  \ [0x02] illegal access input 130
    $03 constant IAC_ILACIN131                  \ [0x03] illegal access input 131
    $04 constant IAC_ILACIN132                  \ [0x04] illegal access input 132
    $05 constant IAC_ILACIN133                  \ [0x05] illegal access input 133
    $06 constant IAC_ILACIN134                  \ [0x06] illegal access input 134
    $07 constant IAC_ILACIN135                  \ [0x07] illegal access input 135
    $08 constant IAC_ILACIN136                  \ [0x08] illegal access input 136
    $09 constant IAC_ILACIN137                  \ [0x09] illegal access input 137
    $0a constant IAC_ILACIN138                  \ [0x0a] illegal access input 138
    $0b constant IAC_ILACIN139                  \ [0x0b] illegal access input 139
    $0c constant IAC_ILACIN140                  \ [0x0c] illegal access input 140
    $0d constant IAC_ILACIN141                  \ [0x0d] illegal access input 141
    $0e constant IAC_ILACIN142                  \ [0x0e] illegal access input 142
    $0f constant IAC_ILACIN143                  \ [0x0f] illegal access input 143
    $10 constant IAC_ILACIN144                  \ [0x10] illegal access input 144
    $11 constant IAC_ILACIN145                  \ [0x11] illegal access input 145
    $12 constant IAC_ILACIN146                  \ [0x12] illegal access input 146
    $13 constant IAC_ILACIN147                  \ [0x13] illegal access input 147
    $14 constant IAC_ILACIN148                  \ [0x14] illegal access input 148
    $15 constant IAC_ILACIN149                  \ [0x15] illegal access input 149
    $16 constant IAC_ILACIN150                  \ [0x16] illegal access input 150
    $17 constant IAC_ILACIN151                  \ [0x17] illegal access input 151
    $18 constant IAC_ILACIN152                  \ [0x18] illegal access input 152
    $19 constant IAC_ILACIN153                  \ [0x19] illegal access input 153
    $1a constant IAC_ILACIN154                  \ [0x1a] illegal access input 154
    $1b constant IAC_ILACIN155                  \ [0x1b] illegal access input 155
    $1c constant IAC_ILACIN156                  \ [0x1c] illegal access input 156
    $1d constant IAC_ILACIN157                  \ [0x1d] illegal access input 157
    $1e constant IAC_ILACIN158                  \ [0x1e] illegal access input 158
    $1f constant IAC_ILACIN159                  \ [0x1f] illegal access input 159
  [then]

  \
  \ @brief Illegal access controller
  \
  $00 constant IAC_IAC_IER0             \ IAC interrupt enable register 0
  $04 constant IAC_IAC_IER1             \ IAC interrupt enable register 1
  $08 constant IAC_IAC_IER2             \ IAC interrupt enable register 2
  $0C constant IAC_IAC_IER3             \ IAC interrupt enable register 3
  $10 constant IAC_IAC_IER4             \ IAC interrupt enable register 4
  $14 constant IAC_IAC_IER5             \ IAC interrupt enable register 5
  $80 constant IAC_IAC_ISR0             \ IAC interrupt status register 0
  $84 constant IAC_IAC_ISR1             \ IAC interrupt status register 1
  $88 constant IAC_IAC_ISR2             \ IAC interrupt status register 2
  $8C constant IAC_IAC_ISR3             \ IAC interrupt status register 3
  $90 constant IAC_IAC_ISR4             \ IAC interrupt status register 4
  $94 constant IAC_IAC_ISR5             \ IAC interrupt status register 5
  $100 constant IAC_IAC_ICR0            \ IAC interrupt clear register 0
  $104 constant IAC_IAC_ICR1            \ IAC interrupt clear register 1
  $108 constant IAC_IAC_ICR2            \ IAC interrupt clear register 2
  $10C constant IAC_IAC_ICR3            \ IAC interrupt clear register 3
  $110 constant IAC_IAC_ICR4            \ IAC interrupt clear register 4
  $114 constant IAC_IAC_ICR5            \ IAC interrupt clear register 5
  $36C constant IAC_IAC_IISR0           \ IAC ILAC input status register 0
  $370 constant IAC_IAC_IISR1           \ IAC ILAC input status register 1
  $374 constant IAC_IAC_IISR2           \ IAC ILAC input status register 2
  $378 constant IAC_IAC_IISR3           \ IAC ILAC input status register 3
  $37C constant IAC_IAC_IISR4           \ IAC ILAC input status register 4
  $384 constant IAC_IAC_IISR5           \ IAC ILAC input status register 5

: IAC_DEF ; [then]
