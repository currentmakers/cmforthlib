\
\ @file ethernet_mtl.fs
\ @brief Ethernet: MTL mode register (MTL)
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Operating mode Register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000002 constant ETHERNET_MTL_MTLOMR_DTXSTS                       \ DTXSTS
$00000100 constant ETHERNET_MTL_MTLOMR_CNTPRST                      \ CNTPRST
$00000200 constant ETHERNET_MTL_MTLOMR_CNTCLR                       \ CNTCLR


\
\ @brief Interrupt status Register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MTL_MTLISR_Q0IS                         \ Queue interrupt status


\
\ @brief Tx queue operating mode Register
\ Address offset: 0x100
\ Reset value: 0x00070008
\

$00000001 constant ETHERNET_MTL_MTLTXQOMR_FTQ                       \ Flush Transmit Queue
$00000002 constant ETHERNET_MTL_MTLTXQOMR_TSF                       \ Transmit Store and Forward
$0000000c constant ETHERNET_MTL_MTLTXQOMR_TXQEN                     \ Transmit Queue Enable
$00000070 constant ETHERNET_MTL_MTLTXQOMR_TTC                       \ Transmit Threshold Control
$00070000 constant ETHERNET_MTL_MTLTXQOMR_TQS                       \ Transmit Queue Size


\
\ @brief Tx queue underflow register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$000007ff constant ETHERNET_MTL_MTLTXQUR_UFFRMCNT                   \ Underflow Packet Counter
$00000800 constant ETHERNET_MTL_MTLTXQUR_UFCNTOVF                   \ UFCNTOVF


\
\ @brief Tx queue debug Register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MTL_MTLTXQDR_TXQPAUSED                  \ TXQPAUSED
$00000006 constant ETHERNET_MTL_MTLTXQDR_TRCSTS                     \ TRCSTS
$00000008 constant ETHERNET_MTL_MTLTXQDR_TWCSTS                     \ TWCSTS
$00000010 constant ETHERNET_MTL_MTLTXQDR_TXQSTS                     \ TXQSTS
$00000020 constant ETHERNET_MTL_MTLTXQDR_TXSTSFSTS                  \ TXSTSFSTS
$00070000 constant ETHERNET_MTL_MTLTXQDR_PTXQ                       \ PTXQ
$00700000 constant ETHERNET_MTL_MTLTXQDR_STXSTSF                    \ STXSTSF


\
\ @brief Queue interrupt control status Register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MTL_MTLQICSR_TXUNFIS                    \ TXUNFIS
$00000100 constant ETHERNET_MTL_MTLQICSR_TXUIE                      \ TXUIE
$00010000 constant ETHERNET_MTL_MTLQICSR_RXOVFIS                    \ RXOVFIS
$01000000 constant ETHERNET_MTL_MTLQICSR_RXOIE                      \ RXOIE


\
\ @brief Rx queue operating mode register
\ Address offset: 0x130
\ Reset value: 0x00700000
\

$00000003 constant ETHERNET_MTL_MTLRXQOMR_RTC                       \ RTC
$00000008 constant ETHERNET_MTL_MTLRXQOMR_FUP                       \ FUP
$00000010 constant ETHERNET_MTL_MTLRXQOMR_FEP                       \ FEP
$00000020 constant ETHERNET_MTL_MTLRXQOMR_RSF                       \ RSF
$00000040 constant ETHERNET_MTL_MTLRXQOMR_DIS_TCP_EF                \ DIS_TCP_EF
$00000080 constant ETHERNET_MTL_MTLRXQOMR_EHFC                      \ EHFC
$00000700 constant ETHERNET_MTL_MTLRXQOMR_RFA                       \ RFA
$0001c000 constant ETHERNET_MTL_MTLRXQOMR_RFD                       \ RFD
$00700000 constant ETHERNET_MTL_MTLRXQOMR_RQS                       \ RQS


\
\ @brief Rx queue missed packet and overflow counter register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$000007ff constant ETHERNET_MTL_MTLRXQMPOCR_OVFPKTCNT               \ OVFPKTCNT
$00000800 constant ETHERNET_MTL_MTLRXQMPOCR_OVFCNTOVF               \ OVFCNTOVF
$07ff0000 constant ETHERNET_MTL_MTLRXQMPOCR_MISPKTCNT               \ MISPKTCNT
$08000000 constant ETHERNET_MTL_MTLRXQMPOCR_MISCNTOVF               \ MISCNTOVF


\
\ @brief Rx queue debug register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MTL_MTLRXQDR_RWCSTS                     \ RWCSTS
$00000006 constant ETHERNET_MTL_MTLRXQDR_RRCSTS                     \ RRCSTS
$00000030 constant ETHERNET_MTL_MTLRXQDR_RXQSTS                     \ RXQSTS
$3fff0000 constant ETHERNET_MTL_MTLRXQDR_PRXQ                       \ PRXQ


\
\ @brief Ethernet: MTL mode register (MTL)
\
$40028c00 constant ETHERNET_MTL_MTLOMR  \ offset: 0x00 : Operating mode Register
$40028c20 constant ETHERNET_MTL_MTLISR  \ offset: 0x20 : Interrupt status Register
$40028d00 constant ETHERNET_MTL_MTLTXQOMR  \ offset: 0x100 : Tx queue operating mode Register
$40028d04 constant ETHERNET_MTL_MTLTXQUR  \ offset: 0x104 : Tx queue underflow register
$40028d08 constant ETHERNET_MTL_MTLTXQDR  \ offset: 0x108 : Tx queue debug Register
$40028d2c constant ETHERNET_MTL_MTLQICSR  \ offset: 0x12C : Queue interrupt control status Register
$40028d30 constant ETHERNET_MTL_MTLRXQOMR  \ offset: 0x130 : Rx queue operating mode register
$40028d34 constant ETHERNET_MTL_MTLRXQMPOCR  \ offset: 0x134 : Rx queue missed packet and overflow counter register
$40028d38 constant ETHERNET_MTL_MTLRXQDR  \ offset: 0x138 : Rx queue debug register

