\
\ @file fmc.fs
\ @brief FMC register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief This register contains the control information of each memory bank, used for SRAMs, PSRAM, FRAM and NOR Flash memories.
\ Address offset: 0x00
\ Reset value: 0x000030DB
\

$00000001 constant FMC_FMC_BCR1_MBKEN                               \ MBKEN
$00000002 constant FMC_FMC_BCR1_MUXEN                               \ MUXEN
$0000000c constant FMC_FMC_BCR1_MTYP                                \ MTYP
$00000030 constant FMC_FMC_BCR1_MWID                                \ MWID
$00000040 constant FMC_FMC_BCR1_FACCEN                              \ FACCEN
$00000100 constant FMC_FMC_BCR1_BURSTEN                             \ BURSTEN
$00000200 constant FMC_FMC_BCR1_WAITPOL                             \ WAITPOL
$00000800 constant FMC_FMC_BCR1_WAITCFG                             \ WAITCFG
$00001000 constant FMC_FMC_BCR1_WREN                                \ WREN
$00002000 constant FMC_FMC_BCR1_WAITEN                              \ WAITEN
$00004000 constant FMC_FMC_BCR1_EXTMOD                              \ EXTMOD
$00008000 constant FMC_FMC_BCR1_ASYNCWAIT                           \ ASYNCWAIT
$00070000 constant FMC_FMC_BCR1_CPSIZE                              \ CPSIZE
$00080000 constant FMC_FMC_BCR1_CBURSTRW                            \ CBURSTRW
$00100000 constant FMC_FMC_BCR1_CCLKEN                              \ CCLKEN
$00c00000 constant FMC_FMC_BCR1_NBLSET                              \ NBLSET
$80000000 constant FMC_FMC_BCR1_FMCEN                               \ FMCEN


\
\ @brief This register contains the control information of each memory bank, used for SRAMs, PSRAM and NOR Flash memories.If the EXTMOD bit is set in the FMC_BCRx register, then this register is partitioned for write and read access, that is, two registers are available: one to configure read accesses (this register) and one to configure write accesses (FMC_BWTRx registers).
\ Address offset: 0x04
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_FMC_BTR1_ADDSET                              \ ADDSET
$000000f0 constant FMC_FMC_BTR1_ADDHLD                              \ ADDHLD
$0000ff00 constant FMC_FMC_BTR1_DATAST                              \ DATAST
$000f0000 constant FMC_FMC_BTR1_BUSTURN                             \ BUSTURN
$00f00000 constant FMC_FMC_BTR1_CLKDIV                              \ CLKDIV
$0f000000 constant FMC_FMC_BTR1_DATLAT                              \ DATLAT
$30000000 constant FMC_FMC_BTR1_ACCMOD                              \ ACCMOD
$c0000000 constant FMC_FMC_BTR1_DATAHLD                             \ DATAHLD


\
\ @brief This register contains the control information of each memory bank, used for SRAMs, PSRAM, FRAM and NOR Flash memories.
\ Address offset: 0x08
\ Reset value: 0x000030DB
\

$00000001 constant FMC_FMC_BCR2_MBKEN                               \ MBKEN
$00000002 constant FMC_FMC_BCR2_MUXEN                               \ MUXEN
$0000000c constant FMC_FMC_BCR2_MTYP                                \ MTYP
$00000030 constant FMC_FMC_BCR2_MWID                                \ MWID
$00000040 constant FMC_FMC_BCR2_FACCEN                              \ FACCEN
$00000100 constant FMC_FMC_BCR2_BURSTEN                             \ BURSTEN
$00000200 constant FMC_FMC_BCR2_WAITPOL                             \ WAITPOL
$00000800 constant FMC_FMC_BCR2_WAITCFG                             \ WAITCFG
$00001000 constant FMC_FMC_BCR2_WREN                                \ WREN
$00002000 constant FMC_FMC_BCR2_WAITEN                              \ WAITEN
$00004000 constant FMC_FMC_BCR2_EXTMOD                              \ EXTMOD
$00008000 constant FMC_FMC_BCR2_ASYNCWAIT                           \ ASYNCWAIT
$00070000 constant FMC_FMC_BCR2_CPSIZE                              \ CPSIZE
$00080000 constant FMC_FMC_BCR2_CBURSTRW                            \ CBURSTRW
$00100000 constant FMC_FMC_BCR2_CCLKEN                              \ CCLKEN
$00c00000 constant FMC_FMC_BCR2_NBLSET                              \ NBLSET
$80000000 constant FMC_FMC_BCR2_FMCEN                               \ FMCEN


\
\ @brief This register contains the control information of each memory bank, used for SRAMs, PSRAM and NOR Flash memories.If the EXTMOD bit is set in the FMC_BCRx register, then this register is partitioned for write and read access, that is, two registers are available: one to configure read accesses (this register) and one to configure write accesses (FMC_BWTRx registers).
\ Address offset: 0x0C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_FMC_BTR2_ADDSET                              \ ADDSET
$000000f0 constant FMC_FMC_BTR2_ADDHLD                              \ ADDHLD
$0000ff00 constant FMC_FMC_BTR2_DATAST                              \ DATAST
$000f0000 constant FMC_FMC_BTR2_BUSTURN                             \ BUSTURN
$00f00000 constant FMC_FMC_BTR2_CLKDIV                              \ CLKDIV
$0f000000 constant FMC_FMC_BTR2_DATLAT                              \ DATLAT
$30000000 constant FMC_FMC_BTR2_ACCMOD                              \ ACCMOD
$c0000000 constant FMC_FMC_BTR2_DATAHLD                             \ DATAHLD


\
\ @brief This register contains the control information of each memory bank, used for SRAMs, PSRAM, FRAM and NOR Flash memories.
\ Address offset: 0x10
\ Reset value: 0x000030DB
\

$00000001 constant FMC_FMC_BCR3_MBKEN                               \ MBKEN
$00000002 constant FMC_FMC_BCR3_MUXEN                               \ MUXEN
$0000000c constant FMC_FMC_BCR3_MTYP                                \ MTYP
$00000030 constant FMC_FMC_BCR3_MWID                                \ MWID
$00000040 constant FMC_FMC_BCR3_FACCEN                              \ FACCEN
$00000100 constant FMC_FMC_BCR3_BURSTEN                             \ BURSTEN
$00000200 constant FMC_FMC_BCR3_WAITPOL                             \ WAITPOL
$00000800 constant FMC_FMC_BCR3_WAITCFG                             \ WAITCFG
$00001000 constant FMC_FMC_BCR3_WREN                                \ WREN
$00002000 constant FMC_FMC_BCR3_WAITEN                              \ WAITEN
$00004000 constant FMC_FMC_BCR3_EXTMOD                              \ EXTMOD
$00008000 constant FMC_FMC_BCR3_ASYNCWAIT                           \ ASYNCWAIT
$00070000 constant FMC_FMC_BCR3_CPSIZE                              \ CPSIZE
$00080000 constant FMC_FMC_BCR3_CBURSTRW                            \ CBURSTRW
$00100000 constant FMC_FMC_BCR3_CCLKEN                              \ CCLKEN
$00c00000 constant FMC_FMC_BCR3_NBLSET                              \ NBLSET
$80000000 constant FMC_FMC_BCR3_FMCEN                               \ FMCEN


\
\ @brief This register contains the control information of each memory bank, used for SRAMs, PSRAM and NOR Flash memories.If the EXTMOD bit is set in the FMC_BCRx register, then this register is partitioned for write and read access, that is, two registers are available: one to configure read accesses (this register) and one to configure write accesses (FMC_BWTRx registers).
\ Address offset: 0x14
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_FMC_BTR3_ADDSET                              \ ADDSET
$000000f0 constant FMC_FMC_BTR3_ADDHLD                              \ ADDHLD
$0000ff00 constant FMC_FMC_BTR3_DATAST                              \ DATAST
$000f0000 constant FMC_FMC_BTR3_BUSTURN                             \ BUSTURN
$00f00000 constant FMC_FMC_BTR3_CLKDIV                              \ CLKDIV
$0f000000 constant FMC_FMC_BTR3_DATLAT                              \ DATLAT
$30000000 constant FMC_FMC_BTR3_ACCMOD                              \ ACCMOD
$c0000000 constant FMC_FMC_BTR3_DATAHLD                             \ DATAHLD


\
\ @brief This register contains the control information of each memory bank, used for SRAMs, PSRAM, FRAM and NOR Flash memories.
\ Address offset: 0x18
\ Reset value: 0x000030DB
\

$00000001 constant FMC_FMC_BCR4_MBKEN                               \ MBKEN
$00000002 constant FMC_FMC_BCR4_MUXEN                               \ MUXEN
$0000000c constant FMC_FMC_BCR4_MTYP                                \ MTYP
$00000030 constant FMC_FMC_BCR4_MWID                                \ MWID
$00000040 constant FMC_FMC_BCR4_FACCEN                              \ FACCEN
$00000100 constant FMC_FMC_BCR4_BURSTEN                             \ BURSTEN
$00000200 constant FMC_FMC_BCR4_WAITPOL                             \ WAITPOL
$00000800 constant FMC_FMC_BCR4_WAITCFG                             \ WAITCFG
$00001000 constant FMC_FMC_BCR4_WREN                                \ WREN
$00002000 constant FMC_FMC_BCR4_WAITEN                              \ WAITEN
$00004000 constant FMC_FMC_BCR4_EXTMOD                              \ EXTMOD
$00008000 constant FMC_FMC_BCR4_ASYNCWAIT                           \ ASYNCWAIT
$00070000 constant FMC_FMC_BCR4_CPSIZE                              \ CPSIZE
$00080000 constant FMC_FMC_BCR4_CBURSTRW                            \ CBURSTRW
$00100000 constant FMC_FMC_BCR4_CCLKEN                              \ CCLKEN
$00c00000 constant FMC_FMC_BCR4_NBLSET                              \ NBLSET
$80000000 constant FMC_FMC_BCR4_FMCEN                               \ FMCEN


\
\ @brief This register contains the control information of each memory bank, used for SRAMs, PSRAM and NOR Flash memories.If the EXTMOD bit is set in the FMC_BCRx register, then this register is partitioned for write and read access, that is, two registers are available: one to configure read accesses (this register) and one to configure write accesses (FMC_BWTRx registers).
\ Address offset: 0x1C
\ Reset value: 0x0FFFFFFF
\

$0000000f constant FMC_FMC_BTR4_ADDSET                              \ ADDSET
$000000f0 constant FMC_FMC_BTR4_ADDHLD                              \ ADDHLD
$0000ff00 constant FMC_FMC_BTR4_DATAST                              \ DATAST
$000f0000 constant FMC_FMC_BTR4_BUSTURN                             \ BUSTURN
$00f00000 constant FMC_FMC_BTR4_CLKDIV                              \ CLKDIV
$0f000000 constant FMC_FMC_BTR4_DATLAT                              \ DATLAT
$30000000 constant FMC_FMC_BTR4_ACCMOD                              \ ACCMOD
$c0000000 constant FMC_FMC_BTR4_DATAHLD                             \ DATAHLD


\
\ @brief This register contains the PSRAM chip select counter value for synchronous mode. The chip select counter is common to all banks and can be enabled separately on each bank. During PSRAM read or write accesses, this value is loaded into a timer which is decremented using the fmc_ker_ck while the NE signal is held low. When the timer reaches 0, the PSRAM controller splits the current access, toggles NE to allow PSRAM device refresh and restarts a new access. The programmed counter value guarantees a maximum NE pulse width (tCEM) as specified for PSRAM devices. The counter is reloaded and starts decrementing each time a new access is started by a transition of NE from high to low. h
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant FMC_FMC_PCSCNTR_CSCOUNT                          \ CSCOUNT
$00010000 constant FMC_FMC_PCSCNTR_CNTB1EN                          \ CNTB1EN
$00020000 constant FMC_FMC_PCSCNTR_CNTB2EN                          \ CNTB2EN
$00040000 constant FMC_FMC_PCSCNTR_CNTB3EN                          \ CNTB3EN
$00080000 constant FMC_FMC_PCSCNTR_CNTB4EN                          \ CNTB4EN


\
\ @brief NAND Flash Programmable control register
\ Address offset: 0x80
\ Reset value: 0x0007FE08
\

$00000002 constant FMC_FMC_PCR_PWAITEN                              \ PWAITEN
$00000004 constant FMC_FMC_PCR_PBKEN                                \ PBKEN
$00000030 constant FMC_FMC_PCR_PWID                                 \ PWID
$00000040 constant FMC_FMC_PCR_ECCEN                                \ ECCEN
$00000100 constant FMC_FMC_PCR_ECCALG                               \ ECCALG
$00001e00 constant FMC_FMC_PCR_TCLR                                 \ TCLR
$0001e000 constant FMC_FMC_PCR_TAR                                  \ TAR
$000e0000 constant FMC_FMC_PCR_ECCSS                                \ ECCSS
$00f00000 constant FMC_FMC_PCR_TCEH                                 \ TCEH
$01000000 constant FMC_FMC_PCR_BCHECC                               \ BCHECC
$02000000 constant FMC_FMC_PCR_WEN                                  \ WEN


\
\ @brief This register contains information about the AXI interface isolation status and the NAND write requests status. The FMC has to be disabled before modifying some registers. As requests might be pending, it is necessary to wait till the AXI interface is stable and the core of the block is totally isolated from its AXI interface before reconfiguring the registers. The PEF and PNWEF bits indicate the status of the pipe. If Hamming algorithm is used, the ECC is calculated while data are written to the memory. To read the correct ECC, the software must consequently wait untill no write request to the NAND controller are pending, by polling PEF and NWRF bits.
\ Address offset: 0x84
\ Reset value: 0x00000040
\

$00000003 constant FMC_FMC_SR_ISOST                                 \ ISOST
$00000010 constant FMC_FMC_SR_PEF                                   \ PEF
$00000040 constant FMC_FMC_SR_NWRF                                  \ NWRF


\
\ @brief The FMC_PMEM read/write register contains NAND Flash memory bank timing information. This information is used to access the NAND Flash common memory space for command, address write accesses or data read/write accesses.
\ Address offset: 0x88
\ Reset value: 0x0A0A0A0A
\

$000000ff constant FMC_FMC_PMEM_MEMSET                              \ MEMSET
$0000ff00 constant FMC_FMC_PMEM_MEMWAIT                             \ MEMWAIT
$00ff0000 constant FMC_FMC_PMEM_MEMHOLD                             \ MEMHOLD
$ff000000 constant FMC_FMC_PMEM_MEMHIZ                              \ MEMHIZ


\
\ @brief The FMC_PATT read/write register contains NAND Flash memory bank timing information. It is used for 8-bit accesses to the NAND Flash attribute memory space during the last address write access when the timing differs from previous accesses (for Ready/Busy management, refer to Section25.8.5: NAND Flash prewait function).
\ Address offset: 0x8C
\ Reset value: 0x0A0A0A0A
\

$000000ff constant FMC_FMC_PATT_ATTSET                              \ ATTSET
$0000ff00 constant FMC_FMC_PATT_ATTWAIT                             \ ATTWAIT
$00ff0000 constant FMC_FMC_PATT_ATTHOLD                             \ ATTHOLD
$ff000000 constant FMC_FMC_PATT_ATTHIZ                              \ ATTHIZ


\
\ @brief This register is used during read accesses in conjunction with the FMC sequencer. It contains the current error correction code value computed by the FMC NAND controller Hamming module. When the FMC sequencer reads data from a NAND Flash memory page at the correct address, the data read are automatically processed by the Hamming computation module. When X bytes have been read (according to the sector size ECCSS field in the FMC_PCR register), the CPU must read the computed ECC value from the FMC_HECCR register. It then verifies if these computed parity data are the same as the parity value recorded in the spare area and stored in the and the FMC_HPR, to determine whether a page is valid, and to correct it otherwise. The FMC_HPR register should be cleared after being read by setting the ECCEN bit to 0. To compute a new data block, the ECCEN bit must be set to 1.
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant FMC_FMC_HPR_HPR                                  \ HPR


\
\ @brief This register contain the current error correction code value computed by the FMC NAND controller Hamming module.When the CPU reads/writes data from/to a NAND Flash memory page at the correct address (refer to Section25.8.6: NAND ECC controller), the data read/written from/to the NAND Flash memory are automatically processed by the Hamming computation module. When X bytes have been read (according to the sector size ECCSS field in the FMC_PCR register), the CPU must read the computed ECC value from the FMC_HECCR register. It then verifies if these computed parity data are the same as the parity value recorded in the spare area, to determine whether a page is valid, and to correct it otherwise. The FMC_HECCR register should be cleared after being read by setting the ECCEN bit to 0. To compute a new data block, the ECCEN bit must be set to 1.
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant FMC_FMC_HECCR_HECC                               \ HECC


\
\ @brief This register contains the control information of each memory bank. It is used for SRAMs, FRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
\ Address offset: 0x104
\ Reset value: 0x000FFFFF
\

$0000000f constant FMC_FMC_BWTR1_ADDSET                             \ ADDSET
$000000f0 constant FMC_FMC_BWTR1_ADDHLD                             \ ADDHLD
$0000ff00 constant FMC_FMC_BWTR1_DATAST                             \ DATAST
$000f0000 constant FMC_FMC_BWTR1_BUSTURN                            \ BUSTURN
$30000000 constant FMC_FMC_BWTR1_ACCMOD                             \ ACCMOD
$c0000000 constant FMC_FMC_BWTR1_DATAHLD                            \ DATAHLD


\
\ @brief This register contains the control information of each memory bank. It is used for SRAMs, FRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
\ Address offset: 0x10C
\ Reset value: 0x000FFFFF
\

$0000000f constant FMC_FMC_BWTR2_ADDSET                             \ ADDSET
$000000f0 constant FMC_FMC_BWTR2_ADDHLD                             \ ADDHLD
$0000ff00 constant FMC_FMC_BWTR2_DATAST                             \ DATAST
$000f0000 constant FMC_FMC_BWTR2_BUSTURN                            \ BUSTURN
$30000000 constant FMC_FMC_BWTR2_ACCMOD                             \ ACCMOD
$c0000000 constant FMC_FMC_BWTR2_DATAHLD                            \ DATAHLD


\
\ @brief This register contains the control information of each memory bank. It is used for SRAMs, FRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
\ Address offset: 0x114
\ Reset value: 0x000FFFFF
\

$0000000f constant FMC_FMC_BWTR3_ADDSET                             \ ADDSET
$000000f0 constant FMC_FMC_BWTR3_ADDHLD                             \ ADDHLD
$0000ff00 constant FMC_FMC_BWTR3_DATAST                             \ DATAST
$000f0000 constant FMC_FMC_BWTR3_BUSTURN                            \ BUSTURN
$30000000 constant FMC_FMC_BWTR3_ACCMOD                             \ ACCMOD
$c0000000 constant FMC_FMC_BWTR3_DATAHLD                            \ DATAHLD


\
\ @brief This register contains the control information of each memory bank. It is used for SRAMs, FRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
\ Address offset: 0x11C
\ Reset value: 0x000FFFFF
\

$0000000f constant FMC_FMC_BWTR4_ADDSET                             \ ADDSET
$000000f0 constant FMC_FMC_BWTR4_ADDHLD                             \ ADDHLD
$0000ff00 constant FMC_FMC_BWTR4_DATAST                             \ DATAST
$000f0000 constant FMC_FMC_BWTR4_BUSTURN                            \ BUSTURN
$30000000 constant FMC_FMC_BWTR4_ACCMOD                             \ ACCMOD
$c0000000 constant FMC_FMC_BWTR4_DATAHLD                            \ DATAHLD


\
\ @brief FMC NAND Command Sequencer Control Register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant FMC_FMC_CSQCR_CSQSTART                           \ CSQSTART


\
\ @brief FMC NAND Command Sequencer Configuration Register 1
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000002 constant FMC_FMC_CSQCFGR1_CMD2EN                          \ CMD2EN
$00000004 constant FMC_FMC_CSQCFGR1_DMADEN                          \ DMADEN
$00000070 constant FMC_FMC_CSQCFGR1_ACYNBR                          \ ACYNBR
$0000ff00 constant FMC_FMC_CSQCFGR1_CMD1                            \ CMD1
$00ff0000 constant FMC_FMC_CSQCFGR1_CMD2                            \ CMD2
$01000000 constant FMC_FMC_CSQCFGR1_CMD1T                           \ CMD1T
$02000000 constant FMC_FMC_CSQCFGR1_CMD2T                           \ CMD2T


\
\ @brief This register is used to configure the command sequencer to issue random read/ write commands to read/ write data by sector and automatically read/write data from NAND Flash memory at a programmable address offset. This is useful when performing a sector read/write operation followed by an ECC read/write operation in the NAND Flash spare area.The command sequencer generates the random commands untill all the sectors are read/written. .
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000001 constant FMC_FMC_CSQCFGR2_SQSDTEN                         \ SQSDTEN
$00000002 constant FMC_FMC_CSQCFGR2_RCMD2EN                         \ RCMD2EN
$00000004 constant FMC_FMC_CSQCFGR2_DMASEN                          \ DMASEN
$0000ff00 constant FMC_FMC_CSQCFGR2_RCMD1                           \ RCMD1
$00ff0000 constant FMC_FMC_CSQCFGR2_RCMD2                           \ RCMD2
$01000000 constant FMC_FMC_CSQCFGR2_RCMD1T                          \ RCMD1T
$02000000 constant FMC_FMC_CSQCFGR2_RCMD2T                          \ RCMD2T


\
\ @brief FMC NAND sequencer configuration register 3
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$00003f00 constant FMC_FMC_CSQCFGR3_SNBR                            \ SNBR
$00010000 constant FMC_FMC_CSQCFGR3_AC1T                            \ AC1T
$00020000 constant FMC_FMC_CSQCFGR3_AC2T                            \ AC2T
$00040000 constant FMC_FMC_CSQCFGR3_AC3T                            \ AC3T
$00080000 constant FMC_FMC_CSQCFGR3_AC4T                            \ AC4T
$00100000 constant FMC_FMC_CSQCFGR3_AC5T                            \ AC5T
$00200000 constant FMC_FMC_CSQCFGR3_SDT                             \ SDT
$00400000 constant FMC_FMC_CSQCFGR3_RAC1T                           \ RAC1T
$00800000 constant FMC_FMC_CSQCFGR3_RAC2T                           \ RAC2T


\
\ @brief This register is used to define the value of address cycles 1 to 4 to be issued by the command sequencer.
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$000000ff constant FMC_FMC_CSQAR1_ADDC1                             \ ADDC1
$0000ff00 constant FMC_FMC_CSQAR1_ADDC2                             \ ADDC2
$00ff0000 constant FMC_FMC_CSQAR1_ADDC3                             \ ADDC3
$ff000000 constant FMC_FMC_CSQAR1_ADDC4                             \ ADDC4


\
\ @brief This register is used to program the fifth address cycle and the address offset in spare area. It also selects the chip enable.
\ Address offset: 0x214
\ Reset value: 0x00020000
\

$000000ff constant FMC_FMC_CSQAR2_ADDC5                             \ ADDC5
$00000400 constant FMC_FMC_CSQAR2_NANDCEN0                          \ NANDCEN0
$00000800 constant FMC_FMC_CSQAR2_NANDCEN1                          \ NANDCEN1
$ffff0000 constant FMC_FMC_CSQAR2_SAO                               \ SAO


\
\ @brief FMC NAND Command Sequencer Interrupt Enable Register
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$00000001 constant FMC_FMC_CSQIER_TCIE                              \ TCIE
$00000002 constant FMC_FMC_CSQIER_SCIE                              \ SCIE
$00000004 constant FMC_FMC_CSQIER_SEIE                              \ SEIE
$00000008 constant FMC_FMC_CSQIER_SUEIE                             \ SUEIE
$00000010 constant FMC_FMC_CSQIER_CMDTCIE                           \ CMDTCIE


\
\ @brief FMC NAND Command Sequencer Interrupt Status Register
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$00000001 constant FMC_FMC_CSQISR_TCF                               \ TCF
$00000002 constant FMC_FMC_CSQISR_SCF                               \ SCF
$00000004 constant FMC_FMC_CSQISR_SEF                               \ SEF
$00000008 constant FMC_FMC_CSQISR_SUEF                              \ SUEF
$00000010 constant FMC_FMC_CSQISR_CMDTCF                            \ CMDTCF


\
\ @brief FMC NAND Command Sequencer Interrupt Clear Register
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$00000001 constant FMC_FMC_CSQICR_CTCF                              \ CTCF
$00000002 constant FMC_FMC_CSQICR_CSCF                              \ CSCF
$00000004 constant FMC_FMC_CSQICR_CSEF                              \ CSEF
$00000008 constant FMC_FMC_CSQICR_CSUEF                             \ CSUEF
$00000010 constant FMC_FMC_CSQICR_CCMDTCF                           \ CCMDTCF


\
\ @brief This register holds a sector error mapping status when the whole transfer is complete.
\ Address offset: 0x230
\ Reset value: 0x00000000
\

$0000ffff constant FMC_FMC_CSQEMSR_SEM                              \ SEM


\
\ @brief FMC BCH Interrupt enable register
\ Address offset: 0x250
\ Reset value: 0x00000000
\

$00000001 constant FMC_FMC_BCHIER_DUEIE                             \ DUEIE
$00000002 constant FMC_FMC_BCHIER_DERIE                             \ DERIE
$00000004 constant FMC_FMC_BCHIER_DEFIE                             \ DEFIE
$00000008 constant FMC_FMC_BCHIER_DSRIE                             \ DSRIE
$00000010 constant FMC_FMC_BCHIER_EPBRIE                            \ EPBRIE


\
\ @brief This register holds the status of BCH encoder/decoder after processing each sector. When the sequencer is used, this register is automatically cleared.
\ Address offset: 0x254
\ Reset value: 0x00000000
\

$00000001 constant FMC_FMC_BCHISR_DUEF                              \ DUEF
$00000002 constant FMC_FMC_BCHISR_DERF                              \ DERF
$00000004 constant FMC_FMC_BCHISR_DEFF                              \ DEFF
$00000008 constant FMC_FMC_BCHISR_DSRF                              \ DSRF
$00000010 constant FMC_FMC_BCHISR_EPBRF                             \ EPBRF


\
\ @brief FMC BCH Interrupt Clear Register
\ Address offset: 0x258
\ Reset value: 0x00000000
\

$00000001 constant FMC_FMC_BCHICR_CDUEF                             \ CDUEF
$00000002 constant FMC_FMC_BCHICR_CDERF                             \ CDERF
$00000004 constant FMC_FMC_BCHICR_CDEFF                             \ CDEFF
$00000008 constant FMC_FMC_BCHICR_CDSRF                             \ CDSRF
$00000010 constant FMC_FMC_BCHICR_CEPBRF                            \ CEPBRF


\
\ @brief These registers contain the BCH parity bits (BCHPB). For the BCH 4-bit, only BCHPB[51:0] are significant and for the BCH 8-bit BCHPB[103:0] are significant.
\ Address offset: 0x260
\ Reset value: 0x00000000
\

$00000000 constant FMC_FMC_BCHPBR1_BCHPB                            \ BCHPB


\
\ @brief FMC BCH Parity Bits Register 2
\ Address offset: 0x264
\ Reset value: 0x00000000
\

$00000000 constant FMC_FMC_BCHPBR2_BCHPB                            \ BCHPB


\
\ @brief FMC BCH Parity Bits Register 3
\ Address offset: 0x268
\ Reset value: 0x00000000
\

$00000000 constant FMC_FMC_BCHPBR3_BCHPB                            \ BCHPB


\
\ @brief FMC BCH Parity Bits Register 4
\ Address offset: 0x26C
\ Reset value: 0x00000000
\

$000000ff constant FMC_FMC_BCHPBR4_BCHPB                            \ BCHPB


\
\ @brief This register contains some fields already available in other registers but that require to be saved when error correction is performed on several sectors at a time (for example a whole NAND Flash page). This allows a DMA channel to transfer the content of FMC_BCHDSR0..4 to a decoding status buffer. .
\ Address offset: 0x27C
\ Reset value: 0x00000000
\

$00000001 constant FMC_FMC_BCHDSR0_DUE                              \ DUE
$00000002 constant FMC_FMC_BCHDSR0_DEF                              \ DEF
$000000f0 constant FMC_FMC_BCHDSR0_DEN                              \ DEN


\
\ @brief The maximum error correction capability of the BCH block embedded in the FMC is 8 errors
\ Address offset: 0x280
\ Reset value: 0x00000000
\

$00001fff constant FMC_FMC_BCHDSR1_EBP1                             \ EBP1
$1fff0000 constant FMC_FMC_BCHDSR1_EBP2                             \ EBP2


\
\ @brief The maximum error correction capability of the BCH block embedded in the FMC is 8 errors. This register contains the positions of the 3rd and 4th error bits in EBP3 and EPB4 fields, respectively.
\ Address offset: 0x284
\ Reset value: 0x00000000
\

$00001fff constant FMC_FMC_BCHDSR2_EBP3                             \ EBP3
$1fff0000 constant FMC_FMC_BCHDSR2_EBP4                             \ EBP4


\
\ @brief The maximum error correction capability of the BCH block embedded in the FMC is 8 errors.
\ Address offset: 0x288
\ Reset value: 0x00000000
\

$00001fff constant FMC_FMC_BCHDSR3_EBP5                             \ EBP5
$1fff0000 constant FMC_FMC_BCHDSR3_EBP6                             \ EBP6


\
\ @brief The maximum error correction capability of the BCH block embedded in the FMC is 8 errors. This register contains the positions of the 7th and 8th error bits in EBP7 and EPB8 fields, respectively. .
\ Address offset: 0x28C
\ Reset value: 0x00000000
\

$00001fff constant FMC_FMC_BCHDSR4_EBP7                             \ EBP7
$1fff0000 constant FMC_FMC_BCHDSR4_EBP8                             \ EBP8


\
\ @brief FMC Hardware configuration register 2
\ Address offset: 0x3EC
\ Reset value: 0x00DC8762
\

$0000000f constant FMC_FMC_HWCFGR2_RD_LN2DPTH                       \ RD_LN2DPTH
$000000f0 constant FMC_FMC_HWCFGR2_NOR_BASE                         \ NOR_BASE
$00000f00 constant FMC_FMC_HWCFGR2_SDRAM_RBASE                      \ SDRAM_RBASE
$0000f000 constant FMC_FMC_HWCFGR2_NAND_BASE                        \ NAND_BASE
$000f0000 constant FMC_FMC_HWCFGR2_SDRAM1_BASE                      \ SDRAM1_BASE
$00f00000 constant FMC_FMC_HWCFGR2_SDRAM2_BASE                      \ SDRAM2_BASE


\
\ @brief FMC Hardware configuration register 1
\ Address offset: 0x3F0
\ Reset value: 0x2232B011
\

$00000001 constant FMC_FMC_HWCFGR1_NAND_SEL                         \ NAND_SEL
$00000010 constant FMC_FMC_HWCFGR1_NAND_ECC                         \ NAND_ECC
$00000100 constant FMC_FMC_HWCFGR1_SDRAM_SEL                        \ SDRAM_SEL
$0000f000 constant FMC_FMC_HWCFGR1_ID_SIZE                          \ ID_SIZE
$000f0000 constant FMC_FMC_HWCFGR1_WA_LN2DPTH                       \ WA_LN2DPTH
$00f00000 constant FMC_FMC_HWCFGR1_WD_LN2DPTH                       \ WD_LN2DPTH
$0f000000 constant FMC_FMC_HWCFGR1_WR_LN2DPTH                       \ WR_LN2DPTH
$f0000000 constant FMC_FMC_HWCFGR1_RA_LN2DPTH                       \ RA_LN2DPTH


\
\ @brief FMC Version register
\ Address offset: 0x3F4
\ Reset value: 0x00000011
\

$0000000f constant FMC_FMC_VERR_MINREV                              \ MINREV
$000000f0 constant FMC_FMC_VERR_MAJREV                              \ MAJREV


\
\ @brief FMC Identification register
\ Address offset: 0x3F8
\ Reset value: 0x00140001
\

$00000000 constant FMC_FMC_IPIDR_ID                                 \ ID


\
\ @brief FMC Size Identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant FMC_FMC_SIDR_SID                                 \ SID


\
\ @brief FMC register block
\
$58002000 constant FMC_FMC_BCR1   \ offset: 0x00 : This register contains the control information of each memory bank, used for SRAMs, PSRAM, FRAM and NOR Flash memories.
$58002004 constant FMC_FMC_BTR1   \ offset: 0x04 : This register contains the control information of each memory bank, used for SRAMs, PSRAM and NOR Flash memories.If the EXTMOD bit is set in the FMC_BCRx register, then this register is partitioned for write and read access, that is, two registers are available: one to configure read accesses (this register) and one to configure write accesses (FMC_BWTRx registers).
$58002008 constant FMC_FMC_BCR2   \ offset: 0x08 : This register contains the control information of each memory bank, used for SRAMs, PSRAM, FRAM and NOR Flash memories.
$5800200c constant FMC_FMC_BTR2   \ offset: 0x0C : This register contains the control information of each memory bank, used for SRAMs, PSRAM and NOR Flash memories.If the EXTMOD bit is set in the FMC_BCRx register, then this register is partitioned for write and read access, that is, two registers are available: one to configure read accesses (this register) and one to configure write accesses (FMC_BWTRx registers).
$58002010 constant FMC_FMC_BCR3   \ offset: 0x10 : This register contains the control information of each memory bank, used for SRAMs, PSRAM, FRAM and NOR Flash memories.
$58002014 constant FMC_FMC_BTR3   \ offset: 0x14 : This register contains the control information of each memory bank, used for SRAMs, PSRAM and NOR Flash memories.If the EXTMOD bit is set in the FMC_BCRx register, then this register is partitioned for write and read access, that is, two registers are available: one to configure read accesses (this register) and one to configure write accesses (FMC_BWTRx registers).
$58002018 constant FMC_FMC_BCR4   \ offset: 0x18 : This register contains the control information of each memory bank, used for SRAMs, PSRAM, FRAM and NOR Flash memories.
$5800201c constant FMC_FMC_BTR4   \ offset: 0x1C : This register contains the control information of each memory bank, used for SRAMs, PSRAM and NOR Flash memories.If the EXTMOD bit is set in the FMC_BCRx register, then this register is partitioned for write and read access, that is, two registers are available: one to configure read accesses (this register) and one to configure write accesses (FMC_BWTRx registers).
$58002020 constant FMC_FMC_PCSCNTR  \ offset: 0x20 : This register contains the PSRAM chip select counter value for synchronous mode. The chip select counter is common to all banks and can be enabled separately on each bank. During PSRAM read or write accesses, this value is loaded into a timer which is decremented using the fmc_ker_ck while the NE signal is held low. When the timer reaches 0, the PSRAM controller splits the current access, toggles NE to allow PSRAM device refresh and restarts a new access. The programmed counter value guarantees a maximum NE pulse width (tCEM) as specified for PSRAM devices. The counter is reloaded and starts decrementing each time a new access is started by a transition of NE from high to low. h
$58002080 constant FMC_FMC_PCR    \ offset: 0x80 : NAND Flash Programmable control register
$58002084 constant FMC_FMC_SR     \ offset: 0x84 : This register contains information about the AXI interface isolation status and the NAND write requests status. The FMC has to be disabled before modifying some registers. As requests might be pending, it is necessary to wait till the AXI interface is stable and the core of the block is totally isolated from its AXI interface before reconfiguring the registers. The PEF and PNWEF bits indicate the status of the pipe. If Hamming algorithm is used, the ECC is calculated while data are written to the memory. To read the correct ECC, the software must consequently wait untill no write request to the NAND controller are pending, by polling PEF and NWRF bits.
$58002088 constant FMC_FMC_PMEM   \ offset: 0x88 : The FMC_PMEM read/write register contains NAND Flash memory bank timing information. This information is used to access the NAND Flash common memory space for command, address write accesses or data read/write accesses.
$5800208c constant FMC_FMC_PATT   \ offset: 0x8C : The FMC_PATT read/write register contains NAND Flash memory bank timing information. It is used for 8-bit accesses to the NAND Flash attribute memory space during the last address write access when the timing differs from previous accesses (for Ready/Busy management, refer to Section25.8.5: NAND Flash prewait function).
$58002090 constant FMC_FMC_HPR    \ offset: 0x90 : This register is used during read accesses in conjunction with the FMC sequencer. It contains the current error correction code value computed by the FMC NAND controller Hamming module. When the FMC sequencer reads data from a NAND Flash memory page at the correct address, the data read are automatically processed by the Hamming computation module. When X bytes have been read (according to the sector size ECCSS field in the FMC_PCR register), the CPU must read the computed ECC value from the FMC_HECCR register. It then verifies if these computed parity data are the same as the parity value recorded in the spare area and stored in the and the FMC_HPR, to determine whether a page is valid, and to correct it otherwise. The FMC_HPR register should be cleared after being read by setting the ECCEN bit to 0. To compute a new data block, the ECCEN bit must be set to 1.
$58002094 constant FMC_FMC_HECCR  \ offset: 0x94 : This register contain the current error correction code value computed by the FMC NAND controller Hamming module.When the CPU reads/writes data from/to a NAND Flash memory page at the correct address (refer to Section25.8.6: NAND ECC controller), the data read/written from/to the NAND Flash memory are automatically processed by the Hamming computation module. When X bytes have been read (according to the sector size ECCSS field in the FMC_PCR register), the CPU must read the computed ECC value from the FMC_HECCR register. It then verifies if these computed parity data are the same as the parity value recorded in the spare area, to determine whether a page is valid, and to correct it otherwise. The FMC_HECCR register should be cleared after being read by setting the ECCEN bit to 0. To compute a new data block, the ECCEN bit must be set to 1.
$58002104 constant FMC_FMC_BWTR1  \ offset: 0x104 : This register contains the control information of each memory bank. It is used for SRAMs, FRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
$5800210c constant FMC_FMC_BWTR2  \ offset: 0x10C : This register contains the control information of each memory bank. It is used for SRAMs, FRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
$58002114 constant FMC_FMC_BWTR3  \ offset: 0x114 : This register contains the control information of each memory bank. It is used for SRAMs, FRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
$5800211c constant FMC_FMC_BWTR4  \ offset: 0x11C : This register contains the control information of each memory bank. It is used for SRAMs, FRAMs, PSRAMs and NOR Flash memories. When the EXTMOD bit is set in the FMC_BCRx register, then this register is active for write access.
$58002200 constant FMC_FMC_CSQCR  \ offset: 0x200 : FMC NAND Command Sequencer Control Register
$58002204 constant FMC_FMC_CSQCFGR1  \ offset: 0x204 : FMC NAND Command Sequencer Configuration Register 1
$58002208 constant FMC_FMC_CSQCFGR2  \ offset: 0x208 : This register is used to configure the command sequencer to issue random read/ write commands to read/ write data by sector and automatically read/write data from NAND Flash memory at a programmable address offset. This is useful when performing a sector read/write operation followed by an ECC read/write operation in the NAND Flash spare area.The command sequencer generates the random commands untill all the sectors are read/written. .
$5800220c constant FMC_FMC_CSQCFGR3  \ offset: 0x20C : FMC NAND sequencer configuration register 3
$58002210 constant FMC_FMC_CSQAR1  \ offset: 0x210 : This register is used to define the value of address cycles 1 to 4 to be issued by the command sequencer.
$58002214 constant FMC_FMC_CSQAR2  \ offset: 0x214 : This register is used to program the fifth address cycle and the address offset in spare area. It also selects the chip enable.
$58002220 constant FMC_FMC_CSQIER  \ offset: 0x220 : FMC NAND Command Sequencer Interrupt Enable Register
$58002224 constant FMC_FMC_CSQISR  \ offset: 0x224 : FMC NAND Command Sequencer Interrupt Status Register
$58002228 constant FMC_FMC_CSQICR  \ offset: 0x228 : FMC NAND Command Sequencer Interrupt Clear Register
$58002230 constant FMC_FMC_CSQEMSR  \ offset: 0x230 : This register holds a sector error mapping status when the whole transfer is complete.
$58002250 constant FMC_FMC_BCHIER  \ offset: 0x250 : FMC BCH Interrupt enable register
$58002254 constant FMC_FMC_BCHISR  \ offset: 0x254 : This register holds the status of BCH encoder/decoder after processing each sector. When the sequencer is used, this register is automatically cleared.
$58002258 constant FMC_FMC_BCHICR  \ offset: 0x258 : FMC BCH Interrupt Clear Register
$58002260 constant FMC_FMC_BCHPBR1  \ offset: 0x260 : These registers contain the BCH parity bits (BCHPB). For the BCH 4-bit, only BCHPB[51:0] are significant and for the BCH 8-bit BCHPB[103:0] are significant.
$58002264 constant FMC_FMC_BCHPBR2  \ offset: 0x264 : FMC BCH Parity Bits Register 2
$58002268 constant FMC_FMC_BCHPBR3  \ offset: 0x268 : FMC BCH Parity Bits Register 3
$5800226c constant FMC_FMC_BCHPBR4  \ offset: 0x26C : FMC BCH Parity Bits Register 4
$5800227c constant FMC_FMC_BCHDSR0  \ offset: 0x27C : This register contains some fields already available in other registers but that require to be saved when error correction is performed on several sectors at a time (for example a whole NAND Flash page). This allows a DMA channel to transfer the content of FMC_BCHDSR0..4 to a decoding status buffer. .
$58002280 constant FMC_FMC_BCHDSR1  \ offset: 0x280 : The maximum error correction capability of the BCH block embedded in the FMC is 8 errors
$58002284 constant FMC_FMC_BCHDSR2  \ offset: 0x284 : The maximum error correction capability of the BCH block embedded in the FMC is 8 errors. This register contains the positions of the 3rd and 4th error bits in EBP3 and EPB4 fields, respectively.
$58002288 constant FMC_FMC_BCHDSR3  \ offset: 0x288 : The maximum error correction capability of the BCH block embedded in the FMC is 8 errors.
$5800228c constant FMC_FMC_BCHDSR4  \ offset: 0x28C : The maximum error correction capability of the BCH block embedded in the FMC is 8 errors. This register contains the positions of the 7th and 8th error bits in EBP7 and EPB8 fields, respectively. .
$580023ec constant FMC_FMC_HWCFGR2  \ offset: 0x3EC : FMC Hardware configuration register 2
$580023f0 constant FMC_FMC_HWCFGR1  \ offset: 0x3F0 : FMC Hardware configuration register 1
$580023f4 constant FMC_FMC_VERR   \ offset: 0x3F4 : FMC Version register
$580023f8 constant FMC_FMC_IPIDR  \ offset: 0x3F8 : FMC Identification register
$580023fc constant FMC_FMC_SIDR   \ offset: 0x3FC : FMC Size Identification register

