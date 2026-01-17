\
\ @file fmc1.fs
\ @brief Flexible memory controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FMC1_DEF

  [ifdef] FMC1_FMC_BCR1_DEF
    \
    \ @brief SRAM/NOR Flash chip-select control register for memory region 1
    \ Address offset: 0x00
    \ Reset value: 0x000030DB
    \
    $00 constant FMC1_MBKEN                     \ [0x00] Memory region enable bit
    $01 constant FMC1_MUXEN                     \ [0x01] Address/data multiplexing enable bit
    $02 constant FMC1_MTYP                      \ [0x02 : 2] Memory type
    $04 constant FMC1_MWID                      \ [0x04 : 2] Memory data bus width
    $06 constant FMC1_FACCEN                    \ [0x06] Flash memory access enable
    $08 constant FMC1_BURSTEN                   \ [0x08] Burst enable bit
    $09 constant FMC1_WAITPOL                   \ [0x09] Wait signal polarity bit
    $0b constant FMC1_WAITCFG                   \ [0x0b] Wait timing configuration
    $0c constant FMC1_WREN                      \ [0x0c] Write enable bit
    $0d constant FMC1_WAITEN                    \ [0x0d] Wait enable bit
    $0e constant FMC1_EXTMOD                    \ [0x0e] Extended mode enable
    $0f constant FMC1_ASYNCWAIT                 \ [0x0f] Wait signal during asynchronous transfers
    $10 constant FMC1_CPSIZE                    \ [0x10 : 3] CRAM page size
    $13 constant FMC1_CBURSTRW                  \ [0x13] Write burst enable
    $14 constant FMC1_CSCOUNT0                  \ [0x14 : 2] Chip Select (CS) counter
    $16 constant FMC1_NBLSET                    \ [0x16 : 2] Byte lane (NBL) setup
  [then]


  [ifdef] FMC1_FMC_BTR1_DEF
    \
    \ @brief SRAM/NOR Flash chip-select timing registers for memory region 1
    \ Address offset: 0x04
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC1_ADDSET                    \ [0x00 : 4] Address setup phase duration
    $04 constant FMC1_ADDHLD                    \ [0x04 : 4] Address-hold phase duration
    $08 constant FMC1_DATAST                    \ [0x08 : 8] Data-phase duration
    $10 constant FMC1_BUSTURN                   \ [0x10 : 4] Bus turnaround phase duration
    $14 constant FMC1_CLKDIV                    \ [0x14 : 4] Clock divide ratio (for FMC_CLK signal)
    $18 constant FMC1_DATLAT                    \ [0x18 : 4] Data latency for synchronous memory (see note below bit descriptions)
    $1c constant FMC1_ACCMOD                    \ [0x1c : 2] Access mode
    $1e constant FMC1_DATAHLD                   \ [0x1e : 2] Data Hold phase duration
  [then]


  [ifdef] FMC1_FMC_BCR2_DEF
    \
    \ @brief SRAM/NOR Flash chip-select control register for memory region 2
    \ Address offset: 0x08
    \ Reset value: 0x000030D2
    \
    $00 constant FMC1_MBKEN                     \ [0x00] Memory region enable bit
    $01 constant FMC1_MUXEN                     \ [0x01] Address/data multiplexing enable bit
    $02 constant FMC1_MTYP                      \ [0x02 : 2] Memory type
    $04 constant FMC1_MWID                      \ [0x04 : 2] Memory data bus width
    $06 constant FMC1_FACCEN                    \ [0x06] Flash memory access enable
    $08 constant FMC1_BURSTEN                   \ [0x08] Burst enable bit
    $09 constant FMC1_WAITPOL                   \ [0x09] Wait signal polarity bit
    $0b constant FMC1_WAITCFG                   \ [0x0b] Wait timing configuration
    $0c constant FMC1_WREN                      \ [0x0c] Write enable bit
    $0d constant FMC1_WAITEN                    \ [0x0d] Wait enable bit
    $0e constant FMC1_EXTMOD                    \ [0x0e] Extended mode enable
    $0f constant FMC1_ASYNCWAIT                 \ [0x0f] Wait signal during asynchronous transfers
    $10 constant FMC1_CPSIZE                    \ [0x10 : 3] CRAM page size
    $13 constant FMC1_CBURSTRW                  \ [0x13] Write burst enable
    $14 constant FMC1_CSCOUNT0                  \ [0x14 : 2] Chip Select (CS) counter
    $16 constant FMC1_NBLSET                    \ [0x16 : 2] Byte lane (NBL) setup
  [then]


  [ifdef] FMC1_FMC_BTR2_DEF
    \
    \ @brief SRAM/NOR Flash chip-select timing registers for memory region 2
    \ Address offset: 0x0C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC1_ADDSET                    \ [0x00 : 4] Address setup phase duration
    $04 constant FMC1_ADDHLD                    \ [0x04 : 4] Address-hold phase duration
    $08 constant FMC1_DATAST                    \ [0x08 : 8] Data-phase duration
    $10 constant FMC1_BUSTURN                   \ [0x10 : 4] Bus turnaround phase duration
    $14 constant FMC1_CLKDIV                    \ [0x14 : 4] Clock divide ratio (for FMC_CLK signal)
    $18 constant FMC1_DATLAT                    \ [0x18 : 4] Data latency for synchronous memory (see note below bit descriptions)
    $1c constant FMC1_ACCMOD                    \ [0x1c : 2] Access mode
    $1e constant FMC1_DATAHLD                   \ [0x1e : 2] Data Hold phase duration
  [then]


  [ifdef] FMC1_FMC_BCR3_DEF
    \
    \ @brief SRAM/NOR Flash chip-select control register for memory region 3
    \ Address offset: 0x10
    \ Reset value: 0x000030D2
    \
    $00 constant FMC1_MBKEN                     \ [0x00] Memory region enable bit
    $01 constant FMC1_MUXEN                     \ [0x01] Address/data multiplexing enable bit
    $02 constant FMC1_MTYP                      \ [0x02 : 2] Memory type
    $04 constant FMC1_MWID                      \ [0x04 : 2] Memory data bus width
    $06 constant FMC1_FACCEN                    \ [0x06] Flash memory access enable
    $08 constant FMC1_BURSTEN                   \ [0x08] Burst enable bit
    $09 constant FMC1_WAITPOL                   \ [0x09] Wait signal polarity bit
    $0b constant FMC1_WAITCFG                   \ [0x0b] Wait timing configuration
    $0c constant FMC1_WREN                      \ [0x0c] Write enable bit
    $0d constant FMC1_WAITEN                    \ [0x0d] Wait enable bit
    $0e constant FMC1_EXTMOD                    \ [0x0e] Extended mode enable
    $0f constant FMC1_ASYNCWAIT                 \ [0x0f] Wait signal during asynchronous transfers
    $10 constant FMC1_CPSIZE                    \ [0x10 : 3] CRAM page size
    $13 constant FMC1_CBURSTRW                  \ [0x13] Write burst enable
    $14 constant FMC1_CSCOUNT0                  \ [0x14 : 2] Chip Select (CS) counter
    $16 constant FMC1_NBLSET                    \ [0x16 : 2] Byte lane (NBL) setup
  [then]


  [ifdef] FMC1_FMC_BTR3_DEF
    \
    \ @brief SRAM/NOR Flash chip-select timing registers for memory region 3
    \ Address offset: 0x14
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC1_ADDSET                    \ [0x00 : 4] Address setup phase duration
    $04 constant FMC1_ADDHLD                    \ [0x04 : 4] Address-hold phase duration
    $08 constant FMC1_DATAST                    \ [0x08 : 8] Data-phase duration
    $10 constant FMC1_BUSTURN                   \ [0x10 : 4] Bus turnaround phase duration
    $14 constant FMC1_CLKDIV                    \ [0x14 : 4] Clock divide ratio (for FMC_CLK signal)
    $18 constant FMC1_DATLAT                    \ [0x18 : 4] Data latency for synchronous memory (see note below bit descriptions)
    $1c constant FMC1_ACCMOD                    \ [0x1c : 2] Access mode
    $1e constant FMC1_DATAHLD                   \ [0x1e : 2] Data Hold phase duration
  [then]


  [ifdef] FMC1_FMC_BCR4_DEF
    \
    \ @brief SRAM/NOR Flash chip-select control register for memory region 4
    \ Address offset: 0x18
    \ Reset value: 0x000030D2
    \
    $00 constant FMC1_MBKEN                     \ [0x00] Memory region enable bit
    $01 constant FMC1_MUXEN                     \ [0x01] Address/data multiplexing enable bit
    $02 constant FMC1_MTYP                      \ [0x02 : 2] Memory type
    $04 constant FMC1_MWID                      \ [0x04 : 2] Memory data bus width
    $06 constant FMC1_FACCEN                    \ [0x06] Flash memory access enable
    $08 constant FMC1_BURSTEN                   \ [0x08] Burst enable bit
    $09 constant FMC1_WAITPOL                   \ [0x09] Wait signal polarity bit
    $0b constant FMC1_WAITCFG                   \ [0x0b] Wait timing configuration
    $0c constant FMC1_WREN                      \ [0x0c] Write enable bit
    $0d constant FMC1_WAITEN                    \ [0x0d] Wait enable bit
    $0e constant FMC1_EXTMOD                    \ [0x0e] Extended mode enable
    $0f constant FMC1_ASYNCWAIT                 \ [0x0f] Wait signal during asynchronous transfers
    $10 constant FMC1_CPSIZE                    \ [0x10 : 3] CRAM page size
    $13 constant FMC1_CBURSTRW                  \ [0x13] Write burst enable
    $14 constant FMC1_CSCOUNT0                  \ [0x14 : 2] Chip Select (CS) counter
    $16 constant FMC1_NBLSET                    \ [0x16 : 2] Byte lane (NBL) setup
  [then]


  [ifdef] FMC1_FMC_BTR4_DEF
    \
    \ @brief SRAM/NOR Flash chip-select timing registers for memory region 4
    \ Address offset: 0x1C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC1_ADDSET                    \ [0x00 : 4] Address setup phase duration
    $04 constant FMC1_ADDHLD                    \ [0x04 : 4] Address-hold phase duration
    $08 constant FMC1_DATAST                    \ [0x08 : 8] Data-phase duration
    $10 constant FMC1_BUSTURN                   \ [0x10 : 4] Bus turnaround phase duration
    $14 constant FMC1_CLKDIV                    \ [0x14 : 4] Clock divide ratio (for FMC_CLK signal)
    $18 constant FMC1_DATLAT                    \ [0x18 : 4] Data latency for synchronous memory (see note below bit descriptions)
    $1c constant FMC1_ACCMOD                    \ [0x1c : 2] Access mode
    $1e constant FMC1_DATAHLD                   \ [0x1e : 2] Data Hold phase duration
  [then]


  [ifdef] FMC1_FMC_CFGR_DEF
    \
    \ @brief FMC common configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $10 constant FMC1_CLKDIV                    \ [0x10 : 4] Clock divide ratio (for FMC_CLK signal)
    $14 constant FMC1_CCLKEN                    \ [0x14] Continuous clock enable
    $18 constant FMC1_BMAP0                     \ [0x18] FMC memory region mapping
    $19 constant FMC1_BMAP1                     \ [0x19] FMC memory region mapping
    $1f constant FMC1_FMCEN                     \ [0x1f] FMC controller enable
  [then]


  [ifdef] FMC1_FMC_PCR_DEF
    \
    \ @brief NAND Flash programmable control register
    \ Address offset: 0x80
    \ Reset value: 0x0007FE08
    \
    $01 constant FMC1_PWAITEN                   \ [0x01] Wait feature enable bit
    $02 constant FMC1_PBKEN                     \ [0x02] NAND Flash memory region enable bit
    $04 constant FMC1_PWID                      \ [0x04 : 2] Data bus width
    $06 constant FMC1_ECCEN                     \ [0x06] ECC computation logic enable bit
    $08 constant FMC1_ECCALG                    \ [0x08] ECC algorithm
    $09 constant FMC1_TCLR                      \ [0x09 : 4] CLE to RE delay.
    $0d constant FMC1_TAR                       \ [0x0d : 4] ALE to RE delay.
    $11 constant FMC1_ECCSS                     \ [0x11 : 3] ECC sector size (used to access spare area)
    $18 constant FMC1_BCHECC                    \ [0x18] BCH error correction capability
    $19 constant FMC1_WEN                       \ [0x19] Write enable
  [then]


  [ifdef] FMC1_FMC_SR_DEF
    \
    \ @brief FMC status register
    \ Address offset: 0x84
    \ Reset value: 0x00000053
    \
    $00 constant FMC1_ISOST                     \ [0x00 : 2] FMC isolation state with respect to the AXI interface
    $04 constant FMC1_PEF                       \ [0x04] Pipe Empty Flag
    $06 constant FMC1_NWRF                      \ [0x06] NAND write request flag
  [then]


  [ifdef] FMC1_FMC_PMEM_DEF
    \
    \ @brief FMC common memory space timing register
    \ Address offset: 0x88
    \ Reset value: 0x0A0A0A0A
    \
    $00 constant FMC1_MEMSET                    \ [0x00 : 8] Common memory setup time
    $08 constant FMC1_MEMWAIT                   \ [0x08 : 8] Common memory wait time
    $10 constant FMC1_MEMHOLD                   \ [0x10 : 8] Common memory hold time
    $18 constant FMC1_MEMHIZ                    \ [0x18 : 8] Common memory data bus Hi-Z time
  [then]


  [ifdef] FMC1_FMC_PATT_DEF
    \
    \ @brief FMC attribute memory space timing registers
    \ Address offset: 0x8C
    \ Reset value: 0x0A0A0A0A
    \
    $00 constant FMC1_ATTSET                    \ [0x00 : 8] Attribute memory setup time
    $08 constant FMC1_ATTWAIT                   \ [0x08 : 8] Attribute memory wait time
    $10 constant FMC1_ATTHOLD                   \ [0x10 : 8] Attribute memory hold time
    $18 constant FMC1_ATTHIZ                    \ [0x18 : 8] Attribute memory data bus Hi-Z time
  [then]


  [ifdef] FMC1_FMC_HPR_DEF
    \
    \ @brief FMC Hamming parity result registers
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_HPR                       \ [0x00 : 32] Hamming parity result
  [then]


  [ifdef] FMC1_FMC_HECCR_DEF
    \
    \ @brief FMC Hamming code ECC result register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_HECC                      \ [0x00 : 32] ECC result
  [then]


  [ifdef] FMC1_FMC_BWTR1_DEF
    \
    \ @brief SRAM/NOR-Flash write timing registers for memory region 1
    \ Address offset: 0x104
    \ Reset value: 0x000FFFFF
    \
    $00 constant FMC1_ADDSET                    \ [0x00 : 4] Address setup phase duration.
    $04 constant FMC1_ADDHLD                    \ [0x04 : 4] Address-hold phase duration.
    $08 constant FMC1_DATAST                    \ [0x08 : 8] Data-phase duration.
    $10 constant FMC1_BUSTURN                   \ [0x10 : 4] Bus turnaround phase duration
    $1c constant FMC1_ACCMOD                    \ [0x1c : 2] Access mode.
    $1e constant FMC1_DATAHLD                   \ [0x1e : 2] Data Hold phase duration
  [then]


  [ifdef] FMC1_FMC_BWTR2_DEF
    \
    \ @brief SRAM/NOR-Flash write timing registers for memory region 2
    \ Address offset: 0x10C
    \ Reset value: 0x000FFFFF
    \
    $00 constant FMC1_ADDSET                    \ [0x00 : 4] Address setup phase duration.
    $04 constant FMC1_ADDHLD                    \ [0x04 : 4] Address-hold phase duration.
    $08 constant FMC1_DATAST                    \ [0x08 : 8] Data-phase duration.
    $10 constant FMC1_BUSTURN                   \ [0x10 : 4] Bus turnaround phase duration
    $1c constant FMC1_ACCMOD                    \ [0x1c : 2] Access mode.
    $1e constant FMC1_DATAHLD                   \ [0x1e : 2] Data Hold phase duration
  [then]


  [ifdef] FMC1_FMC_BWTR3_DEF
    \
    \ @brief SRAM/NOR-Flash write timing registers for memory region 3
    \ Address offset: 0x114
    \ Reset value: 0x000FFFFF
    \
    $00 constant FMC1_ADDSET                    \ [0x00 : 4] Address setup phase duration.
    $04 constant FMC1_ADDHLD                    \ [0x04 : 4] Address-hold phase duration.
    $08 constant FMC1_DATAST                    \ [0x08 : 8] Data-phase duration.
    $10 constant FMC1_BUSTURN                   \ [0x10 : 4] Bus turnaround phase duration
    $1c constant FMC1_ACCMOD                    \ [0x1c : 2] Access mode.
    $1e constant FMC1_DATAHLD                   \ [0x1e : 2] Data Hold phase duration
  [then]


  [ifdef] FMC1_FMC_BWTR4_DEF
    \
    \ @brief SRAM/NOR-Flash write timing registers for memory region 4
    \ Address offset: 0x11C
    \ Reset value: 0x000FFFFF
    \
    $00 constant FMC1_ADDSET                    \ [0x00 : 4] Address setup phase duration.
    $04 constant FMC1_ADDHLD                    \ [0x04 : 4] Address-hold phase duration.
    $08 constant FMC1_DATAST                    \ [0x08 : 8] Data-phase duration.
    $10 constant FMC1_BUSTURN                   \ [0x10 : 4] Bus turnaround phase duration
    $1c constant FMC1_ACCMOD                    \ [0x1c : 2] Access mode.
    $1e constant FMC1_DATAHLD                   \ [0x1e : 2] Data Hold phase duration
  [then]


  [ifdef] FMC1_FMC_SDCR1_DEF
    \
    \ @brief SDRAM control registers for SDRAM device 1
    \ Address offset: 0x140
    \ Reset value: 0x000002D0
    \
    $00 constant FMC1_NC                        \ [0x00 : 2] Number of column address bits
    $02 constant FMC1_NR                        \ [0x02 : 2] Number of row address bits
    $04 constant FMC1_MWID                      \ [0x04 : 2] Memory data bus width.
    $06 constant FMC1_NB                        \ [0x06] Number of banks
    $07 constant FMC1_CAS                       \ [0x07 : 2] CAS Latency
    $09 constant FMC1_WP                        \ [0x09] Write protection
    $0a constant FMC1_SDCLK                     \ [0x0a : 2] SDRAM clock configuration
    $0d constant FMC1_RPIPE                     \ [0x0d : 2] Read pipe
    $10 constant FMC1_SDEN                      \ [0x10] SDRAM device enable
    $11 constant FMC1_SDINIT                    \ [0x11] SDRAM device initialization
  [then]


  [ifdef] FMC1_FMC_SDCR2_DEF
    \
    \ @brief SDRAM control registers for SDRAM device 2
    \ Address offset: 0x144
    \ Reset value: 0x000002D0
    \
    $00 constant FMC1_NC                        \ [0x00 : 2] Number of column address bits
    $02 constant FMC1_NR                        \ [0x02 : 2] Number of row address bits
    $04 constant FMC1_MWID                      \ [0x04 : 2] Memory data bus width.
    $06 constant FMC1_NB                        \ [0x06] Number of banks
    $07 constant FMC1_CAS                       \ [0x07 : 2] CAS Latency
    $09 constant FMC1_WP                        \ [0x09] Write protection
    $10 constant FMC1_SDEN                      \ [0x10] SDRAM device enable
    $11 constant FMC1_SDINIT                    \ [0x11] SDRAM device initialization
  [then]


  [ifdef] FMC1_FMC_SDTR_DEF
    \
    \ @brief SDRAM timing register
    \ Address offset: 0x148
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC1_TMRD                      \ [0x00 : 4] Load mode register to active
    $04 constant FMC1_TXSR                      \ [0x04 : 4] Exit self-refresh delay
    $08 constant FMC1_TRAS                      \ [0x08 : 4] Self-refresh time
    $0c constant FMC1_TRC                       \ [0x0c : 4] Row cycle delay
    $10 constant FMC1_TWR                       \ [0x10 : 4] Recovery delay
    $14 constant FMC1_TRP                       \ [0x14 : 4] Row precharge delay
    $18 constant FMC1_TRCD                      \ [0x18 : 4] Row to column delay
  [then]


  [ifdef] FMC1_FMC_SDCMR_DEF
    \
    \ @brief SDRAM command mode register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_MODE                      \ [0x00 : 3] Command mode
    $03 constant FMC1_DS2                       \ [0x03] Command targeting SDRAM device 2
    $04 constant FMC1_DS1                       \ [0x04] Command targeting SDRAM device 1
    $05 constant FMC1_NRFS                      \ [0x05 : 4] Number of Refresh commands
    $09 constant FMC1_MRD                       \ [0x09 : 14] Mode register definition
  [then]


  [ifdef] FMC1_FMC_SDRTR_DEF
    \
    \ @brief SDRAM refresh timer register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_CRE                       \ [0x00] Clear Refresh error flag
    $01 constant FMC1_RFSCNT                    \ [0x01 : 13] Refresh Timer Count
    $0e constant FMC1_REIE                      \ [0x0e] RES Interrupt Enable
  [then]


  [ifdef] FMC1_FMC_SDSR_DEF
    \
    \ @brief SDRAM status register
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_RE                        \ [0x00] Refresh error flag
    $01 constant FMC1_MODES1                    \ [0x01 : 2] Status Mode for SDRAM device 1
    $03 constant FMC1_MODES2                    \ [0x03 : 2] Status mode for SDRAM device 2
    $0f constant FMC1_CMDOK                     \ [0x0f] Previous command status
  [then]


  [ifdef] FMC1_FMC_IER_DEF
    \
    \ @brief FMC NAND interrupt enable register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_IREE                      \ [0x00] Interrupt rising edge detection enable bit
    $01 constant FMC1_IHLE                      \ [0x01] Interrupt high-level detection enable bit
    $02 constant FMC1_IFEE                      \ [0x02] Interrupt falling edge detection enable bit
  [then]


  [ifdef] FMC1_FMC_ISR_DEF
    \
    \ @brief FMC controller interrupt status register
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_IREF                      \ [0x00] Interrupt rising edge flag
    $01 constant FMC1_IHLF                      \ [0x01] Interrupt high-level flag
    $02 constant FMC1_IFEF                      \ [0x02] Interrupt falling edge flag
  [then]


  [ifdef] FMC1_FMC_ICR_DEF
    \
    \ @brief FMC NAND controller interrupt clear register
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_CIREF                     \ [0x00] Clear Interrupt rising edge flag
    $01 constant FMC1_CIHLF                     \ [0x01] Clear Interrupt high-level flag
    $02 constant FMC1_CIFEF                     \ [0x02] Clear Interrupt falling edge flag
  [then]


  [ifdef] FMC1_FMC_CSQCR_DEF
    \
    \ @brief FMC NAND command sequencer control register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_CSQSTART                  \ [0x00] Command Sequencer Enable
  [then]


  [ifdef] FMC1_FMC_CSQCFGR1_DEF
    \
    \ @brief FMC NAND command sequencer configuration register 1
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $01 constant FMC1_CMD2EN                    \ [0x01] Command cycle 2 Enable
    $02 constant FMC1_DMADEN                    \ [0x02] Command sequencer DMA request data enable
    $04 constant FMC1_ACYNBR                    \ [0x04 : 3] Address Cycle number
    $08 constant FMC1_CMD1                      \ [0x08 : 8] Command 1 sequencer
    $10 constant FMC1_CMD2                      \ [0x10 : 8] Command 2 sequencer
    $18 constant FMC1_CMD1T                     \ [0x18] Command 1 Sequencer timings
    $19 constant FMC1_CMD2T                     \ [0x19] Command 2 Sequencer timings
  [then]


  [ifdef] FMC1_FMC_CSQCFGR2_DEF
    \
    \ @brief FMC NAND command sequencer configuration register 2
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_SQSDTEN                   \ [0x00] Sequencer spare data transfer enable
    $01 constant FMC1_RCMD2EN                   \ [0x01] Random Command 2 sequencer enable
    $02 constant FMC1_DMASEN                    \ [0x02] Command sequencer DMA request decoding status enable
    $08 constant FMC1_RCMD1                     \ [0x08 : 8] Random Command 1 sequencer
    $10 constant FMC1_RCMD2                     \ [0x10 : 8] Random Command 2 sequencer
    $18 constant FMC1_RCMD1T                    \ [0x18] Command 1 sequencer timings
    $19 constant FMC1_RCMD2T                    \ [0x19] Command 1 sequencer timings
  [then]


  [ifdef] FMC1_FMC_CSQCFGR3_DEF
    \
    \ @brief FMC NAND sequencer configuration register 3
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $08 constant FMC1_SNBR                      \ [0x08 : 6] Number of sectors to be read/written
    $10 constant FMC1_AC1T                      \ [0x10] Address cycle 1 sequencer timings
    $11 constant FMC1_AC2T                      \ [0x11] Address cycle 2 sequencer timings
    $12 constant FMC1_AC3T                      \ [0x12] Address cycle 3 sequencer timings
    $13 constant FMC1_AC4T                      \ [0x13] Address cycle 4sequencer timings
    $14 constant FMC1_AC5T                      \ [0x14] Address cycle 5 sequencer timings
    $15 constant FMC1_SDT                       \ [0x15] Spare data transfer sequencer timings
    $16 constant FMC1_RAC1T                     \ [0x16] Random Address cycle 1 sequencer timings
    $17 constant FMC1_RAC2T                     \ [0x17] Random Address cycle 2 sequencer timings
  [then]


  [ifdef] FMC1_FMC_CSQAR1_DEF
    \
    \ @brief FMC NAND command sequencer address register 1
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_ADDC1                     \ [0x00 : 8] Address Cycle 1
    $08 constant FMC1_ADDC2                     \ [0x08 : 8] Address Cycle 2
    $10 constant FMC1_ADDC3                     \ [0x10 : 8] Address Cycle 3
    $18 constant FMC1_ADDC4                     \ [0x18 : 8] Address Cycle 4
  [then]


  [ifdef] FMC1_FMC_CSQAR2_DEF
    \
    \ @brief FMC NAND command sequencer address register 2
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_ADDC5                     \ [0x00 : 8] Address Cycle 5
    $10 constant FMC1_SAO                       \ [0x10 : 16] Spare Area Address Offset
  [then]


  [ifdef] FMC1_FMC_CSQIER_DEF
    \
    \ @brief FMC NAND command sequencer interrupt enable register
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_TCIE                      \ [0x00] Transfer Complete Interrupt enable
    $01 constant FMC1_SCIE                      \ [0x01] Sector Complete interrupt enable
    $02 constant FMC1_SEIE                      \ [0x02] Sector Error interrupt enable
    $03 constant FMC1_SUEIE                     \ [0x03] Sector Uncorrectable Error interrupt enable
    $04 constant FMC1_CMDTCIE                   \ [0x04] Command Transfer Complete interrupt enable
  [then]


  [ifdef] FMC1_FMC_CSQISR_DEF
    \
    \ @brief FMC NAND command sequencer interrupt status register
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_TCF                       \ [0x00] Transfer Complete flag
    $01 constant FMC1_SCF                       \ [0x01] Sector Complete flag
    $02 constant FMC1_SEF                       \ [0x02] Sector Error flag
    $03 constant FMC1_SUEF                      \ [0x03] Sector Uncorrectable Error flag
    $04 constant FMC1_CMDTCF                    \ [0x04] Command Transfer Complete flag
  [then]


  [ifdef] FMC1_FMC_CSQICR_DEF
    \
    \ @brief FMC NAND command sequencer interrupt clear register
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_CTCF                      \ [0x00] Clear Transfer Complete flag
    $01 constant FMC1_CSCF                      \ [0x01] Clear Sector Complete flag
    $02 constant FMC1_CSEF                      \ [0x02] Clear Sector Error flag
    $03 constant FMC1_CSUEF                     \ [0x03] Clear Sector uncorrectable Error flag
    $04 constant FMC1_CCMDTCF                   \ [0x04] Clear Command Transfer Complete flag
  [then]


  [ifdef] FMC1_FMC_CSQEMSR_DEF
    \
    \ @brief FMC command sequencer error mapping status register
    \ Address offset: 0x230
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_SEM                       \ [0x00 : 16] Sector Error mapping
  [then]


  [ifdef] FMC1_FMC_BCHIER_DEF
    \
    \ @brief FMC BCH interrupt enable register
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_DUEIE                     \ [0x00] Decoder Uncorrectable Errors Interrupt enable
    $01 constant FMC1_DERIE                     \ [0x01] Decoder Error Ready Interrupt enable
    $02 constant FMC1_DEFIE                     \ [0x02] Decoder Error Found Interrupt enable
    $03 constant FMC1_DSRIE                     \ [0x03] Decoder Syndrome Ready Interrupt enable
    $04 constant FMC1_EPBRIE                    \ [0x04] Decoder Parity Bits Ready Interrupt enable
  [then]


  [ifdef] FMC1_FMC_BCHISR_DEF
    \
    \ @brief FMC BCH interrupt and status register
    \ Address offset: 0x254
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_DUEF                      \ [0x00] Decoder Uncorrectable Errors flag
    $01 constant FMC1_DERF                      \ [0x01] Decoder Error Ready flag
    $02 constant FMC1_DEFF                      \ [0x02] Decoder Error Found flag
    $03 constant FMC1_DSRF                      \ [0x03] Decoder Syndrome Ready flag
    $04 constant FMC1_EPBRF                     \ [0x04] Encoder Parity Bits Ready flag
  [then]


  [ifdef] FMC1_FMC_BCHICR_DEF
    \
    \ @brief FMC BCH interrupt clear register
    \ Address offset: 0x258
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_CDUEF                     \ [0x00] Clear Decoder Uncorrectable Error flag
    $01 constant FMC1_CDERF                     \ [0x01] Clear Decoder Error ready flag
    $02 constant FMC1_CDEFF                     \ [0x02] Clear Decoder Error Found flag
    $03 constant FMC1_CDSRF                     \ [0x03] Clear Decoder Syndrome Ready flag
    $04 constant FMC1_CEPBRF                    \ [0x04] Clear Encoder Parity Bits Ready flag
  [then]


  [ifdef] FMC1_FMC_BCHPBR1_DEF
    \
    \ @brief FMC BCH parity bits register 1
    \ Address offset: 0x260
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_BCHPB                     \ [0x00 : 32] BCH parity bits
  [then]


  [ifdef] FMC1_FMC_BCHPBR2_DEF
    \
    \ @brief FMC BCH parity bits register 2
    \ Address offset: 0x264
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_BCHPB                     \ [0x00 : 32] BCH parity bits
  [then]


  [ifdef] FMC1_FMC_BCHPBR3_DEF
    \
    \ @brief FMC BCH parity bits register 3
    \ Address offset: 0x268
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_BCHPB                     \ [0x00 : 32] BCH parity bits
  [then]


  [ifdef] FMC1_FMC_BCHPBR4_DEF
    \
    \ @brief FMC BCH parity bits register 4
    \ Address offset: 0x26C
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_BCHPB                     \ [0x00 : 8] BCH parity bits
  [then]


  [ifdef] FMC1_FMC_BCHDSR0_DEF
    \
    \ @brief FMC BCH decoder status register 0
    \ Address offset: 0x27C
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_DUE                       \ [0x00] Decoder uncorrectable error
    $01 constant FMC1_DEF                       \ [0x01] Decoder error found
    $04 constant FMC1_DEN                       \ [0x04 : 4] Decoder error number
  [then]


  [ifdef] FMC1_FMC_BCHDSR1_DEF
    \
    \ @brief FMC BCH decoder status register for memory region 1
    \ Address offset: 0x280
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_EBP1                      \ [0x00 : 13] Error bit position for error number 1
    $10 constant FMC1_EBP2                      \ [0x10 : 13] Error bit position for error number 2
  [then]


  [ifdef] FMC1_FMC_BCHDSR2_DEF
    \
    \ @brief FMC BCH decoder status register for memory region 2
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_EBP3                      \ [0x00 : 13] Error bit position for error number 3
    $10 constant FMC1_EBP4                      \ [0x10 : 13] Error bit position for error number 4
  [then]


  [ifdef] FMC1_FMC_BCHDSR3_DEF
    \
    \ @brief FMC BCH decoder status register for memory region 3
    \ Address offset: 0x288
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_EBP5                      \ [0x00 : 13] Error bit position for error number 5
    $10 constant FMC1_EBP6                      \ [0x10 : 13] Error bit position for error number 6
  [then]


  [ifdef] FMC1_FMC_BCHDSR4_DEF
    \
    \ @brief FMC BCH decoder status register for memory region 4
    \ Address offset: 0x28C
    \ Reset value: 0x00000000
    \
    $00 constant FMC1_EBP7                      \ [0x00 : 13] Error bit position for error number 7
    $10 constant FMC1_EBP8                      \ [0x10 : 13] Error bit position for error number 8
  [then]

  \
  \ @brief Flexible memory controller
  \
  $00 constant FMC1_FMC_BCR1            \ SRAM/NOR Flash chip-select control register for memory region 1
  $04 constant FMC1_FMC_BTR1            \ SRAM/NOR Flash chip-select timing registers for memory region 1
  $08 constant FMC1_FMC_BCR2            \ SRAM/NOR Flash chip-select control register for memory region 2
  $0C constant FMC1_FMC_BTR2            \ SRAM/NOR Flash chip-select timing registers for memory region 2
  $10 constant FMC1_FMC_BCR3            \ SRAM/NOR Flash chip-select control register for memory region 3
  $14 constant FMC1_FMC_BTR3            \ SRAM/NOR Flash chip-select timing registers for memory region 3
  $18 constant FMC1_FMC_BCR4            \ SRAM/NOR Flash chip-select control register for memory region 4
  $1C constant FMC1_FMC_BTR4            \ SRAM/NOR Flash chip-select timing registers for memory region 4
  $20 constant FMC1_FMC_CFGR            \ FMC common configuration register
  $80 constant FMC1_FMC_PCR             \ NAND Flash programmable control register
  $84 constant FMC1_FMC_SR              \ FMC status register
  $88 constant FMC1_FMC_PMEM            \ FMC common memory space timing register
  $8C constant FMC1_FMC_PATT            \ FMC attribute memory space timing registers
  $90 constant FMC1_FMC_HPR             \ FMC Hamming parity result registers
  $94 constant FMC1_FMC_HECCR           \ FMC Hamming code ECC result register
  $104 constant FMC1_FMC_BWTR1          \ SRAM/NOR-Flash write timing registers for memory region 1
  $10C constant FMC1_FMC_BWTR2          \ SRAM/NOR-Flash write timing registers for memory region 2
  $114 constant FMC1_FMC_BWTR3          \ SRAM/NOR-Flash write timing registers for memory region 3
  $11C constant FMC1_FMC_BWTR4          \ SRAM/NOR-Flash write timing registers for memory region 4
  $140 constant FMC1_FMC_SDCR1          \ SDRAM control registers for SDRAM device 1
  $144 constant FMC1_FMC_SDCR2          \ SDRAM control registers for SDRAM device 2
  $148 constant FMC1_FMC_SDTR           \ SDRAM timing register
  $150 constant FMC1_FMC_SDCMR          \ SDRAM command mode register
  $154 constant FMC1_FMC_SDRTR          \ SDRAM refresh timer register
  $158 constant FMC1_FMC_SDSR           \ SDRAM status register
  $180 constant FMC1_FMC_IER            \ FMC NAND interrupt enable register
  $184 constant FMC1_FMC_ISR            \ FMC controller interrupt status register
  $188 constant FMC1_FMC_ICR            \ FMC NAND controller interrupt clear register
  $200 constant FMC1_FMC_CSQCR          \ FMC NAND command sequencer control register
  $204 constant FMC1_FMC_CSQCFGR1       \ FMC NAND command sequencer configuration register 1
  $208 constant FMC1_FMC_CSQCFGR2       \ FMC NAND command sequencer configuration register 2
  $20C constant FMC1_FMC_CSQCFGR3       \ FMC NAND sequencer configuration register 3
  $210 constant FMC1_FMC_CSQAR1         \ FMC NAND command sequencer address register 1
  $214 constant FMC1_FMC_CSQAR2         \ FMC NAND command sequencer address register 2
  $220 constant FMC1_FMC_CSQIER         \ FMC NAND command sequencer interrupt enable register
  $224 constant FMC1_FMC_CSQISR         \ FMC NAND command sequencer interrupt status register
  $228 constant FMC1_FMC_CSQICR         \ FMC NAND command sequencer interrupt clear register
  $230 constant FMC1_FMC_CSQEMSR        \ FMC command sequencer error mapping status register
  $250 constant FMC1_FMC_BCHIER         \ FMC BCH interrupt enable register
  $254 constant FMC1_FMC_BCHISR         \ FMC BCH interrupt and status register
  $258 constant FMC1_FMC_BCHICR         \ FMC BCH interrupt clear register
  $260 constant FMC1_FMC_BCHPBR1        \ FMC BCH parity bits register 1
  $264 constant FMC1_FMC_BCHPBR2        \ FMC BCH parity bits register 2
  $268 constant FMC1_FMC_BCHPBR3        \ FMC BCH parity bits register 3
  $26C constant FMC1_FMC_BCHPBR4        \ FMC BCH parity bits register 4
  $27C constant FMC1_FMC_BCHDSR0        \ FMC BCH decoder status register 0
  $280 constant FMC1_FMC_BCHDSR1        \ FMC BCH decoder status register for memory region 1
  $284 constant FMC1_FMC_BCHDSR2        \ FMC BCH decoder status register for memory region 2
  $288 constant FMC1_FMC_BCHDSR3        \ FMC BCH decoder status register for memory region 3
  $28C constant FMC1_FMC_BCHDSR4        \ FMC BCH decoder status register for memory region 4

: FMC1_DEF ; [then]
