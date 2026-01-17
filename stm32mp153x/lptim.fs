\
\ @file lptim.fs
\ @brief LPTIM1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LPTIM_DEF

  [ifdef] LPTIM_LPTIM_ISR_DEF
    \
    \ @brief LPTIM interrupt and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CMPM                     \ [0x00] CMPM
    $01 constant LPTIM_ARRM                     \ [0x01] ARRM
    $02 constant LPTIM_EXTTRIG                  \ [0x02] EXTTRIG
    $03 constant LPTIM_CMPOK                    \ [0x03] CMPOK
    $04 constant LPTIM_ARROK                    \ [0x04] ARROK
    $05 constant LPTIM_UP                       \ [0x05] UP
    $06 constant LPTIM_DOWN                     \ [0x06] DOWN
  [then]


  [ifdef] LPTIM_LPTIM_ICR_DEF
    \
    \ @brief LPTIM interrupt clear register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CMPMCF                   \ [0x00] CMPMCF
    $01 constant LPTIM_ARRMCF                   \ [0x01] ARRMCF
    $02 constant LPTIM_EXTTRIGCF                \ [0x02] EXTTRIGCF
    $03 constant LPTIM_CMPOKCF                  \ [0x03] CMPOKCF
    $04 constant LPTIM_ARROKCF                  \ [0x04] ARROKCF
    $05 constant LPTIM_UPCF                     \ [0x05] UPCF
    $06 constant LPTIM_DOWNCF                   \ [0x06] DOWNCF
  [then]


  [ifdef] LPTIM_LPTIM_IER_DEF
    \
    \ @brief LPTIM interrupt enable register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CMPMIE                   \ [0x00] CMPMIE
    $01 constant LPTIM_ARRMIE                   \ [0x01] ARRMIE
    $02 constant LPTIM_EXTTRIGIE                \ [0x02] EXTTRIGIE
    $03 constant LPTIM_CMPOKIE                  \ [0x03] CMPOKIE
    $04 constant LPTIM_ARROKIE                  \ [0x04] ARROKIE
    $05 constant LPTIM_UPIE                     \ [0x05] UPIE
    $06 constant LPTIM_DOWNIE                   \ [0x06] DOWNIE
  [then]


  [ifdef] LPTIM_LPTIM_CFGR_DEF
    \
    \ @brief LPTIM configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CKSEL                    \ [0x00] CKSEL
    $01 constant LPTIM_CKPOL                    \ [0x01 : 2] CKPOL
    $03 constant LPTIM_CKFLT                    \ [0x03 : 2] CKFLT
    $06 constant LPTIM_TRGFLT                   \ [0x06 : 2] TRGFLT
    $09 constant LPTIM_PRESC                    \ [0x09 : 3] PRESC
    $0d constant LPTIM_TRIGSEL                  \ [0x0d : 3] TRIGSEL
    $11 constant LPTIM_TRIGEN                   \ [0x11 : 2] TRIGEN
    $13 constant LPTIM_TIMOUT                   \ [0x13] TIMOUT
    $14 constant LPTIM_WAVE                     \ [0x14] WAVE
    $15 constant LPTIM_WAVPOL                   \ [0x15] WAVPOL
    $16 constant LPTIM_PRELOAD                  \ [0x16] PRELOAD
    $17 constant LPTIM_COUNTMODE                \ [0x17] COUNTMODE
    $18 constant LPTIM_ENC                      \ [0x18] ENC
  [then]


  [ifdef] LPTIM_LPTIM_CR_DEF
    \
    \ @brief LPTIM control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_ENABLE                   \ [0x00] ENABLE
    $01 constant LPTIM_SNGSTRT                  \ [0x01] SNGSTRT
    $02 constant LPTIM_CNTSTRT                  \ [0x02] CNTSTRT
    $03 constant LPTIM_COUNTRST                 \ [0x03] COUNTRST
    $04 constant LPTIM_RSTARE                   \ [0x04] RSTARE
  [then]


  [ifdef] LPTIM_LPTIM_CMP_DEF
    \
    \ @brief LPTIM compare register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CMP                      \ [0x00 : 16] CMP
  [then]


  [ifdef] LPTIM_LPTIM_ARR_DEF
    \
    \ @brief LPTIM autoreload register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant LPTIM_ARR                      \ [0x00 : 16] ARR
  [then]


  [ifdef] LPTIM_LPTIM_CNT_DEF
    \
    \ @brief LPTIM counter register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CNT                      \ [0x00 : 16] CNT
  [then]


  [ifdef] LPTIM_LPTIM_CFGR2_DEF
    \
    \ @brief LPTIM configuration register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_IN1SEL                   \ [0x00 : 2] IN1SEL
    $04 constant LPTIM_IN2SEL                   \ [0x04 : 2] IN2SEL
  [then]


  [ifdef] LPTIM_LPTIM1_HWCFGR_DEF
    \
    \ @brief LPTIM 1 peripheral hardware configuration register
    \ Address offset: 0x3F0
    \ Reset value: 0x00010804
    \
    $00 constant LPTIM_CFG1                     \ [0x00 : 8] CFG1
    $08 constant LPTIM_CFG2                     \ [0x08 : 8] CFG2
    $10 constant LPTIM_CFG3                     \ [0x10 : 4] CFG3
    $18 constant LPTIM_CFG4                     \ [0x18 : 8] CFG4
  [then]


  [ifdef] LPTIM_LPTIM_VERR_DEF
    \
    \ @brief LPTIM peripheral version identification register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000014
    \
    $00 constant LPTIM_MINREV                   \ [0x00 : 4] MINREV
    $04 constant LPTIM_MAJREV                   \ [0x04 : 4] MAJREV
  [then]


  [ifdef] LPTIM_LPTIM_PIDR_DEF
    \
    \ @brief LPTIM peripheral type identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00120011
    \
    $00 constant LPTIM_P_ID                     \ [0x00 : 32] P_ID
  [then]


  [ifdef] LPTIM_LPTIM_SIDR_DEF
    \
    \ @brief LPTIM registers map size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant LPTIM_S_ID                     \ [0x00 : 32] S_ID
  [then]

  \
  \ @brief LPTIM1
  \
  $00 constant LPTIM_LPTIM_ISR          \ LPTIM interrupt and status register
  $04 constant LPTIM_LPTIM_ICR          \ LPTIM interrupt clear register
  $08 constant LPTIM_LPTIM_IER          \ LPTIM interrupt enable register
  $0C constant LPTIM_LPTIM_CFGR         \ LPTIM configuration register
  $10 constant LPTIM_LPTIM_CR           \ LPTIM control register
  $14 constant LPTIM_LPTIM_CMP          \ LPTIM compare register
  $18 constant LPTIM_LPTIM_ARR          \ LPTIM autoreload register
  $1C constant LPTIM_LPTIM_CNT          \ LPTIM counter register
  $24 constant LPTIM_LPTIM_CFGR2        \ LPTIM configuration register 2
  $3F0 constant LPTIM_LPTIM1_HWCFGR     \ LPTIM 1 peripheral hardware configuration register
  $3F4 constant LPTIM_LPTIM_VERR        \ LPTIM peripheral version identification register
  $3F8 constant LPTIM_LPTIM_PIDR        \ LPTIM peripheral type identification register
  $3FC constant LPTIM_LPTIM_SIDR        \ LPTIM registers map size identification register

: LPTIM_DEF ; [then]
