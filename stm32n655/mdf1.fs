\
\ @file mdf1.fs
\ @brief MDF register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] MDF1_DEF

  [ifdef] MDF1_MDF_GCR_DEF
    \
    \ @brief MDF global control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_TRGO                      \ [0x00] Trigger output control
    $04 constant MDF1_ILVNB                     \ [0x04 : 4] Interleaved number
  [then]


  [ifdef] MDF1_MDF_CKGCR_DEF
    \
    \ @brief MDF clock generator control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_CKGDEN                    \ [0x00] CKGEN dividers enable
    $01 constant MDF1_CCK0EN                    \ [0x01] MDF_CCK0 clock enable
    $02 constant MDF1_CCK1EN                    \ [0x02] MDF_CCK1 clock enable
    $04 constant MDF1_CKGMOD                    \ [0x04] Clock generator mode
    $05 constant MDF1_CCK0DIR                   \ [0x05] MDF_CCK0 direction
    $06 constant MDF1_CCK1DIR                   \ [0x06] MDF_CCK1 direction
    $08 constant MDF1_TRGSENS                   \ [0x08] CKGEN trigger sensitivity selection
    $0c constant MDF1_TRGSRC                    \ [0x0c : 4] Digital filter trigger signal selection
    $10 constant MDF1_CCKDIV                    \ [0x10 : 4] Divider to control the MDF_CCK clock
    $18 constant MDF1_PROCDIV                   \ [0x18 : 7] Divider to control the serial interface clock
    $1f constant MDF1_CKGACTIVE                 \ [0x1f] Clock generator active flag
  [then]


  [ifdef] MDF1_MDF_SITF0CR_DEF
    \
    \ @brief MDF serial interface control register 0
    \ Address offset: 0x80
    \ Reset value: 0x00001F00
    \
    $00 constant MDF1_SITFEN                    \ [0x00] Serial interface enable
    $01 constant MDF1_SCKSRC                    \ [0x01 : 2] Serial clock source
    $04 constant MDF1_SITFMOD                   \ [0x04 : 2] Serial interface type
    $08 constant MDF1_STH                       \ [0x08 : 5] Manchester symbol threshold/SPI threshold
    $1f constant MDF1_SITFACTIVE                \ [0x1f] Serial interface active flag
  [then]


  [ifdef] MDF1_MDF_BSMX0CR_DEF
    \
    \ @brief MDF bitstream matrix control register 0
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_BSSEL                     \ [0x00 : 5] Bitstream Selection
    $1f constant MDF1_BSMXACTIVE                \ [0x1f] BSMX active flag
  [then]


  [ifdef] MDF1_MDF_DFLT0CR_DEF
    \
    \ @brief MDF digital filter control register 0
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DFLTEN                    \ [0x00] Digital filter enable
    $01 constant MDF1_DMAEN                     \ [0x01] DMA requests enable
    $02 constant MDF1_FTH                       \ [0x02] RXFIFO Threshold selection
    $04 constant MDF1_ACQMOD                    \ [0x04 : 3] Digital filter trigger mode
    $08 constant MDF1_TRGSENS                   \ [0x08] Digital filter trigger sensitivity selection
    $0c constant MDF1_TRGSRC                    \ [0x0c : 4] Digital filter trigger signal selection
    $10 constant MDF1_SNPSFMT                   \ [0x10] Snapshot data format
    $14 constant MDF1_NBDIS                     \ [0x14 : 8] Number of samples to be discarded
    $1e constant MDF1_DFLTRUN                   \ [0x1e] Digital filter run status flag
    $1f constant MDF1_DFLTACTIVE                \ [0x1f] Digital filter active flag
  [then]


  [ifdef] MDF1_MDF_DFLT0CICR_DEF
    \
    \ @brief MDF digital filter configuration register 0
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DATSRC                    \ [0x00 : 2] Source data for the digital filter
    $04 constant MDF1_CICMOD                    \ [0x04 : 3] Select the CIC mode
    $08 constant MDF1_MCICD                     \ [0x08 : 8] CIC decimation ratio selection
    $10 constant MDF1_MCICD8                    \ [0x10] CIC decimation ratio selection
    $14 constant MDF1_SCALE                     \ [0x14 : 6] Scaling factor selection
  [then]


  [ifdef] MDF1_MDF_DFLT0RSFR_DEF
    \
    \ @brief MDF reshape filter configuration register 0
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_RSFLTBYP                  \ [0x00] Reshaper filter bypass
    $04 constant MDF1_RSFLTD                    \ [0x04] Reshaper filter decimation ratio
    $07 constant MDF1_HPFBYP                    \ [0x07] High-pass filter bypass
    $08 constant MDF1_HPFC                      \ [0x08 : 2] High-pass filter cut-off frequency
  [then]


  [ifdef] MDF1_MDF_DFLT0INTR_DEF
    \
    \ @brief MDF integrator configuration register 0
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_INTDIV                    \ [0x00 : 2] Integrator output division
    $04 constant MDF1_INTVAL                    \ [0x04 : 7] Integration value selection
  [then]


  [ifdef] MDF1_MDF_OLD0CR_DEF
    \
    \ @brief MDF out-of limit detector control register 0
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDEN                     \ [0x00] OLDx enable
    $01 constant MDF1_THINB                     \ [0x01] Threshold In band
    $04 constant MDF1_BKOLD                     \ [0x04 : 4] Break signal assignment for out-of limit detector
    $0c constant MDF1_ACICN                     \ [0x0c : 2] OLDx CIC order selection
    $11 constant MDF1_ACICD                     \ [0x11 : 5] OLDx CIC decimation ratio selection
    $1f constant MDF1_OLDACTIVE                 \ [0x1f] OLDx active flag
  [then]


  [ifdef] MDF1_MDF_OLD0THLR_DEF
    \
    \ @brief MDF OLD0 low threshold register 0
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHL                    \ [0x00 : 26] OLD low threshold value
  [then]


  [ifdef] MDF1_MDF_OLD0THHR_DEF
    \
    \ @brief MDF OLD0 high threshold register 0
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHH                    \ [0x00 : 26] OLDx high threshold value
  [then]


  [ifdef] MDF1_MDF_DLY0CR_DEF
    \
    \ @brief MDF delay control register 0
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SKPDLY                    \ [0x00 : 7] Delay to apply to a bitstream
    $1f constant MDF1_SKPBF                     \ [0x1f] Skip busy flag
  [then]


  [ifdef] MDF1_MDF_SCD0CR_DEF
    \
    \ @brief MDF short circuit detector control register 0
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SCDEN                     \ [0x00] SCDx enable
    $04 constant MDF1_BKSCD                     \ [0x04 : 4] Break signal assignment for short circuit detector
    $0c constant MDF1_SCDT                      \ [0x0c : 8] SCDx threshold
    $1f constant MDF1_SCDACTIVE                 \ [0x1f] SCDx active flag
  [then]


  [ifdef] MDF1_MDF_DFLT0IER_DEF
    \
    \ @brief MDF DFLT0 interrupt enable register 0
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHIE                     \ [0x00] RXFIFO threshold interrupt enable
    $01 constant MDF1_DOVRIE                    \ [0x01] Data overflow interrupt enable
    $02 constant MDF1_SSDRIE                    \ [0x02] Snapshot data ready interrupt enable
    $04 constant MDF1_OLDIE                     \ [0x04] OLD0 interrupt enable
    $07 constant MDF1_SSOVRIE                   \ [0x07] Snapshot overrun interrupt enable
    $08 constant MDF1_SCDIE                     \ [0x08] SCD0 interrupt enable
    $09 constant MDF1_SATIE                     \ [0x09] Saturation detection interrupt enable
    $0a constant MDF1_CKABIE                    \ [0x0a] Clock absence detection interrupt enable
    $0b constant MDF1_RFOVRIE                   \ [0x0b] Reshape filter overrun interrupt enable
  [then]


  [ifdef] MDF1_MDF_DFLT0ISR_DEF
    \
    \ @brief MDF DFLT0 interrupt status register 0
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHF                      \ [0x00] RXFIFO threshold flag
    $01 constant MDF1_DOVRF                     \ [0x01] Data overflow flag
    $02 constant MDF1_SSDRF                     \ [0x02] Snapshot data ready flag
    $03 constant MDF1_RXNEF                     \ [0x03] RXFIFO not-empty flag
    $04 constant MDF1_OLDF                      \ [0x04] OLD0 flag
    $05 constant MDF1_THLF                      \ [0x05] Low-threshold status flag
    $06 constant MDF1_THHF                      \ [0x06] High-threshold status flag
    $07 constant MDF1_SSOVRF                    \ [0x07] Snapshot overrun flag
    $08 constant MDF1_SCDF                      \ [0x08] Short-circuit detector flag
    $09 constant MDF1_SATF                      \ [0x09] Saturation detection flag
    $0a constant MDF1_CKABF                     \ [0x0a] Clock absence detection flag
    $0b constant MDF1_RFOVRF                    \ [0x0b] Reshape filter overrun detection flag
  [then]


  [ifdef] MDF1_MDF_OEC0CR_DEF
    \
    \ @brief MDF offset error compensation control register 0
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OFFSET                    \ [0x00 : 26] Offset error compensation
  [then]


  [ifdef] MDF1_MDF_SNPS0DR_DEF
    \
    \ @brief MDF snapshot data register 0
    \ Address offset: 0xEC
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_MCICDC                    \ [0x00 : 9] Contains the MCIC decimation counter value when the last trigger event occurs (MCIC_CNT)
    $09 constant MDF1_EXTSDR                    \ [0x09 : 7] Extended data size
    $10 constant MDF1_SDR                       \ [0x10 : 16] Contains the 16 MSB of the last valid data processed by the digital filter.
  [then]


  [ifdef] MDF1_MDF_DFLT0DR_DEF
    \
    \ @brief MDF digital filter data register 0
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $08 constant MDF1_DR                        \ [0x08 : 24] Data processed by digital filter
  [then]


  [ifdef] MDF1_MDF_SITF1CR_DEF
    \
    \ @brief MDF serial interface control register 1
    \ Address offset: 0x100
    \ Reset value: 0x00001F00
    \
    $00 constant MDF1_SITFEN                    \ [0x00] Serial interface enable
    $01 constant MDF1_SCKSRC                    \ [0x01 : 2] Serial clock source
    $04 constant MDF1_SITFMOD                   \ [0x04 : 2] Serial interface type
    $08 constant MDF1_STH                       \ [0x08 : 5] Manchester symbol threshold/SPI threshold
    $1f constant MDF1_SITFACTIVE                \ [0x1f] Serial interface active flag
  [then]


  [ifdef] MDF1_MDF_BSMX1CR_DEF
    \
    \ @brief MDF bitstream matrix control register 1
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_BSSEL                     \ [0x00 : 5] Bitstream Selection
    $1f constant MDF1_BSMXACTIVE                \ [0x1f] BSMX active flag
  [then]


  [ifdef] MDF1_MDF_DFLT1CR_DEF
    \
    \ @brief MDF digital filter control register 1
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DFLTEN                    \ [0x00] Digital filter enable
    $01 constant MDF1_DMAEN                     \ [0x01] DMA requests enable
    $02 constant MDF1_FTH                       \ [0x02] RXFIFO Threshold selection
    $04 constant MDF1_ACQMOD                    \ [0x04 : 3] Digital filter trigger mode
    $08 constant MDF1_TRGSENS                   \ [0x08] Digital filter trigger sensitivity selection
    $0c constant MDF1_TRGSRC                    \ [0x0c : 4] Digital filter trigger signal selection
    $10 constant MDF1_SNPSFMT                   \ [0x10] Snapshot data format
    $14 constant MDF1_NBDIS                     \ [0x14 : 8] Number of samples to be discarded
    $1e constant MDF1_DFLTRUN                   \ [0x1e] Digital filter run status flag
    $1f constant MDF1_DFLTACTIVE                \ [0x1f] Digital filter active flag
  [then]


  [ifdef] MDF1_MDF_DFLT1CICR_DEF
    \
    \ @brief MDF digital filter configuration register 1
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DATSRC                    \ [0x00 : 2] Source data for the digital filter
    $04 constant MDF1_CICMOD                    \ [0x04 : 3] Select the CIC mode
    $08 constant MDF1_MCICD                     \ [0x08 : 8] CIC decimation ratio selection
    $10 constant MDF1_MCICD8                    \ [0x10] CIC decimation ratio selection
    $14 constant MDF1_SCALE                     \ [0x14 : 6] Scaling factor selection
  [then]


  [ifdef] MDF1_MDF_DFLT1RSFR_DEF
    \
    \ @brief MDF reshape filter configuration register 1
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_RSFLTBYP                  \ [0x00] Reshaper filter bypass
    $04 constant MDF1_RSFLTD                    \ [0x04] Reshaper filter decimation ratio
    $07 constant MDF1_HPFBYP                    \ [0x07] High-pass filter bypass
    $08 constant MDF1_HPFC                      \ [0x08 : 2] High-pass filter cut-off frequency
  [then]


  [ifdef] MDF1_MDF_DFLT1INTR_DEF
    \
    \ @brief MDF integrator configuration register 1
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_INTDIV                    \ [0x00 : 2] Integrator output division
    $04 constant MDF1_INTVAL                    \ [0x04 : 7] Integration value selection
  [then]


  [ifdef] MDF1_MDF_OLD1CR_DEF
    \
    \ @brief MDF out-of limit detector control register 1
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDEN                     \ [0x00] OLDx enable
    $01 constant MDF1_THINB                     \ [0x01] Threshold In band
    $04 constant MDF1_BKOLD                     \ [0x04 : 4] Break signal assignment for out-of limit detector
    $0c constant MDF1_ACICN                     \ [0x0c : 2] OLDx CIC order selection
    $11 constant MDF1_ACICD                     \ [0x11 : 5] OLDx CIC decimation ratio selection
    $1f constant MDF1_OLDACTIVE                 \ [0x1f] OLDx active flag
  [then]


  [ifdef] MDF1_MDF_OLD1THLR_DEF
    \
    \ @brief MDF OLD1 low threshold register 1
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHL                    \ [0x00 : 26] OLD low threshold value
  [then]


  [ifdef] MDF1_MDF_OLD1THHR_DEF
    \
    \ @brief MDF OLD1 high threshold register 1
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHH                    \ [0x00 : 26] OLDx high threshold value
  [then]


  [ifdef] MDF1_MDF_DLY1CR_DEF
    \
    \ @brief MDF delay control register 1
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SKPDLY                    \ [0x00 : 7] Delay to apply to a bitstream
    $1f constant MDF1_SKPBF                     \ [0x1f] Skip busy flag
  [then]


  [ifdef] MDF1_MDF_SCD1CR_DEF
    \
    \ @brief MDF short circuit detector control register 1
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SCDEN                     \ [0x00] SCDx enable
    $04 constant MDF1_BKSCD                     \ [0x04 : 4] Break signal assignment for short circuit detector
    $0c constant MDF1_SCDT                      \ [0x0c : 8] SCDx threshold
    $1f constant MDF1_SCDACTIVE                 \ [0x1f] SCDx active flag
  [then]


  [ifdef] MDF1_MDF_DFLT1IER_DEF
    \
    \ @brief MDF DFLT1 interrupt enable register 1
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHIE                     \ [0x00] RXFIFO threshold interrupt enable
    $01 constant MDF1_DOVRIE                    \ [0x01] Data overflow interrupt enable
    $02 constant MDF1_SSDRIE                    \ [0x02] Snapshot data ready interrupt enable
    $04 constant MDF1_OLDIE                     \ [0x04] OLDx interrupt enable
    $07 constant MDF1_SSOVRIE                   \ [0x07] Snapshot overrun interrupt enable
    $08 constant MDF1_SCDIE                     \ [0x08] SCDx interrupt enable
    $09 constant MDF1_SATIE                     \ [0x09] Saturation detection interrupt enable
    $0a constant MDF1_CKABIE                    \ [0x0a] Clock absence detection interrupt enable
    $0b constant MDF1_RFOVRIE                   \ [0x0b] Reshape filter overrun interrupt enable
  [then]


  [ifdef] MDF1_MDF_DFLT1ISR_DEF
    \
    \ @brief MDF DFLT1 interrupt status register 1
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHF                      \ [0x00] RXFIFO threshold flag
    $01 constant MDF1_DOVRF                     \ [0x01] Data overflow flag
    $02 constant MDF1_SSDRF                     \ [0x02] Snapshot data ready flag
    $03 constant MDF1_RXNEF                     \ [0x03] RXFIFO not-empty flag
    $04 constant MDF1_OLDF                      \ [0x04] OLDx flag
    $05 constant MDF1_THLF                      \ [0x05] Low-threshold status flag
    $06 constant MDF1_THHF                      \ [0x06] High-threshold status flag
    $07 constant MDF1_SSOVRF                    \ [0x07] Snapshot overrun flag
    $08 constant MDF1_SCDF                      \ [0x08] Short-circuit detector flag
    $09 constant MDF1_SATF                      \ [0x09] Saturation detection flag
    $0a constant MDF1_CKABF                     \ [0x0a] Clock absence detection flag
    $0b constant MDF1_RFOVRF                    \ [0x0b] Reshape filter overrun detection flag
  [then]


  [ifdef] MDF1_MDF_OEC1CR_DEF
    \
    \ @brief MDF offset error compensation control register 1
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OFFSET                    \ [0x00 : 26] Offset error compensation
  [then]


  [ifdef] MDF1_MDF_SNPS1DR_DEF
    \
    \ @brief MDF snapshot data register 1
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_MCICDC                    \ [0x00 : 9] Contains the MCIC decimation counter value when the last trigger event occurs (MCIC_CNT)
    $09 constant MDF1_EXTSDR                    \ [0x09 : 7] Extended data size
    $10 constant MDF1_SDR                       \ [0x10 : 16] Contains the 16 MSB of the last valid data processed by the digital filter.
  [then]


  [ifdef] MDF1_MDF_DFLT1DR_DEF
    \
    \ @brief MDF digital filter data register 1
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $08 constant MDF1_DR                        \ [0x08 : 24] Data processed by digital filter
  [then]


  [ifdef] MDF1_MDF_SITF2CR_DEF
    \
    \ @brief MDF serial interface control register 2
    \ Address offset: 0x180
    \ Reset value: 0x00001F00
    \
    $00 constant MDF1_SITFEN                    \ [0x00] Serial interface enable
    $01 constant MDF1_SCKSRC                    \ [0x01 : 2] Serial clock source
    $04 constant MDF1_SITFMOD                   \ [0x04 : 2] Serial interface type
    $08 constant MDF1_STH                       \ [0x08 : 5] Manchester symbol threshold/SPI threshold
    $1f constant MDF1_SITFACTIVE                \ [0x1f] Serial interface active flag
  [then]


  [ifdef] MDF1_MDF_BSMX2CR_DEF
    \
    \ @brief MDF bitstream matrix control register 2
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_BSSEL                     \ [0x00 : 5] Bitstream Selection
    $1f constant MDF1_BSMXACTIVE                \ [0x1f] BSMX active flag
  [then]


  [ifdef] MDF1_MDF_DFLT2CR_DEF
    \
    \ @brief MDF digital filter control register 2
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DFLTEN                    \ [0x00] Digital filter enable
    $01 constant MDF1_DMAEN                     \ [0x01] DMA requests enable
    $02 constant MDF1_FTH                       \ [0x02] RXFIFO Threshold selection
    $04 constant MDF1_ACQMOD                    \ [0x04 : 3] Digital filter trigger mode
    $08 constant MDF1_TRGSENS                   \ [0x08] Digital filter trigger sensitivity selection
    $0c constant MDF1_TRGSRC                    \ [0x0c : 4] Digital filter trigger signal selection
    $10 constant MDF1_SNPSFMT                   \ [0x10] Snapshot data format
    $14 constant MDF1_NBDIS                     \ [0x14 : 8] Number of samples to be discarded
    $1e constant MDF1_DFLTRUN                   \ [0x1e] Digital filter run status flag
    $1f constant MDF1_DFLTACTIVE                \ [0x1f] Digital filter active flag
  [then]


  [ifdef] MDF1_MDF_DFLT2CICR_DEF
    \
    \ @brief MDF digital filter configuration register 2
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DATSRC                    \ [0x00 : 2] Source data for the digital filter
    $04 constant MDF1_CICMOD                    \ [0x04 : 3] Select the CIC mode
    $08 constant MDF1_MCICD                     \ [0x08 : 8] CIC decimation ratio selection
    $10 constant MDF1_MCICD8                    \ [0x10] CIC decimation ratio selection
    $14 constant MDF1_SCALE                     \ [0x14 : 6] Scaling factor selection
  [then]


  [ifdef] MDF1_MDF_DFLT2RSFR_DEF
    \
    \ @brief MDF reshape filter configuration register 2
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_RSFLTBYP                  \ [0x00] Reshaper filter bypass
    $04 constant MDF1_RSFLTD                    \ [0x04] Reshaper filter decimation ratio
    $07 constant MDF1_HPFBYP                    \ [0x07] High-pass filter bypass
    $08 constant MDF1_HPFC                      \ [0x08 : 2] High-pass filter cut-off frequency
  [then]


  [ifdef] MDF1_MDF_DFLT2INTR_DEF
    \
    \ @brief MDF integrator configuration register 2
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_INTDIV                    \ [0x00 : 2] Integrator output division
    $04 constant MDF1_INTVAL                    \ [0x04 : 7] Integration value selection
  [then]


  [ifdef] MDF1_MDF_OLD2CR_DEF
    \
    \ @brief MDF out-of limit detector control register 2
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDEN                     \ [0x00] OLDx enable
    $01 constant MDF1_THINB                     \ [0x01] Threshold In band
    $04 constant MDF1_BKOLD                     \ [0x04 : 4] Break signal assignment for out-of limit detector
    $0c constant MDF1_ACICN                     \ [0x0c : 2] OLDx CIC order selection
    $11 constant MDF1_ACICD                     \ [0x11 : 5] OLDx CIC decimation ratio selection
    $1f constant MDF1_OLDACTIVE                 \ [0x1f] OLDx active flag
  [then]


  [ifdef] MDF1_MDF_OLD2THLR_DEF
    \
    \ @brief MDF OLD2 low threshold register 2
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHL                    \ [0x00 : 26] OLD low threshold value
  [then]


  [ifdef] MDF1_MDF_OLD2THHR_DEF
    \
    \ @brief MDF OLD2 high threshold register 2
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHH                    \ [0x00 : 26] OLDx high threshold value
  [then]


  [ifdef] MDF1_MDF_DLY2CR_DEF
    \
    \ @brief MDF delay control register 2
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SKPDLY                    \ [0x00 : 7] Delay to apply to a bitstream
    $1f constant MDF1_SKPBF                     \ [0x1f] Skip busy flag
  [then]


  [ifdef] MDF1_MDF_SCD2CR_DEF
    \
    \ @brief MDF short circuit detector control register 2
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SCDEN                     \ [0x00] SCDx enable
    $04 constant MDF1_BKSCD                     \ [0x04 : 4] Break signal assignment for short circuit detector
    $0c constant MDF1_SCDT                      \ [0x0c : 8] SCDx threshold
    $1f constant MDF1_SCDACTIVE                 \ [0x1f] SCDx active flag
  [then]


  [ifdef] MDF1_MDF_DFLT2IER_DEF
    \
    \ @brief MDF DFLT2 interrupt enable register 2
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHIE                     \ [0x00] RXFIFO threshold interrupt enable
    $01 constant MDF1_DOVRIE                    \ [0x01] Data overflow interrupt enable
    $02 constant MDF1_SSDRIE                    \ [0x02] Snapshot data ready interrupt enable
    $04 constant MDF1_OLDIE                     \ [0x04] OLDx interrupt enable
    $07 constant MDF1_SSOVRIE                   \ [0x07] Snapshot overrun interrupt enable
    $08 constant MDF1_SCDIE                     \ [0x08] SCDx interrupt enable
    $09 constant MDF1_SATIE                     \ [0x09] Saturation detection interrupt enable
    $0a constant MDF1_CKABIE                    \ [0x0a] Clock absence detection interrupt enable
    $0b constant MDF1_RFOVRIE                   \ [0x0b] Reshape filter overrun interrupt enable
  [then]


  [ifdef] MDF1_MDF_DFLT2ISR_DEF
    \
    \ @brief MDF DFLT2 interrupt status register 2
    \ Address offset: 0x1B0
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHF                      \ [0x00] RXFIFO threshold flag
    $01 constant MDF1_DOVRF                     \ [0x01] Data overflow flag
    $02 constant MDF1_SSDRF                     \ [0x02] Snapshot data ready flag
    $03 constant MDF1_RXNEF                     \ [0x03] RXFIFO not-empty flag
    $04 constant MDF1_OLDF                      \ [0x04] OLDx flag
    $05 constant MDF1_THLF                      \ [0x05] Low-threshold status flag
    $06 constant MDF1_THHF                      \ [0x06] High-threshold status flag
    $07 constant MDF1_SSOVRF                    \ [0x07] Snapshot overrun flag
    $08 constant MDF1_SCDF                      \ [0x08] Short-circuit detector flag
    $09 constant MDF1_SATF                      \ [0x09] Saturation detection flag
    $0a constant MDF1_CKABF                     \ [0x0a] Clock absence detection flag
    $0b constant MDF1_RFOVRF                    \ [0x0b] Reshape filter overrun detection flag
  [then]


  [ifdef] MDF1_MDF_OEC2CR_DEF
    \
    \ @brief MDF offset error compensation control register 2
    \ Address offset: 0x1B4
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OFFSET                    \ [0x00 : 26] Offset error compensation
  [then]


  [ifdef] MDF1_MDF_SNPS2DR_DEF
    \
    \ @brief MDF snapshot data register 2
    \ Address offset: 0x1EC
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_MCICDC                    \ [0x00 : 9] Contains the MCIC decimation counter value when the last trigger event occurs (MCIC_CNT)
    $09 constant MDF1_EXTSDR                    \ [0x09 : 7] Extended data size
    $10 constant MDF1_SDR                       \ [0x10 : 16] Contains the 16 MSB of the last valid data processed by the digital filter.
  [then]


  [ifdef] MDF1_MDF_DFLT2DR_DEF
    \
    \ @brief MDF digital filter data register 2
    \ Address offset: 0x1F0
    \ Reset value: 0x00000000
    \
    $08 constant MDF1_DR                        \ [0x08 : 24] Data processed by digital filter
  [then]


  [ifdef] MDF1_MDF_SITF3CR_DEF
    \
    \ @brief MDF serial interface control register 3
    \ Address offset: 0x200
    \ Reset value: 0x00001F00
    \
    $00 constant MDF1_SITFEN                    \ [0x00] Serial interface enable
    $01 constant MDF1_SCKSRC                    \ [0x01 : 2] Serial clock source
    $04 constant MDF1_SITFMOD                   \ [0x04 : 2] Serial interface type
    $08 constant MDF1_STH                       \ [0x08 : 5] Manchester symbol threshold/SPI threshold
    $1f constant MDF1_SITFACTIVE                \ [0x1f] Serial interface active flag
  [then]


  [ifdef] MDF1_MDF_BSMX3CR_DEF
    \
    \ @brief MDF bitstream matrix control register 3
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_BSSEL                     \ [0x00 : 5] Bitstream Selection
    $1f constant MDF1_BSMXACTIVE                \ [0x1f] BSMX active flag
  [then]


  [ifdef] MDF1_MDF_DFLT3CR_DEF
    \
    \ @brief MDF digital filter control register 3
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DFLTEN                    \ [0x00] Digital filter enable
    $01 constant MDF1_DMAEN                     \ [0x01] DMA requests enable
    $02 constant MDF1_FTH                       \ [0x02] RXFIFO Threshold selection
    $04 constant MDF1_ACQMOD                    \ [0x04 : 3] Digital filter trigger mode
    $08 constant MDF1_TRGSENS                   \ [0x08] Digital filter trigger sensitivity selection
    $0c constant MDF1_TRGSRC                    \ [0x0c : 4] Digital filter trigger signal selection
    $10 constant MDF1_SNPSFMT                   \ [0x10] Snapshot data format
    $14 constant MDF1_NBDIS                     \ [0x14 : 8] Number of samples to be discarded
    $1e constant MDF1_DFLTRUN                   \ [0x1e] Digital filter run status flag
    $1f constant MDF1_DFLTACTIVE                \ [0x1f] Digital filter active flag
  [then]


  [ifdef] MDF1_MDF_DFLT3CICR_DEF
    \
    \ @brief MDF digital filter configuration register 3
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DATSRC                    \ [0x00 : 2] Source data for the digital filter
    $04 constant MDF1_CICMOD                    \ [0x04 : 3] Select the CIC mode
    $08 constant MDF1_MCICD                     \ [0x08 : 8] CIC decimation ratio selection
    $10 constant MDF1_MCICD8                    \ [0x10] CIC decimation ratio selection
    $14 constant MDF1_SCALE                     \ [0x14 : 6] Scaling factor selection
  [then]


  [ifdef] MDF1_MDF_DFLT3RSFR_DEF
    \
    \ @brief MDF reshape filter configuration register 3
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_RSFLTBYP                  \ [0x00] Reshaper filter bypass
    $04 constant MDF1_RSFLTD                    \ [0x04] Reshaper filter decimation ratio
    $07 constant MDF1_HPFBYP                    \ [0x07] High-pass filter bypass
    $08 constant MDF1_HPFC                      \ [0x08 : 2] High-pass filter cut-off frequency
  [then]


  [ifdef] MDF1_MDF_DFLT3INTR_DEF
    \
    \ @brief MDF integrator configuration register 3
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_INTDIV                    \ [0x00 : 2] Integrator output division
    $04 constant MDF1_INTVAL                    \ [0x04 : 7] Integration value selection
  [then]


  [ifdef] MDF1_MDF_OLD3CR_DEF
    \
    \ @brief MDF out-of limit detector control register 3
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDEN                     \ [0x00] OLDx enable
    $01 constant MDF1_THINB                     \ [0x01] Threshold In band
    $04 constant MDF1_BKOLD                     \ [0x04 : 4] Break signal assignment for out-of limit detector
    $0c constant MDF1_ACICN                     \ [0x0c : 2] OLDx CIC order selection
    $11 constant MDF1_ACICD                     \ [0x11 : 5] OLDx CIC decimation ratio selection
    $1f constant MDF1_OLDACTIVE                 \ [0x1f] OLDx active flag
  [then]


  [ifdef] MDF1_MDF_OLD3THLR_DEF
    \
    \ @brief MDF OLD3 low threshold register 3
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHL                    \ [0x00 : 26] OLD low threshold value
  [then]


  [ifdef] MDF1_MDF_OLD3THHR_DEF
    \
    \ @brief MDF OLD3 high threshold register 3
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHH                    \ [0x00 : 26] OLDx high threshold value
  [then]


  [ifdef] MDF1_MDF_DLY3CR_DEF
    \
    \ @brief MDF delay control register 3
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SKPDLY                    \ [0x00 : 7] Delay to apply to a bitstream
    $1f constant MDF1_SKPBF                     \ [0x1f] Skip busy flag
  [then]


  [ifdef] MDF1_MDF_SCD3CR_DEF
    \
    \ @brief MDF short circuit detector control register 3
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SCDEN                     \ [0x00] SCDx enable
    $04 constant MDF1_BKSCD                     \ [0x04 : 4] Break signal assignment for short circuit detector
    $0c constant MDF1_SCDT                      \ [0x0c : 8] SCDx threshold
    $1f constant MDF1_SCDACTIVE                 \ [0x1f] SCDx active flag
  [then]


  [ifdef] MDF1_MDF_DFLT3IER_DEF
    \
    \ @brief MDF DFLT3 interrupt enable register 3
    \ Address offset: 0x22C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHIE                     \ [0x00] RXFIFO threshold interrupt enable
    $01 constant MDF1_DOVRIE                    \ [0x01] Data overflow interrupt enable
    $02 constant MDF1_SSDRIE                    \ [0x02] Snapshot data ready interrupt enable
    $04 constant MDF1_OLDIE                     \ [0x04] OLDx interrupt enable
    $07 constant MDF1_SSOVRIE                   \ [0x07] Snapshot overrun interrupt enable
    $08 constant MDF1_SCDIE                     \ [0x08] SCDx interrupt enable
    $09 constant MDF1_SATIE                     \ [0x09] Saturation detection interrupt enable
    $0a constant MDF1_CKABIE                    \ [0x0a] Clock absence detection interrupt enable
    $0b constant MDF1_RFOVRIE                   \ [0x0b] Reshape filter overrun interrupt enable
  [then]


  [ifdef] MDF1_MDF_DFLT3ISR_DEF
    \
    \ @brief MDF DFLT3 interrupt status register 3
    \ Address offset: 0x230
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHF                      \ [0x00] RXFIFO threshold flag
    $01 constant MDF1_DOVRF                     \ [0x01] Data overflow flag
    $02 constant MDF1_SSDRF                     \ [0x02] Snapshot data ready flag
    $03 constant MDF1_RXNEF                     \ [0x03] RXFIFO not-empty flag
    $04 constant MDF1_OLDF                      \ [0x04] OLDx flag
    $05 constant MDF1_THLF                      \ [0x05] Low-threshold status flag
    $06 constant MDF1_THHF                      \ [0x06] High-threshold status flag
    $07 constant MDF1_SSOVRF                    \ [0x07] Snapshot overrun flag
    $08 constant MDF1_SCDF                      \ [0x08] Short-circuit detector flag
    $09 constant MDF1_SATF                      \ [0x09] Saturation detection flag
    $0a constant MDF1_CKABF                     \ [0x0a] Clock absence detection flag
    $0b constant MDF1_RFOVRF                    \ [0x0b] Reshape filter overrun detection flag
  [then]


  [ifdef] MDF1_MDF_OEC3CR_DEF
    \
    \ @brief MDF offset error compensation control register 3
    \ Address offset: 0x234
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OFFSET                    \ [0x00 : 26] Offset error compensation
  [then]


  [ifdef] MDF1_MDF_SNPS3DR_DEF
    \
    \ @brief MDF snapshot data register 3
    \ Address offset: 0x26C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_MCICDC                    \ [0x00 : 9] Contains the MCIC decimation counter value when the last trigger event occurs (MCIC_CNT)
    $09 constant MDF1_EXTSDR                    \ [0x09 : 7] Extended data size
    $10 constant MDF1_SDR                       \ [0x10 : 16] Contains the 16 MSB of the last valid data processed by the digital filter.
  [then]


  [ifdef] MDF1_MDF_DFLT3DR_DEF
    \
    \ @brief MDF digital filter data register 3
    \ Address offset: 0x270
    \ Reset value: 0x00000000
    \
    $08 constant MDF1_DR                        \ [0x08 : 24] Data processed by digital filter
  [then]


  [ifdef] MDF1_MDF_SITF4CR_DEF
    \
    \ @brief MDF serial interface control register 4
    \ Address offset: 0x280
    \ Reset value: 0x00001F00
    \
    $00 constant MDF1_SITFEN                    \ [0x00] Serial interface enable
    $01 constant MDF1_SCKSRC                    \ [0x01 : 2] Serial clock source
    $04 constant MDF1_SITFMOD                   \ [0x04 : 2] Serial interface type
    $08 constant MDF1_STH                       \ [0x08 : 5] Manchester symbol threshold/SPI threshold
    $1f constant MDF1_SITFACTIVE                \ [0x1f] Serial interface active flag
  [then]


  [ifdef] MDF1_MDF_BSMX4CR_DEF
    \
    \ @brief MDF bitstream matrix control register 4
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_BSSEL                     \ [0x00 : 5] Bitstream Selection
    $1f constant MDF1_BSMXACTIVE                \ [0x1f] BSMX active flag
  [then]


  [ifdef] MDF1_MDF_DFLT4CR_DEF
    \
    \ @brief MDF digital filter control register 4
    \ Address offset: 0x288
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DFLTEN                    \ [0x00] Digital filter enable
    $01 constant MDF1_DMAEN                     \ [0x01] DMA requests enable
    $02 constant MDF1_FTH                       \ [0x02] RXFIFO Threshold selection
    $04 constant MDF1_ACQMOD                    \ [0x04 : 3] Digital filter trigger mode
    $08 constant MDF1_TRGSENS                   \ [0x08] Digital filter trigger sensitivity selection
    $0c constant MDF1_TRGSRC                    \ [0x0c : 4] Digital filter trigger signal selection
    $10 constant MDF1_SNPSFMT                   \ [0x10] Snapshot data format
    $14 constant MDF1_NBDIS                     \ [0x14 : 8] Number of samples to be discarded
    $1e constant MDF1_DFLTRUN                   \ [0x1e] Digital filter run status flag
    $1f constant MDF1_DFLTACTIVE                \ [0x1f] Digital filter active flag
  [then]


  [ifdef] MDF1_MDF_DFLT4CICR_DEF
    \
    \ @brief MDF digital filter configuration register 4
    \ Address offset: 0x28C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DATSRC                    \ [0x00 : 2] Source data for the digital filter
    $04 constant MDF1_CICMOD                    \ [0x04 : 3] Select the CIC mode
    $08 constant MDF1_MCICD                     \ [0x08 : 8] CIC decimation ratio selection
    $10 constant MDF1_MCICD8                    \ [0x10] CIC decimation ratio selection
    $14 constant MDF1_SCALE                     \ [0x14 : 6] Scaling factor selection
  [then]


  [ifdef] MDF1_MDF_DFLT4RSFR_DEF
    \
    \ @brief MDF reshape filter configuration register 4
    \ Address offset: 0x290
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_RSFLTBYP                  \ [0x00] Reshaper filter bypass
    $04 constant MDF1_RSFLTD                    \ [0x04] Reshaper filter decimation ratio
    $07 constant MDF1_HPFBYP                    \ [0x07] High-pass filter bypass
    $08 constant MDF1_HPFC                      \ [0x08 : 2] High-pass filter cut-off frequency
  [then]


  [ifdef] MDF1_MDF_DFLT4INTR_DEF
    \
    \ @brief MDF integrator configuration register 4
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_INTDIV                    \ [0x00 : 2] Integrator output division
    $04 constant MDF1_INTVAL                    \ [0x04 : 7] Integration value selection
  [then]


  [ifdef] MDF1_MDF_OLD4CR_DEF
    \
    \ @brief MDF out-of limit detector control register 4
    \ Address offset: 0x298
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDEN                     \ [0x00] OLDx enable
    $01 constant MDF1_THINB                     \ [0x01] Threshold In band
    $04 constant MDF1_BKOLD                     \ [0x04 : 4] Break signal assignment for out-of limit detector
    $0c constant MDF1_ACICN                     \ [0x0c : 2] OLDx CIC order selection
    $11 constant MDF1_ACICD                     \ [0x11 : 5] OLDx CIC decimation ratio selection
    $1f constant MDF1_OLDACTIVE                 \ [0x1f] OLDx active flag
  [then]


  [ifdef] MDF1_MDF_OLD4THLR_DEF
    \
    \ @brief MDF OLD4 low threshold register 4
    \ Address offset: 0x29C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHL                    \ [0x00 : 26] OLD low threshold value
  [then]


  [ifdef] MDF1_MDF_OLD4THHR_DEF
    \
    \ @brief MDF OLD4 high threshold register 4
    \ Address offset: 0x2A0
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHH                    \ [0x00 : 26] OLDx high threshold value
  [then]


  [ifdef] MDF1_MDF_DLY4CR_DEF
    \
    \ @brief MDF delay control register 4
    \ Address offset: 0x2A4
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SKPDLY                    \ [0x00 : 7] Delay to apply to a bitstream
    $1f constant MDF1_SKPBF                     \ [0x1f] Skip busy flag
  [then]


  [ifdef] MDF1_MDF_SCD4CR_DEF
    \
    \ @brief MDF short circuit detector control register 4
    \ Address offset: 0x2A8
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SCDEN                     \ [0x00] SCDx enable
    $04 constant MDF1_BKSCD                     \ [0x04 : 4] Break signal assignment for short circuit detector
    $0c constant MDF1_SCDT                      \ [0x0c : 8] SCDx threshold
    $1f constant MDF1_SCDACTIVE                 \ [0x1f] SCDx active flag
  [then]


  [ifdef] MDF1_MDF_DFLT4IER_DEF
    \
    \ @brief MDF DFLT4 interrupt enable register 4
    \ Address offset: 0x2AC
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHIE                     \ [0x00] RXFIFO threshold interrupt enable
    $01 constant MDF1_DOVRIE                    \ [0x01] Data overflow interrupt enable
    $02 constant MDF1_SSDRIE                    \ [0x02] Snapshot data ready interrupt enable
    $04 constant MDF1_OLDIE                     \ [0x04] OLDx interrupt enable
    $07 constant MDF1_SSOVRIE                   \ [0x07] Snapshot overrun interrupt enable
    $08 constant MDF1_SCDIE                     \ [0x08] SCDx interrupt enable
    $09 constant MDF1_SATIE                     \ [0x09] Saturation detection interrupt enable
    $0a constant MDF1_CKABIE                    \ [0x0a] Clock absence detection interrupt enable
    $0b constant MDF1_RFOVRIE                   \ [0x0b] Reshape filter overrun interrupt enable
  [then]


  [ifdef] MDF1_MDF_DFLT4ISR_DEF
    \
    \ @brief MDF DFLT4 interrupt status register 4
    \ Address offset: 0x2B0
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHF                      \ [0x00] RXFIFO threshold flag
    $01 constant MDF1_DOVRF                     \ [0x01] Data overflow flag
    $02 constant MDF1_SSDRF                     \ [0x02] Snapshot data ready flag
    $03 constant MDF1_RXNEF                     \ [0x03] RXFIFO not-empty flag
    $04 constant MDF1_OLDF                      \ [0x04] OLDx flag
    $05 constant MDF1_THLF                      \ [0x05] Low-threshold status flag
    $06 constant MDF1_THHF                      \ [0x06] High-threshold status flag
    $07 constant MDF1_SSOVRF                    \ [0x07] Snapshot overrun flag
    $08 constant MDF1_SCDF                      \ [0x08] Short-circuit detector flag
    $09 constant MDF1_SATF                      \ [0x09] Saturation detection flag
    $0a constant MDF1_CKABF                     \ [0x0a] Clock absence detection flag
    $0b constant MDF1_RFOVRF                    \ [0x0b] Reshape filter overrun detection flag
  [then]


  [ifdef] MDF1_MDF_OEC4CR_DEF
    \
    \ @brief MDF offset error compensation control register 4
    \ Address offset: 0x2B4
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OFFSET                    \ [0x00 : 26] Offset error compensation
  [then]


  [ifdef] MDF1_MDF_SNPS4DR_DEF
    \
    \ @brief MDF snapshot data register 4
    \ Address offset: 0x2EC
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_MCICDC                    \ [0x00 : 9] Contains the MCIC decimation counter value when the last trigger event occurs (MCIC_CNT)
    $09 constant MDF1_EXTSDR                    \ [0x09 : 7] Extended data size
    $10 constant MDF1_SDR                       \ [0x10 : 16] Contains the 16 MSB of the last valid data processed by the digital filter.
  [then]


  [ifdef] MDF1_MDF_DFLT4DR_DEF
    \
    \ @brief MDF digital filter data register 4
    \ Address offset: 0x2F0
    \ Reset value: 0x00000000
    \
    $08 constant MDF1_DR                        \ [0x08 : 24] Data processed by digital filter
  [then]


  [ifdef] MDF1_MDF_SITF5CR_DEF
    \
    \ @brief MDF serial interface control register 5
    \ Address offset: 0x300
    \ Reset value: 0x00001F00
    \
    $00 constant MDF1_SITFEN                    \ [0x00] Serial interface enable
    $01 constant MDF1_SCKSRC                    \ [0x01 : 2] Serial clock source
    $04 constant MDF1_SITFMOD                   \ [0x04 : 2] Serial interface type
    $08 constant MDF1_STH                       \ [0x08 : 5] Manchester symbol threshold/SPI threshold
    $1f constant MDF1_SITFACTIVE                \ [0x1f] Serial interface active flag
  [then]


  [ifdef] MDF1_MDF_BSMX5CR_DEF
    \
    \ @brief MDF bitstream matrix control register 5
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_BSSEL                     \ [0x00 : 5] Bitstream Selection
    $1f constant MDF1_BSMXACTIVE                \ [0x1f] BSMX active flag
  [then]


  [ifdef] MDF1_MDF_DFLT5CR_DEF
    \
    \ @brief MDF digital filter control register 5
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DFLTEN                    \ [0x00] Digital filter enable
    $01 constant MDF1_DMAEN                     \ [0x01] DMA requests enable
    $02 constant MDF1_FTH                       \ [0x02] RXFIFO Threshold selection
    $04 constant MDF1_ACQMOD                    \ [0x04 : 3] Digital filter trigger mode
    $08 constant MDF1_TRGSENS                   \ [0x08] Digital filter trigger sensitivity selection
    $0c constant MDF1_TRGSRC                    \ [0x0c : 4] Digital filter trigger signal selection
    $10 constant MDF1_SNPSFMT                   \ [0x10] Snapshot data format
    $14 constant MDF1_NBDIS                     \ [0x14 : 8] Number of samples to be discarded
    $1e constant MDF1_DFLTRUN                   \ [0x1e] Digital filter run status flag
    $1f constant MDF1_DFLTACTIVE                \ [0x1f] Digital filter active flag
  [then]


  [ifdef] MDF1_MDF_DFLT5CICR_DEF
    \
    \ @brief MDF digital filter configuration register 5
    \ Address offset: 0x30C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_DATSRC                    \ [0x00 : 2] Source data for the digital filter
    $04 constant MDF1_CICMOD                    \ [0x04 : 3] Select the CIC mode
    $08 constant MDF1_MCICD                     \ [0x08 : 8] CIC decimation ratio selection
    $10 constant MDF1_MCICD8                    \ [0x10] CIC decimation ratio selection
    $14 constant MDF1_SCALE                     \ [0x14 : 6] Scaling factor selection
  [then]


  [ifdef] MDF1_MDF_DFLT5RSFR_DEF
    \
    \ @brief MDF reshape filter configuration register 5
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_RSFLTBYP                  \ [0x00] Reshaper filter bypass
    $04 constant MDF1_RSFLTD                    \ [0x04] Reshaper filter decimation ratio
    $07 constant MDF1_HPFBYP                    \ [0x07] High-pass filter bypass
    $08 constant MDF1_HPFC                      \ [0x08 : 2] High-pass filter cut-off frequency
  [then]


  [ifdef] MDF1_MDF_DFLT5INTR_DEF
    \
    \ @brief MDF integrator configuration register 5
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_INTDIV                    \ [0x00 : 2] Integrator output division
    $04 constant MDF1_INTVAL                    \ [0x04 : 7] Integration value selection
  [then]


  [ifdef] MDF1_MDF_OLD5CR_DEF
    \
    \ @brief MDF out-of limit detector control register 5
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDEN                     \ [0x00] OLDx enable
    $01 constant MDF1_THINB                     \ [0x01] Threshold In band
    $04 constant MDF1_BKOLD                     \ [0x04 : 4] Break signal assignment for out-of limit detector
    $0c constant MDF1_ACICN                     \ [0x0c : 2] OLDx CIC order selection
    $11 constant MDF1_ACICD                     \ [0x11 : 5] OLDx CIC decimation ratio selection
    $1f constant MDF1_OLDACTIVE                 \ [0x1f] OLDx active flag
  [then]


  [ifdef] MDF1_MDF_OLD5THLR_DEF
    \
    \ @brief MDF OLD5 low threshold register 5
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHL                    \ [0x00 : 26] OLD low threshold value
  [then]


  [ifdef] MDF1_MDF_OLD5THHR_DEF
    \
    \ @brief MDF OLD5 high threshold register 5
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OLDTHH                    \ [0x00 : 26] OLDx high threshold value
  [then]


  [ifdef] MDF1_MDF_DLY5CR_DEF
    \
    \ @brief MDF delay control register 5
    \ Address offset: 0x324
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SKPDLY                    \ [0x00 : 7] Delay to apply to a bitstream
    $1f constant MDF1_SKPBF                     \ [0x1f] Skip busy flag
  [then]


  [ifdef] MDF1_MDF_SCD5CR_DEF
    \
    \ @brief MDF short circuit detector control register 5
    \ Address offset: 0x328
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_SCDEN                     \ [0x00] SCDx enable
    $04 constant MDF1_BKSCD                     \ [0x04 : 4] Break signal assignment for short circuit detector
    $0c constant MDF1_SCDT                      \ [0x0c : 8] SCDx threshold
    $1f constant MDF1_SCDACTIVE                 \ [0x1f] SCDx active flag
  [then]


  [ifdef] MDF1_MDF_DFLT5IER_DEF
    \
    \ @brief MDF DFLT5 interrupt enable register 5
    \ Address offset: 0x32C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHIE                     \ [0x00] RXFIFO threshold interrupt enable
    $01 constant MDF1_DOVRIE                    \ [0x01] Data overflow interrupt enable
    $02 constant MDF1_SSDRIE                    \ [0x02] Snapshot data ready interrupt enable
    $04 constant MDF1_OLDIE                     \ [0x04] OLDx interrupt enable
    $07 constant MDF1_SSOVRIE                   \ [0x07] Snapshot overrun interrupt enable
    $08 constant MDF1_SCDIE                     \ [0x08] SCDx interrupt enable
    $09 constant MDF1_SATIE                     \ [0x09] Saturation detection interrupt enable
    $0a constant MDF1_CKABIE                    \ [0x0a] Clock absence detection interrupt enable
    $0b constant MDF1_RFOVRIE                   \ [0x0b] Reshape filter overrun interrupt enable
  [then]


  [ifdef] MDF1_MDF_DFLT5ISR_DEF
    \
    \ @brief MDF DFLT5 interrupt status register 5
    \ Address offset: 0x330
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_FTHF                      \ [0x00] RXFIFO threshold flag
    $01 constant MDF1_DOVRF                     \ [0x01] Data overflow flag
    $02 constant MDF1_SSDRF                     \ [0x02] Snapshot data ready flag
    $03 constant MDF1_RXNEF                     \ [0x03] RXFIFO not-empty flag
    $04 constant MDF1_OLDF                      \ [0x04] OLDx flag
    $05 constant MDF1_THLF                      \ [0x05] Low-threshold status flag
    $06 constant MDF1_THHF                      \ [0x06] High-threshold status flag
    $07 constant MDF1_SSOVRF                    \ [0x07] Snapshot overrun flag
    $08 constant MDF1_SCDF                      \ [0x08] Short-circuit detector flag
    $09 constant MDF1_SATF                      \ [0x09] Saturation detection flag
    $0a constant MDF1_CKABF                     \ [0x0a] Clock absence detection flag
    $0b constant MDF1_RFOVRF                    \ [0x0b] Reshape filter overrun detection flag
  [then]


  [ifdef] MDF1_MDF_OEC5CR_DEF
    \
    \ @brief MDF offset error compensation control register 5
    \ Address offset: 0x334
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_OFFSET                    \ [0x00 : 26] Offset error compensation
  [then]


  [ifdef] MDF1_MDF_SNPS5DR_DEF
    \
    \ @brief MDF snapshot data register 5
    \ Address offset: 0x36C
    \ Reset value: 0x00000000
    \
    $00 constant MDF1_MCICDC                    \ [0x00 : 9] Contains the MCIC decimation counter value when the last trigger event occurs (MCIC_CNT)
    $09 constant MDF1_EXTSDR                    \ [0x09 : 7] Extended data size
    $10 constant MDF1_SDR                       \ [0x10 : 16] Contains the 16 MSB of the last valid data processed by the digital filter.
  [then]


  [ifdef] MDF1_MDF_DFLT5DR_DEF
    \
    \ @brief MDF digital filter data register 5
    \ Address offset: 0x370
    \ Reset value: 0x00000000
    \
    $08 constant MDF1_DR                        \ [0x08 : 24] Data processed by digital filter
  [then]

  \
  \ @brief MDF register block
  \
  $00 constant MDF1_MDF_GCR             \ MDF global control register
  $04 constant MDF1_MDF_CKGCR           \ MDF clock generator control register
  $80 constant MDF1_MDF_SITF0CR         \ MDF serial interface control register 0
  $84 constant MDF1_MDF_BSMX0CR         \ MDF bitstream matrix control register 0
  $88 constant MDF1_MDF_DFLT0CR         \ MDF digital filter control register 0
  $8C constant MDF1_MDF_DFLT0CICR       \ MDF digital filter configuration register 0
  $90 constant MDF1_MDF_DFLT0RSFR       \ MDF reshape filter configuration register 0
  $94 constant MDF1_MDF_DFLT0INTR       \ MDF integrator configuration register 0
  $98 constant MDF1_MDF_OLD0CR          \ MDF out-of limit detector control register 0
  $9C constant MDF1_MDF_OLD0THLR        \ MDF OLD0 low threshold register 0
  $A0 constant MDF1_MDF_OLD0THHR        \ MDF OLD0 high threshold register 0
  $A4 constant MDF1_MDF_DLY0CR          \ MDF delay control register 0
  $A8 constant MDF1_MDF_SCD0CR          \ MDF short circuit detector control register 0
  $AC constant MDF1_MDF_DFLT0IER        \ MDF DFLT0 interrupt enable register 0
  $B0 constant MDF1_MDF_DFLT0ISR        \ MDF DFLT0 interrupt status register 0
  $B4 constant MDF1_MDF_OEC0CR          \ MDF offset error compensation control register 0
  $EC constant MDF1_MDF_SNPS0DR         \ MDF snapshot data register 0
  $F0 constant MDF1_MDF_DFLT0DR         \ MDF digital filter data register 0
  $100 constant MDF1_MDF_SITF1CR        \ MDF serial interface control register 1
  $104 constant MDF1_MDF_BSMX1CR        \ MDF bitstream matrix control register 1
  $108 constant MDF1_MDF_DFLT1CR        \ MDF digital filter control register 1
  $10C constant MDF1_MDF_DFLT1CICR      \ MDF digital filter configuration register 1
  $110 constant MDF1_MDF_DFLT1RSFR      \ MDF reshape filter configuration register 1
  $114 constant MDF1_MDF_DFLT1INTR      \ MDF integrator configuration register 1
  $118 constant MDF1_MDF_OLD1CR         \ MDF out-of limit detector control register 1
  $11C constant MDF1_MDF_OLD1THLR       \ MDF OLD1 low threshold register 1
  $120 constant MDF1_MDF_OLD1THHR       \ MDF OLD1 high threshold register 1
  $124 constant MDF1_MDF_DLY1CR         \ MDF delay control register 1
  $128 constant MDF1_MDF_SCD1CR         \ MDF short circuit detector control register 1
  $12C constant MDF1_MDF_DFLT1IER       \ MDF DFLT1 interrupt enable register 1
  $130 constant MDF1_MDF_DFLT1ISR       \ MDF DFLT1 interrupt status register 1
  $134 constant MDF1_MDF_OEC1CR         \ MDF offset error compensation control register 1
  $16C constant MDF1_MDF_SNPS1DR        \ MDF snapshot data register 1
  $170 constant MDF1_MDF_DFLT1DR        \ MDF digital filter data register 1
  $180 constant MDF1_MDF_SITF2CR        \ MDF serial interface control register 2
  $184 constant MDF1_MDF_BSMX2CR        \ MDF bitstream matrix control register 2
  $188 constant MDF1_MDF_DFLT2CR        \ MDF digital filter control register 2
  $18C constant MDF1_MDF_DFLT2CICR      \ MDF digital filter configuration register 2
  $190 constant MDF1_MDF_DFLT2RSFR      \ MDF reshape filter configuration register 2
  $194 constant MDF1_MDF_DFLT2INTR      \ MDF integrator configuration register 2
  $198 constant MDF1_MDF_OLD2CR         \ MDF out-of limit detector control register 2
  $19C constant MDF1_MDF_OLD2THLR       \ MDF OLD2 low threshold register 2
  $1A0 constant MDF1_MDF_OLD2THHR       \ MDF OLD2 high threshold register 2
  $1A4 constant MDF1_MDF_DLY2CR         \ MDF delay control register 2
  $1A8 constant MDF1_MDF_SCD2CR         \ MDF short circuit detector control register 2
  $1AC constant MDF1_MDF_DFLT2IER       \ MDF DFLT2 interrupt enable register 2
  $1B0 constant MDF1_MDF_DFLT2ISR       \ MDF DFLT2 interrupt status register 2
  $1B4 constant MDF1_MDF_OEC2CR         \ MDF offset error compensation control register 2
  $1EC constant MDF1_MDF_SNPS2DR        \ MDF snapshot data register 2
  $1F0 constant MDF1_MDF_DFLT2DR        \ MDF digital filter data register 2
  $200 constant MDF1_MDF_SITF3CR        \ MDF serial interface control register 3
  $204 constant MDF1_MDF_BSMX3CR        \ MDF bitstream matrix control register 3
  $208 constant MDF1_MDF_DFLT3CR        \ MDF digital filter control register 3
  $20C constant MDF1_MDF_DFLT3CICR      \ MDF digital filter configuration register 3
  $210 constant MDF1_MDF_DFLT3RSFR      \ MDF reshape filter configuration register 3
  $214 constant MDF1_MDF_DFLT3INTR      \ MDF integrator configuration register 3
  $218 constant MDF1_MDF_OLD3CR         \ MDF out-of limit detector control register 3
  $21C constant MDF1_MDF_OLD3THLR       \ MDF OLD3 low threshold register 3
  $220 constant MDF1_MDF_OLD3THHR       \ MDF OLD3 high threshold register 3
  $224 constant MDF1_MDF_DLY3CR         \ MDF delay control register 3
  $228 constant MDF1_MDF_SCD3CR         \ MDF short circuit detector control register 3
  $22C constant MDF1_MDF_DFLT3IER       \ MDF DFLT3 interrupt enable register 3
  $230 constant MDF1_MDF_DFLT3ISR       \ MDF DFLT3 interrupt status register 3
  $234 constant MDF1_MDF_OEC3CR         \ MDF offset error compensation control register 3
  $26C constant MDF1_MDF_SNPS3DR        \ MDF snapshot data register 3
  $270 constant MDF1_MDF_DFLT3DR        \ MDF digital filter data register 3
  $280 constant MDF1_MDF_SITF4CR        \ MDF serial interface control register 4
  $284 constant MDF1_MDF_BSMX4CR        \ MDF bitstream matrix control register 4
  $288 constant MDF1_MDF_DFLT4CR        \ MDF digital filter control register 4
  $28C constant MDF1_MDF_DFLT4CICR      \ MDF digital filter configuration register 4
  $290 constant MDF1_MDF_DFLT4RSFR      \ MDF reshape filter configuration register 4
  $294 constant MDF1_MDF_DFLT4INTR      \ MDF integrator configuration register 4
  $298 constant MDF1_MDF_OLD4CR         \ MDF out-of limit detector control register 4
  $29C constant MDF1_MDF_OLD4THLR       \ MDF OLD4 low threshold register 4
  $2A0 constant MDF1_MDF_OLD4THHR       \ MDF OLD4 high threshold register 4
  $2A4 constant MDF1_MDF_DLY4CR         \ MDF delay control register 4
  $2A8 constant MDF1_MDF_SCD4CR         \ MDF short circuit detector control register 4
  $2AC constant MDF1_MDF_DFLT4IER       \ MDF DFLT4 interrupt enable register 4
  $2B0 constant MDF1_MDF_DFLT4ISR       \ MDF DFLT4 interrupt status register 4
  $2B4 constant MDF1_MDF_OEC4CR         \ MDF offset error compensation control register 4
  $2EC constant MDF1_MDF_SNPS4DR        \ MDF snapshot data register 4
  $2F0 constant MDF1_MDF_DFLT4DR        \ MDF digital filter data register 4
  $300 constant MDF1_MDF_SITF5CR        \ MDF serial interface control register 5
  $304 constant MDF1_MDF_BSMX5CR        \ MDF bitstream matrix control register 5
  $308 constant MDF1_MDF_DFLT5CR        \ MDF digital filter control register 5
  $30C constant MDF1_MDF_DFLT5CICR      \ MDF digital filter configuration register 5
  $310 constant MDF1_MDF_DFLT5RSFR      \ MDF reshape filter configuration register 5
  $314 constant MDF1_MDF_DFLT5INTR      \ MDF integrator configuration register 5
  $318 constant MDF1_MDF_OLD5CR         \ MDF out-of limit detector control register 5
  $31C constant MDF1_MDF_OLD5THLR       \ MDF OLD5 low threshold register 5
  $320 constant MDF1_MDF_OLD5THHR       \ MDF OLD5 high threshold register 5
  $324 constant MDF1_MDF_DLY5CR         \ MDF delay control register 5
  $328 constant MDF1_MDF_SCD5CR         \ MDF short circuit detector control register 5
  $32C constant MDF1_MDF_DFLT5IER       \ MDF DFLT5 interrupt enable register 5
  $330 constant MDF1_MDF_DFLT5ISR       \ MDF DFLT5 interrupt status register 5
  $334 constant MDF1_MDF_OEC5CR         \ MDF offset error compensation control register 5
  $36C constant MDF1_MDF_SNPS5DR        \ MDF snapshot data register 5
  $370 constant MDF1_MDF_DFLT5DR        \ MDF digital filter data register 5

: MDF1_DEF ; [then]
