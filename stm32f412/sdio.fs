\
\ @file sdio.fs
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

$00000003 constant SDIO_POWER_PWRCTRL                               \ PWRCTRL


\
\ @brief SDI clock control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000000ff constant SDIO_CLKCR_CLKDIV                                \ Clock divide factor
$00000100 constant SDIO_CLKCR_CLKEN                                 \ Clock enable bit
$00000200 constant SDIO_CLKCR_PWRSAV                                \ Power saving configuration bit
$00000400 constant SDIO_CLKCR_BYPASS                                \ Clock divider bypass enable bit
$00001800 constant SDIO_CLKCR_WIDBUS                                \ Wide bus mode enable bit
$00002000 constant SDIO_CLKCR_NEGEDGE                               \ SDIO_CK dephasing selection bit
$00004000 constant SDIO_CLKCR_HWFC_EN                               \ HW Flow Control enable


\
\ @brief argument register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant SDIO_ARG_CMDARG                                  \ Command argument


\
\ @brief command register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000003f constant SDIO_CMD_CMDINDEX                                \ Command index
$000000c0 constant SDIO_CMD_WAITRESP                                \ Wait for response bits
$00000100 constant SDIO_CMD_WAITINT                                 \ CPSM waits for interrupt request
$00000200 constant SDIO_CMD_WAITPEND                                \ CPSM Waits for ends of data transfer (CmdPend internal signal).
$00000400 constant SDIO_CMD_CPSMEN                                  \ Command path state machine (CPSM) Enable bit
$00000800 constant SDIO_CMD_SDIOSUSPEND                             \ SD I/O suspend command
$00001000 constant SDIO_CMD_ENCMDCOMPL                              \ Enable CMD completion
$00002000 constant SDIO_CMD_NIEN                                    \ not Interrupt Enable
$00004000 constant SDIO_CMD_CE_ATACMD                               \ CE-ATA command


\
\ @brief command response register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000003f constant SDIO_RESPCMD_RESPCMD                             \ Response command index


\
\ @brief response 1..4 register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant SDIO_RESP1_CARDSTATUS1                           \ Card Status


\
\ @brief response 1..4 register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant SDIO_RESP2_CARDSTATUS2                           \ Card Status


\
\ @brief response 1..4 register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant SDIO_RESP3_CARDSTATUS3                           \ Card Status


\
\ @brief response 1..4 register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SDIO_RESP4_CARDSTATUS4                           \ Card Status


\
\ @brief data timer register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant SDIO_DTIMER_DATATIME                             \ Data timeout period


\
\ @brief data length register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$01ffffff constant SDIO_DLEN_DATALENGTH                             \ Data length value


\
\ @brief data control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant SDIO_DCTRL_DTEN                                  \ DTEN
$00000002 constant SDIO_DCTRL_DTDIR                                 \ Data transfer direction selection
$00000004 constant SDIO_DCTRL_DTMODE                                \ Data transfer mode selection 1: Stream or SDIO multibyte data transfer.
$00000008 constant SDIO_DCTRL_DMAEN                                 \ DMA enable bit
$000000f0 constant SDIO_DCTRL_DBLOCKSIZE                            \ Data block size
$00000100 constant SDIO_DCTRL_RWSTART                               \ Read wait start
$00000200 constant SDIO_DCTRL_RWSTOP                                \ Read wait stop
$00000400 constant SDIO_DCTRL_RWMOD                                 \ Read wait mode
$00000800 constant SDIO_DCTRL_SDIOEN                                \ SD I/O enable functions


\
\ @brief data counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$01ffffff constant SDIO_DCOUNT_DATACOUNT                            \ Data count value


\
\ @brief status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant SDIO_STA_CCRCFAIL                                \ Command response received (CRC check failed)
$00000002 constant SDIO_STA_DCRCFAIL                                \ Data block sent/received (CRC check failed)
$00000004 constant SDIO_STA_CTIMEOUT                                \ Command response timeout
$00000008 constant SDIO_STA_DTIMEOUT                                \ Data timeout
$00000010 constant SDIO_STA_TXUNDERR                                \ Transmit FIFO underrun error
$00000020 constant SDIO_STA_RXOVERR                                 \ Received FIFO overrun error
$00000040 constant SDIO_STA_CMDREND                                 \ Command response received (CRC check passed)
$00000080 constant SDIO_STA_CMDSENT                                 \ Command sent (no response required)
$00000100 constant SDIO_STA_DATAEND                                 \ Data end (data counter, SDIDCOUNT, is zero)
$00000200 constant SDIO_STA_STBITERR                                \ Start bit not detected on all data signals in wide bus mode
$00000400 constant SDIO_STA_DBCKEND                                 \ Data block sent/received (CRC check passed)
$00000800 constant SDIO_STA_CMDACT                                  \ Command transfer in progress
$00001000 constant SDIO_STA_TXACT                                   \ Data transmit in progress
$00002000 constant SDIO_STA_RXACT                                   \ Data receive in progress
$00004000 constant SDIO_STA_TXFIFOHE                                \ Transmit FIFO half empty: at least 8 words can be written into the FIFO
$00008000 constant SDIO_STA_RXFIFOHF                                \ Receive FIFO half full: there are at least 8 words in the FIFO
$00010000 constant SDIO_STA_TXFIFOF                                 \ Transmit FIFO full
$00020000 constant SDIO_STA_RXFIFOF                                 \ Receive FIFO full
$00040000 constant SDIO_STA_TXFIFOE                                 \ Transmit FIFO empty
$00080000 constant SDIO_STA_RXFIFOE                                 \ Receive FIFO empty
$00100000 constant SDIO_STA_TXDAVL                                  \ Data available in transmit FIFO
$00200000 constant SDIO_STA_RXDAVL                                  \ Data available in receive FIFO
$00400000 constant SDIO_STA_SDIOIT                                  \ SDIO interrupt received
$00800000 constant SDIO_STA_CEATAEND                                \ CE-ATA command completion signal received for CMD61


\
\ @brief interrupt clear register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant SDIO_ICR_CCRCFAILC                               \ CCRCFAIL flag clear bit
$00000002 constant SDIO_ICR_DCRCFAILC                               \ DCRCFAIL flag clear bit
$00000004 constant SDIO_ICR_CTIMEOUTC                               \ CTIMEOUT flag clear bit
$00000008 constant SDIO_ICR_DTIMEOUTC                               \ DTIMEOUT flag clear bit
$00000010 constant SDIO_ICR_TXUNDERRC                               \ TXUNDERR flag clear bit
$00000020 constant SDIO_ICR_RXOVERRC                                \ RXOVERR flag clear bit
$00000040 constant SDIO_ICR_CMDRENDC                                \ CMDREND flag clear bit
$00000080 constant SDIO_ICR_CMDSENTC                                \ CMDSENT flag clear bit
$00000100 constant SDIO_ICR_DATAENDC                                \ DATAEND flag clear bit
$00000200 constant SDIO_ICR_STBITERRC                               \ STBITERR flag clear bit
$00000400 constant SDIO_ICR_DBCKENDC                                \ DBCKEND flag clear bit
$00400000 constant SDIO_ICR_SDIOITC                                 \ SDIOIT flag clear bit
$00800000 constant SDIO_ICR_CEATAENDC                               \ CEATAEND flag clear bit


\
\ @brief mask register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant SDIO_MASK_CCRCFAILIE                             \ Command CRC fail interrupt enable
$00000002 constant SDIO_MASK_DCRCFAILIE                             \ Data CRC fail interrupt enable
$00000004 constant SDIO_MASK_CTIMEOUTIE                             \ Command timeout interrupt enable
$00000008 constant SDIO_MASK_DTIMEOUTIE                             \ Data timeout interrupt enable
$00000010 constant SDIO_MASK_TXUNDERRIE                             \ Tx FIFO underrun error interrupt enable
$00000020 constant SDIO_MASK_RXOVERRIE                              \ Rx FIFO overrun error interrupt enable
$00000040 constant SDIO_MASK_CMDRENDIE                              \ Command response received interrupt enable
$00000080 constant SDIO_MASK_CMDSENTIE                              \ Command sent interrupt enable
$00000100 constant SDIO_MASK_DATAENDIE                              \ Data end interrupt enable
$00000200 constant SDIO_MASK_STBITERRIE                             \ Start bit error interrupt enable
$00000400 constant SDIO_MASK_DBCKENDIE                              \ Data block end interrupt enable
$00000800 constant SDIO_MASK_CMDACTIE                               \ Command acting interrupt enable
$00001000 constant SDIO_MASK_TXACTIE                                \ Data transmit acting interrupt enable
$00002000 constant SDIO_MASK_RXACTIE                                \ Data receive acting interrupt enable
$00004000 constant SDIO_MASK_TXFIFOHEIE                             \ Tx FIFO half empty interrupt enable
$00008000 constant SDIO_MASK_RXFIFOHFIE                             \ Rx FIFO half full interrupt enable
$00010000 constant SDIO_MASK_TXFIFOFIE                              \ Tx FIFO full interrupt enable
$00020000 constant SDIO_MASK_RXFIFOFIE                              \ Rx FIFO full interrupt enable
$00040000 constant SDIO_MASK_TXFIFOEIE                              \ Tx FIFO empty interrupt enable
$00080000 constant SDIO_MASK_RXFIFOEIE                              \ Rx FIFO empty interrupt enable
$00100000 constant SDIO_MASK_TXDAVLIE                               \ Data available in Tx FIFO interrupt enable
$00200000 constant SDIO_MASK_RXDAVLIE                               \ Data available in Rx FIFO interrupt enable
$00400000 constant SDIO_MASK_SDIOITIE                               \ SDIO mode interrupt received interrupt enable
$00800000 constant SDIO_MASK_CEATAENDIE                             \ CE-ATA command completion signal received interrupt enable


\
\ @brief FIFO counter register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00ffffff constant SDIO_FIFOCNT_FIFOCOUNT                           \ Remaining number of words to be written to or read from the FIFO.


\
\ @brief data FIFO register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant SDIO_FIFO_FIFODATA                               \ Receive and transmit FIFO data


\
\ @brief Secure digital input/output interface
\
$40012c00 constant SDIO_POWER     \ offset: 0x00 : power control register
$40012c04 constant SDIO_CLKCR     \ offset: 0x04 : SDI clock control register
$40012c08 constant SDIO_ARG       \ offset: 0x08 : argument register
$40012c0c constant SDIO_CMD       \ offset: 0x0C : command register
$40012c10 constant SDIO_RESPCMD   \ offset: 0x10 : command response register
$40012c14 constant SDIO_RESP1     \ offset: 0x14 : response 1..4 register
$40012c18 constant SDIO_RESP2     \ offset: 0x18 : response 1..4 register
$40012c1c constant SDIO_RESP3     \ offset: 0x1C : response 1..4 register
$40012c20 constant SDIO_RESP4     \ offset: 0x20 : response 1..4 register
$40012c24 constant SDIO_DTIMER    \ offset: 0x24 : data timer register
$40012c28 constant SDIO_DLEN      \ offset: 0x28 : data length register
$40012c2c constant SDIO_DCTRL     \ offset: 0x2C : data control register
$40012c30 constant SDIO_DCOUNT    \ offset: 0x30 : data counter register
$40012c34 constant SDIO_STA       \ offset: 0x34 : status register
$40012c38 constant SDIO_ICR       \ offset: 0x38 : interrupt clear register
$40012c3c constant SDIO_MASK      \ offset: 0x3C : mask register
$40012c48 constant SDIO_FIFOCNT   \ offset: 0x48 : FIFO counter register
$40012c80 constant SDIO_FIFO      \ offset: 0x80 : data FIFO register

