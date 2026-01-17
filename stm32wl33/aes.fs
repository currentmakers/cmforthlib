\
\ @file aes.fs
\ @brief AES interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] AES_DEF

  [ifdef] AES_AES_CR_DEF
    \
    \ @brief AES_CR register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant AES_EN                         \ [0x00] EN: AES IP enable
    $01 constant AES_DATATYPE                   \ [0x01 : 2] DATATYPE[1:0]: Data type selection
    $03 constant AES_MODE                       \ [0x03 : 2] MODE[1:0]: AES operating mode
    $05 constant AES_CHMOD_1_0                  \ [0x05 : 2] CHMOD[1:0]: AES Chaining Mode selection
    $07 constant AES_CCFC                       \ [0x07] CCFC: Computation Complete Flag Clear
    $08 constant AES_ERRC                       \ [0x08] ERRC: Error clear
    $09 constant AES_CCFIE                      \ [0x09] CCFIE: CCF Flag Interrupt Enable
    $0a constant AES_ERRIE                      \ [0x0a] ERRIE: Error Interrupt Enable
    $0b constant AES_DMAINEN                    \ [0x0b] DMAINEN: DMA Input Enable
    $0c constant AES_DMAOUTEN                   \ [0x0c] DMAOUTEN: DMA Output Enable
    $0d constant AES_GCMPH                      \ [0x0d : 2] GCMPH[1:0]: GCM or CCM Phase selection
    $10 constant AES_CHMOD_2                    \ [0x10] CHMOD[2]: Chaining mode selection, bit [2]
    $12 constant AES_KEYSIZE                    \ [0x12] KEYSIZE: Key Size selection.
    $14 constant AES_NPBLB                      \ [0x14 : 4] NPBLB: Number of Padding Bytes in Last Block of payload.
  [then]


  [ifdef] AES_AES_SR_DEF
    \
    \ @brief AES_SR register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant AES_CCF                        \ [0x00] CCF: Computation complete flag
    $01 constant AES_RDERR                      \ [0x01] RDERR: Read error flag
    $02 constant AES_WRERR                      \ [0x02] WRERR: Write error flag
    $03 constant AES_BUSY                       \ [0x03] BUSY: Busy flag
  [then]


  [ifdef] AES_AES_DINR_DEF
    \
    \ @brief AES_DINR register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant AES_DINR                       \ [0x00 : 32] DINR[x+31:x]: One of four 32-bit words of a 128-bit input data block being written into the peripheral
  [then]


  [ifdef] AES_AES_DOUTR_DEF
    \
    \ @brief AES_DOUTR register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant AES_DOUTR                      \ [0x00 : 32] DOUTR[x+31:x]: One of four 32-bit words of a 128-bit output data block being read from the
  [then]


  [ifdef] AES_AES_KEYR0_DEF
    \
    \ @brief AES_KEYRx register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] KEY [((32*x)+31):((32*x)+0)]: Cryptographic key, bits [((32*x)+31):((32*x)+0)]
  [then]


  [ifdef] AES_AES_KEYR1_DEF
    \
    \ @brief AES_KEYRx register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] KEY [((32*x)+31):((32*x)+0)]: Cryptographic key, bits [((32*x)+31):((32*x)+0)]
  [then]


  [ifdef] AES_AES_KEYR2_DEF
    \
    \ @brief AES_KEYRx register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] KEY [((32*x)+31):((32*x)+0)]: Cryptographic key, bits [((32*x)+31):((32*x)+0)]
  [then]


  [ifdef] AES_AES_KEYR3_DEF
    \
    \ @brief AES_KEYRx register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] KEY [((32*x)+31):((32*x)+0)]: Cryptographic key, bits [((32*x)+31):((32*x)+0)]
  [then]


  [ifdef] AES_AES_IVR0_DEF
    \
    \ @brief AES_IVRx register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant AES_IVI                        \ [0x00 : 32] IVI [((32*x)+31):((32*x)+0)]: Initialization vector register (LSB IVR[((32*x)+31):((32*x)+0)])
  [then]


  [ifdef] AES_AES_IVR1_DEF
    \
    \ @brief AES_IVRx register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant AES_IVI                        \ [0x00 : 32] IVI [((32*x)+31):((32*x)+0)]: Initialization vector register (LSB IVR[((32*x)+31):((32*x)+0)])
  [then]


  [ifdef] AES_AES_IVR2_DEF
    \
    \ @brief AES_IVRx register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant AES_IVI                        \ [0x00 : 32] IVI [((32*x)+31):((32*x)+0)]: Initialization vector register (LSB IVR[((32*x)+31):((32*x)+0)])
  [then]


  [ifdef] AES_AES_IVR3_DEF
    \
    \ @brief AES_IVRx register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant AES_IVI                        \ [0x00 : 32] IVI [((32*x)+31):((32*x)+0)]: Initialization vector register (LSB IVR[((32*x)+31):((32*x)+0)])
  [then]

  \
  \ @brief AES interrupt
  \
  $00 constant AES_AES_CR               \ AES_CR register
  $04 constant AES_AES_SR               \ AES_SR register
  $08 constant AES_AES_DINR             \ AES_DINR register
  $0C constant AES_AES_DOUTR            \ AES_DOUTR register
  $10 constant AES_AES_KEYR0            \ AES_KEYRx register
  $14 constant AES_AES_KEYR1            \ AES_KEYRx register
  $18 constant AES_AES_KEYR2            \ AES_KEYRx register
  $1C constant AES_AES_KEYR3            \ AES_KEYRx register
  $20 constant AES_AES_IVR0             \ AES_IVRx register
  $24 constant AES_AES_IVR1             \ AES_IVRx register
  $28 constant AES_AES_IVR2             \ AES_IVRx register
  $2C constant AES_AES_IVR3             \ AES_IVRx register

: AES_DEF ; [then]
