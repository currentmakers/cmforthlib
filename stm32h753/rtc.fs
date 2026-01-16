\
\ @file rtc.fs
\ @brief RTC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief The RTC_TR is the calendar time shadow register. This register must be written in initialization mode only. Refer to Calendar initialization and configuration on page9 and Reading the calendar on page10.This register is write protected. The write access procedure is described in RTC register write protection on page9.
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000000f constant RTC_RTC_TR_SU                                    \ Second units in BCD format
$00000070 constant RTC_RTC_TR_ST                                    \ Second tens in BCD format
$00000f00 constant RTC_RTC_TR_MNU                                   \ Minute units in BCD format
$00007000 constant RTC_RTC_TR_MNT                                   \ Minute tens in BCD format
$000f0000 constant RTC_RTC_TR_HU                                    \ Hour units in BCD format
$00300000 constant RTC_RTC_TR_HT                                    \ Hour tens in BCD format
$00400000 constant RTC_RTC_TR_PM                                    \ AM/PM notation


\
\ @brief The RTC_DR is the calendar date shadow register. This register must be written in initialization mode only. Refer to Calendar initialization and configuration on page9 and Reading the calendar on page10.This register is write protected. The write access procedure is described in RTC register write protection on page9.
\ Address offset: 0x04
\ Reset value: 0x00002101
\

$0000000f constant RTC_RTC_DR_DU                                    \ Date units in BCD format
$00000030 constant RTC_RTC_DR_DT                                    \ Date tens in BCD format
$00000f00 constant RTC_RTC_DR_MU                                    \ Month units in BCD format
$00001000 constant RTC_RTC_DR_MT                                    \ Month tens in BCD format
$0000e000 constant RTC_RTC_DR_WDU                                   \ Week day units
$000f0000 constant RTC_RTC_DR_YU                                    \ Year units in BCD format
$00f00000 constant RTC_RTC_DR_YT                                    \ Year tens in BCD format


\
\ @brief RTC control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant RTC_RTC_CR_WUCKSEL                               \ Wakeup clock selection
$00000008 constant RTC_RTC_CR_TSEDGE                                \ Time-stamp event active edge TSE must be reset when TSEDGE is changed to avoid unwanted TSF setting.
$00000010 constant RTC_RTC_CR_REFCKON                               \ RTC_REFIN reference clock detection enable (50 or 60Hz) Note: PREDIV_S must be 0x00FF.
$00000020 constant RTC_RTC_CR_BYPSHAD                               \ Bypass the shadow registers Note: If the frequency of the APB clock is less than seven times the frequency of RTCCLK, BYPSHAD must be set to 1.
$00000040 constant RTC_RTC_CR_FMT                                   \ Hour format
$00000100 constant RTC_RTC_CR_ALRAE                                 \ Alarm A enable
$00000200 constant RTC_RTC_CR_ALRBE                                 \ Alarm B enable
$00000400 constant RTC_RTC_CR_WUTE                                  \ Wakeup timer enable
$00000800 constant RTC_RTC_CR_TSE                                   \ timestamp enable
$00001000 constant RTC_RTC_CR_ALRAIE                                \ Alarm A interrupt enable
$00002000 constant RTC_RTC_CR_ALRBIE                                \ Alarm B interrupt enable
$00004000 constant RTC_RTC_CR_WUTIE                                 \ Wakeup timer interrupt enable
$00008000 constant RTC_RTC_CR_TSIE                                  \ Time-stamp interrupt enable
$00010000 constant RTC_RTC_CR_ADD1H                                 \ Add 1 hour (summer time change) When this bit is set outside initialization mode, 1 hour is added to the calendar time. This bit is always read as 0.
$00020000 constant RTC_RTC_CR_SUB1H                                 \ Subtract 1 hour (winter time change) When this bit is set outside initialization mode, 1 hour is subtracted to the calendar time if the current hour is not 0. This bit is always read as 0. Setting this bit has no effect when current hour is 0.
$00040000 constant RTC_RTC_CR_BKP                                   \ Backup This bit can be written by the user to memorize whether the daylight saving time change has been performed or not.
$00080000 constant RTC_RTC_CR_COSEL                                 \ Calibration output selection When COE=1, this bit selects which signal is output on RTC_CALIB. These frequencies are valid for RTCCLK at 32.768 kHz and prescalers at their default values (PREDIV_A=127 and PREDIV_S=255). Refer to Section24.3.15: Calibration clock output
$00100000 constant RTC_RTC_CR_POL                                   \ Output polarity This bit is used to configure the polarity of RTC_ALARM output
$00600000 constant RTC_RTC_CR_OSEL                                  \ Output selection These bits are used to select the flag to be routed to RTC_ALARM output
$00800000 constant RTC_RTC_CR_COE                                   \ Calibration output enable This bit enables the RTC_CALIB output
$01000000 constant RTC_RTC_CR_ITSE                                  \ timestamp on internal event enable


\
\ @brief This register is write protected (except for RTC_ISR[13:8] bits). The write access procedure is described in RTC register write protection on page9.
\ Address offset: 0x0C
\ Reset value: 0x00000007
\

$00000001 constant RTC_RTC_ISR_ALRAWF                               \ Alarm A write flag This bit is set by hardware when Alarm A values can be changed, after the ALRAE bit has been set to 0 in RTC_CR. It is cleared by hardware in initialization mode.
$00000002 constant RTC_RTC_ISR_ALRBWF                               \ Alarm B write flag This bit is set by hardware when Alarm B values can be changed, after the ALRBE bit has been set to 0 in RTC_CR. It is cleared by hardware in initialization mode.
$00000004 constant RTC_RTC_ISR_WUTWF                                \ Wakeup timer write flag This bit is set by hardware up to 2 RTCCLK cycles after the WUTE bit has been set to 0 in RTC_CR, and is cleared up to 2 RTCCLK cycles after the WUTE bit has been set to 1. The wakeup timer values can be changed when WUTE bit is cleared and WUTWF is set.
$00000008 constant RTC_RTC_ISR_SHPF                                 \ Shift operation pending This flag is set by hardware as soon as a shift operation is initiated by a write to the RTC_SHIFTR register. It is cleared by hardware when the corresponding shift operation has been executed. Writing to the SHPF bit has no effect.
$00000010 constant RTC_RTC_ISR_INITS                                \ Initialization status flag This bit is set by hardware when the calendar year field is different from 0 (Backup domain reset state).
$00000020 constant RTC_RTC_ISR_RSF                                  \ Registers synchronization flag This bit is set by hardware each time the calendar registers are copied into the shadow registers (RTC_SSRx, RTC_TRx and RTC_DRx). This bit is cleared by hardware in initialization mode, while a shift operation is pending (SHPF=1), or when in bypass shadow register mode (BYPSHAD=1). This bit can also be cleared by software. It is cleared either by software or by hardware in initialization mode.
$00000040 constant RTC_RTC_ISR_INITF                                \ Initialization flag When this bit is set to 1, the RTC is in initialization state, and the time, date and prescaler registers can be updated.
$00000080 constant RTC_RTC_ISR_INIT                                 \ Initialization mode
$00000100 constant RTC_RTC_ISR_ALRAF                                \ Alarm A flag This flag is set by hardware when the time/date registers (RTC_TR and RTC_DR) match the Alarm A register (RTC_ALRMAR). This flag is cleared by software by writing 0.
$00000200 constant RTC_RTC_ISR_ALRBF                                \ Alarm B flag This flag is set by hardware when the time/date registers (RTC_TR and RTC_DR) match the Alarm B register (RTC_ALRMBR). This flag is cleared by software by writing 0.
$00000400 constant RTC_RTC_ISR_WUTF                                 \ Wakeup timer flag This flag is set by hardware when the wakeup auto-reload counter reaches 0. This flag is cleared by software by writing 0. This flag must be cleared by software at least 1.5 RTCCLK periods before WUTF is set to 1 again.
$00000800 constant RTC_RTC_ISR_TSF                                  \ Time-stamp flag This flag is set by hardware when a time-stamp event occurs. This flag is cleared by software by writing 0.
$00001000 constant RTC_RTC_ISR_TSOVF                                \ Time-stamp overflow flag This flag is set by hardware when a time-stamp event occurs while TSF is already set. This flag is cleared by software by writing 0. It is recommended to check and then clear TSOVF only after clearing the TSF bit. Otherwise, an overflow might not be noticed if a time-stamp event occurs immediately before the TSF bit is cleared.
$00002000 constant RTC_RTC_ISR_TAMP1F                               \ RTC_TAMP1 detection flag This flag is set by hardware when a tamper detection event is detected on the RTC_TAMP1 input. It is cleared by software writing 0
$00004000 constant RTC_RTC_ISR_TAMP2F                               \ RTC_TAMP2 detection flag This flag is set by hardware when a tamper detection event is detected on the RTC_TAMP2 input. It is cleared by software writing 0
$00008000 constant RTC_RTC_ISR_TAMP3F                               \ RTC_TAMP3 detection flag This flag is set by hardware when a tamper detection event is detected on the RTC_TAMP3 input. It is cleared by software writing 0
$00010000 constant RTC_RTC_ISR_RECALPF                              \ Recalibration pending Flag The RECALPF status flag is automatically set to 1 when software writes to the RTC_CALR register, indicating that the RTC_CALR register is blocked. When the new calibration settings are taken into account, this bit returns to 0. Refer to Re-calibration on-the-fly.
$00020000 constant RTC_RTC_ISR_ITSF                                 \ Internal tTime-stamp flag


\
\ @brief This register must be written in initialization mode only. The initialization must be performed in two separate write accesses. Refer to Calendar initialization and configuration on page9.This register is write protected. The write access procedure is described in RTC register write protection on page9.
\ Address offset: 0x10
\ Reset value: 0x007F00FF
\

$00007fff constant RTC_RTC_PRER_PREDIV_S                            \ Synchronous prescaler factor This is the synchronous division factor: ck_spre frequency = ck_apre frequency/(PREDIV_S+1)
$007f0000 constant RTC_RTC_PRER_PREDIV_A                            \ Asynchronous prescaler factor This is the asynchronous division factor: ck_apre frequency = RTCCLK frequency/(PREDIV_A+1)


\
\ @brief This register can be written only when WUTWF is set to 1 in RTC_ISR.This register is write protected. The write access procedure is described in RTC register write protection on page9.
\ Address offset: 0x14
\ Reset value: 0x0000FFFF
\

$0000ffff constant RTC_RTC_WUTR_WUT                                 \ Wakeup auto-reload value bits When the wakeup timer is enabled (WUTE set to 1), the WUTF flag is set every (WUT[15:0] + 1) ck_wut cycles. The ck_wut period is selected through WUCKSEL[2:0] bits of the RTC_CR register When WUCKSEL[2] = 1, the wakeup timer becomes 17-bits and WUCKSEL[1] effectively becomes WUT[16] the most-significant bit to be reloaded into the timer. The first assertion of WUTF occurs (WUT+1) ck_wut cycles after WUTE is set. Setting WUT[15:0] to 0x0000 with WUCKSEL[2:0] =011 (RTCCLK/2) is forbidden.


\
\ @brief This register can be written only when ALRAWF is set to 1 in RTC_ISR, or in initialization mode.This register is write protected. The write access procedure is described in RTC register write protection on page9.
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant RTC_RTC_ALRMAR_SU                                \ Second units in BCD format.
$00000070 constant RTC_RTC_ALRMAR_ST                                \ Second tens in BCD format.
$00000080 constant RTC_RTC_ALRMAR_MSK1                              \ Alarm A seconds mask
$00000f00 constant RTC_RTC_ALRMAR_MNU                               \ Minute units in BCD format.
$00007000 constant RTC_RTC_ALRMAR_MNT                               \ Minute tens in BCD format.
$00008000 constant RTC_RTC_ALRMAR_MSK2                              \ Alarm A minutes mask
$000f0000 constant RTC_RTC_ALRMAR_HU                                \ Hour units in BCD format.
$00300000 constant RTC_RTC_ALRMAR_HT                                \ Hour tens in BCD format.
$00400000 constant RTC_RTC_ALRMAR_PM                                \ AM/PM notation
$00800000 constant RTC_RTC_ALRMAR_MSK3                              \ Alarm A hours mask
$0f000000 constant RTC_RTC_ALRMAR_DU                                \ Date units or day in BCD format.
$30000000 constant RTC_RTC_ALRMAR_DT                                \ Date tens in BCD format.
$40000000 constant RTC_RTC_ALRMAR_WDSEL                             \ Week day selection
$80000000 constant RTC_RTC_ALRMAR_MSK4                              \ Alarm A date mask


\
\ @brief This register can be written only when ALRBWF is set to 1 in RTC_ISR, or in initialization mode.This register is write protected. The write access procedure is described in RTC register write protection on page9.
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant RTC_RTC_ALRMBR_SU                                \ Second units in BCD format
$00000070 constant RTC_RTC_ALRMBR_ST                                \ Second tens in BCD format
$00000080 constant RTC_RTC_ALRMBR_MSK1                              \ Alarm B seconds mask
$00000f00 constant RTC_RTC_ALRMBR_MNU                               \ Minute units in BCD format
$00007000 constant RTC_RTC_ALRMBR_MNT                               \ Minute tens in BCD format
$00008000 constant RTC_RTC_ALRMBR_MSK2                              \ Alarm B minutes mask
$000f0000 constant RTC_RTC_ALRMBR_HU                                \ Hour units in BCD format
$00300000 constant RTC_RTC_ALRMBR_HT                                \ Hour tens in BCD format
$00400000 constant RTC_RTC_ALRMBR_PM                                \ AM/PM notation
$00800000 constant RTC_RTC_ALRMBR_MSK3                              \ Alarm B hours mask
$0f000000 constant RTC_RTC_ALRMBR_DU                                \ Date units or day in BCD format
$30000000 constant RTC_RTC_ALRMBR_DT                                \ Date tens in BCD format
$40000000 constant RTC_RTC_ALRMBR_WDSEL                             \ Week day selection
$80000000 constant RTC_RTC_ALRMBR_MSK4                              \ Alarm B date mask


\
\ @brief RTC write protection register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant RTC_RTC_WPR_KEY                                  \ Write protection key This byte is written by software. Reading this byte always returns 0x00. Refer to RTC register write protection for a description of how to unlock RTC register write protection.


\
\ @brief RTC sub second register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant RTC_RTC_SSR_SS                                   \ Sub second value SS[15:0] is the value in the synchronous prescaler counter. The fraction of a second is given by the formula below: Second fraction = (PREDIV_S - SS) / (PREDIV_S + 1) Note: SS can be larger than PREDIV_S only after a shift operation. In that case, the correct time/date is one second less than as indicated by RTC_TR/RTC_DR.


\
\ @brief This register is write protected. The write access procedure is described in RTC register write protection on page9.
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00007fff constant RTC_RTC_SHIFTR_SUBFS                             \ Subtract a fraction of a second These bits are write only and is always read as zero. Writing to this bit has no effect when a shift operation is pending (when SHPF=1, in RTC_ISR). The value which is written to SUBFS is added to the synchronous prescaler counter. Since this counter counts down, this operation effectively subtracts from (delays) the clock by: Delay (seconds) = SUBFS / (PREDIV_S + 1) A fraction of a second can effectively be added to the clock (advancing the clock) when the ADD1S function is used in conjunction with SUBFS, effectively advancing the clock by: Advance (seconds) = (1 - (SUBFS / (PREDIV_S + 1))). Note: Writing to SUBFS causes RSF to be cleared. Software can then wait until RSF=1 to be sure that the shadow registers have been updated with the shifted time.
$80000000 constant RTC_RTC_SHIFTR_ADD1S                             \ Add one second This bit is write only and is always read as zero. Writing to this bit has no effect when a shift operation is pending (when SHPF=1, in RTC_ISR). This function is intended to be used with SUBFS (see description below) in order to effectively add a fraction of a second to the clock in an atomic operation.


\
\ @brief The content of this register is valid only when TSF is set to 1 in RTC_ISR. It is cleared when TSF bit is reset.
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000000f constant RTC_RTC_TSTR_SU                                  \ Second units in BCD format.
$00000070 constant RTC_RTC_TSTR_ST                                  \ Second tens in BCD format.
$00000f00 constant RTC_RTC_TSTR_MNU                                 \ Minute units in BCD format.
$00007000 constant RTC_RTC_TSTR_MNT                                 \ Minute tens in BCD format.
$000f0000 constant RTC_RTC_TSTR_HU                                  \ Hour units in BCD format.
$00300000 constant RTC_RTC_TSTR_HT                                  \ Hour tens in BCD format.
$00400000 constant RTC_RTC_TSTR_PM                                  \ AM/PM notation


\
\ @brief The content of this register is valid only when TSF is set to 1 in RTC_ISR. It is cleared when TSF bit is reset.
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000000f constant RTC_RTC_TSDR_DU                                  \ Date units in BCD format
$00000030 constant RTC_RTC_TSDR_DT                                  \ Date tens in BCD format
$00000f00 constant RTC_RTC_TSDR_MU                                  \ Month units in BCD format
$00001000 constant RTC_RTC_TSDR_MT                                  \ Month tens in BCD format
$0000e000 constant RTC_RTC_TSDR_WDU                                 \ Week day units


\
\ @brief The content of this register is valid only when RTC_ISR/TSF is set. It is cleared when the RTC_ISR/TSF bit is reset.
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant RTC_RTC_TSSSR_SS                                 \ Sub second value SS[15:0] is the value of the synchronous prescaler counter when the timestamp event occurred.


\
\ @brief This register is write protected. The write access procedure is described in RTC register write protection on page9.
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$000001ff constant RTC_RTC_CALR_CALM                                \ Calibration minus The frequency of the calendar is reduced by masking CALM out of 220 RTCCLK pulses (32 seconds if the input frequency is 32768 Hz). This decreases the frequency of the calendar with a resolution of 0.9537 ppm. To increase the frequency of the calendar, this feature should be used in conjunction with CALP. See Section24.3.12: RTC smooth digital calibration on page13.
$00002000 constant RTC_RTC_CALR_CALW16                              \ Use a 16-second calibration cycle period When CALW16 is set to 1, the 16-second calibration cycle period is selected.This bit must not be set to 1 if CALW8=1. Note: CALM[0] is stuck at 0 when CALW16= 1. Refer to Section24.3.12: RTC smooth digital calibration.
$00004000 constant RTC_RTC_CALR_CALW8                               \ Use an 8-second calibration cycle period When CALW8 is set to 1, the 8-second calibration cycle period is selected. Note: CALM[1:0] are stuck at 00; when CALW8= 1. Refer to Section24.3.12: RTC smooth digital calibration.
$00008000 constant RTC_RTC_CALR_CALP                                \ Increase frequency of RTC by 488.5 ppm This feature is intended to be used in conjunction with CALM, which lowers the frequency of the calendar with a fine resolution. if the input frequency is 32768 Hz, the number of RTCCLK pulses added during a 32-second window is calculated as follows: (512 * CALP) - CALM. Refer to Section24.3.12: RTC smooth digital calibration.


\
\ @brief RTC tamper and alternate function configuration register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant RTC_RTC_TAMPCR_TAMP1E                            \ RTC_TAMP1 input detection enable
$00000002 constant RTC_RTC_TAMPCR_TAMP1TRG                          \ Active level for RTC_TAMP1 input If TAMPFLT != 00 if TAMPFLT = 00:
$00000004 constant RTC_RTC_TAMPCR_TAMPIE                            \ Tamper interrupt enable
$00000008 constant RTC_RTC_TAMPCR_TAMP2E                            \ RTC_TAMP2 input detection enable
$00000010 constant RTC_RTC_TAMPCR_TAMP2TRG                          \ Active level for RTC_TAMP2 input if TAMPFLT != 00: if TAMPFLT = 00:
$00000020 constant RTC_RTC_TAMPCR_TAMP3E                            \ RTC_TAMP3 detection enable
$00000040 constant RTC_RTC_TAMPCR_TAMP3TRG                          \ Active level for RTC_TAMP3 input if TAMPFLT != 00: if TAMPFLT = 00:
$00000080 constant RTC_RTC_TAMPCR_TAMPTS                            \ Activate timestamp on tamper detection event TAMPTS is valid even if TSE=0 in the RTC_CR register.
$00000700 constant RTC_RTC_TAMPCR_TAMPFREQ                          \ Tamper sampling frequency Determines the frequency at which each of the RTC_TAMPx inputs are sampled.
$00001800 constant RTC_RTC_TAMPCR_TAMPFLT                           \ RTC_TAMPx filter count These bits determines the number of consecutive samples at the specified level (TAMP*TRG) needed to activate a Tamper event. TAMPFLT is valid for each of the RTC_TAMPx inputs.
$00006000 constant RTC_RTC_TAMPCR_TAMPPRCH                          \ RTC_TAMPx precharge duration These bit determines the duration of time during which the pull-up/is activated before each sample. TAMPPRCH is valid for each of the RTC_TAMPx inputs.
$00008000 constant RTC_RTC_TAMPCR_TAMPPUDIS                         \ RTC_TAMPx pull-up disable This bit determines if each of the RTC_TAMPx pins are pre-charged before each sample.
$00010000 constant RTC_RTC_TAMPCR_TAMP1IE                           \ Tamper 1 interrupt enable
$00020000 constant RTC_RTC_TAMPCR_TAMP1NOERASE                      \ Tamper 1 no erase
$00040000 constant RTC_RTC_TAMPCR_TAMP1MF                           \ Tamper 1 mask flag
$00080000 constant RTC_RTC_TAMPCR_TAMP2IE                           \ Tamper 2 interrupt enable
$00100000 constant RTC_RTC_TAMPCR_TAMP2NOERASE                      \ Tamper 2 no erase
$00200000 constant RTC_RTC_TAMPCR_TAMP2MF                           \ Tamper 2 mask flag
$00400000 constant RTC_RTC_TAMPCR_TAMP3IE                           \ Tamper 3 interrupt enable
$00800000 constant RTC_RTC_TAMPCR_TAMP3NOERASE                      \ Tamper 3 no erase
$01000000 constant RTC_RTC_TAMPCR_TAMP3MF                           \ Tamper 3 mask flag


\
\ @brief This register can be written only when ALRAE is reset in RTC_CR register, or in initialization mode.This register is write protected. The write access procedure is described in RTC register write protection on page9
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00007fff constant RTC_RTC_ALRMASSR_SS                              \ Sub seconds value This value is compared with the contents of the synchronous prescaler counter to determine if Alarm A is to be activated. Only bits 0 up MASKSS-1 are compared.
$0f000000 constant RTC_RTC_ALRMASSR_MASKSS                          \ Mask the most-significant bits starting at this bit ... The overflow bits of the synchronous counter (bits 15) is never compared. This bit can be different from 0 only after a shift operation.


\
\ @brief This register can be written only when ALRBE is reset in RTC_CR register, or in initialization mode.This register is write protected.The write access procedure is described in Section: RTC register write protection.
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00007fff constant RTC_RTC_ALRMBSSR_SS                              \ Sub seconds value This value is compared with the contents of the synchronous prescaler counter to determine if Alarm B is to be activated. Only bits 0 up to MASKSS-1 are compared.
$0f000000 constant RTC_RTC_ALRMBSSR_MASKSS                          \ Mask the most-significant bits starting at this bit ... The overflow bits of the synchronous counter (bits 15) is never compared. This bit can be different from 0 only after a shift operation.


\
\ @brief RTC option register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant RTC_RTC_OR_RTC_ALARM_TYPE                        \ RTC_ALARM output type on PC13
$00000002 constant RTC_RTC_OR_RTC_OUT_RMP                           \ RTC_OUT remap


\
\ @brief RTC backup registers
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP0R_BKP                                \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP1R_BKP                                \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP2R_BKP                                \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP3R_BKP                                \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP4R_BKP                                \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP5R_BKP                                \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP6R_BKP                                \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP7R_BKP                                \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP8R_BKP                                \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP9R_BKP                                \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP10R_BKP                               \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP11R_BKP                               \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP12R_BKP                               \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP13R_BKP                               \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP14R_BKP                               \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP15R_BKP                               \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP16R_BKP                               \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP17R_BKP                               \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP18R_BKP                               \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP19R_BKP                               \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP20R_BKP                               \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP21R_BKP                               \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP22R_BKP                               \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP23R_BKP                               \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP24R_BKP                               \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP25R_BKP                               \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP26R_BKP                               \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP27R_BKP                               \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP28R_BKP                               \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP29R_BKP                               \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP30R_BKP                               \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC backup registers
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP31R_BKP                               \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.


\
\ @brief RTC
\
$58004000 constant RTC_RTC_TR     \ offset: 0x00 : The RTC_TR is the calendar time shadow register. This register must be written in initialization mode only. Refer to Calendar initialization and configuration on page9 and Reading the calendar on page10.This register is write protected. The write access procedure is described in RTC register write protection on page9.
$58004004 constant RTC_RTC_DR     \ offset: 0x04 : The RTC_DR is the calendar date shadow register. This register must be written in initialization mode only. Refer to Calendar initialization and configuration on page9 and Reading the calendar on page10.This register is write protected. The write access procedure is described in RTC register write protection on page9.
$58004008 constant RTC_RTC_CR     \ offset: 0x08 : RTC control register
$5800400c constant RTC_RTC_ISR    \ offset: 0x0C : This register is write protected (except for RTC_ISR[13:8] bits). The write access procedure is described in RTC register write protection on page9.
$58004010 constant RTC_RTC_PRER   \ offset: 0x10 : This register must be written in initialization mode only. The initialization must be performed in two separate write accesses. Refer to Calendar initialization and configuration on page9.This register is write protected. The write access procedure is described in RTC register write protection on page9.
$58004014 constant RTC_RTC_WUTR   \ offset: 0x14 : This register can be written only when WUTWF is set to 1 in RTC_ISR.This register is write protected. The write access procedure is described in RTC register write protection on page9.
$5800401c constant RTC_RTC_ALRMAR  \ offset: 0x1C : This register can be written only when ALRAWF is set to 1 in RTC_ISR, or in initialization mode.This register is write protected. The write access procedure is described in RTC register write protection on page9.
$58004020 constant RTC_RTC_ALRMBR  \ offset: 0x20 : This register can be written only when ALRBWF is set to 1 in RTC_ISR, or in initialization mode.This register is write protected. The write access procedure is described in RTC register write protection on page9.
$58004024 constant RTC_RTC_WPR    \ offset: 0x24 : RTC write protection register
$58004028 constant RTC_RTC_SSR    \ offset: 0x28 : RTC sub second register
$5800402c constant RTC_RTC_SHIFTR  \ offset: 0x2C : This register is write protected. The write access procedure is described in RTC register write protection on page9.
$58004030 constant RTC_RTC_TSTR   \ offset: 0x30 : The content of this register is valid only when TSF is set to 1 in RTC_ISR. It is cleared when TSF bit is reset.
$58004034 constant RTC_RTC_TSDR   \ offset: 0x34 : The content of this register is valid only when TSF is set to 1 in RTC_ISR. It is cleared when TSF bit is reset.
$58004038 constant RTC_RTC_TSSSR  \ offset: 0x38 : The content of this register is valid only when RTC_ISR/TSF is set. It is cleared when the RTC_ISR/TSF bit is reset.
$5800403c constant RTC_RTC_CALR   \ offset: 0x3C : This register is write protected. The write access procedure is described in RTC register write protection on page9.
$58004040 constant RTC_RTC_TAMPCR  \ offset: 0x40 : RTC tamper and alternate function configuration register
$58004044 constant RTC_RTC_ALRMASSR  \ offset: 0x44 : This register can be written only when ALRAE is reset in RTC_CR register, or in initialization mode.This register is write protected. The write access procedure is described in RTC register write protection on page9
$58004048 constant RTC_RTC_ALRMBSSR  \ offset: 0x48 : This register can be written only when ALRBE is reset in RTC_CR register, or in initialization mode.This register is write protected.The write access procedure is described in Section: RTC register write protection.
$5800404c constant RTC_RTC_OR     \ offset: 0x4C : RTC option register
$58004050 constant RTC_RTC_BKP0R  \ offset: 0x50 : RTC backup registers
$58004054 constant RTC_RTC_BKP1R  \ offset: 0x54 : RTC backup registers
$58004058 constant RTC_RTC_BKP2R  \ offset: 0x58 : RTC backup registers
$5800405c constant RTC_RTC_BKP3R  \ offset: 0x5C : RTC backup registers
$58004060 constant RTC_RTC_BKP4R  \ offset: 0x60 : RTC backup registers
$58004064 constant RTC_RTC_BKP5R  \ offset: 0x64 : RTC backup registers
$58004068 constant RTC_RTC_BKP6R  \ offset: 0x68 : RTC backup registers
$5800406c constant RTC_RTC_BKP7R  \ offset: 0x6C : RTC backup registers
$58004070 constant RTC_RTC_BKP8R  \ offset: 0x70 : RTC backup registers
$58004074 constant RTC_RTC_BKP9R  \ offset: 0x74 : RTC backup registers
$58004078 constant RTC_RTC_BKP10R  \ offset: 0x78 : RTC backup registers
$5800407c constant RTC_RTC_BKP11R  \ offset: 0x7C : RTC backup registers
$58004080 constant RTC_RTC_BKP12R  \ offset: 0x80 : RTC backup registers
$58004084 constant RTC_RTC_BKP13R  \ offset: 0x84 : RTC backup registers
$58004088 constant RTC_RTC_BKP14R  \ offset: 0x88 : RTC backup registers
$5800408c constant RTC_RTC_BKP15R  \ offset: 0x8C : RTC backup registers
$58004090 constant RTC_RTC_BKP16R  \ offset: 0x90 : RTC backup registers
$58004094 constant RTC_RTC_BKP17R  \ offset: 0x94 : RTC backup registers
$58004098 constant RTC_RTC_BKP18R  \ offset: 0x98 : RTC backup registers
$5800409c constant RTC_RTC_BKP19R  \ offset: 0x9C : RTC backup registers
$580040a0 constant RTC_RTC_BKP20R  \ offset: 0xA0 : RTC backup registers
$580040a4 constant RTC_RTC_BKP21R  \ offset: 0xA4 : RTC backup registers
$580040a8 constant RTC_RTC_BKP22R  \ offset: 0xA8 : RTC backup registers
$580040ac constant RTC_RTC_BKP23R  \ offset: 0xAC : RTC backup registers
$580040b0 constant RTC_RTC_BKP24R  \ offset: 0xB0 : RTC backup registers
$580040b4 constant RTC_RTC_BKP25R  \ offset: 0xB4 : RTC backup registers
$580040b8 constant RTC_RTC_BKP26R  \ offset: 0xB8 : RTC backup registers
$580040bc constant RTC_RTC_BKP27R  \ offset: 0xBC : RTC backup registers
$580040c0 constant RTC_RTC_BKP28R  \ offset: 0xC0 : RTC backup registers
$580040c4 constant RTC_RTC_BKP29R  \ offset: 0xC4 : RTC backup registers
$580040c8 constant RTC_RTC_BKP30R  \ offset: 0xC8 : RTC backup registers
$580040cc constant RTC_RTC_BKP31R  \ offset: 0xCC : RTC backup registers

