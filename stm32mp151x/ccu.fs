\
\ @file ccu.fs
\ @brief CCU
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Clock calibration unit core release register
\ Address offset: 0x00
\ Reset value: 0x11141218
\

$000000ff constant CCU_FCCAN_CCU_CREL_DAY                           \ DAY
$0000ff00 constant CCU_FCCAN_CCU_CREL_MON                           \ MON
$000f0000 constant CCU_FCCAN_CCU_CREL_YEAR                          \ YEAR
$00f00000 constant CCU_FCCAN_CCU_CREL_SUBSTEP                       \ SUBSTEP
$0f000000 constant CCU_FCCAN_CCU_CREL_STEP                          \ STEP
$f0000000 constant CCU_FCCAN_CCU_CREL_REL                           \ REL


\
\ @brief Calibration configuration register
\ Address offset: 0x04
\ Reset value: 0x00000004
\

$0000001f constant CCU_FCCAN_CCU_CCFG_TQBT                          \ TQBT
$00000040 constant CCU_FCCAN_CCU_CCFG_BCC                           \ BCC
$00000080 constant CCU_FCCAN_CCU_CCFG_CFL                           \ CFL
$0000ff00 constant CCU_FCCAN_CCU_CCFG_OCPM                          \ OCPM
$000f0000 constant CCU_FCCAN_CCU_CCFG_CDIV                          \ CDIV
$80000000 constant CCU_FCCAN_CCU_CCFG_SWR                           \ SWR


\
\ @brief Calibration status register
\ Address offset: 0x08
\ Reset value: 0x0203FFFF
\

$0003ffff constant CCU_FCCAN_CCU_CSTAT_OCPC                         \ OCPC
$1ffc0000 constant CCU_FCCAN_CCU_CSTAT_TQC                          \ TQC
$c0000000 constant CCU_FCCAN_CCU_CSTAT_CALS                         \ CALS


\
\ @brief The calibration watchdog is started after the first falling edge when the calibration FSM is in state Not_Calibrated (CCU_CSTAT.CALS = 00). In this state the calibration watchdog monitors the message received. In case no message was received until the calibration watchdog has counted down to 0, the calibration FSM stays in state Not_Calibrated (CCU_CSTAT.CALS = 00), the counter is reloaded with FDCAN_RWD.WDC and basic calibration is restarted after the next falling edge. When in state Basic_Calibrated (CCU_CSTAT.CALS = 01), the calibration watchdog is restarted with each received message . In case no message was received until the calibration watchdog has counted down to 0, the calibration FSM returns to state Not_Calibrated (CCU_CSTAT.CALS = 00), the counter is reloaded with FDCAN_RWD.WDC and basic calibration is restarted after the next falling edge. When a quartz message is received, state Precision_Calibrated (CCU_CSTAT.CALS = 10) is entered and the calibration watchdog is restarted. In this state the calibration watchdog monitors the quartz message received input. In case no message from a quartz controlled node is received by the attached TTCAN until the calibration watchdog has counted down to 0, the calibration FSM transits back to state Basic_Calibrated (CCU_CSTAT.CALS = 01). The signal is active when the CAN protocol engine on the attached TTCAN is started i.e. when the INIT bit is reset. A calibration watchdog event also sets interrupt flag CCU_IR.CWE. If enabled by CCU_IE.CWEE, interrupt line is activated (set to high). Interrupt line remains active until interrupt flag CCU_IR.CWE is reset.
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant CCU_FCCAN_CCU_CWD_WDC                            \ WDC
$ffff0000 constant CCU_FCCAN_CCU_CWD_WDV                            \ WDV


\
\ @brief The flags are set when one of the listed conditions is detected (edge-sensitive). The flags remain set until the Host clears them. A flag is cleared by writing a 1 to the corresponding bit position. Writing a 0 has no effect. A hard reset will clear the register. The configuration of CCU_IE controls whether an interrupt is generated or not.
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant CCU_FCCAN_CCU_IR_CWE                             \ CWE
$00000002 constant CCU_FCCAN_CCU_IR_CSC                             \ CSC


\
\ @brief The settings in the CU interrupt enable register determine whether a status change in the CU interrupt register will be signaled on an interrupt line.
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant CCU_FCCAN_CCU_IE_CWEE                            \ CWEE
$00000002 constant CCU_FCCAN_CCU_IE_CSCE                            \ CSCE


\
\ @brief CCU
\
$44010000 constant CCU_FCCAN_CCU_CREL  \ offset: 0x00 : Clock calibration unit core release register
$44010004 constant CCU_FCCAN_CCU_CCFG  \ offset: 0x04 : Calibration configuration register
$44010008 constant CCU_FCCAN_CCU_CSTAT  \ offset: 0x08 : Calibration status register
$4401000c constant CCU_FCCAN_CCU_CWD  \ offset: 0x0C : The calibration watchdog is started after the first falling edge when the calibration FSM is in state Not_Calibrated (CCU_CSTAT.CALS = 00). In this state the calibration watchdog monitors the message received. In case no message was received until the calibration watchdog has counted down to 0, the calibration FSM stays in state Not_Calibrated (CCU_CSTAT.CALS = 00), the counter is reloaded with FDCAN_RWD.WDC and basic calibration is restarted after the next falling edge. When in state Basic_Calibrated (CCU_CSTAT.CALS = 01), the calibration watchdog is restarted with each received message . In case no message was received until the calibration watchdog has counted down to 0, the calibration FSM returns to state Not_Calibrated (CCU_CSTAT.CALS = 00), the counter is reloaded with FDCAN_RWD.WDC and basic calibration is restarted after the next falling edge. When a quartz message is received, state Precision_Calibrated (CCU_CSTAT.CALS = 10) is entered and the calibration watchdog is restarted. In this state the calibration watchdog monitors the quartz message received input. In case no message from a quartz controlled node is received by the attached TTCAN until the calibration watchdog has counted down to 0, the calibration FSM transits back to state Basic_Calibrated (CCU_CSTAT.CALS = 01). The signal is active when the CAN protocol engine on the attached TTCAN is started i.e. when the INIT bit is reset. A calibration watchdog event also sets interrupt flag CCU_IR.CWE. If enabled by CCU_IE.CWEE, interrupt line is activated (set to high). Interrupt line remains active until interrupt flag CCU_IR.CWE is reset.
$44010010 constant CCU_FCCAN_CCU_IR  \ offset: 0x10 : The flags are set when one of the listed conditions is detected (edge-sensitive). The flags remain set until the Host clears them. A flag is cleared by writing a 1 to the corresponding bit position. Writing a 0 has no effect. A hard reset will clear the register. The configuration of CCU_IE controls whether an interrupt is generated or not.
$44010014 constant CCU_FCCAN_CCU_IE  \ offset: 0x14 : The settings in the CU interrupt enable register determine whether a status change in the CU interrupt register will be signaled on an interrupt line.

