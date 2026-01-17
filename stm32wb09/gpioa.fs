\
\ @file gpioa.fs
\ @brief GPIOA interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOA_DEF

  [ifdef] GPIOA_MODER_DEF
    \
    \ @brief MODER register
    \ Address offset: 0x00
    \ Reset value: 0x000000A0
    \
    $00 constant GPIOA_MODE0                    \ [0x00 : 2] MODE0[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $02 constant GPIOA_MODE1                    \ [0x02 : 2] MODE1[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $04 constant GPIOA_MODE2                    \ [0x04 : 2] MODE2[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $06 constant GPIOA_MODE3                    \ [0x06 : 2] MODE3[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $10 constant GPIOA_MODE8                    \ [0x10 : 2] MODE8[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $12 constant GPIOA_MODE9                    \ [0x12 : 2] MODE9[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $14 constant GPIOA_MODE10                   \ [0x14 : 2] MODE10[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
    $16 constant GPIOA_MODE11                   \ [0x16 : 2] MODE11[1:0]Port A configuration bits. These bits are written by software to configure the I/O mode. -00: Input mode -01: output mode -10: Alternate function mode -11: Analog mode
  [then]


  [ifdef] GPIOA_OTYPER_DEF
    \
    \ @brief OTYPER register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_OT0                      \ [0x00] OT0: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $01 constant GPIOA_OT1                      \ [0x01] OT1: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $02 constant GPIOA_OT2                      \ [0x02] OT2: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $03 constant GPIOA_OT3                      \ [0x03] OT3: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $08 constant GPIOA_OT8                      \ [0x08] OT8: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $09 constant GPIOA_OT9                      \ [0x09] OT9: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $0a constant GPIOA_OT10                     \ [0x0a] OT10: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
    $0b constant GPIOA_OT11                     \ [0x0b] OT11: Port A configuration bits These bits are written by software to configure the I/O output type. -0: Output push-pull (reset state) -1: Output open-drain
  [then]


  [ifdef] GPIOA_OSPEEDR_DEF
    \
    \ @brief OSPEEDR register
    \ Address offset: 0x08
    \ Reset value: 0x00000030
    \
    $00 constant GPIOA_OSPEED0                  \ [0x00 : 2] OSPEED0[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
    $02 constant GPIOA_OSPEED1                  \ [0x02 : 2] OSPEED1[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
    $04 constant GPIOA_OSPEED2                  \ [0x04 : 2] OSPEED2[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
    $06 constant GPIOA_OSPEED3                  \ [0x06 : 2] OSPEED3[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
    $10 constant GPIOA_OSPEED8                  \ [0x10 : 2] OSPEED8[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
    $12 constant GPIOA_OSPEED9                  \ [0x12 : 2] OSPEED9[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
    $14 constant GPIOA_OSPEED10                 \ [0x14 : 2] OSPEED10[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
    $16 constant GPIOA_OSPEED11                 \ [0x16 : 2] OSPEED11[1:0]: Port A configuration bits These bits are written by software to configure the I/O output speed.
  [then]


  [ifdef] GPIOA_PUPDR_DEF
    \
    \ @brief PUPDR register
    \ Address offset: 0x0C
    \ Reset value: 0x00550095
    \
    $00 constant GPIOA_PUPD0                    \ [0x00 : 2] PUPD0: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $02 constant GPIOA_PUPD1                    \ [0x02 : 2] PUPD1: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $04 constant GPIOA_PUPD2                    \ [0x04 : 2] PUPD2: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $06 constant GPIOA_PUPD3                    \ [0x06 : 2] PUPD3: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $10 constant GPIOA_PUPD8                    \ [0x10 : 2] PUPD8: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $12 constant GPIOA_PUPD9                    \ [0x12 : 2] PUPD9: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $14 constant GPIOA_PUPD10                   \ [0x14 : 2] PUPD10: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
    $16 constant GPIOA_PUPD11                   \ [0x16 : 2] PUPD11: Port A configuration bits These bits are written by software to configure the I/O pull-up or pull-down -00: No pull-up, pull-down -01: Pull-up -10: Pull-down -11: Reserved
  [then]


  [ifdef] GPIOA_IDR_DEF
    \
    \ @brief IDR register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_ID0                      \ [0x00] ID0: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $01 constant GPIOA_ID1                      \ [0x01] ID1: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $02 constant GPIOA_ID2                      \ [0x02] ID2: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $03 constant GPIOA_ID3                      \ [0x03] ID3: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $08 constant GPIOA_ID8                      \ [0x08] ID8: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $09 constant GPIOA_ID9                      \ [0x09] ID9: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $0a constant GPIOA_ID10                     \ [0x0a] ID10: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
    $0b constant GPIOA_ID11                     \ [0x0b] ID11: Port A input data bit.These bits are read-only. They contain the input value of the corresponding I/O port
  [then]


  [ifdef] GPIOA_ODR_DEF
    \
    \ @brief ODR register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_OD0                      \ [0x00] OD0: Port A output data bit These bits can be read and written by software
    $01 constant GPIOA_OD1                      \ [0x01] OD1: Port A output data bit These bits can be read and written by software
    $02 constant GPIOA_OD2                      \ [0x02] OD2: Port A output data bit These bits can be read and written by software
    $03 constant GPIOA_OD3                      \ [0x03] OD3: Port A output data bit These bits can be read and written by software
    $08 constant GPIOA_OD8                      \ [0x08] OD8: Port A output data bit These bits can be read and written by software
    $09 constant GPIOA_OD9                      \ [0x09] OD9: Port A output data bit These bits can be read and written by software
    $0a constant GPIOA_OD10                     \ [0x0a] OD10: Port A output data bit These bits can be read and written by software
    $0b constant GPIOA_OD11                     \ [0x0b] OD11: Port A output data bit These bits can be read and written by software
  [then]


  [ifdef] GPIOA_BSRR_DEF
    \
    \ @brief BSRR register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_BS0                      \ [0x00] BS0: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
    $01 constant GPIOA_BS1                      \ [0x01] BS1: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
    $02 constant GPIOA_BS2                      \ [0x02] BS2: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
    $03 constant GPIOA_BS3                      \ [0x03] BS3: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
    $08 constant GPIOA_BS8                      \ [0x08] BS8: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
    $09 constant GPIOA_BS9                      \ [0x09] BS9: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
    $0a constant GPIOA_BS10                     \ [0x0a] BS10: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
    $0b constant GPIOA_BS11                     \ [0x0b] BS11: Port A set bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Sets the corresponding ODx bit
    $10 constant GPIOA_BR0                      \ [0x10] BR0: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
    $11 constant GPIOA_BR1                      \ [0x11] BR1: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
    $12 constant GPIOA_BR2                      \ [0x12] BR2: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
    $13 constant GPIOA_BR3                      \ [0x13] BR3: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
    $18 constant GPIOA_BR8                      \ [0x18] BR8: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
    $19 constant GPIOA_BR9                      \ [0x19] BR9: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
    $1a constant GPIOA_BR10                     \ [0x1a] BR10: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
    $1b constant GPIOA_BR11                     \ [0x1b] BR11: Port A reset bit y These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit Note: If both BSx and BRx are set, BSx has priority.
  [then]


  [ifdef] GPIOA_LCKR_DEF
    \
    \ @brief LCKR register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_LCK0                     \ [0x00] LCK0: Port A lock bit 0 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $01 constant GPIOA_LCK1                     \ [0x01] LCK1: Port A lock bit 1 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $02 constant GPIOA_LCK2                     \ [0x02] LCK2: Port A lock bit 2 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $03 constant GPIOA_LCK3                     \ [0x03] LCK3: Port A lock bit 3 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $08 constant GPIOA_LCK8                     \ [0x08] LCK8: Port A lock bit 8 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $09 constant GPIOA_LCK9                     \ [0x09] LCK9: Port A lock bit 9 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $0a constant GPIOA_LCK10                    \ [0x0a] LCK10: Port A lock bit 10 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $0b constant GPIOA_LCK11                    \ [0x0b] LCK11: Port A lock bit 11 These bits are read/write but can only be written when the LCKK bit is 0, using the specific sequence described in LCKK bit description. -0: Port configuration not locked -1: Port configuration locked
    $10 constant GPIOA_LCKK                     \ [0x10] LCKK: Lock key This bit can be read any time. It can only be modified using the lock key write sequence. -0: Port configuration lock key not active -1: Port configuration lock key active. The GPIOx_LCKR register is locked until the next MCU reset or peripheral reset. LOCK key write sequence: WR LCKR[16] = 1' + LCKR[15:0] WR LCKR[16] = 0' + LCKR[15:0] WR LCKR[16] = 1' + LCKR[15:0] RD LCKR RD LCKR[16] = 1' (this read operation is optional but it confirms that the lock is active) Note: During the LOCK key write sequence, the value of LCK[15:0] must not change. Any error in the lock sequence aborts the lock. After the first lock sequence on any bit of the port, any read access on the LCKK bit will return 1' until the next MCU reset or peripheral reset
  [then]


  [ifdef] GPIOA_AFRL_DEF
    \
    \ @brief AFRL register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_AFSEL0                   \ [0x00 : 4] y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $04 constant GPIOA_AFSEL1                   \ [0x04 : 4] y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $08 constant GPIOA_AFSEL2                   \ [0x08 : 4] y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $0c constant GPIOA_AFSEL3                   \ [0x0c : 4] y[3:0]: Alternate function selection for port A pin y (y = 0..7) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
  [then]


  [ifdef] GPIOA_AFRH_DEF
    \
    \ @brief AFRH register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_AFSEL8                   \ [0x00 : 4] y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $04 constant GPIOA_AFSEL9                   \ [0x04 : 4] y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $08 constant GPIOA_AFSEL10                  \ [0x08 : 4] y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
    $0c constant GPIOA_AFSEL11                  \ [0x0c : 4] y[3:0]: Alternate function selection for port A pin y (y = 8..15) These bits are written by software to configure alternate function I/Os AFSELy selection: -0000: AF0 -0001: AF1 -0010: AF2 -0011: AF3 -0100: AF4 -0101: AF5 -0110: AF6 -0111: AF7 1xxx: Reserved
  [then]


  [ifdef] GPIOA_BRR_DEF
    \
    \ @brief BRR register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_BR0                      \ [0x00] BR0: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $01 constant GPIOA_BR1                      \ [0x01] BR1: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $02 constant GPIOA_BR2                      \ [0x02] BR2: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $03 constant GPIOA_BR3                      \ [0x03] BR3: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $08 constant GPIOA_BR8                      \ [0x08] BR8: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $09 constant GPIOA_BR9                      \ [0x09] BR9: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $0a constant GPIOA_BR10                     \ [0x0a] BR10: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
    $0b constant GPIOA_BR11                     \ [0x0b] BR11: Port A reset bit y (y = 0..15) These bits are write-only. A read to these bits returns the value 0x0000. -0: No action on the corresponding ODx bit -1: Resets the corresponding ODx bit
  [then]

  \
  \ @brief GPIOA interrupt
  \
  $00 constant GPIOA_MODER              \ MODER register
  $04 constant GPIOA_OTYPER             \ OTYPER register
  $08 constant GPIOA_OSPEEDR            \ OSPEEDR register
  $0C constant GPIOA_PUPDR              \ PUPDR register
  $10 constant GPIOA_IDR                \ IDR register
  $14 constant GPIOA_ODR                \ ODR register
  $18 constant GPIOA_BSRR               \ BSRR register
  $1C constant GPIOA_LCKR               \ LCKR register
  $20 constant GPIOA_AFRL               \ AFRL register
  $24 constant GPIOA_AFRH               \ AFRH register
  $28 constant GPIOA_BRR                \ BRR register

: GPIOA_DEF ; [then]
