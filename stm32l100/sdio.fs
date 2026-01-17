\
\ @file sdio.fs
\ @brief Secure digital input/output interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SDIO_DEF

  [ifdef] SDIO_POWER_DEF
    \
    \ @brief power control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_PWRCTRL                   \ [0x00 : 2] Power supply control bits.
  [then]


  [ifdef] SDIO_CLKCR_DEF
    \
    \ @brief SDI clock control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_CLKDIV                    \ [0x00 : 8] Clock divide factor
    $08 constant SDIO_CLKEN                     \ [0x08] Clock enable bit
    $09 constant SDIO_PWRSAV                    \ [0x09] Power saving configuration bit
    $0a constant SDIO_BYPASS                    \ [0x0a] Clock divider bypass enable bit
    $0b constant SDIO_WIDBUS                    \ [0x0b : 2] Wide bus mode enable bit
    $0d constant SDIO_NEGEDGE                   \ [0x0d] SDIO_CK dephasing selection bit
    $0e constant SDIO_HWFC_EN                   \ [0x0e] HW Flow Control enable
  [then]


  [ifdef] SDIO_ARG_DEF
    \
    \ @brief argument register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_CMDARG                    \ [0x00 : 32] Command argument
  [then]


  [ifdef] SDIO_CMD_DEF
    \
    \ @brief command register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_CMDINDEX                  \ [0x00 : 6] Command index
    $06 constant SDIO_WAITRESP                  \ [0x06 : 2] Wait for response bits
    $08 constant SDIO_WAITINT                   \ [0x08] CPSM waits for interrupt request
    $09 constant SDIO_WAITPEND                  \ [0x09] CPSM Waits for ends of data transfer (CmdPend internal signal).
    $0a constant SDIO_CPSMEN                    \ [0x0a] Command path state machine (CPSM) Enable bit
    $0b constant SDIO_SDIOSuspend               \ [0x0b] SD I/O suspend command
    $0c constant SDIO_ENCMDcompl                \ [0x0c] Enable CMD completion
    $0d constant SDIO_nIEN                      \ [0x0d] not Interrupt Enable
    $0e constant SDIO_CE_ATACMD                 \ [0x0e] CE-ATA command
  [then]


  [ifdef] SDIO_RESPCMD_DEF
    \
    \ @brief command response register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_RESPCMD                   \ [0x00 : 6] Response command index
  [then]


  [ifdef] SDIO_RESP1_DEF
    \
    \ @brief response 1..4 register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_CARDSTATUS1               \ [0x00 : 32] see Table 133.
  [then]


  [ifdef] SDIO_RESP2_DEF
    \
    \ @brief response 1..4 register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_CARDSTATUS2               \ [0x00 : 32] see Table 133.
  [then]


  [ifdef] SDIO_RESP3_DEF
    \
    \ @brief response 1..4 register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_CARDSTATUS3               \ [0x00 : 32] see Table 133.
  [then]


  [ifdef] SDIO_RESP4_DEF
    \
    \ @brief response 1..4 register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_CARDSTATUS4               \ [0x00 : 32] see Table 133.
  [then]


  [ifdef] SDIO_DTIMER_DEF
    \
    \ @brief data timer register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_DATATIME                  \ [0x00 : 32] Data timeout period
  [then]


  [ifdef] SDIO_DLEN_DEF
    \
    \ @brief data length register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_DATALENGTH                \ [0x00 : 25] Data length value
  [then]


  [ifdef] SDIO_DCTRL_DEF
    \
    \ @brief data control register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_DTEN                      \ [0x00] Data transfer enabled bit
    $01 constant SDIO_DTDIR                     \ [0x01] Data transfer direction selection
    $02 constant SDIO_DTMODE                    \ [0x02] Data transfer mode selection 1: Stream or SDIO multibyte data transfer.
    $03 constant SDIO_DMAEN                     \ [0x03] DMA enable bit
    $04 constant SDIO_DBLOCKSIZE                \ [0x04 : 4] Data block size
    $08 constant SDIO_RWSTART                   \ [0x08] Read wait start
    $09 constant SDIO_RWSTOP                    \ [0x09] Read wait stop
    $0a constant SDIO_RWMOD                     \ [0x0a] Read wait mode
    $0b constant SDIO_SDIOEN                    \ [0x0b] SD I/O enable functions
  [then]


  [ifdef] SDIO_DCOUNT_DEF
    \
    \ @brief data counter register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_DATACOUNT                 \ [0x00 : 25] Data count value
  [then]


  [ifdef] SDIO_STA_DEF
    \
    \ @brief status register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_CCRCFAIL                  \ [0x00] Command response received (CRC check failed)
    $01 constant SDIO_DCRCFAIL                  \ [0x01] Data block sent/received (CRC check failed)
    $02 constant SDIO_CTIMEOUT                  \ [0x02] Command response timeout
    $03 constant SDIO_DTIMEOUT                  \ [0x03] Data timeout
    $04 constant SDIO_TXUNDERR                  \ [0x04] Transmit FIFO underrun error
    $05 constant SDIO_RXOVERR                   \ [0x05] Received FIFO overrun error
    $06 constant SDIO_CMDREND                   \ [0x06] Command response received (CRC check passed)
    $07 constant SDIO_CMDSENT                   \ [0x07] Command sent (no response required)
    $08 constant SDIO_DATAEND                   \ [0x08] Data end (data counter, SDIDCOUNT, is zero)
    $09 constant SDIO_STBITERR                  \ [0x09] Start bit not detected on all data signals in wide bus mode
    $0a constant SDIO_DBCKEND                   \ [0x0a] Data block sent/received (CRC check passed)
    $0b constant SDIO_CMDACT                    \ [0x0b] Command transfer in progress
    $0c constant SDIO_TXACT                     \ [0x0c] Data transmit in progress
    $0d constant SDIO_RXACT                     \ [0x0d] Data receive in progress
    $0e constant SDIO_TXFIFOHE                  \ [0x0e] Transmit FIFO half empty: at least 8 words can be written into the FIFO
    $0f constant SDIO_RXFIFOHF                  \ [0x0f] Receive FIFO half full: there are at least 8 words in the FIFO
    $10 constant SDIO_TXFIFOF                   \ [0x10] Transmit FIFO full
    $11 constant SDIO_RXFIFOF                   \ [0x11] Receive FIFO full
    $12 constant SDIO_TXFIFOE                   \ [0x12] Transmit FIFO empty
    $13 constant SDIO_RXFIFOE                   \ [0x13] Receive FIFO empty
    $14 constant SDIO_TXDAVL                    \ [0x14] Data available in transmit FIFO
    $15 constant SDIO_RXDAVL                    \ [0x15] Data available in receive FIFO
    $16 constant SDIO_SDIOIT                    \ [0x16] SDIO interrupt received
    $17 constant SDIO_CEATAEND                  \ [0x17] CE-ATA command completion signal received for CMD61
  [then]


  [ifdef] SDIO_ICR_DEF
    \
    \ @brief interrupt clear register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_CCRCFAILC                 \ [0x00] CCRCFAIL flag clear bit
    $01 constant SDIO_DCRCFAILC                 \ [0x01] DCRCFAIL flag clear bit
    $02 constant SDIO_CTIMEOUTC                 \ [0x02] CTIMEOUT flag clear bit
    $03 constant SDIO_DTIMEOUTC                 \ [0x03] DTIMEOUT flag clear bit
    $04 constant SDIO_TXUNDERRC                 \ [0x04] TXUNDERR flag clear bit
    $05 constant SDIO_RXOVERRC                  \ [0x05] RXOVERR flag clear bit
    $06 constant SDIO_CMDRENDC                  \ [0x06] CMDREND flag clear bit
    $07 constant SDIO_CMDSENTC                  \ [0x07] CMDSENT flag clear bit
    $08 constant SDIO_DATAENDC                  \ [0x08] DATAEND flag clear bit
    $09 constant SDIO_STBITERRC                 \ [0x09] STBITERR flag clear bit
    $0a constant SDIO_DBCKENDC                  \ [0x0a] DBCKEND flag clear bit
    $16 constant SDIO_SDIOITC                   \ [0x16] SDIOIT flag clear bit
    $17 constant SDIO_CEATAENDC                 \ [0x17] CEATAEND flag clear bit
  [then]


  [ifdef] SDIO_MASK_DEF
    \
    \ @brief mask register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_CCRCFAILIE                \ [0x00] Command CRC fail interrupt enable
    $01 constant SDIO_DCRCFAILIE                \ [0x01] Data CRC fail interrupt enable
    $02 constant SDIO_CTIMEOUTIE                \ [0x02] Command timeout interrupt enable
    $03 constant SDIO_DTIMEOUTIE                \ [0x03] Data timeout interrupt enable
    $04 constant SDIO_TXUNDERRIE                \ [0x04] Tx FIFO underrun error interrupt enable
    $05 constant SDIO_RXOVERRIE                 \ [0x05] Rx FIFO overrun error interrupt enable
    $06 constant SDIO_CMDRENDIE                 \ [0x06] Command response received interrupt enable
    $07 constant SDIO_CMDSENTIE                 \ [0x07] Command sent interrupt enable
    $08 constant SDIO_DATAENDIE                 \ [0x08] Data end interrupt enable
    $09 constant SDIO_STBITERRIE                \ [0x09] Start bit error interrupt enable
    $0a constant SDIO_DBCKENDIE                 \ [0x0a] Data block end interrupt enable
    $0b constant SDIO_CMDACTIE                  \ [0x0b] Command acting interrupt enable
    $0c constant SDIO_TXACTIE                   \ [0x0c] Data transmit acting interrupt enable
    $0d constant SDIO_RXACTIE                   \ [0x0d] Data receive acting interrupt enable
    $0e constant SDIO_TXFIFOHEIE                \ [0x0e] Tx FIFO half empty interrupt enable
    $0f constant SDIO_RXFIFOHFIE                \ [0x0f] Rx FIFO half full interrupt enable
    $10 constant SDIO_TXFIFOFIE                 \ [0x10] Tx FIFO full interrupt enable
    $11 constant SDIO_RXFIFOFIE                 \ [0x11] Rx FIFO full interrupt enable
    $12 constant SDIO_TXFIFOEIE                 \ [0x12] Tx FIFO empty interrupt enable
    $13 constant SDIO_RXFIFOEIE                 \ [0x13] Rx FIFO empty interrupt enable
    $14 constant SDIO_TXDAVLIE                  \ [0x14] Data available in Tx FIFO interrupt enable
    $15 constant SDIO_RXDAVLIE                  \ [0x15] Data available in Rx FIFO interrupt enable
    $16 constant SDIO_SDIOITIE                  \ [0x16] SDIO mode interrupt received interrupt enable
    $17 constant SDIO_CEATAENDIE                \ [0x17] CE-ATA command completion signal received interrupt enable
  [then]


  [ifdef] SDIO_FIFOCNT_DEF
    \
    \ @brief FIFO counter register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_FIFOCOUNT                 \ [0x00 : 24] Remaining number of words to be written to or read from the FIFO.
  [then]


  [ifdef] SDIO_FIFO_DEF
    \
    \ @brief data FIFO register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_FIF0Data                  \ [0x00 : 32] FIF0Data
  [then]

  \
  \ @brief Secure digital input/output interface
  \
  $00 constant SDIO_POWER               \ power control register
  $04 constant SDIO_CLKCR               \ SDI clock control register
  $08 constant SDIO_ARG                 \ argument register
  $0C constant SDIO_CMD                 \ command register
  $10 constant SDIO_RESPCMD             \ command response register
  $14 constant SDIO_RESP1               \ response 1..4 register
  $18 constant SDIO_RESP2               \ response 1..4 register
  $1C constant SDIO_RESP3               \ response 1..4 register
  $20 constant SDIO_RESP4               \ response 1..4 register
  $24 constant SDIO_DTIMER              \ data timer register
  $28 constant SDIO_DLEN                \ data length register
  $2C constant SDIO_DCTRL               \ data control register
  $30 constant SDIO_DCOUNT              \ data counter register
  $34 constant SDIO_STA                 \ status register
  $38 constant SDIO_ICR                 \ interrupt clear register
  $3C constant SDIO_MASK                \ mask register
  $48 constant SDIO_FIFOCNT             \ FIFO counter register
  $80 constant SDIO_FIFO                \ data FIFO register

: SDIO_DEF ; [then]
