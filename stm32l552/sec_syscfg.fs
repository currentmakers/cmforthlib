\
\ @file sec_syscfg.fs
\ @brief System configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SYSCFG secure configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_SYSCFG_SECCFGR_SYSCFGSEC                     \ SYSCFG clock control security
$00000002 constant SEC_SYSCFG_SECCFGR_CLASSBSEC                     \ ClassB security
$00000004 constant SEC_SYSCFG_SECCFGR_SRAM2SEC                      \ SRAM2 security
$00000008 constant SEC_SYSCFG_SECCFGR_FPUSEC                        \ FPUSEC


\
\ @brief configuration register 1
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000100 constant SEC_SYSCFG_CFGR1_BOOSTEN                         \ I/O analog switch voltage booster enable
$00000200 constant SEC_SYSCFG_CFGR1_ANASWVDD                        \ GPIO analog switch control voltage selection
$00010000 constant SEC_SYSCFG_CFGR1_I2C_PB6_FMP                     \ Fast-mode Plus (Fm+) driving capability activation on PB6
$00020000 constant SEC_SYSCFG_CFGR1_I2C_PB7_FMP                     \ Fast-mode Plus (Fm+) driving capability activation on PB7
$00040000 constant SEC_SYSCFG_CFGR1_I2C_PB8_FMP                     \ Fast-mode Plus (Fm+) driving capability activation on PB8
$00080000 constant SEC_SYSCFG_CFGR1_I2C_PB9_FMP                     \ Fast-mode Plus (Fm+) driving capability activation on PB9
$00100000 constant SEC_SYSCFG_CFGR1_I2C1_FMP                        \ I2C1 Fast-mode Plus driving capability activation
$00200000 constant SEC_SYSCFG_CFGR1_I2C2_FMP                        \ I2C2 Fast-mode Plus driving capability activation
$00400000 constant SEC_SYSCFG_CFGR1_I2C3_FMP                        \ I2C3 Fast-mode Plus driving capability activation
$00800000 constant SEC_SYSCFG_CFGR1_I2C4_FMP                        \ I2C4_FMP


\
\ @brief FPU interrupt mask register
\ Address offset: 0x08
\ Reset value: 0x0000001F
\

$0000003f constant SEC_SYSCFG_FPUIMR_FPU_IE                         \ Floating point unit interrupts enable bits


\
\ @brief SYSCFG CPU non-secure lock register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SEC_SYSCFG_CNSLCKR_LOCKNSVTOR                    \ VTOR_NS register lock
$00000002 constant SEC_SYSCFG_CNSLCKR_LOCKNSMPU                     \ Non-secure MPU registers lock


\
\ @brief SYSCFG CPU secure lock register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_SYSCFG_CSLOCKR_LOCKSVTAIRCR                  \ LOCKSVTAIRCR
$00000002 constant SEC_SYSCFG_CSLOCKR_LOCKSMPU                      \ LOCKSMPU
$00000004 constant SEC_SYSCFG_CSLOCKR_LOCKSAU                       \ LOCKSAU


\
\ @brief CFGR2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SEC_SYSCFG_CFGR2_CLL                             \ LOCKUP (hardfault) output enable bit
$00000002 constant SEC_SYSCFG_CFGR2_SPL                             \ SRAM2 parity lock bit
$00000004 constant SEC_SYSCFG_CFGR2_PVDL                            \ PVD lock enable bit
$00000008 constant SEC_SYSCFG_CFGR2_ECCL                            \ ECC Lock
$00000100 constant SEC_SYSCFG_CFGR2_SPF                             \ SRAM2 parity error flag


\
\ @brief SCSR
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SEC_SYSCFG_SCSR_SRAM2ER                          \ SRAM2 Erase
$00000002 constant SEC_SYSCFG_SCSR_SRAM2BSY                         \ SRAM2 busy by erase operation


\
\ @brief SKR
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000000ff constant SEC_SYSCFG_SKR_KEY                               \ SRAM2 write protection key for software erase


\
\ @brief SWPR
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SEC_SYSCFG_SWPR_P0WP                             \ P0WP
$00000002 constant SEC_SYSCFG_SWPR_P1WP                             \ P1WP
$00000004 constant SEC_SYSCFG_SWPR_P2WP                             \ P2WP
$00000008 constant SEC_SYSCFG_SWPR_P3WP                             \ P3WP
$00000010 constant SEC_SYSCFG_SWPR_P4WP                             \ P4WP
$00000020 constant SEC_SYSCFG_SWPR_P5WP                             \ P5WP
$00000040 constant SEC_SYSCFG_SWPR_P6WP                             \ P6WP
$00000080 constant SEC_SYSCFG_SWPR_P7WP                             \ P7WP
$00000100 constant SEC_SYSCFG_SWPR_P8WP                             \ P8WP
$00000200 constant SEC_SYSCFG_SWPR_P9WP                             \ P9WP
$00000400 constant SEC_SYSCFG_SWPR_P10WP                            \ P10WP
$00000800 constant SEC_SYSCFG_SWPR_P11WP                            \ P11WP
$00001000 constant SEC_SYSCFG_SWPR_P12WP                            \ P12WP
$00002000 constant SEC_SYSCFG_SWPR_P13WP                            \ P13WP
$00004000 constant SEC_SYSCFG_SWPR_P14WP                            \ P14WP
$00008000 constant SEC_SYSCFG_SWPR_P15WP                            \ P15WP
$00010000 constant SEC_SYSCFG_SWPR_P16WP                            \ P16WP
$00020000 constant SEC_SYSCFG_SWPR_P17WP                            \ P17WP
$00040000 constant SEC_SYSCFG_SWPR_P18WP                            \ P18WP
$00080000 constant SEC_SYSCFG_SWPR_P19WP                            \ P19WP
$00100000 constant SEC_SYSCFG_SWPR_P20WP                            \ P20WP
$00200000 constant SEC_SYSCFG_SWPR_P21WP                            \ P21WP
$00400000 constant SEC_SYSCFG_SWPR_P22WP                            \ P22WP
$00800000 constant SEC_SYSCFG_SWPR_P23WP                            \ P23WP
$01000000 constant SEC_SYSCFG_SWPR_P24WP                            \ P24WP
$02000000 constant SEC_SYSCFG_SWPR_P25WP                            \ P25WP
$04000000 constant SEC_SYSCFG_SWPR_P26WP                            \ P26WP
$08000000 constant SEC_SYSCFG_SWPR_P27WP                            \ P27WP
$10000000 constant SEC_SYSCFG_SWPR_P28WP                            \ P28WP
$20000000 constant SEC_SYSCFG_SWPR_P29WP                            \ P29WP
$40000000 constant SEC_SYSCFG_SWPR_P30WP                            \ P30WP
$80000000 constant SEC_SYSCFG_SWPR_P31WP                            \ SRAM2 page 31 write protection


\
\ @brief SWPR2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant SEC_SYSCFG_SWPR2_P32WP                           \ P32WP
$00000002 constant SEC_SYSCFG_SWPR2_P33WP                           \ P33WP
$00000004 constant SEC_SYSCFG_SWPR2_P34WP                           \ P34WP
$00000008 constant SEC_SYSCFG_SWPR2_P35WP                           \ P35WP
$00000010 constant SEC_SYSCFG_SWPR2_P36WP                           \ P36WP
$00000020 constant SEC_SYSCFG_SWPR2_P37WP                           \ P37WP
$00000040 constant SEC_SYSCFG_SWPR2_P38WP                           \ P38WP
$00000080 constant SEC_SYSCFG_SWPR2_P39WP                           \ P39WP
$00000100 constant SEC_SYSCFG_SWPR2_P40WP                           \ P40WP
$00000200 constant SEC_SYSCFG_SWPR2_P41WP                           \ P41WP
$00000400 constant SEC_SYSCFG_SWPR2_P42WP                           \ P42WP
$00000800 constant SEC_SYSCFG_SWPR2_P43WP                           \ P43WP
$00001000 constant SEC_SYSCFG_SWPR2_P44WP                           \ P44WP
$00002000 constant SEC_SYSCFG_SWPR2_P45WP                           \ P45WP
$00004000 constant SEC_SYSCFG_SWPR2_P46WP                           \ P46WP
$00008000 constant SEC_SYSCFG_SWPR2_P47WP                           \ P47WP
$00010000 constant SEC_SYSCFG_SWPR2_P48WP                           \ P48WP
$00020000 constant SEC_SYSCFG_SWPR2_P49WP                           \ P49WP
$00040000 constant SEC_SYSCFG_SWPR2_P50WP                           \ P50WP
$00080000 constant SEC_SYSCFG_SWPR2_P51WP                           \ P51WP
$00100000 constant SEC_SYSCFG_SWPR2_P52WP                           \ P52WP
$00200000 constant SEC_SYSCFG_SWPR2_P53WP                           \ P53WP
$00400000 constant SEC_SYSCFG_SWPR2_P54WP                           \ P54WP
$00800000 constant SEC_SYSCFG_SWPR2_P55WP                           \ P55WP
$01000000 constant SEC_SYSCFG_SWPR2_P56WP                           \ P56WP
$02000000 constant SEC_SYSCFG_SWPR2_P57WP                           \ P57WP
$04000000 constant SEC_SYSCFG_SWPR2_P58WP                           \ P58WP
$08000000 constant SEC_SYSCFG_SWPR2_P59WP                           \ P59WP
$10000000 constant SEC_SYSCFG_SWPR2_P60WP                           \ P60WP
$20000000 constant SEC_SYSCFG_SWPR2_P61WP                           \ P61WP
$40000000 constant SEC_SYSCFG_SWPR2_P62WP                           \ P62WP
$80000000 constant SEC_SYSCFG_SWPR2_P63WP                           \ P63WP


\
\ @brief RSSCMDR
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$000000ff constant SEC_SYSCFG_RSSCMDR_RSSCMD                        \ RSS commands


\
\ @brief System configuration controller
\
$50010000 constant SEC_SYSCFG_SECCFGR  \ offset: 0x00 : SYSCFG secure configuration register
$50010004 constant SEC_SYSCFG_CFGR1  \ offset: 0x04 : configuration register 1
$50010008 constant SEC_SYSCFG_FPUIMR  \ offset: 0x08 : FPU interrupt mask register
$5001000c constant SEC_SYSCFG_CNSLCKR  \ offset: 0x0C : SYSCFG CPU non-secure lock register
$50010010 constant SEC_SYSCFG_CSLOCKR  \ offset: 0x10 : SYSCFG CPU secure lock register
$50010014 constant SEC_SYSCFG_CFGR2  \ offset: 0x14 : CFGR2
$50010018 constant SEC_SYSCFG_SCSR  \ offset: 0x18 : SCSR
$5001001c constant SEC_SYSCFG_SKR  \ offset: 0x1C : SKR
$50010020 constant SEC_SYSCFG_SWPR  \ offset: 0x20 : SWPR
$50010024 constant SEC_SYSCFG_SWPR2  \ offset: 0x24 : SWPR2
$5001002c constant SEC_SYSCFG_RSSCMDR  \ offset: 0x2C : RSSCMDR

