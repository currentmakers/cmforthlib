\
\ @file pssi.fs
\ @brief Parallel synchronous slave interface
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

$00000020 constant PSSI_PSSI_CR_CKPOL                               \ Parallel data clock polarity This bit configures the capture edge of the parallel clock or the edge used for driving outputs, depending on OUTEN.
$00000040 constant PSSI_PSSI_CR_DEPOL                               \ Data enable (PSSI_DE) polarity This bit indicates the level on the PSSI_DE pin when the data are not valid on the parallel interface.
$00000100 constant PSSI_PSSI_CR_RDYPOL                              \ Ready (PSSI_RDY) polarity This bit indicates the level on the PSSI_RDY pin when the data are not valid on the parallel interface.
$00000c00 constant PSSI_PSSI_CR_EDM                                 \ Extended data mode
$00004000 constant PSSI_PSSI_CR_ENABLE                              \ PSSI enable The contents of the FIFO are flushed when ENABLE is cleared to 0. Note: When ENABLE=1, the content of PSSI_CR must not be changed, except for the ENABLE bit itself. All configuration bits can change as soon as ENABLE changes from 0 to 1. Note: The DMA controller and all PSSI configuration registers must be programmed correctly before setting the ENABLE bit to 1.
$001c0000 constant PSSI_PSSI_CR_DERDYCFG                            \ Data enable and ready configuration When the PSSI_RDY function is mapped to the PSSI_DE pin (settings 101 or 111), it is still the RDYPOL bit which determines its polarity. Similarly, when the PSSI_DE function is mapped to the PSSI_RDY pin (settings 110 or 111), it is still the DEPOL bit which determines its polarity.
$20000000 constant PSSI_PSSI_CR_CKSRC                               \ Clock source This bit configures the clock source of the PSSI_PDCK.
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

$00000002 constant PSSI_PSSI_RIS_OVR_RIS                            \ Data buffer overrun/underrun raw interrupt status This bit is cleared by writing a 1 to the OVR_ISC bit in PSSI_ICR.


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

$00000002 constant PSSI_PSSI_MIS_OVR_MIS                            \ Data buffer overrun/underrun masked interrupt status This bit is set to 1 only when PSSI_IER/OVR_IE and PSSI_RIS/OVR_RIS are both set to 1.


\
\ @brief PSSI interrupt clear register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000002 constant PSSI_PSSI_ICR_OVR_ISC                            \ Data buffer overrun/underrun interrupt status clear Writing this bit to 1 clears the OVR_RIS bit in PSSI_RIS.


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
\ @brief Parallel synchronous slave interface
\
$48000400 constant PSSI_PSSI_CR   \ offset: 0x00 : PSSI control register
$48000404 constant PSSI_PSSI_SR   \ offset: 0x04 : PSSI status register
$48000408 constant PSSI_PSSI_RIS  \ offset: 0x08 : PSSI raw interrupt status register
$4800040c constant PSSI_PSSI_IER  \ offset: 0x0C : PSSI interrupt enable register
$48000410 constant PSSI_PSSI_MIS  \ offset: 0x10 : PSSI masked interrupt status register
$48000414 constant PSSI_PSSI_ICR  \ offset: 0x14 : PSSI interrupt clear register
$48000428 constant PSSI_PSSI_DR   \ offset: 0x28 : PSSI data register

