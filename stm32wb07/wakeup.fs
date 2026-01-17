\
\ @file wakeup.fs
\ @brief WAKEUP_OFFSET register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] WAKEUP_DEF

  [ifdef] WAKEUP_WAKEUP_OFFSET_DEF
    \
    \ @brief WAKEUP_OFFSET register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant WAKEUP_WAKEUP_OFFSET           \ [0x00 : 8] delay of anticipation of the Soc device to settle power and clock
  [then]


  [ifdef] WAKEUP_ABSOLUTE_TIME_DEF
    \
    \ @brief ABSOLUTE_TIME register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant WAKEUP_ABSOLUTE_TIME           \ [0x00 : 32] absolute time
  [then]


  [ifdef] WAKEUP_MINIMUM_PERIOD_LENGTH_DEF
    \
    \ @brief MINIMUM_PERIOD_LENGTH register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $04 constant WAKEUP_LENGTH                  \ [0x04 : 10] minimum period length computed by Time Interpolator
  [then]


  [ifdef] WAKEUP_AVERAGE_PERIOD_LENGTH_DEF
    \
    \ @brief AVERAGE_PERIOD_LENGTH register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant WAKEUP_LENGTH_FRACT            \ [0x00 : 4] additional information/precision on slow clock frequency.
    $04 constant WAKEUP_LENGTH_INT              \ [0x04 : 10] average period length computed by Time Interpolator.
    $18 constant WAKEUP_AVERAGE_COUNT           \ [0x18 : 8] Number of slow clock cycles.
  [then]


  [ifdef] WAKEUP_MAXIMUM_PERIOD_LENGTH_DEF
    \
    \ @brief MAXIMUM_PERIOD_LENGTH register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $04 constant WAKEUP_LENGTH                  \ [0x04 : 10] maximum period length computed by Time Interpolator
  [then]


  [ifdef] WAKEUP_STATISTICS_RESTART_DEF
    \
    \ @brief STATISTICS_RESTART register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant WAKEUP_CLR_MIN_MAX             \ [0x00] Write '1' to clear the minimum and maximum registers.
    $01 constant WAKEUP_CLR_AVR                 \ [0x01] Write '1' to clear the AVERAGE_PERIOD_LENGTH register value.
  [then]


  [ifdef] WAKEUP_BLUE_WAKEUP_TIME_DEF
    \
    \ @brief BLUE_WAKEUP_TIME register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant WAKEUP_WAKEUP_TIME             \ [0x00 : 32] programmed wakeup time for the IP_BLE.
  [then]


  [ifdef] WAKEUP_BLUE_SLEEP_REQUEST_MODE_DEF
    \
    \ @brief BLUE_SLEEP_REQUEST_MODE register
    \ Address offset: 0x28
    \ Reset value: 0x00000007
    \
    $1d constant WAKEUP_SLEEP_EN                \ [0x1d] IP_BLE sleeping mode enable:
    $1e constant WAKEUP_BLE_WAKEUP_EN           \ [0x1e] IP_BLE wakeup enable:
    $1f constant WAKEUP_FORCE_SLEEPING          \ [0x1f] IP_BLE sleeping control:
  [then]


  [ifdef] WAKEUP_CM0_WAKEUP_TIME_DEF
    \
    \ @brief CM0_WAKEUP_TIME register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $04 constant WAKEUP_WAKEUP_TIME             \ [0x04 : 28] programmed wakeup time for CPU.
  [then]


  [ifdef] WAKEUP_CM0_SLEEP_REQUEST_MODE_DEF
    \
    \ @brief CM0_SLEEP_REQUEST_MODE register
    \ Address offset: 0x30
    \ Reset value: 0x80000007
    \
    $1e constant WAKEUP_CPU_WAKEUP_EN           \ [0x1e] CPU wakeup enable:
    $1f constant WAKEUP_FORCE_SLEEPING          \ [0x1f] CPU sleeping control:
  [then]


  [ifdef] WAKEUP_WAKEUP_BLE_IRQ_ENABLE_DEF
    \
    \ @brief WAKEUP_BLE_IRQ_ENABLE register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant WAKEUP_WAKEUP_IT               \ [0x00] IP_BLE wakeup interrupt enable:
  [then]


  [ifdef] WAKEUP_WAKEUP_BLE_IRQ_STATUS_DEF
    \
    \ @brief WAKEUP_BLE_IRQ_STATUS register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant WAKEUP_WAKEUP_IT               \ [0x00] On read, returns the IP_BLE wakeup interrupt status.
  [then]


  [ifdef] WAKEUP_WAKEUP_CM0_IRQ_ENABLE_DEF
    \
    \ @brief WAKEUP_CM0_IRQ_ENABLE register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant WAKEUP_WAKEUP_IT               \ [0x00] CPU wakeup interrupt enable:
  [then]


  [ifdef] WAKEUP_WAKEUP_CM0_IRQ_STATUS_DEF
    \
    \ @brief WAKEUP_CM0_IRQ_STATUS register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant WAKEUP_WAKEUP_IT               \ [0x00] On read, returns the CPU wakeup interrupt status.
  [then]

  \
  \ @brief WAKEUP_OFFSET register
  \
  $08 constant WAKEUP_WAKEUP_OFFSET     \ WAKEUP_OFFSET register
  $10 constant WAKEUP_ABSOLUTE_TIME     \ ABSOLUTE_TIME register
  $14 constant WAKEUP_MINIMUM_PERIOD_LENGTH    \ MINIMUM_PERIOD_LENGTH register
  $18 constant WAKEUP_AVERAGE_PERIOD_LENGTH    \ AVERAGE_PERIOD_LENGTH register
  $1C constant WAKEUP_MAXIMUM_PERIOD_LENGTH    \ MAXIMUM_PERIOD_LENGTH register
  $20 constant WAKEUP_STATISTICS_RESTART    \ STATISTICS_RESTART register
  $24 constant WAKEUP_BLUE_WAKEUP_TIME  \ BLUE_WAKEUP_TIME register
  $28 constant WAKEUP_BLUE_SLEEP_REQUEST_MODE    \ BLUE_SLEEP_REQUEST_MODE register
  $2C constant WAKEUP_CM0_WAKEUP_TIME   \ CM0_WAKEUP_TIME register
  $30 constant WAKEUP_CM0_SLEEP_REQUEST_MODE    \ CM0_SLEEP_REQUEST_MODE register
  $40 constant WAKEUP_WAKEUP_BLE_IRQ_ENABLE    \ WAKEUP_BLE_IRQ_ENABLE register
  $44 constant WAKEUP_WAKEUP_BLE_IRQ_STATUS    \ WAKEUP_BLE_IRQ_STATUS register
  $48 constant WAKEUP_WAKEUP_CM0_IRQ_ENABLE    \ WAKEUP_CM0_IRQ_ENABLE register
  $4C constant WAKEUP_WAKEUP_CM0_IRQ_STATUS    \ WAKEUP_CM0_IRQ_STATUS register

: WAKEUP_DEF ; [then]
