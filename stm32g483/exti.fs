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

$00000001 constant EXTI_IMR1_IM0                                    \ Interrupt Mask on line 0
$00000002 constant EXTI_IMR1_IM1                                    \ Interrupt Mask on line 1
$00000004 constant EXTI_IMR1_IM2                                    \ Interrupt Mask on line 2
$00000008 constant EXTI_IMR1_IM3                                    \ Interrupt Mask on line 3
$00000010 constant EXTI_IMR1_IM4                                    \ Interrupt Mask on line 4
$00000020 constant EXTI_IMR1_IM5                                    \ Interrupt Mask on line 5
$00000040 constant EXTI_IMR1_IM6                                    \ Interrupt Mask on line 6
$00000080 constant EXTI_IMR1_IM7                                    \ Interrupt Mask on line 7
$00000100 constant EXTI_IMR1_IM8                                    \ Interrupt Mask on line 8
$00000200 constant EXTI_IMR1_IM9                                    \ Interrupt Mask on line 9
$00000400 constant EXTI_IMR1_IM10                                   \ Interrupt Mask on line 10
$00000800 constant EXTI_IMR1_IM11                                   \ Interrupt Mask on line 11
$00001000 constant EXTI_IMR1_IM12                                   \ Interrupt Mask on line 12
$00002000 constant EXTI_IMR1_IM13                                   \ Interrupt Mask on line 13
$00004000 constant EXTI_IMR1_IM14                                   \ Interrupt Mask on line 14
$00008000 constant EXTI_IMR1_IM15                                   \ Interrupt Mask on line 15
$00010000 constant EXTI_IMR1_IM16                                   \ Interrupt Mask on line 16
$00020000 constant EXTI_IMR1_IM17                                   \ Interrupt Mask on line 17
$00040000 constant EXTI_IMR1_IM18                                   \ Interrupt Mask on line 18
$00080000 constant EXTI_IMR1_IM19                                   \ Interrupt Mask on line 19
$00100000 constant EXTI_IMR1_IM20                                   \ Interrupt Mask on line 20
$00200000 constant EXTI_IMR1_IM21                                   \ Interrupt Mask on line 21
$00400000 constant EXTI_IMR1_IM22                                   \ Interrupt Mask on line 22
$00800000 constant EXTI_IMR1_IM23                                   \ Interrupt Mask on line 23
$01000000 constant EXTI_IMR1_IM24                                   \ Interrupt Mask on line 24
$02000000 constant EXTI_IMR1_IM25                                   \ Interrupt Mask on line 25
$04000000 constant EXTI_IMR1_IM26                                   \ Interrupt Mask on line 26
$08000000 constant EXTI_IMR1_IM27                                   \ Interrupt Mask on line 27
$10000000 constant EXTI_IMR1_IM28                                   \ Interrupt Mask on line 28
$20000000 constant EXTI_IMR1_IM29                                   \ Interrupt Mask on line 29
$40000000 constant EXTI_IMR1_IM30                                   \ Interrupt Mask on line 30
$80000000 constant EXTI_IMR1_IM31                                   \ Interrupt Mask on line 31


\
\ @brief Event mask register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EMR1_EM0                                    \ Event Mask on line 0
$00000002 constant EXTI_EMR1_EM1                                    \ Event Mask on line 1
$00000004 constant EXTI_EMR1_EM2                                    \ Event Mask on line 2
$00000008 constant EXTI_EMR1_EM3                                    \ Event Mask on line 3
$00000010 constant EXTI_EMR1_EM4                                    \ Event Mask on line 4
$00000020 constant EXTI_EMR1_EM5                                    \ Event Mask on line 5
$00000040 constant EXTI_EMR1_EM6                                    \ Event Mask on line 6
$00000080 constant EXTI_EMR1_EM7                                    \ Event Mask on line 7
$00000100 constant EXTI_EMR1_EM8                                    \ Event Mask on line 8
$00000200 constant EXTI_EMR1_EM9                                    \ Event Mask on line 9
$00000400 constant EXTI_EMR1_EM10                                   \ Event Mask on line 10
$00000800 constant EXTI_EMR1_EM11                                   \ Event Mask on line 11
$00001000 constant EXTI_EMR1_EM12                                   \ Event Mask on line 12
$00002000 constant EXTI_EMR1_EM13                                   \ Event Mask on line 13
$00004000 constant EXTI_EMR1_EM14                                   \ Event Mask on line 14
$00008000 constant EXTI_EMR1_EM15                                   \ Event Mask on line 15
$00010000 constant EXTI_EMR1_EM16                                   \ Event Mask on line 16
$00020000 constant EXTI_EMR1_EM17                                   \ Event Mask on line 17
$00040000 constant EXTI_EMR1_EM18                                   \ Event Mask on line 18
$00080000 constant EXTI_EMR1_EM19                                   \ Event Mask on line 19
$00100000 constant EXTI_EMR1_EM20                                   \ Event Mask on line 20
$00200000 constant EXTI_EMR1_EM21                                   \ Event Mask on line 21
$00400000 constant EXTI_EMR1_EM22                                   \ Event Mask on line 22
$00800000 constant EXTI_EMR1_EM23                                   \ Event Mask on line 23
$01000000 constant EXTI_EMR1_EM24                                   \ Event Mask on line 24
$02000000 constant EXTI_EMR1_EM25                                   \ Event Mask on line 25
$04000000 constant EXTI_EMR1_EM26                                   \ Event Mask on line 26
$08000000 constant EXTI_EMR1_EM27                                   \ Event Mask on line 27
$10000000 constant EXTI_EMR1_EM28                                   \ Event Mask on line 28
$20000000 constant EXTI_EMR1_EM29                                   \ Event Mask on line 29
$40000000 constant EXTI_EMR1_EM30                                   \ Event Mask on line 30
$80000000 constant EXTI_EMR1_EM31                                   \ Event Mask on line 31


\
\ @brief Rising Trigger selection register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant EXTI_RTSR1_RT0                                   \ Rising trigger event configuration of line 0
$00000002 constant EXTI_RTSR1_RT1                                   \ Rising trigger event configuration of line 1
$00000004 constant EXTI_RTSR1_RT2                                   \ Rising trigger event configuration of line 2
$00000008 constant EXTI_RTSR1_RT3                                   \ Rising trigger event configuration of line 3
$00000010 constant EXTI_RTSR1_RT4                                   \ Rising trigger event configuration of line 4
$00000020 constant EXTI_RTSR1_RT5                                   \ Rising trigger event configuration of line 5
$00000040 constant EXTI_RTSR1_RT6                                   \ Rising trigger event configuration of line 6
$00000080 constant EXTI_RTSR1_RT7                                   \ Rising trigger event configuration of line 7
$00000100 constant EXTI_RTSR1_RT8                                   \ Rising trigger event configuration of line 8
$00000200 constant EXTI_RTSR1_RT9                                   \ Rising trigger event configuration of line 9
$00000400 constant EXTI_RTSR1_RT10                                  \ Rising trigger event configuration of line 10
$00000800 constant EXTI_RTSR1_RT11                                  \ Rising trigger event configuration of line 11
$00001000 constant EXTI_RTSR1_RT12                                  \ Rising trigger event configuration of line 12
$00002000 constant EXTI_RTSR1_RT13                                  \ Rising trigger event configuration of line 13
$00004000 constant EXTI_RTSR1_RT14                                  \ Rising trigger event configuration of line 14
$00008000 constant EXTI_RTSR1_RT15                                  \ Rising trigger event configuration of line 15
$00010000 constant EXTI_RTSR1_RT16                                  \ Rising trigger event configuration of line 16
$00040000 constant EXTI_RTSR1_RT18                                  \ Rising trigger event configuration of line 18
$00080000 constant EXTI_RTSR1_RT19                                  \ Rising trigger event configuration of line 19
$00100000 constant EXTI_RTSR1_RT20                                  \ Rising trigger event configuration of line 20
$00200000 constant EXTI_RTSR1_RT21                                  \ Rising trigger event configuration of line 21
$00400000 constant EXTI_RTSR1_RT22                                  \ Rising trigger event configuration of line 22
$e0000000 constant EXTI_RTSR1_RT                                    \ RT


\
\ @brief Falling Trigger selection register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant EXTI_FTSR1_FT0                                   \ Falling trigger event configuration of line 0
$00000002 constant EXTI_FTSR1_FT1                                   \ Falling trigger event configuration of line 1
$00000004 constant EXTI_FTSR1_FT2                                   \ Falling trigger event configuration of line 2
$00000008 constant EXTI_FTSR1_FT3                                   \ Falling trigger event configuration of line 3
$00000010 constant EXTI_FTSR1_FT4                                   \ Falling trigger event configuration of line 4
$00000020 constant EXTI_FTSR1_FT5                                   \ Falling trigger event configuration of line 5
$00000040 constant EXTI_FTSR1_FT6                                   \ Falling trigger event configuration of line 6
$00000080 constant EXTI_FTSR1_FT7                                   \ Falling trigger event configuration of line 7
$00000100 constant EXTI_FTSR1_FT8                                   \ Falling trigger event configuration of line 8
$00000200 constant EXTI_FTSR1_FT9                                   \ Falling trigger event configuration of line 9
$00000400 constant EXTI_FTSR1_FT10                                  \ Falling trigger event configuration of line 10
$00000800 constant EXTI_FTSR1_FT11                                  \ Falling trigger event configuration of line 11
$00001000 constant EXTI_FTSR1_FT12                                  \ Falling trigger event configuration of line 12
$00002000 constant EXTI_FTSR1_FT13                                  \ Falling trigger event configuration of line 13
$00004000 constant EXTI_FTSR1_FT14                                  \ Falling trigger event configuration of line 14
$00008000 constant EXTI_FTSR1_FT15                                  \ Falling trigger event configuration of line 15
$00010000 constant EXTI_FTSR1_FT16                                  \ Falling trigger event configuration of line 16
$00040000 constant EXTI_FTSR1_FT18                                  \ Falling trigger event configuration of line 18
$00080000 constant EXTI_FTSR1_FT19                                  \ Falling trigger event configuration of line 19
$00100000 constant EXTI_FTSR1_FT20                                  \ Falling trigger event configuration of line 20
$00200000 constant EXTI_FTSR1_FT21                                  \ Falling trigger event configuration of line 21
$00400000 constant EXTI_FTSR1_FT22                                  \ Falling trigger event configuration of line 22


\
\ @brief Software interrupt event register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant EXTI_SWIER1_SWI0                                 \ Software Interrupt on line 0
$00000002 constant EXTI_SWIER1_SWI1                                 \ Software Interrupt on line 1
$00000004 constant EXTI_SWIER1_SWI2                                 \ Software Interrupt on line 2
$00000008 constant EXTI_SWIER1_SWI3                                 \ Software Interrupt on line 3
$00000010 constant EXTI_SWIER1_SWI4                                 \ Software Interrupt on line 4
$00000020 constant EXTI_SWIER1_SWI5                                 \ Software Interrupt on line 5
$00000040 constant EXTI_SWIER1_SWI6                                 \ Software Interrupt on line 6
$00000080 constant EXTI_SWIER1_SWI7                                 \ Software Interrupt on line 7
$00000100 constant EXTI_SWIER1_SWI8                                 \ Software Interrupt on line 8
$00000200 constant EXTI_SWIER1_SWI9                                 \ Software Interrupt on line 9
$00000400 constant EXTI_SWIER1_SWI10                                \ Software Interrupt on line 10
$00000800 constant EXTI_SWIER1_SWI11                                \ Software Interrupt on line 11
$00001000 constant EXTI_SWIER1_SWI12                                \ Software Interrupt on line 12
$00002000 constant EXTI_SWIER1_SWI13                                \ Software Interrupt on line 13
$00004000 constant EXTI_SWIER1_SWI14                                \ Software Interrupt on line 14
$00008000 constant EXTI_SWIER1_SWI15                                \ Software Interrupt on line 15
$00010000 constant EXTI_SWIER1_SWI16                                \ Software Interrupt on line 16
$00040000 constant EXTI_SWIER1_SWI18                                \ Software Interrupt on line 18
$00080000 constant EXTI_SWIER1_SWI19                                \ Software Interrupt on line 19
$00100000 constant EXTI_SWIER1_SWI20                                \ Software Interrupt on line 20
$00200000 constant EXTI_SWIER1_SWI21                                \ Software Interrupt on line 21
$00400000 constant EXTI_SWIER1_SWI22                                \ Software Interrupt on line 22


\
\ @brief Pending register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant EXTI_PR1_PIF0                                    \ Pending bit 0
$00000002 constant EXTI_PR1_PIF1                                    \ Pending bit 1
$00000004 constant EXTI_PR1_PIF2                                    \ Pending bit 2
$00000008 constant EXTI_PR1_PIF3                                    \ Pending bit 3
$00000010 constant EXTI_PR1_PIF4                                    \ Pending bit 4
$00000020 constant EXTI_PR1_PIF5                                    \ Pending bit 5
$00000040 constant EXTI_PR1_PIF6                                    \ Pending bit 6
$00000080 constant EXTI_PR1_PIF7                                    \ Pending bit 7
$00000100 constant EXTI_PR1_PIF8                                    \ Pending bit 8
$00000200 constant EXTI_PR1_PIF9                                    \ Pending bit 9
$00000400 constant EXTI_PR1_PIF10                                   \ Pending bit 10
$00000800 constant EXTI_PR1_PIF11                                   \ Pending bit 11
$00001000 constant EXTI_PR1_PIF12                                   \ Pending bit 12
$00002000 constant EXTI_PR1_PIF13                                   \ Pending bit 13
$00004000 constant EXTI_PR1_PIF14                                   \ Pending bit 14
$00008000 constant EXTI_PR1_PIF15                                   \ Pending bit 15
$00010000 constant EXTI_PR1_PIF16                                   \ Pending bit 16
$00040000 constant EXTI_PR1_PIF18                                   \ Pending bit 18
$00080000 constant EXTI_PR1_PIF19                                   \ Pending bit 19
$00100000 constant EXTI_PR1_PIF20                                   \ Pending bit 20
$00200000 constant EXTI_PR1_PIF21                                   \ Pending bit 21
$00400000 constant EXTI_PR1_PIF22                                   \ Pending bit 22


\
\ @brief Interrupt mask register
\ Address offset: 0x20
\ Reset value: 0xFFFFFF87
\

$00000001 constant EXTI_IMR2_IM32                                   \ Interrupt Mask on external/internal line 32
$00000002 constant EXTI_IMR2_IM33                                   \ Interrupt Mask on external/internal line 33
$00000004 constant EXTI_IMR2_IM34                                   \ Interrupt Mask on external/internal line 34
$00000008 constant EXTI_IMR2_IM35                                   \ Interrupt Mask on external/internal line 35
$00000010 constant EXTI_IMR2_IM36                                   \ Interrupt Mask on external/internal line 36
$00000020 constant EXTI_IMR2_IM37                                   \ Interrupt Mask on external/internal line 37
$00000040 constant EXTI_IMR2_IM38                                   \ Interrupt Mask on external/internal line 38
$00000080 constant EXTI_IMR2_IM39                                   \ Interrupt Mask on external/internal line 39
$00000100 constant EXTI_IMR2_IM40                                   \ Interrupt Mask on external/internal line 40
$00000200 constant EXTI_IMR2_IM41                                   \ Interrupt Mask on external/internal line 41
$00000400 constant EXTI_IMR2_IM42                                   \ Interrupt Mask on external/internal line 42
$00000800 constant EXTI_IMR2_IM43                                   \ Interrupt Mask on external/internal line 43


\
\ @brief Event mask register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EMR2_EM32                                   \ Event mask on external/internal line 32
$00000002 constant EXTI_EMR2_EM33                                   \ Event mask on external/internal line 33
$00000004 constant EXTI_EMR2_EM34                                   \ Event mask on external/internal line 34
$00000008 constant EXTI_EMR2_EM35                                   \ Event mask on external/internal line 35
$00000010 constant EXTI_EMR2_EM36                                   \ Event mask on external/internal line 36
$00000020 constant EXTI_EMR2_EM37                                   \ Event mask on external/internal line 37
$00000040 constant EXTI_EMR2_EM38                                   \ Event mask on external/internal line 38
$00000080 constant EXTI_EMR2_EM39                                   \ Event mask on external/internal line 39
$00000100 constant EXTI_EMR2_EM40                                   \ Event mask on external/internal line 40


\
\ @brief Rising Trigger selection register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant EXTI_RTSR2_RT32                                  \ Rising trigger event configuration bit of line 32
$00000002 constant EXTI_RTSR2_RT33                                  \ Rising trigger event configuration bit of line 32
$00000040 constant EXTI_RTSR2_RT38                                  \ Rising trigger event configuration bit of line 38
$00000080 constant EXTI_RTSR2_RT39                                  \ Rising trigger event configuration bit of line 39
$00000100 constant EXTI_RTSR2_RT40                                  \ Rising trigger event configuration bit of line 40
$00000200 constant EXTI_RTSR2_RT41                                  \ Rising trigger event configuration bit of line 41


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

