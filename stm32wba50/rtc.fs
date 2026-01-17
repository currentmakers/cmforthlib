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
    \ @brief RTC subsecond register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 32] Synchronous binary counter SS[31:16]: Synchronous binary counter MSB values When Binary or Mixed mode is selected (BIN = 01 or 10 or 11): SS[31:16] are the 16 MSB of the SS[31:0] free-running down-counter. When BCD mode is selected (BIN=00): SS[31:16] are forced by hardware to 0x0000. SS[15:0]: Subsecond value/synchronous binary counter LSB values When Binary mode is selected (BIN = 01 or 10 or 11): SS[15:0] are the 16 LSB of the SS[31:0] free-running down-counter. When BCD mode is selected (BIN=00): SS[15:0] is the value in the synchronous prescaler counter. The fraction of a second is given by the formula below: Second fraction = (PREDIV_S - SS) / (PREDIV_S + 1) SS can be larger than PREDIV_S only after a shift operation. In that case, the correct time/date is one second less than as indicated by RTC_TR/RTC_DR.
  [then]


  [ifdef] RTC_RTC_ICSR_DEF
    \
    \ @brief RTC initialization control and status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000007
    \
    $02 constant RTC_WUTWF                      \ [0x02] Wakeup timer write flag This bit is set by hardware when WUT value can be changed, after the WUTE bit has been set to 0 in RTC_CR. It is cleared by hardware in initialization mode.
    $03 constant RTC_SHPF                       \ [0x03] Shift operation pending This flag is set by hardware as soon as a shift operation is initiated by a write to the RTC_SHIFTR register. It is cleared by hardware when the corresponding shift operation has been executed. Writing to the SHPF bit has no effect.
    $04 constant RTC_INITS                      \ [0x04] Initialization status flag This bit is set by hardware when the calendar year field is different from 0 (Backup domain reset state).
    $05 constant RTC_RSF                        \ [0x05] Registers synchronization flag This bit is set by hardware each time the calendar registers are copied into the shadow registers (RTC_SSR, RTC_TR and RTC_DR). This bit is cleared by hardware in initialization mode, while a shift operation is pending (SHPF = 1), or when in bypass shadow register mode (BYPSHAD = 1). This bit can also be cleared by software. It is cleared either by software or by hardware in initialization mode.
    $06 constant RTC_INITF                      \ [0x06] Initialization flag When this bit is set to 1, the RTC is in initialization state, and the time, date and prescaler registers can be updated.
    $07 constant RTC_INIT                       \ [0x07] Initialization mode
    $08 constant RTC_BIN                        \ [0x08 : 2] Binary mode
    $0a constant RTC_BCDU                       \ [0x0a : 3] BCD update (BIN = 10 or 11) In mixed mode when both BCD calendar and binary extended counter are used (BIN = 10 or 11), the calendar second is incremented using the SSR Least Significant Bits.
    $10 constant RTC_RECALPF                    \ [0x10] Recalibration pending Flag The RECALPF status flag is automatically set to 1 when software writes to the RTC_CALR register, indicating that the RTC_CALR register is blocked. When the new calibration settings are taken into account, this bit returns to 0. Refer to Re-calibration on-the-fly.
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
    $00 constant RTC_WUT                        \ [0x00 : 16] Wakeup auto-reload value bits When the wakeup timer is enabled (WUTE set to 1), the WUTF flag is set every (WUT[15:0]+1) ck_wut cycles. The ck_wut period is selected through WUCKSEL[2:0] bits of the RTC_CR register. When WUCKSEL[2] = 1, the wakeup timer becomes 17-bits and WUCKSEL[1] effectively becomes WUT[16] the most-significant bit to be reloaded into the timer. The first assertion of WUTF occurs between WUT and (WUT + 2) ck_wut cycles after WUTE is set. Setting WUT[15:0] to 0x0000 with WUCKSEL[2:0] = 011 (RTCCLK/2) is forbidden.
    $10 constant RTC_WUTOCLR                    \ [0x10 : 16] Wakeup auto-reload output clear value When WUTOCLR[15:0] is different from 0x0000, WUTF is set by hardware when the auto-reload down-counter reaches 0 and is cleared by hardware when the auto-reload downcounter reaches WUTOCLR[15:0]. When WUTOCLR[15:0] = 0x0000, WUTF is set by hardware when the WUT down-counter reaches 0 and is cleared by software.
  [then]


  [ifdef] RTC_RTC_CR_DEF
    \
    \ @brief RTC control register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RTC_WUCKSEL                    \ [0x00 : 3] ck_wut wakeup clock selection 10x: ck_spre (usually 1Hz) clock is selected in BCD mode. In binary or mixed mode, this is the clock selected by BCDU. 11x: ck_spre (usually 1 Hz) clock is selected in BCD mode. In binary or mixed mode, this is the clock selected by BCDU. Furthermore, 2sup16/sup is added to the WUT counter value.
    $03 constant RTC_TSEDGE                     \ [0x03] Timestamp event active edge TSE must be reset when TSEDGE is changed to avoid unwanted TSF setting.
    $04 constant RTC_REFCKON                    \ [0x04] RTC_REFIN reference clock detection enable (50 or 60Hz) Note: BIN must be 0x00 and PREDIV_S must be 0x00FF.
    $05 constant RTC_BYPSHAD                    \ [0x05] Bypass the shadow registers Note: If the frequency of the APB clock is less than seven times the frequency of RTCCLK, BYPSHAD must be set to 1.
    $06 constant RTC_FMT                        \ [0x06] Hour format
    $07 constant RTC_SSRUIE                     \ [0x07] SSR underflow interrupt enable
    $08 constant RTC_ALRAE                      \ [0x08] Alarm A enable
    $09 constant RTC_ALRBE                      \ [0x09] Alarm B enable
    $0a constant RTC_WUTE                       \ [0x0a] Wakeup timer enable Note: When the wakeup timer is disabled, wait for WUTWF = 1 before enabling it again.
    $0b constant RTC_TSE                        \ [0x0b] timestamp enable
    $0c constant RTC_ALRAIE                     \ [0x0c] Alarm A interrupt enable
    $0d constant RTC_ALRBIE                     \ [0x0d] Alarm B interrupt enable
    $0e constant RTC_WUTIE                      \ [0x0e] Wakeup timer interrupt enable
    $0f constant RTC_TSIE                       \ [0x0f] Timestamp interrupt enable
    $10 constant RTC_ADD1H                      \ [0x10] Add 1 hour (summer time change) When this bit is set outside initialization mode, 1 hour is added to the calendar time. This bit is always read as 0.
    $11 constant RTC_SUB1H                      \ [0x11] Subtract 1 hour (winter time change) When this bit is set outside initialization mode, 1 hour is subtracted to the calendar time if the current hour is not 0. This bit is always read as 0. Setting this bit has no effect when current hour is 0.
    $12 constant RTC_BKP                        \ [0x12] Backup This bit can be written by the user to memorize whether the daylight saving time change has been performed or not.
    $13 constant RTC_COSEL                      \ [0x13] Calibration output selection When COE = 1, this bit selects which signal is output on CALIB. These frequencies are valid for RTCCLK at 32.768kHz and prescalers at their default values (PREDIV_A = 127 and PREDIV_S = 255). Refer to Section74.3.18: Calibration clock output.
    $14 constant RTC_POL                        \ [0x14] Output polarity This bit is used to configure the polarity of TAMPALRM output.
    $15 constant RTC_OSEL                       \ [0x15 : 2] Output selection These bits are used to select the flag to be routed to TAMPALRM output.
    $17 constant RTC_COE                        \ [0x17] Calibration output enable This bit enables the CALIB output
    $19 constant RTC_TAMPTS                     \ [0x19] Activate timestamp on tamper detection event TAMPTS is valid even if TSE = 0 in the RTC_CR register. Timestamp flag is set up to 3 ck_apre cycles after the tamper flags.
    $1a constant RTC_TAMPOE                     \ [0x1a] Tamper detection output enable on TAMPALRM
    $1b constant RTC_ALRAFCLR                   \ [0x1b] Alarm A flag automatic clear
    $1c constant RTC_ALRBFCLR                   \ [0x1c] Alarm B flag automatic clear
    $1d constant RTC_TAMPALRM_PU                \ [0x1d] TAMPALRM pull-up enable
    $1e constant RTC_TAMPALRM_TYPE              \ [0x1e] TAMPALRM output type
    $1f constant RTC_OUT2EN                     \ [0x1f] RTC_OUT2 output enable With this bit set, the RTC outputs can be remapped on RTC_OUT2 as follows: OUT2EN=0: RTC output 2 disable If OSEL different 00 or TAMPOE = 1: TAMPALRM is output on RTC_OUT1 If OSEL=00 and TAMPOE=0 and COE=1: CALIB is output on RTC_OUT1 OUT2EN = 1: RTC output 2 enable If (OSEL different 00 or TAMPOE = 1) and COE = 0: TAMPALRM is output on RTC_OUT2 If OSEL=00 and TAMPOE=0 and COE=1: CALIB is output on RTC_OUT2 If (OSEL different 00 or TAMPOE = 1) and COE = 1: CALIB is output on RTC_OUT2 and TAMPALRM is output on RTC_OUT1.
  [then]


  [ifdef] RTC_RTC_PRIVCFGR_DEF
    \
    \ @brief RTC privilege mode control register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_ALRAPRIV                   \ [0x00] Alarm A and SSR underflow privilege protection
    $01 constant RTC_ALRBPRIV                   \ [0x01] Alarm B privilege protection
    $02 constant RTC_WUTPRIV                    \ [0x02] Wakeup timer privilege protection
    $03 constant RTC_TSPRIV                     \ [0x03] Timestamp privilege protection
    $0d constant RTC_CALPRIV                    \ [0x0d] Shift register, Delight saving, calibration and reference clock privilege protection
    $0e constant RTC_INITPRIV                   \ [0x0e] Initialization privilege protection
    $0f constant RTC_PRIV                       \ [0x0f] RTC privilege protection
  [then]


  [ifdef] RTC_RTC_SECCFGR_DEF
    \
    \ @brief RTC secure configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant RTC_ALRASEC                    \ [0x00] Alarm A and SSR underflow protection
    $01 constant RTC_ALRBSEC                    \ [0x01] Alarm B protection
    $02 constant RTC_WUTSEC                     \ [0x02] Wakeup timer protection
    $03 constant RTC_TSSEC                      \ [0x03] Timestamp protection
    $0d constant RTC_CALSEC                     \ [0x0d] Shift register, daylight saving, calibration and reference clock protection
    $0e constant RTC_INITSEC                    \ [0x0e] Initialization protection
    $0f constant RTC_SEC                        \ [0x0f] RTC global protection
  [then]


  [ifdef] RTC_RTC_WPR_DEF
    \
    \ @brief RTC write protection register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant RTC_KEY                        \ [0x00 : 8] Write protection key This byte is written by software. Reading this byte always returns 0x00. Refer to RTC register write protection for a description of how to unlock RTC register write protection.
  [then]


  [ifdef] RTC_RTC_CALR_DEF
    \
    \ @brief RTC calibration register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RTC_CALM                       \ [0x00 : 9] Calibration minus The frequency of the calendar is reduced by masking CALM out of 2sup20/sup RTCCLK pulses (32seconds if the input frequency is 32768Hz). This decreases the frequency of the calendar with a resolution of 0.9537ppm. To increase the frequency of the calendar, this feature should be used in conjunction with CALP. See Section74.3.16: RTC smooth digital calibration on page4278.
    $0c constant RTC_LPCAL                      \ [0x0c] RTC low-power mode
    $0d constant RTC_CALW16                     \ [0x0d] Use a 16-second calibration cycle period When CALW16 is set to 1, the 16-second calibration cycle period is selected. This bit must not be set to 1 if CALW8 = 1. Note: CALM[0] is stuck at 0 when CALW16 = 1. Refer to Section74.3.16: RTC smooth digital calibration.
    $0e constant RTC_CALW8                      \ [0x0e] Use an 8-second calibration cycle period When CALW8 is set to 1, the 8-second calibration cycle period is selected. Note: CALM[1:0] are stuck at 00 when CALW8 = 1. Refer to Section74.3.16: RTC smooth digital calibration.
    $0f constant RTC_CALP                       \ [0x0f] Increase frequency of RTC by 488.5ppm. This feature is intended to be used in conjunction with CALM, which lowers the frequency of the calendar with a fine resolution. if the input frequency is 32768 Hz, the number of RTCCLK pulses added during a 32 second window is calculated as follows: (512 * CALP) CALM. Refer to Section74.3.16: RTC smooth digital calibration.
  [then]


  [ifdef] RTC_RTC_SHIFTR_DEF
    \
    \ @brief RTC shift control register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SUBFS                      \ [0x00 : 15] Subtract a fraction of a second These bits are write only and is always read as zero. Writing to this bit has no effect when a shift operation is pending (when SHPF = 1, in RTC_ICSR). The value which is written to SUBFS is added to the synchronous prescaler counter. Since this counter counts down, this operation effectively subtracts from (delays) the clock by: Delay (seconds) = SUBFS / (PREDIV_S + 1) A fraction of a second can effectively be added to the clock (advancing the clock) when the ADD1S function is used in conjunction with SUBFS, effectively advancing the clock by: Advance (seconds) = (1 - (SUBFS / (PREDIV_S + 1))). In mixed BCD-binary mode (BIN=10 or 11), the SUBFS[14:BCDU+8] must be written with 0. Note: Writing to SUBFS causes RSF to be cleared. Software can then wait until RSF = 1 to be sure that the shadow registers have been updated with the shifted time.
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
    \ @brief RTC timestamp subsecond register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 32] Subsecond value/synchronous binary counter values SS[31:0] is the value of the synchronous prescaler counter when the timestamp event occurred.
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
    \ @brief RTC alarm A subsecond register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 15] Subseconds value This value is compared with the contents of the synchronous prescaler counter to determine if alarm A is to be activated. Only bits 0 up MASKSS-1 are compared. This field is the mirror of SS[14:0] in the RTC_ALRMABINR, and so can also be read or written through RTC_ALRMABINR.
    $18 constant RTC_MASKSS                     \ [0x18 : 6] Mask the most-significant bits starting at this bit ... From 32 to 63: All 32 SS bits are compared and must match to activate alarm. Note: In BCD mode (BIN=00) the overflow bits of the synchronous counter (bits 31:15) are never compared. These bits can be different from 0 only after a shift operation.
    $1f constant RTC_SSCLR                      \ [0x1f] Clear synchronous counter on alarm (Binary mode only) Note: SSCLR must be kept to 0 when BCD or mixed mode is used (BIN = 00, 10 or 11).
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
    \ @brief RTC alarm B subsecond register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 15] Subseconds value This value is compared with the contents of the synchronous prescaler counter to determine if alarm B is to be activated. Only bits 0 up to MASKSS-1 are compared. This field is the mirror of SS[14:0] in the RTC_ALRMBBINR, and so can also be read or written through RTC_ALRMBBINR.
    $18 constant RTC_MASKSS                     \ [0x18 : 6] Mask the most-significant bits starting at this bit ... From 32 to 63: All 32 SS bits are compared and must match to activate alarm. Note: In BCD mode (BIN=00)The overflow bits of the synchronous counter (bits 15) is never compared. This bit can be different from 0 only after a shift operation.
    $1f constant RTC_SSCLR                      \ [0x1f] Clear synchronous counter on alarm (Binary mode only) Note: SSCLR must be kept to 0 when BCD or mixed mode is used (BIN = 00, 10 or 11).
  [then]


  [ifdef] RTC_RTC_SR_DEF
    \
    \ @brief RTC status register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RTC_ALRAF                      \ [0x00] Alarm A flag This flag is set by hardware when the time/date registers (RTC_TR and RTC_DR) match the alarm A register (RTC_ALRMAR).
    $01 constant RTC_ALRBF                      \ [0x01] Alarm B flag This flag is set by hardware when the time/date registers (RTC_TR and RTC_DR) match the alarm B register (RTC_ALRMBR).
    $02 constant RTC_WUTF                       \ [0x02] Wakeup timer flag This flag is set by hardware when the wakeup auto-reload counter reaches 0. If WUTOCLR[15:0] is different from 0x0000, WUTF is cleared by hardware when the wakeup auto-reload counter reaches WUTOCLR value. If WUTOCLR[15:0] is 0x0000, WUTF must be cleared by software. This flag must be cleared by software at least 1.5 RTCCLK periods before WUTF is set to 1 again.
    $03 constant RTC_TSF                        \ [0x03] Timestamp flag This flag is set by hardware when a timestamp event occurs. Note: TSF is not set if TAMPTS=1 and the tamper flag is read during the 3 ck_apre cycles following tamper event. Refer to Timestamp on tamper event for more details.
    $04 constant RTC_TSOVF                      \ [0x04] Timestamp overflow flag This flag is set by hardware when a timestamp event occurs while TSF is already set. It is recommended to check and then clear TSOVF only after clearing the TSF bit. Otherwise, an overflow might not be noticed if a timestamp event occurs immediately before the TSF bit is cleared.
    $06 constant RTC_SSRUF                      \ [0x06] SSR underflow flag This flag is set by hardware when the SSR rolls under 0. SSRUF is not set when SSCLR=1.
  [then]


  [ifdef] RTC_RTC_MISR_DEF
    \
    \ @brief RTC non-secure masked interrupt status register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RTC_ALRAMF                     \ [0x00] Alarm A masked flag This flag is set by hardware when the alarm A non-secure interrupt occurs.
    $01 constant RTC_ALRBMF                     \ [0x01] Alarm B non-secure masked flag This flag is set by hardware when the alarm B non-secure interrupt occurs.
    $02 constant RTC_WUTMF                      \ [0x02] Wakeup timer non-secure masked flag This flag is set by hardware when the wakeup timer non-secure interrupt occurs. This flag must be cleared by software at least 1.5 RTCCLK periods before WUTF is set to 1 again.
    $03 constant RTC_TSMF                       \ [0x03] Timestamp non-secure masked flag This flag is set by hardware when a timestamp non-secure interrupt occurs.
    $04 constant RTC_TSOVMF                     \ [0x04] Timestamp overflow non-secure masked flag This flag is set by hardware when a timestamp interrupt occurs while TSMF is already set. It is recommended to check and then clear TSOVF only after clearing the TSF bit. Otherwise, an overflow might not be noticed if a timestamp event occurs immediately before the TSF bit is cleared.
    $06 constant RTC_SSRUMF                     \ [0x06] SSR underflow non-secure masked flag This flag is set by hardware when the SSR underflow non-secure interrupt occurs.
  [then]


  [ifdef] RTC_RTC_SMISR_DEF
    \
    \ @brief RTC secure masked interrupt status register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RTC_ALRAMF                     \ [0x00] Alarm A interrupt secure masked flag This flag is set by hardware when the alarm A secure interrupt occurs.
    $01 constant RTC_ALRBMF                     \ [0x01] Alarm B interrupt secure masked flag This flag is set by hardware when the alarm B secure interrupt occurs.
    $02 constant RTC_WUTMF                      \ [0x02] Wakeup timer interrupt secure masked flag This flag is set by hardware when the wakeup timer secure interrupt occurs. This flag must be cleared by software at least 1.5 RTCCLK periods before WUTF is set to 1 again.
    $03 constant RTC_TSMF                       \ [0x03] Timestamp interrupt secure masked flag This flag is set by hardware when a timestamp secure interrupt occurs.
    $04 constant RTC_TSOVMF                     \ [0x04] Timestamp overflow interrupt secure masked flag This flag is set by hardware when a timestamp secure interrupt occurs while TSMF is already set. It is recommended to check and then clear TSOVF only after clearing the TSF bit. Otherwise, an overflow might not be noticed if a timestamp event occurs immediately before the TSF bit is cleared.
    $06 constant RTC_SSRUMF                     \ [0x06] SSR underflow secure masked flag This flag is set by hardware when the SSR underflow secure interrupt occurs.
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
    $03 constant RTC_CTSF                       \ [0x03] Clear timestamp flag Writing 1 in this bit clears the TSF bit in the RTC_SR register.
    $04 constant RTC_CTSOVF                     \ [0x04] Clear timestamp overflow flag Writing 1 in this bit clears the TSOVF bit in the RTC_SR register. It is recommended to check and then clear TSOVF only after clearing the TSF bit. Otherwise, an overflow might not be noticed if a timestamp event occurs immediately before the TSF bit is cleared.
    $06 constant RTC_CSSRUF                     \ [0x06] Clear SSR underflow flag Writing '1' in this bit clears the SSRUF in the RTC_SR register.
  [then]


  [ifdef] RTC_RTC_ALRABINR_DEF
    \
    \ @brief RTC alarm A binary mode register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 32] Synchronous counter alarm value in Binary mode This value is compared with the contents of the synchronous counter to determine if Alarm A is to be activated. Only bits 0 up MASKSS-1 are compared. SS[14:0] is the mirror of SS[14:0] in the RTC_ALRMASSRR, and so can also be read or written through RTC_ALRMASSR.
  [then]


  [ifdef] RTC_RTC_ALRBBINR_DEF
    \
    \ @brief RTC alarm B binary mode register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant RTC_SS                         \ [0x00 : 32] Synchronous counter alarm value in Binary mode This value is compared with the contents of the synchronous counter to determine if Alarm Bis to be activated. Only bits 0 up MASKSS-1 are compared. SS[14:0] is the mirror of SS[14:0] in the RTC_ALRMBSSRR, and so can also be read or written through RTC_ALRMBSSR.
  [then]

  \
  \ @brief Real-time clock
  \
  $00 constant RTC_RTC_TR               \ RTC time register
  $04 constant RTC_RTC_DR               \ RTC date register
  $08 constant RTC_RTC_SSR              \ RTC subsecond register
  $0C constant RTC_RTC_ICSR             \ RTC initialization control and status register
  $10 constant RTC_RTC_PRER             \ RTC prescaler register
  $14 constant RTC_RTC_WUTR             \ RTC wakeup timer register
  $18 constant RTC_RTC_CR               \ RTC control register
  $1C constant RTC_RTC_PRIVCFGR         \ RTC privilege mode control register
  $20 constant RTC_RTC_SECCFGR          \ RTC secure configuration register
  $24 constant RTC_RTC_WPR              \ RTC write protection register
  $28 constant RTC_RTC_CALR             \ RTC calibration register
  $2C constant RTC_RTC_SHIFTR           \ RTC shift control register
  $30 constant RTC_RTC_TSTR             \ RTC timestamp time register
  $34 constant RTC_RTC_TSDR             \ RTC timestamp date register
  $38 constant RTC_RTC_TSSSR            \ RTC timestamp subsecond register
  $40 constant RTC_RTC_ALRMAR           \ RTC alarm A register
  $44 constant RTC_RTC_ALRMASSR         \ RTC alarm A subsecond register
  $48 constant RTC_RTC_ALRMBR           \ RTC alarm B register
  $4C constant RTC_RTC_ALRMBSSR         \ RTC alarm B subsecond register
  $50 constant RTC_RTC_SR               \ RTC status register
  $54 constant RTC_RTC_MISR             \ RTC non-secure masked interrupt status register
  $58 constant RTC_RTC_SMISR            \ RTC secure masked interrupt status register
  $5C constant RTC_RTC_SCR              \ RTC status clear register
  $70 constant RTC_RTC_ALRABINR         \ RTC alarm A binary mode register
  $74 constant RTC_RTC_ALRBBINR         \ RTC alarm B binary mode register

: RTC_DEF ; [then]
