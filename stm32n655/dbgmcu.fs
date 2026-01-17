\
\ @file dbgmcu.fs
\ @brief Microcontroller debug unit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DBGMCU_DEF

  [ifdef] DBGMCU_DBGMCU_IDCODE_DEF
    \
    \ @brief DBGMCU identity code register
    \ Address offset: 0x00
    \ Reset value: 0x00006486
    \
    $00 constant DBGMCU_DEV_ID                  \ [0x00 : 12] Device ID
    $10 constant DBGMCU_REV_ID                  \ [0x10 : 16] Revision
  [then]


  [ifdef] DBGMCU_DBGMCU_CR_DEF
    \
    \ @brief DBGMCU configuration register
    \ Address offset: 0x04
    \ Reset value: 0x80000000
    \
    $00 constant DBGMCU_DBG_SLEEP               \ [0x00] Allow debug in Sleep mode
    $01 constant DBGMCU_DBG_STOP                \ [0x01] Allow debug in Stop mode
    $02 constant DBGMCU_DBG_STANDBY             \ [0x02] Allow debug in Standby mode
    $14 constant DBGMCU_DBGCLKEN                \ [0x14] Debug clock enable through software
    $15 constant DBGMCU_TRACECLKEN              \ [0x15] TPIU export clock enable through software
    $1c constant DBGMCU_DBTRGOEN                \ [0x1c] DBTRGIO connection control
    $1f constant DBGMCU_HLT_TSGEN_EN            \ [0x1f] TSGEN halt enable
  [then]


  [ifdef] DBGMCU_DBGMCU_APB1LFZ1_DEF
    \
    \ @brief DBGMCU APB1L peripheral freeze register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_TIM2_STOP           \ [0x00] TIM2 stop in debug
    $01 constant DBGMCU_DBG_TIM3_STOP           \ [0x01] TIM3 stop in debug
    $02 constant DBGMCU_DBG_TIM4_STOP           \ [0x02] TIM4 stop in debug
    $03 constant DBGMCU_DBG_TIM5_STOP           \ [0x03] TIM5 stop in debug
    $04 constant DBGMCU_DBG_TIM6_STOP           \ [0x04] TIM6 stop in debug
    $05 constant DBGMCU_DBG_TIM7_STOP           \ [0x05] TIM7 stop in debug
    $06 constant DBGMCU_DBG_TIM12_STOP          \ [0x06] TIM12 stop in debug
    $07 constant DBGMCU_DBG_TIM13_STOP          \ [0x07] TIM13 stop in debug
    $08 constant DBGMCU_DBG_TIM14_STOP          \ [0x08] TIM14 stop in debug
    $09 constant DBGMCU_DBG_LPTIM1_STOP         \ [0x09] LPTIM1 stop in debug
    $0b constant DBGMCU_DBG_WWDG1_STOP          \ [0x0b] WWDG1 stop in debug
    $0c constant DBGMCU_DBG_TIM10_STOP          \ [0x0c] TIM10 stop in debug
    $0d constant DBGMCU_DBG_TIM11_STOP          \ [0x0d] TIM11 stop in debug
    $15 constant DBGMCU_DBG_I2C1_STOP           \ [0x15] I2C1 SMBUS timeout stop in debug
    $16 constant DBGMCU_DBG_I2C2_STOP           \ [0x16] I2C2 SMBUS timeout stop in debug
    $17 constant DBGMCU_DBG_I2C3_STOP           \ [0x17] I2C3 SMBUS timeout stop in debug
    $18 constant DBGMCU_DBG_I3C1_STOP           \ [0x18] I3C1 SMBUS timeout stop in debug
    $19 constant DBGMCU_DBG_I3C2_STOP           \ [0x19] I3C2 SMBUS timeout stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_APB1HFZ1_DEF
    \
    \ @brief DBGMCU APB1H peripheral freeze register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $08 constant DBGMCU_DBG_FDCAN_STOP          \ [0x08] FDCAN stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_APB2FZ1_DEF
    \
    \ @brief DBGMCU APB2 peripheral freeze register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_TIM1_STOP           \ [0x00] TIM1 stop in debug
    $01 constant DBGMCU_DBG_TIM8_STOP           \ [0x01] TIM8 stop in debug
    $0f constant DBGMCU_DBG_TIM18_STOP          \ [0x0f] TIM18 stop in debug
    $10 constant DBGMCU_DBG_TIM15_STOP          \ [0x10] TIM15 stop in debug
    $11 constant DBGMCU_DBG_TIM16_STOP          \ [0x11] TIM16 stop in debug
    $12 constant DBGMCU_DBG_TIM17_STOP          \ [0x12] TIM17 stop in debug
    $13 constant DBGMCU_DBG_TIM9_STOP           \ [0x13] TIM9 stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_APB4FZ1_DEF
    \
    \ @brief DBGMCU APB4 peripheral freeze register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $08 constant DBGMCU_DBG_I2C4_STOP           \ [0x08] I2C4 stop in debug
    $09 constant DBGMCU_DBG_LPTIM2_STOP         \ [0x09] LPTIM2 stop in debug
    $0a constant DBGMCU_DBG_LPTIM3_STOP         \ [0x0a] LPTIM3 stop in debug
    $0b constant DBGMCU_DBG_LPTIM4_STOP         \ [0x0b] LPTIM4 stop in debug
    $0c constant DBGMCU_DBG_LPTIM5_STOP         \ [0x0c] LPTIM5 stop in debug
    $10 constant DBGMCU_DBG_RTC_STOP            \ [0x10] RTC clock is suspended in debug
    $12 constant DBGMCU_DBG_IWDG_STOP           \ [0x12] WWDG stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_APB5FZ1_DEF
    \
    \ @brief DBGMCU APB5 peripheral freeze register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $04 constant DBGMCU_DBG_GFXTIM_STOP         \ [0x04] GFXTIM stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_AHB1FZ1_DEF
    \
    \ @brief DBGMCU AHB1 peripheral freeze register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_GPDMA1_CH0_STOP     \ [0x00] GPDMA1_CHn suspend in debug
    $01 constant DBGMCU_DBG_GPDMA1_CH1_STOP     \ [0x01] GPDMA1_CHn suspend in debug
    $02 constant DBGMCU_DBG_GPDMA1_CH2_STOP     \ [0x02] GPDMA1_CHn suspend in debug
    $03 constant DBGMCU_DBG_GPDMA1_CH3_STOP     \ [0x03] GPDMA1_CHn suspend in debug
    $04 constant DBGMCU_DBG_GPDMA1_CH4_STOP     \ [0x04] GPDMA1_CHn suspend in debug
    $05 constant DBGMCU_DBG_GPDMA1_CH5_STOP     \ [0x05] GPDMA1_CHn suspend in debug
    $06 constant DBGMCU_DBG_GPDMA1_CH6_STOP     \ [0x06] GPDMA1_CHn suspend in debug
    $07 constant DBGMCU_DBG_GPDMA1_CH7_STOP     \ [0x07] GPDMA1_CHn suspend in debug
    $08 constant DBGMCU_DBG_GPDMA1_CH8_STOP     \ [0x08] GPDMA1_CHn suspend in debug
    $09 constant DBGMCU_DBG_GPDMA1_CH9_STOP     \ [0x09] GPDMA1_CHn suspend in debug
    $0a constant DBGMCU_DBG_GPDMA1_CH10_STOP    \ [0x0a] GPDMA1_CHn suspend in debug
    $0b constant DBGMCU_DBG_GPDMA1_CH11_STOP    \ [0x0b] GPDMA1_CHn suspend in debug
    $0c constant DBGMCU_DBG_GPDMA1_CH12_STOP    \ [0x0c] GPDMA1_CHn suspend in debug
    $0d constant DBGMCU_DBG_GPDMA1_CH13_STOP    \ [0x0d] GPDMA1_CHn suspend in debug
    $0e constant DBGMCU_DBG_GPDMA1_CH14_STOP    \ [0x0e] GPDMA1_CHn suspend in debug
    $0f constant DBGMCU_DBG_GPDMA1_CH15_STOP    \ [0x0f] GPDMA1_CHn suspend in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_AHB5FZ1_DEF
    \
    \ @brief DBGMCU AHB5 peripheral freeze register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DBG_HPDMA1_CH0_STOP     \ [0x00] HPDMA3_CHn suspend in debug
    $01 constant DBGMCU_DBG_HPDMA1_CH1_STOP     \ [0x01] HPDMA3_CHn suspend in debug
    $02 constant DBGMCU_DBG_HPDMA1_CH2_STOP     \ [0x02] HPDMA3_CHn suspend in debug
    $03 constant DBGMCU_DBG_HPDMA1_CH3_STOP     \ [0x03] HPDMA3_CHn suspend in debug
    $04 constant DBGMCU_DBG_HPDMA1_CH4_STOP     \ [0x04] HPDMA3_CHn suspend in debug
    $05 constant DBGMCU_DBG_HPDMA1_CH5_STOP     \ [0x05] HPDMA3_CHn suspend in debug
    $06 constant DBGMCU_DBG_HPDMA1_CH6_STOP     \ [0x06] HPDMA3_CHn suspend in debug
    $07 constant DBGMCU_DBG_HPDMA1_CH7_STOP     \ [0x07] HPDMA3_CHn suspend in debug
    $08 constant DBGMCU_DBG_HPDMA1_CH8_STOP     \ [0x08] HPDMA3_CHn suspend in debug
    $09 constant DBGMCU_DBG_HPDMA1_CH9_STOP     \ [0x09] HPDMA3_CHn suspend in debug
    $0a constant DBGMCU_DBG_HPDMA1_CH10_STOP    \ [0x0a] HPDMA3_CHn suspend in debug
    $0b constant DBGMCU_DBG_HPDMA1_CH11_STOP    \ [0x0b] HPDMA3_CHn suspend in debug
    $0c constant DBGMCU_DBG_HPDMA1_CH12_STOP    \ [0x0c] HPDMA3_CHn suspend in debug
    $0d constant DBGMCU_DBG_HPDMA1_CH13_STOP    \ [0x0d] HPDMA3_CHn suspend in debug
    $0e constant DBGMCU_DBG_HPDMA1_CH14_STOP    \ [0x0e] HPDMA3_CHn suspend in debug
    $0f constant DBGMCU_DBG_HPDMA1_CH15_STOP    \ [0x0f] HPDMA3_CHn suspend in debug
    $10 constant DBGMCU_NPU_DBG_FREEZE          \ [0x10] NPU stop in debug mode
  [then]


  [ifdef] DBGMCU_DBGMCU_SR_DEF
    \
    \ @brief DBGMCU status register
    \ Address offset: 0xFC
    \ Reset value: 0x00010003
    \
    $00 constant DBGMCU_AP0_PRESENT             \ [0x00] Access point 0 presence
    $01 constant DBGMCU_AP1_PRESENT             \ [0x01] Access point 1 presence
    $10 constant DBGMCU_AP0_ENABLE              \ [0x10] Access point 0 enable
    $11 constant DBGMCU_AP1_ENABLE              \ [0x11] Access point 1 enable
  [then]


  [ifdef] DBGMCU_DBGMCU_DBG_AUTH_HOST_DEF
    \
    \ @brief DBGMCU host authentication register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_MESSAGE                 \ [0x00 : 32] Mailbox between debugger and processor
  [then]


  [ifdef] DBGMCU_DBGMCU_DBG_AUTH_DEV_DEF
    \
    \ @brief DBGMCU device authentication register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_MESSAGE                 \ [0x00 : 32] Mailbox between debugger and processor
  [then]


  [ifdef] DBGMCU_DBGMCU_DBG_AUTH_ACK_DEF
    \
    \ @brief DBGMCU message read acknowledge authentication register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_HOST_ACK                \ [0x00] Access status to DBG_AUTH_HOST register
    $01 constant DBGMCU_DEVICE_ACK              \ [0x01] Access status to DBG_AUTH_DEV register
  [then]

  \
  \ @brief Microcontroller debug unit
  \
  $00 constant DBGMCU_DBGMCU_IDCODE     \ DBGMCU identity code register
  $04 constant DBGMCU_DBGMCU_CR         \ DBGMCU configuration register
  $10 constant DBGMCU_DBGMCU_APB1LFZ1   \ DBGMCU APB1L peripheral freeze register
  $14 constant DBGMCU_DBGMCU_APB1HFZ1   \ DBGMCU APB1H peripheral freeze register
  $18 constant DBGMCU_DBGMCU_APB2FZ1    \ DBGMCU APB2 peripheral freeze register
  $1C constant DBGMCU_DBGMCU_APB4FZ1    \ DBGMCU APB4 peripheral freeze register
  $20 constant DBGMCU_DBGMCU_APB5FZ1    \ DBGMCU APB5 peripheral freeze register
  $24 constant DBGMCU_DBGMCU_AHB1FZ1    \ DBGMCU AHB1 peripheral freeze register
  $28 constant DBGMCU_DBGMCU_AHB5FZ1    \ DBGMCU AHB5 peripheral freeze register
  $FC constant DBGMCU_DBGMCU_SR         \ DBGMCU status register
  $100 constant DBGMCU_DBGMCU_DBG_AUTH_HOST    \ DBGMCU host authentication register
  $104 constant DBGMCU_DBGMCU_DBG_AUTH_DEV    \ DBGMCU device authentication register
  $108 constant DBGMCU_DBGMCU_DBG_AUTH_ACK    \ DBGMCU message read acknowledge authentication register

: DBGMCU_DEF ; [then]
