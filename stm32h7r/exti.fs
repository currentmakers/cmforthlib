\
\ @file exti.fs
\ @brief Extended interrupt and event controller
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

$00000001 constant EXTI_EXTI_RTSR1_TR0                              \ Rising trigger event configuration bit of configurable event input x.
$00000002 constant EXTI_EXTI_RTSR1_TR1                              \ Rising trigger event configuration bit of configurable event input x.
$00000004 constant EXTI_EXTI_RTSR1_TR2                              \ Rising trigger event configuration bit of configurable event input x.
$00000008 constant EXTI_EXTI_RTSR1_TR3                              \ Rising trigger event configuration bit of configurable event input x.
$00000010 constant EXTI_EXTI_RTSR1_TR4                              \ Rising trigger event configuration bit of configurable event input x.
$00000020 constant EXTI_EXTI_RTSR1_TR5                              \ Rising trigger event configuration bit of configurable event input x.
$00000040 constant EXTI_EXTI_RTSR1_TR6                              \ Rising trigger event configuration bit of configurable event input x.
$00000080 constant EXTI_EXTI_RTSR1_TR7                              \ Rising trigger event configuration bit of configurable event input x.
$00000100 constant EXTI_EXTI_RTSR1_TR8                              \ Rising trigger event configuration bit of configurable event input x.
$00000200 constant EXTI_EXTI_RTSR1_TR9                              \ Rising trigger event configuration bit of configurable event input x.
$00000400 constant EXTI_EXTI_RTSR1_TR10                             \ Rising trigger event configuration bit of configurable event input x.
$00000800 constant EXTI_EXTI_RTSR1_TR11                             \ Rising trigger event configuration bit of configurable event input x.
$00001000 constant EXTI_EXTI_RTSR1_TR12                             \ Rising trigger event configuration bit of configurable event input x.
$00002000 constant EXTI_EXTI_RTSR1_TR13                             \ Rising trigger event configuration bit of configurable event input x.
$00004000 constant EXTI_EXTI_RTSR1_TR14                             \ Rising trigger event configuration bit of configurable event input x.
$00008000 constant EXTI_EXTI_RTSR1_TR15                             \ Rising trigger event configuration bit of configurable event input x.
$00010000 constant EXTI_EXTI_RTSR1_TR16                             \ Rising trigger event configuration bit of configurable event input x.
$00020000 constant EXTI_EXTI_RTSR1_TR17                             \ Rising trigger event configuration bit of configurable event input x.
$00040000 constant EXTI_EXTI_RTSR1_TR18                             \ Rising trigger event configuration bit of configurable event input x.
$00080000 constant EXTI_EXTI_RTSR1_TR19                             \ Rising trigger event configuration bit of configurable event input x.
$00100000 constant EXTI_EXTI_RTSR1_TR20                             \ Rising trigger event configuration bit of configurable event input x.
$00200000 constant EXTI_EXTI_RTSR1_TR21                             \ Rising trigger event configuration bit of configurable event input x.


\
\ @brief EXTI falling trigger selection register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_FTSR1_TR0                              \ Falling trigger event configuration bit of configurable event input x.
$00000002 constant EXTI_EXTI_FTSR1_TR1                              \ Falling trigger event configuration bit of configurable event input x.
$00000004 constant EXTI_EXTI_FTSR1_TR2                              \ Falling trigger event configuration bit of configurable event input x.
$00000008 constant EXTI_EXTI_FTSR1_TR3                              \ Falling trigger event configuration bit of configurable event input x.
$00000010 constant EXTI_EXTI_FTSR1_TR4                              \ Falling trigger event configuration bit of configurable event input x.
$00000020 constant EXTI_EXTI_FTSR1_TR5                              \ Falling trigger event configuration bit of configurable event input x.
$00000040 constant EXTI_EXTI_FTSR1_TR6                              \ Falling trigger event configuration bit of configurable event input x.
$00000080 constant EXTI_EXTI_FTSR1_TR7                              \ Falling trigger event configuration bit of configurable event input x.
$00000100 constant EXTI_EXTI_FTSR1_TR8                              \ Falling trigger event configuration bit of configurable event input x.
$00000200 constant EXTI_EXTI_FTSR1_TR9                              \ Falling trigger event configuration bit of configurable event input x.
$00000400 constant EXTI_EXTI_FTSR1_TR10                             \ Falling trigger event configuration bit of configurable event input x.
$00000800 constant EXTI_EXTI_FTSR1_TR11                             \ Falling trigger event configuration bit of configurable event input x.
$00001000 constant EXTI_EXTI_FTSR1_TR12                             \ Falling trigger event configuration bit of configurable event input x.
$00002000 constant EXTI_EXTI_FTSR1_TR13                             \ Falling trigger event configuration bit of configurable event input x.
$00004000 constant EXTI_EXTI_FTSR1_TR14                             \ Falling trigger event configuration bit of configurable event input x.
$00008000 constant EXTI_EXTI_FTSR1_TR15                             \ Falling trigger event configuration bit of configurable event input x.
$00010000 constant EXTI_EXTI_FTSR1_TR16                             \ Falling trigger event configuration bit of configurable event input x.
$00020000 constant EXTI_EXTI_FTSR1_TR17                             \ Falling trigger event configuration bit of configurable event input x.
$00040000 constant EXTI_EXTI_FTSR1_TR18                             \ Falling trigger event configuration bit of configurable event input x.
$00080000 constant EXTI_EXTI_FTSR1_TR19                             \ Falling trigger event configuration bit of configurable event input x.
$00100000 constant EXTI_EXTI_FTSR1_TR20                             \ Falling trigger event configuration bit of configurable event input x.
$00200000 constant EXTI_EXTI_FTSR1_TR21                             \ Falling trigger event configuration bit of configurable event input x.


\
\ @brief EXTI software interrupt event register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_SWIER1_SWIER0                          \ Software interrupt on line x This bitfield alway returns 0 when read.
$00000002 constant EXTI_EXTI_SWIER1_SWIER1                          \ Software interrupt on line x This bitfield alway returns 0 when read.
$00000004 constant EXTI_EXTI_SWIER1_SWIER2                          \ Software interrupt on line x This bitfield alway returns 0 when read.
$00000008 constant EXTI_EXTI_SWIER1_SWIER3                          \ Software interrupt on line x This bitfield alway returns 0 when read.
$00000010 constant EXTI_EXTI_SWIER1_SWIER4                          \ Software interrupt on line x This bitfield alway returns 0 when read.
$00000020 constant EXTI_EXTI_SWIER1_SWIER5                          \ Software interrupt on line x This bitfield alway returns 0 when read.
$00000040 constant EXTI_EXTI_SWIER1_SWIER6                          \ Software interrupt on line x This bitfield alway returns 0 when read.
$00000080 constant EXTI_EXTI_SWIER1_SWIER7                          \ Software interrupt on line x This bitfield alway returns 0 when read.
$00000100 constant EXTI_EXTI_SWIER1_SWIER8                          \ Software interrupt on line x This bitfield alway returns 0 when read.
$00000200 constant EXTI_EXTI_SWIER1_SWIER9                          \ Software interrupt on line x This bitfield alway returns 0 when read.
$00000400 constant EXTI_EXTI_SWIER1_SWIER10                         \ Software interrupt on line x This bitfield alway returns 0 when read.
$00000800 constant EXTI_EXTI_SWIER1_SWIER11                         \ Software interrupt on line x This bitfield alway returns 0 when read.
$00001000 constant EXTI_EXTI_SWIER1_SWIER12                         \ Software interrupt on line x This bitfield alway returns 0 when read.
$00002000 constant EXTI_EXTI_SWIER1_SWIER13                         \ Software interrupt on line x This bitfield alway returns 0 when read.
$00004000 constant EXTI_EXTI_SWIER1_SWIER14                         \ Software interrupt on line x This bitfield alway returns 0 when read.
$00008000 constant EXTI_EXTI_SWIER1_SWIER15                         \ Software interrupt on line x This bitfield alway returns 0 when read.
$00010000 constant EXTI_EXTI_SWIER1_SWIER16                         \ Software interrupt on line x This bitfield alway returns 0 when read.
$00020000 constant EXTI_EXTI_SWIER1_SWIER17                         \ Software interrupt on line x This bitfield alway returns 0 when read.
$00040000 constant EXTI_EXTI_SWIER1_SWIER18                         \ Software interrupt on line x This bitfield alway returns 0 when read.
$00080000 constant EXTI_EXTI_SWIER1_SWIER19                         \ Software interrupt on line x This bitfield alway returns 0 when read.
$00100000 constant EXTI_EXTI_SWIER1_SWIER20                         \ Software interrupt on line x This bitfield alway returns 0 when read.
$00200000 constant EXTI_EXTI_SWIER1_SWIER21                         \ Software interrupt on line x This bitfield alway returns 0 when read.


\
\ @brief EXTI rising trigger selection register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000004 constant EXTI_EXTI_RTSR2_TR34                             \ Rising trigger event configuration bit of configurable event input x+32.<sup>(1)</sup>
$00004000 constant EXTI_EXTI_RTSR2_TR46                             \ Rising trigger event configuration bit of configurable event input x+32.<sup>(1)</sup>
$00020000 constant EXTI_EXTI_RTSR2_TR49                             \ Rising trigger event configuration bit of configurable event input x+32.<sup>(1)</sup>
$00080000 constant EXTI_EXTI_RTSR2_TR51                             \ Rising trigger event configuration bit of configurable event input x+32.<sup>(1)</sup>
$00400000 constant EXTI_EXTI_RTSR2_TR54                             \ Rising trigger event configuration bit of configurable event input x+32.


\
\ @brief EXTI falling trigger selection register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000004 constant EXTI_EXTI_FTSR2_TR34                             \ Falling trigger event configuration bit of configurable event input x+32.<sup>(1)</sup>
$00004000 constant EXTI_EXTI_FTSR2_TR46                             \ Falling trigger event configuration bit of configurable event input x+32.<sup>(1)</sup>
$00020000 constant EXTI_EXTI_FTSR2_TR49                             \ Falling trigger event configuration bit of configurable event input x+32.<sup>(1)</sup>
$00080000 constant EXTI_EXTI_FTSR2_TR51                             \ Falling trigger event configuration bit of configurable event input x+32.<sup>(1)</sup>
$00400000 constant EXTI_EXTI_FTSR2_TR54                             \ Falling trigger event configuration bit of configurable event input x+32.


\
\ @brief EXTI software interrupt event register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000004 constant EXTI_EXTI_SWIER2_SWIER34                         \ Software interrupt on line x+32 Always returns 0 when read.
$00004000 constant EXTI_EXTI_SWIER2_SWIER46                         \ Software interrupt on line x+32 Always returns 0 when read.
$00020000 constant EXTI_EXTI_SWIER2_SWIER49                         \ Software interrupt on line x+32 Always returns 0 when read.
$00080000 constant EXTI_EXTI_SWIER2_SWIER51                         \ Software interrupt on line x+32 Always returns 0 when read.
$00400000 constant EXTI_EXTI_SWIER2_SWIER54                         \ Software interrupt on line x+32 Always returns 0 when read.


\
\ @brief EXTI interrupt mask register
\ Address offset: 0x18
\ Reset value: 0xFFC00000
\

$00000001 constant EXTI_EXTI_IMR1_MR0                               \ CPU interrupt mask on configurable event input x
$00000002 constant EXTI_EXTI_IMR1_MR1                               \ CPU interrupt mask on configurable event input x
$00000004 constant EXTI_EXTI_IMR1_MR2                               \ CPU interrupt mask on configurable event input x
$00000008 constant EXTI_EXTI_IMR1_MR3                               \ CPU interrupt mask on configurable event input x
$00000010 constant EXTI_EXTI_IMR1_MR4                               \ CPU interrupt mask on configurable event input x
$00000020 constant EXTI_EXTI_IMR1_MR5                               \ CPU interrupt mask on configurable event input x
$00000040 constant EXTI_EXTI_IMR1_MR6                               \ CPU interrupt mask on configurable event input x
$00000080 constant EXTI_EXTI_IMR1_MR7                               \ CPU interrupt mask on configurable event input x
$00000100 constant EXTI_EXTI_IMR1_MR8                               \ CPU interrupt mask on configurable event input x
$00000200 constant EXTI_EXTI_IMR1_MR9                               \ CPU interrupt mask on configurable event input x
$00000400 constant EXTI_EXTI_IMR1_MR10                              \ CPU interrupt mask on configurable event input x
$00000800 constant EXTI_EXTI_IMR1_MR11                              \ CPU interrupt mask on configurable event input x
$00001000 constant EXTI_EXTI_IMR1_MR12                              \ CPU interrupt mask on configurable event input x
$00002000 constant EXTI_EXTI_IMR1_MR13                              \ CPU interrupt mask on configurable event input x
$00004000 constant EXTI_EXTI_IMR1_MR14                              \ CPU interrupt mask on configurable event input x
$00008000 constant EXTI_EXTI_IMR1_MR15                              \ CPU interrupt mask on configurable event input x
$00010000 constant EXTI_EXTI_IMR1_MR16                              \ CPU interrupt mask on configurable event input x
$00020000 constant EXTI_EXTI_IMR1_MR17                              \ CPU interrupt mask on configurable event input x
$00040000 constant EXTI_EXTI_IMR1_MR18                              \ CPU interrupt mask on configurable event input x
$00080000 constant EXTI_EXTI_IMR1_MR19                              \ CPU interrupt mask on configurable event input x
$00100000 constant EXTI_EXTI_IMR1_MR20                              \ CPU interrupt mask on configurable event input x
$00200000 constant EXTI_EXTI_IMR1_MR21                              \ CPU interrupt mask on configurable event input x
$00400000 constant EXTI_EXTI_IMR1_MR22                              \ CPU interrupt mask on direct event input x
$00800000 constant EXTI_EXTI_IMR1_MR23                              \ CPU interrupt mask on direct event input x
$01000000 constant EXTI_EXTI_IMR1_MR24                              \ CPU interrupt mask on direct event input x
$02000000 constant EXTI_EXTI_IMR1_MR25                              \ CPU interrupt mask on direct event input x
$04000000 constant EXTI_EXTI_IMR1_MR26                              \ CPU interrupt mask on direct event input x
$08000000 constant EXTI_EXTI_IMR1_MR27                              \ CPU interrupt mask on direct event input x
$10000000 constant EXTI_EXTI_IMR1_MR28                              \ CPU interrupt mask on direct event input x
$20000000 constant EXTI_EXTI_IMR1_MR29                              \ CPU interrupt mask on direct event input x
$40000000 constant EXTI_EXTI_IMR1_MR30                              \ CPU interrupt mask on direct event input x
$80000000 constant EXTI_EXTI_IMR1_MR31                              \ CPU interrupt mask on direct event input x


\
\ @brief EXTI event mask register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_EMR1_MR0                               \ CPU event mask on event input x
$00000002 constant EXTI_EXTI_EMR1_MR1                               \ CPU event mask on event input x
$00000004 constant EXTI_EXTI_EMR1_MR2                               \ CPU event mask on event input x
$00000008 constant EXTI_EXTI_EMR1_MR3                               \ CPU event mask on event input x
$00000010 constant EXTI_EXTI_EMR1_MR4                               \ CPU event mask on event input x
$00000020 constant EXTI_EXTI_EMR1_MR5                               \ CPU event mask on event input x
$00000040 constant EXTI_EXTI_EMR1_MR6                               \ CPU event mask on event input x
$00000080 constant EXTI_EXTI_EMR1_MR7                               \ CPU event mask on event input x
$00000100 constant EXTI_EXTI_EMR1_MR8                               \ CPU event mask on event input x
$00000200 constant EXTI_EXTI_EMR1_MR9                               \ CPU event mask on event input x
$00000400 constant EXTI_EXTI_EMR1_MR10                              \ CPU event mask on event input x
$00000800 constant EXTI_EXTI_EMR1_MR11                              \ CPU event mask on event input x
$00001000 constant EXTI_EXTI_EMR1_MR12                              \ CPU event mask on event input x
$00002000 constant EXTI_EXTI_EMR1_MR13                              \ CPU event mask on event input x
$00004000 constant EXTI_EXTI_EMR1_MR14                              \ CPU event mask on event input x
$00008000 constant EXTI_EXTI_EMR1_MR15                              \ CPU event mask on event input x
$00010000 constant EXTI_EXTI_EMR1_MR16                              \ CPU event mask on event input x
$00020000 constant EXTI_EXTI_EMR1_MR17                              \ CPU event mask on event input x
$00040000 constant EXTI_EXTI_EMR1_MR18                              \ CPU event mask on event input x
$00080000 constant EXTI_EXTI_EMR1_MR19                              \ CPU event mask on event input x
$00100000 constant EXTI_EXTI_EMR1_MR20                              \ CPU event mask on event input x
$00200000 constant EXTI_EXTI_EMR1_MR21                              \ CPU event mask on event input x
$00400000 constant EXTI_EXTI_EMR1_MR22                              \ CPU event mask on event input x
$00800000 constant EXTI_EXTI_EMR1_MR23                              \ CPU event mask on event input x
$01000000 constant EXTI_EXTI_EMR1_MR24                              \ CPU event mask on event input x
$02000000 constant EXTI_EXTI_EMR1_MR25                              \ CPU event mask on event input x
$04000000 constant EXTI_EXTI_EMR1_MR26                              \ CPU event mask on event input x
$08000000 constant EXTI_EXTI_EMR1_MR27                              \ CPU event mask on event input x
$10000000 constant EXTI_EXTI_EMR1_MR28                              \ CPU event mask on event input x
$20000000 constant EXTI_EXTI_EMR1_MR29                              \ CPU event mask on event input x
$40000000 constant EXTI_EXTI_EMR1_MR30                              \ CPU event mask on event input x
$80000000 constant EXTI_EXTI_EMR1_MR31                              \ CPU event mask on event input x


\
\ @brief EXTI pending register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_PR1_PR0                                \ Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00000002 constant EXTI_EXTI_PR1_PR1                                \ Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00000004 constant EXTI_EXTI_PR1_PR2                                \ Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00000008 constant EXTI_EXTI_PR1_PR3                                \ Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00000010 constant EXTI_EXTI_PR1_PR4                                \ Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00000020 constant EXTI_EXTI_PR1_PR5                                \ Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00000040 constant EXTI_EXTI_PR1_PR6                                \ Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00000080 constant EXTI_EXTI_PR1_PR7                                \ Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00000100 constant EXTI_EXTI_PR1_PR8                                \ Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00000200 constant EXTI_EXTI_PR1_PR9                                \ Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00000400 constant EXTI_EXTI_PR1_PR10                               \ Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00000800 constant EXTI_EXTI_PR1_PR11                               \ Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00001000 constant EXTI_EXTI_PR1_PR12                               \ Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00002000 constant EXTI_EXTI_PR1_PR13                               \ Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00004000 constant EXTI_EXTI_PR1_PR14                               \ Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00008000 constant EXTI_EXTI_PR1_PR15                               \ Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00010000 constant EXTI_EXTI_PR1_PR16                               \ Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00020000 constant EXTI_EXTI_PR1_PR17                               \ Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00040000 constant EXTI_EXTI_PR1_PR18                               \ Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00080000 constant EXTI_EXTI_PR1_PR19                               \ Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00100000 constant EXTI_EXTI_PR1_PR20                               \ Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00200000 constant EXTI_EXTI_PR1_PR21                               \ Configurable event inputs x Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.


\
\ @brief EXTI interrupt mask register
\ Address offset: 0x24
\ Reset value: 0xFFF5FFFF
\

$00000001 constant EXTI_EXTI_IMR2_MR32                              \ CPU interrupt mask on direct event input i
$00000002 constant EXTI_EXTI_IMR2_MR33                              \ CPU interrupt mask on direct event input i
$00000004 constant EXTI_EXTI_IMR2_MR34                              \ CPU interrupt mask on direct event input i
$00000008 constant EXTI_EXTI_IMR2_MR35                              \ CPU interrupt mask on direct event input i
$00000010 constant EXTI_EXTI_IMR2_MR36                              \ CPU interrupt mask on direct event input i
$00000020 constant EXTI_EXTI_IMR2_MR37                              \ CPU interrupt mask on direct event input i
$00000040 constant EXTI_EXTI_IMR2_MR38                              \ CPU interrupt mask on direct event input i
$00000080 constant EXTI_EXTI_IMR2_MR39                              \ CPU interrupt mask on direct event input i
$00000100 constant EXTI_EXTI_IMR2_MR40                              \ CPU interrupt mask on direct event input i
$00000200 constant EXTI_EXTI_IMR2_MR41                              \ CPU interrupt mask on direct event input i
$00000400 constant EXTI_EXTI_IMR2_MR42                              \ CPU interrupt mask on direct event input i
$00000800 constant EXTI_EXTI_IMR2_MR43                              \ CPU interrupt mask on direct event input i
$00001000 constant EXTI_EXTI_IMR2_MR44                              \ CPU interrupt mask on direct event input i
$00002000 constant EXTI_EXTI_IMR2_MR45                              \ CPU interrupt mask on direct event input i
$00004000 constant EXTI_EXTI_IMR2_MR46                              \ CPU interrupt mask on direct event input i
$00008000 constant EXTI_EXTI_IMR2_MR47                              \ CPU interrupt mask on direct event input i
$00010000 constant EXTI_EXTI_IMR2_MR48                              \ CPU interrupt mask on direct event input i
$00020000 constant EXTI_EXTI_IMR2_MR49                              \ CPU interrupt mask on direct event input i
$00040000 constant EXTI_EXTI_IMR2_MR50                              \ CPU interrupt mask on direct event input i
$00080000 constant EXTI_EXTI_IMR2_MR51                              \ CPU interrupt mask on direct event input i
$00100000 constant EXTI_EXTI_IMR2_MR52                              \ CPU interrupt mask on direct event input i
$00200000 constant EXTI_EXTI_IMR2_MR53                              \ CPU interrupt mask on direct event input i
$00400000 constant EXTI_EXTI_IMR2_MR54                              \ CPU interrupt mask on direct event input i
$00800000 constant EXTI_EXTI_IMR2_MR55                              \ CPU interrupt mask on direct event input i
$01000000 constant EXTI_EXTI_IMR2_MR56                              \ CPU interrupt mask on direct event input i
$02000000 constant EXTI_EXTI_IMR2_MR57                              \ CPU interrupt mask on direct event input i
$04000000 constant EXTI_EXTI_IMR2_MR58                              \ CPU interrupt mask on direct event input i
$08000000 constant EXTI_EXTI_IMR2_MR59                              \ CPU interrupt mask on direct event input i


\
\ @brief EXTI event mask register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant EXTI_EXTI_EMR2_MR32                              \ CPU event mask on event input i
$00000002 constant EXTI_EXTI_EMR2_MR33                              \ CPU event mask on event input i
$00000004 constant EXTI_EXTI_EMR2_MR34                              \ CPU event mask on event input i
$00000008 constant EXTI_EXTI_EMR2_MR35                              \ CPU event mask on event input i
$00000010 constant EXTI_EXTI_EMR2_MR36                              \ CPU event mask on event input i
$00000020 constant EXTI_EXTI_EMR2_MR37                              \ CPU event mask on event input i
$00000040 constant EXTI_EXTI_EMR2_MR38                              \ CPU event mask on event input i
$00000080 constant EXTI_EXTI_EMR2_MR39                              \ CPU event mask on event input i
$00000100 constant EXTI_EXTI_EMR2_MR40                              \ CPU event mask on event input i
$00000200 constant EXTI_EXTI_EMR2_MR41                              \ CPU event mask on event input i
$00000400 constant EXTI_EXTI_EMR2_MR42                              \ CPU event mask on event input i
$00000800 constant EXTI_EXTI_EMR2_MR43                              \ CPU event mask on event input i
$00001000 constant EXTI_EXTI_EMR2_MR44                              \ CPU event mask on event input i
$00002000 constant EXTI_EXTI_EMR2_MR45                              \ CPU event mask on event input i
$00004000 constant EXTI_EXTI_EMR2_MR46                              \ CPU event mask on event input i
$00008000 constant EXTI_EXTI_EMR2_MR47                              \ CPU event mask on event input i
$00010000 constant EXTI_EXTI_EMR2_MR48                              \ CPU event mask on event input i
$00020000 constant EXTI_EXTI_EMR2_MR49                              \ CPU event mask on event input i
$00040000 constant EXTI_EXTI_EMR2_MR50                              \ CPU event mask on event input i
$00080000 constant EXTI_EXTI_EMR2_MR51                              \ CPU event mask on event input i
$00100000 constant EXTI_EXTI_EMR2_MR52                              \ CPU event mask on event input i
$00200000 constant EXTI_EXTI_EMR2_MR53                              \ CPU event mask on event input i
$00400000 constant EXTI_EXTI_EMR2_MR54                              \ CPU event mask on event input i
$00800000 constant EXTI_EXTI_EMR2_MR55                              \ CPU event mask on event input i
$01000000 constant EXTI_EXTI_EMR2_MR56                              \ CPU event mask on event input i
$02000000 constant EXTI_EXTI_EMR2_MR57                              \ CPU event mask on event input i
$04000000 constant EXTI_EXTI_EMR2_MR58                              \ CPU event mask on event input i
$08000000 constant EXTI_EXTI_EMR2_MR59                              \ CPU event mask on event input i


\
\ @brief EXTI pending register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000004 constant EXTI_EXTI_PR2_PR34                               \ Configurable event inputs x+32 Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00004000 constant EXTI_EXTI_PR2_PR46                               \ Configurable event inputs x+32 Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00020000 constant EXTI_EXTI_PR2_PR49                               \ Configurable event inputs x+32 Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00080000 constant EXTI_EXTI_PR2_PR51                               \ Configurable event inputs x+32 Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.
$00400000 constant EXTI_EXTI_PR2_PR54                               \ Configurable event inputs x+32 Pending bit This bit is set when the selected edge event arrives on the external interrupt line. This bit is cleared by writing a 1 into the bit or by changing the sensitivity of the edge detector.


\
\ @brief EXTI interrupt mask register
\ Address offset: 0x30
\ Reset value: 0x0F8BFFFF
\

$00002000 constant EXTI_EXTI_IMR3_MR77                              \ CPU interrupt mask on direct event input x+64


\
\ @brief EXTI event mask register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00002000 constant EXTI_EXTI_EMR3_MR77                              \ CPU event mask on event input x+64


\
\ @brief Extended interrupt and event controller
\
$58000000 constant EXTI_EXTI_RTSR1  \ offset: 0x00 : EXTI rising trigger selection register
$58000004 constant EXTI_EXTI_FTSR1  \ offset: 0x04 : EXTI falling trigger selection register
$58000008 constant EXTI_EXTI_SWIER1  \ offset: 0x08 : EXTI software interrupt event register
$5800000c constant EXTI_EXTI_RTSR2  \ offset: 0x0C : EXTI rising trigger selection register
$58000010 constant EXTI_EXTI_FTSR2  \ offset: 0x10 : EXTI falling trigger selection register
$58000014 constant EXTI_EXTI_SWIER2  \ offset: 0x14 : EXTI software interrupt event register
$58000018 constant EXTI_EXTI_IMR1  \ offset: 0x18 : EXTI interrupt mask register
$5800001c constant EXTI_EXTI_EMR1  \ offset: 0x1C : EXTI event mask register
$58000020 constant EXTI_EXTI_PR1  \ offset: 0x20 : EXTI pending register
$58000024 constant EXTI_EXTI_IMR2  \ offset: 0x24 : EXTI interrupt mask register
$58000028 constant EXTI_EXTI_EMR2  \ offset: 0x28 : EXTI event mask register
$5800002c constant EXTI_EXTI_PR2  \ offset: 0x2C : EXTI pending register
$58000030 constant EXTI_EXTI_IMR3  \ offset: 0x30 : EXTI interrupt mask register
$58000034 constant EXTI_EXTI_EMR3  \ offset: 0x34 : EXTI event mask register

