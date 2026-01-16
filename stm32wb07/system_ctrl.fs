\
\ @file system_ctrl.fs
\ @brief DIE_ID register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DIE_ID register
\ Address offset: 0x00
\ Reset value: 0x00000120
\

$0000000f constant SYSTEM_CTRL_DIE_ID_REVISION                      \ Cut revision (metal fix)
$000000f0 constant SYSTEM_CTRL_DIE_ID_VERSION                       \ Cut version
$00000f00 constant SYSTEM_CTRL_DIE_ID_PRODUCT                       \ Product version. May be used to discriminate several version of a same digital BLE LPH device embedding different analog versions


\
\ @brief JTAG_ID register
\ Address offset: 0x04
\ Reset value: 0x0201E041
\

$00000ffe constant SYSTEM_CTRL_JTAG_ID_MANUF_ID                     \ Manufacturer ID
$0ffff000 constant SYSTEM_CTRL_JTAG_ID_PART_NUMBER                  \ Part number
$f0000000 constant SYSTEM_CTRL_JTAG_ID_VERSION_NUMBER               \ Version


\
\ @brief I2C_FMP_CTRL register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SYSTEM_CTRL_I2C_FMP_CTRL_I2C1_PA0_FMP            \ I2C1 Fast-Mode Plus driving capability for I2C1_SCL on PA0 I/O. 0: PA0 pin operated in standard mode. 1: FM+ mode is enabled on PA0 pin, and speed control is bypassed
$00000002 constant SYSTEM_CTRL_I2C_FMP_CTRL_I2C1_PA1_FMP            \ I2C1 Fast-Mode Plus driving capability for I2C1_SDA on PA1 I/O. 0: PA1 pin operated in standard mode. 1: FM+ mode is enabled on PA1 pin, and speed control is bypassed
$00000004 constant SYSTEM_CTRL_I2C_FMP_CTRL_I2C1_PB6_FMP            \ I2C1 Fast-Mode Plus driving capability for I2C1_SCL on PB6 I/O. 0: PB6 pin operated in standard mode. 1: FM+ mode is enabled on PB6 pin, and speed control is bypassed.
$00000008 constant SYSTEM_CTRL_I2C_FMP_CTRL_I2C1_PB7_FMP            \ I2C1 Fast-Mode Plus driving capability for I2C1_SDA on PB7 I/O. 0: PB7 pin operated in standard mode. 1: FM+ mode is enabled on PB7 pin, and speed control is bypassed


\
\ @brief IO_DTR register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SYSTEM_CTRL_IO_DTR_PA0_DT                        \ PA0_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
$00000002 constant SYSTEM_CTRL_IO_DTR_PA1_DT                        \ PA1_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
$00000004 constant SYSTEM_CTRL_IO_DTR_PA2_DT                        \ PA2_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
$00000008 constant SYSTEM_CTRL_IO_DTR_PA3_DT                        \ PA3_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
$00000010 constant SYSTEM_CTRL_IO_DTR_PA4_DT                        \ PA4_DT:Interrupt Detection Type for port A I/Os.
$00000020 constant SYSTEM_CTRL_IO_DTR_PA5_DT                        \ PA5_DT:Interrupt Detection Type for port A I/Os.
$00000040 constant SYSTEM_CTRL_IO_DTR_PA6_DT                        \ PA6_DT:Interrupt Detection Type for port A I/Os.
$00000080 constant SYSTEM_CTRL_IO_DTR_PA7_DT                        \ PA7_DT:Interrupt Detection Type for port A I/Os.
$00000100 constant SYSTEM_CTRL_IO_DTR_PA8_DT                        \ PA8_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
$00000200 constant SYSTEM_CTRL_IO_DTR_PA9_DT                        \ PA9_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
$00000400 constant SYSTEM_CTRL_IO_DTR_PA10_DT                       \ PA10_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
$00000800 constant SYSTEM_CTRL_IO_DTR_PA11_DT                       \ PA11_DT: Interrupt Detection Type for port A I/Os. 0: edge detection. 1: level detection.
$00010000 constant SYSTEM_CTRL_IO_DTR_PB0_DT                        \ PB0_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
$00020000 constant SYSTEM_CTRL_IO_DTR_PB1_DT                        \ PB1_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
$00040000 constant SYSTEM_CTRL_IO_DTR_PB2_DT                        \ PB2_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
$00080000 constant SYSTEM_CTRL_IO_DTR_PB3_DT                        \ PB3_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
$00100000 constant SYSTEM_CTRL_IO_DTR_PB4_DT                        \ PB4_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
$00200000 constant SYSTEM_CTRL_IO_DTR_PB5_DT                        \ PB5_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
$00400000 constant SYSTEM_CTRL_IO_DTR_PB6_DT                        \ PB6_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
$00800000 constant SYSTEM_CTRL_IO_DTR_PB7_DT                        \ PB7_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
$01000000 constant SYSTEM_CTRL_IO_DTR_PB8_DT                        \ PB8_DT:Interrupt Detection Type for port B I/Os.
$02000000 constant SYSTEM_CTRL_IO_DTR_PB9_DT                        \ PB9_DT:Interrupt Detection Type for port B I/Os.
$04000000 constant SYSTEM_CTRL_IO_DTR_PB10_DT                       \ PB10_DT:Interrupt Detection Type for port B I/Os.
$08000000 constant SYSTEM_CTRL_IO_DTR_PB11_DT                       \ PB11_DT:Interrupt Detection Type for port B I/Os.
$10000000 constant SYSTEM_CTRL_IO_DTR_PB12_DT                       \ PB12_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
$20000000 constant SYSTEM_CTRL_IO_DTR_PB13_DT                       \ PB13_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
$40000000 constant SYSTEM_CTRL_IO_DTR_PB14_DT                       \ PB14_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.
$80000000 constant SYSTEM_CTRL_IO_DTR_PB15_DT                       \ PB15_DT: Interrupt Detection Type for port B I/Os. 0: edge detection. 1: level detection.


\
\ @brief IO_IBER register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SYSTEM_CTRL_IO_IBER_PA0_IBE                      \ PA0_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
$00000002 constant SYSTEM_CTRL_IO_IBER_PA1_IBE                      \ PA1_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
$00000004 constant SYSTEM_CTRL_IO_IBER_PA2_IBE                      \ PA2_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
$00000008 constant SYSTEM_CTRL_IO_IBER_PA3_IBE                      \ PA3_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
$00000010 constant SYSTEM_CTRL_IO_IBER_PA4_IBE                      \ PA4_IBE: Interrupt edge selection for Port A I/Os.
$00000020 constant SYSTEM_CTRL_IO_IBER_PA5_IBE                      \ PA5_IBE: Interrupt edge selection for Port A I/Os.
$00000040 constant SYSTEM_CTRL_IO_IBER_PA6_IBE                      \ PA6_IBE: Interrupt edge selection for Port A I/Os.
$00000080 constant SYSTEM_CTRL_IO_IBER_PA7_IBE                      \ PA7_IBE: Interrupt edge selection for Port A I/Os.
$00000100 constant SYSTEM_CTRL_IO_IBER_PA8_IBE                      \ PA8_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
$00000200 constant SYSTEM_CTRL_IO_IBER_PA9_IBE                      \ PA9_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
$00000400 constant SYSTEM_CTRL_IO_IBER_PA10_IBE                     \ PA10_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
$00000800 constant SYSTEM_CTRL_IO_IBER_PA11_IBE                     \ PA11_IBE: Interrupt edge selection for Port A I/Os. 0: single edge detection. 1: both edges detection
$00001000 constant SYSTEM_CTRL_IO_IBER_PA12_IBE                     \ PA12_IBE: Interrupt edge selection for Port A I/Os.
$00002000 constant SYSTEM_CTRL_IO_IBER_PA13_IBE                     \ PA13_IBE: Interrupt edge selection for Port A I/Os.
$00004000 constant SYSTEM_CTRL_IO_IBER_PA14_IBE                     \ PA14_IBE: Interrupt edge selection for Port A I/Os.
$00008000 constant SYSTEM_CTRL_IO_IBER_PA15_IBE                     \ PA15_IBE: Interrupt edge selection for Port A I/Os.
$00010000 constant SYSTEM_CTRL_IO_IBER_PB0_IBE                      \ PB0_IBE: Interrupt edge selection for port B I/Os.
$00020000 constant SYSTEM_CTRL_IO_IBER_PB1_IBE                      \ PB1_IBE: Interrupt edge selection for port B I/Os.
$00040000 constant SYSTEM_CTRL_IO_IBER_PB2_IBE                      \ PB2_IBE: Interrupt edge selection for port B I/Os.
$00080000 constant SYSTEM_CTRL_IO_IBER_PB3_IBE                      \ PB3_IBE: Interrupt edge selection for port B I/Os.
$00100000 constant SYSTEM_CTRL_IO_IBER_PB4_IBE                      \ PB4_IBE: Interrupt edge selection for port B I/Os.
$00200000 constant SYSTEM_CTRL_IO_IBER_PB5_IBE                      \ PB5_IBE: Interrupt edge selection for port B I/Os.
$00400000 constant SYSTEM_CTRL_IO_IBER_PB6_IBE                      \ PB6_IBE: Interrupt edge selection for port B I/Os.
$00800000 constant SYSTEM_CTRL_IO_IBER_PB7_IBE                      \ PB7_IBE: Interrupt edge selection for port B I/Os.
$01000000 constant SYSTEM_CTRL_IO_IBER_PB8_IBE                      \ PB8_IBE: Interrupt edge selection for port B I/Os.
$02000000 constant SYSTEM_CTRL_IO_IBER_PB9_IBE                      \ PB9_IBE: Interrupt edge selection for port B I/Os.
$04000000 constant SYSTEM_CTRL_IO_IBER_PB10_IBE                     \ PB10_IBE: Interrupt edge selection for port B I/Os.
$08000000 constant SYSTEM_CTRL_IO_IBER_PB11_IBE                     \ PB11_IBE: Interrupt edge selection for port B I/Os.
$10000000 constant SYSTEM_CTRL_IO_IBER_PB12_IBE                     \ PB12_IBE: Interrupt edge selection for port B I/Os. 0: single edge detection. 1: both edges detection.
$20000000 constant SYSTEM_CTRL_IO_IBER_PB13_IBE                     \ PB13_IBE: Interrupt edge selection for port B I/Os. 0: single edge detection. 1: both edges detection.
$40000000 constant SYSTEM_CTRL_IO_IBER_PB14_IBE                     \ PB14_IBE: Interrupt edge selection for port B I/Os. 0: single edge detection. 1: both edges detection.
$80000000 constant SYSTEM_CTRL_IO_IBER_PB15_IBE                     \ PB15_IBE: Interrupt edge selection for port B I/Os. 0: single edge detection. 1: both edges detection.


\
\ @brief IO_IEVR register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SYSTEM_CTRL_IO_IEVR_PA0_IEV                      \ PA0_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
$00000002 constant SYSTEM_CTRL_IO_IEVR_PA1_IEV                      \ PA1_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
$00000004 constant SYSTEM_CTRL_IO_IEVR_PA2_IEV                      \ PA2_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
$00000008 constant SYSTEM_CTRL_IO_IEVR_PA3_IEV                      \ PA3_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
$00000010 constant SYSTEM_CTRL_IO_IEVR_PA4_IEV                      \ PA4_IEV : Interrupt polarity event for Port A I/Os.
$00000020 constant SYSTEM_CTRL_IO_IEVR_PA5_IEV                      \ PA5_IEV : Interrupt polarity event for Port A I/Os.
$00000040 constant SYSTEM_CTRL_IO_IEVR_PA6_IEV                      \ PA6_IEV : Interrupt polarity event for Port A I/Os.
$00000080 constant SYSTEM_CTRL_IO_IEVR_PA7_IEV                      \ PA7_IEV : Interrupt polarity event for Port A I/Os.
$00000100 constant SYSTEM_CTRL_IO_IEVR_PA8_IEV                      \ PA8_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
$00000200 constant SYSTEM_CTRL_IO_IEVR_PA9_IEV                      \ PA9_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
$00000400 constant SYSTEM_CTRL_IO_IEVR_PA10_IEV                     \ PA10_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
$00000800 constant SYSTEM_CTRL_IO_IEVR_PA11_IEV                     \ PA11_IEV : Interrupt polarity event for Port A I/Os. 0: falling edge / low level. 1: rising edge / high level.
$00001000 constant SYSTEM_CTRL_IO_IEVR_PA12_IEV                     \ PA12_IEV : Interrupt polarity event for Port A I/Os.
$00002000 constant SYSTEM_CTRL_IO_IEVR_PA13_IEV                     \ PA13_IEV : Interrupt polarity event for Port A I/Os.
$00004000 constant SYSTEM_CTRL_IO_IEVR_PA14_IEV                     \ PA14_IEV : Interrupt polarity event for Port A I/Os.
$00008000 constant SYSTEM_CTRL_IO_IEVR_PA15_IEV                     \ PA15_IEV : Interrupt polarity event for Port A I/Os.
$00010000 constant SYSTEM_CTRL_IO_IEVR_PB0_IEV                      \ PB0_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
$00020000 constant SYSTEM_CTRL_IO_IEVR_PB1_IEV                      \ PB1_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
$00040000 constant SYSTEM_CTRL_IO_IEVR_PB2_IEV                      \ PB2_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
$00080000 constant SYSTEM_CTRL_IO_IEVR_PB3_IEV                      \ PB3_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
$00100000 constant SYSTEM_CTRL_IO_IEVR_PB4_IEV                      \ PB4_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
$00200000 constant SYSTEM_CTRL_IO_IEVR_PB5_IEV                      \ PB5_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
$00400000 constant SYSTEM_CTRL_IO_IEVR_PB6_IEV                      \ PB6_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
$00800000 constant SYSTEM_CTRL_IO_IEVR_PB7_IEV                      \ PB7_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
$01000000 constant SYSTEM_CTRL_IO_IEVR_PB8_IEV                      \ PB8_IEV : Interrupt polarity event for Port B I/Os.
$02000000 constant SYSTEM_CTRL_IO_IEVR_PB9_IEV                      \ PB9_IEV : Interrupt polarity event for Port B I/Os.
$04000000 constant SYSTEM_CTRL_IO_IEVR_PB10_IEV                     \ PB10_IEV : Interrupt polarity event for Port B I/Os.
$08000000 constant SYSTEM_CTRL_IO_IEVR_PB11_IEV                     \ PB11_IEV : Interrupt polarity event for Port B I/Os.
$10000000 constant SYSTEM_CTRL_IO_IEVR_PB12_IEV                     \ PB12_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
$20000000 constant SYSTEM_CTRL_IO_IEVR_PB13_IEV                     \ PB13_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
$40000000 constant SYSTEM_CTRL_IO_IEVR_PB14_IEV                     \ PB14_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.
$80000000 constant SYSTEM_CTRL_IO_IEVR_PB15_IEV                     \ PB15_IEV : Interrupt polarity event for Port B I/Os. 0: falling edge / low level. 1: rising edge / high level.


\
\ @brief IO_IER register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SYSTEM_CTRL_IO_IER_PA0_IE                        \ PA0_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
$00000002 constant SYSTEM_CTRL_IO_IER_PA1_IE                        \ PA1_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
$00000004 constant SYSTEM_CTRL_IO_IER_PA2_IE                        \ PA2_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
$00000008 constant SYSTEM_CTRL_IO_IER_PA3_IE                        \ PA3_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
$00000010 constant SYSTEM_CTRL_IO_IER_PA4_IE                        \ PA4_IE: Interrupt enable for port A I/Os.
$00000020 constant SYSTEM_CTRL_IO_IER_PA5_IE                        \ PA5_IE: Interrupt enable for port A I/Os.
$00000040 constant SYSTEM_CTRL_IO_IER_PA6_IE                        \ PA6_IE: Interrupt enable for port A I/Os.
$00000080 constant SYSTEM_CTRL_IO_IER_PA7_IE                        \ PA7_IE: Interrupt enable for port A I/Os.
$00000100 constant SYSTEM_CTRL_IO_IER_PA8_IE                        \ PA8_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
$00000200 constant SYSTEM_CTRL_IO_IER_PA9_IE                        \ PA9_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
$00000400 constant SYSTEM_CTRL_IO_IER_PA10_IE                       \ PA10_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
$00000800 constant SYSTEM_CTRL_IO_IER_PA11_IE                       \ PA11_IE: Interrupt enable for port A I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
$00001000 constant SYSTEM_CTRL_IO_IER_PA12_IE                       \ PA12_IE: Interrupt enable for port A I/Os.
$00002000 constant SYSTEM_CTRL_IO_IER_PA13_IE                       \ PA13_IE: Interrupt enable for port A I/Os.
$00004000 constant SYSTEM_CTRL_IO_IER_PA14_IE                       \ PA14_IE: Interrupt enable for port A I/Os.
$00008000 constant SYSTEM_CTRL_IO_IER_PA15_IE                       \ PA15_IE: Interrupt enable for port A I/Os.
$00010000 constant SYSTEM_CTRL_IO_IER_PB0_IE                        \ PB0_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
$00020000 constant SYSTEM_CTRL_IO_IER_PB1_IE                        \ PB1_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
$00040000 constant SYSTEM_CTRL_IO_IER_PB2_IE                        \ PB2_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
$00080000 constant SYSTEM_CTRL_IO_IER_PB3_IE                        \ PB3_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
$00100000 constant SYSTEM_CTRL_IO_IER_PB4_IE                        \ PB4_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
$00200000 constant SYSTEM_CTRL_IO_IER_PB5_IE                        \ PB5_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
$00400000 constant SYSTEM_CTRL_IO_IER_PB6_IE                        \ PB6_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
$00800000 constant SYSTEM_CTRL_IO_IER_PB7_IE                        \ PB7_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
$01000000 constant SYSTEM_CTRL_IO_IER_PB8_IE                        \ PB8_IE: Interrupt enable for port B I/Os.
$02000000 constant SYSTEM_CTRL_IO_IER_PB9_IE                        \ PB9_IE: Interrupt enable for port B I/Os.
$04000000 constant SYSTEM_CTRL_IO_IER_PB10_IE                       \ PB10_IE: Interrupt enable for port B I/Os.
$08000000 constant SYSTEM_CTRL_IO_IER_PB11_IE                       \ PB11_IE: Interrupt enable for port B I/Os.
$10000000 constant SYSTEM_CTRL_IO_IER_PB12_IE                       \ PB12_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
$20000000 constant SYSTEM_CTRL_IO_IER_PB13_IE                       \ PB13_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
$40000000 constant SYSTEM_CTRL_IO_IER_PB14_IE                       \ PB14_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.
$80000000 constant SYSTEM_CTRL_IO_IER_PB15_IE                       \ PB15_IE: Interrupt enable for port B I/Os. 0: interrupt is disabled. 1: interrupt is enabled.


\
\ @brief IO_ISCR register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SYSTEM_CTRL_IO_ISCR_PA0_ISC                      \ PA0_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
$00000002 constant SYSTEM_CTRL_IO_ISCR_PA1_ISC                      \ PA1_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
$00000004 constant SYSTEM_CTRL_IO_ISCR_PA2_ISC                      \ PA2_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
$00000008 constant SYSTEM_CTRL_IO_ISCR_PA3_ISC                      \ PA3_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
$00000010 constant SYSTEM_CTRL_IO_ISCR_PA4_ISC                      \ PA4_ISC: Interrupt status (before mask) for port a I/Os..
$00000020 constant SYSTEM_CTRL_IO_ISCR_PA5_ISC                      \ PA5_ISC: Interrupt status (before mask) for port a I/Os..
$00000040 constant SYSTEM_CTRL_IO_ISCR_PA6_ISC                      \ PA6_ISC: Interrupt status (before mask) for port a I/Os..
$00000080 constant SYSTEM_CTRL_IO_ISCR_PA7_ISC                      \ PA7_ISC: Interrupt status (before mask) for port a I/Os..
$00000100 constant SYSTEM_CTRL_IO_ISCR_PA8_ISC                      \ PA8_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
$00000200 constant SYSTEM_CTRL_IO_ISCR_PA9_ISC                      \ PA9_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
$00000400 constant SYSTEM_CTRL_IO_ISCR_PA10_ISC                     \ PA10_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
$00000800 constant SYSTEM_CTRL_IO_ISCR_PA11_ISC                     \ PA11_ISC: Interrupt status (before mask) for port a I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
$00001000 constant SYSTEM_CTRL_IO_ISCR_PA12_ISC                     \ PA12_ISC: Interrupt status (before mask) for port a I/Os.
$00002000 constant SYSTEM_CTRL_IO_ISCR_PA13_ISC                     \ PA13_ISC: Interrupt status (before mask) for port a I/Os.
$00004000 constant SYSTEM_CTRL_IO_ISCR_PA14_ISC                     \ PA14_ISC: Interrupt status (before mask) for port a I/Os.
$00008000 constant SYSTEM_CTRL_IO_ISCR_PA15_ISC                     \ PA15_ISC: Interrupt status (before mask) for port a I/Os.
$00010000 constant SYSTEM_CTRL_IO_ISCR_PB0_ISC                      \ PB0_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
$00020000 constant SYSTEM_CTRL_IO_ISCR_PB1_ISC                      \ PB1_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
$00040000 constant SYSTEM_CTRL_IO_ISCR_PB2_ISC                      \ PB2_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
$00080000 constant SYSTEM_CTRL_IO_ISCR_PB3_ISC                      \ PB3_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
$00100000 constant SYSTEM_CTRL_IO_ISCR_PB4_ISC                      \ PB4_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
$00200000 constant SYSTEM_CTRL_IO_ISCR_PB5_ISC                      \ PB5_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
$00400000 constant SYSTEM_CTRL_IO_ISCR_PB6_ISC                      \ PB6_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
$00800000 constant SYSTEM_CTRL_IO_ISCR_PB7_ISC                      \ PB7_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
$01000000 constant SYSTEM_CTRL_IO_ISCR_PB8_ISC                      \ PB8_ISC: Interrupt status (before mask) for port B I/Os..
$02000000 constant SYSTEM_CTRL_IO_ISCR_PB9_ISC                      \ PB9_ISC: Interrupt status (before mask) for port B I/Os..
$04000000 constant SYSTEM_CTRL_IO_ISCR_PB10_ISC                     \ PB10_ISC: Interrupt status (before mask) for port B I/Os..
$08000000 constant SYSTEM_CTRL_IO_ISCR_PB11_ISC                     \ PB11_ISC: Interrupt status (before mask) for port B I/Os..
$10000000 constant SYSTEM_CTRL_IO_ISCR_PB12_ISC                     \ PB12_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
$20000000 constant SYSTEM_CTRL_IO_ISCR_PB13_ISC                     \ PB13_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
$40000000 constant SYSTEM_CTRL_IO_ISCR_PB14_ISC                     \ PB14_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
$80000000 constant SYSTEM_CTRL_IO_ISCR_PB15_ISC                     \ PB15_ISC: Interrupt status (before mask) for port B I/Os. 0: no pending interrupt. 1: event occurred on corresponding I/O / interrupt occurred (if enabled). Cleared by writing 1 in the bit.


\
\ @brief PWRC_IER register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000002 constant SYSTEM_CTRL_PWRC_IER_PVD_IE                      \ PVD_IE: Programmable Voltage Detector interrupt enable. 0: PVD interrupt is disabled. 1: PVD interrupt is enabled.
$00000004 constant SYSTEM_CTRL_PWRC_IER_WKUP_IE                     \ WKUP_IE: Power Controller Wakeup event interrupt enable. 0: Interrupt on wakeup event seen by the PWRC is disabled. 1: Interrupt on wakeup event seen by the PWRC is enabled.


\
\ @brief PWRC_ISCR register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000002 constant SYSTEM_CTRL_PWRC_ISCR_PVD_ISC                    \ PVD_ISC: Programmable Voltage Detector status. 0: no pending interrupt. 1: voltage went under programmed threshold / interrupt occurred (if enabled). Cleared by writing 1 in the bit.
$00000004 constant SYSTEM_CTRL_PWRC_ISCR_WKUP_ISC                   \ WKUP_ISC: Indicates the Power Controller receives a Wakeup event. 0: no pending interrupt. 1: Wakeup event on PWRC occurred / interrupt occurred (if enabled). Cleared by writing 1 in the bit. This flag will be read at 1 if a wakeup event arrives so close to the low power mode entry requests that the PWRC aborts before shutting down the system.


\
\ @brief BLERXTX_DTR register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant SYSTEM_CTRL_BLERXTX_DTR_TX_DT                    \ TX_DT: detection type on TX_SEQUENCE signal: 0: detection on edge (default). 1: detection on level
$00000002 constant SYSTEM_CTRL_BLERXTX_DTR_RX_DT                    \ RX_DT: detection type on RX_SEQUENCE signal: 0: detection on edge (default). 1: detection on level


\
\ @brief BLERXTX_IBER register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant SYSTEM_CTRL_BLERXTX_IBER_TX_IBE                  \ TX_IBE: interrupt edge register on TX_SEQUENCE signal: 0: detection on single edge (default). 1: detection on both edges
$00000002 constant SYSTEM_CTRL_BLERXTX_IBER_RX_IBE                  \ RX_IBE: interrupt edge register on RX_SEQUENCE signal: 0: detection on single edge (default). 1: detection on both edges


\
\ @brief BLERXTX_IEVR register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant SYSTEM_CTRL_BLERXTX_IEVR_TX_IEV                  \ TX_IEV: interrupt polarity event on TX_SEQUENCE signal: 0: detection on falling edge / low level (default). 1: detection on rising edge / high level
$00000002 constant SYSTEM_CTRL_BLERXTX_IEVR_RX_IEV                  \ RX_IEV: interrupt polarity event on RX_SEQUENCE signal: 0: detection on falling edge / low level (default). 1: detection on rising edge / high level


\
\ @brief BLERXTX_IER register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant SYSTEM_CTRL_BLERXTX_IER_TX_IE                    \ TX_IE: interrupt enable on TX_SEQUENCE signal: 0: TX_SEQUENCE interrupt is disabled (default). 1: TX_SEQUENCE interrupt is enabled
$00000002 constant SYSTEM_CTRL_BLERXTX_IER_RX_IE                    \ RX_IE: interrupt enable on RX_SEQUENCE signal: 0: RX_SEQUENCE interrupt is disabled (default). 1: RX_SEQUENCE interrupt is enabled


\
\ @brief BLERXTX_ISCR register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant SYSTEM_CTRL_BLERXTX_ISCR_TX_ISC                  \ TX_ISC:interrupt status on TX_SEQUENCE signal (can be a rising or a falling edge depending on BLERXTX_IEVR and BLERXTX_IBER): 0: no activity on TX_SEQUENCE detected. 1: activity on TX_SEQUENCE occurred
$00000002 constant SYSTEM_CTRL_BLERXTX_ISCR_RX_ISC                  \ RX_ISC: interrupt status on RX_SEQUENCE signal (can be a rising or a falling edge depending on BLERXTX_IEVR and BLERXTX_IBER): 0: no activity on RX_SEQUENCE detected. 1: activity on RX_SEQUENCE occurred


\
\ @brief DIE_ID register
\
$40000000 constant SYSTEM_CTRL_DIE_ID  \ offset: 0x00 : DIE_ID register
$40000004 constant SYSTEM_CTRL_JTAG_ID  \ offset: 0x04 : JTAG_ID register
$40000008 constant SYSTEM_CTRL_I2C_FMP_CTRL  \ offset: 0x08 : I2C_FMP_CTRL register
$4000000c constant SYSTEM_CTRL_IO_DTR  \ offset: 0x0C : IO_DTR register
$40000010 constant SYSTEM_CTRL_IO_IBER  \ offset: 0x10 : IO_IBER register
$40000014 constant SYSTEM_CTRL_IO_IEVR  \ offset: 0x14 : IO_IEVR register
$40000018 constant SYSTEM_CTRL_IO_IER  \ offset: 0x18 : IO_IER register
$4000001c constant SYSTEM_CTRL_IO_ISCR  \ offset: 0x1C : IO_ISCR register
$40000020 constant SYSTEM_CTRL_PWRC_IER  \ offset: 0x20 : PWRC_IER register
$40000024 constant SYSTEM_CTRL_PWRC_ISCR  \ offset: 0x24 : PWRC_ISCR register
$4000002c constant SYSTEM_CTRL_BLERXTX_DTR  \ offset: 0x2C : BLERXTX_DTR register
$40000030 constant SYSTEM_CTRL_BLERXTX_IBER  \ offset: 0x30 : BLERXTX_IBER register
$40000034 constant SYSTEM_CTRL_BLERXTX_IEVR  \ offset: 0x34 : BLERXTX_IEVR register
$40000038 constant SYSTEM_CTRL_BLERXTX_IER  \ offset: 0x38 : BLERXTX_IER register
$4000003c constant SYSTEM_CTRL_BLERXTX_ISCR  \ offset: 0x3C : BLERXTX_ISCR register

