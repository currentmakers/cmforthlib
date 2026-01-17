\
\ @file mpu.fs
\ @brief Memory protection unit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] MPU_DEF

  [ifdef] MPU_MPU_TYPER_DEF
    \
    \ @brief MPU type register
    \ Address offset: 0x00
    \ Reset value: 0x00000800
    \
    $00 constant MPU_SEPARATE                   \ [0x00] Separate flag
    $08 constant MPU_DREGION                    \ [0x08 : 8] Number of MPU data regions
    $10 constant MPU_IREGION                    \ [0x10 : 8] Number of MPU instruction regions
  [then]


  [ifdef] MPU_MPU_CTRL_DEF
    \
    \ @brief MPU control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant MPU_ENABLE                     \ [0x00] Enables the MPU
    $01 constant MPU_HFNMIENA                   \ [0x01] Enables the operation of MPU during hard fault
    $02 constant MPU_PRIVDEFENA                 \ [0x02] Enable priviliged software access to default memory map
  [then]


  [ifdef] MPU_MPU_RNR_DEF
    \
    \ @brief MPU region number register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant MPU_REGION                     \ [0x00 : 8] MPU region
  [then]


  [ifdef] MPU_MPU_RBAR_DEF
    \
    \ @brief MPU region base address register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant MPU_REGION                     \ [0x00 : 4] MPU region field
    $04 constant MPU_VALID                      \ [0x04] MPU region number valid
    $05 constant MPU_ADDR                       \ [0x05 : 27] Region base address field
  [then]


  [ifdef] MPU_MPU_RASR_DEF
    \
    \ @brief MPU region attribute and size register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant MPU_ENABLE                     \ [0x00] Region enable bit.
    $01 constant MPU_SIZE                       \ [0x01 : 5] Size of the MPU protection region
    $08 constant MPU_SRD                        \ [0x08 : 8] Subregion disable bits
    $10 constant MPU_B                          \ [0x10] memory attribute
    $11 constant MPU_C                          \ [0x11] memory attribute
    $12 constant MPU_S                          \ [0x12] Shareable memory attribute
    $13 constant MPU_TEX                        \ [0x13 : 3] memory attribute
    $18 constant MPU_AP                         \ [0x18 : 3] Access permission
    $1c constant MPU_XN                         \ [0x1c] Instruction access disable bit
  [then]

  \
  \ @brief Memory protection unit
  \
  $00 constant MPU_MPU_TYPER            \ MPU type register
  $04 constant MPU_MPU_CTRL             \ MPU control register
  $08 constant MPU_MPU_RNR              \ MPU region number register
  $0C constant MPU_MPU_RBAR             \ MPU region base address register
  $10 constant MPU_MPU_RASR             \ MPU region attribute and size register

: MPU_DEF ; [then]
