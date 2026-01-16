\
\ @file bkp.fs
\ @brief Backup registers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR1_D1                                       \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR2_D2                                       \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR3_D3                                       \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR4_D4                                       \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR5_D5                                       \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR6_D6                                       \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR7_D7                                       \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR8_D8                                       \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR9_D9                                       \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR10_D10                                     \ Backup data


\
\ @brief RTC clock calibration register (BKP_RTCCR)
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000007f constant BKP_RTCCR_CAL                                    \ Calibration value
$00000080 constant BKP_RTCCR_CCO                                    \ Calibration Clock Output
$00000100 constant BKP_RTCCR_ASOE                                   \ Alarm or second output enable
$00000200 constant BKP_RTCCR_ASOS                                   \ Alarm or second output selection


\
\ @brief Backup control register (BKP_CR)
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant BKP_CR_TPE                                       \ Tamper pin enable
$00000002 constant BKP_CR_TPAL                                      \ Tamper pin active level


\
\ @brief BKP_CSR control/status register (BKP_CSR)
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant BKP_CSR_CTE                                      \ Clear Tamper event
$00000002 constant BKP_CSR_CTI                                      \ Clear Tamper Interrupt
$00000004 constant BKP_CSR_TPIE                                     \ Tamper Pin interrupt enable
$00000100 constant BKP_CSR_TEF                                      \ Tamper Event Flag
$00000200 constant BKP_CSR_TIF                                      \ Tamper Interrupt Flag


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR11_DR11                                    \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR12_DR12                                    \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR13_DR13                                    \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR14_D14                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR15_D15                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR16_D16                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR17_D17                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR18_D18                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR19_D19                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR20_D20                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR21_D21                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR22_D22                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR23_D23                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR24_D24                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR25_D25                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR26_D26                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR27_D27                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR28_D28                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR29_D29                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR30_D30                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR31_D31                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR32_D32                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR33_D33                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR34_D34                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR35_D35                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR36_D36                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR37_D37                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR38_D38                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR39_D39                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR40_D40                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR41_D41                                     \ Backup data


\
\ @brief Backup data register (BKP_DR)
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$0000ffff constant BKP_DR42_D42                                     \ Backup data


\
\ @brief Backup registers
\
$40006c04 constant BKP_DR1        \ offset: 0x00 : Backup data register (BKP_DR)
$40006c08 constant BKP_DR2        \ offset: 0x04 : Backup data register (BKP_DR)
$40006c0c constant BKP_DR3        \ offset: 0x08 : Backup data register (BKP_DR)
$40006c10 constant BKP_DR4        \ offset: 0x0C : Backup data register (BKP_DR)
$40006c14 constant BKP_DR5        \ offset: 0x10 : Backup data register (BKP_DR)
$40006c18 constant BKP_DR6        \ offset: 0x14 : Backup data register (BKP_DR)
$40006c1c constant BKP_DR7        \ offset: 0x18 : Backup data register (BKP_DR)
$40006c20 constant BKP_DR8        \ offset: 0x1C : Backup data register (BKP_DR)
$40006c24 constant BKP_DR9        \ offset: 0x20 : Backup data register (BKP_DR)
$40006c28 constant BKP_DR10       \ offset: 0x24 : Backup data register (BKP_DR)
$40006c2c constant BKP_RTCCR      \ offset: 0x28 : RTC clock calibration register (BKP_RTCCR)
$40006c30 constant BKP_CR         \ offset: 0x2C : Backup control register (BKP_CR)
$40006c34 constant BKP_CSR        \ offset: 0x30 : BKP_CSR control/status register (BKP_CSR)
$40006c40 constant BKP_DR11       \ offset: 0x3C : Backup data register (BKP_DR)
$40006c44 constant BKP_DR12       \ offset: 0x40 : Backup data register (BKP_DR)
$40006c48 constant BKP_DR13       \ offset: 0x44 : Backup data register (BKP_DR)
$40006c4c constant BKP_DR14       \ offset: 0x48 : Backup data register (BKP_DR)
$40006c50 constant BKP_DR15       \ offset: 0x4C : Backup data register (BKP_DR)
$40006c54 constant BKP_DR16       \ offset: 0x50 : Backup data register (BKP_DR)
$40006c58 constant BKP_DR17       \ offset: 0x54 : Backup data register (BKP_DR)
$40006c5c constant BKP_DR18       \ offset: 0x58 : Backup data register (BKP_DR)
$40006c60 constant BKP_DR19       \ offset: 0x5C : Backup data register (BKP_DR)
$40006c64 constant BKP_DR20       \ offset: 0x60 : Backup data register (BKP_DR)
$40006c68 constant BKP_DR21       \ offset: 0x64 : Backup data register (BKP_DR)
$40006c6c constant BKP_DR22       \ offset: 0x68 : Backup data register (BKP_DR)
$40006c70 constant BKP_DR23       \ offset: 0x6C : Backup data register (BKP_DR)
$40006c74 constant BKP_DR24       \ offset: 0x70 : Backup data register (BKP_DR)
$40006c78 constant BKP_DR25       \ offset: 0x74 : Backup data register (BKP_DR)
$40006c7c constant BKP_DR26       \ offset: 0x78 : Backup data register (BKP_DR)
$40006c80 constant BKP_DR27       \ offset: 0x7C : Backup data register (BKP_DR)
$40006c84 constant BKP_DR28       \ offset: 0x80 : Backup data register (BKP_DR)
$40006c88 constant BKP_DR29       \ offset: 0x84 : Backup data register (BKP_DR)
$40006c8c constant BKP_DR30       \ offset: 0x88 : Backup data register (BKP_DR)
$40006c90 constant BKP_DR31       \ offset: 0x8C : Backup data register (BKP_DR)
$40006c94 constant BKP_DR32       \ offset: 0x90 : Backup data register (BKP_DR)
$40006c98 constant BKP_DR33       \ offset: 0x94 : Backup data register (BKP_DR)
$40006c9c constant BKP_DR34       \ offset: 0x98 : Backup data register (BKP_DR)
$40006ca0 constant BKP_DR35       \ offset: 0x9C : Backup data register (BKP_DR)
$40006ca4 constant BKP_DR36       \ offset: 0xA0 : Backup data register (BKP_DR)
$40006ca8 constant BKP_DR37       \ offset: 0xA4 : Backup data register (BKP_DR)
$40006cac constant BKP_DR38       \ offset: 0xA8 : Backup data register (BKP_DR)
$40006cb0 constant BKP_DR39       \ offset: 0xAC : Backup data register (BKP_DR)
$40006cb4 constant BKP_DR40       \ offset: 0xB0 : Backup data register (BKP_DR)
$40006cb8 constant BKP_DR41       \ offset: 0xB4 : Backup data register (BKP_DR)
$40006cbc constant BKP_DR42       \ offset: 0xB8 : Backup data register (BKP_DR)

