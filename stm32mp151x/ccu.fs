\
\ @file ccu.fs
\ @brief CCU
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] CCU_DEF

  [ifdef] CCU_FCCAN_CCU_CREL_DEF
    \
    \ @brief Clock calibration unit core release register
    \ Address offset: 0x00
    \ Reset value: 0x11141218
    \
    $00 constant CCU_DAY                        \ [0x00 : 8] DAY
    $08 constant CCU_MON                        \ [0x08 : 8] MON
    $10 constant CCU_YEAR                       \ [0x10 : 4] YEAR
    $14 constant CCU_SUBSTEP                    \ [0x14 : 4] SUBSTEP
    $18 constant CCU_STEP                       \ [0x18 : 4] STEP
    $1c constant CCU_REL                        \ [0x1c : 4] REL
  [then]


  [ifdef] CCU_FCCAN_CCU_CCFG_DEF
    \
    \ @brief Calibration configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000004
    \
    $00 constant CCU_TQBT                       \ [0x00 : 5] TQBT
    $06 constant CCU_BCC                        \ [0x06] BCC
    $07 constant CCU_CFL                        \ [0x07] CFL
    $08 constant CCU_OCPM                       \ [0x08 : 8] OCPM
    $10 constant CCU_CDIV                       \ [0x10 : 4] CDIV
    $1f constant CCU_SWR                        \ [0x1f] SWR
  [then]


  [ifdef] CCU_FCCAN_CCU_CSTAT_DEF
    \
    \ @brief Calibration status register
    \ Address offset: 0x08
    \ Reset value: 0x0203FFFF
    \
    $00 constant CCU_OCPC                       \ [0x00 : 18] OCPC
    $12 constant CCU_TQC                        \ [0x12 : 11] TQC
    $1e constant CCU_CALS                       \ [0x1e : 2] CALS
  [then]


  [ifdef] CCU_FCCAN_CCU_CWD_DEF
    \
    \ @brief The calibration watchdog is started after the first falling edge when the calibration FSM is in state Not_Calibrated (CCU_CSTAT.CALS = 00). In this state the calibration watchdog monitors the message received. In case no message was received until the calibration watchdog has counted down to 0, the calibration FSM stays in state Not_Calibrated (CCU_CSTAT.CALS = 00), the counter is reloaded with FDCAN_RWD.WDC and basic calibration is restarted after the next falling edge. When in state Basic_Calibrated (CCU_CSTAT.CALS = 01), the calibration watchdog is restarted with each received message . In case no message was received until the calibration watchdog has counted down to 0, the calibration FSM returns to state Not_Calibrated (CCU_CSTAT.CALS = 00), the counter is reloaded with FDCAN_RWD.WDC and basic calibration is restarted after the next falling edge. When a quartz message is received, state Precision_Calibrated (CCU_CSTAT.CALS = 10) is entered and the calibration watchdog is restarted. In this state the calibration watchdog monitors the quartz message received input. In case no message from a quartz controlled node is received by the attached TTCAN until the calibration watchdog has counted down to 0, the calibration FSM transits back to state Basic_Calibrated (CCU_CSTAT.CALS = 01). The signal is active when the CAN protocol engine on the attached TTCAN is started i.e. when the INIT bit is reset. A calibration watchdog event also sets interrupt flag CCU_IR.CWE. If enabled by CCU_IE.CWEE, interrupt line is activated (set to high). Interrupt line remains active until interrupt flag CCU_IR.CWE is reset.
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant CCU_WDC                        \ [0x00 : 16] WDC
    $10 constant CCU_WDV                        \ [0x10 : 16] WDV
  [then]


  [ifdef] CCU_FCCAN_CCU_IR_DEF
    \
    \ @brief The flags are set when one of the listed conditions is detected (edge-sensitive). The flags remain set until the Host clears them. A flag is cleared by writing a 1 to the corresponding bit position. Writing a 0 has no effect. A hard reset will clear the register. The configuration of CCU_IE controls whether an interrupt is generated or not.
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant CCU_CWE                        \ [0x00] CWE
    $01 constant CCU_CSC                        \ [0x01] CSC
  [then]


  [ifdef] CCU_FCCAN_CCU_IE_DEF
    \
    \ @brief The settings in the CU interrupt enable register determine whether a status change in the CU interrupt register will be signaled on an interrupt line.
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant CCU_CWEE                       \ [0x00] CWEE
    $01 constant CCU_CSCE                       \ [0x01] CSCE
  [then]

  \
  \ @brief CCU
  \
  $00 constant CCU_FCCAN_CCU_CREL       \ Clock calibration unit core release register
  $04 constant CCU_FCCAN_CCU_CCFG       \ Calibration configuration register
  $08 constant CCU_FCCAN_CCU_CSTAT      \ Calibration status register
  $0C constant CCU_FCCAN_CCU_CWD        \ The calibration watchdog is started after the first falling edge when the calibration FSM is in state Not_Calibrated (CCU_CSTAT.CALS = 00). In this state the calibration watchdog monitors the message received. In case no message was received until the calibration watchdog has counted down to 0, the calibration FSM stays in state Not_Calibrated (CCU_CSTAT.CALS = 00), the counter is reloaded with FDCAN_RWD.WDC and basic calibration is restarted after the next falling edge. When in state Basic_Calibrated (CCU_CSTAT.CALS = 01), the calibration watchdog is restarted with each received message . In case no message was received until the calibration watchdog has counted down to 0, the calibration FSM returns to state Not_Calibrated (CCU_CSTAT.CALS = 00), the counter is reloaded with FDCAN_RWD.WDC and basic calibration is restarted after the next falling edge. When a quartz message is received, state Precision_Calibrated (CCU_CSTAT.CALS = 10) is entered and the calibration watchdog is restarted. In this state the calibration watchdog monitors the quartz message received input. In case no message from a quartz controlled node is received by the attached TTCAN until the calibration watchdog has counted down to 0, the calibration FSM transits back to state Basic_Calibrated (CCU_CSTAT.CALS = 01). The signal is active when the CAN protocol engine on the attached TTCAN is started i.e. when the INIT bit is reset. A calibration watchdog event also sets interrupt flag CCU_IR.CWE. If enabled by CCU_IE.CWEE, interrupt line is activated (set to high). Interrupt line remains active until interrupt flag CCU_IR.CWE is reset.
  $10 constant CCU_FCCAN_CCU_IR         \ The flags are set when one of the listed conditions is detected (edge-sensitive). The flags remain set until the Host clears them. A flag is cleared by writing a 1 to the corresponding bit position. Writing a 0 has no effect. A hard reset will clear the register. The configuration of CCU_IE controls whether an interrupt is generated or not.
  $14 constant CCU_FCCAN_CCU_IE         \ The settings in the CU interrupt enable register determine whether a status change in the CU interrupt register will be signaled on an interrupt line.

: CCU_DEF ; [then]
