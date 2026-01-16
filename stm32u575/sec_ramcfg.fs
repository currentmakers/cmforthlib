\
\ @file sec_ramcfg.fs
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

$00000001 constant SEC_RAMCFG_RAM1CR_ECCE                           \ ECCE
$00000010 constant SEC_RAMCFG_RAM1CR_ALE                            \ ALE
$00000100 constant SEC_RAMCFG_RAM1CR_SRAMER                         \ SRAMER
$00070000 constant SEC_RAMCFG_RAM1CR_WSC                            \ WSC


\
\ @brief RAMCFG RAMx interrupt status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SEC_RAMCFG_RAM1ISR_SEDC                          \ SEDC
$00000002 constant SEC_RAMCFG_RAM1ISR_DED                           \ DED
$00000100 constant SEC_RAMCFG_RAM1ISR_SRAMBUSY                      \ SRAMBUSY


\
\ @brief RAMCFG SRAM x erase key register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant SEC_RAMCFG_RAM1ERKEYR_ERASEKEY                   \ ERASEKEY


\
\ @brief RAMCFG SRAM x control register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant SEC_RAMCFG_RAM2CR_ECCE                           \ ECCE
$00000010 constant SEC_RAMCFG_RAM2CR_ALE                            \ ALE
$00000100 constant SEC_RAMCFG_RAM2CR_SRAMER                         \ SRAMER
$00070000 constant SEC_RAMCFG_RAM2CR_WSC                            \ WSC


\
\ @brief RAMCFG SRAM x interrupt enable register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant SEC_RAMCFG_RAM2IER_SEIE                          \ SEIE
$00000002 constant SEC_RAMCFG_RAM2IER_DEIE                          \ DEIE
$00000008 constant SEC_RAMCFG_RAM2IER_ECCNMI                        \ ECCNMI


\
\ @brief RAMCFG RAMx interrupt status register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant SEC_RAMCFG_RAM2ISR_SEDC                          \ SEDC
$00000002 constant SEC_RAMCFG_RAM2ISR_DED                           \ DED
$00000100 constant SEC_RAMCFG_RAM2ISR_SRAMBUSY                      \ SRAMBUSY


\
\ @brief RAMCFG RAM x ECC single error address register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant SEC_RAMCFG_RAM2SEAR_ESEA                         \ ESEA


\
\ @brief RAMCFG RAM x ECC double error address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant SEC_RAMCFG_RAM2DEAR_EDEA                         \ EDEA


\
\ @brief RAMCFG RAM x interrupt clear register x
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant SEC_RAMCFG_RAM2ICR_CSEDC                         \ CSEDC
$00000002 constant SEC_RAMCFG_RAM2ICR_CDED                          \ CDED


\
\ @brief RAMCFG SRAM2 write protection register 1
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant SEC_RAMCFG_RAM2WPR1_P0WP                         \ P0WP
$00000002 constant SEC_RAMCFG_RAM2WPR1_P1WP                         \ P1WP
$00000004 constant SEC_RAMCFG_RAM2WPR1_P2WP                         \ P2WP
$00000008 constant SEC_RAMCFG_RAM2WPR1_P3WP                         \ P3WP
$00000010 constant SEC_RAMCFG_RAM2WPR1_P4WP                         \ P4WP
$00000020 constant SEC_RAMCFG_RAM2WPR1_P5WP                         \ P5WP
$00000040 constant SEC_RAMCFG_RAM2WPR1_P6WP                         \ P6WP
$00000080 constant SEC_RAMCFG_RAM2WPR1_P7WP                         \ P7WP
$00000100 constant SEC_RAMCFG_RAM2WPR1_P8WP                         \ P8WP
$00000200 constant SEC_RAMCFG_RAM2WPR1_P9WP                         \ P9WP
$00000400 constant SEC_RAMCFG_RAM2WPR1_P10WP                        \ P10WP
$00000800 constant SEC_RAMCFG_RAM2WPR1_P11WP                        \ P11WP
$00001000 constant SEC_RAMCFG_RAM2WPR1_P12WP                        \ P12WP
$00002000 constant SEC_RAMCFG_RAM2WPR1_P13WP                        \ P13WP
$00004000 constant SEC_RAMCFG_RAM2WPR1_P14WP                        \ P14WP
$00008000 constant SEC_RAMCFG_RAM2WPR1_P15WP                        \ P15WP
$00010000 constant SEC_RAMCFG_RAM2WPR1_P16WP                        \ P16WP
$00020000 constant SEC_RAMCFG_RAM2WPR1_P17WP                        \ P17WP
$00040000 constant SEC_RAMCFG_RAM2WPR1_P18WP                        \ P18WP
$00080000 constant SEC_RAMCFG_RAM2WPR1_P19WP                        \ P19WP
$00100000 constant SEC_RAMCFG_RAM2WPR1_P20WP                        \ P20WP
$00200000 constant SEC_RAMCFG_RAM2WPR1_P21WP                        \ P21WP
$00400000 constant SEC_RAMCFG_RAM2WPR1_P22WP                        \ P22WP
$00800000 constant SEC_RAMCFG_RAM2WPR1_P23WP                        \ P23WP
$01000000 constant SEC_RAMCFG_RAM2WPR1_P24WP                        \ P24WP
$02000000 constant SEC_RAMCFG_RAM2WPR1_P25WP                        \ P25WP
$04000000 constant SEC_RAMCFG_RAM2WPR1_P26WP                        \ P26WP
$08000000 constant SEC_RAMCFG_RAM2WPR1_P27WP                        \ P27WP
$10000000 constant SEC_RAMCFG_RAM2WPR1_P28WP                        \ P28WP
$20000000 constant SEC_RAMCFG_RAM2WPR1_P29WP                        \ P29WP
$40000000 constant SEC_RAMCFG_RAM2WPR1_P30WP                        \ P30WP
$80000000 constant SEC_RAMCFG_RAM2WPR1_P31WP                        \ P31WP


\
\ @brief RAMCFG SRAM2 write protection register 2
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant SEC_RAMCFG_RAM2WPR2_P32WP                        \ P32WP
$00000002 constant SEC_RAMCFG_RAM2WPR2_P33WP                        \ P33WP
$00000004 constant SEC_RAMCFG_RAM2WPR2_P34WP                        \ P34WP
$00000008 constant SEC_RAMCFG_RAM2WPR2_P35WP                        \ P35WP
$00000010 constant SEC_RAMCFG_RAM2WPR2_P36WP                        \ P36WP
$00000020 constant SEC_RAMCFG_RAM2WPR2_P37WP                        \ P37WP
$00000040 constant SEC_RAMCFG_RAM2WPR2_P38WP                        \ P38WP
$00000080 constant SEC_RAMCFG_RAM2WPR2_P39WP                        \ P39WP
$00000100 constant SEC_RAMCFG_RAM2WPR2_P40WP                        \ P40WP
$00000200 constant SEC_RAMCFG_RAM2WPR2_P41WP                        \ P41WP
$00000400 constant SEC_RAMCFG_RAM2WPR2_P42WP                        \ P42WP
$00000800 constant SEC_RAMCFG_RAM2WPR2_P43WP                        \ P43WP
$00001000 constant SEC_RAMCFG_RAM2WPR2_P44WP                        \ P44WP
$00002000 constant SEC_RAMCFG_RAM2WPR2_P45WP                        \ P45WP
$00004000 constant SEC_RAMCFG_RAM2WPR2_P46WP                        \ P46WP
$00008000 constant SEC_RAMCFG_RAM2WPR2_P47WP                        \ P47WP
$00010000 constant SEC_RAMCFG_RAM2WPR2_P48WP                        \ P48WP
$00020000 constant SEC_RAMCFG_RAM2WPR2_P49WP                        \ P49WP
$00040000 constant SEC_RAMCFG_RAM2WPR2_P50WP                        \ P50WP
$00080000 constant SEC_RAMCFG_RAM2WPR2_P51WP                        \ P51WP
$00100000 constant SEC_RAMCFG_RAM2WPR2_P52WP                        \ P52WP
$00200000 constant SEC_RAMCFG_RAM2WPR2_P53WP                        \ P53WP
$00400000 constant SEC_RAMCFG_RAM2WPR2_P54WP                        \ P54WP
$00800000 constant SEC_RAMCFG_RAM2WPR2_P55WP                        \ P55WP
$01000000 constant SEC_RAMCFG_RAM2WPR2_P56WP                        \ P56WP
$02000000 constant SEC_RAMCFG_RAM2WPR2_P57WP                        \ P57WP
$04000000 constant SEC_RAMCFG_RAM2WPR2_P58WP                        \ P58WP
$08000000 constant SEC_RAMCFG_RAM2WPR2_P59WP                        \ P59WP
$10000000 constant SEC_RAMCFG_RAM2WPR2_P60WP                        \ P60WP
$20000000 constant SEC_RAMCFG_RAM2WPR2_P61WP                        \ P61WP
$40000000 constant SEC_RAMCFG_RAM2WPR2_P62WP                        \ P62WP
$80000000 constant SEC_RAMCFG_RAM2WPR2_P63WP                        \ P63WP


\
\ @brief RAMCFG SRAM x ECC key register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$000000ff constant SEC_RAMCFG_RAM2ECCKEYR_ECCKEY                    \ ECCKEY


\
\ @brief RAMCFG SRAM x erase key register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$000000ff constant SEC_RAMCFG_RAM2ERKEYR_ERASEKEY                   \ ERASEKEY


\
\ @brief RAMCFG SRAM x control register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant SEC_RAMCFG_RAM3CR_ECCE                           \ ECCE
$00000010 constant SEC_RAMCFG_RAM3CR_ALE                            \ ALE
$00000100 constant SEC_RAMCFG_RAM3CR_SRAMER                         \ SRAMER
$00070000 constant SEC_RAMCFG_RAM3CR_WSC                            \ WSC


\
\ @brief RAMCFG SRAM x interrupt enable register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant SEC_RAMCFG_RAM3IER_SEIE                          \ SEIE
$00000002 constant SEC_RAMCFG_RAM3IER_DEIE                          \ DEIE
$00000008 constant SEC_RAMCFG_RAM3IER_ECCNMI                        \ ECCNMI


\
\ @brief RAMCFG RAMx interrupt status register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant SEC_RAMCFG_RAM3ISR_SEDC                          \ SEDC
$00000002 constant SEC_RAMCFG_RAM3ISR_DED                           \ DED
$00000100 constant SEC_RAMCFG_RAM3ISR_SRAMBUSY                      \ SRAMBUSY


\
\ @brief RAMCFG RAM x ECC single error address register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant SEC_RAMCFG_RAM3SEAR_ESEA                         \ ESEA


\
\ @brief RAMCFG RAM x ECC double error address register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant SEC_RAMCFG_RAM3DEAR_EDEA                         \ EDEA


\
\ @brief RAMCFG RAM x interrupt clear register x
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant SEC_RAMCFG_RAM3ICR_CSEDC                         \ CSEDC
$00000002 constant SEC_RAMCFG_RAM3ICR_CDED                          \ CDED


\
\ @brief RAMCFG SRAM x ECC key register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$000000ff constant SEC_RAMCFG_RAM3ECCKEYR_ECCKEY                    \ ECCKEY


\
\ @brief RAMCFG SRAM x erase key register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$000000ff constant SEC_RAMCFG_RAM3ERKEYR_ERASEKEY                   \ ERASEKEY


\
\ @brief RAMCFG SRAM x control register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant SEC_RAMCFG_RAM4CR_ECCE                           \ ECCE
$00000010 constant SEC_RAMCFG_RAM4CR_ALE                            \ ALE
$00000100 constant SEC_RAMCFG_RAM4CR_SRAMER                         \ SRAMER
$00070000 constant SEC_RAMCFG_RAM4CR_WSC                            \ WSC


\
\ @brief RAMCFG RAMx interrupt status register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000001 constant SEC_RAMCFG_RAM4ISR_SEDC                          \ SEDC
$00000002 constant SEC_RAMCFG_RAM4ISR_DED                           \ DED
$00000100 constant SEC_RAMCFG_RAM4ISR_SRAMBUSY                      \ SRAMBUSY


\
\ @brief RAMCFG SRAM x erase key register
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$000000ff constant SEC_RAMCFG_RAM4ERKEYR_ERASEKEY                   \ ERASEKEY


\
\ @brief RAMCFG SRAM x control register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant SEC_RAMCFG_RAM5CR_ECCE                           \ ECCE
$00000010 constant SEC_RAMCFG_RAM5CR_ALE                            \ ALE
$00000100 constant SEC_RAMCFG_RAM5CR_SRAMER                         \ SRAMER
$00070000 constant SEC_RAMCFG_RAM5CR_WSC                            \ WSC


\
\ @brief RAMCFG SRAM x interrupt enable register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant SEC_RAMCFG_RAM5IER_SEIE                          \ SEIE
$00000002 constant SEC_RAMCFG_RAM5IER_DEIE                          \ DEIE
$00000008 constant SEC_RAMCFG_RAM5IER_ECCNMI                        \ ECCNMI


\
\ @brief RAMCFG RAMx interrupt status register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant SEC_RAMCFG_RAM5ISR_SEDC                          \ SEDC
$00000002 constant SEC_RAMCFG_RAM5ISR_DED                           \ DED
$00000100 constant SEC_RAMCFG_RAM5ISR_SRAMBUSY                      \ SRAMBUSY


\
\ @brief RAMCFG RAM x ECC single error address register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000000 constant SEC_RAMCFG_RAM5SEAR_ESEA                         \ ESEA


\
\ @brief RAMCFG RAM x ECC double error address register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant SEC_RAMCFG_RAM5DEAR_EDEA                         \ EDEA


\
\ @brief RAMCFG RAM x interrupt clear register x
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000001 constant SEC_RAMCFG_RAM5ICR_CSEDC                         \ CSEDC
$00000002 constant SEC_RAMCFG_RAM5ICR_CDED                          \ CDED


\
\ @brief RAMCFG
\
$50026000 constant SEC_RAMCFG_RAM1CR  \ offset: 0x00 : RAMCFG SRAM x control register
$50026008 constant SEC_RAMCFG_RAM1ISR  \ offset: 0x08 : RAMCFG RAMx interrupt status register
$50026028 constant SEC_RAMCFG_RAM1ERKEYR  \ offset: 0x28 : RAMCFG SRAM x erase key register
$50026040 constant SEC_RAMCFG_RAM2CR  \ offset: 0x40 : RAMCFG SRAM x control register
$50026044 constant SEC_RAMCFG_RAM2IER  \ offset: 0x44 : RAMCFG SRAM x interrupt enable register
$50026048 constant SEC_RAMCFG_RAM2ISR  \ offset: 0x48 : RAMCFG RAMx interrupt status register
$5002604c constant SEC_RAMCFG_RAM2SEAR  \ offset: 0x4C : RAMCFG RAM x ECC single error address register
$50026050 constant SEC_RAMCFG_RAM2DEAR  \ offset: 0x50 : RAMCFG RAM x ECC double error address register
$50026054 constant SEC_RAMCFG_RAM2ICR  \ offset: 0x54 : RAMCFG RAM x interrupt clear register x
$50026058 constant SEC_RAMCFG_RAM2WPR1  \ offset: 0x58 : RAMCFG SRAM2 write protection register 1
$5002605c constant SEC_RAMCFG_RAM2WPR2  \ offset: 0x5C : RAMCFG SRAM2 write protection register 2
$50026064 constant SEC_RAMCFG_RAM2ECCKEYR  \ offset: 0x64 : RAMCFG SRAM x ECC key register
$50026068 constant SEC_RAMCFG_RAM2ERKEYR  \ offset: 0x68 : RAMCFG SRAM x erase key register
$50026080 constant SEC_RAMCFG_RAM3CR  \ offset: 0x80 : RAMCFG SRAM x control register
$50026084 constant SEC_RAMCFG_RAM3IER  \ offset: 0x84 : RAMCFG SRAM x interrupt enable register
$50026088 constant SEC_RAMCFG_RAM3ISR  \ offset: 0x88 : RAMCFG RAMx interrupt status register
$5002608c constant SEC_RAMCFG_RAM3SEAR  \ offset: 0x8C : RAMCFG RAM x ECC single error address register
$50026090 constant SEC_RAMCFG_RAM3DEAR  \ offset: 0x90 : RAMCFG RAM x ECC double error address register
$50026094 constant SEC_RAMCFG_RAM3ICR  \ offset: 0x94 : RAMCFG RAM x interrupt clear register x
$500260a4 constant SEC_RAMCFG_RAM3ECCKEYR  \ offset: 0xA4 : RAMCFG SRAM x ECC key register
$500260a8 constant SEC_RAMCFG_RAM3ERKEYR  \ offset: 0xA8 : RAMCFG SRAM x erase key register
$500260c0 constant SEC_RAMCFG_RAM4CR  \ offset: 0xC0 : RAMCFG SRAM x control register
$500260c8 constant SEC_RAMCFG_RAM4ISR  \ offset: 0xC8 : RAMCFG RAMx interrupt status register
$500260e8 constant SEC_RAMCFG_RAM4ERKEYR  \ offset: 0xE8 : RAMCFG SRAM x erase key register
$50026100 constant SEC_RAMCFG_RAM5CR  \ offset: 0x100 : RAMCFG SRAM x control register
$50026104 constant SEC_RAMCFG_RAM5IER  \ offset: 0x104 : RAMCFG SRAM x interrupt enable register
$50026108 constant SEC_RAMCFG_RAM5ISR  \ offset: 0x108 : RAMCFG RAMx interrupt status register
$5002610c constant SEC_RAMCFG_RAM5SEAR  \ offset: 0x10C : RAMCFG RAM x ECC single error address register
$50026110 constant SEC_RAMCFG_RAM5DEAR  \ offset: 0x110 : RAMCFG RAM x ECC double error address register
$50026114 constant SEC_RAMCFG_RAM5ICR  \ offset: 0x114 : RAMCFG RAM x interrupt clear register x

