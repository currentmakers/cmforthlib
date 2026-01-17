\
\ @file pwrc.fs
\ @brief PVD / BORH
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] PWRC_DEF

  [ifdef] PWRC_CR1_DEF
    \
    \ @brief CR1 register
    \ Address offset: 0x00
    \ Reset value: 0x00000114
    \
    $00 constant PWRC_LPMS                      \ [0x00] LPMS Low Power Mode Selection Selection of the low power mode entered when CPU enters DEEP SLEEP mode and BLE is rdy2sleep. - 0: Deep Stop mode (default) - 1: Shutdown mode
    $01 constant PWRC_ENSDNBOR                  \ [0x01] ENSDNBOR: Enable BOR supply monitoring during shutdown mode. - 1: the PD_ALL_SHUTDOWN signal is not set during SHUTDOWN mode - 0: the PD_ALL_SHUTDOWN signal is set during SHUTDOWN mode.
    $02 constant PWRC_IBIAS_RUN_AUTO            \ [0x02] IBIAS_RUN_AUTO: Enable automatic IBIAS control during RUN/DEEPSTOP mode. - 0: IBIAS control is manual (and controlled by IBIAS_RUN_STATE register) - 1: IBIAS control is automatic (default).
    $03 constant PWRC_IBIAS_RUN_STATE           \ [0x03] IBIAS_RUN_STATE: Enable/Disable IBIAS during RUN mode when automatic mode is disabled. - 0: IBIAS control is disabled (default). - 1: IBIAS control is enabled.
    $04 constant PWRC_APC                       \ [0x04] APC Apply Pull-up and pull-down configuration from CPU - 1: the I/O pull-up and pull-down configurations defined in the PUCRx and PDCRx registers is applied. - 0: the PUCRx and PDCRx are not used to control the I/O pull-up and pull-down configuration of the product I/Os.
    $05 constant PWRC_ENBORH                    \ [0x05] ENBORH: enable BORH configuration - 1: BORH is enabled, threshold level depends on SELBOR[1:0] - 0: BORH off (VBOR0): threshold level for above 1.60V voltage operation.
    $06 constant PWRC_SELBORH                   \ [0x06 : 2] SELBORH[1:0]: BORH selection of Vbor threshold - 11: BORH Level 4(VBOR4): threshold level for above 2.81 V voltage operation. - 10: BORH Level 3 (VBOR3): threshold level for above 2.52 V voltage operation - 01: BORH Level 2 (VBOR2): threshold level for above 2.21 V voltage operation - 00: BORH Level 1 (VBOR1): threshold level for above 2.0V voltage operation.
    $08 constant PWRC_ENBORL                    \ [0x08] ENBORL: Enable BORL reset supervising during RUN mode. - 0: No BORL is monitored during RUN mode. - 1: BORL is monitored during RUN mode (a POR reset will happen if VDDIO goes below 1.6V during RUN mode) (default). Note: Enabling this feature prevents blocking the device if VDDIO goes below supported voltages during RUN.
  [then]


  [ifdef] PWRC_CR2_DEF
    \
    \ @brief CR2 register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_PVDE                      \ [0x00] PVDE Programmable Voltage Detector Enable When this bit is set the Power Voltage Detector is enabled
    $01 constant PWRC_PVDLS                     \ [0x01 : 3] PVDLS[2:0] Programmable Voltage Detector Level selection - 000: 2.05 V - Lowest level - 001: 2.20 V - 010: 2.36 V - 011: 2.52 V - 100: 2.64 V - 101: 2.81 V - 110: 2.91 V - Highest level - 111: External input analog voltage (compare internally to VBGP; When external input VBGP then PVDO=1)
    $04 constant PWRC_DBGRET                    \ [0x04] DBGRET: PA2 and PA3 retention enable after DEEPSTOP - 0: PA2, PA3 don't retain their status exiting from DEEPSTOP (default). - 1: PA2, PA3 retain their status exiting from DEEPSTOP.
    $05 constant PWRC_RAMRET1                   \ [0x05] RAMRET1: RAM1 retention during low power mode - 1: RAM1 bank is powered during low power mode - 0: RAM1 bank is disabled during low power mode (by default)
    $06 constant PWRC_LPREG_FORCE_VH            \ [0x06] force LPREG=1.2V during DEEPSTOP - 1: Force LPREG=1.2V during DEEPSTOP - 0: No Force (Default) Note LPREG= 1.2v can still apply when LCDEN or COMP.SCALEREN request it
    $07 constant PWRC_LPREG_VH_STATUS           \ [0x07] status LPREG VH (1.2v) during DEEPSTOP - 1: LPREG=1.2V during DEEPSTOP - 0: LPREG=1V during DEEPSTOP
    $08 constant PWRC_GPIORET                   \ [0x08] GPIORET: GPIO retention enable. - 0: Release GPIO retention after deepstop (Should be reset after restore Context) - 1: Enable GPIO Retention during deepstop (Must be set before deepstop)
    $09 constant PWRC_ENTS                      \ [0x09] ENTS: Enable Temperature Sensor - 1: Temperature sensor is enabled - 0: Temperature sensor is disabled
    $0a constant PWRC_RFREGEN                   \ [0x0a] RFREGEN: RF Regulator Enable - 1: Enable RF Regulator - 0: Disable RF Regulator (Note: RF Regulator can still be enabled by the RFSUGB or RCC_CR.HSEON)
    $0b constant PWRC_RFREGCEXT                 \ [0x0b] RFREGCEXT: RF Regulator External Supply Bypass - 1: External supply bypass capability - 0: Internal supply only
    $0c constant PWRC_RFREGBYP                  \ [0x0c] RFREGBYP: RF Regulator Bypass Enable - 1: LDO output connected to VSMPS. - 0: internally generated 1.2V
    $0d constant PWRC_RFREGRDY                  \ [0x0d] RFDREGRDY: RF Regulator Ready flag - 1: RF Regulator is ready - 0: RF Regulator is not ready
    $0e constant PWRC_RFREGON_STATUS            \ [0x0e] RFREGON_STATUS: RF Regulator On Status - 1: RF Regulator is enabled - 0: RF Regulator is disabled
  [then]


  [ifdef] PWRC_IEWU_DEF
    \
    \ @brief IEWU register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_EIWL0                     \ [0x00] EWL0 Enable Internal WakeUp line LPUART When this bit is set the internal wakeup line is enabled and a rising edge will trigger a CPU wakeup event. - 0: wakeup disabled. - 1: wakeup enabled.
    $01 constant PWRC_EIWL1                     \ [0x01] EIWL1 Enable Internal WakeUp line RTC When this bit is set the internal wakeup line is enabled and a rising edge will trigger a CPU wakeup event. - 0: wakeup disabled. - 1: wakeup enabled.
    $02 constant PWRC_EIWL2                     \ [0x02] EIWL2 Enable Internal WakeUp line LCD When this bit is set the internal wakeup line is enabled and a rising edge will trigger a CPU wakeup event. - 0: wakeup disabled. - 1: wakeup enabled.
    $03 constant PWRC_EIWL3                     \ [0x03] EIWL3 Enable Internal Wakeup line COMP When this bit is set the COMP wakeup is enabled and an edge will trigger a COMP wakeup event - 0: wakeup disabled. - 1: wakeup enabled.
    $04 constant PWRC_EIWL4                     \ [0x04] EIWL4 Enable Internal Wakeup line LCSC When this bit is set the LCSC wakeup is enabled and an edge will trigger a LCSC wakeup event - 0: wakeup disabled. - 1: wakeup enabled.
    $08 constant PWRC_EWMRSUBG                  \ [0x08] EWMRSUB Wakeup MRSUBG Enable When this bit is set the MRSUBG wakeup is enabled and a rising edge will trigger a MRSUBG wakeup event - 0: MRSUBG wakeup disabled. - 1: MRSUBG wakeup enabled.
    $09 constant PWRC_EWMRSUBGHCPU              \ [0x09] EWMRSUBGHCPU Wakeup MRSUBG Host CPU Enable When this bit is set the MRSUBG HOST CPU wakeup is enabled and a rising edge will trigger a MRSUBG Host CPU wakeup event - 0: MRSUBG Host CPU wakeup disabled. - 1: MRSUBG Host CPU wakeup enabled.
    $0a constant PWRC_EWLPAWUR                  \ [0x0a] EWLPAWUR: Wakeup Bubble Enable When this bit is set the Bubble wakeup is enabled and a rising edge will trigger a LPAWUR wakeup event - 0: LPAWUR wakeup disabled. - 1: LPAWUR wakeup enabled.
  [then]


  [ifdef] PWRC_IWUP_DEF
    \
    \ @brief IWUP register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_IWUP0                     \ [0x00] IWUP0: Wakeup polarity for internal wakeup line 0 event (LPUART). - 0: Detection of wakeup event on rising edge (default). - 1: Detection of wakeup event on falling edge.
    $01 constant PWRC_IWUP1                     \ [0x01] IWUP1: Wakeup polarity for internal wakeup line 1 event (RTC). - 0: Detection of wakeup event on rising edge (default). - 1: Detection of wakeup event on falling edge.
    $02 constant PWRC_IWUP2                     \ [0x02] IWUP2: Wakeup polarity for internal wakeup line 2 event (LCD). - 0: Detection of wakeup event on rising edge (default). - 1: Detection of wakeup event on falling edge.
    $03 constant PWRC_IWUP3                     \ [0x03] IWUP3: Wakeup polarity for internal wakeup line 3 event (COMP). - 0: Detection of wakeup event on rising edge (default). - 1: Detection of wakeup event on falling edge.
    $04 constant PWRC_IWUP4                     \ [0x04] IWUP4: Wakeup polarity for internal wakeup line 4 event (LCSC). - 0: Detection of wakeup event on rising edge (default). - 1: Detection of wakeup event on falling edge.
    $08 constant PWRC_WMRSUBGHP                 \ [0x08] WMRSUBGHP: Wakeup polarity for internal wakeup MRSUBG event - 0: Detection of wakeup event on rising edge (default). - 1: Detection of wakeup event on falling edge.
    $09 constant PWRC_WMRSUBGHCPUP              \ [0x09] WMRSUBGHCPUP: Wakeup polarity for internal wakeup MRSUBG Host CPU event - 0: Detection of wakeup event on rising edge (default). - 1: Detection of wakeup event on falling edge.
    $0a constant PWRC_WLPAWURP                  \ [0x0a] WLPAWURP: Wakeup polarity for wakeup LPAWUR event. - 0: Detection of wakeup event on rising edge (default). - 1: Detection of wakeup event on falling edge.
  [then]


  [ifdef] PWRC_IWUF_DEF
    \
    \ @brief IWUF register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_IWUF0                     \ [0x00] IWUF0: Internal wakeup flag (LPUART). - 0: no wakeup from LPUART occurred since last clear. - 1: a wakeup from LPUART occurred since last clear. Cleared by writing 1 in this bit.
    $01 constant PWRC_IWUF1                     \ [0x01] IWUF1: Internal wakeup flag (RTC). - 0: no wakeup from RTC occurred since last clear. - 1: a wakeup from RTC occurred
    $02 constant PWRC_IWUF2                     \ [0x02] IWUF2: Internal wakeup flag (LCD). - 0: no wakeup from LCD occurred since last clear. - 1: a wakeup from LCD occurred since last clear. Cleared by writing 1 in this bit.
    $03 constant PWRC_IWUF3                     \ [0x03] IWUF3: Internal wakeup flag (COMP). - 0: no wakeup from COMP occurred since last clear. - 1: a wakeup from COMP occurred since last clear. Cleared by writing 1 in this bit.
    $04 constant PWRC_IWUF4                     \ [0x04] IWUF4: Internal wakeup flag (LCSC). - 0: no wakeup from LCSC occurred since last clear. - 1: a wakeup from LCSC occurred since last clear. Cleared by writing 1 in this bit.
    $08 constant PWRC_WMRSUBGF                  \ [0x08] WMRSUBGF Wakeup MRSUBG Flag This bit is set by hardware when a MRSUBG wakeup is detected It is cleared by a reset pad or by software writing 1 in this bit field. - 0: No MRSUBG Wakeup detected - 1: MRSUBG Wakeup detected writting 1 in this bit, clears the interrupt
    $09 constant PWRC_WMRSUBGHCPUF              \ [0x09] WMRSUBGHCPUF Wakeup MRSUBG HOST CPU Flag (cf. user manual) This bit is set by hardware when a MRSUBG HOST CPU wakeup is detected It is cleared by a reset pad or by software writing 1 in this bit field. - 0: No MRSUBG Host CPU wakeup detected - 1: MRSUBG Host CPU wakeup detected writting 1 in this bit, clears the interrupt
    $0a constant PWRC_WLPAWURF                  \ [0x0a] WLPAWURF Wakeup LPAWUR Flag (cf. user manual) This bit is set by hardware when a LPAWUR wakeup is detected It is cleared by a reset pad or by software writing 1 in this bit field. - 0: No LPAWUR wakeup detected - 1: LPAWUR wakeup detected writting 1 in this bit, clears the interrupt
  [then]


  [ifdef] PWRC_SR2_DEF
    \
    \ @brief SR2 register
    \ Address offset: 0x14
    \ Reset value: 0x0000F3F6
    \
    $00 constant PWRC_SMPSBYPR                  \ [0x00] SMPSBYPR: SMPS Force Bypass Control Replica This bit mirrors the actual BYPASS_3V3 control signal driven to the SMPS regulator, dependant on the real working state.
    $01 constant PWRC_SMPSENR                   \ [0x01] SMPSENR: SMPS Enable Control Replica This bit mirrors the actual ENABLE_3V3 control signal driven to the SMPS regulator, dependant on the real working state.
    $02 constant PWRC_SMPSRDY                   \ [0x02] SMPSRDY: SMPS Ready Status This bit provides the information whether SMPS is ready. - 0: SMPS regulator is not ready - 1: SMPS regulator is ready.
    $04 constant PWRC_IOBOOTVAL2                \ [0x04 : 4] Bit3: PB15 input value on VDD33 latched at POR Bit2: PB14 input value on VDD33 latched at POR Bit1: PB13 input value on VDD33 latched at POR Bit0: PB12 input value on VDD33 latched at POR
    $08 constant PWRC_REGLPS                    \ [0x08] REGLPS: Regulator Low Power Started This bit provides the information whether low power regulator is ready. - 0: LP regulator is not ready. - 1: LP regulator is ready.
    $09 constant PWRC_REGMS                     \ [0x09] REGMS: Main regulator ready status. - 0: The Main regulator is not ready. - 1: The Main regulator is ready.
    $0b constant PWRC_PVDO                      \ [0x0b] PVDO: Power Voltage Detector Output When the Power Voltage Detector is enabled (CR2.PVDE) this bit is set when the system supply (VDDIO) is lower than the selected PVD threshold (CR2.PVDLS)
    $0c constant PWRC_IOBOOTVAL                 \ [0x0c : 4] Bit3: PA11 input value on VDD33 latched at POR Bit2: PA10 input value on VDD33 latched at POR Bit1: PA9 input value on VDD33 latched at POR Bit0: PA8 input value on VDD33 latched at POR
  [then]


  [ifdef] PWRC_CR5_DEF
    \
    \ @brief CR5 register
    \ Address offset: 0x1C
    \ Reset value: 0x00006014
    \
    $00 constant PWRC_SMPSLVL                   \ [0x00 : 4] SMPSLVL[3:0] SMPS Output Level Voltage Selection Select the SMPS output voltage with a granularity of 50mV. Default = '0100' (1.4V) Vout = 1.2 + 0.05*SMPSOUT (V)
    $04 constant PWRC_SMPSBOMSEL                \ [0x04 : 2] SMPSBOMSEL: SMPS BOM Selection: - 00: BOM1 - 01: BOM2 (default) - 10: BOM3 - 11: n/a
    $06 constant PWRC_SMPS_BOF_STATIC           \ [0x06] SMPS_BOF_STATIC: SMPS Bypass on the Fly static - 0 : disabled (by default) - 1 : SMPS Bypass on the fly static is enabled (EN_SW=1)
    $07 constant PWRC_NOSMPS_BOF                \ [0x07] NOSMPS_BOF: No SMPS Mode to be used in accordance to SMPS_BOF_STATIC =1 When this bit is set, the SMPS regulator will be disabled. Note that this configuration should be used only SMPS_BOF_STATIC=1. - 0 : No effect, SMPS is enabled. (default) - 1 : SMPS is disabled;
    $08 constant PWRC_SMPSLPOPEN                \ [0x08] SMPSLPOPEN: In Low Power mode SMPS is in OPEN mode (instead of PRECHARGE mode). When this bit is set, when the chip is in Low power mode the SMPS regulator will be disabled (HZ) Documentation needed. - 0 : in Low Power mode, SMPS is in PRECHARGE, output is connected to VDDIO. (default) - 1 : in Low Power mode, SMPS is disabled, output is floating
    $09 constant PWRC_SMPSFBYP                  \ [0x09] SMPSFB Force SMPS Regulator in bypass mode When this bit is set, the SMPS regulator will be forced to operate in precharge mode. the actual state of SMPS can be observed thanks to the replica SR2.SMPSBYPR. - 0 : no effect (by default) - 1 : SMPS is disabled and bypassed (ENABLE_3V3=0 and PRECHARGE_3V3=1)
    $0a constant PWRC_NOSMPS                    \ [0x0a] NOSMPS: No SMPS Mode When this bit is set, the SMPS regulator will be disabled. Note that this configuration should be used only when SMPS_FB pad is directly connected to VBATT or Vext, without L/C BOM. - 0 : No effect, SMPS is enabled. (Default) - 1 : SMPS is disabled;
    $0b constant PWRC_SMPS_ENA_DCM              \ [0x0b] SMPS_ENA_DCM: enable discontinuous conduction mode - 0 : disable (Default) - 1 : enable
    $0c constant PWRC_CLKDETR_DISABLE           \ [0x0c] CLKDETR_DISABLE: disable SMPS clock detection The SMPS clock detection enables an automatic SMPS bypass switching in case of unwanted loss of SMPS clock. - 0 : SMPS clock detection enabled (default) - 1 : SMPS clock detection disabled
    $0d constant PWRC_SMPS_PRECH_CUR_SEL        \ [0x0d : 2] SMPS_PRECH_CUR_SEL[1:0] Selection for SMPS PRECHARGE limit current - 00: 2.5mA - 01: 5mA - 10: 10mA - 11: 20mA (default)
    $0f constant PWRC_SMPS_BOF_DYN              \ [0x0f] SMPS_BOF_DYN: SMPS Bypass on the Fly dynamic - 0 : disabled (by default) - 1 : SMPS Bypass on the fly dynamic is enabled (EN_LDO=1)
  [then]


  [ifdef] PWRC_PUCRA_DEF
    \
    \ @brief PUCRA register
    \ Address offset: 0x20
    \ Reset value: 0x0000FFF7
    \
    $00 constant PWRC_PUA                       \ [0x00 : 16] PUA[x] : Pull Up Port A Pull up activation on port A[i] pad when APC bit of PWRC CR1 is set - 1: Pull-Up activated on port A[i] when APC bit of PWRC CR1 bit is set and PWR_PDCRA[x] is reset - 0: Pull-Up not activated on port A[i]
  [then]


  [ifdef] PWRC_PDCRA_DEF
    \
    \ @brief PDCRA register
    \ Address offset: 0x24
    \ Reset value: 0x00000008
    \
    $00 constant PWRC_PDA                       \ [0x00 : 16] PDA[x]: Pull Down Port A Pull Down activation on port A[i] pad when APC bit of PWRC CR1 is set - 1: Pull-Down activated on Port A[i] when APC bit of PWRC CR1 bit is set - 0: Pull-Down not activated on Port A[i]
  [then]


  [ifdef] PWRC_PUCRB_DEF
    \
    \ @brief PUCRB register
    \ Address offset: 0x28
    \ Reset value: 0x0000FFFF
    \
    $00 constant PWRC_PUB                       \ [0x00 : 16] PUB[x] : Pull Up Port B Pull up activation on port B[i] pad when APC bit of PWRC CR1 is set - 1: Pull-Up activated on port B[i] when APC bit of PWRC CR1 bit is set and PWR_PDCRB[x] is reset - 0: Pull-Up not activated on port B[i]
  [then]


  [ifdef] PWRC_PDCRB_DEF
    \
    \ @brief PDCRB register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_PDB                       \ [0x00 : 16] PDB[x]: Pull Down Port B Pull Down activation on port B[i] pad when APC bit of PWRC CR1 is set - 1: Pull-Down activated on Port B[i] when APC bit of PWRC CR1 bit is set - 0: Pull-Down not activated on Port B[i]
  [then]


  [ifdef] PWRC_EWUA_DEF
    \
    \ @brief EWUA register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_EWUA                      \ [0x00 : 16] EWUA[x] Enable WakeUp line PA[x] When this bit is set the PA[x] wakeup line is enabled and a rising or falling edge on wakeup line PA[x] will trigger a CPU wakeup event depending on CR7.WUPA[x] bit.
  [then]


  [ifdef] PWRC_WUPA_DEF
    \
    \ @brief WUPA register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_WUPA                      \ [0x00 : 16] WUPA[x] Wake-up Line PA[x] Polarity This bit defines the polarity used for event detection on external wake-up line PA[x] - 0: Detection on high level (rising edge) - 1: Detection on low level (falling edge)
  [then]


  [ifdef] PWRC_WUFA_DEF
    \
    \ @brief WUFA register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_WUFA                      \ [0x00 : 16] WUFA[x] WakeUp Flag PA[x] This bit is set when a wakeup is detected on wakeup line PA[x]. It is cleared by a reset pad or by writing 1 in this bit field. Writing 1 this bit, clears the interrupt:
  [then]


  [ifdef] PWRC_EWUB_DEF
    \
    \ @brief EWUB register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_EWUB                      \ [0x00 : 16] EWUB[x] Enable WakeUp line PB[x] When this bit is set the PB[x] wakeup line is enabled and a rising or falling edge on wakeup line PB[x] will trigger a CPU wakeup event depending on CR9.WUPB[x] bit.
  [then]


  [ifdef] PWRC_WUPB_DEF
    \
    \ @brief WUPB register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_WUPB                      \ [0x00 : 16] WUPB[x] Wake-up Line PB[x] Polarity This bit defines the polarity used for event detection on external wake-up line PB[x] - 0: Detection on high level (rising edge) - 1: Detection on low level (falling edge)
  [then]


  [ifdef] PWRC_WUFB_DEF
    \
    \ @brief WUFB register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_WUFB                      \ [0x00 : 16] WUFB[x] WakeUp Flag PB[x] This bit is set when a wakeup is detected on wakeup line PB[x]. It is cleared by a reset pad or by writing 1 in this bit field. Writing 1 this bit, clears the interrupt:
  [then]


  [ifdef] PWRC_SDWN_WUEN_DEF
    \
    \ @brief SDWN_WUEN register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_WUEN                      \ [0x00] WUEN PB0 I/O WakeUp from shutdown Enable When this bit is set the PB0 wakeup from shutdown is enabled so that a rising or falling edge on PB0 (depending on SDWN_WUPOL..WUPOL bit) will trigger a CPU wakeup. It is cleared by a PORESETn. - 0: PB0 wakeup from shutdown disabled - 1: PB0 wakeup from shutdown enabled
  [then]


  [ifdef] PWRC_SDWN_WUPOL_DEF
    \
    \ @brief SDWN_WUPOL register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_WUPOL                     \ [0x00] WUPOL PB0 I/O WakeUp from shutdown Polarity This bit defines the polarity used for wakeup from shutdown detection on PB0 pin. It is cleared by a PORESETn. - 0: Detection on high level (rising edge) - 1: Detection on low level (falling edge)
  [then]


  [ifdef] PWRC_SDWN_WUF_DEF
    \
    \ @brief SDWN_WUF register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_WUF                       \ [0x00] WUF PB0 I/O WakeUp from shutdown Flag This bit is set when a wakeup from shutdown is detected on PB0 pin. It is cleared by a PORESETn or by writing 0 in this bit field. - 0: Shutdown wakeup from PB0 not occurred - 1: Shutdown wakeup from PB0 occurred
  [then]


  [ifdef] PWRC_BOF_TUNE_DEF
    \
    \ @brief BOF_TUNE register
    \ Address offset: 0x58
    \ Reset value: 0x00000004
    \
    $00 constant PWRC_BOF_TUNE                  \ [0x00 : 4] BOF_TUNE: selection of the Bypass on the Fly LDO output voltage. - 0: 1.2V - 1: 1.2V - 2: 1.2V - 3: 1.3V - 4: 1.4V (Default) - 5: 1.5V - 6: 1.6V - 7: 1.7V - 8: 1.8V - 9: 1.9V - 10: 2V - 11: 2.1V - 12: 2.2V - 13: 2.3V - 14: 2.4V - 15: 2.4V
  [then]


  [ifdef] PWRC_DBGR_DEF
    \
    \ @brief DBGR register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_DEEPSTOP2                 \ [0x00] DEEPSTOP2 low power saving mode emulation enable this bit enable an emulated debug DEEPSTOP low power mode. If emulation is enabled, entering in DEEPSTOP mode, the v12i power domain still enters power saving mode, but its clock and power are maintained.
    $07 constant PWRC_SMPSFRDY                  \ [0x07] SMPSFB Force ready check When this bit is set, the SMPS regulator will be forced to operate in precharge mode. the actual state of SMPS can be observed thanks to the replica SR2.SMPSBYPR. - 0 : no effect (by default) - 1 : SMPS is disabled and bypassed (ENABLE_3V3=0 and PRECHARGE_3V3=1)
    $08 constant PWRC_KELVIN_TEST               \ [0x08 : 3] KELVIN_TEST[2:0]: Enable TEST mode Kelvin for LDO_RF (Write protected by IFR3 key) - 000: 0mA (open) (default 0x0) - 001 for 1mA - 010 for 3mA - 011 for 5mA - 100 for 8mA - 101 for 10mA else: 0mA (open) for other combinations.
    $0d constant PWRC_DIS_PRECH                 \ [0x0d : 3] DIS_PRECH[2:0]: disable precharge during deepstop (debug) allowed combination are: - 111: precharge and SMPS monitoring are disabled (whatever CR5.SMPSLPOPEN) - 101: precharge are activated only at deepstop exit (to be used only with CR5.SMPSLPOPEN=1) else: No effect (default 0x0)
  [then]


  [ifdef] PWRC_EXTSRR_DEF
    \
    \ @brief EXTSRR register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $09 constant PWRC_DEEPSTOPF                 \ [0x09] DEEPSTOPF System DeepStop Flag This bit is set by hardware and cleared only by a POR reset or by writing '1' in this bit field - 0: System has not been in DEEPSTOP mode - 1: System has been in DEEPSTOP mode
    $0a constant PWRC_RFPHASEF                  \ [0x0a] RFPHASEF RFPHASE Flag This bit is set by hardware after a S3LP wake-up event (S3LP activation); it is cleared either by software, writing '1' in this bit field, or by hardware when Ready2Sleep signal is asserted by the Radio IP. - 0: RF IP does not require attention - 1: RF IP awake and requesting system attention
  [then]


  [ifdef] PWRC_DBGSMPS_DEF
    \
    \ @brief DBGSMPS register
    \ Address offset: 0x8C
    \ Reset value: 0x00008000
    \
    $00 constant PWRC_TESTDIG                   \ [0x00 : 4] TESTDIG: SMPS TEST_DIG_3V3[3:0] SMPS control signal
    $04 constant PWRC_TESTKEL                   \ [0x04 : 2] TESTKEL: SMPS TEST_KEL_3V3[1:0] SMPS control signal
    $06 constant PWRC_HOT_STUP                  \ [0x06] HOT_STUP_3V3 SMPS control signal
    $07 constant PWRC_NO_STUP                   \ [0x07] NO_STUP_3V3 SMPS control signal
    $08 constant PWRC_TESTILIM                  \ [0x08] TESTILIM: SMPS TEST_ILIM_3V3 SMPS control signal
    $09 constant PWRC_CTLRES_RAMP               \ [0x09] CTLRES_RAM_3V3 SMPS control signal
    $0a constant PWRC_DIS_BIG_MOS               \ [0x0a] DIS_BIG_MOS_3V3 SMPS control signal
    $0b constant PWRC_TEST_OL                   \ [0x0b] TEST_OL_3V3 SMPS control signal
    $0c constant PWRC_DIS_ILIM                  \ [0x0c] DIS_ILIM_3V3 SMPS control signal
    $0d constant PWRC_ILIM_BOOST                \ [0x0d] ILIM_BOOST_3V3 SMPS current limitation Boost - 0: Max current = 110mA (Default) - 1: Max current = 130mA
    $0e constant PWRC_BOF_CUR_SEL               \ [0x0e : 2] BOF_CUR_SEL Bypass On the Fly current limitation - 00 : 20mA - 01 : 40mA - 10 : 60mA (default) - 11 : no limit
  [then]


  [ifdef] PWRC_TRIMR_DEF
    \
    \ @brief TRIMR register
    \ Address offset: 0x90
    \ Reset value: 0x00002304
    \
    $00 constant PWRC_RFD_REG_TRIM              \ [0x00 : 3] RFD_REG_TRIM[2:0]: RF LDO Trimming By default, this value is taken from the engi bytes; and saved on V12o domain when OBL done. if associated ENGTRIM is enabled the RF LDO trimming can be controlled by the dedicated ENGTRIM register. Default= '100'.
    $03 constant PWRC_SPARE                     \ [0x03] SPARE
    $04 constant PWRC_TRIM_MR                   \ [0x04 : 4] TRIM_MR[3:0]: Main Regulator Voltage Trimming By default, this value is taken from the engi bytes; and saved on V12o domain when OBL done. if associated ENGTRIM.TRIMMREN is enabled the Main Regulator Voltage can be controlled by the dedicated ENGTRIM.TRIM_MR register. Default= '0000'.
    $08 constant PWRC_SMPS_TRIM                 \ [0x08 : 3] SMPS_TRIM[2:0]: SMPS Output Voltage Trimming By default, this value is taken from the engi bytes; and saved on V12o domain when OBL done. if associated ENGTRIM is enabled the SMPS output voltage can be controlled by the dedicated ENGTRIM register. Default= '011'.
    $0b constant PWRC_BOF_TRIM                  \ [0x0b : 3] BOF_TRIM[2:0]: Bypass On the Fly Output Voltage Trimming By default, this value is taken from the engi bytes; and saved on V12o domain when OBL done. if associated ENGTRIM is enabled the SMPS output voltage can be controlled by the dedicated ENGTRIM register. Default= '100'.
  [then]


  [ifdef] PWRC_ENGTRIM_DEF
    \
    \ @brief ENGTRIM register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_TRIMRFDREGEN              \ [0x00] TRIMRFDREGEN: trimming RFREG enabled - 1: trimming bit applied from ENGTRIM register - 0: trimming bit applied from OBL (can be read on TRIMR register)
    $01 constant PWRC_TRIM_RFDREG               \ [0x01 : 3] TRIM_RFDREG: RF Regulator Trimming By default, this value is not applied, but taken from the engi bytes; if ENGTRIM.TRIMRFDREGEN=1, the startup current can be controlled by this register.
    $04 constant PWRC_SPARE                     \ [0x04] SPARE
    $05 constant PWRC_TRIMMREN                  \ [0x05] TRIMMREN: trimming MR enabled - 1: trimming bit applied from ENGTRIM register - 0: trimming bit applied from OBL (can be read on TRIMR register)
    $06 constant PWRC_TRIM_MR                   \ [0x06 : 4] TRIM_MR: Main Regulator Output Voltage Trimming By default, this value is not applied, but taken from the engi bytes; if ENGTRIM.TRIMMREN=1, the startup current can be controlled by this register.
    $0a constant PWRC_SMPSTRIMEN                \ [0x0a] SMPSTRIMEN: trimming SMPS enabled - 1: trimming bit applied from ENGTRIM register - 0: trimming bit applied from OBL (can be read on TRIMR register)
    $0b constant PWRC_SMPS_TRIM                 \ [0x0b : 3] SMPS_TRIM: SMPS Output Voltage Trimming By default, this value is not applied, but taken from the engi bytes; if ENGTRIM.SMPSTRIMEN=1, the SMPS output voltage can be controlled by this register.
  [then]


  [ifdef] PWRC_DBG_STATUS_REG1_DEF
    \
    \ @brief DBG_STATUS_REG1 register
    \ Address offset: 0x98
    \ Reset value: 0x00000202
    \
    $00 constant PWRC_SMPS_FSM_STATE            \ [0x00 : 3] SMPS_FSM_STATE[2:0]: Indicates the current state of the SMPS FSM inside the PWRC.: - 000: STARTUP - 001: SMPS_REQ - 010: SMPS_RUN - 011: STOP - 100: NOSMPS - 101: PRECHARGE - 110: NOSMPS_BOF
    $08 constant PWRC_FLASH_FSM_STATE           \ [0x08 : 3] FLASH_FSM_STATE[2:0]: Indicates the current state of the FLASH FSM inside the PWRC: - 000: STATE1: FLASH POR - 001: STATE2: FLASH PWRUP - 010: STATE3: FLASH READY - 101: STATE4: FLASH SWITCH OFF - 110: STATE5: FLASH PWR DOWN
  [then]


  [ifdef] PWRC_DBG_STATUS_REG2_DEF
    \
    \ @brief DBG_STATUS_REG2 register
    \ Address offset: 0x9C
    \ Reset value: 0x00000201
    \
    $00 constant PWRC_PMU_FSM_STATE             \ [0x00 : 4] PMU_FSM_STATE[3:0]: Indicates the current state of the PMU FSM inside the PWRC. - 0000: POR - 0001: RUN - 0010: DS ENTRY - 0011: WAIT1 - 0100: WAIT2 - 0101: WAIT - 0110: WAIT3 - 0111: WAIT4 - 1000: ISOLATION - 1001: DEEPSTOP - 1010: SHUTDOWN - 1011: DEEPSTOP EXIT
    $08 constant PWRC_RAM_FSM_STATE             \ [0x08 : 2] RAM_FSM_STATE[1:0]: Indicates the current state of the RAM FSM inside the PWRC: - 00: POR - 01: POWER UP - 10: READY - 11: OFF
  [then]


  [ifdef] PWRC_ENGTRIM2_DEF
    \
    \ @brief ENGTRIM2 register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_BOFTRIMEN                 \ [0x00] BOFTRIMEN: trimming BOF enabled - 1: trimming bit applied from ENGTRIM2 register - 0: trimming bit applied from OBL (can be read on TRIMR register)
    $01 constant PWRC_BOF_TRIM                  \ [0x01 : 3] SMPS_TRIM: SMPS Output Voltage Trimming By default, this value is not applied, but taken from the engi bytes; if ENGTRIM.BOFTRIMEN=1, the SMPS output voltage can be controlled by this register.
  [then]

  \
  \ @brief PVD / BORH
  \
  $00 constant PWRC_CR1                 \ CR1 register
  $04 constant PWRC_CR2                 \ CR2 register
  $08 constant PWRC_IEWU                \ IEWU register
  $0C constant PWRC_IWUP                \ IWUP register
  $10 constant PWRC_IWUF                \ IWUF register
  $14 constant PWRC_SR2                 \ SR2 register
  $1C constant PWRC_CR5                 \ CR5 register
  $20 constant PWRC_PUCRA               \ PUCRA register
  $24 constant PWRC_PDCRA               \ PDCRA register
  $28 constant PWRC_PUCRB               \ PUCRB register
  $2C constant PWRC_PDCRB               \ PDCRB register
  $30 constant PWRC_EWUA                \ EWUA register
  $34 constant PWRC_WUPA                \ WUPA register
  $38 constant PWRC_WUFA                \ WUFA register
  $40 constant PWRC_EWUB                \ EWUB register
  $44 constant PWRC_WUPB                \ WUPB register
  $48 constant PWRC_WUFB                \ WUFB register
  $4C constant PWRC_SDWN_WUEN           \ SDWN_WUEN register
  $50 constant PWRC_SDWN_WUPOL          \ SDWN_WUPOL register
  $54 constant PWRC_SDWN_WUF            \ SDWN_WUF register
  $58 constant PWRC_BOF_TUNE            \ BOF_TUNE register
  $84 constant PWRC_DBGR                \ DBGR register
  $88 constant PWRC_EXTSRR              \ EXTSRR register
  $8C constant PWRC_DBGSMPS             \ DBGSMPS register
  $90 constant PWRC_TRIMR               \ TRIMR register
  $94 constant PWRC_ENGTRIM             \ ENGTRIM register
  $98 constant PWRC_DBG_STATUS_REG1     \ DBG_STATUS_REG1 register
  $9C constant PWRC_DBG_STATUS_REG2     \ DBG_STATUS_REG2 register
  $A0 constant PWRC_ENGTRIM2            \ ENGTRIM2 register

: PWRC_DEF ; [then]
