\
\ @file swpmi1.fs
\ @brief Single Wire Protocol Master       Interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SWPMI Configuration/Control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SWPMI1_CR_RXDMA                                  \ Reception DMA enable
$00000002 constant SWPMI1_CR_TXDMA                                  \ Transmission DMA enable
$00000004 constant SWPMI1_CR_RXMODE                                 \ Reception buffering mode
$00000008 constant SWPMI1_CR_TXMODE                                 \ Transmission buffering mode
$00000010 constant SWPMI1_CR_LPBK                                   \ Loopback mode enable
$00000020 constant SWPMI1_CR_SWPME                                  \ Single wire protocol master interface enable
$00000400 constant SWPMI1_CR_DEACT                                  \ Single wire protocol master interface deactivate


\
\ @brief SWPMI Bitrate register
\ Address offset: 0x04
\ Reset value: 0x00000001
\

$0000003f constant SWPMI1_BRR_BR                                    \ Bitrate prescaler


\
\ @brief SWPMI Interrupt and Status register
\ Address offset: 0x0C
\ Reset value: 0x000002C2
\

$00000001 constant SWPMI1_ISR_RXBFF                                 \ Receive buffer full flag
$00000002 constant SWPMI1_ISR_TXBEF                                 \ Transmit buffer empty flag
$00000004 constant SWPMI1_ISR_RXBERF                                \ Receive CRC error flag
$00000008 constant SWPMI1_ISR_RXOVRF                                \ Receive overrun error flag
$00000010 constant SWPMI1_ISR_TXUNRF                                \ Transmit underrun error flag
$00000020 constant SWPMI1_ISR_RXNE                                  \ Receive data register not empty
$00000040 constant SWPMI1_ISR_TXE                                   \ Transmit data register empty
$00000080 constant SWPMI1_ISR_TCF                                   \ Transfer complete flag
$00000100 constant SWPMI1_ISR_SRF                                   \ Slave resume flag
$00000200 constant SWPMI1_ISR_SUSP                                  \ SUSPEND flag
$00000400 constant SWPMI1_ISR_DEACTF                                \ DEACTIVATED flag


\
\ @brief SWPMI Interrupt Flag Clear register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SWPMI1_ICR_CRXBFF                                \ Clear receive buffer full flag
$00000002 constant SWPMI1_ICR_CTXBEF                                \ Clear transmit buffer empty flag
$00000004 constant SWPMI1_ICR_CRXBERF                               \ Clear receive CRC error flag
$00000008 constant SWPMI1_ICR_CRXOVRF                               \ Clear receive overrun error flag
$00000010 constant SWPMI1_ICR_CTXUNRF                               \ Clear transmit underrun error flag
$00000080 constant SWPMI1_ICR_CTCF                                  \ Clear transfer complete flag
$00000100 constant SWPMI1_ICR_CSRF                                  \ Clear slave resume flag


\
\ @brief SWPMI Interrupt Enable register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SWPMI1_IER_RXBFIE                                \ Receive buffer full interrupt enable
$00000002 constant SWPMI1_IER_TXBEIE                                \ Transmit buffer empty interrupt enable
$00000004 constant SWPMI1_IER_RXBERIE                               \ Receive CRC error interrupt enable
$00000008 constant SWPMI1_IER_RXOVRIE                               \ Receive overrun error interrupt enable
$00000010 constant SWPMI1_IER_TXUNRIE                               \ Transmit underrun error interrupt enable
$00000020 constant SWPMI1_IER_RIE                                   \ Receive interrupt enable
$00000040 constant SWPMI1_IER_TIE                                   \ Transmit interrupt enable
$00000080 constant SWPMI1_IER_TCIE                                  \ Transmit complete interrupt enable
$00000100 constant SWPMI1_IER_SRIE                                  \ Slave resume interrupt enable


\
\ @brief SWPMI Receive Frame Length register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000001f constant SWPMI1_RFL_RFL                                   \ Receive frame length


\
\ @brief SWPMI Transmit data register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant SWPMI1_TDR_TD                                    \ Transmit data


\
\ @brief SWPMI Receive data register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SWPMI1_RDR_RD                                    \ received data


\
\ @brief SWPMI Option register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant SWPMI1_OR_SWP_TBYP                               \ SWP transceiver bypass
$00000002 constant SWPMI1_OR_SWP_CLASS                              \ SWP class selection


\
\ @brief Single Wire Protocol Master Interface
\
$40008800 constant SWPMI1_CR      \ offset: 0x00 : SWPMI Configuration/Control register
$40008804 constant SWPMI1_BRR     \ offset: 0x04 : SWPMI Bitrate register
$4000880c constant SWPMI1_ISR     \ offset: 0x0C : SWPMI Interrupt and Status register
$40008810 constant SWPMI1_ICR     \ offset: 0x10 : SWPMI Interrupt Flag Clear register
$40008814 constant SWPMI1_IER     \ offset: 0x14 : SWPMI Interrupt Enable register
$40008818 constant SWPMI1_RFL     \ offset: 0x18 : SWPMI Receive Frame Length register
$4000881c constant SWPMI1_TDR     \ offset: 0x1C : SWPMI Transmit data register
$40008820 constant SWPMI1_RDR     \ offset: 0x20 : SWPMI Receive data register
$40008824 constant SWPMI1_OR      \ offset: 0x24 : SWPMI Option register

