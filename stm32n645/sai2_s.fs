\
\ @file sai2_s.fs
\ @brief Serial audio interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SAI global configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant SAI2_S_SAI_GCR_SYNCIN                            \ Synchronization outputs
$00000030 constant SAI2_S_SAI_GCR_SYNCOUT                           \ Synchronization outputs


\
\ @brief SAI configuration register 1
\ Address offset: 0x04
\ Reset value: 0x00000040
\

$00000003 constant SAI2_S_SAI_ACR1_MODE                             \ SAIx audio block mode
$0000000c constant SAI2_S_SAI_ACR1_PRTCFG                           \ Protocol configuration
$000000e0 constant SAI2_S_SAI_ACR1_DS                               \ Data size
$00000100 constant SAI2_S_SAI_ACR1_LSBFIRST                         \ Least significant bit first
$00000200 constant SAI2_S_SAI_ACR1_CKSTR                            \ Clock strobing edge
$00000c00 constant SAI2_S_SAI_ACR1_SYNCEN                           \ Synchronization enable
$00001000 constant SAI2_S_SAI_ACR1_MONO                             \ Mono mode
$00002000 constant SAI2_S_SAI_ACR1_OUTDRIV                          \ Output drive
$00010000 constant SAI2_S_SAI_ACR1_SAIEN                            \ Audio block enable
$00020000 constant SAI2_S_SAI_ACR1_DMAEN                            \ DMA enable
$00080000 constant SAI2_S_SAI_ACR1_NODIV                            \ No divider
$03f00000 constant SAI2_S_SAI_ACR1_MCKDIV                           \ Master clock divider
$04000000 constant SAI2_S_SAI_ACR1_OSR                              \ Oversampling ratio for master clock
$08000000 constant SAI2_S_SAI_ACR1_MCKEN                            \ Master clock generation enable


\
\ @brief SAI configuration register 2
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant SAI2_S_SAI_ACR2_FTH                              \ FIFO threshold.
$00000008 constant SAI2_S_SAI_ACR2_FFLUSH                           \ FIFO flush.
$00000010 constant SAI2_S_SAI_ACR2_TRIS                             \ Tristate management on data line.
$00000020 constant SAI2_S_SAI_ACR2_MUTE                             \ Mute.
$00000040 constant SAI2_S_SAI_ACR2_MUTEVAL                          \ Mute value.
$00001f80 constant SAI2_S_SAI_ACR2_MUTECNT                          \ Mute counter.
$00002000 constant SAI2_S_SAI_ACR2_CPL                              \ Complement bit.
$0000c000 constant SAI2_S_SAI_ACR2_COMP                             \ Companding mode.


\
\ @brief SAI frame configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000007
\

$000000ff constant SAI2_S_SAI_AFRCR_FRL                             \ Frame length.
$00007f00 constant SAI2_S_SAI_AFRCR_FSALL                           \ Frame synchronization active level length.
$00010000 constant SAI2_S_SAI_AFRCR_FSDEF                           \ Frame synchronization definition.
$00020000 constant SAI2_S_SAI_AFRCR_FSPOL                           \ Frame synchronization polarity.
$00040000 constant SAI2_S_SAI_AFRCR_FSOFF                           \ Frame synchronization offset.


\
\ @brief SAI slot register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000001f constant SAI2_S_SAI_ASLOTR_FBOFF                          \ First bit offset
$000000c0 constant SAI2_S_SAI_ASLOTR_SLOTSZ                         \ Slot size
$00000f00 constant SAI2_S_SAI_ASLOTR_NBSLOT                         \ Number of slots in an audio frame.
$ffff0000 constant SAI2_S_SAI_ASLOTR_SLOTEN                         \ Slot enable.


\
\ @brief SAI interrupt mask register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SAI2_S_SAI_AIM_OVRUDRIE                          \ Overrun/underrun interrupt enable.
$00000002 constant SAI2_S_SAI_AIM_MUTEDETIE                         \ Mute detection interrupt enable.
$00000004 constant SAI2_S_SAI_AIM_WCKCFGIE                          \ Wrong clock configuration interrupt enable.
$00000008 constant SAI2_S_SAI_AIM_FREQIE                            \ FIFO request interrupt enable.
$00000010 constant SAI2_S_SAI_AIM_CNRDYIE                           \ Codec not ready interrupt enable (AC'97).
$00000020 constant SAI2_S_SAI_AIM_AFSDETIE                          \ Anticipated frame synchronization detection interrupt enable.
$00000040 constant SAI2_S_SAI_AIM_LFSDETIE                          \ Late frame synchronization detection interrupt enable.


\
\ @brief SAI status register
\ Address offset: 0x18
\ Reset value: 0x00000008
\

$00000001 constant SAI2_S_SAI_ASR_OVRUDR                            \ Overrun / underrun.
$00000002 constant SAI2_S_SAI_ASR_MUTEDET                           \ Mute detection.
$00000004 constant SAI2_S_SAI_ASR_WCKCFG                            \ Wrong clock configuration flag.
$00000008 constant SAI2_S_SAI_ASR_FREQ                              \ FIFO request.
$00000010 constant SAI2_S_SAI_ASR_CNRDY                             \ Codec not ready.
$00000020 constant SAI2_S_SAI_ASR_AFSDET                            \ Anticipated frame synchronization detection.
$00000040 constant SAI2_S_SAI_ASR_LFSDET                            \ Late frame synchronization detection.
$00070000 constant SAI2_S_SAI_ASR_FLVL                              \ FIFO level threshold.


\
\ @brief SAI clear flag register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SAI2_S_SAI_ACLRFR_COVRUDR                        \ Clear overrun / underrun.
$00000002 constant SAI2_S_SAI_ACLRFR_CMUTEDET                       \ Mute detection flag.
$00000004 constant SAI2_S_SAI_ACLRFR_CWCKCFG                        \ Clear wrong clock configuration flag.
$00000010 constant SAI2_S_SAI_ACLRFR_CCNRDY                         \ Clear Codec not ready flag.
$00000020 constant SAI2_S_SAI_ACLRFR_CAFSDET                        \ Clear anticipated frame synchronization detection flag.
$00000040 constant SAI2_S_SAI_ACLRFR_CLFSDET                        \ Clear late frame synchronization detection flag.


\
\ @brief SAI data register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SAI2_S_SAI_ADR_DATA                              \ Data


\
\ @brief SAI configuration register 1
\ Address offset: 0x24
\ Reset value: 0x00000040
\

$00000003 constant SAI2_S_SAI_BCR1_MODE                             \ SAIx audio block mode
$0000000c constant SAI2_S_SAI_BCR1_PRTCFG                           \ Protocol configuration
$000000e0 constant SAI2_S_SAI_BCR1_DS                               \ Data size
$00000100 constant SAI2_S_SAI_BCR1_LSBFIRST                         \ Least significant bit first
$00000200 constant SAI2_S_SAI_BCR1_CKSTR                            \ Clock strobing edge
$00000c00 constant SAI2_S_SAI_BCR1_SYNCEN                           \ Synchronization enable
$00001000 constant SAI2_S_SAI_BCR1_MONO                             \ Mono mode
$00002000 constant SAI2_S_SAI_BCR1_OUTDRIV                          \ Output drive
$00010000 constant SAI2_S_SAI_BCR1_SAIEN                            \ Audio block enable
$00020000 constant SAI2_S_SAI_BCR1_DMAEN                            \ DMA enable
$00080000 constant SAI2_S_SAI_BCR1_NODIV                            \ No divider
$03f00000 constant SAI2_S_SAI_BCR1_MCKDIV                           \ Master clock divider
$04000000 constant SAI2_S_SAI_BCR1_OSR                              \ Oversampling ratio for master clock
$08000000 constant SAI2_S_SAI_BCR1_MCKEN                            \ Master clock generation enable


\
\ @brief SAI configuration register 2
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000007 constant SAI2_S_SAI_BCR2_FTH                              \ FIFO threshold.
$00000008 constant SAI2_S_SAI_BCR2_FFLUSH                           \ FIFO flush.
$00000010 constant SAI2_S_SAI_BCR2_TRIS                             \ Tristate management on data line.
$00000020 constant SAI2_S_SAI_BCR2_MUTE                             \ Mute.
$00000040 constant SAI2_S_SAI_BCR2_MUTEVAL                          \ Mute value.
$00001f80 constant SAI2_S_SAI_BCR2_MUTECNT                          \ Mute counter.
$00002000 constant SAI2_S_SAI_BCR2_CPL                              \ Complement bit.
$0000c000 constant SAI2_S_SAI_BCR2_COMP                             \ Companding mode.


\
\ @brief SAI frame configuration register
\ Address offset: 0x2C
\ Reset value: 0x00000007
\

$000000ff constant SAI2_S_SAI_BFRCR_FRL                             \ Frame length.
$00007f00 constant SAI2_S_SAI_BFRCR_FSALL                           \ Frame synchronization active level length.
$00010000 constant SAI2_S_SAI_BFRCR_FSDEF                           \ Frame synchronization definition.
$00020000 constant SAI2_S_SAI_BFRCR_FSPOL                           \ Frame synchronization polarity.
$00040000 constant SAI2_S_SAI_BFRCR_FSOFF                           \ Frame synchronization offset.


\
\ @brief SAI slot register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000001f constant SAI2_S_SAI_BSLOTR_FBOFF                          \ First bit offset
$000000c0 constant SAI2_S_SAI_BSLOTR_SLOTSZ                         \ Slot size
$00000f00 constant SAI2_S_SAI_BSLOTR_NBSLOT                         \ Number of slots in an audio frame.
$ffff0000 constant SAI2_S_SAI_BSLOTR_SLOTEN                         \ Slot enable.


\
\ @brief SAI interrupt mask register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant SAI2_S_SAI_BIM_OVRUDRIE                          \ Overrun/underrun interrupt enable.
$00000002 constant SAI2_S_SAI_BIM_MUTEDETIE                         \ Mute detection interrupt enable.
$00000004 constant SAI2_S_SAI_BIM_WCKCFGIE                          \ Wrong clock configuration interrupt enable.
$00000008 constant SAI2_S_SAI_BIM_FREQIE                            \ FIFO request interrupt enable.
$00000010 constant SAI2_S_SAI_BIM_CNRDYIE                           \ Codec not ready interrupt enable (AC'97).
$00000020 constant SAI2_S_SAI_BIM_AFSDETIE                          \ Anticipated frame synchronization detection interrupt enable.
$00000040 constant SAI2_S_SAI_BIM_LFSDETIE                          \ Late frame synchronization detection interrupt enable.


\
\ @brief SAI status register
\ Address offset: 0x38
\ Reset value: 0x00000008
\

$00000001 constant SAI2_S_SAI_BSR_OVRUDR                            \ Overrun / underrun.
$00000002 constant SAI2_S_SAI_BSR_MUTEDET                           \ Mute detection.
$00000004 constant SAI2_S_SAI_BSR_WCKCFG                            \ Wrong clock configuration flag.
$00000008 constant SAI2_S_SAI_BSR_FREQ                              \ FIFO request.
$00000010 constant SAI2_S_SAI_BSR_CNRDY                             \ Codec not ready.
$00000020 constant SAI2_S_SAI_BSR_AFSDET                            \ Anticipated frame synchronization detection.
$00000040 constant SAI2_S_SAI_BSR_LFSDET                            \ Late frame synchronization detection.
$00070000 constant SAI2_S_SAI_BSR_FLVL                              \ FIFO level threshold.


\
\ @brief SAI clear flag register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant SAI2_S_SAI_BCLRFR_COVRUDR                        \ Clear overrun / underrun.
$00000002 constant SAI2_S_SAI_BCLRFR_CMUTEDET                       \ Mute detection flag.
$00000004 constant SAI2_S_SAI_BCLRFR_CWCKCFG                        \ Clear wrong clock configuration flag.
$00000010 constant SAI2_S_SAI_BCLRFR_CCNRDY                         \ Clear Codec not ready flag.
$00000020 constant SAI2_S_SAI_BCLRFR_CAFSDET                        \ Clear anticipated frame synchronization detection flag.
$00000040 constant SAI2_S_SAI_BCLRFR_CLFSDET                        \ Clear late frame synchronization detection flag.


\
\ @brief SAI data register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant SAI2_S_SAI_BDR_DATA                              \ Data


\
\ @brief SAI PDM control register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant SAI2_S_SAI_PDMCR_PDMEN                           \ PDM enable
$00000030 constant SAI2_S_SAI_PDMCR_MICNBR                          \ Number of microphones
$00000100 constant SAI2_S_SAI_PDMCR_CKEN1                           \ Clock enable of bitstream clock number 1
$00000200 constant SAI2_S_SAI_PDMCR_CKEN2                           \ Clock enable of bitstream clock number 2


\
\ @brief SAI PDM delay register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000007 constant SAI2_S_SAI_PDMDLY_DLYM1L                         \ Delay line adjust for first microphone of pair 1
$00000070 constant SAI2_S_SAI_PDMDLY_DLYM1R                         \ Delay line adjust for second microphone of pair 1
$00000700 constant SAI2_S_SAI_PDMDLY_DLYM2L                         \ Delay line for first microphone of pair 2
$00007000 constant SAI2_S_SAI_PDMDLY_DLYM2R                         \ Delay line for second microphone of pair 2
$00070000 constant SAI2_S_SAI_PDMDLY_DLYM3L                         \ Delay line for first microphone of pair 3
$00700000 constant SAI2_S_SAI_PDMDLY_DLYM3R                         \ Delay line for second microphone of pair 3
$07000000 constant SAI2_S_SAI_PDMDLY_DLYM4L                         \ Delay line for first microphone of pair 4
$70000000 constant SAI2_S_SAI_PDMDLY_DLYM4R                         \ Delay line for second microphone of pair 4


\
\ @brief Serial audio interface
\
$52005c00 constant SAI2_S_SAI_GCR  \ offset: 0x00 : SAI global configuration register
$52005c04 constant SAI2_S_SAI_ACR1  \ offset: 0x04 : SAI configuration register 1
$52005c08 constant SAI2_S_SAI_ACR2  \ offset: 0x08 : SAI configuration register 2
$52005c0c constant SAI2_S_SAI_AFRCR  \ offset: 0x0C : SAI frame configuration register
$52005c10 constant SAI2_S_SAI_ASLOTR  \ offset: 0x10 : SAI slot register
$52005c14 constant SAI2_S_SAI_AIM  \ offset: 0x14 : SAI interrupt mask register
$52005c18 constant SAI2_S_SAI_ASR  \ offset: 0x18 : SAI status register
$52005c1c constant SAI2_S_SAI_ACLRFR  \ offset: 0x1C : SAI clear flag register
$52005c20 constant SAI2_S_SAI_ADR  \ offset: 0x20 : SAI data register
$52005c24 constant SAI2_S_SAI_BCR1  \ offset: 0x24 : SAI configuration register 1
$52005c28 constant SAI2_S_SAI_BCR2  \ offset: 0x28 : SAI configuration register 2
$52005c2c constant SAI2_S_SAI_BFRCR  \ offset: 0x2C : SAI frame configuration register
$52005c30 constant SAI2_S_SAI_BSLOTR  \ offset: 0x30 : SAI slot register
$52005c34 constant SAI2_S_SAI_BIM  \ offset: 0x34 : SAI interrupt mask register
$52005c38 constant SAI2_S_SAI_BSR  \ offset: 0x38 : SAI status register
$52005c3c constant SAI2_S_SAI_BCLRFR  \ offset: 0x3C : SAI clear flag register
$52005c40 constant SAI2_S_SAI_BDR  \ offset: 0x40 : SAI data register
$52005c44 constant SAI2_S_SAI_PDMCR  \ offset: 0x44 : SAI PDM control register
$52005c48 constant SAI2_S_SAI_PDMDLY  \ offset: 0x48 : SAI PDM delay register

