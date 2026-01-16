\
\ @file mpu.fs
\ @brief Memory protection unit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief MPU type register
\ Address offset: 0x00
\ Reset value: 0x00000800
\

$00000001 constant MPU_MPU_TYPER_SEPARATE                           \ Separate flag
$0000ff00 constant MPU_MPU_TYPER_DREGION                            \ Number of MPU data regions
$00ff0000 constant MPU_MPU_TYPER_IREGION                            \ Number of MPU instruction regions


\
\ @brief MPU control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant MPU_MPU_CTRL_ENABLE                              \ Enables the MPU
$00000002 constant MPU_MPU_CTRL_HFNMIENA                            \ Enables the operation of MPU during hard fault
$00000004 constant MPU_MPU_CTRL_PRIVDEFENA                          \ Enable priviliged software access to default memory map


\
\ @brief MPU region number register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant MPU_MPU_RNR_REGION                               \ MPU region


\
\ @brief MPU region base address register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant MPU_MPU_RBAR_REGION                              \ MPU region field
$00000010 constant MPU_MPU_RBAR_VALID                               \ MPU region number valid
$ffffffe0 constant MPU_MPU_RBAR_ADDR                                \ Region base address field


\
\ @brief MPU region attribute and size register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant MPU_MPU_RASR_ENABLE                              \ Region enable bit.
$0000003e constant MPU_MPU_RASR_SIZE                                \ Size of the MPU protection region
$0000ff00 constant MPU_MPU_RASR_SRD                                 \ Subregion disable bits
$00010000 constant MPU_MPU_RASR_B                                   \ memory attribute
$00020000 constant MPU_MPU_RASR_C                                   \ memory attribute
$00040000 constant MPU_MPU_RASR_S                                   \ Shareable memory attribute
$00380000 constant MPU_MPU_RASR_TEX                                 \ memory attribute
$07000000 constant MPU_MPU_RASR_AP                                  \ Access permission
$10000000 constant MPU_MPU_RASR_XN                                  \ Instruction access disable bit


\
\ @brief Memory protection unit
\
$e000ed90 constant MPU_MPU_TYPER  \ offset: 0x00 : MPU type register
$e000ed94 constant MPU_MPU_CTRL   \ offset: 0x04 : MPU control register
$e000ed98 constant MPU_MPU_RNR    \ offset: 0x08 : MPU region number register
$e000ed9c constant MPU_MPU_RBAR   \ offset: 0x0C : MPU region base address register
$e000eda0 constant MPU_MPU_RASR   \ offset: 0x10 : MPU region attribute and size register

