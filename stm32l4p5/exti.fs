\
\ @file exti.fs
\ @brief External interrupt/event       controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Interrupt mask register
\ Address offset: 0x00
\ Reset value: 0xFF820000
\

$00000001 constant EXTI_IMR1_MR0                                    \ Interrupt Mask on line 0
$00000002 constant EXTI_IMR1_MR1                                    \ Interrupt Mask on line 1
$00000004 constant EXTI_IMR1_MR2                                    \ Interrupt Mask on line 2
$00000008 constant EXTI_IMR1_MR3                                    \ Interrupt Mask on line 3
$00000010 constant EXTI_IMR1_MR4                                    \ Interrupt Mask on line 4
$00000020 constant EXTI_IMR1_MR5                                    \ Interrupt Mask on line 5
$00000040 constant EXTI_IMR1_MR6                                    \ Interrupt Mask on line 6
$00000080 constant EXTI_IMR1_MR7                                    \ Interrupt Mask on line 7
$00000100 constant EXTI_IMR1_MR8                                    \ Interrupt Mask on line 8
$00000200 constant EXTI_IMR1_MR9                                    \ Interrupt Mask on line 9
$00000400 constant EXTI_IMR1_MR10                                   \ Interrupt Mask on line 10
$00000800 constant EXTI_IMR1_MR11                                   \ Interrupt Mask on line 11
$00001000 constant EXTI_IMR1_MR12                                   \ Interrupt Mask on line 12
$00002000 constant EXTI_IMR1_MR13                                   \ Interrupt Mask on line 13
$00004000 constant EXTI_IMR1_MR14                                   \ Interrupt Mask on line 14
$00008000 constant EXTI_IMR1_MR15                                   \ Interrupt Mask on line 15
$00010000 constant EXTI_IMR1_MR16                                   \ Interrupt Mask on line 16
$00020000 constant EXTI_IMR1_MR17                                   \ Interrupt Mask on line 17
$00040000 constant EXTI_IMR1_MR18                                   \ Interrupt Mask on line 18
$00080000 constant EXTI_IMR1_MR19                                   \ Interrupt Mask on line 19
$00100000 constant EXTI_IMR1_MR20                                   \ Interrupt Mask on line 20
$00200000 constant EXTI_IMR1_MR21                                   \ Interrupt Mask on line 21
$00400000 constant EXTI_IMR1_MR22                                   \ Interrupt Mask on line 22
$00800000 constant EXTI_IMR1_MR23                                   \ Interrupt Mask on line 23
$01000000 constant EXTI_IMR1_MR24                                   \ Interrupt Mask on line 24
$02000000 constant EXTI_IMR1_MR25                                   \ Interrupt Mask on line 25
$04000000 constant EXTI_IMR1_MR26                                   \ Interrupt Mask on line 26
$08000000 constant EXTI_IMR1_MR27                                   \ Interrupt Mask on line 27
$10000000 constant EXTI_IMR1_MR28                                   \ Interrupt Mask on line 28
$20000000 constant EXTI_IMR1_MR29                                   \ Interrupt Mask on line 29
$40000000 constant EXTI_IMR1_MR30                                   \ Interrupt Mask on line 30
$80000000 constant EXTI_IMR1_MR31                                   \ Interrupt Mask on line 31


\
\ @brief Event mask register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EMR1_MR0                                    \ Event Mask on line 0
$00000002 constant EXTI_EMR1_MR1                                    \ Event Mask on line 1
$00000004 constant EXTI_EMR1_MR2                                    \ Event Mask on line 2
$00000008 constant EXTI_EMR1_MR3                                    \ Event Mask on line 3
$00000010 constant EXTI_EMR1_MR4                                    \ Event Mask on line 4
$00000020 constant EXTI_EMR1_MR5                                    \ Event Mask on line 5
$00000040 constant EXTI_EMR1_MR6                                    \ Event Mask on line 6
$00000080 constant EXTI_EMR1_MR7                                    \ Event Mask on line 7
$00000100 constant EXTI_EMR1_MR8                                    \ Event Mask on line 8
$00000200 constant EXTI_EMR1_MR9                                    \ Event Mask on line 9
$00000400 constant EXTI_EMR1_MR10                                   \ Event Mask on line 10
$00000800 constant EXTI_EMR1_MR11                                   \ Event Mask on line 11
$00001000 constant EXTI_EMR1_MR12                                   \ Event Mask on line 12
$00002000 constant EXTI_EMR1_MR13                                   \ Event Mask on line 13
$00004000 constant EXTI_EMR1_MR14                                   \ Event Mask on line 14
$00008000 constant EXTI_EMR1_MR15                                   \ Event Mask on line 15
$00010000 constant EXTI_EMR1_MR16                                   \ Event Mask on line 16
$00020000 constant EXTI_EMR1_MR17                                   \ Event Mask on line 17
$00040000 constant EXTI_EMR1_MR18                                   \ Event Mask on line 18
$00080000 constant EXTI_EMR1_MR19                                   \ Event Mask on line 19
$00100000 constant EXTI_EMR1_MR20                                   \ Event Mask on line 20
$00200000 constant EXTI_EMR1_MR21                                   \ Event Mask on line 21
$00400000 constant EXTI_EMR1_MR22                                   \ Event Mask on line 22
$00800000 constant EXTI_EMR1_MR23                                   \ Event Mask on line 23
$01000000 constant EXTI_EMR1_MR24                                   \ Event Mask on line 24
$02000000 constant EXTI_EMR1_MR25                                   \ Event Mask on line 25
$04000000 constant EXTI_EMR1_MR26                                   \ Event Mask on line 26
$08000000 constant EXTI_EMR1_MR27                                   \ Event Mask on line 27
$10000000 constant EXTI_EMR1_MR28                                   \ Event Mask on line 28
$20000000 constant EXTI_EMR1_MR29                                   \ Event Mask on line 29
$40000000 constant EXTI_EMR1_MR30                                   \ Event Mask on line 30
$80000000 constant EXTI_EMR1_MR31                                   \ Event Mask on line 31


\
\ @brief Rising Trigger selection register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant EXTI_RTSR1_TR0                                   \ Rising trigger event configuration of line 0
$00000002 constant EXTI_RTSR1_TR1                                   \ Rising trigger event configuration of line 1
$00000004 constant EXTI_RTSR1_TR2                                   \ Rising trigger event configuration of line 2
$00000008 constant EXTI_RTSR1_TR3                                   \ Rising trigger event configuration of line 3
$00000010 constant EXTI_RTSR1_TR4                                   \ Rising trigger event configuration of line 4
$00000020 constant EXTI_RTSR1_TR5                                   \ Rising trigger event configuration of line 5
$00000040 constant EXTI_RTSR1_TR6                                   \ Rising trigger event configuration of line 6
$00000080 constant EXTI_RTSR1_TR7                                   \ Rising trigger event configuration of line 7
$00000100 constant EXTI_RTSR1_TR8                                   \ Rising trigger event configuration of line 8
$00000200 constant EXTI_RTSR1_TR9                                   \ Rising trigger event configuration of line 9
$00000400 constant EXTI_RTSR1_TR10                                  \ Rising trigger event configuration of line 10
$00000800 constant EXTI_RTSR1_TR11                                  \ Rising trigger event configuration of line 11
$00001000 constant EXTI_RTSR1_TR12                                  \ Rising trigger event configuration of line 12
$00002000 constant EXTI_RTSR1_TR13                                  \ Rising trigger event configuration of line 13
$00004000 constant EXTI_RTSR1_TR14                                  \ Rising trigger event configuration of line 14
$00008000 constant EXTI_RTSR1_TR15                                  \ Rising trigger event configuration of line 15
$00010000 constant EXTI_RTSR1_TR16                                  \ Rising trigger event configuration of line 16
$00040000 constant EXTI_RTSR1_TR18                                  \ Rising trigger event configuration of line 18
$00080000 constant EXTI_RTSR1_TR19                                  \ Rising trigger event configuration of line 19
$00100000 constant EXTI_RTSR1_TR20                                  \ Rising trigger event configuration of line 20
$00200000 constant EXTI_RTSR1_TR21                                  \ Rising trigger event configuration of line 21
$00400000 constant EXTI_RTSR1_TR22                                  \ Rising trigger event configuration of line 22


\
\ @brief Falling Trigger selection register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant EXTI_FTSR1_TR0                                   \ Falling trigger event configuration of line 0
$00000002 constant EXTI_FTSR1_TR1                                   \ Falling trigger event configuration of line 1
$00000004 constant EXTI_FTSR1_TR2                                   \ Falling trigger event configuration of line 2
$00000008 constant EXTI_FTSR1_TR3                                   \ Falling trigger event configuration of line 3
$00000010 constant EXTI_FTSR1_TR4                                   \ Falling trigger event configuration of line 4
$00000020 constant EXTI_FTSR1_TR5                                   \ Falling trigger event configuration of line 5
$00000040 constant EXTI_FTSR1_TR6                                   \ Falling trigger event configuration of line 6
$00000080 constant EXTI_FTSR1_TR7                                   \ Falling trigger event configuration of line 7
$00000100 constant EXTI_FTSR1_TR8                                   \ Falling trigger event configuration of line 8
$00000200 constant EXTI_FTSR1_TR9                                   \ Falling trigger event configuration of line 9
$00000400 constant EXTI_FTSR1_TR10                                  \ Falling trigger event configuration of line 10
$00000800 constant EXTI_FTSR1_TR11                                  \ Falling trigger event configuration of line 11
$00001000 constant EXTI_FTSR1_TR12                                  \ Falling trigger event configuration of line 12
$00002000 constant EXTI_FTSR1_TR13                                  \ Falling trigger event configuration of line 13
$00004000 constant EXTI_FTSR1_TR14                                  \ Falling trigger event configuration of line 14
$00008000 constant EXTI_FTSR1_TR15                                  \ Falling trigger event configuration of line 15
$00010000 constant EXTI_FTSR1_TR16                                  \ Falling trigger event configuration of line 16
$00040000 constant EXTI_FTSR1_TR18                                  \ Falling trigger event configuration of line 18
$00080000 constant EXTI_FTSR1_TR19                                  \ Falling trigger event configuration of line 19
$00100000 constant EXTI_FTSR1_TR20                                  \ Falling trigger event configuration of line 20
$00200000 constant EXTI_FTSR1_TR21                                  \ Falling trigger event configuration of line 21
$00400000 constant EXTI_FTSR1_TR22                                  \ Falling trigger event configuration of line 22


\
\ @brief Software interrupt event register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant EXTI_SWIER1_SWIER0                               \ Software Interrupt on line 0
$00000002 constant EXTI_SWIER1_SWIER1                               \ Software Interrupt on line 1
$00000004 constant EXTI_SWIER1_SWIER2                               \ Software Interrupt on line 2
$00000008 constant EXTI_SWIER1_SWIER3                               \ Software Interrupt on line 3
$00000010 constant EXTI_SWIER1_SWIER4                               \ Software Interrupt on line 4
$00000020 constant EXTI_SWIER1_SWIER5                               \ Software Interrupt on line 5
$00000040 constant EXTI_SWIER1_SWIER6                               \ Software Interrupt on line 6
$00000080 constant EXTI_SWIER1_SWIER7                               \ Software Interrupt on line 7
$00000100 constant EXTI_SWIER1_SWIER8                               \ Software Interrupt on line 8
$00000200 constant EXTI_SWIER1_SWIER9                               \ Software Interrupt on line 9
$00000400 constant EXTI_SWIER1_SWIER10                              \ Software Interrupt on line 10
$00000800 constant EXTI_SWIER1_SWIER11                              \ Software Interrupt on line 11
$00001000 constant EXTI_SWIER1_SWIER12                              \ Software Interrupt on line 12
$00002000 constant EXTI_SWIER1_SWIER13                              \ Software Interrupt on line 13
$00004000 constant EXTI_SWIER1_SWIER14                              \ Software Interrupt on line 14
$00008000 constant EXTI_SWIER1_SWIER15                              \ Software Interrupt on line 15
$00010000 constant EXTI_SWIER1_SWIER16                              \ Software Interrupt on line 16
$00040000 constant EXTI_SWIER1_SWIER18                              \ Software Interrupt on line 18
$00080000 constant EXTI_SWIER1_SWIER19                              \ Software Interrupt on line 19
$00100000 constant EXTI_SWIER1_SWIER20                              \ Software Interrupt on line 20
$00200000 constant EXTI_SWIER1_SWIER21                              \ Software Interrupt on line 21
$00400000 constant EXTI_SWIER1_SWIER22                              \ Software Interrupt on line 22


\
\ @brief Pending register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant EXTI_PR1_PR0                                     \ Pending bit 0
$00000002 constant EXTI_PR1_PR1                                     \ Pending bit 1
$00000004 constant EXTI_PR1_PR2                                     \ Pending bit 2
$00000008 constant EXTI_PR1_PR3                                     \ Pending bit 3
$00000010 constant EXTI_PR1_PR4                                     \ Pending bit 4
$00000020 constant EXTI_PR1_PR5                                     \ Pending bit 5
$00000040 constant EXTI_PR1_PR6                                     \ Pending bit 6
$00000080 constant EXTI_PR1_PR7                                     \ Pending bit 7
$00000100 constant EXTI_PR1_PR8                                     \ Pending bit 8
$00000200 constant EXTI_PR1_PR9                                     \ Pending bit 9
$00000400 constant EXTI_PR1_PR10                                    \ Pending bit 10
$00000800 constant EXTI_PR1_PR11                                    \ Pending bit 11
$00001000 constant EXTI_PR1_PR12                                    \ Pending bit 12
$00002000 constant EXTI_PR1_PR13                                    \ Pending bit 13
$00004000 constant EXTI_PR1_PR14                                    \ Pending bit 14
$00008000 constant EXTI_PR1_PR15                                    \ Pending bit 15
$00010000 constant EXTI_PR1_PR16                                    \ Pending bit 16
$00040000 constant EXTI_PR1_PR18                                    \ Pending bit 18
$00080000 constant EXTI_PR1_PR19                                    \ Pending bit 19
$00100000 constant EXTI_PR1_PR20                                    \ Pending bit 20
$00200000 constant EXTI_PR1_PR21                                    \ Pending bit 21
$00400000 constant EXTI_PR1_PR22                                    \ Pending bit 22


\
\ @brief Interrupt mask register
\ Address offset: 0x20
\ Reset value: 0xFFFFFF87
\

$00000001 constant EXTI_IMR2_MR32                                   \ Interrupt Mask on external/internal line 32
$00000002 constant EXTI_IMR2_MR33                                   \ Interrupt Mask on external/internal line 33
$00000004 constant EXTI_IMR2_MR34                                   \ Interrupt Mask on external/internal line 34
$00000008 constant EXTI_IMR2_MR35                                   \ Interrupt Mask on external/internal line 35
$00000010 constant EXTI_IMR2_MR36                                   \ Interrupt Mask on external/internal line 36
$00000020 constant EXTI_IMR2_MR37                                   \ Interrupt Mask on external/internal line 37
$00000040 constant EXTI_IMR2_MR38                                   \ Interrupt Mask on external/internal line 38
$00000080 constant EXTI_IMR2_MR39                                   \ Interrupt Mask on external/internal line 39


\
\ @brief Event mask register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EMR2_MR32                                   \ Event mask on external/internal line 32
$00000002 constant EXTI_EMR2_MR33                                   \ Event mask on external/internal line 33
$00000004 constant EXTI_EMR2_MR34                                   \ Event mask on external/internal line 34
$00000008 constant EXTI_EMR2_MR35                                   \ Event mask on external/internal line 35
$00000010 constant EXTI_EMR2_MR36                                   \ Event mask on external/internal line 36
$00000020 constant EXTI_EMR2_MR37                                   \ Event mask on external/internal line 37
$00000040 constant EXTI_EMR2_MR38                                   \ Event mask on external/internal line 38
$00000080 constant EXTI_EMR2_MR39                                   \ Event mask on external/internal line 39


\
\ @brief Rising Trigger selection register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000008 constant EXTI_RTSR2_RT35                                  \ Rising trigger event configuration bit of line 35
$00000010 constant EXTI_RTSR2_RT36                                  \ Rising trigger event configuration bit of line 36
$00000020 constant EXTI_RTSR2_RT37                                  \ Rising trigger event configuration bit of line 37
$00000040 constant EXTI_RTSR2_RT38                                  \ Rising trigger event configuration bit of line 38


\
\ @brief Falling Trigger selection register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000008 constant EXTI_FTSR2_FT35                                  \ Falling trigger event configuration bit of line 35
$00000010 constant EXTI_FTSR2_FT36                                  \ Falling trigger event configuration bit of line 36
$00000020 constant EXTI_FTSR2_FT37                                  \ Falling trigger event configuration bit of line 37
$00000040 constant EXTI_FTSR2_FT38                                  \ Falling trigger event configuration bit of line 38


\
\ @brief Software interrupt event register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000008 constant EXTI_SWIER2_SWI35                                \ Software interrupt on line 35
$00000010 constant EXTI_SWIER2_SWI36                                \ Software interrupt on line 36
$00000020 constant EXTI_SWIER2_SWI37                                \ Software interrupt on line 37
$00000040 constant EXTI_SWIER2_SWI38                                \ Software interrupt on line 38


\
\ @brief Pending register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000008 constant EXTI_PR2_PIF35                                   \ Pending interrupt flag on line 35
$00000010 constant EXTI_PR2_PIF36                                   \ Pending interrupt flag on line 36
$00000020 constant EXTI_PR2_PIF37                                   \ Pending interrupt flag on line 37
$00000040 constant EXTI_PR2_PIF38                                   \ Pending interrupt flag on line 38


\
\ @brief External interrupt/event controller
\
$40010400 constant EXTI_IMR1      \ offset: 0x00 : Interrupt mask register
$40010404 constant EXTI_EMR1      \ offset: 0x04 : Event mask register
$40010408 constant EXTI_RTSR1     \ offset: 0x08 : Rising Trigger selection register
$4001040c constant EXTI_FTSR1     \ offset: 0x0C : Falling Trigger selection register
$40010410 constant EXTI_SWIER1    \ offset: 0x10 : Software interrupt event register
$40010414 constant EXTI_PR1       \ offset: 0x14 : Pending register
$40010420 constant EXTI_IMR2      \ offset: 0x20 : Interrupt mask register
$40010424 constant EXTI_EMR2      \ offset: 0x24 : Event mask register
$40010428 constant EXTI_RTSR2     \ offset: 0x28 : Rising Trigger selection register
$4001042c constant EXTI_FTSR2     \ offset: 0x2C : Falling Trigger selection register
$40010430 constant EXTI_SWIER2    \ offset: 0x30 : Software interrupt event register
$40010434 constant EXTI_PR2       \ offset: 0x34 : Pending register

