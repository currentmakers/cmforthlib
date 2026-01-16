\
\ @file pwr_s.fs
\ @brief Power control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief PWR control register 1
\ Address offset: 0x00
\ Reset value: 0x00000024
\

$00000004 constant PWR_S_PWR_CR1_SDEN                               \ SMPS step-down converter enable
$00000010 constant PWR_S_PWR_CR1_MODE_PDN                           \ Enables the pull down on output voltage during power-down mode
$00000020 constant PWR_S_PWR_CR1_LPDS08V                            \ SMPS low-power mode enable (SVOS high only)
$001f0000 constant PWR_S_PWR_CR1_POPL                               \ pwr_on pulse low configuration.


\
\ @brief PWR control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant PWR_S_PWR_CR2_PVDEN                              \ Programmable voltage detector enable
$00000100 constant PWR_S_PWR_CR2_PVDO                               \ Programmable voltage detect output


\
\ @brief PWR control register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant PWR_S_PWR_CR3_VCOREMONEN                         \ Vless thansub>DDCOREless than/sub> monitoring enable
$00000010 constant PWR_S_PWR_CR3_VCORELLS                           \ Vless thansub>DDCOREless than/sub> voltage detector low-level selection
$00000100 constant PWR_S_PWR_CR3_VCOREL                             \ Monitored Vless thansub>DDCOREless than/sub> level above low threshold
$00000200 constant PWR_S_PWR_CR3_VCOREH                             \ Monitored Vless thansub>DDCOREless than/sub> level above high threshold


\
\ @brief PWR control register 4
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant PWR_S_PWR_CR4_TCMRBSEN                           \ I-TCM and D-TCM RAMs backup supply enable (used to maintain TCM RAMs content in Standby mode)
$00000010 constant PWR_S_PWR_CR4_TCMFLXRBSEN                        \ I-TCM FLEXMEM backup supply enable (used to maintain I-TCM FLEX MEM content in Standby mode)


\
\ @brief PWR voltage scaling control register
\ Address offset: 0x20
\ Reset value: 0x00020002
\

$00000001 constant PWR_S_PWR_VOSCR_VOS                              \ Voltage scaling selection according to performance
$00000002 constant PWR_S_PWR_VOSCR_VOSRDY                           \ VOS ready bit for Vless thansub>COREless than/sub> voltage scaling output selection
$00010000 constant PWR_S_PWR_VOSCR_ACTVOS                           \ VOS currently applied for Vless thansub>COREless than/sub> voltage scaling selection
$00020000 constant PWR_S_PWR_VOSCR_ACTVOSRDY                        \ Voltage level ready bit for currently used ACTVOS


\
\ @brief PWR backup domain control register 1
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant PWR_S_PWR_BDCR1_MONEN                            \ Vless thansub>BATless than/sub> and temperature monitoring enable
$00010000 constant PWR_S_PWR_BDCR1_VBATL                            \ Vless thansub>BATless than/sub> level monitoring versus low threshold
$00020000 constant PWR_S_PWR_BDCR1_VBATH                            \ Vless thansub>BATless than/sub> level monitoring versus high threshold
$00040000 constant PWR_S_PWR_BDCR1_TEMPL                            \ Temperature level monitoring versus low threshold
$00080000 constant PWR_S_PWR_BDCR1_TEMPH                            \ Temperature level monitoring versus high threshold


\
\ @brief PWR backup domain control register 2
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant PWR_S_PWR_BDCR2_BKPRBSEN                         \ Backup RAM backup supply enable (used to maintain BKPRAM content in Standby and Vless thansub>BATless than/sub> modes).


\
\ @brief PWR disable backup protection control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant PWR_S_PWR_DBPCR_DBP                              \ Disable backup domain write protection


\
\ @brief PWR CPU control register
\ Address offset: 0x30
\ Reset value: 0x00010000
\

$00000001 constant PWR_S_PWR_CPUCR_PDDS                             \ Power-down deepsleep selection
$00000002 constant PWR_S_PWR_CPUCR_CSSF                             \ Clear Standby and Stop flags (always read as 0)
$00000100 constant PWR_S_PWR_CPUCR_STOPF                            \ Stop flag
$00000200 constant PWR_S_PWR_CPUCR_SBF                              \ Standby flag
$00010000 constant PWR_S_PWR_CPUCR_SVOS                             \ System Stop mode voltage scaling selection


\
\ @brief PWR supply voltage monitoring control register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant PWR_S_PWR_SVMCR1_VDDIO4VMEN                      \ Vless thansub>DDIO4 less than/sub>independent I/O voltage monitor enable
$00000100 constant PWR_S_PWR_SVMCR1_VDDIO4SV                        \ Vless thansub>DDIO4 less than/sub>independent I/O supply valid.
$00010000 constant PWR_S_PWR_SVMCR1_VDDIO4RDY                       \ Vless thansub>DDIO4 less than/sub>ready
$01000000 constant PWR_S_PWR_SVMCR1_VDDIO4VRSEL                     \ Vless thansub>DDIO4less than/sub> I/O voltage range selection
$02000000 constant PWR_S_PWR_SVMCR1_VDDIO4VRSTBY                    \ Vless thansub>DDIO4less than/sub> I/O voltage range Standby mode


\
\ @brief PWR supply voltage monitoring control register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant PWR_S_PWR_SVMCR2_VDDIO5VMEN                      \ Vless thansub>DDIO5 less than/sub>independent voltage monitor enable
$00000100 constant PWR_S_PWR_SVMCR2_VDDIO5SV                        \ Vless thansub>DDIO5 less than/sub>independent supply valid
$00010000 constant PWR_S_PWR_SVMCR2_VDDIO5RDY                       \ Vless thansub>DDIO5 less than/sub>ready
$01000000 constant PWR_S_PWR_SVMCR2_VDDIO5VRSEL                     \ Vless thansub>DDIO5less than/sub> I/O voltage range selection
$02000000 constant PWR_S_PWR_SVMCR2_VDDIO5VRSTBY                    \ Vless thansub>DDIO5less than/sub> I/O voltage range Standby mode


\
\ @brief PWR supply voltage monitoring control register 3
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant PWR_S_PWR_SVMCR3_VDDIO2VMEN                      \ Vless thansub>DDIO2 less than/sub>independent voltage monitor enable
$00000002 constant PWR_S_PWR_SVMCR3_VDDIO3VMEN                      \ Vless thansub>DDIO3 less than/sub>independent voltage monitor enable
$00000004 constant PWR_S_PWR_SVMCR3_USB33VMEN                       \ Vless thansub>DD33USB less than/sub>independent USB 33 voltage monitor enable.
$00000010 constant PWR_S_PWR_SVMCR3_AVMEN                           \ Vless thansub>DDA18ADC less than/sub>independent ADC voltage monitor enable
$00000100 constant PWR_S_PWR_SVMCR3_VDDIO2SV                        \ Vless thansub>DDIO2 less than/sub>independent supply valid.
$00000200 constant PWR_S_PWR_SVMCR3_VDDIO3SV                        \ Vless thansub>DDIO3 less than/sub>independent supply valid
$00000400 constant PWR_S_PWR_SVMCR3_USB33SV                         \ Vless thansub>DD33USB less than/sub>independent supply valid
$00001000 constant PWR_S_PWR_SVMCR3_ASV                             \ Vless thansub>DDA18ADC less than/sub>independent supply valid
$00010000 constant PWR_S_PWR_SVMCR3_VDDIO2RDY                       \ Vless thansub>DDIO2 less than/sub>ready
$00020000 constant PWR_S_PWR_SVMCR3_VDDIO3RDY                       \ Vless thansub>DDIO3 less than/sub>ready
$00040000 constant PWR_S_PWR_SVMCR3_USB33RDY                        \ Vless thansub>DD33USB less than/sub>ready
$00100000 constant PWR_S_PWR_SVMCR3_ARDY                            \ Vless thansub>DDA18ADC less than/sub>ready
$01000000 constant PWR_S_PWR_SVMCR3_VDDIOVRSEL                      \ Vless thansub>DDless than/sub> I/O voltage range selection
$02000000 constant PWR_S_PWR_SVMCR3_VDDIO2VRSEL                     \ Vless thansub>DDIO2less than/sub> I/O voltage range selection
$04000000 constant PWR_S_PWR_SVMCR3_VDDIO3VRSEL                     \ Vless thansub>DDIO3less than/sub> I/O voltage range selection


\
\ @brief PWR wake-up clear register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant PWR_S_PWR_WKUPCR_WKUPC1                          \ Clear wake-up flag for WKUP1 pin
$00000002 constant PWR_S_PWR_WKUPCR_WKUPC2                          \ Clear wake-up flag for WKUP2 pin
$00000004 constant PWR_S_PWR_WKUPCR_WKUPC3                          \ Clear wake-up flag for WKUP3 pin
$00000008 constant PWR_S_PWR_WKUPCR_WKUPC4                          \ Clear wake-up flag for WKUP4 pin


\
\ @brief PWR wake-up status register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant PWR_S_PWR_WKUPSR_WKUPF1                          \ Wake-up flag for WKUP1 pin before enable
$00000002 constant PWR_S_PWR_WKUPSR_WKUPF2                          \ Wake-up flag for WKUP2 pin before enable
$00000004 constant PWR_S_PWR_WKUPSR_WKUPF3                          \ Wake-up flag for WKUP3 pin before enable
$00000008 constant PWR_S_PWR_WKUPSR_WKUPF4                          \ Wake-up flag for WKUP4 pin before enable


\
\ @brief PWR wake-up enable and polarity register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant PWR_S_PWR_WKUPEPR_WKUPEN1                        \ Enable WKUP1 pin
$00000002 constant PWR_S_PWR_WKUPEPR_WKUPEN2                        \ Enable WKUP2 pin
$00000004 constant PWR_S_PWR_WKUPEPR_WKUPEN3                        \ Enable WKUP3 pin
$00000008 constant PWR_S_PWR_WKUPEPR_WKUPEN4                        \ Enable WKUP4 pin
$00000100 constant PWR_S_PWR_WKUPEPR_WKUPP1                         \ Wake-up polarity bit for WKUP1 pin
$00000200 constant PWR_S_PWR_WKUPEPR_WKUPP2                         \ Wake-up polarity bit for WKUP2 pin
$00000400 constant PWR_S_PWR_WKUPEPR_WKUPP3                         \ Wake-up polarity bit for WKUP3 pin
$00000800 constant PWR_S_PWR_WKUPEPR_WKUPP4                         \ Wake-up polarity bit for WKUP4 pin
$00030000 constant PWR_S_PWR_WKUPEPR_WKUPPUPD1                      \ Wake-up pull configuration for WKUP1 pin
$000c0000 constant PWR_S_PWR_WKUPEPR_WKUPPUPD2                      \ Wake-up pull configuration for WKUP2 pin
$00300000 constant PWR_S_PWR_WKUPEPR_WKUPPUPD3                      \ Wake-up pull configuration for WKUP3 pin
$00c00000 constant PWR_S_PWR_WKUPEPR_WKUPPUPD4                      \ Wake-up pull configuration for WKUP4 pin


\
\ @brief PWR security configuration register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant PWR_S_PWR_SECCFGR_SEC0                           \ System supply configuration secure protection
$00000002 constant PWR_S_PWR_SECCFGR_SEC1                           \ Programmable voltage detector secure protection
$00000004 constant PWR_S_PWR_SECCFGR_SEC2                           \ Vless thansub>DDCOREless than/sub> monitor secure protection
$00000008 constant PWR_S_PWR_SECCFGR_SEC3                           \ I-TCM, D-TCM, and I-TCM FLEXMEM low power control secure protection
$00000010 constant PWR_S_PWR_SECCFGR_SEC4                           \ Voltage scaling selection secure protection
$00000020 constant PWR_S_PWR_SECCFGR_SEC5                           \ Backup domain secure protection
$00000040 constant PWR_S_PWR_SECCFGR_SEC6                           \ CPU power control secure protection
$00000080 constant PWR_S_PWR_SECCFGR_SEC7                           \ Peripheral voltage monitor secure protection
$00010000 constant PWR_S_PWR_SECCFGR_WKUPSEC1                       \ WKUP1 pin secure protection
$00020000 constant PWR_S_PWR_SECCFGR_WKUPSEC2                       \ WKUP2 pin secure protection
$00040000 constant PWR_S_PWR_SECCFGR_WKUPSEC3                       \ WKUP3 pin secure protection
$00080000 constant PWR_S_PWR_SECCFGR_WKUPSEC4                       \ WKUP4 pin secure protection


\
\ @brief PWR privilege configuration register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000001 constant PWR_S_PWR_PRIVCFGR_PRIV0                         \ System supply configuration privileged protection
$00000002 constant PWR_S_PWR_PRIVCFGR_PRIV1                         \ Programmable voltage detector privileged protection
$00000004 constant PWR_S_PWR_PRIVCFGR_PRIV2                         \ Vless thansub>DDCOREless than/sub> monitor privileged protection
$00000008 constant PWR_S_PWR_PRIVCFGR_PRIV3                         \ I-TCM, D-TCM, and I-TCM FLEX MEM low power control privileged protection
$00000010 constant PWR_S_PWR_PRIVCFGR_PRIV4                         \ Voltage scaling selection privileged protection
$00000020 constant PWR_S_PWR_PRIVCFGR_PRIV5                         \ Backup domain privileged protection
$00000040 constant PWR_S_PWR_PRIVCFGR_PRIV6                         \ CPU power control privileged protection
$00000080 constant PWR_S_PWR_PRIVCFGR_PRIV7                         \ Peripheral voltage monitor privileged protection
$00010000 constant PWR_S_PWR_PRIVCFGR_WKUPPRIV1                     \ WKUP1 pin privileged protection
$00020000 constant PWR_S_PWR_PRIVCFGR_WKUPPRIV2                     \ WKUP2 pin privileged protection
$00040000 constant PWR_S_PWR_PRIVCFGR_WKUPPRIV3                     \ WKUP3 pin privileged protection
$00080000 constant PWR_S_PWR_PRIVCFGR_WKUPPRIV4                     \ WKUP4 pin privileged protection


\
\ @brief Power control
\
$56024800 constant PWR_S_PWR_CR1  \ offset: 0x00 : PWR control register 1
$56024804 constant PWR_S_PWR_CR2  \ offset: 0x04 : PWR control register 2
$56024808 constant PWR_S_PWR_CR3  \ offset: 0x08 : PWR control register 3
$5602480c constant PWR_S_PWR_CR4  \ offset: 0x0C : PWR control register 4
$56024820 constant PWR_S_PWR_VOSCR  \ offset: 0x20 : PWR voltage scaling control register
$56024824 constant PWR_S_PWR_BDCR1  \ offset: 0x24 : PWR backup domain control register 1
$56024828 constant PWR_S_PWR_BDCR2  \ offset: 0x28 : PWR backup domain control register 2
$5602482c constant PWR_S_PWR_DBPCR  \ offset: 0x2C : PWR disable backup protection control register
$56024830 constant PWR_S_PWR_CPUCR  \ offset: 0x30 : PWR CPU control register
$56024834 constant PWR_S_PWR_SVMCR1  \ offset: 0x34 : PWR supply voltage monitoring control register 1
$56024838 constant PWR_S_PWR_SVMCR2  \ offset: 0x38 : PWR supply voltage monitoring control register 2
$5602483c constant PWR_S_PWR_SVMCR3  \ offset: 0x3C : PWR supply voltage monitoring control register 3
$56024850 constant PWR_S_PWR_WKUPCR  \ offset: 0x50 : PWR wake-up clear register
$56024854 constant PWR_S_PWR_WKUPSR  \ offset: 0x54 : PWR wake-up status register
$56024858 constant PWR_S_PWR_WKUPEPR  \ offset: 0x58 : PWR wake-up enable and polarity register
$56024870 constant PWR_S_PWR_SECCFGR  \ offset: 0x70 : PWR security configuration register
$56024874 constant PWR_S_PWR_PRIVCFGR  \ offset: 0x74 : PWR privilege configuration register

