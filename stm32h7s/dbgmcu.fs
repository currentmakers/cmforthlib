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
\ Reset value: 0x00006485
\

$00000fff constant DBGMCU_DBGMCU_IDC_DEV_ID                         \ Device ID
$ffff0000 constant DBGMCU_DBGMCU_IDC_REV_ID                         \ Revision


\
\ @brief DBGMCU configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_DBGMCU_CR_DBGSLEEP                        \ Debug in Sleep mode enable
$00000002 constant DBGMCU_DBGMCU_CR_DBGSTOP                         \ Debug in Stop mode enable
$00000004 constant DBGMCU_DBGMCU_CR_DBGSTBY                         \ Debug in Standby mode enable
$00010000 constant DBGMCU_DBGMCU_CR_DCRT                            \ Debug credentials reset type This bit selects which type of reset is used to revoke the debug authentication credentials
$00100000 constant DBGMCU_DBGMCU_CR_TRACECLKEN                      \ Trace port clock enable. This bit enables the trace port clock, TRACECLK.
$00200000 constant DBGMCU_DBGMCU_CR_D1DBGCKEN                       \ D1 debug clock enable This bit allows the debug components in the D1 clock domain (excluding those in the processor core) to be switched off if they are not needed.
$10000000 constant DBGMCU_DBGMCU_CR_TRGOEN                          \ External trigger output enable This bit controls the direction of the bi-directional trigger pin, TRGIO.


\
\ @brief DBGMCU AHB5 peripheral freeze register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_DBGMCU_AHB5FZR_DBG_HPDMA_0_STOP           \ HPDMA channel 0 stop in debug
$00000002 constant DBGMCU_DBGMCU_AHB5FZR_DBG_HPDMA_1_STOP           \ HPDMA channel 1 stop in debug
$00000004 constant DBGMCU_DBGMCU_AHB5FZR_DBG_HPDMA_2_STOP           \ HPDMA channel 2 stop in debug
$00000008 constant DBGMCU_DBGMCU_AHB5FZR_DBG_HPDMA_3_STOP           \ HPDMA channel 3 stop in debug
$00000010 constant DBGMCU_DBGMCU_AHB5FZR_DBG_HPDMA_4_STOP           \ HPDMA channel 4 stop in debug
$00000020 constant DBGMCU_DBGMCU_AHB5FZR_DBG_HPDMA_5_STOP           \ HPDMA channel 5 stop in debug
$00000040 constant DBGMCU_DBGMCU_AHB5FZR_DBG_HPDMA_6_STOP           \ HPDMA channel 6 stop in debug
$00000080 constant DBGMCU_DBGMCU_AHB5FZR_DBG_HPDMA_7_STOP           \ HPDMA channel 7 stop in debug
$00000100 constant DBGMCU_DBGMCU_AHB5FZR_DBG_HPDMA_8_STOP           \ HPDMA channel 8 stop in debug
$00000200 constant DBGMCU_DBGMCU_AHB5FZR_DBG_HPDMA_9_STOP           \ HPDMA channel 9 stop in debug
$00000400 constant DBGMCU_DBGMCU_AHB5FZR_DBG_HPDMA_10_STOP          \ HPDMA channel 10 stop in debug
$00000800 constant DBGMCU_DBGMCU_AHB5FZR_DBG_HPDMA_11_STOP          \ HPDMA channel 11 stop in debug
$00001000 constant DBGMCU_DBGMCU_AHB5FZR_DBG_HPDMA_12_STOP          \ HPDMA channel 12 stop in debug
$00002000 constant DBGMCU_DBGMCU_AHB5FZR_DBG_HPDMA_13_STOP          \ HPDMA channel 13 stop in debug
$00004000 constant DBGMCU_DBGMCU_AHB5FZR_DBG_HPDMA_14_STOP          \ HPDMA channel 14 stop in debug
$00008000 constant DBGMCU_DBGMCU_AHB5FZR_DBG_HPDMA_15_STOP          \ HPDMA channel 15 stop in debug


\
\ @brief DBGMCU AHB1 peripheral freeze register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA_0_STOP           \ GPDMA channel 0 stop in debug
$00000002 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA_1_STOP           \ GPDMA channel 1 stop in debug
$00000004 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA_2_STOP           \ GPDMA channel 2 stop in debug
$00000008 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA_3_STOP           \ GPDMA channel 3 stop in debug
$00000010 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA_4_STOP           \ GPDMA channel 4 stop in debug
$00000020 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA_5_STOP           \ GPDMA channel 5 stop in debug
$00000040 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA_6_STOP           \ GPDMA channel 6 stop in debug
$00000080 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA_7_STOP           \ GPDMA channel 7 stop in debug
$00000100 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA_8_STOP           \ GPDMA channel 8 stop in debug
$00000200 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA_9_STOP           \ GPDMA channel 9 stop in debug
$00000400 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA_10_STOP          \ GPDMA channel 10 stop in debug
$00000800 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA_11_STOP          \ GPDMA channel 11 stop in debug
$00001000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA_12_STOP          \ GPDMA channel 12 stop in debug
$00002000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA_13_STOP          \ GPDMA channel 13 stop in debug
$00004000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA_14_STOP          \ GPDMA channel 14 stop in debug
$00008000 constant DBGMCU_DBGMCU_AHB1FZR_DBG_GPDMA_15_STOP          \ GPDMA channel 15 stop in debug


\
\ @brief DBGMCU APB1 peripheral freeze register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_DBGMCU_APB1FZR_TIM2                       \ TIM2 stop in debug
$00000002 constant DBGMCU_DBGMCU_APB1FZR_TIM3                       \ TIM3 stop in debug
$00000004 constant DBGMCU_DBGMCU_APB1FZR_TIM4                       \ TIM4 stop in debug
$00000008 constant DBGMCU_DBGMCU_APB1FZR_TIM5                       \ TIM5 stop in debug
$00000010 constant DBGMCU_DBGMCU_APB1FZR_TIM6                       \ TIM6 stop in debug
$00000020 constant DBGMCU_DBGMCU_APB1FZR_TIM7                       \ TIM7 stop in debug
$00000040 constant DBGMCU_DBGMCU_APB1FZR_TIM12                      \ TIM12 stop in debug
$00000080 constant DBGMCU_DBGMCU_APB1FZR_TIM13                      \ TIM13 stop in debug
$00000100 constant DBGMCU_DBGMCU_APB1FZR_TIM14                      \ TIM14 stop in debug
$00000200 constant DBGMCU_DBGMCU_APB1FZR_LPTIM1                     \ LPTIM1 stop in debug
$00000800 constant DBGMCU_DBGMCU_APB1FZR_WWDG                       \ WWDG stop in debug
$00200000 constant DBGMCU_DBGMCU_APB1FZR_I2C1                       \ I2C1 SMBUS timeout stop in debug
$00400000 constant DBGMCU_DBGMCU_APB1FZR_I2C2                       \ I2C2 SMBUS timeout stop in debug
$00800000 constant DBGMCU_DBGMCU_APB1FZR_I2C3                       \ I2C3 SMBUS timeout stop in debug


\
\ @brief DBGMCU APB2 peripheral freeze register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant DBGMCU_DBGMCU_APB2FZ_TIM1                        \ TIM1 stop in debug
$00010000 constant DBGMCU_DBGMCU_APB2FZ_TIM15                       \ TIM15 stop in debug
$00020000 constant DBGMCU_DBGMCU_APB2FZ_TIM16                       \ TIM16 stop in debug
$00040000 constant DBGMCU_DBGMCU_APB2FZ_TIM17                       \ TIM17 stop in debug
$00080000 constant DBGMCU_DBGMCU_APB2FZ_TIM9                        \ TIM9 stop in debug


\
\ @brief DBGMCU APB4 peripheral freeze register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000200 constant DBGMCU_DBGMCU_APB4FZR_LPTIM2                     \ LPTIM2 stop in debug
$00000400 constant DBGMCU_DBGMCU_APB4FZR_LPTIM3                     \ LPTIM2 stop in debug
$00000800 constant DBGMCU_DBGMCU_APB4FZR_LPTIM4                     \ LPTIM4 stop in debug
$00001000 constant DBGMCU_DBGMCU_APB4FZR_LPTIM5                     \ LPTIM5 stop in debug
$00010000 constant DBGMCU_DBGMCU_APB4FZR_RTC                        \ RTC stop in debug
$00040000 constant DBGMCU_DBGMCU_APB4FZR_IWDG                       \ Independent watchdog for stop in debug


\
\ @brief DBGMCU status register
\ Address offset: 0xFC
\ Reset value: 0x00010003
\

$0000ffff constant DBGMCU_DBGMCU_SR_AP_PRESENT                      \ Bit n identifies whether access port AP n is open (can be accessed via the debug port) or locked (debug access to the AP is blocked) Bit n = 0: APn absent Bit n = 1: APn present
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
\ @brief DBGMCU peripheral identity register 4
\ Address offset: 0xFD0
\ Reset value: 0x00000000
\

$0000000f constant DBGMCU_DBGMCU_PIDR4_JEP106CON                    \ JEP106 continuation code
$000000f0 constant DBGMCU_DBGMCU_PIDR4_SIZE                         \ Register file size


\
\ @brief DBGMCU peripheral identity register 0
\ Address offset: 0xFE0
\ Reset value: 0x00000000
\

$000000ff constant DBGMCU_DBGMCU_PIDR0_PARTNUM                      \ Part number field, bits [7:0]


\
\ @brief DBGMCU peripheral identity register 1
\ Address offset: 0xFE4
\ Reset value: 0x00000000
\

$0000000f constant DBGMCU_DBGMCU_PIDR1_PARTNUM                      \ Part number field, bits [11:8]
$000000f0 constant DBGMCU_DBGMCU_PIDR1_JEP106ID                     \ JEP106 identity code field, bits [3:0]


\
\ @brief DBGMCU peripheral identity register 2
\ Address offset: 0xFE8
\ Reset value: 0x0000000A
\

$00000007 constant DBGMCU_DBGMCU_PIDR2_JEP106ID                     \ JEP106 identity code field, bits [6:4]
$00000008 constant DBGMCU_DBGMCU_PIDR2_JEDEC                        \ JEDEC assigned value
$000000f0 constant DBGMCU_DBGMCU_PIDR2_REVISION                     \ Component revision number


\
\ @brief DBGMCU peripheral identity register 3
\ Address offset: 0xFEC
\ Reset value: 0x00000000
\

$0000000f constant DBGMCU_DBGMCU_PIDR3_CMOD                         \ Customer modified
$000000f0 constant DBGMCU_DBGMCU_PIDR3_REVAND                       \ Metal fix version


\
\ @brief DBGMCU component identity register
\ Address offset: 0xFF0
\ Reset value: 0x0000000D
\

$000000ff constant DBGMCU_DBGMCU_CIDR0_PREAMBLE                     \ Component ID field, bits [7:0]


\
\ @brief DBGMCU component identity register
\ Address offset: 0xFF4
\ Reset value: 0x000000F0
\

$0000000f constant DBGMCU_DBGMCU_CIDR1_PREAMBLE                     \ Component ID field, bits [11:8]
$000000f0 constant DBGMCU_DBGMCU_CIDR1_CLASS                        \ Component ID field, bits [15:12] - component class


\
\ @brief DBGMCU component identity register
\ Address offset: 0xFF8
\ Reset value: 0x00000005
\

$000000ff constant DBGMCU_DBGMCU_CIDR2_PREAMBLE                     \ Component ID field, bits [23:16]


\
\ @brief DBGMCU component identity register
\ Address offset: 0xFFC
\ Reset value: 0x000000B1
\

$000000ff constant DBGMCU_DBGMCU_CIDR3_PREAMBLE                     \ Component ID field, bits [31:24]


\
\ @brief Microcontroller debug unit
\
$5c001000 constant DBGMCU_DBGMCU_IDC  \ offset: 0x00 : DBGMCU identity code register
$5c001004 constant DBGMCU_DBGMCU_CR  \ offset: 0x04 : DBGMCU configuration register
$5c001020 constant DBGMCU_DBGMCU_AHB5FZR  \ offset: 0x20 : DBGMCU AHB5 peripheral freeze register
$5c001024 constant DBGMCU_DBGMCU_AHB1FZR  \ offset: 0x24 : DBGMCU AHB1 peripheral freeze register
$5c00103c constant DBGMCU_DBGMCU_APB1FZR  \ offset: 0x3C : DBGMCU APB1 peripheral freeze register
$5c00104c constant DBGMCU_DBGMCU_APB2FZ  \ offset: 0x4C : DBGMCU APB2 peripheral freeze register
$5c001054 constant DBGMCU_DBGMCU_APB4FZR  \ offset: 0x54 : DBGMCU APB4 peripheral freeze register
$5c0010fc constant DBGMCU_DBGMCU_SR  \ offset: 0xFC : DBGMCU status register
$5c001100 constant DBGMCU_DBGMCU_DBG_AUTH_HOST  \ offset: 0x100 : DBGMCU debug authentication mailbox host register
$5c001104 constant DBGMCU_DBGMCU_DBG_AUTH_DEVICE  \ offset: 0x104 : DBGMCU debug authentication mailbox device register
$5c001108 constant DBGMCU_DBGMCU_DBG_AUTH_ACK  \ offset: 0x108 : DBGMCU debug authentication mailbox acknowledge register
$5c001fd0 constant DBGMCU_DBGMCU_PIDR4  \ offset: 0xFD0 : DBGMCU peripheral identity register 4
$5c001fe0 constant DBGMCU_DBGMCU_PIDR0  \ offset: 0xFE0 : DBGMCU peripheral identity register 0
$5c001fe4 constant DBGMCU_DBGMCU_PIDR1  \ offset: 0xFE4 : DBGMCU peripheral identity register 1
$5c001fe8 constant DBGMCU_DBGMCU_PIDR2  \ offset: 0xFE8 : DBGMCU peripheral identity register 2
$5c001fec constant DBGMCU_DBGMCU_PIDR3  \ offset: 0xFEC : DBGMCU peripheral identity register 3
$5c001ff0 constant DBGMCU_DBGMCU_CIDR0  \ offset: 0xFF0 : DBGMCU component identity register
$5c001ff4 constant DBGMCU_DBGMCU_CIDR1  \ offset: 0xFF4 : DBGMCU component identity register
$5c001ff8 constant DBGMCU_DBGMCU_CIDR2  \ offset: 0xFF8 : DBGMCU component identity register
$5c001ffc constant DBGMCU_DBGMCU_CIDR3  \ offset: 0xFFC : DBGMCU component identity register

