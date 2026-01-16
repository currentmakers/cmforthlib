\
\ @file sec_rtc.fs
\ @brief Real-time clock
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief time register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000000f constant SEC_RTC_TR_SU                                    \ Second units in BCD format
$00000070 constant SEC_RTC_TR_ST                                    \ Second tens in BCD format
$00000f00 constant SEC_RTC_TR_MNU                                   \ Minute units in BCD format
$00007000 constant SEC_RTC_TR_MNT                                   \ Minute tens in BCD format
$000f0000 constant SEC_RTC_TR_HU                                    \ Hour units in BCD format
$00300000 constant SEC_RTC_TR_HT                                    \ Hour tens in BCD format
$00400000 constant SEC_RTC_TR_PM                                    \ AM/PM notation


\
\ @brief date register
\ Address offset: 0x04
\ Reset value: 0x00002101
\

$0000000f constant SEC_RTC_DR_DU                                    \ Date units in BCD format
$00000030 constant SEC_RTC_DR_DT                                    \ Date tens in BCD format
$00000f00 constant SEC_RTC_DR_MU                                    \ Month units in BCD format
$00001000 constant SEC_RTC_DR_MT                                    \ Month tens in BCD format
$0000e000 constant SEC_RTC_DR_WDU                                   \ Week day units
$000f0000 constant SEC_RTC_DR_YU                                    \ Year units in BCD format
$00f00000 constant SEC_RTC_DR_YT                                    \ Year tens in BCD format


\
\ @brief RTC sub second register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant SEC_RTC_SSR_SS                                   \ SS


\
\ @brief RTC initialization control and status register
\ Address offset: 0x0C
\ Reset value: 0x00000007
\

$00000004 constant SEC_RTC_ICSR_WUTWF                               \ Wakeup timer write flag
$00000008 constant SEC_RTC_ICSR_SHPF                                \ Shift operation pending
$00000010 constant SEC_RTC_ICSR_INITS                               \ Initialization status flag
$00000020 constant SEC_RTC_ICSR_RSF                                 \ Registers synchronization flag
$00000040 constant SEC_RTC_ICSR_INITF                               \ Initialization flag
$00000080 constant SEC_RTC_ICSR_INIT                                \ Initialization mode
$00000300 constant SEC_RTC_ICSR_BIN                                 \ BIN
$00001c00 constant SEC_RTC_ICSR_BCDU                                \ BCDU
$00010000 constant SEC_RTC_ICSR_RECALPF                             \ Recalibration pending Flag


\
\ @brief prescaler register
\ Address offset: 0x10
\ Reset value: 0x007F00FF
\

$00007fff constant SEC_RTC_PRER_PREDIV_S                            \ Synchronous prescaler factor
$007f0000 constant SEC_RTC_PRER_PREDIV_A                            \ Asynchronous prescaler factor


\
\ @brief wakeup timer register
\ Address offset: 0x14
\ Reset value: 0x0000FFFF
\

$0000ffff constant SEC_RTC_WUTR_WUT                                 \ Wakeup auto-reload value bits
$ffff0000 constant SEC_RTC_WUTR_WUTOCLR                             \ WUTOCLR


\
\ @brief RTC control register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000007 constant SEC_RTC_CR_WUCKSEL                               \ WUCKSEL
$00000008 constant SEC_RTC_CR_TSEDGE                                \ TSEDGE
$00000010 constant SEC_RTC_CR_REFCKON                               \ REFCKON
$00000020 constant SEC_RTC_CR_BYPSHAD                               \ BYPSHAD
$00000040 constant SEC_RTC_CR_FMT                                   \ FMT
$00000080 constant SEC_RTC_CR_SSRUIE                                \ SSRUIE
$00000100 constant SEC_RTC_CR_ALRAE                                 \ ALRAE
$00000200 constant SEC_RTC_CR_ALRBE                                 \ ALRBE
$00000400 constant SEC_RTC_CR_WUTE                                  \ WUTE
$00000800 constant SEC_RTC_CR_TSE                                   \ TSE
$00001000 constant SEC_RTC_CR_ALRAIE                                \ ALRAIE
$00002000 constant SEC_RTC_CR_ALRBIE                                \ ALRBIE
$00004000 constant SEC_RTC_CR_WUTIE                                 \ WUTIE
$00008000 constant SEC_RTC_CR_TSIE                                  \ TSIE
$00010000 constant SEC_RTC_CR_ADD1H                                 \ ADD1H
$00020000 constant SEC_RTC_CR_SUB1H                                 \ SUB1H
$00040000 constant SEC_RTC_CR_BKP                                   \ BKP
$00080000 constant SEC_RTC_CR_COSEL                                 \ COSEL
$00100000 constant SEC_RTC_CR_POL                                   \ POL
$00600000 constant SEC_RTC_CR_OSEL                                  \ OSEL
$00800000 constant SEC_RTC_CR_COE                                   \ COE
$01000000 constant SEC_RTC_CR_ITSE                                  \ ITSE
$02000000 constant SEC_RTC_CR_TAMPTS                                \ TAMPTS
$04000000 constant SEC_RTC_CR_TAMPOE                                \ TAMPOE
$08000000 constant SEC_RTC_CR_ALRAFCLR                              \ ALRAFCLR
$10000000 constant SEC_RTC_CR_ALRBFCLR                              \ ALRBFCLR
$20000000 constant SEC_RTC_CR_TAMPALRM_PU                           \ TAMPALRM_PU
$40000000 constant SEC_RTC_CR_TAMPALRM_TYPE                         \ TAMPALRM_TYPE
$80000000 constant SEC_RTC_CR_OUT2EN                                \ OUT2EN


\
\ @brief RTC privilege mode control register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SEC_RTC_PRIVCR_ALRAPRIV                          \ ALRAPRIV
$00000002 constant SEC_RTC_PRIVCR_ALRBPRIV                          \ ALRBPRIV
$00000004 constant SEC_RTC_PRIVCR_WUTPRIV                           \ WUTPRIV
$00000008 constant SEC_RTC_PRIVCR_TSPRIV                            \ TSPRIV
$00002000 constant SEC_RTC_PRIVCR_CALPRIV                           \ CALPRIV
$00004000 constant SEC_RTC_PRIVCR_INITPRIV                          \ INITPRIV
$00008000 constant SEC_RTC_PRIVCR_PRIV                              \ PRIV


\
\ @brief RTC secure mode control register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SEC_RTC_SECCFGR_ALRASEC                          \ ALRASEC
$00000002 constant SEC_RTC_SECCFGR_ALRBSEC                          \ ALRBSEC
$00000004 constant SEC_RTC_SECCFGR_WUTSEC                           \ WUTSEC
$00000008 constant SEC_RTC_SECCFGR_TSSEC                            \ TSSEC
$00002000 constant SEC_RTC_SECCFGR_CALSEC                           \ CALSEC
$00004000 constant SEC_RTC_SECCFGR_INITSEC                          \ INITSEC
$00008000 constant SEC_RTC_SECCFGR_SEC                              \ SEC


\
\ @brief write protection register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant SEC_RTC_WPR_KEY                                  \ Write protection key


\
\ @brief calibration register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000001ff constant SEC_RTC_CALR_CALM                                \ Calibration minus
$00001000 constant SEC_RTC_CALR_LPCAL                               \ LPCAL
$00002000 constant SEC_RTC_CALR_CALW16                              \ Use a 16-second calibration cycle period
$00004000 constant SEC_RTC_CALR_CALW8                               \ Use an 8-second calibration cycle period
$00008000 constant SEC_RTC_CALR_CALP                                \ Increase frequency of RTC by 488.5 ppm


\
\ @brief shift control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00007fff constant SEC_RTC_SHIFTR_SUBFS                             \ Subtract a fraction of a second
$80000000 constant SEC_RTC_SHIFTR_ADD1S                             \ Add one second


\
\ @brief time stamp time register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000000f constant SEC_RTC_TSTR_SU                                  \ Second units in BCD format
$00000070 constant SEC_RTC_TSTR_ST                                  \ Second tens in BCD format
$00000f00 constant SEC_RTC_TSTR_MNU                                 \ Minute units in BCD format
$00007000 constant SEC_RTC_TSTR_MNT                                 \ Minute tens in BCD format
$000f0000 constant SEC_RTC_TSTR_HU                                  \ Hour units in BCD format
$00300000 constant SEC_RTC_TSTR_HT                                  \ Hour tens in BCD format
$00400000 constant SEC_RTC_TSTR_PM                                  \ AM/PM notation


\
\ @brief time stamp date register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000000f constant SEC_RTC_TSDR_DU                                  \ Date units in BCD format
$00000030 constant SEC_RTC_TSDR_DT                                  \ Date tens in BCD format
$00000f00 constant SEC_RTC_TSDR_MU                                  \ Month units in BCD format
$00001000 constant SEC_RTC_TSDR_MT                                  \ Month tens in BCD format
$0000e000 constant SEC_RTC_TSDR_WDU                                 \ Week day units


\
\ @brief timestamp sub second register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant SEC_RTC_TSSSR_SS                                 \ Sub second value


\
\ @brief alarm A register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000000f constant SEC_RTC_ALRMAR_SU                                \ Second units in BCD format
$00000070 constant SEC_RTC_ALRMAR_ST                                \ Second tens in BCD format
$00000080 constant SEC_RTC_ALRMAR_MSK1                              \ Alarm A seconds mask
$00000f00 constant SEC_RTC_ALRMAR_MNU                               \ Minute units in BCD format
$00007000 constant SEC_RTC_ALRMAR_MNT                               \ Minute tens in BCD format
$00008000 constant SEC_RTC_ALRMAR_MSK2                              \ Alarm A minutes mask
$000f0000 constant SEC_RTC_ALRMAR_HU                                \ Hour units in BCD format
$00300000 constant SEC_RTC_ALRMAR_HT                                \ Hour tens in BCD format
$00400000 constant SEC_RTC_ALRMAR_PM                                \ AM/PM notation
$00800000 constant SEC_RTC_ALRMAR_MSK3                              \ Alarm A hours mask
$0f000000 constant SEC_RTC_ALRMAR_DU                                \ Date units or day in BCD format
$30000000 constant SEC_RTC_ALRMAR_DT                                \ Date tens in BCD format
$40000000 constant SEC_RTC_ALRMAR_WDSEL                             \ Week day selection
$80000000 constant SEC_RTC_ALRMAR_MSK4                              \ Alarm A date mask


\
\ @brief alarm A sub second register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00007fff constant SEC_RTC_ALRMASSR_SS                              \ Sub seconds value
$3f000000 constant SEC_RTC_ALRMASSR_MASKSS                          \ Mask the most-significant bits starting at this bit
$80000000 constant SEC_RTC_ALRMASSR_SSCLR                           \ SSCLR


\
\ @brief alarm B register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000000f constant SEC_RTC_ALRMBR_SU                                \ Second units in BCD format
$00000070 constant SEC_RTC_ALRMBR_ST                                \ Second tens in BCD format
$00000080 constant SEC_RTC_ALRMBR_MSK1                              \ Alarm B seconds mask
$00000f00 constant SEC_RTC_ALRMBR_MNU                               \ Minute units in BCD format
$00007000 constant SEC_RTC_ALRMBR_MNT                               \ Minute tens in BCD format
$00008000 constant SEC_RTC_ALRMBR_MSK2                              \ Alarm B minutes mask
$000f0000 constant SEC_RTC_ALRMBR_HU                                \ Hour units in BCD format
$00300000 constant SEC_RTC_ALRMBR_HT                                \ Hour tens in BCD format
$00400000 constant SEC_RTC_ALRMBR_PM                                \ AM/PM notation
$00800000 constant SEC_RTC_ALRMBR_MSK3                              \ Alarm B hours mask
$0f000000 constant SEC_RTC_ALRMBR_DU                                \ Date units or day in BCD format
$30000000 constant SEC_RTC_ALRMBR_DT                                \ Date tens in BCD format
$40000000 constant SEC_RTC_ALRMBR_WDSEL                             \ Week day selection
$80000000 constant SEC_RTC_ALRMBR_MSK4                              \ Alarm B date mask


\
\ @brief alarm B sub second register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00007fff constant SEC_RTC_ALRMBSSR_SS                              \ Sub seconds value
$3f000000 constant SEC_RTC_ALRMBSSR_MASKSS                          \ Mask the most-significant bits starting at this bit
$80000000 constant SEC_RTC_ALRMBSSR_SSCLR                           \ SSCLR


\
\ @brief RTC status register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant SEC_RTC_SR_ALRAF                                 \ ALRAF
$00000002 constant SEC_RTC_SR_ALRBF                                 \ ALRBF
$00000004 constant SEC_RTC_SR_WUTF                                  \ WUTF
$00000008 constant SEC_RTC_SR_TSF                                   \ TSF
$00000010 constant SEC_RTC_SR_TSOVF                                 \ TSOVF
$00000020 constant SEC_RTC_SR_ITSF                                  \ ITSF
$00000040 constant SEC_RTC_SR_SSRUF                                 \ SSRUF


\
\ @brief RTC non-secure masked interrupt status register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant SEC_RTC_MISR_ALRAMF                              \ ALRAMF
$00000002 constant SEC_RTC_MISR_ALRBMF                              \ ALRBMF
$00000004 constant SEC_RTC_MISR_WUTMF                               \ WUTMF
$00000008 constant SEC_RTC_MISR_TSMF                                \ TSMF
$00000010 constant SEC_RTC_MISR_TSOVMF                              \ TSOVMF
$00000020 constant SEC_RTC_MISR_ITSMF                               \ ITSMF
$00000040 constant SEC_RTC_MISR_SSRUMF                              \ SSRUMF


\
\ @brief RTC secure masked interrupt status register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant SEC_RTC_SMISR_ALRAMF                             \ ALRAMF
$00000002 constant SEC_RTC_SMISR_ALRBMF                             \ ALRBMF
$00000004 constant SEC_RTC_SMISR_WUTMF                              \ WUTMF
$00000008 constant SEC_RTC_SMISR_TSMF                               \ TSMF
$00000010 constant SEC_RTC_SMISR_TSOVMF                             \ TSOVMF
$00000020 constant SEC_RTC_SMISR_ITSMF                              \ ITSMF
$00000040 constant SEC_RTC_SMISR_SSRUMF                             \ SSRUMF


\
\ @brief RTC status clear register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant SEC_RTC_SCR_CALRAF                               \ CALRAF
$00000002 constant SEC_RTC_SCR_CALRBF                               \ CALRBF
$00000004 constant SEC_RTC_SCR_CWUTF                                \ CWUTF
$00000008 constant SEC_RTC_SCR_CTSF                                 \ CTSF
$00000010 constant SEC_RTC_SCR_CTSOVF                               \ CTSOVF
$00000020 constant SEC_RTC_SCR_CITSF                                \ CITSF
$00000040 constant SEC_RTC_SCR_CSSRUF                               \ CSSRUF


\
\ @brief RTC alarm A binary mode register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant SEC_RTC_ALRABINR_SS                              \ Synchronous counter alarm value in Binary mode


\
\ @brief RTC alarm B binary mode register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant SEC_RTC_ALRBBINR_SS                              \ Synchronous counter alarm value in Binary mode


\
\ @brief Real-time clock
\
$56007800 constant SEC_RTC_TR     \ offset: 0x00 : time register
$56007804 constant SEC_RTC_DR     \ offset: 0x04 : date register
$56007808 constant SEC_RTC_SSR    \ offset: 0x08 : RTC sub second register
$5600780c constant SEC_RTC_ICSR   \ offset: 0x0C : RTC initialization control and status register
$56007810 constant SEC_RTC_PRER   \ offset: 0x10 : prescaler register
$56007814 constant SEC_RTC_WUTR   \ offset: 0x14 : wakeup timer register
$56007818 constant SEC_RTC_CR     \ offset: 0x18 : RTC control register
$5600781c constant SEC_RTC_PRIVCR  \ offset: 0x1C : RTC privilege mode control register
$56007820 constant SEC_RTC_SECCFGR  \ offset: 0x20 : RTC secure mode control register
$56007824 constant SEC_RTC_WPR    \ offset: 0x24 : write protection register
$56007828 constant SEC_RTC_CALR   \ offset: 0x28 : calibration register
$5600782c constant SEC_RTC_SHIFTR  \ offset: 0x2C : shift control register
$56007830 constant SEC_RTC_TSTR   \ offset: 0x30 : time stamp time register
$56007834 constant SEC_RTC_TSDR   \ offset: 0x34 : time stamp date register
$56007838 constant SEC_RTC_TSSSR  \ offset: 0x38 : timestamp sub second register
$56007840 constant SEC_RTC_ALRMAR  \ offset: 0x40 : alarm A register
$56007844 constant SEC_RTC_ALRMASSR  \ offset: 0x44 : alarm A sub second register
$56007848 constant SEC_RTC_ALRMBR  \ offset: 0x48 : alarm B register
$5600784c constant SEC_RTC_ALRMBSSR  \ offset: 0x4C : alarm B sub second register
$56007850 constant SEC_RTC_SR     \ offset: 0x50 : RTC status register
$56007854 constant SEC_RTC_MISR   \ offset: 0x54 : RTC non-secure masked interrupt status register
$56007858 constant SEC_RTC_SMISR  \ offset: 0x58 : RTC secure masked interrupt status register
$5600785c constant SEC_RTC_SCR    \ offset: 0x5C : RTC status clear register
$56007870 constant SEC_RTC_ALRABINR  \ offset: 0x70 : RTC alarm A binary mode register
$56007874 constant SEC_RTC_ALRBBINR  \ offset: 0x74 : RTC alarm B binary mode register

