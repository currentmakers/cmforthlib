\
\ @file exti_s.fs
\ @brief Extended interrupts and event controller
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

$00000001 constant EXTI_S_EXTI_RTSR1_RT0                            \ Rising trigger event configuration bit of configurable event input x
$00000002 constant EXTI_S_EXTI_RTSR1_RT1                            \ Rising trigger event configuration bit of configurable event input x
$00000004 constant EXTI_S_EXTI_RTSR1_RT2                            \ Rising trigger event configuration bit of configurable event input x
$00000008 constant EXTI_S_EXTI_RTSR1_RT3                            \ Rising trigger event configuration bit of configurable event input x
$00000010 constant EXTI_S_EXTI_RTSR1_RT4                            \ Rising trigger event configuration bit of configurable event input x
$00000020 constant EXTI_S_EXTI_RTSR1_RT5                            \ Rising trigger event configuration bit of configurable event input x
$00000040 constant EXTI_S_EXTI_RTSR1_RT6                            \ Rising trigger event configuration bit of configurable event input x
$00000080 constant EXTI_S_EXTI_RTSR1_RT7                            \ Rising trigger event configuration bit of configurable event input x
$00000100 constant EXTI_S_EXTI_RTSR1_RT8                            \ Rising trigger event configuration bit of configurable event input x
$00000200 constant EXTI_S_EXTI_RTSR1_RT9                            \ Rising trigger event configuration bit of configurable event input x
$00000400 constant EXTI_S_EXTI_RTSR1_RT10                           \ Rising trigger event configuration bit of configurable event input x
$00000800 constant EXTI_S_EXTI_RTSR1_RT11                           \ Rising trigger event configuration bit of configurable event input x
$00001000 constant EXTI_S_EXTI_RTSR1_RT12                           \ Rising trigger event configuration bit of configurable event input x
$00002000 constant EXTI_S_EXTI_RTSR1_RT13                           \ Rising trigger event configuration bit of configurable event input x
$00004000 constant EXTI_S_EXTI_RTSR1_RT14                           \ Rising trigger event configuration bit of configurable event input x
$00008000 constant EXTI_S_EXTI_RTSR1_RT15                           \ Rising trigger event configuration bit of configurable event input x
$00100000 constant EXTI_S_EXTI_RTSR1_RT20                           \ Rising trigger event configuration bit of configurable event input x
$00200000 constant EXTI_S_EXTI_RTSR1_RT21                           \ Rising trigger event configuration bit of configurable event input x


\
\ @brief EXTI falling trigger selection register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant EXTI_S_EXTI_FTSR1_FT0                            \ Falling trigger event configuration bit of configurable event input x
$00000002 constant EXTI_S_EXTI_FTSR1_FT1                            \ Falling trigger event configuration bit of configurable event input x
$00000004 constant EXTI_S_EXTI_FTSR1_FT2                            \ Falling trigger event configuration bit of configurable event input x
$00000008 constant EXTI_S_EXTI_FTSR1_FT3                            \ Falling trigger event configuration bit of configurable event input x
$00000010 constant EXTI_S_EXTI_FTSR1_FT4                            \ Falling trigger event configuration bit of configurable event input x
$00000020 constant EXTI_S_EXTI_FTSR1_FT5                            \ Falling trigger event configuration bit of configurable event input x
$00000040 constant EXTI_S_EXTI_FTSR1_FT6                            \ Falling trigger event configuration bit of configurable event input x
$00000080 constant EXTI_S_EXTI_FTSR1_FT7                            \ Falling trigger event configuration bit of configurable event input x
$00000100 constant EXTI_S_EXTI_FTSR1_FT8                            \ Falling trigger event configuration bit of configurable event input x
$00000200 constant EXTI_S_EXTI_FTSR1_FT9                            \ Falling trigger event configuration bit of configurable event input x
$00000400 constant EXTI_S_EXTI_FTSR1_FT10                           \ Falling trigger event configuration bit of configurable event input x
$00000800 constant EXTI_S_EXTI_FTSR1_FT11                           \ Falling trigger event configuration bit of configurable event input x
$00001000 constant EXTI_S_EXTI_FTSR1_FT12                           \ Falling trigger event configuration bit of configurable event input x
$00002000 constant EXTI_S_EXTI_FTSR1_FT13                           \ Falling trigger event configuration bit of configurable event input x
$00004000 constant EXTI_S_EXTI_FTSR1_FT14                           \ Falling trigger event configuration bit of configurable event input x
$00008000 constant EXTI_S_EXTI_FTSR1_FT15                           \ Falling trigger event configuration bit of configurable event input x
$00100000 constant EXTI_S_EXTI_FTSR1_FT20                           \ Falling trigger event configuration bit of configurable event input x
$00200000 constant EXTI_S_EXTI_FTSR1_FT21                           \ Falling trigger event configuration bit of configurable event input x


\
\ @brief EXTI software interrupt event register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant EXTI_S_EXTI_SWIER1_SWI0                          \ Software interrupt on event x
$00000002 constant EXTI_S_EXTI_SWIER1_SWI1                          \ Software interrupt on event x
$00000004 constant EXTI_S_EXTI_SWIER1_SWI2                          \ Software interrupt on event x
$00000008 constant EXTI_S_EXTI_SWIER1_SWI3                          \ Software interrupt on event x
$00000010 constant EXTI_S_EXTI_SWIER1_SWI4                          \ Software interrupt on event x
$00000020 constant EXTI_S_EXTI_SWIER1_SWI5                          \ Software interrupt on event x
$00000040 constant EXTI_S_EXTI_SWIER1_SWI6                          \ Software interrupt on event x
$00000080 constant EXTI_S_EXTI_SWIER1_SWI7                          \ Software interrupt on event x
$00000100 constant EXTI_S_EXTI_SWIER1_SWI8                          \ Software interrupt on event x
$00000200 constant EXTI_S_EXTI_SWIER1_SWI9                          \ Software interrupt on event x
$00000400 constant EXTI_S_EXTI_SWIER1_SWI10                         \ Software interrupt on event x
$00000800 constant EXTI_S_EXTI_SWIER1_SWI11                         \ Software interrupt on event x
$00001000 constant EXTI_S_EXTI_SWIER1_SWI12                         \ Software interrupt on event x
$00002000 constant EXTI_S_EXTI_SWIER1_SWI13                         \ Software interrupt on event x
$00004000 constant EXTI_S_EXTI_SWIER1_SWI14                         \ Software interrupt on event x
$00008000 constant EXTI_S_EXTI_SWIER1_SWI15                         \ Software interrupt on event x
$00100000 constant EXTI_S_EXTI_SWIER1_SWI20                         \ Software interrupt on event x
$00200000 constant EXTI_S_EXTI_SWIER1_SWI21                         \ Software interrupt on event x


\
\ @brief EXTI rising edge pending register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant EXTI_S_EXTI_RPR1_RPIF0                           \ Configurable event input x rising edge pending bit
$00000002 constant EXTI_S_EXTI_RPR1_RPIF1                           \ Configurable event input x rising edge pending bit
$00000004 constant EXTI_S_EXTI_RPR1_RPIF2                           \ Configurable event input x rising edge pending bit
$00000008 constant EXTI_S_EXTI_RPR1_RPIF3                           \ Configurable event input x rising edge pending bit
$00000010 constant EXTI_S_EXTI_RPR1_RPIF4                           \ Configurable event input x rising edge pending bit
$00000020 constant EXTI_S_EXTI_RPR1_RPIF5                           \ Configurable event input x rising edge pending bit
$00000040 constant EXTI_S_EXTI_RPR1_RPIF6                           \ Configurable event input x rising edge pending bit
$00000080 constant EXTI_S_EXTI_RPR1_RPIF7                           \ Configurable event input x rising edge pending bit
$00000100 constant EXTI_S_EXTI_RPR1_RPIF8                           \ Configurable event input x rising edge pending bit
$00000200 constant EXTI_S_EXTI_RPR1_RPIF9                           \ Configurable event input x rising edge pending bit
$00000400 constant EXTI_S_EXTI_RPR1_RPIF10                          \ Configurable event input x rising edge pending bit
$00000800 constant EXTI_S_EXTI_RPR1_RPIF11                          \ Configurable event input x rising edge pending bit
$00001000 constant EXTI_S_EXTI_RPR1_RPIF12                          \ Configurable event input x rising edge pending bit
$00002000 constant EXTI_S_EXTI_RPR1_RPIF13                          \ Configurable event input x rising edge pending bit
$00004000 constant EXTI_S_EXTI_RPR1_RPIF14                          \ Configurable event input x rising edge pending bit
$00008000 constant EXTI_S_EXTI_RPR1_RPIF15                          \ Configurable event input x rising edge pending bit
$00100000 constant EXTI_S_EXTI_RPR1_RPIF20                          \ Configurable event input x rising edge pending bit
$00200000 constant EXTI_S_EXTI_RPR1_RPIF21                          \ Configurable event input x rising edge pending bit


\
\ @brief EXTI falling edge pending register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant EXTI_S_EXTI_FPR1_FPIF0                           \ Configurable event input x rising edge pending bit
$00000002 constant EXTI_S_EXTI_FPR1_FPIF1                           \ Configurable event input x rising edge pending bit
$00000004 constant EXTI_S_EXTI_FPR1_FPIF2                           \ Configurable event input x rising edge pending bit
$00000008 constant EXTI_S_EXTI_FPR1_FPIF3                           \ Configurable event input x rising edge pending bit
$00000010 constant EXTI_S_EXTI_FPR1_FPIF4                           \ Configurable event input x rising edge pending bit
$00000020 constant EXTI_S_EXTI_FPR1_FPIF5                           \ Configurable event input x rising edge pending bit
$00000040 constant EXTI_S_EXTI_FPR1_FPIF6                           \ Configurable event input x rising edge pending bit
$00000080 constant EXTI_S_EXTI_FPR1_FPIF7                           \ Configurable event input x rising edge pending bit
$00000100 constant EXTI_S_EXTI_FPR1_FPIF8                           \ Configurable event input x rising edge pending bit
$00000200 constant EXTI_S_EXTI_FPR1_FPIF9                           \ Configurable event input x rising edge pending bit
$00000400 constant EXTI_S_EXTI_FPR1_FPIF10                          \ Configurable event input x rising edge pending bit
$00000800 constant EXTI_S_EXTI_FPR1_FPIF11                          \ Configurable event input x rising edge pending bit
$00001000 constant EXTI_S_EXTI_FPR1_FPIF12                          \ Configurable event input x rising edge pending bit
$00002000 constant EXTI_S_EXTI_FPR1_FPIF13                          \ Configurable event input x rising edge pending bit
$00004000 constant EXTI_S_EXTI_FPR1_FPIF14                          \ Configurable event input x rising edge pending bit
$00008000 constant EXTI_S_EXTI_FPR1_FPIF15                          \ Configurable event input x rising edge pending bit
$00100000 constant EXTI_S_EXTI_FPR1_FPIF20                          \ configurable event input x falling edge pending bit
$00200000 constant EXTI_S_EXTI_FPR1_FPIF21                          \ configurable event input x falling edge pending bit


\
\ @brief EXTI security configuration register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant EXTI_S_EXTI_SECCFGR1_SEC0                        \ Security enable on event input x
$00000002 constant EXTI_S_EXTI_SECCFGR1_SEC1                        \ Security enable on event input x
$00000004 constant EXTI_S_EXTI_SECCFGR1_SEC2                        \ Security enable on event input x
$00000008 constant EXTI_S_EXTI_SECCFGR1_SEC3                        \ Security enable on event input x
$00000010 constant EXTI_S_EXTI_SECCFGR1_SEC4                        \ Security enable on event input x
$00000020 constant EXTI_S_EXTI_SECCFGR1_SEC5                        \ Security enable on event input x
$00000040 constant EXTI_S_EXTI_SECCFGR1_SEC6                        \ Security enable on event input x
$00000080 constant EXTI_S_EXTI_SECCFGR1_SEC7                        \ Security enable on event input x
$00000100 constant EXTI_S_EXTI_SECCFGR1_SEC8                        \ Security enable on event input x
$00000200 constant EXTI_S_EXTI_SECCFGR1_SEC9                        \ Security enable on event input x
$00000400 constant EXTI_S_EXTI_SECCFGR1_SEC10                       \ Security enable on event input x
$00000800 constant EXTI_S_EXTI_SECCFGR1_SEC11                       \ Security enable on event input x
$00001000 constant EXTI_S_EXTI_SECCFGR1_SEC12                       \ Security enable on event input x
$00002000 constant EXTI_S_EXTI_SECCFGR1_SEC13                       \ Security enable on event input x
$00004000 constant EXTI_S_EXTI_SECCFGR1_SEC14                       \ Security enable on event input x
$00008000 constant EXTI_S_EXTI_SECCFGR1_SEC15                       \ Security enable on event input x
$00020000 constant EXTI_S_EXTI_SECCFGR1_SEC17                       \ Security enable on event input x
$00040000 constant EXTI_S_EXTI_SECCFGR1_SEC18                       \ Security enable on event input x
$00080000 constant EXTI_S_EXTI_SECCFGR1_SEC19                       \ Security enable on event input x
$00100000 constant EXTI_S_EXTI_SECCFGR1_SEC20                       \ Security enable on event input x
$00200000 constant EXTI_S_EXTI_SECCFGR1_SEC21                       \ Security enable on event input x
$00400000 constant EXTI_S_EXTI_SECCFGR1_SEC22                       \ Security enable on event input x
$00800000 constant EXTI_S_EXTI_SECCFGR1_SEC23                       \ Security enable on event input x
$01000000 constant EXTI_S_EXTI_SECCFGR1_SEC24                       \ Security enable on event input x
$02000000 constant EXTI_S_EXTI_SECCFGR1_SEC25                       \ Security enable on event input x
$04000000 constant EXTI_S_EXTI_SECCFGR1_SEC26                       \ Security enable on event input x
$08000000 constant EXTI_S_EXTI_SECCFGR1_SEC27                       \ Security enable on event input x
$10000000 constant EXTI_S_EXTI_SECCFGR1_SEC28                       \ Security enable on event input x
$20000000 constant EXTI_S_EXTI_SECCFGR1_SEC29                       \ Security enable on event input x
$40000000 constant EXTI_S_EXTI_SECCFGR1_SEC30                       \ Security enable on event input x
$80000000 constant EXTI_S_EXTI_SECCFGR1_SEC31                       \ Security enable on event input x


\
\ @brief EXTI privilege configuration register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant EXTI_S_EXTI_PRIVCFGR1_PRIV0                      \ Privilege enable on event input x
$00000002 constant EXTI_S_EXTI_PRIVCFGR1_PRIV1                      \ Privilege enable on event input x
$00000004 constant EXTI_S_EXTI_PRIVCFGR1_PRIV2                      \ Privilege enable on event input x
$00000008 constant EXTI_S_EXTI_PRIVCFGR1_PRIV3                      \ Privilege enable on event input x
$00000010 constant EXTI_S_EXTI_PRIVCFGR1_PRIV4                      \ Privilege enable on event input x
$00000020 constant EXTI_S_EXTI_PRIVCFGR1_PRIV5                      \ Privilege enable on event input x
$00000040 constant EXTI_S_EXTI_PRIVCFGR1_PRIV6                      \ Privilege enable on event input x
$00000080 constant EXTI_S_EXTI_PRIVCFGR1_PRIV7                      \ Privilege enable on event input x
$00000100 constant EXTI_S_EXTI_PRIVCFGR1_PRIV8                      \ Privilege enable on event input x
$00000200 constant EXTI_S_EXTI_PRIVCFGR1_PRIV9                      \ Privilege enable on event input x
$00000400 constant EXTI_S_EXTI_PRIVCFGR1_PRIV10                     \ Privilege enable on event input x
$00000800 constant EXTI_S_EXTI_PRIVCFGR1_PRIV11                     \ Privilege enable on event input x
$00001000 constant EXTI_S_EXTI_PRIVCFGR1_PRIV12                     \ Privilege enable on event input x
$00002000 constant EXTI_S_EXTI_PRIVCFGR1_PRIV13                     \ Privilege enable on event input x
$00004000 constant EXTI_S_EXTI_PRIVCFGR1_PRIV14                     \ Privilege enable on event input x
$00008000 constant EXTI_S_EXTI_PRIVCFGR1_PRIV15                     \ Privilege enable on event input x
$00020000 constant EXTI_S_EXTI_PRIVCFGR1_PRIV17                     \ Privilege enable on event input x
$00040000 constant EXTI_S_EXTI_PRIVCFGR1_PRIV18                     \ Privilege enable on event input x
$00080000 constant EXTI_S_EXTI_PRIVCFGR1_PRIV19                     \ Privilege enable on event input x
$00100000 constant EXTI_S_EXTI_PRIVCFGR1_PRIV20                     \ Privilege enable on event input x
$00200000 constant EXTI_S_EXTI_PRIVCFGR1_PRIV21                     \ Privilege enable on event input x
$00400000 constant EXTI_S_EXTI_PRIVCFGR1_PRIV22                     \ Privilege enable on event input x
$00800000 constant EXTI_S_EXTI_PRIVCFGR1_PRIV23                     \ Privilege enable on event input x
$01000000 constant EXTI_S_EXTI_PRIVCFGR1_PRIV24                     \ Privilege enable on event input x
$02000000 constant EXTI_S_EXTI_PRIVCFGR1_PRIV25                     \ Privilege enable on event input x
$04000000 constant EXTI_S_EXTI_PRIVCFGR1_PRIV26                     \ Privilege enable on event input x
$08000000 constant EXTI_S_EXTI_PRIVCFGR1_PRIV27                     \ Privilege enable on event input x
$10000000 constant EXTI_S_EXTI_PRIVCFGR1_PRIV28                     \ Privilege enable on event input x
$20000000 constant EXTI_S_EXTI_PRIVCFGR1_PRIV29                     \ Privilege enable on event input x
$40000000 constant EXTI_S_EXTI_PRIVCFGR1_PRIV30                     \ Privilege enable on event input x
$80000000 constant EXTI_S_EXTI_PRIVCFGR1_PRIV31                     \ Privilege enable on event input x


\
\ @brief EXTI rising trigger selection register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000080 constant EXTI_S_EXTI_RTSR2_RT39                           \ Rising trigger event configuration bit of configurable event input x
$00000100 constant EXTI_S_EXTI_RTSR2_RT40                           \ Rising trigger event configuration bit of configurable event input x
$00080000 constant EXTI_S_EXTI_RTSR2_RT51                           \ Rising trigger event configuration bit of configurable event input 51
$00400000 constant EXTI_S_EXTI_RTSR2_RT54                           \ Rising trigger event configuration bit of configurable event input 54
$01000000 constant EXTI_S_EXTI_RTSR2_RT56                           \ Rising trigger event configuration bit of configurable event input 56


\
\ @brief EXTI falling trigger selection register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000080 constant EXTI_S_EXTI_FTSR2_FT39                           \ Falling trigger event configuration bit of configurable event input x
$00000100 constant EXTI_S_EXTI_FTSR2_FT40                           \ Falling trigger event configuration bit of configurable event input x
$00080000 constant EXTI_S_EXTI_FTSR2_FT51                           \ Falling trigger event configuration bit of configurable event input 51
$00400000 constant EXTI_S_EXTI_FTSR2_FT54                           \ Falling trigger event configuration bit of configurable event input 54
$01000000 constant EXTI_S_EXTI_FTSR2_FT56                           \ Falling trigger event configuration bit of configurable event input 56


\
\ @brief EXTI software interrupt event register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000080 constant EXTI_S_EXTI_SWIER2_SWI39                         \ Software interrupt on event x
$00000100 constant EXTI_S_EXTI_SWIER2_SWI40                         \ Software interrupt on event x
$00080000 constant EXTI_S_EXTI_SWIER2_SWI51                         \ Software interrupt on event 51
$00400000 constant EXTI_S_EXTI_SWIER2_SWI54                         \ Software interrupt on event 54
$01000000 constant EXTI_S_EXTI_SWIER2_SWI56                         \ Software interrupt on event 56


\
\ @brief EXTI rising edge pending register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000080 constant EXTI_S_EXTI_RPR2_RPIF39                          \ Configurable event input x rising edge pending bit
$00000100 constant EXTI_S_EXTI_RPR2_RPIF40                          \ Configurable event input x rising edge pending bit
$00080000 constant EXTI_S_EXTI_RPR2_RPIF51                          \ Configurable event input 51 rising edge pending bit
$00400000 constant EXTI_S_EXTI_RPR2_RPIF54                          \ Configurable event input 54 rising edge pending bit
$01000000 constant EXTI_S_EXTI_RPR2_RPIF56                          \ Configurable event input 56 rising edge pending bit


\
\ @brief EXTI falling edge pending register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000080 constant EXTI_S_EXTI_FPR2_FPIF39                          \ Configurable event input x falling edge pending bit
$00000100 constant EXTI_S_EXTI_FPR2_FPIF40                          \ Configurable event input x falling edge pending bit
$00080000 constant EXTI_S_EXTI_FPR2_FPIF51                          \ Configurable event input 51 falling edge pending bit
$00400000 constant EXTI_S_EXTI_FPR2_FPIF54                          \ Configurable event input 54 falling edge pending bit
$01000000 constant EXTI_S_EXTI_FPR2_FPIF56                          \ Configurable event input 56 falling edge pending bit


\
\ @brief EXTI security enable register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant EXTI_S_EXTI_SECCFGR2_SEC32                       \ Security enable on event input x
$00000002 constant EXTI_S_EXTI_SECCFGR2_SEC33                       \ Security enable on event input x
$00000004 constant EXTI_S_EXTI_SECCFGR2_SEC34                       \ Security enable on event input x
$00000008 constant EXTI_S_EXTI_SECCFGR2_SEC35                       \ Security enable on event input x
$00000010 constant EXTI_S_EXTI_SECCFGR2_SEC36                       \ Security enable on event input x
$00000020 constant EXTI_S_EXTI_SECCFGR2_SEC37                       \ Security enable on event input x
$00000040 constant EXTI_S_EXTI_SECCFGR2_SEC38                       \ Security enable on event input x
$00000080 constant EXTI_S_EXTI_SECCFGR2_SEC39                       \ Security enable on event input x
$00000100 constant EXTI_S_EXTI_SECCFGR2_SEC40                       \ Security enable on event input x
$00000200 constant EXTI_S_EXTI_SECCFGR2_SEC41                       \ Security enable on event input x
$00000400 constant EXTI_S_EXTI_SECCFGR2_SEC42                       \ Security enable on event input x
$00000800 constant EXTI_S_EXTI_SECCFGR2_SEC43                       \ Security enable on event input x
$00001000 constant EXTI_S_EXTI_SECCFGR2_SEC44                       \ Security enable on event input x
$00002000 constant EXTI_S_EXTI_SECCFGR2_SEC45                       \ Security enable on event input x
$00004000 constant EXTI_S_EXTI_SECCFGR2_SEC46                       \ Security enable on event input x
$00008000 constant EXTI_S_EXTI_SECCFGR2_SEC47                       \ Security enable on event input x
$00010000 constant EXTI_S_EXTI_SECCFGR2_SEC48                       \ Security enable on event input x
$00020000 constant EXTI_S_EXTI_SECCFGR2_SEC49                       \ Security enable on event input x
$00040000 constant EXTI_S_EXTI_SECCFGR2_SEC50                       \ Security enable on event input x
$00080000 constant EXTI_S_EXTI_SECCFGR2_SEC51                       \ Security enable on event input x
$00100000 constant EXTI_S_EXTI_SECCFGR2_SEC52                       \ Security enable on event input x
$00200000 constant EXTI_S_EXTI_SECCFGR2_SEC53                       \ Security enable on event input x
$00400000 constant EXTI_S_EXTI_SECCFGR2_SEC54                       \ Security enable on event input x
$00800000 constant EXTI_S_EXTI_SECCFGR2_SEC55                       \ Security enable on event input x
$01000000 constant EXTI_S_EXTI_SECCFGR2_SEC56                       \ Security enable on event input x
$02000000 constant EXTI_S_EXTI_SECCFGR2_SEC57                       \ Security enable on event input x
$04000000 constant EXTI_S_EXTI_SECCFGR2_SEC58                       \ Security enable on event input x
$10000000 constant EXTI_S_EXTI_SECCFGR2_SEC60                       \ Security enable on event input x
$20000000 constant EXTI_S_EXTI_SECCFGR2_SEC61                       \ Security enable on event input x
$40000000 constant EXTI_S_EXTI_SECCFGR2_SEC62                       \ Security enable on event input x
$80000000 constant EXTI_S_EXTI_SECCFGR2_SEC63                       \ Security enable on event input x


\
\ @brief EXTI privilege enable register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant EXTI_S_EXTI_PRIVCFGR2_PRIV32                     \ Privilege enable on event input x
$00000002 constant EXTI_S_EXTI_PRIVCFGR2_PRIV33                     \ Privilege enable on event input x
$00000004 constant EXTI_S_EXTI_PRIVCFGR2_PRIV34                     \ Privilege enable on event input x
$00000008 constant EXTI_S_EXTI_PRIVCFGR2_PRIV35                     \ Privilege enable on event input x
$00000010 constant EXTI_S_EXTI_PRIVCFGR2_PRIV36                     \ Privilege enable on event input x
$00000020 constant EXTI_S_EXTI_PRIVCFGR2_PRIV37                     \ Privilege enable on event input x
$00000040 constant EXTI_S_EXTI_PRIVCFGR2_PRIV38                     \ Privilege enable on event input x
$00000080 constant EXTI_S_EXTI_PRIVCFGR2_PRIV39                     \ Privilege enable on event input x
$00000100 constant EXTI_S_EXTI_PRIVCFGR2_PRIV40                     \ Privilege enable on event input x
$00000200 constant EXTI_S_EXTI_PRIVCFGR2_PRIV41                     \ Privilege enable on event input x
$00000400 constant EXTI_S_EXTI_PRIVCFGR2_PRIV42                     \ Privilege enable on event input x
$00000800 constant EXTI_S_EXTI_PRIVCFGR2_PRIV43                     \ Privilege enable on event input x
$00001000 constant EXTI_S_EXTI_PRIVCFGR2_PRIV44                     \ Privilege enable on event input x
$00002000 constant EXTI_S_EXTI_PRIVCFGR2_PRIV45                     \ Privilege enable on event input x
$00004000 constant EXTI_S_EXTI_PRIVCFGR2_PRIV46                     \ Privilege enable on event input x
$00008000 constant EXTI_S_EXTI_PRIVCFGR2_PRIV47                     \ Privilege enable on event input x
$00010000 constant EXTI_S_EXTI_PRIVCFGR2_PRIV48                     \ Privilege enable on event input x
$00020000 constant EXTI_S_EXTI_PRIVCFGR2_PRIV49                     \ Privilege enable on event input x
$00040000 constant EXTI_S_EXTI_PRIVCFGR2_PRIV50                     \ Privilege enable on event input x
$00080000 constant EXTI_S_EXTI_PRIVCFGR2_PRIV51                     \ Privilege enable on event input x
$00100000 constant EXTI_S_EXTI_PRIVCFGR2_PRIV52                     \ Privilege enable on event input x
$00200000 constant EXTI_S_EXTI_PRIVCFGR2_PRIV53                     \ Privilege enable on event input x
$00400000 constant EXTI_S_EXTI_PRIVCFGR2_PRIV54                     \ Privilege enable on event input x
$00800000 constant EXTI_S_EXTI_PRIVCFGR2_PRIV55                     \ Privilege enable on event input x
$01000000 constant EXTI_S_EXTI_PRIVCFGR2_PRIV56                     \ Privilege enable on event input x
$02000000 constant EXTI_S_EXTI_PRIVCFGR2_PRIV57                     \ Privilege enable on event input x
$04000000 constant EXTI_S_EXTI_PRIVCFGR2_PRIV58                     \ Privilege enable on event input x
$10000000 constant EXTI_S_EXTI_PRIVCFGR2_PRIV60                     \ Privilege enable on event input x
$20000000 constant EXTI_S_EXTI_PRIVCFGR2_PRIV61                     \ Privilege enable on event input x
$40000000 constant EXTI_S_EXTI_PRIVCFGR2_PRIV62                     \ Privilege enable on event input x
$80000000 constant EXTI_S_EXTI_PRIVCFGR2_PRIV63                     \ Privilege enable on event input x


\
\ @brief EXTI rising trigger selection register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000004 constant EXTI_S_EXTI_RTSR3_RT66                           \ Rising trigger event configuration bit of configurable event input 66
$00000010 constant EXTI_S_EXTI_RTSR3_RT68                           \ Rising trigger event configuration bit of configurable event input x
$00000020 constant EXTI_S_EXTI_RTSR3_RT69                           \ Rising trigger event configuration bit of configurable event input x
$00000040 constant EXTI_S_EXTI_RTSR3_RT70                           \ Rising trigger event configuration bit of configurable event input x
$00000080 constant EXTI_S_EXTI_RTSR3_RT71                           \ Rising trigger event configuration bit of configurable event input x
$00000100 constant EXTI_S_EXTI_RTSR3_RT72                           \ Rising trigger event configuration bit of configurable event input x
$00000200 constant EXTI_S_EXTI_RTSR3_RT73                           \ Rising trigger event configuration bit of configurable event input x
$00000400 constant EXTI_S_EXTI_RTSR3_RT74                           \ Rising trigger event configuration bit of configurable event input x


\
\ @brief EXTI falling trigger selection register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000004 constant EXTI_S_EXTI_FTSR3_FT66                           \ Falling trigger event configuration bit of configurable event input 66
$00000010 constant EXTI_S_EXTI_FTSR3_FT68                           \ Falling trigger event configuration bit of configurable event input x
$00000020 constant EXTI_S_EXTI_FTSR3_FT69                           \ Falling trigger event configuration bit of configurable event input x
$00000040 constant EXTI_S_EXTI_FTSR3_FT70                           \ Falling trigger event configuration bit of configurable event input x
$00000080 constant EXTI_S_EXTI_FTSR3_FT71                           \ Falling trigger event configuration bit of configurable event input x
$00000100 constant EXTI_S_EXTI_FTSR3_FT72                           \ Falling trigger event configuration bit of configurable event input x
$00000200 constant EXTI_S_EXTI_FTSR3_FT73                           \ Falling trigger event configuration bit of configurable event input x
$00000400 constant EXTI_S_EXTI_FTSR3_FT74                           \ Falling trigger event configuration bit of configurable event input x


\
\ @brief EXTI software interrupt event register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000004 constant EXTI_S_EXTI_SWIER3_SWI66                         \ Software interrupt on event 66
$00000010 constant EXTI_S_EXTI_SWIER3_SWI68                         \ Software interrupt on event x
$00000020 constant EXTI_S_EXTI_SWIER3_SWI69                         \ Software interrupt on event x
$00000040 constant EXTI_S_EXTI_SWIER3_SWI70                         \ Software interrupt on event x
$00000080 constant EXTI_S_EXTI_SWIER3_SWI71                         \ Software interrupt on event x
$00000100 constant EXTI_S_EXTI_SWIER3_SWI72                         \ Software interrupt on event x
$00000200 constant EXTI_S_EXTI_SWIER3_SWI73                         \ Software interrupt on event x
$00000400 constant EXTI_S_EXTI_SWIER3_SWI74                         \ Software interrupt on event x


\
\ @brief EXTI rising edge pending register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000004 constant EXTI_S_EXTI_RPR3_RPIF66                          \ configurable event input 66rising edge pending bit
$00000010 constant EXTI_S_EXTI_RPR3_RPIF68                          \ configurable event input x rising edge pending bit
$00000020 constant EXTI_S_EXTI_RPR3_RPIF69                          \ configurable event input x rising edge pending bit
$00000040 constant EXTI_S_EXTI_RPR3_RPIF70                          \ configurable event input x rising edge pending bit
$00000080 constant EXTI_S_EXTI_RPR3_RPIF71                          \ configurable event input x rising edge pending bit
$00000100 constant EXTI_S_EXTI_RPR3_RPIF72                          \ configurable event input x rising edge pending bit
$00000200 constant EXTI_S_EXTI_RPR3_RPIF73                          \ configurable event input x rising edge pending bit
$00000400 constant EXTI_S_EXTI_RPR3_RPIF74                          \ configurable event input x rising edge pending bit


\
\ @brief EXTI falling edge pending register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000004 constant EXTI_S_EXTI_FPR3_FPIF66                          \ configurable event input 66 falling edge pending bit
$00000010 constant EXTI_S_EXTI_FPR3_FPIF68                          \ configurable event input x falling edge pending bit
$00000020 constant EXTI_S_EXTI_FPR3_FPIF69                          \ configurable event input x falling edge pending bit
$00000040 constant EXTI_S_EXTI_FPR3_FPIF70                          \ configurable event input x falling edge pending bit
$00000080 constant EXTI_S_EXTI_FPR3_FPIF71                          \ configurable event input x falling edge pending bit
$00000100 constant EXTI_S_EXTI_FPR3_FPIF72                          \ configurable event input x falling edge pending bit
$00000200 constant EXTI_S_EXTI_FPR3_FPIF73                          \ configurable event input x falling edge pending bit
$00000400 constant EXTI_S_EXTI_FPR3_FPIF74                          \ configurable event input x falling edge pending bit


\
\ @brief EXTI security enable register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant EXTI_S_EXTI_SECCFGR3_SEC64                       \ Security enable on event input x
$00000002 constant EXTI_S_EXTI_SECCFGR3_SEC65                       \ Security enable on event input x
$00000004 constant EXTI_S_EXTI_SECCFGR3_SEC66                       \ Security enable on event input x
$00000010 constant EXTI_S_EXTI_SECCFGR3_SEC68                       \ Security enable on event input x
$00000020 constant EXTI_S_EXTI_SECCFGR3_SEC69                       \ Security enable on event input x
$00000040 constant EXTI_S_EXTI_SECCFGR3_SEC70                       \ Security enable on event input x
$00000080 constant EXTI_S_EXTI_SECCFGR3_SEC71                       \ Security enable on event input x
$00000100 constant EXTI_S_EXTI_SECCFGR3_SEC72                       \ Security enable on event input x
$00000200 constant EXTI_S_EXTI_SECCFGR3_SEC73                       \ Security enable on event input x
$00000400 constant EXTI_S_EXTI_SECCFGR3_SEC74                       \ Security enable on event input x
$00002000 constant EXTI_S_EXTI_SECCFGR3_SEC77                       \ Security enable on event input 77


\
\ @brief EXTI privilege enable register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant EXTI_S_EXTI_PRIVCFGR3_PRIV64                     \ Privilege enable on event input x
$00000002 constant EXTI_S_EXTI_PRIVCFGR3_PRIV65                     \ Privilege enable on event input x
$00000004 constant EXTI_S_EXTI_PRIVCFGR3_PRIV66                     \ Privilege enable on event input x
$00000010 constant EXTI_S_EXTI_PRIVCFGR3_PRIV68                     \ Privilege enable on event input x
$00000020 constant EXTI_S_EXTI_PRIVCFGR3_PRIV69                     \ Privilege enable on event input x
$00000040 constant EXTI_S_EXTI_PRIVCFGR3_PRIV70                     \ Privilege enable on event input x
$00000080 constant EXTI_S_EXTI_PRIVCFGR3_PRIV71                     \ Privilege enable on event input x
$00000100 constant EXTI_S_EXTI_PRIVCFGR3_PRIV72                     \ Privilege enable on event input x
$00000200 constant EXTI_S_EXTI_PRIVCFGR3_PRIV73                     \ Privilege enable on event input x
$00000400 constant EXTI_S_EXTI_PRIVCFGR3_PRIV74                     \ Privilege enable on event input x
$00002000 constant EXTI_S_EXTI_PRIVCFGR3_PRIV77                     \ Privilege enable on event input 77


\
\ @brief EXTI external interrupt selection register 1
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$000000ff constant EXTI_S_EXTI_EXTICR1_EXTI0                        \ EXTI0 GPIO port selection.
$0000ff00 constant EXTI_S_EXTI_EXTICR1_EXTI1                        \ EXTI1 GPIO port selection
$00ff0000 constant EXTI_S_EXTI_EXTICR1_EXTI2                        \ EXTI2 GPIO port selection
$ff000000 constant EXTI_S_EXTI_EXTICR1_EXTI3                        \ EXTI3 GPIO port selection


\
\ @brief EXTI external interrupt selection register 2
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$000000ff constant EXTI_S_EXTI_EXTICR2_EXTI4                        \ EXTI4 GPIO port selection.
$0000ff00 constant EXTI_S_EXTI_EXTICR2_EXTI5                        \ EXTI5 GPIO port selection.
$00ff0000 constant EXTI_S_EXTI_EXTICR2_EXTI6                        \ EXTI6 GPIO port selection.
$ff000000 constant EXTI_S_EXTI_EXTICR2_EXTI7                        \ EXTI7 GPIO port selection.


\
\ @brief EXTI external interrupt selection register 3
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$000000ff constant EXTI_S_EXTI_EXTICR3_EXTI8                        \ EXTI8 GPIO port selection.
$0000ff00 constant EXTI_S_EXTI_EXTICR3_EXTI9                        \ EXTI9 GPIO port selection.
$00ff0000 constant EXTI_S_EXTI_EXTICR3_EXTI10                       \ EXTI10 GPIO port selection.
$ff000000 constant EXTI_S_EXTI_EXTICR3_EXTI11                       \ EXTI11 GPIO port selection.


\
\ @brief EXTI external interrupt selection register 4
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$000000ff constant EXTI_S_EXTI_EXTICR4_EXTI12                       \ EXTI12 GPIO port selection.
$0000ff00 constant EXTI_S_EXTI_EXTICR4_EXTI13                       \ EXTI13 GPIO port selection.
$00ff0000 constant EXTI_S_EXTI_EXTICR4_EXTI14                       \ EXTI14 GPIO port selection.
$ff000000 constant EXTI_S_EXTI_EXTICR4_EXTI15                       \ EXTI15 GPIO port selection.


\
\ @brief EXTI lock register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant EXTI_S_EXTI_LOCKR_GLOCK                          \ Global security privilege EXTI_SECCFGRx/PRIVCFGRx


\
\ @brief EXTI CPU wake-up with interrupt mask register 1
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant EXTI_S_EXTI_IMR1_IM0                             \ CPU wake-up with interrupt mask on event input x
$00000002 constant EXTI_S_EXTI_IMR1_IM1                             \ CPU wake-up with interrupt mask on event input x
$00000004 constant EXTI_S_EXTI_IMR1_IM2                             \ CPU wake-up with interrupt mask on event input x
$00000008 constant EXTI_S_EXTI_IMR1_IM3                             \ CPU wake-up with interrupt mask on event input x
$00000010 constant EXTI_S_EXTI_IMR1_IM4                             \ CPU wake-up with interrupt mask on event input x
$00000020 constant EXTI_S_EXTI_IMR1_IM5                             \ CPU wake-up with interrupt mask on event input x
$00000040 constant EXTI_S_EXTI_IMR1_IM6                             \ CPU wake-up with interrupt mask on event input x
$00000080 constant EXTI_S_EXTI_IMR1_IM7                             \ CPU wake-up with interrupt mask on event input x
$00000100 constant EXTI_S_EXTI_IMR1_IM8                             \ CPU wake-up with interrupt mask on event input x
$00000200 constant EXTI_S_EXTI_IMR1_IM9                             \ CPU wake-up with interrupt mask on event input x
$00000400 constant EXTI_S_EXTI_IMR1_IM10                            \ CPU wake-up with interrupt mask on event input x
$00000800 constant EXTI_S_EXTI_IMR1_IM11                            \ CPU wake-up with interrupt mask on event input x
$00001000 constant EXTI_S_EXTI_IMR1_IM12                            \ CPU wake-up with interrupt mask on event input x
$00002000 constant EXTI_S_EXTI_IMR1_IM13                            \ CPU wake-up with interrupt mask on event input x
$00004000 constant EXTI_S_EXTI_IMR1_IM14                            \ CPU wake-up with interrupt mask on event input x
$00008000 constant EXTI_S_EXTI_IMR1_IM15                            \ CPU wake-up with interrupt mask on event input x
$00020000 constant EXTI_S_EXTI_IMR1_IM17                            \ CPU wake-up with interrupt mask on event input x
$00040000 constant EXTI_S_EXTI_IMR1_IM18                            \ CPU wake-up with interrupt mask on event input x
$00080000 constant EXTI_S_EXTI_IMR1_IM19                            \ CPU wake-up with interrupt mask on event input x
$00100000 constant EXTI_S_EXTI_IMR1_IM20                            \ CPU wake-up with interrupt mask on event input x
$00200000 constant EXTI_S_EXTI_IMR1_IM21                            \ CPU wake-up with interrupt mask on event input x
$00400000 constant EXTI_S_EXTI_IMR1_IM22                            \ CPU wake-up with interrupt mask on event input x
$00800000 constant EXTI_S_EXTI_IMR1_IM23                            \ CPU wake-up with interrupt mask on event input x
$01000000 constant EXTI_S_EXTI_IMR1_IM24                            \ CPU wake-up with interrupt mask on event input x
$02000000 constant EXTI_S_EXTI_IMR1_IM25                            \ CPU wake-up with interrupt mask on event input x
$04000000 constant EXTI_S_EXTI_IMR1_IM26                            \ CPU wake-up with interrupt mask on event input x
$08000000 constant EXTI_S_EXTI_IMR1_IM27                            \ CPU wake-up with interrupt mask on event input x
$10000000 constant EXTI_S_EXTI_IMR1_IM28                            \ CPU wake-up with interrupt mask on event input x
$20000000 constant EXTI_S_EXTI_IMR1_IM29                            \ CPU wake-up with interrupt mask on event input x
$40000000 constant EXTI_S_EXTI_IMR1_IM30                            \ CPU wake-up with interrupt mask on event input x
$80000000 constant EXTI_S_EXTI_IMR1_IM31                            \ CPU wake-up with interrupt mask on event input x


\
\ @brief EXTI CPU wake-up with event mask register 1
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant EXTI_S_EXTI_EMR1_EM0                             \ CPU wake-up with interrupt mask on event input x
$00000002 constant EXTI_S_EXTI_EMR1_EM1                             \ CPU wake-up with interrupt mask on event input x
$00000004 constant EXTI_S_EXTI_EMR1_EM2                             \ CPU wake-up with interrupt mask on event input x
$00000008 constant EXTI_S_EXTI_EMR1_EM3                             \ CPU wake-up with interrupt mask on event input x
$00000010 constant EXTI_S_EXTI_EMR1_EM4                             \ CPU wake-up with interrupt mask on event input x
$00000020 constant EXTI_S_EXTI_EMR1_EM5                             \ CPU wake-up with interrupt mask on event input x
$00000040 constant EXTI_S_EXTI_EMR1_EM6                             \ CPU wake-up with interrupt mask on event input x
$00000080 constant EXTI_S_EXTI_EMR1_EM7                             \ CPU wake-up with interrupt mask on event input x
$00000100 constant EXTI_S_EXTI_EMR1_EM8                             \ CPU wake-up with interrupt mask on event input x
$00000200 constant EXTI_S_EXTI_EMR1_EM9                             \ CPU wake-up with interrupt mask on event input x
$00000400 constant EXTI_S_EXTI_EMR1_EM10                            \ CPU wake-up with interrupt mask on event input x
$00000800 constant EXTI_S_EXTI_EMR1_EM11                            \ CPU wake-up with interrupt mask on event input x
$00001000 constant EXTI_S_EXTI_EMR1_EM12                            \ CPU wake-up with interrupt mask on event input x
$00002000 constant EXTI_S_EXTI_EMR1_EM13                            \ CPU wake-up with interrupt mask on event input x
$00004000 constant EXTI_S_EXTI_EMR1_EM14                            \ CPU wake-up with interrupt mask on event input x
$00008000 constant EXTI_S_EXTI_EMR1_EM15                            \ CPU wake-up with interrupt mask on event input x
$00020000 constant EXTI_S_EXTI_EMR1_EM17                            \ CPU wake-up with event on event input x
$00040000 constant EXTI_S_EXTI_EMR1_EM18                            \ CPU wake-up with event on event input x
$00080000 constant EXTI_S_EXTI_EMR1_EM19                            \ CPU wake-up with event on event input x
$00100000 constant EXTI_S_EXTI_EMR1_EM20                            \ CPU wake-up with event on event input x
$00200000 constant EXTI_S_EXTI_EMR1_EM21                            \ CPU wake-up with event on event input x
$00400000 constant EXTI_S_EXTI_EMR1_EM22                            \ CPU wake-up with event on event input x
$00800000 constant EXTI_S_EXTI_EMR1_EM23                            \ CPU wake-up with event on event input x
$01000000 constant EXTI_S_EXTI_EMR1_EM24                            \ CPU wake-up with event on event input x
$02000000 constant EXTI_S_EXTI_EMR1_EM25                            \ CPU wake-up with event on event input x
$04000000 constant EXTI_S_EXTI_EMR1_EM26                            \ CPU wake-up with event on event input x
$08000000 constant EXTI_S_EXTI_EMR1_EM27                            \ CPU wake-up with event on event input x
$10000000 constant EXTI_S_EXTI_EMR1_EM28                            \ CPU wake-up with event on event input x
$20000000 constant EXTI_S_EXTI_EMR1_EM29                            \ CPU wake-up with event on event input x
$40000000 constant EXTI_S_EXTI_EMR1_EM30                            \ CPU wake-up with event on event input x
$80000000 constant EXTI_S_EXTI_EMR1_EM31                            \ CPU wake-up with event on event input x


\
\ @brief EXTI CPU wake-up with interrupt mask register 2
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant EXTI_S_EXTI_IMR2_IM32                            \ CPU wake-up with interrupt mask on event input x
$00000002 constant EXTI_S_EXTI_IMR2_IM33                            \ CPU wake-up with interrupt mask on event input x
$00000004 constant EXTI_S_EXTI_IMR2_IM34                            \ CPU wake-up with interrupt mask on event input x
$00000008 constant EXTI_S_EXTI_IMR2_IM35                            \ CPU wake-up with interrupt mask on event input x
$00000010 constant EXTI_S_EXTI_IMR2_IM36                            \ CPU wake-up with interrupt mask on event input x
$00000020 constant EXTI_S_EXTI_IMR2_IM37                            \ CPU wake-up with interrupt mask on event input x
$00000040 constant EXTI_S_EXTI_IMR2_IM38                            \ CPU wake-up with interrupt mask on event input x
$00000080 constant EXTI_S_EXTI_IMR2_IM39                            \ CPU wake-up with interrupt mask on event input x
$00000100 constant EXTI_S_EXTI_IMR2_IM40                            \ CPU wake-up with interrupt mask on event input x
$00000200 constant EXTI_S_EXTI_IMR2_IM41                            \ CPU wake-up with interrupt mask on event input x
$00000400 constant EXTI_S_EXTI_IMR2_IM42                            \ CPU wake-up with interrupt mask on event input x
$00000800 constant EXTI_S_EXTI_IMR2_IM43                            \ CPU wake-up with interrupt mask on event input x
$00001000 constant EXTI_S_EXTI_IMR2_IM44                            \ CPU wake-up with interrupt mask on event input x
$00002000 constant EXTI_S_EXTI_IMR2_IM45                            \ CPU wake-up with interrupt mask on event input x
$00004000 constant EXTI_S_EXTI_IMR2_IM46                            \ CPU wake-up with interrupt mask on event input x
$00008000 constant EXTI_S_EXTI_IMR2_IM47                            \ CPU wake-up with interrupt mask on event input x
$00010000 constant EXTI_S_EXTI_IMR2_IM48                            \ CPU wake-up with interrupt mask on event input x
$00020000 constant EXTI_S_EXTI_IMR2_IM49                            \ CPU wake-up with interrupt mask on event input x
$00040000 constant EXTI_S_EXTI_IMR2_IM50                            \ CPU wake-up with interrupt mask on event input x
$00080000 constant EXTI_S_EXTI_IMR2_IM51                            \ CPU wake-up with interrupt mask on event input x
$00100000 constant EXTI_S_EXTI_IMR2_IM52                            \ CPU wake-up with interrupt mask on event input x
$00200000 constant EXTI_S_EXTI_IMR2_IM53                            \ CPU wake-up with interrupt mask on event input x
$00400000 constant EXTI_S_EXTI_IMR2_IM54                            \ CPU wake-up with interrupt mask on event input x
$00800000 constant EXTI_S_EXTI_IMR2_IM55                            \ CPU wake-up with interrupt mask on event input x
$01000000 constant EXTI_S_EXTI_IMR2_IM56                            \ CPU wake-up with interrupt mask on event input x
$02000000 constant EXTI_S_EXTI_IMR2_IM57                            \ CPU wake-up with interrupt mask on event input x
$04000000 constant EXTI_S_EXTI_IMR2_IM58                            \ CPU wake-up with interrupt mask on event input x
$10000000 constant EXTI_S_EXTI_IMR2_IM60                            \ CPU wake-up with interrupt mask on event input x
$20000000 constant EXTI_S_EXTI_IMR2_IM61                            \ CPU wake-up with interrupt mask on event input x
$40000000 constant EXTI_S_EXTI_IMR2_IM62                            \ CPU wake-up with interrupt mask on event input x
$80000000 constant EXTI_S_EXTI_IMR2_IM63                            \ CPU wake-up with interrupt mask on event input x


\
\ @brief EXTI CPU wake-up with event mask register 2
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant EXTI_S_EXTI_EMR2_EM32                            \ CPU wake-up with interrupt mask on event input x
$00000002 constant EXTI_S_EXTI_EMR2_EM33                            \ CPU wake-up with interrupt mask on event input x
$00000004 constant EXTI_S_EXTI_EMR2_EM34                            \ CPU wake-up with interrupt mask on event input x
$00000008 constant EXTI_S_EXTI_EMR2_EM35                            \ CPU wake-up with interrupt mask on event input x
$00000010 constant EXTI_S_EXTI_EMR2_EM36                            \ CPU wake-up with interrupt mask on event input x
$00000020 constant EXTI_S_EXTI_EMR2_EM37                            \ CPU wake-up with interrupt mask on event input x
$00000040 constant EXTI_S_EXTI_EMR2_EM38                            \ CPU wake-up with interrupt mask on event input x
$00000080 constant EXTI_S_EXTI_EMR2_EM39                            \ CPU wake-up with interrupt mask on event input x
$00000100 constant EXTI_S_EXTI_EMR2_EM40                            \ CPU wake-up with interrupt mask on event input x
$00000200 constant EXTI_S_EXTI_EMR2_EM41                            \ CPU wake-up with interrupt mask on event input x
$00000400 constant EXTI_S_EXTI_EMR2_EM42                            \ CPU wake-up with interrupt mask on event input x
$00000800 constant EXTI_S_EXTI_EMR2_EM43                            \ CPU wake-up with interrupt mask on event input x
$00001000 constant EXTI_S_EXTI_EMR2_EM44                            \ CPU wake-up with interrupt mask on event input x
$00002000 constant EXTI_S_EXTI_EMR2_EM45                            \ CPU wake-up with interrupt mask on event input x
$00004000 constant EXTI_S_EXTI_EMR2_EM46                            \ CPU wake-up with interrupt mask on event input x
$00008000 constant EXTI_S_EXTI_EMR2_EM47                            \ CPU wake-up with interrupt mask on event input x
$00010000 constant EXTI_S_EXTI_EMR2_EM48                            \ CPU wake-up with interrupt mask on event input x
$00020000 constant EXTI_S_EXTI_EMR2_EM49                            \ CPU wake-up with interrupt mask on event input x
$00040000 constant EXTI_S_EXTI_EMR2_EM50                            \ CPU wake-up with interrupt mask on event input x
$00080000 constant EXTI_S_EXTI_EMR2_EM51                            \ CPU wake-up with interrupt mask on event input x
$00100000 constant EXTI_S_EXTI_EMR2_EM52                            \ CPU wake-up with interrupt mask on event input x
$00200000 constant EXTI_S_EXTI_EMR2_EM53                            \ CPU wake-up with interrupt mask on event input x
$00400000 constant EXTI_S_EXTI_EMR2_EM54                            \ CPU wake-up with interrupt mask on event input x
$00800000 constant EXTI_S_EXTI_EMR2_EM55                            \ CPU wake-up with interrupt mask on event input x
$01000000 constant EXTI_S_EXTI_EMR2_EM56                            \ CPU wake-up with interrupt mask on event input x
$02000000 constant EXTI_S_EXTI_EMR2_EM57                            \ CPU wake-up with interrupt mask on event input x
$04000000 constant EXTI_S_EXTI_EMR2_EM58                            \ CPU wake-up with interrupt mask on event input x
$10000000 constant EXTI_S_EXTI_EMR2_EM60                            \ CPU wake-up with event on event input x
$20000000 constant EXTI_S_EXTI_EMR2_EM61                            \ CPU wake-up with event on event input x
$40000000 constant EXTI_S_EXTI_EMR2_EM62                            \ CPU wake-up with event on event input x
$80000000 constant EXTI_S_EXTI_EMR2_EM63                            \ CPU wake-up with event on event input x


\
\ @brief EXTI CPU wake-up with interrupt mask register 3
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000001 constant EXTI_S_EXTI_IMR3_IM64                            \ CPU wake-up with interrupt mask on event input x
$00000002 constant EXTI_S_EXTI_IMR3_IM65                            \ CPU wake-up with interrupt mask on event input x
$00000004 constant EXTI_S_EXTI_IMR3_IM66                            \ CPU wake-up with interrupt mask on event input x
$00000010 constant EXTI_S_EXTI_IMR3_IM68                            \ CPU wake-up with interrupt mask on event input x
$00000020 constant EXTI_S_EXTI_IMR3_IM69                            \ CPU wake-up with interrupt mask on event input x
$00000040 constant EXTI_S_EXTI_IMR3_IM70                            \ CPU wake-up with interrupt mask on event input x
$00000080 constant EXTI_S_EXTI_IMR3_IM71                            \ CPU wake-up with interrupt mask on event input x
$00000100 constant EXTI_S_EXTI_IMR3_IM72                            \ CPU wake-up with interrupt mask on event input x
$00000200 constant EXTI_S_EXTI_IMR3_IM73                            \ CPU wake-up with interrupt mask on event input x
$00000400 constant EXTI_S_EXTI_IMR3_IM74                            \ CPU wake-up with interrupt mask on event input x
$00002000 constant EXTI_S_EXTI_IMR3_IM77                            \ CPU wake-up with interrupt mask on event input 77


\
\ @brief EXTI CPU wake-up with event mask register 3
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000001 constant EXTI_S_EXTI_EMR3_EM64                            \ CPU wake-up with interrupt mask on event input x
$00000002 constant EXTI_S_EXTI_EMR3_EM65                            \ CPU wake-up with interrupt mask on event input x
$00000004 constant EXTI_S_EXTI_EMR3_EM66                            \ CPU wake-up with interrupt mask on event input x
$00000010 constant EXTI_S_EXTI_EMR3_EM68                            \ CPU wake-up with interrupt mask on event input x
$00000020 constant EXTI_S_EXTI_EMR3_EM69                            \ CPU wake-up with interrupt mask on event input x
$00000040 constant EXTI_S_EXTI_EMR3_EM70                            \ CPU wake-up with interrupt mask on event input x
$00000080 constant EXTI_S_EXTI_EMR3_EM71                            \ CPU wake-up with interrupt mask on event input x
$00000100 constant EXTI_S_EXTI_EMR3_EM72                            \ CPU wake-up with interrupt mask on event input x
$00000200 constant EXTI_S_EXTI_EMR3_EM73                            \ CPU wake-up with interrupt mask on event input x
$00000400 constant EXTI_S_EXTI_EMR3_EM74                            \ CPU wake-up with interrupt mask on event input x
$00002000 constant EXTI_S_EXTI_EMR3_EM77                            \ CPU wake-up with event on event input 77


\
\ @brief Extended interrupts and event controller
\
$56025000 constant EXTI_S_EXTI_RTSR1  \ offset: 0x00 : EXTI rising trigger selection register
$56025004 constant EXTI_S_EXTI_FTSR1  \ offset: 0x04 : EXTI falling trigger selection register
$56025008 constant EXTI_S_EXTI_SWIER1  \ offset: 0x08 : EXTI software interrupt event register
$5602500c constant EXTI_S_EXTI_RPR1  \ offset: 0x0C : EXTI rising edge pending register
$56025010 constant EXTI_S_EXTI_FPR1  \ offset: 0x10 : EXTI falling edge pending register
$56025014 constant EXTI_S_EXTI_SECCFGR1  \ offset: 0x14 : EXTI security configuration register
$56025018 constant EXTI_S_EXTI_PRIVCFGR1  \ offset: 0x18 : EXTI privilege configuration register
$56025020 constant EXTI_S_EXTI_RTSR2  \ offset: 0x20 : EXTI rising trigger selection register
$56025024 constant EXTI_S_EXTI_FTSR2  \ offset: 0x24 : EXTI falling trigger selection register
$56025028 constant EXTI_S_EXTI_SWIER2  \ offset: 0x28 : EXTI software interrupt event register
$5602502c constant EXTI_S_EXTI_RPR2  \ offset: 0x2C : EXTI rising edge pending register
$56025030 constant EXTI_S_EXTI_FPR2  \ offset: 0x30 : EXTI falling edge pending register
$56025034 constant EXTI_S_EXTI_SECCFGR2  \ offset: 0x34 : EXTI security enable register
$56025038 constant EXTI_S_EXTI_PRIVCFGR2  \ offset: 0x38 : EXTI privilege enable register
$56025040 constant EXTI_S_EXTI_RTSR3  \ offset: 0x40 : EXTI rising trigger selection register
$56025044 constant EXTI_S_EXTI_FTSR3  \ offset: 0x44 : EXTI falling trigger selection register
$56025048 constant EXTI_S_EXTI_SWIER3  \ offset: 0x48 : EXTI software interrupt event register
$5602504c constant EXTI_S_EXTI_RPR3  \ offset: 0x4C : EXTI rising edge pending register
$56025050 constant EXTI_S_EXTI_FPR3  \ offset: 0x50 : EXTI falling edge pending register
$56025054 constant EXTI_S_EXTI_SECCFGR3  \ offset: 0x54 : EXTI security enable register
$56025058 constant EXTI_S_EXTI_PRIVCFGR3  \ offset: 0x58 : EXTI privilege enable register
$56025060 constant EXTI_S_EXTI_EXTICR1  \ offset: 0x60 : EXTI external interrupt selection register 1
$56025064 constant EXTI_S_EXTI_EXTICR2  \ offset: 0x64 : EXTI external interrupt selection register 2
$56025068 constant EXTI_S_EXTI_EXTICR3  \ offset: 0x68 : EXTI external interrupt selection register 3
$5602506c constant EXTI_S_EXTI_EXTICR4  \ offset: 0x6C : EXTI external interrupt selection register 4
$56025070 constant EXTI_S_EXTI_LOCKR  \ offset: 0x70 : EXTI lock register
$56025080 constant EXTI_S_EXTI_IMR1  \ offset: 0x80 : EXTI CPU wake-up with interrupt mask register 1
$56025084 constant EXTI_S_EXTI_EMR1  \ offset: 0x84 : EXTI CPU wake-up with event mask register 1
$56025090 constant EXTI_S_EXTI_IMR2  \ offset: 0x90 : EXTI CPU wake-up with interrupt mask register 2
$56025094 constant EXTI_S_EXTI_EMR2  \ offset: 0x94 : EXTI CPU wake-up with event mask register 2
$560250a0 constant EXTI_S_EXTI_IMR3  \ offset: 0xA0 : EXTI CPU wake-up with interrupt mask register 3
$560250a4 constant EXTI_S_EXTI_EMR3  \ offset: 0xA4 : EXTI CPU wake-up with event mask register 3

