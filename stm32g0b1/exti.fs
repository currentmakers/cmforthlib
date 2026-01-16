\
\ @file exti.fs
\ @brief External interrupt/event       controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief EXTI rising trigger selection register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant EXTI_RTSR1_RT0                                   \ Rising trigger event configuration bit of Configurable Event line
$00000002 constant EXTI_RTSR1_RT1                                   \ Rising trigger event configuration bit of Configurable Event line
$00000004 constant EXTI_RTSR1_RT2                                   \ Rising trigger event configuration bit of Configurable Event line
$00000008 constant EXTI_RTSR1_RT3                                   \ Rising trigger event configuration bit of Configurable Event line
$00000010 constant EXTI_RTSR1_RT4                                   \ Rising trigger event configuration bit of Configurable Event line
$00000020 constant EXTI_RTSR1_RT5                                   \ Rising trigger event configuration bit of Configurable Event line
$00000040 constant EXTI_RTSR1_RT6                                   \ Rising trigger event configuration bit of Configurable Event line
$00000080 constant EXTI_RTSR1_RT7                                   \ Rising trigger event configuration bit of Configurable Event line
$00000100 constant EXTI_RTSR1_RT8                                   \ Rising trigger event configuration bit of Configurable Event line
$00000200 constant EXTI_RTSR1_RT9                                   \ Rising trigger event configuration bit of Configurable Event line
$00000400 constant EXTI_RTSR1_RT10                                  \ Rising trigger event configuration bit of Configurable Event line
$00000800 constant EXTI_RTSR1_RT11                                  \ Rising trigger event configuration bit of Configurable Event line
$00001000 constant EXTI_RTSR1_RT12                                  \ Rising trigger event configuration bit of Configurable Event line
$00002000 constant EXTI_RTSR1_RT13                                  \ Rising trigger event configuration bit of Configurable Event line
$00004000 constant EXTI_RTSR1_RT14                                  \ Rising trigger event configuration bit of Configurable Event line
$00008000 constant EXTI_RTSR1_RT15                                  \ Rising trigger event configuration bit of Configurable Event line
$00010000 constant EXTI_RTSR1_RT16                                  \ Rising trigger event configuration bit of Configurable Event line
$00020000 constant EXTI_RTSR1_RT17                                  \ Rising trigger event configuration bit of Configurable Event line
$00040000 constant EXTI_RTSR1_RT18                                  \ Rising trigger event configuration bit of Configurable Event line
$00100000 constant EXTI_RTSR1_RT20                                  \ Rising trigger event configuration bit of Configurable Event line


\
\ @brief EXTI falling trigger selection register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant EXTI_FTSR1_FT0                                   \ Falling trigger event configuration bit of configurable line
$00000002 constant EXTI_FTSR1_FT1                                   \ Falling trigger event configuration bit of configurable line
$00000004 constant EXTI_FTSR1_FT2                                   \ Falling trigger event configuration bit of configurable line
$00000008 constant EXTI_FTSR1_FT3                                   \ Falling trigger event configuration bit of configurable line
$00000010 constant EXTI_FTSR1_FT4                                   \ Falling trigger event configuration bit of configurable line
$00000020 constant EXTI_FTSR1_FT5                                   \ Falling trigger event configuration bit of configurable line
$00000040 constant EXTI_FTSR1_FT6                                   \ Falling trigger event configuration bit of configurable line
$00000080 constant EXTI_FTSR1_FT7                                   \ Falling trigger event configuration bit of configurable line
$00000100 constant EXTI_FTSR1_FT8                                   \ Falling trigger event configuration bit of configurable line
$00000200 constant EXTI_FTSR1_FT9                                   \ Falling trigger event configuration bit of configurable line
$00000400 constant EXTI_FTSR1_FT10                                  \ Falling trigger event configuration bit of configurable line
$00000800 constant EXTI_FTSR1_FT11                                  \ Falling trigger event configuration bit of configurable line
$00001000 constant EXTI_FTSR1_FT12                                  \ Falling trigger event configuration bit of configurable line
$00002000 constant EXTI_FTSR1_FT13                                  \ Falling trigger event configuration bit of configurable line
$00004000 constant EXTI_FTSR1_FT14                                  \ Falling trigger event configuration bit of configurable line
$00008000 constant EXTI_FTSR1_FT15                                  \ Falling trigger event configuration bit of configurable line
$00010000 constant EXTI_FTSR1_FT16                                  \ Falling trigger event configuration bit of configurable line
$00020000 constant EXTI_FTSR1_FT17                                  \ Falling trigger event configuration bit of configurable line
$00040000 constant EXTI_FTSR1_FT18                                  \ Falling trigger event configuration bit of configurable line
$00100000 constant EXTI_FTSR1_FT20                                  \ Rising trigger event configuration bit of Configurable Event input


\
\ @brief EXTI software interrupt event register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant EXTI_SWIER1_SWI0                                 \ Software rising edge event trigger on line
$00000002 constant EXTI_SWIER1_SWI1                                 \ Software rising edge event trigger on line
$00000004 constant EXTI_SWIER1_SWI2                                 \ Software rising edge event trigger on line
$00000008 constant EXTI_SWIER1_SWI3                                 \ Software rising edge event trigger on line
$00000010 constant EXTI_SWIER1_SWI4                                 \ Software rising edge event trigger on line
$00000020 constant EXTI_SWIER1_SWI5                                 \ Software rising edge event trigger on line
$00000040 constant EXTI_SWIER1_SWI6                                 \ Software rising edge event trigger on line
$00000080 constant EXTI_SWIER1_SWI7                                 \ Software rising edge event trigger on line
$00000100 constant EXTI_SWIER1_SWI8                                 \ Software rising edge event trigger on line
$00000200 constant EXTI_SWIER1_SWI9                                 \ Software rising edge event trigger on line
$00000400 constant EXTI_SWIER1_SWI10                                \ Software rising edge event trigger on line
$00000800 constant EXTI_SWIER1_SWI11                                \ Software rising edge event trigger on line
$00001000 constant EXTI_SWIER1_SWI12                                \ Software rising edge event trigger on line
$00002000 constant EXTI_SWIER1_SWI13                                \ Software rising edge event trigger on line
$00004000 constant EXTI_SWIER1_SWI14                                \ Software rising edge event trigger on line
$00008000 constant EXTI_SWIER1_SWI15                                \ Software rising edge event trigger on line
$00010000 constant EXTI_SWIER1_SWI16                                \ Software rising edge event trigger on line
$00020000 constant EXTI_SWIER1_SWI17                                \ Software rising edge event trigger on line
$00040000 constant EXTI_SWIER1_SWI18                                \ Software rising edge event trigger on line
$00100000 constant EXTI_SWIER1_SWI20                                \ Software rising edge event trigger on line


\
\ @brief EXTI rising edge pending register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant EXTI_RPR1_RPIF0                                  \ Rising edge event pending for configurable line
$00000002 constant EXTI_RPR1_RPIF1                                  \ Rising edge event pending for configurable line
$00000004 constant EXTI_RPR1_RPIF2                                  \ Rising edge event pending for configurable line
$00000008 constant EXTI_RPR1_RPIF3                                  \ Rising edge event pending for configurable line
$00000010 constant EXTI_RPR1_RPIF4                                  \ Rising edge event pending for configurable line
$00000020 constant EXTI_RPR1_RPIF5                                  \ configurable event inputs x rising edge Pending bit
$00000040 constant EXTI_RPR1_RPIF6                                  \ Rising edge event pending for configurable line
$00000080 constant EXTI_RPR1_RPIF7                                  \ Rising edge event pending for configurable line
$00000100 constant EXTI_RPR1_RPIF8                                  \ Rising edge event pending for configurable line
$00000200 constant EXTI_RPR1_RPIF9                                  \ Rising edge event pending for configurable line
$00000400 constant EXTI_RPR1_RPIF10                                 \ Rising edge event pending for configurable line
$00000800 constant EXTI_RPR1_RPIF11                                 \ Rising edge event pending for configurable line
$00001000 constant EXTI_RPR1_RPIF12                                 \ Rising edge event pending for configurable line
$00002000 constant EXTI_RPR1_RPIF13                                 \ Rising edge event pending for configurable line
$00004000 constant EXTI_RPR1_RPIF14                                 \ Rising edge event pending for configurable line
$00008000 constant EXTI_RPR1_RPIF15                                 \ Rising edge event pending for configurable line
$00010000 constant EXTI_RPR1_RPIF16                                 \ Rising edge event pending for configurable line
$00020000 constant EXTI_RPR1_RPIF17                                 \ Rising edge event pending for configurable line
$00040000 constant EXTI_RPR1_RPIF18                                 \ Rising edge event pending for configurable line
$00100000 constant EXTI_RPR1_RPIF20                                 \ Rising edge event pending for configurable line


\
\ @brief EXTI falling edge pending register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant EXTI_FPR1_FPIF0                                  \ Falling edge event pending for configurable line
$00000002 constant EXTI_FPR1_FPIF1                                  \ Falling edge event pending for configurable line
$00000004 constant EXTI_FPR1_FPIF2                                  \ Falling edge event pending for configurable line
$00000008 constant EXTI_FPR1_FPIF3                                  \ Falling edge event pending for configurable line
$00000010 constant EXTI_FPR1_FPIF4                                  \ Falling edge event pending for configurable line
$00000020 constant EXTI_FPR1_FPIF5                                  \ Falling edge event pending for configurable line
$00000040 constant EXTI_FPR1_FPIF6                                  \ Falling edge event pending for configurable line
$00000080 constant EXTI_FPR1_FPIF7                                  \ Falling edge event pending for configurable line
$00000100 constant EXTI_FPR1_FPIF8                                  \ Falling edge event pending for configurable line
$00000200 constant EXTI_FPR1_FPIF9                                  \ Falling edge event pending for configurable line
$00000400 constant EXTI_FPR1_FPIF10                                 \ Falling edge event pending for configurable line
$00000800 constant EXTI_FPR1_FPIF11                                 \ Falling edge event pending for configurable line
$00001000 constant EXTI_FPR1_FPIF12                                 \ Falling edge event pending for configurable line
$00002000 constant EXTI_FPR1_FPIF13                                 \ Falling edge event pending for configurable line
$00004000 constant EXTI_FPR1_FPIF14                                 \ Falling edge event pending for configurable line
$00008000 constant EXTI_FPR1_FPIF15                                 \ Falling edge event pending for configurable line
$00010000 constant EXTI_FPR1_FPIF16                                 \ Falling edge event pending for configurable line
$00020000 constant EXTI_FPR1_FPIF17                                 \ Falling edge event pending for configurable line
$00040000 constant EXTI_FPR1_FPIF18                                 \ Falling edge event pending for configurable line
$00100000 constant EXTI_FPR1_FPIF20                                 \ Falling edge event pending for configurable line


\
\ @brief EXTI rising trigger selection register 2
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000004 constant EXTI_RTSR2_RT2                                   \ Rising trigger event configuration bit of configurable line 34


\
\ @brief EXTI falling trigger selection register 2
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000004 constant EXTI_FTSR2_FT2                                   \ Falling trigger event configuration bit of configurable line 34


\
\ @brief EXTI software interrupt event register 2
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000004 constant EXTI_SWIER2_SWI2                                 \ Software rising edge event trigger on line 34


\
\ @brief EXTI rising edge pending register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000004 constant EXTI_RPR2_RPIF2                                  \ Rising edge event pending for configurable line 34


\
\ @brief EXTI falling edge pending register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000004 constant EXTI_FPR2_FPIF2                                  \ Falling edge event pending for configurable line 34


\
\ @brief EXTI external interrupt selection register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$000000ff constant EXTI_EXTICR1_EXTI0_7                             \ GPIO port selection
$0000ff00 constant EXTI_EXTICR1_EXTI8_15                            \ GPIO port selection
$00ff0000 constant EXTI_EXTICR1_EXTI16_23                           \ GPIO port selection
$ff000000 constant EXTI_EXTICR1_EXTI24_31                           \ GPIO port selection


\
\ @brief EXTI external interrupt selection register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$000000ff constant EXTI_EXTICR2_EXTI0_7                             \ GPIO port selection
$0000ff00 constant EXTI_EXTICR2_EXTI8_15                            \ GPIO port selection
$00ff0000 constant EXTI_EXTICR2_EXTI16_23                           \ GPIO port selection
$ff000000 constant EXTI_EXTICR2_EXTI24_31                           \ GPIO port selection


\
\ @brief EXTI external interrupt selection register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$000000ff constant EXTI_EXTICR3_EXTI0_7                             \ GPIO port selection
$0000ff00 constant EXTI_EXTICR3_EXTI8_15                            \ GPIO port selection
$00ff0000 constant EXTI_EXTICR3_EXTI16_23                           \ GPIO port selection
$ff000000 constant EXTI_EXTICR3_EXTI24_31                           \ GPIO port selection


\
\ @brief EXTI external interrupt selection register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$000000ff constant EXTI_EXTICR4_EXTI0_7                             \ GPIO port selection
$0000ff00 constant EXTI_EXTICR4_EXTI8_15                            \ GPIO port selection
$00ff0000 constant EXTI_EXTICR4_EXTI16_23                           \ GPIO port selection
$ff000000 constant EXTI_EXTICR4_EXTI24_31                           \ GPIO port selection


\
\ @brief EXTI CPU wakeup with interrupt mask register
\ Address offset: 0x80
\ Reset value: 0xFFF80000
\

$00000001 constant EXTI_IMR1_IM0                                    \ CPU wakeup with interrupt mask on event input
$00000002 constant EXTI_IMR1_IM1                                    \ CPU wakeup with interrupt mask on event input
$00000004 constant EXTI_IMR1_IM2                                    \ CPU wakeup with interrupt mask on event input
$00000008 constant EXTI_IMR1_IM3                                    \ CPU wakeup with interrupt mask on event input
$00000010 constant EXTI_IMR1_IM4                                    \ CPU wakeup with interrupt mask on event input
$00000020 constant EXTI_IMR1_IM5                                    \ CPU wakeup with interrupt mask on event input
$00000040 constant EXTI_IMR1_IM6                                    \ CPU wakeup with interrupt mask on event input
$00000080 constant EXTI_IMR1_IM7                                    \ CPU wakeup with interrupt mask on event input
$00000100 constant EXTI_IMR1_IM8                                    \ CPU wakeup with interrupt mask on event input
$00000200 constant EXTI_IMR1_IM9                                    \ CPU wakeup with interrupt mask on event input
$00000400 constant EXTI_IMR1_IM10                                   \ CPU wakeup with interrupt mask on event input
$00000800 constant EXTI_IMR1_IM11                                   \ CPU wakeup with interrupt mask on event input
$00001000 constant EXTI_IMR1_IM12                                   \ CPU wakeup with interrupt mask on event input
$00002000 constant EXTI_IMR1_IM13                                   \ CPU wakeup with interrupt mask on event input
$00004000 constant EXTI_IMR1_IM14                                   \ CPU wakeup with interrupt mask on event input
$00008000 constant EXTI_IMR1_IM15                                   \ CPU wakeup with interrupt mask on event input
$00010000 constant EXTI_IMR1_IM16                                   \ CPU wakeup with interrupt mask on event input
$00020000 constant EXTI_IMR1_IM17                                   \ CPU wakeup with interrupt mask on event input
$00040000 constant EXTI_IMR1_IM18                                   \ CPU wakeup with interrupt mask on event input
$00080000 constant EXTI_IMR1_IM19                                   \ CPU wakeup with interrupt mask on event input
$00100000 constant EXTI_IMR1_IM20                                   \ CPU wakeup with interrupt mask on event input
$00200000 constant EXTI_IMR1_IM21                                   \ CPU wakeup with interrupt mask on event input
$00400000 constant EXTI_IMR1_IM22                                   \ CPU wakeup with interrupt mask on event input
$00800000 constant EXTI_IMR1_IM23                                   \ CPU wakeup with interrupt mask on event input
$01000000 constant EXTI_IMR1_IM24                                   \ CPU wakeup with interrupt mask on event input
$02000000 constant EXTI_IMR1_IM25                                   \ CPU wakeup with interrupt mask on event input
$04000000 constant EXTI_IMR1_IM26                                   \ CPU wakeup with interrupt mask on event input
$08000000 constant EXTI_IMR1_IM27                                   \ CPU wakeup with interrupt mask on event input
$10000000 constant EXTI_IMR1_IM28                                   \ CPU wakeup with interrupt mask on event input
$20000000 constant EXTI_IMR1_IM29                                   \ CPU wakeup with interrupt mask on event input
$40000000 constant EXTI_IMR1_IM30                                   \ CPU wakeup with interrupt mask on event input
$80000000 constant EXTI_IMR1_IM31                                   \ CPU wakeup with interrupt mask on event input


\
\ @brief EXTI CPU wakeup with event mask register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EMR1_EM0                                    \ CPU wakeup with event mask on event input
$00000002 constant EXTI_EMR1_EM1                                    \ CPU wakeup with event mask on event input
$00000004 constant EXTI_EMR1_EM2                                    \ CPU wakeup with event mask on event input
$00000008 constant EXTI_EMR1_EM3                                    \ CPU wakeup with event mask on event input
$00000010 constant EXTI_EMR1_EM4                                    \ CPU wakeup with event mask on event input
$00000020 constant EXTI_EMR1_EM5                                    \ CPU wakeup with event mask on event input
$00000040 constant EXTI_EMR1_EM6                                    \ CPU wakeup with event mask on event input
$00000080 constant EXTI_EMR1_EM7                                    \ CPU wakeup with event mask on event input
$00000100 constant EXTI_EMR1_EM8                                    \ CPU wakeup with event mask on event input
$00000200 constant EXTI_EMR1_EM9                                    \ CPU wakeup with event mask on event input
$00000400 constant EXTI_EMR1_EM10                                   \ CPU wakeup with event mask on event input
$00000800 constant EXTI_EMR1_EM11                                   \ CPU wakeup with event mask on event input
$00001000 constant EXTI_EMR1_EM12                                   \ CPU wakeup with event mask on event input
$00002000 constant EXTI_EMR1_EM13                                   \ CPU wakeup with event mask on event input
$00004000 constant EXTI_EMR1_EM14                                   \ CPU wakeup with event mask on event input
$00008000 constant EXTI_EMR1_EM15                                   \ CPU wakeup with event mask on event input
$00010000 constant EXTI_EMR1_EM16                                   \ CPU wakeup with event mask on event input
$00020000 constant EXTI_EMR1_EM17                                   \ CPU wakeup with event mask on event input
$00040000 constant EXTI_EMR1_EM18                                   \ CPU wakeup with event mask on event input
$00080000 constant EXTI_EMR1_EM19                                   \ CPU wakeup with event mask on event input
$00200000 constant EXTI_EMR1_EM21                                   \ CPU wakeup with event mask on event input
$00800000 constant EXTI_EMR1_EM23                                   \ CPU wakeup with event mask on event input
$02000000 constant EXTI_EMR1_EM25                                   \ CPU wakeup with event mask on event input
$04000000 constant EXTI_EMR1_EM26                                   \ CPU wakeup with event mask on event input
$08000000 constant EXTI_EMR1_EM27                                   \ CPU wakeup with event mask on event input
$10000000 constant EXTI_EMR1_EM28                                   \ CPU wakeup with event mask on event input
$20000000 constant EXTI_EMR1_EM29                                   \ CPU wakeup with event mask on event input
$40000000 constant EXTI_EMR1_EM30                                   \ CPU wakeup with event mask on event input
$80000000 constant EXTI_EMR1_EM31                                   \ CPU wakeup with event mask on event input


\
\ @brief EXTI CPU wakeup with interrupt mask register
\ Address offset: 0x90
\ Reset value: 0xFFFFFFFF
\

$00000001 constant EXTI_IMR2_IM32                                   \ CPU wakeup with interrupt mask on event input
$00000002 constant EXTI_IMR2_IM33                                   \ CPU wakeup with interrupt mask on event input
$00000004 constant EXTI_IMR2_IM34                                   \ CPU wakeup with interrupt mask on event input
$00000008 constant EXTI_IMR2_IM35                                   \ CPU wakeup with interrupt mask on event input


\
\ @brief EXTI CPU wakeup with event mask register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EMR2_EM32                                   \ CPU wakeup with event mask on event input
$00000002 constant EXTI_EMR2_EM33                                   \ CPU wakeup with event mask on event input
$00000004 constant EXTI_EMR2_EM34                                   \ CPU wakeup with event mask on event input
$00000008 constant EXTI_EMR2_EM35                                   \ CPU wakeup with event mask on event input


\
\ @brief External interrupt/event controller
\
$40021800 constant EXTI_RTSR1     \ offset: 0x00 : EXTI rising trigger selection register
$40021804 constant EXTI_FTSR1     \ offset: 0x04 : EXTI falling trigger selection register
$40021808 constant EXTI_SWIER1    \ offset: 0x08 : EXTI software interrupt event register
$4002180c constant EXTI_RPR1      \ offset: 0x0C : EXTI rising edge pending register
$40021810 constant EXTI_FPR1      \ offset: 0x10 : EXTI falling edge pending register
$40021828 constant EXTI_RTSR2     \ offset: 0x28 : EXTI rising trigger selection register 2
$4002182c constant EXTI_FTSR2     \ offset: 0x2C : EXTI falling trigger selection register 2
$40021830 constant EXTI_SWIER2    \ offset: 0x30 : EXTI software interrupt event register 2
$40021834 constant EXTI_RPR2      \ offset: 0x34 : EXTI rising edge pending register 2
$40021838 constant EXTI_FPR2      \ offset: 0x38 : EXTI falling edge pending register 2
$40021860 constant EXTI_EXTICR1   \ offset: 0x60 : EXTI external interrupt selection register
$40021864 constant EXTI_EXTICR2   \ offset: 0x64 : EXTI external interrupt selection register
$40021868 constant EXTI_EXTICR3   \ offset: 0x68 : EXTI external interrupt selection register
$4002186c constant EXTI_EXTICR4   \ offset: 0x6C : EXTI external interrupt selection register
$40021880 constant EXTI_IMR1      \ offset: 0x80 : EXTI CPU wakeup with interrupt mask register
$40021884 constant EXTI_EMR1      \ offset: 0x84 : EXTI CPU wakeup with event mask register
$40021890 constant EXTI_IMR2      \ offset: 0x90 : EXTI CPU wakeup with interrupt mask register
$40021894 constant EXTI_EMR2      \ offset: 0x94 : EXTI CPU wakeup with event mask register

