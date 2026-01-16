\
\ @file lptim2_s.fs
\ @brief LPTIM2 address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief LPTIM2 interrupt and status register [alternate]
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LPTIM2_S_LPTIM2_ISR_CC1IF                        \ Compare 1 interrupt flag
$00000002 constant LPTIM2_S_LPTIM2_ISR_ARRM                         \ Autoreload match
$00000004 constant LPTIM2_S_LPTIM2_ISR_EXTTRIG                      \ External trigger edge event
$00000008 constant LPTIM2_S_LPTIM2_ISR_CMP1OK                       \ Compare register 1 update OK
$00000010 constant LPTIM2_S_LPTIM2_ISR_ARROK                        \ Autoreload register update OK
$00000020 constant LPTIM2_S_LPTIM2_ISR_UP                           \ Counter direction change down to up
$00000040 constant LPTIM2_S_LPTIM2_ISR_DOWN                         \ Counter direction change up to down
$00000080 constant LPTIM2_S_LPTIM2_ISR_UE                           \ LPTIM update event occurred
$00000100 constant LPTIM2_S_LPTIM2_ISR_REPOK                        \ Repetition register update OK
$00000200 constant LPTIM2_S_LPTIM2_ISR_CC2IF                        \ Compare 2 interrupt flag
$00080000 constant LPTIM2_S_LPTIM2_ISR_CMP2OK                       \ Compare register 2 update OK
$01000000 constant LPTIM2_S_LPTIM2_ISR_DIEROK                       \ Interrupt enable register update OK


\
\ @brief LPTIM2 interrupt and status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LPTIM2_S_LPTIM2_ISR_ALTERNATE1_CC1IF             \ capture 1 interrupt flag
$00000002 constant LPTIM2_S_LPTIM2_ISR_ALTERNATE1_ARRM              \ Autoreload match
$00000004 constant LPTIM2_S_LPTIM2_ISR_ALTERNATE1_EXTTRIG           \ External trigger edge event
$00000010 constant LPTIM2_S_LPTIM2_ISR_ALTERNATE1_ARROK             \ Autoreload register update OK
$00000020 constant LPTIM2_S_LPTIM2_ISR_ALTERNATE1_UP                \ Counter direction change down to up
$00000040 constant LPTIM2_S_LPTIM2_ISR_ALTERNATE1_DOWN              \ Counter direction change up to down
$00000080 constant LPTIM2_S_LPTIM2_ISR_ALTERNATE1_UE                \ LPTIM update event occurred
$00000100 constant LPTIM2_S_LPTIM2_ISR_ALTERNATE1_REPOK             \ Repetition register update OK
$00000200 constant LPTIM2_S_LPTIM2_ISR_ALTERNATE1_CC2IF             \ Capture 2 interrupt flag
$00001000 constant LPTIM2_S_LPTIM2_ISR_ALTERNATE1_CC1OF             \ Capture 1 over-capture flag
$00002000 constant LPTIM2_S_LPTIM2_ISR_ALTERNATE1_CC2OF             \ Capture 2 over-capture flag
$01000000 constant LPTIM2_S_LPTIM2_ISR_ALTERNATE1_DIEROK            \ Interrupt enable register update OK


\
\ @brief LPTIM2 interrupt clear register [alternate]
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LPTIM2_S_LPTIM2_ICR_CC1CF                        \ Capture/compare 1 clear flag
$00000002 constant LPTIM2_S_LPTIM2_ICR_ARRMCF                       \ Autoreload match clear flag
$00000004 constant LPTIM2_S_LPTIM2_ICR_EXTTRIGCF                    \ External trigger valid edge clear flag
$00000008 constant LPTIM2_S_LPTIM2_ICR_CMP1OKCF                     \ Compare register 1 update OK clear flag
$00000010 constant LPTIM2_S_LPTIM2_ICR_ARROKCF                      \ Autoreload register update OK clear flag
$00000020 constant LPTIM2_S_LPTIM2_ICR_UPCF                         \ Direction change to UP clear flag
$00000040 constant LPTIM2_S_LPTIM2_ICR_DOWNCF                       \ Direction change to down clear flag
$00000080 constant LPTIM2_S_LPTIM2_ICR_UECF                         \ Update event clear flag
$00000100 constant LPTIM2_S_LPTIM2_ICR_REPOKCF                      \ Repetition register update OK clear flag
$00000200 constant LPTIM2_S_LPTIM2_ICR_CC2CF                        \ Capture/compare 2 clear flag
$00080000 constant LPTIM2_S_LPTIM2_ICR_CMP2OKCF                     \ Compare register 2 update OK clear flag
$01000000 constant LPTIM2_S_LPTIM2_ICR_DIEROKCF                     \ Interrupt enable register update OK clear flag


\
\ @brief LPTIM2 interrupt clear register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LPTIM2_S_LPTIM2_ICR_ALTERNATE1_CC1CF             \ Capture/compare 1 clear flag
$00000002 constant LPTIM2_S_LPTIM2_ICR_ALTERNATE1_ARRMCF            \ Autoreload match clear flag
$00000004 constant LPTIM2_S_LPTIM2_ICR_ALTERNATE1_EXTTRIGCF         \ External trigger valid edge clear flag
$00000010 constant LPTIM2_S_LPTIM2_ICR_ALTERNATE1_ARROKCF           \ Autoreload register update OK clear flag
$00000020 constant LPTIM2_S_LPTIM2_ICR_ALTERNATE1_UPCF              \ Direction change to UP clear flag
$00000040 constant LPTIM2_S_LPTIM2_ICR_ALTERNATE1_DOWNCF            \ Direction change to down clear flag
$00000080 constant LPTIM2_S_LPTIM2_ICR_ALTERNATE1_UECF              \ Update event clear flag
$00000100 constant LPTIM2_S_LPTIM2_ICR_ALTERNATE1_REPOKCF           \ Repetition register update OK clear flag
$00000200 constant LPTIM2_S_LPTIM2_ICR_ALTERNATE1_CC2CF             \ Capture/compare 2 clear flag
$00001000 constant LPTIM2_S_LPTIM2_ICR_ALTERNATE1_CC1OCF            \ Capture/compare 1 over-capture clear flag
$00002000 constant LPTIM2_S_LPTIM2_ICR_ALTERNATE1_CC2OCF            \ Capture/compare 2 over-capture clear flag
$01000000 constant LPTIM2_S_LPTIM2_ICR_ALTERNATE1_DIEROKCF          \ Interrupt enable register update OK clear flag


\
\ @brief LPTIM2 interrupt enable register [alternate]
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant LPTIM2_S_LPTIM2_DIER_CC1IE                       \ Capture/compare 1 interrupt enable
$00000002 constant LPTIM2_S_LPTIM2_DIER_ARRMIE                      \ Autoreload match Interrupt Enable
$00000004 constant LPTIM2_S_LPTIM2_DIER_EXTTRIGIE                   \ External trigger valid edge Interrupt Enable
$00000008 constant LPTIM2_S_LPTIM2_DIER_CMP1OKIE                    \ Compare register 1 update OK interrupt enable
$00000010 constant LPTIM2_S_LPTIM2_DIER_ARROKIE                     \ Autoreload register update OK Interrupt Enable
$00000020 constant LPTIM2_S_LPTIM2_DIER_UPIE                        \ Direction change to UP Interrupt Enable
$00000040 constant LPTIM2_S_LPTIM2_DIER_DOWNIE                      \ Direction change to down Interrupt Enable
$00000080 constant LPTIM2_S_LPTIM2_DIER_UEIE                        \ Update event interrupt enable
$00000100 constant LPTIM2_S_LPTIM2_DIER_REPOKIE                     \ Repetition register update OK interrupt Enable
$00000200 constant LPTIM2_S_LPTIM2_DIER_CC2IE                       \ Capture/compare 2 interrupt enable
$00080000 constant LPTIM2_S_LPTIM2_DIER_CMP2OKIE                    \ Compare register 2 update OK interrupt enable
$00800000 constant LPTIM2_S_LPTIM2_DIER_UEDE                        \ Update event DMA request enable


\
\ @brief LPTIM2 interrupt enable register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant LPTIM2_S_LPTIM2_DIER_ALTERNATE1_CC1IE            \ Capture/compare 1 interrupt enable
$00000002 constant LPTIM2_S_LPTIM2_DIER_ALTERNATE1_ARRMIE           \ Autoreload match Interrupt Enable
$00000004 constant LPTIM2_S_LPTIM2_DIER_ALTERNATE1_EXTTRIGIE        \ External trigger valid edge Interrupt Enable
$00000010 constant LPTIM2_S_LPTIM2_DIER_ALTERNATE1_ARROKIE          \ Autoreload register update OK Interrupt Enable
$00000020 constant LPTIM2_S_LPTIM2_DIER_ALTERNATE1_UPIE             \ Direction change to UP Interrupt Enable
$00000040 constant LPTIM2_S_LPTIM2_DIER_ALTERNATE1_DOWNIE           \ Direction change to down Interrupt Enable
$00000080 constant LPTIM2_S_LPTIM2_DIER_ALTERNATE1_UEIE             \ Update event interrupt enable
$00000100 constant LPTIM2_S_LPTIM2_DIER_ALTERNATE1_REPOKIE          \ Repetition register update OK interrupt Enable
$00000200 constant LPTIM2_S_LPTIM2_DIER_ALTERNATE1_CC2IE            \ Capture/compare 2 interrupt enable
$00001000 constant LPTIM2_S_LPTIM2_DIER_ALTERNATE1_CC1OIE           \ Capture/compare 1 over-capture interrupt enable
$00002000 constant LPTIM2_S_LPTIM2_DIER_ALTERNATE1_CC2OIE           \ Capture/compare 2 over-capture interrupt enable
$00010000 constant LPTIM2_S_LPTIM2_DIER_ALTERNATE1_CC1DE            \ Capture/compare 1 DMA request enable
$00800000 constant LPTIM2_S_LPTIM2_DIER_ALTERNATE1_UEDE             \ Update event DMA request enable
$02000000 constant LPTIM2_S_LPTIM2_DIER_ALTERNATE1_CC2DE            \ Capture/compare 2 DMA request enable


\
\ @brief LPTIM configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant LPTIM2_S_LPTIM_CFGR_CKSEL                        \ Clock selector
$00000006 constant LPTIM2_S_LPTIM_CFGR_CKPOL                        \ Clock Polarity
$00000018 constant LPTIM2_S_LPTIM_CFGR_CKFLT                        \ Configurable digital filter for external clock
$000000c0 constant LPTIM2_S_LPTIM_CFGR_TRGFLT                       \ Configurable digital filter for trigger
$00000e00 constant LPTIM2_S_LPTIM_CFGR_PRESC                        \ Clock prescaler
$0000e000 constant LPTIM2_S_LPTIM_CFGR_TRIGSEL                      \ Trigger selector
$00060000 constant LPTIM2_S_LPTIM_CFGR_TRIGEN                       \ Trigger enable and polarity
$00080000 constant LPTIM2_S_LPTIM_CFGR_TIMOUT                       \ Timeout enable
$00100000 constant LPTIM2_S_LPTIM_CFGR_WAVE                         \ Waveform shape
$00200000 constant LPTIM2_S_LPTIM_CFGR_WAVPOL                       \ Waveform shape polarity
$00400000 constant LPTIM2_S_LPTIM_CFGR_PRELOAD                      \ Registers update mode
$00800000 constant LPTIM2_S_LPTIM_CFGR_COUNTMODE                    \ counter mode enabled
$01000000 constant LPTIM2_S_LPTIM_CFGR_ENC                          \ Encoder mode enable


\
\ @brief LPTIM control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant LPTIM2_S_LPTIM_CR_ENABLE                         \ LPTIM enable
$00000002 constant LPTIM2_S_LPTIM_CR_SNGSTRT                        \ LPTIM start in Single mode
$00000004 constant LPTIM2_S_LPTIM_CR_CNTSTRT                        \ Timer start in Continuous mode
$00000008 constant LPTIM2_S_LPTIM_CR_COUNTRST                       \ Counter reset
$00000010 constant LPTIM2_S_LPTIM_CR_RSTARE                         \ Reset after read enable


\
\ @brief LPTIM compare register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM2_S_LPTIM_CCR1_CCR1                         \ Capture/compare 1 value


\
\ @brief LPTIM autoreload register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$0000ffff constant LPTIM2_S_LPTIM_ARR_ARR                           \ Auto reload value


\
\ @brief LPTIM counter register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM2_S_LPTIM_CNT_CNT                           \ Counter value


\
\ @brief LPTIM configuration register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000003 constant LPTIM2_S_LPTIM_CFGR2_IN1SEL                      \ LPTIM input 1 selection
$00000030 constant LPTIM2_S_LPTIM_CFGR2_IN2SEL                      \ LPTIM input 2 selection
$00030000 constant LPTIM2_S_LPTIM_CFGR2_IC1SEL                      \ LPTIM input capture 1 selection
$00300000 constant LPTIM2_S_LPTIM_CFGR2_IC2SEL                      \ LPTIM input capture 2 selection


\
\ @brief LPTIM repetition register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant LPTIM2_S_LPTIM_RCR_REP                           \ Repetition register value


\
\ @brief LPTIM capture/compare mode register 1
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant LPTIM2_S_LPTIM_CCMR1_CC1SEL                      \ Capture/compare 1 selection
$00000002 constant LPTIM2_S_LPTIM_CCMR1_CC1E                        \ Capture/compare 1 output enable.
$0000000c constant LPTIM2_S_LPTIM_CCMR1_CC1P                        \ Capture/compare 1 output polarity.
$00000300 constant LPTIM2_S_LPTIM_CCMR1_IC1PSC                      \ Input capture 1 prescaler
$00003000 constant LPTIM2_S_LPTIM_CCMR1_IC1F                        \ Input capture 1 filter
$00010000 constant LPTIM2_S_LPTIM_CCMR1_CC2SEL                      \ Capture/compare 2 selection
$00020000 constant LPTIM2_S_LPTIM_CCMR1_CC2E                        \ Capture/compare 2 output enable.
$000c0000 constant LPTIM2_S_LPTIM_CCMR1_CC2P                        \ Capture/compare 2 output polarity.
$03000000 constant LPTIM2_S_LPTIM_CCMR1_IC2PSC                      \ Input capture 2 prescaler
$30000000 constant LPTIM2_S_LPTIM_CCMR1_IC2F                        \ Input capture 2 filter


\
\ @brief LPTIM compare register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM2_S_LPTIM_CCR2_CCR2                         \ Capture/compare 2 value


\
\ @brief LPTIM2 address block description
\
$50009400 constant LPTIM2_S_LPTIM2_ISR  \ offset: 0x00 : LPTIM2 interrupt and status register [alternate]
$50009400 constant LPTIM2_S_LPTIM2_ISR_ALTERNATE1  \ offset: 0x00 : LPTIM2 interrupt and status register
$50009404 constant LPTIM2_S_LPTIM2_ICR  \ offset: 0x04 : LPTIM2 interrupt clear register [alternate]
$50009404 constant LPTIM2_S_LPTIM2_ICR_ALTERNATE1  \ offset: 0x04 : LPTIM2 interrupt clear register
$50009408 constant LPTIM2_S_LPTIM2_DIER  \ offset: 0x08 : LPTIM2 interrupt enable register [alternate]
$50009408 constant LPTIM2_S_LPTIM2_DIER_ALTERNATE1  \ offset: 0x08 : LPTIM2 interrupt enable register
$5000940c constant LPTIM2_S_LPTIM_CFGR  \ offset: 0x0C : LPTIM configuration register
$50009410 constant LPTIM2_S_LPTIM_CR  \ offset: 0x10 : LPTIM control register
$50009414 constant LPTIM2_S_LPTIM_CCR1  \ offset: 0x14 : LPTIM compare register 1
$50009418 constant LPTIM2_S_LPTIM_ARR  \ offset: 0x18 : LPTIM autoreload register
$5000941c constant LPTIM2_S_LPTIM_CNT  \ offset: 0x1C : LPTIM counter register
$50009424 constant LPTIM2_S_LPTIM_CFGR2  \ offset: 0x24 : LPTIM configuration register 2
$50009428 constant LPTIM2_S_LPTIM_RCR  \ offset: 0x28 : LPTIM repetition register
$5000942c constant LPTIM2_S_LPTIM_CCMR1  \ offset: 0x2C : LPTIM capture/compare mode register 1
$50009434 constant LPTIM2_S_LPTIM_CCR2  \ offset: 0x34 : LPTIM compare register 2

