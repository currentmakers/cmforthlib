\
\ @file sec_lptim3.fs
\ @brief Low power timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Interrupt and Status Register (output mode)
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM3_ISR_OUTPUT_CC1IF                      \ Compare 1 interrupt flag
$00000002 constant SEC_LPTIM3_ISR_OUTPUT_ARRM                       \ Autoreload match
$00000004 constant SEC_LPTIM3_ISR_OUTPUT_EXTTRIG                    \ External trigger edge event
$00000008 constant SEC_LPTIM3_ISR_OUTPUT_CMP1OK                     \ Compare register 1 update OK
$00000010 constant SEC_LPTIM3_ISR_OUTPUT_ARROK                      \ Autoreload register update OK
$00000020 constant SEC_LPTIM3_ISR_OUTPUT_UP                         \ Counter direction change down to up
$00000040 constant SEC_LPTIM3_ISR_OUTPUT_DOWN                       \ Counter direction change up to down
$00000080 constant SEC_LPTIM3_ISR_OUTPUT_UE                         \ LPTIM update event occurred
$00000100 constant SEC_LPTIM3_ISR_OUTPUT_REPOK                      \ Repetition register update Ok
$00000200 constant SEC_LPTIM3_ISR_OUTPUT_CC2IF                      \ Compare 2 interrupt flag
$00080000 constant SEC_LPTIM3_ISR_OUTPUT_CMP2OK                     \ Compare register 2 update OK
$01000000 constant SEC_LPTIM3_ISR_OUTPUT_DIEROK                     \ Interrupt enable register update OK


\
\ @brief Interrupt and Status Register (intput mode)
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM3_ISR_INPUT_CC1IF                       \ Compare 1 interrupt flag
$00000002 constant SEC_LPTIM3_ISR_INPUT_ARRM                        \ Autoreload match
$00000004 constant SEC_LPTIM3_ISR_INPUT_EXTTRIG                     \ External trigger edge event
$00000010 constant SEC_LPTIM3_ISR_INPUT_ARROK                       \ Autoreload register update OK
$00000020 constant SEC_LPTIM3_ISR_INPUT_UP                          \ Counter direction change down to up
$00000040 constant SEC_LPTIM3_ISR_INPUT_DOWN                        \ Counter direction change up to down
$00000080 constant SEC_LPTIM3_ISR_INPUT_UE                          \ LPTIM update event occurred
$00000100 constant SEC_LPTIM3_ISR_INPUT_REPOK                       \ Repetition register update Ok
$00000200 constant SEC_LPTIM3_ISR_INPUT_CC2IF                       \ Capture 2 interrupt flag
$00001000 constant SEC_LPTIM3_ISR_INPUT_CC1OF                       \ Capture 1 over-capture flag
$00002000 constant SEC_LPTIM3_ISR_INPUT_CC2OF                       \ Capture 2 over-capture flag
$01000000 constant SEC_LPTIM3_ISR_INPUT_DIEROK                      \ Interrupt enable register update OK


\
\ @brief Interrupt Clear Register (output mode)
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM3_ICR_OUTPUT_CC1IF                      \ Capture/compare 1 clear flag
$00000002 constant SEC_LPTIM3_ICR_OUTPUT_ARRMCF                     \ Autoreload match Clear Flag
$00000004 constant SEC_LPTIM3_ICR_OUTPUT_EXTTRIGCF                  \ External trigger valid edge Clear Flag
$00000008 constant SEC_LPTIM3_ICR_OUTPUT_CMP1OKCF                   \ Compare register 1 update OK Clear Flag
$00000010 constant SEC_LPTIM3_ICR_OUTPUT_ARROKCF                    \ Autoreload register update OK Clear Flag
$00000020 constant SEC_LPTIM3_ICR_OUTPUT_UPCF                       \ Direction change to UP Clear Flag
$00000040 constant SEC_LPTIM3_ICR_OUTPUT_DOWNCF                     \ Direction change to down Clear Flag
$00000080 constant SEC_LPTIM3_ICR_OUTPUT_UECF                       \ Update event clear flag
$00000100 constant SEC_LPTIM3_ICR_OUTPUT_REPOKCF                    \ Repetition register update OK clear flag
$00000200 constant SEC_LPTIM3_ICR_OUTPUT_CC2CF                      \ Capture/compare 2 clear flag
$00080000 constant SEC_LPTIM3_ICR_OUTPUT_CMP2OKCF                   \ Compare register 2 update OK clear flag
$01000000 constant SEC_LPTIM3_ICR_OUTPUT_DIEROKCF                   \ Interrupt enable register update OK clear flag


\
\ @brief Interrupt Clear Register (intput mode)
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM3_ICR_INPUT_CC1IF                       \ Capture/compare 1 clear flag
$00000002 constant SEC_LPTIM3_ICR_INPUT_ARRMCF                      \ Autoreload match Clear Flag
$00000004 constant SEC_LPTIM3_ICR_INPUT_EXTTRIGCF                   \ External trigger valid edge Clear Flag
$00000010 constant SEC_LPTIM3_ICR_INPUT_ARROKCF                     \ Autoreload register update OK Clear Flag
$00000020 constant SEC_LPTIM3_ICR_INPUT_UPCF                        \ Direction change to UP Clear Flag
$00000040 constant SEC_LPTIM3_ICR_INPUT_DOWNCF                      \ Direction change to down Clear Flag
$00000080 constant SEC_LPTIM3_ICR_INPUT_UECF                        \ Update event clear flag
$00000100 constant SEC_LPTIM3_ICR_INPUT_REPOKCF                     \ Repetition register update OK clear flag
$00000200 constant SEC_LPTIM3_ICR_INPUT_CC2CF                       \ Capture/compare 2 clear flag
$00001000 constant SEC_LPTIM3_ICR_INPUT_CC1OCF                      \ Capture/compare 1 over-capture clear flag
$00002000 constant SEC_LPTIM3_ICR_INPUT_CC2OCF                      \ Capture/compare 2 over-capture clear flag
$01000000 constant SEC_LPTIM3_ICR_INPUT_DIEROKCF                    \ Interrupt enable register update OK clear flag


\
\ @brief LPTIM interrupt Enable Register (output mode)
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM3_DIER_OUTPUT_CC1IF                     \ Capture/compare 1 clear flag
$00000002 constant SEC_LPTIM3_DIER_OUTPUT_ARRMIE                    \ Autoreload match Interrupt Enable
$00000004 constant SEC_LPTIM3_DIER_OUTPUT_EXTTRIGIE                 \ External trigger valid edge Interrupt Enable
$00000008 constant SEC_LPTIM3_DIER_OUTPUT_CMP1OKIE                  \ Compare register 1 update OK Interrupt Enable
$00000010 constant SEC_LPTIM3_DIER_OUTPUT_ARROKIE                   \ Autoreload register update OK Interrupt Enable
$00000020 constant SEC_LPTIM3_DIER_OUTPUT_UPIE                      \ Direction change to UP Interrupt Enable
$00000040 constant SEC_LPTIM3_DIER_OUTPUT_DOWNIE                    \ Direction change to down Interrupt Enable
$00000080 constant SEC_LPTIM3_DIER_OUTPUT_UEIE                      \ Update event interrupt enable
$00000100 constant SEC_LPTIM3_DIER_OUTPUT_REPOKIE                   \ REPOKIE
$00000200 constant SEC_LPTIM3_DIER_OUTPUT_CC2IE                     \ Capture/compare 2 interrupt enable
$00080000 constant SEC_LPTIM3_DIER_OUTPUT_CMP2OKIE                  \ Compare register 2 update OK interrupt enable
$00800000 constant SEC_LPTIM3_DIER_OUTPUT_UEDE                      \ Update event DMA request enable


\
\ @brief LPTIM interrupt Enable Register (intput mode)
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM3_DIER_INPUT_CC1IF                      \ Capture/compare 1 clear flag
$00000002 constant SEC_LPTIM3_DIER_INPUT_ARRMIE                     \ Autoreload match Interrupt Enable
$00000004 constant SEC_LPTIM3_DIER_INPUT_EXTTRIGIE                  \ External trigger valid edge Interrupt Enable
$00000010 constant SEC_LPTIM3_DIER_INPUT_ARROKIE                    \ Autoreload register update OK Interrupt Enable
$00000020 constant SEC_LPTIM3_DIER_INPUT_UPIE                       \ Direction change to UP Interrupt Enable
$00000040 constant SEC_LPTIM3_DIER_INPUT_DOWNIE                     \ Direction change to down Interrupt Enable
$00000080 constant SEC_LPTIM3_DIER_INPUT_UEIE                       \ Update event interrupt enable
$00000100 constant SEC_LPTIM3_DIER_INPUT_REPOKIE                    \ REPOKIE
$00000200 constant SEC_LPTIM3_DIER_INPUT_CC2IE                      \ Capture/compare 2 interrupt enable
$00001000 constant SEC_LPTIM3_DIER_INPUT_CC1OIE                     \ Capture/compare 1 over-capture interrupt enable
$00002000 constant SEC_LPTIM3_DIER_INPUT_CC2OIE                     \ Capture/compare 2 over-capture interrupt enable
$00010000 constant SEC_LPTIM3_DIER_INPUT_CC1DE                      \ Capture/compare 1 DMA request enable
$02000000 constant SEC_LPTIM3_DIER_INPUT_CC2DE                      \ Capture/compare 2 DMA request enable


\
\ @brief Configuration Register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM3_CFGR_CKSEL                            \ Clock selector
$00000006 constant SEC_LPTIM3_CFGR_CKPOL                            \ Clock Polarity
$00000018 constant SEC_LPTIM3_CFGR_CKFLT                            \ Configurable digital filter for external clock
$000000c0 constant SEC_LPTIM3_CFGR_TRGFLT                           \ Configurable digital filter for trigger
$00000e00 constant SEC_LPTIM3_CFGR_PRESC                            \ Clock prescaler
$0000e000 constant SEC_LPTIM3_CFGR_TRIGSEL                          \ Trigger selector
$00060000 constant SEC_LPTIM3_CFGR_TRIGEN                           \ Trigger enable and polarity
$00080000 constant SEC_LPTIM3_CFGR_TIMOUT                           \ Timeout enable
$00100000 constant SEC_LPTIM3_CFGR_WAVE                             \ Waveform shape
$00200000 constant SEC_LPTIM3_CFGR_WAVPOL                           \ Waveform shape polarity
$00400000 constant SEC_LPTIM3_CFGR_PRELOAD                          \ Registers update mode
$00800000 constant SEC_LPTIM3_CFGR_COUNTMODE                        \ counter mode enabled
$01000000 constant SEC_LPTIM3_CFGR_ENC                              \ Encoder mode enable


\
\ @brief Control Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM3_CR_ENABLE                             \ LPTIM Enable
$00000002 constant SEC_LPTIM3_CR_SNGSTRT                            \ LPTIM start in single mode
$00000004 constant SEC_LPTIM3_CR_CNTSTRT                            \ Timer start in continuous mode
$00000008 constant SEC_LPTIM3_CR_COUNTRST                           \ Counter reset
$00000010 constant SEC_LPTIM3_CR_RSTARE                             \ Reset after read enable


\
\ @brief Compare Register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant SEC_LPTIM3_CCR1_CCR1                             \ Capture/compare 1 value


\
\ @brief Autoreload Register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$0000ffff constant SEC_LPTIM3_ARR_ARR                               \ Auto reload value


\
\ @brief Counter Register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant SEC_LPTIM3_CNT_CNT                               \ Counter value


\
\ @brief LPTIM configuration register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000003 constant SEC_LPTIM3_CFGR2_IN1SEL                          \ LPTIM input 1 selection
$00000030 constant SEC_LPTIM3_CFGR2_IN2SEL                          \ LPTIM input 2 selection
$00030000 constant SEC_LPTIM3_CFGR2_IC1SEL                          \ LPTIM input capture 1 selection
$00300000 constant SEC_LPTIM3_CFGR2_IC2SEL                          \ LPTIM input capture 2 selection


\
\ @brief LPTIM repetition register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant SEC_LPTIM3_RCR_REP                               \ Repetition register value


\
\ @brief LPTIM capture/compare mode register 1
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM3_CCMR1_CC1SEL                          \ Capture/compare 1 selection
$00000002 constant SEC_LPTIM3_CCMR1_CC1E                            \ Capture/compare 1 output enable
$0000000c constant SEC_LPTIM3_CCMR1_CC1P                            \ Capture/compare 1 output polarity
$00000300 constant SEC_LPTIM3_CCMR1_IC1PSC                          \ Input capture 1 prescaler
$00003000 constant SEC_LPTIM3_CCMR1_IC1F                            \ Input capture 1 filter
$00010000 constant SEC_LPTIM3_CCMR1_CC2SEL                          \ Capture/compare 2 selection
$00020000 constant SEC_LPTIM3_CCMR1_CC2E                            \ Capture/compare 2 output enable
$000c0000 constant SEC_LPTIM3_CCMR1_CC2P                            \ Capture/compare 2 output polarity
$03000000 constant SEC_LPTIM3_CCMR1_IC2PSC                          \ Input capture 2 prescaler
$30000000 constant SEC_LPTIM3_CCMR1_IC2F                            \ Input capture 2 filter


\
\ @brief LPTIM Compare Register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant SEC_LPTIM3_CCR2_CCR2                             \ Capture/compare 2 value


\
\ @brief Low power timer
\
$56004800 constant SEC_LPTIM3_ISR_OUTPUT  \ offset: 0x00 : Interrupt and Status Register (output mode)
$56004800 constant SEC_LPTIM3_ISR_INPUT  \ offset: 0x00 : Interrupt and Status Register (intput mode)
$56004804 constant SEC_LPTIM3_ICR_OUTPUT  \ offset: 0x04 : Interrupt Clear Register (output mode)
$56004804 constant SEC_LPTIM3_ICR_INPUT  \ offset: 0x04 : Interrupt Clear Register (intput mode)
$56004808 constant SEC_LPTIM3_DIER_OUTPUT  \ offset: 0x08 : LPTIM interrupt Enable Register (output mode)
$56004808 constant SEC_LPTIM3_DIER_INPUT  \ offset: 0x08 : LPTIM interrupt Enable Register (intput mode)
$5600480c constant SEC_LPTIM3_CFGR  \ offset: 0x0C : Configuration Register
$56004810 constant SEC_LPTIM3_CR  \ offset: 0x10 : Control Register
$56004814 constant SEC_LPTIM3_CCR1  \ offset: 0x14 : Compare Register
$56004818 constant SEC_LPTIM3_ARR  \ offset: 0x18 : Autoreload Register
$5600481c constant SEC_LPTIM3_CNT  \ offset: 0x1C : Counter Register
$56004824 constant SEC_LPTIM3_CFGR2  \ offset: 0x24 : LPTIM configuration register 2
$56004828 constant SEC_LPTIM3_RCR  \ offset: 0x28 : LPTIM repetition register
$5600482c constant SEC_LPTIM3_CCMR1  \ offset: 0x2C : LPTIM capture/compare mode register 1
$56004834 constant SEC_LPTIM3_CCR2  \ offset: 0x34 : LPTIM Compare Register 2

