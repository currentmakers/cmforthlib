\
\ @file sec_lptim4.fs
\ @brief Low power timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Interrupt and Status Register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM4_ISR_CC1IF                             \ Compare 1 interrupt flag
$00000002 constant SEC_LPTIM4_ISR_ARRM                              \ Autoreload match
$00000004 constant SEC_LPTIM4_ISR_EXTTRIG                           \ External trigger edge event
$00000008 constant SEC_LPTIM4_ISR_CMP1OK                            \ Compare register 1 update OK
$00000010 constant SEC_LPTIM4_ISR_ARROK                             \ Autoreload register update OK
$00000020 constant SEC_LPTIM4_ISR_UP                                \ Counter direction change down to up
$00000040 constant SEC_LPTIM4_ISR_DOWN                              \ Counter direction change up to down
$00000080 constant SEC_LPTIM4_ISR_UE                                \ LPTIM update event occurred
$00000100 constant SEC_LPTIM4_ISR_REPOK                             \ Repetition register update Ok
$01000000 constant SEC_LPTIM4_ISR_DIEROK                            \ Interrupt enable register update OK


\
\ @brief Interrupt Clear Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM4_ICR_CC1IF                             \ Capture/compare 1 clear flag
$00000002 constant SEC_LPTIM4_ICR_ARRMCF                            \ Autoreload match Clear Flag
$00000004 constant SEC_LPTIM4_ICR_EXTTRIGCF                         \ External trigger valid edge Clear Flag
$00000008 constant SEC_LPTIM4_ICR_CMP1OKCF                          \ Compare register 1 update OK Clear Flag
$00000010 constant SEC_LPTIM4_ICR_ARROKCF                           \ Autoreload register update OK Clear Flag
$00000020 constant SEC_LPTIM4_ICR_UPCF                              \ Direction change to UP Clear Flag
$00000040 constant SEC_LPTIM4_ICR_DOWNCF                            \ Direction change to down Clear Flag
$00000080 constant SEC_LPTIM4_ICR_UECF                              \ Update event clear flag
$00000100 constant SEC_LPTIM4_ICR_REPOKCF                           \ Repetition register update OK clear flag
$01000000 constant SEC_LPTIM4_ICR_DIEROKCF                          \ Interrupt enable register update OK clear flag


\
\ @brief LPTIM interrupt Enable Register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM4_DIER_CC1IF                            \ Capture/compare 1 clear flag
$00000002 constant SEC_LPTIM4_DIER_ARRMIE                           \ Autoreload match Interrupt Enable
$00000004 constant SEC_LPTIM4_DIER_EXTTRIGIE                        \ External trigger valid edge Interrupt Enable
$00000008 constant SEC_LPTIM4_DIER_CMP1OKIE                         \ Compare register 1 update OK Interrupt Enable
$00000010 constant SEC_LPTIM4_DIER_ARROKIE                          \ Autoreload register update OK Interrupt Enable
$00000020 constant SEC_LPTIM4_DIER_UPIE                             \ Direction change to UP Interrupt Enable
$00000040 constant SEC_LPTIM4_DIER_DOWNIE                           \ Direction change to down Interrupt Enable
$00000080 constant SEC_LPTIM4_DIER_UEIE                             \ Update event interrupt enable
$00000100 constant SEC_LPTIM4_DIER_REPOKIE                          \ REPOKIE


\
\ @brief Configuration Register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM4_CFGR_CKSEL                            \ Clock selector
$00000006 constant SEC_LPTIM4_CFGR_CKPOL                            \ Clock Polarity
$00000018 constant SEC_LPTIM4_CFGR_CKFLT                            \ Configurable digital filter for external clock
$000000c0 constant SEC_LPTIM4_CFGR_TRGFLT                           \ Configurable digital filter for trigger
$00000e00 constant SEC_LPTIM4_CFGR_PRESC                            \ Clock prescaler
$0000e000 constant SEC_LPTIM4_CFGR_TRIGSEL                          \ Trigger selector
$00060000 constant SEC_LPTIM4_CFGR_TRIGEN                           \ Trigger enable and polarity
$00080000 constant SEC_LPTIM4_CFGR_TIMOUT                           \ Timeout enable
$00100000 constant SEC_LPTIM4_CFGR_WAVE                             \ Waveform shape
$00200000 constant SEC_LPTIM4_CFGR_WAVPOL                           \ Waveform shape polarity
$00400000 constant SEC_LPTIM4_CFGR_PRELOAD                          \ Registers update mode
$00800000 constant SEC_LPTIM4_CFGR_COUNTMODE                        \ counter mode enabled
$01000000 constant SEC_LPTIM4_CFGR_ENC                              \ Encoder mode enable


\
\ @brief Control Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM4_CR_ENABLE                             \ LPTIM Enable
$00000002 constant SEC_LPTIM4_CR_SNGSTRT                            \ LPTIM start in single mode
$00000004 constant SEC_LPTIM4_CR_CNTSTRT                            \ Timer start in continuous mode
$00000008 constant SEC_LPTIM4_CR_COUNTRST                           \ Counter reset
$00000010 constant SEC_LPTIM4_CR_RSTARE                             \ Reset after read enable


\
\ @brief Compare Register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant SEC_LPTIM4_CCR1_CCR1                             \ Capture/compare 1 value


\
\ @brief Autoreload Register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$0000ffff constant SEC_LPTIM4_ARR_ARR                               \ Auto reload value


\
\ @brief Counter Register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant SEC_LPTIM4_CNT_CNT                               \ Counter value


\
\ @brief LPTIM configuration register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000003 constant SEC_LPTIM4_CFGR2_IN1SEL                          \ LPTIM input 1 selection
$00000030 constant SEC_LPTIM4_CFGR2_IN2SEL                          \ LPTIM input 2 selection
$00030000 constant SEC_LPTIM4_CFGR2_IC1SEL                          \ LPTIM input capture 1 selection
$00300000 constant SEC_LPTIM4_CFGR2_IC2SEL                          \ LPTIM input capture 2 selection


\
\ @brief LPTIM repetition register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant SEC_LPTIM4_RCR_REP                               \ Repetition register value


\
\ @brief LPTIM capture/compare mode register 1
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM4_CCMR1_CC1SEL                          \ Capture/compare 1 selection
$00000002 constant SEC_LPTIM4_CCMR1_CC1E                            \ Capture/compare 1 output enable
$0000000c constant SEC_LPTIM4_CCMR1_CC1P                            \ Capture/compare 1 output polarity
$00000300 constant SEC_LPTIM4_CCMR1_IC1PSC                          \ Input capture 1 prescaler
$00003000 constant SEC_LPTIM4_CCMR1_IC1F                            \ Input capture 1 filter
$00010000 constant SEC_LPTIM4_CCMR1_CC2SEL                          \ Capture/compare 2 selection
$00020000 constant SEC_LPTIM4_CCMR1_CC2E                            \ Capture/compare 2 output enable
$000c0000 constant SEC_LPTIM4_CCMR1_CC2P                            \ Capture/compare 2 output polarity
$03000000 constant SEC_LPTIM4_CCMR1_IC2PSC                          \ Input capture 2 prescaler
$30000000 constant SEC_LPTIM4_CCMR1_IC2F                            \ Input capture 2 filter


\
\ @brief LPTIM Compare Register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant SEC_LPTIM4_CCR2_CCR2                             \ Capture/compare 2 value


\
\ @brief Low power timer
\
$56004c00 constant SEC_LPTIM4_ISR  \ offset: 0x00 : Interrupt and Status Register
$56004c04 constant SEC_LPTIM4_ICR  \ offset: 0x04 : Interrupt Clear Register
$56004c08 constant SEC_LPTIM4_DIER  \ offset: 0x08 : LPTIM interrupt Enable Register
$56004c0c constant SEC_LPTIM4_CFGR  \ offset: 0x0C : Configuration Register
$56004c10 constant SEC_LPTIM4_CR  \ offset: 0x10 : Control Register
$56004c14 constant SEC_LPTIM4_CCR1  \ offset: 0x14 : Compare Register
$56004c18 constant SEC_LPTIM4_ARR  \ offset: 0x18 : Autoreload Register
$56004c1c constant SEC_LPTIM4_CNT  \ offset: 0x1C : Counter Register
$56004c24 constant SEC_LPTIM4_CFGR2  \ offset: 0x24 : LPTIM configuration register 2
$56004c28 constant SEC_LPTIM4_RCR  \ offset: 0x28 : LPTIM repetition register
$56004c2c constant SEC_LPTIM4_CCMR1  \ offset: 0x2C : LPTIM capture/compare mode register 1
$56004c34 constant SEC_LPTIM4_CCR2  \ offset: 0x34 : LPTIM Compare Register 2

