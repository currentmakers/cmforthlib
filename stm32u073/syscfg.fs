\
\ @file syscfg.fs
\ @brief SYSCFG register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SYSCFG configuration register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant SYSCFG_SYSCFG_CFGR1_MEM_MODE                     \ Memory mapping selection bits These bits are set and cleared by software. They control the memory internal mapping at address 0x000010000. After reset these bits take on the value selected by the actual boot mode configuration. Refer to Section12.5: Boot configuration for more details. X0: Main flash memory mapped at 0x000010000
$00000008 constant SYSCFG_SYSCFG_CFGR1_PA11_RMP                     \ PA11 pin remapping This bit is set and cleared by software. When set, it remaps the PA11 pin to operate as PA9 GPIO port, instead as PA11 GPIO port.
$00000010 constant SYSCFG_SYSCFG_CFGR1_PA12_RMP                     \ PA12 pin remapping This bit is set and cleared by software. When set, it remaps the PA12 pin to operate as PA10 GPIO port, instead as PA12 GPIO port.
$00000020 constant SYSCFG_SYSCFG_CFGR1_IR_POL                       \ IR output polarity selection
$000000c0 constant SYSCFG_SYSCFG_CFGR1_IR_MOD                       \ IR Modulation Envelope signal selection This bitfield selects the signal for IR modulation envelope:
$00000100 constant SYSCFG_SYSCFG_CFGR1_BOOSTEN                      \ I/O analog switch voltage booster enable This bit selects the way of supplying I/O analog switches: When using the analog inputs , setting to 0 is recommended for high V<sub>DD</sub>, setting to 1 for low V<sub>DD</sub> (less than 2.4 V).
$00010000 constant SYSCFG_SYSCFG_CFGR1_I2C_PB6_FMP                  \ Fast Mode Plus (FM+) enable for PB6 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on PB6 I/O port. With this bit in disable state, the I<sup>2</sup>C FM+ driving capability on this I/O port can be enabled through one of I2Cx_FMP bits. When I<sup>2</sup>C FM+ is enabled, the speed control is ignored. Note: This control bit is kept for legacy reasons. It is recommended to use the FMP bit of the I2Cx_CR1 register instead.
$00020000 constant SYSCFG_SYSCFG_CFGR1_I2C_PB7_FMP                  \ Fast Mode Plus (FM+) enable for PB7 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on PB7 I/O port. With this bit in disable state, the I<sup>2</sup>C FM+ driving capability on this I/O port can be enabled through one of I2Cx_FMP bits. When I<sup>2</sup>C FM+ is enabled, the speed control is ignored. Note: This control bit is kept for legacy reasons. It is recommended to use the FMP bit of the I2Cx_CR1 register instead.
$00040000 constant SYSCFG_SYSCFG_CFGR1_I2C_PB8_FMP                  \ Fast Mode Plus (FM+) enable for PB8 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on PB8 I/O port. With this bit in disable state, the I<sup>2</sup>C FM+ driving capability on this I/O port can be enabled through one of I2Cx_FMP bits. When I<sup>2</sup>C FM+ is enabled, the speed control is ignored. Note: This control bit is kept for legacy reasons. It is recommended to use the FMP bit of the I2Cx_CR1 register instead.
$00080000 constant SYSCFG_SYSCFG_CFGR1_I2C_PB9_FMP                  \ Fast Mode Plus (FM+) enable for PB9 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on PB9 I/O port. With this bit in disable state, the I<sup>2</sup>C FM+ driving capability on this I/O port can be enabled through one of I2Cx_FMP bits. When I<sup>2</sup>C FM+ is enabled, the speed control is ignored. Note: This control bit is kept for legacy reasons. It is recommended to use the FMP bit of the I2Cx_CR1 register instead.
$00400000 constant SYSCFG_SYSCFG_CFGR1_I2C_PA9_FMP                  \ Fast Mode Plus (FM+) enable for PA9 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on PA9 I/O port. With this bit in disable state, the I<sup>2</sup>C FM+ driving capability on this I/O port can be enabled through one of I2Cx_FMP bits. When I<sup>2</sup>C FM+ is enabled, the speed control is ignored. Note: This control bit is kept for legacy reasons. It is recommended to use the FMP bit of the I2Cx_CR1 register instead.
$00800000 constant SYSCFG_SYSCFG_CFGR1_I2C_PA10_FMP                 \ Fast Mode Plus (FM+) enable for PA10 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on PA10 I/O port. With this bit in disable state, the I<sup>2</sup>C FM+ driving capability on this I/O port can be enabled through one of I2Cx_FMP bits. When I<sup>2</sup>C FM+ is enabled, the speed control is ignored. Note: This control bit is kept for legacy reasons. It is recommended to use the FMP bit of the I2Cx_CR1 register instead.
$01000000 constant SYSCFG_SYSCFG_CFGR1_I2C3_FMP                     \ Fast Mode Plus (FM+) enable for I2C3 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on I/O ports configured as I2C3 through GPIOx_AFR registers. With this bit in disable state, the I<sup>2</sup>C FM+ driving capability on I/O ports configured as I2C3 can be enabled through their corresponding I2Cx_FMP bit. When I<sup>2</sup>C FM+ is enabled, the speed control is ignored. Note: This control bit is kept for legacy reasons. It is recommended to use the FMP bit of the I2Cx_CR1 register instead.


\
\ @brief SYSCFG configuration register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_CFGR2_CCL                          \ Cortex<Superscript>1<Default 1 Font>-M0+ LOCKUP bit enable bit This bit is set by software and cleared by a system reset. It can be use to enable and lock the connection of Cortex<Superscript>1<Default 1 Font>-M0+ LOCKUP (Hardfault) output to TIM1/15/16 Break input.
$00000002 constant SYSCFG_SYSCFG_CFGR2_SPL                          \ SRAM1 parity lock bit This bit is set by software and cleared by a system reset. It can be used to enable and lock the SRAM1 parity error signal connection to TIM1/15/16 Break input.
$00000004 constant SYSCFG_SYSCFG_CFGR2_PVDL                         \ PVD lock enable bit This bit is set by software and cleared by a system reset. It can be used to enable and lock the PVD connection to TIM1/15/16 Break input, as well as the PVDE and PLS[2:0] in the PWR_CR register.
$00000008 constant SYSCFG_SYSCFG_CFGR2_ECCL                         \ ECC error lock bit This bit is set by software and cleared by a system reset. It can be used to enable and lock the flash ECC 2-bit error detection signal connection to TIM1/15/16 Break input.
$00000010 constant SYSCFG_SYSCFG_CFGR2_BKPL                         \ Backup SRAM2 parity lock This bit is set by software and cleared by a system reset. It can be used to enable and lock the SRAM2 parity error signal connection to TIM1/15/16 Break input.
$00000080 constant SYSCFG_SYSCFG_CFGR2_BKPF                         \ Backup SRAM2 parity error flag This bit is set by hardware when an SRAM2 parity error is detected. It is cleared by software by writing 1.
$00000100 constant SYSCFG_SYSCFG_CFGR2_SPF                          \ SRAM1 parity error flag This bit is set by hardware when an SRAM1 parity error is detected. It is cleared by software by writing 1.


\
\ @brief SYSCFG SRAM2 control and status register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_SCSR_SRAM2ER                       \ SRAM2 erase Setting this bit starts a hardware SRAM2 erase operation. This bit is automatically cleared at the end of the SRAM2 erase operation. Note: This bit is write-protected: setting this bit is possible only after the correct key sequence is written in the SYSCFG_SKR register.
$00000002 constant SYSCFG_SYSCFG_SCSR_SRAM2BSY                      \ SRAM2 busy by erase operation


\
\ @brief SYSCFG SRAM2 key register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant SYSCFG_SYSCFG_SKR_KEY                            \ SRAM2 write protection key for software erase The following steps are required to unlock the write protection of the SRAM2ER bit in the SYSCFG_CFGR2 register: Write 0xCA into KEY[7:0] Write 0x53 into KEY[7:0] Writing a wrong key reactivates the write protection.


\
\ @brief SYSCFG TSC comparator register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_TSCCR_G2_IO1                       \ Comparator mode for group 2 on I/O 1
$00000002 constant SYSCFG_SYSCFG_TSCCR_G2_IO3                       \ Comparator mode for group 2 on I/O 3
$00000004 constant SYSCFG_SYSCFG_TSCCR_G4_IO3                       \ Comparator mode for group 4 on I/O 3
$00000008 constant SYSCFG_SYSCFG_TSCCR_G6_IO1                       \ Comparator mode for group 6 on I/O 1
$00000010 constant SYSCFG_SYSCFG_TSCCR_G7_IO1                       \ Comparator mode for group 7 on I/O 1
$00000020 constant SYSCFG_SYSCFG_TSCCR_TSC_IOCTRL                   \ I/O control in comparator mode The I/O control in comparator mode can be overwritten by hardware.


\
\ @brief SYSCFG interrupt line 0 status register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE0_WWDG                       \ Window watchdog interrupt pending flag


\
\ @brief SYSCFG interrupt line 1 status register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE1_PVDOUT                     \ PVD supply monitoring interrupt request pending (EXTI line 16).
$00000002 constant SYSCFG_SYSCFG_ITLINE1_PVMOUT1                    \ V<sub>DDUSB</sub> supply monitoring interrupt request pending (EXTI line 19)
$00000004 constant SYSCFG_SYSCFG_ITLINE1_PVMOUT3                    \ ADC supply monitoring interrupt request pending (EXTI line 20)
$00000008 constant SYSCFG_SYSCFG_ITLINE1_PVMOUT4                    \ DAC supply monitoring interrupt request pending (EXTI line 21)


\
\ @brief SYSCFG interrupt line 2 status register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE2_TAMP                       \ Tamper interrupt request pending (EXTI line 21)
$00000002 constant SYSCFG_SYSCFG_ITLINE2_RTC                        \ RTC interrupt request pending (EXTI line 19)


\
\ @brief SYSCFG interrupt line 3 status register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE3_FLASH_ITF                  \ Flash interface interrupt request pending
$00000002 constant SYSCFG_SYSCFG_ITLINE3_FLASH_ECC                  \ Flash interface ECC interrupt request pending


\
\ @brief SYSCFG interrupt line 4 status register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE4_RCC                        \ Reset and clock control interrupt request pending
$00000002 constant SYSCFG_SYSCFG_ITLINE4_CRS                        \ CRS interrupt request pending


\
\ @brief SYSCFG interrupt line 5 status register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE5_EXTI0                      \ EXTI line 0 interrupt request pending
$00000002 constant SYSCFG_SYSCFG_ITLINE5_EXTI1                      \ EXTI line 1 interrupt request pending


\
\ @brief SYSCFG interrupt line 6 status register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE6_EXTI2                      \ EXTI line 2 interrupt request pending
$00000002 constant SYSCFG_SYSCFG_ITLINE6_EXTI3                      \ EXTI line 3 interrupt request pending


\
\ @brief SYSCFG interrupt line 7 status register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE7_EXTI4                      \ EXTI line 4 interrupt request pending
$00000002 constant SYSCFG_SYSCFG_ITLINE7_EXTI5                      \ EXTI line 5 interrupt request pending
$00000004 constant SYSCFG_SYSCFG_ITLINE7_EXTI6                      \ EXTI line 6 interrupt request pending
$00000008 constant SYSCFG_SYSCFG_ITLINE7_EXTI7                      \ EXTI line 7 interrupt request pending
$00000010 constant SYSCFG_SYSCFG_ITLINE7_EXTI8                      \ EXTI line 8 interrupt request pending
$00000020 constant SYSCFG_SYSCFG_ITLINE7_EXTI9                      \ EXTI line 9 interrupt request pending
$00000040 constant SYSCFG_SYSCFG_ITLINE7_EXTI10                     \ EXTI line 10 interrupt request pending
$00000080 constant SYSCFG_SYSCFG_ITLINE7_EXTI11                     \ EXTI line 11 interrupt request pending
$00000100 constant SYSCFG_SYSCFG_ITLINE7_EXTI12                     \ EXTI line 12 interrupt request pending
$00000200 constant SYSCFG_SYSCFG_ITLINE7_EXTI13                     \ EXTI line 13 interrupt request pending
$00000400 constant SYSCFG_SYSCFG_ITLINE7_EXTI14                     \ EXTI line 14 interrupt request pending
$00000800 constant SYSCFG_SYSCFG_ITLINE7_EXTI15                     \ EXTI line 15 interrupt request pending


\
\ @brief SYSCFG interrupt line 8 status register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE8_USB                        \ USB interrupt request pending


\
\ @brief SYSCFG interrupt line 9 status register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE9_DMA1_CH1                   \ DMA1 channel 1 interrupt request pending


\
\ @brief SYSCFG interrupt line 10 status register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE10_DMA1_CH2                  \ DMA1 channel 2 interrupt request pending
$00000002 constant SYSCFG_SYSCFG_ITLINE10_DMA1_CH3                  \ DMA1 channel 3 interrupt request pending


\
\ @brief SYSCFG interrupt line 11 status register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE11_DMAMUX                    \ DMAMUX interrupt request pending
$00000002 constant SYSCFG_SYSCFG_ITLINE11_DMA1_CH4                  \ DMA1 channel 4 interrupt request pending
$00000004 constant SYSCFG_SYSCFG_ITLINE11_DMA1_CH5                  \ DMA1 channel 5 interrupt request pending
$00000008 constant SYSCFG_SYSCFG_ITLINE11_DMA1_CH6                  \ DMA1 channel 6 interrupt request pending
$00000010 constant SYSCFG_SYSCFG_ITLINE11_DMA1_CH7                  \ DMA1 channel 7 interrupt request pending
$00000020 constant SYSCFG_SYSCFG_ITLINE11_DMA2_CH1                  \ DMA2 channel 1 interrupt request pending
$00000040 constant SYSCFG_SYSCFG_ITLINE11_DMA2_CH2                  \ DMA2 channel 2 interrupt request pending
$00000080 constant SYSCFG_SYSCFG_ITLINE11_DMA2_CH3                  \ DMA2 channel 3 interrupt request pending
$00000100 constant SYSCFG_SYSCFG_ITLINE11_DMA2_CH4                  \ DMA2 channel 4 interrupt request pending
$00000200 constant SYSCFG_SYSCFG_ITLINE11_DMA2_CH5                  \ DMA2 channel 5 interrupt request pending


\
\ @brief SYSCFG interrupt line 12 status register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE12_ADC                       \ ADC interrupt request pending
$00000002 constant SYSCFG_SYSCFG_ITLINE12_COMP1                     \ Comparator 1 interrupt request pending (EXTI line 17)
$00000004 constant SYSCFG_SYSCFG_ITLINE12_COMP2                     \ Comparator 2 interrupt request pending (EXTI line 18)


\
\ @brief SYSCFG interrupt line 13 status register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE13_TIM1_CCU                  \ Timer 1 commutation interrupt request pending
$00000002 constant SYSCFG_SYSCFG_ITLINE13_TIM1_TRG                  \ Timer 1 trigger interrupt request pending
$00000004 constant SYSCFG_SYSCFG_ITLINE13_TIM1_UPD                  \ Timer 1 update interrupt request pending
$00000008 constant SYSCFG_SYSCFG_ITLINE13_TIM1_BRK                  \ Timer 1 break interrupt request pending


\
\ @brief SYSCFG interrupt line 14 status register
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE14_TIM1_CC1                  \ Timer 1 capture compare 1 interrupt request pending
$00000002 constant SYSCFG_SYSCFG_ITLINE14_TIM1_CC2                  \ Timer 1 capture compare 2 interrupt request pending
$00000004 constant SYSCFG_SYSCFG_ITLINE14_TIM1_CC3                  \ Timer 1 capture compare 3 interrupt request pending
$00000008 constant SYSCFG_SYSCFG_ITLINE14_TIM1_CC4                  \ Timer 1 capture compare 4 interrupt request pending


\
\ @brief SYSCFG interrupt line 15 status register
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE15_TIM2                      \ Timer 2 interrupt request pending


\
\ @brief SYSCFG interrupt line 16 status register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE16_TIM3                      \ Timer 3 interrupt request pending


\
\ @brief SYSCFG interrupt line 17 status register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE17_TIM6                      \ Timer 6 interrupt request pending
$00000002 constant SYSCFG_SYSCFG_ITLINE17_DAC                       \ DAC underrun interrupt request pending
$00000004 constant SYSCFG_SYSCFG_ITLINE17_LPTIM1                    \ Low-power timer 1 interrupt request pending (EXTI line 29)


\
\ @brief SYSCFG interrupt line 18 status register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE18_TIM7                      \ Timer 7 interrupt request pending
$00000002 constant SYSCFG_SYSCFG_ITLINE18_LPTIM2                    \ Low-power timer 2 interrupt request pending (EXTI line 30)


\
\ @brief SYSCFG interrupt line 19 status register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE19_TIM15                     \ Timer 15 interrupt request pending
$00000002 constant SYSCFG_SYSCFG_ITLINE19_LPTIM3                    \ Low-power timer 3 interrupt request pending


\
\ @brief SYSCFG interrupt line 20 status register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE20_TIM16                     \ Timer 16 interrupt request pending


\
\ @brief SYSCFG interrupt line 21 status register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE21_TSC_MCE                   \ TSC max count error interrupt request pending
$00000002 constant SYSCFG_SYSCFG_ITLINE21_TSC_EOA                   \ TSC end of acquisition interrupt request pending


\
\ @brief SYSCFG interrupt line 22 status register
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE22_LCD                       \ LCD interrupt request pending


\
\ @brief SYSCFG interrupt line 23 status register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE23_I2C1                      \ I2C1 interrupt request pending (EXTI line 33)


\
\ @brief SYSCFG interrupt line 24 status register
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE24_I2C2                      \ I2C2 interrupt request pending
$00000002 constant SYSCFG_SYSCFG_ITLINE24_I2C4                      \ I2C4 interrupt request pending
$00000004 constant SYSCFG_SYSCFG_ITLINE24_I2C3                      \ I2C3 interrupt request pending (EXTI line 23)


\
\ @brief SYSCFG interrupt line 25 status register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE25_SPI1                      \ SPI1 interrupt request pending


\
\ @brief SYSCFG interrupt line 26 status register
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE26_SPI2                      \ SPI2 interrupt request pending
$00000002 constant SYSCFG_SYSCFG_ITLINE26_SPI3                      \ SPI3 interrupt request pending


\
\ @brief SYSCFG interrupt line 27 status register
\ Address offset: 0xEC
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE27_USART1                    \ USART1 interrupt request pending, combined with EXTI line 25


\
\ @brief SYSCFG interrupt line 28 status register
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE28_USART2                    \ USART2 interrupt request pending (EXTI line 35)
$00000002 constant SYSCFG_SYSCFG_ITLINE28_LPUART2                   \ LPUART2 interrupt request pending (EXTI line 31)


\
\ @brief SYSCFG interrupt line 29 status register
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE29_USART3                    \ USART3 interrupt request pending
$00000002 constant SYSCFG_SYSCFG_ITLINE29_LPUART1                   \ LPUART1 interrupt request pending (EXTI line 30)


\
\ @brief SYSCFG interrupt line 30 status register
\ Address offset: 0xF8
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE30_USART4                    \ USART4 interrupt request pending
$00000002 constant SYSCFG_SYSCFG_ITLINE30_LPUART3                   \ LPUART3 interrupt request pending (EXTI line 32)


\
\ @brief SYSCFG interrupt line 31 status register
\ Address offset: 0xFC
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE31_RNG                       \ RNG interrupt request pending


\
\ @brief SYSCFG register block
\
$40010000 constant SYSCFG_SYSCFG_CFGR1  \ offset: 0x00 : SYSCFG configuration register 1
$40010018 constant SYSCFG_SYSCFG_CFGR2  \ offset: 0x18 : SYSCFG configuration register 2
$4001001c constant SYSCFG_SYSCFG_SCSR  \ offset: 0x1C : SYSCFG SRAM2 control and status register
$40010020 constant SYSCFG_SYSCFG_SKR  \ offset: 0x20 : SYSCFG SRAM2 key register
$40010024 constant SYSCFG_SYSCFG_TSCCR  \ offset: 0x24 : SYSCFG TSC comparator register
$40010080 constant SYSCFG_SYSCFG_ITLINE0  \ offset: 0x80 : SYSCFG interrupt line 0 status register
$40010084 constant SYSCFG_SYSCFG_ITLINE1  \ offset: 0x84 : SYSCFG interrupt line 1 status register
$40010088 constant SYSCFG_SYSCFG_ITLINE2  \ offset: 0x88 : SYSCFG interrupt line 2 status register
$4001008c constant SYSCFG_SYSCFG_ITLINE3  \ offset: 0x8C : SYSCFG interrupt line 3 status register
$40010090 constant SYSCFG_SYSCFG_ITLINE4  \ offset: 0x90 : SYSCFG interrupt line 4 status register
$40010094 constant SYSCFG_SYSCFG_ITLINE5  \ offset: 0x94 : SYSCFG interrupt line 5 status register
$40010098 constant SYSCFG_SYSCFG_ITLINE6  \ offset: 0x98 : SYSCFG interrupt line 6 status register
$4001009c constant SYSCFG_SYSCFG_ITLINE7  \ offset: 0x9C : SYSCFG interrupt line 7 status register
$400100a0 constant SYSCFG_SYSCFG_ITLINE8  \ offset: 0xA0 : SYSCFG interrupt line 8 status register
$400100a4 constant SYSCFG_SYSCFG_ITLINE9  \ offset: 0xA4 : SYSCFG interrupt line 9 status register
$400100a8 constant SYSCFG_SYSCFG_ITLINE10  \ offset: 0xA8 : SYSCFG interrupt line 10 status register
$400100ac constant SYSCFG_SYSCFG_ITLINE11  \ offset: 0xAC : SYSCFG interrupt line 11 status register
$400100b0 constant SYSCFG_SYSCFG_ITLINE12  \ offset: 0xB0 : SYSCFG interrupt line 12 status register
$400100b4 constant SYSCFG_SYSCFG_ITLINE13  \ offset: 0xB4 : SYSCFG interrupt line 13 status register
$400100b8 constant SYSCFG_SYSCFG_ITLINE14  \ offset: 0xB8 : SYSCFG interrupt line 14 status register
$400100bc constant SYSCFG_SYSCFG_ITLINE15  \ offset: 0xBC : SYSCFG interrupt line 15 status register
$400100c0 constant SYSCFG_SYSCFG_ITLINE16  \ offset: 0xC0 : SYSCFG interrupt line 16 status register
$400100c4 constant SYSCFG_SYSCFG_ITLINE17  \ offset: 0xC4 : SYSCFG interrupt line 17 status register
$400100c8 constant SYSCFG_SYSCFG_ITLINE18  \ offset: 0xC8 : SYSCFG interrupt line 18 status register
$400100cc constant SYSCFG_SYSCFG_ITLINE19  \ offset: 0xCC : SYSCFG interrupt line 19 status register
$400100d0 constant SYSCFG_SYSCFG_ITLINE20  \ offset: 0xD0 : SYSCFG interrupt line 20 status register
$400100d4 constant SYSCFG_SYSCFG_ITLINE21  \ offset: 0xD4 : SYSCFG interrupt line 21 status register
$400100d8 constant SYSCFG_SYSCFG_ITLINE22  \ offset: 0xD8 : SYSCFG interrupt line 22 status register
$400100dc constant SYSCFG_SYSCFG_ITLINE23  \ offset: 0xDC : SYSCFG interrupt line 23 status register
$400100e0 constant SYSCFG_SYSCFG_ITLINE24  \ offset: 0xE0 : SYSCFG interrupt line 24 status register
$400100e4 constant SYSCFG_SYSCFG_ITLINE25  \ offset: 0xE4 : SYSCFG interrupt line 25 status register
$400100e8 constant SYSCFG_SYSCFG_ITLINE26  \ offset: 0xE8 : SYSCFG interrupt line 26 status register
$400100ec constant SYSCFG_SYSCFG_ITLINE27  \ offset: 0xEC : SYSCFG interrupt line 27 status register
$400100f0 constant SYSCFG_SYSCFG_ITLINE28  \ offset: 0xF0 : SYSCFG interrupt line 28 status register
$400100f4 constant SYSCFG_SYSCFG_ITLINE29  \ offset: 0xF4 : SYSCFG interrupt line 29 status register
$400100f8 constant SYSCFG_SYSCFG_ITLINE30  \ offset: 0xF8 : SYSCFG interrupt line 30 status register
$400100fc constant SYSCFG_SYSCFG_ITLINE31  \ offset: 0xFC : SYSCFG interrupt line 31 status register

