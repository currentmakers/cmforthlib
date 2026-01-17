\
\ @file gpio.fs
\ @brief GPIOA interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIO_DEF

  [ifdef] GPIO_MODER_DEF
    \
    \ @brief MODER register
    \ Address offset: 0x00
    \ Reset value: 0x000000A0
    \
    $00 constant GPIO_MODE0                     \ [0x00 : 2] MODE0[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $02 constant GPIO_MODE1                     \ [0x02 : 2] MODE1[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $04 constant GPIO_MODE2                     \ [0x04 : 2] MODE2[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $06 constant GPIO_MODE3                     \ [0x06 : 2] MODE3[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $08 constant GPIO_MODE4                     \ [0x08 : 2] MODE4[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $0a constant GPIO_MODE5                     \ [0x0a : 2] MODE5[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $0c constant GPIO_MODE6                     \ [0x0c : 2] MODE6[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $0e constant GPIO_MODE7                     \ [0x0e : 2] MODE7[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $10 constant GPIO_MODE8                     \ [0x10 : 2] MODE8[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $12 constant GPIO_MODE9                     \ [0x12 : 2] MODE9[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $14 constant GPIO_MODE10                    \ [0x14 : 2] MODE10[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $16 constant GPIO_MODE11                    \ [0x16 : 2] MODE11[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $18 constant GPIO_MODE12                    \ [0x18 : 2] MODE12[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $1a constant GPIO_MODE13                    \ [0x1a : 2] MODE13[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $1c constant GPIO_MODE14                    \ [0x1c : 2] MODE14[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $1e constant GPIO_MODE15                    \ [0x1e : 2] MODE15[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
  [then]


  [ifdef] GPIO_OTYPER_DEF
    \
    \ @brief OTYPER register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_OT0                       \ [0x00] OT0: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $01 constant GPIO_OT1                       \ [0x01] OT1: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $02 constant GPIO_OT2                       \ [0x02] OT2: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $03 constant GPIO_OT3                       \ [0x03] OT3: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $04 constant GPIO_OT4                       \ [0x04] OT4: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $05 constant GPIO_OT5                       \ [0x05] OT5: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $06 constant GPIO_OT6                       \ [0x06] OT6: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $07 constant GPIO_OT7                       \ [0x07] OT7: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $08 constant GPIO_OT8                       \ [0x08] OT8: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $09 constant GPIO_OT9                       \ [0x09] OT9: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $0a constant GPIO_OT10                      \ [0x0a] OT10: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $0b constant GPIO_OT11                      \ [0x0b] OT11: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $0c constant GPIO_OT12                      \ [0x0c] OT12: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $0d constant GPIO_OT13                      \ [0x0d] OT13: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $0e constant GPIO_OT14                      \ [0x0e] OT14: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $0f constant GPIO_OT15                      \ [0x0f] OT15: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
  [then]


  [ifdef] GPIO_OSPEEDR_DEF
    \
    \ @brief OSPEEDR register
    \ Address offset: 0x08
    \ Reset value: 0x00000030
    \
    $00 constant GPIO_OSPEED0                   \ [0x00 : 2] OSPEED0[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
    $02 constant GPIO_OSPEED1                   \ [0x02 : 2] OSPEED1[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
    $04 constant GPIO_OSPEED2                   \ [0x04 : 2] OSPEED2[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
    $06 constant GPIO_OSPEED3                   \ [0x06 : 2] OSPEED3[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
    $08 constant GPIO_OSPEED4                   \ [0x08 : 2] OSPEED4[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
    $0a constant GPIO_OSPEED5                   \ [0x0a : 2] OSPEED5[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
    $0c constant GPIO_OSPEED6                   \ [0x0c : 2] OSPEED6[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
    $0e constant GPIO_OSPEED7                   \ [0x0e : 2] OSPEED7[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
    $10 constant GPIO_OSPEED8                   \ [0x10 : 2] OSPEED8[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
    $12 constant GPIO_OSPEED9                   \ [0x12 : 2] OSPEED9[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
    $14 constant GPIO_OSPEED10                  \ [0x14 : 2] OSPEED10[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
    $16 constant GPIO_OSPEED11                  \ [0x16 : 2] OSPEED11[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
    $18 constant GPIO_OSPEED12                  \ [0x18 : 2] OSPEED12[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
    $1a constant GPIO_OSPEED13                  \ [0x1a : 2] OSPEED13[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
    $1c constant GPIO_OSPEED14                  \ [0x1c : 2] OSPEED14[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
    $1e constant GPIO_OSPEED15                  \ [0x1e : 2] OSPEED15[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
  [then]


  [ifdef] GPIO_PUPDR_DEF
    \
    \ @brief PUPDR register
    \ Address offset: 0x0C
    \ Reset value: 0x55555595
    \
    $00 constant GPIO_PUPD0                     \ [0x00 : 2] PUPD0: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $02 constant GPIO_PUPD1                     \ [0x02 : 2] PUPD1: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $04 constant GPIO_PUPD2                     \ [0x04 : 2] PUPD2: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $06 constant GPIO_PUPD3                     \ [0x06 : 2] PUPD3: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $08 constant GPIO_PUPD4                     \ [0x08 : 2] PUPD4: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $0a constant GPIO_PUPD5                     \ [0x0a : 2] PUPD5: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $0c constant GPIO_PUPD6                     \ [0x0c : 2] PUPD6: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $0e constant GPIO_PUPD7                     \ [0x0e : 2] PUPD7: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $10 constant GPIO_PUPD8                     \ [0x10 : 2] PUPD8: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $12 constant GPIO_PUPD9                     \ [0x12 : 2] PUPD9: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $14 constant GPIO_PUPD10                    \ [0x14 : 2] PUPD10: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $16 constant GPIO_PUPD11                    \ [0x16 : 2] PUPD11: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $18 constant GPIO_PUPD12                    \ [0x18 : 2] PUPD12: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $1a constant GPIO_PUPD13                    \ [0x1a : 2] PUPD13: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $1c constant GPIO_PUPD14                    \ [0x1c : 2] PUPD14: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $1e constant GPIO_PUPD15                    \ [0x1e : 2] PUPD15: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
  [then]


  [ifdef] GPIO_IDR_DEF
    \
    \ @brief IDR register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_ID0                       \ [0x00] ID0: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $01 constant GPIO_ID1                       \ [0x01] ID1: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $02 constant GPIO_ID2                       \ [0x02] ID2: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $03 constant GPIO_ID3                       \ [0x03] ID3: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $04 constant GPIO_ID4                       \ [0x04] ID4: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $05 constant GPIO_ID5                       \ [0x05] ID5: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $06 constant GPIO_ID6                       \ [0x06] ID6: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $07 constant GPIO_ID7                       \ [0x07] ID7: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $08 constant GPIO_ID8                       \ [0x08] ID8: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $09 constant GPIO_ID9                       \ [0x09] ID9: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $0a constant GPIO_ID10                      \ [0x0a] ID10: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $0b constant GPIO_ID11                      \ [0x0b] ID11: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $0c constant GPIO_ID12                      \ [0x0c] ID12: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $0d constant GPIO_ID13                      \ [0x0d] ID13: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $0e constant GPIO_ID14                      \ [0x0e] ID14: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $0f constant GPIO_ID15                      \ [0x0f] ID15: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
  [then]


  [ifdef] GPIO_ODR_DEF
    \
    \ @brief ODR register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_OD0                       \ [0x00] OD0: Port A output data bit These bits can be read and written by software
    $01 constant GPIO_OD1                       \ [0x01] OD1: Port A output data bit These bits can be read and written by software
    $02 constant GPIO_OD2                       \ [0x02] OD2: Port A output data bit These bits can be read and written by software
    $03 constant GPIO_OD3                       \ [0x03] OD3: Port A output data bit These bits can be read and written by software
    $04 constant GPIO_OD4                       \ [0x04] OD4: Port A output data bit These bits can be read and written by software
    $05 constant GPIO_OD5                       \ [0x05] OD5: Port A output data bit These bits can be read and written by software
    $06 constant GPIO_OD6                       \ [0x06] OD6: Port A output data bit These bits can be read and written by software
    $07 constant GPIO_OD7                       \ [0x07] OD7: Port A output data bit These bits can be read and written by software
    $08 constant GPIO_OD8                       \ [0x08] OD8: Port A output data bit These bits can be read and written by software
    $09 constant GPIO_OD9                       \ [0x09] OD9: Port A output data bit These bits can be read and written by software
    $0a constant GPIO_OD10                      \ [0x0a] OD10: Port A output data bit These bits can be read and written by software
    $0b constant GPIO_OD11                      \ [0x0b] OD11: Port A output data bit These bits can be read and written by software
    $0c constant GPIO_OD12                      \ [0x0c] OD12: Port A output data bit These bits can be read and written by software
    $0d constant GPIO_OD13                      \ [0x0d] OD13: Port A output data bit These bits can be read and written by software
    $0e constant GPIO_OD14                      \ [0x0e] OD14: Port A output data bit These bits can be read and written by software
    $0f constant GPIO_OD15                      \ [0x0f] OD15: Port A output data bit These bits can be read and written by software
  [then]


  [ifdef] GPIO_BSRR_DEF
    \
    \ @brief BSRR register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_BS0                       \ [0x00] BS0: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000. 0: No action on the corresponding ODx bit 1: Sets the corresponding ODx bit
    $01 constant GPIO_BS1                       \ [0x01] BS1: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000. 0: No action on the corresponding ODx bit 1: Sets the corresponding ODx bit
    $02 constant GPIO_BS2                       \ [0x02] BS2: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000. 0: No action on the corresponding ODx bit 1: Sets the corresponding ODx bit
    $03 constant GPIO_BS3                       \ [0x03] BS3: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000.
    $04 constant GPIO_BS4                       \ [0x04] BS4: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000.
    $05 constant GPIO_BS5                       \ [0x05] BS5: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000
    $06 constant GPIO_BS6                       \ [0x06] BS6: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000.
    $07 constant GPIO_BS7                       \ [0x07] BS7: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000
    $08 constant GPIO_BS8                       \ [0x08] BS8: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000.
    $09 constant GPIO_BS9                       \ [0x09] BS9: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000.
    $0a constant GPIO_BS10                      \ [0x0a] BS10: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000.
    $0b constant GPIO_BS11                      \ [0x0b] BS11: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000.
    $0c constant GPIO_BS12                      \ [0x0c] BS12: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000.
    $0d constant GPIO_BS13                      \ [0x0d] BS13: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000.
    $0e constant GPIO_BS14                      \ [0x0e] BS14: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000.
    $0f constant GPIO_BS15                      \ [0x0f] BS15: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000.
    $10 constant GPIO_BR0                       \ [0x10] BR0: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
    $11 constant GPIO_BR1                       \ [0x11] BR1: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
    $12 constant GPIO_BR2                       \ [0x12] BR2: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
    $13 constant GPIO_BR3                       \ [0x13] BR3: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
    $14 constant GPIO_BR4                       \ [0x14] BR4: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
    $15 constant GPIO_BR5                       \ [0x15] BR5: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
    $16 constant GPIO_BR6                       \ [0x16] BR6: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
    $17 constant GPIO_BR7                       \ [0x17] BR7: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
    $18 constant GPIO_BR8                       \ [0x18] BR8: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
    $19 constant GPIO_BR9                       \ [0x19] BR9: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
    $1a constant GPIO_BR10                      \ [0x1a] BR10: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
    $1b constant GPIO_BR11                      \ [0x1b] BR11: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
    $1c constant GPIO_BR12                      \ [0x1c] BR12: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
    $1d constant GPIO_BR13                      \ [0x1d] BR13: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
    $1e constant GPIO_BR14                      \ [0x1e] BR14: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
    $1f constant GPIO_BR15                      \ [0x1f] BR15: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
  [then]


  [ifdef] GPIO_LCKR_DEF
    \
    \ @brief LCKR register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_LCK0                      \ [0x00] LCK0: Port A lock bit 0 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $01 constant GPIO_LCK1                      \ [0x01] LCK1: Port A lock bit 1 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $02 constant GPIO_LCK2                      \ [0x02] LCK2: Port A lock bit 2 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $03 constant GPIO_LCK3                      \ [0x03] LCK3: Port A lock bit 3 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $04 constant GPIO_LCK4                      \ [0x04] LCK4: Port A lock bit 4 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $05 constant GPIO_LCK5                      \ [0x05] LCK5: Port A lock bit 5 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $06 constant GPIO_LCK6                      \ [0x06] LCK6: Port A lock bit 6 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $07 constant GPIO_LCK7                      \ [0x07] LCK7: Port A lock bit 7 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $08 constant GPIO_LCK8                      \ [0x08] LCK8: Port A lock bit 8 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $09 constant GPIO_LCK9                      \ [0x09] LCK9: Port A lock bit 9 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $0a constant GPIO_LCK10                     \ [0x0a] LCK10: Port A lock bit 10 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $0b constant GPIO_LCK11                     \ [0x0b] LCK11: Port A lock bit 11 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $0c constant GPIO_LCK12                     \ [0x0c] LCK12: Port A lock bit 12 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $0d constant GPIO_LCK13                     \ [0x0d] LCK13: Port A lock bit 13 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $0e constant GPIO_LCK14                     \ [0x0e] LCK14: Port A lock bit 14 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $0f constant GPIO_LCK15                     \ [0x0f] LCK15: Port A lock bit 15 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $10 constant GPIO_LCKK                      \ [0x10] LCKK: Lock key This bit can be read any time. It can only be modified using the lock key write sequence. -0: Port configuration lock key not active -1: Port configuration lock key active. The GPIOx_LCKR register is locked until the next MCU reset or peripheral reset. LOCK key write sequence: WR LCKR[16] = 1 + LCKR[15:0] WR LCKR[16] = 0 + LCKR[15:0] WR LCKR[16] = 1 + LCKR[15:0] RD LCKR RD LCKR[16] = 1 (this read operation is optional but it confirms that the lock is active) Note: During the LOCK key write sequence, the value of LCK[15:0] must not change. Any error in the lock sequence aborts the lock. After the first lock sequence on any bit of the port, any read access on the LCKK bit will return 1 until the next MCU reset or peripheral reset
  [then]


  [ifdef] GPIO_AFRL_DEF
    \
    \ @brief AFRL register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_AFSEL0                    \ [0x00 : 4] y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $04 constant GPIO_AFSEL1                    \ [0x04 : 4] y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $08 constant GPIO_AFSEL2                    \ [0x08 : 4] y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $0c constant GPIO_AFSEL3                    \ [0x0c : 4] y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $10 constant GPIO_AFSEL4                    \ [0x10 : 4] y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $14 constant GPIO_AFSEL5                    \ [0x14 : 4] y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $18 constant GPIO_AFSEL6                    \ [0x18 : 4] y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $1c constant GPIO_AFSEL7                    \ [0x1c : 4] y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
  [then]


  [ifdef] GPIO_AFRH_DEF
    \
    \ @brief AFRH register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_AFSEL8                    \ [0x00 : 4] y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $04 constant GPIO_AFSEL9                    \ [0x04 : 4] y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $08 constant GPIO_AFSEL10                   \ [0x08 : 4] y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $0c constant GPIO_AFSEL11                   \ [0x0c : 4] y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $10 constant GPIO_AFSEL12                   \ [0x10 : 4] y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $14 constant GPIO_AFSEL13                   \ [0x14 : 4] y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $18 constant GPIO_AFSEL14                   \ [0x18 : 4] y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $1c constant GPIO_AFSEL15                   \ [0x1c : 4] y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
  [then]


  [ifdef] GPIO_BRR_DEF
    \
    \ @brief BRR register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_BR0                       \ [0x00] BR0: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $01 constant GPIO_BR1                       \ [0x01] BR1: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $02 constant GPIO_BR2                       \ [0x02] BR2: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $03 constant GPIO_BR3                       \ [0x03] BR3: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $04 constant GPIO_BR4                       \ [0x04] BR4: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $05 constant GPIO_BR5                       \ [0x05] BR5: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $06 constant GPIO_BR6                       \ [0x06] BR6: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $07 constant GPIO_BR7                       \ [0x07] BR7: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $08 constant GPIO_BR8                       \ [0x08] BR8: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $09 constant GPIO_BR9                       \ [0x09] BR9: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $0a constant GPIO_BR10                      \ [0x0a] BR10: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $0b constant GPIO_BR11                      \ [0x0b] BR11: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $0c constant GPIO_BR12                      \ [0x0c] BR12: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $0d constant GPIO_BR13                      \ [0x0d] BR13: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $0e constant GPIO_BR14                      \ [0x0e] BR14: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $0f constant GPIO_BR15                      \ [0x0f] BR15: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
  [then]

  \
  \ @brief GPIOA interrupt
  \
  $00 constant GPIO_MODER               \ MODER register
  $04 constant GPIO_OTYPER              \ OTYPER register
  $08 constant GPIO_OSPEEDR             \ OSPEEDR register
  $0C constant GPIO_PUPDR               \ PUPDR register
  $10 constant GPIO_IDR                 \ IDR register
  $14 constant GPIO_ODR                 \ ODR register
  $18 constant GPIO_BSRR                \ BSRR register
  $1C constant GPIO_LCKR                \ LCKR register
  $20 constant GPIO_AFRL                \ AFRL register
  $24 constant GPIO_AFRH                \ AFRH register
  $28 constant GPIO_BRR                 \ BRR register

: GPIO_DEF ; [then]
