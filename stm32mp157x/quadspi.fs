\
\ @file quadspi.fs
\ @brief QUADSPI1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] QUADSPI_DEF

  [ifdef] QUADSPI_QUADSPI_CR_DEF
    \
    \ @brief QUADSPI control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_EN                     \ [0x00] EN
    $01 constant QUADSPI_ABORT                  \ [0x01] ABORT
    $02 constant QUADSPI_DMAEN                  \ [0x02] DMAEN
    $03 constant QUADSPI_TCEN                   \ [0x03] TCEN
    $04 constant QUADSPI_SSHIFT                 \ [0x04] SSHIFT
    $06 constant QUADSPI_DFM                    \ [0x06] DFM
    $07 constant QUADSPI_FSEL                   \ [0x07] FSEL
    $08 constant QUADSPI_FTHRES                 \ [0x08 : 4] FTHRES
    $10 constant QUADSPI_TEIE                   \ [0x10] TEIE
    $11 constant QUADSPI_TCIE                   \ [0x11] TCIE
    $12 constant QUADSPI_FTIE                   \ [0x12] FTIE
    $13 constant QUADSPI_SMIE                   \ [0x13] SMIE
    $14 constant QUADSPI_TOIE                   \ [0x14] TOIE
    $16 constant QUADSPI_APMS                   \ [0x16] APMS
    $17 constant QUADSPI_PMM                    \ [0x17] PMM
    $18 constant QUADSPI_PRESCALER              \ [0x18 : 8] PRESCALER
  [then]


  [ifdef] QUADSPI_QUADSPI_DCR_DEF
    \
    \ @brief QUADSPI device configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_CKMODE                 \ [0x00] CKMODE
    $08 constant QUADSPI_CSHT                   \ [0x08 : 3] CSHT
    $10 constant QUADSPI_FSIZE                  \ [0x10 : 5] FSIZE
  [then]


  [ifdef] QUADSPI_QUADSPI_SR_DEF
    \
    \ @brief QUADSPI status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_TEF                    \ [0x00] TEF
    $01 constant QUADSPI_TCF                    \ [0x01] TCF
    $02 constant QUADSPI_FTF                    \ [0x02] FTF
    $03 constant QUADSPI_SMF                    \ [0x03] SMF
    $04 constant QUADSPI_TOF                    \ [0x04] TOF
    $05 constant QUADSPI_BUSY                   \ [0x05] BUSY
    $08 constant QUADSPI_FLEVEL                 \ [0x08 : 5] FLEVEL
  [then]


  [ifdef] QUADSPI_QUADSPI_FCR_DEF
    \
    \ @brief QUADSPI flag clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_CTEF                   \ [0x00] CTEF
    $01 constant QUADSPI_CTCF                   \ [0x01] CTCF
    $03 constant QUADSPI_CSMF                   \ [0x03] CSMF
    $04 constant QUADSPI_CTOF                   \ [0x04] CTOF
  [then]


  [ifdef] QUADSPI_QUADSPI_DLR_DEF
    \
    \ @brief QUADSPI data length register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_DL                     \ [0x00 : 32] DL
  [then]


  [ifdef] QUADSPI_QUADSPI_CCR_DEF
    \
    \ @brief QUADSPI communication configuration register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_INSTRUCTION            \ [0x00 : 8] INSTRUCTION
    $08 constant QUADSPI_IMODE                  \ [0x08 : 2] IMODE
    $0a constant QUADSPI_ADMODE                 \ [0x0a : 2] ADMODE
    $0c constant QUADSPI_ADSIZE                 \ [0x0c : 2] ADSIZE
    $0e constant QUADSPI_ABMODE                 \ [0x0e : 2] ABMODE
    $10 constant QUADSPI_ABSIZE                 \ [0x10 : 2] ABSIZE
    $12 constant QUADSPI_DCYC                   \ [0x12 : 5] DCYC
    $18 constant QUADSPI_DMODE                  \ [0x18 : 2] DMODE
    $1a constant QUADSPI_FMODE                  \ [0x1a : 2] FMODE
    $1c constant QUADSPI_SIOO                   \ [0x1c] SIOO
    $1d constant QUADSPI_FRCM                   \ [0x1d] FRCM
    $1e constant QUADSPI_DHHC                   \ [0x1e] DHHC
    $1f constant QUADSPI_DDRM                   \ [0x1f] DDRM
  [then]


  [ifdef] QUADSPI_QUADSPI_AR_DEF
    \
    \ @brief QUADSPI address register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_ADDRESS                \ [0x00 : 32] ADDRESS
  [then]


  [ifdef] QUADSPI_QUADSPI_ABR_DEF
    \
    \ @brief QUADSPI alternate bytes registers
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_ALTERNATE              \ [0x00 : 32] ALTERNATE
  [then]


  [ifdef] QUADSPI_QUADSPI_DR_DEF
    \
    \ @brief QUADSPI data register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_DATA                   \ [0x00 : 32] DATA
  [then]


  [ifdef] QUADSPI_QUADSPI_PSMKR_DEF
    \
    \ @brief QUADSPI polling status mask register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_MASK                   \ [0x00 : 32] MASK
  [then]


  [ifdef] QUADSPI_QUADSPI_PSMAR_DEF
    \
    \ @brief QUADSPI polling status match register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_MATCH                  \ [0x00 : 32] MATCH
  [then]


  [ifdef] QUADSPI_QUADSPI_PIR_DEF
    \
    \ @brief QUADSPI polling interval register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_INTERVAL               \ [0x00 : 16] INTERVAL
  [then]


  [ifdef] QUADSPI_QUADSPI_LPTR_DEF
    \
    \ @brief QUADSPI low-power timeout register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_TIMEOUT                \ [0x00 : 16] TIMEOUT
  [then]


  [ifdef] QUADSPI_QUADSPI_HWCFGR_DEF
    \
    \ @brief QUADSPI HW configuration register
    \ Address offset: 0x3F0
    \ Reset value: 0x0000B058
    \
    $00 constant QUADSPI_FIFOSIZE               \ [0x00 : 4] FIFOSIZE
    $04 constant QUADSPI_FIFOPTR                \ [0x04 : 4] FIFOPTR
    $08 constant QUADSPI_PRESCVAL               \ [0x08 : 4] PRESCVAL
    $0c constant QUADSPI_IDLENGTH               \ [0x0c : 4] IDLENGTH
  [then]


  [ifdef] QUADSPI_QUADSPI_VERR_DEF
    \
    \ @brief QUADSPI version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000041
    \
    $00 constant QUADSPI_MINREV                 \ [0x00 : 4] MINREV
    $04 constant QUADSPI_MAJREV                 \ [0x04 : 4] MAJREV
  [then]


  [ifdef] QUADSPI_QUADSPI_IPIDR_DEF
    \
    \ @brief QUADSPI identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00140031
    \
    $00 constant QUADSPI_ID                     \ [0x00 : 32] ID
  [then]


  [ifdef] QUADSPI_QUADSPI_SIDR_DEF
    \
    \ @brief QUADSPI size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant QUADSPI_SID                    \ [0x00 : 32] SID
  [then]

  \
  \ @brief QUADSPI1
  \
  $00 constant QUADSPI_QUADSPI_CR       \ QUADSPI control register
  $04 constant QUADSPI_QUADSPI_DCR      \ QUADSPI device configuration register
  $08 constant QUADSPI_QUADSPI_SR       \ QUADSPI status register
  $0C constant QUADSPI_QUADSPI_FCR      \ QUADSPI flag clear register
  $10 constant QUADSPI_QUADSPI_DLR      \ QUADSPI data length register
  $14 constant QUADSPI_QUADSPI_CCR      \ QUADSPI communication configuration register
  $18 constant QUADSPI_QUADSPI_AR       \ QUADSPI address register
  $1C constant QUADSPI_QUADSPI_ABR      \ QUADSPI alternate bytes registers
  $20 constant QUADSPI_QUADSPI_DR       \ QUADSPI data register
  $24 constant QUADSPI_QUADSPI_PSMKR    \ QUADSPI polling status mask register
  $28 constant QUADSPI_QUADSPI_PSMAR    \ QUADSPI polling status match register
  $2C constant QUADSPI_QUADSPI_PIR      \ QUADSPI polling interval register
  $30 constant QUADSPI_QUADSPI_LPTR     \ QUADSPI low-power timeout register
  $3F0 constant QUADSPI_QUADSPI_HWCFGR  \ QUADSPI HW configuration register
  $3F4 constant QUADSPI_QUADSPI_VERR    \ QUADSPI version register
  $3F8 constant QUADSPI_QUADSPI_IPIDR   \ QUADSPI identification register
  $3FC constant QUADSPI_QUADSPI_SIDR    \ QUADSPI size identification register

: QUADSPI_DEF ; [then]
