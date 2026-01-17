\
\ @file rtc.fs
\ @brief RTC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RTC_DEF

  [ifdef] RTC_RTC_TR_DEF
    \
    \ @brief The RTC_TR is the calendar time shadow register. This register must be written in initialization mode only. Refer to Calendar initialization and configuration on page9 and Reading the calendar on page10.This register is write protected. The write access procedure is described in RTC register write protection on page9.
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SU                         \ [0x00 : 4] Second units in BCD format
    $04 constant RTC_ST                         \ [0x04 : 3] Second tens in BCD format
    $08 constant RTC_MNU                        \ [0x08 : 4] Minute units in BCD format
    $0c constant RTC_MNT                        \ [0x0c : 3] Minute tens in BCD format
    $10 constant RTC_HU                         \ [0x10 : 4] Hour units in BCD format
    $14 constant RTC_HT                         \ [0x14 : 2] Hour tens in BCD format
    $16 constant RTC_PM                         \ [0x16] AM/PM notation
  [then]


  [ifdef] RTC_RTC_DR_DEF
    \
    \ @brief The RTC_DR is the calendar date shadow register. This register must be written in initialization mode only. Refer to Calendar initialization and configuration on page9 and Reading the calendar on page10.This register is write protected. The write access procedure is described in RTC register write protection on page9.
    \ Address offset: 0x04
    \ Reset value: 0x00002101
    \
    $00 constant RTC_DU                         \ [0x00 : 4] Date units in BCD format
    $04 constant RTC_DT                         \ [0x04 : 2] Date tens in BCD format
    $08 constant RTC_MU                         \ [0x08 : 4] Month units in BCD format
    $0c constant RTC_MT                         \ [0x0c] Month tens in BCD format
    $0d constant RTC_WDU                        \ [0x0d : 3] Week day units
    $10 constant RTC_YU                         \ [0x10 : 4] Year units in BCD format
    $14 constant RTC_YT                         \ [0x14 : 4] Year tens in BCD format
  [then]


  [ifdef] RTC_RTC_CR_DEF
    \
    \ @brief RTC control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RTC_WUCKSEL                    \ [0x00 : 3] Wakeup clock selection
    $03 constant RTC_TSEDGE                     \ [0x03] Time-stamp event active edge TSE must be reset when TSEDGE is changed to avoid unwanted TSF setting.
    $04 constant RTC_REFCKON                    \ [0x04] RTC_REFIN reference clock detection enable (50 or 60Hz) Note: PREDIV_S must be 0x00FF.
    $05 constant RTC_BYPSHAD                    \ [0x05] Bypass the shadow registers Note: If the frequency of the APB clock is less than seven times the frequency of RTCCLK, BYPSHAD must be set to 1.
    $06 constant RTC_FMT                        \ [0x06] Hour format
    $08 constant RTC_ALRAE                      \ [0x08] Alarm A enable
    $09 constant RTC_ALRBE                      \ [0x09] Alarm B enable
    $0a constant RTC_WUTE                       \ [0x0a] Wakeup timer enable
    $0b constant RTC_TSE                        \ [0x0b] timestamp enable
    $0c constant RTC_ALRAIE                     \ [0x0c] Alarm A interrupt enable
    $0d constant RTC_ALRBIE                     \ [0x0d] Alarm B interrupt enable
    $0e constant RTC_WUTIE                      \ [0x0e] Wakeup timer interrupt enable
    $0f constant RTC_TSIE                       \ [0x0f] Time-stamp interrupt enable
    $10 constant RTC_ADD1H                      \ [0x10] Add 1 hour (summer time change) When this bit is set outside initialization mode, 1 hour is added to the calendar time. This bit is always read as 0.
    $11 constant RTC_SUB1H                      \ [0x11] Subtract 1 hour (winter time change) When this bit is set outside initialization mode, 1 hour is subtracted to the calendar time if the current hour is not 0. This bit is always read as 0. Setting this bit has no effect when current hour is 0.
    $12 constant RTC_BKP                        \ [0x12] Backup This bit can be written by the user to memorize whether the daylight saving time change has been performed or not.
    $13 constant RTC_COSEL                      \ [0x13] Calibration output selection When COE=1, this bit selects which signal is output on RTC_CALIB. These frequencies are valid for RTCCLK at 32.768 kHz and prescalers at their default values (PREDIV_A=127 and PREDIV_S=255). Refer to Section24.3.15: Calibration clock output
    $14 constant RTC_POL                        \ [0x14] Output polarity This bit is used to configure the polarity of RTC_ALARM output
    $15 constant RTC_OSEL                       \ [0x15 : 2] Output selection These bits are used to select the flag to be routed to RTC_ALARM output
    $17 constant RTC_COE                        \ [0x17] Calibration output enable This bit enables the RTC_CALIB output
    $18 constant RTC_ITSE                       \ [0x18] timestamp on internal event enable
  [then]


  [ifdef] RTC_RTC_ISR_DEF
    \
    \ @brief This register is write protected (except for RTC_ISR[13:8] bits). The write access procedure is described in RTC register write protection on page9.
    \ Address offset: 0x0C
    \ Reset value: 0x00000007
    \
    $00 constant RTC_ALRAWF                     \ [0x00] Alarm A write flag This bit is set by hardware when Alarm A values can be changed, after the ALRAE bit has been set to 0 in RTC_CR. It is cleared by hardware in initialization mode.
    $01 constant RTC_ALRBWF                     \ [0x01] Alarm B write flag This bit is set by hardware when Alarm B values can be changed, after the ALRBE bit has been set to 0 in RTC_CR. It is cleared by hardware in initialization mode.
    $02 constant RTC_WUTWF                      \ [0x02] Wakeup timer write flag This bit is set by hardware up to 2 RTCCLK cycles after the WUTE bit has been set to 0 in RTC_CR, and is cleared up to 2 RTCCLK cycles after the WUTE bit has been set to 1. The wakeup timer values can be changed when WUTE bit is cleared and WUTWF is set.
    $03 constant RTC_SHPF                       \ [0x03] Shift operation pending This flag is set by hardware as soon as a shift operation is initiated by a write to the RTC_SHIFTR register. It is cleared by hardware when the corresponding shift operation has been executed. Writing to the SHPF bit has no effect.
    $04 constant RTC_INITS                      \ [0x04] Initialization status flag This bit is set by hardware when the calendar year field is different from 0 (Backup domain reset state).
    $05 constant RTC_RSF                        \ [0x05] Registers synchronization flag This bit is set by hardware each time the calendar registers are copied into the shadow registers (RTC_SSRx, RTC_TRx and RTC_DRx). This bit is cleared by hardware in initialization mode, while a shift operation is pending (SHPF=1), or when in bypass shadow register mode (BYPSHAD=1). This bit can also be cleared by software. It is cleared either by software or by hardware in initialization mode.
    $06 constant RTC_INITF                      \ [0x06] Initialization flag When this bit is set to 1, the RTC is in initialization state, and the time, date and prescaler registers can be updated.
    $07 constant RTC_INIT                       \ [0x07] Initialization mode
    $08 constant RTC_ALRAF                      \ [0x08] Alarm A flag This flag is set by hardware when the time/date registers (RTC_TR and RTC_DR) match the Alarm A register (RTC_ALRMAR). This flag is cleared by software by writing 0.
    $09 constant RTC_ALRBF                      \ [0x09] Alarm B flag This flag is set by hardware when the time/date registers (RTC_TR and RTC_DR) match the Alarm B register (RTC_ALRMBR). This flag is cleared by software by writing 0.
    $0a constant RTC_WUTF                       \ [0x0a] Wakeup timer flag This flag is set by hardware when the wakeup auto-reload counter reaches 0. This flag is cleared by software by writing 0. This flag must be cleared by software at least 1.5 RTCCLK periods before WUTF is set to 1 again.
    $0b constant RTC_TSF                        \ [0x0b] Time-stamp flag This flag is set by hardware when a time-stamp event occurs. This flag is cleared by software by writing 0.
    $0c constant RTC_TSOVF                      \ [0x0c] Time-stamp overflow flag This flag is set by hardware when a time-stamp event occurs while TSF is already set. This flag is cleared by software by writing 0. It is recommended to check and then clear TSOVF only after clearing the TSF bit. Otherwise, an overflow might not be noticed if a time-stamp event occurs immediately before the TSF bit is cleared.
    $0d constant RTC_TAMP1F                     \ [0x0d] RTC_TAMP1 detection flag This flag is set by hardware when a tamper detection event is detected on the RTC_TAMP1 input. It is cleared by software writing 0
    $0e constant RTC_TAMP2F                     \ [0x0e] RTC_TAMP2 detection flag This flag is set by hardware when a tamper detection event is detected on the RTC_TAMP2 input. It is cleared by software writing 0
    $0f constant RTC_TAMP3F                     \ [0x0f] RTC_TAMP3 detection flag This flag is set by hardware when a tamper detection event is detected on the RTC_TAMP3 input. It is cleared by software writing 0
    $10 constant RTC_RECALPF                    \ [0x10] Recalibration pending Flag The RECALPF status flag is automatically set to 1 when software writes to the RTC_CALR register, indicating that the RTC_CALR register is blocked. When the new calibration settings are taken into account, this bit returns to 0. Refer to Re-calibration on-the-fly.
    $11 constant RTC_ITSF                       \ [0x11] Internal tTime-stamp flag
  [then]


  [ifdef] RTC_RTC_PRER_DEF
    \
    \ @brief This register must be written in initialization mode only. The initialization must be performed in two separate write accesses. Refer to Calendar initialization and configuration on page9.This register is write protected. The write access procedure is described in RTC register write protection on page9.
    \ Address offset: 0x10
    \ Reset value: 0x007F00FF
    \
    $00 constant RTC_PREDIV_S                   \ [0x00 : 15] Synchronous prescaler factor This is the synchronous division factor: ck_spre frequency = ck_apre frequency/(PREDIV_S+1)
    $10 constant RTC_PREDIV_A                   \ [0x10 : 7] Asynchronous prescaler factor This is the asynchronous division factor: ck_apre frequency = RTCCLK frequency/(PREDIV_A+1)
  [then]


  [ifdef] RTC_RTC_WUTR_DEF
    \
    \ @brief This register can be written only when WUTWF is set to 1 in RTC_ISR.This register is write protected. The write access procedure is described in RTC register write protection on page9.
    \ Address offset: 0x14
    \ Reset value: 0x0000FFFF
    \
    $00 constant RTC_WUT                        \ [0x00 : 16] Wakeup auto-reload value bits When the wakeup timer is enabled (WUTE set to 1), the WUTF flag is set every (WUT[15:0] + 1) ck_wut cycles. The ck_wut period is selected through WUCKSEL[2:0] bits of the RTC_CR register When WUCKSEL[2] = 1, the wakeup timer becomes 17-bits and WUCKSEL[1] effectively becomes WUT[16] the most-significant bit to be reloaded into the timer. The first assertion of WUTF occurs (WUT+1) ck_wut cycles after WUTE is set. Setting WUT[15:0] to 0x0000 with WUCKSEL[2:0] =011 (RTCCLK/2) is forbidden.
  [then]


  [ifdef] RTC_RTC_ALRMAR_DEF
    \
    \ @brief This register can be written only when ALRAWF is set to 1 in RTC_ISR, or in initialization mode.This register is write protected. The write access procedure is described in RTC register write protection on page9.
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SU                         \ [0x00 : 4] Second units in BCD format.
    $04 constant RTC_ST                         \ [0x04 : 3] Second tens in BCD format.
    $07 constant RTC_MSK1                       \ [0x07] Alarm A seconds mask
    $08 constant RTC_MNU                        \ [0x08 : 4] Minute units in BCD format.
    $0c constant RTC_MNT                        \ [0x0c : 3] Minute tens in BCD format.
    $0f constant RTC_MSK2                       \ [0x0f] Alarm A minutes mask
    $10 constant RTC_HU                         \ [0x10 : 4] Hour units in BCD format.
    $14 constant RTC_HT                         \ [0x14 : 2] Hour tens in BCD format.
    $16 constant RTC_PM                         \ [0x16] AM/PM notation
    $17 constant RTC_MSK3                       \ [0x17] Alarm A hours mask
    $18 constant RTC_DU                         \ [0x18 : 4] Date units or day in BCD format.
    $1c constant RTC_DT                         \ [0x1c : 2] Date tens in BCD format.
    $1e constant RTC_WDSEL                      \ [0x1e] Week day selection
    $1f constant RTC_MSK4                       \ [0x1f] Alarm A date mask
  [then]


  [ifdef] RTC_RTC_ALRMBR_DEF
    \
    \ @brief This register can be written only when ALRBWF is set to 1 in RTC_ISR, or in initialization mode.This register is write protected. The write access procedure is described in RTC register write protection on page9.
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SU                         \ [0x00 : 4] Second units in BCD format
    $04 constant RTC_ST                         \ [0x04 : 3] Second tens in BCD format
    $07 constant RTC_MSK1                       \ [0x07] Alarm B seconds mask
    $08 constant RTC_MNU                        \ [0x08 : 4] Minute units in BCD format
    $0c constant RTC_MNT                        \ [0x0c : 3] Minute tens in BCD format
    $0f constant RTC_MSK2                       \ [0x0f] Alarm B minutes mask
    $10 constant RTC_HU                         \ [0x10 : 4] Hour units in BCD format
    $14 constant RTC_HT                         \ [0x14 : 2] Hour tens in BCD format
    $16 constant RTC_PM                         \ [0x16] AM/PM notation
    $17 constant RTC_MSK3                       \ [0x17] Alarm B hours mask
    $18 constant RTC_DU                         \ [0x18 : 4] Date units or day in BCD format
    $1c constant RTC_DT                         \ [0x1c : 2] Date tens in BCD format
    $1e constant RTC_WDSEL                      \ [0x1e] Week day selection
    $1f constant RTC_MSK4                       \ [0x1f] Alarm B date mask
  [then]


  [ifdef] RTC_RTC_WPR_DEF
    \
    \ @brief RTC write protection register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant RTC_KEY                        \ [0x00 : 8] Write protection key This byte is written by software. Reading this byte always returns 0x00. Refer to RTC register write protection for a description of how to unlock RTC register write protection.
  [then]


  [ifdef] RTC_RTC_SSR_DEF
    \
    \ @brief RTC sub second register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 16] Sub second value SS[15:0] is the value in the synchronous prescaler counter. The fraction of a second is given by the formula below: Second fraction = (PREDIV_S - SS) / (PREDIV_S + 1) Note: SS can be larger than PREDIV_S only after a shift operation. In that case, the correct time/date is one second less than as indicated by RTC_TR/RTC_DR.
  [then]


  [ifdef] RTC_RTC_SHIFTR_DEF
    \
    \ @brief This register is write protected. The write access procedure is described in RTC register write protection on page9.
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SUBFS                      \ [0x00 : 15] Subtract a fraction of a second These bits are write only and is always read as zero. Writing to this bit has no effect when a shift operation is pending (when SHPF=1, in RTC_ISR). The value which is written to SUBFS is added to the synchronous prescaler counter. Since this counter counts down, this operation effectively subtracts from (delays) the clock by: Delay (seconds) = SUBFS / (PREDIV_S + 1) A fraction of a second can effectively be added to the clock (advancing the clock) when the ADD1S function is used in conjunction with SUBFS, effectively advancing the clock by: Advance (seconds) = (1 - (SUBFS / (PREDIV_S + 1))). Note: Writing to SUBFS causes RSF to be cleared. Software can then wait until RSF=1 to be sure that the shadow registers have been updated with the shifted time.
    $1f constant RTC_ADD1S                      \ [0x1f] Add one second This bit is write only and is always read as zero. Writing to this bit has no effect when a shift operation is pending (when SHPF=1, in RTC_ISR). This function is intended to be used with SUBFS (see description below) in order to effectively add a fraction of a second to the clock in an atomic operation.
  [then]


  [ifdef] RTC_RTC_TSTR_DEF
    \
    \ @brief The content of this register is valid only when TSF is set to 1 in RTC_ISR. It is cleared when TSF bit is reset.
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SU                         \ [0x00 : 4] Second units in BCD format.
    $04 constant RTC_ST                         \ [0x04 : 3] Second tens in BCD format.
    $08 constant RTC_MNU                        \ [0x08 : 4] Minute units in BCD format.
    $0c constant RTC_MNT                        \ [0x0c : 3] Minute tens in BCD format.
    $10 constant RTC_HU                         \ [0x10 : 4] Hour units in BCD format.
    $14 constant RTC_HT                         \ [0x14 : 2] Hour tens in BCD format.
    $16 constant RTC_PM                         \ [0x16] AM/PM notation
  [then]


  [ifdef] RTC_RTC_TSDR_DEF
    \
    \ @brief The content of this register is valid only when TSF is set to 1 in RTC_ISR. It is cleared when TSF bit is reset.
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant RTC_DU                         \ [0x00 : 4] Date units in BCD format
    $04 constant RTC_DT                         \ [0x04 : 2] Date tens in BCD format
    $08 constant RTC_MU                         \ [0x08 : 4] Month units in BCD format
    $0c constant RTC_MT                         \ [0x0c] Month tens in BCD format
    $0d constant RTC_WDU                        \ [0x0d : 3] Week day units
  [then]


  [ifdef] RTC_RTC_TSSSR_DEF
    \
    \ @brief The content of this register is valid only when RTC_ISR/TSF is set. It is cleared when the RTC_ISR/TSF bit is reset.
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 16] Sub second value SS[15:0] is the value of the synchronous prescaler counter when the timestamp event occurred.
  [then]


  [ifdef] RTC_RTC_CALR_DEF
    \
    \ @brief This register is write protected. The write access procedure is described in RTC register write protection on page9.
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_CALM                       \ [0x00 : 9] Calibration minus The frequency of the calendar is reduced by masking CALM out of 220 RTCCLK pulses (32 seconds if the input frequency is 32768 Hz). This decreases the frequency of the calendar with a resolution of 0.9537 ppm. To increase the frequency of the calendar, this feature should be used in conjunction with CALP. See Section24.3.12: RTC smooth digital calibration on page13.
    $0d constant RTC_CALW16                     \ [0x0d] Use a 16-second calibration cycle period When CALW16 is set to 1, the 16-second calibration cycle period is selected.This bit must not be set to 1 if CALW8=1. Note: CALM[0] is stuck at 0 when CALW16= 1. Refer to Section24.3.12: RTC smooth digital calibration.
    $0e constant RTC_CALW8                      \ [0x0e] Use an 8-second calibration cycle period When CALW8 is set to 1, the 8-second calibration cycle period is selected. Note: CALM[1:0] are stuck at 00; when CALW8= 1. Refer to Section24.3.12: RTC smooth digital calibration.
    $0f constant RTC_CALP                       \ [0x0f] Increase frequency of RTC by 488.5 ppm This feature is intended to be used in conjunction with CALM, which lowers the frequency of the calendar with a fine resolution. if the input frequency is 32768 Hz, the number of RTCCLK pulses added during a 32-second window is calculated as follows: (512 * CALP) - CALM. Refer to Section24.3.12: RTC smooth digital calibration.
  [then]


  [ifdef] RTC_RTC_TAMPCR_DEF
    \
    \ @brief RTC tamper and alternate function configuration register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant RTC_TAMP1E                     \ [0x00] RTC_TAMP1 input detection enable
    $01 constant RTC_TAMP1TRG                   \ [0x01] Active level for RTC_TAMP1 input If TAMPFLT != 00 if TAMPFLT = 00:
    $02 constant RTC_TAMPIE                     \ [0x02] Tamper interrupt enable
    $03 constant RTC_TAMP2E                     \ [0x03] RTC_TAMP2 input detection enable
    $04 constant RTC_TAMP2TRG                   \ [0x04] Active level for RTC_TAMP2 input if TAMPFLT != 00: if TAMPFLT = 00:
    $05 constant RTC_TAMP3E                     \ [0x05] RTC_TAMP3 detection enable
    $06 constant RTC_TAMP3TRG                   \ [0x06] Active level for RTC_TAMP3 input if TAMPFLT != 00: if TAMPFLT = 00:
    $07 constant RTC_TAMPTS                     \ [0x07] Activate timestamp on tamper detection event TAMPTS is valid even if TSE=0 in the RTC_CR register.
    $08 constant RTC_TAMPFREQ                   \ [0x08 : 3] Tamper sampling frequency Determines the frequency at which each of the RTC_TAMPx inputs are sampled.
    $0b constant RTC_TAMPFLT                    \ [0x0b : 2] RTC_TAMPx filter count These bits determines the number of consecutive samples at the specified level (TAMP*TRG) needed to activate a Tamper event. TAMPFLT is valid for each of the RTC_TAMPx inputs.
    $0d constant RTC_TAMPPRCH                   \ [0x0d : 2] RTC_TAMPx precharge duration These bit determines the duration of time during which the pull-up/is activated before each sample. TAMPPRCH is valid for each of the RTC_TAMPx inputs.
    $0f constant RTC_TAMPPUDIS                  \ [0x0f] RTC_TAMPx pull-up disable This bit determines if each of the RTC_TAMPx pins are pre-charged before each sample.
    $10 constant RTC_TAMP1IE                    \ [0x10] Tamper 1 interrupt enable
    $11 constant RTC_TAMP1NOERASE               \ [0x11] Tamper 1 no erase
    $12 constant RTC_TAMP1MF                    \ [0x12] Tamper 1 mask flag
    $13 constant RTC_TAMP2IE                    \ [0x13] Tamper 2 interrupt enable
    $14 constant RTC_TAMP2NOERASE               \ [0x14] Tamper 2 no erase
    $15 constant RTC_TAMP2MF                    \ [0x15] Tamper 2 mask flag
    $16 constant RTC_TAMP3IE                    \ [0x16] Tamper 3 interrupt enable
    $17 constant RTC_TAMP3NOERASE               \ [0x17] Tamper 3 no erase
    $18 constant RTC_TAMP3MF                    \ [0x18] Tamper 3 mask flag
  [then]


  [ifdef] RTC_RTC_ALRMASSR_DEF
    \
    \ @brief This register can be written only when ALRAE is reset in RTC_CR register, or in initialization mode.This register is write protected. The write access procedure is described in RTC register write protection on page9
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 15] Sub seconds value This value is compared with the contents of the synchronous prescaler counter to determine if Alarm A is to be activated. Only bits 0 up MASKSS-1 are compared.
    $18 constant RTC_MASKSS                     \ [0x18 : 4] Mask the most-significant bits starting at this bit ... The overflow bits of the synchronous counter (bits 15) is never compared. This bit can be different from 0 only after a shift operation.
  [then]


  [ifdef] RTC_RTC_ALRMBSSR_DEF
    \
    \ @brief This register can be written only when ALRBE is reset in RTC_CR register, or in initialization mode.This register is write protected.The write access procedure is described in Section: RTC register write protection.
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 15] Sub seconds value This value is compared with the contents of the synchronous prescaler counter to determine if Alarm B is to be activated. Only bits 0 up to MASKSS-1 are compared.
    $18 constant RTC_MASKSS                     \ [0x18 : 4] Mask the most-significant bits starting at this bit ... The overflow bits of the synchronous counter (bits 15) is never compared. This bit can be different from 0 only after a shift operation.
  [then]


  [ifdef] RTC_RTC_OR_DEF
    \
    \ @brief RTC option register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_RTC_ALARM_TYPE             \ [0x00] RTC_ALARM output type on PC13
    $01 constant RTC_RTC_OUT_RMP                \ [0x01] RTC_OUT remap
  [then]


  [ifdef] RTC_RTC_BKP0R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP1R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP2R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP3R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP4R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP5R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP6R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP7R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP8R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP9R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP10R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP11R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP12R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP13R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP14R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP15R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP16R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP17R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP18R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP19R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP20R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP21R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP22R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP23R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP24R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP25R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP26R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP27R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP28R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP29R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP30R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]


  [ifdef] RTC_RTC_BKP31R_DEF
    \
    \ @brief RTC backup registers
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant RTC_BKP                        \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. This register is reset on a tamper detection event, as long as TAMPxF=1. or when the Flash readout protection is disabled.
  [then]

  \
  \ @brief RTC
  \
  $00 constant RTC_RTC_TR               \ The RTC_TR is the calendar time shadow register. This register must be written in initialization mode only. Refer to Calendar initialization and configuration on page9 and Reading the calendar on page10.This register is write protected. The write access procedure is described in RTC register write protection on page9.
  $04 constant RTC_RTC_DR               \ The RTC_DR is the calendar date shadow register. This register must be written in initialization mode only. Refer to Calendar initialization and configuration on page9 and Reading the calendar on page10.This register is write protected. The write access procedure is described in RTC register write protection on page9.
  $08 constant RTC_RTC_CR               \ RTC control register
  $0C constant RTC_RTC_ISR              \ This register is write protected (except for RTC_ISR[13:8] bits). The write access procedure is described in RTC register write protection on page9.
  $10 constant RTC_RTC_PRER             \ This register must be written in initialization mode only. The initialization must be performed in two separate write accesses. Refer to Calendar initialization and configuration on page9.This register is write protected. The write access procedure is described in RTC register write protection on page9.
  $14 constant RTC_RTC_WUTR             \ This register can be written only when WUTWF is set to 1 in RTC_ISR.This register is write protected. The write access procedure is described in RTC register write protection on page9.
  $1C constant RTC_RTC_ALRMAR           \ This register can be written only when ALRAWF is set to 1 in RTC_ISR, or in initialization mode.This register is write protected. The write access procedure is described in RTC register write protection on page9.
  $20 constant RTC_RTC_ALRMBR           \ This register can be written only when ALRBWF is set to 1 in RTC_ISR, or in initialization mode.This register is write protected. The write access procedure is described in RTC register write protection on page9.
  $24 constant RTC_RTC_WPR              \ RTC write protection register
  $28 constant RTC_RTC_SSR              \ RTC sub second register
  $2C constant RTC_RTC_SHIFTR           \ This register is write protected. The write access procedure is described in RTC register write protection on page9.
  $30 constant RTC_RTC_TSTR             \ The content of this register is valid only when TSF is set to 1 in RTC_ISR. It is cleared when TSF bit is reset.
  $34 constant RTC_RTC_TSDR             \ The content of this register is valid only when TSF is set to 1 in RTC_ISR. It is cleared when TSF bit is reset.
  $38 constant RTC_RTC_TSSSR            \ The content of this register is valid only when RTC_ISR/TSF is set. It is cleared when the RTC_ISR/TSF bit is reset.
  $3C constant RTC_RTC_CALR             \ This register is write protected. The write access procedure is described in RTC register write protection on page9.
  $40 constant RTC_RTC_TAMPCR           \ RTC tamper and alternate function configuration register
  $44 constant RTC_RTC_ALRMASSR         \ This register can be written only when ALRAE is reset in RTC_CR register, or in initialization mode.This register is write protected. The write access procedure is described in RTC register write protection on page9
  $48 constant RTC_RTC_ALRMBSSR         \ This register can be written only when ALRBE is reset in RTC_CR register, or in initialization mode.This register is write protected.The write access procedure is described in Section: RTC register write protection.
  $4C constant RTC_RTC_OR               \ RTC option register
  $50 constant RTC_RTC_BKP0R            \ RTC backup registers
  $54 constant RTC_RTC_BKP1R            \ RTC backup registers
  $58 constant RTC_RTC_BKP2R            \ RTC backup registers
  $5C constant RTC_RTC_BKP3R            \ RTC backup registers
  $60 constant RTC_RTC_BKP4R            \ RTC backup registers
  $64 constant RTC_RTC_BKP5R            \ RTC backup registers
  $68 constant RTC_RTC_BKP6R            \ RTC backup registers
  $6C constant RTC_RTC_BKP7R            \ RTC backup registers
  $70 constant RTC_RTC_BKP8R            \ RTC backup registers
  $74 constant RTC_RTC_BKP9R            \ RTC backup registers
  $78 constant RTC_RTC_BKP10R           \ RTC backup registers
  $7C constant RTC_RTC_BKP11R           \ RTC backup registers
  $80 constant RTC_RTC_BKP12R           \ RTC backup registers
  $84 constant RTC_RTC_BKP13R           \ RTC backup registers
  $88 constant RTC_RTC_BKP14R           \ RTC backup registers
  $8C constant RTC_RTC_BKP15R           \ RTC backup registers
  $90 constant RTC_RTC_BKP16R           \ RTC backup registers
  $94 constant RTC_RTC_BKP17R           \ RTC backup registers
  $98 constant RTC_RTC_BKP18R           \ RTC backup registers
  $9C constant RTC_RTC_BKP19R           \ RTC backup registers
  $A0 constant RTC_RTC_BKP20R           \ RTC backup registers
  $A4 constant RTC_RTC_BKP21R           \ RTC backup registers
  $A8 constant RTC_RTC_BKP22R           \ RTC backup registers
  $AC constant RTC_RTC_BKP23R           \ RTC backup registers
  $B0 constant RTC_RTC_BKP24R           \ RTC backup registers
  $B4 constant RTC_RTC_BKP25R           \ RTC backup registers
  $B8 constant RTC_RTC_BKP26R           \ RTC backup registers
  $BC constant RTC_RTC_BKP27R           \ RTC backup registers
  $C0 constant RTC_RTC_BKP28R           \ RTC backup registers
  $C4 constant RTC_RTC_BKP29R           \ RTC backup registers
  $C8 constant RTC_RTC_BKP30R           \ RTC backup registers
  $CC constant RTC_RTC_BKP31R           \ RTC backup registers

: RTC_DEF ; [then]
