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

$0001ffff constant EXTI_RTSR1_RT                                    \ Rising trigger event configuration bit of Configurable Event input
$00600000 constant EXTI_RTSR1_RT21                                  \ Rising trigger event configuration bit of Configurable Event input


\
\ @brief falling trigger selection register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0001ffff constant EXTI_FTSR1_FT                                    \ Falling trigger event configuration bit of Configurable Event input
$00600000 constant EXTI_FTSR1_FT21                                  \ Falling trigger event configuration bit of Configurable Event input


\
\ @brief software interrupt event register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0001ffff constant EXTI_SWIER1_SWI                                  \ Software interrupt on event
$00600000 constant EXTI_SWIER1_SWI21                                \ Software interrupt on event


\
\ @brief EXTI pending register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0001ffff constant EXTI_PR1_PIF                                     \ Configurable event inputs Pending bit
$00600000 constant EXTI_PR1_PIF21                                   \ Configurable event inputs Pending bit


\
\ @brief rising trigger selection register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000004 constant EXTI_RTSR2_RT34                                  \ Rising trigger event configuration bit of Configurable Event input
$00002000 constant EXTI_RTSR2_RT45                                  \ Rising trigger event configuration bit of Configurable Event input


\
\ @brief falling trigger selection register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000004 constant EXTI_FTSR2_FT34                                  \ Falling trigger event configuration bit of Configurable Event input
$00002000 constant EXTI_FTSR2_FT45                                  \ Falling trigger event configuration bit of Configurable Event input


\
\ @brief software interrupt event register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000004 constant EXTI_SWIER2_SWI34                                \ Software interrupt on event
$00002000 constant EXTI_SWIER2_SWI45                                \ Software interrupt on event 45


\
\ @brief pending register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000004 constant EXTI_PR2_PIF34                                   \ Configurable event inputs 33 Pending bit.
$00002000 constant EXTI_PR2_PIF45                                   \ Configurable event inputs 45 Pending bit.


\
\ @brief interrupt mask register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant EXTI_IMR1_IM                                     \ wakeup with interrupt Mask on event input


\
\ @brief event mask register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EMR1_EM0                                    \ Wakeup with event generation Mask on Event input
$00000002 constant EXTI_EMR1_EM1                                    \ Wakeup with event generation Mask on Event input
$00000004 constant EXTI_EMR1_EM2                                    \ Wakeup with event generation Mask on Event input
$00000008 constant EXTI_EMR1_EM3                                    \ Wakeup with event generation Mask on Event input
$00000010 constant EXTI_EMR1_EM4                                    \ Wakeup with event generation Mask on Event input
$00000020 constant EXTI_EMR1_EM5                                    \ Wakeup with event generation Mask on Event input
$00000040 constant EXTI_EMR1_EM6                                    \ Wakeup with event generation Mask on Event input
$00000080 constant EXTI_EMR1_EM7                                    \ Wakeup with event generation Mask on Event input
$00000100 constant EXTI_EMR1_EM8                                    \ Wakeup with event generation Mask on Event input
$00000200 constant EXTI_EMR1_EM9                                    \ Wakeup with event generation Mask on Event input
$00000400 constant EXTI_EMR1_EM10                                   \ Wakeup with event generation Mask on Event input
$00000800 constant EXTI_EMR1_EM11                                   \ Wakeup with event generation Mask on Event input
$00001000 constant EXTI_EMR1_EM12                                   \ Wakeup with event generation Mask on Event input
$00002000 constant EXTI_EMR1_EM13                                   \ Wakeup with event generation Mask on Event input
$00004000 constant EXTI_EMR1_EM14                                   \ Wakeup with event generation Mask on Event input
$00008000 constant EXTI_EMR1_EM15                                   \ Wakeup with event generation Mask on Event input
$00020000 constant EXTI_EMR1_EM17                                   \ Wakeup with event generation Mask on Event input
$00040000 constant EXTI_EMR1_EM18                                   \ Wakeup with event generation Mask on Event input
$00080000 constant EXTI_EMR1_EM19                                   \ Wakeup with event generation Mask on Event input
$00100000 constant EXTI_EMR1_EM20                                   \ Wakeup with event generation Mask on Event input
$00200000 constant EXTI_EMR1_EM21                                   \ Wakeup with event generation Mask on Event input
$00400000 constant EXTI_EMR1_EM22                                   \ Wakeup with event generation Mask on Event input


\
\ @brief interrupt mask register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000004 constant EXTI_IMR2_IM34                                   \ CPUm Wakeup with interrupt Mask on Event input
$00000040 constant EXTI_IMR2_IM38                                   \ CPUm Wakeup with interrupt Mask on Event input
$00007c00 constant EXTI_IMR2_IM42                                   \ CPUm Wakeup with interrupt Mask on Event input


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
$58000880 constant EXTI_IMR1      \ offset: 0x80 : interrupt mask register
$58000884 constant EXTI_EMR1      \ offset: 0x84 : event mask register
$58000890 constant EXTI_IMR2      \ offset: 0x90 : interrupt mask register

