\
\ @file ddrperfm.fs
\ @brief DDRPERFM
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DDRPERFM_DEF

  [ifdef] DDRPERFM_DDRPERFM_CTL_DEF
    \
    \ @brief Write-only register. A read request returns all zeros.
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DDRPERFM_START                 \ [0x00] START
    $01 constant DDRPERFM_STOP                  \ [0x01] STOP
  [then]


  [ifdef] DDRPERFM_DDRPERFM_CFG_DEF
    \
    \ @brief DDRPERFM configurationl register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DDRPERFM_EN                    \ [0x00 : 4] EN
    $10 constant DDRPERFM_SEL                   \ [0x10 : 2] SEL
  [then]


  [ifdef] DDRPERFM_DDRPERFM_STATUS_DEF
    \
    \ @brief DDRPERFM status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DDRPERFM_COVF                  \ [0x00 : 4] COVF
    $10 constant DDRPERFM_BUSY                  \ [0x10] BUSY
    $1f constant DDRPERFM_TOVF                  \ [0x1f] TOVF
  [then]


  [ifdef] DDRPERFM_DDRPERFM_CCR_DEF
    \
    \ @brief Write-only register. A read request returns all zeros
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant DDRPERFM_CCLR                  \ [0x00 : 4] CCLR
    $1f constant DDRPERFM_TCLR                  \ [0x1f] TCLR
  [then]


  [ifdef] DDRPERFM_DDRPERFM_IER_DEF
    \
    \ @brief DDRPERFM interrupt enable register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DDRPERFM_OVFIE                 \ [0x00] OVFIE
  [then]


  [ifdef] DDRPERFM_DDRPERFM_ISR_DEF
    \
    \ @brief DDRPERFM interrupt status register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DDRPERFM_OVFF                  \ [0x00] OVFF
  [then]


  [ifdef] DDRPERFM_DDRPERFM_ICR_DEF
    \
    \ @brief Write-only register. A read request returns all zeros
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DDRPERFM_OVF                   \ [0x00] OVF
  [then]


  [ifdef] DDRPERFM_DDRPERFM_TCNT_DEF
    \
    \ @brief DDRPERFM time counter register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DDRPERFM_CNT                   \ [0x00 : 32] CNT
  [then]


  [ifdef] DDRPERFM_DDRPERFM_CNT0_DEF
    \
    \ @brief DDRPERFM event counter 0 register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant DDRPERFM_CNT                   \ [0x00 : 32] CNT
  [then]


  [ifdef] DDRPERFM_DDRPERFM_CNT1_DEF
    \
    \ @brief DDRPERFM event counter 1 register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant DDRPERFM_CNT                   \ [0x00 : 32] CNT
  [then]


  [ifdef] DDRPERFM_DDRPERFM_CNT2_DEF
    \
    \ @brief DDRPERFM event counter 2 register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant DDRPERFM_CNT                   \ [0x00 : 32] CNT
  [then]


  [ifdef] DDRPERFM_DDRPERFM_CNT3_DEF
    \
    \ @brief DDRPERFM event counter 3 register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant DDRPERFM_CNT                   \ [0x00 : 32] CNT
  [then]


  [ifdef] DDRPERFM_DDRPERFM_HWCFG_DEF
    \
    \ @brief DDRPERFM hardware configuration register
    \ Address offset: 0x3F0
    \ Reset value: 0x00000004
    \
    $00 constant DDRPERFM_NCNT                  \ [0x00 : 4] NCNT
  [then]


  [ifdef] DDRPERFM_DDRPERFM_VER_DEF
    \
    \ @brief DDRPERFM version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant DDRPERFM_MINREV                \ [0x00 : 4] MINREV
    $04 constant DDRPERFM_MAJREV                \ [0x04 : 4] MAJREV
  [then]


  [ifdef] DDRPERFM_DDRPERFM_ID_DEF
    \
    \ @brief DDRPERFM ID register
    \ Address offset: 0x3F8
    \ Reset value: 0x00140061
    \
    $00 constant DDRPERFM_ID                    \ [0x00 : 32] ID
  [then]


  [ifdef] DDRPERFM_DDRPERFM_SID_DEF
    \
    \ @brief DDRPERFM magic ID register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant DDRPERFM_SID                   \ [0x00 : 32] SID
  [then]

  \
  \ @brief DDRPERFM
  \
  $00 constant DDRPERFM_DDRPERFM_CTL    \ Write-only register. A read request returns all zeros.
  $04 constant DDRPERFM_DDRPERFM_CFG    \ DDRPERFM configurationl register
  $08 constant DDRPERFM_DDRPERFM_STATUS \ DDRPERFM status register
  $0C constant DDRPERFM_DDRPERFM_CCR    \ Write-only register. A read request returns all zeros
  $10 constant DDRPERFM_DDRPERFM_IER    \ DDRPERFM interrupt enable register
  $14 constant DDRPERFM_DDRPERFM_ISR    \ DDRPERFM interrupt status register
  $18 constant DDRPERFM_DDRPERFM_ICR    \ Write-only register. A read request returns all zeros
  $20 constant DDRPERFM_DDRPERFM_TCNT   \ DDRPERFM time counter register
  $60 constant DDRPERFM_DDRPERFM_CNT0   \ DDRPERFM event counter 0 register
  $68 constant DDRPERFM_DDRPERFM_CNT1   \ DDRPERFM event counter 1 register
  $70 constant DDRPERFM_DDRPERFM_CNT2   \ DDRPERFM event counter 2 register
  $78 constant DDRPERFM_DDRPERFM_CNT3   \ DDRPERFM event counter 3 register
  $3F0 constant DDRPERFM_DDRPERFM_HWCFG \ DDRPERFM hardware configuration register
  $3F4 constant DDRPERFM_DDRPERFM_VER   \ DDRPERFM version register
  $3F8 constant DDRPERFM_DDRPERFM_ID    \ DDRPERFM ID register
  $3FC constant DDRPERFM_DDRPERFM_SID   \ DDRPERFM magic ID register

: DDRPERFM_DEF ; [then]
