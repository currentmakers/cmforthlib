\
\ @file tsc.fs
\ @brief Touch sensing controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TSC_CR_TSCE                                      \ Touch sensing controller enable
$00000002 constant TSC_CR_START                                     \ Start a new acquisition
$00000004 constant TSC_CR_AM                                        \ Acquisition mode
$00000008 constant TSC_CR_SYNCPOL                                   \ Synchronization pin polarity
$00000010 constant TSC_CR_IODEF                                     \ I/O Default mode
$000000e0 constant TSC_CR_MCV                                       \ Max count value
$00007000 constant TSC_CR_PGPSC                                     \ pulse generator prescaler
$00008000 constant TSC_CR_SSPSC                                     \ Spread spectrum prescaler
$00010000 constant TSC_CR_SSE                                       \ Spread spectrum enable
$00fe0000 constant TSC_CR_SSD                                       \ Spread spectrum deviation
$0f000000 constant TSC_CR_CTPL                                      \ Charge transfer pulse low
$f0000000 constant TSC_CR_CTPH                                      \ Charge transfer pulse high


\
\ @brief interrupt enable register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TSC_IER_EOAIE                                    \ End of acquisition interrupt enable
$00000002 constant TSC_IER_MCEIE                                    \ Max count error interrupt enable


\
\ @brief interrupt clear register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant TSC_ICR_EOAIC                                    \ End of acquisition interrupt clear
$00000002 constant TSC_ICR_MCEIC                                    \ Max count error interrupt clear


\
\ @brief interrupt status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TSC_ISR_EOAF                                     \ End of acquisition flag
$00000002 constant TSC_ISR_MCEF                                     \ Max count error flag


\
\ @brief I/O hysteresis control register
\ Address offset: 0x10
\ Reset value: 0xFFFFFFFF
\

$00000001 constant TSC_IOHCR_G1_IO1                                 \ G1_IO1
$00000002 constant TSC_IOHCR_G1_IO2                                 \ G1_IO2
$00000004 constant TSC_IOHCR_G1_IO3                                 \ G1_IO3
$00000008 constant TSC_IOHCR_G1_IO4                                 \ G1_IO4
$00000010 constant TSC_IOHCR_G2_IO1                                 \ G2_IO1
$00000020 constant TSC_IOHCR_G2_IO2                                 \ G2_IO2
$00000040 constant TSC_IOHCR_G2_IO3                                 \ G2_IO3
$00000080 constant TSC_IOHCR_G2_IO4                                 \ G2_IO4
$00000100 constant TSC_IOHCR_G3_IO1                                 \ G3_IO1
$00000200 constant TSC_IOHCR_G3_IO2                                 \ G3_IO2
$00000400 constant TSC_IOHCR_G3_IO3                                 \ G3_IO3
$00000800 constant TSC_IOHCR_G3_IO4                                 \ G3_IO4
$00001000 constant TSC_IOHCR_G4_IO1                                 \ G4_IO1
$00002000 constant TSC_IOHCR_G4_IO2                                 \ G4_IO2
$00004000 constant TSC_IOHCR_G4_IO3                                 \ G4_IO3
$00008000 constant TSC_IOHCR_G4_IO4                                 \ G4_IO4
$00010000 constant TSC_IOHCR_G5_IO1                                 \ G5_IO1
$00020000 constant TSC_IOHCR_G5_IO2                                 \ G5_IO2
$00040000 constant TSC_IOHCR_G5_IO3                                 \ G5_IO3
$00080000 constant TSC_IOHCR_G5_IO4                                 \ G5_IO4
$00100000 constant TSC_IOHCR_G6_IO1                                 \ G6_IO1
$00200000 constant TSC_IOHCR_G6_IO2                                 \ G6_IO2
$00400000 constant TSC_IOHCR_G6_IO3                                 \ G6_IO3
$00800000 constant TSC_IOHCR_G6_IO4                                 \ G6_IO4
$01000000 constant TSC_IOHCR_G7_IO1                                 \ G7_IO1
$02000000 constant TSC_IOHCR_G7_IO2                                 \ G7_IO2
$04000000 constant TSC_IOHCR_G7_IO3                                 \ G7_IO3
$08000000 constant TSC_IOHCR_G7_IO4                                 \ G7_IO4


\
\ @brief I/O analog switch control register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant TSC_IOASCR_G1_IO1                                \ G1_IO1
$00000002 constant TSC_IOASCR_G1_IO2                                \ G1_IO2
$00000004 constant TSC_IOASCR_G1_IO3                                \ G1_IO3
$00000008 constant TSC_IOASCR_G1_IO4                                \ G1_IO4
$00000010 constant TSC_IOASCR_G2_IO1                                \ G2_IO1
$00000020 constant TSC_IOASCR_G2_IO2                                \ G2_IO2
$00000040 constant TSC_IOASCR_G2_IO3                                \ G2_IO3
$00000080 constant TSC_IOASCR_G2_IO4                                \ G2_IO4
$00000100 constant TSC_IOASCR_G3_IO1                                \ G3_IO1
$00000200 constant TSC_IOASCR_G3_IO2                                \ G3_IO2
$00000400 constant TSC_IOASCR_G3_IO3                                \ G3_IO3
$00000800 constant TSC_IOASCR_G3_IO4                                \ G3_IO4
$00001000 constant TSC_IOASCR_G4_IO1                                \ G4_IO1
$00002000 constant TSC_IOASCR_G4_IO2                                \ G4_IO2
$00004000 constant TSC_IOASCR_G4_IO3                                \ G4_IO3
$00008000 constant TSC_IOASCR_G4_IO4                                \ G4_IO4
$00010000 constant TSC_IOASCR_G5_IO1                                \ G5_IO1
$00020000 constant TSC_IOASCR_G5_IO2                                \ G5_IO2
$00040000 constant TSC_IOASCR_G5_IO3                                \ G5_IO3
$00080000 constant TSC_IOASCR_G5_IO4                                \ G5_IO4
$00100000 constant TSC_IOASCR_G6_IO1                                \ G6_IO1
$00200000 constant TSC_IOASCR_G6_IO2                                \ G6_IO2
$00400000 constant TSC_IOASCR_G6_IO3                                \ G6_IO3
$00800000 constant TSC_IOASCR_G6_IO4                                \ G6_IO4
$01000000 constant TSC_IOASCR_G7_IO1                                \ G7_IO1
$02000000 constant TSC_IOASCR_G7_IO2                                \ G7_IO2
$04000000 constant TSC_IOASCR_G7_IO3                                \ G7_IO3
$08000000 constant TSC_IOASCR_G7_IO4                                \ G7_IO4


\
\ @brief I/O sampling control register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TSC_IOSCR_G1_IO1                                 \ G1_IO1
$00000002 constant TSC_IOSCR_G1_IO2                                 \ G1_IO2
$00000004 constant TSC_IOSCR_G1_IO3                                 \ G1_IO3
$00000008 constant TSC_IOSCR_G1_IO4                                 \ G1_IO4
$00000010 constant TSC_IOSCR_G2_IO1                                 \ G2_IO1
$00000020 constant TSC_IOSCR_G2_IO2                                 \ G2_IO2
$00000040 constant TSC_IOSCR_G2_IO3                                 \ G2_IO3
$00000080 constant TSC_IOSCR_G2_IO4                                 \ G2_IO4
$00000100 constant TSC_IOSCR_G3_IO1                                 \ G3_IO1
$00000200 constant TSC_IOSCR_G3_IO2                                 \ G3_IO2
$00000400 constant TSC_IOSCR_G3_IO3                                 \ G3_IO3
$00000800 constant TSC_IOSCR_G3_IO4                                 \ G3_IO4
$00001000 constant TSC_IOSCR_G4_IO1                                 \ G4_IO1
$00002000 constant TSC_IOSCR_G4_IO2                                 \ G4_IO2
$00004000 constant TSC_IOSCR_G4_IO3                                 \ G4_IO3
$00008000 constant TSC_IOSCR_G4_IO4                                 \ G4_IO4
$00010000 constant TSC_IOSCR_G5_IO1                                 \ G5_IO1
$00020000 constant TSC_IOSCR_G5_IO2                                 \ G5_IO2
$00040000 constant TSC_IOSCR_G5_IO3                                 \ G5_IO3
$00080000 constant TSC_IOSCR_G5_IO4                                 \ G5_IO4
$00100000 constant TSC_IOSCR_G6_IO1                                 \ G6_IO1
$00200000 constant TSC_IOSCR_G6_IO2                                 \ G6_IO2
$00400000 constant TSC_IOSCR_G6_IO3                                 \ G6_IO3
$00800000 constant TSC_IOSCR_G6_IO4                                 \ G6_IO4
$01000000 constant TSC_IOSCR_G7_IO1                                 \ G7_IO1
$02000000 constant TSC_IOSCR_G7_IO2                                 \ G7_IO2
$04000000 constant TSC_IOSCR_G7_IO3                                 \ G7_IO3
$08000000 constant TSC_IOSCR_G7_IO4                                 \ G7_IO4


\
\ @brief I/O channel control register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant TSC_IOCCR_G1_IO1                                 \ G1_IO1
$00000002 constant TSC_IOCCR_G1_IO2                                 \ G1_IO2
$00000004 constant TSC_IOCCR_G1_IO3                                 \ G1_IO3
$00000008 constant TSC_IOCCR_G1_IO4                                 \ G1_IO4
$00000010 constant TSC_IOCCR_G2_IO1                                 \ G2_IO1
$00000020 constant TSC_IOCCR_G2_IO2                                 \ G2_IO2
$00000040 constant TSC_IOCCR_G2_IO3                                 \ G2_IO3
$00000080 constant TSC_IOCCR_G2_IO4                                 \ G2_IO4
$00000100 constant TSC_IOCCR_G3_IO1                                 \ G3_IO1
$00000200 constant TSC_IOCCR_G3_IO2                                 \ G3_IO2
$00000400 constant TSC_IOCCR_G3_IO3                                 \ G3_IO3
$00000800 constant TSC_IOCCR_G3_IO4                                 \ G3_IO4
$00001000 constant TSC_IOCCR_G4_IO1                                 \ G4_IO1
$00002000 constant TSC_IOCCR_G4_IO2                                 \ G4_IO2
$00004000 constant TSC_IOCCR_G4_IO3                                 \ G4_IO3
$00008000 constant TSC_IOCCR_G4_IO4                                 \ G4_IO4
$00010000 constant TSC_IOCCR_G5_IO1                                 \ G5_IO1
$00020000 constant TSC_IOCCR_G5_IO2                                 \ G5_IO2
$00040000 constant TSC_IOCCR_G5_IO3                                 \ G5_IO3
$00080000 constant TSC_IOCCR_G5_IO4                                 \ G5_IO4
$00100000 constant TSC_IOCCR_G6_IO1                                 \ G6_IO1
$00200000 constant TSC_IOCCR_G6_IO2                                 \ G6_IO2
$00400000 constant TSC_IOCCR_G6_IO3                                 \ G6_IO3
$00800000 constant TSC_IOCCR_G6_IO4                                 \ G6_IO4
$01000000 constant TSC_IOCCR_G7_IO1                                 \ G7_IO1
$02000000 constant TSC_IOCCR_G7_IO2                                 \ G7_IO2
$04000000 constant TSC_IOCCR_G7_IO3                                 \ G7_IO3
$08000000 constant TSC_IOCCR_G7_IO4                                 \ G7_IO4


\
\ @brief I/O group control status register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant TSC_IOGCSR_G1E                                   \ Analog I/O group x enable
$00000002 constant TSC_IOGCSR_G2E                                   \ Analog I/O group x enable
$00000004 constant TSC_IOGCSR_G3E                                   \ Analog I/O group x enable
$00000008 constant TSC_IOGCSR_G4E                                   \ Analog I/O group x enable
$00000010 constant TSC_IOGCSR_G5E                                   \ Analog I/O group x enable
$00000020 constant TSC_IOGCSR_G6E                                   \ Analog I/O group x enable
$00000040 constant TSC_IOGCSR_G7E                                   \ Analog I/O group x enable
$00010000 constant TSC_IOGCSR_G1S                                   \ Analog I/O group x status
$00020000 constant TSC_IOGCSR_G2S                                   \ Analog I/O group x status
$00040000 constant TSC_IOGCSR_G3S                                   \ Analog I/O group x status
$00080000 constant TSC_IOGCSR_G4S                                   \ Analog I/O group x status
$00100000 constant TSC_IOGCSR_G5S                                   \ Analog I/O group x status
$00200000 constant TSC_IOGCSR_G6S                                   \ Analog I/O group x status
$00400000 constant TSC_IOGCSR_G7S                                   \ Analog I/O group x status


\
\ @brief I/O group x counter register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00003fff constant TSC_IOG1CR_CNT                                   \ Counter value


\
\ @brief I/O group x counter register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00003fff constant TSC_IOG2CR_CNT                                   \ Counter value


\
\ @brief I/O group x counter register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00003fff constant TSC_IOG3CR_CNT                                   \ Counter value


\
\ @brief I/O group x counter register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00003fff constant TSC_IOG4CR_CNT                                   \ Counter value


\
\ @brief I/O group x counter register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00003fff constant TSC_IOG5CR_CNT                                   \ Counter value


\
\ @brief I/O group x counter register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00003fff constant TSC_IOG6CR_CNT                                   \ Counter value


\
\ @brief I/O group x counter register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00003fff constant TSC_IOG7CR_CNT                                   \ Counter value


\
\ @brief Touch sensing controller
\
$40024000 constant TSC_CR         \ offset: 0x00 : control register
$40024004 constant TSC_IER        \ offset: 0x04 : interrupt enable register
$40024008 constant TSC_ICR        \ offset: 0x08 : interrupt clear register
$4002400c constant TSC_ISR        \ offset: 0x0C : interrupt status register
$40024010 constant TSC_IOHCR      \ offset: 0x10 : I/O hysteresis control register
$40024018 constant TSC_IOASCR     \ offset: 0x18 : I/O analog switch control register
$40024020 constant TSC_IOSCR      \ offset: 0x20 : I/O sampling control register
$40024028 constant TSC_IOCCR      \ offset: 0x28 : I/O channel control register
$40024030 constant TSC_IOGCSR     \ offset: 0x30 : I/O group control status register
$40024034 constant TSC_IOG1CR     \ offset: 0x34 : I/O group x counter register
$40024038 constant TSC_IOG2CR     \ offset: 0x38 : I/O group x counter register
$4002403c constant TSC_IOG3CR     \ offset: 0x3C : I/O group x counter register
$40024040 constant TSC_IOG4CR     \ offset: 0x40 : I/O group x counter register
$40024044 constant TSC_IOG5CR     \ offset: 0x44 : I/O group x counter register
$40024048 constant TSC_IOG6CR     \ offset: 0x48 : I/O group x counter register
$4002404c constant TSC_IOG7CR     \ offset: 0x4C : I/O group x counter register

