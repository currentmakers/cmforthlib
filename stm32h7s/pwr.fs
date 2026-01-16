\
\ @file pwr.fs
\ @brief Power control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief PWR control register 1
\ Address offset: 0x00
\ Reset value: 0x00000001
\

$00000001 constant PWR_PWR_CR1_SVOS                                 \ System Stop mode voltage scaling selection.
$00000010 constant PWR_PWR_CR1_PVDE                                 \ Programmable voltage detector enable
$000000e0 constant PWR_PWR_CR1_PLS                                  \ Programmable voltage detector level selection These bits select the voltage threshold detected by the PVD. Note: Refer to Section Electrical characteristics of the product datasheet for more details.
$00000100 constant PWR_PWR_CR1_DBP                                  \ Disable backup domain write protection In reset state, the RCC_BDCR register, the RTC registers (including the backup registers), BREN and MOEN bits in the PWR_CSR1 register, are protected against parasitic write access. This bit must be set to enable write access to these registers.
$00000200 constant PWR_PWR_CR1_FLPS                                 \ Flash low-power mode in Stop mode This bit allows to obtain the best trade-off between low-power consumption and restart time when exiting from Stop mode. When it is set, the Flash memory enters low-power mode when device is in Stop mode. consumption).
$00000400 constant PWR_PWR_CR1_RLPSN                                \ RAM low power mode disable in STOP. When set the RAMs will not enter to low power mode when the system enters to STOP.
$00000800 constant PWR_PWR_CR1_BOOSTE                               \ analog switch VBoost control This bit enables the booster to guarantee the analog switch AC performance when the VDD supply voltage is below 2.7 V (reduction of the total harmonic distortion to have the same switch performance over the full supply voltage range) The VDD supply voltage can be monitored through the PVD and the PLS bits.
$00001000 constant PWR_PWR_CR1_AVDREADY                             \ analog voltage ready This bit is only used when the analog switch boost needs to be enabled (see BOOSTE bit). It must be set by software when the expected VDDA analog supply level is available. The correct analog supply level is indicated by the AVDO bit (PWR_CSR1 register) after setting the AVDEN bit and selecting the supply level to be monitored (ALS bits).
$00002000 constant PWR_PWR_CR1_AVDEN                                \ Peripheral voltage monitor on VDDA enable
$0000c000 constant PWR_PWR_CR1_ALS                                  \ Analog voltage detector level selection These bits select the voltage threshold detected by the AVD. Note: Refer to Section Electrical characteristics of the product datasheet for more details.


\
\ @brief PWR control status register 1
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_SR1_ACTVOS                               \ VOS currently applied for V<sub>CORE</sub> voltage scaling selection. These bit reflect the last VOS value applied to the PMU.
$00000002 constant PWR_PWR_SR1_ACTVOSRDY                            \ Voltage levels ready bit for currently used ACTVOS and SDHILEVEL This bit is set to 1 by hardware when the voltage regulator and the SMPS step-down converter are both disabled and Bypass mode is selected in PWR control register 2 (PWR_CSR2).
$00000010 constant PWR_PWR_SR1_PVDO                                 \ Programmable voltage detect output This bit is set and cleared by hardware. It is valid only if the PVD has been enabled by the PVDE bit. PLS[2:0] bits. bits. Note: Since the PVD is disabled in Standby mode, this bit is equal to 0 after Standby or reset until the PVDE bit is set.
$00002000 constant PWR_PWR_SR1_AVDO                                 \ Analog voltage detector output on VDDA This bit is set and cleared by hardware. It is valid only if AVD on VDDA is enabled by the AVDEN bit. Note: Since the AVD is disabled in Standby mode, this bit is equal to 0 after Standby or reset until the AVDEN bit is set


\
\ @brief PWR control status register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_CSR1_BREN                                \ Backup regulator enable When set, the backup regulator (used to maintain the backup RAM content in Standby and V<sub>BAT</sub> modes) is enabled. If BREN is reset, the backup regulator is switched off. The backup RAM can still be used in Run and Stop modes. However, its content will be lost in Standby and V<sub>BAT</sub> modes. If BREN is set, the application must wait till the backup regulator ready flag (BRRDY) is set to indicate that the data written into the SRAM will be maintained in Standby and V<sub>BAT</sub> modes.
$00000010 constant PWR_PWR_CSR1_MONEN                               \ V<sub>BAT</sub> and temperature monitoring enable When set, the V<sub>BAT</sub> supply and temperature monitoring is enabled. Note: V<sub>BAT</sub> and temperature monitoring are only available when the backup regulator is enabled (BREN bit set to 1).
$00010000 constant PWR_PWR_CSR1_BRRDY                               \ Backup regulator ready This bit is set by hardware to indicate that the backup regulator is ready.
$00100000 constant PWR_PWR_CSR1_VBATL                               \ V<sub>BAT</sub> level monitoring versus low threshold
$00200000 constant PWR_PWR_CSR1_VBATH                               \ V<sub>BAT</sub> level monitoring versus high threshold
$00400000 constant PWR_PWR_CSR1_TEMPL                               \ Temperature level monitoring versus low threshold
$00800000 constant PWR_PWR_CSR1_TEMPH                               \ Temperature level monitoring versus high threshold


\
\ @brief PWR control register 2
\ Address offset: 0x0C
\ Reset value: 0x00000006
\

$00000001 constant PWR_PWR_CSR2_BYPASS                              \ Power management unit bypass Note: Illegal combinations of SDHILEVEL, SMPSEXTHP, SDEN, LDOEN and BYPASS are described in Table 41.
$00000002 constant PWR_PWR_CSR2_LDOEN                               \ Low drop-out regulator enable Note: Illegal combinations of SDHILEVEL, SMPSEXTHP, SDEN, LDOEN and BYPASS are described in Table 41.
$00000004 constant PWR_PWR_CSR2_SDEN                                \ SMPS step-down converter enable Note: Illegal combinations of SDHILEVEL, SMPSEXTHP, SDEN, LDOEN and BYPASS are described in Table 41.
$00000008 constant PWR_PWR_CSR2_SMPSEXTHP                           \ SMPS external power delivery selection Note: Illegal combinations of SDHILEVEL, SMPSEXTHP, SDEN, LDOEN and BYPASS are described in Table 41.
$00000010 constant PWR_PWR_CSR2_SDHILEVEL                           \ SMPS step-down converter voltage output for LDO or external supply This bit is used when both the LDO and SMPS step-down converter are enabled with SDEN and LDOEN enabled or when SMPSEXTHP is enabled. In this case SDHILEVEL has to be set to 1 to confirm the regulator settings
$00000100 constant PWR_PWR_CSR2_VBE                                 \ VBAT charging enable
$00000200 constant PWR_PWR_CSR2_VBRS                                \ VBAT charging resistor selection
$00000c00 constant PWR_PWR_CSR2_XSPICAP1                            \ XSPI port 1 capacitor control bits see the product datasheet for more details
$00003000 constant PWR_PWR_CSR2_XSPICAP2                            \ XSPI port 2 capacitor control bits see the product datasheet for more details
$00004000 constant PWR_PWR_CSR2_EN_XSPIM1                           \ EN_XSPIM1: this bit allow the SW to enable the XSPI interface. The XSPIM_P1 supply must be stable prior to setting this bit.
$00008000 constant PWR_PWR_CSR2_EN_XSPIM2                           \ EN_XSPIM2: this bit allows the SW to enable the XSPI interface, when available. The XSPIM_P2 supply must be stable prior to setting this bit. It should also be set when FMC is used.
$00010000 constant PWR_PWR_CSR2_SDEXTRDY                            \ SMPS step-down converter external supply ready This bit is set by hardware to indicate that the external supply from the SMPS step-down converter is ready.
$01000000 constant PWR_PWR_CSR2_USB33DEN                            \ VDD33_USB voltage level detector enable
$02000000 constant PWR_PWR_CSR2_USBREGEN                            \ USB regulator enable.
$04000000 constant PWR_PWR_CSR2_USB33RDY                            \ USB supply ready.
$08000000 constant PWR_PWR_CSR2_USBHSREGEN                          \ USB HS regulator enable.


\
\ @brief PWR CPU control register 3
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_CSR3_PDDS                                \ Power Down Deepsleep. This bit allows CPU to define the Deepsleep mode
$00000002 constant PWR_PWR_CSR3_CSSF                                \ Clear Standby and Stop flags (always read as 0) This bit is cleared to 0 by hardware.
$00000100 constant PWR_PWR_CSR3_STOPF                               \ STOP flag This bit is set by hardware and cleared only by any reset or by setting the CPU CSSF bit.
$00000200 constant PWR_PWR_CSR3_SBF                                 \ System Standby flag This bit is set by hardware and cleared only by a POR (Power-on Reset) or by setting the CPU CSSF bit


\
\ @brief PWR control status register 4
\ Address offset: 0x14
\ Reset value: 0x00000002
\

$00000001 constant PWR_PWR_CSR4_VOS                                 \ Voltage scaling selection according to performance These bits control the V<sub>CORE</sub> voltage level and allow to obtains the best trade-off between power consumption and performance: When increasing the performance, the voltage scaling must be changed before increasing the system frequency. When decreasing performance, the system frequency must first be decreased before changing the voltage scaling. Note: Refer to Section Electrical characteristics of the product datasheet for more details.
$00000002 constant PWR_PWR_CSR4_VOSRDY                              \ VOS Ready bit


\
\ @brief PWR wakeup clear register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WKUPCR_WKUPC1                            \ Clear Wakeup pin flag for WKUP1 These bits are always read as 0.
$00000002 constant PWR_PWR_WKUPCR_WKUPC2                            \ Clear Wakeup pin flag for WKUP2 These bits are always read as 0.
$00000004 constant PWR_PWR_WKUPCR_WKUPC3                            \ Clear Wakeup pin flag for WKUP3 These bits are always read as 0.
$00000008 constant PWR_PWR_WKUPCR_WKUPC4                            \ Clear Wakeup pin flag for WKUP4 These bits are always read as 0.


\
\ @brief PWR wakeup flag register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WKUPFR_WKUPF1                            \ Wakeup pin WKUP1 flag. This bit is set by hardware and cleared only by a Reset pin or by setting the WKUPC1 bit in the PWR wakeup clear register (PWR_WKUPCR).
$00000002 constant PWR_PWR_WKUPFR_WKUPF2                            \ Wakeup pin WKUP2 flag. This bit is set by hardware and cleared only by a Reset pin or by setting the WKUPC2 bit in the PWR wakeup clear register (PWR_WKUPCR).
$00000004 constant PWR_PWR_WKUPFR_WKUPF3                            \ Wakeup pin WKUP3 flag. This bit is set by hardware and cleared only by a Reset pin or by setting the WKUPC3 bit in the PWR wakeup clear register (PWR_WKUPCR).
$00000008 constant PWR_PWR_WKUPFR_WKUPF4                            \ Wakeup pin WKUP4 flag. This bit is set by hardware and cleared only by a Reset pin or by setting the WKUPC4 bit in the PWR wakeup clear register (PWR_WKUPCR).


\
\ @brief PWR wakeup enable and polarity register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WKUPEPR_WKUPEN1                          \ Enable Wakeup Pin WKUPn, (n = 4, 3, 2, 1) Each bit is set and cleared by software. Note: An additional wakeup event is detected if WKUPn+1 pin is enabled (by setting the WKUPENn bit) when WKUPn pin level is already high when WKUPPn+1 selects rising edge, or low when WKUPPn selects falling edge.
$00000002 constant PWR_PWR_WKUPEPR_WKUPEN2                          \ Enable Wakeup Pin WKUPn, (n = 4, 3, 2, 1) Each bit is set and cleared by software. Note: An additional wakeup event is detected if WKUPn+1 pin is enabled (by setting the WKUPENn bit) when WKUPn pin level is already high when WKUPPn+1 selects rising edge, or low when WKUPPn selects falling edge.
$00000004 constant PWR_PWR_WKUPEPR_WKUPEN3                          \ Enable Wakeup Pin WKUPn, (n = 4, 3, 2, 1) Each bit is set and cleared by software. Note: An additional wakeup event is detected if WKUPn+1 pin is enabled (by setting the WKUPENn bit) when WKUPn pin level is already high when WKUPPn+1 selects rising edge, or low when WKUPPn selects falling edge.
$00000008 constant PWR_PWR_WKUPEPR_WKUPEN4                          \ Enable Wakeup Pin WKUPn, (n = 4, 3, 2, 1) Each bit is set and cleared by software. Note: An additional wakeup event is detected if WKUPn+1 pin is enabled (by setting the WKUPENn bit) when WKUPn pin level is already high when WKUPPn+1 selects rising edge, or low when WKUPPn selects falling edge.
$00000100 constant PWR_PWR_WKUPEPR_WKUPP1                           \ Wakeup pin polarity bit for WKUPn, (n = 4, 3, 2, 1) These bits define the polarity used for event detection on WKUPn external wakeup pin.
$00000200 constant PWR_PWR_WKUPEPR_WKUPP2                           \ Wakeup pin polarity bit for WKUPn, (n = 4, 3, 2, 1) These bits define the polarity used for event detection on WKUPn external wakeup pin.
$00000400 constant PWR_PWR_WKUPEPR_WKUPP3                           \ Wakeup pin polarity bit for WKUPn, (n = 4, 3, 2, 1) These bits define the polarity used for event detection on WKUPn external wakeup pin.
$00000800 constant PWR_PWR_WKUPEPR_WKUPP4                           \ Wakeup pin polarity bit for WKUPn, (n = 4, 3, 2, 1) These bits define the polarity used for event detection on WKUPn external wakeup pin.
$00030000 constant PWR_PWR_WKUPEPR_WKUPPUPD1                        \ Wakeup pin pull configuration for WKUPn, These bits define the I/O pad pull configuration used when WKUPENn = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The Wakeup pin pull configuration is kept in Standby mode.
$000c0000 constant PWR_PWR_WKUPEPR_WKUPPUPD2                        \ Wakeup pin pull configuration for WKUPn, These bits define the I/O pad pull configuration used when WKUPENn = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The Wakeup pin pull configuration is kept in Standby mode.
$00300000 constant PWR_PWR_WKUPEPR_WKUPPUPD3                        \ Wakeup pin pull configuration for WKUPn, These bits define the I/O pad pull configuration used when WKUPENn = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The Wakeup pin pull configuration is kept in Standby mode.
$00c00000 constant PWR_PWR_WKUPEPR_WKUPPUPD4                        \ Wakeup pin pull configuration for WKUPn, These bits define the I/O pad pull configuration used when WKUPENn = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The Wakeup pin pull configuration is kept in Standby mode.


\
\ @brief PWR USB Type-C and Power Delivery register
\ Address offset: 0x2C
\ Reset value: 0x00000002
\

$00000001 constant PWR_PWR_UCPDR_UCPD_DBDIS                         \ UCPD dead battery disable
$00000002 constant PWR_PWR_UCPDR_UCPD_STBY                          \ UCPD Standby mode When set, this bit is used to memorize the UCPD configuration in Standby mode. This bit must be written to 1 just before entering Standby mode when using UCPD. It must be written to 0 after exiting the Standby mode and before writing any UCPD registers.


\
\ @brief PWR apply pull configuration register
\ Address offset: 0x30
\ Reset value: 0x00030000
\

$00000001 constant PWR_PWR_APCR_APC                                 \ Apply pull-up and pull-down configuration When this bit is set, the I/O pull-up and pull-down configurations defined in PO5_PUPD, PN7_PUPD bits and PUCRx, PDCRx registers are applied in Standby mode even after wakeup until APC bit is reset to 0. When this bit is cleared, the I/O pull-up or pull-down configurations defined in PO5_PUPD, PN7_PUPD bits and PUCRx and PDCRx registers are not applied in Standby mode and IO becomes Hi-Z.
$00010000 constant PWR_PWR_APCR_PN7_PUPD                            \ Port N bit 7 pull-up/down configuration When this bit is set, a weak pull-up or pull-down resistor is applied on PN7 following inverse logic applied on PN6. If the PUN6 bit in PWR_PUCRN register is set and APC bit is set the week pull-down is applied on PN7. If the PDN6 bit in PWR_PDCRN register is set and APC bit is set the week pull-up is applied on PN7.
$00020000 constant PWR_PWR_APCR_PO5_PUPD                            \ Port O bit 5 pull-up/down configuration When this bit is set, a weak pull-up or pull down resistor is applied on PO5 following inverse logic applied on PO4. If the PUO4 bit in PWR_PUCRO register is set and APC bit is set the week pull-down is applied on PO5. If the PDO4 bit in PWR_PDCRO register is set and APC bit is set the week pull-up is applied on PO5..
$10000000 constant PWR_PWR_APCR_I3CPB6_PU                           \ Port PB6 I3C pull-up bit When I3C is used on PB6, when set, this bit activates the pull-up on I3C1_SCL (PB6) in standby mode.
$20000000 constant PWR_PWR_APCR_I3CPB7_PU                           \ Port PB7 I3C pull-up bit When I3C is used on PB7, when set, this bit activates the pull-up on I3C1_SDA (PB7) in standby mode.
$40000000 constant PWR_PWR_APCR_I3CPB8_PU                           \ Port PB8 I3C pull-up bit When I3C is used on PB8, when set, this bit activates the pull-up on I3C1_SCL (PB8) in standby mode.
$80000000 constant PWR_PWR_APCR_I3CPB9_PU                           \ Port PB9 I3C pull-up bit When I3C is used on PB9, when set, this bit activates the pull-up on I3C1_SDA (PB9) in standby mode.


\
\ @brief PWR port N pull-up control register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000002 constant PWR_PWR_PUCRN_PUN1                               \ Port N pull-up bit 1 When set, each bit activates the pull-up on PN1 when the APC bit is set in PWR_APCR. The pull-up is not activated if the corresponding PD1 bit is also set.
$00000040 constant PWR_PWR_PUCRN_PUN6                               \ Port N pull-up bit 6 When set activates the pull-up on PN6 when the APC bit is set in PWR_APCR. The pull-up is not activated if the corresponding PDN6 bit is also set.
$00001000 constant PWR_PWR_PUCRN_PUN12                              \ Port N pull-up bit 12 When set, each bit activates the pull-up on PN12 when the APC bit is set in PWR_APCR. The pull-up is not activated if the corresponding PD12 bit is also set.


\
\ @brief PWR port N pull-down control register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRN_PDN0                               \ Port N pull-down bit 0 When set activates the pull-down on PN0 when the APC bit is set in PWR_APCR.
$00000002 constant PWR_PWR_PDCRN_PDN1                               \ Port N pull-down bit 1 When set activates the pull-down on PN1 when the APC bit is set in PWR_APCR.
$00000004 constant PWR_PWR_PDCRN_PDN2N5                             \ Port N PN2 to PN5 pull-down activation When set, four pull-down resistors are activated on PN2 to PN5 when the APC bit is set in PWR_APCR.
$00000040 constant PWR_PWR_PDCRN_PDN6                               \ Port N pull-down bit 6 When set activates the pull-down on PN6 when the APC bit is set in PWR_APCR.
$00000100 constant PWR_PWR_PDCRN_PDN8N11                            \ Port N - PN8 to PN11 pull-down activation When set, four pull-down resistors are activated on PN8 to PN11 when the APC bit is set in PWR_APCR.
$00001000 constant PWR_PWR_PDCRN_PDN12                              \ Port N pull-down bit 12 When set activates the pull-down on PN12 when the APC bit is set in PWR_APCR.


\
\ @brief PWR port O pull-up control register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PUCRO_PUO0                               \ (n = 1 to 0) Port O pull-up bits When set, each bit activates the pull-up on POy when the APC bit is set in PWR_APCR. The pull-up is not activated if the corresponding bits in PWR_PDCRO is also set.
$00000002 constant PWR_PWR_PUCRO_PUO1                               \ (n = 1 to 0) Port O pull-up bits When set, each bit activates the pull-up on POy when the APC bit is set in PWR_APCR. The pull-up is not activated if the corresponding bits in PWR_PDCRO is also set.
$00000010 constant PWR_PWR_PUCRO_PUO4                               \ Port O pull-up bit 4 When set activates the pull-up on PO4 when the APC bit is set in PWR_APCR. The pull-up is not activated if the corresponding bits PDO4 in PWR_PDCRO is also set.


\
\ @brief PWR port O pull-down control register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRO_PDO0                               \ Port O pull-down bit y When set, each bit activates the pull-down on POy when the APC bit is set in PWR_APCR.
$00000002 constant PWR_PWR_PDCRO_PDO1                               \ Port O pull-down bit y When set, each bit activates the pull-down on POy when the APC bit is set in PWR_APCR.
$00000004 constant PWR_PWR_PDCRO_PDO2                               \ Port O pull-down bit y When set, each bit activates the pull-down on POy when the APC bit is set in PWR_APCR.
$00000008 constant PWR_PWR_PDCRO_PDO3                               \ Port O pull-down bit y When set, each bit activates the pull-down on POy when the APC bit is set in PWR_APCR.
$00000010 constant PWR_PWR_PDCRO_PDO4                               \ Port O pull-down bit y When set, each bit activates the pull-down on POy when the APC bit is set in PWR_APCR.


\
\ @brief PWR port P pull-down control register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDCRP_PDP0P3                             \ Port P0-P3 pull-down activation When set, four pull-down resistors are activated on P0 to P3 when the APC bit is set in PWR_APCR.
$00000010 constant PWR_PWR_PDCRP_PDP4P7                             \ Port P4-P7 pull-down activation When set, four pull-down resitors are activated on P4 to P7 when the APC bit is set in PWR_APCR.
$00000100 constant PWR_PWR_PDCRP_PDP8P11                            \ Port P8-P11 pull-down activation When set, four pull-down resistors are activated on P8 to P11 when the APC bit is set in PWR_APCR.
$00001000 constant PWR_PWR_PDCRP_PDP12P15                           \ Port P12-P15 pull-down activation When set, four pull-down resistors are activated on P8 to P11 when the APC bit is set in PWR_APCR.


\
\ @brief PWR debug register 1
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PDR1_UNLOCKED                            \ Debug Register Unlocked.
$00000008 constant PWR_PWR_PDR1_SDFPWMEN                            \ Step down converter force PWM mode
$00010000 constant PWR_PWR_PDR1_SYNC_ADC                            \ (Non-User bit)


\
\ @brief Power control
\
$58024800 constant PWR_PWR_CR1    \ offset: 0x00 : PWR control register 1
$58024804 constant PWR_PWR_SR1    \ offset: 0x04 : PWR control status register 1
$58024808 constant PWR_PWR_CSR1   \ offset: 0x08 : PWR control status register 1
$5802480c constant PWR_PWR_CSR2   \ offset: 0x0C : PWR control register 2
$58024810 constant PWR_PWR_CSR3   \ offset: 0x10 : PWR CPU control register 3
$58024814 constant PWR_PWR_CSR4   \ offset: 0x14 : PWR control status register 4
$58024820 constant PWR_PWR_WKUPCR  \ offset: 0x20 : PWR wakeup clear register
$58024824 constant PWR_PWR_WKUPFR  \ offset: 0x24 : PWR wakeup flag register
$58024828 constant PWR_PWR_WKUPEPR  \ offset: 0x28 : PWR wakeup enable and polarity register
$5802482c constant PWR_PWR_UCPDR  \ offset: 0x2C : PWR USB Type-C and Power Delivery register
$58024830 constant PWR_PWR_APCR   \ offset: 0x30 : PWR apply pull configuration register
$58024834 constant PWR_PWR_PUCRN  \ offset: 0x34 : PWR port N pull-up control register
$58024838 constant PWR_PWR_PDCRN  \ offset: 0x38 : PWR port N pull-down control register
$5802483c constant PWR_PWR_PUCRO  \ offset: 0x3C : PWR port O pull-up control register
$58024840 constant PWR_PWR_PDCRO  \ offset: 0x40 : PWR port O pull-down control register
$58024844 constant PWR_PWR_PDCRP  \ offset: 0x44 : PWR port P pull-down control register
$58024850 constant PWR_PWR_PDR1   \ offset: 0x50 : PWR debug register 1

