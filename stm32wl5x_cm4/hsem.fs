\
\ @file hsem.fs
\ @brief Hardware semaphore
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief HSEM register HSEM_R0 HSEM_R31
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R0_PROCID                              \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_R0_COREID                              \ COREID
$80000000 constant HSEM_HSEM_R0_LOCK                                \ Lock indication


\
\ @brief HSEM register HSEM_R0 HSEM_R31
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R1_PROCID                              \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_R1_COREID                              \ COREID
$80000000 constant HSEM_HSEM_R1_LOCK                                \ Lock indication


\
\ @brief HSEM register HSEM_R0 HSEM_R31
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R2_PROCID                              \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_R2_COREID                              \ COREID
$80000000 constant HSEM_HSEM_R2_LOCK                                \ Lock indication


\
\ @brief HSEM register HSEM_R0 HSEM_R31
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R3_PROCID                              \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_R3_COREID                              \ COREID
$80000000 constant HSEM_HSEM_R3_LOCK                                \ Lock indication


\
\ @brief HSEM register HSEM_R0 HSEM_R31
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R4_PROCID                              \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_R4_COREID                              \ COREID
$80000000 constant HSEM_HSEM_R4_LOCK                                \ Lock indication


\
\ @brief HSEM register HSEM_R0 HSEM_R31
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R5_PROCID                              \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_R5_COREID                              \ COREID
$80000000 constant HSEM_HSEM_R5_LOCK                                \ Lock indication


\
\ @brief HSEM register HSEM_R0 HSEM_R31
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R6_PROCID                              \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_R6_COREID                              \ COREID
$80000000 constant HSEM_HSEM_R6_LOCK                                \ Lock indication


\
\ @brief HSEM register HSEM_R0 HSEM_R31
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R7_PROCID                              \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_R7_COREID                              \ COREID
$80000000 constant HSEM_HSEM_R7_LOCK                                \ Lock indication


\
\ @brief HSEM register HSEM_R0 HSEM_R31
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R8_PROCID                              \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_R8_COREID                              \ COREID
$80000000 constant HSEM_HSEM_R8_LOCK                                \ Lock indication


\
\ @brief HSEM register HSEM_R0 HSEM_R31
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R9_PROCID                              \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_R9_COREID                              \ COREID
$80000000 constant HSEM_HSEM_R9_LOCK                                \ Lock indication


\
\ @brief HSEM register HSEM_R0 HSEM_R31
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R10_PROCID                             \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_R10_COREID                             \ COREID
$80000000 constant HSEM_HSEM_R10_LOCK                               \ Lock indication


\
\ @brief HSEM register HSEM_R0 HSEM_R31
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R11_PROCID                             \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_R11_COREID                             \ COREID
$80000000 constant HSEM_HSEM_R11_LOCK                               \ Lock indication


\
\ @brief HSEM register HSEM_R0 HSEM_R31
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R12_PROCID                             \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_R12_COREID                             \ COREID
$80000000 constant HSEM_HSEM_R12_LOCK                               \ Lock indication


\
\ @brief HSEM register HSEM_R0 HSEM_R31
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R13_PROCID                             \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_R13_COREID                             \ COREID
$80000000 constant HSEM_HSEM_R13_LOCK                               \ Lock indication


\
\ @brief HSEM register HSEM_R0 HSEM_R31
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R14_PROCID                             \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_R14_COREID                             \ COREID
$80000000 constant HSEM_HSEM_R14_LOCK                               \ Lock indication


\
\ @brief HSEM register HSEM_R0 HSEM_R31
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R15_PROCID                             \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_R15_COREID                             \ COREID
$80000000 constant HSEM_HSEM_R15_LOCK                               \ Lock indication


\
\ @brief HSEM Read lock register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR0_PROCID                            \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_RLR0_COREID                            \ COREID
$80000000 constant HSEM_HSEM_RLR0_LOCK                              \ Lock indication


\
\ @brief HSEM Read lock register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR1_PROCID                            \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_RLR1_COREID                            \ COREID
$80000000 constant HSEM_HSEM_RLR1_LOCK                              \ Lock indication


\
\ @brief HSEM Read lock register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR2_PROCID                            \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_RLR2_COREID                            \ COREID
$80000000 constant HSEM_HSEM_RLR2_LOCK                              \ Lock indication


\
\ @brief HSEM Read lock register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR3_PROCID                            \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_RLR3_COREID                            \ COREID
$80000000 constant HSEM_HSEM_RLR3_LOCK                              \ Lock indication


\
\ @brief HSEM Read lock register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR4_PROCID                            \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_RLR4_COREID                            \ COREID
$80000000 constant HSEM_HSEM_RLR4_LOCK                              \ Lock indication


\
\ @brief HSEM Read lock register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR5_PROCID                            \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_RLR5_COREID                            \ COREID
$80000000 constant HSEM_HSEM_RLR5_LOCK                              \ Lock indication


\
\ @brief HSEM Read lock register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR6_PROCID                            \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_RLR6_COREID                            \ COREID
$80000000 constant HSEM_HSEM_RLR6_LOCK                              \ Lock indication


\
\ @brief HSEM Read lock register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR7_PROCID                            \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_RLR7_COREID                            \ COREID
$80000000 constant HSEM_HSEM_RLR7_LOCK                              \ Lock indication


\
\ @brief HSEM Read lock register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR8_PROCID                            \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_RLR8_COREID                            \ COREID
$80000000 constant HSEM_HSEM_RLR8_LOCK                              \ Lock indication


\
\ @brief HSEM Read lock register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR9_PROCID                            \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_RLR9_COREID                            \ COREID
$80000000 constant HSEM_HSEM_RLR9_LOCK                              \ Lock indication


\
\ @brief HSEM Read lock register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR10_PROCID                           \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_RLR10_COREID                           \ COREID
$80000000 constant HSEM_HSEM_RLR10_LOCK                             \ Lock indication


\
\ @brief HSEM Read lock register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR11_PROCID                           \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_RLR11_COREID                           \ COREID
$80000000 constant HSEM_HSEM_RLR11_LOCK                             \ Lock indication


\
\ @brief HSEM Read lock register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR12_PROCID                           \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_RLR12_COREID                           \ COREID
$80000000 constant HSEM_HSEM_RLR12_LOCK                             \ Lock indication


\
\ @brief HSEM Read lock register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR13_PROCID                           \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_RLR13_COREID                           \ COREID
$80000000 constant HSEM_HSEM_RLR13_LOCK                             \ Lock indication


\
\ @brief HSEM Read lock register
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR14_PROCID                           \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_RLR14_COREID                           \ COREID
$80000000 constant HSEM_HSEM_RLR14_LOCK                             \ Lock indication


\
\ @brief HSEM Read lock register
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR15_PROCID                           \ Semaphore ProcessID
$00000f00 constant HSEM_HSEM_RLR15_COREID                           \ COREID
$80000000 constant HSEM_HSEM_RLR15_LOCK                             \ Lock indication


\
\ @brief HSEM Interrupt enable register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant HSEM_HSEM_C1IER_ISE0                             \ Interrupt semaphore n enable bit
$00000002 constant HSEM_HSEM_C1IER_ISE1                             \ Interrupt semaphore n enable bit
$00000004 constant HSEM_HSEM_C1IER_ISE2                             \ Interrupt semaphore n enable bit
$00000008 constant HSEM_HSEM_C1IER_ISE3                             \ Interrupt semaphore n enable bit
$00000010 constant HSEM_HSEM_C1IER_ISE4                             \ Interrupt semaphore n enable bit
$00000020 constant HSEM_HSEM_C1IER_ISE5                             \ Interrupt semaphore n enable bit
$00000040 constant HSEM_HSEM_C1IER_ISE6                             \ Interrupt semaphore n enable bit
$00000080 constant HSEM_HSEM_C1IER_ISE7                             \ Interrupt semaphore n enable bit
$00000100 constant HSEM_HSEM_C1IER_ISE8                             \ Interrupt semaphore n enable bit
$00000200 constant HSEM_HSEM_C1IER_ISE9                             \ Interrupt semaphore n enable bit
$00000400 constant HSEM_HSEM_C1IER_ISE10                            \ Interrupt semaphore n enable bit
$00000800 constant HSEM_HSEM_C1IER_ISE11                            \ Interrupt semaphore n enable bit
$00001000 constant HSEM_HSEM_C1IER_ISE12                            \ Interrupt semaphore n enable bit
$00002000 constant HSEM_HSEM_C1IER_ISE13                            \ Interrupt semaphore n enable bit
$00004000 constant HSEM_HSEM_C1IER_ISE14                            \ Interrupt semaphore n enable bit
$00008000 constant HSEM_HSEM_C1IER_ISE15                            \ Interrupt semaphore n enable bit


\
\ @brief HSEM Interrupt clear register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant HSEM_HSEM_C1ICR_ISC0                             \ Interrupt(N) semaphore n clear bit
$00000002 constant HSEM_HSEM_C1ICR_ISC1                             \ Interrupt(N) semaphore n clear bit
$00000004 constant HSEM_HSEM_C1ICR_ISC2                             \ Interrupt(N) semaphore n clear bit
$00000008 constant HSEM_HSEM_C1ICR_ISC3                             \ Interrupt(N) semaphore n clear bit
$00000010 constant HSEM_HSEM_C1ICR_ISC4                             \ Interrupt(N) semaphore n clear bit
$00000020 constant HSEM_HSEM_C1ICR_ISC5                             \ Interrupt(N) semaphore n clear bit
$00000040 constant HSEM_HSEM_C1ICR_ISC6                             \ Interrupt(N) semaphore n clear bit
$00000080 constant HSEM_HSEM_C1ICR_ISC7                             \ Interrupt(N) semaphore n clear bit
$00000100 constant HSEM_HSEM_C1ICR_ISC8                             \ Interrupt(N) semaphore n clear bit
$00000200 constant HSEM_HSEM_C1ICR_ISC9                             \ Interrupt(N) semaphore n clear bit
$00000400 constant HSEM_HSEM_C1ICR_ISC10                            \ Interrupt(N) semaphore n clear bit
$00000800 constant HSEM_HSEM_C1ICR_ISC11                            \ Interrupt(N) semaphore n clear bit
$00001000 constant HSEM_HSEM_C1ICR_ISC12                            \ Interrupt(N) semaphore n clear bit
$00002000 constant HSEM_HSEM_C1ICR_ISC13                            \ Interrupt(N) semaphore n clear bit
$00004000 constant HSEM_HSEM_C1ICR_ISC14                            \ Interrupt(N) semaphore n clear bit
$00008000 constant HSEM_HSEM_C1ICR_ISC15                            \ Interrupt(N) semaphore n clear bit


\
\ @brief HSEM Interrupt status register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant HSEM_HSEM_C1ISR_ISF0                             \ Interrupt(N) semaphore n status bit before enable (mask)
$00000002 constant HSEM_HSEM_C1ISR_ISF1                             \ Interrupt(N) semaphore n status bit before enable (mask)
$00000004 constant HSEM_HSEM_C1ISR_ISF2                             \ Interrupt(N) semaphore n status bit before enable (mask)
$00000008 constant HSEM_HSEM_C1ISR_ISF3                             \ Interrupt(N) semaphore n status bit before enable (mask)
$00000010 constant HSEM_HSEM_C1ISR_ISF4                             \ Interrupt(N) semaphore n status bit before enable (mask)
$00000020 constant HSEM_HSEM_C1ISR_ISF5                             \ Interrupt(N) semaphore n status bit before enable (mask)
$00000040 constant HSEM_HSEM_C1ISR_ISF6                             \ Interrupt(N) semaphore n status bit before enable (mask)
$00000080 constant HSEM_HSEM_C1ISR_ISF7                             \ Interrupt(N) semaphore n status bit before enable (mask)
$00000100 constant HSEM_HSEM_C1ISR_ISF8                             \ Interrupt(N) semaphore n status bit before enable (mask)
$00000200 constant HSEM_HSEM_C1ISR_ISF9                             \ Interrupt(N) semaphore n status bit before enable (mask)
$00000400 constant HSEM_HSEM_C1ISR_ISF10                            \ Interrupt(N) semaphore n status bit before enable (mask)
$00000800 constant HSEM_HSEM_C1ISR_ISF11                            \ Interrupt(N) semaphore n status bit before enable (mask)
$00001000 constant HSEM_HSEM_C1ISR_ISF12                            \ Interrupt(N) semaphore n status bit before enable (mask)
$00002000 constant HSEM_HSEM_C1ISR_ISF13                            \ Interrupt(N) semaphore n status bit before enable (mask)
$00004000 constant HSEM_HSEM_C1ISR_ISF14                            \ Interrupt(N) semaphore n status bit before enable (mask)
$00008000 constant HSEM_HSEM_C1ISR_ISF15                            \ Interrupt(N) semaphore n status bit before enable (mask)


\
\ @brief HSEM Masked interrupt status register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000001 constant HSEM_HSEM_C1MISR_MISF0                           \ masked interrupt(N) semaphore n status bit after enable (mask)
$00000002 constant HSEM_HSEM_C1MISR_MISF1                           \ masked interrupt(N) semaphore n status bit after enable (mask)
$00000004 constant HSEM_HSEM_C1MISR_MISF2                           \ masked interrupt(N) semaphore n status bit after enable (mask)
$00000008 constant HSEM_HSEM_C1MISR_MISF3                           \ masked interrupt(N) semaphore n status bit after enable (mask)
$00000010 constant HSEM_HSEM_C1MISR_MISF4                           \ masked interrupt(N) semaphore n status bit after enable (mask)
$00000020 constant HSEM_HSEM_C1MISR_MISF5                           \ masked interrupt(N) semaphore n status bit after enable (mask)
$00000040 constant HSEM_HSEM_C1MISR_MISF6                           \ masked interrupt(N) semaphore n status bit after enable (mask)
$00000080 constant HSEM_HSEM_C1MISR_MISF7                           \ masked interrupt(N) semaphore n status bit after enable (mask)
$00000100 constant HSEM_HSEM_C1MISR_MISF8                           \ masked interrupt(N) semaphore n status bit after enable (mask)
$00000200 constant HSEM_HSEM_C1MISR_MISF9                           \ masked interrupt(N) semaphore n status bit after enable (mask)
$00000400 constant HSEM_HSEM_C1MISR_MISF10                          \ masked interrupt(N) semaphore n status bit after enable (mask)
$00000800 constant HSEM_HSEM_C1MISR_MISF11                          \ masked interrupt(N) semaphore n status bit after enable (mask)
$00001000 constant HSEM_HSEM_C1MISR_MISF12                          \ masked interrupt(N) semaphore n status bit after enable (mask)
$00002000 constant HSEM_HSEM_C1MISR_MISF13                          \ masked interrupt(N) semaphore n status bit after enable (mask)
$00004000 constant HSEM_HSEM_C1MISR_MISF14                          \ masked interrupt(N) semaphore n status bit after enable (mask)
$00008000 constant HSEM_HSEM_C1MISR_MISF15                          \ masked interrupt(N) semaphore n status bit after enable (mask)


\
\ @brief HSEM Interrupt enable register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000001 constant HSEM_HSEM_C2IER_ISE0                             \ Interrupt semaphore n enable bit
$00000002 constant HSEM_HSEM_C2IER_ISE1                             \ Interrupt semaphore n enable bit
$00000004 constant HSEM_HSEM_C2IER_ISE2                             \ Interrupt semaphore n enable bit
$00000008 constant HSEM_HSEM_C2IER_ISE3                             \ Interrupt semaphore n enable bit
$00000010 constant HSEM_HSEM_C2IER_ISE4                             \ Interrupt semaphore n enable bit
$00000020 constant HSEM_HSEM_C2IER_ISE5                             \ Interrupt semaphore n enable bit
$00000040 constant HSEM_HSEM_C2IER_ISE6                             \ Interrupt semaphore n enable bit
$00000080 constant HSEM_HSEM_C2IER_ISE7                             \ Interrupt semaphore n enable bit
$00000100 constant HSEM_HSEM_C2IER_ISE8                             \ Interrupt semaphore n enable bit
$00000200 constant HSEM_HSEM_C2IER_ISE9                             \ Interrupt semaphore n enable bit
$00000400 constant HSEM_HSEM_C2IER_ISE10                            \ Interrupt semaphore n enable bit
$00000800 constant HSEM_HSEM_C2IER_ISE11                            \ Interrupt semaphore n enable bit
$00001000 constant HSEM_HSEM_C2IER_ISE12                            \ Interrupt semaphore n enable bit
$00002000 constant HSEM_HSEM_C2IER_ISE13                            \ Interrupt semaphore n enable bit
$00004000 constant HSEM_HSEM_C2IER_ISE14                            \ Interrupt semaphore n enable bit
$00008000 constant HSEM_HSEM_C2IER_ISE15                            \ Interrupt semaphore n enable bit


\
\ @brief HSEM Interrupt clear register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000001 constant HSEM_HSEM_C2ICR_ISC0                             \ Interrupt(N) semaphore n clear bit
$00000002 constant HSEM_HSEM_C2ICR_ISC1                             \ Interrupt(N) semaphore n clear bit
$00000004 constant HSEM_HSEM_C2ICR_ISC2                             \ Interrupt(N) semaphore n clear bit
$00000008 constant HSEM_HSEM_C2ICR_ISC3                             \ Interrupt(N) semaphore n clear bit
$00000010 constant HSEM_HSEM_C2ICR_ISC4                             \ Interrupt(N) semaphore n clear bit
$00000020 constant HSEM_HSEM_C2ICR_ISC5                             \ Interrupt(N) semaphore n clear bit
$00000040 constant HSEM_HSEM_C2ICR_ISC6                             \ Interrupt(N) semaphore n clear bit
$00000080 constant HSEM_HSEM_C2ICR_ISC7                             \ Interrupt(N) semaphore n clear bit
$00000100 constant HSEM_HSEM_C2ICR_ISC8                             \ Interrupt(N) semaphore n clear bit
$00000200 constant HSEM_HSEM_C2ICR_ISC9                             \ Interrupt(N) semaphore n clear bit
$00000400 constant HSEM_HSEM_C2ICR_ISC10                            \ Interrupt(N) semaphore n clear bit
$00000800 constant HSEM_HSEM_C2ICR_ISC11                            \ Interrupt(N) semaphore n clear bit
$00001000 constant HSEM_HSEM_C2ICR_ISC12                            \ Interrupt(N) semaphore n clear bit
$00002000 constant HSEM_HSEM_C2ICR_ISC13                            \ Interrupt(N) semaphore n clear bit
$00004000 constant HSEM_HSEM_C2ICR_ISC14                            \ Interrupt(N) semaphore n clear bit
$00008000 constant HSEM_HSEM_C2ICR_ISC15                            \ Interrupt(N) semaphore n clear bit


\
\ @brief HSEM Interrupt status register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000001 constant HSEM_HSEM_C2ISR_ISF0                             \ Interrupt(N) semaphore n status bit before enable (mask)
$00000002 constant HSEM_HSEM_C2ISR_ISF1                             \ Interrupt(N) semaphore n status bit before enable (mask)
$00000004 constant HSEM_HSEM_C2ISR_ISF2                             \ Interrupt(N) semaphore n status bit before enable (mask)
$00000008 constant HSEM_HSEM_C2ISR_ISF3                             \ Interrupt(N) semaphore n status bit before enable (mask)
$00000010 constant HSEM_HSEM_C2ISR_ISF4                             \ Interrupt(N) semaphore n status bit before enable (mask)
$00000020 constant HSEM_HSEM_C2ISR_ISF5                             \ Interrupt(N) semaphore n status bit before enable (mask)
$00000040 constant HSEM_HSEM_C2ISR_ISF6                             \ Interrupt(N) semaphore n status bit before enable (mask)
$00000080 constant HSEM_HSEM_C2ISR_ISF7                             \ Interrupt(N) semaphore n status bit before enable (mask)
$00000100 constant HSEM_HSEM_C2ISR_ISF8                             \ Interrupt(N) semaphore n status bit before enable (mask)
$00000200 constant HSEM_HSEM_C2ISR_ISF9                             \ Interrupt(N) semaphore n status bit before enable (mask)
$00000400 constant HSEM_HSEM_C2ISR_ISF10                            \ Interrupt(N) semaphore n status bit before enable (mask)
$00000800 constant HSEM_HSEM_C2ISR_ISF11                            \ Interrupt(N) semaphore n status bit before enable (mask)
$00001000 constant HSEM_HSEM_C2ISR_ISF12                            \ Interrupt(N) semaphore n status bit before enable (mask)
$00002000 constant HSEM_HSEM_C2ISR_ISF13                            \ Interrupt(N) semaphore n status bit before enable (mask)
$00004000 constant HSEM_HSEM_C2ISR_ISF14                            \ Interrupt(N) semaphore n status bit before enable (mask)
$00008000 constant HSEM_HSEM_C2ISR_ISF15                            \ Interrupt(N) semaphore n status bit before enable (mask)


\
\ @brief HSEM Masked interrupt status register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000001 constant HSEM_HSEM_C2MISR_MISF0                           \ masked interrupt(N) semaphore n status bit after enable (mask)
$00000002 constant HSEM_HSEM_C2MISR_MISF1                           \ masked interrupt(N) semaphore n status bit after enable (mask)
$00000004 constant HSEM_HSEM_C2MISR_MISF2                           \ masked interrupt(N) semaphore n status bit after enable (mask)
$00000008 constant HSEM_HSEM_C2MISR_MISF3                           \ masked interrupt(N) semaphore n status bit after enable (mask)
$00000010 constant HSEM_HSEM_C2MISR_MISF4                           \ masked interrupt(N) semaphore n status bit after enable (mask)
$00000020 constant HSEM_HSEM_C2MISR_MISF5                           \ masked interrupt(N) semaphore n status bit after enable (mask)
$00000040 constant HSEM_HSEM_C2MISR_MISF6                           \ masked interrupt(N) semaphore n status bit after enable (mask)
$00000080 constant HSEM_HSEM_C2MISR_MISF7                           \ masked interrupt(N) semaphore n status bit after enable (mask)
$00000100 constant HSEM_HSEM_C2MISR_MISF8                           \ masked interrupt(N) semaphore n status bit after enable (mask)
$00000200 constant HSEM_HSEM_C2MISR_MISF9                           \ masked interrupt(N) semaphore n status bit after enable (mask)
$00000400 constant HSEM_HSEM_C2MISR_MISF10                          \ masked interrupt(N) semaphore n status bit after enable (mask)
$00000800 constant HSEM_HSEM_C2MISR_MISF11                          \ masked interrupt(N) semaphore n status bit after enable (mask)
$00001000 constant HSEM_HSEM_C2MISR_MISF12                          \ masked interrupt(N) semaphore n status bit after enable (mask)
$00002000 constant HSEM_HSEM_C2MISR_MISF13                          \ masked interrupt(N) semaphore n status bit after enable (mask)
$00004000 constant HSEM_HSEM_C2MISR_MISF14                          \ masked interrupt(N) semaphore n status bit after enable (mask)
$00008000 constant HSEM_HSEM_C2MISR_MISF15                          \ masked interrupt(N) semaphore n status bit after enable (mask)


\
\ @brief HSEM Clear register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000f00 constant HSEM_HSEM_CR_COREID                              \ COREID
$ffff0000 constant HSEM_HSEM_CR_KEY                                 \ Semaphore clear Key


\
\ @brief HSEM Interrupt clear register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$ffff0000 constant HSEM_HSEM_KEYR_KEY                               \ Semaphore Clear Key


\
\ @brief Hardware semaphore
\
$58001400 constant HSEM_HSEM_R0   \ offset: 0x00 : HSEM register HSEM_R0 HSEM_R31
$58001404 constant HSEM_HSEM_R1   \ offset: 0x04 : HSEM register HSEM_R0 HSEM_R31
$58001408 constant HSEM_HSEM_R2   \ offset: 0x08 : HSEM register HSEM_R0 HSEM_R31
$5800140c constant HSEM_HSEM_R3   \ offset: 0x0C : HSEM register HSEM_R0 HSEM_R31
$58001410 constant HSEM_HSEM_R4   \ offset: 0x10 : HSEM register HSEM_R0 HSEM_R31
$58001414 constant HSEM_HSEM_R5   \ offset: 0x14 : HSEM register HSEM_R0 HSEM_R31
$58001418 constant HSEM_HSEM_R6   \ offset: 0x18 : HSEM register HSEM_R0 HSEM_R31
$5800141c constant HSEM_HSEM_R7   \ offset: 0x1C : HSEM register HSEM_R0 HSEM_R31
$58001420 constant HSEM_HSEM_R8   \ offset: 0x20 : HSEM register HSEM_R0 HSEM_R31
$58001424 constant HSEM_HSEM_R9   \ offset: 0x24 : HSEM register HSEM_R0 HSEM_R31
$58001428 constant HSEM_HSEM_R10  \ offset: 0x28 : HSEM register HSEM_R0 HSEM_R31
$5800142c constant HSEM_HSEM_R11  \ offset: 0x2C : HSEM register HSEM_R0 HSEM_R31
$58001430 constant HSEM_HSEM_R12  \ offset: 0x30 : HSEM register HSEM_R0 HSEM_R31
$58001434 constant HSEM_HSEM_R13  \ offset: 0x34 : HSEM register HSEM_R0 HSEM_R31
$58001438 constant HSEM_HSEM_R14  \ offset: 0x38 : HSEM register HSEM_R0 HSEM_R31
$5800143c constant HSEM_HSEM_R15  \ offset: 0x3C : HSEM register HSEM_R0 HSEM_R31
$58001480 constant HSEM_HSEM_RLR0  \ offset: 0x80 : HSEM Read lock register
$58001484 constant HSEM_HSEM_RLR1  \ offset: 0x84 : HSEM Read lock register
$58001488 constant HSEM_HSEM_RLR2  \ offset: 0x88 : HSEM Read lock register
$5800148c constant HSEM_HSEM_RLR3  \ offset: 0x8C : HSEM Read lock register
$58001490 constant HSEM_HSEM_RLR4  \ offset: 0x90 : HSEM Read lock register
$58001494 constant HSEM_HSEM_RLR5  \ offset: 0x94 : HSEM Read lock register
$58001498 constant HSEM_HSEM_RLR6  \ offset: 0x98 : HSEM Read lock register
$5800149c constant HSEM_HSEM_RLR7  \ offset: 0x9C : HSEM Read lock register
$580014a0 constant HSEM_HSEM_RLR8  \ offset: 0xA0 : HSEM Read lock register
$580014a4 constant HSEM_HSEM_RLR9  \ offset: 0xA4 : HSEM Read lock register
$580014a8 constant HSEM_HSEM_RLR10  \ offset: 0xA8 : HSEM Read lock register
$580014ac constant HSEM_HSEM_RLR11  \ offset: 0xAC : HSEM Read lock register
$580014b0 constant HSEM_HSEM_RLR12  \ offset: 0xB0 : HSEM Read lock register
$580014b4 constant HSEM_HSEM_RLR13  \ offset: 0xB4 : HSEM Read lock register
$580014b8 constant HSEM_HSEM_RLR14  \ offset: 0xB8 : HSEM Read lock register
$580014bc constant HSEM_HSEM_RLR15  \ offset: 0xBC : HSEM Read lock register
$58001500 constant HSEM_HSEM_C1IER  \ offset: 0x100 : HSEM Interrupt enable register
$58001504 constant HSEM_HSEM_C1ICR  \ offset: 0x104 : HSEM Interrupt clear register
$58001508 constant HSEM_HSEM_C1ISR  \ offset: 0x108 : HSEM Interrupt status register
$5800150c constant HSEM_HSEM_C1MISR  \ offset: 0x10C : HSEM Masked interrupt status register
$58001510 constant HSEM_HSEM_C2IER  \ offset: 0x110 : HSEM Interrupt enable register
$58001514 constant HSEM_HSEM_C2ICR  \ offset: 0x114 : HSEM Interrupt clear register
$58001518 constant HSEM_HSEM_C2ISR  \ offset: 0x118 : HSEM Interrupt status register
$5800151c constant HSEM_HSEM_C2MISR  \ offset: 0x11C : HSEM Masked interrupt status register
$58001540 constant HSEM_HSEM_CR   \ offset: 0x140 : HSEM Clear register
$58001544 constant HSEM_HSEM_KEYR  \ offset: 0x144 : HSEM Interrupt clear register

