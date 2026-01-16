\
\ @file radio_control.fs
\ @brief RADIO_CONTROL_ID register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RADIO_CONTROL_ID register
\ Address offset: 0x00
\ Reset value: 0x00003000
\

$000000f0 constant RADIO_CONTROL_RADIO_CONTROL_ID_REVISION          \ Incremented for metal fix version
$00000f00 constant RADIO_CONTROL_RADIO_CONTROL_ID_VERSION           \ Cut Number
$0000f000 constant RADIO_CONTROL_RADIO_CONTROL_ID_PRODUCT           \ incremented on major features add-on like new Bluetooth LE SIG version support


\
\ @brief CLK32COUNT_REG register
\ Address offset: 0x04
\ Reset value: 0x00000017
\

$000001ff constant RADIO_CONTROL_CLK32COUNT_REG_SLOW_COUNT          \ program the window length (in slow clock period) for slow clock measurement.


\
\ @brief CLK32PERIOD_REG register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0007ffff constant RADIO_CONTROL_CLK32PERIOD_REG_SLOW_PERIOD        \ indicates slow clock period information.


\
\ @brief CLK32FREQUENCY_REG register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$07ffffff constant RADIO_CONTROL_CLK32FREQUENCY_REG_SLOW_FREQUENCY    \ value equal to (2^39/ SLOW_PERIOD).


\
\ @brief RADIO_CONTROL_IRQ_STATUS register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant RADIO_CONTROL_RADIO_CONTROL_IRQ_STATUS_SLOW_CLK_IRQ    \ slow clock measurement end of calculation interrupt status
$00003f00 constant RADIO_CONTROL_RADIO_CONTROL_IRQ_STATUS_RADIO_FSM_IRQ    \ Radio FSM interrupt status (aka RfFsm_event_irq).


\
\ @brief RADIO_CONTROL_IRQ_ENABLE register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant RADIO_CONTROL_RADIO_CONTROL_IRQ_ENABLE_SLOW_CLK_IRQ_MASK    \ mask slow clock measurement interrupt
$00003f00 constant RADIO_CONTROL_RADIO_CONTROL_IRQ_ENABLE_RADIO_FSM_IRQ_MASK    \ mask for each RfFsm_event (Radio FSM) interrupt.


\
\ @brief RADIO_CONTROL_ID register
\
$60001000 constant RADIO_CONTROL_RADIO_CONTROL_ID  \ offset: 0x00 : RADIO_CONTROL_ID register
$60001004 constant RADIO_CONTROL_CLK32COUNT_REG  \ offset: 0x04 : CLK32COUNT_REG register
$60001008 constant RADIO_CONTROL_CLK32PERIOD_REG  \ offset: 0x08 : CLK32PERIOD_REG register
$6000100c constant RADIO_CONTROL_CLK32FREQUENCY_REG  \ offset: 0x0C : CLK32FREQUENCY_REG register
$60001010 constant RADIO_CONTROL_RADIO_CONTROL_IRQ_STATUS  \ offset: 0x10 : RADIO_CONTROL_IRQ_STATUS register
$60001014 constant RADIO_CONTROL_RADIO_CONTROL_IRQ_ENABLE  \ offset: 0x14 : RADIO_CONTROL_IRQ_ENABLE register

