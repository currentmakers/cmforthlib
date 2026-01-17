\
\ @file gpiob.fs
\ @brief GPIOB interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOB_DEF

  [ifdef] GPIOB_MODER_DEF
    \
    \ @brief MODER register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_MODE0                    \ [0x00 : 2] MODE0[1:0]Port B configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $02 constant GPIOB_MODE1                    \ [0x02 : 2] MODE1[1:0]Port B configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $04 constant GPIOB_MODE2                    \ [0x04 : 2] MODE2[1:0]Port B configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $06 constant GPIOB_MODE3                    \ [0x06 : 2] MODE3[1:0]Port B configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $08 constant GPIOB_MODE4                    \ [0x08 : 2] MODE4[1:0]Port B configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $0a constant GPIOB_MODE5                    \ [0x0a : 2] MODE5[1:0]Port B configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $0c constant GPIOB_MODE6                    \ [0x0c : 2] MODE6[1:0]Port B configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $0e constant GPIOB_MODE7                    \ [0x0e : 2] MODE7[1:0]Port B configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $18 constant GPIOB_MODE12                   \ [0x18 : 2] MODE12[1:0]Port B configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $1a constant GPIOB_MODE13                   \ [0x1a : 2] MODE13[1:0]Port B configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $1c constant GPIOB_MODE14                   \ [0x1c : 2] MODE14[1:0]Port B configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $1e constant GPIOB_MODE15                   \ [0x1e : 2] MODE15[1:0]Port B configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
  [then]


  [ifdef] GPIOB_OTYPER_DEF
    \
    \ @brief OTYPER register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_OT0                      \ [0x00] OT0: Port B configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $01 constant GPIOB_OT1                      \ [0x01] OT1: Port B configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $02 constant GPIOB_OT2                      \ [0x02] OT2: Port B configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $03 constant GPIOB_OT3                      \ [0x03] OT3: Port B configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $04 constant GPIOB_OT4                      \ [0x04] OT4: Port B configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $05 constant GPIOB_OT5                      \ [0x05] OT5: Port B configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $06 constant GPIOB_OT6                      \ [0x06] OT6: Port B configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $07 constant GPIOB_OT7                      \ [0x07] OT7: Port B configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $0c constant GPIOB_OT12                     \ [0x0c] OT12: Port B configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $0d constant GPIOB_OT13                     \ [0x0d] OT13: Port B configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $0e constant GPIOB_OT14                     \ [0x0e] OT14: Port B configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $0f constant GPIOB_OT15                     \ [0x0f] OT15: Port B configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
  [then]


  [ifdef] GPIOB_OSPEEDR_DEF
    \
    \ @brief OSPEEDR register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_OSPEED0                  \ [0x00 : 2] OSPEED0[1:0]: Port B configuration bits These bits are written by software to configure the I/O output speed.
    $02 constant GPIOB_OSPEED1                  \ [0x02 : 2] OSPEED1[1:0]: Port B configuration bits These bits are written by software to configure the I/O output speed.
    $04 constant GPIOB_OSPEED2                  \ [0x04 : 2] OSPEED2[1:0]: Port B configuration bits These bits are written by software to configure the I/O output speed.
    $06 constant GPIOB_OSPEED3                  \ [0x06 : 2] OSPEED3[1:0]: Port B configuration bits These bits are written by software to configure the I/O output speed.
    $08 constant GPIOB_OSPEED4                  \ [0x08 : 2] OSPEED4[1:0]: Port B configuration bits These bits are written by software to configure the I/O output speed.
    $0a constant GPIOB_OSPEED5                  \ [0x0a : 2] OSPEED5[1:0]: Port B configuration bits These bits are written by software to configure the I/O output speed.
    $0c constant GPIOB_OSPEED6                  \ [0x0c : 2] OSPEED6[1:0]: Port B configuration bits These bits are written by software to configure the I/O output speed.
    $0e constant GPIOB_OSPEED7                  \ [0x0e : 2] OSPEED7[1:0]: Port B configuration bits These bits are written by software to configure the I/O output speed.
    $18 constant GPIOB_OSPEED12                 \ [0x18 : 2] OSPEED12[1:0]: Port B configuration bits These bits are written by software to configure the I/O output speed.
    $1a constant GPIOB_OSPEED13                 \ [0x1a : 2] OSPEED13[1:0]: Port B configuration bits These bits are written by software to configure the I/O output speed.
    $1c constant GPIOB_OSPEED14                 \ [0x1c : 2] OSPEED14[1:0]: Port B configuration bits These bits are written by software to configure the I/O output speed.
    $1e constant GPIOB_OSPEED15                 \ [0x1e : 2] OSPEED15[1:0]: Port B configuration bits These bits are written by software to configure the I/O output speed.
  [then]


  [ifdef] GPIOB_PUPDR_DEF
    \
    \ @brief PUPDR register
    \ Address offset: 0x0C
    \ Reset value: 0x55005555
    \
    $00 constant GPIOB_PUPD0                    \ [0x00 : 2] PUPD0: Port B configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $02 constant GPIOB_PUPD1                    \ [0x02 : 2] PUPD1: Port B configuration bits These bits are written by software to configure the I/O pull-up or pull-down 00: No pullup, pulldown 01: Pullup 10: Pulldown 11: Reserved
    $04 constant GPIOB_PUPD2                    \ [0x04 : 2] PUPD2: Port B configuration bits These bits are written by software to configure the I/O pullup or pulldown 00: No pullup, pulldown 01: Pullup 10: Pulldown 11: Reserved
    $06 constant GPIOB_PUPD3                    \ [0x06 : 2] PUPD3: Port B configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $08 constant GPIOB_PUPD4                    \ [0x08 : 2] PUPD4: Port B configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $0a constant GPIOB_PUPD5                    \ [0x0a : 2] PUPD5: Port B configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $0c constant GPIOB_PUPD6                    \ [0x0c : 2] PUPD6: Port B configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $0e constant GPIOB_PUPD7                    \ [0x0e : 2] PUPD7: Port B configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $18 constant GPIOB_PUPD12                   \ [0x18 : 2] PUPD12: Port B configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $1a constant GPIOB_PUPD13                   \ [0x1a : 2] PUPD13: Port B configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $1c constant GPIOB_PUPD14                   \ [0x1c : 2] PUPD14: Port B configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $1e constant GPIOB_PUPD15                   \ [0x1e : 2] PUPD15: Port B configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
  [then]


  [ifdef] GPIOB_IDR_DEF
    \
    \ @brief IDR register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_ID0                      \ [0x00] ID0: Port B input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $01 constant GPIOB_ID1                      \ [0x01] ID1: Port B input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $02 constant GPIOB_ID2                      \ [0x02] ID2: Port B input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $03 constant GPIOB_ID3                      \ [0x03] ID3: Port B input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $04 constant GPIOB_ID4                      \ [0x04] ID4: Port B input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $05 constant GPIOB_ID5                      \ [0x05] ID5: Port B input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $06 constant GPIOB_ID6                      \ [0x06] ID6: Port B input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $07 constant GPIOB_ID7                      \ [0x07] ID7: Port B input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $0c constant GPIOB_ID12                     \ [0x0c] ID12: Port B input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $0d constant GPIOB_ID13                     \ [0x0d] ID13: Port B input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $0e constant GPIOB_ID14                     \ [0x0e] ID14: Port B input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $0f constant GPIOB_ID15                     \ [0x0f] ID15: Port B input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
  [then]


  [ifdef] GPIOB_ODR_DEF
    \
    \ @brief ODR register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_OD0                      \ [0x00] OD0: Port B output data bit These bits can be read and written by software
    $01 constant GPIOB_OD1                      \ [0x01] OD1: Port B output data bit These bits can be read and written by software
    $02 constant GPIOB_OD2                      \ [0x02] OD2: Port B output data bit These bits can be read and written by software
    $03 constant GPIOB_OD3                      \ [0x03] OD3: Port B output data bit These bits can be read and written by software
    $04 constant GPIOB_OD4                      \ [0x04] OD4: Port B output data bit These bits can be read and written by software
    $05 constant GPIOB_OD5                      \ [0x05] OD5: Port B output data bit These bits can be read and written by software
    $06 constant GPIOB_OD6                      \ [0x06] OD6: Port B output data bit These bits can be read and written by software
    $07 constant GPIOB_OD7                      \ [0x07] OD7: Port B output data bit These bits can be read and written by software
    $0c constant GPIOB_OD12                     \ [0x0c] OD12: Port B output data bit These bits can be read and written by software
    $0d constant GPIOB_OD13                     \ [0x0d] OD13: Port B output data bit These bits can be read and written by software
    $0e constant GPIOB_OD14                     \ [0x0e] OD14: Port B output data bit These bits can be read and written by software
    $0f constant GPIOB_OD15                     \ [0x0f] OD15: Port B output data bit These bits can be read and written by software
  [then]


  [ifdef] GPIOB_BSRR_DEF
    \
    \ @brief BSRR register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_BS0                      \ [0x00] BS0: Port B set bit 0 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
    $01 constant GPIOB_BS1                      \ [0x01] BS1: Port B set bit 1 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
    $02 constant GPIOB_BS2                      \ [0x02] BS2: Port B set bit 2 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
    $03 constant GPIOB_BS3                      \ [0x03] BS3: Port B set bit 3 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
    $04 constant GPIOB_BS4                      \ [0x04] BS4: Port B set bit 4 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
    $05 constant GPIOB_BS5                      \ [0x05] BS5: Port B set bit 5 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
    $06 constant GPIOB_BS6                      \ [0x06] BS6: Port B set bit 6 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
    $07 constant GPIOB_BS7                      \ [0x07] BS7: Port B set bit 7 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
    $0c constant GPIOB_BS12                     \ [0x0c] BS12: Port B set bit 12 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
    $0d constant GPIOB_BS13                     \ [0x0d] BS13: Port B set bit 13 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
    $0e constant GPIOB_BS14                     \ [0x0e] BS14: Port B set bit 14 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
    $0f constant GPIOB_BS15                     \ [0x0f] BS15: Port B set bit 15 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
    $10 constant GPIOB_BR0                      \ [0x10] BR0: Port B reset bit 0 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority
    $11 constant GPIOB_BR1                      \ [0x11] BR1: Port B reset bit 1 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority
    $12 constant GPIOB_BR2                      \ [0x12] BR2: Port B reset bit 2 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority
    $13 constant GPIOB_BR3                      \ [0x13] BR3: Port B reset bit 3 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority
    $14 constant GPIOB_BR4                      \ [0x14] BR4: Port B reset bit 4 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority
    $15 constant GPIOB_BR5                      \ [0x15] BR5: Port B reset bit 5 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority
    $16 constant GPIOB_BR6                      \ [0x16] BR6: Port B reset bit 6 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority
    $17 constant GPIOB_BR7                      \ [0x17] BR7: Port B reset bit 7 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority
    $1c constant GPIOB_BR12                     \ [0x1c] BR12: Port B reset bit 12 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority
    $1d constant GPIOB_BR13                     \ [0x1d] BR13: Port B reset bit 13 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority
    $1e constant GPIOB_BR14                     \ [0x1e] BR14: Port B reset bit 14 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority
    $1f constant GPIOB_BR15                     \ [0x1f] BR15: Port B reset bit 15 These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority
  [then]


  [ifdef] GPIOB_LCKR_DEF
    \
    \ @brief LCKR register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_LCK0                     \ [0x00] LCK0: Port B lock bit 0 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $01 constant GPIOB_LCK1                     \ [0x01] LCK1: Port B lock bit 1 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $02 constant GPIOB_LCK2                     \ [0x02] LCK2: Port B lock bit 2 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $03 constant GPIOB_LCK3                     \ [0x03] LCK3: Port B lock bit 3 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $04 constant GPIOB_LCK4                     \ [0x04] LCK4: Port B lock bit 4 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $05 constant GPIOB_LCK5                     \ [0x05] LCK5: Port B lock bit 5 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $06 constant GPIOB_LCK6                     \ [0x06] LCK6: Port B lock bit 6 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $07 constant GPIOB_LCK7                     \ [0x07] LCK7: Port B lock bit 7 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $0c constant GPIOB_LCK12                    \ [0x0c] LCK12: Port B lock bit 12 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $0d constant GPIOB_LCK13                    \ [0x0d] LCK13: Port B lock bit 13 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $0e constant GPIOB_LCK14                    \ [0x0e] LCK14: Port B lock bit 14 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $0f constant GPIOB_LCK15                    \ [0x0f] LCK15: Port B lock bit 15 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $10 constant GPIOB_LCKK                     \ [0x10] LCKK: Lock key This bit can be read any time. It can only be modified using the lock key write sequence. -0: Port configuration lock key not active -1: Port configuration lock key active. The GPIOx_LCKR register is locked until the next MCU reset or peripheral reset. LOCK key write sequence: WR LCKR[16] = 1 + LCKR[15:0] WR LCKR[16] = 0 + LCKR[15:0] WR LCKR[16] = 1 + LCKR[15:0] RD LCKR RD LCKR[16] = 1 (this read operation is optional but it confirms that the lock is active) Note: During the LOCK key write sequence, the value of LCK[15:0] must not change. Any error in the lock sequence aborts the lock. After the first lock sequence on any bit of the port, any read access on the LCKK bit will return 1 until the next MCU reset or peripheral reset.
  [then]


  [ifdef] GPIOB_AFRL_DEF
    \
    \ @brief AFRL register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_AFSEL0                   \ [0x00 : 4] y[3:0]: Alternate function selection for port B pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $04 constant GPIOB_AFSEL1                   \ [0x04 : 4] y[3:0]: Alternate function selection for port B pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $08 constant GPIOB_AFSEL2                   \ [0x08 : 4] y[3:0]: Alternate function selection for port B pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $0c constant GPIOB_AFSEL3                   \ [0x0c : 4] y[3:0]: Alternate function selection for port B pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $10 constant GPIOB_AFSEL4                   \ [0x10 : 4] y[3:0]: Alternate function selection for port B pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $14 constant GPIOB_AFSEL5                   \ [0x14 : 4] y[3:0]: Alternate function selection for port B pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $18 constant GPIOB_AFSEL6                   \ [0x18 : 4] y[3:0]: Alternate function selection for port B pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $1c constant GPIOB_AFSEL7                   \ [0x1c : 4] y[3:0]: Alternate function selection for port B pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
  [then]


  [ifdef] GPIOB_AFRH_DEF
    \
    \ @brief AFRH register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_AFSEL8                   \ [0x00 : 4] y[3:0]: Alternate function selection for port B pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $04 constant GPIOB_AFSEL9                   \ [0x04 : 4] y[3:0]: Alternate function selection for port B pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $08 constant GPIOB_AFSEL10                  \ [0x08 : 4] y[3:0]: Alternate function selection for port B pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $0c constant GPIOB_AFSEL11                  \ [0x0c : 4] y[3:0]: Alternate function selection for port B pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $10 constant GPIOB_AFSEL12                  \ [0x10 : 4] y[3:0]: Alternate function selection for port B pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $14 constant GPIOB_AFSEL13                  \ [0x14 : 4] y[3:0]: Alternate function selection for port B pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $18 constant GPIOB_AFSEL14                  \ [0x18 : 4] y[3:0]: Alternate function selection for port B pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $1c constant GPIOB_AFSEL15                  \ [0x1c : 4] y[3:0]: Alternate function selection for port B pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
  [then]


  [ifdef] GPIOB_BRR_DEF
    \
    \ @brief BRR register
    \ Address offset: 0x28
    \ Reset value: 0x    NULL
    \
    $00 constant GPIOB_BR0                      \ [0x00] BR0: Port B reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $01 constant GPIOB_BR1                      \ [0x01] BR1: Port B reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $02 constant GPIOB_BR2                      \ [0x02] BR2: Port B reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $03 constant GPIOB_BR3                      \ [0x03] BR3: Port B reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $04 constant GPIOB_BR4                      \ [0x04] BR4: Port B reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $05 constant GPIOB_BR5                      \ [0x05] BR5: Port B reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $06 constant GPIOB_BR6                      \ [0x06] BR6: Port B reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $07 constant GPIOB_BR7                      \ [0x07] BR7: Port B reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $0c constant GPIOB_BR12                     \ [0x0c] BR12 Port B reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $0d constant GPIOB_BR13                     \ [0x0d] BR13: Port B reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $0e constant GPIOB_BR14                     \ [0x0e] BR14: Port B reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $0f constant GPIOB_BR15                     \ [0x0f] BR15: Port B reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
  [then]

  \
  \ @brief GPIOB interrupt
  \
  $00 constant GPIOB_MODER              \ MODER register
  $04 constant GPIOB_OTYPER             \ OTYPER register
  $08 constant GPIOB_OSPEEDR            \ OSPEEDR register
  $0C constant GPIOB_PUPDR              \ PUPDR register
  $10 constant GPIOB_IDR                \ IDR register
  $14 constant GPIOB_ODR                \ ODR register
  $18 constant GPIOB_BSRR               \ BSRR register
  $1C constant GPIOB_LCKR               \ LCKR register
  $20 constant GPIOB_AFRL               \ AFRL register
  $24 constant GPIOB_AFRH               \ AFRH register
  $28 constant GPIOB_BRR                \ BRR register

: GPIOB_DEF ; [then]
