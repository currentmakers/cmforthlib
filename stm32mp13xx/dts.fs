\
\ @file dts.fs
\ @brief DTS register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DTS_DEF

  [ifdef] DTS_DTS_CFGR1_DEF
    \
    \ @brief DTS_CFGR1 is the configuration register for temperature sensor 1.
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TS1_EN                     \ [0x00] TS1_EN
    $04 constant DTS_TS1_START                  \ [0x04] TS1_START
    $08 constant DTS_TS1_INTRIG_SEL             \ [0x08 : 4] TS1_INTRIG_SEL
    $10 constant DTS_TS1_SMP_TIME               \ [0x10 : 4] TS1_SMP_TIME
    $14 constant DTS_REFCLK_SEL                 \ [0x14] REFCLK_SEL
    $15 constant DTS_Q_MEAS_opt                 \ [0x15] Q_MEAS_opt
    $18 constant DTS_HSREF_CLK_DIV              \ [0x18 : 7] HSREF_CLK_DIV
  [then]


  [ifdef] DTS_DTS_T0VALR1_DEF
    \
    \ @brief DTS_T0VALR1 contains the value of the factory calibration temperature (T0) for temperature sensor 1. The system reset value is factory trimmed.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TS1_FMT0                   \ [0x00 : 16] TS1_FMT0
    $10 constant DTS_TS1_T0                     \ [0x10 : 2] TS1_T0
  [then]


  [ifdef] DTS_DTS_RAMPVALR_DEF
    \
    \ @brief The DTS_RAMPVALR is the ramp coefficient for the temperature sensor. The system reset value is factory trimmed.
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TS1_RAMP_COEFF             \ [0x00 : 16] TS1_RAMP_COEFF
  [then]


  [ifdef] DTS_DTS_ITR1_DEF
    \
    \ @brief DTS_ITR1 contains the threshold values for sensor 1.
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TS1_LITTHD                 \ [0x00 : 16] TS1_LITTHD
    $10 constant DTS_TS1_HITTHD                 \ [0x10 : 16] TS1_HITTHD
  [then]


  [ifdef] DTS_DTS_DR_DEF
    \
    \ @brief The DTS_DR contains the number of REF_CLK cycles used to compute the FM(T) frequency.
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TS1_MFREQ                  \ [0x00 : 16] TS1_MFREQ
  [then]


  [ifdef] DTS_DTS_SR_DEF
    \
    \ @brief Temperature sensor status register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TS1_ITEF                   \ [0x00] TS1_ITEF
    $01 constant DTS_TS1_ITLF                   \ [0x01] TS1_ITLF
    $02 constant DTS_TS1_ITHF                   \ [0x02] TS1_ITHF
    $04 constant DTS_TS1_AITEF                  \ [0x04] TS1_AITEF
    $05 constant DTS_TS1_AITLF                  \ [0x05] TS1_AITLF
    $06 constant DTS_TS1_AITHF                  \ [0x06] TS1_AITHF
    $0f constant DTS_TS1_RDY                    \ [0x0f] TS1_RDY
  [then]


  [ifdef] DTS_DTS_ITENR_DEF
    \
    \ @brief Temperature sensor interrupt enable register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TS1_ITEEN                  \ [0x00] TS1_ITEEN
    $01 constant DTS_TS1_ITLEN                  \ [0x01] TS1_ITLEN
    $02 constant DTS_TS1_ITHEN                  \ [0x02] TS1_ITHEN
    $04 constant DTS_TS1_AITEEN                 \ [0x04] TS1_AITEEN
    $05 constant DTS_TS1_AITLEN                 \ [0x05] TS1_AITLEN
    $06 constant DTS_TS1_AITHEN                 \ [0x06] TS1_AITHEN
  [then]


  [ifdef] DTS_DTS_ICIFR_DEF
    \
    \ @brief DTS_ICIFR is the control register for the interrupt flags.
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TS1_CITEF                  \ [0x00] TS1_CITEF
    $01 constant DTS_TS1_CITLF                  \ [0x01] TS1_CITLF
    $02 constant DTS_TS1_CITHF                  \ [0x02] TS1_CITHF
    $04 constant DTS_TS1_CAITEF                 \ [0x04] TS1_CAITEF
    $05 constant DTS_TS1_CAITLF                 \ [0x05] TS1_CAITLF
    $06 constant DTS_TS1_CAITHF                 \ [0x06] TS1_CAITHF
  [then]


  [ifdef] DTS_DTS_OR_DEF
    \
    \ @brief The DTS_OR contains general-purpose option bits.
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TS_Op0                     \ [0x00] TS_Op0
    $01 constant DTS_TS_Op1                     \ [0x01] TS_Op1
    $02 constant DTS_TS_Op2                     \ [0x02] TS_Op2
    $03 constant DTS_TS_Op3                     \ [0x03] TS_Op3
    $04 constant DTS_TS_Op4                     \ [0x04] TS_Op4
    $05 constant DTS_TS_Op5                     \ [0x05] TS_Op5
    $06 constant DTS_TS_Op6                     \ [0x06] TS_Op6
    $07 constant DTS_TS_Op7                     \ [0x07] TS_Op7
    $08 constant DTS_TS_Op8                     \ [0x08] TS_Op8
    $09 constant DTS_TS_Op9                     \ [0x09] TS_Op9
    $0a constant DTS_TS_Op10                    \ [0x0a] TS_Op10
    $0b constant DTS_TS_Op11                    \ [0x0b] TS_Op11
    $0c constant DTS_TS_Op12                    \ [0x0c] TS_Op12
    $0d constant DTS_TS_Op13                    \ [0x0d] TS_Op13
    $0e constant DTS_TS_Op14                    \ [0x0e] TS_Op14
    $0f constant DTS_TS_Op15                    \ [0x0f] TS_Op15
    $10 constant DTS_TS_Op16                    \ [0x10] TS_Op16
    $11 constant DTS_TS_Op17                    \ [0x11] TS_Op17
    $12 constant DTS_TS_Op18                    \ [0x12] TS_Op18
    $13 constant DTS_TS_Op19                    \ [0x13] TS_Op19
    $14 constant DTS_TS_Op20                    \ [0x14] TS_Op20
    $15 constant DTS_TS_Op21                    \ [0x15] TS_Op21
    $16 constant DTS_TS_Op22                    \ [0x16] TS_Op22
    $17 constant DTS_TS_Op23                    \ [0x17] TS_Op23
    $18 constant DTS_TS_Op24                    \ [0x18] TS_Op24
    $19 constant DTS_TS_Op25                    \ [0x19] TS_Op25
    $1a constant DTS_TS_Op26                    \ [0x1a] TS_Op26
    $1b constant DTS_TS_Op27                    \ [0x1b] TS_Op27
    $1c constant DTS_TS_Op28                    \ [0x1c] TS_Op28
    $1d constant DTS_TS_Op29                    \ [0x1d] TS_Op29
    $1e constant DTS_TS_Op30                    \ [0x1e] TS_Op30
    $1f constant DTS_TS_Op31                    \ [0x1f] TS_Op31
  [then]

  \
  \ @brief DTS register block
  \
  $00 constant DTS_DTS_CFGR1            \ DTS_CFGR1 is the configuration register for temperature sensor 1.
  $08 constant DTS_DTS_T0VALR1          \ DTS_T0VALR1 contains the value of the factory calibration temperature (T0) for temperature sensor 1. The system reset value is factory trimmed.
  $10 constant DTS_DTS_RAMPVALR         \ The DTS_RAMPVALR is the ramp coefficient for the temperature sensor. The system reset value is factory trimmed.
  $14 constant DTS_DTS_ITR1             \ DTS_ITR1 contains the threshold values for sensor 1.
  $1C constant DTS_DTS_DR               \ The DTS_DR contains the number of REF_CLK cycles used to compute the FM(T) frequency.
  $20 constant DTS_DTS_SR               \ Temperature sensor status register
  $24 constant DTS_DTS_ITENR            \ Temperature sensor interrupt enable register
  $28 constant DTS_DTS_ICIFR            \ DTS_ICIFR is the control register for the interrupt flags.
  $2C constant DTS_DTS_OR               \ The DTS_OR contains general-purpose option bits.

: DTS_DEF ; [then]
