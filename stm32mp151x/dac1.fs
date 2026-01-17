\
\ @file dac1.fs
\ @brief DAC1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DAC1_DEF

  [ifdef] DAC1_DAC_CR_DEF
    \
    \ @brief DAC control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_EN1                       \ [0x00] EN1
    $01 constant DAC1_TEN1                      \ [0x01] TEN1
    $02 constant DAC1_TSEL10                    \ [0x02] TSEL10
    $03 constant DAC1_TSEL11                    \ [0x03] TSEL11
    $04 constant DAC1_TSEL12                    \ [0x04] TSEL12
    $05 constant DAC1_TSEL13                    \ [0x05] TSEL13
    $06 constant DAC1_WAVE1                     \ [0x06 : 2] WAVE1
    $08 constant DAC1_MAMP1                     \ [0x08 : 4] MAMP1
    $0c constant DAC1_DMAEN1                    \ [0x0c] DMAEN1
    $0d constant DAC1_DMAUDRIE1                 \ [0x0d] DMAUDRIE1
    $0e constant DAC1_CEN1                      \ [0x0e] CEN1
    $0f constant DAC1_HFSEL                     \ [0x0f] HFSEL
    $10 constant DAC1_EN2                       \ [0x10] EN2
    $11 constant DAC1_TEN2                      \ [0x11] TEN2
    $12 constant DAC1_TSEL20                    \ [0x12] TSEL20
    $13 constant DAC1_TSEL21                    \ [0x13] TSEL21
    $14 constant DAC1_TSEL22                    \ [0x14] TSEL22
    $15 constant DAC1_TSEL23                    \ [0x15] TSEL23
    $16 constant DAC1_WAVE2                     \ [0x16 : 2] WAVE2
    $18 constant DAC1_MAMP2                     \ [0x18 : 4] MAMP2
    $1c constant DAC1_DMAEN2                    \ [0x1c] DMAEN2
    $1d constant DAC1_DMAUDRIE2                 \ [0x1d] DMAUDRIE2
    $1e constant DAC1_CEN2                      \ [0x1e] CEN2
  [then]


  [ifdef] DAC1_DAC_SWTRGR_DEF
    \
    \ @brief DAC software trigger register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_SWTRIG1                   \ [0x00] SWTRIG1
    $01 constant DAC1_SWTRIG2                   \ [0x01] SWTRIG2
  [then]


  [ifdef] DAC1_DAC_DHR12R1_DEF
    \
    \ @brief DAC channel1 12-bit right-aligned data holding register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_DACC1DHR                  \ [0x00 : 12] DACC1DHR
  [then]


  [ifdef] DAC1_DAC_DHR12L1_DEF
    \
    \ @brief DAC channel1 12-bit left aligned data holding register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $04 constant DAC1_DACC1DHR                  \ [0x04 : 12] DACC1DHR
  [then]


  [ifdef] DAC1_DAC_DHR8R1_DEF
    \
    \ @brief DAC channel1 8-bit right aligned data holding register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_DACC1DHR                  \ [0x00 : 8] DACC1DHR
  [then]


  [ifdef] DAC1_DAC_DHR12R2_DEF
    \
    \ @brief This register is available only on dual-channel DACs. Refer to Section29.3: DAC implementation.
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_DACC2DHR                  \ [0x00 : 12] DACC2DHR
  [then]


  [ifdef] DAC1_DAC_DHR12L2_DEF
    \
    \ @brief This register is available only on dual-channel DACs. Refer to Section29.3: DAC implementation.
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $04 constant DAC1_DACC2DHR                  \ [0x04 : 12] DACC2DHR
  [then]


  [ifdef] DAC1_DAC_DHR8R2_DEF
    \
    \ @brief This register is available only on dual-channel DACs. Refer to Section29.3: DAC implementation.
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_DACC2DHR                  \ [0x00 : 8] DACC2DHR
  [then]


  [ifdef] DAC1_DAC_DHR12RD_DEF
    \
    \ @brief Dual DAC 12-bit right-aligned data holding register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_DACC1DHR                  \ [0x00 : 12] DACC1DHR
    $10 constant DAC1_DACC2DHR                  \ [0x10 : 12] DACC2DHR
  [then]


  [ifdef] DAC1_DAC_DHR12LD_DEF
    \
    \ @brief Dual DAC 12-bit left aligned data holding register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $04 constant DAC1_DACC1DHR                  \ [0x04 : 12] DACC1DHR
    $14 constant DAC1_DACC2DHR                  \ [0x14 : 12] DACC2DHR
  [then]


  [ifdef] DAC1_DAC_DHR8RD_DEF
    \
    \ @brief Dual DAC 8-bit right aligned data holding register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_DACC1DHR                  \ [0x00 : 8] DACC1DHR
    $08 constant DAC1_DACC2DHR                  \ [0x08 : 8] DACC2DHR
  [then]


  [ifdef] DAC1_DAC_DOR1_DEF
    \
    \ @brief DAC channel1 data output register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_DACC1DOR                  \ [0x00 : 12] DACC1DOR
  [then]


  [ifdef] DAC1_DAC_DOR2_DEF
    \
    \ @brief This register is available only on dual-channel DACs. Refer to Section29.3: DAC implementation.
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_DACC2DOR                  \ [0x00 : 12] DACC2DOR
  [then]


  [ifdef] DAC1_DAC_SR_DEF
    \
    \ @brief DAC status register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $0d constant DAC1_DMAUDR1                   \ [0x0d] DMAUDR1
    $0e constant DAC1_CAL_FLAG1                 \ [0x0e] CAL_FLAG1
    $0f constant DAC1_BWST1                     \ [0x0f] BWST1
    $1d constant DAC1_DMAUDR2                   \ [0x1d] DMAUDR2
    $1e constant DAC1_CAL_FLAG2                 \ [0x1e] CAL_FLAG2
    $1f constant DAC1_BWST2                     \ [0x1f] BWST2
  [then]


  [ifdef] DAC1_DAC_CCR_DEF
    \
    \ @brief DAC calibration control register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_OTRIM1                    \ [0x00 : 5] OTRIM1
    $10 constant DAC1_OTRIM2                    \ [0x10 : 5] OTRIM2
  [then]


  [ifdef] DAC1_DAC_MCR_DEF
    \
    \ @brief DAC mode control register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_MODE1                     \ [0x00 : 3] MODE1
    $10 constant DAC1_MODE2                     \ [0x10 : 3] MODE2
  [then]


  [ifdef] DAC1_DAC_SHSR1_DEF
    \
    \ @brief DAC channel 1 sample and hold sample time register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_TSAMPLE1                  \ [0x00 : 10] TSAMPLE1
  [then]


  [ifdef] DAC1_DAC_SHSR2_DEF
    \
    \ @brief This register is available only on dual-channel DACs. Refer to Section29.3: DAC implementation.
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant DAC1_TSAMPLE2                  \ [0x00 : 10] TSAMPLE2
  [then]


  [ifdef] DAC1_DAC_SHHR_DEF
    \
    \ @brief DAC sample and hold time register
    \ Address offset: 0x48
    \ Reset value: 0x00010001
    \
    $00 constant DAC1_THOLD1                    \ [0x00 : 10] THOLD1
    $10 constant DAC1_THOLD2                    \ [0x10 : 10] THOLD2
  [then]


  [ifdef] DAC1_DAC_SHRR_DEF
    \
    \ @brief DAC sample and hold refresh time register
    \ Address offset: 0x4C
    \ Reset value: 0x00010001
    \
    $00 constant DAC1_TREFRESH1                 \ [0x00 : 8] TREFRESH1
    $10 constant DAC1_TREFRESH2                 \ [0x10 : 8] TREFRESH2
  [then]


  [ifdef] DAC1_DAC_HWCFGR0_DEF
    \
    \ @brief DAC IP hardware configuration register
    \ Address offset: 0x3F0
    \ Reset value: 0x00001111
    \
    $00 constant DAC1_DUAL                      \ [0x00 : 4] DUAL
    $04 constant DAC1_LFSR                      \ [0x04 : 4] LFSR
    $08 constant DAC1_TRIANGLE                  \ [0x08 : 4] TRIANGLE
    $0c constant DAC1_SAMPLE                    \ [0x0c : 4] SAMPLE
    $10 constant DAC1_OR_CFG                    \ [0x10 : 8] OR_CFG
  [then]


  [ifdef] DAC1_DAC_VERR_DEF
    \
    \ @brief No
    \ Address offset: 0x3F4
    \ Reset value: 0x00000031
    \
    $00 constant DAC1_MINREV                    \ [0x00 : 4] MINREV
    $04 constant DAC1_MAJREV                    \ [0x04 : 4] MAJREV
  [then]


  [ifdef] DAC1_DAC_IPIDR_DEF
    \
    \ @brief No
    \ Address offset: 0x3F8
    \ Reset value: 0x00110011
    \
    $00 constant DAC1_ID                        \ [0x00 : 32] ID
  [then]


  [ifdef] DAC1_DAC_SIDR_DEF
    \
    \ @brief No
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant DAC1_SID                       \ [0x00 : 32] SID
  [then]

  \
  \ @brief DAC1
  \
  $00 constant DAC1_DAC_CR              \ DAC control register
  $04 constant DAC1_DAC_SWTRGR          \ DAC software trigger register
  $08 constant DAC1_DAC_DHR12R1         \ DAC channel1 12-bit right-aligned data holding register
  $0C constant DAC1_DAC_DHR12L1         \ DAC channel1 12-bit left aligned data holding register
  $10 constant DAC1_DAC_DHR8R1          \ DAC channel1 8-bit right aligned data holding register
  $14 constant DAC1_DAC_DHR12R2         \ This register is available only on dual-channel DACs. Refer to Section29.3: DAC implementation.
  $18 constant DAC1_DAC_DHR12L2         \ This register is available only on dual-channel DACs. Refer to Section29.3: DAC implementation.
  $1C constant DAC1_DAC_DHR8R2          \ This register is available only on dual-channel DACs. Refer to Section29.3: DAC implementation.
  $20 constant DAC1_DAC_DHR12RD         \ Dual DAC 12-bit right-aligned data holding register
  $24 constant DAC1_DAC_DHR12LD         \ Dual DAC 12-bit left aligned data holding register
  $28 constant DAC1_DAC_DHR8RD          \ Dual DAC 8-bit right aligned data holding register
  $2C constant DAC1_DAC_DOR1            \ DAC channel1 data output register
  $30 constant DAC1_DAC_DOR2            \ This register is available only on dual-channel DACs. Refer to Section29.3: DAC implementation.
  $34 constant DAC1_DAC_SR              \ DAC status register
  $38 constant DAC1_DAC_CCR             \ DAC calibration control register
  $3C constant DAC1_DAC_MCR             \ DAC mode control register
  $40 constant DAC1_DAC_SHSR1           \ DAC channel 1 sample and hold sample time register
  $44 constant DAC1_DAC_SHSR2           \ This register is available only on dual-channel DACs. Refer to Section29.3: DAC implementation.
  $48 constant DAC1_DAC_SHHR            \ DAC sample and hold time register
  $4C constant DAC1_DAC_SHRR            \ DAC sample and hold refresh time register
  $3F0 constant DAC1_DAC_HWCFGR0        \ DAC IP hardware configuration register
  $3F4 constant DAC1_DAC_VERR           \ No
  $3F8 constant DAC1_DAC_IPIDR          \ No
  $3FC constant DAC1_DAC_SIDR           \ No

: DAC1_DEF ; [then]
