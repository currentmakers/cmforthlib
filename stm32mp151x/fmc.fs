\
\ @file fmc.fs
\ @brief FMC register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FMC_DEF

  [ifdef] FMC_FMC_BCR1_DEF
    \
    \ @brief This register contains the control information of each memory bank, used for SRAMs, PSRAM, FRAM and NOR Flash memories.
    \ Address offset: 0x00
    \ Reset value: 0x000030DB
    \
    $00 constant FMC_MBKEN                      \ [0x00] MBKEN
    $01 constant FMC_MUXEN                      \ [0x01] MUXEN
    $02 constant FMC_MTYP                       \ [0x02 : 2] MTYP
    $04 constant FMC_MWID                       \ [0x04 : 2] MWID
    $06 constant FMC_FACCEN                     \ [0x06] FACCEN
    $08 constant FMC_BURSTEN                    \ [0x08] BURSTEN
    $09 constant FMC_WAITPOL                    \ [0x09] WAITPOL
    $0b constant FMC_WAITCFG                    \ [0x0b] WAITCFG
    $0c constant FMC_WREN                       \ [0x0c] WREN
    $0d constant FMC_WAITEN                     \ [0x0d] WAITEN
    $0e constant FMC_EXTMOD                     \ [0x0e] EXTMOD
    $0f constant FMC_ASYNCWAIT                  \ [0x0f] ASYNCWAIT
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CPSIZE
    $13 constant FMC_CBURSTRW                   \ [0x13] CBURSTRW
    $14 constant FMC_CCLKEN                     \ [0x14] CCLKEN
    $16 constant FMC_NBLSET                     \ [0x16 : 2] NBLSET
    $1f constant FMC_FMCEN                      \ [0x1f] FMCEN
  [then]


  [ifdef] FMC_FMC_BTR1_DEF
    \
    \ @brief This register contains the control information of each memory bank, used for SRAMs, PSRAM and NOR Flash memories.If the EXTMOD bit is set in the FMC_BCRx register, then this register is partitioned for write and read access, that is, two registers are available: one to configure read accesses (this register) and one to configure write accesses (FMC_BWTRx registers).
    \ Address offset: 0x04
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] ADDSET
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] ADDHLD
    $08 constant FMC_DATAST                     \ [0x08 : 8] DATAST
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] BUSTURN
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] CLKDIV
    $18 constant FMC_DATLAT                     \ [0x18 : 4] DATLAT
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] ACCMOD
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] DATAHLD
  [then]


  [ifdef] FMC_FMC_BCR2_DEF
    \
    \ @brief This register contains the control information of each memory bank, used for SRAMs, PSRAM, FRAM and NOR Flash memories.
    \ Address offset: 0x08
    \ Reset value: 0x000030DB
    \
    $00 constant FMC_MBKEN                      \ [0x00] MBKEN
    $01 constant FMC_MUXEN                      \ [0x01] MUXEN
    $02 constant FMC_MTYP                       \ [0x02 : 2] MTYP
    $04 constant FMC_MWID                       \ [0x04 : 2] MWID
    $06 constant FMC_FACCEN                     \ [0x06] FACCEN
    $08 constant FMC_BURSTEN                    \ [0x08] BURSTEN
    $09 constant FMC_WAITPOL                    \ [0x09] WAITPOL
    $0b constant FMC_WAITCFG                    \ [0x0b] WAITCFG
    $0c constant FMC_WREN                       \ [0x0c] WREN
    $0d constant FMC_WAITEN                     \ [0x0d] WAITEN
    $0e constant FMC_EXTMOD                     \ [0x0e] EXTMOD
    $0f constant FMC_ASYNCWAIT                  \ [0x0f] ASYNCWAIT
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CPSIZE
    $13 constant FMC_CBURSTRW                   \ [0x13] CBURSTRW
    $14 constant FMC_CCLKEN                     \ [0x14] CCLKEN
    $16 constant FMC_NBLSET                     \ [0x16 : 2] NBLSET
    $1f constant FMC_FMCEN                      \ [0x1f] FMCEN
  [then]


  [ifdef] FMC_FMC_BTR2_DEF
    \
    \ @brief This register contains the control information of each memory bank, used for SRAMs, PSRAM and NOR Flash memories.If the EXTMOD bit is set in the FMC_BCRx register, then this register is partitioned for write and read access, that is, two registers are available: one to configure read accesses (this register) and one to configure write accesses (FMC_BWTRx registers).
    \ Address offset: 0x0C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] ADDSET
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] ADDHLD
    $08 constant FMC_DATAST                     \ [0x08 : 8] DATAST
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] BUSTURN
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] CLKDIV
    $18 constant FMC_DATLAT                     \ [0x18 : 4] DATLAT
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] ACCMOD
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] DATAHLD
  [then]


  [ifdef] FMC_FMC_BCR3_DEF
    \
    \ @brief This register contains the control information of each memory bank, used for SRAMs, PSRAM, FRAM and NOR Flash memories.
    \ Address offset: 0x10
    \ Reset value: 0x000030DB
    \
    $00 constant FMC_MBKEN                      \ [0x00] MBKEN
    $01 constant FMC_MUXEN                      \ [0x01] MUXEN
    $02 constant FMC_MTYP                       \ [0x02 : 2] MTYP
    $04 constant FMC_MWID                       \ [0x04 : 2] MWID
    $06 constant FMC_FACCEN                     \ [0x06] FACCEN
    $08 constant FMC_BURSTEN                    \ [0x08] BURSTEN
    $09 constant FMC_WAITPOL                    \ [0x09] WAITPOL
    $0b constant FMC_WAITCFG                    \ [0x0b] WAITCFG
    $0c constant FMC_WREN                       \ [0x0c] WREN
    $0d constant FMC_WAITEN                     \ [0x0d] WAITEN
    $0e constant FMC_EXTMOD                     \ [0x0e] EXTMOD
    $0f constant FMC_ASYNCWAIT                  \ [0x0f] ASYNCWAIT
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CPSIZE
    $13 constant FMC_CBURSTRW                   \ [0x13] CBURSTRW
    $14 constant FMC_CCLKEN                     \ [0x14] CCLKEN
    $16 constant FMC_NBLSET                     \ [0x16 : 2] NBLSET
    $1f constant FMC_FMCEN                      \ [0x1f] FMCEN
  [then]


  [ifdef] FMC_FMC_BTR3_DEF
    \
    \ @brief This register contains the control information of each memory bank, used for SRAMs, PSRAM and NOR Flash memories.If the EXTMOD bit is set in the FMC_BCRx register, then this register is partitioned for write and read access, that is, two registers are available: one to configure read accesses (this register) and one to configure write accesses (FMC_BWTRx registers).
    \ Address offset: 0x14
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] ADDSET
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] ADDHLD
    $08 constant FMC_DATAST                     \ [0x08 : 8] DATAST
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] BUSTURN
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] CLKDIV
    $18 constant FMC_DATLAT                     \ [0x18 : 4] DATLAT
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] ACCMOD
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] DATAHLD
  [then]


  [ifdef] FMC_FMC_BCR4_DEF
    \
    \ @brief This register contains the control information of each memory bank, used for SRAMs, PSRAM, FRAM and NOR Flash memories.
    \ Address offset: 0x18
    \ Reset value: 0x000030DB
    \
    $00 constant FMC_MBKEN                      \ [0x00] MBKEN
    $01 constant FMC_MUXEN                      \ [0x01] MUXEN
    $02 constant FMC_MTYP                       \ [0x02 : 2] MTYP
    $04 constant FMC_MWID                       \ [0x04 : 2] MWID
    $06 constant FMC_FACCEN                     \ [0x06] FACCEN
    $08 constant FMC_BURSTEN                    \ [0x08] BURSTEN
    $09 constant FMC_WAITPOL                    \ [0x09] WAITPOL
    $0b constant FMC_WAITCFG                    \ [0x0b] WAITCFG
    $0c constant FMC_WREN                       \ [0x0c] WREN
    $0d constant FMC_WAITEN                     \ [0x0d] WAITEN
    $0e constant FMC_EXTMOD                     \ [0x0e] EXTMOD
    $0f constant FMC_ASYNCWAIT                  \ [0x0f] ASYNCWAIT
    $10 constant FMC_CPSIZE                     \ [0x10 : 3] CPSIZE
    $13 constant FMC_CBURSTRW                   \ [0x13] CBURSTRW
    $14 constant FMC_CCLKEN                     \ [0x14] CCLKEN
    $16 constant FMC_NBLSET                     \ [0x16 : 2] NBLSET
    $1f constant FMC_FMCEN                      \ [0x1f] FMCEN
  [then]


  [ifdef] FMC_FMC_BTR4_DEF
    \
    \ @brief This register contains the control information of each memory bank, used for SRAMs, PSRAM and NOR Flash memories.If the EXTMOD bit is set in the FMC_BCRx register, then this register is partitioned for write and read access, that is, two registers are available: one to configure read accesses (this register) and one to configure write accesses (FMC_BWTRx registers).
    \ Address offset: 0x1C
    \ Reset value: 0x0FFFFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] ADDSET
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] ADDHLD
    $08 constant FMC_DATAST                     \ [0x08 : 8] DATAST
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] BUSTURN
    $14 constant FMC_CLKDIV                     \ [0x14 : 4] CLKDIV
    $18 constant FMC_DATLAT                     \ [0x18 : 4] DATLAT
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] ACCMOD
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] DATAHLD
  [then]


  [ifdef] FMC_FMC_PCSCNTR_DEF
    \
    \ @brief This register contains the PSRAM chip select counter value for synchronous mode. The chip select counter is common to all banks and can be enabled separately on each bank. During PSRAM read or write accesses, this value is loaded into a timer which is decremented using the fmc_ker_ck while the NE signal is held low. When the timer reaches 0, the PSRAM controller splits the current access, toggles NE to allow PSRAM device refresh and restarts a new access. The programmed counter value guarantees a maximum NE pulse width (tCEM) as specified for PSRAM devices. The counter is reloaded and starts decrementing each time a new access is started by a transition of NE from high to low. h
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant FMC_CSCOUNT                    \ [0x00 : 16] CSCOUNT
    $10 constant FMC_CNTB1EN                    \ [0x10] CNTB1EN
    $11 constant FMC_CNTB2EN                    \ [0x11] CNTB2EN
    $12 constant FMC_CNTB3EN                    \ [0x12] CNTB3EN
    $13 constant FMC_CNTB4EN                    \ [0x13] CNTB4EN
  [then]


  [ifdef] FMC_FMC_PCR_DEF
    \
    \ @brief NAND Flash Programmable control register
    \ Address offset: 0x80
    \ Reset value: 0x0007FE08
    \
    $01 constant FMC_PWAITEN                    \ [0x01] PWAITEN
    $02 constant FMC_PBKEN                      \ [0x02] PBKEN
    $04 constant FMC_PWID                       \ [0x04 : 2] PWID
    $06 constant FMC_ECCEN                      \ [0x06] ECCEN
    $08 constant FMC_ECCALG                     \ [0x08] ECCALG
    $09 constant FMC_TCLR                       \ [0x09 : 4] TCLR
    $0d constant FMC_TAR                        \ [0x0d : 4] TAR
    $11 constant FMC_ECCSS                      \ [0x11 : 3] ECCSS
    $14 constant FMC_TCEH                       \ [0x14 : 4] TCEH
    $18 constant FMC_BCHECC                     \ [0x18] BCHECC
    $19 constant FMC_WEN                        \ [0x19] WEN
  [then]


  [ifdef] FMC_FMC_SR_DEF
    \
    \ @brief This register contains information about the AXI interface isolation status and the NAND write requests status. The FMC has to be disabled before modifying some registers. As requests might be pending, it is necessary to wait till the AXI interface is stable and the core of the block is totally isolated from its AXI interface before reconfiguring the registers. The PEF and PNWEF bits indicate the status of the pipe. If Hamming algorithm is used, the ECC is calculated while data are written to the memory. To read the correct ECC, the software must consequently wait untill no write request to the NAND controller are pending, by polling PEF and NWRF bits.
    \ Address offset: 0x84
    \ Reset value: 0x00000040
    \
    $00 constant FMC_ISOST                      \ [0x00 : 2] ISOST
    $04 constant FMC_PEF                        \ [0x04] PEF
    $06 constant FMC_NWRF                       \ [0x06] NWRF
  [then]


  [ifdef] FMC_FMC_PMEM_DEF
    \
    \ @brief The FMC_PMEM read/write register contains NAND Flash memory bank timing information. This information is used to access the NAND Flash common memory space for command, address write accesses or data read/write accesses.
    \ Address offset: 0x88
    \ Reset value: 0x0A0A0A0A
    \
    $00 constant FMC_MEMSET                     \ [0x00 : 8] MEMSET
    $08 constant FMC_MEMWAIT                    \ [0x08 : 8] MEMWAIT
    $10 constant FMC_MEMHOLD                    \ [0x10 : 8] MEMHOLD
    $18 constant FMC_MEMHIZ                     \ [0x18 : 8] MEMHIZ
  [then]


  [ifdef] FMC_FMC_PATT_DEF
    \
    \ @brief The FMC_PATT read/write register contains NAND Flash memory bank timing information. It is used for 8-bit accesses to the NAND Flash attribute memory space during the last address write access when the timing differs from previous accesses (for Ready/Busy management, refer to Section25.8.5: NAND Flash prewait function).
    \ Address offset: 0x8C
    \ Reset value: 0x0A0A0A0A
    \
    $00 constant FMC_ATTSET                     \ [0x00 : 8] ATTSET
    $08 constant FMC_ATTWAIT                    \ [0x08 : 8] ATTWAIT
    $10 constant FMC_ATTHOLD                    \ [0x10 : 8] ATTHOLD
    $18 constant FMC_ATTHIZ                     \ [0x18 : 8] ATTHIZ
  [then]


  [ifdef] FMC_FMC_HPR_DEF
    \
    \ @brief This register is used during read accesses in conjunction with the FMC sequencer. It contains the current error correction code value computed by the FMC NAND controller Hamming module. When the FMC sequencer reads data from a NAND Flash memory page at the correct address, the data read are automatically processed by the Hamming computation module. When X bytes have been read (according to the sector size ECCSS field in the FMC_PCR register), the CPU must read the computed ECC value from the FMC_HECCR register. It then verifies if these computed parity data are the same as the parity value recorded in the spare area and stored in the and the FMC_HPR, to determine whether a page is valid, and to correct it otherwise. The FMC_HPR register should be cleared after being read by setting the ECCEN bit to 0. To compute a new data block, the ECCEN bit must be set to 1.
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant FMC_HPR                        \ [0x00 : 32] HPR
  [then]


  [ifdef] FMC_FMC_HECCR_DEF
    \
    \ @brief This register contain the current error correction code value computed by the FMC NAND controller Hamming module.When the CPU reads/writes data from/to a NAND Flash memory page at the correct address (refer to Section25.8.6: NAND ECC controller), the data read/written from/to the NAND Flash memory are automatically processed by the Hamming computation module. When X bytes have been read (according to the sector size ECCSS field in the FMC_PCR register), the CPU must read the computed ECC value from the FMC_HECCR register. It then verifies if these computed parity data are the same as the parity value recorded in the spare area, to determine whether a page is valid, and to correct it otherwise. The FMC_HECCR register should be cleared after being read by setting the ECCEN bit to 0. To compute a new data block, the ECCEN bit must be set to 1.
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant FMC_HECC                       \ [0x00 : 32] HECC
  [then]


  [ifdef] FMC_FMC_BWTR1_DEF
    \
    \ @brief This register contains the control information of each memory bank. It is used for SRAMs, FRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
    \ Address offset: 0x104
    \ Reset value: 0x000FFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] ADDSET
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] ADDHLD
    $08 constant FMC_DATAST                     \ [0x08 : 8] DATAST
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] BUSTURN
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] ACCMOD
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] DATAHLD
  [then]


  [ifdef] FMC_FMC_BWTR2_DEF
    \
    \ @brief This register contains the control information of each memory bank. It is used for SRAMs, FRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
    \ Address offset: 0x10C
    \ Reset value: 0x000FFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] ADDSET
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] ADDHLD
    $08 constant FMC_DATAST                     \ [0x08 : 8] DATAST
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] BUSTURN
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] ACCMOD
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] DATAHLD
  [then]


  [ifdef] FMC_FMC_BWTR3_DEF
    \
    \ @brief This register contains the control information of each memory bank. It is used for SRAMs, FRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
    \ Address offset: 0x114
    \ Reset value: 0x000FFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] ADDSET
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] ADDHLD
    $08 constant FMC_DATAST                     \ [0x08 : 8] DATAST
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] BUSTURN
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] ACCMOD
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] DATAHLD
  [then]


  [ifdef] FMC_FMC_BWTR4_DEF
    \
    \ @brief This register contains the control information of each memory bank. It is used for SRAMs, FRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
    \ Address offset: 0x11C
    \ Reset value: 0x000FFFFF
    \
    $00 constant FMC_ADDSET                     \ [0x00 : 4] ADDSET
    $04 constant FMC_ADDHLD                     \ [0x04 : 4] ADDHLD
    $08 constant FMC_DATAST                     \ [0x08 : 8] DATAST
    $10 constant FMC_BUSTURN                    \ [0x10 : 4] BUSTURN
    $1c constant FMC_ACCMOD                     \ [0x1c : 2] ACCMOD
    $1e constant FMC_DATAHLD                    \ [0x1e : 2] DATAHLD
  [then]


  [ifdef] FMC_FMC_CSQCR_DEF
    \
    \ @brief FMC NAND Command Sequencer Control Register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant FMC_CSQSTART                   \ [0x00] CSQSTART
  [then]


  [ifdef] FMC_FMC_CSQCFGR1_DEF
    \
    \ @brief FMC NAND Command Sequencer Configuration Register 1
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $01 constant FMC_CMD2EN                     \ [0x01] CMD2EN
    $02 constant FMC_DMADEN                     \ [0x02] DMADEN
    $04 constant FMC_ACYNBR                     \ [0x04 : 3] ACYNBR
    $08 constant FMC_CMD1                       \ [0x08 : 8] CMD1
    $10 constant FMC_CMD2                       \ [0x10 : 8] CMD2
    $18 constant FMC_CMD1T                      \ [0x18] CMD1T
    $19 constant FMC_CMD2T                      \ [0x19] CMD2T
  [then]


  [ifdef] FMC_FMC_CSQCFGR2_DEF
    \
    \ @brief This register is used to configure the command sequencer to issue random read/ write commands to read/ write data by sector and automatically read/write data from NAND Flash memory at a programmable address offset. This is useful when performing a sector read/write operation followed by an ECC read/write operation in the NAND Flash spare area.The command sequencer generates the random commands untill all the sectors are read/written. .
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant FMC_SQSDTEN                    \ [0x00] SQSDTEN
    $01 constant FMC_RCMD2EN                    \ [0x01] RCMD2EN
    $02 constant FMC_DMASEN                     \ [0x02] DMASEN
    $08 constant FMC_RCMD1                      \ [0x08 : 8] RCMD1
    $10 constant FMC_RCMD2                      \ [0x10 : 8] RCMD2
    $18 constant FMC_RCMD1T                     \ [0x18] RCMD1T
    $19 constant FMC_RCMD2T                     \ [0x19] RCMD2T
  [then]


  [ifdef] FMC_FMC_CSQCFGR3_DEF
    \
    \ @brief FMC NAND sequencer configuration register 3
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $08 constant FMC_SNBR                       \ [0x08 : 6] SNBR
    $10 constant FMC_AC1T                       \ [0x10] AC1T
    $11 constant FMC_AC2T                       \ [0x11] AC2T
    $12 constant FMC_AC3T                       \ [0x12] AC3T
    $13 constant FMC_AC4T                       \ [0x13] AC4T
    $14 constant FMC_AC5T                       \ [0x14] AC5T
    $15 constant FMC_SDT                        \ [0x15] SDT
    $16 constant FMC_RAC1T                      \ [0x16] RAC1T
    $17 constant FMC_RAC2T                      \ [0x17] RAC2T
  [then]


  [ifdef] FMC_FMC_CSQAR1_DEF
    \
    \ @brief This register is used to define the value of address cycles 1 to 4 to be issued by the command sequencer.
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant FMC_ADDC1                      \ [0x00 : 8] ADDC1
    $08 constant FMC_ADDC2                      \ [0x08 : 8] ADDC2
    $10 constant FMC_ADDC3                      \ [0x10 : 8] ADDC3
    $18 constant FMC_ADDC4                      \ [0x18 : 8] ADDC4
  [then]


  [ifdef] FMC_FMC_CSQAR2_DEF
    \
    \ @brief This register is used to program the fifth address cycle and the address offset in spare area. It also selects the chip enable.
    \ Address offset: 0x214
    \ Reset value: 0x00020000
    \
    $00 constant FMC_ADDC5                      \ [0x00 : 8] ADDC5
    $0a constant FMC_NANDCEN0                   \ [0x0a] NANDCEN0
    $0b constant FMC_NANDCEN1                   \ [0x0b] NANDCEN1
    $10 constant FMC_SAO                        \ [0x10 : 16] SAO
  [then]


  [ifdef] FMC_FMC_CSQIER_DEF
    \
    \ @brief FMC NAND Command Sequencer Interrupt Enable Register
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant FMC_TCIE                       \ [0x00] TCIE
    $01 constant FMC_SCIE                       \ [0x01] SCIE
    $02 constant FMC_SEIE                       \ [0x02] SEIE
    $03 constant FMC_SUEIE                      \ [0x03] SUEIE
    $04 constant FMC_CMDTCIE                    \ [0x04] CMDTCIE
  [then]


  [ifdef] FMC_FMC_CSQISR_DEF
    \
    \ @brief FMC NAND Command Sequencer Interrupt Status Register
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant FMC_TCF                        \ [0x00] TCF
    $01 constant FMC_SCF                        \ [0x01] SCF
    $02 constant FMC_SEF                        \ [0x02] SEF
    $03 constant FMC_SUEF                       \ [0x03] SUEF
    $04 constant FMC_CMDTCF                     \ [0x04] CMDTCF
  [then]


  [ifdef] FMC_FMC_CSQICR_DEF
    \
    \ @brief FMC NAND Command Sequencer Interrupt Clear Register
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant FMC_CTCF                       \ [0x00] CTCF
    $01 constant FMC_CSCF                       \ [0x01] CSCF
    $02 constant FMC_CSEF                       \ [0x02] CSEF
    $03 constant FMC_CSUEF                      \ [0x03] CSUEF
    $04 constant FMC_CCMDTCF                    \ [0x04] CCMDTCF
  [then]


  [ifdef] FMC_FMC_CSQEMSR_DEF
    \
    \ @brief This register holds a sector error mapping status when the whole transfer is complete.
    \ Address offset: 0x230
    \ Reset value: 0x00000000
    \
    $00 constant FMC_SEM                        \ [0x00 : 16] SEM
  [then]


  [ifdef] FMC_FMC_BCHIER_DEF
    \
    \ @brief FMC BCH Interrupt enable register
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $00 constant FMC_DUEIE                      \ [0x00] DUEIE
    $01 constant FMC_DERIE                      \ [0x01] DERIE
    $02 constant FMC_DEFIE                      \ [0x02] DEFIE
    $03 constant FMC_DSRIE                      \ [0x03] DSRIE
    $04 constant FMC_EPBRIE                     \ [0x04] EPBRIE
  [then]


  [ifdef] FMC_FMC_BCHISR_DEF
    \
    \ @brief This register holds the status of BCH encoder/decoder after processing each sector. When the sequencer is used, this register is automatically cleared.
    \ Address offset: 0x254
    \ Reset value: 0x00000000
    \
    $00 constant FMC_DUEF                       \ [0x00] DUEF
    $01 constant FMC_DERF                       \ [0x01] DERF
    $02 constant FMC_DEFF                       \ [0x02] DEFF
    $03 constant FMC_DSRF                       \ [0x03] DSRF
    $04 constant FMC_EPBRF                      \ [0x04] EPBRF
  [then]


  [ifdef] FMC_FMC_BCHICR_DEF
    \
    \ @brief FMC BCH Interrupt Clear Register
    \ Address offset: 0x258
    \ Reset value: 0x00000000
    \
    $00 constant FMC_CDUEF                      \ [0x00] CDUEF
    $01 constant FMC_CDERF                      \ [0x01] CDERF
    $02 constant FMC_CDEFF                      \ [0x02] CDEFF
    $03 constant FMC_CDSRF                      \ [0x03] CDSRF
    $04 constant FMC_CEPBRF                     \ [0x04] CEPBRF
  [then]


  [ifdef] FMC_FMC_BCHPBR1_DEF
    \
    \ @brief These registers contain the BCH parity bits (BCHPB). For the BCH 4-bit, only BCHPB[51:0] are significant and for the BCH 8-bit BCHPB[103:0] are significant.
    \ Address offset: 0x260
    \ Reset value: 0x00000000
    \
    $00 constant FMC_BCHPB                      \ [0x00 : 32] BCHPB
  [then]


  [ifdef] FMC_FMC_BCHPBR2_DEF
    \
    \ @brief FMC BCH Parity Bits Register 2
    \ Address offset: 0x264
    \ Reset value: 0x00000000
    \
    $00 constant FMC_BCHPB                      \ [0x00 : 32] BCHPB
  [then]


  [ifdef] FMC_FMC_BCHPBR3_DEF
    \
    \ @brief FMC BCH Parity Bits Register 3
    \ Address offset: 0x268
    \ Reset value: 0x00000000
    \
    $00 constant FMC_BCHPB                      \ [0x00 : 32] BCHPB
  [then]


  [ifdef] FMC_FMC_BCHPBR4_DEF
    \
    \ @brief FMC BCH Parity Bits Register 4
    \ Address offset: 0x26C
    \ Reset value: 0x00000000
    \
    $00 constant FMC_BCHPB                      \ [0x00 : 8] BCHPB
  [then]


  [ifdef] FMC_FMC_BCHDSR0_DEF
    \
    \ @brief This register contains some fields already available in other registers but that require to be saved when error correction is performed on several sectors at a time (for example a whole NAND Flash page). This allows a DMA channel to transfer the content of FMC_BCHDSR0..4 to a decoding status buffer. .
    \ Address offset: 0x27C
    \ Reset value: 0x00000000
    \
    $00 constant FMC_DUE                        \ [0x00] DUE
    $01 constant FMC_DEF                        \ [0x01] DEF
    $04 constant FMC_DEN                        \ [0x04 : 4] DEN
  [then]


  [ifdef] FMC_FMC_BCHDSR1_DEF
    \
    \ @brief The maximum error correction capability of the BCH block embedded in the FMC is 8 errors
    \ Address offset: 0x280
    \ Reset value: 0x00000000
    \
    $00 constant FMC_EBP1                       \ [0x00 : 13] EBP1
    $10 constant FMC_EBP2                       \ [0x10 : 13] EBP2
  [then]


  [ifdef] FMC_FMC_BCHDSR2_DEF
    \
    \ @brief The maximum error correction capability of the BCH block embedded in the FMC is 8 errors. This register contains the positions of the 3rd and 4th error bits in EBP3 and EPB4 fields, respectively.
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant FMC_EBP3                       \ [0x00 : 13] EBP3
    $10 constant FMC_EBP4                       \ [0x10 : 13] EBP4
  [then]


  [ifdef] FMC_FMC_BCHDSR3_DEF
    \
    \ @brief The maximum error correction capability of the BCH block embedded in the FMC is 8 errors.
    \ Address offset: 0x288
    \ Reset value: 0x00000000
    \
    $00 constant FMC_EBP5                       \ [0x00 : 13] EBP5
    $10 constant FMC_EBP6                       \ [0x10 : 13] EBP6
  [then]


  [ifdef] FMC_FMC_BCHDSR4_DEF
    \
    \ @brief The maximum error correction capability of the BCH block embedded in the FMC is 8 errors. This register contains the positions of the 7th and 8th error bits in EBP7 and EPB8 fields, respectively. .
    \ Address offset: 0x28C
    \ Reset value: 0x00000000
    \
    $00 constant FMC_EBP7                       \ [0x00 : 13] EBP7
    $10 constant FMC_EBP8                       \ [0x10 : 13] EBP8
  [then]


  [ifdef] FMC_FMC_HWCFGR2_DEF
    \
    \ @brief FMC Hardware configuration register 2
    \ Address offset: 0x3EC
    \ Reset value: 0x00DC8762
    \
    $00 constant FMC_RD_LN2DPTH                 \ [0x00 : 4] RD_LN2DPTH
    $04 constant FMC_NOR_BASE                   \ [0x04 : 4] NOR_BASE
    $08 constant FMC_SDRAM_RBASE                \ [0x08 : 4] SDRAM_RBASE
    $0c constant FMC_NAND_BASE                  \ [0x0c : 4] NAND_BASE
    $10 constant FMC_SDRAM1_BASE                \ [0x10 : 4] SDRAM1_BASE
    $14 constant FMC_SDRAM2_BASE                \ [0x14 : 4] SDRAM2_BASE
  [then]


  [ifdef] FMC_FMC_HWCFGR1_DEF
    \
    \ @brief FMC Hardware configuration register 1
    \ Address offset: 0x3F0
    \ Reset value: 0x2232B011
    \
    $00 constant FMC_NAND_SEL                   \ [0x00] NAND_SEL
    $04 constant FMC_NAND_ECC                   \ [0x04] NAND_ECC
    $08 constant FMC_SDRAM_SEL                  \ [0x08] SDRAM_SEL
    $0c constant FMC_ID_SIZE                    \ [0x0c : 4] ID_SIZE
    $10 constant FMC_WA_LN2DPTH                 \ [0x10 : 4] WA_LN2DPTH
    $14 constant FMC_WD_LN2DPTH                 \ [0x14 : 4] WD_LN2DPTH
    $18 constant FMC_WR_LN2DPTH                 \ [0x18 : 4] WR_LN2DPTH
    $1c constant FMC_RA_LN2DPTH                 \ [0x1c : 4] RA_LN2DPTH
  [then]


  [ifdef] FMC_FMC_VERR_DEF
    \
    \ @brief FMC Version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000011
    \
    $00 constant FMC_MINREV                     \ [0x00 : 4] MINREV
    $04 constant FMC_MAJREV                     \ [0x04 : 4] MAJREV
  [then]


  [ifdef] FMC_FMC_IPIDR_DEF
    \
    \ @brief FMC Identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00140001
    \
    $00 constant FMC_ID                         \ [0x00 : 32] ID
  [then]


  [ifdef] FMC_FMC_SIDR_DEF
    \
    \ @brief FMC Size Identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant FMC_SID                        \ [0x00 : 32] SID
  [then]

  \
  \ @brief FMC register block
  \
  $00 constant FMC_FMC_BCR1             \ This register contains the control information of each memory bank, used for SRAMs, PSRAM, FRAM and NOR Flash memories.
  $04 constant FMC_FMC_BTR1             \ This register contains the control information of each memory bank, used for SRAMs, PSRAM and NOR Flash memories.If the EXTMOD bit is set in the FMC_BCRx register, then this register is partitioned for write and read access, that is, two registers are available: one to configure read accesses (this register) and one to configure write accesses (FMC_BWTRx registers).
  $08 constant FMC_FMC_BCR2             \ This register contains the control information of each memory bank, used for SRAMs, PSRAM, FRAM and NOR Flash memories.
  $0C constant FMC_FMC_BTR2             \ This register contains the control information of each memory bank, used for SRAMs, PSRAM and NOR Flash memories.If the EXTMOD bit is set in the FMC_BCRx register, then this register is partitioned for write and read access, that is, two registers are available: one to configure read accesses (this register) and one to configure write accesses (FMC_BWTRx registers).
  $10 constant FMC_FMC_BCR3             \ This register contains the control information of each memory bank, used for SRAMs, PSRAM, FRAM and NOR Flash memories.
  $14 constant FMC_FMC_BTR3             \ This register contains the control information of each memory bank, used for SRAMs, PSRAM and NOR Flash memories.If the EXTMOD bit is set in the FMC_BCRx register, then this register is partitioned for write and read access, that is, two registers are available: one to configure read accesses (this register) and one to configure write accesses (FMC_BWTRx registers).
  $18 constant FMC_FMC_BCR4             \ This register contains the control information of each memory bank, used for SRAMs, PSRAM, FRAM and NOR Flash memories.
  $1C constant FMC_FMC_BTR4             \ This register contains the control information of each memory bank, used for SRAMs, PSRAM and NOR Flash memories.If the EXTMOD bit is set in the FMC_BCRx register, then this register is partitioned for write and read access, that is, two registers are available: one to configure read accesses (this register) and one to configure write accesses (FMC_BWTRx registers).
  $20 constant FMC_FMC_PCSCNTR          \ This register contains the PSRAM chip select counter value for synchronous mode. The chip select counter is common to all banks and can be enabled separately on each bank. During PSRAM read or write accesses, this value is loaded into a timer which is decremented using the fmc_ker_ck while the NE signal is held low. When the timer reaches 0, the PSRAM controller splits the current access, toggles NE to allow PSRAM device refresh and restarts a new access. The programmed counter value guarantees a maximum NE pulse width (tCEM) as specified for PSRAM devices. The counter is reloaded and starts decrementing each time a new access is started by a transition of NE from high to low. h
  $80 constant FMC_FMC_PCR              \ NAND Flash Programmable control register
  $84 constant FMC_FMC_SR               \ This register contains information about the AXI interface isolation status and the NAND write requests status. The FMC has to be disabled before modifying some registers. As requests might be pending, it is necessary to wait till the AXI interface is stable and the core of the block is totally isolated from its AXI interface before reconfiguring the registers. The PEF and PNWEF bits indicate the status of the pipe. If Hamming algorithm is used, the ECC is calculated while data are written to the memory. To read the correct ECC, the software must consequently wait untill no write request to the NAND controller are pending, by polling PEF and NWRF bits.
  $88 constant FMC_FMC_PMEM             \ The FMC_PMEM read/write register contains NAND Flash memory bank timing information. This information is used to access the NAND Flash common memory space for command, address write accesses or data read/write accesses.
  $8C constant FMC_FMC_PATT             \ The FMC_PATT read/write register contains NAND Flash memory bank timing information. It is used for 8-bit accesses to the NAND Flash attribute memory space during the last address write access when the timing differs from previous accesses (for Ready/Busy management, refer to Section25.8.5: NAND Flash prewait function).
  $90 constant FMC_FMC_HPR              \ This register is used during read accesses in conjunction with the FMC sequencer. It contains the current error correction code value computed by the FMC NAND controller Hamming module. When the FMC sequencer reads data from a NAND Flash memory page at the correct address, the data read are automatically processed by the Hamming computation module. When X bytes have been read (according to the sector size ECCSS field in the FMC_PCR register), the CPU must read the computed ECC value from the FMC_HECCR register. It then verifies if these computed parity data are the same as the parity value recorded in the spare area and stored in the and the FMC_HPR, to determine whether a page is valid, and to correct it otherwise. The FMC_HPR register should be cleared after being read by setting the ECCEN bit to 0. To compute a new data block, the ECCEN bit must be set to 1.
  $94 constant FMC_FMC_HECCR            \ This register contain the current error correction code value computed by the FMC NAND controller Hamming module.When the CPU reads/writes data from/to a NAND Flash memory page at the correct address (refer to Section25.8.6: NAND ECC controller), the data read/written from/to the NAND Flash memory are automatically processed by the Hamming computation module. When X bytes have been read (according to the sector size ECCSS field in the FMC_PCR register), the CPU must read the computed ECC value from the FMC_HECCR register. It then verifies if these computed parity data are the same as the parity value recorded in the spare area, to determine whether a page is valid, and to correct it otherwise. The FMC_HECCR register should be cleared after being read by setting the ECCEN bit to 0. To compute a new data block, the ECCEN bit must be set to 1.
  $104 constant FMC_FMC_BWTR1           \ This register contains the control information of each memory bank. It is used for SRAMs, FRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
  $10C constant FMC_FMC_BWTR2           \ This register contains the control information of each memory bank. It is used for SRAMs, FRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
  $114 constant FMC_FMC_BWTR3           \ This register contains the control information of each memory bank. It is used for SRAMs, FRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
  $11C constant FMC_FMC_BWTR4           \ This register contains the control information of each memory bank. It is used for SRAMs, FRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
  $200 constant FMC_FMC_CSQCR           \ FMC NAND Command Sequencer Control Register
  $204 constant FMC_FMC_CSQCFGR1        \ FMC NAND Command Sequencer Configuration Register 1
  $208 constant FMC_FMC_CSQCFGR2        \ This register is used to configure the command sequencer to issue random read/ write commands to read/ write data by sector and automatically read/write data from NAND Flash memory at a programmable address offset. This is useful when performing a sector read/write operation followed by an ECC read/write operation in the NAND Flash spare area.The command sequencer generates the random commands untill all the sectors are read/written. .
  $20C constant FMC_FMC_CSQCFGR3        \ FMC NAND sequencer configuration register 3
  $210 constant FMC_FMC_CSQAR1          \ This register is used to define the value of address cycles 1 to 4 to be issued by the command sequencer.
  $214 constant FMC_FMC_CSQAR2          \ This register is used to program the fifth address cycle and the address offset in spare area. It also selects the chip enable.
  $220 constant FMC_FMC_CSQIER          \ FMC NAND Command Sequencer Interrupt Enable Register
  $224 constant FMC_FMC_CSQISR          \ FMC NAND Command Sequencer Interrupt Status Register
  $228 constant FMC_FMC_CSQICR          \ FMC NAND Command Sequencer Interrupt Clear Register
  $230 constant FMC_FMC_CSQEMSR         \ This register holds a sector error mapping status when the whole transfer is complete.
  $250 constant FMC_FMC_BCHIER          \ FMC BCH Interrupt enable register
  $254 constant FMC_FMC_BCHISR          \ This register holds the status of BCH encoder/decoder after processing each sector. When the sequencer is used, this register is automatically cleared.
  $258 constant FMC_FMC_BCHICR          \ FMC BCH Interrupt Clear Register
  $260 constant FMC_FMC_BCHPBR1         \ These registers contain the BCH parity bits (BCHPB). For the BCH 4-bit, only BCHPB[51:0] are significant and for the BCH 8-bit BCHPB[103:0] are significant.
  $264 constant FMC_FMC_BCHPBR2         \ FMC BCH Parity Bits Register 2
  $268 constant FMC_FMC_BCHPBR3         \ FMC BCH Parity Bits Register 3
  $26C constant FMC_FMC_BCHPBR4         \ FMC BCH Parity Bits Register 4
  $27C constant FMC_FMC_BCHDSR0         \ This register contains some fields already available in other registers but that require to be saved when error correction is performed on several sectors at a time (for example a whole NAND Flash page). This allows a DMA channel to transfer the content of FMC_BCHDSR0..4 to a decoding status buffer. .
  $280 constant FMC_FMC_BCHDSR1         \ The maximum error correction capability of the BCH block embedded in the FMC is 8 errors
  $284 constant FMC_FMC_BCHDSR2         \ The maximum error correction capability of the BCH block embedded in the FMC is 8 errors. This register contains the positions of the 3rd and 4th error bits in EBP3 and EPB4 fields, respectively.
  $288 constant FMC_FMC_BCHDSR3         \ The maximum error correction capability of the BCH block embedded in the FMC is 8 errors.
  $28C constant FMC_FMC_BCHDSR4         \ The maximum error correction capability of the BCH block embedded in the FMC is 8 errors. This register contains the positions of the 7th and 8th error bits in EBP7 and EPB8 fields, respectively. .
  $3EC constant FMC_FMC_HWCFGR2         \ FMC Hardware configuration register 2
  $3F0 constant FMC_FMC_HWCFGR1         \ FMC Hardware configuration register 1
  $3F4 constant FMC_FMC_VERR            \ FMC Version register
  $3F8 constant FMC_FMC_IPIDR           \ FMC Identification register
  $3FC constant FMC_FMC_SIDR            \ FMC Size Identification register

: FMC_DEF ; [then]
