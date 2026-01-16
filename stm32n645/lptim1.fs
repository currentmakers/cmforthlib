\
\ @file lptim1.fs
\ @brief Low-power timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief LPTIM1 interrupt and status register [alternate]
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM1_ISR_OUTPUT_CC1IF                   \ Compare 1 interrupt flag
$00000002 constant LPTIM1_LPTIM1_ISR_OUTPUT_ARRM                    \ Autoreload match
$00000004 constant LPTIM1_LPTIM1_ISR_OUTPUT_EXTTRIG                 \ External trigger edge event
$00000008 constant LPTIM1_LPTIM1_ISR_OUTPUT_CMP1OK                  \ Compare register 1 update OK
$00000010 constant LPTIM1_LPTIM1_ISR_OUTPUT_ARROK                   \ Autoreload register update OK
$00000020 constant LPTIM1_LPTIM1_ISR_OUTPUT_UP                      \ Counter direction change down to up
$00000040 constant LPTIM1_LPTIM1_ISR_OUTPUT_DOWN                    \ Counter direction change up to down
$00000080 constant LPTIM1_LPTIM1_ISR_OUTPUT_UE                      \ LPTIM update event occurred
$00000100 constant LPTIM1_LPTIM1_ISR_OUTPUT_REPOK                   \ Repetition register update OK
$00000200 constant LPTIM1_LPTIM1_ISR_OUTPUT_CC2IF                   \ Compare 2 interrupt flag
$00080000 constant LPTIM1_LPTIM1_ISR_OUTPUT_CMP2OK                  \ Compare register 2 update OK
$01000000 constant LPTIM1_LPTIM1_ISR_OUTPUT_DIEROK                  \ Interrupt enable register update OK


\
\ @brief LPTIM1 interrupt and status register [alternate]
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM1_ISR_INPUT_CC1IF                    \ capture 1 interrupt flag
$00000002 constant LPTIM1_LPTIM1_ISR_INPUT_ARRM                     \ Autoreload match
$00000004 constant LPTIM1_LPTIM1_ISR_INPUT_EXTTRIG                  \ External trigger edge event
$00000010 constant LPTIM1_LPTIM1_ISR_INPUT_ARROK                    \ Autoreload register update OK
$00000020 constant LPTIM1_LPTIM1_ISR_INPUT_UP                       \ Counter direction change down to up
$00000040 constant LPTIM1_LPTIM1_ISR_INPUT_DOWN                     \ Counter direction change up to down
$00000080 constant LPTIM1_LPTIM1_ISR_INPUT_UE                       \ LPTIM update event occurred
$00000100 constant LPTIM1_LPTIM1_ISR_INPUT_REPOK                    \ Repetition register update OK
$00000200 constant LPTIM1_LPTIM1_ISR_INPUT_CC2IF                    \ Capture 2 interrupt flag
$00001000 constant LPTIM1_LPTIM1_ISR_INPUT_CC1OF                    \ Capture 1 over-capture flag
$00002000 constant LPTIM1_LPTIM1_ISR_INPUT_CC2OF                    \ Capture 2 over-capture flag
$01000000 constant LPTIM1_LPTIM1_ISR_INPUT_DIEROK                   \ Interrupt enable register update OK


\
\ @brief LPTIM1 interrupt clear register [alternate]
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM1_ICR_OUTPUT_CC1CF                   \ Capture/compare 1 clear flag
$00000002 constant LPTIM1_LPTIM1_ICR_OUTPUT_ARRMCF                  \ Autoreload match clear flag
$00000004 constant LPTIM1_LPTIM1_ICR_OUTPUT_EXTTRIGCF               \ External trigger valid edge clear flag
$00000008 constant LPTIM1_LPTIM1_ICR_OUTPUT_CMP1OKCF                \ Compare register 1 update OK clear flag
$00000010 constant LPTIM1_LPTIM1_ICR_OUTPUT_ARROKCF                 \ Autoreload register update OK clear flag
$00000020 constant LPTIM1_LPTIM1_ICR_OUTPUT_UPCF                    \ Direction change to UP clear flag
$00000040 constant LPTIM1_LPTIM1_ICR_OUTPUT_DOWNCF                  \ Direction change to down clear flag
$00000080 constant LPTIM1_LPTIM1_ICR_OUTPUT_UECF                    \ Update event clear flag
$00000100 constant LPTIM1_LPTIM1_ICR_OUTPUT_REPOKCF                 \ Repetition register update OK clear flag
$00000200 constant LPTIM1_LPTIM1_ICR_OUTPUT_CC2CF                   \ Capture/compare 2 clear flag
$00080000 constant LPTIM1_LPTIM1_ICR_OUTPUT_CMP2OKCF                \ Compare register 2 update OK clear flag
$01000000 constant LPTIM1_LPTIM1_ICR_OUTPUT_DIEROKCF                \ Interrupt enable register update OK clear flag


\
\ @brief LPTIM1 interrupt clear register [alternate]
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM1_ICR_INPUT_CC1CF                    \ Capture/compare 1 clear flag
$00000002 constant LPTIM1_LPTIM1_ICR_INPUT_ARRMCF                   \ Autoreload match clear flag
$00000004 constant LPTIM1_LPTIM1_ICR_INPUT_EXTTRIGCF                \ External trigger valid edge clear flag
$00000010 constant LPTIM1_LPTIM1_ICR_INPUT_ARROKCF                  \ Autoreload register update OK clear flag
$00000020 constant LPTIM1_LPTIM1_ICR_INPUT_UPCF                     \ Direction change to UP clear flag
$00000040 constant LPTIM1_LPTIM1_ICR_INPUT_DOWNCF                   \ Direction change to down clear flag
$00000080 constant LPTIM1_LPTIM1_ICR_INPUT_UECF                     \ Update event clear flag
$00000100 constant LPTIM1_LPTIM1_ICR_INPUT_REPOKCF                  \ Repetition register update OK clear flag
$00000200 constant LPTIM1_LPTIM1_ICR_INPUT_CC2CF                    \ Capture/compare 2 clear flag
$00001000 constant LPTIM1_LPTIM1_ICR_INPUT_CC1OCF                   \ Capture/compare 1 over-capture clear flag
$00002000 constant LPTIM1_LPTIM1_ICR_INPUT_CC2OCF                   \ Capture/compare 2 over-capture clear flag
$01000000 constant LPTIM1_LPTIM1_ICR_INPUT_DIEROKCF                 \ Interrupt enable register update OK clear flag


\
\ @brief LPTIM1 interrupt enable register [alternate]
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM1_DIER_OUTPUT_CC1IE                  \ Capture/compare 1 interrupt enable
$00000002 constant LPTIM1_LPTIM1_DIER_OUTPUT_ARRMIE                 \ Autoreload match Interrupt Enable
$00000004 constant LPTIM1_LPTIM1_DIER_OUTPUT_EXTTRIGIE              \ External trigger valid edge Interrupt Enable
$00000008 constant LPTIM1_LPTIM1_DIER_OUTPUT_CMP1OKIE               \ Compare register 1 update OK interrupt enable
$00000010 constant LPTIM1_LPTIM1_DIER_OUTPUT_ARROKIE                \ Autoreload register update OK Interrupt Enable
$00000020 constant LPTIM1_LPTIM1_DIER_OUTPUT_UPIE                   \ Direction change to UP Interrupt Enable
$00000040 constant LPTIM1_LPTIM1_DIER_OUTPUT_DOWNIE                 \ Direction change to down Interrupt Enable
$00000080 constant LPTIM1_LPTIM1_DIER_OUTPUT_UEIE                   \ Update event interrupt enable
$00000100 constant LPTIM1_LPTIM1_DIER_OUTPUT_REPOKIE                \ Repetition register update OK interrupt Enable
$00000200 constant LPTIM1_LPTIM1_DIER_OUTPUT_CC2IE                  \ Capture/compare 2 interrupt enable
$00080000 constant LPTIM1_LPTIM1_DIER_OUTPUT_CMP2OKIE               \ Compare register 2 update OK interrupt enable
$00800000 constant LPTIM1_LPTIM1_DIER_OUTPUT_UEDE                   \ Update event DMA request enable


\
\ @brief LPTIM1 interrupt enable register [alternate]
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM1_DIER_INPUT_CC1IE                   \ Capture/compare 1 interrupt enable
$00000002 constant LPTIM1_LPTIM1_DIER_INPUT_ARRMIE                  \ Autoreload match Interrupt Enable
$00000004 constant LPTIM1_LPTIM1_DIER_INPUT_EXTTRIGIE               \ External trigger valid edge Interrupt Enable
$00000010 constant LPTIM1_LPTIM1_DIER_INPUT_ARROKIE                 \ Autoreload register update OK Interrupt Enable
$00000020 constant LPTIM1_LPTIM1_DIER_INPUT_UPIE                    \ Direction change to UP Interrupt Enable
$00000040 constant LPTIM1_LPTIM1_DIER_INPUT_DOWNIE                  \ Direction change to down Interrupt Enable
$00000080 constant LPTIM1_LPTIM1_DIER_INPUT_UEIE                    \ Update event interrupt enable
$00000100 constant LPTIM1_LPTIM1_DIER_INPUT_REPOKIE                 \ Repetition register update OK interrupt Enable
$00000200 constant LPTIM1_LPTIM1_DIER_INPUT_CC2IE                   \ Capture/compare 2 interrupt enable
$00001000 constant LPTIM1_LPTIM1_DIER_INPUT_CC1OIE                  \ Capture/compare 1 over-capture interrupt enable
$00002000 constant LPTIM1_LPTIM1_DIER_INPUT_CC2OIE                  \ Capture/compare 2 over-capture interrupt enable
$00010000 constant LPTIM1_LPTIM1_DIER_INPUT_CC1DE                   \ Capture/compare 1 DMA request enable
$00800000 constant LPTIM1_LPTIM1_DIER_INPUT_UEDE                    \ Update event DMA request enable
$02000000 constant LPTIM1_LPTIM1_DIER_INPUT_CC2DE                   \ Capture/compare 2 DMA request enable


\
\ @brief LPTIM1 configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM1_CFGR_CKSEL                         \ Clock selector
$00000006 constant LPTIM1_LPTIM1_CFGR_CKPOL                         \ Clock Polarity
$00000018 constant LPTIM1_LPTIM1_CFGR_CKFLT                         \ Configurable digital filter for external clock
$000000c0 constant LPTIM1_LPTIM1_CFGR_TRGFLT                        \ Configurable digital filter for trigger
$00000e00 constant LPTIM1_LPTIM1_CFGR_PRESC                         \ Clock prescaler
$0000e000 constant LPTIM1_LPTIM1_CFGR_TRIGSEL                       \ Trigger selector
$00060000 constant LPTIM1_LPTIM1_CFGR_TRIGEN                        \ Trigger enable and polarity
$00080000 constant LPTIM1_LPTIM1_CFGR_TIMOUT                        \ Timeout enable
$00100000 constant LPTIM1_LPTIM1_CFGR_WAVE                          \ Waveform shape
$00200000 constant LPTIM1_LPTIM1_CFGR_WAVPOL                        \ Waveform shape polarity
$00400000 constant LPTIM1_LPTIM1_CFGR_PRELOAD                       \ Registers update mode
$00800000 constant LPTIM1_LPTIM1_CFGR_COUNTMODE                     \ counter mode enabled
$01000000 constant LPTIM1_LPTIM1_CFGR_ENC                           \ Encoder mode enable


\
\ @brief LPTIM1 control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM1_CR_ENABLE                          \ LPTIM enable
$00000002 constant LPTIM1_LPTIM1_CR_SNGSTRT                         \ LPTIM start in Single mode
$00000004 constant LPTIM1_LPTIM1_CR_CNTSTRT                         \ Timer start in Continuous mode
$00000008 constant LPTIM1_LPTIM1_CR_COUNTRST                        \ Counter reset
$00000010 constant LPTIM1_LPTIM1_CR_RSTARE                          \ Reset after read enable


\
\ @brief LPTIM1 compare register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM1_LPTIM1_CCR1_CCR1                          \ Capture/compare 1 value


\
\ @brief LPTIM1 autoreload register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$0000ffff constant LPTIM1_LPTIM1_ARR_ARR                            \ Auto reload value


\
\ @brief LPTIM1 counter register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM1_LPTIM1_CNT_CNT                            \ Counter value


\
\ @brief LPTIM1 configuration register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000003 constant LPTIM1_LPTIM1_CFGR2_IN1SEL                       \ LPTIM input 1 selection
$00000030 constant LPTIM1_LPTIM1_CFGR2_IN2SEL                       \ LPTIM input 2 selection
$00030000 constant LPTIM1_LPTIM1_CFGR2_IC1SEL                       \ LPTIM input capture 1 selection
$00300000 constant LPTIM1_LPTIM1_CFGR2_IC2SEL                       \ LPTIM input capture 2 selection


\
\ @brief LPTIM1 repetition register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant LPTIM1_LPTIM1_RCR_REP                            \ Repetition register value


\
\ @brief LPTIM1 capture/compare mode register 1
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM1_CCMR1_CC1SEL                       \ Capture/compare 1 selection
$00000002 constant LPTIM1_LPTIM1_CCMR1_CC1E                         \ Capture/compare 1 output enable.
$0000000c constant LPTIM1_LPTIM1_CCMR1_CC1P                         \ Capture/compare 1 output polarity.
$00000300 constant LPTIM1_LPTIM1_CCMR1_IC1PSC                       \ Input capture 1 prescaler
$00003000 constant LPTIM1_LPTIM1_CCMR1_IC1F                         \ Input capture 1 filter
$00010000 constant LPTIM1_LPTIM1_CCMR1_CC2SEL                       \ Capture/compare 2 selection
$00020000 constant LPTIM1_LPTIM1_CCMR1_CC2E                         \ Capture/compare 2 output enable.
$000c0000 constant LPTIM1_LPTIM1_CCMR1_CC2P                         \ Capture/compare 2 output polarity.
$03000000 constant LPTIM1_LPTIM1_CCMR1_IC2PSC                       \ Input capture 2 prescaler
$30000000 constant LPTIM1_LPTIM1_CCMR1_IC2F                         \ Input capture 2 filter


\
\ @brief LPTIM1 compare register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM1_LPTIM1_CCR2_CCR2                          \ Capture/compare 2 value


\
\ @brief Low-power timer
\
$40002400 constant LPTIM1_LPTIM1_ISR_OUTPUT  \ offset: 0x00 : LPTIM1 interrupt and status register [alternate]
$40002400 constant LPTIM1_LPTIM1_ISR_INPUT  \ offset: 0x00 : LPTIM1 interrupt and status register [alternate]
$40002404 constant LPTIM1_LPTIM1_ICR_OUTPUT  \ offset: 0x04 : LPTIM1 interrupt clear register [alternate]
$40002404 constant LPTIM1_LPTIM1_ICR_INPUT  \ offset: 0x04 : LPTIM1 interrupt clear register [alternate]
$40002408 constant LPTIM1_LPTIM1_DIER_OUTPUT  \ offset: 0x08 : LPTIM1 interrupt enable register [alternate]
$40002408 constant LPTIM1_LPTIM1_DIER_INPUT  \ offset: 0x08 : LPTIM1 interrupt enable register [alternate]
$4000240c constant LPTIM1_LPTIM1_CFGR  \ offset: 0x0C : LPTIM1 configuration register
$40002410 constant LPTIM1_LPTIM1_CR  \ offset: 0x10 : LPTIM1 control register
$40002414 constant LPTIM1_LPTIM1_CCR1  \ offset: 0x14 : LPTIM1 compare register 1
$40002418 constant LPTIM1_LPTIM1_ARR  \ offset: 0x18 : LPTIM1 autoreload register
$4000241c constant LPTIM1_LPTIM1_CNT  \ offset: 0x1C : LPTIM1 counter register
$40002424 constant LPTIM1_LPTIM1_CFGR2  \ offset: 0x24 : LPTIM1 configuration register 2
$40002428 constant LPTIM1_LPTIM1_RCR  \ offset: 0x28 : LPTIM1 repetition register
$4000242c constant LPTIM1_LPTIM1_CCMR1  \ offset: 0x2C : LPTIM1 capture/compare mode register 1
$40002434 constant LPTIM1_LPTIM1_CCR2  \ offset: 0x34 : LPTIM1 compare register 2

