\
\ @file eth_mtl.fs
\ @brief ETH_MTL
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief The Operating Mode register establishes the Transmit and Receive operating modes and commands.
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000002 constant ETH_MTL_ETH_MTLOMR_DTXSTS                        \ DTXSTS
$00000004 constant ETH_MTL_ETH_MTLOMR_RAA                           \ RAA
$00000060 constant ETH_MTL_ETH_MTLOMR_SCHALG                        \ SCHALG
$00000100 constant ETH_MTL_ETH_MTLOMR_CNTPRST                       \ CNTPRST
$00000200 constant ETH_MTL_ETH_MTLOMR_CNTCLR                        \ CNTCLR


\
\ @brief The software driver (application) reads this register during interrupt service routine or polling to determine the interrupt status of MTL queues and the MAC.
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant ETH_MTL_ETH_MTLISR_Q0IS                          \ Q0IS
$00000002 constant ETH_MTL_ETH_MTLISR_Q1IS                          \ Q1IS


\
\ @brief Tx queue 0 operating mode Register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant ETH_MTL_ETH_MTLTXQ0OMR_FTQ                       \ FTQ
$00000002 constant ETH_MTL_ETH_MTLTXQ0OMR_TSF                       \ TSF
$0000000c constant ETH_MTL_ETH_MTLTXQ0OMR_TXQEN                     \ TXQEN
$00000030 constant ETH_MTL_ETH_MTLTXQ0OMR_TTC                       \ TTC
$01ff0000 constant ETH_MTL_ETH_MTLTXQ0OMR_TQS                       \ TQS


\
\ @brief Tx queue 0 underflow register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$000007ff constant ETH_MTL_ETH_MTLTXQ0UR_UFFRMCNT                   \ UFFRMCNT
$00000800 constant ETH_MTL_ETH_MTLTXQ0UR_UFCNTOVF                   \ UFCNTOVF


\
\ @brief Tx queue 0 underflow register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant ETH_MTL_ETH_MTLTXQ0DR_TXQPAUSED                  \ TXQPAUSED
$00000006 constant ETH_MTL_ETH_MTLTXQ0DR_TRCSTS                     \ TRCSTS
$00000008 constant ETH_MTL_ETH_MTLTXQ0DR_TWCSTS                     \ TWCSTS
$00000010 constant ETH_MTL_ETH_MTLTXQ0DR_TXQSTS                     \ TXQSTS
$00000020 constant ETH_MTL_ETH_MTLTXQ0DR_TXSTSFSTS                  \ TXSTSFSTS
$00070000 constant ETH_MTL_ETH_MTLTXQ0DR_PTXQ                       \ PTXQ
$00700000 constant ETH_MTL_ETH_MTLTXQ0DR_STXSTSF                    \ STXSTSF


\
\ @brief Tx queue x ETS status Register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00ffffff constant ETH_MTL_ETH_MTLTXQ0ESR_ABS                       \ ABS


\
\ @brief Queue 0 interrupt control status Register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000001 constant ETH_MTL_ETH_MTLQ0ICSR_TXUNFIS                    \ TXUNFIS
$00000002 constant ETH_MTL_ETH_MTLQ0ICSR_ABPSIS                     \ ABPSIS
$00000100 constant ETH_MTL_ETH_MTLQ0ICSR_TXUIE                      \ TXUIE
$00000200 constant ETH_MTL_ETH_MTLQ0ICSR_ABPSIE                     \ ABPSIE
$00010000 constant ETH_MTL_ETH_MTLQ0ICSR_RXOVFIS                    \ RXOVFIS
$01000000 constant ETH_MTL_ETH_MTLQ0ICSR_RXOIE                      \ RXOIE


\
\ @brief Rx queue 0 operating mode register
\ Address offset: 0x130
\ Reset value: 0x00700000
\

$00000003 constant ETH_MTL_ETH_MTLRXQ0OMR_RTC                       \ RTC
$00000008 constant ETH_MTL_ETH_MTLRXQ0OMR_FUP                       \ FUP
$00000010 constant ETH_MTL_ETH_MTLRXQ0OMR_FEP                       \ FEP
$00000020 constant ETH_MTL_ETH_MTLRXQ0OMR_RSF                       \ RSF
$00000040 constant ETH_MTL_ETH_MTLRXQ0OMR_DIS_TCP_EF                \ DIS_TCP_EF
$00000080 constant ETH_MTL_ETH_MTLRXQ0OMR_EHFC                      \ EHFC
$00000700 constant ETH_MTL_ETH_MTLRXQ0OMR_RFA                       \ RFA
$0001c000 constant ETH_MTL_ETH_MTLRXQ0OMR_RFD                       \ RFD
$00f00000 constant ETH_MTL_ETH_MTLRXQ0OMR_RQS                       \ RQS


\
\ @brief Rx queue 0 missed packet and overflow counter register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$000007ff constant ETH_MTL_ETH_MTLRXQ0MPOCR_OVFPKTCNT               \ OVFPKTCNT
$00000800 constant ETH_MTL_ETH_MTLRXQ0MPOCR_OVFCNTOVF               \ OVFCNTOVF
$07ff0000 constant ETH_MTL_ETH_MTLRXQ0MPOCR_MISPKTCNT               \ MISPKTCNT
$08000000 constant ETH_MTL_ETH_MTLRXQ0MPOCR_MISCNTOVF               \ MISCNTOVF


\
\ @brief Rx queue i debug register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$00000001 constant ETH_MTL_ETH_MTLRXQ0DR_RWCSTS                     \ RWCSTS
$00000006 constant ETH_MTL_ETH_MTLRXQ0DR_RRCSTS                     \ RRCSTS
$00000030 constant ETH_MTL_ETH_MTLRXQ0DR_RXQSTS                     \ RXQSTS
$3fff0000 constant ETH_MTL_ETH_MTLRXQ0DR_PRXQ                       \ PRXQ


\
\ @brief Rx queue 0 control register
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$00000007 constant ETH_MTL_ETH_MTLRXQ0CR_RXQ_WEGT                   \ RXQ_WEGT
$00000008 constant ETH_MTL_ETH_MTLRXQ0CR_RXQ_FRM_ARBIT              \ RXQ_FRM_ARBIT


\
\ @brief Tx queue 1 operating mode Register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000001 constant ETH_MTL_ETH_MTLTXQ1OMR_FTQ                       \ FTQ
$00000002 constant ETH_MTL_ETH_MTLTXQ1OMR_TSF                       \ TSF
$0000000c constant ETH_MTL_ETH_MTLTXQ1OMR_TXQEN                     \ TXQEN
$00000030 constant ETH_MTL_ETH_MTLTXQ1OMR_TTC                       \ TTC
$01ff0000 constant ETH_MTL_ETH_MTLTXQ1OMR_TQS                       \ TQS


\
\ @brief Tx queue 1 underflow register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$000007ff constant ETH_MTL_ETH_MTLTXQ1UR_UFFRMCNT                   \ UFFRMCNT
$00000800 constant ETH_MTL_ETH_MTLTXQ1UR_UFCNTOVF                   \ UFCNTOVF


\
\ @brief Tx queue 1 underflow register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000001 constant ETH_MTL_ETH_MTLTXQ1DR_TXQPAUSED                  \ TXQPAUSED
$00000006 constant ETH_MTL_ETH_MTLTXQ1DR_TRCSTS                     \ TRCSTS
$00000008 constant ETH_MTL_ETH_MTLTXQ1DR_TWCSTS                     \ TWCSTS
$00000010 constant ETH_MTL_ETH_MTLTXQ1DR_TXQSTS                     \ TXQSTS
$00000020 constant ETH_MTL_ETH_MTLTXQ1DR_TXSTSFSTS                  \ TXSTSFSTS
$00070000 constant ETH_MTL_ETH_MTLTXQ1DR_PTXQ                       \ PTXQ
$00700000 constant ETH_MTL_ETH_MTLTXQ1DR_STXSTSF                    \ STXSTSF


\
\ @brief The Queue ETS Control register controls the enhanced transmission selection operation.
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000004 constant ETH_MTL_ETH_MTLTXQ1ECR_AVALG                     \ AVALG
$00000008 constant ETH_MTL_ETH_MTLTXQ1ECR_CC                        \ CC
$00000070 constant ETH_MTL_ETH_MTLTXQ1ECR_SLC                       \ SLC


\
\ @brief Tx queue x ETS status Register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00ffffff constant ETH_MTL_ETH_MTLTXQ1ESR_ABS                       \ ABS


\
\ @brief This register provides the average traffic transmitted on queue 1.
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$001fffff constant ETH_MTL_ETH_MTLTXQ1QWR_ISCQW                     \ ISCQW


\
\ @brief The sendSlopeCredit register contains the sendSlope credit value required for the credit-based shaper algorithm for the Queue.
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00003fff constant ETH_MTL_ETH_MTLTXQ1SSCR_SSC                      \ SSC


\
\ @brief The hiCredit register contains the hiCredit value required for the credit-based shaper algorithm for the Queue.
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$1fffffff constant ETH_MTL_ETH_MTLTXQ1HCR_HC                        \ HC


\
\ @brief The loCredit register contains the loCredit value required for the credit-based shaper algorithm for the Queue.
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$1fffffff constant ETH_MTL_ETH_MTLTXQ1LCR_LC                        \ LC


\
\ @brief Queue 1 interrupt control status Register
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$00000001 constant ETH_MTL_ETH_MTLQ1ICSR_TXUNFIS                    \ TXUNFIS
$00000002 constant ETH_MTL_ETH_MTLQ1ICSR_ABPSIS                     \ ABPSIS
$00000100 constant ETH_MTL_ETH_MTLQ1ICSR_TXUIE                      \ TXUIE
$00000200 constant ETH_MTL_ETH_MTLQ1ICSR_ABPSIE                     \ ABPSIE
$00010000 constant ETH_MTL_ETH_MTLQ1ICSR_RXOVFIS                    \ RXOVFIS
$01000000 constant ETH_MTL_ETH_MTLQ1ICSR_RXOIE                      \ RXOIE


\
\ @brief Rx queue 1 operating mode register
\ Address offset: 0x170
\ Reset value: 0x00700000
\

$00000003 constant ETH_MTL_ETH_MTLRXQ1OMR_RTC                       \ RTC
$00000008 constant ETH_MTL_ETH_MTLRXQ1OMR_FUP                       \ FUP
$00000010 constant ETH_MTL_ETH_MTLRXQ1OMR_FEP                       \ FEP
$00000020 constant ETH_MTL_ETH_MTLRXQ1OMR_RSF                       \ RSF
$00000040 constant ETH_MTL_ETH_MTLRXQ1OMR_DIS_TCP_EF                \ DIS_TCP_EF
$00000080 constant ETH_MTL_ETH_MTLRXQ1OMR_EHFC                      \ EHFC
$00000700 constant ETH_MTL_ETH_MTLRXQ1OMR_RFA                       \ RFA
$0001c000 constant ETH_MTL_ETH_MTLRXQ1OMR_RFD                       \ RFD
$00f00000 constant ETH_MTL_ETH_MTLRXQ1OMR_RQS                       \ RQS


\
\ @brief Rx queue 1 missed packet and overflow counter register
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$000007ff constant ETH_MTL_ETH_MTLRXQ1MPOCR_OVFPKTCNT               \ OVFPKTCNT
$00000800 constant ETH_MTL_ETH_MTLRXQ1MPOCR_OVFCNTOVF               \ OVFCNTOVF
$07ff0000 constant ETH_MTL_ETH_MTLRXQ1MPOCR_MISPKTCNT               \ MISPKTCNT
$08000000 constant ETH_MTL_ETH_MTLRXQ1MPOCR_MISCNTOVF               \ MISCNTOVF


\
\ @brief Rx queue i debug register
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$00000001 constant ETH_MTL_ETH_MTLRXQ1DR_RWCSTS                     \ RWCSTS
$00000006 constant ETH_MTL_ETH_MTLRXQ1DR_RRCSTS                     \ RRCSTS
$00000030 constant ETH_MTL_ETH_MTLRXQ1DR_RXQSTS                     \ RXQSTS
$3fff0000 constant ETH_MTL_ETH_MTLRXQ1DR_PRXQ                       \ PRXQ


\
\ @brief Rx queue 1 control register
\ Address offset: 0x17C
\ Reset value: 0x00000000
\

$00000007 constant ETH_MTL_ETH_MTLRXQ1CR_RXQ_WEGT                   \ RXQ_WEGT
$00000008 constant ETH_MTL_ETH_MTLRXQ1CR_RXQ_FRM_ARBIT              \ RXQ_FRM_ARBIT


\
\ @brief ETH_MTL
\
$5800ac00 constant ETH_MTL_ETH_MTLOMR  \ offset: 0x00 : The Operating Mode register establishes the Transmit and Receive operating modes and commands.
$5800ac20 constant ETH_MTL_ETH_MTLISR  \ offset: 0x20 : The software driver (application) reads this register during interrupt service routine or polling to determine the interrupt status of MTL queues and the MAC.
$5800ad00 constant ETH_MTL_ETH_MTLTXQ0OMR  \ offset: 0x100 : Tx queue 0 operating mode Register
$5800ad04 constant ETH_MTL_ETH_MTLTXQ0UR  \ offset: 0x104 : Tx queue 0 underflow register
$5800ad08 constant ETH_MTL_ETH_MTLTXQ0DR  \ offset: 0x108 : Tx queue 0 underflow register
$5800ad14 constant ETH_MTL_ETH_MTLTXQ0ESR  \ offset: 0x114 : Tx queue x ETS status Register
$5800ad2c constant ETH_MTL_ETH_MTLQ0ICSR  \ offset: 0x12C : Queue 0 interrupt control status Register
$5800ad30 constant ETH_MTL_ETH_MTLRXQ0OMR  \ offset: 0x130 : Rx queue 0 operating mode register
$5800ad34 constant ETH_MTL_ETH_MTLRXQ0MPOCR  \ offset: 0x134 : Rx queue 0 missed packet and overflow counter register
$5800ad38 constant ETH_MTL_ETH_MTLRXQ0DR  \ offset: 0x138 : Rx queue i debug register
$5800ad3c constant ETH_MTL_ETH_MTLRXQ0CR  \ offset: 0x13C : Rx queue 0 control register
$5800ad40 constant ETH_MTL_ETH_MTLTXQ1OMR  \ offset: 0x140 : Tx queue 1 operating mode Register
$5800ad44 constant ETH_MTL_ETH_MTLTXQ1UR  \ offset: 0x144 : Tx queue 1 underflow register
$5800ad48 constant ETH_MTL_ETH_MTLTXQ1DR  \ offset: 0x148 : Tx queue 1 underflow register
$5800ad50 constant ETH_MTL_ETH_MTLTXQ1ECR  \ offset: 0x150 : The Queue ETS Control register controls the enhanced transmission selection operation.
$5800ad54 constant ETH_MTL_ETH_MTLTXQ1ESR  \ offset: 0x154 : Tx queue x ETS status Register
$5800ad58 constant ETH_MTL_ETH_MTLTXQ1QWR  \ offset: 0x158 : This register provides the average traffic transmitted on queue 1.
$5800ad5c constant ETH_MTL_ETH_MTLTXQ1SSCR  \ offset: 0x15C : The sendSlopeCredit register contains the sendSlope credit value required for the credit-based shaper algorithm for the Queue.
$5800ad60 constant ETH_MTL_ETH_MTLTXQ1HCR  \ offset: 0x160 : The hiCredit register contains the hiCredit value required for the credit-based shaper algorithm for the Queue.
$5800ad64 constant ETH_MTL_ETH_MTLTXQ1LCR  \ offset: 0x164 : The loCredit register contains the loCredit value required for the credit-based shaper algorithm for the Queue.
$5800ad6c constant ETH_MTL_ETH_MTLQ1ICSR  \ offset: 0x16C : Queue 1 interrupt control status Register
$5800ad70 constant ETH_MTL_ETH_MTLRXQ1OMR  \ offset: 0x170 : Rx queue 1 operating mode register
$5800ad74 constant ETH_MTL_ETH_MTLRXQ1MPOCR  \ offset: 0x174 : Rx queue 1 missed packet and overflow counter register
$5800ad78 constant ETH_MTL_ETH_MTLRXQ1DR  \ offset: 0x178 : Rx queue i debug register
$5800ad7c constant ETH_MTL_ETH_MTLRXQ1CR  \ offset: 0x17C : Rx queue 1 control register

