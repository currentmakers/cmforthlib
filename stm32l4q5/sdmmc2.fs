\
\ @file sdmmc2.fs
\ @brief Secure digital input/output interface 2
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

$00000003 constant SDMMC2_POWER_PWRCTRL                             \ SDMMC state control bits
$00000004 constant SDMMC2_POWER_VSWITCH                             \ Voltage switch sequence start
$00000008 constant SDMMC2_POWER_VSWITCHEN                           \ Voltage switch procedure enable
$00000010 constant SDMMC2_POWER_DIRPOL                              \ Data and command direction signals polarity selection


\
\ @brief SDI clock control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000003ff constant SDMMC2_CLKCR_CLKDIV                              \ Clock divide factor
$00001000 constant SDMMC2_CLKCR_PWRSAV                              \ Power saving configuration bit
$0000c000 constant SDMMC2_CLKCR_WIDBUS                              \ Wide bus mode enable bit
$00010000 constant SDMMC2_CLKCR_NEGEDGE                             \ SDMMC_CK dephasing selection bit for data and command
$00020000 constant SDMMC2_CLKCR_HWFC_EN                             \ Hardware flow control enable
$00040000 constant SDMMC2_CLKCR_DDR                                 \ Data rate signaling selection
$00080000 constant SDMMC2_CLKCR_BUSSPEED                            \ Bus speed mode selection between DS, HS, SDR12, SDR25 and SDR50,DDR50
$00300000 constant SDMMC2_CLKCR_SELCLKRX                            \ Receive clock selection


\
\ @brief argument register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_ARGR_CMDARG                               \ Command argument


\
\ @brief command register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000003f constant SDMMC2_CMDR_CMDINDEX                             \ Command index
$00000040 constant SDMMC2_CMDR_CMDTRANS                             \ The CPSM treats the command as a data transfer command, stops the interrupt period, and signals DataEnable to the DPSM
$00000080 constant SDMMC2_CMDR_CMDSTOP                              \ The CPSM treats the command as a Stop Transmission command and signals Abort to the DPSM
$00000300 constant SDMMC2_CMDR_WAITRESP                             \ Wait for response bits
$00000400 constant SDMMC2_CMDR_WAITINT                              \ CPSM waits for interrupt request
$00000800 constant SDMMC2_CMDR_WAITPEND                             \ CPSM Waits for ends of data transfer (CmdPend internal signal)
$00001000 constant SDMMC2_CMDR_CPSMEN                               \ Command path state machine (CPSM) Enable bit
$00002000 constant SDMMC2_CMDR_DTHOLD                               \ Hold new data block transmission and reception in the DPSM
$00004000 constant SDMMC2_CMDR_BOOTMODE                             \ Select the boot mode procedure to be used
$00008000 constant SDMMC2_CMDR_BOOTEN                               \ Enable boot mode procedure
$00010000 constant SDMMC2_CMDR_CMDSUSPEND                           \ The CPSM treats the command as a Suspend or Resume command and signals interrupt period start/end


\
\ @brief command response register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000003f constant SDMMC2_RESPCMDR_RESPCMD                          \ Response command index


\
\ @brief response 1..4 register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_RESP1R_CARDSTATUS1                        \ see Table 347


\
\ @brief response 1..4 register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_RESP2R_CARDSTATUS2                        \ see Table 347


\
\ @brief response 1..4 register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_RESP3R_CARDSTATUS3                        \ see Table 347


\
\ @brief response 1..4 register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_RESP4R_CARDSTATUS4                        \ see Table 347


\
\ @brief data timer register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_DTIMER_DATATIME                           \ Data timeout period


\
\ @brief data length register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$01ffffff constant SDMMC2_DLENR_DATALENGTH                          \ Data length value


\
\ @brief data control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant SDMMC2_DCTRL_DTEN                                \ DTEN
$00000002 constant SDMMC2_DCTRL_DTDIR                               \ Data transfer direction selection
$0000000c constant SDMMC2_DCTRL_DTMODE                              \ Data transfer mode selection 1: Stream or SDIO multibyte data transfer
$000000f0 constant SDMMC2_DCTRL_DBLOCKSIZE                          \ Data block size
$00000100 constant SDMMC2_DCTRL_RWSTART                             \ Read wait start
$00000200 constant SDMMC2_DCTRL_RWSTOP                              \ Read wait stop
$00000400 constant SDMMC2_DCTRL_RWMOD                               \ Read wait mode
$00000800 constant SDMMC2_DCTRL_SDIOEN                              \ SD I/O enable functions
$00001000 constant SDMMC2_DCTRL_BOOTACKEN                           \ Enable the reception of the boot acknowledgment
$00002000 constant SDMMC2_DCTRL_FIFORST                             \ FIFO reset, will flush any remaining data


\
\ @brief data counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$01ffffff constant SDMMC2_DCNTR_DATACOUNT                           \ Data count value


\
\ @brief status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant SDMMC2_STAR_CCRCFAIL                             \ Command response received (CRC check failed)
$00000002 constant SDMMC2_STAR_DCRCFAIL                             \ Data block sent/received (CRC check failed)
$00000004 constant SDMMC2_STAR_CTIMEOUT                             \ Command response timeout
$00000008 constant SDMMC2_STAR_DTIMEOUT                             \ Data timeout
$00000010 constant SDMMC2_STAR_TXUNDERR                             \ Transmit FIFO underrun error
$00000020 constant SDMMC2_STAR_RXOVERR                              \ Received FIFO overrun error
$00000040 constant SDMMC2_STAR_CMDREND                              \ Command response received (CRC check passed)
$00000080 constant SDMMC2_STAR_CMDSENT                              \ Command sent (no response required)
$00000100 constant SDMMC2_STAR_DATAEND                              \ Data end (data counter, SDIDCOUNT, is zero)
$00000200 constant SDMMC2_STAR_DHOLD                                \ Data transfer Hold
$00000400 constant SDMMC2_STAR_DBCKEND                              \ Data block sent/received
$00000800 constant SDMMC2_STAR_DABORT                               \ Data transfer aborted by CMD12
$00001000 constant SDMMC2_STAR_DPSMACT                              \ Data path state machine active, i.e. not in Idle state
$00002000 constant SDMMC2_STAR_CPSMACT                              \ Command path state machine active, i.e. not in Idle state
$00004000 constant SDMMC2_STAR_TXFIFOHE                             \ Transmit FIFO half empty: at least 8 words can be written into the FIFO
$00008000 constant SDMMC2_STAR_RXFIFOHF                             \ Receive FIFO half full: there are at least 8 words in the FIFO
$00010000 constant SDMMC2_STAR_TXFIFOF                              \ Transmit FIFO full
$00020000 constant SDMMC2_STAR_RXFIFOF                              \ Receive FIFO full
$00040000 constant SDMMC2_STAR_TXFIFOE                              \ Transmit FIFO empty
$00080000 constant SDMMC2_STAR_RXFIFOE                              \ Receive FIFO empty
$00100000 constant SDMMC2_STAR_BUSYD0                               \ Inverted value of SDMMC_D0 line (Busy), sampled at the end of a CMD response and a second time 2 SDMMC_CK cycles after the CMD response
$00200000 constant SDMMC2_STAR_BUSYD0END                            \ end of SDMMC_D0 Busy following a CMD response detected
$00400000 constant SDMMC2_STAR_SDIOIT                               \ SDIO interrupt received
$00800000 constant SDMMC2_STAR_ACKFAIL                              \ Boot acknowledgment received (boot acknowledgment check fail)
$01000000 constant SDMMC2_STAR_ACKTIMEOUT                           \ Boot acknowledgment timeout
$02000000 constant SDMMC2_STAR_VSWEND                               \ Voltage switch critical timing section completion
$04000000 constant SDMMC2_STAR_CKSTOP                               \ SDMMC_CK stopped in Voltage switch procedure
$08000000 constant SDMMC2_STAR_IDMATE                               \ IDMA transfer error
$10000000 constant SDMMC2_STAR_IDMABTC                              \ IDMA buffer transfer complete


\
\ @brief interrupt clear register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant SDMMC2_ICR_CCRCFAILC                             \ CCRCFAIL flag clear bit
$00000002 constant SDMMC2_ICR_DCRCFAILC                             \ DCRCFAIL flag clear bit
$00000004 constant SDMMC2_ICR_CTIMEOUTC                             \ CTIMEOUT flag clear bit
$00000008 constant SDMMC2_ICR_DTIMEOUTC                             \ DTIMEOUT flag clear bit
$00000010 constant SDMMC2_ICR_TXUNDERRC                             \ TXUNDERR flag clear bit
$00000020 constant SDMMC2_ICR_RXOVERRC                              \ RXOVERR flag clear bit
$00000040 constant SDMMC2_ICR_CMDRENDC                              \ CMDREND flag clear bit
$00000080 constant SDMMC2_ICR_CMDSENTC                              \ CMDSENT flag clear bit
$00000100 constant SDMMC2_ICR_DATAENDC                              \ DATAEND flag clear bit
$00000200 constant SDMMC2_ICR_DHOLDC                                \ DHOLD flag clear bit
$00000400 constant SDMMC2_ICR_DBCKENDC                              \ DBCKEND flag clear bit
$00000800 constant SDMMC2_ICR_DABORTC                               \ DABORT flag clear bit
$00200000 constant SDMMC2_ICR_BUSYD0ENDC                            \ BUSYD0END flag clear bit
$00400000 constant SDMMC2_ICR_SDIOITC                               \ SDIOIT flag clear bit
$00800000 constant SDMMC2_ICR_ACKFAILC                              \ ACKFAIL flag clear bit
$01000000 constant SDMMC2_ICR_ACKTIMEOUTC                           \ ACKTIMEOUT flag clear bit
$02000000 constant SDMMC2_ICR_VSWENDC                               \ VSWEND flag clear bit
$04000000 constant SDMMC2_ICR_CKSTOPC                               \ CKSTOP flag clear bit
$08000000 constant SDMMC2_ICR_IDMATEC                               \ IDMA transfer error clear bit
$10000000 constant SDMMC2_ICR_IDMABTCC                              \ IDMA buffer transfer complete clear bit


\
\ @brief mask register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant SDMMC2_MASKR_CCRCFAILIE                          \ Command CRC fail interrupt enable
$00000002 constant SDMMC2_MASKR_DCRCFAILIE                          \ Data CRC fail interrupt enable
$00000004 constant SDMMC2_MASKR_CTIMEOUTIE                          \ Command timeout interrupt enable
$00000008 constant SDMMC2_MASKR_DTIMEOUTIE                          \ Data timeout interrupt enable
$00000010 constant SDMMC2_MASKR_TXUNDERRIE                          \ Tx FIFO underrun error interrupt enable
$00000020 constant SDMMC2_MASKR_RXOVERRIE                           \ Rx FIFO overrun error interrupt enable
$00000040 constant SDMMC2_MASKR_CMDRENDIE                           \ Command response received interrupt enable
$00000080 constant SDMMC2_MASKR_CMDSENTIE                           \ Command sent interrupt enable
$00000100 constant SDMMC2_MASKR_DATAENDIE                           \ Data end interrupt enable
$00000200 constant SDMMC2_MASKR_DHOLDIE                             \ Data hold interrupt enable
$00000400 constant SDMMC2_MASKR_DBCKENDIE                           \ Data block end interrupt enable
$00000800 constant SDMMC2_MASKR_DABORTIE                            \ Data transfer aborted interrupt enable
$00004000 constant SDMMC2_MASKR_TXFIFOHEIE                          \ Tx FIFO half empty interrupt enable
$00008000 constant SDMMC2_MASKR_RXFIFOHFIE                          \ Rx FIFO half full interrupt enable
$00020000 constant SDMMC2_MASKR_RXFIFOFIE                           \ Rx FIFO full interrupt enable
$00040000 constant SDMMC2_MASKR_TXFIFOEIE                           \ Tx FIFO empty interrupt enable
$00200000 constant SDMMC2_MASKR_BUSYD0ENDIE                         \ BUSYD0END interrupt enable
$00400000 constant SDMMC2_MASKR_SDIOITIE                            \ SDIO mode interrupt received interrupt enable
$00800000 constant SDMMC2_MASKR_ACKFAILIE                           \ Acknowledgment Fail interrupt enable
$01000000 constant SDMMC2_MASKR_ACKTIMEOUTIE                        \ Acknowledgment timeout interrupt enable
$02000000 constant SDMMC2_MASKR_VSWENDIE                            \ Voltage switch critical timing section completion interrupt enable
$04000000 constant SDMMC2_MASKR_CKSTOPIE                            \ CKSTOPIE
$10000000 constant SDMMC2_MASKR_IDMABTCIE                           \ IDMABTCIE


\
\ @brief acknowledgment timer register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$01ffffff constant SDMMC2_ACKTIMER_ACKTIME                          \ Boot acknowledgment timeout period


\
\ @brief DMA control register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant SDMMC2_IDMACTRLR_IDMAEN                          \ IDMA enable
$00000002 constant SDMMC2_IDMACTRLR_IDMABMODE                       \ Buffer mode selection
$00000004 constant SDMMC2_IDMACTRLR_IDMABACT                        \ Double buffer mode active buffer indication


\
\ @brief IDMA buffer size register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00001fe0 constant SDMMC2_IDMABSIZER_IDMABNDT                       \ Number of bytes per buffer


\
\ @brief IDMA buffer 0 base address register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_IDMABASE0R_IDMABASE0                      \ Buffer 0 memory base address bits [31:2], shall be word aligned (bit [1:0] are always 0 and read only)


\
\ @brief IDMA buffer 0 base address register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_IDMABASE1R_IDMABASE1                      \ Buffer 1 memory base address, shall be word aligned (bit [1:0] are always 0 and read only)


\
\ @brief data FIFO register 0
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_FIFOR0_FIFODATA                           \ Receive and transmit FIFO data


\
\ @brief data FIFO register 1
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_FIFOR1_FIFODATA                           \ Receive and transmit FIFO data


\
\ @brief data FIFO register 2
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_FIFOR2_FIFODATA                           \ Receive and transmit FIFO data


\
\ @brief data FIFO register 3
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_FIFOR3_FIFODATA                           \ Receive and transmit FIFO data


\
\ @brief data FIFO register 4
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_FIFOR4_FIFODATA                           \ Receive and transmit FIFO data


\
\ @brief data FIFO register 5
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_FIFOR5_FIFODATA                           \ Receive and transmit FIFO data


\
\ @brief data FIFO register 6
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_FIFOR6_FIFODATA                           \ Receive and transmit FIFO data


\
\ @brief data FIFO register 7
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_FIFOR7_FIFODATA                           \ Receive and transmit FIFO data


\
\ @brief data FIFO register 8
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_FIFOR8_FIFODATA                           \ Receive and transmit FIFO data


\
\ @brief data FIFO register 9
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_FIFOR9_FIFODATA                           \ Receive and transmit FIFO data


\
\ @brief data FIFO register 10
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_FIFOR10_FIFODATA                          \ Receive and transmit FIFO data


\
\ @brief data FIFO register 11
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_FIFOR11_FIFODATA                          \ Receive and transmit FIFO data


\
\ @brief data FIFO register 12
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_FIFOR12_FIFODATA                          \ Receive and transmit FIFO data


\
\ @brief data FIFO register 13
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_FIFOR13_FIFODATA                          \ Receive and transmit FIFO data


\
\ @brief data FIFO register 14
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_FIFOR14_FIFODATA                          \ Receive and transmit FIFO data


\
\ @brief data FIFO register 15
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000000 constant SDMMC2_FIFOR15_FIFODATA                          \ Receive and transmit FIFO data


\
\ @brief Secure digital input/output interface 2
\
$50062800 constant SDMMC2_POWER   \ offset: 0x00 : power control register
$50062804 constant SDMMC2_CLKCR   \ offset: 0x04 : SDI clock control register
$50062808 constant SDMMC2_ARGR    \ offset: 0x08 : argument register
$5006280c constant SDMMC2_CMDR    \ offset: 0x0C : command register
$50062810 constant SDMMC2_RESPCMDR  \ offset: 0x10 : command response register
$50062814 constant SDMMC2_RESP1R  \ offset: 0x14 : response 1..4 register
$50062818 constant SDMMC2_RESP2R  \ offset: 0x18 : response 1..4 register
$5006281c constant SDMMC2_RESP3R  \ offset: 0x1C : response 1..4 register
$50062820 constant SDMMC2_RESP4R  \ offset: 0x20 : response 1..4 register
$50062824 constant SDMMC2_DTIMER  \ offset: 0x24 : data timer register
$50062828 constant SDMMC2_DLENR   \ offset: 0x28 : data length register
$5006282c constant SDMMC2_DCTRL   \ offset: 0x2C : data control register
$50062830 constant SDMMC2_DCNTR   \ offset: 0x30 : data counter register
$50062834 constant SDMMC2_STAR    \ offset: 0x34 : status register
$50062838 constant SDMMC2_ICR     \ offset: 0x38 : interrupt clear register
$5006283c constant SDMMC2_MASKR   \ offset: 0x3C : mask register
$50062840 constant SDMMC2_ACKTIMER  \ offset: 0x40 : acknowledgment timer register
$50062850 constant SDMMC2_IDMACTRLR  \ offset: 0x50 : DMA control register
$50062854 constant SDMMC2_IDMABSIZER  \ offset: 0x54 : IDMA buffer size register
$50062858 constant SDMMC2_IDMABASE0R  \ offset: 0x58 : IDMA buffer 0 base address register
$5006285c constant SDMMC2_IDMABASE1R  \ offset: 0x5C : IDMA buffer 0 base address register
$50062880 constant SDMMC2_FIFOR0  \ offset: 0x80 : data FIFO register 0
$50062884 constant SDMMC2_FIFOR1  \ offset: 0x84 : data FIFO register 1
$50062888 constant SDMMC2_FIFOR2  \ offset: 0x88 : data FIFO register 2
$5006288c constant SDMMC2_FIFOR3  \ offset: 0x8C : data FIFO register 3
$50062890 constant SDMMC2_FIFOR4  \ offset: 0x90 : data FIFO register 4
$50062894 constant SDMMC2_FIFOR5  \ offset: 0x94 : data FIFO register 5
$50062898 constant SDMMC2_FIFOR6  \ offset: 0x98 : data FIFO register 6
$5006289c constant SDMMC2_FIFOR7  \ offset: 0x9C : data FIFO register 7
$500628a0 constant SDMMC2_FIFOR8  \ offset: 0xA0 : data FIFO register 8
$500628a4 constant SDMMC2_FIFOR9  \ offset: 0xA4 : data FIFO register 9
$500628a8 constant SDMMC2_FIFOR10  \ offset: 0xA8 : data FIFO register 10
$500628ac constant SDMMC2_FIFOR11  \ offset: 0xAC : data FIFO register 11
$500628b0 constant SDMMC2_FIFOR12  \ offset: 0xB0 : data FIFO register 12
$500628b4 constant SDMMC2_FIFOR13  \ offset: 0xB4 : data FIFO register 13
$500628b8 constant SDMMC2_FIFOR14  \ offset: 0xB8 : data FIFO register 14
$500628bc constant SDMMC2_FIFOR15  \ offset: 0xBC : data FIFO register 15

