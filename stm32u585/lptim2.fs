\
\ @file lptim2.fs
\ @brief LPTIM2 global interrupt
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

$00000001 constant LPTIM2_ISR_OUTPUT_CC1IF                          \ Compare 1 interrupt flag
$00000002 constant LPTIM2_ISR_OUTPUT_ARRM                           \ Autoreload match
$00000004 constant LPTIM2_ISR_OUTPUT_EXTTRIG                        \ External trigger edge event
$00000008 constant LPTIM2_ISR_OUTPUT_CMP1OK                         \ Compare register 1 update OK
$00000010 constant LPTIM2_ISR_OUTPUT_ARROK                          \ Autoreload register update OK
$00000020 constant LPTIM2_ISR_OUTPUT_UP                             \ Counter direction change down to up
$00000040 constant LPTIM2_ISR_OUTPUT_DOWN                           \ Counter direction change up to down
$00000080 constant LPTIM2_ISR_OUTPUT_UE                             \ LPTIM update event occurred
$00000100 constant LPTIM2_ISR_OUTPUT_REPOK                          \ Repetition register update Ok
$00000200 constant LPTIM2_ISR_OUTPUT_CC2IF                          \ Compare 2 interrupt flag
$00080000 constant LPTIM2_ISR_OUTPUT_CMP2OK                         \ Compare register 2 update OK
$01000000 constant LPTIM2_ISR_OUTPUT_DIEROK                         \ Interrupt enable register update OK


\
\ @brief Interrupt and Status Register (intput mode)
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LPTIM2_ISR_INPUT_CC1IF                           \ Compare 1 interrupt flag
$00000002 constant LPTIM2_ISR_INPUT_ARRM                            \ Autoreload match
$00000004 constant LPTIM2_ISR_INPUT_EXTTRIG                         \ External trigger edge event
$00000010 constant LPTIM2_ISR_INPUT_ARROK                           \ Autoreload register update OK
$00000020 constant LPTIM2_ISR_INPUT_UP                              \ Counter direction change down to up
$00000040 constant LPTIM2_ISR_INPUT_DOWN                            \ Counter direction change up to down
$00000080 constant LPTIM2_ISR_INPUT_UE                              \ LPTIM update event occurred
$00000100 constant LPTIM2_ISR_INPUT_REPOK                           \ Repetition register update Ok
$00000200 constant LPTIM2_ISR_INPUT_CC2IF                           \ Capture 2 interrupt flag
$00001000 constant LPTIM2_ISR_INPUT_CC1OF                           \ Capture 1 over-capture flag
$00002000 constant LPTIM2_ISR_INPUT_CC2OF                           \ Capture 2 over-capture flag
$01000000 constant LPTIM2_ISR_INPUT_DIEROK                          \ Interrupt enable register update OK


\
\ @brief Interrupt Clear Register (output mode)
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LPTIM2_ICR_OUTPUT_CC1IF                          \ Capture/compare 1 clear flag
$00000002 constant LPTIM2_ICR_OUTPUT_ARRMCF                         \ Autoreload match Clear Flag
$00000004 constant LPTIM2_ICR_OUTPUT_EXTTRIGCF                      \ External trigger valid edge Clear Flag
$00000008 constant LPTIM2_ICR_OUTPUT_CMP1OKCF                       \ Compare register 1 update OK Clear Flag
$00000010 constant LPTIM2_ICR_OUTPUT_ARROKCF                        \ Autoreload register update OK Clear Flag
$00000020 constant LPTIM2_ICR_OUTPUT_UPCF                           \ Direction change to UP Clear Flag
$00000040 constant LPTIM2_ICR_OUTPUT_DOWNCF                         \ Direction change to down Clear Flag
$00000080 constant LPTIM2_ICR_OUTPUT_UECF                           \ Update event clear flag
$00000100 constant LPTIM2_ICR_OUTPUT_REPOKCF                        \ Repetition register update OK clear flag
$00000200 constant LPTIM2_ICR_OUTPUT_CC2CF                          \ Capture/compare 2 clear flag
$00080000 constant LPTIM2_ICR_OUTPUT_CMP2OKCF                       \ Compare register 2 update OK clear flag
$01000000 constant LPTIM2_ICR_OUTPUT_DIEROKCF                       \ Interrupt enable register update OK clear flag


\
\ @brief Interrupt Clear Register (intput mode)
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LPTIM2_ICR_INPUT_CC1IF                           \ Capture/compare 1 clear flag
$00000002 constant LPTIM2_ICR_INPUT_ARRMCF                          \ Autoreload match Clear Flag
$00000004 constant LPTIM2_ICR_INPUT_EXTTRIGCF                       \ External trigger valid edge Clear Flag
$00000010 constant LPTIM2_ICR_INPUT_ARROKCF                         \ Autoreload register update OK Clear Flag
$00000020 constant LPTIM2_ICR_INPUT_UPCF                            \ Direction change to UP Clear Flag
$00000040 constant LPTIM2_ICR_INPUT_DOWNCF                          \ Direction change to down Clear Flag
$00000080 constant LPTIM2_ICR_INPUT_UECF                            \ Update event clear flag
$00000100 constant LPTIM2_ICR_INPUT_REPOKCF                         \ Repetition register update OK clear flag
$00000200 constant LPTIM2_ICR_INPUT_CC2CF                           \ Capture/compare 2 clear flag
$00001000 constant LPTIM2_ICR_INPUT_CC1OCF                          \ Capture/compare 1 over-capture clear flag
$00002000 constant LPTIM2_ICR_INPUT_CC2OCF                          \ Capture/compare 2 over-capture clear flag
$01000000 constant LPTIM2_ICR_INPUT_DIEROKCF                        \ Interrupt enable register update OK clear flag


\
\ @brief LPTIM interrupt Enable Register (output mode)
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant LPTIM2_DIER_OUTPUT_CC1IF                         \ Capture/compare 1 clear flag
$00000002 constant LPTIM2_DIER_OUTPUT_ARRMIE                        \ Autoreload match Interrupt Enable
$00000004 constant LPTIM2_DIER_OUTPUT_EXTTRIGIE                     \ External trigger valid edge Interrupt Enable
$00000008 constant LPTIM2_DIER_OUTPUT_CMP1OKIE                      \ Compare register 1 update OK Interrupt Enable
$00000010 constant LPTIM2_DIER_OUTPUT_ARROKIE                       \ Autoreload register update OK Interrupt Enable
$00000020 constant LPTIM2_DIER_OUTPUT_UPIE                          \ Direction change to UP Interrupt Enable
$00000040 constant LPTIM2_DIER_OUTPUT_DOWNIE                        \ Direction change to down Interrupt Enable
$00000080 constant LPTIM2_DIER_OUTPUT_UEIE                          \ Update event interrupt enable
$00000100 constant LPTIM2_DIER_OUTPUT_REPOKIE                       \ REPOKIE
$00000200 constant LPTIM2_DIER_OUTPUT_CC2IE                         \ Capture/compare 2 interrupt enable
$00080000 constant LPTIM2_DIER_OUTPUT_CMP2OKIE                      \ Compare register 2 update OK interrupt enable
$00800000 constant LPTIM2_DIER_OUTPUT_UEDE                          \ Update event DMA request enable


\
\ @brief LPTIM interrupt Enable Register (intput mode)
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant LPTIM2_DIER_INPUT_CC1IF                          \ Capture/compare 1 clear flag
$00000002 constant LPTIM2_DIER_INPUT_ARRMIE                         \ Autoreload match Interrupt Enable
$00000004 constant LPTIM2_DIER_INPUT_EXTTRIGIE                      \ External trigger valid edge Interrupt Enable
$00000010 constant LPTIM2_DIER_INPUT_ARROKIE                        \ Autoreload register update OK Interrupt Enable
$00000020 constant LPTIM2_DIER_INPUT_UPIE                           \ Direction change to UP Interrupt Enable
$00000040 constant LPTIM2_DIER_INPUT_DOWNIE                         \ Direction change to down Interrupt Enable
$00000080 constant LPTIM2_DIER_INPUT_UEIE                           \ Update event interrupt enable
$00000100 constant LPTIM2_DIER_INPUT_REPOKIE                        \ REPOKIE
$00000200 constant LPTIM2_DIER_INPUT_CC2IE                          \ Capture/compare 2 interrupt enable
$00001000 constant LPTIM2_DIER_INPUT_CC1OIE                         \ Capture/compare 1 over-capture interrupt enable
$00002000 constant LPTIM2_DIER_INPUT_CC2OIE                         \ Capture/compare 2 over-capture interrupt enable
$00010000 constant LPTIM2_DIER_INPUT_CC1DE                          \ Capture/compare 1 DMA request enable
$02000000 constant LPTIM2_DIER_INPUT_CC2DE                          \ Capture/compare 2 DMA request enable


\
\ @brief Configuration Register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant LPTIM2_CFGR_CKSEL                                \ Clock selector
$00000006 constant LPTIM2_CFGR_CKPOL                                \ Clock Polarity
$00000018 constant LPTIM2_CFGR_CKFLT                                \ Configurable digital filter for external clock
$000000c0 constant LPTIM2_CFGR_TRGFLT                               \ Configurable digital filter for trigger
$00000e00 constant LPTIM2_CFGR_PRESC                                \ Clock prescaler
$0000e000 constant LPTIM2_CFGR_TRIGSEL                              \ Trigger selector
$00060000 constant LPTIM2_CFGR_TRIGEN                               \ Trigger enable and polarity
$00080000 constant LPTIM2_CFGR_TIMOUT                               \ Timeout enable
$00100000 constant LPTIM2_CFGR_WAVE                                 \ Waveform shape
$00200000 constant LPTIM2_CFGR_WAVPOL                               \ Waveform shape polarity
$00400000 constant LPTIM2_CFGR_PRELOAD                              \ Registers update mode
$00800000 constant LPTIM2_CFGR_COUNTMODE                            \ counter mode enabled
$01000000 constant LPTIM2_CFGR_ENC                                  \ Encoder mode enable


\
\ @brief Control Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant LPTIM2_CR_ENABLE                                 \ LPTIM Enable
$00000002 constant LPTIM2_CR_SNGSTRT                                \ LPTIM start in single mode
$00000004 constant LPTIM2_CR_CNTSTRT                                \ Timer start in continuous mode
$00000008 constant LPTIM2_CR_COUNTRST                               \ Counter reset
$00000010 constant LPTIM2_CR_RSTARE                                 \ Reset after read enable


\
\ @brief Compare Register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM2_CCR1_CCR1                                 \ Capture/compare 1 value


\
\ @brief Autoreload Register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$0000ffff constant LPTIM2_ARR_ARR                                   \ Auto reload value


\
\ @brief Counter Register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM2_CNT_CNT                                   \ Counter value


\
\ @brief LPTIM configuration register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000003 constant LPTIM2_CFGR2_IN1SEL                              \ LPTIM input 1 selection
$00000030 constant LPTIM2_CFGR2_IN2SEL                              \ LPTIM input 2 selection
$00030000 constant LPTIM2_CFGR2_IC1SEL                              \ LPTIM input capture 1 selection
$00300000 constant LPTIM2_CFGR2_IC2SEL                              \ LPTIM input capture 2 selection


\
\ @brief LPTIM repetition register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant LPTIM2_RCR_REP                                   \ Repetition register value


\
\ @brief LPTIM capture/compare mode register 1
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant LPTIM2_CCMR1_CC1SEL                              \ Capture/compare 1 selection
$00000002 constant LPTIM2_CCMR1_CC1E                                \ Capture/compare 1 output enable
$0000000c constant LPTIM2_CCMR1_CC1P                                \ Capture/compare 1 output polarity
$00000300 constant LPTIM2_CCMR1_IC1PSC                              \ Input capture 1 prescaler
$00003000 constant LPTIM2_CCMR1_IC1F                                \ Input capture 1 filter
$00010000 constant LPTIM2_CCMR1_CC2SEL                              \ Capture/compare 2 selection
$00020000 constant LPTIM2_CCMR1_CC2E                                \ Capture/compare 2 output enable
$000c0000 constant LPTIM2_CCMR1_CC2P                                \ Capture/compare 2 output polarity
$03000000 constant LPTIM2_CCMR1_IC2PSC                              \ Input capture 2 prescaler
$30000000 constant LPTIM2_CCMR1_IC2F                                \ Input capture 2 filter


\
\ @brief LPTIM Compare Register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM2_CCR2_CCR2                                 \ Capture/compare 2 value


\
\ @brief LPTIM peripheral hardware configuration register 2
\ Address offset: 0x3EC
\ Reset value: 0x00000000
\

$0000000f constant LPTIM2_HWCFGR2_CFG1                              \ peripheral hardware configuration 1
$0000ff00 constant LPTIM2_HWCFGR2_CFG2                              \ peripheral hardware configuration 2
$00010000 constant LPTIM2_HWCFGR2_CFG3                              \ peripheral hardware configuration 3


\
\ @brief LPTIM peripheral hardware configuration register 1
\ Address offset: 0x3F0
\ Reset value: 0x00000000
\

$000000ff constant LPTIM2_HWCFGR1_CFG1                              \ peripheral hardware configuration 1
$0000ff00 constant LPTIM2_HWCFGR1_CFG2                              \ peripheral hardware configuration 2
$000f0000 constant LPTIM2_HWCFGR1_CFG3                              \ peripheral hardware configuration 3
$ff000000 constant LPTIM2_HWCFGR1_CFG4                              \ peripheral hardware configuration 4


\
\ @brief LPTIM2 global interrupt
\
$40009400 constant LPTIM2_ISR_OUTPUT  \ offset: 0x00 : Interrupt and Status Register (output mode)
$40009400 constant LPTIM2_ISR_INPUT  \ offset: 0x00 : Interrupt and Status Register (intput mode)
$40009404 constant LPTIM2_ICR_OUTPUT  \ offset: 0x04 : Interrupt Clear Register (output mode)
$40009404 constant LPTIM2_ICR_INPUT  \ offset: 0x04 : Interrupt Clear Register (intput mode)
$40009408 constant LPTIM2_DIER_OUTPUT  \ offset: 0x08 : LPTIM interrupt Enable Register (output mode)
$40009408 constant LPTIM2_DIER_INPUT  \ offset: 0x08 : LPTIM interrupt Enable Register (intput mode)
$4000940c constant LPTIM2_CFGR    \ offset: 0x0C : Configuration Register
$40009410 constant LPTIM2_CR      \ offset: 0x10 : Control Register
$40009414 constant LPTIM2_CCR1    \ offset: 0x14 : Compare Register
$40009418 constant LPTIM2_ARR     \ offset: 0x18 : Autoreload Register
$4000941c constant LPTIM2_CNT     \ offset: 0x1C : Counter Register
$40009424 constant LPTIM2_CFGR2   \ offset: 0x24 : LPTIM configuration register 2
$40009428 constant LPTIM2_RCR     \ offset: 0x28 : LPTIM repetition register
$4000942c constant LPTIM2_CCMR1   \ offset: 0x2C : LPTIM capture/compare mode register 1
$40009434 constant LPTIM2_CCR2    \ offset: 0x34 : LPTIM Compare Register 2
$400097ec constant LPTIM2_HWCFGR2  \ offset: 0x3EC : LPTIM peripheral hardware configuration register 2
$400097f0 constant LPTIM2_HWCFGR1  \ offset: 0x3F0 : LPTIM peripheral hardware configuration register 1

