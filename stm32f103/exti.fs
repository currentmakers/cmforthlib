\
\ @file exti.fs
\ @brief EXTI
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


\
\ @brief EXTI
\
$40010400 constant EXTI_IMR       \ offset: 0x00 : Interrupt mask register (EXTI_IMR)
$40010404 constant EXTI_EMR       \ offset: 0x04 : Event mask register (EXTI_EMR)
$40010408 constant EXTI_RTSR      \ offset: 0x08 : Rising Trigger selection register (EXTI_RTSR)
$4001040c constant EXTI_FTSR      \ offset: 0x0C : Falling Trigger selection register (EXTI_FTSR)
$40010410 constant EXTI_SWIER     \ offset: 0x10 : Software interrupt event register (EXTI_SWIER)
$40010414 constant EXTI_PR        \ offset: 0x14 : Pending register (EXTI_PR)

