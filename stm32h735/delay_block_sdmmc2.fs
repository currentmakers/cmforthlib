\
\ @file delay_block_sdmmc2.fs
\ @brief DELAY_Block_SDMMC1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DLYB control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DELAY_BLOCK_SDMMC2_CR_DEN                        \ Delay block enable bit
$00000002 constant DELAY_BLOCK_SDMMC2_CR_SEN                        \ Sampler length enable bit


\
\ @brief DLYB configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000000f constant DELAY_BLOCK_SDMMC2_CFGR_SEL                      \ Select the phase for the Output clock
$00007f00 constant DELAY_BLOCK_SDMMC2_CFGR_UNIT                     \ Delay Defines the delay of a Unit delay cell
$0fff0000 constant DELAY_BLOCK_SDMMC2_CFGR_LNG                      \ Delay line length value
$80000000 constant DELAY_BLOCK_SDMMC2_CFGR_LNGF                     \ Length valid flag


\
\ @brief DELAY_Block_SDMMC1
\
$48022800 constant DELAY_BLOCK_SDMMC2_CR  \ offset: 0x00 : DLYB control register
$48022804 constant DELAY_BLOCK_SDMMC2_CFGR  \ offset: 0x04 : DLYB configuration register

