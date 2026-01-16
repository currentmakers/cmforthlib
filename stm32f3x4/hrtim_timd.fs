\
\ @file hrtim_timd.fs
\ @brief High Resolution Timer: TIMD
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

$00000007 constant HRTIM_TIMD_TIMDCR_CK_PSCX                        \ HRTIM Timer x Clock prescaler
$00000008 constant HRTIM_TIMD_TIMDCR_CONT                           \ Continuous mode
$00000010 constant HRTIM_TIMD_TIMDCR_RETRIG                         \ Re-triggerable mode
$00000020 constant HRTIM_TIMD_TIMDCR_HALF                           \ Half mode enable
$00000040 constant HRTIM_TIMD_TIMDCR_PSHPLL                         \ Push-Pull mode enable
$00000400 constant HRTIM_TIMD_TIMDCR_SYNCRSTX                       \ Synchronization Resets Timer x
$00000800 constant HRTIM_TIMD_TIMDCR_SYNCSTRTX                      \ Synchronization Starts Timer x
$00003000 constant HRTIM_TIMD_TIMDCR_DELCMP2                        \ Delayed CMP2 mode
$0000c000 constant HRTIM_TIMD_TIMDCR_DELCMP4                        \ Delayed CMP4 mode
$00020000 constant HRTIM_TIMD_TIMDCR_TXREPU                         \ Timer x Repetition update
$00040000 constant HRTIM_TIMD_TIMDCR_TXRSTU                         \ Timerx reset update
$00100000 constant HRTIM_TIMD_TIMDCR_TBU                            \ TBU
$00200000 constant HRTIM_TIMD_TIMDCR_TCU                            \ TCU
$00400000 constant HRTIM_TIMD_TIMDCR_TDU                            \ TDU
$00800000 constant HRTIM_TIMD_TIMDCR_TEU                            \ TEU
$01000000 constant HRTIM_TIMD_TIMDCR_MSTU                           \ Master Timer update
$06000000 constant HRTIM_TIMD_TIMDCR_DACSYNC                        \ AC Synchronization
$08000000 constant HRTIM_TIMD_TIMDCR_PREEN                          \ Preload enable
$f0000000 constant HRTIM_TIMD_TIMDCR_UPDGAT                         \ Update Gating


\
\ @brief Timerx Interrupt Status Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMD_TIMDISR_CMP1                          \ Compare 1 Interrupt Flag
$00000002 constant HRTIM_TIMD_TIMDISR_CMP2                          \ Compare 2 Interrupt Flag
$00000004 constant HRTIM_TIMD_TIMDISR_CMP3                          \ Compare 3 Interrupt Flag
$00000008 constant HRTIM_TIMD_TIMDISR_CMP4                          \ Compare 4 Interrupt Flag
$00000010 constant HRTIM_TIMD_TIMDISR_REP                           \ Repetition Interrupt Flag
$00000040 constant HRTIM_TIMD_TIMDISR_UPD                           \ Update Interrupt Flag
$00000080 constant HRTIM_TIMD_TIMDISR_CPT1                          \ Capture1 Interrupt Flag
$00000100 constant HRTIM_TIMD_TIMDISR_CPT2                          \ Capture2 Interrupt Flag
$00000200 constant HRTIM_TIMD_TIMDISR_SETX1                         \ Output 1 Set Interrupt Flag
$00000400 constant HRTIM_TIMD_TIMDISR_RSTX1                         \ Output 1 Reset Interrupt Flag
$00000800 constant HRTIM_TIMD_TIMDISR_SETX2                         \ Output 2 Set Interrupt Flag
$00001000 constant HRTIM_TIMD_TIMDISR_RSTX2                         \ Output 2 Reset Interrupt Flag
$00002000 constant HRTIM_TIMD_TIMDISR_RST                           \ Reset Interrupt Flag
$00004000 constant HRTIM_TIMD_TIMDISR_DLYPRT                        \ Delayed Protection Flag
$00010000 constant HRTIM_TIMD_TIMDISR_CPPSTAT                       \ Current Push Pull Status
$00020000 constant HRTIM_TIMD_TIMDISR_IPPSTAT                       \ Idle Push Pull Status
$00040000 constant HRTIM_TIMD_TIMDISR_O1STAT                        \ Output 1 State
$00080000 constant HRTIM_TIMD_TIMDISR_O2STAT                        \ Output 2 State
$00100000 constant HRTIM_TIMD_TIMDISR_O1CPY                         \ Output 1 Copy
$00200000 constant HRTIM_TIMD_TIMDISR_O2CPY                         \ Output 2 Copy


\
\ @brief Timerx Interrupt Clear Register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMD_TIMDICR_CMP1C                         \ Compare 1 Interrupt flag Clear
$00000002 constant HRTIM_TIMD_TIMDICR_CMP2C                         \ Compare 2 Interrupt flag Clear
$00000004 constant HRTIM_TIMD_TIMDICR_CMP3C                         \ Compare 3 Interrupt flag Clear
$00000008 constant HRTIM_TIMD_TIMDICR_CMP4C                         \ Compare 4 Interrupt flag Clear
$00000010 constant HRTIM_TIMD_TIMDICR_REPC                          \ Repetition Interrupt flag Clear
$00000040 constant HRTIM_TIMD_TIMDICR_UPDC                          \ Update Interrupt flag Clear
$00000080 constant HRTIM_TIMD_TIMDICR_CPT1C                         \ Capture1 Interrupt flag Clear
$00000100 constant HRTIM_TIMD_TIMDICR_CPT2C                         \ Capture2 Interrupt flag Clear
$00000200 constant HRTIM_TIMD_TIMDICR_SET1XC                        \ Output 1 Set flag Clear
$00000400 constant HRTIM_TIMD_TIMDICR_RSTX1C                        \ Output 1 Reset flag Clear
$00000800 constant HRTIM_TIMD_TIMDICR_SET2XC                        \ Output 2 Set flag Clear
$00001000 constant HRTIM_TIMD_TIMDICR_RSTX2C                        \ Output 2 Reset flag Clear
$00002000 constant HRTIM_TIMD_TIMDICR_RSTC                          \ Reset Interrupt flag Clear
$00004000 constant HRTIM_TIMD_TIMDICR_DLYPRTC                       \ Delayed Protection Flag Clear


\
\ @brief TIMxDIER5
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMD_TIMDDIER5_CMP1IE                      \ CMP1IE
$00000002 constant HRTIM_TIMD_TIMDDIER5_CMP2IE                      \ CMP2IE
$00000004 constant HRTIM_TIMD_TIMDDIER5_CMP3IE                      \ CMP3IE
$00000008 constant HRTIM_TIMD_TIMDDIER5_CMP4IE                      \ CMP4IE
$00000010 constant HRTIM_TIMD_TIMDDIER5_REPIE                       \ REPIE
$00000040 constant HRTIM_TIMD_TIMDDIER5_UPDIE                       \ UPDIE
$00000080 constant HRTIM_TIMD_TIMDDIER5_CPT1IE                      \ CPT1IE
$00000100 constant HRTIM_TIMD_TIMDDIER5_CPT2IE                      \ CPT2IE
$00000200 constant HRTIM_TIMD_TIMDDIER5_SET1XIE                     \ SET1xIE
$00000400 constant HRTIM_TIMD_TIMDDIER5_RSTX1IE                     \ RSTx1IE
$00000800 constant HRTIM_TIMD_TIMDDIER5_SETX2IE                     \ SETx2IE
$00001000 constant HRTIM_TIMD_TIMDDIER5_RSTX2IE                     \ RSTx2IE
$00002000 constant HRTIM_TIMD_TIMDDIER5_RSTIE                       \ RSTIE
$00004000 constant HRTIM_TIMD_TIMDDIER5_DLYPRTIE                    \ DLYPRTIE
$00010000 constant HRTIM_TIMD_TIMDDIER5_CMP1DE                      \ CMP1DE
$00020000 constant HRTIM_TIMD_TIMDDIER5_CMP2DE                      \ CMP2DE
$00040000 constant HRTIM_TIMD_TIMDDIER5_CMP3DE                      \ CMP3DE
$00080000 constant HRTIM_TIMD_TIMDDIER5_CMP4DE                      \ CMP4DE
$00100000 constant HRTIM_TIMD_TIMDDIER5_REPDE                       \ REPDE
$00400000 constant HRTIM_TIMD_TIMDDIER5_UPDDE                       \ UPDDE
$00800000 constant HRTIM_TIMD_TIMDDIER5_CPT1DE                      \ CPT1DE
$01000000 constant HRTIM_TIMD_TIMDDIER5_CPT2DE                      \ CPT2DE
$02000000 constant HRTIM_TIMD_TIMDDIER5_SET1XDE                     \ SET1xDE
$04000000 constant HRTIM_TIMD_TIMDDIER5_RSTX1DE                     \ RSTx1DE
$08000000 constant HRTIM_TIMD_TIMDDIER5_SETX2DE                     \ SETx2DE
$10000000 constant HRTIM_TIMD_TIMDDIER5_RSTX2DE                     \ RSTx2DE
$20000000 constant HRTIM_TIMD_TIMDDIER5_RSTDE                       \ RSTDE
$40000000 constant HRTIM_TIMD_TIMDDIER5_DLYPRTDE                    \ DLYPRTDE


\
\ @brief Timerx Counter Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMD_CNTDR_CNTX                            \ Timerx Counter value


\
\ @brief Timerx Period Register
\ Address offset: 0x14
\ Reset value: 0x0000FFFF
\

$0000ffff constant HRTIM_TIMD_PERDR_PERX                            \ Timerx Period value


\
\ @brief Timerx Repetition Register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant HRTIM_TIMD_REPDR_REPX                            \ Timerx Repetition counter value


\
\ @brief Timerx Compare 1 Register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMD_CMP1DR_CMP1X                          \ Timerx Compare 1 value


\
\ @brief Timerx Compare 1 Compound Register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMD_CMP1CDR_CMP1X                         \ Timerx Compare 1 value
$00ff0000 constant HRTIM_TIMD_CMP1CDR_REPX                          \ Timerx Repetition value (aliased from HRTIM_REPx register)


\
\ @brief Timerx Compare 2 Register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMD_CMP2DR_CMP2X                          \ Timerx Compare 2 value


\
\ @brief Timerx Compare 3 Register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMD_CMP3DR_CMP3X                          \ Timerx Compare 3 value


\
\ @brief Timerx Compare 4 Register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMD_CMP4DR_CMP4X                          \ Timerx Compare 4 value


\
\ @brief Timerx Capture 1 Register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMD_CPT1DR_CPT1X                          \ Timerx Capture 1 value


\
\ @brief Timerx Capture 2 Register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_TIMD_CPT2DR_CPT2X                          \ Timerx Capture 2 value


\
\ @brief Timerx Deadtime Register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000001ff constant HRTIM_TIMD_DTDR_DTRX                             \ Deadtime Rising value
$00000200 constant HRTIM_TIMD_DTDR_SDTRX                            \ Sign Deadtime Rising value
$00001c00 constant HRTIM_TIMD_DTDR_DTPRSC                           \ Deadtime Prescaler
$00004000 constant HRTIM_TIMD_DTDR_DTRSLKX                          \ Deadtime Rising Sign Lock
$00008000 constant HRTIM_TIMD_DTDR_DTRLKX                           \ Deadtime Rising Lock
$01ff0000 constant HRTIM_TIMD_DTDR_DTFX                             \ Deadtime Falling value
$02000000 constant HRTIM_TIMD_DTDR_SDTFX                            \ Sign Deadtime Falling value
$40000000 constant HRTIM_TIMD_DTDR_DTFSLKX                          \ Deadtime Falling Sign Lock
$80000000 constant HRTIM_TIMD_DTDR_DTFLKX                           \ Deadtime Falling Lock


\
\ @brief Timerx Output1 Set Register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMD_SETD1R_SST                            \ Software Set trigger
$00000002 constant HRTIM_TIMD_SETD1R_RESYNC                         \ Timer A resynchronizaton
$00000004 constant HRTIM_TIMD_SETD1R_PER                            \ Timer A Period
$00000008 constant HRTIM_TIMD_SETD1R_CMP1                           \ Timer A compare 1
$00000010 constant HRTIM_TIMD_SETD1R_CMP2                           \ Timer A compare 2
$00000020 constant HRTIM_TIMD_SETD1R_CMP3                           \ Timer A compare 3
$00000040 constant HRTIM_TIMD_SETD1R_CMP4                           \ Timer A compare 4
$00000080 constant HRTIM_TIMD_SETD1R_MSTPER                         \ Master Period
$00000100 constant HRTIM_TIMD_SETD1R_MSTCMP1                        \ Master Compare 1
$00000200 constant HRTIM_TIMD_SETD1R_MSTCMP2                        \ Master Compare 2
$00000400 constant HRTIM_TIMD_SETD1R_MSTCMP3                        \ Master Compare 3
$00000800 constant HRTIM_TIMD_SETD1R_MSTCMP4                        \ Master Compare 4
$00001000 constant HRTIM_TIMD_SETD1R_TIMEVNT1                       \ Timer Event 1
$00002000 constant HRTIM_TIMD_SETD1R_TIMEVNT2                       \ Timer Event 2
$00004000 constant HRTIM_TIMD_SETD1R_TIMEVNT3                       \ Timer Event 3
$00008000 constant HRTIM_TIMD_SETD1R_TIMEVNT4                       \ Timer Event 4
$00010000 constant HRTIM_TIMD_SETD1R_TIMEVNT5                       \ Timer Event 5
$00020000 constant HRTIM_TIMD_SETD1R_TIMEVNT6                       \ Timer Event 6
$00040000 constant HRTIM_TIMD_SETD1R_TIMEVNT7                       \ Timer Event 7
$00080000 constant HRTIM_TIMD_SETD1R_TIMEVNT8                       \ Timer Event 8
$00100000 constant HRTIM_TIMD_SETD1R_TIMEVNT9                       \ Timer Event 9
$00200000 constant HRTIM_TIMD_SETD1R_EXTEVNT1                       \ External Event 1
$00400000 constant HRTIM_TIMD_SETD1R_EXTEVNT2                       \ External Event 2
$00800000 constant HRTIM_TIMD_SETD1R_EXTEVNT3                       \ External Event 3
$01000000 constant HRTIM_TIMD_SETD1R_EXTEVNT4                       \ External Event 4
$02000000 constant HRTIM_TIMD_SETD1R_EXTEVNT5                       \ External Event 5
$04000000 constant HRTIM_TIMD_SETD1R_EXTEVNT6                       \ External Event 6
$08000000 constant HRTIM_TIMD_SETD1R_EXTEVNT7                       \ External Event 7
$10000000 constant HRTIM_TIMD_SETD1R_EXTEVNT8                       \ External Event 8
$20000000 constant HRTIM_TIMD_SETD1R_EXTEVNT9                       \ External Event 9
$40000000 constant HRTIM_TIMD_SETD1R_EXTEVNT10                      \ External Event 10
$80000000 constant HRTIM_TIMD_SETD1R_UPDATE                         \ Registers update (transfer preload to active)


\
\ @brief Timerx Output1 Reset Register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMD_RSTD1R_SRT                            \ SRT
$00000002 constant HRTIM_TIMD_RSTD1R_RESYNC                         \ RESYNC
$00000004 constant HRTIM_TIMD_RSTD1R_PER                            \ PER
$00000008 constant HRTIM_TIMD_RSTD1R_CMP1                           \ CMP1
$00000010 constant HRTIM_TIMD_RSTD1R_CMP2                           \ CMP2
$00000020 constant HRTIM_TIMD_RSTD1R_CMP3                           \ CMP3
$00000040 constant HRTIM_TIMD_RSTD1R_CMP4                           \ CMP4
$00000080 constant HRTIM_TIMD_RSTD1R_MSTPER                         \ MSTPER
$00000100 constant HRTIM_TIMD_RSTD1R_MSTCMP1                        \ MSTCMP1
$00000200 constant HRTIM_TIMD_RSTD1R_MSTCMP2                        \ MSTCMP2
$00000400 constant HRTIM_TIMD_RSTD1R_MSTCMP3                        \ MSTCMP3
$00000800 constant HRTIM_TIMD_RSTD1R_MSTCMP4                        \ MSTCMP4
$00001000 constant HRTIM_TIMD_RSTD1R_TIMEVNT1                       \ TIMEVNT1
$00002000 constant HRTIM_TIMD_RSTD1R_TIMEVNT2                       \ TIMEVNT2
$00004000 constant HRTIM_TIMD_RSTD1R_TIMEVNT3                       \ TIMEVNT3
$00008000 constant HRTIM_TIMD_RSTD1R_TIMEVNT4                       \ TIMEVNT4
$00010000 constant HRTIM_TIMD_RSTD1R_TIMEVNT5                       \ TIMEVNT5
$00020000 constant HRTIM_TIMD_RSTD1R_TIMEVNT6                       \ TIMEVNT6
$00040000 constant HRTIM_TIMD_RSTD1R_TIMEVNT7                       \ TIMEVNT7
$00080000 constant HRTIM_TIMD_RSTD1R_TIMEVNT8                       \ TIMEVNT8
$00100000 constant HRTIM_TIMD_RSTD1R_TIMEVNT9                       \ TIMEVNT9
$00200000 constant HRTIM_TIMD_RSTD1R_EXTEVNT1                       \ EXTEVNT1
$00400000 constant HRTIM_TIMD_RSTD1R_EXTEVNT2                       \ EXTEVNT2
$00800000 constant HRTIM_TIMD_RSTD1R_EXTEVNT3                       \ EXTEVNT3
$01000000 constant HRTIM_TIMD_RSTD1R_EXTEVNT4                       \ EXTEVNT4
$02000000 constant HRTIM_TIMD_RSTD1R_EXTEVNT5                       \ EXTEVNT5
$04000000 constant HRTIM_TIMD_RSTD1R_EXTEVNT6                       \ EXTEVNT6
$08000000 constant HRTIM_TIMD_RSTD1R_EXTEVNT7                       \ EXTEVNT7
$10000000 constant HRTIM_TIMD_RSTD1R_EXTEVNT8                       \ EXTEVNT8
$20000000 constant HRTIM_TIMD_RSTD1R_EXTEVNT9                       \ EXTEVNT9
$40000000 constant HRTIM_TIMD_RSTD1R_EXTEVNT10                      \ EXTEVNT10
$80000000 constant HRTIM_TIMD_RSTD1R_UPDATE                         \ UPDATE


\
\ @brief Timerx Output2 Set Register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMD_SETD2R_SST                            \ SST
$00000002 constant HRTIM_TIMD_SETD2R_RESYNC                         \ RESYNC
$00000004 constant HRTIM_TIMD_SETD2R_PER                            \ PER
$00000008 constant HRTIM_TIMD_SETD2R_CMP1                           \ CMP1
$00000010 constant HRTIM_TIMD_SETD2R_CMP2                           \ CMP2
$00000020 constant HRTIM_TIMD_SETD2R_CMP3                           \ CMP3
$00000040 constant HRTIM_TIMD_SETD2R_CMP4                           \ CMP4
$00000080 constant HRTIM_TIMD_SETD2R_MSTPER                         \ MSTPER
$00000100 constant HRTIM_TIMD_SETD2R_MSTCMP1                        \ MSTCMP1
$00000200 constant HRTIM_TIMD_SETD2R_MSTCMP2                        \ MSTCMP2
$00000400 constant HRTIM_TIMD_SETD2R_MSTCMP3                        \ MSTCMP3
$00000800 constant HRTIM_TIMD_SETD2R_MSTCMP4                        \ MSTCMP4
$00001000 constant HRTIM_TIMD_SETD2R_TIMEVNT1                       \ TIMEVNT1
$00002000 constant HRTIM_TIMD_SETD2R_TIMEVNT2                       \ TIMEVNT2
$00004000 constant HRTIM_TIMD_SETD2R_TIMEVNT3                       \ TIMEVNT3
$00008000 constant HRTIM_TIMD_SETD2R_TIMEVNT4                       \ TIMEVNT4
$00010000 constant HRTIM_TIMD_SETD2R_TIMEVNT5                       \ TIMEVNT5
$00020000 constant HRTIM_TIMD_SETD2R_TIMEVNT6                       \ TIMEVNT6
$00040000 constant HRTIM_TIMD_SETD2R_TIMEVNT7                       \ TIMEVNT7
$00080000 constant HRTIM_TIMD_SETD2R_TIMEVNT8                       \ TIMEVNT8
$00100000 constant HRTIM_TIMD_SETD2R_TIMEVNT9                       \ TIMEVNT9
$00200000 constant HRTIM_TIMD_SETD2R_EXTEVNT1                       \ EXTEVNT1
$00400000 constant HRTIM_TIMD_SETD2R_EXTEVNT2                       \ EXTEVNT2
$00800000 constant HRTIM_TIMD_SETD2R_EXTEVNT3                       \ EXTEVNT3
$01000000 constant HRTIM_TIMD_SETD2R_EXTEVNT4                       \ EXTEVNT4
$02000000 constant HRTIM_TIMD_SETD2R_EXTEVNT5                       \ EXTEVNT5
$04000000 constant HRTIM_TIMD_SETD2R_EXTEVNT6                       \ EXTEVNT6
$08000000 constant HRTIM_TIMD_SETD2R_EXTEVNT7                       \ EXTEVNT7
$10000000 constant HRTIM_TIMD_SETD2R_EXTEVNT8                       \ EXTEVNT8
$20000000 constant HRTIM_TIMD_SETD2R_EXTEVNT9                       \ EXTEVNT9
$40000000 constant HRTIM_TIMD_SETD2R_EXTEVNT10                      \ EXTEVNT10
$80000000 constant HRTIM_TIMD_SETD2R_UPDATE                         \ UPDATE


\
\ @brief Timerx Output2 Reset Register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMD_RSTD2R_SRT                            \ SRT
$00000002 constant HRTIM_TIMD_RSTD2R_RESYNC                         \ RESYNC
$00000004 constant HRTIM_TIMD_RSTD2R_PER                            \ PER
$00000008 constant HRTIM_TIMD_RSTD2R_CMP1                           \ CMP1
$00000010 constant HRTIM_TIMD_RSTD2R_CMP2                           \ CMP2
$00000020 constant HRTIM_TIMD_RSTD2R_CMP3                           \ CMP3
$00000040 constant HRTIM_TIMD_RSTD2R_CMP4                           \ CMP4
$00000080 constant HRTIM_TIMD_RSTD2R_MSTPER                         \ MSTPER
$00000100 constant HRTIM_TIMD_RSTD2R_MSTCMP1                        \ MSTCMP1
$00000200 constant HRTIM_TIMD_RSTD2R_MSTCMP2                        \ MSTCMP2
$00000400 constant HRTIM_TIMD_RSTD2R_MSTCMP3                        \ MSTCMP3
$00000800 constant HRTIM_TIMD_RSTD2R_MSTCMP4                        \ MSTCMP4
$00001000 constant HRTIM_TIMD_RSTD2R_TIMEVNT1                       \ TIMEVNT1
$00002000 constant HRTIM_TIMD_RSTD2R_TIMEVNT2                       \ TIMEVNT2
$00004000 constant HRTIM_TIMD_RSTD2R_TIMEVNT3                       \ TIMEVNT3
$00008000 constant HRTIM_TIMD_RSTD2R_TIMEVNT4                       \ TIMEVNT4
$00010000 constant HRTIM_TIMD_RSTD2R_TIMEVNT5                       \ TIMEVNT5
$00020000 constant HRTIM_TIMD_RSTD2R_TIMEVNT6                       \ TIMEVNT6
$00040000 constant HRTIM_TIMD_RSTD2R_TIMEVNT7                       \ TIMEVNT7
$00080000 constant HRTIM_TIMD_RSTD2R_TIMEVNT8                       \ TIMEVNT8
$00100000 constant HRTIM_TIMD_RSTD2R_TIMEVNT9                       \ TIMEVNT9
$00200000 constant HRTIM_TIMD_RSTD2R_EXTEVNT1                       \ EXTEVNT1
$00400000 constant HRTIM_TIMD_RSTD2R_EXTEVNT2                       \ EXTEVNT2
$00800000 constant HRTIM_TIMD_RSTD2R_EXTEVNT3                       \ EXTEVNT3
$01000000 constant HRTIM_TIMD_RSTD2R_EXTEVNT4                       \ EXTEVNT4
$02000000 constant HRTIM_TIMD_RSTD2R_EXTEVNT5                       \ EXTEVNT5
$04000000 constant HRTIM_TIMD_RSTD2R_EXTEVNT6                       \ EXTEVNT6
$08000000 constant HRTIM_TIMD_RSTD2R_EXTEVNT7                       \ EXTEVNT7
$10000000 constant HRTIM_TIMD_RSTD2R_EXTEVNT8                       \ EXTEVNT8
$20000000 constant HRTIM_TIMD_RSTD2R_EXTEVNT9                       \ EXTEVNT9
$40000000 constant HRTIM_TIMD_RSTD2R_EXTEVNT10                      \ EXTEVNT10
$80000000 constant HRTIM_TIMD_RSTD2R_UPDATE                         \ UPDATE


\
\ @brief Timerx External Event Filtering Register 1
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMD_EEFDR1_EE1LTCH                        \ External Event 1 latch
$0000001e constant HRTIM_TIMD_EEFDR1_EE1FLTR                        \ External Event 1 filter
$00000040 constant HRTIM_TIMD_EEFDR1_EE2LTCH                        \ External Event 2 latch
$00000780 constant HRTIM_TIMD_EEFDR1_EE2FLTR                        \ External Event 2 filter
$00001000 constant HRTIM_TIMD_EEFDR1_EE3LTCH                        \ External Event 3 latch
$0001e000 constant HRTIM_TIMD_EEFDR1_EE3FLTR                        \ External Event 3 filter
$00040000 constant HRTIM_TIMD_EEFDR1_EE4LTCH                        \ External Event 4 latch
$00780000 constant HRTIM_TIMD_EEFDR1_EE4FLTR                        \ External Event 4 filter
$01000000 constant HRTIM_TIMD_EEFDR1_EE5LTCH                        \ External Event 5 latch
$1e000000 constant HRTIM_TIMD_EEFDR1_EE5FLTR                        \ External Event 5 filter


\
\ @brief Timerx External Event Filtering Register 2
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMD_EEFDR2_EE6LTCH                        \ External Event 6 latch
$0000001e constant HRTIM_TIMD_EEFDR2_EE6FLTR                        \ External Event 6 filter
$00000040 constant HRTIM_TIMD_EEFDR2_EE7LTCH                        \ External Event 7 latch
$00000780 constant HRTIM_TIMD_EEFDR2_EE7FLTR                        \ External Event 7 filter
$00001000 constant HRTIM_TIMD_EEFDR2_EE8LTCH                        \ External Event 8 latch
$0001e000 constant HRTIM_TIMD_EEFDR2_EE8FLTR                        \ External Event 8 filter
$00040000 constant HRTIM_TIMD_EEFDR2_EE9LTCH                        \ External Event 9 latch
$00780000 constant HRTIM_TIMD_EEFDR2_EE9FLTR                        \ External Event 9 filter
$01000000 constant HRTIM_TIMD_EEFDR2_EE10LTCH                       \ External Event 10 latch
$1e000000 constant HRTIM_TIMD_EEFDR2_EE10FLTR                       \ External Event 10 filter


\
\ @brief TimerA Reset Register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000002 constant HRTIM_TIMD_RSTDR_UPDT                            \ Timer A Update reset
$00000004 constant HRTIM_TIMD_RSTDR_CMP2                            \ Timer A compare 2 reset
$00000008 constant HRTIM_TIMD_RSTDR_CMP4                            \ Timer A compare 4 reset
$00000010 constant HRTIM_TIMD_RSTDR_MSTPER                          \ Master timer Period
$00000020 constant HRTIM_TIMD_RSTDR_MSTCMP1                         \ Master compare 1
$00000040 constant HRTIM_TIMD_RSTDR_MSTCMP2                         \ Master compare 2
$00000080 constant HRTIM_TIMD_RSTDR_MSTCMP3                         \ Master compare 3
$00000100 constant HRTIM_TIMD_RSTDR_MSTCMP4                         \ Master compare 4
$00000200 constant HRTIM_TIMD_RSTDR_EXTEVNT1                        \ External Event 1
$00000400 constant HRTIM_TIMD_RSTDR_EXTEVNT2                        \ External Event 2
$00000800 constant HRTIM_TIMD_RSTDR_EXTEVNT3                        \ External Event 3
$00001000 constant HRTIM_TIMD_RSTDR_EXTEVNT4                        \ External Event 4
$00002000 constant HRTIM_TIMD_RSTDR_EXTEVNT5                        \ External Event 5
$00004000 constant HRTIM_TIMD_RSTDR_EXTEVNT6                        \ External Event 6
$00008000 constant HRTIM_TIMD_RSTDR_EXTEVNT7                        \ External Event 7
$00010000 constant HRTIM_TIMD_RSTDR_EXTEVNT8                        \ External Event 8
$00020000 constant HRTIM_TIMD_RSTDR_EXTEVNT9                        \ External Event 9
$00040000 constant HRTIM_TIMD_RSTDR_EXTEVNT10                       \ External Event 10
$00080000 constant HRTIM_TIMD_RSTDR_TIMACMP1                        \ Timer A Compare 1
$00100000 constant HRTIM_TIMD_RSTDR_TIMACMP2                        \ Timer A Compare 2
$00200000 constant HRTIM_TIMD_RSTDR_TIMACMP4                        \ Timer A Compare 4
$00400000 constant HRTIM_TIMD_RSTDR_TIMBCMP1                        \ Timer B Compare 1
$00800000 constant HRTIM_TIMD_RSTDR_TIMBCMP2                        \ Timer B Compare 2
$01000000 constant HRTIM_TIMD_RSTDR_TIMBCMP4                        \ Timer B Compare 4
$02000000 constant HRTIM_TIMD_RSTDR_TIMCCMP1                        \ Timer C Compare 1
$04000000 constant HRTIM_TIMD_RSTDR_TIMCCMP2                        \ Timer C Compare 2
$08000000 constant HRTIM_TIMD_RSTDR_TIMCCMP4                        \ Timer C Compare 4
$10000000 constant HRTIM_TIMD_RSTDR_TIMECMP1                        \ Timer E Compare 1
$20000000 constant HRTIM_TIMD_RSTDR_TIMECMP2                        \ Timer E Compare 2
$40000000 constant HRTIM_TIMD_RSTDR_TIMECMP4                        \ Timer E Compare 4


\
\ @brief Timerx Chopper Register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$0000000f constant HRTIM_TIMD_CHPDR_CHPFRQ                          \ Timerx carrier frequency value
$00000070 constant HRTIM_TIMD_CHPDR_CHPDTY                          \ Timerx chopper duty cycle value
$00000780 constant HRTIM_TIMD_CHPDR_STRTPW                          \ STRTPW


\
\ @brief Timerx Capture 2 Control Register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMD_CPT1DCR_SWCPT                         \ Software Capture
$00000002 constant HRTIM_TIMD_CPT1DCR_UDPCPT                        \ Update Capture
$00000004 constant HRTIM_TIMD_CPT1DCR_EXEV1CPT                      \ External Event 1 Capture
$00000008 constant HRTIM_TIMD_CPT1DCR_EXEV2CPT                      \ External Event 2 Capture
$00000010 constant HRTIM_TIMD_CPT1DCR_EXEV3CPT                      \ External Event 3 Capture
$00000020 constant HRTIM_TIMD_CPT1DCR_EXEV4CPT                      \ External Event 4 Capture
$00000040 constant HRTIM_TIMD_CPT1DCR_EXEV5CPT                      \ External Event 5 Capture
$00000080 constant HRTIM_TIMD_CPT1DCR_EXEV6CPT                      \ External Event 6 Capture
$00000100 constant HRTIM_TIMD_CPT1DCR_EXEV7CPT                      \ External Event 7 Capture
$00000200 constant HRTIM_TIMD_CPT1DCR_EXEV8CPT                      \ External Event 8 Capture
$00000400 constant HRTIM_TIMD_CPT1DCR_EXEV9CPT                      \ External Event 9 Capture
$00000800 constant HRTIM_TIMD_CPT1DCR_EXEV10CPT                     \ External Event 10 Capture
$00001000 constant HRTIM_TIMD_CPT1DCR_TA1SET                        \ Timer A output 1 Set
$00002000 constant HRTIM_TIMD_CPT1DCR_TA1RST                        \ Timer A output 1 Reset
$00004000 constant HRTIM_TIMD_CPT1DCR_TACMP1                        \ Timer A Compare 1
$00008000 constant HRTIM_TIMD_CPT1DCR_TACMP2                        \ Timer A Compare 2
$00010000 constant HRTIM_TIMD_CPT1DCR_TB1SET                        \ Timer B output 1 Set
$00020000 constant HRTIM_TIMD_CPT1DCR_TB1RST                        \ Timer B output 1 Reset
$00040000 constant HRTIM_TIMD_CPT1DCR_TBCMP1                        \ Timer B Compare 1
$00080000 constant HRTIM_TIMD_CPT1DCR_TBCMP2                        \ Timer B Compare 2
$00100000 constant HRTIM_TIMD_CPT1DCR_TC1SET                        \ Timer C output 1 Set
$00200000 constant HRTIM_TIMD_CPT1DCR_TC1RST                        \ Timer C output 1 Reset
$00400000 constant HRTIM_TIMD_CPT1DCR_TCCMP1                        \ Timer C Compare 1
$00800000 constant HRTIM_TIMD_CPT1DCR_TCCMP2                        \ Timer C Compare 2
$10000000 constant HRTIM_TIMD_CPT1DCR_TE1SET                        \ Timer E output 1 Set
$20000000 constant HRTIM_TIMD_CPT1DCR_TE1RST                        \ Timer E output 1 Reset
$40000000 constant HRTIM_TIMD_CPT1DCR_TECMP1                        \ Timer E Compare 1
$80000000 constant HRTIM_TIMD_CPT1DCR_TECMP2                        \ Timer E Compare 2


\
\ @brief CPT2xCR
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMD_CPT2DCR_SWCPT                         \ Software Capture
$00000002 constant HRTIM_TIMD_CPT2DCR_UDPCPT                        \ Update Capture
$00000004 constant HRTIM_TIMD_CPT2DCR_EXEV1CPT                      \ External Event 1 Capture
$00000008 constant HRTIM_TIMD_CPT2DCR_EXEV2CPT                      \ External Event 2 Capture
$00000010 constant HRTIM_TIMD_CPT2DCR_EXEV3CPT                      \ External Event 3 Capture
$00000020 constant HRTIM_TIMD_CPT2DCR_EXEV4CPT                      \ External Event 4 Capture
$00000040 constant HRTIM_TIMD_CPT2DCR_EXEV5CPT                      \ External Event 5 Capture
$00000080 constant HRTIM_TIMD_CPT2DCR_EXEV6CPT                      \ External Event 6 Capture
$00000100 constant HRTIM_TIMD_CPT2DCR_EXEV7CPT                      \ External Event 7 Capture
$00000200 constant HRTIM_TIMD_CPT2DCR_EXEV8CPT                      \ External Event 8 Capture
$00000400 constant HRTIM_TIMD_CPT2DCR_EXEV9CPT                      \ External Event 9 Capture
$00000800 constant HRTIM_TIMD_CPT2DCR_EXEV10CPT                     \ External Event 10 Capture
$00001000 constant HRTIM_TIMD_CPT2DCR_TA1SET                        \ Timer A output 1 Set
$00002000 constant HRTIM_TIMD_CPT2DCR_TA1RST                        \ Timer A output 1 Reset
$00004000 constant HRTIM_TIMD_CPT2DCR_TACMP1                        \ Timer A Compare 1
$00008000 constant HRTIM_TIMD_CPT2DCR_TACMP2                        \ Timer A Compare 2
$00010000 constant HRTIM_TIMD_CPT2DCR_TB1SET                        \ Timer B output 1 Set
$00020000 constant HRTIM_TIMD_CPT2DCR_TB1RST                        \ Timer B output 1 Reset
$00040000 constant HRTIM_TIMD_CPT2DCR_TBCMP1                        \ Timer B Compare 1
$00080000 constant HRTIM_TIMD_CPT2DCR_TBCMP2                        \ Timer B Compare 2
$00100000 constant HRTIM_TIMD_CPT2DCR_TC1SET                        \ Timer C output 1 Set
$00200000 constant HRTIM_TIMD_CPT2DCR_TC1RST                        \ Timer C output 1 Reset
$00400000 constant HRTIM_TIMD_CPT2DCR_TCCMP1                        \ Timer C Compare 1
$00800000 constant HRTIM_TIMD_CPT2DCR_TCCMP2                        \ Timer C Compare 2
$10000000 constant HRTIM_TIMD_CPT2DCR_TE1SET                        \ Timer E output 1 Set
$20000000 constant HRTIM_TIMD_CPT2DCR_TE1RST                        \ Timer E output 1 Reset
$40000000 constant HRTIM_TIMD_CPT2DCR_TECMP1                        \ Timer E Compare 1
$80000000 constant HRTIM_TIMD_CPT2DCR_TECMP2                        \ Timer E Compare 2


\
\ @brief Timerx Output Register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000002 constant HRTIM_TIMD_OUTDR_POL1                            \ Output 1 polarity
$00000004 constant HRTIM_TIMD_OUTDR_IDLEM1                          \ Output 1 Idle mode
$00000008 constant HRTIM_TIMD_OUTDR_IDLES1                          \ Output 1 Idle State
$00000030 constant HRTIM_TIMD_OUTDR_FAULT1                          \ Output 1 Fault state
$00000040 constant HRTIM_TIMD_OUTDR_CHP1                            \ Output 1 Chopper enable
$00000080 constant HRTIM_TIMD_OUTDR_DIDL1                           \ Output 1 Deadtime upon burst mode Idle entry
$00000100 constant HRTIM_TIMD_OUTDR_DTEN                            \ Deadtime enable
$00000200 constant HRTIM_TIMD_OUTDR_DLYPRTEN                        \ Delayed Protection Enable
$00001c00 constant HRTIM_TIMD_OUTDR_DLYPRT                          \ Delayed Protection
$00020000 constant HRTIM_TIMD_OUTDR_POL2                            \ Output 2 polarity
$00040000 constant HRTIM_TIMD_OUTDR_IDLEM2                          \ Output 2 Idle mode
$00080000 constant HRTIM_TIMD_OUTDR_IDLES2                          \ Output 2 Idle State
$00300000 constant HRTIM_TIMD_OUTDR_FAULT2                          \ Output 2 Fault state
$00400000 constant HRTIM_TIMD_OUTDR_CHP2                            \ Output 2 Chopper enable
$00800000 constant HRTIM_TIMD_OUTDR_DIDL2                           \ Output 2 Deadtime upon burst mode Idle entry


\
\ @brief Timerx Fault Register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_TIMD_FLTDR_FLT1EN                          \ Fault 1 enable
$00000002 constant HRTIM_TIMD_FLTDR_FLT2EN                          \ Fault 2 enable
$00000004 constant HRTIM_TIMD_FLTDR_FLT3EN                          \ Fault 3 enable
$00000008 constant HRTIM_TIMD_FLTDR_FLT4EN                          \ Fault 4 enable
$00000010 constant HRTIM_TIMD_FLTDR_FLT5EN                          \ Fault 5 enable
$80000000 constant HRTIM_TIMD_FLTDR_FLTLCK                          \ Fault sources Lock


\
\ @brief High Resolution Timer: TIMD
\
$40017600 constant HRTIM_TIMD_TIMDCR  \ offset: 0x00 : Timerx Control Register
$40017604 constant HRTIM_TIMD_TIMDISR  \ offset: 0x04 : Timerx Interrupt Status Register
$40017608 constant HRTIM_TIMD_TIMDICR  \ offset: 0x08 : Timerx Interrupt Clear Register
$4001760c constant HRTIM_TIMD_TIMDDIER5  \ offset: 0x0C : TIMxDIER5
$40017610 constant HRTIM_TIMD_CNTDR  \ offset: 0x10 : Timerx Counter Register
$40017614 constant HRTIM_TIMD_PERDR  \ offset: 0x14 : Timerx Period Register
$40017618 constant HRTIM_TIMD_REPDR  \ offset: 0x18 : Timerx Repetition Register
$4001761c constant HRTIM_TIMD_CMP1DR  \ offset: 0x1C : Timerx Compare 1 Register
$40017620 constant HRTIM_TIMD_CMP1CDR  \ offset: 0x20 : Timerx Compare 1 Compound Register
$40017624 constant HRTIM_TIMD_CMP2DR  \ offset: 0x24 : Timerx Compare 2 Register
$40017628 constant HRTIM_TIMD_CMP3DR  \ offset: 0x28 : Timerx Compare 3 Register
$4001762c constant HRTIM_TIMD_CMP4DR  \ offset: 0x2C : Timerx Compare 4 Register
$40017630 constant HRTIM_TIMD_CPT1DR  \ offset: 0x30 : Timerx Capture 1 Register
$40017634 constant HRTIM_TIMD_CPT2DR  \ offset: 0x34 : Timerx Capture 2 Register
$40017638 constant HRTIM_TIMD_DTDR  \ offset: 0x38 : Timerx Deadtime Register
$4001763c constant HRTIM_TIMD_SETD1R  \ offset: 0x3C : Timerx Output1 Set Register
$40017640 constant HRTIM_TIMD_RSTD1R  \ offset: 0x40 : Timerx Output1 Reset Register
$40017644 constant HRTIM_TIMD_SETD2R  \ offset: 0x44 : Timerx Output2 Set Register
$40017648 constant HRTIM_TIMD_RSTD2R  \ offset: 0x48 : Timerx Output2 Reset Register
$4001764c constant HRTIM_TIMD_EEFDR1  \ offset: 0x4C : Timerx External Event Filtering Register 1
$40017650 constant HRTIM_TIMD_EEFDR2  \ offset: 0x50 : Timerx External Event Filtering Register 2
$40017654 constant HRTIM_TIMD_RSTDR  \ offset: 0x54 : TimerA Reset Register
$40017658 constant HRTIM_TIMD_CHPDR  \ offset: 0x58 : Timerx Chopper Register
$4001765c constant HRTIM_TIMD_CPT1DCR  \ offset: 0x5C : Timerx Capture 2 Control Register
$40017660 constant HRTIM_TIMD_CPT2DCR  \ offset: 0x60 : CPT2xCR
$40017664 constant HRTIM_TIMD_OUTDR  \ offset: 0x64 : Timerx Output Register
$40017668 constant HRTIM_TIMD_FLTDR  \ offset: 0x68 : Timerx Fault Register

