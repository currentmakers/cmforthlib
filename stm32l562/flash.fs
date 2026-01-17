\
\ @file flash.fs
\ @brief Flash
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FLASH_DEF

  [ifdef] FLASH_ACR_DEF
    \
    \ @brief Access control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_LATENCY                  \ [0x00 : 4] Latency
    $0d constant FLASH_RUN_PD                   \ [0x0d] Flash Power-down mode during Low-power run mode
    $0e constant FLASH_SLEEP_PD                 \ [0x0e] Flash Power-down mode during Low-power sleep mode
    $0f constant FLASH_LVEN                     \ [0x0f] LVEN
  [then]


  [ifdef] FLASH_PDKEYR_DEF
    \
    \ @brief Power down key register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PDKEYR                   \ [0x00 : 32] RUN_PD in FLASH_ACR key
  [then]


  [ifdef] FLASH_NSKEYR_DEF
    \
    \ @brief Flash non-secure key register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_NSKEYR                   \ [0x00 : 32] NSKEYR
  [then]


  [ifdef] FLASH_SECKEYR_DEF
    \
    \ @brief Flash secure key register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECKEYR                  \ [0x00 : 32] SECKEYR
  [then]


  [ifdef] FLASH_OPTKEYR_DEF
    \
    \ @brief Flash option key register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_OPTKEYR                  \ [0x00 : 32] OPTKEYR
  [then]


  [ifdef] FLASH_LVEKEYR_DEF
    \
    \ @brief Flash low voltage key register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_LVEKEYR                  \ [0x00 : 32] LVEKEYR
  [then]


  [ifdef] FLASH_NSSR_DEF
    \
    \ @brief Flash status register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_NSEOP                    \ [0x00] NSEOP
    $01 constant FLASH_NSOPERR                  \ [0x01] NSOPERR
    $03 constant FLASH_NSPROGERR                \ [0x03] NSPROGERR
    $04 constant FLASH_NSWRPERR                 \ [0x04] NSWRPERR
    $05 constant FLASH_NSPGAERR                 \ [0x05] NSPGAERR
    $06 constant FLASH_NSSIZERR                 \ [0x06] NSSIZERR
    $07 constant FLASH_NSPGSERR                 \ [0x07] NSPGSERR
    $0d constant FLASH_OPTWERR                  \ [0x0d] OPTWERR
    $0f constant FLASH_OPTVERR                  \ [0x0f] OPTVERR
    $10 constant FLASH_NSBSY                    \ [0x10] NSBusy
  [then]


  [ifdef] FLASH_SECSR_DEF
    \
    \ @brief Flash status register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECEOP                   \ [0x00] SECEOP
    $01 constant FLASH_SECOPERR                 \ [0x01] SECOPERR
    $03 constant FLASH_SECPROGERR               \ [0x03] SECPROGERR
    $04 constant FLASH_SECWRPERR                \ [0x04] SECWRPERR
    $05 constant FLASH_SECPGAERR                \ [0x05] SECPGAERR
    $06 constant FLASH_SECSIZERR                \ [0x06] SECSIZERR
    $07 constant FLASH_SECPGSERR                \ [0x07] SECPGSERR
    $0e constant FLASH_SECRDERR                 \ [0x0e] Secure read protection error
    $10 constant FLASH_SECBSY                   \ [0x10] SECBusy
  [then]


  [ifdef] FLASH_NSCR_DEF
    \
    \ @brief Flash non-secure control register
    \ Address offset: 0x28
    \ Reset value: 0xC0000000
    \
    $00 constant FLASH_NSPG                     \ [0x00] NSPG
    $01 constant FLASH_NSPER                    \ [0x01] NSPER
    $02 constant FLASH_NSMER1                   \ [0x02] NSMER1
    $03 constant FLASH_NSPNB                    \ [0x03 : 7] NSPNB
    $0b constant FLASH_NSBKER                   \ [0x0b] NSBKER
    $0f constant FLASH_NSMER2                   \ [0x0f] NSMER2
    $10 constant FLASH_NSSTRT                   \ [0x10] Options modification start
    $11 constant FLASH_OPTSTRT                  \ [0x11] Options modification start
    $18 constant FLASH_NSEOPIE                  \ [0x18] NSEOPIE
    $19 constant FLASH_NSERRIE                  \ [0x19] NSERRIE
    $1b constant FLASH_OBL_LAUNCH               \ [0x1b] Force the option byte loading
    $1e constant FLASH_OPTLOCK                  \ [0x1e] Options Lock
    $1f constant FLASH_NSLOCK                   \ [0x1f] NSLOCK
  [then]


  [ifdef] FLASH_SECCR_DEF
    \
    \ @brief Flash secure control register
    \ Address offset: 0x2C
    \ Reset value: 0x80000000
    \
    $00 constant FLASH_SECPG                    \ [0x00] SECPG
    $01 constant FLASH_SECPER                   \ [0x01] SECPER
    $02 constant FLASH_SECMER1                  \ [0x02] SECMER1
    $03 constant FLASH_SECPNB                   \ [0x03 : 7] SECPNB
    $0b constant FLASH_SECBKER                  \ [0x0b] SECBKER
    $0f constant FLASH_SECMER2                  \ [0x0f] SECMER2
    $10 constant FLASH_SECSTRT                  \ [0x10] SECSTRT
    $18 constant FLASH_SECEOPIE                 \ [0x18] SECEOPIE
    $19 constant FLASH_SECERRIE                 \ [0x19] SECERRIE
    $1a constant FLASH_SECRDERRIE               \ [0x1a] SECRDERRIE
    $1d constant FLASH_SECINV                   \ [0x1d] SECINV
    $1f constant FLASH_SECLOCK                  \ [0x1f] SECLOCK
  [then]


  [ifdef] FLASH_ECCR_DEF
    \
    \ @brief Flash ECC register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_ADDR_ECC                 \ [0x00 : 19] ECC fail address
    $15 constant FLASH_BK_ECC                   \ [0x15] BK_ECC
    $16 constant FLASH_SYSF_ECC                 \ [0x16] SYSF_ECC
    $18 constant FLASH_ECCIE                    \ [0x18] ECC correction interrupt enable
    $1c constant FLASH_ECCC2                    \ [0x1c] ECCC2
    $1d constant FLASH_ECCD2                    \ [0x1d] ECCD2
    $1e constant FLASH_ECCC                     \ [0x1e] ECC correction
    $1f constant FLASH_ECCD                     \ [0x1f] ECC detection
  [then]


  [ifdef] FLASH_OPTR_DEF
    \
    \ @brief Flash option register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_RDP                      \ [0x00 : 8] Read protection level
    $08 constant FLASH_BOR_LEV                  \ [0x08 : 3] BOR reset Level
    $0c constant FLASH_nRST_STOP                \ [0x0c] nRST_STOP
    $0d constant FLASH_nRST_STDBY               \ [0x0d] nRST_STDBY
    $0e constant FLASH_nRST_SHDW                \ [0x0e] nRST_SHDW
    $10 constant FLASH_IWDG_SW                  \ [0x10] Independent watchdog selection
    $11 constant FLASH_IWDG_STOP                \ [0x11] Independent watchdog counter freeze in Stop mode
    $12 constant FLASH_IWDG_STDBY               \ [0x12] Independent watchdog counter freeze in Standby mode
    $13 constant FLASH_WWDG_SW                  \ [0x13] Window watchdog selection
    $14 constant FLASH_SWAP_BANK                \ [0x14] SWAP_BANK
    $15 constant FLASH_DB256K                   \ [0x15] DB256K
    $16 constant FLASH_DBANK                    \ [0x16] DBANK
    $18 constant FLASH_SRAM2_PE                 \ [0x18] SRAM2 parity check enable
    $19 constant FLASH_SRAM2_RST                \ [0x19] SRAM2 Erase when system reset
    $1a constant FLASH_nSWBOOT0                 \ [0x1a] nSWBOOT0
    $1b constant FLASH_nBOOT0                   \ [0x1b] nBOOT0
    $1c constant FLASH_PA15_PUPEN               \ [0x1c] PA15_PUPEN
    $1f constant FLASH_TZEN                     \ [0x1f] TZEN
  [then]


  [ifdef] FLASH_NSBOOTADD0R_DEF
    \
    \ @brief Flash non-secure boot address 0 register
    \ Address offset: 0x44
    \ Reset value: 0x0000000F
    \
    $07 constant FLASH_NSBOOTADD0               \ [0x07 : 25] NSBOOTADD0
  [then]


  [ifdef] FLASH_NSBOOTADD1R_DEF
    \
    \ @brief Flash non-secure boot address 1 register
    \ Address offset: 0x48
    \ Reset value: 0x0000000F
    \
    $07 constant FLASH_NSBOOTADD1               \ [0x07 : 25] NSBOOTADD1
  [then]


  [ifdef] FLASH_SECBOOTADD0R_DEF
    \
    \ @brief FFlash secure boot address 0 register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_BOOT_LOCK                \ [0x00] BOOT_LOCK
    $07 constant FLASH_SECBOOTADD0              \ [0x07 : 25] SECBOOTADD0
  [then]


  [ifdef] FLASH_SECWM1R1_DEF
    \
    \ @brief Flash bank 1 secure watermak1 register
    \ Address offset: 0x50
    \ Reset value: 0xFF00FF00
    \
    $00 constant FLASH_SECWM1_PSTRT             \ [0x00 : 7] SECWM1_PSTRT
    $10 constant FLASH_SECWM1_PEND              \ [0x10 : 7] SECWM1_PEND
  [then]


  [ifdef] FLASH_SECWM1R2_DEF
    \
    \ @brief Flash secure watermak1 register 2
    \ Address offset: 0x54
    \ Reset value: 0x0F000F00
    \
    $00 constant FLASH_PCROP1_PSTRT             \ [0x00 : 7] PCROP1_PSTRT
    $0f constant FLASH_PCROP1EN                 \ [0x0f] PCROP1EN
    $10 constant FLASH_HDP1_PEND                \ [0x10 : 7] HDP1_PEND
    $1f constant FLASH_HDP1EN                   \ [0x1f] HDP1EN
  [then]


  [ifdef] FLASH_WRP1AR_DEF
    \
    \ @brief Flash Bank 1 WRP area A address register
    \ Address offset: 0x58
    \ Reset value: 0xFF00FF00
    \
    $00 constant FLASH_WRP1A_PSTRT              \ [0x00 : 7] WRP1A_PSTRT
    $10 constant FLASH_WRP1A_PEND               \ [0x10 : 7] WRP1A_PEND
  [then]


  [ifdef] FLASH_WRP1BR_DEF
    \
    \ @brief Flash Bank 1 WRP area B address register
    \ Address offset: 0x5C
    \ Reset value: 0xFF00FF00
    \
    $00 constant FLASH_WRP1B_PSTRT              \ [0x00 : 7] WRP1B_PSTRT
    $10 constant FLASH_WRP1B_PEND               \ [0x10 : 7] WRP1B_PEND
  [then]


  [ifdef] FLASH_SECWM2R1_DEF
    \
    \ @brief Flash secure watermak2 register
    \ Address offset: 0x60
    \ Reset value: 0xFF00FF00
    \
    $00 constant FLASH_SECWM2_PSTRT             \ [0x00 : 7] SECWM2_PSTRT
    $10 constant FLASH_SECWM2_PEND              \ [0x10 : 7] SECWM2_PEND
  [then]


  [ifdef] FLASH_SECWM2R2_DEF
    \
    \ @brief Flash secure watermak2 register2
    \ Address offset: 0x64
    \ Reset value: 0x0F000F00
    \
    $00 constant FLASH_PCROP2_PSTRT             \ [0x00 : 7] PCROP2_PSTRT
    $0f constant FLASH_PCROP2EN                 \ [0x0f] PCROP2EN
    $10 constant FLASH_HDP2_PEND                \ [0x10 : 7] HDP2_PEND
    $1f constant FLASH_HDP2EN                   \ [0x1f] HDP2EN
  [then]


  [ifdef] FLASH_WRP2AR_DEF
    \
    \ @brief Flash WPR2 area A address register
    \ Address offset: 0x68
    \ Reset value: 0xFF00FF00
    \
    $00 constant FLASH_WRP2A_PSTRT              \ [0x00 : 7] WRP2A_PSTRT
    $10 constant FLASH_WRP2A_PEND               \ [0x10 : 7] WRP2A_PEND
  [then]


  [ifdef] FLASH_WRP2BR_DEF
    \
    \ @brief Flash WPR2 area B address register
    \ Address offset: 0x6C
    \ Reset value: 0xFF00FF00
    \
    $00 constant FLASH_WRP2B_PSTRT              \ [0x00 : 7] WRP2B_PSTRT
    $10 constant FLASH_WRP2B_PEND               \ [0x10 : 7] WRP2B_PEND
  [then]


  [ifdef] FLASH_SECBB1R1_DEF
    \
    \ @brief FLASH secure block based bank 1 register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB1                   \ [0x00 : 32] SECBB1
  [then]


  [ifdef] FLASH_SECBB1R2_DEF
    \
    \ @brief FLASH secure block based bank 1 register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB1                   \ [0x00 : 32] SECBB1
  [then]


  [ifdef] FLASH_SECBB1R3_DEF
    \
    \ @brief FLASH secure block based bank 1 register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB1                   \ [0x00 : 32] SECBB1
  [then]


  [ifdef] FLASH_SECBB1R4_DEF
    \
    \ @brief FLASH secure block based bank 1 register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB1                   \ [0x00 : 32] SECBB1
  [then]


  [ifdef] FLASH_SECBB2R1_DEF
    \
    \ @brief FLASH secure block based bank 2 register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB2                   \ [0x00 : 32] SECBB2
  [then]


  [ifdef] FLASH_SECBB2R2_DEF
    \
    \ @brief FLASH secure block based bank 2 register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB2                   \ [0x00 : 32] SECBB2
  [then]


  [ifdef] FLASH_SECBB2R3_DEF
    \
    \ @brief FLASH secure block based bank 2 register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB2                   \ [0x00 : 32] SECBB2
  [then]


  [ifdef] FLASH_SECBB2R4_DEF
    \
    \ @brief FLASH secure block based bank 2 register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_SECBB2                   \ [0x00 : 32] SECBB2
  [then]


  [ifdef] FLASH_SECHDPCR_DEF
    \
    \ @brief FLASH secure HDP control register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_HDP1_ACCDIS              \ [0x00] HDP1_ACCDIS
    $01 constant FLASH_HDP2_ACCDIS              \ [0x01] HDP2_ACCDIS
  [then]


  [ifdef] FLASH_PRIVCFGR_DEF
    \
    \ @brief Power privilege configuration register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant FLASH_PRIV                     \ [0x00] PRIV
  [then]

  \
  \ @brief Flash
  \
  $00 constant FLASH_ACR                \ Access control register
  $04 constant FLASH_PDKEYR             \ Power down key register
  $08 constant FLASH_NSKEYR             \ Flash non-secure key register
  $0C constant FLASH_SECKEYR            \ Flash secure key register
  $10 constant FLASH_OPTKEYR            \ Flash option key register
  $14 constant FLASH_LVEKEYR            \ Flash low voltage key register
  $20 constant FLASH_NSSR               \ Flash status register
  $24 constant FLASH_SECSR              \ Flash status register
  $28 constant FLASH_NSCR               \ Flash non-secure control register
  $2C constant FLASH_SECCR              \ Flash secure control register
  $30 constant FLASH_ECCR               \ Flash ECC register
  $40 constant FLASH_OPTR               \ Flash option register
  $44 constant FLASH_NSBOOTADD0R        \ Flash non-secure boot address 0 register
  $48 constant FLASH_NSBOOTADD1R        \ Flash non-secure boot address 1 register
  $4C constant FLASH_SECBOOTADD0R       \ FFlash secure boot address 0 register
  $50 constant FLASH_SECWM1R1           \ Flash bank 1 secure watermak1 register
  $54 constant FLASH_SECWM1R2           \ Flash secure watermak1 register 2
  $58 constant FLASH_WRP1AR             \ Flash Bank 1 WRP area A address register
  $5C constant FLASH_WRP1BR             \ Flash Bank 1 WRP area B address register
  $60 constant FLASH_SECWM2R1           \ Flash secure watermak2 register
  $64 constant FLASH_SECWM2R2           \ Flash secure watermak2 register2
  $68 constant FLASH_WRP2AR             \ Flash WPR2 area A address register
  $6C constant FLASH_WRP2BR             \ Flash WPR2 area B address register
  $80 constant FLASH_SECBB1R1           \ FLASH secure block based bank 1 register
  $84 constant FLASH_SECBB1R2           \ FLASH secure block based bank 1 register
  $88 constant FLASH_SECBB1R3           \ FLASH secure block based bank 1 register
  $8C constant FLASH_SECBB1R4           \ FLASH secure block based bank 1 register
  $A0 constant FLASH_SECBB2R1           \ FLASH secure block based bank 2 register
  $A4 constant FLASH_SECBB2R2           \ FLASH secure block based bank 2 register
  $A8 constant FLASH_SECBB2R3           \ FLASH secure block based bank 2 register
  $AC constant FLASH_SECBB2R4           \ FLASH secure block based bank 2 register
  $C0 constant FLASH_SECHDPCR           \ FLASH secure HDP control register
  $C4 constant FLASH_PRIVCFGR           \ Power privilege configuration register

: FLASH_DEF ; [then]
