\
\ @file lptimer1.fs
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

$00000001 constant LPTIMER1_ISR_CMPM                                \ Compare match
$00000002 constant LPTIMER1_ISR_ARRM                                \ Autoreload match
$00000004 constant LPTIMER1_ISR_EXTTRIG                             \ External trigger edge event
$00000008 constant LPTIMER1_ISR_CMPOK                               \ Compare register update OK
$00000010 constant LPTIMER1_ISR_ARROK                               \ Autoreload register update OK
$00000020 constant LPTIMER1_ISR_UP                                  \ Counter direction change down to up
$00000040 constant LPTIMER1_ISR_DOWN                                \ Counter direction change up to down


\
\ @brief Interrupt Clear Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LPTIMER1_ICR_CMPMCF                              \ compare match Clear Flag
$00000002 constant LPTIMER1_ICR_ARRMCF                              \ Autoreload match Clear Flag
$00000004 constant LPTIMER1_ICR_EXTTRIGCF                           \ External trigger valid edge Clear Flag
$00000008 constant LPTIMER1_ICR_CMPOKCF                             \ Compare register update OK Clear Flag
$00000010 constant LPTIMER1_ICR_ARROKCF                             \ Autoreload register update OK Clear Flag
$00000020 constant LPTIMER1_ICR_UPCF                                \ Direction change to UP Clear Flag
$00000040 constant LPTIMER1_ICR_DOWNCF                              \ Direction change to down Clear Flag


\
\ @brief Interrupt Enable Register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant LPTIMER1_IER_CMPMIE                              \ Compare match Interrupt Enable
$00000002 constant LPTIMER1_IER_ARRMIE                              \ Autoreload match Interrupt Enable
$00000004 constant LPTIMER1_IER_EXTTRIGIE                           \ External trigger valid edge Interrupt Enable
$00000008 constant LPTIMER1_IER_CMPOKIE                             \ Compare register update OK Interrupt Enable
$00000010 constant LPTIMER1_IER_ARROKIE                             \ Autoreload register update OK Interrupt Enable
$00000020 constant LPTIMER1_IER_UPIE                                \ Direction change to UP Interrupt Enable
$00000040 constant LPTIMER1_IER_DOWNIE                              \ Direction change to down Interrupt Enable


\
\ @brief Configuration Register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant LPTIMER1_CFGR_CKSEL                              \ Clock selector
$00000006 constant LPTIMER1_CFGR_CKPOL                              \ Clock Polarity
$00000018 constant LPTIMER1_CFGR_CKFLT                              \ Configurable digital filter for external clock
$000000c0 constant LPTIMER1_CFGR_TRGFLT                             \ Configurable digital filter for trigger
$00000e00 constant LPTIMER1_CFGR_PRESC                              \ Clock prescaler
$0001e000 constant LPTIMER1_CFGR_TRIGSEL                            \ Trigger selector
$00060000 constant LPTIMER1_CFGR_TRIGEN                             \ Trigger enable and polarity
$00080000 constant LPTIMER1_CFGR_TIMOUT                             \ Timeout enable
$00100000 constant LPTIMER1_CFGR_WAVE                               \ Waveform shape
$00200000 constant LPTIMER1_CFGR_WAVPOL                             \ Waveform shape polarity
$00400000 constant LPTIMER1_CFGR_PRELOAD                            \ Registers update mode
$00800000 constant LPTIMER1_CFGR_COUNTMODE                          \ counter mode enabled
$01000000 constant LPTIMER1_CFGR_ENC                                \ Encoder mode enable


\
\ @brief Control Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant LPTIMER1_CR_ENABLE                               \ LPTIM Enable
$00000002 constant LPTIMER1_CR_SNGSTRT                              \ LPTIM start in single mode
$00000004 constant LPTIMER1_CR_CNTSTRT                              \ Timer start in continuous mode
$00000008 constant LPTIMER1_CR_COUNTRST                             \ COUNTRST
$00000010 constant LPTIMER1_CR_RSTARE                               \ RSTARE


\
\ @brief Compare Register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant LPTIMER1_CMP_CMP                                 \ Compare value


\
\ @brief Autoreload Register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$0000ffff constant LPTIMER1_ARR_ARR                                 \ Auto reload value


\
\ @brief Counter Register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant LPTIMER1_CNT_CNT                                 \ Counter value


\
\ @brief option register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant LPTIMER1_OR_IN1                                  \ IN1
$00000002 constant LPTIMER1_OR_IN2                                  \ IN2
$0000000c constant LPTIMER1_OR_IN1_2_1                              \ IN1_2_1
$00000030 constant LPTIMER1_OR_IN2_2_1                              \ IN2_2_1


\
\ @brief Low power timer
\
$40007c00 constant LPTIMER1_ISR   \ offset: 0x00 : Interrupt and Status Register
$40007c04 constant LPTIMER1_ICR   \ offset: 0x04 : Interrupt Clear Register
$40007c08 constant LPTIMER1_IER   \ offset: 0x08 : Interrupt Enable Register
$40007c0c constant LPTIMER1_CFGR  \ offset: 0x0C : Configuration Register
$40007c10 constant LPTIMER1_CR    \ offset: 0x10 : Control Register
$40007c14 constant LPTIMER1_CMP   \ offset: 0x14 : Compare Register
$40007c18 constant LPTIMER1_ARR   \ offset: 0x18 : Autoreload Register
$40007c1c constant LPTIMER1_CNT   \ offset: 0x1C : Counter Register
$40007c20 constant LPTIMER1_OR    \ offset: 0x20 : option register

