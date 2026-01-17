\
\ @file ccu.fs
\ @brief CCU
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] CCU_DEF

  [ifdef] CCU_CCU_CREL_DEF
    \
    \ @brief Clock calibration unit core release register
    \ Address offset: 0x00
    \ Reset value: 0x11141218
    \
    $00 constant CCU_DAY                        \ [0x00 : 8] Timestamp day = 18
    $08 constant CCU_MON                        \ [0x08 : 8] Timestamp month = 12
    $10 constant CCU_YEAR                       \ [0x10 : 4] Timestamp year =
    $14 constant CCU_SUBSTEP                    \ [0x14 : 4] Sub-step of core release = 1
    $18 constant CCU_STEP                       \ [0x18 : 4] Step of core release = 1
    $1c constant CCU_REL                        \ [0x1c : 4] Core release = 1
  [then]


  [ifdef] CCU_CCU_CCFG_DEF
    \
    \ @brief Calibration configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000004
    \
    $00 constant CCU_TQBT                       \ [0x00 : 5] Time quanta per bit time Configures the number of time quanta per bit time. Same value as configured in FDCAN modules. The range of the resulting time quanta clock fdcan_tq_ck is from 0.5 MHz (bitrate of 125 kbit/s with 4 tq per bit time) to 25 MHz (bitrate of 1 Mbit/s with 25 tq per bit time). Valid values are 4 to 25. Configured values below 4 are interpreted as 4, values above 25 are interpreted as 25. Write access by the Host CPU to registers/bits marked with âP=Protected Writeâ is possible only when the FDCAN control bits FDCAN_CCCR.CCE = 1 AND FDCAN_CCCR.INIT = 1.
    $06 constant CCU_BCC                        \ [0x06] Bypass clock calibration If this bit is set, the clock input fdcan_ker_ck is routed to the time quanta clock through a clock divider configurable via CDIV, cu_cok is always 1. In this case the baudrate prescaler of the connected FDCANs has to be configured to generate the FDCAN internal time quanta clock.
    $07 constant CCU_CFL                        \ [0x07] Calibration field length Write access by the Host CPU to registers/bits marked with âP=Protected Writeâ is possible only when the FDCAN control bits FDCAN_CCCR.CCE = 1 AND FDCAN_CCCR.INIT = 1.
    $08 constant CCU_OCPM                       \ [0x08 : 8] Oscillator clock periods minimum Configures the minimum number of periods in two CAN bit times. OCPM is used in basic calibration to avoid false measurements in case of glitches on the bus line. The configured number of periods is OCPM Ã 32. The configuration depends on the frequency and the bitrate configured in FDCAN modules (from 125 kbit/s up to 1 Mbit/s). It is recommended to configure a value slightly below two CAN bit times. The reset value is 1.6 bit times at 80 MHz fdcan_ker_ck and 1 Mbit/s CAN bitrate. Write access by the Host CPU to registers/bits marked with âP=Protected Writeâ is possible only when the FDCAN control bits FDCAN_CCCR.CCE = 1 AND FDCAN_CCCR.INIT = 1.
    $10 constant CCU_CDIV                       \ [0x10 : 4] Clock divider The clock divider has to be configured when the clock calibration is bypassed (BCC = 1) to ensure that the FDCAN requirement is fulfilled. Write access by the Host CPU to registers/bits marked with âP=Protected Writeâ is possible only when the FDCAN control bits FDCAN_CCCR.CCE = 1 AND FDCAN_CCCR.INIT = 1.
    $1f constant CCU_SWR                        \ [0x1f] Software reset Writing a 1 to this bit resets the calibration FSM to state Not_Calibrated (FDCAN_CCU_CSTAT.CALS = 00). The calibration watchdog value CWD.WDV is also reset. Registers FDCAN_CCFG, FDCAN_CCU_CSTAT and the calibration watchdog configuration CWD.WDC are unchanged. The bit remains set until reset is completed. Write access by the Host CPU to registers/bits marked with âP=Protected Writeâ is possible only when the FDCAN control bits FDCAN_CCCR.CCE = 1 AND FDCAN_CCCR.INIT = 1.
  [then]


  [ifdef] CCU_CCU_CSTAT_DEF
    \
    \ @brief Calibration status register
    \ Address offset: 0x08
    \ Reset value: 0x0203FFFF
    \
    $00 constant CCU_OCPC                       \ [0x00 : 18] Oscillator clock period counter Captured number of oscillator clock periods in calibration field (32 or 64 bits). Only valid when the clock calibration unit is in state Precision_Calibrated.
    $12 constant CCU_TQC                        \ [0x12 : 11] Time quanta counter Captured number of time quanta in calibration field (32 or 64 bits). Only valid when the clock calibration unit is in state Precision_Calibrated.
    $1e constant CCU_CALS                       \ [0x1e : 2] Calibration state
  [then]


  [ifdef] CCU_CCU_CWD_DEF
    \
    \ @brief Calibration watchdog register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant CCU_WDC                        \ [0x00 : 16] WDC Watchdog configuration Start value of the calibration watchdog counter. With the reset value of 00 the counter is disabled. Write access by the Host CPU to registers/bits marked with âP = Protected Writeâ is possible only when the FDCAN control bits FDCAN_CCCR.CCE = 1 AND FDCAN_CCCR.INIT = 1.
    $10 constant CCU_WDV                        \ [0x10 : 16] Watchdog value Actual calibration watchdog counter value.
  [then]


  [ifdef] CCU_CCU_IR_DEF
    \
    \ @brief Clock calibration unit interrupt register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant CCU_CWE                        \ [0x00] Calibration watchdog event
    $01 constant CCU_CSC                        \ [0x01] Calibration state changed
  [then]


  [ifdef] CCU_CCU_IE_DEF
    \
    \ @brief Clock calibration unit interrupt enable register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant CCU_CWEE                       \ [0x00] Calibration watchdog event enable
    $01 constant CCU_CSCE                       \ [0x01] Calibration state changed enable
  [then]

  \
  \ @brief CCU
  \
  $00 constant CCU_CCU_CREL             \ Clock calibration unit core release register
  $04 constant CCU_CCU_CCFG             \ Calibration configuration register
  $08 constant CCU_CCU_CSTAT            \ Calibration status register
  $0C constant CCU_CCU_CWD              \ Calibration watchdog register
  $10 constant CCU_CCU_IR               \ Clock calibration unit interrupt register
  $14 constant CCU_CCU_IE               \ Clock calibration unit interrupt enable register

: CCU_DEF ; [then]
