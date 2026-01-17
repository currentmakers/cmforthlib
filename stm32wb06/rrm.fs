\
\ @file rrm.fs
\ @brief UDRA_CTRL0 register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RRM_DEF

  [ifdef] RRM_UDRA_CTRL0_DEF
    \
    \ @brief UDRA_CTRL0 register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant RRM_RELOAD_RDCFGPTR            \ [0x00] reload the radio configuration pointer from RAM.
  [then]


  [ifdef] RRM_UDRA_IRQ_ENABLE_DEF
    \
    \ @brief UDRA_IRQ_ENABLE register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant RRM_RADIO_CFG_PTR_RELOADED     \ [0x00] UDRA interrupt enable (reload radio config pointer)
    $01 constant RRM_CMD_START                  \ [0x01] UDRA interrupt enable (command start)
    $02 constant RRM_CMD_END                    \ [0x02] UDRA interrupt enable (command end)
  [then]


  [ifdef] RRM_UDRA_IRQ_STATUS_DEF
    \
    \ @brief UDRA_IRQ_STATUS register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RRM_RADIO_CFG_PTR_RELOADED     \ [0x00] On read, returns the UDRA reload radio configuration pointer interrupt status.
    $01 constant RRM_CMD_STARD                  \ [0x01] On read, returns the UDRA command start interrupt status.
    $02 constant RRM_CMD_END                    \ [0x02] On read, returns the UDRA command end interrupt status
  [then]


  [ifdef] RRM_UDRA_RADIO_CFG_PTR_DEF
    \
    \ @brief UDRA_RADIO_CFG_PTR register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant RRM_RADIO_CONFIG_ADDRESS       \ [0x00 : 32] UDRA radio configuration address.
  [then]


  [ifdef] RRM_SEMA_IRQ_ENABLE_DEF
    \
    \ @brief SEMA_IRQ_ENABLE register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant RRM_LOCK                       \ [0x00] semaphore locked (= one port granted) interrupt enable
    $01 constant RRM_UNLOCK                     \ [0x01] semaphore unlocked (=no port selected) interrupt enable
  [then]


  [ifdef] RRM_SEMA_IRQ_STATUS_DEF
    \
    \ @brief SEMA_IRQ_STATUS register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant RRM_LOCK                       \ [0x00] On read, returns the semaphore locked interrupt status.
    $01 constant RRM_UNLOCK                     \ [0x01] On read, returns the semaphore unlocked interrupt status.
  [then]


  [ifdef] RRM_BLE_IRQ_ENABLE_DEF
    \
    \ @brief BLE_IRQ_ENABLE register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RRM_PORT_GRANT                 \ [0x00] IP_BLE Port grant interrupt enable
    $01 constant RRM_PORT_RELEASE               \ [0x01] IP_BLE Port release interrupt enable
    $03 constant RRM_PORT_CMD_START             \ [0x03] IP_BLE Port command start interrup enable
    $04 constant RRM_PORT_CMD_END               \ [0x04] IP_BLE Port command end interrup enable
  [then]


  [ifdef] RRM_BLE_IRQ_STATUS_DEF
    \
    \ @brief BLE_IRQ_STATUS register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RRM_PORT_GRANT                 \ [0x00] IP_BLE hardware port granted interrupt status:
    $01 constant RRM_PORT_RELEASE               \ [0x01] IP_BLE hardware port released interrupt status.
    $03 constant RRM_CMD_START                  \ [0x03] IP_BLE hardware port command start interrupt status.
    $04 constant RRM_CMD_END                    \ [0x04] IP_BLE hardware port command end interrupt status.
  [then]


  [ifdef] RRM_VP_CPU_CMD_BUS_DEF
    \
    \ @brief VP_CPU_CMD_BUS register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant RRM_COMMAND                    \ [0x00 : 3] command number
    $03 constant RRM_COMMAND_REQ                \ [0x03] CPU Virtual port command request:
  [then]


  [ifdef] RRM_VP_CPU_SEMA_BUS_DEF
    \
    \ @brief VP_CPU_SEMA_BUS register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant RRM_TAKE_PRIO                  \ [0x00 : 3] semaphore priority: priority value (between 0 and 7) of the take request.
    $03 constant RRM_TAKE_REQ                   \ [0x03] semaphore token request:
  [then]


  [ifdef] RRM_VP_CPU_IRQ_ENABLE_DEF
    \
    \ @brief VP_CPU_IRQ_ENABLE register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant RRM_PORT_GRANT                 \ [0x00] CPU virtual port grant interrupt enable
    $01 constant RRM_PORT_RELEASE               \ [0x01] CPU virtual port release interrupt enable
    $03 constant RRM_PORT_CMD_START             \ [0x03] CPU virtual port command start interrup enable
    $04 constant RRM_PORT_CMD_END               \ [0x04] CPU virtual port command end interrup enable
  [then]


  [ifdef] RRM_VP_CPU_IRQ_STATUS_DEF
    \
    \ @brief VP_CPU_IRQ_STATUS register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant RRM_PORT_GRANT                 \ [0x00] CPU virtual port granted interrupt status.
    $01 constant RRM_PORT_RELEASE               \ [0x01] virtual port released interrupt status.
    $02 constant RRM_PORT_PREEMPT               \ [0x02] CPU virtual port preemption (at semaphore level) interrupt status.
    $03 constant RRM_CMD_START                  \ [0x03] CPU virtual port command start interrupt status.
    $04 constant RRM_CMD_END                    \ [0x04] CPU virtual port command end interrupt status.
  [then]

  \
  \ @brief UDRA_CTRL0 register
  \
  $10 constant RRM_UDRA_CTRL0           \ UDRA_CTRL0 register
  $14 constant RRM_UDRA_IRQ_ENABLE      \ UDRA_IRQ_ENABLE register
  $18 constant RRM_UDRA_IRQ_STATUS      \ UDRA_IRQ_STATUS register
  $1C constant RRM_UDRA_RADIO_CFG_PTR   \ UDRA_RADIO_CFG_PTR register
  $20 constant RRM_SEMA_IRQ_ENABLE      \ SEMA_IRQ_ENABLE register
  $24 constant RRM_SEMA_IRQ_STATUS      \ SEMA_IRQ_STATUS register
  $28 constant RRM_BLE_IRQ_ENABLE       \ BLE_IRQ_ENABLE register
  $2C constant RRM_BLE_IRQ_STATUS       \ BLE_IRQ_STATUS register
  $60 constant RRM_VP_CPU_CMD_BUS       \ VP_CPU_CMD_BUS register
  $64 constant RRM_VP_CPU_SEMA_BUS      \ VP_CPU_SEMA_BUS register
  $68 constant RRM_VP_CPU_IRQ_ENABLE    \ VP_CPU_IRQ_ENABLE register
  $6C constant RRM_VP_CPU_IRQ_STATUS    \ VP_CPU_IRQ_STATUS register

: RRM_DEF ; [then]
