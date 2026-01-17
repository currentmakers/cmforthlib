\
\ @file quadspi.fs
\ @brief QuadSPI interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] QUADSPI_DEF

  [ifdef] QUADSPI_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_EN                     \ [0x00] Enable
    $01 constant QUADSPI_ABORT                  \ [0x01] Abort request
    $02 constant QUADSPI_DMAEN                  \ [0x02] DMA enable
    $03 constant QUADSPI_TCEN                   \ [0x03] Timeout counter enable
    $04 constant QUADSPI_SSHIFT                 \ [0x04] Sample shift
    $06 constant QUADSPI_DFM                    \ [0x06] DFM
    $07 constant QUADSPI_FSEL                   \ [0x07] FSEL
    $08 constant QUADSPI_FTHRES                 \ [0x08 : 5] IFO threshold level
    $10 constant QUADSPI_TEIE                   \ [0x10] Transfer error interrupt enable
    $11 constant QUADSPI_TCIE                   \ [0x11] Transfer complete interrupt enable
    $12 constant QUADSPI_FTIE                   \ [0x12] FIFO threshold interrupt enable
    $13 constant QUADSPI_SMIE                   \ [0x13] Status match interrupt enable
    $14 constant QUADSPI_TOIE                   \ [0x14] TimeOut interrupt enable
    $16 constant QUADSPI_APMS                   \ [0x16] Automatic poll mode stop
    $17 constant QUADSPI_PMM                    \ [0x17] Polling match mode
    $18 constant QUADSPI_PRESCALER              \ [0x18 : 8] Clock prescaler
  [then]


  [ifdef] QUADSPI_DCR_DEF
    \
    \ @brief device configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_CKMODE                 \ [0x00] Mode 0 / mode 3
    $08 constant QUADSPI_CSHT                   \ [0x08 : 3] Chip select high time
    $10 constant QUADSPI_FSIZE                  \ [0x10 : 5] FLASH memory size
  [then]


  [ifdef] QUADSPI_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_TEF                    \ [0x00] Transfer error flag
    $01 constant QUADSPI_TCF                    \ [0x01] Transfer complete flag
    $02 constant QUADSPI_FTF                    \ [0x02] FIFO threshold flag
    $03 constant QUADSPI_SMF                    \ [0x03] Status match flag
    $04 constant QUADSPI_TOF                    \ [0x04] Timeout flag
    $05 constant QUADSPI_BUSY                   \ [0x05] Busy
    $08 constant QUADSPI_FLEVEL                 \ [0x08 : 5] FIFO level
  [then]


  [ifdef] QUADSPI_FCR_DEF
    \
    \ @brief flag clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_CTEF                   \ [0x00] Clear transfer error flag
    $01 constant QUADSPI_CTCF                   \ [0x01] Clear transfer complete flag
    $03 constant QUADSPI_CSMF                   \ [0x03] Clear status match flag
    $04 constant QUADSPI_CTOF                   \ [0x04] Clear timeout flag
  [then]


  [ifdef] QUADSPI_DLR_DEF
    \
    \ @brief data length register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_DL                     \ [0x00 : 32] Data length
  [then]


  [ifdef] QUADSPI_CCR_DEF
    \
    \ @brief communication configuration register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_INSTRUCTION            \ [0x00 : 8] Instruction
    $08 constant QUADSPI_IMODE                  \ [0x08 : 2] Instruction mode
    $0a constant QUADSPI_ADMODE                 \ [0x0a : 2] Address mode
    $0c constant QUADSPI_ADSIZE                 \ [0x0c : 2] Address size
    $0e constant QUADSPI_ABMODE                 \ [0x0e : 2] Alternate bytes mode
    $10 constant QUADSPI_ABSIZE                 \ [0x10 : 2] Alternate bytes size
    $12 constant QUADSPI_DCYC                   \ [0x12 : 5] Number of dummy cycles
    $18 constant QUADSPI_DMODE                  \ [0x18 : 2] Data mode
    $1a constant QUADSPI_FMODE                  \ [0x1a : 2] Functional mode
    $1c constant QUADSPI_SIOO                   \ [0x1c] Send instruction only once mode
    $1f constant QUADSPI_DDRM                   \ [0x1f] Double data rate mode
  [then]


  [ifdef] QUADSPI_AR_DEF
    \
    \ @brief address register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_ADDRESS                \ [0x00 : 32] Address
  [then]


  [ifdef] QUADSPI_ABR_DEF
    \
    \ @brief ABR
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_ALTERNATE              \ [0x00 : 32] ALTERNATE
  [then]


  [ifdef] QUADSPI_DR_DEF
    \
    \ @brief data register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_DATA                   \ [0x00 : 32] Data
  [then]


  [ifdef] QUADSPI_PSMKR_DEF
    \
    \ @brief polling status mask register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_MASK                   \ [0x00 : 32] Status mask
  [then]


  [ifdef] QUADSPI_PSMAR_DEF
    \
    \ @brief polling status match register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_MATCH                  \ [0x00 : 32] Status match
  [then]


  [ifdef] QUADSPI_PIR_DEF
    \
    \ @brief polling interval register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_INTERVAL               \ [0x00 : 16] Polling interval
  [then]


  [ifdef] QUADSPI_LPTR_DEF
    \
    \ @brief low-power timeout register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant QUADSPI_TIMEOUT                \ [0x00 : 16] Timeout period
  [then]

  \
  \ @brief QuadSPI interface
  \
  $00 constant QUADSPI_CR               \ control register
  $04 constant QUADSPI_DCR              \ device configuration register
  $08 constant QUADSPI_SR               \ status register
  $0C constant QUADSPI_FCR              \ flag clear register
  $10 constant QUADSPI_DLR              \ data length register
  $14 constant QUADSPI_CCR              \ communication configuration register
  $18 constant QUADSPI_AR               \ address register
  $1C constant QUADSPI_ABR              \ ABR
  $20 constant QUADSPI_DR               \ data register
  $24 constant QUADSPI_PSMKR            \ polling status mask register
  $28 constant QUADSPI_PSMAR            \ polling status match register
  $2C constant QUADSPI_PIR              \ polling interval register
  $30 constant QUADSPI_LPTR             \ low-power timeout register

: QUADSPI_DEF ; [then]
