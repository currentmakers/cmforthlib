\
\ @file exti.fs
\ @brief External interrupt/event       controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief rising trigger selection register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$003fffff constant EXTI_RTSR1_RT                                    \ Rising trigger event configuration bit of Configurable Event input
$80000000 constant EXTI_RTSR1_RT_31                                 \ Rising trigger event configuration bit of Configurable Event input


\
\ @brief falling trigger selection register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$003fffff constant EXTI_FTSR1_FT                                    \ Falling trigger event configuration bit of Configurable Event input
$80000000 constant EXTI_FTSR1_FT_31                                 \ Falling trigger event configuration bit of Configurable Event input


\
\ @brief software interrupt event register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$003fffff constant EXTI_SWIER1_SWI                                  \ Software interrupt on event
$80000000 constant EXTI_SWIER1_SWI_31                               \ Software interrupt on event


\
\ @brief EXTI pending register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$003fffff constant EXTI_PR1_PIF                                     \ Configurable event inputs Pending bit
$80000000 constant EXTI_PR1_PIF_31                                  \ Configurable event inputs Pending bit


\
\ @brief rising trigger selection register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000002 constant EXTI_RTSR2_RT33                                  \ Rising trigger event configuration bit of Configurable Event input
$00000300 constant EXTI_RTSR2_RT40_41                               \ Rising trigger event configuration bit of Configurable Event input


\
\ @brief falling trigger selection register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000002 constant EXTI_FTSR2_FT33                                  \ Falling trigger event configuration bit of Configurable Event input
$00000300 constant EXTI_FTSR2_FT40_41                               \ Falling trigger event configuration bit of Configurable Event input


\
\ @brief software interrupt event register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000002 constant EXTI_SWIER2_SWI33                                \ Software interrupt on event
$00000300 constant EXTI_SWIER2_SWI40_41                             \ Software interrupt on event


\
\ @brief pending register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000002 constant EXTI_PR2_PIF33                                   \ Configurable event inputs x+32 Pending bit.
$00000300 constant EXTI_PR2_PIF40_41                                \ Configurable event inputs x+32 Pending bit.


\
\ @brief CPUm wakeup with interrupt mask register
\ Address offset: 0x80
\ Reset value: 0x7FC00000
\

$00000000 constant EXTI_C1IMR1_IM                                   \ CPU(m) wakeup with interrupt Mask on Event input


\
\ @brief CPUm wakeup with event mask register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000ffff constant EXTI_C1EMR1_EM0_15                               \ CPU(m) Wakeup with event generation Mask on Event input
$003e0000 constant EXTI_C1EMR1_EM17_21                              \ CPU(m) Wakeup with event generation Mask on Event input


\
\ @brief CPUm wakeup with interrupt mask register
\ Address offset: 0x90
\ Reset value: 0x0001FCFD
\

$0001ffff constant EXTI_C1IMR2_IM                                   \ CPUm Wakeup with interrupt Mask on Event input


\
\ @brief CPUm wakeup with event mask register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000300 constant EXTI_C1EMR2_EM                                   \ CPU(m) Wakeup with event generation Mask on Event input


\
\ @brief CPUm wakeup with interrupt mask register
\ Address offset: 0xC0
\ Reset value: 0x7FC00000
\

$00000000 constant EXTI_C2IMR1_IM                                   \ CPU(m) wakeup with interrupt Mask on Event input


\
\ @brief CPUm wakeup with event mask register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$0000ffff constant EXTI_C2EMR1_EM0_15                               \ CPU(m) Wakeup with event generation Mask on Event input
$003e0000 constant EXTI_C2EMR1_EM17_21                              \ CPU(m) Wakeup with event generation Mask on Event input


\
\ @brief CPUm wakeup with interrupt mask register
\ Address offset: 0xD0
\ Reset value: 0x0001FCFD
\

$0001ffff constant EXTI_C2IMR2_IM                                   \ CPUm Wakeup with interrupt Mask on Event input


\
\ @brief CPUm wakeup with event mask register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000300 constant EXTI_C2EMR2_EM                                   \ CPU(m) Wakeup with event generation Mask on Event input


\
\ @brief EXTI Hardware configuration registers
\ Address offset: 0x3D8
\ Reset value: 0x00000000
\

$00000000 constant EXTI_HWCFGR7_CPUEVENT                            \ HW configuration CPU event generation


\
\ @brief Hardware configuration registers
\ Address offset: 0x3DC
\ Reset value: 0x00000300
\

$00000000 constant EXTI_HWCFGR6_CPUEVENT                            \ HW configuration CPU event generation


\
\ @brief Hardware configuration registers
\ Address offset: 0x3E0
\ Reset value: 0x003EFFFF
\

$00000000 constant EXTI_HWCFGR5_CPUEVENT                            \ HW configuration CPU event generation


\
\ @brief Hardware configuration registers
\ Address offset: 0x3E4
\ Reset value: 0x00000000
\

$00000000 constant EXTI_HWCFGR4_EVENT_TRG                           \ HW configuration event trigger type


\
\ @brief Hardware configuration registers
\ Address offset: 0x3E8
\ Reset value: 0x00000302
\

$00000000 constant EXTI_HWCFGR3_EVENT_TRG                           \ HW configuration event trigger type


\
\ @brief Hardware configuration registers
\ Address offset: 0x3EC
\ Reset value: 0x803FFFFF
\

$00000000 constant EXTI_HWCFGR2_EVENT_TRG                           \ HW configuration event trigger type


\
\ @brief Hardware configuration register 1
\ Address offset: 0x3F0
\ Reset value: 0x00003130
\

$000000ff constant EXTI_HWCFGR1_NBEVENTS                            \ HW configuration number of event
$00000f00 constant EXTI_HWCFGR1_NBCPUS                              \ HW configuration number of CPUs
$0000f000 constant EXTI_HWCFGR1_CPUEVTEN                            \ HW configuration of CPU(m) event output enable


\
\ @brief EXTI IP Version register
\ Address offset: 0x3F4
\ Reset value: 0x00000020
\

$0000000f constant EXTI_VERR_MINREV                                 \ Minor Revision number
$000000f0 constant EXTI_VERR_MAJREV                                 \ Major Revision number


\
\ @brief Identification register
\ Address offset: 0x3F8
\ Reset value: 0x000E0001
\

$00000000 constant EXTI_IPIDR_IPID                                  \ IP Identification


\
\ @brief Size ID register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant EXTI_SIDR_SID                                    \ Size Identification


\
\ @brief External interrupt/event controller
\
$58000800 constant EXTI_RTSR1     \ offset: 0x00 : rising trigger selection register
$58000804 constant EXTI_FTSR1     \ offset: 0x04 : falling trigger selection register
$58000808 constant EXTI_SWIER1    \ offset: 0x08 : software interrupt event register
$5800080c constant EXTI_PR1       \ offset: 0x0C : EXTI pending register
$58000820 constant EXTI_RTSR2     \ offset: 0x20 : rising trigger selection register
$58000824 constant EXTI_FTSR2     \ offset: 0x24 : falling trigger selection register
$58000828 constant EXTI_SWIER2    \ offset: 0x28 : software interrupt event register
$5800082c constant EXTI_PR2       \ offset: 0x2C : pending register
$58000880 constant EXTI_C1IMR1    \ offset: 0x80 : CPUm wakeup with interrupt mask register
$58000884 constant EXTI_C1EMR1    \ offset: 0x84 : CPUm wakeup with event mask register
$58000890 constant EXTI_C1IMR2    \ offset: 0x90 : CPUm wakeup with interrupt mask register
$58000894 constant EXTI_C1EMR2    \ offset: 0x94 : CPUm wakeup with event mask register
$580008c0 constant EXTI_C2IMR1    \ offset: 0xC0 : CPUm wakeup with interrupt mask register
$580008c4 constant EXTI_C2EMR1    \ offset: 0xC4 : CPUm wakeup with event mask register
$580008d0 constant EXTI_C2IMR2    \ offset: 0xD0 : CPUm wakeup with interrupt mask register
$580008d4 constant EXTI_C2EMR2    \ offset: 0xD4 : CPUm wakeup with event mask register
$58000bd8 constant EXTI_HWCFGR7   \ offset: 0x3D8 : EXTI Hardware configuration registers
$58000bdc constant EXTI_HWCFGR6   \ offset: 0x3DC : Hardware configuration registers
$58000be0 constant EXTI_HWCFGR5   \ offset: 0x3E0 : Hardware configuration registers
$58000be4 constant EXTI_HWCFGR4   \ offset: 0x3E4 : Hardware configuration registers
$58000be8 constant EXTI_HWCFGR3   \ offset: 0x3E8 : Hardware configuration registers
$58000bec constant EXTI_HWCFGR2   \ offset: 0x3EC : Hardware configuration registers
$58000bf0 constant EXTI_HWCFGR1   \ offset: 0x3F0 : Hardware configuration register 1
$58000bf4 constant EXTI_VERR      \ offset: 0x3F4 : EXTI IP Version register
$58000bf8 constant EXTI_IPIDR     \ offset: 0x3F8 : Identification register
$58000bfc constant EXTI_SIDR      \ offset: 0x3FC : Size ID register

