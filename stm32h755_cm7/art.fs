\
\ @file art.fs
\ @brief accelerator - control register (ART_CTR)
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ART_DEF

  [ifdef] ART_CTR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00000004
    \
    $00 constant ART_EN                         \ [0x00] Cache enable
    $08 constant ART_PCACHEADDR                 \ [0x08 : 12] Cacheable page index
  [then]

  \
  \ @brief accelerator - control register (ART_CTR)
  \
  $00 constant ART_CTR                  \ control register

: ART_DEF ; [then]
