\
\ @file syscfg.fs
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

$00000001 constant SYSCFG_SECCFGR_SYSCFGSEC                         \ SYSCFG clock control security
$00000002 constant SYSCFG_SECCFGR_CLASSBSEC                         \ CLASSBSEC
$00000008 constant SYSCFG_SECCFGR_FPUSEC                            \ FPUSEC


\
\ @brief configuration register 1
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000100 constant SYSCFG_CFGR1_BOOSTEN                             \ I/O analog switch voltage booster enable
$00000200 constant SYSCFG_CFGR1_ANASWVDD                            \ GPIO analog switch control voltage selection
$00010000 constant SYSCFG_CFGR1_PB6_FMP                             \ PB6_FMP
$00020000 constant SYSCFG_CFGR1_PB7_FMP                             \ PB7_FMP
$00040000 constant SYSCFG_CFGR1_PB8_FMP                             \ PB8_FMP
$00080000 constant SYSCFG_CFGR1_PB9_FMP                             \ PB9_FMP
$03000000 constant SYSCFG_CFGR1_ENDCAP                              \ ENDCAP


\
\ @brief FPU interrupt mask register
\ Address offset: 0x08
\ Reset value: 0x0000001F
\

$0000003f constant SYSCFG_FPUIMR_FPU_IE                             \ Floating point unit interrupts enable bits


\
\ @brief SYSCFG CPU non-secure lock register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_CNSLCKR_LOCKNSVTOR                        \ VTOR_NS register lock
$00000002 constant SYSCFG_CNSLCKR_LOCKNSMPU                         \ Non-secure MPU registers lock


\
\ @brief SYSCFG CPU secure lock register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_CSLOCKR_LOCKSVTAIRCR                      \ LOCKSVTAIRCR
$00000002 constant SYSCFG_CSLOCKR_LOCKSMPU                          \ LOCKSMPU
$00000004 constant SYSCFG_CSLOCKR_LOCKSAU                           \ LOCKSAU


\
\ @brief configuration register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_CFGR2_CLL                                 \ LOCKUP (hardfault) output enable bit
$00000002 constant SYSCFG_CFGR2_SPL                                 \ SRAM ECC lock bit
$00000004 constant SYSCFG_CFGR2_PVDL                                \ PVD lock enable bit
$00000008 constant SYSCFG_CFGR2_ECCL                                \ ECC Lock


\
\ @brief memory erase status register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_MESR_MCLR                                 \ MCLR
$00010000 constant SYSCFG_MESR_IPMEE                                \ IPMEE


\
\ @brief compensation cell control/status register
\ Address offset: 0x1C
\ Reset value: 0x0000000A
\

$00000001 constant SYSCFG_CCCSR_EN1                                 \ EN1
$00000002 constant SYSCFG_CCCSR_CS1                                 \ CS1
$00000004 constant SYSCFG_CCCSR_EN2                                 \ EN2
$00000008 constant SYSCFG_CCCSR_CS2                                 \ CS2
$00000010 constant SYSCFG_CCCSR_EN3                                 \ EN3
$00000020 constant SYSCFG_CCCSR_CS3                                 \ CS3
$00000100 constant SYSCFG_CCCSR_RDY1                                \ RDY1
$00000200 constant SYSCFG_CCCSR_RDY2                                \ RDY2
$00000400 constant SYSCFG_CCCSR_RDY3                                \ RDY3


\
\ @brief compensation cell value register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant SYSCFG_CCVR_NCV1                                 \ NCV1
$000000f0 constant SYSCFG_CCVR_PCV1                                 \ PCV1
$00000f00 constant SYSCFG_CCVR_NCV2                                 \ NCV2
$0000f000 constant SYSCFG_CCVR_PCV2                                 \ PCV2
$000f0000 constant SYSCFG_CCVR_NCV3                                 \ NCV3
$00f00000 constant SYSCFG_CCVR_PCV3                                 \ PCV3


\
\ @brief compensation cell code register
\ Address offset: 0x24
\ Reset value: 0x00007878
\

$0000000f constant SYSCFG_CCCR_NCC1                                 \ NCC1
$000000f0 constant SYSCFG_CCCR_PCC1                                 \ PCC1
$00000f00 constant SYSCFG_CCCR_NCC2                                 \ NCC2
$0000f000 constant SYSCFG_CCCR_PCC2                                 \ PCC2
$000f0000 constant SYSCFG_CCCR_NCC3                                 \ NCC3
$00f00000 constant SYSCFG_CCCR_PCC3                                 \ PCC3


\
\ @brief RSS command register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant SYSCFG_RSSCMDR_RSSCMD                            \ RSS commands


\
\ @brief System configuration controller
\
$46000400 constant SYSCFG_SECCFGR  \ offset: 0x00 : SYSCFG secure configuration register
$46000404 constant SYSCFG_CFGR1   \ offset: 0x04 : configuration register 1
$46000408 constant SYSCFG_FPUIMR  \ offset: 0x08 : FPU interrupt mask register
$4600040c constant SYSCFG_CNSLCKR  \ offset: 0x0C : SYSCFG CPU non-secure lock register
$46000410 constant SYSCFG_CSLOCKR  \ offset: 0x10 : SYSCFG CPU secure lock register
$46000414 constant SYSCFG_CFGR2   \ offset: 0x14 : configuration register 2
$46000418 constant SYSCFG_MESR    \ offset: 0x18 : memory erase status register
$4600041c constant SYSCFG_CCCSR   \ offset: 0x1C : compensation cell control/status register
$46000420 constant SYSCFG_CCVR    \ offset: 0x20 : compensation cell value register
$46000424 constant SYSCFG_CCCR    \ offset: 0x24 : compensation cell code register
$4600042c constant SYSCFG_RSSCMDR  \ offset: 0x2C : RSS command register

