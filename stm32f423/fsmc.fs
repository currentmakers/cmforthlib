\
\ @file fsmc.fs
\ @brief Flexible static memory controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief BCR1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant FSMC_BCR1_MBKEN                                  \ Memory bank enable bit
$00000002 constant FSMC_BCR1_MUXEN                                  \ Memory bank enable bit
$0000000c constant FSMC_BCR1_MTYP                                   \ Memory type
$00000030 constant FSMC_BCR1_MWID                                   \ Memory data bus width
$00000040 constant FSMC_BCR1_FACCEN                                 \ Flash access enable
$00000100 constant FSMC_BCR1_BURSTEN                                \ Burst enable bit
$00000200 constant FSMC_BCR1_WAITPOL                                \ Wait signal polarity bit
$00000800 constant FSMC_BCR1_WAITCFG                                \ Wait timing configuration
$00001000 constant FSMC_BCR1_WREN                                   \ Write enable bitWREN
$00002000 constant FSMC_BCR1_WAITEN                                 \ Wait enable bit
$00004000 constant FSMC_BCR1_EXTMOD                                 \ Extended mode enable
$00008000 constant FSMC_BCR1_ASYNCWAIT                              \ Wait signal during asynchronous transfers
$00070000 constant FSMC_BCR1_CPSIZE                                 \ CRAM page size
$00080000 constant FSMC_BCR1_CBURSTRW                               \ Write burst enable
$00100000 constant FSMC_BCR1_CCLKEN                                 \ Continuous Clock Enable
$00200000 constant FSMC_BCR1_WFDIS                                  \ Write FIFO Disable


\
\ @brief BTR1
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000000f constant FSMC_BTR1_ADDSET                                 \ Address setup phase duration
$000000f0 constant FSMC_BTR1_ADDHLD                                 \ Address-hold phase duration
$0000ff00 constant FSMC_BTR1_DATAST                                 \ Data-phase duration
$000f0000 constant FSMC_BTR1_BUSTURN                                \ Bus turnaround phase duration
$00f00000 constant FSMC_BTR1_CLKDIV                                 \ Clock divide ratio
$0f000000 constant FSMC_BTR1_DATLAT                                 \ Data latency
$30000000 constant FSMC_BTR1_ACCMOD                                 \ Access mode


\
\ @brief BCR2
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant FSMC_BCR2_MBKEN                                  \ Memory bank enable bit
$00000002 constant FSMC_BCR2_MUXEN                                  \ Address/data multiplexing enable bit
$0000000c constant FSMC_BCR2_MTYP                                   \ Memory type
$00000030 constant FSMC_BCR2_MWID                                   \ Memory data bus width
$00000040 constant FSMC_BCR2_FACCEN                                 \ Flash access enable
$00000100 constant FSMC_BCR2_BURSTEN                                \ Burst enable bit
$00000200 constant FSMC_BCR2_WAITPOL                                \ Wait signal polarity bit
$00000800 constant FSMC_BCR2_WAITCFG                                \ Wait timing configuration
$00001000 constant FSMC_BCR2_WREN                                   \ Write enable bit
$00002000 constant FSMC_BCR2_WAITEN                                 \ Wait enable bit
$00004000 constant FSMC_BCR2_EXTMOD                                 \ Extended mode enable
$00008000 constant FSMC_BCR2_ASYNCWAIT                              \ Wait signal during asynchronous transfers
$00070000 constant FSMC_BCR2_CPSIZE                                 \ CRAM page size
$00080000 constant FSMC_BCR2_CBURSTRW                               \ Write burst enable
$00100000 constant FSMC_BCR2_CCLKEN                                 \ Continuous Clock Enable
$00200000 constant FSMC_BCR2_WFDIS                                  \ Write FIFO Disable


\
\ @brief BTR2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant FSMC_BTR2_ADDSET                                 \ Address setup phase duration
$000000f0 constant FSMC_BTR2_ADDHLD                                 \ Address-hold phase duration
$0000ff00 constant FSMC_BTR2_DATAST                                 \ Data-phase duration
$000f0000 constant FSMC_BTR2_BUSTURN                                \ Bus turnaround phase duration
$00f00000 constant FSMC_BTR2_CLKDIV                                 \ Clock divide ratio
$0f000000 constant FSMC_BTR2_DATLAT                                 \ Data latency
$30000000 constant FSMC_BTR2_ACCMOD                                 \ Access mode


\
\ @brief BCR3
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant FSMC_BCR3_MBKEN                                  \ Memory bank enable bit
$00000002 constant FSMC_BCR3_MUXEN                                  \ Address/data multiplexing enable bit
$0000000c constant FSMC_BCR3_MTYP                                   \ Memory type
$00000030 constant FSMC_BCR3_MWID                                   \ Memory data bus width
$00000040 constant FSMC_BCR3_FACCEN                                 \ Flash access enable
$00000100 constant FSMC_BCR3_BURSTEN                                \ Burst enable bit
$00000200 constant FSMC_BCR3_WAITPOL                                \ Wait signal polarity bit
$00000800 constant FSMC_BCR3_WAITCFG                                \ Wait timing configuration
$00001000 constant FSMC_BCR3_WREN                                   \ Write enable bit
$00002000 constant FSMC_BCR3_WAITEN                                 \ Write enable bit
$00004000 constant FSMC_BCR3_EXTMOD                                 \ Extended mode enable
$00008000 constant FSMC_BCR3_ASYNCWAIT                              \ Wait signal during asynchronous transfers
$00070000 constant FSMC_BCR3_CPSIZE                                 \ CRAM page size
$00080000 constant FSMC_BCR3_CBURSTRW                               \ Write burst enable
$00100000 constant FSMC_BCR3_CCLKEN                                 \ Continuous Clock Enable
$00200000 constant FSMC_BCR3_WFDIS                                  \ Write FIFO Disable


\
\ @brief BTR3
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000000f constant FSMC_BTR3_ADDSET                                 \ Address setup phase duration
$000000f0 constant FSMC_BTR3_ADDHLD                                 \ Address-hold phase duration
$0000ff00 constant FSMC_BTR3_DATAST                                 \ Data-phase duration
$000f0000 constant FSMC_BTR3_BUSTURN                                \ Bus turnaround phase duration
$00f00000 constant FSMC_BTR3_CLKDIV                                 \ Clock divide ratio
$0f000000 constant FSMC_BTR3_DATLAT                                 \ Data latency
$30000000 constant FSMC_BTR3_ACCMOD                                 \ Access mode


\
\ @brief BCR4
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant FSMC_BCR4_MBKEN                                  \ Memory bank enable bit
$00000002 constant FSMC_BCR4_MUXEN                                  \ Address/data multiplexing enable bit
$0000000c constant FSMC_BCR4_MTYP                                   \ Memory type
$00000030 constant FSMC_BCR4_MWID                                   \ Memory data bus width
$00000040 constant FSMC_BCR4_FACCEN                                 \ Flash access enable
$00000100 constant FSMC_BCR4_BURSTEN                                \ Burst enable bit
$00000200 constant FSMC_BCR4_WAITPOL                                \ Wait signal polarity bit
$00000800 constant FSMC_BCR4_WAITCFG                                \ Wait timing configuration
$00001000 constant FSMC_BCR4_WREN                                   \ Write enable bit
$00002000 constant FSMC_BCR4_WAITEN                                 \ Wait enable bit
$00004000 constant FSMC_BCR4_EXTMOD                                 \ Extended mode enable
$00008000 constant FSMC_BCR4_ASYNCWAIT                              \ Extended mode enable
$00070000 constant FSMC_BCR4_CPSIZE                                 \ CRAM page size
$00080000 constant FSMC_BCR4_CBURSTRW                               \ Write burst enable
$00100000 constant FSMC_BCR4_CCLKEN                                 \ Continuous Clock Enable
$00200000 constant FSMC_BCR4_WFDIS                                  \ Write FIFO Disable


\
\ @brief BTR4
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant FSMC_BTR4_ADDSET                                 \ Address setup phase duration
$000000f0 constant FSMC_BTR4_ADDHLD                                 \ Address-hold phase duration
$0000ff00 constant FSMC_BTR4_DATAST                                 \ Data-phase duration
$000f0000 constant FSMC_BTR4_BUSTURN                                \ Bus turnaround phase duration
$00f00000 constant FSMC_BTR4_CLKDIV                                 \ Clock divide ratio
$0f000000 constant FSMC_BTR4_DATLAT                                 \ Data latency
$30000000 constant FSMC_BTR4_ACCMOD                                 \ Access mode


\
\ @brief BWTR1
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$0000000f constant FSMC_BWTR1_ADDSET                                \ Address setup phase duration
$000000f0 constant FSMC_BWTR1_ADDHLD                                \ Address-hold phase duration
$0000ff00 constant FSMC_BWTR1_DATAST                                \ Data-phase duration
$000f0000 constant FSMC_BWTR1_BUSTURN                               \ Bus turnaround phase duration
$30000000 constant FSMC_BWTR1_ACCMOD                                \ Access mode


\
\ @brief BWTR2
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$0000000f constant FSMC_BWTR2_ADDSET                                \ Address setup phase duration
$000000f0 constant FSMC_BWTR2_ADDHLD                                \ Address-hold phase duration
$0000ff00 constant FSMC_BWTR2_DATAST                                \ Data-phase duration
$000f0000 constant FSMC_BWTR2_BUSTURN                               \ Bus turnaround phase duration
$30000000 constant FSMC_BWTR2_ACCMOD                                \ Access mode


\
\ @brief BWTR3
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$0000000f constant FSMC_BWTR3_ADDSET                                \ Address setup phase duration
$000000f0 constant FSMC_BWTR3_ADDHLD                                \ Address-hold phase duration
$0000ff00 constant FSMC_BWTR3_DATAST                                \ Data-phase duration
$000f0000 constant FSMC_BWTR3_BUSTURN                               \ Bus turnaround phase duration
$30000000 constant FSMC_BWTR3_ACCMOD                                \ Access mode


\
\ @brief BWTR4
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$0000000f constant FSMC_BWTR4_ADDSET                                \ Address setup phase duration
$000000f0 constant FSMC_BWTR4_ADDHLD                                \ Address-hold phase duration
$0000ff00 constant FSMC_BWTR4_DATAST                                \ Data-phase duration
$000f0000 constant FSMC_BWTR4_BUSTURN                               \ Bus turnaround phase duration
$30000000 constant FSMC_BWTR4_ACCMOD                                \ Access mode


\
\ @brief Flexible static memory controller
\
$60000000 constant FSMC_BCR1      \ offset: 0x00 : BCR1
$60000004 constant FSMC_BTR1      \ offset: 0x04 : BTR1
$60000008 constant FSMC_BCR2      \ offset: 0x08 : BCR2
$6000000c constant FSMC_BTR2      \ offset: 0x0C : BTR2
$60000010 constant FSMC_BCR3      \ offset: 0x10 : BCR3
$60000014 constant FSMC_BTR3      \ offset: 0x14 : BTR3
$60000018 constant FSMC_BCR4      \ offset: 0x18 : BCR4
$6000001c constant FSMC_BTR4      \ offset: 0x1C : BTR4
$60000104 constant FSMC_BWTR1     \ offset: 0x104 : BWTR1
$6000010c constant FSMC_BWTR2     \ offset: 0x10C : BWTR2
$60000114 constant FSMC_BWTR3     \ offset: 0x114 : BWTR3
$6000011c constant FSMC_BWTR4     \ offset: 0x11C : BWTR4

