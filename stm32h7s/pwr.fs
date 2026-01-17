\
\ @file pwr.fs
\ @brief Power control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] PWR_DEF

  [ifdef] PWR_PWR_CR1_DEF
    \
    \ @brief PWR control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000001
    \
    $00 constant PWR_SVOS                       \ [0x00] System Stop mode voltage scaling selection.
    $04 constant PWR_PVDE                       \ [0x04] Programmable voltage detector enable
    $05 constant PWR_PLS                        \ [0x05 : 3] Programmable voltage detector level selection These bits select the voltage threshold detected by the PVD. Note: Refer to Section Electrical characteristics of the product datasheet for more details.
    $08 constant PWR_DBP                        \ [0x08] Disable backup domain write protection In reset state, the RCC_BDCR register, the RTC registers (including the backup registers), BREN and MOEN bits in the PWR_CSR1 register, are protected against parasitic write access. This bit must be set to enable write access to these registers.
    $09 constant PWR_FLPS                       \ [0x09] Flash low-power mode in Stop mode This bit allows to obtain the best trade-off between low-power consumption and restart time when exiting from Stop mode. When it is set, the Flash memory enters low-power mode when device is in Stop mode. consumption).
    $0a constant PWR_RLPSN                      \ [0x0a] RAM low power mode disable in STOP. When set the RAMs will not enter to low power mode when the system enters to STOP.
    $0b constant PWR_BOOSTE                     \ [0x0b] analog switch VBoost control This bit enables the booster to guarantee the analog switch AC performance when the VDD supply voltage is below 2.7 V (reduction of the total harmonic distortion to have the same switch performance over the full supply voltage range) The VDD supply voltage can be monitored through the PVD and the PLS bits.
    $0c constant PWR_AVDREADY                   \ [0x0c] analog voltage ready This bit is only used when the analog switch boost needs to be enabled (see BOOSTE bit). It must be set by software when the expected VDDA analog supply level is available. The correct analog supply level is indicated by the AVDO bit (PWR_CSR1 register) after setting the AVDEN bit and selecting the supply level to be monitored (ALS bits).
    $0d constant PWR_AVDEN                      \ [0x0d] Peripheral voltage monitor on VDDA enable
    $0e constant PWR_ALS                        \ [0x0e : 2] Analog voltage detector level selection These bits select the voltage threshold detected by the AVD. Note: Refer to Section Electrical characteristics of the product datasheet for more details.
  [then]


  [ifdef] PWR_PWR_SR1_DEF
    \
    \ @brief PWR control status register 1
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant PWR_ACTVOS                     \ [0x00] VOS currently applied for V<sub>CORE</sub> voltage scaling selection. These bit reflect the last VOS value applied to the PMU.
    $01 constant PWR_ACTVOSRDY                  \ [0x01] Voltage levels ready bit for currently used ACTVOS and SDHILEVEL This bit is set to 1 by hardware when the voltage regulator and the SMPS step-down converter are both disabled and Bypass mode is selected in PWR control register 2 (PWR_CSR2).
    $04 constant PWR_PVDO                       \ [0x04] Programmable voltage detect output This bit is set and cleared by hardware. It is valid only if the PVD has been enabled by the PVDE bit. PLS[2:0] bits. bits. Note: Since the PVD is disabled in Standby mode, this bit is equal to 0 after Standby or reset until the PVDE bit is set.
    $0d constant PWR_AVDO                       \ [0x0d] Analog voltage detector output on VDDA This bit is set and cleared by hardware. It is valid only if AVD on VDDA is enabled by the AVDEN bit. Note: Since the AVD is disabled in Standby mode, this bit is equal to 0 after Standby or reset until the AVDEN bit is set
  [then]


  [ifdef] PWR_PWR_CSR1_DEF
    \
    \ @brief PWR control status register 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant PWR_BREN                       \ [0x00] Backup regulator enable When set, the backup regulator (used to maintain the backup RAM content in Standby and V<sub>BAT</sub> modes) is enabled. If BREN is reset, the backup regulator is switched off. The backup RAM can still be used in Run and Stop modes. However, its content will be lost in Standby and V<sub>BAT</sub> modes. If BREN is set, the application must wait till the backup regulator ready flag (BRRDY) is set to indicate that the data written into the SRAM will be maintained in Standby and V<sub>BAT</sub> modes.
    $04 constant PWR_MONEN                      \ [0x04] V<sub>BAT</sub> and temperature monitoring enable When set, the V<sub>BAT</sub> supply and temperature monitoring is enabled. Note: V<sub>BAT</sub> and temperature monitoring are only available when the backup regulator is enabled (BREN bit set to 1).
    $10 constant PWR_BRRDY                      \ [0x10] Backup regulator ready This bit is set by hardware to indicate that the backup regulator is ready.
    $14 constant PWR_VBATL                      \ [0x14] V<sub>BAT</sub> level monitoring versus low threshold
    $15 constant PWR_VBATH                      \ [0x15] V<sub>BAT</sub> level monitoring versus high threshold
    $16 constant PWR_TEMPL                      \ [0x16] Temperature level monitoring versus low threshold
    $17 constant PWR_TEMPH                      \ [0x17] Temperature level monitoring versus high threshold
  [then]


  [ifdef] PWR_PWR_CSR2_DEF
    \
    \ @brief PWR control register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000006
    \
    $00 constant PWR_BYPASS                     \ [0x00] Power management unit bypass Note: Illegal combinations of SDHILEVEL, SMPSEXTHP, SDEN, LDOEN and BYPASS are described in Table 41.
    $01 constant PWR_LDOEN                      \ [0x01] Low drop-out regulator enable Note: Illegal combinations of SDHILEVEL, SMPSEXTHP, SDEN, LDOEN and BYPASS are described in Table 41.
    $02 constant PWR_SDEN                       \ [0x02] SMPS step-down converter enable Note: Illegal combinations of SDHILEVEL, SMPSEXTHP, SDEN, LDOEN and BYPASS are described in Table 41.
    $03 constant PWR_SMPSEXTHP                  \ [0x03] SMPS external power delivery selection Note: Illegal combinations of SDHILEVEL, SMPSEXTHP, SDEN, LDOEN and BYPASS are described in Table 41.
    $04 constant PWR_SDHILEVEL                  \ [0x04] SMPS step-down converter voltage output for LDO or external supply This bit is used when both the LDO and SMPS step-down converter are enabled with SDEN and LDOEN enabled or when SMPSEXTHP is enabled. In this case SDHILEVEL has to be set to 1 to confirm the regulator settings
    $08 constant PWR_VBE                        \ [0x08] VBAT charging enable
    $09 constant PWR_VBRS                       \ [0x09] VBAT charging resistor selection
    $0a constant PWR_XSPICAP1                   \ [0x0a : 2] XSPI port 1 capacitor control bits see the product datasheet for more details
    $0c constant PWR_XSPICAP2                   \ [0x0c : 2] XSPI port 2 capacitor control bits see the product datasheet for more details
    $0e constant PWR_EN_XSPIM1                  \ [0x0e] EN_XSPIM1: this bit allow the SW to enable the XSPI interface. The XSPIM_P1 supply must be stable prior to setting this bit.
    $0f constant PWR_EN_XSPIM2                  \ [0x0f] EN_XSPIM2: this bit allows the SW to enable the XSPI interface, when available. The XSPIM_P2 supply must be stable prior to setting this bit. It should also be set when FMC is used.
    $10 constant PWR_SDEXTRDY                   \ [0x10] SMPS step-down converter external supply ready This bit is set by hardware to indicate that the external supply from the SMPS step-down converter is ready.
    $18 constant PWR_USB33DEN                   \ [0x18] VDD33_USB voltage level detector enable
    $19 constant PWR_USBREGEN                   \ [0x19] USB regulator enable.
    $1a constant PWR_USB33RDY                   \ [0x1a] USB supply ready.
    $1b constant PWR_USBHSREGEN                 \ [0x1b] USB HS regulator enable.
  [then]


  [ifdef] PWR_PWR_CSR3_DEF
    \
    \ @brief PWR CPU control register 3
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PDDS                       \ [0x00] Power Down Deepsleep. This bit allows CPU to define the Deepsleep mode
    $01 constant PWR_CSSF                       \ [0x01] Clear Standby and Stop flags (always read as 0) This bit is cleared to 0 by hardware.
    $08 constant PWR_STOPF                      \ [0x08] STOP flag This bit is set by hardware and cleared only by any reset or by setting the CPU CSSF bit.
    $09 constant PWR_SBF                        \ [0x09] System Standby flag This bit is set by hardware and cleared only by a POR (Power-on Reset) or by setting the CPU CSSF bit
  [then]


  [ifdef] PWR_PWR_CSR4_DEF
    \
    \ @brief PWR control status register 4
    \ Address offset: 0x14
    \ Reset value: 0x00000002
    \
    $00 constant PWR_VOS                        \ [0x00] Voltage scaling selection according to performance These bits control the V<sub>CORE</sub> voltage level and allow to obtains the best trade-off between power consumption and performance: When increasing the performance, the voltage scaling must be changed before increasing the system frequency. When decreasing performance, the system frequency must first be decreased before changing the voltage scaling. Note: Refer to Section Electrical characteristics of the product datasheet for more details.
    $01 constant PWR_VOSRDY                     \ [0x01] VOS Ready bit
  [then]


  [ifdef] PWR_PWR_WKUPCR_DEF
    \
    \ @brief PWR wakeup clear register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WKUPC1                     \ [0x00] Clear Wakeup pin flag for WKUP1 These bits are always read as 0.
    $01 constant PWR_WKUPC2                     \ [0x01] Clear Wakeup pin flag for WKUP2 These bits are always read as 0.
    $02 constant PWR_WKUPC3                     \ [0x02] Clear Wakeup pin flag for WKUP3 These bits are always read as 0.
    $03 constant PWR_WKUPC4                     \ [0x03] Clear Wakeup pin flag for WKUP4 These bits are always read as 0.
  [then]


  [ifdef] PWR_PWR_WKUPFR_DEF
    \
    \ @brief PWR wakeup flag register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WKUPF1                     \ [0x00] Wakeup pin WKUP1 flag. This bit is set by hardware and cleared only by a Reset pin or by setting the WKUPC1 bit in the PWR wakeup clear register (PWR_WKUPCR).
    $01 constant PWR_WKUPF2                     \ [0x01] Wakeup pin WKUP2 flag. This bit is set by hardware and cleared only by a Reset pin or by setting the WKUPC2 bit in the PWR wakeup clear register (PWR_WKUPCR).
    $02 constant PWR_WKUPF3                     \ [0x02] Wakeup pin WKUP3 flag. This bit is set by hardware and cleared only by a Reset pin or by setting the WKUPC3 bit in the PWR wakeup clear register (PWR_WKUPCR).
    $03 constant PWR_WKUPF4                     \ [0x03] Wakeup pin WKUP4 flag. This bit is set by hardware and cleared only by a Reset pin or by setting the WKUPC4 bit in the PWR wakeup clear register (PWR_WKUPCR).
  [then]


  [ifdef] PWR_PWR_WKUPEPR_DEF
    \
    \ @brief PWR wakeup enable and polarity register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant PWR_WKUPEN1                    \ [0x00] Enable Wakeup Pin WKUPn, (n = 4, 3, 2, 1) Each bit is set and cleared by software. Note: An additional wakeup event is detected if WKUPn+1 pin is enabled (by setting the WKUPENn bit) when WKUPn pin level is already high when WKUPPn+1 selects rising edge, or low when WKUPPn selects falling edge.
    $01 constant PWR_WKUPEN2                    \ [0x01] Enable Wakeup Pin WKUPn, (n = 4, 3, 2, 1) Each bit is set and cleared by software. Note: An additional wakeup event is detected if WKUPn+1 pin is enabled (by setting the WKUPENn bit) when WKUPn pin level is already high when WKUPPn+1 selects rising edge, or low when WKUPPn selects falling edge.
    $02 constant PWR_WKUPEN3                    \ [0x02] Enable Wakeup Pin WKUPn, (n = 4, 3, 2, 1) Each bit is set and cleared by software. Note: An additional wakeup event is detected if WKUPn+1 pin is enabled (by setting the WKUPENn bit) when WKUPn pin level is already high when WKUPPn+1 selects rising edge, or low when WKUPPn selects falling edge.
    $03 constant PWR_WKUPEN4                    \ [0x03] Enable Wakeup Pin WKUPn, (n = 4, 3, 2, 1) Each bit is set and cleared by software. Note: An additional wakeup event is detected if WKUPn+1 pin is enabled (by setting the WKUPENn bit) when WKUPn pin level is already high when WKUPPn+1 selects rising edge, or low when WKUPPn selects falling edge.
    $08 constant PWR_WKUPP1                     \ [0x08] Wakeup pin polarity bit for WKUPn, (n = 4, 3, 2, 1) These bits define the polarity used for event detection on WKUPn external wakeup pin.
    $09 constant PWR_WKUPP2                     \ [0x09] Wakeup pin polarity bit for WKUPn, (n = 4, 3, 2, 1) These bits define the polarity used for event detection on WKUPn external wakeup pin.
    $0a constant PWR_WKUPP3                     \ [0x0a] Wakeup pin polarity bit for WKUPn, (n = 4, 3, 2, 1) These bits define the polarity used for event detection on WKUPn external wakeup pin.
    $0b constant PWR_WKUPP4                     \ [0x0b] Wakeup pin polarity bit for WKUPn, (n = 4, 3, 2, 1) These bits define the polarity used for event detection on WKUPn external wakeup pin.
    $10 constant PWR_WKUPPUPD1                  \ [0x10 : 2] Wakeup pin pull configuration for WKUPn, These bits define the I/O pad pull configuration used when WKUPENn = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The Wakeup pin pull configuration is kept in Standby mode.
    $12 constant PWR_WKUPPUPD2                  \ [0x12 : 2] Wakeup pin pull configuration for WKUPn, These bits define the I/O pad pull configuration used when WKUPENn = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The Wakeup pin pull configuration is kept in Standby mode.
    $14 constant PWR_WKUPPUPD3                  \ [0x14 : 2] Wakeup pin pull configuration for WKUPn, These bits define the I/O pad pull configuration used when WKUPENn = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The Wakeup pin pull configuration is kept in Standby mode.
    $16 constant PWR_WKUPPUPD4                  \ [0x16 : 2] Wakeup pin pull configuration for WKUPn, These bits define the I/O pad pull configuration used when WKUPENn = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The Wakeup pin pull configuration is kept in Standby mode.
  [then]


  [ifdef] PWR_PWR_UCPDR_DEF
    \
    \ @brief PWR USB Type-C and Power Delivery register
    \ Address offset: 0x2C
    \ Reset value: 0x00000002
    \
    $00 constant PWR_UCPD_DBDIS                 \ [0x00] UCPD dead battery disable
    $01 constant PWR_UCPD_STBY                  \ [0x01] UCPD Standby mode When set, this bit is used to memorize the UCPD configuration in Standby mode. This bit must be written to 1 just before entering Standby mode when using UCPD. It must be written to 0 after exiting the Standby mode and before writing any UCPD registers.
  [then]


  [ifdef] PWR_PWR_APCR_DEF
    \
    \ @brief PWR apply pull configuration register
    \ Address offset: 0x30
    \ Reset value: 0x00030000
    \
    $00 constant PWR_APC                        \ [0x00] Apply pull-up and pull-down configuration When this bit is set, the I/O pull-up and pull-down configurations defined in PO5_PUPD, PN7_PUPD bits and PUCRx, PDCRx registers are applied in Standby mode even after wakeup until APC bit is reset to 0. When this bit is cleared, the I/O pull-up or pull-down configurations defined in PO5_PUPD, PN7_PUPD bits and PUCRx and PDCRx registers are not applied in Standby mode and IO becomes Hi-Z.
    $10 constant PWR_PN7_PUPD                   \ [0x10] Port N bit 7 pull-up/down configuration When this bit is set, a weak pull-up or pull-down resistor is applied on PN7 following inverse logic applied on PN6. If the PUN6 bit in PWR_PUCRN register is set and APC bit is set the week pull-down is applied on PN7. If the PDN6 bit in PWR_PDCRN register is set and APC bit is set the week pull-up is applied on PN7.
    $11 constant PWR_PO5_PUPD                   \ [0x11] Port O bit 5 pull-up/down configuration When this bit is set, a weak pull-up or pull down resistor is applied on PO5 following inverse logic applied on PO4. If the PUO4 bit in PWR_PUCRO register is set and APC bit is set the week pull-down is applied on PO5. If the PDO4 bit in PWR_PDCRO register is set and APC bit is set the week pull-up is applied on PO5..
    $1c constant PWR_I3CPB6_PU                  \ [0x1c] Port PB6 I3C pull-up bit When I3C is used on PB6, when set, this bit activates the pull-up on I3C1_SCL (PB6) in standby mode.
    $1d constant PWR_I3CPB7_PU                  \ [0x1d] Port PB7 I3C pull-up bit When I3C is used on PB7, when set, this bit activates the pull-up on I3C1_SDA (PB7) in standby mode.
    $1e constant PWR_I3CPB8_PU                  \ [0x1e] Port PB8 I3C pull-up bit When I3C is used on PB8, when set, this bit activates the pull-up on I3C1_SCL (PB8) in standby mode.
    $1f constant PWR_I3CPB9_PU                  \ [0x1f] Port PB9 I3C pull-up bit When I3C is used on PB9, when set, this bit activates the pull-up on I3C1_SDA (PB9) in standby mode.
  [then]


  [ifdef] PWR_PWR_PUCRN_DEF
    \
    \ @brief PWR port N pull-up control register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $01 constant PWR_PUN1                       \ [0x01] Port N pull-up bit 1 When set, each bit activates the pull-up on PN1 when the APC bit is set in PWR_APCR. The pull-up is not activated if the corresponding PD1 bit is also set.
    $06 constant PWR_PUN6                       \ [0x06] Port N pull-up bit 6 When set activates the pull-up on PN6 when the APC bit is set in PWR_APCR. The pull-up is not activated if the corresponding PDN6 bit is also set.
    $0c constant PWR_PUN12                      \ [0x0c] Port N pull-up bit 12 When set, each bit activates the pull-up on PN12 when the APC bit is set in PWR_APCR. The pull-up is not activated if the corresponding PD12 bit is also set.
  [then]


  [ifdef] PWR_PWR_PDCRN_DEF
    \
    \ @brief PWR port N pull-down control register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PDN0                       \ [0x00] Port N pull-down bit 0 When set activates the pull-down on PN0 when the APC bit is set in PWR_APCR.
    $01 constant PWR_PDN1                       \ [0x01] Port N pull-down bit 1 When set activates the pull-down on PN1 when the APC bit is set in PWR_APCR.
    $02 constant PWR_PDN2N5                     \ [0x02] Port N PN2 to PN5 pull-down activation When set, four pull-down resistors are activated on PN2 to PN5 when the APC bit is set in PWR_APCR.
    $06 constant PWR_PDN6                       \ [0x06] Port N pull-down bit 6 When set activates the pull-down on PN6 when the APC bit is set in PWR_APCR.
    $08 constant PWR_PDN8N11                    \ [0x08] Port N - PN8 to PN11 pull-down activation When set, four pull-down resistors are activated on PN8 to PN11 when the APC bit is set in PWR_APCR.
    $0c constant PWR_PDN12                      \ [0x0c] Port N pull-down bit 12 When set activates the pull-down on PN12 when the APC bit is set in PWR_APCR.
  [then]


  [ifdef] PWR_PWR_PUCRO_DEF
    \
    \ @brief PWR port O pull-up control register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PUO0                       \ [0x00] (n = 1 to 0) Port O pull-up bits When set, each bit activates the pull-up on POy when the APC bit is set in PWR_APCR. The pull-up is not activated if the corresponding bits in PWR_PDCRO is also set.
    $01 constant PWR_PUO1                       \ [0x01] (n = 1 to 0) Port O pull-up bits When set, each bit activates the pull-up on POy when the APC bit is set in PWR_APCR. The pull-up is not activated if the corresponding bits in PWR_PDCRO is also set.
    $04 constant PWR_PUO4                       \ [0x04] Port O pull-up bit 4 When set activates the pull-up on PO4 when the APC bit is set in PWR_APCR. The pull-up is not activated if the corresponding bits PDO4 in PWR_PDCRO is also set.
  [then]


  [ifdef] PWR_PWR_PDCRO_DEF
    \
    \ @brief PWR port O pull-down control register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PDO0                       \ [0x00] Port O pull-down bit y When set, each bit activates the pull-down on POy when the APC bit is set in PWR_APCR.
    $01 constant PWR_PDO1                       \ [0x01] Port O pull-down bit y When set, each bit activates the pull-down on POy when the APC bit is set in PWR_APCR.
    $02 constant PWR_PDO2                       \ [0x02] Port O pull-down bit y When set, each bit activates the pull-down on POy when the APC bit is set in PWR_APCR.
    $03 constant PWR_PDO3                       \ [0x03] Port O pull-down bit y When set, each bit activates the pull-down on POy when the APC bit is set in PWR_APCR.
    $04 constant PWR_PDO4                       \ [0x04] Port O pull-down bit y When set, each bit activates the pull-down on POy when the APC bit is set in PWR_APCR.
  [then]


  [ifdef] PWR_PWR_PDCRP_DEF
    \
    \ @brief PWR port P pull-down control register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant PWR_PDP0P3                     \ [0x00] Port P0-P3 pull-down activation When set, four pull-down resistors are activated on P0 to P3 when the APC bit is set in PWR_APCR.
    $04 constant PWR_PDP4P7                     \ [0x04] Port P4-P7 pull-down activation When set, four pull-down resitors are activated on P4 to P7 when the APC bit is set in PWR_APCR.
    $08 constant PWR_PDP8P11                    \ [0x08] Port P8-P11 pull-down activation When set, four pull-down resistors are activated on P8 to P11 when the APC bit is set in PWR_APCR.
    $0c constant PWR_PDP12P15                   \ [0x0c] Port P12-P15 pull-down activation When set, four pull-down resistors are activated on P8 to P11 when the APC bit is set in PWR_APCR.
  [then]


  [ifdef] PWR_PWR_PDR1_DEF
    \
    \ @brief PWR debug register 1
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant PWR_UNLOCKED                   \ [0x00] Debug Register Unlocked.
    $03 constant PWR_SDFPWMEN                   \ [0x03] Step down converter force PWM mode
    $10 constant PWR_SYNC_ADC                   \ [0x10] (Non-User bit)
  [then]

  \
  \ @brief Power control
  \
  $00 constant PWR_PWR_CR1              \ PWR control register 1
  $04 constant PWR_PWR_SR1              \ PWR control status register 1
  $08 constant PWR_PWR_CSR1             \ PWR control status register 1
  $0C constant PWR_PWR_CSR2             \ PWR control register 2
  $10 constant PWR_PWR_CSR3             \ PWR CPU control register 3
  $14 constant PWR_PWR_CSR4             \ PWR control status register 4
  $20 constant PWR_PWR_WKUPCR           \ PWR wakeup clear register
  $24 constant PWR_PWR_WKUPFR           \ PWR wakeup flag register
  $28 constant PWR_PWR_WKUPEPR          \ PWR wakeup enable and polarity register
  $2C constant PWR_PWR_UCPDR            \ PWR USB Type-C and Power Delivery register
  $30 constant PWR_PWR_APCR             \ PWR apply pull configuration register
  $34 constant PWR_PWR_PUCRN            \ PWR port N pull-up control register
  $38 constant PWR_PWR_PDCRN            \ PWR port N pull-down control register
  $3C constant PWR_PWR_PUCRO            \ PWR port O pull-up control register
  $40 constant PWR_PWR_PDCRO            \ PWR port O pull-down control register
  $44 constant PWR_PWR_PDCRP            \ PWR port P pull-down control register
  $50 constant PWR_PWR_PDR1             \ PWR debug register 1

: PWR_DEF ; [then]
