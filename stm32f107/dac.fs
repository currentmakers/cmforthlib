\
\ @file dac.fs
\ @brief Digital to analog converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Control register (DAC_CR)
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DAC_CR_EN1                                       \ DAC channel1 enable
$00000002 constant DAC_CR_BOFF1                                     \ DAC channel1 output buffer disable
$00000004 constant DAC_CR_TEN1                                      \ DAC channel1 trigger enable
$00000038 constant DAC_CR_TSEL1                                     \ DAC channel1 trigger selection
$000000c0 constant DAC_CR_WAVE1                                     \ DAC channel1 noise/triangle wave generation enable
$00000f00 constant DAC_CR_MAMP1                                     \ DAC channel1 mask/amplitude selector
$00001000 constant DAC_CR_DMAEN1                                    \ DAC channel1 DMA enable
$00010000 constant DAC_CR_EN2                                       \ DAC channel2 enable
$00020000 constant DAC_CR_BOFF2                                     \ DAC channel2 output buffer disable
$00040000 constant DAC_CR_TEN2                                      \ DAC channel2 trigger enable
$00380000 constant DAC_CR_TSEL2                                     \ DAC channel2 trigger selection
$00c00000 constant DAC_CR_WAVE2                                     \ DAC channel2 noise/triangle wave generation enable
$0f000000 constant DAC_CR_MAMP2                                     \ DAC channel2 mask/amplitude selector
$10000000 constant DAC_CR_DMAEN2                                    \ DAC channel2 DMA enable


\
\ @brief DAC software trigger register (DAC_SWTRIGR)
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DAC_SWTRIGR_SWTRIG1                              \ DAC channel1 software trigger
$00000002 constant DAC_SWTRIGR_SWTRIG2                              \ DAC channel2 software trigger


\
\ @brief DAC channel1 12-bit right-aligned data holding register(DAC_DHR12R1)
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000fff constant DAC_DHR12R1_DACC1DHR                             \ DAC channel1 12-bit right-aligned data


\
\ @brief DAC channel1 12-bit left aligned data holding register (DAC_DHR12L1)
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000fff0 constant DAC_DHR12L1_DACC1DHR                             \ DAC channel1 12-bit left-aligned data


\
\ @brief DAC channel1 8-bit right aligned data holding register (DAC_DHR8R1)
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant DAC_DHR8R1_DACC1DHR                              \ DAC channel1 8-bit right-aligned data


\
\ @brief DAC channel2 12-bit right aligned data holding register (DAC_DHR12R2)
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000fff constant DAC_DHR12R2_DACC2DHR                             \ DAC channel2 12-bit right-aligned data


\
\ @brief DAC channel2 12-bit left aligned data holding register (DAC_DHR12L2)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000fff0 constant DAC_DHR12L2_DACC2DHR                             \ DAC channel2 12-bit left-aligned data


\
\ @brief DAC channel2 8-bit right-aligned data holding register (DAC_DHR8R2)
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000000ff constant DAC_DHR8R2_DACC2DHR                              \ DAC channel2 8-bit right-aligned data


\
\ @brief Dual DAC 12-bit right-aligned data holding register (DAC_DHR12RD), Bits 31:28 Reserved, Bits 15:12 Reserved
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000fff constant DAC_DHR12RD_DACC1DHR                             \ DAC channel1 12-bit right-aligned data
$0fff0000 constant DAC_DHR12RD_DACC2DHR                             \ DAC channel2 12-bit right-aligned data


\
\ @brief DUAL DAC 12-bit left aligned data holding register (DAC_DHR12LD), Bits 19:16 Reserved, Bits 3:0 Reserved
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000fff0 constant DAC_DHR12LD_DACC1DHR                             \ DAC channel1 12-bit left-aligned data
$fff00000 constant DAC_DHR12LD_DACC2DHR                             \ DAC channel2 12-bit right-aligned data


\
\ @brief DUAL DAC 8-bit right aligned data holding register (DAC_DHR8RD), Bits 31:16 Reserved
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant DAC_DHR8RD_DACC1DHR                              \ DAC channel1 8-bit right-aligned data
$0000ff00 constant DAC_DHR8RD_DACC2DHR                              \ DAC channel2 8-bit right-aligned data


\
\ @brief DAC channel1 data output register (DAC_DOR1)
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000fff constant DAC_DOR1_DACC1DOR                                \ DAC channel1 data output


\
\ @brief DAC channel2 data output register (DAC_DOR2)
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000fff constant DAC_DOR2_DACC2DOR                                \ DAC channel2 data output


\
\ @brief Digital to analog converter
\
$40007400 constant DAC_CR         \ offset: 0x00 : Control register (DAC_CR)
$40007404 constant DAC_SWTRIGR    \ offset: 0x04 : DAC software trigger register (DAC_SWTRIGR)
$40007408 constant DAC_DHR12R1    \ offset: 0x08 : DAC channel1 12-bit right-aligned data holding register(DAC_DHR12R1)
$4000740c constant DAC_DHR12L1    \ offset: 0x0C : DAC channel1 12-bit left aligned data holding register (DAC_DHR12L1)
$40007410 constant DAC_DHR8R1     \ offset: 0x10 : DAC channel1 8-bit right aligned data holding register (DAC_DHR8R1)
$40007414 constant DAC_DHR12R2    \ offset: 0x14 : DAC channel2 12-bit right aligned data holding register (DAC_DHR12R2)
$40007418 constant DAC_DHR12L2    \ offset: 0x18 : DAC channel2 12-bit left aligned data holding register (DAC_DHR12L2)
$4000741c constant DAC_DHR8R2     \ offset: 0x1C : DAC channel2 8-bit right-aligned data holding register (DAC_DHR8R2)
$40007420 constant DAC_DHR12RD    \ offset: 0x20 : Dual DAC 12-bit right-aligned data holding register (DAC_DHR12RD), Bits 31:28 Reserved, Bits 15:12 Reserved
$40007424 constant DAC_DHR12LD    \ offset: 0x24 : DUAL DAC 12-bit left aligned data holding register (DAC_DHR12LD), Bits 19:16 Reserved, Bits 3:0 Reserved
$40007428 constant DAC_DHR8RD     \ offset: 0x28 : DUAL DAC 8-bit right aligned data holding register (DAC_DHR8RD), Bits 31:16 Reserved
$4000742c constant DAC_DOR1       \ offset: 0x2C : DAC channel1 data output register (DAC_DOR1)
$40007430 constant DAC_DOR2       \ offset: 0x30 : DAC channel2 data output register (DAC_DOR2)

