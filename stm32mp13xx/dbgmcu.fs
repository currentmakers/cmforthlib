\
\ @file dbgmcu.fs
\ @brief Microcontroller Debug Unit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DBGMCU_DEF

  [ifdef] DBGMCU_DBGMCU_IDC_DEF
    \
    \ @brief DBGMCU identity code register
    \ Address offset: 0x00
    \ Reset value: 0x10006501
    \
    $00 constant DBGMCU_DEV_ID                  \ [0x00 : 12] device ID
    $10 constant DBGMCU_REV_ID                  \ [0x10 : 16] revision 0x1000 = Rev. 1
  [then]


  [ifdef] DBGMCU_DBGMCU_CR_DEF
    \
    \ @brief DBGMCU configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $02 constant DBGMCU_DBGLP                   \ [0x02] Low power mode debug enable
  [then]


  [ifdef] DBGMCU_DBGMCU_APB4FZ_DEF
    \
    \ @brief DBGMCU APB4 peripheral freeze register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $02 constant DBGMCU_IWDG2                   \ [0x02] IWDG2 stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_APB1FZ_DEF
    \
    \ @brief DBGMCU APB1 peripheral freeze register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_TIM2                    \ [0x00] TIM2 stop in debug
    $01 constant DBGMCU_TIM3                    \ [0x01] TIM3 stop in debug
    $02 constant DBGMCU_TIM4                    \ [0x02] TIM4 stop in debug
    $03 constant DBGMCU_TIM5                    \ [0x03] TIM5 stop in debug
    $04 constant DBGMCU_TIM6                    \ [0x04] TIM6 stop in debug
    $05 constant DBGMCU_TIM7                    \ [0x05] TIM7 stop in debug
    $09 constant DBGMCU_LPTIM1                  \ [0x09] LPTIM1 stop in debug
    $12 constant DBGMCU_I2C1                    \ [0x12] I2C1 SMBUS timeout stop in debug
    $13 constant DBGMCU_I2C2                    \ [0x13] I2C2 SMBUS timeout stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_APB2FZ_DEF
    \
    \ @brief DBGMCU APB2 peripheral freeze register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_TIM1                    \ [0x00] TIM1 stop in debug
    $01 constant DBGMCU_TIM8                    \ [0x01] TIM8 stop in debug
    $0f constant DBGMCU_FDCAN                   \ [0x0f] FDCAN stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_APB3FZ_DEF
    \
    \ @brief DBGMCU APB3 peripheral freeze register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $01 constant DBGMCU_LPTIM2                  \ [0x01] LPTIM2 stop in debug
    $02 constant DBGMCU_LPTIM3                  \ [0x02] LPTIM3 stop in debug
    $03 constant DBGMCU_LPTIM4                  \ [0x03] LPTIM4 stop in debug
    $04 constant DBGMCU_LPTIM5                  \ [0x04] LPTIM5 stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_APB5FZ_DEF
    \
    \ @brief DBGMCU APB5 peripheral freeze register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $03 constant DBGMCU_IWDG1                   \ [0x03] independent watchdog 1 stop in debug
    $04 constant DBGMCU_RTC                     \ [0x04] RTC stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_APB6FZ_DEF
    \
    \ @brief DBGMCU APB6 peripheral freeze register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $04 constant DBGMCU_I2C3                    \ [0x04] I2C3 SMBUS stop in debug
    $05 constant DBGMCU_I2C4                    \ [0x05] I2C4 SMBUS stop in debug
    $06 constant DBGMCU_I2C5                    \ [0x06] I2C5 SMBUS stop in debug
    $07 constant DBGMCU_TIM12                   \ [0x07] TIM12 stop in debug
    $08 constant DBGMCU_TIM13                   \ [0x08] TIM13 stop in debug
    $09 constant DBGMCU_TIM14                   \ [0x09] TIM14 stop in debug
    $0a constant DBGMCU_TIM15                   \ [0x0a] TIM15 stop in debug
    $0b constant DBGMCU_TIM16                   \ [0x0b] TIM16 stop in debug
    $0c constant DBGMCU_TIM17                   \ [0x0c] TIM17 stop in debug
  [then]


  [ifdef] DBGMCU_DBGMCU_PIDR4_DEF
    \
    \ @brief DBGMCU peripheral ID4 register
    \ Address offset: 0xFD0
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_DES_2                   \ [0x00 : 4] JEDEC continuation code Indicates the designer of the component, together with the identity code.
    $04 constant DBGMCU_SIZE                    \ [0x04 : 4] component memory size indicator Indicates the total contiguous size of the memory window used by the component in powers of two from the standard 4Â Kbytes. If a component only requires the standard 4Â Kbytes, this bit field must read as 0x0. For 8Â Kbytes it is set to 0x1. For 16Â Kbytes it set to 0x2. For 32Â Kbytes it is set to 0x3, and similarly for larger memory windows.
  [then]


  [ifdef] DBGMCU_DBGMCU_PIDR0_DEF
    \
    \ @brief DBGMCU peripheral ID0 register
    \ Address offset: 0xFE0
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_PART_0                  \ [0x00 : 8] bits [7:0] of the component part number This field is specified by the designer of the component.
  [then]


  [ifdef] DBGMCU_DBGMCU_PIDR1_DEF
    \
    \ @brief DBGMCU peripheral ID1 register
    \ Address offset: 0xFE4
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_PART_1                  \ [0x00 : 4] bits [11:8] of the component part number Specified by the designer of the component.
    $04 constant DBGMCU_DES_0                   \ [0x04 : 4] bits [3:0] of the JEDEC identity code Indicates the designer of the component, together with the continuation code.
  [then]


  [ifdef] DBGMCU_DBGMCU_PIDR2_DEF
    \
    \ @brief DBGMCU peripheral ID2 register
    \ Address offset: 0xFE8
    \ Reset value: 0x0000000A
    \
    $00 constant DBGMCU_DES_1                   \ [0x00 : 3] bits [6:4] of the JEDEC identity code Indicates the designer of the component, together with the continuation code.
    $03 constant DBGMCU_JEDEC                   \ [0x03] JEDEC assigned value usage Indicates the use of a JEDEC assigned value. This bit is always set.
    $04 constant DBGMCU_REVISION                \ [0x04 : 4] incremental component design version An incremental value starting from 0x0 for the first design of this component. The value increases by one at both major and minor revisions and is used as a look-up to establish the exact major and minor revisions.
  [then]


  [ifdef] DBGMCU_DBGMCU_PIDR3_DEF
    \
    \ @brief DBGMCU peripheral ID3 register
    \ Address offset: 0xFEC
    \ Reset value: 0x00000000
    \
    $00 constant DBGMCU_CMOD                    \ [0x00 : 4] customer modification indicator When the component is a reusable IP, this value indicates if the customer has modified the behavior of the component. In most cases this field is 0x0.
    $04 constant DBGMCU_REVAND                  \ [0x04 : 4] minor fix indicator Indicates minor errata fixes specific to the design, for example metal fixes after implementation. In most cases this field is 0x0. ArmÂ® recommends that the component designers ensure that the bit field can be changed by a metal fix if required, for example by driving the bit field from registers that reset to zero.
  [then]


  [ifdef] DBGMCU_DBGMCU_CIDR0_DEF
    \
    \ @brief DBGMCU component ID0 register
    \ Address offset: 0xFF0
    \ Reset value: 0x0000000D
    \
    $00 constant DBGMCU_PRMBL_0                 \ [0x00 : 8] bits [31:24] of component identification Component identification register, that indicates that the identification registers are present.
  [then]


  [ifdef] DBGMCU_DBGMCU_CIDR1_DEF
    \
    \ @brief DBGMCU component ID1 register
    \ Address offset: 0xFF4
    \ Reset value: 0x000000F0
    \
    $00 constant DBGMCU_PRMBL_1                 \ [0x00 : 4] bits [19:16] of component identification. Component identification register, that indicates that the identification registers are present.
    $04 constant DBGMCU_CLASS                   \ [0x04 : 4] component class Indicates the class of the component, for example, ROM table or CoreSightâ¢ component.
  [then]


  [ifdef] DBGMCU_DBGMCU_CIDR2_DEF
    \
    \ @brief DBGMCU component ID2 register
    \ Address offset: 0xFF8
    \ Reset value: 0x00000005
    \
    $00 constant DBGMCU_PRMBL_2                 \ [0x00 : 8] bits [15:8] of component identification Component identification register, that indicates that the identification registers are present.
  [then]


  [ifdef] DBGMCU_DBGMCU_CIDR3_DEF
    \
    \ @brief DBGMCU component ID3 register
    \ Address offset: 0xFFC
    \ Reset value: 0x000000B1
    \
    $00 constant DBGMCU_PRMBL_3                 \ [0x00 : 8] bits [7:0] of component identification Component identification register, that indicates that the identification registers are present.
  [then]

  \
  \ @brief Microcontroller Debug Unit
  \
  $00 constant DBGMCU_DBGMCU_IDC        \ DBGMCU identity code register
  $04 constant DBGMCU_DBGMCU_CR         \ DBGMCU configuration register
  $2C constant DBGMCU_DBGMCU_APB4FZ     \ DBGMCU APB4 peripheral freeze register
  $34 constant DBGMCU_DBGMCU_APB1FZ     \ DBGMCU APB1 peripheral freeze register
  $3C constant DBGMCU_DBGMCU_APB2FZ     \ DBGMCU APB2 peripheral freeze register
  $44 constant DBGMCU_DBGMCU_APB3FZ     \ DBGMCU APB3 peripheral freeze register
  $4C constant DBGMCU_DBGMCU_APB5FZ     \ DBGMCU APB5 peripheral freeze register
  $54 constant DBGMCU_DBGMCU_APB6FZ     \ DBGMCU APB6 peripheral freeze register
  $FD0 constant DBGMCU_DBGMCU_PIDR4     \ DBGMCU peripheral ID4 register
  $FE0 constant DBGMCU_DBGMCU_PIDR0     \ DBGMCU peripheral ID0 register
  $FE4 constant DBGMCU_DBGMCU_PIDR1     \ DBGMCU peripheral ID1 register
  $FE8 constant DBGMCU_DBGMCU_PIDR2     \ DBGMCU peripheral ID2 register
  $FEC constant DBGMCU_DBGMCU_PIDR3     \ DBGMCU peripheral ID3 register
  $FF0 constant DBGMCU_DBGMCU_CIDR0     \ DBGMCU component ID0 register
  $FF4 constant DBGMCU_DBGMCU_CIDR1     \ DBGMCU component ID1 register
  $FF8 constant DBGMCU_DBGMCU_CIDR2     \ DBGMCU component ID2 register
  $FFC constant DBGMCU_DBGMCU_CIDR3     \ DBGMCU component ID3 register

: DBGMCU_DEF ; [then]
