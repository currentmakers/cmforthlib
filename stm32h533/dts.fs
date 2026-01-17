\
\ @file dts.fs
\ @brief DTS address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DTS_DEF

  [ifdef] DTS_DTS_CFGR1_DEF
    \
    \ @brief Temperature sensor configuration register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TS1_EN                     \ [0x00] Temperature sensor 1 enable bit
    $04 constant DTS_TS1_START                  \ [0x04] Start frequency measurement on temperature sensor 1
    $08 constant DTS_TS1_INTRIG_SEL             \ [0x08 : 4] Input trigger selection bit for temperature sensor 1
    $10 constant DTS_TS1_SMP_TIME               \ [0x10 : 4] Sampling time for temperature sensor 1
    $14 constant DTS_REFCLK_SEL                 \ [0x14] Reference clock selection bit
    $15 constant DTS_Q_MEAS_OPT                 \ [0x15] Quick measurement option bit
    $18 constant DTS_HSREF_CLK_DIV              \ [0x18 : 7] High speed clock division ratio
  [then]


  [ifdef] DTS_DTS_T0VALR1_DEF
    \
    \ @brief Temperature sensor T0 value register 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TS1_FMT0                   \ [0x00 : 16] Engineering value of the frequency measured at T0 for
    $10 constant DTS_TS1_T0                     \ [0x10 : 2] Engineering value of the T0 temperature for temperature sensor 1.
  [then]


  [ifdef] DTS_DTS_RAMPVALR_DEF
    \
    \ @brief Temperature sensor ramp value register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TS1_RAMP_COEFF             \ [0x00 : 16] Engineering value of the ramp coefficient for the temperature sensor 1.
  [then]


  [ifdef] DTS_DTS_ITR1_DEF
    \
    \ @brief Temperature sensor interrupt threshold register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TS1_LITTHD                 \ [0x00 : 16] Low interrupt threshold for temperature sensor 1
    $10 constant DTS_TS1_HITTHD                 \ [0x10 : 16] High interrupt threshold for temperature sensor 1
  [then]


  [ifdef] DTS_DTS_DR_DEF
    \
    \ @brief Temperature sensor data register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TS1_MFREQ                  \ [0x00 : 16] Value of the counter output value for temperature sensor 1
  [then]


  [ifdef] DTS_DTS_SR_DEF
    \
    \ @brief Temperature sensor status register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TS1_ITEF                   \ [0x00] Interrupt flag for end of measurement on temperature sensor 1, synchronized on PCLK.
    $01 constant DTS_TS1_ITLF                   \ [0x01] Interrupt flag for low threshold on temperature sensor 1, synchronized on PCLK.
    $02 constant DTS_TS1_ITHF                   \ [0x02] Interrupt flag for high threshold on temperature sensor 1, synchronized on PCLK
    $04 constant DTS_TS1_AITEF                  \ [0x04] Asynchronous interrupt flag for end of measure on temperature sensor 1
    $05 constant DTS_TS1_AITLF                  \ [0x05] Asynchronous interrupt flag for low threshold on temperature sensor 1
    $06 constant DTS_TS1_AITHF                  \ [0x06] Asynchronous interrupt flag for high threshold on temperature sensor 1
    $0f constant DTS_TS1_RDY                    \ [0x0f] Temperature sensor 1 ready flag
  [then]


  [ifdef] DTS_DTS_ITENR_DEF
    \
    \ @brief Temperature sensor interrupt enable register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TS1_ITEEN                  \ [0x00] Interrupt enable flag for end of measurement on temperature sensor 1, synchronized on PCLK.
    $01 constant DTS_TS1_ITLEN                  \ [0x01] Interrupt enable flag for low threshold on temperature sensor 1, synchronized on PCLK.
    $02 constant DTS_TS1_ITHEN                  \ [0x02] Interrupt enable flag for high threshold on temperature sensor 1, synchronized on PCLK.
    $04 constant DTS_TS1_AITEEN                 \ [0x04] Asynchronous interrupt enable flag for end of measurement on temperature sensor 1
    $05 constant DTS_TS1_AITLEN                 \ [0x05] Asynchronous interrupt enable flag for low threshold on temperature sensor 1.
    $06 constant DTS_TS1_AITHEN                 \ [0x06] Asynchronous interrupt enable flag on high threshold for temperature sensor 1.
  [then]


  [ifdef] DTS_DTS_ICIFR_DEF
    \
    \ @brief Temperature sensor clear interrupt flag register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TS1_CITEF                  \ [0x00] Interrupt clear flag for end of measurement on temperature sensor 1
    $01 constant DTS_TS1_CITLF                  \ [0x01] Interrupt clear flag for low threshold on temperature sensor 1
    $02 constant DTS_TS1_CITHF                  \ [0x02] Interrupt clear flag for high threshold on temperature sensor 1
    $04 constant DTS_TS1_CAITEF                 \ [0x04] Write once bit.
    $05 constant DTS_TS1_CAITLF                 \ [0x05] Asynchronous interrupt clear flag for low threshold on temperature sensor 1
    $06 constant DTS_TS1_CAITHF                 \ [0x06] Asynchronous interrupt clear flag for high threshold on temperature sensor 1
  [then]


  [ifdef] DTS_DTS_OR_DEF
    \
    \ @brief Temperature sensor option register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DTS_TS_OP0                     \ [0x00] general purpose option bits
    $01 constant DTS_TS_OP1                     \ [0x01] general purpose option bits
    $02 constant DTS_TS_OP2                     \ [0x02] general purpose option bits
    $03 constant DTS_TS_OP3                     \ [0x03] general purpose option bits
    $04 constant DTS_TS_OP4                     \ [0x04] general purpose option bits
    $05 constant DTS_TS_OP5                     \ [0x05] general purpose option bits
    $06 constant DTS_TS_OP6                     \ [0x06] general purpose option bits
    $07 constant DTS_TS_OP7                     \ [0x07] general purpose option bits
    $08 constant DTS_TS_OP8                     \ [0x08] general purpose option bits
    $09 constant DTS_TS_OP9                     \ [0x09] general purpose option bits
    $0a constant DTS_TS_OP10                    \ [0x0a] general purpose option bits
    $0b constant DTS_TS_OP11                    \ [0x0b] general purpose option bits
    $0c constant DTS_TS_OP12                    \ [0x0c] general purpose option bits
    $0d constant DTS_TS_OP13                    \ [0x0d] general purpose option bits
    $0e constant DTS_TS_OP14                    \ [0x0e] general purpose option bits
    $0f constant DTS_TS_OP15                    \ [0x0f] general purpose option bits
    $10 constant DTS_TS_OP16                    \ [0x10] general purpose option bits
    $11 constant DTS_TS_OP17                    \ [0x11] general purpose option bits
    $12 constant DTS_TS_OP18                    \ [0x12] general purpose option bits
    $13 constant DTS_TS_OP19                    \ [0x13] general purpose option bits
    $14 constant DTS_TS_OP20                    \ [0x14] general purpose option bits
    $15 constant DTS_TS_OP21                    \ [0x15] general purpose option bits
    $16 constant DTS_TS_OP22                    \ [0x16] general purpose option bits
    $17 constant DTS_TS_OP23                    \ [0x17] general purpose option bits
    $18 constant DTS_TS_OP24                    \ [0x18] general purpose option bits
    $19 constant DTS_TS_OP25                    \ [0x19] general purpose option bits
    $1a constant DTS_TS_OP26                    \ [0x1a] general purpose option bits
    $1b constant DTS_TS_OP27                    \ [0x1b] general purpose option bits
    $1c constant DTS_TS_OP28                    \ [0x1c] general purpose option bits
    $1d constant DTS_TS_OP29                    \ [0x1d] general purpose option bits
    $1e constant DTS_TS_OP30                    \ [0x1e] general purpose option bits
    $1f constant DTS_TS_OP31                    \ [0x1f] general purpose option bits
  [then]

  \
  \ @brief DTS address block description
  \
  $00 constant DTS_DTS_CFGR1            \ Temperature sensor configuration register 1
  $08 constant DTS_DTS_T0VALR1          \ Temperature sensor T0 value register 1
  $10 constant DTS_DTS_RAMPVALR         \ Temperature sensor ramp value register
  $14 constant DTS_DTS_ITR1             \ Temperature sensor interrupt threshold register 1
  $1C constant DTS_DTS_DR               \ Temperature sensor data register
  $20 constant DTS_DTS_SR               \ Temperature sensor status register
  $24 constant DTS_DTS_ITENR            \ Temperature sensor interrupt enable register
  $28 constant DTS_DTS_ICIFR            \ Temperature sensor clear interrupt flag register
  $2C constant DTS_DTS_OR               \ Temperature sensor option register

: DTS_DEF ; [then]
