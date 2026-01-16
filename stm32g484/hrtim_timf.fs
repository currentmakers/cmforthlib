\
\ @file hrtim_timf.fs
\ @brief High Resolution Timer: TIMF
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

$00000007 constant HRTIM_TIMF_TIMFCR_CK_PSCX                        \ HRTIM Timer x Clock prescaler
$00000008 constant HRTIM_TIMF_TIMFCR_CONT                           \ Continuous mode
$00000010 constant HRTIM_TIMF_TIMFCR_RETRIG                         \ Re-triggerable mode
$00000020 constant HRTIM_TIMF_TIMFCR_HALF                           \ Half mode enable
$00000040 constant HRTIM_TIMF_TIMFCR_PSHPLL                         \ Push-Pull mode enable
$00000180 constant HRTIM_TIMF_TIMFCR_INTLVD                         \ Interleaved mode
$00000200 constant HRTIM_TIMF_TIMFCR_RSYNCU                         \ Re-Synchronized Update
$00000400 constant HRTIM_TIMF_TIMFCR_SYNCRSTX                       \ Synchronization Resets Timer x
$00000800 constant HRTIM_TIMF_TIMFCR_SYNCSTRTX                      \ Synchronization Starts Timer x
$00003000 constant HRTIM_TIMF_TIMFCR_DELCMP2                        \ Delayed CMP2 mode
$0000c000 constant HRTIM_TIMF_TIMFCR_DELCMP4                        \ Delayed CMP4 mode
$00020000 constant HRTIM_TIMF_TIMFCR_TXREPU                         \ Timer x Repetition update
$00040000 constant HRTIM_TIMF_TIMFCR_TXRSTU                         \ Timerx reset update
$00080000 constant HRTIM_TIMF_TIMFCR_TAU                            \ TAU
$00100000 constant HRTIM_TIMF_TIMFCR_TBU                            \ TBU
$00200000 constant HRTIM_TIMF_TIMFCR_TCU                            \ TCU
$00400000 constant HRTIM_TIMF_TIMFCR_TDU                            \ TDU
$01000000 constant HRTIM_TIMF_TIMFCR_MSTU                           \ Master Timer update
$06000000 constant HRTIM_TIMF_TIMFCR_DACSYNC                        \ AC Synchronization
$08000000 constant HRTIM_TIMF_TIMFCR_PREEN                          \ Preload enable
$f0000000 constant HRTIM_TIMF_TIMFCR_UPDGAT                         \ Update Gating


\
\ @brief Timerx Interrupt Status Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMF_TIMFISR_CMP1                          \ Compare 1 Interrupt Flag
$00000002 constant HRTIM_TIMF_TIMFISR_CMP2                          \ Compare 2 Interrupt Flag
$00000004 constant HRTIM_TIMF_TIMFISR_CMP3                          \ Compare 3 Interrupt Flag
$00000008 constant HRTIM_TIMF_TIMFISR_CMP4                          \ Compare 4 Interrupt Flag
$00000010 constant HRTIM_TIMF_TIMFISR_REP                           \ Repetition Interrupt Flag
$00000040 constant HRTIM_TIMF_TIMFISR_UPD                           \ Update Interrupt Flag
$00000080 constant HRTIM_TIMF_TIMFISR_CPT1                          \ Capture1 Interrupt Flag
$00000100 constant HRTIM_TIMF_TIMFISR_CPT2                          \ Capture2 Interrupt Flag
$00000200 constant HRTIM_TIMF_TIMFISR_SETX1                         \ Output 1 Set Interrupt Flag
$00000400 constant HRTIM_TIMF_TIMFISR_RSTX1                         \ Output 1 Reset Interrupt Flag
$00000800 constant HRTIM_TIMF_TIMFISR_SETX2                         \ Output 2 Set Interrupt Flag
$00001000 constant HRTIM_TIMF_TIMFISR_RSTX2                         \ Output 2 Reset Interrupt Flag
$00002000 constant HRTIM_TIMF_TIMFISR_RST                           \ Reset Interrupt Flag
$00004000 constant HRTIM_TIMF_TIMFISR_DLYPRT                        \ Delayed Protection Flag
$00010000 constant HRTIM_TIMF_TIMFISR_CPPSTAT                       \ Current Push Pull Status
$00020000 constant HRTIM_TIMF_TIMFISR_IPPSTAT                       \ Idle Push Pull Status
$00040000 constant HRTIM_TIMF_TIMFISR_O1STAT                        \ Output 1 State
$00080000 constant HRTIM_TIMF_TIMFISR_O2STAT                        \ Output 2 State
$00100000 constant HRTIM_TIMF_TIMFISR_O1CPY                         \ Output 1 Copy
$00200000 constant HRTIM_TIMF_TIMFISR_O2CPY                         \ Output 2 Copy


\
\ @brief Timerx Interrupt Clear Register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMF_TIMFICR_CMP1C                         \ Compare 1 Interrupt flag Clear
$00000002 constant HRTIM_TIMF_TIMFICR_CMP2C                         \ Compare 2 Interrupt flag Clear
$00000004 constant HRTIM_TIMF_TIMFICR_CMP3C                         \ Compare 3 Interrupt flag Clear
$00000008 constant HRTIM_TIMF_TIMFICR_CMP4C                         \ Compare 4 Interrupt flag Clear
$00000010 constant HRTIM_TIMF_TIMFICR_REPC                          \ Repetition Interrupt flag Clear
$00000040 constant HRTIM_TIMF_TIMFICR_UPDC                          \ Update Interrupt flag Clear
$00000080 constant HRTIM_TIMF_TIMFICR_CPT1C                         \ Capture1 Interrupt flag Clear
$00000100 constant HRTIM_TIMF_TIMFICR_CPT2C                         \ Capture2 Interrupt flag Clear
$00000200 constant HRTIM_TIMF_TIMFICR_SET1XC                        \ Output 1 Set flag Clear
$00000400 constant HRTIM_TIMF_TIMFICR_RSTX1C                        \ Output 1 Reset flag Clear
$00000800 constant HRTIM_TIMF_TIMFICR_SET2XC                        \ Output 2 Set flag Clear
$00001000 constant HRTIM_TIMF_TIMFICR_RSTX2C                        \ Output 2 Reset flag Clear
$00002000 constant HRTIM_TIMF_TIMFICR_RSTC                          \ Reset Interrupt flag Clear
$00004000 constant HRTIM_TIMF_TIMFICR_DLYPRTC                       \ Delayed Protection Flag Clear


\
\ @brief TIMxDIER
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMF_TIMFDIER_CMP1IE                       \ CMP1IE
$00000002 constant HRTIM_TIMF_TIMFDIER_CMP2IE                       \ CMP2IE
$00000004 constant HRTIM_TIMF_TIMFDIER_CMP3IE                       \ CMP3IE
$00000008 constant HRTIM_TIMF_TIMFDIER_CMP4IE                       \ CMP4IE
$00000010 constant HRTIM_TIMF_TIMFDIER_REPIE                        \ REPIE
$00000040 constant HRTIM_TIMF_TIMFDIER_UPDIE                        \ UPDIE
$00000080 constant HRTIM_TIMF_TIMFDIER_CPT1IE                       \ CPT1IE
$00000100 constant HRTIM_TIMF_TIMFDIER_CPT2IE                       \ CPT2IE
$00000200 constant HRTIM_TIMF_TIMFDIER_SET1XIE                      \ SET1xIE
$00000400 constant HRTIM_TIMF_TIMFDIER_RSTX1IE                      \ RSTx1IE
$00000800 constant HRTIM_TIMF_TIMFDIER_SETX2IE                      \ SETx2IE
$00001000 constant HRTIM_TIMF_TIMFDIER_RSTX2IE                      \ RSTx2IE
$00002000 constant HRTIM_TIMF_TIMFDIER_RSTIE                        \ RSTIE
$00004000 constant HRTIM_TIMF_TIMFDIER_DLYPRTIE                     \ DLYPRTIE
$00010000 constant HRTIM_TIMF_TIMFDIER_CMP1DE                       \ CMP1DE
$00020000 constant HRTIM_TIMF_TIMFDIER_CMP2DE                       \ CMP2DE
$00040000 constant HRTIM_TIMF_TIMFDIER_CMP3DE                       \ CMP3DE
$00080000 constant HRTIM_TIMF_TIMFDIER_CMP4DE                       \ CMP4DE
$00100000 constant HRTIM_TIMF_TIMFDIER_REPDE                        \ REPDE
$00400000 constant HRTIM_TIMF_TIMFDIER_UPDDE                        \ UPDDE
$00800000 constant HRTIM_TIMF_TIMFDIER_CPT1DE                       \ CPT1DE
$01000000 constant HRTIM_TIMF_TIMFDIER_CPT2DE                       \ CPT2DE
$02000000 constant HRTIM_TIMF_TIMFDIER_SET1XDE                      \ SET1xDE
$04000000 constant HRTIM_TIMF_TIMFDIER_RSTX1DE                      \ RSTx1DE
$08000000 constant HRTIM_TIMF_TIMFDIER_SETX2DE                      \ SETx2DE
$10000000 constant HRTIM_TIMF_TIMFDIER_RSTX2DE                      \ RSTx2DE
$20000000 constant HRTIM_TIMF_TIMFDIER_RSTDE                        \ RSTDE
$40000000 constant HRTIM_TIMF_TIMFDIER_DLYPRTDE                     \ DLYPRTDE


\
\ @brief Timerx Counter Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMF_CNTFR_CNTX                            \ Timerx Counter value


\
\ @brief Timerx Period Register
\ Address offset: 0x14
\ Reset value: 0x0000FFFF
\

$0000ffff constant HRTIM_TIMF_PERFR_PERX                            \ Timerx Period value


\
\ @brief Timerx Repetition Register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant HRTIM_TIMF_REPFR_REPX                            \ Timerx Repetition counter value


\
\ @brief Timerx Compare 1 Register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMF_CMP1FR_CMP1X                          \ Timerx Compare 1 value


\
\ @brief Timerx Compare 1 Compound Register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMF_CMP1CFR_CMP1X                         \ Timerx Compare 1 value
$00ff0000 constant HRTIM_TIMF_CMP1CFR_REPX                          \ Timerx Repetition value (aliased from HRTIM_REPx register)


\
\ @brief Timerx Compare 2 Register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMF_CMP2FR_CMP2X                          \ Timerx Compare 2 value


\
\ @brief Timerx Compare 3 Register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMF_CMP3FR_CMP3X                          \ Timerx Compare 3 value


\
\ @brief Timerx Compare 4 Register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMF_CMP4FR_CMP4X                          \ Timerx Compare 4 value


\
\ @brief Timerx Capture 1 Register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMF_CPT1FR_CPT1X                          \ Timerx Capture 1 value
$00010000 constant HRTIM_TIMF_CPT1FR_DIR                            \ Timerx Capture 1 Direction status


\
\ @brief Timerx Capture 2 Register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMF_CPT2FR_CPT2X                          \ Timerx Capture 2 value
$00010000 constant HRTIM_TIMF_CPT2FR_DIR                            \ Timerx Capture 1 Direction status


\
\ @brief Timerx Deadtime Register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000001ff constant HRTIM_TIMF_DTFR_DTRX                             \ Deadtime Rising value
$00000200 constant HRTIM_TIMF_DTFR_SDTRX                            \ Sign Deadtime Rising value
$00001c00 constant HRTIM_TIMF_DTFR_DTPRSC                           \ Deadtime Prescaler
$00004000 constant HRTIM_TIMF_DTFR_DTRSLKX                          \ Deadtime Rising Sign Lock
$00008000 constant HRTIM_TIMF_DTFR_DTRLKX                           \ Deadtime Rising Lock
$01ff0000 constant HRTIM_TIMF_DTFR_DTFX                             \ Deadtime Falling value
$02000000 constant HRTIM_TIMF_DTFR_SDTFX                            \ Sign Deadtime Falling value
$40000000 constant HRTIM_TIMF_DTFR_DTFSLKX                          \ Deadtime Falling Sign Lock
$80000000 constant HRTIM_TIMF_DTFR_DTFLKX                           \ Deadtime Falling Lock


\
\ @brief Timerx Output1 Set Register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMF_SETF1R_SST                            \ Software Set trigger
$00000002 constant HRTIM_TIMF_SETF1R_RESYNC                         \ Timer A resynchronizaton
$00000004 constant HRTIM_TIMF_SETF1R_PER                            \ Timer A Period
$00000008 constant HRTIM_TIMF_SETF1R_CMP1                           \ Timer A compare 1
$00000010 constant HRTIM_TIMF_SETF1R_CMP2                           \ Timer A compare 2
$00000020 constant HRTIM_TIMF_SETF1R_CMP3                           \ Timer A compare 3
$00000040 constant HRTIM_TIMF_SETF1R_CMP4                           \ Timer A compare 4
$00000080 constant HRTIM_TIMF_SETF1R_MSTPER                         \ Master Period
$00000100 constant HRTIM_TIMF_SETF1R_MSTCMP1                        \ Master Compare 1
$00000200 constant HRTIM_TIMF_SETF1R_MSTCMP2                        \ Master Compare 2
$00000400 constant HRTIM_TIMF_SETF1R_MSTCMP3                        \ Master Compare 3
$00000800 constant HRTIM_TIMF_SETF1R_MSTCMP4                        \ Master Compare 4
$00001000 constant HRTIM_TIMF_SETF1R_TIMEVNT1                       \ Timer Event 1
$00002000 constant HRTIM_TIMF_SETF1R_TIMEVNT2                       \ Timer Event 2
$00004000 constant HRTIM_TIMF_SETF1R_TIMEVNT3                       \ Timer Event 3
$00008000 constant HRTIM_TIMF_SETF1R_TIMEVNT4                       \ Timer Event 4
$00010000 constant HRTIM_TIMF_SETF1R_TIMEVNT5                       \ Timer Event 5
$00020000 constant HRTIM_TIMF_SETF1R_TIMEVNT6                       \ Timer Event 6
$00040000 constant HRTIM_TIMF_SETF1R_TIMEVNT7                       \ Timer Event 7
$00080000 constant HRTIM_TIMF_SETF1R_TIMEVNT8                       \ Timer Event 8
$00100000 constant HRTIM_TIMF_SETF1R_TIMEVNT9                       \ Timer Event 9
$00200000 constant HRTIM_TIMF_SETF1R_EXTEVNT1                       \ External Event 1
$00400000 constant HRTIM_TIMF_SETF1R_EXTEVNT2                       \ External Event 2
$00800000 constant HRTIM_TIMF_SETF1R_EXTEVNT3                       \ External Event 3
$01000000 constant HRTIM_TIMF_SETF1R_EXTEVNT4                       \ External Event 4
$02000000 constant HRTIM_TIMF_SETF1R_EXTEVNT5                       \ External Event 5
$04000000 constant HRTIM_TIMF_SETF1R_EXTEVNT6                       \ External Event 6
$08000000 constant HRTIM_TIMF_SETF1R_EXTEVNT7                       \ External Event 7
$10000000 constant HRTIM_TIMF_SETF1R_EXTEVNT8                       \ External Event 8
$20000000 constant HRTIM_TIMF_SETF1R_EXTEVNT9                       \ External Event 9
$40000000 constant HRTIM_TIMF_SETF1R_EXTEVNT10                      \ External Event 10
$80000000 constant HRTIM_TIMF_SETF1R_UPDATE                         \ Registers update (transfer preload to active)


\
\ @brief Timerx Output1 Reset Register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMF_RSTE1R_SRT                            \ SRT
$00000002 constant HRTIM_TIMF_RSTE1R_RESYNC                         \ RESYNC
$00000004 constant HRTIM_TIMF_RSTE1R_PER                            \ PER
$00000008 constant HRTIM_TIMF_RSTE1R_CMP1                           \ CMP1
$00000010 constant HRTIM_TIMF_RSTE1R_CMP2                           \ CMP2
$00000020 constant HRTIM_TIMF_RSTE1R_CMP3                           \ CMP3
$00000040 constant HRTIM_TIMF_RSTE1R_CMP4                           \ CMP4
$00000080 constant HRTIM_TIMF_RSTE1R_MSTPER                         \ MSTPER
$00000100 constant HRTIM_TIMF_RSTE1R_MSTCMP1                        \ MSTCMP1
$00000200 constant HRTIM_TIMF_RSTE1R_MSTCMP2                        \ MSTCMP2
$00000400 constant HRTIM_TIMF_RSTE1R_MSTCMP3                        \ MSTCMP3
$00000800 constant HRTIM_TIMF_RSTE1R_MSTCMP4                        \ MSTCMP4
$00001000 constant HRTIM_TIMF_RSTE1R_TIMEVNT1                       \ TIMEVNT1
$00002000 constant HRTIM_TIMF_RSTE1R_TIMEVNT2                       \ TIMEVNT2
$00004000 constant HRTIM_TIMF_RSTE1R_TIMEVNT3                       \ TIMEVNT3
$00008000 constant HRTIM_TIMF_RSTE1R_TIMEVNT4                       \ TIMEVNT4
$00010000 constant HRTIM_TIMF_RSTE1R_TIMEVNT5                       \ TIMEVNT5
$00020000 constant HRTIM_TIMF_RSTE1R_TIMEVNT6                       \ TIMEVNT6
$00040000 constant HRTIM_TIMF_RSTE1R_TIMEVNT7                       \ TIMEVNT7
$00080000 constant HRTIM_TIMF_RSTE1R_TIMEVNT8                       \ TIMEVNT8
$00100000 constant HRTIM_TIMF_RSTE1R_TIMEVNT9                       \ TIMEVNT9
$00200000 constant HRTIM_TIMF_RSTE1R_EXTEVNT1                       \ EXTEVNT1
$00400000 constant HRTIM_TIMF_RSTE1R_EXTEVNT2                       \ EXTEVNT2
$00800000 constant HRTIM_TIMF_RSTE1R_EXTEVNT3                       \ EXTEVNT3
$01000000 constant HRTIM_TIMF_RSTE1R_EXTEVNT4                       \ EXTEVNT4
$02000000 constant HRTIM_TIMF_RSTE1R_EXTEVNT5                       \ EXTEVNT5
$04000000 constant HRTIM_TIMF_RSTE1R_EXTEVNT6                       \ EXTEVNT6
$08000000 constant HRTIM_TIMF_RSTE1R_EXTEVNT7                       \ EXTEVNT7
$10000000 constant HRTIM_TIMF_RSTE1R_EXTEVNT8                       \ EXTEVNT8
$20000000 constant HRTIM_TIMF_RSTE1R_EXTEVNT9                       \ EXTEVNT9
$40000000 constant HRTIM_TIMF_RSTE1R_EXTEVNT10                      \ EXTEVNT10
$80000000 constant HRTIM_TIMF_RSTE1R_UPDATE                         \ UPDATE


\
\ @brief Timerx Output2 Set Register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMF_SETF2R_SST                            \ SST
$00000002 constant HRTIM_TIMF_SETF2R_RESYNC                         \ RESYNC
$00000004 constant HRTIM_TIMF_SETF2R_PER                            \ PER
$00000008 constant HRTIM_TIMF_SETF2R_CMP1                           \ CMP1
$00000010 constant HRTIM_TIMF_SETF2R_CMP2                           \ CMP2
$00000020 constant HRTIM_TIMF_SETF2R_CMP3                           \ CMP3
$00000040 constant HRTIM_TIMF_SETF2R_CMP4                           \ CMP4
$00000080 constant HRTIM_TIMF_SETF2R_MSTPER                         \ MSTPER
$00000100 constant HRTIM_TIMF_SETF2R_MSTCMP1                        \ MSTCMP1
$00000200 constant HRTIM_TIMF_SETF2R_MSTCMP2                        \ MSTCMP2
$00000400 constant HRTIM_TIMF_SETF2R_MSTCMP3                        \ MSTCMP3
$00000800 constant HRTIM_TIMF_SETF2R_MSTCMP4                        \ MSTCMP4
$00001000 constant HRTIM_TIMF_SETF2R_TIMEVNT1                       \ TIMEVNT1
$00002000 constant HRTIM_TIMF_SETF2R_TIMEVNT2                       \ TIMEVNT2
$00004000 constant HRTIM_TIMF_SETF2R_TIMEVNT3                       \ TIMEVNT3
$00008000 constant HRTIM_TIMF_SETF2R_TIMEVNT4                       \ TIMEVNT4
$00010000 constant HRTIM_TIMF_SETF2R_TIMEVNT5                       \ TIMEVNT5
$00020000 constant HRTIM_TIMF_SETF2R_TIMEVNT6                       \ TIMEVNT6
$00040000 constant HRTIM_TIMF_SETF2R_TIMEVNT7                       \ TIMEVNT7
$00080000 constant HRTIM_TIMF_SETF2R_TIMEVNT8                       \ TIMEVNT8
$00100000 constant HRTIM_TIMF_SETF2R_TIMEVNT9                       \ TIMEVNT9
$00200000 constant HRTIM_TIMF_SETF2R_EXTEVNT1                       \ EXTEVNT1
$00400000 constant HRTIM_TIMF_SETF2R_EXTEVNT2                       \ EXTEVNT2
$00800000 constant HRTIM_TIMF_SETF2R_EXTEVNT3                       \ EXTEVNT3
$01000000 constant HRTIM_TIMF_SETF2R_EXTEVNT4                       \ EXTEVNT4
$02000000 constant HRTIM_TIMF_SETF2R_EXTEVNT5                       \ EXTEVNT5
$04000000 constant HRTIM_TIMF_SETF2R_EXTEVNT6                       \ EXTEVNT6
$08000000 constant HRTIM_TIMF_SETF2R_EXTEVNT7                       \ EXTEVNT7
$10000000 constant HRTIM_TIMF_SETF2R_EXTEVNT8                       \ EXTEVNT8
$20000000 constant HRTIM_TIMF_SETF2R_EXTEVNT9                       \ EXTEVNT9
$40000000 constant HRTIM_TIMF_SETF2R_EXTEVNT10                      \ EXTEVNT10
$80000000 constant HRTIM_TIMF_SETF2R_UPDATE                         \ UPDATE


\
\ @brief Timerx Output2 Reset Register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMF_RSTF2R_SRT                            \ SRT
$00000002 constant HRTIM_TIMF_RSTF2R_RESYNC                         \ RESYNC
$00000004 constant HRTIM_TIMF_RSTF2R_PER                            \ PER
$00000008 constant HRTIM_TIMF_RSTF2R_CMP1                           \ CMP1
$00000010 constant HRTIM_TIMF_RSTF2R_CMP2                           \ CMP2
$00000020 constant HRTIM_TIMF_RSTF2R_CMP3                           \ CMP3
$00000040 constant HRTIM_TIMF_RSTF2R_CMP4                           \ CMP4
$00000080 constant HRTIM_TIMF_RSTF2R_MSTPER                         \ MSTPER
$00000100 constant HRTIM_TIMF_RSTF2R_MSTCMP1                        \ MSTCMP1
$00000200 constant HRTIM_TIMF_RSTF2R_MSTCMP2                        \ MSTCMP2
$00000400 constant HRTIM_TIMF_RSTF2R_MSTCMP3                        \ MSTCMP3
$00000800 constant HRTIM_TIMF_RSTF2R_MSTCMP4                        \ MSTCMP4
$00001000 constant HRTIM_TIMF_RSTF2R_TIMEVNT1                       \ TIMEVNT1
$00002000 constant HRTIM_TIMF_RSTF2R_TIMEVNT2                       \ TIMEVNT2
$00004000 constant HRTIM_TIMF_RSTF2R_TIMEVNT3                       \ TIMEVNT3
$00008000 constant HRTIM_TIMF_RSTF2R_TIMEVNT4                       \ TIMEVNT4
$00010000 constant HRTIM_TIMF_RSTF2R_TIMEVNT5                       \ TIMEVNT5
$00020000 constant HRTIM_TIMF_RSTF2R_TIMEVNT6                       \ TIMEVNT6
$00040000 constant HRTIM_TIMF_RSTF2R_TIMEVNT7                       \ TIMEVNT7
$00080000 constant HRTIM_TIMF_RSTF2R_TIMEVNT8                       \ TIMEVNT8
$00100000 constant HRTIM_TIMF_RSTF2R_TIMEVNT9                       \ TIMEVNT9
$00200000 constant HRTIM_TIMF_RSTF2R_EXTEVNT1                       \ EXTEVNT1
$00400000 constant HRTIM_TIMF_RSTF2R_EXTEVNT2                       \ EXTEVNT2
$00800000 constant HRTIM_TIMF_RSTF2R_EXTEVNT3                       \ EXTEVNT3
$01000000 constant HRTIM_TIMF_RSTF2R_EXTEVNT4                       \ EXTEVNT4
$02000000 constant HRTIM_TIMF_RSTF2R_EXTEVNT5                       \ EXTEVNT5
$04000000 constant HRTIM_TIMF_RSTF2R_EXTEVNT6                       \ EXTEVNT6
$08000000 constant HRTIM_TIMF_RSTF2R_EXTEVNT7                       \ EXTEVNT7
$10000000 constant HRTIM_TIMF_RSTF2R_EXTEVNT8                       \ EXTEVNT8
$20000000 constant HRTIM_TIMF_RSTF2R_EXTEVNT9                       \ EXTEVNT9
$40000000 constant HRTIM_TIMF_RSTF2R_EXTEVNT10                      \ EXTEVNT10
$80000000 constant HRTIM_TIMF_RSTF2R_UPDATE                         \ UPDATE


\
\ @brief Timerx External Event Filtering Register 1
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMF_EEFFR1_EE1LTCH                        \ External Event 1 latch
$0000001e constant HRTIM_TIMF_EEFFR1_EE1FLTR                        \ External Event 1 filter
$00000040 constant HRTIM_TIMF_EEFFR1_EE2LTCH                        \ External Event 2 latch
$00000780 constant HRTIM_TIMF_EEFFR1_EE2FLTR                        \ External Event 2 filter
$00001000 constant HRTIM_TIMF_EEFFR1_EE3LTCH                        \ External Event 3 latch
$0001e000 constant HRTIM_TIMF_EEFFR1_EE3FLTR                        \ External Event 3 filter
$00040000 constant HRTIM_TIMF_EEFFR1_EE4LTCH                        \ External Event 4 latch
$00780000 constant HRTIM_TIMF_EEFFR1_EE4FLTR                        \ External Event 4 filter
$01000000 constant HRTIM_TIMF_EEFFR1_EE5LTCH                        \ External Event 5 latch
$1e000000 constant HRTIM_TIMF_EEFFR1_EE5FLTR                        \ External Event 5 filter


\
\ @brief Timerx External Event Filtering Register 2
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMF_EEFFR2_EE6LTCH                        \ External Event 6 latch
$0000001e constant HRTIM_TIMF_EEFFR2_EE6FLTR                        \ External Event 6 filter
$00000040 constant HRTIM_TIMF_EEFFR2_EE7LTCH                        \ External Event 7 latch
$00000780 constant HRTIM_TIMF_EEFFR2_EE7FLTR                        \ External Event 7 filter
$00001000 constant HRTIM_TIMF_EEFFR2_EE8LTCH                        \ External Event 8 latch
$0001e000 constant HRTIM_TIMF_EEFFR2_EE8FLTR                        \ External Event 8 filter
$00040000 constant HRTIM_TIMF_EEFFR2_EE9LTCH                        \ External Event 9 latch
$00780000 constant HRTIM_TIMF_EEFFR2_EE9FLTR                        \ External Event 9 filter
$01000000 constant HRTIM_TIMF_EEFFR2_EE10LTCH                       \ External Event 10 latch
$1e000000 constant HRTIM_TIMF_EEFFR2_EE10FLTR                       \ External Event 10 filter


\
\ @brief TimerA Reset Register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMF_RSTFR_TIMFCMP1                        \ Timer A Update reset
$00000002 constant HRTIM_TIMF_RSTFR_UPDT                            \ Timer A Update reset
$00000004 constant HRTIM_TIMF_RSTFR_CMP2                            \ Timer A compare 2 reset
$00000008 constant HRTIM_TIMF_RSTFR_CMP4                            \ Timer A compare 4 reset
$00000010 constant HRTIM_TIMF_RSTFR_MSTPER                          \ Master timer Period
$00000020 constant HRTIM_TIMF_RSTFR_MSTCMP1                         \ Master compare 1
$00000040 constant HRTIM_TIMF_RSTFR_MSTCMP2                         \ Master compare 2
$00000080 constant HRTIM_TIMF_RSTFR_MSTCMP3                         \ Master compare 3
$00000100 constant HRTIM_TIMF_RSTFR_MSTCMP4                         \ Master compare 4
$00000200 constant HRTIM_TIMF_RSTFR_EXTEVNT1                        \ External Event 1
$00000400 constant HRTIM_TIMF_RSTFR_EXTEVNT2                        \ External Event 2
$00000800 constant HRTIM_TIMF_RSTFR_EXTEVNT3                        \ External Event 3
$00001000 constant HRTIM_TIMF_RSTFR_EXTEVNT4                        \ External Event 4
$00002000 constant HRTIM_TIMF_RSTFR_EXTEVNT5                        \ External Event 5
$00004000 constant HRTIM_TIMF_RSTFR_EXTEVNT6                        \ External Event 6
$00008000 constant HRTIM_TIMF_RSTFR_EXTEVNT7                        \ External Event 7
$00010000 constant HRTIM_TIMF_RSTFR_EXTEVNT8                        \ External Event 8
$00020000 constant HRTIM_TIMF_RSTFR_EXTEVNT9                        \ External Event 9
$00040000 constant HRTIM_TIMF_RSTFR_EXTEVNT10                       \ External Event 10
$00080000 constant HRTIM_TIMF_RSTFR_TIMACMP1                        \ Timer A Compare 1
$00100000 constant HRTIM_TIMF_RSTFR_TIMACMP2                        \ Timer A Compare 2
$00200000 constant HRTIM_TIMF_RSTFR_TIMACMP4                        \ Timer A Compare 4
$00400000 constant HRTIM_TIMF_RSTFR_TIMBCMP1                        \ Timer B Compare 1
$00800000 constant HRTIM_TIMF_RSTFR_TIMBCMP2                        \ Timer B Compare 2
$01000000 constant HRTIM_TIMF_RSTFR_TIMBCMP4                        \ Timer B Compare 4
$02000000 constant HRTIM_TIMF_RSTFR_TIMCCMP1                        \ Timer C Compare 1
$04000000 constant HRTIM_TIMF_RSTFR_TIMCCMP2                        \ Timer C Compare 2
$08000000 constant HRTIM_TIMF_RSTFR_TIMCCMP4                        \ Timer C Compare 4
$10000000 constant HRTIM_TIMF_RSTFR_TIMDCMP1                        \ Timer D Compare 1
$20000000 constant HRTIM_TIMF_RSTFR_TIMDCMP2                        \ Timer D Compare 2
$40000000 constant HRTIM_TIMF_RSTFR_TIMDCMP4                        \ Timer D Compare 4
$80000000 constant HRTIM_TIMF_RSTFR_TIMFCPM2                        \ Timer F Compare 2


\
\ @brief Timerx Chopper Register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$0000000f constant HRTIM_TIMF_CHPFR_CHPFRQ                          \ Timerx carrier frequency value
$00000070 constant HRTIM_TIMF_CHPFR_CHPDTY                          \ Timerx chopper duty cycle value
$00000780 constant HRTIM_TIMF_CHPFR_STRTPW                          \ STRTPW


\
\ @brief Timerx Capture 2 Control Register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMF_CPT1FCR_SWCPT                         \ Software Capture
$00000002 constant HRTIM_TIMF_CPT1FCR_UDPCPT                        \ Update Capture
$00000004 constant HRTIM_TIMF_CPT1FCR_EXEV1CPT                      \ External Event 1 Capture
$00000008 constant HRTIM_TIMF_CPT1FCR_EXEV2CPT                      \ External Event 2 Capture
$00000010 constant HRTIM_TIMF_CPT1FCR_EXEV3CPT                      \ External Event 3 Capture
$00000020 constant HRTIM_TIMF_CPT1FCR_EXEV4CPT                      \ External Event 4 Capture
$00000040 constant HRTIM_TIMF_CPT1FCR_EXEV5CPT                      \ External Event 5 Capture
$00000080 constant HRTIM_TIMF_CPT1FCR_EXEV6CPT                      \ External Event 6 Capture
$00000100 constant HRTIM_TIMF_CPT1FCR_EXEV7CPT                      \ External Event 7 Capture
$00000200 constant HRTIM_TIMF_CPT1FCR_EXEV8CPT                      \ External Event 8 Capture
$00000400 constant HRTIM_TIMF_CPT1FCR_EXEV9CPT                      \ External Event 9 Capture
$00000800 constant HRTIM_TIMF_CPT1FCR_EXEV10CPT                     \ External Event 10 Capture
$00001000 constant HRTIM_TIMF_CPT1FCR_TA1SET                        \ Timer A output 1 Set
$00002000 constant HRTIM_TIMF_CPT1FCR_TA1RST                        \ Timer A output 1 Reset
$00004000 constant HRTIM_TIMF_CPT1FCR_TACMP1                        \ Timer A Compare 1
$00008000 constant HRTIM_TIMF_CPT1FCR_TACMP2                        \ Timer A Compare 2
$00010000 constant HRTIM_TIMF_CPT1FCR_TB1SET                        \ Timer B output 1 Set
$00020000 constant HRTIM_TIMF_CPT1FCR_TB1RST                        \ Timer B output 1 Reset
$00040000 constant HRTIM_TIMF_CPT1FCR_TBCMP1                        \ Timer B Compare 1
$00080000 constant HRTIM_TIMF_CPT1FCR_TBCMP2                        \ Timer B Compare 2
$00100000 constant HRTIM_TIMF_CPT1FCR_TC1SET                        \ Timer C output 1 Set
$00200000 constant HRTIM_TIMF_CPT1FCR_TC1RST                        \ Timer C output 1 Reset
$00400000 constant HRTIM_TIMF_CPT1FCR_TCCMP1                        \ Timer C Compare 1
$00800000 constant HRTIM_TIMF_CPT1FCR_TCCMP2                        \ Timer C Compare 2
$01000000 constant HRTIM_TIMF_CPT1FCR_TD1SET                        \ Timer D output 1 Set
$02000000 constant HRTIM_TIMF_CPT1FCR_TD1RST                        \ Timer D output 1 Reset
$04000000 constant HRTIM_TIMF_CPT1FCR_TDCMP1                        \ Timer D Compare 1
$08000000 constant HRTIM_TIMF_CPT1FCR_TDCMP2                        \ Timer D Compare 2
$10000000 constant HRTIM_TIMF_CPT1FCR_TE1SET                        \ TE1SET
$20000000 constant HRTIM_TIMF_CPT1FCR_TE1RST                        \ TE1RST
$40000000 constant HRTIM_TIMF_CPT1FCR_TECMP1                        \ TECMP1
$80000000 constant HRTIM_TIMF_CPT1FCR_TECMP2                        \ TECMP2


\
\ @brief CPT2xCR
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMF_CPT2FCR_SWCPT                         \ Software Capture
$00000002 constant HRTIM_TIMF_CPT2FCR_UDPCPT                        \ Update Capture
$00000004 constant HRTIM_TIMF_CPT2FCR_EXEV1CPT                      \ External Event 1 Capture
$00000008 constant HRTIM_TIMF_CPT2FCR_EXEV2CPT                      \ External Event 2 Capture
$00000010 constant HRTIM_TIMF_CPT2FCR_EXEV3CPT                      \ External Event 3 Capture
$00000020 constant HRTIM_TIMF_CPT2FCR_EXEV4CPT                      \ External Event 4 Capture
$00000040 constant HRTIM_TIMF_CPT2FCR_EXEV5CPT                      \ External Event 5 Capture
$00000080 constant HRTIM_TIMF_CPT2FCR_EXEV6CPT                      \ External Event 6 Capture
$00000100 constant HRTIM_TIMF_CPT2FCR_EXEV7CPT                      \ External Event 7 Capture
$00000200 constant HRTIM_TIMF_CPT2FCR_EXEV8CPT                      \ External Event 8 Capture
$00000400 constant HRTIM_TIMF_CPT2FCR_EXEV9CPT                      \ External Event 9 Capture
$00000800 constant HRTIM_TIMF_CPT2FCR_EXEV10CPT                     \ External Event 10 Capture
$00001000 constant HRTIM_TIMF_CPT2FCR_TA1SET                        \ Timer A output 1 Set
$00002000 constant HRTIM_TIMF_CPT2FCR_TA1RST                        \ Timer A output 1 Reset
$00004000 constant HRTIM_TIMF_CPT2FCR_TACMP1                        \ Timer A Compare 1
$00008000 constant HRTIM_TIMF_CPT2FCR_TACMP2                        \ Timer A Compare 2
$00010000 constant HRTIM_TIMF_CPT2FCR_TB1SET                        \ Timer B output 1 Set
$00020000 constant HRTIM_TIMF_CPT2FCR_TB1RST                        \ Timer B output 1 Reset
$00040000 constant HRTIM_TIMF_CPT2FCR_TBCMP1                        \ Timer B Compare 1
$00080000 constant HRTIM_TIMF_CPT2FCR_TBCMP2                        \ Timer B Compare 2
$00100000 constant HRTIM_TIMF_CPT2FCR_TC1SET                        \ Timer C output 1 Set
$00200000 constant HRTIM_TIMF_CPT2FCR_TC1RST                        \ Timer C output 1 Reset
$00400000 constant HRTIM_TIMF_CPT2FCR_TCCMP1                        \ Timer C Compare 1
$00800000 constant HRTIM_TIMF_CPT2FCR_TCCMP2                        \ Timer C Compare 2
$01000000 constant HRTIM_TIMF_CPT2FCR_TD1SET                        \ Timer D output 1 Set
$02000000 constant HRTIM_TIMF_CPT2FCR_TD1RST                        \ Timer D output 1 Reset
$04000000 constant HRTIM_TIMF_CPT2FCR_TDCMP1                        \ Timer D Compare 1
$08000000 constant HRTIM_TIMF_CPT2FCR_TDCMP2                        \ Timer D Compare 2
$10000000 constant HRTIM_TIMF_CPT2FCR_TE1SET                        \ TE1SET
$20000000 constant HRTIM_TIMF_CPT2FCR_TE1RST                        \ TE1RST
$40000000 constant HRTIM_TIMF_CPT2FCR_TECMP1                        \ TECMP1
$80000000 constant HRTIM_TIMF_CPT2FCR_TECMP2                        \ TECMP2


\
\ @brief Timerx Output Register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000002 constant HRTIM_TIMF_OUTFR_POL1                            \ Output 1 polarity
$00000004 constant HRTIM_TIMF_OUTFR_IDLEM1                          \ Output 1 Idle mode
$00000008 constant HRTIM_TIMF_OUTFR_IDLES1                          \ Output 1 Idle State
$00000030 constant HRTIM_TIMF_OUTFR_FAULT1                          \ Output 1 Fault state
$00000040 constant HRTIM_TIMF_OUTFR_CHP1                            \ Output 1 Chopper enable
$00000080 constant HRTIM_TIMF_OUTFR_DIDL1                           \ Output 1 Deadtime upon burst mode Idle entry
$00000100 constant HRTIM_TIMF_OUTFR_DTEN                            \ Deadtime enable
$00000200 constant HRTIM_TIMF_OUTFR_DLYPRTEN                        \ Delayed Protection Enable
$00001c00 constant HRTIM_TIMF_OUTFR_DLYPRT                          \ Delayed Protection
$00004000 constant HRTIM_TIMF_OUTFR_BIAR                            \ Balanced Idle Automatic Resume
$00020000 constant HRTIM_TIMF_OUTFR_POL2                            \ Output 2 polarity
$00040000 constant HRTIM_TIMF_OUTFR_IDLEM2                          \ Output 2 Idle mode
$00080000 constant HRTIM_TIMF_OUTFR_IDLES2                          \ Output 2 Idle State
$00300000 constant HRTIM_TIMF_OUTFR_FAULT2                          \ Output 2 Fault state
$00400000 constant HRTIM_TIMF_OUTFR_CHP2                            \ Output 2 Chopper enable
$00800000 constant HRTIM_TIMF_OUTFR_DIDL2                           \ Output 2 Deadtime upon burst mode Idle entry


\
\ @brief Timerx Fault Register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMF_FLTFR_FLT1EN                          \ Fault 1 enable
$00000002 constant HRTIM_TIMF_FLTFR_FLT2EN                          \ Fault 2 enable
$00000004 constant HRTIM_TIMF_FLTFR_FLT3EN                          \ Fault 3 enable
$00000008 constant HRTIM_TIMF_FLTFR_FLT4EN                          \ Fault 4 enable
$00000010 constant HRTIM_TIMF_FLTFR_FLT5EN                          \ Fault 5 enable
$00000020 constant HRTIM_TIMF_FLTFR_FLT6EN                          \ Fault 6 enable
$80000000 constant HRTIM_TIMF_FLTFR_FLTLCK                          \ Fault sources Lock


\
\ @brief HRTIM Timerx Control Register 2
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMF_TIMFCR2_DCDE                          \ Dual Channel DAC trigger enable
$00000002 constant HRTIM_TIMF_TIMFCR2_DCDS                          \ Dual Channel DAC Step trigger
$00000004 constant HRTIM_TIMF_TIMFCR2_DCDR                          \ Dual Channel DAC Reset trigger
$00000010 constant HRTIM_TIMF_TIMFCR2_UDM                           \ Up-Down Mode
$000000c0 constant HRTIM_TIMF_TIMFCR2_ROM                           \ Roll-Over Mode
$00000300 constant HRTIM_TIMF_TIMFCR2_OUTROM                        \ Output Roll-Over Mode
$00000c00 constant HRTIM_TIMF_TIMFCR2_ADROM                         \ ADC Roll-Over Mode
$00003000 constant HRTIM_TIMF_TIMFCR2_BMROM                         \ Burst Mode Roll-Over Mode
$0000c000 constant HRTIM_TIMF_TIMFCR2_FEROM                         \ Fault and Event Roll-Over Mode
$00010000 constant HRTIM_TIMF_TIMFCR2_GTCMP1                        \ Greater than Compare 1 PWM mode
$00020000 constant HRTIM_TIMF_TIMFCR2_GTCMP3                        \ Greater than Compare 3 PWM mode
$00100000 constant HRTIM_TIMF_TIMFCR2_TRGHLF                        \ Triggered-half mode


\
\ @brief HRTIM Timerx External Event Filtering Register 3
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMF_FEEFR3_EEVACE                         \ External Event A Counter Enable
$00000002 constant HRTIM_TIMF_FEEFR3_EEVACRES                       \ External Event A Counter Reset
$00000004 constant HRTIM_TIMF_FEEFR3_EEVARSTM                       \ External Event A Reset Mode
$000000f0 constant HRTIM_TIMF_FEEFR3_EEVASEL                        \ External Event A Selection
$00003f00 constant HRTIM_TIMF_FEEFR3_EEVACNT                        \ External Event A counter


\
\ @brief High Resolution Timer: TIMF
\
$40016b00 constant HRTIM_TIMF_TIMFCR  \ offset: 0x00 : Timerx Control Register
$40016b04 constant HRTIM_TIMF_TIMFISR  \ offset: 0x04 : Timerx Interrupt Status Register
$40016b08 constant HRTIM_TIMF_TIMFICR  \ offset: 0x08 : Timerx Interrupt Clear Register
$40016b0c constant HRTIM_TIMF_TIMFDIER  \ offset: 0x0C : TIMxDIER
$40016b10 constant HRTIM_TIMF_CNTFR  \ offset: 0x10 : Timerx Counter Register
$40016b14 constant HRTIM_TIMF_PERFR  \ offset: 0x14 : Timerx Period Register
$40016b18 constant HRTIM_TIMF_REPFR  \ offset: 0x18 : Timerx Repetition Register
$40016b1c constant HRTIM_TIMF_CMP1FR  \ offset: 0x1C : Timerx Compare 1 Register
$40016b20 constant HRTIM_TIMF_CMP1CFR  \ offset: 0x20 : Timerx Compare 1 Compound Register
$40016b24 constant HRTIM_TIMF_CMP2FR  \ offset: 0x24 : Timerx Compare 2 Register
$40016b28 constant HRTIM_TIMF_CMP3FR  \ offset: 0x28 : Timerx Compare 3 Register
$40016b2c constant HRTIM_TIMF_CMP4FR  \ offset: 0x2C : Timerx Compare 4 Register
$40016b30 constant HRTIM_TIMF_CPT1FR  \ offset: 0x30 : Timerx Capture 1 Register
$40016b34 constant HRTIM_TIMF_CPT2FR  \ offset: 0x34 : Timerx Capture 2 Register
$40016b38 constant HRTIM_TIMF_DTFR  \ offset: 0x38 : Timerx Deadtime Register
$40016b3c constant HRTIM_TIMF_SETF1R  \ offset: 0x3C : Timerx Output1 Set Register
$40016b40 constant HRTIM_TIMF_RSTE1R  \ offset: 0x40 : Timerx Output1 Reset Register
$40016b44 constant HRTIM_TIMF_SETF2R  \ offset: 0x44 : Timerx Output2 Set Register
$40016b48 constant HRTIM_TIMF_RSTF2R  \ offset: 0x48 : Timerx Output2 Reset Register
$40016b4c constant HRTIM_TIMF_EEFFR1  \ offset: 0x4C : Timerx External Event Filtering Register 1
$40016b50 constant HRTIM_TIMF_EEFFR2  \ offset: 0x50 : Timerx External Event Filtering Register 2
$40016b54 constant HRTIM_TIMF_RSTFR  \ offset: 0x54 : TimerA Reset Register
$40016b58 constant HRTIM_TIMF_CHPFR  \ offset: 0x58 : Timerx Chopper Register
$40016b5c constant HRTIM_TIMF_CPT1FCR  \ offset: 0x5C : Timerx Capture 2 Control Register
$40016b60 constant HRTIM_TIMF_CPT2FCR  \ offset: 0x60 : CPT2xCR
$40016b64 constant HRTIM_TIMF_OUTFR  \ offset: 0x64 : Timerx Output Register
$40016b68 constant HRTIM_TIMF_FLTFR  \ offset: 0x68 : Timerx Fault Register
$40016b6c constant HRTIM_TIMF_TIMFCR2  \ offset: 0x6C : HRTIM Timerx Control Register 2
$40016b70 constant HRTIM_TIMF_FEEFR3  \ offset: 0x70 : HRTIM Timerx External Event Filtering Register 3

