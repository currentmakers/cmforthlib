\
\ @file pwrc.fs
\ @brief CR1 register
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
    $00 constant PWRC_LPMS                      \ [0x00] LPMS Low Power Mode Selection Selection of the low power mode entered when CPU enters DEEP SLEEP mode and BLE is rdy2sleep.
    $01 constant PWRC_ENSDNBOR                  \ [0x01] Enable BOR reset supervising during SHUTDOWN mode.
    $04 constant PWRC_APC                       \ [0x04] APC Apply Pull-up and pull-down configuration from CPU
  [then]


  [ifdef] PWRC_CR2_DEF
    \
    \ @brief CR2 register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_PVDE                      \ [0x00] PVDE Programmable Voltage Detector Enable When this bit is set the Power Voltage Detector is enabled
    $01 constant PWRC_PVDLS                     \ [0x01 : 3] PVDLS[2:0] Programmable Voltage Detector Level selection then PVDO=1)
    $05 constant PWRC_RAMRET1                   \ [0x05] RAMRET1: RAM1 retention during low power mode
    $06 constant PWRC_RAMRET2                   \ [0x06] Enables the RAM2 bank retention in DEEPSTOP mode.
    $07 constant PWRC_RAMRET3                   \ [0x07] Enables the RAM3 bank retention in DEEPSTOP mode.
    $09 constant PWRC_ENTS                      \ [0x09] Enable the temperature sensor.
    $0a constant PWRC_LSILPMUFEN                \ [0x0a] LSI LPMU force enable.
  [then]


  [ifdef] PWRC_CR3_DEF
    \
    \ @brief CR3 register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_EWU0                      \ [0x00] EWU0 Enable WakeUp line 0 (PB0) When this bit is set the wakeup line 0 is enabled and a rising or falling edge on wakeup line 0 will trigger a CPU wakeup event depending on CR4.WP0 bit.
    $01 constant PWRC_EWU1                      \ [0x01] EWU1 Enable WakeUp line 1 (PB1) When this bit is set the wakeup line 1 is enabled and a rising or falling edge on wakeup line 1 will trigger a CPU wakeup event depending on CR4.WP1 bit.
    $02 constant PWRC_EWU2                      \ [0x02] EWU2 Enable WakeUp line 2 (PB2) When this bit is set the wakeup line 2 is enabled and a rising or falling edge on wakeup line 2 will trigger a CPU wakeup event depending on CR4.WP2 bit.
    $03 constant PWRC_EWU3                      \ [0x03] EWU3 Enable WakeUp line 3 (PB3) When this bit is set the wakeup line 3 is enabled and a rising or falling edge on wakeup line 3 will trigger a CPU wakeup event depending on CR4.WP3 bit.
    $04 constant PWRC_EWU4                      \ [0x04] EWU4 Enable WakeUp line 4 (PB4) When this bit is set the wakeup line 4 is enabled and a rising or falling edge on wakeup line 4 will trigger a CPU wakeup event depending on CR4.WP4 bit.
    $05 constant PWRC_EWU5                      \ [0x05] EWU5 Enable WakeUp line 5 (PB5) When this bit is set the wakeup line 5 is enabled and a rising or falling edge on wakeup line 5 will trigger a CPU wakeup event depending on CR4.WP5 bit.
    $06 constant PWRC_EWU6                      \ [0x06] EWU6 Enable WakeUp line 6 (PB6) When this bit is set the wakeup line 6 is enabled and a rising or falling edge on wakeup line 6 will trigger a CPU wakeup event depending on CR4.WP6 bit.
    $07 constant PWRC_EWU7                      \ [0x07] EWU7 Enable WakeUp line 7 (PB7) When this bit is set the wakeup line 7 is enabled and a rising or falling edge on wakeup line 7 will trigger a CPU wakeup event depending on CR4.WP7 bit.
    $08 constant PWRC_EWU8                      \ [0x08] EWU8 Enable WakeUp line 8 (PA8) When this bit is set the wakeup line 8 is enabled and a rising or falling edge on wakeup line 8 will trigger a CPU wakeup event depending on CR4.WP8 bit.
    $09 constant PWRC_EWU9                      \ [0x09] EWU9 Enable WakeUp line 9 (PA9) When this bit is set the wakeup line 9 is enabled and a rising or falling edge on wakeup line 9 will trigger a CPU wakeup event depending on CR4.WP9 bit.
    $0a constant PWRC_EWU10                     \ [0x0a] EWU10 Enable WakeUp line 10 (PA10) When this bit is set the wakeup line 10 is enabled and a rising or falling edge on wakeup line 10 will trigger a CPU wakeup event depending on CR4.WP10 bit.
    $0b constant PWRC_EWU11                     \ [0x0b] EWU11 Enable WakeUp line 11 (PA11) When this bit is set the wakeup line 11 is enabled and a rising or falling edge on wakeup line 11 will trigger a CPU wakeup event depending on CR4.WP11 bit.
    $0c constant PWRC_EWBLE                     \ [0x0c] EWBLE: Enable wakeup on BLE event. 0: Wakeup on BLE line is disabled (default). 1: Wakeup on BLE line is enabled.
    $0d constant PWRC_EWBLEHCPU                 \ [0x0d] EWBLEHCPU: Enable wakeup on BLE Host CPU event. 0: Wakeup on BLE Host CPU line is disabled (default). 1: Wakeup on BLE Host CPU line is enabled.
    $0f constant PWRC_EIWL                      \ [0x0f] EIWL: Enable wakeup on Internal event (RTC). 0: Wakeup on internal line is disabled (default). 1: Wakeup on internal line is enabled.
  [then]


  [ifdef] PWRC_CR4_DEF
    \
    \ @brief CR4 register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_WUP0                      \ [0x00] WUP0 Wake-up Line Polarity 0 (PB0) This bit defines the polarity used for event detection on external wake-up line 0
    $01 constant PWRC_WUP1                      \ [0x01] WUP1 Wake-up Line Polarity 1 (PB1) This bit defines the polarity used for event detection on external wake-up line 1
    $02 constant PWRC_WUP2                      \ [0x02] WUP2 Wake-up Line Polarity 2 (PB2) This bit defines the polarity used for event detection on external wake-up line 2
    $03 constant PWRC_WUP3                      \ [0x03] WUP3 Wake-up Line Polarity 3 (PB3) This bit defines the polarity used for event detection on external wake-up line 3
    $04 constant PWRC_WUP4                      \ [0x04] WUP4 Wake-up Line Polarity 4 (PB4) This bit defines the polarity used for event detection on external wake-up line 4
    $05 constant PWRC_WUP5                      \ [0x05] WUP5 Wake-up Line Polarity 5 (PB5) This bit defines the polarity used for event detection on external wake-up line 5
    $06 constant PWRC_WUP6                      \ [0x06] WUP6 Wake-up Line Polarity 6 (PB6) This bit defines the polarity used for event detection on external wake-up line 6
    $07 constant PWRC_WUP7                      \ [0x07] WUP7 Wake-up Line Polarity 7 (PB7) This bit defines the polarity used for event detection on external wake-up line 7
    $08 constant PWRC_WUP8                      \ [0x08] WUP8 Wake-up Line Polarity 8 (PA8) This bit defines the polarity used for event detection on external wake-up line 8
    $09 constant PWRC_WUP9                      \ [0x09] WUP9 Wake-up Line Polarity 9 (PA9) This bit defines the polarity used for event detection on external wake-up line 9
    $0a constant PWRC_WUP10                     \ [0x0a] WUP10 Wake-up Line Polarity 10 (PA10) This bit defines the polarity used for event detection on external wake-up line 10
    $0b constant PWRC_WUP11                     \ [0x0b] WUP11 Wake-up Line Polarity 11 (PA11) This bit defines the polarity used for event detection on external wake-up line 11
  [then]


  [ifdef] PWRC_SR1_DEF
    \
    \ @brief SR1 register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_WUF0                      \ [0x00] WUF0 WakeUp Flag 0 (PB0) This bit is set when a wakeup is detected on wakeup line 0. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
    $01 constant PWRC_WUF1                      \ [0x01] WUF1 WakeUp Flag 1 (PB1) This bit is set when a wakeup is detected on wakeup line 1. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
    $02 constant PWRC_WUF2                      \ [0x02] WUF2 WakeUp Flag 2 (PB2) This bit is set when a wakeup is detected on wakeup line 2. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
    $03 constant PWRC_WUF3                      \ [0x03] WUF3 WakeUp Flag 3 (PB3) This bit is set when a wakeup is detected on wakeup line 3. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
    $04 constant PWRC_WUF4                      \ [0x04] WUF4 WakeUp Flag 4 (PB4) This bit is set when a wakeup is detected on wakeup line 4. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
    $05 constant PWRC_WUF5                      \ [0x05] WUF5 WakeUp Flag 5 (PB5) This bit is set when a wakeup is detected on wakeup line 5. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
    $06 constant PWRC_WUF6                      \ [0x06] WUF6 WakeUp Flag 6 (PB6) This bit is set when a wakeup is detected on wakeup line 6. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
    $07 constant PWRC_WUF7                      \ [0x07] WUF7 WakeUp Flag 7 (PB7) This bit is set when a wakeup is detected on wakeup line 7. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
    $08 constant PWRC_WUF8                      \ [0x08] WUF8 WakeUp Flag 8 (PA8) This bit is set when a wakeup is detected on wakeup line 8. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
    $09 constant PWRC_WUF9                      \ [0x09] WUF9 WakeUp Flag 9 (PA9) This bit is set when a wakeup is detected on wakeup line 9. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
    $0a constant PWRC_WUF10                     \ [0x0a] WUF10 WakeUp Flag 10 (PA10) This bit is set when a wakeup is detected on wakeup line 10. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
    $0b constant PWRC_WUF11                     \ [0x0b] WUF11 WakeUp Flag 11 (PA11) This bit is set when a wakeup is detected on wakeup line 11. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
    $0c constant PWRC_WBLEF                     \ [0x0c] WBLEF: BLE wakeup flag. 0: no wakeup from BLE occurred since last clear. 1: a wakeup from BLE occurred since last clear. Cleared by writing 1 in this bit.
    $0d constant PWRC_WBLEHCPUF                 \ [0x0d] WBLEHCPUF: BLE Host CPU wakeup flag. 0: no wakeup from BLE Host CPU occurred since last clear. 1: a wakeup from BLE Host CPU occurred since last clear. Cleared by writing 1 in this bit.
    $0f constant PWRC_IWUF                      \ [0x0f] IWUF: Internal wakeup flag (RTC). 0: no wakeup from RTC occurred since last clear. 1: a wakeup from RTC occurred since last clear. Note: The user must clear the RTC wakeup flag inside the RTC IP to clear this bit (mirror of the RTC wakeup line on the PWRC block).
  [then]


  [ifdef] PWRC_SR2_DEF
    \
    \ @brief SR2 register
    \ Address offset: 0x14
    \ Reset value: 0x00000306
    \
    $00 constant PWRC_SMPSBYPR                  \ [0x00] SMPSBYPR: SMPS Force Bypass Control Replica This bit mirrors the actual BYPASS_3V3 control signal driven to the SMPS regulator, dependant on the real working state.
    $01 constant PWRC_SMPSENR                   \ [0x01] SMPSENR: SMPS Enable Control Replica This bit mirrors the actual ENABLE_3V3 control signal driven to the SMPS regulator, dependant on the real working state.
    $02 constant PWRC_SMPSRDY                   \ [0x02] SMPSRDY: SMPS Ready Status This bit provides the information whether SMPS is ready.
    $08 constant PWRC_REGLPS                    \ [0x08] REGLPS: Regulator Low Power Started This bit provides the information whether low power regulator is ready.
    $09 constant PWRC_REGMS                     \ [0x09] REGMS: Regulator Main LDO Started This bit provides the information whether main regulator is ready.
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
    $04 constant PWRC_SMPSBOMSEL                \ [0x04 : 2] SMPSBOMSEL: SMPS BOM Selection:
    $08 constant PWRC_SMPSLPOPEN                \ [0x08] SMPSLPOPEN: In Low Power mode SMPS is in OPEN mode (instead of PRECHARGE mode). When this bit is set, when the chip is in Low power mode the SMPS regulator will be disabled (HZ) Documentation needed.
    $09 constant PWRC_SMPSFBYP                  \ [0x09] SMPSFB Force SMPS Regulator in bypass mode When this bit is set, the SMPS regulator will be forced to operate in precharge mode. the actual state of SMPS can be observed thanks to the replica SR2.SMPSBYPR.
    $0a constant PWRC_NOSMPS                    \ [0x0a] NOSMPS: No SMPS Mode When this bit is set, the SMPS regulator will be disabled. Note that this configuration should be used only when SMPS_FB pad is directly connected to VBATT or Vext, without L/C BOM.
    $0b constant PWRC_SMPS_ENA_DCM              \ [0x0b] SMPS_ENA_DCM: enable discontinuous conduction mode
    $0c constant PWRC_CLKDETR_DISABLE           \ [0x0c] CLKDETR_DISABLE: disable SMPS clock detection The SMPS clock detection enables an automatic SMPS bypass switching in case of unwanted loss of SMPS clock.
  [then]


  [ifdef] PWRC_PUCRA_DEF
    \
    \ @brief PUCRA register
    \ Address offset: 0x20
    \ Reset value: 0x00000F07
    \
    $00 constant PWRC_PUA                       \ [0x00 : 16] PUA[x] : Pull Up Pull up activation on port A[i] pad when APC bit of PWRC CR3 is set
  [then]


  [ifdef] PWRC_PDCRA_DEF
    \
    \ @brief PDCRA register
    \ Address offset: 0x24
    \ Reset value: 0x00000008
    \
    $00 constant PWRC_PDA                       \ [0x00 : 16] PDA[x]: Pull Down Pull Down activation on port A[i] pad when APC bit of PWRC CR3 is set
  [then]


  [ifdef] PWRC_PUCRB_DEF
    \
    \ @brief PUCRB register
    \ Address offset: 0x28
    \ Reset value: 0x0000F0FF
    \
    $00 constant PWRC_PUB                       \ [0x00 : 16] PUB[x] : Pull Up Pull up activation on port B[i] pad when APC bit of PWRC CR3 is set
  [then]


  [ifdef] PWRC_PDCRB_DEF
    \
    \ @brief PDCRB register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_PDB                       \ [0x00 : 16] PDB[x]: Pull Down Pull Down activation on port B[i] pad when APC bit of PWRC CR3 is set
  [then]


  [ifdef] PWRC_CR6_DEF
    \
    \ @brief CR6 register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_EWU12                     \ [0x00] EWU12 Enable WakeUp line 12 (PA0) When this bit is set the wakeup line 12 is enabled and a rising or falling edge on wakeup line 0 will trigger a CPU wakeup event depending on CR7.WP0 bit.
    $01 constant PWRC_EWU13                     \ [0x01] EWU13 Enable WakeUp line 13 (PA1) When this bit is set the wakeup line 13 is enabled and a rising or falling edge on wakeup line 1 will trigger a CPU wakeup event depending on CR7.WP1 bit.
    $02 constant PWRC_EWU14                     \ [0x02] EWU14 Enable WakeUp line 14 (PA2) When this bit is set the wakeup line 14 is enabled and a rising or falling edge on wakeup line 2 will trigger a CPU wakeup event depending on CR7.WP2 bit.
    $03 constant PWRC_EWU15                     \ [0x03] EWU15 Enable WakeUp line 15 (PA3) When this bit is set the wakeup line 15 is enabled and a rising or falling edge on wakeup line 3 will trigger a CPU wakeup event depending on CR7.WP3 bit.
    $04 constant PWRC_EWU16                     \ [0x04] EWU16 Enable WakeUp line 16 (PB12) When this bit is set the wakeup line 16 is enabled and a rising or falling edge on wakeup line 4 will trigger a CPU wakeup event depending on CR7.WP4 bit.
    $05 constant PWRC_EWU17                     \ [0x05] EWU17 Enable WakeUp line 17 (PB13) When this bit is set the wakeup line 17 is enabled and a rising or falling edge on wakeup line 5 will trigger a CPU wakeup event depending on CR7.WP5 bit.
    $06 constant PWRC_EWU18                     \ [0x06] EWU18 Enable WakeUp line 18 (PB14) When this bit is set the wakeup line 18 is enabled and a rising or falling edge on wakeup line 6 will trigger a CPU wakeup event depending on CR7.WP6 bit.
    $07 constant PWRC_EWU19                     \ [0x07] EWU19 Enable WakeUp line 19 (PB15) When this bit is set the wakeup line 19 is enabled and a rising or falling edge on wakeup line 7 will trigger a CPU wakeup event depending on CR7.WP7 bit.
    $08 constant PWRC_EWU20                     \ [0x08] Enable wakeup on PB8 I/O event.
    $09 constant PWRC_EWU21                     \ [0x09] Enable wakeup on PB9 I/O event.
    $0a constant PWRC_EWU22                     \ [0x0a] Enable wakeup on PB10 I/O event.
    $0b constant PWRC_EWU23                     \ [0x0b] Enable wakeup on PB11 I/O event.
    $0c constant PWRC_EWU24                     \ [0x0c] Enable wakeup on PA12 I/O event.
    $0d constant PWRC_EWU25                     \ [0x0d] Enable wakeup on PA13 I/O event.
    $0e constant PWRC_EWU26                     \ [0x0e] Enable wakeup on PA14 I/O event.
    $0f constant PWRC_EWU27                     \ [0x0f] Enable wakeup on PA15 I/O event.
  [then]


  [ifdef] PWRC_CR7_DEF
    \
    \ @brief CR7 register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_WUP12                     \ [0x00] WUP12 Wake-up Line Polarity 12 (PA0) This bit defines the polarity used for event detection on external wake-up line 12
    $01 constant PWRC_WUP13                     \ [0x01] WUP13 Wake-up Line Polarity 13 (PA1) This bit defines the polarity used for event detection on external wake-up line 13
    $02 constant PWRC_WUP14                     \ [0x02] WUP14 Wake-up Line Polarity 14 (PA2) This bit defines the polarity used for event detection on external wake-up line 14
    $03 constant PWRC_WUP15                     \ [0x03] WUP15 Wake-up Line Polarity 15 (PA3) This bit defines the polarity used for event detection on external wake-up line 15
    $04 constant PWRC_WUP16                     \ [0x04] WUP16 Wake-up Line Polarity 16 (PB12) This bit defines the polarity used for event detection on external wake-up line 16
    $05 constant PWRC_WUP17                     \ [0x05] WUP17 Wake-up Line Polarity 17 (PB13) This bit defines the polarity used for event detection on external wake-up line 17
    $06 constant PWRC_WUP18                     \ [0x06] WUP18 Wake-up Line Polarity 18 (PB14) This bit defines the polarity used for event detection on external wake-up line 18
    $07 constant PWRC_WUP19                     \ [0x07] WUP19 Wake-up Line Polarity 19 (PB15) This bit defines the polarity used for event detection on external wake-up line 19
    $08 constant PWRC_WUP20                     \ [0x08] Wake-up polarity for PB8 IO event.
    $09 constant PWRC_WUP21                     \ [0x09] Wake-up polarity for PB9 IO event.
    $0a constant PWRC_WUP22                     \ [0x0a] Wake-up polarity for PB10 IO event.
    $0b constant PWRC_WUP23                     \ [0x0b] Wake-up polarity for PB11 IO event.
    $0c constant PWRC_WUP24                     \ [0x0c] Wake-up polarity for PB12 IO event.
    $0d constant PWRC_WUP25                     \ [0x0d] Wake-up polarity for PB13 IO event.
    $0e constant PWRC_WUP26                     \ [0x0e] Wake-up polarity for PB14 IO event.
    $0f constant PWRC_WUP27                     \ [0x0f] Wake-up polarity for PB15 IO event.
  [then]


  [ifdef] PWRC_SR3_DEF
    \
    \ @brief SR3 register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_WUF12                     \ [0x00] WUF12 WakeUp Flag 12 PA0 This bit is set when a wakeup is detected on wakeup line 12. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
    $01 constant PWRC_WUF13                     \ [0x01] WUF13 WakeUp Flag 13 PA1 This bit is set when a wakeup is detected on wakeup line 13. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
    $02 constant PWRC_WUF14                     \ [0x02] WUF14 WakeUp Flag 14 PA2 This bit is set when a wakeup is detected on wakeup line 14. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
    $03 constant PWRC_WUF15                     \ [0x03] WUF15 WakeUp Flag 15 PA3 This bit is set when a wakeup is detected on wakeup line 15. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
    $04 constant PWRC_WUF16                     \ [0x04] WUF16 WakeUp Flag 16 PB12 This bit is set when a wakeup is detected on wakeup line 16. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
    $05 constant PWRC_WUF17                     \ [0x05] WUF17 WakeUp Flag 17 PB13 This bit is set when a wakeup is detected on wakeup line 17. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
    $06 constant PWRC_WUF18                     \ [0x06] WUF18 WakeUp Flag 18 PB14 This bit is set when a wakeup is detected on wakeup line 18. It is cleared by a reset pad or by writing 1 in this bit field. writting this bit, clears the interrupt:
    $07 constant PWRC_WUF19                     \ [0x07] PA7 I/O wake-up flag.
    $08 constant PWRC_WUF20                     \ [0x08] PB8 I/O wake-up flag.
    $09 constant PWRC_WUF21                     \ [0x09] PB9 I/O wake-up flag.
    $0a constant PWRC_WUF22                     \ [0x0a] PB10 I/O wake-up flag.
    $0b constant PWRC_WUF23                     \ [0x0b] PB11 I/O wake-up flag.
    $0c constant PWRC_WUF24                     \ [0x0c] PB12 I/O wake-up flag.
    $0d constant PWRC_WUF25                     \ [0x0d] PB13 I/O wake-up flag.
    $0e constant PWRC_WUF26                     \ [0x0e] PB14 I/O wake-up flag.
    $0f constant PWRC_WUF27                     \ [0x0f] PB15 I/O wake-up flag.
  [then]


  [ifdef] PWRC_IOxCFG_DEF
    \
    \ @brief IOxCFG register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_IOCFG0                    \ [0x00 : 2] Drive configuration for PA8.
    $02 constant PWRC_IOCFG1                    \ [0x02 : 2] Drive configuration for PA9.
    $04 constant PWRC_IOCFG2                    \ [0x04 : 2] Drive configuration for PA10.
    $06 constant PWRC_IOCFG3                    \ [0x06 : 2] Drive configuration for PA11.
    $08 constant PWRC_IOCFG4                    \ [0x08 : 2] Drive configuration for PA4.
    $0a constant PWRC_IOCFG5                    \ [0x0a : 2] Drive configuration for PA5.
    $0c constant PWRC_IOCFG6                    \ [0x0c : 2] Drive configuration for PA6.
    $0e constant PWRC_IOCFG7                    \ [0x0e : 2] Drive configuration for PA7.
  [then]


  [ifdef] PWRC_DBGR_DEF
    \
    \ @brief DBGR register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant PWRC_DEEPSTOP2                 \ [0x00] DEEPSTOP2: DEEPSTOP2 low power saving emulation enable. 0: normal DEEPSTOP will be applied 1: DEEPSTOP2 (debugger features not lost) will be applied instead of DEEPSTOP.
  [then]


  [ifdef] PWRC_EXTSRR_DEF
    \
    \ @brief EXTSRR register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $09 constant PWRC_DEEPSTOPF                 \ [0x09] DEEPSTOPF System DeepStop Flag This bit is set by hardware and cleared only by a POR reset or by writing '1' in this bit field
    $0a constant PWRC_RFPHASEF                  \ [0x0a] RFPHASEF RFPHASE Flag This bit is set by hardware after a Radio wake-up event (BLE activation); it is cleared either by software, writing '1' in this bit field, or by hardware when Ready2Sleep signal is asserted by the Radio IP.
  [then]

  \
  \ @brief CR1 register
  \
  $00 constant PWRC_CR1                 \ CR1 register
  $04 constant PWRC_CR2                 \ CR2 register
  $08 constant PWRC_CR3                 \ CR3 register
  $0C constant PWRC_CR4                 \ CR4 register
  $10 constant PWRC_SR1                 \ SR1 register
  $14 constant PWRC_SR2                 \ SR2 register
  $1C constant PWRC_CR5                 \ CR5 register
  $20 constant PWRC_PUCRA               \ PUCRA register
  $24 constant PWRC_PDCRA               \ PDCRA register
  $28 constant PWRC_PUCRB               \ PUCRB register
  $2C constant PWRC_PDCRB               \ PDCRB register
  $30 constant PWRC_CR6                 \ CR6 register
  $34 constant PWRC_CR7                 \ CR7 register
  $38 constant PWRC_SR3                 \ SR3 register
  $40 constant PWRC_IOXCFG              \ IOxCFG register
  $84 constant PWRC_DBGR                \ DBGR register
  $88 constant PWRC_EXTSRR              \ EXTSRR register

: PWRC_DEF ; [then]
