\
\ @file lptim3.fs
\ @brief Low-power timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief interrupt and status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LPTIM3_ISR_CMPM                                  \ Compare match
$00000002 constant LPTIM3_ISR_ARRM                                  \ Autoreload match
$00000004 constant LPTIM3_ISR_EXTTRIG                               \ External trigger edge event
$00000008 constant LPTIM3_ISR_CMPOK                                 \ Compare register update OK
$00000010 constant LPTIM3_ISR_ARROK                                 \ Autoreload register update OK
$00000020 constant LPTIM3_ISR_UP                                    \ Counter direction change down to up
$00000040 constant LPTIM3_ISR_DOWN                                  \ Counter direction change up to down
$00000080 constant LPTIM3_ISR_UE                                    \ LPTIM update event occurred
$00000100 constant LPTIM3_ISR_REPOK                                 \ Repetition register update Ok


\
\ @brief interrupt clear register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LPTIM3_ICR_CMPMCF                                \ compare match Clear Flag
$00000002 constant LPTIM3_ICR_ARRMCF                                \ Autoreload match Clear Flag
$00000004 constant LPTIM3_ICR_EXTTRIGCF                             \ External trigger valid edge Clear Flag
$00000008 constant LPTIM3_ICR_CMPOKCF                               \ Compare register update OK Clear Flag
$00000010 constant LPTIM3_ICR_ARROKCF                               \ Autoreload register update OK Clear Flag
$00000020 constant LPTIM3_ICR_UPCF                                  \ Direction change to UP Clear Flag
$00000040 constant LPTIM3_ICR_DOWNCF                                \ Direction change to down Clear Flag
$00000080 constant LPTIM3_ICR_UECF                                  \ Update event clear flag
$00000100 constant LPTIM3_ICR_REPOKCF                               \ Repetition register update OK clear flag


\
\ @brief interrupt enable register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant LPTIM3_IER_CMPMIE                                \ Compare match Interrupt Enable
$00000002 constant LPTIM3_IER_ARRMIE                                \ Autoreload match Interrupt Enable
$00000004 constant LPTIM3_IER_EXTTRIGIE                             \ External trigger valid edge Interrupt Enable
$00000008 constant LPTIM3_IER_CMPOKIE                               \ Compare register update OK Interrupt Enable
$00000010 constant LPTIM3_IER_ARROKIE                               \ Autoreload register update OK Interrupt Enable
$00000020 constant LPTIM3_IER_UPIE                                  \ Direction change to UP Interrupt Enable
$00000040 constant LPTIM3_IER_DOWNIE                                \ Direction change to down Interrupt Enable
$00000080 constant LPTIM3_IER_UEIE                                  \ Update event interrupt enable
$00000100 constant LPTIM3_IER_REPOKIE                               \ Repetition register update OK interrupt Enable


\
\ @brief configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant LPTIM3_CFGR_CKSEL                                \ CKSEL
$00000006 constant LPTIM3_CFGR_CKPOL                                \ CKPOL
$00000018 constant LPTIM3_CFGR_CKFLT                                \ CKFLT
$000000c0 constant LPTIM3_CFGR_TRGFLT                               \ TRGFLT
$00000e00 constant LPTIM3_CFGR_PRESC                                \ PRESC
$0000e000 constant LPTIM3_CFGR_TRIGSEL                              \ TRIGSEL
$00060000 constant LPTIM3_CFGR_TRIGEN                               \ TRIGEN
$00080000 constant LPTIM3_CFGR_TIMOUT                               \ TIMOUT
$00100000 constant LPTIM3_CFGR_WAVE                                 \ WAVE
$00200000 constant LPTIM3_CFGR_WAVPOL                               \ WAVPOL
$00400000 constant LPTIM3_CFGR_PRELOAD                              \ PRELOAD
$00800000 constant LPTIM3_CFGR_COUNTMODE                            \ COUNTMODE
$01000000 constant LPTIM3_CFGR_ENC                                  \ ENC


\
\ @brief control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant LPTIM3_CR_ENABLE                                 \ ENABLE
$00000002 constant LPTIM3_CR_SNGSTRT                                \ SNGSTRT
$00000004 constant LPTIM3_CR_CNTSTRT                                \ CNTSTRT
$00000008 constant LPTIM3_CR_COUNTRST                               \ COUNTRST
$00000010 constant LPTIM3_CR_RSTARE                                 \ RSTARE


\
\ @brief compare register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM3_CMP_CMP                                   \ CMP


\
\ @brief autoreload register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$0000ffff constant LPTIM3_ARR_ARR                                   \ Auto reload value


\
\ @brief counter register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM3_CNT_CNT                                   \ Counter value


\
\ @brief option register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant LPTIM3_LPTIM3_OR_OR_0                            \ Option register bit 0
$00000002 constant LPTIM3_LPTIM3_OR_OR_1                            \ Option register bit 1


\
\ @brief repetition register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant LPTIM3_RCR_REP                                   \ Repetition register value


\
\ @brief Low-power timer
\
$40009800 constant LPTIM3_ISR     \ offset: 0x00 : interrupt and status register
$40009804 constant LPTIM3_ICR     \ offset: 0x04 : interrupt clear register
$40009808 constant LPTIM3_IER     \ offset: 0x08 : interrupt enable register
$4000980c constant LPTIM3_CFGR    \ offset: 0x0C : configuration register
$40009810 constant LPTIM3_CR      \ offset: 0x10 : control register
$40009814 constant LPTIM3_CMP     \ offset: 0x14 : compare register
$40009818 constant LPTIM3_ARR     \ offset: 0x18 : autoreload register
$4000981c constant LPTIM3_CNT     \ offset: 0x1C : counter register
$40009820 constant LPTIM3_LPTIM3_OR  \ offset: 0x20 : option register
$40009828 constant LPTIM3_RCR     \ offset: 0x28 : repetition register

