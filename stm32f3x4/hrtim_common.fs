\
\ @file hrtim_common.fs
\ @brief High Resolution Timer: Common       functions
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Control Register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_CR1_MUDIS                           \ Master Update Disable
$00000002 constant HRTIM_COMMON_CR1_TAUDIS                          \ Timer A Update Disable
$00000004 constant HRTIM_COMMON_CR1_TBUDIS                          \ Timer B Update Disable
$00000008 constant HRTIM_COMMON_CR1_TCUDIS                          \ Timer C Update Disable
$00000010 constant HRTIM_COMMON_CR1_TDUDIS                          \ Timer D Update Disable
$00000020 constant HRTIM_COMMON_CR1_TEUDIS                          \ Timer E Update Disable
$00070000 constant HRTIM_COMMON_CR1_AD1USRC                         \ ADC Trigger 1 Update Source
$00380000 constant HRTIM_COMMON_CR1_AD2USRC                         \ ADC Trigger 2 Update Source
$01c00000 constant HRTIM_COMMON_CR1_AD3USRC                         \ ADC Trigger 3 Update Source
$0e000000 constant HRTIM_COMMON_CR1_AD4USRC                         \ ADC Trigger 4 Update Source


\
\ @brief Control Register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_CR2_MSWU                            \ Master Timer Software update
$00000002 constant HRTIM_COMMON_CR2_TASWU                           \ Timer A Software update
$00000004 constant HRTIM_COMMON_CR2_TBSWU                           \ Timer B Software Update
$00000008 constant HRTIM_COMMON_CR2_TCSWU                           \ Timer C Software Update
$00000010 constant HRTIM_COMMON_CR2_TDSWU                           \ Timer D Software Update
$00000020 constant HRTIM_COMMON_CR2_TESWU                           \ Timer E Software Update
$00000100 constant HRTIM_COMMON_CR2_MRST                            \ Master Counter software reset
$00000200 constant HRTIM_COMMON_CR2_TARST                           \ Timer A counter software reset
$00000400 constant HRTIM_COMMON_CR2_TBRST                           \ Timer B counter software reset
$00000800 constant HRTIM_COMMON_CR2_TCRST                           \ Timer C counter software reset
$00001000 constant HRTIM_COMMON_CR2_TDRST                           \ Timer D counter software reset
$00002000 constant HRTIM_COMMON_CR2_TERST                           \ Timer E counter software reset


\
\ @brief Interrupt Status Register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_ISR_FLT1                            \ Fault 1 Interrupt Flag
$00000002 constant HRTIM_COMMON_ISR_FLT2                            \ Fault 2 Interrupt Flag
$00000004 constant HRTIM_COMMON_ISR_FLT3                            \ Fault 3 Interrupt Flag
$00000008 constant HRTIM_COMMON_ISR_FLT4                            \ Fault 4 Interrupt Flag
$00000010 constant HRTIM_COMMON_ISR_FLT5                            \ Fault 5 Interrupt Flag
$00000020 constant HRTIM_COMMON_ISR_SYSFLT                          \ System Fault Interrupt Flag
$00010000 constant HRTIM_COMMON_ISR_DLLRDY                          \ DLL Ready Interrupt Flag
$00020000 constant HRTIM_COMMON_ISR_BMPER                           \ Burst mode Period Interrupt Flag


\
\ @brief Interrupt Clear Register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_ICR_FLT1C                           \ Fault 1 Interrupt Flag Clear
$00000002 constant HRTIM_COMMON_ICR_FLT2C                           \ Fault 2 Interrupt Flag Clear
$00000004 constant HRTIM_COMMON_ICR_FLT3C                           \ Fault 3 Interrupt Flag Clear
$00000008 constant HRTIM_COMMON_ICR_FLT4C                           \ Fault 4 Interrupt Flag Clear
$00000010 constant HRTIM_COMMON_ICR_FLT5C                           \ Fault 5 Interrupt Flag Clear
$00000020 constant HRTIM_COMMON_ICR_SYSFLTC                         \ System Fault Interrupt Flag Clear
$00010000 constant HRTIM_COMMON_ICR_DLLRDYC                         \ DLL Ready Interrupt flag Clear
$00020000 constant HRTIM_COMMON_ICR_BMPERC                          \ Burst mode period flag Clear


\
\ @brief Interrupt Enable Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_IER_FLT1IE                          \ Fault 1 Interrupt Enable
$00000002 constant HRTIM_COMMON_IER_FLT2IE                          \ Fault 2 Interrupt Enable
$00000004 constant HRTIM_COMMON_IER_FLT3IE                          \ Fault 3 Interrupt Enable
$00000008 constant HRTIM_COMMON_IER_FLT4IE                          \ Fault 4 Interrupt Enable
$00000010 constant HRTIM_COMMON_IER_FLT5IE                          \ Fault 5 Interrupt Enable
$00000020 constant HRTIM_COMMON_IER_SYSFLTE                         \ System Fault Interrupt Enable
$00010000 constant HRTIM_COMMON_IER_DLLRDYIE                        \ DLL Ready Interrupt Enable
$00020000 constant HRTIM_COMMON_IER_BMPERIE                         \ Burst mode period Interrupt Enable


\
\ @brief Output Enable Register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_OENR_TA1OEN                         \ Timer A Output 1 Enable
$00000002 constant HRTIM_COMMON_OENR_TA2OEN                         \ Timer A Output 2 Enable
$00000004 constant HRTIM_COMMON_OENR_TB1OEN                         \ Timer B Output 1 Enable
$00000008 constant HRTIM_COMMON_OENR_TB2OEN                         \ Timer B Output 2 Enable
$00000010 constant HRTIM_COMMON_OENR_TC1OEN                         \ Timer C Output 1 Enable
$00000020 constant HRTIM_COMMON_OENR_TC2OEN                         \ Timer C Output 2 Enable
$00000040 constant HRTIM_COMMON_OENR_TD1OEN                         \ Timer D Output 1 Enable
$00000080 constant HRTIM_COMMON_OENR_TD2OEN                         \ Timer D Output 2 Enable
$00000100 constant HRTIM_COMMON_OENR_TE1OEN                         \ Timer E Output 1 Enable
$00000200 constant HRTIM_COMMON_OENR_TE2OEN                         \ Timer E Output 2 Enable


\
\ @brief DISR
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_ODISR_TA1ODIS                       \ TA1ODIS
$00000002 constant HRTIM_COMMON_ODISR_TA2ODIS                       \ TA2ODIS
$00000004 constant HRTIM_COMMON_ODISR_TB1ODIS                       \ TB1ODIS
$00000008 constant HRTIM_COMMON_ODISR_TB2ODIS                       \ TB2ODIS
$00000010 constant HRTIM_COMMON_ODISR_TC1ODIS                       \ TC1ODIS
$00000020 constant HRTIM_COMMON_ODISR_TC2ODIS                       \ TC2ODIS
$00000040 constant HRTIM_COMMON_ODISR_TD1ODIS                       \ TD1ODIS
$00000080 constant HRTIM_COMMON_ODISR_TD2ODIS                       \ TD2ODIS
$00000100 constant HRTIM_COMMON_ODISR_TE1ODIS                       \ TE1ODIS
$00000200 constant HRTIM_COMMON_ODISR_TE2ODIS                       \ TE2ODIS


\
\ @brief Output Disable Status Register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_ODSR_TA1ODS                         \ Timer A Output 1 disable status
$00000002 constant HRTIM_COMMON_ODSR_TA2ODS                         \ Timer A Output 2 disable status
$00000004 constant HRTIM_COMMON_ODSR_TB1ODS                         \ Timer B Output 1 disable status
$00000008 constant HRTIM_COMMON_ODSR_TB2ODS                         \ Timer B Output 2 disable status
$00000010 constant HRTIM_COMMON_ODSR_TC1ODS                         \ Timer C Output 1 disable status
$00000020 constant HRTIM_COMMON_ODSR_TC2ODS                         \ Timer C Output 2 disable status
$00000040 constant HRTIM_COMMON_ODSR_TD1ODS                         \ Timer D Output 1 disable status
$00000080 constant HRTIM_COMMON_ODSR_TD2ODS                         \ Timer D Output 2 disable status
$00000100 constant HRTIM_COMMON_ODSR_TE1ODS                         \ Timer E Output 1 disable status
$00000200 constant HRTIM_COMMON_ODSR_TE2ODS                         \ Timer E Output 2 disable status


\
\ @brief Burst Mode Control Register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_BMCR_BME                            \ Burst Mode enable
$00000002 constant HRTIM_COMMON_BMCR_BMOM                           \ Burst Mode operating mode
$0000003c constant HRTIM_COMMON_BMCR_BMCLK                          \ Burst Mode Clock source
$000003c0 constant HRTIM_COMMON_BMCR_BMPRSC                         \ Burst Mode Prescaler
$00000400 constant HRTIM_COMMON_BMCR_BMPREN                         \ Burst Mode Preload Enable
$00010000 constant HRTIM_COMMON_BMCR_MTBM                           \ Master Timer Burst Mode
$00020000 constant HRTIM_COMMON_BMCR_TABM                           \ Timer A Burst Mode
$00040000 constant HRTIM_COMMON_BMCR_TBBM                           \ Timer B Burst Mode
$00080000 constant HRTIM_COMMON_BMCR_TCBM                           \ Timer C Burst Mode
$00100000 constant HRTIM_COMMON_BMCR_TDBM                           \ Timer D Burst Mode
$00200000 constant HRTIM_COMMON_BMCR_TEBM                           \ Timer E Burst Mode
$80000000 constant HRTIM_COMMON_BMCR_BMSTAT                         \ Burst Mode Status


\
\ @brief BMTRGR
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_BMTRGR_SW                           \ SW
$00000002 constant HRTIM_COMMON_BMTRGR_MSTRST                       \ MSTRST
$00000004 constant HRTIM_COMMON_BMTRGR_MSTREP                       \ MSTREP
$00000008 constant HRTIM_COMMON_BMTRGR_MSTCMP1                      \ MSTCMP1
$00000010 constant HRTIM_COMMON_BMTRGR_MSTCMP2                      \ MSTCMP2
$00000020 constant HRTIM_COMMON_BMTRGR_MSTCMP3                      \ MSTCMP3
$00000040 constant HRTIM_COMMON_BMTRGR_MSTCMP4                      \ MSTCMP4
$00000080 constant HRTIM_COMMON_BMTRGR_TARST                        \ TARST
$00000100 constant HRTIM_COMMON_BMTRGR_TAREP                        \ TAREP
$00000200 constant HRTIM_COMMON_BMTRGR_TACMP1                       \ TACMP1
$00000400 constant HRTIM_COMMON_BMTRGR_TACMP2                       \ TACMP2
$00000800 constant HRTIM_COMMON_BMTRGR_TBRST                        \ TBRST
$00001000 constant HRTIM_COMMON_BMTRGR_TBREP                        \ TBREP
$00002000 constant HRTIM_COMMON_BMTRGR_TBCMP1                       \ TBCMP1
$00004000 constant HRTIM_COMMON_BMTRGR_TBCMP2                       \ TBCMP2
$00008000 constant HRTIM_COMMON_BMTRGR_TCRST                        \ TCRST
$00010000 constant HRTIM_COMMON_BMTRGR_TCREP                        \ TCREP
$00020000 constant HRTIM_COMMON_BMTRGR_TCCMP1                       \ TCCMP1
$00040000 constant HRTIM_COMMON_BMTRGR_TCCMP2                       \ TCCMP2
$00080000 constant HRTIM_COMMON_BMTRGR_TDRST                        \ TDRST
$00100000 constant HRTIM_COMMON_BMTRGR_TDREP                        \ TDREP
$00200000 constant HRTIM_COMMON_BMTRGR_TDCMP1                       \ TDCMP1
$00400000 constant HRTIM_COMMON_BMTRGR_TDCMP2                       \ TDCMP2
$00800000 constant HRTIM_COMMON_BMTRGR_TERST                        \ TERST
$01000000 constant HRTIM_COMMON_BMTRGR_TEREP                        \ TEREP
$02000000 constant HRTIM_COMMON_BMTRGR_TECMP1                       \ TECMP1
$04000000 constant HRTIM_COMMON_BMTRGR_TECMP2                       \ TECMP2
$08000000 constant HRTIM_COMMON_BMTRGR_TAEEV7                       \ TAEEV7
$10000000 constant HRTIM_COMMON_BMTRGR_TDEEV8                       \ TDEEV8
$20000000 constant HRTIM_COMMON_BMTRGR_EEV7                         \ EEV7
$40000000 constant HRTIM_COMMON_BMTRGR_EEV8                         \ EEV8
$80000000 constant HRTIM_COMMON_BMTRGR_OCHPEV                       \ OCHPEV


\
\ @brief BMCMPR
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_COMMON_BMCMPR_BMCMP                        \ BMCMP


\
\ @brief Burst Mode Period Register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant HRTIM_COMMON_BMPER_BMPER                         \ Burst mode Period


\
\ @brief Timer External Event Control Register 1
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000003 constant HRTIM_COMMON_EECR1_EE1SRC                        \ External Event 1 Source
$00000004 constant HRTIM_COMMON_EECR1_EE1POL                        \ External Event 1 Polarity
$00000018 constant HRTIM_COMMON_EECR1_EE1SNS                        \ External Event 1 Sensitivity
$00000020 constant HRTIM_COMMON_EECR1_EE1FAST                       \ External Event 1 Fast mode
$000000c0 constant HRTIM_COMMON_EECR1_EE2SRC                        \ External Event 2 Source
$00000100 constant HRTIM_COMMON_EECR1_EE2POL                        \ External Event 2 Polarity
$00000600 constant HRTIM_COMMON_EECR1_EE2SNS                        \ External Event 2 Sensitivity
$00000800 constant HRTIM_COMMON_EECR1_EE2FAST                       \ External Event 2 Fast mode
$00003000 constant HRTIM_COMMON_EECR1_EE3SRC                        \ External Event 3 Source
$00004000 constant HRTIM_COMMON_EECR1_EE3POL                        \ External Event 3 Polarity
$00018000 constant HRTIM_COMMON_EECR1_EE3SNS                        \ External Event 3 Sensitivity
$00020000 constant HRTIM_COMMON_EECR1_EE3FAST                       \ External Event 3 Fast mode
$000c0000 constant HRTIM_COMMON_EECR1_EE4SRC                        \ External Event 4 Source
$00100000 constant HRTIM_COMMON_EECR1_EE4POL                        \ External Event 4 Polarity
$00600000 constant HRTIM_COMMON_EECR1_EE4SNS                        \ External Event 4 Sensitivity
$00800000 constant HRTIM_COMMON_EECR1_EE4FAST                       \ External Event 4 Fast mode
$03000000 constant HRTIM_COMMON_EECR1_EE5SRC                        \ External Event 5 Source
$04000000 constant HRTIM_COMMON_EECR1_EE5POL                        \ External Event 5 Polarity
$18000000 constant HRTIM_COMMON_EECR1_EE5SNS                        \ External Event 5 Sensitivity
$20000000 constant HRTIM_COMMON_EECR1_EE5FAST                       \ External Event 5 Fast mode


\
\ @brief Timer External Event Control Register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000003 constant HRTIM_COMMON_EECR2_EE6SRC                        \ External Event 6 Source
$00000004 constant HRTIM_COMMON_EECR2_EE6POL                        \ External Event 6 Polarity
$00000018 constant HRTIM_COMMON_EECR2_EE6SNS                        \ External Event 6 Sensitivity
$000000c0 constant HRTIM_COMMON_EECR2_EE7SRC                        \ External Event 7 Source
$00000100 constant HRTIM_COMMON_EECR2_EE7POL                        \ External Event 7 Polarity
$00000600 constant HRTIM_COMMON_EECR2_EE7SNS                        \ External Event 7 Sensitivity
$00003000 constant HRTIM_COMMON_EECR2_EE8SRC                        \ External Event 8 Source
$00004000 constant HRTIM_COMMON_EECR2_EE8POL                        \ External Event 8 Polarity
$00018000 constant HRTIM_COMMON_EECR2_EE8SNS                        \ External Event 8 Sensitivity
$000c0000 constant HRTIM_COMMON_EECR2_EE9SRC                        \ External Event 9 Source
$00100000 constant HRTIM_COMMON_EECR2_EE9POL                        \ External Event 9 Polarity
$00600000 constant HRTIM_COMMON_EECR2_EE9SNS                        \ External Event 9 Sensitivity
$03000000 constant HRTIM_COMMON_EECR2_EE10SRC                       \ External Event 10 Source
$04000000 constant HRTIM_COMMON_EECR2_EE10POL                       \ External Event 10 Polarity
$18000000 constant HRTIM_COMMON_EECR2_EE10SNS                       \ External Event 10 Sensitivity


\
\ @brief Timer External Event Control Register 3
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000000f constant HRTIM_COMMON_EECR3_EE6F                          \ EE6F
$000003c0 constant HRTIM_COMMON_EECR3_EE7F                          \ EE7F
$0000f000 constant HRTIM_COMMON_EECR3_EE8F                          \ EE8F
$003c0000 constant HRTIM_COMMON_EECR3_EE9F                          \ EE9F
$0f000000 constant HRTIM_COMMON_EECR3_EE10F                         \ EE10F
$c0000000 constant HRTIM_COMMON_EECR3_EEVSD                         \ EEVSD


\
\ @brief ADC Trigger 1 Register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_ADC1R_AD1MC1                        \ ADC trigger 1 on Master Compare 1
$00000002 constant HRTIM_COMMON_ADC1R_AD1MC2                        \ ADC trigger 1 on Master Compare 2
$00000004 constant HRTIM_COMMON_ADC1R_AD1MC3                        \ ADC trigger 1 on Master Compare 3
$00000008 constant HRTIM_COMMON_ADC1R_AD1MC4                        \ ADC trigger 1 on Master Compare 4
$00000010 constant HRTIM_COMMON_ADC1R_AD1MPER                       \ ADC trigger 1 on Master Period
$00000020 constant HRTIM_COMMON_ADC1R_AD1EEV1                       \ ADC trigger 1 on External Event 1
$00000040 constant HRTIM_COMMON_ADC1R_AD1EEV2                       \ ADC trigger 1 on External Event 2
$00000080 constant HRTIM_COMMON_ADC1R_AD1EEV3                       \ ADC trigger 1 on External Event 3
$00000100 constant HRTIM_COMMON_ADC1R_AD1EEV4                       \ ADC trigger 1 on External Event 4
$00000200 constant HRTIM_COMMON_ADC1R_AD1EEV5                       \ ADC trigger 1 on External Event 5
$00000400 constant HRTIM_COMMON_ADC1R_AD1TAC2                       \ ADC trigger 1 on Timer A compare 2
$00000800 constant HRTIM_COMMON_ADC1R_AD1TAC3                       \ ADC trigger 1 on Timer A compare 3
$00001000 constant HRTIM_COMMON_ADC1R_AD1TAC4                       \ ADC trigger 1 on Timer A compare 4
$00002000 constant HRTIM_COMMON_ADC1R_AD1TAPER                      \ ADC trigger 1 on Timer A Period
$00004000 constant HRTIM_COMMON_ADC1R_AD1TARST                      \ ADC trigger 1 on Timer A Reset
$00008000 constant HRTIM_COMMON_ADC1R_AD1TBC2                       \ ADC trigger 1 on Timer B compare 2
$00010000 constant HRTIM_COMMON_ADC1R_AD1TBC3                       \ ADC trigger 1 on Timer B compare 3
$00020000 constant HRTIM_COMMON_ADC1R_AD1TBC4                       \ ADC trigger 1 on Timer B compare 4
$00040000 constant HRTIM_COMMON_ADC1R_AD1TBPER                      \ ADC trigger 1 on Timer B Period
$00080000 constant HRTIM_COMMON_ADC1R_AD1TBRST                      \ ADC trigger 1 on Timer B Reset
$00100000 constant HRTIM_COMMON_ADC1R_AD1TCC2                       \ ADC trigger 1 on Timer C compare 2
$00200000 constant HRTIM_COMMON_ADC1R_AD1TCC3                       \ ADC trigger 1 on Timer C compare 3
$00400000 constant HRTIM_COMMON_ADC1R_AD1TCC4                       \ ADC trigger 1 on Timer C compare 4
$00800000 constant HRTIM_COMMON_ADC1R_AD1TCPER                      \ ADC trigger 1 on Timer C Period
$01000000 constant HRTIM_COMMON_ADC1R_AD1TDC2                       \ ADC trigger 1 on Timer D compare 2
$02000000 constant HRTIM_COMMON_ADC1R_AD1TDC3                       \ ADC trigger 1 on Timer D compare 3
$04000000 constant HRTIM_COMMON_ADC1R_AD1TDC4                       \ ADC trigger 1 on Timer D compare 4
$08000000 constant HRTIM_COMMON_ADC1R_AD1TDPER                      \ ADC trigger 1 on Timer D Period
$10000000 constant HRTIM_COMMON_ADC1R_AD1TEC2                       \ ADC trigger 1 on Timer E compare 2
$20000000 constant HRTIM_COMMON_ADC1R_AD1TEC3                       \ ADC trigger 1 on Timer E compare 3
$40000000 constant HRTIM_COMMON_ADC1R_AD1TEC4                       \ ADC trigger 1 on Timer E compare 4
$80000000 constant HRTIM_COMMON_ADC1R_AD1TEPER                      \ ADC trigger 1 on Timer E Period


\
\ @brief ADC Trigger 2 Register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_ADC2R_AD2MC1                        \ ADC trigger 2 on Master Compare 1
$00000002 constant HRTIM_COMMON_ADC2R_AD2MC2                        \ ADC trigger 2 on Master Compare 2
$00000004 constant HRTIM_COMMON_ADC2R_AD2MC3                        \ ADC trigger 2 on Master Compare 3
$00000008 constant HRTIM_COMMON_ADC2R_AD2MC4                        \ ADC trigger 2 on Master Compare 4
$00000010 constant HRTIM_COMMON_ADC2R_AD2MPER                       \ ADC trigger 2 on Master Period
$00000020 constant HRTIM_COMMON_ADC2R_AD2EEV6                       \ ADC trigger 2 on External Event 6
$00000040 constant HRTIM_COMMON_ADC2R_AD2EEV7                       \ ADC trigger 2 on External Event 7
$00000080 constant HRTIM_COMMON_ADC2R_AD2EEV8                       \ ADC trigger 2 on External Event 8
$00000100 constant HRTIM_COMMON_ADC2R_AD2EEV9                       \ ADC trigger 2 on External Event 9
$00000200 constant HRTIM_COMMON_ADC2R_AD2EEV10                      \ ADC trigger 2 on External Event 10
$00000400 constant HRTIM_COMMON_ADC2R_AD2TAC2                       \ ADC trigger 2 on Timer A compare 2
$00000800 constant HRTIM_COMMON_ADC2R_AD2TAC3                       \ ADC trigger 2 on Timer A compare 3
$00001000 constant HRTIM_COMMON_ADC2R_AD2TAC4                       \ ADC trigger 2 on Timer A compare 4
$00002000 constant HRTIM_COMMON_ADC2R_AD2TAPER                      \ ADC trigger 2 on Timer A Period
$00004000 constant HRTIM_COMMON_ADC2R_AD2TBC2                       \ ADC trigger 2 on Timer B compare 2
$00008000 constant HRTIM_COMMON_ADC2R_AD2TBC3                       \ ADC trigger 2 on Timer B compare 3
$00010000 constant HRTIM_COMMON_ADC2R_AD2TBC4                       \ ADC trigger 2 on Timer B compare 4
$00020000 constant HRTIM_COMMON_ADC2R_AD2TBPER                      \ ADC trigger 2 on Timer B Period
$00040000 constant HRTIM_COMMON_ADC2R_AD2TCC2                       \ ADC trigger 2 on Timer C compare 2
$00080000 constant HRTIM_COMMON_ADC2R_AD2TCC3                       \ ADC trigger 2 on Timer C compare 3
$00100000 constant HRTIM_COMMON_ADC2R_AD2TCC4                       \ ADC trigger 2 on Timer C compare 4
$00200000 constant HRTIM_COMMON_ADC2R_AD2TCPER                      \ ADC trigger 2 on Timer C Period
$00400000 constant HRTIM_COMMON_ADC2R_AD2TCRST                      \ ADC trigger 2 on Timer C Reset
$00800000 constant HRTIM_COMMON_ADC2R_AD2TDC2                       \ ADC trigger 2 on Timer D compare 2
$01000000 constant HRTIM_COMMON_ADC2R_AD2TDC3                       \ ADC trigger 2 on Timer D compare 3
$02000000 constant HRTIM_COMMON_ADC2R_AD2TDC4                       \ ADC trigger 2 on Timer D compare 4
$04000000 constant HRTIM_COMMON_ADC2R_AD2TDPER                      \ ADC trigger 2 on Timer D Period
$08000000 constant HRTIM_COMMON_ADC2R_AD2TDRST                      \ ADC trigger 2 on Timer D Reset
$10000000 constant HRTIM_COMMON_ADC2R_AD2TEC2                       \ ADC trigger 2 on Timer E compare 2
$20000000 constant HRTIM_COMMON_ADC2R_AD2TEC3                       \ ADC trigger 2 on Timer E compare 3
$40000000 constant HRTIM_COMMON_ADC2R_AD2TEC4                       \ ADC trigger 2 on Timer E compare 4
$80000000 constant HRTIM_COMMON_ADC2R_AD2TERST                      \ ADC trigger 2 on Timer E Reset


\
\ @brief ADC Trigger 3 Register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_ADC3R_AD1MC1                        \ AD1MC1
$00000002 constant HRTIM_COMMON_ADC3R_AD1MC2                        \ AD1MC2
$00000004 constant HRTIM_COMMON_ADC3R_AD1MC3                        \ AD1MC3
$00000008 constant HRTIM_COMMON_ADC3R_AD1MC4                        \ AD1MC4
$00000010 constant HRTIM_COMMON_ADC3R_AD1MPER                       \ AD1MPER
$00000020 constant HRTIM_COMMON_ADC3R_AD1EEV1                       \ AD1EEV1
$00000040 constant HRTIM_COMMON_ADC3R_AD1EEV2                       \ AD1EEV2
$00000080 constant HRTIM_COMMON_ADC3R_AD1EEV3                       \ AD1EEV3
$00000100 constant HRTIM_COMMON_ADC3R_AD1EEV4                       \ AD1EEV4
$00000200 constant HRTIM_COMMON_ADC3R_AD1EEV5                       \ AD1EEV5
$00000400 constant HRTIM_COMMON_ADC3R_AD1TAC2                       \ AD1TAC2
$00000800 constant HRTIM_COMMON_ADC3R_AD1TAC3                       \ AD1TAC3
$00001000 constant HRTIM_COMMON_ADC3R_AD1TAC4                       \ AD1TAC4
$00002000 constant HRTIM_COMMON_ADC3R_AD1TAPER                      \ AD1TAPER
$00004000 constant HRTIM_COMMON_ADC3R_AD1TARST                      \ AD1TARST
$00008000 constant HRTIM_COMMON_ADC3R_AD1TBC2                       \ AD1TBC2
$00010000 constant HRTIM_COMMON_ADC3R_AD1TBC3                       \ AD1TBC3
$00020000 constant HRTIM_COMMON_ADC3R_AD1TBC4                       \ AD1TBC4
$00040000 constant HRTIM_COMMON_ADC3R_AD1TBPER                      \ AD1TBPER
$00080000 constant HRTIM_COMMON_ADC3R_AD1TBRST                      \ AD1TBRST
$00100000 constant HRTIM_COMMON_ADC3R_AD1TCC2                       \ AD1TCC2
$00200000 constant HRTIM_COMMON_ADC3R_AD1TCC3                       \ AD1TCC3
$00400000 constant HRTIM_COMMON_ADC3R_AD1TCC4                       \ AD1TCC4
$00800000 constant HRTIM_COMMON_ADC3R_AD1TCPER                      \ AD1TCPER
$01000000 constant HRTIM_COMMON_ADC3R_AD1TDC2                       \ AD1TDC2
$02000000 constant HRTIM_COMMON_ADC3R_AD1TDC3                       \ AD1TDC3
$04000000 constant HRTIM_COMMON_ADC3R_AD1TDC4                       \ AD1TDC4
$08000000 constant HRTIM_COMMON_ADC3R_AD1TDPER                      \ AD1TDPER
$10000000 constant HRTIM_COMMON_ADC3R_AD1TEC2                       \ AD1TEC2
$20000000 constant HRTIM_COMMON_ADC3R_AD1TEC3                       \ AD1TEC3
$40000000 constant HRTIM_COMMON_ADC3R_AD1TEC4                       \ AD1TEC4
$80000000 constant HRTIM_COMMON_ADC3R_AD1TEPER                      \ AD1TEPER


\
\ @brief ADC Trigger 4 Register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_ADC4R_AD2MC1                        \ AD2MC1
$00000002 constant HRTIM_COMMON_ADC4R_AD2MC2                        \ AD2MC2
$00000004 constant HRTIM_COMMON_ADC4R_AD2MC3                        \ AD2MC3
$00000008 constant HRTIM_COMMON_ADC4R_AD2MC4                        \ AD2MC4
$00000010 constant HRTIM_COMMON_ADC4R_AD2MPER                       \ AD2MPER
$00000020 constant HRTIM_COMMON_ADC4R_AD2EEV6                       \ AD2EEV6
$00000040 constant HRTIM_COMMON_ADC4R_AD2EEV7                       \ AD2EEV7
$00000080 constant HRTIM_COMMON_ADC4R_AD2EEV8                       \ AD2EEV8
$00000100 constant HRTIM_COMMON_ADC4R_AD2EEV9                       \ AD2EEV9
$00000200 constant HRTIM_COMMON_ADC4R_AD2EEV10                      \ AD2EEV10
$00000400 constant HRTIM_COMMON_ADC4R_AD2TAC2                       \ AD2TAC2
$00000800 constant HRTIM_COMMON_ADC4R_AD2TAC3                       \ AD2TAC3
$00001000 constant HRTIM_COMMON_ADC4R_AD2TAC4                       \ AD2TAC4
$00002000 constant HRTIM_COMMON_ADC4R_AD2TAPER                      \ AD2TAPER
$00004000 constant HRTIM_COMMON_ADC4R_AD2TBC2                       \ AD2TBC2
$00008000 constant HRTIM_COMMON_ADC4R_AD2TBC3                       \ AD2TBC3
$00010000 constant HRTIM_COMMON_ADC4R_AD2TBC4                       \ AD2TBC4
$00020000 constant HRTIM_COMMON_ADC4R_AD2TBPER                      \ AD2TBPER
$00040000 constant HRTIM_COMMON_ADC4R_AD2TCC2                       \ AD2TCC2
$00080000 constant HRTIM_COMMON_ADC4R_AD2TCC3                       \ AD2TCC3
$00100000 constant HRTIM_COMMON_ADC4R_AD2TCC4                       \ AD2TCC4
$00200000 constant HRTIM_COMMON_ADC4R_AD2TCPER                      \ AD2TCPER
$00400000 constant HRTIM_COMMON_ADC4R_AD2TCRST                      \ AD2TCRST
$00800000 constant HRTIM_COMMON_ADC4R_AD2TDC2                       \ AD2TDC2
$01000000 constant HRTIM_COMMON_ADC4R_AD2TDC3                       \ AD2TDC3
$02000000 constant HRTIM_COMMON_ADC4R_AD2TDC4                       \ AD2TDC4
$04000000 constant HRTIM_COMMON_ADC4R_AD2TDPER                      \ AD2TDPER
$08000000 constant HRTIM_COMMON_ADC4R_AD2TDRST                      \ AD2TDRST
$10000000 constant HRTIM_COMMON_ADC4R_AD2TEC2                       \ AD2TEC2
$20000000 constant HRTIM_COMMON_ADC4R_AD2TEC3                       \ AD2TEC3
$40000000 constant HRTIM_COMMON_ADC4R_AD2TEC4                       \ AD2TEC4
$80000000 constant HRTIM_COMMON_ADC4R_AD2TERST                      \ AD2TERST


\
\ @brief DLL Control Register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_DLLCR_CAL                           \ DLL Calibration Start
$00000002 constant HRTIM_COMMON_DLLCR_CALEN                         \ DLL Calibration Enable
$0000000c constant HRTIM_COMMON_DLLCR_CALRTE                        \ DLL Calibration rate


\
\ @brief HRTIM Fault Input Register 1
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_FLTINR1_FLT1E                       \ FLT1E
$00000002 constant HRTIM_COMMON_FLTINR1_FLT1P                       \ FLT1P
$00000004 constant HRTIM_COMMON_FLTINR1_FLT1SRC                     \ FLT1SRC
$00000078 constant HRTIM_COMMON_FLTINR1_FLT1F                       \ FLT1F
$00000080 constant HRTIM_COMMON_FLTINR1_FLT1LCK                     \ FLT1LCK
$00000100 constant HRTIM_COMMON_FLTINR1_FLT2E                       \ FLT2E
$00000200 constant HRTIM_COMMON_FLTINR1_FLT2P                       \ FLT2P
$00000400 constant HRTIM_COMMON_FLTINR1_FLT2SRC                     \ FLT2SRC
$00007800 constant HRTIM_COMMON_FLTINR1_FLT2F                       \ FLT2F
$00008000 constant HRTIM_COMMON_FLTINR1_FLT2LCK                     \ FLT2LCK
$00010000 constant HRTIM_COMMON_FLTINR1_FLT3E                       \ FLT3E
$00020000 constant HRTIM_COMMON_FLTINR1_FLT3P                       \ FLT3P
$00040000 constant HRTIM_COMMON_FLTINR1_FLT3SRC                     \ FLT3SRC
$00780000 constant HRTIM_COMMON_FLTINR1_FLT3F                       \ FLT3F
$00800000 constant HRTIM_COMMON_FLTINR1_FLT3LCK                     \ FLT3LCK
$01000000 constant HRTIM_COMMON_FLTINR1_FLT4E                       \ FLT4E
$02000000 constant HRTIM_COMMON_FLTINR1_FLT4P                       \ FLT4P
$04000000 constant HRTIM_COMMON_FLTINR1_FLT4SRC                     \ FLT4SRC
$78000000 constant HRTIM_COMMON_FLTINR1_FLT4F                       \ FLT4F
$80000000 constant HRTIM_COMMON_FLTINR1_FLT4LCK                     \ FLT4LCK


\
\ @brief HRTIM Fault Input Register 2
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_FLTINR2_FLT5E                       \ FLT5E
$00000002 constant HRTIM_COMMON_FLTINR2_FLT5P                       \ FLT5P
$00000004 constant HRTIM_COMMON_FLTINR2_FLT5SRC                     \ FLT5SRC
$00000078 constant HRTIM_COMMON_FLTINR2_FLT5F                       \ FLT5F
$00000080 constant HRTIM_COMMON_FLTINR2_FLT5LCK                     \ FLT5LCK
$03000000 constant HRTIM_COMMON_FLTINR2_FLTSD                       \ FLTSD


\
\ @brief BDMUPDR
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_BDMUPDR_MCR                         \ MCR
$00000002 constant HRTIM_COMMON_BDMUPDR_MICR                        \ MICR
$00000004 constant HRTIM_COMMON_BDMUPDR_MDIER                       \ MDIER
$00000008 constant HRTIM_COMMON_BDMUPDR_MCNT                        \ MCNT
$00000010 constant HRTIM_COMMON_BDMUPDR_MPER                        \ MPER
$00000020 constant HRTIM_COMMON_BDMUPDR_MREP                        \ MREP
$00000040 constant HRTIM_COMMON_BDMUPDR_MCMP1                       \ MCMP1
$00000080 constant HRTIM_COMMON_BDMUPDR_MCMP2                       \ MCMP2
$00000100 constant HRTIM_COMMON_BDMUPDR_MCMP3                       \ MCMP3
$00000200 constant HRTIM_COMMON_BDMUPDR_MCMP4                       \ MCMP4


\
\ @brief Burst DMA Timerx update Register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_BDTAUPR_TIMXCR                      \ HRTIM_TIMxCR register update enable
$00000002 constant HRTIM_COMMON_BDTAUPR_TIMXICR                     \ HRTIM_TIMxICR register update enable
$00000004 constant HRTIM_COMMON_BDTAUPR_TIMXDIER                    \ HRTIM_TIMxDIER register update enable
$00000008 constant HRTIM_COMMON_BDTAUPR_TIMXCNT                     \ HRTIM_CNTxR register update enable
$00000010 constant HRTIM_COMMON_BDTAUPR_TIMXPER                     \ HRTIM_PERxR register update enable
$00000020 constant HRTIM_COMMON_BDTAUPR_TIMXREP                     \ HRTIM_REPxR register update enable
$00000040 constant HRTIM_COMMON_BDTAUPR_TIMXCMP1                    \ HRTIM_CMP1xR register update enable
$00000080 constant HRTIM_COMMON_BDTAUPR_TIMXCMP2                    \ HRTIM_CMP2xR register update enable
$00000100 constant HRTIM_COMMON_BDTAUPR_TIMXCMP3                    \ HRTIM_CMP3xR register update enable
$00000200 constant HRTIM_COMMON_BDTAUPR_TIMXCMP4                    \ HRTIM_CMP4xR register update enable
$00000400 constant HRTIM_COMMON_BDTAUPR_TIMX_DTXR                   \ HRTIM_DTxR register update enable
$00000800 constant HRTIM_COMMON_BDTAUPR_TIMXSET1R                   \ HRTIM_SET1xR register update enable
$00001000 constant HRTIM_COMMON_BDTAUPR_TIMXRST1R                   \ HRTIM_RST1xR register update enable
$00002000 constant HRTIM_COMMON_BDTAUPR_TIMXSET2R                   \ HRTIM_SET2xR register update enable
$00004000 constant HRTIM_COMMON_BDTAUPR_TIMXRST2R                   \ HRTIM_RST2xR register update enable
$00008000 constant HRTIM_COMMON_BDTAUPR_TIMXEEFR1                   \ HRTIM_EEFxR1 register update enable
$00010000 constant HRTIM_COMMON_BDTAUPR_TIMXEEFR2                   \ HRTIM_EEFxR2 register update enable
$00020000 constant HRTIM_COMMON_BDTAUPR_TIMXRSTR                    \ HRTIM_RSTxR register update enable
$00040000 constant HRTIM_COMMON_BDTAUPR_TIMXCHPR                    \ HRTIM_CHPxR register update enable
$00080000 constant HRTIM_COMMON_BDTAUPR_TIMXOUTR                    \ HRTIM_OUTxR register update enable
$00100000 constant HRTIM_COMMON_BDTAUPR_TIMXFLTR                    \ HRTIM_FLTxR register update enable


\
\ @brief Burst DMA Timerx update Register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_BDTBUPR_TIMXCR                      \ HRTIM_TIMxCR register update enable
$00000002 constant HRTIM_COMMON_BDTBUPR_TIMXICR                     \ HRTIM_TIMxICR register update enable
$00000004 constant HRTIM_COMMON_BDTBUPR_TIMXDIER                    \ HRTIM_TIMxDIER register update enable
$00000008 constant HRTIM_COMMON_BDTBUPR_TIMXCNT                     \ HRTIM_CNTxR register update enable
$00000010 constant HRTIM_COMMON_BDTBUPR_TIMXPER                     \ HRTIM_PERxR register update enable
$00000020 constant HRTIM_COMMON_BDTBUPR_TIMXREP                     \ HRTIM_REPxR register update enable
$00000040 constant HRTIM_COMMON_BDTBUPR_TIMXCMP1                    \ HRTIM_CMP1xR register update enable
$00000080 constant HRTIM_COMMON_BDTBUPR_TIMXCMP2                    \ HRTIM_CMP2xR register update enable
$00000100 constant HRTIM_COMMON_BDTBUPR_TIMXCMP3                    \ HRTIM_CMP3xR register update enable
$00000200 constant HRTIM_COMMON_BDTBUPR_TIMXCMP4                    \ HRTIM_CMP4xR register update enable
$00000400 constant HRTIM_COMMON_BDTBUPR_TIMX_DTXR                   \ HRTIM_DTxR register update enable
$00000800 constant HRTIM_COMMON_BDTBUPR_TIMXSET1R                   \ HRTIM_SET1xR register update enable
$00001000 constant HRTIM_COMMON_BDTBUPR_TIMXRST1R                   \ HRTIM_RST1xR register update enable
$00002000 constant HRTIM_COMMON_BDTBUPR_TIMXSET2R                   \ HRTIM_SET2xR register update enable
$00004000 constant HRTIM_COMMON_BDTBUPR_TIMXRST2R                   \ HRTIM_RST2xR register update enable
$00008000 constant HRTIM_COMMON_BDTBUPR_TIMXEEFR1                   \ HRTIM_EEFxR1 register update enable
$00010000 constant HRTIM_COMMON_BDTBUPR_TIMXEEFR2                   \ HRTIM_EEFxR2 register update enable
$00020000 constant HRTIM_COMMON_BDTBUPR_TIMXRSTR                    \ HRTIM_RSTxR register update enable
$00040000 constant HRTIM_COMMON_BDTBUPR_TIMXCHPR                    \ HRTIM_CHPxR register update enable
$00080000 constant HRTIM_COMMON_BDTBUPR_TIMXOUTR                    \ HRTIM_OUTxR register update enable
$00100000 constant HRTIM_COMMON_BDTBUPR_TIMXFLTR                    \ HRTIM_FLTxR register update enable


\
\ @brief Burst DMA Timerx update Register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_BDTCUPR_TIMXCR                      \ HRTIM_TIMxCR register update enable
$00000002 constant HRTIM_COMMON_BDTCUPR_TIMXICR                     \ HRTIM_TIMxICR register update enable
$00000004 constant HRTIM_COMMON_BDTCUPR_TIMXDIER                    \ HRTIM_TIMxDIER register update enable
$00000008 constant HRTIM_COMMON_BDTCUPR_TIMXCNT                     \ HRTIM_CNTxR register update enable
$00000010 constant HRTIM_COMMON_BDTCUPR_TIMXPER                     \ HRTIM_PERxR register update enable
$00000020 constant HRTIM_COMMON_BDTCUPR_TIMXREP                     \ HRTIM_REPxR register update enable
$00000040 constant HRTIM_COMMON_BDTCUPR_TIMXCMP1                    \ HRTIM_CMP1xR register update enable
$00000080 constant HRTIM_COMMON_BDTCUPR_TIMXCMP2                    \ HRTIM_CMP2xR register update enable
$00000100 constant HRTIM_COMMON_BDTCUPR_TIMXCMP3                    \ HRTIM_CMP3xR register update enable
$00000200 constant HRTIM_COMMON_BDTCUPR_TIMXCMP4                    \ HRTIM_CMP4xR register update enable
$00000400 constant HRTIM_COMMON_BDTCUPR_TIMX_DTXR                   \ HRTIM_DTxR register update enable
$00000800 constant HRTIM_COMMON_BDTCUPR_TIMXSET1R                   \ HRTIM_SET1xR register update enable
$00001000 constant HRTIM_COMMON_BDTCUPR_TIMXRST1R                   \ HRTIM_RST1xR register update enable
$00002000 constant HRTIM_COMMON_BDTCUPR_TIMXSET2R                   \ HRTIM_SET2xR register update enable
$00004000 constant HRTIM_COMMON_BDTCUPR_TIMXRST2R                   \ HRTIM_RST2xR register update enable
$00008000 constant HRTIM_COMMON_BDTCUPR_TIMXEEFR1                   \ HRTIM_EEFxR1 register update enable
$00010000 constant HRTIM_COMMON_BDTCUPR_TIMXEEFR2                   \ HRTIM_EEFxR2 register update enable
$00020000 constant HRTIM_COMMON_BDTCUPR_TIMXRSTR                    \ HRTIM_RSTxR register update enable
$00040000 constant HRTIM_COMMON_BDTCUPR_TIMXCHPR                    \ HRTIM_CHPxR register update enable
$00080000 constant HRTIM_COMMON_BDTCUPR_TIMXOUTR                    \ HRTIM_OUTxR register update enable
$00100000 constant HRTIM_COMMON_BDTCUPR_TIMXFLTR                    \ HRTIM_FLTxR register update enable


\
\ @brief Burst DMA Timerx update Register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_BDTDUPR_TIMXCR                      \ HRTIM_TIMxCR register update enable
$00000002 constant HRTIM_COMMON_BDTDUPR_TIMXICR                     \ HRTIM_TIMxICR register update enable
$00000004 constant HRTIM_COMMON_BDTDUPR_TIMXDIER                    \ HRTIM_TIMxDIER register update enable
$00000008 constant HRTIM_COMMON_BDTDUPR_TIMXCNT                     \ HRTIM_CNTxR register update enable
$00000010 constant HRTIM_COMMON_BDTDUPR_TIMXPER                     \ HRTIM_PERxR register update enable
$00000020 constant HRTIM_COMMON_BDTDUPR_TIMXREP                     \ HRTIM_REPxR register update enable
$00000040 constant HRTIM_COMMON_BDTDUPR_TIMXCMP1                    \ HRTIM_CMP1xR register update enable
$00000080 constant HRTIM_COMMON_BDTDUPR_TIMXCMP2                    \ HRTIM_CMP2xR register update enable
$00000100 constant HRTIM_COMMON_BDTDUPR_TIMXCMP3                    \ HRTIM_CMP3xR register update enable
$00000200 constant HRTIM_COMMON_BDTDUPR_TIMXCMP4                    \ HRTIM_CMP4xR register update enable
$00000400 constant HRTIM_COMMON_BDTDUPR_TIMX_DTXR                   \ HRTIM_DTxR register update enable
$00000800 constant HRTIM_COMMON_BDTDUPR_TIMXSET1R                   \ HRTIM_SET1xR register update enable
$00001000 constant HRTIM_COMMON_BDTDUPR_TIMXRST1R                   \ HRTIM_RST1xR register update enable
$00002000 constant HRTIM_COMMON_BDTDUPR_TIMXSET2R                   \ HRTIM_SET2xR register update enable
$00004000 constant HRTIM_COMMON_BDTDUPR_TIMXRST2R                   \ HRTIM_RST2xR register update enable
$00008000 constant HRTIM_COMMON_BDTDUPR_TIMXEEFR1                   \ HRTIM_EEFxR1 register update enable
$00010000 constant HRTIM_COMMON_BDTDUPR_TIMXEEFR2                   \ HRTIM_EEFxR2 register update enable
$00020000 constant HRTIM_COMMON_BDTDUPR_TIMXRSTR                    \ HRTIM_RSTxR register update enable
$00040000 constant HRTIM_COMMON_BDTDUPR_TIMXCHPR                    \ HRTIM_CHPxR register update enable
$00080000 constant HRTIM_COMMON_BDTDUPR_TIMXOUTR                    \ HRTIM_OUTxR register update enable
$00100000 constant HRTIM_COMMON_BDTDUPR_TIMXFLTR                    \ HRTIM_FLTxR register update enable


\
\ @brief Burst DMA Timerx update Register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_BDTEUPR_TIMXCR                      \ HRTIM_TIMxCR register update enable
$00000002 constant HRTIM_COMMON_BDTEUPR_TIMXICR                     \ HRTIM_TIMxICR register update enable
$00000004 constant HRTIM_COMMON_BDTEUPR_TIMXDIER                    \ HRTIM_TIMxDIER register update enable
$00000008 constant HRTIM_COMMON_BDTEUPR_TIMXCNT                     \ HRTIM_CNTxR register update enable
$00000010 constant HRTIM_COMMON_BDTEUPR_TIMXPER                     \ HRTIM_PERxR register update enable
$00000020 constant HRTIM_COMMON_BDTEUPR_TIMXREP                     \ HRTIM_REPxR register update enable
$00000040 constant HRTIM_COMMON_BDTEUPR_TIMXCMP1                    \ HRTIM_CMP1xR register update enable
$00000080 constant HRTIM_COMMON_BDTEUPR_TIMXCMP2                    \ HRTIM_CMP2xR register update enable
$00000100 constant HRTIM_COMMON_BDTEUPR_TIMXCMP3                    \ HRTIM_CMP3xR register update enable
$00000200 constant HRTIM_COMMON_BDTEUPR_TIMXCMP4                    \ HRTIM_CMP4xR register update enable
$00000400 constant HRTIM_COMMON_BDTEUPR_TIMX_DTXR                   \ HRTIM_DTxR register update enable
$00000800 constant HRTIM_COMMON_BDTEUPR_TIMXSET1R                   \ HRTIM_SET1xR register update enable
$00001000 constant HRTIM_COMMON_BDTEUPR_TIMXRST1R                   \ HRTIM_RST1xR register update enable
$00002000 constant HRTIM_COMMON_BDTEUPR_TIMXSET2R                   \ HRTIM_SET2xR register update enable
$00004000 constant HRTIM_COMMON_BDTEUPR_TIMXRST2R                   \ HRTIM_RST2xR register update enable
$00008000 constant HRTIM_COMMON_BDTEUPR_TIMXEEFR1                   \ HRTIM_EEFxR1 register update enable
$00010000 constant HRTIM_COMMON_BDTEUPR_TIMXEEFR2                   \ HRTIM_EEFxR2 register update enable
$00020000 constant HRTIM_COMMON_BDTEUPR_TIMXRSTR                    \ HRTIM_RSTxR register update enable
$00040000 constant HRTIM_COMMON_BDTEUPR_TIMXCHPR                    \ HRTIM_CHPxR register update enable
$00080000 constant HRTIM_COMMON_BDTEUPR_TIMXOUTR                    \ HRTIM_OUTxR register update enable
$00100000 constant HRTIM_COMMON_BDTEUPR_TIMXFLTR                    \ HRTIM_FLTxR register update enable


\
\ @brief Burst DMA Data Register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant HRTIM_COMMON_BDMADR_BDMADR                       \ Burst DMA Data register


\
\ @brief High Resolution Timer: Common functions
\
$40017780 constant HRTIM_COMMON_CR1  \ offset: 0x00 : Control Register 1
$40017784 constant HRTIM_COMMON_CR2  \ offset: 0x04 : Control Register 2
$40017788 constant HRTIM_COMMON_ISR  \ offset: 0x08 : Interrupt Status Register
$4001778c constant HRTIM_COMMON_ICR  \ offset: 0x0C : Interrupt Clear Register
$40017790 constant HRTIM_COMMON_IER  \ offset: 0x10 : Interrupt Enable Register
$40017794 constant HRTIM_COMMON_OENR  \ offset: 0x14 : Output Enable Register
$40017798 constant HRTIM_COMMON_ODISR  \ offset: 0x18 : DISR
$4001779c constant HRTIM_COMMON_ODSR  \ offset: 0x1C : Output Disable Status Register
$400177a0 constant HRTIM_COMMON_BMCR  \ offset: 0x20 : Burst Mode Control Register
$400177a4 constant HRTIM_COMMON_BMTRGR  \ offset: 0x24 : BMTRGR
$400177a8 constant HRTIM_COMMON_BMCMPR  \ offset: 0x28 : BMCMPR
$400177ac constant HRTIM_COMMON_BMPER  \ offset: 0x2C : Burst Mode Period Register
$400177b0 constant HRTIM_COMMON_EECR1  \ offset: 0x30 : Timer External Event Control Register 1
$400177b4 constant HRTIM_COMMON_EECR2  \ offset: 0x34 : Timer External Event Control Register 2
$400177b8 constant HRTIM_COMMON_EECR3  \ offset: 0x38 : Timer External Event Control Register 3
$400177bc constant HRTIM_COMMON_ADC1R  \ offset: 0x3C : ADC Trigger 1 Register
$400177c0 constant HRTIM_COMMON_ADC2R  \ offset: 0x40 : ADC Trigger 2 Register
$400177c4 constant HRTIM_COMMON_ADC3R  \ offset: 0x44 : ADC Trigger 3 Register
$400177c8 constant HRTIM_COMMON_ADC4R  \ offset: 0x48 : ADC Trigger 4 Register
$400177cc constant HRTIM_COMMON_DLLCR  \ offset: 0x4C : DLL Control Register
$400177d0 constant HRTIM_COMMON_FLTINR1  \ offset: 0x50 : HRTIM Fault Input Register 1
$400177d4 constant HRTIM_COMMON_FLTINR2  \ offset: 0x54 : HRTIM Fault Input Register 2
$400177d8 constant HRTIM_COMMON_BDMUPDR  \ offset: 0x58 : BDMUPDR
$400177dc constant HRTIM_COMMON_BDTAUPR  \ offset: 0x5C : Burst DMA Timerx update Register
$400177e0 constant HRTIM_COMMON_BDTBUPR  \ offset: 0x60 : Burst DMA Timerx update Register
$400177e4 constant HRTIM_COMMON_BDTCUPR  \ offset: 0x64 : Burst DMA Timerx update Register
$400177e8 constant HRTIM_COMMON_BDTDUPR  \ offset: 0x68 : Burst DMA Timerx update Register
$400177ec constant HRTIM_COMMON_BDTEUPR  \ offset: 0x6C : Burst DMA Timerx update Register
$400177f0 constant HRTIM_COMMON_BDMADR  \ offset: 0x70 : Burst DMA Data Register

