\
\ @file spdifrx.fs
\ @brief SPDIF receiver interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SPDIFRX_DEF

  [ifdef] SPDIFRX_SPDIFRX_CR_DEF
    \
    \ @brief SPDIFRX control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_SPDIFRXEN              \ [0x00 : 2] Peripheral block enable less than sup>(1) less than /sup>
    $02 constant SPDIFRX_RXDMAEN                \ [0x02] Receiver DMA enable for data flow less than sup>(1) less than /sup>
    $03 constant SPDIFRX_RXSTEO                 \ [0x03] Stereo mode less than sup>(1) less than /sup>
    $04 constant SPDIFRX_DRFMT                  \ [0x04 : 2] RX data format less than sup>(1) less than /sup>
    $06 constant SPDIFRX_PMSK                   \ [0x06] Mask parity error bit less than sup>(1) less than /sup>
    $07 constant SPDIFRX_VMSK                   \ [0x07] Mask of validity bit less than sup>(1) less than /sup>
    $08 constant SPDIFRX_CUMSK                  \ [0x08] Mask of channel status and user bits less than sup>(1) less than /sup>
    $09 constant SPDIFRX_PTMSK                  \ [0x09] Mask of preamble type bits less than sup>(1) less than /sup>
    $0a constant SPDIFRX_CBDMAEN                \ [0x0a] Control buffer DMA enable for control flow less than sup>(1) less than /sup>
    $0b constant SPDIFRX_CHSEL                  \ [0x0b] Channel selection less than sup>(1) less than /sup>
    $0c constant SPDIFRX_NBTR                   \ [0x0c : 2] Maximum allowed re-tries during synchronization phase less than sup>(1) less than /sup>
    $0e constant SPDIFRX_WFA                    \ [0x0e] Wait for activity less than sup>(1) less than /sup>
    $10 constant SPDIFRX_INSEL                  \ [0x10 : 3] SPDIFRX input selection
    $14 constant SPDIFRX_CKSEN                  \ [0x14] Symbol clock enable
    $15 constant SPDIFRX_CKSBKPEN               \ [0x15] Backup symbol clock enable
  [then]


  [ifdef] SPDIFRX_SPDIFRX_IMR_DEF
    \
    \ @brief SPDIFRX interrupt mask register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_RXNEIE                 \ [0x00] RXNE interrupt enable
    $01 constant SPDIFRX_CSRNEIE                \ [0x01] Control buffer ready interrupt enable
    $02 constant SPDIFRX_PERRIE                 \ [0x02] Parity error interrupt enable
    $03 constant SPDIFRX_OVRIE                  \ [0x03] Overrun error interrupt enable
    $04 constant SPDIFRX_SBLKIE                 \ [0x04] Synchronization block detected interrupt enable
    $05 constant SPDIFRX_SYNCDIE                \ [0x05] Synchronization done
    $06 constant SPDIFRX_IFEIE                  \ [0x06] Serial interface error interrupt enable
  [then]


  [ifdef] SPDIFRX_SPDIFRX_SR_DEF
    \
    \ @brief SPDIFRX status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_RXNE                   \ [0x00] Read data register not empty
    $01 constant SPDIFRX_CSRNE                  \ [0x01] Control buffer register not empty
    $02 constant SPDIFRX_PERR                   \ [0x02] Parity error
    $03 constant SPDIFRX_OVR                    \ [0x03] Overrun error
    $04 constant SPDIFRX_SBD                    \ [0x04] Synchronization block detected
    $05 constant SPDIFRX_SYNCD                  \ [0x05] Synchronization done
    $06 constant SPDIFRX_FERR                   \ [0x06] Framing error
    $07 constant SPDIFRX_SERR                   \ [0x07] Synchronization error
    $08 constant SPDIFRX_TERR                   \ [0x08] Time-out error
    $10 constant SPDIFRX_WIDTH5                 \ [0x10 : 15] duration of 5 symbols counted with spdifrx_ker_ck
  [then]


  [ifdef] SPDIFRX_SPDIFRX_IFCR_DEF
    \
    \ @brief SPDIFRX interrupt flag clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $02 constant SPDIFRX_PERRCF                 \ [0x02] clears the parity error flag
    $03 constant SPDIFRX_OVRCF                  \ [0x03] clears the overrun error flag
    $04 constant SPDIFRX_SBDCF                  \ [0x04] clears the synchronization block detected flag
    $05 constant SPDIFRX_SYNCDCF                \ [0x05] clears the synchronization done flag
  [then]


  [ifdef] SPDIFRX_SPDIFRX_FMT0_DR_DEF
    \
    \ @brief SPDIFRX data input register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_DR                     \ [0x00 : 24] data value
    $18 constant SPDIFRX_PE                     \ [0x18] parity error bit
    $19 constant SPDIFRX_V                      \ [0x19] validity bit
    $1a constant SPDIFRX_U                      \ [0x1a] user bit
    $1b constant SPDIFRX_C                      \ [0x1b] channel status bit
    $1c constant SPDIFRX_PT                     \ [0x1c : 2] preamble type
  [then]


  [ifdef] SPDIFRX_SPDIFRX_FMT1_DR_DEF
    \
    \ @brief SPDIFRX data input register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_PE                     \ [0x00] parity error bit
    $01 constant SPDIFRX_V                      \ [0x01] validity bit
    $02 constant SPDIFRX_U                      \ [0x02] user bit
    $03 constant SPDIFRX_C                      \ [0x03] channel Status bit
    $04 constant SPDIFRX_PT                     \ [0x04 : 2] preamble type
    $08 constant SPDIFRX_DR                     \ [0x08 : 24] data value
  [then]


  [ifdef] SPDIFRX_SPDIFRX_FMT2_DR_DEF
    \
    \ @brief SPDIFRX data input register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_DRNL1                  \ [0x00 : 16] data value
    $10 constant SPDIFRX_DRNL2                  \ [0x10 : 16] data value
  [then]


  [ifdef] SPDIFRX_SPDIFRX_CSR_DEF
    \
    \ @brief SPDIFRX channel status register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_USR                    \ [0x00 : 16] user data information
    $10 constant SPDIFRX_CS                     \ [0x10 : 8] channel A status information
    $18 constant SPDIFRX_SOB                    \ [0x18] start of block
  [then]


  [ifdef] SPDIFRX_SPDIFRX_DIR_DEF
    \
    \ @brief SPDIFRX debug information register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_THI                    \ [0x00 : 13] threshold HIGH (THI = 2.5 x UI / T less than sub>spdifrx_ker_ck less than /sub>)
    $10 constant SPDIFRX_TLO                    \ [0x10 : 13] threshold LOW (TLO = 1.5 x UI / T less than sub>spdifrx_ker_ck less than /sub>)
  [then]

  \
  \ @brief SPDIF receiver interface
  \
  $00 constant SPDIFRX_SPDIFRX_CR       \ SPDIFRX control register
  $04 constant SPDIFRX_SPDIFRX_IMR      \ SPDIFRX interrupt mask register
  $08 constant SPDIFRX_SPDIFRX_SR       \ SPDIFRX status register
  $0C constant SPDIFRX_SPDIFRX_IFCR     \ SPDIFRX interrupt flag clear register
  $10 constant SPDIFRX_SPDIFRX_FMT0_DR  \ SPDIFRX data input register
  $10 constant SPDIFRX_SPDIFRX_FMT1_DR  \ SPDIFRX data input register
  $10 constant SPDIFRX_SPDIFRX_FMT2_DR  \ SPDIFRX data input register
  $14 constant SPDIFRX_SPDIFRX_CSR      \ SPDIFRX channel status register
  $18 constant SPDIFRX_SPDIFRX_DIR      \ SPDIFRX debug information register

: SPDIFRX_DEF ; [then]
