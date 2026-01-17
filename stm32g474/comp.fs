\
\ @file comp.fs
\ @brief Comparator control and status register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] COMP_DEF

  [ifdef] COMP_COMP_C1CSR_DEF
    \
    \ @brief Comparator control/status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant COMP_EN                        \ [0x00] EN
    $04 constant COMP_INMSEL                    \ [0x04 : 3] INMSEL
    $08 constant COMP_INPSEL                    \ [0x08] INPSEL
    $0f constant COMP_POL                       \ [0x0f] POL
    $10 constant COMP_HYST                      \ [0x10 : 3] HYST
    $13 constant COMP_BLANKSEL                  \ [0x13 : 3] BLANKSEL
    $16 constant COMP_BRGEN                     \ [0x16] BRGEN
    $17 constant COMP_SCALEN                    \ [0x17] SCALEN
    $1e constant COMP_VALUE                     \ [0x1e] VALUE
    $1f constant COMP_LOCK                      \ [0x1f] LOCK
  [then]


  [ifdef] COMP_COMP_C2CSR_DEF
    \
    \ @brief Comparator control/status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant COMP_EN                        \ [0x00] EN
    $04 constant COMP_INMSEL                    \ [0x04 : 3] INMSEL
    $08 constant COMP_INPSEL                    \ [0x08] INPSEL
    $0f constant COMP_POL                       \ [0x0f] POL
    $10 constant COMP_HYST                      \ [0x10 : 3] HYST
    $13 constant COMP_BLANKSEL                  \ [0x13 : 3] BLANKSEL
    $16 constant COMP_BRGEN                     \ [0x16] BRGEN
    $17 constant COMP_SCALEN                    \ [0x17] SCALEN
    $1e constant COMP_VALUE                     \ [0x1e] VALUE
    $1f constant COMP_LOCK                      \ [0x1f] LOCK
  [then]


  [ifdef] COMP_COMP_C3CSR_DEF
    \
    \ @brief Comparator control/status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant COMP_EN                        \ [0x00] EN
    $04 constant COMP_INMSEL                    \ [0x04 : 3] INMSEL
    $08 constant COMP_INPSEL                    \ [0x08] INPSEL
    $0f constant COMP_POL                       \ [0x0f] POL
    $10 constant COMP_HYST                      \ [0x10 : 3] HYST
    $13 constant COMP_BLANKSEL                  \ [0x13 : 3] BLANKSEL
    $16 constant COMP_BRGEN                     \ [0x16] BRGEN
    $17 constant COMP_SCALEN                    \ [0x17] SCALEN
    $1e constant COMP_VALUE                     \ [0x1e] VALUE
    $1f constant COMP_LOCK                      \ [0x1f] LOCK
  [then]


  [ifdef] COMP_COMP_C4CSR_DEF
    \
    \ @brief Comparator control/status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant COMP_EN                        \ [0x00] EN
    $04 constant COMP_INMSEL                    \ [0x04 : 3] INMSEL
    $08 constant COMP_INPSEL                    \ [0x08] INPSEL
    $0f constant COMP_POL                       \ [0x0f] POL
    $10 constant COMP_HYST                      \ [0x10 : 3] HYST
    $13 constant COMP_BLANKSEL                  \ [0x13 : 3] BLANKSEL
    $16 constant COMP_BRGEN                     \ [0x16] BRGEN
    $17 constant COMP_SCALEN                    \ [0x17] SCALEN
    $1e constant COMP_VALUE                     \ [0x1e] VALUE
    $1f constant COMP_LOCK                      \ [0x1f] LOCK
  [then]


  [ifdef] COMP_COMP_C5CSR_DEF
    \
    \ @brief Comparator control/status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant COMP_EN                        \ [0x00] EN
    $04 constant COMP_INMSEL                    \ [0x04 : 3] INMSEL
    $08 constant COMP_INPSEL                    \ [0x08] INPSEL
    $0f constant COMP_POL                       \ [0x0f] POL
    $10 constant COMP_HYST                      \ [0x10 : 3] HYST
    $13 constant COMP_BLANKSEL                  \ [0x13 : 3] BLANKSEL
    $16 constant COMP_BRGEN                     \ [0x16] BRGEN
    $17 constant COMP_SCALEN                    \ [0x17] SCALEN
    $1e constant COMP_VALUE                     \ [0x1e] VALUE
    $1f constant COMP_LOCK                      \ [0x1f] LOCK
  [then]


  [ifdef] COMP_COMP_C6CSR_DEF
    \
    \ @brief Comparator control/status register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant COMP_EN                        \ [0x00] EN
    $04 constant COMP_INMSEL                    \ [0x04 : 3] INMSEL
    $08 constant COMP_INPSEL                    \ [0x08] INPSEL
    $0f constant COMP_POL                       \ [0x0f] POL
    $10 constant COMP_HYST                      \ [0x10 : 3] HYST
    $13 constant COMP_BLANKSEL                  \ [0x13 : 3] BLANKSEL
    $16 constant COMP_BRGEN                     \ [0x16] BRGEN
    $17 constant COMP_SCALEN                    \ [0x17] SCALEN
    $1e constant COMP_VALUE                     \ [0x1e] VALUE
    $1f constant COMP_LOCK                      \ [0x1f] LOCK
  [then]


  [ifdef] COMP_COMP_C7CSR_DEF
    \
    \ @brief Comparator control/status register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant COMP_EN                        \ [0x00] EN
    $04 constant COMP_INMSEL                    \ [0x04 : 3] INMSEL
    $08 constant COMP_INPSEL                    \ [0x08] INPSEL
    $0f constant COMP_POL                       \ [0x0f] POL
    $10 constant COMP_HYST                      \ [0x10 : 3] HYST
    $13 constant COMP_BLANKSEL                  \ [0x13 : 3] BLANKSEL
    $16 constant COMP_BRGEN                     \ [0x16] BRGEN
    $17 constant COMP_SCALEN                    \ [0x17] SCALEN
    $1e constant COMP_VALUE                     \ [0x1e] VALUE
    $1f constant COMP_LOCK                      \ [0x1f] LOCK
  [then]

  \
  \ @brief Comparator control and status register
  \
  $00 constant COMP_COMP_C1CSR          \ Comparator control/status register
  $04 constant COMP_COMP_C2CSR          \ Comparator control/status register
  $08 constant COMP_COMP_C3CSR          \ Comparator control/status register
  $0C constant COMP_COMP_C4CSR          \ Comparator control/status register
  $10 constant COMP_COMP_C5CSR          \ Comparator control/status register
  $14 constant COMP_COMP_C6CSR          \ Comparator control/status register
  $18 constant COMP_COMP_C7CSR          \ Comparator control/status register

: COMP_DEF ; [then]
