\
\ @file scb.fs
\ @brief System control block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SCB_DEF

  [ifdef] SCB_CPUID_DEF
    \
    \ @brief CPUID base register
    \ Address offset: 0x00
    \ Reset value: 0x410FC241
    \
    $00 constant SCB_Revision                   \ [0x00 : 4] Revision number
    $04 constant SCB_PartNo                     \ [0x04 : 12] Part number of the processor
    $10 constant SCB_Constant                   \ [0x10 : 4] Reads as 0xF
    $14 constant SCB_Variant                    \ [0x14 : 4] Variant number
    $18 constant SCB_Implementer                \ [0x18 : 8] Implementer code
  [then]


  [ifdef] SCB_ICSR_DEF
    \
    \ @brief Interrupt control and state register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SCB_VECTACTIVE                 \ [0x00 : 9] Active vector
    $0b constant SCB_RETTOBASE                  \ [0x0b] Return to base level
    $0c constant SCB_VECTPENDING                \ [0x0c : 7] Pending vector
    $16 constant SCB_ISRPENDING                 \ [0x16] Interrupt pending flag
    $19 constant SCB_PENDSTCLR                  \ [0x19] SysTick exception clear-pending bit
    $1a constant SCB_PENDSTSET                  \ [0x1a] SysTick exception set-pending bit
    $1b constant SCB_PENDSVCLR                  \ [0x1b] PendSV clear-pending bit
    $1c constant SCB_PENDSVSET                  \ [0x1c] PendSV set-pending bit
    $1f constant SCB_NMIPENDSET                 \ [0x1f] NMI set-pending bit.
  [then]


  [ifdef] SCB_VTOR_DEF
    \
    \ @brief Vector table offset register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $09 constant SCB_TBLOFF                     \ [0x09 : 21] Vector table base offset field
  [then]


  [ifdef] SCB_AIRCR_DEF
    \
    \ @brief Application interrupt and reset control register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SCB_VECTRESET                  \ [0x00] VECTRESET
    $01 constant SCB_VECTCLRACTIVE              \ [0x01] VECTCLRACTIVE
    $02 constant SCB_SYSRESETREQ                \ [0x02] SYSRESETREQ
    $08 constant SCB_PRIGROUP                   \ [0x08 : 3] PRIGROUP
    $0f constant SCB_ENDIANESS                  \ [0x0f] ENDIANESS
    $10 constant SCB_VECTKEYSTAT                \ [0x10 : 16] Register key
  [then]


  [ifdef] SCB_SCR_DEF
    \
    \ @brief System control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $01 constant SCB_SLEEPONEXIT                \ [0x01] SLEEPONEXIT
    $02 constant SCB_SLEEPDEEP                  \ [0x02] SLEEPDEEP
    $04 constant SCB_SEVEONPEND                 \ [0x04] Send Event on Pending bit
  [then]


  [ifdef] SCB_CCR_DEF
    \
    \ @brief Configuration and control register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SCB_NONBASETHRDENA             \ [0x00] Configures how the processor enters Thread mode
    $01 constant SCB_USERSETMPEND               \ [0x01] USERSETMPEND
    $03 constant SCB_UNALIGN__TRP               \ [0x03] UNALIGN_ TRP
    $04 constant SCB_DIV_0_TRP                  \ [0x04] DIV_0_TRP
    $08 constant SCB_BFHFNMIGN                  \ [0x08] BFHFNMIGN
    $09 constant SCB_STKALIGN                   \ [0x09] STKALIGN
  [then]


  [ifdef] SCB_SHPR1_DEF
    \
    \ @brief System handler priority registers
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SCB_PRI_4                      \ [0x00 : 8] Priority of system handler 4
    $08 constant SCB_PRI_5                      \ [0x08 : 8] Priority of system handler 5
    $10 constant SCB_PRI_6                      \ [0x10 : 8] Priority of system handler 6
  [then]


  [ifdef] SCB_SHPR2_DEF
    \
    \ @brief System handler priority registers
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $18 constant SCB_PRI_11                     \ [0x18 : 8] Priority of system handler 11
  [then]


  [ifdef] SCB_SHPR3_DEF
    \
    \ @brief System handler priority registers
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $10 constant SCB_PRI_14                     \ [0x10 : 8] Priority of system handler 14
    $18 constant SCB_PRI_15                     \ [0x18 : 8] Priority of system handler 15
  [then]


  [ifdef] SCB_SHCSR_DEF
    \
    \ @brief System handler control and state register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SCB_MEMFAULTACT                \ [0x00] Memory management fault exception active bit
    $01 constant SCB_BUSFAULTACT                \ [0x01] Bus fault exception active bit
    $03 constant SCB_USGFAULTACT                \ [0x03] Usage fault exception active bit
    $07 constant SCB_SVCALLACT                  \ [0x07] SVC call active bit
    $08 constant SCB_MONITORACT                 \ [0x08] Debug monitor active bit
    $0a constant SCB_PENDSVACT                  \ [0x0a] PendSV exception active bit
    $0b constant SCB_SYSTICKACT                 \ [0x0b] SysTick exception active bit
    $0c constant SCB_USGFAULTPENDED             \ [0x0c] Usage fault exception pending bit
    $0d constant SCB_MEMFAULTPENDED             \ [0x0d] Memory management fault exception pending bit
    $0e constant SCB_BUSFAULTPENDED             \ [0x0e] Bus fault exception pending bit
    $0f constant SCB_SVCALLPENDED               \ [0x0f] SVC call pending bit
    $10 constant SCB_MEMFAULTENA                \ [0x10] Memory management fault enable bit
    $11 constant SCB_BUSFAULTENA                \ [0x11] Bus fault enable bit
    $12 constant SCB_USGFAULTENA                \ [0x12] Usage fault enable bit
  [then]


  [ifdef] SCB_CFSR_UFSR_BFSR_MMFSR_DEF
    \
    \ @brief Configurable fault status register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $01 constant SCB_IACCVIOL                   \ [0x01] Instruction access violation flag
    $03 constant SCB_MUNSTKERR                  \ [0x03] Memory manager fault on unstacking for a return from exception
    $04 constant SCB_MSTKERR                    \ [0x04] Memory manager fault on stacking for exception entry.
    $05 constant SCB_MLSPERR                    \ [0x05] MLSPERR
    $07 constant SCB_MMARVALID                  \ [0x07] Memory Management Fault Address Register (MMAR) valid flag
    $08 constant SCB_IBUSERR                    \ [0x08] Instruction bus error
    $09 constant SCB_PRECISERR                  \ [0x09] Precise data bus error
    $0a constant SCB_IMPRECISERR                \ [0x0a] Imprecise data bus error
    $0b constant SCB_UNSTKERR                   \ [0x0b] Bus fault on unstacking for a return from exception
    $0c constant SCB_STKERR                     \ [0x0c] Bus fault on stacking for exception entry
    $0d constant SCB_LSPERR                     \ [0x0d] Bus fault on floating-point lazy state preservation
    $0f constant SCB_BFARVALID                  \ [0x0f] Bus Fault Address Register (BFAR) valid flag
    $10 constant SCB_UNDEFINSTR                 \ [0x10] Undefined instruction usage fault
    $11 constant SCB_INVSTATE                   \ [0x11] Invalid state usage fault
    $12 constant SCB_INVPC                      \ [0x12] Invalid PC load usage fault
    $13 constant SCB_NOCP                       \ [0x13] No coprocessor usage fault.
    $18 constant SCB_UNALIGNED                  \ [0x18] Unaligned access usage fault
    $19 constant SCB_DIVBYZERO                  \ [0x19] Divide by zero usage fault
  [then]


  [ifdef] SCB_HFSR_DEF
    \
    \ @brief Hard fault status register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $01 constant SCB_VECTTBL                    \ [0x01] Vector table hard fault
    $1e constant SCB_FORCED                     \ [0x1e] Forced hard fault
    $1f constant SCB_DEBUG_VT                   \ [0x1f] Reserved for Debug use
  [then]


  [ifdef] SCB_MMFAR_DEF
    \
    \ @brief Memory management fault address register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant SCB_MMFAR                      \ [0x00 : 32] Memory management fault address
  [then]


  [ifdef] SCB_BFAR_DEF
    \
    \ @brief Bus fault address register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant SCB_BFAR                       \ [0x00 : 32] Bus fault address
  [then]


  [ifdef] SCB_AFSR_DEF
    \
    \ @brief Auxiliary fault status register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant SCB_IMPDEF                     \ [0x00 : 32] Implementation defined
  [then]

  \
  \ @brief System control block
  \
  $00 constant SCB_CPUID                \ CPUID base register
  $04 constant SCB_ICSR                 \ Interrupt control and state register
  $08 constant SCB_VTOR                 \ Vector table offset register
  $0C constant SCB_AIRCR                \ Application interrupt and reset control register
  $10 constant SCB_SCR                  \ System control register
  $14 constant SCB_CCR                  \ Configuration and control register
  $18 constant SCB_SHPR1                \ System handler priority registers
  $1C constant SCB_SHPR2                \ System handler priority registers
  $20 constant SCB_SHPR3                \ System handler priority registers
  $24 constant SCB_SHCSR                \ System handler control and state register
  $28 constant SCB_CFSR_UFSR_BFSR_MMFSR \ Configurable fault status register
  $2C constant SCB_HFSR                 \ Hard fault status register
  $34 constant SCB_MMFAR                \ Memory management fault address register
  $38 constant SCB_BFAR                 \ Bus fault address register
  $3C constant SCB_AFSR                 \ Auxiliary fault status register

: SCB_DEF ; [then]
