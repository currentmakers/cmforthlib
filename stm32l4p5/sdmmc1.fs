\
\ @file sdmmc1.fs
\ @brief Secure digital input/output interface 1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief power control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant SDMMC1_POWER_PWRCTRL                             \ SDMMC state control bits
$00000004 constant SDMMC1_POWER_VSWITCH                             \ Voltage switch sequence start
$00000008 constant SDMMC1_POWER_VSWITCHEN                           \ Voltage switch procedure enable
$00000010 constant SDMMC1_POWER_DIRPOL                              \ Data and command direction signals polarity selection


\
\ @brief SDI clock control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000003ff constant SDMMC1_CLKCR_CLKDIV                              \ Clock divide factor
$00001000 constant SDMMC1_CLKCR_PWRSAV                              \ Power saving configuration bit
$0000c000 constant SDMMC1_CLKCR_WIDBUS                              \ Wide bus mode enable bit
$00010000 constant SDMMC1_CLKCR_NEGEDGE                             \ SDMMC_CK dephasing selection bit for data and command
$00020000 constant SDMMC1_CLKCR_HWFC_EN                             \ Hardware flow control enable
$00040000 constant SDMMC1_CLKCR_DDR                                 \ Data rate signaling selection
$00080000 constant SDMMC1_CLKCR_BUSSPEED                            \ Bus speed mode selection between DS, HS, SDR12, SDR25 and SDR50,DDR50
$00300000 constant SDMMC1_CLKCR_SELCLKRX                            \ Receive clock selection


\
\ @brief argument register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_ARGR_CMDARG                               \ Command argument


\
\ @brief command register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000003f constant SDMMC1_CMDR_CMDINDEX                             \ Command index
$00000040 constant SDMMC1_CMDR_CMDTRANS                             \ The CPSM treats the command as a data transfer command, stops the interrupt period, and signals DataEnable to the DPSM
$00000080 constant SDMMC1_CMDR_CMDSTOP                              \ The CPSM treats the command as a Stop Transmission command and signals Abort to the DPSM
$00000300 constant SDMMC1_CMDR_WAITRESP                             \ Wait for response bits
$00000400 constant SDMMC1_CMDR_WAITINT                              \ CPSM waits for interrupt request
$00000800 constant SDMMC1_CMDR_WAITPEND                             \ CPSM Waits for ends of data transfer (CmdPend internal signal)
$00001000 constant SDMMC1_CMDR_CPSMEN                               \ Command path state machine (CPSM) Enable bit
$00002000 constant SDMMC1_CMDR_DTHOLD                               \ Hold new data block transmission and reception in the DPSM
$00004000 constant SDMMC1_CMDR_BOOTMODE                             \ Select the boot mode procedure to be used
$00008000 constant SDMMC1_CMDR_BOOTEN                               \ Enable boot mode procedure
$00010000 constant SDMMC1_CMDR_CMDSUSPEND                           \ The CPSM treats the command as a Suspend or Resume command and signals interrupt period start/end


\
\ @brief command response register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000003f constant SDMMC1_RESPCMDR_RESPCMD                          \ Response command index


\
\ @brief response 1..4 register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_RESP1R_CARDSTATUS1                        \ see Table 347


\
\ @brief response 1..4 register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_RESP2R_CARDSTATUS2                        \ see Table 347


\
\ @brief response 1..4 register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_RESP3R_CARDSTATUS3                        \ see Table 347


\
\ @brief response 1..4 register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_RESP4R_CARDSTATUS4                        \ see Table 347


\
\ @brief data timer register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_DTIMER_DATATIME                           \ Data timeout period


\
\ @brief data length register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$01ffffff constant SDMMC1_DLENR_DATALENGTH                          \ Data length value


\
\ @brief data control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant SDMMC1_DCTRL_DTEN                                \ DTEN
$00000002 constant SDMMC1_DCTRL_DTDIR                               \ Data transfer direction selection
$0000000c constant SDMMC1_DCTRL_DTMODE                              \ Data transfer mode selection 1: Stream or SDIO multibyte data transfer
$000000f0 constant SDMMC1_DCTRL_DBLOCKSIZE                          \ Data block size
$00000100 constant SDMMC1_DCTRL_RWSTART                             \ Read wait start
$00000200 constant SDMMC1_DCTRL_RWSTOP                              \ Read wait stop
$00000400 constant SDMMC1_DCTRL_RWMOD                               \ Read wait mode
$00000800 constant SDMMC1_DCTRL_SDIOEN                              \ SD I/O enable functions
$00001000 constant SDMMC1_DCTRL_BOOTACKEN                           \ Enable the reception of the boot acknowledgment
$00002000 constant SDMMC1_DCTRL_FIFORST                             \ FIFO reset, will flush any remaining data


\
\ @brief data counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$01ffffff constant SDMMC1_DCNTR_DATACOUNT                           \ Data count value


\
\ @brief status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant SDMMC1_STAR_CCRCFAIL                             \ Command response received (CRC check failed)
$00000002 constant SDMMC1_STAR_DCRCFAIL                             \ Data block sent/received (CRC check failed)
$00000004 constant SDMMC1_STAR_CTIMEOUT                             \ Command response timeout
$00000008 constant SDMMC1_STAR_DTIMEOUT                             \ Data timeout
$00000010 constant SDMMC1_STAR_TXUNDERR                             \ Transmit FIFO underrun error
$00000020 constant SDMMC1_STAR_RXOVERR                              \ Received FIFO overrun error
$00000040 constant SDMMC1_STAR_CMDREND                              \ Command response received (CRC check passed)
$00000080 constant SDMMC1_STAR_CMDSENT                              \ Command sent (no response required)
$00000100 constant SDMMC1_STAR_DATAEND                              \ Data end (data counter, SDIDCOUNT, is zero)
$00000200 constant SDMMC1_STAR_DHOLD                                \ Data transfer Hold
$00000400 constant SDMMC1_STAR_DBCKEND                              \ Data block sent/received
$00000800 constant SDMMC1_STAR_DABORT                               \ Data transfer aborted by CMD12
$00001000 constant SDMMC1_STAR_DPSMACT                              \ Data path state machine active, i.e. not in Idle state
$00002000 constant SDMMC1_STAR_CPSMACT                              \ Command path state machine active, i.e. not in Idle state
$00004000 constant SDMMC1_STAR_TXFIFOHE                             \ Transmit FIFO half empty: at least 8 words can be written into the FIFO
$00008000 constant SDMMC1_STAR_RXFIFOHF                             \ Receive FIFO half full: there are at least 8 words in the FIFO
$00010000 constant SDMMC1_STAR_TXFIFOF                              \ Transmit FIFO full
$00020000 constant SDMMC1_STAR_RXFIFOF                              \ Receive FIFO full
$00040000 constant SDMMC1_STAR_TXFIFOE                              \ Transmit FIFO empty
$00080000 constant SDMMC1_STAR_RXFIFOE                              \ Receive FIFO empty
$00100000 constant SDMMC1_STAR_BUSYD0                               \ Inverted value of SDMMC_D0 line (Busy), sampled at the end of a CMD response and a second time 2 SDMMC_CK cycles after the CMD response
$00200000 constant SDMMC1_STAR_BUSYD0END                            \ end of SDMMC_D0 Busy following a CMD response detected
$00400000 constant SDMMC1_STAR_SDIOIT                               \ SDIO interrupt received
$00800000 constant SDMMC1_STAR_ACKFAIL                              \ Boot acknowledgment received (boot acknowledgment check fail)
$01000000 constant SDMMC1_STAR_ACKTIMEOUT                           \ Boot acknowledgment timeout
$02000000 constant SDMMC1_STAR_VSWEND                               \ Voltage switch critical timing section completion
$04000000 constant SDMMC1_STAR_CKSTOP                               \ SDMMC_CK stopped in Voltage switch procedure
$08000000 constant SDMMC1_STAR_IDMATE                               \ IDMA transfer error
$10000000 constant SDMMC1_STAR_IDMABTC                              \ IDMA buffer transfer complete


\
\ @brief interrupt clear register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant SDMMC1_ICR_CCRCFAILC                             \ CCRCFAIL flag clear bit
$00000002 constant SDMMC1_ICR_DCRCFAILC                             \ DCRCFAIL flag clear bit
$00000004 constant SDMMC1_ICR_CTIMEOUTC                             \ CTIMEOUT flag clear bit
$00000008 constant SDMMC1_ICR_DTIMEOUTC                             \ DTIMEOUT flag clear bit
$00000010 constant SDMMC1_ICR_TXUNDERRC                             \ TXUNDERR flag clear bit
$00000020 constant SDMMC1_ICR_RXOVERRC                              \ RXOVERR flag clear bit
$00000040 constant SDMMC1_ICR_CMDRENDC                              \ CMDREND flag clear bit
$00000080 constant SDMMC1_ICR_CMDSENTC                              \ CMDSENT flag clear bit
$00000100 constant SDMMC1_ICR_DATAENDC                              \ DATAEND flag clear bit
$00000200 constant SDMMC1_ICR_DHOLDC                                \ DHOLD flag clear bit
$00000400 constant SDMMC1_ICR_DBCKENDC                              \ DBCKEND flag clear bit
$00000800 constant SDMMC1_ICR_DABORTC                               \ DABORT flag clear bit
$00200000 constant SDMMC1_ICR_BUSYD0ENDC                            \ BUSYD0END flag clear bit
$00400000 constant SDMMC1_ICR_SDIOITC                               \ SDIOIT flag clear bit
$00800000 constant SDMMC1_ICR_ACKFAILC                              \ ACKFAIL flag clear bit
$01000000 constant SDMMC1_ICR_ACKTIMEOUTC                           \ ACKTIMEOUT flag clear bit
$02000000 constant SDMMC1_ICR_VSWENDC                               \ VSWEND flag clear bit
$04000000 constant SDMMC1_ICR_CKSTOPC                               \ CKSTOP flag clear bit
$08000000 constant SDMMC1_ICR_IDMATEC                               \ IDMA transfer error clear bit
$10000000 constant SDMMC1_ICR_IDMABTCC                              \ IDMA buffer transfer complete clear bit


\
\ @brief mask register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant SDMMC1_MASKR_CCRCFAILIE                          \ Command CRC fail interrupt enable
$00000002 constant SDMMC1_MASKR_DCRCFAILIE                          \ Data CRC fail interrupt enable
$00000004 constant SDMMC1_MASKR_CTIMEOUTIE                          \ Command timeout interrupt enable
$00000008 constant SDMMC1_MASKR_DTIMEOUTIE                          \ Data timeout interrupt enable
$00000010 constant SDMMC1_MASKR_TXUNDERRIE                          \ Tx FIFO underrun error interrupt enable
$00000020 constant SDMMC1_MASKR_RXOVERRIE                           \ Rx FIFO overrun error interrupt enable
$00000040 constant SDMMC1_MASKR_CMDRENDIE                           \ Command response received interrupt enable
$00000080 constant SDMMC1_MASKR_CMDSENTIE                           \ Command sent interrupt enable
$00000100 constant SDMMC1_MASKR_DATAENDIE                           \ Data end interrupt enable
$00000200 constant SDMMC1_MASKR_DHOLDIE                             \ Data hold interrupt enable
$00000400 constant SDMMC1_MASKR_DBCKENDIE                           \ Data block end interrupt enable
$00000800 constant SDMMC1_MASKR_DABORTIE                            \ Data transfer aborted interrupt enable
$00004000 constant SDMMC1_MASKR_TXFIFOHEIE                          \ Tx FIFO half empty interrupt enable
$00008000 constant SDMMC1_MASKR_RXFIFOHFIE                          \ Rx FIFO half full interrupt enable
$00020000 constant SDMMC1_MASKR_RXFIFOFIE                           \ Rx FIFO full interrupt enable
$00040000 constant SDMMC1_MASKR_TXFIFOEIE                           \ Tx FIFO empty interrupt enable
$00200000 constant SDMMC1_MASKR_BUSYD0ENDIE                         \ BUSYD0END interrupt enable
$00400000 constant SDMMC1_MASKR_SDIOITIE                            \ SDIO mode interrupt received interrupt enable
$00800000 constant SDMMC1_MASKR_ACKFAILIE                           \ Acknowledgment Fail interrupt enable
$01000000 constant SDMMC1_MASKR_ACKTIMEOUTIE                        \ Acknowledgment timeout interrupt enable
$02000000 constant SDMMC1_MASKR_VSWENDIE                            \ Voltage switch critical timing section completion interrupt enable
$04000000 constant SDMMC1_MASKR_CKSTOPIE                            \ CKSTOPIE
$10000000 constant SDMMC1_MASKR_IDMABTCIE                           \ IDMABTCIE


\
\ @brief acknowledgment timer register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$01ffffff constant SDMMC1_ACKTIMER_ACKTIME                          \ Boot acknowledgment timeout period


\
\ @brief DMA control register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant SDMMC1_IDMACTRLR_IDMAEN                          \ IDMA enable
$00000002 constant SDMMC1_IDMACTRLR_IDMABMODE                       \ Buffer mode selection
$00000004 constant SDMMC1_IDMACTRLR_IDMABACT                        \ Double buffer mode active buffer indication


\
\ @brief IDMA buffer size register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00001fe0 constant SDMMC1_IDMABSIZER_IDMABNDT                       \ Number of bytes per buffer


\
\ @brief IDMA buffer 0 base address register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_IDMABASE0R_IDMABASE0                      \ Buffer 0 memory base address bits [31:2], shall be word aligned (bit [1:0] are always 0 and read only)


\
\ @brief IDMA buffer 0 base address register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_IDMABASE1R_IDMABASE1                      \ Buffer 1 memory base address, shall be word aligned (bit [1:0] are always 0 and read only)


\
\ @brief data FIFO register 0
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_FIFOR0_FIFODATA                           \ Receive and transmit FIFO data


\
\ @brief data FIFO register 1
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_FIFOR1_FIFODATA                           \ Receive and transmit FIFO data


\
\ @brief data FIFO register 2
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_FIFOR2_FIFODATA                           \ Receive and transmit FIFO data


\
\ @brief data FIFO register 3
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_FIFOR3_FIFODATA                           \ Receive and transmit FIFO data


\
\ @brief data FIFO register 4
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_FIFOR4_FIFODATA                           \ Receive and transmit FIFO data


\
\ @brief data FIFO register 5
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_FIFOR5_FIFODATA                           \ Receive and transmit FIFO data


\
\ @brief data FIFO register 6
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_FIFOR6_FIFODATA                           \ Receive and transmit FIFO data


\
\ @brief data FIFO register 7
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_FIFOR7_FIFODATA                           \ Receive and transmit FIFO data


\
\ @brief data FIFO register 8
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_FIFOR8_FIFODATA                           \ Receive and transmit FIFO data


\
\ @brief data FIFO register 9
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_FIFOR9_FIFODATA                           \ Receive and transmit FIFO data


\
\ @brief data FIFO register 10
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_FIFOR10_FIFODATA                          \ Receive and transmit FIFO data


\
\ @brief data FIFO register 11
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_FIFOR11_FIFODATA                          \ Receive and transmit FIFO data


\
\ @brief data FIFO register 12
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_FIFOR12_FIFODATA                          \ Receive and transmit FIFO data


\
\ @brief data FIFO register 13
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_FIFOR13_FIFODATA                          \ Receive and transmit FIFO data


\
\ @brief data FIFO register 14
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_FIFOR14_FIFODATA                          \ Receive and transmit FIFO data


\
\ @brief data FIFO register 15
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_FIFOR15_FIFODATA                          \ Receive and transmit FIFO data


\
\ @brief Secure digital input/output interface 1
\
$50062400 constant SDMMC1_POWER   \ offset: 0x00 : power control register
$50062404 constant SDMMC1_CLKCR   \ offset: 0x04 : SDI clock control register
$50062408 constant SDMMC1_ARGR    \ offset: 0x08 : argument register
$5006240c constant SDMMC1_CMDR    \ offset: 0x0C : command register
$50062410 constant SDMMC1_RESPCMDR  \ offset: 0x10 : command response register
$50062414 constant SDMMC1_RESP1R  \ offset: 0x14 : response 1..4 register
$50062418 constant SDMMC1_RESP2R  \ offset: 0x18 : response 1..4 register
$5006241c constant SDMMC1_RESP3R  \ offset: 0x1C : response 1..4 register
$50062420 constant SDMMC1_RESP4R  \ offset: 0x20 : response 1..4 register
$50062424 constant SDMMC1_DTIMER  \ offset: 0x24 : data timer register
$50062428 constant SDMMC1_DLENR   \ offset: 0x28 : data length register
$5006242c constant SDMMC1_DCTRL   \ offset: 0x2C : data control register
$50062430 constant SDMMC1_DCNTR   \ offset: 0x30 : data counter register
$50062434 constant SDMMC1_STAR    \ offset: 0x34 : status register
$50062438 constant SDMMC1_ICR     \ offset: 0x38 : interrupt clear register
$5006243c constant SDMMC1_MASKR   \ offset: 0x3C : mask register
$50062440 constant SDMMC1_ACKTIMER  \ offset: 0x40 : acknowledgment timer register
$50062450 constant SDMMC1_IDMACTRLR  \ offset: 0x50 : DMA control register
$50062454 constant SDMMC1_IDMABSIZER  \ offset: 0x54 : IDMA buffer size register
$50062458 constant SDMMC1_IDMABASE0R  \ offset: 0x58 : IDMA buffer 0 base address register
$5006245c constant SDMMC1_IDMABASE1R  \ offset: 0x5C : IDMA buffer 0 base address register
$50062480 constant SDMMC1_FIFOR0  \ offset: 0x80 : data FIFO register 0
$50062484 constant SDMMC1_FIFOR1  \ offset: 0x84 : data FIFO register 1
$50062488 constant SDMMC1_FIFOR2  \ offset: 0x88 : data FIFO register 2
$5006248c constant SDMMC1_FIFOR3  \ offset: 0x8C : data FIFO register 3
$50062490 constant SDMMC1_FIFOR4  \ offset: 0x90 : data FIFO register 4
$50062494 constant SDMMC1_FIFOR5  \ offset: 0x94 : data FIFO register 5
$50062498 constant SDMMC1_FIFOR6  \ offset: 0x98 : data FIFO register 6
$5006249c constant SDMMC1_FIFOR7  \ offset: 0x9C : data FIFO register 7
$500624a0 constant SDMMC1_FIFOR8  \ offset: 0xA0 : data FIFO register 8
$500624a4 constant SDMMC1_FIFOR9  \ offset: 0xA4 : data FIFO register 9
$500624a8 constant SDMMC1_FIFOR10  \ offset: 0xA8 : data FIFO register 10
$500624ac constant SDMMC1_FIFOR11  \ offset: 0xAC : data FIFO register 11
$500624b0 constant SDMMC1_FIFOR12  \ offset: 0xB0 : data FIFO register 12
$500624b4 constant SDMMC1_FIFOR13  \ offset: 0xB4 : data FIFO register 13
$500624b8 constant SDMMC1_FIFOR14  \ offset: 0xB8 : data FIFO register 14
$500624bc constant SDMMC1_FIFOR15  \ offset: 0xBC : data FIFO register 15

