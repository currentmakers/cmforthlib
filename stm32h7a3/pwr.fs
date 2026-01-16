\
\ @file pwr.fs
\ @brief PWR
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief PWR control register 1
\ Address offset: 0x00
\ Reset value: 0xF000C000
\

$00000001 constant PWR_PWR_CR1_LPDS                                 \ Low-power Deepsleep with SVOS3 (SVOS4 and SVOS5 always use low-power, regardless of the setting of this bit)
$00000010 constant PWR_PWR_CR1_PVDE                                 \ Programmable voltage detector enable
$000000e0 constant PWR_PWR_CR1_PLS                                  \ Programmable voltage detector level selection These bits select the voltage threshold detected by the PVD. Note: Refer to Section Electrical characteristics of the product datasheet for more details.
$00000100 constant PWR_PWR_CR1_DBP                                  \ Disable backup domain write protection In reset state, the RCC_BDCR register, the RTC registers (including the backup registers), BREN and MOEN bits in PWR_CR2 register, are protected against parasitic write access. This bit must be set to enable write access to these registers.
$00000200 constant PWR_PWR_CR1_FLPS                                 \ Flash low-power mode in DStop mode This bit allows to obtain the best trade-off between low-power consumption and restart time when exiting from DStop mode. When it is set, the Flash memory enters low-power mode when D1 domain is in DStop mode.
$00001000 constant PWR_PWR_CR1_BOOSTE                               \ BOOSTE
$00002000 constant PWR_PWR_CR1_AVD_READY                            \ AVD_READY
$0000c000 constant PWR_PWR_CR1_SVOS                                 \ System Stop mode voltage scaling selection These bits control the VCORE voltage level in system Stop mode, to obtain the best trade-off between power consumption and performance.
$00010000 constant PWR_PWR_CR1_AVDEN                                \ Peripheral voltage monitor on VDDA enable
$00060000 constant PWR_PWR_CR1_ALS                                  \ Analog voltage detector level selection These bits select the voltage threshold detected by the AVD.
$00080000 constant PWR_PWR_CR1_AXIRAM1SO                            \ AXIRAM1SO
$00100000 constant PWR_PWR_CR1_AXIRAM2SO                            \ AXIRAM2SO
$00200000 constant PWR_PWR_CR1_AXIRAM3SO                            \ AXIRAM3SO
$00400000 constant PWR_PWR_CR1_AHBRAM1SO                            \ AHBRAM1SO
$00800000 constant PWR_PWR_CR1_AHBRAM2SO                            \ AHBRAM2SO
$01000000 constant PWR_PWR_CR1_ITCMSO                               \ ITCMSO
$02000000 constant PWR_PWR_CR1_GFXSO                                \ GFXSO
$04000000 constant PWR_PWR_CR1_HSITFSO                              \ HSITFSO
$08000000 constant PWR_PWR_CR1_SRDRAMSO                             \ SRDRAMSO


\
\ @brief PWR control status register 1
\ Address offset: 0x04
\ Reset value: 0x00004000
\

$00000010 constant PWR_PWR_CSR1_PVDO                                \ Programmable voltage detect output This bit is set and cleared by hardware. It is valid only if the PVD has been enabled by the PVDE bit. Note: since the PVD is disabled in Standby mode, this bit is equal to 0 after Standby or reset until the PVDE bit is set.
$00002000 constant PWR_PWR_CSR1_ACTVOSRDY                           \ Voltage levels ready bit for currently used VOS and SDLEVEL This bit is set to 1 by hardware when the voltage regulator and the SD converter are both disabled and Bypass mode is selected in PWR control register 3 (PWR_CR3).
$0000c000 constant PWR_PWR_CSR1_ACTVOS                              \ VOS currently applied for VCORE voltage scaling selection. These bits reflect the last VOS value applied to the PMU.
$00010000 constant PWR_PWR_CSR1_AVDO                                \ Analog voltage detector output on VDDA This bit is set and cleared by hardware. It is valid only if AVD on VDDA is enabled by the AVDEN bit. Note: Since the AVD is disabled in Standby mode, this bit is equal to 0 after Standby or reset until the AVDEN bit is set.
$00020000 constant PWR_PWR_CSR1_MMCVDO                              \ MMCVDO


\
\ @brief This register is not reset by wakeup from Standby mode, RESET signal and VDD POR. It is only reset by VSW POR and VSWRST reset. This register shall not be accessed when VSWRST bit in RCC_BDCR register resets the VSW domain.After reset, PWR_CR2 register is write-protected. Prior to modifying its content, the DBP bit in PWR_CR1 register must be set to disable the write protection.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_CR2_BREN                                 \ Backup regulator enable When set, the Backup regulator (used to maintain the backup RAM content in Standby and VBAT modes) is enabled. If BREN is reset, the backup regulator is switched off. The backup RAM can still be used in Run and Stop modes. However, its content will be lost in Standby and VBAT modes. If BREN is set, the application must wait till the Backup Regulator Ready flag (BRRDY) is set to indicate that the data written into the SRAM will be maintained in Standby and VBAT modes.
$00000010 constant PWR_PWR_CR2_MONEN                                \ VBAT and temperature monitoring enable When set, the VBAT supply and temperature monitoring is enabled.
$00010000 constant PWR_PWR_CR2_BRRDY                                \ Backup regulator ready This bit is set by hardware to indicate that the Backup regulator is ready.
$00400000 constant PWR_PWR_CR2_TEMPL                                \ Temperature level monitoring versus low threshold
$00800000 constant PWR_PWR_CR2_TEMPH                                \ Temperature level monitoring versus high threshold


\
\ @brief Reset only by POR only, not reset by wakeup from Standby mode and RESET pad. The lower byte of this register is written once after POR and shall be written before changing VOS level or ck_sys clock frequency. No limitation applies to the upper bytes.Programming data corresponding to an invalid combination of SDLEVEL, SDEXTHP, SDEN, LDOEN and BYPASS bits (see Table9) will be ignored: data will not be written, the written-once mechanism will lock the register and any further write access will be ignored. The default supply configuration will be kept and the ACTVOSRDY bit in PWR control status register 1 (PWR_CSR1) will go on indicating invalid voltage levels. The system shall be power cycled before writing a new value.
\ Address offset: 0x0C
\ Reset value: 0x00000006
\

$00000001 constant PWR_PWR_CR3_BYPASS                               \ Power management unit bypass
$00000002 constant PWR_PWR_CR3_LDOEN                                \ Low drop-out regulator enable
$00000004 constant PWR_PWR_CR3_SMPSEN                               \ SMPSEN
$00000008 constant PWR_PWR_CR3_SMPSEXTHP                            \ SMPSEXTHP
$00000030 constant PWR_PWR_CR3_SMPSLEVEL                            \ SMPSLEVEL
$00000100 constant PWR_PWR_CR3_VBE                                  \ VBAT charging enable
$00000200 constant PWR_PWR_CR3_VBRS                                 \ VBAT charging resistor selection
$00010000 constant PWR_PWR_CR3_SMPSEXTRDY                           \ SMPSEXTRDY
$01000000 constant PWR_PWR_CR3_USB33DEN                             \ VDD33USB voltage level detector enable.
$02000000 constant PWR_PWR_CR3_USBREGEN                             \ USB regulator enable.
$04000000 constant PWR_PWR_CR3_USB33RDY                             \ USB supply ready.


\
\ @brief This register allows controlling CPU1 power.
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_CPUCR_RETDS_CD                           \ RETDS_CD
$00000004 constant PWR_PWR_CPUCR_PDDS_SRD                           \ PDDS_SRD
$00000020 constant PWR_PWR_CPUCR_STOPF                              \ STOP flag This bit is set by hardware and cleared only by any reset or by setting the CPU1 CSSF bit.
$00000040 constant PWR_PWR_CPUCR_SBF                                \ System Standby flag This bit is set by hardware and cleared only by a POR (Power-on Reset) or by setting the CPU1 CSSF bit
$00000200 constant PWR_PWR_CPUCR_CSSF                               \ Clear D1 domain CPU1 Standby, Stop and HOLD flags (always read as 0) This bit is cleared to 0 by hardware.
$00000800 constant PWR_PWR_CPUCR_RUN_SRD                            \ RUN_SRD


\
\ @brief This register allows controlling D3 domain power.Following reset VOSRDY will be read 1 by software
\ Address offset: 0x18
\ Reset value: 0x00004000
\

$00002000 constant PWR_PWR_SRDCR_VOSRDY                             \ VOS Ready bit for VCORE voltage scaling output selection. This bit is set to 1 by hardware when Bypass mode is selected in PWR control register 3 (PWR_CR3).
$0000c000 constant PWR_PWR_SRDCR_VOS                                \ Voltage scaling selection according to performance These bits control the VCORE voltage level and allow to obtains the best trade-off between power consumption and performance: When increasing the performance, the voltage scaling shall be changed before increasing the system frequency. When decreasing performance, the system frequency shall first be decreased before changing the voltage scaling.


\
\ @brief reset only by system reset, not reset by wakeup from Standby mode5 wait states are required when writing this register (when clearing a WKUPF bit in PWR_WKUPFR, the AHB write access will complete after the WKUPF has been cleared).
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WKUPCR_WKUPC1                            \ Clear Wakeup pin flag for WKUP. These bits are always read as 0.
$00000002 constant PWR_PWR_WKUPCR_WKUPC2                            \ Clear Wakeup pin flag for WKUP. These bits are always read as 0.
$00000004 constant PWR_PWR_WKUPCR_WKUPC3                            \ Clear Wakeup pin flag for WKUP. These bits are always read as 0.
$00000008 constant PWR_PWR_WKUPCR_WKUPC4                            \ Clear Wakeup pin flag for WKUP. These bits are always read as 0.
$00000010 constant PWR_PWR_WKUPCR_WKUPC5                            \ Clear Wakeup pin flag for WKUP. These bits are always read as 0.
$00000020 constant PWR_PWR_WKUPCR_WKUPC6                            \ Clear Wakeup pin flag for WKUP. These bits are always read as 0.


\
\ @brief reset only by system reset, not reset by wakeup from Standby mode
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WKUPFR_WKUPF1                            \ Wakeup pin WKUPF flag. This bit is set by hardware and cleared only by a Reset pin or by setting the WKUPCn+1 bit in the PWR wakeup clear register (PWR_WKUPCR).
$00000002 constant PWR_PWR_WKUPFR_WKUPF2                            \ Wakeup pin WKUPF flag. This bit is set by hardware and cleared only by a Reset pin or by setting the WKUPCn+1 bit in the PWR wakeup clear register (PWR_WKUPCR).
$00000004 constant PWR_PWR_WKUPFR_WKUPF3                            \ Wakeup pin WKUPF flag. This bit is set by hardware and cleared only by a Reset pin or by setting the WKUPCn+1 bit in the PWR wakeup clear register (PWR_WKUPCR).
$00000008 constant PWR_PWR_WKUPFR_WKUPF4                            \ Wakeup pin WKUPF flag. This bit is set by hardware and cleared only by a Reset pin or by setting the WKUPCn+1 bit in the PWR wakeup clear register (PWR_WKUPCR).
$00000010 constant PWR_PWR_WKUPFR_WKUPF5                            \ Wakeup pin WKUPF flag. This bit is set by hardware and cleared only by a Reset pin or by setting the WKUPCn+1 bit in the PWR wakeup clear register (PWR_WKUPCR).
$00000020 constant PWR_PWR_WKUPFR_WKUPF6                            \ Wakeup pin WKUPF flag. This bit is set by hardware and cleared only by a Reset pin or by setting the WKUPCn+1 bit in the PWR wakeup clear register (PWR_WKUPCR).


\
\ @brief Reset only by system reset, not reset by wakeup from Standby mode
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WKUPEPR_WKUPEN1                          \ Enable Wakeup Pin WKUPn+1 Each bit is set and cleared by software. Note: An additional wakeup event is detected if WKUPn+1 pin is enabled (by setting the WKUPENn+1 bit) when WKUPn+1 pin level is already high when WKUPPn+1 selects rising edge, or low when WKUPPn+1 selects falling edge.
$00000002 constant PWR_PWR_WKUPEPR_WKUPEN2                          \ Enable Wakeup Pin WKUPn+1 Each bit is set and cleared by software. Note: An additional wakeup event is detected if WKUPn+1 pin is enabled (by setting the WKUPENn+1 bit) when WKUPn+1 pin level is already high when WKUPPn+1 selects rising edge, or low when WKUPPn+1 selects falling edge.
$00000004 constant PWR_PWR_WKUPEPR_WKUPEN3                          \ Enable Wakeup Pin WKUPn+1 Each bit is set and cleared by software. Note: An additional wakeup event is detected if WKUPn+1 pin is enabled (by setting the WKUPENn+1 bit) when WKUPn+1 pin level is already high when WKUPPn+1 selects rising edge, or low when WKUPPn+1 selects falling edge.
$00000008 constant PWR_PWR_WKUPEPR_WKUPEN4                          \ Enable Wakeup Pin WKUPn+1 Each bit is set and cleared by software. Note: An additional wakeup event is detected if WKUPn+1 pin is enabled (by setting the WKUPENn+1 bit) when WKUPn+1 pin level is already high when WKUPPn+1 selects rising edge, or low when WKUPPn+1 selects falling edge.
$00000010 constant PWR_PWR_WKUPEPR_WKUPEN5                          \ Enable Wakeup Pin WKUPn+1 Each bit is set and cleared by software. Note: An additional wakeup event is detected if WKUPn+1 pin is enabled (by setting the WKUPENn+1 bit) when WKUPn+1 pin level is already high when WKUPPn+1 selects rising edge, or low when WKUPPn+1 selects falling edge.
$00000020 constant PWR_PWR_WKUPEPR_WKUPEN6                          \ Enable Wakeup Pin WKUPn+1 Each bit is set and cleared by software. Note: An additional wakeup event is detected if WKUPn+1 pin is enabled (by setting the WKUPENn+1 bit) when WKUPn+1 pin level is already high when WKUPPn+1 selects rising edge, or low when WKUPPn+1 selects falling edge.
$00000100 constant PWR_PWR_WKUPEPR_WKUPP1                           \ Wakeup pin polarity bit for WKUPn-7 These bits define the polarity used for event detection on WKUPn-7 external wakeup pin.
$00000200 constant PWR_PWR_WKUPEPR_WKUPP2                           \ Wakeup pin polarity bit for WKUPn-7 These bits define the polarity used for event detection on WKUPn-7 external wakeup pin.
$00000400 constant PWR_PWR_WKUPEPR_WKUPP3                           \ Wakeup pin polarity bit for WKUPn-7 These bits define the polarity used for event detection on WKUPn-7 external wakeup pin.
$00000800 constant PWR_PWR_WKUPEPR_WKUPP4                           \ Wakeup pin polarity bit for WKUPn-7 These bits define the polarity used for event detection on WKUPn-7 external wakeup pin.
$00001000 constant PWR_PWR_WKUPEPR_WKUPP5                           \ Wakeup pin polarity bit for WKUPn-7 These bits define the polarity used for event detection on WKUPn-7 external wakeup pin.
$00002000 constant PWR_PWR_WKUPEPR_WKUPP6                           \ Wakeup pin polarity bit for WKUPn-7 These bits define the polarity used for event detection on WKUPn-7 external wakeup pin.
$00030000 constant PWR_PWR_WKUPEPR_WKUPPUPD1                        \ Wakeup pin pull configuration
$000c0000 constant PWR_PWR_WKUPEPR_WKUPPUPD2                        \ Wakeup pin pull configuration
$00300000 constant PWR_PWR_WKUPEPR_WKUPPUPD3                        \ Wakeup pin pull configuration
$00c00000 constant PWR_PWR_WKUPEPR_WKUPPUPD4                        \ Wakeup pin pull configuration
$03000000 constant PWR_PWR_WKUPEPR_WKUPPUPD5                        \ Wakeup pin pull configuration
$0c000000 constant PWR_PWR_WKUPEPR_WKUPPUPD6                        \ Wakeup pin pull configuration for WKUP(truncate(n/2)-7) These bits define the I/O pad pull configuration used when WKUPEN(truncate(n/2)-7) = 1. The associated GPIO port pull configuration shall be set to the same value or to 00. The Wakeup pin pull configuration is kept in Standby mode.


\
\ @brief PWR
\
$58024800 constant PWR_PWR_CR1    \ offset: 0x00 : PWR control register 1
$58024804 constant PWR_PWR_CSR1   \ offset: 0x04 : PWR control status register 1
$58024808 constant PWR_PWR_CR2    \ offset: 0x08 : This register is not reset by wakeup from Standby mode, RESET signal and VDD POR. It is only reset by VSW POR and VSWRST reset. This register shall not be accessed when VSWRST bit in RCC_BDCR register resets the VSW domain.After reset, PWR_CR2 register is write-protected. Prior to modifying its content, the DBP bit in PWR_CR1 register must be set to disable the write protection.
$5802480c constant PWR_PWR_CR3    \ offset: 0x0C : Reset only by POR only, not reset by wakeup from Standby mode and RESET pad. The lower byte of this register is written once after POR and shall be written before changing VOS level or ck_sys clock frequency. No limitation applies to the upper bytes.Programming data corresponding to an invalid combination of SDLEVEL, SDEXTHP, SDEN, LDOEN and BYPASS bits (see Table9) will be ignored: data will not be written, the written-once mechanism will lock the register and any further write access will be ignored. The default supply configuration will be kept and the ACTVOSRDY bit in PWR control status register 1 (PWR_CSR1) will go on indicating invalid voltage levels. The system shall be power cycled before writing a new value.
$58024810 constant PWR_PWR_CPUCR  \ offset: 0x10 : This register allows controlling CPU1 power.
$58024818 constant PWR_PWR_SRDCR  \ offset: 0x18 : This register allows controlling D3 domain power.Following reset VOSRDY will be read 1 by software
$58024820 constant PWR_PWR_WKUPCR  \ offset: 0x20 : reset only by system reset, not reset by wakeup from Standby mode5 wait states are required when writing this register (when clearing a WKUPF bit in PWR_WKUPFR, the AHB write access will complete after the WKUPF has been cleared).
$58024824 constant PWR_PWR_WKUPFR  \ offset: 0x24 : reset only by system reset, not reset by wakeup from Standby mode
$58024828 constant PWR_PWR_WKUPEPR  \ offset: 0x28 : Reset only by system reset, not reset by wakeup from Standby mode

