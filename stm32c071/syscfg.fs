\
\ @file syscfg.fs
\ @brief Spider_SYSCFG register block
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

$00000003 constant SYSCFG_SYSCFG_CFGR1_MEM_MODE                     \ Memory mapping selection bits This bitfield controlled by software selects the memory internally mapped at the address 0x0000 0000. Its reset value is determined by the boot mode configuration. Refer to Section 3: Boot configuration for more details. x0: Main Flash memory
$00000008 constant SYSCFG_SYSCFG_CFGR1_PA11_RMP                     \ PA11 pin remapping This bit is set and cleared by software. When set, it remaps the PA11 pin to operate as PA9 GPIO port, instead as PA11 GPIO port. Note: If the PINMUX2[1:0] bitfield of the SYSCFG_CFGR3 register is at 00, PA11_RMP must be kept at 0 to prevent conflict due to two GPIO outputs with different output levels connected to the same pin.
$00000010 constant SYSCFG_SYSCFG_CFGR1_PA12_RMP                     \ PA12 pin remapping This bit is set and cleared by software. When set, it remaps the PA12 pin to operate as PA10 GPIO port, instead as PA12 GPIO port. Note: If the PINMUX4[1:0] bitfield of the SYSCFG_CFGR3 register is at 00, PA12_RMP must be kept at 0 to prevent conflict due to two GPIO outputs with different output levels connected to the same pin.
$00000020 constant SYSCFG_SYSCFG_CFGR1_IR_POL                       \ IR output polarity selection
$000000c0 constant SYSCFG_SYSCFG_CFGR1_IR_MOD                       \ IR Modulation Envelope signal selection This bitfield selects the signal for IR modulation envelope:
$00010000 constant SYSCFG_SYSCFG_CFGR1_I2C_PB6_FMP                  \ Fast Mode Plus (FM+) enable for PB6 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on PB6 I/O port.
$00020000 constant SYSCFG_SYSCFG_CFGR1_I2C_PB7_FMP                  \ Fast Mode Plus (FM+) enable for PB7 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on PB7 I/O port.
$00040000 constant SYSCFG_SYSCFG_CFGR1_I2C_PB8_FMP                  \ Fast Mode Plus (FM+) enable for PB8 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on PB8 I/O port. Note: Not available on STM32C011xx.
$00080000 constant SYSCFG_SYSCFG_CFGR1_I2C_PB9_FMP                  \ Fast Mode Plus (FM+) enable for PB9 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on PB9 I/O port. Note: Not available on STM32C011xx.
$00100000 constant SYSCFG_SYSCFG_CFGR1_I2C1_FMP                     \ Fast Mode Plus (FM+) enable for I2C1 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on I/O ports configured as I2C1 through GPIOx_AFR registers.
$00200000 constant SYSCFG_SYSCFG_CFGR1_I2C2_FMP                     \ Fast Mode Plus (FM+) enable for I2C2 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on I/O ports configured as I2C2 through GPIOx_AFR registers. Note: Only applicable to STM32C071xx. Reserved on the other products.
$00400000 constant SYSCFG_SYSCFG_CFGR1_I2C_PA9_FMP                  \ Fast Mode Plus (FM+) enable for PA9 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on PA9 I/O port.
$00800000 constant SYSCFG_SYSCFG_CFGR1_I2C_PA10_FMP                 \ Fast Mode Plus (FM+) enable for PA10 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on PA10 I/O port.
$01000000 constant SYSCFG_SYSCFG_CFGR1_I2C_PC14_FMP                 \ Fast Mode Plus (FM+) enable for PC14 This bit is set and cleared by software. It enables I<sup>2</sup>C FM+ driving capability on PC14 I/O port. Note: Not available on STM32C011xx.


\
\ @brief SYSCFG configuration register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_CFGR2_LOCKUP_LOCK                  \ Cortex<Superscript> <Default Font>-M0+ LOCKUP enable This bit is set by software and cleared by system reset. When set, it enables the connection of Cortex<Superscript> <Default Font>-M0+ LOCKUP (HardFault) output to the TIM1/16/17 Break input.


\
\ @brief SYSCFG configuration register 3
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000003 constant SYSCFG_SYSCFG_CFGR3_PINMUX0                      \ Pin GPIO multiplexer 0 This bit is set by software and cleared by system reset. It assigns a GPIO to a pin. 1x: Reserved 1x: Reserved
$0000000c constant SYSCFG_SYSCFG_CFGR3_PINMUX1                      \ Pin GPIO multiplexer 1 This bit is set by software and cleared by system reset. It assigns a GPIO to a pin. 1x: Reserved
$00000030 constant SYSCFG_SYSCFG_CFGR3_PINMUX2                      \ Pin GPIO multiplexer 2 This bit is set by software and cleared by system reset. It assigns a GPIO to a pin. 1x: Reserved Note: The PA11_RMP bit of the SYSCFG_CFGR1 takes priority over the selection through this bitfield. Refer to the description of the SYSCFG_CFGR1 register for more details.
$000000c0 constant SYSCFG_SYSCFG_CFGR3_PINMUX3                      \ Pin GPIO multiplexer 3 This bit is set by software and cleared by system reset. It assigns a GPIO to a pin. 1x: Reserved
$00000300 constant SYSCFG_SYSCFG_CFGR3_PINMUX4                      \ Pin GPIO multiplexer 4 This bit is set by software and cleared by system reset. It assigns a GPIO to a pin. 1x: Reserved Note: The PA12_RMP bit of the SYSCFG_CFGR1 takes priority over the selection through this bitfield. Refer to the description of the SYSCFG_CFGR1 register for more details.
$00000c00 constant SYSCFG_SYSCFG_CFGR3_PINMUX5                      \ Pin GPIO multiplexer 5 This bit is set by software and cleared by system reset. It assigns a GPIO to a pin.


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

$00000002 constant SYSCFG_SYSCFG_ITLINE1_PVM_VDDIO2_OUT             \ V<sub>DDIO2</sub> supply monitoring interrupt request pending (EXTI line 34)


\
\ @brief SYSCFG interrupt line 2 status register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000002 constant SYSCFG_SYSCFG_ITLINE2_RTC                        \ RTC interrupt request pending (EXTI line 19)


\
\ @brief SYSCFG interrupt line 3 status register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000002 constant SYSCFG_SYSCFG_ITLINE3_FLASH_ITF                  \ Flash interface interrupt request pending


\
\ @brief SYSCFG interrupt line 4 status register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE4_RCC                        \ Reset and clock control interrupt request pending
$00000002 constant SYSCFG_SYSCFG_ITLINE4_CRS                        \ CRS interrupt request pending Note: Only applicable on STM32C071xx, reserved on other products.


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

$00000001 constant SYSCFG_SYSCFG_ITLINE9_DMA1_CH1                   \ DMA1 channel 1interrupt request pending


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
$00000002 constant SYSCFG_SYSCFG_ITLINE11_DMA_CH4                   \ DMA channel 5 interrupt request pending Note: Only applicable on STM32C071xx, reserved on the other products.
$00000004 constant SYSCFG_SYSCFG_ITLINE11_DMA_CH5                   \ DMA channel 5 interrupt request pending Note: Only applicable on STM32C071xx, reserved on the other products.


\
\ @brief SYSCFG interrupt line 12 status register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE12_ADC                       \ ADC interrupt request pending


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

$00000001 constant SYSCFG_SYSCFG_ITLINE14_TIM1_CC                   \ Timer 1 capture compare interrupt request pending


\
\ @brief SYSCFG interrupt line 15 status register
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE15_TIM2                      \ TIM2 interrupt request pending


\
\ @brief SYSCFG interrupt line 16 status register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE16_TIM3                      \ Timer 3 interrupt request pending


\
\ @brief SYSCFG interrupt line 19 status register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE19_TIM14                     \ Timer 14 interrupt request pending


\
\ @brief SYSCFG interrupt line 21 status register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE21_TIM16                     \ Timer 16 interrupt request pending


\
\ @brief SYSCFG interrupt line 22 status register
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE22_TIM17                     \ Timer 17 interrupt request pending


\
\ @brief SYSCFG interrupt line 23 status register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE23_I2C1                      \ I2C1 interrupt request pending, combined with EXTI line 23


\
\ @brief SYSCFG interrupt line 24 status register
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_SYSCFG_ITLINE24_I2C2                      \ I2C2 interrupt request pending


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

$00000001 constant SYSCFG_SYSCFG_ITLINE28_USART2                    \ USART2 interrupt request pending (EXTI line 26)


\
\ @brief Spider_SYSCFG register block
\
$40010000 constant SYSCFG_SYSCFG_CFGR1  \ offset: 0x00 : SYSCFG configuration register 1
$40010018 constant SYSCFG_SYSCFG_CFGR2  \ offset: 0x18 : SYSCFG configuration register 2
$4001003c constant SYSCFG_SYSCFG_CFGR3  \ offset: 0x3C : SYSCFG configuration register 3
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
$400100cc constant SYSCFG_SYSCFG_ITLINE19  \ offset: 0xCC : SYSCFG interrupt line 19 status register
$400100d4 constant SYSCFG_SYSCFG_ITLINE21  \ offset: 0xD4 : SYSCFG interrupt line 21 status register
$400100d8 constant SYSCFG_SYSCFG_ITLINE22  \ offset: 0xD8 : SYSCFG interrupt line 22 status register
$400100dc constant SYSCFG_SYSCFG_ITLINE23  \ offset: 0xDC : SYSCFG interrupt line 23 status register
$400100e0 constant SYSCFG_SYSCFG_ITLINE24  \ offset: 0xE0 : SYSCFG interrupt line 24 status register
$400100e4 constant SYSCFG_SYSCFG_ITLINE25  \ offset: 0xE4 : SYSCFG interrupt line 25 status register
$400100e8 constant SYSCFG_SYSCFG_ITLINE26  \ offset: 0xE8 : SYSCFG interrupt line 26 status register
$400100ec constant SYSCFG_SYSCFG_ITLINE27  \ offset: 0xEC : SYSCFG interrupt line 27 status register
$400100f0 constant SYSCFG_SYSCFG_ITLINE28  \ offset: 0xF0 : SYSCFG interrupt line 28 status register

