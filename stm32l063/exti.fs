\
\ @file exti.fs
\ @brief External interrupt/event       controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Interrupt mask register (EXTI_IMR)
\ Address offset: 0x00
\ Reset value: 0xFF840000
\

$00000001 constant EXTI_IMR_IM0                                     \ Interrupt Mask on line 0
$00000002 constant EXTI_IMR_IM1                                     \ Interrupt Mask on line 1
$00000004 constant EXTI_IMR_IM2                                     \ Interrupt Mask on line 2
$00000008 constant EXTI_IMR_IM3                                     \ Interrupt Mask on line 3
$00000010 constant EXTI_IMR_IM4                                     \ Interrupt Mask on line 4
$00000020 constant EXTI_IMR_IM5                                     \ Interrupt Mask on line 5
$00000040 constant EXTI_IMR_IM6                                     \ Interrupt Mask on line 6
$00000080 constant EXTI_IMR_IM7                                     \ Interrupt Mask on line 7
$00000100 constant EXTI_IMR_IM8                                     \ Interrupt Mask on line 8
$00000200 constant EXTI_IMR_IM9                                     \ Interrupt Mask on line 9
$00000400 constant EXTI_IMR_IM10                                    \ Interrupt Mask on line 10
$00000800 constant EXTI_IMR_IM11                                    \ Interrupt Mask on line 11
$00001000 constant EXTI_IMR_IM12                                    \ Interrupt Mask on line 12
$00002000 constant EXTI_IMR_IM13                                    \ Interrupt Mask on line 13
$00004000 constant EXTI_IMR_IM14                                    \ Interrupt Mask on line 14
$00008000 constant EXTI_IMR_IM15                                    \ Interrupt Mask on line 15
$00010000 constant EXTI_IMR_IM16                                    \ Interrupt Mask on line 16
$00020000 constant EXTI_IMR_IM17                                    \ Interrupt Mask on line 17
$00040000 constant EXTI_IMR_IM18                                    \ Interrupt Mask on line 18
$00080000 constant EXTI_IMR_IM19                                    \ Interrupt Mask on line 19
$00100000 constant EXTI_IMR_IM20                                    \ Interrupt Mask on line 20
$00200000 constant EXTI_IMR_IM21                                    \ Interrupt Mask on line 21
$00400000 constant EXTI_IMR_IM22                                    \ Interrupt Mask on line 22
$00800000 constant EXTI_IMR_IM23                                    \ Interrupt Mask on line 23
$01000000 constant EXTI_IMR_IM24                                    \ Interrupt Mask on line 24
$02000000 constant EXTI_IMR_IM25                                    \ Interrupt Mask on line 25
$04000000 constant EXTI_IMR_IM26                                    \ Interrupt Mask on line 27
$10000000 constant EXTI_IMR_IM28                                    \ Interrupt Mask on line 27
$20000000 constant EXTI_IMR_IM29                                    \ Interrupt Mask on line 27


\
\ @brief Event mask register (EXTI_EMR)
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EMR_EM0                                     \ Event Mask on line 0
$00000002 constant EXTI_EMR_EM1                                     \ Event Mask on line 1
$00000004 constant EXTI_EMR_EM2                                     \ Event Mask on line 2
$00000008 constant EXTI_EMR_EM3                                     \ Event Mask on line 3
$00000010 constant EXTI_EMR_EM4                                     \ Event Mask on line 4
$00000020 constant EXTI_EMR_EM5                                     \ Event Mask on line 5
$00000040 constant EXTI_EMR_EM6                                     \ Event Mask on line 6
$00000080 constant EXTI_EMR_EM7                                     \ Event Mask on line 7
$00000100 constant EXTI_EMR_EM8                                     \ Event Mask on line 8
$00000200 constant EXTI_EMR_EM9                                     \ Event Mask on line 9
$00000400 constant EXTI_EMR_EM10                                    \ Event Mask on line 10
$00000800 constant EXTI_EMR_EM11                                    \ Event Mask on line 11
$00001000 constant EXTI_EMR_EM12                                    \ Event Mask on line 12
$00002000 constant EXTI_EMR_EM13                                    \ Event Mask on line 13
$00004000 constant EXTI_EMR_EM14                                    \ Event Mask on line 14
$00008000 constant EXTI_EMR_EM15                                    \ Event Mask on line 15
$00010000 constant EXTI_EMR_EM16                                    \ Event Mask on line 16
$00020000 constant EXTI_EMR_EM17                                    \ Event Mask on line 17
$00040000 constant EXTI_EMR_EM18                                    \ Event Mask on line 18
$00080000 constant EXTI_EMR_EM19                                    \ Event Mask on line 19
$00100000 constant EXTI_EMR_EM20                                    \ Event Mask on line 20
$00200000 constant EXTI_EMR_EM21                                    \ Event Mask on line 21
$00400000 constant EXTI_EMR_EM22                                    \ Event Mask on line 22
$00800000 constant EXTI_EMR_EM23                                    \ Event Mask on line 23
$01000000 constant EXTI_EMR_EM24                                    \ Event Mask on line 24
$02000000 constant EXTI_EMR_EM25                                    \ Event Mask on line 25
$04000000 constant EXTI_EMR_EM26                                    \ Event Mask on line 26
$10000000 constant EXTI_EMR_EM28                                    \ Event Mask on line 28
$20000000 constant EXTI_EMR_EM29                                    \ Event Mask on line 29


\
\ @brief Rising Trigger selection register (EXTI_RTSR)
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant EXTI_RTSR_RT0                                    \ Rising trigger event configuration of line 0
$00000002 constant EXTI_RTSR_RT1                                    \ Rising trigger event configuration of line 1
$00000004 constant EXTI_RTSR_RT2                                    \ Rising trigger event configuration of line 2
$00000008 constant EXTI_RTSR_RT3                                    \ Rising trigger event configuration of line 3
$00000010 constant EXTI_RTSR_RT4                                    \ Rising trigger event configuration of line 4
$00000020 constant EXTI_RTSR_RT5                                    \ Rising trigger event configuration of line 5
$00000040 constant EXTI_RTSR_RT6                                    \ Rising trigger event configuration of line 6
$00000080 constant EXTI_RTSR_RT7                                    \ Rising trigger event configuration of line 7
$00000100 constant EXTI_RTSR_RT8                                    \ Rising trigger event configuration of line 8
$00000200 constant EXTI_RTSR_RT9                                    \ Rising trigger event configuration of line 9
$00000400 constant EXTI_RTSR_RT10                                   \ Rising trigger event configuration of line 10
$00000800 constant EXTI_RTSR_RT11                                   \ Rising trigger event configuration of line 11
$00001000 constant EXTI_RTSR_RT12                                   \ Rising trigger event configuration of line 12
$00002000 constant EXTI_RTSR_RT13                                   \ Rising trigger event configuration of line 13
$00004000 constant EXTI_RTSR_RT14                                   \ Rising trigger event configuration of line 14
$00008000 constant EXTI_RTSR_RT15                                   \ Rising trigger event configuration of line 15
$00010000 constant EXTI_RTSR_RT16                                   \ Rising trigger event configuration of line 16
$00020000 constant EXTI_RTSR_RT17                                   \ Rising trigger event configuration of line 17
$00080000 constant EXTI_RTSR_RT19                                   \ Rising trigger event configuration of line 19
$00100000 constant EXTI_RTSR_RT20                                   \ Rising trigger event configuration of line 20
$00200000 constant EXTI_RTSR_RT21                                   \ Rising trigger event configuration of line 21
$00400000 constant EXTI_RTSR_RT22                                   \ Rising trigger event configuration of line 22


\
\ @brief Falling Trigger selection register (EXTI_FTSR)
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant EXTI_FTSR_FT0                                    \ Falling trigger event configuration of line 0
$00000002 constant EXTI_FTSR_FT1                                    \ Falling trigger event configuration of line 1
$00000004 constant EXTI_FTSR_FT2                                    \ Falling trigger event configuration of line 2
$00000008 constant EXTI_FTSR_FT3                                    \ Falling trigger event configuration of line 3
$00000010 constant EXTI_FTSR_FT4                                    \ Falling trigger event configuration of line 4
$00000020 constant EXTI_FTSR_FT5                                    \ Falling trigger event configuration of line 5
$00000040 constant EXTI_FTSR_FT6                                    \ Falling trigger event configuration of line 6
$00000080 constant EXTI_FTSR_FT7                                    \ Falling trigger event configuration of line 7
$00000100 constant EXTI_FTSR_FT8                                    \ Falling trigger event configuration of line 8
$00000200 constant EXTI_FTSR_FT9                                    \ Falling trigger event configuration of line 9
$00000400 constant EXTI_FTSR_FT10                                   \ Falling trigger event configuration of line 10
$00000800 constant EXTI_FTSR_FT11                                   \ Falling trigger event configuration of line 11
$00001000 constant EXTI_FTSR_FT12                                   \ Falling trigger event configuration of line 12
$00002000 constant EXTI_FTSR_FT13                                   \ Falling trigger event configuration of line 13
$00004000 constant EXTI_FTSR_FT14                                   \ Falling trigger event configuration of line 14
$00008000 constant EXTI_FTSR_FT15                                   \ Falling trigger event configuration of line 15
$00010000 constant EXTI_FTSR_FT16                                   \ Falling trigger event configuration of line 16
$00020000 constant EXTI_FTSR_FT17                                   \ Falling trigger event configuration of line 17
$00080000 constant EXTI_FTSR_FT19                                   \ Falling trigger event configuration of line 19
$00100000 constant EXTI_FTSR_FT20                                   \ Falling trigger event configuration of line 20
$00200000 constant EXTI_FTSR_FT21                                   \ Falling trigger event configuration of line 21
$00400000 constant EXTI_FTSR_FT22                                   \ Falling trigger event configuration of line 22


\
\ @brief Software interrupt event register (EXTI_SWIER)
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant EXTI_SWIER_SWI0                                  \ Software Interrupt on line 0
$00000002 constant EXTI_SWIER_SWI1                                  \ Software Interrupt on line 1
$00000004 constant EXTI_SWIER_SWI2                                  \ Software Interrupt on line 2
$00000008 constant EXTI_SWIER_SWI3                                  \ Software Interrupt on line 3
$00000010 constant EXTI_SWIER_SWI4                                  \ Software Interrupt on line 4
$00000020 constant EXTI_SWIER_SWI5                                  \ Software Interrupt on line 5
$00000040 constant EXTI_SWIER_SWI6                                  \ Software Interrupt on line 6
$00000080 constant EXTI_SWIER_SWI7                                  \ Software Interrupt on line 7
$00000100 constant EXTI_SWIER_SWI8                                  \ Software Interrupt on line 8
$00000200 constant EXTI_SWIER_SWI9                                  \ Software Interrupt on line 9
$00000400 constant EXTI_SWIER_SWI10                                 \ Software Interrupt on line 10
$00000800 constant EXTI_SWIER_SWI11                                 \ Software Interrupt on line 11
$00001000 constant EXTI_SWIER_SWI12                                 \ Software Interrupt on line 12
$00002000 constant EXTI_SWIER_SWI13                                 \ Software Interrupt on line 13
$00004000 constant EXTI_SWIER_SWI14                                 \ Software Interrupt on line 14
$00008000 constant EXTI_SWIER_SWI15                                 \ Software Interrupt on line 15
$00010000 constant EXTI_SWIER_SWI16                                 \ Software Interrupt on line 16
$00020000 constant EXTI_SWIER_SWI17                                 \ Software Interrupt on line 17
$00080000 constant EXTI_SWIER_SWI19                                 \ Software Interrupt on line 19
$00100000 constant EXTI_SWIER_SWI20                                 \ Software Interrupt on line 20
$00200000 constant EXTI_SWIER_SWI21                                 \ Software Interrupt on line 21
$00400000 constant EXTI_SWIER_SWI22                                 \ Software Interrupt on line 22


\
\ @brief Pending register (EXTI_PR)
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant EXTI_PR_PIF0                                     \ Pending bit 0
$00000002 constant EXTI_PR_PIF1                                     \ Pending bit 1
$00000004 constant EXTI_PR_PIF2                                     \ Pending bit 2
$00000008 constant EXTI_PR_PIF3                                     \ Pending bit 3
$00000010 constant EXTI_PR_PIF4                                     \ Pending bit 4
$00000020 constant EXTI_PR_PIF5                                     \ Pending bit 5
$00000040 constant EXTI_PR_PIF6                                     \ Pending bit 6
$00000080 constant EXTI_PR_PIF7                                     \ Pending bit 7
$00000100 constant EXTI_PR_PIF8                                     \ Pending bit 8
$00000200 constant EXTI_PR_PIF9                                     \ Pending bit 9
$00000400 constant EXTI_PR_PIF10                                    \ Pending bit 10
$00000800 constant EXTI_PR_PIF11                                    \ Pending bit 11
$00001000 constant EXTI_PR_PIF12                                    \ Pending bit 12
$00002000 constant EXTI_PR_PIF13                                    \ Pending bit 13
$00004000 constant EXTI_PR_PIF14                                    \ Pending bit 14
$00008000 constant EXTI_PR_PIF15                                    \ Pending bit 15
$00010000 constant EXTI_PR_PIF16                                    \ Pending bit 16
$00020000 constant EXTI_PR_PIF17                                    \ Pending bit 17
$00080000 constant EXTI_PR_PIF19                                    \ Pending bit 19
$00100000 constant EXTI_PR_PIF20                                    \ Pending bit 20
$00200000 constant EXTI_PR_PIF21                                    \ Pending bit 21
$00400000 constant EXTI_PR_PIF22                                    \ Pending bit 22


\
\ @brief External interrupt/event controller
\
$40010400 constant EXTI_IMR       \ offset: 0x00 : Interrupt mask register (EXTI_IMR)
$40010404 constant EXTI_EMR       \ offset: 0x04 : Event mask register (EXTI_EMR)
$40010408 constant EXTI_RTSR      \ offset: 0x08 : Rising Trigger selection register (EXTI_RTSR)
$4001040c constant EXTI_FTSR      \ offset: 0x0C : Falling Trigger selection register (EXTI_FTSR)
$40010410 constant EXTI_SWIER     \ offset: 0x10 : Software interrupt event register (EXTI_SWIER)
$40010414 constant EXTI_PR        \ offset: 0x14 : Pending register (EXTI_PR)

