\
\ @file rrm_reg.fs
\ @brief UDRA_CTRL0 register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief UDRA_CTRL0 register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant RRM_REG_UDRA_CTRL0_RELOAD_RDCFGPTR               \ reload the radio configuration pointer from RAM.


\
\ @brief UDRA_IRQ_ENABLE register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant RRM_REG_UDRA_IRQ_ENABLE_RADIO_CFG_PTR_RELOADED    \ UDRA interrupt enable (reload radio config pointer)
$00000002 constant RRM_REG_UDRA_IRQ_ENABLE_CMD_START                \ UDRA interrupt enable (command start)
$00000004 constant RRM_REG_UDRA_IRQ_ENABLE_CMD_END                  \ UDRA interrupt enable (command end)


\
\ @brief UDRA_IRQ_STATUS register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant RRM_REG_UDRA_IRQ_STATUS_RADIO_CFG_PTR_RELOADED    \ On read, returns the UDRA reload radio configuration pointer interrupt status.
$00000002 constant RRM_REG_UDRA_IRQ_STATUS_CMD_STARD                \ On read, returns the UDRA command start interrupt status.
$00000004 constant RRM_REG_UDRA_IRQ_STATUS_CMD_END                  \ On read, returns the UDRA command end interrupt status


\
\ @brief UDRA_RADIO_CFG_PTR register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant RRM_REG_UDRA_RADIO_CFG_PTR_RADIO_CONFIG_ADDRESS    \ UDRA radio configuration address.


\
\ @brief SEMA_IRQ_ENABLE register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant RRM_REG_SEMA_IRQ_ENABLE_LOCK                     \ semaphore locked (= one port granted) interrupt enable
$00000002 constant RRM_REG_SEMA_IRQ_ENABLE_UNLOCK                   \ semaphore unlocked (=no port selected) interrupt enable


\
\ @brief SEMA_IRQ_STATUS register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant RRM_REG_SEMA_IRQ_STATUS_LOCK                     \ On read, returns the semaphore locked interrupt status.
$00000002 constant RRM_REG_SEMA_IRQ_STATUS_UNLOCK                   \ On read, returns the semaphore unlocked interrupt status.


\
\ @brief BLE_IRQ_ENABLE register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant RRM_REG_BLE_IRQ_ENABLE_PORT_GRANT                \ IP_BLE Port grant interrupt enable
$00000002 constant RRM_REG_BLE_IRQ_ENABLE_PORT_RELEASE              \ IP_BLE Port release interrupt enable
$00000008 constant RRM_REG_BLE_IRQ_ENABLE_PORT_CMD_START            \ IP_BLE Port command start interrup enable
$00000010 constant RRM_REG_BLE_IRQ_ENABLE_PORT_CMD_END              \ IP_BLE Port command end interrup enable


\
\ @brief BLE_IRQ_STATUS register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant RRM_REG_BLE_IRQ_STATUS_PORT_GRANT                \ IP_BLE hardware port granted interrupt status:
$00000002 constant RRM_REG_BLE_IRQ_STATUS_PORT_RELEASE              \ IP_BLE hardware port released interrupt status.
$00000008 constant RRM_REG_BLE_IRQ_STATUS_CMD_START                 \ IP_BLE hardware port command start interrupt status.
$00000010 constant RRM_REG_BLE_IRQ_STATUS_CMD_END                   \ IP_BLE hardware port command end interrupt status.


\
\ @brief VP_CPU_CMD_BUS register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000007 constant RRM_REG_VP_CPU_CMD_BUS_COMMAND                   \ command number
$00000008 constant RRM_REG_VP_CPU_CMD_BUS_COMMAND_REQ               \ CPU Virtual port command request:


\
\ @brief VP_CPU_SEMA_BUS register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000007 constant RRM_REG_VP_CPU_SEMA_BUS_TAKE_PRIO                \ semaphore priority: priority value (between 0 and 7) of the take request.
$00000008 constant RRM_REG_VP_CPU_SEMA_BUS_TAKE_REQ                 \ semaphore token request:


\
\ @brief VP_CPU_IRQ_ENABLE register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000001 constant RRM_REG_VP_CPU_IRQ_ENABLE_PORT_GRANT             \ CPU virtual port grant interrupt enable
$00000002 constant RRM_REG_VP_CPU_IRQ_ENABLE_PORT_RELEASE           \ CPU virtual port release interrupt enable
$00000008 constant RRM_REG_VP_CPU_IRQ_ENABLE_PORT_CMD_START         \ CPU virtual port command start interrup enable
$00000010 constant RRM_REG_VP_CPU_IRQ_ENABLE_PORT_CMD_END           \ CPU virtual port command end interrup enable


\
\ @brief VP_CPU_IRQ_STATUS register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000001 constant RRM_REG_VP_CPU_IRQ_STATUS_PORT_GRANT             \ CPU virtual port granted interrupt status.
$00000002 constant RRM_REG_VP_CPU_IRQ_STATUS_PORT_RELEASE           \ virtual port released interrupt status.
$00000004 constant RRM_REG_VP_CPU_IRQ_STATUS_PORT_PREEMPT           \ CPU virtual port preemption (at semaphore level) interrupt status.
$00000008 constant RRM_REG_VP_CPU_IRQ_STATUS_CMD_START              \ CPU virtual port command start interrupt status.
$00000010 constant RRM_REG_VP_CPU_IRQ_STATUS_CMD_END                \ CPU virtual port command end interrupt status.


\
\ @brief UDRA_CTRL0 register
\
$60001410 constant RRM_REG_UDRA_CTRL0  \ offset: 0x10 : UDRA_CTRL0 register
$60001414 constant RRM_REG_UDRA_IRQ_ENABLE  \ offset: 0x14 : UDRA_IRQ_ENABLE register
$60001418 constant RRM_REG_UDRA_IRQ_STATUS  \ offset: 0x18 : UDRA_IRQ_STATUS register
$6000141c constant RRM_REG_UDRA_RADIO_CFG_PTR  \ offset: 0x1C : UDRA_RADIO_CFG_PTR register
$60001420 constant RRM_REG_SEMA_IRQ_ENABLE  \ offset: 0x20 : SEMA_IRQ_ENABLE register
$60001424 constant RRM_REG_SEMA_IRQ_STATUS  \ offset: 0x24 : SEMA_IRQ_STATUS register
$60001428 constant RRM_REG_BLE_IRQ_ENABLE  \ offset: 0x28 : BLE_IRQ_ENABLE register
$6000142c constant RRM_REG_BLE_IRQ_STATUS  \ offset: 0x2C : BLE_IRQ_STATUS register
$60001460 constant RRM_REG_VP_CPU_CMD_BUS  \ offset: 0x60 : VP_CPU_CMD_BUS register
$60001464 constant RRM_REG_VP_CPU_SEMA_BUS  \ offset: 0x64 : VP_CPU_SEMA_BUS register
$60001468 constant RRM_REG_VP_CPU_IRQ_ENABLE  \ offset: 0x68 : VP_CPU_IRQ_ENABLE register
$6000146c constant RRM_REG_VP_CPU_IRQ_STATUS  \ offset: 0x6C : VP_CPU_IRQ_STATUS register

