\
\ @file spdifrx.fs
\ @brief SPDIF receiver interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SPDIFRX control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant SPDIFRX_SPDIFRX_CR_SPDIFRXEN                     \ Peripheral block enable less than sup>(1) less than /sup>
$00000004 constant SPDIFRX_SPDIFRX_CR_RXDMAEN                       \ Receiver DMA enable for data flow less than sup>(1) less than /sup>
$00000008 constant SPDIFRX_SPDIFRX_CR_RXSTEO                        \ Stereo mode less than sup>(1) less than /sup>
$00000030 constant SPDIFRX_SPDIFRX_CR_DRFMT                         \ RX data format less than sup>(1) less than /sup>
$00000040 constant SPDIFRX_SPDIFRX_CR_PMSK                          \ Mask parity error bit less than sup>(1) less than /sup>
$00000080 constant SPDIFRX_SPDIFRX_CR_VMSK                          \ Mask of validity bit less than sup>(1) less than /sup>
$00000100 constant SPDIFRX_SPDIFRX_CR_CUMSK                         \ Mask of channel status and user bits less than sup>(1) less than /sup>
$00000200 constant SPDIFRX_SPDIFRX_CR_PTMSK                         \ Mask of preamble type bits less than sup>(1) less than /sup>
$00000400 constant SPDIFRX_SPDIFRX_CR_CBDMAEN                       \ Control buffer DMA enable for control flow less than sup>(1) less than /sup>
$00000800 constant SPDIFRX_SPDIFRX_CR_CHSEL                         \ Channel selection less than sup>(1) less than /sup>
$00003000 constant SPDIFRX_SPDIFRX_CR_NBTR                          \ Maximum allowed re-tries during synchronization phase less than sup>(1) less than /sup>
$00004000 constant SPDIFRX_SPDIFRX_CR_WFA                           \ Wait for activity less than sup>(1) less than /sup>
$00070000 constant SPDIFRX_SPDIFRX_CR_INSEL                         \ SPDIFRX input selection
$00100000 constant SPDIFRX_SPDIFRX_CR_CKSEN                         \ Symbol clock enable
$00200000 constant SPDIFRX_SPDIFRX_CR_CKSBKPEN                      \ Backup symbol clock enable


\
\ @brief SPDIFRX interrupt mask register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SPDIFRX_SPDIFRX_IMR_RXNEIE                       \ RXNE interrupt enable
$00000002 constant SPDIFRX_SPDIFRX_IMR_CSRNEIE                      \ Control buffer ready interrupt enable
$00000004 constant SPDIFRX_SPDIFRX_IMR_PERRIE                       \ Parity error interrupt enable
$00000008 constant SPDIFRX_SPDIFRX_IMR_OVRIE                        \ Overrun error interrupt enable
$00000010 constant SPDIFRX_SPDIFRX_IMR_SBLKIE                       \ Synchronization block detected interrupt enable
$00000020 constant SPDIFRX_SPDIFRX_IMR_SYNCDIE                      \ Synchronization done
$00000040 constant SPDIFRX_SPDIFRX_IMR_IFEIE                        \ Serial interface error interrupt enable


\
\ @brief SPDIFRX status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SPDIFRX_SPDIFRX_SR_RXNE                          \ Read data register not empty
$00000002 constant SPDIFRX_SPDIFRX_SR_CSRNE                         \ Control buffer register not empty
$00000004 constant SPDIFRX_SPDIFRX_SR_PERR                          \ Parity error
$00000008 constant SPDIFRX_SPDIFRX_SR_OVR                           \ Overrun error
$00000010 constant SPDIFRX_SPDIFRX_SR_SBD                           \ Synchronization block detected
$00000020 constant SPDIFRX_SPDIFRX_SR_SYNCD                         \ Synchronization done
$00000040 constant SPDIFRX_SPDIFRX_SR_FERR                          \ Framing error
$00000080 constant SPDIFRX_SPDIFRX_SR_SERR                          \ Synchronization error
$00000100 constant SPDIFRX_SPDIFRX_SR_TERR                          \ Time-out error
$7fff0000 constant SPDIFRX_SPDIFRX_SR_WIDTH5                        \ duration of 5 symbols counted with spdifrx_ker_ck


\
\ @brief SPDIFRX interrupt flag clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000004 constant SPDIFRX_SPDIFRX_IFCR_PERRCF                      \ clears the parity error flag
$00000008 constant SPDIFRX_SPDIFRX_IFCR_OVRCF                       \ clears the overrun error flag
$00000010 constant SPDIFRX_SPDIFRX_IFCR_SBDCF                       \ clears the synchronization block detected flag
$00000020 constant SPDIFRX_SPDIFRX_IFCR_SYNCDCF                     \ clears the synchronization done flag


\
\ @brief SPDIFRX data input register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00ffffff constant SPDIFRX_SPDIFRX_FMT0_DR_DR                       \ data value
$01000000 constant SPDIFRX_SPDIFRX_FMT0_DR_PE                       \ parity error bit
$02000000 constant SPDIFRX_SPDIFRX_FMT0_DR_V                        \ validity bit
$04000000 constant SPDIFRX_SPDIFRX_FMT0_DR_U                        \ user bit
$08000000 constant SPDIFRX_SPDIFRX_FMT0_DR_C                        \ channel status bit
$30000000 constant SPDIFRX_SPDIFRX_FMT0_DR_PT                       \ preamble type


\
\ @brief SPDIFRX data input register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SPDIFRX_SPDIFRX_FMT1_DR_PE                       \ parity error bit
$00000002 constant SPDIFRX_SPDIFRX_FMT1_DR_V                        \ validity bit
$00000004 constant SPDIFRX_SPDIFRX_FMT1_DR_U                        \ user bit
$00000008 constant SPDIFRX_SPDIFRX_FMT1_DR_C                        \ channel Status bit
$00000030 constant SPDIFRX_SPDIFRX_FMT1_DR_PT                       \ preamble type
$ffffff00 constant SPDIFRX_SPDIFRX_FMT1_DR_DR                       \ data value


\
\ @brief SPDIFRX data input register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant SPDIFRX_SPDIFRX_FMT2_DR_DRNL1                    \ data value
$ffff0000 constant SPDIFRX_SPDIFRX_FMT2_DR_DRNL2                    \ data value


\
\ @brief SPDIFRX channel status register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant SPDIFRX_SPDIFRX_CSR_USR                          \ user data information
$00ff0000 constant SPDIFRX_SPDIFRX_CSR_CS                           \ channel A status information
$01000000 constant SPDIFRX_SPDIFRX_CSR_SOB                          \ start of block


\
\ @brief SPDIFRX debug information register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00001fff constant SPDIFRX_SPDIFRX_DIR_THI                          \ threshold HIGH (THI = 2.5 x UI / T less than sub>spdifrx_ker_ck less than /sub>)
$1fff0000 constant SPDIFRX_SPDIFRX_DIR_TLO                          \ threshold LOW (TLO = 1.5 x UI / T less than sub>spdifrx_ker_ck less than /sub>)


\
\ @brief SPDIF receiver interface
\
$40004000 constant SPDIFRX_SPDIFRX_CR  \ offset: 0x00 : SPDIFRX control register
$40004004 constant SPDIFRX_SPDIFRX_IMR  \ offset: 0x04 : SPDIFRX interrupt mask register
$40004008 constant SPDIFRX_SPDIFRX_SR  \ offset: 0x08 : SPDIFRX status register
$4000400c constant SPDIFRX_SPDIFRX_IFCR  \ offset: 0x0C : SPDIFRX interrupt flag clear register
$40004010 constant SPDIFRX_SPDIFRX_FMT0_DR  \ offset: 0x10 : SPDIFRX data input register
$40004010 constant SPDIFRX_SPDIFRX_FMT1_DR  \ offset: 0x10 : SPDIFRX data input register
$40004010 constant SPDIFRX_SPDIFRX_FMT2_DR  \ offset: 0x10 : SPDIFRX data input register
$40004014 constant SPDIFRX_SPDIFRX_CSR  \ offset: 0x14 : SPDIFRX channel status register
$40004018 constant SPDIFRX_SPDIFRX_DIR  \ offset: 0x18 : SPDIFRX debug information register

