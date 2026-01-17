\
\ @file octospi.fs
\ @brief OctoSPI
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OCTOSPI_DEF

  [ifdef] OCTOSPI_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_EN                     \ [0x00] Enable
    $01 constant OCTOSPI_ABORT                  \ [0x01] Abort request
    $02 constant OCTOSPI_DMAEN                  \ [0x02] DMA enable
    $03 constant OCTOSPI_TCEN                   \ [0x03] Timeout counter enable
    $06 constant OCTOSPI_DQM                    \ [0x06] Dual-quad mode
    $07 constant OCTOSPI_FSEL                   \ [0x07] FLASH memory selection
    $08 constant OCTOSPI_FTHRES                 \ [0x08 : 5] IFO threshold level
    $10 constant OCTOSPI_TEIE                   \ [0x10] Transfer error interrupt enable
    $11 constant OCTOSPI_TCIE                   \ [0x11] Transfer complete interrupt enable
    $12 constant OCTOSPI_FTIE                   \ [0x12] FIFO threshold interrupt enable
    $13 constant OCTOSPI_SMIE                   \ [0x13] Status match interrupt enable
    $14 constant OCTOSPI_TOIE                   \ [0x14] TimeOut interrupt enable
    $16 constant OCTOSPI_APMS                   \ [0x16] Automatic poll mode stop
    $17 constant OCTOSPI_PMM                    \ [0x17] Polling match mode
    $1c constant OCTOSPI_FMODE                  \ [0x1c : 2] Functional mode
  [then]


  [ifdef] OCTOSPI_DCR1_DEF
    \
    \ @brief device configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_CKMODE                 \ [0x00] Mode 0 / mode 3
    $01 constant OCTOSPI_FRCK                   \ [0x01] Free running clock
    $08 constant OCTOSPI_CSHT                   \ [0x08 : 3] Chip-select high time
    $10 constant OCTOSPI_DEVSIZE                \ [0x10 : 5] Device size
    $18 constant OCTOSPI_MTYP                   \ [0x18 : 2] Memory type
  [then]


  [ifdef] OCTOSPI_DCR2_DEF
    \
    \ @brief device configuration register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_PRESCALER              \ [0x00 : 8] Clock prescaler
    $10 constant OCTOSPI_WRAPSIZE               \ [0x10 : 3] Wrap size
  [then]


  [ifdef] OCTOSPI_DCR3_DEF
    \
    \ @brief device configuration register 3
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $10 constant OCTOSPI_CSBOUND                \ [0x10 : 5] CS boundary
  [then]


  [ifdef] OCTOSPI_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_TEF                    \ [0x00] Transfer error flag
    $01 constant OCTOSPI_TCF                    \ [0x01] Transfer complete flag
    $02 constant OCTOSPI_FTF                    \ [0x02] FIFO threshold flag
    $03 constant OCTOSPI_SMF                    \ [0x03] Status match flag
    $04 constant OCTOSPI_TOF                    \ [0x04] Timeout flag
    $05 constant OCTOSPI_BUSY                   \ [0x05] BUSY
    $08 constant OCTOSPI_FLEVEL                 \ [0x08 : 6] FIFO level
  [then]


  [ifdef] OCTOSPI_FCR_DEF
    \
    \ @brief flag clear register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_CTEF                   \ [0x00] Clear transfer error flag
    $01 constant OCTOSPI_CTCF                   \ [0x01] Clear transfer complete flag
    $03 constant OCTOSPI_CSMF                   \ [0x03] Clear status match flag
    $04 constant OCTOSPI_CTOF                   \ [0x04] Clear timeout flag
  [then]


  [ifdef] OCTOSPI_DLR_DEF
    \
    \ @brief data length register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_DL                     \ [0x00 : 32] Data length
  [then]


  [ifdef] OCTOSPI_AR_DEF
    \
    \ @brief address register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_ADDRESS                \ [0x00 : 32] ADDRESS
  [then]


  [ifdef] OCTOSPI_DR_DEF
    \
    \ @brief data register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_DATA                   \ [0x00 : 32] Data
  [then]


  [ifdef] OCTOSPI_PSMKR_DEF
    \
    \ @brief polling status mask register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_MASK                   \ [0x00 : 32] Status mask
  [then]


  [ifdef] OCTOSPI_PSMAR_DEF
    \
    \ @brief polling status match register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_MATCH                  \ [0x00 : 32] Status match
  [then]


  [ifdef] OCTOSPI_PIR_DEF
    \
    \ @brief polling interval register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_INTERVAL               \ [0x00 : 16] Polling interval
  [then]


  [ifdef] OCTOSPI_CCR_DEF
    \
    \ @brief communication configuration register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_IMODE                  \ [0x00 : 3] Instruction mode
    $03 constant OCTOSPI_IDTR                   \ [0x03] Instruction double transfer rate
    $04 constant OCTOSPI_ISIZE                  \ [0x04 : 2] Instruction size
    $08 constant OCTOSPI_ADMODE                 \ [0x08 : 3] Address mode
    $0b constant OCTOSPI_ADDTR                  \ [0x0b] Address double transfer rate
    $0c constant OCTOSPI_ADSIZE                 \ [0x0c : 2] Address size
    $10 constant OCTOSPI_ABMODE                 \ [0x10 : 3] Alternate byte mode
    $13 constant OCTOSPI_ABDTR                  \ [0x13] Alternate bytes double transfer rate
    $14 constant OCTOSPI_ABSIZE                 \ [0x14 : 2] Alternate bytes size
    $18 constant OCTOSPI_DMODE                  \ [0x18 : 3] Data mode
    $1b constant OCTOSPI_DDTR                   \ [0x1b] Alternate bytes double transfer rate
    $1d constant OCTOSPI_DQSE                   \ [0x1d] DQS enable
    $1f constant OCTOSPI_SIOO                   \ [0x1f] Send instruction only once mode
  [then]


  [ifdef] OCTOSPI_TCR_DEF
    \
    \ @brief timing configuration register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_DCYC                   \ [0x00 : 5] Number of dummy cycles
    $1c constant OCTOSPI_DHQC                   \ [0x1c] Delay hold quarter cycle
    $1e constant OCTOSPI_SSHIFT                 \ [0x1e] Sample shift
  [then]


  [ifdef] OCTOSPI_IR_DEF
    \
    \ @brief instruction register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_INSTRUCTION            \ [0x00 : 32] INSTRUCTION
  [then]


  [ifdef] OCTOSPI_ABR_DEF
    \
    \ @brief alternate bytes register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_ALTERNATE              \ [0x00 : 32] Alternate bytes
  [then]


  [ifdef] OCTOSPI_LPTR_DEF
    \
    \ @brief low-power timeout register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_TIMEOUT                \ [0x00 : 16] Timeout period
  [then]


  [ifdef] OCTOSPI_WCCR_DEF
    \
    \ @brief write communication configuration register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_IMODE                  \ [0x00 : 3] Instruction mode
    $03 constant OCTOSPI_IDTR                   \ [0x03] Instruction double transfer rate
    $04 constant OCTOSPI_ISIZE                  \ [0x04 : 2] Instruction size
    $08 constant OCTOSPI_ADMODE                 \ [0x08 : 3] Address mode
    $0b constant OCTOSPI_ADDTR                  \ [0x0b] Address double transfer rate
    $0c constant OCTOSPI_ADSIZE                 \ [0x0c : 2] Address size
    $10 constant OCTOSPI_ABMODE                 \ [0x10 : 3] Alternate byte mode
    $13 constant OCTOSPI_ABDTR                  \ [0x13] Alternate bytes double transfer rate
    $14 constant OCTOSPI_ABSIZE                 \ [0x14 : 2] Alternate bytes size
    $18 constant OCTOSPI_DMODE                  \ [0x18 : 3] Data mode
    $1b constant OCTOSPI_DDTR                   \ [0x1b] alternate bytes double transfer rate
    $1d constant OCTOSPI_DQSE                   \ [0x1d] DQS enable
    $1f constant OCTOSPI_SIOO                   \ [0x1f] Send instruction only once mode
  [then]


  [ifdef] OCTOSPI_WTCR_DEF
    \
    \ @brief write timing configuration register
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_DCYC                   \ [0x00 : 5] Number of dummy cycles
  [then]


  [ifdef] OCTOSPI_WIR_DEF
    \
    \ @brief write instruction register
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_INSTRUCTION            \ [0x00 : 32] INSTRUCTION
  [then]


  [ifdef] OCTOSPI_WABR_DEF
    \
    \ @brief write alternate bytes register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_ALTERNATE              \ [0x00 : 32] Alternate bytes
  [then]


  [ifdef] OCTOSPI_HLCR_DEF
    \
    \ @brief HyperBusTM latency configuration register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI_LM                     \ [0x00] Latency mode
    $01 constant OCTOSPI_WZL                    \ [0x01] Write zero latency
    $08 constant OCTOSPI_TACC                   \ [0x08 : 8] Access time
    $10 constant OCTOSPI_TRWR                   \ [0x10 : 8] Read write recovery time
  [then]


  [ifdef] OCTOSPI_HWCFGR_DEF
    \
    \ @brief HW configuration register
    \ Address offset: 0x3F0
    \ Reset value: 0x11300080
    \
    $00 constant OCTOSPI_AXI                    \ [0x00 : 4] AXI interface
    $04 constant OCTOSPI_FIFO                   \ [0x04 : 8] FIFO depth
    $0c constant OCTOSPI_PRES                   \ [0x0c : 8] Prescaler
    $14 constant OCTOSPI_IDL                    \ [0x14 : 4] ID Length
    $18 constant OCTOSPI_MMW                    \ [0x18 : 4] Memory map write
    $1c constant OCTOSPI_MST                    \ [0x1c : 4] Master
  [then]


  [ifdef] OCTOSPI_VER_DEF
    \
    \ @brief version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant OCTOSPI_VER                    \ [0x00 : 8] Version
  [then]


  [ifdef] OCTOSPI_ID_DEF
    \
    \ @brief identification
    \ Address offset: 0x3F8
    \ Reset value: 0x00140041
    \
    $00 constant OCTOSPI_ID                     \ [0x00 : 32] Identification
  [then]


  [ifdef] OCTOSPI_MID_DEF
    \
    \ @brief magic ID
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant OCTOSPI_MID                    \ [0x00 : 32] Magic ID
  [then]

  \
  \ @brief OctoSPI
  \
  $00 constant OCTOSPI_CR               \ control register
  $08 constant OCTOSPI_DCR1             \ device configuration register
  $0C constant OCTOSPI_DCR2             \ device configuration register 2
  $10 constant OCTOSPI_DCR3             \ device configuration register 3
  $20 constant OCTOSPI_SR               \ status register
  $24 constant OCTOSPI_FCR              \ flag clear register
  $40 constant OCTOSPI_DLR              \ data length register
  $48 constant OCTOSPI_AR               \ address register
  $50 constant OCTOSPI_DR               \ data register
  $80 constant OCTOSPI_PSMKR            \ polling status mask register
  $88 constant OCTOSPI_PSMAR            \ polling status match register
  $90 constant OCTOSPI_PIR              \ polling interval register
  $100 constant OCTOSPI_CCR             \ communication configuration register
  $108 constant OCTOSPI_TCR             \ timing configuration register
  $110 constant OCTOSPI_IR              \ instruction register
  $120 constant OCTOSPI_ABR             \ alternate bytes register
  $130 constant OCTOSPI_LPTR            \ low-power timeout register
  $180 constant OCTOSPI_WCCR            \ write communication configuration register
  $188 constant OCTOSPI_WTCR            \ write timing configuration register
  $190 constant OCTOSPI_WIR             \ write instruction register
  $1A0 constant OCTOSPI_WABR            \ write alternate bytes register
  $200 constant OCTOSPI_HLCR            \ HyperBusTM latency configuration register
  $3F0 constant OCTOSPI_HWCFGR          \ HW configuration register
  $3F4 constant OCTOSPI_VER             \ version register
  $3F8 constant OCTOSPI_ID              \ identification
  $3FC constant OCTOSPI_MID             \ magic ID

: OCTOSPI_DEF ; [then]
