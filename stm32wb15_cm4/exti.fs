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

$001fffff constant EXTI_RTSR1_RT                                    \ Rising trigger event configuration bit of Configurable Event input


\
\ @brief falling trigger selection register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$001fffff constant EXTI_FTSR1_FT                                    \ Falling trigger event configuration bit of Configurable Event input


\
\ @brief software interrupt event register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$001fffff constant EXTI_SWIER1_SWI                                  \ Software interrupt on event


\
\ @brief EXTI pending register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$001fffff constant EXTI_PR1_PIF                                     \ Configurable event inputs Pending bit


\
\ @brief rising trigger selection register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000002 constant EXTI_RTSR2_RT33                                  \ Rising trigger event configuration bit of Configurable Event input
$00000100 constant EXTI_RTSR2_RT40                                  \ Rising trigger event configuration bit of Configurable Event input 40
$00000200 constant EXTI_RTSR2_RT41                                  \ Rising trigger event configuration bit of Configurable Event input 41


\
\ @brief falling trigger selection register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000002 constant EXTI_FTSR2_FT33                                  \ Falling trigger event configuration bit of Configurable Event input
$00000100 constant EXTI_FTSR2_FT40                                  \ Falling trigger event configuration bit of configurable event input 40
$00000200 constant EXTI_FTSR2_FT41                                  \ Falling trigger event configuration bit of configurable event input 41


\
\ @brief software interrupt event register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000002 constant EXTI_SWIER2_SWI33                                \ Software interrupt on event
$00000100 constant EXTI_SWIER2_SWI40                                \ Software interrupt on event
$00000200 constant EXTI_SWIER2_SWI41                                \ Software interrupt on event


\
\ @brief pending register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000002 constant EXTI_PR2_PIF33                                   \ Configurable event inputs x+32 Pending bit.
$00000100 constant EXTI_PR2_PIF40                                   \ Configurable event inputs x+32 Pending bit.
$00000200 constant EXTI_PR2_PIF41                                   \ Configurable event inputs x+32 Pending bit.


\
\ @brief CPUm wakeup with interrupt mask register
\ Address offset: 0x80
\ Reset value: 0x7FC00000
\

$00000000 constant EXTI_IMR1_IM                                     \ CPU(m) wakeup with interrupt Mask on Event input


\
\ @brief CPUm wakeup with event mask register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000ffff constant EXTI_EMR1_EM0_15                                 \ CPU(m) Wakeup with event generation Mask on Event input
$001e0000 constant EXTI_EMR1_EM17_20                                \ CPU(m) Wakeup with event generation Mask on Event input


\
\ @brief CPUm wakeup with interrupt mask register
\ Address offset: 0x90
\ Reset value: 0x0001FCFD
\

$0003fffe constant EXTI_IMR2_IM                                     \ CPUm Wakeup with interrupt Mask on Event input


\
\ @brief CPUm wakeup with event mask register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000300 constant EXTI_EMR2_EM                                     \ CPU(m) Wakeup with event generation Mask on Event input


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
$001e0000 constant EXTI_C2EMR1_EM17_20                              \ CPU(m) Wakeup with event generation Mask on Event input


\
\ @brief CPUm wakeup with interrupt mask register
\ Address offset: 0xD0
\ Reset value: 0x0001FCFD
\

$0003fffe constant EXTI_C2IMR2_IM                                   \ CPUm Wakeup with interrupt Mask on Event input


\
\ @brief CPUm wakeup with event mask register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000300 constant EXTI_C2EMR2_EM                                   \ CPU(m) Wakeup with event generation Mask on Event input


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
$58000880 constant EXTI_IMR1      \ offset: 0x80 : CPUm wakeup with interrupt mask register
$58000884 constant EXTI_EMR1      \ offset: 0x84 : CPUm wakeup with event mask register
$58000890 constant EXTI_IMR2      \ offset: 0x90 : CPUm wakeup with interrupt mask register
$58000894 constant EXTI_EMR2      \ offset: 0x94 : CPUm wakeup with event mask register
$580008c0 constant EXTI_C2IMR1    \ offset: 0xC0 : CPUm wakeup with interrupt mask register
$580008c4 constant EXTI_C2EMR1    \ offset: 0xC4 : CPUm wakeup with event mask register
$580008d0 constant EXTI_C2IMR2    \ offset: 0xD0 : CPUm wakeup with interrupt mask register
$580008d4 constant EXTI_C2EMR2    \ offset: 0xD4 : CPUm wakeup with event mask register

