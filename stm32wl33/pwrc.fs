\
\ @file pwrc.fs
\ @brief PVD / BORH
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

$00000001 constant PWRC_CR1_LPMS                                    \ LPMS Low Power Mode Selection Selection of the low power mode entered when CPU enters DEEP SLEEP mode and BLE is rdy2sleep. - 0: Deep Stop mode (default) - 1: Shutdown mode
$00000002 constant PWRC_CR1_ENSDNBOR                                \ ENSDNBOR: Enable BOR supply monitoring during shutdown mode. - 1: the PD_ALL_SHUTDOWN signal is not set during SHUTDOWN mode - 0: the PD_ALL_SHUTDOWN signal is set during SHUTDOWN mode.
$00000004 constant PWRC_CR1_IBIAS_RUN_AUTO                          \ IBIAS_RUN_AUTO: Enable automatic IBIAS control during RUN/DEEPSTOP mode. - 0: IBIAS control is manual (and controlled by IBIAS_RUN_STATE register) - 1: IBIAS control is automatic (default).
$00000008 constant PWRC_CR1_IBIAS_RUN_STATE                         \ IBIAS_RUN_STATE: Enable/Disable IBIAS during RUN mode when automatic mode is disabled. - 0: IBIAS control is disabled (default). - 1: IBIAS control is enabled.
$00000010 constant PWRC_CR1_APC                                     \ APC Apply Pull-up and pull-down configuration from CPU - 1: the I/O pull-up and pull-down configurations defined in the PUCRx and PDCRx registers is applied. - 0: the PUCRx and PDCRx are not used to control the I/O pull-up and pull-down configuration of the product I/Os.
$00000020 constant PWRC_CR1_ENBORH                                  \ ENBORH: enable BORH configuration - 1: BORH is enabled, threshold level depends on SELBOR[1:0] - 0: BORH off (VBOR0): threshold level for above 1.60V voltage operation.
$000000c0 constant PWRC_CR1_SELBORH                                 \ SELBORH[1:0]: BORH selection of Vbor threshold - 11: BORH Level 4(VBOR4): threshold level for above 2.81 V voltage operation. - 10: BORH Level 3 (VBOR3): threshold level for above 2.52 V voltage operation - 01: BORH Level 2 (VBOR2): threshold level for above 2.21 V voltage operation - 00: BORH Level 1 (VBOR1): threshold level for above 2.0V voltage operation.
$00000100 constant PWRC_CR1_ENBORL                                  \ ENBORL: Enable BORL reset supervising during RUN mode. - 0: No BORL is monitored during RUN mode. - 1: BORL is monitored during RUN mode (a POR reset will happen if VDDIO goes below 1.6V during RUN mode) (default). Note: Enabling this feature prevents blocking the device if VDDIO goes below supported voltages during RUN.


\
\ @brief CR2 register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant PWRC_CR2_PVDE                                    \ PVDE Programmable Voltage Detector Enable When this bit is set the Power Voltage Detector is enabled
$0000000e constant PWRC_CR2_PVDLS                                   \ PVDLS[2:0] Programmable Voltage Detector Level selection - 000: 2.05 V - Lowest level - 001: 2.20 V - 010: 2.36 V - 011: 2.52 V - 100: 2.64 V - 101: 2.81 V - 110: 2.91 V - Highest level - 111: External input analog voltage (compare internally to VBGP; When external input VBGP then PVDO=1)
$00000010 constant PWRC_CR2_DBGRET                                  \ DBGRET: PA2 and PA3 retention enable after DEEPSTOP - 0: PA2, PA3 don't retain their status exiting from DEEPSTOP (default). - 1: PA2, PA3 retain their status exiting from DEEPSTOP.
$00000020 constant PWRC_CR2_RAMRET1                                 \ RAMRET1: RAM1 retention during low power mode - 1: RAM1 bank is powered during low power mode - 0: RAM1 bank is disabled during low power mode (by default)
$00000040 constant PWRC_CR2_LPREG_FORCE_VH                          \ force LPREG=1.2V during DEEPSTOP - 1: Force LPREG=1.2V during DEEPSTOP - 0: No Force (Default) Note LPREG= 1.2v can still apply when LCDEN or COMP.SCALEREN request it
$00000080 constant PWRC_CR2_LPREG_VH_STATUS                         \ status LPREG VH (1.2v) during DEEPSTOP - 1: LPREG=1.2V during DEEPSTOP - 0: LPREG=1V during DEEPSTOP
$00000100 constant PWRC_CR2_GPIORET                                 \ GPIORET: GPIO retention enable. - 0: Release GPIO retention after deepstop (Should be reset after restore Context) - 1: Enable GPIO Retention during deepstop (Must be set before deepstop)
$00000200 constant PWRC_CR2_ENTS                                    \ ENTS: Enable Temperature Sensor - 1: Temperature sensor is enabled - 0: Temperature sensor is disabled
$00000400 constant PWRC_CR2_RFREGEN                                 \ RFREGEN: RF Regulator Enable - 1: Enable RF Regulator - 0: Disable RF Regulator (Note: RF Regulator can still be enabled by the RFSUGB or RCC_CR.HSEON)
$00000800 constant PWRC_CR2_RFREGCEXT                               \ RFREGCEXT: RF Regulator External Supply Bypass - 1: External supply bypass capability - 0: Internal supply only
$00001000 constant PWRC_CR2_RFREGBYP                                \ RFREGBYP: RF Regulator Bypass Enable - 1: LDO output connected to VSMPS. - 0: internally generated 1.2V
$00002000 constant PWRC_CR2_RFREGRDY                                \ RFDREGRDY: RF Regulator Ready flag - 1: RF Regulator is ready - 0: RF Regulator is not ready
$00004000 constant PWRC_CR2_RFREGON_STATUS                          \ RFREGON_STATUS: RF Regulator On Status - 1: RF Regulator is enabled - 0: RF Regulator is disabled


\
\ @brief IEWU register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant PWRC_IEWU_EIWL0                                  \ EWL0 Enable Internal WakeUp line LPUART When this bit is set the internal wakeup line is enabled and a rising edge will trigger a CPU wakeup event. - 0: wakeup disabled. - 1: wakeup enabled.
$00000002 constant PWRC_IEWU_EIWL1                                  \ EIWL1 Enable Internal WakeUp line RTC When this bit is set the internal wakeup line is enabled and a rising edge will trigger a CPU wakeup event. - 0: wakeup disabled. - 1: wakeup enabled.
$00000004 constant PWRC_IEWU_EIWL2                                  \ EIWL2 Enable Internal WakeUp line LCD When this bit is set the internal wakeup line is enabled and a rising edge will trigger a CPU wakeup event. - 0: wakeup disabled. - 1: wakeup enabled.
$00000008 constant PWRC_IEWU_EIWL3                                  \ EIWL3 Enable Internal Wakeup line COMP When this bit is set the COMP wakeup is enabled and an edge will trigger a COMP wakeup event - 0: wakeup disabled. - 1: wakeup enabled.
$00000010 constant PWRC_IEWU_EIWL4                                  \ EIWL4 Enable Internal Wakeup line LCSC When this bit is set the LCSC wakeup is enabled and an edge will trigger a LCSC wakeup event - 0: wakeup disabled. - 1: wakeup enabled.
$00000100 constant PWRC_IEWU_EWMRSUBG                               \ EWMRSUB Wakeup MRSUBG Enable When this bit is set the MRSUBG wakeup is enabled and a rising edge will trigger a MRSUBG wakeup event - 0: MRSUBG wakeup disabled. - 1: MRSUBG wakeup enabled.
$00000200 constant PWRC_IEWU_EWMRSUBGHCPU                           \ EWMRSUBGHCPU Wakeup MRSUBG Host CPU Enable When this bit is set the MRSUBG HOST CPU wakeup is enabled and a rising edge will trigger a MRSUBG Host CPU wakeup event - 0: MRSUBG Host CPU wakeup disabled. - 1: MRSUBG Host CPU wakeup enabled.
$00000400 constant PWRC_IEWU_EWLPAWUR                               \ EWLPAWUR: Wakeup Bubble Enable When this bit is set the Bubble wakeup is enabled and a rising edge will trigger a LPAWUR wakeup event - 0: LPAWUR wakeup disabled. - 1: LPAWUR wakeup enabled.


\
\ @brief IWUP register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant PWRC_IWUP_IWUP0                                  \ IWUP0: Wakeup polarity for internal wakeup line 0 event (LPUART). - 0: Detection of wakeup event on rising edge (default). - 1: Detection of wakeup event on falling edge.
$00000002 constant PWRC_IWUP_IWUP1                                  \ IWUP1: Wakeup polarity for internal wakeup line 1 event (RTC). - 0: Detection of wakeup event on rising edge (default). - 1: Detection of wakeup event on falling edge.
$00000004 constant PWRC_IWUP_IWUP2                                  \ IWUP2: Wakeup polarity for internal wakeup line 2 event (LCD). - 0: Detection of wakeup event on rising edge (default). - 1: Detection of wakeup event on falling edge.
$00000008 constant PWRC_IWUP_IWUP3                                  \ IWUP3: Wakeup polarity for internal wakeup line 3 event (COMP). - 0: Detection of wakeup event on rising edge (default). - 1: Detection of wakeup event on falling edge.
$00000010 constant PWRC_IWUP_IWUP4                                  \ IWUP4: Wakeup polarity for internal wakeup line 4 event (LCSC). - 0: Detection of wakeup event on rising edge (default). - 1: Detection of wakeup event on falling edge.
$00000100 constant PWRC_IWUP_WMRSUBGHP                              \ WMRSUBGHP: Wakeup polarity for internal wakeup MRSUBG event - 0: Detection of wakeup event on rising edge (default). - 1: Detection of wakeup event on falling edge.
$00000200 constant PWRC_IWUP_WMRSUBGHCPUP                           \ WMRSUBGHCPUP: Wakeup polarity for internal wakeup MRSUBG Host CPU event - 0: Detection of wakeup event on rising edge (default). - 1: Detection of wakeup event on falling edge.
$00000400 constant PWRC_IWUP_WLPAWURP                               \ WLPAWURP: Wakeup polarity for wakeup LPAWUR event. - 0: Detection of wakeup event on rising edge (default). - 1: Detection of wakeup event on falling edge.


\
\ @brief IWUF register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant PWRC_IWUF_IWUF0                                  \ IWUF0: Internal wakeup flag (LPUART). - 0: no wakeup from LPUART occurred since last clear. - 1: a wakeup from LPUART occurred since last clear. Cleared by writing 1 in this bit.
$00000002 constant PWRC_IWUF_IWUF1                                  \ IWUF1: Internal wakeup flag (RTC). - 0: no wakeup from RTC occurred since last clear. - 1: a wakeup from RTC occurred
$00000004 constant PWRC_IWUF_IWUF2                                  \ IWUF2: Internal wakeup flag (LCD). - 0: no wakeup from LCD occurred since last clear. - 1: a wakeup from LCD occurred since last clear. Cleared by writing 1 in this bit.
$00000008 constant PWRC_IWUF_IWUF3                                  \ IWUF3: Internal wakeup flag (COMP). - 0: no wakeup from COMP occurred since last clear. - 1: a wakeup from COMP occurred since last clear. Cleared by writing 1 in this bit.
$00000010 constant PWRC_IWUF_IWUF4                                  \ IWUF4: Internal wakeup flag (LCSC). - 0: no wakeup from LCSC occurred since last clear. - 1: a wakeup from LCSC occurred since last clear. Cleared by writing 1 in this bit.
$00000100 constant PWRC_IWUF_WMRSUBGF                               \ WMRSUBGF Wakeup MRSUBG Flag This bit is set by hardware when a MRSUBG wakeup is detected It is cleared by a reset pad or by software writing 1 in this bit field. - 0: No MRSUBG Wakeup detected - 1: MRSUBG Wakeup detected writting 1 in this bit, clears the interrupt
$00000200 constant PWRC_IWUF_WMRSUBGHCPUF                           \ WMRSUBGHCPUF Wakeup MRSUBG HOST CPU Flag (cf. user manual) This bit is set by hardware when a MRSUBG HOST CPU wakeup is detected It is cleared by a reset pad or by software writing 1 in this bit field. - 0: No MRSUBG Host CPU wakeup detected - 1: MRSUBG Host CPU wakeup detected writting 1 in this bit, clears the interrupt
$00000400 constant PWRC_IWUF_WLPAWURF                               \ WLPAWURF Wakeup LPAWUR Flag (cf. user manual) This bit is set by hardware when a LPAWUR wakeup is detected It is cleared by a reset pad or by software writing 1 in this bit field. - 0: No LPAWUR wakeup detected - 1: LPAWUR wakeup detected writting 1 in this bit, clears the interrupt


\
\ @brief SR2 register
\ Address offset: 0x14
\ Reset value: 0x0000F3F6
\

$00000001 constant PWRC_SR2_SMPSBYPR                                \ SMPSBYPR: SMPS Force Bypass Control Replica This bit mirrors the actual BYPASS_3V3 control signal driven to the SMPS regulator, dependant on the real working state.
$00000002 constant PWRC_SR2_SMPSENR                                 \ SMPSENR: SMPS Enable Control Replica This bit mirrors the actual ENABLE_3V3 control signal driven to the SMPS regulator, dependant on the real working state.
$00000004 constant PWRC_SR2_SMPSRDY                                 \ SMPSRDY: SMPS Ready Status This bit provides the information whether SMPS is ready. - 0: SMPS regulator is not ready - 1: SMPS regulator is ready.
$000000f0 constant PWRC_SR2_IOBOOTVAL2                              \ Bit3: PB15 input value on VDD33 latched at POR Bit2: PB14 input value on VDD33 latched at POR Bit1: PB13 input value on VDD33 latched at POR Bit0: PB12 input value on VDD33 latched at POR
$00000100 constant PWRC_SR2_REGLPS                                  \ REGLPS: Regulator Low Power Started This bit provides the information whether low power regulator is ready. - 0: LP regulator is not ready. - 1: LP regulator is ready.
$00000200 constant PWRC_SR2_REGMS                                   \ REGMS: Main regulator ready status. - 0: The Main regulator is not ready. - 1: The Main regulator is ready.
$00000800 constant PWRC_SR2_PVDO                                    \ PVDO: Power Voltage Detector Output When the Power Voltage Detector is enabled (CR2.PVDE) this bit is set when the system supply (VDDIO) is lower than the selected PVD threshold (CR2.PVDLS)
$0000f000 constant PWRC_SR2_IOBOOTVAL                               \ Bit3: PA11 input value on VDD33 latched at POR Bit2: PA10 input value on VDD33 latched at POR Bit1: PA9 input value on VDD33 latched at POR Bit0: PA8 input value on VDD33 latched at POR


\
\ @brief CR5 register
\ Address offset: 0x1C
\ Reset value: 0x00006014
\

$0000000f constant PWRC_CR5_SMPSLVL                                 \ SMPSLVL[3:0] SMPS Output Level Voltage Selection Select the SMPS output voltage with a granularity of 50mV. Default = '0100' (1.4V) Vout = 1.2 + 0.05*SMPSOUT (V)
$00000030 constant PWRC_CR5_SMPSBOMSEL                              \ SMPSBOMSEL: SMPS BOM Selection: - 00: BOM1 - 01: BOM2 (default) - 10: BOM3 - 11: n/a
$00000040 constant PWRC_CR5_SMPS_BOF_STATIC                         \ SMPS_BOF_STATIC: SMPS Bypass on the Fly static - 0 : disabled (by default) - 1 : SMPS Bypass on the fly static is enabled (EN_SW=1)
$00000080 constant PWRC_CR5_NOSMPS_BOF                              \ NOSMPS_BOF: No SMPS Mode to be used in accordance to SMPS_BOF_STATIC =1 When this bit is set, the SMPS regulator will be disabled. Note that this configuration should be used only SMPS_BOF_STATIC=1. - 0 : No effect, SMPS is enabled. (default) - 1 : SMPS is disabled;
$00000100 constant PWRC_CR5_SMPSLPOPEN                              \ SMPSLPOPEN: In Low Power mode SMPS is in OPEN mode (instead of PRECHARGE mode). When this bit is set, when the chip is in Low power mode the SMPS regulator will be disabled (HZ) Documentation needed. - 0 : in Low Power mode, SMPS is in PRECHARGE, output is connected to VDDIO. (default) - 1 : in Low Power mode, SMPS is disabled, output is floating
$00000200 constant PWRC_CR5_SMPSFBYP                                \ SMPSFB Force SMPS Regulator in bypass mode When this bit is set, the SMPS regulator will be forced to operate in precharge mode. the actual state of SMPS can be observed thanks to the replica SR2.SMPSBYPR. - 0 : no effect (by default) - 1 : SMPS is disabled and bypassed (ENABLE_3V3=0 and PRECHARGE_3V3=1)
$00000400 constant PWRC_CR5_NOSMPS                                  \ NOSMPS: No SMPS Mode When this bit is set, the SMPS regulator will be disabled. Note that this configuration should be used only when SMPS_FB pad is directly connected to VBATT or Vext, without L/C BOM. - 0 : No effect, SMPS is enabled. (Default) - 1 : SMPS is disabled;
$00000800 constant PWRC_CR5_SMPS_ENA_DCM                            \ SMPS_ENA_DCM: enable discontinuous conduction mode - 0 : disable (Default) - 1 : enable
$00001000 constant PWRC_CR5_CLKDETR_DISABLE                         \ CLKDETR_DISABLE: disable SMPS clock detection The SMPS clock detection enables an automatic SMPS bypass switching in case of unwanted loss of SMPS clock. - 0 : SMPS clock detection enabled (default) - 1 : SMPS clock detection disabled
$00006000 constant PWRC_CR5_SMPS_PRECH_CUR_SEL                      \ SMPS_PRECH_CUR_SEL[1:0] Selection for SMPS PRECHARGE limit current - 00: 2.5mA - 01: 5mA - 10: 10mA - 11: 20mA (default)
$00008000 constant PWRC_CR5_SMPS_BOF_DYN                            \ SMPS_BOF_DYN: SMPS Bypass on the Fly dynamic - 0 : disabled (by default) - 1 : SMPS Bypass on the fly dynamic is enabled (EN_LDO=1)


\
\ @brief PUCRA register
\ Address offset: 0x20
\ Reset value: 0x0000FFF7
\

$0000ffff constant PWRC_PUCRA_PUA                                   \ PUA[x] : Pull Up Port A Pull up activation on port A[i] pad when APC bit of PWRC CR1 is set - 1: Pull-Up activated on port A[i] when APC bit of PWRC CR1 bit is set and PWR_PDCRA[x] is reset - 0: Pull-Up not activated on port A[i]


\
\ @brief PDCRA register
\ Address offset: 0x24
\ Reset value: 0x00000008
\

$0000ffff constant PWRC_PDCRA_PDA                                   \ PDA[x]: Pull Down Port A Pull Down activation on port A[i] pad when APC bit of PWRC CR1 is set - 1: Pull-Down activated on Port A[i] when APC bit of PWRC CR1 bit is set - 0: Pull-Down not activated on Port A[i]


\
\ @brief PUCRB register
\ Address offset: 0x28
\ Reset value: 0x0000FFFF
\

$0000ffff constant PWRC_PUCRB_PUB                                   \ PUB[x] : Pull Up Port B Pull up activation on port B[i] pad when APC bit of PWRC CR1 is set - 1: Pull-Up activated on port B[i] when APC bit of PWRC CR1 bit is set and PWR_PDCRB[x] is reset - 0: Pull-Up not activated on port B[i]


\
\ @brief PDCRB register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant PWRC_PDCRB_PDB                                   \ PDB[x]: Pull Down Port B Pull Down activation on port B[i] pad when APC bit of PWRC CR1 is set - 1: Pull-Down activated on Port B[i] when APC bit of PWRC CR1 bit is set - 0: Pull-Down not activated on Port B[i]


\
\ @brief EWUA register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant PWRC_EWUA_EWUA                                   \ EWUA[x] Enable WakeUp line PA[x] When this bit is set the PA[x] wakeup line is enabled and a rising or falling edge on wakeup line PA[x] will trigger a CPU wakeup event depending on CR7.WUPA[x] bit.


\
\ @brief WUPA register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant PWRC_WUPA_WUPA                                   \ WUPA[x] Wake-up Line PA[x] Polarity This bit defines the polarity used for event detection on external wake-up line PA[x] - 0: Detection on high level (rising edge) - 1: Detection on low level (falling edge)


\
\ @brief WUFA register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant PWRC_WUFA_WUFA                                   \ WUFA[x] WakeUp Flag PA[x] This bit is set when a wakeup is detected on wakeup line PA[x]. It is cleared by a reset pad or by writing 1 in this bit field. Writing 1 this bit, clears the interrupt:


\
\ @brief EWUB register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant PWRC_EWUB_EWUB                                   \ EWUB[x] Enable WakeUp line PB[x] When this bit is set the PB[x] wakeup line is enabled and a rising or falling edge on wakeup line PB[x] will trigger a CPU wakeup event depending on CR9.WUPB[x] bit.


\
\ @brief WUPB register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000ffff constant PWRC_WUPB_WUPB                                   \ WUPB[x] Wake-up Line PB[x] Polarity This bit defines the polarity used for event detection on external wake-up line PB[x] - 0: Detection on high level (rising edge) - 1: Detection on low level (falling edge)


\
\ @brief WUFB register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000ffff constant PWRC_WUFB_WUFB                                   \ WUFB[x] WakeUp Flag PB[x] This bit is set when a wakeup is detected on wakeup line PB[x]. It is cleared by a reset pad or by writing 1 in this bit field. Writing 1 this bit, clears the interrupt:


\
\ @brief SDWN_WUEN register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant PWRC_SDWN_WUEN_WUEN                              \ WUEN PB0 I/O WakeUp from shutdown Enable When this bit is set the PB0 wakeup from shutdown is enabled so that a rising or falling edge on PB0 (depending on SDWN_WUPOL..WUPOL bit) will trigger a CPU wakeup. It is cleared by a PORESETn. - 0: PB0 wakeup from shutdown disabled - 1: PB0 wakeup from shutdown enabled


\
\ @brief SDWN_WUPOL register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant PWRC_SDWN_WUPOL_WUPOL                            \ WUPOL PB0 I/O WakeUp from shutdown Polarity This bit defines the polarity used for wakeup from shutdown detection on PB0 pin. It is cleared by a PORESETn. - 0: Detection on high level (rising edge) - 1: Detection on low level (falling edge)


\
\ @brief SDWN_WUF register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant PWRC_SDWN_WUF_WUF                                \ WUF PB0 I/O WakeUp from shutdown Flag This bit is set when a wakeup from shutdown is detected on PB0 pin. It is cleared by a PORESETn or by writing 0 in this bit field. - 0: Shutdown wakeup from PB0 not occurred - 1: Shutdown wakeup from PB0 occurred


\
\ @brief BOF_TUNE register
\ Address offset: 0x58
\ Reset value: 0x00000004
\

$0000000f constant PWRC_BOF_TUNE_BOF_TUNE                           \ BOF_TUNE: selection of the Bypass on the Fly LDO output voltage. - 0: 1.2V - 1: 1.2V - 2: 1.2V - 3: 1.3V - 4: 1.4V (Default) - 5: 1.5V - 6: 1.6V - 7: 1.7V - 8: 1.8V - 9: 1.9V - 10: 2V - 11: 2.1V - 12: 2.2V - 13: 2.3V - 14: 2.4V - 15: 2.4V


\
\ @brief DBGR register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant PWRC_DBGR_DEEPSTOP2                              \ DEEPSTOP2 low power saving mode emulation enable this bit enable an emulated debug DEEPSTOP low power mode. If emulation is enabled, entering in DEEPSTOP mode, the v12i power domain still enters power saving mode, but its clock and power are maintained.
$00000080 constant PWRC_DBGR_SMPSFRDY                               \ SMPSFB Force ready check When this bit is set, the SMPS regulator will be forced to operate in precharge mode. the actual state of SMPS can be observed thanks to the replica SR2.SMPSBYPR. - 0 : no effect (by default) - 1 : SMPS is disabled and bypassed (ENABLE_3V3=0 and PRECHARGE_3V3=1)
$00000700 constant PWRC_DBGR_KELVIN_TEST                            \ KELVIN_TEST[2:0]: Enable TEST mode Kelvin for LDO_RF (Write protected by IFR3 key) - 000: 0mA (open) (default 0x0) - 001 for 1mA - 010 for 3mA - 011 for 5mA - 100 for 8mA - 101 for 10mA else: 0mA (open) for other combinations.
$0000e000 constant PWRC_DBGR_DIS_PRECH                              \ DIS_PRECH[2:0]: disable precharge during deepstop (debug) allowed combination are: - 111: precharge and SMPS monitoring are disabled (whatever CR5.SMPSLPOPEN) - 101: precharge are activated only at deepstop exit (to be used only with CR5.SMPSLPOPEN=1) else: No effect (default 0x0)


\
\ @brief EXTSRR register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000200 constant PWRC_EXTSRR_DEEPSTOPF                            \ DEEPSTOPF System DeepStop Flag This bit is set by hardware and cleared only by a POR reset or by writing '1' in this bit field - 0: System has not been in DEEPSTOP mode - 1: System has been in DEEPSTOP mode
$00000400 constant PWRC_EXTSRR_RFPHASEF                             \ RFPHASEF RFPHASE Flag This bit is set by hardware after a S3LP wake-up event (S3LP activation); it is cleared either by software, writing '1' in this bit field, or by hardware when Ready2Sleep signal is asserted by the Radio IP. - 0: RF IP does not require attention - 1: RF IP awake and requesting system attention


\
\ @brief DBGSMPS register
\ Address offset: 0x8C
\ Reset value: 0x00008000
\

$0000000f constant PWRC_DBGSMPS_TESTDIG                             \ TESTDIG: SMPS TEST_DIG_3V3[3:0] SMPS control signal
$00000030 constant PWRC_DBGSMPS_TESTKEL                             \ TESTKEL: SMPS TEST_KEL_3V3[1:0] SMPS control signal
$00000040 constant PWRC_DBGSMPS_HOT_STUP                            \ HOT_STUP_3V3 SMPS control signal
$00000080 constant PWRC_DBGSMPS_NO_STUP                             \ NO_STUP_3V3 SMPS control signal
$00000100 constant PWRC_DBGSMPS_TESTILIM                            \ TESTILIM: SMPS TEST_ILIM_3V3 SMPS control signal
$00000200 constant PWRC_DBGSMPS_CTLRES_RAMP                         \ CTLRES_RAM_3V3 SMPS control signal
$00000400 constant PWRC_DBGSMPS_DIS_BIG_MOS                         \ DIS_BIG_MOS_3V3 SMPS control signal
$00000800 constant PWRC_DBGSMPS_TEST_OL                             \ TEST_OL_3V3 SMPS control signal
$00001000 constant PWRC_DBGSMPS_DIS_ILIM                            \ DIS_ILIM_3V3 SMPS control signal
$00002000 constant PWRC_DBGSMPS_ILIM_BOOST                          \ ILIM_BOOST_3V3 SMPS current limitation Boost - 0: Max current = 110mA (Default) - 1: Max current = 130mA
$0000c000 constant PWRC_DBGSMPS_BOF_CUR_SEL                         \ BOF_CUR_SEL Bypass On the Fly current limitation - 00 : 20mA - 01 : 40mA - 10 : 60mA (default) - 11 : no limit


\
\ @brief TRIMR register
\ Address offset: 0x90
\ Reset value: 0x00002304
\

$00000007 constant PWRC_TRIMR_RFD_REG_TRIM                          \ RFD_REG_TRIM[2:0]: RF LDO Trimming By default, this value is taken from the engi bytes; and saved on V12o domain when OBL done. if associated ENGTRIM is enabled the RF LDO trimming can be controlled by the dedicated ENGTRIM register. Default= '100'.
$00000008 constant PWRC_TRIMR_SPARE                             
$000000f0 constant PWRC_TRIMR_TRIM_MR                               \ TRIM_MR[3:0]: Main Regulator Voltage Trimming By default, this value is taken from the engi bytes; and saved on V12o domain when OBL done. if associated ENGTRIM.TRIMMREN is enabled the Main Regulator Voltage can be controlled by the dedicated ENGTRIM.TRIM_MR register. Default= '0000'.
$00000700 constant PWRC_TRIMR_SMPS_TRIM                             \ SMPS_TRIM[2:0]: SMPS Output Voltage Trimming By default, this value is taken from the engi bytes; and saved on V12o domain when OBL done. if associated ENGTRIM is enabled the SMPS output voltage can be controlled by the dedicated ENGTRIM register. Default= '011'.
$00003800 constant PWRC_TRIMR_BOF_TRIM                              \ BOF_TRIM[2:0]: Bypass On the Fly Output Voltage Trimming By default, this value is taken from the engi bytes; and saved on V12o domain when OBL done. if associated ENGTRIM is enabled the SMPS output voltage can be controlled by the dedicated ENGTRIM register. Default= '100'.


\
\ @brief ENGTRIM register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant PWRC_ENGTRIM_TRIMRFDREGEN                        \ TRIMRFDREGEN: trimming RFREG enabled - 1: trimming bit applied from ENGTRIM register - 0: trimming bit applied from OBL (can be read on TRIMR register)
$0000000e constant PWRC_ENGTRIM_TRIM_RFDREG                         \ TRIM_RFDREG: RF Regulator Trimming By default, this value is not applied, but taken from the engi bytes; if ENGTRIM.TRIMRFDREGEN=1, the startup current can be controlled by this register.
$00000010 constant PWRC_ENGTRIM_SPARE                           
$00000020 constant PWRC_ENGTRIM_TRIMMREN                            \ TRIMMREN: trimming MR enabled - 1: trimming bit applied from ENGTRIM register - 0: trimming bit applied from OBL (can be read on TRIMR register)
$000003c0 constant PWRC_ENGTRIM_TRIM_MR                             \ TRIM_MR: Main Regulator Output Voltage Trimming By default, this value is not applied, but taken from the engi bytes; if ENGTRIM.TRIMMREN=1, the startup current can be controlled by this register.
$00000400 constant PWRC_ENGTRIM_SMPSTRIMEN                          \ SMPSTRIMEN: trimming SMPS enabled - 1: trimming bit applied from ENGTRIM register - 0: trimming bit applied from OBL (can be read on TRIMR register)
$00003800 constant PWRC_ENGTRIM_SMPS_TRIM                           \ SMPS_TRIM: SMPS Output Voltage Trimming By default, this value is not applied, but taken from the engi bytes; if ENGTRIM.SMPSTRIMEN=1, the SMPS output voltage can be controlled by this register.


\
\ @brief DBG_STATUS_REG1 register
\ Address offset: 0x98
\ Reset value: 0x00000202
\

$00000007 constant PWRC_DBG_STATUS_REG1_SMPS_FSM_STATE              \ SMPS_FSM_STATE[2:0]: Indicates the current state of the SMPS FSM inside the PWRC.: - 000: STARTUP - 001: SMPS_REQ - 010: SMPS_RUN - 011: STOP - 100: NOSMPS - 101: PRECHARGE - 110: NOSMPS_BOF
$00000700 constant PWRC_DBG_STATUS_REG1_FLASH_FSM_STATE             \ FLASH_FSM_STATE[2:0]: Indicates the current state of the FLASH FSM inside the PWRC: - 000: STATE1: FLASH POR - 001: STATE2: FLASH PWRUP - 010: STATE3: FLASH READY - 101: STATE4: FLASH SWITCH OFF - 110: STATE5: FLASH PWR DOWN


\
\ @brief DBG_STATUS_REG2 register
\ Address offset: 0x9C
\ Reset value: 0x00000201
\

$0000000f constant PWRC_DBG_STATUS_REG2_PMU_FSM_STATE               \ PMU_FSM_STATE[3:0]: Indicates the current state of the PMU FSM inside the PWRC. - 0000: POR - 0001: RUN - 0010: DS ENTRY - 0011: WAIT1 - 0100: WAIT2 - 0101: WAIT - 0110: WAIT3 - 0111: WAIT4 - 1000: ISOLATION - 1001: DEEPSTOP - 1010: SHUTDOWN - 1011: DEEPSTOP EXIT
$00000300 constant PWRC_DBG_STATUS_REG2_RAM_FSM_STATE               \ RAM_FSM_STATE[1:0]: Indicates the current state of the RAM FSM inside the PWRC: - 00: POR - 01: POWER UP - 10: READY - 11: OFF


\
\ @brief ENGTRIM2 register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000001 constant PWRC_ENGTRIM2_BOFTRIMEN                          \ BOFTRIMEN: trimming BOF enabled - 1: trimming bit applied from ENGTRIM2 register - 0: trimming bit applied from OBL (can be read on TRIMR register)
$0000000e constant PWRC_ENGTRIM2_BOF_TRIM                           \ SMPS_TRIM: SMPS Output Voltage Trimming By default, this value is not applied, but taken from the engi bytes; if ENGTRIM.BOFTRIMEN=1, the SMPS output voltage can be controlled by this register.


\
\ @brief PVD / BORH
\
$48500000 constant PWRC_CR1       \ offset: 0x00 : CR1 register
$48500004 constant PWRC_CR2       \ offset: 0x04 : CR2 register
$48500008 constant PWRC_IEWU      \ offset: 0x08 : IEWU register
$4850000c constant PWRC_IWUP      \ offset: 0x0C : IWUP register
$48500010 constant PWRC_IWUF      \ offset: 0x10 : IWUF register
$48500014 constant PWRC_SR2       \ offset: 0x14 : SR2 register
$4850001c constant PWRC_CR5       \ offset: 0x1C : CR5 register
$48500020 constant PWRC_PUCRA     \ offset: 0x20 : PUCRA register
$48500024 constant PWRC_PDCRA     \ offset: 0x24 : PDCRA register
$48500028 constant PWRC_PUCRB     \ offset: 0x28 : PUCRB register
$4850002c constant PWRC_PDCRB     \ offset: 0x2C : PDCRB register
$48500030 constant PWRC_EWUA      \ offset: 0x30 : EWUA register
$48500034 constant PWRC_WUPA      \ offset: 0x34 : WUPA register
$48500038 constant PWRC_WUFA      \ offset: 0x38 : WUFA register
$48500040 constant PWRC_EWUB      \ offset: 0x40 : EWUB register
$48500044 constant PWRC_WUPB      \ offset: 0x44 : WUPB register
$48500048 constant PWRC_WUFB      \ offset: 0x48 : WUFB register
$4850004c constant PWRC_SDWN_WUEN  \ offset: 0x4C : SDWN_WUEN register
$48500050 constant PWRC_SDWN_WUPOL  \ offset: 0x50 : SDWN_WUPOL register
$48500054 constant PWRC_SDWN_WUF  \ offset: 0x54 : SDWN_WUF register
$48500058 constant PWRC_BOF_TUNE  \ offset: 0x58 : BOF_TUNE register
$48500084 constant PWRC_DBGR      \ offset: 0x84 : DBGR register
$48500088 constant PWRC_EXTSRR    \ offset: 0x88 : EXTSRR register
$4850008c constant PWRC_DBGSMPS   \ offset: 0x8C : DBGSMPS register
$48500090 constant PWRC_TRIMR     \ offset: 0x90 : TRIMR register
$48500094 constant PWRC_ENGTRIM   \ offset: 0x94 : ENGTRIM register
$48500098 constant PWRC_DBG_STATUS_REG1  \ offset: 0x98 : DBG_STATUS_REG1 register
$4850009c constant PWRC_DBG_STATUS_REG2  \ offset: 0x9C : DBG_STATUS_REG2 register
$485000a0 constant PWRC_ENGTRIM2  \ offset: 0xA0 : ENGTRIM2 register

