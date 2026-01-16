\
\ @file sai2.fs
\ @brief SAI2 global interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Global configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant SAI2_GCR_SYNCIN                                  \ Synchronization inputs
$00000030 constant SAI2_GCR_SYNCOUT                                 \ Synchronization outputs


\
\ @brief AConfiguration register 1
\ Address offset: 0x04
\ Reset value: 0x00000040
\

$00000003 constant SAI2_ACR1_MODE                                   \ Audio block mode
$0000000c constant SAI2_ACR1_PRTCFG                                 \ Protocol configuration
$000000e0 constant SAI2_ACR1_DS                                     \ Data size
$00000100 constant SAI2_ACR1_LSBFIRST                               \ Least significant bit first
$00000200 constant SAI2_ACR1_CKSTR                                  \ Clock strobing edge
$00000c00 constant SAI2_ACR1_SYNCEN                                 \ Synchronization enable
$00001000 constant SAI2_ACR1_MONO                                   \ Mono mode
$00002000 constant SAI2_ACR1_OUTDRI                                 \ Output drive
$00010000 constant SAI2_ACR1_SAIAEN                                 \ Audio block A enable
$00020000 constant SAI2_ACR1_DMAEN                                  \ DMA enable
$00080000 constant SAI2_ACR1_NODIV                                  \ No divider
$00f00000 constant SAI2_ACR1_MCJDIV                                 \ Master clock divider


\
\ @brief AConfiguration register 2
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant SAI2_ACR2_FTH                                    \ FIFO threshold
$00000008 constant SAI2_ACR2_FFLUS                                  \ FIFO flush
$00000010 constant SAI2_ACR2_TRIS                                   \ Tristate management on data line
$00000020 constant SAI2_ACR2_MUTE                                   \ Mute
$00000040 constant SAI2_ACR2_MUTEVAL                                \ Mute value
$00001f80 constant SAI2_ACR2_MUTECN                                 \ Mute counter
$00002000 constant SAI2_ACR2_CPL                                    \ Complement bit
$0000c000 constant SAI2_ACR2_COMP                                   \ Companding mode


\
\ @brief AFRCR
\ Address offset: 0x0C
\ Reset value: 0x00000007
\

$000000ff constant SAI2_AFRCR_FRL                                   \ Frame length
$00007f00 constant SAI2_AFRCR_FSALL                                 \ Frame synchronization active level length
$00010000 constant SAI2_AFRCR_FSDEF                                 \ Frame synchronization definition
$00020000 constant SAI2_AFRCR_FSPOL                                 \ Frame synchronization polarity
$00040000 constant SAI2_AFRCR_FSOFF                                 \ Frame synchronization offset


\
\ @brief ASlot register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000001f constant SAI2_ASLOTR_FBOFF                                \ First bit offset
$000000c0 constant SAI2_ASLOTR_SLOTSZ                               \ Slot size
$00000f00 constant SAI2_ASLOTR_NBSLOT                               \ Number of slots in an audio frame
$ffff0000 constant SAI2_ASLOTR_SLOTEN                               \ Slot enable


\
\ @brief AInterrupt mask register2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SAI2_AIM_OVRUDRIE                                \ Overrun/underrun interrupt enable
$00000002 constant SAI2_AIM_MUTEDET                                 \ Mute detection interrupt enable
$00000004 constant SAI2_AIM_WCKCFG                                  \ Wrong clock configuration interrupt enable
$00000008 constant SAI2_AIM_FREQIE                                  \ FIFO request interrupt enable
$00000010 constant SAI2_AIM_CNRDYIE                                 \ Codec not ready interrupt enable
$00000020 constant SAI2_AIM_AFSDETIE                                \ Anticipated frame synchronization detection interrupt enable
$00000040 constant SAI2_AIM_LFSDET                                  \ Late frame synchronization detection interrupt enable


\
\ @brief AStatus register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SAI2_ASR_OVRUDR                                  \ Overrun / underrun
$00000002 constant SAI2_ASR_MUTEDET                                 \ Mute detection
$00000004 constant SAI2_ASR_WCKCFG                                  \ Wrong clock configuration flag. This bit is read only.
$00000008 constant SAI2_ASR_FREQ                                    \ FIFO request
$00000010 constant SAI2_ASR_CNRDY                                   \ Codec not ready
$00000020 constant SAI2_ASR_AFSDET                                  \ Anticipated frame synchronization detection
$00000040 constant SAI2_ASR_LFSDET                                  \ Late frame synchronization detection
$00070000 constant SAI2_ASR_FLVL                                    \ FIFO level threshold


\
\ @brief AClear flag register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SAI2_ACLRFR_OVRUDR                               \ Clear overrun / underrun
$00000002 constant SAI2_ACLRFR_MUTEDET                              \ Mute detection flag
$00000004 constant SAI2_ACLRFR_WCKCFG                               \ Clear wrong clock configuration flag
$00000010 constant SAI2_ACLRFR_CNRDY                                \ Clear codec not ready flag
$00000020 constant SAI2_ACLRFR_CAFSDET                              \ Clear anticipated frame synchronization detection flag.
$00000040 constant SAI2_ACLRFR_LFSDET                               \ Clear late frame synchronization detection flag


\
\ @brief AData register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SAI2_ADR_DATA                                    \ Data


\
\ @brief BConfiguration register 1
\ Address offset: 0x24
\ Reset value: 0x00000040
\

$00000003 constant SAI2_BCR1_MODE                                   \ Audio block mode
$0000000c constant SAI2_BCR1_PRTCFG                                 \ Protocol configuration
$000000e0 constant SAI2_BCR1_DS                                     \ Data size
$00000100 constant SAI2_BCR1_LSBFIRST                               \ Least significant bit first
$00000200 constant SAI2_BCR1_CKSTR                                  \ Clock strobing edge
$00000c00 constant SAI2_BCR1_SYNCEN                                 \ Synchronization enable
$00001000 constant SAI2_BCR1_MONO                                   \ Mono mode
$00002000 constant SAI2_BCR1_OUTDRI                                 \ Output drive
$00010000 constant SAI2_BCR1_SAIBEN                                 \ Audio block B enable
$00020000 constant SAI2_BCR1_DMAEN                                  \ DMA enable
$00080000 constant SAI2_BCR1_NODIV                                  \ No divider
$00f00000 constant SAI2_BCR1_MCJDIV                                 \ Master clock divider


\
\ @brief BConfiguration register 2
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000007 constant SAI2_BCR2_FTH                                    \ FIFO threshold
$00000008 constant SAI2_BCR2_FFLUS                                  \ FIFO flush
$00000010 constant SAI2_BCR2_TRIS                                   \ Tristate management on data line
$00000020 constant SAI2_BCR2_MUTE                                   \ Mute
$00000040 constant SAI2_BCR2_MUTEVAL                                \ Mute value
$00001f80 constant SAI2_BCR2_MUTECN                                 \ Mute counter
$00002000 constant SAI2_BCR2_CPL                                    \ Complement bit
$0000c000 constant SAI2_BCR2_COMP                                   \ Companding mode


\
\ @brief BFRCR
\ Address offset: 0x2C
\ Reset value: 0x00000007
\

$000000ff constant SAI2_BFRCR_FRL                                   \ Frame length
$00007f00 constant SAI2_BFRCR_FSALL                                 \ Frame synchronization active level length
$00010000 constant SAI2_BFRCR_FSDEF                                 \ Frame synchronization definition
$00020000 constant SAI2_BFRCR_FSPOL                                 \ Frame synchronization polarity
$00040000 constant SAI2_BFRCR_FSOFF                                 \ Frame synchronization offset


\
\ @brief BSlot register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000001f constant SAI2_BSLOTR_FBOFF                                \ First bit offset
$000000c0 constant SAI2_BSLOTR_SLOTSZ                               \ Slot size
$00000f00 constant SAI2_BSLOTR_NBSLOT                               \ Number of slots in an audio frame
$ffff0000 constant SAI2_BSLOTR_SLOTEN                               \ Slot enable


\
\ @brief BInterrupt mask register2
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant SAI2_BIM_OVRUDRIE                                \ Overrun/underrun interrupt enable
$00000002 constant SAI2_BIM_MUTEDET                                 \ Mute detection interrupt enable
$00000004 constant SAI2_BIM_WCKCFG                                  \ Wrong clock configuration interrupt enable
$00000008 constant SAI2_BIM_FREQIE                                  \ FIFO request interrupt enable
$00000010 constant SAI2_BIM_CNRDYIE                                 \ Codec not ready interrupt enable
$00000020 constant SAI2_BIM_AFSDETIE                                \ Anticipated frame synchronization detection interrupt enable
$00000040 constant SAI2_BIM_LFSDETIE                                \ Late frame synchronization detection interrupt enable


\
\ @brief BStatus register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant SAI2_BSR_OVRUDR                                  \ Overrun / underrun
$00000002 constant SAI2_BSR_MUTEDET                                 \ Mute detection
$00000004 constant SAI2_BSR_WCKCFG                                  \ Wrong clock configuration flag
$00000008 constant SAI2_BSR_FREQ                                    \ FIFO request
$00000010 constant SAI2_BSR_CNRDY                                   \ Codec not ready
$00000020 constant SAI2_BSR_AFSDET                                  \ Anticipated frame synchronization detection
$00000040 constant SAI2_BSR_LFSDET                                  \ Late frame synchronization detection
$00070000 constant SAI2_BSR_FLVL                                    \ FIFO level threshold


\
\ @brief BClear flag register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant SAI2_BCLRFR_OVRUDR                               \ Clear overrun / underrun
$00000002 constant SAI2_BCLRFR_MUTEDET                              \ Mute detection flag
$00000004 constant SAI2_BCLRFR_WCKCFG                               \ Clear wrong clock configuration flag
$00000010 constant SAI2_BCLRFR_CNRDY                                \ Clear codec not ready flag
$00000020 constant SAI2_BCLRFR_CAFSDET                              \ Clear anticipated frame synchronization detection flag
$00000040 constant SAI2_BCLRFR_LFSDET                               \ Clear late frame synchronization detection flag


\
\ @brief BData register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant SAI2_BDR_DATA                                    \ Data


\
\ @brief SAI2 global interrupt
\
$40015c00 constant SAI2_GCR       \ offset: 0x00 : Global configuration register
$40015c04 constant SAI2_ACR1      \ offset: 0x04 : AConfiguration register 1
$40015c08 constant SAI2_ACR2      \ offset: 0x08 : AConfiguration register 2
$40015c0c constant SAI2_AFRCR     \ offset: 0x0C : AFRCR
$40015c10 constant SAI2_ASLOTR    \ offset: 0x10 : ASlot register
$40015c14 constant SAI2_AIM       \ offset: 0x14 : AInterrupt mask register2
$40015c18 constant SAI2_ASR       \ offset: 0x18 : AStatus register
$40015c1c constant SAI2_ACLRFR    \ offset: 0x1C : AClear flag register
$40015c20 constant SAI2_ADR       \ offset: 0x20 : AData register
$40015c24 constant SAI2_BCR1      \ offset: 0x24 : BConfiguration register 1
$40015c28 constant SAI2_BCR2      \ offset: 0x28 : BConfiguration register 2
$40015c2c constant SAI2_BFRCR     \ offset: 0x2C : BFRCR
$40015c30 constant SAI2_BSLOTR    \ offset: 0x30 : BSlot register
$40015c34 constant SAI2_BIM       \ offset: 0x34 : BInterrupt mask register2
$40015c38 constant SAI2_BSR       \ offset: 0x38 : BStatus register
$40015c3c constant SAI2_BCLRFR    \ offset: 0x3C : BClear flag register
$40015c40 constant SAI2_BDR       \ offset: 0x40 : BData register

