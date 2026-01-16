\
\ @file sdmmc1.fs
\ @brief Secure digital input/output       interface
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

$00000003 constant SDMMC1_POWER_PWRCTRL                             \ PWRCTRL


\
\ @brief SDI clock control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000000ff constant SDMMC1_CLKCR_CLKDIV                              \ Clock divide factor
$00000100 constant SDMMC1_CLKCR_CLKEN                               \ Clock enable bit
$00000200 constant SDMMC1_CLKCR_PWRSAV                              \ Power saving configuration bit
$00000400 constant SDMMC1_CLKCR_BYPASS                              \ Clock divider bypass enable bit
$00001800 constant SDMMC1_CLKCR_WIDBUS                              \ Wide bus mode enable bit
$00002000 constant SDMMC1_CLKCR_NEGEDGE                             \ SDIO_CK dephasing selection bit
$00004000 constant SDMMC1_CLKCR_HWFC_EN                             \ HW Flow Control enable


\
\ @brief argument register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_ARG_CMDARG                                \ Command argument


\
\ @brief command register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000003f constant SDMMC1_CMD_CMDINDEX                              \ Command index
$000000c0 constant SDMMC1_CMD_WAITRESP                              \ Wait for response bits
$00000100 constant SDMMC1_CMD_WAITINT                               \ CPSM waits for interrupt request
$00000200 constant SDMMC1_CMD_WAITPEND                              \ CPSM Waits for ends of data transfer (CmdPend internal signal)
$00000400 constant SDMMC1_CMD_CPSMEN                                \ Command path state machine (CPSM) Enable bit
$00000800 constant SDMMC1_CMD_SDIOSUSPEND                           \ SD I/O suspend command
$00001000 constant SDMMC1_CMD_ENCMDCOMPL                            \ Enable CMD completion
$00002000 constant SDMMC1_CMD_NIEN                                  \ not Interrupt Enable
$00004000 constant SDMMC1_CMD_CE_ATACMD                             \ CE-ATA command


\
\ @brief command response register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000003f constant SDMMC1_RESPCMD_RESPCMD                           \ Response command index


\
\ @brief response 1..4 register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_RESP1_CARDSTATUS1                         \ see Table 132


\
\ @brief response 1..4 register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_RESP2_CARDSTATUS2                         \ see Table 132


\
\ @brief response 1..4 register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_RESP3_CARDSTATUS3                         \ see Table 132


\
\ @brief response 1..4 register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_RESP4_CARDSTATUS4                         \ see Table 132


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

$01ffffff constant SDMMC1_DLEN_DATALENGTH                           \ Data length value


\
\ @brief data control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant SDMMC1_DCTRL_DTEN                                \ DTEN
$00000002 constant SDMMC1_DCTRL_DTDIR                               \ Data transfer direction selection
$00000004 constant SDMMC1_DCTRL_DTMODE                              \ Data transfer mode selection 1: Stream or SDIO multibyte data transfer
$00000008 constant SDMMC1_DCTRL_DMAEN                               \ DMA enable bit
$000000f0 constant SDMMC1_DCTRL_DBLOCKSIZE                          \ Data block size
$00000100 constant SDMMC1_DCTRL_RWSTART                             \ Read wait start
$00000200 constant SDMMC1_DCTRL_RWSTOP                              \ Read wait stop
$00000400 constant SDMMC1_DCTRL_RWMOD                               \ Read wait mode
$00000800 constant SDMMC1_DCTRL_SDIOEN                              \ SD I/O enable functions


\
\ @brief data counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$01ffffff constant SDMMC1_DCOUNT_DATACOUNT                          \ Data count value


\
\ @brief status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant SDMMC1_STA_CCRCFAIL                              \ Command response received (CRC check failed)
$00000002 constant SDMMC1_STA_DCRCFAIL                              \ Data block sent/received (CRC check failed)
$00000004 constant SDMMC1_STA_CTIMEOUT                              \ Command response timeout
$00000008 constant SDMMC1_STA_DTIMEOUT                              \ Data timeout
$00000010 constant SDMMC1_STA_TXUNDERR                              \ Transmit FIFO underrun error
$00000020 constant SDMMC1_STA_RXOVERR                               \ Received FIFO overrun error
$00000040 constant SDMMC1_STA_CMDREND                               \ Command response received (CRC check passed)
$00000080 constant SDMMC1_STA_CMDSENT                               \ Command sent (no response required)
$00000100 constant SDMMC1_STA_DATAEND                               \ Data end (data counter, SDIDCOUNT, is zero)
$00000200 constant SDMMC1_STA_STBITERR                              \ Start bit not detected on all data signals in wide bus mode
$00000400 constant SDMMC1_STA_DBCKEND                               \ Data block sent/received (CRC check passed)
$00000800 constant SDMMC1_STA_CMDACT                                \ Command transfer in progress
$00001000 constant SDMMC1_STA_TXACT                                 \ Data transmit in progress
$00002000 constant SDMMC1_STA_RXACT                                 \ Data receive in progress
$00004000 constant SDMMC1_STA_TXFIFOHE                              \ Transmit FIFO half empty: at least 8 words can be written into the FIFO
$00008000 constant SDMMC1_STA_RXFIFOHF                              \ Receive FIFO half full: there are at least 8 words in the FIFO
$00010000 constant SDMMC1_STA_TXFIFOF                               \ Transmit FIFO full
$00020000 constant SDMMC1_STA_RXFIFOF                               \ Receive FIFO full
$00040000 constant SDMMC1_STA_TXFIFOE                               \ Transmit FIFO empty
$00080000 constant SDMMC1_STA_RXFIFOE                               \ Receive FIFO empty
$00100000 constant SDMMC1_STA_TXDAVL                                \ Data available in transmit FIFO
$00200000 constant SDMMC1_STA_RXDAVL                                \ Data available in receive FIFO
$00400000 constant SDMMC1_STA_SDIOIT                                \ SDIO interrupt received
$00800000 constant SDMMC1_STA_CEATAEND                              \ CE-ATA command completion signal received for CMD61


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
$00000200 constant SDMMC1_ICR_STBITERRC                             \ STBITERR flag clear bit
$00000400 constant SDMMC1_ICR_DBCKENDC                              \ DBCKEND flag clear bit
$00400000 constant SDMMC1_ICR_SDIOITC                               \ SDIOIT flag clear bit
$00800000 constant SDMMC1_ICR_CEATAENDC                             \ CEATAEND flag clear bit


\
\ @brief mask register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant SDMMC1_MASK_CCRCFAILIE                           \ Command CRC fail interrupt enable
$00000002 constant SDMMC1_MASK_DCRCFAILIE                           \ Data CRC fail interrupt enable
$00000004 constant SDMMC1_MASK_CTIMEOUTIE                           \ Command timeout interrupt enable
$00000008 constant SDMMC1_MASK_DTIMEOUTIE                           \ Data timeout interrupt enable
$00000010 constant SDMMC1_MASK_TXUNDERRIE                           \ Tx FIFO underrun error interrupt enable
$00000020 constant SDMMC1_MASK_RXOVERRIE                            \ Rx FIFO overrun error interrupt enable
$00000040 constant SDMMC1_MASK_CMDRENDIE                            \ Command response received interrupt enable
$00000080 constant SDMMC1_MASK_CMDSENTIE                            \ Command sent interrupt enable
$00000100 constant SDMMC1_MASK_DATAENDIE                            \ Data end interrupt enable
$00000200 constant SDMMC1_MASK_STBITERRIE                           \ Start bit error interrupt enable
$00000400 constant SDMMC1_MASK_DBCKENDIE                            \ Data block end interrupt enable
$00000800 constant SDMMC1_MASK_CMDACTIE                             \ Command acting interrupt enable
$00001000 constant SDMMC1_MASK_TXACTIE                              \ Data transmit acting interrupt enable
$00002000 constant SDMMC1_MASK_RXACTIE                              \ Data receive acting interrupt enable
$00004000 constant SDMMC1_MASK_TXFIFOHEIE                           \ Tx FIFO half empty interrupt enable
$00008000 constant SDMMC1_MASK_RXFIFOHFIE                           \ Rx FIFO half full interrupt enable
$00010000 constant SDMMC1_MASK_TXFIFOFIE                            \ Tx FIFO full interrupt enable
$00020000 constant SDMMC1_MASK_RXFIFOFIE                            \ Rx FIFO full interrupt enable
$00040000 constant SDMMC1_MASK_TXFIFOEIE                            \ Tx FIFO empty interrupt enable
$00080000 constant SDMMC1_MASK_RXFIFOEIE                            \ Rx FIFO empty interrupt enable
$00100000 constant SDMMC1_MASK_TXDAVLIE                             \ Data available in Tx FIFO interrupt enable
$00200000 constant SDMMC1_MASK_RXDAVLIE                             \ Data available in Rx FIFO interrupt enable
$00400000 constant SDMMC1_MASK_SDIOITIE                             \ SDIO mode interrupt received interrupt enable
$00800000 constant SDMMC1_MASK_CEATAENDIE                           \ CE-ATA command completion signal received interrupt enable


\
\ @brief FIFO counter register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00ffffff constant SDMMC1_FIFOCNT_FIFOCOUNT                         \ Remaining number of words to be written to or read from the FIFO


\
\ @brief data FIFO register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant SDMMC1_FIFO_FIFODATA                             \ Receive and transmit FIFO data


\
\ @brief Secure digital input/output interface
\
$50062400 constant SDMMC1_POWER   \ offset: 0x00 : power control register
$50062404 constant SDMMC1_CLKCR   \ offset: 0x04 : SDI clock control register
$50062408 constant SDMMC1_ARG     \ offset: 0x08 : argument register
$5006240c constant SDMMC1_CMD     \ offset: 0x0C : command register
$50062410 constant SDMMC1_RESPCMD  \ offset: 0x10 : command response register
$50062414 constant SDMMC1_RESP1   \ offset: 0x14 : response 1..4 register
$50062418 constant SDMMC1_RESP2   \ offset: 0x18 : response 1..4 register
$5006241c constant SDMMC1_RESP3   \ offset: 0x1C : response 1..4 register
$50062420 constant SDMMC1_RESP4   \ offset: 0x20 : response 1..4 register
$50062424 constant SDMMC1_DTIMER  \ offset: 0x24 : data timer register
$50062428 constant SDMMC1_DLEN    \ offset: 0x28 : data length register
$5006242c constant SDMMC1_DCTRL   \ offset: 0x2C : data control register
$50062430 constant SDMMC1_DCOUNT  \ offset: 0x30 : data counter register
$50062434 constant SDMMC1_STA     \ offset: 0x34 : status register
$50062438 constant SDMMC1_ICR     \ offset: 0x38 : interrupt clear register
$5006243c constant SDMMC1_MASK    \ offset: 0x3C : mask register
$50062448 constant SDMMC1_FIFOCNT  \ offset: 0x48 : FIFO counter register
$50062480 constant SDMMC1_FIFO    \ offset: 0x80 : data FIFO register

