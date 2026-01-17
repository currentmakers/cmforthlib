\
\ @file gpiod.fs
\ @brief GPIOD address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOD_DEF

  [ifdef] GPIOD_GPIOD_MODER_DEF
    \
    \ @brief GPIO port mode register
    \ Address offset: 0x00
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOD_MODE0                    \ [0x00 : 2] Port x configuration for I/O y These bits are written by software to set the I/O to one of four operating modes.
    $02 constant GPIOD_MODE1                    \ [0x02 : 2] Port x configuration for I/O y These bits are written by software to set the I/O to one of four operating modes.
    $04 constant GPIOD_MODE2                    \ [0x04 : 2] Port x configuration for I/O y These bits are written by software to set the I/O to one of four operating modes.
    $06 constant GPIOD_MODE3                    \ [0x06 : 2] Port x configuration for I/O y These bits are written by software to set the I/O to one of four operating modes.
    $08 constant GPIOD_MODE4                    \ [0x08 : 2] Port x configuration for I/O y These bits are written by software to set the I/O to one of four operating modes.
    $0a constant GPIOD_MODE5                    \ [0x0a : 2] Port x configuration for I/O y These bits are written by software to set the I/O to one of four operating modes.
    $0c constant GPIOD_MODE6                    \ [0x0c : 2] Port x configuration for I/O y These bits are written by software to set the I/O to one of four operating modes.
    $0e constant GPIOD_MODE7                    \ [0x0e : 2] Port x configuration for I/O y These bits are written by software to set the I/O to one of four operating modes.
    $10 constant GPIOD_MODE8                    \ [0x10 : 2] Port x configuration for I/O y These bits are written by software to set the I/O to one of four operating modes.
    $12 constant GPIOD_MODE9                    \ [0x12 : 2] Port x configuration for I/O y These bits are written by software to set the I/O to one of four operating modes.
    $14 constant GPIOD_MODE10                   \ [0x14 : 2] Port x configuration for I/O y These bits are written by software to set the I/O to one of four operating modes.
    $16 constant GPIOD_MODE11                   \ [0x16 : 2] Port x configuration for I/O y These bits are written by software to set the I/O to one of four operating modes.
    $18 constant GPIOD_MODE12                   \ [0x18 : 2] Port x configuration for I/O y These bits are written by software to set the I/O to one of four operating modes.
    $1a constant GPIOD_MODE13                   \ [0x1a : 2] Port x configuration for I/O y These bits are written by software to set the I/O to one of four operating modes.
    $1c constant GPIOD_MODE14                   \ [0x1c : 2] Port x configuration for I/O y These bits are written by software to set the I/O to one of four operating modes.
    $1e constant GPIOD_MODE15                   \ [0x1e : 2] Port x configuration for I/O y These bits are written by software to set the I/O to one of four operating modes.
  [then]


  [ifdef] GPIOD_GPIOD_OTYPER_DEF
    \
    \ @brief GPIO port output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_OT0                      \ [0x00] Port x configuration for I/O y These bits are written by software to configure the I/O output type.
    $01 constant GPIOD_OT1                      \ [0x01] Port x configuration for I/O y These bits are written by software to configure the I/O output type.
    $02 constant GPIOD_OT2                      \ [0x02] Port x configuration for I/O y These bits are written by software to configure the I/O output type.
    $03 constant GPIOD_OT3                      \ [0x03] Port x configuration for I/O y These bits are written by software to configure the I/O output type.
    $04 constant GPIOD_OT4                      \ [0x04] Port x configuration for I/O y These bits are written by software to configure the I/O output type.
    $05 constant GPIOD_OT5                      \ [0x05] Port x configuration for I/O y These bits are written by software to configure the I/O output type.
    $06 constant GPIOD_OT6                      \ [0x06] Port x configuration for I/O y These bits are written by software to configure the I/O output type.
    $07 constant GPIOD_OT7                      \ [0x07] Port x configuration for I/O y These bits are written by software to configure the I/O output type.
    $08 constant GPIOD_OT8                      \ [0x08] Port x configuration for I/O y These bits are written by software to configure the I/O output type.
    $09 constant GPIOD_OT9                      \ [0x09] Port x configuration for I/O y These bits are written by software to configure the I/O output type.
    $0a constant GPIOD_OT10                     \ [0x0a] Port x configuration for I/O y These bits are written by software to configure the I/O output type.
    $0b constant GPIOD_OT11                     \ [0x0b] Port x configuration for I/O y These bits are written by software to configure the I/O output type.
    $0c constant GPIOD_OT12                     \ [0x0c] Port x configuration for I/O y These bits are written by software to configure the I/O output type.
    $0d constant GPIOD_OT13                     \ [0x0d] Port x configuration for I/O y These bits are written by software to configure the I/O output type.
    $0e constant GPIOD_OT14                     \ [0x0e] Port x configuration for I/O y These bits are written by software to configure the I/O output type.
    $0f constant GPIOD_OT15                     \ [0x0f] Port x configuration for I/O y These bits are written by software to configure the I/O output type.
  [then]


  [ifdef] GPIOD_GPIOD_OSPEEDR_DEF
    \
    \ @brief GPIO port output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_OSPEED0                  \ [0x00 : 2] Port x configuration for I/O y These bits are written by software to configure the I/O output speed. Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. Note: The FT_c GPIOs cannot be set to high speed.
    $02 constant GPIOD_OSPEED1                  \ [0x02 : 2] Port x configuration for I/O y These bits are written by software to configure the I/O output speed. Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. Note: The FT_c GPIOs cannot be set to high speed.
    $04 constant GPIOD_OSPEED2                  \ [0x04 : 2] Port x configuration for I/O y These bits are written by software to configure the I/O output speed. Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. Note: The FT_c GPIOs cannot be set to high speed.
    $06 constant GPIOD_OSPEED3                  \ [0x06 : 2] Port x configuration for I/O y These bits are written by software to configure the I/O output speed. Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. Note: The FT_c GPIOs cannot be set to high speed.
    $08 constant GPIOD_OSPEED4                  \ [0x08 : 2] Port x configuration for I/O y These bits are written by software to configure the I/O output speed. Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. Note: The FT_c GPIOs cannot be set to high speed.
    $0a constant GPIOD_OSPEED5                  \ [0x0a : 2] Port x configuration for I/O y These bits are written by software to configure the I/O output speed. Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. Note: The FT_c GPIOs cannot be set to high speed.
    $0c constant GPIOD_OSPEED6                  \ [0x0c : 2] Port x configuration for I/O y These bits are written by software to configure the I/O output speed. Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. Note: The FT_c GPIOs cannot be set to high speed.
    $0e constant GPIOD_OSPEED7                  \ [0x0e : 2] Port x configuration for I/O y These bits are written by software to configure the I/O output speed. Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. Note: The FT_c GPIOs cannot be set to high speed.
    $10 constant GPIOD_OSPEED8                  \ [0x10 : 2] Port x configuration for I/O y These bits are written by software to configure the I/O output speed. Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. Note: The FT_c GPIOs cannot be set to high speed.
    $12 constant GPIOD_OSPEED9                  \ [0x12 : 2] Port x configuration for I/O y These bits are written by software to configure the I/O output speed. Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. Note: The FT_c GPIOs cannot be set to high speed.
    $14 constant GPIOD_OSPEED10                 \ [0x14 : 2] Port x configuration for I/O y These bits are written by software to configure the I/O output speed. Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. Note: The FT_c GPIOs cannot be set to high speed.
    $16 constant GPIOD_OSPEED11                 \ [0x16 : 2] Port x configuration for I/O y These bits are written by software to configure the I/O output speed. Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. Note: The FT_c GPIOs cannot be set to high speed.
    $18 constant GPIOD_OSPEED12                 \ [0x18 : 2] Port x configuration for I/O y These bits are written by software to configure the I/O output speed. Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. Note: The FT_c GPIOs cannot be set to high speed.
    $1a constant GPIOD_OSPEED13                 \ [0x1a : 2] Port x configuration for I/O y These bits are written by software to configure the I/O output speed. Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. Note: The FT_c GPIOs cannot be set to high speed.
    $1c constant GPIOD_OSPEED14                 \ [0x1c : 2] Port x configuration for I/O y These bits are written by software to configure the I/O output speed. Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. Note: The FT_c GPIOs cannot be set to high speed.
    $1e constant GPIOD_OSPEED15                 \ [0x1e : 2] Port x configuration for I/O y These bits are written by software to configure the I/O output speed. Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.. Note: The FT_c GPIOs cannot be set to high speed.
  [then]


  [ifdef] GPIOD_GPIOD_PUPDR_DEF
    \
    \ @brief GPIO port pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_PUPD0                    \ [0x00 : 2] Port x configuration I/O y These bits are written by software to configure the I/O pull-up or pull-down Note: On the same pin, this pull up/down must not be activated when a pull down/up is set through the PWR_PDCRx/PWR_PUCRx registers.
    $02 constant GPIOD_PUPD1                    \ [0x02 : 2] Port x configuration I/O y These bits are written by software to configure the I/O pull-up or pull-down Note: On the same pin, this pull up/down must not be activated when a pull down/up is set through the PWR_PDCRx/PWR_PUCRx registers.
    $04 constant GPIOD_PUPD2                    \ [0x04 : 2] Port x configuration I/O y These bits are written by software to configure the I/O pull-up or pull-down Note: On the same pin, this pull up/down must not be activated when a pull down/up is set through the PWR_PDCRx/PWR_PUCRx registers.
    $06 constant GPIOD_PUPD3                    \ [0x06 : 2] Port x configuration I/O y These bits are written by software to configure the I/O pull-up or pull-down Note: On the same pin, this pull up/down must not be activated when a pull down/up is set through the PWR_PDCRx/PWR_PUCRx registers.
    $08 constant GPIOD_PUPD4                    \ [0x08 : 2] Port x configuration I/O y These bits are written by software to configure the I/O pull-up or pull-down Note: On the same pin, this pull up/down must not be activated when a pull down/up is set through the PWR_PDCRx/PWR_PUCRx registers.
    $0a constant GPIOD_PUPD5                    \ [0x0a : 2] Port x configuration I/O y These bits are written by software to configure the I/O pull-up or pull-down Note: On the same pin, this pull up/down must not be activated when a pull down/up is set through the PWR_PDCRx/PWR_PUCRx registers.
    $0c constant GPIOD_PUPD6                    \ [0x0c : 2] Port x configuration I/O y These bits are written by software to configure the I/O pull-up or pull-down Note: On the same pin, this pull up/down must not be activated when a pull down/up is set through the PWR_PDCRx/PWR_PUCRx registers.
    $0e constant GPIOD_PUPD7                    \ [0x0e : 2] Port x configuration I/O y These bits are written by software to configure the I/O pull-up or pull-down Note: On the same pin, this pull up/down must not be activated when a pull down/up is set through the PWR_PDCRx/PWR_PUCRx registers.
    $10 constant GPIOD_PUPD8                    \ [0x10 : 2] Port x configuration I/O y These bits are written by software to configure the I/O pull-up or pull-down Note: On the same pin, this pull up/down must not be activated when a pull down/up is set through the PWR_PDCRx/PWR_PUCRx registers.
    $12 constant GPIOD_PUPD9                    \ [0x12 : 2] Port x configuration I/O y These bits are written by software to configure the I/O pull-up or pull-down Note: On the same pin, this pull up/down must not be activated when a pull down/up is set through the PWR_PDCRx/PWR_PUCRx registers.
    $14 constant GPIOD_PUPD10                   \ [0x14 : 2] Port x configuration I/O y These bits are written by software to configure the I/O pull-up or pull-down Note: On the same pin, this pull up/down must not be activated when a pull down/up is set through the PWR_PDCRx/PWR_PUCRx registers.
    $16 constant GPIOD_PUPD11                   \ [0x16 : 2] Port x configuration I/O y These bits are written by software to configure the I/O pull-up or pull-down Note: On the same pin, this pull up/down must not be activated when a pull down/up is set through the PWR_PDCRx/PWR_PUCRx registers.
    $18 constant GPIOD_PUPD12                   \ [0x18 : 2] Port x configuration I/O y These bits are written by software to configure the I/O pull-up or pull-down Note: On the same pin, this pull up/down must not be activated when a pull down/up is set through the PWR_PDCRx/PWR_PUCRx registers.
    $1a constant GPIOD_PUPD13                   \ [0x1a : 2] Port x configuration I/O y These bits are written by software to configure the I/O pull-up or pull-down Note: On the same pin, this pull up/down must not be activated when a pull down/up is set through the PWR_PDCRx/PWR_PUCRx registers.
    $1c constant GPIOD_PUPD14                   \ [0x1c : 2] Port x configuration I/O y These bits are written by software to configure the I/O pull-up or pull-down Note: On the same pin, this pull up/down must not be activated when a pull down/up is set through the PWR_PDCRx/PWR_PUCRx registers.
    $1e constant GPIOD_PUPD15                   \ [0x1e : 2] Port x configuration I/O y These bits are written by software to configure the I/O pull-up or pull-down Note: On the same pin, this pull up/down must not be activated when a pull down/up is set through the PWR_PDCRx/PWR_PUCRx registers.
  [then]


  [ifdef] GPIOD_GPIOD_IDR_DEF
    \
    \ @brief GPIO port input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_ID0                      \ [0x00] Port x input data I/O y These bits are read-only. They contain the input value of the corresponding I/O port.
    $01 constant GPIOD_ID1                      \ [0x01] Port x input data I/O y These bits are read-only. They contain the input value of the corresponding I/O port.
    $02 constant GPIOD_ID2                      \ [0x02] Port x input data I/O y These bits are read-only. They contain the input value of the corresponding I/O port.
    $03 constant GPIOD_ID3                      \ [0x03] Port x input data I/O y These bits are read-only. They contain the input value of the corresponding I/O port.
    $04 constant GPIOD_ID4                      \ [0x04] Port x input data I/O y These bits are read-only. They contain the input value of the corresponding I/O port.
    $05 constant GPIOD_ID5                      \ [0x05] Port x input data I/O y These bits are read-only. They contain the input value of the corresponding I/O port.
    $06 constant GPIOD_ID6                      \ [0x06] Port x input data I/O y These bits are read-only. They contain the input value of the corresponding I/O port.
    $07 constant GPIOD_ID7                      \ [0x07] Port x input data I/O y These bits are read-only. They contain the input value of the corresponding I/O port.
    $08 constant GPIOD_ID8                      \ [0x08] Port x input data I/O y These bits are read-only. They contain the input value of the corresponding I/O port.
    $09 constant GPIOD_ID9                      \ [0x09] Port x input data I/O y These bits are read-only. They contain the input value of the corresponding I/O port.
    $0a constant GPIOD_ID10                     \ [0x0a] Port x input data I/O y These bits are read-only. They contain the input value of the corresponding I/O port.
    $0b constant GPIOD_ID11                     \ [0x0b] Port x input data I/O y These bits are read-only. They contain the input value of the corresponding I/O port.
    $0c constant GPIOD_ID12                     \ [0x0c] Port x input data I/O y These bits are read-only. They contain the input value of the corresponding I/O port.
    $0d constant GPIOD_ID13                     \ [0x0d] Port x input data I/O y These bits are read-only. They contain the input value of the corresponding I/O port.
    $0e constant GPIOD_ID14                     \ [0x0e] Port x input data I/O y These bits are read-only. They contain the input value of the corresponding I/O port.
    $0f constant GPIOD_ID15                     \ [0x0f] Port x input data I/O y These bits are read-only. They contain the input value of the corresponding I/O port.
  [then]


  [ifdef] GPIOD_GPIOD_ODR_DEF
    \
    \ @brief GPIO port output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_OD0                      \ [0x00] Port output data I/O y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $01 constant GPIOD_OD1                      \ [0x01] Port output data I/O y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $02 constant GPIOD_OD2                      \ [0x02] Port output data I/O y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $03 constant GPIOD_OD3                      \ [0x03] Port output data I/O y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $04 constant GPIOD_OD4                      \ [0x04] Port output data I/O y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $05 constant GPIOD_OD5                      \ [0x05] Port output data I/O y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $06 constant GPIOD_OD6                      \ [0x06] Port output data I/O y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $07 constant GPIOD_OD7                      \ [0x07] Port output data I/O y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $08 constant GPIOD_OD8                      \ [0x08] Port output data I/O y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $09 constant GPIOD_OD9                      \ [0x09] Port output data I/O y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $0a constant GPIOD_OD10                     \ [0x0a] Port output data I/O y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $0b constant GPIOD_OD11                     \ [0x0b] Port output data I/O y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $0c constant GPIOD_OD12                     \ [0x0c] Port output data I/O y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $0d constant GPIOD_OD13                     \ [0x0d] Port output data I/O y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $0e constant GPIOD_OD14                     \ [0x0e] Port output data I/O y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
    $0f constant GPIOD_OD15                     \ [0x0f] Port output data I/O y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A, B, C, D, F).
  [then]


  [ifdef] GPIOD_GPIOD_BSRR_DEF
    \
    \ @brief GPIO port bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_BS0                      \ [0x00] Port x set I/O y These bits are write-only. A read operation always returns 0x0000.
    $01 constant GPIOD_BS1                      \ [0x01] Port x set I/O y These bits are write-only. A read operation always returns 0x0000.
    $02 constant GPIOD_BS2                      \ [0x02] Port x set I/O y These bits are write-only. A read operation always returns 0x0000.
    $03 constant GPIOD_BS3                      \ [0x03] Port x set I/O y These bits are write-only. A read operation always returns 0x0000.
    $04 constant GPIOD_BS4                      \ [0x04] Port x set I/O y These bits are write-only. A read operation always returns 0x0000.
    $05 constant GPIOD_BS5                      \ [0x05] Port x set I/O y These bits are write-only. A read operation always returns 0x0000.
    $06 constant GPIOD_BS6                      \ [0x06] Port x set I/O y These bits are write-only. A read operation always returns 0x0000.
    $07 constant GPIOD_BS7                      \ [0x07] Port x set I/O y These bits are write-only. A read operation always returns 0x0000.
    $08 constant GPIOD_BS8                      \ [0x08] Port x set I/O y These bits are write-only. A read operation always returns 0x0000.
    $09 constant GPIOD_BS9                      \ [0x09] Port x set I/O y These bits are write-only. A read operation always returns 0x0000.
    $0a constant GPIOD_BS10                     \ [0x0a] Port x set I/O y These bits are write-only. A read operation always returns 0x0000.
    $0b constant GPIOD_BS11                     \ [0x0b] Port x set I/O y These bits are write-only. A read operation always returns 0x0000.
    $0c constant GPIOD_BS12                     \ [0x0c] Port x set I/O y These bits are write-only. A read operation always returns 0x0000.
    $0d constant GPIOD_BS13                     \ [0x0d] Port x set I/O y These bits are write-only. A read operation always returns 0x0000.
    $0e constant GPIOD_BS14                     \ [0x0e] Port x set I/O y These bits are write-only. A read operation always returns 0x0000.
    $0f constant GPIOD_BS15                     \ [0x0f] Port x set I/O y These bits are write-only. A read operation always returns 0x0000.
    $10 constant GPIOD_BR0                      \ [0x10] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $11 constant GPIOD_BR1                      \ [0x11] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $12 constant GPIOD_BR2                      \ [0x12] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $13 constant GPIOD_BR3                      \ [0x13] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $14 constant GPIOD_BR4                      \ [0x14] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $15 constant GPIOD_BR5                      \ [0x15] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $16 constant GPIOD_BR6                      \ [0x16] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $17 constant GPIOD_BR7                      \ [0x17] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $18 constant GPIOD_BR8                      \ [0x18] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $19 constant GPIOD_BR9                      \ [0x19] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1a constant GPIOD_BR10                     \ [0x1a] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1b constant GPIOD_BR11                     \ [0x1b] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1c constant GPIOD_BR12                     \ [0x1c] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1d constant GPIOD_BR13                     \ [0x1d] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1e constant GPIOD_BR14                     \ [0x1e] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1f constant GPIOD_BR15                     \ [0x1f] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000. Note: If both BSx and BRx are set, BSx has priority.
  [then]


  [ifdef] GPIOD_GPIOD_LCKR_DEF
    \
    \ @brief GPIO port configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_LCK0                     \ [0x00] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $01 constant GPIOD_LCK1                     \ [0x01] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $02 constant GPIOD_LCK2                     \ [0x02] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $03 constant GPIOD_LCK3                     \ [0x03] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $04 constant GPIOD_LCK4                     \ [0x04] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $05 constant GPIOD_LCK5                     \ [0x05] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $06 constant GPIOD_LCK6                     \ [0x06] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $07 constant GPIOD_LCK7                     \ [0x07] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $08 constant GPIOD_LCK8                     \ [0x08] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $09 constant GPIOD_LCK9                     \ [0x09] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $0a constant GPIOD_LCK10                    \ [0x0a] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $0b constant GPIOD_LCK11                    \ [0x0b] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $0c constant GPIOD_LCK12                    \ [0x0c] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $0d constant GPIOD_LCK13                    \ [0x0d] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $0e constant GPIOD_LCK14                    \ [0x0e] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $0f constant GPIOD_LCK15                    \ [0x0f] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $10 constant GPIOD_LCKK                     \ [0x10] Lock key This bit can be read any time. It can only be modified using the lock key write sequence. LOCK key write sequence: WR LCKR[16] = 1 + LCKR[15:0] WR LCKR[16] = 0 + LCKR[15:0] WR LCKR[16] = 1 + LCKR[15:0] RD LCKR RD LCKR[16] = 1 (this read operation is optional but it confirms that the lock is active) Note: During the LOCK key write sequence, the value of LCK[15:0] must not change. Note: Any error in the lock sequence aborts the lock. Note: After the first lock sequence on any bit of the port, any read access on the LCKK bit returns 1 until the next MCU reset or peripheral reset.
  [then]


  [ifdef] GPIOD_GPIOD_AFRL_DEF
    \
    \ @brief GPIO alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_AFSEL0                   \ [0x00 : 4] Alternate function selection for port x pin y These bits are written by software to configure alternate function I/Os
    $04 constant GPIOD_AFSEL1                   \ [0x04 : 4] Alternate function selection for port x pin y These bits are written by software to configure alternate function I/Os
    $08 constant GPIOD_AFSEL2                   \ [0x08 : 4] Alternate function selection for port x pin y These bits are written by software to configure alternate function I/Os
    $0c constant GPIOD_AFSEL3                   \ [0x0c : 4] Alternate function selection for port x pin y These bits are written by software to configure alternate function I/Os
    $10 constant GPIOD_AFSEL4                   \ [0x10 : 4] Alternate function selection for port x pin y These bits are written by software to configure alternate function I/Os
    $14 constant GPIOD_AFSEL5                   \ [0x14 : 4] Alternate function selection for port x pin y These bits are written by software to configure alternate function I/Os
    $18 constant GPIOD_AFSEL6                   \ [0x18 : 4] Alternate function selection for port x pin y These bits are written by software to configure alternate function I/Os
    $1c constant GPIOD_AFSEL7                   \ [0x1c : 4] Alternate function selection for port x pin y These bits are written by software to configure alternate function I/Os
  [then]


  [ifdef] GPIOD_GPIOD_AFRH_DEF
    \
    \ @brief GPIO alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_AFSEL8                   \ [0x00 : 4] Alternate function selection for port x, I/O y These bits are written by software to configure alternate function I/Os
    $04 constant GPIOD_AFSEL9                   \ [0x04 : 4] Alternate function selection for port x, I/O y These bits are written by software to configure alternate function I/Os
    $08 constant GPIOD_AFSEL10                  \ [0x08 : 4] Alternate function selection for port x, I/O y These bits are written by software to configure alternate function I/Os
    $0c constant GPIOD_AFSEL11                  \ [0x0c : 4] Alternate function selection for port x, I/O y These bits are written by software to configure alternate function I/Os
    $10 constant GPIOD_AFSEL12                  \ [0x10 : 4] Alternate function selection for port x, I/O y These bits are written by software to configure alternate function I/Os
    $14 constant GPIOD_AFSEL13                  \ [0x14 : 4] Alternate function selection for port x, I/O y These bits are written by software to configure alternate function I/Os
    $18 constant GPIOD_AFSEL14                  \ [0x18 : 4] Alternate function selection for port x, I/O y These bits are written by software to configure alternate function I/Os
    $1c constant GPIOD_AFSEL15                  \ [0x1c : 4] Alternate function selection for port x, I/O y These bits are written by software to configure alternate function I/Os
  [then]


  [ifdef] GPIOD_GPIOD_BRR_DEF
    \
    \ @brief GPIO port bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_BR0                      \ [0x00] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000.
    $01 constant GPIOD_BR1                      \ [0x01] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000.
    $02 constant GPIOD_BR2                      \ [0x02] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000.
    $03 constant GPIOD_BR3                      \ [0x03] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000.
    $04 constant GPIOD_BR4                      \ [0x04] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000.
    $05 constant GPIOD_BR5                      \ [0x05] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000.
    $06 constant GPIOD_BR6                      \ [0x06] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000.
    $07 constant GPIOD_BR7                      \ [0x07] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000.
    $08 constant GPIOD_BR8                      \ [0x08] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000.
    $09 constant GPIOD_BR9                      \ [0x09] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000.
    $0a constant GPIOD_BR10                     \ [0x0a] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000.
    $0b constant GPIOD_BR11                     \ [0x0b] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000.
    $0c constant GPIOD_BR12                     \ [0x0c] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000.
    $0d constant GPIOD_BR13                     \ [0x0d] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000.
    $0e constant GPIOD_BR14                     \ [0x0e] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000.
    $0f constant GPIOD_BR15                     \ [0x0f] Port x reset I/O y These bits are write-only. A read operation always returns 0x0000.
  [then]

  \
  \ @brief GPIOD address block description
  \
  $00 constant GPIOD_GPIOD_MODER        \ GPIO port mode register
  $04 constant GPIOD_GPIOD_OTYPER       \ GPIO port output type register
  $08 constant GPIOD_GPIOD_OSPEEDR      \ GPIO port output speed register
  $0C constant GPIOD_GPIOD_PUPDR        \ GPIO port pull-up/pull-down register
  $10 constant GPIOD_GPIOD_IDR          \ GPIO port input data register
  $14 constant GPIOD_GPIOD_ODR          \ GPIO port output data register
  $18 constant GPIOD_GPIOD_BSRR         \ GPIO port bit set/reset register
  $1C constant GPIOD_GPIOD_LCKR         \ GPIO port configuration lock register
  $20 constant GPIOD_GPIOD_AFRL         \ GPIO alternate function low register
  $24 constant GPIOD_GPIOD_AFRH         \ GPIO alternate function high register
  $28 constant GPIOD_GPIOD_BRR          \ GPIO port bit reset register

: GPIOD_DEF ; [then]
