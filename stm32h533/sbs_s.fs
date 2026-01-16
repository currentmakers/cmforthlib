\
\ @file sbs_s.fs
\ @brief SBS address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SBS temporal isolation control register
\ Address offset: 0x10
\ Reset value: 0x000000B4
\

$000000ff constant SBS_S_SBS_HDPLCR_INCR_HDPL                       \ increment HDPL value


\
\ @brief SBS temporal isolation status register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant SBS_S_SBS_HDPLSR_HDPL                            \ temporal isolation level


\
\ @brief SBS next HDPL control register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant SBS_S_SBS_NEXTHDPLCR_NEXTHDPL                    \ index to point to a higher HDPL than the current one


\
\ @brief SBS debug control register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant SBS_S_SBS_DBGCR_AP_UNLOCK                        \ access port unlock
$0000ff00 constant SBS_S_SBS_DBGCR_DBG_UNLOCK                       \ debug unlock when DBG_AUTH_HDPL is reached
$00ff0000 constant SBS_S_SBS_DBGCR_DBG_AUTH_HDPL                    \ authenticated debug temporal isolation level
$ff000000 constant SBS_S_SBS_DBGCR_DBG_AUTH_SEC                     \ control debug opening secure/non-secure


\
\ @brief SBS debug lock register
\ Address offset: 0x24
\ Reset value: 0x000000B4
\

$000000ff constant SBS_S_SBS_DBGLOCKR_DBGCFG_LOCK                   \ debug configuration lock


\
\ @brief SBS RSS command register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant SBS_S_SBS_RSSCMDR_RSSCMD                         \ RSS command


\
\ @brief SBS EPOCH selection control register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000003 constant SBS_S_SBS_EPOCHSELCR_EPOCH_SEL                   \ select EPOCH value to be sent to the SAES


\
\ @brief SBS security mode configuration control register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant SBS_S_SBS_SECCFGR_SBSSEC                         \ SBS clock control, memory-erase status register and compensation cell register security enable
$00000002 constant SBS_S_SBS_SECCFGR_CLASSBSEC                      \ ClassB security enable
$00000008 constant SBS_S_SBS_SECCFGR_FPUSEC                         \ FPU security enable


\
\ @brief SBS product mode and configuration register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00010000 constant SBS_S_SBS_PMCR_PB6_FMP                           \ Fast-mode Plus driving capability activation on PB6
$00020000 constant SBS_S_SBS_PMCR_PB7_FMP                           \ Fast-mode Plus driving capability activation on PB7
$00040000 constant SBS_S_SBS_PMCR_PB8_FMP                           \ Fast-mode Plus driving capability activation on PB8
$00080000 constant SBS_S_SBS_PMCR_PB9_FMP                           \ Fast-mode Plus driving capability activation on PB9
$00e00000 constant SBS_S_SBS_PMCR_ETH_SEL_PHY                       \ Ethernet PHY interface selection


\
\ @brief SBS FPU interrupt mask register
\ Address offset: 0x104
\ Reset value: 0x0000001F
\

$0000003f constant SBS_S_SBS_FPUIMR_FPU_IE                          \ FPU interrupt enable


\
\ @brief SBS memory erase status register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant SBS_S_SBS_MESR_MCLR                              \ device memories erase status
$00010000 constant SBS_S_SBS_MESR_IPMEE                             \ ICACHE erase status


\
\ @brief SBS compensation cell for I/Os control and status register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000001 constant SBS_S_SBS_CCCSR_EN1                              \ enable compensation cell for VDDIO power rail
$00000002 constant SBS_S_SBS_CCCSR_CS1                              \ code selection for VDDIO power rail (reset value set to 1)
$00000004 constant SBS_S_SBS_CCCSR_EN2                              \ enable compensation cell for VDDIO2 power rail
$00000008 constant SBS_S_SBS_CCCSR_CS2                              \ code selection for VDDIO2 power rail (reset value set to 1)
$00000100 constant SBS_S_SBS_CCCSR_RDY1                             \ VDDIO compensation cell ready flag
$00000200 constant SBS_S_SBS_CCCSR_RDY2                             \ VDDIO2 compensation cell ready flag


\
\ @brief SBS compensation cell for I/Os value register
\ Address offset: 0x114
\ Reset value: 0x00000088
\

$0000000f constant SBS_S_SBS_CCVALR_ANSRC1                          \ compensation value for the NMOS transistor
$000000f0 constant SBS_S_SBS_CCVALR_APSRC1                          \ compensation value for the PMOS transistor
$00000f00 constant SBS_S_SBS_CCVALR_ANSRC2                          \ Compensation value for the NMOS transistor
$0000f000 constant SBS_S_SBS_CCVALR_APSRC2                          \ compensation value for the PMOS transistor


\
\ @brief SBS compensation cell for I/Os software code register
\ Address offset: 0x118
\ Reset value: 0x00007878
\

$0000000f constant SBS_S_SBS_CCSWCR_SW_ANSRC1                       \ NMOS compensation code for VDD power rails
$000000f0 constant SBS_S_SBS_CCSWCR_SW_APSRC1                       \ PMOS compensation code for the VDD power rails
$00000f00 constant SBS_S_SBS_CCSWCR_SW_ANSRC2                       \ NMOS compensation code for VDDIO power rails
$0000f000 constant SBS_S_SBS_CCSWCR_SW_APSRC2                       \ PMOS compensation code for the Vless thansub>DDIOless than/sub> power rails


\
\ @brief SBS Class B register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000001 constant SBS_S_SBS_CFGR2_CLL                              \ core lockup lock
$00000002 constant SBS_S_SBS_CFGR2_SEL                              \ SRAM ECC error lock
$00000004 constant SBS_S_SBS_CFGR2_PVDL                             \ PVD lock
$00000008 constant SBS_S_SBS_CFGR2_ECCL                             \ ECC lock


\
\ @brief SBS CPU non-secure lock register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000001 constant SBS_S_SBS_CNSLCKR_LOCKNSVTOR                     \ VTOR_NS register lock
$00000002 constant SBS_S_SBS_CNSLCKR_LOCKNSMPU                      \ non-secure MPU register lock


\
\ @brief SBS CPU secure lock register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000001 constant SBS_S_SBS_CSLCKR_LOCKSVTAIRCR                    \ VTOR_S and AIRCR register lock
$00000002 constant SBS_S_SBS_CSLCKR_LOCKSMPU                        \ secure MPU registers lock
$00000004 constant SBS_S_SBS_CSLCKR_LOCKSAU                         \ SAU registers lock


\
\ @brief SBS flift ECC NMI mask register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000001 constant SBS_S_SBS_ECCNMIR_ECCNMI_MASK_EN                 \ NMI behavior setup when a double ECC error occurs on flitf data part


\
\ @brief SBS address block description
\
$54000410 constant SBS_S_SBS_HDPLCR  \ offset: 0x10 : SBS temporal isolation control register
$54000414 constant SBS_S_SBS_HDPLSR  \ offset: 0x14 : SBS temporal isolation status register
$54000418 constant SBS_S_SBS_NEXTHDPLCR  \ offset: 0x18 : SBS next HDPL control register
$54000420 constant SBS_S_SBS_DBGCR  \ offset: 0x20 : SBS debug control register
$54000424 constant SBS_S_SBS_DBGLOCKR  \ offset: 0x24 : SBS debug lock register
$54000434 constant SBS_S_SBS_RSSCMDR  \ offset: 0x34 : SBS RSS command register
$540004a0 constant SBS_S_SBS_EPOCHSELCR  \ offset: 0xA0 : SBS EPOCH selection control register
$540004c0 constant SBS_S_SBS_SECCFGR  \ offset: 0xC0 : SBS security mode configuration control register
$54000500 constant SBS_S_SBS_PMCR  \ offset: 0x100 : SBS product mode and configuration register
$54000504 constant SBS_S_SBS_FPUIMR  \ offset: 0x104 : SBS FPU interrupt mask register
$54000508 constant SBS_S_SBS_MESR  \ offset: 0x108 : SBS memory erase status register
$54000510 constant SBS_S_SBS_CCCSR  \ offset: 0x110 : SBS compensation cell for I/Os control and status register
$54000514 constant SBS_S_SBS_CCVALR  \ offset: 0x114 : SBS compensation cell for I/Os value register
$54000518 constant SBS_S_SBS_CCSWCR  \ offset: 0x118 : SBS compensation cell for I/Os software code register
$54000520 constant SBS_S_SBS_CFGR2  \ offset: 0x120 : SBS Class B register
$54000544 constant SBS_S_SBS_CNSLCKR  \ offset: 0x144 : SBS CPU non-secure lock register
$54000548 constant SBS_S_SBS_CSLCKR  \ offset: 0x148 : SBS CPU secure lock register
$5400054c constant SBS_S_SBS_ECCNMIR  \ offset: 0x14C : SBS flift ECC NMI mask register

