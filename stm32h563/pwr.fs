\
\ @file pwr.fs
\ @brief Power control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief PWR power mode control register
\ Address offset: 0x00
\ Reset value: 0x0000000C
\

$00000001 constant PWR_PWR_PMCR_LPMS                                \ low-power mode selection This bit defines the Deepsleep mode.
$0000000c constant PWR_PWR_PMCR_SVOS                                \ system Stop mode voltage scaling selection These bits control the Vsub CORE/sub voltage level in system Stop mode, to obtain the best trade-off between power consumption and performance.
$00000080 constant PWR_PWR_PMCR_CSSF                                \ clear Standby and Stop flags (always read as 0) This bit is cleared to 0 by hardware.
$00000200 constant PWR_PWR_PMCR_FLPS                                \ Flash memory low-power mode in Stop mode This bit is used to obtain the best trade-off between low-power consumption and restart time when exiting from Stop mode. When it is set, the Flash memory enters low-power mode when the CPU domain is in Stop mode. Note: When system enters stop mode with SVOS5 enabled, Flash memory is automatically forced in low-power mode.
$00001000 constant PWR_PWR_PMCR_BOOSTE                              \ analog switch Vsub BOOST/sub control This bit enables the booster to guarantee the analog switch AC performance when the Vsub DD/sub supply voltage is below 2.7 V (reduction of the total harmonic distortion to have the same switch performance over the full supply voltage range) The Vsub DD/sub supply voltage can be monitored through the PVD and the PLS bits.
$00002000 constant PWR_PWR_PMCR_AVD_READY                           \ analog voltage ready This bit is only used when the analog switch boost needs to be enabled (see BOOSTE bit). It must be set by software when the expected Vsub DDA/sub analog supply level is available. The correct analog supply level is indicated by the AVDO bit (PWR_VMSR register) after setting the AVDEN bit (PWR_VMCR register) and selecting the supply level to be monitored (ALS bits).
$00010000 constant PWR_PWR_PMCR_ETHERNETSO                          \ ETHERNET RAM shut-off in Stop mode.
$00800000 constant PWR_PWR_PMCR_SRAM3SO                             \ AHB SRAM3 shut-off in Stop mode.
$01000000 constant PWR_PWR_PMCR_SRAM2_16SO                          \ AHB SRAM2 16-Kbyte shut-off in Stop mode.
$02000000 constant PWR_PWR_PMCR_SRAM2_48SO                          \ AHB SRAM2 48-Kbyte shut-off in Stop mode.
$04000000 constant PWR_PWR_PMCR_SRAM1SO                             \ AHB SRAM1 shut-off in Stop mode


\
\ @brief PWR status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000020 constant PWR_PWR_PMSR_STOPF                               \ Stop flag This bit is set by hardware and cleared only by any reset or by setting the CSSF bit.
$00000040 constant PWR_PWR_PMSR_SBF                                 \ System standby flag This bit is set by hardware and cleared only by a POR or by setting the CSSF bit.


\
\ @brief PWR voltage scaling control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000030 constant PWR_PWR_VOSCR_VOS                                \ voltage scaling selection according to performance These bits control the Vsub CORE/sub voltage level and allow to obtain the best trade-off between power consumption and performance: - In bypass mode, these bits must also be set according to the external provided core voltage level and related performance. - When increasing the performance, the voltage scaling must be changed before increasing the system frequency. - When decreasing performance, the system frequency must first be decreased before changing the voltage scaling.


\
\ @brief PWR voltage scaling status register
\ Address offset: 0x14
\ Reset value: 0x00000008
\

$00000008 constant PWR_PWR_VOSSR_VOSRDY                             \ Ready bit for Vsub CORE/sub voltage scaling output selection.
$00002000 constant PWR_PWR_VOSSR_ACTVOSRDY                          \ Voltage level ready for currently used VOS
$0000c000 constant PWR_PWR_VOSSR_ACTVOS                             \ voltage output scaling currently applied to Vsub CORE/sub This field provides the last VOS value.


\
\ @brief PWR Backup domain control register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_BDCR_BREN                                \ Backup RAM retention in Standby and Vsub BAT/sub modes When this bit set, the backup regulator (used to maintain the backup RAM content in Standby and Vsub BAT/sub modes) is enabled. If BREN is cleared, the backup regulator is switched off. The backup RAM can still be used in Run and Stop modes. However its content is lost in Standby and Vsub BAT/sub modes. If BREN is set, the application must wait till the backup regulator ready flag (BRRDY) is set to indicate that the data written into the SRAM is maintained in Standby and Vsub BAT/sub modes.
$00000002 constant PWR_PWR_BDCR_MONEN                               \ Backup domain voltage and temperature monitoring enable
$00000100 constant PWR_PWR_BDCR_VBE                                 \ Vsub BAT/sub charging enable Note: Reset only by POR,.
$00000200 constant PWR_PWR_BDCR_VBRS                                \ Vsub BAT/sub charging resistor selection


\
\ @brief PWR Backup domain control register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_DBPCR_DBP                                \ Disable Backup domain write protection In reset state, all registers and SRAM in Backup domain are protected against parasitic write access. This bit must be set to enable write access to these registers.


\
\ @brief PWR Backup domain status register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00010000 constant PWR_PWR_BDSR_BRRDY                               \ backup regulator ready This bit is set by hardware to indicate that the backup regulator is ready.
$00100000 constant PWR_PWR_BDSR_VBATL                               \ Vsub BAT/sub level monitoring versus low threshold
$00200000 constant PWR_PWR_BDSR_VBATH                               \ Vsub BAT/sub level monitoring versus high threshold
$00400000 constant PWR_PWR_BDSR_TEMPL                               \ temperature level monitoring versus low threshold
$00800000 constant PWR_PWR_BDSR_TEMPH                               \ temperature level monitoring versus high threshold


\
\ @brief PWR USB Type-C power delivery register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_UCPDR_UCPD_DBDIS                         \ USB Type-C and power delivery dead battery disable After exiting reset, the USB Type-C 'dead battery' behavior is enabled, which may have a pull-down effect on CC1 and CC2 pins. It is recommended to disable it in all case, either to stop this pull-down or to hand over control to the UCPD (which should therefore be initialized before doing the disable).
$00000002 constant PWR_PWR_UCPDR_UCPD_STBY                          \ USB Type-c and Power delivery Standby mode When set, this bit is used to memorize the UCPD configuration in Standby mode. This bit must be written to 1 just before entering Standby mode when using UCPD, and it must be written to 0 after exiting the standby mode and before writing any UCPD register.


\
\ @brief PWR supply configuration control register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_SCCR_BYPASS                              \ power management unit bypass
$00000100 constant PWR_PWR_SCCR_LDOEN                               \ LDO enable The value is set by hardware when the package uses the LDO regulator.
$00000200 constant PWR_PWR_SCCR_SMPSEN                              \ SMPS enable The value is set by hardware when the package uses the SMPS regulator.


\
\ @brief PWR voltage monitor control register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_VMCR_PVDE                                \ PVD enable
$0000000e constant PWR_PWR_VMCR_PLS                                 \ programmable voltage detector (PVD) level selection These bits select the voltage threshold detected by the PVD.
$00000100 constant PWR_PWR_VMCR_AVDEN                               \ peripheral voltage monitor on Vsub DDA/sub enable
$00000600 constant PWR_PWR_VMCR_ALS                                 \ analog voltage detector (AVD) level selection These bits select the voltage threshold detected by the AVD.


\
\ @brief PWR USB supply control register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$01000000 constant PWR_PWR_USBSCR_USB33DEN                          \ Vsub DDUSB/sub voltage level detector enable
$02000000 constant PWR_PWR_USBSCR_USB33SV                           \ independent USB supply valid This bit is used to validate the Vsub DDUSB/sub supply for electrical and logical isolation purpose. Setting this bit is mandatory to use the USBFS peripheral. If Vsub DDUSB/sub is not always present in the application, the Vsub DDUSB/sub voltage monitor can be used to determine whether this supply is ready or not.


\
\ @brief PWR voltage monitor status register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00080000 constant PWR_PWR_VMSR_AVDO                                \ analog voltage detector output on Vsub DDA/sub This bit is set and cleared by hardware. It is valid only if AVD on VDDA is enabled by the AVDEN bit. Note: Since the AVD is disabled in Standby mode, this bit is equal to 0 after standby or reset until the AVDEN bit is set.
$00100000 constant PWR_PWR_VMSR_VDDIO2RDY                           \ voltage detector output on Vsub DDIO2/sub This bit is set and cleared by hardware.
$00400000 constant PWR_PWR_VMSR_PVDO                                \ programmable voltage detect output This bit is set and cleared by hardware. It is valid only if the PVD has been enabled by the PVDE bit. Note: Since the PVD is disabled in Standby mode, this bit is equal to 0 after Standby or reset until the PVDE bit is set.
$01000000 constant PWR_PWR_VMSR_USB33RDY                            \ Vsub DDUSB/sub ready


\
\ @brief PWR wakeup status clear register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WUSCR_CWUF1                              \ clear wakeup pin flag for WUFx These bits are always read as 0.
$00000002 constant PWR_PWR_WUSCR_CWUF2                              \ clear wakeup pin flag for WUFx These bits are always read as 0.
$00000004 constant PWR_PWR_WUSCR_CWUF3                              \ clear wakeup pin flag for WUFx These bits are always read as 0.
$00000008 constant PWR_PWR_WUSCR_CWUF4                              \ clear wakeup pin flag for WUFx These bits are always read as 0.
$00000010 constant PWR_PWR_WUSCR_CWUF5                              \ clear wakeup pin flag for WUFx These bits are always read as 0.
$00000020 constant PWR_PWR_WUSCR_CWUF6                              \ clear wakeup pin flag for WUFx These bits are always read as 0.
$00000040 constant PWR_PWR_WUSCR_CWUF7                              \ clear wakeup pin flag for WUFx These bits are always read as 0.
$00000080 constant PWR_PWR_WUSCR_CWUF8                              \ clear wakeup pin flag for WUFx These bits are always read as 0.


\
\ @brief PWR wakeup status register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WUSR_WUF1                                \ wakeup pin WUFx flag This bit is set by hardware and cleared only by a RESET pin or by setting the CWUFx bit in PWR_WUSCR register.
$00000002 constant PWR_PWR_WUSR_WUF2                                \ wakeup pin WUFx flag This bit is set by hardware and cleared only by a RESET pin or by setting the CWUFx bit in PWR_WUSCR register.
$00000004 constant PWR_PWR_WUSR_WUF3                                \ wakeup pin WUFx flag This bit is set by hardware and cleared only by a RESET pin or by setting the CWUFx bit in PWR_WUSCR register.
$00000008 constant PWR_PWR_WUSR_WUF4                                \ wakeup pin WUFx flag This bit is set by hardware and cleared only by a RESET pin or by setting the CWUFx bit in PWR_WUSCR register.
$00000010 constant PWR_PWR_WUSR_WUF5                                \ wakeup pin WUFx flag This bit is set by hardware and cleared only by a RESET pin or by setting the CWUFx bit in PWR_WUSCR register.
$00000020 constant PWR_PWR_WUSR_WUF6                                \ wakeup pin WUFx flag This bit is set by hardware and cleared only by a RESET pin or by setting the CWUFx bit in PWR_WUSCR register.
$00000040 constant PWR_PWR_WUSR_WUF7                                \ wakeup pin WUFx flag This bit is set by hardware and cleared only by a RESET pin or by setting the CWUFx bit in PWR_WUSCR register.
$00000080 constant PWR_PWR_WUSR_WUF8                                \ wakeup pin WUFx flag This bit is set by hardware and cleared only by a RESET pin or by setting the CWUFx bit in PWR_WUSCR register.


\
\ @brief PWR wakeup configuration register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WUCR_WUPEN1                              \ enable wakeup pin WUPx These bits are set and cleared by software. Note: an additional wakeup event is detected if WUPx pin is enabled (by setting the WUPENx bit) when WUPx pin level is already high when WUPPx selects rising edge, or low when WUPPx selects falling edge.
$00000002 constant PWR_PWR_WUCR_WUPEN2                              \ enable wakeup pin WUPx These bits are set and cleared by software. Note: an additional wakeup event is detected if WUPx pin is enabled (by setting the WUPENx bit) when WUPx pin level is already high when WUPPx selects rising edge, or low when WUPPx selects falling edge.
$00000004 constant PWR_PWR_WUCR_WUPEN3                              \ enable wakeup pin WUPx These bits are set and cleared by software. Note: an additional wakeup event is detected if WUPx pin is enabled (by setting the WUPENx bit) when WUPx pin level is already high when WUPPx selects rising edge, or low when WUPPx selects falling edge.
$00000008 constant PWR_PWR_WUCR_WUPEN4                              \ enable wakeup pin WUPx These bits are set and cleared by software. Note: an additional wakeup event is detected if WUPx pin is enabled (by setting the WUPENx bit) when WUPx pin level is already high when WUPPx selects rising edge, or low when WUPPx selects falling edge.
$00000010 constant PWR_PWR_WUCR_WUPEN5                              \ enable wakeup pin WUPx These bits are set and cleared by software. Note: an additional wakeup event is detected if WUPx pin is enabled (by setting the WUPENx bit) when WUPx pin level is already high when WUPPx selects rising edge, or low when WUPPx selects falling edge.
$00000020 constant PWR_PWR_WUCR_WUPEN6                              \ enable wakeup pin WUPx These bits are set and cleared by software. Note: an additional wakeup event is detected if WUPx pin is enabled (by setting the WUPENx bit) when WUPx pin level is already high when WUPPx selects rising edge, or low when WUPPx selects falling edge.
$00000040 constant PWR_PWR_WUCR_WUPEN7                              \ enable wakeup pin WUPx These bits are set and cleared by software. Note: an additional wakeup event is detected if WUPx pin is enabled (by setting the WUPENx bit) when WUPx pin level is already high when WUPPx selects rising edge, or low when WUPPx selects falling edge.
$00000080 constant PWR_PWR_WUCR_WUPEN8                              \ enable wakeup pin WUPx These bits are set and cleared by software. Note: an additional wakeup event is detected if WUPx pin is enabled (by setting the WUPENx bit) when WUPx pin level is already high when WUPPx selects rising edge, or low when WUPPx selects falling edge.
$00000100 constant PWR_PWR_WUCR_WUPP1                               \ wakeup pin polarity bit for WUPx These bits define the polarity used for event detection on WUPx external wakeup pin.
$00000200 constant PWR_PWR_WUCR_WUPP2                               \ wakeup pin polarity bit for WUPx These bits define the polarity used for event detection on WUPx external wakeup pin.
$00000400 constant PWR_PWR_WUCR_WUPP3                               \ wakeup pin polarity bit for WUPx These bits define the polarity used for event detection on WUPx external wakeup pin.
$00000800 constant PWR_PWR_WUCR_WUPP4                               \ wakeup pin polarity bit for WUPx These bits define the polarity used for event detection on WUPx external wakeup pin.
$00001000 constant PWR_PWR_WUCR_WUPP5                               \ wakeup pin polarity bit for WUPx These bits define the polarity used for event detection on WUPx external wakeup pin.
$00002000 constant PWR_PWR_WUCR_WUPP6                               \ wakeup pin polarity bit for WUPx These bits define the polarity used for event detection on WUPx external wakeup pin.
$00004000 constant PWR_PWR_WUCR_WUPP7                               \ wakeup pin polarity bit for WUPx These bits define the polarity used for event detection on WUPx external wakeup pin.
$00008000 constant PWR_PWR_WUCR_WUPP8                               \ wakeup pin polarity bit for WUPx These bits define the polarity used for event detection on WUPx external wakeup pin.
$00030000 constant PWR_PWR_WUCR_WUPPUPD1                            \ wakeup pin pull configuration for WKUPx These bits define the I/O pad pull configuration used when WUPENx = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The wakeup pin pull configuration is kept in Standby mode.
$000c0000 constant PWR_PWR_WUCR_WUPPUPD2                            \ wakeup pin pull configuration for WKUPx These bits define the I/O pad pull configuration used when WUPENx = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The wakeup pin pull configuration is kept in Standby mode.
$00300000 constant PWR_PWR_WUCR_WUPPUPD3                            \ wakeup pin pull configuration for WKUPx These bits define the I/O pad pull configuration used when WUPENx = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The wakeup pin pull configuration is kept in Standby mode.
$00c00000 constant PWR_PWR_WUCR_WUPPUPD4                            \ wakeup pin pull configuration for WKUPx These bits define the I/O pad pull configuration used when WUPENx = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The wakeup pin pull configuration is kept in Standby mode.
$03000000 constant PWR_PWR_WUCR_WUPPUPD5                            \ wakeup pin pull configuration for WKUPx These bits define the I/O pad pull configuration used when WUPENx = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The wakeup pin pull configuration is kept in Standby mode.
$0c000000 constant PWR_PWR_WUCR_WUPPUPD6                            \ wakeup pin pull configuration for WKUPx These bits define the I/O pad pull configuration used when WUPENx = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The wakeup pin pull configuration is kept in Standby mode.
$30000000 constant PWR_PWR_WUCR_WUPPUPD7                            \ wakeup pin pull configuration for WKUPx These bits define the I/O pad pull configuration used when WUPENx = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The wakeup pin pull configuration is kept in Standby mode.
$c0000000 constant PWR_PWR_WUCR_WUPPUPD8                            \ wakeup pin pull configuration for WKUPx These bits define the I/O pad pull configuration used when WUPENx = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The wakeup pin pull configuration is kept in Standby mode.


\
\ @brief PWR I/O retention register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_IORETR_IORETEN                           \ IO retention enable: When entering into standby mode, the output is sampled, and apply to the output IO during the standby power mode. Note: the IO state is not retained if the DBG_STANDBY bit is set in DBGMCU_CR register.
$00010000 constant PWR_PWR_IORETR_JTAGIORETEN                       \ IO retention enable for JTAG IOs when entering into standby mode, the output is sampled, and apply to the output IO during the standby power mode


\
\ @brief PWR security configuration register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_SECCFGR_WUP1SEC                          \ WUPx secure protection
$00000002 constant PWR_PWR_SECCFGR_WUP2SEC                          \ WUPx secure protection
$00000004 constant PWR_PWR_SECCFGR_WUP3SEC                          \ WUPx secure protection
$00000008 constant PWR_PWR_SECCFGR_WUP4SEC                          \ WUPx secure protection
$00000010 constant PWR_PWR_SECCFGR_WUP5SEC                          \ WUPx secure protection
$00000020 constant PWR_PWR_SECCFGR_WUP6SEC                          \ WUPx secure protection
$00000040 constant PWR_PWR_SECCFGR_WUP7SEC                          \ WUPx secure protection
$00000080 constant PWR_PWR_SECCFGR_WUP8SEC                          \ WUPx secure protection
$00000800 constant PWR_PWR_SECCFGR_RETSEC                           \ retention secure protection
$00001000 constant PWR_PWR_SECCFGR_LPMSEC                           \ low-power modes secure protection
$00002000 constant PWR_PWR_SECCFGR_SCMSEC                           \ supply configuration and monitoring secure protection.
$00004000 constant PWR_PWR_SECCFGR_VBSEC                            \ backup domain secure protection
$00008000 constant PWR_PWR_SECCFGR_VUSBSEC                          \ voltage USB secure protection


\
\ @brief PWR privilege configuration register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PRIVCFGR_SPRIV                           \ PWR secure functions privilege configuration Set and reset by software. This bit can be written only by a secure privileged access.
$00000002 constant PWR_PWR_PRIVCFGR_NSPRIV                          \ PWR non-secure functions privilege configuration Set and reset by software. This bit can be written only by privileged access, secure or non-secure.


\
\ @brief Power control
\
$44020800 constant PWR_PWR_PMCR   \ offset: 0x00 : PWR power mode control register
$44020804 constant PWR_PWR_PMSR   \ offset: 0x04 : PWR status register
$44020810 constant PWR_PWR_VOSCR  \ offset: 0x10 : PWR voltage scaling control register
$44020814 constant PWR_PWR_VOSSR  \ offset: 0x14 : PWR voltage scaling status register
$44020820 constant PWR_PWR_BDCR   \ offset: 0x20 : PWR Backup domain control register
$44020824 constant PWR_PWR_DBPCR  \ offset: 0x24 : PWR Backup domain control register
$44020828 constant PWR_PWR_BDSR   \ offset: 0x28 : PWR Backup domain status register
$4402082c constant PWR_PWR_UCPDR  \ offset: 0x2C : PWR USB Type-C power delivery register
$44020830 constant PWR_PWR_SCCR   \ offset: 0x30 : PWR supply configuration control register
$44020834 constant PWR_PWR_VMCR   \ offset: 0x34 : PWR voltage monitor control register
$44020838 constant PWR_PWR_USBSCR  \ offset: 0x38 : PWR USB supply control register
$4402083c constant PWR_PWR_VMSR   \ offset: 0x3C : PWR voltage monitor status register
$44020840 constant PWR_PWR_WUSCR  \ offset: 0x40 : PWR wakeup status clear register
$44020844 constant PWR_PWR_WUSR   \ offset: 0x44 : PWR wakeup status register
$44020848 constant PWR_PWR_WUCR   \ offset: 0x48 : PWR wakeup configuration register
$44020850 constant PWR_PWR_IORETR  \ offset: 0x50 : PWR I/O retention register
$44020900 constant PWR_PWR_SECCFGR  \ offset: 0x100 : PWR security configuration register
$44020904 constant PWR_PWR_PRIVCFGR  \ offset: 0x104 : PWR privilege configuration register

