\
\ @file gpioa.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOA_DEF

  [ifdef] GPIOA_GPIOA_MODER_DEF
    \
    \ @brief GPIO port A mode register
    \ Address offset: 0x00
    \ Reset value: 0xABFFFFFF
    \
    $00 constant GPIOA_MODE0                    \ [0x00 : 2] Port configuration I/O pin 0
    $02 constant GPIOA_MODE1                    \ [0x02 : 2] Port configuration I/O pin 1
    $04 constant GPIOA_MODE2                    \ [0x04 : 2] Port configuration I/O pin 2
    $06 constant GPIOA_MODE3                    \ [0x06 : 2] Port configuration I/O pin 3
    $0a constant GPIOA_MODE5                    \ [0x0a : 2] Port configuration I/O pin 5
    $0c constant GPIOA_MODE6                    \ [0x0c : 2] Port configuration I/O pin 6
    $0e constant GPIOA_MODE7                    \ [0x0e : 2] Port configuration I/O pin 7
    $10 constant GPIOA_MODE8                    \ [0x10 : 2] Port configuration I/O pin 8
    $12 constant GPIOA_MODE9                    \ [0x12 : 2] Port configuration I/O pin 9
    $14 constant GPIOA_MODE10                   \ [0x14 : 2] Port configuration I/O pin 10
    $16 constant GPIOA_MODE11                   \ [0x16 : 2] Port configuration I/O pin 11
    $18 constant GPIOA_MODE12                   \ [0x18 : 2] Port configuration I/O pin 12
    $1a constant GPIOA_MODE13                   \ [0x1a : 2] Port configuration I/O pin 13
    $1c constant GPIOA_MODE14                   \ [0x1c : 2] Port configuration I/O pin 14
    $1e constant GPIOA_MODE15                   \ [0x1e : 2] Port configuration I/O pin 15 These bits are written by software to configure the I/O mode. Access can be protected by GPIOA SEC15.
  [then]


  [ifdef] GPIOA_GPIOA_OTYPER_DEF
    \
    \ @brief GPIO port A output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_OT0                      \ [0x00] Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
    $01 constant GPIOA_OT1                      \ [0x01] Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
    $02 constant GPIOA_OT2                      \ [0x02] Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
    $03 constant GPIOA_OT3                      \ [0x03] Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
    $05 constant GPIOA_OT5                      \ [0x05] Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
    $06 constant GPIOA_OT6                      \ [0x06] Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
    $07 constant GPIOA_OT7                      \ [0x07] Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
    $08 constant GPIOA_OT8                      \ [0x08] Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
    $09 constant GPIOA_OT9                      \ [0x09] Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
    $0a constant GPIOA_OT10                     \ [0x0a] Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
    $0b constant GPIOA_OT11                     \ [0x0b] Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
    $0c constant GPIOA_OT12                     \ [0x0c] Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
    $0d constant GPIOA_OT13                     \ [0x0d] Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
    $0e constant GPIOA_OT14                     \ [0x0e] Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
    $0f constant GPIOA_OT15                     \ [0x0f] Port configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOA SECy.
  [then]


  [ifdef] GPIOA_GPIOA_OSPEEDR_DEF
    \
    \ @brief GPIO port A output speed register
    \ Address offset: 0x08
    \ Reset value: 0x08000000
    \
    $00 constant GPIOA_OSPEED0                  \ [0x00 : 2] Port configuration I/O pin 0
    $02 constant GPIOA_OSPEED1                  \ [0x02 : 2] Port configuration I/O pin 1
    $04 constant GPIOA_OSPEED2                  \ [0x04 : 2] Port configuration I/O pin 2
    $06 constant GPIOA_OSPEED3                  \ [0x06 : 2] Port configuration I/O pin 3
    $0a constant GPIOA_OSPEED5                  \ [0x0a : 2] Port configuration I/O pin 5
    $0c constant GPIOA_OSPEED6                  \ [0x0c : 2] Port configuration I/O pin 6
    $0e constant GPIOA_OSPEED7                  \ [0x0e : 2] Port configuration I/O pin 7
    $10 constant GPIOA_OSPEED8                  \ [0x10 : 2] Port configuration I/O pin 8
    $12 constant GPIOA_OSPEED9                  \ [0x12 : 2] Port configuration I/O pin 9
    $14 constant GPIOA_OSPEED10                 \ [0x14 : 2] Port configuration I/O pin 10
    $16 constant GPIOA_OSPEED11                 \ [0x16 : 2] Port configuration I/O pin 11
    $18 constant GPIOA_OSPEED12                 \ [0x18 : 2] Port configuration I/O pin 12
    $1a constant GPIOA_OSPEED13                 \ [0x1a : 2] Port configuration I/O pin 13
    $1c constant GPIOA_OSPEED14                 \ [0x1c : 2] Port configuration I/O pin 14
    $1e constant GPIOA_OSPEED15                 \ [0x1e : 2] Port configuration I/O pin 15 These bits are written by software to configure the I/O output speed. Access can be protected by GPIOA SEC15. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
  [then]


  [ifdef] GPIOA_GPIOA_PUPDR_DEF
    \
    \ @brief GPIO port A pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x64000000
    \
    $00 constant GPIOA_PUPD0                    \ [0x00 : 2] Port configuration I/O pin 0
    $02 constant GPIOA_PUPD1                    \ [0x02 : 2] Port configuration I/O pin 1
    $04 constant GPIOA_PUPD2                    \ [0x04 : 2] Port configuration I/O pin 2
    $06 constant GPIOA_PUPD3                    \ [0x06 : 2] Port configuration I/O pin 3
    $0a constant GPIOA_PUPD5                    \ [0x0a : 2] Port configuration I/O pin 5
    $0c constant GPIOA_PUPD6                    \ [0x0c : 2] Port configuration I/O pin 6
    $0e constant GPIOA_PUPD7                    \ [0x0e : 2] Port configuration I/O pin 7
    $10 constant GPIOA_PUPD8                    \ [0x10 : 2] Port configuration I/O pin 8
    $12 constant GPIOA_PUPD9                    \ [0x12 : 2] Port configuration I/O pin 9
    $14 constant GPIOA_PUPD10                   \ [0x14 : 2] Port configuration I/O pin 10
    $16 constant GPIOA_PUPD11                   \ [0x16 : 2] Port configuration I/O pin 11
    $18 constant GPIOA_PUPD12                   \ [0x18 : 2] Port configuration I/O pin 12
    $1a constant GPIOA_PUPD13                   \ [0x1a : 2] Port configuration I/O pin 13
    $1c constant GPIOA_PUPD14                   \ [0x1c : 2] Port configuration I/O pin 14
    $1e constant GPIOA_PUPD15                   \ [0x1e : 2] Port configuration I/O pin 15 These bits are written by software to configure the I/O pull-up or pull-down Access can be protected by GPIOA SEC15.
  [then]


  [ifdef] GPIOA_GPIOA_IDR_DEF
    \
    \ @brief GPIO port A input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_ID0                      \ [0x00] Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
    $01 constant GPIOA_ID1                      \ [0x01] Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
    $02 constant GPIOA_ID2                      \ [0x02] Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
    $03 constant GPIOA_ID3                      \ [0x03] Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
    $05 constant GPIOA_ID5                      \ [0x05] Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
    $06 constant GPIOA_ID6                      \ [0x06] Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
    $07 constant GPIOA_ID7                      \ [0x07] Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
    $08 constant GPIOA_ID8                      \ [0x08] Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
    $09 constant GPIOA_ID9                      \ [0x09] Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
    $0a constant GPIOA_ID10                     \ [0x0a] Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
    $0b constant GPIOA_ID11                     \ [0x0b] Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
    $0c constant GPIOA_ID12                     \ [0x0c] Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
    $0d constant GPIOA_ID13                     \ [0x0d] Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
    $0e constant GPIOA_ID14                     \ [0x0e] Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
    $0f constant GPIOA_ID15                     \ [0x0f] Port input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOA SECy.
  [then]


  [ifdef] GPIOA_GPIOA_ODR_DEF
    \
    \ @brief GPIO port A output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_OD0                      \ [0x00] Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers.
    $01 constant GPIOA_OD1                      \ [0x01] Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers.
    $02 constant GPIOA_OD2                      \ [0x02] Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers.
    $03 constant GPIOA_OD3                      \ [0x03] Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers.
    $05 constant GPIOA_OD5                      \ [0x05] Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers .
    $06 constant GPIOA_OD6                      \ [0x06] Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers .
    $07 constant GPIOA_OD7                      \ [0x07] Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers .
    $08 constant GPIOA_OD8                      \ [0x08] Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers .
    $09 constant GPIOA_OD9                      \ [0x09] Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers .
    $0a constant GPIOA_OD10                     \ [0x0a] Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers .
    $0b constant GPIOA_OD11                     \ [0x0b] Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers .
    $0c constant GPIOA_OD12                     \ [0x0c] Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers .
    $0d constant GPIOA_OD13                     \ [0x0d] Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers .
    $0e constant GPIOA_OD14                     \ [0x0e] Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers .
    $0f constant GPIOA_OD15                     \ [0x0f] Port output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOA SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOA_BSRR or GPIOA_BRR registers .
  [then]


  [ifdef] GPIOA_GPIOA_BSRR_DEF
    \
    \ @brief GPIO port A bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_BS0                      \ [0x00] Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
    $01 constant GPIOA_BS1                      \ [0x01] Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
    $02 constant GPIOA_BS2                      \ [0x02] Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
    $03 constant GPIOA_BS3                      \ [0x03] Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
    $05 constant GPIOA_BS5                      \ [0x05] Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
    $06 constant GPIOA_BS6                      \ [0x06] Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
    $07 constant GPIOA_BS7                      \ [0x07] Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
    $08 constant GPIOA_BS8                      \ [0x08] Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
    $09 constant GPIOA_BS9                      \ [0x09] Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
    $0a constant GPIOA_BS10                     \ [0x0a] Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
    $0b constant GPIOA_BS11                     \ [0x0b] Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
    $0c constant GPIOA_BS12                     \ [0x0c] Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
    $0d constant GPIOA_BS13                     \ [0x0d] Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
    $0e constant GPIOA_BS14                     \ [0x0e] Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
    $0f constant GPIOA_BS15                     \ [0x0f] Port set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy
    $10 constant GPIOA_BR0                      \ [0x10] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
    $11 constant GPIOA_BR1                      \ [0x11] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
    $12 constant GPIOA_BR2                      \ [0x12] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
    $13 constant GPIOA_BR3                      \ [0x13] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
    $15 constant GPIOA_BR5                      \ [0x15] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
    $16 constant GPIOA_BR6                      \ [0x16] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
    $17 constant GPIOA_BR7                      \ [0x17] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
    $18 constant GPIOA_BR8                      \ [0x18] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
    $19 constant GPIOA_BR9                      \ [0x19] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
    $1a constant GPIOA_BR10                     \ [0x1a] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
    $1b constant GPIOA_BR11                     \ [0x1b] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
    $1c constant GPIOA_BR12                     \ [0x1c] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
    $1d constant GPIOA_BR13                     \ [0x1d] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
    $1e constant GPIOA_BR14                     \ [0x1e] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
    $1f constant GPIOA_BR15                     \ [0x1f] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy. Note: If both BSy and BRy are set, BSy has priority.
  [then]


  [ifdef] GPIOA_GPIOA_LCKR_DEF
    \
    \ @brief GPIO port A configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_LCK0                     \ [0x00] Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
    $01 constant GPIOA_LCK1                     \ [0x01] Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
    $02 constant GPIOA_LCK2                     \ [0x02] Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
    $03 constant GPIOA_LCK3                     \ [0x03] Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
    $05 constant GPIOA_LCK5                     \ [0x05] Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
    $06 constant GPIOA_LCK6                     \ [0x06] Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
    $07 constant GPIOA_LCK7                     \ [0x07] Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
    $08 constant GPIOA_LCK8                     \ [0x08] Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
    $09 constant GPIOA_LCK9                     \ [0x09] Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
    $0a constant GPIOA_LCK10                    \ [0x0a] Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
    $0b constant GPIOA_LCK11                    \ [0x0b] Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
    $0c constant GPIOA_LCK12                    \ [0x0c] Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
    $0d constant GPIOA_LCK13                    \ [0x0d] Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
    $0e constant GPIOA_LCK14                    \ [0x0e] Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
    $0f constant GPIOA_LCK15                    \ [0x0f] Port lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOA SECy.
    $10 constant GPIOA_LCKK                     \ [0x10] Lock key This bit can be read any time. It can only be modified using the lock key write sequence. Access can be protected by any GPIOA SECy. - LOCK key write sequence: WR LCKR[16] = 1 + LCKR[15:0] WR LCKR[16] = 0 + LCKR[15:0] WR LCKR[16] = 1 + LCKR[15:0] - LOCK key read RD LCKR[16] = 1 (this read operation is optional but it confirms that the lock is active) Note: During the LOCK key write sequence, the value of LCKR[15:0] must not change. Note: Any error in the lock sequence aborts the LOCK. Note: After the first LOCK sequence on any bit of the port, any read access on the LCKK bit returns 1 until the next MCU reset or peripheral reset.
  [then]


  [ifdef] GPIOA_GPIOA_AFRL_DEF
    \
    \ @brief GPIO port A alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_AFSEL0                   \ [0x00 : 4] Alternate function selection for port I/O pin 0
    $04 constant GPIOA_AFSEL1                   \ [0x04 : 4] Alternate function selection for port I/O pin 1
    $08 constant GPIOA_AFSEL2                   \ [0x08 : 4] Alternate function selection for port I/O pin 2
    $0c constant GPIOA_AFSEL3                   \ [0x0c : 4] Alternate function selection for port I/O pin 3
    $14 constant GPIOA_AFSEL5                   \ [0x14 : 4] Alternate function selection for port I/O pin 5
    $18 constant GPIOA_AFSEL6                   \ [0x18 : 4] Alternate function selection for port I/O pin 6
    $1c constant GPIOA_AFSEL7                   \ [0x1c : 4] Alternate function selection for port I/O pin 7 These bits are written by software to configure alternate function I/Os. Access can be protected by GPIOA SECy.
  [then]


  [ifdef] GPIOA_GPIOA_AFRH_DEF
    \
    \ @brief GPIO port A alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_AFSEL8                   \ [0x00 : 4] Alternate function selection for port I/O pin 8
    $04 constant GPIOA_AFSEL9                   \ [0x04 : 4] Alternate function selection for port I/O pin 9
    $08 constant GPIOA_AFSEL10                  \ [0x08 : 4] Alternate function selection for port I/O pin 10
    $0c constant GPIOA_AFSEL11                  \ [0x0c : 4] Alternate function selection for port I/O pin 11
    $10 constant GPIOA_AFSEL12                  \ [0x10 : 4] Alternate function selection for port I/O pin 12
    $14 constant GPIOA_AFSEL13                  \ [0x14 : 4] Alternate function selection for port I/O pin 13
    $18 constant GPIOA_AFSEL14                  \ [0x18 : 4] Alternate function selection for port I/O pin 14
    $1c constant GPIOA_AFSEL15                  \ [0x1c : 4] Alternate function selection for port I/O pin 15 These bits are written by software to configure alternate function I/Os. Access can be protected by GPIOA SEC15.
  [then]


  [ifdef] GPIOA_GPIOA_BRR_DEF
    \
    \ @brief GPIO port A bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_BR0                      \ [0x00] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
    $01 constant GPIOA_BR1                      \ [0x01] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
    $02 constant GPIOA_BR2                      \ [0x02] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
    $03 constant GPIOA_BR3                      \ [0x03] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
    $05 constant GPIOA_BR5                      \ [0x05] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
    $06 constant GPIOA_BR6                      \ [0x06] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
    $07 constant GPIOA_BR7                      \ [0x07] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
    $08 constant GPIOA_BR8                      \ [0x08] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
    $09 constant GPIOA_BR9                      \ [0x09] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
    $0a constant GPIOA_BR10                     \ [0x0a] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
    $0b constant GPIOA_BR11                     \ [0x0b] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
    $0c constant GPIOA_BR12                     \ [0x0c] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
    $0d constant GPIOA_BR13                     \ [0x0d] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
    $0e constant GPIOA_BR14                     \ [0x0e] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
    $0f constant GPIOA_BR15                     \ [0x0f] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOA SECy.
  [then]


  [ifdef] GPIOA_GPIOA_SECCFGR_DEF
    \
    \ @brief GPIO port A secure configuration register
    \ Address offset: 0x30
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOA_SEC0                     \ [0x00] I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
    $01 constant GPIOA_SEC1                     \ [0x01] I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
    $02 constant GPIOA_SEC2                     \ [0x02] I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
    $03 constant GPIOA_SEC3                     \ [0x03] I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
    $05 constant GPIOA_SEC5                     \ [0x05] I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
    $06 constant GPIOA_SEC6                     \ [0x06] I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
    $07 constant GPIOA_SEC7                     \ [0x07] I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
    $08 constant GPIOA_SEC8                     \ [0x08] I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
    $09 constant GPIOA_SEC9                     \ [0x09] I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
    $0a constant GPIOA_SEC10                    \ [0x0a] I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
    $0b constant GPIOA_SEC11                    \ [0x0b] I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
    $0c constant GPIOA_SEC12                    \ [0x0c] I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
    $0d constant GPIOA_SEC13                    \ [0x0d] I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
    $0e constant GPIOA_SEC14                    \ [0x0e] I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
    $0f constant GPIOA_SEC15                    \ [0x0f] I/O pin of port secure bit enable y These bits are written by software to enabled the security I/O port pin.
  [then]

  \
  \ @brief General-purpose I/Os
  \
  $00 constant GPIOA_GPIOA_MODER        \ GPIO port A mode register
  $04 constant GPIOA_GPIOA_OTYPER       \ GPIO port A output type register
  $08 constant GPIOA_GPIOA_OSPEEDR      \ GPIO port A output speed register
  $0C constant GPIOA_GPIOA_PUPDR        \ GPIO port A pull-up/pull-down register
  $10 constant GPIOA_GPIOA_IDR          \ GPIO port A input data register
  $14 constant GPIOA_GPIOA_ODR          \ GPIO port A output data register
  $18 constant GPIOA_GPIOA_BSRR         \ GPIO port A bit set/reset register
  $1C constant GPIOA_GPIOA_LCKR         \ GPIO port A configuration lock register
  $20 constant GPIOA_GPIOA_AFRL         \ GPIO port A alternate function low register
  $24 constant GPIOA_GPIOA_AFRH         \ GPIO port A alternate function high register
  $28 constant GPIOA_GPIOA_BRR          \ GPIO port A bit reset register
  $30 constant GPIOA_GPIOA_SECCFGR      \ GPIO port A secure configuration register

: GPIOA_DEF ; [then]
