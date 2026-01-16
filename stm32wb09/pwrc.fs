\
\ @file pwrc.fs
\ @brief CR1 register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief CR1 register
\ Address offset: 0x00
\ Reset value: 0x00000114
\

$00000001 constant PWRC_CR1_LPMS                                    \ LPMS Low Power Mode Selection Selection of the low power mode entered when CPU enters DEEP SLEEP mode and BLE is rdy2sleep.
$00000002 constant PWRC_CR1_ENSDNBOR                                \ ENSDNBOR: Enable BOR supply monitoring during shutdown mode.
$00000004 constant PWRC_CR1_IBIAS_RUN_AUTO                          \ IBIAS_RUN_AUTO: Enable automatic IBIAS control during RUN/DEEPSTOP mode. 0: IBIAS control is manual (and controlled by IBIAS_RUN_STATE register) 1: IBIAS control is automatic (default).
$00000008 constant PWRC_CR1_IBIAS_RUN_STATE                         \ IBIAS_RUN_STATE: Enable/Disable IBIAS during RUN mode when automatic mode is disabled. 0: IBIAS control is disabled (default). 1: IBIAS control is enabled.
$00000010 constant PWRC_CR1_APC                                     \ APC Apply Pull-up and pull-down configuration from CPU
$00000020 constant PWRC_CR1_ENBORH                                  \ ENBORH: enable BORH configuration
$000000c0 constant PWRC_CR1_SELBORH                                 \ SELBORH[1:0]: BORH selection of Vbor threshold
$00000100 constant PWRC_CR1_ENBORL                                  \ ENBORL: Enable BORL reset supervising during RUN mode. 0: No BORL is monitored during RUN mode. 1: BORL is monitored during RUN mode (a POR reset will happen if VDDIO goes below 1.6V during RUN mode) (default). Note: Enabling this feature prevents blocking the device if VDDIO goes below supported voltages during RUN.


\
\ @brief CR2 register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant PWRC_CR2_PVDE                                    \ PVDE Programmable Voltage Detector Enable When this bit is set the Power Voltage Detector is enabled
$0000000e constant PWRC_CR2_PVDLS                                   \ PVDLS[2:0] Programmable Voltage Detector Level selection then PVDO=1)
$00000010 constant PWRC_CR2_DBGRET                                  \ DBGRET: PA2 and PA3 retention enable after DEEPSTOP 0: PA2, PA3 don't retain their status exiting from DEEPSTOP. (default) 1: PA2, PA3 retain their status exiting from DEEPSTOP.
$00000020 constant PWRC_CR2_RAMRET1                                 \ RAMRET1: RAM1 retention during low power mode
$00000100 constant PWRC_CR2_GPIORET                                 \ GPIORET: GPIO retention enable. 0: GPIO don't retain their status during DEEPSTOP and exiting from DEEPSTOP (default) 1: GPIO retain their status during DEEPSTOP and exiting from DEEPSTOP. Note: it's mandatory to ensure this bit is set before entering DEEPSTOP unless DBRG.DEEPSTOP2 bit is set.
$00000200 constant PWRC_CR2_ENTS                                    \ ENTS: Enable Temperature Sensor


\
\ @brief CR3 register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant PWRC_CR3_EWU0                                    \ EWU0 Enable WakeUp line 0 (PB0) When this bit is set the wakeup line 0 is enabled and a rising or falling edge on wakeup line 0 will trigger a CPU wakeup event depending on CR4.WP0 bit.
$00000002 constant PWRC_CR3_EWU1                                    \ EWU1 Enable WakeUp line 1 (PB1) When this bit is set the wakeup line 1 is enabled and a rising or falling edge on wakeup line 1 will trigger a CPU wakeup event depending on CR4.WP1 bit.
$00000004 constant PWRC_CR3_EWU2                                    \ EWU2 Enable WakeUp line 2 (PB2) When this bit is set the wakeup line 2 is enabled and a rising or falling edge on wakeup line 2 will trigger a CPU wakeup event depending on CR4.WP2 bit.
$00000008 constant PWRC_CR3_EWU3                                    \ EWU3 Enable WakeUp line 3 (PB3) When this bit is set the wakeup line 3 is enabled and a rising or falling edge on wakeup line 3 will trigger a CPU wakeup event depending on CR4.WP3 bit.
$00000010 constant PWRC_CR3_EWU4                                    \ EWU4 Enable WakeUp line 4 (PB4) When this bit is set the wakeup line 4 is enabled and a rising or falling edge on wakeup line 4 will trigger a CPU wakeup event depending on CR4.WP4 bit.
$00000020 constant PWRC_CR3_EWU5                                    \ EWU5 Enable WakeUp line 5 (PB5) When this bit is set the wakeup line 5 is enabled and a rising or falling edge on wakeup line 5 will trigger a CPU wakeup event depending on CR4.WP5 bit.
$00000040 constant PWRC_CR3_EWU6                                    \ EWU6 Enable WakeUp line 6 (PB6) When this bit is set the wakeup line 6 is enabled and a rising or falling edge on wakeup line 6 will trigger a CPU wakeup event depending on CR4.WP6 bit.
$00000080 constant PWRC_CR3_EWU7                                    \ EWU7 Enable WakeUp line 7 (PB7) When this bit is set the wakeup line 7 is enabled and a rising or falling edge on wakeup line 7 will trigger a CPU wakeup event depending on CR4.WP7 bit.
$00000100 constant PWRC_CR3_EWU8                                    \ EWU8 Enable WakeUp line 8 (PA8) When this bit is set the wakeup line 8 is enabled and a rising or falling edge on wakeup line 8 will trigger a CPU wakeup event depending on CR4.WP8 bit.
$00000200 constant PWRC_CR3_EWU9                                    \ EWU9 Enable WakeUp line 9 (PA9) When this bit is set the wakeup line 9 is enabled and a rising or falling edge on wakeup line 9 will trigger a CPU wakeup event depending on CR4.WP9 bit.
$00000400 constant PWRC_CR3_EWU10                                   \ EWU10 Enable WakeUp line 10 (PA10) When this bit is set the wakeup line 10 is enabled and a rising or falling edge on wakeup line 10 will trigger a CPU wakeup event depending on CR4.WP10 bit.
$00000800 constant PWRC_CR3_EWU11                                   \ EWU11 Enable WakeUp line 11 (PA11) When this bit is set the wakeup line 11 is enabled and a rising or falling edge on wakeup line 11 will trigger a CPU wakeup event depending on CR4.WP11 bit.
$00001000 constant PWRC_CR3_EWBLE                                   \ EWBLE: Enable wakeup on BLE event. 0: Wakeup on BLE line is disabled (default). 1: Wakeup on BLE line is enabled.
$00002000 constant PWRC_CR3_EWBLEHCPU                               \ EWBLEHCPU: Enable wakeup on BLE Host CPU event. 0: Wakeup on BLE Host CPU line is disabled (default). 1: Wakeup on BLE Host CPU line is enabled.
$00004000 constant PWRC_CR3_EIWL2                                   \ EIWL2: Enable wakeup on Internal event (LPUART). 0: Wakeup on internal line is disabled (default). 1: Wakeup on internal line is enabled.
$00008000 constant PWRC_CR3_EIWL                                    \ EIWL: Enable wakeup on Internal event (RTC). 0: Wakeup on internal line is disabled (default). 1: Wakeup on internal line is enabled.


\
\ @brief CR4 register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant PWRC_CR4_WUP0                                    \ WUP0 Wake-up Line Polarity 0 (PB0) This bit defines the polarity used for event detection on external wake-up line 0
$00000002 constant PWRC_CR4_WUP1                                    \ WUP1 Wake-up Line Polarity 1 (PB1) This bit defines the polarity used for event detection on external wake-up line 1
$00000004 constant PWRC_CR4_WUP2                                    \ WUP2 Wake-up Line Polarity 2 (PB2) This bit defines the polarity used for event detection on external wake-up line 2
$00000008 constant PWRC_CR4_WUP3                                    \ WUP3 Wake-up Line Polarity 3 (PB3) This bit defines the polarity used for event detection on external wake-up line 3
$00000010 constant PWRC_CR4_WUP4                                    \ WUP4 Wake-up Line Polarity 4 (PB4) This bit defines the polarity used for event detection on external wake-up line 4
$00000020 constant PWRC_CR4_WUP5                                    \ WUP5 Wake-up Line Polarity 5 (PB5) This bit defines the polarity used for event detection on external wake-up line 5
$00000040 constant PWRC_CR4_WUP6                                    \ WUP6 Wake-up Line Polarity 6 (PB6) This bit defines the polarity used for event detection on external wake-up line 6
$00000080 constant PWRC_CR4_WUP7                                    \ WUP7 Wake-up Line Polarity 7 (PB7) This bit defines the polarity used for event detection on external wake-up line 7
$00000100 constant PWRC_CR4_WUP8                                    \ WUP8 Wake-up Line Polarity 8 (PA8) This bit defines the polarity used for event detection on external wake-up line 8
$00000200 constant PWRC_CR4_WUP9                                    \ WUP9 Wake-up Line Polarity 9 (PA9) This bit defines the polarity used for event detection on external wake-up line 9
$00000400 constant PWRC_CR4_WUP10                                   \ WUP10 Wake-up Line Polarity 10 (PA10) This bit defines the polarity used for event detection on external wake-up line 10
$00000800 constant PWRC_CR4_WUP11                                   \ WUP11 Wake-up Line Polarity 11 (PA11) This bit defines the polarity used for event detection on external wake-up line 11


\
\ @brief SR1 register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant PWRC_SR1_WUF0                                    \ WUF0 WakeUp Flag 0 (PB0) This bit is set when a wakeup is detected on wakeup line 0. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
$00000002 constant PWRC_SR1_WUF1                                    \ WUF1 WakeUp Flag 1 (PB1) This bit is set when a wakeup is detected on wakeup line 1. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
$00000004 constant PWRC_SR1_WUF2                                    \ WUF2 WakeUp Flag 2 (PB2) This bit is set when a wakeup is detected on wakeup line 2. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
$00000008 constant PWRC_SR1_WUF3                                    \ WUF3 WakeUp Flag 3 (PB3) This bit is set when a wakeup is detected on wakeup line 3. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
$00000010 constant PWRC_SR1_WUF4                                    \ WUF4 WakeUp Flag 4 (PB4) This bit is set when a wakeup is detected on wakeup line 4. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
$00000020 constant PWRC_SR1_WUF5                                    \ WUF5 WakeUp Flag 5 (PB5) This bit is set when a wakeup is detected on wakeup line 5. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
$00000040 constant PWRC_SR1_WUF6                                    \ WUF6 WakeUp Flag 6 (PB6) This bit is set when a wakeup is detected on wakeup line 6. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
$00000080 constant PWRC_SR1_WUF7                                    \ WUF7 WakeUp Flag 7 (PB7) This bit is set when a wakeup is detected on wakeup line 7. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
$00000100 constant PWRC_SR1_WUF8                                    \ WUF8 WakeUp Flag 8 (PA8) This bit is set when a wakeup is detected on wakeup line 8. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
$00000200 constant PWRC_SR1_WUF9                                    \ WUF9 WakeUp Flag 9 (PA9) This bit is set when a wakeup is detected on wakeup line 9. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
$00000400 constant PWRC_SR1_WUF10                                   \ WUF10 WakeUp Flag 10 (PA10) This bit is set when a wakeup is detected on wakeup line 10. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
$00000800 constant PWRC_SR1_WUF11                                   \ WUF11 WakeUp Flag 11 (PA11) This bit is set when a wakeup is detected on wakeup line 11. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
$00001000 constant PWRC_SR1_WBLEF                                   \ WBLEF: BLE wakeup flag. 0: no wakeup from BLE occurred since last clear. 1: a wakeup from BLE occurred since last clear. Cleared by writing 1 in this bit.
$00002000 constant PWRC_SR1_WBLEHCPUF                               \ WBLEHCPUF: BLE Host CPU wakeup flag. 0: no wakeup from BLE Host CPU occurred since last clear. 1: a wakeup from BLE Host CPU occurred since last clear. Cleared by writing 1 in this bit.
$00004000 constant PWRC_SR1_IWUF2                                   \ IWUF2: Internal wakeup 2 flag (LPUART). 0: no wakeup from LPUART occurred since last clear. 1: a wakeup from LPUART occurred since last clear. Note: The user must clear the LPUART wakeup flag inside the LPUART IP to clear this bit (mirror of the LPUART wakeup line on the PWRC block).
$00008000 constant PWRC_SR1_IWUF                                    \ IWUF: Internal wakeup flag (RTC). 0: no wakeup from RTC occurred since last clear. 1: a wakeup from RTC occurred since last clear. Note: The user must clear the RTC wakeup flag inside the RTC IP to clear this bit (mirror of the RTC wakeup line on the PWRC block).


\
\ @brief SR2 register
\ Address offset: 0x14
\ Reset value: 0x00000306
\

$00000001 constant PWRC_SR2_SMPSBYPR                                \ SMPSBYPR: SMPS Force Bypass Control Replica This bit mirrors the actual BYPASS_3V3 control signal driven to the SMPS regulator, dependant on the real working state.
$00000002 constant PWRC_SR2_SMPSENR                                 \ SMPSENR: SMPS Enable Control Replica This bit mirrors the actual ENABLE_3V3 control signal driven to the SMPS regulator, dependant on the real working state.
$00000004 constant PWRC_SR2_SMPSRDY                                 \ SMPSRDY: SMPS Ready Status This bit provides the information whether SMPS is ready.
$000000f0 constant PWRC_SR2_IOBOOTVAL2                              \ Bit3: PB15 input value on VDD33 latched at POR Bit2: PB14 input value on VDD33 latched at POR Bit1: PB13 input value on VDD33 latched at POR Bit0: PB12 input value on VDD33 latched at POR
$00000100 constant PWRC_SR2_REGLPS                                  \ REGLPS: Regulator Low Power Started This bit provides the information whether low power regulator is ready.
$00000200 constant PWRC_SR2_REGMS                                   \ REGMS: Regulator Main LDO Started This bit provides the information whether main regulator is ready.
$00000800 constant PWRC_SR2_PVDO                                    \ PVDO: Power Voltage Detector Output When the Power Voltage Detector is enabled (CR2.PVDE) this bit is set when the system supply (VDDIO) is lower than the selected PVD threshold (CR2.PVDLS)
$0000f000 constant PWRC_SR2_IOBOOTVAL                               \ Bit3: PA11 input value on VDD33 latched at POR Bit2: PA10 input value on VDD33 latched at POR Bit1: PA9 input value on VDD33 latched at POR Bit0: PA8 input value on VDD33 latched at POR


\
\ @brief CR5 register
\ Address offset: 0x1C
\ Reset value: 0x00006014
\

$0000000f constant PWRC_CR5_SMPSLVL                                 \ SMPSLVL[3:0] SMPS Output Level Voltage Selection Select the SMPS output voltage with a granularity of 50mV. Default = '0100' (1.4V) Vout = 1.2 + 0.05*SMPSOUT (V)
$00000030 constant PWRC_CR5_SMPSBOMSEL                              \ SMPSBOMSEL: SMPS BOM Selection:
$00000080 constant PWRC_CR5_SMPSFRDY                                \ SMPSFB Force ready check When this bit is set, the SMPS FSM will consider the SMPS ready .
$00000100 constant PWRC_CR5_SMPSLPOPEN                              \ SMPSLPOPEN: In Low Power mode SMPS is in OPEN mode (instead of PRECHARGE mode). When this bit is set, when the chip is in Low power mode the SMPS regulator will be disabled (HZ) Documentation needed.
$00000200 constant PWRC_CR5_SMPSFBYP                                \ SMPSFB Force SMPS Regulator in bypass mode When this bit is set, the SMPS regulator will be forced to operate in precharge mode. the actual state of SMPS can be observed thanks to the replica SR2.SMPSBYPR.
$00000400 constant PWRC_CR5_NOSMPS                                  \ NOSMPS: No SMPS Mode When this bit is set, the SMPS regulator will be disabled. Note that this configuration should be used only when SMPS_FB pad is directly connected to VBATT or Vext, without L/C BOM.
$00000800 constant PWRC_CR5_SMPS_ENA_DCM                            \ SMPS_ENA_DCM: enable discontinuous conduction mode
$00001000 constant PWRC_CR5_CLKDETR_DISABLE                         \ CLKDETR_DISABLE: disable SMPS clock detection The SMPS clock detection enables an automatic SMPS bypass switching in case of unwanted loss of SMPS clock.
$00006000 constant PWRC_CR5_SMPS_PRECH_CUR_SEL                      \ SMPS_PRECH_CUR_SEL[1:0] Selection for SMPS PRECHARGE limit current


\
\ @brief PUCRA register
\ Address offset: 0x20
\ Reset value: 0x00000F07
\

$0000ffff constant PWRC_PUCRA_PU                                    \ PU[x] : Pull Up Pull up activation on port A[i] pad when APC bit of PWRC CR3 is set


\
\ @brief PDCRA register
\ Address offset: 0x24
\ Reset value: 0x00000008
\

$0000ffff constant PWRC_PDCRA_PD                                    \ PD[x]: Pull Down Pull Down activation on port A[i] pad when APC bit of PWRC CR3 is set


\
\ @brief PUCRB register
\ Address offset: 0x28
\ Reset value: 0x0000F0FF
\

$0000ffff constant PWRC_PUCRB_PU                                    \ PU[x] : Pull Up Pull up activation on port B[i] pad when APC bit of PWRC CR3 is set


\
\ @brief PDCRB register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant PWRC_PDCRB_PD                                    \ PD[x]: Pull Down Pull Down activation on port B[i] pad when APC bit of PWRC CR3 is set


\
\ @brief CR6 register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant PWRC_CR6_EWU12                                   \ EWU12 Enable WakeUp line 12 (PA0) When this bit is set the wakeup line 12 is enabled and a rising or falling edge on wakeup line 0 will trigger a CPU wakeup event depending on CR7.WP0 bit.
$00000002 constant PWRC_CR6_EWU13                                   \ EWU13 Enable WakeUp line 13 (PA1) When this bit is set the wakeup line 13 is enabled and a rising or falling edge on wakeup line 1 will trigger a CPU wakeup event depending on CR7.WP1 bit.
$00000004 constant PWRC_CR6_EWU14                                   \ EWU14 Enable WakeUp line 14 (PA2) When this bit is set the wakeup line 14 is enabled and a rising or falling edge on wakeup line 2 will trigger a CPU wakeup event depending on CR7.WP2 bit.
$00000008 constant PWRC_CR6_EWU15                                   \ EWU15 Enable WakeUp line 15 (PA3) When this bit is set the wakeup line 15 is enabled and a rising or falling edge on wakeup line 3 will trigger a CPU wakeup event depending on CR7.WP3 bit.
$00000010 constant PWRC_CR6_EWU16                                   \ EWU16 Enable WakeUp line 16 (PB12) When this bit is set the wakeup line 16 is enabled and a rising or falling edge on wakeup line 4 will trigger a CPU wakeup event depending on CR7.WP4 bit.
$00000020 constant PWRC_CR6_EWU17                                   \ EWU17 Enable WakeUp line 17 (PB13) When this bit is set the wakeup line 17 is enabled and a rising or falling edge on wakeup line 5 will trigger a CPU wakeup event depending on CR7.WP5 bit.
$00000040 constant PWRC_CR6_EWU18                                   \ EWU18 Enable WakeUp line 18 (PB14) When this bit is set the wakeup line 18 is enabled and a rising or falling edge on wakeup line 6 will trigger a CPU wakeup event depending on CR7.WP6 bit.
$00000080 constant PWRC_CR6_EWU19                                   \ EWU19 Enable WakeUp line 19 (PB15) When this bit is set the wakeup line 19 is enabled and a rising or falling edge on wakeup line 7 will trigger a CPU wakeup event depending on CR7.WP7 bit.


\
\ @brief CR7 register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant PWRC_CR7_WUP12                                   \ WUP12 Wake-up Line Polarity 12 (PA0) This bit defines the polarity used for event detection on external wake-up line 12
$00000002 constant PWRC_CR7_WUP13                                   \ WUP13 Wake-up Line Polarity 13 (PA1) This bit defines the polarity used for event detection on external wake-up line 13
$00000004 constant PWRC_CR7_WUP14                                   \ WUP14 Wake-up Line Polarity 14 (PA2) This bit defines the polarity used for event detection on external wake-up line 14
$00000008 constant PWRC_CR7_WUP15                                   \ WUP15 Wake-up Line Polarity 15 (PA3) This bit defines the polarity used for event detection on external wake-up line 15
$00000010 constant PWRC_CR7_WUP16                                   \ WUP16 Wake-up Line Polarity 16 (PB12) This bit defines the polarity used for event detection on external wake-up line 16
$00000020 constant PWRC_CR7_WUP17                                   \ WUP17 Wake-up Line Polarity 17 (PB13) This bit defines the polarity used for event detection on external wake-up line 17
$00000040 constant PWRC_CR7_WUP18                                   \ WUP18 Wake-up Line Polarity 18 (PB14) This bit defines the polarity used for event detection on external wake-up line 18
$00000080 constant PWRC_CR7_WUP19                                   \ WUP19 Wake-up Line Polarity 19 (PB15) This bit defines the polarity used for event detection on external wake-up line 19


\
\ @brief SR3 register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant PWRC_SR3_WUF12                                   \ WUF12 WakeUp Flag 12 PA0 This bit is set when a wakeup is detected on wakeup line 12. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
$00000002 constant PWRC_SR3_WUF13                                   \ WUF13 WakeUp Flag 13 PA1 This bit is set when a wakeup is detected on wakeup line 13. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
$00000004 constant PWRC_SR3_WUF14                                   \ WUF14 WakeUp Flag 14 PA2 This bit is set when a wakeup is detected on wakeup line 14. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
$00000008 constant PWRC_SR3_WUF15                                   \ WUF15 WakeUp Flag 15 PA3 This bit is set when a wakeup is detected on wakeup line 15. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
$00000010 constant PWRC_SR3_WUF16                                   \ WUF16 WakeUp Flag 16 PB12 This bit is set when a wakeup is detected on wakeup line 16. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
$00000020 constant PWRC_SR3_WUF17                                   \ WUF17 WakeUp Flag 17 PB13 This bit is set when a wakeup is detected on wakeup line 17. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
$00000040 constant PWRC_SR3_WUF18                                   \ WUF18 WakeUp Flag 18 PB14 This bit is set when a wakeup is detected on wakeup line 18. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
$00000080 constant PWRC_SR3_WUF19                                   \ WUF19 WakeUp Flag 19 PB15 This bit is set when a wakeup is detected on wakeup line 19. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:


\
\ @brief DBGR register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant PWRC_DBGR_DEEPSTOP2                              \ DEEPSTOP2: DEEPSTOP2 low power saving emulation enable. 0: normal DEEPSTOP will be applied 1: DEEPSTOP2 (debugger features not lost) will be applied instead of DEEPSTOP.
$0000e000 constant PWRC_DBGR_DIS_PRECH                              \ DIS_PRECH[2:0]: disable precharge during deepstop (debug) 111: precharge and SMPS monitoring are disabled (whatever CR5.SMPSLPOPEN) 101: precharge are activated only at deepstop exit (to be used only with CR5.SMPSLPOPEN=1) else: No effect (default 0x0)


\
\ @brief EXTSRR register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000200 constant PWRC_EXTSRR_DEEPSTOPF                            \ DEEPSTOPF System DeepStop Flag This bit is set by hardware and cleared only by a POR reset or by writing '1' in this bit field
$00000400 constant PWRC_EXTSRR_RFPHASEF                             \ RFPHASEF RFPHASE Flag This bit is set by hardware after a Radio wake-up event (BLE activation); it is cleared either by software, writing '1' in this bit field, or by hardware when Ready2Sleep signal is asserted by the Radio IP.


\
\ @brief CR1 register
\
$48500000 constant PWRC_CR1       \ offset: 0x00 : CR1 register
$48500004 constant PWRC_CR2       \ offset: 0x04 : CR2 register
$48500008 constant PWRC_CR3       \ offset: 0x08 : CR3 register
$4850000c constant PWRC_CR4       \ offset: 0x0C : CR4 register
$48500010 constant PWRC_SR1       \ offset: 0x10 : SR1 register
$48500014 constant PWRC_SR2       \ offset: 0x14 : SR2 register
$4850001c constant PWRC_CR5       \ offset: 0x1C : CR5 register
$48500020 constant PWRC_PUCRA     \ offset: 0x20 : PUCRA register
$48500024 constant PWRC_PDCRA     \ offset: 0x24 : PDCRA register
$48500028 constant PWRC_PUCRB     \ offset: 0x28 : PUCRB register
$4850002c constant PWRC_PDCRB     \ offset: 0x2C : PDCRB register
$48500030 constant PWRC_CR6       \ offset: 0x30 : CR6 register
$48500034 constant PWRC_CR7       \ offset: 0x34 : CR7 register
$48500038 constant PWRC_SR3       \ offset: 0x38 : SR3 register
$48500084 constant PWRC_DBGR      \ offset: 0x84 : DBGR register
$48500088 constant PWRC_EXTSRR    \ offset: 0x88 : EXTSRR register

