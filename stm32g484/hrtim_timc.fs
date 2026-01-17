\
\ @file hrtim_timc.fs
\ @brief High Resolution Timer: TIMC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] HRTIM_TIMC_DEF

  [ifdef] HRTIM_TIMC_TIMCCR_DEF
    \
    \ @brief Timerx Control Register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_CK_PSCx             \ [0x00 : 3] HRTIM Timer x Clock prescaler
    $03 constant HRTIM_TIMC_CONT                \ [0x03] Continuous mode
    $04 constant HRTIM_TIMC_RETRIG              \ [0x04] Re-triggerable mode
    $05 constant HRTIM_TIMC_HALF                \ [0x05] Half mode enable
    $06 constant HRTIM_TIMC_PSHPLL              \ [0x06] Push-Pull mode enable
    $07 constant HRTIM_TIMC_INTLVD              \ [0x07 : 2] Interleaved mode
    $09 constant HRTIM_TIMC_RSYNCU              \ [0x09] Re-Synchronized Update
    $0a constant HRTIM_TIMC_SYNCRSTx            \ [0x0a] Synchronization Resets Timer x
    $0b constant HRTIM_TIMC_SYNCSTRTx           \ [0x0b] Synchronization Starts Timer x
    $0c constant HRTIM_TIMC_DELCMP2             \ [0x0c : 2] Delayed CMP2 mode
    $0e constant HRTIM_TIMC_DELCMP4             \ [0x0e : 2] Delayed CMP4 mode
    $10 constant HRTIM_TIMC_TFU                 \ [0x10] TFU
    $11 constant HRTIM_TIMC_TxREPU              \ [0x11] Timer x Repetition update
    $12 constant HRTIM_TIMC_TxRSTU              \ [0x12] Timerx reset update
    $13 constant HRTIM_TIMC_TAU                 \ [0x13] TAU
    $14 constant HRTIM_TIMC_TBU                 \ [0x14] TBU
    $16 constant HRTIM_TIMC_TDU                 \ [0x16] TDU
    $17 constant HRTIM_TIMC_TEU                 \ [0x17] TEU
    $18 constant HRTIM_TIMC_MSTU                \ [0x18] Master Timer update
    $19 constant HRTIM_TIMC_DACSYNC             \ [0x19 : 2] AC Synchronization
    $1b constant HRTIM_TIMC_PREEN               \ [0x1b] Preload enable
    $1c constant HRTIM_TIMC_UPDGAT              \ [0x1c : 4] Update Gating
  [then]


  [ifdef] HRTIM_TIMC_TIMCISR_DEF
    \
    \ @brief Timerx Interrupt Status Register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_CMP1                \ [0x00] Compare 1 Interrupt Flag
    $01 constant HRTIM_TIMC_CMP2                \ [0x01] Compare 2 Interrupt Flag
    $02 constant HRTIM_TIMC_CMP3                \ [0x02] Compare 3 Interrupt Flag
    $03 constant HRTIM_TIMC_CMP4                \ [0x03] Compare 4 Interrupt Flag
    $04 constant HRTIM_TIMC_REP                 \ [0x04] Repetition Interrupt Flag
    $06 constant HRTIM_TIMC_UPD                 \ [0x06] Update Interrupt Flag
    $07 constant HRTIM_TIMC_CPT1                \ [0x07] Capture1 Interrupt Flag
    $08 constant HRTIM_TIMC_CPT2                \ [0x08] Capture2 Interrupt Flag
    $09 constant HRTIM_TIMC_SETx1               \ [0x09] Output 1 Set Interrupt Flag
    $0a constant HRTIM_TIMC_RSTx1               \ [0x0a] Output 1 Reset Interrupt Flag
    $0b constant HRTIM_TIMC_SETx2               \ [0x0b] Output 2 Set Interrupt Flag
    $0c constant HRTIM_TIMC_RSTx2               \ [0x0c] Output 2 Reset Interrupt Flag
    $0d constant HRTIM_TIMC_RST                 \ [0x0d] Reset Interrupt Flag
    $0e constant HRTIM_TIMC_DLYPRT              \ [0x0e] Delayed Protection Flag
    $10 constant HRTIM_TIMC_CPPSTAT             \ [0x10] Current Push Pull Status
    $11 constant HRTIM_TIMC_IPPSTAT             \ [0x11] Idle Push Pull Status
    $12 constant HRTIM_TIMC_O1STAT              \ [0x12] Output 1 State
    $13 constant HRTIM_TIMC_O2STAT              \ [0x13] Output 2 State
    $14 constant HRTIM_TIMC_O1CPY               \ [0x14] Output 1 Copy
    $15 constant HRTIM_TIMC_O2CPY               \ [0x15] Output 2 Copy
  [then]


  [ifdef] HRTIM_TIMC_TIMCICR_DEF
    \
    \ @brief Timerx Interrupt Clear Register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_CMP1C               \ [0x00] Compare 1 Interrupt flag Clear
    $01 constant HRTIM_TIMC_CMP2C               \ [0x01] Compare 2 Interrupt flag Clear
    $02 constant HRTIM_TIMC_CMP3C               \ [0x02] Compare 3 Interrupt flag Clear
    $03 constant HRTIM_TIMC_CMP4C               \ [0x03] Compare 4 Interrupt flag Clear
    $04 constant HRTIM_TIMC_REPC                \ [0x04] Repetition Interrupt flag Clear
    $06 constant HRTIM_TIMC_UPDC                \ [0x06] Update Interrupt flag Clear
    $07 constant HRTIM_TIMC_CPT1C               \ [0x07] Capture1 Interrupt flag Clear
    $08 constant HRTIM_TIMC_CPT2C               \ [0x08] Capture2 Interrupt flag Clear
    $09 constant HRTIM_TIMC_SET1xC              \ [0x09] Output 1 Set flag Clear
    $0a constant HRTIM_TIMC_RSTx1C              \ [0x0a] Output 1 Reset flag Clear
    $0b constant HRTIM_TIMC_SET2xC              \ [0x0b] Output 2 Set flag Clear
    $0c constant HRTIM_TIMC_RSTx2C              \ [0x0c] Output 2 Reset flag Clear
    $0d constant HRTIM_TIMC_RSTC                \ [0x0d] Reset Interrupt flag Clear
    $0e constant HRTIM_TIMC_DLYPRTC             \ [0x0e] Delayed Protection Flag Clear
  [then]


  [ifdef] HRTIM_TIMC_TIMCDIER_DEF
    \
    \ @brief TIMxDIER
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_CMP1IE              \ [0x00] CMP1IE
    $01 constant HRTIM_TIMC_CMP2IE              \ [0x01] CMP2IE
    $02 constant HRTIM_TIMC_CMP3IE              \ [0x02] CMP3IE
    $03 constant HRTIM_TIMC_CMP4IE              \ [0x03] CMP4IE
    $04 constant HRTIM_TIMC_REPIE               \ [0x04] REPIE
    $06 constant HRTIM_TIMC_UPDIE               \ [0x06] UPDIE
    $07 constant HRTIM_TIMC_CPT1IE              \ [0x07] CPT1IE
    $08 constant HRTIM_TIMC_CPT2IE              \ [0x08] CPT2IE
    $09 constant HRTIM_TIMC_SET1xIE             \ [0x09] SET1xIE
    $0a constant HRTIM_TIMC_RSTx1IE             \ [0x0a] RSTx1IE
    $0b constant HRTIM_TIMC_SETx2IE             \ [0x0b] SETx2IE
    $0c constant HRTIM_TIMC_RSTx2IE             \ [0x0c] RSTx2IE
    $0d constant HRTIM_TIMC_RSTIE               \ [0x0d] RSTIE
    $0e constant HRTIM_TIMC_DLYPRTIE            \ [0x0e] DLYPRTIE
    $10 constant HRTIM_TIMC_CMP1DE              \ [0x10] CMP1DE
    $11 constant HRTIM_TIMC_CMP2DE              \ [0x11] CMP2DE
    $12 constant HRTIM_TIMC_CMP3DE              \ [0x12] CMP3DE
    $13 constant HRTIM_TIMC_CMP4DE              \ [0x13] CMP4DE
    $14 constant HRTIM_TIMC_REPDE               \ [0x14] REPDE
    $16 constant HRTIM_TIMC_UPDDE               \ [0x16] UPDDE
    $17 constant HRTIM_TIMC_CPT1DE              \ [0x17] CPT1DE
    $18 constant HRTIM_TIMC_CPT2DE              \ [0x18] CPT2DE
    $19 constant HRTIM_TIMC_SET1xDE             \ [0x19] SET1xDE
    $1a constant HRTIM_TIMC_RSTx1DE             \ [0x1a] RSTx1DE
    $1b constant HRTIM_TIMC_SETx2DE             \ [0x1b] SETx2DE
    $1c constant HRTIM_TIMC_RSTx2DE             \ [0x1c] RSTx2DE
    $1d constant HRTIM_TIMC_RSTDE               \ [0x1d] RSTDE
    $1e constant HRTIM_TIMC_DLYPRTDE            \ [0x1e] DLYPRTDE
  [then]


  [ifdef] HRTIM_TIMC_CNTCR_DEF
    \
    \ @brief Timerx Counter Register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_CNTx                \ [0x00 : 16] Timerx Counter value
  [then]


  [ifdef] HRTIM_TIMC_PERCR_DEF
    \
    \ @brief Timerx Period Register
    \ Address offset: 0x14
    \ Reset value: 0x0000FFFF
    \
    $00 constant HRTIM_TIMC_PERx                \ [0x00 : 16] Timerx Period value
  [then]


  [ifdef] HRTIM_TIMC_REPCR_DEF
    \
    \ @brief Timerx Repetition Register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_REPx                \ [0x00 : 8] Timerx Repetition counter value
  [then]


  [ifdef] HRTIM_TIMC_CMP1CR_DEF
    \
    \ @brief Timerx Compare 1 Register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_CMP1x               \ [0x00 : 16] Timerx Compare 1 value
  [then]


  [ifdef] HRTIM_TIMC_CMP1CCR_DEF
    \
    \ @brief Timerx Compare 1 Compound Register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_CMP1x               \ [0x00 : 16] Timerx Compare 1 value
    $10 constant HRTIM_TIMC_REPx                \ [0x10 : 8] Timerx Repetition value (aliased from HRTIM_REPx register)
  [then]


  [ifdef] HRTIM_TIMC_CMP2CR_DEF
    \
    \ @brief Timerx Compare 2 Register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_CMP2x               \ [0x00 : 16] Timerx Compare 2 value
  [then]


  [ifdef] HRTIM_TIMC_CMP3CR_DEF
    \
    \ @brief Timerx Compare 3 Register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_CMP3x               \ [0x00 : 16] Timerx Compare 3 value
  [then]


  [ifdef] HRTIM_TIMC_CMP4CR_DEF
    \
    \ @brief Timerx Compare 4 Register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_CMP4x               \ [0x00 : 16] Timerx Compare 4 value
  [then]


  [ifdef] HRTIM_TIMC_CPT1CR_DEF
    \
    \ @brief Timerx Capture 1 Register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_CPT1x               \ [0x00 : 16] Timerx Capture 1 value
    $10 constant HRTIM_TIMC_DIR                 \ [0x10] Timerx Capture 1 Direction status
  [then]


  [ifdef] HRTIM_TIMC_CPT2CR_DEF
    \
    \ @brief Timerx Capture 2 Register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_CPT2x               \ [0x00 : 16] Timerx Capture 2 value
    $10 constant HRTIM_TIMC_DIR                 \ [0x10] Timerx Capture 1 Direction status
  [then]


  [ifdef] HRTIM_TIMC_DTCR_DEF
    \
    \ @brief Timerx Deadtime Register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_DTRx                \ [0x00 : 9] Deadtime Rising value
    $09 constant HRTIM_TIMC_SDTRx               \ [0x09] Sign Deadtime Rising value
    $0a constant HRTIM_TIMC_DTPRSC              \ [0x0a : 3] Deadtime Prescaler
    $0e constant HRTIM_TIMC_DTRSLKx             \ [0x0e] Deadtime Rising Sign Lock
    $0f constant HRTIM_TIMC_DTRLKx              \ [0x0f] Deadtime Rising Lock
    $10 constant HRTIM_TIMC_DTFx                \ [0x10 : 9] Deadtime Falling value
    $19 constant HRTIM_TIMC_SDTFx               \ [0x19] Sign Deadtime Falling value
    $1e constant HRTIM_TIMC_DTFSLKx             \ [0x1e] Deadtime Falling Sign Lock
    $1f constant HRTIM_TIMC_DTFLKx              \ [0x1f] Deadtime Falling Lock
  [then]


  [ifdef] HRTIM_TIMC_SETC1R_DEF
    \
    \ @brief Timerx Output1 Set Register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_SST                 \ [0x00] Software Set trigger
    $01 constant HRTIM_TIMC_RESYNC              \ [0x01] Timer A resynchronizaton
    $02 constant HRTIM_TIMC_PER                 \ [0x02] Timer A Period
    $03 constant HRTIM_TIMC_CMP1                \ [0x03] Timer A compare 1
    $04 constant HRTIM_TIMC_CMP2                \ [0x04] Timer A compare 2
    $05 constant HRTIM_TIMC_CMP3                \ [0x05] Timer A compare 3
    $06 constant HRTIM_TIMC_CMP4                \ [0x06] Timer A compare 4
    $07 constant HRTIM_TIMC_MSTPER              \ [0x07] Master Period
    $08 constant HRTIM_TIMC_MSTCMP1             \ [0x08] Master Compare 1
    $09 constant HRTIM_TIMC_MSTCMP2             \ [0x09] Master Compare 2
    $0a constant HRTIM_TIMC_MSTCMP3             \ [0x0a] Master Compare 3
    $0b constant HRTIM_TIMC_MSTCMP4             \ [0x0b] Master Compare 4
    $0c constant HRTIM_TIMC_TIMEVNT1            \ [0x0c] Timer Event 1
    $0d constant HRTIM_TIMC_TIMEVNT2            \ [0x0d] Timer Event 2
    $0e constant HRTIM_TIMC_TIMEVNT3            \ [0x0e] Timer Event 3
    $0f constant HRTIM_TIMC_TIMEVNT4            \ [0x0f] Timer Event 4
    $10 constant HRTIM_TIMC_TIMEVNT5            \ [0x10] Timer Event 5
    $11 constant HRTIM_TIMC_TIMEVNT6            \ [0x11] Timer Event 6
    $12 constant HRTIM_TIMC_TIMEVNT7            \ [0x12] Timer Event 7
    $13 constant HRTIM_TIMC_TIMEVNT8            \ [0x13] Timer Event 8
    $14 constant HRTIM_TIMC_TIMEVNT9            \ [0x14] Timer Event 9
    $15 constant HRTIM_TIMC_EXTEVNT1            \ [0x15] External Event 1
    $16 constant HRTIM_TIMC_EXTEVNT2            \ [0x16] External Event 2
    $17 constant HRTIM_TIMC_EXTEVNT3            \ [0x17] External Event 3
    $18 constant HRTIM_TIMC_EXTEVNT4            \ [0x18] External Event 4
    $19 constant HRTIM_TIMC_EXTEVNT5            \ [0x19] External Event 5
    $1a constant HRTIM_TIMC_EXTEVNT6            \ [0x1a] External Event 6
    $1b constant HRTIM_TIMC_EXTEVNT7            \ [0x1b] External Event 7
    $1c constant HRTIM_TIMC_EXTEVNT8            \ [0x1c] External Event 8
    $1d constant HRTIM_TIMC_EXTEVNT9            \ [0x1d] External Event 9
    $1e constant HRTIM_TIMC_EXTEVNT10           \ [0x1e] External Event 10
    $1f constant HRTIM_TIMC_UPDATE              \ [0x1f] Registers update (transfer preload to active)
  [then]


  [ifdef] HRTIM_TIMC_RSTC1R_DEF
    \
    \ @brief Timerx Output1 Reset Register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_SRT                 \ [0x00] SRT
    $01 constant HRTIM_TIMC_RESYNC              \ [0x01] RESYNC
    $02 constant HRTIM_TIMC_PER                 \ [0x02] PER
    $03 constant HRTIM_TIMC_CMP1                \ [0x03] CMP1
    $04 constant HRTIM_TIMC_CMP2                \ [0x04] CMP2
    $05 constant HRTIM_TIMC_CMP3                \ [0x05] CMP3
    $06 constant HRTIM_TIMC_CMP4                \ [0x06] CMP4
    $07 constant HRTIM_TIMC_MSTPER              \ [0x07] MSTPER
    $08 constant HRTIM_TIMC_MSTCMP1             \ [0x08] MSTCMP1
    $09 constant HRTIM_TIMC_MSTCMP2             \ [0x09] MSTCMP2
    $0a constant HRTIM_TIMC_MSTCMP3             \ [0x0a] MSTCMP3
    $0b constant HRTIM_TIMC_MSTCMP4             \ [0x0b] MSTCMP4
    $0c constant HRTIM_TIMC_TIMEVNT1            \ [0x0c] TIMEVNT1
    $0d constant HRTIM_TIMC_TIMEVNT2            \ [0x0d] TIMEVNT2
    $0e constant HRTIM_TIMC_TIMEVNT3            \ [0x0e] TIMEVNT3
    $0f constant HRTIM_TIMC_TIMEVNT4            \ [0x0f] TIMEVNT4
    $10 constant HRTIM_TIMC_TIMEVNT5            \ [0x10] TIMEVNT5
    $11 constant HRTIM_TIMC_TIMEVNT6            \ [0x11] TIMEVNT6
    $12 constant HRTIM_TIMC_TIMEVNT7            \ [0x12] TIMEVNT7
    $13 constant HRTIM_TIMC_TIMEVNT8            \ [0x13] TIMEVNT8
    $14 constant HRTIM_TIMC_TIMEVNT9            \ [0x14] TIMEVNT9
    $15 constant HRTIM_TIMC_EXTEVNT1            \ [0x15] EXTEVNT1
    $16 constant HRTIM_TIMC_EXTEVNT2            \ [0x16] EXTEVNT2
    $17 constant HRTIM_TIMC_EXTEVNT3            \ [0x17] EXTEVNT3
    $18 constant HRTIM_TIMC_EXTEVNT4            \ [0x18] EXTEVNT4
    $19 constant HRTIM_TIMC_EXTEVNT5            \ [0x19] EXTEVNT5
    $1a constant HRTIM_TIMC_EXTEVNT6            \ [0x1a] EXTEVNT6
    $1b constant HRTIM_TIMC_EXTEVNT7            \ [0x1b] EXTEVNT7
    $1c constant HRTIM_TIMC_EXTEVNT8            \ [0x1c] EXTEVNT8
    $1d constant HRTIM_TIMC_EXTEVNT9            \ [0x1d] EXTEVNT9
    $1e constant HRTIM_TIMC_EXTEVNT10           \ [0x1e] EXTEVNT10
    $1f constant HRTIM_TIMC_UPDATE              \ [0x1f] UPDATE
  [then]


  [ifdef] HRTIM_TIMC_SETC2R_DEF
    \
    \ @brief Timerx Output2 Set Register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_SST                 \ [0x00] SST
    $01 constant HRTIM_TIMC_RESYNC              \ [0x01] RESYNC
    $02 constant HRTIM_TIMC_PER                 \ [0x02] PER
    $03 constant HRTIM_TIMC_CMP1                \ [0x03] CMP1
    $04 constant HRTIM_TIMC_CMP2                \ [0x04] CMP2
    $05 constant HRTIM_TIMC_CMP3                \ [0x05] CMP3
    $06 constant HRTIM_TIMC_CMP4                \ [0x06] CMP4
    $07 constant HRTIM_TIMC_MSTPER              \ [0x07] MSTPER
    $08 constant HRTIM_TIMC_MSTCMP1             \ [0x08] MSTCMP1
    $09 constant HRTIM_TIMC_MSTCMP2             \ [0x09] MSTCMP2
    $0a constant HRTIM_TIMC_MSTCMP3             \ [0x0a] MSTCMP3
    $0b constant HRTIM_TIMC_MSTCMP4             \ [0x0b] MSTCMP4
    $0c constant HRTIM_TIMC_TIMEVNT1            \ [0x0c] TIMEVNT1
    $0d constant HRTIM_TIMC_TIMEVNT2            \ [0x0d] TIMEVNT2
    $0e constant HRTIM_TIMC_TIMEVNT3            \ [0x0e] TIMEVNT3
    $0f constant HRTIM_TIMC_TIMEVNT4            \ [0x0f] TIMEVNT4
    $10 constant HRTIM_TIMC_TIMEVNT5            \ [0x10] TIMEVNT5
    $11 constant HRTIM_TIMC_TIMEVNT6            \ [0x11] TIMEVNT6
    $12 constant HRTIM_TIMC_TIMEVNT7            \ [0x12] TIMEVNT7
    $13 constant HRTIM_TIMC_TIMEVNT8            \ [0x13] TIMEVNT8
    $14 constant HRTIM_TIMC_TIMEVNT9            \ [0x14] TIMEVNT9
    $15 constant HRTIM_TIMC_EXTEVNT1            \ [0x15] EXTEVNT1
    $16 constant HRTIM_TIMC_EXTEVNT2            \ [0x16] EXTEVNT2
    $17 constant HRTIM_TIMC_EXTEVNT3            \ [0x17] EXTEVNT3
    $18 constant HRTIM_TIMC_EXTEVNT4            \ [0x18] EXTEVNT4
    $19 constant HRTIM_TIMC_EXTEVNT5            \ [0x19] EXTEVNT5
    $1a constant HRTIM_TIMC_EXTEVNT6            \ [0x1a] EXTEVNT6
    $1b constant HRTIM_TIMC_EXTEVNT7            \ [0x1b] EXTEVNT7
    $1c constant HRTIM_TIMC_EXTEVNT8            \ [0x1c] EXTEVNT8
    $1d constant HRTIM_TIMC_EXTEVNT9            \ [0x1d] EXTEVNT9
    $1e constant HRTIM_TIMC_EXTEVNT10           \ [0x1e] EXTEVNT10
    $1f constant HRTIM_TIMC_UPDATE              \ [0x1f] UPDATE
  [then]


  [ifdef] HRTIM_TIMC_RSTC2R_DEF
    \
    \ @brief Timerx Output2 Reset Register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_SRT                 \ [0x00] SRT
    $01 constant HRTIM_TIMC_RESYNC              \ [0x01] RESYNC
    $02 constant HRTIM_TIMC_PER                 \ [0x02] PER
    $03 constant HRTIM_TIMC_CMP1                \ [0x03] CMP1
    $04 constant HRTIM_TIMC_CMP2                \ [0x04] CMP2
    $05 constant HRTIM_TIMC_CMP3                \ [0x05] CMP3
    $06 constant HRTIM_TIMC_CMP4                \ [0x06] CMP4
    $07 constant HRTIM_TIMC_MSTPER              \ [0x07] MSTPER
    $08 constant HRTIM_TIMC_MSTCMP1             \ [0x08] MSTCMP1
    $09 constant HRTIM_TIMC_MSTCMP2             \ [0x09] MSTCMP2
    $0a constant HRTIM_TIMC_MSTCMP3             \ [0x0a] MSTCMP3
    $0b constant HRTIM_TIMC_MSTCMP4             \ [0x0b] MSTCMP4
    $0c constant HRTIM_TIMC_TIMEVNT1            \ [0x0c] TIMEVNT1
    $0d constant HRTIM_TIMC_TIMEVNT2            \ [0x0d] TIMEVNT2
    $0e constant HRTIM_TIMC_TIMEVNT3            \ [0x0e] TIMEVNT3
    $0f constant HRTIM_TIMC_TIMEVNT4            \ [0x0f] TIMEVNT4
    $10 constant HRTIM_TIMC_TIMEVNT5            \ [0x10] TIMEVNT5
    $11 constant HRTIM_TIMC_TIMEVNT6            \ [0x11] TIMEVNT6
    $12 constant HRTIM_TIMC_TIMEVNT7            \ [0x12] TIMEVNT7
    $13 constant HRTIM_TIMC_TIMEVNT8            \ [0x13] TIMEVNT8
    $14 constant HRTIM_TIMC_TIMEVNT9            \ [0x14] TIMEVNT9
    $15 constant HRTIM_TIMC_EXTEVNT1            \ [0x15] EXTEVNT1
    $16 constant HRTIM_TIMC_EXTEVNT2            \ [0x16] EXTEVNT2
    $17 constant HRTIM_TIMC_EXTEVNT3            \ [0x17] EXTEVNT3
    $18 constant HRTIM_TIMC_EXTEVNT4            \ [0x18] EXTEVNT4
    $19 constant HRTIM_TIMC_EXTEVNT5            \ [0x19] EXTEVNT5
    $1a constant HRTIM_TIMC_EXTEVNT6            \ [0x1a] EXTEVNT6
    $1b constant HRTIM_TIMC_EXTEVNT7            \ [0x1b] EXTEVNT7
    $1c constant HRTIM_TIMC_EXTEVNT8            \ [0x1c] EXTEVNT8
    $1d constant HRTIM_TIMC_EXTEVNT9            \ [0x1d] EXTEVNT9
    $1e constant HRTIM_TIMC_EXTEVNT10           \ [0x1e] EXTEVNT10
    $1f constant HRTIM_TIMC_UPDATE              \ [0x1f] UPDATE
  [then]


  [ifdef] HRTIM_TIMC_EEFCR1_DEF
    \
    \ @brief Timerx External Event Filtering Register 1
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_EE1LTCH             \ [0x00] External Event 1 latch
    $01 constant HRTIM_TIMC_EE1FLTR             \ [0x01 : 4] External Event 1 filter
    $06 constant HRTIM_TIMC_EE2LTCH             \ [0x06] External Event 2 latch
    $07 constant HRTIM_TIMC_EE2FLTR             \ [0x07 : 4] External Event 2 filter
    $0c constant HRTIM_TIMC_EE3LTCH             \ [0x0c] External Event 3 latch
    $0d constant HRTIM_TIMC_EE3FLTR             \ [0x0d : 4] External Event 3 filter
    $12 constant HRTIM_TIMC_EE4LTCH             \ [0x12] External Event 4 latch
    $13 constant HRTIM_TIMC_EE4FLTR             \ [0x13 : 4] External Event 4 filter
    $18 constant HRTIM_TIMC_EE5LTCH             \ [0x18] External Event 5 latch
    $19 constant HRTIM_TIMC_EE5FLTR             \ [0x19 : 4] External Event 5 filter
  [then]


  [ifdef] HRTIM_TIMC_EEFCR2_DEF
    \
    \ @brief Timerx External Event Filtering Register 2
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_EE6LTCH             \ [0x00] External Event 6 latch
    $01 constant HRTIM_TIMC_EE6FLTR             \ [0x01 : 4] External Event 6 filter
    $06 constant HRTIM_TIMC_EE7LTCH             \ [0x06] External Event 7 latch
    $07 constant HRTIM_TIMC_EE7FLTR             \ [0x07 : 4] External Event 7 filter
    $0c constant HRTIM_TIMC_EE8LTCH             \ [0x0c] External Event 8 latch
    $0d constant HRTIM_TIMC_EE8FLTR             \ [0x0d : 4] External Event 8 filter
    $12 constant HRTIM_TIMC_EE9LTCH             \ [0x12] External Event 9 latch
    $13 constant HRTIM_TIMC_EE9FLTR             \ [0x13 : 4] External Event 9 filter
    $18 constant HRTIM_TIMC_EE10LTCH            \ [0x18] External Event 10 latch
    $19 constant HRTIM_TIMC_EE10FLTR            \ [0x19 : 4] External Event 10 filter
  [then]


  [ifdef] HRTIM_TIMC_RSTCR_DEF
    \
    \ @brief TimerA Reset Register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_TIMFCMP1            \ [0x00] Timer A Update reset
    $01 constant HRTIM_TIMC_UPDT                \ [0x01] Timer A Update reset
    $02 constant HRTIM_TIMC_CMP2                \ [0x02] Timer A compare 2 reset
    $03 constant HRTIM_TIMC_CMP4                \ [0x03] Timer A compare 4 reset
    $04 constant HRTIM_TIMC_MSTPER              \ [0x04] Master timer Period
    $05 constant HRTIM_TIMC_MSTCMP1             \ [0x05] Master compare 1
    $06 constant HRTIM_TIMC_MSTCMP2             \ [0x06] Master compare 2
    $07 constant HRTIM_TIMC_MSTCMP3             \ [0x07] Master compare 3
    $08 constant HRTIM_TIMC_MSTCMP4             \ [0x08] Master compare 4
    $09 constant HRTIM_TIMC_EXTEVNT1            \ [0x09] External Event 1
    $0a constant HRTIM_TIMC_EXTEVNT2            \ [0x0a] External Event 2
    $0b constant HRTIM_TIMC_EXTEVNT3            \ [0x0b] External Event 3
    $0c constant HRTIM_TIMC_EXTEVNT4            \ [0x0c] External Event 4
    $0d constant HRTIM_TIMC_EXTEVNT5            \ [0x0d] External Event 5
    $0e constant HRTIM_TIMC_EXTEVNT6            \ [0x0e] External Event 6
    $0f constant HRTIM_TIMC_EXTEVNT7            \ [0x0f] External Event 7
    $10 constant HRTIM_TIMC_EXTEVNT8            \ [0x10] External Event 8
    $11 constant HRTIM_TIMC_EXTEVNT9            \ [0x11] External Event 9
    $12 constant HRTIM_TIMC_EXTEVNT10           \ [0x12] External Event 10
    $13 constant HRTIM_TIMC_TIMACMP1            \ [0x13] Timer A Compare 1
    $14 constant HRTIM_TIMC_TIMACMP2            \ [0x14] Timer A Compare 2
    $15 constant HRTIM_TIMC_TIMACMP4            \ [0x15] Timer A Compare 4
    $16 constant HRTIM_TIMC_TIMBCMP1            \ [0x16] Timer B Compare 1
    $17 constant HRTIM_TIMC_TIMBCMP2            \ [0x17] Timer B Compare 2
    $18 constant HRTIM_TIMC_TIMBCMP4            \ [0x18] Timer B Compare 4
    $19 constant HRTIM_TIMC_TIMDCMP1            \ [0x19] Timer D Compare 1
    $1a constant HRTIM_TIMC_TIMDCMP2            \ [0x1a] Timer D Compare 2
    $1b constant HRTIM_TIMC_TIMDCMP4            \ [0x1b] Timer D Compare 4
    $1c constant HRTIM_TIMC_TIMECMP1            \ [0x1c] Timer E Compare 1
    $1d constant HRTIM_TIMC_TIMECMP2            \ [0x1d] Timer E Compare 2
    $1e constant HRTIM_TIMC_TIMECMP4            \ [0x1e] Timer E Compare 4
    $1f constant HRTIM_TIMC_TIMFCPM2            \ [0x1f] Timer F Compare 2
  [then]


  [ifdef] HRTIM_TIMC_CHPCR_DEF
    \
    \ @brief Timerx Chopper Register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_CHPFRQ              \ [0x00 : 4] Timerx carrier frequency value
    $04 constant HRTIM_TIMC_CHPDTY              \ [0x04 : 3] Timerx chopper duty cycle value
    $07 constant HRTIM_TIMC_STRTPW              \ [0x07 : 4] STRTPW
  [then]


  [ifdef] HRTIM_TIMC_CPT1CCR_DEF
    \
    \ @brief Timerx Capture 2 Control Register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_SWCPT               \ [0x00] Software Capture
    $01 constant HRTIM_TIMC_UDPCPT              \ [0x01] Update Capture
    $02 constant HRTIM_TIMC_EXEV1CPT            \ [0x02] External Event 1 Capture
    $03 constant HRTIM_TIMC_EXEV2CPT            \ [0x03] External Event 2 Capture
    $04 constant HRTIM_TIMC_EXEV3CPT            \ [0x04] External Event 3 Capture
    $05 constant HRTIM_TIMC_EXEV4CPT            \ [0x05] External Event 4 Capture
    $06 constant HRTIM_TIMC_EXEV5CPT            \ [0x06] External Event 5 Capture
    $07 constant HRTIM_TIMC_EXEV6CPT            \ [0x07] External Event 6 Capture
    $08 constant HRTIM_TIMC_EXEV7CPT            \ [0x08] External Event 7 Capture
    $09 constant HRTIM_TIMC_EXEV8CPT            \ [0x09] External Event 8 Capture
    $0a constant HRTIM_TIMC_EXEV9CPT            \ [0x0a] External Event 9 Capture
    $0b constant HRTIM_TIMC_EXEV10CPT           \ [0x0b] External Event 10 Capture
    $0c constant HRTIM_TIMC_TA1SET              \ [0x0c] Timer A output 1 Set
    $0d constant HRTIM_TIMC_TA1RST              \ [0x0d] Timer A output 1 Reset
    $0e constant HRTIM_TIMC_TACMP1              \ [0x0e] Timer A Compare 1
    $0f constant HRTIM_TIMC_TACMP2              \ [0x0f] Timer A Compare 2
    $10 constant HRTIM_TIMC_TB1SET              \ [0x10] Timer B output 1 Set
    $11 constant HRTIM_TIMC_TB1RST              \ [0x11] Timer B output 1 Reset
    $12 constant HRTIM_TIMC_TBCMP1              \ [0x12] Timer B Compare 1
    $13 constant HRTIM_TIMC_TBCMP2              \ [0x13] Timer B Compare 2
    $14 constant HRTIM_TIMC_TF1SET              \ [0x14] TF1SET
    $15 constant HRTIM_TIMC_TF1RST              \ [0x15] TF1RST
    $16 constant HRTIM_TIMC_TFCMP1              \ [0x16] TFCMP1
    $17 constant HRTIM_TIMC_TFCMP2              \ [0x17] TFCMP2
    $18 constant HRTIM_TIMC_TD1SET              \ [0x18] Timer D output 1 Set
    $19 constant HRTIM_TIMC_TD1RST              \ [0x19] Timer D output 1 Reset
    $1a constant HRTIM_TIMC_TDCMP1              \ [0x1a] Timer D Compare 1
    $1b constant HRTIM_TIMC_TDCMP2              \ [0x1b] Timer D Compare 2
    $1c constant HRTIM_TIMC_TE1SET              \ [0x1c] Timer E output 1 Set
    $1d constant HRTIM_TIMC_TE1RST              \ [0x1d] Timer E output 1 Reset
    $1e constant HRTIM_TIMC_TECMP1              \ [0x1e] Timer E Compare 1
    $1f constant HRTIM_TIMC_TECMP2              \ [0x1f] Timer E Compare 2
  [then]


  [ifdef] HRTIM_TIMC_CPT2CCR_DEF
    \
    \ @brief CPT2xCR
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_SWCPT               \ [0x00] Software Capture
    $01 constant HRTIM_TIMC_UDPCPT              \ [0x01] Update Capture
    $02 constant HRTIM_TIMC_EXEV1CPT            \ [0x02] External Event 1 Capture
    $03 constant HRTIM_TIMC_EXEV2CPT            \ [0x03] External Event 2 Capture
    $04 constant HRTIM_TIMC_EXEV3CPT            \ [0x04] External Event 3 Capture
    $05 constant HRTIM_TIMC_EXEV4CPT            \ [0x05] External Event 4 Capture
    $06 constant HRTIM_TIMC_EXEV5CPT            \ [0x06] External Event 5 Capture
    $07 constant HRTIM_TIMC_EXEV6CPT            \ [0x07] External Event 6 Capture
    $08 constant HRTIM_TIMC_EXEV7CPT            \ [0x08] External Event 7 Capture
    $09 constant HRTIM_TIMC_EXEV8CPT            \ [0x09] External Event 8 Capture
    $0a constant HRTIM_TIMC_EXEV9CPT            \ [0x0a] External Event 9 Capture
    $0b constant HRTIM_TIMC_EXEV10CPT           \ [0x0b] External Event 10 Capture
    $0c constant HRTIM_TIMC_TA1SET              \ [0x0c] Timer A output 1 Set
    $0d constant HRTIM_TIMC_TA1RST              \ [0x0d] Timer A output 1 Reset
    $0e constant HRTIM_TIMC_TACMP1              \ [0x0e] Timer A Compare 1
    $0f constant HRTIM_TIMC_TACMP2              \ [0x0f] Timer A Compare 2
    $10 constant HRTIM_TIMC_TB1SET              \ [0x10] Timer B output 1 Set
    $11 constant HRTIM_TIMC_TB1RST              \ [0x11] Timer B output 1 Reset
    $12 constant HRTIM_TIMC_TBCMP1              \ [0x12] Timer B Compare 1
    $13 constant HRTIM_TIMC_TBCMP2              \ [0x13] Timer B Compare 2
    $14 constant HRTIM_TIMC_TF1SET              \ [0x14] TF1SET
    $15 constant HRTIM_TIMC_TF1RST              \ [0x15] TF1RST
    $16 constant HRTIM_TIMC_TF1CMP1             \ [0x16] TF1CMP1
    $17 constant HRTIM_TIMC_TF1CMP2             \ [0x17] TF1CMP2
    $18 constant HRTIM_TIMC_TD1SET              \ [0x18] Timer D output 1 Set
    $19 constant HRTIM_TIMC_TD1RST              \ [0x19] Timer D output 1 Reset
    $1a constant HRTIM_TIMC_TDCMP1              \ [0x1a] Timer D Compare 1
    $1b constant HRTIM_TIMC_TDCMP2              \ [0x1b] Timer D Compare 2
    $1c constant HRTIM_TIMC_TE1SET              \ [0x1c] Timer E output 1 Set
    $1d constant HRTIM_TIMC_TE1RST              \ [0x1d] Timer E output 1 Reset
    $1e constant HRTIM_TIMC_TECMP1              \ [0x1e] Timer E Compare 1
    $1f constant HRTIM_TIMC_TECMP2              \ [0x1f] Timer E Compare 2
  [then]


  [ifdef] HRTIM_TIMC_OUTCR_DEF
    \
    \ @brief Timerx Output Register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $01 constant HRTIM_TIMC_POL1                \ [0x01] Output 1 polarity
    $02 constant HRTIM_TIMC_IDLEM1              \ [0x02] Output 1 Idle mode
    $03 constant HRTIM_TIMC_IDLES1              \ [0x03] Output 1 Idle State
    $04 constant HRTIM_TIMC_FAULT1              \ [0x04 : 2] Output 1 Fault state
    $06 constant HRTIM_TIMC_CHP1                \ [0x06] Output 1 Chopper enable
    $07 constant HRTIM_TIMC_DIDL1               \ [0x07] Output 1 Deadtime upon burst mode Idle entry
    $08 constant HRTIM_TIMC_DTEN                \ [0x08] Deadtime enable
    $09 constant HRTIM_TIMC_DLYPRTEN            \ [0x09] Delayed Protection Enable
    $0a constant HRTIM_TIMC_DLYPRT              \ [0x0a : 3] Delayed Protection
    $0e constant HRTIM_TIMC_BIAR                \ [0x0e] Balanced Idle Automatic Resume
    $11 constant HRTIM_TIMC_POL2                \ [0x11] Output 2 polarity
    $12 constant HRTIM_TIMC_IDLEM2              \ [0x12] Output 2 Idle mode
    $13 constant HRTIM_TIMC_IDLES2              \ [0x13] Output 2 Idle State
    $14 constant HRTIM_TIMC_FAULT2              \ [0x14 : 2] Output 2 Fault state
    $16 constant HRTIM_TIMC_CHP2                \ [0x16] Output 2 Chopper enable
    $17 constant HRTIM_TIMC_DIDL2               \ [0x17] Output 2 Deadtime upon burst mode Idle entry
  [then]


  [ifdef] HRTIM_TIMC_FLTCR_DEF
    \
    \ @brief Timerx Fault Register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_FLT1EN              \ [0x00] Fault 1 enable
    $01 constant HRTIM_TIMC_FLT2EN              \ [0x01] Fault 2 enable
    $02 constant HRTIM_TIMC_FLT3EN              \ [0x02] Fault 3 enable
    $03 constant HRTIM_TIMC_FLT4EN              \ [0x03] Fault 4 enable
    $04 constant HRTIM_TIMC_FLT5EN              \ [0x04] Fault 5 enable
    $05 constant HRTIM_TIMC_FLT6EN              \ [0x05] Fault 6 enable
    $1f constant HRTIM_TIMC_FLTLCK              \ [0x1f] Fault sources Lock
  [then]


  [ifdef] HRTIM_TIMC_TIMCCR2_DEF
    \
    \ @brief HRTIM Timerx Control Register 2
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_DCDE                \ [0x00] Dual Channel DAC trigger enable
    $01 constant HRTIM_TIMC_DCDS                \ [0x01] Dual Channel DAC Step trigger
    $02 constant HRTIM_TIMC_DCDR                \ [0x02] Dual Channel DAC Reset trigger
    $04 constant HRTIM_TIMC_UDM                 \ [0x04] Up-Down Mode
    $06 constant HRTIM_TIMC_ROM                 \ [0x06 : 2] Roll-Over Mode
    $08 constant HRTIM_TIMC_OUTROM              \ [0x08 : 2] Output Roll-Over Mode
    $0a constant HRTIM_TIMC_ADROM               \ [0x0a : 2] ADC Roll-Over Mode
    $0c constant HRTIM_TIMC_BMROM               \ [0x0c : 2] Burst Mode Roll-Over Mode
    $0e constant HRTIM_TIMC_FEROM               \ [0x0e : 2] Fault and Event Roll-Over Mode
    $10 constant HRTIM_TIMC_GTCMP1              \ [0x10] Greater than Compare 1 PWM mode
    $11 constant HRTIM_TIMC_GTCMP3              \ [0x11] Greater than Compare 3 PWM mode
    $14 constant HRTIM_TIMC_TRGHLF              \ [0x14] Triggered-half mode
  [then]


  [ifdef] HRTIM_TIMC_CEEFR3_DEF
    \
    \ @brief HRTIM Timerx External Event Filtering Register 3
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant HRTIM_TIMC_EEVACE              \ [0x00] External Event A Counter Enable
    $01 constant HRTIM_TIMC_EEVACRES            \ [0x01] External Event A Counter Reset
    $02 constant HRTIM_TIMC_EEVARSTM            \ [0x02] External Event A Reset Mode
    $04 constant HRTIM_TIMC_EEVASEL             \ [0x04 : 4] External Event A Selection
    $08 constant HRTIM_TIMC_EEVACNT             \ [0x08 : 6] External Event A counter
  [then]

  \
  \ @brief High Resolution Timer: TIMC
  \
  $00 constant HRTIM_TIMC_TIMCCR        \ Timerx Control Register
  $04 constant HRTIM_TIMC_TIMCISR       \ Timerx Interrupt Status Register
  $08 constant HRTIM_TIMC_TIMCICR       \ Timerx Interrupt Clear Register
  $0C constant HRTIM_TIMC_TIMCDIER      \ TIMxDIER
  $10 constant HRTIM_TIMC_CNTCR         \ Timerx Counter Register
  $14 constant HRTIM_TIMC_PERCR         \ Timerx Period Register
  $18 constant HRTIM_TIMC_REPCR         \ Timerx Repetition Register
  $1C constant HRTIM_TIMC_CMP1CR        \ Timerx Compare 1 Register
  $20 constant HRTIM_TIMC_CMP1CCR       \ Timerx Compare 1 Compound Register
  $24 constant HRTIM_TIMC_CMP2CR        \ Timerx Compare 2 Register
  $28 constant HRTIM_TIMC_CMP3CR        \ Timerx Compare 3 Register
  $2C constant HRTIM_TIMC_CMP4CR        \ Timerx Compare 4 Register
  $30 constant HRTIM_TIMC_CPT1CR        \ Timerx Capture 1 Register
  $34 constant HRTIM_TIMC_CPT2CR        \ Timerx Capture 2 Register
  $38 constant HRTIM_TIMC_DTCR          \ Timerx Deadtime Register
  $3C constant HRTIM_TIMC_SETC1R        \ Timerx Output1 Set Register
  $40 constant HRTIM_TIMC_RSTC1R        \ Timerx Output1 Reset Register
  $44 constant HRTIM_TIMC_SETC2R        \ Timerx Output2 Set Register
  $48 constant HRTIM_TIMC_RSTC2R        \ Timerx Output2 Reset Register
  $4C constant HRTIM_TIMC_EEFCR1        \ Timerx External Event Filtering Register 1
  $50 constant HRTIM_TIMC_EEFCR2        \ Timerx External Event Filtering Register 2
  $54 constant HRTIM_TIMC_RSTCR         \ TimerA Reset Register
  $58 constant HRTIM_TIMC_CHPCR         \ Timerx Chopper Register
  $5C constant HRTIM_TIMC_CPT1CCR       \ Timerx Capture 2 Control Register
  $60 constant HRTIM_TIMC_CPT2CCR       \ CPT2xCR
  $64 constant HRTIM_TIMC_OUTCR         \ Timerx Output Register
  $68 constant HRTIM_TIMC_FLTCR         \ Timerx Fault Register
  $6C constant HRTIM_TIMC_TIMCCR2       \ HRTIM Timerx Control Register 2
  $70 constant HRTIM_TIMC_CEEFR3        \ HRTIM Timerx External Event Filtering Register 3

: HRTIM_TIMC_DEF ; [then]
