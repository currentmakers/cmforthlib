\
\ @file hrtim_time.fs
\ @brief High Resolution Timer: TIME
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

$00000007 constant HRTIM_TIME_TIMECR_CK_PSCX                        \ HRTIM Timer x Clock prescaler
$00000008 constant HRTIM_TIME_TIMECR_CONT                           \ Continuous mode
$00000010 constant HRTIM_TIME_TIMECR_RETRIG                         \ Re-triggerable mode
$00000020 constant HRTIM_TIME_TIMECR_HALF                           \ Half mode enable
$00000040 constant HRTIM_TIME_TIMECR_PSHPLL                         \ Push-Pull mode enable
$00000400 constant HRTIM_TIME_TIMECR_SYNCRSTX                       \ Synchronization Resets Timer x
$00000800 constant HRTIM_TIME_TIMECR_SYNCSTRTX                      \ Synchronization Starts Timer x
$00003000 constant HRTIM_TIME_TIMECR_DELCMP2                        \ Delayed CMP2 mode
$0000c000 constant HRTIM_TIME_TIMECR_DELCMP4                        \ Delayed CMP4 mode
$00020000 constant HRTIM_TIME_TIMECR_TXREPU                         \ Timer x Repetition update
$00040000 constant HRTIM_TIME_TIMECR_TXRSTU                         \ Timerx reset update
$00100000 constant HRTIM_TIME_TIMECR_TBU                            \ TBU
$00200000 constant HRTIM_TIME_TIMECR_TCU                            \ TCU
$00400000 constant HRTIM_TIME_TIMECR_TDU                            \ TDU
$00800000 constant HRTIM_TIME_TIMECR_TEU                            \ TEU
$01000000 constant HRTIM_TIME_TIMECR_MSTU                           \ Master Timer update
$06000000 constant HRTIM_TIME_TIMECR_DACSYNC                        \ AC Synchronization
$08000000 constant HRTIM_TIME_TIMECR_PREEN                          \ Preload enable
$f0000000 constant HRTIM_TIME_TIMECR_UPDGAT                         \ Update Gating


\
\ @brief Timerx Interrupt Status Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIME_TIMEISR_CMP1                          \ Compare 1 Interrupt Flag
$00000002 constant HRTIM_TIME_TIMEISR_CMP2                          \ Compare 2 Interrupt Flag
$00000004 constant HRTIM_TIME_TIMEISR_CMP3                          \ Compare 3 Interrupt Flag
$00000008 constant HRTIM_TIME_TIMEISR_CMP4                          \ Compare 4 Interrupt Flag
$00000010 constant HRTIM_TIME_TIMEISR_REP                           \ Repetition Interrupt Flag
$00000040 constant HRTIM_TIME_TIMEISR_UPD                           \ Update Interrupt Flag
$00000080 constant HRTIM_TIME_TIMEISR_CPT1                          \ Capture1 Interrupt Flag
$00000100 constant HRTIM_TIME_TIMEISR_CPT2                          \ Capture2 Interrupt Flag
$00000200 constant HRTIM_TIME_TIMEISR_SETX1                         \ Output 1 Set Interrupt Flag
$00000400 constant HRTIM_TIME_TIMEISR_RSTX1                         \ Output 1 Reset Interrupt Flag
$00000800 constant HRTIM_TIME_TIMEISR_SETX2                         \ Output 2 Set Interrupt Flag
$00001000 constant HRTIM_TIME_TIMEISR_RSTX2                         \ Output 2 Reset Interrupt Flag
$00002000 constant HRTIM_TIME_TIMEISR_RST                           \ Reset Interrupt Flag
$00004000 constant HRTIM_TIME_TIMEISR_DLYPRT                        \ Delayed Protection Flag
$00010000 constant HRTIM_TIME_TIMEISR_CPPSTAT                       \ Current Push Pull Status
$00020000 constant HRTIM_TIME_TIMEISR_IPPSTAT                       \ Idle Push Pull Status
$00040000 constant HRTIM_TIME_TIMEISR_O1STAT                        \ Output 1 State
$00080000 constant HRTIM_TIME_TIMEISR_O2STAT                        \ Output 2 State
$00100000 constant HRTIM_TIME_TIMEISR_O1CPY                         \ Output 1 Copy
$00200000 constant HRTIM_TIME_TIMEISR_O2CPY                         \ Output 2 Copy


\
\ @brief Timerx Interrupt Clear Register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIME_TIMEICR_CMP1C                         \ Compare 1 Interrupt flag Clear
$00000002 constant HRTIM_TIME_TIMEICR_CMP2C                         \ Compare 2 Interrupt flag Clear
$00000004 constant HRTIM_TIME_TIMEICR_CMP3C                         \ Compare 3 Interrupt flag Clear
$00000008 constant HRTIM_TIME_TIMEICR_CMP4C                         \ Compare 4 Interrupt flag Clear
$00000010 constant HRTIM_TIME_TIMEICR_REPC                          \ Repetition Interrupt flag Clear
$00000040 constant HRTIM_TIME_TIMEICR_UPDC                          \ Update Interrupt flag Clear
$00000080 constant HRTIM_TIME_TIMEICR_CPT1C                         \ Capture1 Interrupt flag Clear
$00000100 constant HRTIM_TIME_TIMEICR_CPT2C                         \ Capture2 Interrupt flag Clear
$00000200 constant HRTIM_TIME_TIMEICR_SET1XC                        \ Output 1 Set flag Clear
$00000400 constant HRTIM_TIME_TIMEICR_RSTX1C                        \ Output 1 Reset flag Clear
$00000800 constant HRTIM_TIME_TIMEICR_SET2XC                        \ Output 2 Set flag Clear
$00001000 constant HRTIM_TIME_TIMEICR_RSTX2C                        \ Output 2 Reset flag Clear
$00002000 constant HRTIM_TIME_TIMEICR_RSTC                          \ Reset Interrupt flag Clear
$00004000 constant HRTIM_TIME_TIMEICR_DLYPRTC                       \ Delayed Protection Flag Clear


\
\ @brief TIMxDIER5
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIME_TIMEDIER5_CMP1IE                      \ CMP1IE
$00000002 constant HRTIM_TIME_TIMEDIER5_CMP2IE                      \ CMP2IE
$00000004 constant HRTIM_TIME_TIMEDIER5_CMP3IE                      \ CMP3IE
$00000008 constant HRTIM_TIME_TIMEDIER5_CMP4IE                      \ CMP4IE
$00000010 constant HRTIM_TIME_TIMEDIER5_REPIE                       \ REPIE
$00000040 constant HRTIM_TIME_TIMEDIER5_UPDIE                       \ UPDIE
$00000080 constant HRTIM_TIME_TIMEDIER5_CPT1IE                      \ CPT1IE
$00000100 constant HRTIM_TIME_TIMEDIER5_CPT2IE                      \ CPT2IE
$00000200 constant HRTIM_TIME_TIMEDIER5_SET1XIE                     \ SET1xIE
$00000400 constant HRTIM_TIME_TIMEDIER5_RSTX1IE                     \ RSTx1IE
$00000800 constant HRTIM_TIME_TIMEDIER5_SETX2IE                     \ SETx2IE
$00001000 constant HRTIM_TIME_TIMEDIER5_RSTX2IE                     \ RSTx2IE
$00002000 constant HRTIM_TIME_TIMEDIER5_RSTIE                       \ RSTIE
$00004000 constant HRTIM_TIME_TIMEDIER5_DLYPRTIE                    \ DLYPRTIE
$00010000 constant HRTIM_TIME_TIMEDIER5_CMP1DE                      \ CMP1DE
$00020000 constant HRTIM_TIME_TIMEDIER5_CMP2DE                      \ CMP2DE
$00040000 constant HRTIM_TIME_TIMEDIER5_CMP3DE                      \ CMP3DE
$00080000 constant HRTIM_TIME_TIMEDIER5_CMP4DE                      \ CMP4DE
$00100000 constant HRTIM_TIME_TIMEDIER5_REPDE                       \ REPDE
$00400000 constant HRTIM_TIME_TIMEDIER5_UPDDE                       \ UPDDE
$00800000 constant HRTIM_TIME_TIMEDIER5_CPT1DE                      \ CPT1DE
$01000000 constant HRTIM_TIME_TIMEDIER5_CPT2DE                      \ CPT2DE
$02000000 constant HRTIM_TIME_TIMEDIER5_SET1XDE                     \ SET1xDE
$04000000 constant HRTIM_TIME_TIMEDIER5_RSTX1DE                     \ RSTx1DE
$08000000 constant HRTIM_TIME_TIMEDIER5_SETX2DE                     \ SETx2DE
$10000000 constant HRTIM_TIME_TIMEDIER5_RSTX2DE                     \ RSTx2DE
$20000000 constant HRTIM_TIME_TIMEDIER5_RSTDE                       \ RSTDE
$40000000 constant HRTIM_TIME_TIMEDIER5_DLYPRTDE                    \ DLYPRTDE


\
\ @brief Timerx Counter Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIME_CNTER_CNTX                            \ Timerx Counter value


\
\ @brief Timerx Period Register
\ Address offset: 0x14
\ Reset value: 0x0000FFFF
\

$0000ffff constant HRTIM_TIME_PERER_PERX                            \ Timerx Period value


\
\ @brief Timerx Repetition Register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant HRTIM_TIME_REPER_REPX                            \ Timerx Repetition counter value


\
\ @brief Timerx Compare 1 Register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIME_CMP1ER_CMP1X                          \ Timerx Compare 1 value


\
\ @brief Timerx Compare 1 Compound Register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIME_CMP1CER_CMP1X                         \ Timerx Compare 1 value
$00ff0000 constant HRTIM_TIME_CMP1CER_REPX                          \ Timerx Repetition value (aliased from HRTIM_REPx register)


\
\ @brief Timerx Compare 2 Register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIME_CMP2ER_CMP2X                          \ Timerx Compare 2 value


\
\ @brief Timerx Compare 3 Register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIME_CMP3ER_CMP3X                          \ Timerx Compare 3 value


\
\ @brief Timerx Compare 4 Register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIME_CMP4ER_CMP4X                          \ Timerx Compare 4 value


\
\ @brief Timerx Capture 1 Register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIME_CPT1ER_CPT1X                          \ Timerx Capture 1 value


\
\ @brief Timerx Capture 2 Register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIME_CPT2ER_CPT2X                          \ Timerx Capture 2 value


\
\ @brief Timerx Deadtime Register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000001ff constant HRTIM_TIME_DTER_DTRX                             \ Deadtime Rising value
$00000200 constant HRTIM_TIME_DTER_SDTRX                            \ Sign Deadtime Rising value
$00001c00 constant HRTIM_TIME_DTER_DTPRSC                           \ Deadtime Prescaler
$00004000 constant HRTIM_TIME_DTER_DTRSLKX                          \ Deadtime Rising Sign Lock
$00008000 constant HRTIM_TIME_DTER_DTRLKX                           \ Deadtime Rising Lock
$01ff0000 constant HRTIM_TIME_DTER_DTFX                             \ Deadtime Falling value
$02000000 constant HRTIM_TIME_DTER_SDTFX                            \ Sign Deadtime Falling value
$40000000 constant HRTIM_TIME_DTER_DTFSLKX                          \ Deadtime Falling Sign Lock
$80000000 constant HRTIM_TIME_DTER_DTFLKX                           \ Deadtime Falling Lock


\
\ @brief Timerx Output1 Set Register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIME_SETE1R_SST                            \ Software Set trigger
$00000002 constant HRTIM_TIME_SETE1R_RESYNC                         \ Timer A resynchronizaton
$00000004 constant HRTIM_TIME_SETE1R_PER                            \ Timer A Period
$00000008 constant HRTIM_TIME_SETE1R_CMP1                           \ Timer A compare 1
$00000010 constant HRTIM_TIME_SETE1R_CMP2                           \ Timer A compare 2
$00000020 constant HRTIM_TIME_SETE1R_CMP3                           \ Timer A compare 3
$00000040 constant HRTIM_TIME_SETE1R_CMP4                           \ Timer A compare 4
$00000080 constant HRTIM_TIME_SETE1R_MSTPER                         \ Master Period
$00000100 constant HRTIM_TIME_SETE1R_MSTCMP1                        \ Master Compare 1
$00000200 constant HRTIM_TIME_SETE1R_MSTCMP2                        \ Master Compare 2
$00000400 constant HRTIM_TIME_SETE1R_MSTCMP3                        \ Master Compare 3
$00000800 constant HRTIM_TIME_SETE1R_MSTCMP4                        \ Master Compare 4
$00001000 constant HRTIM_TIME_SETE1R_TIMEVNT1                       \ Timer Event 1
$00002000 constant HRTIM_TIME_SETE1R_TIMEVNT2                       \ Timer Event 2
$00004000 constant HRTIM_TIME_SETE1R_TIMEVNT3                       \ Timer Event 3
$00008000 constant HRTIM_TIME_SETE1R_TIMEVNT4                       \ Timer Event 4
$00010000 constant HRTIM_TIME_SETE1R_TIMEVNT5                       \ Timer Event 5
$00020000 constant HRTIM_TIME_SETE1R_TIMEVNT6                       \ Timer Event 6
$00040000 constant HRTIM_TIME_SETE1R_TIMEVNT7                       \ Timer Event 7
$00080000 constant HRTIM_TIME_SETE1R_TIMEVNT8                       \ Timer Event 8
$00100000 constant HRTIM_TIME_SETE1R_TIMEVNT9                       \ Timer Event 9
$00200000 constant HRTIM_TIME_SETE1R_EXTEVNT1                       \ External Event 1
$00400000 constant HRTIM_TIME_SETE1R_EXTEVNT2                       \ External Event 2
$00800000 constant HRTIM_TIME_SETE1R_EXTEVNT3                       \ External Event 3
$01000000 constant HRTIM_TIME_SETE1R_EXTEVNT4                       \ External Event 4
$02000000 constant HRTIM_TIME_SETE1R_EXTEVNT5                       \ External Event 5
$04000000 constant HRTIM_TIME_SETE1R_EXTEVNT6                       \ External Event 6
$08000000 constant HRTIM_TIME_SETE1R_EXTEVNT7                       \ External Event 7
$10000000 constant HRTIM_TIME_SETE1R_EXTEVNT8                       \ External Event 8
$20000000 constant HRTIM_TIME_SETE1R_EXTEVNT9                       \ External Event 9
$40000000 constant HRTIM_TIME_SETE1R_EXTEVNT10                      \ External Event 10
$80000000 constant HRTIM_TIME_SETE1R_UPDATE                         \ Registers update (transfer preload to active)


\
\ @brief Timerx Output1 Reset Register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIME_RSTE1R_SRT                            \ SRT
$00000002 constant HRTIM_TIME_RSTE1R_RESYNC                         \ RESYNC
$00000004 constant HRTIM_TIME_RSTE1R_PER                            \ PER
$00000008 constant HRTIM_TIME_RSTE1R_CMP1                           \ CMP1
$00000010 constant HRTIM_TIME_RSTE1R_CMP2                           \ CMP2
$00000020 constant HRTIM_TIME_RSTE1R_CMP3                           \ CMP3
$00000040 constant HRTIM_TIME_RSTE1R_CMP4                           \ CMP4
$00000080 constant HRTIM_TIME_RSTE1R_MSTPER                         \ MSTPER
$00000100 constant HRTIM_TIME_RSTE1R_MSTCMP1                        \ MSTCMP1
$00000200 constant HRTIM_TIME_RSTE1R_MSTCMP2                        \ MSTCMP2
$00000400 constant HRTIM_TIME_RSTE1R_MSTCMP3                        \ MSTCMP3
$00000800 constant HRTIM_TIME_RSTE1R_MSTCMP4                        \ MSTCMP4
$00001000 constant HRTIM_TIME_RSTE1R_TIMEVNT1                       \ TIMEVNT1
$00002000 constant HRTIM_TIME_RSTE1R_TIMEVNT2                       \ TIMEVNT2
$00004000 constant HRTIM_TIME_RSTE1R_TIMEVNT3                       \ TIMEVNT3
$00008000 constant HRTIM_TIME_RSTE1R_TIMEVNT4                       \ TIMEVNT4
$00010000 constant HRTIM_TIME_RSTE1R_TIMEVNT5                       \ TIMEVNT5
$00020000 constant HRTIM_TIME_RSTE1R_TIMEVNT6                       \ TIMEVNT6
$00040000 constant HRTIM_TIME_RSTE1R_TIMEVNT7                       \ TIMEVNT7
$00080000 constant HRTIM_TIME_RSTE1R_TIMEVNT8                       \ TIMEVNT8
$00100000 constant HRTIM_TIME_RSTE1R_TIMEVNT9                       \ TIMEVNT9
$00200000 constant HRTIM_TIME_RSTE1R_EXTEVNT1                       \ EXTEVNT1
$00400000 constant HRTIM_TIME_RSTE1R_EXTEVNT2                       \ EXTEVNT2
$00800000 constant HRTIM_TIME_RSTE1R_EXTEVNT3                       \ EXTEVNT3
$01000000 constant HRTIM_TIME_RSTE1R_EXTEVNT4                       \ EXTEVNT4
$02000000 constant HRTIM_TIME_RSTE1R_EXTEVNT5                       \ EXTEVNT5
$04000000 constant HRTIM_TIME_RSTE1R_EXTEVNT6                       \ EXTEVNT6
$08000000 constant HRTIM_TIME_RSTE1R_EXTEVNT7                       \ EXTEVNT7
$10000000 constant HRTIM_TIME_RSTE1R_EXTEVNT8                       \ EXTEVNT8
$20000000 constant HRTIM_TIME_RSTE1R_EXTEVNT9                       \ EXTEVNT9
$40000000 constant HRTIM_TIME_RSTE1R_EXTEVNT10                      \ EXTEVNT10
$80000000 constant HRTIM_TIME_RSTE1R_UPDATE                         \ UPDATE


\
\ @brief Timerx Output2 Set Register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIME_SETE2R_SST                            \ SST
$00000002 constant HRTIM_TIME_SETE2R_RESYNC                         \ RESYNC
$00000004 constant HRTIM_TIME_SETE2R_PER                            \ PER
$00000008 constant HRTIM_TIME_SETE2R_CMP1                           \ CMP1
$00000010 constant HRTIM_TIME_SETE2R_CMP2                           \ CMP2
$00000020 constant HRTIM_TIME_SETE2R_CMP3                           \ CMP3
$00000040 constant HRTIM_TIME_SETE2R_CMP4                           \ CMP4
$00000080 constant HRTIM_TIME_SETE2R_MSTPER                         \ MSTPER
$00000100 constant HRTIM_TIME_SETE2R_MSTCMP1                        \ MSTCMP1
$00000200 constant HRTIM_TIME_SETE2R_MSTCMP2                        \ MSTCMP2
$00000400 constant HRTIM_TIME_SETE2R_MSTCMP3                        \ MSTCMP3
$00000800 constant HRTIM_TIME_SETE2R_MSTCMP4                        \ MSTCMP4
$00001000 constant HRTIM_TIME_SETE2R_TIMEVNT1                       \ TIMEVNT1
$00002000 constant HRTIM_TIME_SETE2R_TIMEVNT2                       \ TIMEVNT2
$00004000 constant HRTIM_TIME_SETE2R_TIMEVNT3                       \ TIMEVNT3
$00008000 constant HRTIM_TIME_SETE2R_TIMEVNT4                       \ TIMEVNT4
$00010000 constant HRTIM_TIME_SETE2R_TIMEVNT5                       \ TIMEVNT5
$00020000 constant HRTIM_TIME_SETE2R_TIMEVNT6                       \ TIMEVNT6
$00040000 constant HRTIM_TIME_SETE2R_TIMEVNT7                       \ TIMEVNT7
$00080000 constant HRTIM_TIME_SETE2R_TIMEVNT8                       \ TIMEVNT8
$00100000 constant HRTIM_TIME_SETE2R_TIMEVNT9                       \ TIMEVNT9
$00200000 constant HRTIM_TIME_SETE2R_EXTEVNT1                       \ EXTEVNT1
$00400000 constant HRTIM_TIME_SETE2R_EXTEVNT2                       \ EXTEVNT2
$00800000 constant HRTIM_TIME_SETE2R_EXTEVNT3                       \ EXTEVNT3
$01000000 constant HRTIM_TIME_SETE2R_EXTEVNT4                       \ EXTEVNT4
$02000000 constant HRTIM_TIME_SETE2R_EXTEVNT5                       \ EXTEVNT5
$04000000 constant HRTIM_TIME_SETE2R_EXTEVNT6                       \ EXTEVNT6
$08000000 constant HRTIM_TIME_SETE2R_EXTEVNT7                       \ EXTEVNT7
$10000000 constant HRTIM_TIME_SETE2R_EXTEVNT8                       \ EXTEVNT8
$20000000 constant HRTIM_TIME_SETE2R_EXTEVNT9                       \ EXTEVNT9
$40000000 constant HRTIM_TIME_SETE2R_EXTEVNT10                      \ EXTEVNT10
$80000000 constant HRTIM_TIME_SETE2R_UPDATE                         \ UPDATE


\
\ @brief Timerx Output2 Reset Register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIME_RSTE2R_SRT                            \ SRT
$00000002 constant HRTIM_TIME_RSTE2R_RESYNC                         \ RESYNC
$00000004 constant HRTIM_TIME_RSTE2R_PER                            \ PER
$00000008 constant HRTIM_TIME_RSTE2R_CMP1                           \ CMP1
$00000010 constant HRTIM_TIME_RSTE2R_CMP2                           \ CMP2
$00000020 constant HRTIM_TIME_RSTE2R_CMP3                           \ CMP3
$00000040 constant HRTIM_TIME_RSTE2R_CMP4                           \ CMP4
$00000080 constant HRTIM_TIME_RSTE2R_MSTPER                         \ MSTPER
$00000100 constant HRTIM_TIME_RSTE2R_MSTCMP1                        \ MSTCMP1
$00000200 constant HRTIM_TIME_RSTE2R_MSTCMP2                        \ MSTCMP2
$00000400 constant HRTIM_TIME_RSTE2R_MSTCMP3                        \ MSTCMP3
$00000800 constant HRTIM_TIME_RSTE2R_MSTCMP4                        \ MSTCMP4
$00001000 constant HRTIM_TIME_RSTE2R_TIMEVNT1                       \ TIMEVNT1
$00002000 constant HRTIM_TIME_RSTE2R_TIMEVNT2                       \ TIMEVNT2
$00004000 constant HRTIM_TIME_RSTE2R_TIMEVNT3                       \ TIMEVNT3
$00008000 constant HRTIM_TIME_RSTE2R_TIMEVNT4                       \ TIMEVNT4
$00010000 constant HRTIM_TIME_RSTE2R_TIMEVNT5                       \ TIMEVNT5
$00020000 constant HRTIM_TIME_RSTE2R_TIMEVNT6                       \ TIMEVNT6
$00040000 constant HRTIM_TIME_RSTE2R_TIMEVNT7                       \ TIMEVNT7
$00080000 constant HRTIM_TIME_RSTE2R_TIMEVNT8                       \ TIMEVNT8
$00100000 constant HRTIM_TIME_RSTE2R_TIMEVNT9                       \ TIMEVNT9
$00200000 constant HRTIM_TIME_RSTE2R_EXTEVNT1                       \ EXTEVNT1
$00400000 constant HRTIM_TIME_RSTE2R_EXTEVNT2                       \ EXTEVNT2
$00800000 constant HRTIM_TIME_RSTE2R_EXTEVNT3                       \ EXTEVNT3
$01000000 constant HRTIM_TIME_RSTE2R_EXTEVNT4                       \ EXTEVNT4
$02000000 constant HRTIM_TIME_RSTE2R_EXTEVNT5                       \ EXTEVNT5
$04000000 constant HRTIM_TIME_RSTE2R_EXTEVNT6                       \ EXTEVNT6
$08000000 constant HRTIM_TIME_RSTE2R_EXTEVNT7                       \ EXTEVNT7
$10000000 constant HRTIM_TIME_RSTE2R_EXTEVNT8                       \ EXTEVNT8
$20000000 constant HRTIM_TIME_RSTE2R_EXTEVNT9                       \ EXTEVNT9
$40000000 constant HRTIM_TIME_RSTE2R_EXTEVNT10                      \ EXTEVNT10
$80000000 constant HRTIM_TIME_RSTE2R_UPDATE                         \ UPDATE


\
\ @brief Timerx External Event Filtering Register 1
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIME_EEFER1_EE1LTCH                        \ External Event 1 latch
$0000001e constant HRTIM_TIME_EEFER1_EE1FLTR                        \ External Event 1 filter
$00000040 constant HRTIM_TIME_EEFER1_EE2LTCH                        \ External Event 2 latch
$00000780 constant HRTIM_TIME_EEFER1_EE2FLTR                        \ External Event 2 filter
$00001000 constant HRTIM_TIME_EEFER1_EE3LTCH                        \ External Event 3 latch
$0001e000 constant HRTIM_TIME_EEFER1_EE3FLTR                        \ External Event 3 filter
$00040000 constant HRTIM_TIME_EEFER1_EE4LTCH                        \ External Event 4 latch
$00780000 constant HRTIM_TIME_EEFER1_EE4FLTR                        \ External Event 4 filter
$01000000 constant HRTIM_TIME_EEFER1_EE5LTCH                        \ External Event 5 latch
$1e000000 constant HRTIM_TIME_EEFER1_EE5FLTR                        \ External Event 5 filter


\
\ @brief Timerx External Event Filtering Register 2
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIME_EEFER2_EE6LTCH                        \ External Event 6 latch
$0000001e constant HRTIM_TIME_EEFER2_EE6FLTR                        \ External Event 6 filter
$00000040 constant HRTIM_TIME_EEFER2_EE7LTCH                        \ External Event 7 latch
$00000780 constant HRTIM_TIME_EEFER2_EE7FLTR                        \ External Event 7 filter
$00001000 constant HRTIM_TIME_EEFER2_EE8LTCH                        \ External Event 8 latch
$0001e000 constant HRTIM_TIME_EEFER2_EE8FLTR                        \ External Event 8 filter
$00040000 constant HRTIM_TIME_EEFER2_EE9LTCH                        \ External Event 9 latch
$00780000 constant HRTIM_TIME_EEFER2_EE9FLTR                        \ External Event 9 filter
$01000000 constant HRTIM_TIME_EEFER2_EE10LTCH                       \ External Event 10 latch
$1e000000 constant HRTIM_TIME_EEFER2_EE10FLTR                       \ External Event 10 filter


\
\ @brief TimerA Reset Register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000002 constant HRTIM_TIME_RSTER_UPDT                            \ Timer A Update reset
$00000004 constant HRTIM_TIME_RSTER_CMP2                            \ Timer A compare 2 reset
$00000008 constant HRTIM_TIME_RSTER_CMP4                            \ Timer A compare 4 reset
$00000010 constant HRTIM_TIME_RSTER_MSTPER                          \ Master timer Period
$00000020 constant HRTIM_TIME_RSTER_MSTCMP1                         \ Master compare 1
$00000040 constant HRTIM_TIME_RSTER_MSTCMP2                         \ Master compare 2
$00000080 constant HRTIM_TIME_RSTER_MSTCMP3                         \ Master compare 3
$00000100 constant HRTIM_TIME_RSTER_MSTCMP4                         \ Master compare 4
$00000200 constant HRTIM_TIME_RSTER_EXTEVNT1                        \ External Event 1
$00000400 constant HRTIM_TIME_RSTER_EXTEVNT2                        \ External Event 2
$00000800 constant HRTIM_TIME_RSTER_EXTEVNT3                        \ External Event 3
$00001000 constant HRTIM_TIME_RSTER_EXTEVNT4                        \ External Event 4
$00002000 constant HRTIM_TIME_RSTER_EXTEVNT5                        \ External Event 5
$00004000 constant HRTIM_TIME_RSTER_EXTEVNT6                        \ External Event 6
$00008000 constant HRTIM_TIME_RSTER_EXTEVNT7                        \ External Event 7
$00010000 constant HRTIM_TIME_RSTER_EXTEVNT8                        \ External Event 8
$00020000 constant HRTIM_TIME_RSTER_EXTEVNT9                        \ External Event 9
$00040000 constant HRTIM_TIME_RSTER_EXTEVNT10                       \ External Event 10
$00080000 constant HRTIM_TIME_RSTER_TIMACMP1                        \ Timer A Compare 1
$00100000 constant HRTIM_TIME_RSTER_TIMACMP2                        \ Timer A Compare 2
$00200000 constant HRTIM_TIME_RSTER_TIMACMP4                        \ Timer A Compare 4
$00400000 constant HRTIM_TIME_RSTER_TIMBCMP1                        \ Timer B Compare 1
$00800000 constant HRTIM_TIME_RSTER_TIMBCMP2                        \ Timer B Compare 2
$01000000 constant HRTIM_TIME_RSTER_TIMBCMP4                        \ Timer B Compare 4
$02000000 constant HRTIM_TIME_RSTER_TIMCCMP1                        \ Timer C Compare 1
$04000000 constant HRTIM_TIME_RSTER_TIMCCMP2                        \ Timer C Compare 2
$08000000 constant HRTIM_TIME_RSTER_TIMCCMP4                        \ Timer C Compare 4
$10000000 constant HRTIM_TIME_RSTER_TIMDCMP1                        \ Timer D Compare 1
$20000000 constant HRTIM_TIME_RSTER_TIMDCMP2                        \ Timer D Compare 2
$40000000 constant HRTIM_TIME_RSTER_TIMDCMP4                        \ Timer D Compare 4


\
\ @brief Timerx Chopper Register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$0000000f constant HRTIM_TIME_CHPER_CHPFRQ                          \ Timerx carrier frequency value
$00000070 constant HRTIM_TIME_CHPER_CHPDTY                          \ Timerx chopper duty cycle value
$00000780 constant HRTIM_TIME_CHPER_STRTPW                          \ STRTPW


\
\ @brief Timerx Capture 2 Control Register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIME_CPT1ECR_SWCPT                         \ Software Capture
$00000002 constant HRTIM_TIME_CPT1ECR_UDPCPT                        \ Update Capture
$00000004 constant HRTIM_TIME_CPT1ECR_EXEV1CPT                      \ External Event 1 Capture
$00000008 constant HRTIM_TIME_CPT1ECR_EXEV2CPT                      \ External Event 2 Capture
$00000010 constant HRTIM_TIME_CPT1ECR_EXEV3CPT                      \ External Event 3 Capture
$00000020 constant HRTIM_TIME_CPT1ECR_EXEV4CPT                      \ External Event 4 Capture
$00000040 constant HRTIM_TIME_CPT1ECR_EXEV5CPT                      \ External Event 5 Capture
$00000080 constant HRTIM_TIME_CPT1ECR_EXEV6CPT                      \ External Event 6 Capture
$00000100 constant HRTIM_TIME_CPT1ECR_EXEV7CPT                      \ External Event 7 Capture
$00000200 constant HRTIM_TIME_CPT1ECR_EXEV8CPT                      \ External Event 8 Capture
$00000400 constant HRTIM_TIME_CPT1ECR_EXEV9CPT                      \ External Event 9 Capture
$00000800 constant HRTIM_TIME_CPT1ECR_EXEV10CPT                     \ External Event 10 Capture
$00001000 constant HRTIM_TIME_CPT1ECR_TA1SET                        \ Timer A output 1 Set
$00002000 constant HRTIM_TIME_CPT1ECR_TA1RST                        \ Timer A output 1 Reset
$00004000 constant HRTIM_TIME_CPT1ECR_TACMP1                        \ Timer A Compare 1
$00008000 constant HRTIM_TIME_CPT1ECR_TACMP2                        \ Timer A Compare 2
$00010000 constant HRTIM_TIME_CPT1ECR_TB1SET                        \ Timer B output 1 Set
$00020000 constant HRTIM_TIME_CPT1ECR_TB1RST                        \ Timer B output 1 Reset
$00040000 constant HRTIM_TIME_CPT1ECR_TBCMP1                        \ Timer B Compare 1
$00080000 constant HRTIM_TIME_CPT1ECR_TBCMP2                        \ Timer B Compare 2
$00100000 constant HRTIM_TIME_CPT1ECR_TC1SET                        \ Timer C output 1 Set
$00200000 constant HRTIM_TIME_CPT1ECR_TC1RST                        \ Timer C output 1 Reset
$00400000 constant HRTIM_TIME_CPT1ECR_TCCMP1                        \ Timer C Compare 1
$00800000 constant HRTIM_TIME_CPT1ECR_TCCMP2                        \ Timer C Compare 2
$01000000 constant HRTIM_TIME_CPT1ECR_TD1SET                        \ Timer D output 1 Set
$02000000 constant HRTIM_TIME_CPT1ECR_TD1RST                        \ Timer D output 1 Reset
$04000000 constant HRTIM_TIME_CPT1ECR_TDCMP1                        \ Timer D Compare 1
$08000000 constant HRTIM_TIME_CPT1ECR_TDCMP2                        \ Timer D Compare 2


\
\ @brief CPT2xCR
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIME_CPT2ECR_SWCPT                         \ Software Capture
$00000002 constant HRTIM_TIME_CPT2ECR_UDPCPT                        \ Update Capture
$00000004 constant HRTIM_TIME_CPT2ECR_EXEV1CPT                      \ External Event 1 Capture
$00000008 constant HRTIM_TIME_CPT2ECR_EXEV2CPT                      \ External Event 2 Capture
$00000010 constant HRTIM_TIME_CPT2ECR_EXEV3CPT                      \ External Event 3 Capture
$00000020 constant HRTIM_TIME_CPT2ECR_EXEV4CPT                      \ External Event 4 Capture
$00000040 constant HRTIM_TIME_CPT2ECR_EXEV5CPT                      \ External Event 5 Capture
$00000080 constant HRTIM_TIME_CPT2ECR_EXEV6CPT                      \ External Event 6 Capture
$00000100 constant HRTIM_TIME_CPT2ECR_EXEV7CPT                      \ External Event 7 Capture
$00000200 constant HRTIM_TIME_CPT2ECR_EXEV8CPT                      \ External Event 8 Capture
$00000400 constant HRTIM_TIME_CPT2ECR_EXEV9CPT                      \ External Event 9 Capture
$00000800 constant HRTIM_TIME_CPT2ECR_EXEV10CPT                     \ External Event 10 Capture
$00001000 constant HRTIM_TIME_CPT2ECR_TA1SET                        \ Timer A output 1 Set
$00002000 constant HRTIM_TIME_CPT2ECR_TA1RST                        \ Timer A output 1 Reset
$00004000 constant HRTIM_TIME_CPT2ECR_TACMP1                        \ Timer A Compare 1
$00008000 constant HRTIM_TIME_CPT2ECR_TACMP2                        \ Timer A Compare 2
$00010000 constant HRTIM_TIME_CPT2ECR_TB1SET                        \ Timer B output 1 Set
$00020000 constant HRTIM_TIME_CPT2ECR_TB1RST                        \ Timer B output 1 Reset
$00040000 constant HRTIM_TIME_CPT2ECR_TBCMP1                        \ Timer B Compare 1
$00080000 constant HRTIM_TIME_CPT2ECR_TBCMP2                        \ Timer B Compare 2
$00100000 constant HRTIM_TIME_CPT2ECR_TC1SET                        \ Timer C output 1 Set
$00200000 constant HRTIM_TIME_CPT2ECR_TC1RST                        \ Timer C output 1 Reset
$00400000 constant HRTIM_TIME_CPT2ECR_TCCMP1                        \ Timer C Compare 1
$00800000 constant HRTIM_TIME_CPT2ECR_TCCMP2                        \ Timer C Compare 2
$01000000 constant HRTIM_TIME_CPT2ECR_TD1SET                        \ Timer D output 1 Set
$02000000 constant HRTIM_TIME_CPT2ECR_TD1RST                        \ Timer D output 1 Reset
$04000000 constant HRTIM_TIME_CPT2ECR_TDCMP1                        \ Timer D Compare 1
$08000000 constant HRTIM_TIME_CPT2ECR_TDCMP2                        \ Timer D Compare 2


\
\ @brief Timerx Output Register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000002 constant HRTIM_TIME_OUTER_POL1                            \ Output 1 polarity
$00000004 constant HRTIM_TIME_OUTER_IDLEM1                          \ Output 1 Idle mode
$00000008 constant HRTIM_TIME_OUTER_IDLES1                          \ Output 1 Idle State
$00000030 constant HRTIM_TIME_OUTER_FAULT1                          \ Output 1 Fault state
$00000040 constant HRTIM_TIME_OUTER_CHP1                            \ Output 1 Chopper enable
$00000080 constant HRTIM_TIME_OUTER_DIDL1                           \ Output 1 Deadtime upon burst mode Idle entry
$00000100 constant HRTIM_TIME_OUTER_DTEN                            \ Deadtime enable
$00000200 constant HRTIM_TIME_OUTER_DLYPRTEN                        \ Delayed Protection Enable
$00001c00 constant HRTIM_TIME_OUTER_DLYPRT                          \ Delayed Protection
$00020000 constant HRTIM_TIME_OUTER_POL2                            \ Output 2 polarity
$00040000 constant HRTIM_TIME_OUTER_IDLEM2                          \ Output 2 Idle mode
$00080000 constant HRTIM_TIME_OUTER_IDLES2                          \ Output 2 Idle State
$00300000 constant HRTIM_TIME_OUTER_FAULT2                          \ Output 2 Fault state
$00400000 constant HRTIM_TIME_OUTER_CHP2                            \ Output 2 Chopper enable
$00800000 constant HRTIM_TIME_OUTER_DIDL2                           \ Output 2 Deadtime upon burst mode Idle entry


\
\ @brief Timerx Fault Register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIME_FLTER_FLT1EN                          \ Fault 1 enable
$00000002 constant HRTIM_TIME_FLTER_FLT2EN                          \ Fault 2 enable
$00000004 constant HRTIM_TIME_FLTER_FLT3EN                          \ Fault 3 enable
$00000008 constant HRTIM_TIME_FLTER_FLT4EN                          \ Fault 4 enable
$00000010 constant HRTIM_TIME_FLTER_FLT5EN                          \ Fault 5 enable
$80000000 constant HRTIM_TIME_FLTER_FLTLCK                          \ Fault sources Lock


\
\ @brief High Resolution Timer: TIME
\
$40017680 constant HRTIM_TIME_TIMECR  \ offset: 0x00 : Timerx Control Register
$40017684 constant HRTIM_TIME_TIMEISR  \ offset: 0x04 : Timerx Interrupt Status Register
$40017688 constant HRTIM_TIME_TIMEICR  \ offset: 0x08 : Timerx Interrupt Clear Register
$4001768c constant HRTIM_TIME_TIMEDIER5  \ offset: 0x0C : TIMxDIER5
$40017690 constant HRTIM_TIME_CNTER  \ offset: 0x10 : Timerx Counter Register
$40017694 constant HRTIM_TIME_PERER  \ offset: 0x14 : Timerx Period Register
$40017698 constant HRTIM_TIME_REPER  \ offset: 0x18 : Timerx Repetition Register
$4001769c constant HRTIM_TIME_CMP1ER  \ offset: 0x1C : Timerx Compare 1 Register
$400176a0 constant HRTIM_TIME_CMP1CER  \ offset: 0x20 : Timerx Compare 1 Compound Register
$400176a4 constant HRTIM_TIME_CMP2ER  \ offset: 0x24 : Timerx Compare 2 Register
$400176a8 constant HRTIM_TIME_CMP3ER  \ offset: 0x28 : Timerx Compare 3 Register
$400176ac constant HRTIM_TIME_CMP4ER  \ offset: 0x2C : Timerx Compare 4 Register
$400176b0 constant HRTIM_TIME_CPT1ER  \ offset: 0x30 : Timerx Capture 1 Register
$400176b4 constant HRTIM_TIME_CPT2ER  \ offset: 0x34 : Timerx Capture 2 Register
$400176b8 constant HRTIM_TIME_DTER  \ offset: 0x38 : Timerx Deadtime Register
$400176bc constant HRTIM_TIME_SETE1R  \ offset: 0x3C : Timerx Output1 Set Register
$400176c0 constant HRTIM_TIME_RSTE1R  \ offset: 0x40 : Timerx Output1 Reset Register
$400176c4 constant HRTIM_TIME_SETE2R  \ offset: 0x44 : Timerx Output2 Set Register
$400176c8 constant HRTIM_TIME_RSTE2R  \ offset: 0x48 : Timerx Output2 Reset Register
$400176cc constant HRTIM_TIME_EEFER1  \ offset: 0x4C : Timerx External Event Filtering Register 1
$400176d0 constant HRTIM_TIME_EEFER2  \ offset: 0x50 : Timerx External Event Filtering Register 2
$400176d4 constant HRTIM_TIME_RSTER  \ offset: 0x54 : TimerA Reset Register
$400176d8 constant HRTIM_TIME_CHPER  \ offset: 0x58 : Timerx Chopper Register
$400176dc constant HRTIM_TIME_CPT1ECR  \ offset: 0x5C : Timerx Capture 2 Control Register
$400176e0 constant HRTIM_TIME_CPT2ECR  \ offset: 0x60 : CPT2xCR
$400176e4 constant HRTIM_TIME_OUTER  \ offset: 0x64 : Timerx Output Register
$400176e8 constant HRTIM_TIME_FLTER  \ offset: 0x68 : Timerx Fault Register

