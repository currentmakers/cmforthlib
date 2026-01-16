\
\ @file dbgmcu.fs
\ @brief Microcontroller debug unit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DBGMCU identity code register
\ Address offset: 0x00
\ Reset value: 0x00006000
\

$00000fff constant DBGMCU_DBGMCU_IDCODE_DEV_ID                      \ device identification
$ffff0000 constant DBGMCU_DBGMCU_IDCODE_REV_ID                      \ revision


\
\ @brief DBGMCU configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000002 constant DBGMCU_DBGMCU_CR_DBG_STOP                        \ Allows debug in Stop mode All clocks are disabled automatically in Stop mode. All active clocks and oscillators continue to run during Stop mode, allowing full debug capability. On exit from Stop mode, the clock settings are set to the Stop mode exit state.
$00000004 constant DBGMCU_DBGMCU_CR_DBG_STANDBY                     \ Allows debug in Standby mode All clocks are disabled and the core powered down automatically in Standby mode. All active clocks and oscillators continue to run during Standby mode, and the core supply is maintained, allowing full debug capability. On exit from Standby mode, a system reset is performed.
$00000010 constant DBGMCU_DBGMCU_CR_TRACE_IOEN                      \ trace pin enable
$00000020 constant DBGMCU_DBGMCU_CR_TRACE_EN                        \ trace port and clock enable. This bit enables the trace port clock, TRACECK.
$000000c0 constant DBGMCU_DBGMCU_CR_TRACE_MODE                      \ trace pin assignment
$00010000 constant DBGMCU_DBGMCU_CR_DCRT                            \ Debug credentials reset type This bit selects which type of reset is used to revoke the debug authentication credentials


\
\ @brief DBGMCU APB1L peripheral freeze register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_DBGMCU_APB1LFZR_DBG_TIM2_STOP             \ TIM2 stop in debug
$00000002 constant DBGMCU_DBGMCU_APB1LFZR_DBG_TIM3_STOP             \ TIM3 stop in debug
$00000004 constant DBGMCU_DBGMCU_APB1LFZR_DBG_TIM4_STOP             \ TIM4 stop in debug
$00000008 constant DBGMCU_DBGMCU_APB1LFZR_DBG_TIM5_STOP             \ TIM5 stop in debug
$00000010 constant DBGMCU_DBGMCU_APB1LFZR_DBG_TIM6_STOP             \ TIM6 stop in debug
$00000020 constant DBGMCU_DBGMCU_APB1LFZR_DBG_TIM7_STOP             \ TIM7 stop in debug
$00000040 constant DBGMCU_DBGMCU_APB1LFZR_DBG_TIM12_STOP            \ TIM12 stop in debug
$00000080 constant DBGMCU_DBGMCU_APB1LFZR_DBG_TIM13_STOP            \ TIM13 stop in debug
$00000100 constant DBGMCU_DBGMCU_APB1LFZR_DBG_TIM14_STOP            \ TIM14 stop in debug
$00000800 constant DBGMCU_DBGMCU_APB1LFZR_DBG_WWDG_STOP             \ WWDG stop in debug
$00001000 constant DBGMCU_DBGMCU_APB1LFZR_DBG_IWDG_STOP             \ IWDG stop in debug
$00200000 constant DBGMCU_DBGMCU_APB1LFZR_DBG_I2C1_STOP             \ I2C1 SMBUS timeout stop in debug
$00400000 constant DBGMCU_DBGMCU_APB1LFZR_DBG_I2C2_STOP             \ I2C2 SMBUS timeout stop in debug
$00800000 constant DBGMCU_DBGMCU_APB1LFZR_DBG_I3C1_STOP             \ I3C1 SCL stall counter stop in debug


\
\ @brief DBGMCU APB1H peripheral freeze register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000020 constant DBGMCU_DBGMCU_APB1HFZR_DBG_LPTIM2_STOP           \ LPTIM2 stop in debug


\
\ @brief DBGMCU APB2 peripheral freeze register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000800 constant DBGMCU_DBGMCU_APB2FZR_DBG_TIM1_STOP              \ TIM1 stop in debug
$00002000 constant DBGMCU_DBGMCU_APB2FZR_DBG_TIM8_STOP              \ TIM8 stop in debug
$00010000 constant DBGMCU_DBGMCU_APB2FZR_DBG_TIM15_STOP             \ TIM15 stop in debug
$00020000 constant DBGMCU_DBGMCU_APB2FZR_DBG_TIM16_STOP             \ TIM16 stop in debug
$00040000 constant DBGMCU_DBGMCU_APB2FZR_DBG_TIM17_STOP             \ TIM17 stop in debug


\
\ @brief DBGMCU APB3 peripheral freeze register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000400 constant DBGMCU_DBGMCU_APB3FZR_DBG_I2C3_STOP              \ I2C3 SMBUS timeout stop in debug
$00000800 constant DBGMCU_DBGMCU_APB3FZR_DBG_I2C4_STOP              \ I2C4 SMBUS timeout stop in debug
$00020000 constant DBGMCU_DBGMCU_APB3FZR_DBG_LPTIM1_STOP            \ LPTIM1 stop in debug
$00040000 constant DBGMCU_DBGMCU_APB3FZR_DBG_LPTIM3_STOP            \ LPTIM3 stop in debug
$00080000 constant DBGMCU_DBGMCU_APB3FZR_DBG_LPTIM4_STOP            \ LPTIM4 stop in debug
$00100000 constant DBGMCU_DBGMCU_APB3FZR_DBG_LPTIM5_STOP            \ LPTIM5 stop in debug
$00200000 constant DBGMCU_DBGMCU_APB3FZR_DBG_LPTIM6_STOP            \ LPTIM6 stop in debug
$40000000 constant DBGMCU_DBGMCU_APB3FZR_DBG_RTC_STOP               \ RTC stop in debug


\
\ @brief DBGMCU AHB1 peripheral freeze register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_0_STOP          \ GPDMA1 channel 0 stop in debug
$00000002 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_1_STOP          \ GPDMA1 channel 1 stop in debug
$00000004 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_2_STOP          \ GPDMA1 channel 2 stop in debug
$00000008 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_3_STOP          \ GPDMA1 channel 3 stop in debug
$00000010 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_4_STOP          \ GPDMA1 channel 4 stop in debug
$00000020 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_5_STOP          \ GPDMA1 channel 5 stop in debug
$00000040 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_6_STOP          \ GPDMA1 channel 6 stop in debug
$00000080 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_7_STOP          \ GPDMA1 channel 7 stop in debug
$00000100 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_8_STOP          \ GPDMA1 channel 8 stop in debug
$00000200 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_9_STOP          \ GPDMA1 channel 9 stop in debug
$00000400 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_10_STOP         \ GPDMA1 channel 10 stop in debug
$00000800 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_11_STOP         \ GPDMA1 channel 11 stop in debug
$00001000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_12_STOP         \ GPDMA1 channel 12 stop in debug
$00002000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_13_STOP         \ GPDMA1 channel 13 stop in debug
$00004000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_14_STOP         \ GPDMA1 channel 14 stop in debug
$00008000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA1_15_STOP         \ GPDMA1 channel 15 stop in debug
$00010000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA2_0_STOP          \ GPDMA2 channel 0 stop in debug
$00020000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA2_1_STOP          \ GPDMA2 channel 1 stop in debug
$00040000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA2_2_STOP          \ GPDMA2 channel 2 stop in debug
$00080000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA2_3_STOP          \ GPDMA2 channel 3 stop in debug
$00100000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA2_4_STOP          \ GPDMA2 channel 4 stop in debug
$00200000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA2_5_STOP          \ GPDMA2 channel 5 stop in debug
$00400000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA2_6_STOP          \ GPDMA2 channel 6 stop in debug
$00800000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA2_7_STOP          \ GPDMA2 channel 7 stop in debug
$01000000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA2_8_STOP          \ GPDMA2 channel 8 stop in debug
$02000000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA2_9_STOP          \ GPDMA2 channel 9 stop in debug
$04000000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA2_10_STOP         \ GPDMA2 channel 10 stop in debug
$08000000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA2_11_STOP         \ GPDMA2 channel 11 stop in debug
$10000000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA2_12_STOP         \ GPDMA2 channel 12 stop in debug
$20000000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA2_13_STOP         \ GPDMA2 channel 13 stop in debug
$40000000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA2_14_STOP         \ GPDMA2 channel 14 stop in debug
$80000000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA2_15_STOP         \ GPDMA2 channel 15 stop in debug


\
\ @brief DBGMCU status register
\ Address offset: 0xFC
\ Reset value: 0x00010003
\

$0000ffff constant DBGMCU_DBGMCU_SR_AP_PRESENT                      \ Bit n identifies whether access port AP n is present in device Bit n = 0: APn absent Bit n = 1: APn present
$ffff0000 constant DBGMCU_DBGMCU_SR_AP_ENABLED                      \ Bit n identifies whether access port AP n is open (can be accessed via the debug port) or locked (debug access to the AP is blocked) Bit n = 0: APn locked Bit n = 1: APn enabled


\
\ @brief DBGMCU debug authentication mailbox host register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant DBGMCU_DBGMCU_DBG_AUTH_HOST_MESSAGE              \ Debug host to device mailbox message. During debug authentication the debug host communicates with the device via this register.


\
\ @brief DBGMCU debug authentication mailbox device register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant DBGMCU_DBGMCU_DBG_AUTH_DEVICE_MESSAGE            \ Device to debug host mailbox message. During debug authentication the device communicates with the debug host via this register.


\
\ @brief DBGMCU debug authentication mailbox acknowledge register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_DBGMCU_DBG_AUTH_ACK_HOST_ACK              \ Host to device acknowledge. The device sets this bit to indicate that it has placed a message in the DBGMCU_DBG_AUTH_DEVICE register. It should be reset by the host after reading the message
$00000002 constant DBGMCU_DBGMCU_DBG_AUTH_ACK_DEV_ACK               \ Device to device acknowledge. The host sets this bit to indicate that it has placed a message in the DBGMCU_DBG_AUTH_HOST register. It is reset by the device after reading the message


\
\ @brief DBGMCU CoreSight peripheral identity register 4
\ Address offset: 0xFD0
\ Reset value: 0x00000000
\

$0000000f constant DBGMCU_DBGMCU_PIDR4_JEP106CON                    \ JEP106 continuation code
$000000f0 constant DBGMCU_DBGMCU_PIDR4_SIZE                         \ register file size


\
\ @brief DBGMCU CoreSight peripheral identity register 0
\ Address offset: 0xFE0
\ Reset value: 0x00000000
\

$000000ff constant DBGMCU_DBGMCU_PIDR0_PARTNUM                      \ part number bits [7:0]


\
\ @brief DBGMCU CoreSight peripheral identity register 1
\ Address offset: 0xFE4
\ Reset value: 0x00000000
\

$0000000f constant DBGMCU_DBGMCU_PIDR1_PARTNUM                      \ part number bits [11:8]
$000000f0 constant DBGMCU_DBGMCU_PIDR1_JEP106ID                     \ JEP106 identity code bits [3:0]


\
\ @brief DBGMCU CoreSight peripheral identity register 2
\ Address offset: 0xFE8
\ Reset value: 0x0000000A
\

$00000007 constant DBGMCU_DBGMCU_PIDR2_JEP106ID                     \ JEP106 identity code bits [6:4]
$00000008 constant DBGMCU_DBGMCU_PIDR2_JEDEC                        \ JEDEC assigned value
$000000f0 constant DBGMCU_DBGMCU_PIDR2_REVISION                     \ component revision number


\
\ @brief DBGMCU CoreSight peripheral identity register 3
\ Address offset: 0xFEC
\ Reset value: 0x00000000
\

$0000000f constant DBGMCU_DBGMCU_PIDR3_CMOD                         \ customer modified
$000000f0 constant DBGMCU_DBGMCU_PIDR3_REVAND                       \ metal fix version


\
\ @brief DBGMCU CoreSight component identity register 0
\ Address offset: 0xFF0
\ Reset value: 0x0000000D
\

$000000ff constant DBGMCU_DBGMCU_CIDR0_PREAMBLE                     \ component identification bits [7:0]


\
\ @brief DBGMCU CoreSight component identity register 1
\ Address offset: 0xFF4
\ Reset value: 0x000000F0
\

$0000000f constant DBGMCU_DBGMCU_CIDR1_PREAMBLE                     \ component identification bits [11:8]
$000000f0 constant DBGMCU_DBGMCU_CIDR1_CLASS                        \ component identification bits [15:12]component class


\
\ @brief DBGMCU CoreSight component identity register 2
\ Address offset: 0xFF8
\ Reset value: 0x00000005
\

$000000ff constant DBGMCU_DBGMCU_CIDR2_PREAMBLE                     \ component identification bits [23:16]


\
\ @brief DBGMCU CoreSight component identity register 3
\ Address offset: 0xFFC
\ Reset value: 0x000000B1
\

$000000ff constant DBGMCU_DBGMCU_CIDR3_PREAMBLE                     \ component identification bits [31:24]


\
\ @brief Microcontroller debug unit
\
$44024000 constant DBGMCU_DBGMCU_IDCODE  \ offset: 0x00 : DBGMCU identity code register
$44024004 constant DBGMCU_DBGMCU_CR  \ offset: 0x04 : DBGMCU configuration register
$44024008 constant DBGMCU_DBGMCU_APB1LFZR  \ offset: 0x08 : DBGMCU APB1L peripheral freeze register
$4402400c constant DBGMCU_DBGMCU_APB1HFZR  \ offset: 0x0C : DBGMCU APB1H peripheral freeze register
$44024010 constant DBGMCU_DBGMCU_APB2FZR  \ offset: 0x10 : DBGMCU APB2 peripheral freeze register
$44024014 constant DBGMCU_DBGMCU_APB3FZR  \ offset: 0x14 : DBGMCU APB3 peripheral freeze register
$44024020 constant DBGMCU_DBGMCU_AHB1FZR  \ offset: 0x20 : DBGMCU AHB1 peripheral freeze register
$440240fc constant DBGMCU_DBGMCU_SR  \ offset: 0xFC : DBGMCU status register
$44024100 constant DBGMCU_DBGMCU_DBG_AUTH_HOST  \ offset: 0x100 : DBGMCU debug authentication mailbox host register
$44024104 constant DBGMCU_DBGMCU_DBG_AUTH_DEVICE  \ offset: 0x104 : DBGMCU debug authentication mailbox device register
$44024108 constant DBGMCU_DBGMCU_DBG_AUTH_ACK  \ offset: 0x108 : DBGMCU debug authentication mailbox acknowledge register
$44024fd0 constant DBGMCU_DBGMCU_PIDR4  \ offset: 0xFD0 : DBGMCU CoreSight peripheral identity register 4
$44024fe0 constant DBGMCU_DBGMCU_PIDR0  \ offset: 0xFE0 : DBGMCU CoreSight peripheral identity register 0
$44024fe4 constant DBGMCU_DBGMCU_PIDR1  \ offset: 0xFE4 : DBGMCU CoreSight peripheral identity register 1
$44024fe8 constant DBGMCU_DBGMCU_PIDR2  \ offset: 0xFE8 : DBGMCU CoreSight peripheral identity register 2
$44024fec constant DBGMCU_DBGMCU_PIDR3  \ offset: 0xFEC : DBGMCU CoreSight peripheral identity register 3
$44024ff0 constant DBGMCU_DBGMCU_CIDR0  \ offset: 0xFF0 : DBGMCU CoreSight component identity register 0
$44024ff4 constant DBGMCU_DBGMCU_CIDR1  \ offset: 0xFF4 : DBGMCU CoreSight component identity register 1
$44024ff8 constant DBGMCU_DBGMCU_CIDR2  \ offset: 0xFF8 : DBGMCU CoreSight component identity register 2
$44024ffc constant DBGMCU_DBGMCU_CIDR3  \ offset: 0xFFC : DBGMCU CoreSight component identity register 3

