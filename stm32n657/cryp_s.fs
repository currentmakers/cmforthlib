\
\ @file cryp_s.fs
\ @brief Cryptographic processor
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief CRYP control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000004 constant CRYP_S_CRYP_CR_ALGODIR                           \ Algorithm direction
$00000038 constant CRYP_S_CRYP_CR_ALGOMODE                          \ ALGOMODE[2:0]: Algorithm mode
$000000c0 constant CRYP_S_CRYP_CR_DATATYPE                          \ Data type
$00000300 constant CRYP_S_CRYP_CR_KEYSIZE                           \ Key size selection
$00004000 constant CRYP_S_CRYP_CR_FFLUSH                            \ FIFO flush
$00008000 constant CRYP_S_CRYP_CR_CRYPEN                            \ CRYP enable
$00030000 constant CRYP_S_CRYP_CR_GCM_CCMPH                         \ GCM or CCM phase selection
$00080000 constant CRYP_S_CRYP_CR_ALGOMODE_1                        \ ALGOMODE[3]
$00f00000 constant CRYP_S_CRYP_CR_NPBLB                             \ Number of padding bytes in last block
$03000000 constant CRYP_S_CRYP_CR_KMOD                              \ Key mode selection
$80000000 constant CRYP_S_CRYP_CR_IPRST                             \ CRYP peripheral software reset


\
\ @brief CRYP status register
\ Address offset: 0x04
\ Reset value: 0x00000003
\

$00000001 constant CRYP_S_CRYP_SR_IFEM                              \ Input FIFO empty flag
$00000002 constant CRYP_S_CRYP_SR_IFNF                              \ Input FIFO not full flag
$00000004 constant CRYP_S_CRYP_SR_OFNE                              \ Output FIFO not empty flag
$00000008 constant CRYP_S_CRYP_SR_OFFU                              \ Output FIFO full flag
$00000010 constant CRYP_S_CRYP_SR_BUSY                              \ Busy bit
$00000040 constant CRYP_S_CRYP_SR_KERF                              \ Key error flag
$00000080 constant CRYP_S_CRYP_SR_KEYVALID                          \ Key valid flag


\
\ @brief CRYP data input register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_DINR_DIN                             \ Data input


\
\ @brief CRYP data output register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_DOUTR_DOUT                           \ Data output


\
\ @brief CRYP DMA control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant CRYP_S_CRYP_DMACR_DIEN                           \ DMA input enable
$00000002 constant CRYP_S_CRYP_DMACR_DOEN                           \ DMA output enable


\
\ @brief CRYP interrupt mask set/clear register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant CRYP_S_CRYP_IMSCR_INIM                           \ Input FIFO service interrupt mask
$00000002 constant CRYP_S_CRYP_IMSCR_OUTIM                          \ Output FIFO service interrupt mask


\
\ @brief CRYP raw interrupt status register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$00000001 constant CRYP_S_CRYP_RISR_INRIS                           \ Input FIFO service raw interrupt status
$00000002 constant CRYP_S_CRYP_RISR_OUTRIS                          \ Output FIFO service raw interrupt status


\
\ @brief CRYP masked interrupt status register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant CRYP_S_CRYP_MISR_INMIS                           \ Input FIFO service masked interrupt status
$00000002 constant CRYP_S_CRYP_MISR_OUTMIS                          \ Output FIFO service masked interrupt status


\
\ @brief CRYP key register 0L
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_K0LR_K                               \ Key bit x


\
\ @brief CRYP key register 0R
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_K0RR_K                               \ Key bit x


\
\ @brief CRYP key register 1L
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_K1LR_K                               \ Key bit x


\
\ @brief CRYP key register 1R
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_K1RR_K                               \ Key bit x


\
\ @brief CRYP key register 2L
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_K2LR_K                               \ Key bit x


\
\ @brief CRYP key register 2R
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_K2RR_K                               \ Key bit x


\
\ @brief CRYP key register 3L
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_K3LR_K                               \ Key bit x


\
\ @brief CRYP key register 3R
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_K3RR_K                               \ Key bit x


\
\ @brief CRYP initialization vector register 0L
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_IV0LR_IVI                            \ Initialization vector bit x


\
\ @brief CRYP initialization vector register 0R
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_IV0RR_IVI                            \ Initialization vector bit x


\
\ @brief CRYP initialization vector register 1L
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_IV1LR_IVI                            \ Initialization vector bit x


\
\ @brief CRYP initialization vector register 1R
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_IV1RR_IVI                            \ Initialization vector bit x


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_CSGCMCCM0R_CSGCMCCM                  \ Context swap for GCM/GMAC and CCM modes


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_CSGCMCCM1R_CSGCMCCM                  \ Context swap for GCM/GMAC and CCM modes


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_CSGCMCCM2R_CSGCMCCM                  \ Context swap for GCM/GMAC and CCM modes


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_CSGCMCCM3R_CSGCMCCM                  \ Context swap for GCM/GMAC and CCM modes


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_CSGCMCCM4R_CSGCMCCM                  \ Context swap for GCM/GMAC and CCM modes


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_CSGCMCCM5R_CSGCMCCM                  \ Context swap for GCM/GMAC and CCM modes


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_CSGCMCCM6R_CSGCMCCM                  \ Context swap for GCM/GMAC and CCM modes


\
\ @brief CRYP context swap GCM-CCM registers
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_CSGCMCCM7R_CSGCMCCM                  \ Context swap for GCM/GMAC and CCM modes


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_CSGCM0R_CSGCM                        \ Context swap for GCM/GMAC modes


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_CSGCM1R_CSGCM                        \ Context swap for GCM/GMAC modes


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_CSGCM2R_CSGCM                        \ Context swap for GCM/GMAC modes


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_CSGCM3R_CSGCM                        \ Context swap for GCM/GMAC modes


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_CSGCM4R_CSGCM                        \ Context swap for GCM/GMAC modes


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_CSGCM5R_CSGCM                        \ Context swap for GCM/GMAC modes


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_CSGCM6R_CSGCM                        \ Context swap for GCM/GMAC modes


\
\ @brief CRYP context swap GCM registers
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant CRYP_S_CRYP_CSGCM7R_CSGCM                        \ Context swap for GCM/GMAC modes


\
\ @brief Cryptographic processor
\
$54020800 constant CRYP_S_CRYP_CR  \ offset: 0x00 : CRYP control register
$54020804 constant CRYP_S_CRYP_SR  \ offset: 0x04 : CRYP status register
$54020808 constant CRYP_S_CRYP_DINR  \ offset: 0x08 : CRYP data input register
$5402080c constant CRYP_S_CRYP_DOUTR  \ offset: 0x0C : CRYP data output register
$54020810 constant CRYP_S_CRYP_DMACR  \ offset: 0x10 : CRYP DMA control register
$54020814 constant CRYP_S_CRYP_IMSCR  \ offset: 0x14 : CRYP interrupt mask set/clear register
$54020818 constant CRYP_S_CRYP_RISR  \ offset: 0x18 : CRYP raw interrupt status register
$5402081c constant CRYP_S_CRYP_MISR  \ offset: 0x1C : CRYP masked interrupt status register
$54020820 constant CRYP_S_CRYP_K0LR  \ offset: 0x20 : CRYP key register 0L
$54020824 constant CRYP_S_CRYP_K0RR  \ offset: 0x24 : CRYP key register 0R
$54020828 constant CRYP_S_CRYP_K1LR  \ offset: 0x28 : CRYP key register 1L
$5402082c constant CRYP_S_CRYP_K1RR  \ offset: 0x2C : CRYP key register 1R
$54020830 constant CRYP_S_CRYP_K2LR  \ offset: 0x30 : CRYP key register 2L
$54020834 constant CRYP_S_CRYP_K2RR  \ offset: 0x34 : CRYP key register 2R
$54020838 constant CRYP_S_CRYP_K3LR  \ offset: 0x38 : CRYP key register 3L
$5402083c constant CRYP_S_CRYP_K3RR  \ offset: 0x3C : CRYP key register 3R
$54020840 constant CRYP_S_CRYP_IV0LR  \ offset: 0x40 : CRYP initialization vector register 0L
$54020844 constant CRYP_S_CRYP_IV0RR  \ offset: 0x44 : CRYP initialization vector register 0R
$54020848 constant CRYP_S_CRYP_IV1LR  \ offset: 0x48 : CRYP initialization vector register 1L
$5402084c constant CRYP_S_CRYP_IV1RR  \ offset: 0x4C : CRYP initialization vector register 1R
$54020850 constant CRYP_S_CRYP_CSGCMCCM0R  \ offset: 0x50 : CRYP context swap GCM-CCM registers
$54020854 constant CRYP_S_CRYP_CSGCMCCM1R  \ offset: 0x54 : CRYP context swap GCM-CCM registers
$54020858 constant CRYP_S_CRYP_CSGCMCCM2R  \ offset: 0x58 : CRYP context swap GCM-CCM registers
$5402085c constant CRYP_S_CRYP_CSGCMCCM3R  \ offset: 0x5C : CRYP context swap GCM-CCM registers
$54020860 constant CRYP_S_CRYP_CSGCMCCM4R  \ offset: 0x60 : CRYP context swap GCM-CCM registers
$54020864 constant CRYP_S_CRYP_CSGCMCCM5R  \ offset: 0x64 : CRYP context swap GCM-CCM registers
$54020868 constant CRYP_S_CRYP_CSGCMCCM6R  \ offset: 0x68 : CRYP context swap GCM-CCM registers
$5402086c constant CRYP_S_CRYP_CSGCMCCM7R  \ offset: 0x6C : CRYP context swap GCM-CCM registers
$54020870 constant CRYP_S_CRYP_CSGCM0R  \ offset: 0x70 : CRYP context swap GCM registers
$54020874 constant CRYP_S_CRYP_CSGCM1R  \ offset: 0x74 : CRYP context swap GCM registers
$54020878 constant CRYP_S_CRYP_CSGCM2R  \ offset: 0x78 : CRYP context swap GCM registers
$5402087c constant CRYP_S_CRYP_CSGCM3R  \ offset: 0x7C : CRYP context swap GCM registers
$54020880 constant CRYP_S_CRYP_CSGCM4R  \ offset: 0x80 : CRYP context swap GCM registers
$54020884 constant CRYP_S_CRYP_CSGCM5R  \ offset: 0x84 : CRYP context swap GCM registers
$54020888 constant CRYP_S_CRYP_CSGCM6R  \ offset: 0x88 : CRYP context swap GCM registers
$5402088c constant CRYP_S_CRYP_CSGCM7R  \ offset: 0x8C : CRYP context swap GCM registers

