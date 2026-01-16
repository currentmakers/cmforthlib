\
\ @file scb.fs
\ @brief System control block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief CPUID base register
\ Address offset: 0x00
\ Reset value: 0x410FC241
\

$0000000f constant SCB_CPUID_REVISION                               \ Revision number
$0000fff0 constant SCB_CPUID_PARTNO                                 \ Part number of the processor
$000f0000 constant SCB_CPUID_CONSTANT                               \ Reads as 0xF
$00f00000 constant SCB_CPUID_VARIANT                                \ Variant number
$ff000000 constant SCB_CPUID_IMPLEMENTER                            \ Implementer code


\
\ @brief Interrupt control and state register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000003f constant SCB_ICSR_VECTACTIVE                              \ Active vector
$0003f000 constant SCB_ICSR_VECTPENDING                             \ Pending vector
$00400000 constant SCB_ICSR_ISRPENDING                              \ Interrupt pending flag
$02000000 constant SCB_ICSR_PENDSTCLR                               \ SysTick exception clear-pending bit
$04000000 constant SCB_ICSR_PENDSTSET                               \ SysTick exception set-pending bit
$08000000 constant SCB_ICSR_PENDSVCLR                               \ PendSV clear-pending bit
$10000000 constant SCB_ICSR_PENDSVSET                               \ PendSV set-pending bit
$80000000 constant SCB_ICSR_NMIPENDSET                              \ NMI set-pending bit.


\
\ @brief Application interrupt and reset control register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000002 constant SCB_AIRCR_VECTCLRACTIVE                          \ VECTCLRACTIVE
$00000004 constant SCB_AIRCR_SYSRESETREQ                            \ SYSRESETREQ
$00008000 constant SCB_AIRCR_ENDIANESS                              \ ENDIANESS
$ffff0000 constant SCB_AIRCR_VECTKEYSTAT                            \ Register key


\
\ @brief System control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000002 constant SCB_SCR_SLEEPONEXIT                              \ SLEEPONEXIT
$00000004 constant SCB_SCR_SLEEPDEEP                                \ SLEEPDEEP
$00000010 constant SCB_SCR_SEVEONPEND                               \ Send Event on Pending bit


\
\ @brief Configuration and control register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000008 constant SCB_CCR_UNALIGN__TRP                             \ UNALIGN_ TRP
$00000200 constant SCB_CCR_STKALIGN                                 \ STKALIGN


\
\ @brief System handler priority registers
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$ff000000 constant SCB_SHPR2_PRI_11                                 \ Priority of system handler 11


\
\ @brief System handler priority registers
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00ff0000 constant SCB_SHPR3_PRI_14                                 \ Priority of system handler 14
$ff000000 constant SCB_SHPR3_PRI_15                                 \ Priority of system handler 15


\
\ @brief System control block
\
$e000ed00 constant SCB_CPUID      \ offset: 0x00 : CPUID base register
$e000ed04 constant SCB_ICSR       \ offset: 0x04 : Interrupt control and state register
$e000ed0c constant SCB_AIRCR      \ offset: 0x0C : Application interrupt and reset control register
$e000ed10 constant SCB_SCR        \ offset: 0x10 : System control register
$e000ed14 constant SCB_CCR        \ offset: 0x14 : Configuration and control register
$e000ed1c constant SCB_SHPR2      \ offset: 0x1C : System handler priority registers
$e000ed20 constant SCB_SHPR3      \ offset: 0x20 : System handler priority registers

