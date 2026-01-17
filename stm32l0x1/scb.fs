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
    $10 constant SCB_Architecture               \ [0x10 : 4] Reads as 0xF
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
    $07 constant SCB_TBLOFF                     \ [0x07 : 25] Vector table base offset field
  [then]


  [ifdef] SCB_AIRCR_DEF
    \
    \ @brief Application interrupt and reset control register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $01 constant SCB_VECTCLRACTIVE              \ [0x01] VECTCLRACTIVE
    $02 constant SCB_SYSRESETREQ                \ [0x02] SYSRESETREQ
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

  \
  \ @brief System control block
  \
  $00 constant SCB_CPUID                \ CPUID base register
  $04 constant SCB_ICSR                 \ Interrupt control and state register
  $08 constant SCB_VTOR                 \ Vector table offset register
  $0C constant SCB_AIRCR                \ Application interrupt and reset control register
  $10 constant SCB_SCR                  \ System control register
  $14 constant SCB_CCR                  \ Configuration and control register
  $1C constant SCB_SHPR2                \ System handler priority registers
  $20 constant SCB_SHPR3                \ System handler priority registers

: SCB_DEF ; [then]
