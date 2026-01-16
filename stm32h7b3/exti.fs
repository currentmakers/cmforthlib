\
\ @file exti.fs
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

$00000001 constant EXTI_RTSR1_TR0                                   \ Rising trigger event configuration bit of Configurable Event input
$00000002 constant EXTI_RTSR1_TR1                                   \ Rising trigger event configuration bit of Configurable Event input
$00000004 constant EXTI_RTSR1_TR2                                   \ Rising trigger event configuration bit of Configurable Event input
$00000008 constant EXTI_RTSR1_TR3                                   \ Rising trigger event configuration bit of Configurable Event input
$00000010 constant EXTI_RTSR1_TR4                                   \ Rising trigger event configuration bit of Configurable Event input
$00000020 constant EXTI_RTSR1_TR5                                   \ Rising trigger event configuration bit of Configurable Event input
$00000040 constant EXTI_RTSR1_TR6                                   \ Rising trigger event configuration bit of Configurable Event input
$00000080 constant EXTI_RTSR1_TR7                                   \ Rising trigger event configuration bit of Configurable Event input
$00000100 constant EXTI_RTSR1_TR8                                   \ Rising trigger event configuration bit of Configurable Event input
$00000200 constant EXTI_RTSR1_TR9                                   \ Rising trigger event configuration bit of Configurable Event input
$00000400 constant EXTI_RTSR1_TR10                                  \ Rising trigger event configuration bit of Configurable Event input
$00000800 constant EXTI_RTSR1_TR11                                  \ Rising trigger event configuration bit of Configurable Event input
$00001000 constant EXTI_RTSR1_TR12                                  \ Rising trigger event configuration bit of Configurable Event input
$00002000 constant EXTI_RTSR1_TR13                                  \ Rising trigger event configuration bit of Configurable Event input
$00004000 constant EXTI_RTSR1_TR14                                  \ Rising trigger event configuration bit of Configurable Event input
$00008000 constant EXTI_RTSR1_TR15                                  \ Rising trigger event configuration bit of Configurable Event input
$00010000 constant EXTI_RTSR1_TR16                                  \ Rising trigger event configuration bit of Configurable Event input
$00020000 constant EXTI_RTSR1_TR17                                  \ Rising trigger event configuration bit of Configurable Event input
$00040000 constant EXTI_RTSR1_TR18                                  \ Rising trigger event configuration bit of Configurable Event input
$00080000 constant EXTI_RTSR1_TR19                                  \ Rising trigger event configuration bit of Configurable Event input
$00100000 constant EXTI_RTSR1_TR20                                  \ Rising trigger event configuration bit of Configurable Event input
$00200000 constant EXTI_RTSR1_TR21                                  \ Rising trigger event configuration bit of Configurable Event input


\
\ @brief EXTI falling trigger selection register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant EXTI_FTSR1_TR0                                   \ Rising trigger event configuration bit of Configurable Event input
$00000002 constant EXTI_FTSR1_TR1                                   \ Rising trigger event configuration bit of Configurable Event input
$00000004 constant EXTI_FTSR1_TR2                                   \ Rising trigger event configuration bit of Configurable Event input
$00000008 constant EXTI_FTSR1_TR3                                   \ Rising trigger event configuration bit of Configurable Event input
$00000010 constant EXTI_FTSR1_TR4                                   \ Rising trigger event configuration bit of Configurable Event input
$00000020 constant EXTI_FTSR1_TR5                                   \ Rising trigger event configuration bit of Configurable Event input
$00000040 constant EXTI_FTSR1_TR6                                   \ Rising trigger event configuration bit of Configurable Event input
$00000080 constant EXTI_FTSR1_TR7                                   \ Rising trigger event configuration bit of Configurable Event input
$00000100 constant EXTI_FTSR1_TR8                                   \ Rising trigger event configuration bit of Configurable Event input
$00000200 constant EXTI_FTSR1_TR9                                   \ Rising trigger event configuration bit of Configurable Event input
$00000400 constant EXTI_FTSR1_TR10                                  \ Rising trigger event configuration bit of Configurable Event input
$00000800 constant EXTI_FTSR1_TR11                                  \ Rising trigger event configuration bit of Configurable Event input
$00001000 constant EXTI_FTSR1_TR12                                  \ Rising trigger event configuration bit of Configurable Event input
$00002000 constant EXTI_FTSR1_TR13                                  \ Rising trigger event configuration bit of Configurable Event input
$00004000 constant EXTI_FTSR1_TR14                                  \ Rising trigger event configuration bit of Configurable Event input
$00008000 constant EXTI_FTSR1_TR15                                  \ Rising trigger event configuration bit of Configurable Event input
$00010000 constant EXTI_FTSR1_TR16                                  \ Rising trigger event configuration bit of Configurable Event input
$00020000 constant EXTI_FTSR1_TR17                                  \ Rising trigger event configuration bit of Configurable Event input
$00040000 constant EXTI_FTSR1_TR18                                  \ Rising trigger event configuration bit of Configurable Event input
$00080000 constant EXTI_FTSR1_TR19                                  \ Rising trigger event configuration bit of Configurable Event input
$00100000 constant EXTI_FTSR1_TR20                                  \ Rising trigger event configuration bit of Configurable Event input
$00200000 constant EXTI_FTSR1_TR21                                  \ Rising trigger event configuration bit of Configurable Event input


\
\ @brief EXTI software interrupt event register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant EXTI_SWIER1_SWIER0                               \ Rising trigger event configuration bit of Configurable Event input
$00000002 constant EXTI_SWIER1_SWIER1                               \ Rising trigger event configuration bit of Configurable Event input
$00000004 constant EXTI_SWIER1_SWIER2                               \ Rising trigger event configuration bit of Configurable Event input
$00000008 constant EXTI_SWIER1_SWIER3                               \ Rising trigger event configuration bit of Configurable Event input
$00000010 constant EXTI_SWIER1_SWIER4                               \ Rising trigger event configuration bit of Configurable Event input
$00000020 constant EXTI_SWIER1_SWIER5                               \ Rising trigger event configuration bit of Configurable Event input
$00000040 constant EXTI_SWIER1_SWIER6                               \ Rising trigger event configuration bit of Configurable Event input
$00000080 constant EXTI_SWIER1_SWIER7                               \ Rising trigger event configuration bit of Configurable Event input
$00000100 constant EXTI_SWIER1_SWIER8                               \ Rising trigger event configuration bit of Configurable Event input
$00000200 constant EXTI_SWIER1_SWIER9                               \ Rising trigger event configuration bit of Configurable Event input
$00000400 constant EXTI_SWIER1_SWIER10                              \ Rising trigger event configuration bit of Configurable Event input
$00000800 constant EXTI_SWIER1_SWIER11                              \ Rising trigger event configuration bit of Configurable Event input
$00001000 constant EXTI_SWIER1_SWIER12                              \ Rising trigger event configuration bit of Configurable Event input
$00002000 constant EXTI_SWIER1_SWIER13                              \ Rising trigger event configuration bit of Configurable Event input
$00004000 constant EXTI_SWIER1_SWIER14                              \ Rising trigger event configuration bit of Configurable Event input
$00008000 constant EXTI_SWIER1_SWIER15                              \ Rising trigger event configuration bit of Configurable Event input
$00010000 constant EXTI_SWIER1_SWIER16                              \ Rising trigger event configuration bit of Configurable Event input
$00020000 constant EXTI_SWIER1_SWIER17                              \ Rising trigger event configuration bit of Configurable Event input
$00040000 constant EXTI_SWIER1_SWIER18                              \ Rising trigger event configuration bit of Configurable Event input
$00080000 constant EXTI_SWIER1_SWIER19                              \ Rising trigger event configuration bit of Configurable Event input
$00100000 constant EXTI_SWIER1_SWIER20                              \ Rising trigger event configuration bit of Configurable Event input
$00200000 constant EXTI_SWIER1_SWIER21                              \ Rising trigger event configuration bit of Configurable Event input


\
\ @brief EXTI D3 pending mask register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant EXTI_D3PMR1_MR0                                  \ Rising trigger event configuration bit of Configurable Event input
$00000002 constant EXTI_D3PMR1_MR1                                  \ Rising trigger event configuration bit of Configurable Event input
$00000004 constant EXTI_D3PMR1_MR2                                  \ Rising trigger event configuration bit of Configurable Event input
$00000008 constant EXTI_D3PMR1_MR3                                  \ Rising trigger event configuration bit of Configurable Event input
$00000010 constant EXTI_D3PMR1_MR4                                  \ Rising trigger event configuration bit of Configurable Event input
$00000020 constant EXTI_D3PMR1_MR5                                  \ Rising trigger event configuration bit of Configurable Event input
$00000040 constant EXTI_D3PMR1_MR6                                  \ Rising trigger event configuration bit of Configurable Event input
$00000080 constant EXTI_D3PMR1_MR7                                  \ Rising trigger event configuration bit of Configurable Event input
$00000100 constant EXTI_D3PMR1_MR8                                  \ Rising trigger event configuration bit of Configurable Event input
$00000200 constant EXTI_D3PMR1_MR9                                  \ Rising trigger event configuration bit of Configurable Event input
$00000400 constant EXTI_D3PMR1_MR10                                 \ Rising trigger event configuration bit of Configurable Event input
$00000800 constant EXTI_D3PMR1_MR11                                 \ Rising trigger event configuration bit of Configurable Event input
$00001000 constant EXTI_D3PMR1_MR12                                 \ Rising trigger event configuration bit of Configurable Event input
$00002000 constant EXTI_D3PMR1_MR13                                 \ Rising trigger event configuration bit of Configurable Event input
$00004000 constant EXTI_D3PMR1_MR14                                 \ Rising trigger event configuration bit of Configurable Event input
$00008000 constant EXTI_D3PMR1_MR15                                 \ Rising trigger event configuration bit of Configurable Event input
$00080000 constant EXTI_D3PMR1_MR19                                 \ Rising trigger event configuration bit of Configurable Event input
$00100000 constant EXTI_D3PMR1_MR20                                 \ Rising trigger event configuration bit of Configurable Event input
$00200000 constant EXTI_D3PMR1_MR21                                 \ Rising trigger event configuration bit of Configurable Event input
$02000000 constant EXTI_D3PMR1_MR25                                 \ Rising trigger event configuration bit of Configurable Event input


\
\ @brief EXTI D3 pending clear selection register low
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000003 constant EXTI_D3PCR1L_PCS0                                \ D3 Pending request clear input signal selection on Event input x = truncate (n/2)
$0000000c constant EXTI_D3PCR1L_PCS1                                \ D3 Pending request clear input signal selection on Event input x = truncate (n/2)
$00000030 constant EXTI_D3PCR1L_PCS2                                \ D3 Pending request clear input signal selection on Event input x = truncate (n/2)
$000000c0 constant EXTI_D3PCR1L_PCS3                                \ D3 Pending request clear input signal selection on Event input x = truncate (n/2)
$00000300 constant EXTI_D3PCR1L_PCS4                                \ D3 Pending request clear input signal selection on Event input x = truncate (n/2)
$00000c00 constant EXTI_D3PCR1L_PCS5                                \ D3 Pending request clear input signal selection on Event input x = truncate (n/2)
$00003000 constant EXTI_D3PCR1L_PCS6                                \ D3 Pending request clear input signal selection on Event input x = truncate (n/2)
$0000c000 constant EXTI_D3PCR1L_PCS7                                \ D3 Pending request clear input signal selection on Event input x = truncate (n/2)
$00030000 constant EXTI_D3PCR1L_PCS8                                \ D3 Pending request clear input signal selection on Event input x = truncate (n/2)
$000c0000 constant EXTI_D3PCR1L_PCS9                                \ D3 Pending request clear input signal selection on Event input x = truncate (n/2)
$00300000 constant EXTI_D3PCR1L_PCS10                               \ D3 Pending request clear input signal selection on Event input x = truncate (n/2)
$00c00000 constant EXTI_D3PCR1L_PCS11                               \ D3 Pending request clear input signal selection on Event input x = truncate (n/2)
$03000000 constant EXTI_D3PCR1L_PCS12                               \ D3 Pending request clear input signal selection on Event input x = truncate (n/2)
$0c000000 constant EXTI_D3PCR1L_PCS13                               \ D3 Pending request clear input signal selection on Event input x = truncate (n/2)
$30000000 constant EXTI_D3PCR1L_PCS14                               \ D3 Pending request clear input signal selection on Event input x = truncate (n/2)
$c0000000 constant EXTI_D3PCR1L_PCS15                               \ D3 Pending request clear input signal selection on Event input x = truncate (n/2)


\
\ @brief EXTI D3 pending clear selection register high
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000c0 constant EXTI_D3PCR1H_PCS19                               \ D3 Pending request clear input signal selection on Event input x = truncate ((n+32)/2)
$00000300 constant EXTI_D3PCR1H_PCS20                               \ D3 Pending request clear input signal selection on Event input x = truncate ((n+32)/2)
$00000c00 constant EXTI_D3PCR1H_PCS21                               \ D3 Pending request clear input signal selection on Event input x = truncate ((n+32)/2)
$000c0000 constant EXTI_D3PCR1H_PCS25                               \ D3 Pending request clear input signal selection on Event input x = truncate ((n+32)/2)


\
\ @brief EXTI rising trigger selection register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00020000 constant EXTI_RTSR2_TR49                                  \ Rising trigger event configuration bit of Configurable Event input x+32
$00080000 constant EXTI_RTSR2_TR51                                  \ Rising trigger event configuration bit of Configurable Event input x+32


\
\ @brief EXTI falling trigger selection register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00020000 constant EXTI_FTSR2_TR49                                  \ Falling trigger event configuration bit of Configurable Event input x+32
$00080000 constant EXTI_FTSR2_TR51                                  \ Falling trigger event configuration bit of Configurable Event input x+32


\
\ @brief EXTI software interrupt event register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00020000 constant EXTI_SWIER2_SWIER49                              \ Software interrupt on line x+32
$00080000 constant EXTI_SWIER2_SWIER51                              \ Software interrupt on line x+32


\
\ @brief EXTI D3 pending mask register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000004 constant EXTI_D3PMR2_MR34                                 \ D3 Pending Mask on Event input x+32
$00000008 constant EXTI_D3PMR2_MR35                                 \ D3 Pending Mask on Event input x+32
$00000200 constant EXTI_D3PMR2_MR41                                 \ D3 Pending Mask on Event input x+32
$00010000 constant EXTI_D3PMR2_MR48                                 \ D3 Pending Mask on Event input x+32
$00020000 constant EXTI_D3PMR2_MR49                                 \ D3 Pending Mask on Event input x+32
$00040000 constant EXTI_D3PMR2_MR50                                 \ D3 Pending Mask on Event input x+32
$00080000 constant EXTI_D3PMR2_MR51                                 \ D3 Pending Mask on Event input x+32
$00100000 constant EXTI_D3PMR2_MR52                                 \ D3 Pending Mask on Event input x+32
$00200000 constant EXTI_D3PMR2_MR53                                 \ D3 Pending Mask on Event input x+32


\
\ @brief EXTI D3 pending clear selection register low
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000030 constant EXTI_D3PCR2L_PCS34                               \ D3 Pending request clear input signal selection on Event input x = truncate ((n+64)/2)
$000000c0 constant EXTI_D3PCR2L_PCS35                               \ D3 Pending request clear input signal selection on Event input x = truncate ((n+64)/2)
$000c0000 constant EXTI_D3PCR2L_PCS41                               \ D3 Pending request clear input signal selection on Event input x = truncate ((n+64)/2)


\
\ @brief EXTI D3 pending clear selection register high
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000003 constant EXTI_D3PCR2H_PCS48                               \ Pending request clear input signal selection on Event input x= truncate ((n+96)/2)
$0000000c constant EXTI_D3PCR2H_PCS49                               \ Pending request clear input signal selection on Event input x= truncate ((n+96)/2)
$00000030 constant EXTI_D3PCR2H_PCS50                               \ Pending request clear input signal selection on Event input x= truncate ((n+96)/2)
$000000c0 constant EXTI_D3PCR2H_PCS51                               \ Pending request clear input signal selection on Event input x= truncate ((n+96)/2)
$00000300 constant EXTI_D3PCR2H_PCS52                               \ Pending request clear input signal selection on Event input x= truncate ((n+96)/2)
$00000c00 constant EXTI_D3PCR2H_PCS53                               \ Pending request clear input signal selection on Event input x= truncate ((n+96)/2)


\
\ @brief EXTI rising trigger selection register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00040000 constant EXTI_RTSR3_TR82                                  \ Rising trigger event configuration bit of Configurable Event input x+64
$00100000 constant EXTI_RTSR3_TR84                                  \ Rising trigger event configuration bit of Configurable Event input x+64
$00200000 constant EXTI_RTSR3_TR85                                  \ Rising trigger event configuration bit of Configurable Event input x+64
$00400000 constant EXTI_RTSR3_TR86                                  \ Rising trigger event configuration bit of Configurable Event input x+64


\
\ @brief EXTI falling trigger selection register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00040000 constant EXTI_FTSR3_TR82                                  \ Falling trigger event configuration bit of Configurable Event input x+64
$00100000 constant EXTI_FTSR3_TR84                                  \ Falling trigger event configuration bit of Configurable Event input x+64
$00200000 constant EXTI_FTSR3_TR85                                  \ Falling trigger event configuration bit of Configurable Event input x+64
$00400000 constant EXTI_FTSR3_TR86                                  \ Falling trigger event configuration bit of Configurable Event input x+64


\
\ @brief EXTI software interrupt event register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00040000 constant EXTI_SWIER3_SWIER82                              \ Software interrupt on line x+64
$00100000 constant EXTI_SWIER3_SWIER84                              \ Software interrupt on line x+64
$00200000 constant EXTI_SWIER3_SWIER85                              \ Software interrupt on line x+64
$00400000 constant EXTI_SWIER3_SWIER86                              \ Software interrupt on line x+64


\
\ @brief EXTI D3 pending mask register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$01000000 constant EXTI_D3PMR3_MR88                                 \ D3 Pending Mask on Event input x+64


\
\ @brief EXTI D3 pending clear selection register high
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$000c0000 constant EXTI_D3PCR3H_PCS88                               \ D3 Pending request clear input signal selection on Event input x= truncate N+160/2


\
\ @brief EXTI interrupt mask register
\ Address offset: 0x80
\ Reset value: 0xFFC00000
\

$00000001 constant EXTI_CPUIMR1_MR0                                 \ Rising trigger event configuration bit of Configurable Event input
$00000002 constant EXTI_CPUIMR1_MR1                                 \ Rising trigger event configuration bit of Configurable Event input
$00000004 constant EXTI_CPUIMR1_MR2                                 \ Rising trigger event configuration bit of Configurable Event input
$00000008 constant EXTI_CPUIMR1_MR3                                 \ Rising trigger event configuration bit of Configurable Event input
$00000010 constant EXTI_CPUIMR1_MR4                                 \ Rising trigger event configuration bit of Configurable Event input
$00000020 constant EXTI_CPUIMR1_MR5                                 \ Rising trigger event configuration bit of Configurable Event input
$00000040 constant EXTI_CPUIMR1_MR6                                 \ Rising trigger event configuration bit of Configurable Event input
$00000080 constant EXTI_CPUIMR1_MR7                                 \ Rising trigger event configuration bit of Configurable Event input
$00000100 constant EXTI_CPUIMR1_MR8                                 \ Rising trigger event configuration bit of Configurable Event input
$00000200 constant EXTI_CPUIMR1_MR9                                 \ Rising trigger event configuration bit of Configurable Event input
$00000400 constant EXTI_CPUIMR1_MR10                                \ Rising trigger event configuration bit of Configurable Event input
$00000800 constant EXTI_CPUIMR1_MR11                                \ Rising trigger event configuration bit of Configurable Event input
$00001000 constant EXTI_CPUIMR1_MR12                                \ Rising trigger event configuration bit of Configurable Event input
$00002000 constant EXTI_CPUIMR1_MR13                                \ Rising trigger event configuration bit of Configurable Event input
$00004000 constant EXTI_CPUIMR1_MR14                                \ Rising trigger event configuration bit of Configurable Event input
$00008000 constant EXTI_CPUIMR1_MR15                                \ Rising trigger event configuration bit of Configurable Event input
$00010000 constant EXTI_CPUIMR1_MR16                                \ Rising trigger event configuration bit of Configurable Event input
$00020000 constant EXTI_CPUIMR1_MR17                                \ Rising trigger event configuration bit of Configurable Event input
$00040000 constant EXTI_CPUIMR1_MR18                                \ Rising trigger event configuration bit of Configurable Event input
$00080000 constant EXTI_CPUIMR1_MR19                                \ Rising trigger event configuration bit of Configurable Event input
$00100000 constant EXTI_CPUIMR1_MR20                                \ Rising trigger event configuration bit of Configurable Event input
$00200000 constant EXTI_CPUIMR1_MR21                                \ Rising trigger event configuration bit of Configurable Event input
$00400000 constant EXTI_CPUIMR1_MR22                                \ Rising trigger event configuration bit of Configurable Event input
$00800000 constant EXTI_CPUIMR1_MR23                                \ Rising trigger event configuration bit of Configurable Event input
$01000000 constant EXTI_CPUIMR1_MR24                                \ Rising trigger event configuration bit of Configurable Event input
$02000000 constant EXTI_CPUIMR1_MR25                                \ Rising trigger event configuration bit of Configurable Event input
$04000000 constant EXTI_CPUIMR1_MR26                                \ Rising trigger event configuration bit of Configurable Event input
$08000000 constant EXTI_CPUIMR1_MR27                                \ Rising trigger event configuration bit of Configurable Event input
$10000000 constant EXTI_CPUIMR1_MR28                                \ Rising trigger event configuration bit of Configurable Event input
$20000000 constant EXTI_CPUIMR1_MR29                                \ Rising trigger event configuration bit of Configurable Event input
$40000000 constant EXTI_CPUIMR1_MR30                                \ Rising trigger event configuration bit of Configurable Event input
$80000000 constant EXTI_CPUIMR1_MR31                                \ Rising trigger event configuration bit of Configurable Event input


\
\ @brief EXTI event mask register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant EXTI_CPUEMR1_MR0                                 \ CPU Event mask on Event input x
$00000002 constant EXTI_CPUEMR1_MR1                                 \ CPU Event mask on Event input x
$00000004 constant EXTI_CPUEMR1_MR2                                 \ CPU Event mask on Event input x
$00000008 constant EXTI_CPUEMR1_MR3                                 \ CPU Event mask on Event input x
$00000010 constant EXTI_CPUEMR1_MR4                                 \ CPU Event mask on Event input x
$00000020 constant EXTI_CPUEMR1_MR5                                 \ CPU Event mask on Event input x
$00000040 constant EXTI_CPUEMR1_MR6                                 \ CPU Event mask on Event input x
$00000080 constant EXTI_CPUEMR1_MR7                                 \ CPU Event mask on Event input x
$00000100 constant EXTI_CPUEMR1_MR8                                 \ CPU Event mask on Event input x
$00000200 constant EXTI_CPUEMR1_MR9                                 \ CPU Event mask on Event input x
$00000400 constant EXTI_CPUEMR1_MR10                                \ CPU Event mask on Event input x
$00000800 constant EXTI_CPUEMR1_MR11                                \ CPU Event mask on Event input x
$00001000 constant EXTI_CPUEMR1_MR12                                \ CPU Event mask on Event input x
$00002000 constant EXTI_CPUEMR1_MR13                                \ CPU Event mask on Event input x
$00004000 constant EXTI_CPUEMR1_MR14                                \ CPU Event mask on Event input x
$00008000 constant EXTI_CPUEMR1_MR15                                \ CPU Event mask on Event input x
$00010000 constant EXTI_CPUEMR1_MR16                                \ CPU Event mask on Event input x
$00020000 constant EXTI_CPUEMR1_MR17                                \ CPU Event mask on Event input x
$00040000 constant EXTI_CPUEMR1_MR18                                \ CPU Event mask on Event input x
$00080000 constant EXTI_CPUEMR1_MR19                                \ CPU Event mask on Event input x
$00100000 constant EXTI_CPUEMR1_MR20                                \ CPU Event mask on Event input x
$00200000 constant EXTI_CPUEMR1_MR21                                \ CPU Event mask on Event input x
$00400000 constant EXTI_CPUEMR1_MR22                                \ CPU Event mask on Event input x
$00800000 constant EXTI_CPUEMR1_MR23                                \ CPU Event mask on Event input x
$01000000 constant EXTI_CPUEMR1_MR24                                \ CPU Event mask on Event input x
$02000000 constant EXTI_CPUEMR1_MR25                                \ CPU Event mask on Event input x
$04000000 constant EXTI_CPUEMR1_MR26                                \ CPU Event mask on Event input x
$08000000 constant EXTI_CPUEMR1_MR27                                \ CPU Event mask on Event input x
$10000000 constant EXTI_CPUEMR1_MR28                                \ CPU Event mask on Event input x
$20000000 constant EXTI_CPUEMR1_MR29                                \ CPU Event mask on Event input x
$40000000 constant EXTI_CPUEMR1_MR30                                \ CPU Event mask on Event input x
$80000000 constant EXTI_CPUEMR1_MR31                                \ CPU Event mask on Event input x


\
\ @brief EXTI pending register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant EXTI_CPUPR1_PR0                                  \ CPU Event mask on Event input x
$00000002 constant EXTI_CPUPR1_PR1                                  \ CPU Event mask on Event input x
$00000004 constant EXTI_CPUPR1_PR2                                  \ CPU Event mask on Event input x
$00000008 constant EXTI_CPUPR1_PR3                                  \ CPU Event mask on Event input x
$00000010 constant EXTI_CPUPR1_PR4                                  \ CPU Event mask on Event input x
$00000020 constant EXTI_CPUPR1_PR5                                  \ CPU Event mask on Event input x
$00000040 constant EXTI_CPUPR1_PR6                                  \ CPU Event mask on Event input x
$00000080 constant EXTI_CPUPR1_PR7                                  \ CPU Event mask on Event input x
$00000100 constant EXTI_CPUPR1_PR8                                  \ CPU Event mask on Event input x
$00000200 constant EXTI_CPUPR1_PR9                                  \ CPU Event mask on Event input x
$00000400 constant EXTI_CPUPR1_PR10                                 \ CPU Event mask on Event input x
$00000800 constant EXTI_CPUPR1_PR11                                 \ CPU Event mask on Event input x
$00001000 constant EXTI_CPUPR1_PR12                                 \ CPU Event mask on Event input x
$00002000 constant EXTI_CPUPR1_PR13                                 \ CPU Event mask on Event input x
$00004000 constant EXTI_CPUPR1_PR14                                 \ CPU Event mask on Event input x
$00008000 constant EXTI_CPUPR1_PR15                                 \ CPU Event mask on Event input x
$00010000 constant EXTI_CPUPR1_PR16                                 \ CPU Event mask on Event input x
$00020000 constant EXTI_CPUPR1_PR17                                 \ CPU Event mask on Event input x
$00040000 constant EXTI_CPUPR1_PR18                                 \ CPU Event mask on Event input x
$00080000 constant EXTI_CPUPR1_PR19                                 \ CPU Event mask on Event input x
$00100000 constant EXTI_CPUPR1_PR20                                 \ CPU Event mask on Event input x
$00200000 constant EXTI_CPUPR1_PR21                                 \ CPU Event mask on Event input x


\
\ @brief EXTI interrupt mask register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant EXTI_CPUIMR2_MR0                                 \ CPU Interrupt Mask on Direct Event input x+32
$00000002 constant EXTI_CPUIMR2_MR1                                 \ CPU Interrupt Mask on Direct Event input x+32
$00000004 constant EXTI_CPUIMR2_MR2                                 \ CPU Interrupt Mask on Direct Event input x+32
$00000008 constant EXTI_CPUIMR2_MR3                                 \ CPU Interrupt Mask on Direct Event input x+32
$00000010 constant EXTI_CPUIMR2_MR4                                 \ CPU Interrupt Mask on Direct Event input x+32
$00000020 constant EXTI_CPUIMR2_MR5                                 \ CPU Interrupt Mask on Direct Event input x+32
$00000040 constant EXTI_CPUIMR2_MR6                                 \ CPU Interrupt Mask on Direct Event input x+32
$00000080 constant EXTI_CPUIMR2_MR7                                 \ CPU Interrupt Mask on Direct Event input x+32
$00000100 constant EXTI_CPUIMR2_MR8                                 \ CPU Interrupt Mask on Direct Event input x+32
$00000200 constant EXTI_CPUIMR2_MR9                                 \ CPU Interrupt Mask on Direct Event input x+32
$00000400 constant EXTI_CPUIMR2_MR10                                \ CPU Interrupt Mask on Direct Event input x+32
$00000800 constant EXTI_CPUIMR2_MR11                                \ CPU Interrupt Mask on Direct Event input x+32
$00001000 constant EXTI_CPUIMR2_MR12                                \ CPU Interrupt Mask on Direct Event input x+32
$00004000 constant EXTI_CPUIMR2_MR14                                \ CPU Interrupt Mask on Direct Event input x+32
$00008000 constant EXTI_CPUIMR2_MR15                                \ CPU Interrupt Mask on Direct Event input x+32
$00010000 constant EXTI_CPUIMR2_MR16                                \ CPU Interrupt Mask on Direct Event input x+32
$00020000 constant EXTI_CPUIMR2_MR17                                \ CPU Interrupt Mask on Direct Event input x+32
$00040000 constant EXTI_CPUIMR2_MR18                                \ CPU Interrupt Mask on Direct Event input x+32
$00080000 constant EXTI_CPUIMR2_MR19                                \ CPU Interrupt Mask on Direct Event input x+32
$00100000 constant EXTI_CPUIMR2_MR20                                \ CPU Interrupt Mask on Direct Event input x+32
$00200000 constant EXTI_CPUIMR2_MR21                                \ CPU Interrupt Mask on Direct Event input x+32
$00400000 constant EXTI_CPUIMR2_MR22                                \ CPU Interrupt Mask on Direct Event input x+32
$00800000 constant EXTI_CPUIMR2_MR23                                \ CPU Interrupt Mask on Direct Event input x+32
$01000000 constant EXTI_CPUIMR2_MR24                                \ CPU Interrupt Mask on Direct Event input x+32
$02000000 constant EXTI_CPUIMR2_MR25                                \ CPU Interrupt Mask on Direct Event input x+32
$04000000 constant EXTI_CPUIMR2_MR26                                \ CPU Interrupt Mask on Direct Event input x+32
$08000000 constant EXTI_CPUIMR2_MR27                                \ CPU Interrupt Mask on Direct Event input x+32
$10000000 constant EXTI_CPUIMR2_MR28                                \ CPU Interrupt Mask on Direct Event input x+32
$20000000 constant EXTI_CPUIMR2_MR29                                \ CPU Interrupt Mask on Direct Event input x+32
$40000000 constant EXTI_CPUIMR2_MR30                                \ CPU Interrupt Mask on Direct Event input x+32
$80000000 constant EXTI_CPUIMR2_MR31                                \ CPU Interrupt Mask on Direct Event input x+32


\
\ @brief EXTI event mask register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant EXTI_CPUEMR2_MR32                                \ CPU Interrupt Mask on Direct Event input x+32
$00000002 constant EXTI_CPUEMR2_MR33                                \ CPU Interrupt Mask on Direct Event input x+32
$00000004 constant EXTI_CPUEMR2_MR34                                \ CPU Interrupt Mask on Direct Event input x+32
$00000008 constant EXTI_CPUEMR2_MR35                                \ CPU Interrupt Mask on Direct Event input x+32
$00000010 constant EXTI_CPUEMR2_MR36                                \ CPU Interrupt Mask on Direct Event input x+32
$00000020 constant EXTI_CPUEMR2_MR37                                \ CPU Interrupt Mask on Direct Event input x+32
$00000040 constant EXTI_CPUEMR2_MR38                                \ CPU Interrupt Mask on Direct Event input x+32
$00000080 constant EXTI_CPUEMR2_MR39                                \ CPU Interrupt Mask on Direct Event input x+32
$00000100 constant EXTI_CPUEMR2_MR40                                \ CPU Interrupt Mask on Direct Event input x+32
$00000200 constant EXTI_CPUEMR2_MR41                                \ CPU Interrupt Mask on Direct Event input x+32
$00000400 constant EXTI_CPUEMR2_MR42                                \ CPU Interrupt Mask on Direct Event input x+32
$00000800 constant EXTI_CPUEMR2_MR43                                \ CPU Interrupt Mask on Direct Event input x+32
$00001000 constant EXTI_CPUEMR2_MR44                                \ CPU Interrupt Mask on Direct Event input x+32
$00004000 constant EXTI_CPUEMR2_MR46                                \ CPU Interrupt Mask on Direct Event input x+32
$00008000 constant EXTI_CPUEMR2_MR47                                \ CPU Interrupt Mask on Direct Event input x+32
$00010000 constant EXTI_CPUEMR2_MR48                                \ CPU Interrupt Mask on Direct Event input x+32
$00020000 constant EXTI_CPUEMR2_MR49                                \ CPU Interrupt Mask on Direct Event input x+32
$00040000 constant EXTI_CPUEMR2_MR50                                \ CPU Interrupt Mask on Direct Event input x+32
$00080000 constant EXTI_CPUEMR2_MR51                                \ CPU Interrupt Mask on Direct Event input x+32
$00100000 constant EXTI_CPUEMR2_MR52                                \ CPU Interrupt Mask on Direct Event input x+32
$00200000 constant EXTI_CPUEMR2_MR53                                \ CPU Interrupt Mask on Direct Event input x+32
$00400000 constant EXTI_CPUEMR2_MR54                                \ CPU Interrupt Mask on Direct Event input x+32
$00800000 constant EXTI_CPUEMR2_MR55                                \ CPU Interrupt Mask on Direct Event input x+32
$01000000 constant EXTI_CPUEMR2_MR56                                \ CPU Interrupt Mask on Direct Event input x+32
$02000000 constant EXTI_CPUEMR2_MR57                                \ CPU Interrupt Mask on Direct Event input x+32
$04000000 constant EXTI_CPUEMR2_MR58                                \ CPU Interrupt Mask on Direct Event input x+32
$08000000 constant EXTI_CPUEMR2_MR59                                \ CPU Interrupt Mask on Direct Event input x+32
$10000000 constant EXTI_CPUEMR2_MR60                                \ CPU Interrupt Mask on Direct Event input x+32
$20000000 constant EXTI_CPUEMR2_MR61                                \ CPU Interrupt Mask on Direct Event input x+32
$40000000 constant EXTI_CPUEMR2_MR62                                \ CPU Interrupt Mask on Direct Event input x+32
$80000000 constant EXTI_CPUEMR2_MR63                                \ CPU Interrupt Mask on Direct Event input x+32


\
\ @brief EXTI pending register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00020000 constant EXTI_CPUPR2_PR49                                 \ Configurable event inputs x+32 Pending bit
$00080000 constant EXTI_CPUPR2_PR51                                 \ Configurable event inputs x+32 Pending bit


\
\ @brief EXTI interrupt mask register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000001 constant EXTI_CPUIMR3_MR64                                \ CPU Interrupt Mask on Direct Event input x+64
$00000002 constant EXTI_CPUIMR3_MR65                                \ CPU Interrupt Mask on Direct Event input x+64
$00000004 constant EXTI_CPUIMR3_MR66                                \ CPU Interrupt Mask on Direct Event input x+64
$00000008 constant EXTI_CPUIMR3_MR67                                \ CPU Interrupt Mask on Direct Event input x+64
$00000010 constant EXTI_CPUIMR3_MR68                                \ CPU Interrupt Mask on Direct Event input x+64
$00000020 constant EXTI_CPUIMR3_MR69                                \ CPU Interrupt Mask on Direct Event input x+64
$00000040 constant EXTI_CPUIMR3_MR70                                \ CPU Interrupt Mask on Direct Event input x+64
$00000080 constant EXTI_CPUIMR3_MR71                                \ CPU Interrupt Mask on Direct Event input x+64
$00000100 constant EXTI_CPUIMR3_MR72                                \ CPU Interrupt Mask on Direct Event input x+64
$00000200 constant EXTI_CPUIMR3_MR73                                \ CPU Interrupt Mask on Direct Event input x+64
$00000400 constant EXTI_CPUIMR3_MR74                                \ CPU Interrupt Mask on Direct Event input x+64
$00000800 constant EXTI_CPUIMR3_MR75                                \ CPU Interrupt Mask on Direct Event input x+64
$00001000 constant EXTI_CPUIMR3_MR76                                \ CPU Interrupt Mask on Direct Event input x+64
$00002000 constant EXTI_CPUIMR3_MR77                                \ CPU Interrupt Mask on Direct Event input x+64
$00004000 constant EXTI_CPUIMR3_MR78                                \ CPU Interrupt Mask on Direct Event input x+64
$00008000 constant EXTI_CPUIMR3_MR79                                \ CPU Interrupt Mask on Direct Event input x+64
$00010000 constant EXTI_CPUIMR3_MR80                                \ CPU Interrupt Mask on Direct Event input x+64
$00040000 constant EXTI_CPUIMR3_MR82                                \ CPU Interrupt Mask on Direct Event input x+64
$00100000 constant EXTI_CPUIMR3_MR84                                \ CPU Interrupt Mask on Direct Event input x+64
$00200000 constant EXTI_CPUIMR3_MR85                                \ CPU Interrupt Mask on Direct Event input x+64
$00400000 constant EXTI_CPUIMR3_MR86                                \ CPU Interrupt Mask on Direct Event input x+64
$00800000 constant EXTI_CPUIMR3_MR87                                \ CPU Interrupt Mask on Direct Event input x+64
$01000000 constant EXTI_CPUIMR3_MR88                                \ CPU Interrupt Mask on Direct Event input x+64


\
\ @brief EXTI event mask register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000001 constant EXTI_CPUEMR3_MR64                                \ CPU Event mask on Event input x+64
$00000002 constant EXTI_CPUEMR3_MR65                                \ CPU Event mask on Event input x+64
$00000004 constant EXTI_CPUEMR3_MR66                                \ CPU Event mask on Event input x+64
$00000008 constant EXTI_CPUEMR3_MR67                                \ CPU Event mask on Event input x+64
$00000010 constant EXTI_CPUEMR3_MR68                                \ CPU Event mask on Event input x+64
$00000020 constant EXTI_CPUEMR3_MR69                                \ CPU Event mask on Event input x+64
$00000040 constant EXTI_CPUEMR3_MR70                                \ CPU Event mask on Event input x+64
$00000080 constant EXTI_CPUEMR3_MR71                                \ CPU Event mask on Event input x+64
$00000100 constant EXTI_CPUEMR3_MR72                                \ CPU Event mask on Event input x+64
$00000200 constant EXTI_CPUEMR3_MR73                                \ CPU Event mask on Event input x+64
$00000400 constant EXTI_CPUEMR3_MR74                                \ CPU Event mask on Event input x+64
$00000800 constant EXTI_CPUEMR3_MR75                                \ CPU Event mask on Event input x+64
$00001000 constant EXTI_CPUEMR3_MR76                                \ CPU Event mask on Event input x+64
$00002000 constant EXTI_CPUEMR3_MR77                                \ CPU Event mask on Event input x+64
$00004000 constant EXTI_CPUEMR3_MR78                                \ CPU Event mask on Event input x+64
$00008000 constant EXTI_CPUEMR3_MR79                                \ CPU Event mask on Event input x+64
$00010000 constant EXTI_CPUEMR3_MR80                                \ CPU Event mask on Event input x+64
$00040000 constant EXTI_CPUEMR3_MR82                                \ CPU Event mask on Event input x+64
$00100000 constant EXTI_CPUEMR3_MR84                                \ CPU Event mask on Event input x+64
$00200000 constant EXTI_CPUEMR3_MR85                                \ CPU Event mask on Event input x+64
$00400000 constant EXTI_CPUEMR3_MR86                                \ CPU Event mask on Event input x+64
$00800000 constant EXTI_CPUEMR3_MR87                                \ CPU Event mask on Event input x+64
$01000000 constant EXTI_CPUEMR3_MR88                                \ CPU Event mask on Event input x+64


\
\ @brief EXTI pending register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00040000 constant EXTI_CPUPR3_PR82                                 \ Configurable event inputs x+64 Pending bit
$00100000 constant EXTI_CPUPR3_PR84                                 \ Configurable event inputs x+64 Pending bit
$00200000 constant EXTI_CPUPR3_PR85                                 \ Configurable event inputs x+64 Pending bit
$00400000 constant EXTI_CPUPR3_PR86                                 \ Configurable event inputs x+64 Pending bit


\
\ @brief External interrupt/event controller
\
$58000000 constant EXTI_RTSR1     \ offset: 0x00 : EXTI rising trigger selection register
$58000004 constant EXTI_FTSR1     \ offset: 0x04 : EXTI falling trigger selection register
$58000008 constant EXTI_SWIER1    \ offset: 0x08 : EXTI software interrupt event register
$5800000c constant EXTI_D3PMR1    \ offset: 0x0C : EXTI D3 pending mask register
$58000010 constant EXTI_D3PCR1L   \ offset: 0x10 : EXTI D3 pending clear selection register low
$58000014 constant EXTI_D3PCR1H   \ offset: 0x14 : EXTI D3 pending clear selection register high
$58000020 constant EXTI_RTSR2     \ offset: 0x20 : EXTI rising trigger selection register
$58000024 constant EXTI_FTSR2     \ offset: 0x24 : EXTI falling trigger selection register
$58000028 constant EXTI_SWIER2    \ offset: 0x28 : EXTI software interrupt event register
$5800002c constant EXTI_D3PMR2    \ offset: 0x2C : EXTI D3 pending mask register
$58000030 constant EXTI_D3PCR2L   \ offset: 0x30 : EXTI D3 pending clear selection register low
$58000034 constant EXTI_D3PCR2H   \ offset: 0x34 : EXTI D3 pending clear selection register high
$58000040 constant EXTI_RTSR3     \ offset: 0x40 : EXTI rising trigger selection register
$58000044 constant EXTI_FTSR3     \ offset: 0x44 : EXTI falling trigger selection register
$58000048 constant EXTI_SWIER3    \ offset: 0x48 : EXTI software interrupt event register
$5800004c constant EXTI_D3PMR3    \ offset: 0x4C : EXTI D3 pending mask register
$58000054 constant EXTI_D3PCR3H   \ offset: 0x54 : EXTI D3 pending clear selection register high
$58000080 constant EXTI_CPUIMR1   \ offset: 0x80 : EXTI interrupt mask register
$58000084 constant EXTI_CPUEMR1   \ offset: 0x84 : EXTI event mask register
$58000088 constant EXTI_CPUPR1    \ offset: 0x88 : EXTI pending register
$58000090 constant EXTI_CPUIMR2   \ offset: 0x90 : EXTI interrupt mask register
$58000094 constant EXTI_CPUEMR2   \ offset: 0x94 : EXTI event mask register
$58000098 constant EXTI_CPUPR2    \ offset: 0x98 : EXTI pending register
$580000a0 constant EXTI_CPUIMR3   \ offset: 0xA0 : EXTI interrupt mask register
$580000a4 constant EXTI_CPUEMR3   \ offset: 0xA4 : EXTI event mask register
$580000a8 constant EXTI_CPUPR3    \ offset: 0xA8 : EXTI pending register

