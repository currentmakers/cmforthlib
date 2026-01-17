\
\ @file gpiob.fs
\ @brief GPIOB address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOB_DEF

  [ifdef] GPIOB_GPIOB_MODER_DEF
    \
    \ @brief GPIO port mode register
    \ Address offset: 0x00
    \ Reset value: 0xEBFFFFFF
    \
    $00 constant GPIOB_MODE0                    \ [0x00 : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to set the I/O to one of four operating modes.
    $02 constant GPIOB_MODE1                    \ [0x02 : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to set the I/O to one of four operating modes.
    $04 constant GPIOB_MODE2                    \ [0x04 : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to set the I/O to one of four operating modes.
    $06 constant GPIOB_MODE3                    \ [0x06 : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to set the I/O to one of four operating modes.
    $08 constant GPIOB_MODE4                    \ [0x08 : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to set the I/O to one of four operating modes.
    $0a constant GPIOB_MODE5                    \ [0x0a : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to set the I/O to one of four operating modes.
    $0c constant GPIOB_MODE6                    \ [0x0c : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to set the I/O to one of four operating modes.
    $0e constant GPIOB_MODE7                    \ [0x0e : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to set the I/O to one of four operating modes.
    $10 constant GPIOB_MODE8                    \ [0x10 : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to set the I/O to one of four operating modes.
    $12 constant GPIOB_MODE9                    \ [0x12 : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to set the I/O to one of four operating modes.
    $14 constant GPIOB_MODE10                   \ [0x14 : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to set the I/O to one of four operating modes.
    $16 constant GPIOB_MODE11                   \ [0x16 : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to set the I/O to one of four operating modes.
    $18 constant GPIOB_MODE12                   \ [0x18 : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to set the I/O to one of four operating modes.
    $1a constant GPIOB_MODE13                   \ [0x1a : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to set the I/O to one of four operating modes.
    $1c constant GPIOB_MODE14                   \ [0x1c : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to set the I/O to one of four operating modes.
    $1e constant GPIOB_MODE15                   \ [0x1e : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to set the I/O to one of four operating modes.
  [then]


  [ifdef] GPIOB_GPIOB_OTYPER_DEF
    \
    \ @brief GPIO port output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_OT0                      \ [0x00] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output type.
    $01 constant GPIOB_OT1                      \ [0x01] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output type.
    $02 constant GPIOB_OT2                      \ [0x02] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output type.
    $03 constant GPIOB_OT3                      \ [0x03] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output type.
    $04 constant GPIOB_OT4                      \ [0x04] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output type.
    $05 constant GPIOB_OT5                      \ [0x05] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output type.
    $06 constant GPIOB_OT6                      \ [0x06] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output type.
    $07 constant GPIOB_OT7                      \ [0x07] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output type.
    $08 constant GPIOB_OT8                      \ [0x08] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output type.
    $09 constant GPIOB_OT9                      \ [0x09] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output type.
    $0a constant GPIOB_OT10                     \ [0x0a] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output type.
    $0b constant GPIOB_OT11                     \ [0x0b] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output type.
    $0c constant GPIOB_OT12                     \ [0x0c] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output type.
    $0d constant GPIOB_OT13                     \ [0x0d] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output type.
    $0e constant GPIOB_OT14                     \ [0x0e] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output type.
    $0f constant GPIOB_OT15                     \ [0x0f] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output type.
  [then]


  [ifdef] GPIOB_GPIOB_OSPEEDR_DEF
    \
    \ @brief GPIO port output speed register
    \ Address offset: 0x08
    \ Reset value: 0x0C000000
    \
    $00 constant GPIOB_OSPEED0                  \ [0x00 : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. The FT_c GPIOs cannot be set to high speed.
    $02 constant GPIOB_OSPEED1                  \ [0x02 : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. The FT_c GPIOs cannot be set to high speed.
    $04 constant GPIOB_OSPEED2                  \ [0x04 : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. The FT_c GPIOs cannot be set to high speed.
    $06 constant GPIOB_OSPEED3                  \ [0x06 : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. The FT_c GPIOs cannot be set to high speed.
    $08 constant GPIOB_OSPEED4                  \ [0x08 : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. The FT_c GPIOs cannot be set to high speed.
    $0a constant GPIOB_OSPEED5                  \ [0x0a : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. The FT_c GPIOs cannot be set to high speed.
    $0c constant GPIOB_OSPEED6                  \ [0x0c : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. The FT_c GPIOs cannot be set to high speed.
    $0e constant GPIOB_OSPEED7                  \ [0x0e : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. The FT_c GPIOs cannot be set to high speed.
    $10 constant GPIOB_OSPEED8                  \ [0x10 : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. The FT_c GPIOs cannot be set to high speed.
    $12 constant GPIOB_OSPEED9                  \ [0x12 : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. The FT_c GPIOs cannot be set to high speed.
    $14 constant GPIOB_OSPEED10                 \ [0x14 : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. The FT_c GPIOs cannot be set to high speed.
    $16 constant GPIOB_OSPEED11                 \ [0x16 : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. The FT_c GPIOs cannot be set to high speed.
    $18 constant GPIOB_OSPEED12                 \ [0x18 : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. The FT_c GPIOs cannot be set to high speed.
    $1a constant GPIOB_OSPEED13                 \ [0x1a : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. The FT_c GPIOs cannot be set to high speed.
    $1c constant GPIOB_OSPEED14                 \ [0x1c : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. The FT_c GPIOs cannot be set to high speed.
    $1e constant GPIOB_OSPEED15                 \ [0x1e : 2] Port x configuration for I/O y (y = 15 to 0) These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. The FT_c GPIOs cannot be set to high speed.
  [then]


  [ifdef] GPIOB_GPIOB_PUPDR_DEF
    \
    \ @brief GPIO port pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x24000000
    \
    $00 constant GPIOB_PUPD0                    \ [0x00 : 2] Port x configuration I/O y (y = 15 to 0) These bits are written by software to configure the I/O pull-up or pull-down
    $02 constant GPIOB_PUPD1                    \ [0x02 : 2] Port x configuration I/O y (y = 15 to 0) These bits are written by software to configure the I/O pull-up or pull-down
    $04 constant GPIOB_PUPD2                    \ [0x04 : 2] Port x configuration I/O y (y = 15 to 0) These bits are written by software to configure the I/O pull-up or pull-down
    $06 constant GPIOB_PUPD3                    \ [0x06 : 2] Port x configuration I/O y (y = 15 to 0) These bits are written by software to configure the I/O pull-up or pull-down
    $08 constant GPIOB_PUPD4                    \ [0x08 : 2] Port x configuration I/O y (y = 15 to 0) These bits are written by software to configure the I/O pull-up or pull-down
    $0a constant GPIOB_PUPD5                    \ [0x0a : 2] Port x configuration I/O y (y = 15 to 0) These bits are written by software to configure the I/O pull-up or pull-down
    $0c constant GPIOB_PUPD6                    \ [0x0c : 2] Port x configuration I/O y (y = 15 to 0) These bits are written by software to configure the I/O pull-up or pull-down
    $0e constant GPIOB_PUPD7                    \ [0x0e : 2] Port x configuration I/O y (y = 15 to 0) These bits are written by software to configure the I/O pull-up or pull-down
    $10 constant GPIOB_PUPD8                    \ [0x10 : 2] Port x configuration I/O y (y = 15 to 0) These bits are written by software to configure the I/O pull-up or pull-down
    $12 constant GPIOB_PUPD9                    \ [0x12 : 2] Port x configuration I/O y (y = 15 to 0) These bits are written by software to configure the I/O pull-up or pull-down
    $14 constant GPIOB_PUPD10                   \ [0x14 : 2] Port x configuration I/O y (y = 15 to 0) These bits are written by software to configure the I/O pull-up or pull-down
    $16 constant GPIOB_PUPD11                   \ [0x16 : 2] Port x configuration I/O y (y = 15 to 0) These bits are written by software to configure the I/O pull-up or pull-down
    $18 constant GPIOB_PUPD12                   \ [0x18 : 2] Port x configuration I/O y (y = 15 to 0) These bits are written by software to configure the I/O pull-up or pull-down
    $1a constant GPIOB_PUPD13                   \ [0x1a : 2] Port x configuration I/O y (y = 15 to 0) These bits are written by software to configure the I/O pull-up or pull-down
    $1c constant GPIOB_PUPD14                   \ [0x1c : 2] Port x configuration I/O y (y = 15 to 0) These bits are written by software to configure the I/O pull-up or pull-down
    $1e constant GPIOB_PUPD15                   \ [0x1e : 2] Port x configuration I/O y (y = 15 to 0) These bits are written by software to configure the I/O pull-up or pull-down
  [then]


  [ifdef] GPIOB_GPIOB_IDR_DEF
    \
    \ @brief GPIO port input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_ID0                      \ [0x00] Port x input data I/O y (y = 15 to 0) These bits are read-only. They contain the input value of the corresponding I/O port.
    $01 constant GPIOB_ID1                      \ [0x01] Port x input data I/O y (y = 15 to 0) These bits are read-only. They contain the input value of the corresponding I/O port.
    $02 constant GPIOB_ID2                      \ [0x02] Port x input data I/O y (y = 15 to 0) These bits are read-only. They contain the input value of the corresponding I/O port.
    $03 constant GPIOB_ID3                      \ [0x03] Port x input data I/O y (y = 15 to 0) These bits are read-only. They contain the input value of the corresponding I/O port.
    $04 constant GPIOB_ID4                      \ [0x04] Port x input data I/O y (y = 15 to 0) These bits are read-only. They contain the input value of the corresponding I/O port.
    $05 constant GPIOB_ID5                      \ [0x05] Port x input data I/O y (y = 15 to 0) These bits are read-only. They contain the input value of the corresponding I/O port.
    $06 constant GPIOB_ID6                      \ [0x06] Port x input data I/O y (y = 15 to 0) These bits are read-only. They contain the input value of the corresponding I/O port.
    $07 constant GPIOB_ID7                      \ [0x07] Port x input data I/O y (y = 15 to 0) These bits are read-only. They contain the input value of the corresponding I/O port.
    $08 constant GPIOB_ID8                      \ [0x08] Port x input data I/O y (y = 15 to 0) These bits are read-only. They contain the input value of the corresponding I/O port.
    $09 constant GPIOB_ID9                      \ [0x09] Port x input data I/O y (y = 15 to 0) These bits are read-only. They contain the input value of the corresponding I/O port.
    $0a constant GPIOB_ID10                     \ [0x0a] Port x input data I/O y (y = 15 to 0) These bits are read-only. They contain the input value of the corresponding I/O port.
    $0b constant GPIOB_ID11                     \ [0x0b] Port x input data I/O y (y = 15 to 0) These bits are read-only. They contain the input value of the corresponding I/O port.
    $0c constant GPIOB_ID12                     \ [0x0c] Port x input data I/O y (y = 15 to 0) These bits are read-only. They contain the input value of the corresponding I/O port.
    $0d constant GPIOB_ID13                     \ [0x0d] Port x input data I/O y (y = 15 to 0) These bits are read-only. They contain the input value of the corresponding I/O port.
    $0e constant GPIOB_ID14                     \ [0x0e] Port x input data I/O y (y = 15 to 0) These bits are read-only. They contain the input value of the corresponding I/O port.
    $0f constant GPIOB_ID15                     \ [0x0f] Port x input data I/O y (y = 15 to 0) These bits are read-only. They contain the input value of the corresponding I/O port.
  [then]


  [ifdef] GPIOB_GPIOB_ODR_DEF
    \
    \ @brief GPIO port output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_OD0                      \ [0x00] Port output data I/O y (y = 15 to 0) These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $01 constant GPIOB_OD1                      \ [0x01] Port output data I/O y (y = 15 to 0) These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $02 constant GPIOB_OD2                      \ [0x02] Port output data I/O y (y = 15 to 0) These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $03 constant GPIOB_OD3                      \ [0x03] Port output data I/O y (y = 15 to 0) These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $04 constant GPIOB_OD4                      \ [0x04] Port output data I/O y (y = 15 to 0) These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $05 constant GPIOB_OD5                      \ [0x05] Port output data I/O y (y = 15 to 0) These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $06 constant GPIOB_OD6                      \ [0x06] Port output data I/O y (y = 15 to 0) These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $07 constant GPIOB_OD7                      \ [0x07] Port output data I/O y (y = 15 to 0) These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $08 constant GPIOB_OD8                      \ [0x08] Port output data I/O y (y = 15 to 0) These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $09 constant GPIOB_OD9                      \ [0x09] Port output data I/O y (y = 15 to 0) These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $0a constant GPIOB_OD10                     \ [0x0a] Port output data I/O y (y = 15 to 0) These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $0b constant GPIOB_OD11                     \ [0x0b] Port output data I/O y (y = 15 to 0) These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $0c constant GPIOB_OD12                     \ [0x0c] Port output data I/O y (y = 15 to 0) These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $0d constant GPIOB_OD13                     \ [0x0d] Port output data I/O y (y = 15 to 0) These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $0e constant GPIOB_OD14                     \ [0x0e] Port output data I/O y (y = 15 to 0) These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $0f constant GPIOB_OD15                     \ [0x0f] Port output data I/O y (y = 15 to 0) These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
  [then]


  [ifdef] GPIOB_GPIOB_BSRR_DEF
    \
    \ @brief GPIO port bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_BS0                      \ [0x00] Port x set I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $01 constant GPIOB_BS1                      \ [0x01] Port x set I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $02 constant GPIOB_BS2                      \ [0x02] Port x set I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $03 constant GPIOB_BS3                      \ [0x03] Port x set I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $04 constant GPIOB_BS4                      \ [0x04] Port x set I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $05 constant GPIOB_BS5                      \ [0x05] Port x set I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $06 constant GPIOB_BS6                      \ [0x06] Port x set I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $07 constant GPIOB_BS7                      \ [0x07] Port x set I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $08 constant GPIOB_BS8                      \ [0x08] Port x set I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $09 constant GPIOB_BS9                      \ [0x09] Port x set I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $0a constant GPIOB_BS10                     \ [0x0a] Port x set I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $0b constant GPIOB_BS11                     \ [0x0b] Port x set I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $0c constant GPIOB_BS12                     \ [0x0c] Port x set I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $0d constant GPIOB_BS13                     \ [0x0d] Port x set I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $0e constant GPIOB_BS14                     \ [0x0e] Port x set I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $0f constant GPIOB_BS15                     \ [0x0f] Port x set I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $10 constant GPIOB_BR0                      \ [0x10] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $11 constant GPIOB_BR1                      \ [0x11] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $12 constant GPIOB_BR2                      \ [0x12] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $13 constant GPIOB_BR3                      \ [0x13] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $14 constant GPIOB_BR4                      \ [0x14] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $15 constant GPIOB_BR5                      \ [0x15] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $16 constant GPIOB_BR6                      \ [0x16] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $17 constant GPIOB_BR7                      \ [0x17] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $18 constant GPIOB_BR8                      \ [0x18] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $19 constant GPIOB_BR9                      \ [0x19] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1a constant GPIOB_BR10                     \ [0x1a] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1b constant GPIOB_BR11                     \ [0x1b] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1c constant GPIOB_BR12                     \ [0x1c] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1d constant GPIOB_BR13                     \ [0x1d] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1e constant GPIOB_BR14                     \ [0x1e] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1f constant GPIOB_BR15                     \ [0x1f] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
  [then]


  [ifdef] GPIOB_GPIOB_LCKR_DEF
    \
    \ @brief GPIO port configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_LCK0                     \ [0x00] Port x lock I/O pin y (y = 15 to 0) These bits are read/write but can only be written when the LCKK bit is 0.
    $01 constant GPIOB_LCK1                     \ [0x01] Port x lock I/O pin y (y = 15 to 0) These bits are read/write but can only be written when the LCKK bit is 0.
    $02 constant GPIOB_LCK2                     \ [0x02] Port x lock I/O pin y (y = 15 to 0) These bits are read/write but can only be written when the LCKK bit is 0.
    $03 constant GPIOB_LCK3                     \ [0x03] Port x lock I/O pin y (y = 15 to 0) These bits are read/write but can only be written when the LCKK bit is 0.
    $04 constant GPIOB_LCK4                     \ [0x04] Port x lock I/O pin y (y = 15 to 0) These bits are read/write but can only be written when the LCKK bit is 0.
    $05 constant GPIOB_LCK5                     \ [0x05] Port x lock I/O pin y (y = 15 to 0) These bits are read/write but can only be written when the LCKK bit is 0.
    $06 constant GPIOB_LCK6                     \ [0x06] Port x lock I/O pin y (y = 15 to 0) These bits are read/write but can only be written when the LCKK bit is 0.
    $07 constant GPIOB_LCK7                     \ [0x07] Port x lock I/O pin y (y = 15 to 0) These bits are read/write but can only be written when the LCKK bit is 0.
    $08 constant GPIOB_LCK8                     \ [0x08] Port x lock I/O pin y (y = 15 to 0) These bits are read/write but can only be written when the LCKK bit is 0.
    $09 constant GPIOB_LCK9                     \ [0x09] Port x lock I/O pin y (y = 15 to 0) These bits are read/write but can only be written when the LCKK bit is 0.
    $0a constant GPIOB_LCK10                    \ [0x0a] Port x lock I/O pin y (y = 15 to 0) These bits are read/write but can only be written when the LCKK bit is 0.
    $0b constant GPIOB_LCK11                    \ [0x0b] Port x lock I/O pin y (y = 15 to 0) These bits are read/write but can only be written when the LCKK bit is 0.
    $0c constant GPIOB_LCK12                    \ [0x0c] Port x lock I/O pin y (y = 15 to 0) These bits are read/write but can only be written when the LCKK bit is 0.
    $0d constant GPIOB_LCK13                    \ [0x0d] Port x lock I/O pin y (y = 15 to 0) These bits are read/write but can only be written when the LCKK bit is 0.
    $0e constant GPIOB_LCK14                    \ [0x0e] Port x lock I/O pin y (y = 15 to 0) These bits are read/write but can only be written when the LCKK bit is 0.
    $0f constant GPIOB_LCK15                    \ [0x0f] Port x lock I/O pin y (y = 15 to 0) These bits are read/write but can only be written when the LCKK bit is 0.
    $10 constant GPIOB_LCKK                     \ [0x10] Lock key This bit can be read any time. It can only be modified using the lock key write sequence. LOCK key write sequence: WR LCKR[16] = 1 + LCKR[15:0] WR LCKR[16] = 0 + LCKR[15:0] WR LCKR[16] = 1 + LCKR[15:0] RD LCKR RD LCKR[16] = 1 (this read operation is optional but it confirms that the lock is active) Note: During the LOCK key write sequence, the value of LCK[15:0] must not change. Any error in the lock sequence aborts the lock. After the first lock sequence on any bit of the port, any read access on the LCKK bit returns 1 until the next MCU reset or peripheral reset.
  [then]


  [ifdef] GPIOB_GPIOB_AFRL_DEF
    \
    \ @brief GPIO alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_AFSEL0                   \ [0x00 : 4] Alternate function selection for port x pin y (y = 0 to 7) These bits are written by software to configure alternate function I/Os
    $04 constant GPIOB_AFSEL1                   \ [0x04 : 4] Alternate function selection for port x pin y (y = 0 to 7) These bits are written by software to configure alternate function I/Os
    $08 constant GPIOB_AFSEL2                   \ [0x08 : 4] Alternate function selection for port x pin y (y = 0 to 7) These bits are written by software to configure alternate function I/Os
    $0c constant GPIOB_AFSEL3                   \ [0x0c : 4] Alternate function selection for port x pin y (y = 0 to 7) These bits are written by software to configure alternate function I/Os
    $10 constant GPIOB_AFSEL4                   \ [0x10 : 4] Alternate function selection for port x pin y (y = 0 to 7) These bits are written by software to configure alternate function I/Os
    $14 constant GPIOB_AFSEL5                   \ [0x14 : 4] Alternate function selection for port x pin y (y = 0 to 7) These bits are written by software to configure alternate function I/Os
    $18 constant GPIOB_AFSEL6                   \ [0x18 : 4] Alternate function selection for port x pin y (y = 0 to 7) These bits are written by software to configure alternate function I/Os
    $1c constant GPIOB_AFSEL7                   \ [0x1c : 4] Alternate function selection for port x pin y (y = 0 to 7) These bits are written by software to configure alternate function I/Os
  [then]


  [ifdef] GPIOB_GPIOB_AFRH_DEF
    \
    \ @brief GPIO alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_AFSEL8                   \ [0x00 : 4] Alternate function selection for port x, I/O y (y = 8 to 15) These bits are written by software to configure alternate function I/Os
    $04 constant GPIOB_AFSEL9                   \ [0x04 : 4] Alternate function selection for port x, I/O y (y = 8 to 15) These bits are written by software to configure alternate function I/Os
    $08 constant GPIOB_AFSEL10                  \ [0x08 : 4] Alternate function selection for port x, I/O y (y = 8 to 15) These bits are written by software to configure alternate function I/Os
    $0c constant GPIOB_AFSEL11                  \ [0x0c : 4] Alternate function selection for port x, I/O y (y = 8 to 15) These bits are written by software to configure alternate function I/Os
    $10 constant GPIOB_AFSEL12                  \ [0x10 : 4] Alternate function selection for port x, I/O y (y = 8 to 15) These bits are written by software to configure alternate function I/Os
    $14 constant GPIOB_AFSEL13                  \ [0x14 : 4] Alternate function selection for port x, I/O y (y = 8 to 15) These bits are written by software to configure alternate function I/Os
    $18 constant GPIOB_AFSEL14                  \ [0x18 : 4] Alternate function selection for port x, I/O y (y = 8 to 15) These bits are written by software to configure alternate function I/Os
    $1c constant GPIOB_AFSEL15                  \ [0x1c : 4] Alternate function selection for port x, I/O y (y = 8 to 15) These bits are written by software to configure alternate function I/Os
  [then]


  [ifdef] GPIOB_GPIOB_BRR_DEF
    \
    \ @brief GPIO port bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_BR0                      \ [0x00] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $01 constant GPIOB_BR1                      \ [0x01] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $02 constant GPIOB_BR2                      \ [0x02] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $03 constant GPIOB_BR3                      \ [0x03] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $04 constant GPIOB_BR4                      \ [0x04] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $05 constant GPIOB_BR5                      \ [0x05] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $06 constant GPIOB_BR6                      \ [0x06] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $07 constant GPIOB_BR7                      \ [0x07] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $08 constant GPIOB_BR8                      \ [0x08] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $09 constant GPIOB_BR9                      \ [0x09] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $0a constant GPIOB_BR10                     \ [0x0a] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $0b constant GPIOB_BR11                     \ [0x0b] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $0c constant GPIOB_BR12                     \ [0x0c] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $0d constant GPIOB_BR13                     \ [0x0d] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $0e constant GPIOB_BR14                     \ [0x0e] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
    $0f constant GPIOB_BR15                     \ [0x0f] Port x reset I/O y (y = 15 to 0) These bits are write-only. A read operation always returns 0x0000.
  [then]

  \
  \ @brief GPIOB address block description
  \
  $00 constant GPIOB_GPIOB_MODER        \ GPIO port mode register
  $04 constant GPIOB_GPIOB_OTYPER       \ GPIO port output type register
  $08 constant GPIOB_GPIOB_OSPEEDR      \ GPIO port output speed register
  $0C constant GPIOB_GPIOB_PUPDR        \ GPIO port pull-up/pull-down register
  $10 constant GPIOB_GPIOB_IDR          \ GPIO port input data register
  $14 constant GPIOB_GPIOB_ODR          \ GPIO port output data register
  $18 constant GPIOB_GPIOB_BSRR         \ GPIO port bit set/reset register
  $1C constant GPIOB_GPIOB_LCKR         \ GPIO port configuration lock register
  $20 constant GPIOB_GPIOB_AFRL         \ GPIO alternate function low register
  $24 constant GPIOB_GPIOB_AFRH         \ GPIO alternate function high register
  $28 constant GPIOB_GPIOB_BRR          \ GPIO port bit reset register

: GPIOB_DEF ; [then]
