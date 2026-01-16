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
\ Reset value: 0x0F940000
\

$00000001 constant EXTI_IMR_MR0                                     \ Interrupt Mask on line 0
$00000002 constant EXTI_IMR_MR1                                     \ Interrupt Mask on line 1
$00000004 constant EXTI_IMR_MR2                                     \ Interrupt Mask on line 2
$00000008 constant EXTI_IMR_MR3                                     \ Interrupt Mask on line 3
$00000010 constant EXTI_IMR_MR4                                     \ Interrupt Mask on line 4
$00000020 constant EXTI_IMR_MR5                                     \ Interrupt Mask on line 5
$00000040 constant EXTI_IMR_MR6                                     \ Interrupt Mask on line 6
$00000080 constant EXTI_IMR_MR7                                     \ Interrupt Mask on line 7
$00000100 constant EXTI_IMR_MR8                                     \ Interrupt Mask on line 8
$00000200 constant EXTI_IMR_MR9                                     \ Interrupt Mask on line 9
$00000400 constant EXTI_IMR_MR10                                    \ Interrupt Mask on line 10
$00000800 constant EXTI_IMR_MR11                                    \ Interrupt Mask on line 11
$00001000 constant EXTI_IMR_MR12                                    \ Interrupt Mask on line 12
$00002000 constant EXTI_IMR_MR13                                    \ Interrupt Mask on line 13
$00004000 constant EXTI_IMR_MR14                                    \ Interrupt Mask on line 14
$00008000 constant EXTI_IMR_MR15                                    \ Interrupt Mask on line 15
$00010000 constant EXTI_IMR_MR16                                    \ Interrupt Mask on line 16
$00020000 constant EXTI_IMR_MR17                                    \ Interrupt Mask on line 17
$00040000 constant EXTI_IMR_MR18                                    \ Interrupt Mask on line 18
$00080000 constant EXTI_IMR_MR19                                    \ Interrupt Mask on line 19
$00100000 constant EXTI_IMR_MR20                                    \ Interrupt Mask on line 20
$00200000 constant EXTI_IMR_MR21                                    \ Interrupt Mask on line 21
$00400000 constant EXTI_IMR_MR22                                    \ Interrupt Mask on line 22
$00800000 constant EXTI_IMR_MR23                                    \ Interrupt Mask on line 23
$01000000 constant EXTI_IMR_MR24                                    \ Interrupt Mask on line 24
$02000000 constant EXTI_IMR_MR25                                    \ Interrupt Mask on line 25
$04000000 constant EXTI_IMR_MR26                                    \ Interrupt Mask on line 26
$08000000 constant EXTI_IMR_MR27                                    \ Interrupt Mask on line 27


\
\ @brief Event mask register (EXTI_EMR)
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EMR_MR0                                     \ Event Mask on line 0
$00000002 constant EXTI_EMR_MR1                                     \ Event Mask on line 1
$00000004 constant EXTI_EMR_MR2                                     \ Event Mask on line 2
$00000008 constant EXTI_EMR_MR3                                     \ Event Mask on line 3
$00000010 constant EXTI_EMR_MR4                                     \ Event Mask on line 4
$00000020 constant EXTI_EMR_MR5                                     \ Event Mask on line 5
$00000040 constant EXTI_EMR_MR6                                     \ Event Mask on line 6
$00000080 constant EXTI_EMR_MR7                                     \ Event Mask on line 7
$00000100 constant EXTI_EMR_MR8                                     \ Event Mask on line 8
$00000200 constant EXTI_EMR_MR9                                     \ Event Mask on line 9
$00000400 constant EXTI_EMR_MR10                                    \ Event Mask on line 10
$00000800 constant EXTI_EMR_MR11                                    \ Event Mask on line 11
$00001000 constant EXTI_EMR_MR12                                    \ Event Mask on line 12
$00002000 constant EXTI_EMR_MR13                                    \ Event Mask on line 13
$00004000 constant EXTI_EMR_MR14                                    \ Event Mask on line 14
$00008000 constant EXTI_EMR_MR15                                    \ Event Mask on line 15
$00010000 constant EXTI_EMR_MR16                                    \ Event Mask on line 16
$00020000 constant EXTI_EMR_MR17                                    \ Event Mask on line 17
$00040000 constant EXTI_EMR_MR18                                    \ Event Mask on line 18
$00080000 constant EXTI_EMR_MR19                                    \ Event Mask on line 19
$00100000 constant EXTI_EMR_MR20                                    \ Event Mask on line 20
$00200000 constant EXTI_EMR_MR21                                    \ Event Mask on line 21
$00400000 constant EXTI_EMR_MR22                                    \ Event Mask on line 22
$00800000 constant EXTI_EMR_MR23                                    \ Event Mask on line 23
$01000000 constant EXTI_EMR_MR24                                    \ Event Mask on line 24
$02000000 constant EXTI_EMR_MR25                                    \ Event Mask on line 25
$04000000 constant EXTI_EMR_MR26                                    \ Event Mask on line 26
$08000000 constant EXTI_EMR_MR27                                    \ Event Mask on line 27


\
\ @brief Rising Trigger selection register (EXTI_RTSR)
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant EXTI_RTSR_TR0                                    \ Rising trigger event configuration of line 0
$00000002 constant EXTI_RTSR_TR1                                    \ Rising trigger event configuration of line 1
$00000004 constant EXTI_RTSR_TR2                                    \ Rising trigger event configuration of line 2
$00000008 constant EXTI_RTSR_TR3                                    \ Rising trigger event configuration of line 3
$00000010 constant EXTI_RTSR_TR4                                    \ Rising trigger event configuration of line 4
$00000020 constant EXTI_RTSR_TR5                                    \ Rising trigger event configuration of line 5
$00000040 constant EXTI_RTSR_TR6                                    \ Rising trigger event configuration of line 6
$00000080 constant EXTI_RTSR_TR7                                    \ Rising trigger event configuration of line 7
$00000100 constant EXTI_RTSR_TR8                                    \ Rising trigger event configuration of line 8
$00000200 constant EXTI_RTSR_TR9                                    \ Rising trigger event configuration of line 9
$00000400 constant EXTI_RTSR_TR10                                   \ Rising trigger event configuration of line 10
$00000800 constant EXTI_RTSR_TR11                                   \ Rising trigger event configuration of line 11
$00001000 constant EXTI_RTSR_TR12                                   \ Rising trigger event configuration of line 12
$00002000 constant EXTI_RTSR_TR13                                   \ Rising trigger event configuration of line 13
$00004000 constant EXTI_RTSR_TR14                                   \ Rising trigger event configuration of line 14
$00008000 constant EXTI_RTSR_TR15                                   \ Rising trigger event configuration of line 15
$00010000 constant EXTI_RTSR_TR16                                   \ Rising trigger event configuration of line 16
$00020000 constant EXTI_RTSR_TR17                                   \ Rising trigger event configuration of line 17
$00080000 constant EXTI_RTSR_TR19                                   \ Rising trigger event configuration of line 19


\
\ @brief Falling Trigger selection register (EXTI_FTSR)
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant EXTI_FTSR_TR0                                    \ Falling trigger event configuration of line 0
$00000002 constant EXTI_FTSR_TR1                                    \ Falling trigger event configuration of line 1
$00000004 constant EXTI_FTSR_TR2                                    \ Falling trigger event configuration of line 2
$00000008 constant EXTI_FTSR_TR3                                    \ Falling trigger event configuration of line 3
$00000010 constant EXTI_FTSR_TR4                                    \ Falling trigger event configuration of line 4
$00000020 constant EXTI_FTSR_TR5                                    \ Falling trigger event configuration of line 5
$00000040 constant EXTI_FTSR_TR6                                    \ Falling trigger event configuration of line 6
$00000080 constant EXTI_FTSR_TR7                                    \ Falling trigger event configuration of line 7
$00000100 constant EXTI_FTSR_TR8                                    \ Falling trigger event configuration of line 8
$00000200 constant EXTI_FTSR_TR9                                    \ Falling trigger event configuration of line 9
$00000400 constant EXTI_FTSR_TR10                                   \ Falling trigger event configuration of line 10
$00000800 constant EXTI_FTSR_TR11                                   \ Falling trigger event configuration of line 11
$00001000 constant EXTI_FTSR_TR12                                   \ Falling trigger event configuration of line 12
$00002000 constant EXTI_FTSR_TR13                                   \ Falling trigger event configuration of line 13
$00004000 constant EXTI_FTSR_TR14                                   \ Falling trigger event configuration of line 14
$00008000 constant EXTI_FTSR_TR15                                   \ Falling trigger event configuration of line 15
$00010000 constant EXTI_FTSR_TR16                                   \ Falling trigger event configuration of line 16
$00020000 constant EXTI_FTSR_TR17                                   \ Falling trigger event configuration of line 17
$00080000 constant EXTI_FTSR_TR19                                   \ Falling trigger event configuration of line 19


\
\ @brief Software interrupt event register (EXTI_SWIER)
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant EXTI_SWIER_SWIER0                                \ Software Interrupt on line 0
$00000002 constant EXTI_SWIER_SWIER1                                \ Software Interrupt on line 1
$00000004 constant EXTI_SWIER_SWIER2                                \ Software Interrupt on line 2
$00000008 constant EXTI_SWIER_SWIER3                                \ Software Interrupt on line 3
$00000010 constant EXTI_SWIER_SWIER4                                \ Software Interrupt on line 4
$00000020 constant EXTI_SWIER_SWIER5                                \ Software Interrupt on line 5
$00000040 constant EXTI_SWIER_SWIER6                                \ Software Interrupt on line 6
$00000080 constant EXTI_SWIER_SWIER7                                \ Software Interrupt on line 7
$00000100 constant EXTI_SWIER_SWIER8                                \ Software Interrupt on line 8
$00000200 constant EXTI_SWIER_SWIER9                                \ Software Interrupt on line 9
$00000400 constant EXTI_SWIER_SWIER10                               \ Software Interrupt on line 10
$00000800 constant EXTI_SWIER_SWIER11                               \ Software Interrupt on line 11
$00001000 constant EXTI_SWIER_SWIER12                               \ Software Interrupt on line 12
$00002000 constant EXTI_SWIER_SWIER13                               \ Software Interrupt on line 13
$00004000 constant EXTI_SWIER_SWIER14                               \ Software Interrupt on line 14
$00008000 constant EXTI_SWIER_SWIER15                               \ Software Interrupt on line 15
$00010000 constant EXTI_SWIER_SWIER16                               \ Software Interrupt on line 16
$00020000 constant EXTI_SWIER_SWIER17                               \ Software Interrupt on line 17
$00080000 constant EXTI_SWIER_SWIER19                               \ Software Interrupt on line 19


\
\ @brief Pending register (EXTI_PR)
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant EXTI_PR_PIF0                                     \ Pending interrupt flag on line 0
$00000002 constant EXTI_PR_PIF1                                     \ Pending interrupt flag on line 1
$00000004 constant EXTI_PR_PIF2                                     \ Pending interrupt flag on line 2
$00000008 constant EXTI_PR_PIF3                                     \ Pending interrupt flag on line 3
$00000010 constant EXTI_PR_PIF4                                     \ Pending interrupt flag on line 4
$00000020 constant EXTI_PR_PIF5                                     \ Pending interrupt flag on line 5
$00000040 constant EXTI_PR_PIF6                                     \ Pending interrupt flag on line 6
$00000080 constant EXTI_PR_PIF7                                     \ Pending interrupt flag on line 7
$00000100 constant EXTI_PR_PIF8                                     \ Pending interrupt flag on line 8
$00000200 constant EXTI_PR_PIF9                                     \ Pending interrupt flag on line 9
$00000400 constant EXTI_PR_PIF10                                    \ Pending interrupt flag on line 10
$00000800 constant EXTI_PR_PIF11                                    \ Pending interrupt flag on line 11
$00001000 constant EXTI_PR_PIF12                                    \ Pending interrupt flag on line 12
$00002000 constant EXTI_PR_PIF13                                    \ Pending interrupt flag on line 13
$00004000 constant EXTI_PR_PIF14                                    \ Pending interrupt flag on line 14
$00008000 constant EXTI_PR_PIF15                                    \ Pending interrupt flag on line 15
$00010000 constant EXTI_PR_PIF16                                    \ Pending interrupt flag on line 16
$00020000 constant EXTI_PR_PIF17                                    \ Pending interrupt flag on line 17
$00080000 constant EXTI_PR_PIF19                                    \ Pending interrupt flag on line 19
$00100000 constant EXTI_PR_PIF20                                    \ Pending interrupt flag on line 20
$00200000 constant EXTI_PR_PIF21                                    \ Pending interrupt flag on line 21
$00400000 constant EXTI_PR_PIF22                                    \ Pending interrupt flag on line 22
$80000000 constant EXTI_PR_PIF31                                    \ Pending interrupt flag on line 31


\
\ @brief External interrupt/event controller
\
$40010400 constant EXTI_IMR       \ offset: 0x00 : Interrupt mask register (EXTI_IMR)
$40010404 constant EXTI_EMR       \ offset: 0x04 : Event mask register (EXTI_EMR)
$40010408 constant EXTI_RTSR      \ offset: 0x08 : Rising Trigger selection register (EXTI_RTSR)
$4001040c constant EXTI_FTSR      \ offset: 0x0C : Falling Trigger selection register (EXTI_FTSR)
$40010410 constant EXTI_SWIER     \ offset: 0x10 : Software interrupt event register (EXTI_SWIER)
$40010414 constant EXTI_PR        \ offset: 0x14 : Pending register (EXTI_PR)

