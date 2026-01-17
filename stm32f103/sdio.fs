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
    \ @brief Bits 1:0 = PWRCTRL: Power supply control bits
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_PWRCTRL                   \ [0x00 : 2] PWRCTRL
  [then]


  [ifdef] SDIO_CLKCR_DEF
    \
    \ @brief SDI clock control register (SDIO_CLKCR)
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
    \ @brief Bits 31:0 = : Command argument
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_CMDARG                    \ [0x00 : 32] Command argument
  [then]


  [ifdef] SDIO_CMD_DEF
    \
    \ @brief SDIO command register (SDIO_CMD)
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_CMDINDEX                  \ [0x00 : 6] CMDINDEX
    $06 constant SDIO_WAITRESP                  \ [0x06 : 2] WAITRESP
    $08 constant SDIO_WAITINT                   \ [0x08] WAITINT
    $09 constant SDIO_WAITPEND                  \ [0x09] WAITPEND
    $0a constant SDIO_CPSMEN                    \ [0x0a] CPSMEN
    $0b constant SDIO_SDIOSuspend               \ [0x0b] SDIOSuspend
    $0c constant SDIO_ENCMDcompl                \ [0x0c] ENCMDcompl
    $0d constant SDIO_nIEN                      \ [0x0d] nIEN
    $0e constant SDIO_CE_ATACMD                 \ [0x0e] CE_ATACMD
  [then]


  [ifdef] SDIO_RESPCMD_DEF
    \
    \ @brief SDIO command register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_RESPCMD                   \ [0x00 : 6] RESPCMD
  [then]


  [ifdef] SDIO_RESPI1_DEF
    \
    \ @brief Bits 31:0 = CARDSTATUS1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_CARDSTATUS1               \ [0x00 : 32] CARDSTATUS1
  [then]


  [ifdef] SDIO_RESP2_DEF
    \
    \ @brief Bits 31:0 = CARDSTATUS2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_CARDSTATUS2               \ [0x00 : 32] CARDSTATUS2
  [then]


  [ifdef] SDIO_RESP3_DEF
    \
    \ @brief Bits 31:0 = CARDSTATUS3
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_CARDSTATUS3               \ [0x00 : 32] CARDSTATUS3
  [then]


  [ifdef] SDIO_RESP4_DEF
    \
    \ @brief Bits 31:0 = CARDSTATUS4
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_CARDSTATUS4               \ [0x00 : 32] CARDSTATUS4
  [then]


  [ifdef] SDIO_DTIMER_DEF
    \
    \ @brief Bits 31:0 = DATATIME: Data timeout period
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_DATATIME                  \ [0x00 : 32] Data timeout period
  [then]


  [ifdef] SDIO_DLEN_DEF
    \
    \ @brief Bits 24:0 = DATALENGTH: Data length value
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_DATALENGTH                \ [0x00 : 25] Data length value
  [then]


  [ifdef] SDIO_DCTRL_DEF
    \
    \ @brief SDIO data control register (SDIO_DCTRL)
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_DTEN                      \ [0x00] DTEN
    $01 constant SDIO_DTDIR                     \ [0x01] DTDIR
    $02 constant SDIO_DTMODE                    \ [0x02] DTMODE
    $03 constant SDIO_DMAEN                     \ [0x03] DMAEN
    $04 constant SDIO_DBLOCKSIZE                \ [0x04 : 4] DBLOCKSIZE
    $08 constant SDIO_PWSTART                   \ [0x08] PWSTART
    $09 constant SDIO_PWSTOP                    \ [0x09] PWSTOP
    $0a constant SDIO_RWMOD                     \ [0x0a] RWMOD
    $0b constant SDIO_SDIOEN                    \ [0x0b] SDIOEN
  [then]


  [ifdef] SDIO_DCOUNT_DEF
    \
    \ @brief Bits 24:0 = DATACOUNT: Data count value
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_DATACOUNT                 \ [0x00 : 25] Data count value
  [then]


  [ifdef] SDIO_STA_DEF
    \
    \ @brief SDIO status register (SDIO_STA)
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_CCRCFAIL                  \ [0x00] CCRCFAIL
    $01 constant SDIO_DCRCFAIL                  \ [0x01] DCRCFAIL
    $02 constant SDIO_CTIMEOUT                  \ [0x02] CTIMEOUT
    $03 constant SDIO_DTIMEOUT                  \ [0x03] DTIMEOUT
    $04 constant SDIO_TXUNDERR                  \ [0x04] TXUNDERR
    $05 constant SDIO_RXOVERR                   \ [0x05] RXOVERR
    $06 constant SDIO_CMDREND                   \ [0x06] CMDREND
    $07 constant SDIO_CMDSENT                   \ [0x07] CMDSENT
    $08 constant SDIO_DATAEND                   \ [0x08] DATAEND
    $09 constant SDIO_STBITERR                  \ [0x09] STBITERR
    $0a constant SDIO_DBCKEND                   \ [0x0a] DBCKEND
    $0b constant SDIO_CMDACT                    \ [0x0b] CMDACT
    $0c constant SDIO_TXACT                     \ [0x0c] TXACT
    $0d constant SDIO_RXACT                     \ [0x0d] RXACT
    $0e constant SDIO_TXFIFOHE                  \ [0x0e] TXFIFOHE
    $0f constant SDIO_RXFIFOHF                  \ [0x0f] RXFIFOHF
    $10 constant SDIO_TXFIFOF                   \ [0x10] TXFIFOF
    $11 constant SDIO_RXFIFOF                   \ [0x11] RXFIFOF
    $12 constant SDIO_TXFIFOE                   \ [0x12] TXFIFOE
    $13 constant SDIO_RXFIFOE                   \ [0x13] RXFIFOE
    $14 constant SDIO_TXDAVL                    \ [0x14] TXDAVL
    $15 constant SDIO_RXDAVL                    \ [0x15] RXDAVL
    $16 constant SDIO_SDIOIT                    \ [0x16] SDIOIT
    $17 constant SDIO_CEATAEND                  \ [0x17] CEATAEND
  [then]


  [ifdef] SDIO_ICR_DEF
    \
    \ @brief SDIO interrupt clear register (SDIO_ICR)
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_CCRCFAILC                 \ [0x00] CCRCFAILC
    $01 constant SDIO_DCRCFAILC                 \ [0x01] DCRCFAILC
    $02 constant SDIO_CTIMEOUTC                 \ [0x02] CTIMEOUTC
    $03 constant SDIO_DTIMEOUTC                 \ [0x03] DTIMEOUTC
    $04 constant SDIO_TXUNDERRC                 \ [0x04] TXUNDERRC
    $05 constant SDIO_RXOVERRC                  \ [0x05] RXOVERRC
    $06 constant SDIO_CMDRENDC                  \ [0x06] CMDRENDC
    $07 constant SDIO_CMDSENTC                  \ [0x07] CMDSENTC
    $08 constant SDIO_DATAENDC                  \ [0x08] DATAENDC
    $09 constant SDIO_STBITERRC                 \ [0x09] STBITERRC
    $0a constant SDIO_DBCKENDC                  \ [0x0a] DBCKENDC
    $16 constant SDIO_SDIOITC                   \ [0x16] SDIOITC
    $17 constant SDIO_CEATAENDC                 \ [0x17] CEATAENDC
  [then]


  [ifdef] SDIO_MASK_DEF
    \
    \ @brief SDIO mask register (SDIO_MASK)
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_CCRCFAILIE                \ [0x00] CCRCFAILIE
    $01 constant SDIO_DCRCFAILIE                \ [0x01] DCRCFAILIE
    $02 constant SDIO_CTIMEOUTIE                \ [0x02] CTIMEOUTIE
    $03 constant SDIO_DTIMEOUTIE                \ [0x03] DTIMEOUTIE
    $04 constant SDIO_TXUNDERRIE                \ [0x04] TXUNDERRIE
    $05 constant SDIO_RXOVERRIE                 \ [0x05] RXOVERRIE
    $06 constant SDIO_CMDRENDIE                 \ [0x06] CMDRENDIE
    $07 constant SDIO_CMDSENTIE                 \ [0x07] CMDSENTIE
    $08 constant SDIO_DATAENDIE                 \ [0x08] DATAENDIE
    $09 constant SDIO_STBITERRIE                \ [0x09] STBITERRIE
    $0a constant SDIO_DBACKENDIE                \ [0x0a] DBACKENDIE
    $0b constant SDIO_CMDACTIE                  \ [0x0b] CMDACTIE
    $0c constant SDIO_TXACTIE                   \ [0x0c] TXACTIE
    $0d constant SDIO_RXACTIE                   \ [0x0d] RXACTIE
    $0e constant SDIO_TXFIFOHEIE                \ [0x0e] TXFIFOHEIE
    $0f constant SDIO_RXFIFOHFIE                \ [0x0f] RXFIFOHFIE
    $10 constant SDIO_TXFIFOFIE                 \ [0x10] TXFIFOFIE
    $11 constant SDIO_RXFIFOFIE                 \ [0x11] RXFIFOFIE
    $12 constant SDIO_TXFIFOEIE                 \ [0x12] TXFIFOEIE
    $13 constant SDIO_RXFIFOEIE                 \ [0x13] RXFIFOEIE
    $14 constant SDIO_TXDAVLIE                  \ [0x14] TXDAVLIE
    $15 constant SDIO_RXDAVLIE                  \ [0x15] RXDAVLIE
    $16 constant SDIO_SDIOITIE                  \ [0x16] SDIOITIE
    $17 constant SDIO_CEATENDIE                 \ [0x17] CEATENDIE
  [then]


  [ifdef] SDIO_FIFOCNT_DEF
    \
    \ @brief Bits 23:0 = FIFOCOUNT: Remaining number of words to be written to or read from the FIFO
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_FIF0COUNT                 \ [0x00 : 24] FIF0COUNT
  [then]


  [ifdef] SDIO_FIFO_DEF
    \
    \ @brief bits 31:0 = FIFOData: Receive and transmit FIFO data
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant SDIO_FIFOData                  \ [0x00 : 32] FIFOData
  [then]

  \
  \ @brief Secure digital input/output interface
  \
  $00 constant SDIO_POWER               \ Bits 1:0 = PWRCTRL: Power supply control bits
  $04 constant SDIO_CLKCR               \ SDI clock control register (SDIO_CLKCR)
  $08 constant SDIO_ARG                 \ Bits 31:0 = : Command argument
  $0C constant SDIO_CMD                 \ SDIO command register (SDIO_CMD)
  $10 constant SDIO_RESPCMD             \ SDIO command register
  $14 constant SDIO_RESPI1              \ Bits 31:0 = CARDSTATUS1
  $18 constant SDIO_RESP2               \ Bits 31:0 = CARDSTATUS2
  $1C constant SDIO_RESP3               \ Bits 31:0 = CARDSTATUS3
  $20 constant SDIO_RESP4               \ Bits 31:0 = CARDSTATUS4
  $24 constant SDIO_DTIMER              \ Bits 31:0 = DATATIME: Data timeout period
  $28 constant SDIO_DLEN                \ Bits 24:0 = DATALENGTH: Data length value
  $2C constant SDIO_DCTRL               \ SDIO data control register (SDIO_DCTRL)
  $30 constant SDIO_DCOUNT              \ Bits 24:0 = DATACOUNT: Data count value
  $34 constant SDIO_STA                 \ SDIO status register (SDIO_STA)
  $38 constant SDIO_ICR                 \ SDIO interrupt clear register (SDIO_ICR)
  $3C constant SDIO_MASK                \ SDIO mask register (SDIO_MASK)
  $48 constant SDIO_FIFOCNT             \ Bits 23:0 = FIFOCOUNT: Remaining number of words to be written to or read from the FIFO
  $80 constant SDIO_FIFO                \ bits 31:0 = FIFOData: Receive and transmit FIFO data

: SDIO_DEF ; [then]
