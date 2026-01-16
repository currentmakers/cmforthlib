\
\ @file sec_rtc.fs
\ @brief Real-time clock
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

$0000000f constant SEC_RTC_RTC_TR_SU                                \ Second units in BCD format
$00000070 constant SEC_RTC_RTC_TR_ST                                \ Second tens in BCD format
$00000f00 constant SEC_RTC_RTC_TR_MNU                               \ Minute units in BCD format
$00007000 constant SEC_RTC_RTC_TR_MNT                               \ Minute tens in BCD format
$000f0000 constant SEC_RTC_RTC_TR_HU                                \ Hour units in BCD format
$00300000 constant SEC_RTC_RTC_TR_HT                                \ Hour tens in BCD format
$00400000 constant SEC_RTC_RTC_TR_PM                                \ AM/PM notation


\
\ @brief RTC date register
\ Address offset: 0x04
\ Reset value: 0x00002101
\

$0000000f constant SEC_RTC_RTC_DR_DU                                \ Date units in BCD format
$00000030 constant SEC_RTC_RTC_DR_DT                                \ Date tens in BCD format
$00000f00 constant SEC_RTC_RTC_DR_MU                                \ Month units in BCD format
$00001000 constant SEC_RTC_RTC_DR_MT                                \ Month tens in BCD format
$0000e000 constant SEC_RTC_RTC_DR_WDU                               \ Week day units ...
$000f0000 constant SEC_RTC_RTC_DR_YU                                \ Year units in BCD format
$00f00000 constant SEC_RTC_RTC_DR_YT                                \ Year tens in BCD format


\
\ @brief RTC sub second register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant SEC_RTC_RTC_SSR_SS                               \ Synchronous binary counter SS[31:16]: Synchronous binary counter MSB values When Binary or Mixed mode is selected (BIN = 01 or 10 or 11): SS[31:16] are the 16 MSB of the SS[31:0] free-running down-counter. When BCD mode is selected (BIN=00): SS[31:16] are forced by hardware to 0x0000. SS[15:0]: Sub second value/Synchronous binary counter LSB values When Binary mode is selected (BIN = 01 or 10 or 11): SS[15:0] are the 16 LSB of the SS[31:0] free-running down-counter. When BCD mode is selected (BIN=00): SS[15:0] is the value in the synchronous prescaler counter. The fraction of a second is given by the formula below: Second fraction = (PREDIV_S SS) / (PREDIV_S + 1) SS can be larger than PREDIV_S only after a shift operation. In that case, the correct time/date is one second less than as indicated by RTC_TR/RTC_DR.


\
\ @brief RTC initialization control and status register
\ Address offset: 0x0C
\ Reset value: 0x00000007
\

$00000004 constant SEC_RTC_RTC_ICSR_WUTWF                           \ Wakeup timer write flag This bit is set by hardware when WUT value can be changed, after the WUTE bit has been set to 0 in RTC_CR. It is cleared by hardware in initialization mode.
$00000008 constant SEC_RTC_RTC_ICSR_SHPF                            \ Shift operation pending This flag is set by hardware as soon as a shift operation is initiated by a write to the RTC_SHIFTR register. It is cleared by hardware when the corresponding shift operation has been executed. Writing to the SHPF bit has no effect.
$00000010 constant SEC_RTC_RTC_ICSR_INITS                           \ Initialization status flag This bit is set by hardware when the calendar year field is different from 0 (Backup domain reset state).
$00000020 constant SEC_RTC_RTC_ICSR_RSF                             \ Registers synchronization flag This bit is set by hardware each time the calendar registers are copied into the shadow registers (RTC_SSR, RTC_TR and RTC_DR). This bit is cleared by hardware in initialization mode, while a shift operation is pending (SHPF = 1), or when in bypass shadow register mode (BYPSHAD = 1). This bit can also be cleared by software. It is cleared either by software or by hardware in initialization mode.
$00000040 constant SEC_RTC_RTC_ICSR_INITF                           \ Initialization flag When this bit is set to 1, the RTC is in initialization state, and the time, date and prescaler registers can be updated.
$00000080 constant SEC_RTC_RTC_ICSR_INIT                            \ Initialization mode
$00000300 constant SEC_RTC_RTC_ICSR_BIN                             \ Binary mode
$00001c00 constant SEC_RTC_RTC_ICSR_BCDU                            \ BCD update (BIN = 10 or 11) In mixed mode when both BCD calendar and binary extended counter are used (BIN = 10 or 11), the calendar second is incremented using the SSR Least Significant Bits.
$00010000 constant SEC_RTC_RTC_ICSR_RECALPF                         \ Recalibration pending Flag The RECALPF status flag is automatically set to 1 when software writes to the RTC_CALR register, indicating that the RTC_CALR register is blocked. When the new calibration settings are taken into account, this bit returns to 0. Refer to .


\
\ @brief RTC prescaler register
\ Address offset: 0x10
\ Reset value: 0x007F00FF
\

$00007fff constant SEC_RTC_RTC_PRER_PREDIV_S                        \ Synchronous prescaler factor This is the synchronous division factor: ck_spre frequency = ck_apre frequency/(PREDIV_S+1)
$007f0000 constant SEC_RTC_RTC_PRER_PREDIV_A                        \ Asynchronous prescaler factor This is the asynchronous division factor: ck_apre frequency = RTCCLK frequency/(PREDIV_A+1)


\
\ @brief RTC wakeup timer register
\ Address offset: 0x14
\ Reset value: 0x0000FFFF
\

$0000ffff constant SEC_RTC_RTC_WUTR_WUT                             \ Wakeup auto-reload value bits When the wakeup timer is enabled (WUTE set to 1), the WUTF flag is set every (WUT[15:0] + 1) ck_wut cycles. The ck_wut period is selected through WUCKSEL[2:0] bits of the RTC_CR register. When WUCKSEL[2] = 1, the wakeup timer becomes 17-bits and WUCKSEL[1] effectively becomes WUT[16] the most-significant bit to be reloaded into the timer. The first assertion of WUTF occurs between WUT and (WUT + 2) ck_wut cycles after WUTE is set. Setting WUT[15:0] to 0x0000 with WUCKSEL[2:0] = 011 (RTCCLK/2) is forbidden.
$ffff0000 constant SEC_RTC_RTC_WUTR_WUTOCLR                         \ Wakeup auto-reload output clear value When WUTOCLR[15:0] is different from 0x0000, WUTF is set by hardware when the auto-reload down-counter reaches 0 and is cleared by hardware when the auto-reload downcounter reaches WUTOCLR[15:0]. When WUTOCLR[15:0] = 0x0000, WUTF is set by hardware when the WUT down-counter reaches 0 and is cleared by software.


\
\ @brief RTC control register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000007 constant SEC_RTC_RTC_CR_WUCKSEL                           \ ck_wut wakeup clock selection 10x: ck_spre (usually 1 Hz) clock is selected in BCD mode. In binary or mixed mode, this is the clock selected by BCDU. 11x: ck_spre (usually 1 Hz) clock is selected in BCD mode. In binary or mixed mode, this is the clock selected by BCDU. Furthermore, 216 is added to the WUT counter value.
$00000008 constant SEC_RTC_RTC_CR_TSEDGE                            \ Timestamp event active edge TSE must be reset when TSEDGE is changed to avoid unwanted TSF setting.
$00000010 constant SEC_RTC_RTC_CR_REFCKON                           \ RTC_REFIN reference clock detection enable (50 or 60 Hz) Note: BIN must be 0x00 and PREDIV_S must be 0x00FF.
$00000020 constant SEC_RTC_RTC_CR_BYPSHAD                           \ Bypass the shadow registers Note: If the frequency of the APB1 clock is less than seven times the frequency of RTCCLK, BYPSHAD must be set to 1.
$00000040 constant SEC_RTC_RTC_CR_FMT                               \ Hour format
$00000080 constant SEC_RTC_RTC_CR_SSRUIE                            \ SSR underflow interrupt enable
$00000100 constant SEC_RTC_RTC_CR_ALRAE                             \ Alarm A enable
$00000200 constant SEC_RTC_RTC_CR_ALRBE                             \ Alarm B enable
$00000400 constant SEC_RTC_RTC_CR_WUTE                              \ Wakeup timer enable Note: When the wakeup timer is disabled, wait for WUTWF = 1 before enabling it again.
$00000800 constant SEC_RTC_RTC_CR_TSE                               \ timestamp enable
$00001000 constant SEC_RTC_RTC_CR_ALRAIE                            \ Alarm A interrupt enable
$00002000 constant SEC_RTC_RTC_CR_ALRBIE                            \ Alarm B interrupt enable
$00004000 constant SEC_RTC_RTC_CR_WUTIE                             \ Wakeup timer interrupt enable
$00008000 constant SEC_RTC_RTC_CR_TSIE                              \ Timestamp interrupt enable
$00010000 constant SEC_RTC_RTC_CR_ADD1H                             \ Add 1 hour (summer time change) When this bit is set outside initialization mode, 1 hour is added to the calendar time. This bit is always read as 0.
$00020000 constant SEC_RTC_RTC_CR_SUB1H                             \ Subtract 1 hour (winter time change) When this bit is set outside initialization mode, 1 hour is subtracted to the calendar time if the current hour is not 0. This bit is always read as 0. Setting this bit has no effect when current hour is 0.
$00040000 constant SEC_RTC_RTC_CR_BKP                               \ Backup This bit can be written by the user to memorize whether the daylight saving time change has been performed or not.
$00080000 constant SEC_RTC_RTC_CR_COSEL                             \ Calibration output selection When COE = 1, this bit selects which signal is output on CALIB. These frequencies are valid for RTCCLK at 32.768 kHz and prescalers at their default values (PREDIV_A = 127 and PREDIV_S = 255). Refer to .
$00100000 constant SEC_RTC_RTC_CR_POL                               \ Output polarity This bit is used to configure the polarity of TAMPALRM output.
$00600000 constant SEC_RTC_RTC_CR_OSEL                              \ Output selection These bits are used to select the flag to be routed to TAMPALRM output.
$00800000 constant SEC_RTC_RTC_CR_COE                               \ Calibration output enable This bit enables the CALIB output
$01000000 constant SEC_RTC_RTC_CR_ITSE                              \ timestamp on internal event enable
$02000000 constant SEC_RTC_RTC_CR_TAMPTS                            \ Activate timestamp on tamper detection event TAMPTS is valid even if TSE = 0 in the RTC_CR register. Timestamp flag is set up to 3 ck_apre cycles after the tamper flags.
$04000000 constant SEC_RTC_RTC_CR_TAMPOE                            \ Tamper detection output enable on TAMPALRM
$08000000 constant SEC_RTC_RTC_CR_ALRAFCLR                          \ Alarm A flag automatic clear
$10000000 constant SEC_RTC_RTC_CR_ALRBFCLR                          \ Alarm B flag automatic clear
$20000000 constant SEC_RTC_RTC_CR_TAMPALRM_PU                       \ TAMPALRM pull-up enable
$40000000 constant SEC_RTC_RTC_CR_TAMPALRM_TYPE                     \ TAMPALRM output type
$80000000 constant SEC_RTC_RTC_CR_OUT2EN                            \ RTC_OUT2 output enable Setting this bit permits to remap the RTC outputs on RTC_OUT2 as follows: OUT2EN = 0: RTC output 2 disable If OSEL different 00 or TAMPOE = 1: TAMPALRM is output on RTC_OUT1 If OSEL = 00 and TAMPOE = 0 and COE = 1: CALIB is output on RTC_OUT1 OUT2EN = 1: RTC output 2 enable If (OSEL different 00 or TAMPOE = 1) and COE = 0: TAMPALRM is output on RTC_OUT2 If OSEL = 00 and TAMPOE = 0 and COE = 1: CALIB is output on RTC_OUT2 If (OSEL different 00 or TAMPOE = 1) and COE = 1: CALIB is output on RTC_OUT2 and TAMPALRM is output on RTC_OUT1.


\
\ @brief RTC privilege mode control register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SEC_RTC_RTC_PRIVCFGR_ALRAPRIV                    \ Alarm A and SSR underflow privilege protection
$00000002 constant SEC_RTC_RTC_PRIVCFGR_ALRBPRIV                    \ Alarm B privilege protection
$00000004 constant SEC_RTC_RTC_PRIVCFGR_WUTPRIV                     \ Wakeup timer privilege protection
$00000008 constant SEC_RTC_RTC_PRIVCFGR_TSPRIV                      \ Timestamp privilege protection
$00002000 constant SEC_RTC_RTC_PRIVCFGR_CALPRIV                     \ Shift register, Delight saving, calibration and reference clock privilege protection
$00004000 constant SEC_RTC_RTC_PRIVCFGR_INITPRIV                    \ Initialization privilege protection
$00008000 constant SEC_RTC_RTC_PRIVCFGR_PRIV                        \ RTC privilege protection


\
\ @brief RTC secure configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SEC_RTC_RTC_SECCFGR_ALRASEC                      \ Alarm A and SSR underflow protection
$00000002 constant SEC_RTC_RTC_SECCFGR_ALRBSEC                      \ Alarm B protection
$00000004 constant SEC_RTC_RTC_SECCFGR_WUTSEC                       \ Wakeup timer protection
$00000008 constant SEC_RTC_RTC_SECCFGR_TSSEC                        \ Timestamp protection
$00002000 constant SEC_RTC_RTC_SECCFGR_CALSEC                       \ Shift register, daylight saving, calibration and reference clock protection
$00004000 constant SEC_RTC_RTC_SECCFGR_INITSEC                      \ Initialization protection
$00008000 constant SEC_RTC_RTC_SECCFGR_SEC                          \ RTC global protection


\
\ @brief RTC write protection register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant SEC_RTC_RTC_WPR_KEY                              \ Write protection key This byte is written by software. Reading this byte always returns 0x00. Refer to for a description of how to unlock RTC register write protection.


\
\ @brief RTC calibration register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000001ff constant SEC_RTC_RTC_CALR_CALM                            \ Calibration minus The frequency of the calendar is reduced by masking CALM out of 220 RTCCLK pulses (32 seconds if the input frequency is 32768 Hz). This decreases the frequency of the calendar with a resolution of 0.9537 ppm. To increase the frequency of the calendar, this feature should be used in conjunction with CALP. See .
$00001000 constant SEC_RTC_RTC_CALR_LPCAL                           \ RTC low-power mode
$00002000 constant SEC_RTC_RTC_CALR_CALW16                          \ Use a 16-second calibration cycle period When CALW16 is set to 1, the 16-second calibration cycle period is selected. This bit must not be set to 1 if CALW8 = 1. Note: CALM[0] is stuck at 0 when CALW16 = 1. Refer to calibration.
$00004000 constant SEC_RTC_RTC_CALR_CALW8                           \ Use an 8-second calibration cycle period When CALW8 is set to 1, the 8-second calibration cycle period is selected. Note: CALM[1:0] are stuck at 00 when CALW8 = 1. Refer to digital calibration.
$00008000 constant SEC_RTC_RTC_CALR_CALP                            \ Increase frequency of RTC by 488.5 ppm This feature is intended to be used in conjunction with CALM, which lowers the frequency of the calendar with a fine resolution. if the input frequency is 32768 Hz, the number of RTCCLK pulses added during a 32-second window is calculated as follows: (512 CALP) CALM. Refer to .


\
\ @brief RTC shift control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00007fff constant SEC_RTC_RTC_SHIFTR_SUBFS                         \ Subtract a fraction of a second These bits are write only and is always read as zero. Writing to this bit has no effect when a shift operation is pending (when SHPF = 1, in RTC_ICSR). The value which is written to SUBFS is added to the synchronous prescaler counter. Since this counter counts down, this operation effectively subtracts from (delays) the clock by: Delay (seconds) = SUBFS / (PREDIV_S + 1) A fraction of a second can effectively be added to the clock (advancing the clock) when the ADD1S function is used in conjunction with SUBFS, effectively advancing the clock by: Advance (seconds) = (1 (SUBFS / (PREDIV_S + 1))). In mixed BCD-binary mode (BIN=10 or 11), the SUBFS[14:BCDU+8] must be written with 0. Note: Writing to SUBFS causes RSF to be cleared. Software can then wait until RSF = 1 to be sure that the shadow registers have been updated with the shifted time.
$80000000 constant SEC_RTC_RTC_SHIFTR_ADD1S                         \ Add one second This bit is write only and is always read as zero. Writing to this bit has no effect when a shift operation is pending (when SHPF = 1, in RTC_ICSR). This function is intended to be used with SUBFS (see description below) in order to effectively add a fraction of a second to the clock in an atomic operation.


\
\ @brief RTC timestamp time register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000000f constant SEC_RTC_RTC_TSTR_SU                              \ Second units in BCD format.
$00000070 constant SEC_RTC_RTC_TSTR_ST                              \ Second tens in BCD format.
$00000f00 constant SEC_RTC_RTC_TSTR_MNU                             \ Minute units in BCD format.
$00007000 constant SEC_RTC_RTC_TSTR_MNT                             \ Minute tens in BCD format.
$000f0000 constant SEC_RTC_RTC_TSTR_HU                              \ Hour units in BCD format.
$00300000 constant SEC_RTC_RTC_TSTR_HT                              \ Hour tens in BCD format.
$00400000 constant SEC_RTC_RTC_TSTR_PM                              \ AM/PM notation


\
\ @brief RTC timestamp date register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000000f constant SEC_RTC_RTC_TSDR_DU                              \ Date units in BCD format
$00000030 constant SEC_RTC_RTC_TSDR_DT                              \ Date tens in BCD format
$00000f00 constant SEC_RTC_RTC_TSDR_MU                              \ Month units in BCD format
$00001000 constant SEC_RTC_RTC_TSDR_MT                              \ Month tens in BCD format
$0000e000 constant SEC_RTC_RTC_TSDR_WDU                             \ Week day units


\
\ @brief RTC timestamp sub second register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant SEC_RTC_RTC_TSSSR_SS                             \ Sub second value/Synchronous binary counter values SS[31:0] is the value of the synchronous prescaler counter when the timestamp event occurred.


\
\ @brief RTC alarm A register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000000f constant SEC_RTC_RTC_ALRMAR_SU                            \ Second units in BCD format.
$00000070 constant SEC_RTC_RTC_ALRMAR_ST                            \ Second tens in BCD format.
$00000080 constant SEC_RTC_RTC_ALRMAR_MSK1                          \ Alarm A seconds mask
$00000f00 constant SEC_RTC_RTC_ALRMAR_MNU                           \ Minute units in BCD format
$00007000 constant SEC_RTC_RTC_ALRMAR_MNT                           \ Minute tens in BCD format
$00008000 constant SEC_RTC_RTC_ALRMAR_MSK2                          \ Alarm A minutes mask
$000f0000 constant SEC_RTC_RTC_ALRMAR_HU                            \ Hour units in BCD format
$00300000 constant SEC_RTC_RTC_ALRMAR_HT                            \ Hour tens in BCD format
$00400000 constant SEC_RTC_RTC_ALRMAR_PM                            \ AM/PM notation
$00800000 constant SEC_RTC_RTC_ALRMAR_MSK3                          \ Alarm A hours mask
$0f000000 constant SEC_RTC_RTC_ALRMAR_DU                            \ Date units or day in BCD format
$30000000 constant SEC_RTC_RTC_ALRMAR_DT                            \ Date tens in BCD format
$40000000 constant SEC_RTC_RTC_ALRMAR_WDSEL                         \ Week day selection
$80000000 constant SEC_RTC_RTC_ALRMAR_MSK4                          \ Alarm A date mask


\
\ @brief RTC alarm A sub second register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00007fff constant SEC_RTC_RTC_ALRMASSR_SS                          \ Sub seconds value This value is compared with the contents of the synchronous prescaler counter to determine if alarm A is to be activated. Only bits 0 up MASKSS-1 are compared. This field is the mirror of SS[14:0] in the RTC_ALRMABINR, and so can also be read or written through RTC_ALRMABINR.
$3f000000 constant SEC_RTC_RTC_ALRMASSR_MASKSS                      \ Mask the most-significant bits starting at this bit 2: SS[31:2] are don't care in Alarm A comparison. Only SS[1:0] are compared. ... 31: SS[31] is don't care in Alarm A comparison. Only SS[30:0] are compared. From 32 to 63: All 32 SS bits are compared and must match to activate alarm. Note: In BCD mode (BIN=00) the overflow bits of the synchronous counter (bits 31:15) are never compared. These bits can be different from 0 only after a shift operation.
$80000000 constant SEC_RTC_RTC_ALRMASSR_SSCLR                       \ Clear synchronous counter on alarm (Binary mode only) Note: SSCLR must be kept to 0 when BCD or mixed mode is used (BIN = 00, 10 or 11).


\
\ @brief RTC alarm B register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000000f constant SEC_RTC_RTC_ALRMBR_SU                            \ Second units in BCD format
$00000070 constant SEC_RTC_RTC_ALRMBR_ST                            \ Second tens in BCD format
$00000080 constant SEC_RTC_RTC_ALRMBR_MSK1                          \ Alarm B seconds mask
$00000f00 constant SEC_RTC_RTC_ALRMBR_MNU                           \ Minute units in BCD format
$00007000 constant SEC_RTC_RTC_ALRMBR_MNT                           \ Minute tens in BCD format
$00008000 constant SEC_RTC_RTC_ALRMBR_MSK2                          \ Alarm B minutes mask
$000f0000 constant SEC_RTC_RTC_ALRMBR_HU                            \ Hour units in BCD format
$00300000 constant SEC_RTC_RTC_ALRMBR_HT                            \ Hour tens in BCD format
$00400000 constant SEC_RTC_RTC_ALRMBR_PM                            \ AM/PM notation
$00800000 constant SEC_RTC_RTC_ALRMBR_MSK3                          \ Alarm B hours mask
$0f000000 constant SEC_RTC_RTC_ALRMBR_DU                            \ Date units or day in BCD format
$30000000 constant SEC_RTC_RTC_ALRMBR_DT                            \ Date tens in BCD format
$40000000 constant SEC_RTC_RTC_ALRMBR_WDSEL                         \ Week day selection
$80000000 constant SEC_RTC_RTC_ALRMBR_MSK4                          \ Alarm B date mask


\
\ @brief RTC alarm B sub second register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00007fff constant SEC_RTC_RTC_ALRMBSSR_SS                          \ Sub seconds value This value is compared with the contents of the synchronous prescaler counter to determine if alarm B is to be activated. Only bits 0 up to MASKSS-1 are compared. This field is the mirror of SS[14:0] in the RTC_ALRMBBINR, and so can also be read or written through RTC_ALRMBBINR.
$3f000000 constant SEC_RTC_RTC_ALRMBSSR_MASKSS                      \ Mask the most-significant bits starting at this bit 2: SS[31:2] are don't care in Alarm B comparison. Only SS[1:0] are compared. ... 31: SS[31] is don't care in Alarm B comparison. Only SS[30:0] are compared. From 32 to 63: All 32 SS bits are compared and must match to activate alarm. Note: In BCD mode (BIN=00)The overflow bits of the synchronous counter (bits 15) is never compared. This bit can be different from 0 only after a shift operation.
$80000000 constant SEC_RTC_RTC_ALRMBSSR_SSCLR                       \ Clear synchronous counter on alarm (Binary mode only) Note: SSCLR must be kept to 0 when BCD or mixed mode is used (BIN = 00, 10 or 11).


\
\ @brief RTC status register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant SEC_RTC_RTC_SR_ALRAF                             \ Alarm A flag This flag is set by hardware when the time/date registers (RTC_TR and RTC_DR) match the alarm A register (RTC_ALRMAR).
$00000002 constant SEC_RTC_RTC_SR_ALRBF                             \ Alarm B flag This flag is set by hardware when the time/date registers (RTC_TR and RTC_DR) match the alarm B register (RTC_ALRMBR).
$00000004 constant SEC_RTC_RTC_SR_WUTF                              \ Wakeup timer flag This flag is set by hardware when the wakeup auto-reload counter reaches 0. If WUTOCLR[15:0] is different from 0x0000, WUTF is cleared by hardware when the wakeup auto-reload counter reaches WUTOCLR value. If WUTOCLR[15:0] is 0x0000, WUTF must be cleared by software. This flag must be cleared by software at least 1.5 RTCCLK periods before WUTF is set to 1 again.
$00000008 constant SEC_RTC_RTC_SR_TSF                               \ Timestamp flag This flag is set by hardware when a timestamp event occurs. If ITSF flag is set, TSF must be cleared together with ITSF. Note: TSF is not set if TAMPTS = 1 and the tamper flag is read during the 3 ck_apre cycles following tamper event. Refer to for more details.
$00000010 constant SEC_RTC_RTC_SR_TSOVF                             \ Timestamp overflow flag This flag is set by hardware when a timestamp event occurs while TSF is already set. It is recommended to check and then clear TSOVF only after clearing the TSF bit. Otherwise, an overflow might not be noticed if a timestamp event occurs immediately before the TSF bit is cleared.
$00000020 constant SEC_RTC_RTC_SR_ITSF                              \ Internal timestamp flag This flag is set by hardware when a timestamp on the internal event occurs.
$00000040 constant SEC_RTC_RTC_SR_SSRUF                             \ SSR underflow flag This flag is set by hardware when the SSR rolls under 0. SSRUF is not set when SSCLR=1.


\
\ @brief RTC non-secure masked interrupt status register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant SEC_RTC_RTC_MISR_ALRAMF                          \ Alarm A masked flag This flag is set by hardware when the alarm A non-secure interrupt occurs.
$00000002 constant SEC_RTC_RTC_MISR_ALRBMF                          \ Alarm B non-secure masked flag This flag is set by hardware when the alarm B non-secure interrupt occurs.
$00000004 constant SEC_RTC_RTC_MISR_WUTMF                           \ Wakeup timer non-secure masked flag This flag is set by hardware when the wakeup timer non-secure interrupt occurs. This flag must be cleared by software at least 1.5 RTCCLK periods before WUTF is set to 1 again.
$00000008 constant SEC_RTC_RTC_MISR_TSMF                            \ Timestamp non-secure masked flag This flag is set by hardware when a timestamp non-secure interrupt occurs. If ITSF flag is set, TSF must be cleared together with ITSF.
$00000010 constant SEC_RTC_RTC_MISR_TSOVMF                          \ Timestamp overflow non-secure masked flag This flag is set by hardware when a timestamp interrupt occurs while TSMF is already set. It is recommended to check and then clear TSOVF only after clearing the TSF bit. Otherwise, an overflow might not be noticed if a timestamp event occurs immediately before the TSF bit is cleared.
$00000020 constant SEC_RTC_RTC_MISR_ITSMF                           \ Internal timestamp non-secure masked flag This flag is set by hardware when a timestamp on the internal event occurs and timestamp non-secure interrupt is raised.
$00000040 constant SEC_RTC_RTC_MISR_SSRUMF                          \ SSR underflow non-secure masked flag This flag is set by hardware when the SSR underflow non-secure interrupt occurs.


\
\ @brief RTC secure masked interrupt status register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant SEC_RTC_RTC_SMISR_ALRAMF                         \ Alarm A interrupt secure masked flag This flag is set by hardware when the alarm A secure interrupt occurs.
$00000002 constant SEC_RTC_RTC_SMISR_ALRBMF                         \ Alarm B interrupt secure masked flag This flag is set by hardware when the alarm B secure interrupt occurs.
$00000004 constant SEC_RTC_RTC_SMISR_WUTMF                          \ Wakeup timer interrupt secure masked flag This flag is set by hardware when the wakeup timer secure interrupt occurs. This flag must be cleared by software at least 1.5 RTCCLK periods before WUTF is set to 1 again.
$00000008 constant SEC_RTC_RTC_SMISR_TSMF                           \ Timestamp interrupt secure masked flag This flag is set by hardware when a timestamp secure interrupt occurs. If ITSF flag is set, TSF must be cleared together with ITSF.
$00000010 constant SEC_RTC_RTC_SMISR_TSOVMF                         \ Timestamp overflow interrupt secure masked flag This flag is set by hardware when a timestamp secure interrupt occurs while TSMF is already set. It is recommended to check and then clear TSOVF only after clearing the TSF bit. Otherwise, an overflow might not be noticed if a timestamp event occurs immediately before the TSF bit is cleared.
$00000020 constant SEC_RTC_RTC_SMISR_ITSMF                          \ Internal timestamp interrupt secure masked flag This flag is set by hardware when a timestamp on the internal event occurs and timestamp secure interrupt is raised.
$00000040 constant SEC_RTC_RTC_SMISR_SSRUMF                         \ SSR underflow secure masked flag This flag is set by hardware when the SSR underflow secure interrupt occurs.


\
\ @brief RTC status clear register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant SEC_RTC_RTC_SCR_CALRAF                           \ Clear alarm A flag Writing 1 in this bit clears the ALRAF bit in the RTC_SR register.
$00000002 constant SEC_RTC_RTC_SCR_CALRBF                           \ Clear alarm B flag Writing 1 in this bit clears the ALRBF bit in the RTC_SR register.
$00000004 constant SEC_RTC_RTC_SCR_CWUTF                            \ Clear wakeup timer flag Writing 1 in this bit clears the WUTF bit in the RTC_SR register.
$00000008 constant SEC_RTC_RTC_SCR_CTSF                             \ Clear timestamp flag Writing 1 in this bit clears the TSOVF bit in the RTC_SR register. If ITSF flag is set, TSF must be cleared together with ITSF by setting CRSF and CITSF.
$00000010 constant SEC_RTC_RTC_SCR_CTSOVF                           \ Clear timestamp overflow flag Writing 1 in this bit clears the TSOVF bit in the RTC_SR register. It is recommended to check and then clear TSOVF only after clearing the TSF bit. Otherwise, an overflow might not be noticed if a timestamp event occurs immediately before the TSF bit is cleared.
$00000020 constant SEC_RTC_RTC_SCR_CITSF                            \ Clear internal timestamp flag Writing 1 in this bit clears the ITSF bit in the RTC_SR register.
$00000040 constant SEC_RTC_RTC_SCR_CSSRUF                           \ Clear SSR underflow flag Writing '1' in this bit clears the SSRUF in the RTC_SR register.


\
\ @brief RTC option register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant SEC_RTC_RTC_OR_OUT2_RMP                          \ RTC_OUT2 mapping


\
\ @brief RTC alarm A binary mode register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant SEC_RTC_RTC_ALRABINR_SS                          \ Synchronous counter alarm value in Binary mode This value is compared with the contents of the synchronous counter to determine if Alarm A is to be activated. Only bits 0 up MASKSS-1 are compared. SS[14:0] is the mirror of SS[14:0] in the RTC_ALRMASSRR, and so can also be read or written through RTC_ALRMASSR.


\
\ @brief RTC alarm B binary mode register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant SEC_RTC_RTC_ALRBBINR_SS                          \ Synchronous counter alarm value in Binary mode This value is compared with the contents of the synchronous counter to determine if Alarm Bis to be activated. Only bits 0 up MASKSS-1 are compared. SS[14:0] is the mirror of SS[14:0] in the RTC_ALRMBSSRR, and so can also be read or written through RTC_ALRMBSSR.


\
\ @brief Real-time clock
\
$54007800 constant SEC_RTC_RTC_TR  \ offset: 0x00 : RTC time register
$54007804 constant SEC_RTC_RTC_DR  \ offset: 0x04 : RTC date register
$54007808 constant SEC_RTC_RTC_SSR  \ offset: 0x08 : RTC sub second register
$5400780c constant SEC_RTC_RTC_ICSR  \ offset: 0x0C : RTC initialization control and status register
$54007810 constant SEC_RTC_RTC_PRER  \ offset: 0x10 : RTC prescaler register
$54007814 constant SEC_RTC_RTC_WUTR  \ offset: 0x14 : RTC wakeup timer register
$54007818 constant SEC_RTC_RTC_CR  \ offset: 0x18 : RTC control register
$5400781c constant SEC_RTC_RTC_PRIVCFGR  \ offset: 0x1C : RTC privilege mode control register
$54007820 constant SEC_RTC_RTC_SECCFGR  \ offset: 0x20 : RTC secure configuration register
$54007824 constant SEC_RTC_RTC_WPR  \ offset: 0x24 : RTC write protection register
$54007828 constant SEC_RTC_RTC_CALR  \ offset: 0x28 : RTC calibration register
$5400782c constant SEC_RTC_RTC_SHIFTR  \ offset: 0x2C : RTC shift control register
$54007830 constant SEC_RTC_RTC_TSTR  \ offset: 0x30 : RTC timestamp time register
$54007834 constant SEC_RTC_RTC_TSDR  \ offset: 0x34 : RTC timestamp date register
$54007838 constant SEC_RTC_RTC_TSSSR  \ offset: 0x38 : RTC timestamp sub second register
$54007840 constant SEC_RTC_RTC_ALRMAR  \ offset: 0x40 : RTC alarm A register
$54007844 constant SEC_RTC_RTC_ALRMASSR  \ offset: 0x44 : RTC alarm A sub second register
$54007848 constant SEC_RTC_RTC_ALRMBR  \ offset: 0x48 : RTC alarm B register
$5400784c constant SEC_RTC_RTC_ALRMBSSR  \ offset: 0x4C : RTC alarm B sub second register
$54007850 constant SEC_RTC_RTC_SR  \ offset: 0x50 : RTC status register
$54007854 constant SEC_RTC_RTC_MISR  \ offset: 0x54 : RTC non-secure masked interrupt status register
$54007858 constant SEC_RTC_RTC_SMISR  \ offset: 0x58 : RTC secure masked interrupt status register
$5400785c constant SEC_RTC_RTC_SCR  \ offset: 0x5C : RTC status clear register
$54007860 constant SEC_RTC_RTC_OR  \ offset: 0x60 : RTC option register
$54007870 constant SEC_RTC_RTC_ALRABINR  \ offset: 0x70 : RTC alarm A binary mode register
$54007874 constant SEC_RTC_RTC_ALRBBINR  \ offset: 0x74 : RTC alarm B binary mode register

