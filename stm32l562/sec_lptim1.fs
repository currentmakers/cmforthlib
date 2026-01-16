\
\ @file sec_lptim1.fs
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

$00000001 constant SEC_LPTIM1_ISR_CMPM                              \ Compare match
$00000002 constant SEC_LPTIM1_ISR_ARRM                              \ Autoreload match
$00000004 constant SEC_LPTIM1_ISR_EXTTRIG                           \ External trigger edge event
$00000008 constant SEC_LPTIM1_ISR_CMPOK                             \ Compare register update OK
$00000010 constant SEC_LPTIM1_ISR_ARROK                             \ Autoreload register update OK
$00000020 constant SEC_LPTIM1_ISR_UP                                \ Counter direction change down to up
$00000040 constant SEC_LPTIM1_ISR_DOWN                              \ Counter direction change up to down
$00000080 constant SEC_LPTIM1_ISR_UE                                \ LPTIM update event occurred
$00000100 constant SEC_LPTIM1_ISR_REPOK                             \ Repetition register update Ok


\
\ @brief Interrupt Clear Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM1_ICR_CMPMCF                            \ compare match Clear Flag
$00000002 constant SEC_LPTIM1_ICR_ARRMCF                            \ Autoreload match Clear Flag
$00000004 constant SEC_LPTIM1_ICR_EXTTRIGCF                         \ External trigger valid edge Clear Flag
$00000008 constant SEC_LPTIM1_ICR_CMPOKCF                           \ Compare register update OK Clear Flag
$00000010 constant SEC_LPTIM1_ICR_ARROKCF                           \ Autoreload register update OK Clear Flag
$00000020 constant SEC_LPTIM1_ICR_UPCF                              \ Direction change to UP Clear Flag
$00000040 constant SEC_LPTIM1_ICR_DOWNCF                            \ Direction change to down Clear Flag
$00000080 constant SEC_LPTIM1_ICR_UECF                              \ Update event clear flag
$00000100 constant SEC_LPTIM1_ICR_REPOKCF                           \ Repetition register update OK clear flag


\
\ @brief Interrupt Enable Register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM1_IER_CMPMIE                            \ Compare match Interrupt Enable
$00000002 constant SEC_LPTIM1_IER_ARRMIE                            \ Autoreload match Interrupt Enable
$00000004 constant SEC_LPTIM1_IER_EXTTRIGIE                         \ External trigger valid edge Interrupt Enable
$00000008 constant SEC_LPTIM1_IER_CMPOKIE                           \ Compare register update OK Interrupt Enable
$00000010 constant SEC_LPTIM1_IER_ARROKIE                           \ Autoreload register update OK Interrupt Enable
$00000020 constant SEC_LPTIM1_IER_UPIE                              \ Direction change to UP Interrupt Enable
$00000040 constant SEC_LPTIM1_IER_DOWNIE                            \ Direction change to down Interrupt Enable
$00000080 constant SEC_LPTIM1_IER_UEIE                              \ Update event interrupt enable
$00000100 constant SEC_LPTIM1_IER_REPOKIE                           \ REPOKIE


\
\ @brief Configuration Register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM1_CFGR_CKSEL                            \ Clock selector
$00000006 constant SEC_LPTIM1_CFGR_CKPOL                            \ Clock Polarity
$00000018 constant SEC_LPTIM1_CFGR_CKFLT                            \ Configurable digital filter for external clock
$000000c0 constant SEC_LPTIM1_CFGR_TRGFLT                           \ Configurable digital filter for trigger
$00000e00 constant SEC_LPTIM1_CFGR_PRESC                            \ Clock prescaler
$0000e000 constant SEC_LPTIM1_CFGR_TRIGSEL                          \ Trigger selector
$00060000 constant SEC_LPTIM1_CFGR_TRIGEN                           \ Trigger enable and polarity
$00080000 constant SEC_LPTIM1_CFGR_TIMOUT                           \ Timeout enable
$00100000 constant SEC_LPTIM1_CFGR_WAVE                             \ Waveform shape
$00200000 constant SEC_LPTIM1_CFGR_WAVPOL                           \ Waveform shape polarity
$00400000 constant SEC_LPTIM1_CFGR_PRELOAD                          \ Registers update mode
$00800000 constant SEC_LPTIM1_CFGR_COUNTMODE                        \ counter mode enabled
$01000000 constant SEC_LPTIM1_CFGR_ENC                              \ Encoder mode enable


\
\ @brief Control Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM1_CR_ENABLE                             \ LPTIM Enable
$00000002 constant SEC_LPTIM1_CR_SNGSTRT                            \ LPTIM start in single mode
$00000004 constant SEC_LPTIM1_CR_CNTSTRT                            \ Timer start in continuous mode
$00000008 constant SEC_LPTIM1_CR_RSTARE                             \ Reset after read enable
$00000010 constant SEC_LPTIM1_CR_COUNTRST                           \ Counter reset


\
\ @brief Compare Register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant SEC_LPTIM1_CMP_CMP                               \ Compare value


\
\ @brief Autoreload Register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$0000ffff constant SEC_LPTIM1_ARR_ARR                               \ Auto reload value


\
\ @brief Counter Register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant SEC_LPTIM1_CNT_CNT                               \ Counter value


\
\ @brief LPTIM option register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM1_OR_OR_0                               \ Option register bit 0
$00000002 constant SEC_LPTIM1_OR_OR_1                               \ Option register bit 1


\
\ @brief LPTIM repetition register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant SEC_LPTIM1_RCR_REP                               \ Repetition register value


\
\ @brief Low power timer
\
$50007c00 constant SEC_LPTIM1_ISR  \ offset: 0x00 : Interrupt and Status Register
$50007c04 constant SEC_LPTIM1_ICR  \ offset: 0x04 : Interrupt Clear Register
$50007c08 constant SEC_LPTIM1_IER  \ offset: 0x08 : Interrupt Enable Register
$50007c0c constant SEC_LPTIM1_CFGR  \ offset: 0x0C : Configuration Register
$50007c10 constant SEC_LPTIM1_CR  \ offset: 0x10 : Control Register
$50007c14 constant SEC_LPTIM1_CMP  \ offset: 0x14 : Compare Register
$50007c18 constant SEC_LPTIM1_ARR  \ offset: 0x18 : Autoreload Register
$50007c1c constant SEC_LPTIM1_CNT  \ offset: 0x1C : Counter Register
$50007c20 constant SEC_LPTIM1_OR  \ offset: 0x20 : LPTIM option register
$50007c28 constant SEC_LPTIM1_RCR  \ offset: 0x28 : LPTIM repetition register

