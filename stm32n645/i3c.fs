\
\ @file i3c.fs
\ @brief Improved inter-integrated circuit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] I3C_DEF

  [ifdef] I3C_I3C_CR_DEF
    \
    \ @brief I3C message control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant I3C_DCNT                       \ [0x00 : 16] Count of data to transfer during a read or write message, in bytes (whatever I3C acts as controller/target)
    $10 constant I3C_RNW                        \ [0x10] Read / non-write message (when I3C acts as controller)
    $11 constant I3C_ADD                        \ [0x11 : 7] 7-bit I3C dynamic / I less than sup>2 less than /sup>C static target address (when I3C acts as controller)
    $1b constant I3C_MTYPE                      \ [0x1b : 4] Message type (whatever I3C acts as controller/target)
    $1f constant I3C_MEND                       \ [0x1f] Message end type / last message of a frame (when the I3C acts as controller)
  [then]


  [ifdef] I3C_I3C_CR_alternate_DEF
    \
    \ @brief I3C message control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant I3C_DCNT                       \ [0x00 : 16] Count of related data to the CCC command to transfer as CCC defining bytes, or CCC sub-command bytes, or CCC data bytes, in bytes
    $10 constant I3C_CCC                        \ [0x10 : 8] 8-bit CCC code (when I3C acts as controller)
    $1b constant I3C_MTYPE                      \ [0x1b : 4] Message type (when I3C acts as controller)
    $1f constant I3C_MEND                       \ [0x1f] Message end type / last message of a frame (when I3C acts as controller)
  [then]


  [ifdef] I3C_I3C_CFGR_DEF
    \
    \ @brief I3C configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant I3C_EN                         \ [0x00] I3C enable (whatever I3C acts as controller/target)
    $01 constant I3C_CRINIT                     \ [0x01] Initial controller/target role
    $02 constant I3C_NOARBH                     \ [0x02] No arbitrable header after a start (when I3C acts as a controller)
    $03 constant I3C_RSTPTRN                    \ [0x03] HDR reset pattern enable (when I3C acts as a controller)
    $04 constant I3C_EXITPTRN                   \ [0x04] HDR exit pattern enable (when I3C acts as a controller)
    $05 constant I3C_HKSDAEN                    \ [0x05] High-keeper enable on SDA line (when I3C acts as a controller)
    $07 constant I3C_HJACK                      \ [0x07] Hot-join request acknowledge (when I3C acts as a controller)
    $08 constant I3C_RXDMAEN                    \ [0x08] RX-FIFO DMA request enable (whatever I3C acts as controller/target)
    $09 constant I3C_RXFLUSH                    \ [0x09] RX-FIFO flush (whatever I3C acts as controller/target)
    $0a constant I3C_RXTHRES                    \ [0x0a] RX-FIFO threshold (whatever I3C acts as controller/target)
    $0c constant I3C_TXDMAEN                    \ [0x0c] TX-FIFO DMA request enable (whatever I3C acts as controller/target)
    $0d constant I3C_TXFLUSH                    \ [0x0d] TX-FIFO flush (whatever I3C acts as controller/target)
    $0e constant I3C_TXTHRES                    \ [0x0e] TX-FIFO threshold (whatever I3C acts as controller/target)
    $10 constant I3C_SDMAEN                     \ [0x10] S-FIFO DMA request enable (when I3C acts as controller)
    $11 constant I3C_SFLUSH                     \ [0x11] S-FIFO flush (when I3C acts as controller)
    $12 constant I3C_SMODE                      \ [0x12] S-FIFO enable / status receive mode (when I3C acts as controller)
    $13 constant I3C_TMODE                      \ [0x13] Transmit mode (when I3C acts as controller)
    $14 constant I3C_CDMAEN                     \ [0x14] C-FIFO DMA request enable (when I3C acts as controller)
    $15 constant I3C_CFLUSH                     \ [0x15] C-FIFO flush (when I3C acts as controller)
    $1e constant I3C_TSFSET                     \ [0x1e] Frame transfer set (software trigger) (when I3C acts as controller)
  [then]


  [ifdef] I3C_I3C_RDR_DEF
    \
    \ @brief I3C receive data byte register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant I3C_RDB0                       \ [0x00 : 8] 8-bit received data on I3C bus.
  [then]


  [ifdef] I3C_I3C_RDWR_DEF
    \
    \ @brief I3C receive data word register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant I3C_RDB0                       \ [0x00 : 8] 8-bit received data (earliest byte on I3C bus).
    $08 constant I3C_RDB1                       \ [0x08 : 8] 8-bit received data (next byte after RDB0 on I3C bus).
    $10 constant I3C_RDB2                       \ [0x10 : 8] 8-bit received data (next byte after RDB1 on I3C bus).
    $18 constant I3C_RDB3                       \ [0x18 : 8] 8-bit received data (latest byte on I3C bus).
  [then]


  [ifdef] I3C_I3C_TDR_DEF
    \
    \ @brief I3C transmit data byte register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant I3C_TDB0                       \ [0x00 : 8] 8-bit data to transmit on I3C bus.
  [then]


  [ifdef] I3C_I3C_TDWR_DEF
    \
    \ @brief I3C transmit data word register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant I3C_TDB0                       \ [0x00 : 8] 8-bit transmit data (earliest byte on I3C bus)
    $08 constant I3C_TDB1                       \ [0x08 : 8] 8-bit transmit data (next byte after TDB0[7:0] on I3C bus).
    $10 constant I3C_TDB2                       \ [0x10 : 8] 8-bit transmit data (next byte after TDB1[7:0] on I3C bus).
    $18 constant I3C_TDB3                       \ [0x18 : 8] 8-bit transmit data (latest byte on I3C bus).
  [then]


  [ifdef] I3C_I3C_IBIDR_DEF
    \
    \ @brief I3C IBI payload data register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant I3C_IBIDB0                     \ [0x00 : 8] 8-bit IBI payload data (earliest byte on I3C bus, MDB[7:0] mandatory data byte).
    $08 constant I3C_IBIDB1                     \ [0x08 : 8] 8-bit IBI payload data (next byte on I3C bus after IBIDB0[7:0]).
    $10 constant I3C_IBIDB2                     \ [0x10 : 8] 8-bit IBI payload data (next byte on I3C bus after IBIDB1[7:0]).
    $18 constant I3C_IBIDB3                     \ [0x18 : 8] 8-bit IBI payload data (latest byte on I3C bus).
  [then]


  [ifdef] I3C_I3C_TGTTDR_DEF
    \
    \ @brief I3C target transmit configuration register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant I3C_TGTTDCNT                   \ [0x00 : 16] Transmit data counter, in bytes (when I3C is configured as target)
    $10 constant I3C_PRELOAD                    \ [0x10] Preload of the TX-FIFO (when I3C is configured as target)
  [then]


  [ifdef] I3C_I3C_SR_DEF
    \
    \ @brief I3C status register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant I3C_XDCNT                      \ [0x00 : 16] Data counter
    $11 constant I3C_ABT                        \ [0x11] A private read message is ended prematurely by the target (when the I3C acts as controller)
    $12 constant I3C_DIR                        \ [0x12] Message direction
    $18 constant I3C_MID                        \ [0x18 : 8] Message identifier/counter of a given frame (when the I3C acts as controller)
  [then]


  [ifdef] I3C_I3C_SER_DEF
    \
    \ @brief I3C status error register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant I3C_CODERR                     \ [0x00 : 4] Protocol error code/type
    $04 constant I3C_PERR                       \ [0x04] Protocol error
    $05 constant I3C_STALL                      \ [0x05] SCL stall error (when the I3C acts as target)
    $06 constant I3C_DOVR                       \ [0x06] RX-FIFO overrun or TX-FIFO underrun
    $07 constant I3C_COVR                       \ [0x07] C-FIFO underrun or S-FIFO overrun (when the I3C acts as controller)
    $08 constant I3C_ANACK                      \ [0x08] Address not acknowledged (when the I3C is configured as controller)
    $09 constant I3C_DNACK                      \ [0x09] Data not acknowledged (when the I3C acts as controller)
    $0a constant I3C_DERR                       \ [0x0a] Data error (when the I3C acts as controller)
  [then]


  [ifdef] I3C_I3C_RMR_DEF
    \
    \ @brief I3C received message register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant I3C_IBIRDCNT                   \ [0x00 : 3] IBI received payload data count (when the I3C is configured as controller)
    $08 constant I3C_RCODE                      \ [0x08 : 8] Received CCC code (when the I3C is configured as target)
    $11 constant I3C_RADD                       \ [0x11 : 7] Received target address (when the I3C is configured as controller)
  [then]


  [ifdef] I3C_I3C_EVR_DEF
    \
    \ @brief I3C event register
    \ Address offset: 0x50
    \ Reset value: 0x00000003
    \
    $00 constant I3C_CFEF                       \ [0x00] C-FIFO empty flag (whatever the I3C acts as controller)
    $01 constant I3C_TXFEF                      \ [0x01] TX-FIFO empty flag (whatever the I3C acts as controller/target)
    $02 constant I3C_CFNFF                      \ [0x02] C-FIFO not full flag (when the I3C acts as controller)
    $03 constant I3C_SFNEF                      \ [0x03] S-FIFO not empty flag (when the I3C acts as controller)
    $04 constant I3C_TXFNFF                     \ [0x04] TX-FIFO not full flag (whatever the I3C acts as controller/target)
    $05 constant I3C_RXFNEF                     \ [0x05] RX-FIFO not empty flag (whatever the I3C acts as controller/target)
    $06 constant I3C_TXLASTF                    \ [0x06] Last written data byte/word flag (whatever the I3C acts as controller/target)
    $07 constant I3C_RXLASTF                    \ [0x07] Last read data byte/word flag (when the I3C acts as controller)
    $09 constant I3C_FCF                        \ [0x09] Frame complete flag (whatever the I3C acts as controller/target)
    $0a constant I3C_RXTGTENDF                  \ [0x0a] Target-initiated read end flag (when the I3C acts as controller)
    $0b constant I3C_ERRF                       \ [0x0b] Flag (whatever the I3C acts as controller/target)
    $0f constant I3C_IBIF                       \ [0x0f] IBI flag (when the I3C acts as controller)
    $10 constant I3C_IBIENDF                    \ [0x10] IBI end flag (when the I3C acts as target)
    $11 constant I3C_CRF                        \ [0x11] Controller-role request flag (when the I3C acts as controller)
    $12 constant I3C_CRUPDF                     \ [0x12] Controller-role update flag (when the I3C acts as target)
    $13 constant I3C_HJF                        \ [0x13] Hot-join flag (when the I3C acts as controller)
    $15 constant I3C_WKPF                       \ [0x15] Wake-up/missed start flag (when the I3C acts as target)
    $16 constant I3C_GETF                       \ [0x16] Get flag (when the I3C acts as target)
    $17 constant I3C_STAF                       \ [0x17] Get status flag (when the I3C acts as target)
    $18 constant I3C_DAUPDF                     \ [0x18] Dynamic address update flag (when the I3C acts as target)
    $19 constant I3C_MWLUPDF                    \ [0x19] Maximum write length update flag (when the I3C acts as target)
    $1a constant I3C_MRLUPDF                    \ [0x1a] Maximum read length update flag (when the I3C acts as target)
    $1b constant I3C_RSTF                       \ [0x1b] Reset pattern flag (when the I3C acts as target)
    $1c constant I3C_ASUPDF                     \ [0x1c] Activity state update flag (when the I3C acts as target)
    $1d constant I3C_INTUPDF                    \ [0x1d] Interrupt/controller-role/hot-join update flag (when the I3C acts as target)
    $1e constant I3C_DEFF                       \ [0x1e] DEFTGTS flag (when the I3C acts as target)
    $1f constant I3C_GRPF                       \ [0x1f] Group addressing flag (when the I3C acts as target)
  [then]


  [ifdef] I3C_I3C_IER_DEF
    \
    \ @brief I3C interrupt enable register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $02 constant I3C_CFNFIE                     \ [0x02] C-FIFO not full interrupt enable (whatever the I3C acts as controller/target)
    $03 constant I3C_SFNEIE                     \ [0x03] S-FIFO not empty interrupt enable (whatever the I3C acts as controller/target)
    $04 constant I3C_TXFNFIE                    \ [0x04] TX-FIFO not full interrupt enable (whatever the I3C acts as controller/target)
    $05 constant I3C_RXFNEIE                    \ [0x05] RX-FIFO not empty interrupt enable (whatever the I3C acts as controller/target)
    $09 constant I3C_FCIE                       \ [0x09] frame complete interrupt enable (whatever the I3C acts as controller/target)
    $0a constant I3C_RXTGTENDIE                 \ [0x0a] target-initiated read end interrupt enable (when the I3C acts as controller)
    $0b constant I3C_ERRIE                      \ [0x0b] error interrupt enable (whatever the I3C acts as controller/target)
    $0f constant I3C_IBIIE                      \ [0x0f] IBI request interrupt enable (when the I3C acts as controller)
    $10 constant I3C_IBIENDIE                   \ [0x10] IBI end interrupt enable (when the I3C acts as target)
    $11 constant I3C_CRIE                       \ [0x11] Controller-role request interrupt enable (when the I3C acts as controller)
    $12 constant I3C_CRUPDIE                    \ [0x12] Controller-role update interrupt enable (when the I3C acts as target)
    $13 constant I3C_HJIE                       \ [0x13] Hot-join interrupt enable (when the I3C acts as controller)
    $15 constant I3C_WKPIE                      \ [0x15] Wake-up interrupt enable (when the I3C acts as target)
    $16 constant I3C_GETIE                      \ [0x16] GETxxx CCC interrupt enable (except GETSTATUS of format 1) (when the I3C acts as target)
    $17 constant I3C_STAIE                      \ [0x17] format 1 GETSTATUS CCC interrupt enable (when the I3C acts as target)
    $18 constant I3C_DAUPDIE                    \ [0x18] ENTDAA/RSTDAA/SETNEWDA CCC interrupt enable (when the I3C acts as target)
    $19 constant I3C_MWLUPDIE                   \ [0x19] SETMWL CCC interrupt enable (when the I3C acts as target)
    $1a constant I3C_MRLUPDIE                   \ [0x1a] SETMRL CCC interrupt enable (when the I3C acts as target)
    $1b constant I3C_RSTIE                      \ [0x1b] reset pattern interrupt enable (when the I3C acts as target)
    $1c constant I3C_ASUPDIE                    \ [0x1c] ENTASx CCC interrupt enable (when the I3C acts as target)
    $1d constant I3C_INTUPDIE                   \ [0x1d] ENEC/DISEC CCC interrupt enable (when the I3C acts as target)
    $1e constant I3C_DEFIE                      \ [0x1e] DEFTGTS CCC interrupt enable (when the I3C acts as target)
    $1f constant I3C_GRPIE                      \ [0x1f] DEFGRPA CCC interrupt enable (when the I3C acts as target)
  [then]


  [ifdef] I3C_I3C_CEVR_DEF
    \
    \ @brief I3C clear event register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $09 constant I3C_CFCF                       \ [0x09] Clear frame complete flag (whatever the I3C acts as controller/target)
    $0a constant I3C_CRXTGTENDF                 \ [0x0a] Clear target-initiated read end flag (when the I3C acts as controller)
    $0b constant I3C_CERRF                      \ [0x0b] Clear error flag (whatever the I3C acts as controller/target)
    $0f constant I3C_CIBIF                      \ [0x0f] Clear IBI request flag (when the I3C acts as controller)
    $10 constant I3C_CIBIENDF                   \ [0x10] Clear IBI end flag (when the I3C acts as target)
    $11 constant I3C_CCRF                       \ [0x11] Clear controller-role request flag (when the I3C acts as controller)
    $12 constant I3C_CCRUPDF                    \ [0x12] Clear controller-role update flag (when the I3C acts as target)
    $13 constant I3C_CHJF                       \ [0x13] Clear hot-join flag (when the I3C acts as controller)
    $15 constant I3C_CWKPF                      \ [0x15] Clear wake-up flag (when the I3C acts as target)
    $16 constant I3C_CGETF                      \ [0x16] Clear GETxxx CCC flag (except GETSTATUS of format 1) (when the I3C acts as target)
    $17 constant I3C_CSTAF                      \ [0x17] Clear format 1 GETSTATUS CCC flag (when the I3C acts as target)
    $18 constant I3C_CDAUPDF                    \ [0x18] Clear ENTDAA/RSTDAA/SETNEWDA CCC flag (when the I3C acts as target)
    $19 constant I3C_CMWLUPDF                   \ [0x19] Clear SETMWL CCC flag (when the I3C acts as target)
    $1a constant I3C_CMRLUPDF                   \ [0x1a] Clear SETMRL CCC flag (when the I3C acts as target)
    $1b constant I3C_CRSTF                      \ [0x1b] Clear reset pattern flag (when the I3C acts as target)
    $1c constant I3C_CASUPDF                    \ [0x1c] Clear ENTASx CCC flag (when the I3C acts as target)
    $1d constant I3C_CINTUPDF                   \ [0x1d] Clear ENEC/DISEC CCC flag (when the I3C acts as target)
    $1e constant I3C_CDEFF                      \ [0x1e] Clear DEFTGTS CCC flag (when the I3C acts as target)
    $1f constant I3C_CGRPF                      \ [0x1f] Clear DEFGRPA CCC flag (when the I3C acts as target)
  [then]


  [ifdef] I3C_I3C_DEVR0_DEF
    \
    \ @brief I3C own device characteristics register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant I3C_DAVAL                      \ [0x00] Dynamic address is valid (when the I3C acts as target)
    $01 constant I3C_DA                         \ [0x01 : 7] 7-bit dynamic address
    $10 constant I3C_IBIEN                      \ [0x10] IBI request enable (when the I3C acts as target)
    $11 constant I3C_CREN                       \ [0x11] Controller-role request enable (when the I3C acts as target)
    $13 constant I3C_HJEN                       \ [0x13] Hot-join request enable (when the I3C acts as target)
    $14 constant I3C_AS                         \ [0x14 : 2] Activity state (when the I3C acts as target)
    $16 constant I3C_RSTACT                     \ [0x16 : 2] Reset action/level on received reset pattern (when the I3C acts as target)
    $18 constant I3C_RSTVAL                     \ [0x18] Reset action is valid (when the I3C acts as target)
  [then]


  [ifdef] I3C_I3C_DEVR1_DEF
    \
    \ @brief I3C device 1 characteristics register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $01 constant I3C_DA                         \ [0x01 : 7] Assigned I3C dynamic address to target x (when the I3C acts as controller)
    $10 constant I3C_IBIACK                     \ [0x10] IBI request acknowledge (when the I3C acts as controller)
    $11 constant I3C_CRACK                      \ [0x11] Controller-role request acknowledge (when the I3C acts as controller)
    $12 constant I3C_IBIDEN                     \ [0x12] IBI data enable (when the I3C acts as controller)
    $13 constant I3C_SUSP                       \ [0x13] Suspend/stop I3C transfer on received IBI (when the I3C acts as controller)
    $1f constant I3C_DIS                        \ [0x1f] DA[6:0] write disabled (when the I3C acts as controller)
  [then]


  [ifdef] I3C_I3C_DEVR2_DEF
    \
    \ @brief I3C device 2 characteristics register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $01 constant I3C_DA                         \ [0x01 : 7] Assigned I3C dynamic address to target x (when the I3C acts as controller)
    $10 constant I3C_IBIACK                     \ [0x10] IBI request acknowledge (when the I3C acts as controller)
    $11 constant I3C_CRACK                      \ [0x11] Controller-role request acknowledge (when the I3C acts as controller)
    $12 constant I3C_IBIDEN                     \ [0x12] IBI data enable (when the I3C acts as controller)
    $13 constant I3C_SUSP                       \ [0x13] Suspend/stop I3C transfer on received IBI (when the I3C acts as controller)
    $1f constant I3C_DIS                        \ [0x1f] DA[6:0] write disabled (when the I3C acts as controller)
  [then]


  [ifdef] I3C_I3C_DEVR3_DEF
    \
    \ @brief I3C device 3 characteristics register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $01 constant I3C_DA                         \ [0x01 : 7] Assigned I3C dynamic address to target x (when the I3C acts as controller)
    $10 constant I3C_IBIACK                     \ [0x10] IBI request acknowledge (when the I3C acts as controller)
    $11 constant I3C_CRACK                      \ [0x11] Controller-role request acknowledge (when the I3C acts as controller)
    $12 constant I3C_IBIDEN                     \ [0x12] IBI data enable (when the I3C acts as controller)
    $13 constant I3C_SUSP                       \ [0x13] Suspend/stop I3C transfer on received IBI (when the I3C acts as controller)
    $1f constant I3C_DIS                        \ [0x1f] DA[6:0] write disabled (when the I3C acts as controller)
  [then]


  [ifdef] I3C_I3C_DEVR4_DEF
    \
    \ @brief I3C device 4 characteristics register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $01 constant I3C_DA                         \ [0x01 : 7] Assigned I3C dynamic address to target x (when the I3C acts as controller)
    $10 constant I3C_IBIACK                     \ [0x10] IBI request acknowledge (when the I3C acts as controller)
    $11 constant I3C_CRACK                      \ [0x11] Controller-role request acknowledge (when the I3C acts as controller)
    $12 constant I3C_IBIDEN                     \ [0x12] IBI data enable (when the I3C acts as controller)
    $13 constant I3C_SUSP                       \ [0x13] Suspend/stop I3C transfer on received IBI (when the I3C acts as controller)
    $1f constant I3C_DIS                        \ [0x1f] DA[6:0] write disabled (when the I3C acts as controller)
  [then]


  [ifdef] I3C_I3C_MAXRLR_DEF
    \
    \ @brief I3C maximum read length register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant I3C_MRL                        \ [0x00 : 16] Maximum data read length (when I3C acts as target)
    $10 constant I3C_IBIP                       \ [0x10 : 3] IBI payload data maximum size, in bytes (when I3C acts as target)
  [then]


  [ifdef] I3C_I3C_MAXWLR_DEF
    \
    \ @brief I3C maximum write length register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant I3C_MWL                        \ [0x00 : 16] Maximum data write length (when I3C acts as target)
  [then]


  [ifdef] I3C_I3C_TIMINGR0_DEF
    \
    \ @brief I3C timing register 0
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant I3C_SCLL_PP                    \ [0x00 : 8] SCL low duration in I3C push-pull phases, in number of kernel clocks cycles:
    $08 constant I3C_SCLH_I3C                   \ [0x08 : 8] SCL high duration, used for I3C messages (both in push-pull and open-drain phases), in number of kernel clocks cycles:
    $10 constant I3C_SCLL_OD                    \ [0x10 : 8] SCL low duration in open-drain phases, used for legacy I less than sup>2 less than /sup>C messages and for I3C open-drain phases (address phase following a start, ACK phase during controller-initiated messages, and T bit phase during direct/private/IBI payload), in number of kernel clocks cycles:
    $18 constant I3C_SCLH_I2C                   \ [0x18 : 8] SCL high duration, used for legacy I less than sup>2 less than /sup>C messages, in number of kernel clocks cycles:
  [then]


  [ifdef] I3C_I3C_TIMINGR1_DEF
    \
    \ @brief I3C timing register 1
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant I3C_AVAL                       \ [0x00 : 8] Number of kernel clock cycles to set a time unit of 1 s, whatever I3C acts as controller or target.
    $08 constant I3C_ASNCR                      \ [0x08 : 2] Activity state of the new controller (when I3C acts as active controller)
    $10 constant I3C_FREE                       \ [0x10 : 7] Number of kernel clocks cycles that is used to set some MIPI timings like bus free condition time (when the I3C acts as controller)
    $1c constant I3C_SDA_HD                     \ [0x1c] SDA hold time (when the I3C acts as controller), in number of kernel clocks cycles (refer to MIPI timing SDA hold time in push-pull t less than sub>HD_PP less than /sub>):
  [then]


  [ifdef] I3C_I3C_TIMINGR2_DEF
    \
    \ @brief I3C timing register 2
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant I3C_STALLT                     \ [0x00] Controller clock stall enable on T-bit phase of data (and on the ACK/NACK phase of data byte of a legacy I less than sup>2 less than /sup>C read)
    $01 constant I3C_STALLD                     \ [0x01] Controller clock stall enable on PAR phase of Data
    $02 constant I3C_STALLC                     \ [0x02] Controller clock stall enable on PAR phase of CCC
    $03 constant I3C_STALLA                     \ [0x03] Controller clock stall enable on ACK phase
    $08 constant I3C_STALL                      \ [0x08 : 8] Controller clock stall time, in number of kernel clock cycles
  [then]


  [ifdef] I3C_I3C_BCR_DEF
    \
    \ @brief I3C bus characteristics register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant I3C_BCR0                       \ [0x00] max data speed limitation
    $02 constant I3C_BCR2                       \ [0x02] in-band interrupt (IBI) payload
    $06 constant I3C_BCR6                       \ [0x06] Controller capable
  [then]


  [ifdef] I3C_I3C_DCR_DEF
    \
    \ @brief I3C device characteristics register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant I3C_DCR                        \ [0x00 : 8] device characteristics ID
  [then]


  [ifdef] I3C_I3C_GETCAPR_DEF
    \
    \ @brief I3C get capability register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $0e constant I3C_CAPPEND                    \ [0x0e] IBI MDB support for pending read notification
  [then]


  [ifdef] I3C_I3C_CRCAPR_DEF
    \
    \ @brief I3C controller-role capability register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $03 constant I3C_CAPDHOFF                   \ [0x03] delayed controller-role hand-off
    $09 constant I3C_CAPGRP                     \ [0x09] group management support (when acting as controller)
  [then]


  [ifdef] I3C_I3C_GETMXDSR_DEF
    \
    \ @brief I3C get capability register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant I3C_HOFFAS                     \ [0x00 : 2] Controller hand-off activity state
    $08 constant I3C_FMT                        \ [0x08 : 2] GETMXDS CCC format
    $10 constant I3C_RDTURN                     \ [0x10 : 8] programmed byte of the 3-byte MaxRdTurn (maximum read turnaround byte)
    $18 constant I3C_TSCO                       \ [0x18] clock-to-data turnaround time (t less than sub>SCO less than /sub>)
  [then]


  [ifdef] I3C_I3C_EPIDR_DEF
    \
    \ @brief I3C extended provisioned ID register
    \ Address offset: 0xD4
    \ Reset value: 0x02080000
    \
    $0c constant I3C_MIPIID                     \ [0x0c : 4] 4-bit MIPI Instance ID
    $10 constant I3C_IDTSEL                     \ [0x10] provisioned ID type selector
    $11 constant I3C_MIPIMID                    \ [0x11 : 15] 15-bit MIPI manufacturer ID
  [then]

  \
  \ @brief Improved inter-integrated circuit
  \
  $00 constant I3C_I3C_CR               \ I3C message control register
  $00 constant I3C_I3C_CR_ALTERNATE     \ I3C message control register
  $04 constant I3C_I3C_CFGR             \ I3C configuration register
  $10 constant I3C_I3C_RDR              \ I3C receive data byte register
  $14 constant I3C_I3C_RDWR             \ I3C receive data word register
  $18 constant I3C_I3C_TDR              \ I3C transmit data byte register
  $1C constant I3C_I3C_TDWR             \ I3C transmit data word register
  $20 constant I3C_I3C_IBIDR            \ I3C IBI payload data register
  $24 constant I3C_I3C_TGTTDR           \ I3C target transmit configuration register
  $30 constant I3C_I3C_SR               \ I3C status register
  $34 constant I3C_I3C_SER              \ I3C status error register
  $40 constant I3C_I3C_RMR              \ I3C received message register
  $50 constant I3C_I3C_EVR              \ I3C event register
  $54 constant I3C_I3C_IER              \ I3C interrupt enable register
  $58 constant I3C_I3C_CEVR             \ I3C clear event register
  $60 constant I3C_I3C_DEVR0            \ I3C own device characteristics register
  $64 constant I3C_I3C_DEVR1            \ I3C device 1 characteristics register
  $68 constant I3C_I3C_DEVR2            \ I3C device 2 characteristics register
  $6C constant I3C_I3C_DEVR3            \ I3C device 3 characteristics register
  $70 constant I3C_I3C_DEVR4            \ I3C device 4 characteristics register
  $90 constant I3C_I3C_MAXRLR           \ I3C maximum read length register
  $94 constant I3C_I3C_MAXWLR           \ I3C maximum write length register
  $A0 constant I3C_I3C_TIMINGR0         \ I3C timing register 0
  $A4 constant I3C_I3C_TIMINGR1         \ I3C timing register 1
  $A8 constant I3C_I3C_TIMINGR2         \ I3C timing register 2
  $C0 constant I3C_I3C_BCR              \ I3C bus characteristics register
  $C4 constant I3C_I3C_DCR              \ I3C device characteristics register
  $C8 constant I3C_I3C_GETCAPR          \ I3C get capability register
  $CC constant I3C_I3C_CRCAPR           \ I3C controller-role capability register
  $D0 constant I3C_I3C_GETMXDSR         \ I3C get capability register
  $D4 constant I3C_I3C_EPIDR            \ I3C extended provisioned ID register

: I3C_DEF ; [then]
