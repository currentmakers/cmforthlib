\
\ @file rtc.fs
\ @brief RTC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief The RTC_TR is the calendar time shadow register. This register must be written in initialization mode only. Refer to Calendar initialization and configuration on page1830 and Reading the calendar on page1831. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be write-protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000000f constant RTC_RTC_TR_SU                                    \ SU
$00000070 constant RTC_RTC_TR_ST                                    \ ST
$00000f00 constant RTC_RTC_TR_MNU                                   \ MNU
$00007000 constant RTC_RTC_TR_MNT                                   \ MNT
$000f0000 constant RTC_RTC_TR_HU                                    \ HU
$00300000 constant RTC_RTC_TR_HT                                    \ HT
$00400000 constant RTC_RTC_TR_PM                                    \ PM


\
\ @brief The RTC_DR is the calendar date shadow register. This register must be written in initialization mode only. Refer to Calendar initialization and configuration on page1830 and Reading the calendar on page1831. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be write-protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
\ Address offset: 0x04
\ Reset value: 0x00002101
\

$0000000f constant RTC_RTC_DR_DU                                    \ DU
$00000030 constant RTC_RTC_DR_DT                                    \ DT
$00000f00 constant RTC_RTC_DR_MU                                    \ MU
$00001000 constant RTC_RTC_DR_MT                                    \ MT
$0000e000 constant RTC_RTC_DR_WDU                                   \ WDU
$000f0000 constant RTC_RTC_DR_YU                                    \ YU
$00f00000 constant RTC_RTC_DR_YT                                    \ YT


\
\ @brief RTC sub second register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000ffff constant RTC_RTC_SSR_SS                                   \ SS


\
\ @brief This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be globally protected, or each bit of this register can be individually protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
\ Address offset: 0x0C
\ Reset value: 0x00000007
\

$00000001 constant RTC_RTC_ICSR_ALRAWF                              \ ALRAWF
$00000002 constant RTC_RTC_ICSR_ALRBWF                              \ ALRBWF
$00000004 constant RTC_RTC_ICSR_WUTWF                               \ WUTWF
$00000008 constant RTC_RTC_ICSR_SHPF                                \ SHPF
$00000010 constant RTC_RTC_ICSR_INITS                               \ INITS
$00000020 constant RTC_RTC_ICSR_RSF                                 \ RSF
$00000040 constant RTC_RTC_ICSR_INITF                               \ INITF
$00000080 constant RTC_RTC_ICSR_INIT                                \ INIT
$00010000 constant RTC_RTC_ICSR_RECALPF                             \ RECALPF


\
\ @brief This register must be written in initialization mode only. The initialization must be performed in two separate write accesses. Refer to Calendar initialization and configuration on page1830. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be write-protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
\ Address offset: 0x10
\ Reset value: 0x007F00FF
\

$00007fff constant RTC_RTC_PRER_PREDIV_S                            \ PREDIV_S
$007f0000 constant RTC_RTC_PRER_PREDIV_A                            \ PREDIV_A


\
\ @brief This register can be written only when WUTWF is set to 1 in RTC_ICSR. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
\ Address offset: 0x14
\ Reset value: 0x0000FFFF
\

$0000ffff constant RTC_RTC_WUTR_WUT                                 \ WUT


\
\ @brief This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be globally protected, or each bit of this register can be individually protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000007 constant RTC_RTC_CR_WUCKSEL                               \ WUCKSEL
$00000008 constant RTC_RTC_CR_TSEDGE                                \ TSEDGE
$00000010 constant RTC_RTC_CR_REFCKON                               \ REFCKON
$00000020 constant RTC_RTC_CR_BYPSHAD                               \ BYPSHAD
$00000040 constant RTC_RTC_CR_FMT                                   \ FMT
$00000100 constant RTC_RTC_CR_ALRAE                                 \ ALRAE
$00000200 constant RTC_RTC_CR_ALRBE                                 \ ALRBE
$00000400 constant RTC_RTC_CR_WUTE                                  \ WUTE
$00000800 constant RTC_RTC_CR_TSE                                   \ TSE
$00001000 constant RTC_RTC_CR_ALRAIE                                \ ALRAIE
$00002000 constant RTC_RTC_CR_ALRBIE                                \ ALRBIE
$00004000 constant RTC_RTC_CR_WUTIE                                 \ WUTIE
$00008000 constant RTC_RTC_CR_TSIE                                  \ TSIE
$00010000 constant RTC_RTC_CR_ADD1H                                 \ ADD1H
$00020000 constant RTC_RTC_CR_SUB1H                                 \ SUB1H
$00040000 constant RTC_RTC_CR_BKP                                   \ BKP
$00080000 constant RTC_RTC_CR_COSEL                                 \ COSEL
$00100000 constant RTC_RTC_CR_POL                                   \ POL
$00600000 constant RTC_RTC_CR_OSEL                                  \ OSEL
$00800000 constant RTC_RTC_CR_COE                                   \ COE
$01000000 constant RTC_RTC_CR_ITSE                                  \ ITSE
$02000000 constant RTC_RTC_CR_TAMPTS                                \ TAMPTS
$04000000 constant RTC_RTC_CR_TAMPOE                                \ TAMPOE
$20000000 constant RTC_RTC_CR_TAMPALRM_PU                           \ TAMPALRM_PU
$40000000 constant RTC_RTC_CR_TAMPALRM_TYPE                         \ TAMPALRM_TYPE
$80000000 constant RTC_RTC_CR_OUT2EN                                \ OUT2EN


\
\ @brief This register can be written only when the APB access is secure.
\ Address offset: 0x20
\ Reset value: 0x0000E00F
\

$00000001 constant RTC_RTC_SMCR_ALRADPROT                           \ ALRADPROT
$00000002 constant RTC_RTC_SMCR_ALRBDPROT                           \ ALRBDPROT
$00000004 constant RTC_RTC_SMCR_WUTDPROT                            \ WUTDPROT
$00000008 constant RTC_RTC_SMCR_TSDPROT                             \ TSDPROT
$00002000 constant RTC_RTC_SMCR_CALDPROT                            \ CALDPROT
$00004000 constant RTC_RTC_SMCR_INITDPROT                           \ INITDPROT
$00008000 constant RTC_RTC_SMCR_DECPROT                             \ DECPROT


\
\ @brief RTC write protection register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant RTC_RTC_WPR_KEY                                  \ KEY


\
\ @brief This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be write-protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000001ff constant RTC_RTC_CALR_CALM                                \ CALM
$00002000 constant RTC_RTC_CALR_CALW16                              \ CALW16
$00004000 constant RTC_RTC_CALR_CALW8                               \ CALW8
$00008000 constant RTC_RTC_CALR_CALP                                \ CALP


\
\ @brief This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00007fff constant RTC_RTC_SHIFTR_SUBFS                             \ SUBFS
$80000000 constant RTC_RTC_SHIFTR_ADD1S                             \ ADD1S


\
\ @brief The content of this register is valid only when TSF is set to 1 in RTC_SR. It is cleared when TSF bit is reset. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000000f constant RTC_RTC_TSTR_SU                                  \ SU
$00000070 constant RTC_RTC_TSTR_ST                                  \ ST
$00000f00 constant RTC_RTC_TSTR_MNU                                 \ MNU
$00007000 constant RTC_RTC_TSTR_MNT                                 \ MNT
$000f0000 constant RTC_RTC_TSTR_HU                                  \ HU
$00300000 constant RTC_RTC_TSTR_HT                                  \ HT
$00400000 constant RTC_RTC_TSTR_PM                                  \ PM


\
\ @brief The content of this register is valid only when TSF is set to 1 in RTC_SR. It is cleared when TSF bit is reset. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000000f constant RTC_RTC_TSDR_DU                                  \ DU
$00000030 constant RTC_RTC_TSDR_DT                                  \ DT
$00000f00 constant RTC_RTC_TSDR_MU                                  \ MU
$00001000 constant RTC_RTC_TSDR_MT                                  \ MT
$0000e000 constant RTC_RTC_TSDR_WDU                                 \ WDU


\
\ @brief The content of this register is valid only when TSF is set to 1 in RTC_SR. It is cleared when the TSF bit is reset. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant RTC_RTC_TSSSR_SS                                 \ SS


\
\ @brief This register can be written only when ALRAWF is set to 1 in RTC_ICSR, or in initialization mode. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000000f constant RTC_RTC_ALRMAR_SU                                \ SU
$00000070 constant RTC_RTC_ALRMAR_ST                                \ ST
$00000080 constant RTC_RTC_ALRMAR_MSK1                              \ MSK1
$00000f00 constant RTC_RTC_ALRMAR_MNU                               \ MNU
$00007000 constant RTC_RTC_ALRMAR_MNT                               \ MNT
$00008000 constant RTC_RTC_ALRMAR_MSK2                              \ MSK2
$000f0000 constant RTC_RTC_ALRMAR_HU                                \ HU
$00300000 constant RTC_RTC_ALRMAR_HT                                \ HT
$00400000 constant RTC_RTC_ALRMAR_PM                                \ PM
$00800000 constant RTC_RTC_ALRMAR_MSK3                              \ MSK3
$0f000000 constant RTC_RTC_ALRMAR_DU                                \ DU
$30000000 constant RTC_RTC_ALRMAR_DT                                \ DT
$40000000 constant RTC_RTC_ALRMAR_WDSEL                             \ WDSEL
$80000000 constant RTC_RTC_ALRMAR_MSK4                              \ MSK4


\
\ @brief This register can be written only when ALRAWF is set to 1 in RTC_ICSR, or in initialization mode. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00007fff constant RTC_RTC_ALRMASSR_SS                              \ SS
$0f000000 constant RTC_RTC_ALRMASSR_MASKSS                          \ MASKSS


\
\ @brief This register can be written only when ALRBWF is set to 1 in RTC_ICSR, or in initialization mode. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000000f constant RTC_RTC_ALRMBR_SU                                \ SU
$00000070 constant RTC_RTC_ALRMBR_ST                                \ ST
$00000080 constant RTC_RTC_ALRMBR_MSK1                              \ MSK1
$00000f00 constant RTC_RTC_ALRMBR_MNU                               \ MNU
$00007000 constant RTC_RTC_ALRMBR_MNT                               \ MNT
$00008000 constant RTC_RTC_ALRMBR_MSK2                              \ MSK2
$000f0000 constant RTC_RTC_ALRMBR_HU                                \ HU
$00300000 constant RTC_RTC_ALRMBR_HT                                \ HT
$00400000 constant RTC_RTC_ALRMBR_PM                                \ PM
$00800000 constant RTC_RTC_ALRMBR_MSK3                              \ MSK3
$0f000000 constant RTC_RTC_ALRMBR_DU                                \ DU
$30000000 constant RTC_RTC_ALRMBR_DT                                \ DT
$40000000 constant RTC_RTC_ALRMBR_WDSEL                             \ WDSEL
$80000000 constant RTC_RTC_ALRMBR_MSK4                              \ MSK4


\
\ @brief This register can be written only when ALRBE is reset in RTC_CR register, or in initialization mode. This register is write protected.The write access procedure is described in Section: RTC register write protection. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00007fff constant RTC_RTC_ALRMBSSR_SS                              \ SS
$0f000000 constant RTC_RTC_ALRMBSSR_MASKSS                          \ MASKSS


\
\ @brief This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant RTC_RTC_SR_ALRAF                                 \ ALRAF
$00000002 constant RTC_RTC_SR_ALRBF                                 \ ALRBF
$00000004 constant RTC_RTC_SR_WUTF                                  \ WUTF
$00000008 constant RTC_RTC_SR_TSF                                   \ TSF
$00000010 constant RTC_RTC_SR_TSOVF                                 \ TSOVF
$00000020 constant RTC_RTC_SR_ITSF                                  \ ITSF


\
\ @brief RTC non-secure masked interrupt status register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant RTC_RTC_MISR_ALRAMF                              \ ALRAMF
$00000002 constant RTC_RTC_MISR_ALRBMF                              \ ALRBMF
$00000004 constant RTC_RTC_MISR_WUTMF                               \ WUTMF
$00000008 constant RTC_RTC_MISR_TSMF                                \ TSMF
$00000010 constant RTC_RTC_MISR_TSOVMF                              \ TSOVMF
$00000020 constant RTC_RTC_MISR_ITSMF                               \ ITSMF


\
\ @brief This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant RTC_RTC_SMISR_ALRAMF                             \ ALRAMF
$00000002 constant RTC_RTC_SMISR_ALRBMF                             \ ALRBMF
$00000004 constant RTC_RTC_SMISR_WUTMF                              \ WUTMF
$00000008 constant RTC_RTC_SMISR_TSMF                               \ TSMF
$00000010 constant RTC_RTC_SMISR_TSOVMF                             \ TSOVMF
$00000020 constant RTC_RTC_SMISR_ITSMF                              \ ITSMF


\
\ @brief This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant RTC_RTC_SCR_CALRAF                               \ CALRAF
$00000002 constant RTC_RTC_SCR_CALRBF                               \ CALRBF
$00000004 constant RTC_RTC_SCR_CWUTF                                \ CWUTF
$00000008 constant RTC_RTC_SCR_CTSF                                 \ CTSF
$00000010 constant RTC_RTC_SCR_CTSOVF                               \ CTSOVF
$00000020 constant RTC_RTC_SCR_CITSF                                \ CITSF


\
\ @brief RTC configuration register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant RTC_RTC_CFGR_OUT2_RMP                            \ OUT2_RMP
$00000006 constant RTC_RTC_CFGR_LSCOEN                              \ LSCOEN


\
\ @brief RTC hardware configuration register
\ Address offset: 0x3F0
\ Reset value: 0x01031111
\

$0000000f constant RTC_RTC_HWCFGR_ALARMB                            \ ALARMB
$000000f0 constant RTC_RTC_HWCFGR_WAKEUP                            \ WAKEUP
$00000f00 constant RTC_RTC_HWCFGR_SMOOTH_CALIB                      \ SMOOTH_CALIB
$0000f000 constant RTC_RTC_HWCFGR_TIMESTAMP                         \ TIMESTAMP
$00ff0000 constant RTC_RTC_HWCFGR_OPTIONREG_OUT                     \ OPTIONREG_OUT
$0f000000 constant RTC_RTC_HWCFGR_TRUST_ZONE                        \ TRUST_ZONE


\
\ @brief RTC version register
\ Address offset: 0x3F4
\ Reset value: 0x00000010
\

$0000000f constant RTC_RTC_VERR_MINREV                              \ MINREV
$000000f0 constant RTC_RTC_VERR_MAJREV                              \ MAJREV


\
\ @brief RTC identification register
\ Address offset: 0x3F8
\ Reset value: 0x00120033
\

$00000000 constant RTC_RTC_IPIDR_ID                                 \ ID


\
\ @brief RTC size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant RTC_RTC_SIDR_SID                                 \ SID


\
\ @brief RTC
\
$5c004000 constant RTC_RTC_TR     \ offset: 0x00 : The RTC_TR is the calendar time shadow register. This register must be written in initialization mode only. Refer to Calendar initialization and configuration on page1830 and Reading the calendar on page1831. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be write-protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
$5c004004 constant RTC_RTC_DR     \ offset: 0x04 : The RTC_DR is the calendar date shadow register. This register must be written in initialization mode only. Refer to Calendar initialization and configuration on page1830 and Reading the calendar on page1831. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be write-protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
$5c004008 constant RTC_RTC_SSR    \ offset: 0x08 : RTC sub second register
$5c00400c constant RTC_RTC_ICSR   \ offset: 0x0C : This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be globally protected, or each bit of this register can be individually protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
$5c004010 constant RTC_RTC_PRER   \ offset: 0x10 : This register must be written in initialization mode only. The initialization must be performed in two separate write accesses. Refer to Calendar initialization and configuration on page1830. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be write-protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
$5c004014 constant RTC_RTC_WUTR   \ offset: 0x14 : This register can be written only when WUTWF is set to 1 in RTC_ICSR. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
$5c004018 constant RTC_RTC_CR     \ offset: 0x18 : This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be globally protected, or each bit of this register can be individually protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
$5c004020 constant RTC_RTC_SMCR   \ offset: 0x20 : This register can be written only when the APB access is secure.
$5c004024 constant RTC_RTC_WPR    \ offset: 0x24 : RTC write protection register
$5c004028 constant RTC_RTC_CALR   \ offset: 0x28 : This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be write-protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
$5c00402c constant RTC_RTC_SHIFTR  \ offset: 0x2C : This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
$5c004030 constant RTC_RTC_TSTR   \ offset: 0x30 : The content of this register is valid only when TSF is set to 1 in RTC_SR. It is cleared when TSF bit is reset. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
$5c004034 constant RTC_RTC_TSDR   \ offset: 0x34 : The content of this register is valid only when TSF is set to 1 in RTC_SR. It is cleared when TSF bit is reset. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
$5c004038 constant RTC_RTC_TSSSR  \ offset: 0x38 : The content of this register is valid only when TSF is set to 1 in RTC_SR. It is cleared when the TSF bit is reset. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
$5c004040 constant RTC_RTC_ALRMAR  \ offset: 0x40 : This register can be written only when ALRAWF is set to 1 in RTC_ICSR, or in initialization mode. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
$5c004044 constant RTC_RTC_ALRMASSR  \ offset: 0x44 : This register can be written only when ALRAWF is set to 1 in RTC_ICSR, or in initialization mode. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
$5c004048 constant RTC_RTC_ALRMBR  \ offset: 0x48 : This register can be written only when ALRBWF is set to 1 in RTC_ICSR, or in initialization mode. This register is write protected. The write access procedure is described in RTC register write protection on page1830. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
$5c00404c constant RTC_RTC_ALRMBSSR  \ offset: 0x4C : This register can be written only when ALRBE is reset in RTC_CR register, or in initialization mode. This register is write protected.The write access procedure is described in Section: RTC register write protection. This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
$5c004050 constant RTC_RTC_SR     \ offset: 0x50 : This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
$5c004054 constant RTC_RTC_MISR   \ offset: 0x54 : RTC non-secure masked interrupt status register
$5c004058 constant RTC_RTC_SMISR  \ offset: 0x58 : This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
$5c00405c constant RTC_RTC_SCR    \ offset: 0x5C : This register can be protected against non-secure access. Refer to Section50.3.4: RTC secure protection modes.
$5c004060 constant RTC_RTC_CFGR   \ offset: 0x60 : RTC configuration register
$5c0043f0 constant RTC_RTC_HWCFGR  \ offset: 0x3F0 : RTC hardware configuration register
$5c0043f4 constant RTC_RTC_VERR   \ offset: 0x3F4 : RTC version register
$5c0043f8 constant RTC_RTC_IPIDR  \ offset: 0x3F8 : RTC identification register
$5c0043fc constant RTC_RTC_SIDR   \ offset: 0x3FC : RTC size identification register

