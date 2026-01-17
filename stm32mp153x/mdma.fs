\
\ @file mdma.fs
\ @brief MDMA1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] MDMA_DEF

  [ifdef] MDMA_MDMA_GISR0_DEF
    \
    \ @brief MDMA global interrupt/status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_GIF0                      \ [0x00] GIF0
    $01 constant MDMA_GIF1                      \ [0x01] GIF1
    $02 constant MDMA_GIF2                      \ [0x02] GIF2
    $03 constant MDMA_GIF3                      \ [0x03] GIF3
    $04 constant MDMA_GIF4                      \ [0x04] GIF4
    $05 constant MDMA_GIF5                      \ [0x05] GIF5
    $06 constant MDMA_GIF6                      \ [0x06] GIF6
    $07 constant MDMA_GIF7                      \ [0x07] GIF7
    $08 constant MDMA_GIF8                      \ [0x08] GIF8
    $09 constant MDMA_GIF9                      \ [0x09] GIF9
    $0a constant MDMA_GIF10                     \ [0x0a] GIF10
    $0b constant MDMA_GIF11                     \ [0x0b] GIF11
    $0c constant MDMA_GIF12                     \ [0x0c] GIF12
    $0d constant MDMA_GIF13                     \ [0x0d] GIF13
    $0e constant MDMA_GIF14                     \ [0x0e] GIF14
    $0f constant MDMA_GIF15                     \ [0x0f] GIF15
    $10 constant MDMA_GIF16                     \ [0x10] GIF16
    $11 constant MDMA_GIF17                     \ [0x11] GIF17
    $12 constant MDMA_GIF18                     \ [0x12] GIF18
    $13 constant MDMA_GIF19                     \ [0x13] GIF19
    $14 constant MDMA_GIF20                     \ [0x14] GIF20
    $15 constant MDMA_GIF21                     \ [0x15] GIF21
    $16 constant MDMA_GIF22                     \ [0x16] GIF22
    $17 constant MDMA_GIF23                     \ [0x17] GIF23
    $18 constant MDMA_GIF24                     \ [0x18] GIF24
    $19 constant MDMA_GIF25                     \ [0x19] GIF25
    $1a constant MDMA_GIF26                     \ [0x1a] GIF26
    $1b constant MDMA_GIF27                     \ [0x1b] GIF27
    $1c constant MDMA_GIF28                     \ [0x1c] GIF28
    $1d constant MDMA_GIF29                     \ [0x1d] GIF29
    $1e constant MDMA_GIF30                     \ [0x1e] GIF30
    $1f constant MDMA_GIF31                     \ [0x1f] GIF31
  [then]


  [ifdef] MDMA_MDMA_SGISR0_DEF
    \
    \ @brief MDMA secure global interrupt/status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_GIF0                      \ [0x00] GIF0
    $01 constant MDMA_GIF1                      \ [0x01] GIF1
    $02 constant MDMA_GIF2                      \ [0x02] GIF2
    $03 constant MDMA_GIF3                      \ [0x03] GIF3
    $04 constant MDMA_GIF4                      \ [0x04] GIF4
    $05 constant MDMA_GIF5                      \ [0x05] GIF5
    $06 constant MDMA_GIF6                      \ [0x06] GIF6
    $07 constant MDMA_GIF7                      \ [0x07] GIF7
    $08 constant MDMA_GIF8                      \ [0x08] GIF8
    $09 constant MDMA_GIF9                      \ [0x09] GIF9
    $0a constant MDMA_GIF10                     \ [0x0a] GIF10
    $0b constant MDMA_GIF11                     \ [0x0b] GIF11
    $0c constant MDMA_GIF12                     \ [0x0c] GIF12
    $0d constant MDMA_GIF13                     \ [0x0d] GIF13
    $0e constant MDMA_GIF14                     \ [0x0e] GIF14
    $0f constant MDMA_GIF15                     \ [0x0f] GIF15
    $10 constant MDMA_GIF16                     \ [0x10] GIF16
    $11 constant MDMA_GIF17                     \ [0x11] GIF17
    $12 constant MDMA_GIF18                     \ [0x12] GIF18
    $13 constant MDMA_GIF19                     \ [0x13] GIF19
    $14 constant MDMA_GIF20                     \ [0x14] GIF20
    $15 constant MDMA_GIF21                     \ [0x15] GIF21
    $16 constant MDMA_GIF22                     \ [0x16] GIF22
    $17 constant MDMA_GIF23                     \ [0x17] GIF23
    $18 constant MDMA_GIF24                     \ [0x18] GIF24
    $19 constant MDMA_GIF25                     \ [0x19] GIF25
    $1a constant MDMA_GIF26                     \ [0x1a] GIF26
    $1b constant MDMA_GIF27                     \ [0x1b] GIF27
    $1c constant MDMA_GIF28                     \ [0x1c] GIF28
    $1d constant MDMA_GIF29                     \ [0x1d] GIF29
    $1e constant MDMA_GIF30                     \ [0x1e] GIF30
    $1f constant MDMA_GIF31                     \ [0x1f] GIF31
  [then]


  [ifdef] MDMA_MDMA_C0ISR_DEF
    \
    \ @brief MDMA channel 0 interrupt/status register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C0IFCR_DEF
    \
    \ @brief MDMA channel 0 interrupt flag clear register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C0ESR_DEF
    \
    \ @brief MDMA channel 0 error status register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C0CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C0TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C0BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C0SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C0DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C0BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C0LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C0TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C0MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C0MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C1ISR_DEF
    \
    \ @brief MDMA channel 1 interrupt/status register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C1IFCR_DEF
    \
    \ @brief MDMA channel 1 interrupt flag clear register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C1ESR_DEF
    \
    \ @brief MDMA channel 1 error status register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C1CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C1TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C1BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C1SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C1DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C1BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C1LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C1TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C1MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C1MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C2ISR_DEF
    \
    \ @brief MDMA channel 2 interrupt/status register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C2IFCR_DEF
    \
    \ @brief MDMA channel 2 interrupt flag clear register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C2ESR_DEF
    \
    \ @brief MDMA channel 2 error status register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C2CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C2TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C2BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C2SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C2DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C2BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C2LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C2TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C2MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C2MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0xF4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C3ISR_DEF
    \
    \ @brief MDMA channel 3 interrupt/status register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C3IFCR_DEF
    \
    \ @brief MDMA channel 3 interrupt flag clear register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C3ESR_DEF
    \
    \ @brief MDMA channel 3 error status register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C3CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C3TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C3BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C3SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C3DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C3BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C3LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C3TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C3MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C3MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C4ISR_DEF
    \
    \ @brief MDMA channel 4 interrupt/status register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C4IFCR_DEF
    \
    \ @brief MDMA channel 4 interrupt flag clear register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C4ESR_DEF
    \
    \ @brief MDMA channel 4 error status register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C4CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C4TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C4BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C4SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C4DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C4BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C4LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C4TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x168
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C4MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C4MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x174
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C5ISR_DEF
    \
    \ @brief MDMA channel 5 interrupt/status register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C5IFCR_DEF
    \
    \ @brief MDMA channel 5 interrupt flag clear register
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C5ESR_DEF
    \
    \ @brief MDMA channel 5 error status register
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C5CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C5TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C5BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C5SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C5DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C5BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C5LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C5TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C5MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x1B0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C5MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x1B4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C6ISR_DEF
    \
    \ @brief MDMA channel 6 interrupt/status register
    \ Address offset: 0x1C0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C6IFCR_DEF
    \
    \ @brief MDMA channel 6 interrupt flag clear register
    \ Address offset: 0x1C4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C6ESR_DEF
    \
    \ @brief MDMA channel 6 error status register
    \ Address offset: 0x1C8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C6CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C6TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x1D0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C6BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x1D4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C6SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x1D8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C6DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x1DC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C6BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x1E0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C6LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x1E4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C6TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x1E8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C6MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x1F0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C6MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x1F4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C7ISR_DEF
    \
    \ @brief MDMA channel 7 interrupt/status register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C7IFCR_DEF
    \
    \ @brief MDMA channel 7 interrupt flag clear register
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C7ESR_DEF
    \
    \ @brief MDMA channel 7 error status register
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C7CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C7TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C7BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C7SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C7DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C7BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C7LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C7TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C7MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x230
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C7MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x234
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C8ISR_DEF
    \
    \ @brief MDMA channel 8 interrupt/status register
    \ Address offset: 0x240
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C8IFCR_DEF
    \
    \ @brief MDMA channel 8 interrupt flag clear register
    \ Address offset: 0x244
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C8ESR_DEF
    \
    \ @brief MDMA channel 8 error status register
    \ Address offset: 0x248
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C8CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x24C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C8TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C8BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x254
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C8SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x258
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C8DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x25C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C8BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x260
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C8LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x264
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C8TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x268
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C8MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x270
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C8MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x274
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C9ISR_DEF
    \
    \ @brief MDMA channel 9 interrupt/status register
    \ Address offset: 0x280
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C9IFCR_DEF
    \
    \ @brief MDMA channel 9 interrupt flag clear register
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C9ESR_DEF
    \
    \ @brief MDMA channel 9 error status register
    \ Address offset: 0x288
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C9CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x28C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C9TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x290
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C9BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C9SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x298
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C9DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x29C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C9BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x2A0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C9LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x2A4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C9TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x2A8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C9MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x2B0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C9MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x2B4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C10ISR_DEF
    \
    \ @brief MDMA channel 10 interrupt/status register
    \ Address offset: 0x2C0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C10IFCR_DEF
    \
    \ @brief MDMA channel 10 interrupt flag clear register
    \ Address offset: 0x2C4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C10ESR_DEF
    \
    \ @brief MDMA channel 10 error status register
    \ Address offset: 0x2C8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C10CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x2CC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C10TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x2D0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C10BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x2D4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C10SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x2D8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C10DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x2DC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C10BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x2E0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C10LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x2E4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C10TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x2E8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C10MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x2F0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C10MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x2F4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C11ISR_DEF
    \
    \ @brief MDMA channel 11 interrupt/status register
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C11IFCR_DEF
    \
    \ @brief MDMA channel 11 interrupt flag clear register
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C11ESR_DEF
    \
    \ @brief MDMA channel 11 error status register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C11CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x30C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C11TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C11BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C11SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C11DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C11BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C11LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x324
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C11TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x328
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C11MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x330
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C11MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x334
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C12ISR_DEF
    \
    \ @brief MDMA channel 12 interrupt/status register
    \ Address offset: 0x340
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C12IFCR_DEF
    \
    \ @brief MDMA channel 12 interrupt flag clear register
    \ Address offset: 0x344
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C12ESR_DEF
    \
    \ @brief MDMA channel 12 error status register
    \ Address offset: 0x348
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C12CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x34C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C12TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x350
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C12BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x354
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C12SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x358
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C12DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x35C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C12BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x360
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C12LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x364
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C12TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x368
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C12MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x370
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C12MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x374
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C13ISR_DEF
    \
    \ @brief MDMA channel 13 interrupt/status register
    \ Address offset: 0x380
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C13IFCR_DEF
    \
    \ @brief MDMA channel 13 interrupt flag clear register
    \ Address offset: 0x384
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C13ESR_DEF
    \
    \ @brief MDMA channel 13 error status register
    \ Address offset: 0x388
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C13CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x38C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C13TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x390
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C13BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x394
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C13SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x398
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C13DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x39C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C13BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x3A0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C13LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x3A4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C13TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x3A8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C13MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x3B0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C13MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x3B4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C14ISR_DEF
    \
    \ @brief MDMA channel 14 interrupt/status register
    \ Address offset: 0x3C0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C14IFCR_DEF
    \
    \ @brief MDMA channel 14 interrupt flag clear register
    \ Address offset: 0x3C4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C14ESR_DEF
    \
    \ @brief MDMA channel 14 error status register
    \ Address offset: 0x3C8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C14CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x3CC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C14TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x3D0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C14BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x3D4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C14SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x3D8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C14DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C14BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C14LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C14TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x3E8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C14MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C14MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x3F4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C15ISR_DEF
    \
    \ @brief MDMA channel 15 interrupt/status register
    \ Address offset: 0x400
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C15IFCR_DEF
    \
    \ @brief MDMA channel 15 interrupt flag clear register
    \ Address offset: 0x404
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C15ESR_DEF
    \
    \ @brief MDMA channel 15 error status register
    \ Address offset: 0x408
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C15CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x40C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C15TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x410
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C15BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x414
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C15SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C15DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x41C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C15BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x420
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C15LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x424
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C15TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x428
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C15MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x430
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C15MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x434
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C16ISR_DEF
    \
    \ @brief MDMA channel 16 interrupt/status register
    \ Address offset: 0x440
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C16IFCR_DEF
    \
    \ @brief MDMA channel 16 interrupt flag clear register
    \ Address offset: 0x444
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C16ESR_DEF
    \
    \ @brief MDMA channel 16 error status register
    \ Address offset: 0x448
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C16CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x44C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C16TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x450
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C16BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x454
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C16SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x458
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C16DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x45C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C16BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x460
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C16LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x464
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C16TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x468
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C16MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x470
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C16MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x474
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C17ISR_DEF
    \
    \ @brief MDMA channel 17 interrupt/status register
    \ Address offset: 0x480
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C17IFCR_DEF
    \
    \ @brief MDMA channel 17 interrupt flag clear register
    \ Address offset: 0x484
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C17ESR_DEF
    \
    \ @brief MDMA channel 17 error status register
    \ Address offset: 0x488
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C17CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x48C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C17TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x490
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C17BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x494
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C17SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x498
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C17DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x49C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C17BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x4A0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C17LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x4A4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C17TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x4A8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C17MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x4B0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C17MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x4B4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C18ISR_DEF
    \
    \ @brief MDMA channel 18 interrupt/status register
    \ Address offset: 0x4C0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C18IFCR_DEF
    \
    \ @brief MDMA channel 18 interrupt flag clear register
    \ Address offset: 0x4C4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C18ESR_DEF
    \
    \ @brief MDMA channel 18 error status register
    \ Address offset: 0x4C8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C18CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x4CC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C18TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x4D0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C18BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x4D4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C18SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x4D8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C18DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x4DC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C18BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x4E0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C18LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x4E4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C18TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x4E8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C18MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x4F0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C18MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x4F4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C19ISR_DEF
    \
    \ @brief MDMA channel 19 interrupt/status register
    \ Address offset: 0x500
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C19IFCR_DEF
    \
    \ @brief MDMA channel 19 interrupt flag clear register
    \ Address offset: 0x504
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C19ESR_DEF
    \
    \ @brief MDMA channel 19 error status register
    \ Address offset: 0x508
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C19CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x50C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C19TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x510
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C19BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x514
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C19SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x518
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C19DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x51C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C19BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x520
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C19LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x524
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C19TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x528
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C19MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x530
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C19MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x534
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C20ISR_DEF
    \
    \ @brief MDMA channel 20 interrupt/status register
    \ Address offset: 0x540
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C20IFCR_DEF
    \
    \ @brief MDMA channel 20 interrupt flag clear register
    \ Address offset: 0x544
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C20ESR_DEF
    \
    \ @brief MDMA channel 20 error status register
    \ Address offset: 0x548
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C20CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x54C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C20TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x550
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C20BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x554
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C20SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x558
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C20DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x55C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C20BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x560
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C20LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x564
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C20TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x568
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C20MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x570
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C20MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x574
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C21ISR_DEF
    \
    \ @brief MDMA channel 21 interrupt/status register
    \ Address offset: 0x580
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C21IFCR_DEF
    \
    \ @brief MDMA channel 21 interrupt flag clear register
    \ Address offset: 0x584
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C21ESR_DEF
    \
    \ @brief MDMA channel 21 error status register
    \ Address offset: 0x588
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C21CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x58C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C21TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x590
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C21BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x594
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C21SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x598
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C21DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x59C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C21BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x5A0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C21LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x5A4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C21TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x5A8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C21MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x5B0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C21MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x5B4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C22ISR_DEF
    \
    \ @brief MDMA channel 22 interrupt/status register
    \ Address offset: 0x5C0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C22IFCR_DEF
    \
    \ @brief MDMA channel 22 interrupt flag clear register
    \ Address offset: 0x5C4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C22ESR_DEF
    \
    \ @brief MDMA channel 22 error status register
    \ Address offset: 0x5C8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C22CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x5CC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C22TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x5D0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C22BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x5D4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C22SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x5D8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C22DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x5DC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C22BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x5E0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C22LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x5E4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C22TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x5E8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C22MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x5F0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C22MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x5F4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C23ISR_DEF
    \
    \ @brief MDMA channel 23 interrupt/status register
    \ Address offset: 0x600
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C23IFCR_DEF
    \
    \ @brief MDMA channel 23 interrupt flag clear register
    \ Address offset: 0x604
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C23ESR_DEF
    \
    \ @brief MDMA channel 23 error status register
    \ Address offset: 0x608
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C23CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x60C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C23TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x610
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C23BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x614
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C23SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x618
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C23DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x61C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C23BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x620
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C23LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x624
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C23TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x628
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C23MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x630
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C23MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x634
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C24ISR_DEF
    \
    \ @brief MDMA channel 24 interrupt/status register
    \ Address offset: 0x640
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C24IFCR_DEF
    \
    \ @brief MDMA channel 24 interrupt flag clear register
    \ Address offset: 0x644
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C24ESR_DEF
    \
    \ @brief MDMA channel 24 error status register
    \ Address offset: 0x648
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C24CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x64C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C24TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x650
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C24BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x654
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C24SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x658
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C24DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x65C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C24BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x660
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C24LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x664
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C24TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x668
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C24MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x670
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C24MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x674
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C25ISR_DEF
    \
    \ @brief MDMA channel 25 interrupt/status register
    \ Address offset: 0x680
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C25IFCR_DEF
    \
    \ @brief MDMA channel 25 interrupt flag clear register
    \ Address offset: 0x684
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C25ESR_DEF
    \
    \ @brief MDMA channel 25 error status register
    \ Address offset: 0x688
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C25CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x68C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C25TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x690
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C25BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x694
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C25SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x698
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C25DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x69C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C25BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x6A0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C25LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x6A4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C25TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x6A8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C25MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x6B0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C25MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x6B4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C26ISR_DEF
    \
    \ @brief MDMA channel 26 interrupt/status register
    \ Address offset: 0x6C0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C26IFCR_DEF
    \
    \ @brief MDMA channel 26 interrupt flag clear register
    \ Address offset: 0x6C4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C26ESR_DEF
    \
    \ @brief MDMA channel 26 error status register
    \ Address offset: 0x6C8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C26CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x6CC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C26TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x6D0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C26BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x6D4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C26SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x6D8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C26DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x6DC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C26BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x6E0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C26LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x6E4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C26TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x6E8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C26MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x6F0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C26MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x6F4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C27ISR_DEF
    \
    \ @brief MDMA channel 27 interrupt/status register
    \ Address offset: 0x700
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C27IFCR_DEF
    \
    \ @brief MDMA channel 27 interrupt flag clear register
    \ Address offset: 0x704
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C27ESR_DEF
    \
    \ @brief MDMA channel 27 error status register
    \ Address offset: 0x708
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C27CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x70C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C27TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x710
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C27BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x714
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C27SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x718
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C27DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x71C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C27BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x720
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C27LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x724
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C27TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x728
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C27MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x730
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C27MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x734
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C28ISR_DEF
    \
    \ @brief MDMA channel 28 interrupt/status register
    \ Address offset: 0x740
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C28IFCR_DEF
    \
    \ @brief MDMA channel 28 interrupt flag clear register
    \ Address offset: 0x744
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C28ESR_DEF
    \
    \ @brief MDMA channel 28 error status register
    \ Address offset: 0x748
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C28CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x74C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C28TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x750
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C28BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x754
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C28SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x758
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C28DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x75C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C28BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x760
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C28LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x764
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C28TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x768
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C28MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x770
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C28MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x774
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C29ISR_DEF
    \
    \ @brief MDMA channel 29 interrupt/status register
    \ Address offset: 0x780
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C29IFCR_DEF
    \
    \ @brief MDMA channel 29 interrupt flag clear register
    \ Address offset: 0x784
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C29ESR_DEF
    \
    \ @brief MDMA channel 29 error status register
    \ Address offset: 0x788
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C29CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x78C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C29TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x790
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C29BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x794
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C29SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x798
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C29DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x79C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C29BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x7A0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C29LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x7A4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C29TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x7A8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C29MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x7B0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C29MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x7B4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C30ISR_DEF
    \
    \ @brief MDMA channel 30 interrupt/status register
    \ Address offset: 0x7C0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C30IFCR_DEF
    \
    \ @brief MDMA channel 30 interrupt flag clear register
    \ Address offset: 0x7C4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C30ESR_DEF
    \
    \ @brief MDMA channel 30 error status register
    \ Address offset: 0x7C8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C30CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x7CC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C30TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x7D0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C30BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x7D4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C30SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x7D8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C30DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x7DC
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C30BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x7E0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C30LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x7E4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C30TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x7E8
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C30MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x7F0
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C30MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x7F4
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]


  [ifdef] MDMA_MDMA_C31ISR_DEF
    \
    \ @brief MDMA channel 31 interrupt/status register
    \ Address offset: 0x800
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEIF                      \ [0x00] TEIF
    $01 constant MDMA_CTCIF                     \ [0x01] CTCIF
    $02 constant MDMA_BRTIF                     \ [0x02] BRTIF
    $03 constant MDMA_BTIF                      \ [0x03] BTIF
    $04 constant MDMA_TCIF                      \ [0x04] TCIF
    $10 constant MDMA_CRQA                      \ [0x10] CRQA
  [then]


  [ifdef] MDMA_MDMA_C31IFCR_DEF
    \
    \ @brief MDMA channel 31 interrupt flag clear register
    \ Address offset: 0x804
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_CTEIF                     \ [0x00] CTEIF
    $01 constant MDMA_CCTCIF                    \ [0x01] CCTCIF
    $02 constant MDMA_CBRTIF                    \ [0x02] CBRTIF
    $03 constant MDMA_CBTIF                     \ [0x03] CBTIF
    $04 constant MDMA_CLTCIF                    \ [0x04] CLTCIF
  [then]


  [ifdef] MDMA_MDMA_C31ESR_DEF
    \
    \ @brief MDMA channel 31 error status register
    \ Address offset: 0x808
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TEA                       \ [0x00 : 7] TEA
    $07 constant MDMA_TED                       \ [0x07] TED
    $08 constant MDMA_TELD                      \ [0x08] TELD
    $09 constant MDMA_TEMD                      \ [0x09] TEMD
    $0a constant MDMA_ASE                       \ [0x0a] ASE
    $0b constant MDMA_BSE                       \ [0x0b] BSE
  [then]


  [ifdef] MDMA_MDMA_C31CR_DEF
    \
    \ @brief This register is used to control the concerned channel.
    \ Address offset: 0x80C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_EN                        \ [0x00] EN
    $01 constant MDMA_TEIE                      \ [0x01] TEIE
    $02 constant MDMA_CTCIE                     \ [0x02] CTCIE
    $03 constant MDMA_BRTIE                     \ [0x03] BRTIE
    $04 constant MDMA_BTIE                      \ [0x04] BTIE
    $05 constant MDMA_TCIE                      \ [0x05] TCIE
    $06 constant MDMA_PL                        \ [0x06 : 2] PL
    $0c constant MDMA_BEX                       \ [0x0c] BEX
    $0d constant MDMA_HEX                       \ [0x0d] HEX
    $0e constant MDMA_WEX                       \ [0x0e] WEX
    $10 constant MDMA_SWRQ                      \ [0x10] SWRQ
  [then]


  [ifdef] MDMA_MDMA_C31TCR_DEF
    \
    \ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
    \ Address offset: 0x810
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SINC                      \ [0x00 : 2] SINC
    $02 constant MDMA_DINC                      \ [0x02 : 2] DINC
    $04 constant MDMA_SSIZE                     \ [0x04 : 2] SSIZE
    $06 constant MDMA_DSIZE                     \ [0x06 : 2] DSIZE
    $08 constant MDMA_SINCOS                    \ [0x08 : 2] SINCOS
    $0a constant MDMA_DINCOS                    \ [0x0a : 2] DINCOS
    $0c constant MDMA_SBURST                    \ [0x0c : 3] SBURST
    $0f constant MDMA_DBURST                    \ [0x0f : 3] DBURST
    $12 constant MDMA_TLEN                      \ [0x12 : 7] TLEN
    $19 constant MDMA_PKE                       \ [0x19] PKE
    $1a constant MDMA_PAM                       \ [0x1a : 2] PAM
    $1c constant MDMA_TRGM                      \ [0x1c : 2] TRGM
    $1e constant MDMA_SWRM                      \ [0x1e] SWRM
    $1f constant MDMA_BWM                       \ [0x1f] BWM
  [then]


  [ifdef] MDMA_MDMA_C31BNDTR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
    \ Address offset: 0x814
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_BNDT                      \ [0x00 : 17] BNDT
    $12 constant MDMA_BRSUM                     \ [0x12] BRSUM
    $13 constant MDMA_BRDUM                     \ [0x13] BRDUM
    $14 constant MDMA_BRC                       \ [0x14 : 12] BRC
  [then]


  [ifdef] MDMA_MDMA_C31SAR_DEF
    \
    \ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
    \ Address offset: 0x818
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SAR                       \ [0x00 : 32] SAR
  [then]


  [ifdef] MDMA_MDMA_C31DAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
    \ Address offset: 0x81C
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_DAR                       \ [0x00 : 32] DAR
  [then]


  [ifdef] MDMA_MDMA_C31BRUR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
    \ Address offset: 0x820
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_SUV                       \ [0x00 : 16] SUV
    $10 constant MDMA_DUV                       \ [0x10 : 16] DUV
  [then]


  [ifdef] MDMA_MDMA_C31LAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
    \ Address offset: 0x824
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_LAR                       \ [0x00 : 32] LAR
  [then]


  [ifdef] MDMA_MDMA_C31TBR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
    \ Address offset: 0x828
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_TSEL                      \ [0x00 : 6] TSEL
    $10 constant MDMA_SBUS                      \ [0x10] SBUS
    $11 constant MDMA_DBUS                      \ [0x11] DBUS
  [then]


  [ifdef] MDMA_MDMA_C31MAR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
    \ Address offset: 0x830
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MAR                       \ [0x00 : 32] MAR
  [then]


  [ifdef] MDMA_MDMA_C31MDR_DEF
    \
    \ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
    \ Address offset: 0x834
    \ Reset value: 0x00000000
    \
    $00 constant MDMA_MDR                       \ [0x00 : 32] MDR
  [then]

  \
  \ @brief MDMA1
  \
  $00 constant MDMA_MDMA_GISR0          \ MDMA global interrupt/status register
  $08 constant MDMA_MDMA_SGISR0         \ MDMA secure global interrupt/status register
  $40 constant MDMA_MDMA_C0ISR          \ MDMA channel 0 interrupt/status register
  $44 constant MDMA_MDMA_C0IFCR         \ MDMA channel 0 interrupt flag clear register
  $48 constant MDMA_MDMA_C0ESR          \ MDMA channel 0 error status register
  $4C constant MDMA_MDMA_C0CR           \ This register is used to control the concerned channel.
  $50 constant MDMA_MDMA_C0TCR          \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $54 constant MDMA_MDMA_C0BNDTR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $58 constant MDMA_MDMA_C0SAR          \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $5C constant MDMA_MDMA_C0DAR          \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $60 constant MDMA_MDMA_C0BRUR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $64 constant MDMA_MDMA_C0LAR          \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $68 constant MDMA_MDMA_C0TBR          \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $70 constant MDMA_MDMA_C0MAR          \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $74 constant MDMA_MDMA_C0MDR          \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $80 constant MDMA_MDMA_C1ISR          \ MDMA channel 1 interrupt/status register
  $84 constant MDMA_MDMA_C1IFCR         \ MDMA channel 1 interrupt flag clear register
  $88 constant MDMA_MDMA_C1ESR          \ MDMA channel 1 error status register
  $8C constant MDMA_MDMA_C1CR           \ This register is used to control the concerned channel.
  $90 constant MDMA_MDMA_C1TCR          \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $94 constant MDMA_MDMA_C1BNDTR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $98 constant MDMA_MDMA_C1SAR          \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $9C constant MDMA_MDMA_C1DAR          \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $A0 constant MDMA_MDMA_C1BRUR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $A4 constant MDMA_MDMA_C1LAR          \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $A8 constant MDMA_MDMA_C1TBR          \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $B0 constant MDMA_MDMA_C1MAR          \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $B4 constant MDMA_MDMA_C1MDR          \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $C0 constant MDMA_MDMA_C2ISR          \ MDMA channel 2 interrupt/status register
  $C4 constant MDMA_MDMA_C2IFCR         \ MDMA channel 2 interrupt flag clear register
  $C8 constant MDMA_MDMA_C2ESR          \ MDMA channel 2 error status register
  $CC constant MDMA_MDMA_C2CR           \ This register is used to control the concerned channel.
  $D0 constant MDMA_MDMA_C2TCR          \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $D4 constant MDMA_MDMA_C2BNDTR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $D8 constant MDMA_MDMA_C2SAR          \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $DC constant MDMA_MDMA_C2DAR          \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $E0 constant MDMA_MDMA_C2BRUR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $E4 constant MDMA_MDMA_C2LAR          \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $E8 constant MDMA_MDMA_C2TBR          \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $F0 constant MDMA_MDMA_C2MAR          \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $F4 constant MDMA_MDMA_C2MDR          \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $100 constant MDMA_MDMA_C3ISR         \ MDMA channel 3 interrupt/status register
  $104 constant MDMA_MDMA_C3IFCR        \ MDMA channel 3 interrupt flag clear register
  $108 constant MDMA_MDMA_C3ESR         \ MDMA channel 3 error status register
  $10C constant MDMA_MDMA_C3CR          \ This register is used to control the concerned channel.
  $110 constant MDMA_MDMA_C3TCR         \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $114 constant MDMA_MDMA_C3BNDTR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $118 constant MDMA_MDMA_C3SAR         \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $11C constant MDMA_MDMA_C3DAR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $120 constant MDMA_MDMA_C3BRUR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $124 constant MDMA_MDMA_C3LAR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $128 constant MDMA_MDMA_C3TBR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $130 constant MDMA_MDMA_C3MAR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $134 constant MDMA_MDMA_C3MDR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $140 constant MDMA_MDMA_C4ISR         \ MDMA channel 4 interrupt/status register
  $144 constant MDMA_MDMA_C4IFCR        \ MDMA channel 4 interrupt flag clear register
  $148 constant MDMA_MDMA_C4ESR         \ MDMA channel 4 error status register
  $14C constant MDMA_MDMA_C4CR          \ This register is used to control the concerned channel.
  $150 constant MDMA_MDMA_C4TCR         \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $154 constant MDMA_MDMA_C4BNDTR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $158 constant MDMA_MDMA_C4SAR         \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $15C constant MDMA_MDMA_C4DAR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $160 constant MDMA_MDMA_C4BRUR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $164 constant MDMA_MDMA_C4LAR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $168 constant MDMA_MDMA_C4TBR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $170 constant MDMA_MDMA_C4MAR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $174 constant MDMA_MDMA_C4MDR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $180 constant MDMA_MDMA_C5ISR         \ MDMA channel 5 interrupt/status register
  $184 constant MDMA_MDMA_C5IFCR        \ MDMA channel 5 interrupt flag clear register
  $188 constant MDMA_MDMA_C5ESR         \ MDMA channel 5 error status register
  $18C constant MDMA_MDMA_C5CR          \ This register is used to control the concerned channel.
  $190 constant MDMA_MDMA_C5TCR         \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $194 constant MDMA_MDMA_C5BNDTR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $198 constant MDMA_MDMA_C5SAR         \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $19C constant MDMA_MDMA_C5DAR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $1A0 constant MDMA_MDMA_C5BRUR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $1A4 constant MDMA_MDMA_C5LAR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $1A8 constant MDMA_MDMA_C5TBR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $1B0 constant MDMA_MDMA_C5MAR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $1B4 constant MDMA_MDMA_C5MDR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $1C0 constant MDMA_MDMA_C6ISR         \ MDMA channel 6 interrupt/status register
  $1C4 constant MDMA_MDMA_C6IFCR        \ MDMA channel 6 interrupt flag clear register
  $1C8 constant MDMA_MDMA_C6ESR         \ MDMA channel 6 error status register
  $1CC constant MDMA_MDMA_C6CR          \ This register is used to control the concerned channel.
  $1D0 constant MDMA_MDMA_C6TCR         \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $1D4 constant MDMA_MDMA_C6BNDTR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $1D8 constant MDMA_MDMA_C6SAR         \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $1DC constant MDMA_MDMA_C6DAR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $1E0 constant MDMA_MDMA_C6BRUR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $1E4 constant MDMA_MDMA_C6LAR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $1E8 constant MDMA_MDMA_C6TBR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $1F0 constant MDMA_MDMA_C6MAR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $1F4 constant MDMA_MDMA_C6MDR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $200 constant MDMA_MDMA_C7ISR         \ MDMA channel 7 interrupt/status register
  $204 constant MDMA_MDMA_C7IFCR        \ MDMA channel 7 interrupt flag clear register
  $208 constant MDMA_MDMA_C7ESR         \ MDMA channel 7 error status register
  $20C constant MDMA_MDMA_C7CR          \ This register is used to control the concerned channel.
  $210 constant MDMA_MDMA_C7TCR         \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $214 constant MDMA_MDMA_C7BNDTR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $218 constant MDMA_MDMA_C7SAR         \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $21C constant MDMA_MDMA_C7DAR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $220 constant MDMA_MDMA_C7BRUR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $224 constant MDMA_MDMA_C7LAR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $228 constant MDMA_MDMA_C7TBR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $230 constant MDMA_MDMA_C7MAR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $234 constant MDMA_MDMA_C7MDR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $240 constant MDMA_MDMA_C8ISR         \ MDMA channel 8 interrupt/status register
  $244 constant MDMA_MDMA_C8IFCR        \ MDMA channel 8 interrupt flag clear register
  $248 constant MDMA_MDMA_C8ESR         \ MDMA channel 8 error status register
  $24C constant MDMA_MDMA_C8CR          \ This register is used to control the concerned channel.
  $250 constant MDMA_MDMA_C8TCR         \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $254 constant MDMA_MDMA_C8BNDTR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $258 constant MDMA_MDMA_C8SAR         \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $25C constant MDMA_MDMA_C8DAR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $260 constant MDMA_MDMA_C8BRUR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $264 constant MDMA_MDMA_C8LAR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $268 constant MDMA_MDMA_C8TBR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $270 constant MDMA_MDMA_C8MAR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $274 constant MDMA_MDMA_C8MDR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $280 constant MDMA_MDMA_C9ISR         \ MDMA channel 9 interrupt/status register
  $284 constant MDMA_MDMA_C9IFCR        \ MDMA channel 9 interrupt flag clear register
  $288 constant MDMA_MDMA_C9ESR         \ MDMA channel 9 error status register
  $28C constant MDMA_MDMA_C9CR          \ This register is used to control the concerned channel.
  $290 constant MDMA_MDMA_C9TCR         \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $294 constant MDMA_MDMA_C9BNDTR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $298 constant MDMA_MDMA_C9SAR         \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $29C constant MDMA_MDMA_C9DAR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $2A0 constant MDMA_MDMA_C9BRUR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $2A4 constant MDMA_MDMA_C9LAR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $2A8 constant MDMA_MDMA_C9TBR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $2B0 constant MDMA_MDMA_C9MAR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $2B4 constant MDMA_MDMA_C9MDR         \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $2C0 constant MDMA_MDMA_C10ISR        \ MDMA channel 10 interrupt/status register
  $2C4 constant MDMA_MDMA_C10IFCR       \ MDMA channel 10 interrupt flag clear register
  $2C8 constant MDMA_MDMA_C10ESR        \ MDMA channel 10 error status register
  $2CC constant MDMA_MDMA_C10CR         \ This register is used to control the concerned channel.
  $2D0 constant MDMA_MDMA_C10TCR        \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $2D4 constant MDMA_MDMA_C10BNDTR      \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $2D8 constant MDMA_MDMA_C10SAR        \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $2DC constant MDMA_MDMA_C10DAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $2E0 constant MDMA_MDMA_C10BRUR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $2E4 constant MDMA_MDMA_C10LAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $2E8 constant MDMA_MDMA_C10TBR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $2F0 constant MDMA_MDMA_C10MAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $2F4 constant MDMA_MDMA_C10MDR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $300 constant MDMA_MDMA_C11ISR        \ MDMA channel 11 interrupt/status register
  $304 constant MDMA_MDMA_C11IFCR       \ MDMA channel 11 interrupt flag clear register
  $308 constant MDMA_MDMA_C11ESR        \ MDMA channel 11 error status register
  $30C constant MDMA_MDMA_C11CR         \ This register is used to control the concerned channel.
  $310 constant MDMA_MDMA_C11TCR        \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $314 constant MDMA_MDMA_C11BNDTR      \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $318 constant MDMA_MDMA_C11SAR        \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $31C constant MDMA_MDMA_C11DAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $320 constant MDMA_MDMA_C11BRUR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $324 constant MDMA_MDMA_C11LAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $328 constant MDMA_MDMA_C11TBR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $330 constant MDMA_MDMA_C11MAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $334 constant MDMA_MDMA_C11MDR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $340 constant MDMA_MDMA_C12ISR        \ MDMA channel 12 interrupt/status register
  $344 constant MDMA_MDMA_C12IFCR       \ MDMA channel 12 interrupt flag clear register
  $348 constant MDMA_MDMA_C12ESR        \ MDMA channel 12 error status register
  $34C constant MDMA_MDMA_C12CR         \ This register is used to control the concerned channel.
  $350 constant MDMA_MDMA_C12TCR        \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $354 constant MDMA_MDMA_C12BNDTR      \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $358 constant MDMA_MDMA_C12SAR        \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $35C constant MDMA_MDMA_C12DAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $360 constant MDMA_MDMA_C12BRUR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $364 constant MDMA_MDMA_C12LAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $368 constant MDMA_MDMA_C12TBR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $370 constant MDMA_MDMA_C12MAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $374 constant MDMA_MDMA_C12MDR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $380 constant MDMA_MDMA_C13ISR        \ MDMA channel 13 interrupt/status register
  $384 constant MDMA_MDMA_C13IFCR       \ MDMA channel 13 interrupt flag clear register
  $388 constant MDMA_MDMA_C13ESR        \ MDMA channel 13 error status register
  $38C constant MDMA_MDMA_C13CR         \ This register is used to control the concerned channel.
  $390 constant MDMA_MDMA_C13TCR        \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $394 constant MDMA_MDMA_C13BNDTR      \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $398 constant MDMA_MDMA_C13SAR        \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $39C constant MDMA_MDMA_C13DAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $3A0 constant MDMA_MDMA_C13BRUR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $3A4 constant MDMA_MDMA_C13LAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $3A8 constant MDMA_MDMA_C13TBR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $3B0 constant MDMA_MDMA_C13MAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $3B4 constant MDMA_MDMA_C13MDR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $3C0 constant MDMA_MDMA_C14ISR        \ MDMA channel 14 interrupt/status register
  $3C4 constant MDMA_MDMA_C14IFCR       \ MDMA channel 14 interrupt flag clear register
  $3C8 constant MDMA_MDMA_C14ESR        \ MDMA channel 14 error status register
  $3CC constant MDMA_MDMA_C14CR         \ This register is used to control the concerned channel.
  $3D0 constant MDMA_MDMA_C14TCR        \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $3D4 constant MDMA_MDMA_C14BNDTR      \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $3D8 constant MDMA_MDMA_C14SAR        \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $3DC constant MDMA_MDMA_C14DAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $3E0 constant MDMA_MDMA_C14BRUR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $3E4 constant MDMA_MDMA_C14LAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $3E8 constant MDMA_MDMA_C14TBR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $3F0 constant MDMA_MDMA_C14MAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $3F4 constant MDMA_MDMA_C14MDR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $400 constant MDMA_MDMA_C15ISR        \ MDMA channel 15 interrupt/status register
  $404 constant MDMA_MDMA_C15IFCR       \ MDMA channel 15 interrupt flag clear register
  $408 constant MDMA_MDMA_C15ESR        \ MDMA channel 15 error status register
  $40C constant MDMA_MDMA_C15CR         \ This register is used to control the concerned channel.
  $410 constant MDMA_MDMA_C15TCR        \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $414 constant MDMA_MDMA_C15BNDTR      \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $418 constant MDMA_MDMA_C15SAR        \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $41C constant MDMA_MDMA_C15DAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $420 constant MDMA_MDMA_C15BRUR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $424 constant MDMA_MDMA_C15LAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $428 constant MDMA_MDMA_C15TBR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $430 constant MDMA_MDMA_C15MAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $434 constant MDMA_MDMA_C15MDR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $440 constant MDMA_MDMA_C16ISR        \ MDMA channel 16 interrupt/status register
  $444 constant MDMA_MDMA_C16IFCR       \ MDMA channel 16 interrupt flag clear register
  $448 constant MDMA_MDMA_C16ESR        \ MDMA channel 16 error status register
  $44C constant MDMA_MDMA_C16CR         \ This register is used to control the concerned channel.
  $450 constant MDMA_MDMA_C16TCR        \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $454 constant MDMA_MDMA_C16BNDTR      \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $458 constant MDMA_MDMA_C16SAR        \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $45C constant MDMA_MDMA_C16DAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $460 constant MDMA_MDMA_C16BRUR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $464 constant MDMA_MDMA_C16LAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $468 constant MDMA_MDMA_C16TBR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $470 constant MDMA_MDMA_C16MAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $474 constant MDMA_MDMA_C16MDR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $480 constant MDMA_MDMA_C17ISR        \ MDMA channel 17 interrupt/status register
  $484 constant MDMA_MDMA_C17IFCR       \ MDMA channel 17 interrupt flag clear register
  $488 constant MDMA_MDMA_C17ESR        \ MDMA channel 17 error status register
  $48C constant MDMA_MDMA_C17CR         \ This register is used to control the concerned channel.
  $490 constant MDMA_MDMA_C17TCR        \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $494 constant MDMA_MDMA_C17BNDTR      \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $498 constant MDMA_MDMA_C17SAR        \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $49C constant MDMA_MDMA_C17DAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $4A0 constant MDMA_MDMA_C17BRUR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $4A4 constant MDMA_MDMA_C17LAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $4A8 constant MDMA_MDMA_C17TBR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $4B0 constant MDMA_MDMA_C17MAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $4B4 constant MDMA_MDMA_C17MDR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $4C0 constant MDMA_MDMA_C18ISR        \ MDMA channel 18 interrupt/status register
  $4C4 constant MDMA_MDMA_C18IFCR       \ MDMA channel 18 interrupt flag clear register
  $4C8 constant MDMA_MDMA_C18ESR        \ MDMA channel 18 error status register
  $4CC constant MDMA_MDMA_C18CR         \ This register is used to control the concerned channel.
  $4D0 constant MDMA_MDMA_C18TCR        \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $4D4 constant MDMA_MDMA_C18BNDTR      \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $4D8 constant MDMA_MDMA_C18SAR        \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $4DC constant MDMA_MDMA_C18DAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $4E0 constant MDMA_MDMA_C18BRUR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $4E4 constant MDMA_MDMA_C18LAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $4E8 constant MDMA_MDMA_C18TBR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $4F0 constant MDMA_MDMA_C18MAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $4F4 constant MDMA_MDMA_C18MDR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $500 constant MDMA_MDMA_C19ISR        \ MDMA channel 19 interrupt/status register
  $504 constant MDMA_MDMA_C19IFCR       \ MDMA channel 19 interrupt flag clear register
  $508 constant MDMA_MDMA_C19ESR        \ MDMA channel 19 error status register
  $50C constant MDMA_MDMA_C19CR         \ This register is used to control the concerned channel.
  $510 constant MDMA_MDMA_C19TCR        \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $514 constant MDMA_MDMA_C19BNDTR      \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $518 constant MDMA_MDMA_C19SAR        \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $51C constant MDMA_MDMA_C19DAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $520 constant MDMA_MDMA_C19BRUR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $524 constant MDMA_MDMA_C19LAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $528 constant MDMA_MDMA_C19TBR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $530 constant MDMA_MDMA_C19MAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $534 constant MDMA_MDMA_C19MDR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $540 constant MDMA_MDMA_C20ISR        \ MDMA channel 20 interrupt/status register
  $544 constant MDMA_MDMA_C20IFCR       \ MDMA channel 20 interrupt flag clear register
  $548 constant MDMA_MDMA_C20ESR        \ MDMA channel 20 error status register
  $54C constant MDMA_MDMA_C20CR         \ This register is used to control the concerned channel.
  $550 constant MDMA_MDMA_C20TCR        \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $554 constant MDMA_MDMA_C20BNDTR      \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $558 constant MDMA_MDMA_C20SAR        \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $55C constant MDMA_MDMA_C20DAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $560 constant MDMA_MDMA_C20BRUR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $564 constant MDMA_MDMA_C20LAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $568 constant MDMA_MDMA_C20TBR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $570 constant MDMA_MDMA_C20MAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $574 constant MDMA_MDMA_C20MDR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $580 constant MDMA_MDMA_C21ISR        \ MDMA channel 21 interrupt/status register
  $584 constant MDMA_MDMA_C21IFCR       \ MDMA channel 21 interrupt flag clear register
  $588 constant MDMA_MDMA_C21ESR        \ MDMA channel 21 error status register
  $58C constant MDMA_MDMA_C21CR         \ This register is used to control the concerned channel.
  $590 constant MDMA_MDMA_C21TCR        \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $594 constant MDMA_MDMA_C21BNDTR      \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $598 constant MDMA_MDMA_C21SAR        \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $59C constant MDMA_MDMA_C21DAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $5A0 constant MDMA_MDMA_C21BRUR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $5A4 constant MDMA_MDMA_C21LAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $5A8 constant MDMA_MDMA_C21TBR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $5B0 constant MDMA_MDMA_C21MAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $5B4 constant MDMA_MDMA_C21MDR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $5C0 constant MDMA_MDMA_C22ISR        \ MDMA channel 22 interrupt/status register
  $5C4 constant MDMA_MDMA_C22IFCR       \ MDMA channel 22 interrupt flag clear register
  $5C8 constant MDMA_MDMA_C22ESR        \ MDMA channel 22 error status register
  $5CC constant MDMA_MDMA_C22CR         \ This register is used to control the concerned channel.
  $5D0 constant MDMA_MDMA_C22TCR        \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $5D4 constant MDMA_MDMA_C22BNDTR      \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $5D8 constant MDMA_MDMA_C22SAR        \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $5DC constant MDMA_MDMA_C22DAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $5E0 constant MDMA_MDMA_C22BRUR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $5E4 constant MDMA_MDMA_C22LAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $5E8 constant MDMA_MDMA_C22TBR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $5F0 constant MDMA_MDMA_C22MAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $5F4 constant MDMA_MDMA_C22MDR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $600 constant MDMA_MDMA_C23ISR        \ MDMA channel 23 interrupt/status register
  $604 constant MDMA_MDMA_C23IFCR       \ MDMA channel 23 interrupt flag clear register
  $608 constant MDMA_MDMA_C23ESR        \ MDMA channel 23 error status register
  $60C constant MDMA_MDMA_C23CR         \ This register is used to control the concerned channel.
  $610 constant MDMA_MDMA_C23TCR        \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $614 constant MDMA_MDMA_C23BNDTR      \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $618 constant MDMA_MDMA_C23SAR        \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $61C constant MDMA_MDMA_C23DAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $620 constant MDMA_MDMA_C23BRUR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $624 constant MDMA_MDMA_C23LAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $628 constant MDMA_MDMA_C23TBR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $630 constant MDMA_MDMA_C23MAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $634 constant MDMA_MDMA_C23MDR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $640 constant MDMA_MDMA_C24ISR        \ MDMA channel 24 interrupt/status register
  $644 constant MDMA_MDMA_C24IFCR       \ MDMA channel 24 interrupt flag clear register
  $648 constant MDMA_MDMA_C24ESR        \ MDMA channel 24 error status register
  $64C constant MDMA_MDMA_C24CR         \ This register is used to control the concerned channel.
  $650 constant MDMA_MDMA_C24TCR        \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $654 constant MDMA_MDMA_C24BNDTR      \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $658 constant MDMA_MDMA_C24SAR        \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $65C constant MDMA_MDMA_C24DAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $660 constant MDMA_MDMA_C24BRUR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $664 constant MDMA_MDMA_C24LAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $668 constant MDMA_MDMA_C24TBR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $670 constant MDMA_MDMA_C24MAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $674 constant MDMA_MDMA_C24MDR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $680 constant MDMA_MDMA_C25ISR        \ MDMA channel 25 interrupt/status register
  $684 constant MDMA_MDMA_C25IFCR       \ MDMA channel 25 interrupt flag clear register
  $688 constant MDMA_MDMA_C25ESR        \ MDMA channel 25 error status register
  $68C constant MDMA_MDMA_C25CR         \ This register is used to control the concerned channel.
  $690 constant MDMA_MDMA_C25TCR        \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $694 constant MDMA_MDMA_C25BNDTR      \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $698 constant MDMA_MDMA_C25SAR        \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $69C constant MDMA_MDMA_C25DAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $6A0 constant MDMA_MDMA_C25BRUR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $6A4 constant MDMA_MDMA_C25LAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $6A8 constant MDMA_MDMA_C25TBR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $6B0 constant MDMA_MDMA_C25MAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $6B4 constant MDMA_MDMA_C25MDR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $6C0 constant MDMA_MDMA_C26ISR        \ MDMA channel 26 interrupt/status register
  $6C4 constant MDMA_MDMA_C26IFCR       \ MDMA channel 26 interrupt flag clear register
  $6C8 constant MDMA_MDMA_C26ESR        \ MDMA channel 26 error status register
  $6CC constant MDMA_MDMA_C26CR         \ This register is used to control the concerned channel.
  $6D0 constant MDMA_MDMA_C26TCR        \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $6D4 constant MDMA_MDMA_C26BNDTR      \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $6D8 constant MDMA_MDMA_C26SAR        \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $6DC constant MDMA_MDMA_C26DAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $6E0 constant MDMA_MDMA_C26BRUR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $6E4 constant MDMA_MDMA_C26LAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $6E8 constant MDMA_MDMA_C26TBR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $6F0 constant MDMA_MDMA_C26MAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $6F4 constant MDMA_MDMA_C26MDR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $700 constant MDMA_MDMA_C27ISR        \ MDMA channel 27 interrupt/status register
  $704 constant MDMA_MDMA_C27IFCR       \ MDMA channel 27 interrupt flag clear register
  $708 constant MDMA_MDMA_C27ESR        \ MDMA channel 27 error status register
  $70C constant MDMA_MDMA_C27CR         \ This register is used to control the concerned channel.
  $710 constant MDMA_MDMA_C27TCR        \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $714 constant MDMA_MDMA_C27BNDTR      \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $718 constant MDMA_MDMA_C27SAR        \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $71C constant MDMA_MDMA_C27DAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $720 constant MDMA_MDMA_C27BRUR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $724 constant MDMA_MDMA_C27LAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $728 constant MDMA_MDMA_C27TBR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $730 constant MDMA_MDMA_C27MAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $734 constant MDMA_MDMA_C27MDR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $740 constant MDMA_MDMA_C28ISR        \ MDMA channel 28 interrupt/status register
  $744 constant MDMA_MDMA_C28IFCR       \ MDMA channel 28 interrupt flag clear register
  $748 constant MDMA_MDMA_C28ESR        \ MDMA channel 28 error status register
  $74C constant MDMA_MDMA_C28CR         \ This register is used to control the concerned channel.
  $750 constant MDMA_MDMA_C28TCR        \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $754 constant MDMA_MDMA_C28BNDTR      \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $758 constant MDMA_MDMA_C28SAR        \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $75C constant MDMA_MDMA_C28DAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $760 constant MDMA_MDMA_C28BRUR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $764 constant MDMA_MDMA_C28LAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $768 constant MDMA_MDMA_C28TBR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $770 constant MDMA_MDMA_C28MAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $774 constant MDMA_MDMA_C28MDR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $780 constant MDMA_MDMA_C29ISR        \ MDMA channel 29 interrupt/status register
  $784 constant MDMA_MDMA_C29IFCR       \ MDMA channel 29 interrupt flag clear register
  $788 constant MDMA_MDMA_C29ESR        \ MDMA channel 29 error status register
  $78C constant MDMA_MDMA_C29CR         \ This register is used to control the concerned channel.
  $790 constant MDMA_MDMA_C29TCR        \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $794 constant MDMA_MDMA_C29BNDTR      \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $798 constant MDMA_MDMA_C29SAR        \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $79C constant MDMA_MDMA_C29DAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $7A0 constant MDMA_MDMA_C29BRUR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $7A4 constant MDMA_MDMA_C29LAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $7A8 constant MDMA_MDMA_C29TBR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $7B0 constant MDMA_MDMA_C29MAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $7B4 constant MDMA_MDMA_C29MDR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $7C0 constant MDMA_MDMA_C30ISR        \ MDMA channel 30 interrupt/status register
  $7C4 constant MDMA_MDMA_C30IFCR       \ MDMA channel 30 interrupt flag clear register
  $7C8 constant MDMA_MDMA_C30ESR        \ MDMA channel 30 error status register
  $7CC constant MDMA_MDMA_C30CR         \ This register is used to control the concerned channel.
  $7D0 constant MDMA_MDMA_C30TCR        \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $7D4 constant MDMA_MDMA_C30BNDTR      \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $7D8 constant MDMA_MDMA_C30SAR        \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $7DC constant MDMA_MDMA_C30DAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $7E0 constant MDMA_MDMA_C30BRUR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $7E4 constant MDMA_MDMA_C30LAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $7E8 constant MDMA_MDMA_C30TBR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $7F0 constant MDMA_MDMA_C30MAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $7F4 constant MDMA_MDMA_C30MDR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
  $800 constant MDMA_MDMA_C31ISR        \ MDMA channel 31 interrupt/status register
  $804 constant MDMA_MDMA_C31IFCR       \ MDMA channel 31 interrupt flag clear register
  $808 constant MDMA_MDMA_C31ESR        \ MDMA channel 31 error status register
  $80C constant MDMA_MDMA_C31CR         \ This register is used to control the concerned channel.
  $810 constant MDMA_MDMA_C31TCR        \ This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
  $814 constant MDMA_MDMA_C31BNDTR      \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
  $818 constant MDMA_MDMA_C31SAR        \ In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
  $81C constant MDMA_MDMA_C31DAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
  $820 constant MDMA_MDMA_C31BRUR       \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
  $824 constant MDMA_MDMA_C31LAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
  $828 constant MDMA_MDMA_C31TBR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
  $830 constant MDMA_MDMA_C31MAR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
  $834 constant MDMA_MDMA_C31MDR        \ In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).

: MDMA_DEF ; [then]
