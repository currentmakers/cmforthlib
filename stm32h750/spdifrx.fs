\
\ @file spdifrx.fs
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

$00000003 constant SPDIFRX_CR_SPDIFRXEN                             \ Peripheral Block Enable
$00000004 constant SPDIFRX_CR_RXDMAEN                               \ Receiver DMA ENable for data flow
$00000008 constant SPDIFRX_CR_RXSTEO                                \ STerEO Mode
$00000030 constant SPDIFRX_CR_DRFMT                                 \ RX Data format
$00000040 constant SPDIFRX_CR_PMSK                                  \ Mask Parity error bit
$00000080 constant SPDIFRX_CR_VMSK                                  \ Mask of Validity bit
$00000100 constant SPDIFRX_CR_CUMSK                                 \ Mask of channel status and user bits
$00000200 constant SPDIFRX_CR_PTMSK                                 \ Mask of Preamble Type bits
$00000400 constant SPDIFRX_CR_CBDMAEN                               \ Control Buffer DMA ENable for control flow
$00000800 constant SPDIFRX_CR_CHSEL                                 \ Channel Selection
$00003000 constant SPDIFRX_CR_NBTR                                  \ Maximum allowed re-tries during synchronization phase
$00004000 constant SPDIFRX_CR_WFA                                   \ Wait For Activity
$00070000 constant SPDIFRX_CR_INSEL                                 \ input selection
$00100000 constant SPDIFRX_CR_CKSEN                                 \ Symbol Clock Enable
$00200000 constant SPDIFRX_CR_CKSBKPEN                              \ Backup Symbol Clock Enable


\
\ @brief Interrupt mask register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SPDIFRX_IMR_RXNEIE                               \ RXNE interrupt enable
$00000002 constant SPDIFRX_IMR_CSRNEIE                              \ Control Buffer Ready Interrupt Enable
$00000004 constant SPDIFRX_IMR_PERRIE                               \ Parity error interrupt enable
$00000008 constant SPDIFRX_IMR_OVRIE                                \ Overrun error Interrupt Enable
$00000010 constant SPDIFRX_IMR_SBLKIE                               \ Synchronization Block Detected Interrupt Enable
$00000020 constant SPDIFRX_IMR_SYNCDIE                              \ Synchronization Done
$00000040 constant SPDIFRX_IMR_IFEIE                                \ Serial Interface Error Interrupt Enable


\
\ @brief Status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SPDIFRX_SR_RXNE                                  \ Read data register not empty
$00000002 constant SPDIFRX_SR_CSRNE                                 \ Control Buffer register is not empty
$00000004 constant SPDIFRX_SR_PERR                                  \ Parity error
$00000008 constant SPDIFRX_SR_OVR                                   \ Overrun error
$00000010 constant SPDIFRX_SR_SBD                                   \ Synchronization Block Detected
$00000020 constant SPDIFRX_SR_SYNCD                                 \ Synchronization Done
$00000040 constant SPDIFRX_SR_FERR                                  \ Framing error
$00000080 constant SPDIFRX_SR_SERR                                  \ Synchronization error
$00000100 constant SPDIFRX_SR_TERR                                  \ Time-out error
$7fff0000 constant SPDIFRX_SR_WIDTH5                                \ Duration of 5 symbols counted with SPDIF_CLK


\
\ @brief Interrupt Flag Clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000004 constant SPDIFRX_IFCR_PERRCF                              \ Clears the Parity error flag
$00000008 constant SPDIFRX_IFCR_OVRCF                               \ Clears the Overrun error flag
$00000010 constant SPDIFRX_IFCR_SBDCF                               \ Clears the Synchronization Block Detected flag
$00000020 constant SPDIFRX_IFCR_SYNCDCF                             \ Clears the Synchronization Done flag


\
\ @brief Data input register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00ffffff constant SPDIFRX_DR_00_DR                                 \ Parity Error bit
$01000000 constant SPDIFRX_DR_00_PE                                 \ Parity Error bit
$02000000 constant SPDIFRX_DR_00_V                                  \ Validity bit
$04000000 constant SPDIFRX_DR_00_U                                  \ User bit
$08000000 constant SPDIFRX_DR_00_C                                  \ Channel Status bit
$30000000 constant SPDIFRX_DR_00_PT                                 \ Preamble Type


\
\ @brief Data input register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SPDIFRX_DR_01_PE                                 \ Parity Error bit
$00000002 constant SPDIFRX_DR_01_V                                  \ Validity bit
$00000004 constant SPDIFRX_DR_01_U                                  \ User bit
$00000008 constant SPDIFRX_DR_01_C                                  \ Channel Status bit
$00000030 constant SPDIFRX_DR_01_PT                                 \ Preamble Type
$ffffff00 constant SPDIFRX_DR_01_DR                                 \ Data value


\
\ @brief Data input register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant SPDIFRX_DR_10_DRNL1                              \ Data value
$ffff0000 constant SPDIFRX_DR_10_DRNL2                              \ Data value


\
\ @brief Channel Status register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant SPDIFRX_CSR_USR                                  \ User data information
$00ff0000 constant SPDIFRX_CSR_CS                                   \ Channel A status information
$01000000 constant SPDIFRX_CSR_SOB                                  \ Start Of Block


\
\ @brief Debug Information register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00001fff constant SPDIFRX_DIR_THI                                  \ Threshold HIGH
$1fff0000 constant SPDIFRX_DIR_TLO                                  \ Threshold LOW


\
\ @brief SPDIFRX version register
\ Address offset: 0x3F4
\ Reset value: 0x00000012
\

$0000000f constant SPDIFRX_VERR_MINREV                              \ Minor revision
$000000f0 constant SPDIFRX_VERR_MAJREV                              \ Major revision


\
\ @brief SPDIFRX identification register
\ Address offset: 0x3F8
\ Reset value: 0x00130041
\

$00000000 constant SPDIFRX_IDR_ID                                   \ SPDIFRX identifier


\
\ @brief SPDIFRX size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant SPDIFRX_SIDR_SID                                 \ Size identification


\
\ @brief Receiver Interface
\
$40004000 constant SPDIFRX_CR     \ offset: 0x00 : Control register
$40004004 constant SPDIFRX_IMR    \ offset: 0x04 : Interrupt mask register
$40004008 constant SPDIFRX_SR     \ offset: 0x08 : Status register
$4000400c constant SPDIFRX_IFCR   \ offset: 0x0C : Interrupt Flag Clear register
$40004010 constant SPDIFRX_DR_00  \ offset: 0x10 : Data input register
$40004010 constant SPDIFRX_DR_01  \ offset: 0x10 : Data input register
$40004010 constant SPDIFRX_DR_10  \ offset: 0x10 : Data input register
$40004014 constant SPDIFRX_CSR    \ offset: 0x14 : Channel Status register
$40004018 constant SPDIFRX_DIR    \ offset: 0x18 : Debug Information register
$400043f4 constant SPDIFRX_VERR   \ offset: 0x3F4 : SPDIFRX version register
$400043f8 constant SPDIFRX_IDR    \ offset: 0x3F8 : SPDIFRX identification register
$400043fc constant SPDIFRX_SIDR   \ offset: 0x3FC : SPDIFRX size identification register

