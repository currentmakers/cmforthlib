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
    \ @brief Control register (WWDG_CR)
    \ Address offset: 0x00
    \ Reset value: 0x0000007F
    \
    $00 constant WWDG_T                         \ [0x00 : 7] 7-bit counter (MSB to LSB)
    $07 constant WWDG_WDGA                      \ [0x07] Activation bit
  [then]


  [ifdef] WWDG_CFR_DEF
    \
    \ @brief Configuration register (WWDG_CFR)
    \ Address offset: 0x04
    \ Reset value: 0x0000007F
    \
    $00 constant WWDG_W                         \ [0x00 : 7] 7-bit window value
    $07 constant WWDG_WDGTB                     \ [0x07 : 2] Timer Base
    $09 constant WWDG_EWI                       \ [0x09] Early Wakeup Interrupt
  [then]


  [ifdef] WWDG_SR_DEF
    \
    \ @brief Status register (WWDG_SR)
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant WWDG_EWI                       \ [0x00] Early Wakeup Interrupt
  [then]

  \
  \ @brief Window watchdog
  \
  $00 constant WWDG_CR                  \ Control register (WWDG_CR)
  $04 constant WWDG_CFR                 \ Configuration register (WWDG_CFR)
  $08 constant WWDG_SR                  \ Status register (WWDG_SR)

: WWDG_DEF ; [then]
