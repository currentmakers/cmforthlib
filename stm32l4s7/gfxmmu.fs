\
\ @file gfxmmu.fs
\ @brief Graphic MMU
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GFXMMU_DEF

  [ifdef] GFXMMU_CR_DEF
    \
    \ @brief Graphic MMU configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_B0OIE                   \ [0x00] Buffer 0 overflow interrupt enable
    $01 constant GFXMMU_B1OIE                   \ [0x01] Buffer 1 overflow interrupt enable
    $02 constant GFXMMU_B2OIE                   \ [0x02] Buffer 2 overflow interrupt enable
    $03 constant GFXMMU_B3OIE                   \ [0x03] Buffer 3 overflow interrupt enable
    $04 constant GFXMMU_AMEIE                   \ [0x04] AHB master error interrupt enable
    $06 constant GFXMMU_BM192                   \ [0x06] 192 Block mode
  [then]


  [ifdef] GFXMMU_SR_DEF
    \
    \ @brief Graphic MMU status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_B0OF                    \ [0x00] Buffer 0 overflow flag
    $01 constant GFXMMU_B1OF                    \ [0x01] Buffer 1 overflow flag
    $02 constant GFXMMU_B2OF                    \ [0x02] Buffer 2 overflow flag
    $03 constant GFXMMU_B3OF                    \ [0x03] Buffer 3 overflow flag
    $04 constant GFXMMU_AMEF                    \ [0x04] AHB master error flag
  [then]


  [ifdef] GFXMMU_FCR_DEF
    \
    \ @brief Graphic MMU flag clear register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_CB0OF                   \ [0x00] Clear buffer 0 overflow flag
    $01 constant GFXMMU_CB1OF                   \ [0x01] Clear buffer 1 overflow flag
    $02 constant GFXMMU_CB2OF                   \ [0x02] Clear buffer 2 overflow flag
    $03 constant GFXMMU_CB3OF                   \ [0x03] Clear buffer 3 overflow flag
    $04 constant GFXMMU_CAMEF                   \ [0x04] Clear AHB master error flag
  [then]


  [ifdef] GFXMMU_DVR_DEF
    \
    \ @brief Graphic MMU default value register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_DV                      \ [0x00 : 32] Default value
  [then]


  [ifdef] GFXMMU_B0CR_DEF
    \
    \ @brief Graphic MMU buffer 0 configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_PBO                     \ [0x04 : 19] Physical buffer offset
    $17 constant GFXMMU_PBBA                    \ [0x17 : 9] Physical buffer base address
  [then]


  [ifdef] GFXMMU_B1CR_DEF
    \
    \ @brief Graphic MMU buffer 1 configuration register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_PBO                     \ [0x04 : 19] Physical buffer offset
    $17 constant GFXMMU_PBBA                    \ [0x17 : 9] Physical buffer base address
  [then]


  [ifdef] GFXMMU_B2CR_DEF
    \
    \ @brief Graphic MMU buffer 2 configuration register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_PBO                     \ [0x04 : 19] Physical buffer offset
    $17 constant GFXMMU_PBBA                    \ [0x17 : 9] Physical buffer base address
  [then]


  [ifdef] GFXMMU_B3CR_DEF
    \
    \ @brief Graphic MMU buffer 3 configuration register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_PBO                     \ [0x04 : 19] Physical buffer offset
    $17 constant GFXMMU_PBBA                    \ [0x17 : 9] Physical buffer base address
  [then]


  [ifdef] GFXMMU_VERR_DEF
    \
    \ @brief Graphic MMU version register
    \ Address offset: 0xFF4
    \ Reset value: 0x00000010
    \
    $00 constant GFXMMU_MINREV                  \ [0x00 : 4] Minor revision
    $04 constant GFXMMU_MAJREV                  \ [0x04 : 4] Major revision
  [then]


  [ifdef] GFXMMU_IPIDR_DEF
    \
    \ @brief Graphic MMU identification register
    \ Address offset: 0xFF8
    \ Reset value: 0x00160061
    \
    $00 constant GFXMMU_ID                      \ [0x00 : 32] Identification Code
  [then]


  [ifdef] GFXMMU_SIDR_DEF
    \
    \ @brief Graphic MMU size identification register
    \ Address offset: 0xFFC
    \ Reset value: 0xA3C5DD04
    \
    $00 constant GFXMMU_SID                     \ [0x00 : 32] Size and ID
  [then]


  [ifdef] GFXMMU_LUT0L_DEF
    \
    \ @brief Graphic MMU LUT entry 0 low
    \ Address offset: 0x1000
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT0H_DEF
    \
    \ @brief Graphic MMU LUT entry 0 high
    \ Address offset: 0x1004
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1L_DEF
    \
    \ @brief Graphic MMU LUT entry 1 low
    \ Address offset: 0x1008
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1H_DEF
    \
    \ @brief Graphic MMU LUT entry 1 high
    \ Address offset: 0x100C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT2L_DEF
    \
    \ @brief Graphic MMU LUT entry 2 low
    \ Address offset: 0x1010
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT2H_DEF
    \
    \ @brief Graphic MMU LUT entry 2 high
    \ Address offset: 0x1014
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT3L_DEF
    \
    \ @brief Graphic MMU LUT entry 3 low
    \ Address offset: 0x1018
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT3H_DEF
    \
    \ @brief Graphic MMU LUT entry 3 high
    \ Address offset: 0x101C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT4L_DEF
    \
    \ @brief Graphic MMU LUT entry 4 low
    \ Address offset: 0x1020
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT4H_DEF
    \
    \ @brief Graphic MMU LUT entry 4 high
    \ Address offset: 0x1024
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT5L_DEF
    \
    \ @brief Graphic MMU LUT entry 5 low
    \ Address offset: 0x1028
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT5H_DEF
    \
    \ @brief Graphic MMU LUT entry 5 high
    \ Address offset: 0x102C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT6L_DEF
    \
    \ @brief Graphic MMU LUT entry 6 low
    \ Address offset: 0x1030
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT6H_DEF
    \
    \ @brief Graphic MMU LUT entry 6 high
    \ Address offset: 0x1034
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT7L_DEF
    \
    \ @brief Graphic MMU LUT entry 7 low
    \ Address offset: 0x1038
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT7H_DEF
    \
    \ @brief Graphic MMU LUT entry 7 high
    \ Address offset: 0x103C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT8L_DEF
    \
    \ @brief Graphic MMU LUT entry 8 low
    \ Address offset: 0x1040
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT8H_DEF
    \
    \ @brief Graphic MMU LUT entry 8 high
    \ Address offset: 0x1044
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT9L_DEF
    \
    \ @brief Graphic MMU LUT entry 9 low
    \ Address offset: 0x1048
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT9H_DEF
    \
    \ @brief Graphic MMU LUT entry 9 high
    \ Address offset: 0x104C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT10L_DEF
    \
    \ @brief Graphic MMU LUT entry 10 low
    \ Address offset: 0x1050
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT10H_DEF
    \
    \ @brief Graphic MMU LUT entry 10 high
    \ Address offset: 0x1054
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT11L_DEF
    \
    \ @brief Graphic MMU LUT entry 11 low
    \ Address offset: 0x1058
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT11H_DEF
    \
    \ @brief Graphic MMU LUT entry 11 high
    \ Address offset: 0x105C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT12L_DEF
    \
    \ @brief Graphic MMU LUT entry 12 low
    \ Address offset: 0x1060
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT12H_DEF
    \
    \ @brief Graphic MMU LUT entry 12 high
    \ Address offset: 0x1064
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT13L_DEF
    \
    \ @brief Graphic MMU LUT entry 13 low
    \ Address offset: 0x1068
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT13H_DEF
    \
    \ @brief Graphic MMU LUT entry 13 high
    \ Address offset: 0x106C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT14L_DEF
    \
    \ @brief Graphic MMU LUT entry 14 low
    \ Address offset: 0x1070
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT14H_DEF
    \
    \ @brief Graphic MMU LUT entry 14 high
    \ Address offset: 0x1074
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT15L_DEF
    \
    \ @brief Graphic MMU LUT entry 15 low
    \ Address offset: 0x1078
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT15H_DEF
    \
    \ @brief Graphic MMU LUT entry 15 high
    \ Address offset: 0x107C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT16L_DEF
    \
    \ @brief Graphic MMU LUT entry 16 low
    \ Address offset: 0x1080
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT16H_DEF
    \
    \ @brief Graphic MMU LUT entry 16 high
    \ Address offset: 0x1084
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT17L_DEF
    \
    \ @brief Graphic MMU LUT entry 17 low
    \ Address offset: 0x1088
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT17H_DEF
    \
    \ @brief Graphic MMU LUT entry 17 high
    \ Address offset: 0x108C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT18L_DEF
    \
    \ @brief Graphic MMU LUT entry 18 low
    \ Address offset: 0x1090
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT18H_DEF
    \
    \ @brief Graphic MMU LUT entry 18 high
    \ Address offset: 0x1094
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT19L_DEF
    \
    \ @brief Graphic MMU LUT entry 19 low
    \ Address offset: 0x1098
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT19H_DEF
    \
    \ @brief Graphic MMU LUT entry 19 high
    \ Address offset: 0x109C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT20L_DEF
    \
    \ @brief Graphic MMU LUT entry 20 low
    \ Address offset: 0x10A0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT20H_DEF
    \
    \ @brief Graphic MMU LUT entry 20 high
    \ Address offset: 0x10A4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT21L_DEF
    \
    \ @brief Graphic MMU LUT entry 21 low
    \ Address offset: 0x10A8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT21H_DEF
    \
    \ @brief Graphic MMU LUT entry 21 high
    \ Address offset: 0x10AC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT22L_DEF
    \
    \ @brief Graphic MMU LUT entry 22 low
    \ Address offset: 0x10B0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT22H_DEF
    \
    \ @brief Graphic MMU LUT entry 22 high
    \ Address offset: 0x10B4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT23L_DEF
    \
    \ @brief Graphic MMU LUT entry 23 low
    \ Address offset: 0x10B8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT23H_DEF
    \
    \ @brief Graphic MMU LUT entry 23 high
    \ Address offset: 0x10BC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT24L_DEF
    \
    \ @brief Graphic MMU LUT entry 24 low
    \ Address offset: 0x10C0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT24H_DEF
    \
    \ @brief Graphic MMU LUT entry 24 high
    \ Address offset: 0x10C4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT25L_DEF
    \
    \ @brief Graphic MMU LUT entry 25 low
    \ Address offset: 0x10C8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT25H_DEF
    \
    \ @brief Graphic MMU LUT entry 25 high
    \ Address offset: 0x10CC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT26L_DEF
    \
    \ @brief Graphic MMU LUT entry 26 low
    \ Address offset: 0x10D0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT26H_DEF
    \
    \ @brief Graphic MMU LUT entry 26 high
    \ Address offset: 0x10D4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT27L_DEF
    \
    \ @brief Graphic MMU LUT entry 27 low
    \ Address offset: 0x10D8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT27H_DEF
    \
    \ @brief Graphic MMU LUT entry 27 high
    \ Address offset: 0x10DC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT28L_DEF
    \
    \ @brief Graphic MMU LUT entry 28 low
    \ Address offset: 0x10E0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT28H_DEF
    \
    \ @brief Graphic MMU LUT entry 28 high
    \ Address offset: 0x10E4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT29L_DEF
    \
    \ @brief Graphic MMU LUT entry 29 low
    \ Address offset: 0x10E8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT29H_DEF
    \
    \ @brief Graphic MMU LUT entry 29 high
    \ Address offset: 0x10EC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT30L_DEF
    \
    \ @brief Graphic MMU LUT entry 30 low
    \ Address offset: 0x10F0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT30H_DEF
    \
    \ @brief Graphic MMU LUT entry 30 high
    \ Address offset: 0x10F4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT31L_DEF
    \
    \ @brief Graphic MMU LUT entry 31 low
    \ Address offset: 0x10F8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT31H_DEF
    \
    \ @brief Graphic MMU LUT entry 31 high
    \ Address offset: 0x10FC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT32L_DEF
    \
    \ @brief Graphic MMU LUT entry 32 low
    \ Address offset: 0x1100
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT32H_DEF
    \
    \ @brief Graphic MMU LUT entry 32 high
    \ Address offset: 0x1104
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT33L_DEF
    \
    \ @brief Graphic MMU LUT entry 33 low
    \ Address offset: 0x1108
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT33H_DEF
    \
    \ @brief Graphic MMU LUT entry 33 high
    \ Address offset: 0x110C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT34L_DEF
    \
    \ @brief Graphic MMU LUT entry 34 low
    \ Address offset: 0x1110
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT34H_DEF
    \
    \ @brief Graphic MMU LUT entry 34 high
    \ Address offset: 0x1114
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT35L_DEF
    \
    \ @brief Graphic MMU LUT entry 35 low
    \ Address offset: 0x1118
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT35H_DEF
    \
    \ @brief Graphic MMU LUT entry 35 high
    \ Address offset: 0x111C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT36L_DEF
    \
    \ @brief Graphic MMU LUT entry 36 low
    \ Address offset: 0x1120
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT36H_DEF
    \
    \ @brief Graphic MMU LUT entry 36 high
    \ Address offset: 0x1124
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT37L_DEF
    \
    \ @brief Graphic MMU LUT entry 37 low
    \ Address offset: 0x1128
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT37H_DEF
    \
    \ @brief Graphic MMU LUT entry 37 high
    \ Address offset: 0x112C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT38L_DEF
    \
    \ @brief Graphic MMU LUT entry 38 low
    \ Address offset: 0x1130
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT38H_DEF
    \
    \ @brief Graphic MMU LUT entry 38 high
    \ Address offset: 0x1134
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT39L_DEF
    \
    \ @brief Graphic MMU LUT entry 39 low
    \ Address offset: 0x1138
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT39H_DEF
    \
    \ @brief Graphic MMU LUT entry 39 high
    \ Address offset: 0x113C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT40L_DEF
    \
    \ @brief Graphic MMU LUT entry 40 low
    \ Address offset: 0x1140
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT40H_DEF
    \
    \ @brief Graphic MMU LUT entry 40 high
    \ Address offset: 0x1144
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT41L_DEF
    \
    \ @brief Graphic MMU LUT entry 41 low
    \ Address offset: 0x1148
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT41H_DEF
    \
    \ @brief Graphic MMU LUT entry 41 high
    \ Address offset: 0x114C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT42L_DEF
    \
    \ @brief Graphic MMU LUT entry 42 low
    \ Address offset: 0x1150
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT42H_DEF
    \
    \ @brief Graphic MMU LUT entry 42 high
    \ Address offset: 0x1154
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT43L_DEF
    \
    \ @brief Graphic MMU LUT entry 43 low
    \ Address offset: 0x1158
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT43H_DEF
    \
    \ @brief Graphic MMU LUT entry 43 high
    \ Address offset: 0x115C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT44L_DEF
    \
    \ @brief Graphic MMU LUT entry 44 low
    \ Address offset: 0x1160
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT44H_DEF
    \
    \ @brief Graphic MMU LUT entry 44 high
    \ Address offset: 0x1164
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT45L_DEF
    \
    \ @brief Graphic MMU LUT entry 45 low
    \ Address offset: 0x1168
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT45H_DEF
    \
    \ @brief Graphic MMU LUT entry 45 high
    \ Address offset: 0x116C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT46L_DEF
    \
    \ @brief Graphic MMU LUT entry 46 low
    \ Address offset: 0x1170
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT46H_DEF
    \
    \ @brief Graphic MMU LUT entry 46 high
    \ Address offset: 0x1174
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT47L_DEF
    \
    \ @brief Graphic MMU LUT entry 47 low
    \ Address offset: 0x1178
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT47H_DEF
    \
    \ @brief Graphic MMU LUT entry 47 high
    \ Address offset: 0x117C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT48L_DEF
    \
    \ @brief Graphic MMU LUT entry 48 low
    \ Address offset: 0x1180
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT48H_DEF
    \
    \ @brief Graphic MMU LUT entry 48 high
    \ Address offset: 0x1184
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT49L_DEF
    \
    \ @brief Graphic MMU LUT entry 49 low
    \ Address offset: 0x1188
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT49H_DEF
    \
    \ @brief Graphic MMU LUT entry 49 high
    \ Address offset: 0x118C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT50L_DEF
    \
    \ @brief Graphic MMU LUT entry 50 low
    \ Address offset: 0x1190
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT50H_DEF
    \
    \ @brief Graphic MMU LUT entry 50 high
    \ Address offset: 0x1194
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT51L_DEF
    \
    \ @brief Graphic MMU LUT entry 51 low
    \ Address offset: 0x1198
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT51H_DEF
    \
    \ @brief Graphic MMU LUT entry 51 high
    \ Address offset: 0x119C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT52L_DEF
    \
    \ @brief Graphic MMU LUT entry 52 low
    \ Address offset: 0x11A0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT52H_DEF
    \
    \ @brief Graphic MMU LUT entry 52 high
    \ Address offset: 0x11A4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT53L_DEF
    \
    \ @brief Graphic MMU LUT entry 53 low
    \ Address offset: 0x11A8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT53H_DEF
    \
    \ @brief Graphic MMU LUT entry 53 high
    \ Address offset: 0x11AC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT54L_DEF
    \
    \ @brief Graphic MMU LUT entry 54 low
    \ Address offset: 0x11B0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT54H_DEF
    \
    \ @brief Graphic MMU LUT entry 54 high
    \ Address offset: 0x11B4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT55L_DEF
    \
    \ @brief Graphic MMU LUT entry 55 low
    \ Address offset: 0x11B8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT55H_DEF
    \
    \ @brief Graphic MMU LUT entry 55 high
    \ Address offset: 0x11BC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT56L_DEF
    \
    \ @brief Graphic MMU LUT entry 56 low
    \ Address offset: 0x11C0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT56H_DEF
    \
    \ @brief Graphic MMU LUT entry 56 high
    \ Address offset: 0x11C4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT57L_DEF
    \
    \ @brief Graphic MMU LUT entry 57 low
    \ Address offset: 0x11C8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT57H_DEF
    \
    \ @brief Graphic MMU LUT entry 57 high
    \ Address offset: 0x11CC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT58L_DEF
    \
    \ @brief Graphic MMU LUT entry 58 low
    \ Address offset: 0x11D0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT58H_DEF
    \
    \ @brief Graphic MMU LUT entry 58 high
    \ Address offset: 0x11D4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT59L_DEF
    \
    \ @brief Graphic MMU LUT entry 59 low
    \ Address offset: 0x11D8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT59H_DEF
    \
    \ @brief Graphic MMU LUT entry 59 high
    \ Address offset: 0x11DC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT60L_DEF
    \
    \ @brief Graphic MMU LUT entry 60 low
    \ Address offset: 0x11E0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT60H_DEF
    \
    \ @brief Graphic MMU LUT entry 60 high
    \ Address offset: 0x11E4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT61L_DEF
    \
    \ @brief Graphic MMU LUT entry 61 low
    \ Address offset: 0x11E8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT61H_DEF
    \
    \ @brief Graphic MMU LUT entry 61 high
    \ Address offset: 0x11EC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT62L_DEF
    \
    \ @brief Graphic MMU LUT entry 62 low
    \ Address offset: 0x11F0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT62H_DEF
    \
    \ @brief Graphic MMU LUT entry 62 high
    \ Address offset: 0x11F4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT63L_DEF
    \
    \ @brief Graphic MMU LUT entry 63 low
    \ Address offset: 0x11F8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT63H_DEF
    \
    \ @brief Graphic MMU LUT entry 63 high
    \ Address offset: 0x11FC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT64L_DEF
    \
    \ @brief Graphic MMU LUT entry 64 low
    \ Address offset: 0x1200
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT64H_DEF
    \
    \ @brief Graphic MMU LUT entry 64 high
    \ Address offset: 0x1204
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT65L_DEF
    \
    \ @brief Graphic MMU LUT entry 65 low
    \ Address offset: 0x1208
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT65H_DEF
    \
    \ @brief Graphic MMU LUT entry 65 high
    \ Address offset: 0x120C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT66L_DEF
    \
    \ @brief Graphic MMU LUT entry 66 low
    \ Address offset: 0x1210
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT66H_DEF
    \
    \ @brief Graphic MMU LUT entry 66 high
    \ Address offset: 0x1214
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT67L_DEF
    \
    \ @brief Graphic MMU LUT entry 67 low
    \ Address offset: 0x1218
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT67H_DEF
    \
    \ @brief Graphic MMU LUT entry 67 high
    \ Address offset: 0x121C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT68L_DEF
    \
    \ @brief Graphic MMU LUT entry 68 low
    \ Address offset: 0x1220
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT68H_DEF
    \
    \ @brief Graphic MMU LUT entry 68 high
    \ Address offset: 0x1224
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT69L_DEF
    \
    \ @brief Graphic MMU LUT entry 69 low
    \ Address offset: 0x1228
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT69H_DEF
    \
    \ @brief Graphic MMU LUT entry 69 high
    \ Address offset: 0x122C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT70L_DEF
    \
    \ @brief Graphic MMU LUT entry 70 low
    \ Address offset: 0x1230
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT70H_DEF
    \
    \ @brief Graphic MMU LUT entry 70 high
    \ Address offset: 0x1234
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT71L_DEF
    \
    \ @brief Graphic MMU LUT entry 71 low
    \ Address offset: 0x1238
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT71H_DEF
    \
    \ @brief Graphic MMU LUT entry 71 high
    \ Address offset: 0x123C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT72L_DEF
    \
    \ @brief Graphic MMU LUT entry 72 low
    \ Address offset: 0x1240
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT72H_DEF
    \
    \ @brief Graphic MMU LUT entry 72 high
    \ Address offset: 0x1244
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT73L_DEF
    \
    \ @brief Graphic MMU LUT entry 73 low
    \ Address offset: 0x1248
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT73H_DEF
    \
    \ @brief Graphic MMU LUT entry 73 high
    \ Address offset: 0x124C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT74L_DEF
    \
    \ @brief Graphic MMU LUT entry 74 low
    \ Address offset: 0x1250
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT74H_DEF
    \
    \ @brief Graphic MMU LUT entry 74 high
    \ Address offset: 0x1254
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT75L_DEF
    \
    \ @brief Graphic MMU LUT entry 75 low
    \ Address offset: 0x1258
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT75H_DEF
    \
    \ @brief Graphic MMU LUT entry 75 high
    \ Address offset: 0x125C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT76L_DEF
    \
    \ @brief Graphic MMU LUT entry 76 low
    \ Address offset: 0x1260
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT76H_DEF
    \
    \ @brief Graphic MMU LUT entry 76 high
    \ Address offset: 0x1264
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT77L_DEF
    \
    \ @brief Graphic MMU LUT entry 77 low
    \ Address offset: 0x1268
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT77H_DEF
    \
    \ @brief Graphic MMU LUT entry 77 high
    \ Address offset: 0x126C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT78L_DEF
    \
    \ @brief Graphic MMU LUT entry 78 low
    \ Address offset: 0x1270
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT78H_DEF
    \
    \ @brief Graphic MMU LUT entry 78 high
    \ Address offset: 0x1274
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT79L_DEF
    \
    \ @brief Graphic MMU LUT entry 79 low
    \ Address offset: 0x1278
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT79H_DEF
    \
    \ @brief Graphic MMU LUT entry 79 high
    \ Address offset: 0x127C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT80L_DEF
    \
    \ @brief Graphic MMU LUT entry 80 low
    \ Address offset: 0x1280
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT80H_DEF
    \
    \ @brief Graphic MMU LUT entry 80 high
    \ Address offset: 0x1284
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT81L_DEF
    \
    \ @brief Graphic MMU LUT entry 81 low
    \ Address offset: 0x1288
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT81H_DEF
    \
    \ @brief Graphic MMU LUT entry 81 high
    \ Address offset: 0x128C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT82L_DEF
    \
    \ @brief Graphic MMU LUT entry 82 low
    \ Address offset: 0x1290
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT82H_DEF
    \
    \ @brief Graphic MMU LUT entry 82 high
    \ Address offset: 0x1294
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT83L_DEF
    \
    \ @brief Graphic MMU LUT entry 83 low
    \ Address offset: 0x1298
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT83H_DEF
    \
    \ @brief Graphic MMU LUT entry 83 high
    \ Address offset: 0x129C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT84L_DEF
    \
    \ @brief Graphic MMU LUT entry 84 low
    \ Address offset: 0x12A0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT84H_DEF
    \
    \ @brief Graphic MMU LUT entry 84 high
    \ Address offset: 0x12A4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT85L_DEF
    \
    \ @brief Graphic MMU LUT entry 85 low
    \ Address offset: 0x12A8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT85H_DEF
    \
    \ @brief Graphic MMU LUT entry 85 high
    \ Address offset: 0x12AC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT86L_DEF
    \
    \ @brief Graphic MMU LUT entry 86 low
    \ Address offset: 0x12B0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT86H_DEF
    \
    \ @brief Graphic MMU LUT entry 86 high
    \ Address offset: 0x12B4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT87L_DEF
    \
    \ @brief Graphic MMU LUT entry 87 low
    \ Address offset: 0x12B8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT87H_DEF
    \
    \ @brief Graphic MMU LUT entry 87 high
    \ Address offset: 0x12BC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT88L_DEF
    \
    \ @brief Graphic MMU LUT entry 88 low
    \ Address offset: 0x12C0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT88H_DEF
    \
    \ @brief Graphic MMU LUT entry 88 high
    \ Address offset: 0x12C4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT89L_DEF
    \
    \ @brief Graphic MMU LUT entry 89 low
    \ Address offset: 0x12C8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT89H_DEF
    \
    \ @brief Graphic MMU LUT entry 89 high
    \ Address offset: 0x12CC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT90L_DEF
    \
    \ @brief Graphic MMU LUT entry 90 low
    \ Address offset: 0x12D0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT90H_DEF
    \
    \ @brief Graphic MMU LUT entry 90 high
    \ Address offset: 0x12D4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT91L_DEF
    \
    \ @brief Graphic MMU LUT entry 91 low
    \ Address offset: 0x12D8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT91H_DEF
    \
    \ @brief Graphic MMU LUT entry 91 high
    \ Address offset: 0x12DC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT92L_DEF
    \
    \ @brief Graphic MMU LUT entry 92 low
    \ Address offset: 0x12E0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT92H_DEF
    \
    \ @brief Graphic MMU LUT entry 92 high
    \ Address offset: 0x12E4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT93L_DEF
    \
    \ @brief Graphic MMU LUT entry 93 low
    \ Address offset: 0x12E8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT93H_DEF
    \
    \ @brief Graphic MMU LUT entry 93 high
    \ Address offset: 0x12EC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT94L_DEF
    \
    \ @brief Graphic MMU LUT entry 94 low
    \ Address offset: 0x12F0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT94H_DEF
    \
    \ @brief Graphic MMU LUT entry 94 high
    \ Address offset: 0x12F4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT95L_DEF
    \
    \ @brief Graphic MMU LUT entry 95 low
    \ Address offset: 0x12F8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT95H_DEF
    \
    \ @brief Graphic MMU LUT entry 95 high
    \ Address offset: 0x12FC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT96L_DEF
    \
    \ @brief Graphic MMU LUT entry 96 low
    \ Address offset: 0x1300
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT96H_DEF
    \
    \ @brief Graphic MMU LUT entry 96 high
    \ Address offset: 0x1304
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT97L_DEF
    \
    \ @brief Graphic MMU LUT entry 97 low
    \ Address offset: 0x1308
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT97H_DEF
    \
    \ @brief Graphic MMU LUT entry 97 high
    \ Address offset: 0x130C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT98L_DEF
    \
    \ @brief Graphic MMU LUT entry 98 low
    \ Address offset: 0x1310
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT98H_DEF
    \
    \ @brief Graphic MMU LUT entry 98 high
    \ Address offset: 0x1314
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT99L_DEF
    \
    \ @brief Graphic MMU LUT entry 99 low
    \ Address offset: 0x1318
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT99H_DEF
    \
    \ @brief Graphic MMU LUT entry 99 high
    \ Address offset: 0x131C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT100L_DEF
    \
    \ @brief Graphic MMU LUT entry 100 low
    \ Address offset: 0x1320
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT100H_DEF
    \
    \ @brief Graphic MMU LUT entry 100 high
    \ Address offset: 0x1324
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT101L_DEF
    \
    \ @brief Graphic MMU LUT entry 101 low
    \ Address offset: 0x1328
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT101H_DEF
    \
    \ @brief Graphic MMU LUT entry 101 high
    \ Address offset: 0x132C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT102L_DEF
    \
    \ @brief Graphic MMU LUT entry 102 low
    \ Address offset: 0x1330
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT102H_DEF
    \
    \ @brief Graphic MMU LUT entry 102 high
    \ Address offset: 0x1334
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT103L_DEF
    \
    \ @brief Graphic MMU LUT entry 103 low
    \ Address offset: 0x1338
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT103H_DEF
    \
    \ @brief Graphic MMU LUT entry 103 high
    \ Address offset: 0x133C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT104L_DEF
    \
    \ @brief Graphic MMU LUT entry 104 low
    \ Address offset: 0x1340
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT104H_DEF
    \
    \ @brief Graphic MMU LUT entry 104 high
    \ Address offset: 0x1344
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT105L_DEF
    \
    \ @brief Graphic MMU LUT entry 105 low
    \ Address offset: 0x1348
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT105H_DEF
    \
    \ @brief Graphic MMU LUT entry 105 high
    \ Address offset: 0x134C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT106L_DEF
    \
    \ @brief Graphic MMU LUT entry 106 low
    \ Address offset: 0x1350
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT106H_DEF
    \
    \ @brief Graphic MMU LUT entry 106 high
    \ Address offset: 0x1354
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT107L_DEF
    \
    \ @brief Graphic MMU LUT entry 107 low
    \ Address offset: 0x1358
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT107H_DEF
    \
    \ @brief Graphic MMU LUT entry 107 high
    \ Address offset: 0x135C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT108L_DEF
    \
    \ @brief Graphic MMU LUT entry 108 low
    \ Address offset: 0x1360
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT108H_DEF
    \
    \ @brief Graphic MMU LUT entry 108 high
    \ Address offset: 0x1364
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT109L_DEF
    \
    \ @brief Graphic MMU LUT entry 109 low
    \ Address offset: 0x1368
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT109H_DEF
    \
    \ @brief Graphic MMU LUT entry 109 high
    \ Address offset: 0x136C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT110L_DEF
    \
    \ @brief Graphic MMU LUT entry 110 low
    \ Address offset: 0x1370
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT110H_DEF
    \
    \ @brief Graphic MMU LUT entry 110 high
    \ Address offset: 0x1374
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT111L_DEF
    \
    \ @brief Graphic MMU LUT entry 111 low
    \ Address offset: 0x1378
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT111H_DEF
    \
    \ @brief Graphic MMU LUT entry 111 high
    \ Address offset: 0x137C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT112L_DEF
    \
    \ @brief Graphic MMU LUT entry 112 low
    \ Address offset: 0x1380
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT112H_DEF
    \
    \ @brief Graphic MMU LUT entry 112 high
    \ Address offset: 0x1384
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT113L_DEF
    \
    \ @brief Graphic MMU LUT entry 113 low
    \ Address offset: 0x1388
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT113H_DEF
    \
    \ @brief Graphic MMU LUT entry 113 high
    \ Address offset: 0x138C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT114L_DEF
    \
    \ @brief Graphic MMU LUT entry 114 low
    \ Address offset: 0x1390
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT114H_DEF
    \
    \ @brief Graphic MMU LUT entry 114 high
    \ Address offset: 0x1394
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT115L_DEF
    \
    \ @brief Graphic MMU LUT entry 115 low
    \ Address offset: 0x1398
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT115H_DEF
    \
    \ @brief Graphic MMU LUT entry 115 high
    \ Address offset: 0x139C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT116L_DEF
    \
    \ @brief Graphic MMU LUT entry 116 low
    \ Address offset: 0x13A0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT116H_DEF
    \
    \ @brief Graphic MMU LUT entry 116 high
    \ Address offset: 0x13A4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT117L_DEF
    \
    \ @brief Graphic MMU LUT entry 117 low
    \ Address offset: 0x13A8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT117H_DEF
    \
    \ @brief Graphic MMU LUT entry 117 high
    \ Address offset: 0x13AC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT118L_DEF
    \
    \ @brief Graphic MMU LUT entry 118 low
    \ Address offset: 0x13B0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT118H_DEF
    \
    \ @brief Graphic MMU LUT entry 118 high
    \ Address offset: 0x13B4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT119L_DEF
    \
    \ @brief Graphic MMU LUT entry 119 low
    \ Address offset: 0x13B8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT119H_DEF
    \
    \ @brief Graphic MMU LUT entry 119 high
    \ Address offset: 0x13BC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT120L_DEF
    \
    \ @brief Graphic MMU LUT entry 120 low
    \ Address offset: 0x13C0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT120H_DEF
    \
    \ @brief Graphic MMU LUT entry 120 high
    \ Address offset: 0x13C4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT121L_DEF
    \
    \ @brief Graphic MMU LUT entry 121 low
    \ Address offset: 0x13C8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT121H_DEF
    \
    \ @brief Graphic MMU LUT entry 121 high
    \ Address offset: 0x13CC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT122L_DEF
    \
    \ @brief Graphic MMU LUT entry 122 low
    \ Address offset: 0x13D0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT122H_DEF
    \
    \ @brief Graphic MMU LUT entry 122 high
    \ Address offset: 0x13D4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT123L_DEF
    \
    \ @brief Graphic MMU LUT entry 123 low
    \ Address offset: 0x13D8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT123H_DEF
    \
    \ @brief Graphic MMU LUT entry 123 high
    \ Address offset: 0x13DC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT124L_DEF
    \
    \ @brief Graphic MMU LUT entry 124 low
    \ Address offset: 0x13E0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT124H_DEF
    \
    \ @brief Graphic MMU LUT entry 124 high
    \ Address offset: 0x13E4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT125L_DEF
    \
    \ @brief Graphic MMU LUT entry 125 low
    \ Address offset: 0x13E8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT125H_DEF
    \
    \ @brief Graphic MMU LUT entry 125 high
    \ Address offset: 0x13EC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT126L_DEF
    \
    \ @brief Graphic MMU LUT entry 126 low
    \ Address offset: 0x13F0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT126H_DEF
    \
    \ @brief Graphic MMU LUT entry 126 high
    \ Address offset: 0x13F4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT127L_DEF
    \
    \ @brief Graphic MMU LUT entry 127 low
    \ Address offset: 0x13F8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT127H_DEF
    \
    \ @brief Graphic MMU LUT entry 127 high
    \ Address offset: 0x13FC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT128L_DEF
    \
    \ @brief Graphic MMU LUT entry 128 low
    \ Address offset: 0x1400
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT128H_DEF
    \
    \ @brief Graphic MMU LUT entry 128 high
    \ Address offset: 0x1404
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT129L_DEF
    \
    \ @brief Graphic MMU LUT entry 129 low
    \ Address offset: 0x1408
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT129H_DEF
    \
    \ @brief Graphic MMU LUT entry 129 high
    \ Address offset: 0x140C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT130L_DEF
    \
    \ @brief Graphic MMU LUT entry 130 low
    \ Address offset: 0x1410
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT130H_DEF
    \
    \ @brief Graphic MMU LUT entry 130 high
    \ Address offset: 0x1414
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT131L_DEF
    \
    \ @brief Graphic MMU LUT entry 131 low
    \ Address offset: 0x1418
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT131H_DEF
    \
    \ @brief Graphic MMU LUT entry 131 high
    \ Address offset: 0x141C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT132L_DEF
    \
    \ @brief Graphic MMU LUT entry 132 low
    \ Address offset: 0x1420
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT132H_DEF
    \
    \ @brief Graphic MMU LUT entry 132 high
    \ Address offset: 0x1424
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT133L_DEF
    \
    \ @brief Graphic MMU LUT entry 133 low
    \ Address offset: 0x1428
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT133H_DEF
    \
    \ @brief Graphic MMU LUT entry 133 high
    \ Address offset: 0x142C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT134L_DEF
    \
    \ @brief Graphic MMU LUT entry 134 low
    \ Address offset: 0x1430
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT134H_DEF
    \
    \ @brief Graphic MMU LUT entry 134 high
    \ Address offset: 0x1434
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT135L_DEF
    \
    \ @brief Graphic MMU LUT entry 135 low
    \ Address offset: 0x1438
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT135H_DEF
    \
    \ @brief Graphic MMU LUT entry 135 high
    \ Address offset: 0x143C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT136L_DEF
    \
    \ @brief Graphic MMU LUT entry 136 low
    \ Address offset: 0x1440
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT136H_DEF
    \
    \ @brief Graphic MMU LUT entry 136 high
    \ Address offset: 0x1444
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT137L_DEF
    \
    \ @brief Graphic MMU LUT entry 137 low
    \ Address offset: 0x1448
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT137H_DEF
    \
    \ @brief Graphic MMU LUT entry 137 high
    \ Address offset: 0x144C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT138L_DEF
    \
    \ @brief Graphic MMU LUT entry 138 low
    \ Address offset: 0x1450
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT138H_DEF
    \
    \ @brief Graphic MMU LUT entry 138 high
    \ Address offset: 0x1454
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT139L_DEF
    \
    \ @brief Graphic MMU LUT entry 139 low
    \ Address offset: 0x1458
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT139H_DEF
    \
    \ @brief Graphic MMU LUT entry 139 high
    \ Address offset: 0x145C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT140L_DEF
    \
    \ @brief Graphic MMU LUT entry 140 low
    \ Address offset: 0x1460
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT140H_DEF
    \
    \ @brief Graphic MMU LUT entry 140 high
    \ Address offset: 0x1464
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT141L_DEF
    \
    \ @brief Graphic MMU LUT entry 141 low
    \ Address offset: 0x1468
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT141H_DEF
    \
    \ @brief Graphic MMU LUT entry 141 high
    \ Address offset: 0x146C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT142L_DEF
    \
    \ @brief Graphic MMU LUT entry 142 low
    \ Address offset: 0x1470
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT142H_DEF
    \
    \ @brief Graphic MMU LUT entry 142 high
    \ Address offset: 0x1474
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT143L_DEF
    \
    \ @brief Graphic MMU LUT entry 143 low
    \ Address offset: 0x1478
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT143H_DEF
    \
    \ @brief Graphic MMU LUT entry 143 high
    \ Address offset: 0x147C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT144L_DEF
    \
    \ @brief Graphic MMU LUT entry 144 low
    \ Address offset: 0x1480
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT144H_DEF
    \
    \ @brief Graphic MMU LUT entry 144 high
    \ Address offset: 0x1484
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT145L_DEF
    \
    \ @brief Graphic MMU LUT entry 145 low
    \ Address offset: 0x1488
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT145H_DEF
    \
    \ @brief Graphic MMU LUT entry 145 high
    \ Address offset: 0x148C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT146L_DEF
    \
    \ @brief Graphic MMU LUT entry 146 low
    \ Address offset: 0x1490
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT146H_DEF
    \
    \ @brief Graphic MMU LUT entry 146 high
    \ Address offset: 0x1494
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT147L_DEF
    \
    \ @brief Graphic MMU LUT entry 147 low
    \ Address offset: 0x1498
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT147H_DEF
    \
    \ @brief Graphic MMU LUT entry 147 high
    \ Address offset: 0x149C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT148L_DEF
    \
    \ @brief Graphic MMU LUT entry 148 low
    \ Address offset: 0x14A0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT148H_DEF
    \
    \ @brief Graphic MMU LUT entry 148 high
    \ Address offset: 0x14A4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT149L_DEF
    \
    \ @brief Graphic MMU LUT entry 149 low
    \ Address offset: 0x14A8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT149H_DEF
    \
    \ @brief Graphic MMU LUT entry 149 high
    \ Address offset: 0x14AC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT150L_DEF
    \
    \ @brief Graphic MMU LUT entry 150 low
    \ Address offset: 0x14B0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT150H_DEF
    \
    \ @brief Graphic MMU LUT entry 150 high
    \ Address offset: 0x14B4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT151L_DEF
    \
    \ @brief Graphic MMU LUT entry 151 low
    \ Address offset: 0x14B8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT151H_DEF
    \
    \ @brief Graphic MMU LUT entry 151 high
    \ Address offset: 0x14BC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT152L_DEF
    \
    \ @brief Graphic MMU LUT entry 152 low
    \ Address offset: 0x14C0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT152H_DEF
    \
    \ @brief Graphic MMU LUT entry 152 high
    \ Address offset: 0x14C4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT153L_DEF
    \
    \ @brief Graphic MMU LUT entry 153 low
    \ Address offset: 0x14C8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT153H_DEF
    \
    \ @brief Graphic MMU LUT entry 153 high
    \ Address offset: 0x14CC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT154L_DEF
    \
    \ @brief Graphic MMU LUT entry 154 low
    \ Address offset: 0x14D0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT154H_DEF
    \
    \ @brief Graphic MMU LUT entry 154 high
    \ Address offset: 0x14D4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT155L_DEF
    \
    \ @brief Graphic MMU LUT entry 155 low
    \ Address offset: 0x14D8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT155H_DEF
    \
    \ @brief Graphic MMU LUT entry 155 high
    \ Address offset: 0x14DC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT156L_DEF
    \
    \ @brief Graphic MMU LUT entry 156 low
    \ Address offset: 0x14E0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT156H_DEF
    \
    \ @brief Graphic MMU LUT entry 156 high
    \ Address offset: 0x14E4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT157L_DEF
    \
    \ @brief Graphic MMU LUT entry 157 low
    \ Address offset: 0x14E8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT157H_DEF
    \
    \ @brief Graphic MMU LUT entry 157 high
    \ Address offset: 0x14EC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT158L_DEF
    \
    \ @brief Graphic MMU LUT entry 158 low
    \ Address offset: 0x14F0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT158H_DEF
    \
    \ @brief Graphic MMU LUT entry 158 high
    \ Address offset: 0x14F4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT159L_DEF
    \
    \ @brief Graphic MMU LUT entry 159 low
    \ Address offset: 0x14F8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT159H_DEF
    \
    \ @brief Graphic MMU LUT entry 159 high
    \ Address offset: 0x14FC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT160L_DEF
    \
    \ @brief Graphic MMU LUT entry 160 low
    \ Address offset: 0x1500
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT160H_DEF
    \
    \ @brief Graphic MMU LUT entry 160 high
    \ Address offset: 0x1504
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT161L_DEF
    \
    \ @brief Graphic MMU LUT entry 161 low
    \ Address offset: 0x1508
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT161H_DEF
    \
    \ @brief Graphic MMU LUT entry 161 high
    \ Address offset: 0x150C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT162L_DEF
    \
    \ @brief Graphic MMU LUT entry 162 low
    \ Address offset: 0x1510
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT162H_DEF
    \
    \ @brief Graphic MMU LUT entry 162 high
    \ Address offset: 0x1514
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT163L_DEF
    \
    \ @brief Graphic MMU LUT entry 163 low
    \ Address offset: 0x1518
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT163H_DEF
    \
    \ @brief Graphic MMU LUT entry 163 high
    \ Address offset: 0x151C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT164L_DEF
    \
    \ @brief Graphic MMU LUT entry 164 low
    \ Address offset: 0x1520
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT164H_DEF
    \
    \ @brief Graphic MMU LUT entry 164 high
    \ Address offset: 0x1524
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT165L_DEF
    \
    \ @brief Graphic MMU LUT entry 165 low
    \ Address offset: 0x1528
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT165H_DEF
    \
    \ @brief Graphic MMU LUT entry 165 high
    \ Address offset: 0x152C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT166L_DEF
    \
    \ @brief Graphic MMU LUT entry 166 low
    \ Address offset: 0x1530
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT166H_DEF
    \
    \ @brief Graphic MMU LUT entry 166 high
    \ Address offset: 0x1534
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT167L_DEF
    \
    \ @brief Graphic MMU LUT entry 167 low
    \ Address offset: 0x1538
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT167H_DEF
    \
    \ @brief Graphic MMU LUT entry 167 high
    \ Address offset: 0x153C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT168L_DEF
    \
    \ @brief Graphic MMU LUT entry 168 low
    \ Address offset: 0x1540
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT168H_DEF
    \
    \ @brief Graphic MMU LUT entry 168 high
    \ Address offset: 0x1544
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT169L_DEF
    \
    \ @brief Graphic MMU LUT entry 169 low
    \ Address offset: 0x1548
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT169H_DEF
    \
    \ @brief Graphic MMU LUT entry 169 high
    \ Address offset: 0x154C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT170L_DEF
    \
    \ @brief Graphic MMU LUT entry 170 low
    \ Address offset: 0x1550
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT170H_DEF
    \
    \ @brief Graphic MMU LUT entry 170 high
    \ Address offset: 0x1554
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT171L_DEF
    \
    \ @brief Graphic MMU LUT entry 171 low
    \ Address offset: 0x1558
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT171H_DEF
    \
    \ @brief Graphic MMU LUT entry 171 high
    \ Address offset: 0x155C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT172L_DEF
    \
    \ @brief Graphic MMU LUT entry 172 low
    \ Address offset: 0x1560
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT172H_DEF
    \
    \ @brief Graphic MMU LUT entry 172 high
    \ Address offset: 0x1564
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT173L_DEF
    \
    \ @brief Graphic MMU LUT entry 173 low
    \ Address offset: 0x1568
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT173H_DEF
    \
    \ @brief Graphic MMU LUT entry 173 high
    \ Address offset: 0x156C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT174L_DEF
    \
    \ @brief Graphic MMU LUT entry 174 low
    \ Address offset: 0x1570
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT174H_DEF
    \
    \ @brief Graphic MMU LUT entry 174 high
    \ Address offset: 0x1574
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT175L_DEF
    \
    \ @brief Graphic MMU LUT entry 175 low
    \ Address offset: 0x1578
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT175H_DEF
    \
    \ @brief Graphic MMU LUT entry 175 high
    \ Address offset: 0x157C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT176L_DEF
    \
    \ @brief Graphic MMU LUT entry 176 low
    \ Address offset: 0x1580
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT176H_DEF
    \
    \ @brief Graphic MMU LUT entry 176 high
    \ Address offset: 0x1584
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT177L_DEF
    \
    \ @brief Graphic MMU LUT entry 177 low
    \ Address offset: 0x1588
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT177H_DEF
    \
    \ @brief Graphic MMU LUT entry 177 high
    \ Address offset: 0x158C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT178L_DEF
    \
    \ @brief Graphic MMU LUT entry 178 low
    \ Address offset: 0x1590
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT178H_DEF
    \
    \ @brief Graphic MMU LUT entry 178 high
    \ Address offset: 0x1594
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT179L_DEF
    \
    \ @brief Graphic MMU LUT entry 179 low
    \ Address offset: 0x1598
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT179H_DEF
    \
    \ @brief Graphic MMU LUT entry 179 high
    \ Address offset: 0x159C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT180L_DEF
    \
    \ @brief Graphic MMU LUT entry 180 low
    \ Address offset: 0x15A0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT180H_DEF
    \
    \ @brief Graphic MMU LUT entry 180 high
    \ Address offset: 0x15A4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT181L_DEF
    \
    \ @brief Graphic MMU LUT entry 181 low
    \ Address offset: 0x15A8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT181H_DEF
    \
    \ @brief Graphic MMU LUT entry 181 high
    \ Address offset: 0x15AC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT182L_DEF
    \
    \ @brief Graphic MMU LUT entry 182 low
    \ Address offset: 0x15B0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT182H_DEF
    \
    \ @brief Graphic MMU LUT entry 182 high
    \ Address offset: 0x15B4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT183L_DEF
    \
    \ @brief Graphic MMU LUT entry 183 low
    \ Address offset: 0x15B8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT183H_DEF
    \
    \ @brief Graphic MMU LUT entry 183 high
    \ Address offset: 0x15BC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT184L_DEF
    \
    \ @brief Graphic MMU LUT entry 184 low
    \ Address offset: 0x15C0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT184H_DEF
    \
    \ @brief Graphic MMU LUT entry 184 high
    \ Address offset: 0x15C4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT185L_DEF
    \
    \ @brief Graphic MMU LUT entry 185 low
    \ Address offset: 0x15C8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT185H_DEF
    \
    \ @brief Graphic MMU LUT entry 185 high
    \ Address offset: 0x15CC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT186L_DEF
    \
    \ @brief Graphic MMU LUT entry 186 low
    \ Address offset: 0x15D0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT186H_DEF
    \
    \ @brief Graphic MMU LUT entry 186 high
    \ Address offset: 0x15D4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT187L_DEF
    \
    \ @brief Graphic MMU LUT entry 187 low
    \ Address offset: 0x15D8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT187H_DEF
    \
    \ @brief Graphic MMU LUT entry 187 high
    \ Address offset: 0x15DC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT188L_DEF
    \
    \ @brief Graphic MMU LUT entry 188 low
    \ Address offset: 0x15E0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT188H_DEF
    \
    \ @brief Graphic MMU LUT entry 188 high
    \ Address offset: 0x15E4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT189L_DEF
    \
    \ @brief Graphic MMU LUT entry 189 low
    \ Address offset: 0x15E8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT189H_DEF
    \
    \ @brief Graphic MMU LUT entry 189 high
    \ Address offset: 0x15EC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT190L_DEF
    \
    \ @brief Graphic MMU LUT entry 190 low
    \ Address offset: 0x15F0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT190H_DEF
    \
    \ @brief Graphic MMU LUT entry 190 high
    \ Address offset: 0x15F4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT191L_DEF
    \
    \ @brief Graphic MMU LUT entry 191 low
    \ Address offset: 0x15F8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT191H_DEF
    \
    \ @brief Graphic MMU LUT entry 191 high
    \ Address offset: 0x15FC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT192L_DEF
    \
    \ @brief Graphic MMU LUT entry 192 low
    \ Address offset: 0x1600
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT192H_DEF
    \
    \ @brief Graphic MMU LUT entry 192 high
    \ Address offset: 0x1604
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT193L_DEF
    \
    \ @brief Graphic MMU LUT entry 193 low
    \ Address offset: 0x1608
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT193H_DEF
    \
    \ @brief Graphic MMU LUT entry 193 high
    \ Address offset: 0x160C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT194L_DEF
    \
    \ @brief Graphic MMU LUT entry 194 low
    \ Address offset: 0x1610
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT194H_DEF
    \
    \ @brief Graphic MMU LUT entry 194 high
    \ Address offset: 0x1614
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT195L_DEF
    \
    \ @brief Graphic MMU LUT entry 195 low
    \ Address offset: 0x1618
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT195H_DEF
    \
    \ @brief Graphic MMU LUT entry 195 high
    \ Address offset: 0x161C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT196L_DEF
    \
    \ @brief Graphic MMU LUT entry 196 low
    \ Address offset: 0x1620
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT196H_DEF
    \
    \ @brief Graphic MMU LUT entry 196 high
    \ Address offset: 0x1624
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT197L_DEF
    \
    \ @brief Graphic MMU LUT entry 197 low
    \ Address offset: 0x1628
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT197H_DEF
    \
    \ @brief Graphic MMU LUT entry 197 high
    \ Address offset: 0x162C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT198L_DEF
    \
    \ @brief Graphic MMU LUT entry 198 low
    \ Address offset: 0x1630
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT198H_DEF
    \
    \ @brief Graphic MMU LUT entry 198 high
    \ Address offset: 0x1634
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT199L_DEF
    \
    \ @brief Graphic MMU LUT entry 199 low
    \ Address offset: 0x1638
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT199H_DEF
    \
    \ @brief Graphic MMU LUT entry 199 high
    \ Address offset: 0x163C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT200L_DEF
    \
    \ @brief Graphic MMU LUT entry 200 low
    \ Address offset: 0x1640
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT200H_DEF
    \
    \ @brief Graphic MMU LUT entry 200 high
    \ Address offset: 0x1644
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT201L_DEF
    \
    \ @brief Graphic MMU LUT entry 201 low
    \ Address offset: 0x1648
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT201H_DEF
    \
    \ @brief Graphic MMU LUT entry 201 high
    \ Address offset: 0x164C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT202L_DEF
    \
    \ @brief Graphic MMU LUT entry 202 low
    \ Address offset: 0x1650
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT202H_DEF
    \
    \ @brief Graphic MMU LUT entry 202 high
    \ Address offset: 0x1654
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT203L_DEF
    \
    \ @brief Graphic MMU LUT entry 203 low
    \ Address offset: 0x1658
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT203H_DEF
    \
    \ @brief Graphic MMU LUT entry 203 high
    \ Address offset: 0x165C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT204L_DEF
    \
    \ @brief Graphic MMU LUT entry 204 low
    \ Address offset: 0x1660
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT204H_DEF
    \
    \ @brief Graphic MMU LUT entry 204 high
    \ Address offset: 0x1664
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT205L_DEF
    \
    \ @brief Graphic MMU LUT entry 205 low
    \ Address offset: 0x1668
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT205H_DEF
    \
    \ @brief Graphic MMU LUT entry 205 high
    \ Address offset: 0x166C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT206L_DEF
    \
    \ @brief Graphic MMU LUT entry 206 low
    \ Address offset: 0x1670
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT206H_DEF
    \
    \ @brief Graphic MMU LUT entry 206 high
    \ Address offset: 0x1674
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT207L_DEF
    \
    \ @brief Graphic MMU LUT entry 207 low
    \ Address offset: 0x1678
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT207H_DEF
    \
    \ @brief Graphic MMU LUT entry 207 high
    \ Address offset: 0x167C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT208L_DEF
    \
    \ @brief Graphic MMU LUT entry 208 low
    \ Address offset: 0x1680
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT208H_DEF
    \
    \ @brief Graphic MMU LUT entry 208 high
    \ Address offset: 0x1684
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT209L_DEF
    \
    \ @brief Graphic MMU LUT entry 209 low
    \ Address offset: 0x1688
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT209H_DEF
    \
    \ @brief Graphic MMU LUT entry 209 high
    \ Address offset: 0x168C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT210L_DEF
    \
    \ @brief Graphic MMU LUT entry 210 low
    \ Address offset: 0x1690
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT210H_DEF
    \
    \ @brief Graphic MMU LUT entry 210 high
    \ Address offset: 0x1694
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT211L_DEF
    \
    \ @brief Graphic MMU LUT entry 211 low
    \ Address offset: 0x1698
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT211H_DEF
    \
    \ @brief Graphic MMU LUT entry 211 high
    \ Address offset: 0x169C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT212L_DEF
    \
    \ @brief Graphic MMU LUT entry 212 low
    \ Address offset: 0x16A0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT212H_DEF
    \
    \ @brief Graphic MMU LUT entry 212 high
    \ Address offset: 0x16A4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT213L_DEF
    \
    \ @brief Graphic MMU LUT entry 213 low
    \ Address offset: 0x16A8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT213H_DEF
    \
    \ @brief Graphic MMU LUT entry 213 high
    \ Address offset: 0x16AC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT214L_DEF
    \
    \ @brief Graphic MMU LUT entry 214 low
    \ Address offset: 0x16B0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT214H_DEF
    \
    \ @brief Graphic MMU LUT entry 214 high
    \ Address offset: 0x16B4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT215L_DEF
    \
    \ @brief Graphic MMU LUT entry 215 low
    \ Address offset: 0x16B8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT215H_DEF
    \
    \ @brief Graphic MMU LUT entry 215 high
    \ Address offset: 0x16BC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT216L_DEF
    \
    \ @brief Graphic MMU LUT entry 216 low
    \ Address offset: 0x16C0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT216H_DEF
    \
    \ @brief Graphic MMU LUT entry 216 high
    \ Address offset: 0x16C4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT217L_DEF
    \
    \ @brief Graphic MMU LUT entry 217 low
    \ Address offset: 0x16C8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT217H_DEF
    \
    \ @brief Graphic MMU LUT entry 217 high
    \ Address offset: 0x16CC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT218L_DEF
    \
    \ @brief Graphic MMU LUT entry 218 low
    \ Address offset: 0x16D0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT218H_DEF
    \
    \ @brief Graphic MMU LUT entry 218 high
    \ Address offset: 0x16D4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT219L_DEF
    \
    \ @brief Graphic MMU LUT entry 219 low
    \ Address offset: 0x16D8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT219H_DEF
    \
    \ @brief Graphic MMU LUT entry 219 high
    \ Address offset: 0x16DC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT220L_DEF
    \
    \ @brief Graphic MMU LUT entry 220 low
    \ Address offset: 0x16E0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT220H_DEF
    \
    \ @brief Graphic MMU LUT entry 220 high
    \ Address offset: 0x16E4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT221L_DEF
    \
    \ @brief Graphic MMU LUT entry 221 low
    \ Address offset: 0x16E8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT221H_DEF
    \
    \ @brief Graphic MMU LUT entry 221 high
    \ Address offset: 0x16EC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT222L_DEF
    \
    \ @brief Graphic MMU LUT entry 222 low
    \ Address offset: 0x16F0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT222H_DEF
    \
    \ @brief Graphic MMU LUT entry 222 high
    \ Address offset: 0x16F4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT223L_DEF
    \
    \ @brief Graphic MMU LUT entry 223 low
    \ Address offset: 0x16F8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT223H_DEF
    \
    \ @brief Graphic MMU LUT entry 223 high
    \ Address offset: 0x16FC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT224L_DEF
    \
    \ @brief Graphic MMU LUT entry 224 low
    \ Address offset: 0x1700
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT224H_DEF
    \
    \ @brief Graphic MMU LUT entry 224 high
    \ Address offset: 0x1704
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT225L_DEF
    \
    \ @brief Graphic MMU LUT entry 225 low
    \ Address offset: 0x1708
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT225H_DEF
    \
    \ @brief Graphic MMU LUT entry 225 high
    \ Address offset: 0x170C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT226L_DEF
    \
    \ @brief Graphic MMU LUT entry 226 low
    \ Address offset: 0x1710
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT226H_DEF
    \
    \ @brief Graphic MMU LUT entry 226 high
    \ Address offset: 0x1714
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT227L_DEF
    \
    \ @brief Graphic MMU LUT entry 227 low
    \ Address offset: 0x1718
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT227H_DEF
    \
    \ @brief Graphic MMU LUT entry 227 high
    \ Address offset: 0x171C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT228L_DEF
    \
    \ @brief Graphic MMU LUT entry 228 low
    \ Address offset: 0x1720
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT228H_DEF
    \
    \ @brief Graphic MMU LUT entry 228 high
    \ Address offset: 0x1724
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT229L_DEF
    \
    \ @brief Graphic MMU LUT entry 229 low
    \ Address offset: 0x1728
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT229H_DEF
    \
    \ @brief Graphic MMU LUT entry 229 high
    \ Address offset: 0x172C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT230L_DEF
    \
    \ @brief Graphic MMU LUT entry 230 low
    \ Address offset: 0x1730
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT230H_DEF
    \
    \ @brief Graphic MMU LUT entry 230 high
    \ Address offset: 0x1734
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT231L_DEF
    \
    \ @brief Graphic MMU LUT entry 231 low
    \ Address offset: 0x1738
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT231H_DEF
    \
    \ @brief Graphic MMU LUT entry 231 high
    \ Address offset: 0x173C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT232L_DEF
    \
    \ @brief Graphic MMU LUT entry 232 low
    \ Address offset: 0x1740
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT232H_DEF
    \
    \ @brief Graphic MMU LUT entry 232 high
    \ Address offset: 0x1744
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT233L_DEF
    \
    \ @brief Graphic MMU LUT entry 233 low
    \ Address offset: 0x1748
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT233H_DEF
    \
    \ @brief Graphic MMU LUT entry 233 high
    \ Address offset: 0x174C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT234L_DEF
    \
    \ @brief Graphic MMU LUT entry 234 low
    \ Address offset: 0x1750
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT234H_DEF
    \
    \ @brief Graphic MMU LUT entry 234 high
    \ Address offset: 0x1754
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT235L_DEF
    \
    \ @brief Graphic MMU LUT entry 235 low
    \ Address offset: 0x1758
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT235H_DEF
    \
    \ @brief Graphic MMU LUT entry 235 high
    \ Address offset: 0x175C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT236L_DEF
    \
    \ @brief Graphic MMU LUT entry 236 low
    \ Address offset: 0x1760
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT236H_DEF
    \
    \ @brief Graphic MMU LUT entry 236 high
    \ Address offset: 0x1764
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT237L_DEF
    \
    \ @brief Graphic MMU LUT entry 237 low
    \ Address offset: 0x1768
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT237H_DEF
    \
    \ @brief Graphic MMU LUT entry 237 high
    \ Address offset: 0x176C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT238L_DEF
    \
    \ @brief Graphic MMU LUT entry 238 low
    \ Address offset: 0x1770
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT238H_DEF
    \
    \ @brief Graphic MMU LUT entry 238 high
    \ Address offset: 0x1774
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT239L_DEF
    \
    \ @brief Graphic MMU LUT entry 239 low
    \ Address offset: 0x1778
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT239H_DEF
    \
    \ @brief Graphic MMU LUT entry 239 high
    \ Address offset: 0x177C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT240L_DEF
    \
    \ @brief Graphic MMU LUT entry 240 low
    \ Address offset: 0x1780
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT240H_DEF
    \
    \ @brief Graphic MMU LUT entry 240 high
    \ Address offset: 0x1784
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT241L_DEF
    \
    \ @brief Graphic MMU LUT entry 241 low
    \ Address offset: 0x1788
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT241H_DEF
    \
    \ @brief Graphic MMU LUT entry 241 high
    \ Address offset: 0x178C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT242L_DEF
    \
    \ @brief Graphic MMU LUT entry 242 low
    \ Address offset: 0x1790
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT242H_DEF
    \
    \ @brief Graphic MMU LUT entry 242 high
    \ Address offset: 0x1794
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT243L_DEF
    \
    \ @brief Graphic MMU LUT entry 243 low
    \ Address offset: 0x1798
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT243H_DEF
    \
    \ @brief Graphic MMU LUT entry 243 high
    \ Address offset: 0x179C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT244L_DEF
    \
    \ @brief Graphic MMU LUT entry 244 low
    \ Address offset: 0x17A0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT244H_DEF
    \
    \ @brief Graphic MMU LUT entry 244 high
    \ Address offset: 0x17A4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT245L_DEF
    \
    \ @brief Graphic MMU LUT entry 245 low
    \ Address offset: 0x17A8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT245H_DEF
    \
    \ @brief Graphic MMU LUT entry 245 high
    \ Address offset: 0x17AC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT246L_DEF
    \
    \ @brief Graphic MMU LUT entry 246 low
    \ Address offset: 0x17B0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT246H_DEF
    \
    \ @brief Graphic MMU LUT entry 246 high
    \ Address offset: 0x17B4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT247L_DEF
    \
    \ @brief Graphic MMU LUT entry 247 low
    \ Address offset: 0x17B8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT247H_DEF
    \
    \ @brief Graphic MMU LUT entry 247 high
    \ Address offset: 0x17BC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT248L_DEF
    \
    \ @brief Graphic MMU LUT entry 248 low
    \ Address offset: 0x17C0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT248H_DEF
    \
    \ @brief Graphic MMU LUT entry 248 high
    \ Address offset: 0x17C4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT249L_DEF
    \
    \ @brief Graphic MMU LUT entry 249 low
    \ Address offset: 0x17C8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT249H_DEF
    \
    \ @brief Graphic MMU LUT entry 249 high
    \ Address offset: 0x17CC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT250L_DEF
    \
    \ @brief Graphic MMU LUT entry 250 low
    \ Address offset: 0x17D0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT250H_DEF
    \
    \ @brief Graphic MMU LUT entry 250 high
    \ Address offset: 0x17D4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT251L_DEF
    \
    \ @brief Graphic MMU LUT entry 251 low
    \ Address offset: 0x17D8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT251H_DEF
    \
    \ @brief Graphic MMU LUT entry 251 high
    \ Address offset: 0x17DC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT252L_DEF
    \
    \ @brief Graphic MMU LUT entry 252 low
    \ Address offset: 0x17E0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT252H_DEF
    \
    \ @brief Graphic MMU LUT entry 252 high
    \ Address offset: 0x17E4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT253L_DEF
    \
    \ @brief Graphic MMU LUT entry 253 low
    \ Address offset: 0x17E8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT253H_DEF
    \
    \ @brief Graphic MMU LUT entry 253 high
    \ Address offset: 0x17EC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT254L_DEF
    \
    \ @brief Graphic MMU LUT entry 254 low
    \ Address offset: 0x17F0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT254H_DEF
    \
    \ @brief Graphic MMU LUT entry 254 high
    \ Address offset: 0x17F4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT255L_DEF
    \
    \ @brief Graphic MMU LUT entry 255 low
    \ Address offset: 0x17F8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT255H_DEF
    \
    \ @brief Graphic MMU LUT entry 255 high
    \ Address offset: 0x17FC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT256L_DEF
    \
    \ @brief Graphic MMU LUT entry 256 low
    \ Address offset: 0x1800
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT256H_DEF
    \
    \ @brief Graphic MMU LUT entry 256 high
    \ Address offset: 0x1804
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT257L_DEF
    \
    \ @brief Graphic MMU LUT entry 257 low
    \ Address offset: 0x1808
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT257H_DEF
    \
    \ @brief Graphic MMU LUT entry 257 high
    \ Address offset: 0x180C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT258L_DEF
    \
    \ @brief Graphic MMU LUT entry 258 low
    \ Address offset: 0x1810
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT258H_DEF
    \
    \ @brief Graphic MMU LUT entry 258 high
    \ Address offset: 0x1814
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT259L_DEF
    \
    \ @brief Graphic MMU LUT entry 259 low
    \ Address offset: 0x1818
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT259H_DEF
    \
    \ @brief Graphic MMU LUT entry 259 high
    \ Address offset: 0x181C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT260L_DEF
    \
    \ @brief Graphic MMU LUT entry 260 low
    \ Address offset: 0x1820
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT260H_DEF
    \
    \ @brief Graphic MMU LUT entry 260 high
    \ Address offset: 0x1824
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT261L_DEF
    \
    \ @brief Graphic MMU LUT entry 261 low
    \ Address offset: 0x1828
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT261H_DEF
    \
    \ @brief Graphic MMU LUT entry 261 high
    \ Address offset: 0x182C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT262L_DEF
    \
    \ @brief Graphic MMU LUT entry 262 low
    \ Address offset: 0x1830
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT262H_DEF
    \
    \ @brief Graphic MMU LUT entry 262 high
    \ Address offset: 0x1834
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT263L_DEF
    \
    \ @brief Graphic MMU LUT entry 263 low
    \ Address offset: 0x1838
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT263H_DEF
    \
    \ @brief Graphic MMU LUT entry 263 high
    \ Address offset: 0x183C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT264L_DEF
    \
    \ @brief Graphic MMU LUT entry 264 low
    \ Address offset: 0x1840
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT264H_DEF
    \
    \ @brief Graphic MMU LUT entry 264 high
    \ Address offset: 0x1844
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT265L_DEF
    \
    \ @brief Graphic MMU LUT entry 265 low
    \ Address offset: 0x1848
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT265H_DEF
    \
    \ @brief Graphic MMU LUT entry 265 high
    \ Address offset: 0x184C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT266L_DEF
    \
    \ @brief Graphic MMU LUT entry 266 low
    \ Address offset: 0x1850
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT266H_DEF
    \
    \ @brief Graphic MMU LUT entry 266 high
    \ Address offset: 0x1854
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT267L_DEF
    \
    \ @brief Graphic MMU LUT entry 267 low
    \ Address offset: 0x1858
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT267H_DEF
    \
    \ @brief Graphic MMU LUT entry 267 high
    \ Address offset: 0x185C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT268L_DEF
    \
    \ @brief Graphic MMU LUT entry 268 low
    \ Address offset: 0x1860
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT268H_DEF
    \
    \ @brief Graphic MMU LUT entry 268 high
    \ Address offset: 0x1864
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT269L_DEF
    \
    \ @brief Graphic MMU LUT entry 269 low
    \ Address offset: 0x1868
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT269H_DEF
    \
    \ @brief Graphic MMU LUT entry 269 high
    \ Address offset: 0x186C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT270L_DEF
    \
    \ @brief Graphic MMU LUT entry 270 low
    \ Address offset: 0x1870
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT270H_DEF
    \
    \ @brief Graphic MMU LUT entry 270 high
    \ Address offset: 0x1874
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT271L_DEF
    \
    \ @brief Graphic MMU LUT entry 271 low
    \ Address offset: 0x1878
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT271H_DEF
    \
    \ @brief Graphic MMU LUT entry 271 high
    \ Address offset: 0x187C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT272L_DEF
    \
    \ @brief Graphic MMU LUT entry 272 low
    \ Address offset: 0x1880
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT272H_DEF
    \
    \ @brief Graphic MMU LUT entry 272 high
    \ Address offset: 0x1884
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT273L_DEF
    \
    \ @brief Graphic MMU LUT entry 273 low
    \ Address offset: 0x1888
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT273H_DEF
    \
    \ @brief Graphic MMU LUT entry 273 high
    \ Address offset: 0x188C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT274L_DEF
    \
    \ @brief Graphic MMU LUT entry 274 low
    \ Address offset: 0x1890
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT274H_DEF
    \
    \ @brief Graphic MMU LUT entry 274 high
    \ Address offset: 0x1894
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT275L_DEF
    \
    \ @brief Graphic MMU LUT entry 275 low
    \ Address offset: 0x1898
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT275H_DEF
    \
    \ @brief Graphic MMU LUT entry 275 high
    \ Address offset: 0x189C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT276L_DEF
    \
    \ @brief Graphic MMU LUT entry 276 low
    \ Address offset: 0x18A0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT276H_DEF
    \
    \ @brief Graphic MMU LUT entry 276 high
    \ Address offset: 0x18A4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT277L_DEF
    \
    \ @brief Graphic MMU LUT entry 277 low
    \ Address offset: 0x18A8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT277H_DEF
    \
    \ @brief Graphic MMU LUT entry 277 high
    \ Address offset: 0x18AC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT278L_DEF
    \
    \ @brief Graphic MMU LUT entry 278 low
    \ Address offset: 0x18B0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT278H_DEF
    \
    \ @brief Graphic MMU LUT entry 278 high
    \ Address offset: 0x18B4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT279L_DEF
    \
    \ @brief Graphic MMU LUT entry 279 low
    \ Address offset: 0x18B8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT279H_DEF
    \
    \ @brief Graphic MMU LUT entry 279 high
    \ Address offset: 0x18BC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT280L_DEF
    \
    \ @brief Graphic MMU LUT entry 280 low
    \ Address offset: 0x18C0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT280H_DEF
    \
    \ @brief Graphic MMU LUT entry 280 high
    \ Address offset: 0x18C4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT281L_DEF
    \
    \ @brief Graphic MMU LUT entry 281 low
    \ Address offset: 0x18C8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT281H_DEF
    \
    \ @brief Graphic MMU LUT entry 281 high
    \ Address offset: 0x18CC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT282L_DEF
    \
    \ @brief Graphic MMU LUT entry 282 low
    \ Address offset: 0x18D0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT282H_DEF
    \
    \ @brief Graphic MMU LUT entry 282 high
    \ Address offset: 0x18D4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT283L_DEF
    \
    \ @brief Graphic MMU LUT entry 283 low
    \ Address offset: 0x18D8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT283H_DEF
    \
    \ @brief Graphic MMU LUT entry 283 high
    \ Address offset: 0x18DC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT284L_DEF
    \
    \ @brief Graphic MMU LUT entry 284 low
    \ Address offset: 0x18E0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT284H_DEF
    \
    \ @brief Graphic MMU LUT entry 284 high
    \ Address offset: 0x18E4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT285L_DEF
    \
    \ @brief Graphic MMU LUT entry 285 low
    \ Address offset: 0x18E8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT285H_DEF
    \
    \ @brief Graphic MMU LUT entry 285 high
    \ Address offset: 0x18EC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT286L_DEF
    \
    \ @brief Graphic MMU LUT entry 286 low
    \ Address offset: 0x18F0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT286H_DEF
    \
    \ @brief Graphic MMU LUT entry 286 high
    \ Address offset: 0x18F4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT287L_DEF
    \
    \ @brief Graphic MMU LUT entry 287 low
    \ Address offset: 0x18F8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT287H_DEF
    \
    \ @brief Graphic MMU LUT entry 287 high
    \ Address offset: 0x18FC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT288L_DEF
    \
    \ @brief Graphic MMU LUT entry 288 low
    \ Address offset: 0x1900
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT288H_DEF
    \
    \ @brief Graphic MMU LUT entry 288 high
    \ Address offset: 0x1904
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT289L_DEF
    \
    \ @brief Graphic MMU LUT entry 289 low
    \ Address offset: 0x1908
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT289H_DEF
    \
    \ @brief Graphic MMU LUT entry 289 high
    \ Address offset: 0x190C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT290L_DEF
    \
    \ @brief Graphic MMU LUT entry 290 low
    \ Address offset: 0x1910
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT290H_DEF
    \
    \ @brief Graphic MMU LUT entry 290 high
    \ Address offset: 0x1914
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT291L_DEF
    \
    \ @brief Graphic MMU LUT entry 291 low
    \ Address offset: 0x1918
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT291H_DEF
    \
    \ @brief Graphic MMU LUT entry 291 high
    \ Address offset: 0x191C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT292L_DEF
    \
    \ @brief Graphic MMU LUT entry 292 low
    \ Address offset: 0x1920
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT292H_DEF
    \
    \ @brief Graphic MMU LUT entry 292 high
    \ Address offset: 0x1924
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT293L_DEF
    \
    \ @brief Graphic MMU LUT entry 293 low
    \ Address offset: 0x1928
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT293H_DEF
    \
    \ @brief Graphic MMU LUT entry 293 high
    \ Address offset: 0x192C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT294L_DEF
    \
    \ @brief Graphic MMU LUT entry 294 low
    \ Address offset: 0x1930
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT294H_DEF
    \
    \ @brief Graphic MMU LUT entry 294 high
    \ Address offset: 0x1934
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT295L_DEF
    \
    \ @brief Graphic MMU LUT entry 295 low
    \ Address offset: 0x1938
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT295H_DEF
    \
    \ @brief Graphic MMU LUT entry 295 high
    \ Address offset: 0x193C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT296L_DEF
    \
    \ @brief Graphic MMU LUT entry 296 low
    \ Address offset: 0x1940
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT296H_DEF
    \
    \ @brief Graphic MMU LUT entry 296 high
    \ Address offset: 0x1944
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT297L_DEF
    \
    \ @brief Graphic MMU LUT entry 297 low
    \ Address offset: 0x1948
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT297H_DEF
    \
    \ @brief Graphic MMU LUT entry 297 high
    \ Address offset: 0x194C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT298L_DEF
    \
    \ @brief Graphic MMU LUT entry 298 low
    \ Address offset: 0x1950
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT298H_DEF
    \
    \ @brief Graphic MMU LUT entry 298 high
    \ Address offset: 0x1954
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT299L_DEF
    \
    \ @brief Graphic MMU LUT entry 299 low
    \ Address offset: 0x1958
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT299H_DEF
    \
    \ @brief Graphic MMU LUT entry 299 high
    \ Address offset: 0x195C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT300L_DEF
    \
    \ @brief Graphic MMU LUT entry 300 low
    \ Address offset: 0x1960
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT300H_DEF
    \
    \ @brief Graphic MMU LUT entry 300 high
    \ Address offset: 0x1964
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT301L_DEF
    \
    \ @brief Graphic MMU LUT entry 301 low
    \ Address offset: 0x1968
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT301H_DEF
    \
    \ @brief Graphic MMU LUT entry 301 high
    \ Address offset: 0x196C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT302L_DEF
    \
    \ @brief Graphic MMU LUT entry 302 low
    \ Address offset: 0x1970
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT302H_DEF
    \
    \ @brief Graphic MMU LUT entry 302 high
    \ Address offset: 0x1974
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT303L_DEF
    \
    \ @brief Graphic MMU LUT entry 303 low
    \ Address offset: 0x1978
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT303H_DEF
    \
    \ @brief Graphic MMU LUT entry 303 high
    \ Address offset: 0x197C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT304L_DEF
    \
    \ @brief Graphic MMU LUT entry 304 low
    \ Address offset: 0x1980
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT304H_DEF
    \
    \ @brief Graphic MMU LUT entry 304 high
    \ Address offset: 0x1984
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT305L_DEF
    \
    \ @brief Graphic MMU LUT entry 305 low
    \ Address offset: 0x1988
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT305H_DEF
    \
    \ @brief Graphic MMU LUT entry 305 high
    \ Address offset: 0x198C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT306L_DEF
    \
    \ @brief Graphic MMU LUT entry 306 low
    \ Address offset: 0x1990
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT306H_DEF
    \
    \ @brief Graphic MMU LUT entry 306 high
    \ Address offset: 0x1994
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT307L_DEF
    \
    \ @brief Graphic MMU LUT entry 307 low
    \ Address offset: 0x1998
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT307H_DEF
    \
    \ @brief Graphic MMU LUT entry 307 high
    \ Address offset: 0x199C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT308L_DEF
    \
    \ @brief Graphic MMU LUT entry 308 low
    \ Address offset: 0x19A0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT308H_DEF
    \
    \ @brief Graphic MMU LUT entry 308 high
    \ Address offset: 0x19A4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT309L_DEF
    \
    \ @brief Graphic MMU LUT entry 309 low
    \ Address offset: 0x19A8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT309H_DEF
    \
    \ @brief Graphic MMU LUT entry 309 high
    \ Address offset: 0x19AC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT310L_DEF
    \
    \ @brief Graphic MMU LUT entry 310 low
    \ Address offset: 0x19B0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT310H_DEF
    \
    \ @brief Graphic MMU LUT entry 310 high
    \ Address offset: 0x19B4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT311L_DEF
    \
    \ @brief Graphic MMU LUT entry 311 low
    \ Address offset: 0x19B8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT311H_DEF
    \
    \ @brief Graphic MMU LUT entry 311 high
    \ Address offset: 0x19BC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT312L_DEF
    \
    \ @brief Graphic MMU LUT entry 312 low
    \ Address offset: 0x19C0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT312H_DEF
    \
    \ @brief Graphic MMU LUT entry 312 high
    \ Address offset: 0x19C4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT313L_DEF
    \
    \ @brief Graphic MMU LUT entry 313 low
    \ Address offset: 0x19C8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT313H_DEF
    \
    \ @brief Graphic MMU LUT entry 313 high
    \ Address offset: 0x19CC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT314L_DEF
    \
    \ @brief Graphic MMU LUT entry 314 low
    \ Address offset: 0x19D0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT314H_DEF
    \
    \ @brief Graphic MMU LUT entry 314 high
    \ Address offset: 0x19D4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT315L_DEF
    \
    \ @brief Graphic MMU LUT entry 315 low
    \ Address offset: 0x19D8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT315H_DEF
    \
    \ @brief Graphic MMU LUT entry 315 high
    \ Address offset: 0x19DC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT316L_DEF
    \
    \ @brief Graphic MMU LUT entry 316 low
    \ Address offset: 0x19E0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT316H_DEF
    \
    \ @brief Graphic MMU LUT entry 316 high
    \ Address offset: 0x19E4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT317L_DEF
    \
    \ @brief Graphic MMU LUT entry 317 low
    \ Address offset: 0x19E8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT317H_DEF
    \
    \ @brief Graphic MMU LUT entry 317 high
    \ Address offset: 0x19EC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT318L_DEF
    \
    \ @brief Graphic MMU LUT entry 318 low
    \ Address offset: 0x19F0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT318H_DEF
    \
    \ @brief Graphic MMU LUT entry 318 high
    \ Address offset: 0x19F4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT319L_DEF
    \
    \ @brief Graphic MMU LUT entry 319 low
    \ Address offset: 0x19F8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT319H_DEF
    \
    \ @brief Graphic MMU LUT entry 319 high
    \ Address offset: 0x19FC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT320L_DEF
    \
    \ @brief Graphic MMU LUT entry 320 low
    \ Address offset: 0x1A00
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT320H_DEF
    \
    \ @brief Graphic MMU LUT entry 320 high
    \ Address offset: 0x1A04
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT321L_DEF
    \
    \ @brief Graphic MMU LUT entry 321 low
    \ Address offset: 0x1A08
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT321H_DEF
    \
    \ @brief Graphic MMU LUT entry 321 high
    \ Address offset: 0x1A0C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT322L_DEF
    \
    \ @brief Graphic MMU LUT entry 322 low
    \ Address offset: 0x1A10
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT322H_DEF
    \
    \ @brief Graphic MMU LUT entry 322 high
    \ Address offset: 0x1A14
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT323L_DEF
    \
    \ @brief Graphic MMU LUT entry 323 low
    \ Address offset: 0x1A18
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT323H_DEF
    \
    \ @brief Graphic MMU LUT entry 323 high
    \ Address offset: 0x1A1C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT324L_DEF
    \
    \ @brief Graphic MMU LUT entry 324 low
    \ Address offset: 0x1A20
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT324H_DEF
    \
    \ @brief Graphic MMU LUT entry 324 high
    \ Address offset: 0x1A24
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT325L_DEF
    \
    \ @brief Graphic MMU LUT entry 325 low
    \ Address offset: 0x1A28
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT325H_DEF
    \
    \ @brief Graphic MMU LUT entry 325 high
    \ Address offset: 0x1A2C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT326L_DEF
    \
    \ @brief Graphic MMU LUT entry 326 low
    \ Address offset: 0x1A30
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT326H_DEF
    \
    \ @brief Graphic MMU LUT entry 326 high
    \ Address offset: 0x1A34
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT327L_DEF
    \
    \ @brief Graphic MMU LUT entry 327 low
    \ Address offset: 0x1A38
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT327H_DEF
    \
    \ @brief Graphic MMU LUT entry 327 high
    \ Address offset: 0x1A3C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT328L_DEF
    \
    \ @brief Graphic MMU LUT entry 328 low
    \ Address offset: 0x1A40
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT328H_DEF
    \
    \ @brief Graphic MMU LUT entry 328 high
    \ Address offset: 0x1A44
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT329L_DEF
    \
    \ @brief Graphic MMU LUT entry 329 low
    \ Address offset: 0x1A48
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT329H_DEF
    \
    \ @brief Graphic MMU LUT entry 329 high
    \ Address offset: 0x1A4C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT330L_DEF
    \
    \ @brief Graphic MMU LUT entry 330 low
    \ Address offset: 0x1A50
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT330H_DEF
    \
    \ @brief Graphic MMU LUT entry 330 high
    \ Address offset: 0x1A54
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT331L_DEF
    \
    \ @brief Graphic MMU LUT entry 331 low
    \ Address offset: 0x1A58
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT331H_DEF
    \
    \ @brief Graphic MMU LUT entry 331 high
    \ Address offset: 0x1A5C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT332L_DEF
    \
    \ @brief Graphic MMU LUT entry 332 low
    \ Address offset: 0x1A60
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT332H_DEF
    \
    \ @brief Graphic MMU LUT entry 332 high
    \ Address offset: 0x1A64
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT333L_DEF
    \
    \ @brief Graphic MMU LUT entry 333 low
    \ Address offset: 0x1A68
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT333H_DEF
    \
    \ @brief Graphic MMU LUT entry 333 high
    \ Address offset: 0x1A6C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT334L_DEF
    \
    \ @brief Graphic MMU LUT entry 334 low
    \ Address offset: 0x1A70
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT334H_DEF
    \
    \ @brief Graphic MMU LUT entry 334 high
    \ Address offset: 0x1A74
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT335L_DEF
    \
    \ @brief Graphic MMU LUT entry 335 low
    \ Address offset: 0x1A78
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT335H_DEF
    \
    \ @brief Graphic MMU LUT entry 335 high
    \ Address offset: 0x1A7C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT336L_DEF
    \
    \ @brief Graphic MMU LUT entry 336 low
    \ Address offset: 0x1A80
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT336H_DEF
    \
    \ @brief Graphic MMU LUT entry 336 high
    \ Address offset: 0x1A84
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT337L_DEF
    \
    \ @brief Graphic MMU LUT entry 337 low
    \ Address offset: 0x1A88
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT337H_DEF
    \
    \ @brief Graphic MMU LUT entry 337 high
    \ Address offset: 0x1A8C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT338L_DEF
    \
    \ @brief Graphic MMU LUT entry 338 low
    \ Address offset: 0x1A90
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT338H_DEF
    \
    \ @brief Graphic MMU LUT entry 338 high
    \ Address offset: 0x1A94
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT339L_DEF
    \
    \ @brief Graphic MMU LUT entry 339 low
    \ Address offset: 0x1A98
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT339H_DEF
    \
    \ @brief Graphic MMU LUT entry 339 high
    \ Address offset: 0x1A9C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT340L_DEF
    \
    \ @brief Graphic MMU LUT entry 340 low
    \ Address offset: 0x1AA0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT340H_DEF
    \
    \ @brief Graphic MMU LUT entry 340 high
    \ Address offset: 0x1AA4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT341L_DEF
    \
    \ @brief Graphic MMU LUT entry 341 low
    \ Address offset: 0x1AA8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT341H_DEF
    \
    \ @brief Graphic MMU LUT entry 341 high
    \ Address offset: 0x1AAC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT342L_DEF
    \
    \ @brief Graphic MMU LUT entry 342 low
    \ Address offset: 0x1AB0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT342H_DEF
    \
    \ @brief Graphic MMU LUT entry 342 high
    \ Address offset: 0x1AB4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT343L_DEF
    \
    \ @brief Graphic MMU LUT entry 343 low
    \ Address offset: 0x1AB8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT343H_DEF
    \
    \ @brief Graphic MMU LUT entry 343 high
    \ Address offset: 0x1ABC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT344L_DEF
    \
    \ @brief Graphic MMU LUT entry 344 low
    \ Address offset: 0x1AC0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT344H_DEF
    \
    \ @brief Graphic MMU LUT entry 344 high
    \ Address offset: 0x1AC4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT345L_DEF
    \
    \ @brief Graphic MMU LUT entry 345 low
    \ Address offset: 0x1AC8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT345H_DEF
    \
    \ @brief Graphic MMU LUT entry 345 high
    \ Address offset: 0x1ACC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT346L_DEF
    \
    \ @brief Graphic MMU LUT entry 346 low
    \ Address offset: 0x1AD0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT346H_DEF
    \
    \ @brief Graphic MMU LUT entry 346 high
    \ Address offset: 0x1AD4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT347L_DEF
    \
    \ @brief Graphic MMU LUT entry 347 low
    \ Address offset: 0x1AD8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT347H_DEF
    \
    \ @brief Graphic MMU LUT entry 347 high
    \ Address offset: 0x1ADC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT348L_DEF
    \
    \ @brief Graphic MMU LUT entry 348 low
    \ Address offset: 0x1AE0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT348H_DEF
    \
    \ @brief Graphic MMU LUT entry 348 high
    \ Address offset: 0x1AE4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT349L_DEF
    \
    \ @brief Graphic MMU LUT entry 349 low
    \ Address offset: 0x1AE8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT349H_DEF
    \
    \ @brief Graphic MMU LUT entry 349 high
    \ Address offset: 0x1AEC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT350L_DEF
    \
    \ @brief Graphic MMU LUT entry 350 low
    \ Address offset: 0x1AF0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT350H_DEF
    \
    \ @brief Graphic MMU LUT entry 350 high
    \ Address offset: 0x1AF4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT351L_DEF
    \
    \ @brief Graphic MMU LUT entry 351 low
    \ Address offset: 0x1AF8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT351H_DEF
    \
    \ @brief Graphic MMU LUT entry 351 high
    \ Address offset: 0x1AFC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT352L_DEF
    \
    \ @brief Graphic MMU LUT entry 352 low
    \ Address offset: 0x1B00
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT352H_DEF
    \
    \ @brief Graphic MMU LUT entry 352 high
    \ Address offset: 0x1B04
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT353L_DEF
    \
    \ @brief Graphic MMU LUT entry 353 low
    \ Address offset: 0x1B08
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT353H_DEF
    \
    \ @brief Graphic MMU LUT entry 353 high
    \ Address offset: 0x1B0C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT354L_DEF
    \
    \ @brief Graphic MMU LUT entry 354 low
    \ Address offset: 0x1B10
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT354H_DEF
    \
    \ @brief Graphic MMU LUT entry 354 high
    \ Address offset: 0x1B14
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT355L_DEF
    \
    \ @brief Graphic MMU LUT entry 355 low
    \ Address offset: 0x1B18
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT355H_DEF
    \
    \ @brief Graphic MMU LUT entry 355 high
    \ Address offset: 0x1B1C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT356L_DEF
    \
    \ @brief Graphic MMU LUT entry 356 low
    \ Address offset: 0x1B20
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT356H_DEF
    \
    \ @brief Graphic MMU LUT entry 356 high
    \ Address offset: 0x1B24
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT357L_DEF
    \
    \ @brief Graphic MMU LUT entry 357 low
    \ Address offset: 0x1B28
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT357H_DEF
    \
    \ @brief Graphic MMU LUT entry 357 high
    \ Address offset: 0x1B2C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT358L_DEF
    \
    \ @brief Graphic MMU LUT entry 358 low
    \ Address offset: 0x1B30
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT358H_DEF
    \
    \ @brief Graphic MMU LUT entry 358 high
    \ Address offset: 0x1B34
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT359L_DEF
    \
    \ @brief Graphic MMU LUT entry 359 low
    \ Address offset: 0x1B38
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT359H_DEF
    \
    \ @brief Graphic MMU LUT entry 359 high
    \ Address offset: 0x1B3C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT360L_DEF
    \
    \ @brief Graphic MMU LUT entry 360 low
    \ Address offset: 0x1B40
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT360H_DEF
    \
    \ @brief Graphic MMU LUT entry 360 high
    \ Address offset: 0x1B44
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT361L_DEF
    \
    \ @brief Graphic MMU LUT entry 361 low
    \ Address offset: 0x1B48
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT361H_DEF
    \
    \ @brief Graphic MMU LUT entry 361 high
    \ Address offset: 0x1B4C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT362L_DEF
    \
    \ @brief Graphic MMU LUT entry 362 low
    \ Address offset: 0x1B50
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT362H_DEF
    \
    \ @brief Graphic MMU LUT entry 362 high
    \ Address offset: 0x1B54
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT363L_DEF
    \
    \ @brief Graphic MMU LUT entry 363 low
    \ Address offset: 0x1B58
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT363H_DEF
    \
    \ @brief Graphic MMU LUT entry 363 high
    \ Address offset: 0x1B5C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT364L_DEF
    \
    \ @brief Graphic MMU LUT entry 364 low
    \ Address offset: 0x1B60
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT364H_DEF
    \
    \ @brief Graphic MMU LUT entry 364 high
    \ Address offset: 0x1B64
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT365L_DEF
    \
    \ @brief Graphic MMU LUT entry 365 low
    \ Address offset: 0x1B68
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT365H_DEF
    \
    \ @brief Graphic MMU LUT entry 365 high
    \ Address offset: 0x1B6C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT366L_DEF
    \
    \ @brief Graphic MMU LUT entry 366 low
    \ Address offset: 0x1B70
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT366H_DEF
    \
    \ @brief Graphic MMU LUT entry 366 high
    \ Address offset: 0x1B74
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT367L_DEF
    \
    \ @brief Graphic MMU LUT entry 367 low
    \ Address offset: 0x1B78
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT367H_DEF
    \
    \ @brief Graphic MMU LUT entry 367 high
    \ Address offset: 0x1B7C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT368L_DEF
    \
    \ @brief Graphic MMU LUT entry 368 low
    \ Address offset: 0x1B80
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT368H_DEF
    \
    \ @brief Graphic MMU LUT entry 368 high
    \ Address offset: 0x1B84
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT369L_DEF
    \
    \ @brief Graphic MMU LUT entry 369 low
    \ Address offset: 0x1B88
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT369H_DEF
    \
    \ @brief Graphic MMU LUT entry 369 high
    \ Address offset: 0x1B8C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT370L_DEF
    \
    \ @brief Graphic MMU LUT entry 370 low
    \ Address offset: 0x1B90
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT370H_DEF
    \
    \ @brief Graphic MMU LUT entry 370 high
    \ Address offset: 0x1B94
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT371L_DEF
    \
    \ @brief Graphic MMU LUT entry 371 low
    \ Address offset: 0x1B98
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT371H_DEF
    \
    \ @brief Graphic MMU LUT entry 371 high
    \ Address offset: 0x1B9C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT372L_DEF
    \
    \ @brief Graphic MMU LUT entry 372 low
    \ Address offset: 0x1BA0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT372H_DEF
    \
    \ @brief Graphic MMU LUT entry 372 high
    \ Address offset: 0x1BA4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT373L_DEF
    \
    \ @brief Graphic MMU LUT entry 373 low
    \ Address offset: 0x1BA8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT373H_DEF
    \
    \ @brief Graphic MMU LUT entry 373 high
    \ Address offset: 0x1BAC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT374L_DEF
    \
    \ @brief Graphic MMU LUT entry 374 low
    \ Address offset: 0x1BB0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT374H_DEF
    \
    \ @brief Graphic MMU LUT entry 374 high
    \ Address offset: 0x1BB4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT375L_DEF
    \
    \ @brief Graphic MMU LUT entry 375 low
    \ Address offset: 0x1BB8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT375H_DEF
    \
    \ @brief Graphic MMU LUT entry 375 high
    \ Address offset: 0x1BBC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT376L_DEF
    \
    \ @brief Graphic MMU LUT entry 376 low
    \ Address offset: 0x1BC0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT376H_DEF
    \
    \ @brief Graphic MMU LUT entry 376 high
    \ Address offset: 0x1BC4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT377L_DEF
    \
    \ @brief Graphic MMU LUT entry 377 low
    \ Address offset: 0x1BC8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT377H_DEF
    \
    \ @brief Graphic MMU LUT entry 377 high
    \ Address offset: 0x1BCC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT378L_DEF
    \
    \ @brief Graphic MMU LUT entry 378 low
    \ Address offset: 0x1BD0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT378H_DEF
    \
    \ @brief Graphic MMU LUT entry 378 high
    \ Address offset: 0x1BD4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT379L_DEF
    \
    \ @brief Graphic MMU LUT entry 379 low
    \ Address offset: 0x1BD8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT379H_DEF
    \
    \ @brief Graphic MMU LUT entry 379 high
    \ Address offset: 0x1BDC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT380L_DEF
    \
    \ @brief Graphic MMU LUT entry 380 low
    \ Address offset: 0x1BE0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT380H_DEF
    \
    \ @brief Graphic MMU LUT entry 380 high
    \ Address offset: 0x1BE4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT381L_DEF
    \
    \ @brief Graphic MMU LUT entry 381 low
    \ Address offset: 0x1BE8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT381H_DEF
    \
    \ @brief Graphic MMU LUT entry 381 high
    \ Address offset: 0x1BEC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT382L_DEF
    \
    \ @brief Graphic MMU LUT entry 382 low
    \ Address offset: 0x1BF0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT382H_DEF
    \
    \ @brief Graphic MMU LUT entry 382 high
    \ Address offset: 0x1BF4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT383L_DEF
    \
    \ @brief Graphic MMU LUT entry 383 low
    \ Address offset: 0x1BF8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT383H_DEF
    \
    \ @brief Graphic MMU LUT entry 383 high
    \ Address offset: 0x1BFC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT384L_DEF
    \
    \ @brief Graphic MMU LUT entry 384 low
    \ Address offset: 0x1C00
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT384H_DEF
    \
    \ @brief Graphic MMU LUT entry 384 high
    \ Address offset: 0x1C04
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT385L_DEF
    \
    \ @brief Graphic MMU LUT entry 385 low
    \ Address offset: 0x1C08
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT385H_DEF
    \
    \ @brief Graphic MMU LUT entry 385 high
    \ Address offset: 0x1C0C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT386L_DEF
    \
    \ @brief Graphic MMU LUT entry 386 low
    \ Address offset: 0x1C10
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT386H_DEF
    \
    \ @brief Graphic MMU LUT entry 386 high
    \ Address offset: 0x1C14
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT387L_DEF
    \
    \ @brief Graphic MMU LUT entry 387 low
    \ Address offset: 0x1C18
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT387H_DEF
    \
    \ @brief Graphic MMU LUT entry 387 high
    \ Address offset: 0x1C1C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT388L_DEF
    \
    \ @brief Graphic MMU LUT entry 388 low
    \ Address offset: 0x1C20
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT388H_DEF
    \
    \ @brief Graphic MMU LUT entry 388 high
    \ Address offset: 0x1C24
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT389L_DEF
    \
    \ @brief Graphic MMU LUT entry 389 low
    \ Address offset: 0x1C28
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT389H_DEF
    \
    \ @brief Graphic MMU LUT entry 389 high
    \ Address offset: 0x1C2C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT390L_DEF
    \
    \ @brief Graphic MMU LUT entry 390 low
    \ Address offset: 0x1C30
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT390H_DEF
    \
    \ @brief Graphic MMU LUT entry 390 high
    \ Address offset: 0x1C34
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT391L_DEF
    \
    \ @brief Graphic MMU LUT entry 391 low
    \ Address offset: 0x1C38
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT391H_DEF
    \
    \ @brief Graphic MMU LUT entry 391 high
    \ Address offset: 0x1C3C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT392L_DEF
    \
    \ @brief Graphic MMU LUT entry 392 low
    \ Address offset: 0x1C40
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT392H_DEF
    \
    \ @brief Graphic MMU LUT entry 392 high
    \ Address offset: 0x1C44
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT393L_DEF
    \
    \ @brief Graphic MMU LUT entry 393 low
    \ Address offset: 0x1C48
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT393H_DEF
    \
    \ @brief Graphic MMU LUT entry 393 high
    \ Address offset: 0x1C4C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT394L_DEF
    \
    \ @brief Graphic MMU LUT entry 394 low
    \ Address offset: 0x1C50
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT394H_DEF
    \
    \ @brief Graphic MMU LUT entry 394 high
    \ Address offset: 0x1C54
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT395L_DEF
    \
    \ @brief Graphic MMU LUT entry 395 low
    \ Address offset: 0x1C58
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT395H_DEF
    \
    \ @brief Graphic MMU LUT entry 395 high
    \ Address offset: 0x1C5C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT396L_DEF
    \
    \ @brief Graphic MMU LUT entry 396 low
    \ Address offset: 0x1C60
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT396H_DEF
    \
    \ @brief Graphic MMU LUT entry 396 high
    \ Address offset: 0x1C64
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT397L_DEF
    \
    \ @brief Graphic MMU LUT entry 397 low
    \ Address offset: 0x1C68
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT397H_DEF
    \
    \ @brief Graphic MMU LUT entry 397 high
    \ Address offset: 0x1C6C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT398L_DEF
    \
    \ @brief Graphic MMU LUT entry 398 low
    \ Address offset: 0x1C70
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT398H_DEF
    \
    \ @brief Graphic MMU LUT entry 398 high
    \ Address offset: 0x1C74
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT399L_DEF
    \
    \ @brief Graphic MMU LUT entry 399 low
    \ Address offset: 0x1C78
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT399H_DEF
    \
    \ @brief Graphic MMU LUT entry 399 high
    \ Address offset: 0x1C7C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT400L_DEF
    \
    \ @brief Graphic MMU LUT entry 400 low
    \ Address offset: 0x1C80
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT400H_DEF
    \
    \ @brief Graphic MMU LUT entry 400 high
    \ Address offset: 0x1C84
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT401L_DEF
    \
    \ @brief Graphic MMU LUT entry 401 low
    \ Address offset: 0x1C88
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT401H_DEF
    \
    \ @brief Graphic MMU LUT entry 401 high
    \ Address offset: 0x1C8C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT402L_DEF
    \
    \ @brief Graphic MMU LUT entry 402 low
    \ Address offset: 0x1C90
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT402H_DEF
    \
    \ @brief Graphic MMU LUT entry 402 high
    \ Address offset: 0x1C94
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT403L_DEF
    \
    \ @brief Graphic MMU LUT entry 403 low
    \ Address offset: 0x1C98
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT403H_DEF
    \
    \ @brief Graphic MMU LUT entry 403 high
    \ Address offset: 0x1C9C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT404L_DEF
    \
    \ @brief Graphic MMU LUT entry 404 low
    \ Address offset: 0x1CA0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT404H_DEF
    \
    \ @brief Graphic MMU LUT entry 404 high
    \ Address offset: 0x1CA4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT405L_DEF
    \
    \ @brief Graphic MMU LUT entry 405 low
    \ Address offset: 0x1CA8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT405H_DEF
    \
    \ @brief Graphic MMU LUT entry 405 high
    \ Address offset: 0x1CAC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT406L_DEF
    \
    \ @brief Graphic MMU LUT entry 406 low
    \ Address offset: 0x1CB0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT406H_DEF
    \
    \ @brief Graphic MMU LUT entry 406 high
    \ Address offset: 0x1CB4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT407L_DEF
    \
    \ @brief Graphic MMU LUT entry 407 low
    \ Address offset: 0x1CB8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT407H_DEF
    \
    \ @brief Graphic MMU LUT entry 407 high
    \ Address offset: 0x1CBC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT408L_DEF
    \
    \ @brief Graphic MMU LUT entry 408 low
    \ Address offset: 0x1CC0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT408H_DEF
    \
    \ @brief Graphic MMU LUT entry 408 high
    \ Address offset: 0x1CC4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT409L_DEF
    \
    \ @brief Graphic MMU LUT entry 409 low
    \ Address offset: 0x1CC8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT409H_DEF
    \
    \ @brief Graphic MMU LUT entry 409 high
    \ Address offset: 0x1CCC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT410L_DEF
    \
    \ @brief Graphic MMU LUT entry 410 low
    \ Address offset: 0x1CD0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT410H_DEF
    \
    \ @brief Graphic MMU LUT entry 410 high
    \ Address offset: 0x1CD4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT411L_DEF
    \
    \ @brief Graphic MMU LUT entry 411 low
    \ Address offset: 0x1CD8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT411H_DEF
    \
    \ @brief Graphic MMU LUT entry 411 high
    \ Address offset: 0x1CDC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT412L_DEF
    \
    \ @brief Graphic MMU LUT entry 412 low
    \ Address offset: 0x1CE0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT412H_DEF
    \
    \ @brief Graphic MMU LUT entry 412 high
    \ Address offset: 0x1CE4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT413L_DEF
    \
    \ @brief Graphic MMU LUT entry 413 low
    \ Address offset: 0x1CE8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT413H_DEF
    \
    \ @brief Graphic MMU LUT entry 413 high
    \ Address offset: 0x1CEC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT414L_DEF
    \
    \ @brief Graphic MMU LUT entry 414 low
    \ Address offset: 0x1CF0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT414H_DEF
    \
    \ @brief Graphic MMU LUT entry 414 high
    \ Address offset: 0x1CF4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT415L_DEF
    \
    \ @brief Graphic MMU LUT entry 415 low
    \ Address offset: 0x1CF8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT415H_DEF
    \
    \ @brief Graphic MMU LUT entry 415 high
    \ Address offset: 0x1CFC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT416L_DEF
    \
    \ @brief Graphic MMU LUT entry 416 low
    \ Address offset: 0x1D00
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT416H_DEF
    \
    \ @brief Graphic MMU LUT entry 416 high
    \ Address offset: 0x1D04
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT417L_DEF
    \
    \ @brief Graphic MMU LUT entry 417 low
    \ Address offset: 0x1D08
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT417H_DEF
    \
    \ @brief Graphic MMU LUT entry 417 high
    \ Address offset: 0x1D0C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT418L_DEF
    \
    \ @brief Graphic MMU LUT entry 418 low
    \ Address offset: 0x1D10
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT418H_DEF
    \
    \ @brief Graphic MMU LUT entry 418 high
    \ Address offset: 0x1D14
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT419L_DEF
    \
    \ @brief Graphic MMU LUT entry 419 low
    \ Address offset: 0x1D18
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT419H_DEF
    \
    \ @brief Graphic MMU LUT entry 419 high
    \ Address offset: 0x1D1C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT420L_DEF
    \
    \ @brief Graphic MMU LUT entry 420 low
    \ Address offset: 0x1D20
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT420H_DEF
    \
    \ @brief Graphic MMU LUT entry 420 high
    \ Address offset: 0x1D24
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT421L_DEF
    \
    \ @brief Graphic MMU LUT entry 421 low
    \ Address offset: 0x1D28
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT421H_DEF
    \
    \ @brief Graphic MMU LUT entry 421 high
    \ Address offset: 0x1D2C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT422L_DEF
    \
    \ @brief Graphic MMU LUT entry 422 low
    \ Address offset: 0x1D30
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT422H_DEF
    \
    \ @brief Graphic MMU LUT entry 422 high
    \ Address offset: 0x1D34
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT423L_DEF
    \
    \ @brief Graphic MMU LUT entry 423 low
    \ Address offset: 0x1D38
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT423H_DEF
    \
    \ @brief Graphic MMU LUT entry 423 high
    \ Address offset: 0x1D3C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT424L_DEF
    \
    \ @brief Graphic MMU LUT entry 424 low
    \ Address offset: 0x1D40
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT424H_DEF
    \
    \ @brief Graphic MMU LUT entry 424 high
    \ Address offset: 0x1D44
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT425L_DEF
    \
    \ @brief Graphic MMU LUT entry 425 low
    \ Address offset: 0x1D48
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT425H_DEF
    \
    \ @brief Graphic MMU LUT entry 425 high
    \ Address offset: 0x1D4C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT426L_DEF
    \
    \ @brief Graphic MMU LUT entry 426 low
    \ Address offset: 0x1D50
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT426H_DEF
    \
    \ @brief Graphic MMU LUT entry 426 high
    \ Address offset: 0x1D54
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT427L_DEF
    \
    \ @brief Graphic MMU LUT entry 427 low
    \ Address offset: 0x1D58
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT427H_DEF
    \
    \ @brief Graphic MMU LUT entry 427 high
    \ Address offset: 0x1D5C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT428L_DEF
    \
    \ @brief Graphic MMU LUT entry 428 low
    \ Address offset: 0x1D60
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT428H_DEF
    \
    \ @brief Graphic MMU LUT entry 428 high
    \ Address offset: 0x1D64
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT429L_DEF
    \
    \ @brief Graphic MMU LUT entry 429 low
    \ Address offset: 0x1D68
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT429H_DEF
    \
    \ @brief Graphic MMU LUT entry 429 high
    \ Address offset: 0x1D6C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT430L_DEF
    \
    \ @brief Graphic MMU LUT entry 430 low
    \ Address offset: 0x1D70
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT430H_DEF
    \
    \ @brief Graphic MMU LUT entry 430 high
    \ Address offset: 0x1D74
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT431L_DEF
    \
    \ @brief Graphic MMU LUT entry 431 low
    \ Address offset: 0x1D78
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT431H_DEF
    \
    \ @brief Graphic MMU LUT entry 431 high
    \ Address offset: 0x1D7C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT432L_DEF
    \
    \ @brief Graphic MMU LUT entry 432 low
    \ Address offset: 0x1D80
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT432H_DEF
    \
    \ @brief Graphic MMU LUT entry 432 high
    \ Address offset: 0x1D84
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT433L_DEF
    \
    \ @brief Graphic MMU LUT entry 433 low
    \ Address offset: 0x1D88
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT433H_DEF
    \
    \ @brief Graphic MMU LUT entry 433 high
    \ Address offset: 0x1D8C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT434L_DEF
    \
    \ @brief Graphic MMU LUT entry 434 low
    \ Address offset: 0x1D90
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT434H_DEF
    \
    \ @brief Graphic MMU LUT entry 434 high
    \ Address offset: 0x1D94
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT435L_DEF
    \
    \ @brief Graphic MMU LUT entry 435 low
    \ Address offset: 0x1D98
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT435H_DEF
    \
    \ @brief Graphic MMU LUT entry 435 high
    \ Address offset: 0x1D9C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT436L_DEF
    \
    \ @brief Graphic MMU LUT entry 436 low
    \ Address offset: 0x1DA0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT436H_DEF
    \
    \ @brief Graphic MMU LUT entry 436 high
    \ Address offset: 0x1DA4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT437L_DEF
    \
    \ @brief Graphic MMU LUT entry 437 low
    \ Address offset: 0x1DA8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT437H_DEF
    \
    \ @brief Graphic MMU LUT entry 437 high
    \ Address offset: 0x1DAC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT438L_DEF
    \
    \ @brief Graphic MMU LUT entry 438 low
    \ Address offset: 0x1DB0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT438H_DEF
    \
    \ @brief Graphic MMU LUT entry 438 high
    \ Address offset: 0x1DB4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT439L_DEF
    \
    \ @brief Graphic MMU LUT entry 439 low
    \ Address offset: 0x1DB8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT439H_DEF
    \
    \ @brief Graphic MMU LUT entry 439 high
    \ Address offset: 0x1DBC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT440L_DEF
    \
    \ @brief Graphic MMU LUT entry 440 low
    \ Address offset: 0x1DC0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT440H_DEF
    \
    \ @brief Graphic MMU LUT entry 440 high
    \ Address offset: 0x1DC4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT441L_DEF
    \
    \ @brief Graphic MMU LUT entry 441 low
    \ Address offset: 0x1DC8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT441H_DEF
    \
    \ @brief Graphic MMU LUT entry 441 high
    \ Address offset: 0x1DCC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT442L_DEF
    \
    \ @brief Graphic MMU LUT entry 442 low
    \ Address offset: 0x1DD0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT442H_DEF
    \
    \ @brief Graphic MMU LUT entry 442 high
    \ Address offset: 0x1DD4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT443L_DEF
    \
    \ @brief Graphic MMU LUT entry 443 low
    \ Address offset: 0x1DD8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT443H_DEF
    \
    \ @brief Graphic MMU LUT entry 443 high
    \ Address offset: 0x1DDC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT444L_DEF
    \
    \ @brief Graphic MMU LUT entry 444 low
    \ Address offset: 0x1DE0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT444H_DEF
    \
    \ @brief Graphic MMU LUT entry 444 high
    \ Address offset: 0x1DE4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT445L_DEF
    \
    \ @brief Graphic MMU LUT entry 445 low
    \ Address offset: 0x1DE8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT445H_DEF
    \
    \ @brief Graphic MMU LUT entry 445 high
    \ Address offset: 0x1DEC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT446L_DEF
    \
    \ @brief Graphic MMU LUT entry 446 low
    \ Address offset: 0x1DF0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT446H_DEF
    \
    \ @brief Graphic MMU LUT entry 446 high
    \ Address offset: 0x1DF4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT447L_DEF
    \
    \ @brief Graphic MMU LUT entry 447 low
    \ Address offset: 0x1DF8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT447H_DEF
    \
    \ @brief Graphic MMU LUT entry 447 high
    \ Address offset: 0x1DFC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT448L_DEF
    \
    \ @brief Graphic MMU LUT entry 448 low
    \ Address offset: 0x1E00
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT448H_DEF
    \
    \ @brief Graphic MMU LUT entry 448 high
    \ Address offset: 0x1E04
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT449L_DEF
    \
    \ @brief Graphic MMU LUT entry 449 low
    \ Address offset: 0x1E08
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT449H_DEF
    \
    \ @brief Graphic MMU LUT entry 449 high
    \ Address offset: 0x1E0C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT450L_DEF
    \
    \ @brief Graphic MMU LUT entry 450 low
    \ Address offset: 0x1E10
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT450H_DEF
    \
    \ @brief Graphic MMU LUT entry 450 high
    \ Address offset: 0x1E14
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT451L_DEF
    \
    \ @brief Graphic MMU LUT entry 451 low
    \ Address offset: 0x1E18
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT451H_DEF
    \
    \ @brief Graphic MMU LUT entry 451 high
    \ Address offset: 0x1E1C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT452L_DEF
    \
    \ @brief Graphic MMU LUT entry 452 low
    \ Address offset: 0x1E20
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT452H_DEF
    \
    \ @brief Graphic MMU LUT entry 452 high
    \ Address offset: 0x1E24
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT453L_DEF
    \
    \ @brief Graphic MMU LUT entry 453 low
    \ Address offset: 0x1E28
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT453H_DEF
    \
    \ @brief Graphic MMU LUT entry 453 high
    \ Address offset: 0x1E2C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT454L_DEF
    \
    \ @brief Graphic MMU LUT entry 454 low
    \ Address offset: 0x1E30
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT454H_DEF
    \
    \ @brief Graphic MMU LUT entry 454 high
    \ Address offset: 0x1E34
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT455L_DEF
    \
    \ @brief Graphic MMU LUT entry 455 low
    \ Address offset: 0x1E38
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT455H_DEF
    \
    \ @brief Graphic MMU LUT entry 455 high
    \ Address offset: 0x1E3C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT456L_DEF
    \
    \ @brief Graphic MMU LUT entry 456 low
    \ Address offset: 0x1E40
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT456H_DEF
    \
    \ @brief Graphic MMU LUT entry 456 high
    \ Address offset: 0x1E44
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT457L_DEF
    \
    \ @brief Graphic MMU LUT entry 457 low
    \ Address offset: 0x1E48
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT457H_DEF
    \
    \ @brief Graphic MMU LUT entry 457 high
    \ Address offset: 0x1E4C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT458L_DEF
    \
    \ @brief Graphic MMU LUT entry 458 low
    \ Address offset: 0x1E50
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT458H_DEF
    \
    \ @brief Graphic MMU LUT entry 458 high
    \ Address offset: 0x1E54
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT459L_DEF
    \
    \ @brief Graphic MMU LUT entry 459 low
    \ Address offset: 0x1E58
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT459H_DEF
    \
    \ @brief Graphic MMU LUT entry 459 high
    \ Address offset: 0x1E5C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT460L_DEF
    \
    \ @brief Graphic MMU LUT entry 460 low
    \ Address offset: 0x1E60
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT460H_DEF
    \
    \ @brief Graphic MMU LUT entry 460 high
    \ Address offset: 0x1E64
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT461L_DEF
    \
    \ @brief Graphic MMU LUT entry 461 low
    \ Address offset: 0x1E68
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT461H_DEF
    \
    \ @brief Graphic MMU LUT entry 461 high
    \ Address offset: 0x1E6C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT462L_DEF
    \
    \ @brief Graphic MMU LUT entry 462 low
    \ Address offset: 0x1E70
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT462H_DEF
    \
    \ @brief Graphic MMU LUT entry 462 high
    \ Address offset: 0x1E74
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT463L_DEF
    \
    \ @brief Graphic MMU LUT entry 463 low
    \ Address offset: 0x1E78
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT463H_DEF
    \
    \ @brief Graphic MMU LUT entry 463 high
    \ Address offset: 0x1E7C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT464L_DEF
    \
    \ @brief Graphic MMU LUT entry 464 low
    \ Address offset: 0x1E80
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT464H_DEF
    \
    \ @brief Graphic MMU LUT entry 464 high
    \ Address offset: 0x1E84
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT465L_DEF
    \
    \ @brief Graphic MMU LUT entry 465 low
    \ Address offset: 0x1E88
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT465H_DEF
    \
    \ @brief Graphic MMU LUT entry 465 high
    \ Address offset: 0x1E8C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT466L_DEF
    \
    \ @brief Graphic MMU LUT entry 466 low
    \ Address offset: 0x1E90
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT466H_DEF
    \
    \ @brief Graphic MMU LUT entry 466 high
    \ Address offset: 0x1E94
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT467L_DEF
    \
    \ @brief Graphic MMU LUT entry 467 low
    \ Address offset: 0x1E98
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT467H_DEF
    \
    \ @brief Graphic MMU LUT entry 467 high
    \ Address offset: 0x1E9C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT468L_DEF
    \
    \ @brief Graphic MMU LUT entry 468 low
    \ Address offset: 0x1EA0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT468H_DEF
    \
    \ @brief Graphic MMU LUT entry 468 high
    \ Address offset: 0x1EA4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT469L_DEF
    \
    \ @brief Graphic MMU LUT entry 469 low
    \ Address offset: 0x1EA8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT469H_DEF
    \
    \ @brief Graphic MMU LUT entry 469 high
    \ Address offset: 0x1EAC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT470L_DEF
    \
    \ @brief Graphic MMU LUT entry 470 low
    \ Address offset: 0x1EB0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT470H_DEF
    \
    \ @brief Graphic MMU LUT entry 470 high
    \ Address offset: 0x1EB4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT471L_DEF
    \
    \ @brief Graphic MMU LUT entry 471 low
    \ Address offset: 0x1EB8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT471H_DEF
    \
    \ @brief Graphic MMU LUT entry 471 high
    \ Address offset: 0x1EBC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT472L_DEF
    \
    \ @brief Graphic MMU LUT entry 472 low
    \ Address offset: 0x1EC0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT472H_DEF
    \
    \ @brief Graphic MMU LUT entry 472 high
    \ Address offset: 0x1EC4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT473L_DEF
    \
    \ @brief Graphic MMU LUT entry 473 low
    \ Address offset: 0x1EC8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT473H_DEF
    \
    \ @brief Graphic MMU LUT entry 473 high
    \ Address offset: 0x1ECC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT474L_DEF
    \
    \ @brief Graphic MMU LUT entry 474 low
    \ Address offset: 0x1ED0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT474H_DEF
    \
    \ @brief Graphic MMU LUT entry 474 high
    \ Address offset: 0x1ED4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT475L_DEF
    \
    \ @brief Graphic MMU LUT entry 475 low
    \ Address offset: 0x1ED8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT475H_DEF
    \
    \ @brief Graphic MMU LUT entry 475 high
    \ Address offset: 0x1EDC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT476L_DEF
    \
    \ @brief Graphic MMU LUT entry 476 low
    \ Address offset: 0x1EE0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT476H_DEF
    \
    \ @brief Graphic MMU LUT entry 476 high
    \ Address offset: 0x1EE4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT477L_DEF
    \
    \ @brief Graphic MMU LUT entry 477 low
    \ Address offset: 0x1EE8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT477H_DEF
    \
    \ @brief Graphic MMU LUT entry 477 high
    \ Address offset: 0x1EEC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT478L_DEF
    \
    \ @brief Graphic MMU LUT entry 478 low
    \ Address offset: 0x1EF0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT478H_DEF
    \
    \ @brief Graphic MMU LUT entry 478 high
    \ Address offset: 0x1EF4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT479L_DEF
    \
    \ @brief Graphic MMU LUT entry 479 low
    \ Address offset: 0x1EF8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT479H_DEF
    \
    \ @brief Graphic MMU LUT entry 479 high
    \ Address offset: 0x1EFC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT480L_DEF
    \
    \ @brief Graphic MMU LUT entry 480 low
    \ Address offset: 0x1F00
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT480H_DEF
    \
    \ @brief Graphic MMU LUT entry 480 high
    \ Address offset: 0x1F04
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT481L_DEF
    \
    \ @brief Graphic MMU LUT entry 481 low
    \ Address offset: 0x1F08
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT481H_DEF
    \
    \ @brief Graphic MMU LUT entry 481 high
    \ Address offset: 0x1F0C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT482L_DEF
    \
    \ @brief Graphic MMU LUT entry 482 low
    \ Address offset: 0x1F10
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT482H_DEF
    \
    \ @brief Graphic MMU LUT entry 482 high
    \ Address offset: 0x1F14
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT483L_DEF
    \
    \ @brief Graphic MMU LUT entry 483 low
    \ Address offset: 0x1F18
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT483H_DEF
    \
    \ @brief Graphic MMU LUT entry 483 high
    \ Address offset: 0x1F1C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT484L_DEF
    \
    \ @brief Graphic MMU LUT entry 484 low
    \ Address offset: 0x1F20
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT484H_DEF
    \
    \ @brief Graphic MMU LUT entry 484 high
    \ Address offset: 0x1F24
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT485L_DEF
    \
    \ @brief Graphic MMU LUT entry 485 low
    \ Address offset: 0x1F28
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT485H_DEF
    \
    \ @brief Graphic MMU LUT entry 485 high
    \ Address offset: 0x1F2C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT486L_DEF
    \
    \ @brief Graphic MMU LUT entry 486 low
    \ Address offset: 0x1F30
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT486H_DEF
    \
    \ @brief Graphic MMU LUT entry 486 high
    \ Address offset: 0x1F34
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT487L_DEF
    \
    \ @brief Graphic MMU LUT entry 487 low
    \ Address offset: 0x1F38
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT487H_DEF
    \
    \ @brief Graphic MMU LUT entry 487 high
    \ Address offset: 0x1F3C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT488L_DEF
    \
    \ @brief Graphic MMU LUT entry 488 low
    \ Address offset: 0x1F40
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT488H_DEF
    \
    \ @brief Graphic MMU LUT entry 488 high
    \ Address offset: 0x1F44
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT489L_DEF
    \
    \ @brief Graphic MMU LUT entry 489 low
    \ Address offset: 0x1F48
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT489H_DEF
    \
    \ @brief Graphic MMU LUT entry 489 high
    \ Address offset: 0x1F4C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT490L_DEF
    \
    \ @brief Graphic MMU LUT entry 490 low
    \ Address offset: 0x1F50
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT490H_DEF
    \
    \ @brief Graphic MMU LUT entry 490 high
    \ Address offset: 0x1F54
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT491L_DEF
    \
    \ @brief Graphic MMU LUT entry 491 low
    \ Address offset: 0x1F58
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT491H_DEF
    \
    \ @brief Graphic MMU LUT entry 491 high
    \ Address offset: 0x1F5C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT492L_DEF
    \
    \ @brief Graphic MMU LUT entry 492 low
    \ Address offset: 0x1F60
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT492H_DEF
    \
    \ @brief Graphic MMU LUT entry 492 high
    \ Address offset: 0x1F64
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT493L_DEF
    \
    \ @brief Graphic MMU LUT entry 493 low
    \ Address offset: 0x1F68
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT493H_DEF
    \
    \ @brief Graphic MMU LUT entry 493 high
    \ Address offset: 0x1F6C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT494L_DEF
    \
    \ @brief Graphic MMU LUT entry 494 low
    \ Address offset: 0x1F70
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT494H_DEF
    \
    \ @brief Graphic MMU LUT entry 494 high
    \ Address offset: 0x1F74
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT495L_DEF
    \
    \ @brief Graphic MMU LUT entry 495 low
    \ Address offset: 0x1F78
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT495H_DEF
    \
    \ @brief Graphic MMU LUT entry 495 high
    \ Address offset: 0x1F7C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT496L_DEF
    \
    \ @brief Graphic MMU LUT entry 496 low
    \ Address offset: 0x1F80
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT496H_DEF
    \
    \ @brief Graphic MMU LUT entry 496 high
    \ Address offset: 0x1F84
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT497L_DEF
    \
    \ @brief Graphic MMU LUT entry 497 low
    \ Address offset: 0x1F88
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT497H_DEF
    \
    \ @brief Graphic MMU LUT entry 497 high
    \ Address offset: 0x1F8C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT498L_DEF
    \
    \ @brief Graphic MMU LUT entry 498 low
    \ Address offset: 0x1F90
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT498H_DEF
    \
    \ @brief Graphic MMU LUT entry 498 high
    \ Address offset: 0x1F94
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT499L_DEF
    \
    \ @brief Graphic MMU LUT entry 499 low
    \ Address offset: 0x1F98
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT499H_DEF
    \
    \ @brief Graphic MMU LUT entry 499 high
    \ Address offset: 0x1F9C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT500L_DEF
    \
    \ @brief Graphic MMU LUT entry 500 low
    \ Address offset: 0x1FA0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT500H_DEF
    \
    \ @brief Graphic MMU LUT entry 500 high
    \ Address offset: 0x1FA4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT501L_DEF
    \
    \ @brief Graphic MMU LUT entry 501 low
    \ Address offset: 0x1FA8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT501H_DEF
    \
    \ @brief Graphic MMU LUT entry 501 high
    \ Address offset: 0x1FAC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT502L_DEF
    \
    \ @brief Graphic MMU LUT entry 502 low
    \ Address offset: 0x1FB0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT502H_DEF
    \
    \ @brief Graphic MMU LUT entry 502 high
    \ Address offset: 0x1FB4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT503L_DEF
    \
    \ @brief Graphic MMU LUT entry 503 low
    \ Address offset: 0x1FB8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT503H_DEF
    \
    \ @brief Graphic MMU LUT entry 503 high
    \ Address offset: 0x1FBC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT504L_DEF
    \
    \ @brief Graphic MMU LUT entry 504 low
    \ Address offset: 0x1FC0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT504H_DEF
    \
    \ @brief Graphic MMU LUT entry 504 high
    \ Address offset: 0x1FC4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT505L_DEF
    \
    \ @brief Graphic MMU LUT entry 505 low
    \ Address offset: 0x1FC8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT505H_DEF
    \
    \ @brief Graphic MMU LUT entry 505 high
    \ Address offset: 0x1FCC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT506L_DEF
    \
    \ @brief Graphic MMU LUT entry 506 low
    \ Address offset: 0x1FD0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT506H_DEF
    \
    \ @brief Graphic MMU LUT entry 506 high
    \ Address offset: 0x1FD4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT507L_DEF
    \
    \ @brief Graphic MMU LUT entry 507 low
    \ Address offset: 0x1FD8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT507H_DEF
    \
    \ @brief Graphic MMU LUT entry 507 high
    \ Address offset: 0x1FDC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT508L_DEF
    \
    \ @brief Graphic MMU LUT entry 508 low
    \ Address offset: 0x1FE0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT508H_DEF
    \
    \ @brief Graphic MMU LUT entry 508 high
    \ Address offset: 0x1FE4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT509L_DEF
    \
    \ @brief Graphic MMU LUT entry 509 low
    \ Address offset: 0x1FE8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT509H_DEF
    \
    \ @brief Graphic MMU LUT entry 509 high
    \ Address offset: 0x1FEC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT510L_DEF
    \
    \ @brief Graphic MMU LUT entry 510 low
    \ Address offset: 0x1FF0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT510H_DEF
    \
    \ @brief Graphic MMU LUT entry 510 high
    \ Address offset: 0x1FF4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT511L_DEF
    \
    \ @brief Graphic MMU LUT entry 511 low
    \ Address offset: 0x1FF8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT511H_DEF
    \
    \ @brief Graphic MMU LUT entry 511 high
    \ Address offset: 0x1FFC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT512L_DEF
    \
    \ @brief Graphic MMU LUT entry 512 low
    \ Address offset: 0x2000
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT512H_DEF
    \
    \ @brief Graphic MMU LUT entry 512 high
    \ Address offset: 0x2004
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT513L_DEF
    \
    \ @brief Graphic MMU LUT entry 513 low
    \ Address offset: 0x2008
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT513H_DEF
    \
    \ @brief Graphic MMU LUT entry 513 high
    \ Address offset: 0x200C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT514L_DEF
    \
    \ @brief Graphic MMU LUT entry 514 low
    \ Address offset: 0x2010
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT514H_DEF
    \
    \ @brief Graphic MMU LUT entry 514 high
    \ Address offset: 0x2014
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT515L_DEF
    \
    \ @brief Graphic MMU LUT entry 515 low
    \ Address offset: 0x2018
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT515H_DEF
    \
    \ @brief Graphic MMU LUT entry 515 high
    \ Address offset: 0x201C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT516L_DEF
    \
    \ @brief Graphic MMU LUT entry 516 low
    \ Address offset: 0x2020
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT516H_DEF
    \
    \ @brief Graphic MMU LUT entry 516 high
    \ Address offset: 0x2024
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT517L_DEF
    \
    \ @brief Graphic MMU LUT entry 517 low
    \ Address offset: 0x2028
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT517H_DEF
    \
    \ @brief Graphic MMU LUT entry 517 high
    \ Address offset: 0x202C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT518L_DEF
    \
    \ @brief Graphic MMU LUT entry 518 low
    \ Address offset: 0x2030
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT518H_DEF
    \
    \ @brief Graphic MMU LUT entry 518 high
    \ Address offset: 0x2034
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT519L_DEF
    \
    \ @brief Graphic MMU LUT entry 519 low
    \ Address offset: 0x2038
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT519H_DEF
    \
    \ @brief Graphic MMU LUT entry 519 high
    \ Address offset: 0x203C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT520L_DEF
    \
    \ @brief Graphic MMU LUT entry 520 low
    \ Address offset: 0x2040
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT520H_DEF
    \
    \ @brief Graphic MMU LUT entry 520 high
    \ Address offset: 0x2044
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT521L_DEF
    \
    \ @brief Graphic MMU LUT entry 521 low
    \ Address offset: 0x2048
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT521H_DEF
    \
    \ @brief Graphic MMU LUT entry 521 high
    \ Address offset: 0x204C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT522L_DEF
    \
    \ @brief Graphic MMU LUT entry 522 low
    \ Address offset: 0x2050
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT522H_DEF
    \
    \ @brief Graphic MMU LUT entry 522 high
    \ Address offset: 0x2054
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT523L_DEF
    \
    \ @brief Graphic MMU LUT entry 523 low
    \ Address offset: 0x2058
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT523H_DEF
    \
    \ @brief Graphic MMU LUT entry 523 high
    \ Address offset: 0x205C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT524L_DEF
    \
    \ @brief Graphic MMU LUT entry 524 low
    \ Address offset: 0x2060
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT524H_DEF
    \
    \ @brief Graphic MMU LUT entry 524 high
    \ Address offset: 0x2064
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT525L_DEF
    \
    \ @brief Graphic MMU LUT entry 525 low
    \ Address offset: 0x2068
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT525H_DEF
    \
    \ @brief Graphic MMU LUT entry 525 high
    \ Address offset: 0x206C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT526L_DEF
    \
    \ @brief Graphic MMU LUT entry 526 low
    \ Address offset: 0x2070
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT526H_DEF
    \
    \ @brief Graphic MMU LUT entry 526 high
    \ Address offset: 0x2074
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT527L_DEF
    \
    \ @brief Graphic MMU LUT entry 527 low
    \ Address offset: 0x2078
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT527H_DEF
    \
    \ @brief Graphic MMU LUT entry 527 high
    \ Address offset: 0x207C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT528L_DEF
    \
    \ @brief Graphic MMU LUT entry 528 low
    \ Address offset: 0x2080
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT528H_DEF
    \
    \ @brief Graphic MMU LUT entry 528 high
    \ Address offset: 0x2084
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT529L_DEF
    \
    \ @brief Graphic MMU LUT entry 529 low
    \ Address offset: 0x2088
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT529H_DEF
    \
    \ @brief Graphic MMU LUT entry 529 high
    \ Address offset: 0x208C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT530L_DEF
    \
    \ @brief Graphic MMU LUT entry 530 low
    \ Address offset: 0x2090
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT530H_DEF
    \
    \ @brief Graphic MMU LUT entry 530 high
    \ Address offset: 0x2094
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT531L_DEF
    \
    \ @brief Graphic MMU LUT entry 531 low
    \ Address offset: 0x2098
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT531H_DEF
    \
    \ @brief Graphic MMU LUT entry 531 high
    \ Address offset: 0x209C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT532L_DEF
    \
    \ @brief Graphic MMU LUT entry 532 low
    \ Address offset: 0x20A0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT532H_DEF
    \
    \ @brief Graphic MMU LUT entry 532 high
    \ Address offset: 0x20A4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT533L_DEF
    \
    \ @brief Graphic MMU LUT entry 533 low
    \ Address offset: 0x20A8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT533H_DEF
    \
    \ @brief Graphic MMU LUT entry 533 high
    \ Address offset: 0x20AC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT534L_DEF
    \
    \ @brief Graphic MMU LUT entry 534 low
    \ Address offset: 0x20B0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT534H_DEF
    \
    \ @brief Graphic MMU LUT entry 534 high
    \ Address offset: 0x20B4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT535L_DEF
    \
    \ @brief Graphic MMU LUT entry 535 low
    \ Address offset: 0x20B8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT535H_DEF
    \
    \ @brief Graphic MMU LUT entry 535 high
    \ Address offset: 0x20BC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT536L_DEF
    \
    \ @brief Graphic MMU LUT entry 536 low
    \ Address offset: 0x20C0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT536H_DEF
    \
    \ @brief Graphic MMU LUT entry 536 high
    \ Address offset: 0x20C4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT537L_DEF
    \
    \ @brief Graphic MMU LUT entry 537 low
    \ Address offset: 0x20C8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT537H_DEF
    \
    \ @brief Graphic MMU LUT entry 537 high
    \ Address offset: 0x20CC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT538L_DEF
    \
    \ @brief Graphic MMU LUT entry 538 low
    \ Address offset: 0x20D0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT538H_DEF
    \
    \ @brief Graphic MMU LUT entry 538 high
    \ Address offset: 0x20D4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT539L_DEF
    \
    \ @brief Graphic MMU LUT entry 539 low
    \ Address offset: 0x20D8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT539H_DEF
    \
    \ @brief Graphic MMU LUT entry 539 high
    \ Address offset: 0x20DC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT540L_DEF
    \
    \ @brief Graphic MMU LUT entry 540 low
    \ Address offset: 0x20E0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT540H_DEF
    \
    \ @brief Graphic MMU LUT entry 540 high
    \ Address offset: 0x20E4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT541L_DEF
    \
    \ @brief Graphic MMU LUT entry 541 low
    \ Address offset: 0x20E8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT541H_DEF
    \
    \ @brief Graphic MMU LUT entry 541 high
    \ Address offset: 0x20EC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT542L_DEF
    \
    \ @brief Graphic MMU LUT entry 542 low
    \ Address offset: 0x20F0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT542H_DEF
    \
    \ @brief Graphic MMU LUT entry 542 high
    \ Address offset: 0x20F4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT543L_DEF
    \
    \ @brief Graphic MMU LUT entry 543 low
    \ Address offset: 0x20F8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT543H_DEF
    \
    \ @brief Graphic MMU LUT entry 543 high
    \ Address offset: 0x20FC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT544L_DEF
    \
    \ @brief Graphic MMU LUT entry 544 low
    \ Address offset: 0x2100
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT544H_DEF
    \
    \ @brief Graphic MMU LUT entry 544 high
    \ Address offset: 0x2104
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT545L_DEF
    \
    \ @brief Graphic MMU LUT entry 545 low
    \ Address offset: 0x2108
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT545H_DEF
    \
    \ @brief Graphic MMU LUT entry 545 high
    \ Address offset: 0x210C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT546L_DEF
    \
    \ @brief Graphic MMU LUT entry 546 low
    \ Address offset: 0x2110
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT546H_DEF
    \
    \ @brief Graphic MMU LUT entry 546 high
    \ Address offset: 0x2114
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT547L_DEF
    \
    \ @brief Graphic MMU LUT entry 547 low
    \ Address offset: 0x2118
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT547H_DEF
    \
    \ @brief Graphic MMU LUT entry 547 high
    \ Address offset: 0x211C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT548L_DEF
    \
    \ @brief Graphic MMU LUT entry 548 low
    \ Address offset: 0x2120
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT548H_DEF
    \
    \ @brief Graphic MMU LUT entry 548 high
    \ Address offset: 0x2124
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT549L_DEF
    \
    \ @brief Graphic MMU LUT entry 549 low
    \ Address offset: 0x2128
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT549H_DEF
    \
    \ @brief Graphic MMU LUT entry 549 high
    \ Address offset: 0x212C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT550L_DEF
    \
    \ @brief Graphic MMU LUT entry 550 low
    \ Address offset: 0x2130
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT550H_DEF
    \
    \ @brief Graphic MMU LUT entry 550 high
    \ Address offset: 0x2134
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT551L_DEF
    \
    \ @brief Graphic MMU LUT entry 551 low
    \ Address offset: 0x2138
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT551H_DEF
    \
    \ @brief Graphic MMU LUT entry 551 high
    \ Address offset: 0x213C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT552L_DEF
    \
    \ @brief Graphic MMU LUT entry 552 low
    \ Address offset: 0x2140
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT552H_DEF
    \
    \ @brief Graphic MMU LUT entry 552 high
    \ Address offset: 0x2144
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT553L_DEF
    \
    \ @brief Graphic MMU LUT entry 553 low
    \ Address offset: 0x2148
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT553H_DEF
    \
    \ @brief Graphic MMU LUT entry 553 high
    \ Address offset: 0x214C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT554L_DEF
    \
    \ @brief Graphic MMU LUT entry 554 low
    \ Address offset: 0x2150
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT554H_DEF
    \
    \ @brief Graphic MMU LUT entry 554 high
    \ Address offset: 0x2154
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT555L_DEF
    \
    \ @brief Graphic MMU LUT entry 555 low
    \ Address offset: 0x2158
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT555H_DEF
    \
    \ @brief Graphic MMU LUT entry 555 high
    \ Address offset: 0x215C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT556L_DEF
    \
    \ @brief Graphic MMU LUT entry 556 low
    \ Address offset: 0x2160
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT556H_DEF
    \
    \ @brief Graphic MMU LUT entry 556 high
    \ Address offset: 0x2164
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT557L_DEF
    \
    \ @brief Graphic MMU LUT entry 557 low
    \ Address offset: 0x2168
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT557H_DEF
    \
    \ @brief Graphic MMU LUT entry 557 high
    \ Address offset: 0x216C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT558L_DEF
    \
    \ @brief Graphic MMU LUT entry 558 low
    \ Address offset: 0x2170
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT558H_DEF
    \
    \ @brief Graphic MMU LUT entry 558 high
    \ Address offset: 0x2174
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT559L_DEF
    \
    \ @brief Graphic MMU LUT entry 559 low
    \ Address offset: 0x2178
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT559H_DEF
    \
    \ @brief Graphic MMU LUT entry 559 high
    \ Address offset: 0x217C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT560L_DEF
    \
    \ @brief Graphic MMU LUT entry 560 low
    \ Address offset: 0x2180
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT560H_DEF
    \
    \ @brief Graphic MMU LUT entry 560 high
    \ Address offset: 0x2184
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT561L_DEF
    \
    \ @brief Graphic MMU LUT entry 561 low
    \ Address offset: 0x2188
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT561H_DEF
    \
    \ @brief Graphic MMU LUT entry 561 high
    \ Address offset: 0x218C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT562L_DEF
    \
    \ @brief Graphic MMU LUT entry 562 low
    \ Address offset: 0x2190
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT562H_DEF
    \
    \ @brief Graphic MMU LUT entry 562 high
    \ Address offset: 0x2194
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT563L_DEF
    \
    \ @brief Graphic MMU LUT entry 563 low
    \ Address offset: 0x2198
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT563H_DEF
    \
    \ @brief Graphic MMU LUT entry 563 high
    \ Address offset: 0x219C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT564L_DEF
    \
    \ @brief Graphic MMU LUT entry 564 low
    \ Address offset: 0x21A0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT564H_DEF
    \
    \ @brief Graphic MMU LUT entry 564 high
    \ Address offset: 0x21A4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT565L_DEF
    \
    \ @brief Graphic MMU LUT entry 565 low
    \ Address offset: 0x21A8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT565H_DEF
    \
    \ @brief Graphic MMU LUT entry 565 high
    \ Address offset: 0x21AC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT566L_DEF
    \
    \ @brief Graphic MMU LUT entry 566 low
    \ Address offset: 0x21B0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT566H_DEF
    \
    \ @brief Graphic MMU LUT entry 566 high
    \ Address offset: 0x21B4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT567L_DEF
    \
    \ @brief Graphic MMU LUT entry 567 low
    \ Address offset: 0x21B8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT567H_DEF
    \
    \ @brief Graphic MMU LUT entry 567 high
    \ Address offset: 0x21BC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT568L_DEF
    \
    \ @brief Graphic MMU LUT entry 568 low
    \ Address offset: 0x21C0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT568H_DEF
    \
    \ @brief Graphic MMU LUT entry 568 high
    \ Address offset: 0x21C4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT569L_DEF
    \
    \ @brief Graphic MMU LUT entry 569 low
    \ Address offset: 0x21C8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT569H_DEF
    \
    \ @brief Graphic MMU LUT entry 569 high
    \ Address offset: 0x21CC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT570L_DEF
    \
    \ @brief Graphic MMU LUT entry 570 low
    \ Address offset: 0x21D0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT570H_DEF
    \
    \ @brief Graphic MMU LUT entry 570 high
    \ Address offset: 0x21D4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT571L_DEF
    \
    \ @brief Graphic MMU LUT entry 571 low
    \ Address offset: 0x21D8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT571H_DEF
    \
    \ @brief Graphic MMU LUT entry 571 high
    \ Address offset: 0x21DC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT572L_DEF
    \
    \ @brief Graphic MMU LUT entry 572 low
    \ Address offset: 0x21E0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT572H_DEF
    \
    \ @brief Graphic MMU LUT entry 572 high
    \ Address offset: 0x21E4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT573L_DEF
    \
    \ @brief Graphic MMU LUT entry 573 low
    \ Address offset: 0x21E8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT573H_DEF
    \
    \ @brief Graphic MMU LUT entry 573 high
    \ Address offset: 0x21EC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT574L_DEF
    \
    \ @brief Graphic MMU LUT entry 574 low
    \ Address offset: 0x21F0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT574H_DEF
    \
    \ @brief Graphic MMU LUT entry 574 high
    \ Address offset: 0x21F4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT575L_DEF
    \
    \ @brief Graphic MMU LUT entry 575 low
    \ Address offset: 0x21F8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT575H_DEF
    \
    \ @brief Graphic MMU LUT entry 575 high
    \ Address offset: 0x21FC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT576L_DEF
    \
    \ @brief Graphic MMU LUT entry 576 low
    \ Address offset: 0x2200
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT576H_DEF
    \
    \ @brief Graphic MMU LUT entry 576 high
    \ Address offset: 0x2204
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT577L_DEF
    \
    \ @brief Graphic MMU LUT entry 577 low
    \ Address offset: 0x2208
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT577H_DEF
    \
    \ @brief Graphic MMU LUT entry 577 high
    \ Address offset: 0x220C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT578L_DEF
    \
    \ @brief Graphic MMU LUT entry 578 low
    \ Address offset: 0x2210
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT578H_DEF
    \
    \ @brief Graphic MMU LUT entry 578 high
    \ Address offset: 0x2214
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT579L_DEF
    \
    \ @brief Graphic MMU LUT entry 579 low
    \ Address offset: 0x2218
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT579H_DEF
    \
    \ @brief Graphic MMU LUT entry 579 high
    \ Address offset: 0x221C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT580L_DEF
    \
    \ @brief Graphic MMU LUT entry 580 low
    \ Address offset: 0x2220
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT580H_DEF
    \
    \ @brief Graphic MMU LUT entry 580 high
    \ Address offset: 0x2224
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT581L_DEF
    \
    \ @brief Graphic MMU LUT entry 581 low
    \ Address offset: 0x2228
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT581H_DEF
    \
    \ @brief Graphic MMU LUT entry 581 high
    \ Address offset: 0x222C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT582L_DEF
    \
    \ @brief Graphic MMU LUT entry 582 low
    \ Address offset: 0x2230
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT582H_DEF
    \
    \ @brief Graphic MMU LUT entry 582 high
    \ Address offset: 0x2234
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT583L_DEF
    \
    \ @brief Graphic MMU LUT entry 583 low
    \ Address offset: 0x2238
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT583H_DEF
    \
    \ @brief Graphic MMU LUT entry 583 high
    \ Address offset: 0x223C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT584L_DEF
    \
    \ @brief Graphic MMU LUT entry 584 low
    \ Address offset: 0x2240
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT584H_DEF
    \
    \ @brief Graphic MMU LUT entry 584 high
    \ Address offset: 0x2244
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT585L_DEF
    \
    \ @brief Graphic MMU LUT entry 585 low
    \ Address offset: 0x2248
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT585H_DEF
    \
    \ @brief Graphic MMU LUT entry 585 high
    \ Address offset: 0x224C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT586L_DEF
    \
    \ @brief Graphic MMU LUT entry 586 low
    \ Address offset: 0x2250
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT586H_DEF
    \
    \ @brief Graphic MMU LUT entry 586 high
    \ Address offset: 0x2254
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT587L_DEF
    \
    \ @brief Graphic MMU LUT entry 587 low
    \ Address offset: 0x2258
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT587H_DEF
    \
    \ @brief Graphic MMU LUT entry 587 high
    \ Address offset: 0x225C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT588L_DEF
    \
    \ @brief Graphic MMU LUT entry 588 low
    \ Address offset: 0x2260
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT588H_DEF
    \
    \ @brief Graphic MMU LUT entry 588 high
    \ Address offset: 0x2264
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT589L_DEF
    \
    \ @brief Graphic MMU LUT entry 589 low
    \ Address offset: 0x2268
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT589H_DEF
    \
    \ @brief Graphic MMU LUT entry 589 high
    \ Address offset: 0x226C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT590L_DEF
    \
    \ @brief Graphic MMU LUT entry 590 low
    \ Address offset: 0x2270
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT590H_DEF
    \
    \ @brief Graphic MMU LUT entry 590 high
    \ Address offset: 0x2274
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT591L_DEF
    \
    \ @brief Graphic MMU LUT entry 591 low
    \ Address offset: 0x2278
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT591H_DEF
    \
    \ @brief Graphic MMU LUT entry 591 high
    \ Address offset: 0x227C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT592L_DEF
    \
    \ @brief Graphic MMU LUT entry 592 low
    \ Address offset: 0x2280
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT592H_DEF
    \
    \ @brief Graphic MMU LUT entry 592 high
    \ Address offset: 0x2284
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT593L_DEF
    \
    \ @brief Graphic MMU LUT entry 593 low
    \ Address offset: 0x2288
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT593H_DEF
    \
    \ @brief Graphic MMU LUT entry 593 high
    \ Address offset: 0x228C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT594L_DEF
    \
    \ @brief Graphic MMU LUT entry 594 low
    \ Address offset: 0x2290
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT594H_DEF
    \
    \ @brief Graphic MMU LUT entry 594 high
    \ Address offset: 0x2294
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT595L_DEF
    \
    \ @brief Graphic MMU LUT entry 595 low
    \ Address offset: 0x2298
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT595H_DEF
    \
    \ @brief Graphic MMU LUT entry 595 high
    \ Address offset: 0x229C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT596L_DEF
    \
    \ @brief Graphic MMU LUT entry 596 low
    \ Address offset: 0x22A0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT596H_DEF
    \
    \ @brief Graphic MMU LUT entry 596 high
    \ Address offset: 0x22A4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT597L_DEF
    \
    \ @brief Graphic MMU LUT entry 597 low
    \ Address offset: 0x22A8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT597H_DEF
    \
    \ @brief Graphic MMU LUT entry 597 high
    \ Address offset: 0x22AC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT598L_DEF
    \
    \ @brief Graphic MMU LUT entry 598 low
    \ Address offset: 0x22B0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT598H_DEF
    \
    \ @brief Graphic MMU LUT entry 598 high
    \ Address offset: 0x22B4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT599L_DEF
    \
    \ @brief Graphic MMU LUT entry 599 low
    \ Address offset: 0x22B8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT599H_DEF
    \
    \ @brief Graphic MMU LUT entry 599 high
    \ Address offset: 0x22BC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT600L_DEF
    \
    \ @brief Graphic MMU LUT entry 600 low
    \ Address offset: 0x22C0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT600H_DEF
    \
    \ @brief Graphic MMU LUT entry 600 high
    \ Address offset: 0x22C4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT601L_DEF
    \
    \ @brief Graphic MMU LUT entry 601 low
    \ Address offset: 0x22C8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT601H_DEF
    \
    \ @brief Graphic MMU LUT entry 601 high
    \ Address offset: 0x22CC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT602L_DEF
    \
    \ @brief Graphic MMU LUT entry 602 low
    \ Address offset: 0x22D0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT602H_DEF
    \
    \ @brief Graphic MMU LUT entry 602 high
    \ Address offset: 0x22D4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT603L_DEF
    \
    \ @brief Graphic MMU LUT entry 603 low
    \ Address offset: 0x22D8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT603H_DEF
    \
    \ @brief Graphic MMU LUT entry 603 high
    \ Address offset: 0x22DC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT604L_DEF
    \
    \ @brief Graphic MMU LUT entry 604 low
    \ Address offset: 0x22E0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT604H_DEF
    \
    \ @brief Graphic MMU LUT entry 604 high
    \ Address offset: 0x22E4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT605L_DEF
    \
    \ @brief Graphic MMU LUT entry 605 low
    \ Address offset: 0x22E8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT605H_DEF
    \
    \ @brief Graphic MMU LUT entry 605 high
    \ Address offset: 0x22EC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT606L_DEF
    \
    \ @brief Graphic MMU LUT entry 606 low
    \ Address offset: 0x22F0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT606H_DEF
    \
    \ @brief Graphic MMU LUT entry 606 high
    \ Address offset: 0x22F4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT607L_DEF
    \
    \ @brief Graphic MMU LUT entry 607 low
    \ Address offset: 0x22F8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT607H_DEF
    \
    \ @brief Graphic MMU LUT entry 607 high
    \ Address offset: 0x22FC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT608L_DEF
    \
    \ @brief Graphic MMU LUT entry 608 low
    \ Address offset: 0x2300
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT608H_DEF
    \
    \ @brief Graphic MMU LUT entry 608 high
    \ Address offset: 0x2304
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT609L_DEF
    \
    \ @brief Graphic MMU LUT entry 609 low
    \ Address offset: 0x2308
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT609H_DEF
    \
    \ @brief Graphic MMU LUT entry 609 high
    \ Address offset: 0x230C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT610L_DEF
    \
    \ @brief Graphic MMU LUT entry 610 low
    \ Address offset: 0x2310
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT610H_DEF
    \
    \ @brief Graphic MMU LUT entry 610 high
    \ Address offset: 0x2314
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT611L_DEF
    \
    \ @brief Graphic MMU LUT entry 611 low
    \ Address offset: 0x2318
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT611H_DEF
    \
    \ @brief Graphic MMU LUT entry 611 high
    \ Address offset: 0x231C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT612L_DEF
    \
    \ @brief Graphic MMU LUT entry 612 low
    \ Address offset: 0x2320
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT612H_DEF
    \
    \ @brief Graphic MMU LUT entry 612 high
    \ Address offset: 0x2324
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT613L_DEF
    \
    \ @brief Graphic MMU LUT entry 613 low
    \ Address offset: 0x2328
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT613H_DEF
    \
    \ @brief Graphic MMU LUT entry 613 high
    \ Address offset: 0x232C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT614L_DEF
    \
    \ @brief Graphic MMU LUT entry 614 low
    \ Address offset: 0x2330
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT614H_DEF
    \
    \ @brief Graphic MMU LUT entry 614 high
    \ Address offset: 0x2334
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT615L_DEF
    \
    \ @brief Graphic MMU LUT entry 615 low
    \ Address offset: 0x2338
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT615H_DEF
    \
    \ @brief Graphic MMU LUT entry 615 high
    \ Address offset: 0x233C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT616L_DEF
    \
    \ @brief Graphic MMU LUT entry 616 low
    \ Address offset: 0x2340
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT616H_DEF
    \
    \ @brief Graphic MMU LUT entry 616 high
    \ Address offset: 0x2344
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT617L_DEF
    \
    \ @brief Graphic MMU LUT entry 617 low
    \ Address offset: 0x2348
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT617H_DEF
    \
    \ @brief Graphic MMU LUT entry 617 high
    \ Address offset: 0x234C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT618L_DEF
    \
    \ @brief Graphic MMU LUT entry 618 low
    \ Address offset: 0x2350
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT618H_DEF
    \
    \ @brief Graphic MMU LUT entry 618 high
    \ Address offset: 0x2354
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT619L_DEF
    \
    \ @brief Graphic MMU LUT entry 619 low
    \ Address offset: 0x2358
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT619H_DEF
    \
    \ @brief Graphic MMU LUT entry 619 high
    \ Address offset: 0x235C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT620L_DEF
    \
    \ @brief Graphic MMU LUT entry 620 low
    \ Address offset: 0x2360
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT620H_DEF
    \
    \ @brief Graphic MMU LUT entry 620 high
    \ Address offset: 0x2364
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT621L_DEF
    \
    \ @brief Graphic MMU LUT entry 621 low
    \ Address offset: 0x2368
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT621H_DEF
    \
    \ @brief Graphic MMU LUT entry 621 high
    \ Address offset: 0x236C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT622L_DEF
    \
    \ @brief Graphic MMU LUT entry 622 low
    \ Address offset: 0x2370
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT622H_DEF
    \
    \ @brief Graphic MMU LUT entry 622 high
    \ Address offset: 0x2374
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT623L_DEF
    \
    \ @brief Graphic MMU LUT entry 623 low
    \ Address offset: 0x2378
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT623H_DEF
    \
    \ @brief Graphic MMU LUT entry 623 high
    \ Address offset: 0x237C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT624L_DEF
    \
    \ @brief Graphic MMU LUT entry 624 low
    \ Address offset: 0x2380
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT624H_DEF
    \
    \ @brief Graphic MMU LUT entry 624 high
    \ Address offset: 0x2384
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT625L_DEF
    \
    \ @brief Graphic MMU LUT entry 625 low
    \ Address offset: 0x2388
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT625H_DEF
    \
    \ @brief Graphic MMU LUT entry 625 high
    \ Address offset: 0x238C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT626L_DEF
    \
    \ @brief Graphic MMU LUT entry 626 low
    \ Address offset: 0x2390
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT626H_DEF
    \
    \ @brief Graphic MMU LUT entry 626 high
    \ Address offset: 0x2394
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT627L_DEF
    \
    \ @brief Graphic MMU LUT entry 627 low
    \ Address offset: 0x2398
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT627H_DEF
    \
    \ @brief Graphic MMU LUT entry 627 high
    \ Address offset: 0x239C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT628L_DEF
    \
    \ @brief Graphic MMU LUT entry 628 low
    \ Address offset: 0x23A0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT628H_DEF
    \
    \ @brief Graphic MMU LUT entry 628 high
    \ Address offset: 0x23A4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT629L_DEF
    \
    \ @brief Graphic MMU LUT entry 629 low
    \ Address offset: 0x23A8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT629H_DEF
    \
    \ @brief Graphic MMU LUT entry 629 high
    \ Address offset: 0x23AC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT630L_DEF
    \
    \ @brief Graphic MMU LUT entry 630 low
    \ Address offset: 0x23B0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT630H_DEF
    \
    \ @brief Graphic MMU LUT entry 630 high
    \ Address offset: 0x23B4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT631L_DEF
    \
    \ @brief Graphic MMU LUT entry 631 low
    \ Address offset: 0x23B8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT631H_DEF
    \
    \ @brief Graphic MMU LUT entry 631 high
    \ Address offset: 0x23BC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT632L_DEF
    \
    \ @brief Graphic MMU LUT entry 632 low
    \ Address offset: 0x23C0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT632H_DEF
    \
    \ @brief Graphic MMU LUT entry 632 high
    \ Address offset: 0x23C4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT633L_DEF
    \
    \ @brief Graphic MMU LUT entry 633 low
    \ Address offset: 0x23C8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT633H_DEF
    \
    \ @brief Graphic MMU LUT entry 633 high
    \ Address offset: 0x23CC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT634L_DEF
    \
    \ @brief Graphic MMU LUT entry 634 low
    \ Address offset: 0x23D0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT634H_DEF
    \
    \ @brief Graphic MMU LUT entry 634 high
    \ Address offset: 0x23D4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT635L_DEF
    \
    \ @brief Graphic MMU LUT entry 635 low
    \ Address offset: 0x23D8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT635H_DEF
    \
    \ @brief Graphic MMU LUT entry 635 high
    \ Address offset: 0x23DC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT636L_DEF
    \
    \ @brief Graphic MMU LUT entry 636 low
    \ Address offset: 0x23E0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT636H_DEF
    \
    \ @brief Graphic MMU LUT entry 636 high
    \ Address offset: 0x23E4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT637L_DEF
    \
    \ @brief Graphic MMU LUT entry 637 low
    \ Address offset: 0x23E8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT637H_DEF
    \
    \ @brief Graphic MMU LUT entry 637 high
    \ Address offset: 0x23EC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT638L_DEF
    \
    \ @brief Graphic MMU LUT entry 638 low
    \ Address offset: 0x23F0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT638H_DEF
    \
    \ @brief Graphic MMU LUT entry 638 high
    \ Address offset: 0x23F4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT639L_DEF
    \
    \ @brief Graphic MMU LUT entry 639 low
    \ Address offset: 0x23F8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT639H_DEF
    \
    \ @brief Graphic MMU LUT entry 639 high
    \ Address offset: 0x23FC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT640L_DEF
    \
    \ @brief Graphic MMU LUT entry 640 low
    \ Address offset: 0x2400
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT640H_DEF
    \
    \ @brief Graphic MMU LUT entry 640 high
    \ Address offset: 0x2404
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT641L_DEF
    \
    \ @brief Graphic MMU LUT entry 641 low
    \ Address offset: 0x2408
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT641H_DEF
    \
    \ @brief Graphic MMU LUT entry 641 high
    \ Address offset: 0x240C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT642L_DEF
    \
    \ @brief Graphic MMU LUT entry 642 low
    \ Address offset: 0x2410
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT642H_DEF
    \
    \ @brief Graphic MMU LUT entry 642 high
    \ Address offset: 0x2414
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT643L_DEF
    \
    \ @brief Graphic MMU LUT entry 643 low
    \ Address offset: 0x2418
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT643H_DEF
    \
    \ @brief Graphic MMU LUT entry 643 high
    \ Address offset: 0x241C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT644L_DEF
    \
    \ @brief Graphic MMU LUT entry 644 low
    \ Address offset: 0x2420
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT644H_DEF
    \
    \ @brief Graphic MMU LUT entry 644 high
    \ Address offset: 0x2424
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT645L_DEF
    \
    \ @brief Graphic MMU LUT entry 645 low
    \ Address offset: 0x2428
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT645H_DEF
    \
    \ @brief Graphic MMU LUT entry 645 high
    \ Address offset: 0x242C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT646L_DEF
    \
    \ @brief Graphic MMU LUT entry 646 low
    \ Address offset: 0x2430
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT646H_DEF
    \
    \ @brief Graphic MMU LUT entry 646 high
    \ Address offset: 0x2434
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT647L_DEF
    \
    \ @brief Graphic MMU LUT entry 647 low
    \ Address offset: 0x2438
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT647H_DEF
    \
    \ @brief Graphic MMU LUT entry 647 high
    \ Address offset: 0x243C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT648L_DEF
    \
    \ @brief Graphic MMU LUT entry 648 low
    \ Address offset: 0x2440
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT648H_DEF
    \
    \ @brief Graphic MMU LUT entry 648 high
    \ Address offset: 0x2444
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT649L_DEF
    \
    \ @brief Graphic MMU LUT entry 649 low
    \ Address offset: 0x2448
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT649H_DEF
    \
    \ @brief Graphic MMU LUT entry 649 high
    \ Address offset: 0x244C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT650L_DEF
    \
    \ @brief Graphic MMU LUT entry 650 low
    \ Address offset: 0x2450
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT650H_DEF
    \
    \ @brief Graphic MMU LUT entry 650 high
    \ Address offset: 0x2454
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT651L_DEF
    \
    \ @brief Graphic MMU LUT entry 651 low
    \ Address offset: 0x2458
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT651H_DEF
    \
    \ @brief Graphic MMU LUT entry 651 high
    \ Address offset: 0x245C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT652L_DEF
    \
    \ @brief Graphic MMU LUT entry 652 low
    \ Address offset: 0x2460
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT652H_DEF
    \
    \ @brief Graphic MMU LUT entry 652 high
    \ Address offset: 0x2464
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT653L_DEF
    \
    \ @brief Graphic MMU LUT entry 653 low
    \ Address offset: 0x2468
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT653H_DEF
    \
    \ @brief Graphic MMU LUT entry 653 high
    \ Address offset: 0x246C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT654L_DEF
    \
    \ @brief Graphic MMU LUT entry 654 low
    \ Address offset: 0x2470
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT654H_DEF
    \
    \ @brief Graphic MMU LUT entry 654 high
    \ Address offset: 0x2474
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT655L_DEF
    \
    \ @brief Graphic MMU LUT entry 655 low
    \ Address offset: 0x2478
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT655H_DEF
    \
    \ @brief Graphic MMU LUT entry 655 high
    \ Address offset: 0x247C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT656L_DEF
    \
    \ @brief Graphic MMU LUT entry 656 low
    \ Address offset: 0x2480
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT656H_DEF
    \
    \ @brief Graphic MMU LUT entry 656 high
    \ Address offset: 0x2484
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT657L_DEF
    \
    \ @brief Graphic MMU LUT entry 657 low
    \ Address offset: 0x2488
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT657H_DEF
    \
    \ @brief Graphic MMU LUT entry 657 high
    \ Address offset: 0x248C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT658L_DEF
    \
    \ @brief Graphic MMU LUT entry 658 low
    \ Address offset: 0x2490
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT658H_DEF
    \
    \ @brief Graphic MMU LUT entry 658 high
    \ Address offset: 0x2494
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT659L_DEF
    \
    \ @brief Graphic MMU LUT entry 659 low
    \ Address offset: 0x2498
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT659H_DEF
    \
    \ @brief Graphic MMU LUT entry 659 high
    \ Address offset: 0x249C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT660L_DEF
    \
    \ @brief Graphic MMU LUT entry 660 low
    \ Address offset: 0x24A0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT660H_DEF
    \
    \ @brief Graphic MMU LUT entry 660 high
    \ Address offset: 0x24A4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT661L_DEF
    \
    \ @brief Graphic MMU LUT entry 661 low
    \ Address offset: 0x24A8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT661H_DEF
    \
    \ @brief Graphic MMU LUT entry 661 high
    \ Address offset: 0x24AC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT662L_DEF
    \
    \ @brief Graphic MMU LUT entry 662 low
    \ Address offset: 0x24B0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT662H_DEF
    \
    \ @brief Graphic MMU LUT entry 662 high
    \ Address offset: 0x24B4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT663L_DEF
    \
    \ @brief Graphic MMU LUT entry 663 low
    \ Address offset: 0x24B8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT663H_DEF
    \
    \ @brief Graphic MMU LUT entry 663 high
    \ Address offset: 0x24BC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT664L_DEF
    \
    \ @brief Graphic MMU LUT entry 664 low
    \ Address offset: 0x24C0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT664H_DEF
    \
    \ @brief Graphic MMU LUT entry 664 high
    \ Address offset: 0x24C4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT665L_DEF
    \
    \ @brief Graphic MMU LUT entry 665 low
    \ Address offset: 0x24C8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT665H_DEF
    \
    \ @brief Graphic MMU LUT entry 665 high
    \ Address offset: 0x24CC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT666L_DEF
    \
    \ @brief Graphic MMU LUT entry 666 low
    \ Address offset: 0x24D0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT666H_DEF
    \
    \ @brief Graphic MMU LUT entry 666 high
    \ Address offset: 0x24D4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT667L_DEF
    \
    \ @brief Graphic MMU LUT entry 667 low
    \ Address offset: 0x24D8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT667H_DEF
    \
    \ @brief Graphic MMU LUT entry 667 high
    \ Address offset: 0x24DC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT668L_DEF
    \
    \ @brief Graphic MMU LUT entry 668 low
    \ Address offset: 0x24E0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT668H_DEF
    \
    \ @brief Graphic MMU LUT entry 668 high
    \ Address offset: 0x24E4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT669L_DEF
    \
    \ @brief Graphic MMU LUT entry 669 low
    \ Address offset: 0x24E8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT669H_DEF
    \
    \ @brief Graphic MMU LUT entry 669 high
    \ Address offset: 0x24EC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT670L_DEF
    \
    \ @brief Graphic MMU LUT entry 670 low
    \ Address offset: 0x24F0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT670H_DEF
    \
    \ @brief Graphic MMU LUT entry 670 high
    \ Address offset: 0x24F4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT671L_DEF
    \
    \ @brief Graphic MMU LUT entry 671 low
    \ Address offset: 0x24F8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT671H_DEF
    \
    \ @brief Graphic MMU LUT entry 671 high
    \ Address offset: 0x24FC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT672L_DEF
    \
    \ @brief Graphic MMU LUT entry 672 low
    \ Address offset: 0x2500
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT672H_DEF
    \
    \ @brief Graphic MMU LUT entry 672 high
    \ Address offset: 0x2504
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT673L_DEF
    \
    \ @brief Graphic MMU LUT entry 673 low
    \ Address offset: 0x2508
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT673H_DEF
    \
    \ @brief Graphic MMU LUT entry 673 high
    \ Address offset: 0x250C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT674L_DEF
    \
    \ @brief Graphic MMU LUT entry 674 low
    \ Address offset: 0x2510
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT674H_DEF
    \
    \ @brief Graphic MMU LUT entry 674 high
    \ Address offset: 0x2514
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT675L_DEF
    \
    \ @brief Graphic MMU LUT entry 675 low
    \ Address offset: 0x2518
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT675H_DEF
    \
    \ @brief Graphic MMU LUT entry 675 high
    \ Address offset: 0x251C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT676L_DEF
    \
    \ @brief Graphic MMU LUT entry 676 low
    \ Address offset: 0x2520
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT676H_DEF
    \
    \ @brief Graphic MMU LUT entry 676 high
    \ Address offset: 0x2524
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT677L_DEF
    \
    \ @brief Graphic MMU LUT entry 677 low
    \ Address offset: 0x2528
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT677H_DEF
    \
    \ @brief Graphic MMU LUT entry 677 high
    \ Address offset: 0x252C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT678L_DEF
    \
    \ @brief Graphic MMU LUT entry 678 low
    \ Address offset: 0x2530
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT678H_DEF
    \
    \ @brief Graphic MMU LUT entry 678 high
    \ Address offset: 0x2534
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT679L_DEF
    \
    \ @brief Graphic MMU LUT entry 679 low
    \ Address offset: 0x2538
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT679H_DEF
    \
    \ @brief Graphic MMU LUT entry 679 high
    \ Address offset: 0x253C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT680L_DEF
    \
    \ @brief Graphic MMU LUT entry 680 low
    \ Address offset: 0x2540
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT680H_DEF
    \
    \ @brief Graphic MMU LUT entry 680 high
    \ Address offset: 0x2544
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT681L_DEF
    \
    \ @brief Graphic MMU LUT entry 681 low
    \ Address offset: 0x2548
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT681H_DEF
    \
    \ @brief Graphic MMU LUT entry 681 high
    \ Address offset: 0x254C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT682L_DEF
    \
    \ @brief Graphic MMU LUT entry 682 low
    \ Address offset: 0x2550
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT682H_DEF
    \
    \ @brief Graphic MMU LUT entry 682 high
    \ Address offset: 0x2554
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT683L_DEF
    \
    \ @brief Graphic MMU LUT entry 683 low
    \ Address offset: 0x2558
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT683H_DEF
    \
    \ @brief Graphic MMU LUT entry 683 high
    \ Address offset: 0x255C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT684L_DEF
    \
    \ @brief Graphic MMU LUT entry 684 low
    \ Address offset: 0x2560
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT684H_DEF
    \
    \ @brief Graphic MMU LUT entry 684 high
    \ Address offset: 0x2564
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT685L_DEF
    \
    \ @brief Graphic MMU LUT entry 685 low
    \ Address offset: 0x2568
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT685H_DEF
    \
    \ @brief Graphic MMU LUT entry 685 high
    \ Address offset: 0x256C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT686L_DEF
    \
    \ @brief Graphic MMU LUT entry 686 low
    \ Address offset: 0x2570
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT686H_DEF
    \
    \ @brief Graphic MMU LUT entry 686 high
    \ Address offset: 0x2574
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT687L_DEF
    \
    \ @brief Graphic MMU LUT entry 687 low
    \ Address offset: 0x2578
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT687H_DEF
    \
    \ @brief Graphic MMU LUT entry 687 high
    \ Address offset: 0x257C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT688L_DEF
    \
    \ @brief Graphic MMU LUT entry 688 low
    \ Address offset: 0x2580
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT688H_DEF
    \
    \ @brief Graphic MMU LUT entry 688 high
    \ Address offset: 0x2584
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT689L_DEF
    \
    \ @brief Graphic MMU LUT entry 689 low
    \ Address offset: 0x2588
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT689H_DEF
    \
    \ @brief Graphic MMU LUT entry 689 high
    \ Address offset: 0x258C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT690L_DEF
    \
    \ @brief Graphic MMU LUT entry 690 low
    \ Address offset: 0x2590
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT690H_DEF
    \
    \ @brief Graphic MMU LUT entry 690 high
    \ Address offset: 0x2594
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT691L_DEF
    \
    \ @brief Graphic MMU LUT entry 691 low
    \ Address offset: 0x2598
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT691H_DEF
    \
    \ @brief Graphic MMU LUT entry 691 high
    \ Address offset: 0x259C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT692L_DEF
    \
    \ @brief Graphic MMU LUT entry 692 low
    \ Address offset: 0x25A0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT692H_DEF
    \
    \ @brief Graphic MMU LUT entry 692 high
    \ Address offset: 0x25A4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT693L_DEF
    \
    \ @brief Graphic MMU LUT entry 693 low
    \ Address offset: 0x25A8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT693H_DEF
    \
    \ @brief Graphic MMU LUT entry 693 high
    \ Address offset: 0x25AC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT694L_DEF
    \
    \ @brief Graphic MMU LUT entry 694 low
    \ Address offset: 0x25B0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT694H_DEF
    \
    \ @brief Graphic MMU LUT entry 694 high
    \ Address offset: 0x25B4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT695L_DEF
    \
    \ @brief Graphic MMU LUT entry 695 low
    \ Address offset: 0x25B8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT695H_DEF
    \
    \ @brief Graphic MMU LUT entry 695 high
    \ Address offset: 0x25BC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT696L_DEF
    \
    \ @brief Graphic MMU LUT entry 696 low
    \ Address offset: 0x25C0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT696H_DEF
    \
    \ @brief Graphic MMU LUT entry 696 high
    \ Address offset: 0x25C4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT697L_DEF
    \
    \ @brief Graphic MMU LUT entry 697 low
    \ Address offset: 0x25C8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT697H_DEF
    \
    \ @brief Graphic MMU LUT entry 697 high
    \ Address offset: 0x25CC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT698L_DEF
    \
    \ @brief Graphic MMU LUT entry 698 low
    \ Address offset: 0x25D0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT698H_DEF
    \
    \ @brief Graphic MMU LUT entry 698 high
    \ Address offset: 0x25D4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT699L_DEF
    \
    \ @brief Graphic MMU LUT entry 699 low
    \ Address offset: 0x25D8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT699H_DEF
    \
    \ @brief Graphic MMU LUT entry 699 high
    \ Address offset: 0x25DC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT700L_DEF
    \
    \ @brief Graphic MMU LUT entry 700 low
    \ Address offset: 0x25E0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT700H_DEF
    \
    \ @brief Graphic MMU LUT entry 700 high
    \ Address offset: 0x25E4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT701L_DEF
    \
    \ @brief Graphic MMU LUT entry 701 low
    \ Address offset: 0x25E8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT701H_DEF
    \
    \ @brief Graphic MMU LUT entry 701 high
    \ Address offset: 0x25EC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT702L_DEF
    \
    \ @brief Graphic MMU LUT entry 702 low
    \ Address offset: 0x25F0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT702H_DEF
    \
    \ @brief Graphic MMU LUT entry 702 high
    \ Address offset: 0x25F4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT703L_DEF
    \
    \ @brief Graphic MMU LUT entry 703 low
    \ Address offset: 0x25F8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT703H_DEF
    \
    \ @brief Graphic MMU LUT entry 703 high
    \ Address offset: 0x25FC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT704L_DEF
    \
    \ @brief Graphic MMU LUT entry 704 low
    \ Address offset: 0x2600
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT704H_DEF
    \
    \ @brief Graphic MMU LUT entry 704 high
    \ Address offset: 0x2604
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT705L_DEF
    \
    \ @brief Graphic MMU LUT entry 705 low
    \ Address offset: 0x2608
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT705H_DEF
    \
    \ @brief Graphic MMU LUT entry 705 high
    \ Address offset: 0x260C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT706L_DEF
    \
    \ @brief Graphic MMU LUT entry 706 low
    \ Address offset: 0x2610
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT706H_DEF
    \
    \ @brief Graphic MMU LUT entry 706 high
    \ Address offset: 0x2614
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT707L_DEF
    \
    \ @brief Graphic MMU LUT entry 707 low
    \ Address offset: 0x2618
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT707H_DEF
    \
    \ @brief Graphic MMU LUT entry 707 high
    \ Address offset: 0x261C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT708L_DEF
    \
    \ @brief Graphic MMU LUT entry 708 low
    \ Address offset: 0x2620
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT708H_DEF
    \
    \ @brief Graphic MMU LUT entry 708 high
    \ Address offset: 0x2624
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT709L_DEF
    \
    \ @brief Graphic MMU LUT entry 709 low
    \ Address offset: 0x2628
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT709H_DEF
    \
    \ @brief Graphic MMU LUT entry 709 high
    \ Address offset: 0x262C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT710L_DEF
    \
    \ @brief Graphic MMU LUT entry 710 low
    \ Address offset: 0x2630
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT710H_DEF
    \
    \ @brief Graphic MMU LUT entry 710 high
    \ Address offset: 0x2634
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT711L_DEF
    \
    \ @brief Graphic MMU LUT entry 711 low
    \ Address offset: 0x2638
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT711H_DEF
    \
    \ @brief Graphic MMU LUT entry 711 high
    \ Address offset: 0x263C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT712L_DEF
    \
    \ @brief Graphic MMU LUT entry 712 low
    \ Address offset: 0x2640
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT712H_DEF
    \
    \ @brief Graphic MMU LUT entry 712 high
    \ Address offset: 0x2644
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT713L_DEF
    \
    \ @brief Graphic MMU LUT entry 713 low
    \ Address offset: 0x2648
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT713H_DEF
    \
    \ @brief Graphic MMU LUT entry 713 high
    \ Address offset: 0x264C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT714L_DEF
    \
    \ @brief Graphic MMU LUT entry 714 low
    \ Address offset: 0x2650
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT714H_DEF
    \
    \ @brief Graphic MMU LUT entry 714 high
    \ Address offset: 0x2654
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT715L_DEF
    \
    \ @brief Graphic MMU LUT entry 715 low
    \ Address offset: 0x2658
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT715H_DEF
    \
    \ @brief Graphic MMU LUT entry 715 high
    \ Address offset: 0x265C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT716L_DEF
    \
    \ @brief Graphic MMU LUT entry 716 low
    \ Address offset: 0x2660
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT716H_DEF
    \
    \ @brief Graphic MMU LUT entry 716 high
    \ Address offset: 0x2664
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT717L_DEF
    \
    \ @brief Graphic MMU LUT entry 717 low
    \ Address offset: 0x2668
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT717H_DEF
    \
    \ @brief Graphic MMU LUT entry 717 high
    \ Address offset: 0x266C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT718L_DEF
    \
    \ @brief Graphic MMU LUT entry 718 low
    \ Address offset: 0x2670
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT718H_DEF
    \
    \ @brief Graphic MMU LUT entry 718 high
    \ Address offset: 0x2674
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT719L_DEF
    \
    \ @brief Graphic MMU LUT entry 719 low
    \ Address offset: 0x2678
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT719H_DEF
    \
    \ @brief Graphic MMU LUT entry 719 high
    \ Address offset: 0x267C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT720L_DEF
    \
    \ @brief Graphic MMU LUT entry 720 low
    \ Address offset: 0x2680
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT720H_DEF
    \
    \ @brief Graphic MMU LUT entry 720 high
    \ Address offset: 0x2684
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT721L_DEF
    \
    \ @brief Graphic MMU LUT entry 721 low
    \ Address offset: 0x2688
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT721H_DEF
    \
    \ @brief Graphic MMU LUT entry 721 high
    \ Address offset: 0x268C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT722L_DEF
    \
    \ @brief Graphic MMU LUT entry 722 low
    \ Address offset: 0x2690
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT722H_DEF
    \
    \ @brief Graphic MMU LUT entry 722 high
    \ Address offset: 0x2694
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT723L_DEF
    \
    \ @brief Graphic MMU LUT entry 723 low
    \ Address offset: 0x2698
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT723H_DEF
    \
    \ @brief Graphic MMU LUT entry 723 high
    \ Address offset: 0x269C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT724L_DEF
    \
    \ @brief Graphic MMU LUT entry 724 low
    \ Address offset: 0x26A0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT724H_DEF
    \
    \ @brief Graphic MMU LUT entry 724 high
    \ Address offset: 0x26A4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT725L_DEF
    \
    \ @brief Graphic MMU LUT entry 725 low
    \ Address offset: 0x26A8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT725H_DEF
    \
    \ @brief Graphic MMU LUT entry 725 high
    \ Address offset: 0x26AC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT726L_DEF
    \
    \ @brief Graphic MMU LUT entry 726 low
    \ Address offset: 0x26B0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT726H_DEF
    \
    \ @brief Graphic MMU LUT entry 726 high
    \ Address offset: 0x26B4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT727L_DEF
    \
    \ @brief Graphic MMU LUT entry 727 low
    \ Address offset: 0x26B8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT727H_DEF
    \
    \ @brief Graphic MMU LUT entry 727 high
    \ Address offset: 0x26BC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT728L_DEF
    \
    \ @brief Graphic MMU LUT entry 728 low
    \ Address offset: 0x26C0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT728H_DEF
    \
    \ @brief Graphic MMU LUT entry 728 high
    \ Address offset: 0x26C4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT729L_DEF
    \
    \ @brief Graphic MMU LUT entry 729 low
    \ Address offset: 0x26C8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT729H_DEF
    \
    \ @brief Graphic MMU LUT entry 729 high
    \ Address offset: 0x26CC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT730L_DEF
    \
    \ @brief Graphic MMU LUT entry 730 low
    \ Address offset: 0x26D0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT730H_DEF
    \
    \ @brief Graphic MMU LUT entry 730 high
    \ Address offset: 0x26D4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT731L_DEF
    \
    \ @brief Graphic MMU LUT entry 731 low
    \ Address offset: 0x26D8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT731H_DEF
    \
    \ @brief Graphic MMU LUT entry 731 high
    \ Address offset: 0x26DC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT732L_DEF
    \
    \ @brief Graphic MMU LUT entry 732 low
    \ Address offset: 0x26E0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT732H_DEF
    \
    \ @brief Graphic MMU LUT entry 732 high
    \ Address offset: 0x26E4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT733L_DEF
    \
    \ @brief Graphic MMU LUT entry 733 low
    \ Address offset: 0x26E8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT733H_DEF
    \
    \ @brief Graphic MMU LUT entry 733 high
    \ Address offset: 0x26EC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT734L_DEF
    \
    \ @brief Graphic MMU LUT entry 734 low
    \ Address offset: 0x26F0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT734H_DEF
    \
    \ @brief Graphic MMU LUT entry 734 high
    \ Address offset: 0x26F4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT735L_DEF
    \
    \ @brief Graphic MMU LUT entry 735 low
    \ Address offset: 0x26F8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT735H_DEF
    \
    \ @brief Graphic MMU LUT entry 735 high
    \ Address offset: 0x26FC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT736L_DEF
    \
    \ @brief Graphic MMU LUT entry 736 low
    \ Address offset: 0x2700
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT736H_DEF
    \
    \ @brief Graphic MMU LUT entry 736 high
    \ Address offset: 0x2704
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT737L_DEF
    \
    \ @brief Graphic MMU LUT entry 737 low
    \ Address offset: 0x2708
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT737H_DEF
    \
    \ @brief Graphic MMU LUT entry 737 high
    \ Address offset: 0x270C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT738L_DEF
    \
    \ @brief Graphic MMU LUT entry 738 low
    \ Address offset: 0x2710
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT738H_DEF
    \
    \ @brief Graphic MMU LUT entry 738 high
    \ Address offset: 0x2714
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT739L_DEF
    \
    \ @brief Graphic MMU LUT entry 739 low
    \ Address offset: 0x2718
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT739H_DEF
    \
    \ @brief Graphic MMU LUT entry 739 high
    \ Address offset: 0x271C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT740L_DEF
    \
    \ @brief Graphic MMU LUT entry 740 low
    \ Address offset: 0x2720
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT740H_DEF
    \
    \ @brief Graphic MMU LUT entry 740 high
    \ Address offset: 0x2724
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT741L_DEF
    \
    \ @brief Graphic MMU LUT entry 741 low
    \ Address offset: 0x2728
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT741H_DEF
    \
    \ @brief Graphic MMU LUT entry 741 high
    \ Address offset: 0x272C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT742L_DEF
    \
    \ @brief Graphic MMU LUT entry 742 low
    \ Address offset: 0x2730
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT742H_DEF
    \
    \ @brief Graphic MMU LUT entry 742 high
    \ Address offset: 0x2734
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT743L_DEF
    \
    \ @brief Graphic MMU LUT entry 743 low
    \ Address offset: 0x2738
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT743H_DEF
    \
    \ @brief Graphic MMU LUT entry 743 high
    \ Address offset: 0x273C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT744L_DEF
    \
    \ @brief Graphic MMU LUT entry 744 low
    \ Address offset: 0x2740
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT744H_DEF
    \
    \ @brief Graphic MMU LUT entry 744 high
    \ Address offset: 0x2744
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT745L_DEF
    \
    \ @brief Graphic MMU LUT entry 745 low
    \ Address offset: 0x2748
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT745H_DEF
    \
    \ @brief Graphic MMU LUT entry 745 high
    \ Address offset: 0x274C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT746L_DEF
    \
    \ @brief Graphic MMU LUT entry 746 low
    \ Address offset: 0x2750
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT746H_DEF
    \
    \ @brief Graphic MMU LUT entry 746 high
    \ Address offset: 0x2754
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT747L_DEF
    \
    \ @brief Graphic MMU LUT entry 747 low
    \ Address offset: 0x2758
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT747H_DEF
    \
    \ @brief Graphic MMU LUT entry 747 high
    \ Address offset: 0x275C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT748L_DEF
    \
    \ @brief Graphic MMU LUT entry 748 low
    \ Address offset: 0x2760
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT748H_DEF
    \
    \ @brief Graphic MMU LUT entry 748 high
    \ Address offset: 0x2764
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT749L_DEF
    \
    \ @brief Graphic MMU LUT entry 749 low
    \ Address offset: 0x2768
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT749H_DEF
    \
    \ @brief Graphic MMU LUT entry 749 high
    \ Address offset: 0x276C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT750L_DEF
    \
    \ @brief Graphic MMU LUT entry 750 low
    \ Address offset: 0x2770
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT750H_DEF
    \
    \ @brief Graphic MMU LUT entry 750 high
    \ Address offset: 0x2774
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT751L_DEF
    \
    \ @brief Graphic MMU LUT entry 751 low
    \ Address offset: 0x2778
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT751H_DEF
    \
    \ @brief Graphic MMU LUT entry 751 high
    \ Address offset: 0x277C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT752L_DEF
    \
    \ @brief Graphic MMU LUT entry 752 low
    \ Address offset: 0x2780
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT752H_DEF
    \
    \ @brief Graphic MMU LUT entry 752 high
    \ Address offset: 0x2784
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT753L_DEF
    \
    \ @brief Graphic MMU LUT entry 753 low
    \ Address offset: 0x2788
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT753H_DEF
    \
    \ @brief Graphic MMU LUT entry 753 high
    \ Address offset: 0x278C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT754L_DEF
    \
    \ @brief Graphic MMU LUT entry 754 low
    \ Address offset: 0x2790
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT754H_DEF
    \
    \ @brief Graphic MMU LUT entry 754 high
    \ Address offset: 0x2794
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT755L_DEF
    \
    \ @brief Graphic MMU LUT entry 755 low
    \ Address offset: 0x2798
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT755H_DEF
    \
    \ @brief Graphic MMU LUT entry 755 high
    \ Address offset: 0x279C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT756L_DEF
    \
    \ @brief Graphic MMU LUT entry 756 low
    \ Address offset: 0x27A0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT756H_DEF
    \
    \ @brief Graphic MMU LUT entry 756 high
    \ Address offset: 0x27A4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT757L_DEF
    \
    \ @brief Graphic MMU LUT entry 757 low
    \ Address offset: 0x27A8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT757H_DEF
    \
    \ @brief Graphic MMU LUT entry 757 high
    \ Address offset: 0x27AC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT758L_DEF
    \
    \ @brief Graphic MMU LUT entry 758 low
    \ Address offset: 0x27B0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT758H_DEF
    \
    \ @brief Graphic MMU LUT entry 758 high
    \ Address offset: 0x27B4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT759L_DEF
    \
    \ @brief Graphic MMU LUT entry 759 low
    \ Address offset: 0x27B8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT759H_DEF
    \
    \ @brief Graphic MMU LUT entry 759 high
    \ Address offset: 0x27BC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT760L_DEF
    \
    \ @brief Graphic MMU LUT entry 760 low
    \ Address offset: 0x27C0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT760H_DEF
    \
    \ @brief Graphic MMU LUT entry 760 high
    \ Address offset: 0x27C4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT761L_DEF
    \
    \ @brief Graphic MMU LUT entry 761 low
    \ Address offset: 0x27C8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT761H_DEF
    \
    \ @brief Graphic MMU LUT entry 761 high
    \ Address offset: 0x27CC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT762L_DEF
    \
    \ @brief Graphic MMU LUT entry 762 low
    \ Address offset: 0x27D0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT762H_DEF
    \
    \ @brief Graphic MMU LUT entry 762 high
    \ Address offset: 0x27D4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT763L_DEF
    \
    \ @brief Graphic MMU LUT entry 763 low
    \ Address offset: 0x27D8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT763H_DEF
    \
    \ @brief Graphic MMU LUT entry 763 high
    \ Address offset: 0x27DC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT764L_DEF
    \
    \ @brief Graphic MMU LUT entry 764 low
    \ Address offset: 0x27E0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT764H_DEF
    \
    \ @brief Graphic MMU LUT entry 764 high
    \ Address offset: 0x27E4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT765L_DEF
    \
    \ @brief Graphic MMU LUT entry 765 low
    \ Address offset: 0x27E8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT765H_DEF
    \
    \ @brief Graphic MMU LUT entry 765 high
    \ Address offset: 0x27EC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT766L_DEF
    \
    \ @brief Graphic MMU LUT entry 766 low
    \ Address offset: 0x27F0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT766H_DEF
    \
    \ @brief Graphic MMU LUT entry 766 high
    \ Address offset: 0x27F4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT767L_DEF
    \
    \ @brief Graphic MMU LUT entry 767 low
    \ Address offset: 0x27F8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT767H_DEF
    \
    \ @brief Graphic MMU LUT entry 767 high
    \ Address offset: 0x27FC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT768L_DEF
    \
    \ @brief Graphic MMU LUT entry 768 low
    \ Address offset: 0x2800
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT768H_DEF
    \
    \ @brief Graphic MMU LUT entry 768 high
    \ Address offset: 0x2804
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT769L_DEF
    \
    \ @brief Graphic MMU LUT entry 769 low
    \ Address offset: 0x2808
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT769H_DEF
    \
    \ @brief Graphic MMU LUT entry 769 high
    \ Address offset: 0x280C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT770L_DEF
    \
    \ @brief Graphic MMU LUT entry 770 low
    \ Address offset: 0x2810
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT770H_DEF
    \
    \ @brief Graphic MMU LUT entry 770 high
    \ Address offset: 0x2814
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT771L_DEF
    \
    \ @brief Graphic MMU LUT entry 771 low
    \ Address offset: 0x2818
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT771H_DEF
    \
    \ @brief Graphic MMU LUT entry 771 high
    \ Address offset: 0x281C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT772L_DEF
    \
    \ @brief Graphic MMU LUT entry 772 low
    \ Address offset: 0x2820
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT772H_DEF
    \
    \ @brief Graphic MMU LUT entry 772 high
    \ Address offset: 0x2824
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT773L_DEF
    \
    \ @brief Graphic MMU LUT entry 773 low
    \ Address offset: 0x2828
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT773H_DEF
    \
    \ @brief Graphic MMU LUT entry 773 high
    \ Address offset: 0x282C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT774L_DEF
    \
    \ @brief Graphic MMU LUT entry 774 low
    \ Address offset: 0x2830
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT774H_DEF
    \
    \ @brief Graphic MMU LUT entry 774 high
    \ Address offset: 0x2834
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT775L_DEF
    \
    \ @brief Graphic MMU LUT entry 775 low
    \ Address offset: 0x2838
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT775H_DEF
    \
    \ @brief Graphic MMU LUT entry 775 high
    \ Address offset: 0x283C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT776L_DEF
    \
    \ @brief Graphic MMU LUT entry 776 low
    \ Address offset: 0x2840
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT776H_DEF
    \
    \ @brief Graphic MMU LUT entry 776 high
    \ Address offset: 0x2844
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT777L_DEF
    \
    \ @brief Graphic MMU LUT entry 777 low
    \ Address offset: 0x2848
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT777H_DEF
    \
    \ @brief Graphic MMU LUT entry 777 high
    \ Address offset: 0x284C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT778L_DEF
    \
    \ @brief Graphic MMU LUT entry 778 low
    \ Address offset: 0x2850
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT778H_DEF
    \
    \ @brief Graphic MMU LUT entry 778 high
    \ Address offset: 0x2854
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT779L_DEF
    \
    \ @brief Graphic MMU LUT entry 779 low
    \ Address offset: 0x2858
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT779H_DEF
    \
    \ @brief Graphic MMU LUT entry 779 high
    \ Address offset: 0x285C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT780L_DEF
    \
    \ @brief Graphic MMU LUT entry 780 low
    \ Address offset: 0x2860
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT780H_DEF
    \
    \ @brief Graphic MMU LUT entry 780 high
    \ Address offset: 0x2864
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT781L_DEF
    \
    \ @brief Graphic MMU LUT entry 781 low
    \ Address offset: 0x2868
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT781H_DEF
    \
    \ @brief Graphic MMU LUT entry 781 high
    \ Address offset: 0x286C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT782L_DEF
    \
    \ @brief Graphic MMU LUT entry 782 low
    \ Address offset: 0x2870
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT782H_DEF
    \
    \ @brief Graphic MMU LUT entry 782 high
    \ Address offset: 0x2874
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT783L_DEF
    \
    \ @brief Graphic MMU LUT entry 783 low
    \ Address offset: 0x2878
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT783H_DEF
    \
    \ @brief Graphic MMU LUT entry 783 high
    \ Address offset: 0x287C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT784L_DEF
    \
    \ @brief Graphic MMU LUT entry 784 low
    \ Address offset: 0x2880
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT784H_DEF
    \
    \ @brief Graphic MMU LUT entry 784 high
    \ Address offset: 0x2884
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT785L_DEF
    \
    \ @brief Graphic MMU LUT entry 785 low
    \ Address offset: 0x2888
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT785H_DEF
    \
    \ @brief Graphic MMU LUT entry 785 high
    \ Address offset: 0x288C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT786L_DEF
    \
    \ @brief Graphic MMU LUT entry 786 low
    \ Address offset: 0x2890
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT786H_DEF
    \
    \ @brief Graphic MMU LUT entry 786 high
    \ Address offset: 0x2894
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT787L_DEF
    \
    \ @brief Graphic MMU LUT entry 787 low
    \ Address offset: 0x2898
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT787H_DEF
    \
    \ @brief Graphic MMU LUT entry 787 high
    \ Address offset: 0x289C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT788L_DEF
    \
    \ @brief Graphic MMU LUT entry 788 low
    \ Address offset: 0x28A0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT788H_DEF
    \
    \ @brief Graphic MMU LUT entry 788 high
    \ Address offset: 0x28A4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT789L_DEF
    \
    \ @brief Graphic MMU LUT entry 789 low
    \ Address offset: 0x28A8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT789H_DEF
    \
    \ @brief Graphic MMU LUT entry 789 high
    \ Address offset: 0x28AC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT790L_DEF
    \
    \ @brief Graphic MMU LUT entry 790 low
    \ Address offset: 0x28B0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT790H_DEF
    \
    \ @brief Graphic MMU LUT entry 790 high
    \ Address offset: 0x28B4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT791L_DEF
    \
    \ @brief Graphic MMU LUT entry 791 low
    \ Address offset: 0x28B8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT791H_DEF
    \
    \ @brief Graphic MMU LUT entry 791 high
    \ Address offset: 0x28BC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT792L_DEF
    \
    \ @brief Graphic MMU LUT entry 792 low
    \ Address offset: 0x28C0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT792H_DEF
    \
    \ @brief Graphic MMU LUT entry 792 high
    \ Address offset: 0x28C4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT793L_DEF
    \
    \ @brief Graphic MMU LUT entry 793 low
    \ Address offset: 0x28C8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT793H_DEF
    \
    \ @brief Graphic MMU LUT entry 793 high
    \ Address offset: 0x28CC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT794L_DEF
    \
    \ @brief Graphic MMU LUT entry 794 low
    \ Address offset: 0x28D0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT794H_DEF
    \
    \ @brief Graphic MMU LUT entry 794 high
    \ Address offset: 0x28D4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT795L_DEF
    \
    \ @brief Graphic MMU LUT entry 795 low
    \ Address offset: 0x28D8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT795H_DEF
    \
    \ @brief Graphic MMU LUT entry 795 high
    \ Address offset: 0x28DC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT796L_DEF
    \
    \ @brief Graphic MMU LUT entry 796 low
    \ Address offset: 0x28E0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT796H_DEF
    \
    \ @brief Graphic MMU LUT entry 796 high
    \ Address offset: 0x28E4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT797L_DEF
    \
    \ @brief Graphic MMU LUT entry 797 low
    \ Address offset: 0x28E8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT797H_DEF
    \
    \ @brief Graphic MMU LUT entry 797 high
    \ Address offset: 0x28EC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT798L_DEF
    \
    \ @brief Graphic MMU LUT entry 798 low
    \ Address offset: 0x28F0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT798H_DEF
    \
    \ @brief Graphic MMU LUT entry 798 high
    \ Address offset: 0x28F4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT799L_DEF
    \
    \ @brief Graphic MMU LUT entry 799 low
    \ Address offset: 0x28F8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT799H_DEF
    \
    \ @brief Graphic MMU LUT entry 799 high
    \ Address offset: 0x28FC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT800L_DEF
    \
    \ @brief Graphic MMU LUT entry 800 low
    \ Address offset: 0x2900
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT800H_DEF
    \
    \ @brief Graphic MMU LUT entry 800 high
    \ Address offset: 0x2904
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT801L_DEF
    \
    \ @brief Graphic MMU LUT entry 801 low
    \ Address offset: 0x2908
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT801H_DEF
    \
    \ @brief Graphic MMU LUT entry 801 high
    \ Address offset: 0x290C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT802L_DEF
    \
    \ @brief Graphic MMU LUT entry 802 low
    \ Address offset: 0x2910
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT802H_DEF
    \
    \ @brief Graphic MMU LUT entry 802 high
    \ Address offset: 0x2914
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT803L_DEF
    \
    \ @brief Graphic MMU LUT entry 803 low
    \ Address offset: 0x2918
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT803H_DEF
    \
    \ @brief Graphic MMU LUT entry 803 high
    \ Address offset: 0x291C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT804L_DEF
    \
    \ @brief Graphic MMU LUT entry 804 low
    \ Address offset: 0x2920
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT804H_DEF
    \
    \ @brief Graphic MMU LUT entry 804 high
    \ Address offset: 0x2924
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT805L_DEF
    \
    \ @brief Graphic MMU LUT entry 805 low
    \ Address offset: 0x2928
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT805H_DEF
    \
    \ @brief Graphic MMU LUT entry 805 high
    \ Address offset: 0x292C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT806L_DEF
    \
    \ @brief Graphic MMU LUT entry 806 low
    \ Address offset: 0x2930
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT806H_DEF
    \
    \ @brief Graphic MMU LUT entry 806 high
    \ Address offset: 0x2934
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT807L_DEF
    \
    \ @brief Graphic MMU LUT entry 807 low
    \ Address offset: 0x2938
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT807H_DEF
    \
    \ @brief Graphic MMU LUT entry 807 high
    \ Address offset: 0x293C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT808L_DEF
    \
    \ @brief Graphic MMU LUT entry 808 low
    \ Address offset: 0x2940
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT808H_DEF
    \
    \ @brief Graphic MMU LUT entry 808 high
    \ Address offset: 0x2944
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT809L_DEF
    \
    \ @brief Graphic MMU LUT entry 809 low
    \ Address offset: 0x2948
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT809H_DEF
    \
    \ @brief Graphic MMU LUT entry 809 high
    \ Address offset: 0x294C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT810L_DEF
    \
    \ @brief Graphic MMU LUT entry 810 low
    \ Address offset: 0x2950
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT810H_DEF
    \
    \ @brief Graphic MMU LUT entry 810 high
    \ Address offset: 0x2954
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT811L_DEF
    \
    \ @brief Graphic MMU LUT entry 811 low
    \ Address offset: 0x2958
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT811H_DEF
    \
    \ @brief Graphic MMU LUT entry 811 high
    \ Address offset: 0x295C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT812L_DEF
    \
    \ @brief Graphic MMU LUT entry 812 low
    \ Address offset: 0x2960
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT812H_DEF
    \
    \ @brief Graphic MMU LUT entry 812 high
    \ Address offset: 0x2964
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT813L_DEF
    \
    \ @brief Graphic MMU LUT entry 813 low
    \ Address offset: 0x2968
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT813H_DEF
    \
    \ @brief Graphic MMU LUT entry 813 high
    \ Address offset: 0x296C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT814L_DEF
    \
    \ @brief Graphic MMU LUT entry 814 low
    \ Address offset: 0x2970
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT814H_DEF
    \
    \ @brief Graphic MMU LUT entry 814 high
    \ Address offset: 0x2974
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT815L_DEF
    \
    \ @brief Graphic MMU LUT entry 815 low
    \ Address offset: 0x2978
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT815H_DEF
    \
    \ @brief Graphic MMU LUT entry 815 high
    \ Address offset: 0x297C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT816L_DEF
    \
    \ @brief Graphic MMU LUT entry 816 low
    \ Address offset: 0x2980
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT816H_DEF
    \
    \ @brief Graphic MMU LUT entry 816 high
    \ Address offset: 0x2984
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT817L_DEF
    \
    \ @brief Graphic MMU LUT entry 817 low
    \ Address offset: 0x2988
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT817H_DEF
    \
    \ @brief Graphic MMU LUT entry 817 high
    \ Address offset: 0x298C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT818L_DEF
    \
    \ @brief Graphic MMU LUT entry 818 low
    \ Address offset: 0x2990
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT818H_DEF
    \
    \ @brief Graphic MMU LUT entry 818 high
    \ Address offset: 0x2994
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT819L_DEF
    \
    \ @brief Graphic MMU LUT entry 819 low
    \ Address offset: 0x2998
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT819H_DEF
    \
    \ @brief Graphic MMU LUT entry 819 high
    \ Address offset: 0x299C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT820L_DEF
    \
    \ @brief Graphic MMU LUT entry 820 low
    \ Address offset: 0x29A0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT820H_DEF
    \
    \ @brief Graphic MMU LUT entry 820 high
    \ Address offset: 0x29A4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT821L_DEF
    \
    \ @brief Graphic MMU LUT entry 821 low
    \ Address offset: 0x29A8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT821H_DEF
    \
    \ @brief Graphic MMU LUT entry 821 high
    \ Address offset: 0x29AC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT822L_DEF
    \
    \ @brief Graphic MMU LUT entry 822 low
    \ Address offset: 0x29B0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT822H_DEF
    \
    \ @brief Graphic MMU LUT entry 822 high
    \ Address offset: 0x29B4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT823L_DEF
    \
    \ @brief Graphic MMU LUT entry 823 low
    \ Address offset: 0x29B8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT823H_DEF
    \
    \ @brief Graphic MMU LUT entry 823 high
    \ Address offset: 0x29BC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT824L_DEF
    \
    \ @brief Graphic MMU LUT entry 824 low
    \ Address offset: 0x29C0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT824H_DEF
    \
    \ @brief Graphic MMU LUT entry 824 high
    \ Address offset: 0x29C4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT825L_DEF
    \
    \ @brief Graphic MMU LUT entry 825 low
    \ Address offset: 0x29C8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT825H_DEF
    \
    \ @brief Graphic MMU LUT entry 825 high
    \ Address offset: 0x29CC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT826L_DEF
    \
    \ @brief Graphic MMU LUT entry 826 low
    \ Address offset: 0x29D0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT826H_DEF
    \
    \ @brief Graphic MMU LUT entry 826 high
    \ Address offset: 0x29D4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT827L_DEF
    \
    \ @brief Graphic MMU LUT entry 827 low
    \ Address offset: 0x29D8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT827H_DEF
    \
    \ @brief Graphic MMU LUT entry 827 high
    \ Address offset: 0x29DC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT828L_DEF
    \
    \ @brief Graphic MMU LUT entry 828 low
    \ Address offset: 0x29E0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT828H_DEF
    \
    \ @brief Graphic MMU LUT entry 828 high
    \ Address offset: 0x29E4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT829L_DEF
    \
    \ @brief Graphic MMU LUT entry 829 low
    \ Address offset: 0x29E8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT829H_DEF
    \
    \ @brief Graphic MMU LUT entry 829 high
    \ Address offset: 0x29EC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT830L_DEF
    \
    \ @brief Graphic MMU LUT entry 830 low
    \ Address offset: 0x29F0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT830H_DEF
    \
    \ @brief Graphic MMU LUT entry 830 high
    \ Address offset: 0x29F4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT831L_DEF
    \
    \ @brief Graphic MMU LUT entry 831 low
    \ Address offset: 0x29F8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT831H_DEF
    \
    \ @brief Graphic MMU LUT entry 831 high
    \ Address offset: 0x29FC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT832L_DEF
    \
    \ @brief Graphic MMU LUT entry 832 low
    \ Address offset: 0x2A00
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT832H_DEF
    \
    \ @brief Graphic MMU LUT entry 832 high
    \ Address offset: 0x2A04
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT833L_DEF
    \
    \ @brief Graphic MMU LUT entry 833 low
    \ Address offset: 0x2A08
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT833H_DEF
    \
    \ @brief Graphic MMU LUT entry 833 high
    \ Address offset: 0x2A0C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT834L_DEF
    \
    \ @brief Graphic MMU LUT entry 834 low
    \ Address offset: 0x2A10
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT834H_DEF
    \
    \ @brief Graphic MMU LUT entry 834 high
    \ Address offset: 0x2A14
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT835L_DEF
    \
    \ @brief Graphic MMU LUT entry 835 low
    \ Address offset: 0x2A18
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT835H_DEF
    \
    \ @brief Graphic MMU LUT entry 835 high
    \ Address offset: 0x2A1C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT836L_DEF
    \
    \ @brief Graphic MMU LUT entry 836 low
    \ Address offset: 0x2A20
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT836H_DEF
    \
    \ @brief Graphic MMU LUT entry 836 high
    \ Address offset: 0x2A24
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT837L_DEF
    \
    \ @brief Graphic MMU LUT entry 837 low
    \ Address offset: 0x2A28
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT837H_DEF
    \
    \ @brief Graphic MMU LUT entry 837 high
    \ Address offset: 0x2A2C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT838L_DEF
    \
    \ @brief Graphic MMU LUT entry 838 low
    \ Address offset: 0x2A30
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT838H_DEF
    \
    \ @brief Graphic MMU LUT entry 838 high
    \ Address offset: 0x2A34
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT839L_DEF
    \
    \ @brief Graphic MMU LUT entry 839 low
    \ Address offset: 0x2A38
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT839H_DEF
    \
    \ @brief Graphic MMU LUT entry 839 high
    \ Address offset: 0x2A3C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT840L_DEF
    \
    \ @brief Graphic MMU LUT entry 840 low
    \ Address offset: 0x2A40
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT840H_DEF
    \
    \ @brief Graphic MMU LUT entry 840 high
    \ Address offset: 0x2A44
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT841L_DEF
    \
    \ @brief Graphic MMU LUT entry 841 low
    \ Address offset: 0x2A48
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT841H_DEF
    \
    \ @brief Graphic MMU LUT entry 841 high
    \ Address offset: 0x2A4C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT842L_DEF
    \
    \ @brief Graphic MMU LUT entry 842 low
    \ Address offset: 0x2A50
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT842H_DEF
    \
    \ @brief Graphic MMU LUT entry 842 high
    \ Address offset: 0x2A54
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT843L_DEF
    \
    \ @brief Graphic MMU LUT entry 843 low
    \ Address offset: 0x2A58
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT843H_DEF
    \
    \ @brief Graphic MMU LUT entry 843 high
    \ Address offset: 0x2A5C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT844L_DEF
    \
    \ @brief Graphic MMU LUT entry 844 low
    \ Address offset: 0x2A60
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT844H_DEF
    \
    \ @brief Graphic MMU LUT entry 844 high
    \ Address offset: 0x2A64
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT845L_DEF
    \
    \ @brief Graphic MMU LUT entry 845 low
    \ Address offset: 0x2A68
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT845H_DEF
    \
    \ @brief Graphic MMU LUT entry 845 high
    \ Address offset: 0x2A6C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT846L_DEF
    \
    \ @brief Graphic MMU LUT entry 846 low
    \ Address offset: 0x2A70
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT846H_DEF
    \
    \ @brief Graphic MMU LUT entry 846 high
    \ Address offset: 0x2A74
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT847L_DEF
    \
    \ @brief Graphic MMU LUT entry 847 low
    \ Address offset: 0x2A78
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT847H_DEF
    \
    \ @brief Graphic MMU LUT entry 847 high
    \ Address offset: 0x2A7C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT848L_DEF
    \
    \ @brief Graphic MMU LUT entry 848 low
    \ Address offset: 0x2A80
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT848H_DEF
    \
    \ @brief Graphic MMU LUT entry 848 high
    \ Address offset: 0x2A84
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT849L_DEF
    \
    \ @brief Graphic MMU LUT entry 849 low
    \ Address offset: 0x2A88
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT849H_DEF
    \
    \ @brief Graphic MMU LUT entry 849 high
    \ Address offset: 0x2A8C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT850L_DEF
    \
    \ @brief Graphic MMU LUT entry 850 low
    \ Address offset: 0x2A90
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT850H_DEF
    \
    \ @brief Graphic MMU LUT entry 850 high
    \ Address offset: 0x2A94
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT851L_DEF
    \
    \ @brief Graphic MMU LUT entry 851 low
    \ Address offset: 0x2A98
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT851H_DEF
    \
    \ @brief Graphic MMU LUT entry 851 high
    \ Address offset: 0x2A9C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT852L_DEF
    \
    \ @brief Graphic MMU LUT entry 852 low
    \ Address offset: 0x2AA0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT852H_DEF
    \
    \ @brief Graphic MMU LUT entry 852 high
    \ Address offset: 0x2AA4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT853L_DEF
    \
    \ @brief Graphic MMU LUT entry 853 low
    \ Address offset: 0x2AA8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT853H_DEF
    \
    \ @brief Graphic MMU LUT entry 853 high
    \ Address offset: 0x2AAC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT854L_DEF
    \
    \ @brief Graphic MMU LUT entry 854 low
    \ Address offset: 0x2AB0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT854H_DEF
    \
    \ @brief Graphic MMU LUT entry 854 high
    \ Address offset: 0x2AB4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT855L_DEF
    \
    \ @brief Graphic MMU LUT entry 855 low
    \ Address offset: 0x2AB8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT855H_DEF
    \
    \ @brief Graphic MMU LUT entry 855 high
    \ Address offset: 0x2ABC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT856L_DEF
    \
    \ @brief Graphic MMU LUT entry 856 low
    \ Address offset: 0x2AC0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT856H_DEF
    \
    \ @brief Graphic MMU LUT entry 856 high
    \ Address offset: 0x2AC4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT857L_DEF
    \
    \ @brief Graphic MMU LUT entry 857 low
    \ Address offset: 0x2AC8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT857H_DEF
    \
    \ @brief Graphic MMU LUT entry 857 high
    \ Address offset: 0x2ACC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT858L_DEF
    \
    \ @brief Graphic MMU LUT entry 858 low
    \ Address offset: 0x2AD0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT858H_DEF
    \
    \ @brief Graphic MMU LUT entry 858 high
    \ Address offset: 0x2AD4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT859L_DEF
    \
    \ @brief Graphic MMU LUT entry 859 low
    \ Address offset: 0x2AD8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT859H_DEF
    \
    \ @brief Graphic MMU LUT entry 859 high
    \ Address offset: 0x2ADC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT860L_DEF
    \
    \ @brief Graphic MMU LUT entry 860 low
    \ Address offset: 0x2AE0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT860H_DEF
    \
    \ @brief Graphic MMU LUT entry 860 high
    \ Address offset: 0x2AE4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT861L_DEF
    \
    \ @brief Graphic MMU LUT entry 861 low
    \ Address offset: 0x2AE8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT861H_DEF
    \
    \ @brief Graphic MMU LUT entry 861 high
    \ Address offset: 0x2AEC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT862L_DEF
    \
    \ @brief Graphic MMU LUT entry 862 low
    \ Address offset: 0x2AF0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT862H_DEF
    \
    \ @brief Graphic MMU LUT entry 862 high
    \ Address offset: 0x2AF4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT863L_DEF
    \
    \ @brief Graphic MMU LUT entry 863 low
    \ Address offset: 0x2AF8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT863H_DEF
    \
    \ @brief Graphic MMU LUT entry 863 high
    \ Address offset: 0x2AFC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT864L_DEF
    \
    \ @brief Graphic MMU LUT entry 864 low
    \ Address offset: 0x2B00
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT864H_DEF
    \
    \ @brief Graphic MMU LUT entry 864 high
    \ Address offset: 0x2B04
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT865L_DEF
    \
    \ @brief Graphic MMU LUT entry 865 low
    \ Address offset: 0x2B08
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT865H_DEF
    \
    \ @brief Graphic MMU LUT entry 865 high
    \ Address offset: 0x2B0C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT866L_DEF
    \
    \ @brief Graphic MMU LUT entry 866 low
    \ Address offset: 0x2B10
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT866H_DEF
    \
    \ @brief Graphic MMU LUT entry 866 high
    \ Address offset: 0x2B14
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT867L_DEF
    \
    \ @brief Graphic MMU LUT entry 867 low
    \ Address offset: 0x2B18
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT867H_DEF
    \
    \ @brief Graphic MMU LUT entry 867 high
    \ Address offset: 0x2B1C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT868L_DEF
    \
    \ @brief Graphic MMU LUT entry 868 low
    \ Address offset: 0x2B20
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT868H_DEF
    \
    \ @brief Graphic MMU LUT entry 868 high
    \ Address offset: 0x2B24
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT869L_DEF
    \
    \ @brief Graphic MMU LUT entry 869 low
    \ Address offset: 0x2B28
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT869H_DEF
    \
    \ @brief Graphic MMU LUT entry 869 high
    \ Address offset: 0x2B2C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT870L_DEF
    \
    \ @brief Graphic MMU LUT entry 870 low
    \ Address offset: 0x2B30
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT870H_DEF
    \
    \ @brief Graphic MMU LUT entry 870 high
    \ Address offset: 0x2B34
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT871L_DEF
    \
    \ @brief Graphic MMU LUT entry 871 low
    \ Address offset: 0x2B38
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT871H_DEF
    \
    \ @brief Graphic MMU LUT entry 871 high
    \ Address offset: 0x2B3C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT872L_DEF
    \
    \ @brief Graphic MMU LUT entry 872 low
    \ Address offset: 0x2B40
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT872H_DEF
    \
    \ @brief Graphic MMU LUT entry 872 high
    \ Address offset: 0x2B44
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT873L_DEF
    \
    \ @brief Graphic MMU LUT entry 873 low
    \ Address offset: 0x2B48
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT873H_DEF
    \
    \ @brief Graphic MMU LUT entry 873 high
    \ Address offset: 0x2B4C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT874L_DEF
    \
    \ @brief Graphic MMU LUT entry 874 low
    \ Address offset: 0x2B50
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT874H_DEF
    \
    \ @brief Graphic MMU LUT entry 874 high
    \ Address offset: 0x2B54
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT875L_DEF
    \
    \ @brief Graphic MMU LUT entry 875 low
    \ Address offset: 0x2B58
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT875H_DEF
    \
    \ @brief Graphic MMU LUT entry 875 high
    \ Address offset: 0x2B5C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT876L_DEF
    \
    \ @brief Graphic MMU LUT entry 876 low
    \ Address offset: 0x2B60
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT876H_DEF
    \
    \ @brief Graphic MMU LUT entry 876 high
    \ Address offset: 0x2B64
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT877L_DEF
    \
    \ @brief Graphic MMU LUT entry 877 low
    \ Address offset: 0x2B68
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT877H_DEF
    \
    \ @brief Graphic MMU LUT entry 877 high
    \ Address offset: 0x2B6C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT878L_DEF
    \
    \ @brief Graphic MMU LUT entry 878 low
    \ Address offset: 0x2B70
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT878H_DEF
    \
    \ @brief Graphic MMU LUT entry 878 high
    \ Address offset: 0x2B74
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT879L_DEF
    \
    \ @brief Graphic MMU LUT entry 879 low
    \ Address offset: 0x2B78
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT879H_DEF
    \
    \ @brief Graphic MMU LUT entry 879 high
    \ Address offset: 0x2B7C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT880L_DEF
    \
    \ @brief Graphic MMU LUT entry 880 low
    \ Address offset: 0x2B80
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT880H_DEF
    \
    \ @brief Graphic MMU LUT entry 880 high
    \ Address offset: 0x2B84
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT881L_DEF
    \
    \ @brief Graphic MMU LUT entry 881 low
    \ Address offset: 0x2B88
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT881H_DEF
    \
    \ @brief Graphic MMU LUT entry 881 high
    \ Address offset: 0x2B8C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT882L_DEF
    \
    \ @brief Graphic MMU LUT entry 882 low
    \ Address offset: 0x2B90
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT882H_DEF
    \
    \ @brief Graphic MMU LUT entry 882 high
    \ Address offset: 0x2B94
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT883L_DEF
    \
    \ @brief Graphic MMU LUT entry 883 low
    \ Address offset: 0x2B98
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT883H_DEF
    \
    \ @brief Graphic MMU LUT entry 883 high
    \ Address offset: 0x2B9C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT884L_DEF
    \
    \ @brief Graphic MMU LUT entry 884 low
    \ Address offset: 0x2BA0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT884H_DEF
    \
    \ @brief Graphic MMU LUT entry 884 high
    \ Address offset: 0x2BA4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT885L_DEF
    \
    \ @brief Graphic MMU LUT entry 885 low
    \ Address offset: 0x2BA8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT885H_DEF
    \
    \ @brief Graphic MMU LUT entry 885 high
    \ Address offset: 0x2BAC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT886L_DEF
    \
    \ @brief Graphic MMU LUT entry 886 low
    \ Address offset: 0x2BB0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT886H_DEF
    \
    \ @brief Graphic MMU LUT entry 886 high
    \ Address offset: 0x2BB4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT887L_DEF
    \
    \ @brief Graphic MMU LUT entry 887 low
    \ Address offset: 0x2BB8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT887H_DEF
    \
    \ @brief Graphic MMU LUT entry 887 high
    \ Address offset: 0x2BBC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT888L_DEF
    \
    \ @brief Graphic MMU LUT entry 888 low
    \ Address offset: 0x2BC0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT888H_DEF
    \
    \ @brief Graphic MMU LUT entry 888 high
    \ Address offset: 0x2BC4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT889L_DEF
    \
    \ @brief Graphic MMU LUT entry 889 low
    \ Address offset: 0x2BC8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT889H_DEF
    \
    \ @brief Graphic MMU LUT entry 889 high
    \ Address offset: 0x2BCC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT890L_DEF
    \
    \ @brief Graphic MMU LUT entry 890 low
    \ Address offset: 0x2BD0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT890H_DEF
    \
    \ @brief Graphic MMU LUT entry 890 high
    \ Address offset: 0x2BD4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT891L_DEF
    \
    \ @brief Graphic MMU LUT entry 891 low
    \ Address offset: 0x2BD8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT891H_DEF
    \
    \ @brief Graphic MMU LUT entry 891 high
    \ Address offset: 0x2BDC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT892L_DEF
    \
    \ @brief Graphic MMU LUT entry 892 low
    \ Address offset: 0x2BE0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT892H_DEF
    \
    \ @brief Graphic MMU LUT entry 892 high
    \ Address offset: 0x2BE4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT893L_DEF
    \
    \ @brief Graphic MMU LUT entry 893 low
    \ Address offset: 0x2BE8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT893H_DEF
    \
    \ @brief Graphic MMU LUT entry 893 high
    \ Address offset: 0x2BEC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT894L_DEF
    \
    \ @brief Graphic MMU LUT entry 894 low
    \ Address offset: 0x2BF0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT894H_DEF
    \
    \ @brief Graphic MMU LUT entry 894 high
    \ Address offset: 0x2BF4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT895L_DEF
    \
    \ @brief Graphic MMU LUT entry 895 low
    \ Address offset: 0x2BF8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT895H_DEF
    \
    \ @brief Graphic MMU LUT entry 895 high
    \ Address offset: 0x2BFC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT896L_DEF
    \
    \ @brief Graphic MMU LUT entry 896 low
    \ Address offset: 0x2C00
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT896H_DEF
    \
    \ @brief Graphic MMU LUT entry 896 high
    \ Address offset: 0x2C04
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT897L_DEF
    \
    \ @brief Graphic MMU LUT entry 897 low
    \ Address offset: 0x2C08
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT897H_DEF
    \
    \ @brief Graphic MMU LUT entry 897 high
    \ Address offset: 0x2C0C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT898L_DEF
    \
    \ @brief Graphic MMU LUT entry 898 low
    \ Address offset: 0x2C10
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT898H_DEF
    \
    \ @brief Graphic MMU LUT entry 898 high
    \ Address offset: 0x2C14
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT899L_DEF
    \
    \ @brief Graphic MMU LUT entry 899 low
    \ Address offset: 0x2C18
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT899H_DEF
    \
    \ @brief Graphic MMU LUT entry 899 high
    \ Address offset: 0x2C1C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT900L_DEF
    \
    \ @brief Graphic MMU LUT entry 900 low
    \ Address offset: 0x2C20
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT900H_DEF
    \
    \ @brief Graphic MMU LUT entry 900 high
    \ Address offset: 0x2C24
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT901L_DEF
    \
    \ @brief Graphic MMU LUT entry 901 low
    \ Address offset: 0x2C28
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT901H_DEF
    \
    \ @brief Graphic MMU LUT entry 901 high
    \ Address offset: 0x2C2C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT902L_DEF
    \
    \ @brief Graphic MMU LUT entry 902 low
    \ Address offset: 0x2C30
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT902H_DEF
    \
    \ @brief Graphic MMU LUT entry 902 high
    \ Address offset: 0x2C34
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT903L_DEF
    \
    \ @brief Graphic MMU LUT entry 903 low
    \ Address offset: 0x2C38
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT903H_DEF
    \
    \ @brief Graphic MMU LUT entry 903 high
    \ Address offset: 0x2C3C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT904L_DEF
    \
    \ @brief Graphic MMU LUT entry 904 low
    \ Address offset: 0x2C40
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT904H_DEF
    \
    \ @brief Graphic MMU LUT entry 904 high
    \ Address offset: 0x2C44
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT905L_DEF
    \
    \ @brief Graphic MMU LUT entry 905 low
    \ Address offset: 0x2C48
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT905H_DEF
    \
    \ @brief Graphic MMU LUT entry 905 high
    \ Address offset: 0x2C4C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT906L_DEF
    \
    \ @brief Graphic MMU LUT entry 906 low
    \ Address offset: 0x2C50
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT906H_DEF
    \
    \ @brief Graphic MMU LUT entry 906 high
    \ Address offset: 0x2C54
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT907L_DEF
    \
    \ @brief Graphic MMU LUT entry 907 low
    \ Address offset: 0x2C58
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT907H_DEF
    \
    \ @brief Graphic MMU LUT entry 907 high
    \ Address offset: 0x2C5C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT908L_DEF
    \
    \ @brief Graphic MMU LUT entry 908 low
    \ Address offset: 0x2C60
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT908H_DEF
    \
    \ @brief Graphic MMU LUT entry 908 high
    \ Address offset: 0x2C64
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT909L_DEF
    \
    \ @brief Graphic MMU LUT entry 909 low
    \ Address offset: 0x2C68
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT909H_DEF
    \
    \ @brief Graphic MMU LUT entry 909 high
    \ Address offset: 0x2C6C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT910L_DEF
    \
    \ @brief Graphic MMU LUT entry 910 low
    \ Address offset: 0x2C70
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT910H_DEF
    \
    \ @brief Graphic MMU LUT entry 910 high
    \ Address offset: 0x2C74
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT911L_DEF
    \
    \ @brief Graphic MMU LUT entry 911 low
    \ Address offset: 0x2C78
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT911H_DEF
    \
    \ @brief Graphic MMU LUT entry 911 high
    \ Address offset: 0x2C7C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT912L_DEF
    \
    \ @brief Graphic MMU LUT entry 912 low
    \ Address offset: 0x2C80
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT912H_DEF
    \
    \ @brief Graphic MMU LUT entry 912 high
    \ Address offset: 0x2C84
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT913L_DEF
    \
    \ @brief Graphic MMU LUT entry 913 low
    \ Address offset: 0x2C88
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT913H_DEF
    \
    \ @brief Graphic MMU LUT entry 913 high
    \ Address offset: 0x2C8C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT914L_DEF
    \
    \ @brief Graphic MMU LUT entry 914 low
    \ Address offset: 0x2C90
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT914H_DEF
    \
    \ @brief Graphic MMU LUT entry 914 high
    \ Address offset: 0x2C94
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT915L_DEF
    \
    \ @brief Graphic MMU LUT entry 915 low
    \ Address offset: 0x2C98
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT915H_DEF
    \
    \ @brief Graphic MMU LUT entry 915 high
    \ Address offset: 0x2C9C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT916L_DEF
    \
    \ @brief Graphic MMU LUT entry 916 low
    \ Address offset: 0x2CA0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT916H_DEF
    \
    \ @brief Graphic MMU LUT entry 916 high
    \ Address offset: 0x2CA4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT917L_DEF
    \
    \ @brief Graphic MMU LUT entry 917 low
    \ Address offset: 0x2CA8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT917H_DEF
    \
    \ @brief Graphic MMU LUT entry 917 high
    \ Address offset: 0x2CAC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT918L_DEF
    \
    \ @brief Graphic MMU LUT entry 918 low
    \ Address offset: 0x2CB0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT918H_DEF
    \
    \ @brief Graphic MMU LUT entry 918 high
    \ Address offset: 0x2CB4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT919L_DEF
    \
    \ @brief Graphic MMU LUT entry 919 low
    \ Address offset: 0x2CB8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT919H_DEF
    \
    \ @brief Graphic MMU LUT entry 919 high
    \ Address offset: 0x2CBC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT920L_DEF
    \
    \ @brief Graphic MMU LUT entry 920 low
    \ Address offset: 0x2CC0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT920H_DEF
    \
    \ @brief Graphic MMU LUT entry 920 high
    \ Address offset: 0x2CC4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT921L_DEF
    \
    \ @brief Graphic MMU LUT entry 921 low
    \ Address offset: 0x2CC8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT921H_DEF
    \
    \ @brief Graphic MMU LUT entry 921 high
    \ Address offset: 0x2CCC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT922L_DEF
    \
    \ @brief Graphic MMU LUT entry 922 low
    \ Address offset: 0x2CD0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT922H_DEF
    \
    \ @brief Graphic MMU LUT entry 922 high
    \ Address offset: 0x2CD4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT923L_DEF
    \
    \ @brief Graphic MMU LUT entry 923 low
    \ Address offset: 0x2CD8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT923H_DEF
    \
    \ @brief Graphic MMU LUT entry 923 high
    \ Address offset: 0x2CDC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT924L_DEF
    \
    \ @brief Graphic MMU LUT entry 924 low
    \ Address offset: 0x2CE0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT924H_DEF
    \
    \ @brief Graphic MMU LUT entry 924 high
    \ Address offset: 0x2CE4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT925L_DEF
    \
    \ @brief Graphic MMU LUT entry 925 low
    \ Address offset: 0x2CE8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT925H_DEF
    \
    \ @brief Graphic MMU LUT entry 925 high
    \ Address offset: 0x2CEC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT926L_DEF
    \
    \ @brief Graphic MMU LUT entry 926 low
    \ Address offset: 0x2CF0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT926H_DEF
    \
    \ @brief Graphic MMU LUT entry 926 high
    \ Address offset: 0x2CF4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT927L_DEF
    \
    \ @brief Graphic MMU LUT entry 927 low
    \ Address offset: 0x2CF8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT927H_DEF
    \
    \ @brief Graphic MMU LUT entry 927 high
    \ Address offset: 0x2CFC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT928L_DEF
    \
    \ @brief Graphic MMU LUT entry 928 low
    \ Address offset: 0x2D00
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT928H_DEF
    \
    \ @brief Graphic MMU LUT entry 928 high
    \ Address offset: 0x2D04
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT929L_DEF
    \
    \ @brief Graphic MMU LUT entry 929 low
    \ Address offset: 0x2D08
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT929H_DEF
    \
    \ @brief Graphic MMU LUT entry 929 high
    \ Address offset: 0x2D0C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT930L_DEF
    \
    \ @brief Graphic MMU LUT entry 930 low
    \ Address offset: 0x2D10
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT930H_DEF
    \
    \ @brief Graphic MMU LUT entry 930 high
    \ Address offset: 0x2D14
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT931L_DEF
    \
    \ @brief Graphic MMU LUT entry 931 low
    \ Address offset: 0x2D18
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT931H_DEF
    \
    \ @brief Graphic MMU LUT entry 931 high
    \ Address offset: 0x2D1C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT932L_DEF
    \
    \ @brief Graphic MMU LUT entry 932 low
    \ Address offset: 0x2D20
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT932H_DEF
    \
    \ @brief Graphic MMU LUT entry 932 high
    \ Address offset: 0x2D24
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT933L_DEF
    \
    \ @brief Graphic MMU LUT entry 933 low
    \ Address offset: 0x2D28
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT933H_DEF
    \
    \ @brief Graphic MMU LUT entry 933 high
    \ Address offset: 0x2D2C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT934L_DEF
    \
    \ @brief Graphic MMU LUT entry 934 low
    \ Address offset: 0x2D30
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT934H_DEF
    \
    \ @brief Graphic MMU LUT entry 934 high
    \ Address offset: 0x2D34
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT935L_DEF
    \
    \ @brief Graphic MMU LUT entry 935 low
    \ Address offset: 0x2D38
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT935H_DEF
    \
    \ @brief Graphic MMU LUT entry 935 high
    \ Address offset: 0x2D3C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT936L_DEF
    \
    \ @brief Graphic MMU LUT entry 936 low
    \ Address offset: 0x2D40
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT936H_DEF
    \
    \ @brief Graphic MMU LUT entry 936 high
    \ Address offset: 0x2D44
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT937L_DEF
    \
    \ @brief Graphic MMU LUT entry 937 low
    \ Address offset: 0x2D48
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT937H_DEF
    \
    \ @brief Graphic MMU LUT entry 937 high
    \ Address offset: 0x2D4C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT938L_DEF
    \
    \ @brief Graphic MMU LUT entry 938 low
    \ Address offset: 0x2D50
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT938H_DEF
    \
    \ @brief Graphic MMU LUT entry 938 high
    \ Address offset: 0x2D54
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT939L_DEF
    \
    \ @brief Graphic MMU LUT entry 939 low
    \ Address offset: 0x2D58
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT939H_DEF
    \
    \ @brief Graphic MMU LUT entry 939 high
    \ Address offset: 0x2D5C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT940L_DEF
    \
    \ @brief Graphic MMU LUT entry 940 low
    \ Address offset: 0x2D60
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT940H_DEF
    \
    \ @brief Graphic MMU LUT entry 940 high
    \ Address offset: 0x2D64
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT941L_DEF
    \
    \ @brief Graphic MMU LUT entry 941 low
    \ Address offset: 0x2D68
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT941H_DEF
    \
    \ @brief Graphic MMU LUT entry 941 high
    \ Address offset: 0x2D6C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT942L_DEF
    \
    \ @brief Graphic MMU LUT entry 942 low
    \ Address offset: 0x2D70
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT942H_DEF
    \
    \ @brief Graphic MMU LUT entry 942 high
    \ Address offset: 0x2D74
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT943L_DEF
    \
    \ @brief Graphic MMU LUT entry 943 low
    \ Address offset: 0x2D78
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT943H_DEF
    \
    \ @brief Graphic MMU LUT entry 943 high
    \ Address offset: 0x2D7C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT944L_DEF
    \
    \ @brief Graphic MMU LUT entry 944 low
    \ Address offset: 0x2D80
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT944H_DEF
    \
    \ @brief Graphic MMU LUT entry 944 high
    \ Address offset: 0x2D84
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT945L_DEF
    \
    \ @brief Graphic MMU LUT entry 945 low
    \ Address offset: 0x2D88
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT945H_DEF
    \
    \ @brief Graphic MMU LUT entry 945 high
    \ Address offset: 0x2D8C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT946L_DEF
    \
    \ @brief Graphic MMU LUT entry 946 low
    \ Address offset: 0x2D90
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT946H_DEF
    \
    \ @brief Graphic MMU LUT entry 946 high
    \ Address offset: 0x2D94
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT947L_DEF
    \
    \ @brief Graphic MMU LUT entry 947 low
    \ Address offset: 0x2D98
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT947H_DEF
    \
    \ @brief Graphic MMU LUT entry 947 high
    \ Address offset: 0x2D9C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT948L_DEF
    \
    \ @brief Graphic MMU LUT entry 948 low
    \ Address offset: 0x2DA0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT948H_DEF
    \
    \ @brief Graphic MMU LUT entry 948 high
    \ Address offset: 0x2DA4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT949L_DEF
    \
    \ @brief Graphic MMU LUT entry 949 low
    \ Address offset: 0x2DA8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT949H_DEF
    \
    \ @brief Graphic MMU LUT entry 949 high
    \ Address offset: 0x2DAC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT950L_DEF
    \
    \ @brief Graphic MMU LUT entry 950 low
    \ Address offset: 0x2DB0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT950H_DEF
    \
    \ @brief Graphic MMU LUT entry 950 high
    \ Address offset: 0x2DB4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT951L_DEF
    \
    \ @brief Graphic MMU LUT entry 951 low
    \ Address offset: 0x2DB8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT951H_DEF
    \
    \ @brief Graphic MMU LUT entry 951 high
    \ Address offset: 0x2DBC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT952L_DEF
    \
    \ @brief Graphic MMU LUT entry 952 low
    \ Address offset: 0x2DC0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT952H_DEF
    \
    \ @brief Graphic MMU LUT entry 952 high
    \ Address offset: 0x2DC4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT953L_DEF
    \
    \ @brief Graphic MMU LUT entry 953 low
    \ Address offset: 0x2DC8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT953H_DEF
    \
    \ @brief Graphic MMU LUT entry 953 high
    \ Address offset: 0x2DCC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT954L_DEF
    \
    \ @brief Graphic MMU LUT entry 954 low
    \ Address offset: 0x2DD0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT954H_DEF
    \
    \ @brief Graphic MMU LUT entry 954 high
    \ Address offset: 0x2DD4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT955L_DEF
    \
    \ @brief Graphic MMU LUT entry 955 low
    \ Address offset: 0x2DD8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT955H_DEF
    \
    \ @brief Graphic MMU LUT entry 955 high
    \ Address offset: 0x2DDC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT956L_DEF
    \
    \ @brief Graphic MMU LUT entry 956 low
    \ Address offset: 0x2DE0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT956H_DEF
    \
    \ @brief Graphic MMU LUT entry 956 high
    \ Address offset: 0x2DE4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT957L_DEF
    \
    \ @brief Graphic MMU LUT entry 957 low
    \ Address offset: 0x2DE8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT957H_DEF
    \
    \ @brief Graphic MMU LUT entry 957 high
    \ Address offset: 0x2DEC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT958L_DEF
    \
    \ @brief Graphic MMU LUT entry 958 low
    \ Address offset: 0x2DF0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT958H_DEF
    \
    \ @brief Graphic MMU LUT entry 958 high
    \ Address offset: 0x2DF4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT959L_DEF
    \
    \ @brief Graphic MMU LUT entry 959 low
    \ Address offset: 0x2DF8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT959H_DEF
    \
    \ @brief Graphic MMU LUT entry 959 high
    \ Address offset: 0x2DFC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT960L_DEF
    \
    \ @brief Graphic MMU LUT entry 960 low
    \ Address offset: 0x2E00
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT960H_DEF
    \
    \ @brief Graphic MMU LUT entry 960 high
    \ Address offset: 0x2E04
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT961L_DEF
    \
    \ @brief Graphic MMU LUT entry 961 low
    \ Address offset: 0x2E08
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT961H_DEF
    \
    \ @brief Graphic MMU LUT entry 961 high
    \ Address offset: 0x2E0C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT962L_DEF
    \
    \ @brief Graphic MMU LUT entry 962 low
    \ Address offset: 0x2E10
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT962H_DEF
    \
    \ @brief Graphic MMU LUT entry 962 high
    \ Address offset: 0x2E14
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT963L_DEF
    \
    \ @brief Graphic MMU LUT entry 963 low
    \ Address offset: 0x2E18
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT963H_DEF
    \
    \ @brief Graphic MMU LUT entry 963 high
    \ Address offset: 0x2E1C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT964L_DEF
    \
    \ @brief Graphic MMU LUT entry 964 low
    \ Address offset: 0x2E20
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT964H_DEF
    \
    \ @brief Graphic MMU LUT entry 964 high
    \ Address offset: 0x2E24
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT965L_DEF
    \
    \ @brief Graphic MMU LUT entry 965 low
    \ Address offset: 0x2E28
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT965H_DEF
    \
    \ @brief Graphic MMU LUT entry 965 high
    \ Address offset: 0x2E2C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT966L_DEF
    \
    \ @brief Graphic MMU LUT entry 966 low
    \ Address offset: 0x2E30
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT966H_DEF
    \
    \ @brief Graphic MMU LUT entry 966 high
    \ Address offset: 0x2E34
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT967L_DEF
    \
    \ @brief Graphic MMU LUT entry 967 low
    \ Address offset: 0x2E38
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT967H_DEF
    \
    \ @brief Graphic MMU LUT entry 967 high
    \ Address offset: 0x2E3C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT968L_DEF
    \
    \ @brief Graphic MMU LUT entry 968 low
    \ Address offset: 0x2E40
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT968H_DEF
    \
    \ @brief Graphic MMU LUT entry 968 high
    \ Address offset: 0x2E44
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT969L_DEF
    \
    \ @brief Graphic MMU LUT entry 969 low
    \ Address offset: 0x2E48
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT969H_DEF
    \
    \ @brief Graphic MMU LUT entry 969 high
    \ Address offset: 0x2E4C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT970L_DEF
    \
    \ @brief Graphic MMU LUT entry 970 low
    \ Address offset: 0x2E50
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT970H_DEF
    \
    \ @brief Graphic MMU LUT entry 970 high
    \ Address offset: 0x2E54
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT971L_DEF
    \
    \ @brief Graphic MMU LUT entry 971 low
    \ Address offset: 0x2E58
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT971H_DEF
    \
    \ @brief Graphic MMU LUT entry 971 high
    \ Address offset: 0x2E5C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT972L_DEF
    \
    \ @brief Graphic MMU LUT entry 972 low
    \ Address offset: 0x2E60
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT972H_DEF
    \
    \ @brief Graphic MMU LUT entry 972 high
    \ Address offset: 0x2E64
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT973L_DEF
    \
    \ @brief Graphic MMU LUT entry 973 low
    \ Address offset: 0x2E68
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT973H_DEF
    \
    \ @brief Graphic MMU LUT entry 973 high
    \ Address offset: 0x2E6C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT974L_DEF
    \
    \ @brief Graphic MMU LUT entry 974 low
    \ Address offset: 0x2E70
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT974H_DEF
    \
    \ @brief Graphic MMU LUT entry 974 high
    \ Address offset: 0x2E74
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT975L_DEF
    \
    \ @brief Graphic MMU LUT entry 975 low
    \ Address offset: 0x2E78
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT975H_DEF
    \
    \ @brief Graphic MMU LUT entry 975 high
    \ Address offset: 0x2E7C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT976L_DEF
    \
    \ @brief Graphic MMU LUT entry 976 low
    \ Address offset: 0x2E80
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT976H_DEF
    \
    \ @brief Graphic MMU LUT entry 976 high
    \ Address offset: 0x2E84
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT977L_DEF
    \
    \ @brief Graphic MMU LUT entry 977 low
    \ Address offset: 0x2E88
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT977H_DEF
    \
    \ @brief Graphic MMU LUT entry 977 high
    \ Address offset: 0x2E8C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT978L_DEF
    \
    \ @brief Graphic MMU LUT entry 978 low
    \ Address offset: 0x2E90
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT978H_DEF
    \
    \ @brief Graphic MMU LUT entry 978 high
    \ Address offset: 0x2E94
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT979L_DEF
    \
    \ @brief Graphic MMU LUT entry 979 low
    \ Address offset: 0x2E98
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT979H_DEF
    \
    \ @brief Graphic MMU LUT entry 979 high
    \ Address offset: 0x2E9C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT980L_DEF
    \
    \ @brief Graphic MMU LUT entry 980 low
    \ Address offset: 0x2EA0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT980H_DEF
    \
    \ @brief Graphic MMU LUT entry 980 high
    \ Address offset: 0x2EA4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT981L_DEF
    \
    \ @brief Graphic MMU LUT entry 981 low
    \ Address offset: 0x2EA8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT981H_DEF
    \
    \ @brief Graphic MMU LUT entry 981 high
    \ Address offset: 0x2EAC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT982L_DEF
    \
    \ @brief Graphic MMU LUT entry 982 low
    \ Address offset: 0x2EB0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT982H_DEF
    \
    \ @brief Graphic MMU LUT entry 982 high
    \ Address offset: 0x2EB4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT983L_DEF
    \
    \ @brief Graphic MMU LUT entry 983 low
    \ Address offset: 0x2EB8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT983H_DEF
    \
    \ @brief Graphic MMU LUT entry 983 high
    \ Address offset: 0x2EBC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT984L_DEF
    \
    \ @brief Graphic MMU LUT entry 984 low
    \ Address offset: 0x2EC0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT984H_DEF
    \
    \ @brief Graphic MMU LUT entry 984 high
    \ Address offset: 0x2EC4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT985L_DEF
    \
    \ @brief Graphic MMU LUT entry 985 low
    \ Address offset: 0x2EC8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT985H_DEF
    \
    \ @brief Graphic MMU LUT entry 985 high
    \ Address offset: 0x2ECC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT986L_DEF
    \
    \ @brief Graphic MMU LUT entry 986 low
    \ Address offset: 0x2ED0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT986H_DEF
    \
    \ @brief Graphic MMU LUT entry 986 high
    \ Address offset: 0x2ED4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT987L_DEF
    \
    \ @brief Graphic MMU LUT entry 987 low
    \ Address offset: 0x2ED8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT987H_DEF
    \
    \ @brief Graphic MMU LUT entry 987 high
    \ Address offset: 0x2EDC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT988L_DEF
    \
    \ @brief Graphic MMU LUT entry 988 low
    \ Address offset: 0x2EE0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT988H_DEF
    \
    \ @brief Graphic MMU LUT entry 988 high
    \ Address offset: 0x2EE4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT989L_DEF
    \
    \ @brief Graphic MMU LUT entry 989 low
    \ Address offset: 0x2EE8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT989H_DEF
    \
    \ @brief Graphic MMU LUT entry 989 high
    \ Address offset: 0x2EEC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT990L_DEF
    \
    \ @brief Graphic MMU LUT entry 990 low
    \ Address offset: 0x2EF0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT990H_DEF
    \
    \ @brief Graphic MMU LUT entry 990 high
    \ Address offset: 0x2EF4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT991L_DEF
    \
    \ @brief Graphic MMU LUT entry 991 low
    \ Address offset: 0x2EF8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT991H_DEF
    \
    \ @brief Graphic MMU LUT entry 991 high
    \ Address offset: 0x2EFC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT992L_DEF
    \
    \ @brief Graphic MMU LUT entry 992 low
    \ Address offset: 0x2F00
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT992H_DEF
    \
    \ @brief Graphic MMU LUT entry 992 high
    \ Address offset: 0x2F04
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT993L_DEF
    \
    \ @brief Graphic MMU LUT entry 993 low
    \ Address offset: 0x2F08
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT993H_DEF
    \
    \ @brief Graphic MMU LUT entry 993 high
    \ Address offset: 0x2F0C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT994L_DEF
    \
    \ @brief Graphic MMU LUT entry 994 low
    \ Address offset: 0x2F10
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT994H_DEF
    \
    \ @brief Graphic MMU LUT entry 994 high
    \ Address offset: 0x2F14
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT995L_DEF
    \
    \ @brief Graphic MMU LUT entry 995 low
    \ Address offset: 0x2F18
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT995H_DEF
    \
    \ @brief Graphic MMU LUT entry 995 high
    \ Address offset: 0x2F1C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT996L_DEF
    \
    \ @brief Graphic MMU LUT entry 996 low
    \ Address offset: 0x2F20
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT996H_DEF
    \
    \ @brief Graphic MMU LUT entry 996 high
    \ Address offset: 0x2F24
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT997L_DEF
    \
    \ @brief Graphic MMU LUT entry 997 low
    \ Address offset: 0x2F28
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT997H_DEF
    \
    \ @brief Graphic MMU LUT entry 997 high
    \ Address offset: 0x2F2C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT998L_DEF
    \
    \ @brief Graphic MMU LUT entry 998 low
    \ Address offset: 0x2F30
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT998H_DEF
    \
    \ @brief Graphic MMU LUT entry 998 high
    \ Address offset: 0x2F34
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT999L_DEF
    \
    \ @brief Graphic MMU LUT entry 999 low
    \ Address offset: 0x2F38
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT999H_DEF
    \
    \ @brief Graphic MMU LUT entry 999 high
    \ Address offset: 0x2F3C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1000L_DEF
    \
    \ @brief Graphic MMU LUT entry 1000 low
    \ Address offset: 0x2F40
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1000H_DEF
    \
    \ @brief Graphic MMU LUT entry 1000 high
    \ Address offset: 0x2F44
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1001L_DEF
    \
    \ @brief Graphic MMU LUT entry 1001 low
    \ Address offset: 0x2F48
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1001H_DEF
    \
    \ @brief Graphic MMU LUT entry 1001 high
    \ Address offset: 0x2F4C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1002L_DEF
    \
    \ @brief Graphic MMU LUT entry 1002 low
    \ Address offset: 0x2F50
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1002H_DEF
    \
    \ @brief Graphic MMU LUT entry 1002 high
    \ Address offset: 0x2F54
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1003L_DEF
    \
    \ @brief Graphic MMU LUT entry 1003 low
    \ Address offset: 0x2F58
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1003H_DEF
    \
    \ @brief Graphic MMU LUT entry 1003 high
    \ Address offset: 0x2F5C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1004L_DEF
    \
    \ @brief Graphic MMU LUT entry 1004 low
    \ Address offset: 0x2F60
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1004H_DEF
    \
    \ @brief Graphic MMU LUT entry 1004 high
    \ Address offset: 0x2F64
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1005L_DEF
    \
    \ @brief Graphic MMU LUT entry 1005 low
    \ Address offset: 0x2F68
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1005H_DEF
    \
    \ @brief Graphic MMU LUT entry 1005 high
    \ Address offset: 0x2F6C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1006L_DEF
    \
    \ @brief Graphic MMU LUT entry 1006 low
    \ Address offset: 0x2F70
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1006H_DEF
    \
    \ @brief Graphic MMU LUT entry 1006 high
    \ Address offset: 0x2F74
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1007L_DEF
    \
    \ @brief Graphic MMU LUT entry 1007 low
    \ Address offset: 0x2F78
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1007H_DEF
    \
    \ @brief Graphic MMU LUT entry 1007 high
    \ Address offset: 0x2F7C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1008L_DEF
    \
    \ @brief Graphic MMU LUT entry 1008 low
    \ Address offset: 0x2F80
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1008H_DEF
    \
    \ @brief Graphic MMU LUT entry 1008 high
    \ Address offset: 0x2F84
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1009L_DEF
    \
    \ @brief Graphic MMU LUT entry 1009 low
    \ Address offset: 0x2F88
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1009H_DEF
    \
    \ @brief Graphic MMU LUT entry 1009 high
    \ Address offset: 0x2F8C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1010L_DEF
    \
    \ @brief Graphic MMU LUT entry 1010 low
    \ Address offset: 0x2F90
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1010H_DEF
    \
    \ @brief Graphic MMU LUT entry 1010 high
    \ Address offset: 0x2F94
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1011L_DEF
    \
    \ @brief Graphic MMU LUT entry 1011 low
    \ Address offset: 0x2F98
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1011H_DEF
    \
    \ @brief Graphic MMU LUT entry 1011 high
    \ Address offset: 0x2F9C
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1012L_DEF
    \
    \ @brief Graphic MMU LUT entry 1012 low
    \ Address offset: 0x2FA0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1012H_DEF
    \
    \ @brief Graphic MMU LUT entry 1012 high
    \ Address offset: 0x2FA4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1013L_DEF
    \
    \ @brief Graphic MMU LUT entry 1013 low
    \ Address offset: 0x2FA8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1013H_DEF
    \
    \ @brief Graphic MMU LUT entry 1013 high
    \ Address offset: 0x2FAC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1014L_DEF
    \
    \ @brief Graphic MMU LUT entry 1014 low
    \ Address offset: 0x2FB0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1014H_DEF
    \
    \ @brief Graphic MMU LUT entry 1014 high
    \ Address offset: 0x2FB4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1015L_DEF
    \
    \ @brief Graphic MMU LUT entry 1015 low
    \ Address offset: 0x2FB8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1015H_DEF
    \
    \ @brief Graphic MMU LUT entry 1015 high
    \ Address offset: 0x2FBC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1016L_DEF
    \
    \ @brief Graphic MMU LUT entry 1016 low
    \ Address offset: 0x2FC0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1016H_DEF
    \
    \ @brief Graphic MMU LUT entry 1016 high
    \ Address offset: 0x2FC4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1017L_DEF
    \
    \ @brief Graphic MMU LUT entry 1017 low
    \ Address offset: 0x2FC8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1017H_DEF
    \
    \ @brief Graphic MMU LUT entry 1017 high
    \ Address offset: 0x2FCC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1018L_DEF
    \
    \ @brief Graphic MMU LUT entry 1018 low
    \ Address offset: 0x2FD0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1018H_DEF
    \
    \ @brief Graphic MMU LUT entry 1018 high
    \ Address offset: 0x2FD4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1019L_DEF
    \
    \ @brief Graphic MMU LUT entry 1019 low
    \ Address offset: 0x2FD8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1019H_DEF
    \
    \ @brief Graphic MMU LUT entry 1019 high
    \ Address offset: 0x2FDC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1020L_DEF
    \
    \ @brief Graphic MMU LUT entry 1020 low
    \ Address offset: 0x2FE0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1020H_DEF
    \
    \ @brief Graphic MMU LUT entry 1020 high
    \ Address offset: 0x2FE4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1021L_DEF
    \
    \ @brief Graphic MMU LUT entry 1021 low
    \ Address offset: 0x2FE8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1021H_DEF
    \
    \ @brief Graphic MMU LUT entry 1021 high
    \ Address offset: 0x2FEC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1022L_DEF
    \
    \ @brief Graphic MMU LUT entry 1022 low
    \ Address offset: 0x2FF0
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1022H_DEF
    \
    \ @brief Graphic MMU LUT entry 1022 high
    \ Address offset: 0x2FF4
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]


  [ifdef] GFXMMU_LUT1023L_DEF
    \
    \ @brief Graphic MMU LUT entry 1023 low
    \ Address offset: 0x2FF8
    \ Reset value: 0x00000000
    \
    $00 constant GFXMMU_EN                      \ [0x00] Enable
    $08 constant GFXMMU_FVB                     \ [0x08 : 8] First Valid Block
    $10 constant GFXMMU_LVB                     \ [0x10 : 8] Last Valid Block
  [then]


  [ifdef] GFXMMU_LUT1023H_DEF
    \
    \ @brief Graphic MMU LUT entry 1023 high
    \ Address offset: 0x2FFC
    \ Reset value: 0x00000000
    \
    $04 constant GFXMMU_LO                      \ [0x04 : 18] Line offset
  [then]

  \
  \ @brief Graphic MMU
  \
  $00 constant GFXMMU_CR                \ Graphic MMU configuration register
  $04 constant GFXMMU_SR                \ Graphic MMU status register
  $08 constant GFXMMU_FCR               \ Graphic MMU flag clear register
  $10 constant GFXMMU_DVR               \ Graphic MMU default value register
  $20 constant GFXMMU_B0CR              \ Graphic MMU buffer 0 configuration register
  $24 constant GFXMMU_B1CR              \ Graphic MMU buffer 1 configuration register
  $28 constant GFXMMU_B2CR              \ Graphic MMU buffer 2 configuration register
  $2C constant GFXMMU_B3CR              \ Graphic MMU buffer 3 configuration register
  $FF4 constant GFXMMU_VERR             \ Graphic MMU version register
  $FF8 constant GFXMMU_IPIDR            \ Graphic MMU identification register
  $FFC constant GFXMMU_SIDR             \ Graphic MMU size identification register
  $1000 constant GFXMMU_LUT0L           \ Graphic MMU LUT entry 0 low
  $1004 constant GFXMMU_LUT0H           \ Graphic MMU LUT entry 0 high
  $1008 constant GFXMMU_LUT1L           \ Graphic MMU LUT entry 1 low
  $100C constant GFXMMU_LUT1H           \ Graphic MMU LUT entry 1 high
  $1010 constant GFXMMU_LUT2L           \ Graphic MMU LUT entry 2 low
  $1014 constant GFXMMU_LUT2H           \ Graphic MMU LUT entry 2 high
  $1018 constant GFXMMU_LUT3L           \ Graphic MMU LUT entry 3 low
  $101C constant GFXMMU_LUT3H           \ Graphic MMU LUT entry 3 high
  $1020 constant GFXMMU_LUT4L           \ Graphic MMU LUT entry 4 low
  $1024 constant GFXMMU_LUT4H           \ Graphic MMU LUT entry 4 high
  $1028 constant GFXMMU_LUT5L           \ Graphic MMU LUT entry 5 low
  $102C constant GFXMMU_LUT5H           \ Graphic MMU LUT entry 5 high
  $1030 constant GFXMMU_LUT6L           \ Graphic MMU LUT entry 6 low
  $1034 constant GFXMMU_LUT6H           \ Graphic MMU LUT entry 6 high
  $1038 constant GFXMMU_LUT7L           \ Graphic MMU LUT entry 7 low
  $103C constant GFXMMU_LUT7H           \ Graphic MMU LUT entry 7 high
  $1040 constant GFXMMU_LUT8L           \ Graphic MMU LUT entry 8 low
  $1044 constant GFXMMU_LUT8H           \ Graphic MMU LUT entry 8 high
  $1048 constant GFXMMU_LUT9L           \ Graphic MMU LUT entry 9 low
  $104C constant GFXMMU_LUT9H           \ Graphic MMU LUT entry 9 high
  $1050 constant GFXMMU_LUT10L          \ Graphic MMU LUT entry 10 low
  $1054 constant GFXMMU_LUT10H          \ Graphic MMU LUT entry 10 high
  $1058 constant GFXMMU_LUT11L          \ Graphic MMU LUT entry 11 low
  $105C constant GFXMMU_LUT11H          \ Graphic MMU LUT entry 11 high
  $1060 constant GFXMMU_LUT12L          \ Graphic MMU LUT entry 12 low
  $1064 constant GFXMMU_LUT12H          \ Graphic MMU LUT entry 12 high
  $1068 constant GFXMMU_LUT13L          \ Graphic MMU LUT entry 13 low
  $106C constant GFXMMU_LUT13H          \ Graphic MMU LUT entry 13 high
  $1070 constant GFXMMU_LUT14L          \ Graphic MMU LUT entry 14 low
  $1074 constant GFXMMU_LUT14H          \ Graphic MMU LUT entry 14 high
  $1078 constant GFXMMU_LUT15L          \ Graphic MMU LUT entry 15 low
  $107C constant GFXMMU_LUT15H          \ Graphic MMU LUT entry 15 high
  $1080 constant GFXMMU_LUT16L          \ Graphic MMU LUT entry 16 low
  $1084 constant GFXMMU_LUT16H          \ Graphic MMU LUT entry 16 high
  $1088 constant GFXMMU_LUT17L          \ Graphic MMU LUT entry 17 low
  $108C constant GFXMMU_LUT17H          \ Graphic MMU LUT entry 17 high
  $1090 constant GFXMMU_LUT18L          \ Graphic MMU LUT entry 18 low
  $1094 constant GFXMMU_LUT18H          \ Graphic MMU LUT entry 18 high
  $1098 constant GFXMMU_LUT19L          \ Graphic MMU LUT entry 19 low
  $109C constant GFXMMU_LUT19H          \ Graphic MMU LUT entry 19 high
  $10A0 constant GFXMMU_LUT20L          \ Graphic MMU LUT entry 20 low
  $10A4 constant GFXMMU_LUT20H          \ Graphic MMU LUT entry 20 high
  $10A8 constant GFXMMU_LUT21L          \ Graphic MMU LUT entry 21 low
  $10AC constant GFXMMU_LUT21H          \ Graphic MMU LUT entry 21 high
  $10B0 constant GFXMMU_LUT22L          \ Graphic MMU LUT entry 22 low
  $10B4 constant GFXMMU_LUT22H          \ Graphic MMU LUT entry 22 high
  $10B8 constant GFXMMU_LUT23L          \ Graphic MMU LUT entry 23 low
  $10BC constant GFXMMU_LUT23H          \ Graphic MMU LUT entry 23 high
  $10C0 constant GFXMMU_LUT24L          \ Graphic MMU LUT entry 24 low
  $10C4 constant GFXMMU_LUT24H          \ Graphic MMU LUT entry 24 high
  $10C8 constant GFXMMU_LUT25L          \ Graphic MMU LUT entry 25 low
  $10CC constant GFXMMU_LUT25H          \ Graphic MMU LUT entry 25 high
  $10D0 constant GFXMMU_LUT26L          \ Graphic MMU LUT entry 26 low
  $10D4 constant GFXMMU_LUT26H          \ Graphic MMU LUT entry 26 high
  $10D8 constant GFXMMU_LUT27L          \ Graphic MMU LUT entry 27 low
  $10DC constant GFXMMU_LUT27H          \ Graphic MMU LUT entry 27 high
  $10E0 constant GFXMMU_LUT28L          \ Graphic MMU LUT entry 28 low
  $10E4 constant GFXMMU_LUT28H          \ Graphic MMU LUT entry 28 high
  $10E8 constant GFXMMU_LUT29L          \ Graphic MMU LUT entry 29 low
  $10EC constant GFXMMU_LUT29H          \ Graphic MMU LUT entry 29 high
  $10F0 constant GFXMMU_LUT30L          \ Graphic MMU LUT entry 30 low
  $10F4 constant GFXMMU_LUT30H          \ Graphic MMU LUT entry 30 high
  $10F8 constant GFXMMU_LUT31L          \ Graphic MMU LUT entry 31 low
  $10FC constant GFXMMU_LUT31H          \ Graphic MMU LUT entry 31 high
  $1100 constant GFXMMU_LUT32L          \ Graphic MMU LUT entry 32 low
  $1104 constant GFXMMU_LUT32H          \ Graphic MMU LUT entry 32 high
  $1108 constant GFXMMU_LUT33L          \ Graphic MMU LUT entry 33 low
  $110C constant GFXMMU_LUT33H          \ Graphic MMU LUT entry 33 high
  $1110 constant GFXMMU_LUT34L          \ Graphic MMU LUT entry 34 low
  $1114 constant GFXMMU_LUT34H          \ Graphic MMU LUT entry 34 high
  $1118 constant GFXMMU_LUT35L          \ Graphic MMU LUT entry 35 low
  $111C constant GFXMMU_LUT35H          \ Graphic MMU LUT entry 35 high
  $1120 constant GFXMMU_LUT36L          \ Graphic MMU LUT entry 36 low
  $1124 constant GFXMMU_LUT36H          \ Graphic MMU LUT entry 36 high
  $1128 constant GFXMMU_LUT37L          \ Graphic MMU LUT entry 37 low
  $112C constant GFXMMU_LUT37H          \ Graphic MMU LUT entry 37 high
  $1130 constant GFXMMU_LUT38L          \ Graphic MMU LUT entry 38 low
  $1134 constant GFXMMU_LUT38H          \ Graphic MMU LUT entry 38 high
  $1138 constant GFXMMU_LUT39L          \ Graphic MMU LUT entry 39 low
  $113C constant GFXMMU_LUT39H          \ Graphic MMU LUT entry 39 high
  $1140 constant GFXMMU_LUT40L          \ Graphic MMU LUT entry 40 low
  $1144 constant GFXMMU_LUT40H          \ Graphic MMU LUT entry 40 high
  $1148 constant GFXMMU_LUT41L          \ Graphic MMU LUT entry 41 low
  $114C constant GFXMMU_LUT41H          \ Graphic MMU LUT entry 41 high
  $1150 constant GFXMMU_LUT42L          \ Graphic MMU LUT entry 42 low
  $1154 constant GFXMMU_LUT42H          \ Graphic MMU LUT entry 42 high
  $1158 constant GFXMMU_LUT43L          \ Graphic MMU LUT entry 43 low
  $115C constant GFXMMU_LUT43H          \ Graphic MMU LUT entry 43 high
  $1160 constant GFXMMU_LUT44L          \ Graphic MMU LUT entry 44 low
  $1164 constant GFXMMU_LUT44H          \ Graphic MMU LUT entry 44 high
  $1168 constant GFXMMU_LUT45L          \ Graphic MMU LUT entry 45 low
  $116C constant GFXMMU_LUT45H          \ Graphic MMU LUT entry 45 high
  $1170 constant GFXMMU_LUT46L          \ Graphic MMU LUT entry 46 low
  $1174 constant GFXMMU_LUT46H          \ Graphic MMU LUT entry 46 high
  $1178 constant GFXMMU_LUT47L          \ Graphic MMU LUT entry 47 low
  $117C constant GFXMMU_LUT47H          \ Graphic MMU LUT entry 47 high
  $1180 constant GFXMMU_LUT48L          \ Graphic MMU LUT entry 48 low
  $1184 constant GFXMMU_LUT48H          \ Graphic MMU LUT entry 48 high
  $1188 constant GFXMMU_LUT49L          \ Graphic MMU LUT entry 49 low
  $118C constant GFXMMU_LUT49H          \ Graphic MMU LUT entry 49 high
  $1190 constant GFXMMU_LUT50L          \ Graphic MMU LUT entry 50 low
  $1194 constant GFXMMU_LUT50H          \ Graphic MMU LUT entry 50 high
  $1198 constant GFXMMU_LUT51L          \ Graphic MMU LUT entry 51 low
  $119C constant GFXMMU_LUT51H          \ Graphic MMU LUT entry 51 high
  $11A0 constant GFXMMU_LUT52L          \ Graphic MMU LUT entry 52 low
  $11A4 constant GFXMMU_LUT52H          \ Graphic MMU LUT entry 52 high
  $11A8 constant GFXMMU_LUT53L          \ Graphic MMU LUT entry 53 low
  $11AC constant GFXMMU_LUT53H          \ Graphic MMU LUT entry 53 high
  $11B0 constant GFXMMU_LUT54L          \ Graphic MMU LUT entry 54 low
  $11B4 constant GFXMMU_LUT54H          \ Graphic MMU LUT entry 54 high
  $11B8 constant GFXMMU_LUT55L          \ Graphic MMU LUT entry 55 low
  $11BC constant GFXMMU_LUT55H          \ Graphic MMU LUT entry 55 high
  $11C0 constant GFXMMU_LUT56L          \ Graphic MMU LUT entry 56 low
  $11C4 constant GFXMMU_LUT56H          \ Graphic MMU LUT entry 56 high
  $11C8 constant GFXMMU_LUT57L          \ Graphic MMU LUT entry 57 low
  $11CC constant GFXMMU_LUT57H          \ Graphic MMU LUT entry 57 high
  $11D0 constant GFXMMU_LUT58L          \ Graphic MMU LUT entry 58 low
  $11D4 constant GFXMMU_LUT58H          \ Graphic MMU LUT entry 58 high
  $11D8 constant GFXMMU_LUT59L          \ Graphic MMU LUT entry 59 low
  $11DC constant GFXMMU_LUT59H          \ Graphic MMU LUT entry 59 high
  $11E0 constant GFXMMU_LUT60L          \ Graphic MMU LUT entry 60 low
  $11E4 constant GFXMMU_LUT60H          \ Graphic MMU LUT entry 60 high
  $11E8 constant GFXMMU_LUT61L          \ Graphic MMU LUT entry 61 low
  $11EC constant GFXMMU_LUT61H          \ Graphic MMU LUT entry 61 high
  $11F0 constant GFXMMU_LUT62L          \ Graphic MMU LUT entry 62 low
  $11F4 constant GFXMMU_LUT62H          \ Graphic MMU LUT entry 62 high
  $11F8 constant GFXMMU_LUT63L          \ Graphic MMU LUT entry 63 low
  $11FC constant GFXMMU_LUT63H          \ Graphic MMU LUT entry 63 high
  $1200 constant GFXMMU_LUT64L          \ Graphic MMU LUT entry 64 low
  $1204 constant GFXMMU_LUT64H          \ Graphic MMU LUT entry 64 high
  $1208 constant GFXMMU_LUT65L          \ Graphic MMU LUT entry 65 low
  $120C constant GFXMMU_LUT65H          \ Graphic MMU LUT entry 65 high
  $1210 constant GFXMMU_LUT66L          \ Graphic MMU LUT entry 66 low
  $1214 constant GFXMMU_LUT66H          \ Graphic MMU LUT entry 66 high
  $1218 constant GFXMMU_LUT67L          \ Graphic MMU LUT entry 67 low
  $121C constant GFXMMU_LUT67H          \ Graphic MMU LUT entry 67 high
  $1220 constant GFXMMU_LUT68L          \ Graphic MMU LUT entry 68 low
  $1224 constant GFXMMU_LUT68H          \ Graphic MMU LUT entry 68 high
  $1228 constant GFXMMU_LUT69L          \ Graphic MMU LUT entry 69 low
  $122C constant GFXMMU_LUT69H          \ Graphic MMU LUT entry 69 high
  $1230 constant GFXMMU_LUT70L          \ Graphic MMU LUT entry 70 low
  $1234 constant GFXMMU_LUT70H          \ Graphic MMU LUT entry 70 high
  $1238 constant GFXMMU_LUT71L          \ Graphic MMU LUT entry 71 low
  $123C constant GFXMMU_LUT71H          \ Graphic MMU LUT entry 71 high
  $1240 constant GFXMMU_LUT72L          \ Graphic MMU LUT entry 72 low
  $1244 constant GFXMMU_LUT72H          \ Graphic MMU LUT entry 72 high
  $1248 constant GFXMMU_LUT73L          \ Graphic MMU LUT entry 73 low
  $124C constant GFXMMU_LUT73H          \ Graphic MMU LUT entry 73 high
  $1250 constant GFXMMU_LUT74L          \ Graphic MMU LUT entry 74 low
  $1254 constant GFXMMU_LUT74H          \ Graphic MMU LUT entry 74 high
  $1258 constant GFXMMU_LUT75L          \ Graphic MMU LUT entry 75 low
  $125C constant GFXMMU_LUT75H          \ Graphic MMU LUT entry 75 high
  $1260 constant GFXMMU_LUT76L          \ Graphic MMU LUT entry 76 low
  $1264 constant GFXMMU_LUT76H          \ Graphic MMU LUT entry 76 high
  $1268 constant GFXMMU_LUT77L          \ Graphic MMU LUT entry 77 low
  $126C constant GFXMMU_LUT77H          \ Graphic MMU LUT entry 77 high
  $1270 constant GFXMMU_LUT78L          \ Graphic MMU LUT entry 78 low
  $1274 constant GFXMMU_LUT78H          \ Graphic MMU LUT entry 78 high
  $1278 constant GFXMMU_LUT79L          \ Graphic MMU LUT entry 79 low
  $127C constant GFXMMU_LUT79H          \ Graphic MMU LUT entry 79 high
  $1280 constant GFXMMU_LUT80L          \ Graphic MMU LUT entry 80 low
  $1284 constant GFXMMU_LUT80H          \ Graphic MMU LUT entry 80 high
  $1288 constant GFXMMU_LUT81L          \ Graphic MMU LUT entry 81 low
  $128C constant GFXMMU_LUT81H          \ Graphic MMU LUT entry 81 high
  $1290 constant GFXMMU_LUT82L          \ Graphic MMU LUT entry 82 low
  $1294 constant GFXMMU_LUT82H          \ Graphic MMU LUT entry 82 high
  $1298 constant GFXMMU_LUT83L          \ Graphic MMU LUT entry 83 low
  $129C constant GFXMMU_LUT83H          \ Graphic MMU LUT entry 83 high
  $12A0 constant GFXMMU_LUT84L          \ Graphic MMU LUT entry 84 low
  $12A4 constant GFXMMU_LUT84H          \ Graphic MMU LUT entry 84 high
  $12A8 constant GFXMMU_LUT85L          \ Graphic MMU LUT entry 85 low
  $12AC constant GFXMMU_LUT85H          \ Graphic MMU LUT entry 85 high
  $12B0 constant GFXMMU_LUT86L          \ Graphic MMU LUT entry 86 low
  $12B4 constant GFXMMU_LUT86H          \ Graphic MMU LUT entry 86 high
  $12B8 constant GFXMMU_LUT87L          \ Graphic MMU LUT entry 87 low
  $12BC constant GFXMMU_LUT87H          \ Graphic MMU LUT entry 87 high
  $12C0 constant GFXMMU_LUT88L          \ Graphic MMU LUT entry 88 low
  $12C4 constant GFXMMU_LUT88H          \ Graphic MMU LUT entry 88 high
  $12C8 constant GFXMMU_LUT89L          \ Graphic MMU LUT entry 89 low
  $12CC constant GFXMMU_LUT89H          \ Graphic MMU LUT entry 89 high
  $12D0 constant GFXMMU_LUT90L          \ Graphic MMU LUT entry 90 low
  $12D4 constant GFXMMU_LUT90H          \ Graphic MMU LUT entry 90 high
  $12D8 constant GFXMMU_LUT91L          \ Graphic MMU LUT entry 91 low
  $12DC constant GFXMMU_LUT91H          \ Graphic MMU LUT entry 91 high
  $12E0 constant GFXMMU_LUT92L          \ Graphic MMU LUT entry 92 low
  $12E4 constant GFXMMU_LUT92H          \ Graphic MMU LUT entry 92 high
  $12E8 constant GFXMMU_LUT93L          \ Graphic MMU LUT entry 93 low
  $12EC constant GFXMMU_LUT93H          \ Graphic MMU LUT entry 93 high
  $12F0 constant GFXMMU_LUT94L          \ Graphic MMU LUT entry 94 low
  $12F4 constant GFXMMU_LUT94H          \ Graphic MMU LUT entry 94 high
  $12F8 constant GFXMMU_LUT95L          \ Graphic MMU LUT entry 95 low
  $12FC constant GFXMMU_LUT95H          \ Graphic MMU LUT entry 95 high
  $1300 constant GFXMMU_LUT96L          \ Graphic MMU LUT entry 96 low
  $1304 constant GFXMMU_LUT96H          \ Graphic MMU LUT entry 96 high
  $1308 constant GFXMMU_LUT97L          \ Graphic MMU LUT entry 97 low
  $130C constant GFXMMU_LUT97H          \ Graphic MMU LUT entry 97 high
  $1310 constant GFXMMU_LUT98L          \ Graphic MMU LUT entry 98 low
  $1314 constant GFXMMU_LUT98H          \ Graphic MMU LUT entry 98 high
  $1318 constant GFXMMU_LUT99L          \ Graphic MMU LUT entry 99 low
  $131C constant GFXMMU_LUT99H          \ Graphic MMU LUT entry 99 high
  $1320 constant GFXMMU_LUT100L         \ Graphic MMU LUT entry 100 low
  $1324 constant GFXMMU_LUT100H         \ Graphic MMU LUT entry 100 high
  $1328 constant GFXMMU_LUT101L         \ Graphic MMU LUT entry 101 low
  $132C constant GFXMMU_LUT101H         \ Graphic MMU LUT entry 101 high
  $1330 constant GFXMMU_LUT102L         \ Graphic MMU LUT entry 102 low
  $1334 constant GFXMMU_LUT102H         \ Graphic MMU LUT entry 102 high
  $1338 constant GFXMMU_LUT103L         \ Graphic MMU LUT entry 103 low
  $133C constant GFXMMU_LUT103H         \ Graphic MMU LUT entry 103 high
  $1340 constant GFXMMU_LUT104L         \ Graphic MMU LUT entry 104 low
  $1344 constant GFXMMU_LUT104H         \ Graphic MMU LUT entry 104 high
  $1348 constant GFXMMU_LUT105L         \ Graphic MMU LUT entry 105 low
  $134C constant GFXMMU_LUT105H         \ Graphic MMU LUT entry 105 high
  $1350 constant GFXMMU_LUT106L         \ Graphic MMU LUT entry 106 low
  $1354 constant GFXMMU_LUT106H         \ Graphic MMU LUT entry 106 high
  $1358 constant GFXMMU_LUT107L         \ Graphic MMU LUT entry 107 low
  $135C constant GFXMMU_LUT107H         \ Graphic MMU LUT entry 107 high
  $1360 constant GFXMMU_LUT108L         \ Graphic MMU LUT entry 108 low
  $1364 constant GFXMMU_LUT108H         \ Graphic MMU LUT entry 108 high
  $1368 constant GFXMMU_LUT109L         \ Graphic MMU LUT entry 109 low
  $136C constant GFXMMU_LUT109H         \ Graphic MMU LUT entry 109 high
  $1370 constant GFXMMU_LUT110L         \ Graphic MMU LUT entry 110 low
  $1374 constant GFXMMU_LUT110H         \ Graphic MMU LUT entry 110 high
  $1378 constant GFXMMU_LUT111L         \ Graphic MMU LUT entry 111 low
  $137C constant GFXMMU_LUT111H         \ Graphic MMU LUT entry 111 high
  $1380 constant GFXMMU_LUT112L         \ Graphic MMU LUT entry 112 low
  $1384 constant GFXMMU_LUT112H         \ Graphic MMU LUT entry 112 high
  $1388 constant GFXMMU_LUT113L         \ Graphic MMU LUT entry 113 low
  $138C constant GFXMMU_LUT113H         \ Graphic MMU LUT entry 113 high
  $1390 constant GFXMMU_LUT114L         \ Graphic MMU LUT entry 114 low
  $1394 constant GFXMMU_LUT114H         \ Graphic MMU LUT entry 114 high
  $1398 constant GFXMMU_LUT115L         \ Graphic MMU LUT entry 115 low
  $139C constant GFXMMU_LUT115H         \ Graphic MMU LUT entry 115 high
  $13A0 constant GFXMMU_LUT116L         \ Graphic MMU LUT entry 116 low
  $13A4 constant GFXMMU_LUT116H         \ Graphic MMU LUT entry 116 high
  $13A8 constant GFXMMU_LUT117L         \ Graphic MMU LUT entry 117 low
  $13AC constant GFXMMU_LUT117H         \ Graphic MMU LUT entry 117 high
  $13B0 constant GFXMMU_LUT118L         \ Graphic MMU LUT entry 118 low
  $13B4 constant GFXMMU_LUT118H         \ Graphic MMU LUT entry 118 high
  $13B8 constant GFXMMU_LUT119L         \ Graphic MMU LUT entry 119 low
  $13BC constant GFXMMU_LUT119H         \ Graphic MMU LUT entry 119 high
  $13C0 constant GFXMMU_LUT120L         \ Graphic MMU LUT entry 120 low
  $13C4 constant GFXMMU_LUT120H         \ Graphic MMU LUT entry 120 high
  $13C8 constant GFXMMU_LUT121L         \ Graphic MMU LUT entry 121 low
  $13CC constant GFXMMU_LUT121H         \ Graphic MMU LUT entry 121 high
  $13D0 constant GFXMMU_LUT122L         \ Graphic MMU LUT entry 122 low
  $13D4 constant GFXMMU_LUT122H         \ Graphic MMU LUT entry 122 high
  $13D8 constant GFXMMU_LUT123L         \ Graphic MMU LUT entry 123 low
  $13DC constant GFXMMU_LUT123H         \ Graphic MMU LUT entry 123 high
  $13E0 constant GFXMMU_LUT124L         \ Graphic MMU LUT entry 124 low
  $13E4 constant GFXMMU_LUT124H         \ Graphic MMU LUT entry 124 high
  $13E8 constant GFXMMU_LUT125L         \ Graphic MMU LUT entry 125 low
  $13EC constant GFXMMU_LUT125H         \ Graphic MMU LUT entry 125 high
  $13F0 constant GFXMMU_LUT126L         \ Graphic MMU LUT entry 126 low
  $13F4 constant GFXMMU_LUT126H         \ Graphic MMU LUT entry 126 high
  $13F8 constant GFXMMU_LUT127L         \ Graphic MMU LUT entry 127 low
  $13FC constant GFXMMU_LUT127H         \ Graphic MMU LUT entry 127 high
  $1400 constant GFXMMU_LUT128L         \ Graphic MMU LUT entry 128 low
  $1404 constant GFXMMU_LUT128H         \ Graphic MMU LUT entry 128 high
  $1408 constant GFXMMU_LUT129L         \ Graphic MMU LUT entry 129 low
  $140C constant GFXMMU_LUT129H         \ Graphic MMU LUT entry 129 high
  $1410 constant GFXMMU_LUT130L         \ Graphic MMU LUT entry 130 low
  $1414 constant GFXMMU_LUT130H         \ Graphic MMU LUT entry 130 high
  $1418 constant GFXMMU_LUT131L         \ Graphic MMU LUT entry 131 low
  $141C constant GFXMMU_LUT131H         \ Graphic MMU LUT entry 131 high
  $1420 constant GFXMMU_LUT132L         \ Graphic MMU LUT entry 132 low
  $1424 constant GFXMMU_LUT132H         \ Graphic MMU LUT entry 132 high
  $1428 constant GFXMMU_LUT133L         \ Graphic MMU LUT entry 133 low
  $142C constant GFXMMU_LUT133H         \ Graphic MMU LUT entry 133 high
  $1430 constant GFXMMU_LUT134L         \ Graphic MMU LUT entry 134 low
  $1434 constant GFXMMU_LUT134H         \ Graphic MMU LUT entry 134 high
  $1438 constant GFXMMU_LUT135L         \ Graphic MMU LUT entry 135 low
  $143C constant GFXMMU_LUT135H         \ Graphic MMU LUT entry 135 high
  $1440 constant GFXMMU_LUT136L         \ Graphic MMU LUT entry 136 low
  $1444 constant GFXMMU_LUT136H         \ Graphic MMU LUT entry 136 high
  $1448 constant GFXMMU_LUT137L         \ Graphic MMU LUT entry 137 low
  $144C constant GFXMMU_LUT137H         \ Graphic MMU LUT entry 137 high
  $1450 constant GFXMMU_LUT138L         \ Graphic MMU LUT entry 138 low
  $1454 constant GFXMMU_LUT138H         \ Graphic MMU LUT entry 138 high
  $1458 constant GFXMMU_LUT139L         \ Graphic MMU LUT entry 139 low
  $145C constant GFXMMU_LUT139H         \ Graphic MMU LUT entry 139 high
  $1460 constant GFXMMU_LUT140L         \ Graphic MMU LUT entry 140 low
  $1464 constant GFXMMU_LUT140H         \ Graphic MMU LUT entry 140 high
  $1468 constant GFXMMU_LUT141L         \ Graphic MMU LUT entry 141 low
  $146C constant GFXMMU_LUT141H         \ Graphic MMU LUT entry 141 high
  $1470 constant GFXMMU_LUT142L         \ Graphic MMU LUT entry 142 low
  $1474 constant GFXMMU_LUT142H         \ Graphic MMU LUT entry 142 high
  $1478 constant GFXMMU_LUT143L         \ Graphic MMU LUT entry 143 low
  $147C constant GFXMMU_LUT143H         \ Graphic MMU LUT entry 143 high
  $1480 constant GFXMMU_LUT144L         \ Graphic MMU LUT entry 144 low
  $1484 constant GFXMMU_LUT144H         \ Graphic MMU LUT entry 144 high
  $1488 constant GFXMMU_LUT145L         \ Graphic MMU LUT entry 145 low
  $148C constant GFXMMU_LUT145H         \ Graphic MMU LUT entry 145 high
  $1490 constant GFXMMU_LUT146L         \ Graphic MMU LUT entry 146 low
  $1494 constant GFXMMU_LUT146H         \ Graphic MMU LUT entry 146 high
  $1498 constant GFXMMU_LUT147L         \ Graphic MMU LUT entry 147 low
  $149C constant GFXMMU_LUT147H         \ Graphic MMU LUT entry 147 high
  $14A0 constant GFXMMU_LUT148L         \ Graphic MMU LUT entry 148 low
  $14A4 constant GFXMMU_LUT148H         \ Graphic MMU LUT entry 148 high
  $14A8 constant GFXMMU_LUT149L         \ Graphic MMU LUT entry 149 low
  $14AC constant GFXMMU_LUT149H         \ Graphic MMU LUT entry 149 high
  $14B0 constant GFXMMU_LUT150L         \ Graphic MMU LUT entry 150 low
  $14B4 constant GFXMMU_LUT150H         \ Graphic MMU LUT entry 150 high
  $14B8 constant GFXMMU_LUT151L         \ Graphic MMU LUT entry 151 low
  $14BC constant GFXMMU_LUT151H         \ Graphic MMU LUT entry 151 high
  $14C0 constant GFXMMU_LUT152L         \ Graphic MMU LUT entry 152 low
  $14C4 constant GFXMMU_LUT152H         \ Graphic MMU LUT entry 152 high
  $14C8 constant GFXMMU_LUT153L         \ Graphic MMU LUT entry 153 low
  $14CC constant GFXMMU_LUT153H         \ Graphic MMU LUT entry 153 high
  $14D0 constant GFXMMU_LUT154L         \ Graphic MMU LUT entry 154 low
  $14D4 constant GFXMMU_LUT154H         \ Graphic MMU LUT entry 154 high
  $14D8 constant GFXMMU_LUT155L         \ Graphic MMU LUT entry 155 low
  $14DC constant GFXMMU_LUT155H         \ Graphic MMU LUT entry 155 high
  $14E0 constant GFXMMU_LUT156L         \ Graphic MMU LUT entry 156 low
  $14E4 constant GFXMMU_LUT156H         \ Graphic MMU LUT entry 156 high
  $14E8 constant GFXMMU_LUT157L         \ Graphic MMU LUT entry 157 low
  $14EC constant GFXMMU_LUT157H         \ Graphic MMU LUT entry 157 high
  $14F0 constant GFXMMU_LUT158L         \ Graphic MMU LUT entry 158 low
  $14F4 constant GFXMMU_LUT158H         \ Graphic MMU LUT entry 158 high
  $14F8 constant GFXMMU_LUT159L         \ Graphic MMU LUT entry 159 low
  $14FC constant GFXMMU_LUT159H         \ Graphic MMU LUT entry 159 high
  $1500 constant GFXMMU_LUT160L         \ Graphic MMU LUT entry 160 low
  $1504 constant GFXMMU_LUT160H         \ Graphic MMU LUT entry 160 high
  $1508 constant GFXMMU_LUT161L         \ Graphic MMU LUT entry 161 low
  $150C constant GFXMMU_LUT161H         \ Graphic MMU LUT entry 161 high
  $1510 constant GFXMMU_LUT162L         \ Graphic MMU LUT entry 162 low
  $1514 constant GFXMMU_LUT162H         \ Graphic MMU LUT entry 162 high
  $1518 constant GFXMMU_LUT163L         \ Graphic MMU LUT entry 163 low
  $151C constant GFXMMU_LUT163H         \ Graphic MMU LUT entry 163 high
  $1520 constant GFXMMU_LUT164L         \ Graphic MMU LUT entry 164 low
  $1524 constant GFXMMU_LUT164H         \ Graphic MMU LUT entry 164 high
  $1528 constant GFXMMU_LUT165L         \ Graphic MMU LUT entry 165 low
  $152C constant GFXMMU_LUT165H         \ Graphic MMU LUT entry 165 high
  $1530 constant GFXMMU_LUT166L         \ Graphic MMU LUT entry 166 low
  $1534 constant GFXMMU_LUT166H         \ Graphic MMU LUT entry 166 high
  $1538 constant GFXMMU_LUT167L         \ Graphic MMU LUT entry 167 low
  $153C constant GFXMMU_LUT167H         \ Graphic MMU LUT entry 167 high
  $1540 constant GFXMMU_LUT168L         \ Graphic MMU LUT entry 168 low
  $1544 constant GFXMMU_LUT168H         \ Graphic MMU LUT entry 168 high
  $1548 constant GFXMMU_LUT169L         \ Graphic MMU LUT entry 169 low
  $154C constant GFXMMU_LUT169H         \ Graphic MMU LUT entry 169 high
  $1550 constant GFXMMU_LUT170L         \ Graphic MMU LUT entry 170 low
  $1554 constant GFXMMU_LUT170H         \ Graphic MMU LUT entry 170 high
  $1558 constant GFXMMU_LUT171L         \ Graphic MMU LUT entry 171 low
  $155C constant GFXMMU_LUT171H         \ Graphic MMU LUT entry 171 high
  $1560 constant GFXMMU_LUT172L         \ Graphic MMU LUT entry 172 low
  $1564 constant GFXMMU_LUT172H         \ Graphic MMU LUT entry 172 high
  $1568 constant GFXMMU_LUT173L         \ Graphic MMU LUT entry 173 low
  $156C constant GFXMMU_LUT173H         \ Graphic MMU LUT entry 173 high
  $1570 constant GFXMMU_LUT174L         \ Graphic MMU LUT entry 174 low
  $1574 constant GFXMMU_LUT174H         \ Graphic MMU LUT entry 174 high
  $1578 constant GFXMMU_LUT175L         \ Graphic MMU LUT entry 175 low
  $157C constant GFXMMU_LUT175H         \ Graphic MMU LUT entry 175 high
  $1580 constant GFXMMU_LUT176L         \ Graphic MMU LUT entry 176 low
  $1584 constant GFXMMU_LUT176H         \ Graphic MMU LUT entry 176 high
  $1588 constant GFXMMU_LUT177L         \ Graphic MMU LUT entry 177 low
  $158C constant GFXMMU_LUT177H         \ Graphic MMU LUT entry 177 high
  $1590 constant GFXMMU_LUT178L         \ Graphic MMU LUT entry 178 low
  $1594 constant GFXMMU_LUT178H         \ Graphic MMU LUT entry 178 high
  $1598 constant GFXMMU_LUT179L         \ Graphic MMU LUT entry 179 low
  $159C constant GFXMMU_LUT179H         \ Graphic MMU LUT entry 179 high
  $15A0 constant GFXMMU_LUT180L         \ Graphic MMU LUT entry 180 low
  $15A4 constant GFXMMU_LUT180H         \ Graphic MMU LUT entry 180 high
  $15A8 constant GFXMMU_LUT181L         \ Graphic MMU LUT entry 181 low
  $15AC constant GFXMMU_LUT181H         \ Graphic MMU LUT entry 181 high
  $15B0 constant GFXMMU_LUT182L         \ Graphic MMU LUT entry 182 low
  $15B4 constant GFXMMU_LUT182H         \ Graphic MMU LUT entry 182 high
  $15B8 constant GFXMMU_LUT183L         \ Graphic MMU LUT entry 183 low
  $15BC constant GFXMMU_LUT183H         \ Graphic MMU LUT entry 183 high
  $15C0 constant GFXMMU_LUT184L         \ Graphic MMU LUT entry 184 low
  $15C4 constant GFXMMU_LUT184H         \ Graphic MMU LUT entry 184 high
  $15C8 constant GFXMMU_LUT185L         \ Graphic MMU LUT entry 185 low
  $15CC constant GFXMMU_LUT185H         \ Graphic MMU LUT entry 185 high
  $15D0 constant GFXMMU_LUT186L         \ Graphic MMU LUT entry 186 low
  $15D4 constant GFXMMU_LUT186H         \ Graphic MMU LUT entry 186 high
  $15D8 constant GFXMMU_LUT187L         \ Graphic MMU LUT entry 187 low
  $15DC constant GFXMMU_LUT187H         \ Graphic MMU LUT entry 187 high
  $15E0 constant GFXMMU_LUT188L         \ Graphic MMU LUT entry 188 low
  $15E4 constant GFXMMU_LUT188H         \ Graphic MMU LUT entry 188 high
  $15E8 constant GFXMMU_LUT189L         \ Graphic MMU LUT entry 189 low
  $15EC constant GFXMMU_LUT189H         \ Graphic MMU LUT entry 189 high
  $15F0 constant GFXMMU_LUT190L         \ Graphic MMU LUT entry 190 low
  $15F4 constant GFXMMU_LUT190H         \ Graphic MMU LUT entry 190 high
  $15F8 constant GFXMMU_LUT191L         \ Graphic MMU LUT entry 191 low
  $15FC constant GFXMMU_LUT191H         \ Graphic MMU LUT entry 191 high
  $1600 constant GFXMMU_LUT192L         \ Graphic MMU LUT entry 192 low
  $1604 constant GFXMMU_LUT192H         \ Graphic MMU LUT entry 192 high
  $1608 constant GFXMMU_LUT193L         \ Graphic MMU LUT entry 193 low
  $160C constant GFXMMU_LUT193H         \ Graphic MMU LUT entry 193 high
  $1610 constant GFXMMU_LUT194L         \ Graphic MMU LUT entry 194 low
  $1614 constant GFXMMU_LUT194H         \ Graphic MMU LUT entry 194 high
  $1618 constant GFXMMU_LUT195L         \ Graphic MMU LUT entry 195 low
  $161C constant GFXMMU_LUT195H         \ Graphic MMU LUT entry 195 high
  $1620 constant GFXMMU_LUT196L         \ Graphic MMU LUT entry 196 low
  $1624 constant GFXMMU_LUT196H         \ Graphic MMU LUT entry 196 high
  $1628 constant GFXMMU_LUT197L         \ Graphic MMU LUT entry 197 low
  $162C constant GFXMMU_LUT197H         \ Graphic MMU LUT entry 197 high
  $1630 constant GFXMMU_LUT198L         \ Graphic MMU LUT entry 198 low
  $1634 constant GFXMMU_LUT198H         \ Graphic MMU LUT entry 198 high
  $1638 constant GFXMMU_LUT199L         \ Graphic MMU LUT entry 199 low
  $163C constant GFXMMU_LUT199H         \ Graphic MMU LUT entry 199 high
  $1640 constant GFXMMU_LUT200L         \ Graphic MMU LUT entry 200 low
  $1644 constant GFXMMU_LUT200H         \ Graphic MMU LUT entry 200 high
  $1648 constant GFXMMU_LUT201L         \ Graphic MMU LUT entry 201 low
  $164C constant GFXMMU_LUT201H         \ Graphic MMU LUT entry 201 high
  $1650 constant GFXMMU_LUT202L         \ Graphic MMU LUT entry 202 low
  $1654 constant GFXMMU_LUT202H         \ Graphic MMU LUT entry 202 high
  $1658 constant GFXMMU_LUT203L         \ Graphic MMU LUT entry 203 low
  $165C constant GFXMMU_LUT203H         \ Graphic MMU LUT entry 203 high
  $1660 constant GFXMMU_LUT204L         \ Graphic MMU LUT entry 204 low
  $1664 constant GFXMMU_LUT204H         \ Graphic MMU LUT entry 204 high
  $1668 constant GFXMMU_LUT205L         \ Graphic MMU LUT entry 205 low
  $166C constant GFXMMU_LUT205H         \ Graphic MMU LUT entry 205 high
  $1670 constant GFXMMU_LUT206L         \ Graphic MMU LUT entry 206 low
  $1674 constant GFXMMU_LUT206H         \ Graphic MMU LUT entry 206 high
  $1678 constant GFXMMU_LUT207L         \ Graphic MMU LUT entry 207 low
  $167C constant GFXMMU_LUT207H         \ Graphic MMU LUT entry 207 high
  $1680 constant GFXMMU_LUT208L         \ Graphic MMU LUT entry 208 low
  $1684 constant GFXMMU_LUT208H         \ Graphic MMU LUT entry 208 high
  $1688 constant GFXMMU_LUT209L         \ Graphic MMU LUT entry 209 low
  $168C constant GFXMMU_LUT209H         \ Graphic MMU LUT entry 209 high
  $1690 constant GFXMMU_LUT210L         \ Graphic MMU LUT entry 210 low
  $1694 constant GFXMMU_LUT210H         \ Graphic MMU LUT entry 210 high
  $1698 constant GFXMMU_LUT211L         \ Graphic MMU LUT entry 211 low
  $169C constant GFXMMU_LUT211H         \ Graphic MMU LUT entry 211 high
  $16A0 constant GFXMMU_LUT212L         \ Graphic MMU LUT entry 212 low
  $16A4 constant GFXMMU_LUT212H         \ Graphic MMU LUT entry 212 high
  $16A8 constant GFXMMU_LUT213L         \ Graphic MMU LUT entry 213 low
  $16AC constant GFXMMU_LUT213H         \ Graphic MMU LUT entry 213 high
  $16B0 constant GFXMMU_LUT214L         \ Graphic MMU LUT entry 214 low
  $16B4 constant GFXMMU_LUT214H         \ Graphic MMU LUT entry 214 high
  $16B8 constant GFXMMU_LUT215L         \ Graphic MMU LUT entry 215 low
  $16BC constant GFXMMU_LUT215H         \ Graphic MMU LUT entry 215 high
  $16C0 constant GFXMMU_LUT216L         \ Graphic MMU LUT entry 216 low
  $16C4 constant GFXMMU_LUT216H         \ Graphic MMU LUT entry 216 high
  $16C8 constant GFXMMU_LUT217L         \ Graphic MMU LUT entry 217 low
  $16CC constant GFXMMU_LUT217H         \ Graphic MMU LUT entry 217 high
  $16D0 constant GFXMMU_LUT218L         \ Graphic MMU LUT entry 218 low
  $16D4 constant GFXMMU_LUT218H         \ Graphic MMU LUT entry 218 high
  $16D8 constant GFXMMU_LUT219L         \ Graphic MMU LUT entry 219 low
  $16DC constant GFXMMU_LUT219H         \ Graphic MMU LUT entry 219 high
  $16E0 constant GFXMMU_LUT220L         \ Graphic MMU LUT entry 220 low
  $16E4 constant GFXMMU_LUT220H         \ Graphic MMU LUT entry 220 high
  $16E8 constant GFXMMU_LUT221L         \ Graphic MMU LUT entry 221 low
  $16EC constant GFXMMU_LUT221H         \ Graphic MMU LUT entry 221 high
  $16F0 constant GFXMMU_LUT222L         \ Graphic MMU LUT entry 222 low
  $16F4 constant GFXMMU_LUT222H         \ Graphic MMU LUT entry 222 high
  $16F8 constant GFXMMU_LUT223L         \ Graphic MMU LUT entry 223 low
  $16FC constant GFXMMU_LUT223H         \ Graphic MMU LUT entry 223 high
  $1700 constant GFXMMU_LUT224L         \ Graphic MMU LUT entry 224 low
  $1704 constant GFXMMU_LUT224H         \ Graphic MMU LUT entry 224 high
  $1708 constant GFXMMU_LUT225L         \ Graphic MMU LUT entry 225 low
  $170C constant GFXMMU_LUT225H         \ Graphic MMU LUT entry 225 high
  $1710 constant GFXMMU_LUT226L         \ Graphic MMU LUT entry 226 low
  $1714 constant GFXMMU_LUT226H         \ Graphic MMU LUT entry 226 high
  $1718 constant GFXMMU_LUT227L         \ Graphic MMU LUT entry 227 low
  $171C constant GFXMMU_LUT227H         \ Graphic MMU LUT entry 227 high
  $1720 constant GFXMMU_LUT228L         \ Graphic MMU LUT entry 228 low
  $1724 constant GFXMMU_LUT228H         \ Graphic MMU LUT entry 228 high
  $1728 constant GFXMMU_LUT229L         \ Graphic MMU LUT entry 229 low
  $172C constant GFXMMU_LUT229H         \ Graphic MMU LUT entry 229 high
  $1730 constant GFXMMU_LUT230L         \ Graphic MMU LUT entry 230 low
  $1734 constant GFXMMU_LUT230H         \ Graphic MMU LUT entry 230 high
  $1738 constant GFXMMU_LUT231L         \ Graphic MMU LUT entry 231 low
  $173C constant GFXMMU_LUT231H         \ Graphic MMU LUT entry 231 high
  $1740 constant GFXMMU_LUT232L         \ Graphic MMU LUT entry 232 low
  $1744 constant GFXMMU_LUT232H         \ Graphic MMU LUT entry 232 high
  $1748 constant GFXMMU_LUT233L         \ Graphic MMU LUT entry 233 low
  $174C constant GFXMMU_LUT233H         \ Graphic MMU LUT entry 233 high
  $1750 constant GFXMMU_LUT234L         \ Graphic MMU LUT entry 234 low
  $1754 constant GFXMMU_LUT234H         \ Graphic MMU LUT entry 234 high
  $1758 constant GFXMMU_LUT235L         \ Graphic MMU LUT entry 235 low
  $175C constant GFXMMU_LUT235H         \ Graphic MMU LUT entry 235 high
  $1760 constant GFXMMU_LUT236L         \ Graphic MMU LUT entry 236 low
  $1764 constant GFXMMU_LUT236H         \ Graphic MMU LUT entry 236 high
  $1768 constant GFXMMU_LUT237L         \ Graphic MMU LUT entry 237 low
  $176C constant GFXMMU_LUT237H         \ Graphic MMU LUT entry 237 high
  $1770 constant GFXMMU_LUT238L         \ Graphic MMU LUT entry 238 low
  $1774 constant GFXMMU_LUT238H         \ Graphic MMU LUT entry 238 high
  $1778 constant GFXMMU_LUT239L         \ Graphic MMU LUT entry 239 low
  $177C constant GFXMMU_LUT239H         \ Graphic MMU LUT entry 239 high
  $1780 constant GFXMMU_LUT240L         \ Graphic MMU LUT entry 240 low
  $1784 constant GFXMMU_LUT240H         \ Graphic MMU LUT entry 240 high
  $1788 constant GFXMMU_LUT241L         \ Graphic MMU LUT entry 241 low
  $178C constant GFXMMU_LUT241H         \ Graphic MMU LUT entry 241 high
  $1790 constant GFXMMU_LUT242L         \ Graphic MMU LUT entry 242 low
  $1794 constant GFXMMU_LUT242H         \ Graphic MMU LUT entry 242 high
  $1798 constant GFXMMU_LUT243L         \ Graphic MMU LUT entry 243 low
  $179C constant GFXMMU_LUT243H         \ Graphic MMU LUT entry 243 high
  $17A0 constant GFXMMU_LUT244L         \ Graphic MMU LUT entry 244 low
  $17A4 constant GFXMMU_LUT244H         \ Graphic MMU LUT entry 244 high
  $17A8 constant GFXMMU_LUT245L         \ Graphic MMU LUT entry 245 low
  $17AC constant GFXMMU_LUT245H         \ Graphic MMU LUT entry 245 high
  $17B0 constant GFXMMU_LUT246L         \ Graphic MMU LUT entry 246 low
  $17B4 constant GFXMMU_LUT246H         \ Graphic MMU LUT entry 246 high
  $17B8 constant GFXMMU_LUT247L         \ Graphic MMU LUT entry 247 low
  $17BC constant GFXMMU_LUT247H         \ Graphic MMU LUT entry 247 high
  $17C0 constant GFXMMU_LUT248L         \ Graphic MMU LUT entry 248 low
  $17C4 constant GFXMMU_LUT248H         \ Graphic MMU LUT entry 248 high
  $17C8 constant GFXMMU_LUT249L         \ Graphic MMU LUT entry 249 low
  $17CC constant GFXMMU_LUT249H         \ Graphic MMU LUT entry 249 high
  $17D0 constant GFXMMU_LUT250L         \ Graphic MMU LUT entry 250 low
  $17D4 constant GFXMMU_LUT250H         \ Graphic MMU LUT entry 250 high
  $17D8 constant GFXMMU_LUT251L         \ Graphic MMU LUT entry 251 low
  $17DC constant GFXMMU_LUT251H         \ Graphic MMU LUT entry 251 high
  $17E0 constant GFXMMU_LUT252L         \ Graphic MMU LUT entry 252 low
  $17E4 constant GFXMMU_LUT252H         \ Graphic MMU LUT entry 252 high
  $17E8 constant GFXMMU_LUT253L         \ Graphic MMU LUT entry 253 low
  $17EC constant GFXMMU_LUT253H         \ Graphic MMU LUT entry 253 high
  $17F0 constant GFXMMU_LUT254L         \ Graphic MMU LUT entry 254 low
  $17F4 constant GFXMMU_LUT254H         \ Graphic MMU LUT entry 254 high
  $17F8 constant GFXMMU_LUT255L         \ Graphic MMU LUT entry 255 low
  $17FC constant GFXMMU_LUT255H         \ Graphic MMU LUT entry 255 high
  $1800 constant GFXMMU_LUT256L         \ Graphic MMU LUT entry 256 low
  $1804 constant GFXMMU_LUT256H         \ Graphic MMU LUT entry 256 high
  $1808 constant GFXMMU_LUT257L         \ Graphic MMU LUT entry 257 low
  $180C constant GFXMMU_LUT257H         \ Graphic MMU LUT entry 257 high
  $1810 constant GFXMMU_LUT258L         \ Graphic MMU LUT entry 258 low
  $1814 constant GFXMMU_LUT258H         \ Graphic MMU LUT entry 258 high
  $1818 constant GFXMMU_LUT259L         \ Graphic MMU LUT entry 259 low
  $181C constant GFXMMU_LUT259H         \ Graphic MMU LUT entry 259 high
  $1820 constant GFXMMU_LUT260L         \ Graphic MMU LUT entry 260 low
  $1824 constant GFXMMU_LUT260H         \ Graphic MMU LUT entry 260 high
  $1828 constant GFXMMU_LUT261L         \ Graphic MMU LUT entry 261 low
  $182C constant GFXMMU_LUT261H         \ Graphic MMU LUT entry 261 high
  $1830 constant GFXMMU_LUT262L         \ Graphic MMU LUT entry 262 low
  $1834 constant GFXMMU_LUT262H         \ Graphic MMU LUT entry 262 high
  $1838 constant GFXMMU_LUT263L         \ Graphic MMU LUT entry 263 low
  $183C constant GFXMMU_LUT263H         \ Graphic MMU LUT entry 263 high
  $1840 constant GFXMMU_LUT264L         \ Graphic MMU LUT entry 264 low
  $1844 constant GFXMMU_LUT264H         \ Graphic MMU LUT entry 264 high
  $1848 constant GFXMMU_LUT265L         \ Graphic MMU LUT entry 265 low
  $184C constant GFXMMU_LUT265H         \ Graphic MMU LUT entry 265 high
  $1850 constant GFXMMU_LUT266L         \ Graphic MMU LUT entry 266 low
  $1854 constant GFXMMU_LUT266H         \ Graphic MMU LUT entry 266 high
  $1858 constant GFXMMU_LUT267L         \ Graphic MMU LUT entry 267 low
  $185C constant GFXMMU_LUT267H         \ Graphic MMU LUT entry 267 high
  $1860 constant GFXMMU_LUT268L         \ Graphic MMU LUT entry 268 low
  $1864 constant GFXMMU_LUT268H         \ Graphic MMU LUT entry 268 high
  $1868 constant GFXMMU_LUT269L         \ Graphic MMU LUT entry 269 low
  $186C constant GFXMMU_LUT269H         \ Graphic MMU LUT entry 269 high
  $1870 constant GFXMMU_LUT270L         \ Graphic MMU LUT entry 270 low
  $1874 constant GFXMMU_LUT270H         \ Graphic MMU LUT entry 270 high
  $1878 constant GFXMMU_LUT271L         \ Graphic MMU LUT entry 271 low
  $187C constant GFXMMU_LUT271H         \ Graphic MMU LUT entry 271 high
  $1880 constant GFXMMU_LUT272L         \ Graphic MMU LUT entry 272 low
  $1884 constant GFXMMU_LUT272H         \ Graphic MMU LUT entry 272 high
  $1888 constant GFXMMU_LUT273L         \ Graphic MMU LUT entry 273 low
  $188C constant GFXMMU_LUT273H         \ Graphic MMU LUT entry 273 high
  $1890 constant GFXMMU_LUT274L         \ Graphic MMU LUT entry 274 low
  $1894 constant GFXMMU_LUT274H         \ Graphic MMU LUT entry 274 high
  $1898 constant GFXMMU_LUT275L         \ Graphic MMU LUT entry 275 low
  $189C constant GFXMMU_LUT275H         \ Graphic MMU LUT entry 275 high
  $18A0 constant GFXMMU_LUT276L         \ Graphic MMU LUT entry 276 low
  $18A4 constant GFXMMU_LUT276H         \ Graphic MMU LUT entry 276 high
  $18A8 constant GFXMMU_LUT277L         \ Graphic MMU LUT entry 277 low
  $18AC constant GFXMMU_LUT277H         \ Graphic MMU LUT entry 277 high
  $18B0 constant GFXMMU_LUT278L         \ Graphic MMU LUT entry 278 low
  $18B4 constant GFXMMU_LUT278H         \ Graphic MMU LUT entry 278 high
  $18B8 constant GFXMMU_LUT279L         \ Graphic MMU LUT entry 279 low
  $18BC constant GFXMMU_LUT279H         \ Graphic MMU LUT entry 279 high
  $18C0 constant GFXMMU_LUT280L         \ Graphic MMU LUT entry 280 low
  $18C4 constant GFXMMU_LUT280H         \ Graphic MMU LUT entry 280 high
  $18C8 constant GFXMMU_LUT281L         \ Graphic MMU LUT entry 281 low
  $18CC constant GFXMMU_LUT281H         \ Graphic MMU LUT entry 281 high
  $18D0 constant GFXMMU_LUT282L         \ Graphic MMU LUT entry 282 low
  $18D4 constant GFXMMU_LUT282H         \ Graphic MMU LUT entry 282 high
  $18D8 constant GFXMMU_LUT283L         \ Graphic MMU LUT entry 283 low
  $18DC constant GFXMMU_LUT283H         \ Graphic MMU LUT entry 283 high
  $18E0 constant GFXMMU_LUT284L         \ Graphic MMU LUT entry 284 low
  $18E4 constant GFXMMU_LUT284H         \ Graphic MMU LUT entry 284 high
  $18E8 constant GFXMMU_LUT285L         \ Graphic MMU LUT entry 285 low
  $18EC constant GFXMMU_LUT285H         \ Graphic MMU LUT entry 285 high
  $18F0 constant GFXMMU_LUT286L         \ Graphic MMU LUT entry 286 low
  $18F4 constant GFXMMU_LUT286H         \ Graphic MMU LUT entry 286 high
  $18F8 constant GFXMMU_LUT287L         \ Graphic MMU LUT entry 287 low
  $18FC constant GFXMMU_LUT287H         \ Graphic MMU LUT entry 287 high
  $1900 constant GFXMMU_LUT288L         \ Graphic MMU LUT entry 288 low
  $1904 constant GFXMMU_LUT288H         \ Graphic MMU LUT entry 288 high
  $1908 constant GFXMMU_LUT289L         \ Graphic MMU LUT entry 289 low
  $190C constant GFXMMU_LUT289H         \ Graphic MMU LUT entry 289 high
  $1910 constant GFXMMU_LUT290L         \ Graphic MMU LUT entry 290 low
  $1914 constant GFXMMU_LUT290H         \ Graphic MMU LUT entry 290 high
  $1918 constant GFXMMU_LUT291L         \ Graphic MMU LUT entry 291 low
  $191C constant GFXMMU_LUT291H         \ Graphic MMU LUT entry 291 high
  $1920 constant GFXMMU_LUT292L         \ Graphic MMU LUT entry 292 low
  $1924 constant GFXMMU_LUT292H         \ Graphic MMU LUT entry 292 high
  $1928 constant GFXMMU_LUT293L         \ Graphic MMU LUT entry 293 low
  $192C constant GFXMMU_LUT293H         \ Graphic MMU LUT entry 293 high
  $1930 constant GFXMMU_LUT294L         \ Graphic MMU LUT entry 294 low
  $1934 constant GFXMMU_LUT294H         \ Graphic MMU LUT entry 294 high
  $1938 constant GFXMMU_LUT295L         \ Graphic MMU LUT entry 295 low
  $193C constant GFXMMU_LUT295H         \ Graphic MMU LUT entry 295 high
  $1940 constant GFXMMU_LUT296L         \ Graphic MMU LUT entry 296 low
  $1944 constant GFXMMU_LUT296H         \ Graphic MMU LUT entry 296 high
  $1948 constant GFXMMU_LUT297L         \ Graphic MMU LUT entry 297 low
  $194C constant GFXMMU_LUT297H         \ Graphic MMU LUT entry 297 high
  $1950 constant GFXMMU_LUT298L         \ Graphic MMU LUT entry 298 low
  $1954 constant GFXMMU_LUT298H         \ Graphic MMU LUT entry 298 high
  $1958 constant GFXMMU_LUT299L         \ Graphic MMU LUT entry 299 low
  $195C constant GFXMMU_LUT299H         \ Graphic MMU LUT entry 299 high
  $1960 constant GFXMMU_LUT300L         \ Graphic MMU LUT entry 300 low
  $1964 constant GFXMMU_LUT300H         \ Graphic MMU LUT entry 300 high
  $1968 constant GFXMMU_LUT301L         \ Graphic MMU LUT entry 301 low
  $196C constant GFXMMU_LUT301H         \ Graphic MMU LUT entry 301 high
  $1970 constant GFXMMU_LUT302L         \ Graphic MMU LUT entry 302 low
  $1974 constant GFXMMU_LUT302H         \ Graphic MMU LUT entry 302 high
  $1978 constant GFXMMU_LUT303L         \ Graphic MMU LUT entry 303 low
  $197C constant GFXMMU_LUT303H         \ Graphic MMU LUT entry 303 high
  $1980 constant GFXMMU_LUT304L         \ Graphic MMU LUT entry 304 low
  $1984 constant GFXMMU_LUT304H         \ Graphic MMU LUT entry 304 high
  $1988 constant GFXMMU_LUT305L         \ Graphic MMU LUT entry 305 low
  $198C constant GFXMMU_LUT305H         \ Graphic MMU LUT entry 305 high
  $1990 constant GFXMMU_LUT306L         \ Graphic MMU LUT entry 306 low
  $1994 constant GFXMMU_LUT306H         \ Graphic MMU LUT entry 306 high
  $1998 constant GFXMMU_LUT307L         \ Graphic MMU LUT entry 307 low
  $199C constant GFXMMU_LUT307H         \ Graphic MMU LUT entry 307 high
  $19A0 constant GFXMMU_LUT308L         \ Graphic MMU LUT entry 308 low
  $19A4 constant GFXMMU_LUT308H         \ Graphic MMU LUT entry 308 high
  $19A8 constant GFXMMU_LUT309L         \ Graphic MMU LUT entry 309 low
  $19AC constant GFXMMU_LUT309H         \ Graphic MMU LUT entry 309 high
  $19B0 constant GFXMMU_LUT310L         \ Graphic MMU LUT entry 310 low
  $19B4 constant GFXMMU_LUT310H         \ Graphic MMU LUT entry 310 high
  $19B8 constant GFXMMU_LUT311L         \ Graphic MMU LUT entry 311 low
  $19BC constant GFXMMU_LUT311H         \ Graphic MMU LUT entry 311 high
  $19C0 constant GFXMMU_LUT312L         \ Graphic MMU LUT entry 312 low
  $19C4 constant GFXMMU_LUT312H         \ Graphic MMU LUT entry 312 high
  $19C8 constant GFXMMU_LUT313L         \ Graphic MMU LUT entry 313 low
  $19CC constant GFXMMU_LUT313H         \ Graphic MMU LUT entry 313 high
  $19D0 constant GFXMMU_LUT314L         \ Graphic MMU LUT entry 314 low
  $19D4 constant GFXMMU_LUT314H         \ Graphic MMU LUT entry 314 high
  $19D8 constant GFXMMU_LUT315L         \ Graphic MMU LUT entry 315 low
  $19DC constant GFXMMU_LUT315H         \ Graphic MMU LUT entry 315 high
  $19E0 constant GFXMMU_LUT316L         \ Graphic MMU LUT entry 316 low
  $19E4 constant GFXMMU_LUT316H         \ Graphic MMU LUT entry 316 high
  $19E8 constant GFXMMU_LUT317L         \ Graphic MMU LUT entry 317 low
  $19EC constant GFXMMU_LUT317H         \ Graphic MMU LUT entry 317 high
  $19F0 constant GFXMMU_LUT318L         \ Graphic MMU LUT entry 318 low
  $19F4 constant GFXMMU_LUT318H         \ Graphic MMU LUT entry 318 high
  $19F8 constant GFXMMU_LUT319L         \ Graphic MMU LUT entry 319 low
  $19FC constant GFXMMU_LUT319H         \ Graphic MMU LUT entry 319 high
  $1A00 constant GFXMMU_LUT320L         \ Graphic MMU LUT entry 320 low
  $1A04 constant GFXMMU_LUT320H         \ Graphic MMU LUT entry 320 high
  $1A08 constant GFXMMU_LUT321L         \ Graphic MMU LUT entry 321 low
  $1A0C constant GFXMMU_LUT321H         \ Graphic MMU LUT entry 321 high
  $1A10 constant GFXMMU_LUT322L         \ Graphic MMU LUT entry 322 low
  $1A14 constant GFXMMU_LUT322H         \ Graphic MMU LUT entry 322 high
  $1A18 constant GFXMMU_LUT323L         \ Graphic MMU LUT entry 323 low
  $1A1C constant GFXMMU_LUT323H         \ Graphic MMU LUT entry 323 high
  $1A20 constant GFXMMU_LUT324L         \ Graphic MMU LUT entry 324 low
  $1A24 constant GFXMMU_LUT324H         \ Graphic MMU LUT entry 324 high
  $1A28 constant GFXMMU_LUT325L         \ Graphic MMU LUT entry 325 low
  $1A2C constant GFXMMU_LUT325H         \ Graphic MMU LUT entry 325 high
  $1A30 constant GFXMMU_LUT326L         \ Graphic MMU LUT entry 326 low
  $1A34 constant GFXMMU_LUT326H         \ Graphic MMU LUT entry 326 high
  $1A38 constant GFXMMU_LUT327L         \ Graphic MMU LUT entry 327 low
  $1A3C constant GFXMMU_LUT327H         \ Graphic MMU LUT entry 327 high
  $1A40 constant GFXMMU_LUT328L         \ Graphic MMU LUT entry 328 low
  $1A44 constant GFXMMU_LUT328H         \ Graphic MMU LUT entry 328 high
  $1A48 constant GFXMMU_LUT329L         \ Graphic MMU LUT entry 329 low
  $1A4C constant GFXMMU_LUT329H         \ Graphic MMU LUT entry 329 high
  $1A50 constant GFXMMU_LUT330L         \ Graphic MMU LUT entry 330 low
  $1A54 constant GFXMMU_LUT330H         \ Graphic MMU LUT entry 330 high
  $1A58 constant GFXMMU_LUT331L         \ Graphic MMU LUT entry 331 low
  $1A5C constant GFXMMU_LUT331H         \ Graphic MMU LUT entry 331 high
  $1A60 constant GFXMMU_LUT332L         \ Graphic MMU LUT entry 332 low
  $1A64 constant GFXMMU_LUT332H         \ Graphic MMU LUT entry 332 high
  $1A68 constant GFXMMU_LUT333L         \ Graphic MMU LUT entry 333 low
  $1A6C constant GFXMMU_LUT333H         \ Graphic MMU LUT entry 333 high
  $1A70 constant GFXMMU_LUT334L         \ Graphic MMU LUT entry 334 low
  $1A74 constant GFXMMU_LUT334H         \ Graphic MMU LUT entry 334 high
  $1A78 constant GFXMMU_LUT335L         \ Graphic MMU LUT entry 335 low
  $1A7C constant GFXMMU_LUT335H         \ Graphic MMU LUT entry 335 high
  $1A80 constant GFXMMU_LUT336L         \ Graphic MMU LUT entry 336 low
  $1A84 constant GFXMMU_LUT336H         \ Graphic MMU LUT entry 336 high
  $1A88 constant GFXMMU_LUT337L         \ Graphic MMU LUT entry 337 low
  $1A8C constant GFXMMU_LUT337H         \ Graphic MMU LUT entry 337 high
  $1A90 constant GFXMMU_LUT338L         \ Graphic MMU LUT entry 338 low
  $1A94 constant GFXMMU_LUT338H         \ Graphic MMU LUT entry 338 high
  $1A98 constant GFXMMU_LUT339L         \ Graphic MMU LUT entry 339 low
  $1A9C constant GFXMMU_LUT339H         \ Graphic MMU LUT entry 339 high
  $1AA0 constant GFXMMU_LUT340L         \ Graphic MMU LUT entry 340 low
  $1AA4 constant GFXMMU_LUT340H         \ Graphic MMU LUT entry 340 high
  $1AA8 constant GFXMMU_LUT341L         \ Graphic MMU LUT entry 341 low
  $1AAC constant GFXMMU_LUT341H         \ Graphic MMU LUT entry 341 high
  $1AB0 constant GFXMMU_LUT342L         \ Graphic MMU LUT entry 342 low
  $1AB4 constant GFXMMU_LUT342H         \ Graphic MMU LUT entry 342 high
  $1AB8 constant GFXMMU_LUT343L         \ Graphic MMU LUT entry 343 low
  $1ABC constant GFXMMU_LUT343H         \ Graphic MMU LUT entry 343 high
  $1AC0 constant GFXMMU_LUT344L         \ Graphic MMU LUT entry 344 low
  $1AC4 constant GFXMMU_LUT344H         \ Graphic MMU LUT entry 344 high
  $1AC8 constant GFXMMU_LUT345L         \ Graphic MMU LUT entry 345 low
  $1ACC constant GFXMMU_LUT345H         \ Graphic MMU LUT entry 345 high
  $1AD0 constant GFXMMU_LUT346L         \ Graphic MMU LUT entry 346 low
  $1AD4 constant GFXMMU_LUT346H         \ Graphic MMU LUT entry 346 high
  $1AD8 constant GFXMMU_LUT347L         \ Graphic MMU LUT entry 347 low
  $1ADC constant GFXMMU_LUT347H         \ Graphic MMU LUT entry 347 high
  $1AE0 constant GFXMMU_LUT348L         \ Graphic MMU LUT entry 348 low
  $1AE4 constant GFXMMU_LUT348H         \ Graphic MMU LUT entry 348 high
  $1AE8 constant GFXMMU_LUT349L         \ Graphic MMU LUT entry 349 low
  $1AEC constant GFXMMU_LUT349H         \ Graphic MMU LUT entry 349 high
  $1AF0 constant GFXMMU_LUT350L         \ Graphic MMU LUT entry 350 low
  $1AF4 constant GFXMMU_LUT350H         \ Graphic MMU LUT entry 350 high
  $1AF8 constant GFXMMU_LUT351L         \ Graphic MMU LUT entry 351 low
  $1AFC constant GFXMMU_LUT351H         \ Graphic MMU LUT entry 351 high
  $1B00 constant GFXMMU_LUT352L         \ Graphic MMU LUT entry 352 low
  $1B04 constant GFXMMU_LUT352H         \ Graphic MMU LUT entry 352 high
  $1B08 constant GFXMMU_LUT353L         \ Graphic MMU LUT entry 353 low
  $1B0C constant GFXMMU_LUT353H         \ Graphic MMU LUT entry 353 high
  $1B10 constant GFXMMU_LUT354L         \ Graphic MMU LUT entry 354 low
  $1B14 constant GFXMMU_LUT354H         \ Graphic MMU LUT entry 354 high
  $1B18 constant GFXMMU_LUT355L         \ Graphic MMU LUT entry 355 low
  $1B1C constant GFXMMU_LUT355H         \ Graphic MMU LUT entry 355 high
  $1B20 constant GFXMMU_LUT356L         \ Graphic MMU LUT entry 356 low
  $1B24 constant GFXMMU_LUT356H         \ Graphic MMU LUT entry 356 high
  $1B28 constant GFXMMU_LUT357L         \ Graphic MMU LUT entry 357 low
  $1B2C constant GFXMMU_LUT357H         \ Graphic MMU LUT entry 357 high
  $1B30 constant GFXMMU_LUT358L         \ Graphic MMU LUT entry 358 low
  $1B34 constant GFXMMU_LUT358H         \ Graphic MMU LUT entry 358 high
  $1B38 constant GFXMMU_LUT359L         \ Graphic MMU LUT entry 359 low
  $1B3C constant GFXMMU_LUT359H         \ Graphic MMU LUT entry 359 high
  $1B40 constant GFXMMU_LUT360L         \ Graphic MMU LUT entry 360 low
  $1B44 constant GFXMMU_LUT360H         \ Graphic MMU LUT entry 360 high
  $1B48 constant GFXMMU_LUT361L         \ Graphic MMU LUT entry 361 low
  $1B4C constant GFXMMU_LUT361H         \ Graphic MMU LUT entry 361 high
  $1B50 constant GFXMMU_LUT362L         \ Graphic MMU LUT entry 362 low
  $1B54 constant GFXMMU_LUT362H         \ Graphic MMU LUT entry 362 high
  $1B58 constant GFXMMU_LUT363L         \ Graphic MMU LUT entry 363 low
  $1B5C constant GFXMMU_LUT363H         \ Graphic MMU LUT entry 363 high
  $1B60 constant GFXMMU_LUT364L         \ Graphic MMU LUT entry 364 low
  $1B64 constant GFXMMU_LUT364H         \ Graphic MMU LUT entry 364 high
  $1B68 constant GFXMMU_LUT365L         \ Graphic MMU LUT entry 365 low
  $1B6C constant GFXMMU_LUT365H         \ Graphic MMU LUT entry 365 high
  $1B70 constant GFXMMU_LUT366L         \ Graphic MMU LUT entry 366 low
  $1B74 constant GFXMMU_LUT366H         \ Graphic MMU LUT entry 366 high
  $1B78 constant GFXMMU_LUT367L         \ Graphic MMU LUT entry 367 low
  $1B7C constant GFXMMU_LUT367H         \ Graphic MMU LUT entry 367 high
  $1B80 constant GFXMMU_LUT368L         \ Graphic MMU LUT entry 368 low
  $1B84 constant GFXMMU_LUT368H         \ Graphic MMU LUT entry 368 high
  $1B88 constant GFXMMU_LUT369L         \ Graphic MMU LUT entry 369 low
  $1B8C constant GFXMMU_LUT369H         \ Graphic MMU LUT entry 369 high
  $1B90 constant GFXMMU_LUT370L         \ Graphic MMU LUT entry 370 low
  $1B94 constant GFXMMU_LUT370H         \ Graphic MMU LUT entry 370 high
  $1B98 constant GFXMMU_LUT371L         \ Graphic MMU LUT entry 371 low
  $1B9C constant GFXMMU_LUT371H         \ Graphic MMU LUT entry 371 high
  $1BA0 constant GFXMMU_LUT372L         \ Graphic MMU LUT entry 372 low
  $1BA4 constant GFXMMU_LUT372H         \ Graphic MMU LUT entry 372 high
  $1BA8 constant GFXMMU_LUT373L         \ Graphic MMU LUT entry 373 low
  $1BAC constant GFXMMU_LUT373H         \ Graphic MMU LUT entry 373 high
  $1BB0 constant GFXMMU_LUT374L         \ Graphic MMU LUT entry 374 low
  $1BB4 constant GFXMMU_LUT374H         \ Graphic MMU LUT entry 374 high
  $1BB8 constant GFXMMU_LUT375L         \ Graphic MMU LUT entry 375 low
  $1BBC constant GFXMMU_LUT375H         \ Graphic MMU LUT entry 375 high
  $1BC0 constant GFXMMU_LUT376L         \ Graphic MMU LUT entry 376 low
  $1BC4 constant GFXMMU_LUT376H         \ Graphic MMU LUT entry 376 high
  $1BC8 constant GFXMMU_LUT377L         \ Graphic MMU LUT entry 377 low
  $1BCC constant GFXMMU_LUT377H         \ Graphic MMU LUT entry 377 high
  $1BD0 constant GFXMMU_LUT378L         \ Graphic MMU LUT entry 378 low
  $1BD4 constant GFXMMU_LUT378H         \ Graphic MMU LUT entry 378 high
  $1BD8 constant GFXMMU_LUT379L         \ Graphic MMU LUT entry 379 low
  $1BDC constant GFXMMU_LUT379H         \ Graphic MMU LUT entry 379 high
  $1BE0 constant GFXMMU_LUT380L         \ Graphic MMU LUT entry 380 low
  $1BE4 constant GFXMMU_LUT380H         \ Graphic MMU LUT entry 380 high
  $1BE8 constant GFXMMU_LUT381L         \ Graphic MMU LUT entry 381 low
  $1BEC constant GFXMMU_LUT381H         \ Graphic MMU LUT entry 381 high
  $1BF0 constant GFXMMU_LUT382L         \ Graphic MMU LUT entry 382 low
  $1BF4 constant GFXMMU_LUT382H         \ Graphic MMU LUT entry 382 high
  $1BF8 constant GFXMMU_LUT383L         \ Graphic MMU LUT entry 383 low
  $1BFC constant GFXMMU_LUT383H         \ Graphic MMU LUT entry 383 high
  $1C00 constant GFXMMU_LUT384L         \ Graphic MMU LUT entry 384 low
  $1C04 constant GFXMMU_LUT384H         \ Graphic MMU LUT entry 384 high
  $1C08 constant GFXMMU_LUT385L         \ Graphic MMU LUT entry 385 low
  $1C0C constant GFXMMU_LUT385H         \ Graphic MMU LUT entry 385 high
  $1C10 constant GFXMMU_LUT386L         \ Graphic MMU LUT entry 386 low
  $1C14 constant GFXMMU_LUT386H         \ Graphic MMU LUT entry 386 high
  $1C18 constant GFXMMU_LUT387L         \ Graphic MMU LUT entry 387 low
  $1C1C constant GFXMMU_LUT387H         \ Graphic MMU LUT entry 387 high
  $1C20 constant GFXMMU_LUT388L         \ Graphic MMU LUT entry 388 low
  $1C24 constant GFXMMU_LUT388H         \ Graphic MMU LUT entry 388 high
  $1C28 constant GFXMMU_LUT389L         \ Graphic MMU LUT entry 389 low
  $1C2C constant GFXMMU_LUT389H         \ Graphic MMU LUT entry 389 high
  $1C30 constant GFXMMU_LUT390L         \ Graphic MMU LUT entry 390 low
  $1C34 constant GFXMMU_LUT390H         \ Graphic MMU LUT entry 390 high
  $1C38 constant GFXMMU_LUT391L         \ Graphic MMU LUT entry 391 low
  $1C3C constant GFXMMU_LUT391H         \ Graphic MMU LUT entry 391 high
  $1C40 constant GFXMMU_LUT392L         \ Graphic MMU LUT entry 392 low
  $1C44 constant GFXMMU_LUT392H         \ Graphic MMU LUT entry 392 high
  $1C48 constant GFXMMU_LUT393L         \ Graphic MMU LUT entry 393 low
  $1C4C constant GFXMMU_LUT393H         \ Graphic MMU LUT entry 393 high
  $1C50 constant GFXMMU_LUT394L         \ Graphic MMU LUT entry 394 low
  $1C54 constant GFXMMU_LUT394H         \ Graphic MMU LUT entry 394 high
  $1C58 constant GFXMMU_LUT395L         \ Graphic MMU LUT entry 395 low
  $1C5C constant GFXMMU_LUT395H         \ Graphic MMU LUT entry 395 high
  $1C60 constant GFXMMU_LUT396L         \ Graphic MMU LUT entry 396 low
  $1C64 constant GFXMMU_LUT396H         \ Graphic MMU LUT entry 396 high
  $1C68 constant GFXMMU_LUT397L         \ Graphic MMU LUT entry 397 low
  $1C6C constant GFXMMU_LUT397H         \ Graphic MMU LUT entry 397 high
  $1C70 constant GFXMMU_LUT398L         \ Graphic MMU LUT entry 398 low
  $1C74 constant GFXMMU_LUT398H         \ Graphic MMU LUT entry 398 high
  $1C78 constant GFXMMU_LUT399L         \ Graphic MMU LUT entry 399 low
  $1C7C constant GFXMMU_LUT399H         \ Graphic MMU LUT entry 399 high
  $1C80 constant GFXMMU_LUT400L         \ Graphic MMU LUT entry 400 low
  $1C84 constant GFXMMU_LUT400H         \ Graphic MMU LUT entry 400 high
  $1C88 constant GFXMMU_LUT401L         \ Graphic MMU LUT entry 401 low
  $1C8C constant GFXMMU_LUT401H         \ Graphic MMU LUT entry 401 high
  $1C90 constant GFXMMU_LUT402L         \ Graphic MMU LUT entry 402 low
  $1C94 constant GFXMMU_LUT402H         \ Graphic MMU LUT entry 402 high
  $1C98 constant GFXMMU_LUT403L         \ Graphic MMU LUT entry 403 low
  $1C9C constant GFXMMU_LUT403H         \ Graphic MMU LUT entry 403 high
  $1CA0 constant GFXMMU_LUT404L         \ Graphic MMU LUT entry 404 low
  $1CA4 constant GFXMMU_LUT404H         \ Graphic MMU LUT entry 404 high
  $1CA8 constant GFXMMU_LUT405L         \ Graphic MMU LUT entry 405 low
  $1CAC constant GFXMMU_LUT405H         \ Graphic MMU LUT entry 405 high
  $1CB0 constant GFXMMU_LUT406L         \ Graphic MMU LUT entry 406 low
  $1CB4 constant GFXMMU_LUT406H         \ Graphic MMU LUT entry 406 high
  $1CB8 constant GFXMMU_LUT407L         \ Graphic MMU LUT entry 407 low
  $1CBC constant GFXMMU_LUT407H         \ Graphic MMU LUT entry 407 high
  $1CC0 constant GFXMMU_LUT408L         \ Graphic MMU LUT entry 408 low
  $1CC4 constant GFXMMU_LUT408H         \ Graphic MMU LUT entry 408 high
  $1CC8 constant GFXMMU_LUT409L         \ Graphic MMU LUT entry 409 low
  $1CCC constant GFXMMU_LUT409H         \ Graphic MMU LUT entry 409 high
  $1CD0 constant GFXMMU_LUT410L         \ Graphic MMU LUT entry 410 low
  $1CD4 constant GFXMMU_LUT410H         \ Graphic MMU LUT entry 410 high
  $1CD8 constant GFXMMU_LUT411L         \ Graphic MMU LUT entry 411 low
  $1CDC constant GFXMMU_LUT411H         \ Graphic MMU LUT entry 411 high
  $1CE0 constant GFXMMU_LUT412L         \ Graphic MMU LUT entry 412 low
  $1CE4 constant GFXMMU_LUT412H         \ Graphic MMU LUT entry 412 high
  $1CE8 constant GFXMMU_LUT413L         \ Graphic MMU LUT entry 413 low
  $1CEC constant GFXMMU_LUT413H         \ Graphic MMU LUT entry 413 high
  $1CF0 constant GFXMMU_LUT414L         \ Graphic MMU LUT entry 414 low
  $1CF4 constant GFXMMU_LUT414H         \ Graphic MMU LUT entry 414 high
  $1CF8 constant GFXMMU_LUT415L         \ Graphic MMU LUT entry 415 low
  $1CFC constant GFXMMU_LUT415H         \ Graphic MMU LUT entry 415 high
  $1D00 constant GFXMMU_LUT416L         \ Graphic MMU LUT entry 416 low
  $1D04 constant GFXMMU_LUT416H         \ Graphic MMU LUT entry 416 high
  $1D08 constant GFXMMU_LUT417L         \ Graphic MMU LUT entry 417 low
  $1D0C constant GFXMMU_LUT417H         \ Graphic MMU LUT entry 417 high
  $1D10 constant GFXMMU_LUT418L         \ Graphic MMU LUT entry 418 low
  $1D14 constant GFXMMU_LUT418H         \ Graphic MMU LUT entry 418 high
  $1D18 constant GFXMMU_LUT419L         \ Graphic MMU LUT entry 419 low
  $1D1C constant GFXMMU_LUT419H         \ Graphic MMU LUT entry 419 high
  $1D20 constant GFXMMU_LUT420L         \ Graphic MMU LUT entry 420 low
  $1D24 constant GFXMMU_LUT420H         \ Graphic MMU LUT entry 420 high
  $1D28 constant GFXMMU_LUT421L         \ Graphic MMU LUT entry 421 low
  $1D2C constant GFXMMU_LUT421H         \ Graphic MMU LUT entry 421 high
  $1D30 constant GFXMMU_LUT422L         \ Graphic MMU LUT entry 422 low
  $1D34 constant GFXMMU_LUT422H         \ Graphic MMU LUT entry 422 high
  $1D38 constant GFXMMU_LUT423L         \ Graphic MMU LUT entry 423 low
  $1D3C constant GFXMMU_LUT423H         \ Graphic MMU LUT entry 423 high
  $1D40 constant GFXMMU_LUT424L         \ Graphic MMU LUT entry 424 low
  $1D44 constant GFXMMU_LUT424H         \ Graphic MMU LUT entry 424 high
  $1D48 constant GFXMMU_LUT425L         \ Graphic MMU LUT entry 425 low
  $1D4C constant GFXMMU_LUT425H         \ Graphic MMU LUT entry 425 high
  $1D50 constant GFXMMU_LUT426L         \ Graphic MMU LUT entry 426 low
  $1D54 constant GFXMMU_LUT426H         \ Graphic MMU LUT entry 426 high
  $1D58 constant GFXMMU_LUT427L         \ Graphic MMU LUT entry 427 low
  $1D5C constant GFXMMU_LUT427H         \ Graphic MMU LUT entry 427 high
  $1D60 constant GFXMMU_LUT428L         \ Graphic MMU LUT entry 428 low
  $1D64 constant GFXMMU_LUT428H         \ Graphic MMU LUT entry 428 high
  $1D68 constant GFXMMU_LUT429L         \ Graphic MMU LUT entry 429 low
  $1D6C constant GFXMMU_LUT429H         \ Graphic MMU LUT entry 429 high
  $1D70 constant GFXMMU_LUT430L         \ Graphic MMU LUT entry 430 low
  $1D74 constant GFXMMU_LUT430H         \ Graphic MMU LUT entry 430 high
  $1D78 constant GFXMMU_LUT431L         \ Graphic MMU LUT entry 431 low
  $1D7C constant GFXMMU_LUT431H         \ Graphic MMU LUT entry 431 high
  $1D80 constant GFXMMU_LUT432L         \ Graphic MMU LUT entry 432 low
  $1D84 constant GFXMMU_LUT432H         \ Graphic MMU LUT entry 432 high
  $1D88 constant GFXMMU_LUT433L         \ Graphic MMU LUT entry 433 low
  $1D8C constant GFXMMU_LUT433H         \ Graphic MMU LUT entry 433 high
  $1D90 constant GFXMMU_LUT434L         \ Graphic MMU LUT entry 434 low
  $1D94 constant GFXMMU_LUT434H         \ Graphic MMU LUT entry 434 high
  $1D98 constant GFXMMU_LUT435L         \ Graphic MMU LUT entry 435 low
  $1D9C constant GFXMMU_LUT435H         \ Graphic MMU LUT entry 435 high
  $1DA0 constant GFXMMU_LUT436L         \ Graphic MMU LUT entry 436 low
  $1DA4 constant GFXMMU_LUT436H         \ Graphic MMU LUT entry 436 high
  $1DA8 constant GFXMMU_LUT437L         \ Graphic MMU LUT entry 437 low
  $1DAC constant GFXMMU_LUT437H         \ Graphic MMU LUT entry 437 high
  $1DB0 constant GFXMMU_LUT438L         \ Graphic MMU LUT entry 438 low
  $1DB4 constant GFXMMU_LUT438H         \ Graphic MMU LUT entry 438 high
  $1DB8 constant GFXMMU_LUT439L         \ Graphic MMU LUT entry 439 low
  $1DBC constant GFXMMU_LUT439H         \ Graphic MMU LUT entry 439 high
  $1DC0 constant GFXMMU_LUT440L         \ Graphic MMU LUT entry 440 low
  $1DC4 constant GFXMMU_LUT440H         \ Graphic MMU LUT entry 440 high
  $1DC8 constant GFXMMU_LUT441L         \ Graphic MMU LUT entry 441 low
  $1DCC constant GFXMMU_LUT441H         \ Graphic MMU LUT entry 441 high
  $1DD0 constant GFXMMU_LUT442L         \ Graphic MMU LUT entry 442 low
  $1DD4 constant GFXMMU_LUT442H         \ Graphic MMU LUT entry 442 high
  $1DD8 constant GFXMMU_LUT443L         \ Graphic MMU LUT entry 443 low
  $1DDC constant GFXMMU_LUT443H         \ Graphic MMU LUT entry 443 high
  $1DE0 constant GFXMMU_LUT444L         \ Graphic MMU LUT entry 444 low
  $1DE4 constant GFXMMU_LUT444H         \ Graphic MMU LUT entry 444 high
  $1DE8 constant GFXMMU_LUT445L         \ Graphic MMU LUT entry 445 low
  $1DEC constant GFXMMU_LUT445H         \ Graphic MMU LUT entry 445 high
  $1DF0 constant GFXMMU_LUT446L         \ Graphic MMU LUT entry 446 low
  $1DF4 constant GFXMMU_LUT446H         \ Graphic MMU LUT entry 446 high
  $1DF8 constant GFXMMU_LUT447L         \ Graphic MMU LUT entry 447 low
  $1DFC constant GFXMMU_LUT447H         \ Graphic MMU LUT entry 447 high
  $1E00 constant GFXMMU_LUT448L         \ Graphic MMU LUT entry 448 low
  $1E04 constant GFXMMU_LUT448H         \ Graphic MMU LUT entry 448 high
  $1E08 constant GFXMMU_LUT449L         \ Graphic MMU LUT entry 449 low
  $1E0C constant GFXMMU_LUT449H         \ Graphic MMU LUT entry 449 high
  $1E10 constant GFXMMU_LUT450L         \ Graphic MMU LUT entry 450 low
  $1E14 constant GFXMMU_LUT450H         \ Graphic MMU LUT entry 450 high
  $1E18 constant GFXMMU_LUT451L         \ Graphic MMU LUT entry 451 low
  $1E1C constant GFXMMU_LUT451H         \ Graphic MMU LUT entry 451 high
  $1E20 constant GFXMMU_LUT452L         \ Graphic MMU LUT entry 452 low
  $1E24 constant GFXMMU_LUT452H         \ Graphic MMU LUT entry 452 high
  $1E28 constant GFXMMU_LUT453L         \ Graphic MMU LUT entry 453 low
  $1E2C constant GFXMMU_LUT453H         \ Graphic MMU LUT entry 453 high
  $1E30 constant GFXMMU_LUT454L         \ Graphic MMU LUT entry 454 low
  $1E34 constant GFXMMU_LUT454H         \ Graphic MMU LUT entry 454 high
  $1E38 constant GFXMMU_LUT455L         \ Graphic MMU LUT entry 455 low
  $1E3C constant GFXMMU_LUT455H         \ Graphic MMU LUT entry 455 high
  $1E40 constant GFXMMU_LUT456L         \ Graphic MMU LUT entry 456 low
  $1E44 constant GFXMMU_LUT456H         \ Graphic MMU LUT entry 456 high
  $1E48 constant GFXMMU_LUT457L         \ Graphic MMU LUT entry 457 low
  $1E4C constant GFXMMU_LUT457H         \ Graphic MMU LUT entry 457 high
  $1E50 constant GFXMMU_LUT458L         \ Graphic MMU LUT entry 458 low
  $1E54 constant GFXMMU_LUT458H         \ Graphic MMU LUT entry 458 high
  $1E58 constant GFXMMU_LUT459L         \ Graphic MMU LUT entry 459 low
  $1E5C constant GFXMMU_LUT459H         \ Graphic MMU LUT entry 459 high
  $1E60 constant GFXMMU_LUT460L         \ Graphic MMU LUT entry 460 low
  $1E64 constant GFXMMU_LUT460H         \ Graphic MMU LUT entry 460 high
  $1E68 constant GFXMMU_LUT461L         \ Graphic MMU LUT entry 461 low
  $1E6C constant GFXMMU_LUT461H         \ Graphic MMU LUT entry 461 high
  $1E70 constant GFXMMU_LUT462L         \ Graphic MMU LUT entry 462 low
  $1E74 constant GFXMMU_LUT462H         \ Graphic MMU LUT entry 462 high
  $1E78 constant GFXMMU_LUT463L         \ Graphic MMU LUT entry 463 low
  $1E7C constant GFXMMU_LUT463H         \ Graphic MMU LUT entry 463 high
  $1E80 constant GFXMMU_LUT464L         \ Graphic MMU LUT entry 464 low
  $1E84 constant GFXMMU_LUT464H         \ Graphic MMU LUT entry 464 high
  $1E88 constant GFXMMU_LUT465L         \ Graphic MMU LUT entry 465 low
  $1E8C constant GFXMMU_LUT465H         \ Graphic MMU LUT entry 465 high
  $1E90 constant GFXMMU_LUT466L         \ Graphic MMU LUT entry 466 low
  $1E94 constant GFXMMU_LUT466H         \ Graphic MMU LUT entry 466 high
  $1E98 constant GFXMMU_LUT467L         \ Graphic MMU LUT entry 467 low
  $1E9C constant GFXMMU_LUT467H         \ Graphic MMU LUT entry 467 high
  $1EA0 constant GFXMMU_LUT468L         \ Graphic MMU LUT entry 468 low
  $1EA4 constant GFXMMU_LUT468H         \ Graphic MMU LUT entry 468 high
  $1EA8 constant GFXMMU_LUT469L         \ Graphic MMU LUT entry 469 low
  $1EAC constant GFXMMU_LUT469H         \ Graphic MMU LUT entry 469 high
  $1EB0 constant GFXMMU_LUT470L         \ Graphic MMU LUT entry 470 low
  $1EB4 constant GFXMMU_LUT470H         \ Graphic MMU LUT entry 470 high
  $1EB8 constant GFXMMU_LUT471L         \ Graphic MMU LUT entry 471 low
  $1EBC constant GFXMMU_LUT471H         \ Graphic MMU LUT entry 471 high
  $1EC0 constant GFXMMU_LUT472L         \ Graphic MMU LUT entry 472 low
  $1EC4 constant GFXMMU_LUT472H         \ Graphic MMU LUT entry 472 high
  $1EC8 constant GFXMMU_LUT473L         \ Graphic MMU LUT entry 473 low
  $1ECC constant GFXMMU_LUT473H         \ Graphic MMU LUT entry 473 high
  $1ED0 constant GFXMMU_LUT474L         \ Graphic MMU LUT entry 474 low
  $1ED4 constant GFXMMU_LUT474H         \ Graphic MMU LUT entry 474 high
  $1ED8 constant GFXMMU_LUT475L         \ Graphic MMU LUT entry 475 low
  $1EDC constant GFXMMU_LUT475H         \ Graphic MMU LUT entry 475 high
  $1EE0 constant GFXMMU_LUT476L         \ Graphic MMU LUT entry 476 low
  $1EE4 constant GFXMMU_LUT476H         \ Graphic MMU LUT entry 476 high
  $1EE8 constant GFXMMU_LUT477L         \ Graphic MMU LUT entry 477 low
  $1EEC constant GFXMMU_LUT477H         \ Graphic MMU LUT entry 477 high
  $1EF0 constant GFXMMU_LUT478L         \ Graphic MMU LUT entry 478 low
  $1EF4 constant GFXMMU_LUT478H         \ Graphic MMU LUT entry 478 high
  $1EF8 constant GFXMMU_LUT479L         \ Graphic MMU LUT entry 479 low
  $1EFC constant GFXMMU_LUT479H         \ Graphic MMU LUT entry 479 high
  $1F00 constant GFXMMU_LUT480L         \ Graphic MMU LUT entry 480 low
  $1F04 constant GFXMMU_LUT480H         \ Graphic MMU LUT entry 480 high
  $1F08 constant GFXMMU_LUT481L         \ Graphic MMU LUT entry 481 low
  $1F0C constant GFXMMU_LUT481H         \ Graphic MMU LUT entry 481 high
  $1F10 constant GFXMMU_LUT482L         \ Graphic MMU LUT entry 482 low
  $1F14 constant GFXMMU_LUT482H         \ Graphic MMU LUT entry 482 high
  $1F18 constant GFXMMU_LUT483L         \ Graphic MMU LUT entry 483 low
  $1F1C constant GFXMMU_LUT483H         \ Graphic MMU LUT entry 483 high
  $1F20 constant GFXMMU_LUT484L         \ Graphic MMU LUT entry 484 low
  $1F24 constant GFXMMU_LUT484H         \ Graphic MMU LUT entry 484 high
  $1F28 constant GFXMMU_LUT485L         \ Graphic MMU LUT entry 485 low
  $1F2C constant GFXMMU_LUT485H         \ Graphic MMU LUT entry 485 high
  $1F30 constant GFXMMU_LUT486L         \ Graphic MMU LUT entry 486 low
  $1F34 constant GFXMMU_LUT486H         \ Graphic MMU LUT entry 486 high
  $1F38 constant GFXMMU_LUT487L         \ Graphic MMU LUT entry 487 low
  $1F3C constant GFXMMU_LUT487H         \ Graphic MMU LUT entry 487 high
  $1F40 constant GFXMMU_LUT488L         \ Graphic MMU LUT entry 488 low
  $1F44 constant GFXMMU_LUT488H         \ Graphic MMU LUT entry 488 high
  $1F48 constant GFXMMU_LUT489L         \ Graphic MMU LUT entry 489 low
  $1F4C constant GFXMMU_LUT489H         \ Graphic MMU LUT entry 489 high
  $1F50 constant GFXMMU_LUT490L         \ Graphic MMU LUT entry 490 low
  $1F54 constant GFXMMU_LUT490H         \ Graphic MMU LUT entry 490 high
  $1F58 constant GFXMMU_LUT491L         \ Graphic MMU LUT entry 491 low
  $1F5C constant GFXMMU_LUT491H         \ Graphic MMU LUT entry 491 high
  $1F60 constant GFXMMU_LUT492L         \ Graphic MMU LUT entry 492 low
  $1F64 constant GFXMMU_LUT492H         \ Graphic MMU LUT entry 492 high
  $1F68 constant GFXMMU_LUT493L         \ Graphic MMU LUT entry 493 low
  $1F6C constant GFXMMU_LUT493H         \ Graphic MMU LUT entry 493 high
  $1F70 constant GFXMMU_LUT494L         \ Graphic MMU LUT entry 494 low
  $1F74 constant GFXMMU_LUT494H         \ Graphic MMU LUT entry 494 high
  $1F78 constant GFXMMU_LUT495L         \ Graphic MMU LUT entry 495 low
  $1F7C constant GFXMMU_LUT495H         \ Graphic MMU LUT entry 495 high
  $1F80 constant GFXMMU_LUT496L         \ Graphic MMU LUT entry 496 low
  $1F84 constant GFXMMU_LUT496H         \ Graphic MMU LUT entry 496 high
  $1F88 constant GFXMMU_LUT497L         \ Graphic MMU LUT entry 497 low
  $1F8C constant GFXMMU_LUT497H         \ Graphic MMU LUT entry 497 high
  $1F90 constant GFXMMU_LUT498L         \ Graphic MMU LUT entry 498 low
  $1F94 constant GFXMMU_LUT498H         \ Graphic MMU LUT entry 498 high
  $1F98 constant GFXMMU_LUT499L         \ Graphic MMU LUT entry 499 low
  $1F9C constant GFXMMU_LUT499H         \ Graphic MMU LUT entry 499 high
  $1FA0 constant GFXMMU_LUT500L         \ Graphic MMU LUT entry 500 low
  $1FA4 constant GFXMMU_LUT500H         \ Graphic MMU LUT entry 500 high
  $1FA8 constant GFXMMU_LUT501L         \ Graphic MMU LUT entry 501 low
  $1FAC constant GFXMMU_LUT501H         \ Graphic MMU LUT entry 501 high
  $1FB0 constant GFXMMU_LUT502L         \ Graphic MMU LUT entry 502 low
  $1FB4 constant GFXMMU_LUT502H         \ Graphic MMU LUT entry 502 high
  $1FB8 constant GFXMMU_LUT503L         \ Graphic MMU LUT entry 503 low
  $1FBC constant GFXMMU_LUT503H         \ Graphic MMU LUT entry 503 high
  $1FC0 constant GFXMMU_LUT504L         \ Graphic MMU LUT entry 504 low
  $1FC4 constant GFXMMU_LUT504H         \ Graphic MMU LUT entry 504 high
  $1FC8 constant GFXMMU_LUT505L         \ Graphic MMU LUT entry 505 low
  $1FCC constant GFXMMU_LUT505H         \ Graphic MMU LUT entry 505 high
  $1FD0 constant GFXMMU_LUT506L         \ Graphic MMU LUT entry 506 low
  $1FD4 constant GFXMMU_LUT506H         \ Graphic MMU LUT entry 506 high
  $1FD8 constant GFXMMU_LUT507L         \ Graphic MMU LUT entry 507 low
  $1FDC constant GFXMMU_LUT507H         \ Graphic MMU LUT entry 507 high
  $1FE0 constant GFXMMU_LUT508L         \ Graphic MMU LUT entry 508 low
  $1FE4 constant GFXMMU_LUT508H         \ Graphic MMU LUT entry 508 high
  $1FE8 constant GFXMMU_LUT509L         \ Graphic MMU LUT entry 509 low
  $1FEC constant GFXMMU_LUT509H         \ Graphic MMU LUT entry 509 high
  $1FF0 constant GFXMMU_LUT510L         \ Graphic MMU LUT entry 510 low
  $1FF4 constant GFXMMU_LUT510H         \ Graphic MMU LUT entry 510 high
  $1FF8 constant GFXMMU_LUT511L         \ Graphic MMU LUT entry 511 low
  $1FFC constant GFXMMU_LUT511H         \ Graphic MMU LUT entry 511 high
  $2000 constant GFXMMU_LUT512L         \ Graphic MMU LUT entry 512 low
  $2004 constant GFXMMU_LUT512H         \ Graphic MMU LUT entry 512 high
  $2008 constant GFXMMU_LUT513L         \ Graphic MMU LUT entry 513 low
  $200C constant GFXMMU_LUT513H         \ Graphic MMU LUT entry 513 high
  $2010 constant GFXMMU_LUT514L         \ Graphic MMU LUT entry 514 low
  $2014 constant GFXMMU_LUT514H         \ Graphic MMU LUT entry 514 high
  $2018 constant GFXMMU_LUT515L         \ Graphic MMU LUT entry 515 low
  $201C constant GFXMMU_LUT515H         \ Graphic MMU LUT entry 515 high
  $2020 constant GFXMMU_LUT516L         \ Graphic MMU LUT entry 516 low
  $2024 constant GFXMMU_LUT516H         \ Graphic MMU LUT entry 516 high
  $2028 constant GFXMMU_LUT517L         \ Graphic MMU LUT entry 517 low
  $202C constant GFXMMU_LUT517H         \ Graphic MMU LUT entry 517 high
  $2030 constant GFXMMU_LUT518L         \ Graphic MMU LUT entry 518 low
  $2034 constant GFXMMU_LUT518H         \ Graphic MMU LUT entry 518 high
  $2038 constant GFXMMU_LUT519L         \ Graphic MMU LUT entry 519 low
  $203C constant GFXMMU_LUT519H         \ Graphic MMU LUT entry 519 high
  $2040 constant GFXMMU_LUT520L         \ Graphic MMU LUT entry 520 low
  $2044 constant GFXMMU_LUT520H         \ Graphic MMU LUT entry 520 high
  $2048 constant GFXMMU_LUT521L         \ Graphic MMU LUT entry 521 low
  $204C constant GFXMMU_LUT521H         \ Graphic MMU LUT entry 521 high
  $2050 constant GFXMMU_LUT522L         \ Graphic MMU LUT entry 522 low
  $2054 constant GFXMMU_LUT522H         \ Graphic MMU LUT entry 522 high
  $2058 constant GFXMMU_LUT523L         \ Graphic MMU LUT entry 523 low
  $205C constant GFXMMU_LUT523H         \ Graphic MMU LUT entry 523 high
  $2060 constant GFXMMU_LUT524L         \ Graphic MMU LUT entry 524 low
  $2064 constant GFXMMU_LUT524H         \ Graphic MMU LUT entry 524 high
  $2068 constant GFXMMU_LUT525L         \ Graphic MMU LUT entry 525 low
  $206C constant GFXMMU_LUT525H         \ Graphic MMU LUT entry 525 high
  $2070 constant GFXMMU_LUT526L         \ Graphic MMU LUT entry 526 low
  $2074 constant GFXMMU_LUT526H         \ Graphic MMU LUT entry 526 high
  $2078 constant GFXMMU_LUT527L         \ Graphic MMU LUT entry 527 low
  $207C constant GFXMMU_LUT527H         \ Graphic MMU LUT entry 527 high
  $2080 constant GFXMMU_LUT528L         \ Graphic MMU LUT entry 528 low
  $2084 constant GFXMMU_LUT528H         \ Graphic MMU LUT entry 528 high
  $2088 constant GFXMMU_LUT529L         \ Graphic MMU LUT entry 529 low
  $208C constant GFXMMU_LUT529H         \ Graphic MMU LUT entry 529 high
  $2090 constant GFXMMU_LUT530L         \ Graphic MMU LUT entry 530 low
  $2094 constant GFXMMU_LUT530H         \ Graphic MMU LUT entry 530 high
  $2098 constant GFXMMU_LUT531L         \ Graphic MMU LUT entry 531 low
  $209C constant GFXMMU_LUT531H         \ Graphic MMU LUT entry 531 high
  $20A0 constant GFXMMU_LUT532L         \ Graphic MMU LUT entry 532 low
  $20A4 constant GFXMMU_LUT532H         \ Graphic MMU LUT entry 532 high
  $20A8 constant GFXMMU_LUT533L         \ Graphic MMU LUT entry 533 low
  $20AC constant GFXMMU_LUT533H         \ Graphic MMU LUT entry 533 high
  $20B0 constant GFXMMU_LUT534L         \ Graphic MMU LUT entry 534 low
  $20B4 constant GFXMMU_LUT534H         \ Graphic MMU LUT entry 534 high
  $20B8 constant GFXMMU_LUT535L         \ Graphic MMU LUT entry 535 low
  $20BC constant GFXMMU_LUT535H         \ Graphic MMU LUT entry 535 high
  $20C0 constant GFXMMU_LUT536L         \ Graphic MMU LUT entry 536 low
  $20C4 constant GFXMMU_LUT536H         \ Graphic MMU LUT entry 536 high
  $20C8 constant GFXMMU_LUT537L         \ Graphic MMU LUT entry 537 low
  $20CC constant GFXMMU_LUT537H         \ Graphic MMU LUT entry 537 high
  $20D0 constant GFXMMU_LUT538L         \ Graphic MMU LUT entry 538 low
  $20D4 constant GFXMMU_LUT538H         \ Graphic MMU LUT entry 538 high
  $20D8 constant GFXMMU_LUT539L         \ Graphic MMU LUT entry 539 low
  $20DC constant GFXMMU_LUT539H         \ Graphic MMU LUT entry 539 high
  $20E0 constant GFXMMU_LUT540L         \ Graphic MMU LUT entry 540 low
  $20E4 constant GFXMMU_LUT540H         \ Graphic MMU LUT entry 540 high
  $20E8 constant GFXMMU_LUT541L         \ Graphic MMU LUT entry 541 low
  $20EC constant GFXMMU_LUT541H         \ Graphic MMU LUT entry 541 high
  $20F0 constant GFXMMU_LUT542L         \ Graphic MMU LUT entry 542 low
  $20F4 constant GFXMMU_LUT542H         \ Graphic MMU LUT entry 542 high
  $20F8 constant GFXMMU_LUT543L         \ Graphic MMU LUT entry 543 low
  $20FC constant GFXMMU_LUT543H         \ Graphic MMU LUT entry 543 high
  $2100 constant GFXMMU_LUT544L         \ Graphic MMU LUT entry 544 low
  $2104 constant GFXMMU_LUT544H         \ Graphic MMU LUT entry 544 high
  $2108 constant GFXMMU_LUT545L         \ Graphic MMU LUT entry 545 low
  $210C constant GFXMMU_LUT545H         \ Graphic MMU LUT entry 545 high
  $2110 constant GFXMMU_LUT546L         \ Graphic MMU LUT entry 546 low
  $2114 constant GFXMMU_LUT546H         \ Graphic MMU LUT entry 546 high
  $2118 constant GFXMMU_LUT547L         \ Graphic MMU LUT entry 547 low
  $211C constant GFXMMU_LUT547H         \ Graphic MMU LUT entry 547 high
  $2120 constant GFXMMU_LUT548L         \ Graphic MMU LUT entry 548 low
  $2124 constant GFXMMU_LUT548H         \ Graphic MMU LUT entry 548 high
  $2128 constant GFXMMU_LUT549L         \ Graphic MMU LUT entry 549 low
  $212C constant GFXMMU_LUT549H         \ Graphic MMU LUT entry 549 high
  $2130 constant GFXMMU_LUT550L         \ Graphic MMU LUT entry 550 low
  $2134 constant GFXMMU_LUT550H         \ Graphic MMU LUT entry 550 high
  $2138 constant GFXMMU_LUT551L         \ Graphic MMU LUT entry 551 low
  $213C constant GFXMMU_LUT551H         \ Graphic MMU LUT entry 551 high
  $2140 constant GFXMMU_LUT552L         \ Graphic MMU LUT entry 552 low
  $2144 constant GFXMMU_LUT552H         \ Graphic MMU LUT entry 552 high
  $2148 constant GFXMMU_LUT553L         \ Graphic MMU LUT entry 553 low
  $214C constant GFXMMU_LUT553H         \ Graphic MMU LUT entry 553 high
  $2150 constant GFXMMU_LUT554L         \ Graphic MMU LUT entry 554 low
  $2154 constant GFXMMU_LUT554H         \ Graphic MMU LUT entry 554 high
  $2158 constant GFXMMU_LUT555L         \ Graphic MMU LUT entry 555 low
  $215C constant GFXMMU_LUT555H         \ Graphic MMU LUT entry 555 high
  $2160 constant GFXMMU_LUT556L         \ Graphic MMU LUT entry 556 low
  $2164 constant GFXMMU_LUT556H         \ Graphic MMU LUT entry 556 high
  $2168 constant GFXMMU_LUT557L         \ Graphic MMU LUT entry 557 low
  $216C constant GFXMMU_LUT557H         \ Graphic MMU LUT entry 557 high
  $2170 constant GFXMMU_LUT558L         \ Graphic MMU LUT entry 558 low
  $2174 constant GFXMMU_LUT558H         \ Graphic MMU LUT entry 558 high
  $2178 constant GFXMMU_LUT559L         \ Graphic MMU LUT entry 559 low
  $217C constant GFXMMU_LUT559H         \ Graphic MMU LUT entry 559 high
  $2180 constant GFXMMU_LUT560L         \ Graphic MMU LUT entry 560 low
  $2184 constant GFXMMU_LUT560H         \ Graphic MMU LUT entry 560 high
  $2188 constant GFXMMU_LUT561L         \ Graphic MMU LUT entry 561 low
  $218C constant GFXMMU_LUT561H         \ Graphic MMU LUT entry 561 high
  $2190 constant GFXMMU_LUT562L         \ Graphic MMU LUT entry 562 low
  $2194 constant GFXMMU_LUT562H         \ Graphic MMU LUT entry 562 high
  $2198 constant GFXMMU_LUT563L         \ Graphic MMU LUT entry 563 low
  $219C constant GFXMMU_LUT563H         \ Graphic MMU LUT entry 563 high
  $21A0 constant GFXMMU_LUT564L         \ Graphic MMU LUT entry 564 low
  $21A4 constant GFXMMU_LUT564H         \ Graphic MMU LUT entry 564 high
  $21A8 constant GFXMMU_LUT565L         \ Graphic MMU LUT entry 565 low
  $21AC constant GFXMMU_LUT565H         \ Graphic MMU LUT entry 565 high
  $21B0 constant GFXMMU_LUT566L         \ Graphic MMU LUT entry 566 low
  $21B4 constant GFXMMU_LUT566H         \ Graphic MMU LUT entry 566 high
  $21B8 constant GFXMMU_LUT567L         \ Graphic MMU LUT entry 567 low
  $21BC constant GFXMMU_LUT567H         \ Graphic MMU LUT entry 567 high
  $21C0 constant GFXMMU_LUT568L         \ Graphic MMU LUT entry 568 low
  $21C4 constant GFXMMU_LUT568H         \ Graphic MMU LUT entry 568 high
  $21C8 constant GFXMMU_LUT569L         \ Graphic MMU LUT entry 569 low
  $21CC constant GFXMMU_LUT569H         \ Graphic MMU LUT entry 569 high
  $21D0 constant GFXMMU_LUT570L         \ Graphic MMU LUT entry 570 low
  $21D4 constant GFXMMU_LUT570H         \ Graphic MMU LUT entry 570 high
  $21D8 constant GFXMMU_LUT571L         \ Graphic MMU LUT entry 571 low
  $21DC constant GFXMMU_LUT571H         \ Graphic MMU LUT entry 571 high
  $21E0 constant GFXMMU_LUT572L         \ Graphic MMU LUT entry 572 low
  $21E4 constant GFXMMU_LUT572H         \ Graphic MMU LUT entry 572 high
  $21E8 constant GFXMMU_LUT573L         \ Graphic MMU LUT entry 573 low
  $21EC constant GFXMMU_LUT573H         \ Graphic MMU LUT entry 573 high
  $21F0 constant GFXMMU_LUT574L         \ Graphic MMU LUT entry 574 low
  $21F4 constant GFXMMU_LUT574H         \ Graphic MMU LUT entry 574 high
  $21F8 constant GFXMMU_LUT575L         \ Graphic MMU LUT entry 575 low
  $21FC constant GFXMMU_LUT575H         \ Graphic MMU LUT entry 575 high
  $2200 constant GFXMMU_LUT576L         \ Graphic MMU LUT entry 576 low
  $2204 constant GFXMMU_LUT576H         \ Graphic MMU LUT entry 576 high
  $2208 constant GFXMMU_LUT577L         \ Graphic MMU LUT entry 577 low
  $220C constant GFXMMU_LUT577H         \ Graphic MMU LUT entry 577 high
  $2210 constant GFXMMU_LUT578L         \ Graphic MMU LUT entry 578 low
  $2214 constant GFXMMU_LUT578H         \ Graphic MMU LUT entry 578 high
  $2218 constant GFXMMU_LUT579L         \ Graphic MMU LUT entry 579 low
  $221C constant GFXMMU_LUT579H         \ Graphic MMU LUT entry 579 high
  $2220 constant GFXMMU_LUT580L         \ Graphic MMU LUT entry 580 low
  $2224 constant GFXMMU_LUT580H         \ Graphic MMU LUT entry 580 high
  $2228 constant GFXMMU_LUT581L         \ Graphic MMU LUT entry 581 low
  $222C constant GFXMMU_LUT581H         \ Graphic MMU LUT entry 581 high
  $2230 constant GFXMMU_LUT582L         \ Graphic MMU LUT entry 582 low
  $2234 constant GFXMMU_LUT582H         \ Graphic MMU LUT entry 582 high
  $2238 constant GFXMMU_LUT583L         \ Graphic MMU LUT entry 583 low
  $223C constant GFXMMU_LUT583H         \ Graphic MMU LUT entry 583 high
  $2240 constant GFXMMU_LUT584L         \ Graphic MMU LUT entry 584 low
  $2244 constant GFXMMU_LUT584H         \ Graphic MMU LUT entry 584 high
  $2248 constant GFXMMU_LUT585L         \ Graphic MMU LUT entry 585 low
  $224C constant GFXMMU_LUT585H         \ Graphic MMU LUT entry 585 high
  $2250 constant GFXMMU_LUT586L         \ Graphic MMU LUT entry 586 low
  $2254 constant GFXMMU_LUT586H         \ Graphic MMU LUT entry 586 high
  $2258 constant GFXMMU_LUT587L         \ Graphic MMU LUT entry 587 low
  $225C constant GFXMMU_LUT587H         \ Graphic MMU LUT entry 587 high
  $2260 constant GFXMMU_LUT588L         \ Graphic MMU LUT entry 588 low
  $2264 constant GFXMMU_LUT588H         \ Graphic MMU LUT entry 588 high
  $2268 constant GFXMMU_LUT589L         \ Graphic MMU LUT entry 589 low
  $226C constant GFXMMU_LUT589H         \ Graphic MMU LUT entry 589 high
  $2270 constant GFXMMU_LUT590L         \ Graphic MMU LUT entry 590 low
  $2274 constant GFXMMU_LUT590H         \ Graphic MMU LUT entry 590 high
  $2278 constant GFXMMU_LUT591L         \ Graphic MMU LUT entry 591 low
  $227C constant GFXMMU_LUT591H         \ Graphic MMU LUT entry 591 high
  $2280 constant GFXMMU_LUT592L         \ Graphic MMU LUT entry 592 low
  $2284 constant GFXMMU_LUT592H         \ Graphic MMU LUT entry 592 high
  $2288 constant GFXMMU_LUT593L         \ Graphic MMU LUT entry 593 low
  $228C constant GFXMMU_LUT593H         \ Graphic MMU LUT entry 593 high
  $2290 constant GFXMMU_LUT594L         \ Graphic MMU LUT entry 594 low
  $2294 constant GFXMMU_LUT594H         \ Graphic MMU LUT entry 594 high
  $2298 constant GFXMMU_LUT595L         \ Graphic MMU LUT entry 595 low
  $229C constant GFXMMU_LUT595H         \ Graphic MMU LUT entry 595 high
  $22A0 constant GFXMMU_LUT596L         \ Graphic MMU LUT entry 596 low
  $22A4 constant GFXMMU_LUT596H         \ Graphic MMU LUT entry 596 high
  $22A8 constant GFXMMU_LUT597L         \ Graphic MMU LUT entry 597 low
  $22AC constant GFXMMU_LUT597H         \ Graphic MMU LUT entry 597 high
  $22B0 constant GFXMMU_LUT598L         \ Graphic MMU LUT entry 598 low
  $22B4 constant GFXMMU_LUT598H         \ Graphic MMU LUT entry 598 high
  $22B8 constant GFXMMU_LUT599L         \ Graphic MMU LUT entry 599 low
  $22BC constant GFXMMU_LUT599H         \ Graphic MMU LUT entry 599 high
  $22C0 constant GFXMMU_LUT600L         \ Graphic MMU LUT entry 600 low
  $22C4 constant GFXMMU_LUT600H         \ Graphic MMU LUT entry 600 high
  $22C8 constant GFXMMU_LUT601L         \ Graphic MMU LUT entry 601 low
  $22CC constant GFXMMU_LUT601H         \ Graphic MMU LUT entry 601 high
  $22D0 constant GFXMMU_LUT602L         \ Graphic MMU LUT entry 602 low
  $22D4 constant GFXMMU_LUT602H         \ Graphic MMU LUT entry 602 high
  $22D8 constant GFXMMU_LUT603L         \ Graphic MMU LUT entry 603 low
  $22DC constant GFXMMU_LUT603H         \ Graphic MMU LUT entry 603 high
  $22E0 constant GFXMMU_LUT604L         \ Graphic MMU LUT entry 604 low
  $22E4 constant GFXMMU_LUT604H         \ Graphic MMU LUT entry 604 high
  $22E8 constant GFXMMU_LUT605L         \ Graphic MMU LUT entry 605 low
  $22EC constant GFXMMU_LUT605H         \ Graphic MMU LUT entry 605 high
  $22F0 constant GFXMMU_LUT606L         \ Graphic MMU LUT entry 606 low
  $22F4 constant GFXMMU_LUT606H         \ Graphic MMU LUT entry 606 high
  $22F8 constant GFXMMU_LUT607L         \ Graphic MMU LUT entry 607 low
  $22FC constant GFXMMU_LUT607H         \ Graphic MMU LUT entry 607 high
  $2300 constant GFXMMU_LUT608L         \ Graphic MMU LUT entry 608 low
  $2304 constant GFXMMU_LUT608H         \ Graphic MMU LUT entry 608 high
  $2308 constant GFXMMU_LUT609L         \ Graphic MMU LUT entry 609 low
  $230C constant GFXMMU_LUT609H         \ Graphic MMU LUT entry 609 high
  $2310 constant GFXMMU_LUT610L         \ Graphic MMU LUT entry 610 low
  $2314 constant GFXMMU_LUT610H         \ Graphic MMU LUT entry 610 high
  $2318 constant GFXMMU_LUT611L         \ Graphic MMU LUT entry 611 low
  $231C constant GFXMMU_LUT611H         \ Graphic MMU LUT entry 611 high
  $2320 constant GFXMMU_LUT612L         \ Graphic MMU LUT entry 612 low
  $2324 constant GFXMMU_LUT612H         \ Graphic MMU LUT entry 612 high
  $2328 constant GFXMMU_LUT613L         \ Graphic MMU LUT entry 613 low
  $232C constant GFXMMU_LUT613H         \ Graphic MMU LUT entry 613 high
  $2330 constant GFXMMU_LUT614L         \ Graphic MMU LUT entry 614 low
  $2334 constant GFXMMU_LUT614H         \ Graphic MMU LUT entry 614 high
  $2338 constant GFXMMU_LUT615L         \ Graphic MMU LUT entry 615 low
  $233C constant GFXMMU_LUT615H         \ Graphic MMU LUT entry 615 high
  $2340 constant GFXMMU_LUT616L         \ Graphic MMU LUT entry 616 low
  $2344 constant GFXMMU_LUT616H         \ Graphic MMU LUT entry 616 high
  $2348 constant GFXMMU_LUT617L         \ Graphic MMU LUT entry 617 low
  $234C constant GFXMMU_LUT617H         \ Graphic MMU LUT entry 617 high
  $2350 constant GFXMMU_LUT618L         \ Graphic MMU LUT entry 618 low
  $2354 constant GFXMMU_LUT618H         \ Graphic MMU LUT entry 618 high
  $2358 constant GFXMMU_LUT619L         \ Graphic MMU LUT entry 619 low
  $235C constant GFXMMU_LUT619H         \ Graphic MMU LUT entry 619 high
  $2360 constant GFXMMU_LUT620L         \ Graphic MMU LUT entry 620 low
  $2364 constant GFXMMU_LUT620H         \ Graphic MMU LUT entry 620 high
  $2368 constant GFXMMU_LUT621L         \ Graphic MMU LUT entry 621 low
  $236C constant GFXMMU_LUT621H         \ Graphic MMU LUT entry 621 high
  $2370 constant GFXMMU_LUT622L         \ Graphic MMU LUT entry 622 low
  $2374 constant GFXMMU_LUT622H         \ Graphic MMU LUT entry 622 high
  $2378 constant GFXMMU_LUT623L         \ Graphic MMU LUT entry 623 low
  $237C constant GFXMMU_LUT623H         \ Graphic MMU LUT entry 623 high
  $2380 constant GFXMMU_LUT624L         \ Graphic MMU LUT entry 624 low
  $2384 constant GFXMMU_LUT624H         \ Graphic MMU LUT entry 624 high
  $2388 constant GFXMMU_LUT625L         \ Graphic MMU LUT entry 625 low
  $238C constant GFXMMU_LUT625H         \ Graphic MMU LUT entry 625 high
  $2390 constant GFXMMU_LUT626L         \ Graphic MMU LUT entry 626 low
  $2394 constant GFXMMU_LUT626H         \ Graphic MMU LUT entry 626 high
  $2398 constant GFXMMU_LUT627L         \ Graphic MMU LUT entry 627 low
  $239C constant GFXMMU_LUT627H         \ Graphic MMU LUT entry 627 high
  $23A0 constant GFXMMU_LUT628L         \ Graphic MMU LUT entry 628 low
  $23A4 constant GFXMMU_LUT628H         \ Graphic MMU LUT entry 628 high
  $23A8 constant GFXMMU_LUT629L         \ Graphic MMU LUT entry 629 low
  $23AC constant GFXMMU_LUT629H         \ Graphic MMU LUT entry 629 high
  $23B0 constant GFXMMU_LUT630L         \ Graphic MMU LUT entry 630 low
  $23B4 constant GFXMMU_LUT630H         \ Graphic MMU LUT entry 630 high
  $23B8 constant GFXMMU_LUT631L         \ Graphic MMU LUT entry 631 low
  $23BC constant GFXMMU_LUT631H         \ Graphic MMU LUT entry 631 high
  $23C0 constant GFXMMU_LUT632L         \ Graphic MMU LUT entry 632 low
  $23C4 constant GFXMMU_LUT632H         \ Graphic MMU LUT entry 632 high
  $23C8 constant GFXMMU_LUT633L         \ Graphic MMU LUT entry 633 low
  $23CC constant GFXMMU_LUT633H         \ Graphic MMU LUT entry 633 high
  $23D0 constant GFXMMU_LUT634L         \ Graphic MMU LUT entry 634 low
  $23D4 constant GFXMMU_LUT634H         \ Graphic MMU LUT entry 634 high
  $23D8 constant GFXMMU_LUT635L         \ Graphic MMU LUT entry 635 low
  $23DC constant GFXMMU_LUT635H         \ Graphic MMU LUT entry 635 high
  $23E0 constant GFXMMU_LUT636L         \ Graphic MMU LUT entry 636 low
  $23E4 constant GFXMMU_LUT636H         \ Graphic MMU LUT entry 636 high
  $23E8 constant GFXMMU_LUT637L         \ Graphic MMU LUT entry 637 low
  $23EC constant GFXMMU_LUT637H         \ Graphic MMU LUT entry 637 high
  $23F0 constant GFXMMU_LUT638L         \ Graphic MMU LUT entry 638 low
  $23F4 constant GFXMMU_LUT638H         \ Graphic MMU LUT entry 638 high
  $23F8 constant GFXMMU_LUT639L         \ Graphic MMU LUT entry 639 low
  $23FC constant GFXMMU_LUT639H         \ Graphic MMU LUT entry 639 high
  $2400 constant GFXMMU_LUT640L         \ Graphic MMU LUT entry 640 low
  $2404 constant GFXMMU_LUT640H         \ Graphic MMU LUT entry 640 high
  $2408 constant GFXMMU_LUT641L         \ Graphic MMU LUT entry 641 low
  $240C constant GFXMMU_LUT641H         \ Graphic MMU LUT entry 641 high
  $2410 constant GFXMMU_LUT642L         \ Graphic MMU LUT entry 642 low
  $2414 constant GFXMMU_LUT642H         \ Graphic MMU LUT entry 642 high
  $2418 constant GFXMMU_LUT643L         \ Graphic MMU LUT entry 643 low
  $241C constant GFXMMU_LUT643H         \ Graphic MMU LUT entry 643 high
  $2420 constant GFXMMU_LUT644L         \ Graphic MMU LUT entry 644 low
  $2424 constant GFXMMU_LUT644H         \ Graphic MMU LUT entry 644 high
  $2428 constant GFXMMU_LUT645L         \ Graphic MMU LUT entry 645 low
  $242C constant GFXMMU_LUT645H         \ Graphic MMU LUT entry 645 high
  $2430 constant GFXMMU_LUT646L         \ Graphic MMU LUT entry 646 low
  $2434 constant GFXMMU_LUT646H         \ Graphic MMU LUT entry 646 high
  $2438 constant GFXMMU_LUT647L         \ Graphic MMU LUT entry 647 low
  $243C constant GFXMMU_LUT647H         \ Graphic MMU LUT entry 647 high
  $2440 constant GFXMMU_LUT648L         \ Graphic MMU LUT entry 648 low
  $2444 constant GFXMMU_LUT648H         \ Graphic MMU LUT entry 648 high
  $2448 constant GFXMMU_LUT649L         \ Graphic MMU LUT entry 649 low
  $244C constant GFXMMU_LUT649H         \ Graphic MMU LUT entry 649 high
  $2450 constant GFXMMU_LUT650L         \ Graphic MMU LUT entry 650 low
  $2454 constant GFXMMU_LUT650H         \ Graphic MMU LUT entry 650 high
  $2458 constant GFXMMU_LUT651L         \ Graphic MMU LUT entry 651 low
  $245C constant GFXMMU_LUT651H         \ Graphic MMU LUT entry 651 high
  $2460 constant GFXMMU_LUT652L         \ Graphic MMU LUT entry 652 low
  $2464 constant GFXMMU_LUT652H         \ Graphic MMU LUT entry 652 high
  $2468 constant GFXMMU_LUT653L         \ Graphic MMU LUT entry 653 low
  $246C constant GFXMMU_LUT653H         \ Graphic MMU LUT entry 653 high
  $2470 constant GFXMMU_LUT654L         \ Graphic MMU LUT entry 654 low
  $2474 constant GFXMMU_LUT654H         \ Graphic MMU LUT entry 654 high
  $2478 constant GFXMMU_LUT655L         \ Graphic MMU LUT entry 655 low
  $247C constant GFXMMU_LUT655H         \ Graphic MMU LUT entry 655 high
  $2480 constant GFXMMU_LUT656L         \ Graphic MMU LUT entry 656 low
  $2484 constant GFXMMU_LUT656H         \ Graphic MMU LUT entry 656 high
  $2488 constant GFXMMU_LUT657L         \ Graphic MMU LUT entry 657 low
  $248C constant GFXMMU_LUT657H         \ Graphic MMU LUT entry 657 high
  $2490 constant GFXMMU_LUT658L         \ Graphic MMU LUT entry 658 low
  $2494 constant GFXMMU_LUT658H         \ Graphic MMU LUT entry 658 high
  $2498 constant GFXMMU_LUT659L         \ Graphic MMU LUT entry 659 low
  $249C constant GFXMMU_LUT659H         \ Graphic MMU LUT entry 659 high
  $24A0 constant GFXMMU_LUT660L         \ Graphic MMU LUT entry 660 low
  $24A4 constant GFXMMU_LUT660H         \ Graphic MMU LUT entry 660 high
  $24A8 constant GFXMMU_LUT661L         \ Graphic MMU LUT entry 661 low
  $24AC constant GFXMMU_LUT661H         \ Graphic MMU LUT entry 661 high
  $24B0 constant GFXMMU_LUT662L         \ Graphic MMU LUT entry 662 low
  $24B4 constant GFXMMU_LUT662H         \ Graphic MMU LUT entry 662 high
  $24B8 constant GFXMMU_LUT663L         \ Graphic MMU LUT entry 663 low
  $24BC constant GFXMMU_LUT663H         \ Graphic MMU LUT entry 663 high
  $24C0 constant GFXMMU_LUT664L         \ Graphic MMU LUT entry 664 low
  $24C4 constant GFXMMU_LUT664H         \ Graphic MMU LUT entry 664 high
  $24C8 constant GFXMMU_LUT665L         \ Graphic MMU LUT entry 665 low
  $24CC constant GFXMMU_LUT665H         \ Graphic MMU LUT entry 665 high
  $24D0 constant GFXMMU_LUT666L         \ Graphic MMU LUT entry 666 low
  $24D4 constant GFXMMU_LUT666H         \ Graphic MMU LUT entry 666 high
  $24D8 constant GFXMMU_LUT667L         \ Graphic MMU LUT entry 667 low
  $24DC constant GFXMMU_LUT667H         \ Graphic MMU LUT entry 667 high
  $24E0 constant GFXMMU_LUT668L         \ Graphic MMU LUT entry 668 low
  $24E4 constant GFXMMU_LUT668H         \ Graphic MMU LUT entry 668 high
  $24E8 constant GFXMMU_LUT669L         \ Graphic MMU LUT entry 669 low
  $24EC constant GFXMMU_LUT669H         \ Graphic MMU LUT entry 669 high
  $24F0 constant GFXMMU_LUT670L         \ Graphic MMU LUT entry 670 low
  $24F4 constant GFXMMU_LUT670H         \ Graphic MMU LUT entry 670 high
  $24F8 constant GFXMMU_LUT671L         \ Graphic MMU LUT entry 671 low
  $24FC constant GFXMMU_LUT671H         \ Graphic MMU LUT entry 671 high
  $2500 constant GFXMMU_LUT672L         \ Graphic MMU LUT entry 672 low
  $2504 constant GFXMMU_LUT672H         \ Graphic MMU LUT entry 672 high
  $2508 constant GFXMMU_LUT673L         \ Graphic MMU LUT entry 673 low
  $250C constant GFXMMU_LUT673H         \ Graphic MMU LUT entry 673 high
  $2510 constant GFXMMU_LUT674L         \ Graphic MMU LUT entry 674 low
  $2514 constant GFXMMU_LUT674H         \ Graphic MMU LUT entry 674 high
  $2518 constant GFXMMU_LUT675L         \ Graphic MMU LUT entry 675 low
  $251C constant GFXMMU_LUT675H         \ Graphic MMU LUT entry 675 high
  $2520 constant GFXMMU_LUT676L         \ Graphic MMU LUT entry 676 low
  $2524 constant GFXMMU_LUT676H         \ Graphic MMU LUT entry 676 high
  $2528 constant GFXMMU_LUT677L         \ Graphic MMU LUT entry 677 low
  $252C constant GFXMMU_LUT677H         \ Graphic MMU LUT entry 677 high
  $2530 constant GFXMMU_LUT678L         \ Graphic MMU LUT entry 678 low
  $2534 constant GFXMMU_LUT678H         \ Graphic MMU LUT entry 678 high
  $2538 constant GFXMMU_LUT679L         \ Graphic MMU LUT entry 679 low
  $253C constant GFXMMU_LUT679H         \ Graphic MMU LUT entry 679 high
  $2540 constant GFXMMU_LUT680L         \ Graphic MMU LUT entry 680 low
  $2544 constant GFXMMU_LUT680H         \ Graphic MMU LUT entry 680 high
  $2548 constant GFXMMU_LUT681L         \ Graphic MMU LUT entry 681 low
  $254C constant GFXMMU_LUT681H         \ Graphic MMU LUT entry 681 high
  $2550 constant GFXMMU_LUT682L         \ Graphic MMU LUT entry 682 low
  $2554 constant GFXMMU_LUT682H         \ Graphic MMU LUT entry 682 high
  $2558 constant GFXMMU_LUT683L         \ Graphic MMU LUT entry 683 low
  $255C constant GFXMMU_LUT683H         \ Graphic MMU LUT entry 683 high
  $2560 constant GFXMMU_LUT684L         \ Graphic MMU LUT entry 684 low
  $2564 constant GFXMMU_LUT684H         \ Graphic MMU LUT entry 684 high
  $2568 constant GFXMMU_LUT685L         \ Graphic MMU LUT entry 685 low
  $256C constant GFXMMU_LUT685H         \ Graphic MMU LUT entry 685 high
  $2570 constant GFXMMU_LUT686L         \ Graphic MMU LUT entry 686 low
  $2574 constant GFXMMU_LUT686H         \ Graphic MMU LUT entry 686 high
  $2578 constant GFXMMU_LUT687L         \ Graphic MMU LUT entry 687 low
  $257C constant GFXMMU_LUT687H         \ Graphic MMU LUT entry 687 high
  $2580 constant GFXMMU_LUT688L         \ Graphic MMU LUT entry 688 low
  $2584 constant GFXMMU_LUT688H         \ Graphic MMU LUT entry 688 high
  $2588 constant GFXMMU_LUT689L         \ Graphic MMU LUT entry 689 low
  $258C constant GFXMMU_LUT689H         \ Graphic MMU LUT entry 689 high
  $2590 constant GFXMMU_LUT690L         \ Graphic MMU LUT entry 690 low
  $2594 constant GFXMMU_LUT690H         \ Graphic MMU LUT entry 690 high
  $2598 constant GFXMMU_LUT691L         \ Graphic MMU LUT entry 691 low
  $259C constant GFXMMU_LUT691H         \ Graphic MMU LUT entry 691 high
  $25A0 constant GFXMMU_LUT692L         \ Graphic MMU LUT entry 692 low
  $25A4 constant GFXMMU_LUT692H         \ Graphic MMU LUT entry 692 high
  $25A8 constant GFXMMU_LUT693L         \ Graphic MMU LUT entry 693 low
  $25AC constant GFXMMU_LUT693H         \ Graphic MMU LUT entry 693 high
  $25B0 constant GFXMMU_LUT694L         \ Graphic MMU LUT entry 694 low
  $25B4 constant GFXMMU_LUT694H         \ Graphic MMU LUT entry 694 high
  $25B8 constant GFXMMU_LUT695L         \ Graphic MMU LUT entry 695 low
  $25BC constant GFXMMU_LUT695H         \ Graphic MMU LUT entry 695 high
  $25C0 constant GFXMMU_LUT696L         \ Graphic MMU LUT entry 696 low
  $25C4 constant GFXMMU_LUT696H         \ Graphic MMU LUT entry 696 high
  $25C8 constant GFXMMU_LUT697L         \ Graphic MMU LUT entry 697 low
  $25CC constant GFXMMU_LUT697H         \ Graphic MMU LUT entry 697 high
  $25D0 constant GFXMMU_LUT698L         \ Graphic MMU LUT entry 698 low
  $25D4 constant GFXMMU_LUT698H         \ Graphic MMU LUT entry 698 high
  $25D8 constant GFXMMU_LUT699L         \ Graphic MMU LUT entry 699 low
  $25DC constant GFXMMU_LUT699H         \ Graphic MMU LUT entry 699 high
  $25E0 constant GFXMMU_LUT700L         \ Graphic MMU LUT entry 700 low
  $25E4 constant GFXMMU_LUT700H         \ Graphic MMU LUT entry 700 high
  $25E8 constant GFXMMU_LUT701L         \ Graphic MMU LUT entry 701 low
  $25EC constant GFXMMU_LUT701H         \ Graphic MMU LUT entry 701 high
  $25F0 constant GFXMMU_LUT702L         \ Graphic MMU LUT entry 702 low
  $25F4 constant GFXMMU_LUT702H         \ Graphic MMU LUT entry 702 high
  $25F8 constant GFXMMU_LUT703L         \ Graphic MMU LUT entry 703 low
  $25FC constant GFXMMU_LUT703H         \ Graphic MMU LUT entry 703 high
  $2600 constant GFXMMU_LUT704L         \ Graphic MMU LUT entry 704 low
  $2604 constant GFXMMU_LUT704H         \ Graphic MMU LUT entry 704 high
  $2608 constant GFXMMU_LUT705L         \ Graphic MMU LUT entry 705 low
  $260C constant GFXMMU_LUT705H         \ Graphic MMU LUT entry 705 high
  $2610 constant GFXMMU_LUT706L         \ Graphic MMU LUT entry 706 low
  $2614 constant GFXMMU_LUT706H         \ Graphic MMU LUT entry 706 high
  $2618 constant GFXMMU_LUT707L         \ Graphic MMU LUT entry 707 low
  $261C constant GFXMMU_LUT707H         \ Graphic MMU LUT entry 707 high
  $2620 constant GFXMMU_LUT708L         \ Graphic MMU LUT entry 708 low
  $2624 constant GFXMMU_LUT708H         \ Graphic MMU LUT entry 708 high
  $2628 constant GFXMMU_LUT709L         \ Graphic MMU LUT entry 709 low
  $262C constant GFXMMU_LUT709H         \ Graphic MMU LUT entry 709 high
  $2630 constant GFXMMU_LUT710L         \ Graphic MMU LUT entry 710 low
  $2634 constant GFXMMU_LUT710H         \ Graphic MMU LUT entry 710 high
  $2638 constant GFXMMU_LUT711L         \ Graphic MMU LUT entry 711 low
  $263C constant GFXMMU_LUT711H         \ Graphic MMU LUT entry 711 high
  $2640 constant GFXMMU_LUT712L         \ Graphic MMU LUT entry 712 low
  $2644 constant GFXMMU_LUT712H         \ Graphic MMU LUT entry 712 high
  $2648 constant GFXMMU_LUT713L         \ Graphic MMU LUT entry 713 low
  $264C constant GFXMMU_LUT713H         \ Graphic MMU LUT entry 713 high
  $2650 constant GFXMMU_LUT714L         \ Graphic MMU LUT entry 714 low
  $2654 constant GFXMMU_LUT714H         \ Graphic MMU LUT entry 714 high
  $2658 constant GFXMMU_LUT715L         \ Graphic MMU LUT entry 715 low
  $265C constant GFXMMU_LUT715H         \ Graphic MMU LUT entry 715 high
  $2660 constant GFXMMU_LUT716L         \ Graphic MMU LUT entry 716 low
  $2664 constant GFXMMU_LUT716H         \ Graphic MMU LUT entry 716 high
  $2668 constant GFXMMU_LUT717L         \ Graphic MMU LUT entry 717 low
  $266C constant GFXMMU_LUT717H         \ Graphic MMU LUT entry 717 high
  $2670 constant GFXMMU_LUT718L         \ Graphic MMU LUT entry 718 low
  $2674 constant GFXMMU_LUT718H         \ Graphic MMU LUT entry 718 high
  $2678 constant GFXMMU_LUT719L         \ Graphic MMU LUT entry 719 low
  $267C constant GFXMMU_LUT719H         \ Graphic MMU LUT entry 719 high
  $2680 constant GFXMMU_LUT720L         \ Graphic MMU LUT entry 720 low
  $2684 constant GFXMMU_LUT720H         \ Graphic MMU LUT entry 720 high
  $2688 constant GFXMMU_LUT721L         \ Graphic MMU LUT entry 721 low
  $268C constant GFXMMU_LUT721H         \ Graphic MMU LUT entry 721 high
  $2690 constant GFXMMU_LUT722L         \ Graphic MMU LUT entry 722 low
  $2694 constant GFXMMU_LUT722H         \ Graphic MMU LUT entry 722 high
  $2698 constant GFXMMU_LUT723L         \ Graphic MMU LUT entry 723 low
  $269C constant GFXMMU_LUT723H         \ Graphic MMU LUT entry 723 high
  $26A0 constant GFXMMU_LUT724L         \ Graphic MMU LUT entry 724 low
  $26A4 constant GFXMMU_LUT724H         \ Graphic MMU LUT entry 724 high
  $26A8 constant GFXMMU_LUT725L         \ Graphic MMU LUT entry 725 low
  $26AC constant GFXMMU_LUT725H         \ Graphic MMU LUT entry 725 high
  $26B0 constant GFXMMU_LUT726L         \ Graphic MMU LUT entry 726 low
  $26B4 constant GFXMMU_LUT726H         \ Graphic MMU LUT entry 726 high
  $26B8 constant GFXMMU_LUT727L         \ Graphic MMU LUT entry 727 low
  $26BC constant GFXMMU_LUT727H         \ Graphic MMU LUT entry 727 high
  $26C0 constant GFXMMU_LUT728L         \ Graphic MMU LUT entry 728 low
  $26C4 constant GFXMMU_LUT728H         \ Graphic MMU LUT entry 728 high
  $26C8 constant GFXMMU_LUT729L         \ Graphic MMU LUT entry 729 low
  $26CC constant GFXMMU_LUT729H         \ Graphic MMU LUT entry 729 high
  $26D0 constant GFXMMU_LUT730L         \ Graphic MMU LUT entry 730 low
  $26D4 constant GFXMMU_LUT730H         \ Graphic MMU LUT entry 730 high
  $26D8 constant GFXMMU_LUT731L         \ Graphic MMU LUT entry 731 low
  $26DC constant GFXMMU_LUT731H         \ Graphic MMU LUT entry 731 high
  $26E0 constant GFXMMU_LUT732L         \ Graphic MMU LUT entry 732 low
  $26E4 constant GFXMMU_LUT732H         \ Graphic MMU LUT entry 732 high
  $26E8 constant GFXMMU_LUT733L         \ Graphic MMU LUT entry 733 low
  $26EC constant GFXMMU_LUT733H         \ Graphic MMU LUT entry 733 high
  $26F0 constant GFXMMU_LUT734L         \ Graphic MMU LUT entry 734 low
  $26F4 constant GFXMMU_LUT734H         \ Graphic MMU LUT entry 734 high
  $26F8 constant GFXMMU_LUT735L         \ Graphic MMU LUT entry 735 low
  $26FC constant GFXMMU_LUT735H         \ Graphic MMU LUT entry 735 high
  $2700 constant GFXMMU_LUT736L         \ Graphic MMU LUT entry 736 low
  $2704 constant GFXMMU_LUT736H         \ Graphic MMU LUT entry 736 high
  $2708 constant GFXMMU_LUT737L         \ Graphic MMU LUT entry 737 low
  $270C constant GFXMMU_LUT737H         \ Graphic MMU LUT entry 737 high
  $2710 constant GFXMMU_LUT738L         \ Graphic MMU LUT entry 738 low
  $2714 constant GFXMMU_LUT738H         \ Graphic MMU LUT entry 738 high
  $2718 constant GFXMMU_LUT739L         \ Graphic MMU LUT entry 739 low
  $271C constant GFXMMU_LUT739H         \ Graphic MMU LUT entry 739 high
  $2720 constant GFXMMU_LUT740L         \ Graphic MMU LUT entry 740 low
  $2724 constant GFXMMU_LUT740H         \ Graphic MMU LUT entry 740 high
  $2728 constant GFXMMU_LUT741L         \ Graphic MMU LUT entry 741 low
  $272C constant GFXMMU_LUT741H         \ Graphic MMU LUT entry 741 high
  $2730 constant GFXMMU_LUT742L         \ Graphic MMU LUT entry 742 low
  $2734 constant GFXMMU_LUT742H         \ Graphic MMU LUT entry 742 high
  $2738 constant GFXMMU_LUT743L         \ Graphic MMU LUT entry 743 low
  $273C constant GFXMMU_LUT743H         \ Graphic MMU LUT entry 743 high
  $2740 constant GFXMMU_LUT744L         \ Graphic MMU LUT entry 744 low
  $2744 constant GFXMMU_LUT744H         \ Graphic MMU LUT entry 744 high
  $2748 constant GFXMMU_LUT745L         \ Graphic MMU LUT entry 745 low
  $274C constant GFXMMU_LUT745H         \ Graphic MMU LUT entry 745 high
  $2750 constant GFXMMU_LUT746L         \ Graphic MMU LUT entry 746 low
  $2754 constant GFXMMU_LUT746H         \ Graphic MMU LUT entry 746 high
  $2758 constant GFXMMU_LUT747L         \ Graphic MMU LUT entry 747 low
  $275C constant GFXMMU_LUT747H         \ Graphic MMU LUT entry 747 high
  $2760 constant GFXMMU_LUT748L         \ Graphic MMU LUT entry 748 low
  $2764 constant GFXMMU_LUT748H         \ Graphic MMU LUT entry 748 high
  $2768 constant GFXMMU_LUT749L         \ Graphic MMU LUT entry 749 low
  $276C constant GFXMMU_LUT749H         \ Graphic MMU LUT entry 749 high
  $2770 constant GFXMMU_LUT750L         \ Graphic MMU LUT entry 750 low
  $2774 constant GFXMMU_LUT750H         \ Graphic MMU LUT entry 750 high
  $2778 constant GFXMMU_LUT751L         \ Graphic MMU LUT entry 751 low
  $277C constant GFXMMU_LUT751H         \ Graphic MMU LUT entry 751 high
  $2780 constant GFXMMU_LUT752L         \ Graphic MMU LUT entry 752 low
  $2784 constant GFXMMU_LUT752H         \ Graphic MMU LUT entry 752 high
  $2788 constant GFXMMU_LUT753L         \ Graphic MMU LUT entry 753 low
  $278C constant GFXMMU_LUT753H         \ Graphic MMU LUT entry 753 high
  $2790 constant GFXMMU_LUT754L         \ Graphic MMU LUT entry 754 low
  $2794 constant GFXMMU_LUT754H         \ Graphic MMU LUT entry 754 high
  $2798 constant GFXMMU_LUT755L         \ Graphic MMU LUT entry 755 low
  $279C constant GFXMMU_LUT755H         \ Graphic MMU LUT entry 755 high
  $27A0 constant GFXMMU_LUT756L         \ Graphic MMU LUT entry 756 low
  $27A4 constant GFXMMU_LUT756H         \ Graphic MMU LUT entry 756 high
  $27A8 constant GFXMMU_LUT757L         \ Graphic MMU LUT entry 757 low
  $27AC constant GFXMMU_LUT757H         \ Graphic MMU LUT entry 757 high
  $27B0 constant GFXMMU_LUT758L         \ Graphic MMU LUT entry 758 low
  $27B4 constant GFXMMU_LUT758H         \ Graphic MMU LUT entry 758 high
  $27B8 constant GFXMMU_LUT759L         \ Graphic MMU LUT entry 759 low
  $27BC constant GFXMMU_LUT759H         \ Graphic MMU LUT entry 759 high
  $27C0 constant GFXMMU_LUT760L         \ Graphic MMU LUT entry 760 low
  $27C4 constant GFXMMU_LUT760H         \ Graphic MMU LUT entry 760 high
  $27C8 constant GFXMMU_LUT761L         \ Graphic MMU LUT entry 761 low
  $27CC constant GFXMMU_LUT761H         \ Graphic MMU LUT entry 761 high
  $27D0 constant GFXMMU_LUT762L         \ Graphic MMU LUT entry 762 low
  $27D4 constant GFXMMU_LUT762H         \ Graphic MMU LUT entry 762 high
  $27D8 constant GFXMMU_LUT763L         \ Graphic MMU LUT entry 763 low
  $27DC constant GFXMMU_LUT763H         \ Graphic MMU LUT entry 763 high
  $27E0 constant GFXMMU_LUT764L         \ Graphic MMU LUT entry 764 low
  $27E4 constant GFXMMU_LUT764H         \ Graphic MMU LUT entry 764 high
  $27E8 constant GFXMMU_LUT765L         \ Graphic MMU LUT entry 765 low
  $27EC constant GFXMMU_LUT765H         \ Graphic MMU LUT entry 765 high
  $27F0 constant GFXMMU_LUT766L         \ Graphic MMU LUT entry 766 low
  $27F4 constant GFXMMU_LUT766H         \ Graphic MMU LUT entry 766 high
  $27F8 constant GFXMMU_LUT767L         \ Graphic MMU LUT entry 767 low
  $27FC constant GFXMMU_LUT767H         \ Graphic MMU LUT entry 767 high
  $2800 constant GFXMMU_LUT768L         \ Graphic MMU LUT entry 768 low
  $2804 constant GFXMMU_LUT768H         \ Graphic MMU LUT entry 768 high
  $2808 constant GFXMMU_LUT769L         \ Graphic MMU LUT entry 769 low
  $280C constant GFXMMU_LUT769H         \ Graphic MMU LUT entry 769 high
  $2810 constant GFXMMU_LUT770L         \ Graphic MMU LUT entry 770 low
  $2814 constant GFXMMU_LUT770H         \ Graphic MMU LUT entry 770 high
  $2818 constant GFXMMU_LUT771L         \ Graphic MMU LUT entry 771 low
  $281C constant GFXMMU_LUT771H         \ Graphic MMU LUT entry 771 high
  $2820 constant GFXMMU_LUT772L         \ Graphic MMU LUT entry 772 low
  $2824 constant GFXMMU_LUT772H         \ Graphic MMU LUT entry 772 high
  $2828 constant GFXMMU_LUT773L         \ Graphic MMU LUT entry 773 low
  $282C constant GFXMMU_LUT773H         \ Graphic MMU LUT entry 773 high
  $2830 constant GFXMMU_LUT774L         \ Graphic MMU LUT entry 774 low
  $2834 constant GFXMMU_LUT774H         \ Graphic MMU LUT entry 774 high
  $2838 constant GFXMMU_LUT775L         \ Graphic MMU LUT entry 775 low
  $283C constant GFXMMU_LUT775H         \ Graphic MMU LUT entry 775 high
  $2840 constant GFXMMU_LUT776L         \ Graphic MMU LUT entry 776 low
  $2844 constant GFXMMU_LUT776H         \ Graphic MMU LUT entry 776 high
  $2848 constant GFXMMU_LUT777L         \ Graphic MMU LUT entry 777 low
  $284C constant GFXMMU_LUT777H         \ Graphic MMU LUT entry 777 high
  $2850 constant GFXMMU_LUT778L         \ Graphic MMU LUT entry 778 low
  $2854 constant GFXMMU_LUT778H         \ Graphic MMU LUT entry 778 high
  $2858 constant GFXMMU_LUT779L         \ Graphic MMU LUT entry 779 low
  $285C constant GFXMMU_LUT779H         \ Graphic MMU LUT entry 779 high
  $2860 constant GFXMMU_LUT780L         \ Graphic MMU LUT entry 780 low
  $2864 constant GFXMMU_LUT780H         \ Graphic MMU LUT entry 780 high
  $2868 constant GFXMMU_LUT781L         \ Graphic MMU LUT entry 781 low
  $286C constant GFXMMU_LUT781H         \ Graphic MMU LUT entry 781 high
  $2870 constant GFXMMU_LUT782L         \ Graphic MMU LUT entry 782 low
  $2874 constant GFXMMU_LUT782H         \ Graphic MMU LUT entry 782 high
  $2878 constant GFXMMU_LUT783L         \ Graphic MMU LUT entry 783 low
  $287C constant GFXMMU_LUT783H         \ Graphic MMU LUT entry 783 high
  $2880 constant GFXMMU_LUT784L         \ Graphic MMU LUT entry 784 low
  $2884 constant GFXMMU_LUT784H         \ Graphic MMU LUT entry 784 high
  $2888 constant GFXMMU_LUT785L         \ Graphic MMU LUT entry 785 low
  $288C constant GFXMMU_LUT785H         \ Graphic MMU LUT entry 785 high
  $2890 constant GFXMMU_LUT786L         \ Graphic MMU LUT entry 786 low
  $2894 constant GFXMMU_LUT786H         \ Graphic MMU LUT entry 786 high
  $2898 constant GFXMMU_LUT787L         \ Graphic MMU LUT entry 787 low
  $289C constant GFXMMU_LUT787H         \ Graphic MMU LUT entry 787 high
  $28A0 constant GFXMMU_LUT788L         \ Graphic MMU LUT entry 788 low
  $28A4 constant GFXMMU_LUT788H         \ Graphic MMU LUT entry 788 high
  $28A8 constant GFXMMU_LUT789L         \ Graphic MMU LUT entry 789 low
  $28AC constant GFXMMU_LUT789H         \ Graphic MMU LUT entry 789 high
  $28B0 constant GFXMMU_LUT790L         \ Graphic MMU LUT entry 790 low
  $28B4 constant GFXMMU_LUT790H         \ Graphic MMU LUT entry 790 high
  $28B8 constant GFXMMU_LUT791L         \ Graphic MMU LUT entry 791 low
  $28BC constant GFXMMU_LUT791H         \ Graphic MMU LUT entry 791 high
  $28C0 constant GFXMMU_LUT792L         \ Graphic MMU LUT entry 792 low
  $28C4 constant GFXMMU_LUT792H         \ Graphic MMU LUT entry 792 high
  $28C8 constant GFXMMU_LUT793L         \ Graphic MMU LUT entry 793 low
  $28CC constant GFXMMU_LUT793H         \ Graphic MMU LUT entry 793 high
  $28D0 constant GFXMMU_LUT794L         \ Graphic MMU LUT entry 794 low
  $28D4 constant GFXMMU_LUT794H         \ Graphic MMU LUT entry 794 high
  $28D8 constant GFXMMU_LUT795L         \ Graphic MMU LUT entry 795 low
  $28DC constant GFXMMU_LUT795H         \ Graphic MMU LUT entry 795 high
  $28E0 constant GFXMMU_LUT796L         \ Graphic MMU LUT entry 796 low
  $28E4 constant GFXMMU_LUT796H         \ Graphic MMU LUT entry 796 high
  $28E8 constant GFXMMU_LUT797L         \ Graphic MMU LUT entry 797 low
  $28EC constant GFXMMU_LUT797H         \ Graphic MMU LUT entry 797 high
  $28F0 constant GFXMMU_LUT798L         \ Graphic MMU LUT entry 798 low
  $28F4 constant GFXMMU_LUT798H         \ Graphic MMU LUT entry 798 high
  $28F8 constant GFXMMU_LUT799L         \ Graphic MMU LUT entry 799 low
  $28FC constant GFXMMU_LUT799H         \ Graphic MMU LUT entry 799 high
  $2900 constant GFXMMU_LUT800L         \ Graphic MMU LUT entry 800 low
  $2904 constant GFXMMU_LUT800H         \ Graphic MMU LUT entry 800 high
  $2908 constant GFXMMU_LUT801L         \ Graphic MMU LUT entry 801 low
  $290C constant GFXMMU_LUT801H         \ Graphic MMU LUT entry 801 high
  $2910 constant GFXMMU_LUT802L         \ Graphic MMU LUT entry 802 low
  $2914 constant GFXMMU_LUT802H         \ Graphic MMU LUT entry 802 high
  $2918 constant GFXMMU_LUT803L         \ Graphic MMU LUT entry 803 low
  $291C constant GFXMMU_LUT803H         \ Graphic MMU LUT entry 803 high
  $2920 constant GFXMMU_LUT804L         \ Graphic MMU LUT entry 804 low
  $2924 constant GFXMMU_LUT804H         \ Graphic MMU LUT entry 804 high
  $2928 constant GFXMMU_LUT805L         \ Graphic MMU LUT entry 805 low
  $292C constant GFXMMU_LUT805H         \ Graphic MMU LUT entry 805 high
  $2930 constant GFXMMU_LUT806L         \ Graphic MMU LUT entry 806 low
  $2934 constant GFXMMU_LUT806H         \ Graphic MMU LUT entry 806 high
  $2938 constant GFXMMU_LUT807L         \ Graphic MMU LUT entry 807 low
  $293C constant GFXMMU_LUT807H         \ Graphic MMU LUT entry 807 high
  $2940 constant GFXMMU_LUT808L         \ Graphic MMU LUT entry 808 low
  $2944 constant GFXMMU_LUT808H         \ Graphic MMU LUT entry 808 high
  $2948 constant GFXMMU_LUT809L         \ Graphic MMU LUT entry 809 low
  $294C constant GFXMMU_LUT809H         \ Graphic MMU LUT entry 809 high
  $2950 constant GFXMMU_LUT810L         \ Graphic MMU LUT entry 810 low
  $2954 constant GFXMMU_LUT810H         \ Graphic MMU LUT entry 810 high
  $2958 constant GFXMMU_LUT811L         \ Graphic MMU LUT entry 811 low
  $295C constant GFXMMU_LUT811H         \ Graphic MMU LUT entry 811 high
  $2960 constant GFXMMU_LUT812L         \ Graphic MMU LUT entry 812 low
  $2964 constant GFXMMU_LUT812H         \ Graphic MMU LUT entry 812 high
  $2968 constant GFXMMU_LUT813L         \ Graphic MMU LUT entry 813 low
  $296C constant GFXMMU_LUT813H         \ Graphic MMU LUT entry 813 high
  $2970 constant GFXMMU_LUT814L         \ Graphic MMU LUT entry 814 low
  $2974 constant GFXMMU_LUT814H         \ Graphic MMU LUT entry 814 high
  $2978 constant GFXMMU_LUT815L         \ Graphic MMU LUT entry 815 low
  $297C constant GFXMMU_LUT815H         \ Graphic MMU LUT entry 815 high
  $2980 constant GFXMMU_LUT816L         \ Graphic MMU LUT entry 816 low
  $2984 constant GFXMMU_LUT816H         \ Graphic MMU LUT entry 816 high
  $2988 constant GFXMMU_LUT817L         \ Graphic MMU LUT entry 817 low
  $298C constant GFXMMU_LUT817H         \ Graphic MMU LUT entry 817 high
  $2990 constant GFXMMU_LUT818L         \ Graphic MMU LUT entry 818 low
  $2994 constant GFXMMU_LUT818H         \ Graphic MMU LUT entry 818 high
  $2998 constant GFXMMU_LUT819L         \ Graphic MMU LUT entry 819 low
  $299C constant GFXMMU_LUT819H         \ Graphic MMU LUT entry 819 high
  $29A0 constant GFXMMU_LUT820L         \ Graphic MMU LUT entry 820 low
  $29A4 constant GFXMMU_LUT820H         \ Graphic MMU LUT entry 820 high
  $29A8 constant GFXMMU_LUT821L         \ Graphic MMU LUT entry 821 low
  $29AC constant GFXMMU_LUT821H         \ Graphic MMU LUT entry 821 high
  $29B0 constant GFXMMU_LUT822L         \ Graphic MMU LUT entry 822 low
  $29B4 constant GFXMMU_LUT822H         \ Graphic MMU LUT entry 822 high
  $29B8 constant GFXMMU_LUT823L         \ Graphic MMU LUT entry 823 low
  $29BC constant GFXMMU_LUT823H         \ Graphic MMU LUT entry 823 high
  $29C0 constant GFXMMU_LUT824L         \ Graphic MMU LUT entry 824 low
  $29C4 constant GFXMMU_LUT824H         \ Graphic MMU LUT entry 824 high
  $29C8 constant GFXMMU_LUT825L         \ Graphic MMU LUT entry 825 low
  $29CC constant GFXMMU_LUT825H         \ Graphic MMU LUT entry 825 high
  $29D0 constant GFXMMU_LUT826L         \ Graphic MMU LUT entry 826 low
  $29D4 constant GFXMMU_LUT826H         \ Graphic MMU LUT entry 826 high
  $29D8 constant GFXMMU_LUT827L         \ Graphic MMU LUT entry 827 low
  $29DC constant GFXMMU_LUT827H         \ Graphic MMU LUT entry 827 high
  $29E0 constant GFXMMU_LUT828L         \ Graphic MMU LUT entry 828 low
  $29E4 constant GFXMMU_LUT828H         \ Graphic MMU LUT entry 828 high
  $29E8 constant GFXMMU_LUT829L         \ Graphic MMU LUT entry 829 low
  $29EC constant GFXMMU_LUT829H         \ Graphic MMU LUT entry 829 high
  $29F0 constant GFXMMU_LUT830L         \ Graphic MMU LUT entry 830 low
  $29F4 constant GFXMMU_LUT830H         \ Graphic MMU LUT entry 830 high
  $29F8 constant GFXMMU_LUT831L         \ Graphic MMU LUT entry 831 low
  $29FC constant GFXMMU_LUT831H         \ Graphic MMU LUT entry 831 high
  $2A00 constant GFXMMU_LUT832L         \ Graphic MMU LUT entry 832 low
  $2A04 constant GFXMMU_LUT832H         \ Graphic MMU LUT entry 832 high
  $2A08 constant GFXMMU_LUT833L         \ Graphic MMU LUT entry 833 low
  $2A0C constant GFXMMU_LUT833H         \ Graphic MMU LUT entry 833 high
  $2A10 constant GFXMMU_LUT834L         \ Graphic MMU LUT entry 834 low
  $2A14 constant GFXMMU_LUT834H         \ Graphic MMU LUT entry 834 high
  $2A18 constant GFXMMU_LUT835L         \ Graphic MMU LUT entry 835 low
  $2A1C constant GFXMMU_LUT835H         \ Graphic MMU LUT entry 835 high
  $2A20 constant GFXMMU_LUT836L         \ Graphic MMU LUT entry 836 low
  $2A24 constant GFXMMU_LUT836H         \ Graphic MMU LUT entry 836 high
  $2A28 constant GFXMMU_LUT837L         \ Graphic MMU LUT entry 837 low
  $2A2C constant GFXMMU_LUT837H         \ Graphic MMU LUT entry 837 high
  $2A30 constant GFXMMU_LUT838L         \ Graphic MMU LUT entry 838 low
  $2A34 constant GFXMMU_LUT838H         \ Graphic MMU LUT entry 838 high
  $2A38 constant GFXMMU_LUT839L         \ Graphic MMU LUT entry 839 low
  $2A3C constant GFXMMU_LUT839H         \ Graphic MMU LUT entry 839 high
  $2A40 constant GFXMMU_LUT840L         \ Graphic MMU LUT entry 840 low
  $2A44 constant GFXMMU_LUT840H         \ Graphic MMU LUT entry 840 high
  $2A48 constant GFXMMU_LUT841L         \ Graphic MMU LUT entry 841 low
  $2A4C constant GFXMMU_LUT841H         \ Graphic MMU LUT entry 841 high
  $2A50 constant GFXMMU_LUT842L         \ Graphic MMU LUT entry 842 low
  $2A54 constant GFXMMU_LUT842H         \ Graphic MMU LUT entry 842 high
  $2A58 constant GFXMMU_LUT843L         \ Graphic MMU LUT entry 843 low
  $2A5C constant GFXMMU_LUT843H         \ Graphic MMU LUT entry 843 high
  $2A60 constant GFXMMU_LUT844L         \ Graphic MMU LUT entry 844 low
  $2A64 constant GFXMMU_LUT844H         \ Graphic MMU LUT entry 844 high
  $2A68 constant GFXMMU_LUT845L         \ Graphic MMU LUT entry 845 low
  $2A6C constant GFXMMU_LUT845H         \ Graphic MMU LUT entry 845 high
  $2A70 constant GFXMMU_LUT846L         \ Graphic MMU LUT entry 846 low
  $2A74 constant GFXMMU_LUT846H         \ Graphic MMU LUT entry 846 high
  $2A78 constant GFXMMU_LUT847L         \ Graphic MMU LUT entry 847 low
  $2A7C constant GFXMMU_LUT847H         \ Graphic MMU LUT entry 847 high
  $2A80 constant GFXMMU_LUT848L         \ Graphic MMU LUT entry 848 low
  $2A84 constant GFXMMU_LUT848H         \ Graphic MMU LUT entry 848 high
  $2A88 constant GFXMMU_LUT849L         \ Graphic MMU LUT entry 849 low
  $2A8C constant GFXMMU_LUT849H         \ Graphic MMU LUT entry 849 high
  $2A90 constant GFXMMU_LUT850L         \ Graphic MMU LUT entry 850 low
  $2A94 constant GFXMMU_LUT850H         \ Graphic MMU LUT entry 850 high
  $2A98 constant GFXMMU_LUT851L         \ Graphic MMU LUT entry 851 low
  $2A9C constant GFXMMU_LUT851H         \ Graphic MMU LUT entry 851 high
  $2AA0 constant GFXMMU_LUT852L         \ Graphic MMU LUT entry 852 low
  $2AA4 constant GFXMMU_LUT852H         \ Graphic MMU LUT entry 852 high
  $2AA8 constant GFXMMU_LUT853L         \ Graphic MMU LUT entry 853 low
  $2AAC constant GFXMMU_LUT853H         \ Graphic MMU LUT entry 853 high
  $2AB0 constant GFXMMU_LUT854L         \ Graphic MMU LUT entry 854 low
  $2AB4 constant GFXMMU_LUT854H         \ Graphic MMU LUT entry 854 high
  $2AB8 constant GFXMMU_LUT855L         \ Graphic MMU LUT entry 855 low
  $2ABC constant GFXMMU_LUT855H         \ Graphic MMU LUT entry 855 high
  $2AC0 constant GFXMMU_LUT856L         \ Graphic MMU LUT entry 856 low
  $2AC4 constant GFXMMU_LUT856H         \ Graphic MMU LUT entry 856 high
  $2AC8 constant GFXMMU_LUT857L         \ Graphic MMU LUT entry 857 low
  $2ACC constant GFXMMU_LUT857H         \ Graphic MMU LUT entry 857 high
  $2AD0 constant GFXMMU_LUT858L         \ Graphic MMU LUT entry 858 low
  $2AD4 constant GFXMMU_LUT858H         \ Graphic MMU LUT entry 858 high
  $2AD8 constant GFXMMU_LUT859L         \ Graphic MMU LUT entry 859 low
  $2ADC constant GFXMMU_LUT859H         \ Graphic MMU LUT entry 859 high
  $2AE0 constant GFXMMU_LUT860L         \ Graphic MMU LUT entry 860 low
  $2AE4 constant GFXMMU_LUT860H         \ Graphic MMU LUT entry 860 high
  $2AE8 constant GFXMMU_LUT861L         \ Graphic MMU LUT entry 861 low
  $2AEC constant GFXMMU_LUT861H         \ Graphic MMU LUT entry 861 high
  $2AF0 constant GFXMMU_LUT862L         \ Graphic MMU LUT entry 862 low
  $2AF4 constant GFXMMU_LUT862H         \ Graphic MMU LUT entry 862 high
  $2AF8 constant GFXMMU_LUT863L         \ Graphic MMU LUT entry 863 low
  $2AFC constant GFXMMU_LUT863H         \ Graphic MMU LUT entry 863 high
  $2B00 constant GFXMMU_LUT864L         \ Graphic MMU LUT entry 864 low
  $2B04 constant GFXMMU_LUT864H         \ Graphic MMU LUT entry 864 high
  $2B08 constant GFXMMU_LUT865L         \ Graphic MMU LUT entry 865 low
  $2B0C constant GFXMMU_LUT865H         \ Graphic MMU LUT entry 865 high
  $2B10 constant GFXMMU_LUT866L         \ Graphic MMU LUT entry 866 low
  $2B14 constant GFXMMU_LUT866H         \ Graphic MMU LUT entry 866 high
  $2B18 constant GFXMMU_LUT867L         \ Graphic MMU LUT entry 867 low
  $2B1C constant GFXMMU_LUT867H         \ Graphic MMU LUT entry 867 high
  $2B20 constant GFXMMU_LUT868L         \ Graphic MMU LUT entry 868 low
  $2B24 constant GFXMMU_LUT868H         \ Graphic MMU LUT entry 868 high
  $2B28 constant GFXMMU_LUT869L         \ Graphic MMU LUT entry 869 low
  $2B2C constant GFXMMU_LUT869H         \ Graphic MMU LUT entry 869 high
  $2B30 constant GFXMMU_LUT870L         \ Graphic MMU LUT entry 870 low
  $2B34 constant GFXMMU_LUT870H         \ Graphic MMU LUT entry 870 high
  $2B38 constant GFXMMU_LUT871L         \ Graphic MMU LUT entry 871 low
  $2B3C constant GFXMMU_LUT871H         \ Graphic MMU LUT entry 871 high
  $2B40 constant GFXMMU_LUT872L         \ Graphic MMU LUT entry 872 low
  $2B44 constant GFXMMU_LUT872H         \ Graphic MMU LUT entry 872 high
  $2B48 constant GFXMMU_LUT873L         \ Graphic MMU LUT entry 873 low
  $2B4C constant GFXMMU_LUT873H         \ Graphic MMU LUT entry 873 high
  $2B50 constant GFXMMU_LUT874L         \ Graphic MMU LUT entry 874 low
  $2B54 constant GFXMMU_LUT874H         \ Graphic MMU LUT entry 874 high
  $2B58 constant GFXMMU_LUT875L         \ Graphic MMU LUT entry 875 low
  $2B5C constant GFXMMU_LUT875H         \ Graphic MMU LUT entry 875 high
  $2B60 constant GFXMMU_LUT876L         \ Graphic MMU LUT entry 876 low
  $2B64 constant GFXMMU_LUT876H         \ Graphic MMU LUT entry 876 high
  $2B68 constant GFXMMU_LUT877L         \ Graphic MMU LUT entry 877 low
  $2B6C constant GFXMMU_LUT877H         \ Graphic MMU LUT entry 877 high
  $2B70 constant GFXMMU_LUT878L         \ Graphic MMU LUT entry 878 low
  $2B74 constant GFXMMU_LUT878H         \ Graphic MMU LUT entry 878 high
  $2B78 constant GFXMMU_LUT879L         \ Graphic MMU LUT entry 879 low
  $2B7C constant GFXMMU_LUT879H         \ Graphic MMU LUT entry 879 high
  $2B80 constant GFXMMU_LUT880L         \ Graphic MMU LUT entry 880 low
  $2B84 constant GFXMMU_LUT880H         \ Graphic MMU LUT entry 880 high
  $2B88 constant GFXMMU_LUT881L         \ Graphic MMU LUT entry 881 low
  $2B8C constant GFXMMU_LUT881H         \ Graphic MMU LUT entry 881 high
  $2B90 constant GFXMMU_LUT882L         \ Graphic MMU LUT entry 882 low
  $2B94 constant GFXMMU_LUT882H         \ Graphic MMU LUT entry 882 high
  $2B98 constant GFXMMU_LUT883L         \ Graphic MMU LUT entry 883 low
  $2B9C constant GFXMMU_LUT883H         \ Graphic MMU LUT entry 883 high
  $2BA0 constant GFXMMU_LUT884L         \ Graphic MMU LUT entry 884 low
  $2BA4 constant GFXMMU_LUT884H         \ Graphic MMU LUT entry 884 high
  $2BA8 constant GFXMMU_LUT885L         \ Graphic MMU LUT entry 885 low
  $2BAC constant GFXMMU_LUT885H         \ Graphic MMU LUT entry 885 high
  $2BB0 constant GFXMMU_LUT886L         \ Graphic MMU LUT entry 886 low
  $2BB4 constant GFXMMU_LUT886H         \ Graphic MMU LUT entry 886 high
  $2BB8 constant GFXMMU_LUT887L         \ Graphic MMU LUT entry 887 low
  $2BBC constant GFXMMU_LUT887H         \ Graphic MMU LUT entry 887 high
  $2BC0 constant GFXMMU_LUT888L         \ Graphic MMU LUT entry 888 low
  $2BC4 constant GFXMMU_LUT888H         \ Graphic MMU LUT entry 888 high
  $2BC8 constant GFXMMU_LUT889L         \ Graphic MMU LUT entry 889 low
  $2BCC constant GFXMMU_LUT889H         \ Graphic MMU LUT entry 889 high
  $2BD0 constant GFXMMU_LUT890L         \ Graphic MMU LUT entry 890 low
  $2BD4 constant GFXMMU_LUT890H         \ Graphic MMU LUT entry 890 high
  $2BD8 constant GFXMMU_LUT891L         \ Graphic MMU LUT entry 891 low
  $2BDC constant GFXMMU_LUT891H         \ Graphic MMU LUT entry 891 high
  $2BE0 constant GFXMMU_LUT892L         \ Graphic MMU LUT entry 892 low
  $2BE4 constant GFXMMU_LUT892H         \ Graphic MMU LUT entry 892 high
  $2BE8 constant GFXMMU_LUT893L         \ Graphic MMU LUT entry 893 low
  $2BEC constant GFXMMU_LUT893H         \ Graphic MMU LUT entry 893 high
  $2BF0 constant GFXMMU_LUT894L         \ Graphic MMU LUT entry 894 low
  $2BF4 constant GFXMMU_LUT894H         \ Graphic MMU LUT entry 894 high
  $2BF8 constant GFXMMU_LUT895L         \ Graphic MMU LUT entry 895 low
  $2BFC constant GFXMMU_LUT895H         \ Graphic MMU LUT entry 895 high
  $2C00 constant GFXMMU_LUT896L         \ Graphic MMU LUT entry 896 low
  $2C04 constant GFXMMU_LUT896H         \ Graphic MMU LUT entry 896 high
  $2C08 constant GFXMMU_LUT897L         \ Graphic MMU LUT entry 897 low
  $2C0C constant GFXMMU_LUT897H         \ Graphic MMU LUT entry 897 high
  $2C10 constant GFXMMU_LUT898L         \ Graphic MMU LUT entry 898 low
  $2C14 constant GFXMMU_LUT898H         \ Graphic MMU LUT entry 898 high
  $2C18 constant GFXMMU_LUT899L         \ Graphic MMU LUT entry 899 low
  $2C1C constant GFXMMU_LUT899H         \ Graphic MMU LUT entry 899 high
  $2C20 constant GFXMMU_LUT900L         \ Graphic MMU LUT entry 900 low
  $2C24 constant GFXMMU_LUT900H         \ Graphic MMU LUT entry 900 high
  $2C28 constant GFXMMU_LUT901L         \ Graphic MMU LUT entry 901 low
  $2C2C constant GFXMMU_LUT901H         \ Graphic MMU LUT entry 901 high
  $2C30 constant GFXMMU_LUT902L         \ Graphic MMU LUT entry 902 low
  $2C34 constant GFXMMU_LUT902H         \ Graphic MMU LUT entry 902 high
  $2C38 constant GFXMMU_LUT903L         \ Graphic MMU LUT entry 903 low
  $2C3C constant GFXMMU_LUT903H         \ Graphic MMU LUT entry 903 high
  $2C40 constant GFXMMU_LUT904L         \ Graphic MMU LUT entry 904 low
  $2C44 constant GFXMMU_LUT904H         \ Graphic MMU LUT entry 904 high
  $2C48 constant GFXMMU_LUT905L         \ Graphic MMU LUT entry 905 low
  $2C4C constant GFXMMU_LUT905H         \ Graphic MMU LUT entry 905 high
  $2C50 constant GFXMMU_LUT906L         \ Graphic MMU LUT entry 906 low
  $2C54 constant GFXMMU_LUT906H         \ Graphic MMU LUT entry 906 high
  $2C58 constant GFXMMU_LUT907L         \ Graphic MMU LUT entry 907 low
  $2C5C constant GFXMMU_LUT907H         \ Graphic MMU LUT entry 907 high
  $2C60 constant GFXMMU_LUT908L         \ Graphic MMU LUT entry 908 low
  $2C64 constant GFXMMU_LUT908H         \ Graphic MMU LUT entry 908 high
  $2C68 constant GFXMMU_LUT909L         \ Graphic MMU LUT entry 909 low
  $2C6C constant GFXMMU_LUT909H         \ Graphic MMU LUT entry 909 high
  $2C70 constant GFXMMU_LUT910L         \ Graphic MMU LUT entry 910 low
  $2C74 constant GFXMMU_LUT910H         \ Graphic MMU LUT entry 910 high
  $2C78 constant GFXMMU_LUT911L         \ Graphic MMU LUT entry 911 low
  $2C7C constant GFXMMU_LUT911H         \ Graphic MMU LUT entry 911 high
  $2C80 constant GFXMMU_LUT912L         \ Graphic MMU LUT entry 912 low
  $2C84 constant GFXMMU_LUT912H         \ Graphic MMU LUT entry 912 high
  $2C88 constant GFXMMU_LUT913L         \ Graphic MMU LUT entry 913 low
  $2C8C constant GFXMMU_LUT913H         \ Graphic MMU LUT entry 913 high
  $2C90 constant GFXMMU_LUT914L         \ Graphic MMU LUT entry 914 low
  $2C94 constant GFXMMU_LUT914H         \ Graphic MMU LUT entry 914 high
  $2C98 constant GFXMMU_LUT915L         \ Graphic MMU LUT entry 915 low
  $2C9C constant GFXMMU_LUT915H         \ Graphic MMU LUT entry 915 high
  $2CA0 constant GFXMMU_LUT916L         \ Graphic MMU LUT entry 916 low
  $2CA4 constant GFXMMU_LUT916H         \ Graphic MMU LUT entry 916 high
  $2CA8 constant GFXMMU_LUT917L         \ Graphic MMU LUT entry 917 low
  $2CAC constant GFXMMU_LUT917H         \ Graphic MMU LUT entry 917 high
  $2CB0 constant GFXMMU_LUT918L         \ Graphic MMU LUT entry 918 low
  $2CB4 constant GFXMMU_LUT918H         \ Graphic MMU LUT entry 918 high
  $2CB8 constant GFXMMU_LUT919L         \ Graphic MMU LUT entry 919 low
  $2CBC constant GFXMMU_LUT919H         \ Graphic MMU LUT entry 919 high
  $2CC0 constant GFXMMU_LUT920L         \ Graphic MMU LUT entry 920 low
  $2CC4 constant GFXMMU_LUT920H         \ Graphic MMU LUT entry 920 high
  $2CC8 constant GFXMMU_LUT921L         \ Graphic MMU LUT entry 921 low
  $2CCC constant GFXMMU_LUT921H         \ Graphic MMU LUT entry 921 high
  $2CD0 constant GFXMMU_LUT922L         \ Graphic MMU LUT entry 922 low
  $2CD4 constant GFXMMU_LUT922H         \ Graphic MMU LUT entry 922 high
  $2CD8 constant GFXMMU_LUT923L         \ Graphic MMU LUT entry 923 low
  $2CDC constant GFXMMU_LUT923H         \ Graphic MMU LUT entry 923 high
  $2CE0 constant GFXMMU_LUT924L         \ Graphic MMU LUT entry 924 low
  $2CE4 constant GFXMMU_LUT924H         \ Graphic MMU LUT entry 924 high
  $2CE8 constant GFXMMU_LUT925L         \ Graphic MMU LUT entry 925 low
  $2CEC constant GFXMMU_LUT925H         \ Graphic MMU LUT entry 925 high
  $2CF0 constant GFXMMU_LUT926L         \ Graphic MMU LUT entry 926 low
  $2CF4 constant GFXMMU_LUT926H         \ Graphic MMU LUT entry 926 high
  $2CF8 constant GFXMMU_LUT927L         \ Graphic MMU LUT entry 927 low
  $2CFC constant GFXMMU_LUT927H         \ Graphic MMU LUT entry 927 high
  $2D00 constant GFXMMU_LUT928L         \ Graphic MMU LUT entry 928 low
  $2D04 constant GFXMMU_LUT928H         \ Graphic MMU LUT entry 928 high
  $2D08 constant GFXMMU_LUT929L         \ Graphic MMU LUT entry 929 low
  $2D0C constant GFXMMU_LUT929H         \ Graphic MMU LUT entry 929 high
  $2D10 constant GFXMMU_LUT930L         \ Graphic MMU LUT entry 930 low
  $2D14 constant GFXMMU_LUT930H         \ Graphic MMU LUT entry 930 high
  $2D18 constant GFXMMU_LUT931L         \ Graphic MMU LUT entry 931 low
  $2D1C constant GFXMMU_LUT931H         \ Graphic MMU LUT entry 931 high
  $2D20 constant GFXMMU_LUT932L         \ Graphic MMU LUT entry 932 low
  $2D24 constant GFXMMU_LUT932H         \ Graphic MMU LUT entry 932 high
  $2D28 constant GFXMMU_LUT933L         \ Graphic MMU LUT entry 933 low
  $2D2C constant GFXMMU_LUT933H         \ Graphic MMU LUT entry 933 high
  $2D30 constant GFXMMU_LUT934L         \ Graphic MMU LUT entry 934 low
  $2D34 constant GFXMMU_LUT934H         \ Graphic MMU LUT entry 934 high
  $2D38 constant GFXMMU_LUT935L         \ Graphic MMU LUT entry 935 low
  $2D3C constant GFXMMU_LUT935H         \ Graphic MMU LUT entry 935 high
  $2D40 constant GFXMMU_LUT936L         \ Graphic MMU LUT entry 936 low
  $2D44 constant GFXMMU_LUT936H         \ Graphic MMU LUT entry 936 high
  $2D48 constant GFXMMU_LUT937L         \ Graphic MMU LUT entry 937 low
  $2D4C constant GFXMMU_LUT937H         \ Graphic MMU LUT entry 937 high
  $2D50 constant GFXMMU_LUT938L         \ Graphic MMU LUT entry 938 low
  $2D54 constant GFXMMU_LUT938H         \ Graphic MMU LUT entry 938 high
  $2D58 constant GFXMMU_LUT939L         \ Graphic MMU LUT entry 939 low
  $2D5C constant GFXMMU_LUT939H         \ Graphic MMU LUT entry 939 high
  $2D60 constant GFXMMU_LUT940L         \ Graphic MMU LUT entry 940 low
  $2D64 constant GFXMMU_LUT940H         \ Graphic MMU LUT entry 940 high
  $2D68 constant GFXMMU_LUT941L         \ Graphic MMU LUT entry 941 low
  $2D6C constant GFXMMU_LUT941H         \ Graphic MMU LUT entry 941 high
  $2D70 constant GFXMMU_LUT942L         \ Graphic MMU LUT entry 942 low
  $2D74 constant GFXMMU_LUT942H         \ Graphic MMU LUT entry 942 high
  $2D78 constant GFXMMU_LUT943L         \ Graphic MMU LUT entry 943 low
  $2D7C constant GFXMMU_LUT943H         \ Graphic MMU LUT entry 943 high
  $2D80 constant GFXMMU_LUT944L         \ Graphic MMU LUT entry 944 low
  $2D84 constant GFXMMU_LUT944H         \ Graphic MMU LUT entry 944 high
  $2D88 constant GFXMMU_LUT945L         \ Graphic MMU LUT entry 945 low
  $2D8C constant GFXMMU_LUT945H         \ Graphic MMU LUT entry 945 high
  $2D90 constant GFXMMU_LUT946L         \ Graphic MMU LUT entry 946 low
  $2D94 constant GFXMMU_LUT946H         \ Graphic MMU LUT entry 946 high
  $2D98 constant GFXMMU_LUT947L         \ Graphic MMU LUT entry 947 low
  $2D9C constant GFXMMU_LUT947H         \ Graphic MMU LUT entry 947 high
  $2DA0 constant GFXMMU_LUT948L         \ Graphic MMU LUT entry 948 low
  $2DA4 constant GFXMMU_LUT948H         \ Graphic MMU LUT entry 948 high
  $2DA8 constant GFXMMU_LUT949L         \ Graphic MMU LUT entry 949 low
  $2DAC constant GFXMMU_LUT949H         \ Graphic MMU LUT entry 949 high
  $2DB0 constant GFXMMU_LUT950L         \ Graphic MMU LUT entry 950 low
  $2DB4 constant GFXMMU_LUT950H         \ Graphic MMU LUT entry 950 high
  $2DB8 constant GFXMMU_LUT951L         \ Graphic MMU LUT entry 951 low
  $2DBC constant GFXMMU_LUT951H         \ Graphic MMU LUT entry 951 high
  $2DC0 constant GFXMMU_LUT952L         \ Graphic MMU LUT entry 952 low
  $2DC4 constant GFXMMU_LUT952H         \ Graphic MMU LUT entry 952 high
  $2DC8 constant GFXMMU_LUT953L         \ Graphic MMU LUT entry 953 low
  $2DCC constant GFXMMU_LUT953H         \ Graphic MMU LUT entry 953 high
  $2DD0 constant GFXMMU_LUT954L         \ Graphic MMU LUT entry 954 low
  $2DD4 constant GFXMMU_LUT954H         \ Graphic MMU LUT entry 954 high
  $2DD8 constant GFXMMU_LUT955L         \ Graphic MMU LUT entry 955 low
  $2DDC constant GFXMMU_LUT955H         \ Graphic MMU LUT entry 955 high
  $2DE0 constant GFXMMU_LUT956L         \ Graphic MMU LUT entry 956 low
  $2DE4 constant GFXMMU_LUT956H         \ Graphic MMU LUT entry 956 high
  $2DE8 constant GFXMMU_LUT957L         \ Graphic MMU LUT entry 957 low
  $2DEC constant GFXMMU_LUT957H         \ Graphic MMU LUT entry 957 high
  $2DF0 constant GFXMMU_LUT958L         \ Graphic MMU LUT entry 958 low
  $2DF4 constant GFXMMU_LUT958H         \ Graphic MMU LUT entry 958 high
  $2DF8 constant GFXMMU_LUT959L         \ Graphic MMU LUT entry 959 low
  $2DFC constant GFXMMU_LUT959H         \ Graphic MMU LUT entry 959 high
  $2E00 constant GFXMMU_LUT960L         \ Graphic MMU LUT entry 960 low
  $2E04 constant GFXMMU_LUT960H         \ Graphic MMU LUT entry 960 high
  $2E08 constant GFXMMU_LUT961L         \ Graphic MMU LUT entry 961 low
  $2E0C constant GFXMMU_LUT961H         \ Graphic MMU LUT entry 961 high
  $2E10 constant GFXMMU_LUT962L         \ Graphic MMU LUT entry 962 low
  $2E14 constant GFXMMU_LUT962H         \ Graphic MMU LUT entry 962 high
  $2E18 constant GFXMMU_LUT963L         \ Graphic MMU LUT entry 963 low
  $2E1C constant GFXMMU_LUT963H         \ Graphic MMU LUT entry 963 high
  $2E20 constant GFXMMU_LUT964L         \ Graphic MMU LUT entry 964 low
  $2E24 constant GFXMMU_LUT964H         \ Graphic MMU LUT entry 964 high
  $2E28 constant GFXMMU_LUT965L         \ Graphic MMU LUT entry 965 low
  $2E2C constant GFXMMU_LUT965H         \ Graphic MMU LUT entry 965 high
  $2E30 constant GFXMMU_LUT966L         \ Graphic MMU LUT entry 966 low
  $2E34 constant GFXMMU_LUT966H         \ Graphic MMU LUT entry 966 high
  $2E38 constant GFXMMU_LUT967L         \ Graphic MMU LUT entry 967 low
  $2E3C constant GFXMMU_LUT967H         \ Graphic MMU LUT entry 967 high
  $2E40 constant GFXMMU_LUT968L         \ Graphic MMU LUT entry 968 low
  $2E44 constant GFXMMU_LUT968H         \ Graphic MMU LUT entry 968 high
  $2E48 constant GFXMMU_LUT969L         \ Graphic MMU LUT entry 969 low
  $2E4C constant GFXMMU_LUT969H         \ Graphic MMU LUT entry 969 high
  $2E50 constant GFXMMU_LUT970L         \ Graphic MMU LUT entry 970 low
  $2E54 constant GFXMMU_LUT970H         \ Graphic MMU LUT entry 970 high
  $2E58 constant GFXMMU_LUT971L         \ Graphic MMU LUT entry 971 low
  $2E5C constant GFXMMU_LUT971H         \ Graphic MMU LUT entry 971 high
  $2E60 constant GFXMMU_LUT972L         \ Graphic MMU LUT entry 972 low
  $2E64 constant GFXMMU_LUT972H         \ Graphic MMU LUT entry 972 high
  $2E68 constant GFXMMU_LUT973L         \ Graphic MMU LUT entry 973 low
  $2E6C constant GFXMMU_LUT973H         \ Graphic MMU LUT entry 973 high
  $2E70 constant GFXMMU_LUT974L         \ Graphic MMU LUT entry 974 low
  $2E74 constant GFXMMU_LUT974H         \ Graphic MMU LUT entry 974 high
  $2E78 constant GFXMMU_LUT975L         \ Graphic MMU LUT entry 975 low
  $2E7C constant GFXMMU_LUT975H         \ Graphic MMU LUT entry 975 high
  $2E80 constant GFXMMU_LUT976L         \ Graphic MMU LUT entry 976 low
  $2E84 constant GFXMMU_LUT976H         \ Graphic MMU LUT entry 976 high
  $2E88 constant GFXMMU_LUT977L         \ Graphic MMU LUT entry 977 low
  $2E8C constant GFXMMU_LUT977H         \ Graphic MMU LUT entry 977 high
  $2E90 constant GFXMMU_LUT978L         \ Graphic MMU LUT entry 978 low
  $2E94 constant GFXMMU_LUT978H         \ Graphic MMU LUT entry 978 high
  $2E98 constant GFXMMU_LUT979L         \ Graphic MMU LUT entry 979 low
  $2E9C constant GFXMMU_LUT979H         \ Graphic MMU LUT entry 979 high
  $2EA0 constant GFXMMU_LUT980L         \ Graphic MMU LUT entry 980 low
  $2EA4 constant GFXMMU_LUT980H         \ Graphic MMU LUT entry 980 high
  $2EA8 constant GFXMMU_LUT981L         \ Graphic MMU LUT entry 981 low
  $2EAC constant GFXMMU_LUT981H         \ Graphic MMU LUT entry 981 high
  $2EB0 constant GFXMMU_LUT982L         \ Graphic MMU LUT entry 982 low
  $2EB4 constant GFXMMU_LUT982H         \ Graphic MMU LUT entry 982 high
  $2EB8 constant GFXMMU_LUT983L         \ Graphic MMU LUT entry 983 low
  $2EBC constant GFXMMU_LUT983H         \ Graphic MMU LUT entry 983 high
  $2EC0 constant GFXMMU_LUT984L         \ Graphic MMU LUT entry 984 low
  $2EC4 constant GFXMMU_LUT984H         \ Graphic MMU LUT entry 984 high
  $2EC8 constant GFXMMU_LUT985L         \ Graphic MMU LUT entry 985 low
  $2ECC constant GFXMMU_LUT985H         \ Graphic MMU LUT entry 985 high
  $2ED0 constant GFXMMU_LUT986L         \ Graphic MMU LUT entry 986 low
  $2ED4 constant GFXMMU_LUT986H         \ Graphic MMU LUT entry 986 high
  $2ED8 constant GFXMMU_LUT987L         \ Graphic MMU LUT entry 987 low
  $2EDC constant GFXMMU_LUT987H         \ Graphic MMU LUT entry 987 high
  $2EE0 constant GFXMMU_LUT988L         \ Graphic MMU LUT entry 988 low
  $2EE4 constant GFXMMU_LUT988H         \ Graphic MMU LUT entry 988 high
  $2EE8 constant GFXMMU_LUT989L         \ Graphic MMU LUT entry 989 low
  $2EEC constant GFXMMU_LUT989H         \ Graphic MMU LUT entry 989 high
  $2EF0 constant GFXMMU_LUT990L         \ Graphic MMU LUT entry 990 low
  $2EF4 constant GFXMMU_LUT990H         \ Graphic MMU LUT entry 990 high
  $2EF8 constant GFXMMU_LUT991L         \ Graphic MMU LUT entry 991 low
  $2EFC constant GFXMMU_LUT991H         \ Graphic MMU LUT entry 991 high
  $2F00 constant GFXMMU_LUT992L         \ Graphic MMU LUT entry 992 low
  $2F04 constant GFXMMU_LUT992H         \ Graphic MMU LUT entry 992 high
  $2F08 constant GFXMMU_LUT993L         \ Graphic MMU LUT entry 993 low
  $2F0C constant GFXMMU_LUT993H         \ Graphic MMU LUT entry 993 high
  $2F10 constant GFXMMU_LUT994L         \ Graphic MMU LUT entry 994 low
  $2F14 constant GFXMMU_LUT994H         \ Graphic MMU LUT entry 994 high
  $2F18 constant GFXMMU_LUT995L         \ Graphic MMU LUT entry 995 low
  $2F1C constant GFXMMU_LUT995H         \ Graphic MMU LUT entry 995 high
  $2F20 constant GFXMMU_LUT996L         \ Graphic MMU LUT entry 996 low
  $2F24 constant GFXMMU_LUT996H         \ Graphic MMU LUT entry 996 high
  $2F28 constant GFXMMU_LUT997L         \ Graphic MMU LUT entry 997 low
  $2F2C constant GFXMMU_LUT997H         \ Graphic MMU LUT entry 997 high
  $2F30 constant GFXMMU_LUT998L         \ Graphic MMU LUT entry 998 low
  $2F34 constant GFXMMU_LUT998H         \ Graphic MMU LUT entry 998 high
  $2F38 constant GFXMMU_LUT999L         \ Graphic MMU LUT entry 999 low
  $2F3C constant GFXMMU_LUT999H         \ Graphic MMU LUT entry 999 high
  $2F40 constant GFXMMU_LUT1000L        \ Graphic MMU LUT entry 1000 low
  $2F44 constant GFXMMU_LUT1000H        \ Graphic MMU LUT entry 1000 high
  $2F48 constant GFXMMU_LUT1001L        \ Graphic MMU LUT entry 1001 low
  $2F4C constant GFXMMU_LUT1001H        \ Graphic MMU LUT entry 1001 high
  $2F50 constant GFXMMU_LUT1002L        \ Graphic MMU LUT entry 1002 low
  $2F54 constant GFXMMU_LUT1002H        \ Graphic MMU LUT entry 1002 high
  $2F58 constant GFXMMU_LUT1003L        \ Graphic MMU LUT entry 1003 low
  $2F5C constant GFXMMU_LUT1003H        \ Graphic MMU LUT entry 1003 high
  $2F60 constant GFXMMU_LUT1004L        \ Graphic MMU LUT entry 1004 low
  $2F64 constant GFXMMU_LUT1004H        \ Graphic MMU LUT entry 1004 high
  $2F68 constant GFXMMU_LUT1005L        \ Graphic MMU LUT entry 1005 low
  $2F6C constant GFXMMU_LUT1005H        \ Graphic MMU LUT entry 1005 high
  $2F70 constant GFXMMU_LUT1006L        \ Graphic MMU LUT entry 1006 low
  $2F74 constant GFXMMU_LUT1006H        \ Graphic MMU LUT entry 1006 high
  $2F78 constant GFXMMU_LUT1007L        \ Graphic MMU LUT entry 1007 low
  $2F7C constant GFXMMU_LUT1007H        \ Graphic MMU LUT entry 1007 high
  $2F80 constant GFXMMU_LUT1008L        \ Graphic MMU LUT entry 1008 low
  $2F84 constant GFXMMU_LUT1008H        \ Graphic MMU LUT entry 1008 high
  $2F88 constant GFXMMU_LUT1009L        \ Graphic MMU LUT entry 1009 low
  $2F8C constant GFXMMU_LUT1009H        \ Graphic MMU LUT entry 1009 high
  $2F90 constant GFXMMU_LUT1010L        \ Graphic MMU LUT entry 1010 low
  $2F94 constant GFXMMU_LUT1010H        \ Graphic MMU LUT entry 1010 high
  $2F98 constant GFXMMU_LUT1011L        \ Graphic MMU LUT entry 1011 low
  $2F9C constant GFXMMU_LUT1011H        \ Graphic MMU LUT entry 1011 high
  $2FA0 constant GFXMMU_LUT1012L        \ Graphic MMU LUT entry 1012 low
  $2FA4 constant GFXMMU_LUT1012H        \ Graphic MMU LUT entry 1012 high
  $2FA8 constant GFXMMU_LUT1013L        \ Graphic MMU LUT entry 1013 low
  $2FAC constant GFXMMU_LUT1013H        \ Graphic MMU LUT entry 1013 high
  $2FB0 constant GFXMMU_LUT1014L        \ Graphic MMU LUT entry 1014 low
  $2FB4 constant GFXMMU_LUT1014H        \ Graphic MMU LUT entry 1014 high
  $2FB8 constant GFXMMU_LUT1015L        \ Graphic MMU LUT entry 1015 low
  $2FBC constant GFXMMU_LUT1015H        \ Graphic MMU LUT entry 1015 high
  $2FC0 constant GFXMMU_LUT1016L        \ Graphic MMU LUT entry 1016 low
  $2FC4 constant GFXMMU_LUT1016H        \ Graphic MMU LUT entry 1016 high
  $2FC8 constant GFXMMU_LUT1017L        \ Graphic MMU LUT entry 1017 low
  $2FCC constant GFXMMU_LUT1017H        \ Graphic MMU LUT entry 1017 high
  $2FD0 constant GFXMMU_LUT1018L        \ Graphic MMU LUT entry 1018 low
  $2FD4 constant GFXMMU_LUT1018H        \ Graphic MMU LUT entry 1018 high
  $2FD8 constant GFXMMU_LUT1019L        \ Graphic MMU LUT entry 1019 low
  $2FDC constant GFXMMU_LUT1019H        \ Graphic MMU LUT entry 1019 high
  $2FE0 constant GFXMMU_LUT1020L        \ Graphic MMU LUT entry 1020 low
  $2FE4 constant GFXMMU_LUT1020H        \ Graphic MMU LUT entry 1020 high
  $2FE8 constant GFXMMU_LUT1021L        \ Graphic MMU LUT entry 1021 low
  $2FEC constant GFXMMU_LUT1021H        \ Graphic MMU LUT entry 1021 high
  $2FF0 constant GFXMMU_LUT1022L        \ Graphic MMU LUT entry 1022 low
  $2FF4 constant GFXMMU_LUT1022H        \ Graphic MMU LUT entry 1022 high
  $2FF8 constant GFXMMU_LUT1023L        \ Graphic MMU LUT entry 1023 low
  $2FFC constant GFXMMU_LUT1023H        \ Graphic MMU LUT entry 1023 high

: GFXMMU_DEF ; [then]
