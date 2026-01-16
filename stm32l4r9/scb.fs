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

$000001ff constant SCB_ICSR_VECTACTIVE                              \ Active vector
$00000800 constant SCB_ICSR_RETTOBASE                               \ Return to base level
$0007f000 constant SCB_ICSR_VECTPENDING                             \ Pending vector
$00400000 constant SCB_ICSR_ISRPENDING                              \ Interrupt pending flag
$02000000 constant SCB_ICSR_PENDSTCLR                               \ SysTick exception clear-pending bit
$04000000 constant SCB_ICSR_PENDSTSET                               \ SysTick exception set-pending bit
$08000000 constant SCB_ICSR_PENDSVCLR                               \ PendSV clear-pending bit
$10000000 constant SCB_ICSR_PENDSVSET                               \ PendSV set-pending bit
$80000000 constant SCB_ICSR_NMIPENDSET                              \ NMI set-pending bit.


\
\ @brief Vector table offset register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$3ffffe00 constant SCB_VTOR_TBLOFF                                  \ Vector table base offset field


\
\ @brief Application interrupt and reset control register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SCB_AIRCR_VECTRESET                              \ VECTRESET
$00000002 constant SCB_AIRCR_VECTCLRACTIVE                          \ VECTCLRACTIVE
$00000004 constant SCB_AIRCR_SYSRESETREQ                            \ SYSRESETREQ
$00000700 constant SCB_AIRCR_PRIGROUP                               \ PRIGROUP
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

$00000001 constant SCB_CCR_NONBASETHRDENA                           \ Configures how the processor enters Thread mode
$00000002 constant SCB_CCR_USERSETMPEND                             \ USERSETMPEND
$00000008 constant SCB_CCR_UNALIGN__TRP                             \ UNALIGN_ TRP
$00000010 constant SCB_CCR_DIV_0_TRP                                \ DIV_0_TRP
$00000100 constant SCB_CCR_BFHFNMIGN                                \ BFHFNMIGN
$00000200 constant SCB_CCR_STKALIGN                                 \ STKALIGN


\
\ @brief System handler priority registers
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant SCB_SHPR1_PRI_4                                  \ Priority of system handler 4
$0000ff00 constant SCB_SHPR1_PRI_5                                  \ Priority of system handler 5
$00ff0000 constant SCB_SHPR1_PRI_6                                  \ Priority of system handler 6


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
\ @brief System handler control and state register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant SCB_SHCSR_MEMFAULTACT                            \ Memory management fault exception active bit
$00000002 constant SCB_SHCSR_BUSFAULTACT                            \ Bus fault exception active bit
$00000008 constant SCB_SHCSR_USGFAULTACT                            \ Usage fault exception active bit
$00000080 constant SCB_SHCSR_SVCALLACT                              \ SVC call active bit
$00000100 constant SCB_SHCSR_MONITORACT                             \ Debug monitor active bit
$00000400 constant SCB_SHCSR_PENDSVACT                              \ PendSV exception active bit
$00000800 constant SCB_SHCSR_SYSTICKACT                             \ SysTick exception active bit
$00001000 constant SCB_SHCSR_USGFAULTPENDED                         \ Usage fault exception pending bit
$00002000 constant SCB_SHCSR_MEMFAULTPENDED                         \ Memory management fault exception pending bit
$00004000 constant SCB_SHCSR_BUSFAULTPENDED                         \ Bus fault exception pending bit
$00008000 constant SCB_SHCSR_SVCALLPENDED                           \ SVC call pending bit
$00010000 constant SCB_SHCSR_MEMFAULTENA                            \ Memory management fault enable bit
$00020000 constant SCB_SHCSR_BUSFAULTENA                            \ Bus fault enable bit
$00040000 constant SCB_SHCSR_USGFAULTENA                            \ Usage fault enable bit


\
\ @brief Configurable fault status register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000002 constant SCB_CFSR_UFSR_BFSR_MMFSR_IACCVIOL                \ Instruction access violation flag
$00000008 constant SCB_CFSR_UFSR_BFSR_MMFSR_MUNSTKERR               \ Memory manager fault on unstacking for a return from exception
$00000010 constant SCB_CFSR_UFSR_BFSR_MMFSR_MSTKERR                 \ Memory manager fault on stacking for exception entry.
$00000020 constant SCB_CFSR_UFSR_BFSR_MMFSR_MLSPERR                 \ MLSPERR
$00000080 constant SCB_CFSR_UFSR_BFSR_MMFSR_MMARVALID               \ Memory Management Fault Address Register (MMAR) valid flag
$00000100 constant SCB_CFSR_UFSR_BFSR_MMFSR_IBUSERR                 \ Instruction bus error
$00000200 constant SCB_CFSR_UFSR_BFSR_MMFSR_PRECISERR               \ Precise data bus error
$00000400 constant SCB_CFSR_UFSR_BFSR_MMFSR_IMPRECISERR             \ Imprecise data bus error
$00000800 constant SCB_CFSR_UFSR_BFSR_MMFSR_UNSTKERR                \ Bus fault on unstacking for a return from exception
$00001000 constant SCB_CFSR_UFSR_BFSR_MMFSR_STKERR                  \ Bus fault on stacking for exception entry
$00002000 constant SCB_CFSR_UFSR_BFSR_MMFSR_LSPERR                  \ Bus fault on floating-point lazy state preservation
$00008000 constant SCB_CFSR_UFSR_BFSR_MMFSR_BFARVALID               \ Bus Fault Address Register (BFAR) valid flag
$00010000 constant SCB_CFSR_UFSR_BFSR_MMFSR_UNDEFINSTR              \ Undefined instruction usage fault
$00020000 constant SCB_CFSR_UFSR_BFSR_MMFSR_INVSTATE                \ Invalid state usage fault
$00040000 constant SCB_CFSR_UFSR_BFSR_MMFSR_INVPC                   \ Invalid PC load usage fault
$00080000 constant SCB_CFSR_UFSR_BFSR_MMFSR_NOCP                    \ No coprocessor usage fault.
$01000000 constant SCB_CFSR_UFSR_BFSR_MMFSR_UNALIGNED               \ Unaligned access usage fault
$02000000 constant SCB_CFSR_UFSR_BFSR_MMFSR_DIVBYZERO               \ Divide by zero usage fault


\
\ @brief Hard fault status register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000002 constant SCB_HFSR_VECTTBL                                 \ Vector table hard fault
$40000000 constant SCB_HFSR_FORCED                                  \ Forced hard fault
$80000000 constant SCB_HFSR_DEBUG_VT                                \ Reserved for Debug use


\
\ @brief Memory management fault address register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant SCB_MMFAR_MMFAR                                  \ Memory management fault address


\
\ @brief Bus fault address register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant SCB_BFAR_BFAR                                    \ Bus fault address


\
\ @brief Auxiliary fault status register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant SCB_AFSR_IMPDEF                                  \ Implementation defined


\
\ @brief System control block
\
$e000ed00 constant SCB_CPUID      \ offset: 0x00 : CPUID base register
$e000ed04 constant SCB_ICSR       \ offset: 0x04 : Interrupt control and state register
$e000ed08 constant SCB_VTOR       \ offset: 0x08 : Vector table offset register
$e000ed0c constant SCB_AIRCR      \ offset: 0x0C : Application interrupt and reset control register
$e000ed10 constant SCB_SCR        \ offset: 0x10 : System control register
$e000ed14 constant SCB_CCR        \ offset: 0x14 : Configuration and control register
$e000ed18 constant SCB_SHPR1      \ offset: 0x18 : System handler priority registers
$e000ed1c constant SCB_SHPR2      \ offset: 0x1C : System handler priority registers
$e000ed20 constant SCB_SHPR3      \ offset: 0x20 : System handler priority registers
$e000ed24 constant SCB_SHCSR      \ offset: 0x24 : System handler control and state register
$e000ed28 constant SCB_CFSR_UFSR_BFSR_MMFSR  \ offset: 0x28 : Configurable fault status register
$e000ed2c constant SCB_HFSR       \ offset: 0x2C : Hard fault status register
$e000ed34 constant SCB_MMFAR      \ offset: 0x34 : Memory management fault address register
$e000ed38 constant SCB_BFAR       \ offset: 0x38 : Bus fault address register
$e000ed3c constant SCB_AFSR       \ offset: 0x3C : Auxiliary fault status register

