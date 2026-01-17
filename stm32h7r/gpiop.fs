\
\ @file gpiop.fs
\ @brief GPIOP address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOP_DEF

  [ifdef] GPIOP_GPIOP_MODER_DEF
    \
    \ @brief GPIO port mode register
    \ Address offset: 0x00
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOP_MODE0                    \ [0x00 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $02 constant GPIOP_MODE1                    \ [0x02 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $04 constant GPIOP_MODE2                    \ [0x04 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $06 constant GPIOP_MODE3                    \ [0x06 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $08 constant GPIOP_MODE4                    \ [0x08 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0a constant GPIOP_MODE5                    \ [0x0a : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0c constant GPIOP_MODE6                    \ [0x0c : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0e constant GPIOP_MODE7                    \ [0x0e : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $10 constant GPIOP_MODE8                    \ [0x10 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $12 constant GPIOP_MODE9                    \ [0x12 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $14 constant GPIOP_MODE10                   \ [0x14 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $16 constant GPIOP_MODE11                   \ [0x16 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $18 constant GPIOP_MODE12                   \ [0x18 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1a constant GPIOP_MODE13                   \ [0x1a : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1c constant GPIOP_MODE14                   \ [0x1c : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1e constant GPIOP_MODE15                   \ [0x1e : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
  [then]


  [ifdef] GPIOP_GPIOP_OTYPER_DEF
    \
    \ @brief GPIO port output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_OT0                      \ [0x00] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $01 constant GPIOP_OT1                      \ [0x01] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $02 constant GPIOP_OT2                      \ [0x02] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $03 constant GPIOP_OT3                      \ [0x03] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $04 constant GPIOP_OT4                      \ [0x04] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $05 constant GPIOP_OT5                      \ [0x05] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $06 constant GPIOP_OT6                      \ [0x06] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $07 constant GPIOP_OT7                      \ [0x07] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $08 constant GPIOP_OT8                      \ [0x08] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $09 constant GPIOP_OT9                      \ [0x09] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0a constant GPIOP_OT10                     \ [0x0a] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0b constant GPIOP_OT11                     \ [0x0b] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0c constant GPIOP_OT12                     \ [0x0c] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0d constant GPIOP_OT13                     \ [0x0d] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0e constant GPIOP_OT14                     \ [0x0e] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0f constant GPIOP_OT15                     \ [0x0f] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
  [then]


  [ifdef] GPIOP_GPIOP_OSPEEDR_DEF
    \
    \ @brief GPIO port output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_OSPEED0                  \ [0x00 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $02 constant GPIOP_OSPEED1                  \ [0x02 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $04 constant GPIOP_OSPEED2                  \ [0x04 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $06 constant GPIOP_OSPEED3                  \ [0x06 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $08 constant GPIOP_OSPEED4                  \ [0x08 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0a constant GPIOP_OSPEED5                  \ [0x0a : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0c constant GPIOP_OSPEED6                  \ [0x0c : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0e constant GPIOP_OSPEED7                  \ [0x0e : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $10 constant GPIOP_OSPEED8                  \ [0x10 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $12 constant GPIOP_OSPEED9                  \ [0x12 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $14 constant GPIOP_OSPEED10                 \ [0x14 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $16 constant GPIOP_OSPEED11                 \ [0x16 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $18 constant GPIOP_OSPEED12                 \ [0x18 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1a constant GPIOP_OSPEED13                 \ [0x1a : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1c constant GPIOP_OSPEED14                 \ [0x1c : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1e constant GPIOP_OSPEED15                 \ [0x1e : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
  [then]


  [ifdef] GPIOP_GPIOP_PUPDR_DEF
    \
    \ @brief GPIO port pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_PUPD0                    \ [0x00 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $02 constant GPIOP_PUPD1                    \ [0x02 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $04 constant GPIOP_PUPD2                    \ [0x04 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $06 constant GPIOP_PUPD3                    \ [0x06 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $08 constant GPIOP_PUPD4                    \ [0x08 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0a constant GPIOP_PUPD5                    \ [0x0a : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0c constant GPIOP_PUPD6                    \ [0x0c : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0e constant GPIOP_PUPD7                    \ [0x0e : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $10 constant GPIOP_PUPD8                    \ [0x10 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $12 constant GPIOP_PUPD9                    \ [0x12 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $14 constant GPIOP_PUPD10                   \ [0x14 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $16 constant GPIOP_PUPD11                   \ [0x16 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $18 constant GPIOP_PUPD12                   \ [0x18 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1a constant GPIOP_PUPD13                   \ [0x1a : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1c constant GPIOP_PUPD14                   \ [0x1c : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1e constant GPIOP_PUPD15                   \ [0x1e : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
  [then]


  [ifdef] GPIOP_GPIOP_IDR_DEF
    \
    \ @brief GPIO port input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_ID0                      \ [0x00] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $01 constant GPIOP_ID1                      \ [0x01] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $02 constant GPIOP_ID2                      \ [0x02] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $03 constant GPIOP_ID3                      \ [0x03] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $04 constant GPIOP_ID4                      \ [0x04] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $05 constant GPIOP_ID5                      \ [0x05] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $06 constant GPIOP_ID6                      \ [0x06] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $07 constant GPIOP_ID7                      \ [0x07] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $08 constant GPIOP_ID8                      \ [0x08] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $09 constant GPIOP_ID9                      \ [0x09] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0a constant GPIOP_ID10                     \ [0x0a] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0b constant GPIOP_ID11                     \ [0x0b] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0c constant GPIOP_ID12                     \ [0x0c] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0d constant GPIOP_ID13                     \ [0x0d] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0e constant GPIOP_ID14                     \ [0x0e] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0f constant GPIOP_ID15                     \ [0x0f] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
  [then]


  [ifdef] GPIOP_GPIOP_ODR_DEF
    \
    \ @brief GPIO port output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_OD0                      \ [0x00] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $01 constant GPIOP_OD1                      \ [0x01] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $02 constant GPIOP_OD2                      \ [0x02] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $03 constant GPIOP_OD3                      \ [0x03] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $04 constant GPIOP_OD4                      \ [0x04] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $05 constant GPIOP_OD5                      \ [0x05] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $06 constant GPIOP_OD6                      \ [0x06] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $07 constant GPIOP_OD7                      \ [0x07] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $08 constant GPIOP_OD8                      \ [0x08] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $09 constant GPIOP_OD9                      \ [0x09] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0a constant GPIOP_OD10                     \ [0x0a] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0b constant GPIOP_OD11                     \ [0x0b] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0c constant GPIOP_OD12                     \ [0x0c] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0d constant GPIOP_OD13                     \ [0x0d] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0e constant GPIOP_OD14                     \ [0x0e] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0f constant GPIOP_OD15                     \ [0x0f] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
  [then]


  [ifdef] GPIOP_GPIOP_BSRR_DEF
    \
    \ @brief GPIO port bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_BS0                      \ [0x00] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $01 constant GPIOP_BS1                      \ [0x01] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $02 constant GPIOP_BS2                      \ [0x02] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $03 constant GPIOP_BS3                      \ [0x03] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $04 constant GPIOP_BS4                      \ [0x04] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $05 constant GPIOP_BS5                      \ [0x05] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $06 constant GPIOP_BS6                      \ [0x06] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $07 constant GPIOP_BS7                      \ [0x07] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $08 constant GPIOP_BS8                      \ [0x08] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $09 constant GPIOP_BS9                      \ [0x09] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0a constant GPIOP_BS10                     \ [0x0a] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0b constant GPIOP_BS11                     \ [0x0b] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0c constant GPIOP_BS12                     \ [0x0c] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0d constant GPIOP_BS13                     \ [0x0d] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0e constant GPIOP_BS14                     \ [0x0e] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0f constant GPIOP_BS15                     \ [0x0f] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $10 constant GPIOP_BR0                      \ [0x10] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $11 constant GPIOP_BR1                      \ [0x11] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $12 constant GPIOP_BR2                      \ [0x12] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $13 constant GPIOP_BR3                      \ [0x13] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $14 constant GPIOP_BR4                      \ [0x14] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $15 constant GPIOP_BR5                      \ [0x15] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $16 constant GPIOP_BR6                      \ [0x16] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $17 constant GPIOP_BR7                      \ [0x17] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $18 constant GPIOP_BR8                      \ [0x18] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $19 constant GPIOP_BR9                      \ [0x19] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1a constant GPIOP_BR10                     \ [0x1a] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1b constant GPIOP_BR11                     \ [0x1b] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1c constant GPIOP_BR12                     \ [0x1c] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1d constant GPIOP_BR13                     \ [0x1d] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1e constant GPIOP_BR14                     \ [0x1e] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1f constant GPIOP_BR15                     \ [0x1f] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
  [then]


  [ifdef] GPIOP_GPIOP_LCKR_DEF
    \
    \ @brief GPIO port configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_LCK0                     \ [0x00] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $01 constant GPIOP_LCK1                     \ [0x01] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $02 constant GPIOP_LCK2                     \ [0x02] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $03 constant GPIOP_LCK3                     \ [0x03] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $04 constant GPIOP_LCK4                     \ [0x04] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $05 constant GPIOP_LCK5                     \ [0x05] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $06 constant GPIOP_LCK6                     \ [0x06] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $07 constant GPIOP_LCK7                     \ [0x07] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $08 constant GPIOP_LCK8                     \ [0x08] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $09 constant GPIOP_LCK9                     \ [0x09] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0a constant GPIOP_LCK10                    \ [0x0a] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0b constant GPIOP_LCK11                    \ [0x0b] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0c constant GPIOP_LCK12                    \ [0x0c] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0d constant GPIOP_LCK13                    \ [0x0d] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0e constant GPIOP_LCK14                    \ [0x0e] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0f constant GPIOP_LCK15                    \ [0x0f] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $10 constant GPIOP_LCKK                     \ [0x10] Lock key This bit can be read any time. It can only be modified using the lock key write sequence. - LOCK key write sequence: WR LCKR[16] = 1 + LCKR[15:0] WR LCKR[16] = 0 + LCKR[15:0] WR LCKR[16] = 1 + LCKR[15:0] - LOCK key read RD LCKR[16] = 1 (this read operation is optional but it confirms that the lock is active) Note: During the LOCK key write sequence, the value of LCK[15:0] must not change. Note: Any error in the lock sequence aborts the LOCK. Note: After the first LOCK sequence on any bit of the port, any read access on the LCKK bit returns 1 until the next MCU reset or peripheral reset.
  [then]


  [ifdef] GPIOP_GPIOP_AFRL_DEF
    \
    \ @brief GPIO alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_AFSEL0                   \ [0x00 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $04 constant GPIOP_AFSEL1                   \ [0x04 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $08 constant GPIOP_AFSEL2                   \ [0x08 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0c constant GPIOP_AFSEL3                   \ [0x0c : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $10 constant GPIOP_AFSEL4                   \ [0x10 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $14 constant GPIOP_AFSEL5                   \ [0x14 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $18 constant GPIOP_AFSEL6                   \ [0x18 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1c constant GPIOP_AFSEL7                   \ [0x1c : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
  [then]


  [ifdef] GPIOP_GPIOP_AFRH_DEF
    \
    \ @brief GPIO alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_AFSEL8                   \ [0x00 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $04 constant GPIOP_AFSEL9                   \ [0x04 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $08 constant GPIOP_AFSEL10                  \ [0x08 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0c constant GPIOP_AFSEL11                  \ [0x0c : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $10 constant GPIOP_AFSEL12                  \ [0x10 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $14 constant GPIOP_AFSEL13                  \ [0x14 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $18 constant GPIOP_AFSEL14                  \ [0x18 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1c constant GPIOP_AFSEL15                  \ [0x1c : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
  [then]


  [ifdef] GPIOP_GPIOP_BRR_DEF
    \
    \ @brief GPIO port bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_BR0                      \ [0x00] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $01 constant GPIOP_BR1                      \ [0x01] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $02 constant GPIOP_BR2                      \ [0x02] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $03 constant GPIOP_BR3                      \ [0x03] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $04 constant GPIOP_BR4                      \ [0x04] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $05 constant GPIOP_BR5                      \ [0x05] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $06 constant GPIOP_BR6                      \ [0x06] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $07 constant GPIOP_BR7                      \ [0x07] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $08 constant GPIOP_BR8                      \ [0x08] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $09 constant GPIOP_BR9                      \ [0x09] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0a constant GPIOP_BR10                     \ [0x0a] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0b constant GPIOP_BR11                     \ [0x0b] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0c constant GPIOP_BR12                     \ [0x0c] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0d constant GPIOP_BR13                     \ [0x0d] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0e constant GPIOP_BR14                     \ [0x0e] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0f constant GPIOP_BR15                     \ [0x0f] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
  [then]

  \
  \ @brief GPIOP address block description
  \
  $00 constant GPIOP_GPIOP_MODER        \ GPIO port mode register
  $04 constant GPIOP_GPIOP_OTYPER       \ GPIO port output type register
  $08 constant GPIOP_GPIOP_OSPEEDR      \ GPIO port output speed register
  $0C constant GPIOP_GPIOP_PUPDR        \ GPIO port pull-up/pull-down register
  $10 constant GPIOP_GPIOP_IDR          \ GPIO port input data register
  $14 constant GPIOP_GPIOP_ODR          \ GPIO port output data register
  $18 constant GPIOP_GPIOP_BSRR         \ GPIO port bit set/reset register
  $1C constant GPIOP_GPIOP_LCKR         \ GPIO port configuration lock register
  $20 constant GPIOP_GPIOP_AFRL         \ GPIO alternate function low register
  $24 constant GPIOP_GPIOP_AFRH         \ GPIO alternate function high register
  $28 constant GPIOP_GPIOP_BRR          \ GPIO port bit reset register

: GPIOP_DEF ; [then]
