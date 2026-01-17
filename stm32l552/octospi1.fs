\
\ @file octospi1.fs
\ @brief OctoSPI
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OCTOSPI1_DEF

  [ifdef] OCTOSPI1_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_EN                    \ [0x00] Enable
    $01 constant OCTOSPI1_ABORT                 \ [0x01] Abort request
    $02 constant OCTOSPI1_DMAEN                 \ [0x02] DMA enable
    $03 constant OCTOSPI1_TCEN                  \ [0x03] Timeout counter enable
    $06 constant OCTOSPI1_DQM                   \ [0x06] Dual-quad mode
    $07 constant OCTOSPI1_FSEL                  \ [0x07] FLASH memory selection
    $08 constant OCTOSPI1_FTHRES                \ [0x08 : 5] IFO threshold level
    $10 constant OCTOSPI1_TEIE                  \ [0x10] Transfer error interrupt enable
    $11 constant OCTOSPI1_TCIE                  \ [0x11] Transfer complete interrupt enable
    $12 constant OCTOSPI1_FTIE                  \ [0x12] FIFO threshold interrupt enable
    $13 constant OCTOSPI1_SMIE                  \ [0x13] Status match interrupt enable
    $14 constant OCTOSPI1_TOIE                  \ [0x14] TimeOut interrupt enable
    $16 constant OCTOSPI1_APMS                  \ [0x16] Automatic poll mode stop
    $17 constant OCTOSPI1_PMM                   \ [0x17] Polling match mode
    $1c constant OCTOSPI1_FMODE                 \ [0x1c : 2] Functional mode
  [then]


  [ifdef] OCTOSPI1_DCR1_DEF
    \
    \ @brief device configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_CKMODE                \ [0x00] Mode 0 / mode 3
    $01 constant OCTOSPI1_FRCK                  \ [0x01] Free running clock
    $03 constant OCTOSPI1_DLYBYP                \ [0x03] Delay block bypass
    $08 constant OCTOSPI1_CSHT                  \ [0x08 : 3] Chip-select high time
    $10 constant OCTOSPI1_DEVSIZE               \ [0x10 : 5] Device size
    $18 constant OCTOSPI1_MTYP                  \ [0x18 : 2] Memory type
  [then]


  [ifdef] OCTOSPI1_DCR2_DEF
    \
    \ @brief device configuration register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_PRESCALER             \ [0x00 : 8] Clock prescaler
    $10 constant OCTOSPI1_WRAPSIZE              \ [0x10 : 3] Wrap size
  [then]


  [ifdef] OCTOSPI1_DCR3_DEF
    \
    \ @brief device configuration register 3
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $10 constant OCTOSPI1_CSBOUND               \ [0x10 : 5] CS boundary
  [then]


  [ifdef] OCTOSPI1_DCR4_DEF
    \
    \ @brief device configuration register 4
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_REFRESH               \ [0x00 : 32] REFRESH
  [then]


  [ifdef] OCTOSPI1_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_TEF                   \ [0x00] Transfer error flag
    $01 constant OCTOSPI1_TCF                   \ [0x01] Transfer complete flag
    $02 constant OCTOSPI1_FTF                   \ [0x02] FIFO threshold flag
    $03 constant OCTOSPI1_SMF                   \ [0x03] Status match flag
    $04 constant OCTOSPI1_TOF                   \ [0x04] Timeout flag
    $05 constant OCTOSPI1_BUSY                  \ [0x05] BUSY
    $08 constant OCTOSPI1_FLEVEL                \ [0x08 : 6] FIFO level
  [then]


  [ifdef] OCTOSPI1_FCR_DEF
    \
    \ @brief flag clear register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_CTEF                  \ [0x00] Clear transfer error flag
    $01 constant OCTOSPI1_CTCF                  \ [0x01] Clear transfer complete flag
    $03 constant OCTOSPI1_CSMF                  \ [0x03] Clear status match flag
    $04 constant OCTOSPI1_CTOF                  \ [0x04] Clear timeout flag
  [then]


  [ifdef] OCTOSPI1_DLR_DEF
    \
    \ @brief data length register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_DL                    \ [0x00 : 32] Data length
  [then]


  [ifdef] OCTOSPI1_AR_DEF
    \
    \ @brief address register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_ADDRESS               \ [0x00 : 32] ADDRESS
  [then]


  [ifdef] OCTOSPI1_DR_DEF
    \
    \ @brief data register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_DATA                  \ [0x00 : 32] Data
  [then]


  [ifdef] OCTOSPI1_PSMKR_DEF
    \
    \ @brief polling status mask register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_MASK                  \ [0x00 : 32] Status mask
  [then]


  [ifdef] OCTOSPI1_PSMAR_DEF
    \
    \ @brief polling status match register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_MATCH                 \ [0x00 : 32] Status match
  [then]


  [ifdef] OCTOSPI1_PIR_DEF
    \
    \ @brief polling interval register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_INTERVAL              \ [0x00 : 16] Polling interval
  [then]


  [ifdef] OCTOSPI1_CCR_DEF
    \
    \ @brief communication configuration
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_IMODE                 \ [0x00 : 3] Instruction mode
    $03 constant OCTOSPI1_IDTR                  \ [0x03] Instruction double transfer rate
    $04 constant OCTOSPI1_ISIZE                 \ [0x04 : 2] Instruction size
    $08 constant OCTOSPI1_ADMODE                \ [0x08 : 3] Address mode
    $0b constant OCTOSPI1_ADDTR                 \ [0x0b] Address double transfer rate
    $0c constant OCTOSPI1_ADSIZE                \ [0x0c : 2] Address size
    $10 constant OCTOSPI1_ABMODE                \ [0x10 : 3] Alternate byte mode
    $13 constant OCTOSPI1_ABDTR                 \ [0x13] Alternate bytes double transfer rate
    $14 constant OCTOSPI1_ABSIZE                \ [0x14 : 2] Alternate bytes size
    $18 constant OCTOSPI1_DMODE                 \ [0x18 : 3] Data mode
    $1b constant OCTOSPI1_DDTR                  \ [0x1b] Alternate bytes double transfer rate
    $1d constant OCTOSPI1_DQSE                  \ [0x1d] DQS enable
    $1f constant OCTOSPI1_SIOO                  \ [0x1f] Send instruction only once mode
  [then]


  [ifdef] OCTOSPI1_TCR_DEF
    \
    \ @brief timing configuration register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_DCYC                  \ [0x00 : 5] Number of dummy cycles
    $1c constant OCTOSPI1_DHQC                  \ [0x1c] Delay hold quarter cycle
    $1e constant OCTOSPI1_SSHIFT                \ [0x1e] Sample shift
  [then]


  [ifdef] OCTOSPI1_IR_DEF
    \
    \ @brief instruction register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_INSTRUCTION           \ [0x00 : 32] INSTRUCTION
  [then]


  [ifdef] OCTOSPI1_ABR_DEF
    \
    \ @brief alternate bytes register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_ALTERNATE             \ [0x00 : 32] Alternate bytes
  [then]


  [ifdef] OCTOSPI1_LPTR_DEF
    \
    \ @brief low-power timeout register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_TIMEOUT               \ [0x00 : 16] Timeout period
  [then]


  [ifdef] OCTOSPI1_WPCCR_DEF
    \
    \ @brief wrap communication configuration register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_IMODE                 \ [0x00 : 3] Instruction mode
    $03 constant OCTOSPI1_IDTR                  \ [0x03] Instruction double transfer rate
    $04 constant OCTOSPI1_ISIZE                 \ [0x04 : 2] Instruction size
    $08 constant OCTOSPI1_ADMODE                \ [0x08 : 3] Address mode
    $0b constant OCTOSPI1_ADDTR                 \ [0x0b] Address double transfer rate
    $0c constant OCTOSPI1_ADSIZE                \ [0x0c : 2] Address size
    $10 constant OCTOSPI1_ABMODE                \ [0x10 : 3] Alternate byte mode
    $13 constant OCTOSPI1_ABDTR                 \ [0x13] Alternate bytes double transfer rate
    $14 constant OCTOSPI1_ABSIZE                \ [0x14 : 2] Alternate bytes size
    $18 constant OCTOSPI1_DMODE                 \ [0x18 : 3] Data mode
    $1b constant OCTOSPI1_DDTR                  \ [0x1b] alternate bytes double transfer rate
    $1d constant OCTOSPI1_DQSE                  \ [0x1d] DQS enable
  [then]


  [ifdef] OCTOSPI1_WPTCR_DEF
    \
    \ @brief wrap timing configuration register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_DCYC                  \ [0x00 : 5] Number of dummy cycles
    $1c constant OCTOSPI1_DHQC                  \ [0x1c] Delay hold quarter cycle
    $1e constant OCTOSPI1_SSHIFT                \ [0x1e] Sample shift
  [then]


  [ifdef] OCTOSPI1_WPIR_DEF
    \
    \ @brief wrap instruction register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_INSTRUCTION           \ [0x00 : 32] INSTRUCTION
  [then]


  [ifdef] OCTOSPI1_WPABR_DEF
    \
    \ @brief wrap alternate bytes register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_ALTERNATE             \ [0x00 : 32] Alternate bytes
  [then]


  [ifdef] OCTOSPI1_WCCR_DEF
    \
    \ @brief WCCR
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_IMODE                 \ [0x00 : 3] IMODE
    $03 constant OCTOSPI1_IDTR                  \ [0x03] IDTR
    $04 constant OCTOSPI1_ISIZE                 \ [0x04 : 2] ISIZE
    $08 constant OCTOSPI1_ADMODE                \ [0x08 : 3] ADMODE
    $0b constant OCTOSPI1_ADDTR                 \ [0x0b] ADDTR
    $0c constant OCTOSPI1_ADSIZE                \ [0x0c : 2] ADSIZE
    $10 constant OCTOSPI1_ABMODE                \ [0x10 : 3] ABMODE
    $13 constant OCTOSPI1_ABDTR                 \ [0x13] ABDTR
    $14 constant OCTOSPI1_ABSIZE                \ [0x14 : 2] ABSIZE
    $18 constant OCTOSPI1_DMODE                 \ [0x18 : 3] DMODE
    $1b constant OCTOSPI1_DDTR                  \ [0x1b] DDTR
    $1d constant OCTOSPI1_DQSE                  \ [0x1d] DQSE
  [then]


  [ifdef] OCTOSPI1_WTCR_DEF
    \
    \ @brief WTCR
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_DCYC                  \ [0x00 : 5] DCYC
  [then]


  [ifdef] OCTOSPI1_WIR_DEF
    \
    \ @brief WIR
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_INSTRUCTION           \ [0x00 : 32] INSTRUCTION
  [then]


  [ifdef] OCTOSPI1_WABR_DEF
    \
    \ @brief write alternate bytes register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_ALTERNATE             \ [0x00 : 32] Alternate bytes
  [then]


  [ifdef] OCTOSPI1_HLCR_DEF
    \
    \ @brief HyperBus latency configuration register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant OCTOSPI1_LM                    \ [0x00] Latency mode
    $01 constant OCTOSPI1_WZL                   \ [0x01] Write zero latency
    $08 constant OCTOSPI1_TACC                  \ [0x08 : 8] Access time
    $10 constant OCTOSPI1_TRWR                  \ [0x10 : 8] Read write recovery time
  [then]

  \
  \ @brief OctoSPI
  \
  $00 constant OCTOSPI1_CR              \ control register
  $08 constant OCTOSPI1_DCR1            \ device configuration register
  $0C constant OCTOSPI1_DCR2            \ device configuration register 2
  $10 constant OCTOSPI1_DCR3            \ device configuration register 3
  $14 constant OCTOSPI1_DCR4            \ device configuration register 4
  $20 constant OCTOSPI1_SR              \ status register
  $24 constant OCTOSPI1_FCR             \ flag clear register
  $40 constant OCTOSPI1_DLR             \ data length register
  $48 constant OCTOSPI1_AR              \ address register
  $50 constant OCTOSPI1_DR              \ data register
  $80 constant OCTOSPI1_PSMKR           \ polling status mask register
  $88 constant OCTOSPI1_PSMAR           \ polling status match register
  $90 constant OCTOSPI1_PIR             \ polling interval register
  $100 constant OCTOSPI1_CCR            \ communication configuration
  $108 constant OCTOSPI1_TCR            \ timing configuration register
  $110 constant OCTOSPI1_IR             \ instruction register
  $120 constant OCTOSPI1_ABR            \ alternate bytes register
  $130 constant OCTOSPI1_LPTR           \ low-power timeout register
  $140 constant OCTOSPI1_WPCCR          \ wrap communication configuration register
  $148 constant OCTOSPI1_WPTCR          \ wrap timing configuration register
  $150 constant OCTOSPI1_WPIR           \ wrap instruction register
  $160 constant OCTOSPI1_WPABR          \ wrap alternate bytes register
  $180 constant OCTOSPI1_WCCR           \ WCCR
  $188 constant OCTOSPI1_WTCR           \ WTCR
  $190 constant OCTOSPI1_WIR            \ WIR
  $1A0 constant OCTOSPI1_WABR           \ write alternate bytes register
  $200 constant OCTOSPI1_HLCR           \ HyperBus latency configuration register

: OCTOSPI1_DEF ; [then]
