\
\ @file system_ctrl.fs
\ @brief DIE_ID register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SYSTEM_CTRL_DEF

  [ifdef] SYSTEM_CTRL_DIE_ID_DEF
    \
    \ @brief DIE_ID register
    \ Address offset: 0x00
    \ Reset value: 0x00000120
    \
    $00 constant SYSTEM_CTRL_REVISION           \ [0x00 : 4] Cut revision (metal fix)
    $04 constant SYSTEM_CTRL_VERSION            \ [0x04 : 4] Cut version
    $08 constant SYSTEM_CTRL_PRODUCT            \ [0x08 : 4] Product version. May be used to discriminate several version of a same digital BLE LPH device embedding different analog versions
  [then]


  [ifdef] SYSTEM_CTRL_JTAG_ID_DEF
    \
    \ @brief JTAG_ID register
    \ Address offset: 0x04
    \ Reset value: 0x02027041
    \
    $01 constant SYSTEM_CTRL_MANUF_ID           \ [0x01 : 11] Manufacturer ID
    $0c constant SYSTEM_CTRL_PART_NUMBER        \ [0x0c : 16] Part number
    $1c constant SYSTEM_CTRL_VERSION_NUMBER     \ [0x1c : 4] Version
  [then]


  [ifdef] SYSTEM_CTRL_I2C_FMP_CTRL_DEF
    \
    \ @brief I2C_FMP_CTRL register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SYSTEM_CTRL_I2C1_PA0_FMP       \ [0x00] I2C1 Fast-Mode Plus driving capability for I2C1_SCL on PA0 I/O. 0: PA0 pin operated in standard mode. 1: FM+ mode is enabled on PA0 pin, and speed control is bypassed
    $01 constant SYSTEM_CTRL_I2C1_PA1_FMP       \ [0x01] I2C1 Fast-Mode Plus driving capability for I2C1_SDA on PA1 I/O. 0: PA1 pin operated in standard mode. 1: FM+ mode is enabled on PA1 pin, and speed control is bypassed
    $02 constant SYSTEM_CTRL_I2C1_PB6_FMP       \ [0x02] I2C1 Fast-Mode Plus driving capability for I2C1_SCL on PB6 I/O. 0: PB6 pin operated in standard mode. 1: FM+ mode is enabled on PB6 pin, and speed control is bypassed.
    $03 constant SYSTEM_CTRL_I2C1_PB7_FMP       \ [0x03] I2C1 Fast-Mode Plus driving capability for I2C1_SDA on PB7 I/O. 0: PB7 pin operated in standard mode. 1: FM+ mode is enabled on PB7 pin, and speed control is bypassed
    $04 constant SYSTEM_CTRL_I2C1_PB10_FMP      \ [0x04] I2C1_PB10_FMP: I2C1 Fast-Mode Plus driving capability for I2C1_SDA on PB10 I/O. 0: PB10 pin operated in standard mode. 1: FM+ mode is enabled on PB10 pin, and speed control is bypassed.
    $05 constant SYSTEM_CTRL_I2C1_PB11_FMP      \ [0x05] I2C1_PB11_FMP: I2C1 Fast-Mode Plus driving capability for I2C1_SCL on PB11 I/O. 0: PB11 pin operated in standard mode. 1: FM+ mode is enabled on PB11 pin, and speed control is bypassed
    $06 constant SYSTEM_CTRL_I2C2_PA6_FMP       \ [0x06] I2C2_PA6_FMP: I2C2 Fast-Mode Plus driving capability for I2C2_SCL on PA6 I/O. 0: PA6 pin operated in standard mode. 1: FM+ mode is enabled on PA6 pin, and speed control is bypassed.
    $07 constant SYSTEM_CTRL_I2C2_PA7_FMP       \ [0x07] I2C2_PA7_FMP: I2C2 Fast-Mode Plus driving capability for I2C2_SDA on PA7 I/O. 0: PA7 pin operated in standard mode. 1: FM+ mode is enabled on PA7 pin, and speed control is bypassed
    $08 constant SYSTEM_CTRL_I2C2_PA13_FMP      \ [0x08] I2C2_PA13_FMP: I2C2 Fast-Mode Plus driving capability for I2C2_SCL on PA13 I/O. 0: PA13 pin operated in standard mode. 1: FM+ mode is enabled on PA13 pin, and speed control is bypassed.
    $09 constant SYSTEM_CTRL_I2C2_PA14_FMP      \ [0x09] I2C2_PA14_FMP: I2C2 Fast-Mode Plus driving capability for I2C2_SDA on PA14 I/O. 0: PA14 pin operated in standard mode. 1: FM+ mode is enabled on PA14 pin, and speed control is bypassed.
  [then]


  [ifdef] SYSTEM_CTRL_IO_DTR_DEF
    \
    \ @brief IO_DTR register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SYSTEM_CTRL_PA0_DT             \ [0x00] PA0_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
    $01 constant SYSTEM_CTRL_PA1_DT             \ [0x01] PA1_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
    $02 constant SYSTEM_CTRL_PA2_DT             \ [0x02] PA2_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
    $03 constant SYSTEM_CTRL_PA3_DT             \ [0x03] PA3_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
    $04 constant SYSTEM_CTRL_PA4_DT             \ [0x04] PA4_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
    $05 constant SYSTEM_CTRL_PA5_DT             \ [0x05] PA5_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
    $06 constant SYSTEM_CTRL_PA6_DT             \ [0x06] PA6_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
    $07 constant SYSTEM_CTRL_PA7_DT             \ [0x07] PA7_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
    $08 constant SYSTEM_CTRL_PA8_DT             \ [0x08] PA8_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
    $09 constant SYSTEM_CTRL_PA9_DT             \ [0x09] PA9_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
    $0a constant SYSTEM_CTRL_PA10_DT            \ [0x0a] PA10_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
    $0b constant SYSTEM_CTRL_PA11_DT            \ [0x0b] PA11_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
    $0c constant SYSTEM_CTRL_PA12_DT            \ [0x0c] PA12_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
    $0d constant SYSTEM_CTRL_PA13_DT            \ [0x0d] PA13_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
    $0e constant SYSTEM_CTRL_PA14_DT            \ [0x0e] PA14_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
    $0f constant SYSTEM_CTRL_PA15_DT            \ [0x0f] PA15_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
    $10 constant SYSTEM_CTRL_PB0_DT             \ [0x10] PB0_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
    $11 constant SYSTEM_CTRL_PB1_DT             \ [0x11] PB1_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
    $12 constant SYSTEM_CTRL_PB2_DT             \ [0x12] PB2_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
    $13 constant SYSTEM_CTRL_PB3_DT             \ [0x13] PB3_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
    $14 constant SYSTEM_CTRL_PB4_DT             \ [0x14] PB4_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
    $15 constant SYSTEM_CTRL_PB5_DT             \ [0x15] PB5_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
    $16 constant SYSTEM_CTRL_PB6_DT             \ [0x16] PB6_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
    $17 constant SYSTEM_CTRL_PB7_DT             \ [0x17] PB7_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
    $18 constant SYSTEM_CTRL_PB8_DT             \ [0x18] PB8_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
    $19 constant SYSTEM_CTRL_PB9_DT             \ [0x19] PB9_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
    $1a constant SYSTEM_CTRL_PB10_DT            \ [0x1a] PB10_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
    $1b constant SYSTEM_CTRL_PB11_DT            \ [0x1b] PB11_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
    $1c constant SYSTEM_CTRL_PB12_DT            \ [0x1c] PB12_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
    $1d constant SYSTEM_CTRL_PB13_DT            \ [0x1d] PB13_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
    $1e constant SYSTEM_CTRL_PB14_DT            \ [0x1e] PB14_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
    $1f constant SYSTEM_CTRL_PB15_DT            \ [0x1f] PB15_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
  [then]


  [ifdef] SYSTEM_CTRL_IO_IBER_DEF
    \
    \ @brief IO_IBER register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SYSTEM_CTRL_PA0_IBE            \ [0x00] PA0_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
    $01 constant SYSTEM_CTRL_PA1_IBE            \ [0x01] PA1_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
    $02 constant SYSTEM_CTRL_PA2_IBE            \ [0x02] PA2_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
    $03 constant SYSTEM_CTRL_PA3_IBE            \ [0x03] PA3_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
    $04 constant SYSTEM_CTRL_PA4_IBE            \ [0x04] PA4_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
    $05 constant SYSTEM_CTRL_PA5_IBE            \ [0x05] PA5_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
    $06 constant SYSTEM_CTRL_PA6_IBE            \ [0x06] PA6_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
    $07 constant SYSTEM_CTRL_PA7_IBE            \ [0x07] PA7_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
    $08 constant SYSTEM_CTRL_PA8_IBE            \ [0x08] PA8_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
    $09 constant SYSTEM_CTRL_PA9_IBE            \ [0x09] PA9_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
    $0a constant SYSTEM_CTRL_PA10_IBE           \ [0x0a] PA10_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
    $0b constant SYSTEM_CTRL_PA11_IBE           \ [0x0b] PA11_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
    $0c constant SYSTEM_CTRL_PA12_IBE           \ [0x0c] PA12_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
    $0d constant SYSTEM_CTRL_PA13_IBE           \ [0x0d] PA13_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
    $0e constant SYSTEM_CTRL_PA14_IBE           \ [0x0e] PA14_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
    $0f constant SYSTEM_CTRL_PA15_IBE           \ [0x0f] PA15_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
    $10 constant SYSTEM_CTRL_PB0_IBE            \ [0x10] PB0_IBE: Interrupt edge selection for port B I/Os. 0: single edge detection. 1: both edges detection.
    $11 constant SYSTEM_CTRL_PB1_IBE            \ [0x11] PB1_IBE: Interrupt edge selection for port B I/Os. 0: single edge detection. 1: both edges detection.
    $12 constant SYSTEM_CTRL_PB2_IBE            \ [0x12] PB2_IBE: Interrupt edge selection for port B I/Os. 0: single edge detection. 1: both edges detection.
    $13 constant SYSTEM_CTRL_PB3_IBE            \ [0x13] PB3_IBE: Interrupt edge selection for port B I/Os. 0: single edge detection. 1: both edges detection.
    $14 constant SYSTEM_CTRL_PB4_IBE            \ [0x14] PB4_IBE: Interrupt edge selection for port B I/Os. 0: single edge detection. 1: both edges detection.
    $15 constant SYSTEM_CTRL_PB5_IBE            \ [0x15] PB5_IBE: Interrupt edge selection for port B I/Os. 0: single edge detection. 1: both edges detection.
    $16 constant SYSTEM_CTRL_PB6_IBE            \ [0x16] PB6_IBE: Interrupt edge selection for port B I/Os. 0: single edge detection. 1: both edges detection.
    $17 constant SYSTEM_CTRL_PB7_IBE            \ [0x17] PB7_IBE: Interrupt edge selection for port B I/Os. 0: single edge detection. 1: both edges detection.
    $18 constant SYSTEM_CTRL_PB8_IBE            \ [0x18] PB8_IBE: Interrupt edge selection for port B I/Os. 0: single edge detection. 1: both edges detection.
    $19 constant SYSTEM_CTRL_PB9_IBE            \ [0x19] PB9_IBE: Interrupt edge selection for port B I/Os. 0: single edge detection. 1: both edges detection.
    $1a constant SYSTEM_CTRL_PB10_IBE           \ [0x1a] PB10_IBE: Interrupt edge selection for port B I/Os. 0: single edge detection. 1: both edges detection.
    $1b constant SYSTEM_CTRL_PB11_IBE           \ [0x1b] PB11_IBE: Interrupt edge selection for port B I/Os. 0: single edge detection. 1: both edges detection.
    $1c constant SYSTEM_CTRL_PB12_IBE           \ [0x1c] PB12_IBE: Interrupt edge selection for port B I/Os. 0: single edge detection. 1: both edges detection.
    $1d constant SYSTEM_CTRL_PB13_IBE           \ [0x1d] PB13_IBE: Interrupt edge selection for port B I/Os. 0: single edge detection. 1: both edges detection.
    $1e constant SYSTEM_CTRL_PB14_IBE           \ [0x1e] PB14_IBE: Interrupt edge selection for port B I/Os. 0: single edge detection. 1: both edges detection.
    $1f constant SYSTEM_CTRL_PB15_IBE           \ [0x1f] PB15_IBE: Interrupt edge selection for port B I/Os. 0: single edge detection. 1: both edges detection.
  [then]


  [ifdef] SYSTEM_CTRL_IO_IEVR_DEF
    \
    \ @brief IO_IEVR register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SYSTEM_CTRL_PA0_IEV            \ [0x00] PA0_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $01 constant SYSTEM_CTRL_PA1_IEV            \ [0x01] PA1_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $02 constant SYSTEM_CTRL_PA2_IEV            \ [0x02] PA2_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $03 constant SYSTEM_CTRL_PA3_IEV            \ [0x03] PA3_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $04 constant SYSTEM_CTRL_PA4_IEV            \ [0x04] PA4_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $05 constant SYSTEM_CTRL_PA5_IEV            \ [0x05] PA5_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $06 constant SYSTEM_CTRL_PA6_IEV            \ [0x06] PA6_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $07 constant SYSTEM_CTRL_PA7_IEV            \ [0x07] PA7_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $08 constant SYSTEM_CTRL_PA8_IEV            \ [0x08] PA8_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $09 constant SYSTEM_CTRL_PA9_IEV            \ [0x09] PA9_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $0a constant SYSTEM_CTRL_PA10_IEV           \ [0x0a] PA10_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $0b constant SYSTEM_CTRL_PA11_IEV           \ [0x0b] PA11_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $0c constant SYSTEM_CTRL_PA12_IEV           \ [0x0c] PA12_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $0d constant SYSTEM_CTRL_PA13_IEV           \ [0x0d] PA13_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $0e constant SYSTEM_CTRL_PA14_IEV           \ [0x0e] PA14_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $0f constant SYSTEM_CTRL_PA15_IEV           \ [0x0f] PA15_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $10 constant SYSTEM_CTRL_PB0_IEV            \ [0x10] PB0_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $11 constant SYSTEM_CTRL_PB1_IEV            \ [0x11] PB1_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $12 constant SYSTEM_CTRL_PB2_IEV            \ [0x12] PB2_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $13 constant SYSTEM_CTRL_PB3_IEV            \ [0x13] PB3_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $14 constant SYSTEM_CTRL_PB4_IEV            \ [0x14] PB4_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $15 constant SYSTEM_CTRL_PB5_IEV            \ [0x15] PB5_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $16 constant SYSTEM_CTRL_PB6_IEV            \ [0x16] PB6_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $17 constant SYSTEM_CTRL_PB7_IEV            \ [0x17] PB7_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $18 constant SYSTEM_CTRL_PB8_IEV            \ [0x18] PB8_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $19 constant SYSTEM_CTRL_PB9_IEV            \ [0x19] PB9_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $1a constant SYSTEM_CTRL_PB10_IEV           \ [0x1a] PB10_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $1b constant SYSTEM_CTRL_PB11_IEV           \ [0x1b] PB11_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $1c constant SYSTEM_CTRL_PB12_IEV           \ [0x1c] PB12_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $1d constant SYSTEM_CTRL_PB13_IEV           \ [0x1d] PB13_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $1e constant SYSTEM_CTRL_PB14_IEV           \ [0x1e] PB14_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
    $1f constant SYSTEM_CTRL_PB15_IEV           \ [0x1f] PB15_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
  [then]


  [ifdef] SYSTEM_CTRL_IO_IER_DEF
    \
    \ @brief IO_IER register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SYSTEM_CTRL_PA0_IE             \ [0x00] PA0_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $01 constant SYSTEM_CTRL_PA1_IE             \ [0x01] PA1_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $02 constant SYSTEM_CTRL_PA2_IE             \ [0x02] PA2_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $03 constant SYSTEM_CTRL_PA3_IE             \ [0x03] PA3_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $04 constant SYSTEM_CTRL_PA4_IE             \ [0x04] PA4_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $05 constant SYSTEM_CTRL_PA5_IE             \ [0x05] PA5_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $06 constant SYSTEM_CTRL_PA6_IE             \ [0x06] PA6_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $07 constant SYSTEM_CTRL_PA7_IE             \ [0x07] PA7_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $08 constant SYSTEM_CTRL_PA8_IE             \ [0x08] PA8_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $09 constant SYSTEM_CTRL_PA9_IE             \ [0x09] PA9_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $0a constant SYSTEM_CTRL_PA10_IE            \ [0x0a] PA10_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $0b constant SYSTEM_CTRL_PA11_IE            \ [0x0b] PA11_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $0c constant SYSTEM_CTRL_PA12_IE            \ [0x0c] PA12_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $0d constant SYSTEM_CTRL_PA13_IE            \ [0x0d] PA13_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $0e constant SYSTEM_CTRL_PA14_IE            \ [0x0e] PA14_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $0f constant SYSTEM_CTRL_PA15_IE            \ [0x0f] PA15_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $10 constant SYSTEM_CTRL_PB0_IE             \ [0x10] PB0_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $11 constant SYSTEM_CTRL_PB1_IE             \ [0x11] PB1_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $12 constant SYSTEM_CTRL_PB2_IE             \ [0x12] PB2_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $13 constant SYSTEM_CTRL_PB3_IE             \ [0x13] PB3_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $14 constant SYSTEM_CTRL_PB4_IE             \ [0x14] PB4_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $15 constant SYSTEM_CTRL_PB5_IE             \ [0x15] PB5_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $16 constant SYSTEM_CTRL_PB6_IE             \ [0x16] PB6_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $17 constant SYSTEM_CTRL_PB7_IE             \ [0x17] PB7_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $18 constant SYSTEM_CTRL_PB8_IE             \ [0x18] PB8_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $19 constant SYSTEM_CTRL_PB9_IE             \ [0x19] PB9_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $1a constant SYSTEM_CTRL_PB10_IE            \ [0x1a] PB10_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $1b constant SYSTEM_CTRL_PB11_IE            \ [0x1b] PB11_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $1c constant SYSTEM_CTRL_PB12_IE            \ [0x1c] PB12_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $1d constant SYSTEM_CTRL_PB13_IE            \ [0x1d] PB13_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $1e constant SYSTEM_CTRL_PB14_IE            \ [0x1e] PB14_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
    $1f constant SYSTEM_CTRL_PB15_IE            \ [0x1f] PB15_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
  [then]


  [ifdef] SYSTEM_CTRL_IO_ISCR_DEF
    \
    \ @brief IO_ISCR register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SYSTEM_CTRL_PA0_ISC            \ [0x00] PA0_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $01 constant SYSTEM_CTRL_PA1_ISC            \ [0x01] PA1_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $02 constant SYSTEM_CTRL_PA2_ISC            \ [0x02] PA2_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $03 constant SYSTEM_CTRL_PA3_ISC            \ [0x03] PA3_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $04 constant SYSTEM_CTRL_PA4_ISC            \ [0x04] PA4_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $05 constant SYSTEM_CTRL_PA5_ISC            \ [0x05] PA5_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $06 constant SYSTEM_CTRL_PA6_ISC            \ [0x06] PA6_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $07 constant SYSTEM_CTRL_PA7_ISC            \ [0x07] PA7_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $08 constant SYSTEM_CTRL_PA8_ISC            \ [0x08] PA8_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $09 constant SYSTEM_CTRL_PA9_ISC            \ [0x09] PA9_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $0a constant SYSTEM_CTRL_PA10_ISC           \ [0x0a] PA10_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $0b constant SYSTEM_CTRL_PA11_ISC           \ [0x0b] PA11_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $0c constant SYSTEM_CTRL_PA12_ISC           \ [0x0c] PA12_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $0d constant SYSTEM_CTRL_PA13_ISC           \ [0x0d] PA13_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $0e constant SYSTEM_CTRL_PA14_ISC           \ [0x0e] PA14_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $0f constant SYSTEM_CTRL_PA15_ISC           \ [0x0f] PA15_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $10 constant SYSTEM_CTRL_PB0_ISC            \ [0x10] PB0_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $11 constant SYSTEM_CTRL_PB1_ISC            \ [0x11] PB1_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $12 constant SYSTEM_CTRL_PB2_ISC            \ [0x12] PB2_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $13 constant SYSTEM_CTRL_PB3_ISC            \ [0x13] PB3_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $14 constant SYSTEM_CTRL_PB4_ISC            \ [0x14] PB4_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $15 constant SYSTEM_CTRL_PB5_ISC            \ [0x15] PB5_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $16 constant SYSTEM_CTRL_PB6_ISC            \ [0x16] PB6_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $17 constant SYSTEM_CTRL_PB7_ISC            \ [0x17] PB7_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $18 constant SYSTEM_CTRL_PB8_ISC            \ [0x18] PB8_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $19 constant SYSTEM_CTRL_PB9_ISC            \ [0x19] PB9_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $1a constant SYSTEM_CTRL_PB10_ISC           \ [0x1a] PB10_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $1b constant SYSTEM_CTRL_PB11_ISC           \ [0x1b] PB11_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $1c constant SYSTEM_CTRL_PB12_ISC           \ [0x1c] PB12_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $1d constant SYSTEM_CTRL_PB13_ISC           \ [0x1d] PB13_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $1e constant SYSTEM_CTRL_PB14_ISC           \ [0x1e] PB14_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $1f constant SYSTEM_CTRL_PB15_ISC           \ [0x1f] PB15_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
  [then]


  [ifdef] SYSTEM_CTRL_PWRC_IER_DEF
    \
    \ @brief PWRC_IER register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SYSTEM_CTRL_BORH_IE            \ [0x00] BORH_IE: BORH interrupt enable. 0: BORH interrupt is disabled. 1: BORH interrupt is enabled.
    $01 constant SYSTEM_CTRL_PVD_IE             \ [0x01] PVD_IE: Programmable Voltage Detector interrupt enable. 0: PVD interrupt is disabled. 1: PVD interrupt is enabled.
    $02 constant SYSTEM_CTRL_WKUP_IE            \ [0x02] WKUP_IE: Power Controller Wakeup event interrupt enable. 0: Interrupt on wakeup event seen by the PWRC is disabled. 1: Interrupt on wakeup event seen by the PWRC is enabled.
  [then]


  [ifdef] SYSTEM_CTRL_PWRC_ISCR_DEF
    \
    \ @brief PWRC_ISCR register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SYSTEM_CTRL_BORH_ISC           \ [0x00] BORH_ISC: BORH interrupt status. 0: no pending interrupt. 1: voltage went under BORH threshold / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $01 constant SYSTEM_CTRL_PVD_ISC            \ [0x01] PVD_ISC: Programmable Voltage Detector status. 0: no pending interrupt. 1: voltage went under programmed threshold / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
    $02 constant SYSTEM_CTRL_WKUP_ISC           \ [0x02] WKUP_ISC: Indicates the Power Controller receives a Wakeup event. 0: no pending interrupt. 1: Wakeup event on PWRC occurred / interrupt occurred (if enabled). Cleared by writing 1 in the bit. This flag will be read at 1 if a wakeup event arrives so close to the low power mode entry requests that the PWRC aborts before shutting down the system.
  [then]


  [ifdef] SYSTEM_CTRL_GPIO_SWA_CTRL_DEF
    \
    \ @brief GPIO_SWA_CTRL register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant SYSTEM_CTRL_ATB1_nPVD          \ [0x00] ATB1_nPVD: select the analog feature on PB14 between ATB1 and PVD when the PB14 I/O is programmed in analog mode (in the associated GPIO_MODER register): 0: PVD external voltage feature is selected (default). 1: ATB1 feature is selected
  [then]


  [ifdef] SYSTEM_CTRL_INTAI_DTR_DEF
    \
    \ @brief INTAI_DTR register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant SYSTEM_CTRL_TX_DT              \ [0x00] TX_DT: detection type on TX_SEQUENCE signal: 0: detection on edge (default). 1: detection on level
    $01 constant SYSTEM_CTRL_RX_DT              \ [0x01] RX_DT: detection type on RX_SEQUENCE signal: 0: detection on edge (default). 1: detection on level
    $04 constant SYSTEM_CTRL_COMP_DT            \ [0x04] COMP_DT: detection type on COMP_OUT (after COMP_POL selection) signal: 0: detection on edge (default). 1: detection on level
    $05 constant SYSTEM_CTRL_RFIP_BUSY_STATUS_DT     \ [0x05] RFIP_BUSY_STATUS_DT: detection type on RFIP_BUSY_STATUS signal: 0: detection on edge (default). 1: detection on level
  [then]


  [ifdef] SYSTEM_CTRL_INTAI_IBER_DEF
    \
    \ @brief INTAI_IBER register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant SYSTEM_CTRL_TX_IBE             \ [0x00] TX_IBE: interrupt edge register on TX_SEQUENCE signal: 0: detection on single edge (default). 1: detection on both edges
    $01 constant SYSTEM_CTRL_RX_IBE             \ [0x01] RX_IBE: interrupt edge register on RX_SEQUENCE signal: 0: detection on single edge (default). 1: detection on both edges
    $04 constant SYSTEM_CTRL_COMP_IBE           \ [0x04] COMP_IBE: interrupt edge register on COMP_OUT signal: 0: detection on single edge (default). 1: detection on both edges
    $05 constant SYSTEM_CTRL_RFIP_BUSY_STATUS_IBE     \ [0x05] RFIP_BUSY_STATUS_IBE: interrupt edge register on RFIP_BUSY_STATUS signal: 0: detection on single edge (default). 1: detection on both edges
  [then]


  [ifdef] SYSTEM_CTRL_INTAI_IEVR_DEF
    \
    \ @brief INTAI_IEVR register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant SYSTEM_CTRL_TX_IEV             \ [0x00] TX_IEV: interrupt polarity event on TX_SEQUENCE signal: 0: detection on falling edge / low level (default). 1: detection on rising edge / high level
    $01 constant SYSTEM_CTRL_RX_IEV             \ [0x01] RX_IEV: interrupt polarity event on RX_SEQUENCE signal: 0: detection on falling edge / low level (default). 1: detection on rising edge / high level
    $04 constant SYSTEM_CTRL_COMP_IEV           \ [0x04] COMP_IEV: interrupt polarity event on COMP_OUT signal: 0: detection on falling edge / low level (default). 1: detection on rising edge / high level
    $05 constant SYSTEM_CTRL_RFIP_BUSY_STATUS_IEV     \ [0x05] RFIP_BUSY_STATUS_IEV: interrupt polarity event on RFIP_BUSY_STATUS signal: 0: detection on falling edge / low level (default). 1: detection on rising edge / high level
  [then]


  [ifdef] SYSTEM_CTRL_INTAI_IER_DEF
    \
    \ @brief INTAI_IER register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant SYSTEM_CTRL_TX_IE              \ [0x00] TX_IE: interrupt enable on TX_SEQUENCE signal: 0: TX_SEQUENCE interrupt is disabled (default). 1: TX_SEQUENCE interrupt is enabled
    $01 constant SYSTEM_CTRL_RX_IE              \ [0x01] RX_IE: interrupt enable on RX_SEQUENCE signal: 0: RX_SEQUENCE interrupt is disabled (default). 1: RX_SEQUENCE interrupt is enabled
    $04 constant SYSTEM_CTRL_COMP_IE            \ [0x04] COMP_IE: interrupt enable on COMP_OUT signal: 0: COMP_OUT interrupt is disabled (default). 1: COMP_OUT interrupt is enabled
    $05 constant SYSTEM_CTRL_RFIP_BUSY_STATUS_IE     \ [0x05] RFIP_BUSY_STATUS_IE: interrupt enable on RFIP_BUSY_STATUS signal: 0: RFIP_BUSY_STATUS interrupt is disabled (default). 1: RFIP_BUSY_STATUS interrupt is enabled
  [then]


  [ifdef] SYSTEM_CTRL_INTAI_ISCR_DEF
    \
    \ @brief INTAI_ISCR register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant SYSTEM_CTRL_TX_ISC             \ [0x00] TX_ISC:interrupt status on TX_SEQUENCE signal (can be a rising or a falling edge depending on BLERXTX_IEVR and BLERXTX_IBER): 0: no activity on TX_SEQUENCE detected. 1: activity on TX_SEQUENCE occurred
    $01 constant SYSTEM_CTRL_RX_ISC             \ [0x01] RX_ISC: interrupt status on RX_SEQUENCE signal (can be a rising or a falling edge depending on BLERXTX_IEVR and BLERXTX_IBER): 0: no activity on RX_SEQUENCE detected. 1: activity on RX_SEQUENCE occurred
    $02 constant SYSTEM_CTRL_TX_ISEDGE          \ [0x02] TX_ISEDGE: interrupt edge status on TX_SEQUENCE signal: 0: falling edge on TX_SEQUENCE detected. 1: rising edge on TX_SEQUENCE detected.
    $03 constant SYSTEM_CTRL_RX_ISEDGE          \ [0x03] RX_ISEDGE: interrupt edge status on RX_SEQUENCE signal: 0: falling edge on RX_SEQUENCE detected. 1: rising edge on RX_SEQUENCE detected.
    $04 constant SYSTEM_CTRL_COMP_ISC           \ [0x04] COMP_ISC: interrupt status on COMP_OUT (can be a rising or a falling edge depending on INTAI_IEVR and INTAI_IBER): 0: no activity on COMP_OUT detected. 1: activity on COMP_OUT occurred
    $05 constant SYSTEM_CTRL_RFIP_BUSY_STATUS_ISC     \ [0x05] RFIP_BUSY_STATUS_ISC: interrupt status on RFIP_BUSY_STATUS (can be a rising or a falling edge depending on INTAI_IEVR and INTAI_IBER): 0: no activity on RFIP_BUSY_STATUS detected. 1: activity on RFIP_BUSY_STATUS occurred
  [then]


  [ifdef] SYSTEM_CTRL_SYSCFG_SR1_DEF
    \
    \ @brief SYSCFG_SR1 register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $05 constant SYSTEM_CTRL_RFIP_BUSY_STATUS   \ [0x05] RFIP_BUSY_STATUS: MR_SUBG BUSY status: Software should check that MR_SUBG IP is not busy (or relay on the related interrupt) before to initiate any system clock frequency switch to operate the switching in a safe way. 0: MR_SUBG is not busy. 1: MR_SUBG is busy
  [then]


  [ifdef] SYSTEM_CTRL_RF_DTB_CONFIG_DEF
    \
    \ @brief RF_DTB_CONFIG register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant SYSTEM_CTRL_RF_DTB_CONFIG      \ [0x00 : 2] Controlling AF7 extended mode: - 00 : MR_SUBG DTB default configuration - 01 : MR_SUBG DTB shuffled configuration - 10 : BUBBLE_DTB configuration - 11 : MR_SUBG DTB default configuration (as per 00)
  [then]

  \
  \ @brief DIE_ID register
  \
  $00 constant SYSTEM_CTRL_DIE_ID       \ DIE_ID register
  $04 constant SYSTEM_CTRL_JTAG_ID      \ JTAG_ID register
  $08 constant SYSTEM_CTRL_I2C_FMP_CTRL \ I2C_FMP_CTRL register
  $0C constant SYSTEM_CTRL_IO_DTR       \ IO_DTR register
  $10 constant SYSTEM_CTRL_IO_IBER      \ IO_IBER register
  $14 constant SYSTEM_CTRL_IO_IEVR      \ IO_IEVR register
  $18 constant SYSTEM_CTRL_IO_IER       \ IO_IER register
  $1C constant SYSTEM_CTRL_IO_ISCR      \ IO_ISCR register
  $20 constant SYSTEM_CTRL_PWRC_IER     \ PWRC_IER register
  $24 constant SYSTEM_CTRL_PWRC_ISCR    \ PWRC_ISCR register
  $28 constant SYSTEM_CTRL_GPIO_SWA_CTRL    \ GPIO_SWA_CTRL register
  $2C constant SYSTEM_CTRL_INTAI_DTR    \ INTAI_DTR register
  $30 constant SYSTEM_CTRL_INTAI_IBER   \ INTAI_IBER register
  $34 constant SYSTEM_CTRL_INTAI_IEVR   \ INTAI_IEVR register
  $38 constant SYSTEM_CTRL_INTAI_IER    \ INTAI_IER register
  $3C constant SYSTEM_CTRL_INTAI_ISCR   \ INTAI_ISCR register
  $40 constant SYSTEM_CTRL_SYSCFG_SR1   \ SYSCFG_SR1 register
  $44 constant SYSTEM_CTRL_RF_DTB_CONFIG    \ RF_DTB_CONFIG register

: SYSTEM_CTRL_DEF ; [then]
