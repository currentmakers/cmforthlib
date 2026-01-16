\
\ @file exti.fs
\ @brief EXTI
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Contains only register bits for configurable events.
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_RTSR1_RT0                              \ RT0
$00000002 constant EXTI_EXTI_RTSR1_RT1                              \ RT1
$00000004 constant EXTI_EXTI_RTSR1_RT2                              \ RT2
$00000008 constant EXTI_EXTI_RTSR1_RT3                              \ RT3
$00000010 constant EXTI_EXTI_RTSR1_RT4                              \ RT4
$00000020 constant EXTI_EXTI_RTSR1_RT5                              \ RT5
$00000040 constant EXTI_EXTI_RTSR1_RT6                              \ RT6
$00000080 constant EXTI_EXTI_RTSR1_RT7                              \ RT7
$00000100 constant EXTI_EXTI_RTSR1_RT8                              \ RT8
$00000200 constant EXTI_EXTI_RTSR1_RT9                              \ RT9
$00000400 constant EXTI_EXTI_RTSR1_RT10                             \ RT10
$00000800 constant EXTI_EXTI_RTSR1_RT11                             \ RT11
$00001000 constant EXTI_EXTI_RTSR1_RT12                             \ RT12
$00002000 constant EXTI_EXTI_RTSR1_RT13                             \ RT13
$00004000 constant EXTI_EXTI_RTSR1_RT14                             \ RT14
$00008000 constant EXTI_EXTI_RTSR1_RT15                             \ RT15
$00010000 constant EXTI_EXTI_RTSR1_RT16                             \ RT16


\
\ @brief Contains only register bits for configurable events.
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_FTSR1_FT0                              \ FT0
$00000002 constant EXTI_EXTI_FTSR1_FT1                              \ FT1
$00000004 constant EXTI_EXTI_FTSR1_FT2                              \ FT2
$00000008 constant EXTI_EXTI_FTSR1_FT3                              \ FT3
$00000010 constant EXTI_EXTI_FTSR1_FT4                              \ FT4
$00000020 constant EXTI_EXTI_FTSR1_FT5                              \ FT5
$00000040 constant EXTI_EXTI_FTSR1_FT6                              \ FT6
$00000080 constant EXTI_EXTI_FTSR1_FT7                              \ FT7
$00000100 constant EXTI_EXTI_FTSR1_FT8                              \ FT8
$00000200 constant EXTI_EXTI_FTSR1_FT9                              \ FT9
$00000400 constant EXTI_EXTI_FTSR1_FT10                             \ FT10
$00000800 constant EXTI_EXTI_FTSR1_FT11                             \ FT11
$00001000 constant EXTI_EXTI_FTSR1_FT12                             \ FT12
$00002000 constant EXTI_EXTI_FTSR1_FT13                             \ FT13
$00004000 constant EXTI_EXTI_FTSR1_FT14                             \ FT14
$00008000 constant EXTI_EXTI_FTSR1_FT15                             \ FT15
$00010000 constant EXTI_EXTI_FTSR1_FT16                             \ FT16


\
\ @brief Contains only register bits for configurable events.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_SWIER1_SWI0                            \ SWI0
$00000002 constant EXTI_EXTI_SWIER1_SWI1                            \ SWI1
$00000004 constant EXTI_EXTI_SWIER1_SWI2                            \ SWI2
$00000008 constant EXTI_EXTI_SWIER1_SWI3                            \ SWI3
$00000010 constant EXTI_EXTI_SWIER1_SWI4                            \ SWI4
$00000020 constant EXTI_EXTI_SWIER1_SWI5                            \ SWI5
$00000040 constant EXTI_EXTI_SWIER1_SWI6                            \ SWI6
$00000080 constant EXTI_EXTI_SWIER1_SWI7                            \ SWI7
$00000100 constant EXTI_EXTI_SWIER1_SWI8                            \ SWI8
$00000200 constant EXTI_EXTI_SWIER1_SWI9                            \ SWI9
$00000400 constant EXTI_EXTI_SWIER1_SWI10                           \ SWI10
$00000800 constant EXTI_EXTI_SWIER1_SWI11                           \ SWI11
$00001000 constant EXTI_EXTI_SWIER1_SWI12                           \ SWI12
$00002000 constant EXTI_EXTI_SWIER1_SWI13                           \ SWI13
$00004000 constant EXTI_EXTI_SWIER1_SWI14                           \ SWI14
$00008000 constant EXTI_EXTI_SWIER1_SWI15                           \ SWI15
$00010000 constant EXTI_EXTI_SWIER1_SWI16                           \ SWI16


\
\ @brief Contains only register bits for configurable events.
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_RPR1_RPIF0                             \ RPIF0
$00000002 constant EXTI_EXTI_RPR1_RPIF1                             \ RPIF1
$00000004 constant EXTI_EXTI_RPR1_RPIF2                             \ RPIF2
$00000008 constant EXTI_EXTI_RPR1_RPIF3                             \ RPIF3
$00000010 constant EXTI_EXTI_RPR1_RPIF4                             \ RPIF4
$00000020 constant EXTI_EXTI_RPR1_RPIF5                             \ RPIF5
$00000040 constant EXTI_EXTI_RPR1_RPIF6                             \ RPIF6
$00000080 constant EXTI_EXTI_RPR1_RPIF7                             \ RPIF7
$00000100 constant EXTI_EXTI_RPR1_RPIF8                             \ RPIF8
$00000200 constant EXTI_EXTI_RPR1_RPIF9                             \ RPIF9
$00000400 constant EXTI_EXTI_RPR1_RPIF10                            \ RPIF10
$00000800 constant EXTI_EXTI_RPR1_RPIF11                            \ RPIF11
$00001000 constant EXTI_EXTI_RPR1_RPIF12                            \ RPIF12
$00002000 constant EXTI_EXTI_RPR1_RPIF13                            \ RPIF13
$00004000 constant EXTI_EXTI_RPR1_RPIF14                            \ RPIF14
$00008000 constant EXTI_EXTI_RPR1_RPIF15                            \ RPIF15
$00010000 constant EXTI_EXTI_RPR1_RPIF16                            \ RPIF16


\
\ @brief Contains only register bits for configurable events.
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_FPR1_FPIF0                             \ FPIF0
$00000002 constant EXTI_EXTI_FPR1_FPIF1                             \ FPIF1
$00000004 constant EXTI_EXTI_FPR1_FPIF2                             \ FPIF2
$00000008 constant EXTI_EXTI_FPR1_FPIF3                             \ FPIF3
$00000010 constant EXTI_EXTI_FPR1_FPIF4                             \ FPIF4
$00000020 constant EXTI_EXTI_FPR1_FPIF5                             \ FPIF5
$00000040 constant EXTI_EXTI_FPR1_FPIF6                             \ FPIF6
$00000080 constant EXTI_EXTI_FPR1_FPIF7                             \ FPIF7
$00000100 constant EXTI_EXTI_FPR1_FPIF8                             \ FPIF8
$00000200 constant EXTI_EXTI_FPR1_FPIF9                             \ FPIF9
$00000400 constant EXTI_EXTI_FPR1_FPIF10                            \ FPIF10
$00000800 constant EXTI_EXTI_FPR1_FPIF11                            \ FPIF11
$00001000 constant EXTI_EXTI_FPR1_FPIF12                            \ FPIF12
$00002000 constant EXTI_EXTI_FPR1_FPIF13                            \ FPIF13
$00004000 constant EXTI_EXTI_FPR1_FPIF14                            \ FPIF14
$00008000 constant EXTI_EXTI_FPR1_FPIF15                            \ FPIF15
$00010000 constant EXTI_EXTI_FPR1_FPIF16                            \ FPIF16


\
\ @brief This register provides TrustZone Write access security, a non-secure write access will generate a bus error. A non-secure read will return the register data. Contains only register bits for TrustZone capable Input events.
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_TZENR1_TZEN0                           \ TZEN0
$00000002 constant EXTI_EXTI_TZENR1_TZEN1                           \ TZEN1
$00000004 constant EXTI_EXTI_TZENR1_TZEN2                           \ TZEN2
$00000008 constant EXTI_EXTI_TZENR1_TZEN3                           \ TZEN3
$00000010 constant EXTI_EXTI_TZENR1_TZEN4                           \ TZEN4
$00000020 constant EXTI_EXTI_TZENR1_TZEN5                           \ TZEN5
$00000040 constant EXTI_EXTI_TZENR1_TZEN6                           \ TZEN6
$00000080 constant EXTI_EXTI_TZENR1_TZEN7                           \ TZEN7
$00000100 constant EXTI_EXTI_TZENR1_TZEN8                           \ TZEN8
$00000200 constant EXTI_EXTI_TZENR1_TZEN9                           \ TZEN9
$00000400 constant EXTI_EXTI_TZENR1_TZEN10                          \ TZEN10
$00000800 constant EXTI_EXTI_TZENR1_TZEN11                          \ TZEN11
$00001000 constant EXTI_EXTI_TZENR1_TZEN12                          \ TZEN12
$00002000 constant EXTI_EXTI_TZENR1_TZEN13                          \ TZEN13
$00004000 constant EXTI_EXTI_TZENR1_TZEN14                          \ TZEN14
$00008000 constant EXTI_EXTI_TZENR1_TZEN15                          \ TZEN15
$00020000 constant EXTI_EXTI_TZENR1_TZEN17                          \ TZEN17
$00040000 constant EXTI_EXTI_TZENR1_TZEN18                          \ TZEN18
$00080000 constant EXTI_EXTI_TZENR1_TZEN19                          \ TZEN19
$01000000 constant EXTI_EXTI_TZENR1_TZEN24                          \ TZEN24
$04000000 constant EXTI_EXTI_TZENR1_TZEN26                          \ TZEN26


\
\ @brief Contains only register bits for configurable events.
\ Address offset: 0x20
\ Reset value: 0x00000000
\


\
\ @brief Contains only register bits for configurable events.
\ Address offset: 0x24
\ Reset value: 0x00000000
\


\
\ @brief Contains only register bits for configurable events.
\ Address offset: 0x28
\ Reset value: 0x00000000
\


\
\ @brief Contains only register bits for configurable events.
\ Address offset: 0x2C
\ Reset value: 0x00000000
\


\
\ @brief Contains only register bits for configurable events.
\ Address offset: 0x30
\ Reset value: 0x00000000
\


\
\ @brief This register provides TrustZone Write access security, a non-secure write access will generate a bus error. A non-secure read will return the register data. Contains only register bits for TrustZone capable Input events.
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000200 constant EXTI_EXTI_TZENR2_TZEN41                          \ TZEN41
$00400000 constant EXTI_EXTI_TZENR2_TZEN54                          \ TZEN54
$00800000 constant EXTI_EXTI_TZENR2_TZEN55                          \ TZEN55
$01000000 constant EXTI_EXTI_TZENR2_TZEN56                          \ TZEN56
$02000000 constant EXTI_EXTI_TZENR2_TZEN57                          \ TZEN57
$04000000 constant EXTI_EXTI_TZENR2_TZEN58                          \ TZEN58
$08000000 constant EXTI_EXTI_TZENR2_TZEN59                          \ TZEN59
$10000000 constant EXTI_EXTI_TZENR2_TZEN60                          \ TZEN60


\
\ @brief Contains only register bits for configurable events.
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000002 constant EXTI_EXTI_RTSR3_RT65                             \ RT65
$00000004 constant EXTI_EXTI_RTSR3_RT66                             \ RT66
$00000010 constant EXTI_EXTI_RTSR3_RT68                             \ RT68
$00000200 constant EXTI_EXTI_RTSR3_RT73                             \ RT73
$00000400 constant EXTI_EXTI_RTSR3_RT74                             \ RT74


\
\ @brief Contains only register bits for configurable events.
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000002 constant EXTI_EXTI_FTSR3_FT65                             \ FT65
$00000004 constant EXTI_EXTI_FTSR3_FT66                             \ FT66
$00000010 constant EXTI_EXTI_FTSR3_FT68                             \ FT68
$00000200 constant EXTI_EXTI_FTSR3_FT73                             \ FT73
$00000400 constant EXTI_EXTI_FTSR3_FT74                             \ FT74


\
\ @brief Contains only register bits for configurable events.
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000002 constant EXTI_EXTI_SWIER3_SWI65                           \ SWI65
$00000004 constant EXTI_EXTI_SWIER3_SWI66                           \ SWI66
$00000010 constant EXTI_EXTI_SWIER3_SWI68                           \ SWI68
$00000200 constant EXTI_EXTI_SWIER3_SWI73                           \ SWI73
$00000400 constant EXTI_EXTI_SWIER3_SWI74                           \ SWI74


\
\ @brief Contains only register bits for configurable events.
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000002 constant EXTI_EXTI_RPR3_RPIF65                            \ RPIF65
$00000004 constant EXTI_EXTI_RPR3_RPIF66                            \ RPIF66
$00000010 constant EXTI_EXTI_RPR3_RPIF68                            \ RPIF68
$00000200 constant EXTI_EXTI_RPR3_RPIF73                            \ RPIF73
$00000400 constant EXTI_EXTI_RPR3_RPIF74                            \ RPIF74


\
\ @brief Contains only register bits for configurable events.
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000002 constant EXTI_EXTI_FPR3_FPIF65                            \ FPIF65
$00000004 constant EXTI_EXTI_FPR3_FPIF66                            \ FPIF66
$00000010 constant EXTI_EXTI_FPR3_FPIF68                            \ FPIF68
$00000200 constant EXTI_EXTI_FPR3_FPIF73                            \ FPIF73
$00000400 constant EXTI_EXTI_FPR3_FPIF74                            \ FPIF74


\
\ @brief This register provides TrustZone Write access security, a non-secure write access will generate a bus error. A non-secure read will return the register data. Contains only register bits for TrustZone capable Input events.
\ Address offset: 0x54
\ Reset value: 0x00000000
\


\
\ @brief EXTIm fields contain only the number of bits in line with the nb_ioport configuration.
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$000000ff constant EXTI_EXTI_EXTICR1_EXTI0                          \ EXTI0
$0000ff00 constant EXTI_EXTI_EXTICR1_EXTI1                          \ EXTI1
$00ff0000 constant EXTI_EXTI_EXTICR1_EXTI2                          \ EXTI2
$ff000000 constant EXTI_EXTI_EXTICR1_EXTI3                          \ EXTI3


\
\ @brief EXTIm fields contain only the number of bits in line with the nb_ioport configuration.
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$000000ff constant EXTI_EXTI_EXTICR2_EXTI4                          \ EXTI4
$0000ff00 constant EXTI_EXTI_EXTICR2_EXTI5                          \ EXTI5
$00ff0000 constant EXTI_EXTI_EXTICR2_EXTI6                          \ EXTI6
$ff000000 constant EXTI_EXTI_EXTICR2_EXTI7                          \ EXTI7


\
\ @brief EXTIm fields contain only the number of bits in line with the nb_ioport configuration.
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$000000ff constant EXTI_EXTI_EXTICR3_EXTI8                          \ EXTI8
$0000ff00 constant EXTI_EXTI_EXTICR3_EXTI9                          \ EXTI9
$00ff0000 constant EXTI_EXTI_EXTICR3_EXTI10                         \ EXTI10
$ff000000 constant EXTI_EXTI_EXTICR3_EXTI11                         \ EXTI11


\
\ @brief EXTIm fields contain only the number of bits in line with the nb_ioport configuration.
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$000000ff constant EXTI_EXTI_EXTICR4_EXTI12                         \ EXTI12
$0000ff00 constant EXTI_EXTI_EXTICR4_EXTI13                         \ EXTI13
$00ff0000 constant EXTI_EXTI_EXTICR4_EXTI14                         \ EXTI14
$ff000000 constant EXTI_EXTI_EXTICR4_EXTI15                         \ EXTI15


\
\ @brief Contains register bits for configurable events and Direct events.
\ Address offset: 0x80
\ Reset value: 0xFFFE0000
\

$00000001 constant EXTI_EXTI_IMR1_IM0                               \ IM0
$00000002 constant EXTI_EXTI_IMR1_IM1                               \ IM1
$00000004 constant EXTI_EXTI_IMR1_IM2                               \ IM2
$00000008 constant EXTI_EXTI_IMR1_IM3                               \ IM3
$00000010 constant EXTI_EXTI_IMR1_IM4                               \ IM4
$00000020 constant EXTI_EXTI_IMR1_IM5                               \ IM5
$00000040 constant EXTI_EXTI_IMR1_IM6                               \ IM6
$00000080 constant EXTI_EXTI_IMR1_IM7                               \ IM7
$00000100 constant EXTI_EXTI_IMR1_IM8                               \ IM8
$00000200 constant EXTI_EXTI_IMR1_IM9                               \ IM9
$00000400 constant EXTI_EXTI_IMR1_IM10                              \ IM10
$00000800 constant EXTI_EXTI_IMR1_IM11                              \ IM11
$00001000 constant EXTI_EXTI_IMR1_IM12                              \ IM12
$00002000 constant EXTI_EXTI_IMR1_IM13                              \ IM13
$00004000 constant EXTI_EXTI_IMR1_IM14                              \ IM14
$00008000 constant EXTI_EXTI_IMR1_IM15                              \ IM15
$00010000 constant EXTI_EXTI_IMR1_IM16                              \ IM16
$00020000 constant EXTI_EXTI_IMR1_IM17                              \ IM17
$00040000 constant EXTI_EXTI_IMR1_IM18                              \ IM18
$00080000 constant EXTI_EXTI_IMR1_IM19                              \ IM19
$00100000 constant EXTI_EXTI_IMR1_IM20                              \ IM20
$00200000 constant EXTI_EXTI_IMR1_IM21                              \ IM21
$00400000 constant EXTI_EXTI_IMR1_IM22                              \ IM22
$00800000 constant EXTI_EXTI_IMR1_IM23                              \ IM23
$01000000 constant EXTI_EXTI_IMR1_IM24                              \ IM24
$02000000 constant EXTI_EXTI_IMR1_IM25                              \ IM25
$04000000 constant EXTI_EXTI_IMR1_IM26                              \ IM26
$08000000 constant EXTI_EXTI_IMR1_IM27                              \ IM27
$10000000 constant EXTI_EXTI_IMR1_IM28                              \ IM28
$20000000 constant EXTI_EXTI_IMR1_IM29                              \ IM29
$40000000 constant EXTI_EXTI_IMR1_IM30                              \ IM30
$80000000 constant EXTI_EXTI_IMR1_IM31                              \ IM31


\
\ @brief EXTI CPU wakeup with event mask register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_EMR1_EM0                               \ EM0
$00000002 constant EXTI_EXTI_EMR1_EM1                               \ EM1
$00000004 constant EXTI_EXTI_EMR1_EM2                               \ EM2
$00000008 constant EXTI_EXTI_EMR1_EM3                               \ EM3
$00000010 constant EXTI_EXTI_EMR1_EM4                               \ EM4
$00000020 constant EXTI_EXTI_EMR1_EM5                               \ EM5
$00000040 constant EXTI_EXTI_EMR1_EM6                               \ EM6
$00000080 constant EXTI_EXTI_EMR1_EM7                               \ EM7
$00000100 constant EXTI_EXTI_EMR1_EM8                               \ EM8
$00000200 constant EXTI_EXTI_EMR1_EM9                               \ EM9
$00000400 constant EXTI_EXTI_EMR1_EM10                              \ EM10
$00000800 constant EXTI_EXTI_EMR1_EM11                              \ EM11
$00001000 constant EXTI_EXTI_EMR1_EM12                              \ EM12
$00002000 constant EXTI_EXTI_EMR1_EM13                              \ EM13
$00004000 constant EXTI_EXTI_EMR1_EM14                              \ EM14
$00008000 constant EXTI_EXTI_EMR1_EM15                              \ EM15
$00020000 constant EXTI_EXTI_EMR1_EM17                              \ EM17
$00040000 constant EXTI_EXTI_EMR1_EM18                              \ EM18
$00080000 constant EXTI_EXTI_EMR1_EM19                              \ EM19


\
\ @brief Contains register bits for configurable events and direct events.
\ Address offset: 0x90
\ Reset value: 0xFFFFFFFF
\

$00000001 constant EXTI_EXTI_IMR2_IM32                              \ IM32
$00000002 constant EXTI_EXTI_IMR2_IM33                              \ IM33
$00000004 constant EXTI_EXTI_IMR2_IM34                              \ IM34
$00000008 constant EXTI_EXTI_IMR2_IM35                              \ IM35
$00000010 constant EXTI_EXTI_IMR2_IM36                              \ IM36
$00000020 constant EXTI_EXTI_IMR2_IM37                              \ IM37
$00000040 constant EXTI_EXTI_IMR2_IM38                              \ IM38
$00000080 constant EXTI_EXTI_IMR2_IM39                              \ IM39
$00000100 constant EXTI_EXTI_IMR2_IM40                              \ IM40
$00000200 constant EXTI_EXTI_IMR2_IM41                              \ IM41
$00000400 constant EXTI_EXTI_IMR2_IM42                              \ IM42
$00000800 constant EXTI_EXTI_IMR2_IM43                              \ IM43
$00001000 constant EXTI_EXTI_IMR2_IM44                              \ IM44
$00002000 constant EXTI_EXTI_IMR2_IM45                              \ IM45
$00004000 constant EXTI_EXTI_IMR2_IM46                              \ IM46
$00008000 constant EXTI_EXTI_IMR2_IM47                              \ IM47
$00010000 constant EXTI_EXTI_IMR2_IM48                              \ IM48
$00020000 constant EXTI_EXTI_IMR2_IM49                              \ IM49
$00040000 constant EXTI_EXTI_IMR2_IM50                              \ IM50
$00080000 constant EXTI_EXTI_IMR2_IM51                              \ IM51
$00100000 constant EXTI_EXTI_IMR2_IM52                              \ IM52
$00200000 constant EXTI_EXTI_IMR2_IM53                              \ IM53
$00400000 constant EXTI_EXTI_IMR2_IM54                              \ IM54
$00800000 constant EXTI_EXTI_IMR2_IM55                              \ IM55
$01000000 constant EXTI_EXTI_IMR2_IM56                              \ IM56
$02000000 constant EXTI_EXTI_IMR2_IM57                              \ IM57
$04000000 constant EXTI_EXTI_IMR2_IM58                              \ IM58
$08000000 constant EXTI_EXTI_IMR2_IM59                              \ IM59
$10000000 constant EXTI_EXTI_IMR2_IM60                              \ IM60
$20000000 constant EXTI_EXTI_IMR2_IM61                              \ IM61
$40000000 constant EXTI_EXTI_IMR2_IM62                              \ IM62
$80000000 constant EXTI_EXTI_IMR2_IM63                              \ IM63


\
\ @brief EXTI CPU wakeup with event mask register
\ Address offset: 0x94
\ Reset value: 0x00000000
\


\
\ @brief Contains register bits for configurable events and direct events.
\ Address offset: 0xA0
\ Reset value: 0x00000DE9
\

$00000001 constant EXTI_EXTI_IMR3_IM64                              \ IM64
$00000002 constant EXTI_EXTI_IMR3_IM65                              \ IM65
$00000004 constant EXTI_EXTI_IMR3_IM66                              \ IM66
$00000008 constant EXTI_EXTI_IMR3_IM67                              \ IM67
$00000010 constant EXTI_EXTI_IMR3_IM68                              \ IM68
$00000020 constant EXTI_EXTI_IMR3_IM69                              \ IM69
$00000040 constant EXTI_EXTI_IMR3_IM70                              \ IM70
$00000080 constant EXTI_EXTI_IMR3_IM71                              \ IM71
$00000100 constant EXTI_EXTI_IMR3_IM72                              \ IM72
$00000200 constant EXTI_EXTI_IMR3_IM73                              \ IM73
$00000400 constant EXTI_EXTI_IMR3_IM74                              \ IM74
$00000800 constant EXTI_EXTI_IMR3_IM75                              \ IM75


\
\ @brief EXTI CPU wakeup with event mask register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000004 constant EXTI_EXTI_EMR3_EM66                              \ EM66


\
\ @brief Contains register bits for configurable events and Direct events.
\ Address offset: 0xC0
\ Reset value: 0xFFFE0000
\

$00000001 constant EXTI_EXTI_C2IMR1_IM0                             \ IM0
$00000002 constant EXTI_EXTI_C2IMR1_IM1                             \ IM1
$00000004 constant EXTI_EXTI_C2IMR1_IM2                             \ IM2
$00000008 constant EXTI_EXTI_C2IMR1_IM3                             \ IM3
$00000010 constant EXTI_EXTI_C2IMR1_IM4                             \ IM4
$00000020 constant EXTI_EXTI_C2IMR1_IM5                             \ IM5
$00000040 constant EXTI_EXTI_C2IMR1_IM6                             \ IM6
$00000080 constant EXTI_EXTI_C2IMR1_IM7                             \ IM7
$00000100 constant EXTI_EXTI_C2IMR1_IM8                             \ IM8
$00000200 constant EXTI_EXTI_C2IMR1_IM9                             \ IM9
$00000400 constant EXTI_EXTI_C2IMR1_IM10                            \ IM10
$00000800 constant EXTI_EXTI_C2IMR1_IM11                            \ IM11
$00001000 constant EXTI_EXTI_C2IMR1_IM12                            \ IM12
$00002000 constant EXTI_EXTI_C2IMR1_IM13                            \ IM13
$00004000 constant EXTI_EXTI_C2IMR1_IM14                            \ IM14
$00008000 constant EXTI_EXTI_C2IMR1_IM15                            \ IM15
$00010000 constant EXTI_EXTI_C2IMR1_IM16                            \ IM16
$00020000 constant EXTI_EXTI_C2IMR1_IM17                            \ IM17
$00040000 constant EXTI_EXTI_C2IMR1_IM18                            \ IM18
$00080000 constant EXTI_EXTI_C2IMR1_IM19                            \ IM19
$00100000 constant EXTI_EXTI_C2IMR1_IM20                            \ IM20
$00200000 constant EXTI_EXTI_C2IMR1_IM21                            \ IM21
$00400000 constant EXTI_EXTI_C2IMR1_IM22                            \ IM22
$00800000 constant EXTI_EXTI_C2IMR1_IM23                            \ IM23
$01000000 constant EXTI_EXTI_C2IMR1_IM24                            \ IM24
$02000000 constant EXTI_EXTI_C2IMR1_IM25                            \ IM25
$04000000 constant EXTI_EXTI_C2IMR1_IM26                            \ IM26
$08000000 constant EXTI_EXTI_C2IMR1_IM27                            \ IM27
$10000000 constant EXTI_EXTI_C2IMR1_IM28                            \ IM28
$20000000 constant EXTI_EXTI_C2IMR1_IM29                            \ IM29
$40000000 constant EXTI_EXTI_C2IMR1_IM30                            \ IM30
$80000000 constant EXTI_EXTI_C2IMR1_IM31                            \ IM31


\
\ @brief EXTI CPU2 wakeup with event mask register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_C2EMR1_EM0                             \ EM0
$00000002 constant EXTI_EXTI_C2EMR1_EM1                             \ EM1
$00000004 constant EXTI_EXTI_C2EMR1_EM2                             \ EM2
$00000008 constant EXTI_EXTI_C2EMR1_EM3                             \ EM3
$00000010 constant EXTI_EXTI_C2EMR1_EM4                             \ EM4
$00000020 constant EXTI_EXTI_C2EMR1_EM5                             \ EM5
$00000040 constant EXTI_EXTI_C2EMR1_EM6                             \ EM6
$00000080 constant EXTI_EXTI_C2EMR1_EM7                             \ EM7
$00000100 constant EXTI_EXTI_C2EMR1_EM8                             \ EM8
$00000200 constant EXTI_EXTI_C2EMR1_EM9                             \ EM9
$00000400 constant EXTI_EXTI_C2EMR1_EM10                            \ EM10
$00000800 constant EXTI_EXTI_C2EMR1_EM11                            \ EM11
$00001000 constant EXTI_EXTI_C2EMR1_EM12                            \ EM12
$00002000 constant EXTI_EXTI_C2EMR1_EM13                            \ EM13
$00004000 constant EXTI_EXTI_C2EMR1_EM14                            \ EM14
$00008000 constant EXTI_EXTI_C2EMR1_EM15                            \ EM15
$00020000 constant EXTI_EXTI_C2EMR1_EM17                            \ EM17
$00040000 constant EXTI_EXTI_C2EMR1_EM18                            \ EM18
$00080000 constant EXTI_EXTI_C2EMR1_EM19                            \ EM19


\
\ @brief Contains register bits for configurable events and direct events.
\ Address offset: 0xD0
\ Reset value: 0xFFFFFFFF
\

$00000001 constant EXTI_EXTI_C2IMR2_IM32                            \ IM32
$00000002 constant EXTI_EXTI_C2IMR2_IM33                            \ IM33
$00000004 constant EXTI_EXTI_C2IMR2_IM34                            \ IM34
$00000008 constant EXTI_EXTI_C2IMR2_IM35                            \ IM35
$00000010 constant EXTI_EXTI_C2IMR2_IM36                            \ IM36
$00000020 constant EXTI_EXTI_C2IMR2_IM37                            \ IM37
$00000040 constant EXTI_EXTI_C2IMR2_IM38                            \ IM38
$00000080 constant EXTI_EXTI_C2IMR2_IM39                            \ IM39
$00000100 constant EXTI_EXTI_C2IMR2_IM40                            \ IM40
$00000200 constant EXTI_EXTI_C2IMR2_IM41                            \ IM41
$00000400 constant EXTI_EXTI_C2IMR2_IM42                            \ IM42
$00000800 constant EXTI_EXTI_C2IMR2_IM43                            \ IM43
$00001000 constant EXTI_EXTI_C2IMR2_IM44                            \ IM44
$00002000 constant EXTI_EXTI_C2IMR2_IM45                            \ IM45
$00004000 constant EXTI_EXTI_C2IMR2_IM46                            \ IM46
$00008000 constant EXTI_EXTI_C2IMR2_IM47                            \ IM47
$00010000 constant EXTI_EXTI_C2IMR2_IM48                            \ IM48
$00020000 constant EXTI_EXTI_C2IMR2_IM49                            \ IM49
$00040000 constant EXTI_EXTI_C2IMR2_IM50                            \ IM50
$00080000 constant EXTI_EXTI_C2IMR2_IM51                            \ IM51
$00100000 constant EXTI_EXTI_C2IMR2_IM52                            \ IM52
$00200000 constant EXTI_EXTI_C2IMR2_IM53                            \ IM53
$00400000 constant EXTI_EXTI_C2IMR2_IM54                            \ IM54
$00800000 constant EXTI_EXTI_C2IMR2_IM55                            \ IM55
$01000000 constant EXTI_EXTI_C2IMR2_IM56                            \ IM56
$02000000 constant EXTI_EXTI_C2IMR2_IM57                            \ IM57
$04000000 constant EXTI_EXTI_C2IMR2_IM58                            \ IM58
$08000000 constant EXTI_EXTI_C2IMR2_IM59                            \ IM59
$10000000 constant EXTI_EXTI_C2IMR2_IM60                            \ IM60
$20000000 constant EXTI_EXTI_C2IMR2_IM61                            \ IM61
$40000000 constant EXTI_EXTI_C2IMR2_IM62                            \ IM62
$80000000 constant EXTI_EXTI_C2IMR2_IM63                            \ IM63


\
\ @brief EXTI CPU2 wakeup with event mask register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\


\
\ @brief Contains register bits for configurable events and direct events.
\ Address offset: 0xE0
\ Reset value: 0x00000DE9
\

$00000001 constant EXTI_EXTI_C2IMR3_IM64                            \ IM64
$00000002 constant EXTI_EXTI_C2IMR3_IM65                            \ IM65
$00000004 constant EXTI_EXTI_C2IMR3_IM66                            \ IM66
$00000008 constant EXTI_EXTI_C2IMR3_IM67                            \ IM67
$00000010 constant EXTI_EXTI_C2IMR3_IM68                            \ IM68
$00000020 constant EXTI_EXTI_C2IMR3_IM69                            \ IM69
$00000040 constant EXTI_EXTI_C2IMR3_IM70                            \ IM70
$00000080 constant EXTI_EXTI_C2IMR3_IM71                            \ IM71
$00000100 constant EXTI_EXTI_C2IMR3_IM72                            \ IM72
$00000200 constant EXTI_EXTI_C2IMR3_IM73                            \ IM73
$00000400 constant EXTI_EXTI_C2IMR3_IM74                            \ IM74
$00000800 constant EXTI_EXTI_C2IMR3_IM75                            \ IM75


\
\ @brief EXTI CPU2 wakeup with event mask register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000004 constant EXTI_EXTI_C2EMR3_EM66                            \ EM66


\
\ @brief EXTI hardware configuration register 13
\ Address offset: 0x3C0
\ Reset value: 0x050EFFFF
\

$00000000 constant EXTI_EXTI_HWCFGR13_TZ                            \ TZ


\
\ @brief EXTI hardware configuration register 12
\ Address offset: 0x3C4
\ Reset value: 0x050EFFFF
\

$00000000 constant EXTI_EXTI_HWCFGR12_TZ                            \ TZ


\
\ @brief EXTI hardware configuration register 11
\ Address offset: 0x3C8
\ Reset value: 0x050EFFFF
\

$00000000 constant EXTI_EXTI_HWCFGR11_TZ                            \ TZ


\
\ @brief EXTI hardware configuration register 10
\ Address offset: 0x3CC
\ Reset value: 0x00000000
\


\
\ @brief EXTI hardware configuration register 9
\ Address offset: 0x3D0
\ Reset value: 0x00000000
\


\
\ @brief EXTI hardware configuration register 8
\ Address offset: 0x3D4
\ Reset value: 0x00000000
\


\
\ @brief EXTI hardware configuration register 7
\ Address offset: 0x3D8
\ Reset value: 0x000EFFFF
\

$00000000 constant EXTI_EXTI_HWCFGR7_CPUEVENT                       \ CPUEVENT


\
\ @brief EXTI hardware configuration register 6
\ Address offset: 0x3DC
\ Reset value: 0x000EFFFF
\

$00000000 constant EXTI_EXTI_HWCFGR6_CPUEVENT                       \ CPUEVENT


\
\ @brief EXTI hardware configuration register 5
\ Address offset: 0x3E0
\ Reset value: 0x000EFFFF
\

$00000000 constant EXTI_EXTI_HWCFGR5_CPUEVENT                       \ CPUEVENT


\
\ @brief EXTI hardware configuration register 4
\ Address offset: 0x3E4
\ Reset value: 0x0001FFFF
\

$00000000 constant EXTI_EXTI_HWCFGR4_EVENT_TRG                      \ EVENT_TRG


\
\ @brief EXTI hardware configuration register 3
\ Address offset: 0x3E8
\ Reset value: 0x0001FFFF
\

$00000000 constant EXTI_EXTI_HWCFGR3_EVENT_TRG                      \ EVENT_TRG


\
\ @brief EXTI hardware configuration register 2
\ Address offset: 0x3EC
\ Reset value: 0x0001FFFF
\

$00000000 constant EXTI_EXTI_HWCFGR2_EVENT_TRG                      \ EVENT_TRG


\
\ @brief EXTI hardware configuration register 1
\ Address offset: 0x3F0
\ Reset value: 0x000B214B
\

$000000ff constant EXTI_EXTI_HWCFGR1_NBEVENTS                       \ NBEVENTS
$00000f00 constant EXTI_EXTI_HWCFGR1_NBCPUS                         \ NBCPUS
$0000f000 constant EXTI_EXTI_HWCFGR1_CPUEVTEN                       \ CPUEVTEN
$00ff0000 constant EXTI_EXTI_HWCFGR1_NBIOPORT                       \ NBIOPORT


\
\ @brief EXTI IP version register
\ Address offset: 0x3F4
\ Reset value: 0x00000030
\

$0000000f constant EXTI_EXTI_VERR_MINREV                            \ MINREV
$000000f0 constant EXTI_EXTI_VERR_MAJREV                            \ MAJREV


\
\ @brief EXTI identification register
\ Address offset: 0x3F8
\ Reset value: 0x000E0001
\

$00000000 constant EXTI_EXTI_IPIDR_IPID                             \ IPID


\
\ @brief EXTI size ID register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant EXTI_EXTI_SIDR_SID                               \ SID


\
\ @brief EXTI
\
$5000d000 constant EXTI_EXTI_RTSR1  \ offset: 0x00 : Contains only register bits for configurable events.
$5000d004 constant EXTI_EXTI_FTSR1  \ offset: 0x04 : Contains only register bits for configurable events.
$5000d008 constant EXTI_EXTI_SWIER1  \ offset: 0x08 : Contains only register bits for configurable events.
$5000d00c constant EXTI_EXTI_RPR1  \ offset: 0x0C : Contains only register bits for configurable events.
$5000d010 constant EXTI_EXTI_FPR1  \ offset: 0x10 : Contains only register bits for configurable events.
$5000d014 constant EXTI_EXTI_TZENR1  \ offset: 0x14 : This register provides TrustZone Write access security, a non-secure write access will generate a bus error. A non-secure read will return the register data. Contains only register bits for TrustZone capable Input events.
$5000d020 constant EXTI_EXTI_RTSR2  \ offset: 0x20 : Contains only register bits for configurable events.
$5000d024 constant EXTI_EXTI_FTSR2  \ offset: 0x24 : Contains only register bits for configurable events.
$5000d028 constant EXTI_EXTI_SWIER2  \ offset: 0x28 : Contains only register bits for configurable events.
$5000d02c constant EXTI_EXTI_RPR2  \ offset: 0x2C : Contains only register bits for configurable events.
$5000d030 constant EXTI_EXTI_FPR2  \ offset: 0x30 : Contains only register bits for configurable events.
$5000d034 constant EXTI_EXTI_TZENR2  \ offset: 0x34 : This register provides TrustZone Write access security, a non-secure write access will generate a bus error. A non-secure read will return the register data. Contains only register bits for TrustZone capable Input events.
$5000d040 constant EXTI_EXTI_RTSR3  \ offset: 0x40 : Contains only register bits for configurable events.
$5000d044 constant EXTI_EXTI_FTSR3  \ offset: 0x44 : Contains only register bits for configurable events.
$5000d048 constant EXTI_EXTI_SWIER3  \ offset: 0x48 : Contains only register bits for configurable events.
$5000d04c constant EXTI_EXTI_RPR3  \ offset: 0x4C : Contains only register bits for configurable events.
$5000d050 constant EXTI_EXTI_FPR3  \ offset: 0x50 : Contains only register bits for configurable events.
$5000d054 constant EXTI_EXTI_TZENR3  \ offset: 0x54 : This register provides TrustZone Write access security, a non-secure write access will generate a bus error. A non-secure read will return the register data. Contains only register bits for TrustZone capable Input events.
$5000d060 constant EXTI_EXTI_EXTICR1  \ offset: 0x60 : EXTIm fields contain only the number of bits in line with the nb_ioport configuration.
$5000d064 constant EXTI_EXTI_EXTICR2  \ offset: 0x64 : EXTIm fields contain only the number of bits in line with the nb_ioport configuration.
$5000d068 constant EXTI_EXTI_EXTICR3  \ offset: 0x68 : EXTIm fields contain only the number of bits in line with the nb_ioport configuration.
$5000d06c constant EXTI_EXTI_EXTICR4  \ offset: 0x6C : EXTIm fields contain only the number of bits in line with the nb_ioport configuration.
$5000d080 constant EXTI_EXTI_IMR1  \ offset: 0x80 : Contains register bits for configurable events and Direct events.
$5000d084 constant EXTI_EXTI_EMR1  \ offset: 0x84 : EXTI CPU wakeup with event mask register
$5000d090 constant EXTI_EXTI_IMR2  \ offset: 0x90 : Contains register bits for configurable events and direct events.
$5000d094 constant EXTI_EXTI_EMR2  \ offset: 0x94 : EXTI CPU wakeup with event mask register
$5000d0a0 constant EXTI_EXTI_IMR3  \ offset: 0xA0 : Contains register bits for configurable events and direct events.
$5000d0a4 constant EXTI_EXTI_EMR3  \ offset: 0xA4 : EXTI CPU wakeup with event mask register
$5000d0c0 constant EXTI_EXTI_C2IMR1  \ offset: 0xC0 : Contains register bits for configurable events and Direct events.
$5000d0c4 constant EXTI_EXTI_C2EMR1  \ offset: 0xC4 : EXTI CPU2 wakeup with event mask register
$5000d0d0 constant EXTI_EXTI_C2IMR2  \ offset: 0xD0 : Contains register bits for configurable events and direct events.
$5000d0d4 constant EXTI_EXTI_C2EMR2  \ offset: 0xD4 : EXTI CPU2 wakeup with event mask register
$5000d0e0 constant EXTI_EXTI_C2IMR3  \ offset: 0xE0 : Contains register bits for configurable events and direct events.
$5000d0e4 constant EXTI_EXTI_C2EMR3  \ offset: 0xE4 : EXTI CPU2 wakeup with event mask register
$5000d3c0 constant EXTI_EXTI_HWCFGR13  \ offset: 0x3C0 : EXTI hardware configuration register 13
$5000d3c4 constant EXTI_EXTI_HWCFGR12  \ offset: 0x3C4 : EXTI hardware configuration register 12
$5000d3c8 constant EXTI_EXTI_HWCFGR11  \ offset: 0x3C8 : EXTI hardware configuration register 11
$5000d3cc constant EXTI_EXTI_HWCFGR10  \ offset: 0x3CC : EXTI hardware configuration register 10
$5000d3d0 constant EXTI_EXTI_HWCFGR9  \ offset: 0x3D0 : EXTI hardware configuration register 9
$5000d3d4 constant EXTI_EXTI_HWCFGR8  \ offset: 0x3D4 : EXTI hardware configuration register 8
$5000d3d8 constant EXTI_EXTI_HWCFGR7  \ offset: 0x3D8 : EXTI hardware configuration register 7
$5000d3dc constant EXTI_EXTI_HWCFGR6  \ offset: 0x3DC : EXTI hardware configuration register 6
$5000d3e0 constant EXTI_EXTI_HWCFGR5  \ offset: 0x3E0 : EXTI hardware configuration register 5
$5000d3e4 constant EXTI_EXTI_HWCFGR4  \ offset: 0x3E4 : EXTI hardware configuration register 4
$5000d3e8 constant EXTI_EXTI_HWCFGR3  \ offset: 0x3E8 : EXTI hardware configuration register 3
$5000d3ec constant EXTI_EXTI_HWCFGR2  \ offset: 0x3EC : EXTI hardware configuration register 2
$5000d3f0 constant EXTI_EXTI_HWCFGR1  \ offset: 0x3F0 : EXTI hardware configuration register 1
$5000d3f4 constant EXTI_EXTI_VERR  \ offset: 0x3F4 : EXTI IP version register
$5000d3f8 constant EXTI_EXTI_IPIDR  \ offset: 0x3F8 : EXTI identification register
$5000d3fc constant EXTI_EXTI_SIDR  \ offset: 0x3FC : EXTI size ID register

