\
\ @file gpioa.fs
\ @brief GPIOA address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOA_DEF

  [ifdef] GPIOA_GPIOA_MODER_DEF
    \
    \ @brief GPIO port mode register
    \ Address offset: 0x00
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOA_MODE0                    \ [0x00 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
    $02 constant GPIOA_MODE1                    \ [0x02 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
    $04 constant GPIOA_MODE2                    \ [0x04 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
    $06 constant GPIOA_MODE3                    \ [0x06 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
    $08 constant GPIOA_MODE4                    \ [0x08 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
    $0a constant GPIOA_MODE5                    \ [0x0a : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
    $0c constant GPIOA_MODE6                    \ [0x0c : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
    $0e constant GPIOA_MODE7                    \ [0x0e : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
    $10 constant GPIOA_MODE8                    \ [0x10 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
    $12 constant GPIOA_MODE9                    \ [0x12 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
    $14 constant GPIOA_MODE10                   \ [0x14 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
    $16 constant GPIOA_MODE11                   \ [0x16 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
    $18 constant GPIOA_MODE12                   \ [0x18 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
    $1a constant GPIOA_MODE13                   \ [0x1a : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
    $1c constant GPIOA_MODE14                   \ [0x1c : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
    $1e constant GPIOA_MODE15                   \ [0x1e : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode.
  [then]


  [ifdef] GPIOA_GPIOA_OTYPER_DEF
    \
    \ @brief GPIO port output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_OT0                      \ [0x00] Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
    $01 constant GPIOA_OT1                      \ [0x01] Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
    $02 constant GPIOA_OT2                      \ [0x02] Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
    $03 constant GPIOA_OT3                      \ [0x03] Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
    $04 constant GPIOA_OT4                      \ [0x04] Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
    $05 constant GPIOA_OT5                      \ [0x05] Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
    $06 constant GPIOA_OT6                      \ [0x06] Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
    $07 constant GPIOA_OT7                      \ [0x07] Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
    $08 constant GPIOA_OT8                      \ [0x08] Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
    $09 constant GPIOA_OT9                      \ [0x09] Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
    $0a constant GPIOA_OT10                     \ [0x0a] Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
    $0b constant GPIOA_OT11                     \ [0x0b] Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
    $0c constant GPIOA_OT12                     \ [0x0c] Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
    $0d constant GPIOA_OT13                     \ [0x0d] Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
    $0e constant GPIOA_OT14                     \ [0x0e] Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
    $0f constant GPIOA_OT15                     \ [0x0f] Port x configuration I/O pin y These bits are written by software to configure the I/O output type.
  [then]


  [ifdef] GPIOA_GPIOA_OSPEEDR_DEF
    \
    \ @brief GPIO port output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_OSPEED0                  \ [0x00 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed..
    $02 constant GPIOA_OSPEED1                  \ [0x02 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed..
    $04 constant GPIOA_OSPEED2                  \ [0x04 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed..
    $06 constant GPIOA_OSPEED3                  \ [0x06 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed..
    $08 constant GPIOA_OSPEED4                  \ [0x08 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed..
    $0a constant GPIOA_OSPEED5                  \ [0x0a : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed..
    $0c constant GPIOA_OSPEED6                  \ [0x0c : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed..
    $0e constant GPIOA_OSPEED7                  \ [0x0e : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed..
    $10 constant GPIOA_OSPEED8                  \ [0x10 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed..
    $12 constant GPIOA_OSPEED9                  \ [0x12 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed..
    $14 constant GPIOA_OSPEED10                 \ [0x14 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed..
    $16 constant GPIOA_OSPEED11                 \ [0x16 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed..
    $18 constant GPIOA_OSPEED12                 \ [0x18 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed..
    $1a constant GPIOA_OSPEED13                 \ [0x1a : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed..
    $1c constant GPIOA_OSPEED14                 \ [0x1c : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed..
    $1e constant GPIOA_OSPEED15                 \ [0x1e : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed..
  [then]


  [ifdef] GPIOA_GPIOA_PUPDR_DEF
    \
    \ @brief GPIO port pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_PUPD0                    \ [0x00 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
    $02 constant GPIOA_PUPD1                    \ [0x02 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
    $04 constant GPIOA_PUPD2                    \ [0x04 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
    $06 constant GPIOA_PUPD3                    \ [0x06 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
    $08 constant GPIOA_PUPD4                    \ [0x08 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
    $0a constant GPIOA_PUPD5                    \ [0x0a : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
    $0c constant GPIOA_PUPD6                    \ [0x0c : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
    $0e constant GPIOA_PUPD7                    \ [0x0e : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
    $10 constant GPIOA_PUPD8                    \ [0x10 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
    $12 constant GPIOA_PUPD9                    \ [0x12 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
    $14 constant GPIOA_PUPD10                   \ [0x14 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
    $16 constant GPIOA_PUPD11                   \ [0x16 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
    $18 constant GPIOA_PUPD12                   \ [0x18 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
    $1a constant GPIOA_PUPD13                   \ [0x1a : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
    $1c constant GPIOA_PUPD14                   \ [0x1c : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
    $1e constant GPIOA_PUPD15                   \ [0x1e : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down
  [then]


  [ifdef] GPIOA_GPIOA_IDR_DEF
    \
    \ @brief GPIO port input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_ID0                      \ [0x00] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
    $01 constant GPIOA_ID1                      \ [0x01] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
    $02 constant GPIOA_ID2                      \ [0x02] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
    $03 constant GPIOA_ID3                      \ [0x03] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
    $04 constant GPIOA_ID4                      \ [0x04] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
    $05 constant GPIOA_ID5                      \ [0x05] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
    $06 constant GPIOA_ID6                      \ [0x06] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
    $07 constant GPIOA_ID7                      \ [0x07] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
    $08 constant GPIOA_ID8                      \ [0x08] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
    $09 constant GPIOA_ID9                      \ [0x09] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
    $0a constant GPIOA_ID10                     \ [0x0a] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
    $0b constant GPIOA_ID11                     \ [0x0b] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
    $0c constant GPIOA_ID12                     \ [0x0c] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
    $0d constant GPIOA_ID13                     \ [0x0d] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
    $0e constant GPIOA_ID14                     \ [0x0e] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
    $0f constant GPIOA_ID15                     \ [0x0f] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port.
  [then]


  [ifdef] GPIOA_GPIOA_ODR_DEF
    \
    \ @brief GPIO port output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_OD0                      \ [0x00] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
    $01 constant GPIOA_OD1                      \ [0x01] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
    $02 constant GPIOA_OD2                      \ [0x02] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
    $03 constant GPIOA_OD3                      \ [0x03] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
    $04 constant GPIOA_OD4                      \ [0x04] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
    $05 constant GPIOA_OD5                      \ [0x05] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
    $06 constant GPIOA_OD6                      \ [0x06] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
    $07 constant GPIOA_OD7                      \ [0x07] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
    $08 constant GPIOA_OD8                      \ [0x08] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
    $09 constant GPIOA_OD9                      \ [0x09] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
    $0a constant GPIOA_OD10                     \ [0x0a] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
    $0b constant GPIOA_OD11                     \ [0x0b] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
    $0c constant GPIOA_OD12                     \ [0x0c] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
    $0d constant GPIOA_OD13                     \ [0x0d] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
    $0e constant GPIOA_OD14                     \ [0x0e] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
    $0f constant GPIOA_OD15                     \ [0x0f] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR register (x = A..F).
  [then]


  [ifdef] GPIOA_GPIOA_BSRR_DEF
    \
    \ @brief GPIO port bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_BS0                      \ [0x00] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $01 constant GPIOA_BS1                      \ [0x01] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $02 constant GPIOA_BS2                      \ [0x02] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $03 constant GPIOA_BS3                      \ [0x03] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $04 constant GPIOA_BS4                      \ [0x04] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $05 constant GPIOA_BS5                      \ [0x05] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $06 constant GPIOA_BS6                      \ [0x06] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $07 constant GPIOA_BS7                      \ [0x07] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $08 constant GPIOA_BS8                      \ [0x08] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $09 constant GPIOA_BS9                      \ [0x09] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $0a constant GPIOA_BS10                     \ [0x0a] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $0b constant GPIOA_BS11                     \ [0x0b] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $0c constant GPIOA_BS12                     \ [0x0c] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $0d constant GPIOA_BS13                     \ [0x0d] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $0e constant GPIOA_BS14                     \ [0x0e] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $0f constant GPIOA_BS15                     \ [0x0f] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $10 constant GPIOA_BR0                      \ [0x10] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $11 constant GPIOA_BR1                      \ [0x11] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $12 constant GPIOA_BR2                      \ [0x12] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $13 constant GPIOA_BR3                      \ [0x13] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $14 constant GPIOA_BR4                      \ [0x14] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $15 constant GPIOA_BR5                      \ [0x15] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $16 constant GPIOA_BR6                      \ [0x16] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $17 constant GPIOA_BR7                      \ [0x17] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $18 constant GPIOA_BR8                      \ [0x18] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $19 constant GPIOA_BR9                      \ [0x19] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1a constant GPIOA_BR10                     \ [0x1a] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1b constant GPIOA_BR11                     \ [0x1b] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1c constant GPIOA_BR12                     \ [0x1c] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1d constant GPIOA_BR13                     \ [0x1d] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1e constant GPIOA_BR14                     \ [0x1e] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
    $1f constant GPIOA_BR15                     \ [0x1f] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSx and BRx are set, BSx has priority.
  [then]


  [ifdef] GPIOA_GPIOA_LCKR_DEF
    \
    \ @brief GPIO port configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_LCK0                     \ [0x00] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $01 constant GPIOA_LCK1                     \ [0x01] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $02 constant GPIOA_LCK2                     \ [0x02] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $03 constant GPIOA_LCK3                     \ [0x03] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $04 constant GPIOA_LCK4                     \ [0x04] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $05 constant GPIOA_LCK5                     \ [0x05] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $06 constant GPIOA_LCK6                     \ [0x06] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $07 constant GPIOA_LCK7                     \ [0x07] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $08 constant GPIOA_LCK8                     \ [0x08] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $09 constant GPIOA_LCK9                     \ [0x09] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $0a constant GPIOA_LCK10                    \ [0x0a] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $0b constant GPIOA_LCK11                    \ [0x0b] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $0c constant GPIOA_LCK12                    \ [0x0c] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $0d constant GPIOA_LCK13                    \ [0x0d] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $0e constant GPIOA_LCK14                    \ [0x0e] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $0f constant GPIOA_LCK15                    \ [0x0f] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0.
    $10 constant GPIOA_LCKK                     \ [0x10] Lock key This bit can be read any time. It can only be modified using the lock key write sequence. LOCK key write sequence: WR LCKR[16] = 1 + LCKR[15:0] WR LCKR[16] = 0 + LCKR[15:0] WR LCKR[16] = 1 + LCKR[15:0] RD LCKR RD LCKR[16] = 1 (this read operation is optional but it confirms that the lock is active) Note: During the LOCK key write sequence, the value of LCK[15:0] must not change. Note: Any error in the lock sequence aborts the lock. Note: After the first lock sequence on any bit of the port, any read access on the LCKK bit returns 1 until the next MCU reset or peripheral reset.
  [then]


  [ifdef] GPIOA_GPIOA_AFRL_DEF
    \
    \ @brief GPIO alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_AFSEL0                   \ [0x00 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
    $04 constant GPIOA_AFSEL1                   \ [0x04 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
    $08 constant GPIOA_AFSEL2                   \ [0x08 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
    $0c constant GPIOA_AFSEL3                   \ [0x0c : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
    $10 constant GPIOA_AFSEL4                   \ [0x10 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
    $14 constant GPIOA_AFSEL5                   \ [0x14 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
    $18 constant GPIOA_AFSEL6                   \ [0x18 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
    $1c constant GPIOA_AFSEL7                   \ [0x1c : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
  [then]


  [ifdef] GPIOA_GPIOA_AFRH_DEF
    \
    \ @brief GPIO alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_AFSEL8                   \ [0x00 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
    $04 constant GPIOA_AFSEL9                   \ [0x04 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
    $08 constant GPIOA_AFSEL10                  \ [0x08 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
    $0c constant GPIOA_AFSEL11                  \ [0x0c : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
    $10 constant GPIOA_AFSEL12                  \ [0x10 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
    $14 constant GPIOA_AFSEL13                  \ [0x14 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
    $18 constant GPIOA_AFSEL14                  \ [0x18 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
    $1c constant GPIOA_AFSEL15                  \ [0x1c : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os.
  [then]


  [ifdef] GPIOA_GPIOA_BRR_DEF
    \
    \ @brief GPIO port bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_BR0                      \ [0x00] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $01 constant GPIOA_BR1                      \ [0x01] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $02 constant GPIOA_BR2                      \ [0x02] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $03 constant GPIOA_BR3                      \ [0x03] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $04 constant GPIOA_BR4                      \ [0x04] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $05 constant GPIOA_BR5                      \ [0x05] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $06 constant GPIOA_BR6                      \ [0x06] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $07 constant GPIOA_BR7                      \ [0x07] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $08 constant GPIOA_BR8                      \ [0x08] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $09 constant GPIOA_BR9                      \ [0x09] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $0a constant GPIOA_BR10                     \ [0x0a] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $0b constant GPIOA_BR11                     \ [0x0b] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $0c constant GPIOA_BR12                     \ [0x0c] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $0d constant GPIOA_BR13                     \ [0x0d] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $0e constant GPIOA_BR14                     \ [0x0e] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
    $0f constant GPIOA_BR15                     \ [0x0f] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000.
  [then]

  \
  \ @brief GPIOA address block description
  \
  $00 constant GPIOA_GPIOA_MODER        \ GPIO port mode register
  $04 constant GPIOA_GPIOA_OTYPER       \ GPIO port output type register
  $08 constant GPIOA_GPIOA_OSPEEDR      \ GPIO port output speed register
  $0C constant GPIOA_GPIOA_PUPDR        \ GPIO port pull-up/pull-down register
  $10 constant GPIOA_GPIOA_IDR          \ GPIO port input data register
  $14 constant GPIOA_GPIOA_ODR          \ GPIO port output data register
  $18 constant GPIOA_GPIOA_BSRR         \ GPIO port bit set/reset register
  $1C constant GPIOA_GPIOA_LCKR         \ GPIO port configuration lock register
  $20 constant GPIOA_GPIOA_AFRL         \ GPIO alternate function low register
  $24 constant GPIOA_GPIOA_AFRH         \ GPIO alternate function high register
  $28 constant GPIOA_GPIOA_BRR          \ GPIO port bit reset register

: GPIOA_DEF ; [then]
