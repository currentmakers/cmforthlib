\
\ @file ramcfg.fs
\ @brief RAMCFG
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RAMCFG SRAM x control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_M1CR_ECCE                                 \ ECCE
$00000010 constant RAMCFG_M1CR_ALE                                  \ ALE
$00000100 constant RAMCFG_M1CR_SRAMER                               \ SRAMER
$00070000 constant RAMCFG_M1CR_WSC                                  \ WSC


\
\ @brief RAMCFG RAMx interrupt status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_M1ISR_SEDC                                \ SEDC
$00000002 constant RAMCFG_M1ISR_DED                                 \ DED
$00000100 constant RAMCFG_M1ISR_SRAMBUSY                            \ SRAMBUSY


\
\ @brief RAMCFG SRAM x erase key register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_RAM1ERKEYR_ERASEKEY                       \ ERASEKEY


\
\ @brief RAMCFG SRAM x control register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_M2CR_ECCE                                 \ ECCE
$00000010 constant RAMCFG_M2CR_ALE                                  \ ALE
$00000100 constant RAMCFG_M2CR_SRAMER                               \ SRAMER
$00070000 constant RAMCFG_M2CR_WSC                                  \ WSC


\
\ @brief RAMCFG SRAM x interrupt enable register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_M2IER_SEIE                                \ SEIE
$00000002 constant RAMCFG_M2IER_DEIE                                \ DEIE
$00000008 constant RAMCFG_M2IER_ECCNMI                              \ ECCNMI


\
\ @brief RAMCFG RAMx interrupt status register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_M2ISR_SEDC                                \ SEDC
$00000002 constant RAMCFG_M2ISR_DED                                 \ DED
$00000100 constant RAMCFG_M2ISR_SRAMBUSY                            \ SRAMBUSY


\
\ @brief RAMCFG RAM x ECC single error address register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_M2SEAR_ESEA                               \ ESEA


\
\ @brief RAMCFG RAM x ECC double error address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_M2DEAR_EDEA                               \ EDEA


\
\ @brief RAMCFG RAM x interrupt clear register x
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_M2ICR_CSEDC                               \ CSEDC
$00000002 constant RAMCFG_M2ICR_CDED                                \ CDED


\
\ @brief RAMCFG SRAM2 write protection register 1
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_M2WPR1_P0WP                               \ P0WP
$00000002 constant RAMCFG_M2WPR1_P1WP                               \ P1WP
$00000004 constant RAMCFG_M2WPR1_P2WP                               \ P2WP
$00000008 constant RAMCFG_M2WPR1_P3WP                               \ P3WP
$00000010 constant RAMCFG_M2WPR1_P4WP                               \ P4WP
$00000020 constant RAMCFG_M2WPR1_P5WP                               \ P5WP
$00000040 constant RAMCFG_M2WPR1_P6WP                               \ P6WP
$00000080 constant RAMCFG_M2WPR1_P7WP                               \ P7WP
$00000100 constant RAMCFG_M2WPR1_P8WP                               \ P8WP
$00000200 constant RAMCFG_M2WPR1_P9WP                               \ P9WP
$00000400 constant RAMCFG_M2WPR1_P10WP                              \ P10WP
$00000800 constant RAMCFG_M2WPR1_P11WP                              \ P11WP
$00001000 constant RAMCFG_M2WPR1_P12WP                              \ P12WP
$00002000 constant RAMCFG_M2WPR1_P13WP                              \ P13WP
$00004000 constant RAMCFG_M2WPR1_P14WP                              \ P14WP
$00008000 constant RAMCFG_M2WPR1_P15WP                              \ P15WP
$00010000 constant RAMCFG_M2WPR1_P16WP                              \ P16WP
$00020000 constant RAMCFG_M2WPR1_P17WP                              \ P17WP
$00040000 constant RAMCFG_M2WPR1_P18WP                              \ P18WP
$00080000 constant RAMCFG_M2WPR1_P19WP                              \ P19WP
$00100000 constant RAMCFG_M2WPR1_P20WP                              \ P20WP
$00200000 constant RAMCFG_M2WPR1_P21WP                              \ P21WP
$00400000 constant RAMCFG_M2WPR1_P22WP                              \ P22WP
$00800000 constant RAMCFG_M2WPR1_P23WP                              \ P23WP
$01000000 constant RAMCFG_M2WPR1_P24WP                              \ P24WP
$02000000 constant RAMCFG_M2WPR1_P25WP                              \ P25WP
$04000000 constant RAMCFG_M2WPR1_P26WP                              \ P26WP
$08000000 constant RAMCFG_M2WPR1_P27WP                              \ P27WP
$10000000 constant RAMCFG_M2WPR1_P28WP                              \ P28WP
$20000000 constant RAMCFG_M2WPR1_P29WP                              \ P29WP
$40000000 constant RAMCFG_M2WPR1_P30WP                              \ P30WP
$80000000 constant RAMCFG_M2WPR1_P31WP                              \ P31WP


\
\ @brief RAMCFG SRAM2 write protection register 2
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_M2WPR2_P32WP                              \ P32WP
$00000002 constant RAMCFG_M2WPR2_P33WP                              \ P33WP
$00000004 constant RAMCFG_M2WPR2_P34WP                              \ P34WP
$00000008 constant RAMCFG_M2WPR2_P35WP                              \ P35WP
$00000010 constant RAMCFG_M2WPR2_P36WP                              \ P36WP
$00000020 constant RAMCFG_M2WPR2_P37WP                              \ P37WP
$00000040 constant RAMCFG_M2WPR2_P38WP                              \ P38WP
$00000080 constant RAMCFG_M2WPR2_P39WP                              \ P39WP
$00000100 constant RAMCFG_M2WPR2_P40WP                              \ P40WP
$00000200 constant RAMCFG_M2WPR2_P41WP                              \ P41WP
$00000400 constant RAMCFG_M2WPR2_P42WP                              \ P42WP
$00000800 constant RAMCFG_M2WPR2_P43WP                              \ P43WP
$00001000 constant RAMCFG_M2WPR2_P44WP                              \ P44WP
$00002000 constant RAMCFG_M2WPR2_P45WP                              \ P45WP
$00004000 constant RAMCFG_M2WPR2_P46WP                              \ P46WP
$00008000 constant RAMCFG_M2WPR2_P47WP                              \ P47WP
$00010000 constant RAMCFG_M2WPR2_P48WP                              \ P48WP
$00020000 constant RAMCFG_M2WPR2_P49WP                              \ P49WP
$00040000 constant RAMCFG_M2WPR2_P50WP                              \ P50WP
$00080000 constant RAMCFG_M2WPR2_P51WP                              \ P51WP
$00100000 constant RAMCFG_M2WPR2_P52WP                              \ P52WP
$00200000 constant RAMCFG_M2WPR2_P53WP                              \ P53WP
$00400000 constant RAMCFG_M2WPR2_P54WP                              \ P54WP
$00800000 constant RAMCFG_M2WPR2_P55WP                              \ P55WP
$01000000 constant RAMCFG_M2WPR2_P56WP                              \ P56WP
$02000000 constant RAMCFG_M2WPR2_P57WP                              \ P57WP
$04000000 constant RAMCFG_M2WPR2_P58WP                              \ P58WP
$08000000 constant RAMCFG_M2WPR2_P59WP                              \ P59WP
$10000000 constant RAMCFG_M2WPR2_P60WP                              \ P60WP
$20000000 constant RAMCFG_M2WPR2_P61WP                              \ P61WP
$40000000 constant RAMCFG_M2WPR2_P62WP                              \ P62WP
$80000000 constant RAMCFG_M2WPR2_P63WP                              \ P63WP


\
\ @brief RAMCFG SRAM x ECC key register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_M2ECCKEYR_ECCKEY                          \ ECCKEY


\
\ @brief RAMCFG SRAM x erase key register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_M2ERKEYR_ERASEKEY                         \ ERASEKEY


\
\ @brief RAMCFG SRAM x control register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_M3CR_ECCE                                 \ ECCE
$00000010 constant RAMCFG_M3CR_ALE                                  \ ALE
$00000100 constant RAMCFG_M3CR_SRAMER                               \ SRAMER
$00070000 constant RAMCFG_M3CR_WSC                                  \ WSC


\
\ @brief RAMCFG SRAM x interrupt enable register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_M3IER_SEIE                                \ SEIE
$00000002 constant RAMCFG_M3IER_DEIE                                \ DEIE
$00000008 constant RAMCFG_M3IER_ECCNMI                              \ ECCNMI


\
\ @brief RAMCFG RAMx interrupt status register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_M3ISR_SEDC                                \ SEDC
$00000002 constant RAMCFG_M3ISR_DED                                 \ DED
$00000100 constant RAMCFG_M3ISR_SRAMBUSY                            \ SRAMBUSY


\
\ @brief RAMCFG RAM x ECC single error address register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_M3SEAR_ESEA                               \ ESEA


\
\ @brief RAMCFG RAM x ECC double error address register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_M3DEAR_EDEA                               \ EDEA


\
\ @brief RAMCFG RAM x interrupt clear register x
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_M3ICR_CSEDC                               \ CSEDC
$00000002 constant RAMCFG_M3ICR_CDED                                \ CDED


\
\ @brief RAMCFG SRAM x ECC key register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_M3ECCKEYR_ECCKEY                          \ ECCKEY


\
\ @brief RAMCFG SRAM x erase key register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_M3ERKEYR_ERASEKEY                         \ ERASEKEY


\
\ @brief RAMCFG SRAM x control register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_M4CR_ECCE                                 \ ECCE
$00000010 constant RAMCFG_M4CR_ALE                                  \ ALE
$00000100 constant RAMCFG_M4CR_SRAMER                               \ SRAMER
$00070000 constant RAMCFG_M4CR_WSC                                  \ WSC


\
\ @brief RAMCFG RAMx interrupt status register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_M4ISR_SEDC                                \ SEDC
$00000002 constant RAMCFG_M4ISR_DED                                 \ DED
$00000100 constant RAMCFG_M4ISR_SRAMBUSY                            \ SRAMBUSY


\
\ @brief RAMCFG SRAM x erase key register
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_M4ERKEYR_ERASEKEY                         \ ERASEKEY


\
\ @brief RAMCFG SRAM x control register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_M5CR_ECCE                                 \ ECCE
$00000010 constant RAMCFG_M5CR_ALE                                  \ ALE
$00000100 constant RAMCFG_M5CR_SRAMER                               \ SRAMER
$00070000 constant RAMCFG_M5CR_WSC                                  \ WSC


\
\ @brief RAMCFG SRAM x interrupt enable register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_M5IER_SEIE                                \ SEIE
$00000002 constant RAMCFG_M5IER_DEIE                                \ DEIE
$00000008 constant RAMCFG_M5IER_ECCNMI                              \ ECCNMI


\
\ @brief RAMCFG RAMx interrupt status register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_M5ISR_SEDC                                \ SEDC
$00000002 constant RAMCFG_M5ISR_DED                                 \ DED
$00000100 constant RAMCFG_M5ISR_SRAMBUSY                            \ SRAMBUSY


\
\ @brief RAMCFG RAM x ECC single error address register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_M5SEAR_ESEA                               \ ESEA


\
\ @brief RAMCFG RAM x ECC double error address register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_M5DEAR_EDEA                               \ EDEA


\
\ @brief RAMCFG RAM x interrupt clear register x
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_M5ICR_CSEDC                               \ CSEDC
$00000002 constant RAMCFG_M5ICR_CDED                                \ CDED


\
\ @brief RAMCFG RAM x interrupt clear register x
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_M5ECCKEYR_ECCKEY                          \ ECCKEY


\
\ @brief Erase write protection key The following steps are required to unlock the write protection of the SRAMER bit in the RAMCFG_MxCR register. 1) Write 0xCA into ERASEKEY[7:0]. 2) Write 0x53 into ERASEKEY[7:0]. Note: Writing a wrong key reactivates the write protection.
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_M5ERKEYR_ERASEKEY                         \ Erase write protection key The following steps are required to unlock the write protection of the SRAMER bit in the RAMCFG_MxCR register. 1) Write 0xCA into ERASEKEY[7:0]. 2) Write 0x53 into ERASEKEY[7:0]. Note: Writing a wrong key reactivates the write protection.


\
\ @brief memory x control register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_M6CR_ECCE                                 \ ECCE
$00000010 constant RAMCFG_M6CR_ALE                                  \ ALE
$00000100 constant RAMCFG_M6CR_SRAMER                               \ SRAMER
$00070000 constant RAMCFG_M6CR_WSC                                  \ WSC


\
\ @brief ECC single error detected and corrected Note: This bit is reserved and must be kept at reset value in SRAM1, SRAM4 and SRAM5 interrupt status registers.
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_M6ISR_SEDC                                \ ECC single error detected and corrected Note: This bit is reserved and must be kept at reset value in SRAM1, SRAM4 and SRAM5 interrupt status registers.
$00000002 constant RAMCFG_M6ISR_DED                                 \ ECC double error detected Note: This bit is reserved and must be kept at reset value in SRAM1, SRAM4 and SRAM5 interrupt status registers.
$00000100 constant RAMCFG_M6ISR_SRAMBUSY                            \ SRAM busy with erase operation Note: Depending on the SRAM, the erase operation can be performed due to software request, system reset if the option bit is enabled, tamper detection or readout protection regression. Refer to .


\
\ @brief Erase write protection key The following steps are required to unlock the write protection of the SRAMER bit in the RAMCFG_MxCR register. 1) Write 0xCA into ERASEKEY[7:0]. 2) Write 0x53 into ERASEKEY[7:0]. Note: Writing a wrong key reactivates the write protection.
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_M6ERKEYR_ERASEKEY                         \ Erase write protection key The following steps are required to unlock the write protection of the SRAMER bit in the RAMCFG_MxCR register. 1) Write 0xCA into ERASEKEY[7:0]. 2) Write 0x53 into ERASEKEY[7:0]. Note: Writing a wrong key reactivates the write protection.


\
\ @brief RAMCFG
\
$40026000 constant RAMCFG_M1CR    \ offset: 0x00 : RAMCFG SRAM x control register
$40026008 constant RAMCFG_M1ISR   \ offset: 0x08 : RAMCFG RAMx interrupt status register
$40026028 constant RAMCFG_RAM1ERKEYR  \ offset: 0x28 : RAMCFG SRAM x erase key register
$40026040 constant RAMCFG_M2CR    \ offset: 0x40 : RAMCFG SRAM x control register
$40026044 constant RAMCFG_M2IER   \ offset: 0x44 : RAMCFG SRAM x interrupt enable register
$40026048 constant RAMCFG_M2ISR   \ offset: 0x48 : RAMCFG RAMx interrupt status register
$4002604c constant RAMCFG_M2SEAR  \ offset: 0x4C : RAMCFG RAM x ECC single error address register
$40026050 constant RAMCFG_M2DEAR  \ offset: 0x50 : RAMCFG RAM x ECC double error address register
$40026054 constant RAMCFG_M2ICR   \ offset: 0x54 : RAMCFG RAM x interrupt clear register x
$40026058 constant RAMCFG_M2WPR1  \ offset: 0x58 : RAMCFG SRAM2 write protection register 1
$4002605c constant RAMCFG_M2WPR2  \ offset: 0x5C : RAMCFG SRAM2 write protection register 2
$40026064 constant RAMCFG_M2ECCKEYR  \ offset: 0x64 : RAMCFG SRAM x ECC key register
$40026068 constant RAMCFG_M2ERKEYR  \ offset: 0x68 : RAMCFG SRAM x erase key register
$40026080 constant RAMCFG_M3CR    \ offset: 0x80 : RAMCFG SRAM x control register
$40026084 constant RAMCFG_M3IER   \ offset: 0x84 : RAMCFG SRAM x interrupt enable register
$40026088 constant RAMCFG_M3ISR   \ offset: 0x88 : RAMCFG RAMx interrupt status register
$4002608c constant RAMCFG_M3SEAR  \ offset: 0x8C : RAMCFG RAM x ECC single error address register
$40026090 constant RAMCFG_M3DEAR  \ offset: 0x90 : RAMCFG RAM x ECC double error address register
$40026094 constant RAMCFG_M3ICR   \ offset: 0x94 : RAMCFG RAM x interrupt clear register x
$400260a4 constant RAMCFG_M3ECCKEYR  \ offset: 0xA4 : RAMCFG SRAM x ECC key register
$400260a8 constant RAMCFG_M3ERKEYR  \ offset: 0xA8 : RAMCFG SRAM x erase key register
$400260c0 constant RAMCFG_M4CR    \ offset: 0xC0 : RAMCFG SRAM x control register
$400260c8 constant RAMCFG_M4ISR   \ offset: 0xC8 : RAMCFG RAMx interrupt status register
$400260e8 constant RAMCFG_M4ERKEYR  \ offset: 0xE8 : RAMCFG SRAM x erase key register
$40026100 constant RAMCFG_M5CR    \ offset: 0x100 : RAMCFG SRAM x control register
$40026104 constant RAMCFG_M5IER   \ offset: 0x104 : RAMCFG SRAM x interrupt enable register
$40026108 constant RAMCFG_M5ISR   \ offset: 0x108 : RAMCFG RAMx interrupt status register
$4002610c constant RAMCFG_M5SEAR  \ offset: 0x10C : RAMCFG RAM x ECC single error address register
$40026110 constant RAMCFG_M5DEAR  \ offset: 0x110 : RAMCFG RAM x ECC double error address register
$40026114 constant RAMCFG_M5ICR   \ offset: 0x114 : RAMCFG RAM x interrupt clear register x
$40026124 constant RAMCFG_M5ECCKEYR  \ offset: 0x124 : RAMCFG RAM x interrupt clear register x
$40026128 constant RAMCFG_M5ERKEYR  \ offset: 0x128 : Erase write protection key The following steps are required to unlock the write protection of the SRAMER bit in the RAMCFG_MxCR register. 1) Write 0xCA into ERASEKEY[7:0]. 2) Write 0x53 into ERASEKEY[7:0]. Note: Writing a wrong key reactivates the write protection.
$40026140 constant RAMCFG_M6CR    \ offset: 0x140 : memory x control register
$40026148 constant RAMCFG_M6ISR   \ offset: 0x148 : ECC single error detected and corrected Note: This bit is reserved and must be kept at reset value in SRAM1, SRAM4 and SRAM5 interrupt status registers.
$40026168 constant RAMCFG_M6ERKEYR  \ offset: 0x168 : Erase write protection key The following steps are required to unlock the write protection of the SRAMER bit in the RAMCFG_MxCR register. 1) Write 0xCA into ERASEKEY[7:0]. 2) Write 0x53 into ERASEKEY[7:0]. Note: Writing a wrong key reactivates the write protection.

