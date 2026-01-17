\
\ @file gpio.fs
\ @brief GPIO
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIO_DEF

  [ifdef] GPIO_MODER_DEF
    \
    \ @brief GPIO port mode register
    \ Address offset: 0x00
    \ Reset value: 0xABFFFFFF
    \
    $00 constant GPIO_MODE0                     \ [0x00 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
    $02 constant GPIO_MODE1                     \ [0x02 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
    $04 constant GPIO_MODE2                     \ [0x04 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
    $06 constant GPIO_MODE3                     \ [0x06 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
    $08 constant GPIO_MODE4                     \ [0x08 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
    $0a constant GPIO_MODE5                     \ [0x0a : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
    $0c constant GPIO_MODE6                     \ [0x0c : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
    $0e constant GPIO_MODE7                     \ [0x0e : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
    $10 constant GPIO_MODE8                     \ [0x10 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
    $12 constant GPIO_MODE9                     \ [0x12 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
    $14 constant GPIO_MODE10                    \ [0x14 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
    $16 constant GPIO_MODE11                    \ [0x16 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
    $18 constant GPIO_MODE12                    \ [0x18 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
    $1a constant GPIO_MODE13                    \ [0x1a : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
    $1c constant GPIO_MODE14                    \ [0x1c : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
    $1e constant GPIO_MODE15                    \ [0x1e : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O mode.
  [then]


  [ifdef] GPIO_OTYPER_DEF
    \
    \ @brief GPIO port output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_OT0                       \ [0x00] Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
    $01 constant GPIO_OT1                       \ [0x01] Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
    $02 constant GPIO_OT2                       \ [0x02] Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
    $03 constant GPIO_OT3                       \ [0x03] Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
    $04 constant GPIO_OT4                       \ [0x04] Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
    $05 constant GPIO_OT5                       \ [0x05] Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
    $06 constant GPIO_OT6                       \ [0x06] Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
    $07 constant GPIO_OT7                       \ [0x07] Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
    $08 constant GPIO_OT8                       \ [0x08] Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
    $09 constant GPIO_OT9                       \ [0x09] Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
    $0a constant GPIO_OT10                      \ [0x0a] Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
    $0b constant GPIO_OT11                      \ [0x0b] Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
    $0c constant GPIO_OT12                      \ [0x0c] Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
    $0d constant GPIO_OT13                      \ [0x0d] Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
    $0e constant GPIO_OT14                      \ [0x0e] Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
    $0f constant GPIO_OT15                      \ [0x0f] Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output type.
  [then]


  [ifdef] GPIO_OSPEEDR_DEF
    \
    \ @brief GPIO port output speed register
    \ Address offset: 0x08
    \ Reset value: 0x0C000000
    \
    $00 constant GPIO_OSPEED0                   \ [0x00 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
    $02 constant GPIO_OSPEED1                   \ [0x02 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
    $04 constant GPIO_OSPEED2                   \ [0x04 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
    $06 constant GPIO_OSPEED3                   \ [0x06 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
    $08 constant GPIO_OSPEED4                   \ [0x08 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
    $0a constant GPIO_OSPEED5                   \ [0x0a : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
    $0c constant GPIO_OSPEED6                   \ [0x0c : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
    $0e constant GPIO_OSPEED7                   \ [0x0e : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
    $10 constant GPIO_OSPEED8                   \ [0x10 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
    $12 constant GPIO_OSPEED9                   \ [0x12 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
    $14 constant GPIO_OSPEED10                  \ [0x14 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
    $16 constant GPIO_OSPEED11                  \ [0x16 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
    $18 constant GPIO_OSPEED12                  \ [0x18 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
    $1a constant GPIO_OSPEED13                  \ [0x1a : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
    $1c constant GPIO_OSPEED14                  \ [0x1c : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
    $1e constant GPIO_OSPEED15                  \ [0x1e : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
  [then]


  [ifdef] GPIO_PUPDR_DEF
    \
    \ @brief GPIO port pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x12100000
    \
    $00 constant GPIO_PUPD0                     \ [0x00 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
    $02 constant GPIO_PUPD1                     \ [0x02 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
    $04 constant GPIO_PUPD2                     \ [0x04 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
    $06 constant GPIO_PUPD3                     \ [0x06 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
    $08 constant GPIO_PUPD4                     \ [0x08 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
    $0a constant GPIO_PUPD5                     \ [0x0a : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
    $0c constant GPIO_PUPD6                     \ [0x0c : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
    $0e constant GPIO_PUPD7                     \ [0x0e : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
    $10 constant GPIO_PUPD8                     \ [0x10 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
    $12 constant GPIO_PUPD9                     \ [0x12 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
    $14 constant GPIO_PUPD10                    \ [0x14 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
    $16 constant GPIO_PUPD11                    \ [0x16 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
    $18 constant GPIO_PUPD12                    \ [0x18 : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
    $1a constant GPIO_PUPD13                    \ [0x1a : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
    $1c constant GPIO_PUPD14                    \ [0x1c : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
    $1e constant GPIO_PUPD15                    \ [0x1e : 2] [1:0]: Port x configuration bits (y = 0..15) These bits are written by software to configure the I/O pull-up or pull-down
  [then]


  [ifdef] GPIO_IDR_DEF
    \
    \ @brief GPIO port input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_ID0                       \ [0x00] Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
    $01 constant GPIO_ID1                       \ [0x01] Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
    $02 constant GPIO_ID2                       \ [0x02] Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
    $03 constant GPIO_ID3                       \ [0x03] Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
    $04 constant GPIO_ID4                       \ [0x04] Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
    $05 constant GPIO_ID5                       \ [0x05] Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
    $06 constant GPIO_ID6                       \ [0x06] Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
    $07 constant GPIO_ID7                       \ [0x07] Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
    $08 constant GPIO_ID8                       \ [0x08] Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
    $09 constant GPIO_ID9                       \ [0x09] Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
    $0a constant GPIO_ID10                      \ [0x0a] Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
    $0b constant GPIO_ID11                      \ [0x0b] Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
    $0c constant GPIO_ID12                      \ [0x0c] Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
    $0d constant GPIO_ID13                      \ [0x0d] Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
    $0e constant GPIO_ID14                      \ [0x0e] Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
    $0f constant GPIO_ID15                      \ [0x0f] Port input data bit (y = 0..15) These bits are read-only. They contain the input value of the corresponding I/O port.
  [then]


  [ifdef] GPIO_ODR_DEF
    \
    \ @brief GPIO port output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_OD0                       \ [0x00] Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
    $01 constant GPIO_OD1                       \ [0x01] Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
    $02 constant GPIO_OD2                       \ [0x02] Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
    $03 constant GPIO_OD3                       \ [0x03] Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
    $04 constant GPIO_OD4                       \ [0x04] Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
    $05 constant GPIO_OD5                       \ [0x05] Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
    $06 constant GPIO_OD6                       \ [0x06] Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
    $07 constant GPIO_OD7                       \ [0x07] Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
    $08 constant GPIO_OD8                       \ [0x08] Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
    $09 constant GPIO_OD9                       \ [0x09] Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
    $0a constant GPIO_OD10                      \ [0x0a] Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
    $0b constant GPIO_OD11                      \ [0x0b] Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
    $0c constant GPIO_OD12                      \ [0x0c] Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
    $0d constant GPIO_OD13                      \ [0x0d] Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
    $0e constant GPIO_OD14                      \ [0x0e] Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
    $0f constant GPIO_OD15                      \ [0x0f] Port output data bit These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A..F).
  [then]


  [ifdef] GPIO_BSRR_DEF
    \
    \ @brief GPIO port bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_BS0                       \ [0x00] Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
    $01 constant GPIO_BS1                       \ [0x01] Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
    $02 constant GPIO_BS2                       \ [0x02] Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
    $03 constant GPIO_BS3                       \ [0x03] Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
    $04 constant GPIO_BS4                       \ [0x04] Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
    $05 constant GPIO_BS5                       \ [0x05] Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
    $06 constant GPIO_BS6                       \ [0x06] Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
    $07 constant GPIO_BS7                       \ [0x07] Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
    $08 constant GPIO_BS8                       \ [0x08] Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
    $09 constant GPIO_BS9                       \ [0x09] Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
    $0a constant GPIO_BS10                      \ [0x0a] Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
    $0b constant GPIO_BS11                      \ [0x0b] Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
    $0c constant GPIO_BS12                      \ [0x0c] Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
    $0d constant GPIO_BS13                      \ [0x0d] Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
    $0e constant GPIO_BS14                      \ [0x0e] Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
    $0f constant GPIO_BS15                      \ [0x0f] Port x set bit y (y= 0..15) These bits are write-only. A read to these bits returns the value 0x0000.
    $10 constant GPIO_BR0                       \ [0x10] Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $11 constant GPIO_BR1                       \ [0x11] Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $12 constant GPIO_BR2                       \ [0x12] Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $13 constant GPIO_BR3                       \ [0x13] Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $14 constant GPIO_BR4                       \ [0x14] Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $15 constant GPIO_BR5                       \ [0x15] Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $16 constant GPIO_BR6                       \ [0x16] Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $17 constant GPIO_BR7                       \ [0x17] Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $18 constant GPIO_BR8                       \ [0x18] Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $19 constant GPIO_BR9                       \ [0x19] Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1a constant GPIO_BR10                      \ [0x1a] Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1b constant GPIO_BR11                      \ [0x1b] Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1c constant GPIO_BR12                      \ [0x1c] Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1d constant GPIO_BR13                      \ [0x1d] Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1e constant GPIO_BR14                      \ [0x1e] Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1f constant GPIO_BR15                      \ [0x1f] Port x reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
  [then]


  [ifdef] GPIO_LCKR_DEF
    \
    \ @brief This register is used to lock the configuration of the port bits when a correct write sequence is applied to bit 16 (LCKK). The value of bits [15:0] is used to lock the configuration of the GPIO. During the write sequence, the value of LCKR[15:0] must not change. When the LOCK sequence has been applied on a port bit, the value of this port bit can no longer be modified until the next MCU reset or peripheral reset.A specific write sequence is used to write to the GPIOx_LCKR register. Only word access (32-bit long) is allowed during this locking sequence.Each lock bit freezes a specific configuration register (control and alternate function registers).
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_LCK0                      \ [0x00] Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
    $01 constant GPIO_LCK1                      \ [0x01] Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
    $02 constant GPIO_LCK2                      \ [0x02] Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
    $03 constant GPIO_LCK3                      \ [0x03] Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
    $04 constant GPIO_LCK4                      \ [0x04] Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
    $05 constant GPIO_LCK5                      \ [0x05] Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
    $06 constant GPIO_LCK6                      \ [0x06] Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
    $07 constant GPIO_LCK7                      \ [0x07] Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
    $08 constant GPIO_LCK8                      \ [0x08] Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
    $09 constant GPIO_LCK9                      \ [0x09] Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
    $0a constant GPIO_LCK10                     \ [0x0a] Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
    $0b constant GPIO_LCK11                     \ [0x0b] Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
    $0c constant GPIO_LCK12                     \ [0x0c] Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
    $0d constant GPIO_LCK13                     \ [0x0d] Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
    $0e constant GPIO_LCK14                     \ [0x0e] Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
    $0f constant GPIO_LCK15                     \ [0x0f] Port x lock bit y (y= 0..15) These bits are read/write but can only be written when the LCKK bit is 0.
    $10 constant GPIO_LCKK                      \ [0x10] Lock key This bit can be read any time. It can only be modified using the lock key write sequence. LOCK key write sequence: WR LCKR[16] = 1 + LCKR[15:0] WR LCKR[16] = 0 + LCKR[15:0] WR LCKR[16] = 1 + LCKR[15:0] RD LCKR RD LCKR[16] = 1 (this read operation is optional but it confirms that the lock is active) Note: During the LOCK key write sequence, the value of LCK[15:0] must not change. Any error in the lock sequence aborts the lock. After the first lock sequence on any bit of the port, any read access on the LCKK bit will return 1 until the next MCU reset or peripheral reset.
  [then]


  [ifdef] GPIO_AFRL_DEF
    \
    \ @brief GPIO alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_AFSEL0                    \ [0x00 : 4] [3:0]: Alternate function selection for port x pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection:
    $04 constant GPIO_AFSEL1                    \ [0x04 : 4] [3:0]: Alternate function selection for port x pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection:
    $08 constant GPIO_AFSEL2                    \ [0x08 : 4] [3:0]: Alternate function selection for port x pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection:
    $0c constant GPIO_AFSEL3                    \ [0x0c : 4] [3:0]: Alternate function selection for port x pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection:
    $10 constant GPIO_AFSEL4                    \ [0x10 : 4] [3:0]: Alternate function selection for port x pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection:
    $14 constant GPIO_AFSEL5                    \ [0x14 : 4] [3:0]: Alternate function selection for port x pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection:
    $18 constant GPIO_AFSEL6                    \ [0x18 : 4] [3:0]: Alternate function selection for port x pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection:
    $1c constant GPIO_AFSEL7                    \ [0x1c : 4] [3:0]: Alternate function selection for port x pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection:
  [then]


  [ifdef] GPIO_AFRH_DEF
    \
    \ @brief GPIO alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_AFSEL8                    \ [0x00 : 4] [3:0]: Alternate function selection for port x pin y (y = 8..15) These bits are written by software to configure alternate function I/Os
    $04 constant GPIO_AFSEL9                    \ [0x04 : 4] [3:0]: Alternate function selection for port x pin y (y = 8..15) These bits are written by software to configure alternate function I/Os
    $08 constant GPIO_AFSEL10                   \ [0x08 : 4] [3:0]: Alternate function selection for port x pin y (y = 8..15) These bits are written by software to configure alternate function I/Os
    $0c constant GPIO_AFSEL11                   \ [0x0c : 4] [3:0]: Alternate function selection for port x pin y (y = 8..15) These bits are written by software to configure alternate function I/Os
    $10 constant GPIO_AFSEL12                   \ [0x10 : 4] [3:0]: Alternate function selection for port x pin y (y = 8..15) These bits are written by software to configure alternate function I/Os
    $14 constant GPIO_AFSEL13                   \ [0x14 : 4] [3:0]: Alternate function selection for port x pin y (y = 8..15) These bits are written by software to configure alternate function I/Os
    $18 constant GPIO_AFSEL14                   \ [0x18 : 4] [3:0]: Alternate function selection for port x pin y (y = 8..15) These bits are written by software to configure alternate function I/Os
    $1c constant GPIO_AFSEL15                   \ [0x1c : 4] [3:0]: Alternate function selection for port x pin y (y = 8..15) These bits are written by software to configure alternate function I/Os
  [then]

  \
  \ @brief GPIO
  \
  $00 constant GPIO_MODER               \ GPIO port mode register
  $04 constant GPIO_OTYPER              \ GPIO port output type register
  $08 constant GPIO_OSPEEDR             \ GPIO port output speed register
  $0C constant GPIO_PUPDR               \ GPIO port pull-up/pull-down register
  $10 constant GPIO_IDR                 \ GPIO port input data register
  $14 constant GPIO_ODR                 \ GPIO port output data register
  $18 constant GPIO_BSRR                \ GPIO port bit set/reset register
  $1C constant GPIO_LCKR                \ This register is used to lock the configuration of the port bits when a correct write sequence is applied to bit 16 (LCKK). The value of bits [15:0] is used to lock the configuration of the GPIO. During the write sequence, the value of LCKR[15:0] must not change. When the LOCK sequence has been applied on a port bit, the value of this port bit can no longer be modified until the next MCU reset or peripheral reset.A specific write sequence is used to write to the GPIOx_LCKR register. Only word access (32-bit long) is allowed during this locking sequence.Each lock bit freezes a specific configuration register (control and alternate function registers).
  $20 constant GPIO_AFRL                \ GPIO alternate function low register
  $24 constant GPIO_AFRH                \ GPIO alternate function high register

: GPIO_DEF ; [then]
