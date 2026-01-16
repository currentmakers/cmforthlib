\
\ @file mdma.fs
\ @brief MDMA1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief MDMA global interrupt/status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_GISR0_GIF0                             \ GIF0
$00000002 constant MDMA_MDMA_GISR0_GIF1                             \ GIF1
$00000004 constant MDMA_MDMA_GISR0_GIF2                             \ GIF2
$00000008 constant MDMA_MDMA_GISR0_GIF3                             \ GIF3
$00000010 constant MDMA_MDMA_GISR0_GIF4                             \ GIF4
$00000020 constant MDMA_MDMA_GISR0_GIF5                             \ GIF5
$00000040 constant MDMA_MDMA_GISR0_GIF6                             \ GIF6
$00000080 constant MDMA_MDMA_GISR0_GIF7                             \ GIF7
$00000100 constant MDMA_MDMA_GISR0_GIF8                             \ GIF8
$00000200 constant MDMA_MDMA_GISR0_GIF9                             \ GIF9
$00000400 constant MDMA_MDMA_GISR0_GIF10                            \ GIF10
$00000800 constant MDMA_MDMA_GISR0_GIF11                            \ GIF11
$00001000 constant MDMA_MDMA_GISR0_GIF12                            \ GIF12
$00002000 constant MDMA_MDMA_GISR0_GIF13                            \ GIF13
$00004000 constant MDMA_MDMA_GISR0_GIF14                            \ GIF14
$00008000 constant MDMA_MDMA_GISR0_GIF15                            \ GIF15
$00010000 constant MDMA_MDMA_GISR0_GIF16                            \ GIF16
$00020000 constant MDMA_MDMA_GISR0_GIF17                            \ GIF17
$00040000 constant MDMA_MDMA_GISR0_GIF18                            \ GIF18
$00080000 constant MDMA_MDMA_GISR0_GIF19                            \ GIF19
$00100000 constant MDMA_MDMA_GISR0_GIF20                            \ GIF20
$00200000 constant MDMA_MDMA_GISR0_GIF21                            \ GIF21
$00400000 constant MDMA_MDMA_GISR0_GIF22                            \ GIF22
$00800000 constant MDMA_MDMA_GISR0_GIF23                            \ GIF23
$01000000 constant MDMA_MDMA_GISR0_GIF24                            \ GIF24
$02000000 constant MDMA_MDMA_GISR0_GIF25                            \ GIF25
$04000000 constant MDMA_MDMA_GISR0_GIF26                            \ GIF26
$08000000 constant MDMA_MDMA_GISR0_GIF27                            \ GIF27
$10000000 constant MDMA_MDMA_GISR0_GIF28                            \ GIF28
$20000000 constant MDMA_MDMA_GISR0_GIF29                            \ GIF29
$40000000 constant MDMA_MDMA_GISR0_GIF30                            \ GIF30
$80000000 constant MDMA_MDMA_GISR0_GIF31                            \ GIF31


\
\ @brief MDMA secure global interrupt/status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_SGISR0_GIF0                            \ GIF0
$00000002 constant MDMA_MDMA_SGISR0_GIF1                            \ GIF1
$00000004 constant MDMA_MDMA_SGISR0_GIF2                            \ GIF2
$00000008 constant MDMA_MDMA_SGISR0_GIF3                            \ GIF3
$00000010 constant MDMA_MDMA_SGISR0_GIF4                            \ GIF4
$00000020 constant MDMA_MDMA_SGISR0_GIF5                            \ GIF5
$00000040 constant MDMA_MDMA_SGISR0_GIF6                            \ GIF6
$00000080 constant MDMA_MDMA_SGISR0_GIF7                            \ GIF7
$00000100 constant MDMA_MDMA_SGISR0_GIF8                            \ GIF8
$00000200 constant MDMA_MDMA_SGISR0_GIF9                            \ GIF9
$00000400 constant MDMA_MDMA_SGISR0_GIF10                           \ GIF10
$00000800 constant MDMA_MDMA_SGISR0_GIF11                           \ GIF11
$00001000 constant MDMA_MDMA_SGISR0_GIF12                           \ GIF12
$00002000 constant MDMA_MDMA_SGISR0_GIF13                           \ GIF13
$00004000 constant MDMA_MDMA_SGISR0_GIF14                           \ GIF14
$00008000 constant MDMA_MDMA_SGISR0_GIF15                           \ GIF15
$00010000 constant MDMA_MDMA_SGISR0_GIF16                           \ GIF16
$00020000 constant MDMA_MDMA_SGISR0_GIF17                           \ GIF17
$00040000 constant MDMA_MDMA_SGISR0_GIF18                           \ GIF18
$00080000 constant MDMA_MDMA_SGISR0_GIF19                           \ GIF19
$00100000 constant MDMA_MDMA_SGISR0_GIF20                           \ GIF20
$00200000 constant MDMA_MDMA_SGISR0_GIF21                           \ GIF21
$00400000 constant MDMA_MDMA_SGISR0_GIF22                           \ GIF22
$00800000 constant MDMA_MDMA_SGISR0_GIF23                           \ GIF23
$01000000 constant MDMA_MDMA_SGISR0_GIF24                           \ GIF24
$02000000 constant MDMA_MDMA_SGISR0_GIF25                           \ GIF25
$04000000 constant MDMA_MDMA_SGISR0_GIF26                           \ GIF26
$08000000 constant MDMA_MDMA_SGISR0_GIF27                           \ GIF27
$10000000 constant MDMA_MDMA_SGISR0_GIF28                           \ GIF28
$20000000 constant MDMA_MDMA_SGISR0_GIF29                           \ GIF29
$40000000 constant MDMA_MDMA_SGISR0_GIF30                           \ GIF30
$80000000 constant MDMA_MDMA_SGISR0_GIF31                           \ GIF31


\
\ @brief MDMA channel 0 interrupt/status register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C0ISR_TEIF                             \ TEIF
$00000002 constant MDMA_MDMA_C0ISR_CTCIF                            \ CTCIF
$00000004 constant MDMA_MDMA_C0ISR_BRTIF                            \ BRTIF
$00000008 constant MDMA_MDMA_C0ISR_BTIF                             \ BTIF
$00000010 constant MDMA_MDMA_C0ISR_TCIF                             \ TCIF
$00010000 constant MDMA_MDMA_C0ISR_CRQA                             \ CRQA


\
\ @brief MDMA channel 0 interrupt flag clear register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C0IFCR_CTEIF                           \ CTEIF
$00000002 constant MDMA_MDMA_C0IFCR_CCTCIF                          \ CCTCIF
$00000004 constant MDMA_MDMA_C0IFCR_CBRTIF                          \ CBRTIF
$00000008 constant MDMA_MDMA_C0IFCR_CBTIF                           \ CBTIF
$00000010 constant MDMA_MDMA_C0IFCR_CLTCIF                          \ CLTCIF


\
\ @brief MDMA channel 0 error status register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C0ESR_TEA                              \ TEA
$00000080 constant MDMA_MDMA_C0ESR_TED                              \ TED
$00000100 constant MDMA_MDMA_C0ESR_TELD                             \ TELD
$00000200 constant MDMA_MDMA_C0ESR_TEMD                             \ TEMD
$00000400 constant MDMA_MDMA_C0ESR_ASE                              \ ASE
$00000800 constant MDMA_MDMA_C0ESR_BSE                              \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C0CR_EN                                \ EN
$00000002 constant MDMA_MDMA_C0CR_TEIE                              \ TEIE
$00000004 constant MDMA_MDMA_C0CR_CTCIE                             \ CTCIE
$00000008 constant MDMA_MDMA_C0CR_BRTIE                             \ BRTIE
$00000010 constant MDMA_MDMA_C0CR_BTIE                              \ BTIE
$00000020 constant MDMA_MDMA_C0CR_TCIE                              \ TCIE
$000000c0 constant MDMA_MDMA_C0CR_PL                                \ PL
$00001000 constant MDMA_MDMA_C0CR_BEX                               \ BEX
$00002000 constant MDMA_MDMA_C0CR_HEX                               \ HEX
$00004000 constant MDMA_MDMA_C0CR_WEX                               \ WEX
$00010000 constant MDMA_MDMA_C0CR_SWRQ                              \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C0TCR_SINC                             \ SINC
$0000000c constant MDMA_MDMA_C0TCR_DINC                             \ DINC
$00000030 constant MDMA_MDMA_C0TCR_SSIZE                            \ SSIZE
$000000c0 constant MDMA_MDMA_C0TCR_DSIZE                            \ DSIZE
$00000300 constant MDMA_MDMA_C0TCR_SINCOS                           \ SINCOS
$00000c00 constant MDMA_MDMA_C0TCR_DINCOS                           \ DINCOS
$00007000 constant MDMA_MDMA_C0TCR_SBURST                           \ SBURST
$00038000 constant MDMA_MDMA_C0TCR_DBURST                           \ DBURST
$01fc0000 constant MDMA_MDMA_C0TCR_TLEN                             \ TLEN
$02000000 constant MDMA_MDMA_C0TCR_PKE                              \ PKE
$0c000000 constant MDMA_MDMA_C0TCR_PAM                              \ PAM
$30000000 constant MDMA_MDMA_C0TCR_TRGM                             \ TRGM
$40000000 constant MDMA_MDMA_C0TCR_SWRM                             \ SWRM
$80000000 constant MDMA_MDMA_C0TCR_BWM                              \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C0BNDTR_BNDT                           \ BNDT
$00040000 constant MDMA_MDMA_C0BNDTR_BRSUM                          \ BRSUM
$00080000 constant MDMA_MDMA_C0BNDTR_BRDUM                          \ BRDUM
$fff00000 constant MDMA_MDMA_C0BNDTR_BRC                            \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C0SAR_SAR                              \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C0DAR_DAR                              \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C0BRUR_SUV                             \ SUV
$ffff0000 constant MDMA_MDMA_C0BRUR_DUV                             \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C0LAR_LAR                              \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C0TBR_TSEL                             \ TSEL
$00010000 constant MDMA_MDMA_C0TBR_SBUS                             \ SBUS
$00020000 constant MDMA_MDMA_C0TBR_DBUS                             \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C0MAR_MAR                              \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C0MDR_MDR                              \ MDR


\
\ @brief MDMA channel 1 interrupt/status register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C1ISR_TEIF                             \ TEIF
$00000002 constant MDMA_MDMA_C1ISR_CTCIF                            \ CTCIF
$00000004 constant MDMA_MDMA_C1ISR_BRTIF                            \ BRTIF
$00000008 constant MDMA_MDMA_C1ISR_BTIF                             \ BTIF
$00000010 constant MDMA_MDMA_C1ISR_TCIF                             \ TCIF
$00010000 constant MDMA_MDMA_C1ISR_CRQA                             \ CRQA


\
\ @brief MDMA channel 1 interrupt flag clear register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C1IFCR_CTEIF                           \ CTEIF
$00000002 constant MDMA_MDMA_C1IFCR_CCTCIF                          \ CCTCIF
$00000004 constant MDMA_MDMA_C1IFCR_CBRTIF                          \ CBRTIF
$00000008 constant MDMA_MDMA_C1IFCR_CBTIF                           \ CBTIF
$00000010 constant MDMA_MDMA_C1IFCR_CLTCIF                          \ CLTCIF


\
\ @brief MDMA channel 1 error status register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C1ESR_TEA                              \ TEA
$00000080 constant MDMA_MDMA_C1ESR_TED                              \ TED
$00000100 constant MDMA_MDMA_C1ESR_TELD                             \ TELD
$00000200 constant MDMA_MDMA_C1ESR_TEMD                             \ TEMD
$00000400 constant MDMA_MDMA_C1ESR_ASE                              \ ASE
$00000800 constant MDMA_MDMA_C1ESR_BSE                              \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C1CR_EN                                \ EN
$00000002 constant MDMA_MDMA_C1CR_TEIE                              \ TEIE
$00000004 constant MDMA_MDMA_C1CR_CTCIE                             \ CTCIE
$00000008 constant MDMA_MDMA_C1CR_BRTIE                             \ BRTIE
$00000010 constant MDMA_MDMA_C1CR_BTIE                              \ BTIE
$00000020 constant MDMA_MDMA_C1CR_TCIE                              \ TCIE
$000000c0 constant MDMA_MDMA_C1CR_PL                                \ PL
$00001000 constant MDMA_MDMA_C1CR_BEX                               \ BEX
$00002000 constant MDMA_MDMA_C1CR_HEX                               \ HEX
$00004000 constant MDMA_MDMA_C1CR_WEX                               \ WEX
$00010000 constant MDMA_MDMA_C1CR_SWRQ                              \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C1TCR_SINC                             \ SINC
$0000000c constant MDMA_MDMA_C1TCR_DINC                             \ DINC
$00000030 constant MDMA_MDMA_C1TCR_SSIZE                            \ SSIZE
$000000c0 constant MDMA_MDMA_C1TCR_DSIZE                            \ DSIZE
$00000300 constant MDMA_MDMA_C1TCR_SINCOS                           \ SINCOS
$00000c00 constant MDMA_MDMA_C1TCR_DINCOS                           \ DINCOS
$00007000 constant MDMA_MDMA_C1TCR_SBURST                           \ SBURST
$00038000 constant MDMA_MDMA_C1TCR_DBURST                           \ DBURST
$01fc0000 constant MDMA_MDMA_C1TCR_TLEN                             \ TLEN
$02000000 constant MDMA_MDMA_C1TCR_PKE                              \ PKE
$0c000000 constant MDMA_MDMA_C1TCR_PAM                              \ PAM
$30000000 constant MDMA_MDMA_C1TCR_TRGM                             \ TRGM
$40000000 constant MDMA_MDMA_C1TCR_SWRM                             \ SWRM
$80000000 constant MDMA_MDMA_C1TCR_BWM                              \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C1BNDTR_BNDT                           \ BNDT
$00040000 constant MDMA_MDMA_C1BNDTR_BRSUM                          \ BRSUM
$00080000 constant MDMA_MDMA_C1BNDTR_BRDUM                          \ BRDUM
$fff00000 constant MDMA_MDMA_C1BNDTR_BRC                            \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C1SAR_SAR                              \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C1DAR_DAR                              \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C1BRUR_SUV                             \ SUV
$ffff0000 constant MDMA_MDMA_C1BRUR_DUV                             \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C1LAR_LAR                              \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C1TBR_TSEL                             \ TSEL
$00010000 constant MDMA_MDMA_C1TBR_SBUS                             \ SBUS
$00020000 constant MDMA_MDMA_C1TBR_DBUS                             \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C1MAR_MAR                              \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C1MDR_MDR                              \ MDR


\
\ @brief MDMA channel 2 interrupt/status register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C2ISR_TEIF                             \ TEIF
$00000002 constant MDMA_MDMA_C2ISR_CTCIF                            \ CTCIF
$00000004 constant MDMA_MDMA_C2ISR_BRTIF                            \ BRTIF
$00000008 constant MDMA_MDMA_C2ISR_BTIF                             \ BTIF
$00000010 constant MDMA_MDMA_C2ISR_TCIF                             \ TCIF
$00010000 constant MDMA_MDMA_C2ISR_CRQA                             \ CRQA


\
\ @brief MDMA channel 2 interrupt flag clear register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C2IFCR_CTEIF                           \ CTEIF
$00000002 constant MDMA_MDMA_C2IFCR_CCTCIF                          \ CCTCIF
$00000004 constant MDMA_MDMA_C2IFCR_CBRTIF                          \ CBRTIF
$00000008 constant MDMA_MDMA_C2IFCR_CBTIF                           \ CBTIF
$00000010 constant MDMA_MDMA_C2IFCR_CLTCIF                          \ CLTCIF


\
\ @brief MDMA channel 2 error status register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C2ESR_TEA                              \ TEA
$00000080 constant MDMA_MDMA_C2ESR_TED                              \ TED
$00000100 constant MDMA_MDMA_C2ESR_TELD                             \ TELD
$00000200 constant MDMA_MDMA_C2ESR_TEMD                             \ TEMD
$00000400 constant MDMA_MDMA_C2ESR_ASE                              \ ASE
$00000800 constant MDMA_MDMA_C2ESR_BSE                              \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C2CR_EN                                \ EN
$00000002 constant MDMA_MDMA_C2CR_TEIE                              \ TEIE
$00000004 constant MDMA_MDMA_C2CR_CTCIE                             \ CTCIE
$00000008 constant MDMA_MDMA_C2CR_BRTIE                             \ BRTIE
$00000010 constant MDMA_MDMA_C2CR_BTIE                              \ BTIE
$00000020 constant MDMA_MDMA_C2CR_TCIE                              \ TCIE
$000000c0 constant MDMA_MDMA_C2CR_PL                                \ PL
$00001000 constant MDMA_MDMA_C2CR_BEX                               \ BEX
$00002000 constant MDMA_MDMA_C2CR_HEX                               \ HEX
$00004000 constant MDMA_MDMA_C2CR_WEX                               \ WEX
$00010000 constant MDMA_MDMA_C2CR_SWRQ                              \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C2TCR_SINC                             \ SINC
$0000000c constant MDMA_MDMA_C2TCR_DINC                             \ DINC
$00000030 constant MDMA_MDMA_C2TCR_SSIZE                            \ SSIZE
$000000c0 constant MDMA_MDMA_C2TCR_DSIZE                            \ DSIZE
$00000300 constant MDMA_MDMA_C2TCR_SINCOS                           \ SINCOS
$00000c00 constant MDMA_MDMA_C2TCR_DINCOS                           \ DINCOS
$00007000 constant MDMA_MDMA_C2TCR_SBURST                           \ SBURST
$00038000 constant MDMA_MDMA_C2TCR_DBURST                           \ DBURST
$01fc0000 constant MDMA_MDMA_C2TCR_TLEN                             \ TLEN
$02000000 constant MDMA_MDMA_C2TCR_PKE                              \ PKE
$0c000000 constant MDMA_MDMA_C2TCR_PAM                              \ PAM
$30000000 constant MDMA_MDMA_C2TCR_TRGM                             \ TRGM
$40000000 constant MDMA_MDMA_C2TCR_SWRM                             \ SWRM
$80000000 constant MDMA_MDMA_C2TCR_BWM                              \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C2BNDTR_BNDT                           \ BNDT
$00040000 constant MDMA_MDMA_C2BNDTR_BRSUM                          \ BRSUM
$00080000 constant MDMA_MDMA_C2BNDTR_BRDUM                          \ BRDUM
$fff00000 constant MDMA_MDMA_C2BNDTR_BRC                            \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C2SAR_SAR                              \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C2DAR_DAR                              \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C2BRUR_SUV                             \ SUV
$ffff0000 constant MDMA_MDMA_C2BRUR_DUV                             \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C2LAR_LAR                              \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C2TBR_TSEL                             \ TSEL
$00010000 constant MDMA_MDMA_C2TBR_SBUS                             \ SBUS
$00020000 constant MDMA_MDMA_C2TBR_DBUS                             \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C2MAR_MAR                              \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C2MDR_MDR                              \ MDR


\
\ @brief MDMA channel 3 interrupt/status register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C3ISR_TEIF                             \ TEIF
$00000002 constant MDMA_MDMA_C3ISR_CTCIF                            \ CTCIF
$00000004 constant MDMA_MDMA_C3ISR_BRTIF                            \ BRTIF
$00000008 constant MDMA_MDMA_C3ISR_BTIF                             \ BTIF
$00000010 constant MDMA_MDMA_C3ISR_TCIF                             \ TCIF
$00010000 constant MDMA_MDMA_C3ISR_CRQA                             \ CRQA


\
\ @brief MDMA channel 3 interrupt flag clear register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C3IFCR_CTEIF                           \ CTEIF
$00000002 constant MDMA_MDMA_C3IFCR_CCTCIF                          \ CCTCIF
$00000004 constant MDMA_MDMA_C3IFCR_CBRTIF                          \ CBRTIF
$00000008 constant MDMA_MDMA_C3IFCR_CBTIF                           \ CBTIF
$00000010 constant MDMA_MDMA_C3IFCR_CLTCIF                          \ CLTCIF


\
\ @brief MDMA channel 3 error status register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C3ESR_TEA                              \ TEA
$00000080 constant MDMA_MDMA_C3ESR_TED                              \ TED
$00000100 constant MDMA_MDMA_C3ESR_TELD                             \ TELD
$00000200 constant MDMA_MDMA_C3ESR_TEMD                             \ TEMD
$00000400 constant MDMA_MDMA_C3ESR_ASE                              \ ASE
$00000800 constant MDMA_MDMA_C3ESR_BSE                              \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C3CR_EN                                \ EN
$00000002 constant MDMA_MDMA_C3CR_TEIE                              \ TEIE
$00000004 constant MDMA_MDMA_C3CR_CTCIE                             \ CTCIE
$00000008 constant MDMA_MDMA_C3CR_BRTIE                             \ BRTIE
$00000010 constant MDMA_MDMA_C3CR_BTIE                              \ BTIE
$00000020 constant MDMA_MDMA_C3CR_TCIE                              \ TCIE
$000000c0 constant MDMA_MDMA_C3CR_PL                                \ PL
$00001000 constant MDMA_MDMA_C3CR_BEX                               \ BEX
$00002000 constant MDMA_MDMA_C3CR_HEX                               \ HEX
$00004000 constant MDMA_MDMA_C3CR_WEX                               \ WEX
$00010000 constant MDMA_MDMA_C3CR_SWRQ                              \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C3TCR_SINC                             \ SINC
$0000000c constant MDMA_MDMA_C3TCR_DINC                             \ DINC
$00000030 constant MDMA_MDMA_C3TCR_SSIZE                            \ SSIZE
$000000c0 constant MDMA_MDMA_C3TCR_DSIZE                            \ DSIZE
$00000300 constant MDMA_MDMA_C3TCR_SINCOS                           \ SINCOS
$00000c00 constant MDMA_MDMA_C3TCR_DINCOS                           \ DINCOS
$00007000 constant MDMA_MDMA_C3TCR_SBURST                           \ SBURST
$00038000 constant MDMA_MDMA_C3TCR_DBURST                           \ DBURST
$01fc0000 constant MDMA_MDMA_C3TCR_TLEN                             \ TLEN
$02000000 constant MDMA_MDMA_C3TCR_PKE                              \ PKE
$0c000000 constant MDMA_MDMA_C3TCR_PAM                              \ PAM
$30000000 constant MDMA_MDMA_C3TCR_TRGM                             \ TRGM
$40000000 constant MDMA_MDMA_C3TCR_SWRM                             \ SWRM
$80000000 constant MDMA_MDMA_C3TCR_BWM                              \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C3BNDTR_BNDT                           \ BNDT
$00040000 constant MDMA_MDMA_C3BNDTR_BRSUM                          \ BRSUM
$00080000 constant MDMA_MDMA_C3BNDTR_BRDUM                          \ BRDUM
$fff00000 constant MDMA_MDMA_C3BNDTR_BRC                            \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C3SAR_SAR                              \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C3DAR_DAR                              \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C3BRUR_SUV                             \ SUV
$ffff0000 constant MDMA_MDMA_C3BRUR_DUV                             \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C3LAR_LAR                              \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C3TBR_TSEL                             \ TSEL
$00010000 constant MDMA_MDMA_C3TBR_SBUS                             \ SBUS
$00020000 constant MDMA_MDMA_C3TBR_DBUS                             \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C3MAR_MAR                              \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C3MDR_MDR                              \ MDR


\
\ @brief MDMA channel 4 interrupt/status register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C4ISR_TEIF                             \ TEIF
$00000002 constant MDMA_MDMA_C4ISR_CTCIF                            \ CTCIF
$00000004 constant MDMA_MDMA_C4ISR_BRTIF                            \ BRTIF
$00000008 constant MDMA_MDMA_C4ISR_BTIF                             \ BTIF
$00000010 constant MDMA_MDMA_C4ISR_TCIF                             \ TCIF
$00010000 constant MDMA_MDMA_C4ISR_CRQA                             \ CRQA


\
\ @brief MDMA channel 4 interrupt flag clear register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C4IFCR_CTEIF                           \ CTEIF
$00000002 constant MDMA_MDMA_C4IFCR_CCTCIF                          \ CCTCIF
$00000004 constant MDMA_MDMA_C4IFCR_CBRTIF                          \ CBRTIF
$00000008 constant MDMA_MDMA_C4IFCR_CBTIF                           \ CBTIF
$00000010 constant MDMA_MDMA_C4IFCR_CLTCIF                          \ CLTCIF


\
\ @brief MDMA channel 4 error status register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C4ESR_TEA                              \ TEA
$00000080 constant MDMA_MDMA_C4ESR_TED                              \ TED
$00000100 constant MDMA_MDMA_C4ESR_TELD                             \ TELD
$00000200 constant MDMA_MDMA_C4ESR_TEMD                             \ TEMD
$00000400 constant MDMA_MDMA_C4ESR_ASE                              \ ASE
$00000800 constant MDMA_MDMA_C4ESR_BSE                              \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C4CR_EN                                \ EN
$00000002 constant MDMA_MDMA_C4CR_TEIE                              \ TEIE
$00000004 constant MDMA_MDMA_C4CR_CTCIE                             \ CTCIE
$00000008 constant MDMA_MDMA_C4CR_BRTIE                             \ BRTIE
$00000010 constant MDMA_MDMA_C4CR_BTIE                              \ BTIE
$00000020 constant MDMA_MDMA_C4CR_TCIE                              \ TCIE
$000000c0 constant MDMA_MDMA_C4CR_PL                                \ PL
$00001000 constant MDMA_MDMA_C4CR_BEX                               \ BEX
$00002000 constant MDMA_MDMA_C4CR_HEX                               \ HEX
$00004000 constant MDMA_MDMA_C4CR_WEX                               \ WEX
$00010000 constant MDMA_MDMA_C4CR_SWRQ                              \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C4TCR_SINC                             \ SINC
$0000000c constant MDMA_MDMA_C4TCR_DINC                             \ DINC
$00000030 constant MDMA_MDMA_C4TCR_SSIZE                            \ SSIZE
$000000c0 constant MDMA_MDMA_C4TCR_DSIZE                            \ DSIZE
$00000300 constant MDMA_MDMA_C4TCR_SINCOS                           \ SINCOS
$00000c00 constant MDMA_MDMA_C4TCR_DINCOS                           \ DINCOS
$00007000 constant MDMA_MDMA_C4TCR_SBURST                           \ SBURST
$00038000 constant MDMA_MDMA_C4TCR_DBURST                           \ DBURST
$01fc0000 constant MDMA_MDMA_C4TCR_TLEN                             \ TLEN
$02000000 constant MDMA_MDMA_C4TCR_PKE                              \ PKE
$0c000000 constant MDMA_MDMA_C4TCR_PAM                              \ PAM
$30000000 constant MDMA_MDMA_C4TCR_TRGM                             \ TRGM
$40000000 constant MDMA_MDMA_C4TCR_SWRM                             \ SWRM
$80000000 constant MDMA_MDMA_C4TCR_BWM                              \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C4BNDTR_BNDT                           \ BNDT
$00040000 constant MDMA_MDMA_C4BNDTR_BRSUM                          \ BRSUM
$00080000 constant MDMA_MDMA_C4BNDTR_BRDUM                          \ BRDUM
$fff00000 constant MDMA_MDMA_C4BNDTR_BRC                            \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C4SAR_SAR                              \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C4DAR_DAR                              \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C4BRUR_SUV                             \ SUV
$ffff0000 constant MDMA_MDMA_C4BRUR_DUV                             \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C4LAR_LAR                              \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C4TBR_TSEL                             \ TSEL
$00010000 constant MDMA_MDMA_C4TBR_SBUS                             \ SBUS
$00020000 constant MDMA_MDMA_C4TBR_DBUS                             \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C4MAR_MAR                              \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C4MDR_MDR                              \ MDR


\
\ @brief MDMA channel 5 interrupt/status register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C5ISR_TEIF                             \ TEIF
$00000002 constant MDMA_MDMA_C5ISR_CTCIF                            \ CTCIF
$00000004 constant MDMA_MDMA_C5ISR_BRTIF                            \ BRTIF
$00000008 constant MDMA_MDMA_C5ISR_BTIF                             \ BTIF
$00000010 constant MDMA_MDMA_C5ISR_TCIF                             \ TCIF
$00010000 constant MDMA_MDMA_C5ISR_CRQA                             \ CRQA


\
\ @brief MDMA channel 5 interrupt flag clear register
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C5IFCR_CTEIF                           \ CTEIF
$00000002 constant MDMA_MDMA_C5IFCR_CCTCIF                          \ CCTCIF
$00000004 constant MDMA_MDMA_C5IFCR_CBRTIF                          \ CBRTIF
$00000008 constant MDMA_MDMA_C5IFCR_CBTIF                           \ CBTIF
$00000010 constant MDMA_MDMA_C5IFCR_CLTCIF                          \ CLTCIF


\
\ @brief MDMA channel 5 error status register
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C5ESR_TEA                              \ TEA
$00000080 constant MDMA_MDMA_C5ESR_TED                              \ TED
$00000100 constant MDMA_MDMA_C5ESR_TELD                             \ TELD
$00000200 constant MDMA_MDMA_C5ESR_TEMD                             \ TEMD
$00000400 constant MDMA_MDMA_C5ESR_ASE                              \ ASE
$00000800 constant MDMA_MDMA_C5ESR_BSE                              \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C5CR_EN                                \ EN
$00000002 constant MDMA_MDMA_C5CR_TEIE                              \ TEIE
$00000004 constant MDMA_MDMA_C5CR_CTCIE                             \ CTCIE
$00000008 constant MDMA_MDMA_C5CR_BRTIE                             \ BRTIE
$00000010 constant MDMA_MDMA_C5CR_BTIE                              \ BTIE
$00000020 constant MDMA_MDMA_C5CR_TCIE                              \ TCIE
$000000c0 constant MDMA_MDMA_C5CR_PL                                \ PL
$00001000 constant MDMA_MDMA_C5CR_BEX                               \ BEX
$00002000 constant MDMA_MDMA_C5CR_HEX                               \ HEX
$00004000 constant MDMA_MDMA_C5CR_WEX                               \ WEX
$00010000 constant MDMA_MDMA_C5CR_SWRQ                              \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C5TCR_SINC                             \ SINC
$0000000c constant MDMA_MDMA_C5TCR_DINC                             \ DINC
$00000030 constant MDMA_MDMA_C5TCR_SSIZE                            \ SSIZE
$000000c0 constant MDMA_MDMA_C5TCR_DSIZE                            \ DSIZE
$00000300 constant MDMA_MDMA_C5TCR_SINCOS                           \ SINCOS
$00000c00 constant MDMA_MDMA_C5TCR_DINCOS                           \ DINCOS
$00007000 constant MDMA_MDMA_C5TCR_SBURST                           \ SBURST
$00038000 constant MDMA_MDMA_C5TCR_DBURST                           \ DBURST
$01fc0000 constant MDMA_MDMA_C5TCR_TLEN                             \ TLEN
$02000000 constant MDMA_MDMA_C5TCR_PKE                              \ PKE
$0c000000 constant MDMA_MDMA_C5TCR_PAM                              \ PAM
$30000000 constant MDMA_MDMA_C5TCR_TRGM                             \ TRGM
$40000000 constant MDMA_MDMA_C5TCR_SWRM                             \ SWRM
$80000000 constant MDMA_MDMA_C5TCR_BWM                              \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x194
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C5BNDTR_BNDT                           \ BNDT
$00040000 constant MDMA_MDMA_C5BNDTR_BRSUM                          \ BRSUM
$00080000 constant MDMA_MDMA_C5BNDTR_BRDUM                          \ BRDUM
$fff00000 constant MDMA_MDMA_C5BNDTR_BRC                            \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C5SAR_SAR                              \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x19C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C5DAR_DAR                              \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C5BRUR_SUV                             \ SUV
$ffff0000 constant MDMA_MDMA_C5BRUR_DUV                             \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x1A4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C5LAR_LAR                              \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x1A8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C5TBR_TSEL                             \ TSEL
$00010000 constant MDMA_MDMA_C5TBR_SBUS                             \ SBUS
$00020000 constant MDMA_MDMA_C5TBR_DBUS                             \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x1B0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C5MAR_MAR                              \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x1B4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C5MDR_MDR                              \ MDR


\
\ @brief MDMA channel 6 interrupt/status register
\ Address offset: 0x1C0
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C6ISR_TEIF                             \ TEIF
$00000002 constant MDMA_MDMA_C6ISR_CTCIF                            \ CTCIF
$00000004 constant MDMA_MDMA_C6ISR_BRTIF                            \ BRTIF
$00000008 constant MDMA_MDMA_C6ISR_BTIF                             \ BTIF
$00000010 constant MDMA_MDMA_C6ISR_TCIF                             \ TCIF
$00010000 constant MDMA_MDMA_C6ISR_CRQA                             \ CRQA


\
\ @brief MDMA channel 6 interrupt flag clear register
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C6IFCR_CTEIF                           \ CTEIF
$00000002 constant MDMA_MDMA_C6IFCR_CCTCIF                          \ CCTCIF
$00000004 constant MDMA_MDMA_C6IFCR_CBRTIF                          \ CBRTIF
$00000008 constant MDMA_MDMA_C6IFCR_CBTIF                           \ CBTIF
$00000010 constant MDMA_MDMA_C6IFCR_CLTCIF                          \ CLTCIF


\
\ @brief MDMA channel 6 error status register
\ Address offset: 0x1C8
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C6ESR_TEA                              \ TEA
$00000080 constant MDMA_MDMA_C6ESR_TED                              \ TED
$00000100 constant MDMA_MDMA_C6ESR_TELD                             \ TELD
$00000200 constant MDMA_MDMA_C6ESR_TEMD                             \ TEMD
$00000400 constant MDMA_MDMA_C6ESR_ASE                              \ ASE
$00000800 constant MDMA_MDMA_C6ESR_BSE                              \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x1CC
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C6CR_EN                                \ EN
$00000002 constant MDMA_MDMA_C6CR_TEIE                              \ TEIE
$00000004 constant MDMA_MDMA_C6CR_CTCIE                             \ CTCIE
$00000008 constant MDMA_MDMA_C6CR_BRTIE                             \ BRTIE
$00000010 constant MDMA_MDMA_C6CR_BTIE                              \ BTIE
$00000020 constant MDMA_MDMA_C6CR_TCIE                              \ TCIE
$000000c0 constant MDMA_MDMA_C6CR_PL                                \ PL
$00001000 constant MDMA_MDMA_C6CR_BEX                               \ BEX
$00002000 constant MDMA_MDMA_C6CR_HEX                               \ HEX
$00004000 constant MDMA_MDMA_C6CR_WEX                               \ WEX
$00010000 constant MDMA_MDMA_C6CR_SWRQ                              \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x1D0
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C6TCR_SINC                             \ SINC
$0000000c constant MDMA_MDMA_C6TCR_DINC                             \ DINC
$00000030 constant MDMA_MDMA_C6TCR_SSIZE                            \ SSIZE
$000000c0 constant MDMA_MDMA_C6TCR_DSIZE                            \ DSIZE
$00000300 constant MDMA_MDMA_C6TCR_SINCOS                           \ SINCOS
$00000c00 constant MDMA_MDMA_C6TCR_DINCOS                           \ DINCOS
$00007000 constant MDMA_MDMA_C6TCR_SBURST                           \ SBURST
$00038000 constant MDMA_MDMA_C6TCR_DBURST                           \ DBURST
$01fc0000 constant MDMA_MDMA_C6TCR_TLEN                             \ TLEN
$02000000 constant MDMA_MDMA_C6TCR_PKE                              \ PKE
$0c000000 constant MDMA_MDMA_C6TCR_PAM                              \ PAM
$30000000 constant MDMA_MDMA_C6TCR_TRGM                             \ TRGM
$40000000 constant MDMA_MDMA_C6TCR_SWRM                             \ SWRM
$80000000 constant MDMA_MDMA_C6TCR_BWM                              \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x1D4
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C6BNDTR_BNDT                           \ BNDT
$00040000 constant MDMA_MDMA_C6BNDTR_BRSUM                          \ BRSUM
$00080000 constant MDMA_MDMA_C6BNDTR_BRDUM                          \ BRDUM
$fff00000 constant MDMA_MDMA_C6BNDTR_BRC                            \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x1D8
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C6SAR_SAR                              \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x1DC
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C6DAR_DAR                              \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x1E0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C6BRUR_SUV                             \ SUV
$ffff0000 constant MDMA_MDMA_C6BRUR_DUV                             \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x1E4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C6LAR_LAR                              \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x1E8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C6TBR_TSEL                             \ TSEL
$00010000 constant MDMA_MDMA_C6TBR_SBUS                             \ SBUS
$00020000 constant MDMA_MDMA_C6TBR_DBUS                             \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x1F0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C6MAR_MAR                              \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x1F4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C6MDR_MDR                              \ MDR


\
\ @brief MDMA channel 7 interrupt/status register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C7ISR_TEIF                             \ TEIF
$00000002 constant MDMA_MDMA_C7ISR_CTCIF                            \ CTCIF
$00000004 constant MDMA_MDMA_C7ISR_BRTIF                            \ BRTIF
$00000008 constant MDMA_MDMA_C7ISR_BTIF                             \ BTIF
$00000010 constant MDMA_MDMA_C7ISR_TCIF                             \ TCIF
$00010000 constant MDMA_MDMA_C7ISR_CRQA                             \ CRQA


\
\ @brief MDMA channel 7 interrupt flag clear register
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C7IFCR_CTEIF                           \ CTEIF
$00000002 constant MDMA_MDMA_C7IFCR_CCTCIF                          \ CCTCIF
$00000004 constant MDMA_MDMA_C7IFCR_CBRTIF                          \ CBRTIF
$00000008 constant MDMA_MDMA_C7IFCR_CBTIF                           \ CBTIF
$00000010 constant MDMA_MDMA_C7IFCR_CLTCIF                          \ CLTCIF


\
\ @brief MDMA channel 7 error status register
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C7ESR_TEA                              \ TEA
$00000080 constant MDMA_MDMA_C7ESR_TED                              \ TED
$00000100 constant MDMA_MDMA_C7ESR_TELD                             \ TELD
$00000200 constant MDMA_MDMA_C7ESR_TEMD                             \ TEMD
$00000400 constant MDMA_MDMA_C7ESR_ASE                              \ ASE
$00000800 constant MDMA_MDMA_C7ESR_BSE                              \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C7CR_EN                                \ EN
$00000002 constant MDMA_MDMA_C7CR_TEIE                              \ TEIE
$00000004 constant MDMA_MDMA_C7CR_CTCIE                             \ CTCIE
$00000008 constant MDMA_MDMA_C7CR_BRTIE                             \ BRTIE
$00000010 constant MDMA_MDMA_C7CR_BTIE                              \ BTIE
$00000020 constant MDMA_MDMA_C7CR_TCIE                              \ TCIE
$000000c0 constant MDMA_MDMA_C7CR_PL                                \ PL
$00001000 constant MDMA_MDMA_C7CR_BEX                               \ BEX
$00002000 constant MDMA_MDMA_C7CR_HEX                               \ HEX
$00004000 constant MDMA_MDMA_C7CR_WEX                               \ WEX
$00010000 constant MDMA_MDMA_C7CR_SWRQ                              \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C7TCR_SINC                             \ SINC
$0000000c constant MDMA_MDMA_C7TCR_DINC                             \ DINC
$00000030 constant MDMA_MDMA_C7TCR_SSIZE                            \ SSIZE
$000000c0 constant MDMA_MDMA_C7TCR_DSIZE                            \ DSIZE
$00000300 constant MDMA_MDMA_C7TCR_SINCOS                           \ SINCOS
$00000c00 constant MDMA_MDMA_C7TCR_DINCOS                           \ DINCOS
$00007000 constant MDMA_MDMA_C7TCR_SBURST                           \ SBURST
$00038000 constant MDMA_MDMA_C7TCR_DBURST                           \ DBURST
$01fc0000 constant MDMA_MDMA_C7TCR_TLEN                             \ TLEN
$02000000 constant MDMA_MDMA_C7TCR_PKE                              \ PKE
$0c000000 constant MDMA_MDMA_C7TCR_PAM                              \ PAM
$30000000 constant MDMA_MDMA_C7TCR_TRGM                             \ TRGM
$40000000 constant MDMA_MDMA_C7TCR_SWRM                             \ SWRM
$80000000 constant MDMA_MDMA_C7TCR_BWM                              \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C7BNDTR_BNDT                           \ BNDT
$00040000 constant MDMA_MDMA_C7BNDTR_BRSUM                          \ BRSUM
$00080000 constant MDMA_MDMA_C7BNDTR_BRDUM                          \ BRDUM
$fff00000 constant MDMA_MDMA_C7BNDTR_BRC                            \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C7SAR_SAR                              \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x21C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C7DAR_DAR                              \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C7BRUR_SUV                             \ SUV
$ffff0000 constant MDMA_MDMA_C7BRUR_DUV                             \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C7LAR_LAR                              \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C7TBR_TSEL                             \ TSEL
$00010000 constant MDMA_MDMA_C7TBR_SBUS                             \ SBUS
$00020000 constant MDMA_MDMA_C7TBR_DBUS                             \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x230
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C7MAR_MAR                              \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x234
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C7MDR_MDR                              \ MDR


\
\ @brief MDMA channel 8 interrupt/status register
\ Address offset: 0x240
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C8ISR_TEIF                             \ TEIF
$00000002 constant MDMA_MDMA_C8ISR_CTCIF                            \ CTCIF
$00000004 constant MDMA_MDMA_C8ISR_BRTIF                            \ BRTIF
$00000008 constant MDMA_MDMA_C8ISR_BTIF                             \ BTIF
$00000010 constant MDMA_MDMA_C8ISR_TCIF                             \ TCIF
$00010000 constant MDMA_MDMA_C8ISR_CRQA                             \ CRQA


\
\ @brief MDMA channel 8 interrupt flag clear register
\ Address offset: 0x244
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C8IFCR_CTEIF                           \ CTEIF
$00000002 constant MDMA_MDMA_C8IFCR_CCTCIF                          \ CCTCIF
$00000004 constant MDMA_MDMA_C8IFCR_CBRTIF                          \ CBRTIF
$00000008 constant MDMA_MDMA_C8IFCR_CBTIF                           \ CBTIF
$00000010 constant MDMA_MDMA_C8IFCR_CLTCIF                          \ CLTCIF


\
\ @brief MDMA channel 8 error status register
\ Address offset: 0x248
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C8ESR_TEA                              \ TEA
$00000080 constant MDMA_MDMA_C8ESR_TED                              \ TED
$00000100 constant MDMA_MDMA_C8ESR_TELD                             \ TELD
$00000200 constant MDMA_MDMA_C8ESR_TEMD                             \ TEMD
$00000400 constant MDMA_MDMA_C8ESR_ASE                              \ ASE
$00000800 constant MDMA_MDMA_C8ESR_BSE                              \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x24C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C8CR_EN                                \ EN
$00000002 constant MDMA_MDMA_C8CR_TEIE                              \ TEIE
$00000004 constant MDMA_MDMA_C8CR_CTCIE                             \ CTCIE
$00000008 constant MDMA_MDMA_C8CR_BRTIE                             \ BRTIE
$00000010 constant MDMA_MDMA_C8CR_BTIE                              \ BTIE
$00000020 constant MDMA_MDMA_C8CR_TCIE                              \ TCIE
$000000c0 constant MDMA_MDMA_C8CR_PL                                \ PL
$00001000 constant MDMA_MDMA_C8CR_BEX                               \ BEX
$00002000 constant MDMA_MDMA_C8CR_HEX                               \ HEX
$00004000 constant MDMA_MDMA_C8CR_WEX                               \ WEX
$00010000 constant MDMA_MDMA_C8CR_SWRQ                              \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C8TCR_SINC                             \ SINC
$0000000c constant MDMA_MDMA_C8TCR_DINC                             \ DINC
$00000030 constant MDMA_MDMA_C8TCR_SSIZE                            \ SSIZE
$000000c0 constant MDMA_MDMA_C8TCR_DSIZE                            \ DSIZE
$00000300 constant MDMA_MDMA_C8TCR_SINCOS                           \ SINCOS
$00000c00 constant MDMA_MDMA_C8TCR_DINCOS                           \ DINCOS
$00007000 constant MDMA_MDMA_C8TCR_SBURST                           \ SBURST
$00038000 constant MDMA_MDMA_C8TCR_DBURST                           \ DBURST
$01fc0000 constant MDMA_MDMA_C8TCR_TLEN                             \ TLEN
$02000000 constant MDMA_MDMA_C8TCR_PKE                              \ PKE
$0c000000 constant MDMA_MDMA_C8TCR_PAM                              \ PAM
$30000000 constant MDMA_MDMA_C8TCR_TRGM                             \ TRGM
$40000000 constant MDMA_MDMA_C8TCR_SWRM                             \ SWRM
$80000000 constant MDMA_MDMA_C8TCR_BWM                              \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x254
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C8BNDTR_BNDT                           \ BNDT
$00040000 constant MDMA_MDMA_C8BNDTR_BRSUM                          \ BRSUM
$00080000 constant MDMA_MDMA_C8BNDTR_BRDUM                          \ BRDUM
$fff00000 constant MDMA_MDMA_C8BNDTR_BRC                            \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x258
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C8SAR_SAR                              \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x25C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C8DAR_DAR                              \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x260
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C8BRUR_SUV                             \ SUV
$ffff0000 constant MDMA_MDMA_C8BRUR_DUV                             \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x264
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C8LAR_LAR                              \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x268
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C8TBR_TSEL                             \ TSEL
$00010000 constant MDMA_MDMA_C8TBR_SBUS                             \ SBUS
$00020000 constant MDMA_MDMA_C8TBR_DBUS                             \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x270
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C8MAR_MAR                              \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x274
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C8MDR_MDR                              \ MDR


\
\ @brief MDMA channel 9 interrupt/status register
\ Address offset: 0x280
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C9ISR_TEIF                             \ TEIF
$00000002 constant MDMA_MDMA_C9ISR_CTCIF                            \ CTCIF
$00000004 constant MDMA_MDMA_C9ISR_BRTIF                            \ BRTIF
$00000008 constant MDMA_MDMA_C9ISR_BTIF                             \ BTIF
$00000010 constant MDMA_MDMA_C9ISR_TCIF                             \ TCIF
$00010000 constant MDMA_MDMA_C9ISR_CRQA                             \ CRQA


\
\ @brief MDMA channel 9 interrupt flag clear register
\ Address offset: 0x284
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C9IFCR_CTEIF                           \ CTEIF
$00000002 constant MDMA_MDMA_C9IFCR_CCTCIF                          \ CCTCIF
$00000004 constant MDMA_MDMA_C9IFCR_CBRTIF                          \ CBRTIF
$00000008 constant MDMA_MDMA_C9IFCR_CBTIF                           \ CBTIF
$00000010 constant MDMA_MDMA_C9IFCR_CLTCIF                          \ CLTCIF


\
\ @brief MDMA channel 9 error status register
\ Address offset: 0x288
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C9ESR_TEA                              \ TEA
$00000080 constant MDMA_MDMA_C9ESR_TED                              \ TED
$00000100 constant MDMA_MDMA_C9ESR_TELD                             \ TELD
$00000200 constant MDMA_MDMA_C9ESR_TEMD                             \ TEMD
$00000400 constant MDMA_MDMA_C9ESR_ASE                              \ ASE
$00000800 constant MDMA_MDMA_C9ESR_BSE                              \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x28C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C9CR_EN                                \ EN
$00000002 constant MDMA_MDMA_C9CR_TEIE                              \ TEIE
$00000004 constant MDMA_MDMA_C9CR_CTCIE                             \ CTCIE
$00000008 constant MDMA_MDMA_C9CR_BRTIE                             \ BRTIE
$00000010 constant MDMA_MDMA_C9CR_BTIE                              \ BTIE
$00000020 constant MDMA_MDMA_C9CR_TCIE                              \ TCIE
$000000c0 constant MDMA_MDMA_C9CR_PL                                \ PL
$00001000 constant MDMA_MDMA_C9CR_BEX                               \ BEX
$00002000 constant MDMA_MDMA_C9CR_HEX                               \ HEX
$00004000 constant MDMA_MDMA_C9CR_WEX                               \ WEX
$00010000 constant MDMA_MDMA_C9CR_SWRQ                              \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x290
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C9TCR_SINC                             \ SINC
$0000000c constant MDMA_MDMA_C9TCR_DINC                             \ DINC
$00000030 constant MDMA_MDMA_C9TCR_SSIZE                            \ SSIZE
$000000c0 constant MDMA_MDMA_C9TCR_DSIZE                            \ DSIZE
$00000300 constant MDMA_MDMA_C9TCR_SINCOS                           \ SINCOS
$00000c00 constant MDMA_MDMA_C9TCR_DINCOS                           \ DINCOS
$00007000 constant MDMA_MDMA_C9TCR_SBURST                           \ SBURST
$00038000 constant MDMA_MDMA_C9TCR_DBURST                           \ DBURST
$01fc0000 constant MDMA_MDMA_C9TCR_TLEN                             \ TLEN
$02000000 constant MDMA_MDMA_C9TCR_PKE                              \ PKE
$0c000000 constant MDMA_MDMA_C9TCR_PAM                              \ PAM
$30000000 constant MDMA_MDMA_C9TCR_TRGM                             \ TRGM
$40000000 constant MDMA_MDMA_C9TCR_SWRM                             \ SWRM
$80000000 constant MDMA_MDMA_C9TCR_BWM                              \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x294
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C9BNDTR_BNDT                           \ BNDT
$00040000 constant MDMA_MDMA_C9BNDTR_BRSUM                          \ BRSUM
$00080000 constant MDMA_MDMA_C9BNDTR_BRDUM                          \ BRDUM
$fff00000 constant MDMA_MDMA_C9BNDTR_BRC                            \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x298
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C9SAR_SAR                              \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x29C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C9DAR_DAR                              \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x2A0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C9BRUR_SUV                             \ SUV
$ffff0000 constant MDMA_MDMA_C9BRUR_DUV                             \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x2A4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C9LAR_LAR                              \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x2A8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C9TBR_TSEL                             \ TSEL
$00010000 constant MDMA_MDMA_C9TBR_SBUS                             \ SBUS
$00020000 constant MDMA_MDMA_C9TBR_DBUS                             \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x2B0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C9MAR_MAR                              \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x2B4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C9MDR_MDR                              \ MDR


\
\ @brief MDMA channel 10 interrupt/status register
\ Address offset: 0x2C0
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C10ISR_TEIF                            \ TEIF
$00000002 constant MDMA_MDMA_C10ISR_CTCIF                           \ CTCIF
$00000004 constant MDMA_MDMA_C10ISR_BRTIF                           \ BRTIF
$00000008 constant MDMA_MDMA_C10ISR_BTIF                            \ BTIF
$00000010 constant MDMA_MDMA_C10ISR_TCIF                            \ TCIF
$00010000 constant MDMA_MDMA_C10ISR_CRQA                            \ CRQA


\
\ @brief MDMA channel 10 interrupt flag clear register
\ Address offset: 0x2C4
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C10IFCR_CTEIF                          \ CTEIF
$00000002 constant MDMA_MDMA_C10IFCR_CCTCIF                         \ CCTCIF
$00000004 constant MDMA_MDMA_C10IFCR_CBRTIF                         \ CBRTIF
$00000008 constant MDMA_MDMA_C10IFCR_CBTIF                          \ CBTIF
$00000010 constant MDMA_MDMA_C10IFCR_CLTCIF                         \ CLTCIF


\
\ @brief MDMA channel 10 error status register
\ Address offset: 0x2C8
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C10ESR_TEA                             \ TEA
$00000080 constant MDMA_MDMA_C10ESR_TED                             \ TED
$00000100 constant MDMA_MDMA_C10ESR_TELD                            \ TELD
$00000200 constant MDMA_MDMA_C10ESR_TEMD                            \ TEMD
$00000400 constant MDMA_MDMA_C10ESR_ASE                             \ ASE
$00000800 constant MDMA_MDMA_C10ESR_BSE                             \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x2CC
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C10CR_EN                               \ EN
$00000002 constant MDMA_MDMA_C10CR_TEIE                             \ TEIE
$00000004 constant MDMA_MDMA_C10CR_CTCIE                            \ CTCIE
$00000008 constant MDMA_MDMA_C10CR_BRTIE                            \ BRTIE
$00000010 constant MDMA_MDMA_C10CR_BTIE                             \ BTIE
$00000020 constant MDMA_MDMA_C10CR_TCIE                             \ TCIE
$000000c0 constant MDMA_MDMA_C10CR_PL                               \ PL
$00001000 constant MDMA_MDMA_C10CR_BEX                              \ BEX
$00002000 constant MDMA_MDMA_C10CR_HEX                              \ HEX
$00004000 constant MDMA_MDMA_C10CR_WEX                              \ WEX
$00010000 constant MDMA_MDMA_C10CR_SWRQ                             \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x2D0
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C10TCR_SINC                            \ SINC
$0000000c constant MDMA_MDMA_C10TCR_DINC                            \ DINC
$00000030 constant MDMA_MDMA_C10TCR_SSIZE                           \ SSIZE
$000000c0 constant MDMA_MDMA_C10TCR_DSIZE                           \ DSIZE
$00000300 constant MDMA_MDMA_C10TCR_SINCOS                          \ SINCOS
$00000c00 constant MDMA_MDMA_C10TCR_DINCOS                          \ DINCOS
$00007000 constant MDMA_MDMA_C10TCR_SBURST                          \ SBURST
$00038000 constant MDMA_MDMA_C10TCR_DBURST                          \ DBURST
$01fc0000 constant MDMA_MDMA_C10TCR_TLEN                            \ TLEN
$02000000 constant MDMA_MDMA_C10TCR_PKE                             \ PKE
$0c000000 constant MDMA_MDMA_C10TCR_PAM                             \ PAM
$30000000 constant MDMA_MDMA_C10TCR_TRGM                            \ TRGM
$40000000 constant MDMA_MDMA_C10TCR_SWRM                            \ SWRM
$80000000 constant MDMA_MDMA_C10TCR_BWM                             \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x2D4
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C10BNDTR_BNDT                          \ BNDT
$00040000 constant MDMA_MDMA_C10BNDTR_BRSUM                         \ BRSUM
$00080000 constant MDMA_MDMA_C10BNDTR_BRDUM                         \ BRDUM
$fff00000 constant MDMA_MDMA_C10BNDTR_BRC                           \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x2D8
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C10SAR_SAR                             \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x2DC
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C10DAR_DAR                             \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x2E0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C10BRUR_SUV                            \ SUV
$ffff0000 constant MDMA_MDMA_C10BRUR_DUV                            \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x2E4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C10LAR_LAR                             \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x2E8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C10TBR_TSEL                            \ TSEL
$00010000 constant MDMA_MDMA_C10TBR_SBUS                            \ SBUS
$00020000 constant MDMA_MDMA_C10TBR_DBUS                            \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x2F0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C10MAR_MAR                             \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x2F4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C10MDR_MDR                             \ MDR


\
\ @brief MDMA channel 11 interrupt/status register
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C11ISR_TEIF                            \ TEIF
$00000002 constant MDMA_MDMA_C11ISR_CTCIF                           \ CTCIF
$00000004 constant MDMA_MDMA_C11ISR_BRTIF                           \ BRTIF
$00000008 constant MDMA_MDMA_C11ISR_BTIF                            \ BTIF
$00000010 constant MDMA_MDMA_C11ISR_TCIF                            \ TCIF
$00010000 constant MDMA_MDMA_C11ISR_CRQA                            \ CRQA


\
\ @brief MDMA channel 11 interrupt flag clear register
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C11IFCR_CTEIF                          \ CTEIF
$00000002 constant MDMA_MDMA_C11IFCR_CCTCIF                         \ CCTCIF
$00000004 constant MDMA_MDMA_C11IFCR_CBRTIF                         \ CBRTIF
$00000008 constant MDMA_MDMA_C11IFCR_CBTIF                          \ CBTIF
$00000010 constant MDMA_MDMA_C11IFCR_CLTCIF                         \ CLTCIF


\
\ @brief MDMA channel 11 error status register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C11ESR_TEA                             \ TEA
$00000080 constant MDMA_MDMA_C11ESR_TED                             \ TED
$00000100 constant MDMA_MDMA_C11ESR_TELD                            \ TELD
$00000200 constant MDMA_MDMA_C11ESR_TEMD                            \ TEMD
$00000400 constant MDMA_MDMA_C11ESR_ASE                             \ ASE
$00000800 constant MDMA_MDMA_C11ESR_BSE                             \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x30C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C11CR_EN                               \ EN
$00000002 constant MDMA_MDMA_C11CR_TEIE                             \ TEIE
$00000004 constant MDMA_MDMA_C11CR_CTCIE                            \ CTCIE
$00000008 constant MDMA_MDMA_C11CR_BRTIE                            \ BRTIE
$00000010 constant MDMA_MDMA_C11CR_BTIE                             \ BTIE
$00000020 constant MDMA_MDMA_C11CR_TCIE                             \ TCIE
$000000c0 constant MDMA_MDMA_C11CR_PL                               \ PL
$00001000 constant MDMA_MDMA_C11CR_BEX                              \ BEX
$00002000 constant MDMA_MDMA_C11CR_HEX                              \ HEX
$00004000 constant MDMA_MDMA_C11CR_WEX                              \ WEX
$00010000 constant MDMA_MDMA_C11CR_SWRQ                             \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C11TCR_SINC                            \ SINC
$0000000c constant MDMA_MDMA_C11TCR_DINC                            \ DINC
$00000030 constant MDMA_MDMA_C11TCR_SSIZE                           \ SSIZE
$000000c0 constant MDMA_MDMA_C11TCR_DSIZE                           \ DSIZE
$00000300 constant MDMA_MDMA_C11TCR_SINCOS                          \ SINCOS
$00000c00 constant MDMA_MDMA_C11TCR_DINCOS                          \ DINCOS
$00007000 constant MDMA_MDMA_C11TCR_SBURST                          \ SBURST
$00038000 constant MDMA_MDMA_C11TCR_DBURST                          \ DBURST
$01fc0000 constant MDMA_MDMA_C11TCR_TLEN                            \ TLEN
$02000000 constant MDMA_MDMA_C11TCR_PKE                             \ PKE
$0c000000 constant MDMA_MDMA_C11TCR_PAM                             \ PAM
$30000000 constant MDMA_MDMA_C11TCR_TRGM                            \ TRGM
$40000000 constant MDMA_MDMA_C11TCR_SWRM                            \ SWRM
$80000000 constant MDMA_MDMA_C11TCR_BWM                             \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x314
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C11BNDTR_BNDT                          \ BNDT
$00040000 constant MDMA_MDMA_C11BNDTR_BRSUM                         \ BRSUM
$00080000 constant MDMA_MDMA_C11BNDTR_BRDUM                         \ BRDUM
$fff00000 constant MDMA_MDMA_C11BNDTR_BRC                           \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x318
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C11SAR_SAR                             \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x31C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C11DAR_DAR                             \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x320
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C11BRUR_SUV                            \ SUV
$ffff0000 constant MDMA_MDMA_C11BRUR_DUV                            \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x324
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C11LAR_LAR                             \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x328
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C11TBR_TSEL                            \ TSEL
$00010000 constant MDMA_MDMA_C11TBR_SBUS                            \ SBUS
$00020000 constant MDMA_MDMA_C11TBR_DBUS                            \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x330
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C11MAR_MAR                             \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x334
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C11MDR_MDR                             \ MDR


\
\ @brief MDMA channel 12 interrupt/status register
\ Address offset: 0x340
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C12ISR_TEIF                            \ TEIF
$00000002 constant MDMA_MDMA_C12ISR_CTCIF                           \ CTCIF
$00000004 constant MDMA_MDMA_C12ISR_BRTIF                           \ BRTIF
$00000008 constant MDMA_MDMA_C12ISR_BTIF                            \ BTIF
$00000010 constant MDMA_MDMA_C12ISR_TCIF                            \ TCIF
$00010000 constant MDMA_MDMA_C12ISR_CRQA                            \ CRQA


\
\ @brief MDMA channel 12 interrupt flag clear register
\ Address offset: 0x344
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C12IFCR_CTEIF                          \ CTEIF
$00000002 constant MDMA_MDMA_C12IFCR_CCTCIF                         \ CCTCIF
$00000004 constant MDMA_MDMA_C12IFCR_CBRTIF                         \ CBRTIF
$00000008 constant MDMA_MDMA_C12IFCR_CBTIF                          \ CBTIF
$00000010 constant MDMA_MDMA_C12IFCR_CLTCIF                         \ CLTCIF


\
\ @brief MDMA channel 12 error status register
\ Address offset: 0x348
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C12ESR_TEA                             \ TEA
$00000080 constant MDMA_MDMA_C12ESR_TED                             \ TED
$00000100 constant MDMA_MDMA_C12ESR_TELD                            \ TELD
$00000200 constant MDMA_MDMA_C12ESR_TEMD                            \ TEMD
$00000400 constant MDMA_MDMA_C12ESR_ASE                             \ ASE
$00000800 constant MDMA_MDMA_C12ESR_BSE                             \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x34C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C12CR_EN                               \ EN
$00000002 constant MDMA_MDMA_C12CR_TEIE                             \ TEIE
$00000004 constant MDMA_MDMA_C12CR_CTCIE                            \ CTCIE
$00000008 constant MDMA_MDMA_C12CR_BRTIE                            \ BRTIE
$00000010 constant MDMA_MDMA_C12CR_BTIE                             \ BTIE
$00000020 constant MDMA_MDMA_C12CR_TCIE                             \ TCIE
$000000c0 constant MDMA_MDMA_C12CR_PL                               \ PL
$00001000 constant MDMA_MDMA_C12CR_BEX                              \ BEX
$00002000 constant MDMA_MDMA_C12CR_HEX                              \ HEX
$00004000 constant MDMA_MDMA_C12CR_WEX                              \ WEX
$00010000 constant MDMA_MDMA_C12CR_SWRQ                             \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x350
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C12TCR_SINC                            \ SINC
$0000000c constant MDMA_MDMA_C12TCR_DINC                            \ DINC
$00000030 constant MDMA_MDMA_C12TCR_SSIZE                           \ SSIZE
$000000c0 constant MDMA_MDMA_C12TCR_DSIZE                           \ DSIZE
$00000300 constant MDMA_MDMA_C12TCR_SINCOS                          \ SINCOS
$00000c00 constant MDMA_MDMA_C12TCR_DINCOS                          \ DINCOS
$00007000 constant MDMA_MDMA_C12TCR_SBURST                          \ SBURST
$00038000 constant MDMA_MDMA_C12TCR_DBURST                          \ DBURST
$01fc0000 constant MDMA_MDMA_C12TCR_TLEN                            \ TLEN
$02000000 constant MDMA_MDMA_C12TCR_PKE                             \ PKE
$0c000000 constant MDMA_MDMA_C12TCR_PAM                             \ PAM
$30000000 constant MDMA_MDMA_C12TCR_TRGM                            \ TRGM
$40000000 constant MDMA_MDMA_C12TCR_SWRM                            \ SWRM
$80000000 constant MDMA_MDMA_C12TCR_BWM                             \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x354
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C12BNDTR_BNDT                          \ BNDT
$00040000 constant MDMA_MDMA_C12BNDTR_BRSUM                         \ BRSUM
$00080000 constant MDMA_MDMA_C12BNDTR_BRDUM                         \ BRDUM
$fff00000 constant MDMA_MDMA_C12BNDTR_BRC                           \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x358
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C12SAR_SAR                             \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x35C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C12DAR_DAR                             \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x360
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C12BRUR_SUV                            \ SUV
$ffff0000 constant MDMA_MDMA_C12BRUR_DUV                            \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x364
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C12LAR_LAR                             \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x368
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C12TBR_TSEL                            \ TSEL
$00010000 constant MDMA_MDMA_C12TBR_SBUS                            \ SBUS
$00020000 constant MDMA_MDMA_C12TBR_DBUS                            \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x370
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C12MAR_MAR                             \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x374
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C12MDR_MDR                             \ MDR


\
\ @brief MDMA channel 13 interrupt/status register
\ Address offset: 0x380
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C13ISR_TEIF                            \ TEIF
$00000002 constant MDMA_MDMA_C13ISR_CTCIF                           \ CTCIF
$00000004 constant MDMA_MDMA_C13ISR_BRTIF                           \ BRTIF
$00000008 constant MDMA_MDMA_C13ISR_BTIF                            \ BTIF
$00000010 constant MDMA_MDMA_C13ISR_TCIF                            \ TCIF
$00010000 constant MDMA_MDMA_C13ISR_CRQA                            \ CRQA


\
\ @brief MDMA channel 13 interrupt flag clear register
\ Address offset: 0x384
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C13IFCR_CTEIF                          \ CTEIF
$00000002 constant MDMA_MDMA_C13IFCR_CCTCIF                         \ CCTCIF
$00000004 constant MDMA_MDMA_C13IFCR_CBRTIF                         \ CBRTIF
$00000008 constant MDMA_MDMA_C13IFCR_CBTIF                          \ CBTIF
$00000010 constant MDMA_MDMA_C13IFCR_CLTCIF                         \ CLTCIF


\
\ @brief MDMA channel 13 error status register
\ Address offset: 0x388
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C13ESR_TEA                             \ TEA
$00000080 constant MDMA_MDMA_C13ESR_TED                             \ TED
$00000100 constant MDMA_MDMA_C13ESR_TELD                            \ TELD
$00000200 constant MDMA_MDMA_C13ESR_TEMD                            \ TEMD
$00000400 constant MDMA_MDMA_C13ESR_ASE                             \ ASE
$00000800 constant MDMA_MDMA_C13ESR_BSE                             \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x38C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C13CR_EN                               \ EN
$00000002 constant MDMA_MDMA_C13CR_TEIE                             \ TEIE
$00000004 constant MDMA_MDMA_C13CR_CTCIE                            \ CTCIE
$00000008 constant MDMA_MDMA_C13CR_BRTIE                            \ BRTIE
$00000010 constant MDMA_MDMA_C13CR_BTIE                             \ BTIE
$00000020 constant MDMA_MDMA_C13CR_TCIE                             \ TCIE
$000000c0 constant MDMA_MDMA_C13CR_PL                               \ PL
$00001000 constant MDMA_MDMA_C13CR_BEX                              \ BEX
$00002000 constant MDMA_MDMA_C13CR_HEX                              \ HEX
$00004000 constant MDMA_MDMA_C13CR_WEX                              \ WEX
$00010000 constant MDMA_MDMA_C13CR_SWRQ                             \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x390
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C13TCR_SINC                            \ SINC
$0000000c constant MDMA_MDMA_C13TCR_DINC                            \ DINC
$00000030 constant MDMA_MDMA_C13TCR_SSIZE                           \ SSIZE
$000000c0 constant MDMA_MDMA_C13TCR_DSIZE                           \ DSIZE
$00000300 constant MDMA_MDMA_C13TCR_SINCOS                          \ SINCOS
$00000c00 constant MDMA_MDMA_C13TCR_DINCOS                          \ DINCOS
$00007000 constant MDMA_MDMA_C13TCR_SBURST                          \ SBURST
$00038000 constant MDMA_MDMA_C13TCR_DBURST                          \ DBURST
$01fc0000 constant MDMA_MDMA_C13TCR_TLEN                            \ TLEN
$02000000 constant MDMA_MDMA_C13TCR_PKE                             \ PKE
$0c000000 constant MDMA_MDMA_C13TCR_PAM                             \ PAM
$30000000 constant MDMA_MDMA_C13TCR_TRGM                            \ TRGM
$40000000 constant MDMA_MDMA_C13TCR_SWRM                            \ SWRM
$80000000 constant MDMA_MDMA_C13TCR_BWM                             \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x394
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C13BNDTR_BNDT                          \ BNDT
$00040000 constant MDMA_MDMA_C13BNDTR_BRSUM                         \ BRSUM
$00080000 constant MDMA_MDMA_C13BNDTR_BRDUM                         \ BRDUM
$fff00000 constant MDMA_MDMA_C13BNDTR_BRC                           \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x398
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C13SAR_SAR                             \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x39C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C13DAR_DAR                             \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x3A0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C13BRUR_SUV                            \ SUV
$ffff0000 constant MDMA_MDMA_C13BRUR_DUV                            \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x3A4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C13LAR_LAR                             \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x3A8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C13TBR_TSEL                            \ TSEL
$00010000 constant MDMA_MDMA_C13TBR_SBUS                            \ SBUS
$00020000 constant MDMA_MDMA_C13TBR_DBUS                            \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x3B0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C13MAR_MAR                             \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x3B4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C13MDR_MDR                             \ MDR


\
\ @brief MDMA channel 14 interrupt/status register
\ Address offset: 0x3C0
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C14ISR_TEIF                            \ TEIF
$00000002 constant MDMA_MDMA_C14ISR_CTCIF                           \ CTCIF
$00000004 constant MDMA_MDMA_C14ISR_BRTIF                           \ BRTIF
$00000008 constant MDMA_MDMA_C14ISR_BTIF                            \ BTIF
$00000010 constant MDMA_MDMA_C14ISR_TCIF                            \ TCIF
$00010000 constant MDMA_MDMA_C14ISR_CRQA                            \ CRQA


\
\ @brief MDMA channel 14 interrupt flag clear register
\ Address offset: 0x3C4
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C14IFCR_CTEIF                          \ CTEIF
$00000002 constant MDMA_MDMA_C14IFCR_CCTCIF                         \ CCTCIF
$00000004 constant MDMA_MDMA_C14IFCR_CBRTIF                         \ CBRTIF
$00000008 constant MDMA_MDMA_C14IFCR_CBTIF                          \ CBTIF
$00000010 constant MDMA_MDMA_C14IFCR_CLTCIF                         \ CLTCIF


\
\ @brief MDMA channel 14 error status register
\ Address offset: 0x3C8
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C14ESR_TEA                             \ TEA
$00000080 constant MDMA_MDMA_C14ESR_TED                             \ TED
$00000100 constant MDMA_MDMA_C14ESR_TELD                            \ TELD
$00000200 constant MDMA_MDMA_C14ESR_TEMD                            \ TEMD
$00000400 constant MDMA_MDMA_C14ESR_ASE                             \ ASE
$00000800 constant MDMA_MDMA_C14ESR_BSE                             \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x3CC
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C14CR_EN                               \ EN
$00000002 constant MDMA_MDMA_C14CR_TEIE                             \ TEIE
$00000004 constant MDMA_MDMA_C14CR_CTCIE                            \ CTCIE
$00000008 constant MDMA_MDMA_C14CR_BRTIE                            \ BRTIE
$00000010 constant MDMA_MDMA_C14CR_BTIE                             \ BTIE
$00000020 constant MDMA_MDMA_C14CR_TCIE                             \ TCIE
$000000c0 constant MDMA_MDMA_C14CR_PL                               \ PL
$00001000 constant MDMA_MDMA_C14CR_BEX                              \ BEX
$00002000 constant MDMA_MDMA_C14CR_HEX                              \ HEX
$00004000 constant MDMA_MDMA_C14CR_WEX                              \ WEX
$00010000 constant MDMA_MDMA_C14CR_SWRQ                             \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x3D0
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C14TCR_SINC                            \ SINC
$0000000c constant MDMA_MDMA_C14TCR_DINC                            \ DINC
$00000030 constant MDMA_MDMA_C14TCR_SSIZE                           \ SSIZE
$000000c0 constant MDMA_MDMA_C14TCR_DSIZE                           \ DSIZE
$00000300 constant MDMA_MDMA_C14TCR_SINCOS                          \ SINCOS
$00000c00 constant MDMA_MDMA_C14TCR_DINCOS                          \ DINCOS
$00007000 constant MDMA_MDMA_C14TCR_SBURST                          \ SBURST
$00038000 constant MDMA_MDMA_C14TCR_DBURST                          \ DBURST
$01fc0000 constant MDMA_MDMA_C14TCR_TLEN                            \ TLEN
$02000000 constant MDMA_MDMA_C14TCR_PKE                             \ PKE
$0c000000 constant MDMA_MDMA_C14TCR_PAM                             \ PAM
$30000000 constant MDMA_MDMA_C14TCR_TRGM                            \ TRGM
$40000000 constant MDMA_MDMA_C14TCR_SWRM                            \ SWRM
$80000000 constant MDMA_MDMA_C14TCR_BWM                             \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x3D4
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C14BNDTR_BNDT                          \ BNDT
$00040000 constant MDMA_MDMA_C14BNDTR_BRSUM                         \ BRSUM
$00080000 constant MDMA_MDMA_C14BNDTR_BRDUM                         \ BRDUM
$fff00000 constant MDMA_MDMA_C14BNDTR_BRC                           \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x3D8
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C14SAR_SAR                             \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x3DC
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C14DAR_DAR                             \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x3E0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C14BRUR_SUV                            \ SUV
$ffff0000 constant MDMA_MDMA_C14BRUR_DUV                            \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x3E4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C14LAR_LAR                             \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x3E8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C14TBR_TSEL                            \ TSEL
$00010000 constant MDMA_MDMA_C14TBR_SBUS                            \ SBUS
$00020000 constant MDMA_MDMA_C14TBR_DBUS                            \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x3F0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C14MAR_MAR                             \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x3F4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C14MDR_MDR                             \ MDR


\
\ @brief MDMA channel 15 interrupt/status register
\ Address offset: 0x400
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C15ISR_TEIF                            \ TEIF
$00000002 constant MDMA_MDMA_C15ISR_CTCIF                           \ CTCIF
$00000004 constant MDMA_MDMA_C15ISR_BRTIF                           \ BRTIF
$00000008 constant MDMA_MDMA_C15ISR_BTIF                            \ BTIF
$00000010 constant MDMA_MDMA_C15ISR_TCIF                            \ TCIF
$00010000 constant MDMA_MDMA_C15ISR_CRQA                            \ CRQA


\
\ @brief MDMA channel 15 interrupt flag clear register
\ Address offset: 0x404
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C15IFCR_CTEIF                          \ CTEIF
$00000002 constant MDMA_MDMA_C15IFCR_CCTCIF                         \ CCTCIF
$00000004 constant MDMA_MDMA_C15IFCR_CBRTIF                         \ CBRTIF
$00000008 constant MDMA_MDMA_C15IFCR_CBTIF                          \ CBTIF
$00000010 constant MDMA_MDMA_C15IFCR_CLTCIF                         \ CLTCIF


\
\ @brief MDMA channel 15 error status register
\ Address offset: 0x408
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C15ESR_TEA                             \ TEA
$00000080 constant MDMA_MDMA_C15ESR_TED                             \ TED
$00000100 constant MDMA_MDMA_C15ESR_TELD                            \ TELD
$00000200 constant MDMA_MDMA_C15ESR_TEMD                            \ TEMD
$00000400 constant MDMA_MDMA_C15ESR_ASE                             \ ASE
$00000800 constant MDMA_MDMA_C15ESR_BSE                             \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x40C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C15CR_EN                               \ EN
$00000002 constant MDMA_MDMA_C15CR_TEIE                             \ TEIE
$00000004 constant MDMA_MDMA_C15CR_CTCIE                            \ CTCIE
$00000008 constant MDMA_MDMA_C15CR_BRTIE                            \ BRTIE
$00000010 constant MDMA_MDMA_C15CR_BTIE                             \ BTIE
$00000020 constant MDMA_MDMA_C15CR_TCIE                             \ TCIE
$000000c0 constant MDMA_MDMA_C15CR_PL                               \ PL
$00001000 constant MDMA_MDMA_C15CR_BEX                              \ BEX
$00002000 constant MDMA_MDMA_C15CR_HEX                              \ HEX
$00004000 constant MDMA_MDMA_C15CR_WEX                              \ WEX
$00010000 constant MDMA_MDMA_C15CR_SWRQ                             \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x410
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C15TCR_SINC                            \ SINC
$0000000c constant MDMA_MDMA_C15TCR_DINC                            \ DINC
$00000030 constant MDMA_MDMA_C15TCR_SSIZE                           \ SSIZE
$000000c0 constant MDMA_MDMA_C15TCR_DSIZE                           \ DSIZE
$00000300 constant MDMA_MDMA_C15TCR_SINCOS                          \ SINCOS
$00000c00 constant MDMA_MDMA_C15TCR_DINCOS                          \ DINCOS
$00007000 constant MDMA_MDMA_C15TCR_SBURST                          \ SBURST
$00038000 constant MDMA_MDMA_C15TCR_DBURST                          \ DBURST
$01fc0000 constant MDMA_MDMA_C15TCR_TLEN                            \ TLEN
$02000000 constant MDMA_MDMA_C15TCR_PKE                             \ PKE
$0c000000 constant MDMA_MDMA_C15TCR_PAM                             \ PAM
$30000000 constant MDMA_MDMA_C15TCR_TRGM                            \ TRGM
$40000000 constant MDMA_MDMA_C15TCR_SWRM                            \ SWRM
$80000000 constant MDMA_MDMA_C15TCR_BWM                             \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x414
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C15BNDTR_BNDT                          \ BNDT
$00040000 constant MDMA_MDMA_C15BNDTR_BRSUM                         \ BRSUM
$00080000 constant MDMA_MDMA_C15BNDTR_BRDUM                         \ BRDUM
$fff00000 constant MDMA_MDMA_C15BNDTR_BRC                           \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x418
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C15SAR_SAR                             \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x41C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C15DAR_DAR                             \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x420
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C15BRUR_SUV                            \ SUV
$ffff0000 constant MDMA_MDMA_C15BRUR_DUV                            \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x424
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C15LAR_LAR                             \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x428
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C15TBR_TSEL                            \ TSEL
$00010000 constant MDMA_MDMA_C15TBR_SBUS                            \ SBUS
$00020000 constant MDMA_MDMA_C15TBR_DBUS                            \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x430
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C15MAR_MAR                             \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x434
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C15MDR_MDR                             \ MDR


\
\ @brief MDMA channel 16 interrupt/status register
\ Address offset: 0x440
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C16ISR_TEIF                            \ TEIF
$00000002 constant MDMA_MDMA_C16ISR_CTCIF                           \ CTCIF
$00000004 constant MDMA_MDMA_C16ISR_BRTIF                           \ BRTIF
$00000008 constant MDMA_MDMA_C16ISR_BTIF                            \ BTIF
$00000010 constant MDMA_MDMA_C16ISR_TCIF                            \ TCIF
$00010000 constant MDMA_MDMA_C16ISR_CRQA                            \ CRQA


\
\ @brief MDMA channel 16 interrupt flag clear register
\ Address offset: 0x444
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C16IFCR_CTEIF                          \ CTEIF
$00000002 constant MDMA_MDMA_C16IFCR_CCTCIF                         \ CCTCIF
$00000004 constant MDMA_MDMA_C16IFCR_CBRTIF                         \ CBRTIF
$00000008 constant MDMA_MDMA_C16IFCR_CBTIF                          \ CBTIF
$00000010 constant MDMA_MDMA_C16IFCR_CLTCIF                         \ CLTCIF


\
\ @brief MDMA channel 16 error status register
\ Address offset: 0x448
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C16ESR_TEA                             \ TEA
$00000080 constant MDMA_MDMA_C16ESR_TED                             \ TED
$00000100 constant MDMA_MDMA_C16ESR_TELD                            \ TELD
$00000200 constant MDMA_MDMA_C16ESR_TEMD                            \ TEMD
$00000400 constant MDMA_MDMA_C16ESR_ASE                             \ ASE
$00000800 constant MDMA_MDMA_C16ESR_BSE                             \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x44C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C16CR_EN                               \ EN
$00000002 constant MDMA_MDMA_C16CR_TEIE                             \ TEIE
$00000004 constant MDMA_MDMA_C16CR_CTCIE                            \ CTCIE
$00000008 constant MDMA_MDMA_C16CR_BRTIE                            \ BRTIE
$00000010 constant MDMA_MDMA_C16CR_BTIE                             \ BTIE
$00000020 constant MDMA_MDMA_C16CR_TCIE                             \ TCIE
$000000c0 constant MDMA_MDMA_C16CR_PL                               \ PL
$00001000 constant MDMA_MDMA_C16CR_BEX                              \ BEX
$00002000 constant MDMA_MDMA_C16CR_HEX                              \ HEX
$00004000 constant MDMA_MDMA_C16CR_WEX                              \ WEX
$00010000 constant MDMA_MDMA_C16CR_SWRQ                             \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x450
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C16TCR_SINC                            \ SINC
$0000000c constant MDMA_MDMA_C16TCR_DINC                            \ DINC
$00000030 constant MDMA_MDMA_C16TCR_SSIZE                           \ SSIZE
$000000c0 constant MDMA_MDMA_C16TCR_DSIZE                           \ DSIZE
$00000300 constant MDMA_MDMA_C16TCR_SINCOS                          \ SINCOS
$00000c00 constant MDMA_MDMA_C16TCR_DINCOS                          \ DINCOS
$00007000 constant MDMA_MDMA_C16TCR_SBURST                          \ SBURST
$00038000 constant MDMA_MDMA_C16TCR_DBURST                          \ DBURST
$01fc0000 constant MDMA_MDMA_C16TCR_TLEN                            \ TLEN
$02000000 constant MDMA_MDMA_C16TCR_PKE                             \ PKE
$0c000000 constant MDMA_MDMA_C16TCR_PAM                             \ PAM
$30000000 constant MDMA_MDMA_C16TCR_TRGM                            \ TRGM
$40000000 constant MDMA_MDMA_C16TCR_SWRM                            \ SWRM
$80000000 constant MDMA_MDMA_C16TCR_BWM                             \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x454
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C16BNDTR_BNDT                          \ BNDT
$00040000 constant MDMA_MDMA_C16BNDTR_BRSUM                         \ BRSUM
$00080000 constant MDMA_MDMA_C16BNDTR_BRDUM                         \ BRDUM
$fff00000 constant MDMA_MDMA_C16BNDTR_BRC                           \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x458
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C16SAR_SAR                             \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x45C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C16DAR_DAR                             \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x460
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C16BRUR_SUV                            \ SUV
$ffff0000 constant MDMA_MDMA_C16BRUR_DUV                            \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x464
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C16LAR_LAR                             \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x468
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C16TBR_TSEL                            \ TSEL
$00010000 constant MDMA_MDMA_C16TBR_SBUS                            \ SBUS
$00020000 constant MDMA_MDMA_C16TBR_DBUS                            \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x470
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C16MAR_MAR                             \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x474
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C16MDR_MDR                             \ MDR


\
\ @brief MDMA channel 17 interrupt/status register
\ Address offset: 0x480
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C17ISR_TEIF                            \ TEIF
$00000002 constant MDMA_MDMA_C17ISR_CTCIF                           \ CTCIF
$00000004 constant MDMA_MDMA_C17ISR_BRTIF                           \ BRTIF
$00000008 constant MDMA_MDMA_C17ISR_BTIF                            \ BTIF
$00000010 constant MDMA_MDMA_C17ISR_TCIF                            \ TCIF
$00010000 constant MDMA_MDMA_C17ISR_CRQA                            \ CRQA


\
\ @brief MDMA channel 17 interrupt flag clear register
\ Address offset: 0x484
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C17IFCR_CTEIF                          \ CTEIF
$00000002 constant MDMA_MDMA_C17IFCR_CCTCIF                         \ CCTCIF
$00000004 constant MDMA_MDMA_C17IFCR_CBRTIF                         \ CBRTIF
$00000008 constant MDMA_MDMA_C17IFCR_CBTIF                          \ CBTIF
$00000010 constant MDMA_MDMA_C17IFCR_CLTCIF                         \ CLTCIF


\
\ @brief MDMA channel 17 error status register
\ Address offset: 0x488
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C17ESR_TEA                             \ TEA
$00000080 constant MDMA_MDMA_C17ESR_TED                             \ TED
$00000100 constant MDMA_MDMA_C17ESR_TELD                            \ TELD
$00000200 constant MDMA_MDMA_C17ESR_TEMD                            \ TEMD
$00000400 constant MDMA_MDMA_C17ESR_ASE                             \ ASE
$00000800 constant MDMA_MDMA_C17ESR_BSE                             \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x48C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C17CR_EN                               \ EN
$00000002 constant MDMA_MDMA_C17CR_TEIE                             \ TEIE
$00000004 constant MDMA_MDMA_C17CR_CTCIE                            \ CTCIE
$00000008 constant MDMA_MDMA_C17CR_BRTIE                            \ BRTIE
$00000010 constant MDMA_MDMA_C17CR_BTIE                             \ BTIE
$00000020 constant MDMA_MDMA_C17CR_TCIE                             \ TCIE
$000000c0 constant MDMA_MDMA_C17CR_PL                               \ PL
$00001000 constant MDMA_MDMA_C17CR_BEX                              \ BEX
$00002000 constant MDMA_MDMA_C17CR_HEX                              \ HEX
$00004000 constant MDMA_MDMA_C17CR_WEX                              \ WEX
$00010000 constant MDMA_MDMA_C17CR_SWRQ                             \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x490
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C17TCR_SINC                            \ SINC
$0000000c constant MDMA_MDMA_C17TCR_DINC                            \ DINC
$00000030 constant MDMA_MDMA_C17TCR_SSIZE                           \ SSIZE
$000000c0 constant MDMA_MDMA_C17TCR_DSIZE                           \ DSIZE
$00000300 constant MDMA_MDMA_C17TCR_SINCOS                          \ SINCOS
$00000c00 constant MDMA_MDMA_C17TCR_DINCOS                          \ DINCOS
$00007000 constant MDMA_MDMA_C17TCR_SBURST                          \ SBURST
$00038000 constant MDMA_MDMA_C17TCR_DBURST                          \ DBURST
$01fc0000 constant MDMA_MDMA_C17TCR_TLEN                            \ TLEN
$02000000 constant MDMA_MDMA_C17TCR_PKE                             \ PKE
$0c000000 constant MDMA_MDMA_C17TCR_PAM                             \ PAM
$30000000 constant MDMA_MDMA_C17TCR_TRGM                            \ TRGM
$40000000 constant MDMA_MDMA_C17TCR_SWRM                            \ SWRM
$80000000 constant MDMA_MDMA_C17TCR_BWM                             \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x494
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C17BNDTR_BNDT                          \ BNDT
$00040000 constant MDMA_MDMA_C17BNDTR_BRSUM                         \ BRSUM
$00080000 constant MDMA_MDMA_C17BNDTR_BRDUM                         \ BRDUM
$fff00000 constant MDMA_MDMA_C17BNDTR_BRC                           \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x498
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C17SAR_SAR                             \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x49C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C17DAR_DAR                             \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x4A0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C17BRUR_SUV                            \ SUV
$ffff0000 constant MDMA_MDMA_C17BRUR_DUV                            \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x4A4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C17LAR_LAR                             \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x4A8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C17TBR_TSEL                            \ TSEL
$00010000 constant MDMA_MDMA_C17TBR_SBUS                            \ SBUS
$00020000 constant MDMA_MDMA_C17TBR_DBUS                            \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x4B0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C17MAR_MAR                             \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x4B4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C17MDR_MDR                             \ MDR


\
\ @brief MDMA channel 18 interrupt/status register
\ Address offset: 0x4C0
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C18ISR_TEIF                            \ TEIF
$00000002 constant MDMA_MDMA_C18ISR_CTCIF                           \ CTCIF
$00000004 constant MDMA_MDMA_C18ISR_BRTIF                           \ BRTIF
$00000008 constant MDMA_MDMA_C18ISR_BTIF                            \ BTIF
$00000010 constant MDMA_MDMA_C18ISR_TCIF                            \ TCIF
$00010000 constant MDMA_MDMA_C18ISR_CRQA                            \ CRQA


\
\ @brief MDMA channel 18 interrupt flag clear register
\ Address offset: 0x4C4
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C18IFCR_CTEIF                          \ CTEIF
$00000002 constant MDMA_MDMA_C18IFCR_CCTCIF                         \ CCTCIF
$00000004 constant MDMA_MDMA_C18IFCR_CBRTIF                         \ CBRTIF
$00000008 constant MDMA_MDMA_C18IFCR_CBTIF                          \ CBTIF
$00000010 constant MDMA_MDMA_C18IFCR_CLTCIF                         \ CLTCIF


\
\ @brief MDMA channel 18 error status register
\ Address offset: 0x4C8
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C18ESR_TEA                             \ TEA
$00000080 constant MDMA_MDMA_C18ESR_TED                             \ TED
$00000100 constant MDMA_MDMA_C18ESR_TELD                            \ TELD
$00000200 constant MDMA_MDMA_C18ESR_TEMD                            \ TEMD
$00000400 constant MDMA_MDMA_C18ESR_ASE                             \ ASE
$00000800 constant MDMA_MDMA_C18ESR_BSE                             \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x4CC
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C18CR_EN                               \ EN
$00000002 constant MDMA_MDMA_C18CR_TEIE                             \ TEIE
$00000004 constant MDMA_MDMA_C18CR_CTCIE                            \ CTCIE
$00000008 constant MDMA_MDMA_C18CR_BRTIE                            \ BRTIE
$00000010 constant MDMA_MDMA_C18CR_BTIE                             \ BTIE
$00000020 constant MDMA_MDMA_C18CR_TCIE                             \ TCIE
$000000c0 constant MDMA_MDMA_C18CR_PL                               \ PL
$00001000 constant MDMA_MDMA_C18CR_BEX                              \ BEX
$00002000 constant MDMA_MDMA_C18CR_HEX                              \ HEX
$00004000 constant MDMA_MDMA_C18CR_WEX                              \ WEX
$00010000 constant MDMA_MDMA_C18CR_SWRQ                             \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x4D0
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C18TCR_SINC                            \ SINC
$0000000c constant MDMA_MDMA_C18TCR_DINC                            \ DINC
$00000030 constant MDMA_MDMA_C18TCR_SSIZE                           \ SSIZE
$000000c0 constant MDMA_MDMA_C18TCR_DSIZE                           \ DSIZE
$00000300 constant MDMA_MDMA_C18TCR_SINCOS                          \ SINCOS
$00000c00 constant MDMA_MDMA_C18TCR_DINCOS                          \ DINCOS
$00007000 constant MDMA_MDMA_C18TCR_SBURST                          \ SBURST
$00038000 constant MDMA_MDMA_C18TCR_DBURST                          \ DBURST
$01fc0000 constant MDMA_MDMA_C18TCR_TLEN                            \ TLEN
$02000000 constant MDMA_MDMA_C18TCR_PKE                             \ PKE
$0c000000 constant MDMA_MDMA_C18TCR_PAM                             \ PAM
$30000000 constant MDMA_MDMA_C18TCR_TRGM                            \ TRGM
$40000000 constant MDMA_MDMA_C18TCR_SWRM                            \ SWRM
$80000000 constant MDMA_MDMA_C18TCR_BWM                             \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x4D4
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C18BNDTR_BNDT                          \ BNDT
$00040000 constant MDMA_MDMA_C18BNDTR_BRSUM                         \ BRSUM
$00080000 constant MDMA_MDMA_C18BNDTR_BRDUM                         \ BRDUM
$fff00000 constant MDMA_MDMA_C18BNDTR_BRC                           \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x4D8
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C18SAR_SAR                             \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x4DC
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C18DAR_DAR                             \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x4E0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C18BRUR_SUV                            \ SUV
$ffff0000 constant MDMA_MDMA_C18BRUR_DUV                            \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x4E4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C18LAR_LAR                             \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x4E8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C18TBR_TSEL                            \ TSEL
$00010000 constant MDMA_MDMA_C18TBR_SBUS                            \ SBUS
$00020000 constant MDMA_MDMA_C18TBR_DBUS                            \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x4F0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C18MAR_MAR                             \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x4F4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C18MDR_MDR                             \ MDR


\
\ @brief MDMA channel 19 interrupt/status register
\ Address offset: 0x500
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C19ISR_TEIF                            \ TEIF
$00000002 constant MDMA_MDMA_C19ISR_CTCIF                           \ CTCIF
$00000004 constant MDMA_MDMA_C19ISR_BRTIF                           \ BRTIF
$00000008 constant MDMA_MDMA_C19ISR_BTIF                            \ BTIF
$00000010 constant MDMA_MDMA_C19ISR_TCIF                            \ TCIF
$00010000 constant MDMA_MDMA_C19ISR_CRQA                            \ CRQA


\
\ @brief MDMA channel 19 interrupt flag clear register
\ Address offset: 0x504
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C19IFCR_CTEIF                          \ CTEIF
$00000002 constant MDMA_MDMA_C19IFCR_CCTCIF                         \ CCTCIF
$00000004 constant MDMA_MDMA_C19IFCR_CBRTIF                         \ CBRTIF
$00000008 constant MDMA_MDMA_C19IFCR_CBTIF                          \ CBTIF
$00000010 constant MDMA_MDMA_C19IFCR_CLTCIF                         \ CLTCIF


\
\ @brief MDMA channel 19 error status register
\ Address offset: 0x508
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C19ESR_TEA                             \ TEA
$00000080 constant MDMA_MDMA_C19ESR_TED                             \ TED
$00000100 constant MDMA_MDMA_C19ESR_TELD                            \ TELD
$00000200 constant MDMA_MDMA_C19ESR_TEMD                            \ TEMD
$00000400 constant MDMA_MDMA_C19ESR_ASE                             \ ASE
$00000800 constant MDMA_MDMA_C19ESR_BSE                             \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x50C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C19CR_EN                               \ EN
$00000002 constant MDMA_MDMA_C19CR_TEIE                             \ TEIE
$00000004 constant MDMA_MDMA_C19CR_CTCIE                            \ CTCIE
$00000008 constant MDMA_MDMA_C19CR_BRTIE                            \ BRTIE
$00000010 constant MDMA_MDMA_C19CR_BTIE                             \ BTIE
$00000020 constant MDMA_MDMA_C19CR_TCIE                             \ TCIE
$000000c0 constant MDMA_MDMA_C19CR_PL                               \ PL
$00001000 constant MDMA_MDMA_C19CR_BEX                              \ BEX
$00002000 constant MDMA_MDMA_C19CR_HEX                              \ HEX
$00004000 constant MDMA_MDMA_C19CR_WEX                              \ WEX
$00010000 constant MDMA_MDMA_C19CR_SWRQ                             \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x510
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C19TCR_SINC                            \ SINC
$0000000c constant MDMA_MDMA_C19TCR_DINC                            \ DINC
$00000030 constant MDMA_MDMA_C19TCR_SSIZE                           \ SSIZE
$000000c0 constant MDMA_MDMA_C19TCR_DSIZE                           \ DSIZE
$00000300 constant MDMA_MDMA_C19TCR_SINCOS                          \ SINCOS
$00000c00 constant MDMA_MDMA_C19TCR_DINCOS                          \ DINCOS
$00007000 constant MDMA_MDMA_C19TCR_SBURST                          \ SBURST
$00038000 constant MDMA_MDMA_C19TCR_DBURST                          \ DBURST
$01fc0000 constant MDMA_MDMA_C19TCR_TLEN                            \ TLEN
$02000000 constant MDMA_MDMA_C19TCR_PKE                             \ PKE
$0c000000 constant MDMA_MDMA_C19TCR_PAM                             \ PAM
$30000000 constant MDMA_MDMA_C19TCR_TRGM                            \ TRGM
$40000000 constant MDMA_MDMA_C19TCR_SWRM                            \ SWRM
$80000000 constant MDMA_MDMA_C19TCR_BWM                             \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x514
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C19BNDTR_BNDT                          \ BNDT
$00040000 constant MDMA_MDMA_C19BNDTR_BRSUM                         \ BRSUM
$00080000 constant MDMA_MDMA_C19BNDTR_BRDUM                         \ BRDUM
$fff00000 constant MDMA_MDMA_C19BNDTR_BRC                           \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x518
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C19SAR_SAR                             \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x51C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C19DAR_DAR                             \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x520
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C19BRUR_SUV                            \ SUV
$ffff0000 constant MDMA_MDMA_C19BRUR_DUV                            \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x524
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C19LAR_LAR                             \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x528
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C19TBR_TSEL                            \ TSEL
$00010000 constant MDMA_MDMA_C19TBR_SBUS                            \ SBUS
$00020000 constant MDMA_MDMA_C19TBR_DBUS                            \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x530
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C19MAR_MAR                             \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x534
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C19MDR_MDR                             \ MDR


\
\ @brief MDMA channel 20 interrupt/status register
\ Address offset: 0x540
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C20ISR_TEIF                            \ TEIF
$00000002 constant MDMA_MDMA_C20ISR_CTCIF                           \ CTCIF
$00000004 constant MDMA_MDMA_C20ISR_BRTIF                           \ BRTIF
$00000008 constant MDMA_MDMA_C20ISR_BTIF                            \ BTIF
$00000010 constant MDMA_MDMA_C20ISR_TCIF                            \ TCIF
$00010000 constant MDMA_MDMA_C20ISR_CRQA                            \ CRQA


\
\ @brief MDMA channel 20 interrupt flag clear register
\ Address offset: 0x544
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C20IFCR_CTEIF                          \ CTEIF
$00000002 constant MDMA_MDMA_C20IFCR_CCTCIF                         \ CCTCIF
$00000004 constant MDMA_MDMA_C20IFCR_CBRTIF                         \ CBRTIF
$00000008 constant MDMA_MDMA_C20IFCR_CBTIF                          \ CBTIF
$00000010 constant MDMA_MDMA_C20IFCR_CLTCIF                         \ CLTCIF


\
\ @brief MDMA channel 20 error status register
\ Address offset: 0x548
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C20ESR_TEA                             \ TEA
$00000080 constant MDMA_MDMA_C20ESR_TED                             \ TED
$00000100 constant MDMA_MDMA_C20ESR_TELD                            \ TELD
$00000200 constant MDMA_MDMA_C20ESR_TEMD                            \ TEMD
$00000400 constant MDMA_MDMA_C20ESR_ASE                             \ ASE
$00000800 constant MDMA_MDMA_C20ESR_BSE                             \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x54C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C20CR_EN                               \ EN
$00000002 constant MDMA_MDMA_C20CR_TEIE                             \ TEIE
$00000004 constant MDMA_MDMA_C20CR_CTCIE                            \ CTCIE
$00000008 constant MDMA_MDMA_C20CR_BRTIE                            \ BRTIE
$00000010 constant MDMA_MDMA_C20CR_BTIE                             \ BTIE
$00000020 constant MDMA_MDMA_C20CR_TCIE                             \ TCIE
$000000c0 constant MDMA_MDMA_C20CR_PL                               \ PL
$00001000 constant MDMA_MDMA_C20CR_BEX                              \ BEX
$00002000 constant MDMA_MDMA_C20CR_HEX                              \ HEX
$00004000 constant MDMA_MDMA_C20CR_WEX                              \ WEX
$00010000 constant MDMA_MDMA_C20CR_SWRQ                             \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x550
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C20TCR_SINC                            \ SINC
$0000000c constant MDMA_MDMA_C20TCR_DINC                            \ DINC
$00000030 constant MDMA_MDMA_C20TCR_SSIZE                           \ SSIZE
$000000c0 constant MDMA_MDMA_C20TCR_DSIZE                           \ DSIZE
$00000300 constant MDMA_MDMA_C20TCR_SINCOS                          \ SINCOS
$00000c00 constant MDMA_MDMA_C20TCR_DINCOS                          \ DINCOS
$00007000 constant MDMA_MDMA_C20TCR_SBURST                          \ SBURST
$00038000 constant MDMA_MDMA_C20TCR_DBURST                          \ DBURST
$01fc0000 constant MDMA_MDMA_C20TCR_TLEN                            \ TLEN
$02000000 constant MDMA_MDMA_C20TCR_PKE                             \ PKE
$0c000000 constant MDMA_MDMA_C20TCR_PAM                             \ PAM
$30000000 constant MDMA_MDMA_C20TCR_TRGM                            \ TRGM
$40000000 constant MDMA_MDMA_C20TCR_SWRM                            \ SWRM
$80000000 constant MDMA_MDMA_C20TCR_BWM                             \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x554
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C20BNDTR_BNDT                          \ BNDT
$00040000 constant MDMA_MDMA_C20BNDTR_BRSUM                         \ BRSUM
$00080000 constant MDMA_MDMA_C20BNDTR_BRDUM                         \ BRDUM
$fff00000 constant MDMA_MDMA_C20BNDTR_BRC                           \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x558
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C20SAR_SAR                             \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x55C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C20DAR_DAR                             \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x560
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C20BRUR_SUV                            \ SUV
$ffff0000 constant MDMA_MDMA_C20BRUR_DUV                            \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x564
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C20LAR_LAR                             \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x568
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C20TBR_TSEL                            \ TSEL
$00010000 constant MDMA_MDMA_C20TBR_SBUS                            \ SBUS
$00020000 constant MDMA_MDMA_C20TBR_DBUS                            \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x570
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C20MAR_MAR                             \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x574
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C20MDR_MDR                             \ MDR


\
\ @brief MDMA channel 21 interrupt/status register
\ Address offset: 0x580
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C21ISR_TEIF                            \ TEIF
$00000002 constant MDMA_MDMA_C21ISR_CTCIF                           \ CTCIF
$00000004 constant MDMA_MDMA_C21ISR_BRTIF                           \ BRTIF
$00000008 constant MDMA_MDMA_C21ISR_BTIF                            \ BTIF
$00000010 constant MDMA_MDMA_C21ISR_TCIF                            \ TCIF
$00010000 constant MDMA_MDMA_C21ISR_CRQA                            \ CRQA


\
\ @brief MDMA channel 21 interrupt flag clear register
\ Address offset: 0x584
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C21IFCR_CTEIF                          \ CTEIF
$00000002 constant MDMA_MDMA_C21IFCR_CCTCIF                         \ CCTCIF
$00000004 constant MDMA_MDMA_C21IFCR_CBRTIF                         \ CBRTIF
$00000008 constant MDMA_MDMA_C21IFCR_CBTIF                          \ CBTIF
$00000010 constant MDMA_MDMA_C21IFCR_CLTCIF                         \ CLTCIF


\
\ @brief MDMA channel 21 error status register
\ Address offset: 0x588
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C21ESR_TEA                             \ TEA
$00000080 constant MDMA_MDMA_C21ESR_TED                             \ TED
$00000100 constant MDMA_MDMA_C21ESR_TELD                            \ TELD
$00000200 constant MDMA_MDMA_C21ESR_TEMD                            \ TEMD
$00000400 constant MDMA_MDMA_C21ESR_ASE                             \ ASE
$00000800 constant MDMA_MDMA_C21ESR_BSE                             \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x58C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C21CR_EN                               \ EN
$00000002 constant MDMA_MDMA_C21CR_TEIE                             \ TEIE
$00000004 constant MDMA_MDMA_C21CR_CTCIE                            \ CTCIE
$00000008 constant MDMA_MDMA_C21CR_BRTIE                            \ BRTIE
$00000010 constant MDMA_MDMA_C21CR_BTIE                             \ BTIE
$00000020 constant MDMA_MDMA_C21CR_TCIE                             \ TCIE
$000000c0 constant MDMA_MDMA_C21CR_PL                               \ PL
$00001000 constant MDMA_MDMA_C21CR_BEX                              \ BEX
$00002000 constant MDMA_MDMA_C21CR_HEX                              \ HEX
$00004000 constant MDMA_MDMA_C21CR_WEX                              \ WEX
$00010000 constant MDMA_MDMA_C21CR_SWRQ                             \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x590
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C21TCR_SINC                            \ SINC
$0000000c constant MDMA_MDMA_C21TCR_DINC                            \ DINC
$00000030 constant MDMA_MDMA_C21TCR_SSIZE                           \ SSIZE
$000000c0 constant MDMA_MDMA_C21TCR_DSIZE                           \ DSIZE
$00000300 constant MDMA_MDMA_C21TCR_SINCOS                          \ SINCOS
$00000c00 constant MDMA_MDMA_C21TCR_DINCOS                          \ DINCOS
$00007000 constant MDMA_MDMA_C21TCR_SBURST                          \ SBURST
$00038000 constant MDMA_MDMA_C21TCR_DBURST                          \ DBURST
$01fc0000 constant MDMA_MDMA_C21TCR_TLEN                            \ TLEN
$02000000 constant MDMA_MDMA_C21TCR_PKE                             \ PKE
$0c000000 constant MDMA_MDMA_C21TCR_PAM                             \ PAM
$30000000 constant MDMA_MDMA_C21TCR_TRGM                            \ TRGM
$40000000 constant MDMA_MDMA_C21TCR_SWRM                            \ SWRM
$80000000 constant MDMA_MDMA_C21TCR_BWM                             \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x594
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C21BNDTR_BNDT                          \ BNDT
$00040000 constant MDMA_MDMA_C21BNDTR_BRSUM                         \ BRSUM
$00080000 constant MDMA_MDMA_C21BNDTR_BRDUM                         \ BRDUM
$fff00000 constant MDMA_MDMA_C21BNDTR_BRC                           \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x598
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C21SAR_SAR                             \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x59C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C21DAR_DAR                             \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x5A0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C21BRUR_SUV                            \ SUV
$ffff0000 constant MDMA_MDMA_C21BRUR_DUV                            \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x5A4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C21LAR_LAR                             \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x5A8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C21TBR_TSEL                            \ TSEL
$00010000 constant MDMA_MDMA_C21TBR_SBUS                            \ SBUS
$00020000 constant MDMA_MDMA_C21TBR_DBUS                            \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x5B0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C21MAR_MAR                             \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x5B4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C21MDR_MDR                             \ MDR


\
\ @brief MDMA channel 22 interrupt/status register
\ Address offset: 0x5C0
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C22ISR_TEIF                            \ TEIF
$00000002 constant MDMA_MDMA_C22ISR_CTCIF                           \ CTCIF
$00000004 constant MDMA_MDMA_C22ISR_BRTIF                           \ BRTIF
$00000008 constant MDMA_MDMA_C22ISR_BTIF                            \ BTIF
$00000010 constant MDMA_MDMA_C22ISR_TCIF                            \ TCIF
$00010000 constant MDMA_MDMA_C22ISR_CRQA                            \ CRQA


\
\ @brief MDMA channel 22 interrupt flag clear register
\ Address offset: 0x5C4
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C22IFCR_CTEIF                          \ CTEIF
$00000002 constant MDMA_MDMA_C22IFCR_CCTCIF                         \ CCTCIF
$00000004 constant MDMA_MDMA_C22IFCR_CBRTIF                         \ CBRTIF
$00000008 constant MDMA_MDMA_C22IFCR_CBTIF                          \ CBTIF
$00000010 constant MDMA_MDMA_C22IFCR_CLTCIF                         \ CLTCIF


\
\ @brief MDMA channel 22 error status register
\ Address offset: 0x5C8
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C22ESR_TEA                             \ TEA
$00000080 constant MDMA_MDMA_C22ESR_TED                             \ TED
$00000100 constant MDMA_MDMA_C22ESR_TELD                            \ TELD
$00000200 constant MDMA_MDMA_C22ESR_TEMD                            \ TEMD
$00000400 constant MDMA_MDMA_C22ESR_ASE                             \ ASE
$00000800 constant MDMA_MDMA_C22ESR_BSE                             \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x5CC
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C22CR_EN                               \ EN
$00000002 constant MDMA_MDMA_C22CR_TEIE                             \ TEIE
$00000004 constant MDMA_MDMA_C22CR_CTCIE                            \ CTCIE
$00000008 constant MDMA_MDMA_C22CR_BRTIE                            \ BRTIE
$00000010 constant MDMA_MDMA_C22CR_BTIE                             \ BTIE
$00000020 constant MDMA_MDMA_C22CR_TCIE                             \ TCIE
$000000c0 constant MDMA_MDMA_C22CR_PL                               \ PL
$00001000 constant MDMA_MDMA_C22CR_BEX                              \ BEX
$00002000 constant MDMA_MDMA_C22CR_HEX                              \ HEX
$00004000 constant MDMA_MDMA_C22CR_WEX                              \ WEX
$00010000 constant MDMA_MDMA_C22CR_SWRQ                             \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x5D0
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C22TCR_SINC                            \ SINC
$0000000c constant MDMA_MDMA_C22TCR_DINC                            \ DINC
$00000030 constant MDMA_MDMA_C22TCR_SSIZE                           \ SSIZE
$000000c0 constant MDMA_MDMA_C22TCR_DSIZE                           \ DSIZE
$00000300 constant MDMA_MDMA_C22TCR_SINCOS                          \ SINCOS
$00000c00 constant MDMA_MDMA_C22TCR_DINCOS                          \ DINCOS
$00007000 constant MDMA_MDMA_C22TCR_SBURST                          \ SBURST
$00038000 constant MDMA_MDMA_C22TCR_DBURST                          \ DBURST
$01fc0000 constant MDMA_MDMA_C22TCR_TLEN                            \ TLEN
$02000000 constant MDMA_MDMA_C22TCR_PKE                             \ PKE
$0c000000 constant MDMA_MDMA_C22TCR_PAM                             \ PAM
$30000000 constant MDMA_MDMA_C22TCR_TRGM                            \ TRGM
$40000000 constant MDMA_MDMA_C22TCR_SWRM                            \ SWRM
$80000000 constant MDMA_MDMA_C22TCR_BWM                             \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x5D4
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C22BNDTR_BNDT                          \ BNDT
$00040000 constant MDMA_MDMA_C22BNDTR_BRSUM                         \ BRSUM
$00080000 constant MDMA_MDMA_C22BNDTR_BRDUM                         \ BRDUM
$fff00000 constant MDMA_MDMA_C22BNDTR_BRC                           \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x5D8
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C22SAR_SAR                             \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x5DC
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C22DAR_DAR                             \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x5E0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C22BRUR_SUV                            \ SUV
$ffff0000 constant MDMA_MDMA_C22BRUR_DUV                            \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x5E4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C22LAR_LAR                             \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x5E8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C22TBR_TSEL                            \ TSEL
$00010000 constant MDMA_MDMA_C22TBR_SBUS                            \ SBUS
$00020000 constant MDMA_MDMA_C22TBR_DBUS                            \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x5F0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C22MAR_MAR                             \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x5F4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C22MDR_MDR                             \ MDR


\
\ @brief MDMA channel 23 interrupt/status register
\ Address offset: 0x600
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C23ISR_TEIF                            \ TEIF
$00000002 constant MDMA_MDMA_C23ISR_CTCIF                           \ CTCIF
$00000004 constant MDMA_MDMA_C23ISR_BRTIF                           \ BRTIF
$00000008 constant MDMA_MDMA_C23ISR_BTIF                            \ BTIF
$00000010 constant MDMA_MDMA_C23ISR_TCIF                            \ TCIF
$00010000 constant MDMA_MDMA_C23ISR_CRQA                            \ CRQA


\
\ @brief MDMA channel 23 interrupt flag clear register
\ Address offset: 0x604
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C23IFCR_CTEIF                          \ CTEIF
$00000002 constant MDMA_MDMA_C23IFCR_CCTCIF                         \ CCTCIF
$00000004 constant MDMA_MDMA_C23IFCR_CBRTIF                         \ CBRTIF
$00000008 constant MDMA_MDMA_C23IFCR_CBTIF                          \ CBTIF
$00000010 constant MDMA_MDMA_C23IFCR_CLTCIF                         \ CLTCIF


\
\ @brief MDMA channel 23 error status register
\ Address offset: 0x608
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C23ESR_TEA                             \ TEA
$00000080 constant MDMA_MDMA_C23ESR_TED                             \ TED
$00000100 constant MDMA_MDMA_C23ESR_TELD                            \ TELD
$00000200 constant MDMA_MDMA_C23ESR_TEMD                            \ TEMD
$00000400 constant MDMA_MDMA_C23ESR_ASE                             \ ASE
$00000800 constant MDMA_MDMA_C23ESR_BSE                             \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x60C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C23CR_EN                               \ EN
$00000002 constant MDMA_MDMA_C23CR_TEIE                             \ TEIE
$00000004 constant MDMA_MDMA_C23CR_CTCIE                            \ CTCIE
$00000008 constant MDMA_MDMA_C23CR_BRTIE                            \ BRTIE
$00000010 constant MDMA_MDMA_C23CR_BTIE                             \ BTIE
$00000020 constant MDMA_MDMA_C23CR_TCIE                             \ TCIE
$000000c0 constant MDMA_MDMA_C23CR_PL                               \ PL
$00001000 constant MDMA_MDMA_C23CR_BEX                              \ BEX
$00002000 constant MDMA_MDMA_C23CR_HEX                              \ HEX
$00004000 constant MDMA_MDMA_C23CR_WEX                              \ WEX
$00010000 constant MDMA_MDMA_C23CR_SWRQ                             \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x610
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C23TCR_SINC                            \ SINC
$0000000c constant MDMA_MDMA_C23TCR_DINC                            \ DINC
$00000030 constant MDMA_MDMA_C23TCR_SSIZE                           \ SSIZE
$000000c0 constant MDMA_MDMA_C23TCR_DSIZE                           \ DSIZE
$00000300 constant MDMA_MDMA_C23TCR_SINCOS                          \ SINCOS
$00000c00 constant MDMA_MDMA_C23TCR_DINCOS                          \ DINCOS
$00007000 constant MDMA_MDMA_C23TCR_SBURST                          \ SBURST
$00038000 constant MDMA_MDMA_C23TCR_DBURST                          \ DBURST
$01fc0000 constant MDMA_MDMA_C23TCR_TLEN                            \ TLEN
$02000000 constant MDMA_MDMA_C23TCR_PKE                             \ PKE
$0c000000 constant MDMA_MDMA_C23TCR_PAM                             \ PAM
$30000000 constant MDMA_MDMA_C23TCR_TRGM                            \ TRGM
$40000000 constant MDMA_MDMA_C23TCR_SWRM                            \ SWRM
$80000000 constant MDMA_MDMA_C23TCR_BWM                             \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x614
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C23BNDTR_BNDT                          \ BNDT
$00040000 constant MDMA_MDMA_C23BNDTR_BRSUM                         \ BRSUM
$00080000 constant MDMA_MDMA_C23BNDTR_BRDUM                         \ BRDUM
$fff00000 constant MDMA_MDMA_C23BNDTR_BRC                           \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x618
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C23SAR_SAR                             \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x61C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C23DAR_DAR                             \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x620
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C23BRUR_SUV                            \ SUV
$ffff0000 constant MDMA_MDMA_C23BRUR_DUV                            \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x624
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C23LAR_LAR                             \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x628
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C23TBR_TSEL                            \ TSEL
$00010000 constant MDMA_MDMA_C23TBR_SBUS                            \ SBUS
$00020000 constant MDMA_MDMA_C23TBR_DBUS                            \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x630
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C23MAR_MAR                             \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x634
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C23MDR_MDR                             \ MDR


\
\ @brief MDMA channel 24 interrupt/status register
\ Address offset: 0x640
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C24ISR_TEIF                            \ TEIF
$00000002 constant MDMA_MDMA_C24ISR_CTCIF                           \ CTCIF
$00000004 constant MDMA_MDMA_C24ISR_BRTIF                           \ BRTIF
$00000008 constant MDMA_MDMA_C24ISR_BTIF                            \ BTIF
$00000010 constant MDMA_MDMA_C24ISR_TCIF                            \ TCIF
$00010000 constant MDMA_MDMA_C24ISR_CRQA                            \ CRQA


\
\ @brief MDMA channel 24 interrupt flag clear register
\ Address offset: 0x644
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C24IFCR_CTEIF                          \ CTEIF
$00000002 constant MDMA_MDMA_C24IFCR_CCTCIF                         \ CCTCIF
$00000004 constant MDMA_MDMA_C24IFCR_CBRTIF                         \ CBRTIF
$00000008 constant MDMA_MDMA_C24IFCR_CBTIF                          \ CBTIF
$00000010 constant MDMA_MDMA_C24IFCR_CLTCIF                         \ CLTCIF


\
\ @brief MDMA channel 24 error status register
\ Address offset: 0x648
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C24ESR_TEA                             \ TEA
$00000080 constant MDMA_MDMA_C24ESR_TED                             \ TED
$00000100 constant MDMA_MDMA_C24ESR_TELD                            \ TELD
$00000200 constant MDMA_MDMA_C24ESR_TEMD                            \ TEMD
$00000400 constant MDMA_MDMA_C24ESR_ASE                             \ ASE
$00000800 constant MDMA_MDMA_C24ESR_BSE                             \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x64C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C24CR_EN                               \ EN
$00000002 constant MDMA_MDMA_C24CR_TEIE                             \ TEIE
$00000004 constant MDMA_MDMA_C24CR_CTCIE                            \ CTCIE
$00000008 constant MDMA_MDMA_C24CR_BRTIE                            \ BRTIE
$00000010 constant MDMA_MDMA_C24CR_BTIE                             \ BTIE
$00000020 constant MDMA_MDMA_C24CR_TCIE                             \ TCIE
$000000c0 constant MDMA_MDMA_C24CR_PL                               \ PL
$00001000 constant MDMA_MDMA_C24CR_BEX                              \ BEX
$00002000 constant MDMA_MDMA_C24CR_HEX                              \ HEX
$00004000 constant MDMA_MDMA_C24CR_WEX                              \ WEX
$00010000 constant MDMA_MDMA_C24CR_SWRQ                             \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x650
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C24TCR_SINC                            \ SINC
$0000000c constant MDMA_MDMA_C24TCR_DINC                            \ DINC
$00000030 constant MDMA_MDMA_C24TCR_SSIZE                           \ SSIZE
$000000c0 constant MDMA_MDMA_C24TCR_DSIZE                           \ DSIZE
$00000300 constant MDMA_MDMA_C24TCR_SINCOS                          \ SINCOS
$00000c00 constant MDMA_MDMA_C24TCR_DINCOS                          \ DINCOS
$00007000 constant MDMA_MDMA_C24TCR_SBURST                          \ SBURST
$00038000 constant MDMA_MDMA_C24TCR_DBURST                          \ DBURST
$01fc0000 constant MDMA_MDMA_C24TCR_TLEN                            \ TLEN
$02000000 constant MDMA_MDMA_C24TCR_PKE                             \ PKE
$0c000000 constant MDMA_MDMA_C24TCR_PAM                             \ PAM
$30000000 constant MDMA_MDMA_C24TCR_TRGM                            \ TRGM
$40000000 constant MDMA_MDMA_C24TCR_SWRM                            \ SWRM
$80000000 constant MDMA_MDMA_C24TCR_BWM                             \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x654
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C24BNDTR_BNDT                          \ BNDT
$00040000 constant MDMA_MDMA_C24BNDTR_BRSUM                         \ BRSUM
$00080000 constant MDMA_MDMA_C24BNDTR_BRDUM                         \ BRDUM
$fff00000 constant MDMA_MDMA_C24BNDTR_BRC                           \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x658
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C24SAR_SAR                             \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x65C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C24DAR_DAR                             \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x660
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C24BRUR_SUV                            \ SUV
$ffff0000 constant MDMA_MDMA_C24BRUR_DUV                            \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x664
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C24LAR_LAR                             \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x668
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C24TBR_TSEL                            \ TSEL
$00010000 constant MDMA_MDMA_C24TBR_SBUS                            \ SBUS
$00020000 constant MDMA_MDMA_C24TBR_DBUS                            \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x670
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C24MAR_MAR                             \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x674
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C24MDR_MDR                             \ MDR


\
\ @brief MDMA channel 25 interrupt/status register
\ Address offset: 0x680
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C25ISR_TEIF                            \ TEIF
$00000002 constant MDMA_MDMA_C25ISR_CTCIF                           \ CTCIF
$00000004 constant MDMA_MDMA_C25ISR_BRTIF                           \ BRTIF
$00000008 constant MDMA_MDMA_C25ISR_BTIF                            \ BTIF
$00000010 constant MDMA_MDMA_C25ISR_TCIF                            \ TCIF
$00010000 constant MDMA_MDMA_C25ISR_CRQA                            \ CRQA


\
\ @brief MDMA channel 25 interrupt flag clear register
\ Address offset: 0x684
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C25IFCR_CTEIF                          \ CTEIF
$00000002 constant MDMA_MDMA_C25IFCR_CCTCIF                         \ CCTCIF
$00000004 constant MDMA_MDMA_C25IFCR_CBRTIF                         \ CBRTIF
$00000008 constant MDMA_MDMA_C25IFCR_CBTIF                          \ CBTIF
$00000010 constant MDMA_MDMA_C25IFCR_CLTCIF                         \ CLTCIF


\
\ @brief MDMA channel 25 error status register
\ Address offset: 0x688
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C25ESR_TEA                             \ TEA
$00000080 constant MDMA_MDMA_C25ESR_TED                             \ TED
$00000100 constant MDMA_MDMA_C25ESR_TELD                            \ TELD
$00000200 constant MDMA_MDMA_C25ESR_TEMD                            \ TEMD
$00000400 constant MDMA_MDMA_C25ESR_ASE                             \ ASE
$00000800 constant MDMA_MDMA_C25ESR_BSE                             \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x68C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C25CR_EN                               \ EN
$00000002 constant MDMA_MDMA_C25CR_TEIE                             \ TEIE
$00000004 constant MDMA_MDMA_C25CR_CTCIE                            \ CTCIE
$00000008 constant MDMA_MDMA_C25CR_BRTIE                            \ BRTIE
$00000010 constant MDMA_MDMA_C25CR_BTIE                             \ BTIE
$00000020 constant MDMA_MDMA_C25CR_TCIE                             \ TCIE
$000000c0 constant MDMA_MDMA_C25CR_PL                               \ PL
$00001000 constant MDMA_MDMA_C25CR_BEX                              \ BEX
$00002000 constant MDMA_MDMA_C25CR_HEX                              \ HEX
$00004000 constant MDMA_MDMA_C25CR_WEX                              \ WEX
$00010000 constant MDMA_MDMA_C25CR_SWRQ                             \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x690
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C25TCR_SINC                            \ SINC
$0000000c constant MDMA_MDMA_C25TCR_DINC                            \ DINC
$00000030 constant MDMA_MDMA_C25TCR_SSIZE                           \ SSIZE
$000000c0 constant MDMA_MDMA_C25TCR_DSIZE                           \ DSIZE
$00000300 constant MDMA_MDMA_C25TCR_SINCOS                          \ SINCOS
$00000c00 constant MDMA_MDMA_C25TCR_DINCOS                          \ DINCOS
$00007000 constant MDMA_MDMA_C25TCR_SBURST                          \ SBURST
$00038000 constant MDMA_MDMA_C25TCR_DBURST                          \ DBURST
$01fc0000 constant MDMA_MDMA_C25TCR_TLEN                            \ TLEN
$02000000 constant MDMA_MDMA_C25TCR_PKE                             \ PKE
$0c000000 constant MDMA_MDMA_C25TCR_PAM                             \ PAM
$30000000 constant MDMA_MDMA_C25TCR_TRGM                            \ TRGM
$40000000 constant MDMA_MDMA_C25TCR_SWRM                            \ SWRM
$80000000 constant MDMA_MDMA_C25TCR_BWM                             \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x694
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C25BNDTR_BNDT                          \ BNDT
$00040000 constant MDMA_MDMA_C25BNDTR_BRSUM                         \ BRSUM
$00080000 constant MDMA_MDMA_C25BNDTR_BRDUM                         \ BRDUM
$fff00000 constant MDMA_MDMA_C25BNDTR_BRC                           \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x698
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C25SAR_SAR                             \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x69C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C25DAR_DAR                             \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x6A0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C25BRUR_SUV                            \ SUV
$ffff0000 constant MDMA_MDMA_C25BRUR_DUV                            \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x6A4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C25LAR_LAR                             \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x6A8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C25TBR_TSEL                            \ TSEL
$00010000 constant MDMA_MDMA_C25TBR_SBUS                            \ SBUS
$00020000 constant MDMA_MDMA_C25TBR_DBUS                            \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x6B0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C25MAR_MAR                             \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x6B4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C25MDR_MDR                             \ MDR


\
\ @brief MDMA channel 26 interrupt/status register
\ Address offset: 0x6C0
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C26ISR_TEIF                            \ TEIF
$00000002 constant MDMA_MDMA_C26ISR_CTCIF                           \ CTCIF
$00000004 constant MDMA_MDMA_C26ISR_BRTIF                           \ BRTIF
$00000008 constant MDMA_MDMA_C26ISR_BTIF                            \ BTIF
$00000010 constant MDMA_MDMA_C26ISR_TCIF                            \ TCIF
$00010000 constant MDMA_MDMA_C26ISR_CRQA                            \ CRQA


\
\ @brief MDMA channel 26 interrupt flag clear register
\ Address offset: 0x6C4
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C26IFCR_CTEIF                          \ CTEIF
$00000002 constant MDMA_MDMA_C26IFCR_CCTCIF                         \ CCTCIF
$00000004 constant MDMA_MDMA_C26IFCR_CBRTIF                         \ CBRTIF
$00000008 constant MDMA_MDMA_C26IFCR_CBTIF                          \ CBTIF
$00000010 constant MDMA_MDMA_C26IFCR_CLTCIF                         \ CLTCIF


\
\ @brief MDMA channel 26 error status register
\ Address offset: 0x6C8
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C26ESR_TEA                             \ TEA
$00000080 constant MDMA_MDMA_C26ESR_TED                             \ TED
$00000100 constant MDMA_MDMA_C26ESR_TELD                            \ TELD
$00000200 constant MDMA_MDMA_C26ESR_TEMD                            \ TEMD
$00000400 constant MDMA_MDMA_C26ESR_ASE                             \ ASE
$00000800 constant MDMA_MDMA_C26ESR_BSE                             \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x6CC
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C26CR_EN                               \ EN
$00000002 constant MDMA_MDMA_C26CR_TEIE                             \ TEIE
$00000004 constant MDMA_MDMA_C26CR_CTCIE                            \ CTCIE
$00000008 constant MDMA_MDMA_C26CR_BRTIE                            \ BRTIE
$00000010 constant MDMA_MDMA_C26CR_BTIE                             \ BTIE
$00000020 constant MDMA_MDMA_C26CR_TCIE                             \ TCIE
$000000c0 constant MDMA_MDMA_C26CR_PL                               \ PL
$00001000 constant MDMA_MDMA_C26CR_BEX                              \ BEX
$00002000 constant MDMA_MDMA_C26CR_HEX                              \ HEX
$00004000 constant MDMA_MDMA_C26CR_WEX                              \ WEX
$00010000 constant MDMA_MDMA_C26CR_SWRQ                             \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x6D0
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C26TCR_SINC                            \ SINC
$0000000c constant MDMA_MDMA_C26TCR_DINC                            \ DINC
$00000030 constant MDMA_MDMA_C26TCR_SSIZE                           \ SSIZE
$000000c0 constant MDMA_MDMA_C26TCR_DSIZE                           \ DSIZE
$00000300 constant MDMA_MDMA_C26TCR_SINCOS                          \ SINCOS
$00000c00 constant MDMA_MDMA_C26TCR_DINCOS                          \ DINCOS
$00007000 constant MDMA_MDMA_C26TCR_SBURST                          \ SBURST
$00038000 constant MDMA_MDMA_C26TCR_DBURST                          \ DBURST
$01fc0000 constant MDMA_MDMA_C26TCR_TLEN                            \ TLEN
$02000000 constant MDMA_MDMA_C26TCR_PKE                             \ PKE
$0c000000 constant MDMA_MDMA_C26TCR_PAM                             \ PAM
$30000000 constant MDMA_MDMA_C26TCR_TRGM                            \ TRGM
$40000000 constant MDMA_MDMA_C26TCR_SWRM                            \ SWRM
$80000000 constant MDMA_MDMA_C26TCR_BWM                             \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x6D4
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C26BNDTR_BNDT                          \ BNDT
$00040000 constant MDMA_MDMA_C26BNDTR_BRSUM                         \ BRSUM
$00080000 constant MDMA_MDMA_C26BNDTR_BRDUM                         \ BRDUM
$fff00000 constant MDMA_MDMA_C26BNDTR_BRC                           \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x6D8
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C26SAR_SAR                             \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x6DC
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C26DAR_DAR                             \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x6E0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C26BRUR_SUV                            \ SUV
$ffff0000 constant MDMA_MDMA_C26BRUR_DUV                            \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x6E4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C26LAR_LAR                             \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x6E8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C26TBR_TSEL                            \ TSEL
$00010000 constant MDMA_MDMA_C26TBR_SBUS                            \ SBUS
$00020000 constant MDMA_MDMA_C26TBR_DBUS                            \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x6F0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C26MAR_MAR                             \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x6F4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C26MDR_MDR                             \ MDR


\
\ @brief MDMA channel 27 interrupt/status register
\ Address offset: 0x700
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C27ISR_TEIF                            \ TEIF
$00000002 constant MDMA_MDMA_C27ISR_CTCIF                           \ CTCIF
$00000004 constant MDMA_MDMA_C27ISR_BRTIF                           \ BRTIF
$00000008 constant MDMA_MDMA_C27ISR_BTIF                            \ BTIF
$00000010 constant MDMA_MDMA_C27ISR_TCIF                            \ TCIF
$00010000 constant MDMA_MDMA_C27ISR_CRQA                            \ CRQA


\
\ @brief MDMA channel 27 interrupt flag clear register
\ Address offset: 0x704
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C27IFCR_CTEIF                          \ CTEIF
$00000002 constant MDMA_MDMA_C27IFCR_CCTCIF                         \ CCTCIF
$00000004 constant MDMA_MDMA_C27IFCR_CBRTIF                         \ CBRTIF
$00000008 constant MDMA_MDMA_C27IFCR_CBTIF                          \ CBTIF
$00000010 constant MDMA_MDMA_C27IFCR_CLTCIF                         \ CLTCIF


\
\ @brief MDMA channel 27 error status register
\ Address offset: 0x708
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C27ESR_TEA                             \ TEA
$00000080 constant MDMA_MDMA_C27ESR_TED                             \ TED
$00000100 constant MDMA_MDMA_C27ESR_TELD                            \ TELD
$00000200 constant MDMA_MDMA_C27ESR_TEMD                            \ TEMD
$00000400 constant MDMA_MDMA_C27ESR_ASE                             \ ASE
$00000800 constant MDMA_MDMA_C27ESR_BSE                             \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x70C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C27CR_EN                               \ EN
$00000002 constant MDMA_MDMA_C27CR_TEIE                             \ TEIE
$00000004 constant MDMA_MDMA_C27CR_CTCIE                            \ CTCIE
$00000008 constant MDMA_MDMA_C27CR_BRTIE                            \ BRTIE
$00000010 constant MDMA_MDMA_C27CR_BTIE                             \ BTIE
$00000020 constant MDMA_MDMA_C27CR_TCIE                             \ TCIE
$000000c0 constant MDMA_MDMA_C27CR_PL                               \ PL
$00001000 constant MDMA_MDMA_C27CR_BEX                              \ BEX
$00002000 constant MDMA_MDMA_C27CR_HEX                              \ HEX
$00004000 constant MDMA_MDMA_C27CR_WEX                              \ WEX
$00010000 constant MDMA_MDMA_C27CR_SWRQ                             \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x710
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C27TCR_SINC                            \ SINC
$0000000c constant MDMA_MDMA_C27TCR_DINC                            \ DINC
$00000030 constant MDMA_MDMA_C27TCR_SSIZE                           \ SSIZE
$000000c0 constant MDMA_MDMA_C27TCR_DSIZE                           \ DSIZE
$00000300 constant MDMA_MDMA_C27TCR_SINCOS                          \ SINCOS
$00000c00 constant MDMA_MDMA_C27TCR_DINCOS                          \ DINCOS
$00007000 constant MDMA_MDMA_C27TCR_SBURST                          \ SBURST
$00038000 constant MDMA_MDMA_C27TCR_DBURST                          \ DBURST
$01fc0000 constant MDMA_MDMA_C27TCR_TLEN                            \ TLEN
$02000000 constant MDMA_MDMA_C27TCR_PKE                             \ PKE
$0c000000 constant MDMA_MDMA_C27TCR_PAM                             \ PAM
$30000000 constant MDMA_MDMA_C27TCR_TRGM                            \ TRGM
$40000000 constant MDMA_MDMA_C27TCR_SWRM                            \ SWRM
$80000000 constant MDMA_MDMA_C27TCR_BWM                             \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x714
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C27BNDTR_BNDT                          \ BNDT
$00040000 constant MDMA_MDMA_C27BNDTR_BRSUM                         \ BRSUM
$00080000 constant MDMA_MDMA_C27BNDTR_BRDUM                         \ BRDUM
$fff00000 constant MDMA_MDMA_C27BNDTR_BRC                           \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x718
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C27SAR_SAR                             \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x71C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C27DAR_DAR                             \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x720
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C27BRUR_SUV                            \ SUV
$ffff0000 constant MDMA_MDMA_C27BRUR_DUV                            \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x724
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C27LAR_LAR                             \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x728
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C27TBR_TSEL                            \ TSEL
$00010000 constant MDMA_MDMA_C27TBR_SBUS                            \ SBUS
$00020000 constant MDMA_MDMA_C27TBR_DBUS                            \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x730
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C27MAR_MAR                             \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x734
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C27MDR_MDR                             \ MDR


\
\ @brief MDMA channel 28 interrupt/status register
\ Address offset: 0x740
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C28ISR_TEIF                            \ TEIF
$00000002 constant MDMA_MDMA_C28ISR_CTCIF                           \ CTCIF
$00000004 constant MDMA_MDMA_C28ISR_BRTIF                           \ BRTIF
$00000008 constant MDMA_MDMA_C28ISR_BTIF                            \ BTIF
$00000010 constant MDMA_MDMA_C28ISR_TCIF                            \ TCIF
$00010000 constant MDMA_MDMA_C28ISR_CRQA                            \ CRQA


\
\ @brief MDMA channel 28 interrupt flag clear register
\ Address offset: 0x744
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C28IFCR_CTEIF                          \ CTEIF
$00000002 constant MDMA_MDMA_C28IFCR_CCTCIF                         \ CCTCIF
$00000004 constant MDMA_MDMA_C28IFCR_CBRTIF                         \ CBRTIF
$00000008 constant MDMA_MDMA_C28IFCR_CBTIF                          \ CBTIF
$00000010 constant MDMA_MDMA_C28IFCR_CLTCIF                         \ CLTCIF


\
\ @brief MDMA channel 28 error status register
\ Address offset: 0x748
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C28ESR_TEA                             \ TEA
$00000080 constant MDMA_MDMA_C28ESR_TED                             \ TED
$00000100 constant MDMA_MDMA_C28ESR_TELD                            \ TELD
$00000200 constant MDMA_MDMA_C28ESR_TEMD                            \ TEMD
$00000400 constant MDMA_MDMA_C28ESR_ASE                             \ ASE
$00000800 constant MDMA_MDMA_C28ESR_BSE                             \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x74C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C28CR_EN                               \ EN
$00000002 constant MDMA_MDMA_C28CR_TEIE                             \ TEIE
$00000004 constant MDMA_MDMA_C28CR_CTCIE                            \ CTCIE
$00000008 constant MDMA_MDMA_C28CR_BRTIE                            \ BRTIE
$00000010 constant MDMA_MDMA_C28CR_BTIE                             \ BTIE
$00000020 constant MDMA_MDMA_C28CR_TCIE                             \ TCIE
$000000c0 constant MDMA_MDMA_C28CR_PL                               \ PL
$00001000 constant MDMA_MDMA_C28CR_BEX                              \ BEX
$00002000 constant MDMA_MDMA_C28CR_HEX                              \ HEX
$00004000 constant MDMA_MDMA_C28CR_WEX                              \ WEX
$00010000 constant MDMA_MDMA_C28CR_SWRQ                             \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x750
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C28TCR_SINC                            \ SINC
$0000000c constant MDMA_MDMA_C28TCR_DINC                            \ DINC
$00000030 constant MDMA_MDMA_C28TCR_SSIZE                           \ SSIZE
$000000c0 constant MDMA_MDMA_C28TCR_DSIZE                           \ DSIZE
$00000300 constant MDMA_MDMA_C28TCR_SINCOS                          \ SINCOS
$00000c00 constant MDMA_MDMA_C28TCR_DINCOS                          \ DINCOS
$00007000 constant MDMA_MDMA_C28TCR_SBURST                          \ SBURST
$00038000 constant MDMA_MDMA_C28TCR_DBURST                          \ DBURST
$01fc0000 constant MDMA_MDMA_C28TCR_TLEN                            \ TLEN
$02000000 constant MDMA_MDMA_C28TCR_PKE                             \ PKE
$0c000000 constant MDMA_MDMA_C28TCR_PAM                             \ PAM
$30000000 constant MDMA_MDMA_C28TCR_TRGM                            \ TRGM
$40000000 constant MDMA_MDMA_C28TCR_SWRM                            \ SWRM
$80000000 constant MDMA_MDMA_C28TCR_BWM                             \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x754
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C28BNDTR_BNDT                          \ BNDT
$00040000 constant MDMA_MDMA_C28BNDTR_BRSUM                         \ BRSUM
$00080000 constant MDMA_MDMA_C28BNDTR_BRDUM                         \ BRDUM
$fff00000 constant MDMA_MDMA_C28BNDTR_BRC                           \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x758
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C28SAR_SAR                             \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x75C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C28DAR_DAR                             \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x760
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C28BRUR_SUV                            \ SUV
$ffff0000 constant MDMA_MDMA_C28BRUR_DUV                            \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x764
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C28LAR_LAR                             \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x768
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C28TBR_TSEL                            \ TSEL
$00010000 constant MDMA_MDMA_C28TBR_SBUS                            \ SBUS
$00020000 constant MDMA_MDMA_C28TBR_DBUS                            \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x770
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C28MAR_MAR                             \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x774
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C28MDR_MDR                             \ MDR


\
\ @brief MDMA channel 29 interrupt/status register
\ Address offset: 0x780
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C29ISR_TEIF                            \ TEIF
$00000002 constant MDMA_MDMA_C29ISR_CTCIF                           \ CTCIF
$00000004 constant MDMA_MDMA_C29ISR_BRTIF                           \ BRTIF
$00000008 constant MDMA_MDMA_C29ISR_BTIF                            \ BTIF
$00000010 constant MDMA_MDMA_C29ISR_TCIF                            \ TCIF
$00010000 constant MDMA_MDMA_C29ISR_CRQA                            \ CRQA


\
\ @brief MDMA channel 29 interrupt flag clear register
\ Address offset: 0x784
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C29IFCR_CTEIF                          \ CTEIF
$00000002 constant MDMA_MDMA_C29IFCR_CCTCIF                         \ CCTCIF
$00000004 constant MDMA_MDMA_C29IFCR_CBRTIF                         \ CBRTIF
$00000008 constant MDMA_MDMA_C29IFCR_CBTIF                          \ CBTIF
$00000010 constant MDMA_MDMA_C29IFCR_CLTCIF                         \ CLTCIF


\
\ @brief MDMA channel 29 error status register
\ Address offset: 0x788
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C29ESR_TEA                             \ TEA
$00000080 constant MDMA_MDMA_C29ESR_TED                             \ TED
$00000100 constant MDMA_MDMA_C29ESR_TELD                            \ TELD
$00000200 constant MDMA_MDMA_C29ESR_TEMD                            \ TEMD
$00000400 constant MDMA_MDMA_C29ESR_ASE                             \ ASE
$00000800 constant MDMA_MDMA_C29ESR_BSE                             \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x78C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C29CR_EN                               \ EN
$00000002 constant MDMA_MDMA_C29CR_TEIE                             \ TEIE
$00000004 constant MDMA_MDMA_C29CR_CTCIE                            \ CTCIE
$00000008 constant MDMA_MDMA_C29CR_BRTIE                            \ BRTIE
$00000010 constant MDMA_MDMA_C29CR_BTIE                             \ BTIE
$00000020 constant MDMA_MDMA_C29CR_TCIE                             \ TCIE
$000000c0 constant MDMA_MDMA_C29CR_PL                               \ PL
$00001000 constant MDMA_MDMA_C29CR_BEX                              \ BEX
$00002000 constant MDMA_MDMA_C29CR_HEX                              \ HEX
$00004000 constant MDMA_MDMA_C29CR_WEX                              \ WEX
$00010000 constant MDMA_MDMA_C29CR_SWRQ                             \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x790
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C29TCR_SINC                            \ SINC
$0000000c constant MDMA_MDMA_C29TCR_DINC                            \ DINC
$00000030 constant MDMA_MDMA_C29TCR_SSIZE                           \ SSIZE
$000000c0 constant MDMA_MDMA_C29TCR_DSIZE                           \ DSIZE
$00000300 constant MDMA_MDMA_C29TCR_SINCOS                          \ SINCOS
$00000c00 constant MDMA_MDMA_C29TCR_DINCOS                          \ DINCOS
$00007000 constant MDMA_MDMA_C29TCR_SBURST                          \ SBURST
$00038000 constant MDMA_MDMA_C29TCR_DBURST                          \ DBURST
$01fc0000 constant MDMA_MDMA_C29TCR_TLEN                            \ TLEN
$02000000 constant MDMA_MDMA_C29TCR_PKE                             \ PKE
$0c000000 constant MDMA_MDMA_C29TCR_PAM                             \ PAM
$30000000 constant MDMA_MDMA_C29TCR_TRGM                            \ TRGM
$40000000 constant MDMA_MDMA_C29TCR_SWRM                            \ SWRM
$80000000 constant MDMA_MDMA_C29TCR_BWM                             \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x794
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C29BNDTR_BNDT                          \ BNDT
$00040000 constant MDMA_MDMA_C29BNDTR_BRSUM                         \ BRSUM
$00080000 constant MDMA_MDMA_C29BNDTR_BRDUM                         \ BRDUM
$fff00000 constant MDMA_MDMA_C29BNDTR_BRC                           \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x798
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C29SAR_SAR                             \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x79C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C29DAR_DAR                             \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x7A0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C29BRUR_SUV                            \ SUV
$ffff0000 constant MDMA_MDMA_C29BRUR_DUV                            \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x7A4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C29LAR_LAR                             \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x7A8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C29TBR_TSEL                            \ TSEL
$00010000 constant MDMA_MDMA_C29TBR_SBUS                            \ SBUS
$00020000 constant MDMA_MDMA_C29TBR_DBUS                            \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x7B0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C29MAR_MAR                             \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x7B4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C29MDR_MDR                             \ MDR


\
\ @brief MDMA channel 30 interrupt/status register
\ Address offset: 0x7C0
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C30ISR_TEIF                            \ TEIF
$00000002 constant MDMA_MDMA_C30ISR_CTCIF                           \ CTCIF
$00000004 constant MDMA_MDMA_C30ISR_BRTIF                           \ BRTIF
$00000008 constant MDMA_MDMA_C30ISR_BTIF                            \ BTIF
$00000010 constant MDMA_MDMA_C30ISR_TCIF                            \ TCIF
$00010000 constant MDMA_MDMA_C30ISR_CRQA                            \ CRQA


\
\ @brief MDMA channel 30 interrupt flag clear register
\ Address offset: 0x7C4
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C30IFCR_CTEIF                          \ CTEIF
$00000002 constant MDMA_MDMA_C30IFCR_CCTCIF                         \ CCTCIF
$00000004 constant MDMA_MDMA_C30IFCR_CBRTIF                         \ CBRTIF
$00000008 constant MDMA_MDMA_C30IFCR_CBTIF                          \ CBTIF
$00000010 constant MDMA_MDMA_C30IFCR_CLTCIF                         \ CLTCIF


\
\ @brief MDMA channel 30 error status register
\ Address offset: 0x7C8
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C30ESR_TEA                             \ TEA
$00000080 constant MDMA_MDMA_C30ESR_TED                             \ TED
$00000100 constant MDMA_MDMA_C30ESR_TELD                            \ TELD
$00000200 constant MDMA_MDMA_C30ESR_TEMD                            \ TEMD
$00000400 constant MDMA_MDMA_C30ESR_ASE                             \ ASE
$00000800 constant MDMA_MDMA_C30ESR_BSE                             \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x7CC
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C30CR_EN                               \ EN
$00000002 constant MDMA_MDMA_C30CR_TEIE                             \ TEIE
$00000004 constant MDMA_MDMA_C30CR_CTCIE                            \ CTCIE
$00000008 constant MDMA_MDMA_C30CR_BRTIE                            \ BRTIE
$00000010 constant MDMA_MDMA_C30CR_BTIE                             \ BTIE
$00000020 constant MDMA_MDMA_C30CR_TCIE                             \ TCIE
$000000c0 constant MDMA_MDMA_C30CR_PL                               \ PL
$00001000 constant MDMA_MDMA_C30CR_BEX                              \ BEX
$00002000 constant MDMA_MDMA_C30CR_HEX                              \ HEX
$00004000 constant MDMA_MDMA_C30CR_WEX                              \ WEX
$00010000 constant MDMA_MDMA_C30CR_SWRQ                             \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x7D0
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C30TCR_SINC                            \ SINC
$0000000c constant MDMA_MDMA_C30TCR_DINC                            \ DINC
$00000030 constant MDMA_MDMA_C30TCR_SSIZE                           \ SSIZE
$000000c0 constant MDMA_MDMA_C30TCR_DSIZE                           \ DSIZE
$00000300 constant MDMA_MDMA_C30TCR_SINCOS                          \ SINCOS
$00000c00 constant MDMA_MDMA_C30TCR_DINCOS                          \ DINCOS
$00007000 constant MDMA_MDMA_C30TCR_SBURST                          \ SBURST
$00038000 constant MDMA_MDMA_C30TCR_DBURST                          \ DBURST
$01fc0000 constant MDMA_MDMA_C30TCR_TLEN                            \ TLEN
$02000000 constant MDMA_MDMA_C30TCR_PKE                             \ PKE
$0c000000 constant MDMA_MDMA_C30TCR_PAM                             \ PAM
$30000000 constant MDMA_MDMA_C30TCR_TRGM                            \ TRGM
$40000000 constant MDMA_MDMA_C30TCR_SWRM                            \ SWRM
$80000000 constant MDMA_MDMA_C30TCR_BWM                             \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x7D4
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C30BNDTR_BNDT                          \ BNDT
$00040000 constant MDMA_MDMA_C30BNDTR_BRSUM                         \ BRSUM
$00080000 constant MDMA_MDMA_C30BNDTR_BRDUM                         \ BRDUM
$fff00000 constant MDMA_MDMA_C30BNDTR_BRC                           \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x7D8
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C30SAR_SAR                             \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x7DC
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C30DAR_DAR                             \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x7E0
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C30BRUR_SUV                            \ SUV
$ffff0000 constant MDMA_MDMA_C30BRUR_DUV                            \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x7E4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C30LAR_LAR                             \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x7E8
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C30TBR_TSEL                            \ TSEL
$00010000 constant MDMA_MDMA_C30TBR_SBUS                            \ SBUS
$00020000 constant MDMA_MDMA_C30TBR_DBUS                            \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x7F0
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C30MAR_MAR                             \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x7F4
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C30MDR_MDR                             \ MDR


\
\ @brief MDMA channel 31 interrupt/status register
\ Address offset: 0x800
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C31ISR_TEIF                            \ TEIF
$00000002 constant MDMA_MDMA_C31ISR_CTCIF                           \ CTCIF
$00000004 constant MDMA_MDMA_C31ISR_BRTIF                           \ BRTIF
$00000008 constant MDMA_MDMA_C31ISR_BTIF                            \ BTIF
$00000010 constant MDMA_MDMA_C31ISR_TCIF                            \ TCIF
$00010000 constant MDMA_MDMA_C31ISR_CRQA                            \ CRQA


\
\ @brief MDMA channel 31 interrupt flag clear register
\ Address offset: 0x804
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C31IFCR_CTEIF                          \ CTEIF
$00000002 constant MDMA_MDMA_C31IFCR_CCTCIF                         \ CCTCIF
$00000004 constant MDMA_MDMA_C31IFCR_CBRTIF                         \ CBRTIF
$00000008 constant MDMA_MDMA_C31IFCR_CBTIF                          \ CBTIF
$00000010 constant MDMA_MDMA_C31IFCR_CLTCIF                         \ CLTCIF


\
\ @brief MDMA channel 31 error status register
\ Address offset: 0x808
\ Reset value: 0x00000000
\

$0000007f constant MDMA_MDMA_C31ESR_TEA                             \ TEA
$00000080 constant MDMA_MDMA_C31ESR_TED                             \ TED
$00000100 constant MDMA_MDMA_C31ESR_TELD                            \ TELD
$00000200 constant MDMA_MDMA_C31ESR_TEMD                            \ TEMD
$00000400 constant MDMA_MDMA_C31ESR_ASE                             \ ASE
$00000800 constant MDMA_MDMA_C31ESR_BSE                             \ BSE


\
\ @brief This register is used to control the concerned channel.
\ Address offset: 0x80C
\ Reset value: 0x00000000
\

$00000001 constant MDMA_MDMA_C31CR_EN                               \ EN
$00000002 constant MDMA_MDMA_C31CR_TEIE                             \ TEIE
$00000004 constant MDMA_MDMA_C31CR_CTCIE                            \ CTCIE
$00000008 constant MDMA_MDMA_C31CR_BRTIE                            \ BRTIE
$00000010 constant MDMA_MDMA_C31CR_BTIE                             \ BTIE
$00000020 constant MDMA_MDMA_C31CR_TCIE                             \ TCIE
$000000c0 constant MDMA_MDMA_C31CR_PL                               \ PL
$00001000 constant MDMA_MDMA_C31CR_BEX                              \ BEX
$00002000 constant MDMA_MDMA_C31CR_HEX                              \ HEX
$00004000 constant MDMA_MDMA_C31CR_WEX                              \ WEX
$00010000 constant MDMA_MDMA_C31CR_SWRQ                             \ SWRQ


\
\ @brief This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
\ Address offset: 0x810
\ Reset value: 0x00000000
\

$00000003 constant MDMA_MDMA_C31TCR_SINC                            \ SINC
$0000000c constant MDMA_MDMA_C31TCR_DINC                            \ DINC
$00000030 constant MDMA_MDMA_C31TCR_SSIZE                           \ SSIZE
$000000c0 constant MDMA_MDMA_C31TCR_DSIZE                           \ DSIZE
$00000300 constant MDMA_MDMA_C31TCR_SINCOS                          \ SINCOS
$00000c00 constant MDMA_MDMA_C31TCR_DINCOS                          \ DINCOS
$00007000 constant MDMA_MDMA_C31TCR_SBURST                          \ SBURST
$00038000 constant MDMA_MDMA_C31TCR_DBURST                          \ DBURST
$01fc0000 constant MDMA_MDMA_C31TCR_TLEN                            \ TLEN
$02000000 constant MDMA_MDMA_C31TCR_PKE                             \ PKE
$0c000000 constant MDMA_MDMA_C31TCR_PAM                             \ PAM
$30000000 constant MDMA_MDMA_C31TCR_TRGM                            \ TRGM
$40000000 constant MDMA_MDMA_C31TCR_SWRM                            \ SWRM
$80000000 constant MDMA_MDMA_C31TCR_BWM                             \ BWM


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
\ Address offset: 0x814
\ Reset value: 0x00000000
\

$0001ffff constant MDMA_MDMA_C31BNDTR_BNDT                          \ BNDT
$00040000 constant MDMA_MDMA_C31BNDTR_BRSUM                         \ BRSUM
$00080000 constant MDMA_MDMA_C31BNDTR_BRDUM                         \ BRDUM
$fff00000 constant MDMA_MDMA_C31BNDTR_BRC                           \ BRC


\
\ @brief In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
\ Address offset: 0x818
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C31SAR_SAR                             \ SAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
\ Address offset: 0x81C
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C31DAR_DAR                             \ DAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
\ Address offset: 0x820
\ Reset value: 0x00000000
\

$0000ffff constant MDMA_MDMA_C31BRUR_SUV                            \ SUV
$ffff0000 constant MDMA_MDMA_C31BRUR_DUV                            \ DUV


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
\ Address offset: 0x824
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C31LAR_LAR                             \ LAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
\ Address offset: 0x828
\ Reset value: 0x00000000
\

$0000003f constant MDMA_MDMA_C31TBR_TSEL                            \ TSEL
$00010000 constant MDMA_MDMA_C31TBR_SBUS                            \ SBUS
$00020000 constant MDMA_MDMA_C31TBR_DBUS                            \ DBUS


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
\ Address offset: 0x830
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C31MAR_MAR                             \ MAR


\
\ @brief In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
\ Address offset: 0x834
\ Reset value: 0x00000000
\

$00000000 constant MDMA_MDMA_C31MDR_MDR                             \ MDR


\
\ @brief MDMA1
\
$58000000 constant MDMA_MDMA_GISR0  \ offset: 0x00 : MDMA global interrupt/status register
$58000008 constant MDMA_MDMA_SGISR0  \ offset: 0x08 : MDMA secure global interrupt/status register
$58000040 constant MDMA_MDMA_C0ISR  \ offset: 0x40 : MDMA channel 0 interrupt/status register
$58000044 constant MDMA_MDMA_C0IFCR  \ offset: 0x44 : MDMA channel 0 interrupt flag clear register
$58000048 constant MDMA_MDMA_C0ESR  \ offset: 0x48 : MDMA channel 0 error status register
$5800004c constant MDMA_MDMA_C0CR  \ offset: 0x4C : This register is used to control the concerned channel.
$58000050 constant MDMA_MDMA_C0TCR  \ offset: 0x50 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000054 constant MDMA_MDMA_C0BNDTR  \ offset: 0x54 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000058 constant MDMA_MDMA_C0SAR  \ offset: 0x58 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800005c constant MDMA_MDMA_C0DAR  \ offset: 0x5C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$58000060 constant MDMA_MDMA_C0BRUR  \ offset: 0x60 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$58000064 constant MDMA_MDMA_C0LAR  \ offset: 0x64 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$58000068 constant MDMA_MDMA_C0TBR  \ offset: 0x68 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$58000070 constant MDMA_MDMA_C0MAR  \ offset: 0x70 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$58000074 constant MDMA_MDMA_C0MDR  \ offset: 0x74 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000080 constant MDMA_MDMA_C1ISR  \ offset: 0x80 : MDMA channel 1 interrupt/status register
$58000084 constant MDMA_MDMA_C1IFCR  \ offset: 0x84 : MDMA channel 1 interrupt flag clear register
$58000088 constant MDMA_MDMA_C1ESR  \ offset: 0x88 : MDMA channel 1 error status register
$5800008c constant MDMA_MDMA_C1CR  \ offset: 0x8C : This register is used to control the concerned channel.
$58000090 constant MDMA_MDMA_C1TCR  \ offset: 0x90 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000094 constant MDMA_MDMA_C1BNDTR  \ offset: 0x94 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000098 constant MDMA_MDMA_C1SAR  \ offset: 0x98 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800009c constant MDMA_MDMA_C1DAR  \ offset: 0x9C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$580000a0 constant MDMA_MDMA_C1BRUR  \ offset: 0xA0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$580000a4 constant MDMA_MDMA_C1LAR  \ offset: 0xA4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$580000a8 constant MDMA_MDMA_C1TBR  \ offset: 0xA8 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$580000b0 constant MDMA_MDMA_C1MAR  \ offset: 0xB0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$580000b4 constant MDMA_MDMA_C1MDR  \ offset: 0xB4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$580000c0 constant MDMA_MDMA_C2ISR  \ offset: 0xC0 : MDMA channel 2 interrupt/status register
$580000c4 constant MDMA_MDMA_C2IFCR  \ offset: 0xC4 : MDMA channel 2 interrupt flag clear register
$580000c8 constant MDMA_MDMA_C2ESR  \ offset: 0xC8 : MDMA channel 2 error status register
$580000cc constant MDMA_MDMA_C2CR  \ offset: 0xCC : This register is used to control the concerned channel.
$580000d0 constant MDMA_MDMA_C2TCR  \ offset: 0xD0 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$580000d4 constant MDMA_MDMA_C2BNDTR  \ offset: 0xD4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$580000d8 constant MDMA_MDMA_C2SAR  \ offset: 0xD8 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$580000dc constant MDMA_MDMA_C2DAR  \ offset: 0xDC : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$580000e0 constant MDMA_MDMA_C2BRUR  \ offset: 0xE0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$580000e4 constant MDMA_MDMA_C2LAR  \ offset: 0xE4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$580000e8 constant MDMA_MDMA_C2TBR  \ offset: 0xE8 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$580000f0 constant MDMA_MDMA_C2MAR  \ offset: 0xF0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$580000f4 constant MDMA_MDMA_C2MDR  \ offset: 0xF4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000100 constant MDMA_MDMA_C3ISR  \ offset: 0x100 : MDMA channel 3 interrupt/status register
$58000104 constant MDMA_MDMA_C3IFCR  \ offset: 0x104 : MDMA channel 3 interrupt flag clear register
$58000108 constant MDMA_MDMA_C3ESR  \ offset: 0x108 : MDMA channel 3 error status register
$5800010c constant MDMA_MDMA_C3CR  \ offset: 0x10C : This register is used to control the concerned channel.
$58000110 constant MDMA_MDMA_C3TCR  \ offset: 0x110 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000114 constant MDMA_MDMA_C3BNDTR  \ offset: 0x114 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000118 constant MDMA_MDMA_C3SAR  \ offset: 0x118 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800011c constant MDMA_MDMA_C3DAR  \ offset: 0x11C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$58000120 constant MDMA_MDMA_C3BRUR  \ offset: 0x120 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$58000124 constant MDMA_MDMA_C3LAR  \ offset: 0x124 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$58000128 constant MDMA_MDMA_C3TBR  \ offset: 0x128 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$58000130 constant MDMA_MDMA_C3MAR  \ offset: 0x130 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$58000134 constant MDMA_MDMA_C3MDR  \ offset: 0x134 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000140 constant MDMA_MDMA_C4ISR  \ offset: 0x140 : MDMA channel 4 interrupt/status register
$58000144 constant MDMA_MDMA_C4IFCR  \ offset: 0x144 : MDMA channel 4 interrupt flag clear register
$58000148 constant MDMA_MDMA_C4ESR  \ offset: 0x148 : MDMA channel 4 error status register
$5800014c constant MDMA_MDMA_C4CR  \ offset: 0x14C : This register is used to control the concerned channel.
$58000150 constant MDMA_MDMA_C4TCR  \ offset: 0x150 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000154 constant MDMA_MDMA_C4BNDTR  \ offset: 0x154 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000158 constant MDMA_MDMA_C4SAR  \ offset: 0x158 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800015c constant MDMA_MDMA_C4DAR  \ offset: 0x15C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$58000160 constant MDMA_MDMA_C4BRUR  \ offset: 0x160 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$58000164 constant MDMA_MDMA_C4LAR  \ offset: 0x164 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$58000168 constant MDMA_MDMA_C4TBR  \ offset: 0x168 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$58000170 constant MDMA_MDMA_C4MAR  \ offset: 0x170 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$58000174 constant MDMA_MDMA_C4MDR  \ offset: 0x174 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000180 constant MDMA_MDMA_C5ISR  \ offset: 0x180 : MDMA channel 5 interrupt/status register
$58000184 constant MDMA_MDMA_C5IFCR  \ offset: 0x184 : MDMA channel 5 interrupt flag clear register
$58000188 constant MDMA_MDMA_C5ESR  \ offset: 0x188 : MDMA channel 5 error status register
$5800018c constant MDMA_MDMA_C5CR  \ offset: 0x18C : This register is used to control the concerned channel.
$58000190 constant MDMA_MDMA_C5TCR  \ offset: 0x190 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000194 constant MDMA_MDMA_C5BNDTR  \ offset: 0x194 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000198 constant MDMA_MDMA_C5SAR  \ offset: 0x198 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800019c constant MDMA_MDMA_C5DAR  \ offset: 0x19C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$580001a0 constant MDMA_MDMA_C5BRUR  \ offset: 0x1A0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$580001a4 constant MDMA_MDMA_C5LAR  \ offset: 0x1A4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$580001a8 constant MDMA_MDMA_C5TBR  \ offset: 0x1A8 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$580001b0 constant MDMA_MDMA_C5MAR  \ offset: 0x1B0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$580001b4 constant MDMA_MDMA_C5MDR  \ offset: 0x1B4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$580001c0 constant MDMA_MDMA_C6ISR  \ offset: 0x1C0 : MDMA channel 6 interrupt/status register
$580001c4 constant MDMA_MDMA_C6IFCR  \ offset: 0x1C4 : MDMA channel 6 interrupt flag clear register
$580001c8 constant MDMA_MDMA_C6ESR  \ offset: 0x1C8 : MDMA channel 6 error status register
$580001cc constant MDMA_MDMA_C6CR  \ offset: 0x1CC : This register is used to control the concerned channel.
$580001d0 constant MDMA_MDMA_C6TCR  \ offset: 0x1D0 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$580001d4 constant MDMA_MDMA_C6BNDTR  \ offset: 0x1D4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$580001d8 constant MDMA_MDMA_C6SAR  \ offset: 0x1D8 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$580001dc constant MDMA_MDMA_C6DAR  \ offset: 0x1DC : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$580001e0 constant MDMA_MDMA_C6BRUR  \ offset: 0x1E0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$580001e4 constant MDMA_MDMA_C6LAR  \ offset: 0x1E4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$580001e8 constant MDMA_MDMA_C6TBR  \ offset: 0x1E8 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$580001f0 constant MDMA_MDMA_C6MAR  \ offset: 0x1F0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$580001f4 constant MDMA_MDMA_C6MDR  \ offset: 0x1F4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000200 constant MDMA_MDMA_C7ISR  \ offset: 0x200 : MDMA channel 7 interrupt/status register
$58000204 constant MDMA_MDMA_C7IFCR  \ offset: 0x204 : MDMA channel 7 interrupt flag clear register
$58000208 constant MDMA_MDMA_C7ESR  \ offset: 0x208 : MDMA channel 7 error status register
$5800020c constant MDMA_MDMA_C7CR  \ offset: 0x20C : This register is used to control the concerned channel.
$58000210 constant MDMA_MDMA_C7TCR  \ offset: 0x210 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000214 constant MDMA_MDMA_C7BNDTR  \ offset: 0x214 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000218 constant MDMA_MDMA_C7SAR  \ offset: 0x218 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800021c constant MDMA_MDMA_C7DAR  \ offset: 0x21C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$58000220 constant MDMA_MDMA_C7BRUR  \ offset: 0x220 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$58000224 constant MDMA_MDMA_C7LAR  \ offset: 0x224 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$58000228 constant MDMA_MDMA_C7TBR  \ offset: 0x228 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$58000230 constant MDMA_MDMA_C7MAR  \ offset: 0x230 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$58000234 constant MDMA_MDMA_C7MDR  \ offset: 0x234 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000240 constant MDMA_MDMA_C8ISR  \ offset: 0x240 : MDMA channel 8 interrupt/status register
$58000244 constant MDMA_MDMA_C8IFCR  \ offset: 0x244 : MDMA channel 8 interrupt flag clear register
$58000248 constant MDMA_MDMA_C8ESR  \ offset: 0x248 : MDMA channel 8 error status register
$5800024c constant MDMA_MDMA_C8CR  \ offset: 0x24C : This register is used to control the concerned channel.
$58000250 constant MDMA_MDMA_C8TCR  \ offset: 0x250 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000254 constant MDMA_MDMA_C8BNDTR  \ offset: 0x254 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000258 constant MDMA_MDMA_C8SAR  \ offset: 0x258 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800025c constant MDMA_MDMA_C8DAR  \ offset: 0x25C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$58000260 constant MDMA_MDMA_C8BRUR  \ offset: 0x260 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$58000264 constant MDMA_MDMA_C8LAR  \ offset: 0x264 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$58000268 constant MDMA_MDMA_C8TBR  \ offset: 0x268 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$58000270 constant MDMA_MDMA_C8MAR  \ offset: 0x270 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$58000274 constant MDMA_MDMA_C8MDR  \ offset: 0x274 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000280 constant MDMA_MDMA_C9ISR  \ offset: 0x280 : MDMA channel 9 interrupt/status register
$58000284 constant MDMA_MDMA_C9IFCR  \ offset: 0x284 : MDMA channel 9 interrupt flag clear register
$58000288 constant MDMA_MDMA_C9ESR  \ offset: 0x288 : MDMA channel 9 error status register
$5800028c constant MDMA_MDMA_C9CR  \ offset: 0x28C : This register is used to control the concerned channel.
$58000290 constant MDMA_MDMA_C9TCR  \ offset: 0x290 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000294 constant MDMA_MDMA_C9BNDTR  \ offset: 0x294 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000298 constant MDMA_MDMA_C9SAR  \ offset: 0x298 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800029c constant MDMA_MDMA_C9DAR  \ offset: 0x29C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$580002a0 constant MDMA_MDMA_C9BRUR  \ offset: 0x2A0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$580002a4 constant MDMA_MDMA_C9LAR  \ offset: 0x2A4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$580002a8 constant MDMA_MDMA_C9TBR  \ offset: 0x2A8 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$580002b0 constant MDMA_MDMA_C9MAR  \ offset: 0x2B0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$580002b4 constant MDMA_MDMA_C9MDR  \ offset: 0x2B4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$580002c0 constant MDMA_MDMA_C10ISR  \ offset: 0x2C0 : MDMA channel 10 interrupt/status register
$580002c4 constant MDMA_MDMA_C10IFCR  \ offset: 0x2C4 : MDMA channel 10 interrupt flag clear register
$580002c8 constant MDMA_MDMA_C10ESR  \ offset: 0x2C8 : MDMA channel 10 error status register
$580002cc constant MDMA_MDMA_C10CR  \ offset: 0x2CC : This register is used to control the concerned channel.
$580002d0 constant MDMA_MDMA_C10TCR  \ offset: 0x2D0 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$580002d4 constant MDMA_MDMA_C10BNDTR  \ offset: 0x2D4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$580002d8 constant MDMA_MDMA_C10SAR  \ offset: 0x2D8 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$580002dc constant MDMA_MDMA_C10DAR  \ offset: 0x2DC : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$580002e0 constant MDMA_MDMA_C10BRUR  \ offset: 0x2E0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$580002e4 constant MDMA_MDMA_C10LAR  \ offset: 0x2E4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$580002e8 constant MDMA_MDMA_C10TBR  \ offset: 0x2E8 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$580002f0 constant MDMA_MDMA_C10MAR  \ offset: 0x2F0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$580002f4 constant MDMA_MDMA_C10MDR  \ offset: 0x2F4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000300 constant MDMA_MDMA_C11ISR  \ offset: 0x300 : MDMA channel 11 interrupt/status register
$58000304 constant MDMA_MDMA_C11IFCR  \ offset: 0x304 : MDMA channel 11 interrupt flag clear register
$58000308 constant MDMA_MDMA_C11ESR  \ offset: 0x308 : MDMA channel 11 error status register
$5800030c constant MDMA_MDMA_C11CR  \ offset: 0x30C : This register is used to control the concerned channel.
$58000310 constant MDMA_MDMA_C11TCR  \ offset: 0x310 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000314 constant MDMA_MDMA_C11BNDTR  \ offset: 0x314 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000318 constant MDMA_MDMA_C11SAR  \ offset: 0x318 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800031c constant MDMA_MDMA_C11DAR  \ offset: 0x31C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$58000320 constant MDMA_MDMA_C11BRUR  \ offset: 0x320 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$58000324 constant MDMA_MDMA_C11LAR  \ offset: 0x324 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$58000328 constant MDMA_MDMA_C11TBR  \ offset: 0x328 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$58000330 constant MDMA_MDMA_C11MAR  \ offset: 0x330 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$58000334 constant MDMA_MDMA_C11MDR  \ offset: 0x334 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000340 constant MDMA_MDMA_C12ISR  \ offset: 0x340 : MDMA channel 12 interrupt/status register
$58000344 constant MDMA_MDMA_C12IFCR  \ offset: 0x344 : MDMA channel 12 interrupt flag clear register
$58000348 constant MDMA_MDMA_C12ESR  \ offset: 0x348 : MDMA channel 12 error status register
$5800034c constant MDMA_MDMA_C12CR  \ offset: 0x34C : This register is used to control the concerned channel.
$58000350 constant MDMA_MDMA_C12TCR  \ offset: 0x350 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000354 constant MDMA_MDMA_C12BNDTR  \ offset: 0x354 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000358 constant MDMA_MDMA_C12SAR  \ offset: 0x358 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800035c constant MDMA_MDMA_C12DAR  \ offset: 0x35C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$58000360 constant MDMA_MDMA_C12BRUR  \ offset: 0x360 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$58000364 constant MDMA_MDMA_C12LAR  \ offset: 0x364 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$58000368 constant MDMA_MDMA_C12TBR  \ offset: 0x368 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$58000370 constant MDMA_MDMA_C12MAR  \ offset: 0x370 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$58000374 constant MDMA_MDMA_C12MDR  \ offset: 0x374 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000380 constant MDMA_MDMA_C13ISR  \ offset: 0x380 : MDMA channel 13 interrupt/status register
$58000384 constant MDMA_MDMA_C13IFCR  \ offset: 0x384 : MDMA channel 13 interrupt flag clear register
$58000388 constant MDMA_MDMA_C13ESR  \ offset: 0x388 : MDMA channel 13 error status register
$5800038c constant MDMA_MDMA_C13CR  \ offset: 0x38C : This register is used to control the concerned channel.
$58000390 constant MDMA_MDMA_C13TCR  \ offset: 0x390 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000394 constant MDMA_MDMA_C13BNDTR  \ offset: 0x394 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000398 constant MDMA_MDMA_C13SAR  \ offset: 0x398 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800039c constant MDMA_MDMA_C13DAR  \ offset: 0x39C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$580003a0 constant MDMA_MDMA_C13BRUR  \ offset: 0x3A0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$580003a4 constant MDMA_MDMA_C13LAR  \ offset: 0x3A4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$580003a8 constant MDMA_MDMA_C13TBR  \ offset: 0x3A8 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$580003b0 constant MDMA_MDMA_C13MAR  \ offset: 0x3B0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$580003b4 constant MDMA_MDMA_C13MDR  \ offset: 0x3B4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$580003c0 constant MDMA_MDMA_C14ISR  \ offset: 0x3C0 : MDMA channel 14 interrupt/status register
$580003c4 constant MDMA_MDMA_C14IFCR  \ offset: 0x3C4 : MDMA channel 14 interrupt flag clear register
$580003c8 constant MDMA_MDMA_C14ESR  \ offset: 0x3C8 : MDMA channel 14 error status register
$580003cc constant MDMA_MDMA_C14CR  \ offset: 0x3CC : This register is used to control the concerned channel.
$580003d0 constant MDMA_MDMA_C14TCR  \ offset: 0x3D0 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$580003d4 constant MDMA_MDMA_C14BNDTR  \ offset: 0x3D4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$580003d8 constant MDMA_MDMA_C14SAR  \ offset: 0x3D8 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$580003dc constant MDMA_MDMA_C14DAR  \ offset: 0x3DC : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$580003e0 constant MDMA_MDMA_C14BRUR  \ offset: 0x3E0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$580003e4 constant MDMA_MDMA_C14LAR  \ offset: 0x3E4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$580003e8 constant MDMA_MDMA_C14TBR  \ offset: 0x3E8 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$580003f0 constant MDMA_MDMA_C14MAR  \ offset: 0x3F0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$580003f4 constant MDMA_MDMA_C14MDR  \ offset: 0x3F4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000400 constant MDMA_MDMA_C15ISR  \ offset: 0x400 : MDMA channel 15 interrupt/status register
$58000404 constant MDMA_MDMA_C15IFCR  \ offset: 0x404 : MDMA channel 15 interrupt flag clear register
$58000408 constant MDMA_MDMA_C15ESR  \ offset: 0x408 : MDMA channel 15 error status register
$5800040c constant MDMA_MDMA_C15CR  \ offset: 0x40C : This register is used to control the concerned channel.
$58000410 constant MDMA_MDMA_C15TCR  \ offset: 0x410 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000414 constant MDMA_MDMA_C15BNDTR  \ offset: 0x414 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000418 constant MDMA_MDMA_C15SAR  \ offset: 0x418 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800041c constant MDMA_MDMA_C15DAR  \ offset: 0x41C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$58000420 constant MDMA_MDMA_C15BRUR  \ offset: 0x420 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$58000424 constant MDMA_MDMA_C15LAR  \ offset: 0x424 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$58000428 constant MDMA_MDMA_C15TBR  \ offset: 0x428 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$58000430 constant MDMA_MDMA_C15MAR  \ offset: 0x430 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$58000434 constant MDMA_MDMA_C15MDR  \ offset: 0x434 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000440 constant MDMA_MDMA_C16ISR  \ offset: 0x440 : MDMA channel 16 interrupt/status register
$58000444 constant MDMA_MDMA_C16IFCR  \ offset: 0x444 : MDMA channel 16 interrupt flag clear register
$58000448 constant MDMA_MDMA_C16ESR  \ offset: 0x448 : MDMA channel 16 error status register
$5800044c constant MDMA_MDMA_C16CR  \ offset: 0x44C : This register is used to control the concerned channel.
$58000450 constant MDMA_MDMA_C16TCR  \ offset: 0x450 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000454 constant MDMA_MDMA_C16BNDTR  \ offset: 0x454 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000458 constant MDMA_MDMA_C16SAR  \ offset: 0x458 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800045c constant MDMA_MDMA_C16DAR  \ offset: 0x45C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$58000460 constant MDMA_MDMA_C16BRUR  \ offset: 0x460 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$58000464 constant MDMA_MDMA_C16LAR  \ offset: 0x464 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$58000468 constant MDMA_MDMA_C16TBR  \ offset: 0x468 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$58000470 constant MDMA_MDMA_C16MAR  \ offset: 0x470 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$58000474 constant MDMA_MDMA_C16MDR  \ offset: 0x474 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000480 constant MDMA_MDMA_C17ISR  \ offset: 0x480 : MDMA channel 17 interrupt/status register
$58000484 constant MDMA_MDMA_C17IFCR  \ offset: 0x484 : MDMA channel 17 interrupt flag clear register
$58000488 constant MDMA_MDMA_C17ESR  \ offset: 0x488 : MDMA channel 17 error status register
$5800048c constant MDMA_MDMA_C17CR  \ offset: 0x48C : This register is used to control the concerned channel.
$58000490 constant MDMA_MDMA_C17TCR  \ offset: 0x490 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000494 constant MDMA_MDMA_C17BNDTR  \ offset: 0x494 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000498 constant MDMA_MDMA_C17SAR  \ offset: 0x498 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800049c constant MDMA_MDMA_C17DAR  \ offset: 0x49C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$580004a0 constant MDMA_MDMA_C17BRUR  \ offset: 0x4A0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$580004a4 constant MDMA_MDMA_C17LAR  \ offset: 0x4A4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$580004a8 constant MDMA_MDMA_C17TBR  \ offset: 0x4A8 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$580004b0 constant MDMA_MDMA_C17MAR  \ offset: 0x4B0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$580004b4 constant MDMA_MDMA_C17MDR  \ offset: 0x4B4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$580004c0 constant MDMA_MDMA_C18ISR  \ offset: 0x4C0 : MDMA channel 18 interrupt/status register
$580004c4 constant MDMA_MDMA_C18IFCR  \ offset: 0x4C4 : MDMA channel 18 interrupt flag clear register
$580004c8 constant MDMA_MDMA_C18ESR  \ offset: 0x4C8 : MDMA channel 18 error status register
$580004cc constant MDMA_MDMA_C18CR  \ offset: 0x4CC : This register is used to control the concerned channel.
$580004d0 constant MDMA_MDMA_C18TCR  \ offset: 0x4D0 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$580004d4 constant MDMA_MDMA_C18BNDTR  \ offset: 0x4D4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$580004d8 constant MDMA_MDMA_C18SAR  \ offset: 0x4D8 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$580004dc constant MDMA_MDMA_C18DAR  \ offset: 0x4DC : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$580004e0 constant MDMA_MDMA_C18BRUR  \ offset: 0x4E0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$580004e4 constant MDMA_MDMA_C18LAR  \ offset: 0x4E4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$580004e8 constant MDMA_MDMA_C18TBR  \ offset: 0x4E8 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$580004f0 constant MDMA_MDMA_C18MAR  \ offset: 0x4F0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$580004f4 constant MDMA_MDMA_C18MDR  \ offset: 0x4F4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000500 constant MDMA_MDMA_C19ISR  \ offset: 0x500 : MDMA channel 19 interrupt/status register
$58000504 constant MDMA_MDMA_C19IFCR  \ offset: 0x504 : MDMA channel 19 interrupt flag clear register
$58000508 constant MDMA_MDMA_C19ESR  \ offset: 0x508 : MDMA channel 19 error status register
$5800050c constant MDMA_MDMA_C19CR  \ offset: 0x50C : This register is used to control the concerned channel.
$58000510 constant MDMA_MDMA_C19TCR  \ offset: 0x510 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000514 constant MDMA_MDMA_C19BNDTR  \ offset: 0x514 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000518 constant MDMA_MDMA_C19SAR  \ offset: 0x518 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800051c constant MDMA_MDMA_C19DAR  \ offset: 0x51C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$58000520 constant MDMA_MDMA_C19BRUR  \ offset: 0x520 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$58000524 constant MDMA_MDMA_C19LAR  \ offset: 0x524 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$58000528 constant MDMA_MDMA_C19TBR  \ offset: 0x528 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$58000530 constant MDMA_MDMA_C19MAR  \ offset: 0x530 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$58000534 constant MDMA_MDMA_C19MDR  \ offset: 0x534 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000540 constant MDMA_MDMA_C20ISR  \ offset: 0x540 : MDMA channel 20 interrupt/status register
$58000544 constant MDMA_MDMA_C20IFCR  \ offset: 0x544 : MDMA channel 20 interrupt flag clear register
$58000548 constant MDMA_MDMA_C20ESR  \ offset: 0x548 : MDMA channel 20 error status register
$5800054c constant MDMA_MDMA_C20CR  \ offset: 0x54C : This register is used to control the concerned channel.
$58000550 constant MDMA_MDMA_C20TCR  \ offset: 0x550 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000554 constant MDMA_MDMA_C20BNDTR  \ offset: 0x554 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000558 constant MDMA_MDMA_C20SAR  \ offset: 0x558 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800055c constant MDMA_MDMA_C20DAR  \ offset: 0x55C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$58000560 constant MDMA_MDMA_C20BRUR  \ offset: 0x560 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$58000564 constant MDMA_MDMA_C20LAR  \ offset: 0x564 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$58000568 constant MDMA_MDMA_C20TBR  \ offset: 0x568 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$58000570 constant MDMA_MDMA_C20MAR  \ offset: 0x570 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$58000574 constant MDMA_MDMA_C20MDR  \ offset: 0x574 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000580 constant MDMA_MDMA_C21ISR  \ offset: 0x580 : MDMA channel 21 interrupt/status register
$58000584 constant MDMA_MDMA_C21IFCR  \ offset: 0x584 : MDMA channel 21 interrupt flag clear register
$58000588 constant MDMA_MDMA_C21ESR  \ offset: 0x588 : MDMA channel 21 error status register
$5800058c constant MDMA_MDMA_C21CR  \ offset: 0x58C : This register is used to control the concerned channel.
$58000590 constant MDMA_MDMA_C21TCR  \ offset: 0x590 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000594 constant MDMA_MDMA_C21BNDTR  \ offset: 0x594 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000598 constant MDMA_MDMA_C21SAR  \ offset: 0x598 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800059c constant MDMA_MDMA_C21DAR  \ offset: 0x59C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$580005a0 constant MDMA_MDMA_C21BRUR  \ offset: 0x5A0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$580005a4 constant MDMA_MDMA_C21LAR  \ offset: 0x5A4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$580005a8 constant MDMA_MDMA_C21TBR  \ offset: 0x5A8 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$580005b0 constant MDMA_MDMA_C21MAR  \ offset: 0x5B0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$580005b4 constant MDMA_MDMA_C21MDR  \ offset: 0x5B4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$580005c0 constant MDMA_MDMA_C22ISR  \ offset: 0x5C0 : MDMA channel 22 interrupt/status register
$580005c4 constant MDMA_MDMA_C22IFCR  \ offset: 0x5C4 : MDMA channel 22 interrupt flag clear register
$580005c8 constant MDMA_MDMA_C22ESR  \ offset: 0x5C8 : MDMA channel 22 error status register
$580005cc constant MDMA_MDMA_C22CR  \ offset: 0x5CC : This register is used to control the concerned channel.
$580005d0 constant MDMA_MDMA_C22TCR  \ offset: 0x5D0 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$580005d4 constant MDMA_MDMA_C22BNDTR  \ offset: 0x5D4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$580005d8 constant MDMA_MDMA_C22SAR  \ offset: 0x5D8 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$580005dc constant MDMA_MDMA_C22DAR  \ offset: 0x5DC : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$580005e0 constant MDMA_MDMA_C22BRUR  \ offset: 0x5E0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$580005e4 constant MDMA_MDMA_C22LAR  \ offset: 0x5E4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$580005e8 constant MDMA_MDMA_C22TBR  \ offset: 0x5E8 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$580005f0 constant MDMA_MDMA_C22MAR  \ offset: 0x5F0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$580005f4 constant MDMA_MDMA_C22MDR  \ offset: 0x5F4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000600 constant MDMA_MDMA_C23ISR  \ offset: 0x600 : MDMA channel 23 interrupt/status register
$58000604 constant MDMA_MDMA_C23IFCR  \ offset: 0x604 : MDMA channel 23 interrupt flag clear register
$58000608 constant MDMA_MDMA_C23ESR  \ offset: 0x608 : MDMA channel 23 error status register
$5800060c constant MDMA_MDMA_C23CR  \ offset: 0x60C : This register is used to control the concerned channel.
$58000610 constant MDMA_MDMA_C23TCR  \ offset: 0x610 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000614 constant MDMA_MDMA_C23BNDTR  \ offset: 0x614 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000618 constant MDMA_MDMA_C23SAR  \ offset: 0x618 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800061c constant MDMA_MDMA_C23DAR  \ offset: 0x61C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$58000620 constant MDMA_MDMA_C23BRUR  \ offset: 0x620 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$58000624 constant MDMA_MDMA_C23LAR  \ offset: 0x624 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$58000628 constant MDMA_MDMA_C23TBR  \ offset: 0x628 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$58000630 constant MDMA_MDMA_C23MAR  \ offset: 0x630 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$58000634 constant MDMA_MDMA_C23MDR  \ offset: 0x634 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000640 constant MDMA_MDMA_C24ISR  \ offset: 0x640 : MDMA channel 24 interrupt/status register
$58000644 constant MDMA_MDMA_C24IFCR  \ offset: 0x644 : MDMA channel 24 interrupt flag clear register
$58000648 constant MDMA_MDMA_C24ESR  \ offset: 0x648 : MDMA channel 24 error status register
$5800064c constant MDMA_MDMA_C24CR  \ offset: 0x64C : This register is used to control the concerned channel.
$58000650 constant MDMA_MDMA_C24TCR  \ offset: 0x650 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000654 constant MDMA_MDMA_C24BNDTR  \ offset: 0x654 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000658 constant MDMA_MDMA_C24SAR  \ offset: 0x658 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800065c constant MDMA_MDMA_C24DAR  \ offset: 0x65C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$58000660 constant MDMA_MDMA_C24BRUR  \ offset: 0x660 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$58000664 constant MDMA_MDMA_C24LAR  \ offset: 0x664 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$58000668 constant MDMA_MDMA_C24TBR  \ offset: 0x668 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$58000670 constant MDMA_MDMA_C24MAR  \ offset: 0x670 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$58000674 constant MDMA_MDMA_C24MDR  \ offset: 0x674 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000680 constant MDMA_MDMA_C25ISR  \ offset: 0x680 : MDMA channel 25 interrupt/status register
$58000684 constant MDMA_MDMA_C25IFCR  \ offset: 0x684 : MDMA channel 25 interrupt flag clear register
$58000688 constant MDMA_MDMA_C25ESR  \ offset: 0x688 : MDMA channel 25 error status register
$5800068c constant MDMA_MDMA_C25CR  \ offset: 0x68C : This register is used to control the concerned channel.
$58000690 constant MDMA_MDMA_C25TCR  \ offset: 0x690 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000694 constant MDMA_MDMA_C25BNDTR  \ offset: 0x694 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000698 constant MDMA_MDMA_C25SAR  \ offset: 0x698 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800069c constant MDMA_MDMA_C25DAR  \ offset: 0x69C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$580006a0 constant MDMA_MDMA_C25BRUR  \ offset: 0x6A0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$580006a4 constant MDMA_MDMA_C25LAR  \ offset: 0x6A4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$580006a8 constant MDMA_MDMA_C25TBR  \ offset: 0x6A8 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$580006b0 constant MDMA_MDMA_C25MAR  \ offset: 0x6B0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$580006b4 constant MDMA_MDMA_C25MDR  \ offset: 0x6B4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$580006c0 constant MDMA_MDMA_C26ISR  \ offset: 0x6C0 : MDMA channel 26 interrupt/status register
$580006c4 constant MDMA_MDMA_C26IFCR  \ offset: 0x6C4 : MDMA channel 26 interrupt flag clear register
$580006c8 constant MDMA_MDMA_C26ESR  \ offset: 0x6C8 : MDMA channel 26 error status register
$580006cc constant MDMA_MDMA_C26CR  \ offset: 0x6CC : This register is used to control the concerned channel.
$580006d0 constant MDMA_MDMA_C26TCR  \ offset: 0x6D0 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$580006d4 constant MDMA_MDMA_C26BNDTR  \ offset: 0x6D4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$580006d8 constant MDMA_MDMA_C26SAR  \ offset: 0x6D8 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$580006dc constant MDMA_MDMA_C26DAR  \ offset: 0x6DC : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$580006e0 constant MDMA_MDMA_C26BRUR  \ offset: 0x6E0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$580006e4 constant MDMA_MDMA_C26LAR  \ offset: 0x6E4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$580006e8 constant MDMA_MDMA_C26TBR  \ offset: 0x6E8 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$580006f0 constant MDMA_MDMA_C26MAR  \ offset: 0x6F0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$580006f4 constant MDMA_MDMA_C26MDR  \ offset: 0x6F4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000700 constant MDMA_MDMA_C27ISR  \ offset: 0x700 : MDMA channel 27 interrupt/status register
$58000704 constant MDMA_MDMA_C27IFCR  \ offset: 0x704 : MDMA channel 27 interrupt flag clear register
$58000708 constant MDMA_MDMA_C27ESR  \ offset: 0x708 : MDMA channel 27 error status register
$5800070c constant MDMA_MDMA_C27CR  \ offset: 0x70C : This register is used to control the concerned channel.
$58000710 constant MDMA_MDMA_C27TCR  \ offset: 0x710 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000714 constant MDMA_MDMA_C27BNDTR  \ offset: 0x714 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000718 constant MDMA_MDMA_C27SAR  \ offset: 0x718 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800071c constant MDMA_MDMA_C27DAR  \ offset: 0x71C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$58000720 constant MDMA_MDMA_C27BRUR  \ offset: 0x720 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$58000724 constant MDMA_MDMA_C27LAR  \ offset: 0x724 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$58000728 constant MDMA_MDMA_C27TBR  \ offset: 0x728 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$58000730 constant MDMA_MDMA_C27MAR  \ offset: 0x730 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$58000734 constant MDMA_MDMA_C27MDR  \ offset: 0x734 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000740 constant MDMA_MDMA_C28ISR  \ offset: 0x740 : MDMA channel 28 interrupt/status register
$58000744 constant MDMA_MDMA_C28IFCR  \ offset: 0x744 : MDMA channel 28 interrupt flag clear register
$58000748 constant MDMA_MDMA_C28ESR  \ offset: 0x748 : MDMA channel 28 error status register
$5800074c constant MDMA_MDMA_C28CR  \ offset: 0x74C : This register is used to control the concerned channel.
$58000750 constant MDMA_MDMA_C28TCR  \ offset: 0x750 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000754 constant MDMA_MDMA_C28BNDTR  \ offset: 0x754 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000758 constant MDMA_MDMA_C28SAR  \ offset: 0x758 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800075c constant MDMA_MDMA_C28DAR  \ offset: 0x75C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$58000760 constant MDMA_MDMA_C28BRUR  \ offset: 0x760 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$58000764 constant MDMA_MDMA_C28LAR  \ offset: 0x764 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$58000768 constant MDMA_MDMA_C28TBR  \ offset: 0x768 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$58000770 constant MDMA_MDMA_C28MAR  \ offset: 0x770 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$58000774 constant MDMA_MDMA_C28MDR  \ offset: 0x774 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000780 constant MDMA_MDMA_C29ISR  \ offset: 0x780 : MDMA channel 29 interrupt/status register
$58000784 constant MDMA_MDMA_C29IFCR  \ offset: 0x784 : MDMA channel 29 interrupt flag clear register
$58000788 constant MDMA_MDMA_C29ESR  \ offset: 0x788 : MDMA channel 29 error status register
$5800078c constant MDMA_MDMA_C29CR  \ offset: 0x78C : This register is used to control the concerned channel.
$58000790 constant MDMA_MDMA_C29TCR  \ offset: 0x790 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000794 constant MDMA_MDMA_C29BNDTR  \ offset: 0x794 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000798 constant MDMA_MDMA_C29SAR  \ offset: 0x798 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800079c constant MDMA_MDMA_C29DAR  \ offset: 0x79C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$580007a0 constant MDMA_MDMA_C29BRUR  \ offset: 0x7A0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$580007a4 constant MDMA_MDMA_C29LAR  \ offset: 0x7A4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$580007a8 constant MDMA_MDMA_C29TBR  \ offset: 0x7A8 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$580007b0 constant MDMA_MDMA_C29MAR  \ offset: 0x7B0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$580007b4 constant MDMA_MDMA_C29MDR  \ offset: 0x7B4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$580007c0 constant MDMA_MDMA_C30ISR  \ offset: 0x7C0 : MDMA channel 30 interrupt/status register
$580007c4 constant MDMA_MDMA_C30IFCR  \ offset: 0x7C4 : MDMA channel 30 interrupt flag clear register
$580007c8 constant MDMA_MDMA_C30ESR  \ offset: 0x7C8 : MDMA channel 30 error status register
$580007cc constant MDMA_MDMA_C30CR  \ offset: 0x7CC : This register is used to control the concerned channel.
$580007d0 constant MDMA_MDMA_C30TCR  \ offset: 0x7D0 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$580007d4 constant MDMA_MDMA_C30BNDTR  \ offset: 0x7D4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$580007d8 constant MDMA_MDMA_C30SAR  \ offset: 0x7D8 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$580007dc constant MDMA_MDMA_C30DAR  \ offset: 0x7DC : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$580007e0 constant MDMA_MDMA_C30BRUR  \ offset: 0x7E0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$580007e4 constant MDMA_MDMA_C30LAR  \ offset: 0x7E4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$580007e8 constant MDMA_MDMA_C30TBR  \ offset: 0x7E8 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$580007f0 constant MDMA_MDMA_C30MAR  \ offset: 0x7F0 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$580007f4 constant MDMA_MDMA_C30MDR  \ offset: 0x7F4 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).
$58000800 constant MDMA_MDMA_C31ISR  \ offset: 0x800 : MDMA channel 31 interrupt/status register
$58000804 constant MDMA_MDMA_C31IFCR  \ offset: 0x804 : MDMA channel 31 interrupt flag clear register
$58000808 constant MDMA_MDMA_C31ESR  \ offset: 0x808 : MDMA channel 31 error status register
$5800080c constant MDMA_MDMA_C31CR  \ offset: 0x80C : This register is used to control the concerned channel.
$58000810 constant MDMA_MDMA_C31TCR  \ offset: 0x810 : This register is used to configure the concerned channel. In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x00).
$58000814 constant MDMA_MDMA_C31BNDTR  \ offset: 0x814 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x04).
$58000818 constant MDMA_MDMA_C31SAR  \ offset: 0x818 : In Linked List mode, at the end of a Block (single or last Block in repeated Block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x08).
$5800081c constant MDMA_MDMA_C31DAR  \ offset: 0x81C : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x0C). M
$58000820 constant MDMA_MDMA_C31BRUR  \ offset: 0x820 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x10).
$58000824 constant MDMA_MDMA_C31LAR  \ offset: 0x824 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x14). The new value is only taken into account after all registers are updated, for the next end of block.
$58000828 constant MDMA_MDMA_C31TBR  \ offset: 0x828 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x18).
$58000830 constant MDMA_MDMA_C31MAR  \ offset: 0x830 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x20).
$58000834 constant MDMA_MDMA_C31MDR  \ offset: 0x834 : In Linked List mode, at the end of a block (single or last block in repeated block transfer mode), this register will be loaded from memory (from address given by current LAR[31:0] + 0x24).

