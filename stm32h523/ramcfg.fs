\
\ @file ramcfg.fs
\ @brief RAMCFG address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RAMCFG memory 1 control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMCFG_M1CR_ECCE                          \ ECC enable.
$00000010 constant RAMCFG_RAMCFG_M1CR_ALE                           \ Address latch enable
$00000100 constant RAMCFG_RAMCFG_M1CR_SRAMER                        \ SRAM erase


\
\ @brief RAMCFG memory interrupt status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMCFG_M1ISR_SEDC                         \ ECC single error detected and corrected
$00000002 constant RAMCFG_RAMCFG_M1ISR_DED                          \ ECC double error detected
$00000100 constant RAMCFG_RAMCFG_M1ISR_SRAMBUSY                     \ SRAM busy with erase operation


\
\ @brief RAMCFG memory 1 erase key register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_RAMCFG_M1ERKEYR_ERASEKEY                  \ Erase write protection key


\
\ @brief RAMCFG memory 2 control register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMCFG_M2CR_ECCE                          \ ECC enable.
$00000010 constant RAMCFG_RAMCFG_M2CR_ALE                           \ Address latch enable
$00000100 constant RAMCFG_RAMCFG_M2CR_SRAMER                        \ SRAM erase


\
\ @brief RAMCFG memory 2 interrupt enable register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMCFG_M2IER_SEIE                         \ ECC single error interrupt enable
$00000002 constant RAMCFG_RAMCFG_M2IER_DEIE                         \ ECC double error interrupt enable
$00000008 constant RAMCFG_RAMCFG_M2IER_ECCNMI                       \ Double error NMI


\
\ @brief RAMCFG memory interrupt status register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMCFG_M2ISR_SEDC                         \ ECC single error detected and corrected
$00000002 constant RAMCFG_RAMCFG_M2ISR_DED                          \ ECC double error detected
$00000100 constant RAMCFG_RAMCFG_M2ISR_SRAMBUSY                     \ SRAM busy with erase operation


\
\ @brief RAMCFG memory 2 ECC single error address register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMCFG_M2SEAR_ESEA                        \ ECC single error address


\
\ @brief RAMCFG memory 2 ECC double error address register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMCFG_M2DEAR_EDEA                        \ ECC double error address


\
\ @brief RAMCFG memory 2 interrupt clear register 2
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMCFG_M2ICR_CSEDC                        \ Clear ECC single error detected and corrected
$00000002 constant RAMCFG_RAMCFG_M2ICR_CDED                         \ Clear ECC double error detected


\
\ @brief RAMCFG memory 2 write protection register 1
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMCFG_M2WPR1_P0WP                        \ SRAM2 1-Kbyte page y write protection
$00000002 constant RAMCFG_RAMCFG_M2WPR1_P1WP                        \ SRAM2 1-Kbyte page y write protection
$00000004 constant RAMCFG_RAMCFG_M2WPR1_P2WP                        \ SRAM2 1-Kbyte page y write protection
$00000008 constant RAMCFG_RAMCFG_M2WPR1_P3WP                        \ SRAM2 1-Kbyte page y write protection
$00000010 constant RAMCFG_RAMCFG_M2WPR1_P4WP                        \ SRAM2 1-Kbyte page y write protection
$00000020 constant RAMCFG_RAMCFG_M2WPR1_P5WP                        \ SRAM2 1-Kbyte page y write protection
$00000040 constant RAMCFG_RAMCFG_M2WPR1_P6WP                        \ SRAM2 1-Kbyte page y write protection
$00000080 constant RAMCFG_RAMCFG_M2WPR1_P7WP                        \ SRAM2 1-Kbyte page y write protection
$00000100 constant RAMCFG_RAMCFG_M2WPR1_P8WP                        \ SRAM2 1-Kbyte page y write protection
$00000200 constant RAMCFG_RAMCFG_M2WPR1_P9WP                        \ SRAM2 1-Kbyte page y write protection
$00000400 constant RAMCFG_RAMCFG_M2WPR1_P10WP                       \ SRAM2 1-Kbyte page y write protection
$00000800 constant RAMCFG_RAMCFG_M2WPR1_P11WP                       \ SRAM2 1-Kbyte page y write protection
$00001000 constant RAMCFG_RAMCFG_M2WPR1_P12WP                       \ SRAM2 1-Kbyte page y write protection
$00002000 constant RAMCFG_RAMCFG_M2WPR1_P13WP                       \ SRAM2 1-Kbyte page y write protection
$00004000 constant RAMCFG_RAMCFG_M2WPR1_P14WP                       \ SRAM2 1-Kbyte page y write protection
$00008000 constant RAMCFG_RAMCFG_M2WPR1_P15WP                       \ SRAM2 1-Kbyte page y write protection
$00010000 constant RAMCFG_RAMCFG_M2WPR1_P16WP                       \ SRAM2 1-Kbyte page y write protection
$00020000 constant RAMCFG_RAMCFG_M2WPR1_P17WP                       \ SRAM2 1-Kbyte page y write protection
$00040000 constant RAMCFG_RAMCFG_M2WPR1_P18WP                       \ SRAM2 1-Kbyte page y write protection
$00080000 constant RAMCFG_RAMCFG_M2WPR1_P19WP                       \ SRAM2 1-Kbyte page y write protection
$00100000 constant RAMCFG_RAMCFG_M2WPR1_P20WP                       \ SRAM2 1-Kbyte page y write protection
$00200000 constant RAMCFG_RAMCFG_M2WPR1_P21WP                       \ SRAM2 1-Kbyte page y write protection
$00400000 constant RAMCFG_RAMCFG_M2WPR1_P22WP                       \ SRAM2 1-Kbyte page y write protection
$00800000 constant RAMCFG_RAMCFG_M2WPR1_P23WP                       \ SRAM2 1-Kbyte page y write protection
$01000000 constant RAMCFG_RAMCFG_M2WPR1_P24WP                       \ SRAM2 1-Kbyte page y write protection
$02000000 constant RAMCFG_RAMCFG_M2WPR1_P25WP                       \ SRAM2 1-Kbyte page y write protection
$04000000 constant RAMCFG_RAMCFG_M2WPR1_P26WP                       \ SRAM2 1-Kbyte page y write protection
$08000000 constant RAMCFG_RAMCFG_M2WPR1_P27WP                       \ SRAM2 1-Kbyte page y write protection
$10000000 constant RAMCFG_RAMCFG_M2WPR1_P28WP                       \ SRAM2 1-Kbyte page y write protection
$20000000 constant RAMCFG_RAMCFG_M2WPR1_P29WP                       \ SRAM2 1-Kbyte page y write protection
$40000000 constant RAMCFG_RAMCFG_M2WPR1_P30WP                       \ SRAM2 1-Kbyte page y write protection
$80000000 constant RAMCFG_RAMCFG_M2WPR1_P31WP                       \ SRAM2 1-Kbyte page y write protection


\
\ @brief RAMCFG memory 2 write protection register 2
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMCFG_M2WPR2_P32WP                       \ SRAM2 1-Kbyte page y write protection
$00000002 constant RAMCFG_RAMCFG_M2WPR2_P33WP                       \ SRAM2 1-Kbyte page y write protection
$00000004 constant RAMCFG_RAMCFG_M2WPR2_P34WP                       \ SRAM2 1-Kbyte page y write protection
$00000008 constant RAMCFG_RAMCFG_M2WPR2_P35WP                       \ SRAM2 1-Kbyte page y write protection
$00000010 constant RAMCFG_RAMCFG_M2WPR2_P36WP                       \ SRAM2 1-Kbyte page y write protection
$00000020 constant RAMCFG_RAMCFG_M2WPR2_P37WP                       \ SRAM2 1-Kbyte page y write protection
$00000040 constant RAMCFG_RAMCFG_M2WPR2_P38WP                       \ SRAM2 1-Kbyte page y write protection
$00000080 constant RAMCFG_RAMCFG_M2WPR2_P39WP                       \ SRAM2 1-Kbyte page y write protection
$00000100 constant RAMCFG_RAMCFG_M2WPR2_P40WP                       \ SRAM2 1-Kbyte page y write protection
$00000200 constant RAMCFG_RAMCFG_M2WPR2_P41WP                       \ SRAM2 1-Kbyte page y write protection
$00000400 constant RAMCFG_RAMCFG_M2WPR2_P42WP                       \ SRAM2 1-Kbyte page y write protection
$00000800 constant RAMCFG_RAMCFG_M2WPR2_P43WP                       \ SRAM2 1-Kbyte page y write protection
$00001000 constant RAMCFG_RAMCFG_M2WPR2_P44WP                       \ SRAM2 1-Kbyte page y write protection
$00002000 constant RAMCFG_RAMCFG_M2WPR2_P45WP                       \ SRAM2 1-Kbyte page y write protection
$00004000 constant RAMCFG_RAMCFG_M2WPR2_P46WP                       \ SRAM2 1-Kbyte page y write protection
$00008000 constant RAMCFG_RAMCFG_M2WPR2_P47WP                       \ SRAM2 1-Kbyte page y write protection
$00010000 constant RAMCFG_RAMCFG_M2WPR2_P48WP                       \ SRAM2 1-Kbyte page y write protection
$00020000 constant RAMCFG_RAMCFG_M2WPR2_P49WP                       \ SRAM2 1-Kbyte page y write protection
$00040000 constant RAMCFG_RAMCFG_M2WPR2_P50WP                       \ SRAM2 1-Kbyte page y write protection
$00080000 constant RAMCFG_RAMCFG_M2WPR2_P51WP                       \ SRAM2 1-Kbyte page y write protection
$00100000 constant RAMCFG_RAMCFG_M2WPR2_P52WP                       \ SRAM2 1-Kbyte page y write protection
$00200000 constant RAMCFG_RAMCFG_M2WPR2_P53WP                       \ SRAM2 1-Kbyte page y write protection
$00400000 constant RAMCFG_RAMCFG_M2WPR2_P54WP                       \ SRAM2 1-Kbyte page y write protection
$00800000 constant RAMCFG_RAMCFG_M2WPR2_P55WP                       \ SRAM2 1-Kbyte page y write protection
$01000000 constant RAMCFG_RAMCFG_M2WPR2_P56WP                       \ SRAM2 1-Kbyte page y write protection
$02000000 constant RAMCFG_RAMCFG_M2WPR2_P57WP                       \ SRAM2 1-Kbyte page y write protection
$04000000 constant RAMCFG_RAMCFG_M2WPR2_P58WP                       \ SRAM2 1-Kbyte page y write protection
$08000000 constant RAMCFG_RAMCFG_M2WPR2_P59WP                       \ SRAM2 1-Kbyte page y write protection
$10000000 constant RAMCFG_RAMCFG_M2WPR2_P60WP                       \ SRAM2 1-Kbyte page y write protection
$20000000 constant RAMCFG_RAMCFG_M2WPR2_P61WP                       \ SRAM2 1-Kbyte page y write protection
$40000000 constant RAMCFG_RAMCFG_M2WPR2_P62WP                       \ SRAM2 1-Kbyte page y write protection
$80000000 constant RAMCFG_RAMCFG_M2WPR2_P63WP                       \ SRAM2 1-Kbyte page y write protection


\
\ @brief RAMCFG memory 2 write protection register 3
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMCFG_M2WPR3_P64WP                       \ SRAM2 1-Kbyte page y write protection
$00000002 constant RAMCFG_RAMCFG_M2WPR3_P65WP                       \ SRAM2 1-Kbyte page y write protection
$00000004 constant RAMCFG_RAMCFG_M2WPR3_P66WP                       \ SRAM2 1-Kbyte page y write protection
$00000008 constant RAMCFG_RAMCFG_M2WPR3_P67WP                       \ SRAM2 1-Kbyte page y write protection
$00000010 constant RAMCFG_RAMCFG_M2WPR3_P68WP                       \ SRAM2 1-Kbyte page y write protection
$00000020 constant RAMCFG_RAMCFG_M2WPR3_P69WP                       \ SRAM2 1-Kbyte page y write protection
$00000040 constant RAMCFG_RAMCFG_M2WPR3_P70WP                       \ SRAM2 1-Kbyte page y write protection
$00000080 constant RAMCFG_RAMCFG_M2WPR3_P71WP                       \ SRAM2 1-Kbyte page y write protection
$00000100 constant RAMCFG_RAMCFG_M2WPR3_P72WP                       \ SRAM2 1-Kbyte page y write protection
$00000200 constant RAMCFG_RAMCFG_M2WPR3_P73WP                       \ SRAM2 1-Kbyte page y write protection
$00000400 constant RAMCFG_RAMCFG_M2WPR3_P74WP                       \ SRAM2 1-Kbyte page y write protection
$00000800 constant RAMCFG_RAMCFG_M2WPR3_P75WP                       \ SRAM2 1-Kbyte page y write protection
$00001000 constant RAMCFG_RAMCFG_M2WPR3_P76WP                       \ SRAM2 1-Kbyte page y write protection
$00002000 constant RAMCFG_RAMCFG_M2WPR3_P77WP                       \ SRAM2 1-Kbyte page y write protection
$00004000 constant RAMCFG_RAMCFG_M2WPR3_P78WP                       \ SRAM2 1-Kbyte page y write protection
$00008000 constant RAMCFG_RAMCFG_M2WPR3_P79WP                       \ SRAM2 1-Kbyte page y write protection


\
\ @brief RAMCFG memory 2 ECC key register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_RAMCFG_M2ECCKEYR_ECCKEY                   \ ECC write protection key


\
\ @brief RAMCFG memory 2 erase key register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_RAMCFG_M2ERKEYR_ERASEKEY                  \ Erase write protection key


\
\ @brief RAMCFG memory 3 control register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMCFG_M3CR_ECCE                          \ ECC enable.
$00000010 constant RAMCFG_RAMCFG_M3CR_ALE                           \ Address latch enable
$00000100 constant RAMCFG_RAMCFG_M3CR_SRAMER                        \ SRAM erase


\
\ @brief RAMCFG memory 3 interrupt enable register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMCFG_M3IER_SEIE                         \ ECC single error interrupt enable
$00000002 constant RAMCFG_RAMCFG_M3IER_DEIE                         \ ECC double error interrupt enable
$00000008 constant RAMCFG_RAMCFG_M3IER_ECCNMI                       \ Double error NMI


\
\ @brief RAMCFG memory interrupt status register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMCFG_M3ISR_SEDC                         \ ECC single error detected and corrected
$00000002 constant RAMCFG_RAMCFG_M3ISR_DED                          \ ECC double error detected
$00000100 constant RAMCFG_RAMCFG_M3ISR_SRAMBUSY                     \ SRAM busy with erase operation


\
\ @brief RAMCFG memory 3 ECC single error address register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMCFG_M3SEAR_ESEA                        \ ECC single error address


\
\ @brief RAMCFG memory 3 ECC double error address register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMCFG_M3DEAR_EDEA                        \ ECC double error address


\
\ @brief RAMCFG memory 3 interrupt clear register 3
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMCFG_M3ICR_CSEDC                        \ Clear ECC single error detected and corrected
$00000002 constant RAMCFG_RAMCFG_M3ICR_CDED                         \ Clear ECC double error detected


\
\ @brief RAMCFG memory 3 ECC key register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_RAMCFG_M3ECCKEYR_ECCKEY                   \ ECC write protection key


\
\ @brief RAMCFG memory 3 erase key register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_RAMCFG_M3ERKEYR_ERASEKEY                  \ Erase write protection key


\
\ @brief RAMCFG memory 4 erase key register
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_RAMCFG_M4ERKEYR_ERASEKEY                  \ Erase write protection key


\
\ @brief RAMCFG memory 5 control register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMCFG_M5CR_ECCE                          \ ECC enable.
$00000010 constant RAMCFG_RAMCFG_M5CR_ALE                           \ Address latch enable
$00000100 constant RAMCFG_RAMCFG_M5CR_SRAMER                        \ SRAM erase


\
\ @brief RAMCFG memory 5 interrupt enable register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMCFG_M5IER_SEIE                         \ ECC single error interrupt enable
$00000002 constant RAMCFG_RAMCFG_M5IER_DEIE                         \ ECC double error interrupt enable
$00000008 constant RAMCFG_RAMCFG_M5IER_ECCNMI                       \ Double error NMI


\
\ @brief RAMCFG memory interrupt status register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMCFG_M5ISR_SEDC                         \ ECC single error detected and corrected
$00000002 constant RAMCFG_RAMCFG_M5ISR_DED                          \ ECC double error detected
$00000100 constant RAMCFG_RAMCFG_M5ISR_SRAMBUSY                     \ SRAM busy with erase operation


\
\ @brief RAMCFG memory 5 ECC single error address register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMCFG_M5SEAR_ESEA                        \ ECC single error address


\
\ @brief RAMCFG memory 5 ECC double error address register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMCFG_M5DEAR_EDEA                        \ ECC double error address


\
\ @brief RAMCFG memory 5 interrupt clear register 5
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMCFG_M5ICR_CSEDC                        \ Clear ECC single error detected and corrected
$00000002 constant RAMCFG_RAMCFG_M5ICR_CDED                         \ Clear ECC double error detected


\
\ @brief RAMCFG memory 5 ECC key register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_RAMCFG_M5ECCKEYR_ECCKEY                   \ ECC write protection key


\
\ @brief RAMCFG memory 5 erase key register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$000000ff constant RAMCFG_RAMCFG_M5ERKEYR_ERASEKEY                  \ Erase write protection key


\
\ @brief RAMCFG address block description
\
$40026000 constant RAMCFG_RAMCFG_M1CR  \ offset: 0x00 : RAMCFG memory 1 control register
$40026008 constant RAMCFG_RAMCFG_M1ISR  \ offset: 0x08 : RAMCFG memory interrupt status register
$40026028 constant RAMCFG_RAMCFG_M1ERKEYR  \ offset: 0x28 : RAMCFG memory 1 erase key register
$40026040 constant RAMCFG_RAMCFG_M2CR  \ offset: 0x40 : RAMCFG memory 2 control register
$40026044 constant RAMCFG_RAMCFG_M2IER  \ offset: 0x44 : RAMCFG memory 2 interrupt enable register
$40026048 constant RAMCFG_RAMCFG_M2ISR  \ offset: 0x48 : RAMCFG memory interrupt status register
$4002604c constant RAMCFG_RAMCFG_M2SEAR  \ offset: 0x4C : RAMCFG memory 2 ECC single error address register
$40026050 constant RAMCFG_RAMCFG_M2DEAR  \ offset: 0x50 : RAMCFG memory 2 ECC double error address register
$40026054 constant RAMCFG_RAMCFG_M2ICR  \ offset: 0x54 : RAMCFG memory 2 interrupt clear register 2
$40026058 constant RAMCFG_RAMCFG_M2WPR1  \ offset: 0x58 : RAMCFG memory 2 write protection register 1
$4002605c constant RAMCFG_RAMCFG_M2WPR2  \ offset: 0x5C : RAMCFG memory 2 write protection register 2
$40026060 constant RAMCFG_RAMCFG_M2WPR3  \ offset: 0x60 : RAMCFG memory 2 write protection register 3
$40026064 constant RAMCFG_RAMCFG_M2ECCKEYR  \ offset: 0x64 : RAMCFG memory 2 ECC key register
$40026068 constant RAMCFG_RAMCFG_M2ERKEYR  \ offset: 0x68 : RAMCFG memory 2 erase key register
$40026080 constant RAMCFG_RAMCFG_M3CR  \ offset: 0x80 : RAMCFG memory 3 control register
$40026084 constant RAMCFG_RAMCFG_M3IER  \ offset: 0x84 : RAMCFG memory 3 interrupt enable register
$40026088 constant RAMCFG_RAMCFG_M3ISR  \ offset: 0x88 : RAMCFG memory interrupt status register
$4002608c constant RAMCFG_RAMCFG_M3SEAR  \ offset: 0x8C : RAMCFG memory 3 ECC single error address register
$40026090 constant RAMCFG_RAMCFG_M3DEAR  \ offset: 0x90 : RAMCFG memory 3 ECC double error address register
$40026094 constant RAMCFG_RAMCFG_M3ICR  \ offset: 0x94 : RAMCFG memory 3 interrupt clear register 3
$400260a4 constant RAMCFG_RAMCFG_M3ECCKEYR  \ offset: 0xA4 : RAMCFG memory 3 ECC key register
$400260a8 constant RAMCFG_RAMCFG_M3ERKEYR  \ offset: 0xA8 : RAMCFG memory 3 erase key register
$400260e8 constant RAMCFG_RAMCFG_M4ERKEYR  \ offset: 0xE8 : RAMCFG memory 4 erase key register
$40026100 constant RAMCFG_RAMCFG_M5CR  \ offset: 0x100 : RAMCFG memory 5 control register
$40026104 constant RAMCFG_RAMCFG_M5IER  \ offset: 0x104 : RAMCFG memory 5 interrupt enable register
$40026108 constant RAMCFG_RAMCFG_M5ISR  \ offset: 0x108 : RAMCFG memory interrupt status register
$4002610c constant RAMCFG_RAMCFG_M5SEAR  \ offset: 0x10C : RAMCFG memory 5 ECC single error address register
$40026110 constant RAMCFG_RAMCFG_M5DEAR  \ offset: 0x110 : RAMCFG memory 5 ECC double error address register
$40026114 constant RAMCFG_RAMCFG_M5ICR  \ offset: 0x114 : RAMCFG memory 5 interrupt clear register 5
$40026124 constant RAMCFG_RAMCFG_M5ECCKEYR  \ offset: 0x124 : RAMCFG memory 5 ECC key register
$40026128 constant RAMCFG_RAMCFG_M5ERKEYR  \ offset: 0x128 : RAMCFG memory 5 erase key register

