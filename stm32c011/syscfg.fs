\
\ @file syscfg.fs
\ @brief SYSCFG register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SYSCFG_DEF

  [ifdef] SYSCFG_SYSCFG_CFGR1_DEF
    \
    \ @brief SYSCFG configuration register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_MEM_MODE                \ [0x00 : 2] Memory mapping selection bits This bitfield controlled by software selects the memory internally mapped at the address 0x0000 0000. Its reset value is determined by the boot mode configuration. Refer to for more details. x0: Main Flash memory
    $03 constant SYSCFG_PA11_RMP                \ [0x03] PA11 pin remapping This bit is set and cleared by software. When set, it remaps the PA11 pin to operate as PA9 GPIO port, instead as PA11 GPIO port.
    $04 constant SYSCFG_PA12_RMP                \ [0x04] PA12 pin remapping This bit is set and cleared by software. When set, it remaps the PA12 pin to operate as PA10 GPIO port, instead as PA12 GPIO port.
    $05 constant SYSCFG_IR_POL                  \ [0x05] IR output polarity selection
    $06 constant SYSCFG_IR_MOD                  \ [0x06 : 2] IR Modulation Envelope signal selection This bitfield selects the signal for IR modulation envelope:
    $10 constant SYSCFG_I2C_PB6_FMP             \ [0x10] Fast Mode Plus (FM+) enable for PB6 This bit is set and cleared by software. It enables I2C FM+ driving capability on PB6 I/O port. With this bit in disable state, the I2C FM+ driving capability on this I/O port can be enabled through one of I2Cx_FMP bits. When I2C FM+ is enabled, the speed control is ignored.
    $11 constant SYSCFG_I2C_PB7_FMP             \ [0x11] Fast Mode Plus (FM+) enable for PB7 This bit is set and cleared by software. It enables I2C FM+ driving capability on PB7 I/O port. With this bit in disable state, the I2C FM+ driving capability on this I/O port can be enabled through one of I2Cx_FMP bits. When I2C FM+ is enabled, the speed control is ignored.
    $12 constant SYSCFG_I2C_PB8_FMP             \ [0x12] Fast Mode Plus (FM+) enable for PB8 This bit is set and cleared by software. It enables I2C FM+ driving capability on PB8 I/O port. With this bit in disable state, the I2C FM+ driving capability on this I/O port can be enabled through one of I2Cx_FMP bits. When I2C FM+ is enabled, the speed control is ignored.
    $13 constant SYSCFG_I2C_PB9_FMP             \ [0x13] Fast Mode Plus (FM+) enable for PB9 This bit is set and cleared by software. It enables I2C FM+ driving capability on PB9 I/O port. With this bit in disable state, the I2C FM+ driving capability on this I/O port can be enabled through one of I2Cx_FMP bits. When I2C FM+ is enabled, the speed control is ignored.
    $14 constant SYSCFG_I2C1_FMP                \ [0x14] Fast Mode Plus (FM+) enable for I2C1 This bit is set and cleared by software. It enables I2C FM+ driving capability on I/O ports configured as I2C1 through GPIOx_AFR registers. With this bit in disable state, the I2C FM+ driving capability on I/O ports configured as I2C1 can be enabled through their corresponding I2Cx_FMP bit. When I2C FM+ is enabled, the speed control is ignored.
    $16 constant SYSCFG_I2C_PA9_FMP             \ [0x16] Fast Mode Plus (FM+) enable for PA9 This bit is set and cleared by software. It enables I2C FM+ driving capability on PA9 I/O port. With this bit in disable state, the I2C FM+ driving capability on this I/O port can be enabled through one of I2Cx_FMP bits. When I2C FM+ is enabled, the speed control is ignored.
    $17 constant SYSCFG_I2C_PA10_FMP            \ [0x17] Fast Mode Plus (FM+) enable for PA10 This bit is set and cleared by software. It enables I2C FM+ driving capability on PA10 I/O port. With this bit in disable state, the I2C FM+ driving capability on this I/O port can be enabled through one of I2Cx_FMP bits. When I2C FM+ is enabled, the speed control is ignored.
    $18 constant SYSCFG_I2C_PC14_FMP            \ [0x18] Fast Mode Plus (FM+) enable for PC14 This bit is set and cleared by software. It enables I2C FM+ driving capability on PC14 I/O port. With this bit in disable state, the I2C FM+ driving capability on this I/O port can be enabled through one of I2Cx_FMP bits. When I2C FM+ is enabled, the speed control is ignored.
  [then]


  [ifdef] SYSCFG_SYSCFG_CFGR2_DEF
    \
    \ @brief SYSCFG configuration register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_LOCKUP_LOCK             \ [0x00] Cortex<Superscript><Default Font>-M0+ LOCKUP enable This bit is set by software and cleared by system reset. When set, it enables the connection of Cortex<Superscript><Default Font>-M0+ LOCKUP (HardFault) output to the TIM1/16/17 Break input.
  [then]


  [ifdef] SYSCFG_SYSCFG_CFGR3_DEF
    \
    \ @brief SYSCFG configuration register 3
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_PINMUX0                 \ [0x00 : 2] Pin GPIO multiplexer 0 This bit is set by software and cleared by system reset. It assigns a GPIO to a pin. 1x: Reserved Pin F2 of WLCSP14 package GPIO assignment 1x: Reserved
    $02 constant SYSCFG_PINMUX1                 \ [0x02 : 2] Pin GPIO multiplexer 1 This bit is set by software and cleared by system reset. It assigns a GPIO to a pin. 1x: Reserved
    $04 constant SYSCFG_PINMUX2                 \ [0x04 : 2] Pin GPIO multiplexer 2 This bit is set by software and cleared by system reset. It assigns a GPIO to a pin. 1x: Reserved 1x: Reserved
    $06 constant SYSCFG_PINMUX3                 \ [0x06 : 2] Pin GPIO multiplexer 3 This bit is set by software and cleared by system reset. It assigns a GPIO to a pin. 1x: Reserved
    $08 constant SYSCFG_PINMUX4                 \ [0x08 : 2] Pin GPIO multiplexer 4 This bit is set by software and cleared by system reset. It assigns a GPIO to a pin. 1x: Reserved 1x: Reserved
    $0a constant SYSCFG_PINMUX5                 \ [0x0a : 2] Pin GPIO multiplexer 5 This bit is set by software and cleared by system reset. It assigns a GPIO to a pin. 1x: Reserved
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE0_DEF
    \
    \ @brief SYSCFG interrupt line 0 status register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_WWDG                    \ [0x00] Window watchdog interrupt pending flag
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE2_DEF
    \
    \ @brief SYSCFG interrupt line 2 status register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $01 constant SYSCFG_RTC                     \ [0x01] RTC interrupt request pending (EXTI line 19)
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE3_DEF
    \
    \ @brief SYSCFG interrupt line 3 status register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $01 constant SYSCFG_FLASH_ITF               \ [0x01] Flash interface interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE4_DEF
    \
    \ @brief SYSCFG interrupt line 4 status register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_RCC                     \ [0x00] Reset and clock control interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE5_DEF
    \
    \ @brief SYSCFG interrupt line 5 status register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_EXTI0                   \ [0x00] EXTI line 0 interrupt request pending
    $01 constant SYSCFG_EXTI1                   \ [0x01] EXTI line 1 interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE6_DEF
    \
    \ @brief SYSCFG interrupt line 6 status register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_EXTI2                   \ [0x00] EXTI line 2 interrupt request pending
    $01 constant SYSCFG_EXTI3                   \ [0x01] EXTI line 3 interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE7_DEF
    \
    \ @brief SYSCFG interrupt line 7 status register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_EXTI4                   \ [0x00] EXTI line 4 interrupt request pending
    $01 constant SYSCFG_EXTI5                   \ [0x01] EXTI line 5 interrupt request pending
    $02 constant SYSCFG_EXTI6                   \ [0x02] EXTI line 6 interrupt request pending
    $03 constant SYSCFG_EXTI7                   \ [0x03] EXTI line 7 interrupt request pending
    $04 constant SYSCFG_EXTI8                   \ [0x04] EXTI line 8 interrupt request pending
    $05 constant SYSCFG_EXTI9                   \ [0x05] EXTI line 9 interrupt request pending
    $06 constant SYSCFG_EXTI10                  \ [0x06] EXTI line 10 interrupt request pending
    $07 constant SYSCFG_EXTI11                  \ [0x07] EXTI line 11 interrupt request pending
    $08 constant SYSCFG_EXTI12                  \ [0x08] EXTI line 12 interrupt request pending
    $09 constant SYSCFG_EXTI13                  \ [0x09] EXTI line 13 interrupt request pending
    $0a constant SYSCFG_EXTI14                  \ [0x0a] EXTI line 14 interrupt request pending
    $0b constant SYSCFG_EXTI15                  \ [0x0b] EXTI line 15 interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE9_DEF
    \
    \ @brief SYSCFG interrupt line 9 status register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_DMA1_CH1                \ [0x00] DMA1 channel 1interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE10_DEF
    \
    \ @brief SYSCFG interrupt line 10 status register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_DMA1_CH2                \ [0x00] DMA1 channel 2 interrupt request pending
    $01 constant SYSCFG_DMA1_CH3                \ [0x01] DMA1 channel 3 interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE11_DEF
    \
    \ @brief SYSCFG interrupt line 11 status register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_DMAMUX                  \ [0x00] DMAMUX interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE12_DEF
    \
    \ @brief SYSCFG interrupt line 12 status register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ADC                     \ [0x00] ADC interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE13_DEF
    \
    \ @brief SYSCFG interrupt line 13 status register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TIM1_CCU                \ [0x00] Timer 1 commutation interrupt request pending
    $01 constant SYSCFG_TIM1_TRG                \ [0x01] Timer 1 trigger interrupt request pending
    $02 constant SYSCFG_TIM1_UPD                \ [0x02] Timer 1 update interrupt request pending
    $03 constant SYSCFG_TIM1_BRK                \ [0x03] Timer 1 break interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE14_DEF
    \
    \ @brief SYSCFG interrupt line 14 status register
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TIM1_CC                 \ [0x00] Timer 1 capture compare interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE16_DEF
    \
    \ @brief SYSCFG interrupt line 16 status register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TIM3                    \ [0x00] Timer 3 interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE19_DEF
    \
    \ @brief SYSCFG interrupt line 19 status register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TIM14                   \ [0x00] Timer 14 interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE21_DEF
    \
    \ @brief SYSCFG interrupt line 21 status register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TIM16                   \ [0x00] Timer 16 interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE22_DEF
    \
    \ @brief SYSCFG interrupt line 22 status register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TIM17                   \ [0x00] Timer 17 interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE23_DEF
    \
    \ @brief SYSCFG interrupt line 23 status register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_I2C1                    \ [0x00] I2C1 interrupt request pending, combined with EXTI line 23
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE25_DEF
    \
    \ @brief SYSCFG interrupt line 25 status register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_SPI1                    \ [0x00] SPI1 interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE27_DEF
    \
    \ @brief SYSCFG interrupt line 27 status register
    \ Address offset: 0xEC
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_USART1                  \ [0x00] USART1 interrupt request pending, combined with EXTI line 25
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE28_DEF
    \
    \ @brief SYSCFG interrupt line 28 status register
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_USART2                  \ [0x00] USART2 interrupt request pending (EXTI line 26)
  [then]

  \
  \ @brief SYSCFG register block
  \
  $00 constant SYSCFG_SYSCFG_CFGR1      \ SYSCFG configuration register 1
  $18 constant SYSCFG_SYSCFG_CFGR2      \ SYSCFG configuration register 2
  $3C constant SYSCFG_SYSCFG_CFGR3      \ SYSCFG configuration register 3
  $80 constant SYSCFG_SYSCFG_ITLINE0    \ SYSCFG interrupt line 0 status register
  $88 constant SYSCFG_SYSCFG_ITLINE2    \ SYSCFG interrupt line 2 status register
  $8C constant SYSCFG_SYSCFG_ITLINE3    \ SYSCFG interrupt line 3 status register
  $90 constant SYSCFG_SYSCFG_ITLINE4    \ SYSCFG interrupt line 4 status register
  $94 constant SYSCFG_SYSCFG_ITLINE5    \ SYSCFG interrupt line 5 status register
  $98 constant SYSCFG_SYSCFG_ITLINE6    \ SYSCFG interrupt line 6 status register
  $9C constant SYSCFG_SYSCFG_ITLINE7    \ SYSCFG interrupt line 7 status register
  $A4 constant SYSCFG_SYSCFG_ITLINE9    \ SYSCFG interrupt line 9 status register
  $A8 constant SYSCFG_SYSCFG_ITLINE10   \ SYSCFG interrupt line 10 status register
  $AC constant SYSCFG_SYSCFG_ITLINE11   \ SYSCFG interrupt line 11 status register
  $B0 constant SYSCFG_SYSCFG_ITLINE12   \ SYSCFG interrupt line 12 status register
  $B4 constant SYSCFG_SYSCFG_ITLINE13   \ SYSCFG interrupt line 13 status register
  $B8 constant SYSCFG_SYSCFG_ITLINE14   \ SYSCFG interrupt line 14 status register
  $C0 constant SYSCFG_SYSCFG_ITLINE16   \ SYSCFG interrupt line 16 status register
  $CC constant SYSCFG_SYSCFG_ITLINE19   \ SYSCFG interrupt line 19 status register
  $D4 constant SYSCFG_SYSCFG_ITLINE21   \ SYSCFG interrupt line 21 status register
  $D8 constant SYSCFG_SYSCFG_ITLINE22   \ SYSCFG interrupt line 22 status register
  $DC constant SYSCFG_SYSCFG_ITLINE23   \ SYSCFG interrupt line 23 status register
  $E4 constant SYSCFG_SYSCFG_ITLINE25   \ SYSCFG interrupt line 25 status register
  $EC constant SYSCFG_SYSCFG_ITLINE27   \ SYSCFG interrupt line 27 status register
  $F0 constant SYSCFG_SYSCFG_ITLINE28   \ SYSCFG interrupt line 28 status register

: SYSCFG_DEF ; [then]
