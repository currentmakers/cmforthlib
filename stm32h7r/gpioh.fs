\
\ @file gpioh.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOH_DEF

  [ifdef] GPIOH_GPIOH_MODER_DEF
    \
    \ @brief GPIO port mode register
    \ Address offset: 0x00
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOH_MODE0                    \ [0x00 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $02 constant GPIOH_MODE1                    \ [0x02 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $04 constant GPIOH_MODE2                    \ [0x04 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $06 constant GPIOH_MODE3                    \ [0x06 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $08 constant GPIOH_MODE4                    \ [0x08 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0a constant GPIOH_MODE5                    \ [0x0a : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0c constant GPIOH_MODE6                    \ [0x0c : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0e constant GPIOH_MODE7                    \ [0x0e : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $10 constant GPIOH_MODE8                    \ [0x10 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $12 constant GPIOH_MODE9                    \ [0x12 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $14 constant GPIOH_MODE10                   \ [0x14 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $16 constant GPIOH_MODE11                   \ [0x16 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $18 constant GPIOH_MODE12                   \ [0x18 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1a constant GPIOH_MODE13                   \ [0x1a : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1c constant GPIOH_MODE14                   \ [0x1c : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1e constant GPIOH_MODE15                   \ [0x1e : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O mode. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
  [then]


  [ifdef] GPIOH_GPIOH_OTYPER_DEF
    \
    \ @brief GPIO port output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_OT0                      \ [0x00] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $01 constant GPIOH_OT1                      \ [0x01] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $02 constant GPIOH_OT2                      \ [0x02] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $03 constant GPIOH_OT3                      \ [0x03] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $04 constant GPIOH_OT4                      \ [0x04] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $05 constant GPIOH_OT5                      \ [0x05] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $06 constant GPIOH_OT6                      \ [0x06] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $07 constant GPIOH_OT7                      \ [0x07] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $08 constant GPIOH_OT8                      \ [0x08] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $09 constant GPIOH_OT9                      \ [0x09] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0a constant GPIOH_OT10                     \ [0x0a] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0b constant GPIOH_OT11                     \ [0x0b] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0c constant GPIOH_OT12                     \ [0x0c] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0d constant GPIOH_OT13                     \ [0x0d] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0e constant GPIOH_OT14                     \ [0x0e] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0f constant GPIOH_OT15                     \ [0x0f] Port x configuration I/O pin y These bits are written by software to configure the I/O output type. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
  [then]


  [ifdef] GPIOH_GPIOH_OSPEEDR_DEF
    \
    \ @brief GPIO port output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_OSPEED0                  \ [0x00 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $02 constant GPIOH_OSPEED1                  \ [0x02 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $04 constant GPIOH_OSPEED2                  \ [0x04 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $06 constant GPIOH_OSPEED3                  \ [0x06 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $08 constant GPIOH_OSPEED4                  \ [0x08 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0a constant GPIOH_OSPEED5                  \ [0x0a : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0c constant GPIOH_OSPEED6                  \ [0x0c : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0e constant GPIOH_OSPEED7                  \ [0x0e : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $10 constant GPIOH_OSPEED8                  \ [0x10 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $12 constant GPIOH_OSPEED9                  \ [0x12 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $14 constant GPIOH_OSPEED10                 \ [0x14 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $16 constant GPIOH_OSPEED11                 \ [0x16 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $18 constant GPIOH_OSPEED12                 \ [0x18 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1a constant GPIOH_OSPEED13                 \ [0x1a : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1c constant GPIOH_OSPEED14                 \ [0x1c : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1e constant GPIOH_OSPEED15                 \ [0x1e : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O output speed. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
  [then]


  [ifdef] GPIOH_GPIOH_PUPDR_DEF
    \
    \ @brief GPIO port pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_PUPD0                    \ [0x00 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $02 constant GPIOH_PUPD1                    \ [0x02 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $04 constant GPIOH_PUPD2                    \ [0x04 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $06 constant GPIOH_PUPD3                    \ [0x06 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $08 constant GPIOH_PUPD4                    \ [0x08 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0a constant GPIOH_PUPD5                    \ [0x0a : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0c constant GPIOH_PUPD6                    \ [0x0c : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0e constant GPIOH_PUPD7                    \ [0x0e : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $10 constant GPIOH_PUPD8                    \ [0x10 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $12 constant GPIOH_PUPD9                    \ [0x12 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $14 constant GPIOH_PUPD10                   \ [0x14 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $16 constant GPIOH_PUPD11                   \ [0x16 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $18 constant GPIOH_PUPD12                   \ [0x18 : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1a constant GPIOH_PUPD13                   \ [0x1a : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1c constant GPIOH_PUPD14                   \ [0x1c : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1e constant GPIOH_PUPD15                   \ [0x1e : 2] Port x configuration I/O pin y These bits are written by software to configure the I/O pull-up or pull-down Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
  [then]


  [ifdef] GPIOH_GPIOH_IDR_DEF
    \
    \ @brief GPIO port input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_ID0                      \ [0x00] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $01 constant GPIOH_ID1                      \ [0x01] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $02 constant GPIOH_ID2                      \ [0x02] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $03 constant GPIOH_ID3                      \ [0x03] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $04 constant GPIOH_ID4                      \ [0x04] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $05 constant GPIOH_ID5                      \ [0x05] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $06 constant GPIOH_ID6                      \ [0x06] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $07 constant GPIOH_ID7                      \ [0x07] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $08 constant GPIOH_ID8                      \ [0x08] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $09 constant GPIOH_ID9                      \ [0x09] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0a constant GPIOH_ID10                     \ [0x0a] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0b constant GPIOH_ID11                     \ [0x0b] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0c constant GPIOH_ID12                     \ [0x0c] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0d constant GPIOH_ID13                     \ [0x0d] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0e constant GPIOH_ID14                     \ [0x0e] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0f constant GPIOH_ID15                     \ [0x0f] Port x input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
  [then]


  [ifdef] GPIOH_GPIOH_ODR_DEF
    \
    \ @brief GPIO port output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_OD0                      \ [0x00] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $01 constant GPIOH_OD1                      \ [0x01] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $02 constant GPIOH_OD2                      \ [0x02] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $03 constant GPIOH_OD3                      \ [0x03] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $04 constant GPIOH_OD4                      \ [0x04] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $05 constant GPIOH_OD5                      \ [0x05] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $06 constant GPIOH_OD6                      \ [0x06] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $07 constant GPIOH_OD7                      \ [0x07] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $08 constant GPIOH_OD8                      \ [0x08] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $09 constant GPIOH_OD9                      \ [0x09] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0a constant GPIOH_OD10                     \ [0x0a] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0b constant GPIOH_OD11                     \ [0x0b] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0c constant GPIOH_OD12                     \ [0x0c] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0d constant GPIOH_OD13                     \ [0x0d] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0e constant GPIOH_OD14                     \ [0x0e] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0f constant GPIOH_OD15                     \ [0x0f] Port output data I/O pin y These bits can be read and written by software. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOx_BSRR or GPIOx_BRR registers (x = A to G) (x = M to P). Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
  [then]


  [ifdef] GPIOH_GPIOH_BSRR_DEF
    \
    \ @brief GPIO port bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_BS0                      \ [0x00] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $01 constant GPIOH_BS1                      \ [0x01] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $02 constant GPIOH_BS2                      \ [0x02] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $03 constant GPIOH_BS3                      \ [0x03] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $04 constant GPIOH_BS4                      \ [0x04] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $05 constant GPIOH_BS5                      \ [0x05] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $06 constant GPIOH_BS6                      \ [0x06] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $07 constant GPIOH_BS7                      \ [0x07] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $08 constant GPIOH_BS8                      \ [0x08] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $09 constant GPIOH_BS9                      \ [0x09] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0a constant GPIOH_BS10                     \ [0x0a] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0b constant GPIOH_BS11                     \ [0x0b] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0c constant GPIOH_BS12                     \ [0x0c] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0d constant GPIOH_BS13                     \ [0x0d] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0e constant GPIOH_BS14                     \ [0x0e] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0f constant GPIOH_BS15                     \ [0x0f] Port x set I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $10 constant GPIOH_BR0                      \ [0x10] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $11 constant GPIOH_BR1                      \ [0x11] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $12 constant GPIOH_BR2                      \ [0x12] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $13 constant GPIOH_BR3                      \ [0x13] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $14 constant GPIOH_BR4                      \ [0x14] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $15 constant GPIOH_BR5                      \ [0x15] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $16 constant GPIOH_BR6                      \ [0x16] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $17 constant GPIOH_BR7                      \ [0x17] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $18 constant GPIOH_BR8                      \ [0x18] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $19 constant GPIOH_BR9                      \ [0x19] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1a constant GPIOH_BR10                     \ [0x1a] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1b constant GPIOH_BR11                     \ [0x1b] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1c constant GPIOH_BR12                     \ [0x1c] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1d constant GPIOH_BR13                     \ [0x1d] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1e constant GPIOH_BR14                     \ [0x1e] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1f constant GPIOH_BR15                     \ [0x1f] Port x reset I/O pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: If both BSy and BRy are set, BSy has priority. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
  [then]


  [ifdef] GPIOH_GPIOH_LCKR_DEF
    \
    \ @brief GPIO port configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_LCK0                     \ [0x00] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $01 constant GPIOH_LCK1                     \ [0x01] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $02 constant GPIOH_LCK2                     \ [0x02] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $03 constant GPIOH_LCK3                     \ [0x03] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $04 constant GPIOH_LCK4                     \ [0x04] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $05 constant GPIOH_LCK5                     \ [0x05] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $06 constant GPIOH_LCK6                     \ [0x06] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $07 constant GPIOH_LCK7                     \ [0x07] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $08 constant GPIOH_LCK8                     \ [0x08] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $09 constant GPIOH_LCK9                     \ [0x09] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0a constant GPIOH_LCK10                    \ [0x0a] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0b constant GPIOH_LCK11                    \ [0x0b] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0c constant GPIOH_LCK12                    \ [0x0c] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0d constant GPIOH_LCK13                    \ [0x0d] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0e constant GPIOH_LCK14                    \ [0x0e] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0f constant GPIOH_LCK15                    \ [0x0f] Port x lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $10 constant GPIOH_LCKK                     \ [0x10] Lock key This bit can be read any time. It can only be modified using the lock key write sequence. - LOCK key write sequence: WR LCKR[16] = 1 + LCKR[15:0] WR LCKR[16] = 0 + LCKR[15:0] WR LCKR[16] = 1 + LCKR[15:0] - LOCK key read RD LCKR[16] = 1 (this read operation is optional but it confirms that the lock is active) Note: During the LOCK key write sequence, the value of LCK[15:0] must not change. Note: Any error in the lock sequence aborts the LOCK. Note: After the first LOCK sequence on any bit of the port, any read access on the LCKK bit returns 1 until the next MCU reset or peripheral reset.
  [then]


  [ifdef] GPIOH_GPIOH_AFRL_DEF
    \
    \ @brief GPIO alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_AFSEL0                   \ [0x00 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $04 constant GPIOH_AFSEL1                   \ [0x04 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $08 constant GPIOH_AFSEL2                   \ [0x08 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0c constant GPIOH_AFSEL3                   \ [0x0c : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $10 constant GPIOH_AFSEL4                   \ [0x10 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $14 constant GPIOH_AFSEL5                   \ [0x14 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $18 constant GPIOH_AFSEL6                   \ [0x18 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1c constant GPIOH_AFSEL7                   \ [0x1c : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
  [then]


  [ifdef] GPIOH_GPIOH_AFRH_DEF
    \
    \ @brief GPIO alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_AFSEL8                   \ [0x00 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $04 constant GPIOH_AFSEL9                   \ [0x04 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $08 constant GPIOH_AFSEL10                  \ [0x08 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0c constant GPIOH_AFSEL11                  \ [0x0c : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $10 constant GPIOH_AFSEL12                  \ [0x10 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $14 constant GPIOH_AFSEL13                  \ [0x14 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $18 constant GPIOH_AFSEL14                  \ [0x18 : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $1c constant GPIOH_AFSEL15                  \ [0x1c : 4] Alternate function selection for port x I/O pin y These bits are written by software to configure alternate function I/Os. Note: The bitfield is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
  [then]


  [ifdef] GPIOH_GPIOH_BRR_DEF
    \
    \ @brief GPIO port bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_BR0                      \ [0x00] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $01 constant GPIOH_BR1                      \ [0x01] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $02 constant GPIOH_BR2                      \ [0x02] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $03 constant GPIOH_BR3                      \ [0x03] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $04 constant GPIOH_BR4                      \ [0x04] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $05 constant GPIOH_BR5                      \ [0x05] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $06 constant GPIOH_BR6                      \ [0x06] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $07 constant GPIOH_BR7                      \ [0x07] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $08 constant GPIOH_BR8                      \ [0x08] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $09 constant GPIOH_BR9                      \ [0x09] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0a constant GPIOH_BR10                     \ [0x0a] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0b constant GPIOH_BR11                     \ [0x0b] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0c constant GPIOH_BR12                     \ [0x0c] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0d constant GPIOH_BR13                     \ [0x0d] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0e constant GPIOH_BR14                     \ [0x0e] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
    $0f constant GPIOH_BR15                     \ [0x0f] Port x reset IO pin y These bits are write-only. A read to these bits returns the value 0x0000. Note: The bit is reserved and must be kept to reset value when the corresponding I/O is not available on the selected package.
  [then]

  \
  \ @brief General-purpose I/Os
  \
  $00 constant GPIOH_GPIOH_MODER        \ GPIO port mode register
  $04 constant GPIOH_GPIOH_OTYPER       \ GPIO port output type register
  $08 constant GPIOH_GPIOH_OSPEEDR      \ GPIO port output speed register
  $0C constant GPIOH_GPIOH_PUPDR        \ GPIO port pull-up/pull-down register
  $10 constant GPIOH_GPIOH_IDR          \ GPIO port input data register
  $14 constant GPIOH_GPIOH_ODR          \ GPIO port output data register
  $18 constant GPIOH_GPIOH_BSRR         \ GPIO port bit set/reset register
  $1C constant GPIOH_GPIOH_LCKR         \ GPIO port configuration lock register
  $20 constant GPIOH_GPIOH_AFRL         \ GPIO alternate function low register
  $24 constant GPIOH_GPIOH_AFRH         \ GPIO alternate function high register
  $28 constant GPIOH_GPIOH_BRR          \ GPIO port bit reset register

: GPIOH_DEF ; [then]
