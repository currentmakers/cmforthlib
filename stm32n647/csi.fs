\
\ @file csi.fs
\ @brief CSI-2 Host
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] CSI_DEF

  [ifdef] CSI_CSI_CR_DEF
    \
    \ @brief CSI-2 Host control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant CSI_CSIEN                      \ [0x00] CSI-2 enable
    $02 constant CSI_VC0START                   \ [0x02] Virtual channel 0 start
    $03 constant CSI_VC0STOP                    \ [0x03] Virtual channel 0 stop
    $06 constant CSI_VC1START                   \ [0x06] Virtual channel 1 start
    $07 constant CSI_VC1STOP                    \ [0x07] Virtual channel 1 stop
    $0a constant CSI_VC2START                   \ [0x0a] Virtual channel 2 start
    $0b constant CSI_VC2STOP                    \ [0x0b] Virtual channel 2 stop
    $0e constant CSI_VC3START                   \ [0x0e] Virtual channel 3 start
    $0f constant CSI_VC3STOP                    \ [0x0f] Virtual channel 3 stop
  [then]


  [ifdef] CSI_CSI_PCR_DEF
    \
    \ @brief CSI-2 Host DPHY_RX control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant CSI_PWRDOWN                    \ [0x00] Power down
    $01 constant CSI_CLEN                       \ [0x01] Clock lane enable
    $02 constant CSI_DL0EN                      \ [0x02] D-PHY_RX data lane 0 enable
    $03 constant CSI_DL1EN                      \ [0x03] D-PHY_RX data lane 1 enable
  [then]


  [ifdef] CSI_CSI_VC0CFGR1_DEF
    \
    \ @brief CSI-2 Host virtual channel 0 configuration register 1
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant CSI_ALLDT                      \ [0x00] All data types enable for the virtual channel x
    $01 constant CSI_DT0EN                      \ [0x01] Data type 0 enable
    $02 constant CSI_DT1EN                      \ [0x02] Data type 1 enable
    $03 constant CSI_DT2EN                      \ [0x03] Data type 2 enable
    $04 constant CSI_DT3EN                      \ [0x04] Data type 3 enable
    $05 constant CSI_DT4EN                      \ [0x05] Data type 4 enable
    $06 constant CSI_DT5EN                      \ [0x06] Data type 5 enable
    $07 constant CSI_DT6EN                      \ [0x07] Data type 6 enable
    $08 constant CSI_CDTFT                      \ [0x08 : 5] Common format for all data types
    $10 constant CSI_DT0                        \ [0x10 : 6] Data type 0 class selection for virtual channel x
    $18 constant CSI_DT0FT                      \ [0x18 : 5] Data type 0 format
  [then]


  [ifdef] CSI_CSI_VC0CFGR2_DEF
    \
    \ @brief CSI-2 Host virtual channel 0 configuration register 2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant CSI_DT1                        \ [0x00 : 6] Data type 1 class selection for virtual channel x
    $08 constant CSI_DT1FT                      \ [0x08 : 5] Data type 1 format
    $10 constant CSI_DT2                        \ [0x10 : 6] Data type 2 class selection for virtual channel x
    $18 constant CSI_DT2FT                      \ [0x18 : 5] Data type 2 format
  [then]


  [ifdef] CSI_CSI_VC0CFGR3_DEF
    \
    \ @brief CSI-2 Host virtual channel 0 configuration register 3
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant CSI_DT3                        \ [0x00 : 6] Data type 3 class selection for virtual channel x
    $08 constant CSI_DT3FT                      \ [0x08 : 5] Data type 3 format
    $10 constant CSI_DT4                        \ [0x10 : 6] Data type 4 class selection for virtual channel x
    $18 constant CSI_DT4FT                      \ [0x18 : 5] Data type 4 format
  [then]


  [ifdef] CSI_CSI_VC0CFGR4_DEF
    \
    \ @brief CSI-2 Host virtual channel 0 configuration register 4
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant CSI_DT5                        \ [0x00 : 6] Data type 5 class selection for virtual channel x
    $08 constant CSI_DT5FT                      \ [0x08 : 5] Data type 5 format
    $10 constant CSI_DT6                        \ [0x10 : 6] Data type 6 class selection for virtual channel x
    $18 constant CSI_DT6FT                      \ [0x18 : 5] Data type 6 format
  [then]


  [ifdef] CSI_CSI_VC1CFGR1_DEF
    \
    \ @brief CSI-2 Host virtual channel 1 configuration register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant CSI_ALLDT                      \ [0x00] All data types enable for the virtual channel x
    $01 constant CSI_DT0EN                      \ [0x01] Data type 0 enable
    $02 constant CSI_DT1EN                      \ [0x02] Data type 1 enable
    $03 constant CSI_DT2EN                      \ [0x03] Data type 2 enable
    $04 constant CSI_DT3EN                      \ [0x04] Data type 3 enable
    $05 constant CSI_DT4EN                      \ [0x05] Data type 4 enable
    $06 constant CSI_DT5EN                      \ [0x06] Data type 5 enable
    $07 constant CSI_DT6EN                      \ [0x07] Data type 6 enable
    $08 constant CSI_CDTFT                      \ [0x08 : 5] Common format for all data types
    $10 constant CSI_DT0                        \ [0x10 : 6] Data type 0 class selection for virtual channel x
    $18 constant CSI_DT0FT                      \ [0x18 : 5] Data type 0 format
  [then]


  [ifdef] CSI_CSI_VC1CFGR2_DEF
    \
    \ @brief CSI-2 Host virtual channel 1 configuration register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant CSI_DT1                        \ [0x00 : 6] Data type 1 class selection for virtual channel x
    $08 constant CSI_DT1FT                      \ [0x08 : 5] Data type 1 format
    $10 constant CSI_DT2                        \ [0x10 : 6] Data type 2 class selection for virtual channel x
    $18 constant CSI_DT2FT                      \ [0x18 : 5] Data type 2 format
  [then]


  [ifdef] CSI_CSI_VC1CFGR3_DEF
    \
    \ @brief CSI-2 Host virtual channel 1 configuration register 3
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant CSI_DT3                        \ [0x00 : 6] Data type 3 class selection for virtual channel x
    $08 constant CSI_DT3FT                      \ [0x08 : 5] Data type 3 format
    $10 constant CSI_DT4                        \ [0x10 : 6] Data type 4 class selection for virtual channel x
    $18 constant CSI_DT4FT                      \ [0x18 : 5] Data type 4 format
  [then]


  [ifdef] CSI_CSI_VC1CFGR4_DEF
    \
    \ @brief CSI-2 Host virtual channel 1 configuration register 4
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant CSI_DT5                        \ [0x00 : 6] Data type 5 class selection for virtual channel x
    $08 constant CSI_DT5FT                      \ [0x08 : 5] Data type 5 format
    $10 constant CSI_DT6                        \ [0x10 : 6] Data type 6 class selection for virtual channel x
    $18 constant CSI_DT6FT                      \ [0x18 : 5] Data type 6 format
  [then]


  [ifdef] CSI_CSI_VC2CFGR1_DEF
    \
    \ @brief CSI-2 Host virtual channel 2 configuration register 1
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant CSI_ALLDT                      \ [0x00] All data types enable for the virtual channel x
    $01 constant CSI_DT0EN                      \ [0x01] Data type 0 enable
    $02 constant CSI_DT1EN                      \ [0x02] Data type 1 enable
    $03 constant CSI_DT2EN                      \ [0x03] Data type 2 enable
    $04 constant CSI_DT3EN                      \ [0x04] Data type 3 enable
    $05 constant CSI_DT4EN                      \ [0x05] Data type 4 enable
    $06 constant CSI_DT5EN                      \ [0x06] Data type 5 enable
    $07 constant CSI_DT6EN                      \ [0x07] Data type 6 enable
    $08 constant CSI_CDTFT                      \ [0x08 : 5] Common format for all data types
    $10 constant CSI_DT0                        \ [0x10 : 6] Data type 0 class selection for virtual channel x
    $18 constant CSI_DT0FT                      \ [0x18 : 5] Data type 0 format
  [then]


  [ifdef] CSI_CSI_VC2CFGR2_DEF
    \
    \ @brief CSI-2 Host virtual channel 2 configuration register 2
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant CSI_DT1                        \ [0x00 : 6] Data type 1 class selection for virtual channel x
    $08 constant CSI_DT1FT                      \ [0x08 : 5] Data type 1 format
    $10 constant CSI_DT2                        \ [0x10 : 6] Data type 2 class selection for virtual channel x
    $18 constant CSI_DT2FT                      \ [0x18 : 5] Data type 2 format
  [then]


  [ifdef] CSI_CSI_VC2CFGR3_DEF
    \
    \ @brief CSI-2 Host virtual channel 2 configuration register 3
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant CSI_DT3                        \ [0x00 : 6] Data type 3 class selection for virtual channel x
    $08 constant CSI_DT3FT                      \ [0x08 : 5] Data type 3 format
    $10 constant CSI_DT4                        \ [0x10 : 6] Data type 4 class selection for virtual channel x
    $18 constant CSI_DT4FT                      \ [0x18 : 5] Data type 4 format
  [then]


  [ifdef] CSI_CSI_VC2CFGR4_DEF
    \
    \ @brief CSI-2 Host virtual channel 2 configuration register 4
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant CSI_DT5                        \ [0x00 : 6] Data type 5 class selection for virtual channel x
    $08 constant CSI_DT5FT                      \ [0x08 : 5] Data type 5 format
    $10 constant CSI_DT6                        \ [0x10 : 6] Data type 6 class selection for virtual channel x
    $18 constant CSI_DT6FT                      \ [0x18 : 5] Data type 6 format
  [then]


  [ifdef] CSI_CSI_VC3CFGR1_DEF
    \
    \ @brief CSI-2 Host virtual channel 3 configuration register 1
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant CSI_ALLDT                      \ [0x00] All data types enable for the virtual channel x
    $01 constant CSI_DT0EN                      \ [0x01] Data type 0 enable
    $02 constant CSI_DT1EN                      \ [0x02] Data type 1 enable
    $03 constant CSI_DT2EN                      \ [0x03] Data type 2 enable
    $04 constant CSI_DT3EN                      \ [0x04] Data type 3 enable
    $05 constant CSI_DT4EN                      \ [0x05] Data type 4 enable
    $06 constant CSI_DT5EN                      \ [0x06] Data type 5 enable
    $07 constant CSI_DT6EN                      \ [0x07] Data type 6 enable
    $08 constant CSI_CDTFT                      \ [0x08 : 5] Common format for all data types
    $10 constant CSI_DT0                        \ [0x10 : 6] Data type 0 class selection for virtual channel x
    $18 constant CSI_DT0FT                      \ [0x18 : 5] Data type 0 format
  [then]


  [ifdef] CSI_CSI_VC3CFGR2_DEF
    \
    \ @brief CSI-2 Host virtual channel 3 configuration register 2
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant CSI_DT1                        \ [0x00 : 6] Data type 1 class selection for virtual channel x
    $08 constant CSI_DT1FT                      \ [0x08 : 5] Data type 1 format
    $10 constant CSI_DT2                        \ [0x10 : 6] Data type 2 class selection for virtual channel x
    $18 constant CSI_DT2FT                      \ [0x18 : 5] Data type 2 format
  [then]


  [ifdef] CSI_CSI_VC3CFGR3_DEF
    \
    \ @brief CSI-2 Host virtual channel 3 configuration register 3
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant CSI_DT3                        \ [0x00 : 6] Data type 3 class selection for virtual channel x
    $08 constant CSI_DT3FT                      \ [0x08 : 5] Data type 3 format
    $10 constant CSI_DT4                        \ [0x10 : 6] Data type 4 class selection for virtual channel x
    $18 constant CSI_DT4FT                      \ [0x18 : 5] Data type 4 format
  [then]


  [ifdef] CSI_CSI_VC3CFGR4_DEF
    \
    \ @brief CSI-2 Host virtual channel 3 configuration register 4
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant CSI_DT5                        \ [0x00 : 6] Data type 5 class selection for virtual channel x
    $08 constant CSI_DT5FT                      \ [0x08 : 5] Data type 5 format
    $10 constant CSI_DT6                        \ [0x10 : 6] Data type 6 class selection for virtual channel x
    $18 constant CSI_DT6FT                      \ [0x18 : 5] Data type 6 format
  [then]


  [ifdef] CSI_CSI_LB0CFGR_DEF
    \
    \ @brief CSI-2 Host line byte 0 configuration register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant CSI_BYTECNT                    \ [0x00 : 16] Byte counter
    $10 constant CSI_LINECNT                    \ [0x10 : 16] Line counter
  [then]


  [ifdef] CSI_CSI_LB1CFGR_DEF
    \
    \ @brief CSI-2 Host line byte 1 configuration register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant CSI_BYTECNT                    \ [0x00 : 16] Byte counter
    $10 constant CSI_LINECNT                    \ [0x10 : 16] Line counter
  [then]


  [ifdef] CSI_CSI_LB2CFGR_DEF
    \
    \ @brief CSI-2 Host line byte 2 configuration register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant CSI_BYTECNT                    \ [0x00 : 16] Byte counter
    $10 constant CSI_LINECNT                    \ [0x10 : 16] Line counter
  [then]


  [ifdef] CSI_CSI_LB3CFGR_DEF
    \
    \ @brief CSI-2 Host line byte 3 configuration register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant CSI_BYTECNT                    \ [0x00 : 16] Byte counter
    $10 constant CSI_LINECNT                    \ [0x10 : 16] Line counter
  [then]


  [ifdef] CSI_CSI_TIM0CFGR_DEF
    \
    \ @brief CSI-2 Host timer 0 configuration register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant CSI_COUNT                      \ [0x00 : 25] Clock cycle counter
  [then]


  [ifdef] CSI_CSI_TIM1CFGR_DEF
    \
    \ @brief CSI-2 Host timer 1 configuration register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant CSI_COUNT                      \ [0x00 : 25] Clock cycle counter
  [then]


  [ifdef] CSI_CSI_TIM2CFGR_DEF
    \
    \ @brief CSI-2 Host timer 2 configuration register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant CSI_COUNT                      \ [0x00 : 25] Clock cycle counter
  [then]


  [ifdef] CSI_CSI_TIM3CFGR_DEF
    \
    \ @brief CSI-2 Host timer 3 configuration register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant CSI_COUNT                      \ [0x00 : 25] Clock cycle counter
  [then]


  [ifdef] CSI_CSI_LMCFGR_DEF
    \
    \ @brief CSI-2 Host lane merger configuration register
    \ Address offset: 0x70
    \ Reset value: 0x43210200
    \
    $08 constant CSI_LANENB                     \ [0x08 : 3] Number of lanes
    $10 constant CSI_DL0MAP                     \ [0x10 : 3] Physical mapping of logical data lane 0
    $14 constant CSI_DL1MAP                     \ [0x14 : 3] Physical mapping of logical data lane 1
  [then]


  [ifdef] CSI_CSI_PRGITR_DEF
    \
    \ @brief CSI-2 Host program interrupt register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant CSI_LB0VC                      \ [0x00 : 2] Line/byte counter 0 linked to a virtual channel
    $03 constant CSI_LB0EN                      \ [0x03] Line/byte 0 counter enable
    $04 constant CSI_LB1VC                      \ [0x04 : 2] Line/byte counter 1 linked to a virtual channel
    $07 constant CSI_LB1EN                      \ [0x07] Line/byte 1 counter enable
    $08 constant CSI_LB2VC                      \ [0x08 : 2] Line/byte counter 2 linked to a virtual channel
    $0b constant CSI_LB2EN                      \ [0x0b] Line/byte 2 counter enable
    $0c constant CSI_LB3VC                      \ [0x0c : 2] Line/byte counter 3 linked to a virtual channel
    $0f constant CSI_LB3EN                      \ [0x0f] Line/byte 3 counter enable
    $10 constant CSI_TIM0VC                     \ [0x10 : 2] TIM0 base time linked to a virtual channel
    $12 constant CSI_TIM0EOF                    \ [0x12] TIM0 base time starting from the EOF
    $13 constant CSI_TIM0EN                     \ [0x13] TIM0 base time enable
    $14 constant CSI_TIM1VC                     \ [0x14 : 2] TIM1 base time linked to a virtual channel
    $16 constant CSI_TIM1EOF                    \ [0x16] TIM1 base time starting from the EOF
    $17 constant CSI_TIM1EN                     \ [0x17] TIM1 base time enable
    $18 constant CSI_TIM2VC                     \ [0x18 : 2] TIM2 base time linked to a virtual channel
    $1a constant CSI_TIM2EOF                    \ [0x1a] TIM2 base time starting from the EOF
    $1b constant CSI_TIM2EN                     \ [0x1b] TIM2 base time enable
    $1c constant CSI_TIM3VC                     \ [0x1c : 2] TIM3 base time linked to a virtual channel
    $1e constant CSI_TIM3EOF                    \ [0x1e] TIM3 base time starting from the EOF
    $1f constant CSI_TIM3EN                     \ [0x1f] TIM3 base time enable
  [then]


  [ifdef] CSI_CSI_WDR_DEF
    \
    \ @brief CSI-2 Host watchdog register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant CSI_CNT                        \ [0x00 : 32] Watchdog counter
  [then]


  [ifdef] CSI_CSI_IER0_DEF
    \
    \ @brief CSI-2 Host interrupt enable register 0
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant CSI_LB0IE                      \ [0x00] Line/byte counter 0 interrupt enable
    $01 constant CSI_LB1IE                      \ [0x01] Line/byte counter 1 interrupt enable
    $02 constant CSI_LB2IE                      \ [0x02] Line/byte counter 2 interrupt enable
    $03 constant CSI_LB3IE                      \ [0x03] Line/byte counter 3 interrupt enable
    $04 constant CSI_TIM0IE                     \ [0x04] Timer 0 interrupt enable
    $05 constant CSI_TIM1IE                     \ [0x05] Timer 1 interrupt enable
    $06 constant CSI_TIM2IE                     \ [0x06] Timer 2 interrupt enable
    $07 constant CSI_TIM3IE                     \ [0x07] Timer 3 interrupt enable
    $08 constant CSI_SOF0IE                     \ [0x08] SOF for virtual channel 0 interrupt enable
    $09 constant CSI_SOF1IE                     \ [0x09] SOF for virtual channel 1 interrupt enable
    $0a constant CSI_SOF2IE                     \ [0x0a] SOF for virtual channel 2 interrupt enable
    $0b constant CSI_SOF3IE                     \ [0x0b] SOF for virtual channel 3 interrupt enable
    $0c constant CSI_EOF0IE                     \ [0x0c] EOF for virtual channel 0 interrupt enable
    $0d constant CSI_EOF1IE                     \ [0x0d] EOF for virtual channel 1 interrupt enable
    $0e constant CSI_EOF2IE                     \ [0x0e] EOF for virtual channel 2 interrupt enable
    $0f constant CSI_EOF3IE                     \ [0x0f] EOF for virtual channel 3 interrupt enable
    $10 constant CSI_SPKTIE                     \ [0x10] Short packet interrupt enable
    $15 constant CSI_CCFIFOFIE                  \ [0x15] Clock changer FIFO full interrupt enable
    $18 constant CSI_CRCERRIE                   \ [0x18] CRC error interrupt enable
    $19 constant CSI_ECCERRIE                   \ [0x19] ECC error interrupt enable
    $1a constant CSI_CECCERRIE                  \ [0x1a] Corrected ECC error interrupt enable
    $1b constant CSI_IDERRIE                    \ [0x1b] Data type ID error interrupt enable
    $1c constant CSI_SPKTERRIE                  \ [0x1c] Short packet error interrupt enable
    $1d constant CSI_WDERRIE                    \ [0x1d] Watchdog error interrupt enable
    $1e constant CSI_SYNCERRIE                  \ [0x1e] Invalid synchronization error interrupt enable
  [then]


  [ifdef] CSI_CSI_IER1_DEF
    \
    \ @brief CSI-2 Host interrupt enable register 1
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant CSI_ESOTDL0IE                  \ [0x00] SOT error interrupt enable on lane 0
    $01 constant CSI_ESOTSYNCDL0IE              \ [0x01] SOT synchronization interrupt error enable on lane 0
    $02 constant CSI_EESCDL0IE                  \ [0x02] D-PHY_RX lane 0 escape entry error interrupt enable
    $03 constant CSI_ESYNCESCDL0IE              \ [0x03] D-PHY_RX lane 0 low power data transmission synchronization error interrupt enable
    $04 constant CSI_ECTRLDL0IE                 \ [0x04] D-PHY_RX lane 0 control error interrupt enable
    $08 constant CSI_ESOTDL1IE                  \ [0x08] SOT error interrupt enable on lane 1
    $09 constant CSI_ESOTSYNCDL1IE              \ [0x09] SOT synchronization interrupt error enable on lane 1
    $0a constant CSI_EESCDL1IE                  \ [0x0a] D-PHY_RX lane 1 escape entry error interrupt enable
    $0b constant CSI_ESYNCESCDL1IE              \ [0x0b] D-PHY_RX lane 1 low-power data transmission synchronization error interrupt enable
    $0c constant CSI_ECTRLDL1IE                 \ [0x0c] D-PHY_RX lane 1 control error interrupt enable
  [then]


  [ifdef] CSI_CSI_SR0_DEF
    \
    \ @brief CSI-2 Host status register 0
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant CSI_LB0F                       \ [0x00] Line/byte counter 0 flag
    $01 constant CSI_LB1F                       \ [0x01] Line/byte counter 1 flag
    $02 constant CSI_LB2F                       \ [0x02] Line/byte counter 2 flag
    $03 constant CSI_LB3F                       \ [0x03] Line/byte counter 3 flag
    $04 constant CSI_TIM0F                      \ [0x04] Timer 0 flag
    $05 constant CSI_TIM1F                      \ [0x05] Timer 1 flag
    $06 constant CSI_TIM2F                      \ [0x06] Timer 2 flag
    $07 constant CSI_TIM3F                      \ [0x07] Timer 3 flag
    $08 constant CSI_SOF0F                      \ [0x08] SOF flag for virtual channel 0
    $09 constant CSI_SOF1F                      \ [0x09] SOF flag for virtual channel 1
    $0a constant CSI_SOF2F                      \ [0x0a] SOF flag for virtual channel 2
    $0b constant CSI_SOF3F                      \ [0x0b] SOF flag for virtual channel 3
    $0c constant CSI_EOF0F                      \ [0x0c] EOF flag for virtual channel 0
    $0d constant CSI_EOF1F                      \ [0x0d] EOF flag for virtual channel 1
    $0e constant CSI_EOF2F                      \ [0x0e] EOF flag for virtual channel 2
    $0f constant CSI_EOF3F                      \ [0x0f] EOF flag for virtual channel 3
    $10 constant CSI_SPKTF                      \ [0x10] Short packet flag
    $11 constant CSI_VC0STATEF                  \ [0x11] Virtual channel 0 state flag
    $12 constant CSI_VC1STATEF                  \ [0x12] Virtual channel 1 state flag
    $13 constant CSI_VC2STATEF                  \ [0x13] Virtual channel 2 state flag
    $14 constant CSI_VC3STATEF                  \ [0x14] Virtual channel 3 state flag
    $15 constant CSI_CCFIFOFF                   \ [0x15] Clock changer FIFO full flag
    $18 constant CSI_CRCERRF                    \ [0x18] CRC error flag
    $19 constant CSI_ECCERRF                    \ [0x19] ECC error flag
    $1a constant CSI_CECCERRF                   \ [0x1a] Corrected ECC error flag
    $1b constant CSI_IDERRF                     \ [0x1b] Data type ID error flag
    $1c constant CSI_SPKTERRF                   \ [0x1c] Short packet error flag
    $1d constant CSI_WDERRF                     \ [0x1d] Watchdog error flag
    $1e constant CSI_SYNCERRF                   \ [0x1e] Invalid synchronization error flag
  [then]


  [ifdef] CSI_CSI_SR1_DEF
    \
    \ @brief CSI-2 Host status register 1
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant CSI_ESOTDL0F                   \ [0x00] SOT error flag on lane 0
    $01 constant CSI_ESOTSYNCDL0F               \ [0x01] SOT synchronization error flag on lane 0
    $02 constant CSI_EESCDL0F                   \ [0x02] D-PHY_RX lane 0 escape entry error flag
    $03 constant CSI_ESYNCESCDL0F               \ [0x03] D-PHY_RX lane 0 low-power data transmission synchronization error flag
    $04 constant CSI_ECTRLDL0F                  \ [0x04] D-PHY_RX lane 0 control error flag
    $08 constant CSI_ESOTDL1F                   \ [0x08] SOT error flag on lane 1
    $09 constant CSI_ESOTSYNCDL1F               \ [0x09] SOT synchronization error flag on lane 1
    $0a constant CSI_EESCDL1F                   \ [0x0a] D-PHY_RX lane 1 escape entry error flag
    $0b constant CSI_ESYNCESCDL1F               \ [0x0b] D-PHY_RX lane 1 low-power data transmission synchronization error flag
    $0c constant CSI_ECTRLDL1F                  \ [0x0c] D-PHY_RX lane 1 control error flag
    $10 constant CSI_ACTDL0F                    \ [0x10] D-PHY_RX lane 0 high-speed reception active
    $11 constant CSI_SYNCDL0F                   \ [0x11] D-PHY_RX lane 0 receiver synchronization observed
    $12 constant CSI_SKCALDL0F                  \ [0x12] D-PHY_RX lane 0 high-speed skew calibration
    $13 constant CSI_STOPDL0F                   \ [0x13] D-PHY_RX receiver data lane 0 in stop state
    $14 constant CSI_ULPNDL0F                   \ [0x14] D-PHY_RX receiver ultra-low-power state (not) active on data lane 0
    $16 constant CSI_ACTDL1F                    \ [0x16] D-PHY_RX lane 1 high-speed reception active
    $17 constant CSI_SYNCDL1F                   \ [0x17] D-PHY_RX lane 1 receiver synchronization observed
    $18 constant CSI_SKCALDL1F                  \ [0x18] D-PHY_RX lane 1 high-speed skew calibration
    $19 constant CSI_STOPDL1F                   \ [0x19] D-PHY_RX receiver data lane 1 in stop state
    $1a constant CSI_ULPNDL1F                   \ [0x1a] D-PHY_RX receiver ultra-low-power state (not) active on data lane 1
    $1c constant CSI_STOPCLF                    \ [0x1c] D-PHY_RX receiver in stop state for the clock lane
    $1d constant CSI_ULPNACTF                   \ [0x1d] D-PHY_RX receiver ULP state (not) active
    $1e constant CSI_ULPNCLF                    \ [0x1e] D-PHY_RX receiver Ultra-Low power state (not) on clock lane.
    $1f constant CSI_ACTCLF                     \ [0x1f] D-PHY_RX receiver clock active flag
  [then]


  [ifdef] CSI_CSI_FCR0_DEF
    \
    \ @brief CSI-2 Host flag clear register 0
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant CSI_CLB0F                      \ [0x00] Clear line/byte counter 0 flag
    $01 constant CSI_CLB1F                      \ [0x01] Clear line/byte counter 1 flag
    $02 constant CSI_CLB2F                      \ [0x02] Clear line/byte counter 2 flag
    $03 constant CSI_CLB3F                      \ [0x03] Clear line/byte counter 3 flag
    $04 constant CSI_CTIM0F                     \ [0x04] Clear timer 0 flag
    $05 constant CSI_CTIM1F                     \ [0x05] Clear timer 1 flag
    $06 constant CSI_CTIM2F                     \ [0x06] Clear timer 2 flag
    $07 constant CSI_CTIM3F                     \ [0x07] Clear timer 3 flag
    $08 constant CSI_CSOF0F                     \ [0x08] Clear SOF flag for virtual channel 0
    $09 constant CSI_CSOF1F                     \ [0x09] Clear SOF flag for virtual channel 1
    $0a constant CSI_CSOF2F                     \ [0x0a] Clear SOF flag for virtual channel 2
    $0b constant CSI_CSOF3F                     \ [0x0b] Clear SOF flag for virtual channel 3
    $0c constant CSI_CEOF0F                     \ [0x0c] Clear EOF flag for virtual channel 0
    $0d constant CSI_CEOF1F                     \ [0x0d] Clear EOF flag for virtual channel 1
    $0e constant CSI_CEOF2F                     \ [0x0e] Clear EOF flag for virtual channel 2
    $0f constant CSI_CEOF3F                     \ [0x0f] Clear EOF flag for virtual channel 3
    $10 constant CSI_CSPKTF                     \ [0x10] Clear short packet flag
    $15 constant CSI_CCCFIFOFF                  \ [0x15] Clear clock changer FIFO full flag
    $18 constant CSI_CCRCERRF                   \ [0x18] Clear CRC error flag
    $19 constant CSI_CECCERRF                   \ [0x19] Clear ECC error flag
    $1a constant CSI_CCECCERRF                  \ [0x1a] Clear corrected ECC error flag
    $1b constant CSI_CIDERRF                    \ [0x1b] Clear data type ID error flag
    $1c constant CSI_CSPKTERRF                  \ [0x1c] Clear short packet error flag
    $1d constant CSI_CWDERRF                    \ [0x1d] Clear watchdog error flag
    $1e constant CSI_CSYNCERRF                  \ [0x1e] Clear invalid synchronization error flag
  [then]


  [ifdef] CSI_CSI_FCR1_DEF
    \
    \ @brief CSI-2 Host flag clear register 1
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant CSI_CESOTDL0F                  \ [0x00] Clear SOT error flag on lane 0
    $01 constant CSI_CESOTSYNCDL0F              \ [0x01] Clear SOT synchronization error flag on lane 0
    $02 constant CSI_CEESCDL0F                  \ [0x02] Clear D-PHY_RX lane 0 escape entry error flag
    $03 constant CSI_CESYNCESCDL0F              \ [0x03] Clear D-PHY_RX lane 0 low-power data transmission synchronization error flag
    $04 constant CSI_CECTRLDL0F                 \ [0x04] Clear D-PHY_RX lane 0 control error flag
    $08 constant CSI_CESOTDL1F                  \ [0x08] Clear SOT error flag on lane 1
    $09 constant CSI_CESOTSYNCDL1F              \ [0x09] Clear SOT synchronization error flag on lane 1
    $0a constant CSI_CEESCDL1F                  \ [0x0a] Clear D-PHY_RX lane 1 escape entry error flag
    $0b constant CSI_CESYNCESCDL1F              \ [0x0b] Clear D-PHY_RX lane 1 low-power data transmission synchronization error flag
    $0c constant CSI_CECTRLDL1F                 \ [0x0c] Clear D-PHY_RX lane 1 control error flag
  [then]


  [ifdef] CSI_CSI_SPDFR_DEF
    \
    \ @brief CSI-2 Host short packet data field register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant CSI_DATAFIELD                  \ [0x00 : 16] Data field
    $10 constant CSI_DATATYPE                   \ [0x10 : 6] Data type class
    $16 constant CSI_VCHANNEL                   \ [0x16 : 2] Virtual channel
  [then]


  [ifdef] CSI_CSI_ERR1_DEF
    \
    \ @brief CSI-2 Host error register 1
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant CSI_CRCDTERR                   \ [0x00 : 6] Data type having a CRC error
    $06 constant CSI_CRCVCERR                   \ [0x06 : 2] Virtual channel having a CRC error
    $08 constant CSI_CECCDTERR                  \ [0x08 : 6] Data type having a corrected ECC error
    $0e constant CSI_CECCVCERR                  \ [0x0e : 2] Virtual channel having a corrected ECC error
    $10 constant CSI_IDDTERR                    \ [0x10 : 6] Data type in error
    $16 constant CSI_IDVCERR                    \ [0x16 : 2] Virtual channel having ID error
  [then]


  [ifdef] CSI_CSI_ERR2_DEF
    \
    \ @brief CSI-2 Host error register 2
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant CSI_SPKTDTERR                  \ [0x00 : 6] Data type having a short packet error
    $06 constant CSI_SPKTVCERR                  \ [0x06 : 2] Virtual channel having a short packet error
    $10 constant CSI_WDVCERR                    \ [0x10 : 2] Virtual channel having a watchdog error
    $12 constant CSI_SYNCVCERR                  \ [0x12 : 2] Virtual channel having synchronization error
  [then]


  [ifdef] CSI_CSI_PRCR_DEF
    \
    \ @brief CSI PHY reset control register
    \ Address offset: 0x1000
    \ Reset value: 0x00000000
    \
    $01 constant CSI_PEN                        \ [0x01] When set to 0, this bit places the digital section of the D-PHY in the reset state.
  [then]


  [ifdef] CSI_CSI_PMCR_DEF
    \
    \ @brief CSI PHY mode control register
    \ Address offset: 0x1004
    \ Reset value: 0x00011003
    \
    $00 constant CSI_FRXMDL0                    \ [0x00] Force to Rx mode the data lane 0
    $01 constant CSI_FRXMDL1                    \ [0x01] Force to Rx mode the data lane 1
    $02 constant CSI_FTXSMDL0                   \ [0x02] Force to Tx Stop mode the data lane 0
    $04 constant CSI_DTDL                       \ [0x04] Disable turn-around data lane 0
    $08 constant CSI_RTDL0                      \ [0x08] Turn-around request data lane 0
    $0c constant CSI_TUESDL0                    \ [0x0c] Tx ULP escape-mode data lane 0
    $10 constant CSI_TUEXDL0                    \ [0x10] Tx ULP exit sequence data lane 0
  [then]


  [ifdef] CSI_CSI_PFCR_DEF
    \
    \ @brief CSI PHY frequency control register
    \ Address offset: 0x1008
    \ Reset value: 0x00000017
    \
    $00 constant CSI_CCFR                       \ [0x00 : 6] Configuration clock frequency range selection
    $08 constant CSI_HSFR                       \ [0x08 : 7] PHY high-speed frequency range selection
    $10 constant CSI_DLD                        \ [0x10] Data lane direction of lane 0
  [then]


  [ifdef] CSI_CSI_PTCR0_DEF
    \
    \ @brief CSI PHY test control register 0
    \ Address offset: 0x1010
    \ Reset value: 0x00000001
    \
    $00 constant CSI_TCKEN                      \ [0x00] Test-interface clock enable for the TDI bus into the PHY
    $01 constant CSI_TRSEN                      \ [0x01] Test-interface reset enable for the TDI bus into the PHY
  [then]


  [ifdef] CSI_CSI_PTCR1_DEF
    \
    \ @brief CSI PHY test control register 1
    \ Address offset: 0x1014
    \ Reset value: 0x00000000
    \
    $00 constant CSI_TDI                        \ [0x00 : 8] Test-interface data in
    $10 constant CSI_TWM                        \ [0x10] Test-interface write mode selector
  [then]


  [ifdef] CSI_CSI_PTSR_DEF
    \
    \ @brief CSI PHY test status register
    \ Address offset: 0x1018
    \ Reset value: 0x00000000
    \
    $00 constant CSI_TDO                        \ [0x00 : 8] CSI PHY test interface data output bus for read-back and internal probing functionalities
  [then]

  \
  \ @brief CSI-2 Host
  \
  $00 constant CSI_CSI_CR               \ CSI-2 Host control register
  $04 constant CSI_CSI_PCR              \ CSI-2 Host DPHY_RX control register
  $10 constant CSI_CSI_VC0CFGR1         \ CSI-2 Host virtual channel 0 configuration register 1
  $14 constant CSI_CSI_VC0CFGR2         \ CSI-2 Host virtual channel 0 configuration register 2
  $18 constant CSI_CSI_VC0CFGR3         \ CSI-2 Host virtual channel 0 configuration register 3
  $1C constant CSI_CSI_VC0CFGR4         \ CSI-2 Host virtual channel 0 configuration register 4
  $20 constant CSI_CSI_VC1CFGR1         \ CSI-2 Host virtual channel 1 configuration register 1
  $24 constant CSI_CSI_VC1CFGR2         \ CSI-2 Host virtual channel 1 configuration register 2
  $28 constant CSI_CSI_VC1CFGR3         \ CSI-2 Host virtual channel 1 configuration register 3
  $2C constant CSI_CSI_VC1CFGR4         \ CSI-2 Host virtual channel 1 configuration register 4
  $30 constant CSI_CSI_VC2CFGR1         \ CSI-2 Host virtual channel 2 configuration register 1
  $34 constant CSI_CSI_VC2CFGR2         \ CSI-2 Host virtual channel 2 configuration register 2
  $38 constant CSI_CSI_VC2CFGR3         \ CSI-2 Host virtual channel 2 configuration register 3
  $3C constant CSI_CSI_VC2CFGR4         \ CSI-2 Host virtual channel 2 configuration register 4
  $40 constant CSI_CSI_VC3CFGR1         \ CSI-2 Host virtual channel 3 configuration register 1
  $44 constant CSI_CSI_VC3CFGR2         \ CSI-2 Host virtual channel 3 configuration register 2
  $48 constant CSI_CSI_VC3CFGR3         \ CSI-2 Host virtual channel 3 configuration register 3
  $4C constant CSI_CSI_VC3CFGR4         \ CSI-2 Host virtual channel 3 configuration register 4
  $50 constant CSI_CSI_LB0CFGR          \ CSI-2 Host line byte 0 configuration register
  $54 constant CSI_CSI_LB1CFGR          \ CSI-2 Host line byte 1 configuration register
  $58 constant CSI_CSI_LB2CFGR          \ CSI-2 Host line byte 2 configuration register
  $5C constant CSI_CSI_LB3CFGR          \ CSI-2 Host line byte 3 configuration register
  $60 constant CSI_CSI_TIM0CFGR         \ CSI-2 Host timer 0 configuration register
  $64 constant CSI_CSI_TIM1CFGR         \ CSI-2 Host timer 1 configuration register
  $68 constant CSI_CSI_TIM2CFGR         \ CSI-2 Host timer 2 configuration register
  $6C constant CSI_CSI_TIM3CFGR         \ CSI-2 Host timer 3 configuration register
  $70 constant CSI_CSI_LMCFGR           \ CSI-2 Host lane merger configuration register
  $74 constant CSI_CSI_PRGITR           \ CSI-2 Host program interrupt register
  $78 constant CSI_CSI_WDR              \ CSI-2 Host watchdog register
  $80 constant CSI_CSI_IER0             \ CSI-2 Host interrupt enable register 0
  $84 constant CSI_CSI_IER1             \ CSI-2 Host interrupt enable register 1
  $90 constant CSI_CSI_SR0              \ CSI-2 Host status register 0
  $94 constant CSI_CSI_SR1              \ CSI-2 Host status register 1
  $100 constant CSI_CSI_FCR0            \ CSI-2 Host flag clear register 0
  $104 constant CSI_CSI_FCR1            \ CSI-2 Host flag clear register 1
  $110 constant CSI_CSI_SPDFR           \ CSI-2 Host short packet data field register
  $114 constant CSI_CSI_ERR1            \ CSI-2 Host error register 1
  $118 constant CSI_CSI_ERR2            \ CSI-2 Host error register 2
  $1000 constant CSI_CSI_PRCR           \ CSI PHY reset control register
  $1004 constant CSI_CSI_PMCR           \ CSI PHY mode control register
  $1008 constant CSI_CSI_PFCR           \ CSI PHY frequency control register
  $1010 constant CSI_CSI_PTCR0          \ CSI PHY test control register 0
  $1014 constant CSI_CSI_PTCR1          \ CSI PHY test control register 1
  $1018 constant CSI_CSI_PTSR           \ CSI PHY test status register

: CSI_DEF ; [then]
