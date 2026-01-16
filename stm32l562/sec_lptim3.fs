\
\ @file sec_lptim3.fs
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

$00000001 constant SEC_LPTIM3_ISR_CMPM                              \ Compare match
$00000002 constant SEC_LPTIM3_ISR_ARRM                              \ Autoreload match
$00000004 constant SEC_LPTIM3_ISR_EXTTRIG                           \ External trigger edge event
$00000008 constant SEC_LPTIM3_ISR_CMPOK                             \ Compare register update OK
$00000010 constant SEC_LPTIM3_ISR_ARROK                             \ Autoreload register update OK
$00000020 constant SEC_LPTIM3_ISR_UP                                \ Counter direction change down to up
$00000040 constant SEC_LPTIM3_ISR_DOWN                              \ Counter direction change up to down
$00000080 constant SEC_LPTIM3_ISR_UE                                \ LPTIM update event occurred
$00000100 constant SEC_LPTIM3_ISR_REPOK                             \ Repetition register update Ok


\
\ @brief Interrupt Clear Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM3_ICR_CMPMCF                            \ compare match Clear Flag
$00000002 constant SEC_LPTIM3_ICR_ARRMCF                            \ Autoreload match Clear Flag
$00000004 constant SEC_LPTIM3_ICR_EXTTRIGCF                         \ External trigger valid edge Clear Flag
$00000008 constant SEC_LPTIM3_ICR_CMPOKCF                           \ Compare register update OK Clear Flag
$00000010 constant SEC_LPTIM3_ICR_ARROKCF                           \ Autoreload register update OK Clear Flag
$00000020 constant SEC_LPTIM3_ICR_UPCF                              \ Direction change to UP Clear Flag
$00000040 constant SEC_LPTIM3_ICR_DOWNCF                            \ Direction change to down Clear Flag
$00000080 constant SEC_LPTIM3_ICR_UECF                              \ Update event clear flag
$00000100 constant SEC_LPTIM3_ICR_REPOKCF                           \ Repetition register update OK clear flag


\
\ @brief Interrupt Enable Register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM3_IER_CMPMIE                            \ Compare match Interrupt Enable
$00000002 constant SEC_LPTIM3_IER_ARRMIE                            \ Autoreload match Interrupt Enable
$00000004 constant SEC_LPTIM3_IER_EXTTRIGIE                         \ External trigger valid edge Interrupt Enable
$00000008 constant SEC_LPTIM3_IER_CMPOKIE                           \ Compare register update OK Interrupt Enable
$00000010 constant SEC_LPTIM3_IER_ARROKIE                           \ Autoreload register update OK Interrupt Enable
$00000020 constant SEC_LPTIM3_IER_UPIE                              \ Direction change to UP Interrupt Enable
$00000040 constant SEC_LPTIM3_IER_DOWNIE                            \ Direction change to down Interrupt Enable
$00000080 constant SEC_LPTIM3_IER_UEIE                              \ Update event interrupt enable
$00000100 constant SEC_LPTIM3_IER_REPOKIE                           \ REPOKIE


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
$00000008 constant SEC_LPTIM3_CR_RSTARE                             \ Reset after read enable
$00000010 constant SEC_LPTIM3_CR_COUNTRST                           \ Counter reset


\
\ @brief Compare Register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant SEC_LPTIM3_CMP_CMP                               \ Compare value


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
\ @brief LPTIM option register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SEC_LPTIM3_OR_OR_0                               \ Option register bit 0
$00000002 constant SEC_LPTIM3_OR_OR_1                               \ Option register bit 1


\
\ @brief LPTIM repetition register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant SEC_LPTIM3_RCR_REP                               \ Repetition register value


\
\ @brief Low power timer
\
$50009800 constant SEC_LPTIM3_ISR  \ offset: 0x00 : Interrupt and Status Register
$50009804 constant SEC_LPTIM3_ICR  \ offset: 0x04 : Interrupt Clear Register
$50009808 constant SEC_LPTIM3_IER  \ offset: 0x08 : Interrupt Enable Register
$5000980c constant SEC_LPTIM3_CFGR  \ offset: 0x0C : Configuration Register
$50009810 constant SEC_LPTIM3_CR  \ offset: 0x10 : Control Register
$50009814 constant SEC_LPTIM3_CMP  \ offset: 0x14 : Compare Register
$50009818 constant SEC_LPTIM3_ARR  \ offset: 0x18 : Autoreload Register
$5000981c constant SEC_LPTIM3_CNT  \ offset: 0x1C : Counter Register
$50009820 constant SEC_LPTIM3_OR  \ offset: 0x20 : LPTIM option register
$50009828 constant SEC_LPTIM3_RCR  \ offset: 0x28 : LPTIM repetition register

