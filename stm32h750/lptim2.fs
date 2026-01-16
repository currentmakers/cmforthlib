\
\ @file lptim2.fs
\ @brief LPTIM2 timer interrupt
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

$00000001 constant LPTIM2_ISR_CMPM                                  \ Compare match
$00000002 constant LPTIM2_ISR_ARRM                                  \ Autoreload match
$00000004 constant LPTIM2_ISR_EXTTRIG                               \ External trigger edge event
$00000008 constant LPTIM2_ISR_CMPOK                                 \ Compare register update OK
$00000010 constant LPTIM2_ISR_ARROK                                 \ Autoreload register update OK
$00000020 constant LPTIM2_ISR_UP                                    \ Counter direction change down to up
$00000040 constant LPTIM2_ISR_DOWN                                  \ Counter direction change up to down


\
\ @brief Interrupt Clear Register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LPTIM2_ICR_CMPMCF                                \ compare match Clear Flag
$00000002 constant LPTIM2_ICR_ARRMCF                                \ Autoreload match Clear Flag
$00000004 constant LPTIM2_ICR_EXTTRIGCF                             \ External trigger valid edge Clear Flag
$00000008 constant LPTIM2_ICR_CMPOKCF                               \ Compare register update OK Clear Flag
$00000010 constant LPTIM2_ICR_ARROKCF                               \ Autoreload register update OK Clear Flag
$00000020 constant LPTIM2_ICR_UPCF                                  \ Direction change to UP Clear Flag
$00000040 constant LPTIM2_ICR_DOWNCF                                \ Direction change to down Clear Flag


\
\ @brief Interrupt Enable Register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant LPTIM2_IER_CMPMIE                                \ Compare match Interrupt Enable
$00000002 constant LPTIM2_IER_ARRMIE                                \ Autoreload match Interrupt Enable
$00000004 constant LPTIM2_IER_EXTTRIGIE                             \ External trigger valid edge Interrupt Enable
$00000008 constant LPTIM2_IER_CMPOKIE                               \ Compare register update OK Interrupt Enable
$00000010 constant LPTIM2_IER_ARROKIE                               \ Autoreload register update OK Interrupt Enable
$00000020 constant LPTIM2_IER_UPIE                                  \ Direction change to UP Interrupt Enable
$00000040 constant LPTIM2_IER_DOWNIE                                \ Direction change to down Interrupt Enable


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

$0000ffff constant LPTIM2_CMP_CMP                                   \ Compare value


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

$00000003 constant LPTIM2_LPTIM_CFGR2_IN1SEL                        \ LPTIM Input 1 selection
$00000030 constant LPTIM2_LPTIM_CFGR2_IN2SEL                        \ LPTIM Input 2 selection


\
\ @brief LPTIM2 timer interrupt
\
$58002400 constant LPTIM2_ISR     \ offset: 0x00 : Interrupt and Status Register
$58002404 constant LPTIM2_ICR     \ offset: 0x04 : Interrupt Clear Register
$58002408 constant LPTIM2_IER     \ offset: 0x08 : Interrupt Enable Register
$5800240c constant LPTIM2_CFGR    \ offset: 0x0C : Configuration Register
$58002410 constant LPTIM2_CR      \ offset: 0x10 : Control Register
$58002414 constant LPTIM2_CMP     \ offset: 0x14 : Compare Register
$58002418 constant LPTIM2_ARR     \ offset: 0x18 : Autoreload Register
$5800241c constant LPTIM2_CNT     \ offset: 0x1C : Counter Register
$58002424 constant LPTIM2_LPTIM_CFGR2  \ offset: 0x24 : LPTIM configuration register 2

