\
\ @file iac.fs
\ @brief Illegal access controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief IAC interrupt enable register 0
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant IAC_IAC_IER0_IAIE0                               \ illegal access interrupt enable for peripheral 0
$00000002 constant IAC_IAC_IER0_IAIE1                               \ illegal access interrupt enable for peripheral 1
$00000004 constant IAC_IAC_IER0_IAIE2                               \ illegal access interrupt enable for peripheral 2
$00000008 constant IAC_IAC_IER0_IAIE3                               \ illegal access interrupt enable for peripheral 3
$00000010 constant IAC_IAC_IER0_IAIE4                               \ illegal access interrupt enable for peripheral 4
$00000020 constant IAC_IAC_IER0_IAIE5                               \ illegal access interrupt enable for peripheral 5
$00000040 constant IAC_IAC_IER0_IAIE6                               \ illegal access interrupt enable for peripheral 6
$00000080 constant IAC_IAC_IER0_IAIE7                               \ illegal access interrupt enable for peripheral 7
$00000100 constant IAC_IAC_IER0_IAIE8                               \ illegal access interrupt enable for peripheral 8
$00000200 constant IAC_IAC_IER0_IAIE9                               \ illegal access interrupt enable for peripheral 9
$00000400 constant IAC_IAC_IER0_IAIE10                              \ illegal access interrupt enable for peripheral 10
$00000800 constant IAC_IAC_IER0_IAIE11                              \ illegal access interrupt enable for peripheral 11
$00001000 constant IAC_IAC_IER0_IAIE12                              \ illegal access interrupt enable for peripheral 12
$00002000 constant IAC_IAC_IER0_IAIE13                              \ illegal access interrupt enable for peripheral 13
$00004000 constant IAC_IAC_IER0_IAIE14                              \ illegal access interrupt enable for peripheral 14
$00008000 constant IAC_IAC_IER0_IAIE15                              \ illegal access interrupt enable for peripheral 15
$00010000 constant IAC_IAC_IER0_IAIE16                              \ illegal access interrupt enable for peripheral 16
$00020000 constant IAC_IAC_IER0_IAIE17                              \ illegal access interrupt enable for peripheral 17
$00040000 constant IAC_IAC_IER0_IAIE18                              \ illegal access interrupt enable for peripheral 18
$00080000 constant IAC_IAC_IER0_IAIE19                              \ illegal access interrupt enable for peripheral 19
$00100000 constant IAC_IAC_IER0_IAIE20                              \ illegal access interrupt enable for peripheral 20
$00200000 constant IAC_IAC_IER0_IAIE21                              \ illegal access interrupt enable for peripheral 21
$00400000 constant IAC_IAC_IER0_IAIE22                              \ illegal access interrupt enable for peripheral 22
$00800000 constant IAC_IAC_IER0_IAIE23                              \ illegal access interrupt enable for peripheral 23
$01000000 constant IAC_IAC_IER0_IAIE24                              \ illegal access interrupt enable for peripheral 24
$02000000 constant IAC_IAC_IER0_IAIE25                              \ illegal access interrupt enable for peripheral 25
$04000000 constant IAC_IAC_IER0_IAIE26                              \ illegal access interrupt enable for peripheral 26
$08000000 constant IAC_IAC_IER0_IAIE27                              \ illegal access interrupt enable for peripheral 27
$10000000 constant IAC_IAC_IER0_IAIE28                              \ illegal access interrupt enable for peripheral 28
$20000000 constant IAC_IAC_IER0_IAIE29                              \ illegal access interrupt enable for peripheral 29
$40000000 constant IAC_IAC_IER0_IAIE30                              \ illegal access interrupt enable for peripheral 30
$80000000 constant IAC_IAC_IER0_IAIE31                              \ illegal access interrupt enable for peripheral 31


\
\ @brief IAC interrupt enable register 1
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant IAC_IAC_IER1_IAIE32                              \ illegal access interrupt enable for peripheral 32
$00000002 constant IAC_IAC_IER1_IAIE33                              \ illegal access interrupt enable for peripheral 33
$00000004 constant IAC_IAC_IER1_IAIE34                              \ illegal access interrupt enable for peripheral 34
$00000008 constant IAC_IAC_IER1_IAIE35                              \ illegal access interrupt enable for peripheral 35
$00000010 constant IAC_IAC_IER1_IAIE36                              \ illegal access interrupt enable for peripheral 36
$00000020 constant IAC_IAC_IER1_IAIE37                              \ illegal access interrupt enable for peripheral 37
$00000040 constant IAC_IAC_IER1_IAIE38                              \ illegal access interrupt enable for peripheral 38
$00000080 constant IAC_IAC_IER1_IAIE39                              \ illegal access interrupt enable for peripheral 39
$00000100 constant IAC_IAC_IER1_IAIE40                              \ illegal access interrupt enable for peripheral 40
$00000200 constant IAC_IAC_IER1_IAIE41                              \ illegal access interrupt enable for peripheral 41
$00000400 constant IAC_IAC_IER1_IAIE42                              \ illegal access interrupt enable for peripheral 42
$00000800 constant IAC_IAC_IER1_IAIE43                              \ illegal access interrupt enable for peripheral 43
$00001000 constant IAC_IAC_IER1_IAIE44                              \ illegal access interrupt enable for peripheral 44
$00002000 constant IAC_IAC_IER1_IAIE45                              \ illegal access interrupt enable for peripheral 45
$00004000 constant IAC_IAC_IER1_IAIE46                              \ illegal access interrupt enable for peripheral 46
$00008000 constant IAC_IAC_IER1_IAIE47                              \ illegal access interrupt enable for peripheral 47
$00010000 constant IAC_IAC_IER1_IAIE48                              \ illegal access interrupt enable for peripheral 48
$00020000 constant IAC_IAC_IER1_IAIE49                              \ illegal access interrupt enable for peripheral 49
$00040000 constant IAC_IAC_IER1_IAIE50                              \ illegal access interrupt enable for peripheral 50
$00080000 constant IAC_IAC_IER1_IAIE51                              \ illegal access interrupt enable for peripheral 51
$00100000 constant IAC_IAC_IER1_IAIE52                              \ illegal access interrupt enable for peripheral 52
$00200000 constant IAC_IAC_IER1_IAIE53                              \ illegal access interrupt enable for peripheral 53
$00400000 constant IAC_IAC_IER1_IAIE54                              \ illegal access interrupt enable for peripheral 54
$00800000 constant IAC_IAC_IER1_IAIE55                              \ illegal access interrupt enable for peripheral 55
$01000000 constant IAC_IAC_IER1_IAIE56                              \ illegal access interrupt enable for peripheral 56
$02000000 constant IAC_IAC_IER1_IAIE57                              \ illegal access interrupt enable for peripheral 57
$04000000 constant IAC_IAC_IER1_IAIE58                              \ illegal access interrupt enable for peripheral 58
$08000000 constant IAC_IAC_IER1_IAIE59                              \ illegal access interrupt enable for peripheral 59
$10000000 constant IAC_IAC_IER1_IAIE60                              \ illegal access interrupt enable for peripheral 60
$20000000 constant IAC_IAC_IER1_IAIE61                              \ illegal access interrupt enable for peripheral 61
$40000000 constant IAC_IAC_IER1_IAIE62                              \ illegal access interrupt enable for peripheral 62
$80000000 constant IAC_IAC_IER1_IAIE63                              \ illegal access interrupt enable for peripheral 63


\
\ @brief IAC interrupt enable register 2
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant IAC_IAC_IER2_IAIE64                              \ illegal access interrupt enable for peripheral 64
$00000002 constant IAC_IAC_IER2_IAIE65                              \ illegal access interrupt enable for peripheral 65
$00000004 constant IAC_IAC_IER2_IAIE66                              \ illegal access interrupt enable for peripheral 66
$00000008 constant IAC_IAC_IER2_IAIE67                              \ illegal access interrupt enable for peripheral 67
$00000010 constant IAC_IAC_IER2_IAIE68                              \ illegal access interrupt enable for peripheral 68
$00000020 constant IAC_IAC_IER2_IAIE69                              \ illegal access interrupt enable for peripheral 69
$00000040 constant IAC_IAC_IER2_IAIE70                              \ illegal access interrupt enable for peripheral 70
$00000080 constant IAC_IAC_IER2_IAIE71                              \ illegal access interrupt enable for peripheral 71
$00000100 constant IAC_IAC_IER2_IAIE72                              \ illegal access interrupt enable for peripheral 72
$00000200 constant IAC_IAC_IER2_IAIE73                              \ illegal access interrupt enable for peripheral 73
$00000400 constant IAC_IAC_IER2_IAIE74                              \ illegal access interrupt enable for peripheral 74
$00000800 constant IAC_IAC_IER2_IAIE75                              \ illegal access interrupt enable for peripheral 75
$00001000 constant IAC_IAC_IER2_IAIE76                              \ illegal access interrupt enable for peripheral 76
$00002000 constant IAC_IAC_IER2_IAIE77                              \ illegal access interrupt enable for peripheral 77
$00004000 constant IAC_IAC_IER2_IAIE78                              \ illegal access interrupt enable for peripheral 78
$00008000 constant IAC_IAC_IER2_IAIE79                              \ illegal access interrupt enable for peripheral 79
$00010000 constant IAC_IAC_IER2_IAIE80                              \ illegal access interrupt enable for peripheral 80
$00020000 constant IAC_IAC_IER2_IAIE81                              \ illegal access interrupt enable for peripheral 81
$00040000 constant IAC_IAC_IER2_IAIE82                              \ illegal access interrupt enable for peripheral 82
$00080000 constant IAC_IAC_IER2_IAIE83                              \ illegal access interrupt enable for peripheral 83
$00100000 constant IAC_IAC_IER2_IAIE84                              \ illegal access interrupt enable for peripheral 84
$00200000 constant IAC_IAC_IER2_IAIE85                              \ illegal access interrupt enable for peripheral 85
$00400000 constant IAC_IAC_IER2_IAIE86                              \ illegal access interrupt enable for peripheral 86
$00800000 constant IAC_IAC_IER2_IAIE87                              \ illegal access interrupt enable for peripheral 87
$01000000 constant IAC_IAC_IER2_IAIE88                              \ illegal access interrupt enable for peripheral 88
$02000000 constant IAC_IAC_IER2_IAIE89                              \ illegal access interrupt enable for peripheral 89
$04000000 constant IAC_IAC_IER2_IAIE90                              \ illegal access interrupt enable for peripheral 90
$08000000 constant IAC_IAC_IER2_IAIE91                              \ illegal access interrupt enable for peripheral 91
$10000000 constant IAC_IAC_IER2_IAIE92                              \ illegal access interrupt enable for peripheral 92
$20000000 constant IAC_IAC_IER2_IAIE93                              \ illegal access interrupt enable for peripheral 93
$40000000 constant IAC_IAC_IER2_IAIE94                              \ illegal access interrupt enable for peripheral 94
$80000000 constant IAC_IAC_IER2_IAIE95                              \ illegal access interrupt enable for peripheral 95


\
\ @brief IAC interrupt enable register 3
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant IAC_IAC_IER3_IAIE96                              \ illegal access interrupt enable for peripheral 96
$00000002 constant IAC_IAC_IER3_IAIE97                              \ illegal access interrupt enable for peripheral 97
$00000004 constant IAC_IAC_IER3_IAIE98                              \ illegal access interrupt enable for peripheral 98
$00000008 constant IAC_IAC_IER3_IAIE99                              \ illegal access interrupt enable for peripheral 99
$00000010 constant IAC_IAC_IER3_IAIE100                             \ illegal access interrupt enable for peripheral 100
$00000020 constant IAC_IAC_IER3_IAIE101                             \ illegal access interrupt enable for peripheral 101
$00000040 constant IAC_IAC_IER3_IAIE102                             \ illegal access interrupt enable for peripheral 102
$00000080 constant IAC_IAC_IER3_IAIE103                             \ illegal access interrupt enable for peripheral 103
$00000100 constant IAC_IAC_IER3_IAIE104                             \ illegal access interrupt enable for peripheral 104
$00000200 constant IAC_IAC_IER3_IAIE105                             \ illegal access interrupt enable for peripheral 105
$00000400 constant IAC_IAC_IER3_IAIE106                             \ illegal access interrupt enable for peripheral 106
$00000800 constant IAC_IAC_IER3_IAIE107                             \ illegal access interrupt enable for peripheral 107
$00001000 constant IAC_IAC_IER3_IAIE108                             \ illegal access interrupt enable for peripheral 108
$00002000 constant IAC_IAC_IER3_IAIE109                             \ illegal access interrupt enable for peripheral 109
$00004000 constant IAC_IAC_IER3_IAIE110                             \ illegal access interrupt enable for peripheral 110
$00008000 constant IAC_IAC_IER3_IAIE111                             \ illegal access interrupt enable for peripheral 111
$00010000 constant IAC_IAC_IER3_IAIE112                             \ illegal access interrupt enable for peripheral 112
$00020000 constant IAC_IAC_IER3_IAIE113                             \ illegal access interrupt enable for peripheral 113
$00040000 constant IAC_IAC_IER3_IAIE114                             \ illegal access interrupt enable for peripheral 114
$00080000 constant IAC_IAC_IER3_IAIE115                             \ illegal access interrupt enable for peripheral 115
$00100000 constant IAC_IAC_IER3_IAIE116                             \ illegal access interrupt enable for peripheral 116
$00200000 constant IAC_IAC_IER3_IAIE117                             \ illegal access interrupt enable for peripheral 117
$00400000 constant IAC_IAC_IER3_IAIE118                             \ illegal access interrupt enable for peripheral 118
$00800000 constant IAC_IAC_IER3_IAIE119                             \ illegal access interrupt enable for peripheral 119
$01000000 constant IAC_IAC_IER3_IAIE120                             \ illegal access interrupt enable for peripheral 120
$02000000 constant IAC_IAC_IER3_IAIE121                             \ illegal access interrupt enable for peripheral 121
$04000000 constant IAC_IAC_IER3_IAIE122                             \ illegal access interrupt enable for peripheral 122
$08000000 constant IAC_IAC_IER3_IAIE123                             \ illegal access interrupt enable for peripheral 123
$10000000 constant IAC_IAC_IER3_IAIE124                             \ illegal access interrupt enable for peripheral 124
$20000000 constant IAC_IAC_IER3_IAIE125                             \ illegal access interrupt enable for peripheral 125
$40000000 constant IAC_IAC_IER3_IAIE126                             \ illegal access interrupt enable for peripheral 126
$80000000 constant IAC_IAC_IER3_IAIE127                             \ illegal access interrupt enable for peripheral 127


\
\ @brief IAC interrupt enable register 4
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant IAC_IAC_IER4_IAIE128                             \ illegal access interrupt enable for peripheral 128
$00000002 constant IAC_IAC_IER4_IAIE129                             \ illegal access interrupt enable for peripheral 129
$00000004 constant IAC_IAC_IER4_IAIE130                             \ illegal access interrupt enable for peripheral 130
$00000008 constant IAC_IAC_IER4_IAIE131                             \ illegal access interrupt enable for peripheral 131
$00000010 constant IAC_IAC_IER4_IAIE132                             \ illegal access interrupt enable for peripheral 132
$00000020 constant IAC_IAC_IER4_IAIE133                             \ illegal access interrupt enable for peripheral 133
$00000040 constant IAC_IAC_IER4_IAIE134                             \ illegal access interrupt enable for peripheral 134
$00000080 constant IAC_IAC_IER4_IAIE135                             \ illegal access interrupt enable for peripheral 135
$00000100 constant IAC_IAC_IER4_IAIE136                             \ illegal access interrupt enable for peripheral 136
$00000200 constant IAC_IAC_IER4_IAIE137                             \ illegal access interrupt enable for peripheral 137
$00000400 constant IAC_IAC_IER4_IAIE138                             \ illegal access interrupt enable for peripheral 138
$00000800 constant IAC_IAC_IER4_IAIE139                             \ illegal access interrupt enable for peripheral 139
$00001000 constant IAC_IAC_IER4_IAIE140                             \ illegal access interrupt enable for peripheral 140
$00002000 constant IAC_IAC_IER4_IAIE141                             \ illegal access interrupt enable for peripheral 141
$00004000 constant IAC_IAC_IER4_IAIE142                             \ illegal access interrupt enable for peripheral 142
$00008000 constant IAC_IAC_IER4_IAIE143                             \ illegal access interrupt enable for peripheral 143
$00010000 constant IAC_IAC_IER4_IAIE144                             \ illegal access interrupt enable for peripheral 144
$00020000 constant IAC_IAC_IER4_IAIE145                             \ illegal access interrupt enable for peripheral 145
$00040000 constant IAC_IAC_IER4_IAIE146                             \ illegal access interrupt enable for peripheral 146
$00080000 constant IAC_IAC_IER4_IAIE147                             \ illegal access interrupt enable for peripheral 147
$00100000 constant IAC_IAC_IER4_IAIE148                             \ illegal access interrupt enable for peripheral 148
$00200000 constant IAC_IAC_IER4_IAIE149                             \ illegal access interrupt enable for peripheral 149
$00400000 constant IAC_IAC_IER4_IAIE150                             \ illegal access interrupt enable for peripheral 150
$00800000 constant IAC_IAC_IER4_IAIE151                             \ illegal access interrupt enable for peripheral 151
$01000000 constant IAC_IAC_IER4_IAIE152                             \ illegal access interrupt enable for peripheral 152
$02000000 constant IAC_IAC_IER4_IAIE153                             \ illegal access interrupt enable for peripheral 153
$04000000 constant IAC_IAC_IER4_IAIE154                             \ illegal access interrupt enable for peripheral 154
$08000000 constant IAC_IAC_IER4_IAIE155                             \ illegal access interrupt enable for peripheral 155
$10000000 constant IAC_IAC_IER4_IAIE156                             \ illegal access interrupt enable for peripheral 156
$20000000 constant IAC_IAC_IER4_IAIE157                             \ illegal access interrupt enable for peripheral 157
$40000000 constant IAC_IAC_IER4_IAIE158                             \ illegal access interrupt enable for peripheral 158
$80000000 constant IAC_IAC_IER4_IAIE159                             \ illegal access interrupt enable for peripheral 159


\
\ @brief IAC interrupt enable register 5
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant IAC_IAC_IER5_IAIE160                             \ illegal access interrupt enable for peripheral 160
$00000002 constant IAC_IAC_IER5_IAIE161                             \ illegal access interrupt enable for peripheral 161
$00000004 constant IAC_IAC_IER5_IAIE162                             \ illegal access interrupt enable for peripheral 162
$00000008 constant IAC_IAC_IER5_IAIE163                             \ illegal access interrupt enable for peripheral 163
$00000010 constant IAC_IAC_IER5_IAIE164                             \ illegal access interrupt enable for peripheral 164
$00000020 constant IAC_IAC_IER5_IAIE165                             \ illegal access interrupt enable for peripheral 165
$00000040 constant IAC_IAC_IER5_IAIE166                             \ illegal access interrupt enable for peripheral 166
$00000080 constant IAC_IAC_IER5_IAIE167                             \ illegal access interrupt enable for peripheral 167
$00000100 constant IAC_IAC_IER5_IAIE168                             \ illegal access interrupt enable for peripheral 168
$00000200 constant IAC_IAC_IER5_IAIE169                             \ illegal access interrupt enable for peripheral 169
$00000400 constant IAC_IAC_IER5_IAIE170                             \ illegal access interrupt enable for peripheral 170
$00000800 constant IAC_IAC_IER5_IAIE171                             \ illegal access interrupt enable for peripheral 171
$00001000 constant IAC_IAC_IER5_IAIE172                             \ illegal access interrupt enable for peripheral 172
$00002000 constant IAC_IAC_IER5_IAIE173                             \ illegal access interrupt enable for peripheral 173
$00004000 constant IAC_IAC_IER5_IAIE174                             \ illegal access interrupt enable for peripheral 174
$00008000 constant IAC_IAC_IER5_IAIE175                             \ illegal access interrupt enable for peripheral 175
$00010000 constant IAC_IAC_IER5_IAIE176                             \ illegal access interrupt enable for peripheral 176
$00020000 constant IAC_IAC_IER5_IAIE177                             \ illegal access interrupt enable for peripheral 177
$00040000 constant IAC_IAC_IER5_IAIE178                             \ illegal access interrupt enable for peripheral 178
$00080000 constant IAC_IAC_IER5_IAIE179                             \ illegal access interrupt enable for peripheral 179
$00100000 constant IAC_IAC_IER5_IAIE180                             \ illegal access interrupt enable for peripheral 180
$00200000 constant IAC_IAC_IER5_IAIE181                             \ illegal access interrupt enable for peripheral 181
$00400000 constant IAC_IAC_IER5_IAIE182                             \ illegal access interrupt enable for peripheral 182
$00800000 constant IAC_IAC_IER5_IAIE183                             \ illegal access interrupt enable for peripheral 183
$01000000 constant IAC_IAC_IER5_IAIE184                             \ illegal access interrupt enable for peripheral 184
$02000000 constant IAC_IAC_IER5_IAIE185                             \ illegal access interrupt enable for peripheral 185
$04000000 constant IAC_IAC_IER5_IAIE186                             \ illegal access interrupt enable for peripheral 186
$08000000 constant IAC_IAC_IER5_IAIE187                             \ illegal access interrupt enable for peripheral 187
$10000000 constant IAC_IAC_IER5_IAIE188                             \ illegal access interrupt enable for peripheral 188
$20000000 constant IAC_IAC_IER5_IAIE189                             \ illegal access interrupt enable for peripheral 189
$40000000 constant IAC_IAC_IER5_IAIE190                             \ illegal access interrupt enable for peripheral 190
$80000000 constant IAC_IAC_IER5_IAIE191                             \ illegal access interrupt enable for peripheral 191


\
\ @brief IAC interrupt status register 0
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant IAC_IAC_ISR0_IAF0                                \ illegal access interrupt enable for peripheral 0
$00000002 constant IAC_IAC_ISR0_IAF1                                \ illegal access interrupt enable for peripheral 1
$00000004 constant IAC_IAC_ISR0_IAF2                                \ illegal access interrupt enable for peripheral 2
$00000008 constant IAC_IAC_ISR0_IAF3                                \ illegal access interrupt enable for peripheral 3
$00000010 constant IAC_IAC_ISR0_IAF4                                \ illegal access interrupt enable for peripheral 4
$00000020 constant IAC_IAC_ISR0_IAF5                                \ illegal access interrupt enable for peripheral 5
$00000040 constant IAC_IAC_ISR0_IAF6                                \ illegal access interrupt enable for peripheral 6
$00000080 constant IAC_IAC_ISR0_IAF7                                \ illegal access interrupt enable for peripheral 7
$00000100 constant IAC_IAC_ISR0_IAF8                                \ illegal access interrupt enable for peripheral 8
$00000200 constant IAC_IAC_ISR0_IAF9                                \ illegal access interrupt enable for peripheral 9
$00000400 constant IAC_IAC_ISR0_IAF10                               \ illegal access interrupt enable for peripheral 10
$00000800 constant IAC_IAC_ISR0_IAF11                               \ illegal access interrupt enable for peripheral 11
$00001000 constant IAC_IAC_ISR0_IAF12                               \ illegal access interrupt enable for peripheral 12
$00002000 constant IAC_IAC_ISR0_IAF13                               \ illegal access interrupt enable for peripheral 13
$00004000 constant IAC_IAC_ISR0_IAF14                               \ illegal access interrupt enable for peripheral 14
$00008000 constant IAC_IAC_ISR0_IAF15                               \ illegal access interrupt enable for peripheral 15
$00010000 constant IAC_IAC_ISR0_IAF16                               \ illegal access interrupt enable for peripheral 16
$00020000 constant IAC_IAC_ISR0_IAF17                               \ illegal access interrupt enable for peripheral 17
$00040000 constant IAC_IAC_ISR0_IAF18                               \ illegal access interrupt enable for peripheral 18
$00080000 constant IAC_IAC_ISR0_IAF19                               \ illegal access interrupt enable for peripheral 19
$00100000 constant IAC_IAC_ISR0_IAF20                               \ illegal access interrupt enable for peripheral 20
$00200000 constant IAC_IAC_ISR0_IAF21                               \ illegal access interrupt enable for peripheral 21
$00400000 constant IAC_IAC_ISR0_IAF22                               \ illegal access interrupt enable for peripheral 22
$00800000 constant IAC_IAC_ISR0_IAF23                               \ illegal access interrupt enable for peripheral 23
$01000000 constant IAC_IAC_ISR0_IAF24                               \ illegal access interrupt enable for peripheral 24
$02000000 constant IAC_IAC_ISR0_IAF25                               \ illegal access interrupt enable for peripheral 25
$04000000 constant IAC_IAC_ISR0_IAF26                               \ illegal access interrupt enable for peripheral 26
$08000000 constant IAC_IAC_ISR0_IAF27                               \ illegal access interrupt enable for peripheral 27
$10000000 constant IAC_IAC_ISR0_IAF28                               \ illegal access interrupt enable for peripheral 28
$20000000 constant IAC_IAC_ISR0_IAF29                               \ illegal access interrupt enable for peripheral 29
$40000000 constant IAC_IAC_ISR0_IAF30                               \ illegal access interrupt enable for peripheral 30
$80000000 constant IAC_IAC_ISR0_IAF31                               \ illegal access interrupt enable for peripheral 31


\
\ @brief IAC interrupt status register 1
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant IAC_IAC_ISR1_IAF32                               \ illegal access interrupt enable for peripheral 32
$00000002 constant IAC_IAC_ISR1_IAF33                               \ illegal access interrupt enable for peripheral 33
$00000004 constant IAC_IAC_ISR1_IAF34                               \ illegal access interrupt enable for peripheral 34
$00000008 constant IAC_IAC_ISR1_IAF35                               \ illegal access interrupt enable for peripheral 35
$00000010 constant IAC_IAC_ISR1_IAF36                               \ illegal access interrupt enable for peripheral 36
$00000020 constant IAC_IAC_ISR1_IAF37                               \ illegal access interrupt enable for peripheral 37
$00000040 constant IAC_IAC_ISR1_IAF38                               \ illegal access interrupt enable for peripheral 38
$00000080 constant IAC_IAC_ISR1_IAF39                               \ illegal access interrupt enable for peripheral 39
$00000100 constant IAC_IAC_ISR1_IAF40                               \ illegal access interrupt enable for peripheral 40
$00000200 constant IAC_IAC_ISR1_IAF41                               \ illegal access interrupt enable for peripheral 41
$00000400 constant IAC_IAC_ISR1_IAF42                               \ illegal access interrupt enable for peripheral 42
$00000800 constant IAC_IAC_ISR1_IAF43                               \ illegal access interrupt enable for peripheral 43
$00001000 constant IAC_IAC_ISR1_IAF44                               \ illegal access interrupt enable for peripheral 44
$00002000 constant IAC_IAC_ISR1_IAF45                               \ illegal access interrupt enable for peripheral 45
$00004000 constant IAC_IAC_ISR1_IAF46                               \ illegal access interrupt enable for peripheral 46
$00008000 constant IAC_IAC_ISR1_IAF47                               \ illegal access interrupt enable for peripheral 47
$00010000 constant IAC_IAC_ISR1_IAF48                               \ illegal access interrupt enable for peripheral 48
$00020000 constant IAC_IAC_ISR1_IAF49                               \ illegal access interrupt enable for peripheral 49
$00040000 constant IAC_IAC_ISR1_IAF50                               \ illegal access interrupt enable for peripheral 50
$00080000 constant IAC_IAC_ISR1_IAF51                               \ illegal access interrupt enable for peripheral 51
$00100000 constant IAC_IAC_ISR1_IAF52                               \ illegal access interrupt enable for peripheral 52
$00200000 constant IAC_IAC_ISR1_IAF53                               \ illegal access interrupt enable for peripheral 53
$00400000 constant IAC_IAC_ISR1_IAF54                               \ illegal access interrupt enable for peripheral 54
$00800000 constant IAC_IAC_ISR1_IAF55                               \ illegal access interrupt enable for peripheral 55
$01000000 constant IAC_IAC_ISR1_IAF56                               \ illegal access interrupt enable for peripheral 56
$02000000 constant IAC_IAC_ISR1_IAF57                               \ illegal access interrupt enable for peripheral 57
$04000000 constant IAC_IAC_ISR1_IAF58                               \ illegal access interrupt enable for peripheral 58
$08000000 constant IAC_IAC_ISR1_IAF59                               \ illegal access interrupt enable for peripheral 59
$10000000 constant IAC_IAC_ISR1_IAF60                               \ illegal access interrupt enable for peripheral 60
$20000000 constant IAC_IAC_ISR1_IAF61                               \ illegal access interrupt enable for peripheral 61
$40000000 constant IAC_IAC_ISR1_IAF62                               \ illegal access interrupt enable for peripheral 62
$80000000 constant IAC_IAC_ISR1_IAF63                               \ illegal access interrupt enable for peripheral 63


\
\ @brief IAC interrupt status register 2
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant IAC_IAC_ISR2_IAF64                               \ illegal access interrupt enable for peripheral 64
$00000002 constant IAC_IAC_ISR2_IAF65                               \ illegal access interrupt enable for peripheral 65
$00000004 constant IAC_IAC_ISR2_IAF66                               \ illegal access interrupt enable for peripheral 66
$00000008 constant IAC_IAC_ISR2_IAF67                               \ illegal access interrupt enable for peripheral 67
$00000010 constant IAC_IAC_ISR2_IAF68                               \ illegal access interrupt enable for peripheral 68
$00000020 constant IAC_IAC_ISR2_IAF69                               \ illegal access interrupt enable for peripheral 69
$00000040 constant IAC_IAC_ISR2_IAF70                               \ illegal access interrupt enable for peripheral 70
$00000080 constant IAC_IAC_ISR2_IAF71                               \ illegal access interrupt enable for peripheral 71
$00000100 constant IAC_IAC_ISR2_IAF72                               \ illegal access interrupt enable for peripheral 72
$00000200 constant IAC_IAC_ISR2_IAF73                               \ illegal access interrupt enable for peripheral 73
$00000400 constant IAC_IAC_ISR2_IAF74                               \ illegal access interrupt enable for peripheral 74
$00000800 constant IAC_IAC_ISR2_IAF75                               \ illegal access interrupt enable for peripheral 75
$00001000 constant IAC_IAC_ISR2_IAF76                               \ illegal access interrupt enable for peripheral 76
$00002000 constant IAC_IAC_ISR2_IAF77                               \ illegal access interrupt enable for peripheral 77
$00004000 constant IAC_IAC_ISR2_IAF78                               \ illegal access interrupt enable for peripheral 78
$00008000 constant IAC_IAC_ISR2_IAF79                               \ illegal access interrupt enable for peripheral 79
$00010000 constant IAC_IAC_ISR2_IAF80                               \ illegal access interrupt enable for peripheral 80
$00020000 constant IAC_IAC_ISR2_IAF81                               \ illegal access interrupt enable for peripheral 81
$00040000 constant IAC_IAC_ISR2_IAF82                               \ illegal access interrupt enable for peripheral 82
$00080000 constant IAC_IAC_ISR2_IAF83                               \ illegal access interrupt enable for peripheral 83
$00100000 constant IAC_IAC_ISR2_IAF84                               \ illegal access interrupt enable for peripheral 84
$00200000 constant IAC_IAC_ISR2_IAF85                               \ illegal access interrupt enable for peripheral 85
$00400000 constant IAC_IAC_ISR2_IAF86                               \ illegal access interrupt enable for peripheral 86
$00800000 constant IAC_IAC_ISR2_IAF87                               \ illegal access interrupt enable for peripheral 87
$01000000 constant IAC_IAC_ISR2_IAF88                               \ illegal access interrupt enable for peripheral 88
$02000000 constant IAC_IAC_ISR2_IAF89                               \ illegal access interrupt enable for peripheral 89
$04000000 constant IAC_IAC_ISR2_IAF90                               \ illegal access interrupt enable for peripheral 90
$08000000 constant IAC_IAC_ISR2_IAF91                               \ illegal access interrupt enable for peripheral 91
$10000000 constant IAC_IAC_ISR2_IAF92                               \ illegal access interrupt enable for peripheral 92
$20000000 constant IAC_IAC_ISR2_IAF93                               \ illegal access interrupt enable for peripheral 93
$40000000 constant IAC_IAC_ISR2_IAF94                               \ illegal access interrupt enable for peripheral 94
$80000000 constant IAC_IAC_ISR2_IAF95                               \ illegal access interrupt enable for peripheral 95


\
\ @brief IAC interrupt status register 3
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000001 constant IAC_IAC_ISR3_IAF96                               \ illegal access interrupt enable for peripheral 96
$00000002 constant IAC_IAC_ISR3_IAF97                               \ illegal access interrupt enable for peripheral 97
$00000004 constant IAC_IAC_ISR3_IAF98                               \ illegal access interrupt enable for peripheral 98
$00000008 constant IAC_IAC_ISR3_IAF99                               \ illegal access interrupt enable for peripheral 99
$00000010 constant IAC_IAC_ISR3_IAF100                              \ illegal access interrupt enable for peripheral 100
$00000020 constant IAC_IAC_ISR3_IAF101                              \ illegal access interrupt enable for peripheral 101
$00000040 constant IAC_IAC_ISR3_IAF102                              \ illegal access interrupt enable for peripheral 102
$00000080 constant IAC_IAC_ISR3_IAF103                              \ illegal access interrupt enable for peripheral 103
$00000100 constant IAC_IAC_ISR3_IAF104                              \ illegal access interrupt enable for peripheral 104
$00000200 constant IAC_IAC_ISR3_IAF105                              \ illegal access interrupt enable for peripheral 105
$00000400 constant IAC_IAC_ISR3_IAF106                              \ illegal access interrupt enable for peripheral 106
$00000800 constant IAC_IAC_ISR3_IAF107                              \ illegal access interrupt enable for peripheral 107
$00001000 constant IAC_IAC_ISR3_IAF108                              \ illegal access interrupt enable for peripheral 108
$00002000 constant IAC_IAC_ISR3_IAF109                              \ illegal access interrupt enable for peripheral 109
$00004000 constant IAC_IAC_ISR3_IAF110                              \ illegal access interrupt enable for peripheral 110
$00008000 constant IAC_IAC_ISR3_IAF111                              \ illegal access interrupt enable for peripheral 111
$00010000 constant IAC_IAC_ISR3_IAF112                              \ illegal access interrupt enable for peripheral 112
$00020000 constant IAC_IAC_ISR3_IAF113                              \ illegal access interrupt enable for peripheral 113
$00040000 constant IAC_IAC_ISR3_IAF114                              \ illegal access interrupt enable for peripheral 114
$00080000 constant IAC_IAC_ISR3_IAF115                              \ illegal access interrupt enable for peripheral 115
$00100000 constant IAC_IAC_ISR3_IAF116                              \ illegal access interrupt enable for peripheral 116
$00200000 constant IAC_IAC_ISR3_IAF117                              \ illegal access interrupt enable for peripheral 117
$00400000 constant IAC_IAC_ISR3_IAF118                              \ illegal access interrupt enable for peripheral 118
$00800000 constant IAC_IAC_ISR3_IAF119                              \ illegal access interrupt enable for peripheral 119
$01000000 constant IAC_IAC_ISR3_IAF120                              \ illegal access interrupt enable for peripheral 120
$02000000 constant IAC_IAC_ISR3_IAF121                              \ illegal access interrupt enable for peripheral 121
$04000000 constant IAC_IAC_ISR3_IAF122                              \ illegal access interrupt enable for peripheral 122
$08000000 constant IAC_IAC_ISR3_IAF123                              \ illegal access interrupt enable for peripheral 123
$10000000 constant IAC_IAC_ISR3_IAF124                              \ illegal access interrupt enable for peripheral 124
$20000000 constant IAC_IAC_ISR3_IAF125                              \ illegal access interrupt enable for peripheral 125
$40000000 constant IAC_IAC_ISR3_IAF126                              \ illegal access interrupt enable for peripheral 126
$80000000 constant IAC_IAC_ISR3_IAF127                              \ illegal access interrupt enable for peripheral 127


\
\ @brief IAC interrupt status register 4
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant IAC_IAC_ISR4_IAF128                              \ illegal access interrupt enable for peripheral 128
$00000002 constant IAC_IAC_ISR4_IAF129                              \ illegal access interrupt enable for peripheral 129
$00000004 constant IAC_IAC_ISR4_IAF130                              \ illegal access interrupt enable for peripheral 130
$00000008 constant IAC_IAC_ISR4_IAF131                              \ illegal access interrupt enable for peripheral 131
$00000010 constant IAC_IAC_ISR4_IAF132                              \ illegal access interrupt enable for peripheral 132
$00000020 constant IAC_IAC_ISR4_IAF133                              \ illegal access interrupt enable for peripheral 133
$00000040 constant IAC_IAC_ISR4_IAF134                              \ illegal access interrupt enable for peripheral 134
$00000080 constant IAC_IAC_ISR4_IAF135                              \ illegal access interrupt enable for peripheral 135
$00000100 constant IAC_IAC_ISR4_IAF136                              \ illegal access interrupt enable for peripheral 136
$00000200 constant IAC_IAC_ISR4_IAF137                              \ illegal access interrupt enable for peripheral 137
$00000400 constant IAC_IAC_ISR4_IAF138                              \ illegal access interrupt enable for peripheral 138
$00000800 constant IAC_IAC_ISR4_IAF139                              \ illegal access interrupt enable for peripheral 139
$00001000 constant IAC_IAC_ISR4_IAF140                              \ illegal access interrupt enable for peripheral 140
$00002000 constant IAC_IAC_ISR4_IAF141                              \ illegal access interrupt enable for peripheral 141
$00004000 constant IAC_IAC_ISR4_IAF142                              \ illegal access interrupt enable for peripheral 142
$00008000 constant IAC_IAC_ISR4_IAF143                              \ illegal access interrupt enable for peripheral 143
$00010000 constant IAC_IAC_ISR4_IAF144                              \ illegal access interrupt enable for peripheral 144
$00020000 constant IAC_IAC_ISR4_IAF145                              \ illegal access interrupt enable for peripheral 145
$00040000 constant IAC_IAC_ISR4_IAF146                              \ illegal access interrupt enable for peripheral 146
$00080000 constant IAC_IAC_ISR4_IAF147                              \ illegal access interrupt enable for peripheral 147
$00100000 constant IAC_IAC_ISR4_IAF148                              \ illegal access interrupt enable for peripheral 148
$00200000 constant IAC_IAC_ISR4_IAF149                              \ illegal access interrupt enable for peripheral 149
$00400000 constant IAC_IAC_ISR4_IAF150                              \ illegal access interrupt enable for peripheral 150
$00800000 constant IAC_IAC_ISR4_IAF151                              \ illegal access interrupt enable for peripheral 151
$01000000 constant IAC_IAC_ISR4_IAF152                              \ illegal access interrupt enable for peripheral 152
$02000000 constant IAC_IAC_ISR4_IAF153                              \ illegal access interrupt enable for peripheral 153
$04000000 constant IAC_IAC_ISR4_IAF154                              \ illegal access interrupt enable for peripheral 154
$08000000 constant IAC_IAC_ISR4_IAF155                              \ illegal access interrupt enable for peripheral 155
$10000000 constant IAC_IAC_ISR4_IAF156                              \ illegal access interrupt enable for peripheral 156
$20000000 constant IAC_IAC_ISR4_IAF157                              \ illegal access interrupt enable for peripheral 157
$40000000 constant IAC_IAC_ISR4_IAF158                              \ illegal access interrupt enable for peripheral 158
$80000000 constant IAC_IAC_ISR4_IAF159                              \ illegal access interrupt enable for peripheral 159


\
\ @brief IAC interrupt status register 5
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant IAC_IAC_ISR5_IAF160                              \ illegal access interrupt enable for peripheral 160
$00000002 constant IAC_IAC_ISR5_IAF161                              \ illegal access interrupt enable for peripheral 161
$00000004 constant IAC_IAC_ISR5_IAF162                              \ illegal access interrupt enable for peripheral 162
$00000008 constant IAC_IAC_ISR5_IAF163                              \ illegal access interrupt enable for peripheral 163
$00000010 constant IAC_IAC_ISR5_IAF164                              \ illegal access interrupt enable for peripheral 164
$00000020 constant IAC_IAC_ISR5_IAF165                              \ illegal access interrupt enable for peripheral 165
$00000040 constant IAC_IAC_ISR5_IAF166                              \ illegal access interrupt enable for peripheral 166
$00000080 constant IAC_IAC_ISR5_IAF167                              \ illegal access interrupt enable for peripheral 167
$00000100 constant IAC_IAC_ISR5_IAF168                              \ illegal access interrupt enable for peripheral 168
$00000200 constant IAC_IAC_ISR5_IAF169                              \ illegal access interrupt enable for peripheral 169
$00000400 constant IAC_IAC_ISR5_IAF170                              \ illegal access interrupt enable for peripheral 170
$00000800 constant IAC_IAC_ISR5_IAF171                              \ illegal access interrupt enable for peripheral 171
$00001000 constant IAC_IAC_ISR5_IAF172                              \ illegal access interrupt enable for peripheral 172
$00002000 constant IAC_IAC_ISR5_IAF173                              \ illegal access interrupt enable for peripheral 173
$00004000 constant IAC_IAC_ISR5_IAF174                              \ illegal access interrupt enable for peripheral 174
$00008000 constant IAC_IAC_ISR5_IAF175                              \ illegal access interrupt enable for peripheral 175
$00010000 constant IAC_IAC_ISR5_IAF176                              \ illegal access interrupt enable for peripheral 176
$00020000 constant IAC_IAC_ISR5_IAF177                              \ illegal access interrupt enable for peripheral 177
$00040000 constant IAC_IAC_ISR5_IAF178                              \ illegal access interrupt enable for peripheral 178
$00080000 constant IAC_IAC_ISR5_IAF179                              \ illegal access interrupt enable for peripheral 179
$00100000 constant IAC_IAC_ISR5_IAF180                              \ illegal access interrupt enable for peripheral 180
$00200000 constant IAC_IAC_ISR5_IAF181                              \ illegal access interrupt enable for peripheral 181
$00400000 constant IAC_IAC_ISR5_IAF182                              \ illegal access interrupt enable for peripheral 182
$00800000 constant IAC_IAC_ISR5_IAF183                              \ illegal access interrupt enable for peripheral 183
$01000000 constant IAC_IAC_ISR5_IAF184                              \ illegal access interrupt enable for peripheral 184
$02000000 constant IAC_IAC_ISR5_IAF185                              \ illegal access interrupt enable for peripheral 185
$04000000 constant IAC_IAC_ISR5_IAF186                              \ illegal access interrupt enable for peripheral 186
$08000000 constant IAC_IAC_ISR5_IAF187                              \ illegal access interrupt enable for peripheral 187
$10000000 constant IAC_IAC_ISR5_IAF188                              \ illegal access interrupt enable for peripheral 188
$20000000 constant IAC_IAC_ISR5_IAF189                              \ illegal access interrupt enable for peripheral 189
$40000000 constant IAC_IAC_ISR5_IAF190                              \ illegal access interrupt enable for peripheral 190
$80000000 constant IAC_IAC_ISR5_IAF191                              \ illegal access interrupt enable for peripheral 191


\
\ @brief IAC interrupt clear register 0
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant IAC_IAC_ICR0_IAF0                                \ illegal access flag clear for peripheral 0
$00000002 constant IAC_IAC_ICR0_IAF1                                \ illegal access flag clear for peripheral 1
$00000004 constant IAC_IAC_ICR0_IAF2                                \ illegal access flag clear for peripheral 2
$00000008 constant IAC_IAC_ICR0_IAF3                                \ illegal access flag clear for peripheral 3
$00000010 constant IAC_IAC_ICR0_IAF4                                \ illegal access flag clear for peripheral 4
$00000020 constant IAC_IAC_ICR0_IAF5                                \ illegal access flag clear for peripheral 5
$00000040 constant IAC_IAC_ICR0_IAF6                                \ illegal access flag clear for peripheral 6
$00000080 constant IAC_IAC_ICR0_IAF7                                \ illegal access flag clear for peripheral 7
$00000100 constant IAC_IAC_ICR0_IAF8                                \ illegal access flag clear for peripheral 8
$00000200 constant IAC_IAC_ICR0_IAF9                                \ illegal access flag clear for peripheral 9
$00000400 constant IAC_IAC_ICR0_IAF10                               \ illegal access flag clear for peripheral 10
$00000800 constant IAC_IAC_ICR0_IAF11                               \ illegal access flag clear for peripheral 11
$00001000 constant IAC_IAC_ICR0_IAF12                               \ illegal access flag clear for peripheral 12
$00002000 constant IAC_IAC_ICR0_IAF13                               \ illegal access flag clear for peripheral 13
$00004000 constant IAC_IAC_ICR0_IAF14                               \ illegal access flag clear for peripheral 14
$00008000 constant IAC_IAC_ICR0_IAF15                               \ illegal access flag clear for peripheral 15
$00010000 constant IAC_IAC_ICR0_IAF16                               \ illegal access flag clear for peripheral 16
$00020000 constant IAC_IAC_ICR0_IAF17                               \ illegal access flag clear for peripheral 17
$00040000 constant IAC_IAC_ICR0_IAF18                               \ illegal access flag clear for peripheral 18
$00080000 constant IAC_IAC_ICR0_IAF19                               \ illegal access flag clear for peripheral 19
$00100000 constant IAC_IAC_ICR0_IAF20                               \ illegal access flag clear for peripheral 20
$00200000 constant IAC_IAC_ICR0_IAF21                               \ illegal access flag clear for peripheral 21
$00400000 constant IAC_IAC_ICR0_IAF22                               \ illegal access flag clear for peripheral 22
$00800000 constant IAC_IAC_ICR0_IAF23                               \ illegal access flag clear for peripheral 23
$01000000 constant IAC_IAC_ICR0_IAF24                               \ illegal access flag clear for peripheral 24
$02000000 constant IAC_IAC_ICR0_IAF25                               \ illegal access flag clear for peripheral 25
$04000000 constant IAC_IAC_ICR0_IAF26                               \ illegal access flag clear for peripheral 26
$08000000 constant IAC_IAC_ICR0_IAF27                               \ illegal access flag clear for peripheral 27
$10000000 constant IAC_IAC_ICR0_IAF28                               \ illegal access flag clear for peripheral 28
$20000000 constant IAC_IAC_ICR0_IAF29                               \ illegal access flag clear for peripheral 29
$40000000 constant IAC_IAC_ICR0_IAF30                               \ illegal access flag clear for peripheral 30
$80000000 constant IAC_IAC_ICR0_IAF31                               \ illegal access flag clear for peripheral 31


\
\ @brief IAC interrupt clear register 1
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant IAC_IAC_ICR1_IAF32                               \ illegal access flag clear for peripheral 32
$00000002 constant IAC_IAC_ICR1_IAF33                               \ illegal access flag clear for peripheral 33
$00000004 constant IAC_IAC_ICR1_IAF34                               \ illegal access flag clear for peripheral 34
$00000008 constant IAC_IAC_ICR1_IAF35                               \ illegal access flag clear for peripheral 35
$00000010 constant IAC_IAC_ICR1_IAF36                               \ illegal access flag clear for peripheral 36
$00000020 constant IAC_IAC_ICR1_IAF37                               \ illegal access flag clear for peripheral 37
$00000040 constant IAC_IAC_ICR1_IAF38                               \ illegal access flag clear for peripheral 38
$00000080 constant IAC_IAC_ICR1_IAF39                               \ illegal access flag clear for peripheral 39
$00000100 constant IAC_IAC_ICR1_IAF40                               \ illegal access flag clear for peripheral 40
$00000200 constant IAC_IAC_ICR1_IAF41                               \ illegal access flag clear for peripheral 41
$00000400 constant IAC_IAC_ICR1_IAF42                               \ illegal access flag clear for peripheral 42
$00000800 constant IAC_IAC_ICR1_IAF43                               \ illegal access flag clear for peripheral 43
$00001000 constant IAC_IAC_ICR1_IAF44                               \ illegal access flag clear for peripheral 44
$00002000 constant IAC_IAC_ICR1_IAF45                               \ illegal access flag clear for peripheral 45
$00004000 constant IAC_IAC_ICR1_IAF46                               \ illegal access flag clear for peripheral 46
$00008000 constant IAC_IAC_ICR1_IAF47                               \ illegal access flag clear for peripheral 47
$00010000 constant IAC_IAC_ICR1_IAF48                               \ illegal access flag clear for peripheral 48
$00020000 constant IAC_IAC_ICR1_IAF49                               \ illegal access flag clear for peripheral 49
$00040000 constant IAC_IAC_ICR1_IAF50                               \ illegal access flag clear for peripheral 50
$00080000 constant IAC_IAC_ICR1_IAF51                               \ illegal access flag clear for peripheral 51
$00100000 constant IAC_IAC_ICR1_IAF52                               \ illegal access flag clear for peripheral 52
$00200000 constant IAC_IAC_ICR1_IAF53                               \ illegal access flag clear for peripheral 53
$00400000 constant IAC_IAC_ICR1_IAF54                               \ illegal access flag clear for peripheral 54
$00800000 constant IAC_IAC_ICR1_IAF55                               \ illegal access flag clear for peripheral 55
$01000000 constant IAC_IAC_ICR1_IAF56                               \ illegal access flag clear for peripheral 56
$02000000 constant IAC_IAC_ICR1_IAF57                               \ illegal access flag clear for peripheral 57
$04000000 constant IAC_IAC_ICR1_IAF58                               \ illegal access flag clear for peripheral 58
$08000000 constant IAC_IAC_ICR1_IAF59                               \ illegal access flag clear for peripheral 59
$10000000 constant IAC_IAC_ICR1_IAF60                               \ illegal access flag clear for peripheral 60
$20000000 constant IAC_IAC_ICR1_IAF61                               \ illegal access flag clear for peripheral 61
$40000000 constant IAC_IAC_ICR1_IAF62                               \ illegal access flag clear for peripheral 62
$80000000 constant IAC_IAC_ICR1_IAF63                               \ illegal access flag clear for peripheral 63


\
\ @brief IAC interrupt clear register 2
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant IAC_IAC_ICR2_IAF64                               \ illegal access flag clear for peripheral 64
$00000002 constant IAC_IAC_ICR2_IAF65                               \ illegal access flag clear for peripheral 65
$00000004 constant IAC_IAC_ICR2_IAF66                               \ illegal access flag clear for peripheral 66
$00000008 constant IAC_IAC_ICR2_IAF67                               \ illegal access flag clear for peripheral 67
$00000010 constant IAC_IAC_ICR2_IAF68                               \ illegal access flag clear for peripheral 68
$00000020 constant IAC_IAC_ICR2_IAF69                               \ illegal access flag clear for peripheral 69
$00000040 constant IAC_IAC_ICR2_IAF70                               \ illegal access flag clear for peripheral 70
$00000080 constant IAC_IAC_ICR2_IAF71                               \ illegal access flag clear for peripheral 71
$00000100 constant IAC_IAC_ICR2_IAF72                               \ illegal access flag clear for peripheral 72
$00000200 constant IAC_IAC_ICR2_IAF73                               \ illegal access flag clear for peripheral 73
$00000400 constant IAC_IAC_ICR2_IAF74                               \ illegal access flag clear for peripheral 74
$00000800 constant IAC_IAC_ICR2_IAF75                               \ illegal access flag clear for peripheral 75
$00001000 constant IAC_IAC_ICR2_IAF76                               \ illegal access flag clear for peripheral 76
$00002000 constant IAC_IAC_ICR2_IAF77                               \ illegal access flag clear for peripheral 77
$00004000 constant IAC_IAC_ICR2_IAF78                               \ illegal access flag clear for peripheral 78
$00008000 constant IAC_IAC_ICR2_IAF79                               \ illegal access flag clear for peripheral 79
$00010000 constant IAC_IAC_ICR2_IAF80                               \ illegal access flag clear for peripheral 80
$00020000 constant IAC_IAC_ICR2_IAF81                               \ illegal access flag clear for peripheral 81
$00040000 constant IAC_IAC_ICR2_IAF82                               \ illegal access flag clear for peripheral 82
$00080000 constant IAC_IAC_ICR2_IAF83                               \ illegal access flag clear for peripheral 83
$00100000 constant IAC_IAC_ICR2_IAF84                               \ illegal access flag clear for peripheral 84
$00200000 constant IAC_IAC_ICR2_IAF85                               \ illegal access flag clear for peripheral 85
$00400000 constant IAC_IAC_ICR2_IAF86                               \ illegal access flag clear for peripheral 86
$00800000 constant IAC_IAC_ICR2_IAF87                               \ illegal access flag clear for peripheral 87
$01000000 constant IAC_IAC_ICR2_IAF88                               \ illegal access flag clear for peripheral 88
$02000000 constant IAC_IAC_ICR2_IAF89                               \ illegal access flag clear for peripheral 89
$04000000 constant IAC_IAC_ICR2_IAF90                               \ illegal access flag clear for peripheral 90
$08000000 constant IAC_IAC_ICR2_IAF91                               \ illegal access flag clear for peripheral 91
$10000000 constant IAC_IAC_ICR2_IAF92                               \ illegal access flag clear for peripheral 92
$20000000 constant IAC_IAC_ICR2_IAF93                               \ illegal access flag clear for peripheral 93
$40000000 constant IAC_IAC_ICR2_IAF94                               \ illegal access flag clear for peripheral 94
$80000000 constant IAC_IAC_ICR2_IAF95                               \ illegal access flag clear for peripheral 95


\
\ @brief IAC interrupt clear register 3
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000001 constant IAC_IAC_ICR3_IAF96                               \ illegal access flag clear for peripheral 96
$00000002 constant IAC_IAC_ICR3_IAF97                               \ illegal access flag clear for peripheral 97
$00000004 constant IAC_IAC_ICR3_IAF98                               \ illegal access flag clear for peripheral 98
$00000008 constant IAC_IAC_ICR3_IAF99                               \ illegal access flag clear for peripheral 99
$00000010 constant IAC_IAC_ICR3_IAF100                              \ illegal access flag clear for peripheral 100
$00000020 constant IAC_IAC_ICR3_IAF101                              \ illegal access flag clear for peripheral 101
$00000040 constant IAC_IAC_ICR3_IAF102                              \ illegal access flag clear for peripheral 102
$00000080 constant IAC_IAC_ICR3_IAF103                              \ illegal access flag clear for peripheral 103
$00000100 constant IAC_IAC_ICR3_IAF104                              \ illegal access flag clear for peripheral 104
$00000200 constant IAC_IAC_ICR3_IAF105                              \ illegal access flag clear for peripheral 105
$00000400 constant IAC_IAC_ICR3_IAF106                              \ illegal access flag clear for peripheral 106
$00000800 constant IAC_IAC_ICR3_IAF107                              \ illegal access flag clear for peripheral 107
$00001000 constant IAC_IAC_ICR3_IAF108                              \ illegal access flag clear for peripheral 108
$00002000 constant IAC_IAC_ICR3_IAF109                              \ illegal access flag clear for peripheral 109
$00004000 constant IAC_IAC_ICR3_IAF110                              \ illegal access flag clear for peripheral 110
$00008000 constant IAC_IAC_ICR3_IAF111                              \ illegal access flag clear for peripheral 111
$00010000 constant IAC_IAC_ICR3_IAF112                              \ illegal access flag clear for peripheral 112
$00020000 constant IAC_IAC_ICR3_IAF113                              \ illegal access flag clear for peripheral 113
$00040000 constant IAC_IAC_ICR3_IAF114                              \ illegal access flag clear for peripheral 114
$00080000 constant IAC_IAC_ICR3_IAF115                              \ illegal access flag clear for peripheral 115
$00100000 constant IAC_IAC_ICR3_IAF116                              \ illegal access flag clear for peripheral 116
$00200000 constant IAC_IAC_ICR3_IAF117                              \ illegal access flag clear for peripheral 117
$00400000 constant IAC_IAC_ICR3_IAF118                              \ illegal access flag clear for peripheral 118
$00800000 constant IAC_IAC_ICR3_IAF119                              \ illegal access flag clear for peripheral 119
$01000000 constant IAC_IAC_ICR3_IAF120                              \ illegal access flag clear for peripheral 120
$02000000 constant IAC_IAC_ICR3_IAF121                              \ illegal access flag clear for peripheral 121
$04000000 constant IAC_IAC_ICR3_IAF122                              \ illegal access flag clear for peripheral 122
$08000000 constant IAC_IAC_ICR3_IAF123                              \ illegal access flag clear for peripheral 123
$10000000 constant IAC_IAC_ICR3_IAF124                              \ illegal access flag clear for peripheral 124
$20000000 constant IAC_IAC_ICR3_IAF125                              \ illegal access flag clear for peripheral 125
$40000000 constant IAC_IAC_ICR3_IAF126                              \ illegal access flag clear for peripheral 126
$80000000 constant IAC_IAC_ICR3_IAF127                              \ illegal access flag clear for peripheral 127


\
\ @brief IAC interrupt clear register 4
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000001 constant IAC_IAC_ICR4_IAF128                              \ illegal access flag clear for peripheral 128
$00000002 constant IAC_IAC_ICR4_IAF129                              \ illegal access flag clear for peripheral 129
$00000004 constant IAC_IAC_ICR4_IAF130                              \ illegal access flag clear for peripheral 130
$00000008 constant IAC_IAC_ICR4_IAF131                              \ illegal access flag clear for peripheral 131
$00000010 constant IAC_IAC_ICR4_IAF132                              \ illegal access flag clear for peripheral 132
$00000020 constant IAC_IAC_ICR4_IAF133                              \ illegal access flag clear for peripheral 133
$00000040 constant IAC_IAC_ICR4_IAF134                              \ illegal access flag clear for peripheral 134
$00000080 constant IAC_IAC_ICR4_IAF135                              \ illegal access flag clear for peripheral 135
$00000100 constant IAC_IAC_ICR4_IAF136                              \ illegal access flag clear for peripheral 136
$00000200 constant IAC_IAC_ICR4_IAF137                              \ illegal access flag clear for peripheral 137
$00000400 constant IAC_IAC_ICR4_IAF138                              \ illegal access flag clear for peripheral 138
$00000800 constant IAC_IAC_ICR4_IAF139                              \ illegal access flag clear for peripheral 139
$00001000 constant IAC_IAC_ICR4_IAF140                              \ illegal access flag clear for peripheral 140
$00002000 constant IAC_IAC_ICR4_IAF141                              \ illegal access flag clear for peripheral 141
$00004000 constant IAC_IAC_ICR4_IAF142                              \ illegal access flag clear for peripheral 142
$00008000 constant IAC_IAC_ICR4_IAF143                              \ illegal access flag clear for peripheral 143
$00010000 constant IAC_IAC_ICR4_IAF144                              \ illegal access flag clear for peripheral 144
$00020000 constant IAC_IAC_ICR4_IAF145                              \ illegal access flag clear for peripheral 145
$00040000 constant IAC_IAC_ICR4_IAF146                              \ illegal access flag clear for peripheral 146
$00080000 constant IAC_IAC_ICR4_IAF147                              \ illegal access flag clear for peripheral 147
$00100000 constant IAC_IAC_ICR4_IAF148                              \ illegal access flag clear for peripheral 148
$00200000 constant IAC_IAC_ICR4_IAF149                              \ illegal access flag clear for peripheral 149
$00400000 constant IAC_IAC_ICR4_IAF150                              \ illegal access flag clear for peripheral 150
$00800000 constant IAC_IAC_ICR4_IAF151                              \ illegal access flag clear for peripheral 151
$01000000 constant IAC_IAC_ICR4_IAF152                              \ illegal access flag clear for peripheral 152
$02000000 constant IAC_IAC_ICR4_IAF153                              \ illegal access flag clear for peripheral 153
$04000000 constant IAC_IAC_ICR4_IAF154                              \ illegal access flag clear for peripheral 154
$08000000 constant IAC_IAC_ICR4_IAF155                              \ illegal access flag clear for peripheral 155
$10000000 constant IAC_IAC_ICR4_IAF156                              \ illegal access flag clear for peripheral 156
$20000000 constant IAC_IAC_ICR4_IAF157                              \ illegal access flag clear for peripheral 157
$40000000 constant IAC_IAC_ICR4_IAF158                              \ illegal access flag clear for peripheral 158
$80000000 constant IAC_IAC_ICR4_IAF159                              \ illegal access flag clear for peripheral 159


\
\ @brief IAC interrupt clear register 5
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000001 constant IAC_IAC_ICR5_IAF160                              \ illegal access flag clear for peripheral 160
$00000002 constant IAC_IAC_ICR5_IAF161                              \ illegal access flag clear for peripheral 161
$00000004 constant IAC_IAC_ICR5_IAF162                              \ illegal access flag clear for peripheral 162
$00000008 constant IAC_IAC_ICR5_IAF163                              \ illegal access flag clear for peripheral 163
$00000010 constant IAC_IAC_ICR5_IAF164                              \ illegal access flag clear for peripheral 164
$00000020 constant IAC_IAC_ICR5_IAF165                              \ illegal access flag clear for peripheral 165
$00000040 constant IAC_IAC_ICR5_IAF166                              \ illegal access flag clear for peripheral 166
$00000080 constant IAC_IAC_ICR5_IAF167                              \ illegal access flag clear for peripheral 167
$00000100 constant IAC_IAC_ICR5_IAF168                              \ illegal access flag clear for peripheral 168
$00000200 constant IAC_IAC_ICR5_IAF169                              \ illegal access flag clear for peripheral 169
$00000400 constant IAC_IAC_ICR5_IAF170                              \ illegal access flag clear for peripheral 170
$00000800 constant IAC_IAC_ICR5_IAF171                              \ illegal access flag clear for peripheral 171
$00001000 constant IAC_IAC_ICR5_IAF172                              \ illegal access flag clear for peripheral 172
$00002000 constant IAC_IAC_ICR5_IAF173                              \ illegal access flag clear for peripheral 173
$00004000 constant IAC_IAC_ICR5_IAF174                              \ illegal access flag clear for peripheral 174
$00008000 constant IAC_IAC_ICR5_IAF175                              \ illegal access flag clear for peripheral 175
$00010000 constant IAC_IAC_ICR5_IAF176                              \ illegal access flag clear for peripheral 176
$00020000 constant IAC_IAC_ICR5_IAF177                              \ illegal access flag clear for peripheral 177
$00040000 constant IAC_IAC_ICR5_IAF178                              \ illegal access flag clear for peripheral 178
$00080000 constant IAC_IAC_ICR5_IAF179                              \ illegal access flag clear for peripheral 179
$00100000 constant IAC_IAC_ICR5_IAF180                              \ illegal access flag clear for peripheral 180
$00200000 constant IAC_IAC_ICR5_IAF181                              \ illegal access flag clear for peripheral 181
$00400000 constant IAC_IAC_ICR5_IAF182                              \ illegal access flag clear for peripheral 182
$00800000 constant IAC_IAC_ICR5_IAF183                              \ illegal access flag clear for peripheral 183
$01000000 constant IAC_IAC_ICR5_IAF184                              \ illegal access flag clear for peripheral 184
$02000000 constant IAC_IAC_ICR5_IAF185                              \ illegal access flag clear for peripheral 185
$04000000 constant IAC_IAC_ICR5_IAF186                              \ illegal access flag clear for peripheral 186
$08000000 constant IAC_IAC_ICR5_IAF187                              \ illegal access flag clear for peripheral 187
$10000000 constant IAC_IAC_ICR5_IAF188                              \ illegal access flag clear for peripheral 188
$20000000 constant IAC_IAC_ICR5_IAF189                              \ illegal access flag clear for peripheral 189
$40000000 constant IAC_IAC_ICR5_IAF190                              \ illegal access flag clear for peripheral 190
$80000000 constant IAC_IAC_ICR5_IAF191                              \ illegal access flag clear for peripheral 191


\
\ @brief IAC ILAC input status register 0
\ Address offset: 0x36C
\ Reset value: 0xFFFFFF7F
\

$00000001 constant IAC_IAC_IISR0_ILACIN0                            \ illegal access input 0
$00000002 constant IAC_IAC_IISR0_ILACIN1                            \ illegal access input 1
$00000004 constant IAC_IAC_IISR0_ILACIN2                            \ illegal access input 2
$00000008 constant IAC_IAC_IISR0_ILACIN3                            \ illegal access input 3
$00000010 constant IAC_IAC_IISR0_ILACIN4                            \ illegal access input 4
$00000020 constant IAC_IAC_IISR0_ILACIN5                            \ illegal access input 5
$00000040 constant IAC_IAC_IISR0_ILACIN6                            \ illegal access input 6
$00000080 constant IAC_IAC_IISR0_ILACIN7                            \ illegal access input 7
$00000100 constant IAC_IAC_IISR0_ILACIN8                            \ illegal access input 8
$00000200 constant IAC_IAC_IISR0_ILACIN9                            \ illegal access input 9
$00000400 constant IAC_IAC_IISR0_ILACIN10                           \ illegal access input 10
$00000800 constant IAC_IAC_IISR0_ILACIN11                           \ illegal access input 11
$00001000 constant IAC_IAC_IISR0_ILACIN12                           \ illegal access input 12
$00002000 constant IAC_IAC_IISR0_ILACIN13                           \ illegal access input 13
$00004000 constant IAC_IAC_IISR0_ILACIN14                           \ illegal access input 14
$00008000 constant IAC_IAC_IISR0_ILACIN15                           \ illegal access input 15
$00010000 constant IAC_IAC_IISR0_ILACIN16                           \ illegal access input 16
$00020000 constant IAC_IAC_IISR0_ILACIN17                           \ illegal access input 17
$00040000 constant IAC_IAC_IISR0_ILACIN18                           \ illegal access input 18
$00080000 constant IAC_IAC_IISR0_ILACIN19                           \ illegal access input 19
$00100000 constant IAC_IAC_IISR0_ILACIN20                           \ illegal access input 20
$00200000 constant IAC_IAC_IISR0_ILACIN21                           \ illegal access input 21
$00400000 constant IAC_IAC_IISR0_ILACIN22                           \ illegal access input 22
$00800000 constant IAC_IAC_IISR0_ILACIN23                           \ illegal access input 23
$01000000 constant IAC_IAC_IISR0_ILACIN24                           \ illegal access input 24
$02000000 constant IAC_IAC_IISR0_ILACIN25                           \ illegal access input 25
$04000000 constant IAC_IAC_IISR0_ILACIN26                           \ illegal access input 26
$08000000 constant IAC_IAC_IISR0_ILACIN27                           \ illegal access input 27
$10000000 constant IAC_IAC_IISR0_ILACIN28                           \ illegal access input 28
$20000000 constant IAC_IAC_IISR0_ILACIN29                           \ illegal access input 29
$40000000 constant IAC_IAC_IISR0_ILACIN30                           \ illegal access input 30
$80000000 constant IAC_IAC_IISR0_ILACIN31                           \ illegal access input 31


\
\ @brief IAC ILAC input status register 1
\ Address offset: 0x370
\ Reset value: 0x77FFFFFF
\

$00000001 constant IAC_IAC_IISR1_ILACIN32                           \ illegal access input 32
$00000002 constant IAC_IAC_IISR1_ILACIN33                           \ illegal access input 33
$00000004 constant IAC_IAC_IISR1_ILACIN34                           \ illegal access input 34
$00000008 constant IAC_IAC_IISR1_ILACIN35                           \ illegal access input 35
$00000010 constant IAC_IAC_IISR1_ILACIN36                           \ illegal access input 36
$00000020 constant IAC_IAC_IISR1_ILACIN37                           \ illegal access input 37
$00000040 constant IAC_IAC_IISR1_ILACIN38                           \ illegal access input 38
$00000080 constant IAC_IAC_IISR1_ILACIN39                           \ illegal access input 39
$00000100 constant IAC_IAC_IISR1_ILACIN40                           \ illegal access input 40
$00000200 constant IAC_IAC_IISR1_ILACIN41                           \ illegal access input 41
$00000400 constant IAC_IAC_IISR1_ILACIN42                           \ illegal access input 42
$00000800 constant IAC_IAC_IISR1_ILACIN43                           \ illegal access input 43
$00001000 constant IAC_IAC_IISR1_ILACIN44                           \ illegal access input 44
$00002000 constant IAC_IAC_IISR1_ILACIN45                           \ illegal access input 45
$00004000 constant IAC_IAC_IISR1_ILACIN46                           \ illegal access input 46
$00008000 constant IAC_IAC_IISR1_ILACIN47                           \ illegal access input 47
$00010000 constant IAC_IAC_IISR1_ILACIN48                           \ illegal access input 48
$00020000 constant IAC_IAC_IISR1_ILACIN49                           \ illegal access input 49
$00040000 constant IAC_IAC_IISR1_ILACIN50                           \ illegal access input 50
$00080000 constant IAC_IAC_IISR1_ILACIN51                           \ illegal access input 51
$00100000 constant IAC_IAC_IISR1_ILACIN52                           \ illegal access input 52
$00200000 constant IAC_IAC_IISR1_ILACIN53                           \ illegal access input 53
$00400000 constant IAC_IAC_IISR1_ILACIN54                           \ illegal access input 54
$00800000 constant IAC_IAC_IISR1_ILACIN55                           \ illegal access input 55
$01000000 constant IAC_IAC_IISR1_ILACIN56                           \ illegal access input 56
$02000000 constant IAC_IAC_IISR1_ILACIN57                           \ illegal access input 57
$04000000 constant IAC_IAC_IISR1_ILACIN58                           \ illegal access input 58
$08000000 constant IAC_IAC_IISR1_ILACIN59                           \ illegal access input 59
$10000000 constant IAC_IAC_IISR1_ILACIN60                           \ illegal access input 60
$20000000 constant IAC_IAC_IISR1_ILACIN61                           \ illegal access input 61
$40000000 constant IAC_IAC_IISR1_ILACIN62                           \ illegal access input 62
$80000000 constant IAC_IAC_IISR1_ILACIN63                           \ illegal access input 63


\
\ @brief IAC ILAC input status register 2
\ Address offset: 0x374
\ Reset value: 0x77DFF03B
\

$00000001 constant IAC_IAC_IISR2_ILACIN64                           \ illegal access input 64
$00000002 constant IAC_IAC_IISR2_ILACIN65                           \ illegal access input 65
$00000004 constant IAC_IAC_IISR2_ILACIN66                           \ illegal access input 66
$00000008 constant IAC_IAC_IISR2_ILACIN67                           \ illegal access input 67
$00000010 constant IAC_IAC_IISR2_ILACIN68                           \ illegal access input 68
$00000020 constant IAC_IAC_IISR2_ILACIN69                           \ illegal access input 69
$00000040 constant IAC_IAC_IISR2_ILACIN70                           \ illegal access input 70
$00000080 constant IAC_IAC_IISR2_ILACIN71                           \ illegal access input 71
$00000100 constant IAC_IAC_IISR2_ILACIN72                           \ illegal access input 72
$00000200 constant IAC_IAC_IISR2_ILACIN73                           \ illegal access input 73
$00000400 constant IAC_IAC_IISR2_ILACIN74                           \ illegal access input 74
$00000800 constant IAC_IAC_IISR2_ILACIN75                           \ illegal access input 75
$00001000 constant IAC_IAC_IISR2_ILACIN76                           \ illegal access input 76
$00002000 constant IAC_IAC_IISR2_ILACIN77                           \ illegal access input 77
$00004000 constant IAC_IAC_IISR2_ILACIN78                           \ illegal access input 78
$00008000 constant IAC_IAC_IISR2_ILACIN79                           \ illegal access input 79
$00010000 constant IAC_IAC_IISR2_ILACIN80                           \ illegal access input 80
$00020000 constant IAC_IAC_IISR2_ILACIN81                           \ illegal access input 81
$00040000 constant IAC_IAC_IISR2_ILACIN82                           \ illegal access input 82
$00080000 constant IAC_IAC_IISR2_ILACIN83                           \ illegal access input 83
$00100000 constant IAC_IAC_IISR2_ILACIN84                           \ illegal access input 84
$00200000 constant IAC_IAC_IISR2_ILACIN85                           \ illegal access input 85
$00400000 constant IAC_IAC_IISR2_ILACIN86                           \ illegal access input 86
$00800000 constant IAC_IAC_IISR2_ILACIN87                           \ illegal access input 87
$01000000 constant IAC_IAC_IISR2_ILACIN88                           \ illegal access input 88
$02000000 constant IAC_IAC_IISR2_ILACIN89                           \ illegal access input 89
$04000000 constant IAC_IAC_IISR2_ILACIN90                           \ illegal access input 90
$08000000 constant IAC_IAC_IISR2_ILACIN91                           \ illegal access input 91
$10000000 constant IAC_IAC_IISR2_ILACIN92                           \ illegal access input 92
$20000000 constant IAC_IAC_IISR2_ILACIN93                           \ illegal access input 93
$40000000 constant IAC_IAC_IISR2_ILACIN94                           \ illegal access input 94
$80000000 constant IAC_IAC_IISR2_ILACIN95                           \ illegal access input 95


\
\ @brief IAC ILAC input status register 3
\ Address offset: 0x378
\ Reset value: 0x000005FF
\

$00000001 constant IAC_IAC_IISR3_ILACIN96                           \ illegal access input 96
$00000002 constant IAC_IAC_IISR3_ILACIN97                           \ illegal access input 97
$00000004 constant IAC_IAC_IISR3_ILACIN98                           \ illegal access input 98
$00000008 constant IAC_IAC_IISR3_ILACIN99                           \ illegal access input 99
$00000010 constant IAC_IAC_IISR3_ILACIN100                          \ illegal access input 100
$00000020 constant IAC_IAC_IISR3_ILACIN101                          \ illegal access input 101
$00000040 constant IAC_IAC_IISR3_ILACIN102                          \ illegal access input 102
$00000080 constant IAC_IAC_IISR3_ILACIN103                          \ illegal access input 103
$00000100 constant IAC_IAC_IISR3_ILACIN104                          \ illegal access input 104
$00000200 constant IAC_IAC_IISR3_ILACIN105                          \ illegal access input 105
$00000400 constant IAC_IAC_IISR3_ILACIN106                          \ illegal access input 106
$00000800 constant IAC_IAC_IISR3_ILACIN107                          \ illegal access input 107
$00001000 constant IAC_IAC_IISR3_ILACIN108                          \ illegal access input 108
$00002000 constant IAC_IAC_IISR3_ILACIN109                          \ illegal access input 109
$00004000 constant IAC_IAC_IISR3_ILACIN110                          \ illegal access input 110
$00008000 constant IAC_IAC_IISR3_ILACIN111                          \ illegal access input 111
$00010000 constant IAC_IAC_IISR3_ILACIN112                          \ illegal access input 112
$00020000 constant IAC_IAC_IISR3_ILACIN113                          \ illegal access input 113
$00040000 constant IAC_IAC_IISR3_ILACIN114                          \ illegal access input 114
$00080000 constant IAC_IAC_IISR3_ILACIN115                          \ illegal access input 115
$00100000 constant IAC_IAC_IISR3_ILACIN116                          \ illegal access input 116
$00200000 constant IAC_IAC_IISR3_ILACIN117                          \ illegal access input 117
$00400000 constant IAC_IAC_IISR3_ILACIN118                          \ illegal access input 118
$00800000 constant IAC_IAC_IISR3_ILACIN119                          \ illegal access input 119
$01000000 constant IAC_IAC_IISR3_ILACIN120                          \ illegal access input 120
$02000000 constant IAC_IAC_IISR3_ILACIN121                          \ illegal access input 121
$04000000 constant IAC_IAC_IISR3_ILACIN122                          \ illegal access input 122
$08000000 constant IAC_IAC_IISR3_ILACIN123                          \ illegal access input 123
$10000000 constant IAC_IAC_IISR3_ILACIN124                          \ illegal access input 124
$20000000 constant IAC_IAC_IISR3_ILACIN125                          \ illegal access input 125
$40000000 constant IAC_IAC_IISR3_ILACIN126                          \ illegal access input 126
$80000000 constant IAC_IAC_IISR3_ILACIN127                          \ illegal access input 127


\
\ @brief IAC ILAC input status register 4
\ Address offset: 0x37C
\ Reset value: 0x7BEFFFEF
\

$00000001 constant IAC_IAC_IISR4_ILACIN128                          \ illegal access input 128
$00000002 constant IAC_IAC_IISR4_ILACIN129                          \ illegal access input 129
$00000004 constant IAC_IAC_IISR4_ILACIN130                          \ illegal access input 130
$00000008 constant IAC_IAC_IISR4_ILACIN131                          \ illegal access input 131
$00000010 constant IAC_IAC_IISR4_ILACIN132                          \ illegal access input 132
$00000020 constant IAC_IAC_IISR4_ILACIN133                          \ illegal access input 133
$00000040 constant IAC_IAC_IISR4_ILACIN134                          \ illegal access input 134
$00000080 constant IAC_IAC_IISR4_ILACIN135                          \ illegal access input 135
$00000100 constant IAC_IAC_IISR4_ILACIN136                          \ illegal access input 136
$00000200 constant IAC_IAC_IISR4_ILACIN137                          \ illegal access input 137
$00000400 constant IAC_IAC_IISR4_ILACIN138                          \ illegal access input 138
$00000800 constant IAC_IAC_IISR4_ILACIN139                          \ illegal access input 139
$00001000 constant IAC_IAC_IISR4_ILACIN140                          \ illegal access input 140
$00002000 constant IAC_IAC_IISR4_ILACIN141                          \ illegal access input 141
$00004000 constant IAC_IAC_IISR4_ILACIN142                          \ illegal access input 142
$00008000 constant IAC_IAC_IISR4_ILACIN143                          \ illegal access input 143
$00010000 constant IAC_IAC_IISR4_ILACIN144                          \ illegal access input 144
$00020000 constant IAC_IAC_IISR4_ILACIN145                          \ illegal access input 145
$00040000 constant IAC_IAC_IISR4_ILACIN146                          \ illegal access input 146
$00080000 constant IAC_IAC_IISR4_ILACIN147                          \ illegal access input 147
$00100000 constant IAC_IAC_IISR4_ILACIN148                          \ illegal access input 148
$00200000 constant IAC_IAC_IISR4_ILACIN149                          \ illegal access input 149
$00400000 constant IAC_IAC_IISR4_ILACIN150                          \ illegal access input 150
$00800000 constant IAC_IAC_IISR4_ILACIN151                          \ illegal access input 151
$01000000 constant IAC_IAC_IISR4_ILACIN152                          \ illegal access input 152
$02000000 constant IAC_IAC_IISR4_ILACIN153                          \ illegal access input 153
$04000000 constant IAC_IAC_IISR4_ILACIN154                          \ illegal access input 154
$08000000 constant IAC_IAC_IISR4_ILACIN155                          \ illegal access input 155
$10000000 constant IAC_IAC_IISR4_ILACIN156                          \ illegal access input 156
$20000000 constant IAC_IAC_IISR4_ILACIN157                          \ illegal access input 157
$40000000 constant IAC_IAC_IISR4_ILACIN158                          \ illegal access input 158
$80000000 constant IAC_IAC_IISR4_ILACIN159                          \ illegal access input 159


\
\ @brief IAC ILAC input status register 5
\ Address offset: 0x384
\ Reset value: 0x00000000
\

$00000001 constant IAC_IAC_IISR5_ILACIN128                          \ illegal access input 128
$00000002 constant IAC_IAC_IISR5_ILACIN129                          \ illegal access input 129
$00000004 constant IAC_IAC_IISR5_ILACIN130                          \ illegal access input 130
$00000008 constant IAC_IAC_IISR5_ILACIN131                          \ illegal access input 131
$00000010 constant IAC_IAC_IISR5_ILACIN132                          \ illegal access input 132
$00000020 constant IAC_IAC_IISR5_ILACIN133                          \ illegal access input 133
$00000040 constant IAC_IAC_IISR5_ILACIN134                          \ illegal access input 134
$00000080 constant IAC_IAC_IISR5_ILACIN135                          \ illegal access input 135
$00000100 constant IAC_IAC_IISR5_ILACIN136                          \ illegal access input 136
$00000200 constant IAC_IAC_IISR5_ILACIN137                          \ illegal access input 137
$00000400 constant IAC_IAC_IISR5_ILACIN138                          \ illegal access input 138
$00000800 constant IAC_IAC_IISR5_ILACIN139                          \ illegal access input 139
$00001000 constant IAC_IAC_IISR5_ILACIN140                          \ illegal access input 140
$00002000 constant IAC_IAC_IISR5_ILACIN141                          \ illegal access input 141
$00004000 constant IAC_IAC_IISR5_ILACIN142                          \ illegal access input 142
$00008000 constant IAC_IAC_IISR5_ILACIN143                          \ illegal access input 143
$00010000 constant IAC_IAC_IISR5_ILACIN144                          \ illegal access input 144
$00020000 constant IAC_IAC_IISR5_ILACIN145                          \ illegal access input 145
$00040000 constant IAC_IAC_IISR5_ILACIN146                          \ illegal access input 146
$00080000 constant IAC_IAC_IISR5_ILACIN147                          \ illegal access input 147
$00100000 constant IAC_IAC_IISR5_ILACIN148                          \ illegal access input 148
$00200000 constant IAC_IAC_IISR5_ILACIN149                          \ illegal access input 149
$00400000 constant IAC_IAC_IISR5_ILACIN150                          \ illegal access input 150
$00800000 constant IAC_IAC_IISR5_ILACIN151                          \ illegal access input 151
$01000000 constant IAC_IAC_IISR5_ILACIN152                          \ illegal access input 152
$02000000 constant IAC_IAC_IISR5_ILACIN153                          \ illegal access input 153
$04000000 constant IAC_IAC_IISR5_ILACIN154                          \ illegal access input 154
$08000000 constant IAC_IAC_IISR5_ILACIN155                          \ illegal access input 155
$10000000 constant IAC_IAC_IISR5_ILACIN156                          \ illegal access input 156
$20000000 constant IAC_IAC_IISR5_ILACIN157                          \ illegal access input 157
$40000000 constant IAC_IAC_IISR5_ILACIN158                          \ illegal access input 158
$80000000 constant IAC_IAC_IISR5_ILACIN159                          \ illegal access input 159


\
\ @brief Illegal access controller
\
$44025000 constant IAC_IAC_IER0   \ offset: 0x00 : IAC interrupt enable register 0
$44025004 constant IAC_IAC_IER1   \ offset: 0x04 : IAC interrupt enable register 1
$44025008 constant IAC_IAC_IER2   \ offset: 0x08 : IAC interrupt enable register 2
$4402500c constant IAC_IAC_IER3   \ offset: 0x0C : IAC interrupt enable register 3
$44025010 constant IAC_IAC_IER4   \ offset: 0x10 : IAC interrupt enable register 4
$44025014 constant IAC_IAC_IER5   \ offset: 0x14 : IAC interrupt enable register 5
$44025080 constant IAC_IAC_ISR0   \ offset: 0x80 : IAC interrupt status register 0
$44025084 constant IAC_IAC_ISR1   \ offset: 0x84 : IAC interrupt status register 1
$44025088 constant IAC_IAC_ISR2   \ offset: 0x88 : IAC interrupt status register 2
$4402508c constant IAC_IAC_ISR3   \ offset: 0x8C : IAC interrupt status register 3
$44025090 constant IAC_IAC_ISR4   \ offset: 0x90 : IAC interrupt status register 4
$44025094 constant IAC_IAC_ISR5   \ offset: 0x94 : IAC interrupt status register 5
$44025100 constant IAC_IAC_ICR0   \ offset: 0x100 : IAC interrupt clear register 0
$44025104 constant IAC_IAC_ICR1   \ offset: 0x104 : IAC interrupt clear register 1
$44025108 constant IAC_IAC_ICR2   \ offset: 0x108 : IAC interrupt clear register 2
$4402510c constant IAC_IAC_ICR3   \ offset: 0x10C : IAC interrupt clear register 3
$44025110 constant IAC_IAC_ICR4   \ offset: 0x110 : IAC interrupt clear register 4
$44025114 constant IAC_IAC_ICR5   \ offset: 0x114 : IAC interrupt clear register 5
$4402536c constant IAC_IAC_IISR0  \ offset: 0x36C : IAC ILAC input status register 0
$44025370 constant IAC_IAC_IISR1  \ offset: 0x370 : IAC ILAC input status register 1
$44025374 constant IAC_IAC_IISR2  \ offset: 0x374 : IAC ILAC input status register 2
$44025378 constant IAC_IAC_IISR3  \ offset: 0x378 : IAC ILAC input status register 3
$4402537c constant IAC_IAC_IISR4  \ offset: 0x37C : IAC ILAC input status register 4
$44025384 constant IAC_IAC_IISR5  \ offset: 0x384 : IAC ILAC input status register 5

