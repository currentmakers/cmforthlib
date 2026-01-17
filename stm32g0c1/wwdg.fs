\
\ @file wwdg.fs
\ @brief System window watchdog
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] WWDG_DEF

  [ifdef] WWDG_WWDG_CR_DEF
    \
    \ @brief Control register
    \ Address offset: 0x00
    \ Reset value: 0x0000007F
    \
    $00 constant WWDG_T                         \ [0x00 : 7] 7-bit counter (MSB to LSB) These bits contain the value of the watchdog counter, decremented every (4096 x 2WDGTB[1:0]) PCLK cycles. A reset is produced when it is decremented from 0x40 to 0x3F (T6 becomes cleared).
    $07 constant WWDG_WDGA                      \ [0x07] Activation bit This bit is set by software and only cleared by hardware after a reset. When WDGA=1, the watchdog can generate a reset.
  [then]


  [ifdef] WWDG_WWDG_CFR_DEF
    \
    \ @brief Configuration register
    \ Address offset: 0x04
    \ Reset value: 0x0000007F
    \
    $00 constant WWDG_W                         \ [0x00 : 7] 7-bit window value These bits contain the window value to be compared with the down-counter.
    $09 constant WWDG_EWI                       \ [0x09] Early wakeup interrupt When set, an interrupt occurs whenever the counter reaches the value 0x40. This interrupt is only cleared by hardware after a reset.
    $0b constant WWDG_WDGTB                     \ [0x0b : 3] Timer base The timebase of the prescaler can be modified as follows:
  [then]


  [ifdef] WWDG_WWDG_SR_DEF
    \
    \ @brief Status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant WWDG_EWIF                      \ [0x00] Early wakeup interrupt flag
  [then]

  \
  \ @brief System window watchdog
  \
  $00 constant WWDG_WWDG_CR             \ Control register
  $04 constant WWDG_WWDG_CFR            \ Configuration register
  $08 constant WWDG_WWDG_SR             \ Status register

: WWDG_DEF ; [then]
