\
\ @file hrtim_timc.fs
\ @brief High Resolution Timer: TIMC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Timerx Control Register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000007 constant HRTIM_TIMC_TIMCCR_CK_PSCX                        \ HRTIM Timer x Clock prescaler
$00000008 constant HRTIM_TIMC_TIMCCR_CONT                           \ Continuous mode
$00000010 constant HRTIM_TIMC_TIMCCR_RETRIG                         \ Re-triggerable mode
$00000020 constant HRTIM_TIMC_TIMCCR_HALF                           \ Half mode enable
$00000040 constant HRTIM_TIMC_TIMCCR_PSHPLL                         \ Push-Pull mode enable
$00000180 constant HRTIM_TIMC_TIMCCR_INTLVD                         \ Interleaved mode
$00000200 constant HRTIM_TIMC_TIMCCR_RSYNCU                         \ Re-Synchronized Update
$00000400 constant HRTIM_TIMC_TIMCCR_SYNCRSTX                       \ Synchronization Resets Timer x
$00000800 constant HRTIM_TIMC_TIMCCR_SYNCSTRTX                      \ Synchronization Starts Timer x
$00003000 constant HRTIM_TIMC_TIMCCR_DELCMP2                        \ Delayed CMP2 mode
$0000c000 constant HRTIM_TIMC_TIMCCR_DELCMP4                        \ Delayed CMP4 mode
$00010000 constant HRTIM_TIMC_TIMCCR_TFU                            \ TFU
$00020000 constant HRTIM_TIMC_TIMCCR_TXREPU                         \ Timer x Repetition update
$00040000 constant HRTIM_TIMC_TIMCCR_TXRSTU                         \ Timerx reset update
$00080000 constant HRTIM_TIMC_TIMCCR_TAU                            \ TAU
$00100000 constant HRTIM_TIMC_TIMCCR_TBU                            \ TBU
$00400000 constant HRTIM_TIMC_TIMCCR_TDU                            \ TDU
$00800000 constant HRTIM_TIMC_TIMCCR_TEU                            \ TEU
$01000000 constant HRTIM_TIMC_TIMCCR_MSTU                           \ Master Timer update
$06000000 constant HRTIM_TIMC_TIMCCR_DACSYNC                        \ AC Synchronization
$08000000 constant HRTIM_TIMC_TIMCCR_PREEN                          \ Preload enable
$f0000000 constant HRTIM_TIMC_TIMCCR_UPDGAT                         \ Update Gating


\
\ @brief Timerx Interrupt Status Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMC_TIMCISR_CMP1                          \ Compare 1 Interrupt Flag
$00000002 constant HRTIM_TIMC_TIMCISR_CMP2                          \ Compare 2 Interrupt Flag
$00000004 constant HRTIM_TIMC_TIMCISR_CMP3                          \ Compare 3 Interrupt Flag
$00000008 constant HRTIM_TIMC_TIMCISR_CMP4                          \ Compare 4 Interrupt Flag
$00000010 constant HRTIM_TIMC_TIMCISR_REP                           \ Repetition Interrupt Flag
$00000040 constant HRTIM_TIMC_TIMCISR_UPD                           \ Update Interrupt Flag
$00000080 constant HRTIM_TIMC_TIMCISR_CPT1                          \ Capture1 Interrupt Flag
$00000100 constant HRTIM_TIMC_TIMCISR_CPT2                          \ Capture2 Interrupt Flag
$00000200 constant HRTIM_TIMC_TIMCISR_SETX1                         \ Output 1 Set Interrupt Flag
$00000400 constant HRTIM_TIMC_TIMCISR_RSTX1                         \ Output 1 Reset Interrupt Flag
$00000800 constant HRTIM_TIMC_TIMCISR_SETX2                         \ Output 2 Set Interrupt Flag
$00001000 constant HRTIM_TIMC_TIMCISR_RSTX2                         \ Output 2 Reset Interrupt Flag
$00002000 constant HRTIM_TIMC_TIMCISR_RST                           \ Reset Interrupt Flag
$00004000 constant HRTIM_TIMC_TIMCISR_DLYPRT                        \ Delayed Protection Flag
$00010000 constant HRTIM_TIMC_TIMCISR_CPPSTAT                       \ Current Push Pull Status
$00020000 constant HRTIM_TIMC_TIMCISR_IPPSTAT                       \ Idle Push Pull Status
$00040000 constant HRTIM_TIMC_TIMCISR_O1STAT                        \ Output 1 State
$00080000 constant HRTIM_TIMC_TIMCISR_O2STAT                        \ Output 2 State
$00100000 constant HRTIM_TIMC_TIMCISR_O1CPY                         \ Output 1 Copy
$00200000 constant HRTIM_TIMC_TIMCISR_O2CPY                         \ Output 2 Copy


\
\ @brief Timerx Interrupt Clear Register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMC_TIMCICR_CMP1C                         \ Compare 1 Interrupt flag Clear
$00000002 constant HRTIM_TIMC_TIMCICR_CMP2C                         \ Compare 2 Interrupt flag Clear
$00000004 constant HRTIM_TIMC_TIMCICR_CMP3C                         \ Compare 3 Interrupt flag Clear
$00000008 constant HRTIM_TIMC_TIMCICR_CMP4C                         \ Compare 4 Interrupt flag Clear
$00000010 constant HRTIM_TIMC_TIMCICR_REPC                          \ Repetition Interrupt flag Clear
$00000040 constant HRTIM_TIMC_TIMCICR_UPDC                          \ Update Interrupt flag Clear
$00000080 constant HRTIM_TIMC_TIMCICR_CPT1C                         \ Capture1 Interrupt flag Clear
$00000100 constant HRTIM_TIMC_TIMCICR_CPT2C                         \ Capture2 Interrupt flag Clear
$00000200 constant HRTIM_TIMC_TIMCICR_SET1XC                        \ Output 1 Set flag Clear
$00000400 constant HRTIM_TIMC_TIMCICR_RSTX1C                        \ Output 1 Reset flag Clear
$00000800 constant HRTIM_TIMC_TIMCICR_SET2XC                        \ Output 2 Set flag Clear
$00001000 constant HRTIM_TIMC_TIMCICR_RSTX2C                        \ Output 2 Reset flag Clear
$00002000 constant HRTIM_TIMC_TIMCICR_RSTC                          \ Reset Interrupt flag Clear
$00004000 constant HRTIM_TIMC_TIMCICR_DLYPRTC                       \ Delayed Protection Flag Clear


\
\ @brief TIMxDIER
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMC_TIMCDIER_CMP1IE                       \ CMP1IE
$00000002 constant HRTIM_TIMC_TIMCDIER_CMP2IE                       \ CMP2IE
$00000004 constant HRTIM_TIMC_TIMCDIER_CMP3IE                       \ CMP3IE
$00000008 constant HRTIM_TIMC_TIMCDIER_CMP4IE                       \ CMP4IE
$00000010 constant HRTIM_TIMC_TIMCDIER_REPIE                        \ REPIE
$00000040 constant HRTIM_TIMC_TIMCDIER_UPDIE                        \ UPDIE
$00000080 constant HRTIM_TIMC_TIMCDIER_CPT1IE                       \ CPT1IE
$00000100 constant HRTIM_TIMC_TIMCDIER_CPT2IE                       \ CPT2IE
$00000200 constant HRTIM_TIMC_TIMCDIER_SET1XIE                      \ SET1xIE
$00000400 constant HRTIM_TIMC_TIMCDIER_RSTX1IE                      \ RSTx1IE
$00000800 constant HRTIM_TIMC_TIMCDIER_SETX2IE                      \ SETx2IE
$00001000 constant HRTIM_TIMC_TIMCDIER_RSTX2IE                      \ RSTx2IE
$00002000 constant HRTIM_TIMC_TIMCDIER_RSTIE                        \ RSTIE
$00004000 constant HRTIM_TIMC_TIMCDIER_DLYPRTIE                     \ DLYPRTIE
$00010000 constant HRTIM_TIMC_TIMCDIER_CMP1DE                       \ CMP1DE
$00020000 constant HRTIM_TIMC_TIMCDIER_CMP2DE                       \ CMP2DE
$00040000 constant HRTIM_TIMC_TIMCDIER_CMP3DE                       \ CMP3DE
$00080000 constant HRTIM_TIMC_TIMCDIER_CMP4DE                       \ CMP4DE
$00100000 constant HRTIM_TIMC_TIMCDIER_REPDE                        \ REPDE
$00400000 constant HRTIM_TIMC_TIMCDIER_UPDDE                        \ UPDDE
$00800000 constant HRTIM_TIMC_TIMCDIER_CPT1DE                       \ CPT1DE
$01000000 constant HRTIM_TIMC_TIMCDIER_CPT2DE                       \ CPT2DE
$02000000 constant HRTIM_TIMC_TIMCDIER_SET1XDE                      \ SET1xDE
$04000000 constant HRTIM_TIMC_TIMCDIER_RSTX1DE                      \ RSTx1DE
$08000000 constant HRTIM_TIMC_TIMCDIER_SETX2DE                      \ SETx2DE
$10000000 constant HRTIM_TIMC_TIMCDIER_RSTX2DE                      \ RSTx2DE
$20000000 constant HRTIM_TIMC_TIMCDIER_RSTDE                        \ RSTDE
$40000000 constant HRTIM_TIMC_TIMCDIER_DLYPRTDE                     \ DLYPRTDE


\
\ @brief Timerx Counter Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMC_CNTCR_CNTX                            \ Timerx Counter value


\
\ @brief Timerx Period Register
\ Address offset: 0x14
\ Reset value: 0x0000FFFF
\

$0000ffff constant HRTIM_TIMC_PERCR_PERX                            \ Timerx Period value


\
\ @brief Timerx Repetition Register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant HRTIM_TIMC_REPCR_REPX                            \ Timerx Repetition counter value


\
\ @brief Timerx Compare 1 Register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMC_CMP1CR_CMP1X                          \ Timerx Compare 1 value


\
\ @brief Timerx Compare 1 Compound Register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMC_CMP1CCR_CMP1X                         \ Timerx Compare 1 value
$00ff0000 constant HRTIM_TIMC_CMP1CCR_REPX                          \ Timerx Repetition value (aliased from HRTIM_REPx register)


\
\ @brief Timerx Compare 2 Register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMC_CMP2CR_CMP2X                          \ Timerx Compare 2 value


\
\ @brief Timerx Compare 3 Register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMC_CMP3CR_CMP3X                          \ Timerx Compare 3 value


\
\ @brief Timerx Compare 4 Register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMC_CMP4CR_CMP4X                          \ Timerx Compare 4 value


\
\ @brief Timerx Capture 1 Register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMC_CPT1CR_CPT1X                          \ Timerx Capture 1 value
$00010000 constant HRTIM_TIMC_CPT1CR_DIR                            \ Timerx Capture 1 Direction status


\
\ @brief Timerx Capture 2 Register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMC_CPT2CR_CPT2X                          \ Timerx Capture 2 value
$00010000 constant HRTIM_TIMC_CPT2CR_DIR                            \ Timerx Capture 1 Direction status


\
\ @brief Timerx Deadtime Register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000001ff constant HRTIM_TIMC_DTCR_DTRX                             \ Deadtime Rising value
$00000200 constant HRTIM_TIMC_DTCR_SDTRX                            \ Sign Deadtime Rising value
$00001c00 constant HRTIM_TIMC_DTCR_DTPRSC                           \ Deadtime Prescaler
$00004000 constant HRTIM_TIMC_DTCR_DTRSLKX                          \ Deadtime Rising Sign Lock
$00008000 constant HRTIM_TIMC_DTCR_DTRLKX                           \ Deadtime Rising Lock
$01ff0000 constant HRTIM_TIMC_DTCR_DTFX                             \ Deadtime Falling value
$02000000 constant HRTIM_TIMC_DTCR_SDTFX                            \ Sign Deadtime Falling value
$40000000 constant HRTIM_TIMC_DTCR_DTFSLKX                          \ Deadtime Falling Sign Lock
$80000000 constant HRTIM_TIMC_DTCR_DTFLKX                           \ Deadtime Falling Lock


\
\ @brief Timerx Output1 Set Register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMC_SETC1R_SST                            \ Software Set trigger
$00000002 constant HRTIM_TIMC_SETC1R_RESYNC                         \ Timer A resynchronizaton
$00000004 constant HRTIM_TIMC_SETC1R_PER                            \ Timer A Period
$00000008 constant HRTIM_TIMC_SETC1R_CMP1                           \ Timer A compare 1
$00000010 constant HRTIM_TIMC_SETC1R_CMP2                           \ Timer A compare 2
$00000020 constant HRTIM_TIMC_SETC1R_CMP3                           \ Timer A compare 3
$00000040 constant HRTIM_TIMC_SETC1R_CMP4                           \ Timer A compare 4
$00000080 constant HRTIM_TIMC_SETC1R_MSTPER                         \ Master Period
$00000100 constant HRTIM_TIMC_SETC1R_MSTCMP1                        \ Master Compare 1
$00000200 constant HRTIM_TIMC_SETC1R_MSTCMP2                        \ Master Compare 2
$00000400 constant HRTIM_TIMC_SETC1R_MSTCMP3                        \ Master Compare 3
$00000800 constant HRTIM_TIMC_SETC1R_MSTCMP4                        \ Master Compare 4
$00001000 constant HRTIM_TIMC_SETC1R_TIMEVNT1                       \ Timer Event 1
$00002000 constant HRTIM_TIMC_SETC1R_TIMEVNT2                       \ Timer Event 2
$00004000 constant HRTIM_TIMC_SETC1R_TIMEVNT3                       \ Timer Event 3
$00008000 constant HRTIM_TIMC_SETC1R_TIMEVNT4                       \ Timer Event 4
$00010000 constant HRTIM_TIMC_SETC1R_TIMEVNT5                       \ Timer Event 5
$00020000 constant HRTIM_TIMC_SETC1R_TIMEVNT6                       \ Timer Event 6
$00040000 constant HRTIM_TIMC_SETC1R_TIMEVNT7                       \ Timer Event 7
$00080000 constant HRTIM_TIMC_SETC1R_TIMEVNT8                       \ Timer Event 8
$00100000 constant HRTIM_TIMC_SETC1R_TIMEVNT9                       \ Timer Event 9
$00200000 constant HRTIM_TIMC_SETC1R_EXTEVNT1                       \ External Event 1
$00400000 constant HRTIM_TIMC_SETC1R_EXTEVNT2                       \ External Event 2
$00800000 constant HRTIM_TIMC_SETC1R_EXTEVNT3                       \ External Event 3
$01000000 constant HRTIM_TIMC_SETC1R_EXTEVNT4                       \ External Event 4
$02000000 constant HRTIM_TIMC_SETC1R_EXTEVNT5                       \ External Event 5
$04000000 constant HRTIM_TIMC_SETC1R_EXTEVNT6                       \ External Event 6
$08000000 constant HRTIM_TIMC_SETC1R_EXTEVNT7                       \ External Event 7
$10000000 constant HRTIM_TIMC_SETC1R_EXTEVNT8                       \ External Event 8
$20000000 constant HRTIM_TIMC_SETC1R_EXTEVNT9                       \ External Event 9
$40000000 constant HRTIM_TIMC_SETC1R_EXTEVNT10                      \ External Event 10
$80000000 constant HRTIM_TIMC_SETC1R_UPDATE                         \ Registers update (transfer preload to active)


\
\ @brief Timerx Output1 Reset Register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMC_RSTC1R_SRT                            \ SRT
$00000002 constant HRTIM_TIMC_RSTC1R_RESYNC                         \ RESYNC
$00000004 constant HRTIM_TIMC_RSTC1R_PER                            \ PER
$00000008 constant HRTIM_TIMC_RSTC1R_CMP1                           \ CMP1
$00000010 constant HRTIM_TIMC_RSTC1R_CMP2                           \ CMP2
$00000020 constant HRTIM_TIMC_RSTC1R_CMP3                           \ CMP3
$00000040 constant HRTIM_TIMC_RSTC1R_CMP4                           \ CMP4
$00000080 constant HRTIM_TIMC_RSTC1R_MSTPER                         \ MSTPER
$00000100 constant HRTIM_TIMC_RSTC1R_MSTCMP1                        \ MSTCMP1
$00000200 constant HRTIM_TIMC_RSTC1R_MSTCMP2                        \ MSTCMP2
$00000400 constant HRTIM_TIMC_RSTC1R_MSTCMP3                        \ MSTCMP3
$00000800 constant HRTIM_TIMC_RSTC1R_MSTCMP4                        \ MSTCMP4
$00001000 constant HRTIM_TIMC_RSTC1R_TIMEVNT1                       \ TIMEVNT1
$00002000 constant HRTIM_TIMC_RSTC1R_TIMEVNT2                       \ TIMEVNT2
$00004000 constant HRTIM_TIMC_RSTC1R_TIMEVNT3                       \ TIMEVNT3
$00008000 constant HRTIM_TIMC_RSTC1R_TIMEVNT4                       \ TIMEVNT4
$00010000 constant HRTIM_TIMC_RSTC1R_TIMEVNT5                       \ TIMEVNT5
$00020000 constant HRTIM_TIMC_RSTC1R_TIMEVNT6                       \ TIMEVNT6
$00040000 constant HRTIM_TIMC_RSTC1R_TIMEVNT7                       \ TIMEVNT7
$00080000 constant HRTIM_TIMC_RSTC1R_TIMEVNT8                       \ TIMEVNT8
$00100000 constant HRTIM_TIMC_RSTC1R_TIMEVNT9                       \ TIMEVNT9
$00200000 constant HRTIM_TIMC_RSTC1R_EXTEVNT1                       \ EXTEVNT1
$00400000 constant HRTIM_TIMC_RSTC1R_EXTEVNT2                       \ EXTEVNT2
$00800000 constant HRTIM_TIMC_RSTC1R_EXTEVNT3                       \ EXTEVNT3
$01000000 constant HRTIM_TIMC_RSTC1R_EXTEVNT4                       \ EXTEVNT4
$02000000 constant HRTIM_TIMC_RSTC1R_EXTEVNT5                       \ EXTEVNT5
$04000000 constant HRTIM_TIMC_RSTC1R_EXTEVNT6                       \ EXTEVNT6
$08000000 constant HRTIM_TIMC_RSTC1R_EXTEVNT7                       \ EXTEVNT7
$10000000 constant HRTIM_TIMC_RSTC1R_EXTEVNT8                       \ EXTEVNT8
$20000000 constant HRTIM_TIMC_RSTC1R_EXTEVNT9                       \ EXTEVNT9
$40000000 constant HRTIM_TIMC_RSTC1R_EXTEVNT10                      \ EXTEVNT10
$80000000 constant HRTIM_TIMC_RSTC1R_UPDATE                         \ UPDATE


\
\ @brief Timerx Output2 Set Register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMC_SETC2R_SST                            \ SST
$00000002 constant HRTIM_TIMC_SETC2R_RESYNC                         \ RESYNC
$00000004 constant HRTIM_TIMC_SETC2R_PER                            \ PER
$00000008 constant HRTIM_TIMC_SETC2R_CMP1                           \ CMP1
$00000010 constant HRTIM_TIMC_SETC2R_CMP2                           \ CMP2
$00000020 constant HRTIM_TIMC_SETC2R_CMP3                           \ CMP3
$00000040 constant HRTIM_TIMC_SETC2R_CMP4                           \ CMP4
$00000080 constant HRTIM_TIMC_SETC2R_MSTPER                         \ MSTPER
$00000100 constant HRTIM_TIMC_SETC2R_MSTCMP1                        \ MSTCMP1
$00000200 constant HRTIM_TIMC_SETC2R_MSTCMP2                        \ MSTCMP2
$00000400 constant HRTIM_TIMC_SETC2R_MSTCMP3                        \ MSTCMP3
$00000800 constant HRTIM_TIMC_SETC2R_MSTCMP4                        \ MSTCMP4
$00001000 constant HRTIM_TIMC_SETC2R_TIMEVNT1                       \ TIMEVNT1
$00002000 constant HRTIM_TIMC_SETC2R_TIMEVNT2                       \ TIMEVNT2
$00004000 constant HRTIM_TIMC_SETC2R_TIMEVNT3                       \ TIMEVNT3
$00008000 constant HRTIM_TIMC_SETC2R_TIMEVNT4                       \ TIMEVNT4
$00010000 constant HRTIM_TIMC_SETC2R_TIMEVNT5                       \ TIMEVNT5
$00020000 constant HRTIM_TIMC_SETC2R_TIMEVNT6                       \ TIMEVNT6
$00040000 constant HRTIM_TIMC_SETC2R_TIMEVNT7                       \ TIMEVNT7
$00080000 constant HRTIM_TIMC_SETC2R_TIMEVNT8                       \ TIMEVNT8
$00100000 constant HRTIM_TIMC_SETC2R_TIMEVNT9                       \ TIMEVNT9
$00200000 constant HRTIM_TIMC_SETC2R_EXTEVNT1                       \ EXTEVNT1
$00400000 constant HRTIM_TIMC_SETC2R_EXTEVNT2                       \ EXTEVNT2
$00800000 constant HRTIM_TIMC_SETC2R_EXTEVNT3                       \ EXTEVNT3
$01000000 constant HRTIM_TIMC_SETC2R_EXTEVNT4                       \ EXTEVNT4
$02000000 constant HRTIM_TIMC_SETC2R_EXTEVNT5                       \ EXTEVNT5
$04000000 constant HRTIM_TIMC_SETC2R_EXTEVNT6                       \ EXTEVNT6
$08000000 constant HRTIM_TIMC_SETC2R_EXTEVNT7                       \ EXTEVNT7
$10000000 constant HRTIM_TIMC_SETC2R_EXTEVNT8                       \ EXTEVNT8
$20000000 constant HRTIM_TIMC_SETC2R_EXTEVNT9                       \ EXTEVNT9
$40000000 constant HRTIM_TIMC_SETC2R_EXTEVNT10                      \ EXTEVNT10
$80000000 constant HRTIM_TIMC_SETC2R_UPDATE                         \ UPDATE


\
\ @brief Timerx Output2 Reset Register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMC_RSTC2R_SRT                            \ SRT
$00000002 constant HRTIM_TIMC_RSTC2R_RESYNC                         \ RESYNC
$00000004 constant HRTIM_TIMC_RSTC2R_PER                            \ PER
$00000008 constant HRTIM_TIMC_RSTC2R_CMP1                           \ CMP1
$00000010 constant HRTIM_TIMC_RSTC2R_CMP2                           \ CMP2
$00000020 constant HRTIM_TIMC_RSTC2R_CMP3                           \ CMP3
$00000040 constant HRTIM_TIMC_RSTC2R_CMP4                           \ CMP4
$00000080 constant HRTIM_TIMC_RSTC2R_MSTPER                         \ MSTPER
$00000100 constant HRTIM_TIMC_RSTC2R_MSTCMP1                        \ MSTCMP1
$00000200 constant HRTIM_TIMC_RSTC2R_MSTCMP2                        \ MSTCMP2
$00000400 constant HRTIM_TIMC_RSTC2R_MSTCMP3                        \ MSTCMP3
$00000800 constant HRTIM_TIMC_RSTC2R_MSTCMP4                        \ MSTCMP4
$00001000 constant HRTIM_TIMC_RSTC2R_TIMEVNT1                       \ TIMEVNT1
$00002000 constant HRTIM_TIMC_RSTC2R_TIMEVNT2                       \ TIMEVNT2
$00004000 constant HRTIM_TIMC_RSTC2R_TIMEVNT3                       \ TIMEVNT3
$00008000 constant HRTIM_TIMC_RSTC2R_TIMEVNT4                       \ TIMEVNT4
$00010000 constant HRTIM_TIMC_RSTC2R_TIMEVNT5                       \ TIMEVNT5
$00020000 constant HRTIM_TIMC_RSTC2R_TIMEVNT6                       \ TIMEVNT6
$00040000 constant HRTIM_TIMC_RSTC2R_TIMEVNT7                       \ TIMEVNT7
$00080000 constant HRTIM_TIMC_RSTC2R_TIMEVNT8                       \ TIMEVNT8
$00100000 constant HRTIM_TIMC_RSTC2R_TIMEVNT9                       \ TIMEVNT9
$00200000 constant HRTIM_TIMC_RSTC2R_EXTEVNT1                       \ EXTEVNT1
$00400000 constant HRTIM_TIMC_RSTC2R_EXTEVNT2                       \ EXTEVNT2
$00800000 constant HRTIM_TIMC_RSTC2R_EXTEVNT3                       \ EXTEVNT3
$01000000 constant HRTIM_TIMC_RSTC2R_EXTEVNT4                       \ EXTEVNT4
$02000000 constant HRTIM_TIMC_RSTC2R_EXTEVNT5                       \ EXTEVNT5
$04000000 constant HRTIM_TIMC_RSTC2R_EXTEVNT6                       \ EXTEVNT6
$08000000 constant HRTIM_TIMC_RSTC2R_EXTEVNT7                       \ EXTEVNT7
$10000000 constant HRTIM_TIMC_RSTC2R_EXTEVNT8                       \ EXTEVNT8
$20000000 constant HRTIM_TIMC_RSTC2R_EXTEVNT9                       \ EXTEVNT9
$40000000 constant HRTIM_TIMC_RSTC2R_EXTEVNT10                      \ EXTEVNT10
$80000000 constant HRTIM_TIMC_RSTC2R_UPDATE                         \ UPDATE


\
\ @brief Timerx External Event Filtering Register 1
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMC_EEFCR1_EE1LTCH                        \ External Event 1 latch
$0000001e constant HRTIM_TIMC_EEFCR1_EE1FLTR                        \ External Event 1 filter
$00000040 constant HRTIM_TIMC_EEFCR1_EE2LTCH                        \ External Event 2 latch
$00000780 constant HRTIM_TIMC_EEFCR1_EE2FLTR                        \ External Event 2 filter
$00001000 constant HRTIM_TIMC_EEFCR1_EE3LTCH                        \ External Event 3 latch
$0001e000 constant HRTIM_TIMC_EEFCR1_EE3FLTR                        \ External Event 3 filter
$00040000 constant HRTIM_TIMC_EEFCR1_EE4LTCH                        \ External Event 4 latch
$00780000 constant HRTIM_TIMC_EEFCR1_EE4FLTR                        \ External Event 4 filter
$01000000 constant HRTIM_TIMC_EEFCR1_EE5LTCH                        \ External Event 5 latch
$1e000000 constant HRTIM_TIMC_EEFCR1_EE5FLTR                        \ External Event 5 filter


\
\ @brief Timerx External Event Filtering Register 2
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMC_EEFCR2_EE6LTCH                        \ External Event 6 latch
$0000001e constant HRTIM_TIMC_EEFCR2_EE6FLTR                        \ External Event 6 filter
$00000040 constant HRTIM_TIMC_EEFCR2_EE7LTCH                        \ External Event 7 latch
$00000780 constant HRTIM_TIMC_EEFCR2_EE7FLTR                        \ External Event 7 filter
$00001000 constant HRTIM_TIMC_EEFCR2_EE8LTCH                        \ External Event 8 latch
$0001e000 constant HRTIM_TIMC_EEFCR2_EE8FLTR                        \ External Event 8 filter
$00040000 constant HRTIM_TIMC_EEFCR2_EE9LTCH                        \ External Event 9 latch
$00780000 constant HRTIM_TIMC_EEFCR2_EE9FLTR                        \ External Event 9 filter
$01000000 constant HRTIM_TIMC_EEFCR2_EE10LTCH                       \ External Event 10 latch
$1e000000 constant HRTIM_TIMC_EEFCR2_EE10FLTR                       \ External Event 10 filter


\
\ @brief TimerA Reset Register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMC_RSTCR_TIMFCMP1                        \ Timer A Update reset
$00000002 constant HRTIM_TIMC_RSTCR_UPDT                            \ Timer A Update reset
$00000004 constant HRTIM_TIMC_RSTCR_CMP2                            \ Timer A compare 2 reset
$00000008 constant HRTIM_TIMC_RSTCR_CMP4                            \ Timer A compare 4 reset
$00000010 constant HRTIM_TIMC_RSTCR_MSTPER                          \ Master timer Period
$00000020 constant HRTIM_TIMC_RSTCR_MSTCMP1                         \ Master compare 1
$00000040 constant HRTIM_TIMC_RSTCR_MSTCMP2                         \ Master compare 2
$00000080 constant HRTIM_TIMC_RSTCR_MSTCMP3                         \ Master compare 3
$00000100 constant HRTIM_TIMC_RSTCR_MSTCMP4                         \ Master compare 4
$00000200 constant HRTIM_TIMC_RSTCR_EXTEVNT1                        \ External Event 1
$00000400 constant HRTIM_TIMC_RSTCR_EXTEVNT2                        \ External Event 2
$00000800 constant HRTIM_TIMC_RSTCR_EXTEVNT3                        \ External Event 3
$00001000 constant HRTIM_TIMC_RSTCR_EXTEVNT4                        \ External Event 4
$00002000 constant HRTIM_TIMC_RSTCR_EXTEVNT5                        \ External Event 5
$00004000 constant HRTIM_TIMC_RSTCR_EXTEVNT6                        \ External Event 6
$00008000 constant HRTIM_TIMC_RSTCR_EXTEVNT7                        \ External Event 7
$00010000 constant HRTIM_TIMC_RSTCR_EXTEVNT8                        \ External Event 8
$00020000 constant HRTIM_TIMC_RSTCR_EXTEVNT9                        \ External Event 9
$00040000 constant HRTIM_TIMC_RSTCR_EXTEVNT10                       \ External Event 10
$00080000 constant HRTIM_TIMC_RSTCR_TIMACMP1                        \ Timer A Compare 1
$00100000 constant HRTIM_TIMC_RSTCR_TIMACMP2                        \ Timer A Compare 2
$00200000 constant HRTIM_TIMC_RSTCR_TIMACMP4                        \ Timer A Compare 4
$00400000 constant HRTIM_TIMC_RSTCR_TIMBCMP1                        \ Timer B Compare 1
$00800000 constant HRTIM_TIMC_RSTCR_TIMBCMP2                        \ Timer B Compare 2
$01000000 constant HRTIM_TIMC_RSTCR_TIMBCMP4                        \ Timer B Compare 4
$02000000 constant HRTIM_TIMC_RSTCR_TIMDCMP1                        \ Timer D Compare 1
$04000000 constant HRTIM_TIMC_RSTCR_TIMDCMP2                        \ Timer D Compare 2
$08000000 constant HRTIM_TIMC_RSTCR_TIMDCMP4                        \ Timer D Compare 4
$10000000 constant HRTIM_TIMC_RSTCR_TIMECMP1                        \ Timer E Compare 1
$20000000 constant HRTIM_TIMC_RSTCR_TIMECMP2                        \ Timer E Compare 2
$40000000 constant HRTIM_TIMC_RSTCR_TIMECMP4                        \ Timer E Compare 4
$80000000 constant HRTIM_TIMC_RSTCR_TIMFCPM2                        \ Timer F Compare 2


\
\ @brief Timerx Chopper Register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$0000000f constant HRTIM_TIMC_CHPCR_CHPFRQ                          \ Timerx carrier frequency value
$00000070 constant HRTIM_TIMC_CHPCR_CHPDTY                          \ Timerx chopper duty cycle value
$00000780 constant HRTIM_TIMC_CHPCR_STRTPW                          \ STRTPW


\
\ @brief Timerx Capture 2 Control Register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMC_CPT1CCR_SWCPT                         \ Software Capture
$00000002 constant HRTIM_TIMC_CPT1CCR_UDPCPT                        \ Update Capture
$00000004 constant HRTIM_TIMC_CPT1CCR_EXEV1CPT                      \ External Event 1 Capture
$00000008 constant HRTIM_TIMC_CPT1CCR_EXEV2CPT                      \ External Event 2 Capture
$00000010 constant HRTIM_TIMC_CPT1CCR_EXEV3CPT                      \ External Event 3 Capture
$00000020 constant HRTIM_TIMC_CPT1CCR_EXEV4CPT                      \ External Event 4 Capture
$00000040 constant HRTIM_TIMC_CPT1CCR_EXEV5CPT                      \ External Event 5 Capture
$00000080 constant HRTIM_TIMC_CPT1CCR_EXEV6CPT                      \ External Event 6 Capture
$00000100 constant HRTIM_TIMC_CPT1CCR_EXEV7CPT                      \ External Event 7 Capture
$00000200 constant HRTIM_TIMC_CPT1CCR_EXEV8CPT                      \ External Event 8 Capture
$00000400 constant HRTIM_TIMC_CPT1CCR_EXEV9CPT                      \ External Event 9 Capture
$00000800 constant HRTIM_TIMC_CPT1CCR_EXEV10CPT                     \ External Event 10 Capture
$00001000 constant HRTIM_TIMC_CPT1CCR_TA1SET                        \ Timer A output 1 Set
$00002000 constant HRTIM_TIMC_CPT1CCR_TA1RST                        \ Timer A output 1 Reset
$00004000 constant HRTIM_TIMC_CPT1CCR_TACMP1                        \ Timer A Compare 1
$00008000 constant HRTIM_TIMC_CPT1CCR_TACMP2                        \ Timer A Compare 2
$00010000 constant HRTIM_TIMC_CPT1CCR_TB1SET                        \ Timer B output 1 Set
$00020000 constant HRTIM_TIMC_CPT1CCR_TB1RST                        \ Timer B output 1 Reset
$00040000 constant HRTIM_TIMC_CPT1CCR_TBCMP1                        \ Timer B Compare 1
$00080000 constant HRTIM_TIMC_CPT1CCR_TBCMP2                        \ Timer B Compare 2
$00100000 constant HRTIM_TIMC_CPT1CCR_TF1SET                        \ TF1SET
$00200000 constant HRTIM_TIMC_CPT1CCR_TF1RST                        \ TF1RST
$00400000 constant HRTIM_TIMC_CPT1CCR_TFCMP1                        \ TFCMP1
$00800000 constant HRTIM_TIMC_CPT1CCR_TFCMP2                        \ TFCMP2
$01000000 constant HRTIM_TIMC_CPT1CCR_TD1SET                        \ Timer D output 1 Set
$02000000 constant HRTIM_TIMC_CPT1CCR_TD1RST                        \ Timer D output 1 Reset
$04000000 constant HRTIM_TIMC_CPT1CCR_TDCMP1                        \ Timer D Compare 1
$08000000 constant HRTIM_TIMC_CPT1CCR_TDCMP2                        \ Timer D Compare 2
$10000000 constant HRTIM_TIMC_CPT1CCR_TE1SET                        \ Timer E output 1 Set
$20000000 constant HRTIM_TIMC_CPT1CCR_TE1RST                        \ Timer E output 1 Reset
$40000000 constant HRTIM_TIMC_CPT1CCR_TECMP1                        \ Timer E Compare 1
$80000000 constant HRTIM_TIMC_CPT1CCR_TECMP2                        \ Timer E Compare 2


\
\ @brief CPT2xCR
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMC_CPT2CCR_SWCPT                         \ Software Capture
$00000002 constant HRTIM_TIMC_CPT2CCR_UDPCPT                        \ Update Capture
$00000004 constant HRTIM_TIMC_CPT2CCR_EXEV1CPT                      \ External Event 1 Capture
$00000008 constant HRTIM_TIMC_CPT2CCR_EXEV2CPT                      \ External Event 2 Capture
$00000010 constant HRTIM_TIMC_CPT2CCR_EXEV3CPT                      \ External Event 3 Capture
$00000020 constant HRTIM_TIMC_CPT2CCR_EXEV4CPT                      \ External Event 4 Capture
$00000040 constant HRTIM_TIMC_CPT2CCR_EXEV5CPT                      \ External Event 5 Capture
$00000080 constant HRTIM_TIMC_CPT2CCR_EXEV6CPT                      \ External Event 6 Capture
$00000100 constant HRTIM_TIMC_CPT2CCR_EXEV7CPT                      \ External Event 7 Capture
$00000200 constant HRTIM_TIMC_CPT2CCR_EXEV8CPT                      \ External Event 8 Capture
$00000400 constant HRTIM_TIMC_CPT2CCR_EXEV9CPT                      \ External Event 9 Capture
$00000800 constant HRTIM_TIMC_CPT2CCR_EXEV10CPT                     \ External Event 10 Capture
$00001000 constant HRTIM_TIMC_CPT2CCR_TA1SET                        \ Timer A output 1 Set
$00002000 constant HRTIM_TIMC_CPT2CCR_TA1RST                        \ Timer A output 1 Reset
$00004000 constant HRTIM_TIMC_CPT2CCR_TACMP1                        \ Timer A Compare 1
$00008000 constant HRTIM_TIMC_CPT2CCR_TACMP2                        \ Timer A Compare 2
$00010000 constant HRTIM_TIMC_CPT2CCR_TB1SET                        \ Timer B output 1 Set
$00020000 constant HRTIM_TIMC_CPT2CCR_TB1RST                        \ Timer B output 1 Reset
$00040000 constant HRTIM_TIMC_CPT2CCR_TBCMP1                        \ Timer B Compare 1
$00080000 constant HRTIM_TIMC_CPT2CCR_TBCMP2                        \ Timer B Compare 2
$00100000 constant HRTIM_TIMC_CPT2CCR_TF1SET                        \ TF1SET
$00200000 constant HRTIM_TIMC_CPT2CCR_TF1RST                        \ TF1RST
$00400000 constant HRTIM_TIMC_CPT2CCR_TF1CMP1                       \ TF1CMP1
$00800000 constant HRTIM_TIMC_CPT2CCR_TF1CMP2                       \ TF1CMP2
$01000000 constant HRTIM_TIMC_CPT2CCR_TD1SET                        \ Timer D output 1 Set
$02000000 constant HRTIM_TIMC_CPT2CCR_TD1RST                        \ Timer D output 1 Reset
$04000000 constant HRTIM_TIMC_CPT2CCR_TDCMP1                        \ Timer D Compare 1
$08000000 constant HRTIM_TIMC_CPT2CCR_TDCMP2                        \ Timer D Compare 2
$10000000 constant HRTIM_TIMC_CPT2CCR_TE1SET                        \ Timer E output 1 Set
$20000000 constant HRTIM_TIMC_CPT2CCR_TE1RST                        \ Timer E output 1 Reset
$40000000 constant HRTIM_TIMC_CPT2CCR_TECMP1                        \ Timer E Compare 1
$80000000 constant HRTIM_TIMC_CPT2CCR_TECMP2                        \ Timer E Compare 2


\
\ @brief Timerx Output Register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000002 constant HRTIM_TIMC_OUTCR_POL1                            \ Output 1 polarity
$00000004 constant HRTIM_TIMC_OUTCR_IDLEM1                          \ Output 1 Idle mode
$00000008 constant HRTIM_TIMC_OUTCR_IDLES1                          \ Output 1 Idle State
$00000030 constant HRTIM_TIMC_OUTCR_FAULT1                          \ Output 1 Fault state
$00000040 constant HRTIM_TIMC_OUTCR_CHP1                            \ Output 1 Chopper enable
$00000080 constant HRTIM_TIMC_OUTCR_DIDL1                           \ Output 1 Deadtime upon burst mode Idle entry
$00000100 constant HRTIM_TIMC_OUTCR_DTEN                            \ Deadtime enable
$00000200 constant HRTIM_TIMC_OUTCR_DLYPRTEN                        \ Delayed Protection Enable
$00001c00 constant HRTIM_TIMC_OUTCR_DLYPRT                          \ Delayed Protection
$00004000 constant HRTIM_TIMC_OUTCR_BIAR                            \ Balanced Idle Automatic Resume
$00020000 constant HRTIM_TIMC_OUTCR_POL2                            \ Output 2 polarity
$00040000 constant HRTIM_TIMC_OUTCR_IDLEM2                          \ Output 2 Idle mode
$00080000 constant HRTIM_TIMC_OUTCR_IDLES2                          \ Output 2 Idle State
$00300000 constant HRTIM_TIMC_OUTCR_FAULT2                          \ Output 2 Fault state
$00400000 constant HRTIM_TIMC_OUTCR_CHP2                            \ Output 2 Chopper enable
$00800000 constant HRTIM_TIMC_OUTCR_DIDL2                           \ Output 2 Deadtime upon burst mode Idle entry


\
\ @brief Timerx Fault Register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMC_FLTCR_FLT1EN                          \ Fault 1 enable
$00000002 constant HRTIM_TIMC_FLTCR_FLT2EN                          \ Fault 2 enable
$00000004 constant HRTIM_TIMC_FLTCR_FLT3EN                          \ Fault 3 enable
$00000008 constant HRTIM_TIMC_FLTCR_FLT4EN                          \ Fault 4 enable
$00000010 constant HRTIM_TIMC_FLTCR_FLT5EN                          \ Fault 5 enable
$00000020 constant HRTIM_TIMC_FLTCR_FLT6EN                          \ Fault 6 enable
$80000000 constant HRTIM_TIMC_FLTCR_FLTLCK                          \ Fault sources Lock


\
\ @brief HRTIM Timerx Control Register 2
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMC_TIMCCR2_DCDE                          \ Dual Channel DAC trigger enable
$00000002 constant HRTIM_TIMC_TIMCCR2_DCDS                          \ Dual Channel DAC Step trigger
$00000004 constant HRTIM_TIMC_TIMCCR2_DCDR                          \ Dual Channel DAC Reset trigger
$00000010 constant HRTIM_TIMC_TIMCCR2_UDM                           \ Up-Down Mode
$000000c0 constant HRTIM_TIMC_TIMCCR2_ROM                           \ Roll-Over Mode
$00000300 constant HRTIM_TIMC_TIMCCR2_OUTROM                        \ Output Roll-Over Mode
$00000c00 constant HRTIM_TIMC_TIMCCR2_ADROM                         \ ADC Roll-Over Mode
$00003000 constant HRTIM_TIMC_TIMCCR2_BMROM                         \ Burst Mode Roll-Over Mode
$0000c000 constant HRTIM_TIMC_TIMCCR2_FEROM                         \ Fault and Event Roll-Over Mode
$00010000 constant HRTIM_TIMC_TIMCCR2_GTCMP1                        \ Greater than Compare 1 PWM mode
$00020000 constant HRTIM_TIMC_TIMCCR2_GTCMP3                        \ Greater than Compare 3 PWM mode
$00100000 constant HRTIM_TIMC_TIMCCR2_TRGHLF                        \ Triggered-half mode


\
\ @brief HRTIM Timerx External Event Filtering Register 3
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMC_CEEFR3_EEVACE                         \ External Event A Counter Enable
$00000002 constant HRTIM_TIMC_CEEFR3_EEVACRES                       \ External Event A Counter Reset
$00000004 constant HRTIM_TIMC_CEEFR3_EEVARSTM                       \ External Event A Reset Mode
$000000f0 constant HRTIM_TIMC_CEEFR3_EEVASEL                        \ External Event A Selection
$00003f00 constant HRTIM_TIMC_CEEFR3_EEVACNT                        \ External Event A counter


\
\ @brief High Resolution Timer: TIMC
\
$40016980 constant HRTIM_TIMC_TIMCCR  \ offset: 0x00 : Timerx Control Register
$40016984 constant HRTIM_TIMC_TIMCISR  \ offset: 0x04 : Timerx Interrupt Status Register
$40016988 constant HRTIM_TIMC_TIMCICR  \ offset: 0x08 : Timerx Interrupt Clear Register
$4001698c constant HRTIM_TIMC_TIMCDIER  \ offset: 0x0C : TIMxDIER
$40016990 constant HRTIM_TIMC_CNTCR  \ offset: 0x10 : Timerx Counter Register
$40016994 constant HRTIM_TIMC_PERCR  \ offset: 0x14 : Timerx Period Register
$40016998 constant HRTIM_TIMC_REPCR  \ offset: 0x18 : Timerx Repetition Register
$4001699c constant HRTIM_TIMC_CMP1CR  \ offset: 0x1C : Timerx Compare 1 Register
$400169a0 constant HRTIM_TIMC_CMP1CCR  \ offset: 0x20 : Timerx Compare 1 Compound Register
$400169a4 constant HRTIM_TIMC_CMP2CR  \ offset: 0x24 : Timerx Compare 2 Register
$400169a8 constant HRTIM_TIMC_CMP3CR  \ offset: 0x28 : Timerx Compare 3 Register
$400169ac constant HRTIM_TIMC_CMP4CR  \ offset: 0x2C : Timerx Compare 4 Register
$400169b0 constant HRTIM_TIMC_CPT1CR  \ offset: 0x30 : Timerx Capture 1 Register
$400169b4 constant HRTIM_TIMC_CPT2CR  \ offset: 0x34 : Timerx Capture 2 Register
$400169b8 constant HRTIM_TIMC_DTCR  \ offset: 0x38 : Timerx Deadtime Register
$400169bc constant HRTIM_TIMC_SETC1R  \ offset: 0x3C : Timerx Output1 Set Register
$400169c0 constant HRTIM_TIMC_RSTC1R  \ offset: 0x40 : Timerx Output1 Reset Register
$400169c4 constant HRTIM_TIMC_SETC2R  \ offset: 0x44 : Timerx Output2 Set Register
$400169c8 constant HRTIM_TIMC_RSTC2R  \ offset: 0x48 : Timerx Output2 Reset Register
$400169cc constant HRTIM_TIMC_EEFCR1  \ offset: 0x4C : Timerx External Event Filtering Register 1
$400169d0 constant HRTIM_TIMC_EEFCR2  \ offset: 0x50 : Timerx External Event Filtering Register 2
$400169d4 constant HRTIM_TIMC_RSTCR  \ offset: 0x54 : TimerA Reset Register
$400169d8 constant HRTIM_TIMC_CHPCR  \ offset: 0x58 : Timerx Chopper Register
$400169dc constant HRTIM_TIMC_CPT1CCR  \ offset: 0x5C : Timerx Capture 2 Control Register
$400169e0 constant HRTIM_TIMC_CPT2CCR  \ offset: 0x60 : CPT2xCR
$400169e4 constant HRTIM_TIMC_OUTCR  \ offset: 0x64 : Timerx Output Register
$400169e8 constant HRTIM_TIMC_FLTCR  \ offset: 0x68 : Timerx Fault Register
$400169ec constant HRTIM_TIMC_TIMCCR2  \ offset: 0x6C : HRTIM Timerx Control Register 2
$400169f0 constant HRTIM_TIMC_CEEFR3  \ offset: 0x70 : HRTIM Timerx External Event Filtering Register 3

