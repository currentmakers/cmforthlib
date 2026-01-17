\
\ @file fpu_cpacr.fs
\ @brief Floating point unit CPACR
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FPU_CPACR_DEF

  [ifdef] FPU_CPACR_CPACR_DEF
    \
    \ @brief Coprocessor access control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $14 constant FPU_CPACR_CP                   \ [0x14 : 4] CP
  [then]

  \
  \ @brief Floating point unit CPACR
  \
  $00 constant FPU_CPACR_CPACR          \ Coprocessor access control register

: FPU_CPACR_DEF ; [then]
