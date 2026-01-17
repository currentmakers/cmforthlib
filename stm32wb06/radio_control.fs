\
\ @file radio_control.fs
\ @brief RADIO_CONTROL_ID register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RADIO_CONTROL_DEF

  [ifdef] RADIO_CONTROL_RADIO_CONTROL_ID_DEF
    \
    \ @brief RADIO_CONTROL_ID register
    \ Address offset: 0x00
    \ Reset value: 0x00003000
    \
    $04 constant RADIO_CONTROL_REVISION         \ [0x04 : 4] Incremented for metal fix version
    $08 constant RADIO_CONTROL_VERSION          \ [0x08 : 4] Cut Number
    $0c constant RADIO_CONTROL_PRODUCT          \ [0x0c : 4] incremented on major features add-on like new Bluetooth LE SIG version support
  [then]


  [ifdef] RADIO_CONTROL_CLK32COUNT_REG_DEF
    \
    \ @brief CLK32COUNT_REG register
    \ Address offset: 0x04
    \ Reset value: 0x00000017
    \
    $00 constant RADIO_CONTROL_SLOW_COUNT       \ [0x00 : 9] program the window length (in slow clock period) for slow clock measurement.
  [then]


  [ifdef] RADIO_CONTROL_CLK32PERIOD_REG_DEF
    \
    \ @brief CLK32PERIOD_REG register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RADIO_CONTROL_SLOW_PERIOD      \ [0x00 : 19] indicates slow clock period information.
  [then]


  [ifdef] RADIO_CONTROL_CLK32FREQUENCY_REG_DEF
    \
    \ @brief CLK32FREQUENCY_REG register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant RADIO_CONTROL_SLOW_FREQUENCY   \ [0x00 : 27] value equal to (2^39/ SLOW_PERIOD).
  [then]


  [ifdef] RADIO_CONTROL_RADIO_CONTROL_IRQ_STATUS_DEF
    \
    \ @brief RADIO_CONTROL_IRQ_STATUS register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant RADIO_CONTROL_SLOW_CLK_IRQ     \ [0x00] slow clock measurement end of calculation interrupt status
    $08 constant RADIO_CONTROL_RADIO_FSM_IRQ    \ [0x08 : 6] Radio FSM interrupt status (aka RfFsm_event_irq).
  [then]


  [ifdef] RADIO_CONTROL_RADIO_CONTROL_IRQ_ENABLE_DEF
    \
    \ @brief RADIO_CONTROL_IRQ_ENABLE register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant RADIO_CONTROL_SLOW_CLK_IRQ_MASK     \ [0x00] mask slow clock measurement interrupt
    $08 constant RADIO_CONTROL_RADIO_FSM_IRQ_MASK     \ [0x08 : 6] mask for each RfFsm_event (Radio FSM) interrupt.
  [then]

  \
  \ @brief RADIO_CONTROL_ID register
  \
  $00 constant RADIO_CONTROL_RADIO_CONTROL_ID    \ RADIO_CONTROL_ID register
  $04 constant RADIO_CONTROL_CLK32COUNT_REG    \ CLK32COUNT_REG register
  $08 constant RADIO_CONTROL_CLK32PERIOD_REG    \ CLK32PERIOD_REG register
  $0C constant RADIO_CONTROL_CLK32FREQUENCY_REG    \ CLK32FREQUENCY_REG register
  $10 constant RADIO_CONTROL_RADIO_CONTROL_IRQ_STATUS    \ RADIO_CONTROL_IRQ_STATUS register
  $14 constant RADIO_CONTROL_RADIO_CONTROL_IRQ_ENABLE    \ RADIO_CONTROL_IRQ_ENABLE register

: RADIO_CONTROL_DEF ; [then]
