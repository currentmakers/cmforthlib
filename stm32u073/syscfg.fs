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
    $00 constant SYSCFG_MEM_MODE                \ [0x00 : 2] Memory mapping selection bits These bits are set and cleared by software. They control the memory internal mapping at address 0x000010000. After reset these bits take on the value selected by the actual boot mode configuration. Refer to Section12.5: Boot configuration for more details. X0: Main flash memory mapped at 0x000010000
    $03 constant SYSCFG_PA11_RMP                \ [0x03] PA11 pin remapping This bit is set and cleared by software. When set, it remaps the PA11 pin to operate as PA9 GPIO port, instead as PA11 GPIO port.
    $04 constant SYSCFG_PA12_RMP                \ [0x04] PA12 pin remapping This bit is set and cleared by software. When set, it remaps the PA12 pin to operate as PA10 GPIO port, instead as PA12 GPIO port.
    $05 constant SYSCFG_IR_POL                  \ [0x05] IR output polarity selection
    $06 constant SYSCFG_IR_MOD                  \ [0x06 : 2] IR Modulation Envelope signal selection This bitfield selects the signal for IR modulation envelope:
    $08 constant SYSCFG_BOOSTEN                 \ [0x08] I/O analog switch voltage booster enable This bit selects the way of supplying I/O analog switches: When using the analog inputs , setting to 0 is recommended for high V<sub>DD</sub>, setting to 1 for low V<sub>DD</sub> (less than 2.4 V).
    $10 constant SYSCFG_I2C_PB6_FMP             \ [0x10] Fast Mode Plus (FM+) enable for PB6 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on PB6 I/O port. With this bit in disable state, the I<sup>2</sup>C FM+ driving capability on this I/O port can be enabled through one of I2Cx_FMP bits. When I<sup>2</sup>C FM+ is enabled, the speed control is ignored. Note: This control bit is kept for legacy reasons. It is recommended to use the FMP bit of the I2Cx_CR1 register instead.
    $11 constant SYSCFG_I2C_PB7_FMP             \ [0x11] Fast Mode Plus (FM+) enable for PB7 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on PB7 I/O port. With this bit in disable state, the I<sup>2</sup>C FM+ driving capability on this I/O port can be enabled through one of I2Cx_FMP bits. When I<sup>2</sup>C FM+ is enabled, the speed control is ignored. Note: This control bit is kept for legacy reasons. It is recommended to use the FMP bit of the I2Cx_CR1 register instead.
    $12 constant SYSCFG_I2C_PB8_FMP             \ [0x12] Fast Mode Plus (FM+) enable for PB8 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on PB8 I/O port. With this bit in disable state, the I<sup>2</sup>C FM+ driving capability on this I/O port can be enabled through one of I2Cx_FMP bits. When I<sup>2</sup>C FM+ is enabled, the speed control is ignored. Note: This control bit is kept for legacy reasons. It is recommended to use the FMP bit of the I2Cx_CR1 register instead.
    $13 constant SYSCFG_I2C_PB9_FMP             \ [0x13] Fast Mode Plus (FM+) enable for PB9 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on PB9 I/O port. With this bit in disable state, the I<sup>2</sup>C FM+ driving capability on this I/O port can be enabled through one of I2Cx_FMP bits. When I<sup>2</sup>C FM+ is enabled, the speed control is ignored. Note: This control bit is kept for legacy reasons. It is recommended to use the FMP bit of the I2Cx_CR1 register instead.
    $16 constant SYSCFG_I2C_PA9_FMP             \ [0x16] Fast Mode Plus (FM+) enable for PA9 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on PA9 I/O port. With this bit in disable state, the I<sup>2</sup>C FM+ driving capability on this I/O port can be enabled through one of I2Cx_FMP bits. When I<sup>2</sup>C FM+ is enabled, the speed control is ignored. Note: This control bit is kept for legacy reasons. It is recommended to use the FMP bit of the I2Cx_CR1 register instead.
    $17 constant SYSCFG_I2C_PA10_FMP            \ [0x17] Fast Mode Plus (FM+) enable for PA10 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on PA10 I/O port. With this bit in disable state, the I<sup>2</sup>C FM+ driving capability on this I/O port can be enabled through one of I2Cx_FMP bits. When I<sup>2</sup>C FM+ is enabled, the speed control is ignored. Note: This control bit is kept for legacy reasons. It is recommended to use the FMP bit of the I2Cx_CR1 register instead.
    $18 constant SYSCFG_I2C3_FMP                \ [0x18] Fast Mode Plus (FM+) enable for I2C3 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on I/O ports configured as I2C3 through GPIOx_AFR registers. With this bit in disable state, the I<sup>2</sup>C FM+ driving capability on I/O ports configured as I2C3 can be enabled through their corresponding I2Cx_FMP bit. When I<sup>2</sup>C FM+ is enabled, the speed control is ignored. Note: This control bit is kept for legacy reasons. It is recommended to use the FMP bit of the I2Cx_CR1 register instead.
  [then]


  [ifdef] SYSCFG_SYSCFG_CFGR2_DEF
    \
    \ @brief SYSCFG configuration register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_CCL                     \ [0x00] Cortex<Superscript>1<Default 1 Font>-M0+ LOCKUP bit enable bit This bit is set by software and cleared by a system reset. It can be use to enable and lock the connection of Cortex<Superscript>1<Default 1 Font>-M0+ LOCKUP (Hardfault) output to TIM1/15/16 Break input.
    $01 constant SYSCFG_SPL                     \ [0x01] SRAM1 parity lock bit This bit is set by software and cleared by a system reset. It can be used to enable and lock the SRAM1 parity error signal connection to TIM1/15/16 Break input.
    $02 constant SYSCFG_PVDL                    \ [0x02] PVD lock enable bit This bit is set by software and cleared by a system reset. It can be used to enable and lock the PVD connection to TIM1/15/16 Break input, as well as the PVDE and PLS[2:0] in the PWR_CR register.
    $03 constant SYSCFG_ECCL                    \ [0x03] ECC error lock bit This bit is set by software and cleared by a system reset. It can be used to enable and lock the flash ECC 2-bit error detection signal connection to TIM1/15/16 Break input.
    $04 constant SYSCFG_BKPL                    \ [0x04] Backup SRAM2 parity lock This bit is set by software and cleared by a system reset. It can be used to enable and lock the SRAM2 parity error signal connection to TIM1/15/16 Break input.
    $07 constant SYSCFG_BKPF                    \ [0x07] Backup SRAM2 parity error flag This bit is set by hardware when an SRAM2 parity error is detected. It is cleared by software by writing 1.
    $08 constant SYSCFG_SPF                     \ [0x08] SRAM1 parity error flag This bit is set by hardware when an SRAM1 parity error is detected. It is cleared by software by writing 1.
  [then]


  [ifdef] SYSCFG_SYSCFG_SCSR_DEF
    \
    \ @brief SYSCFG SRAM2 control and status register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_SRAM2ER                 \ [0x00] SRAM2 erase Setting this bit starts a hardware SRAM2 erase operation. This bit is automatically cleared at the end of the SRAM2 erase operation. Note: This bit is write-protected: setting this bit is possible only after the correct key sequence is written in the SYSCFG_SKR register.
    $01 constant SYSCFG_SRAM2BSY                \ [0x01] SRAM2 busy by erase operation
  [then]


  [ifdef] SYSCFG_SYSCFG_SKR_DEF
    \
    \ @brief SYSCFG SRAM2 key register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_KEY                     \ [0x00 : 8] SRAM2 write protection key for software erase The following steps are required to unlock the write protection of the SRAM2ER bit in the SYSCFG_CFGR2 register: Write 0xCA into KEY[7:0] Write 0x53 into KEY[7:0] Writing a wrong key reactivates the write protection.
  [then]


  [ifdef] SYSCFG_SYSCFG_TSCCR_DEF
    \
    \ @brief SYSCFG TSC comparator register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_G2_IO1                  \ [0x00] Comparator mode for group 2 on I/O 1
    $01 constant SYSCFG_G2_IO3                  \ [0x01] Comparator mode for group 2 on I/O 3
    $02 constant SYSCFG_G4_IO3                  \ [0x02] Comparator mode for group 4 on I/O 3
    $03 constant SYSCFG_G6_IO1                  \ [0x03] Comparator mode for group 6 on I/O 1
    $04 constant SYSCFG_G7_IO1                  \ [0x04] Comparator mode for group 7 on I/O 1
    $05 constant SYSCFG_TSC_IOCTRL              \ [0x05] I/O control in comparator mode The I/O control in comparator mode can be overwritten by hardware.
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE0_DEF
    \
    \ @brief SYSCFG interrupt line 0 status register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_WWDG                    \ [0x00] Window watchdog interrupt pending flag
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE1_DEF
    \
    \ @brief SYSCFG interrupt line 1 status register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_PVDOUT                  \ [0x00] PVD supply monitoring interrupt request pending (EXTI line 16).
    $01 constant SYSCFG_PVMOUT1                 \ [0x01] V<sub>DDUSB</sub> supply monitoring interrupt request pending (EXTI line 19)
    $02 constant SYSCFG_PVMOUT3                 \ [0x02] ADC supply monitoring interrupt request pending (EXTI line 20)
    $03 constant SYSCFG_PVMOUT4                 \ [0x03] DAC supply monitoring interrupt request pending (EXTI line 21)
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE2_DEF
    \
    \ @brief SYSCFG interrupt line 2 status register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TAMP                    \ [0x00] Tamper interrupt request pending (EXTI line 21)
    $01 constant SYSCFG_RTC                     \ [0x01] RTC interrupt request pending (EXTI line 19)
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE3_DEF
    \
    \ @brief SYSCFG interrupt line 3 status register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_FLASH_ITF               \ [0x00] Flash interface interrupt request pending
    $01 constant SYSCFG_FLASH_ECC               \ [0x01] Flash interface ECC interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE4_DEF
    \
    \ @brief SYSCFG interrupt line 4 status register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_RCC                     \ [0x00] Reset and clock control interrupt request pending
    $01 constant SYSCFG_CRS                     \ [0x01] CRS interrupt request pending
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


  [ifdef] SYSCFG_SYSCFG_ITLINE8_DEF
    \
    \ @brief SYSCFG interrupt line 8 status register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_USB                     \ [0x00] USB interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE9_DEF
    \
    \ @brief SYSCFG interrupt line 9 status register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_DMA1_CH1                \ [0x00] DMA1 channel 1 interrupt request pending
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
    $01 constant SYSCFG_DMA1_CH4                \ [0x01] DMA1 channel 4 interrupt request pending
    $02 constant SYSCFG_DMA1_CH5                \ [0x02] DMA1 channel 5 interrupt request pending
    $03 constant SYSCFG_DMA1_CH6                \ [0x03] DMA1 channel 6 interrupt request pending
    $04 constant SYSCFG_DMA1_CH7                \ [0x04] DMA1 channel 7 interrupt request pending
    $05 constant SYSCFG_DMA2_CH1                \ [0x05] DMA2 channel 1 interrupt request pending
    $06 constant SYSCFG_DMA2_CH2                \ [0x06] DMA2 channel 2 interrupt request pending
    $07 constant SYSCFG_DMA2_CH3                \ [0x07] DMA2 channel 3 interrupt request pending
    $08 constant SYSCFG_DMA2_CH4                \ [0x08] DMA2 channel 4 interrupt request pending
    $09 constant SYSCFG_DMA2_CH5                \ [0x09] DMA2 channel 5 interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE12_DEF
    \
    \ @brief SYSCFG interrupt line 12 status register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ADC                     \ [0x00] ADC interrupt request pending
    $01 constant SYSCFG_COMP1                   \ [0x01] Comparator 1 interrupt request pending (EXTI line 17)
    $02 constant SYSCFG_COMP2                   \ [0x02] Comparator 2 interrupt request pending (EXTI line 18)
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
    $00 constant SYSCFG_TIM1_CC1                \ [0x00] Timer 1 capture compare 1 interrupt request pending
    $01 constant SYSCFG_TIM1_CC2                \ [0x01] Timer 1 capture compare 2 interrupt request pending
    $02 constant SYSCFG_TIM1_CC3                \ [0x02] Timer 1 capture compare 3 interrupt request pending
    $03 constant SYSCFG_TIM1_CC4                \ [0x03] Timer 1 capture compare 4 interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE15_DEF
    \
    \ @brief SYSCFG interrupt line 15 status register
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TIM2                    \ [0x00] Timer 2 interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE16_DEF
    \
    \ @brief SYSCFG interrupt line 16 status register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TIM3                    \ [0x00] Timer 3 interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE17_DEF
    \
    \ @brief SYSCFG interrupt line 17 status register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TIM6                    \ [0x00] Timer 6 interrupt request pending
    $01 constant SYSCFG_DAC                     \ [0x01] DAC underrun interrupt request pending
    $02 constant SYSCFG_LPTIM1                  \ [0x02] Low-power timer 1 interrupt request pending (EXTI line 29)
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE18_DEF
    \
    \ @brief SYSCFG interrupt line 18 status register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TIM7                    \ [0x00] Timer 7 interrupt request pending
    $01 constant SYSCFG_LPTIM2                  \ [0x01] Low-power timer 2 interrupt request pending (EXTI line 30)
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE19_DEF
    \
    \ @brief SYSCFG interrupt line 19 status register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TIM15                   \ [0x00] Timer 15 interrupt request pending
    $01 constant SYSCFG_LPTIM3                  \ [0x01] Low-power timer 3 interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE20_DEF
    \
    \ @brief SYSCFG interrupt line 20 status register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TIM16                   \ [0x00] Timer 16 interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE21_DEF
    \
    \ @brief SYSCFG interrupt line 21 status register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TSC_MCE                 \ [0x00] TSC max count error interrupt request pending
    $01 constant SYSCFG_TSC_EOA                 \ [0x01] TSC end of acquisition interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE22_DEF
    \
    \ @brief SYSCFG interrupt line 22 status register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_LCD                     \ [0x00] LCD interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE23_DEF
    \
    \ @brief SYSCFG interrupt line 23 status register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_I2C1                    \ [0x00] I2C1 interrupt request pending (EXTI line 33)
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE24_DEF
    \
    \ @brief SYSCFG interrupt line 24 status register
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_I2C2                    \ [0x00] I2C2 interrupt request pending
    $01 constant SYSCFG_I2C4                    \ [0x01] I2C4 interrupt request pending
    $02 constant SYSCFG_I2C3                    \ [0x02] I2C3 interrupt request pending (EXTI line 23)
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE25_DEF
    \
    \ @brief SYSCFG interrupt line 25 status register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_SPI1                    \ [0x00] SPI1 interrupt request pending
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE26_DEF
    \
    \ @brief SYSCFG interrupt line 26 status register
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_SPI2                    \ [0x00] SPI2 interrupt request pending
    $01 constant SYSCFG_SPI3                    \ [0x01] SPI3 interrupt request pending
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
    $00 constant SYSCFG_USART2                  \ [0x00] USART2 interrupt request pending (EXTI line 35)
    $01 constant SYSCFG_LPUART2                 \ [0x01] LPUART2 interrupt request pending (EXTI line 31)
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE29_DEF
    \
    \ @brief SYSCFG interrupt line 29 status register
    \ Address offset: 0xF4
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_USART3                  \ [0x00] USART3 interrupt request pending
    $01 constant SYSCFG_LPUART1                 \ [0x01] LPUART1 interrupt request pending (EXTI line 30)
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE30_DEF
    \
    \ @brief SYSCFG interrupt line 30 status register
    \ Address offset: 0xF8
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_USART4                  \ [0x00] USART4 interrupt request pending
    $01 constant SYSCFG_LPUART3                 \ [0x01] LPUART3 interrupt request pending (EXTI line 32)
  [then]


  [ifdef] SYSCFG_SYSCFG_ITLINE31_DEF
    \
    \ @brief SYSCFG interrupt line 31 status register
    \ Address offset: 0xFC
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_RNG                     \ [0x00] RNG interrupt request pending
  [then]

  \
  \ @brief SYSCFG register block
  \
  $00 constant SYSCFG_SYSCFG_CFGR1      \ SYSCFG configuration register 1
  $18 constant SYSCFG_SYSCFG_CFGR2      \ SYSCFG configuration register 2
  $1C constant SYSCFG_SYSCFG_SCSR       \ SYSCFG SRAM2 control and status register
  $20 constant SYSCFG_SYSCFG_SKR        \ SYSCFG SRAM2 key register
  $24 constant SYSCFG_SYSCFG_TSCCR      \ SYSCFG TSC comparator register
  $80 constant SYSCFG_SYSCFG_ITLINE0    \ SYSCFG interrupt line 0 status register
  $84 constant SYSCFG_SYSCFG_ITLINE1    \ SYSCFG interrupt line 1 status register
  $88 constant SYSCFG_SYSCFG_ITLINE2    \ SYSCFG interrupt line 2 status register
  $8C constant SYSCFG_SYSCFG_ITLINE3    \ SYSCFG interrupt line 3 status register
  $90 constant SYSCFG_SYSCFG_ITLINE4    \ SYSCFG interrupt line 4 status register
  $94 constant SYSCFG_SYSCFG_ITLINE5    \ SYSCFG interrupt line 5 status register
  $98 constant SYSCFG_SYSCFG_ITLINE6    \ SYSCFG interrupt line 6 status register
  $9C constant SYSCFG_SYSCFG_ITLINE7    \ SYSCFG interrupt line 7 status register
  $A0 constant SYSCFG_SYSCFG_ITLINE8    \ SYSCFG interrupt line 8 status register
  $A4 constant SYSCFG_SYSCFG_ITLINE9    \ SYSCFG interrupt line 9 status register
  $A8 constant SYSCFG_SYSCFG_ITLINE10   \ SYSCFG interrupt line 10 status register
  $AC constant SYSCFG_SYSCFG_ITLINE11   \ SYSCFG interrupt line 11 status register
  $B0 constant SYSCFG_SYSCFG_ITLINE12   \ SYSCFG interrupt line 12 status register
  $B4 constant SYSCFG_SYSCFG_ITLINE13   \ SYSCFG interrupt line 13 status register
  $B8 constant SYSCFG_SYSCFG_ITLINE14   \ SYSCFG interrupt line 14 status register
  $BC constant SYSCFG_SYSCFG_ITLINE15   \ SYSCFG interrupt line 15 status register
  $C0 constant SYSCFG_SYSCFG_ITLINE16   \ SYSCFG interrupt line 16 status register
  $C4 constant SYSCFG_SYSCFG_ITLINE17   \ SYSCFG interrupt line 17 status register
  $C8 constant SYSCFG_SYSCFG_ITLINE18   \ SYSCFG interrupt line 18 status register
  $CC constant SYSCFG_SYSCFG_ITLINE19   \ SYSCFG interrupt line 19 status register
  $D0 constant SYSCFG_SYSCFG_ITLINE20   \ SYSCFG interrupt line 20 status register
  $D4 constant SYSCFG_SYSCFG_ITLINE21   \ SYSCFG interrupt line 21 status register
  $D8 constant SYSCFG_SYSCFG_ITLINE22   \ SYSCFG interrupt line 22 status register
  $DC constant SYSCFG_SYSCFG_ITLINE23   \ SYSCFG interrupt line 23 status register
  $E0 constant SYSCFG_SYSCFG_ITLINE24   \ SYSCFG interrupt line 24 status register
  $E4 constant SYSCFG_SYSCFG_ITLINE25   \ SYSCFG interrupt line 25 status register
  $E8 constant SYSCFG_SYSCFG_ITLINE26   \ SYSCFG interrupt line 26 status register
  $EC constant SYSCFG_SYSCFG_ITLINE27   \ SYSCFG interrupt line 27 status register
  $F0 constant SYSCFG_SYSCFG_ITLINE28   \ SYSCFG interrupt line 28 status register
  $F4 constant SYSCFG_SYSCFG_ITLINE29   \ SYSCFG interrupt line 29 status register
  $F8 constant SYSCFG_SYSCFG_ITLINE30   \ SYSCFG interrupt line 30 status register
  $FC constant SYSCFG_SYSCFG_ITLINE31   \ SYSCFG interrupt line 31 status register

: SYSCFG_DEF ; [then]
