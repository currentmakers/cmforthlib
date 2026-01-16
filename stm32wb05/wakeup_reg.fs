\
\ @file wakeup_reg.fs
\ @brief RADIO CPU Wakeup interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief WAKEUP_OFFSET register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant WAKEUP_REG_WAKEUP_OFFSET_WAKEUP_OFFSET           \ delay of anticipation of the Soc device to settle power and clock


\
\ @brief ABSOLUTE_TIME register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant WAKEUP_REG_ABSOLUTE_TIME_ABSOLUTE_TIME           \ absolute time


\
\ @brief MINIMUM_PERIOD_LENGTH register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00003ff0 constant WAKEUP_REG_MINIMUM_PERIOD_LENGTH_LENGTH          \ minimum period length computed by Time Interpolator


\
\ @brief AVERAGE_PERIOD_LENGTH register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000000f constant WAKEUP_REG_AVERAGE_PERIOD_LENGTH_LENGTH_FRACT    \ additional information/precision on slow clock frequency.
$00003ff0 constant WAKEUP_REG_AVERAGE_PERIOD_LENGTH_LENGTH_INT      \ average period length computed by Time Interpolator.
$ff000000 constant WAKEUP_REG_AVERAGE_PERIOD_LENGTH_AVERAGE_COUNT    \ Number of slow clock cycles.


\
\ @brief MAXIMUM_PERIOD_LENGTH register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00003ff0 constant WAKEUP_REG_MAXIMUM_PERIOD_LENGTH_LENGTH          \ maximum period length computed by Time Interpolator


\
\ @brief STATISTICS_RESTART register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant WAKEUP_REG_STATISTICS_RESTART_CLR_MIN_MAX        \ Write '1' to clear the minimum and maximum registers.
$00000002 constant WAKEUP_REG_STATISTICS_RESTART_CLR_AVR            \ Write '1' to clear the AVERAGE_PERIOD_LENGTH register value.


\
\ @brief BLUE_WAKEUP_TIME register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant WAKEUP_REG_BLUE_WAKEUP_TIME_WAKEUP_TIME          \ programmed wakeup time for the IP_BLE.


\
\ @brief BLUE_SLEEP_REQUEST_MODE register
\ Address offset: 0x28
\ Reset value: 0x00000007
\

$20000000 constant WAKEUP_REG_BLUE_SLEEP_REQUEST_MODE_SLEEP_EN      \ IP_BLE sleeping mode enable:
$40000000 constant WAKEUP_REG_BLUE_SLEEP_REQUEST_MODE_BLE_WAKEUP_EN    \ IP_BLE wakeup enable:
$80000000 constant WAKEUP_REG_BLUE_SLEEP_REQUEST_MODE_FORCE_SLEEPING    \ IP_BLE sleeping control:


\
\ @brief CM0_WAKEUP_TIME register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$fffffff0 constant WAKEUP_REG_CM0_WAKEUP_TIME_WAKEUP_TIME           \ programmed wakeup time for CPU.


\
\ @brief CM0_SLEEP_REQUEST_MODE register
\ Address offset: 0x30
\ Reset value: 0x80000007
\

$40000000 constant WAKEUP_REG_CM0_SLEEP_REQUEST_MODE_CPU_WAKEUP_EN    \ CPU wakeup enable:
$80000000 constant WAKEUP_REG_CM0_SLEEP_REQUEST_MODE_FORCE_SLEEPING    \ CPU sleeping control:


\
\ @brief WAKEUP_BLE_IRQ_ENABLE register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant WAKEUP_REG_WAKEUP_BLE_IRQ_ENABLE_WAKEUP_IT       \ IP_BLE wakeup interrupt enable:


\
\ @brief WAKEUP_BLE_IRQ_STATUS register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant WAKEUP_REG_WAKEUP_BLE_IRQ_STATUS_WAKEUP_IT       \ On read, returns the IP_BLE wakeup interrupt status.


\
\ @brief WAKEUP_CM0_IRQ_ENABLE register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant WAKEUP_REG_WAKEUP_CM0_IRQ_ENABLE_WAKEUP_IT       \ CPU wakeup interrupt enable:


\
\ @brief WAKEUP_CM0_IRQ_STATUS register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant WAKEUP_REG_WAKEUP_CM0_IRQ_STATUS_WAKEUP_IT       \ On read, returns the CPU wakeup interrupt status.


\
\ @brief RADIO CPU Wakeup interrupt
\
$60001808 constant WAKEUP_REG_WAKEUP_OFFSET  \ offset: 0x08 : WAKEUP_OFFSET register
$60001810 constant WAKEUP_REG_ABSOLUTE_TIME  \ offset: 0x10 : ABSOLUTE_TIME register
$60001814 constant WAKEUP_REG_MINIMUM_PERIOD_LENGTH  \ offset: 0x14 : MINIMUM_PERIOD_LENGTH register
$60001818 constant WAKEUP_REG_AVERAGE_PERIOD_LENGTH  \ offset: 0x18 : AVERAGE_PERIOD_LENGTH register
$6000181c constant WAKEUP_REG_MAXIMUM_PERIOD_LENGTH  \ offset: 0x1C : MAXIMUM_PERIOD_LENGTH register
$60001820 constant WAKEUP_REG_STATISTICS_RESTART  \ offset: 0x20 : STATISTICS_RESTART register
$60001824 constant WAKEUP_REG_BLUE_WAKEUP_TIME  \ offset: 0x24 : BLUE_WAKEUP_TIME register
$60001828 constant WAKEUP_REG_BLUE_SLEEP_REQUEST_MODE  \ offset: 0x28 : BLUE_SLEEP_REQUEST_MODE register
$6000182c constant WAKEUP_REG_CM0_WAKEUP_TIME  \ offset: 0x2C : CM0_WAKEUP_TIME register
$60001830 constant WAKEUP_REG_CM0_SLEEP_REQUEST_MODE  \ offset: 0x30 : CM0_SLEEP_REQUEST_MODE register
$60001840 constant WAKEUP_REG_WAKEUP_BLE_IRQ_ENABLE  \ offset: 0x40 : WAKEUP_BLE_IRQ_ENABLE register
$60001844 constant WAKEUP_REG_WAKEUP_BLE_IRQ_STATUS  \ offset: 0x44 : WAKEUP_BLE_IRQ_STATUS register
$60001848 constant WAKEUP_REG_WAKEUP_CM0_IRQ_ENABLE  \ offset: 0x48 : WAKEUP_CM0_IRQ_ENABLE register
$6000184c constant WAKEUP_REG_WAKEUP_CM0_IRQ_STATUS  \ offset: 0x4C : WAKEUP_CM0_IRQ_STATUS register

