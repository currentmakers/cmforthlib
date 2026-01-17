\
\ @file xspi.fs
\ @brief Extended-SPI interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] XSPI_DEF

  [ifdef] XSPI_XSPI_CR_DEF
    \
    \ @brief XSPI control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_EN                        \ [0x00] Enable
    $01 constant XSPI_ABORT                     \ [0x01] Abort request
    $02 constant XSPI_DMAEN                     \ [0x02] DMA enable
    $03 constant XSPI_TCEN                      \ [0x03] Timeout counter enable
    $06 constant XSPI_DMM                       \ [0x06] Dual-memory configuration
    $08 constant XSPI_FTHRES                    \ [0x08 : 6] FIFO threshold level
    $10 constant XSPI_TEIE                      \ [0x10] Transfer error interrupt enable
    $11 constant XSPI_TCIE                      \ [0x11] Transfer complete interrupt enable
    $12 constant XSPI_FTIE                      \ [0x12] FIFO threshold interrupt enable
    $13 constant XSPI_SMIE                      \ [0x13] Status match interrupt enable
    $14 constant XSPI_TOIE                      \ [0x14] Timeout interrupt enable
    $16 constant XSPI_APMS                      \ [0x16] Automatic status-polling mode stop
    $17 constant XSPI_PMM                       \ [0x17] Polling match mode
    $18 constant XSPI_CSSEL                     \ [0x18] chip select selection
    $19 constant XSPI_NOPREF                    \ [0x19] no prefetch data
    $1a constant XSPI_NOPREF_AXI                \ [0x1a] no prefetch for signaled AXI transactions
    $1c constant XSPI_FMODE                     \ [0x1c : 2] Functional mode
    $1e constant XSPI_MSEL                      \ [0x1e : 2] Flash select
  [then]


  [ifdef] XSPI_XSPI_DCR1_DEF
    \
    \ @brief XSPI device configuration register 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_CKMODE                    \ [0x00] clock mode 0
    $01 constant XSPI_FRCK                      \ [0x01] Free running clock
    $08 constant XSPI_CSHT                      \ [0x08 : 6] Chip-select high time
    $10 constant XSPI_DEVSIZE                   \ [0x10 : 5] Device size
    $15 constant XSPI_EXTENDMEM                 \ [0x15] extended memory support
    $18 constant XSPI_MTYP                      \ [0x18 : 3] Memory type
  [then]


  [ifdef] XSPI_XSPI_DCR2_DEF
    \
    \ @brief XSPI device configuration register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_PRESCALER                 \ [0x00 : 8] Clock prescaler
    $10 constant XSPI_WRAPSIZE                  \ [0x10 : 3] Wrap size
  [then]


  [ifdef] XSPI_XSPI_DCR3_DEF
    \
    \ @brief XSPI device configuration register 3
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_MAXTRAN                   \ [0x00 : 8] Maximum transfer
    $10 constant XSPI_CSBOUND                   \ [0x10 : 5] NCS boundary
  [then]


  [ifdef] XSPI_XSPI_DCR4_DEF
    \
    \ @brief XSPI device configuration register 4
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_REFRESH                   \ [0x00 : 32] Refresh rate
  [then]


  [ifdef] XSPI_XSPI_SR_DEF
    \
    \ @brief XSPI status register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_TEF                       \ [0x00] Transfer error flag
    $01 constant XSPI_TCF                       \ [0x01] Transfer complete flag
    $02 constant XSPI_FTF                       \ [0x02] FIFO threshold flag
    $03 constant XSPI_SMF                       \ [0x03] Status match flag
    $04 constant XSPI_TOF                       \ [0x04] Timeout flag
    $05 constant XSPI_BUSY                      \ [0x05] Busy
    $08 constant XSPI_FLEVEL                    \ [0x08 : 7] FIFO level
  [then]


  [ifdef] XSPI_XSPI_FCR_DEF
    \
    \ @brief XSPI flag clear register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_CTEF                      \ [0x00] Clear transfer error flag
    $01 constant XSPI_CTCF                      \ [0x01] Clear transfer complete flag
    $03 constant XSPI_CSMF                      \ [0x03] Clear status match flag
    $04 constant XSPI_CTOF                      \ [0x04] Clear timeout flag
  [then]


  [ifdef] XSPI_XSPI_DLR_DEF
    \
    \ @brief XSPI data length register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_DL                        \ [0x00 : 32] None
  [then]


  [ifdef] XSPI_XSPI_AR_DEF
    \
    \ @brief XSPIaddress register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_ADDRESS                   \ [0x00 : 32] Address
  [then]


  [ifdef] XSPI_XSPI_DR_DEF
    \
    \ @brief XSPI data register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_DATA                      \ [0x00 : 32] None
  [then]


  [ifdef] XSPI_XSPI_PSMKR_DEF
    \
    \ @brief XSPI polling status mask register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_MASK                      \ [0x00 : 32] Status mask
  [then]


  [ifdef] XSPI_XSPI_PSMAR_DEF
    \
    \ @brief XSPI polling status match register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_MATCH                     \ [0x00 : 32] None
  [then]


  [ifdef] XSPI_XSPI_PIR_DEF
    \
    \ @brief XSPI polling interval register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_INTERVAL                  \ [0x00 : 16] None
  [then]


  [ifdef] XSPI_XSPI_CCR_DEF
    \
    \ @brief XSPI communication configuration register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_IMODE                     \ [0x00 : 3] Instruction mode
    $03 constant XSPI_IDTR                      \ [0x03] Instruction double transfer rate
    $04 constant XSPI_ISIZE                     \ [0x04 : 2] Instruction size
    $08 constant XSPI_ADMODE                    \ [0x08 : 3] Address mode
    $0b constant XSPI_ADDTR                     \ [0x0b] Address double transfer rate
    $0c constant XSPI_ADSIZE                    \ [0x0c : 2] Address size
    $10 constant XSPI_ABMODE                    \ [0x10 : 3] Alternate-byte mode
    $13 constant XSPI_ABDTR                     \ [0x13] Alternate bytes double transfer rate
    $14 constant XSPI_ABSIZE                    \ [0x14 : 2] Alternate bytes size
    $18 constant XSPI_DMODE                     \ [0x18 : 3] Data mode
    $1b constant XSPI_DDTR                      \ [0x1b] Data double transfer rate
    $1d constant XSPI_DQSE                      \ [0x1d] DQS enable
  [then]


  [ifdef] XSPI_XSPI_TCR_DEF
    \
    \ @brief XSPI timing configuration register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_DCYC                      \ [0x00 : 5] Number of dummy cycles
    $1c constant XSPI_DHQC                      \ [0x1c] Delay hold quarter cycle
    $1e constant XSPI_SSHIFT                    \ [0x1e] Sample shift
  [then]


  [ifdef] XSPI_XSPI_IR_DEF
    \
    \ @brief XSPI instruction register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_INSTRUCTION               \ [0x00 : 32] Instruction
  [then]


  [ifdef] XSPI_XSPI_ABR_DEF
    \
    \ @brief XSPI alternate bytes register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_ALTERNATE                 \ [0x00 : 32] None
  [then]


  [ifdef] XSPI_XSPI_LPTR_DEF
    \
    \ @brief XSPI low-power timeout register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_TIMEOUT                   \ [0x00 : 16] None
  [then]


  [ifdef] XSPI_XSPI_WPCCR_DEF
    \
    \ @brief XSPI wrap communication configuration register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_IMODE                     \ [0x00 : 3] Instruction mode
    $03 constant XSPI_IDTR                      \ [0x03] Instruction double transfer rate
    $04 constant XSPI_ISIZE                     \ [0x04 : 2] Instruction size
    $08 constant XSPI_ADMODE                    \ [0x08 : 3] Address mode
    $0b constant XSPI_ADDTR                     \ [0x0b] Address double transfer rate
    $0c constant XSPI_ADSIZE                    \ [0x0c : 2] Address size
    $10 constant XSPI_ABMODE                    \ [0x10 : 3] Alternate-byte mode
    $13 constant XSPI_ABDTR                     \ [0x13] Alternate bytes double transfer rate
    $14 constant XSPI_ABSIZE                    \ [0x14 : 2] Alternate bytes size
    $18 constant XSPI_DMODE                     \ [0x18 : 3] Data mode
    $1b constant XSPI_DDTR                      \ [0x1b] Data double transfer rate
    $1d constant XSPI_DQSE                      \ [0x1d] DQS enable
  [then]


  [ifdef] XSPI_XSPI_WPTCR_DEF
    \
    \ @brief XSPI wrap timing configuration register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_DCYC                      \ [0x00 : 5] Number of dummy cycles
    $1c constant XSPI_DHQC                      \ [0x1c] Delay hold quarter cycle
    $1e constant XSPI_SSHIFT                    \ [0x1e] Sample shift
  [then]


  [ifdef] XSPI_XSPI_WPIR_DEF
    \
    \ @brief XSPI wrap instruction register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_INSTRUCTION               \ [0x00 : 32] None
  [then]


  [ifdef] XSPI_XSPI_WPABR_DEF
    \
    \ @brief XSPI wrap alternate byte register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_ALTERNATE                 \ [0x00 : 32] None
  [then]


  [ifdef] XSPI_XSPI_WCCR_DEF
    \
    \ @brief XSPI write communication configuration register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_IMODE                     \ [0x00 : 3] Instruction mode
    $03 constant XSPI_IDTR                      \ [0x03] Instruction double transfer rate
    $04 constant XSPI_ISIZE                     \ [0x04 : 2] Instruction size
    $08 constant XSPI_ADMODE                    \ [0x08 : 3] Address mode
    $0b constant XSPI_ADDTR                     \ [0x0b] Address double transfer rate
    $0c constant XSPI_ADSIZE                    \ [0x0c : 2] Address size
    $10 constant XSPI_ABMODE                    \ [0x10 : 3] Alternate-byte mode
    $13 constant XSPI_ABDTR                     \ [0x13] Alternate bytes double-transfer rate
    $14 constant XSPI_ABSIZE                    \ [0x14 : 2] Alternate bytes size
    $18 constant XSPI_DMODE                     \ [0x18 : 3] Data mode
    $1b constant XSPI_DDTR                      \ [0x1b] data double transfer rate
    $1d constant XSPI_DQSE                      \ [0x1d] DQS enable
  [then]


  [ifdef] XSPI_XSPI_WTCR_DEF
    \
    \ @brief XSPI write timing configuration register
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_DCYC                      \ [0x00 : 5] Number of dummy cycles
  [then]


  [ifdef] XSPI_XSPI_WIR_DEF
    \
    \ @brief XSPI write instruction register
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_INSTRUCTION               \ [0x00 : 32] Instruction
  [then]


  [ifdef] XSPI_XSPI_WABR_DEF
    \
    \ @brief XSPI write alternate byte register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_ALTERNATE                 \ [0x00 : 32] None
  [then]


  [ifdef] XSPI_XSPI_HLCR_DEF
    \
    \ @brief XSPI HyperBus latency configuration register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_LM                        \ [0x00] Latency mode
    $01 constant XSPI_WZL                       \ [0x01] Write zero latency
    $08 constant XSPI_TACC                      \ [0x08 : 8] None
    $10 constant XSPI_TRWR                      \ [0x10 : 8] Read write recovery time
  [then]


  [ifdef] XSPI_XSPI_CALFCR_DEF
    \
    \ @brief XSPI full-cycle calibration configuration
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_FINE                      \ [0x00 : 7] None
    $10 constant XSPI_COARSE                    \ [0x10 : 5] None
    $1f constant XSPI_CALMAX                    \ [0x1f] Max value
  [then]


  [ifdef] XSPI_XSPI_CALMR_DEF
    \
    \ @brief XSPI DLL master calibration configuration
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_FINE                      \ [0x00 : 7] None
    $10 constant XSPI_COARSE                    \ [0x10 : 5] None
  [then]


  [ifdef] XSPI_XSPI_CALSOR_DEF
    \
    \ @brief XSPI DLL slave output calibration configuration
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_FINE                      \ [0x00 : 7] None
    $10 constant XSPI_COARSE                    \ [0x10 : 5] None
  [then]


  [ifdef] XSPI_XSPI_CALSIR_DEF
    \
    \ @brief XSPI DLL slave input calibration configuration
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant XSPI_FINE                      \ [0x00 : 7] None
    $10 constant XSPI_COARSE                    \ [0x10 : 5] None
  [then]

  \
  \ @brief Extended-SPI interface
  \
  $00 constant XSPI_XSPI_CR             \ XSPI control register
  $08 constant XSPI_XSPI_DCR1           \ XSPI device configuration register 1
  $0C constant XSPI_XSPI_DCR2           \ XSPI device configuration register 2
  $10 constant XSPI_XSPI_DCR3           \ XSPI device configuration register 3
  $14 constant XSPI_XSPI_DCR4           \ XSPI device configuration register 4
  $20 constant XSPI_XSPI_SR             \ XSPI status register
  $24 constant XSPI_XSPI_FCR            \ XSPI flag clear register
  $40 constant XSPI_XSPI_DLR            \ XSPI data length register
  $48 constant XSPI_XSPI_AR             \ XSPIaddress register
  $50 constant XSPI_XSPI_DR             \ XSPI data register
  $80 constant XSPI_XSPI_PSMKR          \ XSPI polling status mask register
  $88 constant XSPI_XSPI_PSMAR          \ XSPI polling status match register
  $90 constant XSPI_XSPI_PIR            \ XSPI polling interval register
  $100 constant XSPI_XSPI_CCR           \ XSPI communication configuration register
  $108 constant XSPI_XSPI_TCR           \ XSPI timing configuration register
  $110 constant XSPI_XSPI_IR            \ XSPI instruction register
  $120 constant XSPI_XSPI_ABR           \ XSPI alternate bytes register
  $130 constant XSPI_XSPI_LPTR          \ XSPI low-power timeout register
  $140 constant XSPI_XSPI_WPCCR         \ XSPI wrap communication configuration register
  $148 constant XSPI_XSPI_WPTCR         \ XSPI wrap timing configuration register
  $150 constant XSPI_XSPI_WPIR          \ XSPI wrap instruction register
  $160 constant XSPI_XSPI_WPABR         \ XSPI wrap alternate byte register
  $180 constant XSPI_XSPI_WCCR          \ XSPI write communication configuration register
  $188 constant XSPI_XSPI_WTCR          \ XSPI write timing configuration register
  $190 constant XSPI_XSPI_WIR           \ XSPI write instruction register
  $1A0 constant XSPI_XSPI_WABR          \ XSPI write alternate byte register
  $200 constant XSPI_XSPI_HLCR          \ XSPI HyperBus latency configuration register
  $210 constant XSPI_XSPI_CALFCR        \ XSPI full-cycle calibration configuration
  $218 constant XSPI_XSPI_CALMR         \ XSPI DLL master calibration configuration
  $220 constant XSPI_XSPI_CALSOR        \ XSPI DLL slave output calibration configuration
  $228 constant XSPI_XSPI_CALSIR        \ XSPI DLL slave input calibration configuration

: XSPI_DEF ; [then]
