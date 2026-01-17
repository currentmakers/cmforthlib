\
\ @file wwdg.fs
\ @brief Window watchdog
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] WWDG_DEF

  [ifdef] WWDG_CR_DEF
    \
    \ @brief Control register
    \ Address offset: 0x00
    \ Reset value: 0x0000007F
    \
    $00 constant WWDG_T                         \ [0x00 : 7] 7-bit counter (MSB to LSB)
    $07 constant WWDG_WDGA                      \ [0x07] Activation bit
  [then]


  [ifdef] WWDG_CFR_DEF
    \
    \ @brief Configuration register
    \ Address offset: 0x04
    \ Reset value: 0x0000007F
    \
    $00 constant WWDG_W                         \ [0x00 : 7] 7-bit window value
    $07 constant WWDG_WDGTB0                    \ [0x07] WDGTB0
    $08 constant WWDG_WDGTB1                    \ [0x08] Timer base
    $09 constant WWDG_EWI                       \ [0x09] Early wakeup interrupt
  [then]


  [ifdef] WWDG_SR_DEF
    \
    \ @brief SR
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant WWDG_EWIF                      \ [0x00] EWIF
  [then]

  \
  \ @brief Window watchdog
  \
  $00 constant WWDG_CR                  \ Control register
  $04 constant WWDG_CFR                 \ Configuration register
  $08 constant WWDG_SR                  \ SR

: WWDG_DEF ; [then]
