\
\ @file sai1.fs
\ @brief SAI1 register block
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

$00000003 constant SAI1_SAI_GCR_SYNCIN                              \ SYNCIN
$00000030 constant SAI1_SAI_GCR_SYNCOUT                             \ SYNCOUT


\
\ @brief Configuration register 1
\ Address offset: 0x04
\ Reset value: 0x00000040
\

$00000003 constant SAI1_SAI_ACR1_MODE                               \ MODE
$0000000c constant SAI1_SAI_ACR1_PRTCFG                             \ PRTCFG
$000000e0 constant SAI1_SAI_ACR1_DS                                 \ DS
$00000100 constant SAI1_SAI_ACR1_LSBFIRST                           \ LSBFIRST
$00000200 constant SAI1_SAI_ACR1_CKSTR                              \ CKSTR
$00000c00 constant SAI1_SAI_ACR1_SYNCEN                             \ SYNCEN
$00001000 constant SAI1_SAI_ACR1_MONO                               \ MONO
$00002000 constant SAI1_SAI_ACR1_OUTDRIV                            \ OUTDRIV
$00010000 constant SAI1_SAI_ACR1_SAIEN                              \ SAIEN
$00020000 constant SAI1_SAI_ACR1_DMAEN                              \ DMAEN
$00080000 constant SAI1_SAI_ACR1_NODIV                              \ NODIV
$03f00000 constant SAI1_SAI_ACR1_MCKDIV                             \ MCKDIV
$04000000 constant SAI1_SAI_ACR1_OSR                                \ OSR
$08000000 constant SAI1_SAI_ACR1_MCKEN                              \ MCKEN


\
\ @brief Configuration register 2
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant SAI1_SAI_ACR2_FTH                                \ FTH
$00000008 constant SAI1_SAI_ACR2_FFLUSH                             \ FFLUSH
$00000010 constant SAI1_SAI_ACR2_TRIS                               \ TRIS
$00000020 constant SAI1_SAI_ACR2_MUTE                               \ MUTE
$00000040 constant SAI1_SAI_ACR2_MUTEVAL                            \ MUTEVAL
$00001f80 constant SAI1_SAI_ACR2_MUTECNT                            \ MUTECNT
$00002000 constant SAI1_SAI_ACR2_CPL                                \ CPL
$0000c000 constant SAI1_SAI_ACR2_COMP                               \ COMP


\
\ @brief This register has no meaning in and SPDIF audio protocol
\ Address offset: 0x0C
\ Reset value: 0x00000007
\

$000000ff constant SAI1_SAI_AFRCR_FRL                               \ FRL
$00007f00 constant SAI1_SAI_AFRCR_FSALL                             \ FSALL
$00010000 constant SAI1_SAI_AFRCR_FSDEF                             \ FSDEF
$00020000 constant SAI1_SAI_AFRCR_FSPOL                             \ FSPOL
$00040000 constant SAI1_SAI_AFRCR_FSOFF                             \ FSOFF


\
\ @brief This register has no meaning in and SPDIF audio protocol
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000001f constant SAI1_SAI_ASLOTR_FBOFF                            \ FBOFF
$000000c0 constant SAI1_SAI_ASLOTR_SLOTSZ                           \ SLOTSZ
$00000f00 constant SAI1_SAI_ASLOTR_NBSLOT                           \ NBSLOT
$ffff0000 constant SAI1_SAI_ASLOTR_SLOTEN                           \ SLOTEN


\
\ @brief Interrupt mask register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SAI1_SAI_AIM_OVRUDRIE                            \ OVRUDRIE
$00000002 constant SAI1_SAI_AIM_MUTEDETIE                           \ MUTEDETIE
$00000004 constant SAI1_SAI_AIM_WCKCFGIE                            \ WCKCFGIE
$00000008 constant SAI1_SAI_AIM_FREQIE                              \ FREQIE
$00000010 constant SAI1_SAI_AIM_CNRDYIE                             \ CNRDYIE
$00000020 constant SAI1_SAI_AIM_AFSDETIE                            \ AFSDETIE
$00000040 constant SAI1_SAI_AIM_LFSDETIE                            \ LFSDETIE


\
\ @brief Status register
\ Address offset: 0x18
\ Reset value: 0x00000008
\

$00000001 constant SAI1_SAI_ASR_OVRUDR                              \ OVRUDR
$00000002 constant SAI1_SAI_ASR_MUTEDET                             \ MUTEDET
$00000004 constant SAI1_SAI_ASR_WCKCFG                              \ WCKCFG
$00000008 constant SAI1_SAI_ASR_FREQ                                \ FREQ
$00000010 constant SAI1_SAI_ASR_CNRDY                               \ CNRDY
$00000020 constant SAI1_SAI_ASR_AFSDET                              \ AFSDET
$00000040 constant SAI1_SAI_ASR_LFSDET                              \ LFSDET
$00070000 constant SAI1_SAI_ASR_FLVL                                \ FLVL


\
\ @brief Clear flag register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SAI1_SAI_ACLRFR_COVRUDR                          \ COVRUDR
$00000002 constant SAI1_SAI_ACLRFR_CMUTEDET                         \ CMUTEDET
$00000004 constant SAI1_SAI_ACLRFR_CWCKCFG                          \ CWCKCFG
$00000010 constant SAI1_SAI_ACLRFR_CCNRDY                           \ CCNRDY
$00000020 constant SAI1_SAI_ACLRFR_CAFSDET                          \ CAFSDET
$00000040 constant SAI1_SAI_ACLRFR_CLFSDET                          \ CLFSDET


\
\ @brief Data register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SAI1_SAI_ADR_DATA                                \ DATA


\
\ @brief Configuration register 1
\ Address offset: 0x24
\ Reset value: 0x00000040
\

$00000003 constant SAI1_SAI_BCR1_MODE                               \ MODE
$0000000c constant SAI1_SAI_BCR1_PRTCFG                             \ PRTCFG
$000000e0 constant SAI1_SAI_BCR1_DS                                 \ DS
$00000100 constant SAI1_SAI_BCR1_LSBFIRST                           \ LSBFIRST
$00000200 constant SAI1_SAI_BCR1_CKSTR                              \ CKSTR
$00000c00 constant SAI1_SAI_BCR1_SYNCEN                             \ SYNCEN
$00001000 constant SAI1_SAI_BCR1_MONO                               \ MONO
$00002000 constant SAI1_SAI_BCR1_OUTDRIV                            \ OUTDRIV
$00010000 constant SAI1_SAI_BCR1_SAIEN                              \ SAIEN
$00020000 constant SAI1_SAI_BCR1_DMAEN                              \ DMAEN
$00080000 constant SAI1_SAI_BCR1_NODIV                              \ NODIV
$03f00000 constant SAI1_SAI_BCR1_MCKDIV                             \ MCKDIV
$04000000 constant SAI1_SAI_BCR1_OSR                                \ OSR
$08000000 constant SAI1_SAI_BCR1_MCKEN                              \ MCKEN


\
\ @brief Configuration register 2
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000007 constant SAI1_SAI_BCR2_FTH                                \ FTH
$00000008 constant SAI1_SAI_BCR2_FFLUSH                             \ FFLUSH
$00000010 constant SAI1_SAI_BCR2_TRIS                               \ TRIS
$00000020 constant SAI1_SAI_BCR2_MUTE                               \ MUTE
$00000040 constant SAI1_SAI_BCR2_MUTEVAL                            \ MUTEVAL
$00001f80 constant SAI1_SAI_BCR2_MUTECNT                            \ MUTECNT
$00002000 constant SAI1_SAI_BCR2_CPL                                \ CPL
$0000c000 constant SAI1_SAI_BCR2_COMP                               \ COMP


\
\ @brief This register has no meaning in and SPDIF audio protocol
\ Address offset: 0x2C
\ Reset value: 0x00000007
\

$000000ff constant SAI1_SAI_BFRCR_FRL                               \ FRL
$00007f00 constant SAI1_SAI_BFRCR_FSALL                             \ FSALL
$00010000 constant SAI1_SAI_BFRCR_FSDEF                             \ FSDEF
$00020000 constant SAI1_SAI_BFRCR_FSPOL                             \ FSPOL
$00040000 constant SAI1_SAI_BFRCR_FSOFF                             \ FSOFF


\
\ @brief This register has no meaning in and SPDIF audio protocol
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000001f constant SAI1_SAI_BSLOTR_FBOFF                            \ FBOFF
$000000c0 constant SAI1_SAI_BSLOTR_SLOTSZ                           \ SLOTSZ
$00000f00 constant SAI1_SAI_BSLOTR_NBSLOT                           \ NBSLOT
$ffff0000 constant SAI1_SAI_BSLOTR_SLOTEN                           \ SLOTEN


\
\ @brief Interrupt mask register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant SAI1_SAI_BIM_OVRUDRIE                            \ OVRUDRIE
$00000002 constant SAI1_SAI_BIM_MUTEDETIE                           \ MUTEDETIE
$00000004 constant SAI1_SAI_BIM_WCKCFGIE                            \ WCKCFGIE
$00000008 constant SAI1_SAI_BIM_FREQIE                              \ FREQIE
$00000010 constant SAI1_SAI_BIM_CNRDYIE                             \ CNRDYIE
$00000020 constant SAI1_SAI_BIM_AFSDETIE                            \ AFSDETIE
$00000040 constant SAI1_SAI_BIM_LFSDETIE                            \ LFSDETIE


\
\ @brief Status register
\ Address offset: 0x38
\ Reset value: 0x00000008
\

$00000001 constant SAI1_SAI_BSR_OVRUDR                              \ OVRUDR
$00000002 constant SAI1_SAI_BSR_MUTEDET                             \ MUTEDET
$00000004 constant SAI1_SAI_BSR_WCKCFG                              \ WCKCFG
$00000008 constant SAI1_SAI_BSR_FREQ                                \ FREQ
$00000010 constant SAI1_SAI_BSR_CNRDY                               \ CNRDY
$00000020 constant SAI1_SAI_BSR_AFSDET                              \ AFSDET
$00000040 constant SAI1_SAI_BSR_LFSDET                              \ LFSDET
$00070000 constant SAI1_SAI_BSR_FLVL                                \ FLVL


\
\ @brief Clear flag register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant SAI1_SAI_BCLRFR_COVRUDR                          \ COVRUDR
$00000002 constant SAI1_SAI_BCLRFR_CMUTEDET                         \ CMUTEDET
$00000004 constant SAI1_SAI_BCLRFR_CWCKCFG                          \ CWCKCFG
$00000010 constant SAI1_SAI_BCLRFR_CCNRDY                           \ CCNRDY
$00000020 constant SAI1_SAI_BCLRFR_CAFSDET                          \ CAFSDET
$00000040 constant SAI1_SAI_BCLRFR_CLFSDET                          \ CLFSDET


\
\ @brief Data register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant SAI1_SAI_BDR_DATA                                \ DATA


\
\ @brief PDM control register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant SAI1_SAI_PDMCR_PDMEN                             \ PDMEN
$00000030 constant SAI1_SAI_PDMCR_MICNBR                            \ MICNBR
$00000100 constant SAI1_SAI_PDMCR_CKEN1                             \ CKEN1
$00000200 constant SAI1_SAI_PDMCR_CKEN2                             \ CKEN2
$00000400 constant SAI1_SAI_PDMCR_CKEN3                             \ CKEN3
$00000800 constant SAI1_SAI_PDMCR_CKEN4                             \ CKEN4


\
\ @brief PDM delay register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000007 constant SAI1_SAI_PDMDLY_DLYM1L                           \ DLYM1L
$00000070 constant SAI1_SAI_PDMDLY_DLYM1R                           \ DLYM1R
$00000700 constant SAI1_SAI_PDMDLY_DLYM2L                           \ DLYM2L
$00007000 constant SAI1_SAI_PDMDLY_DLYM2R                           \ DLYM2R
$00070000 constant SAI1_SAI_PDMDLY_DLYM3L                           \ DLYM3L
$00700000 constant SAI1_SAI_PDMDLY_DLYM3R                           \ DLYM3R
$07000000 constant SAI1_SAI_PDMDLY_DLYM4L                           \ DLYM4L
$70000000 constant SAI1_SAI_PDMDLY_DLYM4R                           \ DLYM4R


\
\ @brief SAI hardware configuration register
\ Address offset: 0x3F0
\ Reset value: 0x00000108
\

$000000ff constant SAI1_SAI_HWCFGR_FIFO_SIZE                        \ FIFO_SIZE
$00000f00 constant SAI1_SAI_HWCFGR_SPDIF_PDM                        \ SPDIF_PDM
$000ff000 constant SAI1_SAI_HWCFGR_OPTION_REGOUT                    \ OPTION_REGOUT


\
\ @brief SAI version register
\ Address offset: 0x3F4
\ Reset value: 0x00000021
\

$0000000f constant SAI1_SAI_VERR_MINREV                             \ MINREV
$000000f0 constant SAI1_SAI_VERR_MAJREV                             \ MAJREV


\
\ @brief SAI identification register
\ Address offset: 0x3F8
\ Reset value: 0x00130031
\

$00000000 constant SAI1_SAI_IPIDR_ID                                \ ID


\
\ @brief SAI size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant SAI1_SAI_SIDR_SID                                \ SID


\
\ @brief SAI1 register block
\
$4400a000 constant SAI1_SAI_GCR   \ offset: 0x00 : Global configuration register
$4400a004 constant SAI1_SAI_ACR1  \ offset: 0x04 : Configuration register 1
$4400a008 constant SAI1_SAI_ACR2  \ offset: 0x08 : Configuration register 2
$4400a00c constant SAI1_SAI_AFRCR  \ offset: 0x0C : This register has no meaning in and SPDIF audio protocol
$4400a010 constant SAI1_SAI_ASLOTR  \ offset: 0x10 : This register has no meaning in and SPDIF audio protocol
$4400a014 constant SAI1_SAI_AIM   \ offset: 0x14 : Interrupt mask register
$4400a018 constant SAI1_SAI_ASR   \ offset: 0x18 : Status register
$4400a01c constant SAI1_SAI_ACLRFR  \ offset: 0x1C : Clear flag register
$4400a020 constant SAI1_SAI_ADR   \ offset: 0x20 : Data register
$4400a024 constant SAI1_SAI_BCR1  \ offset: 0x24 : Configuration register 1
$4400a028 constant SAI1_SAI_BCR2  \ offset: 0x28 : Configuration register 2
$4400a02c constant SAI1_SAI_BFRCR  \ offset: 0x2C : This register has no meaning in and SPDIF audio protocol
$4400a030 constant SAI1_SAI_BSLOTR  \ offset: 0x30 : This register has no meaning in and SPDIF audio protocol
$4400a034 constant SAI1_SAI_BIM   \ offset: 0x34 : Interrupt mask register
$4400a038 constant SAI1_SAI_BSR   \ offset: 0x38 : Status register
$4400a03c constant SAI1_SAI_BCLRFR  \ offset: 0x3C : Clear flag register
$4400a040 constant SAI1_SAI_BDR   \ offset: 0x40 : Data register
$4400a044 constant SAI1_SAI_PDMCR  \ offset: 0x44 : PDM control register
$4400a048 constant SAI1_SAI_PDMDLY  \ offset: 0x48 : PDM delay register
$4400a3f0 constant SAI1_SAI_HWCFGR  \ offset: 0x3F0 : SAI hardware configuration register
$4400a3f4 constant SAI1_SAI_VERR  \ offset: 0x3F4 : SAI version register
$4400a3f8 constant SAI1_SAI_IPIDR  \ offset: 0x3F8 : SAI identification register
$4400a3fc constant SAI1_SAI_SIDR  \ offset: 0x3FC : SAI size identification register

