\
\ @file spdif_rx.fs
\ @brief Receiver Interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant SPDIF_RX_CR_SPDIFEN                              \ Peripheral Block Enable
$00000004 constant SPDIF_RX_CR_RXDMAEN                              \ Receiver DMA ENable for data flow
$00000008 constant SPDIF_RX_CR_RXSTEO                               \ STerEO Mode
$00000030 constant SPDIF_RX_CR_DRFMT                                \ RX Data format
$00000040 constant SPDIF_RX_CR_PMSK                                 \ Mask Parity error bit
$00000080 constant SPDIF_RX_CR_VMSK                                 \ Mask of Validity bit
$00000100 constant SPDIF_RX_CR_CUMSK                                \ Mask of channel status and user bits
$00000200 constant SPDIF_RX_CR_PTMSK                                \ Mask of Preamble Type bits
$00000400 constant SPDIF_RX_CR_CBDMAEN                              \ Control Buffer DMA ENable for control flow
$00000800 constant SPDIF_RX_CR_CHSEL                                \ Channel Selection
$00003000 constant SPDIF_RX_CR_NBTR                                 \ Maximum allowed re-tries during synchronization phase
$00004000 constant SPDIF_RX_CR_WFA                                  \ Wait For Activity
$00070000 constant SPDIF_RX_CR_INSEL                                \ input selection


\
\ @brief Interrupt mask register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SPDIF_RX_IMR_RXNEIE                              \ RXNE interrupt enable
$00000002 constant SPDIF_RX_IMR_CSRNEIE                             \ Control Buffer Ready Interrupt Enable
$00000004 constant SPDIF_RX_IMR_PERRIE                              \ Parity error interrupt enable
$00000008 constant SPDIF_RX_IMR_OVRIE                               \ Overrun error Interrupt Enable
$00000010 constant SPDIF_RX_IMR_SBLKIE                              \ Synchronization Block Detected Interrupt Enable
$00000020 constant SPDIF_RX_IMR_SYNCDIE                             \ Synchronization Done
$00000040 constant SPDIF_RX_IMR_IFEIE                               \ Serial Interface Error Interrupt Enable


\
\ @brief Status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SPDIF_RX_SR_RXNE                                 \ Read data register not empty
$00000002 constant SPDIF_RX_SR_CSRNE                                \ Control Buffer register is not empty
$00000004 constant SPDIF_RX_SR_PERR                                 \ Parity error
$00000008 constant SPDIF_RX_SR_OVR                                  \ Overrun error
$00000010 constant SPDIF_RX_SR_SBD                                  \ Synchronization Block Detected
$00000020 constant SPDIF_RX_SR_SYNCD                                \ Synchronization Done
$00000040 constant SPDIF_RX_SR_FERR                                 \ Framing error
$00000080 constant SPDIF_RX_SR_SERR                                 \ Synchronization error
$00000100 constant SPDIF_RX_SR_TERR                                 \ Time-out error
$7fff0000 constant SPDIF_RX_SR_WIDTH5                               \ Duration of 5 symbols counted with SPDIF_CLK


\
\ @brief Interrupt Flag Clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000004 constant SPDIF_RX_IFCR_PERRCF                             \ Clears the Parity error flag
$00000008 constant SPDIF_RX_IFCR_OVRCF                              \ Clears the Overrun error flag
$00000010 constant SPDIF_RX_IFCR_SBDCF                              \ Clears the Synchronization Block Detected flag
$00000020 constant SPDIF_RX_IFCR_SYNCDCF                            \ Clears the Synchronization Done flag


\
\ @brief Data input register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00ffffff constant SPDIF_RX_DR_DR                                   \ Parity Error bit
$01000000 constant SPDIF_RX_DR_PE                                   \ Parity Error bit
$02000000 constant SPDIF_RX_DR_V                                    \ Validity bit
$04000000 constant SPDIF_RX_DR_U                                    \ User bit
$08000000 constant SPDIF_RX_DR_C                                    \ Channel Status bit
$30000000 constant SPDIF_RX_DR_PT                                   \ Preamble Type


\
\ @brief Channel Status register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant SPDIF_RX_CSR_USR                                 \ User data information
$00ff0000 constant SPDIF_RX_CSR_CS                                  \ Channel A status information
$01000000 constant SPDIF_RX_CSR_SOB                                 \ Start Of Block


\
\ @brief Debug Information register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00001fff constant SPDIF_RX_DIR_THI                                 \ Threshold HIGH
$1fff0000 constant SPDIF_RX_DIR_TLO                                 \ Threshold LOW


\
\ @brief Receiver Interface
\
$40004000 constant SPDIF_RX_CR    \ offset: 0x00 : Control register
$40004004 constant SPDIF_RX_IMR   \ offset: 0x04 : Interrupt mask register
$40004008 constant SPDIF_RX_SR    \ offset: 0x08 : Status register
$4000400c constant SPDIF_RX_IFCR  \ offset: 0x0C : Interrupt Flag Clear register
$40004010 constant SPDIF_RX_DR    \ offset: 0x10 : Data input register
$40004014 constant SPDIF_RX_CSR   \ offset: 0x14 : Channel Status register
$40004018 constant SPDIF_RX_DIR   \ offset: 0x18 : Debug Information register

