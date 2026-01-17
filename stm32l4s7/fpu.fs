\
\ @file fpu.fs
\ @brief Floting point unit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FPU_DEF

  [ifdef] FPU_FPCCR_DEF
    \
    \ @brief Floating-point context control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant FPU_LSPACT                     \ [0x00] LSPACT
    $01 constant FPU_USER                       \ [0x01] USER
    $03 constant FPU_THREAD                     \ [0x03] THREAD
    $04 constant FPU_HFRDY                      \ [0x04] HFRDY
    $05 constant FPU_MMRDY                      \ [0x05] MMRDY
    $06 constant FPU_BFRDY                      \ [0x06] BFRDY
    $08 constant FPU_MONRDY                     \ [0x08] MONRDY
    $1e constant FPU_LSPEN                      \ [0x1e] LSPEN
    $1f constant FPU_ASPEN                      \ [0x1f] ASPEN
  [then]


  [ifdef] FPU_FPCAR_DEF
    \
    \ @brief Floating-point context address register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $03 constant FPU_ADDRESS                    \ [0x03 : 29] Location of unpopulated floating-point
  [then]


  [ifdef] FPU_FPSCR_DEF
    \
    \ @brief Floating-point status control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant FPU_IOC                        \ [0x00] Invalid operation cumulative exception bit
    $01 constant FPU_DZC                        \ [0x01] Division by zero cumulative exception bit.
    $02 constant FPU_OFC                        \ [0x02] Overflow cumulative exception bit
    $03 constant FPU_UFC                        \ [0x03] Underflow cumulative exception bit
    $04 constant FPU_IXC                        \ [0x04] Inexact cumulative exception bit
    $07 constant FPU_IDC                        \ [0x07] Input denormal cumulative exception bit.
    $16 constant FPU_RMode                      \ [0x16 : 2] Rounding Mode control field
    $18 constant FPU_FZ                         \ [0x18] Flush-to-zero mode control bit:
    $19 constant FPU_DN                         \ [0x19] Default NaN mode control bit
    $1a constant FPU_AHP                        \ [0x1a] Alternative half-precision control bit
    $1c constant FPU_V                          \ [0x1c] Overflow condition code flag
    $1d constant FPU_C                          \ [0x1d] Carry condition code flag
    $1e constant FPU_Z                          \ [0x1e] Zero condition code flag
    $1f constant FPU_N                          \ [0x1f] Negative condition code flag
  [then]

  \
  \ @brief Floting point unit
  \
  $00 constant FPU_FPCCR                \ Floating-point context control register
  $04 constant FPU_FPCAR                \ Floating-point context address register
  $08 constant FPU_FPSCR                \ Floating-point status control register

: FPU_DEF ; [then]
