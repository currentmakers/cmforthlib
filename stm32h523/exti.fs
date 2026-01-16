\
\ @file exti.fs
\ @brief EXTI address block description
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

$00000001 constant EXTI_EXTI_RTSR1_RT0                              \ Rising trigger event configuration bit of configurable event input x
$00000002 constant EXTI_EXTI_RTSR1_RT1                              \ Rising trigger event configuration bit of configurable event input x
$00000004 constant EXTI_EXTI_RTSR1_RT2                              \ Rising trigger event configuration bit of configurable event input x
$00000008 constant EXTI_EXTI_RTSR1_RT3                              \ Rising trigger event configuration bit of configurable event input x
$00000010 constant EXTI_EXTI_RTSR1_RT4                              \ Rising trigger event configuration bit of configurable event input x
$00000020 constant EXTI_EXTI_RTSR1_RT5                              \ Rising trigger event configuration bit of configurable event input x
$00000040 constant EXTI_EXTI_RTSR1_RT6                              \ Rising trigger event configuration bit of configurable event input x
$00000080 constant EXTI_EXTI_RTSR1_RT7                              \ Rising trigger event configuration bit of configurable event input x
$00000100 constant EXTI_EXTI_RTSR1_RT8                              \ Rising trigger event configuration bit of configurable event input x
$00000200 constant EXTI_EXTI_RTSR1_RT9                              \ Rising trigger event configuration bit of configurable event input x
$00000400 constant EXTI_EXTI_RTSR1_RT10                             \ Rising trigger event configuration bit of configurable event input x
$00000800 constant EXTI_EXTI_RTSR1_RT11                             \ Rising trigger event configuration bit of configurable event input x
$00001000 constant EXTI_EXTI_RTSR1_RT12                             \ Rising trigger event configuration bit of configurable event input x
$00002000 constant EXTI_EXTI_RTSR1_RT13                             \ Rising trigger event configuration bit of configurable event input x
$00004000 constant EXTI_EXTI_RTSR1_RT14                             \ Rising trigger event configuration bit of configurable event input x
$00008000 constant EXTI_EXTI_RTSR1_RT15                             \ Rising trigger event configuration bit of configurable event input x
$00010000 constant EXTI_EXTI_RTSR1_RT16                             \ Rising trigger event configuration bit of configurable event input x


\
\ @brief EXTI falling trigger selection register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_FTSR1_FT0                              \ Falling trigger event configuration bit of configurable event input x
$00000002 constant EXTI_EXTI_FTSR1_FT1                              \ Falling trigger event configuration bit of configurable event input x
$00000004 constant EXTI_EXTI_FTSR1_FT2                              \ Falling trigger event configuration bit of configurable event input x
$00000008 constant EXTI_EXTI_FTSR1_FT3                              \ Falling trigger event configuration bit of configurable event input x
$00000010 constant EXTI_EXTI_FTSR1_FT4                              \ Falling trigger event configuration bit of configurable event input x
$00000020 constant EXTI_EXTI_FTSR1_FT5                              \ Falling trigger event configuration bit of configurable event input x
$00000040 constant EXTI_EXTI_FTSR1_FT6                              \ Falling trigger event configuration bit of configurable event input x
$00000080 constant EXTI_EXTI_FTSR1_FT7                              \ Falling trigger event configuration bit of configurable event input x
$00000100 constant EXTI_EXTI_FTSR1_FT8                              \ Falling trigger event configuration bit of configurable event input x
$00000200 constant EXTI_EXTI_FTSR1_FT9                              \ Falling trigger event configuration bit of configurable event input x
$00000400 constant EXTI_EXTI_FTSR1_FT10                             \ Falling trigger event configuration bit of configurable event input x
$00000800 constant EXTI_EXTI_FTSR1_FT11                             \ Falling trigger event configuration bit of configurable event input x
$00001000 constant EXTI_EXTI_FTSR1_FT12                             \ Falling trigger event configuration bit of configurable event input x
$00002000 constant EXTI_EXTI_FTSR1_FT13                             \ Falling trigger event configuration bit of configurable event input x
$00004000 constant EXTI_EXTI_FTSR1_FT14                             \ Falling trigger event configuration bit of configurable event input x
$00008000 constant EXTI_EXTI_FTSR1_FT15                             \ Falling trigger event configuration bit of configurable event input x
$00010000 constant EXTI_EXTI_FTSR1_FT16                             \ Falling trigger event configuration bit of configurable event input x


\
\ @brief EXTI software interrupt event register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_SWIER1_SWI0                            \ Software interrupt on event x
$00000002 constant EXTI_EXTI_SWIER1_SWI1                            \ Software interrupt on event x
$00000004 constant EXTI_EXTI_SWIER1_SWI2                            \ Software interrupt on event x
$00000008 constant EXTI_EXTI_SWIER1_SWI3                            \ Software interrupt on event x
$00000010 constant EXTI_EXTI_SWIER1_SWI4                            \ Software interrupt on event x
$00000020 constant EXTI_EXTI_SWIER1_SWI5                            \ Software interrupt on event x
$00000040 constant EXTI_EXTI_SWIER1_SWI6                            \ Software interrupt on event x
$00000080 constant EXTI_EXTI_SWIER1_SWI7                            \ Software interrupt on event x
$00000100 constant EXTI_EXTI_SWIER1_SWI8                            \ Software interrupt on event x
$00000200 constant EXTI_EXTI_SWIER1_SWI9                            \ Software interrupt on event x
$00000400 constant EXTI_EXTI_SWIER1_SWI10                           \ Software interrupt on event x
$00000800 constant EXTI_EXTI_SWIER1_SWI11                           \ Software interrupt on event x
$00001000 constant EXTI_EXTI_SWIER1_SWI12                           \ Software interrupt on event x
$00002000 constant EXTI_EXTI_SWIER1_SWI13                           \ Software interrupt on event x
$00004000 constant EXTI_EXTI_SWIER1_SWI14                           \ Software interrupt on event x
$00008000 constant EXTI_EXTI_SWIER1_SWI15                           \ Software interrupt on event x
$00010000 constant EXTI_EXTI_SWIER1_SWI16                           \ Software interrupt on event x


\
\ @brief EXTI rising edge pending register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_RPR1_RPIF0                             \ configurable event inputs x rising edge pending bit
$00000002 constant EXTI_EXTI_RPR1_RPIF1                             \ configurable event inputs x rising edge pending bit
$00000004 constant EXTI_EXTI_RPR1_RPIF2                             \ configurable event inputs x rising edge pending bit
$00000008 constant EXTI_EXTI_RPR1_RPIF3                             \ configurable event inputs x rising edge pending bit
$00000010 constant EXTI_EXTI_RPR1_RPIF4                             \ configurable event inputs x rising edge pending bit
$00000020 constant EXTI_EXTI_RPR1_RPIF5                             \ configurable event inputs x rising edge pending bit
$00000040 constant EXTI_EXTI_RPR1_RPIF6                             \ configurable event inputs x rising edge pending bit
$00000080 constant EXTI_EXTI_RPR1_RPIF7                             \ configurable event inputs x rising edge pending bit
$00000100 constant EXTI_EXTI_RPR1_RPIF8                             \ configurable event inputs x rising edge pending bit
$00000200 constant EXTI_EXTI_RPR1_RPIF9                             \ configurable event inputs x rising edge pending bit
$00000400 constant EXTI_EXTI_RPR1_RPIF10                            \ configurable event inputs x rising edge pending bit
$00000800 constant EXTI_EXTI_RPR1_RPIF11                            \ configurable event inputs x rising edge pending bit
$00001000 constant EXTI_EXTI_RPR1_RPIF12                            \ configurable event inputs x rising edge pending bit
$00002000 constant EXTI_EXTI_RPR1_RPIF13                            \ configurable event inputs x rising edge pending bit
$00004000 constant EXTI_EXTI_RPR1_RPIF14                            \ configurable event inputs x rising edge pending bit
$00008000 constant EXTI_EXTI_RPR1_RPIF15                            \ configurable event inputs x rising edge pending bit
$00010000 constant EXTI_EXTI_RPR1_RPIF16                            \ configurable event inputs x rising edge pending bit


\
\ @brief EXTI falling edge pending register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_FPR1_FPIF0                             \ configurable event inputs x falling edge pending bit
$00000002 constant EXTI_EXTI_FPR1_FPIF1                             \ configurable event inputs x falling edge pending bit
$00000004 constant EXTI_EXTI_FPR1_FPIF2                             \ configurable event inputs x falling edge pending bit
$00000008 constant EXTI_EXTI_FPR1_FPIF3                             \ configurable event inputs x falling edge pending bit
$00000010 constant EXTI_EXTI_FPR1_FPIF4                             \ configurable event inputs x falling edge pending bit
$00000020 constant EXTI_EXTI_FPR1_FPIF5                             \ configurable event inputs x falling edge pending bit
$00000040 constant EXTI_EXTI_FPR1_FPIF6                             \ configurable event inputs x falling edge pending bit
$00000080 constant EXTI_EXTI_FPR1_FPIF7                             \ configurable event inputs x falling edge pending bit
$00000100 constant EXTI_EXTI_FPR1_FPIF8                             \ configurable event inputs x falling edge pending bit
$00000200 constant EXTI_EXTI_FPR1_FPIF9                             \ configurable event inputs x falling edge pending bit
$00000400 constant EXTI_EXTI_FPR1_FPIF10                            \ configurable event inputs x falling edge pending bit
$00000800 constant EXTI_EXTI_FPR1_FPIF11                            \ configurable event inputs x falling edge pending bit
$00001000 constant EXTI_EXTI_FPR1_FPIF12                            \ configurable event inputs x falling edge pending bit
$00002000 constant EXTI_EXTI_FPR1_FPIF13                            \ configurable event inputs x falling edge pending bit
$00004000 constant EXTI_EXTI_FPR1_FPIF14                            \ configurable event inputs x falling edge pending bit
$00008000 constant EXTI_EXTI_FPR1_FPIF15                            \ configurable event inputs x falling edge pending bit
$00010000 constant EXTI_EXTI_FPR1_FPIF16                            \ configurable event inputs x falling edge pending bit


\
\ @brief EXTI security configuration register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_SECCFGR1_SEC0                          \ Security enable on event input x
$00000002 constant EXTI_EXTI_SECCFGR1_SEC1                          \ Security enable on event input x
$00000004 constant EXTI_EXTI_SECCFGR1_SEC2                          \ Security enable on event input x
$00000008 constant EXTI_EXTI_SECCFGR1_SEC3                          \ Security enable on event input x
$00000010 constant EXTI_EXTI_SECCFGR1_SEC4                          \ Security enable on event input x
$00000020 constant EXTI_EXTI_SECCFGR1_SEC5                          \ Security enable on event input x
$00000040 constant EXTI_EXTI_SECCFGR1_SEC6                          \ Security enable on event input x
$00000080 constant EXTI_EXTI_SECCFGR1_SEC7                          \ Security enable on event input x
$00000100 constant EXTI_EXTI_SECCFGR1_SEC8                          \ Security enable on event input x
$00000200 constant EXTI_EXTI_SECCFGR1_SEC9                          \ Security enable on event input x
$00000400 constant EXTI_EXTI_SECCFGR1_SEC10                         \ Security enable on event input x
$00000800 constant EXTI_EXTI_SECCFGR1_SEC11                         \ Security enable on event input x
$00001000 constant EXTI_EXTI_SECCFGR1_SEC12                         \ Security enable on event input x
$00002000 constant EXTI_EXTI_SECCFGR1_SEC13                         \ Security enable on event input x
$00004000 constant EXTI_EXTI_SECCFGR1_SEC14                         \ Security enable on event input x
$00008000 constant EXTI_EXTI_SECCFGR1_SEC15                         \ Security enable on event input x
$00010000 constant EXTI_EXTI_SECCFGR1_SEC16                         \ Security enable on event input x
$00020000 constant EXTI_EXTI_SECCFGR1_SEC17                         \ Security enable on event input x
$00040000 constant EXTI_EXTI_SECCFGR1_SEC18                         \ Security enable on event input x
$00080000 constant EXTI_EXTI_SECCFGR1_SEC19                         \ Security enable on event input x
$00100000 constant EXTI_EXTI_SECCFGR1_SEC20                         \ Security enable on event input x
$00200000 constant EXTI_EXTI_SECCFGR1_SEC21                         \ Security enable on event input x
$00400000 constant EXTI_EXTI_SECCFGR1_SEC22                         \ Security enable on event input x
$00800000 constant EXTI_EXTI_SECCFGR1_SEC23                         \ Security enable on event input x
$01000000 constant EXTI_EXTI_SECCFGR1_SEC24                         \ Security enable on event input x
$02000000 constant EXTI_EXTI_SECCFGR1_SEC25                         \ Security enable on event input x
$04000000 constant EXTI_EXTI_SECCFGR1_SEC26                         \ Security enable on event input x
$08000000 constant EXTI_EXTI_SECCFGR1_SEC27                         \ Security enable on event input x
$10000000 constant EXTI_EXTI_SECCFGR1_SEC28                         \ Security enable on event input x
$20000000 constant EXTI_EXTI_SECCFGR1_SEC29                         \ Security enable on event input x
$40000000 constant EXTI_EXTI_SECCFGR1_SEC30                         \ Security enable on event input x
$80000000 constant EXTI_EXTI_SECCFGR1_SEC31                         \ Security enable on event input x


\
\ @brief EXTI privilege configuration register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_PRIVCFGR1_PRIV0                        \ Security enable on event input x
$00000002 constant EXTI_EXTI_PRIVCFGR1_PRIV1                        \ Security enable on event input x
$00000004 constant EXTI_EXTI_PRIVCFGR1_PRIV2                        \ Security enable on event input x
$00000008 constant EXTI_EXTI_PRIVCFGR1_PRIV3                        \ Security enable on event input x
$00000010 constant EXTI_EXTI_PRIVCFGR1_PRIV4                        \ Security enable on event input x
$00000020 constant EXTI_EXTI_PRIVCFGR1_PRIV5                        \ Security enable on event input x
$00000040 constant EXTI_EXTI_PRIVCFGR1_PRIV6                        \ Security enable on event input x
$00000080 constant EXTI_EXTI_PRIVCFGR1_PRIV7                        \ Security enable on event input x
$00000100 constant EXTI_EXTI_PRIVCFGR1_PRIV8                        \ Security enable on event input x
$00000200 constant EXTI_EXTI_PRIVCFGR1_PRIV9                        \ Security enable on event input x
$00000400 constant EXTI_EXTI_PRIVCFGR1_PRIV10                       \ Security enable on event input x
$00000800 constant EXTI_EXTI_PRIVCFGR1_PRIV11                       \ Security enable on event input x
$00001000 constant EXTI_EXTI_PRIVCFGR1_PRIV12                       \ Security enable on event input x
$00002000 constant EXTI_EXTI_PRIVCFGR1_PRIV13                       \ Security enable on event input x
$00004000 constant EXTI_EXTI_PRIVCFGR1_PRIV14                       \ Security enable on event input x
$00008000 constant EXTI_EXTI_PRIVCFGR1_PRIV15                       \ Security enable on event input x
$00010000 constant EXTI_EXTI_PRIVCFGR1_PRIV16                       \ Security enable on event input x
$00020000 constant EXTI_EXTI_PRIVCFGR1_PRIV17                       \ Security enable on event input x
$00040000 constant EXTI_EXTI_PRIVCFGR1_PRIV18                       \ Security enable on event input x
$00080000 constant EXTI_EXTI_PRIVCFGR1_PRIV19                       \ Security enable on event input x
$00100000 constant EXTI_EXTI_PRIVCFGR1_PRIV20                       \ Security enable on event input x
$00200000 constant EXTI_EXTI_PRIVCFGR1_PRIV21                       \ Security enable on event input x
$00400000 constant EXTI_EXTI_PRIVCFGR1_PRIV22                       \ Security enable on event input x
$00800000 constant EXTI_EXTI_PRIVCFGR1_PRIV23                       \ Security enable on event input x
$01000000 constant EXTI_EXTI_PRIVCFGR1_PRIV24                       \ Security enable on event input x
$02000000 constant EXTI_EXTI_PRIVCFGR1_PRIV25                       \ Security enable on event input x
$04000000 constant EXTI_EXTI_PRIVCFGR1_PRIV26                       \ Security enable on event input x
$08000000 constant EXTI_EXTI_PRIVCFGR1_PRIV27                       \ Security enable on event input x
$10000000 constant EXTI_EXTI_PRIVCFGR1_PRIV28                       \ Security enable on event input x
$20000000 constant EXTI_EXTI_PRIVCFGR1_PRIV29                       \ Security enable on event input x
$40000000 constant EXTI_EXTI_PRIVCFGR1_PRIV30                       \ Security enable on event input x
$80000000 constant EXTI_EXTI_PRIVCFGR1_PRIV31                       \ Security enable on event input x


\
\ @brief EXTI rising trigger selection register 2
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00004000 constant EXTI_EXTI_RTSR2_RT46                             \ Rising trigger event configuration bit of configurable event input xless thansup>(1)less than/sup>
$00040000 constant EXTI_EXTI_RTSR2_RT50                             \ Rising trigger event configuration bit of configurable event input xless thansup>(1)less than/sup>
$00200000 constant EXTI_EXTI_RTSR2_RT53                             \ Rising trigger event configuration bit of configurable event input x


\
\ @brief EXTI falling trigger selection register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00004000 constant EXTI_EXTI_FTSR2_FT46                             \ Falling trigger event configuration bit of configurable event input x less thansup>(1)less than/sup>
$00040000 constant EXTI_EXTI_FTSR2_FT50                             \ Falling trigger event configuration bit of configurable event input x less thansup>(1)less than/sup>
$00200000 constant EXTI_EXTI_FTSR2_FT53                             \ Falling trigger event configuration bit of configurable event input x


\
\ @brief EXTI software interrupt event register 2
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00004000 constant EXTI_EXTI_SWIER2_SWI46                           \ Software interrupt on event x
$00040000 constant EXTI_EXTI_SWIER2_SWI50                           \ Software interrupt on event x
$00200000 constant EXTI_EXTI_SWIER2_SWI53                           \ Software interrupt on event x


\
\ @brief EXTI rising edge pending register 2
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00004000 constant EXTI_EXTI_RPR2_RPIF46                            \ configurable event inputs x rising edge pending bit
$00040000 constant EXTI_EXTI_RPR2_RPIF50                            \ configurable event inputs x rising edge pending bit
$00200000 constant EXTI_EXTI_RPR2_RPIF53                            \ configurable event inputs x rising edge pending bit


\
\ @brief EXTI falling edge pending register 2
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00004000 constant EXTI_EXTI_FPR2_FPIF46                            \ configurable event inputs x falling edge pending bit
$00040000 constant EXTI_EXTI_FPR2_FPIF50                            \ configurable event inputs x falling edge pending bit
$00200000 constant EXTI_EXTI_FPR2_FPIF53                            \ configurable event inputs x falling edge pending bit


\
\ @brief EXTI security configuration register 2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_SECCFGR2_SEC32                         \ Security enable on event input x
$00000002 constant EXTI_EXTI_SECCFGR2_SEC33                         \ Security enable on event input x
$00000004 constant EXTI_EXTI_SECCFGR2_SEC34                         \ Security enable on event input x
$00000008 constant EXTI_EXTI_SECCFGR2_SEC35                         \ Security enable on event input x
$00000010 constant EXTI_EXTI_SECCFGR2_SEC36                         \ Security enable on event input x
$00000020 constant EXTI_EXTI_SECCFGR2_SEC37                         \ Security enable on event input x
$00000040 constant EXTI_EXTI_SECCFGR2_SEC38                         \ Security enable on event input x
$00000080 constant EXTI_EXTI_SECCFGR2_SEC39                         \ Security enable on event input x
$00000100 constant EXTI_EXTI_SECCFGR2_SEC40                         \ Security enable on event input x
$00000200 constant EXTI_EXTI_SECCFGR2_SEC41                         \ Security enable on event input x
$00000400 constant EXTI_EXTI_SECCFGR2_SEC42                         \ Security enable on event input x
$00000800 constant EXTI_EXTI_SECCFGR2_SEC43                         \ Security enable on event input x
$00001000 constant EXTI_EXTI_SECCFGR2_SEC44                         \ Security enable on event input x
$00002000 constant EXTI_EXTI_SECCFGR2_SEC45                         \ Security enable on event input x
$00004000 constant EXTI_EXTI_SECCFGR2_SEC46                         \ Security enable on event input x
$00008000 constant EXTI_EXTI_SECCFGR2_SEC47                         \ Security enable on event input x
$00010000 constant EXTI_EXTI_SECCFGR2_SEC48                         \ Security enable on event input x
$00020000 constant EXTI_EXTI_SECCFGR2_SEC49                         \ Security enable on event input x
$00040000 constant EXTI_EXTI_SECCFGR2_SEC50                         \ Security enable on event input x
$00080000 constant EXTI_EXTI_SECCFGR2_SEC51                         \ Security enable on event input x
$00100000 constant EXTI_EXTI_SECCFGR2_SEC52                         \ Security enable on event input x
$00200000 constant EXTI_EXTI_SECCFGR2_SEC53                         \ Security enable on event input x
$00400000 constant EXTI_EXTI_SECCFGR2_SEC54                         \ Security enable on event input x
$00800000 constant EXTI_EXTI_SECCFGR2_SEC55                         \ Security enable on event input x
$01000000 constant EXTI_EXTI_SECCFGR2_SEC56                         \ Security enable on event input x
$02000000 constant EXTI_EXTI_SECCFGR2_SEC57                         \ Security enable on event input x


\
\ @brief EXTI privilege configuration register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_PRIVCFGR2_PRIV32                       \ Security enable on event input x
$00000002 constant EXTI_EXTI_PRIVCFGR2_PRIV33                       \ Security enable on event input x
$00000004 constant EXTI_EXTI_PRIVCFGR2_PRIV34                       \ Security enable on event input x
$00000008 constant EXTI_EXTI_PRIVCFGR2_PRIV35                       \ Security enable on event input x
$00000010 constant EXTI_EXTI_PRIVCFGR2_PRIV36                       \ Security enable on event input x
$00000020 constant EXTI_EXTI_PRIVCFGR2_PRIV37                       \ Security enable on event input x
$00000040 constant EXTI_EXTI_PRIVCFGR2_PRIV38                       \ Security enable on event input x
$00000080 constant EXTI_EXTI_PRIVCFGR2_PRIV39                       \ Security enable on event input x
$00000100 constant EXTI_EXTI_PRIVCFGR2_PRIV40                       \ Security enable on event input x
$00000200 constant EXTI_EXTI_PRIVCFGR2_PRIV41                       \ Security enable on event input x
$00000400 constant EXTI_EXTI_PRIVCFGR2_PRIV42                       \ Security enable on event input x
$00000800 constant EXTI_EXTI_PRIVCFGR2_PRIV43                       \ Security enable on event input x
$00001000 constant EXTI_EXTI_PRIVCFGR2_PRIV44                       \ Security enable on event input x
$00002000 constant EXTI_EXTI_PRIVCFGR2_PRIV45                       \ Security enable on event input x
$00004000 constant EXTI_EXTI_PRIVCFGR2_PRIV46                       \ Security enable on event input x
$00008000 constant EXTI_EXTI_PRIVCFGR2_PRIV47                       \ Security enable on event input x
$00010000 constant EXTI_EXTI_PRIVCFGR2_PRIV48                       \ Security enable on event input x
$00020000 constant EXTI_EXTI_PRIVCFGR2_PRIV49                       \ Security enable on event input x
$00040000 constant EXTI_EXTI_PRIVCFGR2_PRIV50                       \ Security enable on event input x
$00080000 constant EXTI_EXTI_PRIVCFGR2_PRIV51                       \ Security enable on event input x
$00100000 constant EXTI_EXTI_PRIVCFGR2_PRIV52                       \ Security enable on event input x
$00200000 constant EXTI_EXTI_PRIVCFGR2_PRIV53                       \ Security enable on event input x
$00400000 constant EXTI_EXTI_PRIVCFGR2_PRIV54                       \ Security enable on event input x
$00800000 constant EXTI_EXTI_PRIVCFGR2_PRIV55                       \ Security enable on event input x
$01000000 constant EXTI_EXTI_PRIVCFGR2_PRIV56                       \ Security enable on event input x
$02000000 constant EXTI_EXTI_PRIVCFGR2_PRIV57                       \ Security enable on event input x


\
\ @brief EXTI external interrupt selection register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$000000ff constant EXTI_EXTI_EXTICR1_EXTI0                          \ EXTI0 GPIO port selection
$0000ff00 constant EXTI_EXTI_EXTICR1_EXTI1                          \ EXTI1 GPIO port selection
$00ff0000 constant EXTI_EXTI_EXTICR1_EXTI2                          \ EXTI2 GPIO port selection
$ff000000 constant EXTI_EXTI_EXTICR1_EXTI3                          \ EXTI3 GPIO port selection


\
\ @brief EXTI external interrupt selection register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$000000ff constant EXTI_EXTI_EXTICR4_EXTI12                         \ EXTI12 GPIO port selection
$0000ff00 constant EXTI_EXTI_EXTICR4_EXTI13                         \ EXTI13 GPIO port selection
$00ff0000 constant EXTI_EXTI_EXTICR4_EXTI14                         \ EXTI14 GPIO port selection
$ff000000 constant EXTI_EXTI_EXTICR4_EXTI15                         \ EXTI15 GPIO port selection


\
\ @brief EXTI external interrupt selection register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$000000ff constant EXTI_EXTI_EXTICR2_EXTI4                          \ EXTI4 GPIO port selection
$0000ff00 constant EXTI_EXTI_EXTICR2_EXTI5                          \ EXTI5 GPIO port selection
$00ff0000 constant EXTI_EXTI_EXTICR2_EXTI6                          \ EXTI6 GPIO port selection
$ff000000 constant EXTI_EXTI_EXTICR2_EXTI7                          \ EXTI7 GPIO port selection


\
\ @brief EXTI external interrupt selection register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$000000ff constant EXTI_EXTI_EXTICR3_EXTI8                          \ EXTI8 GPIO port selection
$0000ff00 constant EXTI_EXTI_EXTICR3_EXTI9                          \ EXTI9 GPIO port selection
$00ff0000 constant EXTI_EXTI_EXTICR3_EXTI10                         \ EXTI10 GPIO port selection
$ff000000 constant EXTI_EXTI_EXTICR3_EXTI11                         \ EXTI11 GPIO port selection


\
\ @brief EXTI lock register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_LOCKR_LOCK                             \ Global security and privilege configuration registers (EXTI_SECCFGR and EXTI_PRIVCFGR) lock


\
\ @brief EXTI CPU wake-up with interrupt mask register
\ Address offset: 0x80
\ Reset value: 0xFFFE0000
\

$00000001 constant EXTI_EXTI_IMR1_IM0                               \ CPU wake-up with interrupt mask on event input x
$00000002 constant EXTI_EXTI_IMR1_IM1                               \ CPU wake-up with interrupt mask on event input x
$00000004 constant EXTI_EXTI_IMR1_IM2                               \ CPU wake-up with interrupt mask on event input x
$00000008 constant EXTI_EXTI_IMR1_IM3                               \ CPU wake-up with interrupt mask on event input x
$00000010 constant EXTI_EXTI_IMR1_IM4                               \ CPU wake-up with interrupt mask on event input x
$00000020 constant EXTI_EXTI_IMR1_IM5                               \ CPU wake-up with interrupt mask on event input x
$00000040 constant EXTI_EXTI_IMR1_IM6                               \ CPU wake-up with interrupt mask on event input x
$00000080 constant EXTI_EXTI_IMR1_IM7                               \ CPU wake-up with interrupt mask on event input x
$00000100 constant EXTI_EXTI_IMR1_IM8                               \ CPU wake-up with interrupt mask on event input x
$00000200 constant EXTI_EXTI_IMR1_IM9                               \ CPU wake-up with interrupt mask on event input x
$00000400 constant EXTI_EXTI_IMR1_IM10                              \ CPU wake-up with interrupt mask on event input x
$00000800 constant EXTI_EXTI_IMR1_IM11                              \ CPU wake-up with interrupt mask on event input x
$00001000 constant EXTI_EXTI_IMR1_IM12                              \ CPU wake-up with interrupt mask on event input x
$00002000 constant EXTI_EXTI_IMR1_IM13                              \ CPU wake-up with interrupt mask on event input x
$00004000 constant EXTI_EXTI_IMR1_IM14                              \ CPU wake-up with interrupt mask on event input x
$00008000 constant EXTI_EXTI_IMR1_IM15                              \ CPU wake-up with interrupt mask on event input x
$00010000 constant EXTI_EXTI_IMR1_IM16                              \ CPU wake-up with interrupt mask on event input x
$00020000 constant EXTI_EXTI_IMR1_IM17                              \ CPU wake-up with interrupt mask on event input x
$00040000 constant EXTI_EXTI_IMR1_IM18                              \ CPU wake-up with interrupt mask on event input x
$00080000 constant EXTI_EXTI_IMR1_IM19                              \ CPU wake-up with interrupt mask on event input x
$00100000 constant EXTI_EXTI_IMR1_IM20                              \ CPU wake-up with interrupt mask on event input x
$00200000 constant EXTI_EXTI_IMR1_IM21                              \ CPU wake-up with interrupt mask on event input x
$00400000 constant EXTI_EXTI_IMR1_IM22                              \ CPU wake-up with interrupt mask on event input x
$00800000 constant EXTI_EXTI_IMR1_IM23                              \ CPU wake-up with interrupt mask on event input x
$01000000 constant EXTI_EXTI_IMR1_IM24                              \ CPU wake-up with interrupt mask on event input x
$02000000 constant EXTI_EXTI_IMR1_IM25                              \ CPU wake-up with interrupt mask on event input x
$04000000 constant EXTI_EXTI_IMR1_IM26                              \ CPU wake-up with interrupt mask on event input x
$08000000 constant EXTI_EXTI_IMR1_IM27                              \ CPU wake-up with interrupt mask on event input x
$10000000 constant EXTI_EXTI_IMR1_IM28                              \ CPU wake-up with interrupt mask on event input x
$20000000 constant EXTI_EXTI_IMR1_IM29                              \ CPU wake-up with interrupt mask on event input x
$40000000 constant EXTI_EXTI_IMR1_IM30                              \ CPU wake-up with interrupt mask on event input x
$80000000 constant EXTI_EXTI_IMR1_IM31                              \ CPU wake-up with interrupt mask on event input x


\
\ @brief EXTI CPU wake-up with event mask register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_EMR1_EM0                               \ CPU wake-up with event generation mask on event input x
$00000002 constant EXTI_EXTI_EMR1_EM1                               \ CPU wake-up with event generation mask on event input x
$00000004 constant EXTI_EXTI_EMR1_EM2                               \ CPU wake-up with event generation mask on event input x
$00000008 constant EXTI_EXTI_EMR1_EM3                               \ CPU wake-up with event generation mask on event input x
$00000010 constant EXTI_EXTI_EMR1_EM4                               \ CPU wake-up with event generation mask on event input x
$00000020 constant EXTI_EXTI_EMR1_EM5                               \ CPU wake-up with event generation mask on event input x
$00000040 constant EXTI_EXTI_EMR1_EM6                               \ CPU wake-up with event generation mask on event input x
$00000080 constant EXTI_EXTI_EMR1_EM7                               \ CPU wake-up with event generation mask on event input x
$00000100 constant EXTI_EXTI_EMR1_EM8                               \ CPU wake-up with event generation mask on event input x
$00000200 constant EXTI_EXTI_EMR1_EM9                               \ CPU wake-up with event generation mask on event input x
$00000400 constant EXTI_EXTI_EMR1_EM10                              \ CPU wake-up with event generation mask on event input x
$00000800 constant EXTI_EXTI_EMR1_EM11                              \ CPU wake-up with event generation mask on event input x
$00001000 constant EXTI_EXTI_EMR1_EM12                              \ CPU wake-up with event generation mask on event input x
$00002000 constant EXTI_EXTI_EMR1_EM13                              \ CPU wake-up with event generation mask on event input x
$00004000 constant EXTI_EXTI_EMR1_EM14                              \ CPU wake-up with event generation mask on event input x
$00008000 constant EXTI_EXTI_EMR1_EM15                              \ CPU wake-up with event generation mask on event input x
$00010000 constant EXTI_EXTI_EMR1_EM16                              \ CPU wake-up with event generation mask on event input x
$00020000 constant EXTI_EXTI_EMR1_EM17                              \ CPU wake-up with event generation mask on event input x
$00040000 constant EXTI_EXTI_EMR1_EM18                              \ CPU wake-up with event generation mask on event input x
$00080000 constant EXTI_EXTI_EMR1_EM19                              \ CPU wake-up with event generation mask on event input x
$00100000 constant EXTI_EXTI_EMR1_EM20                              \ CPU wake-up with event generation mask on event input x
$00200000 constant EXTI_EXTI_EMR1_EM21                              \ CPU wake-up with event generation mask on event input x
$00400000 constant EXTI_EXTI_EMR1_EM22                              \ CPU wake-up with event generation mask on event input x
$00800000 constant EXTI_EXTI_EMR1_EM23                              \ CPU wake-up with event generation mask on event input x
$01000000 constant EXTI_EXTI_EMR1_EM24                              \ CPU wake-up with event generation mask on event input x
$02000000 constant EXTI_EXTI_EMR1_EM25                              \ CPU wake-up with event generation mask on event input x
$04000000 constant EXTI_EXTI_EMR1_EM26                              \ CPU wake-up with event generation mask on event input x
$08000000 constant EXTI_EXTI_EMR1_EM27                              \ CPU wake-up with event generation mask on event input x
$10000000 constant EXTI_EXTI_EMR1_EM28                              \ CPU wake-up with event generation mask on event input x
$20000000 constant EXTI_EXTI_EMR1_EM29                              \ CPU wake-up with event generation mask on event input x
$40000000 constant EXTI_EXTI_EMR1_EM30                              \ CPU wake-up with event generation mask on event input x
$80000000 constant EXTI_EXTI_EMR1_EM31                              \ CPU wake-up with event generation mask on event input x


\
\ @brief EXTI CPU wake-up with interrupt mask register 2
\ Address offset: 0x90
\ Reset value: 0x07DBBFFF
\

$00000001 constant EXTI_EXTI_IMR2_IM32                              \ CPU wake-up with interrupt mask on event input x
$00000002 constant EXTI_EXTI_IMR2_IM33                              \ CPU wake-up with interrupt mask on event input x
$00000004 constant EXTI_EXTI_IMR2_IM34                              \ CPU wake-up with interrupt mask on event input x
$00000008 constant EXTI_EXTI_IMR2_IM35                              \ CPU wake-up with interrupt mask on event input x
$00000010 constant EXTI_EXTI_IMR2_IM36                              \ CPU wake-up with interrupt mask on event input x
$00000020 constant EXTI_EXTI_IMR2_IM37                              \ CPU wake-up with interrupt mask on event input x
$00000040 constant EXTI_EXTI_IMR2_IM38                              \ CPU wake-up with interrupt mask on event input x
$00000080 constant EXTI_EXTI_IMR2_IM39                              \ CPU wake-up with interrupt mask on event input x
$00000100 constant EXTI_EXTI_IMR2_IM40                              \ CPU wake-up with interrupt mask on event input x
$00000200 constant EXTI_EXTI_IMR2_IM41                              \ CPU wake-up with interrupt mask on event input x
$00000400 constant EXTI_EXTI_IMR2_IM42                              \ CPU wake-up with interrupt mask on event input x
$00000800 constant EXTI_EXTI_IMR2_IM43                              \ CPU wake-up with interrupt mask on event input x
$00001000 constant EXTI_EXTI_IMR2_IM44                              \ CPU wake-up with interrupt mask on event input x
$00002000 constant EXTI_EXTI_IMR2_IM45                              \ CPU wake-up with interrupt mask on event input x
$00004000 constant EXTI_EXTI_IMR2_IM46                              \ CPU wake-up with interrupt mask on event input x
$00008000 constant EXTI_EXTI_IMR2_IM47                              \ CPU wake-up with interrupt mask on event input x
$00010000 constant EXTI_EXTI_IMR2_IM48                              \ CPU wake-up with interrupt mask on event input x
$00020000 constant EXTI_EXTI_IMR2_IM49                              \ CPU wake-up with interrupt mask on event input x
$00040000 constant EXTI_EXTI_IMR2_IM50                              \ CPU wake-up with interrupt mask on event input x
$00080000 constant EXTI_EXTI_IMR2_IM51                              \ CPU wake-up with interrupt mask on event input x
$00100000 constant EXTI_EXTI_IMR2_IM52                              \ CPU wake-up with interrupt mask on event input x
$00200000 constant EXTI_EXTI_IMR2_IM53                              \ CPU wake-up with interrupt mask on event input x
$00400000 constant EXTI_EXTI_IMR2_IM54                              \ CPU wake-up with interrupt mask on event input x
$00800000 constant EXTI_EXTI_IMR2_IM55                              \ CPU wake-up with interrupt mask on event input x
$01000000 constant EXTI_EXTI_IMR2_IM56                              \ CPU wake-up with interrupt mask on event input x
$02000000 constant EXTI_EXTI_IMR2_IM57                              \ CPU wake-up with interrupt mask on event input x
$04000000 constant EXTI_EXTI_IMR2_IM58                              \ CPU wake-up with interrupt mask on event input x


\
\ @brief EXTI CPU wake-up with event mask register 2
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_EMR2_EM32                              \ CPU wake-up with event generation mask on event input x
$00000002 constant EXTI_EXTI_EMR2_EM33                              \ CPU wake-up with event generation mask on event input x
$00000004 constant EXTI_EXTI_EMR2_EM34                              \ CPU wake-up with event generation mask on event input x
$00000008 constant EXTI_EXTI_EMR2_EM35                              \ CPU wake-up with event generation mask on event input x
$00000010 constant EXTI_EXTI_EMR2_EM36                              \ CPU wake-up with event generation mask on event input x
$00000020 constant EXTI_EXTI_EMR2_EM37                              \ CPU wake-up with event generation mask on event input x
$00000040 constant EXTI_EXTI_EMR2_EM38                              \ CPU wake-up with event generation mask on event input x
$00000080 constant EXTI_EXTI_EMR2_EM39                              \ CPU wake-up with event generation mask on event input x
$00000100 constant EXTI_EXTI_EMR2_EM40                              \ CPU wake-up with event generation mask on event input x
$00000200 constant EXTI_EXTI_EMR2_EM41                              \ CPU wake-up with event generation mask on event input x
$00000400 constant EXTI_EXTI_EMR2_EM42                              \ CPU wake-up with event generation mask on event input x
$00000800 constant EXTI_EXTI_EMR2_EM43                              \ CPU wake-up with event generation mask on event input x
$00001000 constant EXTI_EXTI_EMR2_EM44                              \ CPU wake-up with event generation mask on event input x
$00002000 constant EXTI_EXTI_EMR2_EM45                              \ CPU wake-up with event generation mask on event input x
$00004000 constant EXTI_EXTI_EMR2_EM46                              \ CPU wake-up with event generation mask on event input x
$00008000 constant EXTI_EXTI_EMR2_EM47                              \ CPU wake-up with event generation mask on event input x
$00010000 constant EXTI_EXTI_EMR2_EM48                              \ CPU wake-up with event generation mask on event input x
$00020000 constant EXTI_EXTI_EMR2_EM49                              \ CPU wake-up with event generation mask on event input x
$00040000 constant EXTI_EXTI_EMR2_EM50                              \ CPU wake-up with event generation mask on event input x
$00080000 constant EXTI_EXTI_EMR2_EM51                              \ CPU wake-up with event generation mask on event input x
$00100000 constant EXTI_EXTI_EMR2_EM52                              \ CPU wake-up with event generation mask on event input x
$00200000 constant EXTI_EXTI_EMR2_EM53                              \ CPU wake-up with event generation mask on event input x
$00400000 constant EXTI_EXTI_EMR2_EM54                              \ CPU wake-up with event generation mask on event input x
$00800000 constant EXTI_EXTI_EMR2_EM55                              \ CPU wake-up with event generation mask on event input x
$01000000 constant EXTI_EXTI_EMR2_EM56                              \ CPU wake-up with event generation mask on event input x
$02000000 constant EXTI_EXTI_EMR2_EM57                              \ CPU wake-up with event generation mask on event input x
$04000000 constant EXTI_EXTI_EMR2_EM58                              \ CPU wake-up with event generation mask on event input x


\
\ @brief EXTI address block description
\
$44022000 constant EXTI_EXTI_RTSR1  \ offset: 0x00 : EXTI rising trigger selection register
$44022004 constant EXTI_EXTI_FTSR1  \ offset: 0x04 : EXTI falling trigger selection register
$44022008 constant EXTI_EXTI_SWIER1  \ offset: 0x08 : EXTI software interrupt event register
$4402200c constant EXTI_EXTI_RPR1  \ offset: 0x0C : EXTI rising edge pending register
$44022010 constant EXTI_EXTI_FPR1  \ offset: 0x10 : EXTI falling edge pending register
$44022014 constant EXTI_EXTI_SECCFGR1  \ offset: 0x14 : EXTI security configuration register
$44022018 constant EXTI_EXTI_PRIVCFGR1  \ offset: 0x18 : EXTI privilege configuration register
$44022020 constant EXTI_EXTI_RTSR2  \ offset: 0x20 : EXTI rising trigger selection register 2
$44022024 constant EXTI_EXTI_FTSR2  \ offset: 0x24 : EXTI falling trigger selection register 2
$44022028 constant EXTI_EXTI_SWIER2  \ offset: 0x28 : EXTI software interrupt event register 2
$4402202c constant EXTI_EXTI_RPR2  \ offset: 0x2C : EXTI rising edge pending register 2
$44022030 constant EXTI_EXTI_FPR2  \ offset: 0x30 : EXTI falling edge pending register 2
$44022034 constant EXTI_EXTI_SECCFGR2  \ offset: 0x34 : EXTI security configuration register 2
$44022038 constant EXTI_EXTI_PRIVCFGR2  \ offset: 0x38 : EXTI privilege configuration register 2
$44022060 constant EXTI_EXTI_EXTICR1  \ offset: 0x60 : EXTI external interrupt selection register
$44022060 constant EXTI_EXTI_EXTICR4  \ offset: 0x60 : EXTI external interrupt selection register
$44022064 constant EXTI_EXTI_EXTICR2  \ offset: 0x64 : EXTI external interrupt selection register
$44022068 constant EXTI_EXTI_EXTICR3  \ offset: 0x68 : EXTI external interrupt selection register
$44022070 constant EXTI_EXTI_LOCKR  \ offset: 0x70 : EXTI lock register
$44022080 constant EXTI_EXTI_IMR1  \ offset: 0x80 : EXTI CPU wake-up with interrupt mask register
$44022084 constant EXTI_EXTI_EMR1  \ offset: 0x84 : EXTI CPU wake-up with event mask register
$44022090 constant EXTI_EXTI_IMR2  \ offset: 0x90 : EXTI CPU wake-up with interrupt mask register 2
$44022094 constant EXTI_EXTI_EMR2  \ offset: 0x94 : EXTI CPU wake-up with event mask register 2

