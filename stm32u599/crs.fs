\
\ @file crs.fs
\ @brief Clock recovery system
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] CRS_DEF

  [ifdef] CRS_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00004000
    \
    $00 constant CRS_SYNCOKIE                   \ [0x00] SYNC event OK interrupt enable
    $01 constant CRS_SYNCWARNIE                 \ [0x01] SYNC warning interrupt enable
    $02 constant CRS_ERRIE                      \ [0x02] Synchronization or trimming error interrupt enable
    $03 constant CRS_ESYNCIE                    \ [0x03] Expected SYNC interrupt enable
    $05 constant CRS_CEN                        \ [0x05] Frequency error counter enable
    $06 constant CRS_AUTOTRIMEN                 \ [0x06] Automatic trimming enable
    $07 constant CRS_SWSYNC                     \ [0x07] Generate software SYNC event
    $08 constant CRS_TRIM                       \ [0x08 : 7] HSI48 oscillator smooth trimming
  [then]


  [ifdef] CRS_CFGR_DEF
    \
    \ @brief configuration register
    \ Address offset: 0x04
    \ Reset value: 0x2022BB7F
    \
    $00 constant CRS_RELOAD                     \ [0x00 : 16] Counter reload value
    $10 constant CRS_FELIM                      \ [0x10 : 8] Frequency error limit
    $18 constant CRS_SYNCDIV                    \ [0x18 : 3] SYNC divider
    $1c constant CRS_SYNCSRC                    \ [0x1c : 2] SYNC signal source selection
    $1f constant CRS_SYNCPOL                    \ [0x1f] SYNC polarity selection
  [then]


  [ifdef] CRS_ISR_DEF
    \
    \ @brief interrupt and status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant CRS_SYNCOKF                    \ [0x00] SYNC event OK flag
    $01 constant CRS_SYNCWARNF                  \ [0x01] SYNC warning flag
    $02 constant CRS_ERRF                       \ [0x02] Error flag
    $03 constant CRS_ESYNCF                     \ [0x03] Expected SYNC flag
    $08 constant CRS_SYNCERR                    \ [0x08] SYNC error
    $09 constant CRS_SYNCMISS                   \ [0x09] SYNC missed
    $0a constant CRS_TRIMOVF                    \ [0x0a] Trimming overflow or underflow
    $0f constant CRS_FEDIR                      \ [0x0f] Frequency error direction
    $10 constant CRS_FECAP                      \ [0x10 : 16] Frequency error capture
  [then]


  [ifdef] CRS_ICR_DEF
    \
    \ @brief interrupt flag clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant CRS_SYNCOKC                    \ [0x00] SYNC event OK clear flag
    $01 constant CRS_SYNCWARNC                  \ [0x01] SYNC warning clear flag
    $02 constant CRS_ERRC                       \ [0x02] Error clear flag
    $03 constant CRS_ESYNCC                     \ [0x03] Expected SYNC clear flag
  [then]

  \
  \ @brief Clock recovery system
  \
  $00 constant CRS_CR                   \ control register
  $04 constant CRS_CFGR                 \ configuration register
  $08 constant CRS_ISR                  \ interrupt and status register
  $0C constant CRS_ICR                  \ interrupt flag clear register

: CRS_DEF ; [then]
