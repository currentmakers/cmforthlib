\
\ @file rtc.fs
\ @brief RTC interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RTC_DEF

  [ifdef] RTC_RTC_TR_DEF
    \
    \ @brief RTC_TR register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SU                         \ [0x00 : 4] Second units in BCD format.
    $04 constant RTC_ST                         \ [0x04 : 3] Second tens in BCD format.
    $08 constant RTC_MNU                        \ [0x08 : 4] Minute units in BCD format.
    $0c constant RTC_MNT                        \ [0x0c : 3] Minute tens in BCD format.
    $10 constant RTC_HU                         \ [0x10 : 4] Hour units in BCD format.
    $14 constant RTC_HT                         \ [0x14 : 2] Hour tens in BCD format.
    $16 constant RTC_PM                         \ [0x16] AM/PM notation. 0: AM or 24-hour format 1: PM
  [then]


  [ifdef] RTC_RTC_DR_DEF
    \
    \ @brief RTC_DR register
    \ Address offset: 0x04
    \ Reset value: 0x00002101
    \
    $00 constant RTC_DU                         \ [0x00 : 4] Date units in BCD format.
    $04 constant RTC_DT                         \ [0x04 : 2] Date tens in BCD format.
    $08 constant RTC_MU                         \ [0x08 : 4] Month units in BCD format.
    $0c constant RTC_MT                         \ [0x0c] Month tens in BCD format.
    $0d constant RTC_WDU                        \ [0x0d : 3] Week day units 000: forbidden 001: Monday 010: Tuesday 011: Wednesday 100: Thursday 101: Friday 110: Saturday 111: Sunday
    $10 constant RTC_YU                         \ [0x10 : 4] Year units in BCD format.
    $14 constant RTC_YT                         \ [0x14 : 4] Year tens in BCD format.
  [then]


  [ifdef] RTC_RTC_CR_DEF
    \
    \ @brief RTC_CR register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RTC_WUCKSEL                    \ [0x00 : 3] Wakeup clock selection 000: RTC/16 clock is selected 001: RTC/8 clock is selected 010: RTC/4 clock is selected 011: RTC/2 clock is selected 10x: ck_spre (usually 1 Hz) clock is selected 11x: ck_spre (usually 1 Hz) clock is selected and 216 is added to the WUT counter value
    $05 constant RTC_BYPSHAD                    \ [0x05] Bypass the shadow registers 0: Calendar values (when reading from RTC_SSR, RTC_TR, and RTC_DR) are taken from the shadow registers, which are updated once every two RTCCLK cycles. 1: Calendar values (when reading from RTC_SSR, RTC_TR, and RTC_DR) are taken directly from the calendar counters.
    $06 constant RTC_FMT                        \ [0x06] Hour format
    $08 constant RTC_ALRAE                      \ [0x08] Alarm A enable 0: Alarm A disabled 1: Alarm A enabled
    $0a constant RTC_WUTE                       \ [0x0a] Wakeup timer enable 0: Wakeup timer disabled 1: Wakeup timer enabled
    $0c constant RTC_ALRAIE                     \ [0x0c] Alarm A interrupt enable 0: Alarm A interrupt disabled 1: Alarm A interrupt enabled
    $0e constant RTC_WUTIE                      \ [0x0e] Wakeup timer interrupt enable 0: Wakeup timer interrupt disabled 1: Wakeup timer interrupt enabled
    $10 constant RTC_ADD1H                      \ [0x10] Add 1 hour (summer time change) When this bit is set outside initialization mode, 1 hour is added to the calendar time. This bit is always read as 0. 0: No effect 1: Adds 1 hour to the current time. This can be used for summer time change
    $11 constant RTC_SUB1H                      \ [0x11] Subtract 1 hour (winter time change) When this bit is set outside initialization mode, 1 hour is subtracted to the calendar time if the current hour is not 0. This bit is always read as 0. Setting this bit has no effect when current hour is 0. 0: No effect 1: Subtracts 1 hour to the current time. This can be used for winter time change.
    $12 constant RTC_BKP                        \ [0x12] Backup This bit can be written by the user to memorize whether the daylight saving time change has been performed or not.
    $13 constant RTC_COSEL                      \ [0x13] Calibration output selection When COE=1, this bit selects which signal is output on RTC_CALIB. 0: Calibration output is 512 Hz 1: Calibration output is 1 Hz These frequencies are valid for RTCCLK at 32.768 kHz and prescalers at their default values (PREDIV_A=127 and PREDIV_S=255).
    $14 constant RTC_POL                        \ [0x14] Output polarity This bit is used to configure the polarity of RTC_ALARM output 0: The pin is high when ALRAF/WUTF is asserted (depending on OSEL[1:0]) 1: The pin is low when ALRAF/WUTF is asserted (depending on OSEL[1:0]).
    $15 constant RTC_OSEL                       \ [0x15 : 2] Output selection These bits are used to select the flag to be routed to RTC_ALARM output 00: Output disabled 01: Alarm A output enabled 10: Reserved 11: Wakeup output enabled
    $17 constant RTC_COE                        \ [0x17] Calibration output enable This bit enables the RTC_CALIB output 0: Calibration output disabled 1: Calibration output enabled
  [then]


  [ifdef] RTC_RTC_ISR_DEF
    \
    \ @brief RTC_ISR register
    \ Address offset: 0x0C
    \ Reset value: 0x00000007
    \
    $00 constant RTC_ALRAWF                     \ [0x00] Alarm A write flag This bit is set by hardware when Alarm A values can be changed, after the ALRAE bit has been set to 0 in RTC_CR. It is cleared by hardware in initialization mode. 0: Alarm A update not allowed 1: Alarm A update allowed.
    $02 constant RTC_WUTWF                      \ [0x02] Wakeup timer write flag This bit is set by hardware when the wakeup timer values can be changed, after the WUTE bit has been set to 0 in RTC_CR. 0: Wakeup timer configuration update not allowed 1: Wakeup timer configuration update allowed.
    $03 constant RTC_SHPF                       \ [0x03] Shift operation pending 0: No shift operation is pending 1: A shift operation is pending This flag is set by hardware as soon as a shift operation is initiated by a write to the RTC_SHIFTR register. It is cleared by hardware when the corresponding shift operation has been executed. Writing to the SHPF bit has no effect.
    $04 constant RTC_INITS                      \ [0x04] Initialization status flag This bit is set by hardware when the calendar year field is different from 0 (power-on reset state). 0: Calendar has not been initialized 1: Calendar has been initialized
    $05 constant RTC_RSF                        \ [0x05] Registers synchronization flag This bit is set by hardware each time the calendar registers are copied into the shadow registers (RTC_SSRx, RTC_TRx and RTC_DRx). This bit is cleared by hardware in initialization mode, while a shift operation is pending (SHPF=1), or when in bypass shadow regsiter mode (BYPSHAD=1). This bit can also be cleared by software. It is cleared either by software or by hardware in initialization mode. 0: Calendar shadow registers not yet synchronized 1: Calendar shadow registers synchronized.
    $06 constant RTC_INITF                      \ [0x06] Initialization flag When this bit is set to 1, the RTC is in initialization state, and the time, date and prescaler registers can be updated. 0: Calendar registers update is not allowed 1: Calendar registers update is allowed.
    $07 constant RTC_INIT                       \ [0x07] Initialization mode 0: Free running mode 1: Initialization mode used to program time and date register (RTC_TR and RTC_DR), and prescaler register (RTC_PRER). Counters are stopped and start counting from the new value when INIT is reset.
    $08 constant RTC_ALRAF                      \ [0x08] Alarm A flag This flag is set by hardware when the time/date registers (RTC_TR and RTC_DR) match the Alarm A register (RTC_ALRMAR). This flag is cleared by software by writing 0.
    $0a constant RTC_WUTF                       \ [0x0a] Wakeup timer flag This flag is set by hardware when the wakeup auto-reload counter reaches 0. This flag is cleared by software by writing 0. This flag must be cleared by software at least 1.5 RTCCLK periods before WUTF is set to 1 again.
    $10 constant RTC_RECALPF                    \ [0x10] Recalibration pending Flag The RECALPF status flag is automatically set to 1' when software writes to the RTC_CALR register, indicating that the RTC_CALR register is blocked. When the new calibration settings are taken into account, this bit returns to 0'.
  [then]


  [ifdef] RTC_RTC_PRER_DEF
    \
    \ @brief RTC_PRER register
    \ Address offset: 0x10
    \ Reset value: 0x007F00FF
    \
    $00 constant RTC_PREDIV_S                   \ [0x00 : 15] Synchronous prescaler factor This is the synchronous division factor: ck_spre frequency = ck_apre frequency/(PREDIV_S+1)
    $10 constant RTC_PREDIV_A                   \ [0x10 : 7] Asynchronous prescaler factor This is the asynchronous division factor: ck_apre frequency = RTCCLK frequency/(PREDIV_A+1)
  [then]


  [ifdef] RTC_RTC_WUTR_DEF
    \
    \ @brief RTC_WUTR register
    \ Address offset: 0x14
    \ Reset value: 0x0000FFFF
    \
    $00 constant RTC_WUT                        \ [0x00 : 16] Wakeup auto-reload value bits When the wakeup timer is enabled (WUTE set to 1), the WUTF flag is set every (WUT[15:0] + 1) ck_wut cycles. The ck_wut period is selected through WUCKSEL[2:0] bits of the RTC_CR register When WUCKSEL[2] = 1, the wakeup timer becomes 17-bits and WUCKSEL[1] effectively becomes WUT[16] the most-significant bit to be reloaded into the timer. The first assertion of WUTF occurs (WUT+1) ck_wut cycles after WUTE is set. Setting WUT[15:0] to 0x0000 with WUCKSEL[2:0] =011 (RTCCLK/2) is forbidden.
  [then]


  [ifdef] RTC_RTC_ALRMAR_DEF
    \
    \ @brief RTC_ALRMAR register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SU                         \ [0x00 : 4] Second units in BCD format.
    $04 constant RTC_ST                         \ [0x04 : 3] Second tens in BCD format.
    $07 constant RTC_MSK1                       \ [0x07] Alarm A seconds mask 0: Alarm A set if the seconds match 1: Seconds don't care in Alarm A comparison
    $08 constant RTC_MNU                        \ [0x08 : 4] Minute units in BCD format.
    $0c constant RTC_MNT                        \ [0x0c : 3] Minute tens in BCD format.
    $0f constant RTC_MSK2                       \ [0x0f] Alarm A minutes mask 0: Alarm A set if the minutes match 1: Minutes don't care in Alarm A comparison
    $10 constant RTC_HU                         \ [0x10 : 4] Hour units in BCD format.
    $14 constant RTC_HT                         \ [0x14 : 2] Hour tens in BCD format.
    $16 constant RTC_PM                         \ [0x16] AM/PM notation 0: AM or 24-hour format 1: PM
    $17 constant RTC_MSK3                       \ [0x17] Alarm A hours mask 0: Alarm A set if the hours match 1: Hours don't care in Alarm A comparison
    $18 constant RTC_DU                         \ [0x18 : 4] Date units or day in BCD format.
    $1c constant RTC_DT                         \ [0x1c : 2] Date tens in BCD format.
    $1e constant RTC_WDSEL                      \ [0x1e] Week day selection 0: DU[3:0] represents the date units 1: DU[3:0] represents the week day. DT[1:0] is don't care.
    $1f constant RTC_MSK4                       \ [0x1f] Alarm A date mask 0: Alarm A set if the date/day match 1: Date/day don't care in Alarm A comparison
  [then]


  [ifdef] RTC_RTC_WPR_DEF
    \
    \ @brief RTC_WPR register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant RTC_KEY                        \ [0x00 : 8] Write protection key This byte is written by software. Reading this byte always returns 0x00
  [then]


  [ifdef] RTC_RTC_SSR_DEF
    \
    \ @brief RTC_SSR register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 16] Sub second value SS[15:0] is the value in the synchronous prescaler's counter. The fraction of a second is given by the formula below: Second fraction = ( PREDIV_S - SS ) / ( PREDIV_S + 1 )
  [then]


  [ifdef] RTC_RTC_SHIFTR_DEF
    \
    \ @brief RTC_SHIFTR register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SUBFS                      \ [0x00 : 15] Subtract a fraction of a second These bits are write only and is always read as zero. Writing to this bit has no effect when a shift operation is pending (when SHPF=1, in RTC_ISR). The value which is written to SUBFS is added to the synchronous prescaler's counter. Since this counter counts down, this operation effectively subtracts from (delays) the clock by: Delay (seconds) = SUBFS / ( PREDIV_S + 1 ) A fraction of a second can effectively be added to the clock (advancing the clock) when the ADD1S function is used in conjunction with SUBFS, effectively advancing the clock by : Advance (seconds) = ( 1 - ( SUBFS / ( PREDIV_S + 1 ) ) ) .
    $1f constant RTC_ADD1S                      \ [0x1f] Add one second 0: No effect 1: Add one second to the clock/calendar This bit is write only and is always read as zero. Writing to this bit has no effect when a shift operation is pending (when SHPF=1, in RTC_ISR). This function is intended to be used with SUBFS (see description below) in order to effectively add a fraction of a second to the clock in an atomic operation.
  [then]


  [ifdef] RTC_RTC_CALR_DEF
    \
    \ @brief RTC_CALR register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_CALM                       \ [0x00 : 9] Calibration minus The frequency of the calendar is reduced by masking CALM out of 220 RTCCLK pulses (32 seconds if the input frequency is 32768 Hz). This decreases the frequency of the calendar with a resolution of 0.9537 ppm. To increase the frequency of the calendar, this feature should be used in conjunction with CALP.
    $0d constant RTC_CALW16                     \ [0x0d] Use a 16-second calibration cycle period When CALW16 is set to 1' , the 16-second calibration cycle period is selected.This bit must not be set to 1' if CALW8=1. Note: CALM[0] is stucked at 0' when CALW16='1'.
    $0e constant RTC_CALW8                      \ [0x0e] Use an 8-second calibration cycle period When CALW8 is set to 1' , the 8-second calibration cycle period is selected. Note: CALM[1:0] are stucked at '00' when CALW8='1'.
    $0f constant RTC_CALP                       \ [0x0f] Increase frequency of RTC by 488.5 ppm 0: No RTCCLK pulses are added. 1: One RTCCLK pulse is effectively inserted every 211 pulses (frequency incresed by 488.5 ppm). This feature is intended to be used in conjunction with CALM, which lowers the frequency of the calendar with a fine resolution. if the input frequency is 32768 Hz, the number of RTCCLK pulses added during a 32-second window is calculated as follows: (512 * CALP) - CALM.
  [then]


  [ifdef] RTC_RTC_ALRMASSR_DEF
    \
    \ @brief RTC_ALRMASSR register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 15] Sub seconds value This value is compared with the contents of the synchronous prescaler's counter to determine if Alarm A is to be activated. Only bits 0 up MASKSS-1 are compared.
    $18 constant RTC_MASKSS                     \ [0x18 : 4] Mask the most-significant bits starting at this bit 0: No comparison on sub seconds for Alarm A. The alarm is set when the seconds unit is incremented (assuming that the rest of the fields match). 1: SS[14:1] are don't care in Alarm A comparison. Only SS[0] is compared. 2: SS[14:2] are don't care in Alarm A comparison. Only SS[1:0] are compared. 3: SS[14:3] are don't care in Alarm A comparison. Only SS[2:0] are compared. ... 12: SS[14:12] are don't care in Alarm A comparison. SS[11:0] are compared. 13: SS[14:13] are don't care in Alarm A comparison. SS[12:0] are compared. 14: SS[14] is don't care in Alarm A comparison. SS[13:0] are compared. 15: All 15 SS bits are compared and must match to activate alarm. The overflow bits of the synchronous counter (bits 15) is never compared. This bit can be different from 0 only after a shift operation.
  [then]


  [ifdef] RTC_RTC_BKP0R_DEF
    \
    \ @brief RTC_BKP0R register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VDD12o so they are retained during DEEPSTOP mode. The application can write or read data to and from these registers. This register is reset on PORESETn only.
  [then]


  [ifdef] RTC_RTC_BKP1R_DEF
    \
    \ @brief RTC_BKP1R register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VDD12o so they are retained during DEEPSTOP mode. The application can write or read data to and from these registers. This register is reset on PORESETn only.
  [then]

  \
  \ @brief RTC interrupt
  \
  $00 constant RTC_RTC_TR               \ RTC_TR register
  $04 constant RTC_RTC_DR               \ RTC_DR register
  $08 constant RTC_RTC_CR               \ RTC_CR register
  $0C constant RTC_RTC_ISR              \ RTC_ISR register
  $10 constant RTC_RTC_PRER             \ RTC_PRER register
  $14 constant RTC_RTC_WUTR             \ RTC_WUTR register
  $1C constant RTC_RTC_ALRMAR           \ RTC_ALRMAR register
  $24 constant RTC_RTC_WPR              \ RTC_WPR register
  $28 constant RTC_RTC_SSR              \ RTC_SSR register
  $2C constant RTC_RTC_SHIFTR           \ RTC_SHIFTR register
  $3C constant RTC_RTC_CALR             \ RTC_CALR register
  $44 constant RTC_RTC_ALRMASSR         \ RTC_ALRMASSR register
  $50 constant RTC_RTC_BKP0R            \ RTC_BKP0R register
  $54 constant RTC_RTC_BKP1R            \ RTC_BKP1R register

: RTC_DEF ; [then]
