\
\ @file adf1.fs
\ @brief ADF1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ADF1_DEF

  [ifdef] ADF1_ADF_GCR_DEF
    \
    \ @brief ADF Global Control Register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ADF1_TRGO                      \ [0x00] Trigger output control Set by software and reset by
  [then]


  [ifdef] ADF1_ADF_CKGCR_DEF
    \
    \ @brief ADF clock generator control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ADF1_CKGDEN                    \ [0x00] CKGEN dividers enable
    $01 constant ADF1_CCK0EN                    \ [0x01] ADF_CCK0 clock enable
    $02 constant ADF1_CCK1EN                    \ [0x02] ADF_CCK1 clock enable
    $04 constant ADF1_CKGMOD                    \ [0x04] Clock generator mode
    $05 constant ADF1_CCK0DIR                   \ [0x05] ADF_CCK0 direction
    $06 constant ADF1_CCK1DIR                   \ [0x06] ADF_CCK1 direction
    $08 constant ADF1_TRGSENS                   \ [0x08] CKGEN trigger sensitivity selection
    $0c constant ADF1_TRGSRC                    \ [0x0c : 4] Digital filter trigger signal selection
    $10 constant ADF1_CCKDIV                    \ [0x10 : 4] Divider to control the ADF_CCK clock
    $18 constant ADF1_PROCDIV                   \ [0x18 : 7] Divider to control the serial interface clock
    $1f constant ADF1_CKGACTIVE                 \ [0x1f] Clock generator active flag
  [then]


  [ifdef] ADF1_ADF_SITF0CR_DEF
    \
    \ @brief ADF serial interface control register 0
    \ Address offset: 0x80
    \ Reset value: 0x00001F00
    \
    $00 constant ADF1_SITFEN                    \ [0x00] SITFEN
    $01 constant ADF1_SCKSRC                    \ [0x01 : 2] SCKSRC
    $04 constant ADF1_SITFMOD                   \ [0x04 : 2] SITFMOD
    $08 constant ADF1_STH                       \ [0x08 : 5] STH
    $1f constant ADF1_SITFACTIVE                \ [0x1f] SITFACTIVE
  [then]


  [ifdef] ADF1_ADF_BSMX0CR_DEF
    \
    \ @brief ADF bitstream matrix control register 0
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant ADF1_BSSEL                     \ [0x00 : 5] Bitstream selection
    $1f constant ADF1_BSMXACTIVE                \ [0x1f] BSMX active flag
  [then]


  [ifdef] ADF1_ADF_DFLT0CR_DEF
    \
    \ @brief ADF digital filter control register 0
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant ADF1_DFLTEN                    \ [0x00] DFLT0 enable
    $01 constant ADF1_DMAEN                     \ [0x01] DMA requests enable
    $02 constant ADF1_FTH                       \ [0x02] RXFIFO threshold selection
    $04 constant ADF1_ACQMOD                    \ [0x04 : 3] DFLT0 trigger mode
    $0c constant ADF1_TRGSRC                    \ [0x0c : 4] DFLT0 trigger signal selection
    $14 constant ADF1_NBDIS                     \ [0x14 : 8] Number of samples to be discarded
    $1e constant ADF1_DFLTRUN                   \ [0x1e] DFLT0 run status flag
    $1f constant ADF1_DFLTACTIVE                \ [0x1f] DFLT0 active flag
  [then]


  [ifdef] ADF1_ADF_DFLT0CICR_DEF
    \
    \ @brief ADF digital filer configuration register 0
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant ADF1_DATSRC                    \ [0x00 : 2] Source data for the digital filter
    $04 constant ADF1_CICMOD                    \ [0x04 : 3] Select the CIC order
    $08 constant ADF1_MCICD                     \ [0x08 : 9] CIC decimation ratio selection
    $14 constant ADF1_SCALE                     \ [0x14 : 6] Scaling factor selection
  [then]


  [ifdef] ADF1_ADF_DFLT0RSFR_DEF
    \
    \ @brief ADF reshape filter configuration register 0
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant ADF1_RSFLTBYP                  \ [0x00] Reshaper filter bypass
    $04 constant ADF1_RSFLTD                    \ [0x04] Reshaper filter decimation ratio
    $07 constant ADF1_HPFBYP                    \ [0x07] High-pass filter bypass
    $08 constant ADF1_HPFC                      \ [0x08 : 2] High-pass filter cut-off frequency
  [then]


  [ifdef] ADF1_ADF_DLY0CR_DEF
    \
    \ @brief ADF delay control register 0
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant ADF1_SKPDLY                    \ [0x00 : 7] Delay to apply to a bitstream
    $1f constant ADF1_SKPBF                     \ [0x1f] Skip busy flag
  [then]


  [ifdef] ADF1_ADF_DFLT0IER_DEF
    \
    \ @brief ADF DFLT0 interrupt enable register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant ADF1_FTHIE                     \ [0x00] RXFIFO threshold interrupt enable
    $01 constant ADF1_DOVRIE                    \ [0x01] Data overflow interrupt enable
    $09 constant ADF1_SATIE                     \ [0x09] Saturation detection interrupt enable
    $0a constant ADF1_CKABIE                    \ [0x0a] Clock absence detection interrupt enable
    $0b constant ADF1_RFOVRIE                   \ [0x0b] Reshape filter overrun interrupt enable
    $0c constant ADF1_SDDETIE                   \ [0x0c] Sound activity detection interrupt enable
    $0d constant ADF1_SDLVLIE                   \ [0x0d] SAD sound-level value ready enable
  [then]


  [ifdef] ADF1_ADF_DFLT0ISR_DEF
    \
    \ @brief ADF DFLT0 interrupt status register 0
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant ADF1_FTHF                      \ [0x00] RXFIFO threshold flag
    $01 constant ADF1_DOVRF                     \ [0x01] Data overflow flag
    $03 constant ADF1_RXNEF                     \ [0x03] RXFIFO not empty flag
    $09 constant ADF1_SATF                      \ [0x09] Saturation detection flag
    $0a constant ADF1_CKABF                     \ [0x0a] Clock absence detection flag
    $0b constant ADF1_RFOVRF                    \ [0x0b] Reshape filter overrun detection flag
    $0c constant ADF1_SDDETF                    \ [0x0c] Sound activity detection flag
    $0d constant ADF1_SDLVLF                    \ [0x0d] Sound level value ready flag
  [then]


  [ifdef] ADF1_ADF_SADCR_DEF
    \
    \ @brief ADF SAD control register
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant ADF1_SADEN                     \ [0x00] Sound activity detector enable
    $01 constant ADF1_DATCAP                    \ [0x01 : 2] Data capture mode
    $03 constant ADF1_DETCFG                    \ [0x03] Sound trigger event configuration
    $04 constant ADF1_SADST                     \ [0x04 : 2] SAD state
    $07 constant ADF1_HYSTEN                    \ [0x07] Hysteresis enable
    $08 constant ADF1_FRSIZE                    \ [0x08 : 3] Frame size
    $0c constant ADF1_SADMOD                    \ [0x0c : 2] SAD working mode
    $1f constant ADF1_SADACTIVE                 \ [0x1f] SAD Active flag
  [then]


  [ifdef] ADF1_ADF_SADCFGR_DEF
    \
    \ @brief ADF SAD configuration register
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant ADF1_SNTHR                     \ [0x00 : 4] SNTHR
    $04 constant ADF1_ANSLP                     \ [0x04 : 3] ANSLP
    $08 constant ADF1_LFRNB                     \ [0x08 : 3] LFRNB
    $0c constant ADF1_HGOVR                     \ [0x0c : 3] Hangover time window
    $10 constant ADF1_ANMIN                     \ [0x10 : 13] ANMIN
  [then]


  [ifdef] ADF1_ADF_SADSDLVR_DEF
    \
    \ @brief ADF SAD sound level register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant ADF1_SDLVL                     \ [0x00 : 15] SDLVL
  [then]


  [ifdef] ADF1_ADF_SADANLVR_DEF
    \
    \ @brief ADF SAD ambient noise level register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant ADF1_ANLVL                     \ [0x00 : 15] ANLVL
  [then]


  [ifdef] ADF1_ADF_DFLT0DR_DEF
    \
    \ @brief ADF digital filter data register 0
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $08 constant ADF1_DR                        \ [0x08 : 24] DR
  [then]

  \
  \ @brief ADF1
  \
  $00 constant ADF1_ADF_GCR             \ ADF Global Control Register
  $04 constant ADF1_ADF_CKGCR           \ ADF clock generator control register
  $80 constant ADF1_ADF_SITF0CR         \ ADF serial interface control register 0
  $84 constant ADF1_ADF_BSMX0CR         \ ADF bitstream matrix control register 0
  $88 constant ADF1_ADF_DFLT0CR         \ ADF digital filter control register 0
  $8C constant ADF1_ADF_DFLT0CICR       \ ADF digital filer configuration register 0
  $90 constant ADF1_ADF_DFLT0RSFR       \ ADF reshape filter configuration register 0
  $A4 constant ADF1_ADF_DLY0CR          \ ADF delay control register 0
  $AC constant ADF1_ADF_DFLT0IER        \ ADF DFLT0 interrupt enable register
  $B0 constant ADF1_ADF_DFLT0ISR        \ ADF DFLT0 interrupt status register 0
  $B8 constant ADF1_ADF_SADCR           \ ADF SAD control register
  $BC constant ADF1_ADF_SADCFGR         \ ADF SAD configuration register
  $C0 constant ADF1_ADF_SADSDLVR        \ ADF SAD sound level register
  $C4 constant ADF1_ADF_SADANLVR        \ ADF SAD ambient noise level register
  $F0 constant ADF1_ADF_DFLT0DR         \ ADF digital filter data register 0

: ADF1_DEF ; [then]
