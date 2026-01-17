\
\ @file sdmmc1.fs
\ @brief Secure digital input/output interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SDMMC1_DEF

  [ifdef] SDMMC1_POWER_DEF
    \
    \ @brief power control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC1_PWRCTRL                 \ [0x00 : 2] PWRCTRL
  [then]


  [ifdef] SDMMC1_CLKCR_DEF
    \
    \ @brief SDI clock control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC1_CLKDIV                  \ [0x00 : 8] Clock divide factor
    $08 constant SDMMC1_CLKEN                   \ [0x08] Clock enable bit
    $09 constant SDMMC1_PWRSAV                  \ [0x09] Power saving configuration bit
    $0a constant SDMMC1_BYPASS                  \ [0x0a] Clock divider bypass enable bit
    $0b constant SDMMC1_WIDBUS                  \ [0x0b : 2] Wide bus mode enable bit
    $0d constant SDMMC1_NEGEDGE                 \ [0x0d] SDIO_CK dephasing selection bit
    $0e constant SDMMC1_HWFC_EN                 \ [0x0e] HW Flow Control enable
  [then]


  [ifdef] SDMMC1_ARG_DEF
    \
    \ @brief argument register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC1_CMDARG                  \ [0x00 : 32] Command argument
  [then]


  [ifdef] SDMMC1_CMD_DEF
    \
    \ @brief command register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC1_CMDINDEX                \ [0x00 : 6] Command index
    $06 constant SDMMC1_WAITRESP                \ [0x06 : 2] Wait for response bits
    $08 constant SDMMC1_WAITINT                 \ [0x08] CPSM waits for interrupt request
    $09 constant SDMMC1_WAITPEND                \ [0x09] CPSM Waits for ends of data transfer (CmdPend internal signal)
    $0a constant SDMMC1_CPSMEN                  \ [0x0a] Command path state machine (CPSM) Enable bit
    $0b constant SDMMC1_SDIOSuspend             \ [0x0b] SD I/O suspend command
    $0c constant SDMMC1_ENCMDcompl              \ [0x0c] Enable CMD completion
    $0d constant SDMMC1_nIEN                    \ [0x0d] not Interrupt Enable
    $0e constant SDMMC1_CE_ATACMD               \ [0x0e] CE-ATA command
  [then]


  [ifdef] SDMMC1_RESPCMD_DEF
    \
    \ @brief command response register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC1_RESPCMD                 \ [0x00 : 6] Response command index
  [then]


  [ifdef] SDMMC1_RESP1_DEF
    \
    \ @brief response 1..4 register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC1_CARDSTATUS1             \ [0x00 : 32] see Table 132
  [then]


  [ifdef] SDMMC1_RESP2_DEF
    \
    \ @brief response 1..4 register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC1_CARDSTATUS2             \ [0x00 : 32] see Table 132
  [then]


  [ifdef] SDMMC1_RESP3_DEF
    \
    \ @brief response 1..4 register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC1_CARDSTATUS3             \ [0x00 : 32] see Table 132
  [then]


  [ifdef] SDMMC1_RESP4_DEF
    \
    \ @brief response 1..4 register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC1_CARDSTATUS4             \ [0x00 : 32] see Table 132
  [then]


  [ifdef] SDMMC1_DTIMER_DEF
    \
    \ @brief data timer register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC1_DATATIME                \ [0x00 : 32] Data timeout period
  [then]


  [ifdef] SDMMC1_DLEN_DEF
    \
    \ @brief data length register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC1_DATALENGTH              \ [0x00 : 25] Data length value
  [then]


  [ifdef] SDMMC1_DCTRL_DEF
    \
    \ @brief data control register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC1_DTEN                    \ [0x00] DTEN
    $01 constant SDMMC1_DTDIR                   \ [0x01] Data transfer direction selection
    $02 constant SDMMC1_DTMODE                  \ [0x02] Data transfer mode selection 1: Stream or SDIO multibyte data transfer
    $03 constant SDMMC1_DMAEN                   \ [0x03] DMA enable bit
    $04 constant SDMMC1_DBLOCKSIZE              \ [0x04 : 4] Data block size
    $08 constant SDMMC1_RWSTART                 \ [0x08] Read wait start
    $09 constant SDMMC1_RWSTOP                  \ [0x09] Read wait stop
    $0a constant SDMMC1_RWMOD                   \ [0x0a] Read wait mode
    $0b constant SDMMC1_SDIOEN                  \ [0x0b] SD I/O enable functions
  [then]


  [ifdef] SDMMC1_DCOUNT_DEF
    \
    \ @brief data counter register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC1_DATACOUNT               \ [0x00 : 25] Data count value
  [then]


  [ifdef] SDMMC1_STA_DEF
    \
    \ @brief status register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC1_CCRCFAIL                \ [0x00] Command response received (CRC check failed)
    $01 constant SDMMC1_DCRCFAIL                \ [0x01] Data block sent/received (CRC check failed)
    $02 constant SDMMC1_CTIMEOUT                \ [0x02] Command response timeout
    $03 constant SDMMC1_DTIMEOUT                \ [0x03] Data timeout
    $04 constant SDMMC1_TXUNDERR                \ [0x04] Transmit FIFO underrun error
    $05 constant SDMMC1_RXOVERR                 \ [0x05] Received FIFO overrun error
    $06 constant SDMMC1_CMDREND                 \ [0x06] Command response received (CRC check passed)
    $07 constant SDMMC1_CMDSENT                 \ [0x07] Command sent (no response required)
    $08 constant SDMMC1_DATAEND                 \ [0x08] Data end (data counter, SDIDCOUNT, is zero)
    $09 constant SDMMC1_STBITERR                \ [0x09] Start bit not detected on all data signals in wide bus mode
    $0a constant SDMMC1_DBCKEND                 \ [0x0a] Data block sent/received (CRC check passed)
    $0b constant SDMMC1_CMDACT                  \ [0x0b] Command transfer in progress
    $0c constant SDMMC1_TXACT                   \ [0x0c] Data transmit in progress
    $0d constant SDMMC1_RXACT                   \ [0x0d] Data receive in progress
    $0e constant SDMMC1_TXFIFOHE                \ [0x0e] Transmit FIFO half empty: at least 8 words can be written into the FIFO
    $0f constant SDMMC1_RXFIFOHF                \ [0x0f] Receive FIFO half full: there are at least 8 words in the FIFO
    $10 constant SDMMC1_TXFIFOF                 \ [0x10] Transmit FIFO full
    $11 constant SDMMC1_RXFIFOF                 \ [0x11] Receive FIFO full
    $12 constant SDMMC1_TXFIFOE                 \ [0x12] Transmit FIFO empty
    $13 constant SDMMC1_RXFIFOE                 \ [0x13] Receive FIFO empty
    $14 constant SDMMC1_TXDAVL                  \ [0x14] Data available in transmit FIFO
    $15 constant SDMMC1_RXDAVL                  \ [0x15] Data available in receive FIFO
    $16 constant SDMMC1_SDIOIT                  \ [0x16] SDIO interrupt received
    $17 constant SDMMC1_CEATAEND                \ [0x17] CE-ATA command completion signal received for CMD61
  [then]


  [ifdef] SDMMC1_ICR_DEF
    \
    \ @brief interrupt clear register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC1_CCRCFAILC               \ [0x00] CCRCFAIL flag clear bit
    $01 constant SDMMC1_DCRCFAILC               \ [0x01] DCRCFAIL flag clear bit
    $02 constant SDMMC1_CTIMEOUTC               \ [0x02] CTIMEOUT flag clear bit
    $03 constant SDMMC1_DTIMEOUTC               \ [0x03] DTIMEOUT flag clear bit
    $04 constant SDMMC1_TXUNDERRC               \ [0x04] TXUNDERR flag clear bit
    $05 constant SDMMC1_RXOVERRC                \ [0x05] RXOVERR flag clear bit
    $06 constant SDMMC1_CMDRENDC                \ [0x06] CMDREND flag clear bit
    $07 constant SDMMC1_CMDSENTC                \ [0x07] CMDSENT flag clear bit
    $08 constant SDMMC1_DATAENDC                \ [0x08] DATAEND flag clear bit
    $09 constant SDMMC1_STBITERRC               \ [0x09] STBITERR flag clear bit
    $0a constant SDMMC1_DBCKENDC                \ [0x0a] DBCKEND flag clear bit
    $16 constant SDMMC1_SDIOITC                 \ [0x16] SDIOIT flag clear bit
    $17 constant SDMMC1_CEATAENDC               \ [0x17] CEATAEND flag clear bit
  [then]


  [ifdef] SDMMC1_MASK_DEF
    \
    \ @brief mask register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC1_CCRCFAILIE              \ [0x00] Command CRC fail interrupt enable
    $01 constant SDMMC1_DCRCFAILIE              \ [0x01] Data CRC fail interrupt enable
    $02 constant SDMMC1_CTIMEOUTIE              \ [0x02] Command timeout interrupt enable
    $03 constant SDMMC1_DTIMEOUTIE              \ [0x03] Data timeout interrupt enable
    $04 constant SDMMC1_TXUNDERRIE              \ [0x04] Tx FIFO underrun error interrupt enable
    $05 constant SDMMC1_RXOVERRIE               \ [0x05] Rx FIFO overrun error interrupt enable
    $06 constant SDMMC1_CMDRENDIE               \ [0x06] Command response received interrupt enable
    $07 constant SDMMC1_CMDSENTIE               \ [0x07] Command sent interrupt enable
    $08 constant SDMMC1_DATAENDIE               \ [0x08] Data end interrupt enable
    $09 constant SDMMC1_STBITERRIE              \ [0x09] Start bit error interrupt enable
    $0a constant SDMMC1_DBCKENDIE               \ [0x0a] Data block end interrupt enable
    $0b constant SDMMC1_CMDACTIE                \ [0x0b] Command acting interrupt enable
    $0c constant SDMMC1_TXACTIE                 \ [0x0c] Data transmit acting interrupt enable
    $0d constant SDMMC1_RXACTIE                 \ [0x0d] Data receive acting interrupt enable
    $0e constant SDMMC1_TXFIFOHEIE              \ [0x0e] Tx FIFO half empty interrupt enable
    $0f constant SDMMC1_RXFIFOHFIE              \ [0x0f] Rx FIFO half full interrupt enable
    $10 constant SDMMC1_TXFIFOFIE               \ [0x10] Tx FIFO full interrupt enable
    $11 constant SDMMC1_RXFIFOFIE               \ [0x11] Rx FIFO full interrupt enable
    $12 constant SDMMC1_TXFIFOEIE               \ [0x12] Tx FIFO empty interrupt enable
    $13 constant SDMMC1_RXFIFOEIE               \ [0x13] Rx FIFO empty interrupt enable
    $14 constant SDMMC1_TXDAVLIE                \ [0x14] Data available in Tx FIFO interrupt enable
    $15 constant SDMMC1_RXDAVLIE                \ [0x15] Data available in Rx FIFO interrupt enable
    $16 constant SDMMC1_SDIOITIE                \ [0x16] SDIO mode interrupt received interrupt enable
    $17 constant SDMMC1_CEATAENDIE              \ [0x17] CE-ATA command completion signal received interrupt enable
  [then]


  [ifdef] SDMMC1_FIFOCNT_DEF
    \
    \ @brief FIFO counter register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC1_FIFOCOUNT               \ [0x00 : 24] Remaining number of words to be written to or read from the FIFO
  [then]


  [ifdef] SDMMC1_FIFO_DEF
    \
    \ @brief data FIFO register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC1_FIFOData                \ [0x00 : 32] Receive and transmit FIFO data
  [then]

  \
  \ @brief Secure digital input/output interface
  \
  $00 constant SDMMC1_POWER             \ power control register
  $04 constant SDMMC1_CLKCR             \ SDI clock control register
  $08 constant SDMMC1_ARG               \ argument register
  $0C constant SDMMC1_CMD               \ command register
  $10 constant SDMMC1_RESPCMD           \ command response register
  $14 constant SDMMC1_RESP1             \ response 1..4 register
  $18 constant SDMMC1_RESP2             \ response 1..4 register
  $1C constant SDMMC1_RESP3             \ response 1..4 register
  $20 constant SDMMC1_RESP4             \ response 1..4 register
  $24 constant SDMMC1_DTIMER            \ data timer register
  $28 constant SDMMC1_DLEN              \ data length register
  $2C constant SDMMC1_DCTRL             \ data control register
  $30 constant SDMMC1_DCOUNT            \ data counter register
  $34 constant SDMMC1_STA               \ status register
  $38 constant SDMMC1_ICR               \ interrupt clear register
  $3C constant SDMMC1_MASK              \ mask register
  $48 constant SDMMC1_FIFOCNT           \ FIFO counter register
  $80 constant SDMMC1_FIFO              \ data FIFO register

: SDMMC1_DEF ; [then]
