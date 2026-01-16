\
\ @file pssi.fs
\ @brief PSSI register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief PSSI control register
\ Address offset: 0x00
\ Reset value: 0x40000000
\

$00000020 constant PSSI_PSSI_CR_CKPOL                               \ Parallel data clock polarity
$00000040 constant PSSI_PSSI_CR_DEPOL                               \ Data enable (PSSI_DE) polarity
$00000100 constant PSSI_PSSI_CR_RDYPOL                              \ Ready (PSSI_RDY) polarity
$00000c00 constant PSSI_PSSI_CR_EDM                                 \ Extended data mode
$00004000 constant PSSI_PSSI_CR_ENABLE                              \ PSSI enable
$001c0000 constant PSSI_PSSI_CR_DERDYCFG                            \ Data enable and ready configuration
$40000000 constant PSSI_PSSI_CR_DMAEN                               \ DMA enable bit
$80000000 constant PSSI_PSSI_CR_OUTEN                               \ Data direction selection bit


\
\ @brief PSSI status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000004 constant PSSI_PSSI_SR_RTT4B                               \ FIFO is ready to transfer four bytes
$00000008 constant PSSI_PSSI_SR_RTT1B                               \ FIFO is ready to transfer one byte


\
\ @brief PSSI raw interrupt status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000002 constant PSSI_PSSI_RIS_OVR_RIS                            \ Data buffer overrun/underrun raw interrupt status


\
\ @brief PSSI interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000002 constant PSSI_PSSI_IER_OVR_IE                             \ Data buffer overrun/underrun interrupt enable


\
\ @brief PSSI masked interrupt status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000002 constant PSSI_PSSI_MIS_OVR_MIS                            \ Data buffer overrun/underrun masked interrupt status


\
\ @brief PSSI interrupt clear register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000002 constant PSSI_PSSI_ICR_OVR_ISC                            \ Data buffer overrun/underrun interrupt status clear


\
\ @brief PSSI data register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant PSSI_PSSI_DR_BYTE0                               \ Data byte 0
$0000ff00 constant PSSI_PSSI_DR_BYTE1                               \ Data byte 1
$00ff0000 constant PSSI_PSSI_DR_BYTE2                               \ Data byte 2
$ff000000 constant PSSI_PSSI_DR_BYTE3                               \ Data byte 3


\
\ @brief PSSI register block
\
$4202c400 constant PSSI_PSSI_CR   \ offset: 0x00 : PSSI control register
$4202c404 constant PSSI_PSSI_SR   \ offset: 0x04 : PSSI status register
$4202c408 constant PSSI_PSSI_RIS  \ offset: 0x08 : PSSI raw interrupt status register
$4202c40c constant PSSI_PSSI_IER  \ offset: 0x0C : PSSI interrupt enable register
$4202c410 constant PSSI_PSSI_MIS  \ offset: 0x10 : PSSI masked interrupt status register
$4202c414 constant PSSI_PSSI_ICR  \ offset: 0x14 : PSSI interrupt clear register
$4202c428 constant PSSI_PSSI_DR   \ offset: 0x28 : PSSI data register

