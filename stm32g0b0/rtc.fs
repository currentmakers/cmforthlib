\
\ @file rtc.fs
\ @brief Real-time clock
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RTC_DEF

  [ifdef] RTC_RTC_TR_DEF
    \
    \ @brief RTC time register
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
    \ @brief RTC date register
    \ Address offset: 0x04
    \ Reset value: 0x00002101
    \
    $00 constant RTC_DU                         \ [0x00 : 4] Date units in BCD format
    $04 constant RTC_DT                         \ [0x04 : 2] Date tens in BCD format
    $08 constant RTC_MU                         \ [0x08 : 4] Month units in BCD format
    $0c constant RTC_MT                         \ [0x0c] Month tens in BCD format
    $0d constant RTC_WDU                        \ [0x0d : 3] Week day units ...
    $10 constant RTC_YU                         \ [0x10 : 4] Year units in BCD format
    $14 constant RTC_YT                         \ [0x14 : 4] Year tens in BCD format
  [then]


  [ifdef] RTC_RTC_SSR_DEF
    \
    \ @brief RTC sub second register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 16] Sub second value SS[15:0] is the value in the synchronous prescaler counter. The fraction of a second is given by the formula below: Second fraction = (PREDIV_S - SS) / (PREDIV_S + 1) Note: SS can be larger than PREDIV_S only after a shift operation. In that case, the correct time/date is one second less than as indicated by RTC_TR/RTC_DR.
  [then]


  [ifdef] RTC_RTC_ICSR_DEF
    \
    \ @brief RTC initialization control and status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000007
    \
    $00 constant RTC_ALRAWF                     \ [0x00] Alarm A write flag This bit is set by hardware when alarm A values can be changed, after the ALRAE bit has been set to 0 in RTC_CR. It is cleared by hardware in initialization mode.
    $01 constant RTC_ALRBWF                     \ [0x01] Alarm B write flag This bit is set by hardware when alarm B values can be changed, after the ALRBE bit has been set to 0 in RTC_CR. It is cleared by hardware in initialization mode.
    $02 constant RTC_WUTWF                      \ [0x02] Wakeup timer write flag This bit is set by hardware when WUT value can be changed, after the WUTE bit has been set to 0 in RTC_CR. It is cleared by hardware in initialization mode.
    $03 constant RTC_SHPF                       \ [0x03] Shift operation pending This flag is set by hardware as soon as a shift operation is initiated by a write to the RTC_SHIFTR register. It is cleared by hardware when the corresponding shift operation has been executed. Writing to the SHPF bit has no effect.
    $04 constant RTC_INITS                      \ [0x04] Initialization status flag This bit is set by hardware when the calendar year field is different from 0 (Backup domain reset state).
    $05 constant RTC_RSF                        \ [0x05] Registers synchronization flag This bit is set by hardware each time the calendar registers are copied into the shadow registers (RTC_SSR, RTC_TR and RTC_DR). This bit is cleared by hardware in initialization mode, while a shift operation is pending (SHPF = 1), or when in bypass shadow register mode (BYPSHAD = 1). This bit can also be cleared by software. It is cleared either by software or by hardware in initialization mode.
    $06 constant RTC_INITF                      \ [0x06] Initialization flag When this bit is set to 1, the RTC is in initialization state, and the time, date and prescaler registers can be updated.
    $07 constant RTC_INIT                       \ [0x07] Initialization mode
    $10 constant RTC_RECALPF                    \ [0x10] Recalibration pending Flag The RECALPF status flag is automatically set to 1 when software writes to the RTC_CALR register, indicating that the RTC_CALR register is blocked. When the new calibration settings are taken into account, this bit returns to 0. Refer to .
  [then]


  [ifdef] RTC_RTC_PRER_DEF
    \
    \ @brief RTC prescaler register
    \ Address offset: 0x10
    \ Reset value: 0x007F00FF
    \
    $00 constant RTC_PREDIV_S                   \ [0x00 : 15] Synchronous prescaler factor This is the synchronous division factor: ck_spre frequency = ck_apre frequency/(PREDIV_S+1)
    $10 constant RTC_PREDIV_A                   \ [0x10 : 7] Asynchronous prescaler factor This is the asynchronous division factor: ck_apre frequency = RTCCLK frequency/(PREDIV_A+1)
  [then]


  [ifdef] RTC_RTC_WUTR_DEF
    \
    \ @brief RTC wakeup timer register
    \ Address offset: 0x14
    \ Reset value: 0x0000FFFF
    \
    $00 constant RTC_WUT                        \ [0x00 : 16] Wakeup auto-reload value bits When the wakeup timer is enabled (WUTE set to 1), the WUTF flag is set every (WUT[15:0]+1) ck_wut cycles. The ck_wut period is selected through WUCKSEL[2:0] bits of the RTC_CR register. When WUCKSEL[2] = 1, the wakeup timer becomes 17-bits and WUCKSEL[1] effectively becomes WUT[16] the most-significant bit to be reloaded into the timer. The first assertion of WUTF occurs between WUT and (WUT + 1) ck_wut cycles after WUTE is set. Setting WUT[15:0] to 0x0000 with WUCKSEL[2:0] = 011 (RTCCLK/2) is forbidden.
  [then]


  [ifdef] RTC_RTC_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RTC_WUCKSEL                    \ [0x00 : 3] ck_wut wakeup clock selection 10x: ck_spre (usually 1Hz) clock is selected 11x: ck_spre (usually 1Hz) clock is selected and 216is added to the WUT counter value
    $03 constant RTC_TSEDGE                     \ [0x03] Timestamp event active edge TSE must be reset when TSEDGE is changed to avoid unwanted TSF setting.
    $04 constant RTC_REFCKON                    \ [0x04] RTC_REFIN reference clock detection enable (50 or 60Hz) Note: PREDIV_S must be 0x00FF.
    $05 constant RTC_BYPSHAD                    \ [0x05] Bypass the shadow registers Note: If the frequency of the APB1 clock is less than seven times the frequency of RTCCLK, BYPSHAD must be set to 1.
    $06 constant RTC_FMT                        \ [0x06] Hour format
    $08 constant RTC_ALRAE                      \ [0x08] Alarm A enable
    $09 constant RTC_ALRBE                      \ [0x09] Alarm B enable
    $0a constant RTC_WUTE                       \ [0x0a] Wakeup timer enable Note: When the wakeup timer is disabled, wait for WUTWF=1 before enabling it again.
    $0b constant RTC_TSE                        \ [0x0b] timestamp enable
    $0c constant RTC_ALRAIE                     \ [0x0c] Alarm A interrupt enable
    $0d constant RTC_ALRBIE                     \ [0x0d] Alarm B interrupt enable
    $0e constant RTC_WUTIE                      \ [0x0e] Wakeup timer interrupt enable
    $0f constant RTC_TSIE                       \ [0x0f] Timestamp interrupt enable
    $10 constant RTC_ADD1H                      \ [0x10] Add 1 hour (summer time change) When this bit is set outside initialization mode, 1 hour is added to the calendar time. This bit is always read as 0.
    $11 constant RTC_SUB1H                      \ [0x11] Subtract 1 hour (winter time change) When this bit is set outside initialization mode, 1 hour is subtracted to the calendar time if the current hour is not 0. This bit is always read as 0. Setting this bit has no effect when current hour is 0.
    $12 constant RTC_BKP                        \ [0x12] Backup This bit can be written by the user to memorize whether the daylight saving time change has been performed or not.
    $13 constant RTC_COSEL                      \ [0x13] Calibration output selection When COE = 1, this bit selects which signal is output on CALIB. These frequencies are valid for RTCCLK at 32.768kHz and prescalers at their default values (PREDIV_A = 127 and PREDIV_S = 255). Refer to .
    $14 constant RTC_POL                        \ [0x14] Output polarity This bit is used to configure the polarity of TAMPALRM output.
    $15 constant RTC_OSEL                       \ [0x15 : 2] Output selection These bits are used to select the flag to be routed to TAMPALRM output.
    $17 constant RTC_COE                        \ [0x17] Calibration output enable This bit enables the CALIB output
    $18 constant RTC_ITSE                       \ [0x18] timestamp on internal event enable
    $19 constant RTC_TAMPTS                     \ [0x19] Activate timestamp on tamper detection event TAMPTS is valid even if TSE = 0 in the RTC_CR register. Timestamp flag is set after the tamper flags, therefore if TAMPTS and TSIE are set, it is recommended to disable the tamper interrupts in order to avoid servicing 2 interrupts.
    $1a constant RTC_TAMPOE                     \ [0x1a] Tamper detection output enable on TAMPALRM
    $1d constant RTC_TAMPALRM_PU                \ [0x1d] TAMPALRM pull-up enable
    $1e constant RTC_TAMPALRM_TYPE              \ [0x1e] TAMPALRM output type
    $1f constant RTC_OUT2EN                     \ [0x1f] RTC_OUT2 output enable Setting this bit allows to remap the RTC outputs on RTC_OUT2 as follows: OUT2EN = 0: RTC output 2 disable If OSEL different 00 or TAMPOE = 1: TAMPALRM is output on RTC_OUT1 If OSEL = 00 and TAMPOE = 0 and COE = 1: CALIB is output on RTC_OUT1 OUT2EN = 1: RTC output 2 enable If (OSEL different 00 or TAMPOE = 1) and COE = 0: TAMPALRM is output on RTC_OUT2 If OSEL = 00 and TAMPOE = 0 and COE = 1: CALIB is output on RTC_OUT2 If (OSEL different 00 or TAMPOE = 1) and COE = 1: CALIB is output on RTC_OUT2 and TAMPALRM is output on RTC_OUT1.
  [then]


  [ifdef] RTC_RTC_WPR_DEF
    \
    \ @brief write protection register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant RTC_KEY                        \ [0x00 : 8] Write protection key This byte is written by software. Reading this byte always returns 0x00. Refer to for a description of how to unlock RTC register write protection.
  [then]


  [ifdef] RTC_RTC_CALR_DEF
    \
    \ @brief RTC calibration register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RTC_CALM                       \ [0x00 : 9] Calibration minus The frequency of the calendar is reduced by masking CALM out of 220 RTCCLK pulses (32 seconds if the input frequency is 32768Hz). This decreases the frequency of the calendar with a resolution of 0.9537ppm. To increase the frequency of the calendar, this feature should be used in conjunction with CALP. See .
    $0d constant RTC_CALW16                     \ [0x0d] Use a 16-second calibration cycle period When CALW16 is set to 1, the 16-second calibration cycle period is selected. This bit must not be set to 1 if CALW8 = 1. Note: CALM[0] is stuck at 0 when CALW16 = 1. Refer to calibration.
    $0e constant RTC_CALW8                      \ [0x0e] Use an 8-second calibration cycle period When CALW8 is set to 1, the 8-second calibration cycle period is selected. Note: CALM[1:0] are stuck at 00 when CALW8 = 1. Refer to digital calibration.
    $0f constant RTC_CALP                       \ [0x0f] Increase frequency of RTC by 488
  [then]


  [ifdef] RTC_RTC_SHIFTR_DEF
    \
    \ @brief RTC shift control register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SUBFS                      \ [0x00 : 15] Subtract a fraction of a second These bits are write only and is always read as zero. Writing to this bit has no effect when a shift operation is pending (when SHPF = 1, in RTC_ICSR). The value which is written to SUBFS is added to the synchronous prescaler counter. Since this counter counts down, this operation effectively subtracts from (delays) the clock by: Delay (seconds) = SUBFS / (PREDIV_S + 1) A fraction of a second can effectively be added to the clock (advancing the clock) when the ADD1S function is used in conjunction with SUBFS, effectively advancing the clock by: Advance (seconds) = (1 - (SUBFS / (PREDIV_S + 1))). Note: Writing to SUBFS causes RSF to be cleared. Software can then wait until RSF = 1 to be sure that the shadow registers have been updated with the shifted time.
    $1f constant RTC_ADD1S                      \ [0x1f] Add one second This bit is write only and is always read as zero. Writing to this bit has no effect when a shift operation is pending (when SHPF = 1, in RTC_ICSR). This function is intended to be used with SUBFS (see description below) in order to effectively add a fraction of a second to the clock in an atomic operation.
  [then]


  [ifdef] RTC_RTC_TSTR_DEF
    \
    \ @brief RTC timestamp time register
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
    \ @brief RTC timestamp date register
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
    \ @brief RTC timestamp sub second register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 16] Sub second value SS[15:0] is the value of the synchronous prescaler counter when the timestamp event occurred.
  [then]


  [ifdef] RTC_RTC_ALRMAR_DEF
    \
    \ @brief RTC alarm A register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SU                         \ [0x00 : 4] Second units in BCD format.
    $04 constant RTC_ST                         \ [0x04 : 3] Second tens in BCD format.
    $07 constant RTC_MSK1                       \ [0x07] Alarm A seconds mask
    $08 constant RTC_MNU                        \ [0x08 : 4] Minute units in BCD format
    $0c constant RTC_MNT                        \ [0x0c : 3] Minute tens in BCD format
    $0f constant RTC_MSK2                       \ [0x0f] Alarm A minutes mask
    $10 constant RTC_HU                         \ [0x10 : 4] Hour units in BCD format
    $14 constant RTC_HT                         \ [0x14 : 2] Hour tens in BCD format
    $16 constant RTC_PM                         \ [0x16] AM/PM notation
    $17 constant RTC_MSK3                       \ [0x17] Alarm A hours mask
    $18 constant RTC_DU                         \ [0x18 : 4] Date units or day in BCD format
    $1c constant RTC_DT                         \ [0x1c : 2] Date tens in BCD format
    $1e constant RTC_WDSEL                      \ [0x1e] Week day selection
    $1f constant RTC_MSK4                       \ [0x1f] Alarm A date mask
  [then]


  [ifdef] RTC_RTC_ALRMASSR_DEF
    \
    \ @brief RTC alarm A sub second register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 15] Sub seconds value This value is compared with the contents of the synchronous prescaler counter to determine if alarm A is to be activated. Only bits 0 up MASKSS-1 are compared.
    $18 constant RTC_MASKSS                     \ [0x18 : 4] Mask the most-significant bits starting at this bit 2: SS[14:2] are don't care in alarm A comparison. Only SS[1:0] are compared. 3: SS[14:3] are don't care in alarm A comparison. Only SS[2:0] are compared. ... 12: SS[14:12] are don't care in alarm A comparison. SS[11:0] are compared. 13: SS[14:13] are don't care in alarm A comparison. SS[12:0] are compared. 14: SS[14] is don't care in alarm A comparison. SS[13:0] are compared. 15: All 15 SS bits are compared and must match to activate alarm. The overflow bits of the synchronous counter (bits 15) is never compared. This bit can be different from 0 only after a shift operation. Note: The overflow bits of the synchronous counter (bits 15) is never compared. This bit can be different from 0 only after a shift operation.
  [then]


  [ifdef] RTC_RTC_ALRMBR_DEF
    \
    \ @brief RTC alarm B register
    \ Address offset: 0x48
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


  [ifdef] RTC_RTC_ALRMBSSR_DEF
    \
    \ @brief RTC alarm B sub second register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 15] Sub seconds value This value is compared with the contents of the synchronous prescaler counter to determine if alarm B is to be activated. Only bits 0 up to MASKSS-1 are compared.
    $18 constant RTC_MASKSS                     \ [0x18 : 4] Mask the most-significant bits starting at this bit ... The overflow bits of the synchronous counter (bits 15) is never compared. This bit can be different from 0 only after a shift operation.
  [then]


  [ifdef] RTC_RTC_SR_DEF
    \
    \ @brief RTC status register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RTC_ALRAF                      \ [0x00] Alarm A flag This flag is set by hardware when the time/date registers (RTC_TR and RTC_DR) match the alarm A register (RTC_ALRMAR).
    $01 constant RTC_ALRBF                      \ [0x01] Alarm B flag This flag is set by hardware when the time/date registers (RTC_TR and RTC_DR) match the alarm B register (RTC_ALRMBR).
    $02 constant RTC_WUTF                       \ [0x02] Wakeup timer flag This flag is set by hardware when the wakeup auto-reload counter reaches 0. This flag must be cleared by software at least 1.5 RTCCLK periods before WUTF is set to 1 again.
    $03 constant RTC_TSF                        \ [0x03] Timestamp flag This flag is set by hardware when a timestamp event occurs. If ITSF flag is set, TSF must be cleared together with ITSF.
    $04 constant RTC_TSOVF                      \ [0x04] Timestamp overflow flag This flag is set by hardware when a timestamp event occurs while TSF is already set. It is recommended to check and then clear TSOVF only after clearing the TSF bit. Otherwise, an overflow might not be noticed if a timestamp event occurs immediately before the TSF bit is cleared.
    $05 constant RTC_ITSF                       \ [0x05] Internal timestamp flag This flag is set by hardware when a timestamp on the internal event occurs.
  [then]


  [ifdef] RTC_RTC_MISR_DEF
    \
    \ @brief RTC masked interrupt status register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RTC_ALRAMF                     \ [0x00] Alarm A masked flag This flag is set by hardware when the alarm A interrupt occurs.
    $01 constant RTC_ALRBMF                     \ [0x01] Alarm B masked flag This flag is set by hardware when the alarm B interrupt occurs.
    $02 constant RTC_WUTMF                      \ [0x02] Wakeup timer masked flag This flag is set by hardware when the wakeup timer interrupt occurs. This flag must be cleared by software at least 1.5 RTCCLK periods before WUTF is set to 1 again.
    $03 constant RTC_TSMF                       \ [0x03] Timestamp masked flag This flag is set by hardware when a timestamp interrupt occurs. If ITSF flag is set, TSF must be cleared together with ITSF.
    $04 constant RTC_TSOVMF                     \ [0x04] Timestamp overflow masked flag This flag is set by hardware when a timestamp interrupt occurs while TSMF is already set. It is recommended to check and then clear TSOVF only after clearing the TSF bit. Otherwise, an overflow might not be noticed if a timestamp event occurs immediately before the TSF bit is cleared.
    $05 constant RTC_ITSMF                      \ [0x05] Internal timestamp masked flag This flag is set by hardware when a timestamp on the internal event occurs and timestampinterrupt is raised.
  [then]


  [ifdef] RTC_RTC_SCR_DEF
    \
    \ @brief RTC status clear register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_CALRAF                     \ [0x00] Clear alarm A flag Writing 1 in this bit clears the ALRAF bit in the RTC_SR register.
    $01 constant RTC_CALRBF                     \ [0x01] Clear alarm B flag Writing 1 in this bit clears the ALRBF bit in the RTC_SR register.
    $02 constant RTC_CWUTF                      \ [0x02] Clear wakeup timer flag Writing 1 in this bit clears the WUTF bit in the RTC_SR register.
    $03 constant RTC_CTSF                       \ [0x03] Clear timestamp flag Writing 1 in this bit clears the TSOVF bit in the RTC_SR register. If ITSF flag is set, TSF must be cleared together with ITSF by setting CRSF and CITSF.
    $04 constant RTC_CTSOVF                     \ [0x04] Clear timestamp overflow flag Writing 1 in this bit clears the TSOVF bit in the RTC_SR register. It is recommended to check and then clear TSOVF only after clearing the TSF bit. Otherwise, an overflow might not be noticed if a timestamp event occurs immediately before the TSF bit is cleared.
    $05 constant RTC_CITSF                      \ [0x05] Clear internal timestamp flag Writing 1 in this bit clears the ITSF bit in the RTC_SR register.
  [then]

  \
  \ @brief Real-time clock
  \
  $00 constant RTC_RTC_TR               \ RTC time register
  $04 constant RTC_RTC_DR               \ RTC date register
  $08 constant RTC_RTC_SSR              \ RTC sub second register
  $0C constant RTC_RTC_ICSR             \ RTC initialization control and status register
  $10 constant RTC_RTC_PRER             \ RTC prescaler register
  $14 constant RTC_RTC_WUTR             \ RTC wakeup timer register
  $18 constant RTC_RTC_CR               \ control register
  $24 constant RTC_RTC_WPR              \ write protection register
  $28 constant RTC_RTC_CALR             \ RTC calibration register
  $2C constant RTC_RTC_SHIFTR           \ RTC shift control register
  $30 constant RTC_RTC_TSTR             \ RTC timestamp time register
  $34 constant RTC_RTC_TSDR             \ RTC timestamp date register
  $38 constant RTC_RTC_TSSSR            \ RTC timestamp sub second register
  $40 constant RTC_RTC_ALRMAR           \ RTC alarm A register
  $44 constant RTC_RTC_ALRMASSR         \ RTC alarm A sub second register
  $48 constant RTC_RTC_ALRMBR           \ RTC alarm B register
  $4C constant RTC_RTC_ALRMBSSR         \ RTC alarm B sub second register
  $50 constant RTC_RTC_SR               \ RTC status register
  $54 constant RTC_RTC_MISR             \ RTC masked interrupt status register
  $5C constant RTC_RTC_SCR              \ RTC status clear register

: RTC_DEF ; [then]
