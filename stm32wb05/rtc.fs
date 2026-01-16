\
\ @file rtc.fs
\ @brief RTC interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RTC_TR register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000000f constant RTC_RTC_TR_SU                                    \ Second units in BCD format.
$00000070 constant RTC_RTC_TR_ST                                    \ Second tens in BCD format.
$00000f00 constant RTC_RTC_TR_MNU                                   \ Minute units in BCD format.
$00007000 constant RTC_RTC_TR_MNT                                   \ Minute tens in BCD format.
$000f0000 constant RTC_RTC_TR_HU                                    \ Hour units in BCD format.
$00300000 constant RTC_RTC_TR_HT                                    \ Hour tens in BCD format.
$00400000 constant RTC_RTC_TR_PM                                    \ AM/PM notation. 0: AM or 24-hour format 1: PM


\
\ @brief RTC_DR register
\ Address offset: 0x04
\ Reset value: 0x00002101
\

$0000000f constant RTC_RTC_DR_DU                                    \ Date units in BCD format.
$00000030 constant RTC_RTC_DR_DT                                    \ Date tens in BCD format.
$00000f00 constant RTC_RTC_DR_MU                                    \ Month units in BCD format.
$00001000 constant RTC_RTC_DR_MT                                    \ Month tens in BCD format.
$0000e000 constant RTC_RTC_DR_WDU                                   \ Week day units 000: forbidden 001: Monday 010: Tuesday 011: Wednesday 100: Thursday 101: Friday 110: Saturday 111: Sunday
$000f0000 constant RTC_RTC_DR_YU                                    \ Year units in BCD format.
$00f00000 constant RTC_RTC_DR_YT                                    \ Year tens in BCD format.


\
\ @brief RTC_CR register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant RTC_RTC_CR_WUCKSEL                               \ Wakeup clock selection 000: RTC/16 clock is selected 001: RTC/8 clock is selected 010: RTC/4 clock is selected 011: RTC/2 clock is selected 10x: ck_spre (usually 1 Hz) clock is selected 11x: ck_spre (usually 1 Hz) clock is selected and 216 is added to the WUT counter value
$00000020 constant RTC_RTC_CR_BYPSHAD                               \ Bypass the shadow registers 0: Calendar values (when reading from RTC_SSR, RTC_TR, and RTC_DR) are taken from the shadow registers, which are updated once every two RTCCLK cycles. 1: Calendar values (when reading from RTC_SSR, RTC_TR, and RTC_DR) are taken directly from the calendar counters.
$00000040 constant RTC_RTC_CR_FMT                                   \ Hour format
$00000100 constant RTC_RTC_CR_ALRAE                                 \ Alarm A enable 0: Alarm A disabled 1: Alarm A enabled
$00000400 constant RTC_RTC_CR_WUTE                                  \ Wakeup timer enable 0: Wakeup timer disabled 1: Wakeup timer enabled
$00001000 constant RTC_RTC_CR_ALRAIE                                \ Alarm A interrupt enable 0: Alarm A interrupt disabled 1: Alarm A interrupt enabled
$00004000 constant RTC_RTC_CR_WUTIE                                 \ Wakeup timer interrupt enable 0: Wakeup timer interrupt disabled 1: Wakeup timer interrupt enabled
$00010000 constant RTC_RTC_CR_ADD1H                                 \ Add 1 hour (summer time change) When this bit is set outside initialization mode, 1 hour is added to the calendar time. This bit is always read as 0. 0: No effect 1: Adds 1 hour to the current time. This can be used for summer time change
$00020000 constant RTC_RTC_CR_SUB1H                                 \ Subtract 1 hour (winter time change) When this bit is set outside initialization mode, 1 hour is subtracted to the calendar time if the current hour is not 0. This bit is always read as 0. Setting this bit has no effect when current hour is 0. 0: No effect 1: Subtracts 1 hour to the current time. This can be used for winter time change.
$00040000 constant RTC_RTC_CR_BKP                                   \ Backup This bit can be written by the user to memorize whether the daylight saving time change has been performed or not.
$00080000 constant RTC_RTC_CR_COSEL                                 \ Calibration output selection When COE=1, this bit selects which signal is output on RTC_CALIB. 0: Calibration output is 512 Hz 1: Calibration output is 1 Hz These frequencies are valid for RTCCLK at 32.768 kHz and prescalers at their default values (PREDIV_A=127 and PREDIV_S=255).
$00100000 constant RTC_RTC_CR_POL                                   \ Output polarity This bit is used to configure the polarity of RTC_ALARM output 0: The pin is high when ALRAF/WUTF is asserted (depending on OSEL[1:0]) 1: The pin is low when ALRAF/WUTF is asserted (depending on OSEL[1:0]).
$00600000 constant RTC_RTC_CR_OSEL                                  \ Output selection These bits are used to select the flag to be routed to RTC_ALARM output 00: Output disabled 01: Alarm A output enabled 10: Reserved 11: Wakeup output enabled
$00800000 constant RTC_RTC_CR_COE                                   \ Calibration output enable This bit enables the RTC_CALIB output 0: Calibration output disabled 1: Calibration output enabled


\
\ @brief RTC_ISR register
\ Address offset: 0x0C
\ Reset value: 0x00000007
\

$00000001 constant RTC_RTC_ISR_ALRAWF                               \ Alarm A write flag This bit is set by hardware when Alarm A values can be changed, after the ALRAE bit has been set to 0 in RTC_CR. It is cleared by hardware in initialization mode. 0: Alarm A update not allowed 1: Alarm A update allowed.
$00000004 constant RTC_RTC_ISR_WUTWF                                \ Wakeup timer write flag This bit is set by hardware when the wakeup timer values can be changed, after the WUTE bit has been set to 0 in RTC_CR. 0: Wakeup timer configuration update not allowed 1: Wakeup timer configuration update allowed.
$00000008 constant RTC_RTC_ISR_SHPF                                 \ Shift operation pending 0: No shift operation is pending 1: A shift operation is pending This flag is set by hardware as soon as a shift operation is initiated by a write to the RTC_SHIFTR register. It is cleared by hardware when the corresponding shift operation has been executed. Writing to the SHPF bit has no effect.
$00000010 constant RTC_RTC_ISR_INITS                                \ Initialization status flag This bit is set by hardware when the calendar year field is different from 0 (power-on reset state). 0: Calendar has not been initialized 1: Calendar has been initialized
$00000020 constant RTC_RTC_ISR_RSF                                  \ Registers synchronization flag This bit is set by hardware each time the calendar registers are copied into the shadow registers (RTC_SSRx, RTC_TRx and RTC_DRx). This bit is cleared by hardware in initialization mode, while a shift operation is pending (SHPF=1), or when in bypass shadow regsiter mode (BYPSHAD=1). This bit can also be cleared by software. It is cleared either by software or by hardware in initialization mode. 0: Calendar shadow registers not yet synchronized 1: Calendar shadow registers synchronized.
$00000040 constant RTC_RTC_ISR_INITF                                \ Initialization flag When this bit is set to 1, the RTC is in initialization state, and the time, date and prescaler registers can be updated. 0: Calendar registers update is not allowed 1: Calendar registers update is allowed.
$00000080 constant RTC_RTC_ISR_INIT                                 \ Initialization mode 0: Free running mode 1: Initialization mode used to program time and date register (RTC_TR and RTC_DR), and prescaler register (RTC_PRER). Counters are stopped and start counting from the new value when INIT is reset.
$00000100 constant RTC_RTC_ISR_ALRAF                                \ Alarm A flag This flag is set by hardware when the time/date registers (RTC_TR and RTC_DR) match the Alarm A register (RTC_ALRMAR). This flag is cleared by software by writing 0.
$00000400 constant RTC_RTC_ISR_WUTF                                 \ Wakeup timer flag This flag is set by hardware when the wakeup auto-reload counter reaches 0. This flag is cleared by software by writing 0. This flag must be cleared by software at least 1.5 RTCCLK periods before WUTF is set to 1 again.
$00010000 constant RTC_RTC_ISR_RECALPF                              \ Recalibration pending Flag The RECALPF status flag is automatically set to 1' when software writes to the RTC_CALR register, indicating that the RTC_CALR register is blocked. When the new calibration settings are taken into account, this bit returns to 0'.


\
\ @brief RTC_PRER register
\ Address offset: 0x10
\ Reset value: 0x007F00FF
\

$00007fff constant RTC_RTC_PRER_PREDIV_S                            \ Synchronous prescaler factor This is the synchronous division factor: ck_spre frequency = ck_apre frequency/(PREDIV_S+1)
$007f0000 constant RTC_RTC_PRER_PREDIV_A                            \ Asynchronous prescaler factor This is the asynchronous division factor: ck_apre frequency = RTCCLK frequency/(PREDIV_A+1)


\
\ @brief RTC_WUTR register
\ Address offset: 0x14
\ Reset value: 0x0000FFFF
\

$0000ffff constant RTC_RTC_WUTR_WUT                                 \ Wakeup auto-reload value bits When the wakeup timer is enabled (WUTE set to 1), the WUTF flag is set every (WUT[15:0] + 1) ck_wut cycles. The ck_wut period is selected through WUCKSEL[2:0] bits of the RTC_CR register When WUCKSEL[2] = 1, the wakeup timer becomes 17-bits and WUCKSEL[1] effectively becomes WUT[16] the most-significant bit to be reloaded into the timer. The first assertion of WUTF occurs (WUT+1) ck_wut cycles after WUTE is set. Setting WUT[15:0] to 0x0000 with WUCKSEL[2:0] =011 (RTCCLK/2) is forbidden.


\
\ @brief RTC_ALRMAR register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant RTC_RTC_ALRMAR_SU                                \ Second units in BCD format.
$00000070 constant RTC_RTC_ALRMAR_ST                                \ Second tens in BCD format.
$00000080 constant RTC_RTC_ALRMAR_MSK1                              \ Alarm A seconds mask 0: Alarm A set if the seconds match 1: Seconds don't care in Alarm A comparison
$00000f00 constant RTC_RTC_ALRMAR_MNU                               \ Minute units in BCD format.
$00007000 constant RTC_RTC_ALRMAR_MNT                               \ Minute tens in BCD format.
$00008000 constant RTC_RTC_ALRMAR_MSK2                              \ Alarm A minutes mask 0: Alarm A set if the minutes match 1: Minutes don't care in Alarm A comparison
$000f0000 constant RTC_RTC_ALRMAR_HU                                \ Hour units in BCD format.
$00300000 constant RTC_RTC_ALRMAR_HT                                \ Hour tens in BCD format.
$00400000 constant RTC_RTC_ALRMAR_PM                                \ AM/PM notation 0: AM or 24-hour format 1: PM
$00800000 constant RTC_RTC_ALRMAR_MSK3                              \ Alarm A hours mask 0: Alarm A set if the hours match 1: Hours don't care in Alarm A comparison
$0f000000 constant RTC_RTC_ALRMAR_DU                                \ Date units or day in BCD format.
$30000000 constant RTC_RTC_ALRMAR_DT                                \ Date tens in BCD format.
$40000000 constant RTC_RTC_ALRMAR_WDSEL                             \ Week day selection 0: DU[3:0] represents the date units 1: DU[3:0] represents the week day. DT[1:0] is don't care.
$80000000 constant RTC_RTC_ALRMAR_MSK4                              \ Alarm A date mask 0: Alarm A set if the date/day match 1: Date/day don't care in Alarm A comparison


\
\ @brief RTC_WPR register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant RTC_RTC_WPR_KEY                                  \ Write protection key This byte is written by software. Reading this byte always returns 0x00


\
\ @brief RTC_SSR register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant RTC_RTC_SSR_SS                                   \ Sub second value SS[15:0] is the value in the synchronous prescaler's counter. The fraction of a second is given by the formula below: Second fraction = ( PREDIV_S - SS ) / ( PREDIV_S + 1 )


\
\ @brief RTC_SHIFTR register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00007fff constant RTC_RTC_SHIFTR_SUBFS                             \ Subtract a fraction of a second These bits are write only and is always read as zero. Writing to this bit has no effect when a shift operation is pending (when SHPF=1, in RTC_ISR). The value which is written to SUBFS is added to the synchronous prescaler's counter. Since this counter counts down, this operation effectively subtracts from (delays) the clock by: Delay (seconds) = SUBFS / ( PREDIV_S + 1 ) A fraction of a second can effectively be added to the clock (advancing the clock) when the ADD1S function is used in conjunction with SUBFS, effectively advancing the clock by : Advance (seconds) = ( 1 - ( SUBFS / ( PREDIV_S + 1 ) ) ) .
$80000000 constant RTC_RTC_SHIFTR_ADD1S                             \ Add one second 0: No effect 1: Add one second to the clock/calendar This bit is write only and is always read as zero. Writing to this bit has no effect when a shift operation is pending (when SHPF=1, in RTC_ISR). This function is intended to be used with SUBFS (see description below) in order to effectively add a fraction of a second to the clock in an atomic operation.


\
\ @brief RTC_CALR register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$000001ff constant RTC_RTC_CALR_CALM                                \ Calibration minus The frequency of the calendar is reduced by masking CALM out of 220 RTCCLK pulses (32 seconds if the input frequency is 32768 Hz). This decreases the frequency of the calendar with a resolution of 0.9537 ppm. To increase the frequency of the calendar, this feature should be used in conjunction with CALP.
$00002000 constant RTC_RTC_CALR_CALW16                              \ Use a 16-second calibration cycle period When CALW16 is set to 1' , the 16-second calibration cycle period is selected.This bit must not be set to 1' if CALW8=1. Note: CALM[0] is stucked at 0' when CALW16='1'.
$00004000 constant RTC_RTC_CALR_CALW8                               \ Use an 8-second calibration cycle period When CALW8 is set to 1' , the 8-second calibration cycle period is selected. Note: CALM[1:0] are stucked at '00' when CALW8='1'.
$00008000 constant RTC_RTC_CALR_CALP                                \ Increase frequency of RTC by 488.5 ppm 0: No RTCCLK pulses are added. 1: One RTCCLK pulse is effectively inserted every 211 pulses (frequency incresed by 488.5 ppm). This feature is intended to be used in conjunction with CALM, which lowers the frequency of the calendar with a fine resolution. if the input frequency is 32768 Hz, the number of RTCCLK pulses added during a 32-second window is calculated as follows: (512 * CALP) - CALM.


\
\ @brief RTC_ALRMASSR register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00007fff constant RTC_RTC_ALRMASSR_SS                              \ Sub seconds value This value is compared with the contents of the synchronous prescaler's counter to determine if Alarm A is to be activated. Only bits 0 up MASKSS-1 are compared.
$0f000000 constant RTC_RTC_ALRMASSR_MASKSS                          \ Mask the most-significant bits starting at this bit 0: No comparison on sub seconds for Alarm A. The alarm is set when the seconds unit is incremented (assuming that the rest of the fields match). 1: SS[14:1] are don't care in Alarm A comparison. Only SS[0] is compared. 2: SS[14:2] are don't care in Alarm A comparison. Only SS[1:0] are compared. 3: SS[14:3] are don't care in Alarm A comparison. Only SS[2:0] are compared. ... 12: SS[14:12] are don't care in Alarm A comparison. SS[11:0] are compared. 13: SS[14:13] are don't care in Alarm A comparison. SS[12:0] are compared. 14: SS[14] is don't care in Alarm A comparison. SS[13:0] are compared. 15: All 15 SS bits are compared and must match to activate alarm. The overflow bits of the synchronous counter (bits 15) is never compared. This bit can be different from 0 only after a shift operation.


\
\ @brief RTC_BKP0R register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP0R_BKP                                \ The application can write or read data to and from these registers. They are powered-on by VDD12o so they are retained during DEEPSTOP mode. The application can write or read data to and from these registers. This register is reset on PORESETn only.


\
\ @brief RTC_BKP1R register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant RTC_RTC_BKP1R_BKP                                \ The application can write or read data to and from these registers. They are powered-on by VDD12o so they are retained during DEEPSTOP mode. The application can write or read data to and from these registers. This register is reset on PORESETn only.


\
\ @brief RTC interrupt
\
$40004000 constant RTC_RTC_TR     \ offset: 0x00 : RTC_TR register
$40004004 constant RTC_RTC_DR     \ offset: 0x04 : RTC_DR register
$40004008 constant RTC_RTC_CR     \ offset: 0x08 : RTC_CR register
$4000400c constant RTC_RTC_ISR    \ offset: 0x0C : RTC_ISR register
$40004010 constant RTC_RTC_PRER   \ offset: 0x10 : RTC_PRER register
$40004014 constant RTC_RTC_WUTR   \ offset: 0x14 : RTC_WUTR register
$4000401c constant RTC_RTC_ALRMAR  \ offset: 0x1C : RTC_ALRMAR register
$40004024 constant RTC_RTC_WPR    \ offset: 0x24 : RTC_WPR register
$40004028 constant RTC_RTC_SSR    \ offset: 0x28 : RTC_SSR register
$4000402c constant RTC_RTC_SHIFTR  \ offset: 0x2C : RTC_SHIFTR register
$4000403c constant RTC_RTC_CALR   \ offset: 0x3C : RTC_CALR register
$40004044 constant RTC_RTC_ALRMASSR  \ offset: 0x44 : RTC_ALRMASSR register
$40004050 constant RTC_RTC_BKP0R  \ offset: 0x50 : RTC_BKP0R register
$40004054 constant RTC_RTC_BKP1R  \ offset: 0x54 : RTC_BKP1R register

