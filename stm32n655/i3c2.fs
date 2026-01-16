\
\ @file i3c2.fs
\ @brief I3C2 event interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief I3C message control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000ffff constant I3C2_I3C_CR_DCNT                                 \ Count of data to transfer during a read or write message, in bytes (whatever I3C acts as controller/target)
$00010000 constant I3C2_I3C_CR_RNW                                  \ Read / non-write message (when I3C acts as controller)
$00fe0000 constant I3C2_I3C_CR_ADD                                  \ 7-bit I3C dynamic / Iless thansup>2less than/sup>C static target address (when I3C acts as controller)
$78000000 constant I3C2_I3C_CR_MTYPE                                \ Message type (whatever I3C acts as controller/target)
$80000000 constant I3C2_I3C_CR_MEND                                 \ Message end type / last message of a frame (when the I3C acts as controller)


\
\ @brief I3C message control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000ffff constant I3C2_I3C_CR_ALTERNATE_DCNT                       \ Count of related data to the CCC command to transfer as CCC defining bytes, or CCC sub-command bytes, or CCC data bytes, in bytes
$00ff0000 constant I3C2_I3C_CR_ALTERNATE_CCC                        \ 8-bit CCC code (when I3C acts as controller)
$78000000 constant I3C2_I3C_CR_ALTERNATE_MTYPE                      \ Message type (when I3C acts as controller)
$80000000 constant I3C2_I3C_CR_ALTERNATE_MEND                       \ Message end type / last message of a frame (when I3C acts as controller)


\
\ @brief I3C configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant I3C2_I3C_CFGR_EN                                 \ I3C enable (whatever I3C acts as controller/target)
$00000002 constant I3C2_I3C_CFGR_CRINIT                             \ Initial controller/target role
$00000004 constant I3C2_I3C_CFGR_NOARBH                             \ No arbitrable header after a start (when I3C acts as a controller)
$00000008 constant I3C2_I3C_CFGR_RSTPTRN                            \ HDR reset pattern enable (when I3C acts as a controller)
$00000010 constant I3C2_I3C_CFGR_EXITPTRN                           \ HDR exit pattern enable (when I3C acts as a controller)
$00000020 constant I3C2_I3C_CFGR_HKSDAEN                            \ High-keeper enable on SDA line (when I3C acts as a controller)
$00000080 constant I3C2_I3C_CFGR_HJACK                              \ Hot-join request acknowledge (when I3C acts as a controller)
$00000100 constant I3C2_I3C_CFGR_RXDMAEN                            \ RX-FIFO DMA request enable (whatever I3C acts as controller/target)
$00000200 constant I3C2_I3C_CFGR_RXFLUSH                            \ RX-FIFO flush (whatever I3C acts as controller/target)
$00000400 constant I3C2_I3C_CFGR_RXTHRES                            \ RX-FIFO threshold (whatever I3C acts as controller/target)
$00001000 constant I3C2_I3C_CFGR_TXDMAEN                            \ TX-FIFO DMA request enable (whatever I3C acts as controller/target)
$00002000 constant I3C2_I3C_CFGR_TXFLUSH                            \ TX-FIFO flush (whatever I3C acts as controller/target)
$00004000 constant I3C2_I3C_CFGR_TXTHRES                            \ TX-FIFO threshold (whatever I3C acts as controller/target)
$00010000 constant I3C2_I3C_CFGR_SDMAEN                             \ S-FIFO DMA request enable (when I3C acts as controller)
$00020000 constant I3C2_I3C_CFGR_SFLUSH                             \ S-FIFO flush (when I3C acts as controller)
$00040000 constant I3C2_I3C_CFGR_SMODE                              \ S-FIFO enable / status receive mode (when I3C acts as controller)
$00080000 constant I3C2_I3C_CFGR_TMODE                              \ Transmit mode (when I3C acts as controller)
$00100000 constant I3C2_I3C_CFGR_CDMAEN                             \ C-FIFO DMA request enable (when I3C acts as controller)
$00200000 constant I3C2_I3C_CFGR_CFLUSH                             \ C-FIFO flush (when I3C acts as controller)
$40000000 constant I3C2_I3C_CFGR_TSFSET                             \ Frame transfer set (software trigger) (when I3C acts as controller)


\
\ @brief I3C receive data byte register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant I3C2_I3C_RDR_RDB0                                \ 8-bit received data on I3C bus.


\
\ @brief I3C receive data word register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant I3C2_I3C_RDWR_RDB0                               \ 8-bit received data (earliest byte on I3C bus).
$0000ff00 constant I3C2_I3C_RDWR_RDB1                               \ 8-bit received data (next byte after RDB0 on I3C bus).
$00ff0000 constant I3C2_I3C_RDWR_RDB2                               \ 8-bit received data (next byte after RDB1 on I3C bus).
$ff000000 constant I3C2_I3C_RDWR_RDB3                               \ 8-bit received data (latest byte on I3C bus).


\
\ @brief I3C transmit data byte register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant I3C2_I3C_TDR_TDB0                                \ 8-bit data to transmit on I3C bus.


\
\ @brief I3C transmit data word register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000000ff constant I3C2_I3C_TDWR_TDB0                               \ 8-bit transmit data (earliest byte on I3C bus)
$0000ff00 constant I3C2_I3C_TDWR_TDB1                               \ 8-bit transmit data (next byte after TDB0[7:0] on I3C bus).
$00ff0000 constant I3C2_I3C_TDWR_TDB2                               \ 8-bit transmit data (next byte after TDB1[7:0] on I3C bus).
$ff000000 constant I3C2_I3C_TDWR_TDB3                               \ 8-bit transmit data (latest byte on I3C bus).


\
\ @brief I3C IBI payload data register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant I3C2_I3C_IBIDR_IBIDB0                            \ 8-bit IBI payload data (earliest byte on I3C bus, MDB[7:0] mandatory data byte).
$0000ff00 constant I3C2_I3C_IBIDR_IBIDB1                            \ 8-bit IBI payload data (next byte on I3C bus after IBIDB0[7:0]).
$00ff0000 constant I3C2_I3C_IBIDR_IBIDB2                            \ 8-bit IBI payload data (next byte on I3C bus after IBIDB1[7:0]).
$ff000000 constant I3C2_I3C_IBIDR_IBIDB3                            \ 8-bit IBI payload data (latest byte on I3C bus).


\
\ @brief I3C target transmit configuration register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant I3C2_I3C_TGTTDR_TGTTDCNT                         \ Transmit data counter, in bytes (when I3C is configured as target)
$00010000 constant I3C2_I3C_TGTTDR_PRELOAD                          \ Preload of the TX-FIFO (when I3C is configured as target)


\
\ @brief I3C status register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant I3C2_I3C_SR_XDCNT                                \ Data counter
$00020000 constant I3C2_I3C_SR_ABT                                  \ A private read message is ended prematurely by the target (when the I3C acts as controller)
$00040000 constant I3C2_I3C_SR_DIR                                  \ Message direction
$ff000000 constant I3C2_I3C_SR_MID                                  \ Message identifier/counter of a given frame (when the I3C acts as controller)


\
\ @brief I3C status error register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000000f constant I3C2_I3C_SER_CODERR                              \ Protocol error code/type
$00000010 constant I3C2_I3C_SER_PERR                                \ Protocol error
$00000020 constant I3C2_I3C_SER_STALL                               \ SCL stall error (when the I3C acts as target)
$00000040 constant I3C2_I3C_SER_DOVR                                \ RX-FIFO overrun or TX-FIFO underrun
$00000080 constant I3C2_I3C_SER_COVR                                \ C-FIFO underrun or S-FIFO overrun (when the I3C acts as controller)
$00000100 constant I3C2_I3C_SER_ANACK                               \ Address not acknowledged (when the I3C is configured as controller)
$00000200 constant I3C2_I3C_SER_DNACK                               \ Data not acknowledged (when the I3C acts as controller)
$00000400 constant I3C2_I3C_SER_DERR                                \ Data error (when the I3C acts as controller)


\
\ @brief I3C received message register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000007 constant I3C2_I3C_RMR_IBIRDCNT                            \ IBI received payload data count (when the I3C is configured as controller)
$0000ff00 constant I3C2_I3C_RMR_RCODE                               \ Received CCC code (when the I3C is configured as target)
$00fe0000 constant I3C2_I3C_RMR_RADD                                \ Received target address (when the I3C is configured as controller)


\
\ @brief I3C event register
\ Address offset: 0x50
\ Reset value: 0x00000003
\

$00000001 constant I3C2_I3C_EVR_CFEF                                \ C-FIFO empty flag (whatever the I3C acts as controller)
$00000002 constant I3C2_I3C_EVR_TXFEF                               \ TX-FIFO empty flag (whatever the I3C acts as controller/target)
$00000004 constant I3C2_I3C_EVR_CFNFF                               \ C-FIFO not full flag (when the I3C acts as controller)
$00000008 constant I3C2_I3C_EVR_SFNEF                               \ S-FIFO not empty flag (when the I3C acts as controller)
$00000010 constant I3C2_I3C_EVR_TXFNFF                              \ TX-FIFO not full flag (whatever the I3C acts as controller/target)
$00000020 constant I3C2_I3C_EVR_RXFNEF                              \ RX-FIFO not empty flag (whatever the I3C acts as controller/target)
$00000040 constant I3C2_I3C_EVR_TXLASTF                             \ Last written data byte/word flag (whatever the I3C acts as controller/target)
$00000080 constant I3C2_I3C_EVR_RXLASTF                             \ Last read data byte/word flag (when the I3C acts as controller)
$00000200 constant I3C2_I3C_EVR_FCF                                 \ Frame complete flag (whatever the I3C acts as controller/target)
$00000400 constant I3C2_I3C_EVR_RXTGTENDF                           \ Target-initiated read end flag (when the I3C acts as controller)
$00000800 constant I3C2_I3C_EVR_ERRF                                \ Flag (whatever the I3C acts as controller/target)
$00008000 constant I3C2_I3C_EVR_IBIF                                \ IBI flag (when the I3C acts as controller)
$00010000 constant I3C2_I3C_EVR_IBIENDF                             \ IBI end flag (when the I3C acts as target)
$00020000 constant I3C2_I3C_EVR_CRF                                 \ Controller-role request flag (when the I3C acts as controller)
$00040000 constant I3C2_I3C_EVR_CRUPDF                              \ Controller-role update flag (when the I3C acts as target)
$00080000 constant I3C2_I3C_EVR_HJF                                 \ Hot-join flag (when the I3C acts as controller)
$00200000 constant I3C2_I3C_EVR_WKPF                                \ Wake-up/missed start flag (when the I3C acts as target)
$00400000 constant I3C2_I3C_EVR_GETF                                \ Get flag (when the I3C acts as target)
$00800000 constant I3C2_I3C_EVR_STAF                                \ Get status flag (when the I3C acts as target)
$01000000 constant I3C2_I3C_EVR_DAUPDF                              \ Dynamic address update flag (when the I3C acts as target)
$02000000 constant I3C2_I3C_EVR_MWLUPDF                             \ Maximum write length update flag (when the I3C acts as target)
$04000000 constant I3C2_I3C_EVR_MRLUPDF                             \ Maximum read length update flag (when the I3C acts as target)
$08000000 constant I3C2_I3C_EVR_RSTF                                \ Reset pattern flag (when the I3C acts as target)
$10000000 constant I3C2_I3C_EVR_ASUPDF                              \ Activity state update flag (when the I3C acts as target)
$20000000 constant I3C2_I3C_EVR_INTUPDF                             \ Interrupt/controller-role/hot-join update flag (when the I3C acts as target)
$40000000 constant I3C2_I3C_EVR_DEFF                                \ DEFTGTS flag (when the I3C acts as target)
$80000000 constant I3C2_I3C_EVR_GRPF                                \ Group addressing flag (when the I3C acts as target)


\
\ @brief I3C interrupt enable register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000004 constant I3C2_I3C_IER_CFNFIE                              \ C-FIFO not full interrupt enable (whatever the I3C acts as controller/target)
$00000008 constant I3C2_I3C_IER_SFNEIE                              \ S-FIFO not empty interrupt enable (whatever the I3C acts as controller/target)
$00000010 constant I3C2_I3C_IER_TXFNFIE                             \ TX-FIFO not full interrupt enable (whatever the I3C acts as controller/target)
$00000020 constant I3C2_I3C_IER_RXFNEIE                             \ RX-FIFO not empty interrupt enable (whatever the I3C acts as controller/target)
$00000200 constant I3C2_I3C_IER_FCIE                                \ frame complete interrupt enable (whatever the I3C acts as controller/target)
$00000400 constant I3C2_I3C_IER_RXTGTENDIE                          \ target-initiated read end interrupt enable (when the I3C acts as controller)
$00000800 constant I3C2_I3C_IER_ERRIE                               \ error interrupt enable (whatever the I3C acts as controller/target)
$00008000 constant I3C2_I3C_IER_IBIIE                               \ IBI request interrupt enable (when the I3C acts as controller)
$00010000 constant I3C2_I3C_IER_IBIENDIE                            \ IBI end interrupt enable (when the I3C acts as target)
$00020000 constant I3C2_I3C_IER_CRIE                                \ Controller-role request interrupt enable (when the I3C acts as controller)
$00040000 constant I3C2_I3C_IER_CRUPDIE                             \ Controller-role update interrupt enable (when the I3C acts as target)
$00080000 constant I3C2_I3C_IER_HJIE                                \ Hot-join interrupt enable (when the I3C acts as controller)
$00200000 constant I3C2_I3C_IER_WKPIE                               \ Wake-up interrupt enable (when the I3C acts as target)
$00400000 constant I3C2_I3C_IER_GETIE                               \ GETxxx CCC interrupt enable (except GETSTATUS of format 1) (when the I3C acts as target)
$00800000 constant I3C2_I3C_IER_STAIE                               \ format 1 GETSTATUS CCC interrupt enable (when the I3C acts as target)
$01000000 constant I3C2_I3C_IER_DAUPDIE                             \ ENTDAA/RSTDAA/SETNEWDA CCC interrupt enable (when the I3C acts as target)
$02000000 constant I3C2_I3C_IER_MWLUPDIE                            \ SETMWL CCC interrupt enable (when the I3C acts as target)
$04000000 constant I3C2_I3C_IER_MRLUPDIE                            \ SETMRL CCC interrupt enable (when the I3C acts as target)
$08000000 constant I3C2_I3C_IER_RSTIE                               \ reset pattern interrupt enable (when the I3C acts as target)
$10000000 constant I3C2_I3C_IER_ASUPDIE                             \ ENTASx CCC interrupt enable (when the I3C acts as target)
$20000000 constant I3C2_I3C_IER_INTUPDIE                            \ ENEC/DISEC CCC interrupt enable (when the I3C acts as target)
$40000000 constant I3C2_I3C_IER_DEFIE                               \ DEFTGTS CCC interrupt enable (when the I3C acts as target)
$80000000 constant I3C2_I3C_IER_GRPIE                               \ DEFGRPA CCC interrupt enable (when the I3C acts as target)


\
\ @brief I3C clear event register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000200 constant I3C2_I3C_CEVR_CFCF                               \ Clear frame complete flag (whatever the I3C acts as controller/target)
$00000400 constant I3C2_I3C_CEVR_CRXTGTENDF                         \ Clear target-initiated read end flag (when the I3C acts as controller)
$00000800 constant I3C2_I3C_CEVR_CERRF                              \ Clear error flag (whatever the I3C acts as controller/target)
$00008000 constant I3C2_I3C_CEVR_CIBIF                              \ Clear IBI request flag (when the I3C acts as controller)
$00010000 constant I3C2_I3C_CEVR_CIBIENDF                           \ Clear IBI end flag (when the I3C acts as target)
$00020000 constant I3C2_I3C_CEVR_CCRF                               \ Clear controller-role request flag (when the I3C acts as controller)
$00040000 constant I3C2_I3C_CEVR_CCRUPDF                            \ Clear controller-role update flag (when the I3C acts as target)
$00080000 constant I3C2_I3C_CEVR_CHJF                               \ Clear hot-join flag (when the I3C acts as controller)
$00200000 constant I3C2_I3C_CEVR_CWKPF                              \ Clear wake-up flag (when the I3C acts as target)
$00400000 constant I3C2_I3C_CEVR_CGETF                              \ Clear GETxxx CCC flag (except GETSTATUS of format 1) (when the I3C acts as target)
$00800000 constant I3C2_I3C_CEVR_CSTAF                              \ Clear format 1 GETSTATUS CCC flag (when the I3C acts as target)
$01000000 constant I3C2_I3C_CEVR_CDAUPDF                            \ Clear ENTDAA/RSTDAA/SETNEWDA CCC flag (when the I3C acts as target)
$02000000 constant I3C2_I3C_CEVR_CMWLUPDF                           \ Clear SETMWL CCC flag (when the I3C acts as target)
$04000000 constant I3C2_I3C_CEVR_CMRLUPDF                           \ Clear SETMRL CCC flag (when the I3C acts as target)
$08000000 constant I3C2_I3C_CEVR_CRSTF                              \ Clear reset pattern flag (when the I3C acts as target)
$10000000 constant I3C2_I3C_CEVR_CASUPDF                            \ Clear ENTASx CCC flag (when the I3C acts as target)
$20000000 constant I3C2_I3C_CEVR_CINTUPDF                           \ Clear ENEC/DISEC CCC flag (when the I3C acts as target)
$40000000 constant I3C2_I3C_CEVR_CDEFF                              \ Clear DEFTGTS CCC flag (when the I3C acts as target)
$80000000 constant I3C2_I3C_CEVR_CGRPF                              \ Clear DEFGRPA CCC flag (when the I3C acts as target)


\
\ @brief I3C own device characteristics register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant I3C2_I3C_DEVR0_DAVAL                             \ Dynamic address is valid (when the I3C acts as target)
$000000fe constant I3C2_I3C_DEVR0_DA                                \ 7-bit dynamic address
$00010000 constant I3C2_I3C_DEVR0_IBIEN                             \ IBI request enable (when the I3C acts as target)
$00020000 constant I3C2_I3C_DEVR0_CREN                              \ Controller-role request enable (when the I3C acts as target)
$00080000 constant I3C2_I3C_DEVR0_HJEN                              \ Hot-join request enable (when the I3C acts as target)
$00300000 constant I3C2_I3C_DEVR0_AS                                \ Activity state (when the I3C acts as target)
$00c00000 constant I3C2_I3C_DEVR0_RSTACT                            \ Reset action/level on received reset pattern (when the I3C acts as target)
$01000000 constant I3C2_I3C_DEVR0_RSTVAL                            \ Reset action is valid (when the I3C acts as target)


\
\ @brief I3C device 1 characteristics register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$000000fe constant I3C2_I3C_DEVR1_DA                                \ Assigned I3C dynamic address to target x (when the I3C acts as controller)
$00010000 constant I3C2_I3C_DEVR1_IBIACK                            \ IBI request acknowledge (when the I3C acts as controller)
$00020000 constant I3C2_I3C_DEVR1_CRACK                             \ Controller-role request acknowledge (when the I3C acts as controller)
$00040000 constant I3C2_I3C_DEVR1_IBIDEN                            \ IBI data enable (when the I3C acts as controller)
$00080000 constant I3C2_I3C_DEVR1_SUSP                              \ Suspend/stop I3C transfer on received IBI (when the I3C acts as controller)
$80000000 constant I3C2_I3C_DEVR1_DIS                               \ DA[6:0] write disabled (when the I3C acts as controller)


\
\ @brief I3C device 2 characteristics register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$000000fe constant I3C2_I3C_DEVR2_DA                                \ Assigned I3C dynamic address to target x (when the I3C acts as controller)
$00010000 constant I3C2_I3C_DEVR2_IBIACK                            \ IBI request acknowledge (when the I3C acts as controller)
$00020000 constant I3C2_I3C_DEVR2_CRACK                             \ Controller-role request acknowledge (when the I3C acts as controller)
$00040000 constant I3C2_I3C_DEVR2_IBIDEN                            \ IBI data enable (when the I3C acts as controller)
$00080000 constant I3C2_I3C_DEVR2_SUSP                              \ Suspend/stop I3C transfer on received IBI (when the I3C acts as controller)
$80000000 constant I3C2_I3C_DEVR2_DIS                               \ DA[6:0] write disabled (when the I3C acts as controller)


\
\ @brief I3C device 3 characteristics register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$000000fe constant I3C2_I3C_DEVR3_DA                                \ Assigned I3C dynamic address to target x (when the I3C acts as controller)
$00010000 constant I3C2_I3C_DEVR3_IBIACK                            \ IBI request acknowledge (when the I3C acts as controller)
$00020000 constant I3C2_I3C_DEVR3_CRACK                             \ Controller-role request acknowledge (when the I3C acts as controller)
$00040000 constant I3C2_I3C_DEVR3_IBIDEN                            \ IBI data enable (when the I3C acts as controller)
$00080000 constant I3C2_I3C_DEVR3_SUSP                              \ Suspend/stop I3C transfer on received IBI (when the I3C acts as controller)
$80000000 constant I3C2_I3C_DEVR3_DIS                               \ DA[6:0] write disabled (when the I3C acts as controller)


\
\ @brief I3C device 4 characteristics register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$000000fe constant I3C2_I3C_DEVR4_DA                                \ Assigned I3C dynamic address to target x (when the I3C acts as controller)
$00010000 constant I3C2_I3C_DEVR4_IBIACK                            \ IBI request acknowledge (when the I3C acts as controller)
$00020000 constant I3C2_I3C_DEVR4_CRACK                             \ Controller-role request acknowledge (when the I3C acts as controller)
$00040000 constant I3C2_I3C_DEVR4_IBIDEN                            \ IBI data enable (when the I3C acts as controller)
$00080000 constant I3C2_I3C_DEVR4_SUSP                              \ Suspend/stop I3C transfer on received IBI (when the I3C acts as controller)
$80000000 constant I3C2_I3C_DEVR4_DIS                               \ DA[6:0] write disabled (when the I3C acts as controller)


\
\ @brief I3C maximum read length register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$0000ffff constant I3C2_I3C_MAXRLR_MRL                              \ Maximum data read length (when I3C acts as target)
$00070000 constant I3C2_I3C_MAXRLR_IBIP                             \ IBI payload data maximum size, in bytes (when I3C acts as target)


\
\ @brief I3C maximum write length register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$0000ffff constant I3C2_I3C_MAXWLR_MWL                              \ Maximum data write length (when I3C acts as target)


\
\ @brief I3C timing register 0
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$000000ff constant I3C2_I3C_TIMINGR0_SCLL_PP                        \ SCL low duration in I3C push-pull phases, in number of kernel clocks cycles:
$0000ff00 constant I3C2_I3C_TIMINGR0_SCLH_I3C                       \ SCL high duration, used for I3C messages (both in push-pull and open-drain phases), in number of kernel clocks cycles:
$00ff0000 constant I3C2_I3C_TIMINGR0_SCLL_OD                        \ SCL low duration in open-drain phases, used for legacy Iless thansup>2less than/sup>C messages and for I3C open-drain phases (address phase following a start, ACK phase during controller-initiated messages, and T bit phase during direct/private/IBI payload), in number of kernel clocks cycles:
$ff000000 constant I3C2_I3C_TIMINGR0_SCLH_I2C                       \ SCL high duration, used for legacy Iless thansup>2less than/sup>C messages, in number of kernel clocks cycles:


\
\ @brief I3C timing register 1
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$000000ff constant I3C2_I3C_TIMINGR1_AVAL                           \ Number of kernel clock cycles to set a time unit of 1 s, whatever I3C acts as controller or target.
$00000300 constant I3C2_I3C_TIMINGR1_ASNCR                          \ Activity state of the new controller (when I3C acts as active controller)
$007f0000 constant I3C2_I3C_TIMINGR1_FREE                           \ Number of kernel clocks cycles that is used to set some MIPI timings like bus free condition time (when the I3C acts as controller)
$10000000 constant I3C2_I3C_TIMINGR1_SDA_HD                         \ SDA hold time (when the I3C acts as controller), in number of kernel clocks cycles (refer to MIPI timing SDA hold time in push-pull tless thansub>HD_PPless than/sub>):


\
\ @brief I3C timing register 2
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000001 constant I3C2_I3C_TIMINGR2_STALLT                         \ Controller clock stall enable on T-bit phase of data (and on the ACK/NACK phase of data byte of a legacy Iless thansup>2less than/sup>C read)
$00000002 constant I3C2_I3C_TIMINGR2_STALLD                         \ Controller clock stall enable on PAR phase of Data
$00000004 constant I3C2_I3C_TIMINGR2_STALLC                         \ Controller clock stall enable on PAR phase of CCC
$00000008 constant I3C2_I3C_TIMINGR2_STALLA                         \ Controller clock stall enable on ACK phase
$0000ff00 constant I3C2_I3C_TIMINGR2_STALL                          \ Controller clock stall time, in number of kernel clock cycles


\
\ @brief I3C bus characteristics register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant I3C2_I3C_BCR_BCR0                                \ max data speed limitation
$00000004 constant I3C2_I3C_BCR_BCR2                                \ in-band interrupt (IBI) payload
$00000040 constant I3C2_I3C_BCR_BCR6                                \ Controller capable


\
\ @brief I3C device characteristics register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$000000ff constant I3C2_I3C_DCR_DCR                                 \ device characteristics ID


\
\ @brief I3C get capability register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00004000 constant I3C2_I3C_GETCAPR_CAPPEND                         \ IBI MDB support for pending read notification


\
\ @brief I3C controller-role capability register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000008 constant I3C2_I3C_CRCAPR_CAPDHOFF                         \ delayed controller-role hand-off
$00000200 constant I3C2_I3C_CRCAPR_CAPGRP                           \ group management support (when acting as controller)


\
\ @brief I3C get capability register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000003 constant I3C2_I3C_GETMXDSR_HOFFAS                         \ Controller hand-off activity state
$00000300 constant I3C2_I3C_GETMXDSR_FMT                            \ GETMXDS CCC format
$00ff0000 constant I3C2_I3C_GETMXDSR_RDTURN                         \ programmed byte of the 3-byte MaxRdTurn (maximum read turnaround byte)
$01000000 constant I3C2_I3C_GETMXDSR_TSCO                           \ clock-to-data turnaround time (tless thansub>SCOless than/sub>)


\
\ @brief I3C extended provisioned ID register
\ Address offset: 0xD4
\ Reset value: 0x02080000
\

$0000f000 constant I3C2_I3C_EPIDR_MIPIID                            \ 4-bit MIPI Instance ID
$00010000 constant I3C2_I3C_EPIDR_IDTSEL                            \ provisioned ID type selector
$fffe0000 constant I3C2_I3C_EPIDR_MIPIMID                           \ 15-bit MIPI manufacturer ID


\
\ @brief I3C2 event interrupt
\
$40006400 constant I3C2_I3C_CR    \ offset: 0x00 : I3C message control register
$40006400 constant I3C2_I3C_CR_ALTERNATE  \ offset: 0x00 : I3C message control register
$40006404 constant I3C2_I3C_CFGR  \ offset: 0x04 : I3C configuration register
$40006410 constant I3C2_I3C_RDR   \ offset: 0x10 : I3C receive data byte register
$40006414 constant I3C2_I3C_RDWR  \ offset: 0x14 : I3C receive data word register
$40006418 constant I3C2_I3C_TDR   \ offset: 0x18 : I3C transmit data byte register
$4000641c constant I3C2_I3C_TDWR  \ offset: 0x1C : I3C transmit data word register
$40006420 constant I3C2_I3C_IBIDR  \ offset: 0x20 : I3C IBI payload data register
$40006424 constant I3C2_I3C_TGTTDR  \ offset: 0x24 : I3C target transmit configuration register
$40006430 constant I3C2_I3C_SR    \ offset: 0x30 : I3C status register
$40006434 constant I3C2_I3C_SER   \ offset: 0x34 : I3C status error register
$40006440 constant I3C2_I3C_RMR   \ offset: 0x40 : I3C received message register
$40006450 constant I3C2_I3C_EVR   \ offset: 0x50 : I3C event register
$40006454 constant I3C2_I3C_IER   \ offset: 0x54 : I3C interrupt enable register
$40006458 constant I3C2_I3C_CEVR  \ offset: 0x58 : I3C clear event register
$40006460 constant I3C2_I3C_DEVR0  \ offset: 0x60 : I3C own device characteristics register
$40006464 constant I3C2_I3C_DEVR1  \ offset: 0x64 : I3C device 1 characteristics register
$40006468 constant I3C2_I3C_DEVR2  \ offset: 0x68 : I3C device 2 characteristics register
$4000646c constant I3C2_I3C_DEVR3  \ offset: 0x6C : I3C device 3 characteristics register
$40006470 constant I3C2_I3C_DEVR4  \ offset: 0x70 : I3C device 4 characteristics register
$40006490 constant I3C2_I3C_MAXRLR  \ offset: 0x90 : I3C maximum read length register
$40006494 constant I3C2_I3C_MAXWLR  \ offset: 0x94 : I3C maximum write length register
$400064a0 constant I3C2_I3C_TIMINGR0  \ offset: 0xA0 : I3C timing register 0
$400064a4 constant I3C2_I3C_TIMINGR1  \ offset: 0xA4 : I3C timing register 1
$400064a8 constant I3C2_I3C_TIMINGR2  \ offset: 0xA8 : I3C timing register 2
$400064c0 constant I3C2_I3C_BCR   \ offset: 0xC0 : I3C bus characteristics register
$400064c4 constant I3C2_I3C_DCR   \ offset: 0xC4 : I3C device characteristics register
$400064c8 constant I3C2_I3C_GETCAPR  \ offset: 0xC8 : I3C get capability register
$400064cc constant I3C2_I3C_CRCAPR  \ offset: 0xCC : I3C controller-role capability register
$400064d0 constant I3C2_I3C_GETMXDSR  \ offset: 0xD0 : I3C get capability register
$400064d4 constant I3C2_I3C_EPIDR  \ offset: 0xD4 : I3C extended provisioned ID register

