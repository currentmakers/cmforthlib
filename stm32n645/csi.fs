\
\ @file csi.fs
\ @brief CSI-2 Host
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief CSI-2 Host control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant CSI_CSI_CR_CSIEN                                 \ CSI-2 enable
$00000004 constant CSI_CSI_CR_VC0START                              \ Virtual channel 0 start
$00000008 constant CSI_CSI_CR_VC0STOP                               \ Virtual channel 0 stop
$00000040 constant CSI_CSI_CR_VC1START                              \ Virtual channel 1 start
$00000080 constant CSI_CSI_CR_VC1STOP                               \ Virtual channel 1 stop
$00000400 constant CSI_CSI_CR_VC2START                              \ Virtual channel 2 start
$00000800 constant CSI_CSI_CR_VC2STOP                               \ Virtual channel 2 stop
$00004000 constant CSI_CSI_CR_VC3START                              \ Virtual channel 3 start
$00008000 constant CSI_CSI_CR_VC3STOP                               \ Virtual channel 3 stop


\
\ @brief CSI-2 Host DPHY_RX control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant CSI_CSI_PCR_PWRDOWN                              \ Power down
$00000002 constant CSI_CSI_PCR_CLEN                                 \ Clock lane enable
$00000004 constant CSI_CSI_PCR_DL0EN                                \ D-PHY_RX data lane 0 enable
$00000008 constant CSI_CSI_PCR_DL1EN                                \ D-PHY_RX data lane 1 enable


\
\ @brief CSI-2 Host virtual channel 0 configuration register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant CSI_CSI_VC0CFGR1_ALLDT                           \ All data types enable for the virtual channel x
$00000002 constant CSI_CSI_VC0CFGR1_DT0EN                           \ Data type 0 enable
$00000004 constant CSI_CSI_VC0CFGR1_DT1EN                           \ Data type 1 enable
$00000008 constant CSI_CSI_VC0CFGR1_DT2EN                           \ Data type 2 enable
$00000010 constant CSI_CSI_VC0CFGR1_DT3EN                           \ Data type 3 enable
$00000020 constant CSI_CSI_VC0CFGR1_DT4EN                           \ Data type 4 enable
$00000040 constant CSI_CSI_VC0CFGR1_DT5EN                           \ Data type 5 enable
$00000080 constant CSI_CSI_VC0CFGR1_DT6EN                           \ Data type 6 enable
$00001f00 constant CSI_CSI_VC0CFGR1_CDTFT                           \ Common format for all data types
$003f0000 constant CSI_CSI_VC0CFGR1_DT0                             \ Data type 0 class selection for virtual channel x
$1f000000 constant CSI_CSI_VC0CFGR1_DT0FT                           \ Data type 0 format


\
\ @brief CSI-2 Host virtual channel 0 configuration register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000003f constant CSI_CSI_VC0CFGR2_DT1                             \ Data type 1 class selection for virtual channel x
$00001f00 constant CSI_CSI_VC0CFGR2_DT1FT                           \ Data type 1 format
$003f0000 constant CSI_CSI_VC0CFGR2_DT2                             \ Data type 2 class selection for virtual channel x
$1f000000 constant CSI_CSI_VC0CFGR2_DT2FT                           \ Data type 2 format


\
\ @brief CSI-2 Host virtual channel 0 configuration register 3
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000003f constant CSI_CSI_VC0CFGR3_DT3                             \ Data type 3 class selection for virtual channel x
$00001f00 constant CSI_CSI_VC0CFGR3_DT3FT                           \ Data type 3 format
$003f0000 constant CSI_CSI_VC0CFGR3_DT4                             \ Data type 4 class selection for virtual channel x
$1f000000 constant CSI_CSI_VC0CFGR3_DT4FT                           \ Data type 4 format


\
\ @brief CSI-2 Host virtual channel 0 configuration register 4
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000003f constant CSI_CSI_VC0CFGR4_DT5                             \ Data type 5 class selection for virtual channel x
$00001f00 constant CSI_CSI_VC0CFGR4_DT5FT                           \ Data type 5 format
$003f0000 constant CSI_CSI_VC0CFGR4_DT6                             \ Data type 6 class selection for virtual channel x
$1f000000 constant CSI_CSI_VC0CFGR4_DT6FT                           \ Data type 6 format


\
\ @brief CSI-2 Host virtual channel 1 configuration register 1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant CSI_CSI_VC1CFGR1_ALLDT                           \ All data types enable for the virtual channel x
$00000002 constant CSI_CSI_VC1CFGR1_DT0EN                           \ Data type 0 enable
$00000004 constant CSI_CSI_VC1CFGR1_DT1EN                           \ Data type 1 enable
$00000008 constant CSI_CSI_VC1CFGR1_DT2EN                           \ Data type 2 enable
$00000010 constant CSI_CSI_VC1CFGR1_DT3EN                           \ Data type 3 enable
$00000020 constant CSI_CSI_VC1CFGR1_DT4EN                           \ Data type 4 enable
$00000040 constant CSI_CSI_VC1CFGR1_DT5EN                           \ Data type 5 enable
$00000080 constant CSI_CSI_VC1CFGR1_DT6EN                           \ Data type 6 enable
$00001f00 constant CSI_CSI_VC1CFGR1_CDTFT                           \ Common format for all data types
$003f0000 constant CSI_CSI_VC1CFGR1_DT0                             \ Data type 0 class selection for virtual channel x
$1f000000 constant CSI_CSI_VC1CFGR1_DT0FT                           \ Data type 0 format


\
\ @brief CSI-2 Host virtual channel 1 configuration register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000003f constant CSI_CSI_VC1CFGR2_DT1                             \ Data type 1 class selection for virtual channel x
$00001f00 constant CSI_CSI_VC1CFGR2_DT1FT                           \ Data type 1 format
$003f0000 constant CSI_CSI_VC1CFGR2_DT2                             \ Data type 2 class selection for virtual channel x
$1f000000 constant CSI_CSI_VC1CFGR2_DT2FT                           \ Data type 2 format


\
\ @brief CSI-2 Host virtual channel 1 configuration register 3
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000003f constant CSI_CSI_VC1CFGR3_DT3                             \ Data type 3 class selection for virtual channel x
$00001f00 constant CSI_CSI_VC1CFGR3_DT3FT                           \ Data type 3 format
$003f0000 constant CSI_CSI_VC1CFGR3_DT4                             \ Data type 4 class selection for virtual channel x
$1f000000 constant CSI_CSI_VC1CFGR3_DT4FT                           \ Data type 4 format


\
\ @brief CSI-2 Host virtual channel 1 configuration register 4
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000003f constant CSI_CSI_VC1CFGR4_DT5                             \ Data type 5 class selection for virtual channel x
$00001f00 constant CSI_CSI_VC1CFGR4_DT5FT                           \ Data type 5 format
$003f0000 constant CSI_CSI_VC1CFGR4_DT6                             \ Data type 6 class selection for virtual channel x
$1f000000 constant CSI_CSI_VC1CFGR4_DT6FT                           \ Data type 6 format


\
\ @brief CSI-2 Host virtual channel 2 configuration register 1
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant CSI_CSI_VC2CFGR1_ALLDT                           \ All data types enable for the virtual channel x
$00000002 constant CSI_CSI_VC2CFGR1_DT0EN                           \ Data type 0 enable
$00000004 constant CSI_CSI_VC2CFGR1_DT1EN                           \ Data type 1 enable
$00000008 constant CSI_CSI_VC2CFGR1_DT2EN                           \ Data type 2 enable
$00000010 constant CSI_CSI_VC2CFGR1_DT3EN                           \ Data type 3 enable
$00000020 constant CSI_CSI_VC2CFGR1_DT4EN                           \ Data type 4 enable
$00000040 constant CSI_CSI_VC2CFGR1_DT5EN                           \ Data type 5 enable
$00000080 constant CSI_CSI_VC2CFGR1_DT6EN                           \ Data type 6 enable
$00001f00 constant CSI_CSI_VC2CFGR1_CDTFT                           \ Common format for all data types
$003f0000 constant CSI_CSI_VC2CFGR1_DT0                             \ Data type 0 class selection for virtual channel x
$1f000000 constant CSI_CSI_VC2CFGR1_DT0FT                           \ Data type 0 format


\
\ @brief CSI-2 Host virtual channel 2 configuration register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000003f constant CSI_CSI_VC2CFGR2_DT1                             \ Data type 1 class selection for virtual channel x
$00001f00 constant CSI_CSI_VC2CFGR2_DT1FT                           \ Data type 1 format
$003f0000 constant CSI_CSI_VC2CFGR2_DT2                             \ Data type 2 class selection for virtual channel x
$1f000000 constant CSI_CSI_VC2CFGR2_DT2FT                           \ Data type 2 format


\
\ @brief CSI-2 Host virtual channel 2 configuration register 3
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000003f constant CSI_CSI_VC2CFGR3_DT3                             \ Data type 3 class selection for virtual channel x
$00001f00 constant CSI_CSI_VC2CFGR3_DT3FT                           \ Data type 3 format
$003f0000 constant CSI_CSI_VC2CFGR3_DT4                             \ Data type 4 class selection for virtual channel x
$1f000000 constant CSI_CSI_VC2CFGR3_DT4FT                           \ Data type 4 format


\
\ @brief CSI-2 Host virtual channel 2 configuration register 4
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000003f constant CSI_CSI_VC2CFGR4_DT5                             \ Data type 5 class selection for virtual channel x
$00001f00 constant CSI_CSI_VC2CFGR4_DT5FT                           \ Data type 5 format
$003f0000 constant CSI_CSI_VC2CFGR4_DT6                             \ Data type 6 class selection for virtual channel x
$1f000000 constant CSI_CSI_VC2CFGR4_DT6FT                           \ Data type 6 format


\
\ @brief CSI-2 Host virtual channel 3 configuration register 1
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant CSI_CSI_VC3CFGR1_ALLDT                           \ All data types enable for the virtual channel x
$00000002 constant CSI_CSI_VC3CFGR1_DT0EN                           \ Data type 0 enable
$00000004 constant CSI_CSI_VC3CFGR1_DT1EN                           \ Data type 1 enable
$00000008 constant CSI_CSI_VC3CFGR1_DT2EN                           \ Data type 2 enable
$00000010 constant CSI_CSI_VC3CFGR1_DT3EN                           \ Data type 3 enable
$00000020 constant CSI_CSI_VC3CFGR1_DT4EN                           \ Data type 4 enable
$00000040 constant CSI_CSI_VC3CFGR1_DT5EN                           \ Data type 5 enable
$00000080 constant CSI_CSI_VC3CFGR1_DT6EN                           \ Data type 6 enable
$00001f00 constant CSI_CSI_VC3CFGR1_CDTFT                           \ Common format for all data types
$003f0000 constant CSI_CSI_VC3CFGR1_DT0                             \ Data type 0 class selection for virtual channel x
$1f000000 constant CSI_CSI_VC3CFGR1_DT0FT                           \ Data type 0 format


\
\ @brief CSI-2 Host virtual channel 3 configuration register 2
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000003f constant CSI_CSI_VC3CFGR2_DT1                             \ Data type 1 class selection for virtual channel x
$00001f00 constant CSI_CSI_VC3CFGR2_DT1FT                           \ Data type 1 format
$003f0000 constant CSI_CSI_VC3CFGR2_DT2                             \ Data type 2 class selection for virtual channel x
$1f000000 constant CSI_CSI_VC3CFGR2_DT2FT                           \ Data type 2 format


\
\ @brief CSI-2 Host virtual channel 3 configuration register 3
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000003f constant CSI_CSI_VC3CFGR3_DT3                             \ Data type 3 class selection for virtual channel x
$00001f00 constant CSI_CSI_VC3CFGR3_DT3FT                           \ Data type 3 format
$003f0000 constant CSI_CSI_VC3CFGR3_DT4                             \ Data type 4 class selection for virtual channel x
$1f000000 constant CSI_CSI_VC3CFGR3_DT4FT                           \ Data type 4 format


\
\ @brief CSI-2 Host virtual channel 3 configuration register 4
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000003f constant CSI_CSI_VC3CFGR4_DT5                             \ Data type 5 class selection for virtual channel x
$00001f00 constant CSI_CSI_VC3CFGR4_DT5FT                           \ Data type 5 format
$003f0000 constant CSI_CSI_VC3CFGR4_DT6                             \ Data type 6 class selection for virtual channel x
$1f000000 constant CSI_CSI_VC3CFGR4_DT6FT                           \ Data type 6 format


\
\ @brief CSI-2 Host line byte 0 configuration register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$0000ffff constant CSI_CSI_LB0CFGR_BYTECNT                          \ Byte counter
$ffff0000 constant CSI_CSI_LB0CFGR_LINECNT                          \ Line counter


\
\ @brief CSI-2 Host line byte 1 configuration register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$0000ffff constant CSI_CSI_LB1CFGR_BYTECNT                          \ Byte counter
$ffff0000 constant CSI_CSI_LB1CFGR_LINECNT                          \ Line counter


\
\ @brief CSI-2 Host line byte 2 configuration register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$0000ffff constant CSI_CSI_LB2CFGR_BYTECNT                          \ Byte counter
$ffff0000 constant CSI_CSI_LB2CFGR_LINECNT                          \ Line counter


\
\ @brief CSI-2 Host line byte 3 configuration register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000ffff constant CSI_CSI_LB3CFGR_BYTECNT                          \ Byte counter
$ffff0000 constant CSI_CSI_LB3CFGR_LINECNT                          \ Line counter


\
\ @brief CSI-2 Host timer 0 configuration register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$01ffffff constant CSI_CSI_TIM0CFGR_COUNT                           \ Clock cycle counter


\
\ @brief CSI-2 Host timer 1 configuration register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$01ffffff constant CSI_CSI_TIM1CFGR_COUNT                           \ Clock cycle counter


\
\ @brief CSI-2 Host timer 2 configuration register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$01ffffff constant CSI_CSI_TIM2CFGR_COUNT                           \ Clock cycle counter


\
\ @brief CSI-2 Host timer 3 configuration register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$01ffffff constant CSI_CSI_TIM3CFGR_COUNT                           \ Clock cycle counter


\
\ @brief CSI-2 Host lane merger configuration register
\ Address offset: 0x70
\ Reset value: 0x43210200
\

$00000700 constant CSI_CSI_LMCFGR_LANENB                            \ Number of lanes
$00070000 constant CSI_CSI_LMCFGR_DL0MAP                            \ Physical mapping of logical data lane 0
$00700000 constant CSI_CSI_LMCFGR_DL1MAP                            \ Physical mapping of logical data lane 1


\
\ @brief CSI-2 Host program interrupt register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000003 constant CSI_CSI_PRGITR_LB0VC                             \ Line/byte counter 0 linked to a virtual channel
$00000008 constant CSI_CSI_PRGITR_LB0EN                             \ Line/byte 0 counter enable
$00000030 constant CSI_CSI_PRGITR_LB1VC                             \ Line/byte counter 1 linked to a virtual channel
$00000080 constant CSI_CSI_PRGITR_LB1EN                             \ Line/byte 1 counter enable
$00000300 constant CSI_CSI_PRGITR_LB2VC                             \ Line/byte counter 2 linked to a virtual channel
$00000800 constant CSI_CSI_PRGITR_LB2EN                             \ Line/byte 2 counter enable
$00003000 constant CSI_CSI_PRGITR_LB3VC                             \ Line/byte counter 3 linked to a virtual channel
$00008000 constant CSI_CSI_PRGITR_LB3EN                             \ Line/byte 3 counter enable
$00030000 constant CSI_CSI_PRGITR_TIM0VC                            \ TIM0 base time linked to a virtual channel
$00040000 constant CSI_CSI_PRGITR_TIM0EOF                           \ TIM0 base time starting from the EOF
$00080000 constant CSI_CSI_PRGITR_TIM0EN                            \ TIM0 base time enable
$00300000 constant CSI_CSI_PRGITR_TIM1VC                            \ TIM1 base time linked to a virtual channel
$00400000 constant CSI_CSI_PRGITR_TIM1EOF                           \ TIM1 base time starting from the EOF
$00800000 constant CSI_CSI_PRGITR_TIM1EN                            \ TIM1 base time enable
$03000000 constant CSI_CSI_PRGITR_TIM2VC                            \ TIM2 base time linked to a virtual channel
$04000000 constant CSI_CSI_PRGITR_TIM2EOF                           \ TIM2 base time starting from the EOF
$08000000 constant CSI_CSI_PRGITR_TIM2EN                            \ TIM2 base time enable
$30000000 constant CSI_CSI_PRGITR_TIM3VC                            \ TIM3 base time linked to a virtual channel
$40000000 constant CSI_CSI_PRGITR_TIM3EOF                           \ TIM3 base time starting from the EOF
$80000000 constant CSI_CSI_PRGITR_TIM3EN                            \ TIM3 base time enable


\
\ @brief CSI-2 Host watchdog register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant CSI_CSI_WDR_CNT                                  \ Watchdog counter


\
\ @brief CSI-2 Host interrupt enable register 0
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant CSI_CSI_IER0_LB0IE                               \ Line/byte counter 0 interrupt enable
$00000002 constant CSI_CSI_IER0_LB1IE                               \ Line/byte counter 1 interrupt enable
$00000004 constant CSI_CSI_IER0_LB2IE                               \ Line/byte counter 2 interrupt enable
$00000008 constant CSI_CSI_IER0_LB3IE                               \ Line/byte counter 3 interrupt enable
$00000010 constant CSI_CSI_IER0_TIM0IE                              \ Timer 0 interrupt enable
$00000020 constant CSI_CSI_IER0_TIM1IE                              \ Timer 1 interrupt enable
$00000040 constant CSI_CSI_IER0_TIM2IE                              \ Timer 2 interrupt enable
$00000080 constant CSI_CSI_IER0_TIM3IE                              \ Timer 3 interrupt enable
$00000100 constant CSI_CSI_IER0_SOF0IE                              \ SOF for virtual channel 0 interrupt enable
$00000200 constant CSI_CSI_IER0_SOF1IE                              \ SOF for virtual channel 1 interrupt enable
$00000400 constant CSI_CSI_IER0_SOF2IE                              \ SOF for virtual channel 2 interrupt enable
$00000800 constant CSI_CSI_IER0_SOF3IE                              \ SOF for virtual channel 3 interrupt enable
$00001000 constant CSI_CSI_IER0_EOF0IE                              \ EOF for virtual channel 0 interrupt enable
$00002000 constant CSI_CSI_IER0_EOF1IE                              \ EOF for virtual channel 1 interrupt enable
$00004000 constant CSI_CSI_IER0_EOF2IE                              \ EOF for virtual channel 2 interrupt enable
$00008000 constant CSI_CSI_IER0_EOF3IE                              \ EOF for virtual channel 3 interrupt enable
$00010000 constant CSI_CSI_IER0_SPKTIE                              \ Short packet interrupt enable
$00200000 constant CSI_CSI_IER0_CCFIFOFIE                           \ Clock changer FIFO full interrupt enable
$01000000 constant CSI_CSI_IER0_CRCERRIE                            \ CRC error interrupt enable
$02000000 constant CSI_CSI_IER0_ECCERRIE                            \ ECC error interrupt enable
$04000000 constant CSI_CSI_IER0_CECCERRIE                           \ Corrected ECC error interrupt enable
$08000000 constant CSI_CSI_IER0_IDERRIE                             \ Data type ID error interrupt enable
$10000000 constant CSI_CSI_IER0_SPKTERRIE                           \ Short packet error interrupt enable
$20000000 constant CSI_CSI_IER0_WDERRIE                             \ Watchdog error interrupt enable
$40000000 constant CSI_CSI_IER0_SYNCERRIE                           \ Invalid synchronization error interrupt enable


\
\ @brief CSI-2 Host interrupt enable register 1
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant CSI_CSI_IER1_ESOTDL0IE                           \ SOT error interrupt enable on lane 0
$00000002 constant CSI_CSI_IER1_ESOTSYNCDL0IE                       \ SOT synchronization interrupt error enable on lane 0
$00000004 constant CSI_CSI_IER1_EESCDL0IE                           \ D-PHY_RX lane 0 escape entry error interrupt enable
$00000008 constant CSI_CSI_IER1_ESYNCESCDL0IE                       \ D-PHY_RX lane 0 low power data transmission synchronization error interrupt enable
$00000010 constant CSI_CSI_IER1_ECTRLDL0IE                          \ D-PHY_RX lane 0 control error interrupt enable
$00000100 constant CSI_CSI_IER1_ESOTDL1IE                           \ SOT error interrupt enable on lane 1
$00000200 constant CSI_CSI_IER1_ESOTSYNCDL1IE                       \ SOT synchronization interrupt error enable on lane 1
$00000400 constant CSI_CSI_IER1_EESCDL1IE                           \ D-PHY_RX lane 1 escape entry error interrupt enable
$00000800 constant CSI_CSI_IER1_ESYNCESCDL1IE                       \ D-PHY_RX lane 1 low-power data transmission synchronization error interrupt enable
$00001000 constant CSI_CSI_IER1_ECTRLDL1IE                          \ D-PHY_RX lane 1 control error interrupt enable


\
\ @brief CSI-2 Host status register 0
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant CSI_CSI_SR0_LB0F                                 \ Line/byte counter 0 flag
$00000002 constant CSI_CSI_SR0_LB1F                                 \ Line/byte counter 1 flag
$00000004 constant CSI_CSI_SR0_LB2F                                 \ Line/byte counter 2 flag
$00000008 constant CSI_CSI_SR0_LB3F                                 \ Line/byte counter 3 flag
$00000010 constant CSI_CSI_SR0_TIM0F                                \ Timer 0 flag
$00000020 constant CSI_CSI_SR0_TIM1F                                \ Timer 1 flag
$00000040 constant CSI_CSI_SR0_TIM2F                                \ Timer 2 flag
$00000080 constant CSI_CSI_SR0_TIM3F                                \ Timer 3 flag
$00000100 constant CSI_CSI_SR0_SOF0F                                \ SOF flag for virtual channel 0
$00000200 constant CSI_CSI_SR0_SOF1F                                \ SOF flag for virtual channel 1
$00000400 constant CSI_CSI_SR0_SOF2F                                \ SOF flag for virtual channel 2
$00000800 constant CSI_CSI_SR0_SOF3F                                \ SOF flag for virtual channel 3
$00001000 constant CSI_CSI_SR0_EOF0F                                \ EOF flag for virtual channel 0
$00002000 constant CSI_CSI_SR0_EOF1F                                \ EOF flag for virtual channel 1
$00004000 constant CSI_CSI_SR0_EOF2F                                \ EOF flag for virtual channel 2
$00008000 constant CSI_CSI_SR0_EOF3F                                \ EOF flag for virtual channel 3
$00010000 constant CSI_CSI_SR0_SPKTF                                \ Short packet flag
$00020000 constant CSI_CSI_SR0_VC0STATEF                            \ Virtual channel 0 state flag
$00040000 constant CSI_CSI_SR0_VC1STATEF                            \ Virtual channel 1 state flag
$00080000 constant CSI_CSI_SR0_VC2STATEF                            \ Virtual channel 2 state flag
$00100000 constant CSI_CSI_SR0_VC3STATEF                            \ Virtual channel 3 state flag
$00200000 constant CSI_CSI_SR0_CCFIFOFF                             \ Clock changer FIFO full flag
$01000000 constant CSI_CSI_SR0_CRCERRF                              \ CRC error flag
$02000000 constant CSI_CSI_SR0_ECCERRF                              \ ECC error flag
$04000000 constant CSI_CSI_SR0_CECCERRF                             \ Corrected ECC error flag
$08000000 constant CSI_CSI_SR0_IDERRF                               \ Data type ID error flag
$10000000 constant CSI_CSI_SR0_SPKTERRF                             \ Short packet error flag
$20000000 constant CSI_CSI_SR0_WDERRF                               \ Watchdog error flag
$40000000 constant CSI_CSI_SR0_SYNCERRF                             \ Invalid synchronization error flag


\
\ @brief CSI-2 Host status register 1
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant CSI_CSI_SR1_ESOTDL0F                             \ SOT error flag on lane 0
$00000002 constant CSI_CSI_SR1_ESOTSYNCDL0F                         \ SOT synchronization error flag on lane 0
$00000004 constant CSI_CSI_SR1_EESCDL0F                             \ D-PHY_RX lane 0 escape entry error flag
$00000008 constant CSI_CSI_SR1_ESYNCESCDL0F                         \ D-PHY_RX lane 0 low-power data transmission synchronization error flag
$00000010 constant CSI_CSI_SR1_ECTRLDL0F                            \ D-PHY_RX lane 0 control error flag
$00000100 constant CSI_CSI_SR1_ESOTDL1F                             \ SOT error flag on lane 1
$00000200 constant CSI_CSI_SR1_ESOTSYNCDL1F                         \ SOT synchronization error flag on lane 1
$00000400 constant CSI_CSI_SR1_EESCDL1F                             \ D-PHY_RX lane 1 escape entry error flag
$00000800 constant CSI_CSI_SR1_ESYNCESCDL1F                         \ D-PHY_RX lane 1 low-power data transmission synchronization error flag
$00001000 constant CSI_CSI_SR1_ECTRLDL1F                            \ D-PHY_RX lane 1 control error flag
$00010000 constant CSI_CSI_SR1_ACTDL0F                              \ D-PHY_RX lane 0 high-speed reception active
$00020000 constant CSI_CSI_SR1_SYNCDL0F                             \ D-PHY_RX lane 0 receiver synchronization observed
$00040000 constant CSI_CSI_SR1_SKCALDL0F                            \ D-PHY_RX lane 0 high-speed skew calibration
$00080000 constant CSI_CSI_SR1_STOPDL0F                             \ D-PHY_RX receiver data lane 0 in stop state
$00100000 constant CSI_CSI_SR1_ULPNDL0F                             \ D-PHY_RX receiver ultra-low-power state (not) active on data lane 0
$00400000 constant CSI_CSI_SR1_ACTDL1F                              \ D-PHY_RX lane 1 high-speed reception active
$00800000 constant CSI_CSI_SR1_SYNCDL1F                             \ D-PHY_RX lane 1 receiver synchronization observed
$01000000 constant CSI_CSI_SR1_SKCALDL1F                            \ D-PHY_RX lane 1 high-speed skew calibration
$02000000 constant CSI_CSI_SR1_STOPDL1F                             \ D-PHY_RX receiver data lane 1 in stop state
$04000000 constant CSI_CSI_SR1_ULPNDL1F                             \ D-PHY_RX receiver ultra-low-power state (not) active on data lane 1
$10000000 constant CSI_CSI_SR1_STOPCLF                              \ D-PHY_RX receiver in stop state for the clock lane
$20000000 constant CSI_CSI_SR1_ULPNACTF                             \ D-PHY_RX receiver ULP state (not) active
$40000000 constant CSI_CSI_SR1_ULPNCLF                              \ D-PHY_RX receiver Ultra-Low power state (not) on clock lane.
$80000000 constant CSI_CSI_SR1_ACTCLF                               \ D-PHY_RX receiver clock active flag


\
\ @brief CSI-2 Host flag clear register 0
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant CSI_CSI_FCR0_CLB0F                               \ Clear line/byte counter 0 flag
$00000002 constant CSI_CSI_FCR0_CLB1F                               \ Clear line/byte counter 1 flag
$00000004 constant CSI_CSI_FCR0_CLB2F                               \ Clear line/byte counter 2 flag
$00000008 constant CSI_CSI_FCR0_CLB3F                               \ Clear line/byte counter 3 flag
$00000010 constant CSI_CSI_FCR0_CTIM0F                              \ Clear timer 0 flag
$00000020 constant CSI_CSI_FCR0_CTIM1F                              \ Clear timer 1 flag
$00000040 constant CSI_CSI_FCR0_CTIM2F                              \ Clear timer 2 flag
$00000080 constant CSI_CSI_FCR0_CTIM3F                              \ Clear timer 3 flag
$00000100 constant CSI_CSI_FCR0_CSOF0F                              \ Clear SOF flag for virtual channel 0
$00000200 constant CSI_CSI_FCR0_CSOF1F                              \ Clear SOF flag for virtual channel 1
$00000400 constant CSI_CSI_FCR0_CSOF2F                              \ Clear SOF flag for virtual channel 2
$00000800 constant CSI_CSI_FCR0_CSOF3F                              \ Clear SOF flag for virtual channel 3
$00001000 constant CSI_CSI_FCR0_CEOF0F                              \ Clear EOF flag for virtual channel 0
$00002000 constant CSI_CSI_FCR0_CEOF1F                              \ Clear EOF flag for virtual channel 1
$00004000 constant CSI_CSI_FCR0_CEOF2F                              \ Clear EOF flag for virtual channel 2
$00008000 constant CSI_CSI_FCR0_CEOF3F                              \ Clear EOF flag for virtual channel 3
$00010000 constant CSI_CSI_FCR0_CSPKTF                              \ Clear short packet flag
$00200000 constant CSI_CSI_FCR0_CCCFIFOFF                           \ Clear clock changer FIFO full flag
$01000000 constant CSI_CSI_FCR0_CCRCERRF                            \ Clear CRC error flag
$02000000 constant CSI_CSI_FCR0_CECCERRF                            \ Clear ECC error flag
$04000000 constant CSI_CSI_FCR0_CCECCERRF                           \ Clear corrected ECC error flag
$08000000 constant CSI_CSI_FCR0_CIDERRF                             \ Clear data type ID error flag
$10000000 constant CSI_CSI_FCR0_CSPKTERRF                           \ Clear short packet error flag
$20000000 constant CSI_CSI_FCR0_CWDERRF                             \ Clear watchdog error flag
$40000000 constant CSI_CSI_FCR0_CSYNCERRF                           \ Clear invalid synchronization error flag


\
\ @brief CSI-2 Host flag clear register 1
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant CSI_CSI_FCR1_CESOTDL0F                           \ Clear SOT error flag on lane 0
$00000002 constant CSI_CSI_FCR1_CESOTSYNCDL0F                       \ Clear SOT synchronization error flag on lane 0
$00000004 constant CSI_CSI_FCR1_CEESCDL0F                           \ Clear D-PHY_RX lane 0 escape entry error flag
$00000008 constant CSI_CSI_FCR1_CESYNCESCDL0F                       \ Clear D-PHY_RX lane 0 low-power data transmission synchronization error flag
$00000010 constant CSI_CSI_FCR1_CECTRLDL0F                          \ Clear D-PHY_RX lane 0 control error flag
$00000100 constant CSI_CSI_FCR1_CESOTDL1F                           \ Clear SOT error flag on lane 1
$00000200 constant CSI_CSI_FCR1_CESOTSYNCDL1F                       \ Clear SOT synchronization error flag on lane 1
$00000400 constant CSI_CSI_FCR1_CEESCDL1F                           \ Clear D-PHY_RX lane 1 escape entry error flag
$00000800 constant CSI_CSI_FCR1_CESYNCESCDL1F                       \ Clear D-PHY_RX lane 1 low-power data transmission synchronization error flag
$00001000 constant CSI_CSI_FCR1_CECTRLDL1F                          \ Clear D-PHY_RX lane 1 control error flag


\
\ @brief CSI-2 Host short packet data field register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$0000ffff constant CSI_CSI_SPDFR_DATAFIELD                          \ Data field
$003f0000 constant CSI_CSI_SPDFR_DATATYPE                           \ Data type class
$00c00000 constant CSI_CSI_SPDFR_VCHANNEL                           \ Virtual channel


\
\ @brief CSI-2 Host error register 1
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$0000003f constant CSI_CSI_ERR1_CRCDTERR                            \ Data type having a CRC error
$000000c0 constant CSI_CSI_ERR1_CRCVCERR                            \ Virtual channel having a CRC error
$00003f00 constant CSI_CSI_ERR1_CECCDTERR                           \ Data type having a corrected ECC error
$0000c000 constant CSI_CSI_ERR1_CECCVCERR                           \ Virtual channel having a corrected ECC error
$003f0000 constant CSI_CSI_ERR1_IDDTERR                             \ Data type in error
$00c00000 constant CSI_CSI_ERR1_IDVCERR                             \ Virtual channel having ID error


\
\ @brief CSI-2 Host error register 2
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$0000003f constant CSI_CSI_ERR2_SPKTDTERR                           \ Data type having a short packet error
$000000c0 constant CSI_CSI_ERR2_SPKTVCERR                           \ Virtual channel having a short packet error
$00030000 constant CSI_CSI_ERR2_WDVCERR                             \ Virtual channel having a watchdog error
$000c0000 constant CSI_CSI_ERR2_SYNCVCERR                           \ Virtual channel having synchronization error


\
\ @brief CSI PHY reset control register
\ Address offset: 0x1000
\ Reset value: 0x00000000
\

$00000002 constant CSI_CSI_PRCR_PEN                                 \ When set to 0, this bit places the digital section of the D-PHY in the reset state.


\
\ @brief CSI PHY mode control register
\ Address offset: 0x1004
\ Reset value: 0x00011003
\

$00000001 constant CSI_CSI_PMCR_FRXMDL0                             \ Force to Rx mode the data lane 0
$00000002 constant CSI_CSI_PMCR_FRXMDL1                             \ Force to Rx mode the data lane 1
$00000004 constant CSI_CSI_PMCR_FTXSMDL0                            \ Force to Tx Stop mode the data lane 0
$00000010 constant CSI_CSI_PMCR_DTDL                                \ Disable turn-around data lane 0
$00000100 constant CSI_CSI_PMCR_RTDL0                               \ Turn-around request data lane 0
$00001000 constant CSI_CSI_PMCR_TUESDL0                             \ Tx ULP escape-mode data lane 0
$00010000 constant CSI_CSI_PMCR_TUEXDL0                             \ Tx ULP exit sequence data lane 0


\
\ @brief CSI PHY frequency control register
\ Address offset: 0x1008
\ Reset value: 0x00000017
\

$0000003f constant CSI_CSI_PFCR_CCFR                                \ Configuration clock frequency range selection
$00007f00 constant CSI_CSI_PFCR_HSFR                                \ PHY high-speed frequency range selection
$00010000 constant CSI_CSI_PFCR_DLD                                 \ Data lane direction of lane 0


\
\ @brief CSI PHY test control register 0
\ Address offset: 0x1010
\ Reset value: 0x00000001
\

$00000001 constant CSI_CSI_PTCR0_TCKEN                              \ Test-interface clock enable for the TDI bus into the PHY
$00000002 constant CSI_CSI_PTCR0_TRSEN                              \ Test-interface reset enable for the TDI bus into the PHY


\
\ @brief CSI PHY test control register 1
\ Address offset: 0x1014
\ Reset value: 0x00000000
\

$000000ff constant CSI_CSI_PTCR1_TDI                                \ Test-interface data in
$00010000 constant CSI_CSI_PTCR1_TWM                                \ Test-interface write mode selector


\
\ @brief CSI PHY test status register
\ Address offset: 0x1018
\ Reset value: 0x00000000
\

$000000ff constant CSI_CSI_PTSR_TDO                                 \ CSI PHY test interface data output bus for read-back and internal probing functionalities


\
\ @brief CSI-2 Host
\
$48006000 constant CSI_CSI_CR     \ offset: 0x00 : CSI-2 Host control register
$48006004 constant CSI_CSI_PCR    \ offset: 0x04 : CSI-2 Host DPHY_RX control register
$48006010 constant CSI_CSI_VC0CFGR1  \ offset: 0x10 : CSI-2 Host virtual channel 0 configuration register 1
$48006014 constant CSI_CSI_VC0CFGR2  \ offset: 0x14 : CSI-2 Host virtual channel 0 configuration register 2
$48006018 constant CSI_CSI_VC0CFGR3  \ offset: 0x18 : CSI-2 Host virtual channel 0 configuration register 3
$4800601c constant CSI_CSI_VC0CFGR4  \ offset: 0x1C : CSI-2 Host virtual channel 0 configuration register 4
$48006020 constant CSI_CSI_VC1CFGR1  \ offset: 0x20 : CSI-2 Host virtual channel 1 configuration register 1
$48006024 constant CSI_CSI_VC1CFGR2  \ offset: 0x24 : CSI-2 Host virtual channel 1 configuration register 2
$48006028 constant CSI_CSI_VC1CFGR3  \ offset: 0x28 : CSI-2 Host virtual channel 1 configuration register 3
$4800602c constant CSI_CSI_VC1CFGR4  \ offset: 0x2C : CSI-2 Host virtual channel 1 configuration register 4
$48006030 constant CSI_CSI_VC2CFGR1  \ offset: 0x30 : CSI-2 Host virtual channel 2 configuration register 1
$48006034 constant CSI_CSI_VC2CFGR2  \ offset: 0x34 : CSI-2 Host virtual channel 2 configuration register 2
$48006038 constant CSI_CSI_VC2CFGR3  \ offset: 0x38 : CSI-2 Host virtual channel 2 configuration register 3
$4800603c constant CSI_CSI_VC2CFGR4  \ offset: 0x3C : CSI-2 Host virtual channel 2 configuration register 4
$48006040 constant CSI_CSI_VC3CFGR1  \ offset: 0x40 : CSI-2 Host virtual channel 3 configuration register 1
$48006044 constant CSI_CSI_VC3CFGR2  \ offset: 0x44 : CSI-2 Host virtual channel 3 configuration register 2
$48006048 constant CSI_CSI_VC3CFGR3  \ offset: 0x48 : CSI-2 Host virtual channel 3 configuration register 3
$4800604c constant CSI_CSI_VC3CFGR4  \ offset: 0x4C : CSI-2 Host virtual channel 3 configuration register 4
$48006050 constant CSI_CSI_LB0CFGR  \ offset: 0x50 : CSI-2 Host line byte 0 configuration register
$48006054 constant CSI_CSI_LB1CFGR  \ offset: 0x54 : CSI-2 Host line byte 1 configuration register
$48006058 constant CSI_CSI_LB2CFGR  \ offset: 0x58 : CSI-2 Host line byte 2 configuration register
$4800605c constant CSI_CSI_LB3CFGR  \ offset: 0x5C : CSI-2 Host line byte 3 configuration register
$48006060 constant CSI_CSI_TIM0CFGR  \ offset: 0x60 : CSI-2 Host timer 0 configuration register
$48006064 constant CSI_CSI_TIM1CFGR  \ offset: 0x64 : CSI-2 Host timer 1 configuration register
$48006068 constant CSI_CSI_TIM2CFGR  \ offset: 0x68 : CSI-2 Host timer 2 configuration register
$4800606c constant CSI_CSI_TIM3CFGR  \ offset: 0x6C : CSI-2 Host timer 3 configuration register
$48006070 constant CSI_CSI_LMCFGR  \ offset: 0x70 : CSI-2 Host lane merger configuration register
$48006074 constant CSI_CSI_PRGITR  \ offset: 0x74 : CSI-2 Host program interrupt register
$48006078 constant CSI_CSI_WDR    \ offset: 0x78 : CSI-2 Host watchdog register
$48006080 constant CSI_CSI_IER0   \ offset: 0x80 : CSI-2 Host interrupt enable register 0
$48006084 constant CSI_CSI_IER1   \ offset: 0x84 : CSI-2 Host interrupt enable register 1
$48006090 constant CSI_CSI_SR0    \ offset: 0x90 : CSI-2 Host status register 0
$48006094 constant CSI_CSI_SR1    \ offset: 0x94 : CSI-2 Host status register 1
$48006100 constant CSI_CSI_FCR0   \ offset: 0x100 : CSI-2 Host flag clear register 0
$48006104 constant CSI_CSI_FCR1   \ offset: 0x104 : CSI-2 Host flag clear register 1
$48006110 constant CSI_CSI_SPDFR  \ offset: 0x110 : CSI-2 Host short packet data field register
$48006114 constant CSI_CSI_ERR1   \ offset: 0x114 : CSI-2 Host error register 1
$48006118 constant CSI_CSI_ERR2   \ offset: 0x118 : CSI-2 Host error register 2
$48007000 constant CSI_CSI_PRCR   \ offset: 0x1000 : CSI PHY reset control register
$48007004 constant CSI_CSI_PMCR   \ offset: 0x1004 : CSI PHY mode control register
$48007008 constant CSI_CSI_PFCR   \ offset: 0x1008 : CSI PHY frequency control register
$48007010 constant CSI_CSI_PTCR0  \ offset: 0x1010 : CSI PHY test control register 0
$48007014 constant CSI_CSI_PTCR1  \ offset: 0x1014 : CSI PHY test control register 1
$48007018 constant CSI_CSI_PTSR   \ offset: 0x1018 : CSI PHY test status register

