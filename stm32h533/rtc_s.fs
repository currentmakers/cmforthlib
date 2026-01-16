\
\ @file rtc_s.fs
\ @brief RTC register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RTC time register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000000f constant RTC_S_RTC_TR_SU                                  \ Second units in BCD format
$00000070 constant RTC_S_RTC_TR_ST                                  \ Second tens in BCD format
$00000f00 constant RTC_S_RTC_TR_MNU                                 \ Minute units in BCD format
$00007000 constant RTC_S_RTC_TR_MNT                                 \ Minute tens in BCD format
$000f0000 constant RTC_S_RTC_TR_HU                                  \ Hour units in BCD format
$00300000 constant RTC_S_RTC_TR_HT                                  \ Hour tens in BCD format
$00400000 constant RTC_S_RTC_TR_PM                                  \ AM/PM notation


\
\ @brief RTC date register
\ Address offset: 0x04
\ Reset value: 0x00002101
\

$0000000f constant RTC_S_RTC_DR_DU                                  \ Date units in BCD format
$00000030 constant RTC_S_RTC_DR_DT                                  \ Date tens in BCD format
$00000f00 constant RTC_S_RTC_DR_MU                                  \ Month units in BCD format
$00001000 constant RTC_S_RTC_DR_MT                                  \ Month tens in BCD format
$0000e000 constant RTC_S_RTC_DR_WDU                                 \ Week day units
$000f0000 constant RTC_S_RTC_DR_YU                                  \ Year units in BCD format
$00f00000 constant RTC_S_RTC_DR_YT                                  \ Year tens in BCD format


\
\ @brief RTC subsecond register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant RTC_S_RTC_SSR_SS                                 \ Synchronous binary counter


\
\ @brief RTC initialization control and status register
\ Address offset: 0x0C
\ Reset value: 0x00000007
\

$00000004 constant RTC_S_RTC_ICSR_WUTWF                             \ Wake-up timer write flag
$00000008 constant RTC_S_RTC_ICSR_SHPF                              \ Shift operation pending
$00000010 constant RTC_S_RTC_ICSR_INITS                             \ Initialization status flag
$00000020 constant RTC_S_RTC_ICSR_RSF                               \ Registers synchronization flag
$00000040 constant RTC_S_RTC_ICSR_INITF                             \ Initialization flag
$00000080 constant RTC_S_RTC_ICSR_INIT                              \ Initialization mode
$00000300 constant RTC_S_RTC_ICSR_BIN                               \ Binary mode
$00001c00 constant RTC_S_RTC_ICSR_BCDU                              \ BCD update (BIN = 10 or 11)
$00010000 constant RTC_S_RTC_ICSR_RECALPF                           \ Recalibration pending Flag


\
\ @brief RTC prescaler register
\ Address offset: 0x10
\ Reset value: 0x007F00FF
\

$00007fff constant RTC_S_RTC_PRER_PREDIV_S                          \ Synchronous prescaler factor
$007f0000 constant RTC_S_RTC_PRER_PREDIV_A                          \ Asynchronous prescaler factor


\
\ @brief RTC wake-up timer register
\ Address offset: 0x14
\ Reset value: 0x0000FFFF
\

$0000ffff constant RTC_S_RTC_WUTR_WUT                               \ Wake-up auto-reload value bits
$ffff0000 constant RTC_S_RTC_WUTR_WUTOCLR                           \ Wake-up auto-reload output clear value


\
\ @brief RTC control register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000007 constant RTC_S_RTC_CR_WUCKSEL                             \ ck_wut wake-up clock selection
$00000008 constant RTC_S_RTC_CR_TSEDGE                              \ Timestamp event active edge
$00000010 constant RTC_S_RTC_CR_REFCKON                             \ RTC_REFIN reference clock detection enable (50 or 60 Hz)
$00000020 constant RTC_S_RTC_CR_BYPSHAD                             \ Bypass the shadow registers
$00000040 constant RTC_S_RTC_CR_FMT                                 \ Hour format
$00000080 constant RTC_S_RTC_CR_SSRUIE                              \ SSR underflow interrupt enable
$00000100 constant RTC_S_RTC_CR_ALRAE                               \ Alarm A enable
$00000200 constant RTC_S_RTC_CR_ALRBE                               \ Alarm B enable
$00000400 constant RTC_S_RTC_CR_WUTE                                \ Wake-up timer enable
$00000800 constant RTC_S_RTC_CR_TSE                                 \ timestamp enable
$00001000 constant RTC_S_RTC_CR_ALRAIE                              \ Alarm A interrupt enable
$00002000 constant RTC_S_RTC_CR_ALRBIE                              \ Alarm B interrupt enable
$00004000 constant RTC_S_RTC_CR_WUTIE                               \ Wake-up timer interrupt enable
$00008000 constant RTC_S_RTC_CR_TSIE                                \ Timestamp interrupt enable
$00010000 constant RTC_S_RTC_CR_ADD1H                               \ Add 1 hour (summer time change)
$00020000 constant RTC_S_RTC_CR_SUB1H                               \ Subtract 1 hour (winter time change)
$00040000 constant RTC_S_RTC_CR_BKP                                 \ Backup
$00080000 constant RTC_S_RTC_CR_COSEL                               \ Calibration output selection
$00100000 constant RTC_S_RTC_CR_POL                                 \ Output polarity
$00600000 constant RTC_S_RTC_CR_OSEL                                \ Output selection
$00800000 constant RTC_S_RTC_CR_COE                                 \ Calibration output enable
$01000000 constant RTC_S_RTC_CR_ITSE                                \ timestamp on internal event enable
$02000000 constant RTC_S_RTC_CR_TAMPTS                              \ Activate timestamp on tamper detection event
$04000000 constant RTC_S_RTC_CR_TAMPOE                              \ Tamper detection output enable on TAMPALRM
$08000000 constant RTC_S_RTC_CR_ALRAFCLR                            \ Alarm A flag automatic clear
$10000000 constant RTC_S_RTC_CR_ALRBFCLR                            \ Alarm B flag automatic clear
$20000000 constant RTC_S_RTC_CR_TAMPALRM_PU                         \ TAMPALRM pull-up enable
$40000000 constant RTC_S_RTC_CR_TAMPALRM_TYPE                       \ TAMPALRM output type
$80000000 constant RTC_S_RTC_CR_OUT2EN                              \ RTC_OUT2 output enable


\
\ @brief RTC privilege mode control register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant RTC_S_RTC_PRIVCFGR_ALRAPRIV                      \ Alarm A and SSR underflow privilege protection
$00000002 constant RTC_S_RTC_PRIVCFGR_ALRBPRIV                      \ Alarm B privilege protection
$00000004 constant RTC_S_RTC_PRIVCFGR_WUTPRIV                       \ Wake-up timer privilege protection
$00000008 constant RTC_S_RTC_PRIVCFGR_TSPRIV                        \ Timestamp privilege protection
$00002000 constant RTC_S_RTC_PRIVCFGR_CALPRIV                       \ Shift register, Delight saving, calibration and reference clock privilege protection
$00004000 constant RTC_S_RTC_PRIVCFGR_INITPRIV                      \ Initialization privilege protection
$00008000 constant RTC_S_RTC_PRIVCFGR_PRIV                          \ RTC privilege protection


\
\ @brief RTC secure configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant RTC_S_RTC_SECCFGR_ALRASEC                        \ Alarm A and SSR underflow protection
$00000002 constant RTC_S_RTC_SECCFGR_ALRBSEC                        \ Alarm B protection
$00000004 constant RTC_S_RTC_SECCFGR_WUTSEC                         \ Wake-up timer protection
$00000008 constant RTC_S_RTC_SECCFGR_TSSEC                          \ Timestamp protection
$00002000 constant RTC_S_RTC_SECCFGR_CALSEC                         \ Shift register, daylight saving, calibration and reference clock protection
$00004000 constant RTC_S_RTC_SECCFGR_INITSEC                        \ Initialization protection
$00008000 constant RTC_S_RTC_SECCFGR_SEC                            \ RTC global protection


\
\ @brief RTC write protection register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant RTC_S_RTC_WPR_KEY                                \ Write protection key


\
\ @brief RTC calibration register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000001ff constant RTC_S_RTC_CALR_CALM                              \ Calibration minus
$00001000 constant RTC_S_RTC_CALR_LPCAL                             \ RTC low-power mode
$00002000 constant RTC_S_RTC_CALR_CALW16                            \ Use a 16-second calibration cycle period
$00004000 constant RTC_S_RTC_CALR_CALW8                             \ Use an 8-second calibration cycle period
$00008000 constant RTC_S_RTC_CALR_CALP                              \ Increase frequency of RTC by 488.


\
\ @brief RTC shift control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00007fff constant RTC_S_RTC_SHIFTR_SUBFS                           \ Subtract a fraction of a second
$80000000 constant RTC_S_RTC_SHIFTR_ADD1S                           \ Add one second


\
\ @brief RTC timestamp time register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000000f constant RTC_S_RTC_TSTR_SU                                \ Second units in BCD format.
$00000070 constant RTC_S_RTC_TSTR_ST                                \ Second tens in BCD format.
$00000f00 constant RTC_S_RTC_TSTR_MNU                               \ Minute units in BCD format.
$00007000 constant RTC_S_RTC_TSTR_MNT                               \ Minute tens in BCD format.
$000f0000 constant RTC_S_RTC_TSTR_HU                                \ Hour units in BCD format.
$00300000 constant RTC_S_RTC_TSTR_HT                                \ Hour tens in BCD format.
$00400000 constant RTC_S_RTC_TSTR_PM                                \ AM/PM notation


\
\ @brief RTC timestamp date register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000000f constant RTC_S_RTC_TSDR_DU                                \ Date units in BCD format
$00000030 constant RTC_S_RTC_TSDR_DT                                \ Date tens in BCD format
$00000f00 constant RTC_S_RTC_TSDR_MU                                \ Month units in BCD format
$00001000 constant RTC_S_RTC_TSDR_MT                                \ Month tens in BCD format
$0000e000 constant RTC_S_RTC_TSDR_WDU                               \ Week day units


\
\ @brief RTC timestamp subsecond register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant RTC_S_RTC_TSSSR_SS                               \ Subsecond value/synchronous binary counter values


\
\ @brief RTC alarm A register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000000f constant RTC_S_RTC_ALRMAR_SU                              \ Second units in BCD format.
$00000070 constant RTC_S_RTC_ALRMAR_ST                              \ Second tens in BCD format.
$00000080 constant RTC_S_RTC_ALRMAR_MSK1                            \ Alarm A seconds mask
$00000f00 constant RTC_S_RTC_ALRMAR_MNU                             \ Minute units in BCD format
$00007000 constant RTC_S_RTC_ALRMAR_MNT                             \ Minute tens in BCD format
$00008000 constant RTC_S_RTC_ALRMAR_MSK2                            \ Alarm A minutes mask
$000f0000 constant RTC_S_RTC_ALRMAR_HU                              \ Hour units in BCD format
$00300000 constant RTC_S_RTC_ALRMAR_HT                              \ Hour tens in BCD format
$00400000 constant RTC_S_RTC_ALRMAR_PM                              \ AM/PM notation
$00800000 constant RTC_S_RTC_ALRMAR_MSK3                            \ Alarm A hours mask
$0f000000 constant RTC_S_RTC_ALRMAR_DU                              \ Date units or day in BCD format
$30000000 constant RTC_S_RTC_ALRMAR_DT                              \ Date tens in BCD format
$40000000 constant RTC_S_RTC_ALRMAR_WDSEL                           \ Week day selection
$80000000 constant RTC_S_RTC_ALRMAR_MSK4                            \ Alarm A date mask


\
\ @brief RTC alarm A subsecond register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00007fff constant RTC_S_RTC_ALRMASSR_SS                            \ Subseconds value
$3f000000 constant RTC_S_RTC_ALRMASSR_MASKSS                        \ Mask the most-significant bits starting at this bit
$80000000 constant RTC_S_RTC_ALRMASSR_SSCLR                         \ Clear synchronous counter on alarm (Binary mode only)


\
\ @brief RTC alarm B register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000000f constant RTC_S_RTC_ALRMBR_SU                              \ Second units in BCD format
$00000070 constant RTC_S_RTC_ALRMBR_ST                              \ Second tens in BCD format
$00000080 constant RTC_S_RTC_ALRMBR_MSK1                            \ Alarm B seconds mask
$00000f00 constant RTC_S_RTC_ALRMBR_MNU                             \ Minute units in BCD format
$00007000 constant RTC_S_RTC_ALRMBR_MNT                             \ Minute tens in BCD format
$00008000 constant RTC_S_RTC_ALRMBR_MSK2                            \ Alarm B minutes mask
$000f0000 constant RTC_S_RTC_ALRMBR_HU                              \ Hour units in BCD format
$00300000 constant RTC_S_RTC_ALRMBR_HT                              \ Hour tens in BCD format
$00400000 constant RTC_S_RTC_ALRMBR_PM                              \ AM/PM notation
$00800000 constant RTC_S_RTC_ALRMBR_MSK3                            \ Alarm B hours mask
$0f000000 constant RTC_S_RTC_ALRMBR_DU                              \ Date units or day in BCD format
$30000000 constant RTC_S_RTC_ALRMBR_DT                              \ Date tens in BCD format
$40000000 constant RTC_S_RTC_ALRMBR_WDSEL                           \ Week day selection
$80000000 constant RTC_S_RTC_ALRMBR_MSK4                            \ Alarm B date mask


\
\ @brief RTC alarm B subsecond register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00007fff constant RTC_S_RTC_ALRMBSSR_SS                            \ Subseconds value
$3f000000 constant RTC_S_RTC_ALRMBSSR_MASKSS                        \ Mask the most-significant bits starting at this bit
$80000000 constant RTC_S_RTC_ALRMBSSR_SSCLR                         \ Clear synchronous counter on alarm (Binary mode only)


\
\ @brief RTC status register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant RTC_S_RTC_SR_ALRAF                               \ Alarm A flag
$00000002 constant RTC_S_RTC_SR_ALRBF                               \ Alarm B flag
$00000004 constant RTC_S_RTC_SR_WUTF                                \ Wake-up timer flag
$00000008 constant RTC_S_RTC_SR_TSF                                 \ Timestamp flag
$00000010 constant RTC_S_RTC_SR_TSOVF                               \ Timestamp overflow flag
$00000020 constant RTC_S_RTC_SR_ITSF                                \ Internal timestamp flag
$00000040 constant RTC_S_RTC_SR_SSRUF                               \ SSR underflow flag


\
\ @brief RTC nonsecure masked interrupt status register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant RTC_S_RTC_MISR_ALRAMF                            \ Alarm A masked flag
$00000002 constant RTC_S_RTC_MISR_ALRBMF                            \ Alarm B nonsecure masked flag
$00000004 constant RTC_S_RTC_MISR_WUTMF                             \ Wake-up timer nonsecure masked flag
$00000008 constant RTC_S_RTC_MISR_TSMF                              \ Timestamp nonsecure masked flag
$00000010 constant RTC_S_RTC_MISR_TSOVMF                            \ Timestamp overflow nonsecure masked flag
$00000020 constant RTC_S_RTC_MISR_ITSMF                             \ Internal timestamp nonsecure masked flag
$00000040 constant RTC_S_RTC_MISR_SSRUMF                            \ SSR underflow nonsecure masked flag


\
\ @brief RTC secure masked interrupt status register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant RTC_S_RTC_SMISR_ALRAMF                           \ Alarm A interrupt secure masked flag
$00000002 constant RTC_S_RTC_SMISR_ALRBMF                           \ Alarm B interrupt secure masked flag
$00000004 constant RTC_S_RTC_SMISR_WUTMF                            \ Wake-up timer interrupt secure masked flag
$00000008 constant RTC_S_RTC_SMISR_TSMF                             \ Timestamp interrupt secure masked flag
$00000010 constant RTC_S_RTC_SMISR_TSOVMF                           \ Timestamp overflow interrupt secure masked flag
$00000020 constant RTC_S_RTC_SMISR_ITSMF                            \ Internal timestamp interrupt secure masked flag
$00000040 constant RTC_S_RTC_SMISR_SSRUMF                           \ SSR underflow secure masked flag


\
\ @brief RTC status clear register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant RTC_S_RTC_SCR_CALRAF                             \ Clear alarm A flag
$00000002 constant RTC_S_RTC_SCR_CALRBF                             \ Clear alarm B flag
$00000004 constant RTC_S_RTC_SCR_CWUTF                              \ Clear wake-up timer flag
$00000008 constant RTC_S_RTC_SCR_CTSF                               \ Clear timestamp flag
$00000010 constant RTC_S_RTC_SCR_CTSOVF                             \ Clear timestamp overflow flag
$00000020 constant RTC_S_RTC_SCR_CITSF                              \ Clear internal timestamp flag
$00000040 constant RTC_S_RTC_SCR_CSSRUF                             \ Clear SSR underflow flag


\
\ @brief RTC option register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant RTC_S_RTC_OR_OUT2_RMP                            \ RTC_OUT2 mapping


\
\ @brief RTC alarm A binary mode register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant RTC_S_RTC_ALRABINR_SS                            \ Synchronous counter alarm value in Binary mode


\
\ @brief RTC alarm B binary mode register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant RTC_S_RTC_ALRBBINR_SS                            \ Synchronous counter alarm value in Binary mode


\
\ @brief RTC register block
\
$54007800 constant RTC_S_RTC_TR   \ offset: 0x00 : RTC time register
$54007804 constant RTC_S_RTC_DR   \ offset: 0x04 : RTC date register
$54007808 constant RTC_S_RTC_SSR  \ offset: 0x08 : RTC subsecond register
$5400780c constant RTC_S_RTC_ICSR  \ offset: 0x0C : RTC initialization control and status register
$54007810 constant RTC_S_RTC_PRER  \ offset: 0x10 : RTC prescaler register
$54007814 constant RTC_S_RTC_WUTR  \ offset: 0x14 : RTC wake-up timer register
$54007818 constant RTC_S_RTC_CR   \ offset: 0x18 : RTC control register
$5400781c constant RTC_S_RTC_PRIVCFGR  \ offset: 0x1C : RTC privilege mode control register
$54007820 constant RTC_S_RTC_SECCFGR  \ offset: 0x20 : RTC secure configuration register
$54007824 constant RTC_S_RTC_WPR  \ offset: 0x24 : RTC write protection register
$54007828 constant RTC_S_RTC_CALR  \ offset: 0x28 : RTC calibration register
$5400782c constant RTC_S_RTC_SHIFTR  \ offset: 0x2C : RTC shift control register
$54007830 constant RTC_S_RTC_TSTR  \ offset: 0x30 : RTC timestamp time register
$54007834 constant RTC_S_RTC_TSDR  \ offset: 0x34 : RTC timestamp date register
$54007838 constant RTC_S_RTC_TSSSR  \ offset: 0x38 : RTC timestamp subsecond register
$54007840 constant RTC_S_RTC_ALRMAR  \ offset: 0x40 : RTC alarm A register
$54007844 constant RTC_S_RTC_ALRMASSR  \ offset: 0x44 : RTC alarm A subsecond register
$54007848 constant RTC_S_RTC_ALRMBR  \ offset: 0x48 : RTC alarm B register
$5400784c constant RTC_S_RTC_ALRMBSSR  \ offset: 0x4C : RTC alarm B subsecond register
$54007850 constant RTC_S_RTC_SR   \ offset: 0x50 : RTC status register
$54007854 constant RTC_S_RTC_MISR  \ offset: 0x54 : RTC nonsecure masked interrupt status register
$54007858 constant RTC_S_RTC_SMISR  \ offset: 0x58 : RTC secure masked interrupt status register
$5400785c constant RTC_S_RTC_SCR  \ offset: 0x5C : RTC status clear register
$54007860 constant RTC_S_RTC_OR   \ offset: 0x60 : RTC option register
$54007870 constant RTC_S_RTC_ALRABINR  \ offset: 0x70 : RTC alarm A binary mode register
$54007874 constant RTC_S_RTC_ALRBBINR  \ offset: 0x74 : RTC alarm B binary mode register

