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
\ Reset value: 0x00000000
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
$00000200 constant EXTI_IMR_MI9                                     \ Interrupt Mask on line 9
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
$00040000 constant EXTI_RTSR_TR18                                   \ Rising trigger event configuration of line 18
$00080000 constant EXTI_RTSR_TR19                                   \ Rising trigger event configuration of line 19
$00100000 constant EXTI_RTSR_TR20                                   \ Rising trigger event configuration of line 20
$00200000 constant EXTI_RTSR_TR21                                   \ Rising trigger event configuration of line 21
$00400000 constant EXTI_RTSR_TR22                                   \ Rising trigger event configuration of line 22
$00800000 constant EXTI_RTSR_TR23                                   \ Rising trigger event configuration of line 23


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
$00040000 constant EXTI_FTSR_TR18                                   \ Falling trigger event configuration of line 18
$00080000 constant EXTI_FTSR_TR19                                   \ Falling trigger event configuration of line 19
$00100000 constant EXTI_FTSR_TR20                                   \ Falling trigger event configuration of line 20
$00200000 constant EXTI_FTSR_TR21                                   \ Falling trigger event configuration of line 21
$00400000 constant EXTI_FTSR_TR22                                   \ Falling trigger event configuration of line 22
$00800000 constant EXTI_FTSR_TR23                                   \ Falling trigger event configuration of line 23


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
$00040000 constant EXTI_SWIER_SWIER18                               \ Software Interrupt on line 18
$00080000 constant EXTI_SWIER_SWIER19                               \ Software Interrupt on line 19
$00100000 constant EXTI_SWIER_SWIER20                               \ Software Interrupt on line 20
$00200000 constant EXTI_SWIER_SWIER21                               \ Software Interrupt on line 21
$00400000 constant EXTI_SWIER_SWIER22                               \ Software Interrupt on line 22
$00800000 constant EXTI_SWIER_SWIER23                               \ Software Interrupt on line 22


\
\ @brief Pending register (EXTI_PR)
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant EXTI_PR_PR0                                      \ Pending bit 0
$00000002 constant EXTI_PR_PR1                                      \ Pending bit 1
$00000004 constant EXTI_PR_PR2                                      \ Pending bit 2
$00000008 constant EXTI_PR_PR3                                      \ Pending bit 3
$00000010 constant EXTI_PR_PR4                                      \ Pending bit 4
$00000020 constant EXTI_PR_PR5                                      \ Pending bit 5
$00000040 constant EXTI_PR_PR6                                      \ Pending bit 6
$00000080 constant EXTI_PR_PR7                                      \ Pending bit 7
$00000100 constant EXTI_PR_PR8                                      \ Pending bit 8
$00000200 constant EXTI_PR_PR9                                      \ Pending bit 9
$00000400 constant EXTI_PR_PR10                                     \ Pending bit 10
$00000800 constant EXTI_PR_PR11                                     \ Pending bit 11
$00001000 constant EXTI_PR_PR12                                     \ Pending bit 12
$00002000 constant EXTI_PR_PR13                                     \ Pending bit 13
$00004000 constant EXTI_PR_PR14                                     \ Pending bit 14
$00008000 constant EXTI_PR_PR15                                     \ Pending bit 15
$00010000 constant EXTI_PR_PR16                                     \ Pending bit 16
$00020000 constant EXTI_PR_PR17                                     \ Pending bit 17
$00040000 constant EXTI_PR_PR18                                     \ Pending bit 18
$00080000 constant EXTI_PR_PR19                                     \ Pending bit 19
$00100000 constant EXTI_PR_PR20                                     \ Pending bit 20
$00200000 constant EXTI_PR_PR21                                     \ Pending bit 21
$00400000 constant EXTI_PR_PR22                                     \ Pending bit 22
$00800000 constant EXTI_PR_PR23                                     \ Pending bit 23


\
\ @brief External interrupt/event controller
\
$40013c00 constant EXTI_IMR       \ offset: 0x00 : Interrupt mask register (EXTI_IMR)
$40013c04 constant EXTI_EMR       \ offset: 0x04 : Event mask register (EXTI_EMR)
$40013c08 constant EXTI_RTSR      \ offset: 0x08 : Rising Trigger selection register (EXTI_RTSR)
$40013c0c constant EXTI_FTSR      \ offset: 0x0C : Falling Trigger selection register (EXTI_FTSR)
$40013c10 constant EXTI_SWIER     \ offset: 0x10 : Software interrupt event register (EXTI_SWIER)
$40013c14 constant EXTI_PR        \ offset: 0x14 : Pending register (EXTI_PR)

