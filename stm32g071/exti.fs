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

$00000001 constant EXTI_RTSR1_TR0                                   \ Rising trigger event configuration bit of Configurable Event input
$00000002 constant EXTI_RTSR1_TR1                                   \ Rising trigger event configuration bit of Configurable Event input
$00000004 constant EXTI_RTSR1_TR2                                   \ Rising trigger event configuration bit of Configurable Event input
$00000008 constant EXTI_RTSR1_TR3                                   \ Rising trigger event configuration bit of Configurable Event input
$00000010 constant EXTI_RTSR1_TR4                                   \ Rising trigger event configuration bit of Configurable Event input
$00000020 constant EXTI_RTSR1_TR5                                   \ Rising trigger event configuration bit of Configurable Event input
$00000040 constant EXTI_RTSR1_TR6                                   \ Rising trigger event configuration bit of Configurable Event input
$00000080 constant EXTI_RTSR1_TR7                                   \ Rising trigger event configuration bit of Configurable Event input
$00000100 constant EXTI_RTSR1_TR8                                   \ Rising trigger event configuration bit of Configurable Event input
$00000200 constant EXTI_RTSR1_TR9                                   \ Rising trigger event configuration bit of Configurable Event input
$00000400 constant EXTI_RTSR1_TR10                                  \ Rising trigger event configuration bit of Configurable Event input
$00000800 constant EXTI_RTSR1_TR11                                  \ Rising trigger event configuration bit of Configurable Event input
$00001000 constant EXTI_RTSR1_TR12                                  \ Rising trigger event configuration bit of Configurable Event input
$00002000 constant EXTI_RTSR1_TR13                                  \ Rising trigger event configuration bit of Configurable Event input
$00004000 constant EXTI_RTSR1_TR14                                  \ Rising trigger event configuration bit of Configurable Event input
$00008000 constant EXTI_RTSR1_TR15                                  \ Rising trigger event configuration bit of Configurable Event input
$00010000 constant EXTI_RTSR1_TR16                                  \ Rising trigger event configuration bit of Configurable Event input
$00020000 constant EXTI_RTSR1_TR17                                  \ Rising trigger event configuration bit of Configurable Event input
$00040000 constant EXTI_RTSR1_TR18                                  \ Rising trigger event configuration bit of Configurable Event input


\
\ @brief EXTI falling trigger selection register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant EXTI_FTSR1_TR0                                   \ Rising trigger event configuration bit of Configurable Event input
$00000002 constant EXTI_FTSR1_TR1                                   \ Rising trigger event configuration bit of Configurable Event input
$00000004 constant EXTI_FTSR1_TR2                                   \ Rising trigger event configuration bit of Configurable Event input
$00000008 constant EXTI_FTSR1_TR3                                   \ Rising trigger event configuration bit of Configurable Event input
$00000010 constant EXTI_FTSR1_TR4                                   \ Rising trigger event configuration bit of Configurable Event input
$00000020 constant EXTI_FTSR1_TR5                                   \ Rising trigger event configuration bit of Configurable Event input
$00000040 constant EXTI_FTSR1_TR6                                   \ Rising trigger event configuration bit of Configurable Event input
$00000080 constant EXTI_FTSR1_TR7                                   \ Rising trigger event configuration bit of Configurable Event input
$00000100 constant EXTI_FTSR1_TR8                                   \ Rising trigger event configuration bit of Configurable Event input
$00000200 constant EXTI_FTSR1_TR9                                   \ Rising trigger event configuration bit of Configurable Event input
$00000400 constant EXTI_FTSR1_TR10                                  \ Rising trigger event configuration bit of Configurable Event input
$00000800 constant EXTI_FTSR1_TR11                                  \ Rising trigger event configuration bit of Configurable Event input
$00001000 constant EXTI_FTSR1_TR12                                  \ Rising trigger event configuration bit of Configurable Event input
$00002000 constant EXTI_FTSR1_TR13                                  \ Rising trigger event configuration bit of Configurable Event input
$00004000 constant EXTI_FTSR1_TR14                                  \ Rising trigger event configuration bit of Configurable Event input
$00008000 constant EXTI_FTSR1_TR15                                  \ Rising trigger event configuration bit of Configurable Event input
$00010000 constant EXTI_FTSR1_TR16                                  \ Rising trigger event configuration bit of Configurable Event input
$00020000 constant EXTI_FTSR1_TR17                                  \ Rising trigger event configuration bit of Configurable Event input
$00040000 constant EXTI_FTSR1_TR18                                  \ Rising trigger event configuration bit of Configurable Event input


\
\ @brief EXTI software interrupt event register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant EXTI_SWIER1_SWIER0                               \ Rising trigger event configuration bit of Configurable Event input
$00000002 constant EXTI_SWIER1_SWIER1                               \ Rising trigger event configuration bit of Configurable Event input
$00000004 constant EXTI_SWIER1_SWIER2                               \ Rising trigger event configuration bit of Configurable Event input
$00000008 constant EXTI_SWIER1_SWIER3                               \ Rising trigger event configuration bit of Configurable Event input
$00000010 constant EXTI_SWIER1_SWIER4                               \ Rising trigger event configuration bit of Configurable Event input
$00000020 constant EXTI_SWIER1_SWIER5                               \ Rising trigger event configuration bit of Configurable Event input
$00000040 constant EXTI_SWIER1_SWIER6                               \ Rising trigger event configuration bit of Configurable Event input
$00000080 constant EXTI_SWIER1_SWIER7                               \ Rising trigger event configuration bit of Configurable Event input
$00000100 constant EXTI_SWIER1_SWIER8                               \ Rising trigger event configuration bit of Configurable Event input
$00000200 constant EXTI_SWIER1_SWIER9                               \ Rising trigger event configuration bit of Configurable Event input
$00000400 constant EXTI_SWIER1_SWIER10                              \ Rising trigger event configuration bit of Configurable Event input
$00000800 constant EXTI_SWIER1_SWIER11                              \ Rising trigger event configuration bit of Configurable Event input
$00001000 constant EXTI_SWIER1_SWIER12                              \ Rising trigger event configuration bit of Configurable Event input
$00002000 constant EXTI_SWIER1_SWIER13                              \ Rising trigger event configuration bit of Configurable Event input
$00004000 constant EXTI_SWIER1_SWIER14                              \ Rising trigger event configuration bit of Configurable Event input
$00008000 constant EXTI_SWIER1_SWIER15                              \ Rising trigger event configuration bit of Configurable Event input
$00010000 constant EXTI_SWIER1_SWIER16                              \ Rising trigger event configuration bit of Configurable Event input
$00020000 constant EXTI_SWIER1_SWIER17                              \ Rising trigger event configuration bit of Configurable Event input
$00040000 constant EXTI_SWIER1_SWIER18                              \ Rising trigger event configuration bit of Configurable Event input


\
\ @brief EXTI rising edge pending register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant EXTI_RPR1_RPIF0                                  \ configurable event inputs x rising edge Pending bit.
$00000002 constant EXTI_RPR1_RPIF1                                  \ configurable event inputs x rising edge Pending bit.
$00000004 constant EXTI_RPR1_RPIF2                                  \ configurable event inputs x rising edge Pending bit.
$00000008 constant EXTI_RPR1_RPIF3                                  \ configurable event inputs x rising edge Pending bit.
$00000010 constant EXTI_RPR1_RPIF4                                  \ configurable event inputs x rising edge Pending bit.
$00000020 constant EXTI_RPR1_RPIF5                                  \ configurable event inputs x rising edge Pending bit
$00000040 constant EXTI_RPR1_RPIF6                                  \ configurable event inputs x rising edge Pending bit.
$00000080 constant EXTI_RPR1_RPIF7                                  \ configurable event inputs x rising edge Pending bit.
$00000100 constant EXTI_RPR1_RPIF8                                  \ configurable event inputs x rising edge Pending bit.
$00000200 constant EXTI_RPR1_RPIF9                                  \ configurable event inputs x rising edge Pending bit.
$00000400 constant EXTI_RPR1_RPIF10                                 \ configurable event inputs x rising edge Pending bit.
$00000800 constant EXTI_RPR1_RPIF11                                 \ configurable event inputs x rising edge Pending bit.
$00001000 constant EXTI_RPR1_RPIF12                                 \ configurable event inputs x rising edge Pending bit.
$00002000 constant EXTI_RPR1_RPIF13                                 \ configurable event inputs x rising edge Pending bit.
$00004000 constant EXTI_RPR1_RPIF14                                 \ configurable event inputs x rising edge Pending bit.
$00008000 constant EXTI_RPR1_RPIF15                                 \ configurable event inputs x rising edge Pending bit.
$00010000 constant EXTI_RPR1_RPIF16                                 \ configurable event inputs x rising edge Pending bit.
$00020000 constant EXTI_RPR1_RPIF17                                 \ configurable event inputs x rising edge Pending bit.
$00040000 constant EXTI_RPR1_RPIF18                                 \ configurable event inputs x rising edge Pending bit.


\
\ @brief EXTI falling edge pending register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant EXTI_FPR1_FPIF0                                  \ configurable event inputs x falling edge pending bit.
$00000002 constant EXTI_FPR1_FPIF1                                  \ configurable event inputs x falling edge pending bit.
$00000004 constant EXTI_FPR1_FPIF2                                  \ configurable event inputs x falling edge pending bit.
$00000008 constant EXTI_FPR1_FPIF3                                  \ configurable event inputs x falling edge pending bit.
$00000010 constant EXTI_FPR1_FPIF4                                  \ configurable event inputs x falling edge pending bit.
$00000020 constant EXTI_FPR1_FPIF5                                  \ configurable event inputs x falling edge pending bit.
$00000040 constant EXTI_FPR1_FPIF6                                  \ configurable event inputs x falling edge pending bit.
$00000080 constant EXTI_FPR1_FPIF7                                  \ configurable event inputs x falling edge pending bit.
$00000100 constant EXTI_FPR1_FPIF8                                  \ configurable event inputs x falling edge pending bit.
$00000200 constant EXTI_FPR1_FPIF9                                  \ configurable event inputs x falling edge pending bit.
$00000400 constant EXTI_FPR1_FPIF10                                 \ configurable event inputs x falling edge pending bit.
$00000800 constant EXTI_FPR1_FPIF11                                 \ configurable event inputs x falling edge pending bit.
$00001000 constant EXTI_FPR1_FPIF12                                 \ configurable event inputs x falling edge pending bit.
$00002000 constant EXTI_FPR1_FPIF13                                 \ configurable event inputs x falling edge pending bit.
$00004000 constant EXTI_FPR1_FPIF14                                 \ configurable event inputs x falling edge pending bit.
$00008000 constant EXTI_FPR1_FPIF15                                 \ configurable event inputs x falling edge pending bit.
$00010000 constant EXTI_FPR1_FPIF16                                 \ configurable event inputs x falling edge pending bit.
$00020000 constant EXTI_FPR1_FPIF17                                 \ configurable event inputs x falling edge pending bit.
$00040000 constant EXTI_FPR1_FPIF18                                 \ configurable event inputs x falling edge pending bit.


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


\
\ @brief EXTI CPU wakeup with event mask register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EMR2_EM32                                   \ CPU wakeup with event mask on event input
$00000002 constant EXTI_EMR2_EM33                                   \ CPU wakeup with event mask on event input


\
\ @brief Hardware configuration registers
\ Address offset: 0x3D8
\ Reset value: 0x00000000
\

$00000000 constant EXTI_HWCFGR7_CPUEVENT                            \ HW configuration CPU event generation


\
\ @brief Hardware configuration registers
\ Address offset: 0x3DC
\ Reset value: 0x00000003
\

$00000000 constant EXTI_HWCFGR6_CPUEVENT                            \ HW configuration CPU event generation


\
\ @brief Hardware configuration registers
\ Address offset: 0x3E0
\ Reset value: 0xFEAFFFFF
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
\ Reset value: 0x00000000
\

$00000000 constant EXTI_HWCFGR3_EVENT_TRG                           \ HW configuration event trigger type


\
\ @brief Hardware configuration registers
\ Address offset: 0x3EC
\ Reset value: 0x0007FFFF
\

$00000000 constant EXTI_HWCFGR2_EVENT_TRG                           \ HW configuration event trigger type


\
\ @brief Hardware configuration registers
\ Address offset: 0x3F0
\ Reset value: 0x00051021
\

$000000ff constant EXTI_HWCFGR1_NBEVENTS                            \ configuration number of event
$00000f00 constant EXTI_HWCFGR1_NBCPUS                              \ configuration number of CPUs
$0000f000 constant EXTI_HWCFGR1_CPUEVTEN                            \ HW configuration of CPU event output enable
$00ff0000 constant EXTI_HWCFGR1_NBIOPORT                            \ HW configuration of number of IO ports


\
\ @brief AES version register
\ Address offset: 0x3F4
\ Reset value: 0x00000030
\

$0000000f constant EXTI_VERR_MINREV                                 \ Minor revision
$000000f0 constant EXTI_VERR_MAJREV                                 \ Major revision


\
\ @brief AES identification register
\ Address offset: 0x3F8
\ Reset value: 0x000E0001
\

$00000000 constant EXTI_IPIDR_ID                                    \ Identification code


\
\ @brief AES size ID register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant EXTI_SIDR_ID                                     \ Size Identification code


\
\ @brief External interrupt/event controller
\
$40021800 constant EXTI_RTSR1     \ offset: 0x00 : EXTI rising trigger selection register
$40021804 constant EXTI_FTSR1     \ offset: 0x04 : EXTI falling trigger selection register
$40021808 constant EXTI_SWIER1    \ offset: 0x08 : EXTI software interrupt event register
$4002180c constant EXTI_RPR1      \ offset: 0x0C : EXTI rising edge pending register
$40021810 constant EXTI_FPR1      \ offset: 0x10 : EXTI falling edge pending register
$40021860 constant EXTI_EXTICR1   \ offset: 0x60 : EXTI external interrupt selection register
$40021864 constant EXTI_EXTICR2   \ offset: 0x64 : EXTI external interrupt selection register
$40021868 constant EXTI_EXTICR3   \ offset: 0x68 : EXTI external interrupt selection register
$4002186c constant EXTI_EXTICR4   \ offset: 0x6C : EXTI external interrupt selection register
$40021880 constant EXTI_IMR1      \ offset: 0x80 : EXTI CPU wakeup with interrupt mask register
$40021884 constant EXTI_EMR1      \ offset: 0x84 : EXTI CPU wakeup with event mask register
$40021890 constant EXTI_IMR2      \ offset: 0x90 : EXTI CPU wakeup with interrupt mask register
$40021894 constant EXTI_EMR2      \ offset: 0x94 : EXTI CPU wakeup with event mask register
$40021bd8 constant EXTI_HWCFGR7   \ offset: 0x3D8 : Hardware configuration registers
$40021bdc constant EXTI_HWCFGR6   \ offset: 0x3DC : Hardware configuration registers
$40021be0 constant EXTI_HWCFGR5   \ offset: 0x3E0 : Hardware configuration registers
$40021be4 constant EXTI_HWCFGR4   \ offset: 0x3E4 : Hardware configuration registers
$40021be8 constant EXTI_HWCFGR3   \ offset: 0x3E8 : Hardware configuration registers
$40021bec constant EXTI_HWCFGR2   \ offset: 0x3EC : Hardware configuration registers
$40021bf0 constant EXTI_HWCFGR1   \ offset: 0x3F0 : Hardware configuration registers
$40021bf4 constant EXTI_VERR      \ offset: 0x3F4 : AES version register
$40021bf8 constant EXTI_IPIDR     \ offset: 0x3F8 : AES identification register
$40021bfc constant EXTI_SIDR      \ offset: 0x3FC : AES size ID register

