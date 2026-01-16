\
\ @file gfxmmu_s.fs
\ @brief Chrom-GRC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief GFXMMU configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_CR_B0OIE                         \ Buffer 0 overflow interrupt enable
$00000002 constant GFXMMU_S_GFXMMU_CR_B1OIE                         \ Buffer 1 overflow interrupt enable
$00000004 constant GFXMMU_S_GFXMMU_CR_B2OIE                         \ Buffer 2 overflow interrupt enable
$00000008 constant GFXMMU_S_GFXMMU_CR_B3OIE                         \ Buffer 3 overflow interrupt enable
$00000010 constant GFXMMU_S_GFXMMU_CR_AMEIE                         \ AXI master error interrupt enable
$00000040 constant GFXMMU_S_GFXMMU_CR_BS                            \ Block size
$00008000 constant GFXMMU_S_GFXMMU_CR_ATE                           \ Address translation enable
$01000000 constant GFXMMU_S_GFXMMU_CR_B0PE                          \ Buffer 0 packing enable
$02000000 constant GFXMMU_S_GFXMMU_CR_B0PM                          \ Buffer 0 packing mode
$04000000 constant GFXMMU_S_GFXMMU_CR_B1PE                          \ Buffer 1 packing enable
$08000000 constant GFXMMU_S_GFXMMU_CR_B1PM                          \ Buffer 1 packing mode
$10000000 constant GFXMMU_S_GFXMMU_CR_B2PE                          \ Buffer 2 packing enable
$20000000 constant GFXMMU_S_GFXMMU_CR_B2PM                          \ Buffer 2 packing mode
$40000000 constant GFXMMU_S_GFXMMU_CR_B3PE                          \ Buffer 3 packing enable
$80000000 constant GFXMMU_S_GFXMMU_CR_B3PM                          \ Buffer 3 packing mode


\
\ @brief GFXMMU status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_SR_B0OF                          \ Buffer 0 overflow flag
$00000002 constant GFXMMU_S_GFXMMU_SR_B1OF                          \ Buffer 1 overflow flag
$00000004 constant GFXMMU_S_GFXMMU_SR_B2OF                          \ Buffer 2 overflow flag
$00000008 constant GFXMMU_S_GFXMMU_SR_B3OF                          \ Buffer 3 overflow flag
$00000010 constant GFXMMU_S_GFXMMU_SR_AMEF                          \ AXI master error flag


\
\ @brief GFXMMU flag clear register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_FCR_CB0OF                        \ Clear buffer 0 overflow flag
$00000002 constant GFXMMU_S_GFXMMU_FCR_CB1OF                        \ Clear buffer 1 overflow flag
$00000004 constant GFXMMU_S_GFXMMU_FCR_CB2OF                        \ Clear buffer 2 overflow flag
$00000008 constant GFXMMU_S_GFXMMU_FCR_CB3OF                        \ Clear buffer 3 overflow flag
$00000010 constant GFXMMU_S_GFXMMU_FCR_CAMEF                        \ Clear AXI master error flag


\
\ @brief GFXMMU default value register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant GFXMMU_S_GFXMMU_DVR_DV                           \ Default value


\
\ @brief GFXMMU default alpha register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant GFXMMU_S_GFXMMU_DAR_DA                           \ Default alpha


\
\ @brief GFXMMU buffer 0 configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$007ffff0 constant GFXMMU_S_GFXMMU_B0CR_PBO                         \ Physical buffer offset
$ff800000 constant GFXMMU_S_GFXMMU_B0CR_PBBA                        \ Physical buffer base address


\
\ @brief GFXMMU buffer 1 configuration register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$007ffff0 constant GFXMMU_S_GFXMMU_B1CR_PBO                         \ Physical buffer offset
$ff800000 constant GFXMMU_S_GFXMMU_B1CR_PBBA                        \ Physical buffer base address


\
\ @brief GFXMMU buffer 2 configuration register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$007ffff0 constant GFXMMU_S_GFXMMU_B2CR_PBO                         \ Physical buffer offset
$ff800000 constant GFXMMU_S_GFXMMU_B2CR_PBBA                        \ Physical buffer base address


\
\ @brief GFXMMU buffer 3 configuration register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$007ffff0 constant GFXMMU_S_GFXMMU_B3CR_PBO                         \ Physical buffer offset
$ff800000 constant GFXMMU_S_GFXMMU_B3CR_PBBA                        \ Physical buffer base address


\
\ @brief GFXMMU LUT entry 0 low
\ Address offset: 0x1000
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT0L_EN                         \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT0L_FVB                        \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT0L_LVB                        \ Last valid block


\
\ @brief GFXMMU LUT entry 0 high
\ Address offset: 0x1004
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT0H_LO                         \ Line offset


\
\ @brief GFXMMU LUT entry 1 low
\ Address offset: 0x1008
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1L_EN                         \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1L_FVB                        \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1L_LVB                        \ Last valid block


\
\ @brief GFXMMU LUT entry 1 high
\ Address offset: 0x100C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1H_LO                         \ Line offset


\
\ @brief GFXMMU LUT entry 2 low
\ Address offset: 0x1010
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT2L_EN                         \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT2L_FVB                        \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT2L_LVB                        \ Last valid block


\
\ @brief GFXMMU LUT entry 2 high
\ Address offset: 0x1014
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT2H_LO                         \ Line offset


\
\ @brief GFXMMU LUT entry 3 low
\ Address offset: 0x1018
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT3L_EN                         \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT3L_FVB                        \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT3L_LVB                        \ Last valid block


\
\ @brief GFXMMU LUT entry 3 high
\ Address offset: 0x101C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT3H_LO                         \ Line offset


\
\ @brief GFXMMU LUT entry 4 low
\ Address offset: 0x1020
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT4L_EN                         \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT4L_FVB                        \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT4L_LVB                        \ Last valid block


\
\ @brief GFXMMU LUT entry 4 high
\ Address offset: 0x1024
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT4H_LO                         \ Line offset


\
\ @brief GFXMMU LUT entry 5 low
\ Address offset: 0x1028
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT5L_EN                         \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT5L_FVB                        \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT5L_LVB                        \ Last valid block


\
\ @brief GFXMMU LUT entry 5 high
\ Address offset: 0x102C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT5H_LO                         \ Line offset


\
\ @brief GFXMMU LUT entry 6 low
\ Address offset: 0x1030
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT6L_EN                         \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT6L_FVB                        \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT6L_LVB                        \ Last valid block


\
\ @brief GFXMMU LUT entry 6 high
\ Address offset: 0x1034
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT6H_LO                         \ Line offset


\
\ @brief GFXMMU LUT entry 7 low
\ Address offset: 0x1038
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT7L_EN                         \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT7L_FVB                        \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT7L_LVB                        \ Last valid block


\
\ @brief GFXMMU LUT entry 7 high
\ Address offset: 0x103C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT7H_LO                         \ Line offset


\
\ @brief GFXMMU LUT entry 8 low
\ Address offset: 0x1040
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT8L_EN                         \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT8L_FVB                        \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT8L_LVB                        \ Last valid block


\
\ @brief GFXMMU LUT entry 8 high
\ Address offset: 0x1044
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT8H_LO                         \ Line offset


\
\ @brief GFXMMU LUT entry 9 low
\ Address offset: 0x1048
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT9L_EN                         \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT9L_FVB                        \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT9L_LVB                        \ Last valid block


\
\ @brief GFXMMU LUT entry 9 high
\ Address offset: 0x104C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT9H_LO                         \ Line offset


\
\ @brief GFXMMU LUT entry 10 low
\ Address offset: 0x1050
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT10L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT10L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT10L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 10 high
\ Address offset: 0x1054
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT10H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 11 low
\ Address offset: 0x1058
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT11L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT11L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT11L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 11 high
\ Address offset: 0x105C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT11H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 12 low
\ Address offset: 0x1060
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT12L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT12L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT12L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 12 high
\ Address offset: 0x1064
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT12H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 13 low
\ Address offset: 0x1068
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT13L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT13L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT13L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 13 high
\ Address offset: 0x106C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT13H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 14 low
\ Address offset: 0x1070
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT14L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT14L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT14L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 14 high
\ Address offset: 0x1074
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT14H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 15 low
\ Address offset: 0x1078
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT15L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT15L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT15L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 15 high
\ Address offset: 0x107C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT15H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 16 low
\ Address offset: 0x1080
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT16L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT16L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT16L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 16 high
\ Address offset: 0x1084
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT16H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 17 low
\ Address offset: 0x1088
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT17L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT17L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT17L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 17 high
\ Address offset: 0x108C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT17H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 18 low
\ Address offset: 0x1090
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT18L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT18L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT18L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 18 high
\ Address offset: 0x1094
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT18H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 19 low
\ Address offset: 0x1098
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT19L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT19L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT19L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 19 high
\ Address offset: 0x109C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT19H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 20 low
\ Address offset: 0x10A0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT20L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT20L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT20L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 20 high
\ Address offset: 0x10A4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT20H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 21 low
\ Address offset: 0x10A8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT21L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT21L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT21L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 21 high
\ Address offset: 0x10AC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT21H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 22 low
\ Address offset: 0x10B0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT22L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT22L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT22L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 22 high
\ Address offset: 0x10B4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT22H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 23 low
\ Address offset: 0x10B8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT23L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT23L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT23L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 23 high
\ Address offset: 0x10BC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT23H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 24 low
\ Address offset: 0x10C0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT24L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT24L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT24L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 24 high
\ Address offset: 0x10C4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT24H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 25 low
\ Address offset: 0x10C8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT25L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT25L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT25L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 25 high
\ Address offset: 0x10CC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT25H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 26 low
\ Address offset: 0x10D0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT26L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT26L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT26L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 26 high
\ Address offset: 0x10D4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT26H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 27 low
\ Address offset: 0x10D8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT27L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT27L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT27L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 27 high
\ Address offset: 0x10DC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT27H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 28 low
\ Address offset: 0x10E0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT28L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT28L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT28L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 28 high
\ Address offset: 0x10E4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT28H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 29 low
\ Address offset: 0x10E8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT29L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT29L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT29L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 29 high
\ Address offset: 0x10EC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT29H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 30 low
\ Address offset: 0x10F0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT30L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT30L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT30L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 30 high
\ Address offset: 0x10F4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT30H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 31 low
\ Address offset: 0x10F8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT31L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT31L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT31L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 31 high
\ Address offset: 0x10FC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT31H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 32 low
\ Address offset: 0x1100
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT32L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT32L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT32L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 32 high
\ Address offset: 0x1104
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT32H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 33 low
\ Address offset: 0x1108
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT33L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT33L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT33L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 33 high
\ Address offset: 0x110C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT33H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 34 low
\ Address offset: 0x1110
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT34L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT34L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT34L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 34 high
\ Address offset: 0x1114
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT34H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 35 low
\ Address offset: 0x1118
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT35L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT35L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT35L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 35 high
\ Address offset: 0x111C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT35H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 36 low
\ Address offset: 0x1120
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT36L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT36L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT36L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 36 high
\ Address offset: 0x1124
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT36H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 37 low
\ Address offset: 0x1128
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT37L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT37L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT37L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 37 high
\ Address offset: 0x112C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT37H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 38 low
\ Address offset: 0x1130
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT38L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT38L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT38L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 38 high
\ Address offset: 0x1134
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT38H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 39 low
\ Address offset: 0x1138
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT39L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT39L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT39L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 39 high
\ Address offset: 0x113C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT39H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 40 low
\ Address offset: 0x1140
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT40L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT40L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT40L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 40 high
\ Address offset: 0x1144
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT40H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 41 low
\ Address offset: 0x1148
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT41L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT41L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT41L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 41 high
\ Address offset: 0x114C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT41H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 42 low
\ Address offset: 0x1150
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT42L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT42L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT42L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 42 high
\ Address offset: 0x1154
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT42H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 43 low
\ Address offset: 0x1158
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT43L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT43L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT43L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 43 high
\ Address offset: 0x115C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT43H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 44 low
\ Address offset: 0x1160
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT44L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT44L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT44L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 44 high
\ Address offset: 0x1164
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT44H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 45 low
\ Address offset: 0x1168
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT45L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT45L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT45L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 45 high
\ Address offset: 0x116C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT45H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 46 low
\ Address offset: 0x1170
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT46L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT46L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT46L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 46 high
\ Address offset: 0x1174
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT46H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 47 low
\ Address offset: 0x1178
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT47L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT47L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT47L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 47 high
\ Address offset: 0x117C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT47H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 48 low
\ Address offset: 0x1180
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT48L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT48L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT48L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 48 high
\ Address offset: 0x1184
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT48H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 49 low
\ Address offset: 0x1188
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT49L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT49L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT49L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 49 high
\ Address offset: 0x118C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT49H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 50 low
\ Address offset: 0x1190
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT50L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT50L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT50L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 50 high
\ Address offset: 0x1194
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT50H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 51 low
\ Address offset: 0x1198
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT51L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT51L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT51L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 51 high
\ Address offset: 0x119C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT51H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 52 low
\ Address offset: 0x11A0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT52L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT52L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT52L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 52 high
\ Address offset: 0x11A4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT52H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 53 low
\ Address offset: 0x11A8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT53L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT53L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT53L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 53 high
\ Address offset: 0x11AC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT53H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 54 low
\ Address offset: 0x11B0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT54L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT54L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT54L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 54 high
\ Address offset: 0x11B4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT54H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 55 low
\ Address offset: 0x11B8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT55L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT55L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT55L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 55 high
\ Address offset: 0x11BC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT55H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 56 low
\ Address offset: 0x11C0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT56L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT56L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT56L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 56 high
\ Address offset: 0x11C4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT56H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 57 low
\ Address offset: 0x11C8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT57L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT57L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT57L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 57 high
\ Address offset: 0x11CC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT57H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 58 low
\ Address offset: 0x11D0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT58L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT58L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT58L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 58 high
\ Address offset: 0x11D4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT58H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 59 low
\ Address offset: 0x11D8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT59L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT59L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT59L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 59 high
\ Address offset: 0x11DC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT59H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 60 low
\ Address offset: 0x11E0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT60L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT60L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT60L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 60 high
\ Address offset: 0x11E4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT60H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 61 low
\ Address offset: 0x11E8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT61L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT61L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT61L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 61 high
\ Address offset: 0x11EC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT61H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 62 low
\ Address offset: 0x11F0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT62L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT62L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT62L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 62 high
\ Address offset: 0x11F4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT62H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 63 low
\ Address offset: 0x11F8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT63L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT63L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT63L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 63 high
\ Address offset: 0x11FC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT63H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 64 low
\ Address offset: 0x1200
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT64L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT64L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT64L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 64 high
\ Address offset: 0x1204
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT64H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 65 low
\ Address offset: 0x1208
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT65L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT65L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT65L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 65 high
\ Address offset: 0x120C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT65H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 66 low
\ Address offset: 0x1210
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT66L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT66L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT66L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 66 high
\ Address offset: 0x1214
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT66H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 67 low
\ Address offset: 0x1218
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT67L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT67L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT67L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 67 high
\ Address offset: 0x121C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT67H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 68 low
\ Address offset: 0x1220
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT68L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT68L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT68L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 68 high
\ Address offset: 0x1224
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT68H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 69 low
\ Address offset: 0x1228
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT69L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT69L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT69L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 69 high
\ Address offset: 0x122C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT69H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 70 low
\ Address offset: 0x1230
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT70L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT70L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT70L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 70 high
\ Address offset: 0x1234
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT70H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 71 low
\ Address offset: 0x1238
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT71L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT71L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT71L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 71 high
\ Address offset: 0x123C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT71H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 72 low
\ Address offset: 0x1240
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT72L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT72L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT72L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 72 high
\ Address offset: 0x1244
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT72H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 73 low
\ Address offset: 0x1248
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT73L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT73L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT73L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 73 high
\ Address offset: 0x124C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT73H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 74 low
\ Address offset: 0x1250
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT74L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT74L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT74L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 74 high
\ Address offset: 0x1254
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT74H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 75 low
\ Address offset: 0x1258
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT75L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT75L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT75L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 75 high
\ Address offset: 0x125C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT75H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 76 low
\ Address offset: 0x1260
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT76L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT76L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT76L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 76 high
\ Address offset: 0x1264
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT76H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 77 low
\ Address offset: 0x1268
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT77L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT77L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT77L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 77 high
\ Address offset: 0x126C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT77H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 78 low
\ Address offset: 0x1270
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT78L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT78L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT78L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 78 high
\ Address offset: 0x1274
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT78H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 79 low
\ Address offset: 0x1278
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT79L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT79L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT79L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 79 high
\ Address offset: 0x127C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT79H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 80 low
\ Address offset: 0x1280
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT80L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT80L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT80L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 80 high
\ Address offset: 0x1284
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT80H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 81 low
\ Address offset: 0x1288
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT81L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT81L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT81L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 81 high
\ Address offset: 0x128C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT81H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 82 low
\ Address offset: 0x1290
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT82L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT82L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT82L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 82 high
\ Address offset: 0x1294
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT82H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 83 low
\ Address offset: 0x1298
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT83L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT83L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT83L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 83 high
\ Address offset: 0x129C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT83H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 84 low
\ Address offset: 0x12A0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT84L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT84L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT84L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 84 high
\ Address offset: 0x12A4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT84H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 85 low
\ Address offset: 0x12A8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT85L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT85L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT85L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 85 high
\ Address offset: 0x12AC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT85H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 86 low
\ Address offset: 0x12B0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT86L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT86L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT86L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 86 high
\ Address offset: 0x12B4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT86H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 87 low
\ Address offset: 0x12B8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT87L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT87L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT87L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 87 high
\ Address offset: 0x12BC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT87H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 88 low
\ Address offset: 0x12C0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT88L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT88L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT88L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 88 high
\ Address offset: 0x12C4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT88H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 89 low
\ Address offset: 0x12C8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT89L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT89L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT89L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 89 high
\ Address offset: 0x12CC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT89H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 90 low
\ Address offset: 0x12D0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT90L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT90L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT90L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 90 high
\ Address offset: 0x12D4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT90H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 91 low
\ Address offset: 0x12D8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT91L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT91L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT91L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 91 high
\ Address offset: 0x12DC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT91H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 92 low
\ Address offset: 0x12E0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT92L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT92L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT92L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 92 high
\ Address offset: 0x12E4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT92H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 93 low
\ Address offset: 0x12E8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT93L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT93L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT93L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 93 high
\ Address offset: 0x12EC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT93H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 94 low
\ Address offset: 0x12F0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT94L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT94L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT94L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 94 high
\ Address offset: 0x12F4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT94H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 95 low
\ Address offset: 0x12F8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT95L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT95L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT95L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 95 high
\ Address offset: 0x12FC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT95H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 96 low
\ Address offset: 0x1300
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT96L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT96L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT96L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 96 high
\ Address offset: 0x1304
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT96H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 97 low
\ Address offset: 0x1308
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT97L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT97L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT97L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 97 high
\ Address offset: 0x130C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT97H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 98 low
\ Address offset: 0x1310
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT98L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT98L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT98L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 98 high
\ Address offset: 0x1314
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT98H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 99 low
\ Address offset: 0x1318
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT99L_EN                        \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT99L_FVB                       \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT99L_LVB                       \ Last valid block


\
\ @brief GFXMMU LUT entry 99 high
\ Address offset: 0x131C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT99H_LO                        \ Line offset


\
\ @brief GFXMMU LUT entry 100 low
\ Address offset: 0x1320
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT100L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT100L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT100L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 100 high
\ Address offset: 0x1324
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT100H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 101 low
\ Address offset: 0x1328
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT101L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT101L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT101L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 101 high
\ Address offset: 0x132C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT101H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 102 low
\ Address offset: 0x1330
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT102L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT102L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT102L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 102 high
\ Address offset: 0x1334
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT102H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 103 low
\ Address offset: 0x1338
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT103L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT103L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT103L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 103 high
\ Address offset: 0x133C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT103H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 104 low
\ Address offset: 0x1340
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT104L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT104L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT104L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 104 high
\ Address offset: 0x1344
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT104H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 105 low
\ Address offset: 0x1348
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT105L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT105L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT105L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 105 high
\ Address offset: 0x134C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT105H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 106 low
\ Address offset: 0x1350
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT106L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT106L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT106L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 106 high
\ Address offset: 0x1354
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT106H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 107 low
\ Address offset: 0x1358
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT107L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT107L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT107L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 107 high
\ Address offset: 0x135C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT107H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 108 low
\ Address offset: 0x1360
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT108L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT108L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT108L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 108 high
\ Address offset: 0x1364
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT108H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 109 low
\ Address offset: 0x1368
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT109L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT109L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT109L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 109 high
\ Address offset: 0x136C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT109H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 110 low
\ Address offset: 0x1370
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT110L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT110L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT110L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 110 high
\ Address offset: 0x1374
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT110H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 111 low
\ Address offset: 0x1378
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT111L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT111L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT111L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 111 high
\ Address offset: 0x137C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT111H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 112 low
\ Address offset: 0x1380
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT112L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT112L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT112L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 112 high
\ Address offset: 0x1384
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT112H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 113 low
\ Address offset: 0x1388
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT113L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT113L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT113L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 113 high
\ Address offset: 0x138C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT113H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 114 low
\ Address offset: 0x1390
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT114L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT114L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT114L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 114 high
\ Address offset: 0x1394
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT114H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 115 low
\ Address offset: 0x1398
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT115L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT115L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT115L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 115 high
\ Address offset: 0x139C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT115H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 116 low
\ Address offset: 0x13A0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT116L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT116L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT116L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 116 high
\ Address offset: 0x13A4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT116H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 117 low
\ Address offset: 0x13A8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT117L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT117L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT117L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 117 high
\ Address offset: 0x13AC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT117H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 118 low
\ Address offset: 0x13B0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT118L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT118L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT118L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 118 high
\ Address offset: 0x13B4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT118H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 119 low
\ Address offset: 0x13B8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT119L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT119L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT119L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 119 high
\ Address offset: 0x13BC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT119H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 120 low
\ Address offset: 0x13C0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT120L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT120L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT120L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 120 high
\ Address offset: 0x13C4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT120H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 121 low
\ Address offset: 0x13C8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT121L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT121L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT121L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 121 high
\ Address offset: 0x13CC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT121H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 122 low
\ Address offset: 0x13D0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT122L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT122L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT122L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 122 high
\ Address offset: 0x13D4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT122H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 123 low
\ Address offset: 0x13D8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT123L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT123L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT123L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 123 high
\ Address offset: 0x13DC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT123H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 124 low
\ Address offset: 0x13E0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT124L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT124L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT124L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 124 high
\ Address offset: 0x13E4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT124H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 125 low
\ Address offset: 0x13E8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT125L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT125L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT125L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 125 high
\ Address offset: 0x13EC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT125H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 126 low
\ Address offset: 0x13F0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT126L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT126L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT126L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 126 high
\ Address offset: 0x13F4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT126H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 127 low
\ Address offset: 0x13F8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT127L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT127L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT127L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 127 high
\ Address offset: 0x13FC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT127H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 128 low
\ Address offset: 0x1400
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT128L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT128L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT128L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 128 high
\ Address offset: 0x1404
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT128H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 129 low
\ Address offset: 0x1408
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT129L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT129L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT129L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 129 high
\ Address offset: 0x140C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT129H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 130 low
\ Address offset: 0x1410
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT130L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT130L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT130L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 130 high
\ Address offset: 0x1414
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT130H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 131 low
\ Address offset: 0x1418
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT131L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT131L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT131L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 131 high
\ Address offset: 0x141C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT131H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 132 low
\ Address offset: 0x1420
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT132L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT132L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT132L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 132 high
\ Address offset: 0x1424
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT132H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 133 low
\ Address offset: 0x1428
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT133L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT133L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT133L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 133 high
\ Address offset: 0x142C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT133H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 134 low
\ Address offset: 0x1430
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT134L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT134L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT134L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 134 high
\ Address offset: 0x1434
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT134H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 135 low
\ Address offset: 0x1438
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT135L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT135L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT135L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 135 high
\ Address offset: 0x143C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT135H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 136 low
\ Address offset: 0x1440
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT136L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT136L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT136L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 136 high
\ Address offset: 0x1444
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT136H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 137 low
\ Address offset: 0x1448
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT137L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT137L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT137L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 137 high
\ Address offset: 0x144C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT137H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 138 low
\ Address offset: 0x1450
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT138L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT138L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT138L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 138 high
\ Address offset: 0x1454
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT138H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 139 low
\ Address offset: 0x1458
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT139L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT139L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT139L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 139 high
\ Address offset: 0x145C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT139H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 140 low
\ Address offset: 0x1460
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT140L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT140L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT140L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 140 high
\ Address offset: 0x1464
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT140H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 141 low
\ Address offset: 0x1468
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT141L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT141L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT141L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 141 high
\ Address offset: 0x146C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT141H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 142 low
\ Address offset: 0x1470
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT142L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT142L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT142L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 142 high
\ Address offset: 0x1474
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT142H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 143 low
\ Address offset: 0x1478
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT143L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT143L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT143L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 143 high
\ Address offset: 0x147C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT143H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 144 low
\ Address offset: 0x1480
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT144L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT144L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT144L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 144 high
\ Address offset: 0x1484
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT144H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 145 low
\ Address offset: 0x1488
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT145L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT145L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT145L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 145 high
\ Address offset: 0x148C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT145H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 146 low
\ Address offset: 0x1490
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT146L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT146L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT146L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 146 high
\ Address offset: 0x1494
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT146H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 147 low
\ Address offset: 0x1498
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT147L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT147L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT147L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 147 high
\ Address offset: 0x149C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT147H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 148 low
\ Address offset: 0x14A0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT148L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT148L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT148L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 148 high
\ Address offset: 0x14A4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT148H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 149 low
\ Address offset: 0x14A8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT149L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT149L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT149L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 149 high
\ Address offset: 0x14AC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT149H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 150 low
\ Address offset: 0x14B0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT150L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT150L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT150L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 150 high
\ Address offset: 0x14B4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT150H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 151 low
\ Address offset: 0x14B8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT151L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT151L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT151L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 151 high
\ Address offset: 0x14BC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT151H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 152 low
\ Address offset: 0x14C0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT152L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT152L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT152L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 152 high
\ Address offset: 0x14C4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT152H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 153 low
\ Address offset: 0x14C8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT153L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT153L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT153L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 153 high
\ Address offset: 0x14CC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT153H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 154 low
\ Address offset: 0x14D0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT154L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT154L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT154L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 154 high
\ Address offset: 0x14D4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT154H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 155 low
\ Address offset: 0x14D8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT155L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT155L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT155L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 155 high
\ Address offset: 0x14DC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT155H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 156 low
\ Address offset: 0x14E0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT156L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT156L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT156L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 156 high
\ Address offset: 0x14E4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT156H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 157 low
\ Address offset: 0x14E8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT157L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT157L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT157L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 157 high
\ Address offset: 0x14EC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT157H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 158 low
\ Address offset: 0x14F0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT158L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT158L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT158L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 158 high
\ Address offset: 0x14F4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT158H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 159 low
\ Address offset: 0x14F8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT159L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT159L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT159L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 159 high
\ Address offset: 0x14FC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT159H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 160 low
\ Address offset: 0x1500
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT160L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT160L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT160L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 160 high
\ Address offset: 0x1504
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT160H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 161 low
\ Address offset: 0x1508
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT161L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT161L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT161L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 161 high
\ Address offset: 0x150C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT161H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 162 low
\ Address offset: 0x1510
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT162L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT162L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT162L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 162 high
\ Address offset: 0x1514
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT162H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 163 low
\ Address offset: 0x1518
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT163L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT163L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT163L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 163 high
\ Address offset: 0x151C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT163H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 164 low
\ Address offset: 0x1520
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT164L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT164L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT164L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 164 high
\ Address offset: 0x1524
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT164H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 165 low
\ Address offset: 0x1528
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT165L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT165L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT165L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 165 high
\ Address offset: 0x152C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT165H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 166 low
\ Address offset: 0x1530
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT166L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT166L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT166L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 166 high
\ Address offset: 0x1534
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT166H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 167 low
\ Address offset: 0x1538
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT167L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT167L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT167L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 167 high
\ Address offset: 0x153C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT167H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 168 low
\ Address offset: 0x1540
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT168L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT168L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT168L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 168 high
\ Address offset: 0x1544
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT168H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 169 low
\ Address offset: 0x1548
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT169L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT169L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT169L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 169 high
\ Address offset: 0x154C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT169H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 170 low
\ Address offset: 0x1550
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT170L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT170L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT170L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 170 high
\ Address offset: 0x1554
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT170H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 171 low
\ Address offset: 0x1558
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT171L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT171L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT171L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 171 high
\ Address offset: 0x155C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT171H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 172 low
\ Address offset: 0x1560
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT172L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT172L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT172L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 172 high
\ Address offset: 0x1564
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT172H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 173 low
\ Address offset: 0x1568
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT173L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT173L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT173L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 173 high
\ Address offset: 0x156C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT173H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 174 low
\ Address offset: 0x1570
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT174L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT174L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT174L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 174 high
\ Address offset: 0x1574
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT174H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 175 low
\ Address offset: 0x1578
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT175L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT175L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT175L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 175 high
\ Address offset: 0x157C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT175H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 176 low
\ Address offset: 0x1580
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT176L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT176L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT176L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 176 high
\ Address offset: 0x1584
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT176H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 177 low
\ Address offset: 0x1588
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT177L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT177L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT177L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 177 high
\ Address offset: 0x158C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT177H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 178 low
\ Address offset: 0x1590
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT178L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT178L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT178L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 178 high
\ Address offset: 0x1594
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT178H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 179 low
\ Address offset: 0x1598
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT179L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT179L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT179L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 179 high
\ Address offset: 0x159C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT179H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 180 low
\ Address offset: 0x15A0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT180L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT180L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT180L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 180 high
\ Address offset: 0x15A4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT180H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 181 low
\ Address offset: 0x15A8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT181L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT181L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT181L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 181 high
\ Address offset: 0x15AC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT181H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 182 low
\ Address offset: 0x15B0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT182L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT182L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT182L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 182 high
\ Address offset: 0x15B4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT182H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 183 low
\ Address offset: 0x15B8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT183L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT183L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT183L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 183 high
\ Address offset: 0x15BC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT183H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 184 low
\ Address offset: 0x15C0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT184L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT184L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT184L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 184 high
\ Address offset: 0x15C4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT184H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 185 low
\ Address offset: 0x15C8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT185L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT185L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT185L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 185 high
\ Address offset: 0x15CC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT185H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 186 low
\ Address offset: 0x15D0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT186L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT186L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT186L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 186 high
\ Address offset: 0x15D4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT186H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 187 low
\ Address offset: 0x15D8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT187L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT187L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT187L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 187 high
\ Address offset: 0x15DC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT187H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 188 low
\ Address offset: 0x15E0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT188L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT188L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT188L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 188 high
\ Address offset: 0x15E4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT188H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 189 low
\ Address offset: 0x15E8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT189L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT189L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT189L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 189 high
\ Address offset: 0x15EC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT189H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 190 low
\ Address offset: 0x15F0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT190L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT190L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT190L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 190 high
\ Address offset: 0x15F4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT190H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 191 low
\ Address offset: 0x15F8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT191L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT191L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT191L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 191 high
\ Address offset: 0x15FC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT191H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 192 low
\ Address offset: 0x1600
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT192L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT192L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT192L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 192 high
\ Address offset: 0x1604
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT192H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 193 low
\ Address offset: 0x1608
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT193L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT193L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT193L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 193 high
\ Address offset: 0x160C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT193H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 194 low
\ Address offset: 0x1610
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT194L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT194L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT194L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 194 high
\ Address offset: 0x1614
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT194H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 195 low
\ Address offset: 0x1618
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT195L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT195L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT195L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 195 high
\ Address offset: 0x161C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT195H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 196 low
\ Address offset: 0x1620
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT196L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT196L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT196L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 196 high
\ Address offset: 0x1624
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT196H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 197 low
\ Address offset: 0x1628
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT197L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT197L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT197L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 197 high
\ Address offset: 0x162C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT197H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 198 low
\ Address offset: 0x1630
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT198L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT198L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT198L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 198 high
\ Address offset: 0x1634
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT198H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 199 low
\ Address offset: 0x1638
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT199L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT199L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT199L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 199 high
\ Address offset: 0x163C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT199H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 200 low
\ Address offset: 0x1640
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT200L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT200L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT200L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 200 high
\ Address offset: 0x1644
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT200H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 201 low
\ Address offset: 0x1648
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT201L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT201L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT201L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 201 high
\ Address offset: 0x164C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT201H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 202 low
\ Address offset: 0x1650
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT202L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT202L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT202L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 202 high
\ Address offset: 0x1654
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT202H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 203 low
\ Address offset: 0x1658
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT203L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT203L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT203L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 203 high
\ Address offset: 0x165C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT203H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 204 low
\ Address offset: 0x1660
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT204L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT204L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT204L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 204 high
\ Address offset: 0x1664
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT204H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 205 low
\ Address offset: 0x1668
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT205L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT205L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT205L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 205 high
\ Address offset: 0x166C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT205H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 206 low
\ Address offset: 0x1670
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT206L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT206L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT206L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 206 high
\ Address offset: 0x1674
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT206H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 207 low
\ Address offset: 0x1678
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT207L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT207L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT207L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 207 high
\ Address offset: 0x167C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT207H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 208 low
\ Address offset: 0x1680
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT208L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT208L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT208L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 208 high
\ Address offset: 0x1684
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT208H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 209 low
\ Address offset: 0x1688
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT209L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT209L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT209L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 209 high
\ Address offset: 0x168C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT209H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 210 low
\ Address offset: 0x1690
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT210L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT210L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT210L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 210 high
\ Address offset: 0x1694
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT210H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 211 low
\ Address offset: 0x1698
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT211L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT211L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT211L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 211 high
\ Address offset: 0x169C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT211H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 212 low
\ Address offset: 0x16A0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT212L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT212L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT212L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 212 high
\ Address offset: 0x16A4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT212H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 213 low
\ Address offset: 0x16A8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT213L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT213L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT213L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 213 high
\ Address offset: 0x16AC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT213H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 214 low
\ Address offset: 0x16B0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT214L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT214L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT214L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 214 high
\ Address offset: 0x16B4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT214H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 215 low
\ Address offset: 0x16B8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT215L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT215L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT215L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 215 high
\ Address offset: 0x16BC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT215H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 216 low
\ Address offset: 0x16C0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT216L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT216L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT216L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 216 high
\ Address offset: 0x16C4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT216H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 217 low
\ Address offset: 0x16C8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT217L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT217L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT217L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 217 high
\ Address offset: 0x16CC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT217H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 218 low
\ Address offset: 0x16D0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT218L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT218L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT218L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 218 high
\ Address offset: 0x16D4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT218H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 219 low
\ Address offset: 0x16D8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT219L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT219L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT219L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 219 high
\ Address offset: 0x16DC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT219H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 220 low
\ Address offset: 0x16E0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT220L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT220L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT220L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 220 high
\ Address offset: 0x16E4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT220H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 221 low
\ Address offset: 0x16E8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT221L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT221L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT221L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 221 high
\ Address offset: 0x16EC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT221H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 222 low
\ Address offset: 0x16F0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT222L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT222L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT222L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 222 high
\ Address offset: 0x16F4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT222H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 223 low
\ Address offset: 0x16F8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT223L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT223L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT223L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 223 high
\ Address offset: 0x16FC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT223H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 224 low
\ Address offset: 0x1700
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT224L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT224L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT224L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 224 high
\ Address offset: 0x1704
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT224H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 225 low
\ Address offset: 0x1708
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT225L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT225L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT225L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 225 high
\ Address offset: 0x170C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT225H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 226 low
\ Address offset: 0x1710
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT226L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT226L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT226L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 226 high
\ Address offset: 0x1714
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT226H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 227 low
\ Address offset: 0x1718
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT227L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT227L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT227L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 227 high
\ Address offset: 0x171C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT227H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 228 low
\ Address offset: 0x1720
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT228L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT228L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT228L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 228 high
\ Address offset: 0x1724
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT228H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 229 low
\ Address offset: 0x1728
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT229L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT229L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT229L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 229 high
\ Address offset: 0x172C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT229H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 230 low
\ Address offset: 0x1730
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT230L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT230L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT230L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 230 high
\ Address offset: 0x1734
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT230H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 231 low
\ Address offset: 0x1738
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT231L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT231L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT231L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 231 high
\ Address offset: 0x173C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT231H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 232 low
\ Address offset: 0x1740
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT232L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT232L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT232L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 232 high
\ Address offset: 0x1744
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT232H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 233 low
\ Address offset: 0x1748
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT233L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT233L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT233L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 233 high
\ Address offset: 0x174C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT233H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 234 low
\ Address offset: 0x1750
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT234L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT234L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT234L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 234 high
\ Address offset: 0x1754
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT234H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 235 low
\ Address offset: 0x1758
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT235L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT235L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT235L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 235 high
\ Address offset: 0x175C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT235H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 236 low
\ Address offset: 0x1760
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT236L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT236L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT236L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 236 high
\ Address offset: 0x1764
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT236H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 237 low
\ Address offset: 0x1768
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT237L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT237L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT237L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 237 high
\ Address offset: 0x176C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT237H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 238 low
\ Address offset: 0x1770
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT238L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT238L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT238L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 238 high
\ Address offset: 0x1774
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT238H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 239 low
\ Address offset: 0x1778
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT239L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT239L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT239L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 239 high
\ Address offset: 0x177C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT239H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 240 low
\ Address offset: 0x1780
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT240L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT240L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT240L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 240 high
\ Address offset: 0x1784
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT240H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 241 low
\ Address offset: 0x1788
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT241L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT241L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT241L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 241 high
\ Address offset: 0x178C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT241H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 242 low
\ Address offset: 0x1790
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT242L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT242L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT242L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 242 high
\ Address offset: 0x1794
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT242H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 243 low
\ Address offset: 0x1798
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT243L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT243L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT243L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 243 high
\ Address offset: 0x179C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT243H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 244 low
\ Address offset: 0x17A0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT244L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT244L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT244L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 244 high
\ Address offset: 0x17A4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT244H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 245 low
\ Address offset: 0x17A8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT245L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT245L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT245L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 245 high
\ Address offset: 0x17AC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT245H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 246 low
\ Address offset: 0x17B0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT246L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT246L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT246L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 246 high
\ Address offset: 0x17B4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT246H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 247 low
\ Address offset: 0x17B8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT247L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT247L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT247L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 247 high
\ Address offset: 0x17BC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT247H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 248 low
\ Address offset: 0x17C0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT248L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT248L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT248L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 248 high
\ Address offset: 0x17C4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT248H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 249 low
\ Address offset: 0x17C8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT249L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT249L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT249L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 249 high
\ Address offset: 0x17CC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT249H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 250 low
\ Address offset: 0x17D0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT250L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT250L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT250L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 250 high
\ Address offset: 0x17D4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT250H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 251 low
\ Address offset: 0x17D8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT251L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT251L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT251L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 251 high
\ Address offset: 0x17DC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT251H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 252 low
\ Address offset: 0x17E0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT252L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT252L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT252L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 252 high
\ Address offset: 0x17E4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT252H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 253 low
\ Address offset: 0x17E8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT253L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT253L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT253L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 253 high
\ Address offset: 0x17EC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT253H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 254 low
\ Address offset: 0x17F0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT254L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT254L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT254L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 254 high
\ Address offset: 0x17F4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT254H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 255 low
\ Address offset: 0x17F8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT255L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT255L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT255L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 255 high
\ Address offset: 0x17FC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT255H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 256 low
\ Address offset: 0x1800
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT256L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT256L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT256L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 256 high
\ Address offset: 0x1804
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT256H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 257 low
\ Address offset: 0x1808
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT257L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT257L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT257L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 257 high
\ Address offset: 0x180C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT257H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 258 low
\ Address offset: 0x1810
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT258L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT258L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT258L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 258 high
\ Address offset: 0x1814
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT258H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 259 low
\ Address offset: 0x1818
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT259L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT259L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT259L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 259 high
\ Address offset: 0x181C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT259H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 260 low
\ Address offset: 0x1820
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT260L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT260L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT260L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 260 high
\ Address offset: 0x1824
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT260H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 261 low
\ Address offset: 0x1828
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT261L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT261L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT261L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 261 high
\ Address offset: 0x182C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT261H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 262 low
\ Address offset: 0x1830
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT262L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT262L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT262L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 262 high
\ Address offset: 0x1834
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT262H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 263 low
\ Address offset: 0x1838
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT263L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT263L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT263L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 263 high
\ Address offset: 0x183C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT263H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 264 low
\ Address offset: 0x1840
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT264L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT264L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT264L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 264 high
\ Address offset: 0x1844
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT264H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 265 low
\ Address offset: 0x1848
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT265L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT265L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT265L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 265 high
\ Address offset: 0x184C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT265H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 266 low
\ Address offset: 0x1850
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT266L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT266L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT266L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 266 high
\ Address offset: 0x1854
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT266H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 267 low
\ Address offset: 0x1858
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT267L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT267L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT267L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 267 high
\ Address offset: 0x185C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT267H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 268 low
\ Address offset: 0x1860
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT268L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT268L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT268L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 268 high
\ Address offset: 0x1864
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT268H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 269 low
\ Address offset: 0x1868
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT269L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT269L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT269L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 269 high
\ Address offset: 0x186C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT269H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 270 low
\ Address offset: 0x1870
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT270L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT270L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT270L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 270 high
\ Address offset: 0x1874
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT270H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 271 low
\ Address offset: 0x1878
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT271L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT271L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT271L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 271 high
\ Address offset: 0x187C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT271H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 272 low
\ Address offset: 0x1880
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT272L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT272L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT272L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 272 high
\ Address offset: 0x1884
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT272H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 273 low
\ Address offset: 0x1888
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT273L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT273L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT273L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 273 high
\ Address offset: 0x188C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT273H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 274 low
\ Address offset: 0x1890
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT274L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT274L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT274L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 274 high
\ Address offset: 0x1894
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT274H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 275 low
\ Address offset: 0x1898
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT275L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT275L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT275L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 275 high
\ Address offset: 0x189C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT275H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 276 low
\ Address offset: 0x18A0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT276L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT276L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT276L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 276 high
\ Address offset: 0x18A4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT276H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 277 low
\ Address offset: 0x18A8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT277L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT277L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT277L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 277 high
\ Address offset: 0x18AC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT277H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 278 low
\ Address offset: 0x18B0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT278L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT278L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT278L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 278 high
\ Address offset: 0x18B4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT278H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 279 low
\ Address offset: 0x18B8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT279L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT279L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT279L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 279 high
\ Address offset: 0x18BC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT279H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 280 low
\ Address offset: 0x18C0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT280L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT280L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT280L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 280 high
\ Address offset: 0x18C4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT280H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 281 low
\ Address offset: 0x18C8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT281L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT281L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT281L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 281 high
\ Address offset: 0x18CC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT281H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 282 low
\ Address offset: 0x18D0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT282L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT282L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT282L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 282 high
\ Address offset: 0x18D4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT282H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 283 low
\ Address offset: 0x18D8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT283L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT283L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT283L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 283 high
\ Address offset: 0x18DC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT283H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 284 low
\ Address offset: 0x18E0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT284L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT284L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT284L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 284 high
\ Address offset: 0x18E4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT284H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 285 low
\ Address offset: 0x18E8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT285L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT285L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT285L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 285 high
\ Address offset: 0x18EC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT285H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 286 low
\ Address offset: 0x18F0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT286L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT286L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT286L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 286 high
\ Address offset: 0x18F4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT286H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 287 low
\ Address offset: 0x18F8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT287L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT287L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT287L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 287 high
\ Address offset: 0x18FC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT287H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 288 low
\ Address offset: 0x1900
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT288L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT288L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT288L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 288 high
\ Address offset: 0x1904
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT288H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 289 low
\ Address offset: 0x1908
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT289L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT289L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT289L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 289 high
\ Address offset: 0x190C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT289H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 290 low
\ Address offset: 0x1910
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT290L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT290L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT290L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 290 high
\ Address offset: 0x1914
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT290H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 291 low
\ Address offset: 0x1918
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT291L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT291L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT291L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 291 high
\ Address offset: 0x191C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT291H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 292 low
\ Address offset: 0x1920
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT292L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT292L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT292L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 292 high
\ Address offset: 0x1924
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT292H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 293 low
\ Address offset: 0x1928
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT293L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT293L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT293L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 293 high
\ Address offset: 0x192C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT293H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 294 low
\ Address offset: 0x1930
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT294L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT294L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT294L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 294 high
\ Address offset: 0x1934
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT294H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 295 low
\ Address offset: 0x1938
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT295L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT295L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT295L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 295 high
\ Address offset: 0x193C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT295H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 296 low
\ Address offset: 0x1940
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT296L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT296L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT296L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 296 high
\ Address offset: 0x1944
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT296H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 297 low
\ Address offset: 0x1948
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT297L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT297L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT297L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 297 high
\ Address offset: 0x194C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT297H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 298 low
\ Address offset: 0x1950
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT298L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT298L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT298L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 298 high
\ Address offset: 0x1954
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT298H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 299 low
\ Address offset: 0x1958
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT299L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT299L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT299L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 299 high
\ Address offset: 0x195C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT299H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 300 low
\ Address offset: 0x1960
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT300L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT300L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT300L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 300 high
\ Address offset: 0x1964
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT300H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 301 low
\ Address offset: 0x1968
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT301L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT301L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT301L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 301 high
\ Address offset: 0x196C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT301H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 302 low
\ Address offset: 0x1970
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT302L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT302L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT302L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 302 high
\ Address offset: 0x1974
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT302H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 303 low
\ Address offset: 0x1978
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT303L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT303L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT303L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 303 high
\ Address offset: 0x197C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT303H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 304 low
\ Address offset: 0x1980
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT304L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT304L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT304L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 304 high
\ Address offset: 0x1984
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT304H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 305 low
\ Address offset: 0x1988
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT305L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT305L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT305L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 305 high
\ Address offset: 0x198C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT305H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 306 low
\ Address offset: 0x1990
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT306L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT306L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT306L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 306 high
\ Address offset: 0x1994
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT306H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 307 low
\ Address offset: 0x1998
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT307L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT307L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT307L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 307 high
\ Address offset: 0x199C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT307H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 308 low
\ Address offset: 0x19A0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT308L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT308L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT308L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 308 high
\ Address offset: 0x19A4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT308H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 309 low
\ Address offset: 0x19A8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT309L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT309L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT309L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 309 high
\ Address offset: 0x19AC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT309H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 310 low
\ Address offset: 0x19B0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT310L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT310L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT310L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 310 high
\ Address offset: 0x19B4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT310H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 311 low
\ Address offset: 0x19B8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT311L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT311L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT311L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 311 high
\ Address offset: 0x19BC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT311H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 312 low
\ Address offset: 0x19C0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT312L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT312L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT312L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 312 high
\ Address offset: 0x19C4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT312H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 313 low
\ Address offset: 0x19C8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT313L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT313L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT313L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 313 high
\ Address offset: 0x19CC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT313H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 314 low
\ Address offset: 0x19D0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT314L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT314L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT314L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 314 high
\ Address offset: 0x19D4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT314H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 315 low
\ Address offset: 0x19D8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT315L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT315L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT315L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 315 high
\ Address offset: 0x19DC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT315H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 316 low
\ Address offset: 0x19E0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT316L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT316L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT316L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 316 high
\ Address offset: 0x19E4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT316H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 317 low
\ Address offset: 0x19E8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT317L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT317L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT317L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 317 high
\ Address offset: 0x19EC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT317H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 318 low
\ Address offset: 0x19F0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT318L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT318L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT318L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 318 high
\ Address offset: 0x19F4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT318H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 319 low
\ Address offset: 0x19F8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT319L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT319L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT319L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 319 high
\ Address offset: 0x19FC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT319H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 320 low
\ Address offset: 0x1A00
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT320L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT320L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT320L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 320 high
\ Address offset: 0x1A04
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT320H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 321 low
\ Address offset: 0x1A08
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT321L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT321L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT321L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 321 high
\ Address offset: 0x1A0C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT321H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 322 low
\ Address offset: 0x1A10
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT322L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT322L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT322L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 322 high
\ Address offset: 0x1A14
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT322H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 323 low
\ Address offset: 0x1A18
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT323L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT323L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT323L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 323 high
\ Address offset: 0x1A1C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT323H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 324 low
\ Address offset: 0x1A20
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT324L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT324L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT324L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 324 high
\ Address offset: 0x1A24
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT324H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 325 low
\ Address offset: 0x1A28
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT325L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT325L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT325L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 325 high
\ Address offset: 0x1A2C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT325H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 326 low
\ Address offset: 0x1A30
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT326L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT326L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT326L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 326 high
\ Address offset: 0x1A34
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT326H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 327 low
\ Address offset: 0x1A38
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT327L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT327L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT327L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 327 high
\ Address offset: 0x1A3C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT327H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 328 low
\ Address offset: 0x1A40
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT328L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT328L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT328L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 328 high
\ Address offset: 0x1A44
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT328H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 329 low
\ Address offset: 0x1A48
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT329L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT329L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT329L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 329 high
\ Address offset: 0x1A4C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT329H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 330 low
\ Address offset: 0x1A50
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT330L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT330L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT330L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 330 high
\ Address offset: 0x1A54
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT330H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 331 low
\ Address offset: 0x1A58
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT331L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT331L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT331L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 331 high
\ Address offset: 0x1A5C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT331H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 332 low
\ Address offset: 0x1A60
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT332L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT332L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT332L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 332 high
\ Address offset: 0x1A64
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT332H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 333 low
\ Address offset: 0x1A68
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT333L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT333L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT333L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 333 high
\ Address offset: 0x1A6C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT333H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 334 low
\ Address offset: 0x1A70
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT334L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT334L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT334L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 334 high
\ Address offset: 0x1A74
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT334H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 335 low
\ Address offset: 0x1A78
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT335L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT335L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT335L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 335 high
\ Address offset: 0x1A7C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT335H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 336 low
\ Address offset: 0x1A80
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT336L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT336L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT336L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 336 high
\ Address offset: 0x1A84
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT336H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 337 low
\ Address offset: 0x1A88
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT337L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT337L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT337L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 337 high
\ Address offset: 0x1A8C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT337H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 338 low
\ Address offset: 0x1A90
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT338L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT338L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT338L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 338 high
\ Address offset: 0x1A94
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT338H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 339 low
\ Address offset: 0x1A98
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT339L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT339L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT339L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 339 high
\ Address offset: 0x1A9C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT339H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 340 low
\ Address offset: 0x1AA0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT340L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT340L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT340L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 340 high
\ Address offset: 0x1AA4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT340H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 341 low
\ Address offset: 0x1AA8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT341L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT341L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT341L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 341 high
\ Address offset: 0x1AAC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT341H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 342 low
\ Address offset: 0x1AB0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT342L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT342L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT342L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 342 high
\ Address offset: 0x1AB4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT342H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 343 low
\ Address offset: 0x1AB8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT343L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT343L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT343L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 343 high
\ Address offset: 0x1ABC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT343H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 344 low
\ Address offset: 0x1AC0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT344L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT344L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT344L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 344 high
\ Address offset: 0x1AC4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT344H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 345 low
\ Address offset: 0x1AC8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT345L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT345L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT345L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 345 high
\ Address offset: 0x1ACC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT345H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 346 low
\ Address offset: 0x1AD0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT346L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT346L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT346L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 346 high
\ Address offset: 0x1AD4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT346H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 347 low
\ Address offset: 0x1AD8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT347L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT347L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT347L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 347 high
\ Address offset: 0x1ADC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT347H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 348 low
\ Address offset: 0x1AE0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT348L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT348L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT348L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 348 high
\ Address offset: 0x1AE4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT348H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 349 low
\ Address offset: 0x1AE8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT349L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT349L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT349L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 349 high
\ Address offset: 0x1AEC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT349H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 350 low
\ Address offset: 0x1AF0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT350L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT350L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT350L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 350 high
\ Address offset: 0x1AF4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT350H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 351 low
\ Address offset: 0x1AF8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT351L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT351L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT351L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 351 high
\ Address offset: 0x1AFC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT351H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 352 low
\ Address offset: 0x1B00
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT352L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT352L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT352L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 352 high
\ Address offset: 0x1B04
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT352H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 353 low
\ Address offset: 0x1B08
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT353L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT353L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT353L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 353 high
\ Address offset: 0x1B0C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT353H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 354 low
\ Address offset: 0x1B10
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT354L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT354L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT354L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 354 high
\ Address offset: 0x1B14
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT354H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 355 low
\ Address offset: 0x1B18
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT355L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT355L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT355L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 355 high
\ Address offset: 0x1B1C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT355H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 356 low
\ Address offset: 0x1B20
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT356L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT356L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT356L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 356 high
\ Address offset: 0x1B24
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT356H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 357 low
\ Address offset: 0x1B28
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT357L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT357L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT357L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 357 high
\ Address offset: 0x1B2C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT357H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 358 low
\ Address offset: 0x1B30
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT358L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT358L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT358L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 358 high
\ Address offset: 0x1B34
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT358H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 359 low
\ Address offset: 0x1B38
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT359L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT359L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT359L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 359 high
\ Address offset: 0x1B3C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT359H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 360 low
\ Address offset: 0x1B40
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT360L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT360L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT360L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 360 high
\ Address offset: 0x1B44
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT360H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 361 low
\ Address offset: 0x1B48
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT361L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT361L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT361L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 361 high
\ Address offset: 0x1B4C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT361H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 362 low
\ Address offset: 0x1B50
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT362L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT362L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT362L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 362 high
\ Address offset: 0x1B54
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT362H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 363 low
\ Address offset: 0x1B58
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT363L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT363L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT363L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 363 high
\ Address offset: 0x1B5C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT363H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 364 low
\ Address offset: 0x1B60
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT364L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT364L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT364L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 364 high
\ Address offset: 0x1B64
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT364H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 365 low
\ Address offset: 0x1B68
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT365L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT365L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT365L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 365 high
\ Address offset: 0x1B6C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT365H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 366 low
\ Address offset: 0x1B70
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT366L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT366L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT366L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 366 high
\ Address offset: 0x1B74
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT366H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 367 low
\ Address offset: 0x1B78
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT367L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT367L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT367L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 367 high
\ Address offset: 0x1B7C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT367H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 368 low
\ Address offset: 0x1B80
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT368L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT368L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT368L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 368 high
\ Address offset: 0x1B84
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT368H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 369 low
\ Address offset: 0x1B88
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT369L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT369L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT369L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 369 high
\ Address offset: 0x1B8C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT369H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 370 low
\ Address offset: 0x1B90
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT370L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT370L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT370L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 370 high
\ Address offset: 0x1B94
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT370H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 371 low
\ Address offset: 0x1B98
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT371L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT371L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT371L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 371 high
\ Address offset: 0x1B9C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT371H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 372 low
\ Address offset: 0x1BA0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT372L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT372L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT372L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 372 high
\ Address offset: 0x1BA4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT372H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 373 low
\ Address offset: 0x1BA8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT373L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT373L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT373L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 373 high
\ Address offset: 0x1BAC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT373H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 374 low
\ Address offset: 0x1BB0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT374L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT374L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT374L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 374 high
\ Address offset: 0x1BB4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT374H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 375 low
\ Address offset: 0x1BB8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT375L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT375L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT375L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 375 high
\ Address offset: 0x1BBC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT375H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 376 low
\ Address offset: 0x1BC0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT376L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT376L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT376L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 376 high
\ Address offset: 0x1BC4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT376H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 377 low
\ Address offset: 0x1BC8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT377L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT377L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT377L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 377 high
\ Address offset: 0x1BCC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT377H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 378 low
\ Address offset: 0x1BD0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT378L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT378L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT378L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 378 high
\ Address offset: 0x1BD4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT378H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 379 low
\ Address offset: 0x1BD8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT379L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT379L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT379L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 379 high
\ Address offset: 0x1BDC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT379H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 380 low
\ Address offset: 0x1BE0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT380L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT380L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT380L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 380 high
\ Address offset: 0x1BE4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT380H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 381 low
\ Address offset: 0x1BE8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT381L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT381L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT381L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 381 high
\ Address offset: 0x1BEC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT381H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 382 low
\ Address offset: 0x1BF0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT382L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT382L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT382L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 382 high
\ Address offset: 0x1BF4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT382H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 383 low
\ Address offset: 0x1BF8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT383L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT383L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT383L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 383 high
\ Address offset: 0x1BFC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT383H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 384 low
\ Address offset: 0x1C00
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT384L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT384L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT384L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 384 high
\ Address offset: 0x1C04
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT384H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 385 low
\ Address offset: 0x1C08
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT385L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT385L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT385L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 385 high
\ Address offset: 0x1C0C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT385H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 386 low
\ Address offset: 0x1C10
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT386L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT386L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT386L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 386 high
\ Address offset: 0x1C14
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT386H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 387 low
\ Address offset: 0x1C18
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT387L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT387L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT387L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 387 high
\ Address offset: 0x1C1C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT387H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 388 low
\ Address offset: 0x1C20
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT388L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT388L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT388L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 388 high
\ Address offset: 0x1C24
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT388H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 389 low
\ Address offset: 0x1C28
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT389L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT389L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT389L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 389 high
\ Address offset: 0x1C2C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT389H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 390 low
\ Address offset: 0x1C30
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT390L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT390L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT390L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 390 high
\ Address offset: 0x1C34
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT390H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 391 low
\ Address offset: 0x1C38
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT391L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT391L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT391L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 391 high
\ Address offset: 0x1C3C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT391H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 392 low
\ Address offset: 0x1C40
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT392L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT392L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT392L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 392 high
\ Address offset: 0x1C44
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT392H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 393 low
\ Address offset: 0x1C48
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT393L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT393L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT393L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 393 high
\ Address offset: 0x1C4C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT393H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 394 low
\ Address offset: 0x1C50
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT394L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT394L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT394L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 394 high
\ Address offset: 0x1C54
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT394H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 395 low
\ Address offset: 0x1C58
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT395L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT395L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT395L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 395 high
\ Address offset: 0x1C5C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT395H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 396 low
\ Address offset: 0x1C60
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT396L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT396L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT396L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 396 high
\ Address offset: 0x1C64
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT396H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 397 low
\ Address offset: 0x1C68
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT397L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT397L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT397L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 397 high
\ Address offset: 0x1C6C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT397H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 398 low
\ Address offset: 0x1C70
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT398L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT398L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT398L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 398 high
\ Address offset: 0x1C74
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT398H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 399 low
\ Address offset: 0x1C78
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT399L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT399L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT399L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 399 high
\ Address offset: 0x1C7C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT399H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 400 low
\ Address offset: 0x1C80
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT400L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT400L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT400L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 400 high
\ Address offset: 0x1C84
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT400H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 401 low
\ Address offset: 0x1C88
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT401L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT401L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT401L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 401 high
\ Address offset: 0x1C8C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT401H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 402 low
\ Address offset: 0x1C90
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT402L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT402L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT402L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 402 high
\ Address offset: 0x1C94
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT402H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 403 low
\ Address offset: 0x1C98
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT403L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT403L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT403L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 403 high
\ Address offset: 0x1C9C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT403H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 404 low
\ Address offset: 0x1CA0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT404L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT404L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT404L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 404 high
\ Address offset: 0x1CA4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT404H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 405 low
\ Address offset: 0x1CA8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT405L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT405L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT405L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 405 high
\ Address offset: 0x1CAC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT405H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 406 low
\ Address offset: 0x1CB0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT406L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT406L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT406L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 406 high
\ Address offset: 0x1CB4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT406H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 407 low
\ Address offset: 0x1CB8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT407L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT407L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT407L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 407 high
\ Address offset: 0x1CBC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT407H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 408 low
\ Address offset: 0x1CC0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT408L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT408L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT408L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 408 high
\ Address offset: 0x1CC4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT408H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 409 low
\ Address offset: 0x1CC8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT409L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT409L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT409L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 409 high
\ Address offset: 0x1CCC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT409H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 410 low
\ Address offset: 0x1CD0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT410L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT410L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT410L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 410 high
\ Address offset: 0x1CD4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT410H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 411 low
\ Address offset: 0x1CD8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT411L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT411L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT411L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 411 high
\ Address offset: 0x1CDC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT411H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 412 low
\ Address offset: 0x1CE0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT412L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT412L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT412L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 412 high
\ Address offset: 0x1CE4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT412H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 413 low
\ Address offset: 0x1CE8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT413L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT413L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT413L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 413 high
\ Address offset: 0x1CEC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT413H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 414 low
\ Address offset: 0x1CF0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT414L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT414L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT414L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 414 high
\ Address offset: 0x1CF4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT414H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 415 low
\ Address offset: 0x1CF8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT415L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT415L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT415L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 415 high
\ Address offset: 0x1CFC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT415H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 416 low
\ Address offset: 0x1D00
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT416L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT416L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT416L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 416 high
\ Address offset: 0x1D04
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT416H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 417 low
\ Address offset: 0x1D08
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT417L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT417L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT417L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 417 high
\ Address offset: 0x1D0C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT417H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 418 low
\ Address offset: 0x1D10
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT418L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT418L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT418L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 418 high
\ Address offset: 0x1D14
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT418H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 419 low
\ Address offset: 0x1D18
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT419L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT419L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT419L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 419 high
\ Address offset: 0x1D1C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT419H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 420 low
\ Address offset: 0x1D20
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT420L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT420L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT420L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 420 high
\ Address offset: 0x1D24
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT420H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 421 low
\ Address offset: 0x1D28
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT421L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT421L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT421L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 421 high
\ Address offset: 0x1D2C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT421H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 422 low
\ Address offset: 0x1D30
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT422L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT422L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT422L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 422 high
\ Address offset: 0x1D34
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT422H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 423 low
\ Address offset: 0x1D38
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT423L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT423L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT423L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 423 high
\ Address offset: 0x1D3C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT423H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 424 low
\ Address offset: 0x1D40
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT424L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT424L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT424L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 424 high
\ Address offset: 0x1D44
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT424H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 425 low
\ Address offset: 0x1D48
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT425L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT425L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT425L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 425 high
\ Address offset: 0x1D4C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT425H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 426 low
\ Address offset: 0x1D50
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT426L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT426L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT426L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 426 high
\ Address offset: 0x1D54
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT426H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 427 low
\ Address offset: 0x1D58
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT427L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT427L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT427L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 427 high
\ Address offset: 0x1D5C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT427H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 428 low
\ Address offset: 0x1D60
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT428L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT428L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT428L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 428 high
\ Address offset: 0x1D64
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT428H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 429 low
\ Address offset: 0x1D68
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT429L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT429L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT429L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 429 high
\ Address offset: 0x1D6C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT429H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 430 low
\ Address offset: 0x1D70
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT430L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT430L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT430L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 430 high
\ Address offset: 0x1D74
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT430H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 431 low
\ Address offset: 0x1D78
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT431L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT431L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT431L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 431 high
\ Address offset: 0x1D7C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT431H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 432 low
\ Address offset: 0x1D80
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT432L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT432L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT432L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 432 high
\ Address offset: 0x1D84
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT432H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 433 low
\ Address offset: 0x1D88
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT433L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT433L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT433L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 433 high
\ Address offset: 0x1D8C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT433H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 434 low
\ Address offset: 0x1D90
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT434L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT434L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT434L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 434 high
\ Address offset: 0x1D94
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT434H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 435 low
\ Address offset: 0x1D98
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT435L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT435L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT435L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 435 high
\ Address offset: 0x1D9C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT435H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 436 low
\ Address offset: 0x1DA0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT436L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT436L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT436L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 436 high
\ Address offset: 0x1DA4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT436H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 437 low
\ Address offset: 0x1DA8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT437L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT437L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT437L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 437 high
\ Address offset: 0x1DAC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT437H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 438 low
\ Address offset: 0x1DB0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT438L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT438L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT438L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 438 high
\ Address offset: 0x1DB4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT438H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 439 low
\ Address offset: 0x1DB8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT439L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT439L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT439L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 439 high
\ Address offset: 0x1DBC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT439H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 440 low
\ Address offset: 0x1DC0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT440L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT440L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT440L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 440 high
\ Address offset: 0x1DC4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT440H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 441 low
\ Address offset: 0x1DC8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT441L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT441L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT441L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 441 high
\ Address offset: 0x1DCC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT441H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 442 low
\ Address offset: 0x1DD0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT442L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT442L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT442L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 442 high
\ Address offset: 0x1DD4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT442H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 443 low
\ Address offset: 0x1DD8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT443L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT443L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT443L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 443 high
\ Address offset: 0x1DDC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT443H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 444 low
\ Address offset: 0x1DE0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT444L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT444L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT444L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 444 high
\ Address offset: 0x1DE4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT444H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 445 low
\ Address offset: 0x1DE8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT445L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT445L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT445L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 445 high
\ Address offset: 0x1DEC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT445H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 446 low
\ Address offset: 0x1DF0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT446L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT446L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT446L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 446 high
\ Address offset: 0x1DF4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT446H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 447 low
\ Address offset: 0x1DF8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT447L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT447L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT447L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 447 high
\ Address offset: 0x1DFC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT447H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 448 low
\ Address offset: 0x1E00
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT448L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT448L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT448L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 448 high
\ Address offset: 0x1E04
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT448H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 449 low
\ Address offset: 0x1E08
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT449L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT449L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT449L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 449 high
\ Address offset: 0x1E0C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT449H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 450 low
\ Address offset: 0x1E10
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT450L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT450L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT450L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 450 high
\ Address offset: 0x1E14
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT450H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 451 low
\ Address offset: 0x1E18
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT451L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT451L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT451L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 451 high
\ Address offset: 0x1E1C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT451H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 452 low
\ Address offset: 0x1E20
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT452L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT452L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT452L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 452 high
\ Address offset: 0x1E24
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT452H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 453 low
\ Address offset: 0x1E28
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT453L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT453L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT453L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 453 high
\ Address offset: 0x1E2C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT453H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 454 low
\ Address offset: 0x1E30
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT454L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT454L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT454L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 454 high
\ Address offset: 0x1E34
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT454H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 455 low
\ Address offset: 0x1E38
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT455L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT455L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT455L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 455 high
\ Address offset: 0x1E3C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT455H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 456 low
\ Address offset: 0x1E40
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT456L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT456L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT456L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 456 high
\ Address offset: 0x1E44
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT456H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 457 low
\ Address offset: 0x1E48
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT457L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT457L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT457L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 457 high
\ Address offset: 0x1E4C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT457H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 458 low
\ Address offset: 0x1E50
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT458L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT458L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT458L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 458 high
\ Address offset: 0x1E54
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT458H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 459 low
\ Address offset: 0x1E58
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT459L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT459L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT459L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 459 high
\ Address offset: 0x1E5C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT459H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 460 low
\ Address offset: 0x1E60
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT460L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT460L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT460L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 460 high
\ Address offset: 0x1E64
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT460H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 461 low
\ Address offset: 0x1E68
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT461L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT461L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT461L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 461 high
\ Address offset: 0x1E6C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT461H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 462 low
\ Address offset: 0x1E70
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT462L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT462L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT462L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 462 high
\ Address offset: 0x1E74
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT462H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 463 low
\ Address offset: 0x1E78
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT463L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT463L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT463L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 463 high
\ Address offset: 0x1E7C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT463H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 464 low
\ Address offset: 0x1E80
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT464L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT464L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT464L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 464 high
\ Address offset: 0x1E84
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT464H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 465 low
\ Address offset: 0x1E88
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT465L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT465L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT465L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 465 high
\ Address offset: 0x1E8C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT465H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 466 low
\ Address offset: 0x1E90
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT466L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT466L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT466L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 466 high
\ Address offset: 0x1E94
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT466H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 467 low
\ Address offset: 0x1E98
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT467L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT467L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT467L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 467 high
\ Address offset: 0x1E9C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT467H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 468 low
\ Address offset: 0x1EA0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT468L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT468L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT468L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 468 high
\ Address offset: 0x1EA4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT468H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 469 low
\ Address offset: 0x1EA8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT469L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT469L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT469L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 469 high
\ Address offset: 0x1EAC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT469H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 470 low
\ Address offset: 0x1EB0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT470L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT470L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT470L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 470 high
\ Address offset: 0x1EB4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT470H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 471 low
\ Address offset: 0x1EB8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT471L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT471L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT471L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 471 high
\ Address offset: 0x1EBC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT471H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 472 low
\ Address offset: 0x1EC0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT472L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT472L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT472L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 472 high
\ Address offset: 0x1EC4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT472H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 473 low
\ Address offset: 0x1EC8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT473L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT473L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT473L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 473 high
\ Address offset: 0x1ECC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT473H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 474 low
\ Address offset: 0x1ED0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT474L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT474L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT474L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 474 high
\ Address offset: 0x1ED4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT474H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 475 low
\ Address offset: 0x1ED8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT475L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT475L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT475L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 475 high
\ Address offset: 0x1EDC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT475H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 476 low
\ Address offset: 0x1EE0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT476L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT476L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT476L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 476 high
\ Address offset: 0x1EE4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT476H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 477 low
\ Address offset: 0x1EE8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT477L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT477L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT477L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 477 high
\ Address offset: 0x1EEC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT477H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 478 low
\ Address offset: 0x1EF0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT478L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT478L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT478L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 478 high
\ Address offset: 0x1EF4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT478H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 479 low
\ Address offset: 0x1EF8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT479L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT479L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT479L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 479 high
\ Address offset: 0x1EFC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT479H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 480 low
\ Address offset: 0x1F00
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT480L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT480L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT480L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 480 high
\ Address offset: 0x1F04
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT480H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 481 low
\ Address offset: 0x1F08
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT481L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT481L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT481L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 481 high
\ Address offset: 0x1F0C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT481H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 482 low
\ Address offset: 0x1F10
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT482L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT482L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT482L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 482 high
\ Address offset: 0x1F14
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT482H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 483 low
\ Address offset: 0x1F18
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT483L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT483L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT483L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 483 high
\ Address offset: 0x1F1C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT483H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 484 low
\ Address offset: 0x1F20
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT484L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT484L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT484L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 484 high
\ Address offset: 0x1F24
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT484H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 485 low
\ Address offset: 0x1F28
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT485L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT485L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT485L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 485 high
\ Address offset: 0x1F2C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT485H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 486 low
\ Address offset: 0x1F30
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT486L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT486L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT486L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 486 high
\ Address offset: 0x1F34
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT486H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 487 low
\ Address offset: 0x1F38
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT487L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT487L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT487L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 487 high
\ Address offset: 0x1F3C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT487H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 488 low
\ Address offset: 0x1F40
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT488L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT488L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT488L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 488 high
\ Address offset: 0x1F44
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT488H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 489 low
\ Address offset: 0x1F48
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT489L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT489L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT489L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 489 high
\ Address offset: 0x1F4C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT489H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 490 low
\ Address offset: 0x1F50
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT490L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT490L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT490L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 490 high
\ Address offset: 0x1F54
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT490H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 491 low
\ Address offset: 0x1F58
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT491L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT491L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT491L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 491 high
\ Address offset: 0x1F5C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT491H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 492 low
\ Address offset: 0x1F60
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT492L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT492L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT492L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 492 high
\ Address offset: 0x1F64
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT492H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 493 low
\ Address offset: 0x1F68
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT493L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT493L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT493L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 493 high
\ Address offset: 0x1F6C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT493H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 494 low
\ Address offset: 0x1F70
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT494L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT494L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT494L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 494 high
\ Address offset: 0x1F74
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT494H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 495 low
\ Address offset: 0x1F78
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT495L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT495L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT495L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 495 high
\ Address offset: 0x1F7C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT495H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 496 low
\ Address offset: 0x1F80
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT496L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT496L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT496L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 496 high
\ Address offset: 0x1F84
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT496H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 497 low
\ Address offset: 0x1F88
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT497L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT497L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT497L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 497 high
\ Address offset: 0x1F8C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT497H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 498 low
\ Address offset: 0x1F90
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT498L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT498L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT498L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 498 high
\ Address offset: 0x1F94
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT498H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 499 low
\ Address offset: 0x1F98
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT499L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT499L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT499L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 499 high
\ Address offset: 0x1F9C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT499H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 500 low
\ Address offset: 0x1FA0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT500L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT500L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT500L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 500 high
\ Address offset: 0x1FA4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT500H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 501 low
\ Address offset: 0x1FA8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT501L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT501L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT501L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 501 high
\ Address offset: 0x1FAC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT501H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 502 low
\ Address offset: 0x1FB0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT502L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT502L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT502L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 502 high
\ Address offset: 0x1FB4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT502H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 503 low
\ Address offset: 0x1FB8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT503L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT503L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT503L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 503 high
\ Address offset: 0x1FBC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT503H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 504 low
\ Address offset: 0x1FC0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT504L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT504L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT504L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 504 high
\ Address offset: 0x1FC4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT504H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 505 low
\ Address offset: 0x1FC8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT505L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT505L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT505L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 505 high
\ Address offset: 0x1FCC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT505H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 506 low
\ Address offset: 0x1FD0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT506L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT506L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT506L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 506 high
\ Address offset: 0x1FD4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT506H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 507 low
\ Address offset: 0x1FD8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT507L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT507L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT507L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 507 high
\ Address offset: 0x1FDC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT507H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 508 low
\ Address offset: 0x1FE0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT508L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT508L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT508L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 508 high
\ Address offset: 0x1FE4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT508H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 509 low
\ Address offset: 0x1FE8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT509L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT509L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT509L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 509 high
\ Address offset: 0x1FEC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT509H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 510 low
\ Address offset: 0x1FF0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT510L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT510L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT510L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 510 high
\ Address offset: 0x1FF4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT510H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 511 low
\ Address offset: 0x1FF8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT511L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT511L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT511L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 511 high
\ Address offset: 0x1FFC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT511H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 512 low
\ Address offset: 0x2000
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT512L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT512L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT512L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 512 high
\ Address offset: 0x2004
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT512H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 513 low
\ Address offset: 0x2008
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT513L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT513L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT513L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 513 high
\ Address offset: 0x200C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT513H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 514 low
\ Address offset: 0x2010
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT514L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT514L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT514L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 514 high
\ Address offset: 0x2014
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT514H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 515 low
\ Address offset: 0x2018
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT515L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT515L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT515L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 515 high
\ Address offset: 0x201C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT515H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 516 low
\ Address offset: 0x2020
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT516L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT516L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT516L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 516 high
\ Address offset: 0x2024
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT516H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 517 low
\ Address offset: 0x2028
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT517L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT517L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT517L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 517 high
\ Address offset: 0x202C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT517H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 518 low
\ Address offset: 0x2030
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT518L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT518L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT518L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 518 high
\ Address offset: 0x2034
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT518H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 519 low
\ Address offset: 0x2038
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT519L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT519L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT519L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 519 high
\ Address offset: 0x203C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT519H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 520 low
\ Address offset: 0x2040
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT520L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT520L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT520L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 520 high
\ Address offset: 0x2044
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT520H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 521 low
\ Address offset: 0x2048
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT521L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT521L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT521L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 521 high
\ Address offset: 0x204C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT521H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 522 low
\ Address offset: 0x2050
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT522L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT522L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT522L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 522 high
\ Address offset: 0x2054
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT522H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 523 low
\ Address offset: 0x2058
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT523L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT523L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT523L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 523 high
\ Address offset: 0x205C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT523H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 524 low
\ Address offset: 0x2060
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT524L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT524L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT524L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 524 high
\ Address offset: 0x2064
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT524H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 525 low
\ Address offset: 0x2068
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT525L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT525L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT525L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 525 high
\ Address offset: 0x206C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT525H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 526 low
\ Address offset: 0x2070
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT526L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT526L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT526L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 526 high
\ Address offset: 0x2074
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT526H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 527 low
\ Address offset: 0x2078
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT527L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT527L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT527L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 527 high
\ Address offset: 0x207C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT527H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 528 low
\ Address offset: 0x2080
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT528L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT528L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT528L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 528 high
\ Address offset: 0x2084
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT528H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 529 low
\ Address offset: 0x2088
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT529L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT529L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT529L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 529 high
\ Address offset: 0x208C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT529H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 530 low
\ Address offset: 0x2090
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT530L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT530L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT530L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 530 high
\ Address offset: 0x2094
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT530H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 531 low
\ Address offset: 0x2098
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT531L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT531L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT531L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 531 high
\ Address offset: 0x209C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT531H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 532 low
\ Address offset: 0x20A0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT532L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT532L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT532L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 532 high
\ Address offset: 0x20A4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT532H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 533 low
\ Address offset: 0x20A8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT533L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT533L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT533L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 533 high
\ Address offset: 0x20AC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT533H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 534 low
\ Address offset: 0x20B0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT534L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT534L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT534L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 534 high
\ Address offset: 0x20B4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT534H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 535 low
\ Address offset: 0x20B8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT535L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT535L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT535L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 535 high
\ Address offset: 0x20BC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT535H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 536 low
\ Address offset: 0x20C0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT536L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT536L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT536L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 536 high
\ Address offset: 0x20C4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT536H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 537 low
\ Address offset: 0x20C8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT537L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT537L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT537L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 537 high
\ Address offset: 0x20CC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT537H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 538 low
\ Address offset: 0x20D0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT538L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT538L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT538L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 538 high
\ Address offset: 0x20D4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT538H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 539 low
\ Address offset: 0x20D8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT539L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT539L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT539L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 539 high
\ Address offset: 0x20DC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT539H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 540 low
\ Address offset: 0x20E0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT540L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT540L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT540L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 540 high
\ Address offset: 0x20E4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT540H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 541 low
\ Address offset: 0x20E8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT541L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT541L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT541L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 541 high
\ Address offset: 0x20EC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT541H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 542 low
\ Address offset: 0x20F0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT542L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT542L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT542L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 542 high
\ Address offset: 0x20F4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT542H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 543 low
\ Address offset: 0x20F8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT543L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT543L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT543L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 543 high
\ Address offset: 0x20FC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT543H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 544 low
\ Address offset: 0x2100
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT544L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT544L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT544L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 544 high
\ Address offset: 0x2104
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT544H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 545 low
\ Address offset: 0x2108
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT545L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT545L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT545L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 545 high
\ Address offset: 0x210C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT545H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 546 low
\ Address offset: 0x2110
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT546L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT546L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT546L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 546 high
\ Address offset: 0x2114
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT546H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 547 low
\ Address offset: 0x2118
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT547L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT547L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT547L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 547 high
\ Address offset: 0x211C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT547H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 548 low
\ Address offset: 0x2120
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT548L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT548L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT548L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 548 high
\ Address offset: 0x2124
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT548H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 549 low
\ Address offset: 0x2128
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT549L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT549L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT549L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 549 high
\ Address offset: 0x212C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT549H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 550 low
\ Address offset: 0x2130
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT550L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT550L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT550L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 550 high
\ Address offset: 0x2134
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT550H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 551 low
\ Address offset: 0x2138
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT551L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT551L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT551L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 551 high
\ Address offset: 0x213C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT551H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 552 low
\ Address offset: 0x2140
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT552L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT552L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT552L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 552 high
\ Address offset: 0x2144
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT552H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 553 low
\ Address offset: 0x2148
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT553L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT553L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT553L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 553 high
\ Address offset: 0x214C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT553H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 554 low
\ Address offset: 0x2150
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT554L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT554L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT554L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 554 high
\ Address offset: 0x2154
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT554H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 555 low
\ Address offset: 0x2158
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT555L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT555L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT555L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 555 high
\ Address offset: 0x215C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT555H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 556 low
\ Address offset: 0x2160
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT556L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT556L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT556L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 556 high
\ Address offset: 0x2164
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT556H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 557 low
\ Address offset: 0x2168
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT557L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT557L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT557L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 557 high
\ Address offset: 0x216C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT557H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 558 low
\ Address offset: 0x2170
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT558L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT558L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT558L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 558 high
\ Address offset: 0x2174
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT558H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 559 low
\ Address offset: 0x2178
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT559L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT559L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT559L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 559 high
\ Address offset: 0x217C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT559H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 560 low
\ Address offset: 0x2180
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT560L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT560L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT560L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 560 high
\ Address offset: 0x2184
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT560H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 561 low
\ Address offset: 0x2188
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT561L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT561L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT561L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 561 high
\ Address offset: 0x218C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT561H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 562 low
\ Address offset: 0x2190
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT562L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT562L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT562L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 562 high
\ Address offset: 0x2194
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT562H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 563 low
\ Address offset: 0x2198
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT563L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT563L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT563L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 563 high
\ Address offset: 0x219C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT563H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 564 low
\ Address offset: 0x21A0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT564L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT564L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT564L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 564 high
\ Address offset: 0x21A4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT564H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 565 low
\ Address offset: 0x21A8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT565L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT565L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT565L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 565 high
\ Address offset: 0x21AC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT565H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 566 low
\ Address offset: 0x21B0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT566L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT566L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT566L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 566 high
\ Address offset: 0x21B4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT566H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 567 low
\ Address offset: 0x21B8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT567L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT567L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT567L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 567 high
\ Address offset: 0x21BC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT567H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 568 low
\ Address offset: 0x21C0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT568L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT568L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT568L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 568 high
\ Address offset: 0x21C4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT568H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 569 low
\ Address offset: 0x21C8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT569L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT569L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT569L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 569 high
\ Address offset: 0x21CC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT569H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 570 low
\ Address offset: 0x21D0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT570L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT570L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT570L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 570 high
\ Address offset: 0x21D4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT570H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 571 low
\ Address offset: 0x21D8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT571L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT571L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT571L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 571 high
\ Address offset: 0x21DC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT571H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 572 low
\ Address offset: 0x21E0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT572L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT572L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT572L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 572 high
\ Address offset: 0x21E4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT572H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 573 low
\ Address offset: 0x21E8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT573L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT573L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT573L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 573 high
\ Address offset: 0x21EC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT573H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 574 low
\ Address offset: 0x21F0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT574L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT574L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT574L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 574 high
\ Address offset: 0x21F4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT574H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 575 low
\ Address offset: 0x21F8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT575L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT575L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT575L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 575 high
\ Address offset: 0x21FC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT575H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 576 low
\ Address offset: 0x2200
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT576L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT576L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT576L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 576 high
\ Address offset: 0x2204
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT576H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 577 low
\ Address offset: 0x2208
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT577L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT577L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT577L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 577 high
\ Address offset: 0x220C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT577H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 578 low
\ Address offset: 0x2210
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT578L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT578L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT578L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 578 high
\ Address offset: 0x2214
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT578H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 579 low
\ Address offset: 0x2218
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT579L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT579L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT579L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 579 high
\ Address offset: 0x221C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT579H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 580 low
\ Address offset: 0x2220
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT580L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT580L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT580L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 580 high
\ Address offset: 0x2224
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT580H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 581 low
\ Address offset: 0x2228
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT581L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT581L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT581L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 581 high
\ Address offset: 0x222C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT581H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 582 low
\ Address offset: 0x2230
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT582L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT582L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT582L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 582 high
\ Address offset: 0x2234
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT582H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 583 low
\ Address offset: 0x2238
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT583L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT583L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT583L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 583 high
\ Address offset: 0x223C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT583H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 584 low
\ Address offset: 0x2240
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT584L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT584L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT584L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 584 high
\ Address offset: 0x2244
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT584H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 585 low
\ Address offset: 0x2248
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT585L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT585L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT585L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 585 high
\ Address offset: 0x224C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT585H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 586 low
\ Address offset: 0x2250
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT586L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT586L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT586L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 586 high
\ Address offset: 0x2254
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT586H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 587 low
\ Address offset: 0x2258
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT587L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT587L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT587L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 587 high
\ Address offset: 0x225C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT587H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 588 low
\ Address offset: 0x2260
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT588L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT588L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT588L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 588 high
\ Address offset: 0x2264
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT588H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 589 low
\ Address offset: 0x2268
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT589L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT589L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT589L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 589 high
\ Address offset: 0x226C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT589H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 590 low
\ Address offset: 0x2270
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT590L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT590L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT590L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 590 high
\ Address offset: 0x2274
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT590H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 591 low
\ Address offset: 0x2278
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT591L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT591L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT591L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 591 high
\ Address offset: 0x227C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT591H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 592 low
\ Address offset: 0x2280
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT592L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT592L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT592L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 592 high
\ Address offset: 0x2284
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT592H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 593 low
\ Address offset: 0x2288
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT593L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT593L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT593L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 593 high
\ Address offset: 0x228C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT593H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 594 low
\ Address offset: 0x2290
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT594L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT594L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT594L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 594 high
\ Address offset: 0x2294
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT594H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 595 low
\ Address offset: 0x2298
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT595L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT595L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT595L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 595 high
\ Address offset: 0x229C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT595H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 596 low
\ Address offset: 0x22A0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT596L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT596L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT596L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 596 high
\ Address offset: 0x22A4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT596H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 597 low
\ Address offset: 0x22A8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT597L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT597L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT597L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 597 high
\ Address offset: 0x22AC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT597H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 598 low
\ Address offset: 0x22B0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT598L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT598L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT598L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 598 high
\ Address offset: 0x22B4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT598H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 599 low
\ Address offset: 0x22B8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT599L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT599L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT599L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 599 high
\ Address offset: 0x22BC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT599H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 600 low
\ Address offset: 0x22C0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT600L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT600L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT600L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 600 high
\ Address offset: 0x22C4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT600H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 601 low
\ Address offset: 0x22C8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT601L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT601L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT601L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 601 high
\ Address offset: 0x22CC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT601H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 602 low
\ Address offset: 0x22D0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT602L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT602L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT602L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 602 high
\ Address offset: 0x22D4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT602H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 603 low
\ Address offset: 0x22D8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT603L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT603L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT603L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 603 high
\ Address offset: 0x22DC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT603H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 604 low
\ Address offset: 0x22E0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT604L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT604L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT604L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 604 high
\ Address offset: 0x22E4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT604H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 605 low
\ Address offset: 0x22E8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT605L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT605L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT605L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 605 high
\ Address offset: 0x22EC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT605H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 606 low
\ Address offset: 0x22F0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT606L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT606L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT606L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 606 high
\ Address offset: 0x22F4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT606H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 607 low
\ Address offset: 0x22F8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT607L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT607L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT607L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 607 high
\ Address offset: 0x22FC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT607H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 608 low
\ Address offset: 0x2300
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT608L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT608L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT608L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 608 high
\ Address offset: 0x2304
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT608H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 609 low
\ Address offset: 0x2308
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT609L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT609L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT609L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 609 high
\ Address offset: 0x230C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT609H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 610 low
\ Address offset: 0x2310
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT610L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT610L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT610L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 610 high
\ Address offset: 0x2314
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT610H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 611 low
\ Address offset: 0x2318
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT611L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT611L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT611L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 611 high
\ Address offset: 0x231C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT611H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 612 low
\ Address offset: 0x2320
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT612L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT612L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT612L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 612 high
\ Address offset: 0x2324
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT612H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 613 low
\ Address offset: 0x2328
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT613L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT613L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT613L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 613 high
\ Address offset: 0x232C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT613H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 614 low
\ Address offset: 0x2330
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT614L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT614L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT614L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 614 high
\ Address offset: 0x2334
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT614H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 615 low
\ Address offset: 0x2338
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT615L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT615L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT615L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 615 high
\ Address offset: 0x233C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT615H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 616 low
\ Address offset: 0x2340
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT616L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT616L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT616L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 616 high
\ Address offset: 0x2344
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT616H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 617 low
\ Address offset: 0x2348
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT617L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT617L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT617L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 617 high
\ Address offset: 0x234C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT617H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 618 low
\ Address offset: 0x2350
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT618L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT618L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT618L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 618 high
\ Address offset: 0x2354
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT618H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 619 low
\ Address offset: 0x2358
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT619L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT619L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT619L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 619 high
\ Address offset: 0x235C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT619H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 620 low
\ Address offset: 0x2360
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT620L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT620L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT620L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 620 high
\ Address offset: 0x2364
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT620H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 621 low
\ Address offset: 0x2368
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT621L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT621L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT621L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 621 high
\ Address offset: 0x236C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT621H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 622 low
\ Address offset: 0x2370
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT622L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT622L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT622L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 622 high
\ Address offset: 0x2374
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT622H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 623 low
\ Address offset: 0x2378
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT623L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT623L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT623L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 623 high
\ Address offset: 0x237C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT623H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 624 low
\ Address offset: 0x2380
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT624L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT624L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT624L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 624 high
\ Address offset: 0x2384
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT624H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 625 low
\ Address offset: 0x2388
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT625L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT625L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT625L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 625 high
\ Address offset: 0x238C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT625H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 626 low
\ Address offset: 0x2390
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT626L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT626L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT626L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 626 high
\ Address offset: 0x2394
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT626H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 627 low
\ Address offset: 0x2398
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT627L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT627L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT627L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 627 high
\ Address offset: 0x239C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT627H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 628 low
\ Address offset: 0x23A0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT628L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT628L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT628L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 628 high
\ Address offset: 0x23A4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT628H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 629 low
\ Address offset: 0x23A8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT629L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT629L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT629L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 629 high
\ Address offset: 0x23AC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT629H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 630 low
\ Address offset: 0x23B0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT630L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT630L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT630L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 630 high
\ Address offset: 0x23B4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT630H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 631 low
\ Address offset: 0x23B8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT631L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT631L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT631L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 631 high
\ Address offset: 0x23BC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT631H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 632 low
\ Address offset: 0x23C0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT632L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT632L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT632L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 632 high
\ Address offset: 0x23C4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT632H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 633 low
\ Address offset: 0x23C8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT633L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT633L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT633L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 633 high
\ Address offset: 0x23CC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT633H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 634 low
\ Address offset: 0x23D0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT634L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT634L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT634L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 634 high
\ Address offset: 0x23D4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT634H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 635 low
\ Address offset: 0x23D8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT635L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT635L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT635L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 635 high
\ Address offset: 0x23DC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT635H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 636 low
\ Address offset: 0x23E0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT636L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT636L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT636L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 636 high
\ Address offset: 0x23E4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT636H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 637 low
\ Address offset: 0x23E8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT637L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT637L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT637L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 637 high
\ Address offset: 0x23EC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT637H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 638 low
\ Address offset: 0x23F0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT638L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT638L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT638L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 638 high
\ Address offset: 0x23F4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT638H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 639 low
\ Address offset: 0x23F8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT639L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT639L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT639L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 639 high
\ Address offset: 0x23FC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT639H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 640 low
\ Address offset: 0x2400
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT640L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT640L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT640L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 640 high
\ Address offset: 0x2404
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT640H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 641 low
\ Address offset: 0x2408
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT641L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT641L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT641L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 641 high
\ Address offset: 0x240C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT641H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 642 low
\ Address offset: 0x2410
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT642L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT642L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT642L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 642 high
\ Address offset: 0x2414
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT642H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 643 low
\ Address offset: 0x2418
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT643L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT643L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT643L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 643 high
\ Address offset: 0x241C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT643H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 644 low
\ Address offset: 0x2420
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT644L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT644L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT644L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 644 high
\ Address offset: 0x2424
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT644H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 645 low
\ Address offset: 0x2428
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT645L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT645L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT645L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 645 high
\ Address offset: 0x242C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT645H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 646 low
\ Address offset: 0x2430
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT646L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT646L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT646L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 646 high
\ Address offset: 0x2434
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT646H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 647 low
\ Address offset: 0x2438
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT647L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT647L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT647L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 647 high
\ Address offset: 0x243C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT647H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 648 low
\ Address offset: 0x2440
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT648L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT648L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT648L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 648 high
\ Address offset: 0x2444
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT648H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 649 low
\ Address offset: 0x2448
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT649L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT649L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT649L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 649 high
\ Address offset: 0x244C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT649H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 650 low
\ Address offset: 0x2450
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT650L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT650L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT650L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 650 high
\ Address offset: 0x2454
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT650H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 651 low
\ Address offset: 0x2458
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT651L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT651L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT651L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 651 high
\ Address offset: 0x245C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT651H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 652 low
\ Address offset: 0x2460
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT652L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT652L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT652L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 652 high
\ Address offset: 0x2464
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT652H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 653 low
\ Address offset: 0x2468
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT653L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT653L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT653L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 653 high
\ Address offset: 0x246C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT653H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 654 low
\ Address offset: 0x2470
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT654L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT654L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT654L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 654 high
\ Address offset: 0x2474
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT654H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 655 low
\ Address offset: 0x2478
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT655L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT655L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT655L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 655 high
\ Address offset: 0x247C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT655H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 656 low
\ Address offset: 0x2480
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT656L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT656L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT656L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 656 high
\ Address offset: 0x2484
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT656H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 657 low
\ Address offset: 0x2488
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT657L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT657L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT657L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 657 high
\ Address offset: 0x248C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT657H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 658 low
\ Address offset: 0x2490
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT658L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT658L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT658L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 658 high
\ Address offset: 0x2494
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT658H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 659 low
\ Address offset: 0x2498
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT659L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT659L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT659L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 659 high
\ Address offset: 0x249C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT659H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 660 low
\ Address offset: 0x24A0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT660L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT660L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT660L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 660 high
\ Address offset: 0x24A4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT660H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 661 low
\ Address offset: 0x24A8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT661L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT661L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT661L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 661 high
\ Address offset: 0x24AC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT661H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 662 low
\ Address offset: 0x24B0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT662L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT662L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT662L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 662 high
\ Address offset: 0x24B4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT662H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 663 low
\ Address offset: 0x24B8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT663L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT663L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT663L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 663 high
\ Address offset: 0x24BC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT663H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 664 low
\ Address offset: 0x24C0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT664L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT664L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT664L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 664 high
\ Address offset: 0x24C4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT664H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 665 low
\ Address offset: 0x24C8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT665L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT665L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT665L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 665 high
\ Address offset: 0x24CC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT665H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 666 low
\ Address offset: 0x24D0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT666L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT666L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT666L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 666 high
\ Address offset: 0x24D4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT666H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 667 low
\ Address offset: 0x24D8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT667L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT667L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT667L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 667 high
\ Address offset: 0x24DC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT667H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 668 low
\ Address offset: 0x24E0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT668L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT668L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT668L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 668 high
\ Address offset: 0x24E4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT668H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 669 low
\ Address offset: 0x24E8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT669L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT669L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT669L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 669 high
\ Address offset: 0x24EC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT669H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 670 low
\ Address offset: 0x24F0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT670L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT670L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT670L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 670 high
\ Address offset: 0x24F4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT670H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 671 low
\ Address offset: 0x24F8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT671L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT671L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT671L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 671 high
\ Address offset: 0x24FC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT671H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 672 low
\ Address offset: 0x2500
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT672L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT672L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT672L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 672 high
\ Address offset: 0x2504
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT672H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 673 low
\ Address offset: 0x2508
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT673L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT673L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT673L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 673 high
\ Address offset: 0x250C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT673H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 674 low
\ Address offset: 0x2510
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT674L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT674L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT674L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 674 high
\ Address offset: 0x2514
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT674H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 675 low
\ Address offset: 0x2518
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT675L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT675L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT675L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 675 high
\ Address offset: 0x251C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT675H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 676 low
\ Address offset: 0x2520
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT676L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT676L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT676L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 676 high
\ Address offset: 0x2524
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT676H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 677 low
\ Address offset: 0x2528
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT677L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT677L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT677L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 677 high
\ Address offset: 0x252C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT677H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 678 low
\ Address offset: 0x2530
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT678L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT678L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT678L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 678 high
\ Address offset: 0x2534
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT678H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 679 low
\ Address offset: 0x2538
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT679L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT679L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT679L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 679 high
\ Address offset: 0x253C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT679H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 680 low
\ Address offset: 0x2540
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT680L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT680L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT680L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 680 high
\ Address offset: 0x2544
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT680H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 681 low
\ Address offset: 0x2548
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT681L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT681L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT681L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 681 high
\ Address offset: 0x254C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT681H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 682 low
\ Address offset: 0x2550
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT682L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT682L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT682L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 682 high
\ Address offset: 0x2554
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT682H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 683 low
\ Address offset: 0x2558
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT683L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT683L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT683L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 683 high
\ Address offset: 0x255C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT683H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 684 low
\ Address offset: 0x2560
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT684L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT684L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT684L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 684 high
\ Address offset: 0x2564
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT684H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 685 low
\ Address offset: 0x2568
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT685L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT685L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT685L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 685 high
\ Address offset: 0x256C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT685H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 686 low
\ Address offset: 0x2570
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT686L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT686L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT686L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 686 high
\ Address offset: 0x2574
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT686H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 687 low
\ Address offset: 0x2578
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT687L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT687L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT687L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 687 high
\ Address offset: 0x257C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT687H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 688 low
\ Address offset: 0x2580
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT688L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT688L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT688L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 688 high
\ Address offset: 0x2584
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT688H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 689 low
\ Address offset: 0x2588
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT689L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT689L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT689L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 689 high
\ Address offset: 0x258C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT689H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 690 low
\ Address offset: 0x2590
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT690L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT690L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT690L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 690 high
\ Address offset: 0x2594
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT690H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 691 low
\ Address offset: 0x2598
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT691L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT691L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT691L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 691 high
\ Address offset: 0x259C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT691H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 692 low
\ Address offset: 0x25A0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT692L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT692L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT692L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 692 high
\ Address offset: 0x25A4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT692H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 693 low
\ Address offset: 0x25A8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT693L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT693L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT693L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 693 high
\ Address offset: 0x25AC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT693H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 694 low
\ Address offset: 0x25B0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT694L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT694L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT694L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 694 high
\ Address offset: 0x25B4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT694H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 695 low
\ Address offset: 0x25B8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT695L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT695L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT695L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 695 high
\ Address offset: 0x25BC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT695H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 696 low
\ Address offset: 0x25C0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT696L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT696L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT696L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 696 high
\ Address offset: 0x25C4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT696H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 697 low
\ Address offset: 0x25C8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT697L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT697L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT697L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 697 high
\ Address offset: 0x25CC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT697H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 698 low
\ Address offset: 0x25D0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT698L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT698L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT698L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 698 high
\ Address offset: 0x25D4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT698H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 699 low
\ Address offset: 0x25D8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT699L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT699L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT699L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 699 high
\ Address offset: 0x25DC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT699H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 700 low
\ Address offset: 0x25E0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT700L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT700L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT700L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 700 high
\ Address offset: 0x25E4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT700H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 701 low
\ Address offset: 0x25E8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT701L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT701L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT701L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 701 high
\ Address offset: 0x25EC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT701H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 702 low
\ Address offset: 0x25F0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT702L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT702L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT702L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 702 high
\ Address offset: 0x25F4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT702H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 703 low
\ Address offset: 0x25F8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT703L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT703L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT703L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 703 high
\ Address offset: 0x25FC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT703H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 704 low
\ Address offset: 0x2600
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT704L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT704L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT704L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 704 high
\ Address offset: 0x2604
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT704H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 705 low
\ Address offset: 0x2608
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT705L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT705L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT705L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 705 high
\ Address offset: 0x260C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT705H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 706 low
\ Address offset: 0x2610
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT706L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT706L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT706L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 706 high
\ Address offset: 0x2614
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT706H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 707 low
\ Address offset: 0x2618
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT707L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT707L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT707L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 707 high
\ Address offset: 0x261C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT707H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 708 low
\ Address offset: 0x2620
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT708L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT708L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT708L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 708 high
\ Address offset: 0x2624
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT708H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 709 low
\ Address offset: 0x2628
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT709L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT709L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT709L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 709 high
\ Address offset: 0x262C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT709H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 710 low
\ Address offset: 0x2630
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT710L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT710L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT710L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 710 high
\ Address offset: 0x2634
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT710H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 711 low
\ Address offset: 0x2638
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT711L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT711L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT711L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 711 high
\ Address offset: 0x263C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT711H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 712 low
\ Address offset: 0x2640
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT712L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT712L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT712L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 712 high
\ Address offset: 0x2644
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT712H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 713 low
\ Address offset: 0x2648
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT713L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT713L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT713L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 713 high
\ Address offset: 0x264C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT713H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 714 low
\ Address offset: 0x2650
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT714L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT714L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT714L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 714 high
\ Address offset: 0x2654
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT714H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 715 low
\ Address offset: 0x2658
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT715L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT715L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT715L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 715 high
\ Address offset: 0x265C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT715H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 716 low
\ Address offset: 0x2660
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT716L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT716L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT716L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 716 high
\ Address offset: 0x2664
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT716H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 717 low
\ Address offset: 0x2668
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT717L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT717L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT717L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 717 high
\ Address offset: 0x266C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT717H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 718 low
\ Address offset: 0x2670
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT718L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT718L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT718L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 718 high
\ Address offset: 0x2674
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT718H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 719 low
\ Address offset: 0x2678
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT719L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT719L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT719L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 719 high
\ Address offset: 0x267C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT719H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 720 low
\ Address offset: 0x2680
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT720L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT720L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT720L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 720 high
\ Address offset: 0x2684
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT720H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 721 low
\ Address offset: 0x2688
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT721L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT721L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT721L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 721 high
\ Address offset: 0x268C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT721H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 722 low
\ Address offset: 0x2690
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT722L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT722L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT722L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 722 high
\ Address offset: 0x2694
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT722H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 723 low
\ Address offset: 0x2698
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT723L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT723L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT723L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 723 high
\ Address offset: 0x269C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT723H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 724 low
\ Address offset: 0x26A0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT724L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT724L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT724L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 724 high
\ Address offset: 0x26A4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT724H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 725 low
\ Address offset: 0x26A8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT725L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT725L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT725L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 725 high
\ Address offset: 0x26AC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT725H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 726 low
\ Address offset: 0x26B0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT726L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT726L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT726L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 726 high
\ Address offset: 0x26B4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT726H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 727 low
\ Address offset: 0x26B8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT727L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT727L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT727L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 727 high
\ Address offset: 0x26BC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT727H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 728 low
\ Address offset: 0x26C0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT728L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT728L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT728L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 728 high
\ Address offset: 0x26C4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT728H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 729 low
\ Address offset: 0x26C8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT729L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT729L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT729L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 729 high
\ Address offset: 0x26CC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT729H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 730 low
\ Address offset: 0x26D0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT730L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT730L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT730L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 730 high
\ Address offset: 0x26D4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT730H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 731 low
\ Address offset: 0x26D8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT731L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT731L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT731L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 731 high
\ Address offset: 0x26DC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT731H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 732 low
\ Address offset: 0x26E0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT732L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT732L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT732L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 732 high
\ Address offset: 0x26E4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT732H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 733 low
\ Address offset: 0x26E8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT733L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT733L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT733L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 733 high
\ Address offset: 0x26EC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT733H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 734 low
\ Address offset: 0x26F0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT734L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT734L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT734L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 734 high
\ Address offset: 0x26F4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT734H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 735 low
\ Address offset: 0x26F8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT735L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT735L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT735L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 735 high
\ Address offset: 0x26FC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT735H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 736 low
\ Address offset: 0x2700
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT736L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT736L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT736L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 736 high
\ Address offset: 0x2704
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT736H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 737 low
\ Address offset: 0x2708
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT737L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT737L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT737L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 737 high
\ Address offset: 0x270C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT737H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 738 low
\ Address offset: 0x2710
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT738L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT738L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT738L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 738 high
\ Address offset: 0x2714
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT738H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 739 low
\ Address offset: 0x2718
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT739L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT739L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT739L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 739 high
\ Address offset: 0x271C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT739H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 740 low
\ Address offset: 0x2720
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT740L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT740L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT740L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 740 high
\ Address offset: 0x2724
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT740H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 741 low
\ Address offset: 0x2728
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT741L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT741L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT741L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 741 high
\ Address offset: 0x272C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT741H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 742 low
\ Address offset: 0x2730
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT742L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT742L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT742L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 742 high
\ Address offset: 0x2734
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT742H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 743 low
\ Address offset: 0x2738
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT743L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT743L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT743L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 743 high
\ Address offset: 0x273C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT743H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 744 low
\ Address offset: 0x2740
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT744L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT744L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT744L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 744 high
\ Address offset: 0x2744
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT744H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 745 low
\ Address offset: 0x2748
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT745L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT745L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT745L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 745 high
\ Address offset: 0x274C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT745H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 746 low
\ Address offset: 0x2750
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT746L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT746L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT746L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 746 high
\ Address offset: 0x2754
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT746H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 747 low
\ Address offset: 0x2758
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT747L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT747L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT747L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 747 high
\ Address offset: 0x275C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT747H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 748 low
\ Address offset: 0x2760
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT748L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT748L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT748L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 748 high
\ Address offset: 0x2764
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT748H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 749 low
\ Address offset: 0x2768
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT749L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT749L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT749L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 749 high
\ Address offset: 0x276C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT749H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 750 low
\ Address offset: 0x2770
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT750L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT750L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT750L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 750 high
\ Address offset: 0x2774
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT750H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 751 low
\ Address offset: 0x2778
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT751L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT751L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT751L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 751 high
\ Address offset: 0x277C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT751H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 752 low
\ Address offset: 0x2780
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT752L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT752L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT752L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 752 high
\ Address offset: 0x2784
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT752H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 753 low
\ Address offset: 0x2788
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT753L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT753L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT753L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 753 high
\ Address offset: 0x278C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT753H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 754 low
\ Address offset: 0x2790
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT754L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT754L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT754L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 754 high
\ Address offset: 0x2794
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT754H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 755 low
\ Address offset: 0x2798
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT755L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT755L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT755L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 755 high
\ Address offset: 0x279C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT755H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 756 low
\ Address offset: 0x27A0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT756L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT756L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT756L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 756 high
\ Address offset: 0x27A4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT756H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 757 low
\ Address offset: 0x27A8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT757L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT757L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT757L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 757 high
\ Address offset: 0x27AC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT757H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 758 low
\ Address offset: 0x27B0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT758L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT758L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT758L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 758 high
\ Address offset: 0x27B4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT758H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 759 low
\ Address offset: 0x27B8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT759L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT759L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT759L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 759 high
\ Address offset: 0x27BC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT759H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 760 low
\ Address offset: 0x27C0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT760L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT760L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT760L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 760 high
\ Address offset: 0x27C4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT760H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 761 low
\ Address offset: 0x27C8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT761L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT761L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT761L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 761 high
\ Address offset: 0x27CC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT761H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 762 low
\ Address offset: 0x27D0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT762L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT762L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT762L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 762 high
\ Address offset: 0x27D4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT762H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 763 low
\ Address offset: 0x27D8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT763L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT763L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT763L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 763 high
\ Address offset: 0x27DC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT763H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 764 low
\ Address offset: 0x27E0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT764L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT764L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT764L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 764 high
\ Address offset: 0x27E4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT764H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 765 low
\ Address offset: 0x27E8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT765L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT765L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT765L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 765 high
\ Address offset: 0x27EC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT765H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 766 low
\ Address offset: 0x27F0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT766L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT766L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT766L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 766 high
\ Address offset: 0x27F4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT766H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 767 low
\ Address offset: 0x27F8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT767L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT767L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT767L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 767 high
\ Address offset: 0x27FC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT767H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 768 low
\ Address offset: 0x2800
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT768L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT768L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT768L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 768 high
\ Address offset: 0x2804
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT768H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 769 low
\ Address offset: 0x2808
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT769L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT769L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT769L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 769 high
\ Address offset: 0x280C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT769H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 770 low
\ Address offset: 0x2810
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT770L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT770L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT770L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 770 high
\ Address offset: 0x2814
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT770H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 771 low
\ Address offset: 0x2818
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT771L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT771L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT771L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 771 high
\ Address offset: 0x281C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT771H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 772 low
\ Address offset: 0x2820
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT772L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT772L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT772L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 772 high
\ Address offset: 0x2824
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT772H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 773 low
\ Address offset: 0x2828
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT773L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT773L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT773L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 773 high
\ Address offset: 0x282C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT773H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 774 low
\ Address offset: 0x2830
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT774L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT774L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT774L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 774 high
\ Address offset: 0x2834
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT774H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 775 low
\ Address offset: 0x2838
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT775L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT775L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT775L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 775 high
\ Address offset: 0x283C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT775H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 776 low
\ Address offset: 0x2840
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT776L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT776L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT776L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 776 high
\ Address offset: 0x2844
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT776H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 777 low
\ Address offset: 0x2848
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT777L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT777L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT777L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 777 high
\ Address offset: 0x284C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT777H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 778 low
\ Address offset: 0x2850
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT778L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT778L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT778L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 778 high
\ Address offset: 0x2854
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT778H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 779 low
\ Address offset: 0x2858
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT779L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT779L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT779L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 779 high
\ Address offset: 0x285C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT779H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 780 low
\ Address offset: 0x2860
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT780L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT780L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT780L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 780 high
\ Address offset: 0x2864
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT780H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 781 low
\ Address offset: 0x2868
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT781L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT781L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT781L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 781 high
\ Address offset: 0x286C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT781H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 782 low
\ Address offset: 0x2870
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT782L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT782L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT782L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 782 high
\ Address offset: 0x2874
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT782H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 783 low
\ Address offset: 0x2878
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT783L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT783L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT783L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 783 high
\ Address offset: 0x287C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT783H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 784 low
\ Address offset: 0x2880
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT784L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT784L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT784L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 784 high
\ Address offset: 0x2884
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT784H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 785 low
\ Address offset: 0x2888
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT785L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT785L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT785L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 785 high
\ Address offset: 0x288C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT785H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 786 low
\ Address offset: 0x2890
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT786L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT786L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT786L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 786 high
\ Address offset: 0x2894
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT786H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 787 low
\ Address offset: 0x2898
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT787L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT787L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT787L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 787 high
\ Address offset: 0x289C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT787H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 788 low
\ Address offset: 0x28A0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT788L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT788L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT788L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 788 high
\ Address offset: 0x28A4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT788H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 789 low
\ Address offset: 0x28A8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT789L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT789L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT789L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 789 high
\ Address offset: 0x28AC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT789H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 790 low
\ Address offset: 0x28B0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT790L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT790L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT790L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 790 high
\ Address offset: 0x28B4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT790H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 791 low
\ Address offset: 0x28B8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT791L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT791L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT791L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 791 high
\ Address offset: 0x28BC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT791H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 792 low
\ Address offset: 0x28C0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT792L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT792L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT792L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 792 high
\ Address offset: 0x28C4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT792H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 793 low
\ Address offset: 0x28C8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT793L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT793L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT793L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 793 high
\ Address offset: 0x28CC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT793H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 794 low
\ Address offset: 0x28D0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT794L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT794L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT794L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 794 high
\ Address offset: 0x28D4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT794H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 795 low
\ Address offset: 0x28D8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT795L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT795L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT795L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 795 high
\ Address offset: 0x28DC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT795H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 796 low
\ Address offset: 0x28E0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT796L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT796L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT796L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 796 high
\ Address offset: 0x28E4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT796H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 797 low
\ Address offset: 0x28E8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT797L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT797L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT797L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 797 high
\ Address offset: 0x28EC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT797H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 798 low
\ Address offset: 0x28F0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT798L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT798L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT798L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 798 high
\ Address offset: 0x28F4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT798H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 799 low
\ Address offset: 0x28F8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT799L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT799L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT799L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 799 high
\ Address offset: 0x28FC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT799H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 800 low
\ Address offset: 0x2900
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT800L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT800L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT800L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 800 high
\ Address offset: 0x2904
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT800H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 801 low
\ Address offset: 0x2908
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT801L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT801L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT801L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 801 high
\ Address offset: 0x290C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT801H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 802 low
\ Address offset: 0x2910
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT802L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT802L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT802L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 802 high
\ Address offset: 0x2914
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT802H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 803 low
\ Address offset: 0x2918
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT803L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT803L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT803L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 803 high
\ Address offset: 0x291C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT803H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 804 low
\ Address offset: 0x2920
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT804L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT804L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT804L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 804 high
\ Address offset: 0x2924
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT804H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 805 low
\ Address offset: 0x2928
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT805L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT805L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT805L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 805 high
\ Address offset: 0x292C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT805H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 806 low
\ Address offset: 0x2930
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT806L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT806L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT806L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 806 high
\ Address offset: 0x2934
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT806H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 807 low
\ Address offset: 0x2938
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT807L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT807L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT807L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 807 high
\ Address offset: 0x293C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT807H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 808 low
\ Address offset: 0x2940
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT808L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT808L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT808L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 808 high
\ Address offset: 0x2944
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT808H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 809 low
\ Address offset: 0x2948
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT809L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT809L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT809L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 809 high
\ Address offset: 0x294C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT809H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 810 low
\ Address offset: 0x2950
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT810L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT810L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT810L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 810 high
\ Address offset: 0x2954
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT810H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 811 low
\ Address offset: 0x2958
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT811L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT811L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT811L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 811 high
\ Address offset: 0x295C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT811H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 812 low
\ Address offset: 0x2960
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT812L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT812L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT812L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 812 high
\ Address offset: 0x2964
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT812H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 813 low
\ Address offset: 0x2968
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT813L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT813L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT813L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 813 high
\ Address offset: 0x296C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT813H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 814 low
\ Address offset: 0x2970
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT814L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT814L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT814L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 814 high
\ Address offset: 0x2974
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT814H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 815 low
\ Address offset: 0x2978
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT815L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT815L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT815L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 815 high
\ Address offset: 0x297C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT815H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 816 low
\ Address offset: 0x2980
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT816L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT816L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT816L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 816 high
\ Address offset: 0x2984
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT816H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 817 low
\ Address offset: 0x2988
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT817L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT817L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT817L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 817 high
\ Address offset: 0x298C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT817H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 818 low
\ Address offset: 0x2990
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT818L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT818L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT818L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 818 high
\ Address offset: 0x2994
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT818H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 819 low
\ Address offset: 0x2998
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT819L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT819L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT819L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 819 high
\ Address offset: 0x299C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT819H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 820 low
\ Address offset: 0x29A0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT820L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT820L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT820L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 820 high
\ Address offset: 0x29A4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT820H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 821 low
\ Address offset: 0x29A8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT821L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT821L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT821L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 821 high
\ Address offset: 0x29AC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT821H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 822 low
\ Address offset: 0x29B0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT822L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT822L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT822L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 822 high
\ Address offset: 0x29B4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT822H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 823 low
\ Address offset: 0x29B8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT823L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT823L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT823L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 823 high
\ Address offset: 0x29BC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT823H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 824 low
\ Address offset: 0x29C0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT824L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT824L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT824L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 824 high
\ Address offset: 0x29C4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT824H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 825 low
\ Address offset: 0x29C8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT825L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT825L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT825L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 825 high
\ Address offset: 0x29CC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT825H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 826 low
\ Address offset: 0x29D0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT826L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT826L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT826L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 826 high
\ Address offset: 0x29D4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT826H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 827 low
\ Address offset: 0x29D8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT827L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT827L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT827L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 827 high
\ Address offset: 0x29DC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT827H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 828 low
\ Address offset: 0x29E0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT828L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT828L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT828L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 828 high
\ Address offset: 0x29E4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT828H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 829 low
\ Address offset: 0x29E8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT829L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT829L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT829L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 829 high
\ Address offset: 0x29EC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT829H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 830 low
\ Address offset: 0x29F0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT830L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT830L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT830L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 830 high
\ Address offset: 0x29F4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT830H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 831 low
\ Address offset: 0x29F8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT831L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT831L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT831L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 831 high
\ Address offset: 0x29FC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT831H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 832 low
\ Address offset: 0x2A00
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT832L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT832L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT832L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 832 high
\ Address offset: 0x2A04
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT832H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 833 low
\ Address offset: 0x2A08
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT833L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT833L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT833L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 833 high
\ Address offset: 0x2A0C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT833H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 834 low
\ Address offset: 0x2A10
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT834L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT834L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT834L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 834 high
\ Address offset: 0x2A14
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT834H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 835 low
\ Address offset: 0x2A18
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT835L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT835L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT835L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 835 high
\ Address offset: 0x2A1C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT835H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 836 low
\ Address offset: 0x2A20
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT836L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT836L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT836L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 836 high
\ Address offset: 0x2A24
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT836H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 837 low
\ Address offset: 0x2A28
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT837L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT837L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT837L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 837 high
\ Address offset: 0x2A2C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT837H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 838 low
\ Address offset: 0x2A30
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT838L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT838L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT838L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 838 high
\ Address offset: 0x2A34
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT838H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 839 low
\ Address offset: 0x2A38
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT839L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT839L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT839L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 839 high
\ Address offset: 0x2A3C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT839H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 840 low
\ Address offset: 0x2A40
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT840L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT840L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT840L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 840 high
\ Address offset: 0x2A44
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT840H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 841 low
\ Address offset: 0x2A48
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT841L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT841L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT841L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 841 high
\ Address offset: 0x2A4C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT841H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 842 low
\ Address offset: 0x2A50
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT842L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT842L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT842L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 842 high
\ Address offset: 0x2A54
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT842H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 843 low
\ Address offset: 0x2A58
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT843L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT843L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT843L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 843 high
\ Address offset: 0x2A5C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT843H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 844 low
\ Address offset: 0x2A60
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT844L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT844L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT844L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 844 high
\ Address offset: 0x2A64
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT844H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 845 low
\ Address offset: 0x2A68
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT845L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT845L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT845L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 845 high
\ Address offset: 0x2A6C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT845H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 846 low
\ Address offset: 0x2A70
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT846L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT846L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT846L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 846 high
\ Address offset: 0x2A74
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT846H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 847 low
\ Address offset: 0x2A78
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT847L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT847L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT847L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 847 high
\ Address offset: 0x2A7C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT847H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 848 low
\ Address offset: 0x2A80
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT848L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT848L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT848L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 848 high
\ Address offset: 0x2A84
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT848H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 849 low
\ Address offset: 0x2A88
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT849L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT849L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT849L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 849 high
\ Address offset: 0x2A8C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT849H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 850 low
\ Address offset: 0x2A90
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT850L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT850L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT850L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 850 high
\ Address offset: 0x2A94
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT850H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 851 low
\ Address offset: 0x2A98
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT851L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT851L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT851L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 851 high
\ Address offset: 0x2A9C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT851H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 852 low
\ Address offset: 0x2AA0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT852L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT852L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT852L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 852 high
\ Address offset: 0x2AA4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT852H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 853 low
\ Address offset: 0x2AA8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT853L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT853L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT853L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 853 high
\ Address offset: 0x2AAC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT853H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 854 low
\ Address offset: 0x2AB0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT854L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT854L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT854L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 854 high
\ Address offset: 0x2AB4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT854H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 855 low
\ Address offset: 0x2AB8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT855L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT855L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT855L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 855 high
\ Address offset: 0x2ABC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT855H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 856 low
\ Address offset: 0x2AC0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT856L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT856L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT856L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 856 high
\ Address offset: 0x2AC4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT856H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 857 low
\ Address offset: 0x2AC8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT857L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT857L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT857L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 857 high
\ Address offset: 0x2ACC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT857H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 858 low
\ Address offset: 0x2AD0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT858L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT858L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT858L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 858 high
\ Address offset: 0x2AD4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT858H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 859 low
\ Address offset: 0x2AD8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT859L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT859L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT859L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 859 high
\ Address offset: 0x2ADC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT859H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 860 low
\ Address offset: 0x2AE0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT860L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT860L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT860L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 860 high
\ Address offset: 0x2AE4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT860H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 861 low
\ Address offset: 0x2AE8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT861L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT861L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT861L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 861 high
\ Address offset: 0x2AEC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT861H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 862 low
\ Address offset: 0x2AF0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT862L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT862L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT862L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 862 high
\ Address offset: 0x2AF4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT862H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 863 low
\ Address offset: 0x2AF8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT863L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT863L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT863L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 863 high
\ Address offset: 0x2AFC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT863H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 864 low
\ Address offset: 0x2B00
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT864L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT864L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT864L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 864 high
\ Address offset: 0x2B04
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT864H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 865 low
\ Address offset: 0x2B08
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT865L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT865L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT865L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 865 high
\ Address offset: 0x2B0C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT865H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 866 low
\ Address offset: 0x2B10
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT866L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT866L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT866L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 866 high
\ Address offset: 0x2B14
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT866H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 867 low
\ Address offset: 0x2B18
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT867L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT867L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT867L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 867 high
\ Address offset: 0x2B1C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT867H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 868 low
\ Address offset: 0x2B20
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT868L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT868L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT868L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 868 high
\ Address offset: 0x2B24
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT868H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 869 low
\ Address offset: 0x2B28
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT869L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT869L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT869L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 869 high
\ Address offset: 0x2B2C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT869H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 870 low
\ Address offset: 0x2B30
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT870L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT870L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT870L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 870 high
\ Address offset: 0x2B34
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT870H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 871 low
\ Address offset: 0x2B38
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT871L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT871L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT871L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 871 high
\ Address offset: 0x2B3C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT871H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 872 low
\ Address offset: 0x2B40
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT872L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT872L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT872L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 872 high
\ Address offset: 0x2B44
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT872H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 873 low
\ Address offset: 0x2B48
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT873L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT873L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT873L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 873 high
\ Address offset: 0x2B4C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT873H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 874 low
\ Address offset: 0x2B50
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT874L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT874L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT874L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 874 high
\ Address offset: 0x2B54
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT874H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 875 low
\ Address offset: 0x2B58
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT875L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT875L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT875L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 875 high
\ Address offset: 0x2B5C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT875H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 876 low
\ Address offset: 0x2B60
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT876L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT876L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT876L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 876 high
\ Address offset: 0x2B64
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT876H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 877 low
\ Address offset: 0x2B68
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT877L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT877L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT877L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 877 high
\ Address offset: 0x2B6C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT877H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 878 low
\ Address offset: 0x2B70
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT878L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT878L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT878L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 878 high
\ Address offset: 0x2B74
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT878H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 879 low
\ Address offset: 0x2B78
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT879L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT879L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT879L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 879 high
\ Address offset: 0x2B7C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT879H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 880 low
\ Address offset: 0x2B80
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT880L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT880L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT880L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 880 high
\ Address offset: 0x2B84
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT880H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 881 low
\ Address offset: 0x2B88
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT881L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT881L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT881L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 881 high
\ Address offset: 0x2B8C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT881H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 882 low
\ Address offset: 0x2B90
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT882L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT882L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT882L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 882 high
\ Address offset: 0x2B94
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT882H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 883 low
\ Address offset: 0x2B98
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT883L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT883L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT883L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 883 high
\ Address offset: 0x2B9C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT883H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 884 low
\ Address offset: 0x2BA0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT884L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT884L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT884L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 884 high
\ Address offset: 0x2BA4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT884H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 885 low
\ Address offset: 0x2BA8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT885L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT885L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT885L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 885 high
\ Address offset: 0x2BAC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT885H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 886 low
\ Address offset: 0x2BB0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT886L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT886L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT886L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 886 high
\ Address offset: 0x2BB4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT886H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 887 low
\ Address offset: 0x2BB8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT887L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT887L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT887L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 887 high
\ Address offset: 0x2BBC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT887H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 888 low
\ Address offset: 0x2BC0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT888L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT888L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT888L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 888 high
\ Address offset: 0x2BC4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT888H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 889 low
\ Address offset: 0x2BC8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT889L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT889L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT889L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 889 high
\ Address offset: 0x2BCC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT889H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 890 low
\ Address offset: 0x2BD0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT890L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT890L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT890L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 890 high
\ Address offset: 0x2BD4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT890H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 891 low
\ Address offset: 0x2BD8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT891L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT891L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT891L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 891 high
\ Address offset: 0x2BDC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT891H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 892 low
\ Address offset: 0x2BE0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT892L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT892L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT892L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 892 high
\ Address offset: 0x2BE4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT892H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 893 low
\ Address offset: 0x2BE8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT893L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT893L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT893L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 893 high
\ Address offset: 0x2BEC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT893H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 894 low
\ Address offset: 0x2BF0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT894L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT894L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT894L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 894 high
\ Address offset: 0x2BF4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT894H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 895 low
\ Address offset: 0x2BF8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT895L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT895L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT895L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 895 high
\ Address offset: 0x2BFC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT895H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 896 low
\ Address offset: 0x2C00
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT896L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT896L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT896L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 896 high
\ Address offset: 0x2C04
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT896H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 897 low
\ Address offset: 0x2C08
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT897L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT897L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT897L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 897 high
\ Address offset: 0x2C0C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT897H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 898 low
\ Address offset: 0x2C10
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT898L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT898L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT898L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 898 high
\ Address offset: 0x2C14
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT898H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 899 low
\ Address offset: 0x2C18
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT899L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT899L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT899L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 899 high
\ Address offset: 0x2C1C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT899H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 900 low
\ Address offset: 0x2C20
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT900L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT900L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT900L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 900 high
\ Address offset: 0x2C24
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT900H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 901 low
\ Address offset: 0x2C28
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT901L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT901L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT901L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 901 high
\ Address offset: 0x2C2C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT901H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 902 low
\ Address offset: 0x2C30
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT902L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT902L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT902L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 902 high
\ Address offset: 0x2C34
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT902H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 903 low
\ Address offset: 0x2C38
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT903L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT903L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT903L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 903 high
\ Address offset: 0x2C3C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT903H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 904 low
\ Address offset: 0x2C40
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT904L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT904L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT904L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 904 high
\ Address offset: 0x2C44
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT904H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 905 low
\ Address offset: 0x2C48
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT905L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT905L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT905L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 905 high
\ Address offset: 0x2C4C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT905H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 906 low
\ Address offset: 0x2C50
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT906L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT906L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT906L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 906 high
\ Address offset: 0x2C54
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT906H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 907 low
\ Address offset: 0x2C58
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT907L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT907L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT907L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 907 high
\ Address offset: 0x2C5C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT907H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 908 low
\ Address offset: 0x2C60
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT908L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT908L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT908L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 908 high
\ Address offset: 0x2C64
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT908H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 909 low
\ Address offset: 0x2C68
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT909L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT909L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT909L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 909 high
\ Address offset: 0x2C6C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT909H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 910 low
\ Address offset: 0x2C70
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT910L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT910L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT910L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 910 high
\ Address offset: 0x2C74
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT910H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 911 low
\ Address offset: 0x2C78
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT911L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT911L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT911L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 911 high
\ Address offset: 0x2C7C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT911H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 912 low
\ Address offset: 0x2C80
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT912L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT912L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT912L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 912 high
\ Address offset: 0x2C84
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT912H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 913 low
\ Address offset: 0x2C88
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT913L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT913L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT913L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 913 high
\ Address offset: 0x2C8C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT913H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 914 low
\ Address offset: 0x2C90
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT914L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT914L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT914L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 914 high
\ Address offset: 0x2C94
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT914H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 915 low
\ Address offset: 0x2C98
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT915L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT915L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT915L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 915 high
\ Address offset: 0x2C9C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT915H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 916 low
\ Address offset: 0x2CA0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT916L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT916L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT916L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 916 high
\ Address offset: 0x2CA4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT916H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 917 low
\ Address offset: 0x2CA8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT917L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT917L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT917L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 917 high
\ Address offset: 0x2CAC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT917H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 918 low
\ Address offset: 0x2CB0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT918L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT918L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT918L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 918 high
\ Address offset: 0x2CB4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT918H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 919 low
\ Address offset: 0x2CB8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT919L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT919L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT919L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 919 high
\ Address offset: 0x2CBC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT919H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 920 low
\ Address offset: 0x2CC0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT920L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT920L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT920L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 920 high
\ Address offset: 0x2CC4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT920H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 921 low
\ Address offset: 0x2CC8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT921L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT921L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT921L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 921 high
\ Address offset: 0x2CCC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT921H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 922 low
\ Address offset: 0x2CD0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT922L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT922L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT922L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 922 high
\ Address offset: 0x2CD4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT922H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 923 low
\ Address offset: 0x2CD8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT923L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT923L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT923L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 923 high
\ Address offset: 0x2CDC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT923H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 924 low
\ Address offset: 0x2CE0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT924L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT924L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT924L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 924 high
\ Address offset: 0x2CE4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT924H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 925 low
\ Address offset: 0x2CE8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT925L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT925L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT925L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 925 high
\ Address offset: 0x2CEC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT925H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 926 low
\ Address offset: 0x2CF0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT926L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT926L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT926L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 926 high
\ Address offset: 0x2CF4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT926H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 927 low
\ Address offset: 0x2CF8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT927L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT927L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT927L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 927 high
\ Address offset: 0x2CFC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT927H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 928 low
\ Address offset: 0x2D00
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT928L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT928L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT928L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 928 high
\ Address offset: 0x2D04
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT928H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 929 low
\ Address offset: 0x2D08
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT929L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT929L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT929L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 929 high
\ Address offset: 0x2D0C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT929H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 930 low
\ Address offset: 0x2D10
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT930L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT930L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT930L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 930 high
\ Address offset: 0x2D14
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT930H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 931 low
\ Address offset: 0x2D18
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT931L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT931L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT931L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 931 high
\ Address offset: 0x2D1C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT931H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 932 low
\ Address offset: 0x2D20
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT932L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT932L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT932L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 932 high
\ Address offset: 0x2D24
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT932H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 933 low
\ Address offset: 0x2D28
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT933L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT933L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT933L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 933 high
\ Address offset: 0x2D2C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT933H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 934 low
\ Address offset: 0x2D30
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT934L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT934L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT934L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 934 high
\ Address offset: 0x2D34
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT934H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 935 low
\ Address offset: 0x2D38
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT935L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT935L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT935L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 935 high
\ Address offset: 0x2D3C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT935H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 936 low
\ Address offset: 0x2D40
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT936L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT936L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT936L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 936 high
\ Address offset: 0x2D44
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT936H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 937 low
\ Address offset: 0x2D48
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT937L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT937L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT937L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 937 high
\ Address offset: 0x2D4C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT937H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 938 low
\ Address offset: 0x2D50
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT938L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT938L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT938L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 938 high
\ Address offset: 0x2D54
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT938H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 939 low
\ Address offset: 0x2D58
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT939L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT939L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT939L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 939 high
\ Address offset: 0x2D5C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT939H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 940 low
\ Address offset: 0x2D60
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT940L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT940L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT940L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 940 high
\ Address offset: 0x2D64
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT940H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 941 low
\ Address offset: 0x2D68
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT941L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT941L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT941L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 941 high
\ Address offset: 0x2D6C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT941H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 942 low
\ Address offset: 0x2D70
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT942L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT942L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT942L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 942 high
\ Address offset: 0x2D74
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT942H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 943 low
\ Address offset: 0x2D78
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT943L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT943L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT943L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 943 high
\ Address offset: 0x2D7C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT943H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 944 low
\ Address offset: 0x2D80
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT944L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT944L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT944L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 944 high
\ Address offset: 0x2D84
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT944H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 945 low
\ Address offset: 0x2D88
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT945L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT945L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT945L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 945 high
\ Address offset: 0x2D8C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT945H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 946 low
\ Address offset: 0x2D90
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT946L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT946L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT946L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 946 high
\ Address offset: 0x2D94
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT946H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 947 low
\ Address offset: 0x2D98
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT947L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT947L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT947L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 947 high
\ Address offset: 0x2D9C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT947H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 948 low
\ Address offset: 0x2DA0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT948L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT948L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT948L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 948 high
\ Address offset: 0x2DA4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT948H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 949 low
\ Address offset: 0x2DA8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT949L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT949L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT949L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 949 high
\ Address offset: 0x2DAC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT949H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 950 low
\ Address offset: 0x2DB0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT950L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT950L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT950L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 950 high
\ Address offset: 0x2DB4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT950H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 951 low
\ Address offset: 0x2DB8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT951L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT951L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT951L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 951 high
\ Address offset: 0x2DBC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT951H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 952 low
\ Address offset: 0x2DC0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT952L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT952L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT952L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 952 high
\ Address offset: 0x2DC4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT952H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 953 low
\ Address offset: 0x2DC8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT953L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT953L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT953L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 953 high
\ Address offset: 0x2DCC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT953H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 954 low
\ Address offset: 0x2DD0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT954L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT954L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT954L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 954 high
\ Address offset: 0x2DD4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT954H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 955 low
\ Address offset: 0x2DD8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT955L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT955L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT955L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 955 high
\ Address offset: 0x2DDC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT955H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 956 low
\ Address offset: 0x2DE0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT956L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT956L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT956L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 956 high
\ Address offset: 0x2DE4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT956H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 957 low
\ Address offset: 0x2DE8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT957L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT957L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT957L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 957 high
\ Address offset: 0x2DEC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT957H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 958 low
\ Address offset: 0x2DF0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT958L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT958L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT958L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 958 high
\ Address offset: 0x2DF4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT958H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 959 low
\ Address offset: 0x2DF8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT959L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT959L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT959L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 959 high
\ Address offset: 0x2DFC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT959H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 960 low
\ Address offset: 0x2E00
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT960L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT960L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT960L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 960 high
\ Address offset: 0x2E04
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT960H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 961 low
\ Address offset: 0x2E08
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT961L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT961L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT961L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 961 high
\ Address offset: 0x2E0C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT961H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 962 low
\ Address offset: 0x2E10
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT962L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT962L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT962L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 962 high
\ Address offset: 0x2E14
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT962H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 963 low
\ Address offset: 0x2E18
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT963L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT963L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT963L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 963 high
\ Address offset: 0x2E1C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT963H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 964 low
\ Address offset: 0x2E20
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT964L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT964L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT964L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 964 high
\ Address offset: 0x2E24
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT964H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 965 low
\ Address offset: 0x2E28
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT965L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT965L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT965L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 965 high
\ Address offset: 0x2E2C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT965H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 966 low
\ Address offset: 0x2E30
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT966L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT966L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT966L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 966 high
\ Address offset: 0x2E34
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT966H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 967 low
\ Address offset: 0x2E38
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT967L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT967L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT967L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 967 high
\ Address offset: 0x2E3C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT967H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 968 low
\ Address offset: 0x2E40
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT968L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT968L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT968L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 968 high
\ Address offset: 0x2E44
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT968H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 969 low
\ Address offset: 0x2E48
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT969L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT969L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT969L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 969 high
\ Address offset: 0x2E4C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT969H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 970 low
\ Address offset: 0x2E50
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT970L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT970L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT970L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 970 high
\ Address offset: 0x2E54
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT970H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 971 low
\ Address offset: 0x2E58
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT971L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT971L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT971L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 971 high
\ Address offset: 0x2E5C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT971H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 972 low
\ Address offset: 0x2E60
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT972L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT972L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT972L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 972 high
\ Address offset: 0x2E64
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT972H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 973 low
\ Address offset: 0x2E68
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT973L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT973L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT973L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 973 high
\ Address offset: 0x2E6C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT973H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 974 low
\ Address offset: 0x2E70
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT974L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT974L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT974L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 974 high
\ Address offset: 0x2E74
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT974H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 975 low
\ Address offset: 0x2E78
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT975L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT975L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT975L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 975 high
\ Address offset: 0x2E7C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT975H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 976 low
\ Address offset: 0x2E80
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT976L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT976L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT976L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 976 high
\ Address offset: 0x2E84
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT976H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 977 low
\ Address offset: 0x2E88
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT977L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT977L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT977L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 977 high
\ Address offset: 0x2E8C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT977H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 978 low
\ Address offset: 0x2E90
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT978L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT978L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT978L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 978 high
\ Address offset: 0x2E94
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT978H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 979 low
\ Address offset: 0x2E98
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT979L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT979L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT979L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 979 high
\ Address offset: 0x2E9C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT979H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 980 low
\ Address offset: 0x2EA0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT980L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT980L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT980L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 980 high
\ Address offset: 0x2EA4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT980H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 981 low
\ Address offset: 0x2EA8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT981L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT981L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT981L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 981 high
\ Address offset: 0x2EAC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT981H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 982 low
\ Address offset: 0x2EB0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT982L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT982L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT982L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 982 high
\ Address offset: 0x2EB4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT982H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 983 low
\ Address offset: 0x2EB8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT983L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT983L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT983L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 983 high
\ Address offset: 0x2EBC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT983H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 984 low
\ Address offset: 0x2EC0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT984L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT984L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT984L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 984 high
\ Address offset: 0x2EC4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT984H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 985 low
\ Address offset: 0x2EC8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT985L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT985L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT985L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 985 high
\ Address offset: 0x2ECC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT985H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 986 low
\ Address offset: 0x2ED0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT986L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT986L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT986L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 986 high
\ Address offset: 0x2ED4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT986H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 987 low
\ Address offset: 0x2ED8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT987L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT987L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT987L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 987 high
\ Address offset: 0x2EDC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT987H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 988 low
\ Address offset: 0x2EE0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT988L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT988L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT988L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 988 high
\ Address offset: 0x2EE4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT988H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 989 low
\ Address offset: 0x2EE8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT989L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT989L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT989L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 989 high
\ Address offset: 0x2EEC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT989H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 990 low
\ Address offset: 0x2EF0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT990L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT990L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT990L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 990 high
\ Address offset: 0x2EF4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT990H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 991 low
\ Address offset: 0x2EF8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT991L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT991L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT991L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 991 high
\ Address offset: 0x2EFC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT991H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 992 low
\ Address offset: 0x2F00
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT992L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT992L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT992L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 992 high
\ Address offset: 0x2F04
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT992H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 993 low
\ Address offset: 0x2F08
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT993L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT993L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT993L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 993 high
\ Address offset: 0x2F0C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT993H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 994 low
\ Address offset: 0x2F10
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT994L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT994L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT994L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 994 high
\ Address offset: 0x2F14
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT994H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 995 low
\ Address offset: 0x2F18
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT995L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT995L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT995L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 995 high
\ Address offset: 0x2F1C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT995H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 996 low
\ Address offset: 0x2F20
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT996L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT996L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT996L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 996 high
\ Address offset: 0x2F24
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT996H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 997 low
\ Address offset: 0x2F28
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT997L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT997L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT997L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 997 high
\ Address offset: 0x2F2C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT997H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 998 low
\ Address offset: 0x2F30
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT998L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT998L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT998L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 998 high
\ Address offset: 0x2F34
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT998H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 999 low
\ Address offset: 0x2F38
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT999L_EN                       \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT999L_FVB                      \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT999L_LVB                      \ Last valid block


\
\ @brief GFXMMU LUT entry 999 high
\ Address offset: 0x2F3C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT999H_LO                       \ Line offset


\
\ @brief GFXMMU LUT entry 1000 low
\ Address offset: 0x2F40
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1000L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1000L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1000L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1000 high
\ Address offset: 0x2F44
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1000H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1001 low
\ Address offset: 0x2F48
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1001L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1001L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1001L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1001 high
\ Address offset: 0x2F4C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1001H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1002 low
\ Address offset: 0x2F50
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1002L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1002L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1002L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1002 high
\ Address offset: 0x2F54
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1002H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1003 low
\ Address offset: 0x2F58
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1003L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1003L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1003L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1003 high
\ Address offset: 0x2F5C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1003H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1004 low
\ Address offset: 0x2F60
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1004L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1004L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1004L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1004 high
\ Address offset: 0x2F64
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1004H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1005 low
\ Address offset: 0x2F68
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1005L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1005L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1005L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1005 high
\ Address offset: 0x2F6C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1005H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1006 low
\ Address offset: 0x2F70
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1006L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1006L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1006L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1006 high
\ Address offset: 0x2F74
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1006H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1007 low
\ Address offset: 0x2F78
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1007L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1007L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1007L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1007 high
\ Address offset: 0x2F7C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1007H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1008 low
\ Address offset: 0x2F80
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1008L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1008L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1008L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1008 high
\ Address offset: 0x2F84
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1008H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1009 low
\ Address offset: 0x2F88
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1009L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1009L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1009L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1009 high
\ Address offset: 0x2F8C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1009H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1010 low
\ Address offset: 0x2F90
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1010L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1010L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1010L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1010 high
\ Address offset: 0x2F94
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1010H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1011 low
\ Address offset: 0x2F98
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1011L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1011L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1011L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1011 high
\ Address offset: 0x2F9C
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1011H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1012 low
\ Address offset: 0x2FA0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1012L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1012L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1012L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1012 high
\ Address offset: 0x2FA4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1012H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1013 low
\ Address offset: 0x2FA8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1013L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1013L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1013L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1013 high
\ Address offset: 0x2FAC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1013H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1014 low
\ Address offset: 0x2FB0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1014L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1014L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1014L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1014 high
\ Address offset: 0x2FB4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1014H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1015 low
\ Address offset: 0x2FB8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1015L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1015L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1015L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1015 high
\ Address offset: 0x2FBC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1015H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1016 low
\ Address offset: 0x2FC0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1016L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1016L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1016L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1016 high
\ Address offset: 0x2FC4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1016H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1017 low
\ Address offset: 0x2FC8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1017L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1017L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1017L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1017 high
\ Address offset: 0x2FCC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1017H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1018 low
\ Address offset: 0x2FD0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1018L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1018L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1018L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1018 high
\ Address offset: 0x2FD4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1018H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1019 low
\ Address offset: 0x2FD8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1019L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1019L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1019L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1019 high
\ Address offset: 0x2FDC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1019H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1020 low
\ Address offset: 0x2FE0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1020L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1020L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1020L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1020 high
\ Address offset: 0x2FE4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1020H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1021 low
\ Address offset: 0x2FE8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1021L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1021L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1021L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1021 high
\ Address offset: 0x2FEC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1021H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1022 low
\ Address offset: 0x2FF0
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1022L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1022L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1022L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1022 high
\ Address offset: 0x2FF4
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1022H_LO                      \ Line offset


\
\ @brief GFXMMU LUT entry 1023 low
\ Address offset: 0x2FF8
\ Reset value: 0x00000000
\

$00000001 constant GFXMMU_S_GFXMMU_LUT1023L_EN                      \ Enable
$0000ff00 constant GFXMMU_S_GFXMMU_LUT1023L_FVB                     \ First valid block
$00ff0000 constant GFXMMU_S_GFXMMU_LUT1023L_LVB                     \ Last valid block


\
\ @brief GFXMMU LUT entry 1023 high
\ Address offset: 0x2FFC
\ Reset value: 0x00000000
\

$0003ffff constant GFXMMU_S_GFXMMU_LUT1023H_LO                      \ Line offset


\
\ @brief Chrom-GRC
\
$58030000 constant GFXMMU_S_GFXMMU_CR  \ offset: 0x00 : GFXMMU configuration register
$58030004 constant GFXMMU_S_GFXMMU_SR  \ offset: 0x04 : GFXMMU status register
$58030008 constant GFXMMU_S_GFXMMU_FCR  \ offset: 0x08 : GFXMMU flag clear register
$58030010 constant GFXMMU_S_GFXMMU_DVR  \ offset: 0x10 : GFXMMU default value register
$58030014 constant GFXMMU_S_GFXMMU_DAR  \ offset: 0x14 : GFXMMU default alpha register
$58030020 constant GFXMMU_S_GFXMMU_B0CR  \ offset: 0x20 : GFXMMU buffer 0 configuration register
$58030024 constant GFXMMU_S_GFXMMU_B1CR  \ offset: 0x24 : GFXMMU buffer 1 configuration register
$58030028 constant GFXMMU_S_GFXMMU_B2CR  \ offset: 0x28 : GFXMMU buffer 2 configuration register
$5803002c constant GFXMMU_S_GFXMMU_B3CR  \ offset: 0x2C : GFXMMU buffer 3 configuration register
$58031000 constant GFXMMU_S_GFXMMU_LUT0L  \ offset: 0x1000 : GFXMMU LUT entry 0 low
$58031004 constant GFXMMU_S_GFXMMU_LUT0H  \ offset: 0x1004 : GFXMMU LUT entry 0 high
$58031008 constant GFXMMU_S_GFXMMU_LUT1L  \ offset: 0x1008 : GFXMMU LUT entry 1 low
$5803100c constant GFXMMU_S_GFXMMU_LUT1H  \ offset: 0x100C : GFXMMU LUT entry 1 high
$58031010 constant GFXMMU_S_GFXMMU_LUT2L  \ offset: 0x1010 : GFXMMU LUT entry 2 low
$58031014 constant GFXMMU_S_GFXMMU_LUT2H  \ offset: 0x1014 : GFXMMU LUT entry 2 high
$58031018 constant GFXMMU_S_GFXMMU_LUT3L  \ offset: 0x1018 : GFXMMU LUT entry 3 low
$5803101c constant GFXMMU_S_GFXMMU_LUT3H  \ offset: 0x101C : GFXMMU LUT entry 3 high
$58031020 constant GFXMMU_S_GFXMMU_LUT4L  \ offset: 0x1020 : GFXMMU LUT entry 4 low
$58031024 constant GFXMMU_S_GFXMMU_LUT4H  \ offset: 0x1024 : GFXMMU LUT entry 4 high
$58031028 constant GFXMMU_S_GFXMMU_LUT5L  \ offset: 0x1028 : GFXMMU LUT entry 5 low
$5803102c constant GFXMMU_S_GFXMMU_LUT5H  \ offset: 0x102C : GFXMMU LUT entry 5 high
$58031030 constant GFXMMU_S_GFXMMU_LUT6L  \ offset: 0x1030 : GFXMMU LUT entry 6 low
$58031034 constant GFXMMU_S_GFXMMU_LUT6H  \ offset: 0x1034 : GFXMMU LUT entry 6 high
$58031038 constant GFXMMU_S_GFXMMU_LUT7L  \ offset: 0x1038 : GFXMMU LUT entry 7 low
$5803103c constant GFXMMU_S_GFXMMU_LUT7H  \ offset: 0x103C : GFXMMU LUT entry 7 high
$58031040 constant GFXMMU_S_GFXMMU_LUT8L  \ offset: 0x1040 : GFXMMU LUT entry 8 low
$58031044 constant GFXMMU_S_GFXMMU_LUT8H  \ offset: 0x1044 : GFXMMU LUT entry 8 high
$58031048 constant GFXMMU_S_GFXMMU_LUT9L  \ offset: 0x1048 : GFXMMU LUT entry 9 low
$5803104c constant GFXMMU_S_GFXMMU_LUT9H  \ offset: 0x104C : GFXMMU LUT entry 9 high
$58031050 constant GFXMMU_S_GFXMMU_LUT10L  \ offset: 0x1050 : GFXMMU LUT entry 10 low
$58031054 constant GFXMMU_S_GFXMMU_LUT10H  \ offset: 0x1054 : GFXMMU LUT entry 10 high
$58031058 constant GFXMMU_S_GFXMMU_LUT11L  \ offset: 0x1058 : GFXMMU LUT entry 11 low
$5803105c constant GFXMMU_S_GFXMMU_LUT11H  \ offset: 0x105C : GFXMMU LUT entry 11 high
$58031060 constant GFXMMU_S_GFXMMU_LUT12L  \ offset: 0x1060 : GFXMMU LUT entry 12 low
$58031064 constant GFXMMU_S_GFXMMU_LUT12H  \ offset: 0x1064 : GFXMMU LUT entry 12 high
$58031068 constant GFXMMU_S_GFXMMU_LUT13L  \ offset: 0x1068 : GFXMMU LUT entry 13 low
$5803106c constant GFXMMU_S_GFXMMU_LUT13H  \ offset: 0x106C : GFXMMU LUT entry 13 high
$58031070 constant GFXMMU_S_GFXMMU_LUT14L  \ offset: 0x1070 : GFXMMU LUT entry 14 low
$58031074 constant GFXMMU_S_GFXMMU_LUT14H  \ offset: 0x1074 : GFXMMU LUT entry 14 high
$58031078 constant GFXMMU_S_GFXMMU_LUT15L  \ offset: 0x1078 : GFXMMU LUT entry 15 low
$5803107c constant GFXMMU_S_GFXMMU_LUT15H  \ offset: 0x107C : GFXMMU LUT entry 15 high
$58031080 constant GFXMMU_S_GFXMMU_LUT16L  \ offset: 0x1080 : GFXMMU LUT entry 16 low
$58031084 constant GFXMMU_S_GFXMMU_LUT16H  \ offset: 0x1084 : GFXMMU LUT entry 16 high
$58031088 constant GFXMMU_S_GFXMMU_LUT17L  \ offset: 0x1088 : GFXMMU LUT entry 17 low
$5803108c constant GFXMMU_S_GFXMMU_LUT17H  \ offset: 0x108C : GFXMMU LUT entry 17 high
$58031090 constant GFXMMU_S_GFXMMU_LUT18L  \ offset: 0x1090 : GFXMMU LUT entry 18 low
$58031094 constant GFXMMU_S_GFXMMU_LUT18H  \ offset: 0x1094 : GFXMMU LUT entry 18 high
$58031098 constant GFXMMU_S_GFXMMU_LUT19L  \ offset: 0x1098 : GFXMMU LUT entry 19 low
$5803109c constant GFXMMU_S_GFXMMU_LUT19H  \ offset: 0x109C : GFXMMU LUT entry 19 high
$580310a0 constant GFXMMU_S_GFXMMU_LUT20L  \ offset: 0x10A0 : GFXMMU LUT entry 20 low
$580310a4 constant GFXMMU_S_GFXMMU_LUT20H  \ offset: 0x10A4 : GFXMMU LUT entry 20 high
$580310a8 constant GFXMMU_S_GFXMMU_LUT21L  \ offset: 0x10A8 : GFXMMU LUT entry 21 low
$580310ac constant GFXMMU_S_GFXMMU_LUT21H  \ offset: 0x10AC : GFXMMU LUT entry 21 high
$580310b0 constant GFXMMU_S_GFXMMU_LUT22L  \ offset: 0x10B0 : GFXMMU LUT entry 22 low
$580310b4 constant GFXMMU_S_GFXMMU_LUT22H  \ offset: 0x10B4 : GFXMMU LUT entry 22 high
$580310b8 constant GFXMMU_S_GFXMMU_LUT23L  \ offset: 0x10B8 : GFXMMU LUT entry 23 low
$580310bc constant GFXMMU_S_GFXMMU_LUT23H  \ offset: 0x10BC : GFXMMU LUT entry 23 high
$580310c0 constant GFXMMU_S_GFXMMU_LUT24L  \ offset: 0x10C0 : GFXMMU LUT entry 24 low
$580310c4 constant GFXMMU_S_GFXMMU_LUT24H  \ offset: 0x10C4 : GFXMMU LUT entry 24 high
$580310c8 constant GFXMMU_S_GFXMMU_LUT25L  \ offset: 0x10C8 : GFXMMU LUT entry 25 low
$580310cc constant GFXMMU_S_GFXMMU_LUT25H  \ offset: 0x10CC : GFXMMU LUT entry 25 high
$580310d0 constant GFXMMU_S_GFXMMU_LUT26L  \ offset: 0x10D0 : GFXMMU LUT entry 26 low
$580310d4 constant GFXMMU_S_GFXMMU_LUT26H  \ offset: 0x10D4 : GFXMMU LUT entry 26 high
$580310d8 constant GFXMMU_S_GFXMMU_LUT27L  \ offset: 0x10D8 : GFXMMU LUT entry 27 low
$580310dc constant GFXMMU_S_GFXMMU_LUT27H  \ offset: 0x10DC : GFXMMU LUT entry 27 high
$580310e0 constant GFXMMU_S_GFXMMU_LUT28L  \ offset: 0x10E0 : GFXMMU LUT entry 28 low
$580310e4 constant GFXMMU_S_GFXMMU_LUT28H  \ offset: 0x10E4 : GFXMMU LUT entry 28 high
$580310e8 constant GFXMMU_S_GFXMMU_LUT29L  \ offset: 0x10E8 : GFXMMU LUT entry 29 low
$580310ec constant GFXMMU_S_GFXMMU_LUT29H  \ offset: 0x10EC : GFXMMU LUT entry 29 high
$580310f0 constant GFXMMU_S_GFXMMU_LUT30L  \ offset: 0x10F0 : GFXMMU LUT entry 30 low
$580310f4 constant GFXMMU_S_GFXMMU_LUT30H  \ offset: 0x10F4 : GFXMMU LUT entry 30 high
$580310f8 constant GFXMMU_S_GFXMMU_LUT31L  \ offset: 0x10F8 : GFXMMU LUT entry 31 low
$580310fc constant GFXMMU_S_GFXMMU_LUT31H  \ offset: 0x10FC : GFXMMU LUT entry 31 high
$58031100 constant GFXMMU_S_GFXMMU_LUT32L  \ offset: 0x1100 : GFXMMU LUT entry 32 low
$58031104 constant GFXMMU_S_GFXMMU_LUT32H  \ offset: 0x1104 : GFXMMU LUT entry 32 high
$58031108 constant GFXMMU_S_GFXMMU_LUT33L  \ offset: 0x1108 : GFXMMU LUT entry 33 low
$5803110c constant GFXMMU_S_GFXMMU_LUT33H  \ offset: 0x110C : GFXMMU LUT entry 33 high
$58031110 constant GFXMMU_S_GFXMMU_LUT34L  \ offset: 0x1110 : GFXMMU LUT entry 34 low
$58031114 constant GFXMMU_S_GFXMMU_LUT34H  \ offset: 0x1114 : GFXMMU LUT entry 34 high
$58031118 constant GFXMMU_S_GFXMMU_LUT35L  \ offset: 0x1118 : GFXMMU LUT entry 35 low
$5803111c constant GFXMMU_S_GFXMMU_LUT35H  \ offset: 0x111C : GFXMMU LUT entry 35 high
$58031120 constant GFXMMU_S_GFXMMU_LUT36L  \ offset: 0x1120 : GFXMMU LUT entry 36 low
$58031124 constant GFXMMU_S_GFXMMU_LUT36H  \ offset: 0x1124 : GFXMMU LUT entry 36 high
$58031128 constant GFXMMU_S_GFXMMU_LUT37L  \ offset: 0x1128 : GFXMMU LUT entry 37 low
$5803112c constant GFXMMU_S_GFXMMU_LUT37H  \ offset: 0x112C : GFXMMU LUT entry 37 high
$58031130 constant GFXMMU_S_GFXMMU_LUT38L  \ offset: 0x1130 : GFXMMU LUT entry 38 low
$58031134 constant GFXMMU_S_GFXMMU_LUT38H  \ offset: 0x1134 : GFXMMU LUT entry 38 high
$58031138 constant GFXMMU_S_GFXMMU_LUT39L  \ offset: 0x1138 : GFXMMU LUT entry 39 low
$5803113c constant GFXMMU_S_GFXMMU_LUT39H  \ offset: 0x113C : GFXMMU LUT entry 39 high
$58031140 constant GFXMMU_S_GFXMMU_LUT40L  \ offset: 0x1140 : GFXMMU LUT entry 40 low
$58031144 constant GFXMMU_S_GFXMMU_LUT40H  \ offset: 0x1144 : GFXMMU LUT entry 40 high
$58031148 constant GFXMMU_S_GFXMMU_LUT41L  \ offset: 0x1148 : GFXMMU LUT entry 41 low
$5803114c constant GFXMMU_S_GFXMMU_LUT41H  \ offset: 0x114C : GFXMMU LUT entry 41 high
$58031150 constant GFXMMU_S_GFXMMU_LUT42L  \ offset: 0x1150 : GFXMMU LUT entry 42 low
$58031154 constant GFXMMU_S_GFXMMU_LUT42H  \ offset: 0x1154 : GFXMMU LUT entry 42 high
$58031158 constant GFXMMU_S_GFXMMU_LUT43L  \ offset: 0x1158 : GFXMMU LUT entry 43 low
$5803115c constant GFXMMU_S_GFXMMU_LUT43H  \ offset: 0x115C : GFXMMU LUT entry 43 high
$58031160 constant GFXMMU_S_GFXMMU_LUT44L  \ offset: 0x1160 : GFXMMU LUT entry 44 low
$58031164 constant GFXMMU_S_GFXMMU_LUT44H  \ offset: 0x1164 : GFXMMU LUT entry 44 high
$58031168 constant GFXMMU_S_GFXMMU_LUT45L  \ offset: 0x1168 : GFXMMU LUT entry 45 low
$5803116c constant GFXMMU_S_GFXMMU_LUT45H  \ offset: 0x116C : GFXMMU LUT entry 45 high
$58031170 constant GFXMMU_S_GFXMMU_LUT46L  \ offset: 0x1170 : GFXMMU LUT entry 46 low
$58031174 constant GFXMMU_S_GFXMMU_LUT46H  \ offset: 0x1174 : GFXMMU LUT entry 46 high
$58031178 constant GFXMMU_S_GFXMMU_LUT47L  \ offset: 0x1178 : GFXMMU LUT entry 47 low
$5803117c constant GFXMMU_S_GFXMMU_LUT47H  \ offset: 0x117C : GFXMMU LUT entry 47 high
$58031180 constant GFXMMU_S_GFXMMU_LUT48L  \ offset: 0x1180 : GFXMMU LUT entry 48 low
$58031184 constant GFXMMU_S_GFXMMU_LUT48H  \ offset: 0x1184 : GFXMMU LUT entry 48 high
$58031188 constant GFXMMU_S_GFXMMU_LUT49L  \ offset: 0x1188 : GFXMMU LUT entry 49 low
$5803118c constant GFXMMU_S_GFXMMU_LUT49H  \ offset: 0x118C : GFXMMU LUT entry 49 high
$58031190 constant GFXMMU_S_GFXMMU_LUT50L  \ offset: 0x1190 : GFXMMU LUT entry 50 low
$58031194 constant GFXMMU_S_GFXMMU_LUT50H  \ offset: 0x1194 : GFXMMU LUT entry 50 high
$58031198 constant GFXMMU_S_GFXMMU_LUT51L  \ offset: 0x1198 : GFXMMU LUT entry 51 low
$5803119c constant GFXMMU_S_GFXMMU_LUT51H  \ offset: 0x119C : GFXMMU LUT entry 51 high
$580311a0 constant GFXMMU_S_GFXMMU_LUT52L  \ offset: 0x11A0 : GFXMMU LUT entry 52 low
$580311a4 constant GFXMMU_S_GFXMMU_LUT52H  \ offset: 0x11A4 : GFXMMU LUT entry 52 high
$580311a8 constant GFXMMU_S_GFXMMU_LUT53L  \ offset: 0x11A8 : GFXMMU LUT entry 53 low
$580311ac constant GFXMMU_S_GFXMMU_LUT53H  \ offset: 0x11AC : GFXMMU LUT entry 53 high
$580311b0 constant GFXMMU_S_GFXMMU_LUT54L  \ offset: 0x11B0 : GFXMMU LUT entry 54 low
$580311b4 constant GFXMMU_S_GFXMMU_LUT54H  \ offset: 0x11B4 : GFXMMU LUT entry 54 high
$580311b8 constant GFXMMU_S_GFXMMU_LUT55L  \ offset: 0x11B8 : GFXMMU LUT entry 55 low
$580311bc constant GFXMMU_S_GFXMMU_LUT55H  \ offset: 0x11BC : GFXMMU LUT entry 55 high
$580311c0 constant GFXMMU_S_GFXMMU_LUT56L  \ offset: 0x11C0 : GFXMMU LUT entry 56 low
$580311c4 constant GFXMMU_S_GFXMMU_LUT56H  \ offset: 0x11C4 : GFXMMU LUT entry 56 high
$580311c8 constant GFXMMU_S_GFXMMU_LUT57L  \ offset: 0x11C8 : GFXMMU LUT entry 57 low
$580311cc constant GFXMMU_S_GFXMMU_LUT57H  \ offset: 0x11CC : GFXMMU LUT entry 57 high
$580311d0 constant GFXMMU_S_GFXMMU_LUT58L  \ offset: 0x11D0 : GFXMMU LUT entry 58 low
$580311d4 constant GFXMMU_S_GFXMMU_LUT58H  \ offset: 0x11D4 : GFXMMU LUT entry 58 high
$580311d8 constant GFXMMU_S_GFXMMU_LUT59L  \ offset: 0x11D8 : GFXMMU LUT entry 59 low
$580311dc constant GFXMMU_S_GFXMMU_LUT59H  \ offset: 0x11DC : GFXMMU LUT entry 59 high
$580311e0 constant GFXMMU_S_GFXMMU_LUT60L  \ offset: 0x11E0 : GFXMMU LUT entry 60 low
$580311e4 constant GFXMMU_S_GFXMMU_LUT60H  \ offset: 0x11E4 : GFXMMU LUT entry 60 high
$580311e8 constant GFXMMU_S_GFXMMU_LUT61L  \ offset: 0x11E8 : GFXMMU LUT entry 61 low
$580311ec constant GFXMMU_S_GFXMMU_LUT61H  \ offset: 0x11EC : GFXMMU LUT entry 61 high
$580311f0 constant GFXMMU_S_GFXMMU_LUT62L  \ offset: 0x11F0 : GFXMMU LUT entry 62 low
$580311f4 constant GFXMMU_S_GFXMMU_LUT62H  \ offset: 0x11F4 : GFXMMU LUT entry 62 high
$580311f8 constant GFXMMU_S_GFXMMU_LUT63L  \ offset: 0x11F8 : GFXMMU LUT entry 63 low
$580311fc constant GFXMMU_S_GFXMMU_LUT63H  \ offset: 0x11FC : GFXMMU LUT entry 63 high
$58031200 constant GFXMMU_S_GFXMMU_LUT64L  \ offset: 0x1200 : GFXMMU LUT entry 64 low
$58031204 constant GFXMMU_S_GFXMMU_LUT64H  \ offset: 0x1204 : GFXMMU LUT entry 64 high
$58031208 constant GFXMMU_S_GFXMMU_LUT65L  \ offset: 0x1208 : GFXMMU LUT entry 65 low
$5803120c constant GFXMMU_S_GFXMMU_LUT65H  \ offset: 0x120C : GFXMMU LUT entry 65 high
$58031210 constant GFXMMU_S_GFXMMU_LUT66L  \ offset: 0x1210 : GFXMMU LUT entry 66 low
$58031214 constant GFXMMU_S_GFXMMU_LUT66H  \ offset: 0x1214 : GFXMMU LUT entry 66 high
$58031218 constant GFXMMU_S_GFXMMU_LUT67L  \ offset: 0x1218 : GFXMMU LUT entry 67 low
$5803121c constant GFXMMU_S_GFXMMU_LUT67H  \ offset: 0x121C : GFXMMU LUT entry 67 high
$58031220 constant GFXMMU_S_GFXMMU_LUT68L  \ offset: 0x1220 : GFXMMU LUT entry 68 low
$58031224 constant GFXMMU_S_GFXMMU_LUT68H  \ offset: 0x1224 : GFXMMU LUT entry 68 high
$58031228 constant GFXMMU_S_GFXMMU_LUT69L  \ offset: 0x1228 : GFXMMU LUT entry 69 low
$5803122c constant GFXMMU_S_GFXMMU_LUT69H  \ offset: 0x122C : GFXMMU LUT entry 69 high
$58031230 constant GFXMMU_S_GFXMMU_LUT70L  \ offset: 0x1230 : GFXMMU LUT entry 70 low
$58031234 constant GFXMMU_S_GFXMMU_LUT70H  \ offset: 0x1234 : GFXMMU LUT entry 70 high
$58031238 constant GFXMMU_S_GFXMMU_LUT71L  \ offset: 0x1238 : GFXMMU LUT entry 71 low
$5803123c constant GFXMMU_S_GFXMMU_LUT71H  \ offset: 0x123C : GFXMMU LUT entry 71 high
$58031240 constant GFXMMU_S_GFXMMU_LUT72L  \ offset: 0x1240 : GFXMMU LUT entry 72 low
$58031244 constant GFXMMU_S_GFXMMU_LUT72H  \ offset: 0x1244 : GFXMMU LUT entry 72 high
$58031248 constant GFXMMU_S_GFXMMU_LUT73L  \ offset: 0x1248 : GFXMMU LUT entry 73 low
$5803124c constant GFXMMU_S_GFXMMU_LUT73H  \ offset: 0x124C : GFXMMU LUT entry 73 high
$58031250 constant GFXMMU_S_GFXMMU_LUT74L  \ offset: 0x1250 : GFXMMU LUT entry 74 low
$58031254 constant GFXMMU_S_GFXMMU_LUT74H  \ offset: 0x1254 : GFXMMU LUT entry 74 high
$58031258 constant GFXMMU_S_GFXMMU_LUT75L  \ offset: 0x1258 : GFXMMU LUT entry 75 low
$5803125c constant GFXMMU_S_GFXMMU_LUT75H  \ offset: 0x125C : GFXMMU LUT entry 75 high
$58031260 constant GFXMMU_S_GFXMMU_LUT76L  \ offset: 0x1260 : GFXMMU LUT entry 76 low
$58031264 constant GFXMMU_S_GFXMMU_LUT76H  \ offset: 0x1264 : GFXMMU LUT entry 76 high
$58031268 constant GFXMMU_S_GFXMMU_LUT77L  \ offset: 0x1268 : GFXMMU LUT entry 77 low
$5803126c constant GFXMMU_S_GFXMMU_LUT77H  \ offset: 0x126C : GFXMMU LUT entry 77 high
$58031270 constant GFXMMU_S_GFXMMU_LUT78L  \ offset: 0x1270 : GFXMMU LUT entry 78 low
$58031274 constant GFXMMU_S_GFXMMU_LUT78H  \ offset: 0x1274 : GFXMMU LUT entry 78 high
$58031278 constant GFXMMU_S_GFXMMU_LUT79L  \ offset: 0x1278 : GFXMMU LUT entry 79 low
$5803127c constant GFXMMU_S_GFXMMU_LUT79H  \ offset: 0x127C : GFXMMU LUT entry 79 high
$58031280 constant GFXMMU_S_GFXMMU_LUT80L  \ offset: 0x1280 : GFXMMU LUT entry 80 low
$58031284 constant GFXMMU_S_GFXMMU_LUT80H  \ offset: 0x1284 : GFXMMU LUT entry 80 high
$58031288 constant GFXMMU_S_GFXMMU_LUT81L  \ offset: 0x1288 : GFXMMU LUT entry 81 low
$5803128c constant GFXMMU_S_GFXMMU_LUT81H  \ offset: 0x128C : GFXMMU LUT entry 81 high
$58031290 constant GFXMMU_S_GFXMMU_LUT82L  \ offset: 0x1290 : GFXMMU LUT entry 82 low
$58031294 constant GFXMMU_S_GFXMMU_LUT82H  \ offset: 0x1294 : GFXMMU LUT entry 82 high
$58031298 constant GFXMMU_S_GFXMMU_LUT83L  \ offset: 0x1298 : GFXMMU LUT entry 83 low
$5803129c constant GFXMMU_S_GFXMMU_LUT83H  \ offset: 0x129C : GFXMMU LUT entry 83 high
$580312a0 constant GFXMMU_S_GFXMMU_LUT84L  \ offset: 0x12A0 : GFXMMU LUT entry 84 low
$580312a4 constant GFXMMU_S_GFXMMU_LUT84H  \ offset: 0x12A4 : GFXMMU LUT entry 84 high
$580312a8 constant GFXMMU_S_GFXMMU_LUT85L  \ offset: 0x12A8 : GFXMMU LUT entry 85 low
$580312ac constant GFXMMU_S_GFXMMU_LUT85H  \ offset: 0x12AC : GFXMMU LUT entry 85 high
$580312b0 constant GFXMMU_S_GFXMMU_LUT86L  \ offset: 0x12B0 : GFXMMU LUT entry 86 low
$580312b4 constant GFXMMU_S_GFXMMU_LUT86H  \ offset: 0x12B4 : GFXMMU LUT entry 86 high
$580312b8 constant GFXMMU_S_GFXMMU_LUT87L  \ offset: 0x12B8 : GFXMMU LUT entry 87 low
$580312bc constant GFXMMU_S_GFXMMU_LUT87H  \ offset: 0x12BC : GFXMMU LUT entry 87 high
$580312c0 constant GFXMMU_S_GFXMMU_LUT88L  \ offset: 0x12C0 : GFXMMU LUT entry 88 low
$580312c4 constant GFXMMU_S_GFXMMU_LUT88H  \ offset: 0x12C4 : GFXMMU LUT entry 88 high
$580312c8 constant GFXMMU_S_GFXMMU_LUT89L  \ offset: 0x12C8 : GFXMMU LUT entry 89 low
$580312cc constant GFXMMU_S_GFXMMU_LUT89H  \ offset: 0x12CC : GFXMMU LUT entry 89 high
$580312d0 constant GFXMMU_S_GFXMMU_LUT90L  \ offset: 0x12D0 : GFXMMU LUT entry 90 low
$580312d4 constant GFXMMU_S_GFXMMU_LUT90H  \ offset: 0x12D4 : GFXMMU LUT entry 90 high
$580312d8 constant GFXMMU_S_GFXMMU_LUT91L  \ offset: 0x12D8 : GFXMMU LUT entry 91 low
$580312dc constant GFXMMU_S_GFXMMU_LUT91H  \ offset: 0x12DC : GFXMMU LUT entry 91 high
$580312e0 constant GFXMMU_S_GFXMMU_LUT92L  \ offset: 0x12E0 : GFXMMU LUT entry 92 low
$580312e4 constant GFXMMU_S_GFXMMU_LUT92H  \ offset: 0x12E4 : GFXMMU LUT entry 92 high
$580312e8 constant GFXMMU_S_GFXMMU_LUT93L  \ offset: 0x12E8 : GFXMMU LUT entry 93 low
$580312ec constant GFXMMU_S_GFXMMU_LUT93H  \ offset: 0x12EC : GFXMMU LUT entry 93 high
$580312f0 constant GFXMMU_S_GFXMMU_LUT94L  \ offset: 0x12F0 : GFXMMU LUT entry 94 low
$580312f4 constant GFXMMU_S_GFXMMU_LUT94H  \ offset: 0x12F4 : GFXMMU LUT entry 94 high
$580312f8 constant GFXMMU_S_GFXMMU_LUT95L  \ offset: 0x12F8 : GFXMMU LUT entry 95 low
$580312fc constant GFXMMU_S_GFXMMU_LUT95H  \ offset: 0x12FC : GFXMMU LUT entry 95 high
$58031300 constant GFXMMU_S_GFXMMU_LUT96L  \ offset: 0x1300 : GFXMMU LUT entry 96 low
$58031304 constant GFXMMU_S_GFXMMU_LUT96H  \ offset: 0x1304 : GFXMMU LUT entry 96 high
$58031308 constant GFXMMU_S_GFXMMU_LUT97L  \ offset: 0x1308 : GFXMMU LUT entry 97 low
$5803130c constant GFXMMU_S_GFXMMU_LUT97H  \ offset: 0x130C : GFXMMU LUT entry 97 high
$58031310 constant GFXMMU_S_GFXMMU_LUT98L  \ offset: 0x1310 : GFXMMU LUT entry 98 low
$58031314 constant GFXMMU_S_GFXMMU_LUT98H  \ offset: 0x1314 : GFXMMU LUT entry 98 high
$58031318 constant GFXMMU_S_GFXMMU_LUT99L  \ offset: 0x1318 : GFXMMU LUT entry 99 low
$5803131c constant GFXMMU_S_GFXMMU_LUT99H  \ offset: 0x131C : GFXMMU LUT entry 99 high
$58031320 constant GFXMMU_S_GFXMMU_LUT100L  \ offset: 0x1320 : GFXMMU LUT entry 100 low
$58031324 constant GFXMMU_S_GFXMMU_LUT100H  \ offset: 0x1324 : GFXMMU LUT entry 100 high
$58031328 constant GFXMMU_S_GFXMMU_LUT101L  \ offset: 0x1328 : GFXMMU LUT entry 101 low
$5803132c constant GFXMMU_S_GFXMMU_LUT101H  \ offset: 0x132C : GFXMMU LUT entry 101 high
$58031330 constant GFXMMU_S_GFXMMU_LUT102L  \ offset: 0x1330 : GFXMMU LUT entry 102 low
$58031334 constant GFXMMU_S_GFXMMU_LUT102H  \ offset: 0x1334 : GFXMMU LUT entry 102 high
$58031338 constant GFXMMU_S_GFXMMU_LUT103L  \ offset: 0x1338 : GFXMMU LUT entry 103 low
$5803133c constant GFXMMU_S_GFXMMU_LUT103H  \ offset: 0x133C : GFXMMU LUT entry 103 high
$58031340 constant GFXMMU_S_GFXMMU_LUT104L  \ offset: 0x1340 : GFXMMU LUT entry 104 low
$58031344 constant GFXMMU_S_GFXMMU_LUT104H  \ offset: 0x1344 : GFXMMU LUT entry 104 high
$58031348 constant GFXMMU_S_GFXMMU_LUT105L  \ offset: 0x1348 : GFXMMU LUT entry 105 low
$5803134c constant GFXMMU_S_GFXMMU_LUT105H  \ offset: 0x134C : GFXMMU LUT entry 105 high
$58031350 constant GFXMMU_S_GFXMMU_LUT106L  \ offset: 0x1350 : GFXMMU LUT entry 106 low
$58031354 constant GFXMMU_S_GFXMMU_LUT106H  \ offset: 0x1354 : GFXMMU LUT entry 106 high
$58031358 constant GFXMMU_S_GFXMMU_LUT107L  \ offset: 0x1358 : GFXMMU LUT entry 107 low
$5803135c constant GFXMMU_S_GFXMMU_LUT107H  \ offset: 0x135C : GFXMMU LUT entry 107 high
$58031360 constant GFXMMU_S_GFXMMU_LUT108L  \ offset: 0x1360 : GFXMMU LUT entry 108 low
$58031364 constant GFXMMU_S_GFXMMU_LUT108H  \ offset: 0x1364 : GFXMMU LUT entry 108 high
$58031368 constant GFXMMU_S_GFXMMU_LUT109L  \ offset: 0x1368 : GFXMMU LUT entry 109 low
$5803136c constant GFXMMU_S_GFXMMU_LUT109H  \ offset: 0x136C : GFXMMU LUT entry 109 high
$58031370 constant GFXMMU_S_GFXMMU_LUT110L  \ offset: 0x1370 : GFXMMU LUT entry 110 low
$58031374 constant GFXMMU_S_GFXMMU_LUT110H  \ offset: 0x1374 : GFXMMU LUT entry 110 high
$58031378 constant GFXMMU_S_GFXMMU_LUT111L  \ offset: 0x1378 : GFXMMU LUT entry 111 low
$5803137c constant GFXMMU_S_GFXMMU_LUT111H  \ offset: 0x137C : GFXMMU LUT entry 111 high
$58031380 constant GFXMMU_S_GFXMMU_LUT112L  \ offset: 0x1380 : GFXMMU LUT entry 112 low
$58031384 constant GFXMMU_S_GFXMMU_LUT112H  \ offset: 0x1384 : GFXMMU LUT entry 112 high
$58031388 constant GFXMMU_S_GFXMMU_LUT113L  \ offset: 0x1388 : GFXMMU LUT entry 113 low
$5803138c constant GFXMMU_S_GFXMMU_LUT113H  \ offset: 0x138C : GFXMMU LUT entry 113 high
$58031390 constant GFXMMU_S_GFXMMU_LUT114L  \ offset: 0x1390 : GFXMMU LUT entry 114 low
$58031394 constant GFXMMU_S_GFXMMU_LUT114H  \ offset: 0x1394 : GFXMMU LUT entry 114 high
$58031398 constant GFXMMU_S_GFXMMU_LUT115L  \ offset: 0x1398 : GFXMMU LUT entry 115 low
$5803139c constant GFXMMU_S_GFXMMU_LUT115H  \ offset: 0x139C : GFXMMU LUT entry 115 high
$580313a0 constant GFXMMU_S_GFXMMU_LUT116L  \ offset: 0x13A0 : GFXMMU LUT entry 116 low
$580313a4 constant GFXMMU_S_GFXMMU_LUT116H  \ offset: 0x13A4 : GFXMMU LUT entry 116 high
$580313a8 constant GFXMMU_S_GFXMMU_LUT117L  \ offset: 0x13A8 : GFXMMU LUT entry 117 low
$580313ac constant GFXMMU_S_GFXMMU_LUT117H  \ offset: 0x13AC : GFXMMU LUT entry 117 high
$580313b0 constant GFXMMU_S_GFXMMU_LUT118L  \ offset: 0x13B0 : GFXMMU LUT entry 118 low
$580313b4 constant GFXMMU_S_GFXMMU_LUT118H  \ offset: 0x13B4 : GFXMMU LUT entry 118 high
$580313b8 constant GFXMMU_S_GFXMMU_LUT119L  \ offset: 0x13B8 : GFXMMU LUT entry 119 low
$580313bc constant GFXMMU_S_GFXMMU_LUT119H  \ offset: 0x13BC : GFXMMU LUT entry 119 high
$580313c0 constant GFXMMU_S_GFXMMU_LUT120L  \ offset: 0x13C0 : GFXMMU LUT entry 120 low
$580313c4 constant GFXMMU_S_GFXMMU_LUT120H  \ offset: 0x13C4 : GFXMMU LUT entry 120 high
$580313c8 constant GFXMMU_S_GFXMMU_LUT121L  \ offset: 0x13C8 : GFXMMU LUT entry 121 low
$580313cc constant GFXMMU_S_GFXMMU_LUT121H  \ offset: 0x13CC : GFXMMU LUT entry 121 high
$580313d0 constant GFXMMU_S_GFXMMU_LUT122L  \ offset: 0x13D0 : GFXMMU LUT entry 122 low
$580313d4 constant GFXMMU_S_GFXMMU_LUT122H  \ offset: 0x13D4 : GFXMMU LUT entry 122 high
$580313d8 constant GFXMMU_S_GFXMMU_LUT123L  \ offset: 0x13D8 : GFXMMU LUT entry 123 low
$580313dc constant GFXMMU_S_GFXMMU_LUT123H  \ offset: 0x13DC : GFXMMU LUT entry 123 high
$580313e0 constant GFXMMU_S_GFXMMU_LUT124L  \ offset: 0x13E0 : GFXMMU LUT entry 124 low
$580313e4 constant GFXMMU_S_GFXMMU_LUT124H  \ offset: 0x13E4 : GFXMMU LUT entry 124 high
$580313e8 constant GFXMMU_S_GFXMMU_LUT125L  \ offset: 0x13E8 : GFXMMU LUT entry 125 low
$580313ec constant GFXMMU_S_GFXMMU_LUT125H  \ offset: 0x13EC : GFXMMU LUT entry 125 high
$580313f0 constant GFXMMU_S_GFXMMU_LUT126L  \ offset: 0x13F0 : GFXMMU LUT entry 126 low
$580313f4 constant GFXMMU_S_GFXMMU_LUT126H  \ offset: 0x13F4 : GFXMMU LUT entry 126 high
$580313f8 constant GFXMMU_S_GFXMMU_LUT127L  \ offset: 0x13F8 : GFXMMU LUT entry 127 low
$580313fc constant GFXMMU_S_GFXMMU_LUT127H  \ offset: 0x13FC : GFXMMU LUT entry 127 high
$58031400 constant GFXMMU_S_GFXMMU_LUT128L  \ offset: 0x1400 : GFXMMU LUT entry 128 low
$58031404 constant GFXMMU_S_GFXMMU_LUT128H  \ offset: 0x1404 : GFXMMU LUT entry 128 high
$58031408 constant GFXMMU_S_GFXMMU_LUT129L  \ offset: 0x1408 : GFXMMU LUT entry 129 low
$5803140c constant GFXMMU_S_GFXMMU_LUT129H  \ offset: 0x140C : GFXMMU LUT entry 129 high
$58031410 constant GFXMMU_S_GFXMMU_LUT130L  \ offset: 0x1410 : GFXMMU LUT entry 130 low
$58031414 constant GFXMMU_S_GFXMMU_LUT130H  \ offset: 0x1414 : GFXMMU LUT entry 130 high
$58031418 constant GFXMMU_S_GFXMMU_LUT131L  \ offset: 0x1418 : GFXMMU LUT entry 131 low
$5803141c constant GFXMMU_S_GFXMMU_LUT131H  \ offset: 0x141C : GFXMMU LUT entry 131 high
$58031420 constant GFXMMU_S_GFXMMU_LUT132L  \ offset: 0x1420 : GFXMMU LUT entry 132 low
$58031424 constant GFXMMU_S_GFXMMU_LUT132H  \ offset: 0x1424 : GFXMMU LUT entry 132 high
$58031428 constant GFXMMU_S_GFXMMU_LUT133L  \ offset: 0x1428 : GFXMMU LUT entry 133 low
$5803142c constant GFXMMU_S_GFXMMU_LUT133H  \ offset: 0x142C : GFXMMU LUT entry 133 high
$58031430 constant GFXMMU_S_GFXMMU_LUT134L  \ offset: 0x1430 : GFXMMU LUT entry 134 low
$58031434 constant GFXMMU_S_GFXMMU_LUT134H  \ offset: 0x1434 : GFXMMU LUT entry 134 high
$58031438 constant GFXMMU_S_GFXMMU_LUT135L  \ offset: 0x1438 : GFXMMU LUT entry 135 low
$5803143c constant GFXMMU_S_GFXMMU_LUT135H  \ offset: 0x143C : GFXMMU LUT entry 135 high
$58031440 constant GFXMMU_S_GFXMMU_LUT136L  \ offset: 0x1440 : GFXMMU LUT entry 136 low
$58031444 constant GFXMMU_S_GFXMMU_LUT136H  \ offset: 0x1444 : GFXMMU LUT entry 136 high
$58031448 constant GFXMMU_S_GFXMMU_LUT137L  \ offset: 0x1448 : GFXMMU LUT entry 137 low
$5803144c constant GFXMMU_S_GFXMMU_LUT137H  \ offset: 0x144C : GFXMMU LUT entry 137 high
$58031450 constant GFXMMU_S_GFXMMU_LUT138L  \ offset: 0x1450 : GFXMMU LUT entry 138 low
$58031454 constant GFXMMU_S_GFXMMU_LUT138H  \ offset: 0x1454 : GFXMMU LUT entry 138 high
$58031458 constant GFXMMU_S_GFXMMU_LUT139L  \ offset: 0x1458 : GFXMMU LUT entry 139 low
$5803145c constant GFXMMU_S_GFXMMU_LUT139H  \ offset: 0x145C : GFXMMU LUT entry 139 high
$58031460 constant GFXMMU_S_GFXMMU_LUT140L  \ offset: 0x1460 : GFXMMU LUT entry 140 low
$58031464 constant GFXMMU_S_GFXMMU_LUT140H  \ offset: 0x1464 : GFXMMU LUT entry 140 high
$58031468 constant GFXMMU_S_GFXMMU_LUT141L  \ offset: 0x1468 : GFXMMU LUT entry 141 low
$5803146c constant GFXMMU_S_GFXMMU_LUT141H  \ offset: 0x146C : GFXMMU LUT entry 141 high
$58031470 constant GFXMMU_S_GFXMMU_LUT142L  \ offset: 0x1470 : GFXMMU LUT entry 142 low
$58031474 constant GFXMMU_S_GFXMMU_LUT142H  \ offset: 0x1474 : GFXMMU LUT entry 142 high
$58031478 constant GFXMMU_S_GFXMMU_LUT143L  \ offset: 0x1478 : GFXMMU LUT entry 143 low
$5803147c constant GFXMMU_S_GFXMMU_LUT143H  \ offset: 0x147C : GFXMMU LUT entry 143 high
$58031480 constant GFXMMU_S_GFXMMU_LUT144L  \ offset: 0x1480 : GFXMMU LUT entry 144 low
$58031484 constant GFXMMU_S_GFXMMU_LUT144H  \ offset: 0x1484 : GFXMMU LUT entry 144 high
$58031488 constant GFXMMU_S_GFXMMU_LUT145L  \ offset: 0x1488 : GFXMMU LUT entry 145 low
$5803148c constant GFXMMU_S_GFXMMU_LUT145H  \ offset: 0x148C : GFXMMU LUT entry 145 high
$58031490 constant GFXMMU_S_GFXMMU_LUT146L  \ offset: 0x1490 : GFXMMU LUT entry 146 low
$58031494 constant GFXMMU_S_GFXMMU_LUT146H  \ offset: 0x1494 : GFXMMU LUT entry 146 high
$58031498 constant GFXMMU_S_GFXMMU_LUT147L  \ offset: 0x1498 : GFXMMU LUT entry 147 low
$5803149c constant GFXMMU_S_GFXMMU_LUT147H  \ offset: 0x149C : GFXMMU LUT entry 147 high
$580314a0 constant GFXMMU_S_GFXMMU_LUT148L  \ offset: 0x14A0 : GFXMMU LUT entry 148 low
$580314a4 constant GFXMMU_S_GFXMMU_LUT148H  \ offset: 0x14A4 : GFXMMU LUT entry 148 high
$580314a8 constant GFXMMU_S_GFXMMU_LUT149L  \ offset: 0x14A8 : GFXMMU LUT entry 149 low
$580314ac constant GFXMMU_S_GFXMMU_LUT149H  \ offset: 0x14AC : GFXMMU LUT entry 149 high
$580314b0 constant GFXMMU_S_GFXMMU_LUT150L  \ offset: 0x14B0 : GFXMMU LUT entry 150 low
$580314b4 constant GFXMMU_S_GFXMMU_LUT150H  \ offset: 0x14B4 : GFXMMU LUT entry 150 high
$580314b8 constant GFXMMU_S_GFXMMU_LUT151L  \ offset: 0x14B8 : GFXMMU LUT entry 151 low
$580314bc constant GFXMMU_S_GFXMMU_LUT151H  \ offset: 0x14BC : GFXMMU LUT entry 151 high
$580314c0 constant GFXMMU_S_GFXMMU_LUT152L  \ offset: 0x14C0 : GFXMMU LUT entry 152 low
$580314c4 constant GFXMMU_S_GFXMMU_LUT152H  \ offset: 0x14C4 : GFXMMU LUT entry 152 high
$580314c8 constant GFXMMU_S_GFXMMU_LUT153L  \ offset: 0x14C8 : GFXMMU LUT entry 153 low
$580314cc constant GFXMMU_S_GFXMMU_LUT153H  \ offset: 0x14CC : GFXMMU LUT entry 153 high
$580314d0 constant GFXMMU_S_GFXMMU_LUT154L  \ offset: 0x14D0 : GFXMMU LUT entry 154 low
$580314d4 constant GFXMMU_S_GFXMMU_LUT154H  \ offset: 0x14D4 : GFXMMU LUT entry 154 high
$580314d8 constant GFXMMU_S_GFXMMU_LUT155L  \ offset: 0x14D8 : GFXMMU LUT entry 155 low
$580314dc constant GFXMMU_S_GFXMMU_LUT155H  \ offset: 0x14DC : GFXMMU LUT entry 155 high
$580314e0 constant GFXMMU_S_GFXMMU_LUT156L  \ offset: 0x14E0 : GFXMMU LUT entry 156 low
$580314e4 constant GFXMMU_S_GFXMMU_LUT156H  \ offset: 0x14E4 : GFXMMU LUT entry 156 high
$580314e8 constant GFXMMU_S_GFXMMU_LUT157L  \ offset: 0x14E8 : GFXMMU LUT entry 157 low
$580314ec constant GFXMMU_S_GFXMMU_LUT157H  \ offset: 0x14EC : GFXMMU LUT entry 157 high
$580314f0 constant GFXMMU_S_GFXMMU_LUT158L  \ offset: 0x14F0 : GFXMMU LUT entry 158 low
$580314f4 constant GFXMMU_S_GFXMMU_LUT158H  \ offset: 0x14F4 : GFXMMU LUT entry 158 high
$580314f8 constant GFXMMU_S_GFXMMU_LUT159L  \ offset: 0x14F8 : GFXMMU LUT entry 159 low
$580314fc constant GFXMMU_S_GFXMMU_LUT159H  \ offset: 0x14FC : GFXMMU LUT entry 159 high
$58031500 constant GFXMMU_S_GFXMMU_LUT160L  \ offset: 0x1500 : GFXMMU LUT entry 160 low
$58031504 constant GFXMMU_S_GFXMMU_LUT160H  \ offset: 0x1504 : GFXMMU LUT entry 160 high
$58031508 constant GFXMMU_S_GFXMMU_LUT161L  \ offset: 0x1508 : GFXMMU LUT entry 161 low
$5803150c constant GFXMMU_S_GFXMMU_LUT161H  \ offset: 0x150C : GFXMMU LUT entry 161 high
$58031510 constant GFXMMU_S_GFXMMU_LUT162L  \ offset: 0x1510 : GFXMMU LUT entry 162 low
$58031514 constant GFXMMU_S_GFXMMU_LUT162H  \ offset: 0x1514 : GFXMMU LUT entry 162 high
$58031518 constant GFXMMU_S_GFXMMU_LUT163L  \ offset: 0x1518 : GFXMMU LUT entry 163 low
$5803151c constant GFXMMU_S_GFXMMU_LUT163H  \ offset: 0x151C : GFXMMU LUT entry 163 high
$58031520 constant GFXMMU_S_GFXMMU_LUT164L  \ offset: 0x1520 : GFXMMU LUT entry 164 low
$58031524 constant GFXMMU_S_GFXMMU_LUT164H  \ offset: 0x1524 : GFXMMU LUT entry 164 high
$58031528 constant GFXMMU_S_GFXMMU_LUT165L  \ offset: 0x1528 : GFXMMU LUT entry 165 low
$5803152c constant GFXMMU_S_GFXMMU_LUT165H  \ offset: 0x152C : GFXMMU LUT entry 165 high
$58031530 constant GFXMMU_S_GFXMMU_LUT166L  \ offset: 0x1530 : GFXMMU LUT entry 166 low
$58031534 constant GFXMMU_S_GFXMMU_LUT166H  \ offset: 0x1534 : GFXMMU LUT entry 166 high
$58031538 constant GFXMMU_S_GFXMMU_LUT167L  \ offset: 0x1538 : GFXMMU LUT entry 167 low
$5803153c constant GFXMMU_S_GFXMMU_LUT167H  \ offset: 0x153C : GFXMMU LUT entry 167 high
$58031540 constant GFXMMU_S_GFXMMU_LUT168L  \ offset: 0x1540 : GFXMMU LUT entry 168 low
$58031544 constant GFXMMU_S_GFXMMU_LUT168H  \ offset: 0x1544 : GFXMMU LUT entry 168 high
$58031548 constant GFXMMU_S_GFXMMU_LUT169L  \ offset: 0x1548 : GFXMMU LUT entry 169 low
$5803154c constant GFXMMU_S_GFXMMU_LUT169H  \ offset: 0x154C : GFXMMU LUT entry 169 high
$58031550 constant GFXMMU_S_GFXMMU_LUT170L  \ offset: 0x1550 : GFXMMU LUT entry 170 low
$58031554 constant GFXMMU_S_GFXMMU_LUT170H  \ offset: 0x1554 : GFXMMU LUT entry 170 high
$58031558 constant GFXMMU_S_GFXMMU_LUT171L  \ offset: 0x1558 : GFXMMU LUT entry 171 low
$5803155c constant GFXMMU_S_GFXMMU_LUT171H  \ offset: 0x155C : GFXMMU LUT entry 171 high
$58031560 constant GFXMMU_S_GFXMMU_LUT172L  \ offset: 0x1560 : GFXMMU LUT entry 172 low
$58031564 constant GFXMMU_S_GFXMMU_LUT172H  \ offset: 0x1564 : GFXMMU LUT entry 172 high
$58031568 constant GFXMMU_S_GFXMMU_LUT173L  \ offset: 0x1568 : GFXMMU LUT entry 173 low
$5803156c constant GFXMMU_S_GFXMMU_LUT173H  \ offset: 0x156C : GFXMMU LUT entry 173 high
$58031570 constant GFXMMU_S_GFXMMU_LUT174L  \ offset: 0x1570 : GFXMMU LUT entry 174 low
$58031574 constant GFXMMU_S_GFXMMU_LUT174H  \ offset: 0x1574 : GFXMMU LUT entry 174 high
$58031578 constant GFXMMU_S_GFXMMU_LUT175L  \ offset: 0x1578 : GFXMMU LUT entry 175 low
$5803157c constant GFXMMU_S_GFXMMU_LUT175H  \ offset: 0x157C : GFXMMU LUT entry 175 high
$58031580 constant GFXMMU_S_GFXMMU_LUT176L  \ offset: 0x1580 : GFXMMU LUT entry 176 low
$58031584 constant GFXMMU_S_GFXMMU_LUT176H  \ offset: 0x1584 : GFXMMU LUT entry 176 high
$58031588 constant GFXMMU_S_GFXMMU_LUT177L  \ offset: 0x1588 : GFXMMU LUT entry 177 low
$5803158c constant GFXMMU_S_GFXMMU_LUT177H  \ offset: 0x158C : GFXMMU LUT entry 177 high
$58031590 constant GFXMMU_S_GFXMMU_LUT178L  \ offset: 0x1590 : GFXMMU LUT entry 178 low
$58031594 constant GFXMMU_S_GFXMMU_LUT178H  \ offset: 0x1594 : GFXMMU LUT entry 178 high
$58031598 constant GFXMMU_S_GFXMMU_LUT179L  \ offset: 0x1598 : GFXMMU LUT entry 179 low
$5803159c constant GFXMMU_S_GFXMMU_LUT179H  \ offset: 0x159C : GFXMMU LUT entry 179 high
$580315a0 constant GFXMMU_S_GFXMMU_LUT180L  \ offset: 0x15A0 : GFXMMU LUT entry 180 low
$580315a4 constant GFXMMU_S_GFXMMU_LUT180H  \ offset: 0x15A4 : GFXMMU LUT entry 180 high
$580315a8 constant GFXMMU_S_GFXMMU_LUT181L  \ offset: 0x15A8 : GFXMMU LUT entry 181 low
$580315ac constant GFXMMU_S_GFXMMU_LUT181H  \ offset: 0x15AC : GFXMMU LUT entry 181 high
$580315b0 constant GFXMMU_S_GFXMMU_LUT182L  \ offset: 0x15B0 : GFXMMU LUT entry 182 low
$580315b4 constant GFXMMU_S_GFXMMU_LUT182H  \ offset: 0x15B4 : GFXMMU LUT entry 182 high
$580315b8 constant GFXMMU_S_GFXMMU_LUT183L  \ offset: 0x15B8 : GFXMMU LUT entry 183 low
$580315bc constant GFXMMU_S_GFXMMU_LUT183H  \ offset: 0x15BC : GFXMMU LUT entry 183 high
$580315c0 constant GFXMMU_S_GFXMMU_LUT184L  \ offset: 0x15C0 : GFXMMU LUT entry 184 low
$580315c4 constant GFXMMU_S_GFXMMU_LUT184H  \ offset: 0x15C4 : GFXMMU LUT entry 184 high
$580315c8 constant GFXMMU_S_GFXMMU_LUT185L  \ offset: 0x15C8 : GFXMMU LUT entry 185 low
$580315cc constant GFXMMU_S_GFXMMU_LUT185H  \ offset: 0x15CC : GFXMMU LUT entry 185 high
$580315d0 constant GFXMMU_S_GFXMMU_LUT186L  \ offset: 0x15D0 : GFXMMU LUT entry 186 low
$580315d4 constant GFXMMU_S_GFXMMU_LUT186H  \ offset: 0x15D4 : GFXMMU LUT entry 186 high
$580315d8 constant GFXMMU_S_GFXMMU_LUT187L  \ offset: 0x15D8 : GFXMMU LUT entry 187 low
$580315dc constant GFXMMU_S_GFXMMU_LUT187H  \ offset: 0x15DC : GFXMMU LUT entry 187 high
$580315e0 constant GFXMMU_S_GFXMMU_LUT188L  \ offset: 0x15E0 : GFXMMU LUT entry 188 low
$580315e4 constant GFXMMU_S_GFXMMU_LUT188H  \ offset: 0x15E4 : GFXMMU LUT entry 188 high
$580315e8 constant GFXMMU_S_GFXMMU_LUT189L  \ offset: 0x15E8 : GFXMMU LUT entry 189 low
$580315ec constant GFXMMU_S_GFXMMU_LUT189H  \ offset: 0x15EC : GFXMMU LUT entry 189 high
$580315f0 constant GFXMMU_S_GFXMMU_LUT190L  \ offset: 0x15F0 : GFXMMU LUT entry 190 low
$580315f4 constant GFXMMU_S_GFXMMU_LUT190H  \ offset: 0x15F4 : GFXMMU LUT entry 190 high
$580315f8 constant GFXMMU_S_GFXMMU_LUT191L  \ offset: 0x15F8 : GFXMMU LUT entry 191 low
$580315fc constant GFXMMU_S_GFXMMU_LUT191H  \ offset: 0x15FC : GFXMMU LUT entry 191 high
$58031600 constant GFXMMU_S_GFXMMU_LUT192L  \ offset: 0x1600 : GFXMMU LUT entry 192 low
$58031604 constant GFXMMU_S_GFXMMU_LUT192H  \ offset: 0x1604 : GFXMMU LUT entry 192 high
$58031608 constant GFXMMU_S_GFXMMU_LUT193L  \ offset: 0x1608 : GFXMMU LUT entry 193 low
$5803160c constant GFXMMU_S_GFXMMU_LUT193H  \ offset: 0x160C : GFXMMU LUT entry 193 high
$58031610 constant GFXMMU_S_GFXMMU_LUT194L  \ offset: 0x1610 : GFXMMU LUT entry 194 low
$58031614 constant GFXMMU_S_GFXMMU_LUT194H  \ offset: 0x1614 : GFXMMU LUT entry 194 high
$58031618 constant GFXMMU_S_GFXMMU_LUT195L  \ offset: 0x1618 : GFXMMU LUT entry 195 low
$5803161c constant GFXMMU_S_GFXMMU_LUT195H  \ offset: 0x161C : GFXMMU LUT entry 195 high
$58031620 constant GFXMMU_S_GFXMMU_LUT196L  \ offset: 0x1620 : GFXMMU LUT entry 196 low
$58031624 constant GFXMMU_S_GFXMMU_LUT196H  \ offset: 0x1624 : GFXMMU LUT entry 196 high
$58031628 constant GFXMMU_S_GFXMMU_LUT197L  \ offset: 0x1628 : GFXMMU LUT entry 197 low
$5803162c constant GFXMMU_S_GFXMMU_LUT197H  \ offset: 0x162C : GFXMMU LUT entry 197 high
$58031630 constant GFXMMU_S_GFXMMU_LUT198L  \ offset: 0x1630 : GFXMMU LUT entry 198 low
$58031634 constant GFXMMU_S_GFXMMU_LUT198H  \ offset: 0x1634 : GFXMMU LUT entry 198 high
$58031638 constant GFXMMU_S_GFXMMU_LUT199L  \ offset: 0x1638 : GFXMMU LUT entry 199 low
$5803163c constant GFXMMU_S_GFXMMU_LUT199H  \ offset: 0x163C : GFXMMU LUT entry 199 high
$58031640 constant GFXMMU_S_GFXMMU_LUT200L  \ offset: 0x1640 : GFXMMU LUT entry 200 low
$58031644 constant GFXMMU_S_GFXMMU_LUT200H  \ offset: 0x1644 : GFXMMU LUT entry 200 high
$58031648 constant GFXMMU_S_GFXMMU_LUT201L  \ offset: 0x1648 : GFXMMU LUT entry 201 low
$5803164c constant GFXMMU_S_GFXMMU_LUT201H  \ offset: 0x164C : GFXMMU LUT entry 201 high
$58031650 constant GFXMMU_S_GFXMMU_LUT202L  \ offset: 0x1650 : GFXMMU LUT entry 202 low
$58031654 constant GFXMMU_S_GFXMMU_LUT202H  \ offset: 0x1654 : GFXMMU LUT entry 202 high
$58031658 constant GFXMMU_S_GFXMMU_LUT203L  \ offset: 0x1658 : GFXMMU LUT entry 203 low
$5803165c constant GFXMMU_S_GFXMMU_LUT203H  \ offset: 0x165C : GFXMMU LUT entry 203 high
$58031660 constant GFXMMU_S_GFXMMU_LUT204L  \ offset: 0x1660 : GFXMMU LUT entry 204 low
$58031664 constant GFXMMU_S_GFXMMU_LUT204H  \ offset: 0x1664 : GFXMMU LUT entry 204 high
$58031668 constant GFXMMU_S_GFXMMU_LUT205L  \ offset: 0x1668 : GFXMMU LUT entry 205 low
$5803166c constant GFXMMU_S_GFXMMU_LUT205H  \ offset: 0x166C : GFXMMU LUT entry 205 high
$58031670 constant GFXMMU_S_GFXMMU_LUT206L  \ offset: 0x1670 : GFXMMU LUT entry 206 low
$58031674 constant GFXMMU_S_GFXMMU_LUT206H  \ offset: 0x1674 : GFXMMU LUT entry 206 high
$58031678 constant GFXMMU_S_GFXMMU_LUT207L  \ offset: 0x1678 : GFXMMU LUT entry 207 low
$5803167c constant GFXMMU_S_GFXMMU_LUT207H  \ offset: 0x167C : GFXMMU LUT entry 207 high
$58031680 constant GFXMMU_S_GFXMMU_LUT208L  \ offset: 0x1680 : GFXMMU LUT entry 208 low
$58031684 constant GFXMMU_S_GFXMMU_LUT208H  \ offset: 0x1684 : GFXMMU LUT entry 208 high
$58031688 constant GFXMMU_S_GFXMMU_LUT209L  \ offset: 0x1688 : GFXMMU LUT entry 209 low
$5803168c constant GFXMMU_S_GFXMMU_LUT209H  \ offset: 0x168C : GFXMMU LUT entry 209 high
$58031690 constant GFXMMU_S_GFXMMU_LUT210L  \ offset: 0x1690 : GFXMMU LUT entry 210 low
$58031694 constant GFXMMU_S_GFXMMU_LUT210H  \ offset: 0x1694 : GFXMMU LUT entry 210 high
$58031698 constant GFXMMU_S_GFXMMU_LUT211L  \ offset: 0x1698 : GFXMMU LUT entry 211 low
$5803169c constant GFXMMU_S_GFXMMU_LUT211H  \ offset: 0x169C : GFXMMU LUT entry 211 high
$580316a0 constant GFXMMU_S_GFXMMU_LUT212L  \ offset: 0x16A0 : GFXMMU LUT entry 212 low
$580316a4 constant GFXMMU_S_GFXMMU_LUT212H  \ offset: 0x16A4 : GFXMMU LUT entry 212 high
$580316a8 constant GFXMMU_S_GFXMMU_LUT213L  \ offset: 0x16A8 : GFXMMU LUT entry 213 low
$580316ac constant GFXMMU_S_GFXMMU_LUT213H  \ offset: 0x16AC : GFXMMU LUT entry 213 high
$580316b0 constant GFXMMU_S_GFXMMU_LUT214L  \ offset: 0x16B0 : GFXMMU LUT entry 214 low
$580316b4 constant GFXMMU_S_GFXMMU_LUT214H  \ offset: 0x16B4 : GFXMMU LUT entry 214 high
$580316b8 constant GFXMMU_S_GFXMMU_LUT215L  \ offset: 0x16B8 : GFXMMU LUT entry 215 low
$580316bc constant GFXMMU_S_GFXMMU_LUT215H  \ offset: 0x16BC : GFXMMU LUT entry 215 high
$580316c0 constant GFXMMU_S_GFXMMU_LUT216L  \ offset: 0x16C0 : GFXMMU LUT entry 216 low
$580316c4 constant GFXMMU_S_GFXMMU_LUT216H  \ offset: 0x16C4 : GFXMMU LUT entry 216 high
$580316c8 constant GFXMMU_S_GFXMMU_LUT217L  \ offset: 0x16C8 : GFXMMU LUT entry 217 low
$580316cc constant GFXMMU_S_GFXMMU_LUT217H  \ offset: 0x16CC : GFXMMU LUT entry 217 high
$580316d0 constant GFXMMU_S_GFXMMU_LUT218L  \ offset: 0x16D0 : GFXMMU LUT entry 218 low
$580316d4 constant GFXMMU_S_GFXMMU_LUT218H  \ offset: 0x16D4 : GFXMMU LUT entry 218 high
$580316d8 constant GFXMMU_S_GFXMMU_LUT219L  \ offset: 0x16D8 : GFXMMU LUT entry 219 low
$580316dc constant GFXMMU_S_GFXMMU_LUT219H  \ offset: 0x16DC : GFXMMU LUT entry 219 high
$580316e0 constant GFXMMU_S_GFXMMU_LUT220L  \ offset: 0x16E0 : GFXMMU LUT entry 220 low
$580316e4 constant GFXMMU_S_GFXMMU_LUT220H  \ offset: 0x16E4 : GFXMMU LUT entry 220 high
$580316e8 constant GFXMMU_S_GFXMMU_LUT221L  \ offset: 0x16E8 : GFXMMU LUT entry 221 low
$580316ec constant GFXMMU_S_GFXMMU_LUT221H  \ offset: 0x16EC : GFXMMU LUT entry 221 high
$580316f0 constant GFXMMU_S_GFXMMU_LUT222L  \ offset: 0x16F0 : GFXMMU LUT entry 222 low
$580316f4 constant GFXMMU_S_GFXMMU_LUT222H  \ offset: 0x16F4 : GFXMMU LUT entry 222 high
$580316f8 constant GFXMMU_S_GFXMMU_LUT223L  \ offset: 0x16F8 : GFXMMU LUT entry 223 low
$580316fc constant GFXMMU_S_GFXMMU_LUT223H  \ offset: 0x16FC : GFXMMU LUT entry 223 high
$58031700 constant GFXMMU_S_GFXMMU_LUT224L  \ offset: 0x1700 : GFXMMU LUT entry 224 low
$58031704 constant GFXMMU_S_GFXMMU_LUT224H  \ offset: 0x1704 : GFXMMU LUT entry 224 high
$58031708 constant GFXMMU_S_GFXMMU_LUT225L  \ offset: 0x1708 : GFXMMU LUT entry 225 low
$5803170c constant GFXMMU_S_GFXMMU_LUT225H  \ offset: 0x170C : GFXMMU LUT entry 225 high
$58031710 constant GFXMMU_S_GFXMMU_LUT226L  \ offset: 0x1710 : GFXMMU LUT entry 226 low
$58031714 constant GFXMMU_S_GFXMMU_LUT226H  \ offset: 0x1714 : GFXMMU LUT entry 226 high
$58031718 constant GFXMMU_S_GFXMMU_LUT227L  \ offset: 0x1718 : GFXMMU LUT entry 227 low
$5803171c constant GFXMMU_S_GFXMMU_LUT227H  \ offset: 0x171C : GFXMMU LUT entry 227 high
$58031720 constant GFXMMU_S_GFXMMU_LUT228L  \ offset: 0x1720 : GFXMMU LUT entry 228 low
$58031724 constant GFXMMU_S_GFXMMU_LUT228H  \ offset: 0x1724 : GFXMMU LUT entry 228 high
$58031728 constant GFXMMU_S_GFXMMU_LUT229L  \ offset: 0x1728 : GFXMMU LUT entry 229 low
$5803172c constant GFXMMU_S_GFXMMU_LUT229H  \ offset: 0x172C : GFXMMU LUT entry 229 high
$58031730 constant GFXMMU_S_GFXMMU_LUT230L  \ offset: 0x1730 : GFXMMU LUT entry 230 low
$58031734 constant GFXMMU_S_GFXMMU_LUT230H  \ offset: 0x1734 : GFXMMU LUT entry 230 high
$58031738 constant GFXMMU_S_GFXMMU_LUT231L  \ offset: 0x1738 : GFXMMU LUT entry 231 low
$5803173c constant GFXMMU_S_GFXMMU_LUT231H  \ offset: 0x173C : GFXMMU LUT entry 231 high
$58031740 constant GFXMMU_S_GFXMMU_LUT232L  \ offset: 0x1740 : GFXMMU LUT entry 232 low
$58031744 constant GFXMMU_S_GFXMMU_LUT232H  \ offset: 0x1744 : GFXMMU LUT entry 232 high
$58031748 constant GFXMMU_S_GFXMMU_LUT233L  \ offset: 0x1748 : GFXMMU LUT entry 233 low
$5803174c constant GFXMMU_S_GFXMMU_LUT233H  \ offset: 0x174C : GFXMMU LUT entry 233 high
$58031750 constant GFXMMU_S_GFXMMU_LUT234L  \ offset: 0x1750 : GFXMMU LUT entry 234 low
$58031754 constant GFXMMU_S_GFXMMU_LUT234H  \ offset: 0x1754 : GFXMMU LUT entry 234 high
$58031758 constant GFXMMU_S_GFXMMU_LUT235L  \ offset: 0x1758 : GFXMMU LUT entry 235 low
$5803175c constant GFXMMU_S_GFXMMU_LUT235H  \ offset: 0x175C : GFXMMU LUT entry 235 high
$58031760 constant GFXMMU_S_GFXMMU_LUT236L  \ offset: 0x1760 : GFXMMU LUT entry 236 low
$58031764 constant GFXMMU_S_GFXMMU_LUT236H  \ offset: 0x1764 : GFXMMU LUT entry 236 high
$58031768 constant GFXMMU_S_GFXMMU_LUT237L  \ offset: 0x1768 : GFXMMU LUT entry 237 low
$5803176c constant GFXMMU_S_GFXMMU_LUT237H  \ offset: 0x176C : GFXMMU LUT entry 237 high
$58031770 constant GFXMMU_S_GFXMMU_LUT238L  \ offset: 0x1770 : GFXMMU LUT entry 238 low
$58031774 constant GFXMMU_S_GFXMMU_LUT238H  \ offset: 0x1774 : GFXMMU LUT entry 238 high
$58031778 constant GFXMMU_S_GFXMMU_LUT239L  \ offset: 0x1778 : GFXMMU LUT entry 239 low
$5803177c constant GFXMMU_S_GFXMMU_LUT239H  \ offset: 0x177C : GFXMMU LUT entry 239 high
$58031780 constant GFXMMU_S_GFXMMU_LUT240L  \ offset: 0x1780 : GFXMMU LUT entry 240 low
$58031784 constant GFXMMU_S_GFXMMU_LUT240H  \ offset: 0x1784 : GFXMMU LUT entry 240 high
$58031788 constant GFXMMU_S_GFXMMU_LUT241L  \ offset: 0x1788 : GFXMMU LUT entry 241 low
$5803178c constant GFXMMU_S_GFXMMU_LUT241H  \ offset: 0x178C : GFXMMU LUT entry 241 high
$58031790 constant GFXMMU_S_GFXMMU_LUT242L  \ offset: 0x1790 : GFXMMU LUT entry 242 low
$58031794 constant GFXMMU_S_GFXMMU_LUT242H  \ offset: 0x1794 : GFXMMU LUT entry 242 high
$58031798 constant GFXMMU_S_GFXMMU_LUT243L  \ offset: 0x1798 : GFXMMU LUT entry 243 low
$5803179c constant GFXMMU_S_GFXMMU_LUT243H  \ offset: 0x179C : GFXMMU LUT entry 243 high
$580317a0 constant GFXMMU_S_GFXMMU_LUT244L  \ offset: 0x17A0 : GFXMMU LUT entry 244 low
$580317a4 constant GFXMMU_S_GFXMMU_LUT244H  \ offset: 0x17A4 : GFXMMU LUT entry 244 high
$580317a8 constant GFXMMU_S_GFXMMU_LUT245L  \ offset: 0x17A8 : GFXMMU LUT entry 245 low
$580317ac constant GFXMMU_S_GFXMMU_LUT245H  \ offset: 0x17AC : GFXMMU LUT entry 245 high
$580317b0 constant GFXMMU_S_GFXMMU_LUT246L  \ offset: 0x17B0 : GFXMMU LUT entry 246 low
$580317b4 constant GFXMMU_S_GFXMMU_LUT246H  \ offset: 0x17B4 : GFXMMU LUT entry 246 high
$580317b8 constant GFXMMU_S_GFXMMU_LUT247L  \ offset: 0x17B8 : GFXMMU LUT entry 247 low
$580317bc constant GFXMMU_S_GFXMMU_LUT247H  \ offset: 0x17BC : GFXMMU LUT entry 247 high
$580317c0 constant GFXMMU_S_GFXMMU_LUT248L  \ offset: 0x17C0 : GFXMMU LUT entry 248 low
$580317c4 constant GFXMMU_S_GFXMMU_LUT248H  \ offset: 0x17C4 : GFXMMU LUT entry 248 high
$580317c8 constant GFXMMU_S_GFXMMU_LUT249L  \ offset: 0x17C8 : GFXMMU LUT entry 249 low
$580317cc constant GFXMMU_S_GFXMMU_LUT249H  \ offset: 0x17CC : GFXMMU LUT entry 249 high
$580317d0 constant GFXMMU_S_GFXMMU_LUT250L  \ offset: 0x17D0 : GFXMMU LUT entry 250 low
$580317d4 constant GFXMMU_S_GFXMMU_LUT250H  \ offset: 0x17D4 : GFXMMU LUT entry 250 high
$580317d8 constant GFXMMU_S_GFXMMU_LUT251L  \ offset: 0x17D8 : GFXMMU LUT entry 251 low
$580317dc constant GFXMMU_S_GFXMMU_LUT251H  \ offset: 0x17DC : GFXMMU LUT entry 251 high
$580317e0 constant GFXMMU_S_GFXMMU_LUT252L  \ offset: 0x17E0 : GFXMMU LUT entry 252 low
$580317e4 constant GFXMMU_S_GFXMMU_LUT252H  \ offset: 0x17E4 : GFXMMU LUT entry 252 high
$580317e8 constant GFXMMU_S_GFXMMU_LUT253L  \ offset: 0x17E8 : GFXMMU LUT entry 253 low
$580317ec constant GFXMMU_S_GFXMMU_LUT253H  \ offset: 0x17EC : GFXMMU LUT entry 253 high
$580317f0 constant GFXMMU_S_GFXMMU_LUT254L  \ offset: 0x17F0 : GFXMMU LUT entry 254 low
$580317f4 constant GFXMMU_S_GFXMMU_LUT254H  \ offset: 0x17F4 : GFXMMU LUT entry 254 high
$580317f8 constant GFXMMU_S_GFXMMU_LUT255L  \ offset: 0x17F8 : GFXMMU LUT entry 255 low
$580317fc constant GFXMMU_S_GFXMMU_LUT255H  \ offset: 0x17FC : GFXMMU LUT entry 255 high
$58031800 constant GFXMMU_S_GFXMMU_LUT256L  \ offset: 0x1800 : GFXMMU LUT entry 256 low
$58031804 constant GFXMMU_S_GFXMMU_LUT256H  \ offset: 0x1804 : GFXMMU LUT entry 256 high
$58031808 constant GFXMMU_S_GFXMMU_LUT257L  \ offset: 0x1808 : GFXMMU LUT entry 257 low
$5803180c constant GFXMMU_S_GFXMMU_LUT257H  \ offset: 0x180C : GFXMMU LUT entry 257 high
$58031810 constant GFXMMU_S_GFXMMU_LUT258L  \ offset: 0x1810 : GFXMMU LUT entry 258 low
$58031814 constant GFXMMU_S_GFXMMU_LUT258H  \ offset: 0x1814 : GFXMMU LUT entry 258 high
$58031818 constant GFXMMU_S_GFXMMU_LUT259L  \ offset: 0x1818 : GFXMMU LUT entry 259 low
$5803181c constant GFXMMU_S_GFXMMU_LUT259H  \ offset: 0x181C : GFXMMU LUT entry 259 high
$58031820 constant GFXMMU_S_GFXMMU_LUT260L  \ offset: 0x1820 : GFXMMU LUT entry 260 low
$58031824 constant GFXMMU_S_GFXMMU_LUT260H  \ offset: 0x1824 : GFXMMU LUT entry 260 high
$58031828 constant GFXMMU_S_GFXMMU_LUT261L  \ offset: 0x1828 : GFXMMU LUT entry 261 low
$5803182c constant GFXMMU_S_GFXMMU_LUT261H  \ offset: 0x182C : GFXMMU LUT entry 261 high
$58031830 constant GFXMMU_S_GFXMMU_LUT262L  \ offset: 0x1830 : GFXMMU LUT entry 262 low
$58031834 constant GFXMMU_S_GFXMMU_LUT262H  \ offset: 0x1834 : GFXMMU LUT entry 262 high
$58031838 constant GFXMMU_S_GFXMMU_LUT263L  \ offset: 0x1838 : GFXMMU LUT entry 263 low
$5803183c constant GFXMMU_S_GFXMMU_LUT263H  \ offset: 0x183C : GFXMMU LUT entry 263 high
$58031840 constant GFXMMU_S_GFXMMU_LUT264L  \ offset: 0x1840 : GFXMMU LUT entry 264 low
$58031844 constant GFXMMU_S_GFXMMU_LUT264H  \ offset: 0x1844 : GFXMMU LUT entry 264 high
$58031848 constant GFXMMU_S_GFXMMU_LUT265L  \ offset: 0x1848 : GFXMMU LUT entry 265 low
$5803184c constant GFXMMU_S_GFXMMU_LUT265H  \ offset: 0x184C : GFXMMU LUT entry 265 high
$58031850 constant GFXMMU_S_GFXMMU_LUT266L  \ offset: 0x1850 : GFXMMU LUT entry 266 low
$58031854 constant GFXMMU_S_GFXMMU_LUT266H  \ offset: 0x1854 : GFXMMU LUT entry 266 high
$58031858 constant GFXMMU_S_GFXMMU_LUT267L  \ offset: 0x1858 : GFXMMU LUT entry 267 low
$5803185c constant GFXMMU_S_GFXMMU_LUT267H  \ offset: 0x185C : GFXMMU LUT entry 267 high
$58031860 constant GFXMMU_S_GFXMMU_LUT268L  \ offset: 0x1860 : GFXMMU LUT entry 268 low
$58031864 constant GFXMMU_S_GFXMMU_LUT268H  \ offset: 0x1864 : GFXMMU LUT entry 268 high
$58031868 constant GFXMMU_S_GFXMMU_LUT269L  \ offset: 0x1868 : GFXMMU LUT entry 269 low
$5803186c constant GFXMMU_S_GFXMMU_LUT269H  \ offset: 0x186C : GFXMMU LUT entry 269 high
$58031870 constant GFXMMU_S_GFXMMU_LUT270L  \ offset: 0x1870 : GFXMMU LUT entry 270 low
$58031874 constant GFXMMU_S_GFXMMU_LUT270H  \ offset: 0x1874 : GFXMMU LUT entry 270 high
$58031878 constant GFXMMU_S_GFXMMU_LUT271L  \ offset: 0x1878 : GFXMMU LUT entry 271 low
$5803187c constant GFXMMU_S_GFXMMU_LUT271H  \ offset: 0x187C : GFXMMU LUT entry 271 high
$58031880 constant GFXMMU_S_GFXMMU_LUT272L  \ offset: 0x1880 : GFXMMU LUT entry 272 low
$58031884 constant GFXMMU_S_GFXMMU_LUT272H  \ offset: 0x1884 : GFXMMU LUT entry 272 high
$58031888 constant GFXMMU_S_GFXMMU_LUT273L  \ offset: 0x1888 : GFXMMU LUT entry 273 low
$5803188c constant GFXMMU_S_GFXMMU_LUT273H  \ offset: 0x188C : GFXMMU LUT entry 273 high
$58031890 constant GFXMMU_S_GFXMMU_LUT274L  \ offset: 0x1890 : GFXMMU LUT entry 274 low
$58031894 constant GFXMMU_S_GFXMMU_LUT274H  \ offset: 0x1894 : GFXMMU LUT entry 274 high
$58031898 constant GFXMMU_S_GFXMMU_LUT275L  \ offset: 0x1898 : GFXMMU LUT entry 275 low
$5803189c constant GFXMMU_S_GFXMMU_LUT275H  \ offset: 0x189C : GFXMMU LUT entry 275 high
$580318a0 constant GFXMMU_S_GFXMMU_LUT276L  \ offset: 0x18A0 : GFXMMU LUT entry 276 low
$580318a4 constant GFXMMU_S_GFXMMU_LUT276H  \ offset: 0x18A4 : GFXMMU LUT entry 276 high
$580318a8 constant GFXMMU_S_GFXMMU_LUT277L  \ offset: 0x18A8 : GFXMMU LUT entry 277 low
$580318ac constant GFXMMU_S_GFXMMU_LUT277H  \ offset: 0x18AC : GFXMMU LUT entry 277 high
$580318b0 constant GFXMMU_S_GFXMMU_LUT278L  \ offset: 0x18B0 : GFXMMU LUT entry 278 low
$580318b4 constant GFXMMU_S_GFXMMU_LUT278H  \ offset: 0x18B4 : GFXMMU LUT entry 278 high
$580318b8 constant GFXMMU_S_GFXMMU_LUT279L  \ offset: 0x18B8 : GFXMMU LUT entry 279 low
$580318bc constant GFXMMU_S_GFXMMU_LUT279H  \ offset: 0x18BC : GFXMMU LUT entry 279 high
$580318c0 constant GFXMMU_S_GFXMMU_LUT280L  \ offset: 0x18C0 : GFXMMU LUT entry 280 low
$580318c4 constant GFXMMU_S_GFXMMU_LUT280H  \ offset: 0x18C4 : GFXMMU LUT entry 280 high
$580318c8 constant GFXMMU_S_GFXMMU_LUT281L  \ offset: 0x18C8 : GFXMMU LUT entry 281 low
$580318cc constant GFXMMU_S_GFXMMU_LUT281H  \ offset: 0x18CC : GFXMMU LUT entry 281 high
$580318d0 constant GFXMMU_S_GFXMMU_LUT282L  \ offset: 0x18D0 : GFXMMU LUT entry 282 low
$580318d4 constant GFXMMU_S_GFXMMU_LUT282H  \ offset: 0x18D4 : GFXMMU LUT entry 282 high
$580318d8 constant GFXMMU_S_GFXMMU_LUT283L  \ offset: 0x18D8 : GFXMMU LUT entry 283 low
$580318dc constant GFXMMU_S_GFXMMU_LUT283H  \ offset: 0x18DC : GFXMMU LUT entry 283 high
$580318e0 constant GFXMMU_S_GFXMMU_LUT284L  \ offset: 0x18E0 : GFXMMU LUT entry 284 low
$580318e4 constant GFXMMU_S_GFXMMU_LUT284H  \ offset: 0x18E4 : GFXMMU LUT entry 284 high
$580318e8 constant GFXMMU_S_GFXMMU_LUT285L  \ offset: 0x18E8 : GFXMMU LUT entry 285 low
$580318ec constant GFXMMU_S_GFXMMU_LUT285H  \ offset: 0x18EC : GFXMMU LUT entry 285 high
$580318f0 constant GFXMMU_S_GFXMMU_LUT286L  \ offset: 0x18F0 : GFXMMU LUT entry 286 low
$580318f4 constant GFXMMU_S_GFXMMU_LUT286H  \ offset: 0x18F4 : GFXMMU LUT entry 286 high
$580318f8 constant GFXMMU_S_GFXMMU_LUT287L  \ offset: 0x18F8 : GFXMMU LUT entry 287 low
$580318fc constant GFXMMU_S_GFXMMU_LUT287H  \ offset: 0x18FC : GFXMMU LUT entry 287 high
$58031900 constant GFXMMU_S_GFXMMU_LUT288L  \ offset: 0x1900 : GFXMMU LUT entry 288 low
$58031904 constant GFXMMU_S_GFXMMU_LUT288H  \ offset: 0x1904 : GFXMMU LUT entry 288 high
$58031908 constant GFXMMU_S_GFXMMU_LUT289L  \ offset: 0x1908 : GFXMMU LUT entry 289 low
$5803190c constant GFXMMU_S_GFXMMU_LUT289H  \ offset: 0x190C : GFXMMU LUT entry 289 high
$58031910 constant GFXMMU_S_GFXMMU_LUT290L  \ offset: 0x1910 : GFXMMU LUT entry 290 low
$58031914 constant GFXMMU_S_GFXMMU_LUT290H  \ offset: 0x1914 : GFXMMU LUT entry 290 high
$58031918 constant GFXMMU_S_GFXMMU_LUT291L  \ offset: 0x1918 : GFXMMU LUT entry 291 low
$5803191c constant GFXMMU_S_GFXMMU_LUT291H  \ offset: 0x191C : GFXMMU LUT entry 291 high
$58031920 constant GFXMMU_S_GFXMMU_LUT292L  \ offset: 0x1920 : GFXMMU LUT entry 292 low
$58031924 constant GFXMMU_S_GFXMMU_LUT292H  \ offset: 0x1924 : GFXMMU LUT entry 292 high
$58031928 constant GFXMMU_S_GFXMMU_LUT293L  \ offset: 0x1928 : GFXMMU LUT entry 293 low
$5803192c constant GFXMMU_S_GFXMMU_LUT293H  \ offset: 0x192C : GFXMMU LUT entry 293 high
$58031930 constant GFXMMU_S_GFXMMU_LUT294L  \ offset: 0x1930 : GFXMMU LUT entry 294 low
$58031934 constant GFXMMU_S_GFXMMU_LUT294H  \ offset: 0x1934 : GFXMMU LUT entry 294 high
$58031938 constant GFXMMU_S_GFXMMU_LUT295L  \ offset: 0x1938 : GFXMMU LUT entry 295 low
$5803193c constant GFXMMU_S_GFXMMU_LUT295H  \ offset: 0x193C : GFXMMU LUT entry 295 high
$58031940 constant GFXMMU_S_GFXMMU_LUT296L  \ offset: 0x1940 : GFXMMU LUT entry 296 low
$58031944 constant GFXMMU_S_GFXMMU_LUT296H  \ offset: 0x1944 : GFXMMU LUT entry 296 high
$58031948 constant GFXMMU_S_GFXMMU_LUT297L  \ offset: 0x1948 : GFXMMU LUT entry 297 low
$5803194c constant GFXMMU_S_GFXMMU_LUT297H  \ offset: 0x194C : GFXMMU LUT entry 297 high
$58031950 constant GFXMMU_S_GFXMMU_LUT298L  \ offset: 0x1950 : GFXMMU LUT entry 298 low
$58031954 constant GFXMMU_S_GFXMMU_LUT298H  \ offset: 0x1954 : GFXMMU LUT entry 298 high
$58031958 constant GFXMMU_S_GFXMMU_LUT299L  \ offset: 0x1958 : GFXMMU LUT entry 299 low
$5803195c constant GFXMMU_S_GFXMMU_LUT299H  \ offset: 0x195C : GFXMMU LUT entry 299 high
$58031960 constant GFXMMU_S_GFXMMU_LUT300L  \ offset: 0x1960 : GFXMMU LUT entry 300 low
$58031964 constant GFXMMU_S_GFXMMU_LUT300H  \ offset: 0x1964 : GFXMMU LUT entry 300 high
$58031968 constant GFXMMU_S_GFXMMU_LUT301L  \ offset: 0x1968 : GFXMMU LUT entry 301 low
$5803196c constant GFXMMU_S_GFXMMU_LUT301H  \ offset: 0x196C : GFXMMU LUT entry 301 high
$58031970 constant GFXMMU_S_GFXMMU_LUT302L  \ offset: 0x1970 : GFXMMU LUT entry 302 low
$58031974 constant GFXMMU_S_GFXMMU_LUT302H  \ offset: 0x1974 : GFXMMU LUT entry 302 high
$58031978 constant GFXMMU_S_GFXMMU_LUT303L  \ offset: 0x1978 : GFXMMU LUT entry 303 low
$5803197c constant GFXMMU_S_GFXMMU_LUT303H  \ offset: 0x197C : GFXMMU LUT entry 303 high
$58031980 constant GFXMMU_S_GFXMMU_LUT304L  \ offset: 0x1980 : GFXMMU LUT entry 304 low
$58031984 constant GFXMMU_S_GFXMMU_LUT304H  \ offset: 0x1984 : GFXMMU LUT entry 304 high
$58031988 constant GFXMMU_S_GFXMMU_LUT305L  \ offset: 0x1988 : GFXMMU LUT entry 305 low
$5803198c constant GFXMMU_S_GFXMMU_LUT305H  \ offset: 0x198C : GFXMMU LUT entry 305 high
$58031990 constant GFXMMU_S_GFXMMU_LUT306L  \ offset: 0x1990 : GFXMMU LUT entry 306 low
$58031994 constant GFXMMU_S_GFXMMU_LUT306H  \ offset: 0x1994 : GFXMMU LUT entry 306 high
$58031998 constant GFXMMU_S_GFXMMU_LUT307L  \ offset: 0x1998 : GFXMMU LUT entry 307 low
$5803199c constant GFXMMU_S_GFXMMU_LUT307H  \ offset: 0x199C : GFXMMU LUT entry 307 high
$580319a0 constant GFXMMU_S_GFXMMU_LUT308L  \ offset: 0x19A0 : GFXMMU LUT entry 308 low
$580319a4 constant GFXMMU_S_GFXMMU_LUT308H  \ offset: 0x19A4 : GFXMMU LUT entry 308 high
$580319a8 constant GFXMMU_S_GFXMMU_LUT309L  \ offset: 0x19A8 : GFXMMU LUT entry 309 low
$580319ac constant GFXMMU_S_GFXMMU_LUT309H  \ offset: 0x19AC : GFXMMU LUT entry 309 high
$580319b0 constant GFXMMU_S_GFXMMU_LUT310L  \ offset: 0x19B0 : GFXMMU LUT entry 310 low
$580319b4 constant GFXMMU_S_GFXMMU_LUT310H  \ offset: 0x19B4 : GFXMMU LUT entry 310 high
$580319b8 constant GFXMMU_S_GFXMMU_LUT311L  \ offset: 0x19B8 : GFXMMU LUT entry 311 low
$580319bc constant GFXMMU_S_GFXMMU_LUT311H  \ offset: 0x19BC : GFXMMU LUT entry 311 high
$580319c0 constant GFXMMU_S_GFXMMU_LUT312L  \ offset: 0x19C0 : GFXMMU LUT entry 312 low
$580319c4 constant GFXMMU_S_GFXMMU_LUT312H  \ offset: 0x19C4 : GFXMMU LUT entry 312 high
$580319c8 constant GFXMMU_S_GFXMMU_LUT313L  \ offset: 0x19C8 : GFXMMU LUT entry 313 low
$580319cc constant GFXMMU_S_GFXMMU_LUT313H  \ offset: 0x19CC : GFXMMU LUT entry 313 high
$580319d0 constant GFXMMU_S_GFXMMU_LUT314L  \ offset: 0x19D0 : GFXMMU LUT entry 314 low
$580319d4 constant GFXMMU_S_GFXMMU_LUT314H  \ offset: 0x19D4 : GFXMMU LUT entry 314 high
$580319d8 constant GFXMMU_S_GFXMMU_LUT315L  \ offset: 0x19D8 : GFXMMU LUT entry 315 low
$580319dc constant GFXMMU_S_GFXMMU_LUT315H  \ offset: 0x19DC : GFXMMU LUT entry 315 high
$580319e0 constant GFXMMU_S_GFXMMU_LUT316L  \ offset: 0x19E0 : GFXMMU LUT entry 316 low
$580319e4 constant GFXMMU_S_GFXMMU_LUT316H  \ offset: 0x19E4 : GFXMMU LUT entry 316 high
$580319e8 constant GFXMMU_S_GFXMMU_LUT317L  \ offset: 0x19E8 : GFXMMU LUT entry 317 low
$580319ec constant GFXMMU_S_GFXMMU_LUT317H  \ offset: 0x19EC : GFXMMU LUT entry 317 high
$580319f0 constant GFXMMU_S_GFXMMU_LUT318L  \ offset: 0x19F0 : GFXMMU LUT entry 318 low
$580319f4 constant GFXMMU_S_GFXMMU_LUT318H  \ offset: 0x19F4 : GFXMMU LUT entry 318 high
$580319f8 constant GFXMMU_S_GFXMMU_LUT319L  \ offset: 0x19F8 : GFXMMU LUT entry 319 low
$580319fc constant GFXMMU_S_GFXMMU_LUT319H  \ offset: 0x19FC : GFXMMU LUT entry 319 high
$58031a00 constant GFXMMU_S_GFXMMU_LUT320L  \ offset: 0x1A00 : GFXMMU LUT entry 320 low
$58031a04 constant GFXMMU_S_GFXMMU_LUT320H  \ offset: 0x1A04 : GFXMMU LUT entry 320 high
$58031a08 constant GFXMMU_S_GFXMMU_LUT321L  \ offset: 0x1A08 : GFXMMU LUT entry 321 low
$58031a0c constant GFXMMU_S_GFXMMU_LUT321H  \ offset: 0x1A0C : GFXMMU LUT entry 321 high
$58031a10 constant GFXMMU_S_GFXMMU_LUT322L  \ offset: 0x1A10 : GFXMMU LUT entry 322 low
$58031a14 constant GFXMMU_S_GFXMMU_LUT322H  \ offset: 0x1A14 : GFXMMU LUT entry 322 high
$58031a18 constant GFXMMU_S_GFXMMU_LUT323L  \ offset: 0x1A18 : GFXMMU LUT entry 323 low
$58031a1c constant GFXMMU_S_GFXMMU_LUT323H  \ offset: 0x1A1C : GFXMMU LUT entry 323 high
$58031a20 constant GFXMMU_S_GFXMMU_LUT324L  \ offset: 0x1A20 : GFXMMU LUT entry 324 low
$58031a24 constant GFXMMU_S_GFXMMU_LUT324H  \ offset: 0x1A24 : GFXMMU LUT entry 324 high
$58031a28 constant GFXMMU_S_GFXMMU_LUT325L  \ offset: 0x1A28 : GFXMMU LUT entry 325 low
$58031a2c constant GFXMMU_S_GFXMMU_LUT325H  \ offset: 0x1A2C : GFXMMU LUT entry 325 high
$58031a30 constant GFXMMU_S_GFXMMU_LUT326L  \ offset: 0x1A30 : GFXMMU LUT entry 326 low
$58031a34 constant GFXMMU_S_GFXMMU_LUT326H  \ offset: 0x1A34 : GFXMMU LUT entry 326 high
$58031a38 constant GFXMMU_S_GFXMMU_LUT327L  \ offset: 0x1A38 : GFXMMU LUT entry 327 low
$58031a3c constant GFXMMU_S_GFXMMU_LUT327H  \ offset: 0x1A3C : GFXMMU LUT entry 327 high
$58031a40 constant GFXMMU_S_GFXMMU_LUT328L  \ offset: 0x1A40 : GFXMMU LUT entry 328 low
$58031a44 constant GFXMMU_S_GFXMMU_LUT328H  \ offset: 0x1A44 : GFXMMU LUT entry 328 high
$58031a48 constant GFXMMU_S_GFXMMU_LUT329L  \ offset: 0x1A48 : GFXMMU LUT entry 329 low
$58031a4c constant GFXMMU_S_GFXMMU_LUT329H  \ offset: 0x1A4C : GFXMMU LUT entry 329 high
$58031a50 constant GFXMMU_S_GFXMMU_LUT330L  \ offset: 0x1A50 : GFXMMU LUT entry 330 low
$58031a54 constant GFXMMU_S_GFXMMU_LUT330H  \ offset: 0x1A54 : GFXMMU LUT entry 330 high
$58031a58 constant GFXMMU_S_GFXMMU_LUT331L  \ offset: 0x1A58 : GFXMMU LUT entry 331 low
$58031a5c constant GFXMMU_S_GFXMMU_LUT331H  \ offset: 0x1A5C : GFXMMU LUT entry 331 high
$58031a60 constant GFXMMU_S_GFXMMU_LUT332L  \ offset: 0x1A60 : GFXMMU LUT entry 332 low
$58031a64 constant GFXMMU_S_GFXMMU_LUT332H  \ offset: 0x1A64 : GFXMMU LUT entry 332 high
$58031a68 constant GFXMMU_S_GFXMMU_LUT333L  \ offset: 0x1A68 : GFXMMU LUT entry 333 low
$58031a6c constant GFXMMU_S_GFXMMU_LUT333H  \ offset: 0x1A6C : GFXMMU LUT entry 333 high
$58031a70 constant GFXMMU_S_GFXMMU_LUT334L  \ offset: 0x1A70 : GFXMMU LUT entry 334 low
$58031a74 constant GFXMMU_S_GFXMMU_LUT334H  \ offset: 0x1A74 : GFXMMU LUT entry 334 high
$58031a78 constant GFXMMU_S_GFXMMU_LUT335L  \ offset: 0x1A78 : GFXMMU LUT entry 335 low
$58031a7c constant GFXMMU_S_GFXMMU_LUT335H  \ offset: 0x1A7C : GFXMMU LUT entry 335 high
$58031a80 constant GFXMMU_S_GFXMMU_LUT336L  \ offset: 0x1A80 : GFXMMU LUT entry 336 low
$58031a84 constant GFXMMU_S_GFXMMU_LUT336H  \ offset: 0x1A84 : GFXMMU LUT entry 336 high
$58031a88 constant GFXMMU_S_GFXMMU_LUT337L  \ offset: 0x1A88 : GFXMMU LUT entry 337 low
$58031a8c constant GFXMMU_S_GFXMMU_LUT337H  \ offset: 0x1A8C : GFXMMU LUT entry 337 high
$58031a90 constant GFXMMU_S_GFXMMU_LUT338L  \ offset: 0x1A90 : GFXMMU LUT entry 338 low
$58031a94 constant GFXMMU_S_GFXMMU_LUT338H  \ offset: 0x1A94 : GFXMMU LUT entry 338 high
$58031a98 constant GFXMMU_S_GFXMMU_LUT339L  \ offset: 0x1A98 : GFXMMU LUT entry 339 low
$58031a9c constant GFXMMU_S_GFXMMU_LUT339H  \ offset: 0x1A9C : GFXMMU LUT entry 339 high
$58031aa0 constant GFXMMU_S_GFXMMU_LUT340L  \ offset: 0x1AA0 : GFXMMU LUT entry 340 low
$58031aa4 constant GFXMMU_S_GFXMMU_LUT340H  \ offset: 0x1AA4 : GFXMMU LUT entry 340 high
$58031aa8 constant GFXMMU_S_GFXMMU_LUT341L  \ offset: 0x1AA8 : GFXMMU LUT entry 341 low
$58031aac constant GFXMMU_S_GFXMMU_LUT341H  \ offset: 0x1AAC : GFXMMU LUT entry 341 high
$58031ab0 constant GFXMMU_S_GFXMMU_LUT342L  \ offset: 0x1AB0 : GFXMMU LUT entry 342 low
$58031ab4 constant GFXMMU_S_GFXMMU_LUT342H  \ offset: 0x1AB4 : GFXMMU LUT entry 342 high
$58031ab8 constant GFXMMU_S_GFXMMU_LUT343L  \ offset: 0x1AB8 : GFXMMU LUT entry 343 low
$58031abc constant GFXMMU_S_GFXMMU_LUT343H  \ offset: 0x1ABC : GFXMMU LUT entry 343 high
$58031ac0 constant GFXMMU_S_GFXMMU_LUT344L  \ offset: 0x1AC0 : GFXMMU LUT entry 344 low
$58031ac4 constant GFXMMU_S_GFXMMU_LUT344H  \ offset: 0x1AC4 : GFXMMU LUT entry 344 high
$58031ac8 constant GFXMMU_S_GFXMMU_LUT345L  \ offset: 0x1AC8 : GFXMMU LUT entry 345 low
$58031acc constant GFXMMU_S_GFXMMU_LUT345H  \ offset: 0x1ACC : GFXMMU LUT entry 345 high
$58031ad0 constant GFXMMU_S_GFXMMU_LUT346L  \ offset: 0x1AD0 : GFXMMU LUT entry 346 low
$58031ad4 constant GFXMMU_S_GFXMMU_LUT346H  \ offset: 0x1AD4 : GFXMMU LUT entry 346 high
$58031ad8 constant GFXMMU_S_GFXMMU_LUT347L  \ offset: 0x1AD8 : GFXMMU LUT entry 347 low
$58031adc constant GFXMMU_S_GFXMMU_LUT347H  \ offset: 0x1ADC : GFXMMU LUT entry 347 high
$58031ae0 constant GFXMMU_S_GFXMMU_LUT348L  \ offset: 0x1AE0 : GFXMMU LUT entry 348 low
$58031ae4 constant GFXMMU_S_GFXMMU_LUT348H  \ offset: 0x1AE4 : GFXMMU LUT entry 348 high
$58031ae8 constant GFXMMU_S_GFXMMU_LUT349L  \ offset: 0x1AE8 : GFXMMU LUT entry 349 low
$58031aec constant GFXMMU_S_GFXMMU_LUT349H  \ offset: 0x1AEC : GFXMMU LUT entry 349 high
$58031af0 constant GFXMMU_S_GFXMMU_LUT350L  \ offset: 0x1AF0 : GFXMMU LUT entry 350 low
$58031af4 constant GFXMMU_S_GFXMMU_LUT350H  \ offset: 0x1AF4 : GFXMMU LUT entry 350 high
$58031af8 constant GFXMMU_S_GFXMMU_LUT351L  \ offset: 0x1AF8 : GFXMMU LUT entry 351 low
$58031afc constant GFXMMU_S_GFXMMU_LUT351H  \ offset: 0x1AFC : GFXMMU LUT entry 351 high
$58031b00 constant GFXMMU_S_GFXMMU_LUT352L  \ offset: 0x1B00 : GFXMMU LUT entry 352 low
$58031b04 constant GFXMMU_S_GFXMMU_LUT352H  \ offset: 0x1B04 : GFXMMU LUT entry 352 high
$58031b08 constant GFXMMU_S_GFXMMU_LUT353L  \ offset: 0x1B08 : GFXMMU LUT entry 353 low
$58031b0c constant GFXMMU_S_GFXMMU_LUT353H  \ offset: 0x1B0C : GFXMMU LUT entry 353 high
$58031b10 constant GFXMMU_S_GFXMMU_LUT354L  \ offset: 0x1B10 : GFXMMU LUT entry 354 low
$58031b14 constant GFXMMU_S_GFXMMU_LUT354H  \ offset: 0x1B14 : GFXMMU LUT entry 354 high
$58031b18 constant GFXMMU_S_GFXMMU_LUT355L  \ offset: 0x1B18 : GFXMMU LUT entry 355 low
$58031b1c constant GFXMMU_S_GFXMMU_LUT355H  \ offset: 0x1B1C : GFXMMU LUT entry 355 high
$58031b20 constant GFXMMU_S_GFXMMU_LUT356L  \ offset: 0x1B20 : GFXMMU LUT entry 356 low
$58031b24 constant GFXMMU_S_GFXMMU_LUT356H  \ offset: 0x1B24 : GFXMMU LUT entry 356 high
$58031b28 constant GFXMMU_S_GFXMMU_LUT357L  \ offset: 0x1B28 : GFXMMU LUT entry 357 low
$58031b2c constant GFXMMU_S_GFXMMU_LUT357H  \ offset: 0x1B2C : GFXMMU LUT entry 357 high
$58031b30 constant GFXMMU_S_GFXMMU_LUT358L  \ offset: 0x1B30 : GFXMMU LUT entry 358 low
$58031b34 constant GFXMMU_S_GFXMMU_LUT358H  \ offset: 0x1B34 : GFXMMU LUT entry 358 high
$58031b38 constant GFXMMU_S_GFXMMU_LUT359L  \ offset: 0x1B38 : GFXMMU LUT entry 359 low
$58031b3c constant GFXMMU_S_GFXMMU_LUT359H  \ offset: 0x1B3C : GFXMMU LUT entry 359 high
$58031b40 constant GFXMMU_S_GFXMMU_LUT360L  \ offset: 0x1B40 : GFXMMU LUT entry 360 low
$58031b44 constant GFXMMU_S_GFXMMU_LUT360H  \ offset: 0x1B44 : GFXMMU LUT entry 360 high
$58031b48 constant GFXMMU_S_GFXMMU_LUT361L  \ offset: 0x1B48 : GFXMMU LUT entry 361 low
$58031b4c constant GFXMMU_S_GFXMMU_LUT361H  \ offset: 0x1B4C : GFXMMU LUT entry 361 high
$58031b50 constant GFXMMU_S_GFXMMU_LUT362L  \ offset: 0x1B50 : GFXMMU LUT entry 362 low
$58031b54 constant GFXMMU_S_GFXMMU_LUT362H  \ offset: 0x1B54 : GFXMMU LUT entry 362 high
$58031b58 constant GFXMMU_S_GFXMMU_LUT363L  \ offset: 0x1B58 : GFXMMU LUT entry 363 low
$58031b5c constant GFXMMU_S_GFXMMU_LUT363H  \ offset: 0x1B5C : GFXMMU LUT entry 363 high
$58031b60 constant GFXMMU_S_GFXMMU_LUT364L  \ offset: 0x1B60 : GFXMMU LUT entry 364 low
$58031b64 constant GFXMMU_S_GFXMMU_LUT364H  \ offset: 0x1B64 : GFXMMU LUT entry 364 high
$58031b68 constant GFXMMU_S_GFXMMU_LUT365L  \ offset: 0x1B68 : GFXMMU LUT entry 365 low
$58031b6c constant GFXMMU_S_GFXMMU_LUT365H  \ offset: 0x1B6C : GFXMMU LUT entry 365 high
$58031b70 constant GFXMMU_S_GFXMMU_LUT366L  \ offset: 0x1B70 : GFXMMU LUT entry 366 low
$58031b74 constant GFXMMU_S_GFXMMU_LUT366H  \ offset: 0x1B74 : GFXMMU LUT entry 366 high
$58031b78 constant GFXMMU_S_GFXMMU_LUT367L  \ offset: 0x1B78 : GFXMMU LUT entry 367 low
$58031b7c constant GFXMMU_S_GFXMMU_LUT367H  \ offset: 0x1B7C : GFXMMU LUT entry 367 high
$58031b80 constant GFXMMU_S_GFXMMU_LUT368L  \ offset: 0x1B80 : GFXMMU LUT entry 368 low
$58031b84 constant GFXMMU_S_GFXMMU_LUT368H  \ offset: 0x1B84 : GFXMMU LUT entry 368 high
$58031b88 constant GFXMMU_S_GFXMMU_LUT369L  \ offset: 0x1B88 : GFXMMU LUT entry 369 low
$58031b8c constant GFXMMU_S_GFXMMU_LUT369H  \ offset: 0x1B8C : GFXMMU LUT entry 369 high
$58031b90 constant GFXMMU_S_GFXMMU_LUT370L  \ offset: 0x1B90 : GFXMMU LUT entry 370 low
$58031b94 constant GFXMMU_S_GFXMMU_LUT370H  \ offset: 0x1B94 : GFXMMU LUT entry 370 high
$58031b98 constant GFXMMU_S_GFXMMU_LUT371L  \ offset: 0x1B98 : GFXMMU LUT entry 371 low
$58031b9c constant GFXMMU_S_GFXMMU_LUT371H  \ offset: 0x1B9C : GFXMMU LUT entry 371 high
$58031ba0 constant GFXMMU_S_GFXMMU_LUT372L  \ offset: 0x1BA0 : GFXMMU LUT entry 372 low
$58031ba4 constant GFXMMU_S_GFXMMU_LUT372H  \ offset: 0x1BA4 : GFXMMU LUT entry 372 high
$58031ba8 constant GFXMMU_S_GFXMMU_LUT373L  \ offset: 0x1BA8 : GFXMMU LUT entry 373 low
$58031bac constant GFXMMU_S_GFXMMU_LUT373H  \ offset: 0x1BAC : GFXMMU LUT entry 373 high
$58031bb0 constant GFXMMU_S_GFXMMU_LUT374L  \ offset: 0x1BB0 : GFXMMU LUT entry 374 low
$58031bb4 constant GFXMMU_S_GFXMMU_LUT374H  \ offset: 0x1BB4 : GFXMMU LUT entry 374 high
$58031bb8 constant GFXMMU_S_GFXMMU_LUT375L  \ offset: 0x1BB8 : GFXMMU LUT entry 375 low
$58031bbc constant GFXMMU_S_GFXMMU_LUT375H  \ offset: 0x1BBC : GFXMMU LUT entry 375 high
$58031bc0 constant GFXMMU_S_GFXMMU_LUT376L  \ offset: 0x1BC0 : GFXMMU LUT entry 376 low
$58031bc4 constant GFXMMU_S_GFXMMU_LUT376H  \ offset: 0x1BC4 : GFXMMU LUT entry 376 high
$58031bc8 constant GFXMMU_S_GFXMMU_LUT377L  \ offset: 0x1BC8 : GFXMMU LUT entry 377 low
$58031bcc constant GFXMMU_S_GFXMMU_LUT377H  \ offset: 0x1BCC : GFXMMU LUT entry 377 high
$58031bd0 constant GFXMMU_S_GFXMMU_LUT378L  \ offset: 0x1BD0 : GFXMMU LUT entry 378 low
$58031bd4 constant GFXMMU_S_GFXMMU_LUT378H  \ offset: 0x1BD4 : GFXMMU LUT entry 378 high
$58031bd8 constant GFXMMU_S_GFXMMU_LUT379L  \ offset: 0x1BD8 : GFXMMU LUT entry 379 low
$58031bdc constant GFXMMU_S_GFXMMU_LUT379H  \ offset: 0x1BDC : GFXMMU LUT entry 379 high
$58031be0 constant GFXMMU_S_GFXMMU_LUT380L  \ offset: 0x1BE0 : GFXMMU LUT entry 380 low
$58031be4 constant GFXMMU_S_GFXMMU_LUT380H  \ offset: 0x1BE4 : GFXMMU LUT entry 380 high
$58031be8 constant GFXMMU_S_GFXMMU_LUT381L  \ offset: 0x1BE8 : GFXMMU LUT entry 381 low
$58031bec constant GFXMMU_S_GFXMMU_LUT381H  \ offset: 0x1BEC : GFXMMU LUT entry 381 high
$58031bf0 constant GFXMMU_S_GFXMMU_LUT382L  \ offset: 0x1BF0 : GFXMMU LUT entry 382 low
$58031bf4 constant GFXMMU_S_GFXMMU_LUT382H  \ offset: 0x1BF4 : GFXMMU LUT entry 382 high
$58031bf8 constant GFXMMU_S_GFXMMU_LUT383L  \ offset: 0x1BF8 : GFXMMU LUT entry 383 low
$58031bfc constant GFXMMU_S_GFXMMU_LUT383H  \ offset: 0x1BFC : GFXMMU LUT entry 383 high
$58031c00 constant GFXMMU_S_GFXMMU_LUT384L  \ offset: 0x1C00 : GFXMMU LUT entry 384 low
$58031c04 constant GFXMMU_S_GFXMMU_LUT384H  \ offset: 0x1C04 : GFXMMU LUT entry 384 high
$58031c08 constant GFXMMU_S_GFXMMU_LUT385L  \ offset: 0x1C08 : GFXMMU LUT entry 385 low
$58031c0c constant GFXMMU_S_GFXMMU_LUT385H  \ offset: 0x1C0C : GFXMMU LUT entry 385 high
$58031c10 constant GFXMMU_S_GFXMMU_LUT386L  \ offset: 0x1C10 : GFXMMU LUT entry 386 low
$58031c14 constant GFXMMU_S_GFXMMU_LUT386H  \ offset: 0x1C14 : GFXMMU LUT entry 386 high
$58031c18 constant GFXMMU_S_GFXMMU_LUT387L  \ offset: 0x1C18 : GFXMMU LUT entry 387 low
$58031c1c constant GFXMMU_S_GFXMMU_LUT387H  \ offset: 0x1C1C : GFXMMU LUT entry 387 high
$58031c20 constant GFXMMU_S_GFXMMU_LUT388L  \ offset: 0x1C20 : GFXMMU LUT entry 388 low
$58031c24 constant GFXMMU_S_GFXMMU_LUT388H  \ offset: 0x1C24 : GFXMMU LUT entry 388 high
$58031c28 constant GFXMMU_S_GFXMMU_LUT389L  \ offset: 0x1C28 : GFXMMU LUT entry 389 low
$58031c2c constant GFXMMU_S_GFXMMU_LUT389H  \ offset: 0x1C2C : GFXMMU LUT entry 389 high
$58031c30 constant GFXMMU_S_GFXMMU_LUT390L  \ offset: 0x1C30 : GFXMMU LUT entry 390 low
$58031c34 constant GFXMMU_S_GFXMMU_LUT390H  \ offset: 0x1C34 : GFXMMU LUT entry 390 high
$58031c38 constant GFXMMU_S_GFXMMU_LUT391L  \ offset: 0x1C38 : GFXMMU LUT entry 391 low
$58031c3c constant GFXMMU_S_GFXMMU_LUT391H  \ offset: 0x1C3C : GFXMMU LUT entry 391 high
$58031c40 constant GFXMMU_S_GFXMMU_LUT392L  \ offset: 0x1C40 : GFXMMU LUT entry 392 low
$58031c44 constant GFXMMU_S_GFXMMU_LUT392H  \ offset: 0x1C44 : GFXMMU LUT entry 392 high
$58031c48 constant GFXMMU_S_GFXMMU_LUT393L  \ offset: 0x1C48 : GFXMMU LUT entry 393 low
$58031c4c constant GFXMMU_S_GFXMMU_LUT393H  \ offset: 0x1C4C : GFXMMU LUT entry 393 high
$58031c50 constant GFXMMU_S_GFXMMU_LUT394L  \ offset: 0x1C50 : GFXMMU LUT entry 394 low
$58031c54 constant GFXMMU_S_GFXMMU_LUT394H  \ offset: 0x1C54 : GFXMMU LUT entry 394 high
$58031c58 constant GFXMMU_S_GFXMMU_LUT395L  \ offset: 0x1C58 : GFXMMU LUT entry 395 low
$58031c5c constant GFXMMU_S_GFXMMU_LUT395H  \ offset: 0x1C5C : GFXMMU LUT entry 395 high
$58031c60 constant GFXMMU_S_GFXMMU_LUT396L  \ offset: 0x1C60 : GFXMMU LUT entry 396 low
$58031c64 constant GFXMMU_S_GFXMMU_LUT396H  \ offset: 0x1C64 : GFXMMU LUT entry 396 high
$58031c68 constant GFXMMU_S_GFXMMU_LUT397L  \ offset: 0x1C68 : GFXMMU LUT entry 397 low
$58031c6c constant GFXMMU_S_GFXMMU_LUT397H  \ offset: 0x1C6C : GFXMMU LUT entry 397 high
$58031c70 constant GFXMMU_S_GFXMMU_LUT398L  \ offset: 0x1C70 : GFXMMU LUT entry 398 low
$58031c74 constant GFXMMU_S_GFXMMU_LUT398H  \ offset: 0x1C74 : GFXMMU LUT entry 398 high
$58031c78 constant GFXMMU_S_GFXMMU_LUT399L  \ offset: 0x1C78 : GFXMMU LUT entry 399 low
$58031c7c constant GFXMMU_S_GFXMMU_LUT399H  \ offset: 0x1C7C : GFXMMU LUT entry 399 high
$58031c80 constant GFXMMU_S_GFXMMU_LUT400L  \ offset: 0x1C80 : GFXMMU LUT entry 400 low
$58031c84 constant GFXMMU_S_GFXMMU_LUT400H  \ offset: 0x1C84 : GFXMMU LUT entry 400 high
$58031c88 constant GFXMMU_S_GFXMMU_LUT401L  \ offset: 0x1C88 : GFXMMU LUT entry 401 low
$58031c8c constant GFXMMU_S_GFXMMU_LUT401H  \ offset: 0x1C8C : GFXMMU LUT entry 401 high
$58031c90 constant GFXMMU_S_GFXMMU_LUT402L  \ offset: 0x1C90 : GFXMMU LUT entry 402 low
$58031c94 constant GFXMMU_S_GFXMMU_LUT402H  \ offset: 0x1C94 : GFXMMU LUT entry 402 high
$58031c98 constant GFXMMU_S_GFXMMU_LUT403L  \ offset: 0x1C98 : GFXMMU LUT entry 403 low
$58031c9c constant GFXMMU_S_GFXMMU_LUT403H  \ offset: 0x1C9C : GFXMMU LUT entry 403 high
$58031ca0 constant GFXMMU_S_GFXMMU_LUT404L  \ offset: 0x1CA0 : GFXMMU LUT entry 404 low
$58031ca4 constant GFXMMU_S_GFXMMU_LUT404H  \ offset: 0x1CA4 : GFXMMU LUT entry 404 high
$58031ca8 constant GFXMMU_S_GFXMMU_LUT405L  \ offset: 0x1CA8 : GFXMMU LUT entry 405 low
$58031cac constant GFXMMU_S_GFXMMU_LUT405H  \ offset: 0x1CAC : GFXMMU LUT entry 405 high
$58031cb0 constant GFXMMU_S_GFXMMU_LUT406L  \ offset: 0x1CB0 : GFXMMU LUT entry 406 low
$58031cb4 constant GFXMMU_S_GFXMMU_LUT406H  \ offset: 0x1CB4 : GFXMMU LUT entry 406 high
$58031cb8 constant GFXMMU_S_GFXMMU_LUT407L  \ offset: 0x1CB8 : GFXMMU LUT entry 407 low
$58031cbc constant GFXMMU_S_GFXMMU_LUT407H  \ offset: 0x1CBC : GFXMMU LUT entry 407 high
$58031cc0 constant GFXMMU_S_GFXMMU_LUT408L  \ offset: 0x1CC0 : GFXMMU LUT entry 408 low
$58031cc4 constant GFXMMU_S_GFXMMU_LUT408H  \ offset: 0x1CC4 : GFXMMU LUT entry 408 high
$58031cc8 constant GFXMMU_S_GFXMMU_LUT409L  \ offset: 0x1CC8 : GFXMMU LUT entry 409 low
$58031ccc constant GFXMMU_S_GFXMMU_LUT409H  \ offset: 0x1CCC : GFXMMU LUT entry 409 high
$58031cd0 constant GFXMMU_S_GFXMMU_LUT410L  \ offset: 0x1CD0 : GFXMMU LUT entry 410 low
$58031cd4 constant GFXMMU_S_GFXMMU_LUT410H  \ offset: 0x1CD4 : GFXMMU LUT entry 410 high
$58031cd8 constant GFXMMU_S_GFXMMU_LUT411L  \ offset: 0x1CD8 : GFXMMU LUT entry 411 low
$58031cdc constant GFXMMU_S_GFXMMU_LUT411H  \ offset: 0x1CDC : GFXMMU LUT entry 411 high
$58031ce0 constant GFXMMU_S_GFXMMU_LUT412L  \ offset: 0x1CE0 : GFXMMU LUT entry 412 low
$58031ce4 constant GFXMMU_S_GFXMMU_LUT412H  \ offset: 0x1CE4 : GFXMMU LUT entry 412 high
$58031ce8 constant GFXMMU_S_GFXMMU_LUT413L  \ offset: 0x1CE8 : GFXMMU LUT entry 413 low
$58031cec constant GFXMMU_S_GFXMMU_LUT413H  \ offset: 0x1CEC : GFXMMU LUT entry 413 high
$58031cf0 constant GFXMMU_S_GFXMMU_LUT414L  \ offset: 0x1CF0 : GFXMMU LUT entry 414 low
$58031cf4 constant GFXMMU_S_GFXMMU_LUT414H  \ offset: 0x1CF4 : GFXMMU LUT entry 414 high
$58031cf8 constant GFXMMU_S_GFXMMU_LUT415L  \ offset: 0x1CF8 : GFXMMU LUT entry 415 low
$58031cfc constant GFXMMU_S_GFXMMU_LUT415H  \ offset: 0x1CFC : GFXMMU LUT entry 415 high
$58031d00 constant GFXMMU_S_GFXMMU_LUT416L  \ offset: 0x1D00 : GFXMMU LUT entry 416 low
$58031d04 constant GFXMMU_S_GFXMMU_LUT416H  \ offset: 0x1D04 : GFXMMU LUT entry 416 high
$58031d08 constant GFXMMU_S_GFXMMU_LUT417L  \ offset: 0x1D08 : GFXMMU LUT entry 417 low
$58031d0c constant GFXMMU_S_GFXMMU_LUT417H  \ offset: 0x1D0C : GFXMMU LUT entry 417 high
$58031d10 constant GFXMMU_S_GFXMMU_LUT418L  \ offset: 0x1D10 : GFXMMU LUT entry 418 low
$58031d14 constant GFXMMU_S_GFXMMU_LUT418H  \ offset: 0x1D14 : GFXMMU LUT entry 418 high
$58031d18 constant GFXMMU_S_GFXMMU_LUT419L  \ offset: 0x1D18 : GFXMMU LUT entry 419 low
$58031d1c constant GFXMMU_S_GFXMMU_LUT419H  \ offset: 0x1D1C : GFXMMU LUT entry 419 high
$58031d20 constant GFXMMU_S_GFXMMU_LUT420L  \ offset: 0x1D20 : GFXMMU LUT entry 420 low
$58031d24 constant GFXMMU_S_GFXMMU_LUT420H  \ offset: 0x1D24 : GFXMMU LUT entry 420 high
$58031d28 constant GFXMMU_S_GFXMMU_LUT421L  \ offset: 0x1D28 : GFXMMU LUT entry 421 low
$58031d2c constant GFXMMU_S_GFXMMU_LUT421H  \ offset: 0x1D2C : GFXMMU LUT entry 421 high
$58031d30 constant GFXMMU_S_GFXMMU_LUT422L  \ offset: 0x1D30 : GFXMMU LUT entry 422 low
$58031d34 constant GFXMMU_S_GFXMMU_LUT422H  \ offset: 0x1D34 : GFXMMU LUT entry 422 high
$58031d38 constant GFXMMU_S_GFXMMU_LUT423L  \ offset: 0x1D38 : GFXMMU LUT entry 423 low
$58031d3c constant GFXMMU_S_GFXMMU_LUT423H  \ offset: 0x1D3C : GFXMMU LUT entry 423 high
$58031d40 constant GFXMMU_S_GFXMMU_LUT424L  \ offset: 0x1D40 : GFXMMU LUT entry 424 low
$58031d44 constant GFXMMU_S_GFXMMU_LUT424H  \ offset: 0x1D44 : GFXMMU LUT entry 424 high
$58031d48 constant GFXMMU_S_GFXMMU_LUT425L  \ offset: 0x1D48 : GFXMMU LUT entry 425 low
$58031d4c constant GFXMMU_S_GFXMMU_LUT425H  \ offset: 0x1D4C : GFXMMU LUT entry 425 high
$58031d50 constant GFXMMU_S_GFXMMU_LUT426L  \ offset: 0x1D50 : GFXMMU LUT entry 426 low
$58031d54 constant GFXMMU_S_GFXMMU_LUT426H  \ offset: 0x1D54 : GFXMMU LUT entry 426 high
$58031d58 constant GFXMMU_S_GFXMMU_LUT427L  \ offset: 0x1D58 : GFXMMU LUT entry 427 low
$58031d5c constant GFXMMU_S_GFXMMU_LUT427H  \ offset: 0x1D5C : GFXMMU LUT entry 427 high
$58031d60 constant GFXMMU_S_GFXMMU_LUT428L  \ offset: 0x1D60 : GFXMMU LUT entry 428 low
$58031d64 constant GFXMMU_S_GFXMMU_LUT428H  \ offset: 0x1D64 : GFXMMU LUT entry 428 high
$58031d68 constant GFXMMU_S_GFXMMU_LUT429L  \ offset: 0x1D68 : GFXMMU LUT entry 429 low
$58031d6c constant GFXMMU_S_GFXMMU_LUT429H  \ offset: 0x1D6C : GFXMMU LUT entry 429 high
$58031d70 constant GFXMMU_S_GFXMMU_LUT430L  \ offset: 0x1D70 : GFXMMU LUT entry 430 low
$58031d74 constant GFXMMU_S_GFXMMU_LUT430H  \ offset: 0x1D74 : GFXMMU LUT entry 430 high
$58031d78 constant GFXMMU_S_GFXMMU_LUT431L  \ offset: 0x1D78 : GFXMMU LUT entry 431 low
$58031d7c constant GFXMMU_S_GFXMMU_LUT431H  \ offset: 0x1D7C : GFXMMU LUT entry 431 high
$58031d80 constant GFXMMU_S_GFXMMU_LUT432L  \ offset: 0x1D80 : GFXMMU LUT entry 432 low
$58031d84 constant GFXMMU_S_GFXMMU_LUT432H  \ offset: 0x1D84 : GFXMMU LUT entry 432 high
$58031d88 constant GFXMMU_S_GFXMMU_LUT433L  \ offset: 0x1D88 : GFXMMU LUT entry 433 low
$58031d8c constant GFXMMU_S_GFXMMU_LUT433H  \ offset: 0x1D8C : GFXMMU LUT entry 433 high
$58031d90 constant GFXMMU_S_GFXMMU_LUT434L  \ offset: 0x1D90 : GFXMMU LUT entry 434 low
$58031d94 constant GFXMMU_S_GFXMMU_LUT434H  \ offset: 0x1D94 : GFXMMU LUT entry 434 high
$58031d98 constant GFXMMU_S_GFXMMU_LUT435L  \ offset: 0x1D98 : GFXMMU LUT entry 435 low
$58031d9c constant GFXMMU_S_GFXMMU_LUT435H  \ offset: 0x1D9C : GFXMMU LUT entry 435 high
$58031da0 constant GFXMMU_S_GFXMMU_LUT436L  \ offset: 0x1DA0 : GFXMMU LUT entry 436 low
$58031da4 constant GFXMMU_S_GFXMMU_LUT436H  \ offset: 0x1DA4 : GFXMMU LUT entry 436 high
$58031da8 constant GFXMMU_S_GFXMMU_LUT437L  \ offset: 0x1DA8 : GFXMMU LUT entry 437 low
$58031dac constant GFXMMU_S_GFXMMU_LUT437H  \ offset: 0x1DAC : GFXMMU LUT entry 437 high
$58031db0 constant GFXMMU_S_GFXMMU_LUT438L  \ offset: 0x1DB0 : GFXMMU LUT entry 438 low
$58031db4 constant GFXMMU_S_GFXMMU_LUT438H  \ offset: 0x1DB4 : GFXMMU LUT entry 438 high
$58031db8 constant GFXMMU_S_GFXMMU_LUT439L  \ offset: 0x1DB8 : GFXMMU LUT entry 439 low
$58031dbc constant GFXMMU_S_GFXMMU_LUT439H  \ offset: 0x1DBC : GFXMMU LUT entry 439 high
$58031dc0 constant GFXMMU_S_GFXMMU_LUT440L  \ offset: 0x1DC0 : GFXMMU LUT entry 440 low
$58031dc4 constant GFXMMU_S_GFXMMU_LUT440H  \ offset: 0x1DC4 : GFXMMU LUT entry 440 high
$58031dc8 constant GFXMMU_S_GFXMMU_LUT441L  \ offset: 0x1DC8 : GFXMMU LUT entry 441 low
$58031dcc constant GFXMMU_S_GFXMMU_LUT441H  \ offset: 0x1DCC : GFXMMU LUT entry 441 high
$58031dd0 constant GFXMMU_S_GFXMMU_LUT442L  \ offset: 0x1DD0 : GFXMMU LUT entry 442 low
$58031dd4 constant GFXMMU_S_GFXMMU_LUT442H  \ offset: 0x1DD4 : GFXMMU LUT entry 442 high
$58031dd8 constant GFXMMU_S_GFXMMU_LUT443L  \ offset: 0x1DD8 : GFXMMU LUT entry 443 low
$58031ddc constant GFXMMU_S_GFXMMU_LUT443H  \ offset: 0x1DDC : GFXMMU LUT entry 443 high
$58031de0 constant GFXMMU_S_GFXMMU_LUT444L  \ offset: 0x1DE0 : GFXMMU LUT entry 444 low
$58031de4 constant GFXMMU_S_GFXMMU_LUT444H  \ offset: 0x1DE4 : GFXMMU LUT entry 444 high
$58031de8 constant GFXMMU_S_GFXMMU_LUT445L  \ offset: 0x1DE8 : GFXMMU LUT entry 445 low
$58031dec constant GFXMMU_S_GFXMMU_LUT445H  \ offset: 0x1DEC : GFXMMU LUT entry 445 high
$58031df0 constant GFXMMU_S_GFXMMU_LUT446L  \ offset: 0x1DF0 : GFXMMU LUT entry 446 low
$58031df4 constant GFXMMU_S_GFXMMU_LUT446H  \ offset: 0x1DF4 : GFXMMU LUT entry 446 high
$58031df8 constant GFXMMU_S_GFXMMU_LUT447L  \ offset: 0x1DF8 : GFXMMU LUT entry 447 low
$58031dfc constant GFXMMU_S_GFXMMU_LUT447H  \ offset: 0x1DFC : GFXMMU LUT entry 447 high
$58031e00 constant GFXMMU_S_GFXMMU_LUT448L  \ offset: 0x1E00 : GFXMMU LUT entry 448 low
$58031e04 constant GFXMMU_S_GFXMMU_LUT448H  \ offset: 0x1E04 : GFXMMU LUT entry 448 high
$58031e08 constant GFXMMU_S_GFXMMU_LUT449L  \ offset: 0x1E08 : GFXMMU LUT entry 449 low
$58031e0c constant GFXMMU_S_GFXMMU_LUT449H  \ offset: 0x1E0C : GFXMMU LUT entry 449 high
$58031e10 constant GFXMMU_S_GFXMMU_LUT450L  \ offset: 0x1E10 : GFXMMU LUT entry 450 low
$58031e14 constant GFXMMU_S_GFXMMU_LUT450H  \ offset: 0x1E14 : GFXMMU LUT entry 450 high
$58031e18 constant GFXMMU_S_GFXMMU_LUT451L  \ offset: 0x1E18 : GFXMMU LUT entry 451 low
$58031e1c constant GFXMMU_S_GFXMMU_LUT451H  \ offset: 0x1E1C : GFXMMU LUT entry 451 high
$58031e20 constant GFXMMU_S_GFXMMU_LUT452L  \ offset: 0x1E20 : GFXMMU LUT entry 452 low
$58031e24 constant GFXMMU_S_GFXMMU_LUT452H  \ offset: 0x1E24 : GFXMMU LUT entry 452 high
$58031e28 constant GFXMMU_S_GFXMMU_LUT453L  \ offset: 0x1E28 : GFXMMU LUT entry 453 low
$58031e2c constant GFXMMU_S_GFXMMU_LUT453H  \ offset: 0x1E2C : GFXMMU LUT entry 453 high
$58031e30 constant GFXMMU_S_GFXMMU_LUT454L  \ offset: 0x1E30 : GFXMMU LUT entry 454 low
$58031e34 constant GFXMMU_S_GFXMMU_LUT454H  \ offset: 0x1E34 : GFXMMU LUT entry 454 high
$58031e38 constant GFXMMU_S_GFXMMU_LUT455L  \ offset: 0x1E38 : GFXMMU LUT entry 455 low
$58031e3c constant GFXMMU_S_GFXMMU_LUT455H  \ offset: 0x1E3C : GFXMMU LUT entry 455 high
$58031e40 constant GFXMMU_S_GFXMMU_LUT456L  \ offset: 0x1E40 : GFXMMU LUT entry 456 low
$58031e44 constant GFXMMU_S_GFXMMU_LUT456H  \ offset: 0x1E44 : GFXMMU LUT entry 456 high
$58031e48 constant GFXMMU_S_GFXMMU_LUT457L  \ offset: 0x1E48 : GFXMMU LUT entry 457 low
$58031e4c constant GFXMMU_S_GFXMMU_LUT457H  \ offset: 0x1E4C : GFXMMU LUT entry 457 high
$58031e50 constant GFXMMU_S_GFXMMU_LUT458L  \ offset: 0x1E50 : GFXMMU LUT entry 458 low
$58031e54 constant GFXMMU_S_GFXMMU_LUT458H  \ offset: 0x1E54 : GFXMMU LUT entry 458 high
$58031e58 constant GFXMMU_S_GFXMMU_LUT459L  \ offset: 0x1E58 : GFXMMU LUT entry 459 low
$58031e5c constant GFXMMU_S_GFXMMU_LUT459H  \ offset: 0x1E5C : GFXMMU LUT entry 459 high
$58031e60 constant GFXMMU_S_GFXMMU_LUT460L  \ offset: 0x1E60 : GFXMMU LUT entry 460 low
$58031e64 constant GFXMMU_S_GFXMMU_LUT460H  \ offset: 0x1E64 : GFXMMU LUT entry 460 high
$58031e68 constant GFXMMU_S_GFXMMU_LUT461L  \ offset: 0x1E68 : GFXMMU LUT entry 461 low
$58031e6c constant GFXMMU_S_GFXMMU_LUT461H  \ offset: 0x1E6C : GFXMMU LUT entry 461 high
$58031e70 constant GFXMMU_S_GFXMMU_LUT462L  \ offset: 0x1E70 : GFXMMU LUT entry 462 low
$58031e74 constant GFXMMU_S_GFXMMU_LUT462H  \ offset: 0x1E74 : GFXMMU LUT entry 462 high
$58031e78 constant GFXMMU_S_GFXMMU_LUT463L  \ offset: 0x1E78 : GFXMMU LUT entry 463 low
$58031e7c constant GFXMMU_S_GFXMMU_LUT463H  \ offset: 0x1E7C : GFXMMU LUT entry 463 high
$58031e80 constant GFXMMU_S_GFXMMU_LUT464L  \ offset: 0x1E80 : GFXMMU LUT entry 464 low
$58031e84 constant GFXMMU_S_GFXMMU_LUT464H  \ offset: 0x1E84 : GFXMMU LUT entry 464 high
$58031e88 constant GFXMMU_S_GFXMMU_LUT465L  \ offset: 0x1E88 : GFXMMU LUT entry 465 low
$58031e8c constant GFXMMU_S_GFXMMU_LUT465H  \ offset: 0x1E8C : GFXMMU LUT entry 465 high
$58031e90 constant GFXMMU_S_GFXMMU_LUT466L  \ offset: 0x1E90 : GFXMMU LUT entry 466 low
$58031e94 constant GFXMMU_S_GFXMMU_LUT466H  \ offset: 0x1E94 : GFXMMU LUT entry 466 high
$58031e98 constant GFXMMU_S_GFXMMU_LUT467L  \ offset: 0x1E98 : GFXMMU LUT entry 467 low
$58031e9c constant GFXMMU_S_GFXMMU_LUT467H  \ offset: 0x1E9C : GFXMMU LUT entry 467 high
$58031ea0 constant GFXMMU_S_GFXMMU_LUT468L  \ offset: 0x1EA0 : GFXMMU LUT entry 468 low
$58031ea4 constant GFXMMU_S_GFXMMU_LUT468H  \ offset: 0x1EA4 : GFXMMU LUT entry 468 high
$58031ea8 constant GFXMMU_S_GFXMMU_LUT469L  \ offset: 0x1EA8 : GFXMMU LUT entry 469 low
$58031eac constant GFXMMU_S_GFXMMU_LUT469H  \ offset: 0x1EAC : GFXMMU LUT entry 469 high
$58031eb0 constant GFXMMU_S_GFXMMU_LUT470L  \ offset: 0x1EB0 : GFXMMU LUT entry 470 low
$58031eb4 constant GFXMMU_S_GFXMMU_LUT470H  \ offset: 0x1EB4 : GFXMMU LUT entry 470 high
$58031eb8 constant GFXMMU_S_GFXMMU_LUT471L  \ offset: 0x1EB8 : GFXMMU LUT entry 471 low
$58031ebc constant GFXMMU_S_GFXMMU_LUT471H  \ offset: 0x1EBC : GFXMMU LUT entry 471 high
$58031ec0 constant GFXMMU_S_GFXMMU_LUT472L  \ offset: 0x1EC0 : GFXMMU LUT entry 472 low
$58031ec4 constant GFXMMU_S_GFXMMU_LUT472H  \ offset: 0x1EC4 : GFXMMU LUT entry 472 high
$58031ec8 constant GFXMMU_S_GFXMMU_LUT473L  \ offset: 0x1EC8 : GFXMMU LUT entry 473 low
$58031ecc constant GFXMMU_S_GFXMMU_LUT473H  \ offset: 0x1ECC : GFXMMU LUT entry 473 high
$58031ed0 constant GFXMMU_S_GFXMMU_LUT474L  \ offset: 0x1ED0 : GFXMMU LUT entry 474 low
$58031ed4 constant GFXMMU_S_GFXMMU_LUT474H  \ offset: 0x1ED4 : GFXMMU LUT entry 474 high
$58031ed8 constant GFXMMU_S_GFXMMU_LUT475L  \ offset: 0x1ED8 : GFXMMU LUT entry 475 low
$58031edc constant GFXMMU_S_GFXMMU_LUT475H  \ offset: 0x1EDC : GFXMMU LUT entry 475 high
$58031ee0 constant GFXMMU_S_GFXMMU_LUT476L  \ offset: 0x1EE0 : GFXMMU LUT entry 476 low
$58031ee4 constant GFXMMU_S_GFXMMU_LUT476H  \ offset: 0x1EE4 : GFXMMU LUT entry 476 high
$58031ee8 constant GFXMMU_S_GFXMMU_LUT477L  \ offset: 0x1EE8 : GFXMMU LUT entry 477 low
$58031eec constant GFXMMU_S_GFXMMU_LUT477H  \ offset: 0x1EEC : GFXMMU LUT entry 477 high
$58031ef0 constant GFXMMU_S_GFXMMU_LUT478L  \ offset: 0x1EF0 : GFXMMU LUT entry 478 low
$58031ef4 constant GFXMMU_S_GFXMMU_LUT478H  \ offset: 0x1EF4 : GFXMMU LUT entry 478 high
$58031ef8 constant GFXMMU_S_GFXMMU_LUT479L  \ offset: 0x1EF8 : GFXMMU LUT entry 479 low
$58031efc constant GFXMMU_S_GFXMMU_LUT479H  \ offset: 0x1EFC : GFXMMU LUT entry 479 high
$58031f00 constant GFXMMU_S_GFXMMU_LUT480L  \ offset: 0x1F00 : GFXMMU LUT entry 480 low
$58031f04 constant GFXMMU_S_GFXMMU_LUT480H  \ offset: 0x1F04 : GFXMMU LUT entry 480 high
$58031f08 constant GFXMMU_S_GFXMMU_LUT481L  \ offset: 0x1F08 : GFXMMU LUT entry 481 low
$58031f0c constant GFXMMU_S_GFXMMU_LUT481H  \ offset: 0x1F0C : GFXMMU LUT entry 481 high
$58031f10 constant GFXMMU_S_GFXMMU_LUT482L  \ offset: 0x1F10 : GFXMMU LUT entry 482 low
$58031f14 constant GFXMMU_S_GFXMMU_LUT482H  \ offset: 0x1F14 : GFXMMU LUT entry 482 high
$58031f18 constant GFXMMU_S_GFXMMU_LUT483L  \ offset: 0x1F18 : GFXMMU LUT entry 483 low
$58031f1c constant GFXMMU_S_GFXMMU_LUT483H  \ offset: 0x1F1C : GFXMMU LUT entry 483 high
$58031f20 constant GFXMMU_S_GFXMMU_LUT484L  \ offset: 0x1F20 : GFXMMU LUT entry 484 low
$58031f24 constant GFXMMU_S_GFXMMU_LUT484H  \ offset: 0x1F24 : GFXMMU LUT entry 484 high
$58031f28 constant GFXMMU_S_GFXMMU_LUT485L  \ offset: 0x1F28 : GFXMMU LUT entry 485 low
$58031f2c constant GFXMMU_S_GFXMMU_LUT485H  \ offset: 0x1F2C : GFXMMU LUT entry 485 high
$58031f30 constant GFXMMU_S_GFXMMU_LUT486L  \ offset: 0x1F30 : GFXMMU LUT entry 486 low
$58031f34 constant GFXMMU_S_GFXMMU_LUT486H  \ offset: 0x1F34 : GFXMMU LUT entry 486 high
$58031f38 constant GFXMMU_S_GFXMMU_LUT487L  \ offset: 0x1F38 : GFXMMU LUT entry 487 low
$58031f3c constant GFXMMU_S_GFXMMU_LUT487H  \ offset: 0x1F3C : GFXMMU LUT entry 487 high
$58031f40 constant GFXMMU_S_GFXMMU_LUT488L  \ offset: 0x1F40 : GFXMMU LUT entry 488 low
$58031f44 constant GFXMMU_S_GFXMMU_LUT488H  \ offset: 0x1F44 : GFXMMU LUT entry 488 high
$58031f48 constant GFXMMU_S_GFXMMU_LUT489L  \ offset: 0x1F48 : GFXMMU LUT entry 489 low
$58031f4c constant GFXMMU_S_GFXMMU_LUT489H  \ offset: 0x1F4C : GFXMMU LUT entry 489 high
$58031f50 constant GFXMMU_S_GFXMMU_LUT490L  \ offset: 0x1F50 : GFXMMU LUT entry 490 low
$58031f54 constant GFXMMU_S_GFXMMU_LUT490H  \ offset: 0x1F54 : GFXMMU LUT entry 490 high
$58031f58 constant GFXMMU_S_GFXMMU_LUT491L  \ offset: 0x1F58 : GFXMMU LUT entry 491 low
$58031f5c constant GFXMMU_S_GFXMMU_LUT491H  \ offset: 0x1F5C : GFXMMU LUT entry 491 high
$58031f60 constant GFXMMU_S_GFXMMU_LUT492L  \ offset: 0x1F60 : GFXMMU LUT entry 492 low
$58031f64 constant GFXMMU_S_GFXMMU_LUT492H  \ offset: 0x1F64 : GFXMMU LUT entry 492 high
$58031f68 constant GFXMMU_S_GFXMMU_LUT493L  \ offset: 0x1F68 : GFXMMU LUT entry 493 low
$58031f6c constant GFXMMU_S_GFXMMU_LUT493H  \ offset: 0x1F6C : GFXMMU LUT entry 493 high
$58031f70 constant GFXMMU_S_GFXMMU_LUT494L  \ offset: 0x1F70 : GFXMMU LUT entry 494 low
$58031f74 constant GFXMMU_S_GFXMMU_LUT494H  \ offset: 0x1F74 : GFXMMU LUT entry 494 high
$58031f78 constant GFXMMU_S_GFXMMU_LUT495L  \ offset: 0x1F78 : GFXMMU LUT entry 495 low
$58031f7c constant GFXMMU_S_GFXMMU_LUT495H  \ offset: 0x1F7C : GFXMMU LUT entry 495 high
$58031f80 constant GFXMMU_S_GFXMMU_LUT496L  \ offset: 0x1F80 : GFXMMU LUT entry 496 low
$58031f84 constant GFXMMU_S_GFXMMU_LUT496H  \ offset: 0x1F84 : GFXMMU LUT entry 496 high
$58031f88 constant GFXMMU_S_GFXMMU_LUT497L  \ offset: 0x1F88 : GFXMMU LUT entry 497 low
$58031f8c constant GFXMMU_S_GFXMMU_LUT497H  \ offset: 0x1F8C : GFXMMU LUT entry 497 high
$58031f90 constant GFXMMU_S_GFXMMU_LUT498L  \ offset: 0x1F90 : GFXMMU LUT entry 498 low
$58031f94 constant GFXMMU_S_GFXMMU_LUT498H  \ offset: 0x1F94 : GFXMMU LUT entry 498 high
$58031f98 constant GFXMMU_S_GFXMMU_LUT499L  \ offset: 0x1F98 : GFXMMU LUT entry 499 low
$58031f9c constant GFXMMU_S_GFXMMU_LUT499H  \ offset: 0x1F9C : GFXMMU LUT entry 499 high
$58031fa0 constant GFXMMU_S_GFXMMU_LUT500L  \ offset: 0x1FA0 : GFXMMU LUT entry 500 low
$58031fa4 constant GFXMMU_S_GFXMMU_LUT500H  \ offset: 0x1FA4 : GFXMMU LUT entry 500 high
$58031fa8 constant GFXMMU_S_GFXMMU_LUT501L  \ offset: 0x1FA8 : GFXMMU LUT entry 501 low
$58031fac constant GFXMMU_S_GFXMMU_LUT501H  \ offset: 0x1FAC : GFXMMU LUT entry 501 high
$58031fb0 constant GFXMMU_S_GFXMMU_LUT502L  \ offset: 0x1FB0 : GFXMMU LUT entry 502 low
$58031fb4 constant GFXMMU_S_GFXMMU_LUT502H  \ offset: 0x1FB4 : GFXMMU LUT entry 502 high
$58031fb8 constant GFXMMU_S_GFXMMU_LUT503L  \ offset: 0x1FB8 : GFXMMU LUT entry 503 low
$58031fbc constant GFXMMU_S_GFXMMU_LUT503H  \ offset: 0x1FBC : GFXMMU LUT entry 503 high
$58031fc0 constant GFXMMU_S_GFXMMU_LUT504L  \ offset: 0x1FC0 : GFXMMU LUT entry 504 low
$58031fc4 constant GFXMMU_S_GFXMMU_LUT504H  \ offset: 0x1FC4 : GFXMMU LUT entry 504 high
$58031fc8 constant GFXMMU_S_GFXMMU_LUT505L  \ offset: 0x1FC8 : GFXMMU LUT entry 505 low
$58031fcc constant GFXMMU_S_GFXMMU_LUT505H  \ offset: 0x1FCC : GFXMMU LUT entry 505 high
$58031fd0 constant GFXMMU_S_GFXMMU_LUT506L  \ offset: 0x1FD0 : GFXMMU LUT entry 506 low
$58031fd4 constant GFXMMU_S_GFXMMU_LUT506H  \ offset: 0x1FD4 : GFXMMU LUT entry 506 high
$58031fd8 constant GFXMMU_S_GFXMMU_LUT507L  \ offset: 0x1FD8 : GFXMMU LUT entry 507 low
$58031fdc constant GFXMMU_S_GFXMMU_LUT507H  \ offset: 0x1FDC : GFXMMU LUT entry 507 high
$58031fe0 constant GFXMMU_S_GFXMMU_LUT508L  \ offset: 0x1FE0 : GFXMMU LUT entry 508 low
$58031fe4 constant GFXMMU_S_GFXMMU_LUT508H  \ offset: 0x1FE4 : GFXMMU LUT entry 508 high
$58031fe8 constant GFXMMU_S_GFXMMU_LUT509L  \ offset: 0x1FE8 : GFXMMU LUT entry 509 low
$58031fec constant GFXMMU_S_GFXMMU_LUT509H  \ offset: 0x1FEC : GFXMMU LUT entry 509 high
$58031ff0 constant GFXMMU_S_GFXMMU_LUT510L  \ offset: 0x1FF0 : GFXMMU LUT entry 510 low
$58031ff4 constant GFXMMU_S_GFXMMU_LUT510H  \ offset: 0x1FF4 : GFXMMU LUT entry 510 high
$58031ff8 constant GFXMMU_S_GFXMMU_LUT511L  \ offset: 0x1FF8 : GFXMMU LUT entry 511 low
$58031ffc constant GFXMMU_S_GFXMMU_LUT511H  \ offset: 0x1FFC : GFXMMU LUT entry 511 high
$58032000 constant GFXMMU_S_GFXMMU_LUT512L  \ offset: 0x2000 : GFXMMU LUT entry 512 low
$58032004 constant GFXMMU_S_GFXMMU_LUT512H  \ offset: 0x2004 : GFXMMU LUT entry 512 high
$58032008 constant GFXMMU_S_GFXMMU_LUT513L  \ offset: 0x2008 : GFXMMU LUT entry 513 low
$5803200c constant GFXMMU_S_GFXMMU_LUT513H  \ offset: 0x200C : GFXMMU LUT entry 513 high
$58032010 constant GFXMMU_S_GFXMMU_LUT514L  \ offset: 0x2010 : GFXMMU LUT entry 514 low
$58032014 constant GFXMMU_S_GFXMMU_LUT514H  \ offset: 0x2014 : GFXMMU LUT entry 514 high
$58032018 constant GFXMMU_S_GFXMMU_LUT515L  \ offset: 0x2018 : GFXMMU LUT entry 515 low
$5803201c constant GFXMMU_S_GFXMMU_LUT515H  \ offset: 0x201C : GFXMMU LUT entry 515 high
$58032020 constant GFXMMU_S_GFXMMU_LUT516L  \ offset: 0x2020 : GFXMMU LUT entry 516 low
$58032024 constant GFXMMU_S_GFXMMU_LUT516H  \ offset: 0x2024 : GFXMMU LUT entry 516 high
$58032028 constant GFXMMU_S_GFXMMU_LUT517L  \ offset: 0x2028 : GFXMMU LUT entry 517 low
$5803202c constant GFXMMU_S_GFXMMU_LUT517H  \ offset: 0x202C : GFXMMU LUT entry 517 high
$58032030 constant GFXMMU_S_GFXMMU_LUT518L  \ offset: 0x2030 : GFXMMU LUT entry 518 low
$58032034 constant GFXMMU_S_GFXMMU_LUT518H  \ offset: 0x2034 : GFXMMU LUT entry 518 high
$58032038 constant GFXMMU_S_GFXMMU_LUT519L  \ offset: 0x2038 : GFXMMU LUT entry 519 low
$5803203c constant GFXMMU_S_GFXMMU_LUT519H  \ offset: 0x203C : GFXMMU LUT entry 519 high
$58032040 constant GFXMMU_S_GFXMMU_LUT520L  \ offset: 0x2040 : GFXMMU LUT entry 520 low
$58032044 constant GFXMMU_S_GFXMMU_LUT520H  \ offset: 0x2044 : GFXMMU LUT entry 520 high
$58032048 constant GFXMMU_S_GFXMMU_LUT521L  \ offset: 0x2048 : GFXMMU LUT entry 521 low
$5803204c constant GFXMMU_S_GFXMMU_LUT521H  \ offset: 0x204C : GFXMMU LUT entry 521 high
$58032050 constant GFXMMU_S_GFXMMU_LUT522L  \ offset: 0x2050 : GFXMMU LUT entry 522 low
$58032054 constant GFXMMU_S_GFXMMU_LUT522H  \ offset: 0x2054 : GFXMMU LUT entry 522 high
$58032058 constant GFXMMU_S_GFXMMU_LUT523L  \ offset: 0x2058 : GFXMMU LUT entry 523 low
$5803205c constant GFXMMU_S_GFXMMU_LUT523H  \ offset: 0x205C : GFXMMU LUT entry 523 high
$58032060 constant GFXMMU_S_GFXMMU_LUT524L  \ offset: 0x2060 : GFXMMU LUT entry 524 low
$58032064 constant GFXMMU_S_GFXMMU_LUT524H  \ offset: 0x2064 : GFXMMU LUT entry 524 high
$58032068 constant GFXMMU_S_GFXMMU_LUT525L  \ offset: 0x2068 : GFXMMU LUT entry 525 low
$5803206c constant GFXMMU_S_GFXMMU_LUT525H  \ offset: 0x206C : GFXMMU LUT entry 525 high
$58032070 constant GFXMMU_S_GFXMMU_LUT526L  \ offset: 0x2070 : GFXMMU LUT entry 526 low
$58032074 constant GFXMMU_S_GFXMMU_LUT526H  \ offset: 0x2074 : GFXMMU LUT entry 526 high
$58032078 constant GFXMMU_S_GFXMMU_LUT527L  \ offset: 0x2078 : GFXMMU LUT entry 527 low
$5803207c constant GFXMMU_S_GFXMMU_LUT527H  \ offset: 0x207C : GFXMMU LUT entry 527 high
$58032080 constant GFXMMU_S_GFXMMU_LUT528L  \ offset: 0x2080 : GFXMMU LUT entry 528 low
$58032084 constant GFXMMU_S_GFXMMU_LUT528H  \ offset: 0x2084 : GFXMMU LUT entry 528 high
$58032088 constant GFXMMU_S_GFXMMU_LUT529L  \ offset: 0x2088 : GFXMMU LUT entry 529 low
$5803208c constant GFXMMU_S_GFXMMU_LUT529H  \ offset: 0x208C : GFXMMU LUT entry 529 high
$58032090 constant GFXMMU_S_GFXMMU_LUT530L  \ offset: 0x2090 : GFXMMU LUT entry 530 low
$58032094 constant GFXMMU_S_GFXMMU_LUT530H  \ offset: 0x2094 : GFXMMU LUT entry 530 high
$58032098 constant GFXMMU_S_GFXMMU_LUT531L  \ offset: 0x2098 : GFXMMU LUT entry 531 low
$5803209c constant GFXMMU_S_GFXMMU_LUT531H  \ offset: 0x209C : GFXMMU LUT entry 531 high
$580320a0 constant GFXMMU_S_GFXMMU_LUT532L  \ offset: 0x20A0 : GFXMMU LUT entry 532 low
$580320a4 constant GFXMMU_S_GFXMMU_LUT532H  \ offset: 0x20A4 : GFXMMU LUT entry 532 high
$580320a8 constant GFXMMU_S_GFXMMU_LUT533L  \ offset: 0x20A8 : GFXMMU LUT entry 533 low
$580320ac constant GFXMMU_S_GFXMMU_LUT533H  \ offset: 0x20AC : GFXMMU LUT entry 533 high
$580320b0 constant GFXMMU_S_GFXMMU_LUT534L  \ offset: 0x20B0 : GFXMMU LUT entry 534 low
$580320b4 constant GFXMMU_S_GFXMMU_LUT534H  \ offset: 0x20B4 : GFXMMU LUT entry 534 high
$580320b8 constant GFXMMU_S_GFXMMU_LUT535L  \ offset: 0x20B8 : GFXMMU LUT entry 535 low
$580320bc constant GFXMMU_S_GFXMMU_LUT535H  \ offset: 0x20BC : GFXMMU LUT entry 535 high
$580320c0 constant GFXMMU_S_GFXMMU_LUT536L  \ offset: 0x20C0 : GFXMMU LUT entry 536 low
$580320c4 constant GFXMMU_S_GFXMMU_LUT536H  \ offset: 0x20C4 : GFXMMU LUT entry 536 high
$580320c8 constant GFXMMU_S_GFXMMU_LUT537L  \ offset: 0x20C8 : GFXMMU LUT entry 537 low
$580320cc constant GFXMMU_S_GFXMMU_LUT537H  \ offset: 0x20CC : GFXMMU LUT entry 537 high
$580320d0 constant GFXMMU_S_GFXMMU_LUT538L  \ offset: 0x20D0 : GFXMMU LUT entry 538 low
$580320d4 constant GFXMMU_S_GFXMMU_LUT538H  \ offset: 0x20D4 : GFXMMU LUT entry 538 high
$580320d8 constant GFXMMU_S_GFXMMU_LUT539L  \ offset: 0x20D8 : GFXMMU LUT entry 539 low
$580320dc constant GFXMMU_S_GFXMMU_LUT539H  \ offset: 0x20DC : GFXMMU LUT entry 539 high
$580320e0 constant GFXMMU_S_GFXMMU_LUT540L  \ offset: 0x20E0 : GFXMMU LUT entry 540 low
$580320e4 constant GFXMMU_S_GFXMMU_LUT540H  \ offset: 0x20E4 : GFXMMU LUT entry 540 high
$580320e8 constant GFXMMU_S_GFXMMU_LUT541L  \ offset: 0x20E8 : GFXMMU LUT entry 541 low
$580320ec constant GFXMMU_S_GFXMMU_LUT541H  \ offset: 0x20EC : GFXMMU LUT entry 541 high
$580320f0 constant GFXMMU_S_GFXMMU_LUT542L  \ offset: 0x20F0 : GFXMMU LUT entry 542 low
$580320f4 constant GFXMMU_S_GFXMMU_LUT542H  \ offset: 0x20F4 : GFXMMU LUT entry 542 high
$580320f8 constant GFXMMU_S_GFXMMU_LUT543L  \ offset: 0x20F8 : GFXMMU LUT entry 543 low
$580320fc constant GFXMMU_S_GFXMMU_LUT543H  \ offset: 0x20FC : GFXMMU LUT entry 543 high
$58032100 constant GFXMMU_S_GFXMMU_LUT544L  \ offset: 0x2100 : GFXMMU LUT entry 544 low
$58032104 constant GFXMMU_S_GFXMMU_LUT544H  \ offset: 0x2104 : GFXMMU LUT entry 544 high
$58032108 constant GFXMMU_S_GFXMMU_LUT545L  \ offset: 0x2108 : GFXMMU LUT entry 545 low
$5803210c constant GFXMMU_S_GFXMMU_LUT545H  \ offset: 0x210C : GFXMMU LUT entry 545 high
$58032110 constant GFXMMU_S_GFXMMU_LUT546L  \ offset: 0x2110 : GFXMMU LUT entry 546 low
$58032114 constant GFXMMU_S_GFXMMU_LUT546H  \ offset: 0x2114 : GFXMMU LUT entry 546 high
$58032118 constant GFXMMU_S_GFXMMU_LUT547L  \ offset: 0x2118 : GFXMMU LUT entry 547 low
$5803211c constant GFXMMU_S_GFXMMU_LUT547H  \ offset: 0x211C : GFXMMU LUT entry 547 high
$58032120 constant GFXMMU_S_GFXMMU_LUT548L  \ offset: 0x2120 : GFXMMU LUT entry 548 low
$58032124 constant GFXMMU_S_GFXMMU_LUT548H  \ offset: 0x2124 : GFXMMU LUT entry 548 high
$58032128 constant GFXMMU_S_GFXMMU_LUT549L  \ offset: 0x2128 : GFXMMU LUT entry 549 low
$5803212c constant GFXMMU_S_GFXMMU_LUT549H  \ offset: 0x212C : GFXMMU LUT entry 549 high
$58032130 constant GFXMMU_S_GFXMMU_LUT550L  \ offset: 0x2130 : GFXMMU LUT entry 550 low
$58032134 constant GFXMMU_S_GFXMMU_LUT550H  \ offset: 0x2134 : GFXMMU LUT entry 550 high
$58032138 constant GFXMMU_S_GFXMMU_LUT551L  \ offset: 0x2138 : GFXMMU LUT entry 551 low
$5803213c constant GFXMMU_S_GFXMMU_LUT551H  \ offset: 0x213C : GFXMMU LUT entry 551 high
$58032140 constant GFXMMU_S_GFXMMU_LUT552L  \ offset: 0x2140 : GFXMMU LUT entry 552 low
$58032144 constant GFXMMU_S_GFXMMU_LUT552H  \ offset: 0x2144 : GFXMMU LUT entry 552 high
$58032148 constant GFXMMU_S_GFXMMU_LUT553L  \ offset: 0x2148 : GFXMMU LUT entry 553 low
$5803214c constant GFXMMU_S_GFXMMU_LUT553H  \ offset: 0x214C : GFXMMU LUT entry 553 high
$58032150 constant GFXMMU_S_GFXMMU_LUT554L  \ offset: 0x2150 : GFXMMU LUT entry 554 low
$58032154 constant GFXMMU_S_GFXMMU_LUT554H  \ offset: 0x2154 : GFXMMU LUT entry 554 high
$58032158 constant GFXMMU_S_GFXMMU_LUT555L  \ offset: 0x2158 : GFXMMU LUT entry 555 low
$5803215c constant GFXMMU_S_GFXMMU_LUT555H  \ offset: 0x215C : GFXMMU LUT entry 555 high
$58032160 constant GFXMMU_S_GFXMMU_LUT556L  \ offset: 0x2160 : GFXMMU LUT entry 556 low
$58032164 constant GFXMMU_S_GFXMMU_LUT556H  \ offset: 0x2164 : GFXMMU LUT entry 556 high
$58032168 constant GFXMMU_S_GFXMMU_LUT557L  \ offset: 0x2168 : GFXMMU LUT entry 557 low
$5803216c constant GFXMMU_S_GFXMMU_LUT557H  \ offset: 0x216C : GFXMMU LUT entry 557 high
$58032170 constant GFXMMU_S_GFXMMU_LUT558L  \ offset: 0x2170 : GFXMMU LUT entry 558 low
$58032174 constant GFXMMU_S_GFXMMU_LUT558H  \ offset: 0x2174 : GFXMMU LUT entry 558 high
$58032178 constant GFXMMU_S_GFXMMU_LUT559L  \ offset: 0x2178 : GFXMMU LUT entry 559 low
$5803217c constant GFXMMU_S_GFXMMU_LUT559H  \ offset: 0x217C : GFXMMU LUT entry 559 high
$58032180 constant GFXMMU_S_GFXMMU_LUT560L  \ offset: 0x2180 : GFXMMU LUT entry 560 low
$58032184 constant GFXMMU_S_GFXMMU_LUT560H  \ offset: 0x2184 : GFXMMU LUT entry 560 high
$58032188 constant GFXMMU_S_GFXMMU_LUT561L  \ offset: 0x2188 : GFXMMU LUT entry 561 low
$5803218c constant GFXMMU_S_GFXMMU_LUT561H  \ offset: 0x218C : GFXMMU LUT entry 561 high
$58032190 constant GFXMMU_S_GFXMMU_LUT562L  \ offset: 0x2190 : GFXMMU LUT entry 562 low
$58032194 constant GFXMMU_S_GFXMMU_LUT562H  \ offset: 0x2194 : GFXMMU LUT entry 562 high
$58032198 constant GFXMMU_S_GFXMMU_LUT563L  \ offset: 0x2198 : GFXMMU LUT entry 563 low
$5803219c constant GFXMMU_S_GFXMMU_LUT563H  \ offset: 0x219C : GFXMMU LUT entry 563 high
$580321a0 constant GFXMMU_S_GFXMMU_LUT564L  \ offset: 0x21A0 : GFXMMU LUT entry 564 low
$580321a4 constant GFXMMU_S_GFXMMU_LUT564H  \ offset: 0x21A4 : GFXMMU LUT entry 564 high
$580321a8 constant GFXMMU_S_GFXMMU_LUT565L  \ offset: 0x21A8 : GFXMMU LUT entry 565 low
$580321ac constant GFXMMU_S_GFXMMU_LUT565H  \ offset: 0x21AC : GFXMMU LUT entry 565 high
$580321b0 constant GFXMMU_S_GFXMMU_LUT566L  \ offset: 0x21B0 : GFXMMU LUT entry 566 low
$580321b4 constant GFXMMU_S_GFXMMU_LUT566H  \ offset: 0x21B4 : GFXMMU LUT entry 566 high
$580321b8 constant GFXMMU_S_GFXMMU_LUT567L  \ offset: 0x21B8 : GFXMMU LUT entry 567 low
$580321bc constant GFXMMU_S_GFXMMU_LUT567H  \ offset: 0x21BC : GFXMMU LUT entry 567 high
$580321c0 constant GFXMMU_S_GFXMMU_LUT568L  \ offset: 0x21C0 : GFXMMU LUT entry 568 low
$580321c4 constant GFXMMU_S_GFXMMU_LUT568H  \ offset: 0x21C4 : GFXMMU LUT entry 568 high
$580321c8 constant GFXMMU_S_GFXMMU_LUT569L  \ offset: 0x21C8 : GFXMMU LUT entry 569 low
$580321cc constant GFXMMU_S_GFXMMU_LUT569H  \ offset: 0x21CC : GFXMMU LUT entry 569 high
$580321d0 constant GFXMMU_S_GFXMMU_LUT570L  \ offset: 0x21D0 : GFXMMU LUT entry 570 low
$580321d4 constant GFXMMU_S_GFXMMU_LUT570H  \ offset: 0x21D4 : GFXMMU LUT entry 570 high
$580321d8 constant GFXMMU_S_GFXMMU_LUT571L  \ offset: 0x21D8 : GFXMMU LUT entry 571 low
$580321dc constant GFXMMU_S_GFXMMU_LUT571H  \ offset: 0x21DC : GFXMMU LUT entry 571 high
$580321e0 constant GFXMMU_S_GFXMMU_LUT572L  \ offset: 0x21E0 : GFXMMU LUT entry 572 low
$580321e4 constant GFXMMU_S_GFXMMU_LUT572H  \ offset: 0x21E4 : GFXMMU LUT entry 572 high
$580321e8 constant GFXMMU_S_GFXMMU_LUT573L  \ offset: 0x21E8 : GFXMMU LUT entry 573 low
$580321ec constant GFXMMU_S_GFXMMU_LUT573H  \ offset: 0x21EC : GFXMMU LUT entry 573 high
$580321f0 constant GFXMMU_S_GFXMMU_LUT574L  \ offset: 0x21F0 : GFXMMU LUT entry 574 low
$580321f4 constant GFXMMU_S_GFXMMU_LUT574H  \ offset: 0x21F4 : GFXMMU LUT entry 574 high
$580321f8 constant GFXMMU_S_GFXMMU_LUT575L  \ offset: 0x21F8 : GFXMMU LUT entry 575 low
$580321fc constant GFXMMU_S_GFXMMU_LUT575H  \ offset: 0x21FC : GFXMMU LUT entry 575 high
$58032200 constant GFXMMU_S_GFXMMU_LUT576L  \ offset: 0x2200 : GFXMMU LUT entry 576 low
$58032204 constant GFXMMU_S_GFXMMU_LUT576H  \ offset: 0x2204 : GFXMMU LUT entry 576 high
$58032208 constant GFXMMU_S_GFXMMU_LUT577L  \ offset: 0x2208 : GFXMMU LUT entry 577 low
$5803220c constant GFXMMU_S_GFXMMU_LUT577H  \ offset: 0x220C : GFXMMU LUT entry 577 high
$58032210 constant GFXMMU_S_GFXMMU_LUT578L  \ offset: 0x2210 : GFXMMU LUT entry 578 low
$58032214 constant GFXMMU_S_GFXMMU_LUT578H  \ offset: 0x2214 : GFXMMU LUT entry 578 high
$58032218 constant GFXMMU_S_GFXMMU_LUT579L  \ offset: 0x2218 : GFXMMU LUT entry 579 low
$5803221c constant GFXMMU_S_GFXMMU_LUT579H  \ offset: 0x221C : GFXMMU LUT entry 579 high
$58032220 constant GFXMMU_S_GFXMMU_LUT580L  \ offset: 0x2220 : GFXMMU LUT entry 580 low
$58032224 constant GFXMMU_S_GFXMMU_LUT580H  \ offset: 0x2224 : GFXMMU LUT entry 580 high
$58032228 constant GFXMMU_S_GFXMMU_LUT581L  \ offset: 0x2228 : GFXMMU LUT entry 581 low
$5803222c constant GFXMMU_S_GFXMMU_LUT581H  \ offset: 0x222C : GFXMMU LUT entry 581 high
$58032230 constant GFXMMU_S_GFXMMU_LUT582L  \ offset: 0x2230 : GFXMMU LUT entry 582 low
$58032234 constant GFXMMU_S_GFXMMU_LUT582H  \ offset: 0x2234 : GFXMMU LUT entry 582 high
$58032238 constant GFXMMU_S_GFXMMU_LUT583L  \ offset: 0x2238 : GFXMMU LUT entry 583 low
$5803223c constant GFXMMU_S_GFXMMU_LUT583H  \ offset: 0x223C : GFXMMU LUT entry 583 high
$58032240 constant GFXMMU_S_GFXMMU_LUT584L  \ offset: 0x2240 : GFXMMU LUT entry 584 low
$58032244 constant GFXMMU_S_GFXMMU_LUT584H  \ offset: 0x2244 : GFXMMU LUT entry 584 high
$58032248 constant GFXMMU_S_GFXMMU_LUT585L  \ offset: 0x2248 : GFXMMU LUT entry 585 low
$5803224c constant GFXMMU_S_GFXMMU_LUT585H  \ offset: 0x224C : GFXMMU LUT entry 585 high
$58032250 constant GFXMMU_S_GFXMMU_LUT586L  \ offset: 0x2250 : GFXMMU LUT entry 586 low
$58032254 constant GFXMMU_S_GFXMMU_LUT586H  \ offset: 0x2254 : GFXMMU LUT entry 586 high
$58032258 constant GFXMMU_S_GFXMMU_LUT587L  \ offset: 0x2258 : GFXMMU LUT entry 587 low
$5803225c constant GFXMMU_S_GFXMMU_LUT587H  \ offset: 0x225C : GFXMMU LUT entry 587 high
$58032260 constant GFXMMU_S_GFXMMU_LUT588L  \ offset: 0x2260 : GFXMMU LUT entry 588 low
$58032264 constant GFXMMU_S_GFXMMU_LUT588H  \ offset: 0x2264 : GFXMMU LUT entry 588 high
$58032268 constant GFXMMU_S_GFXMMU_LUT589L  \ offset: 0x2268 : GFXMMU LUT entry 589 low
$5803226c constant GFXMMU_S_GFXMMU_LUT589H  \ offset: 0x226C : GFXMMU LUT entry 589 high
$58032270 constant GFXMMU_S_GFXMMU_LUT590L  \ offset: 0x2270 : GFXMMU LUT entry 590 low
$58032274 constant GFXMMU_S_GFXMMU_LUT590H  \ offset: 0x2274 : GFXMMU LUT entry 590 high
$58032278 constant GFXMMU_S_GFXMMU_LUT591L  \ offset: 0x2278 : GFXMMU LUT entry 591 low
$5803227c constant GFXMMU_S_GFXMMU_LUT591H  \ offset: 0x227C : GFXMMU LUT entry 591 high
$58032280 constant GFXMMU_S_GFXMMU_LUT592L  \ offset: 0x2280 : GFXMMU LUT entry 592 low
$58032284 constant GFXMMU_S_GFXMMU_LUT592H  \ offset: 0x2284 : GFXMMU LUT entry 592 high
$58032288 constant GFXMMU_S_GFXMMU_LUT593L  \ offset: 0x2288 : GFXMMU LUT entry 593 low
$5803228c constant GFXMMU_S_GFXMMU_LUT593H  \ offset: 0x228C : GFXMMU LUT entry 593 high
$58032290 constant GFXMMU_S_GFXMMU_LUT594L  \ offset: 0x2290 : GFXMMU LUT entry 594 low
$58032294 constant GFXMMU_S_GFXMMU_LUT594H  \ offset: 0x2294 : GFXMMU LUT entry 594 high
$58032298 constant GFXMMU_S_GFXMMU_LUT595L  \ offset: 0x2298 : GFXMMU LUT entry 595 low
$5803229c constant GFXMMU_S_GFXMMU_LUT595H  \ offset: 0x229C : GFXMMU LUT entry 595 high
$580322a0 constant GFXMMU_S_GFXMMU_LUT596L  \ offset: 0x22A0 : GFXMMU LUT entry 596 low
$580322a4 constant GFXMMU_S_GFXMMU_LUT596H  \ offset: 0x22A4 : GFXMMU LUT entry 596 high
$580322a8 constant GFXMMU_S_GFXMMU_LUT597L  \ offset: 0x22A8 : GFXMMU LUT entry 597 low
$580322ac constant GFXMMU_S_GFXMMU_LUT597H  \ offset: 0x22AC : GFXMMU LUT entry 597 high
$580322b0 constant GFXMMU_S_GFXMMU_LUT598L  \ offset: 0x22B0 : GFXMMU LUT entry 598 low
$580322b4 constant GFXMMU_S_GFXMMU_LUT598H  \ offset: 0x22B4 : GFXMMU LUT entry 598 high
$580322b8 constant GFXMMU_S_GFXMMU_LUT599L  \ offset: 0x22B8 : GFXMMU LUT entry 599 low
$580322bc constant GFXMMU_S_GFXMMU_LUT599H  \ offset: 0x22BC : GFXMMU LUT entry 599 high
$580322c0 constant GFXMMU_S_GFXMMU_LUT600L  \ offset: 0x22C0 : GFXMMU LUT entry 600 low
$580322c4 constant GFXMMU_S_GFXMMU_LUT600H  \ offset: 0x22C4 : GFXMMU LUT entry 600 high
$580322c8 constant GFXMMU_S_GFXMMU_LUT601L  \ offset: 0x22C8 : GFXMMU LUT entry 601 low
$580322cc constant GFXMMU_S_GFXMMU_LUT601H  \ offset: 0x22CC : GFXMMU LUT entry 601 high
$580322d0 constant GFXMMU_S_GFXMMU_LUT602L  \ offset: 0x22D0 : GFXMMU LUT entry 602 low
$580322d4 constant GFXMMU_S_GFXMMU_LUT602H  \ offset: 0x22D4 : GFXMMU LUT entry 602 high
$580322d8 constant GFXMMU_S_GFXMMU_LUT603L  \ offset: 0x22D8 : GFXMMU LUT entry 603 low
$580322dc constant GFXMMU_S_GFXMMU_LUT603H  \ offset: 0x22DC : GFXMMU LUT entry 603 high
$580322e0 constant GFXMMU_S_GFXMMU_LUT604L  \ offset: 0x22E0 : GFXMMU LUT entry 604 low
$580322e4 constant GFXMMU_S_GFXMMU_LUT604H  \ offset: 0x22E4 : GFXMMU LUT entry 604 high
$580322e8 constant GFXMMU_S_GFXMMU_LUT605L  \ offset: 0x22E8 : GFXMMU LUT entry 605 low
$580322ec constant GFXMMU_S_GFXMMU_LUT605H  \ offset: 0x22EC : GFXMMU LUT entry 605 high
$580322f0 constant GFXMMU_S_GFXMMU_LUT606L  \ offset: 0x22F0 : GFXMMU LUT entry 606 low
$580322f4 constant GFXMMU_S_GFXMMU_LUT606H  \ offset: 0x22F4 : GFXMMU LUT entry 606 high
$580322f8 constant GFXMMU_S_GFXMMU_LUT607L  \ offset: 0x22F8 : GFXMMU LUT entry 607 low
$580322fc constant GFXMMU_S_GFXMMU_LUT607H  \ offset: 0x22FC : GFXMMU LUT entry 607 high
$58032300 constant GFXMMU_S_GFXMMU_LUT608L  \ offset: 0x2300 : GFXMMU LUT entry 608 low
$58032304 constant GFXMMU_S_GFXMMU_LUT608H  \ offset: 0x2304 : GFXMMU LUT entry 608 high
$58032308 constant GFXMMU_S_GFXMMU_LUT609L  \ offset: 0x2308 : GFXMMU LUT entry 609 low
$5803230c constant GFXMMU_S_GFXMMU_LUT609H  \ offset: 0x230C : GFXMMU LUT entry 609 high
$58032310 constant GFXMMU_S_GFXMMU_LUT610L  \ offset: 0x2310 : GFXMMU LUT entry 610 low
$58032314 constant GFXMMU_S_GFXMMU_LUT610H  \ offset: 0x2314 : GFXMMU LUT entry 610 high
$58032318 constant GFXMMU_S_GFXMMU_LUT611L  \ offset: 0x2318 : GFXMMU LUT entry 611 low
$5803231c constant GFXMMU_S_GFXMMU_LUT611H  \ offset: 0x231C : GFXMMU LUT entry 611 high
$58032320 constant GFXMMU_S_GFXMMU_LUT612L  \ offset: 0x2320 : GFXMMU LUT entry 612 low
$58032324 constant GFXMMU_S_GFXMMU_LUT612H  \ offset: 0x2324 : GFXMMU LUT entry 612 high
$58032328 constant GFXMMU_S_GFXMMU_LUT613L  \ offset: 0x2328 : GFXMMU LUT entry 613 low
$5803232c constant GFXMMU_S_GFXMMU_LUT613H  \ offset: 0x232C : GFXMMU LUT entry 613 high
$58032330 constant GFXMMU_S_GFXMMU_LUT614L  \ offset: 0x2330 : GFXMMU LUT entry 614 low
$58032334 constant GFXMMU_S_GFXMMU_LUT614H  \ offset: 0x2334 : GFXMMU LUT entry 614 high
$58032338 constant GFXMMU_S_GFXMMU_LUT615L  \ offset: 0x2338 : GFXMMU LUT entry 615 low
$5803233c constant GFXMMU_S_GFXMMU_LUT615H  \ offset: 0x233C : GFXMMU LUT entry 615 high
$58032340 constant GFXMMU_S_GFXMMU_LUT616L  \ offset: 0x2340 : GFXMMU LUT entry 616 low
$58032344 constant GFXMMU_S_GFXMMU_LUT616H  \ offset: 0x2344 : GFXMMU LUT entry 616 high
$58032348 constant GFXMMU_S_GFXMMU_LUT617L  \ offset: 0x2348 : GFXMMU LUT entry 617 low
$5803234c constant GFXMMU_S_GFXMMU_LUT617H  \ offset: 0x234C : GFXMMU LUT entry 617 high
$58032350 constant GFXMMU_S_GFXMMU_LUT618L  \ offset: 0x2350 : GFXMMU LUT entry 618 low
$58032354 constant GFXMMU_S_GFXMMU_LUT618H  \ offset: 0x2354 : GFXMMU LUT entry 618 high
$58032358 constant GFXMMU_S_GFXMMU_LUT619L  \ offset: 0x2358 : GFXMMU LUT entry 619 low
$5803235c constant GFXMMU_S_GFXMMU_LUT619H  \ offset: 0x235C : GFXMMU LUT entry 619 high
$58032360 constant GFXMMU_S_GFXMMU_LUT620L  \ offset: 0x2360 : GFXMMU LUT entry 620 low
$58032364 constant GFXMMU_S_GFXMMU_LUT620H  \ offset: 0x2364 : GFXMMU LUT entry 620 high
$58032368 constant GFXMMU_S_GFXMMU_LUT621L  \ offset: 0x2368 : GFXMMU LUT entry 621 low
$5803236c constant GFXMMU_S_GFXMMU_LUT621H  \ offset: 0x236C : GFXMMU LUT entry 621 high
$58032370 constant GFXMMU_S_GFXMMU_LUT622L  \ offset: 0x2370 : GFXMMU LUT entry 622 low
$58032374 constant GFXMMU_S_GFXMMU_LUT622H  \ offset: 0x2374 : GFXMMU LUT entry 622 high
$58032378 constant GFXMMU_S_GFXMMU_LUT623L  \ offset: 0x2378 : GFXMMU LUT entry 623 low
$5803237c constant GFXMMU_S_GFXMMU_LUT623H  \ offset: 0x237C : GFXMMU LUT entry 623 high
$58032380 constant GFXMMU_S_GFXMMU_LUT624L  \ offset: 0x2380 : GFXMMU LUT entry 624 low
$58032384 constant GFXMMU_S_GFXMMU_LUT624H  \ offset: 0x2384 : GFXMMU LUT entry 624 high
$58032388 constant GFXMMU_S_GFXMMU_LUT625L  \ offset: 0x2388 : GFXMMU LUT entry 625 low
$5803238c constant GFXMMU_S_GFXMMU_LUT625H  \ offset: 0x238C : GFXMMU LUT entry 625 high
$58032390 constant GFXMMU_S_GFXMMU_LUT626L  \ offset: 0x2390 : GFXMMU LUT entry 626 low
$58032394 constant GFXMMU_S_GFXMMU_LUT626H  \ offset: 0x2394 : GFXMMU LUT entry 626 high
$58032398 constant GFXMMU_S_GFXMMU_LUT627L  \ offset: 0x2398 : GFXMMU LUT entry 627 low
$5803239c constant GFXMMU_S_GFXMMU_LUT627H  \ offset: 0x239C : GFXMMU LUT entry 627 high
$580323a0 constant GFXMMU_S_GFXMMU_LUT628L  \ offset: 0x23A0 : GFXMMU LUT entry 628 low
$580323a4 constant GFXMMU_S_GFXMMU_LUT628H  \ offset: 0x23A4 : GFXMMU LUT entry 628 high
$580323a8 constant GFXMMU_S_GFXMMU_LUT629L  \ offset: 0x23A8 : GFXMMU LUT entry 629 low
$580323ac constant GFXMMU_S_GFXMMU_LUT629H  \ offset: 0x23AC : GFXMMU LUT entry 629 high
$580323b0 constant GFXMMU_S_GFXMMU_LUT630L  \ offset: 0x23B0 : GFXMMU LUT entry 630 low
$580323b4 constant GFXMMU_S_GFXMMU_LUT630H  \ offset: 0x23B4 : GFXMMU LUT entry 630 high
$580323b8 constant GFXMMU_S_GFXMMU_LUT631L  \ offset: 0x23B8 : GFXMMU LUT entry 631 low
$580323bc constant GFXMMU_S_GFXMMU_LUT631H  \ offset: 0x23BC : GFXMMU LUT entry 631 high
$580323c0 constant GFXMMU_S_GFXMMU_LUT632L  \ offset: 0x23C0 : GFXMMU LUT entry 632 low
$580323c4 constant GFXMMU_S_GFXMMU_LUT632H  \ offset: 0x23C4 : GFXMMU LUT entry 632 high
$580323c8 constant GFXMMU_S_GFXMMU_LUT633L  \ offset: 0x23C8 : GFXMMU LUT entry 633 low
$580323cc constant GFXMMU_S_GFXMMU_LUT633H  \ offset: 0x23CC : GFXMMU LUT entry 633 high
$580323d0 constant GFXMMU_S_GFXMMU_LUT634L  \ offset: 0x23D0 : GFXMMU LUT entry 634 low
$580323d4 constant GFXMMU_S_GFXMMU_LUT634H  \ offset: 0x23D4 : GFXMMU LUT entry 634 high
$580323d8 constant GFXMMU_S_GFXMMU_LUT635L  \ offset: 0x23D8 : GFXMMU LUT entry 635 low
$580323dc constant GFXMMU_S_GFXMMU_LUT635H  \ offset: 0x23DC : GFXMMU LUT entry 635 high
$580323e0 constant GFXMMU_S_GFXMMU_LUT636L  \ offset: 0x23E0 : GFXMMU LUT entry 636 low
$580323e4 constant GFXMMU_S_GFXMMU_LUT636H  \ offset: 0x23E4 : GFXMMU LUT entry 636 high
$580323e8 constant GFXMMU_S_GFXMMU_LUT637L  \ offset: 0x23E8 : GFXMMU LUT entry 637 low
$580323ec constant GFXMMU_S_GFXMMU_LUT637H  \ offset: 0x23EC : GFXMMU LUT entry 637 high
$580323f0 constant GFXMMU_S_GFXMMU_LUT638L  \ offset: 0x23F0 : GFXMMU LUT entry 638 low
$580323f4 constant GFXMMU_S_GFXMMU_LUT638H  \ offset: 0x23F4 : GFXMMU LUT entry 638 high
$580323f8 constant GFXMMU_S_GFXMMU_LUT639L  \ offset: 0x23F8 : GFXMMU LUT entry 639 low
$580323fc constant GFXMMU_S_GFXMMU_LUT639H  \ offset: 0x23FC : GFXMMU LUT entry 639 high
$58032400 constant GFXMMU_S_GFXMMU_LUT640L  \ offset: 0x2400 : GFXMMU LUT entry 640 low
$58032404 constant GFXMMU_S_GFXMMU_LUT640H  \ offset: 0x2404 : GFXMMU LUT entry 640 high
$58032408 constant GFXMMU_S_GFXMMU_LUT641L  \ offset: 0x2408 : GFXMMU LUT entry 641 low
$5803240c constant GFXMMU_S_GFXMMU_LUT641H  \ offset: 0x240C : GFXMMU LUT entry 641 high
$58032410 constant GFXMMU_S_GFXMMU_LUT642L  \ offset: 0x2410 : GFXMMU LUT entry 642 low
$58032414 constant GFXMMU_S_GFXMMU_LUT642H  \ offset: 0x2414 : GFXMMU LUT entry 642 high
$58032418 constant GFXMMU_S_GFXMMU_LUT643L  \ offset: 0x2418 : GFXMMU LUT entry 643 low
$5803241c constant GFXMMU_S_GFXMMU_LUT643H  \ offset: 0x241C : GFXMMU LUT entry 643 high
$58032420 constant GFXMMU_S_GFXMMU_LUT644L  \ offset: 0x2420 : GFXMMU LUT entry 644 low
$58032424 constant GFXMMU_S_GFXMMU_LUT644H  \ offset: 0x2424 : GFXMMU LUT entry 644 high
$58032428 constant GFXMMU_S_GFXMMU_LUT645L  \ offset: 0x2428 : GFXMMU LUT entry 645 low
$5803242c constant GFXMMU_S_GFXMMU_LUT645H  \ offset: 0x242C : GFXMMU LUT entry 645 high
$58032430 constant GFXMMU_S_GFXMMU_LUT646L  \ offset: 0x2430 : GFXMMU LUT entry 646 low
$58032434 constant GFXMMU_S_GFXMMU_LUT646H  \ offset: 0x2434 : GFXMMU LUT entry 646 high
$58032438 constant GFXMMU_S_GFXMMU_LUT647L  \ offset: 0x2438 : GFXMMU LUT entry 647 low
$5803243c constant GFXMMU_S_GFXMMU_LUT647H  \ offset: 0x243C : GFXMMU LUT entry 647 high
$58032440 constant GFXMMU_S_GFXMMU_LUT648L  \ offset: 0x2440 : GFXMMU LUT entry 648 low
$58032444 constant GFXMMU_S_GFXMMU_LUT648H  \ offset: 0x2444 : GFXMMU LUT entry 648 high
$58032448 constant GFXMMU_S_GFXMMU_LUT649L  \ offset: 0x2448 : GFXMMU LUT entry 649 low
$5803244c constant GFXMMU_S_GFXMMU_LUT649H  \ offset: 0x244C : GFXMMU LUT entry 649 high
$58032450 constant GFXMMU_S_GFXMMU_LUT650L  \ offset: 0x2450 : GFXMMU LUT entry 650 low
$58032454 constant GFXMMU_S_GFXMMU_LUT650H  \ offset: 0x2454 : GFXMMU LUT entry 650 high
$58032458 constant GFXMMU_S_GFXMMU_LUT651L  \ offset: 0x2458 : GFXMMU LUT entry 651 low
$5803245c constant GFXMMU_S_GFXMMU_LUT651H  \ offset: 0x245C : GFXMMU LUT entry 651 high
$58032460 constant GFXMMU_S_GFXMMU_LUT652L  \ offset: 0x2460 : GFXMMU LUT entry 652 low
$58032464 constant GFXMMU_S_GFXMMU_LUT652H  \ offset: 0x2464 : GFXMMU LUT entry 652 high
$58032468 constant GFXMMU_S_GFXMMU_LUT653L  \ offset: 0x2468 : GFXMMU LUT entry 653 low
$5803246c constant GFXMMU_S_GFXMMU_LUT653H  \ offset: 0x246C : GFXMMU LUT entry 653 high
$58032470 constant GFXMMU_S_GFXMMU_LUT654L  \ offset: 0x2470 : GFXMMU LUT entry 654 low
$58032474 constant GFXMMU_S_GFXMMU_LUT654H  \ offset: 0x2474 : GFXMMU LUT entry 654 high
$58032478 constant GFXMMU_S_GFXMMU_LUT655L  \ offset: 0x2478 : GFXMMU LUT entry 655 low
$5803247c constant GFXMMU_S_GFXMMU_LUT655H  \ offset: 0x247C : GFXMMU LUT entry 655 high
$58032480 constant GFXMMU_S_GFXMMU_LUT656L  \ offset: 0x2480 : GFXMMU LUT entry 656 low
$58032484 constant GFXMMU_S_GFXMMU_LUT656H  \ offset: 0x2484 : GFXMMU LUT entry 656 high
$58032488 constant GFXMMU_S_GFXMMU_LUT657L  \ offset: 0x2488 : GFXMMU LUT entry 657 low
$5803248c constant GFXMMU_S_GFXMMU_LUT657H  \ offset: 0x248C : GFXMMU LUT entry 657 high
$58032490 constant GFXMMU_S_GFXMMU_LUT658L  \ offset: 0x2490 : GFXMMU LUT entry 658 low
$58032494 constant GFXMMU_S_GFXMMU_LUT658H  \ offset: 0x2494 : GFXMMU LUT entry 658 high
$58032498 constant GFXMMU_S_GFXMMU_LUT659L  \ offset: 0x2498 : GFXMMU LUT entry 659 low
$5803249c constant GFXMMU_S_GFXMMU_LUT659H  \ offset: 0x249C : GFXMMU LUT entry 659 high
$580324a0 constant GFXMMU_S_GFXMMU_LUT660L  \ offset: 0x24A0 : GFXMMU LUT entry 660 low
$580324a4 constant GFXMMU_S_GFXMMU_LUT660H  \ offset: 0x24A4 : GFXMMU LUT entry 660 high
$580324a8 constant GFXMMU_S_GFXMMU_LUT661L  \ offset: 0x24A8 : GFXMMU LUT entry 661 low
$580324ac constant GFXMMU_S_GFXMMU_LUT661H  \ offset: 0x24AC : GFXMMU LUT entry 661 high
$580324b0 constant GFXMMU_S_GFXMMU_LUT662L  \ offset: 0x24B0 : GFXMMU LUT entry 662 low
$580324b4 constant GFXMMU_S_GFXMMU_LUT662H  \ offset: 0x24B4 : GFXMMU LUT entry 662 high
$580324b8 constant GFXMMU_S_GFXMMU_LUT663L  \ offset: 0x24B8 : GFXMMU LUT entry 663 low
$580324bc constant GFXMMU_S_GFXMMU_LUT663H  \ offset: 0x24BC : GFXMMU LUT entry 663 high
$580324c0 constant GFXMMU_S_GFXMMU_LUT664L  \ offset: 0x24C0 : GFXMMU LUT entry 664 low
$580324c4 constant GFXMMU_S_GFXMMU_LUT664H  \ offset: 0x24C4 : GFXMMU LUT entry 664 high
$580324c8 constant GFXMMU_S_GFXMMU_LUT665L  \ offset: 0x24C8 : GFXMMU LUT entry 665 low
$580324cc constant GFXMMU_S_GFXMMU_LUT665H  \ offset: 0x24CC : GFXMMU LUT entry 665 high
$580324d0 constant GFXMMU_S_GFXMMU_LUT666L  \ offset: 0x24D0 : GFXMMU LUT entry 666 low
$580324d4 constant GFXMMU_S_GFXMMU_LUT666H  \ offset: 0x24D4 : GFXMMU LUT entry 666 high
$580324d8 constant GFXMMU_S_GFXMMU_LUT667L  \ offset: 0x24D8 : GFXMMU LUT entry 667 low
$580324dc constant GFXMMU_S_GFXMMU_LUT667H  \ offset: 0x24DC : GFXMMU LUT entry 667 high
$580324e0 constant GFXMMU_S_GFXMMU_LUT668L  \ offset: 0x24E0 : GFXMMU LUT entry 668 low
$580324e4 constant GFXMMU_S_GFXMMU_LUT668H  \ offset: 0x24E4 : GFXMMU LUT entry 668 high
$580324e8 constant GFXMMU_S_GFXMMU_LUT669L  \ offset: 0x24E8 : GFXMMU LUT entry 669 low
$580324ec constant GFXMMU_S_GFXMMU_LUT669H  \ offset: 0x24EC : GFXMMU LUT entry 669 high
$580324f0 constant GFXMMU_S_GFXMMU_LUT670L  \ offset: 0x24F0 : GFXMMU LUT entry 670 low
$580324f4 constant GFXMMU_S_GFXMMU_LUT670H  \ offset: 0x24F4 : GFXMMU LUT entry 670 high
$580324f8 constant GFXMMU_S_GFXMMU_LUT671L  \ offset: 0x24F8 : GFXMMU LUT entry 671 low
$580324fc constant GFXMMU_S_GFXMMU_LUT671H  \ offset: 0x24FC : GFXMMU LUT entry 671 high
$58032500 constant GFXMMU_S_GFXMMU_LUT672L  \ offset: 0x2500 : GFXMMU LUT entry 672 low
$58032504 constant GFXMMU_S_GFXMMU_LUT672H  \ offset: 0x2504 : GFXMMU LUT entry 672 high
$58032508 constant GFXMMU_S_GFXMMU_LUT673L  \ offset: 0x2508 : GFXMMU LUT entry 673 low
$5803250c constant GFXMMU_S_GFXMMU_LUT673H  \ offset: 0x250C : GFXMMU LUT entry 673 high
$58032510 constant GFXMMU_S_GFXMMU_LUT674L  \ offset: 0x2510 : GFXMMU LUT entry 674 low
$58032514 constant GFXMMU_S_GFXMMU_LUT674H  \ offset: 0x2514 : GFXMMU LUT entry 674 high
$58032518 constant GFXMMU_S_GFXMMU_LUT675L  \ offset: 0x2518 : GFXMMU LUT entry 675 low
$5803251c constant GFXMMU_S_GFXMMU_LUT675H  \ offset: 0x251C : GFXMMU LUT entry 675 high
$58032520 constant GFXMMU_S_GFXMMU_LUT676L  \ offset: 0x2520 : GFXMMU LUT entry 676 low
$58032524 constant GFXMMU_S_GFXMMU_LUT676H  \ offset: 0x2524 : GFXMMU LUT entry 676 high
$58032528 constant GFXMMU_S_GFXMMU_LUT677L  \ offset: 0x2528 : GFXMMU LUT entry 677 low
$5803252c constant GFXMMU_S_GFXMMU_LUT677H  \ offset: 0x252C : GFXMMU LUT entry 677 high
$58032530 constant GFXMMU_S_GFXMMU_LUT678L  \ offset: 0x2530 : GFXMMU LUT entry 678 low
$58032534 constant GFXMMU_S_GFXMMU_LUT678H  \ offset: 0x2534 : GFXMMU LUT entry 678 high
$58032538 constant GFXMMU_S_GFXMMU_LUT679L  \ offset: 0x2538 : GFXMMU LUT entry 679 low
$5803253c constant GFXMMU_S_GFXMMU_LUT679H  \ offset: 0x253C : GFXMMU LUT entry 679 high
$58032540 constant GFXMMU_S_GFXMMU_LUT680L  \ offset: 0x2540 : GFXMMU LUT entry 680 low
$58032544 constant GFXMMU_S_GFXMMU_LUT680H  \ offset: 0x2544 : GFXMMU LUT entry 680 high
$58032548 constant GFXMMU_S_GFXMMU_LUT681L  \ offset: 0x2548 : GFXMMU LUT entry 681 low
$5803254c constant GFXMMU_S_GFXMMU_LUT681H  \ offset: 0x254C : GFXMMU LUT entry 681 high
$58032550 constant GFXMMU_S_GFXMMU_LUT682L  \ offset: 0x2550 : GFXMMU LUT entry 682 low
$58032554 constant GFXMMU_S_GFXMMU_LUT682H  \ offset: 0x2554 : GFXMMU LUT entry 682 high
$58032558 constant GFXMMU_S_GFXMMU_LUT683L  \ offset: 0x2558 : GFXMMU LUT entry 683 low
$5803255c constant GFXMMU_S_GFXMMU_LUT683H  \ offset: 0x255C : GFXMMU LUT entry 683 high
$58032560 constant GFXMMU_S_GFXMMU_LUT684L  \ offset: 0x2560 : GFXMMU LUT entry 684 low
$58032564 constant GFXMMU_S_GFXMMU_LUT684H  \ offset: 0x2564 : GFXMMU LUT entry 684 high
$58032568 constant GFXMMU_S_GFXMMU_LUT685L  \ offset: 0x2568 : GFXMMU LUT entry 685 low
$5803256c constant GFXMMU_S_GFXMMU_LUT685H  \ offset: 0x256C : GFXMMU LUT entry 685 high
$58032570 constant GFXMMU_S_GFXMMU_LUT686L  \ offset: 0x2570 : GFXMMU LUT entry 686 low
$58032574 constant GFXMMU_S_GFXMMU_LUT686H  \ offset: 0x2574 : GFXMMU LUT entry 686 high
$58032578 constant GFXMMU_S_GFXMMU_LUT687L  \ offset: 0x2578 : GFXMMU LUT entry 687 low
$5803257c constant GFXMMU_S_GFXMMU_LUT687H  \ offset: 0x257C : GFXMMU LUT entry 687 high
$58032580 constant GFXMMU_S_GFXMMU_LUT688L  \ offset: 0x2580 : GFXMMU LUT entry 688 low
$58032584 constant GFXMMU_S_GFXMMU_LUT688H  \ offset: 0x2584 : GFXMMU LUT entry 688 high
$58032588 constant GFXMMU_S_GFXMMU_LUT689L  \ offset: 0x2588 : GFXMMU LUT entry 689 low
$5803258c constant GFXMMU_S_GFXMMU_LUT689H  \ offset: 0x258C : GFXMMU LUT entry 689 high
$58032590 constant GFXMMU_S_GFXMMU_LUT690L  \ offset: 0x2590 : GFXMMU LUT entry 690 low
$58032594 constant GFXMMU_S_GFXMMU_LUT690H  \ offset: 0x2594 : GFXMMU LUT entry 690 high
$58032598 constant GFXMMU_S_GFXMMU_LUT691L  \ offset: 0x2598 : GFXMMU LUT entry 691 low
$5803259c constant GFXMMU_S_GFXMMU_LUT691H  \ offset: 0x259C : GFXMMU LUT entry 691 high
$580325a0 constant GFXMMU_S_GFXMMU_LUT692L  \ offset: 0x25A0 : GFXMMU LUT entry 692 low
$580325a4 constant GFXMMU_S_GFXMMU_LUT692H  \ offset: 0x25A4 : GFXMMU LUT entry 692 high
$580325a8 constant GFXMMU_S_GFXMMU_LUT693L  \ offset: 0x25A8 : GFXMMU LUT entry 693 low
$580325ac constant GFXMMU_S_GFXMMU_LUT693H  \ offset: 0x25AC : GFXMMU LUT entry 693 high
$580325b0 constant GFXMMU_S_GFXMMU_LUT694L  \ offset: 0x25B0 : GFXMMU LUT entry 694 low
$580325b4 constant GFXMMU_S_GFXMMU_LUT694H  \ offset: 0x25B4 : GFXMMU LUT entry 694 high
$580325b8 constant GFXMMU_S_GFXMMU_LUT695L  \ offset: 0x25B8 : GFXMMU LUT entry 695 low
$580325bc constant GFXMMU_S_GFXMMU_LUT695H  \ offset: 0x25BC : GFXMMU LUT entry 695 high
$580325c0 constant GFXMMU_S_GFXMMU_LUT696L  \ offset: 0x25C0 : GFXMMU LUT entry 696 low
$580325c4 constant GFXMMU_S_GFXMMU_LUT696H  \ offset: 0x25C4 : GFXMMU LUT entry 696 high
$580325c8 constant GFXMMU_S_GFXMMU_LUT697L  \ offset: 0x25C8 : GFXMMU LUT entry 697 low
$580325cc constant GFXMMU_S_GFXMMU_LUT697H  \ offset: 0x25CC : GFXMMU LUT entry 697 high
$580325d0 constant GFXMMU_S_GFXMMU_LUT698L  \ offset: 0x25D0 : GFXMMU LUT entry 698 low
$580325d4 constant GFXMMU_S_GFXMMU_LUT698H  \ offset: 0x25D4 : GFXMMU LUT entry 698 high
$580325d8 constant GFXMMU_S_GFXMMU_LUT699L  \ offset: 0x25D8 : GFXMMU LUT entry 699 low
$580325dc constant GFXMMU_S_GFXMMU_LUT699H  \ offset: 0x25DC : GFXMMU LUT entry 699 high
$580325e0 constant GFXMMU_S_GFXMMU_LUT700L  \ offset: 0x25E0 : GFXMMU LUT entry 700 low
$580325e4 constant GFXMMU_S_GFXMMU_LUT700H  \ offset: 0x25E4 : GFXMMU LUT entry 700 high
$580325e8 constant GFXMMU_S_GFXMMU_LUT701L  \ offset: 0x25E8 : GFXMMU LUT entry 701 low
$580325ec constant GFXMMU_S_GFXMMU_LUT701H  \ offset: 0x25EC : GFXMMU LUT entry 701 high
$580325f0 constant GFXMMU_S_GFXMMU_LUT702L  \ offset: 0x25F0 : GFXMMU LUT entry 702 low
$580325f4 constant GFXMMU_S_GFXMMU_LUT702H  \ offset: 0x25F4 : GFXMMU LUT entry 702 high
$580325f8 constant GFXMMU_S_GFXMMU_LUT703L  \ offset: 0x25F8 : GFXMMU LUT entry 703 low
$580325fc constant GFXMMU_S_GFXMMU_LUT703H  \ offset: 0x25FC : GFXMMU LUT entry 703 high
$58032600 constant GFXMMU_S_GFXMMU_LUT704L  \ offset: 0x2600 : GFXMMU LUT entry 704 low
$58032604 constant GFXMMU_S_GFXMMU_LUT704H  \ offset: 0x2604 : GFXMMU LUT entry 704 high
$58032608 constant GFXMMU_S_GFXMMU_LUT705L  \ offset: 0x2608 : GFXMMU LUT entry 705 low
$5803260c constant GFXMMU_S_GFXMMU_LUT705H  \ offset: 0x260C : GFXMMU LUT entry 705 high
$58032610 constant GFXMMU_S_GFXMMU_LUT706L  \ offset: 0x2610 : GFXMMU LUT entry 706 low
$58032614 constant GFXMMU_S_GFXMMU_LUT706H  \ offset: 0x2614 : GFXMMU LUT entry 706 high
$58032618 constant GFXMMU_S_GFXMMU_LUT707L  \ offset: 0x2618 : GFXMMU LUT entry 707 low
$5803261c constant GFXMMU_S_GFXMMU_LUT707H  \ offset: 0x261C : GFXMMU LUT entry 707 high
$58032620 constant GFXMMU_S_GFXMMU_LUT708L  \ offset: 0x2620 : GFXMMU LUT entry 708 low
$58032624 constant GFXMMU_S_GFXMMU_LUT708H  \ offset: 0x2624 : GFXMMU LUT entry 708 high
$58032628 constant GFXMMU_S_GFXMMU_LUT709L  \ offset: 0x2628 : GFXMMU LUT entry 709 low
$5803262c constant GFXMMU_S_GFXMMU_LUT709H  \ offset: 0x262C : GFXMMU LUT entry 709 high
$58032630 constant GFXMMU_S_GFXMMU_LUT710L  \ offset: 0x2630 : GFXMMU LUT entry 710 low
$58032634 constant GFXMMU_S_GFXMMU_LUT710H  \ offset: 0x2634 : GFXMMU LUT entry 710 high
$58032638 constant GFXMMU_S_GFXMMU_LUT711L  \ offset: 0x2638 : GFXMMU LUT entry 711 low
$5803263c constant GFXMMU_S_GFXMMU_LUT711H  \ offset: 0x263C : GFXMMU LUT entry 711 high
$58032640 constant GFXMMU_S_GFXMMU_LUT712L  \ offset: 0x2640 : GFXMMU LUT entry 712 low
$58032644 constant GFXMMU_S_GFXMMU_LUT712H  \ offset: 0x2644 : GFXMMU LUT entry 712 high
$58032648 constant GFXMMU_S_GFXMMU_LUT713L  \ offset: 0x2648 : GFXMMU LUT entry 713 low
$5803264c constant GFXMMU_S_GFXMMU_LUT713H  \ offset: 0x264C : GFXMMU LUT entry 713 high
$58032650 constant GFXMMU_S_GFXMMU_LUT714L  \ offset: 0x2650 : GFXMMU LUT entry 714 low
$58032654 constant GFXMMU_S_GFXMMU_LUT714H  \ offset: 0x2654 : GFXMMU LUT entry 714 high
$58032658 constant GFXMMU_S_GFXMMU_LUT715L  \ offset: 0x2658 : GFXMMU LUT entry 715 low
$5803265c constant GFXMMU_S_GFXMMU_LUT715H  \ offset: 0x265C : GFXMMU LUT entry 715 high
$58032660 constant GFXMMU_S_GFXMMU_LUT716L  \ offset: 0x2660 : GFXMMU LUT entry 716 low
$58032664 constant GFXMMU_S_GFXMMU_LUT716H  \ offset: 0x2664 : GFXMMU LUT entry 716 high
$58032668 constant GFXMMU_S_GFXMMU_LUT717L  \ offset: 0x2668 : GFXMMU LUT entry 717 low
$5803266c constant GFXMMU_S_GFXMMU_LUT717H  \ offset: 0x266C : GFXMMU LUT entry 717 high
$58032670 constant GFXMMU_S_GFXMMU_LUT718L  \ offset: 0x2670 : GFXMMU LUT entry 718 low
$58032674 constant GFXMMU_S_GFXMMU_LUT718H  \ offset: 0x2674 : GFXMMU LUT entry 718 high
$58032678 constant GFXMMU_S_GFXMMU_LUT719L  \ offset: 0x2678 : GFXMMU LUT entry 719 low
$5803267c constant GFXMMU_S_GFXMMU_LUT719H  \ offset: 0x267C : GFXMMU LUT entry 719 high
$58032680 constant GFXMMU_S_GFXMMU_LUT720L  \ offset: 0x2680 : GFXMMU LUT entry 720 low
$58032684 constant GFXMMU_S_GFXMMU_LUT720H  \ offset: 0x2684 : GFXMMU LUT entry 720 high
$58032688 constant GFXMMU_S_GFXMMU_LUT721L  \ offset: 0x2688 : GFXMMU LUT entry 721 low
$5803268c constant GFXMMU_S_GFXMMU_LUT721H  \ offset: 0x268C : GFXMMU LUT entry 721 high
$58032690 constant GFXMMU_S_GFXMMU_LUT722L  \ offset: 0x2690 : GFXMMU LUT entry 722 low
$58032694 constant GFXMMU_S_GFXMMU_LUT722H  \ offset: 0x2694 : GFXMMU LUT entry 722 high
$58032698 constant GFXMMU_S_GFXMMU_LUT723L  \ offset: 0x2698 : GFXMMU LUT entry 723 low
$5803269c constant GFXMMU_S_GFXMMU_LUT723H  \ offset: 0x269C : GFXMMU LUT entry 723 high
$580326a0 constant GFXMMU_S_GFXMMU_LUT724L  \ offset: 0x26A0 : GFXMMU LUT entry 724 low
$580326a4 constant GFXMMU_S_GFXMMU_LUT724H  \ offset: 0x26A4 : GFXMMU LUT entry 724 high
$580326a8 constant GFXMMU_S_GFXMMU_LUT725L  \ offset: 0x26A8 : GFXMMU LUT entry 725 low
$580326ac constant GFXMMU_S_GFXMMU_LUT725H  \ offset: 0x26AC : GFXMMU LUT entry 725 high
$580326b0 constant GFXMMU_S_GFXMMU_LUT726L  \ offset: 0x26B0 : GFXMMU LUT entry 726 low
$580326b4 constant GFXMMU_S_GFXMMU_LUT726H  \ offset: 0x26B4 : GFXMMU LUT entry 726 high
$580326b8 constant GFXMMU_S_GFXMMU_LUT727L  \ offset: 0x26B8 : GFXMMU LUT entry 727 low
$580326bc constant GFXMMU_S_GFXMMU_LUT727H  \ offset: 0x26BC : GFXMMU LUT entry 727 high
$580326c0 constant GFXMMU_S_GFXMMU_LUT728L  \ offset: 0x26C0 : GFXMMU LUT entry 728 low
$580326c4 constant GFXMMU_S_GFXMMU_LUT728H  \ offset: 0x26C4 : GFXMMU LUT entry 728 high
$580326c8 constant GFXMMU_S_GFXMMU_LUT729L  \ offset: 0x26C8 : GFXMMU LUT entry 729 low
$580326cc constant GFXMMU_S_GFXMMU_LUT729H  \ offset: 0x26CC : GFXMMU LUT entry 729 high
$580326d0 constant GFXMMU_S_GFXMMU_LUT730L  \ offset: 0x26D0 : GFXMMU LUT entry 730 low
$580326d4 constant GFXMMU_S_GFXMMU_LUT730H  \ offset: 0x26D4 : GFXMMU LUT entry 730 high
$580326d8 constant GFXMMU_S_GFXMMU_LUT731L  \ offset: 0x26D8 : GFXMMU LUT entry 731 low
$580326dc constant GFXMMU_S_GFXMMU_LUT731H  \ offset: 0x26DC : GFXMMU LUT entry 731 high
$580326e0 constant GFXMMU_S_GFXMMU_LUT732L  \ offset: 0x26E0 : GFXMMU LUT entry 732 low
$580326e4 constant GFXMMU_S_GFXMMU_LUT732H  \ offset: 0x26E4 : GFXMMU LUT entry 732 high
$580326e8 constant GFXMMU_S_GFXMMU_LUT733L  \ offset: 0x26E8 : GFXMMU LUT entry 733 low
$580326ec constant GFXMMU_S_GFXMMU_LUT733H  \ offset: 0x26EC : GFXMMU LUT entry 733 high
$580326f0 constant GFXMMU_S_GFXMMU_LUT734L  \ offset: 0x26F0 : GFXMMU LUT entry 734 low
$580326f4 constant GFXMMU_S_GFXMMU_LUT734H  \ offset: 0x26F4 : GFXMMU LUT entry 734 high
$580326f8 constant GFXMMU_S_GFXMMU_LUT735L  \ offset: 0x26F8 : GFXMMU LUT entry 735 low
$580326fc constant GFXMMU_S_GFXMMU_LUT735H  \ offset: 0x26FC : GFXMMU LUT entry 735 high
$58032700 constant GFXMMU_S_GFXMMU_LUT736L  \ offset: 0x2700 : GFXMMU LUT entry 736 low
$58032704 constant GFXMMU_S_GFXMMU_LUT736H  \ offset: 0x2704 : GFXMMU LUT entry 736 high
$58032708 constant GFXMMU_S_GFXMMU_LUT737L  \ offset: 0x2708 : GFXMMU LUT entry 737 low
$5803270c constant GFXMMU_S_GFXMMU_LUT737H  \ offset: 0x270C : GFXMMU LUT entry 737 high
$58032710 constant GFXMMU_S_GFXMMU_LUT738L  \ offset: 0x2710 : GFXMMU LUT entry 738 low
$58032714 constant GFXMMU_S_GFXMMU_LUT738H  \ offset: 0x2714 : GFXMMU LUT entry 738 high
$58032718 constant GFXMMU_S_GFXMMU_LUT739L  \ offset: 0x2718 : GFXMMU LUT entry 739 low
$5803271c constant GFXMMU_S_GFXMMU_LUT739H  \ offset: 0x271C : GFXMMU LUT entry 739 high
$58032720 constant GFXMMU_S_GFXMMU_LUT740L  \ offset: 0x2720 : GFXMMU LUT entry 740 low
$58032724 constant GFXMMU_S_GFXMMU_LUT740H  \ offset: 0x2724 : GFXMMU LUT entry 740 high
$58032728 constant GFXMMU_S_GFXMMU_LUT741L  \ offset: 0x2728 : GFXMMU LUT entry 741 low
$5803272c constant GFXMMU_S_GFXMMU_LUT741H  \ offset: 0x272C : GFXMMU LUT entry 741 high
$58032730 constant GFXMMU_S_GFXMMU_LUT742L  \ offset: 0x2730 : GFXMMU LUT entry 742 low
$58032734 constant GFXMMU_S_GFXMMU_LUT742H  \ offset: 0x2734 : GFXMMU LUT entry 742 high
$58032738 constant GFXMMU_S_GFXMMU_LUT743L  \ offset: 0x2738 : GFXMMU LUT entry 743 low
$5803273c constant GFXMMU_S_GFXMMU_LUT743H  \ offset: 0x273C : GFXMMU LUT entry 743 high
$58032740 constant GFXMMU_S_GFXMMU_LUT744L  \ offset: 0x2740 : GFXMMU LUT entry 744 low
$58032744 constant GFXMMU_S_GFXMMU_LUT744H  \ offset: 0x2744 : GFXMMU LUT entry 744 high
$58032748 constant GFXMMU_S_GFXMMU_LUT745L  \ offset: 0x2748 : GFXMMU LUT entry 745 low
$5803274c constant GFXMMU_S_GFXMMU_LUT745H  \ offset: 0x274C : GFXMMU LUT entry 745 high
$58032750 constant GFXMMU_S_GFXMMU_LUT746L  \ offset: 0x2750 : GFXMMU LUT entry 746 low
$58032754 constant GFXMMU_S_GFXMMU_LUT746H  \ offset: 0x2754 : GFXMMU LUT entry 746 high
$58032758 constant GFXMMU_S_GFXMMU_LUT747L  \ offset: 0x2758 : GFXMMU LUT entry 747 low
$5803275c constant GFXMMU_S_GFXMMU_LUT747H  \ offset: 0x275C : GFXMMU LUT entry 747 high
$58032760 constant GFXMMU_S_GFXMMU_LUT748L  \ offset: 0x2760 : GFXMMU LUT entry 748 low
$58032764 constant GFXMMU_S_GFXMMU_LUT748H  \ offset: 0x2764 : GFXMMU LUT entry 748 high
$58032768 constant GFXMMU_S_GFXMMU_LUT749L  \ offset: 0x2768 : GFXMMU LUT entry 749 low
$5803276c constant GFXMMU_S_GFXMMU_LUT749H  \ offset: 0x276C : GFXMMU LUT entry 749 high
$58032770 constant GFXMMU_S_GFXMMU_LUT750L  \ offset: 0x2770 : GFXMMU LUT entry 750 low
$58032774 constant GFXMMU_S_GFXMMU_LUT750H  \ offset: 0x2774 : GFXMMU LUT entry 750 high
$58032778 constant GFXMMU_S_GFXMMU_LUT751L  \ offset: 0x2778 : GFXMMU LUT entry 751 low
$5803277c constant GFXMMU_S_GFXMMU_LUT751H  \ offset: 0x277C : GFXMMU LUT entry 751 high
$58032780 constant GFXMMU_S_GFXMMU_LUT752L  \ offset: 0x2780 : GFXMMU LUT entry 752 low
$58032784 constant GFXMMU_S_GFXMMU_LUT752H  \ offset: 0x2784 : GFXMMU LUT entry 752 high
$58032788 constant GFXMMU_S_GFXMMU_LUT753L  \ offset: 0x2788 : GFXMMU LUT entry 753 low
$5803278c constant GFXMMU_S_GFXMMU_LUT753H  \ offset: 0x278C : GFXMMU LUT entry 753 high
$58032790 constant GFXMMU_S_GFXMMU_LUT754L  \ offset: 0x2790 : GFXMMU LUT entry 754 low
$58032794 constant GFXMMU_S_GFXMMU_LUT754H  \ offset: 0x2794 : GFXMMU LUT entry 754 high
$58032798 constant GFXMMU_S_GFXMMU_LUT755L  \ offset: 0x2798 : GFXMMU LUT entry 755 low
$5803279c constant GFXMMU_S_GFXMMU_LUT755H  \ offset: 0x279C : GFXMMU LUT entry 755 high
$580327a0 constant GFXMMU_S_GFXMMU_LUT756L  \ offset: 0x27A0 : GFXMMU LUT entry 756 low
$580327a4 constant GFXMMU_S_GFXMMU_LUT756H  \ offset: 0x27A4 : GFXMMU LUT entry 756 high
$580327a8 constant GFXMMU_S_GFXMMU_LUT757L  \ offset: 0x27A8 : GFXMMU LUT entry 757 low
$580327ac constant GFXMMU_S_GFXMMU_LUT757H  \ offset: 0x27AC : GFXMMU LUT entry 757 high
$580327b0 constant GFXMMU_S_GFXMMU_LUT758L  \ offset: 0x27B0 : GFXMMU LUT entry 758 low
$580327b4 constant GFXMMU_S_GFXMMU_LUT758H  \ offset: 0x27B4 : GFXMMU LUT entry 758 high
$580327b8 constant GFXMMU_S_GFXMMU_LUT759L  \ offset: 0x27B8 : GFXMMU LUT entry 759 low
$580327bc constant GFXMMU_S_GFXMMU_LUT759H  \ offset: 0x27BC : GFXMMU LUT entry 759 high
$580327c0 constant GFXMMU_S_GFXMMU_LUT760L  \ offset: 0x27C0 : GFXMMU LUT entry 760 low
$580327c4 constant GFXMMU_S_GFXMMU_LUT760H  \ offset: 0x27C4 : GFXMMU LUT entry 760 high
$580327c8 constant GFXMMU_S_GFXMMU_LUT761L  \ offset: 0x27C8 : GFXMMU LUT entry 761 low
$580327cc constant GFXMMU_S_GFXMMU_LUT761H  \ offset: 0x27CC : GFXMMU LUT entry 761 high
$580327d0 constant GFXMMU_S_GFXMMU_LUT762L  \ offset: 0x27D0 : GFXMMU LUT entry 762 low
$580327d4 constant GFXMMU_S_GFXMMU_LUT762H  \ offset: 0x27D4 : GFXMMU LUT entry 762 high
$580327d8 constant GFXMMU_S_GFXMMU_LUT763L  \ offset: 0x27D8 : GFXMMU LUT entry 763 low
$580327dc constant GFXMMU_S_GFXMMU_LUT763H  \ offset: 0x27DC : GFXMMU LUT entry 763 high
$580327e0 constant GFXMMU_S_GFXMMU_LUT764L  \ offset: 0x27E0 : GFXMMU LUT entry 764 low
$580327e4 constant GFXMMU_S_GFXMMU_LUT764H  \ offset: 0x27E4 : GFXMMU LUT entry 764 high
$580327e8 constant GFXMMU_S_GFXMMU_LUT765L  \ offset: 0x27E8 : GFXMMU LUT entry 765 low
$580327ec constant GFXMMU_S_GFXMMU_LUT765H  \ offset: 0x27EC : GFXMMU LUT entry 765 high
$580327f0 constant GFXMMU_S_GFXMMU_LUT766L  \ offset: 0x27F0 : GFXMMU LUT entry 766 low
$580327f4 constant GFXMMU_S_GFXMMU_LUT766H  \ offset: 0x27F4 : GFXMMU LUT entry 766 high
$580327f8 constant GFXMMU_S_GFXMMU_LUT767L  \ offset: 0x27F8 : GFXMMU LUT entry 767 low
$580327fc constant GFXMMU_S_GFXMMU_LUT767H  \ offset: 0x27FC : GFXMMU LUT entry 767 high
$58032800 constant GFXMMU_S_GFXMMU_LUT768L  \ offset: 0x2800 : GFXMMU LUT entry 768 low
$58032804 constant GFXMMU_S_GFXMMU_LUT768H  \ offset: 0x2804 : GFXMMU LUT entry 768 high
$58032808 constant GFXMMU_S_GFXMMU_LUT769L  \ offset: 0x2808 : GFXMMU LUT entry 769 low
$5803280c constant GFXMMU_S_GFXMMU_LUT769H  \ offset: 0x280C : GFXMMU LUT entry 769 high
$58032810 constant GFXMMU_S_GFXMMU_LUT770L  \ offset: 0x2810 : GFXMMU LUT entry 770 low
$58032814 constant GFXMMU_S_GFXMMU_LUT770H  \ offset: 0x2814 : GFXMMU LUT entry 770 high
$58032818 constant GFXMMU_S_GFXMMU_LUT771L  \ offset: 0x2818 : GFXMMU LUT entry 771 low
$5803281c constant GFXMMU_S_GFXMMU_LUT771H  \ offset: 0x281C : GFXMMU LUT entry 771 high
$58032820 constant GFXMMU_S_GFXMMU_LUT772L  \ offset: 0x2820 : GFXMMU LUT entry 772 low
$58032824 constant GFXMMU_S_GFXMMU_LUT772H  \ offset: 0x2824 : GFXMMU LUT entry 772 high
$58032828 constant GFXMMU_S_GFXMMU_LUT773L  \ offset: 0x2828 : GFXMMU LUT entry 773 low
$5803282c constant GFXMMU_S_GFXMMU_LUT773H  \ offset: 0x282C : GFXMMU LUT entry 773 high
$58032830 constant GFXMMU_S_GFXMMU_LUT774L  \ offset: 0x2830 : GFXMMU LUT entry 774 low
$58032834 constant GFXMMU_S_GFXMMU_LUT774H  \ offset: 0x2834 : GFXMMU LUT entry 774 high
$58032838 constant GFXMMU_S_GFXMMU_LUT775L  \ offset: 0x2838 : GFXMMU LUT entry 775 low
$5803283c constant GFXMMU_S_GFXMMU_LUT775H  \ offset: 0x283C : GFXMMU LUT entry 775 high
$58032840 constant GFXMMU_S_GFXMMU_LUT776L  \ offset: 0x2840 : GFXMMU LUT entry 776 low
$58032844 constant GFXMMU_S_GFXMMU_LUT776H  \ offset: 0x2844 : GFXMMU LUT entry 776 high
$58032848 constant GFXMMU_S_GFXMMU_LUT777L  \ offset: 0x2848 : GFXMMU LUT entry 777 low
$5803284c constant GFXMMU_S_GFXMMU_LUT777H  \ offset: 0x284C : GFXMMU LUT entry 777 high
$58032850 constant GFXMMU_S_GFXMMU_LUT778L  \ offset: 0x2850 : GFXMMU LUT entry 778 low
$58032854 constant GFXMMU_S_GFXMMU_LUT778H  \ offset: 0x2854 : GFXMMU LUT entry 778 high
$58032858 constant GFXMMU_S_GFXMMU_LUT779L  \ offset: 0x2858 : GFXMMU LUT entry 779 low
$5803285c constant GFXMMU_S_GFXMMU_LUT779H  \ offset: 0x285C : GFXMMU LUT entry 779 high
$58032860 constant GFXMMU_S_GFXMMU_LUT780L  \ offset: 0x2860 : GFXMMU LUT entry 780 low
$58032864 constant GFXMMU_S_GFXMMU_LUT780H  \ offset: 0x2864 : GFXMMU LUT entry 780 high
$58032868 constant GFXMMU_S_GFXMMU_LUT781L  \ offset: 0x2868 : GFXMMU LUT entry 781 low
$5803286c constant GFXMMU_S_GFXMMU_LUT781H  \ offset: 0x286C : GFXMMU LUT entry 781 high
$58032870 constant GFXMMU_S_GFXMMU_LUT782L  \ offset: 0x2870 : GFXMMU LUT entry 782 low
$58032874 constant GFXMMU_S_GFXMMU_LUT782H  \ offset: 0x2874 : GFXMMU LUT entry 782 high
$58032878 constant GFXMMU_S_GFXMMU_LUT783L  \ offset: 0x2878 : GFXMMU LUT entry 783 low
$5803287c constant GFXMMU_S_GFXMMU_LUT783H  \ offset: 0x287C : GFXMMU LUT entry 783 high
$58032880 constant GFXMMU_S_GFXMMU_LUT784L  \ offset: 0x2880 : GFXMMU LUT entry 784 low
$58032884 constant GFXMMU_S_GFXMMU_LUT784H  \ offset: 0x2884 : GFXMMU LUT entry 784 high
$58032888 constant GFXMMU_S_GFXMMU_LUT785L  \ offset: 0x2888 : GFXMMU LUT entry 785 low
$5803288c constant GFXMMU_S_GFXMMU_LUT785H  \ offset: 0x288C : GFXMMU LUT entry 785 high
$58032890 constant GFXMMU_S_GFXMMU_LUT786L  \ offset: 0x2890 : GFXMMU LUT entry 786 low
$58032894 constant GFXMMU_S_GFXMMU_LUT786H  \ offset: 0x2894 : GFXMMU LUT entry 786 high
$58032898 constant GFXMMU_S_GFXMMU_LUT787L  \ offset: 0x2898 : GFXMMU LUT entry 787 low
$5803289c constant GFXMMU_S_GFXMMU_LUT787H  \ offset: 0x289C : GFXMMU LUT entry 787 high
$580328a0 constant GFXMMU_S_GFXMMU_LUT788L  \ offset: 0x28A0 : GFXMMU LUT entry 788 low
$580328a4 constant GFXMMU_S_GFXMMU_LUT788H  \ offset: 0x28A4 : GFXMMU LUT entry 788 high
$580328a8 constant GFXMMU_S_GFXMMU_LUT789L  \ offset: 0x28A8 : GFXMMU LUT entry 789 low
$580328ac constant GFXMMU_S_GFXMMU_LUT789H  \ offset: 0x28AC : GFXMMU LUT entry 789 high
$580328b0 constant GFXMMU_S_GFXMMU_LUT790L  \ offset: 0x28B0 : GFXMMU LUT entry 790 low
$580328b4 constant GFXMMU_S_GFXMMU_LUT790H  \ offset: 0x28B4 : GFXMMU LUT entry 790 high
$580328b8 constant GFXMMU_S_GFXMMU_LUT791L  \ offset: 0x28B8 : GFXMMU LUT entry 791 low
$580328bc constant GFXMMU_S_GFXMMU_LUT791H  \ offset: 0x28BC : GFXMMU LUT entry 791 high
$580328c0 constant GFXMMU_S_GFXMMU_LUT792L  \ offset: 0x28C0 : GFXMMU LUT entry 792 low
$580328c4 constant GFXMMU_S_GFXMMU_LUT792H  \ offset: 0x28C4 : GFXMMU LUT entry 792 high
$580328c8 constant GFXMMU_S_GFXMMU_LUT793L  \ offset: 0x28C8 : GFXMMU LUT entry 793 low
$580328cc constant GFXMMU_S_GFXMMU_LUT793H  \ offset: 0x28CC : GFXMMU LUT entry 793 high
$580328d0 constant GFXMMU_S_GFXMMU_LUT794L  \ offset: 0x28D0 : GFXMMU LUT entry 794 low
$580328d4 constant GFXMMU_S_GFXMMU_LUT794H  \ offset: 0x28D4 : GFXMMU LUT entry 794 high
$580328d8 constant GFXMMU_S_GFXMMU_LUT795L  \ offset: 0x28D8 : GFXMMU LUT entry 795 low
$580328dc constant GFXMMU_S_GFXMMU_LUT795H  \ offset: 0x28DC : GFXMMU LUT entry 795 high
$580328e0 constant GFXMMU_S_GFXMMU_LUT796L  \ offset: 0x28E0 : GFXMMU LUT entry 796 low
$580328e4 constant GFXMMU_S_GFXMMU_LUT796H  \ offset: 0x28E4 : GFXMMU LUT entry 796 high
$580328e8 constant GFXMMU_S_GFXMMU_LUT797L  \ offset: 0x28E8 : GFXMMU LUT entry 797 low
$580328ec constant GFXMMU_S_GFXMMU_LUT797H  \ offset: 0x28EC : GFXMMU LUT entry 797 high
$580328f0 constant GFXMMU_S_GFXMMU_LUT798L  \ offset: 0x28F0 : GFXMMU LUT entry 798 low
$580328f4 constant GFXMMU_S_GFXMMU_LUT798H  \ offset: 0x28F4 : GFXMMU LUT entry 798 high
$580328f8 constant GFXMMU_S_GFXMMU_LUT799L  \ offset: 0x28F8 : GFXMMU LUT entry 799 low
$580328fc constant GFXMMU_S_GFXMMU_LUT799H  \ offset: 0x28FC : GFXMMU LUT entry 799 high
$58032900 constant GFXMMU_S_GFXMMU_LUT800L  \ offset: 0x2900 : GFXMMU LUT entry 800 low
$58032904 constant GFXMMU_S_GFXMMU_LUT800H  \ offset: 0x2904 : GFXMMU LUT entry 800 high
$58032908 constant GFXMMU_S_GFXMMU_LUT801L  \ offset: 0x2908 : GFXMMU LUT entry 801 low
$5803290c constant GFXMMU_S_GFXMMU_LUT801H  \ offset: 0x290C : GFXMMU LUT entry 801 high
$58032910 constant GFXMMU_S_GFXMMU_LUT802L  \ offset: 0x2910 : GFXMMU LUT entry 802 low
$58032914 constant GFXMMU_S_GFXMMU_LUT802H  \ offset: 0x2914 : GFXMMU LUT entry 802 high
$58032918 constant GFXMMU_S_GFXMMU_LUT803L  \ offset: 0x2918 : GFXMMU LUT entry 803 low
$5803291c constant GFXMMU_S_GFXMMU_LUT803H  \ offset: 0x291C : GFXMMU LUT entry 803 high
$58032920 constant GFXMMU_S_GFXMMU_LUT804L  \ offset: 0x2920 : GFXMMU LUT entry 804 low
$58032924 constant GFXMMU_S_GFXMMU_LUT804H  \ offset: 0x2924 : GFXMMU LUT entry 804 high
$58032928 constant GFXMMU_S_GFXMMU_LUT805L  \ offset: 0x2928 : GFXMMU LUT entry 805 low
$5803292c constant GFXMMU_S_GFXMMU_LUT805H  \ offset: 0x292C : GFXMMU LUT entry 805 high
$58032930 constant GFXMMU_S_GFXMMU_LUT806L  \ offset: 0x2930 : GFXMMU LUT entry 806 low
$58032934 constant GFXMMU_S_GFXMMU_LUT806H  \ offset: 0x2934 : GFXMMU LUT entry 806 high
$58032938 constant GFXMMU_S_GFXMMU_LUT807L  \ offset: 0x2938 : GFXMMU LUT entry 807 low
$5803293c constant GFXMMU_S_GFXMMU_LUT807H  \ offset: 0x293C : GFXMMU LUT entry 807 high
$58032940 constant GFXMMU_S_GFXMMU_LUT808L  \ offset: 0x2940 : GFXMMU LUT entry 808 low
$58032944 constant GFXMMU_S_GFXMMU_LUT808H  \ offset: 0x2944 : GFXMMU LUT entry 808 high
$58032948 constant GFXMMU_S_GFXMMU_LUT809L  \ offset: 0x2948 : GFXMMU LUT entry 809 low
$5803294c constant GFXMMU_S_GFXMMU_LUT809H  \ offset: 0x294C : GFXMMU LUT entry 809 high
$58032950 constant GFXMMU_S_GFXMMU_LUT810L  \ offset: 0x2950 : GFXMMU LUT entry 810 low
$58032954 constant GFXMMU_S_GFXMMU_LUT810H  \ offset: 0x2954 : GFXMMU LUT entry 810 high
$58032958 constant GFXMMU_S_GFXMMU_LUT811L  \ offset: 0x2958 : GFXMMU LUT entry 811 low
$5803295c constant GFXMMU_S_GFXMMU_LUT811H  \ offset: 0x295C : GFXMMU LUT entry 811 high
$58032960 constant GFXMMU_S_GFXMMU_LUT812L  \ offset: 0x2960 : GFXMMU LUT entry 812 low
$58032964 constant GFXMMU_S_GFXMMU_LUT812H  \ offset: 0x2964 : GFXMMU LUT entry 812 high
$58032968 constant GFXMMU_S_GFXMMU_LUT813L  \ offset: 0x2968 : GFXMMU LUT entry 813 low
$5803296c constant GFXMMU_S_GFXMMU_LUT813H  \ offset: 0x296C : GFXMMU LUT entry 813 high
$58032970 constant GFXMMU_S_GFXMMU_LUT814L  \ offset: 0x2970 : GFXMMU LUT entry 814 low
$58032974 constant GFXMMU_S_GFXMMU_LUT814H  \ offset: 0x2974 : GFXMMU LUT entry 814 high
$58032978 constant GFXMMU_S_GFXMMU_LUT815L  \ offset: 0x2978 : GFXMMU LUT entry 815 low
$5803297c constant GFXMMU_S_GFXMMU_LUT815H  \ offset: 0x297C : GFXMMU LUT entry 815 high
$58032980 constant GFXMMU_S_GFXMMU_LUT816L  \ offset: 0x2980 : GFXMMU LUT entry 816 low
$58032984 constant GFXMMU_S_GFXMMU_LUT816H  \ offset: 0x2984 : GFXMMU LUT entry 816 high
$58032988 constant GFXMMU_S_GFXMMU_LUT817L  \ offset: 0x2988 : GFXMMU LUT entry 817 low
$5803298c constant GFXMMU_S_GFXMMU_LUT817H  \ offset: 0x298C : GFXMMU LUT entry 817 high
$58032990 constant GFXMMU_S_GFXMMU_LUT818L  \ offset: 0x2990 : GFXMMU LUT entry 818 low
$58032994 constant GFXMMU_S_GFXMMU_LUT818H  \ offset: 0x2994 : GFXMMU LUT entry 818 high
$58032998 constant GFXMMU_S_GFXMMU_LUT819L  \ offset: 0x2998 : GFXMMU LUT entry 819 low
$5803299c constant GFXMMU_S_GFXMMU_LUT819H  \ offset: 0x299C : GFXMMU LUT entry 819 high
$580329a0 constant GFXMMU_S_GFXMMU_LUT820L  \ offset: 0x29A0 : GFXMMU LUT entry 820 low
$580329a4 constant GFXMMU_S_GFXMMU_LUT820H  \ offset: 0x29A4 : GFXMMU LUT entry 820 high
$580329a8 constant GFXMMU_S_GFXMMU_LUT821L  \ offset: 0x29A8 : GFXMMU LUT entry 821 low
$580329ac constant GFXMMU_S_GFXMMU_LUT821H  \ offset: 0x29AC : GFXMMU LUT entry 821 high
$580329b0 constant GFXMMU_S_GFXMMU_LUT822L  \ offset: 0x29B0 : GFXMMU LUT entry 822 low
$580329b4 constant GFXMMU_S_GFXMMU_LUT822H  \ offset: 0x29B4 : GFXMMU LUT entry 822 high
$580329b8 constant GFXMMU_S_GFXMMU_LUT823L  \ offset: 0x29B8 : GFXMMU LUT entry 823 low
$580329bc constant GFXMMU_S_GFXMMU_LUT823H  \ offset: 0x29BC : GFXMMU LUT entry 823 high
$580329c0 constant GFXMMU_S_GFXMMU_LUT824L  \ offset: 0x29C0 : GFXMMU LUT entry 824 low
$580329c4 constant GFXMMU_S_GFXMMU_LUT824H  \ offset: 0x29C4 : GFXMMU LUT entry 824 high
$580329c8 constant GFXMMU_S_GFXMMU_LUT825L  \ offset: 0x29C8 : GFXMMU LUT entry 825 low
$580329cc constant GFXMMU_S_GFXMMU_LUT825H  \ offset: 0x29CC : GFXMMU LUT entry 825 high
$580329d0 constant GFXMMU_S_GFXMMU_LUT826L  \ offset: 0x29D0 : GFXMMU LUT entry 826 low
$580329d4 constant GFXMMU_S_GFXMMU_LUT826H  \ offset: 0x29D4 : GFXMMU LUT entry 826 high
$580329d8 constant GFXMMU_S_GFXMMU_LUT827L  \ offset: 0x29D8 : GFXMMU LUT entry 827 low
$580329dc constant GFXMMU_S_GFXMMU_LUT827H  \ offset: 0x29DC : GFXMMU LUT entry 827 high
$580329e0 constant GFXMMU_S_GFXMMU_LUT828L  \ offset: 0x29E0 : GFXMMU LUT entry 828 low
$580329e4 constant GFXMMU_S_GFXMMU_LUT828H  \ offset: 0x29E4 : GFXMMU LUT entry 828 high
$580329e8 constant GFXMMU_S_GFXMMU_LUT829L  \ offset: 0x29E8 : GFXMMU LUT entry 829 low
$580329ec constant GFXMMU_S_GFXMMU_LUT829H  \ offset: 0x29EC : GFXMMU LUT entry 829 high
$580329f0 constant GFXMMU_S_GFXMMU_LUT830L  \ offset: 0x29F0 : GFXMMU LUT entry 830 low
$580329f4 constant GFXMMU_S_GFXMMU_LUT830H  \ offset: 0x29F4 : GFXMMU LUT entry 830 high
$580329f8 constant GFXMMU_S_GFXMMU_LUT831L  \ offset: 0x29F8 : GFXMMU LUT entry 831 low
$580329fc constant GFXMMU_S_GFXMMU_LUT831H  \ offset: 0x29FC : GFXMMU LUT entry 831 high
$58032a00 constant GFXMMU_S_GFXMMU_LUT832L  \ offset: 0x2A00 : GFXMMU LUT entry 832 low
$58032a04 constant GFXMMU_S_GFXMMU_LUT832H  \ offset: 0x2A04 : GFXMMU LUT entry 832 high
$58032a08 constant GFXMMU_S_GFXMMU_LUT833L  \ offset: 0x2A08 : GFXMMU LUT entry 833 low
$58032a0c constant GFXMMU_S_GFXMMU_LUT833H  \ offset: 0x2A0C : GFXMMU LUT entry 833 high
$58032a10 constant GFXMMU_S_GFXMMU_LUT834L  \ offset: 0x2A10 : GFXMMU LUT entry 834 low
$58032a14 constant GFXMMU_S_GFXMMU_LUT834H  \ offset: 0x2A14 : GFXMMU LUT entry 834 high
$58032a18 constant GFXMMU_S_GFXMMU_LUT835L  \ offset: 0x2A18 : GFXMMU LUT entry 835 low
$58032a1c constant GFXMMU_S_GFXMMU_LUT835H  \ offset: 0x2A1C : GFXMMU LUT entry 835 high
$58032a20 constant GFXMMU_S_GFXMMU_LUT836L  \ offset: 0x2A20 : GFXMMU LUT entry 836 low
$58032a24 constant GFXMMU_S_GFXMMU_LUT836H  \ offset: 0x2A24 : GFXMMU LUT entry 836 high
$58032a28 constant GFXMMU_S_GFXMMU_LUT837L  \ offset: 0x2A28 : GFXMMU LUT entry 837 low
$58032a2c constant GFXMMU_S_GFXMMU_LUT837H  \ offset: 0x2A2C : GFXMMU LUT entry 837 high
$58032a30 constant GFXMMU_S_GFXMMU_LUT838L  \ offset: 0x2A30 : GFXMMU LUT entry 838 low
$58032a34 constant GFXMMU_S_GFXMMU_LUT838H  \ offset: 0x2A34 : GFXMMU LUT entry 838 high
$58032a38 constant GFXMMU_S_GFXMMU_LUT839L  \ offset: 0x2A38 : GFXMMU LUT entry 839 low
$58032a3c constant GFXMMU_S_GFXMMU_LUT839H  \ offset: 0x2A3C : GFXMMU LUT entry 839 high
$58032a40 constant GFXMMU_S_GFXMMU_LUT840L  \ offset: 0x2A40 : GFXMMU LUT entry 840 low
$58032a44 constant GFXMMU_S_GFXMMU_LUT840H  \ offset: 0x2A44 : GFXMMU LUT entry 840 high
$58032a48 constant GFXMMU_S_GFXMMU_LUT841L  \ offset: 0x2A48 : GFXMMU LUT entry 841 low
$58032a4c constant GFXMMU_S_GFXMMU_LUT841H  \ offset: 0x2A4C : GFXMMU LUT entry 841 high
$58032a50 constant GFXMMU_S_GFXMMU_LUT842L  \ offset: 0x2A50 : GFXMMU LUT entry 842 low
$58032a54 constant GFXMMU_S_GFXMMU_LUT842H  \ offset: 0x2A54 : GFXMMU LUT entry 842 high
$58032a58 constant GFXMMU_S_GFXMMU_LUT843L  \ offset: 0x2A58 : GFXMMU LUT entry 843 low
$58032a5c constant GFXMMU_S_GFXMMU_LUT843H  \ offset: 0x2A5C : GFXMMU LUT entry 843 high
$58032a60 constant GFXMMU_S_GFXMMU_LUT844L  \ offset: 0x2A60 : GFXMMU LUT entry 844 low
$58032a64 constant GFXMMU_S_GFXMMU_LUT844H  \ offset: 0x2A64 : GFXMMU LUT entry 844 high
$58032a68 constant GFXMMU_S_GFXMMU_LUT845L  \ offset: 0x2A68 : GFXMMU LUT entry 845 low
$58032a6c constant GFXMMU_S_GFXMMU_LUT845H  \ offset: 0x2A6C : GFXMMU LUT entry 845 high
$58032a70 constant GFXMMU_S_GFXMMU_LUT846L  \ offset: 0x2A70 : GFXMMU LUT entry 846 low
$58032a74 constant GFXMMU_S_GFXMMU_LUT846H  \ offset: 0x2A74 : GFXMMU LUT entry 846 high
$58032a78 constant GFXMMU_S_GFXMMU_LUT847L  \ offset: 0x2A78 : GFXMMU LUT entry 847 low
$58032a7c constant GFXMMU_S_GFXMMU_LUT847H  \ offset: 0x2A7C : GFXMMU LUT entry 847 high
$58032a80 constant GFXMMU_S_GFXMMU_LUT848L  \ offset: 0x2A80 : GFXMMU LUT entry 848 low
$58032a84 constant GFXMMU_S_GFXMMU_LUT848H  \ offset: 0x2A84 : GFXMMU LUT entry 848 high
$58032a88 constant GFXMMU_S_GFXMMU_LUT849L  \ offset: 0x2A88 : GFXMMU LUT entry 849 low
$58032a8c constant GFXMMU_S_GFXMMU_LUT849H  \ offset: 0x2A8C : GFXMMU LUT entry 849 high
$58032a90 constant GFXMMU_S_GFXMMU_LUT850L  \ offset: 0x2A90 : GFXMMU LUT entry 850 low
$58032a94 constant GFXMMU_S_GFXMMU_LUT850H  \ offset: 0x2A94 : GFXMMU LUT entry 850 high
$58032a98 constant GFXMMU_S_GFXMMU_LUT851L  \ offset: 0x2A98 : GFXMMU LUT entry 851 low
$58032a9c constant GFXMMU_S_GFXMMU_LUT851H  \ offset: 0x2A9C : GFXMMU LUT entry 851 high
$58032aa0 constant GFXMMU_S_GFXMMU_LUT852L  \ offset: 0x2AA0 : GFXMMU LUT entry 852 low
$58032aa4 constant GFXMMU_S_GFXMMU_LUT852H  \ offset: 0x2AA4 : GFXMMU LUT entry 852 high
$58032aa8 constant GFXMMU_S_GFXMMU_LUT853L  \ offset: 0x2AA8 : GFXMMU LUT entry 853 low
$58032aac constant GFXMMU_S_GFXMMU_LUT853H  \ offset: 0x2AAC : GFXMMU LUT entry 853 high
$58032ab0 constant GFXMMU_S_GFXMMU_LUT854L  \ offset: 0x2AB0 : GFXMMU LUT entry 854 low
$58032ab4 constant GFXMMU_S_GFXMMU_LUT854H  \ offset: 0x2AB4 : GFXMMU LUT entry 854 high
$58032ab8 constant GFXMMU_S_GFXMMU_LUT855L  \ offset: 0x2AB8 : GFXMMU LUT entry 855 low
$58032abc constant GFXMMU_S_GFXMMU_LUT855H  \ offset: 0x2ABC : GFXMMU LUT entry 855 high
$58032ac0 constant GFXMMU_S_GFXMMU_LUT856L  \ offset: 0x2AC0 : GFXMMU LUT entry 856 low
$58032ac4 constant GFXMMU_S_GFXMMU_LUT856H  \ offset: 0x2AC4 : GFXMMU LUT entry 856 high
$58032ac8 constant GFXMMU_S_GFXMMU_LUT857L  \ offset: 0x2AC8 : GFXMMU LUT entry 857 low
$58032acc constant GFXMMU_S_GFXMMU_LUT857H  \ offset: 0x2ACC : GFXMMU LUT entry 857 high
$58032ad0 constant GFXMMU_S_GFXMMU_LUT858L  \ offset: 0x2AD0 : GFXMMU LUT entry 858 low
$58032ad4 constant GFXMMU_S_GFXMMU_LUT858H  \ offset: 0x2AD4 : GFXMMU LUT entry 858 high
$58032ad8 constant GFXMMU_S_GFXMMU_LUT859L  \ offset: 0x2AD8 : GFXMMU LUT entry 859 low
$58032adc constant GFXMMU_S_GFXMMU_LUT859H  \ offset: 0x2ADC : GFXMMU LUT entry 859 high
$58032ae0 constant GFXMMU_S_GFXMMU_LUT860L  \ offset: 0x2AE0 : GFXMMU LUT entry 860 low
$58032ae4 constant GFXMMU_S_GFXMMU_LUT860H  \ offset: 0x2AE4 : GFXMMU LUT entry 860 high
$58032ae8 constant GFXMMU_S_GFXMMU_LUT861L  \ offset: 0x2AE8 : GFXMMU LUT entry 861 low
$58032aec constant GFXMMU_S_GFXMMU_LUT861H  \ offset: 0x2AEC : GFXMMU LUT entry 861 high
$58032af0 constant GFXMMU_S_GFXMMU_LUT862L  \ offset: 0x2AF0 : GFXMMU LUT entry 862 low
$58032af4 constant GFXMMU_S_GFXMMU_LUT862H  \ offset: 0x2AF4 : GFXMMU LUT entry 862 high
$58032af8 constant GFXMMU_S_GFXMMU_LUT863L  \ offset: 0x2AF8 : GFXMMU LUT entry 863 low
$58032afc constant GFXMMU_S_GFXMMU_LUT863H  \ offset: 0x2AFC : GFXMMU LUT entry 863 high
$58032b00 constant GFXMMU_S_GFXMMU_LUT864L  \ offset: 0x2B00 : GFXMMU LUT entry 864 low
$58032b04 constant GFXMMU_S_GFXMMU_LUT864H  \ offset: 0x2B04 : GFXMMU LUT entry 864 high
$58032b08 constant GFXMMU_S_GFXMMU_LUT865L  \ offset: 0x2B08 : GFXMMU LUT entry 865 low
$58032b0c constant GFXMMU_S_GFXMMU_LUT865H  \ offset: 0x2B0C : GFXMMU LUT entry 865 high
$58032b10 constant GFXMMU_S_GFXMMU_LUT866L  \ offset: 0x2B10 : GFXMMU LUT entry 866 low
$58032b14 constant GFXMMU_S_GFXMMU_LUT866H  \ offset: 0x2B14 : GFXMMU LUT entry 866 high
$58032b18 constant GFXMMU_S_GFXMMU_LUT867L  \ offset: 0x2B18 : GFXMMU LUT entry 867 low
$58032b1c constant GFXMMU_S_GFXMMU_LUT867H  \ offset: 0x2B1C : GFXMMU LUT entry 867 high
$58032b20 constant GFXMMU_S_GFXMMU_LUT868L  \ offset: 0x2B20 : GFXMMU LUT entry 868 low
$58032b24 constant GFXMMU_S_GFXMMU_LUT868H  \ offset: 0x2B24 : GFXMMU LUT entry 868 high
$58032b28 constant GFXMMU_S_GFXMMU_LUT869L  \ offset: 0x2B28 : GFXMMU LUT entry 869 low
$58032b2c constant GFXMMU_S_GFXMMU_LUT869H  \ offset: 0x2B2C : GFXMMU LUT entry 869 high
$58032b30 constant GFXMMU_S_GFXMMU_LUT870L  \ offset: 0x2B30 : GFXMMU LUT entry 870 low
$58032b34 constant GFXMMU_S_GFXMMU_LUT870H  \ offset: 0x2B34 : GFXMMU LUT entry 870 high
$58032b38 constant GFXMMU_S_GFXMMU_LUT871L  \ offset: 0x2B38 : GFXMMU LUT entry 871 low
$58032b3c constant GFXMMU_S_GFXMMU_LUT871H  \ offset: 0x2B3C : GFXMMU LUT entry 871 high
$58032b40 constant GFXMMU_S_GFXMMU_LUT872L  \ offset: 0x2B40 : GFXMMU LUT entry 872 low
$58032b44 constant GFXMMU_S_GFXMMU_LUT872H  \ offset: 0x2B44 : GFXMMU LUT entry 872 high
$58032b48 constant GFXMMU_S_GFXMMU_LUT873L  \ offset: 0x2B48 : GFXMMU LUT entry 873 low
$58032b4c constant GFXMMU_S_GFXMMU_LUT873H  \ offset: 0x2B4C : GFXMMU LUT entry 873 high
$58032b50 constant GFXMMU_S_GFXMMU_LUT874L  \ offset: 0x2B50 : GFXMMU LUT entry 874 low
$58032b54 constant GFXMMU_S_GFXMMU_LUT874H  \ offset: 0x2B54 : GFXMMU LUT entry 874 high
$58032b58 constant GFXMMU_S_GFXMMU_LUT875L  \ offset: 0x2B58 : GFXMMU LUT entry 875 low
$58032b5c constant GFXMMU_S_GFXMMU_LUT875H  \ offset: 0x2B5C : GFXMMU LUT entry 875 high
$58032b60 constant GFXMMU_S_GFXMMU_LUT876L  \ offset: 0x2B60 : GFXMMU LUT entry 876 low
$58032b64 constant GFXMMU_S_GFXMMU_LUT876H  \ offset: 0x2B64 : GFXMMU LUT entry 876 high
$58032b68 constant GFXMMU_S_GFXMMU_LUT877L  \ offset: 0x2B68 : GFXMMU LUT entry 877 low
$58032b6c constant GFXMMU_S_GFXMMU_LUT877H  \ offset: 0x2B6C : GFXMMU LUT entry 877 high
$58032b70 constant GFXMMU_S_GFXMMU_LUT878L  \ offset: 0x2B70 : GFXMMU LUT entry 878 low
$58032b74 constant GFXMMU_S_GFXMMU_LUT878H  \ offset: 0x2B74 : GFXMMU LUT entry 878 high
$58032b78 constant GFXMMU_S_GFXMMU_LUT879L  \ offset: 0x2B78 : GFXMMU LUT entry 879 low
$58032b7c constant GFXMMU_S_GFXMMU_LUT879H  \ offset: 0x2B7C : GFXMMU LUT entry 879 high
$58032b80 constant GFXMMU_S_GFXMMU_LUT880L  \ offset: 0x2B80 : GFXMMU LUT entry 880 low
$58032b84 constant GFXMMU_S_GFXMMU_LUT880H  \ offset: 0x2B84 : GFXMMU LUT entry 880 high
$58032b88 constant GFXMMU_S_GFXMMU_LUT881L  \ offset: 0x2B88 : GFXMMU LUT entry 881 low
$58032b8c constant GFXMMU_S_GFXMMU_LUT881H  \ offset: 0x2B8C : GFXMMU LUT entry 881 high
$58032b90 constant GFXMMU_S_GFXMMU_LUT882L  \ offset: 0x2B90 : GFXMMU LUT entry 882 low
$58032b94 constant GFXMMU_S_GFXMMU_LUT882H  \ offset: 0x2B94 : GFXMMU LUT entry 882 high
$58032b98 constant GFXMMU_S_GFXMMU_LUT883L  \ offset: 0x2B98 : GFXMMU LUT entry 883 low
$58032b9c constant GFXMMU_S_GFXMMU_LUT883H  \ offset: 0x2B9C : GFXMMU LUT entry 883 high
$58032ba0 constant GFXMMU_S_GFXMMU_LUT884L  \ offset: 0x2BA0 : GFXMMU LUT entry 884 low
$58032ba4 constant GFXMMU_S_GFXMMU_LUT884H  \ offset: 0x2BA4 : GFXMMU LUT entry 884 high
$58032ba8 constant GFXMMU_S_GFXMMU_LUT885L  \ offset: 0x2BA8 : GFXMMU LUT entry 885 low
$58032bac constant GFXMMU_S_GFXMMU_LUT885H  \ offset: 0x2BAC : GFXMMU LUT entry 885 high
$58032bb0 constant GFXMMU_S_GFXMMU_LUT886L  \ offset: 0x2BB0 : GFXMMU LUT entry 886 low
$58032bb4 constant GFXMMU_S_GFXMMU_LUT886H  \ offset: 0x2BB4 : GFXMMU LUT entry 886 high
$58032bb8 constant GFXMMU_S_GFXMMU_LUT887L  \ offset: 0x2BB8 : GFXMMU LUT entry 887 low
$58032bbc constant GFXMMU_S_GFXMMU_LUT887H  \ offset: 0x2BBC : GFXMMU LUT entry 887 high
$58032bc0 constant GFXMMU_S_GFXMMU_LUT888L  \ offset: 0x2BC0 : GFXMMU LUT entry 888 low
$58032bc4 constant GFXMMU_S_GFXMMU_LUT888H  \ offset: 0x2BC4 : GFXMMU LUT entry 888 high
$58032bc8 constant GFXMMU_S_GFXMMU_LUT889L  \ offset: 0x2BC8 : GFXMMU LUT entry 889 low
$58032bcc constant GFXMMU_S_GFXMMU_LUT889H  \ offset: 0x2BCC : GFXMMU LUT entry 889 high
$58032bd0 constant GFXMMU_S_GFXMMU_LUT890L  \ offset: 0x2BD0 : GFXMMU LUT entry 890 low
$58032bd4 constant GFXMMU_S_GFXMMU_LUT890H  \ offset: 0x2BD4 : GFXMMU LUT entry 890 high
$58032bd8 constant GFXMMU_S_GFXMMU_LUT891L  \ offset: 0x2BD8 : GFXMMU LUT entry 891 low
$58032bdc constant GFXMMU_S_GFXMMU_LUT891H  \ offset: 0x2BDC : GFXMMU LUT entry 891 high
$58032be0 constant GFXMMU_S_GFXMMU_LUT892L  \ offset: 0x2BE0 : GFXMMU LUT entry 892 low
$58032be4 constant GFXMMU_S_GFXMMU_LUT892H  \ offset: 0x2BE4 : GFXMMU LUT entry 892 high
$58032be8 constant GFXMMU_S_GFXMMU_LUT893L  \ offset: 0x2BE8 : GFXMMU LUT entry 893 low
$58032bec constant GFXMMU_S_GFXMMU_LUT893H  \ offset: 0x2BEC : GFXMMU LUT entry 893 high
$58032bf0 constant GFXMMU_S_GFXMMU_LUT894L  \ offset: 0x2BF0 : GFXMMU LUT entry 894 low
$58032bf4 constant GFXMMU_S_GFXMMU_LUT894H  \ offset: 0x2BF4 : GFXMMU LUT entry 894 high
$58032bf8 constant GFXMMU_S_GFXMMU_LUT895L  \ offset: 0x2BF8 : GFXMMU LUT entry 895 low
$58032bfc constant GFXMMU_S_GFXMMU_LUT895H  \ offset: 0x2BFC : GFXMMU LUT entry 895 high
$58032c00 constant GFXMMU_S_GFXMMU_LUT896L  \ offset: 0x2C00 : GFXMMU LUT entry 896 low
$58032c04 constant GFXMMU_S_GFXMMU_LUT896H  \ offset: 0x2C04 : GFXMMU LUT entry 896 high
$58032c08 constant GFXMMU_S_GFXMMU_LUT897L  \ offset: 0x2C08 : GFXMMU LUT entry 897 low
$58032c0c constant GFXMMU_S_GFXMMU_LUT897H  \ offset: 0x2C0C : GFXMMU LUT entry 897 high
$58032c10 constant GFXMMU_S_GFXMMU_LUT898L  \ offset: 0x2C10 : GFXMMU LUT entry 898 low
$58032c14 constant GFXMMU_S_GFXMMU_LUT898H  \ offset: 0x2C14 : GFXMMU LUT entry 898 high
$58032c18 constant GFXMMU_S_GFXMMU_LUT899L  \ offset: 0x2C18 : GFXMMU LUT entry 899 low
$58032c1c constant GFXMMU_S_GFXMMU_LUT899H  \ offset: 0x2C1C : GFXMMU LUT entry 899 high
$58032c20 constant GFXMMU_S_GFXMMU_LUT900L  \ offset: 0x2C20 : GFXMMU LUT entry 900 low
$58032c24 constant GFXMMU_S_GFXMMU_LUT900H  \ offset: 0x2C24 : GFXMMU LUT entry 900 high
$58032c28 constant GFXMMU_S_GFXMMU_LUT901L  \ offset: 0x2C28 : GFXMMU LUT entry 901 low
$58032c2c constant GFXMMU_S_GFXMMU_LUT901H  \ offset: 0x2C2C : GFXMMU LUT entry 901 high
$58032c30 constant GFXMMU_S_GFXMMU_LUT902L  \ offset: 0x2C30 : GFXMMU LUT entry 902 low
$58032c34 constant GFXMMU_S_GFXMMU_LUT902H  \ offset: 0x2C34 : GFXMMU LUT entry 902 high
$58032c38 constant GFXMMU_S_GFXMMU_LUT903L  \ offset: 0x2C38 : GFXMMU LUT entry 903 low
$58032c3c constant GFXMMU_S_GFXMMU_LUT903H  \ offset: 0x2C3C : GFXMMU LUT entry 903 high
$58032c40 constant GFXMMU_S_GFXMMU_LUT904L  \ offset: 0x2C40 : GFXMMU LUT entry 904 low
$58032c44 constant GFXMMU_S_GFXMMU_LUT904H  \ offset: 0x2C44 : GFXMMU LUT entry 904 high
$58032c48 constant GFXMMU_S_GFXMMU_LUT905L  \ offset: 0x2C48 : GFXMMU LUT entry 905 low
$58032c4c constant GFXMMU_S_GFXMMU_LUT905H  \ offset: 0x2C4C : GFXMMU LUT entry 905 high
$58032c50 constant GFXMMU_S_GFXMMU_LUT906L  \ offset: 0x2C50 : GFXMMU LUT entry 906 low
$58032c54 constant GFXMMU_S_GFXMMU_LUT906H  \ offset: 0x2C54 : GFXMMU LUT entry 906 high
$58032c58 constant GFXMMU_S_GFXMMU_LUT907L  \ offset: 0x2C58 : GFXMMU LUT entry 907 low
$58032c5c constant GFXMMU_S_GFXMMU_LUT907H  \ offset: 0x2C5C : GFXMMU LUT entry 907 high
$58032c60 constant GFXMMU_S_GFXMMU_LUT908L  \ offset: 0x2C60 : GFXMMU LUT entry 908 low
$58032c64 constant GFXMMU_S_GFXMMU_LUT908H  \ offset: 0x2C64 : GFXMMU LUT entry 908 high
$58032c68 constant GFXMMU_S_GFXMMU_LUT909L  \ offset: 0x2C68 : GFXMMU LUT entry 909 low
$58032c6c constant GFXMMU_S_GFXMMU_LUT909H  \ offset: 0x2C6C : GFXMMU LUT entry 909 high
$58032c70 constant GFXMMU_S_GFXMMU_LUT910L  \ offset: 0x2C70 : GFXMMU LUT entry 910 low
$58032c74 constant GFXMMU_S_GFXMMU_LUT910H  \ offset: 0x2C74 : GFXMMU LUT entry 910 high
$58032c78 constant GFXMMU_S_GFXMMU_LUT911L  \ offset: 0x2C78 : GFXMMU LUT entry 911 low
$58032c7c constant GFXMMU_S_GFXMMU_LUT911H  \ offset: 0x2C7C : GFXMMU LUT entry 911 high
$58032c80 constant GFXMMU_S_GFXMMU_LUT912L  \ offset: 0x2C80 : GFXMMU LUT entry 912 low
$58032c84 constant GFXMMU_S_GFXMMU_LUT912H  \ offset: 0x2C84 : GFXMMU LUT entry 912 high
$58032c88 constant GFXMMU_S_GFXMMU_LUT913L  \ offset: 0x2C88 : GFXMMU LUT entry 913 low
$58032c8c constant GFXMMU_S_GFXMMU_LUT913H  \ offset: 0x2C8C : GFXMMU LUT entry 913 high
$58032c90 constant GFXMMU_S_GFXMMU_LUT914L  \ offset: 0x2C90 : GFXMMU LUT entry 914 low
$58032c94 constant GFXMMU_S_GFXMMU_LUT914H  \ offset: 0x2C94 : GFXMMU LUT entry 914 high
$58032c98 constant GFXMMU_S_GFXMMU_LUT915L  \ offset: 0x2C98 : GFXMMU LUT entry 915 low
$58032c9c constant GFXMMU_S_GFXMMU_LUT915H  \ offset: 0x2C9C : GFXMMU LUT entry 915 high
$58032ca0 constant GFXMMU_S_GFXMMU_LUT916L  \ offset: 0x2CA0 : GFXMMU LUT entry 916 low
$58032ca4 constant GFXMMU_S_GFXMMU_LUT916H  \ offset: 0x2CA4 : GFXMMU LUT entry 916 high
$58032ca8 constant GFXMMU_S_GFXMMU_LUT917L  \ offset: 0x2CA8 : GFXMMU LUT entry 917 low
$58032cac constant GFXMMU_S_GFXMMU_LUT917H  \ offset: 0x2CAC : GFXMMU LUT entry 917 high
$58032cb0 constant GFXMMU_S_GFXMMU_LUT918L  \ offset: 0x2CB0 : GFXMMU LUT entry 918 low
$58032cb4 constant GFXMMU_S_GFXMMU_LUT918H  \ offset: 0x2CB4 : GFXMMU LUT entry 918 high
$58032cb8 constant GFXMMU_S_GFXMMU_LUT919L  \ offset: 0x2CB8 : GFXMMU LUT entry 919 low
$58032cbc constant GFXMMU_S_GFXMMU_LUT919H  \ offset: 0x2CBC : GFXMMU LUT entry 919 high
$58032cc0 constant GFXMMU_S_GFXMMU_LUT920L  \ offset: 0x2CC0 : GFXMMU LUT entry 920 low
$58032cc4 constant GFXMMU_S_GFXMMU_LUT920H  \ offset: 0x2CC4 : GFXMMU LUT entry 920 high
$58032cc8 constant GFXMMU_S_GFXMMU_LUT921L  \ offset: 0x2CC8 : GFXMMU LUT entry 921 low
$58032ccc constant GFXMMU_S_GFXMMU_LUT921H  \ offset: 0x2CCC : GFXMMU LUT entry 921 high
$58032cd0 constant GFXMMU_S_GFXMMU_LUT922L  \ offset: 0x2CD0 : GFXMMU LUT entry 922 low
$58032cd4 constant GFXMMU_S_GFXMMU_LUT922H  \ offset: 0x2CD4 : GFXMMU LUT entry 922 high
$58032cd8 constant GFXMMU_S_GFXMMU_LUT923L  \ offset: 0x2CD8 : GFXMMU LUT entry 923 low
$58032cdc constant GFXMMU_S_GFXMMU_LUT923H  \ offset: 0x2CDC : GFXMMU LUT entry 923 high
$58032ce0 constant GFXMMU_S_GFXMMU_LUT924L  \ offset: 0x2CE0 : GFXMMU LUT entry 924 low
$58032ce4 constant GFXMMU_S_GFXMMU_LUT924H  \ offset: 0x2CE4 : GFXMMU LUT entry 924 high
$58032ce8 constant GFXMMU_S_GFXMMU_LUT925L  \ offset: 0x2CE8 : GFXMMU LUT entry 925 low
$58032cec constant GFXMMU_S_GFXMMU_LUT925H  \ offset: 0x2CEC : GFXMMU LUT entry 925 high
$58032cf0 constant GFXMMU_S_GFXMMU_LUT926L  \ offset: 0x2CF0 : GFXMMU LUT entry 926 low
$58032cf4 constant GFXMMU_S_GFXMMU_LUT926H  \ offset: 0x2CF4 : GFXMMU LUT entry 926 high
$58032cf8 constant GFXMMU_S_GFXMMU_LUT927L  \ offset: 0x2CF8 : GFXMMU LUT entry 927 low
$58032cfc constant GFXMMU_S_GFXMMU_LUT927H  \ offset: 0x2CFC : GFXMMU LUT entry 927 high
$58032d00 constant GFXMMU_S_GFXMMU_LUT928L  \ offset: 0x2D00 : GFXMMU LUT entry 928 low
$58032d04 constant GFXMMU_S_GFXMMU_LUT928H  \ offset: 0x2D04 : GFXMMU LUT entry 928 high
$58032d08 constant GFXMMU_S_GFXMMU_LUT929L  \ offset: 0x2D08 : GFXMMU LUT entry 929 low
$58032d0c constant GFXMMU_S_GFXMMU_LUT929H  \ offset: 0x2D0C : GFXMMU LUT entry 929 high
$58032d10 constant GFXMMU_S_GFXMMU_LUT930L  \ offset: 0x2D10 : GFXMMU LUT entry 930 low
$58032d14 constant GFXMMU_S_GFXMMU_LUT930H  \ offset: 0x2D14 : GFXMMU LUT entry 930 high
$58032d18 constant GFXMMU_S_GFXMMU_LUT931L  \ offset: 0x2D18 : GFXMMU LUT entry 931 low
$58032d1c constant GFXMMU_S_GFXMMU_LUT931H  \ offset: 0x2D1C : GFXMMU LUT entry 931 high
$58032d20 constant GFXMMU_S_GFXMMU_LUT932L  \ offset: 0x2D20 : GFXMMU LUT entry 932 low
$58032d24 constant GFXMMU_S_GFXMMU_LUT932H  \ offset: 0x2D24 : GFXMMU LUT entry 932 high
$58032d28 constant GFXMMU_S_GFXMMU_LUT933L  \ offset: 0x2D28 : GFXMMU LUT entry 933 low
$58032d2c constant GFXMMU_S_GFXMMU_LUT933H  \ offset: 0x2D2C : GFXMMU LUT entry 933 high
$58032d30 constant GFXMMU_S_GFXMMU_LUT934L  \ offset: 0x2D30 : GFXMMU LUT entry 934 low
$58032d34 constant GFXMMU_S_GFXMMU_LUT934H  \ offset: 0x2D34 : GFXMMU LUT entry 934 high
$58032d38 constant GFXMMU_S_GFXMMU_LUT935L  \ offset: 0x2D38 : GFXMMU LUT entry 935 low
$58032d3c constant GFXMMU_S_GFXMMU_LUT935H  \ offset: 0x2D3C : GFXMMU LUT entry 935 high
$58032d40 constant GFXMMU_S_GFXMMU_LUT936L  \ offset: 0x2D40 : GFXMMU LUT entry 936 low
$58032d44 constant GFXMMU_S_GFXMMU_LUT936H  \ offset: 0x2D44 : GFXMMU LUT entry 936 high
$58032d48 constant GFXMMU_S_GFXMMU_LUT937L  \ offset: 0x2D48 : GFXMMU LUT entry 937 low
$58032d4c constant GFXMMU_S_GFXMMU_LUT937H  \ offset: 0x2D4C : GFXMMU LUT entry 937 high
$58032d50 constant GFXMMU_S_GFXMMU_LUT938L  \ offset: 0x2D50 : GFXMMU LUT entry 938 low
$58032d54 constant GFXMMU_S_GFXMMU_LUT938H  \ offset: 0x2D54 : GFXMMU LUT entry 938 high
$58032d58 constant GFXMMU_S_GFXMMU_LUT939L  \ offset: 0x2D58 : GFXMMU LUT entry 939 low
$58032d5c constant GFXMMU_S_GFXMMU_LUT939H  \ offset: 0x2D5C : GFXMMU LUT entry 939 high
$58032d60 constant GFXMMU_S_GFXMMU_LUT940L  \ offset: 0x2D60 : GFXMMU LUT entry 940 low
$58032d64 constant GFXMMU_S_GFXMMU_LUT940H  \ offset: 0x2D64 : GFXMMU LUT entry 940 high
$58032d68 constant GFXMMU_S_GFXMMU_LUT941L  \ offset: 0x2D68 : GFXMMU LUT entry 941 low
$58032d6c constant GFXMMU_S_GFXMMU_LUT941H  \ offset: 0x2D6C : GFXMMU LUT entry 941 high
$58032d70 constant GFXMMU_S_GFXMMU_LUT942L  \ offset: 0x2D70 : GFXMMU LUT entry 942 low
$58032d74 constant GFXMMU_S_GFXMMU_LUT942H  \ offset: 0x2D74 : GFXMMU LUT entry 942 high
$58032d78 constant GFXMMU_S_GFXMMU_LUT943L  \ offset: 0x2D78 : GFXMMU LUT entry 943 low
$58032d7c constant GFXMMU_S_GFXMMU_LUT943H  \ offset: 0x2D7C : GFXMMU LUT entry 943 high
$58032d80 constant GFXMMU_S_GFXMMU_LUT944L  \ offset: 0x2D80 : GFXMMU LUT entry 944 low
$58032d84 constant GFXMMU_S_GFXMMU_LUT944H  \ offset: 0x2D84 : GFXMMU LUT entry 944 high
$58032d88 constant GFXMMU_S_GFXMMU_LUT945L  \ offset: 0x2D88 : GFXMMU LUT entry 945 low
$58032d8c constant GFXMMU_S_GFXMMU_LUT945H  \ offset: 0x2D8C : GFXMMU LUT entry 945 high
$58032d90 constant GFXMMU_S_GFXMMU_LUT946L  \ offset: 0x2D90 : GFXMMU LUT entry 946 low
$58032d94 constant GFXMMU_S_GFXMMU_LUT946H  \ offset: 0x2D94 : GFXMMU LUT entry 946 high
$58032d98 constant GFXMMU_S_GFXMMU_LUT947L  \ offset: 0x2D98 : GFXMMU LUT entry 947 low
$58032d9c constant GFXMMU_S_GFXMMU_LUT947H  \ offset: 0x2D9C : GFXMMU LUT entry 947 high
$58032da0 constant GFXMMU_S_GFXMMU_LUT948L  \ offset: 0x2DA0 : GFXMMU LUT entry 948 low
$58032da4 constant GFXMMU_S_GFXMMU_LUT948H  \ offset: 0x2DA4 : GFXMMU LUT entry 948 high
$58032da8 constant GFXMMU_S_GFXMMU_LUT949L  \ offset: 0x2DA8 : GFXMMU LUT entry 949 low
$58032dac constant GFXMMU_S_GFXMMU_LUT949H  \ offset: 0x2DAC : GFXMMU LUT entry 949 high
$58032db0 constant GFXMMU_S_GFXMMU_LUT950L  \ offset: 0x2DB0 : GFXMMU LUT entry 950 low
$58032db4 constant GFXMMU_S_GFXMMU_LUT950H  \ offset: 0x2DB4 : GFXMMU LUT entry 950 high
$58032db8 constant GFXMMU_S_GFXMMU_LUT951L  \ offset: 0x2DB8 : GFXMMU LUT entry 951 low
$58032dbc constant GFXMMU_S_GFXMMU_LUT951H  \ offset: 0x2DBC : GFXMMU LUT entry 951 high
$58032dc0 constant GFXMMU_S_GFXMMU_LUT952L  \ offset: 0x2DC0 : GFXMMU LUT entry 952 low
$58032dc4 constant GFXMMU_S_GFXMMU_LUT952H  \ offset: 0x2DC4 : GFXMMU LUT entry 952 high
$58032dc8 constant GFXMMU_S_GFXMMU_LUT953L  \ offset: 0x2DC8 : GFXMMU LUT entry 953 low
$58032dcc constant GFXMMU_S_GFXMMU_LUT953H  \ offset: 0x2DCC : GFXMMU LUT entry 953 high
$58032dd0 constant GFXMMU_S_GFXMMU_LUT954L  \ offset: 0x2DD0 : GFXMMU LUT entry 954 low
$58032dd4 constant GFXMMU_S_GFXMMU_LUT954H  \ offset: 0x2DD4 : GFXMMU LUT entry 954 high
$58032dd8 constant GFXMMU_S_GFXMMU_LUT955L  \ offset: 0x2DD8 : GFXMMU LUT entry 955 low
$58032ddc constant GFXMMU_S_GFXMMU_LUT955H  \ offset: 0x2DDC : GFXMMU LUT entry 955 high
$58032de0 constant GFXMMU_S_GFXMMU_LUT956L  \ offset: 0x2DE0 : GFXMMU LUT entry 956 low
$58032de4 constant GFXMMU_S_GFXMMU_LUT956H  \ offset: 0x2DE4 : GFXMMU LUT entry 956 high
$58032de8 constant GFXMMU_S_GFXMMU_LUT957L  \ offset: 0x2DE8 : GFXMMU LUT entry 957 low
$58032dec constant GFXMMU_S_GFXMMU_LUT957H  \ offset: 0x2DEC : GFXMMU LUT entry 957 high
$58032df0 constant GFXMMU_S_GFXMMU_LUT958L  \ offset: 0x2DF0 : GFXMMU LUT entry 958 low
$58032df4 constant GFXMMU_S_GFXMMU_LUT958H  \ offset: 0x2DF4 : GFXMMU LUT entry 958 high
$58032df8 constant GFXMMU_S_GFXMMU_LUT959L  \ offset: 0x2DF8 : GFXMMU LUT entry 959 low
$58032dfc constant GFXMMU_S_GFXMMU_LUT959H  \ offset: 0x2DFC : GFXMMU LUT entry 959 high
$58032e00 constant GFXMMU_S_GFXMMU_LUT960L  \ offset: 0x2E00 : GFXMMU LUT entry 960 low
$58032e04 constant GFXMMU_S_GFXMMU_LUT960H  \ offset: 0x2E04 : GFXMMU LUT entry 960 high
$58032e08 constant GFXMMU_S_GFXMMU_LUT961L  \ offset: 0x2E08 : GFXMMU LUT entry 961 low
$58032e0c constant GFXMMU_S_GFXMMU_LUT961H  \ offset: 0x2E0C : GFXMMU LUT entry 961 high
$58032e10 constant GFXMMU_S_GFXMMU_LUT962L  \ offset: 0x2E10 : GFXMMU LUT entry 962 low
$58032e14 constant GFXMMU_S_GFXMMU_LUT962H  \ offset: 0x2E14 : GFXMMU LUT entry 962 high
$58032e18 constant GFXMMU_S_GFXMMU_LUT963L  \ offset: 0x2E18 : GFXMMU LUT entry 963 low
$58032e1c constant GFXMMU_S_GFXMMU_LUT963H  \ offset: 0x2E1C : GFXMMU LUT entry 963 high
$58032e20 constant GFXMMU_S_GFXMMU_LUT964L  \ offset: 0x2E20 : GFXMMU LUT entry 964 low
$58032e24 constant GFXMMU_S_GFXMMU_LUT964H  \ offset: 0x2E24 : GFXMMU LUT entry 964 high
$58032e28 constant GFXMMU_S_GFXMMU_LUT965L  \ offset: 0x2E28 : GFXMMU LUT entry 965 low
$58032e2c constant GFXMMU_S_GFXMMU_LUT965H  \ offset: 0x2E2C : GFXMMU LUT entry 965 high
$58032e30 constant GFXMMU_S_GFXMMU_LUT966L  \ offset: 0x2E30 : GFXMMU LUT entry 966 low
$58032e34 constant GFXMMU_S_GFXMMU_LUT966H  \ offset: 0x2E34 : GFXMMU LUT entry 966 high
$58032e38 constant GFXMMU_S_GFXMMU_LUT967L  \ offset: 0x2E38 : GFXMMU LUT entry 967 low
$58032e3c constant GFXMMU_S_GFXMMU_LUT967H  \ offset: 0x2E3C : GFXMMU LUT entry 967 high
$58032e40 constant GFXMMU_S_GFXMMU_LUT968L  \ offset: 0x2E40 : GFXMMU LUT entry 968 low
$58032e44 constant GFXMMU_S_GFXMMU_LUT968H  \ offset: 0x2E44 : GFXMMU LUT entry 968 high
$58032e48 constant GFXMMU_S_GFXMMU_LUT969L  \ offset: 0x2E48 : GFXMMU LUT entry 969 low
$58032e4c constant GFXMMU_S_GFXMMU_LUT969H  \ offset: 0x2E4C : GFXMMU LUT entry 969 high
$58032e50 constant GFXMMU_S_GFXMMU_LUT970L  \ offset: 0x2E50 : GFXMMU LUT entry 970 low
$58032e54 constant GFXMMU_S_GFXMMU_LUT970H  \ offset: 0x2E54 : GFXMMU LUT entry 970 high
$58032e58 constant GFXMMU_S_GFXMMU_LUT971L  \ offset: 0x2E58 : GFXMMU LUT entry 971 low
$58032e5c constant GFXMMU_S_GFXMMU_LUT971H  \ offset: 0x2E5C : GFXMMU LUT entry 971 high
$58032e60 constant GFXMMU_S_GFXMMU_LUT972L  \ offset: 0x2E60 : GFXMMU LUT entry 972 low
$58032e64 constant GFXMMU_S_GFXMMU_LUT972H  \ offset: 0x2E64 : GFXMMU LUT entry 972 high
$58032e68 constant GFXMMU_S_GFXMMU_LUT973L  \ offset: 0x2E68 : GFXMMU LUT entry 973 low
$58032e6c constant GFXMMU_S_GFXMMU_LUT973H  \ offset: 0x2E6C : GFXMMU LUT entry 973 high
$58032e70 constant GFXMMU_S_GFXMMU_LUT974L  \ offset: 0x2E70 : GFXMMU LUT entry 974 low
$58032e74 constant GFXMMU_S_GFXMMU_LUT974H  \ offset: 0x2E74 : GFXMMU LUT entry 974 high
$58032e78 constant GFXMMU_S_GFXMMU_LUT975L  \ offset: 0x2E78 : GFXMMU LUT entry 975 low
$58032e7c constant GFXMMU_S_GFXMMU_LUT975H  \ offset: 0x2E7C : GFXMMU LUT entry 975 high
$58032e80 constant GFXMMU_S_GFXMMU_LUT976L  \ offset: 0x2E80 : GFXMMU LUT entry 976 low
$58032e84 constant GFXMMU_S_GFXMMU_LUT976H  \ offset: 0x2E84 : GFXMMU LUT entry 976 high
$58032e88 constant GFXMMU_S_GFXMMU_LUT977L  \ offset: 0x2E88 : GFXMMU LUT entry 977 low
$58032e8c constant GFXMMU_S_GFXMMU_LUT977H  \ offset: 0x2E8C : GFXMMU LUT entry 977 high
$58032e90 constant GFXMMU_S_GFXMMU_LUT978L  \ offset: 0x2E90 : GFXMMU LUT entry 978 low
$58032e94 constant GFXMMU_S_GFXMMU_LUT978H  \ offset: 0x2E94 : GFXMMU LUT entry 978 high
$58032e98 constant GFXMMU_S_GFXMMU_LUT979L  \ offset: 0x2E98 : GFXMMU LUT entry 979 low
$58032e9c constant GFXMMU_S_GFXMMU_LUT979H  \ offset: 0x2E9C : GFXMMU LUT entry 979 high
$58032ea0 constant GFXMMU_S_GFXMMU_LUT980L  \ offset: 0x2EA0 : GFXMMU LUT entry 980 low
$58032ea4 constant GFXMMU_S_GFXMMU_LUT980H  \ offset: 0x2EA4 : GFXMMU LUT entry 980 high
$58032ea8 constant GFXMMU_S_GFXMMU_LUT981L  \ offset: 0x2EA8 : GFXMMU LUT entry 981 low
$58032eac constant GFXMMU_S_GFXMMU_LUT981H  \ offset: 0x2EAC : GFXMMU LUT entry 981 high
$58032eb0 constant GFXMMU_S_GFXMMU_LUT982L  \ offset: 0x2EB0 : GFXMMU LUT entry 982 low
$58032eb4 constant GFXMMU_S_GFXMMU_LUT982H  \ offset: 0x2EB4 : GFXMMU LUT entry 982 high
$58032eb8 constant GFXMMU_S_GFXMMU_LUT983L  \ offset: 0x2EB8 : GFXMMU LUT entry 983 low
$58032ebc constant GFXMMU_S_GFXMMU_LUT983H  \ offset: 0x2EBC : GFXMMU LUT entry 983 high
$58032ec0 constant GFXMMU_S_GFXMMU_LUT984L  \ offset: 0x2EC0 : GFXMMU LUT entry 984 low
$58032ec4 constant GFXMMU_S_GFXMMU_LUT984H  \ offset: 0x2EC4 : GFXMMU LUT entry 984 high
$58032ec8 constant GFXMMU_S_GFXMMU_LUT985L  \ offset: 0x2EC8 : GFXMMU LUT entry 985 low
$58032ecc constant GFXMMU_S_GFXMMU_LUT985H  \ offset: 0x2ECC : GFXMMU LUT entry 985 high
$58032ed0 constant GFXMMU_S_GFXMMU_LUT986L  \ offset: 0x2ED0 : GFXMMU LUT entry 986 low
$58032ed4 constant GFXMMU_S_GFXMMU_LUT986H  \ offset: 0x2ED4 : GFXMMU LUT entry 986 high
$58032ed8 constant GFXMMU_S_GFXMMU_LUT987L  \ offset: 0x2ED8 : GFXMMU LUT entry 987 low
$58032edc constant GFXMMU_S_GFXMMU_LUT987H  \ offset: 0x2EDC : GFXMMU LUT entry 987 high
$58032ee0 constant GFXMMU_S_GFXMMU_LUT988L  \ offset: 0x2EE0 : GFXMMU LUT entry 988 low
$58032ee4 constant GFXMMU_S_GFXMMU_LUT988H  \ offset: 0x2EE4 : GFXMMU LUT entry 988 high
$58032ee8 constant GFXMMU_S_GFXMMU_LUT989L  \ offset: 0x2EE8 : GFXMMU LUT entry 989 low
$58032eec constant GFXMMU_S_GFXMMU_LUT989H  \ offset: 0x2EEC : GFXMMU LUT entry 989 high
$58032ef0 constant GFXMMU_S_GFXMMU_LUT990L  \ offset: 0x2EF0 : GFXMMU LUT entry 990 low
$58032ef4 constant GFXMMU_S_GFXMMU_LUT990H  \ offset: 0x2EF4 : GFXMMU LUT entry 990 high
$58032ef8 constant GFXMMU_S_GFXMMU_LUT991L  \ offset: 0x2EF8 : GFXMMU LUT entry 991 low
$58032efc constant GFXMMU_S_GFXMMU_LUT991H  \ offset: 0x2EFC : GFXMMU LUT entry 991 high
$58032f00 constant GFXMMU_S_GFXMMU_LUT992L  \ offset: 0x2F00 : GFXMMU LUT entry 992 low
$58032f04 constant GFXMMU_S_GFXMMU_LUT992H  \ offset: 0x2F04 : GFXMMU LUT entry 992 high
$58032f08 constant GFXMMU_S_GFXMMU_LUT993L  \ offset: 0x2F08 : GFXMMU LUT entry 993 low
$58032f0c constant GFXMMU_S_GFXMMU_LUT993H  \ offset: 0x2F0C : GFXMMU LUT entry 993 high
$58032f10 constant GFXMMU_S_GFXMMU_LUT994L  \ offset: 0x2F10 : GFXMMU LUT entry 994 low
$58032f14 constant GFXMMU_S_GFXMMU_LUT994H  \ offset: 0x2F14 : GFXMMU LUT entry 994 high
$58032f18 constant GFXMMU_S_GFXMMU_LUT995L  \ offset: 0x2F18 : GFXMMU LUT entry 995 low
$58032f1c constant GFXMMU_S_GFXMMU_LUT995H  \ offset: 0x2F1C : GFXMMU LUT entry 995 high
$58032f20 constant GFXMMU_S_GFXMMU_LUT996L  \ offset: 0x2F20 : GFXMMU LUT entry 996 low
$58032f24 constant GFXMMU_S_GFXMMU_LUT996H  \ offset: 0x2F24 : GFXMMU LUT entry 996 high
$58032f28 constant GFXMMU_S_GFXMMU_LUT997L  \ offset: 0x2F28 : GFXMMU LUT entry 997 low
$58032f2c constant GFXMMU_S_GFXMMU_LUT997H  \ offset: 0x2F2C : GFXMMU LUT entry 997 high
$58032f30 constant GFXMMU_S_GFXMMU_LUT998L  \ offset: 0x2F30 : GFXMMU LUT entry 998 low
$58032f34 constant GFXMMU_S_GFXMMU_LUT998H  \ offset: 0x2F34 : GFXMMU LUT entry 998 high
$58032f38 constant GFXMMU_S_GFXMMU_LUT999L  \ offset: 0x2F38 : GFXMMU LUT entry 999 low
$58032f3c constant GFXMMU_S_GFXMMU_LUT999H  \ offset: 0x2F3C : GFXMMU LUT entry 999 high
$58032f40 constant GFXMMU_S_GFXMMU_LUT1000L  \ offset: 0x2F40 : GFXMMU LUT entry 1000 low
$58032f44 constant GFXMMU_S_GFXMMU_LUT1000H  \ offset: 0x2F44 : GFXMMU LUT entry 1000 high
$58032f48 constant GFXMMU_S_GFXMMU_LUT1001L  \ offset: 0x2F48 : GFXMMU LUT entry 1001 low
$58032f4c constant GFXMMU_S_GFXMMU_LUT1001H  \ offset: 0x2F4C : GFXMMU LUT entry 1001 high
$58032f50 constant GFXMMU_S_GFXMMU_LUT1002L  \ offset: 0x2F50 : GFXMMU LUT entry 1002 low
$58032f54 constant GFXMMU_S_GFXMMU_LUT1002H  \ offset: 0x2F54 : GFXMMU LUT entry 1002 high
$58032f58 constant GFXMMU_S_GFXMMU_LUT1003L  \ offset: 0x2F58 : GFXMMU LUT entry 1003 low
$58032f5c constant GFXMMU_S_GFXMMU_LUT1003H  \ offset: 0x2F5C : GFXMMU LUT entry 1003 high
$58032f60 constant GFXMMU_S_GFXMMU_LUT1004L  \ offset: 0x2F60 : GFXMMU LUT entry 1004 low
$58032f64 constant GFXMMU_S_GFXMMU_LUT1004H  \ offset: 0x2F64 : GFXMMU LUT entry 1004 high
$58032f68 constant GFXMMU_S_GFXMMU_LUT1005L  \ offset: 0x2F68 : GFXMMU LUT entry 1005 low
$58032f6c constant GFXMMU_S_GFXMMU_LUT1005H  \ offset: 0x2F6C : GFXMMU LUT entry 1005 high
$58032f70 constant GFXMMU_S_GFXMMU_LUT1006L  \ offset: 0x2F70 : GFXMMU LUT entry 1006 low
$58032f74 constant GFXMMU_S_GFXMMU_LUT1006H  \ offset: 0x2F74 : GFXMMU LUT entry 1006 high
$58032f78 constant GFXMMU_S_GFXMMU_LUT1007L  \ offset: 0x2F78 : GFXMMU LUT entry 1007 low
$58032f7c constant GFXMMU_S_GFXMMU_LUT1007H  \ offset: 0x2F7C : GFXMMU LUT entry 1007 high
$58032f80 constant GFXMMU_S_GFXMMU_LUT1008L  \ offset: 0x2F80 : GFXMMU LUT entry 1008 low
$58032f84 constant GFXMMU_S_GFXMMU_LUT1008H  \ offset: 0x2F84 : GFXMMU LUT entry 1008 high
$58032f88 constant GFXMMU_S_GFXMMU_LUT1009L  \ offset: 0x2F88 : GFXMMU LUT entry 1009 low
$58032f8c constant GFXMMU_S_GFXMMU_LUT1009H  \ offset: 0x2F8C : GFXMMU LUT entry 1009 high
$58032f90 constant GFXMMU_S_GFXMMU_LUT1010L  \ offset: 0x2F90 : GFXMMU LUT entry 1010 low
$58032f94 constant GFXMMU_S_GFXMMU_LUT1010H  \ offset: 0x2F94 : GFXMMU LUT entry 1010 high
$58032f98 constant GFXMMU_S_GFXMMU_LUT1011L  \ offset: 0x2F98 : GFXMMU LUT entry 1011 low
$58032f9c constant GFXMMU_S_GFXMMU_LUT1011H  \ offset: 0x2F9C : GFXMMU LUT entry 1011 high
$58032fa0 constant GFXMMU_S_GFXMMU_LUT1012L  \ offset: 0x2FA0 : GFXMMU LUT entry 1012 low
$58032fa4 constant GFXMMU_S_GFXMMU_LUT1012H  \ offset: 0x2FA4 : GFXMMU LUT entry 1012 high
$58032fa8 constant GFXMMU_S_GFXMMU_LUT1013L  \ offset: 0x2FA8 : GFXMMU LUT entry 1013 low
$58032fac constant GFXMMU_S_GFXMMU_LUT1013H  \ offset: 0x2FAC : GFXMMU LUT entry 1013 high
$58032fb0 constant GFXMMU_S_GFXMMU_LUT1014L  \ offset: 0x2FB0 : GFXMMU LUT entry 1014 low
$58032fb4 constant GFXMMU_S_GFXMMU_LUT1014H  \ offset: 0x2FB4 : GFXMMU LUT entry 1014 high
$58032fb8 constant GFXMMU_S_GFXMMU_LUT1015L  \ offset: 0x2FB8 : GFXMMU LUT entry 1015 low
$58032fbc constant GFXMMU_S_GFXMMU_LUT1015H  \ offset: 0x2FBC : GFXMMU LUT entry 1015 high
$58032fc0 constant GFXMMU_S_GFXMMU_LUT1016L  \ offset: 0x2FC0 : GFXMMU LUT entry 1016 low
$58032fc4 constant GFXMMU_S_GFXMMU_LUT1016H  \ offset: 0x2FC4 : GFXMMU LUT entry 1016 high
$58032fc8 constant GFXMMU_S_GFXMMU_LUT1017L  \ offset: 0x2FC8 : GFXMMU LUT entry 1017 low
$58032fcc constant GFXMMU_S_GFXMMU_LUT1017H  \ offset: 0x2FCC : GFXMMU LUT entry 1017 high
$58032fd0 constant GFXMMU_S_GFXMMU_LUT1018L  \ offset: 0x2FD0 : GFXMMU LUT entry 1018 low
$58032fd4 constant GFXMMU_S_GFXMMU_LUT1018H  \ offset: 0x2FD4 : GFXMMU LUT entry 1018 high
$58032fd8 constant GFXMMU_S_GFXMMU_LUT1019L  \ offset: 0x2FD8 : GFXMMU LUT entry 1019 low
$58032fdc constant GFXMMU_S_GFXMMU_LUT1019H  \ offset: 0x2FDC : GFXMMU LUT entry 1019 high
$58032fe0 constant GFXMMU_S_GFXMMU_LUT1020L  \ offset: 0x2FE0 : GFXMMU LUT entry 1020 low
$58032fe4 constant GFXMMU_S_GFXMMU_LUT1020H  \ offset: 0x2FE4 : GFXMMU LUT entry 1020 high
$58032fe8 constant GFXMMU_S_GFXMMU_LUT1021L  \ offset: 0x2FE8 : GFXMMU LUT entry 1021 low
$58032fec constant GFXMMU_S_GFXMMU_LUT1021H  \ offset: 0x2FEC : GFXMMU LUT entry 1021 high
$58032ff0 constant GFXMMU_S_GFXMMU_LUT1022L  \ offset: 0x2FF0 : GFXMMU LUT entry 1022 low
$58032ff4 constant GFXMMU_S_GFXMMU_LUT1022H  \ offset: 0x2FF4 : GFXMMU LUT entry 1022 high
$58032ff8 constant GFXMMU_S_GFXMMU_LUT1023L  \ offset: 0x2FF8 : GFXMMU LUT entry 1023 low
$58032ffc constant GFXMMU_S_GFXMMU_LUT1023H  \ offset: 0x2FFC : GFXMMU LUT entry 1023 high

