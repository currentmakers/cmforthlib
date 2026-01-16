\
\ @file pwr.fs
\ @brief PWR address block description
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

$00000001 constant PWR_PWR_PMCR_LPMS                                \ low-power mode selection
$0000000c constant PWR_PWR_PMCR_SVOS                                \ system Stop mode voltage scaling selection
$00000080 constant PWR_PWR_PMCR_CSSF                                \ clear Standby and Stop flags (always read as 0)
$00000200 constant PWR_PWR_PMCR_FLPS                                \ flash memory low-power mode in Stop mode
$00001000 constant PWR_PWR_PMCR_BOOSTE                              \ analog switch Vless thansub>BOOSTless than/sub> control
$00002000 constant PWR_PWR_PMCR_AVD_READY                           \ analog voltage ready
$00010000 constant PWR_PWR_PMCR_ETHERNETSO                          \ ETHERNET RAM shut-off in Stop mode.
$00800000 constant PWR_PWR_PMCR_SRAM3SO                             \ AHB SRAM3 shut-off in Stop mode.
$01000000 constant PWR_PWR_PMCR_SRAM2_16SO                          \ AHB SRAM2 16-Kbyte shut-off in Stop mode.
$02000000 constant PWR_PWR_PMCR_SRAM2_48SO                          \ AHB SRAM2 48-Kbyte shut-off in Stop mode.
$04000000 constant PWR_PWR_PMCR_SRAM1SO                             \ AHB SRAM1 shut-off in Stop mode


\
\ @brief PWR power mode control register
\ Address offset: 0x00
\ Reset value: 0x0000000C
\

$00000001 constant PWR_PWR_PMCR_ALTERNATE1_LPMS                     \ low-power mode selection
$0000000c constant PWR_PWR_PMCR_ALTERNATE1_SVOS                     \ system Stop mode voltage scaling selection
$00000080 constant PWR_PWR_PMCR_ALTERNATE1_CSSF                     \ clear Standby and Stop flags (always read as 0)
$00000200 constant PWR_PWR_PMCR_ALTERNATE1_FLPS                     \ flash memory low-power mode in Stop mode
$00001000 constant PWR_PWR_PMCR_ALTERNATE1_BOOSTE                   \ analog switch Vless thansub>BOOSTless than/sub> control
$00002000 constant PWR_PWR_PMCR_ALTERNATE1_AVD_READY                \ analog voltage ready
$00800000 constant PWR_PWR_PMCR_ALTERNATE1_SRAM3SO                  \ AHB SRAM3 shut-off in Stop mode.
$01000000 constant PWR_PWR_PMCR_ALTERNATE1_SRAM2_16LSO              \ AHB SRAM2 low 16-Kbyte shut-off in Stop mode.
$02000000 constant PWR_PWR_PMCR_ALTERNATE1_SRAM2_16HSO              \ AHB SRAM2 high 16-Kbyte shut-off in Stop mode.
$04000000 constant PWR_PWR_PMCR_ALTERNATE1_SRAM2_48SO               \ AHB SRAM2 48-Kbyte shut-off in Stop mode.
$08000000 constant PWR_PWR_PMCR_ALTERNATE1_SRAM1SO                  \ AHB SRAM1 shut-off in Stop mode


\
\ @brief PWR status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000020 constant PWR_PWR_PMSR_STOPF                               \ Stop flag
$00000040 constant PWR_PWR_PMSR_SBF                                 \ System standby flag


\
\ @brief PWR voltage scaling control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000030 constant PWR_PWR_VOSCR_VOS                                \ voltage scaling selection according to performance


\
\ @brief PWR voltage scaling status register
\ Address offset: 0x14
\ Reset value: 0x00002008
\

$00000008 constant PWR_PWR_VOSSR_VOSRDY                             \ Ready bit for Vless thansub>COREless than/sub> voltage scaling output selection.
$00002000 constant PWR_PWR_VOSSR_ACTVOSRDY                          \ Voltage level ready for currently used VOS
$0000c000 constant PWR_PWR_VOSSR_ACTVOS                             \ voltage output scaling currently applied to Vless thansub>COREless than/sub>


\
\ @brief PWR Backup domain control register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_BDCR_BREN                                \ Backup RAM retention in Standby and Vless thansub>BATless than/sub> modes
$00000002 constant PWR_PWR_BDCR_MONEN                               \ Backup domain voltage and temperature monitoring enable
$00000100 constant PWR_PWR_BDCR_VBE                                 \ Vless thansub>BATless than/sub> charging enable
$00000200 constant PWR_PWR_BDCR_VBRS                                \ Vless thansub>BATless than/sub> charging resistor selection


\
\ @brief PWR Backup domain control register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_DBPCR_DBP                                \ Disable Backup domain write protection


\
\ @brief PWR Backup domain status register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00010000 constant PWR_PWR_BDSR_BRRDY                               \ backup regulator ready
$00100000 constant PWR_PWR_BDSR_VBATL                               \ Vless thansub>BATless than/sub> level monitoring versus low threshold
$00200000 constant PWR_PWR_BDSR_VBATH                               \ Vless thansub>BATless than/sub> level monitoring versus high threshold
$00400000 constant PWR_PWR_BDSR_TEMPL                               \ temperature level monitoring versus low threshold
$00800000 constant PWR_PWR_BDSR_TEMPH                               \ temperature level monitoring versus high threshold


\
\ @brief PWR USB Type-C power delivery register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_UCPDR_UCPD_DBDIS                         \ USB Type-C and power delivery dead battery disable
$00000002 constant PWR_PWR_UCPDR_UCPD_STBY                          \ USB Type-c and Power delivery Standby mode


\
\ @brief PWR supply configuration control register
\ Address offset: 0x30
\ Reset value: 0x00000100
\

$00000001 constant PWR_PWR_SCCR_BYPASS                              \ power management unit bypass
$00000100 constant PWR_PWR_SCCR_LDOEN                               \ LDO enable
$00000200 constant PWR_PWR_SCCR_SMPSEN                              \ SMPS enable


\
\ @brief PWR voltage monitor control register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_VMCR_PVDE                                \ PVD enable
$0000000e constant PWR_PWR_VMCR_PLS                                 \ programmable voltage detector (PVD) level selection
$00000100 constant PWR_PWR_VMCR_AVDEN                               \ peripheral voltage monitor on Vless thansub>DDAless than/sub> enable
$00000600 constant PWR_PWR_VMCR_ALS                                 \ analog voltage detector (AVD) level selection


\
\ @brief PWR USB supply control register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$01000000 constant PWR_PWR_USBSCR_USB33DEN                          \ Vless thansub>DDUSBless than/sub> voltage level detector enable
$02000000 constant PWR_PWR_USBSCR_USB33SV                           \ independent USB supply valid


\
\ @brief PWR voltage monitor status register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00080000 constant PWR_PWR_VMSR_AVDO                                \ analog voltage detector output on Vless thansub>DDAless than/sub>
$00100000 constant PWR_PWR_VMSR_VDDIO2RDY                           \ voltage detector output on Vless thansub>DDIO2less than/sub>
$00400000 constant PWR_PWR_VMSR_PVDO                                \ programmable voltage detect output
$01000000 constant PWR_PWR_VMSR_USB33RDY                            \ Vless thansub>DDUSBless than/sub> ready


\
\ @brief PWR wake-up status clear register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WUSCR_CWUF1                              \ clear wake-up pin flag for WUFx (x = 8 to 1)
$00000002 constant PWR_PWR_WUSCR_CWUF2                              \ clear wake-up pin flag for WUFx (x = 8 to 1)
$00000004 constant PWR_PWR_WUSCR_CWUF3                              \ clear wake-up pin flag for WUFx (x = 8 to 1)
$00000008 constant PWR_PWR_WUSCR_CWUF4                              \ clear wake-up pin flag for WUFx (x = 8 to 1)
$00000010 constant PWR_PWR_WUSCR_CWUF5                              \ clear wake-up pin flag for WUFx (x = 8 to 1)
$00000020 constant PWR_PWR_WUSCR_CWUF6                              \ clear wake-up pin flag for WUFx (x = 8 to 1)
$00000040 constant PWR_PWR_WUSCR_CWUF7                              \ clear wake-up pin flag for WUFx (x = 8 to 1)
$00000080 constant PWR_PWR_WUSCR_CWUF8                              \ clear wake-up pin flag for WUFx (x = 8 to 1)


\
\ @brief PWR wake-up status register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WUSR_WUF1                                \ wake-up pin WUFx flag
$00000002 constant PWR_PWR_WUSR_WUF2                                \ wake-up pin WUFx flag
$00000004 constant PWR_PWR_WUSR_WUF3                                \ wake-up pin WUFx flag
$00000008 constant PWR_PWR_WUSR_WUF4                                \ wake-up pin WUFx flag
$00000010 constant PWR_PWR_WUSR_WUF5                                \ wake-up pin WUFx flag
$00000020 constant PWR_PWR_WUSR_WUF6                                \ wake-up pin WUFx flag
$00000040 constant PWR_PWR_WUSR_WUF7                                \ wake-up pin WUFx flag
$00000080 constant PWR_PWR_WUSR_WUF8                                \ wake-up pin WUFx flag


\
\ @brief PWR wake-up configuration register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_WUCR_WUPEN1                              \ enable wake-up pin WUPx (x = 8 to 1)
$00000002 constant PWR_PWR_WUCR_WUPEN2                              \ enable wake-up pin WUPx (x = 8 to 1)
$00000004 constant PWR_PWR_WUCR_WUPEN3                              \ enable wake-up pin WUPx (x = 8 to 1)
$00000008 constant PWR_PWR_WUCR_WUPEN4                              \ enable wake-up pin WUPx (x = 8 to 1)
$00000010 constant PWR_PWR_WUCR_WUPEN5                              \ enable wake-up pin WUPx (x = 8 to 1)
$00000020 constant PWR_PWR_WUCR_WUPEN6                              \ enable wake-up pin WUPx (x = 8 to 1)
$00000040 constant PWR_PWR_WUCR_WUPEN7                              \ enable wake-up pin WUPx (x = 8 to 1)
$00000080 constant PWR_PWR_WUCR_WUPEN8                              \ enable wake-up pin WUPx (x = 8 to 1)
$00000100 constant PWR_PWR_WUCR_WUPP1                               \ wake-up pin polarity bit for WUPx (x = 8 to 1)
$00000200 constant PWR_PWR_WUCR_WUPP2                               \ wake-up pin polarity bit for WUPx (x = 8 to 1)
$00000400 constant PWR_PWR_WUCR_WUPP3                               \ wake-up pin polarity bit for WUPx (x = 8 to 1)
$00000800 constant PWR_PWR_WUCR_WUPP4                               \ wake-up pin polarity bit for WUPx (x = 8 to 1)
$00001000 constant PWR_PWR_WUCR_WUPP5                               \ wake-up pin polarity bit for WUPx (x = 8 to 1)
$00002000 constant PWR_PWR_WUCR_WUPP6                               \ wake-up pin polarity bit for WUPx (x = 8 to 1)
$00004000 constant PWR_PWR_WUCR_WUPP7                               \ wake-up pin polarity bit for WUPx (x = 8 to 1)
$00008000 constant PWR_PWR_WUCR_WUPP8                               \ wake-up pin polarity bit for WUPx (x = 8 to 1)
$00030000 constant PWR_PWR_WUCR_WUPPUPD1                            \ wake-up pin pull configuration for WKUPx (x = 8 to 1)
$000c0000 constant PWR_PWR_WUCR_WUPPUPD2                            \ wake-up pin pull configuration for WKUPx (x = 8 to 1)
$00300000 constant PWR_PWR_WUCR_WUPPUPD3                            \ wake-up pin pull configuration for WKUPx (x = 8 to 1)
$00c00000 constant PWR_PWR_WUCR_WUPPUPD4                            \ wake-up pin pull configuration for WKUPx (x = 8 to 1)
$03000000 constant PWR_PWR_WUCR_WUPPUPD5                            \ wake-up pin pull configuration for WKUPx (x = 8 to 1)
$0c000000 constant PWR_PWR_WUCR_WUPPUPD6                            \ wake-up pin pull configuration for WKUPx (x = 8 to 1)
$30000000 constant PWR_PWR_WUCR_WUPPUPD7                            \ wake-up pin pull configuration for WKUPx (x = 8 to 1)
$c0000000 constant PWR_PWR_WUCR_WUPPUPD8                            \ wake-up pin pull configuration for WKUPx (x = 8 to 1)


\
\ @brief PWR I/O retention register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_IORETR_IORETEN                           \ IO retention enable
$00010000 constant PWR_PWR_IORETR_JTAGIORETEN                       \ IO retention enable for JTAG IOs


\
\ @brief PWR security configuration register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_SECCFGR_WUP1SEC                          \ WUPx secure protection (x = 8 to 1)
$00000002 constant PWR_PWR_SECCFGR_WUP2SEC                          \ WUPx secure protection (x = 8 to 1)
$00000004 constant PWR_PWR_SECCFGR_WUP3SEC                          \ WUPx secure protection (x = 8 to 1)
$00000008 constant PWR_PWR_SECCFGR_WUP4SEC                          \ WUPx secure protection (x = 8 to 1)
$00000010 constant PWR_PWR_SECCFGR_WUP5SEC                          \ WUPx secure protection (x = 8 to 1)
$00000020 constant PWR_PWR_SECCFGR_WUP6SEC                          \ WUPx secure protection (x = 8 to 1)
$00000040 constant PWR_PWR_SECCFGR_WUP7SEC                          \ WUPx secure protection (x = 8 to 1)
$00000080 constant PWR_PWR_SECCFGR_WUP8SEC                          \ WUPx secure protection (x = 8 to 1)
$00000800 constant PWR_PWR_SECCFGR_RETSEC                           \ retention secure protection
$00001000 constant PWR_PWR_SECCFGR_LPMSEC                           \ low-power modes secure protection
$00002000 constant PWR_PWR_SECCFGR_SCMSEC                           \ supply configuration and monitoring secure protection.
$00004000 constant PWR_PWR_SECCFGR_VBSEC                            \ Backup domain secure protection
$00008000 constant PWR_PWR_SECCFGR_VUSBSEC                          \ voltage USB secure protection


\
\ @brief PWR privilege configuration register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant PWR_PWR_PRIVCFGR_SPRIV                           \ PWR secure functions privilege configuration
$00000002 constant PWR_PWR_PRIVCFGR_NSPRIV                          \ PWR non-secure functions privilege configuration


\
\ @brief PWR address block description
\
$44020800 constant PWR_PWR_PMCR   \ offset: 0x00 : PWR power mode control register
$44020800 constant PWR_PWR_PMCR_ALTERNATE1  \ offset: 0x00 : PWR power mode control register
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
$44020840 constant PWR_PWR_WUSCR  \ offset: 0x40 : PWR wake-up status clear register
$44020844 constant PWR_PWR_WUSR   \ offset: 0x44 : PWR wake-up status register
$44020848 constant PWR_PWR_WUCR   \ offset: 0x48 : PWR wake-up configuration register
$44020850 constant PWR_PWR_IORETR  \ offset: 0x50 : PWR I/O retention register
$44020900 constant PWR_PWR_SECCFGR  \ offset: 0x100 : PWR security configuration register
$44020904 constant PWR_PWR_PRIVCFGR  \ offset: 0x104 : PWR privilege configuration register

