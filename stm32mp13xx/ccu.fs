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

$000000ff constant CCU_CCU_CREL_DAY                                 \ Timestamp day = 18
$0000ff00 constant CCU_CCU_CREL_MON                                 \ Timestamp month = 12
$000f0000 constant CCU_CCU_CREL_YEAR                                \ Timestamp year =
$00f00000 constant CCU_CCU_CREL_SUBSTEP                             \ Sub-step of core release = 1
$0f000000 constant CCU_CCU_CREL_STEP                                \ Step of core release = 1
$f0000000 constant CCU_CCU_CREL_REL                                 \ Core release = 1


\
\ @brief Calibration configuration register
\ Address offset: 0x04
\ Reset value: 0x00000004
\

$0000001f constant CCU_CCU_CCFG_TQBT                                \ Time quanta per bit time Configures the number of time quanta per bit time. Same value as configured in FDCAN modules. The range of the resulting time quanta clock fdcan_tq_ck is from 0.5 MHz (bitrate of 125 kbit/s with 4 tq per bit time) to 25 MHz (bitrate of 1 Mbit/s with 25 tq per bit time). Valid values are 4 to 25. Configured values below 4 are interpreted as 4, values above 25 are interpreted as 25. Write access by the Host CPU to registers/bits marked with âP=Protected Writeâ is possible only when the FDCAN control bits FDCAN_CCCR.CCE = 1 AND FDCAN_CCCR.INIT = 1.
$00000040 constant CCU_CCU_CCFG_BCC                                 \ Bypass clock calibration If this bit is set, the clock input fdcan_ker_ck is routed to the time quanta clock through a clock divider configurable via CDIV, cu_cok is always 1. In this case the baudrate prescaler of the connected FDCANs has to be configured to generate the FDCAN internal time quanta clock.
$00000080 constant CCU_CCU_CCFG_CFL                                 \ Calibration field length Write access by the Host CPU to registers/bits marked with âP=Protected Writeâ is possible only when the FDCAN control bits FDCAN_CCCR.CCE = 1 AND FDCAN_CCCR.INIT = 1.
$0000ff00 constant CCU_CCU_CCFG_OCPM                                \ Oscillator clock periods minimum Configures the minimum number of periods in two CAN bit times. OCPM is used in basic calibration to avoid false measurements in case of glitches on the bus line. The configured number of periods is OCPM Ã 32. The configuration depends on the frequency and the bitrate configured in FDCAN modules (from 125 kbit/s up to 1 Mbit/s). It is recommended to configure a value slightly below two CAN bit times. The reset value is 1.6 bit times at 80 MHz fdcan_ker_ck and 1 Mbit/s CAN bitrate. Write access by the Host CPU to registers/bits marked with âP=Protected Writeâ is possible only when the FDCAN control bits FDCAN_CCCR.CCE = 1 AND FDCAN_CCCR.INIT = 1.
$000f0000 constant CCU_CCU_CCFG_CDIV                                \ Clock divider The clock divider has to be configured when the clock calibration is bypassed (BCC = 1) to ensure that the FDCAN requirement is fulfilled. Write access by the Host CPU to registers/bits marked with âP=Protected Writeâ is possible only when the FDCAN control bits FDCAN_CCCR.CCE = 1 AND FDCAN_CCCR.INIT = 1.
$80000000 constant CCU_CCU_CCFG_SWR                                 \ Software reset Writing a 1 to this bit resets the calibration FSM to state Not_Calibrated (FDCAN_CCU_CSTAT.CALS = 00). The calibration watchdog value CWD.WDV is also reset. Registers FDCAN_CCFG, FDCAN_CCU_CSTAT and the calibration watchdog configuration CWD.WDC are unchanged. The bit remains set until reset is completed. Write access by the Host CPU to registers/bits marked with âP=Protected Writeâ is possible only when the FDCAN control bits FDCAN_CCCR.CCE = 1 AND FDCAN_CCCR.INIT = 1.


\
\ @brief Calibration status register
\ Address offset: 0x08
\ Reset value: 0x0203FFFF
\

$0003ffff constant CCU_CCU_CSTAT_OCPC                               \ Oscillator clock period counter Captured number of oscillator clock periods in calibration field (32 or 64 bits). Only valid when the clock calibration unit is in state Precision_Calibrated.
$1ffc0000 constant CCU_CCU_CSTAT_TQC                                \ Time quanta counter Captured number of time quanta in calibration field (32 or 64 bits). Only valid when the clock calibration unit is in state Precision_Calibrated.
$c0000000 constant CCU_CCU_CSTAT_CALS                               \ Calibration state


\
\ @brief Calibration watchdog register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000ffff constant CCU_CCU_CWD_WDC                                  \ WDC Watchdog configuration Start value of the calibration watchdog counter. With the reset value of 00 the counter is disabled. Write access by the Host CPU to registers/bits marked with âP = Protected Writeâ is possible only when the FDCAN control bits FDCAN_CCCR.CCE = 1 AND FDCAN_CCCR.INIT = 1.
$ffff0000 constant CCU_CCU_CWD_WDV                                  \ Watchdog value Actual calibration watchdog counter value.


\
\ @brief Clock calibration unit interrupt register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant CCU_CCU_IR_CWE                                   \ Calibration watchdog event
$00000002 constant CCU_CCU_IR_CSC                                   \ Calibration state changed


\
\ @brief Clock calibration unit interrupt enable register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant CCU_CCU_IE_CWEE                                  \ Calibration watchdog event enable
$00000002 constant CCU_CCU_IE_CSCE                                  \ Calibration state changed enable


\
\ @brief CCU
\
$44010000 constant CCU_CCU_CREL   \ offset: 0x00 : Clock calibration unit core release register
$44010004 constant CCU_CCU_CCFG   \ offset: 0x04 : Calibration configuration register
$44010008 constant CCU_CCU_CSTAT  \ offset: 0x08 : Calibration status register
$4401000c constant CCU_CCU_CWD    \ offset: 0x0C : Calibration watchdog register
$44010010 constant CCU_CCU_IR     \ offset: 0x10 : Clock calibration unit interrupt register
$44010014 constant CCU_CCU_IE     \ offset: 0x14 : Clock calibration unit interrupt enable register

