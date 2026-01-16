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
$00000040 constant HRTIM_COMMON_CR1_TFUDIS                          \ Timer f Update Disable
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
$00000040 constant HRTIM_COMMON_CR2_TFSWU                           \ Timer f Software Update
$00000100 constant HRTIM_COMMON_CR2_MRST                            \ Master Counter software reset
$00000200 constant HRTIM_COMMON_CR2_TARST                           \ Timer A counter software reset
$00000400 constant HRTIM_COMMON_CR2_TBRST                           \ Timer B counter software reset
$00000800 constant HRTIM_COMMON_CR2_TCRST                           \ Timer C counter software reset
$00001000 constant HRTIM_COMMON_CR2_TDRST                           \ Timer D counter software reset
$00002000 constant HRTIM_COMMON_CR2_TERST                           \ Timer E counter software reset
$00004000 constant HRTIM_COMMON_CR2_TFRST                           \ Timer f counter software reset
$00010000 constant HRTIM_COMMON_CR2_SWPA                            \ Swap Timer A outputs
$00020000 constant HRTIM_COMMON_CR2_SWPB                            \ Swap Timer B outputs
$00040000 constant HRTIM_COMMON_CR2_SWPC                            \ Swap Timer C outputs
$00080000 constant HRTIM_COMMON_CR2_SWPD                            \ Swap Timer D outputs
$00100000 constant HRTIM_COMMON_CR2_SWPE                            \ Swap Timer E outputs
$00200000 constant HRTIM_COMMON_CR2_SWPF                            \ Swap Timer F outputs


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
$00000040 constant HRTIM_COMMON_ISR_FLT6                            \ Fault 6 Interrupt Flag
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
$00000040 constant HRTIM_COMMON_ICR_FLT6C                           \ Fault 6 Interrupt Flag Clear
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
$00000040 constant HRTIM_COMMON_IER_FLT6IE                          \ Fault 6 Interrupt Enable
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
$00000400 constant HRTIM_COMMON_OENR_TF1ODS                         \ Timer F Output 1 disable status
$00000800 constant HRTIM_COMMON_OENR_TF2ODS                         \ Timer F Output 2 disable status


\
\ @brief ODISR
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
$00000400 constant HRTIM_COMMON_ODISR_TF1ODIS                       \ TF1ODIS
$00000800 constant HRTIM_COMMON_ODISR_TF2ODIS                       \ TF2ODIS


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
$00000400 constant HRTIM_COMMON_ODSR_TF1ODS                         \ TF1ODS
$00000800 constant HRTIM_COMMON_ODSR_TF2ODS                         \ TF2ODS


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
$00400000 constant HRTIM_COMMON_BMCR_TFBM                           \ Timer f Burst Mode
$80000000 constant HRTIM_COMMON_BMCR_BMSTAT                         \ Burst Mode Status


\
\ @brief BMTRG
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_BMTRG_SW                            \ SW
$00000002 constant HRTIM_COMMON_BMTRG_MSTRST                        \ MSTRST
$00000004 constant HRTIM_COMMON_BMTRG_MSTREP                        \ MSTREP
$00000008 constant HRTIM_COMMON_BMTRG_MSTCMP1                       \ MSTCMP1
$00000010 constant HRTIM_COMMON_BMTRG_MSTCMP2                       \ MSTCMP2
$00000020 constant HRTIM_COMMON_BMTRG_MSTCMP3                       \ MSTCMP3
$00000040 constant HRTIM_COMMON_BMTRG_MSTCMP4                       \ MSTCMP4
$00000080 constant HRTIM_COMMON_BMTRG_TARST                         \ TARST
$00000100 constant HRTIM_COMMON_BMTRG_TAREP                         \ TAREP
$00000200 constant HRTIM_COMMON_BMTRG_TACMP1                        \ TACMP1
$00000400 constant HRTIM_COMMON_BMTRG_TACMP2                        \ TACMP2
$00000800 constant HRTIM_COMMON_BMTRG_TBRST                         \ TBRST
$00001000 constant HRTIM_COMMON_BMTRG_TBREP                         \ TBREP
$00002000 constant HRTIM_COMMON_BMTRG_TBCMP1                        \ TBCMP1
$00004000 constant HRTIM_COMMON_BMTRG_TBCMP2                        \ TBCMP2
$00008000 constant HRTIM_COMMON_BMTRG_TCRST                         \ TCRST
$00010000 constant HRTIM_COMMON_BMTRG_TCREP                         \ TCREP
$00020000 constant HRTIM_COMMON_BMTRG_TCCMP1                        \ TCCMP1
$00040000 constant HRTIM_COMMON_BMTRG_TCCMP2                        \ TCCMP2
$00080000 constant HRTIM_COMMON_BMTRG_TDRST                         \ TDRST
$00100000 constant HRTIM_COMMON_BMTRG_TDREP                         \ TDREP
$00200000 constant HRTIM_COMMON_BMTRG_TDCMP1                        \ TDCMP1
$00400000 constant HRTIM_COMMON_BMTRG_TDCMP2                        \ TDCMP2
$00800000 constant HRTIM_COMMON_BMTRG_TERST                         \ TERST
$01000000 constant HRTIM_COMMON_BMTRG_TEREP                         \ TEREP
$02000000 constant HRTIM_COMMON_BMTRG_TECMP1                        \ TECMP1
$04000000 constant HRTIM_COMMON_BMTRG_TECMP2                        \ TECMP2
$08000000 constant HRTIM_COMMON_BMTRG_TDEEV7                        \ TDEEV7
$10000000 constant HRTIM_COMMON_BMTRG_TDEEV8                        \ TDEEV8
$20000000 constant HRTIM_COMMON_BMTRG_EEV7                          \ EEV7
$40000000 constant HRTIM_COMMON_BMTRG_EEV8                          \ EEV8
$80000000 constant HRTIM_COMMON_BMTRG_OCHPEV                        \ OCHPEV


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

$00000003 constant HRTIM_COMMON_EECR2_EE6SRC                        \ EE6SRC
$00000004 constant HRTIM_COMMON_EECR2_EE6POL                        \ EE6POL
$00000018 constant HRTIM_COMMON_EECR2_EE6SNS                        \ EE6SNS
$000000c0 constant HRTIM_COMMON_EECR2_EE7SRC                        \ EE7SRC
$00000100 constant HRTIM_COMMON_EECR2_EE7POL                        \ EE7POL
$00000600 constant HRTIM_COMMON_EECR2_EE7SNS                        \ EE7SNS
$00003000 constant HRTIM_COMMON_EECR2_EE8SRC                        \ EE8SRC
$00004000 constant HRTIM_COMMON_EECR2_EE8POL                        \ EE8POL
$00018000 constant HRTIM_COMMON_EECR2_EE8SNS                        \ EE8SNS
$000c0000 constant HRTIM_COMMON_EECR2_EE9SRC                        \ EE9SRC
$00100000 constant HRTIM_COMMON_EECR2_EE9POL                        \ EE9POL
$00600000 constant HRTIM_COMMON_EECR2_EE9SNS                        \ EE9SNS
$03000000 constant HRTIM_COMMON_EECR2_EE10SRC                       \ EE10SRC
$04000000 constant HRTIM_COMMON_EECR2_EE10POL                       \ EE10POL
$18000000 constant HRTIM_COMMON_EECR2_EE10SNS                       \ EE10SNS


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
$00000100 constant HRTIM_COMMON_FLTINR2_FLT6E                       \ FLT6E
$00000200 constant HRTIM_COMMON_FLTINR2_FLT6P                       \ FLT6P
$00000400 constant HRTIM_COMMON_FLTINR2_FLT6SRC_0                   \ FLT6F
$00007800 constant HRTIM_COMMON_FLTINR2_FLT6F                       \ FLT6F
$00008000 constant HRTIM_COMMON_FLTINR2_FLT6LCK                     \ FLT6LCK
$00010000 constant HRTIM_COMMON_FLTINR2_FLT1SRC_1                   \ FLT1SRC_1
$00020000 constant HRTIM_COMMON_FLTINR2_FLT2SRC_1                   \ FLT2SRC_1
$00040000 constant HRTIM_COMMON_FLTINR2_FLT3SRC_1                   \ FLT3SRC_1
$00080000 constant HRTIM_COMMON_FLTINR2_FLT4SRC_1                   \ FLT4SRC_1
$00100000 constant HRTIM_COMMON_FLTINR2_FLT5SRC_1                   \ FLT5SRC_1
$00200000 constant HRTIM_COMMON_FLTINR2_FLT6SRC_1                   \ FLT6SRC
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
$00200000 constant HRTIM_COMMON_BDTAUPR_TIMXCR2                     \ TIMxCR2
$00400000 constant HRTIM_COMMON_BDTAUPR_TIMXEEFR3                   \ TIMxEEFR3


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
$00200000 constant HRTIM_COMMON_BDTBUPR_TIMXCR2                     \ TIMxCR2
$00400000 constant HRTIM_COMMON_BDTBUPR_TIMXEEFR3                   \ TIMxEEFR3


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
$00200000 constant HRTIM_COMMON_BDTCUPR_TIMXCR2                     \ TIMxCR2
$00400000 constant HRTIM_COMMON_BDTCUPR_TIMXEEFR3                   \ TIMxEEFR3


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
$00200000 constant HRTIM_COMMON_BDTDUPR_TIMXCR2                     \ TIMxCR2
$00400000 constant HRTIM_COMMON_BDTDUPR_TIMXEEFR3                   \ TIMxEEFR3


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
$00200000 constant HRTIM_COMMON_BDTEUPR_TIMXCR2                     \ TIMxCR2
$00400000 constant HRTIM_COMMON_BDTEUPR_TIMXEEFR3                   \ TIMxEEFR3


\
\ @brief Burst DMA Data Register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant HRTIM_COMMON_BDMADR_BDMADR                       \ Burst DMA Data register


\
\ @brief Burst DMA Timerx update Register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_BDTFUPR_TIMXCR                      \ HRTIM_TIMxCR register update enable
$00000002 constant HRTIM_COMMON_BDTFUPR_TIMXICR                     \ HRTIM_TIMxICR register update enable
$00000004 constant HRTIM_COMMON_BDTFUPR_TIMXDIER                    \ HRTIM_TIMxDIER register update enable
$00000008 constant HRTIM_COMMON_BDTFUPR_TIMXCNT                     \ HRTIM_CNTxR register update enable
$00000010 constant HRTIM_COMMON_BDTFUPR_TIMXPER                     \ HRTIM_PERxR register update enable
$00000020 constant HRTIM_COMMON_BDTFUPR_TIMXREP                     \ HRTIM_REPxR register update enable
$00000040 constant HRTIM_COMMON_BDTFUPR_TIMXCMP1                    \ HRTIM_CMP1xR register update enable
$00000080 constant HRTIM_COMMON_BDTFUPR_TIMXCMP2                    \ HRTIM_CMP2xR register update enable
$00000100 constant HRTIM_COMMON_BDTFUPR_TIMXCMP3                    \ HRTIM_CMP3xR register update enable
$00000200 constant HRTIM_COMMON_BDTFUPR_TIMXCMP4                    \ HRTIM_CMP4xR register update enable
$00000400 constant HRTIM_COMMON_BDTFUPR_TIMX_DTXR                   \ HRTIM_DTxR register update enable
$00000800 constant HRTIM_COMMON_BDTFUPR_TIMXSET1R                   \ HRTIM_SET1xR register update enable
$00001000 constant HRTIM_COMMON_BDTFUPR_TIMXRST1R                   \ HRTIM_RST1xR register update enable
$00002000 constant HRTIM_COMMON_BDTFUPR_TIMXSET2R                   \ HRTIM_SET2xR register update enable
$00004000 constant HRTIM_COMMON_BDTFUPR_TIMXRST2R                   \ HRTIM_RST2xR register update enable
$00008000 constant HRTIM_COMMON_BDTFUPR_TIMXEEFR1                   \ HRTIM_EEFxR1 register update enable
$00010000 constant HRTIM_COMMON_BDTFUPR_TIMXEEFR2                   \ HRTIM_EEFxR2 register update enable
$00020000 constant HRTIM_COMMON_BDTFUPR_TIMXRSTR                    \ HRTIM_RSTxR register update enable
$00040000 constant HRTIM_COMMON_BDTFUPR_TIMXCHPR                    \ HRTIM_CHPxR register update enable
$00080000 constant HRTIM_COMMON_BDTFUPR_TIMXOUTR                    \ HRTIM_OUTxR register update enable
$00100000 constant HRTIM_COMMON_BDTFUPR_TIMXFLTR                    \ HRTIM_FLTxR register update enable
$00200000 constant HRTIM_COMMON_BDTFUPR_TIMXCR2                     \ TIMxCR2
$00400000 constant HRTIM_COMMON_BDTFUPR_TIMXEEFR3                   \ TIMxEEFR3


\
\ @brief HRTIM ADC Extended Trigger Register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$0000001f constant HRTIM_COMMON_ADCER_ADC5TRG                       \ ADC5TRG
$000003e0 constant HRTIM_COMMON_ADCER_ADC6TRG                       \ ADC6TRG
$00007c00 constant HRTIM_COMMON_ADCER_ADC7TRG                       \ ADC7TRG
$001f0000 constant HRTIM_COMMON_ADCER_ADC8TRG                       \ ADC8TRG
$03e00000 constant HRTIM_COMMON_ADCER_ADC9TRG                       \ ADC9TRG
$7c000000 constant HRTIM_COMMON_ADCER_ADC10TRG                      \ ADC10TRG


\
\ @brief HRTIM ADC Trigger Update Register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000007 constant HRTIM_COMMON_ADCUR_AD5USRC                       \ AD5USRC
$00000070 constant HRTIM_COMMON_ADCUR_AD6USRC                       \ AD6USRC
$00000700 constant HRTIM_COMMON_ADCUR_AD7USRC                       \ AD7USRC
$00007000 constant HRTIM_COMMON_ADCUR_AD8USRC                       \ AD8USRC
$00070000 constant HRTIM_COMMON_ADCUR_AD9USRC                       \ AD9USRC
$00700000 constant HRTIM_COMMON_ADCUR_AD10USRC                      \ AD10USRC


\
\ @brief HRTIM ADC Post Scaler Register 1
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$0000001f constant HRTIM_COMMON_ADCPS1_ADC1PSC                      \ ADC1PSC
$000007c0 constant HRTIM_COMMON_ADCPS1_ADC2PSC                      \ ADC2PSC
$0001f000 constant HRTIM_COMMON_ADCPS1_ADC3PSC                      \ ADC3PSC
$007c0000 constant HRTIM_COMMON_ADCPS1_ADC4PSC                      \ ADC4PSC
$1f000000 constant HRTIM_COMMON_ADCPS1_ADC5PSC                      \ ADC5PSC


\
\ @brief HRTIM ADC Post Scaler Register 2
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000001f constant HRTIM_COMMON_ADCPS2_ADC6PSC                      \ ADC6PSC
$000007c0 constant HRTIM_COMMON_ADCPS2_ADC7PSC                      \ ADC7PSC
$0001f000 constant HRTIM_COMMON_ADCPS2_ADC8PSC                      \ ADC8PSC
$007c0000 constant HRTIM_COMMON_ADCPS2_ADC9PSC                      \ ADC9PSC
$1f000000 constant HRTIM_COMMON_ADCPS2_ADC10PSC                     \ ADC10PSC


\
\ @brief HRTIM Fault Input Register 3
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_FLTINR3_FLT1BLKE                    \ FLT1BLKE
$00000002 constant HRTIM_COMMON_FLTINR3_FLT1BLKS                    \ FLT1BLKS
$0000003c constant HRTIM_COMMON_FLTINR3_FLT1CNT                     \ FLT1CNT
$00000040 constant HRTIM_COMMON_FLTINR3_FLT1CRES                    \ FLT1CRES
$00000080 constant HRTIM_COMMON_FLTINR3_FLT1RSTM                    \ FLT1RSTM
$00000100 constant HRTIM_COMMON_FLTINR3_FLT2BLKE                    \ FLT2BLKE
$00000200 constant HRTIM_COMMON_FLTINR3_FLT2BLKS                    \ FLT2BLKS
$00003c00 constant HRTIM_COMMON_FLTINR3_FLT2CNT                     \ FLT2CNT
$00004000 constant HRTIM_COMMON_FLTINR3_FLT2CRES                    \ FLT2CRES
$00008000 constant HRTIM_COMMON_FLTINR3_FLT2RSTM                    \ FLT2RSTM
$00010000 constant HRTIM_COMMON_FLTINR3_FLT3BLKE                    \ FLT3BLKE
$00020000 constant HRTIM_COMMON_FLTINR3_FLT3BLKS                    \ FLT3BLKS
$003c0000 constant HRTIM_COMMON_FLTINR3_FLT3CNT                     \ FLT3CNT
$00400000 constant HRTIM_COMMON_FLTINR3_FLT3CRES                    \ FLT3CRES
$00800000 constant HRTIM_COMMON_FLTINR3_FLT3RSTM                    \ FLT3RSTM
$01000000 constant HRTIM_COMMON_FLTINR3_FLT4BLKE                    \ FLT4BLKE
$02000000 constant HRTIM_COMMON_FLTINR3_FLT4BLKS                    \ FLT4BLKS
$3c000000 constant HRTIM_COMMON_FLTINR3_FLT4CNT                     \ FLT4CNT
$40000000 constant HRTIM_COMMON_FLTINR3_FLT4CRES                    \ FLT4CRES
$80000000 constant HRTIM_COMMON_FLTINR3_FLT4RSTM                    \ FLT4RSTM


\
\ @brief HRTIM Fault Input Register 4
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000001 constant HRTIM_COMMON_FLTINR4_FLT5BLKE                    \ FLT5BLKE
$00000002 constant HRTIM_COMMON_FLTINR4_FLT5BLKS                    \ FLT5BLKS
$0000003c constant HRTIM_COMMON_FLTINR4_FLT5CNT                     \ FLT5CNT
$00000040 constant HRTIM_COMMON_FLTINR4_FLT5CRES                    \ FLT5CRES
$00000080 constant HRTIM_COMMON_FLTINR4_FLT5RSTM                    \ FLT5RSTM
$00000100 constant HRTIM_COMMON_FLTINR4_FLT6BLKE                    \ FLT6BLKE
$00000200 constant HRTIM_COMMON_FLTINR4_FLT6BLKS                    \ FLT6BLKS
$00003c00 constant HRTIM_COMMON_FLTINR4_FLT6CNT                     \ FLT6CNT
$00004000 constant HRTIM_COMMON_FLTINR4_FLT6CRES                    \ FLT6CRES
$00008000 constant HRTIM_COMMON_FLTINR4_FLT6RSTM                    \ FLT6RSTM


\
\ @brief High Resolution Timer: Common functions
\
$40016b80 constant HRTIM_COMMON_CR1  \ offset: 0x00 : Control Register 1
$40016b84 constant HRTIM_COMMON_CR2  \ offset: 0x04 : Control Register 2
$40016b88 constant HRTIM_COMMON_ISR  \ offset: 0x08 : Interrupt Status Register
$40016b8c constant HRTIM_COMMON_ICR  \ offset: 0x0C : Interrupt Clear Register
$40016b90 constant HRTIM_COMMON_IER  \ offset: 0x10 : Interrupt Enable Register
$40016b94 constant HRTIM_COMMON_OENR  \ offset: 0x14 : Output Enable Register
$40016b98 constant HRTIM_COMMON_ODISR  \ offset: 0x18 : ODISR
$40016b9c constant HRTIM_COMMON_ODSR  \ offset: 0x1C : Output Disable Status Register
$40016ba0 constant HRTIM_COMMON_BMCR  \ offset: 0x20 : Burst Mode Control Register
$40016ba4 constant HRTIM_COMMON_BMTRG  \ offset: 0x24 : BMTRG
$40016ba8 constant HRTIM_COMMON_BMCMPR  \ offset: 0x28 : BMCMPR
$40016bac constant HRTIM_COMMON_BMPER  \ offset: 0x2C : Burst Mode Period Register
$40016bb0 constant HRTIM_COMMON_EECR1  \ offset: 0x30 : Timer External Event Control Register 1
$40016bb4 constant HRTIM_COMMON_EECR2  \ offset: 0x34 : Timer External Event Control Register 2
$40016bb8 constant HRTIM_COMMON_EECR3  \ offset: 0x38 : Timer External Event Control Register 3
$40016bbc constant HRTIM_COMMON_ADC1R  \ offset: 0x3C : ADC Trigger 1 Register
$40016bc0 constant HRTIM_COMMON_ADC2R  \ offset: 0x40 : ADC Trigger 2 Register
$40016bc4 constant HRTIM_COMMON_ADC3R  \ offset: 0x44 : ADC Trigger 3 Register
$40016bc8 constant HRTIM_COMMON_ADC4R  \ offset: 0x48 : ADC Trigger 4 Register
$40016bcc constant HRTIM_COMMON_DLLCR  \ offset: 0x4C : DLL Control Register
$40016bd0 constant HRTIM_COMMON_FLTINR1  \ offset: 0x50 : HRTIM Fault Input Register 1
$40016bd4 constant HRTIM_COMMON_FLTINR2  \ offset: 0x54 : HRTIM Fault Input Register 2
$40016bd8 constant HRTIM_COMMON_BDMUPDR  \ offset: 0x58 : BDMUPDR
$40016bdc constant HRTIM_COMMON_BDTAUPR  \ offset: 0x5C : Burst DMA Timerx update Register
$40016be0 constant HRTIM_COMMON_BDTBUPR  \ offset: 0x60 : Burst DMA Timerx update Register
$40016be4 constant HRTIM_COMMON_BDTCUPR  \ offset: 0x64 : Burst DMA Timerx update Register
$40016be8 constant HRTIM_COMMON_BDTDUPR  \ offset: 0x68 : Burst DMA Timerx update Register
$40016bec constant HRTIM_COMMON_BDTEUPR  \ offset: 0x6C : Burst DMA Timerx update Register
$40016bf0 constant HRTIM_COMMON_BDMADR  \ offset: 0x70 : Burst DMA Data Register
$40016bf4 constant HRTIM_COMMON_BDTFUPR  \ offset: 0x74 : Burst DMA Timerx update Register
$40016bf8 constant HRTIM_COMMON_ADCER  \ offset: 0x78 : HRTIM ADC Extended Trigger Register
$40016bfc constant HRTIM_COMMON_ADCUR  \ offset: 0x7C : HRTIM ADC Trigger Update Register
$40016c00 constant HRTIM_COMMON_ADCPS1  \ offset: 0x80 : HRTIM ADC Post Scaler Register 1
$40016c04 constant HRTIM_COMMON_ADCPS2  \ offset: 0x84 : HRTIM ADC Post Scaler Register 2
$40016c08 constant HRTIM_COMMON_FLTINR3  \ offset: 0x88 : HRTIM Fault Input Register 3
$40016c0c constant HRTIM_COMMON_FLTINR4  \ offset: 0x8C : HRTIM Fault Input Register 4

