\
\ @file ipcc.fs
\ @brief IPCC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Control register CPU1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant IPCC_C1CR_RXOIE                                  \ processor 1 Receive channel occupied interrupt enable
$00010000 constant IPCC_C1CR_TXFIE                                  \ processor 1 Transmit channel free interrupt enable


\
\ @brief Mask register CPU1
\ Address offset: 0x04
\ Reset value: 0xFFFFFFFF
\

$00000001 constant IPCC_C1MR_CH1OM                                  \ processor 1 Receive channel 1 occupied interrupt enable
$00000002 constant IPCC_C1MR_CH2OM                                  \ processor 1 Receive channel 2 occupied interrupt enable
$00000004 constant IPCC_C1MR_CH3OM                                  \ processor 1 Receive channel 3 occupied interrupt enable
$00000008 constant IPCC_C1MR_CH4OM                                  \ processor 1 Receive channel 4 occupied interrupt enable
$00000010 constant IPCC_C1MR_CH5OM                                  \ processor 1 Receive channel 5 occupied interrupt enable
$00000020 constant IPCC_C1MR_CH6OM                                  \ processor 1 Receive channel 6 occupied interrupt enable
$00010000 constant IPCC_C1MR_CH1FM                                  \ processor 1 Transmit channel 1 free interrupt mask
$00020000 constant IPCC_C1MR_CH2FM                                  \ processor 1 Transmit channel 2 free interrupt mask
$00040000 constant IPCC_C1MR_CH3FM                                  \ processor 1 Transmit channel 3 free interrupt mask
$00080000 constant IPCC_C1MR_CH4FM                                  \ processor 1 Transmit channel 4 free interrupt mask
$00100000 constant IPCC_C1MR_CH5FM                                  \ processor 1 Transmit channel 5 free interrupt mask
$00200000 constant IPCC_C1MR_CH6FM                                  \ processor 1 Transmit channel 6 free interrupt mask


\
\ @brief Status Set or Clear register CPU1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant IPCC_C1SCR_CH1C                                  \ processor 1 Receive channel 1 status clear
$00000002 constant IPCC_C1SCR_CH2C                                  \ processor 1 Receive channel 2 status clear
$00000004 constant IPCC_C1SCR_CH3C                                  \ processor 1 Receive channel 3 status clear
$00000008 constant IPCC_C1SCR_CH4C                                  \ processor 1 Receive channel 4 status clear
$00000010 constant IPCC_C1SCR_CH5C                                  \ processor 1 Receive channel 5 status clear
$00000020 constant IPCC_C1SCR_CH6C                                  \ processor 1 Receive channel 6 status clear
$00010000 constant IPCC_C1SCR_CH1S                                  \ processor 1 Transmit channel 1 status set
$00020000 constant IPCC_C1SCR_CH2S                                  \ processor 1 Transmit channel 2 status set
$00040000 constant IPCC_C1SCR_CH3S                                  \ processor 1 Transmit channel 3 status set
$00080000 constant IPCC_C1SCR_CH4S                                  \ processor 1 Transmit channel 4 status set
$00100000 constant IPCC_C1SCR_CH5S                                  \ processor 1 Transmit channel 5 status set
$00200000 constant IPCC_C1SCR_CH6S                                  \ processor 1 Transmit channel 6 status set


\
\ @brief CPU1 to CPU2 status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant IPCC_C1TO2SR_CH1F                                \ processor 1 transmit to process 2 Receive channel 1 status flag
$00000002 constant IPCC_C1TO2SR_CH2F                                \ processor 1 transmit to process 2 Receive channel 2 status flag
$00000004 constant IPCC_C1TO2SR_CH3F                                \ processor 1 transmit to process 2 Receive channel 3 status flag
$00000008 constant IPCC_C1TO2SR_CH4F                                \ processor 1 transmit to process 2 Receive channel 4 status flag
$00000010 constant IPCC_C1TO2SR_CH5F                                \ processor 1 transmit to process 2 Receive channel 5 status flag
$00000020 constant IPCC_C1TO2SR_CH6F                                \ processor 1 transmit to process 2 Receive channel 6 status flag


\
\ @brief Control register CPU2
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant IPCC_C2CR_RXOIE                                  \ processor 2 Receive channel occupied interrupt enable
$00010000 constant IPCC_C2CR_TXFIE                                  \ processor 2 Transmit channel free interrupt enable


\
\ @brief Mask register CPU2
\ Address offset: 0x14
\ Reset value: 0xFFFFFFFF
\

$00000001 constant IPCC_C2MR_CH1OM                                  \ processor 2 Receive channel 1 occupied interrupt enable
$00000002 constant IPCC_C2MR_CH2OM                                  \ processor 2 Receive channel 2 occupied interrupt enable
$00000004 constant IPCC_C2MR_CH3OM                                  \ processor 2 Receive channel 3 occupied interrupt enable
$00000008 constant IPCC_C2MR_CH4OM                                  \ processor 2 Receive channel 4 occupied interrupt enable
$00000010 constant IPCC_C2MR_CH5OM                                  \ processor 2 Receive channel 5 occupied interrupt enable
$00000020 constant IPCC_C2MR_CH6OM                                  \ processor 2 Receive channel 6 occupied interrupt enable
$00010000 constant IPCC_C2MR_CH1FM                                  \ processor 2 Transmit channel 1 free interrupt mask
$00020000 constant IPCC_C2MR_CH2FM                                  \ processor 2 Transmit channel 2 free interrupt mask
$00040000 constant IPCC_C2MR_CH3FM                                  \ processor 2 Transmit channel 3 free interrupt mask
$00080000 constant IPCC_C2MR_CH4FM                                  \ processor 2 Transmit channel 4 free interrupt mask
$00100000 constant IPCC_C2MR_CH5FM                                  \ processor 2 Transmit channel 5 free interrupt mask
$00200000 constant IPCC_C2MR_CH6FM                                  \ processor 2 Transmit channel 6 free interrupt mask


\
\ @brief Status Set or Clear register CPU2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant IPCC_C2SCR_CH1C                                  \ processor 2 Receive channel 1 status clear
$00000002 constant IPCC_C2SCR_CH2C                                  \ processor 2 Receive channel 2 status clear
$00000004 constant IPCC_C2SCR_CH3C                                  \ processor 2 Receive channel 3 status clear
$00000008 constant IPCC_C2SCR_CH4C                                  \ processor 2 Receive channel 4 status clear
$00000010 constant IPCC_C2SCR_CH5C                                  \ processor 2 Receive channel 5 status clear
$00000020 constant IPCC_C2SCR_CH6C                                  \ processor 2 Receive channel 6 status clear
$00010000 constant IPCC_C2SCR_CH1S                                  \ processor 2 Transmit channel 1 status set
$00020000 constant IPCC_C2SCR_CH2S                                  \ processor 2 Transmit channel 2 status set
$00040000 constant IPCC_C2SCR_CH3S                                  \ processor 2 Transmit channel 3 status set
$00080000 constant IPCC_C2SCR_CH4S                                  \ processor 2 Transmit channel 4 status set
$00100000 constant IPCC_C2SCR_CH5S                                  \ processor 2 Transmit channel 5 status set
$00200000 constant IPCC_C2SCR_CH6S                                  \ processor 2 Transmit channel 6 status set


\
\ @brief CPU2 to CPU1 status register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant IPCC_C2TOC1SR_CH1F                               \ processor 2 transmit to process 1 Receive channel 1 status flag
$00000002 constant IPCC_C2TOC1SR_CH2F                               \ processor 2 transmit to process 1 Receive channel 2 status flag
$00000004 constant IPCC_C2TOC1SR_CH3F                               \ processor 2 transmit to process 1 Receive channel 3 status flag
$00000008 constant IPCC_C2TOC1SR_CH4F                               \ processor 2 transmit to process 1 Receive channel 4 status flag
$00000010 constant IPCC_C2TOC1SR_CH5F                               \ processor 2 transmit to process 1 Receive channel 5 status flag
$00000020 constant IPCC_C2TOC1SR_CH6F                               \ processor 2 transmit to process 1 Receive channel 6 status flag


\
\ @brief IPCC
\
$58000c00 constant IPCC_C1CR      \ offset: 0x00 : Control register CPU1
$58000c04 constant IPCC_C1MR      \ offset: 0x04 : Mask register CPU1
$58000c08 constant IPCC_C1SCR     \ offset: 0x08 : Status Set or Clear register CPU1
$58000c0c constant IPCC_C1TO2SR   \ offset: 0x0C : CPU1 to CPU2 status register
$58000c10 constant IPCC_C2CR      \ offset: 0x10 : Control register CPU2
$58000c14 constant IPCC_C2MR      \ offset: 0x14 : Mask register CPU2
$58000c18 constant IPCC_C2SCR     \ offset: 0x18 : Status Set or Clear register CPU2
$58000c1c constant IPCC_C2TOC1SR  \ offset: 0x1C : CPU2 to CPU1 status register

