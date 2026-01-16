\
\ @file lptim5_s.fs
\ @brief Low-power timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief LPTIM5 interrupt and status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LPTIM5_S_LPTIM5_ISR_CC1IF                        \ Compare 1 interrupt flag
$00000002 constant LPTIM5_S_LPTIM5_ISR_ARRM                         \ Autoreload match
$00000004 constant LPTIM5_S_LPTIM5_ISR_EXTTRIG                      \ External trigger edge event
$00000008 constant LPTIM5_S_LPTIM5_ISR_CMP1OK                       \ Compare register 1 update OK
$00000010 constant LPTIM5_S_LPTIM5_ISR_ARROK                        \ Autoreload register update OK
$00000020 constant LPTIM5_S_LPTIM5_ISR_UP                           \ Counter direction change down to up
$00000040 constant LPTIM5_S_LPTIM5_ISR_DOWN                         \ Counter direction change up to down
$00000080 constant LPTIM5_S_LPTIM5_ISR_UE                           \ LPTIM update event occurred
$00000100 constant LPTIM5_S_LPTIM5_ISR_REPOK                        \ Repetition register update OK
$01000000 constant LPTIM5_S_LPTIM5_ISR_DIEROK                       \ Interrupt enable register update OK


\
\ @brief LPTIM5 interrupt clear register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LPTIM5_S_LPTIM5_ICR_CC1CF                        \ Capture/compare 1 clear flag
$00000002 constant LPTIM5_S_LPTIM5_ICR_ARRMCF                       \ Autoreload match clear flag
$00000004 constant LPTIM5_S_LPTIM5_ICR_EXTTRIGCF                    \ External trigger valid edge clear flag
$00000008 constant LPTIM5_S_LPTIM5_ICR_CMP1OKCF                     \ Compare register 1 update OK clear flag
$00000010 constant LPTIM5_S_LPTIM5_ICR_ARROKCF                      \ Autoreload register update OK clear flag
$00000020 constant LPTIM5_S_LPTIM5_ICR_UPCF                         \ Direction change to UP clear flag
$00000040 constant LPTIM5_S_LPTIM5_ICR_DOWNCF                       \ Direction change to down clear flag
$00000080 constant LPTIM5_S_LPTIM5_ICR_UECF                         \ Update event clear flag
$00000100 constant LPTIM5_S_LPTIM5_ICR_REPOKCF                      \ Repetition register update OK clear flag
$01000000 constant LPTIM5_S_LPTIM5_ICR_DIEROKCF                     \ Interrupt enable register update OK clear flag


\
\ @brief LPTIM5 interrupt enable register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant LPTIM5_S_LPTIM5_DIER_CC1IE                       \ Capture/compare 1 interrupt enable
$00000002 constant LPTIM5_S_LPTIM5_DIER_ARRMIE                      \ Autoreload match Interrupt Enable
$00000004 constant LPTIM5_S_LPTIM5_DIER_EXTTRIGIE                   \ External trigger valid edge Interrupt Enable
$00000008 constant LPTIM5_S_LPTIM5_DIER_CMP1OKIE                    \ Compare register 1 update OK interrupt enable
$00000010 constant LPTIM5_S_LPTIM5_DIER_ARROKIE                     \ Autoreload register update OK Interrupt Enable
$00000020 constant LPTIM5_S_LPTIM5_DIER_UPIE                        \ Direction change to UP Interrupt Enable
$00000040 constant LPTIM5_S_LPTIM5_DIER_DOWNIE                      \ Direction change to down Interrupt Enable
$00000080 constant LPTIM5_S_LPTIM5_DIER_UEIE                        \ Update event interrupt enable
$00000100 constant LPTIM5_S_LPTIM5_DIER_REPOKIE                     \ Repetition register update OK interrupt Enable


\
\ @brief LPTIM5 configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant LPTIM5_S_LPTIM5_CFGR_CKSEL                       \ Clock selector
$00000006 constant LPTIM5_S_LPTIM5_CFGR_CKPOL                       \ Clock Polarity
$00000018 constant LPTIM5_S_LPTIM5_CFGR_CKFLT                       \ Configurable digital filter for external clock
$000000c0 constant LPTIM5_S_LPTIM5_CFGR_TRGFLT                      \ Configurable digital filter for trigger
$00000e00 constant LPTIM5_S_LPTIM5_CFGR_PRESC                       \ Clock prescaler
$0000e000 constant LPTIM5_S_LPTIM5_CFGR_TRIGSEL                     \ Trigger selector
$00060000 constant LPTIM5_S_LPTIM5_CFGR_TRIGEN                      \ Trigger enable and polarity
$00080000 constant LPTIM5_S_LPTIM5_CFGR_TIMOUT                      \ Timeout enable
$00100000 constant LPTIM5_S_LPTIM5_CFGR_WAVE                        \ Waveform shape
$00200000 constant LPTIM5_S_LPTIM5_CFGR_WAVPOL                      \ Waveform shape polarity
$00400000 constant LPTIM5_S_LPTIM5_CFGR_PRELOAD                     \ Registers update mode
$00800000 constant LPTIM5_S_LPTIM5_CFGR_COUNTMODE                   \ counter mode enabled
$01000000 constant LPTIM5_S_LPTIM5_CFGR_ENC                         \ Encoder mode enable


\
\ @brief LPTIM5 control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant LPTIM5_S_LPTIM5_CR_ENABLE                        \ LPTIM enable
$00000002 constant LPTIM5_S_LPTIM5_CR_SNGSTRT                       \ LPTIM start in Single mode
$00000004 constant LPTIM5_S_LPTIM5_CR_CNTSTRT                       \ Timer start in Continuous mode
$00000008 constant LPTIM5_S_LPTIM5_CR_COUNTRST                      \ Counter reset
$00000010 constant LPTIM5_S_LPTIM5_CR_RSTARE                        \ Reset after read enable


\
\ @brief LPTIM5 compare register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM5_S_LPTIM5_CCR1_CCR1                        \ Capture/compare 1 value


\
\ @brief LPTIM5 autoreload register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$0000ffff constant LPTIM5_S_LPTIM5_ARR_ARR                          \ Auto reload value


\
\ @brief LPTIM5 counter register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM5_S_LPTIM5_CNT_CNT                          \ Counter value


\
\ @brief LPTIM5 configuration register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000003 constant LPTIM5_S_LPTIM5_CFGR2_IN1SEL                     \ LPTIM input 1 selection
$00000030 constant LPTIM5_S_LPTIM5_CFGR2_IN2SEL                     \ LPTIM input 2 selection
$00030000 constant LPTIM5_S_LPTIM5_CFGR2_IC1SEL                     \ LPTIM input capture 1 selection
$00300000 constant LPTIM5_S_LPTIM5_CFGR2_IC2SEL                     \ LPTIM input capture 2 selection


\
\ @brief LPTIM5 repetition register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant LPTIM5_S_LPTIM5_RCR_REP                          \ Repetition register value


\
\ @brief LPTIM5 capture/compare mode register 1
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant LPTIM5_S_LPTIM5_CCMR1_CC1SEL                     \ Capture/compare 1 selection
$00000002 constant LPTIM5_S_LPTIM5_CCMR1_CC1E                       \ Capture/compare 1 output enable.
$0000000c constant LPTIM5_S_LPTIM5_CCMR1_CC1P                       \ Capture/compare 1 output polarity.
$00000300 constant LPTIM5_S_LPTIM5_CCMR1_IC1PSC                     \ Input capture 1 prescaler
$00003000 constant LPTIM5_S_LPTIM5_CCMR1_IC1F                       \ Input capture 1 filter
$00010000 constant LPTIM5_S_LPTIM5_CCMR1_CC2SEL                     \ Capture/compare 2 selection
$00020000 constant LPTIM5_S_LPTIM5_CCMR1_CC2E                       \ Capture/compare 2 output enable.
$000c0000 constant LPTIM5_S_LPTIM5_CCMR1_CC2P                       \ Capture/compare 2 output polarity.
$03000000 constant LPTIM5_S_LPTIM5_CCMR1_IC2PSC                     \ Input capture 2 prescaler
$30000000 constant LPTIM5_S_LPTIM5_CCMR1_IC2F                       \ Input capture 2 filter


\
\ @brief LPTIM5 compare register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM5_S_LPTIM5_CCR2_CCR2                        \ Capture/compare 2 value


\
\ @brief Low-power timer
\
$56003000 constant LPTIM5_S_LPTIM5_ISR  \ offset: 0x00 : LPTIM5 interrupt and status register
$56003004 constant LPTIM5_S_LPTIM5_ICR  \ offset: 0x04 : LPTIM5 interrupt clear register
$56003008 constant LPTIM5_S_LPTIM5_DIER  \ offset: 0x08 : LPTIM5 interrupt enable register
$5600300c constant LPTIM5_S_LPTIM5_CFGR  \ offset: 0x0C : LPTIM5 configuration register
$56003010 constant LPTIM5_S_LPTIM5_CR  \ offset: 0x10 : LPTIM5 control register
$56003014 constant LPTIM5_S_LPTIM5_CCR1  \ offset: 0x14 : LPTIM5 compare register 1
$56003018 constant LPTIM5_S_LPTIM5_ARR  \ offset: 0x18 : LPTIM5 autoreload register
$5600301c constant LPTIM5_S_LPTIM5_CNT  \ offset: 0x1C : LPTIM5 counter register
$56003024 constant LPTIM5_S_LPTIM5_CFGR2  \ offset: 0x24 : LPTIM5 configuration register 2
$56003028 constant LPTIM5_S_LPTIM5_RCR  \ offset: 0x28 : LPTIM5 repetition register
$5600302c constant LPTIM5_S_LPTIM5_CCMR1  \ offset: 0x2C : LPTIM5 capture/compare mode register 1
$56003034 constant LPTIM5_S_LPTIM5_CCR2  \ offset: 0x34 : LPTIM5 compare register 2

