\
\ @file swpmi.fs
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

$00000001 constant SWPMI_CR_RXDMA                                   \ Reception DMA enable
$00000002 constant SWPMI_CR_TXDMA                                   \ Transmission DMA enable
$00000004 constant SWPMI_CR_RXMODE                                  \ Reception buffering mode
$00000008 constant SWPMI_CR_TXMODE                                  \ Transmission buffering mode
$00000010 constant SWPMI_CR_LPBK                                    \ Loopback mode enable
$00000020 constant SWPMI_CR_SWPACT                                  \ Single wire protocol master interface activate
$00000400 constant SWPMI_CR_DEACT                                   \ Single wire protocol master interface deactivate
$00000800 constant SWPMI_CR_SWPTEN                                  \ Single wire protocol master transceiver enable


\
\ @brief SWPMI Bitrate register
\ Address offset: 0x04
\ Reset value: 0x00000001
\

$000000ff constant SWPMI_BRR_BR                                     \ Bitrate prescaler


\
\ @brief SWPMI Interrupt and Status register
\ Address offset: 0x0C
\ Reset value: 0x000002C2
\

$00000001 constant SWPMI_ISR_RXBFF                                  \ Receive buffer full flag
$00000002 constant SWPMI_ISR_TXBEF                                  \ Transmit buffer empty flag
$00000004 constant SWPMI_ISR_RXBERF                                 \ Receive CRC error flag
$00000008 constant SWPMI_ISR_RXOVRF                                 \ Receive overrun error flag
$00000010 constant SWPMI_ISR_TXUNRF                                 \ Transmit underrun error flag
$00000020 constant SWPMI_ISR_RXNE                                   \ Receive data register not empty
$00000040 constant SWPMI_ISR_TXE                                    \ Transmit data register empty
$00000080 constant SWPMI_ISR_TCF                                    \ Transfer complete flag
$00000100 constant SWPMI_ISR_SRF                                    \ Slave resume flag
$00000200 constant SWPMI_ISR_SUSP                                   \ SUSPEND flag
$00000400 constant SWPMI_ISR_DEACTF                                 \ DEACTIVATED flag
$00000800 constant SWPMI_ISR_RDYF                                   \ transceiver ready flag


\
\ @brief SWPMI Interrupt Flag Clear register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SWPMI_ICR_CRXBFF                                 \ Clear receive buffer full flag
$00000002 constant SWPMI_ICR_CTXBEF                                 \ Clear transmit buffer empty flag
$00000004 constant SWPMI_ICR_CRXBERF                                \ Clear receive CRC error flag
$00000008 constant SWPMI_ICR_CRXOVRF                                \ Clear receive overrun error flag
$00000010 constant SWPMI_ICR_CTXUNRF                                \ Clear transmit underrun error flag
$00000080 constant SWPMI_ICR_CTCF                                   \ Clear transfer complete flag
$00000100 constant SWPMI_ICR_CSRF                                   \ Clear slave resume flag
$00000800 constant SWPMI_ICR_CRDYF                                  \ Clear transceiver ready flag


\
\ @brief SWPMI Interrupt Enable register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SWPMI_IER_RXBFIE                                 \ Receive buffer full interrupt enable
$00000002 constant SWPMI_IER_TXBEIE                                 \ Transmit buffer empty interrupt enable
$00000004 constant SWPMI_IER_RXBERIE                                \ Receive CRC error interrupt enable
$00000008 constant SWPMI_IER_RXOVRIE                                \ Receive overrun error interrupt enable
$00000010 constant SWPMI_IER_TXUNRIE                                \ Transmit underrun error interrupt enable
$00000020 constant SWPMI_IER_RIE                                    \ Receive interrupt enable
$00000040 constant SWPMI_IER_TIE                                    \ Transmit interrupt enable
$00000080 constant SWPMI_IER_TCIE                                   \ Transmit complete interrupt enable
$00000100 constant SWPMI_IER_SRIE                                   \ Slave resume interrupt enable
$00000800 constant SWPMI_IER_RDYIE                                  \ Transceiver ready interrupt enable


\
\ @brief SWPMI Receive Frame Length register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000001f constant SWPMI_RFL_RFL                                    \ Receive frame length


\
\ @brief SWPMI Transmit data register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant SWPMI_TDR_TD                                     \ Transmit data


\
\ @brief SWPMI Receive data register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SWPMI_RDR_RD                                     \ received data


\
\ @brief SWPMI Option register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant SWPMI_OR_SWP_TBYP                                \ SWP transceiver bypass
$00000002 constant SWPMI_OR_SWP_CLASS                               \ SWP class selection


\
\ @brief Single Wire Protocol Master Interface
\
$40008800 constant SWPMI_CR       \ offset: 0x00 : SWPMI Configuration/Control register
$40008804 constant SWPMI_BRR      \ offset: 0x04 : SWPMI Bitrate register
$4000880c constant SWPMI_ISR      \ offset: 0x0C : SWPMI Interrupt and Status register
$40008810 constant SWPMI_ICR      \ offset: 0x10 : SWPMI Interrupt Flag Clear register
$40008814 constant SWPMI_IER      \ offset: 0x14 : SWPMI Interrupt Enable register
$40008818 constant SWPMI_RFL      \ offset: 0x18 : SWPMI Receive Frame Length register
$4000881c constant SWPMI_TDR      \ offset: 0x1C : SWPMI Transmit data register
$40008820 constant SWPMI_RDR      \ offset: 0x20 : SWPMI Receive data register
$40008824 constant SWPMI_OR       \ offset: 0x24 : SWPMI Option register

