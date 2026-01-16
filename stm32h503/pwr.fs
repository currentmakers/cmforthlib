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
$0000000c constant PWR_PWR_PMCR_SVOS                                \ system Stop mode voltage scaling selection These bits control the V CORE voltage level in system Stop mode, to obtain the best trade-off between power consumption and performance.
$00000080 constant PWR_PWR_PMCR_CSSF                                \ clear Standby and Stop flags (always read as 0) This bit is cleared to 0 by hardware.
$00000200 constant PWR_PWR_PMCR_FLPS                                \ Flash memory low-power mode in Stop mode This bit is used to obtain the best trade-off between low-power consumption and restart time when exiting from Stop mode. When it is set, the Flash memory enters low-power mode when the CPU domain is in Stop mode. Note: When system enters stop mode with SVOS5 enabled, Flash memory is automatically forced in low-power mode.
$00001000 constant PWR_PWR_PMCR_BOOSTE                              \ analog switch V BOOST control This bit enables the booster to guarantee the analog switch AC performance when the V DD supply voltage is below 2.7 V (reduction of the total harmonic distortion to have the same switch performance over the full supply voltage range) The V DD supply voltage can be monitored through the PVD and the PLS bits.
$00002000 constant PWR_PWR_PMCR_AVD_READY                           \ analog voltage ready This bit is only used when the analog switch boost needs to be enabled (see BOOSTE bit). It must be set by software when the expected V DDA analog supply level is available. The correct analog supply level is indicated by the AVDO bit (PWR_VMSR register) after setting the AVDEN bit (PWR_VMCR register) and selecting the supply level to be monitored (ALS bits).
$02000000 constant PWR_PWR_PMCR_SRAM2SO                             \ AHB SRAM2 shut-off in Stop mode.
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

$00000030 constant PWR_PWR_VOSCR_VOS                                \ voltage scaling selection according to performance These bits control the V CORE voltage level and allow to obtain the best trade-off between power consumption and performance: - In bypass mode, these bits must also be set according to the external provided core voltage level and related performance. - When increasing the performance, the voltage scaling must be changed before increasing the system frequency. - When decreasing performance, the system frequency must first be decreased before changing the voltage scaling.


\
\ @brief PWR voltage scaling status register
\ Address offset: 0x14
\ Reset value: 0x00000008
\

$00000008 constant PWR_PWR_VOSSR_VOSRDY                             \ Ready bit for V CORE voltage scaling output selection.
$00002000 constant PWR_PWR_VOSSR_ACTVOSRDY                          \ Voltage level ready for currently used VOS
$0000c000 constant PWR_PWR_VOSSR_ACTVOS                             \ voltage output scaling currently applied to V CORE This field provides the last VOS value.


\
\ @brief PWR Backup domain control register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_BDCR_BREN                                \ Backup RAM retention in Standby and V BAT modes When this bit set, the backup regulator (used to maintain the backup RAM content in Standby and V BAT modes) is enabled. If BREN is cleared, the backup regulator is switched off. The backup RAM can still be used in Run and Stop modes. However its content is lost in Standby and V BAT modes. If BREN is set, the application must wait till the backup regulator ready flag (BRRDY) is set to indicate that the data written into the SRAM is maintained in Standby and V BAT modes.
$00000002 constant PWR_PWR_BDCR_MONEN                               \ Backup domain voltage and temperature monitoring enable
$00000100 constant PWR_PWR_BDCR_VBE                                 \ V BAT charging enable Note: Reset only by POR,.
$00000200 constant PWR_PWR_BDCR_VBRS                                \ V BAT charging resistor selection


\
\ @brief PWR disable backup protection control register
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
$00100000 constant PWR_PWR_BDSR_VBATL                               \ V BAT level monitoring versus low threshold
$00200000 constant PWR_PWR_BDSR_VBATH                               \ V BAT level monitoring versus high threshold
$00400000 constant PWR_PWR_BDSR_TEMPL                               \ temperature level monitoring versus low threshold
$00800000 constant PWR_PWR_BDSR_TEMPH                               \ temperature level monitoring versus high threshold


\
\ @brief PWR supply configuration control register
\ Address offset: 0x30
\ Reset value: 0x00000100
\

$00000001 constant PWR_PWR_SCCR_BYPASS                              \ power management unit bypass
$00000100 constant PWR_PWR_SCCR_LDOEN                               \ LDO enable The value is set by hardware when the package uses the LDO regulator.


\
\ @brief PWR voltage monitor control register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_VMCR_PVDE                                \ PVD enable
$0000000e constant PWR_PWR_VMCR_PLS                                 \ programmable voltage detector (PVD) level selection These bits select the voltage threshold detected by the PVD.
$00000100 constant PWR_PWR_VMCR_AVDEN                               \ peripheral voltage monitor on V DDA enable
$00000600 constant PWR_PWR_VMCR_ALS                                 \ analog voltage detector (AVD) level selection These bits select the voltage threshold detected by the AVD.


\
\ @brief PWR voltage monitor status register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00080000 constant PWR_PWR_VMSR_AVDO                                \ analog voltage detector output on V DDA This bit is set and cleared by hardware. It is valid only if AVD on VDDA is enabled by the AVDEN bit. Note: Since the AVD is disabled in Standby mode, this bit is equal to 0 after standby or reset until the AVDEN bit is set.
$00100000 constant PWR_PWR_VMSR_VDDIO2RDY                           \ voltage detector output on V DDIO2 This bit is set and cleared by hardware.
$00400000 constant PWR_PWR_VMSR_PVDO                                \ programmable voltage detect output This bit is set and cleared by hardware. It is valid only if the PVD has been enabled by the PVDE bit. Note: Since the PVD is disabled in Standby mode, this bit is equal to 0 after Standby or reset until the PVDE bit is set.


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
$00000100 constant PWR_PWR_WUCR_WUPP1                               \ wakeup pin polarity bit for WUPx These bits define the polarity used for event detection on WUPx external wakeup pin.
$00000200 constant PWR_PWR_WUCR_WUPP2                               \ wakeup pin polarity bit for WUPx These bits define the polarity used for event detection on WUPx external wakeup pin.
$00000400 constant PWR_PWR_WUCR_WUPP3                               \ wakeup pin polarity bit for WUPx These bits define the polarity used for event detection on WUPx external wakeup pin.
$00000800 constant PWR_PWR_WUCR_WUPP4                               \ wakeup pin polarity bit for WUPx These bits define the polarity used for event detection on WUPx external wakeup pin.
$00001000 constant PWR_PWR_WUCR_WUPP5                               \ wakeup pin polarity bit for WUPx These bits define the polarity used for event detection on WUPx external wakeup pin.
$00030000 constant PWR_PWR_WUCR_WUPPUPD1                            \ wakeup pin pull configuration for WKUPx These bits define the I/O pad pull configuration used when WUPENx = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The wakeup pin pull configuration is kept in Standby mode.
$000c0000 constant PWR_PWR_WUCR_WUPPUPD2                            \ wakeup pin pull configuration for WKUPx These bits define the I/O pad pull configuration used when WUPENx = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The wakeup pin pull configuration is kept in Standby mode.
$00300000 constant PWR_PWR_WUCR_WUPPUPD3                            \ wakeup pin pull configuration for WKUPx These bits define the I/O pad pull configuration used when WUPENx = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The wakeup pin pull configuration is kept in Standby mode.
$00c00000 constant PWR_PWR_WUCR_WUPPUPD4                            \ wakeup pin pull configuration for WKUPx These bits define the I/O pad pull configuration used when WUPENx = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The wakeup pin pull configuration is kept in Standby mode.
$03000000 constant PWR_PWR_WUCR_WUPPUPD5                            \ wakeup pin pull configuration for WKUPx These bits define the I/O pad pull configuration used when WUPENx = 1. The associated GPIO port pull configuration must be set to the same value or to 00. The wakeup pin pull configuration is kept in Standby mode.


\
\ @brief PWR I/O retention register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_IORETR_IORETEN                           \ IO retention enable: When entering into standby mode, the output is sampled, and applied to the output IO during the standby power mode. Note: the IO state is not retained if the DBG_STANDBY bit is set in DBGMCU_CR register.
$00010000 constant PWR_PWR_IORETR_JTAGIORETEN                       \ IO retention enable for JTAG IOs when entering into standby mode, the output is sampled, and applied to the output IO during the standby power mode


\
\ @brief PWR privilege configuration register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000002 constant PWR_PWR_PRIVCFGR_NSPRIV                          \ PWR functions privilege configuration Set and reset by software. This bit can be written only by privileged access.


\
\ @brief Power control
\
$44020800 constant PWR_PWR_PMCR   \ offset: 0x00 : PWR power mode control register
$44020804 constant PWR_PWR_PMSR   \ offset: 0x04 : PWR status register
$44020810 constant PWR_PWR_VOSCR  \ offset: 0x10 : PWR voltage scaling control register
$44020814 constant PWR_PWR_VOSSR  \ offset: 0x14 : PWR voltage scaling status register
$44020820 constant PWR_PWR_BDCR   \ offset: 0x20 : PWR Backup domain control register
$44020824 constant PWR_PWR_DBPCR  \ offset: 0x24 : PWR disable backup protection control register
$44020828 constant PWR_PWR_BDSR   \ offset: 0x28 : PWR Backup domain status register
$44020830 constant PWR_PWR_SCCR   \ offset: 0x30 : PWR supply configuration control register
$44020834 constant PWR_PWR_VMCR   \ offset: 0x34 : PWR voltage monitor control register
$4402083c constant PWR_PWR_VMSR   \ offset: 0x3C : PWR voltage monitor status register
$44020840 constant PWR_PWR_WUSCR  \ offset: 0x40 : PWR wakeup status clear register
$44020844 constant PWR_PWR_WUSR   \ offset: 0x44 : PWR wakeup status register
$44020848 constant PWR_PWR_WUCR   \ offset: 0x48 : PWR wakeup configuration register
$44020850 constant PWR_PWR_IORETR  \ offset: 0x50 : PWR I/O retention register
$44020904 constant PWR_PWR_PRIVCFGR  \ offset: 0x104 : PWR privilege configuration register

