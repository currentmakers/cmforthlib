\
\ @file sdio.fs
\ @brief Secure digital input/output       interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Bits 1:0 = PWRCTRL: Power supply control bits
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant SDIO_POWER_PWRCTRL                               \ PWRCTRL


\
\ @brief SDI clock control register (SDIO_CLKCR)
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
\ @brief Bits 31:0 = : Command argument
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant SDIO_ARG_CMDARG                                  \ Command argument


\
\ @brief SDIO command register (SDIO_CMD)
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000003f constant SDIO_CMD_CMDINDEX                                \ CMDINDEX
$000000c0 constant SDIO_CMD_WAITRESP                                \ WAITRESP
$00000100 constant SDIO_CMD_WAITINT                                 \ WAITINT
$00000200 constant SDIO_CMD_WAITPEND                                \ WAITPEND
$00000400 constant SDIO_CMD_CPSMEN                                  \ CPSMEN
$00000800 constant SDIO_CMD_SDIOSUSPEND                             \ SDIOSuspend
$00001000 constant SDIO_CMD_ENCMDCOMPL                              \ ENCMDcompl
$00002000 constant SDIO_CMD_NIEN                                    \ nIEN
$00004000 constant SDIO_CMD_CE_ATACMD                               \ CE_ATACMD


\
\ @brief SDIO command register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000003f constant SDIO_RESPCMD_RESPCMD                             \ RESPCMD


\
\ @brief Bits 31:0 = CARDSTATUS1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant SDIO_RESPI1_CARDSTATUS1                          \ CARDSTATUS1


\
\ @brief Bits 31:0 = CARDSTATUS2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant SDIO_RESP2_CARDSTATUS2                           \ CARDSTATUS2


\
\ @brief Bits 31:0 = CARDSTATUS3
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant SDIO_RESP3_CARDSTATUS3                           \ CARDSTATUS3


\
\ @brief Bits 31:0 = CARDSTATUS4
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SDIO_RESP4_CARDSTATUS4                           \ CARDSTATUS4


\
\ @brief Bits 31:0 = DATATIME: Data timeout period
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant SDIO_DTIMER_DATATIME                             \ Data timeout period


\
\ @brief Bits 24:0 = DATALENGTH: Data length value
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$01ffffff constant SDIO_DLEN_DATALENGTH                             \ Data length value


\
\ @brief SDIO data control register (SDIO_DCTRL)
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant SDIO_DCTRL_DTEN                                  \ DTEN
$00000002 constant SDIO_DCTRL_DTDIR                                 \ DTDIR
$00000004 constant SDIO_DCTRL_DTMODE                                \ DTMODE
$00000008 constant SDIO_DCTRL_DMAEN                                 \ DMAEN
$000000f0 constant SDIO_DCTRL_DBLOCKSIZE                            \ DBLOCKSIZE
$00000100 constant SDIO_DCTRL_PWSTART                               \ PWSTART
$00000200 constant SDIO_DCTRL_PWSTOP                                \ PWSTOP
$00000400 constant SDIO_DCTRL_RWMOD                                 \ RWMOD
$00000800 constant SDIO_DCTRL_SDIOEN                                \ SDIOEN


\
\ @brief Bits 24:0 = DATACOUNT: Data count value
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$01ffffff constant SDIO_DCOUNT_DATACOUNT                            \ Data count value


\
\ @brief SDIO status register (SDIO_STA)
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant SDIO_STA_CCRCFAIL                                \ CCRCFAIL
$00000002 constant SDIO_STA_DCRCFAIL                                \ DCRCFAIL
$00000004 constant SDIO_STA_CTIMEOUT                                \ CTIMEOUT
$00000008 constant SDIO_STA_DTIMEOUT                                \ DTIMEOUT
$00000010 constant SDIO_STA_TXUNDERR                                \ TXUNDERR
$00000020 constant SDIO_STA_RXOVERR                                 \ RXOVERR
$00000040 constant SDIO_STA_CMDREND                                 \ CMDREND
$00000080 constant SDIO_STA_CMDSENT                                 \ CMDSENT
$00000100 constant SDIO_STA_DATAEND                                 \ DATAEND
$00000200 constant SDIO_STA_STBITERR                                \ STBITERR
$00000400 constant SDIO_STA_DBCKEND                                 \ DBCKEND
$00000800 constant SDIO_STA_CMDACT                                  \ CMDACT
$00001000 constant SDIO_STA_TXACT                                   \ TXACT
$00002000 constant SDIO_STA_RXACT                                   \ RXACT
$00004000 constant SDIO_STA_TXFIFOHE                                \ TXFIFOHE
$00008000 constant SDIO_STA_RXFIFOHF                                \ RXFIFOHF
$00010000 constant SDIO_STA_TXFIFOF                                 \ TXFIFOF
$00020000 constant SDIO_STA_RXFIFOF                                 \ RXFIFOF
$00040000 constant SDIO_STA_TXFIFOE                                 \ TXFIFOE
$00080000 constant SDIO_STA_RXFIFOE                                 \ RXFIFOE
$00100000 constant SDIO_STA_TXDAVL                                  \ TXDAVL
$00200000 constant SDIO_STA_RXDAVL                                  \ RXDAVL
$00400000 constant SDIO_STA_SDIOIT                                  \ SDIOIT
$00800000 constant SDIO_STA_CEATAEND                                \ CEATAEND


\
\ @brief SDIO interrupt clear register (SDIO_ICR)
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant SDIO_ICR_CCRCFAILC                               \ CCRCFAILC
$00000002 constant SDIO_ICR_DCRCFAILC                               \ DCRCFAILC
$00000004 constant SDIO_ICR_CTIMEOUTC                               \ CTIMEOUTC
$00000008 constant SDIO_ICR_DTIMEOUTC                               \ DTIMEOUTC
$00000010 constant SDIO_ICR_TXUNDERRC                               \ TXUNDERRC
$00000020 constant SDIO_ICR_RXOVERRC                                \ RXOVERRC
$00000040 constant SDIO_ICR_CMDRENDC                                \ CMDRENDC
$00000080 constant SDIO_ICR_CMDSENTC                                \ CMDSENTC
$00000100 constant SDIO_ICR_DATAENDC                                \ DATAENDC
$00000200 constant SDIO_ICR_STBITERRC                               \ STBITERRC
$00000400 constant SDIO_ICR_DBCKENDC                                \ DBCKENDC
$00400000 constant SDIO_ICR_SDIOITC                                 \ SDIOITC
$00800000 constant SDIO_ICR_CEATAENDC                               \ CEATAENDC


\
\ @brief SDIO mask register (SDIO_MASK)
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant SDIO_MASK_CCRCFAILIE                             \ CCRCFAILIE
$00000002 constant SDIO_MASK_DCRCFAILIE                             \ DCRCFAILIE
$00000004 constant SDIO_MASK_CTIMEOUTIE                             \ CTIMEOUTIE
$00000008 constant SDIO_MASK_DTIMEOUTIE                             \ DTIMEOUTIE
$00000010 constant SDIO_MASK_TXUNDERRIE                             \ TXUNDERRIE
$00000020 constant SDIO_MASK_RXOVERRIE                              \ RXOVERRIE
$00000040 constant SDIO_MASK_CMDRENDIE                              \ CMDRENDIE
$00000080 constant SDIO_MASK_CMDSENTIE                              \ CMDSENTIE
$00000100 constant SDIO_MASK_DATAENDIE                              \ DATAENDIE
$00000200 constant SDIO_MASK_STBITERRIE                             \ STBITERRIE
$00000400 constant SDIO_MASK_DBACKENDIE                             \ DBACKENDIE
$00000800 constant SDIO_MASK_CMDACTIE                               \ CMDACTIE
$00001000 constant SDIO_MASK_TXACTIE                                \ TXACTIE
$00002000 constant SDIO_MASK_RXACTIE                                \ RXACTIE
$00004000 constant SDIO_MASK_TXFIFOHEIE                             \ TXFIFOHEIE
$00008000 constant SDIO_MASK_RXFIFOHFIE                             \ RXFIFOHFIE
$00010000 constant SDIO_MASK_TXFIFOFIE                              \ TXFIFOFIE
$00020000 constant SDIO_MASK_RXFIFOFIE                              \ RXFIFOFIE
$00040000 constant SDIO_MASK_TXFIFOEIE                              \ TXFIFOEIE
$00080000 constant SDIO_MASK_RXFIFOEIE                              \ RXFIFOEIE
$00100000 constant SDIO_MASK_TXDAVLIE                               \ TXDAVLIE
$00200000 constant SDIO_MASK_RXDAVLIE                               \ RXDAVLIE
$00400000 constant SDIO_MASK_SDIOITIE                               \ SDIOITIE
$00800000 constant SDIO_MASK_CEATENDIE                              \ CEATENDIE


\
\ @brief Bits 23:0 = FIFOCOUNT: Remaining number of words to be written to or read from the FIFO
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00ffffff constant SDIO_FIFOCNT_FIF0COUNT                           \ FIF0COUNT


\
\ @brief bits 31:0 = FIFOData: Receive and transmit FIFO data
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant SDIO_FIFO_FIFODATA                               \ FIFOData


\
\ @brief Secure digital input/output interface
\
$40018000 constant SDIO_POWER     \ offset: 0x00 : Bits 1:0 = PWRCTRL: Power supply control bits
$40018004 constant SDIO_CLKCR     \ offset: 0x04 : SDI clock control register (SDIO_CLKCR)
$40018008 constant SDIO_ARG       \ offset: 0x08 : Bits 31:0 = : Command argument
$4001800c constant SDIO_CMD       \ offset: 0x0C : SDIO command register (SDIO_CMD)
$40018010 constant SDIO_RESPCMD   \ offset: 0x10 : SDIO command register
$40018014 constant SDIO_RESPI1    \ offset: 0x14 : Bits 31:0 = CARDSTATUS1
$40018018 constant SDIO_RESP2     \ offset: 0x18 : Bits 31:0 = CARDSTATUS2
$4001801c constant SDIO_RESP3     \ offset: 0x1C : Bits 31:0 = CARDSTATUS3
$40018020 constant SDIO_RESP4     \ offset: 0x20 : Bits 31:0 = CARDSTATUS4
$40018024 constant SDIO_DTIMER    \ offset: 0x24 : Bits 31:0 = DATATIME: Data timeout period
$40018028 constant SDIO_DLEN      \ offset: 0x28 : Bits 24:0 = DATALENGTH: Data length value
$4001802c constant SDIO_DCTRL     \ offset: 0x2C : SDIO data control register (SDIO_DCTRL)
$40018030 constant SDIO_DCOUNT    \ offset: 0x30 : Bits 24:0 = DATACOUNT: Data count value
$40018034 constant SDIO_STA       \ offset: 0x34 : SDIO status register (SDIO_STA)
$40018038 constant SDIO_ICR       \ offset: 0x38 : SDIO interrupt clear register (SDIO_ICR)
$4001803c constant SDIO_MASK      \ offset: 0x3C : SDIO mask register (SDIO_MASK)
$40018048 constant SDIO_FIFOCNT   \ offset: 0x48 : Bits 23:0 = FIFOCOUNT: Remaining number of words to be written to or read from the FIFO
$40018080 constant SDIO_FIFO      \ offset: 0x80 : bits 31:0 = FIFOData: Receive and transmit FIFO data

