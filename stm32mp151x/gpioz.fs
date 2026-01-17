\
\ @file gpioz.fs
\ @brief GPIOZ
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOZ_DEF

  [ifdef] GPIOZ_GPIOZ_MODER_DEF
    \
    \ @brief GPIO port mode register
    \ Address offset: 0x00
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOZ_MODER0                   \ [0x00 : 2] MODER0
    $02 constant GPIOZ_MODER1                   \ [0x02 : 2] MODER1
    $04 constant GPIOZ_MODER2                   \ [0x04 : 2] MODER2
    $06 constant GPIOZ_MODER3                   \ [0x06 : 2] MODER3
    $08 constant GPIOZ_MODER4                   \ [0x08 : 2] MODER4
    $0a constant GPIOZ_MODER5                   \ [0x0a : 2] MODER5
    $0c constant GPIOZ_MODER6                   \ [0x0c : 2] MODER6
    $0e constant GPIOZ_MODER7                   \ [0x0e : 2] MODER7
    $10 constant GPIOZ_MODER8                   \ [0x10 : 2] MODER8
    $12 constant GPIOZ_MODER9                   \ [0x12 : 2] MODER9
    $14 constant GPIOZ_MODER10                  \ [0x14 : 2] MODER10
    $16 constant GPIOZ_MODER11                  \ [0x16 : 2] MODER11
    $18 constant GPIOZ_MODER12                  \ [0x18 : 2] MODER12
    $1a constant GPIOZ_MODER13                  \ [0x1a : 2] MODER13
    $1c constant GPIOZ_MODER14                  \ [0x1c : 2] MODER14
    $1e constant GPIOZ_MODER15                  \ [0x1e : 2] MODER15
  [then]


  [ifdef] GPIOZ_GPIOZ_OTYPER_DEF
    \
    \ @brief GPIO port output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOZ_OT0                      \ [0x00] OT0
    $01 constant GPIOZ_OT1                      \ [0x01] OT1
    $02 constant GPIOZ_OT2                      \ [0x02] OT2
    $03 constant GPIOZ_OT3                      \ [0x03] OT3
    $04 constant GPIOZ_OT4                      \ [0x04] OT4
    $05 constant GPIOZ_OT5                      \ [0x05] OT5
    $06 constant GPIOZ_OT6                      \ [0x06] OT6
    $07 constant GPIOZ_OT7                      \ [0x07] OT7
    $08 constant GPIOZ_OT8                      \ [0x08] OT8
    $09 constant GPIOZ_OT9                      \ [0x09] OT9
    $0a constant GPIOZ_OT10                     \ [0x0a] OT10
    $0b constant GPIOZ_OT11                     \ [0x0b] OT11
    $0c constant GPIOZ_OT12                     \ [0x0c] OT12
    $0d constant GPIOZ_OT13                     \ [0x0d] OT13
    $0e constant GPIOZ_OT14                     \ [0x0e] OT14
    $0f constant GPIOZ_OT15                     \ [0x0f] OT15
  [then]


  [ifdef] GPIOZ_GPIOZ_OSPEEDR_DEF
    \
    \ @brief GPIO port output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPIOZ_OSPEEDR0                 \ [0x00 : 2] OSPEEDR0
    $02 constant GPIOZ_OSPEEDR1                 \ [0x02 : 2] OSPEEDR1
    $04 constant GPIOZ_OSPEEDR2                 \ [0x04 : 2] OSPEEDR2
    $06 constant GPIOZ_OSPEEDR3                 \ [0x06 : 2] OSPEEDR3
    $08 constant GPIOZ_OSPEEDR4                 \ [0x08 : 2] OSPEEDR4
    $0a constant GPIOZ_OSPEEDR5                 \ [0x0a : 2] OSPEEDR5
    $0c constant GPIOZ_OSPEEDR6                 \ [0x0c : 2] OSPEEDR6
    $0e constant GPIOZ_OSPEEDR7                 \ [0x0e : 2] OSPEEDR7
    $10 constant GPIOZ_OSPEEDR8                 \ [0x10 : 2] OSPEEDR8
    $12 constant GPIOZ_OSPEEDR9                 \ [0x12 : 2] OSPEEDR9
    $14 constant GPIOZ_OSPEEDR10                \ [0x14 : 2] OSPEEDR10
    $16 constant GPIOZ_OSPEEDR11                \ [0x16 : 2] OSPEEDR11
    $18 constant GPIOZ_OSPEEDR12                \ [0x18 : 2] OSPEEDR12
    $1a constant GPIOZ_OSPEEDR13                \ [0x1a : 2] OSPEEDR13
    $1c constant GPIOZ_OSPEEDR14                \ [0x1c : 2] OSPEEDR14
    $1e constant GPIOZ_OSPEEDR15                \ [0x1e : 2] OSPEEDR15
  [then]


  [ifdef] GPIOZ_GPIOZ_PUPDR_DEF
    \
    \ @brief GPIO port pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOZ_PUPDR0                   \ [0x00 : 2] PUPDR0
    $02 constant GPIOZ_PUPDR1                   \ [0x02 : 2] PUPDR1
    $04 constant GPIOZ_PUPDR2                   \ [0x04 : 2] PUPDR2
    $06 constant GPIOZ_PUPDR3                   \ [0x06 : 2] PUPDR3
    $08 constant GPIOZ_PUPDR4                   \ [0x08 : 2] PUPDR4
    $0a constant GPIOZ_PUPDR5                   \ [0x0a : 2] PUPDR5
    $0c constant GPIOZ_PUPDR6                   \ [0x0c : 2] PUPDR6
    $0e constant GPIOZ_PUPDR7                   \ [0x0e : 2] PUPDR7
    $10 constant GPIOZ_PUPDR8                   \ [0x10 : 2] PUPDR8
    $12 constant GPIOZ_PUPDR9                   \ [0x12 : 2] PUPDR9
    $14 constant GPIOZ_PUPDR10                  \ [0x14 : 2] PUPDR10
    $16 constant GPIOZ_PUPDR11                  \ [0x16 : 2] PUPDR11
    $18 constant GPIOZ_PUPDR12                  \ [0x18 : 2] PUPDR12
    $1a constant GPIOZ_PUPDR13                  \ [0x1a : 2] PUPDR13
    $1c constant GPIOZ_PUPDR14                  \ [0x1c : 2] PUPDR14
    $1e constant GPIOZ_PUPDR15                  \ [0x1e : 2] PUPDR15
  [then]


  [ifdef] GPIOZ_GPIOZ_IDR_DEF
    \
    \ @brief GPIO port input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOZ_IDR0                     \ [0x00] IDR0
    $01 constant GPIOZ_IDR1                     \ [0x01] IDR1
    $02 constant GPIOZ_IDR2                     \ [0x02] IDR2
    $03 constant GPIOZ_IDR3                     \ [0x03] IDR3
    $04 constant GPIOZ_IDR4                     \ [0x04] IDR4
    $05 constant GPIOZ_IDR5                     \ [0x05] IDR5
    $06 constant GPIOZ_IDR6                     \ [0x06] IDR6
    $07 constant GPIOZ_IDR7                     \ [0x07] IDR7
    $08 constant GPIOZ_IDR8                     \ [0x08] IDR8
    $09 constant GPIOZ_IDR9                     \ [0x09] IDR9
    $0a constant GPIOZ_IDR10                    \ [0x0a] IDR10
    $0b constant GPIOZ_IDR11                    \ [0x0b] IDR11
    $0c constant GPIOZ_IDR12                    \ [0x0c] IDR12
    $0d constant GPIOZ_IDR13                    \ [0x0d] IDR13
    $0e constant GPIOZ_IDR14                    \ [0x0e] IDR14
    $0f constant GPIOZ_IDR15                    \ [0x0f] IDR15
  [then]


  [ifdef] GPIOZ_GPIOZ_ODR_DEF
    \
    \ @brief GPIO port output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOZ_ODR0                     \ [0x00] ODR0
    $01 constant GPIOZ_ODR1                     \ [0x01] ODR1
    $02 constant GPIOZ_ODR2                     \ [0x02] ODR2
    $03 constant GPIOZ_ODR3                     \ [0x03] ODR3
    $04 constant GPIOZ_ODR4                     \ [0x04] ODR4
    $05 constant GPIOZ_ODR5                     \ [0x05] ODR5
    $06 constant GPIOZ_ODR6                     \ [0x06] ODR6
    $07 constant GPIOZ_ODR7                     \ [0x07] ODR7
    $08 constant GPIOZ_ODR8                     \ [0x08] ODR8
    $09 constant GPIOZ_ODR9                     \ [0x09] ODR9
    $0a constant GPIOZ_ODR10                    \ [0x0a] ODR10
    $0b constant GPIOZ_ODR11                    \ [0x0b] ODR11
    $0c constant GPIOZ_ODR12                    \ [0x0c] ODR12
    $0d constant GPIOZ_ODR13                    \ [0x0d] ODR13
    $0e constant GPIOZ_ODR14                    \ [0x0e] ODR14
    $0f constant GPIOZ_ODR15                    \ [0x0f] ODR15
  [then]


  [ifdef] GPIOZ_GPIOZ_BSRR_DEF
    \
    \ @brief GPIO port bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOZ_BS0                      \ [0x00] BS0
    $01 constant GPIOZ_BS1                      \ [0x01] BS1
    $02 constant GPIOZ_BS2                      \ [0x02] BS2
    $03 constant GPIOZ_BS3                      \ [0x03] BS3
    $04 constant GPIOZ_BS4                      \ [0x04] BS4
    $05 constant GPIOZ_BS5                      \ [0x05] BS5
    $06 constant GPIOZ_BS6                      \ [0x06] BS6
    $07 constant GPIOZ_BS7                      \ [0x07] BS7
    $08 constant GPIOZ_BS8                      \ [0x08] BS8
    $09 constant GPIOZ_BS9                      \ [0x09] BS9
    $0a constant GPIOZ_BS10                     \ [0x0a] BS10
    $0b constant GPIOZ_BS11                     \ [0x0b] BS11
    $0c constant GPIOZ_BS12                     \ [0x0c] BS12
    $0d constant GPIOZ_BS13                     \ [0x0d] BS13
    $0e constant GPIOZ_BS14                     \ [0x0e] BS14
    $0f constant GPIOZ_BS15                     \ [0x0f] BS15
    $10 constant GPIOZ_BR0                      \ [0x10] BR0
    $11 constant GPIOZ_BR1                      \ [0x11] BR1
    $12 constant GPIOZ_BR2                      \ [0x12] BR2
    $13 constant GPIOZ_BR3                      \ [0x13] BR3
    $14 constant GPIOZ_BR4                      \ [0x14] BR4
    $15 constant GPIOZ_BR5                      \ [0x15] BR5
    $16 constant GPIOZ_BR6                      \ [0x16] BR6
    $17 constant GPIOZ_BR7                      \ [0x17] BR7
    $18 constant GPIOZ_BR8                      \ [0x18] BR8
    $19 constant GPIOZ_BR9                      \ [0x19] BR9
    $1a constant GPIOZ_BR10                     \ [0x1a] BR10
    $1b constant GPIOZ_BR11                     \ [0x1b] BR11
    $1c constant GPIOZ_BR12                     \ [0x1c] BR12
    $1d constant GPIOZ_BR13                     \ [0x1d] BR13
    $1e constant GPIOZ_BR14                     \ [0x1e] BR14
    $1f constant GPIOZ_BR15                     \ [0x1f] BR15
  [then]


  [ifdef] GPIOZ_GPIOZ_LCKR_DEF
    \
    \ @brief This register is used to lock the configuration of the port bits when a correct write sequence is applied to bit 16 (LCKK). The value of bits [15:0] is used to lock the configuration of the GPIO. During the write sequence, the value of LCKR[15:0] must not change. When the LOCK sequence has been applied on a port bit, the value of this port bit can no longer be modified until the next MCU reset or peripheral reset. A specific write sequence is used to write to the GPIOx_LCKR register. Only word access (32-bit long) is allowed during this locking sequence. Each lock bit freezes a specific configuration register (control and alternate function registers).
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOZ_LCK0                     \ [0x00] LCK0
    $01 constant GPIOZ_LCK1                     \ [0x01] LCK1
    $02 constant GPIOZ_LCK2                     \ [0x02] LCK2
    $03 constant GPIOZ_LCK3                     \ [0x03] LCK3
    $04 constant GPIOZ_LCK4                     \ [0x04] LCK4
    $05 constant GPIOZ_LCK5                     \ [0x05] LCK5
    $06 constant GPIOZ_LCK6                     \ [0x06] LCK6
    $07 constant GPIOZ_LCK7                     \ [0x07] LCK7
    $08 constant GPIOZ_LCK8                     \ [0x08] LCK8
    $09 constant GPIOZ_LCK9                     \ [0x09] LCK9
    $0a constant GPIOZ_LCK10                    \ [0x0a] LCK10
    $0b constant GPIOZ_LCK11                    \ [0x0b] LCK11
    $0c constant GPIOZ_LCK12                    \ [0x0c] LCK12
    $0d constant GPIOZ_LCK13                    \ [0x0d] LCK13
    $0e constant GPIOZ_LCK14                    \ [0x0e] LCK14
    $0f constant GPIOZ_LCK15                    \ [0x0f] LCK15
    $10 constant GPIOZ_LCKK                     \ [0x10] LCKK
  [then]


  [ifdef] GPIOZ_GPIOZ_AFRL_DEF
    \
    \ @brief GPIO alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOZ_AFR0                     \ [0x00 : 4] AFR0
    $04 constant GPIOZ_AFR1                     \ [0x04 : 4] AFR1
    $08 constant GPIOZ_AFR2                     \ [0x08 : 4] AFR2
    $0c constant GPIOZ_AFR3                     \ [0x0c : 4] AFR3
    $10 constant GPIOZ_AFR4                     \ [0x10 : 4] AFR4
    $14 constant GPIOZ_AFR5                     \ [0x14 : 4] AFR5
    $18 constant GPIOZ_AFR6                     \ [0x18 : 4] AFR6
    $1c constant GPIOZ_AFR7                     \ [0x1c : 4] AFR7
  [then]


  [ifdef] GPIOZ_GPIOZ_AFRH_DEF
    \
    \ @brief GPIO alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOZ_AFR8                     \ [0x00 : 4] AFR8
    $04 constant GPIOZ_AFR9                     \ [0x04 : 4] AFR9
    $08 constant GPIOZ_AFR10                    \ [0x08 : 4] AFR10
    $0c constant GPIOZ_AFR11                    \ [0x0c : 4] AFR11
    $10 constant GPIOZ_AFR12                    \ [0x10 : 4] AFR12
    $14 constant GPIOZ_AFR13                    \ [0x14 : 4] AFR13
    $18 constant GPIOZ_AFR14                    \ [0x18 : 4] AFR14
    $1c constant GPIOZ_AFR15                    \ [0x1c : 4] AFR15
  [then]


  [ifdef] GPIOZ_GPIOZ_BRR_DEF
    \
    \ @brief GPIO port bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOZ_BR0                      \ [0x00] BR0
    $01 constant GPIOZ_BR1                      \ [0x01] BR1
    $02 constant GPIOZ_BR2                      \ [0x02] BR2
    $03 constant GPIOZ_BR3                      \ [0x03] BR3
    $04 constant GPIOZ_BR4                      \ [0x04] BR4
    $05 constant GPIOZ_BR5                      \ [0x05] BR5
    $06 constant GPIOZ_BR6                      \ [0x06] BR6
    $07 constant GPIOZ_BR7                      \ [0x07] BR7
    $08 constant GPIOZ_BR8                      \ [0x08] BR8
    $09 constant GPIOZ_BR9                      \ [0x09] BR9
    $0a constant GPIOZ_BR10                     \ [0x0a] BR10
    $0b constant GPIOZ_BR11                     \ [0x0b] BR11
    $0c constant GPIOZ_BR12                     \ [0x0c] BR12
    $0d constant GPIOZ_BR13                     \ [0x0d] BR13
    $0e constant GPIOZ_BR14                     \ [0x0e] BR14
    $0f constant GPIOZ_BR15                     \ [0x0f] BR15
  [then]


  [ifdef] GPIOZ_GPIOZ_SECCFGR_DEF
    \
    \ @brief This register provides write access security and can be written only by a secure access. It is used to configure a selected I/O as secure. A non-secure write access to this register is discarded.
    \ Address offset: 0x30
    \ Reset value: 0x000000FF
    \
    $00 constant GPIOZ_SEC0                     \ [0x00] SEC0
    $01 constant GPIOZ_SEC1                     \ [0x01] SEC1
    $02 constant GPIOZ_SEC2                     \ [0x02] SEC2
    $03 constant GPIOZ_SEC3                     \ [0x03] SEC3
    $04 constant GPIOZ_SEC4                     \ [0x04] SEC4
    $05 constant GPIOZ_SEC5                     \ [0x05] SEC5
    $06 constant GPIOZ_SEC6                     \ [0x06] SEC6
    $07 constant GPIOZ_SEC7                     \ [0x07] SEC7
  [then]


  [ifdef] GPIOZ_GPIOZ_HWCFGR10_DEF
    \
    \ @brief For GPIOA, B, C, D, E, F, G, H, I, J and GPIOK: For GPIOZ:
    \ Address offset: 0x3C8
    \ Reset value: 0x00011240
    \
    $00 constant GPIOZ_AHB_IOP                  \ [0x00 : 4] AHB_IOP
    $04 constant GPIOZ_AF_SIZE                  \ [0x04 : 4] AF_SIZE
    $08 constant GPIOZ_SPEED_CFG                \ [0x08 : 4] SPEED_CFG
    $0c constant GPIOZ_LOCK_CFG                 \ [0x0c : 4] LOCK_CFG
    $10 constant GPIOZ_SEC_CFG                  \ [0x10 : 4] SEC_CFG
    $14 constant GPIOZ_OR_CFG                   \ [0x14 : 4] OR_CFG
  [then]


  [ifdef] GPIOZ_GPIOZ_HWCFGR9_DEF
    \
    \ @brief For GPIOA, B, C, D, E, F, G, H, I, and GPIOJ: For GPIOK and GPIOZ:
    \ Address offset: 0x3CC
    \ Reset value: 0x000000FF
    \
    $00 constant GPIOZ_EN_IO                    \ [0x00 : 16] EN_IO
  [then]


  [ifdef] GPIOZ_GPIOZ_HWCFGR8_DEF
    \
    \ @brief For GPIOA, B, C, D, E, F, G, H, I, and GPIOJ: For GPIOK and GPIOZ:
    \ Address offset: 0x3D0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOZ_AF_PRIO8                 \ [0x00 : 4] AF_PRIO8
    $04 constant GPIOZ_AF_PRIO9                 \ [0x04 : 4] AF_PRIO9
    $08 constant GPIOZ_AF_PRIO10                \ [0x08 : 4] AF_PRIO10
    $0c constant GPIOZ_AF_PRIO11                \ [0x0c : 4] AF_PRIO11
    $10 constant GPIOZ_AF_PRIO12                \ [0x10 : 4] AF_PRIO12
    $14 constant GPIOZ_AF_PRIO13                \ [0x14 : 4] AF_PRIO13
    $18 constant GPIOZ_AF_PRIO14                \ [0x18 : 4] AF_PRIO14
    $1c constant GPIOZ_AF_PRIO15                \ [0x1c : 4] AF_PRIO15
  [then]


  [ifdef] GPIOZ_GPIOZ_HWCFGR7_DEF
    \
    \ @brief GPIO hardware configuration register 7
    \ Address offset: 0x3D4
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOZ_AF_PRIO0                 \ [0x00 : 4] AF_PRIO0
    $04 constant GPIOZ_AF_PRIO1                 \ [0x04 : 4] AF_PRIO1
    $08 constant GPIOZ_AF_PRIO2                 \ [0x08 : 4] AF_PRIO2
    $0c constant GPIOZ_AF_PRIO3                 \ [0x0c : 4] AF_PRIO3
    $10 constant GPIOZ_AF_PRIO4                 \ [0x10 : 4] AF_PRIO4
    $14 constant GPIOZ_AF_PRIO5                 \ [0x14 : 4] AF_PRIO5
    $18 constant GPIOZ_AF_PRIO6                 \ [0x18 : 4] AF_PRIO6
    $1c constant GPIOZ_AF_PRIO7                 \ [0x1c : 4] AF_PRIO7
  [then]


  [ifdef] GPIOZ_GPIOZ_HWCFGR6_DEF
    \
    \ @brief GPIO hardware configuration register 6
    \ Address offset: 0x3D8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOZ_MODER_RES                \ [0x00 : 32] MODER_RES
  [then]


  [ifdef] GPIOZ_GPIOZ_HWCFGR5_DEF
    \
    \ @brief GPIO hardware configuration register 5
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $00 constant GPIOZ_PUPDR_RES                \ [0x00 : 32] PUPDR_RES
  [then]


  [ifdef] GPIOZ_GPIOZ_HWCFGR4_DEF
    \
    \ @brief GPIO hardware configuration register 4
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOZ_OSPEED_RES               \ [0x00 : 32] OSPEED_RES
  [then]


  [ifdef] GPIOZ_GPIOZ_HWCFGR3_DEF
    \
    \ @brief GPIO hardware configuration register 3
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant GPIOZ_ODR_RES                  \ [0x00 : 16] ODR_RES
    $10 constant GPIOZ_OTYPER_RES               \ [0x10 : 16] OTYPER_RES
  [then]


  [ifdef] GPIOZ_GPIOZ_HWCFGR2_DEF
    \
    \ @brief GPIO hardware configuration register 2
    \ Address offset: 0x3E8
    \ Reset value: 0x00000000
    \
    $00 constant GPIOZ_AFRL_RES                 \ [0x00 : 32] AFRL_RES
  [then]


  [ifdef] GPIOZ_GPIOZ_HWCFGR1_DEF
    \
    \ @brief GPIO hardware configuration register 1
    \ Address offset: 0x3EC
    \ Reset value: 0x00000000
    \
    $00 constant GPIOZ_AFRH_RES                 \ [0x00 : 32] AFRH_RES
  [then]


  [ifdef] GPIOZ_GPIOZ_HWCFGR0_DEF
    \
    \ @brief GPIO hardware configuration register 0
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOZ_OR_RES                   \ [0x00 : 16] OR_RES
  [then]


  [ifdef] GPIOZ_GPIOZ_VERR_DEF
    \
    \ @brief GPIO version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000040
    \
    $00 constant GPIOZ_MINREV                   \ [0x00 : 4] MINREV
    $04 constant GPIOZ_MAJREV                   \ [0x04 : 4] MAJREV
  [then]


  [ifdef] GPIOZ_GPIOZ_IPIDR_DEF
    \
    \ @brief GPIO identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x000F0002
    \
    $00 constant GPIOZ_IPIDR                    \ [0x00 : 32] IPIDR
  [then]


  [ifdef] GPIOZ_GPIOZ_SIDR_DEF
    \
    \ @brief GPIO size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant GPIOZ_SIDR                     \ [0x00 : 32] SIDR
  [then]

  \
  \ @brief GPIOZ
  \
  $00 constant GPIOZ_GPIOZ_MODER        \ GPIO port mode register
  $04 constant GPIOZ_GPIOZ_OTYPER       \ GPIO port output type register
  $08 constant GPIOZ_GPIOZ_OSPEEDR      \ GPIO port output speed register
  $0C constant GPIOZ_GPIOZ_PUPDR        \ GPIO port pull-up/pull-down register
  $10 constant GPIOZ_GPIOZ_IDR          \ GPIO port input data register
  $14 constant GPIOZ_GPIOZ_ODR          \ GPIO port output data register
  $18 constant GPIOZ_GPIOZ_BSRR         \ GPIO port bit set/reset register
  $1C constant GPIOZ_GPIOZ_LCKR         \ This register is used to lock the configuration of the port bits when a correct write sequence is applied to bit 16 (LCKK). The value of bits [15:0] is used to lock the configuration of the GPIO. During the write sequence, the value of LCKR[15:0] must not change. When the LOCK sequence has been applied on a port bit, the value of this port bit can no longer be modified until the next MCU reset or peripheral reset. A specific write sequence is used to write to the GPIOx_LCKR register. Only word access (32-bit long) is allowed during this locking sequence. Each lock bit freezes a specific configuration register (control and alternate function registers).
  $20 constant GPIOZ_GPIOZ_AFRL         \ GPIO alternate function low register
  $24 constant GPIOZ_GPIOZ_AFRH         \ GPIO alternate function high register
  $28 constant GPIOZ_GPIOZ_BRR          \ GPIO port bit reset register
  $30 constant GPIOZ_GPIOZ_SECCFGR      \ This register provides write access security and can be written only by a secure access. It is used to configure a selected I/O as secure. A non-secure write access to this register is discarded.
  $3C8 constant GPIOZ_GPIOZ_HWCFGR10    \ For GPIOA, B, C, D, E, F, G, H, I, J and GPIOK: For GPIOZ:
  $3CC constant GPIOZ_GPIOZ_HWCFGR9     \ For GPIOA, B, C, D, E, F, G, H, I, and GPIOJ: For GPIOK and GPIOZ:
  $3D0 constant GPIOZ_GPIOZ_HWCFGR8     \ For GPIOA, B, C, D, E, F, G, H, I, and GPIOJ: For GPIOK and GPIOZ:
  $3D4 constant GPIOZ_GPIOZ_HWCFGR7     \ GPIO hardware configuration register 7
  $3D8 constant GPIOZ_GPIOZ_HWCFGR6     \ GPIO hardware configuration register 6
  $3DC constant GPIOZ_GPIOZ_HWCFGR5     \ GPIO hardware configuration register 5
  $3E0 constant GPIOZ_GPIOZ_HWCFGR4     \ GPIO hardware configuration register 4
  $3E4 constant GPIOZ_GPIOZ_HWCFGR3     \ GPIO hardware configuration register 3
  $3E8 constant GPIOZ_GPIOZ_HWCFGR2     \ GPIO hardware configuration register 2
  $3EC constant GPIOZ_GPIOZ_HWCFGR1     \ GPIO hardware configuration register 1
  $3F0 constant GPIOZ_GPIOZ_HWCFGR0     \ GPIO hardware configuration register 0
  $3F4 constant GPIOZ_GPIOZ_VERR        \ GPIO version register
  $3F8 constant GPIOZ_GPIOZ_IPIDR       \ GPIO identification register
  $3FC constant GPIOZ_GPIOZ_SIDR        \ GPIO size identification register

: GPIOZ_DEF ; [then]
