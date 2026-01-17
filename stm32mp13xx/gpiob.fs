\
\ @file gpiob.fs
\ @brief GPIOB
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOB_DEF

  [ifdef] GPIOB_GPIOB_MODER_DEF
    \
    \ @brief GPIO port mode register
    \ Address offset: 0x00
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOB_MODER0                   \ [0x00 : 2] MODER0
    $02 constant GPIOB_MODER1                   \ [0x02 : 2] MODER1
    $04 constant GPIOB_MODER2                   \ [0x04 : 2] MODER2
    $06 constant GPIOB_MODER3                   \ [0x06 : 2] MODER3
    $08 constant GPIOB_MODER4                   \ [0x08 : 2] MODER4
    $0a constant GPIOB_MODER5                   \ [0x0a : 2] MODER5
    $0c constant GPIOB_MODER6                   \ [0x0c : 2] MODER6
    $0e constant GPIOB_MODER7                   \ [0x0e : 2] MODER7
    $10 constant GPIOB_MODER8                   \ [0x10 : 2] MODER8
    $12 constant GPIOB_MODER9                   \ [0x12 : 2] MODER9
    $14 constant GPIOB_MODER10                  \ [0x14 : 2] MODER10
    $16 constant GPIOB_MODER11                  \ [0x16 : 2] MODER11
    $18 constant GPIOB_MODER12                  \ [0x18 : 2] MODER12
    $1a constant GPIOB_MODER13                  \ [0x1a : 2] MODER13
    $1c constant GPIOB_MODER14                  \ [0x1c : 2] MODER14
    $1e constant GPIOB_MODER15                  \ [0x1e : 2] MODER15
  [then]


  [ifdef] GPIOB_GPIOB_OTYPER_DEF
    \
    \ @brief GPIO port output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_OT0                      \ [0x00] OT0
    $01 constant GPIOB_OT1                      \ [0x01] OT1
    $02 constant GPIOB_OT2                      \ [0x02] OT2
    $03 constant GPIOB_OT3                      \ [0x03] OT3
    $04 constant GPIOB_OT4                      \ [0x04] OT4
    $05 constant GPIOB_OT5                      \ [0x05] OT5
    $06 constant GPIOB_OT6                      \ [0x06] OT6
    $07 constant GPIOB_OT7                      \ [0x07] OT7
    $08 constant GPIOB_OT8                      \ [0x08] OT8
    $09 constant GPIOB_OT9                      \ [0x09] OT9
    $0a constant GPIOB_OT10                     \ [0x0a] OT10
    $0b constant GPIOB_OT11                     \ [0x0b] OT11
    $0c constant GPIOB_OT12                     \ [0x0c] OT12
    $0d constant GPIOB_OT13                     \ [0x0d] OT13
    $0e constant GPIOB_OT14                     \ [0x0e] OT14
    $0f constant GPIOB_OT15                     \ [0x0f] OT15
  [then]


  [ifdef] GPIOB_GPIOB_OSPEEDR_DEF
    \
    \ @brief GPIO port output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_OSPEEDR0                 \ [0x00 : 2] OSPEEDR0
    $02 constant GPIOB_OSPEEDR1                 \ [0x02 : 2] OSPEEDR1
    $04 constant GPIOB_OSPEEDR2                 \ [0x04 : 2] OSPEEDR2
    $06 constant GPIOB_OSPEEDR3                 \ [0x06 : 2] OSPEEDR3
    $08 constant GPIOB_OSPEEDR4                 \ [0x08 : 2] OSPEEDR4
    $0a constant GPIOB_OSPEEDR5                 \ [0x0a : 2] OSPEEDR5
    $0c constant GPIOB_OSPEEDR6                 \ [0x0c : 2] OSPEEDR6
    $0e constant GPIOB_OSPEEDR7                 \ [0x0e : 2] OSPEEDR7
    $10 constant GPIOB_OSPEEDR8                 \ [0x10 : 2] OSPEEDR8
    $12 constant GPIOB_OSPEEDR9                 \ [0x12 : 2] OSPEEDR9
    $14 constant GPIOB_OSPEEDR10                \ [0x14 : 2] OSPEEDR10
    $16 constant GPIOB_OSPEEDR11                \ [0x16 : 2] OSPEEDR11
    $18 constant GPIOB_OSPEEDR12                \ [0x18 : 2] OSPEEDR12
    $1a constant GPIOB_OSPEEDR13                \ [0x1a : 2] OSPEEDR13
    $1c constant GPIOB_OSPEEDR14                \ [0x1c : 2] OSPEEDR14
    $1e constant GPIOB_OSPEEDR15                \ [0x1e : 2] OSPEEDR15
  [then]


  [ifdef] GPIOB_GPIOB_PUPDR_DEF
    \
    \ @brief GPIO port pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_PUPDR0                   \ [0x00 : 2] PUPDR0
    $02 constant GPIOB_PUPDR1                   \ [0x02 : 2] PUPDR1
    $04 constant GPIOB_PUPDR2                   \ [0x04 : 2] PUPDR2
    $06 constant GPIOB_PUPDR3                   \ [0x06 : 2] PUPDR3
    $08 constant GPIOB_PUPDR4                   \ [0x08 : 2] PUPDR4
    $0a constant GPIOB_PUPDR5                   \ [0x0a : 2] PUPDR5
    $0c constant GPIOB_PUPDR6                   \ [0x0c : 2] PUPDR6
    $0e constant GPIOB_PUPDR7                   \ [0x0e : 2] PUPDR7
    $10 constant GPIOB_PUPDR8                   \ [0x10 : 2] PUPDR8
    $12 constant GPIOB_PUPDR9                   \ [0x12 : 2] PUPDR9
    $14 constant GPIOB_PUPDR10                  \ [0x14 : 2] PUPDR10
    $16 constant GPIOB_PUPDR11                  \ [0x16 : 2] PUPDR11
    $18 constant GPIOB_PUPDR12                  \ [0x18 : 2] PUPDR12
    $1a constant GPIOB_PUPDR13                  \ [0x1a : 2] PUPDR13
    $1c constant GPIOB_PUPDR14                  \ [0x1c : 2] PUPDR14
    $1e constant GPIOB_PUPDR15                  \ [0x1e : 2] PUPDR15
  [then]


  [ifdef] GPIOB_GPIOB_IDR_DEF
    \
    \ @brief GPIO port input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_IDR0                     \ [0x00] IDR0
    $01 constant GPIOB_IDR1                     \ [0x01] IDR1
    $02 constant GPIOB_IDR2                     \ [0x02] IDR2
    $03 constant GPIOB_IDR3                     \ [0x03] IDR3
    $04 constant GPIOB_IDR4                     \ [0x04] IDR4
    $05 constant GPIOB_IDR5                     \ [0x05] IDR5
    $06 constant GPIOB_IDR6                     \ [0x06] IDR6
    $07 constant GPIOB_IDR7                     \ [0x07] IDR7
    $08 constant GPIOB_IDR8                     \ [0x08] IDR8
    $09 constant GPIOB_IDR9                     \ [0x09] IDR9
    $0a constant GPIOB_IDR10                    \ [0x0a] IDR10
    $0b constant GPIOB_IDR11                    \ [0x0b] IDR11
    $0c constant GPIOB_IDR12                    \ [0x0c] IDR12
    $0d constant GPIOB_IDR13                    \ [0x0d] IDR13
    $0e constant GPIOB_IDR14                    \ [0x0e] IDR14
    $0f constant GPIOB_IDR15                    \ [0x0f] IDR15
  [then]


  [ifdef] GPIOB_GPIOB_ODR_DEF
    \
    \ @brief GPIO port output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_ODR0                     \ [0x00] ODR0
    $01 constant GPIOB_ODR1                     \ [0x01] ODR1
    $02 constant GPIOB_ODR2                     \ [0x02] ODR2
    $03 constant GPIOB_ODR3                     \ [0x03] ODR3
    $04 constant GPIOB_ODR4                     \ [0x04] ODR4
    $05 constant GPIOB_ODR5                     \ [0x05] ODR5
    $06 constant GPIOB_ODR6                     \ [0x06] ODR6
    $07 constant GPIOB_ODR7                     \ [0x07] ODR7
    $08 constant GPIOB_ODR8                     \ [0x08] ODR8
    $09 constant GPIOB_ODR9                     \ [0x09] ODR9
    $0a constant GPIOB_ODR10                    \ [0x0a] ODR10
    $0b constant GPIOB_ODR11                    \ [0x0b] ODR11
    $0c constant GPIOB_ODR12                    \ [0x0c] ODR12
    $0d constant GPIOB_ODR13                    \ [0x0d] ODR13
    $0e constant GPIOB_ODR14                    \ [0x0e] ODR14
    $0f constant GPIOB_ODR15                    \ [0x0f] ODR15
  [then]


  [ifdef] GPIOB_GPIOB_BSRR_DEF
    \
    \ @brief GPIO port bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_BS0                      \ [0x00] BS0
    $01 constant GPIOB_BS1                      \ [0x01] BS1
    $02 constant GPIOB_BS2                      \ [0x02] BS2
    $03 constant GPIOB_BS3                      \ [0x03] BS3
    $04 constant GPIOB_BS4                      \ [0x04] BS4
    $05 constant GPIOB_BS5                      \ [0x05] BS5
    $06 constant GPIOB_BS6                      \ [0x06] BS6
    $07 constant GPIOB_BS7                      \ [0x07] BS7
    $08 constant GPIOB_BS8                      \ [0x08] BS8
    $09 constant GPIOB_BS9                      \ [0x09] BS9
    $0a constant GPIOB_BS10                     \ [0x0a] BS10
    $0b constant GPIOB_BS11                     \ [0x0b] BS11
    $0c constant GPIOB_BS12                     \ [0x0c] BS12
    $0d constant GPIOB_BS13                     \ [0x0d] BS13
    $0e constant GPIOB_BS14                     \ [0x0e] BS14
    $0f constant GPIOB_BS15                     \ [0x0f] BS15
    $10 constant GPIOB_BR0                      \ [0x10] BR0
    $11 constant GPIOB_BR1                      \ [0x11] BR1
    $12 constant GPIOB_BR2                      \ [0x12] BR2
    $13 constant GPIOB_BR3                      \ [0x13] BR3
    $14 constant GPIOB_BR4                      \ [0x14] BR4
    $15 constant GPIOB_BR5                      \ [0x15] BR5
    $16 constant GPIOB_BR6                      \ [0x16] BR6
    $17 constant GPIOB_BR7                      \ [0x17] BR7
    $18 constant GPIOB_BR8                      \ [0x18] BR8
    $19 constant GPIOB_BR9                      \ [0x19] BR9
    $1a constant GPIOB_BR10                     \ [0x1a] BR10
    $1b constant GPIOB_BR11                     \ [0x1b] BR11
    $1c constant GPIOB_BR12                     \ [0x1c] BR12
    $1d constant GPIOB_BR13                     \ [0x1d] BR13
    $1e constant GPIOB_BR14                     \ [0x1e] BR14
    $1f constant GPIOB_BR15                     \ [0x1f] BR15
  [then]


  [ifdef] GPIOB_GPIOB_LCKR_DEF
    \
    \ @brief This register is used to lock the configuration of the port bits when a correct write sequence is applied to bit 16 (LCKK). The value of bits [15:0] is used to lock the configuration of the GPIO. During the write sequence, the value of LCKR[15:0] must not change. When the LOCK sequence has been applied on a port bit, the value of this port bit can no longer be modified until the next MCU reset or peripheral reset. A specific write sequence is used to write to the GPIOx_LCKR register. Only word access (32-bit long) is allowed during this locking sequence. Each lock bit freezes a specific configuration register (control and alternate function registers).
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_LCK0                     \ [0x00] LCK0
    $01 constant GPIOB_LCK1                     \ [0x01] LCK1
    $02 constant GPIOB_LCK2                     \ [0x02] LCK2
    $03 constant GPIOB_LCK3                     \ [0x03] LCK3
    $04 constant GPIOB_LCK4                     \ [0x04] LCK4
    $05 constant GPIOB_LCK5                     \ [0x05] LCK5
    $06 constant GPIOB_LCK6                     \ [0x06] LCK6
    $07 constant GPIOB_LCK7                     \ [0x07] LCK7
    $08 constant GPIOB_LCK8                     \ [0x08] LCK8
    $09 constant GPIOB_LCK9                     \ [0x09] LCK9
    $0a constant GPIOB_LCK10                    \ [0x0a] LCK10
    $0b constant GPIOB_LCK11                    \ [0x0b] LCK11
    $0c constant GPIOB_LCK12                    \ [0x0c] LCK12
    $0d constant GPIOB_LCK13                    \ [0x0d] LCK13
    $0e constant GPIOB_LCK14                    \ [0x0e] LCK14
    $0f constant GPIOB_LCK15                    \ [0x0f] LCK15
    $10 constant GPIOB_LCKK                     \ [0x10] LCKK
  [then]


  [ifdef] GPIOB_GPIOB_AFRL_DEF
    \
    \ @brief GPIO alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_AFR0                     \ [0x00 : 4] AFR0
    $04 constant GPIOB_AFR1                     \ [0x04 : 4] AFR1
    $08 constant GPIOB_AFR2                     \ [0x08 : 4] AFR2
    $0c constant GPIOB_AFR3                     \ [0x0c : 4] AFR3
    $10 constant GPIOB_AFR4                     \ [0x10 : 4] AFR4
    $14 constant GPIOB_AFR5                     \ [0x14 : 4] AFR5
    $18 constant GPIOB_AFR6                     \ [0x18 : 4] AFR6
    $1c constant GPIOB_AFR7                     \ [0x1c : 4] AFR7
  [then]


  [ifdef] GPIOB_GPIOB_AFRH_DEF
    \
    \ @brief GPIO alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_AFR8                     \ [0x00 : 4] AFR8
    $04 constant GPIOB_AFR9                     \ [0x04 : 4] AFR9
    $08 constant GPIOB_AFR10                    \ [0x08 : 4] AFR10
    $0c constant GPIOB_AFR11                    \ [0x0c : 4] AFR11
    $10 constant GPIOB_AFR12                    \ [0x10 : 4] AFR12
    $14 constant GPIOB_AFR13                    \ [0x14 : 4] AFR13
    $18 constant GPIOB_AFR14                    \ [0x18 : 4] AFR14
    $1c constant GPIOB_AFR15                    \ [0x1c : 4] AFR15
  [then]


  [ifdef] GPIOB_GPIOB_BRR_DEF
    \
    \ @brief GPIO port bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_BR0                      \ [0x00] BR0
    $01 constant GPIOB_BR1                      \ [0x01] BR1
    $02 constant GPIOB_BR2                      \ [0x02] BR2
    $03 constant GPIOB_BR3                      \ [0x03] BR3
    $04 constant GPIOB_BR4                      \ [0x04] BR4
    $05 constant GPIOB_BR5                      \ [0x05] BR5
    $06 constant GPIOB_BR6                      \ [0x06] BR6
    $07 constant GPIOB_BR7                      \ [0x07] BR7
    $08 constant GPIOB_BR8                      \ [0x08] BR8
    $09 constant GPIOB_BR9                      \ [0x09] BR9
    $0a constant GPIOB_BR10                     \ [0x0a] BR10
    $0b constant GPIOB_BR11                     \ [0x0b] BR11
    $0c constant GPIOB_BR12                     \ [0x0c] BR12
    $0d constant GPIOB_BR13                     \ [0x0d] BR13
    $0e constant GPIOB_BR14                     \ [0x0e] BR14
    $0f constant GPIOB_BR15                     \ [0x0f] BR15
  [then]


  [ifdef] GPIOB_GPIOB_SECCFGR_DEF
    \
    \ @brief GPIO secure configuration register
    \ Address offset: 0x30
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOB_SEC0                     \ [0x00] SEC0
    $01 constant GPIOB_SEC1                     \ [0x01] SEC1
    $02 constant GPIOB_SEC2                     \ [0x02] SEC2
    $03 constant GPIOB_SEC3                     \ [0x03] SEC3
    $04 constant GPIOB_SEC4                     \ [0x04] SEC4
    $05 constant GPIOB_SEC5                     \ [0x05] SEC5
    $06 constant GPIOB_SEC6                     \ [0x06] SEC6
    $07 constant GPIOB_SEC7                     \ [0x07] SEC7
    $08 constant GPIOB_SEC8                     \ [0x08] SEC8
    $09 constant GPIOB_SEC9                     \ [0x09] SEC9
    $0a constant GPIOB_SEC10                    \ [0x0a] SEC10
    $0b constant GPIOB_SEC11                    \ [0x0b] SEC11
    $0c constant GPIOB_SEC12                    \ [0x0c] SEC12
    $0d constant GPIOB_SEC13                    \ [0x0d] SEC13
    $0e constant GPIOB_SEC14                    \ [0x0e] SEC14
    $0f constant GPIOB_SEC15                    \ [0x0f] SEC15
  [then]


  [ifdef] GPIOB_GPIOB_HWCFGR10_DEF
    \
    \ @brief For GPIOA, B, C, D, E, F, G, H, I, J and GPIOK: For GPIOZ:
    \ Address offset: 0x3C8
    \ Reset value: 0x00011240
    \
    $00 constant GPIOB_AHB_IOP                  \ [0x00 : 4] AHB_IOP
    $04 constant GPIOB_AF_SIZE                  \ [0x04 : 4] AF_SIZE
    $08 constant GPIOB_SPEED_CFG                \ [0x08 : 4] SPEED_CFG
    $0c constant GPIOB_LOCK_CFG                 \ [0x0c : 4] LOCK_CFG
    $10 constant GPIOB_SEC_CFG                  \ [0x10 : 4] SEC_CFG
    $14 constant GPIOB_OR_CFG                   \ [0x14 : 4] OR_CFG
  [then]


  [ifdef] GPIOB_GPIOB_HWCFGR9_DEF
    \
    \ @brief For GPIOA, B, C, D, E, F, G, H, I, and GPIOJ: For GPIOK and GPIOZ:
    \ Address offset: 0x3CC
    \ Reset value: 0x000000FF
    \
    $00 constant GPIOB_EN_IO                    \ [0x00 : 16] EN_IO
  [then]


  [ifdef] GPIOB_GPIOB_HWCFGR8_DEF
    \
    \ @brief For GPIOA, B, C, D, E, F, G, H, I, and GPIOJ: For GPIOK and GPIOZ:
    \ Address offset: 0x3D0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_AF_PRIO8                 \ [0x00 : 4] AF_PRIO8
    $04 constant GPIOB_AF_PRIO9                 \ [0x04 : 4] AF_PRIO9
    $08 constant GPIOB_AF_PRIO10                \ [0x08 : 4] AF_PRIO10
    $0c constant GPIOB_AF_PRIO11                \ [0x0c : 4] AF_PRIO11
    $10 constant GPIOB_AF_PRIO12                \ [0x10 : 4] AF_PRIO12
    $14 constant GPIOB_AF_PRIO13                \ [0x14 : 4] AF_PRIO13
    $18 constant GPIOB_AF_PRIO14                \ [0x18 : 4] AF_PRIO14
    $1c constant GPIOB_AF_PRIO15                \ [0x1c : 4] AF_PRIO15
  [then]


  [ifdef] GPIOB_GPIOB_HWCFGR7_DEF
    \
    \ @brief GPIO hardware configuration register 7
    \ Address offset: 0x3D4
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOB_AF_PRIO0                 \ [0x00 : 4] AF_PRIO0
    $04 constant GPIOB_AF_PRIO1                 \ [0x04 : 4] AF_PRIO1
    $08 constant GPIOB_AF_PRIO2                 \ [0x08 : 4] AF_PRIO2
    $0c constant GPIOB_AF_PRIO3                 \ [0x0c : 4] AF_PRIO3
    $10 constant GPIOB_AF_PRIO4                 \ [0x10 : 4] AF_PRIO4
    $14 constant GPIOB_AF_PRIO5                 \ [0x14 : 4] AF_PRIO5
    $18 constant GPIOB_AF_PRIO6                 \ [0x18 : 4] AF_PRIO6
    $1c constant GPIOB_AF_PRIO7                 \ [0x1c : 4] AF_PRIO7
  [then]


  [ifdef] GPIOB_GPIOB_HWCFGR6_DEF
    \
    \ @brief GPIO hardware configuration register 6
    \ Address offset: 0x3D8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOB_MODER_RES                \ [0x00 : 32] MODER_RES
  [then]


  [ifdef] GPIOB_GPIOB_HWCFGR5_DEF
    \
    \ @brief GPIO hardware configuration register 5
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_PUPDR_RES                \ [0x00 : 32] PUPDR_RES
  [then]


  [ifdef] GPIOB_GPIOB_HWCFGR4_DEF
    \
    \ @brief GPIO hardware configuration register 4
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_OSPEED_RES               \ [0x00 : 32] OSPEED_RES
  [then]


  [ifdef] GPIOB_GPIOB_HWCFGR3_DEF
    \
    \ @brief GPIO hardware configuration register 3
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_ODR_RES                  \ [0x00 : 16] ODR_RES
    $10 constant GPIOB_OTYPER_RES               \ [0x10 : 16] OTYPER_RES
  [then]


  [ifdef] GPIOB_GPIOB_HWCFGR2_DEF
    \
    \ @brief GPIO hardware configuration register 2
    \ Address offset: 0x3E8
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_AFRL_RES                 \ [0x00 : 32] AFRL_RES
  [then]


  [ifdef] GPIOB_GPIOB_HWCFGR1_DEF
    \
    \ @brief GPIO hardware configuration register 1
    \ Address offset: 0x3EC
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_AFRH_RES                 \ [0x00 : 32] AFRH_RES
  [then]


  [ifdef] GPIOB_GPIOB_HWCFGR0_DEF
    \
    \ @brief GPIO hardware configuration register 0
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_OR_RES                   \ [0x00 : 16] OR_RES
  [then]


  [ifdef] GPIOB_GPIOB_VERR_DEF
    \
    \ @brief GPIO version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000040
    \
    $00 constant GPIOB_MINREV                   \ [0x00 : 4] MINREV
    $04 constant GPIOB_MAJREV                   \ [0x04 : 4] MAJREV
  [then]


  [ifdef] GPIOB_GPIOB_IPIDR_DEF
    \
    \ @brief GPIO identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x000F0002
    \
    $00 constant GPIOB_IPIDR                    \ [0x00 : 32] IPIDR
  [then]


  [ifdef] GPIOB_GPIOB_SIDR_DEF
    \
    \ @brief GPIO size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant GPIOB_SIDR                     \ [0x00 : 32] SIDR
  [then]

  \
  \ @brief GPIOB
  \
  $00 constant GPIOB_GPIOB_MODER        \ GPIO port mode register
  $04 constant GPIOB_GPIOB_OTYPER       \ GPIO port output type register
  $08 constant GPIOB_GPIOB_OSPEEDR      \ GPIO port output speed register
  $0C constant GPIOB_GPIOB_PUPDR        \ GPIO port pull-up/pull-down register
  $10 constant GPIOB_GPIOB_IDR          \ GPIO port input data register
  $14 constant GPIOB_GPIOB_ODR          \ GPIO port output data register
  $18 constant GPIOB_GPIOB_BSRR         \ GPIO port bit set/reset register
  $1C constant GPIOB_GPIOB_LCKR         \ This register is used to lock the configuration of the port bits when a correct write sequence is applied to bit 16 (LCKK). The value of bits [15:0] is used to lock the configuration of the GPIO. During the write sequence, the value of LCKR[15:0] must not change. When the LOCK sequence has been applied on a port bit, the value of this port bit can no longer be modified until the next MCU reset or peripheral reset. A specific write sequence is used to write to the GPIOx_LCKR register. Only word access (32-bit long) is allowed during this locking sequence. Each lock bit freezes a specific configuration register (control and alternate function registers).
  $20 constant GPIOB_GPIOB_AFRL         \ GPIO alternate function low register
  $24 constant GPIOB_GPIOB_AFRH         \ GPIO alternate function high register
  $28 constant GPIOB_GPIOB_BRR          \ GPIO port bit reset register
  $30 constant GPIOB_GPIOB_SECCFGR      \ GPIO secure configuration register
  $3C8 constant GPIOB_GPIOB_HWCFGR10    \ For GPIOA, B, C, D, E, F, G, H, I, J and GPIOK: For GPIOZ:
  $3CC constant GPIOB_GPIOB_HWCFGR9     \ For GPIOA, B, C, D, E, F, G, H, I, and GPIOJ: For GPIOK and GPIOZ:
  $3D0 constant GPIOB_GPIOB_HWCFGR8     \ For GPIOA, B, C, D, E, F, G, H, I, and GPIOJ: For GPIOK and GPIOZ:
  $3D4 constant GPIOB_GPIOB_HWCFGR7     \ GPIO hardware configuration register 7
  $3D8 constant GPIOB_GPIOB_HWCFGR6     \ GPIO hardware configuration register 6
  $3DC constant GPIOB_GPIOB_HWCFGR5     \ GPIO hardware configuration register 5
  $3E0 constant GPIOB_GPIOB_HWCFGR4     \ GPIO hardware configuration register 4
  $3E4 constant GPIOB_GPIOB_HWCFGR3     \ GPIO hardware configuration register 3
  $3E8 constant GPIOB_GPIOB_HWCFGR2     \ GPIO hardware configuration register 2
  $3EC constant GPIOB_GPIOB_HWCFGR1     \ GPIO hardware configuration register 1
  $3F0 constant GPIOB_GPIOB_HWCFGR0     \ GPIO hardware configuration register 0
  $3F4 constant GPIOB_GPIOB_VERR        \ GPIO version register
  $3F8 constant GPIOB_GPIOB_IPIDR       \ GPIO identification register
  $3FC constant GPIOB_GPIOB_SIDR        \ GPIO size identification register

: GPIOB_DEF ; [then]
