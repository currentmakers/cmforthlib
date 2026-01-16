\
\ @file sec_exti.fs
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

$00000001 constant SEC_EXTI_RTSR1_RT0                               \ Rising trigger event configuration bit of configurable event input x
$00000002 constant SEC_EXTI_RTSR1_RT1                               \ Rising trigger event configuration bit of configurable event input x
$00000004 constant SEC_EXTI_RTSR1_RT2                               \ Rising trigger event configuration bit of configurable event input x
$00000008 constant SEC_EXTI_RTSR1_RT3                               \ Rising trigger event configuration bit of configurable event input x
$00000010 constant SEC_EXTI_RTSR1_RT4                               \ Rising trigger event configuration bit of configurable event input x
$00000020 constant SEC_EXTI_RTSR1_RT5                               \ Rising trigger event configuration bit of configurable event input x
$00000040 constant SEC_EXTI_RTSR1_RT6                               \ Rising trigger event configuration bit of configurable event input x
$00000080 constant SEC_EXTI_RTSR1_RT7                               \ Rising trigger event configuration bit of configurable event input x
$00000100 constant SEC_EXTI_RTSR1_RT8                               \ Rising trigger event configuration bit of configurable event input x
$00000200 constant SEC_EXTI_RTSR1_RT9                               \ Rising trigger event configuration bit of configurable event input x
$00000400 constant SEC_EXTI_RTSR1_RT10                              \ Rising trigger event configuration bit of configurable event input x
$00000800 constant SEC_EXTI_RTSR1_RT11                              \ Rising trigger event configuration bit of configurable event input x
$00001000 constant SEC_EXTI_RTSR1_RT12                              \ Rising trigger event configuration bit of configurable event input x
$00002000 constant SEC_EXTI_RTSR1_RT13                              \ Rising trigger event configuration bit of configurable event input x
$00004000 constant SEC_EXTI_RTSR1_RT14                              \ Rising trigger event configuration bit of configurable event input x
$00008000 constant SEC_EXTI_RTSR1_RT15                              \ Rising trigger event configuration bit of configurable event input x
$00010000 constant SEC_EXTI_RTSR1_RT16                              \ Rising trigger event configuration bit of configurable event input x
$00200000 constant SEC_EXTI_RTSR1_RT21                              \ Rising trigger event configuration bit of configurable event input x
$00400000 constant SEC_EXTI_RTSR1_RT22                              \ Rising trigger event configuration bit of configurable event input x


\
\ @brief EXTI falling trigger selection register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_EXTI_FTSR1_FT0                               \ Falling trigger event configuration bit of configurable event input x
$00000002 constant SEC_EXTI_FTSR1_FT1                               \ Falling trigger event configuration bit of configurable event input x
$00000004 constant SEC_EXTI_FTSR1_FT2                               \ Falling trigger event configuration bit of configurable event input x
$00000008 constant SEC_EXTI_FTSR1_FT3                               \ Falling trigger event configuration bit of configurable event input x
$00000010 constant SEC_EXTI_FTSR1_FT4                               \ Falling trigger event configuration bit of configurable event input x
$00000020 constant SEC_EXTI_FTSR1_FT5                               \ Falling trigger event configuration bit of configurable event input x
$00000040 constant SEC_EXTI_FTSR1_FT6                               \ Falling trigger event configuration bit of configurable event input x
$00000080 constant SEC_EXTI_FTSR1_FT7                               \ Falling trigger event configuration bit of configurable event input x
$00000100 constant SEC_EXTI_FTSR1_FT8                               \ Falling trigger event configuration bit of configurable event input x
$00000200 constant SEC_EXTI_FTSR1_FT9                               \ Falling trigger event configuration bit of configurable event input x
$00000400 constant SEC_EXTI_FTSR1_FT10                              \ Falling trigger event configuration bit of configurable event input x
$00000800 constant SEC_EXTI_FTSR1_FT11                              \ Falling trigger event configuration bit of configurable event input x
$00001000 constant SEC_EXTI_FTSR1_FT12                              \ Falling trigger event configuration bit of configurable event input x
$00002000 constant SEC_EXTI_FTSR1_FT13                              \ Falling trigger event configuration bit of configurable event input x
$00004000 constant SEC_EXTI_FTSR1_FT14                              \ Falling trigger event configuration bit of configurable event input x
$00008000 constant SEC_EXTI_FTSR1_FT15                              \ Falling trigger event configuration bit of configurable event input x
$00010000 constant SEC_EXTI_FTSR1_FT16                              \ Falling trigger event configuration bit of configurable event input x
$00200000 constant SEC_EXTI_FTSR1_FT21                              \ Falling trigger event configuration bit of configurable event input x
$00400000 constant SEC_EXTI_FTSR1_FT22                              \ Falling trigger event configuration bit of configurable event input x


\
\ @brief EXTI software interrupt event register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SEC_EXTI_SWIER1_SWI0                             \ Software interrupt on event x
$00000002 constant SEC_EXTI_SWIER1_SWI1                             \ Software interrupt on event x
$00000004 constant SEC_EXTI_SWIER1_SWI2                             \ Software interrupt on event x
$00000008 constant SEC_EXTI_SWIER1_SWI3                             \ Software interrupt on event x
$00000010 constant SEC_EXTI_SWIER1_SWI4                             \ Software interrupt on event x
$00000020 constant SEC_EXTI_SWIER1_SWI5                             \ Software interrupt on event x
$00000040 constant SEC_EXTI_SWIER1_SWI6                             \ Software interrupt on event x
$00000080 constant SEC_EXTI_SWIER1_SWI7                             \ Software interrupt on event x
$00000100 constant SEC_EXTI_SWIER1_SWI8                             \ Software interrupt on event x
$00000200 constant SEC_EXTI_SWIER1_SWI9                             \ Software interrupt on event x
$00000400 constant SEC_EXTI_SWIER1_SWI10                            \ Software interrupt on event x
$00000800 constant SEC_EXTI_SWIER1_SWI11                            \ Software interrupt on event x
$00001000 constant SEC_EXTI_SWIER1_SWI12                            \ Software interrupt on event x
$00002000 constant SEC_EXTI_SWIER1_SWI13                            \ Software interrupt on event x
$00004000 constant SEC_EXTI_SWIER1_SWI14                            \ Software interrupt on event x
$00008000 constant SEC_EXTI_SWIER1_SWI15                            \ Software interrupt on event x
$00010000 constant SEC_EXTI_SWIER1_SWI16                            \ Software interrupt on event x
$00200000 constant SEC_EXTI_SWIER1_SWI21                            \ Software interrupt on event x
$00400000 constant SEC_EXTI_SWIER1_SWI22                            \ Software interrupt on event x


\
\ @brief EXTI rising edge pending register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SEC_EXTI_RPR1_RPIF0                              \ configurable event inputs x rising edge pending bit
$00000002 constant SEC_EXTI_RPR1_RPIF1                              \ configurable event inputs x rising edge pending bit
$00000004 constant SEC_EXTI_RPR1_RPIF2                              \ configurable event inputs x rising edge pending bit
$00000008 constant SEC_EXTI_RPR1_RPIF3                              \ configurable event inputs x rising edge pending bit
$00000010 constant SEC_EXTI_RPR1_RPIF4                              \ configurable event inputs x rising edge pending bit
$00000020 constant SEC_EXTI_RPR1_RPIF5                              \ configurable event inputs x rising edge pending bit
$00000040 constant SEC_EXTI_RPR1_RPIF6                              \ configurable event inputs x rising edge pending bit
$00000080 constant SEC_EXTI_RPR1_RPIF7                              \ configurable event inputs x rising edge pending bit
$00000100 constant SEC_EXTI_RPR1_RPIF8                              \ configurable event inputs x rising edge pending bit
$00000200 constant SEC_EXTI_RPR1_RPIF9                              \ configurable event inputs x rising edge pending bit
$00000400 constant SEC_EXTI_RPR1_RPIF10                             \ configurable event inputs x rising edge pending bit
$00000800 constant SEC_EXTI_RPR1_RPIF11                             \ configurable event inputs x rising edge pending bit
$00001000 constant SEC_EXTI_RPR1_RPIF12                             \ configurable event inputs x rising edge pending bit
$00002000 constant SEC_EXTI_RPR1_RPIF13                             \ configurable event inputs x rising edge pending bit
$00004000 constant SEC_EXTI_RPR1_RPIF14                             \ configurable event inputs x rising edge pending bit
$00008000 constant SEC_EXTI_RPR1_RPIF15                             \ configurable event inputs x rising edge pending bit
$00010000 constant SEC_EXTI_RPR1_RPIF16                             \ configurable event inputs x rising edge pending bit
$00200000 constant SEC_EXTI_RPR1_RPIF21                             \ configurable event inputs x rising edge pending bit
$00400000 constant SEC_EXTI_RPR1_RPIF22                             \ configurable event inputs x rising edge pending bit


\
\ @brief EXTI falling edge pending register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_EXTI_FPR1_FPIF0                              \ configurable event inputs x falling edge pending bit.
$00000002 constant SEC_EXTI_FPR1_FPIF1                              \ configurable event inputs x falling edge pending bit.
$00000004 constant SEC_EXTI_FPR1_FPIF2                              \ configurable event inputs x falling edge pending bit.
$00000008 constant SEC_EXTI_FPR1_FPIF3                              \ configurable event inputs x falling edge pending bit.
$00000010 constant SEC_EXTI_FPR1_FPIF4                              \ configurable event inputs x falling edge pending bit.
$00000020 constant SEC_EXTI_FPR1_FPIF5                              \ configurable event inputs x falling edge pending bit.
$00000040 constant SEC_EXTI_FPR1_FPIF6                              \ configurable event inputs x falling edge pending bit.
$00000080 constant SEC_EXTI_FPR1_FPIF7                              \ configurable event inputs x falling edge pending bit.
$00000100 constant SEC_EXTI_FPR1_FPIF8                              \ configurable event inputs x falling edge pending bit.
$00000200 constant SEC_EXTI_FPR1_FPIF9                              \ configurable event inputs x falling edge pending bit.
$00000400 constant SEC_EXTI_FPR1_FPIF10                             \ configurable event inputs x falling edge pending bit.
$00000800 constant SEC_EXTI_FPR1_FPIF11                             \ configurable event inputs x falling edge pending bit.
$00001000 constant SEC_EXTI_FPR1_FPIF12                             \ configurable event inputs x falling edge pending bit.
$00002000 constant SEC_EXTI_FPR1_FPIF13                             \ configurable event inputs x falling edge pending bit.
$00004000 constant SEC_EXTI_FPR1_FPIF14                             \ configurable event inputs x falling edge pending bit.
$00008000 constant SEC_EXTI_FPR1_FPIF15                             \ configurable event inputs x falling edge pending bit.
$00010000 constant SEC_EXTI_FPR1_FPIF16                             \ configurable event inputs x falling edge pending bit.
$00200000 constant SEC_EXTI_FPR1_FPIF21                             \ configurable event inputs x falling edge pending bit.
$00400000 constant SEC_EXTI_FPR1_FPIF22                             \ configurable event inputs x falling edge pending bit.


\
\ @brief EXTI security configuration register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SEC_EXTI_SECCFGR1_SEC0                           \ Security enable on event input x
$00000002 constant SEC_EXTI_SECCFGR1_SEC1                           \ Security enable on event input x
$00000004 constant SEC_EXTI_SECCFGR1_SEC2                           \ Security enable on event input x
$00000008 constant SEC_EXTI_SECCFGR1_SEC3                           \ Security enable on event input x
$00000010 constant SEC_EXTI_SECCFGR1_SEC4                           \ Security enable on event input x
$00000020 constant SEC_EXTI_SECCFGR1_SEC5                           \ Security enable on event input x
$00000040 constant SEC_EXTI_SECCFGR1_SEC6                           \ Security enable on event input x
$00000080 constant SEC_EXTI_SECCFGR1_SEC7                           \ Security enable on event input x
$00000100 constant SEC_EXTI_SECCFGR1_SEC8                           \ Security enable on event input x
$00000200 constant SEC_EXTI_SECCFGR1_SEC9                           \ Security enable on event input x
$00000400 constant SEC_EXTI_SECCFGR1_SEC10                          \ Security enable on event input x
$00000800 constant SEC_EXTI_SECCFGR1_SEC11                          \ Security enable on event input x
$00001000 constant SEC_EXTI_SECCFGR1_SEC12                          \ Security enable on event input x
$00002000 constant SEC_EXTI_SECCFGR1_SEC13                          \ Security enable on event input x
$00004000 constant SEC_EXTI_SECCFGR1_SEC14                          \ Security enable on event input x
$00008000 constant SEC_EXTI_SECCFGR1_SEC15                          \ Security enable on event input x
$00010000 constant SEC_EXTI_SECCFGR1_SEC16                          \ Security enable on event input x
$00020000 constant SEC_EXTI_SECCFGR1_SEC17                          \ Security enable on event input x
$00040000 constant SEC_EXTI_SECCFGR1_SEC18                          \ Security enable on event input x
$00080000 constant SEC_EXTI_SECCFGR1_SEC19                          \ Security enable on event input x
$00100000 constant SEC_EXTI_SECCFGR1_SEC20                          \ Security enable on event input x
$00200000 constant SEC_EXTI_SECCFGR1_SEC21                          \ Security enable on event input x
$00400000 constant SEC_EXTI_SECCFGR1_SEC22                          \ Security enable on event input x
$00800000 constant SEC_EXTI_SECCFGR1_SEC23                          \ Security enable on event input x
$01000000 constant SEC_EXTI_SECCFGR1_SEC24                          \ Security enable on event input x
$02000000 constant SEC_EXTI_SECCFGR1_SEC25                          \ Security enable on event input x
$04000000 constant SEC_EXTI_SECCFGR1_SEC26                          \ Security enable on event input x
$08000000 constant SEC_EXTI_SECCFGR1_SEC27                          \ Security enable on event input x
$10000000 constant SEC_EXTI_SECCFGR1_SEC28                          \ Security enable on event input x
$20000000 constant SEC_EXTI_SECCFGR1_SEC29                          \ Security enable on event input x
$40000000 constant SEC_EXTI_SECCFGR1_SEC30                          \ Security enable on event input x
$80000000 constant SEC_EXTI_SECCFGR1_SEC31                          \ Security enable on event input x


\
\ @brief EXTI privilege configuration register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SEC_EXTI_PRIVCFGR1_PRIV0                         \ Security enable on event input x
$00000002 constant SEC_EXTI_PRIVCFGR1_PRIV1                         \ Security enable on event input x
$00000004 constant SEC_EXTI_PRIVCFGR1_PRIV2                         \ Security enable on event input x
$00000008 constant SEC_EXTI_PRIVCFGR1_PRIV3                         \ Security enable on event input x
$00000010 constant SEC_EXTI_PRIVCFGR1_PRIV4                         \ Security enable on event input x
$00000020 constant SEC_EXTI_PRIVCFGR1_PRIV5                         \ Security enable on event input x
$00000040 constant SEC_EXTI_PRIVCFGR1_PRIV6                         \ Security enable on event input x
$00000080 constant SEC_EXTI_PRIVCFGR1_PRIV7                         \ Security enable on event input x
$00000100 constant SEC_EXTI_PRIVCFGR1_PRIV8                         \ Security enable on event input x
$00000200 constant SEC_EXTI_PRIVCFGR1_PRIV9                         \ Security enable on event input x
$00000400 constant SEC_EXTI_PRIVCFGR1_PRIV10                        \ Security enable on event input x
$00000800 constant SEC_EXTI_PRIVCFGR1_PRIV11                        \ Security enable on event input x
$00001000 constant SEC_EXTI_PRIVCFGR1_PRIV12                        \ Security enable on event input x
$00002000 constant SEC_EXTI_PRIVCFGR1_PRIV13                        \ Security enable on event input x
$00004000 constant SEC_EXTI_PRIVCFGR1_PRIV14                        \ Security enable on event input x
$00008000 constant SEC_EXTI_PRIVCFGR1_PRIV15                        \ Security enable on event input x
$00010000 constant SEC_EXTI_PRIVCFGR1_PRIV16                        \ Security enable on event input x
$00020000 constant SEC_EXTI_PRIVCFGR1_PRIV17                        \ Security enable on event input x
$00040000 constant SEC_EXTI_PRIVCFGR1_PRIV18                        \ Security enable on event input x
$00080000 constant SEC_EXTI_PRIVCFGR1_PRIV19                        \ Security enable on event input x
$00100000 constant SEC_EXTI_PRIVCFGR1_PRIV20                        \ Security enable on event input x
$00200000 constant SEC_EXTI_PRIVCFGR1_PRIV21                        \ Security enable on event input x
$00400000 constant SEC_EXTI_PRIVCFGR1_PRIV22                        \ Security enable on event input x
$00800000 constant SEC_EXTI_PRIVCFGR1_PRIV23                        \ Security enable on event input x
$01000000 constant SEC_EXTI_PRIVCFGR1_PRIV24                        \ Security enable on event input x
$02000000 constant SEC_EXTI_PRIVCFGR1_PRIV25                        \ Security enable on event input x
$04000000 constant SEC_EXTI_PRIVCFGR1_PRIV26                        \ Security enable on event input x
$08000000 constant SEC_EXTI_PRIVCFGR1_PRIV27                        \ Security enable on event input x
$10000000 constant SEC_EXTI_PRIVCFGR1_PRIV28                        \ Security enable on event input x
$20000000 constant SEC_EXTI_PRIVCFGR1_PRIV29                        \ Security enable on event input x
$40000000 constant SEC_EXTI_PRIVCFGR1_PRIV30                        \ Security enable on event input x
$80000000 constant SEC_EXTI_PRIVCFGR1_PRIV31                        \ Security enable on event input x


\
\ @brief EXTI rising trigger selection register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000008 constant SEC_EXTI_RTSR2_RT35                              \ Rising trigger event configuration bit of configurable event input x
$00000010 constant SEC_EXTI_RTSR2_RT36                              \ Rising trigger event configuration bit of configurable event input x
$00000020 constant SEC_EXTI_RTSR2_RT37                              \ Rising trigger event configuration bit of configurable event input x
$00000040 constant SEC_EXTI_RTSR2_RT38                              \ Rising trigger event configuration bit of configurable event input x


\
\ @brief EXTI falling trigger selection register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000008 constant SEC_EXTI_FTSR2_FT35                              \ FT35
$00000010 constant SEC_EXTI_FTSR2_FT36                              \ FT36
$00000020 constant SEC_EXTI_FTSR2_FT37                              \ FT37
$00000040 constant SEC_EXTI_FTSR2_FT38                              \ FT38


\
\ @brief EXTI software interrupt event register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000008 constant SEC_EXTI_SWIER2_SWI35                            \ SWI35
$00000010 constant SEC_EXTI_SWIER2_SWI36                            \ SWI36
$00000020 constant SEC_EXTI_SWIER2_SWI37                            \ SWI37
$00000040 constant SEC_EXTI_SWIER2_SWI38                            \ SWI38


\
\ @brief EXTI rising edge pending register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000008 constant SEC_EXTI_RPR2_RPIF35                             \ RPIF35
$00000010 constant SEC_EXTI_RPR2_RPIF36                             \ RPIF36
$00000020 constant SEC_EXTI_RPR2_RPIF37                             \ RPIF37
$00000040 constant SEC_EXTI_RPR2_RPIF38                             \ RPIF38


\
\ @brief EXTI falling edge pending register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000008 constant SEC_EXTI_FPR2_FPIF35                             \ FPIF35
$00000010 constant SEC_EXTI_FPR2_FPIF36                             \ FPIF36
$00000020 constant SEC_EXTI_FPR2_FPIF37                             \ FPIF37
$00000040 constant SEC_EXTI_FPR2_FPIF38                             \ FPIF38


\
\ @brief EXTI security enable register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant SEC_EXTI_PRIVCFGR2_PRIV32                        \ PRIV32
$00000002 constant SEC_EXTI_PRIVCFGR2_PRIV33                        \ PRIV33
$00000004 constant SEC_EXTI_PRIVCFGR2_PRIV34                        \ PRIV34
$00000008 constant SEC_EXTI_PRIVCFGR2_PRIV35                        \ PRIV35
$00000010 constant SEC_EXTI_PRIVCFGR2_PRIV36                        \ PRIV36
$00000020 constant SEC_EXTI_PRIVCFGR2_PRIV37                        \ PRIV37
$00000040 constant SEC_EXTI_PRIVCFGR2_PRIV38                        \ PRIV38
$00000080 constant SEC_EXTI_PRIVCFGR2_PRIV39                        \ PRIV39
$00000100 constant SEC_EXTI_PRIVCFGR2_PRIV40                        \ PRIV40
$00000200 constant SEC_EXTI_PRIVCFGR2_PRIV41                        \ PRIV41
$00000400 constant SEC_EXTI_PRIVCFGR2_PRIV42                        \ PRIV42


\
\ @brief EXTI security enable register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant SEC_EXTI_SECCFGR2_SEC32                          \ SEC32
$00000002 constant SEC_EXTI_SECCFGR2_SEC33                          \ SEC33
$00000004 constant SEC_EXTI_SECCFGR2_SEC34                          \ SEC34
$00000008 constant SEC_EXTI_SECCFGR2_SEC35                          \ SEC35
$00000010 constant SEC_EXTI_SECCFGR2_SEC36                          \ SEC36
$00000020 constant SEC_EXTI_SECCFGR2_SEC37                          \ SEC37
$00000040 constant SEC_EXTI_SECCFGR2_SEC38                          \ SEC38
$00000080 constant SEC_EXTI_SECCFGR2_SEC39                          \ SEC39
$00000100 constant SEC_EXTI_SECCFGR2_SEC40                          \ SEC40
$00000200 constant SEC_EXTI_SECCFGR2_SEC41                          \ SEC41
$00000400 constant SEC_EXTI_SECCFGR2_SEC42                          \ SEC42


\
\ @brief EXTI external interrupt selection register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$000000ff constant SEC_EXTI_EXTICR1_EXTI0_7                         \ EXTIm GPIO port selection
$0000ff00 constant SEC_EXTI_EXTICR1_EXTI8_15                        \ EXTIm+1 GPIO port selection
$00ff0000 constant SEC_EXTI_EXTICR1_EXTI16_23                       \ EXTIm+2 GPIO port selection
$ff000000 constant SEC_EXTI_EXTICR1_EXTI24_31                       \ EXTIm+3 GPIO port selection


\
\ @brief EXTI external interrupt selection register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$000000ff constant SEC_EXTI_EXTICR2_EXTI0_7                         \ EXTIm GPIO port selection
$0000ff00 constant SEC_EXTI_EXTICR2_EXTI8_15                        \ EXTIm+1 GPIO port selection
$00ff0000 constant SEC_EXTI_EXTICR2_EXTI16_23                       \ EXTIm+2 GPIO port selection
$ff000000 constant SEC_EXTI_EXTICR2_EXTI24_31                       \ EXTIm+3 GPIO port selection


\
\ @brief EXTI external interrupt selection register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$000000ff constant SEC_EXTI_EXTICR3_EXTI0_7                         \ EXTIm GPIO port selection
$0000ff00 constant SEC_EXTI_EXTICR3_EXTI8_15                        \ EXTIm+1 GPIO port selection
$00ff0000 constant SEC_EXTI_EXTICR3_EXTI16_23                       \ EXTIm+2 GPIO port selection
$ff000000 constant SEC_EXTI_EXTICR3_EXTI24_31                       \ EXTIm+3 GPIO port selection


\
\ @brief EXTI external interrupt selection register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$000000ff constant SEC_EXTI_EXTICR4_EXTI0_7                         \ EXTIm GPIO port selection
$0000ff00 constant SEC_EXTI_EXTICR4_EXTI8_15                        \ EXTIm+1 GPIO port selection
$00ff0000 constant SEC_EXTI_EXTICR4_EXTI16_23                       \ EXTIm+2 GPIO port selection
$ff000000 constant SEC_EXTI_EXTICR4_EXTI24_31                       \ EXTIm+3 GPIO port selection


\
\ @brief EXTI lock register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant SEC_EXTI_LOCKRG_LOCK                             \ LOCK


\
\ @brief EXTI CPU wakeup with interrupt mask register
\ Address offset: 0x80
\ Reset value: 0xFF9E0000
\

$00000001 constant SEC_EXTI_IMR1_IM0                                \ CPU wakeup with interrupt mask on event input
$00000002 constant SEC_EXTI_IMR1_IM1                                \ CPU wakeup with interrupt mask on event input
$00000004 constant SEC_EXTI_IMR1_IM2                                \ CPU wakeup with interrupt mask on event input
$00000008 constant SEC_EXTI_IMR1_IM3                                \ CPU wakeup with interrupt mask on event input
$00000010 constant SEC_EXTI_IMR1_IM4                                \ CPU wakeup with interrupt mask on event input
$00000020 constant SEC_EXTI_IMR1_IM5                                \ CPU wakeup with interrupt mask on event input
$00000040 constant SEC_EXTI_IMR1_IM6                                \ CPU wakeup with interrupt mask on event input
$00000080 constant SEC_EXTI_IMR1_IM7                                \ CPU wakeup with interrupt mask on event input
$00000100 constant SEC_EXTI_IMR1_IM8                                \ CPU wakeup with interrupt mask on event input
$00000200 constant SEC_EXTI_IMR1_IM9                                \ CPU wakeup with interrupt mask on event input
$00000400 constant SEC_EXTI_IMR1_IM10                               \ CPU wakeup with interrupt mask on event input
$00000800 constant SEC_EXTI_IMR1_IM11                               \ CPU wakeup with interrupt mask on event input
$00001000 constant SEC_EXTI_IMR1_IM12                               \ CPU wakeup with interrupt mask on event input
$00002000 constant SEC_EXTI_IMR1_IM13                               \ CPU wakeup with interrupt mask on event input
$00004000 constant SEC_EXTI_IMR1_IM14                               \ CPU wakeup with interrupt mask on event input
$00008000 constant SEC_EXTI_IMR1_IM15                               \ CPU wakeup with interrupt mask on event input
$00010000 constant SEC_EXTI_IMR1_IM16                               \ CPU wakeup with interrupt mask on event input
$00020000 constant SEC_EXTI_IMR1_IM17                               \ CPU wakeup with interrupt mask on event input
$00040000 constant SEC_EXTI_IMR1_IM18                               \ CPU wakeup with interrupt mask on event input
$00080000 constant SEC_EXTI_IMR1_IM19                               \ CPU wakeup with interrupt mask on event input
$00100000 constant SEC_EXTI_IMR1_IM20                               \ CPU wakeup with interrupt mask on event input
$00200000 constant SEC_EXTI_IMR1_IM21                               \ CPU wakeup with interrupt mask on event input
$00400000 constant SEC_EXTI_IMR1_IM22                               \ CPU wakeup with interrupt mask on event input
$00800000 constant SEC_EXTI_IMR1_IM23                               \ CPU wakeup with interrupt mask on event input
$01000000 constant SEC_EXTI_IMR1_IM24                               \ CPU wakeup with interrupt mask on event input
$02000000 constant SEC_EXTI_IMR1_IM25                               \ CPU wakeup with interrupt mask on event input
$04000000 constant SEC_EXTI_IMR1_IM26                               \ CPU wakeup with interrupt mask on event input
$08000000 constant SEC_EXTI_IMR1_IM27                               \ CPU wakeup with interrupt mask on event input
$10000000 constant SEC_EXTI_IMR1_IM28                               \ CPU wakeup with interrupt mask on event input
$20000000 constant SEC_EXTI_IMR1_IM29                               \ CPU wakeup with interrupt mask on event input
$40000000 constant SEC_EXTI_IMR1_IM30                               \ CPU wakeup with interrupt mask on event input
$80000000 constant SEC_EXTI_IMR1_IM31                               \ CPU wakeup with interrupt mask on event input


\
\ @brief EXTI CPU wakeup with event mask register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant SEC_EXTI_EMR1_EM0                                \ CPU wakeup with interrupt mask on event input
$00000002 constant SEC_EXTI_EMR1_EM1                                \ CPU wakeup with interrupt mask on event input
$00000004 constant SEC_EXTI_EMR1_EM2                                \ CPU wakeup with interrupt mask on event input
$00000008 constant SEC_EXTI_EMR1_EM3                                \ CPU wakeup with interrupt mask on event input
$00000010 constant SEC_EXTI_EMR1_EM4                                \ CPU wakeup with interrupt mask on event input
$00000020 constant SEC_EXTI_EMR1_EM5                                \ CPU wakeup with interrupt mask on event input
$00000040 constant SEC_EXTI_EMR1_EM6                                \ CPU wakeup with interrupt mask on event input
$00000080 constant SEC_EXTI_EMR1_EM7                                \ CPU wakeup with interrupt mask on event input
$00000100 constant SEC_EXTI_EMR1_EM8                                \ CPU wakeup with interrupt mask on event input
$00000200 constant SEC_EXTI_EMR1_EM9                                \ CPU wakeup with interrupt mask on event input
$00000400 constant SEC_EXTI_EMR1_EM10                               \ CPU wakeup with interrupt mask on event input
$00000800 constant SEC_EXTI_EMR1_EM11                               \ CPU wakeup with interrupt mask on event input
$00001000 constant SEC_EXTI_EMR1_EM12                               \ CPU wakeup with interrupt mask on event input
$00002000 constant SEC_EXTI_EMR1_EM13                               \ CPU wakeup with interrupt mask on event input
$00004000 constant SEC_EXTI_EMR1_EM14                               \ CPU wakeup with interrupt mask on event input
$00008000 constant SEC_EXTI_EMR1_EM15                               \ CPU wakeup with interrupt mask on event input
$00010000 constant SEC_EXTI_EMR1_EM16                               \ CPU wakeup with interrupt mask on event input
$00020000 constant SEC_EXTI_EMR1_EM17                               \ CPU wakeup with interrupt mask on event input
$00040000 constant SEC_EXTI_EMR1_EM18                               \ CPU wakeup with interrupt mask on event input
$00080000 constant SEC_EXTI_EMR1_EM19                               \ CPU wakeup with interrupt mask on event input
$00100000 constant SEC_EXTI_EMR1_EM20                               \ CPU wakeup with interrupt mask on event input
$00200000 constant SEC_EXTI_EMR1_EM21                               \ CPU wakeup with interrupt mask on event input
$00400000 constant SEC_EXTI_EMR1_EM22                               \ CPU wakeup with interrupt mask on event input
$00800000 constant SEC_EXTI_EMR1_EM23                               \ CPU wakeup with interrupt mask on event input
$01000000 constant SEC_EXTI_EMR1_EM24                               \ CPU wakeup with interrupt mask on event input
$02000000 constant SEC_EXTI_EMR1_EM25                               \ CPU wakeup with interrupt mask on event input
$04000000 constant SEC_EXTI_EMR1_EM26                               \ CPU wakeup with interrupt mask on event input
$08000000 constant SEC_EXTI_EMR1_EM27                               \ CPU wakeup with interrupt mask on event input
$10000000 constant SEC_EXTI_EMR1_EM28                               \ CPU wakeup with interrupt mask on event input
$20000000 constant SEC_EXTI_EMR1_EM29                               \ CPU wakeup with interrupt mask on event input
$40000000 constant SEC_EXTI_EMR1_EM30                               \ CPU wakeup with interrupt mask on event input
$80000000 constant SEC_EXTI_EMR1_EM31                               \ CPU wakeup with interrupt mask on event input


\
\ @brief EXTI CPUm wakeup with interrupt mask register
\ Address offset: 0x90
\ Reset value: 0x00000787
\

$00000001 constant SEC_EXTI_IMR2_IM32                               \ CPU wakeup with interrupt mask on event input
$00000002 constant SEC_EXTI_IMR2_IM33                               \ CPU wakeup with interrupt mask on event input
$00000004 constant SEC_EXTI_IMR2_IM34                               \ CPU wakeup with interrupt mask on event input
$00000008 constant SEC_EXTI_IMR2_IM35                               \ CPU wakeup with interrupt mask on event input
$00000010 constant SEC_EXTI_IMR2_IM36                               \ CPU wakeup with interrupt mask on event input
$00000020 constant SEC_EXTI_IMR2_IM37                               \ CPU wakeup with interrupt mask on event input
$00000040 constant SEC_EXTI_IMR2_IM38                               \ CPU wakeup with interrupt mask on event input
$00000100 constant SEC_EXTI_IMR2_IM40                               \ CPU wakeup with interrupt mask on event input
$00000200 constant SEC_EXTI_IMR2_IM41                               \ CPU wakeup with interrupt mask on event input
$00000400 constant SEC_EXTI_IMR2_IM42                               \ CPU wakeup with interrupt mask on event input


\
\ @brief EXTI CPU wakeup with event mask register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant SEC_EXTI_EMR2_EM32                               \ CPU wakeup with interrupt mask on event input
$00000002 constant SEC_EXTI_EMR2_EM33                               \ CPU wakeup with interrupt mask on event input
$00000004 constant SEC_EXTI_EMR2_EM34                               \ CPU wakeup with interrupt mask on event input
$00000008 constant SEC_EXTI_EMR2_EM35                               \ CPU wakeup with interrupt mask on event input
$00000010 constant SEC_EXTI_EMR2_EM36                               \ CPU wakeup with interrupt mask on event input
$00000020 constant SEC_EXTI_EMR2_EM37                               \ CPU wakeup with interrupt mask on event input
$00000040 constant SEC_EXTI_EMR2_EM38                               \ CPU wakeup with interrupt mask on event input
$00000100 constant SEC_EXTI_EMR2_EM40                               \ CPU wakeup with interrupt mask on event input
$00000200 constant SEC_EXTI_EMR2_EM41                               \ CPU wakeup with interrupt mask on event input
$00000400 constant SEC_EXTI_EMR2_EM42                               \ CPU wakeup with interrupt mask on event input


\
\ @brief External interrupt/event controller
\
$5002f400 constant SEC_EXTI_RTSR1  \ offset: 0x00 : EXTI rising trigger selection register
$5002f404 constant SEC_EXTI_FTSR1  \ offset: 0x04 : EXTI falling trigger selection register
$5002f408 constant SEC_EXTI_SWIER1  \ offset: 0x08 : EXTI software interrupt event register
$5002f40c constant SEC_EXTI_RPR1  \ offset: 0x0C : EXTI rising edge pending register
$5002f410 constant SEC_EXTI_FPR1  \ offset: 0x10 : EXTI falling edge pending register
$5002f414 constant SEC_EXTI_SECCFGR1  \ offset: 0x14 : EXTI security configuration register
$5002f418 constant SEC_EXTI_PRIVCFGR1  \ offset: 0x18 : EXTI privilege configuration register
$5002f420 constant SEC_EXTI_RTSR2  \ offset: 0x20 : EXTI rising trigger selection register
$5002f424 constant SEC_EXTI_FTSR2  \ offset: 0x24 : EXTI falling trigger selection register
$5002f428 constant SEC_EXTI_SWIER2  \ offset: 0x28 : EXTI software interrupt event register
$5002f42c constant SEC_EXTI_RPR2  \ offset: 0x2C : EXTI rising edge pending register
$5002f430 constant SEC_EXTI_FPR2  \ offset: 0x30 : EXTI falling edge pending register
$5002f434 constant SEC_EXTI_PRIVCFGR2  \ offset: 0x34 : EXTI security enable register
$5002f438 constant SEC_EXTI_SECCFGR2  \ offset: 0x38 : EXTI security enable register
$5002f460 constant SEC_EXTI_EXTICR1  \ offset: 0x60 : EXTI external interrupt selection register
$5002f464 constant SEC_EXTI_EXTICR2  \ offset: 0x64 : EXTI external interrupt selection register
$5002f468 constant SEC_EXTI_EXTICR3  \ offset: 0x68 : EXTI external interrupt selection register
$5002f46c constant SEC_EXTI_EXTICR4  \ offset: 0x6C : EXTI external interrupt selection register
$5002f470 constant SEC_EXTI_LOCKRG  \ offset: 0x70 : EXTI lock register
$5002f480 constant SEC_EXTI_IMR1  \ offset: 0x80 : EXTI CPU wakeup with interrupt mask register
$5002f484 constant SEC_EXTI_EMR1  \ offset: 0x84 : EXTI CPU wakeup with event mask register
$5002f490 constant SEC_EXTI_IMR2  \ offset: 0x90 : EXTI CPUm wakeup with interrupt mask register
$5002f494 constant SEC_EXTI_EMR2  \ offset: 0x94 : EXTI CPU wakeup with event mask register

