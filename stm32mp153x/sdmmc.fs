\
\ @file sdmmc.fs
\ @brief SDMMC1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SDMMC_DEF

  [ifdef] SDMMC_SDMMC_POWER_DEF
    \
    \ @brief SDMMC power control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_PWRCTRL                  \ [0x00 : 2] PWRCTRL
    $02 constant SDMMC_VSWITCH                  \ [0x02] VSWITCH
    $03 constant SDMMC_VSWITCHEN                \ [0x03] VSWITCHEN
    $04 constant SDMMC_DIRPOL                   \ [0x04] DIRPOL
  [then]


  [ifdef] SDMMC_SDMMC_CLKCR_DEF
    \
    \ @brief The SDMMC_CLKCR register controls the SDMMC_CK output clock, the sdmmc_rx_ck receive clock, and the bus width.
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CLKDIV                   \ [0x00 : 10] CLKDIV
    $0c constant SDMMC_PWRSAV                   \ [0x0c] PWRSAV
    $0e constant SDMMC_WIDBUS                   \ [0x0e : 2] WIDBUS
    $10 constant SDMMC_NEGEDGE                  \ [0x10] NEGEDGE
    $11 constant SDMMC_HWFC_EN                  \ [0x11] HWFC_EN
    $12 constant SDMMC_DDR                      \ [0x12] DDR
    $13 constant SDMMC_BUSSPEED                 \ [0x13] BUSSPEED
    $14 constant SDMMC_SELCLKRX                 \ [0x14 : 2] SELCLKRX
  [then]


  [ifdef] SDMMC_SDMMC_ARGR_DEF
    \
    \ @brief The SDMMC_ARGR register contains a 32-bit command argument, which is sent to a card as part of a command message.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CMDARG                   \ [0x00 : 32] CMDARG
  [then]


  [ifdef] SDMMC_SDMMC_CMDR_DEF
    \
    \ @brief The SDMMC_CMDR register contains the command index and command type bits. The command index is sent to a card as part of a command message. The command type bits control the command path state machine (CPSM).
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CMDINDEX                 \ [0x00 : 6] CMDINDEX
    $06 constant SDMMC_CMDTRANS                 \ [0x06] CMDTRANS
    $07 constant SDMMC_CMDSTOP                  \ [0x07] CMDSTOP
    $08 constant SDMMC_WAITRESP                 \ [0x08 : 2] WAITRESP
    $0a constant SDMMC_WAITINT                  \ [0x0a] WAITINT
    $0b constant SDMMC_WAITPEND                 \ [0x0b] WAITPEND
    $0c constant SDMMC_CPSMEN                   \ [0x0c] CPSMEN
    $0d constant SDMMC_DTHOLD                   \ [0x0d] DTHOLD
    $0e constant SDMMC_BOOTMODE                 \ [0x0e] BOOTMODE
    $0f constant SDMMC_BOOTEN                   \ [0x0f] BOOTEN
    $10 constant SDMMC_CMDSUSPEND               \ [0x10] CMDSUSPEND
  [then]


  [ifdef] SDMMC_SDMMC_RESPCMDR_DEF
    \
    \ @brief The SDMMC_RESPCMDR register contains the command index field of the last command response received. If the command response transmission does not contain the command index field (long or OCR response), the RESPCMD field is unknown, although it must contain 111111b (the value of the reserved field from the response).
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_RESPCMD                  \ [0x00 : 6] RESPCMD
  [then]


  [ifdef] SDMMC_SDMMC_RESP1R_DEF
    \
    \ @brief The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CARDSTATUS1              \ [0x00 : 32] CARDSTATUS1
  [then]


  [ifdef] SDMMC_SDMMC_RESP2R_DEF
    \
    \ @brief The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CARDSTATUS2              \ [0x00 : 32] CARDSTATUS2
  [then]


  [ifdef] SDMMC_SDMMC_RESP3R_DEF
    \
    \ @brief The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CARDSTATUS3              \ [0x00 : 32] CARDSTATUS3
  [then]


  [ifdef] SDMMC_SDMMC_RESP4R_DEF
    \
    \ @brief The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CARDSTATUS4              \ [0x00 : 32] CARDSTATUS4
  [then]


  [ifdef] SDMMC_SDMMC_DTIMER_DEF
    \
    \ @brief The SDMMC_DTIMER register contains the data timeout period, in card bus clock periods. A counter loads the value from the SDMMC_DTIMER register, and starts decrementing when the data path state machine (DPSM) enters the Wait_R or Busy state. If the timer reaches 0 while the DPSM is in either of these states, the timeout status flag is set.
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_DATATIME                 \ [0x00 : 32] DATATIME
  [then]


  [ifdef] SDMMC_SDMMC_DLENR_DEF
    \
    \ @brief The SDMMC_DLENR register contains the number of data bytes to be transferred. The value is loaded into the data counter when data transfer starts.
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_DATALENGTH               \ [0x00 : 25] DATALENGTH
  [then]


  [ifdef] SDMMC_SDMMC_DCTRL_DEF
    \
    \ @brief The SDMMC_DCTRL register control the data path state machine (DPSM).
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_DTEN                     \ [0x00] DTEN
    $01 constant SDMMC_DTDIR                    \ [0x01] DTDIR
    $02 constant SDMMC_DTMODE                   \ [0x02 : 2] DTMODE
    $04 constant SDMMC_DBLOCKSIZE               \ [0x04 : 4] DBLOCKSIZE
    $08 constant SDMMC_RWSTART                  \ [0x08] RWSTART
    $09 constant SDMMC_RWSTOP                   \ [0x09] RWSTOP
    $0a constant SDMMC_RWMOD                    \ [0x0a] RWMOD
    $0b constant SDMMC_SDIOEN                   \ [0x0b] SDIOEN
    $0c constant SDMMC_BOOTACKEN                \ [0x0c] BOOTACKEN
    $0d constant SDMMC_FIFORST                  \ [0x0d] FIFORST
  [then]


  [ifdef] SDMMC_SDMMC_DCNTR_DEF
    \
    \ @brief The SDMMC_DCNTR register loads the value from the data length register (see SDMMC_DLENR) when the DPSM moves from the Idle state to the Wait_R or Wait_S state. As data is transferred, the counter decrements the value until it reaches 0. The DPSM then moves to the Idle state and when there has been no error, the data status end flag (DATAEND) is set.
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_DATACOUNT                \ [0x00 : 25] DATACOUNT
  [then]


  [ifdef] SDMMC_SDMMC_STAR_DEF
    \
    \ @brief The SDMMC_STAR register is a read-only register. It contains two types of flag: Static flags (bits [28, 21, 11:0]): these bits remain asserted until they are cleared by writing to the SDMMC interrupt Clear register (see SDMMC_ICR) Dynamic flags (bits [20:12]): these bits change state depending on the state of the underlying logic (for example, FIFO full and empty flags are asserted and de-asserted as data while written to the FIFO)
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CCRCFAIL                 \ [0x00] CCRCFAIL
    $01 constant SDMMC_DCRCFAIL                 \ [0x01] DCRCFAIL
    $02 constant SDMMC_CTIMEOUT                 \ [0x02] CTIMEOUT
    $03 constant SDMMC_DTIMEOUT                 \ [0x03] DTIMEOUT
    $04 constant SDMMC_TXUNDERR                 \ [0x04] TXUNDERR
    $05 constant SDMMC_RXOVERR                  \ [0x05] RXOVERR
    $06 constant SDMMC_CMDREND                  \ [0x06] CMDREND
    $07 constant SDMMC_CMDSENT                  \ [0x07] CMDSENT
    $08 constant SDMMC_DATAEND                  \ [0x08] DATAEND
    $09 constant SDMMC_DHOLD                    \ [0x09] DHOLD
    $0a constant SDMMC_DBCKEND                  \ [0x0a] DBCKEND
    $0b constant SDMMC_DABORT                   \ [0x0b] DABORT
    $0c constant SDMMC_DPSMACT                  \ [0x0c] DPSMACT
    $0d constant SDMMC_CPSMACT                  \ [0x0d] CPSMACT
    $0e constant SDMMC_TXFIFOHE                 \ [0x0e] TXFIFOHE
    $0f constant SDMMC_RXFIFOHF                 \ [0x0f] RXFIFOHF
    $10 constant SDMMC_TXFIFOF                  \ [0x10] TXFIFOF
    $11 constant SDMMC_RXFIFOF                  \ [0x11] RXFIFOF
    $12 constant SDMMC_TXFIFOE                  \ [0x12] TXFIFOE
    $13 constant SDMMC_RXFIFOE                  \ [0x13] RXFIFOE
    $14 constant SDMMC_BUSYD0                   \ [0x14] BUSYD0
    $15 constant SDMMC_BUSYD0END                \ [0x15] BUSYD0END
    $16 constant SDMMC_SDIOIT                   \ [0x16] SDIOIT
    $17 constant SDMMC_ACKFAIL                  \ [0x17] ACKFAIL
    $18 constant SDMMC_ACKTIMEOUT               \ [0x18] ACKTIMEOUT
    $19 constant SDMMC_VSWEND                   \ [0x19] VSWEND
    $1a constant SDMMC_CKSTOP                   \ [0x1a] CKSTOP
    $1b constant SDMMC_IDMATE                   \ [0x1b] IDMATE
    $1c constant SDMMC_IDMABTC                  \ [0x1c] IDMABTC
  [then]


  [ifdef] SDMMC_SDMMC_ICR_DEF
    \
    \ @brief The SDMMC_ICR register is a write-only register. Writing a bit with 1 clears the corresponding bit in the SDMMC_STAR status register.
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CCRCFAILC                \ [0x00] CCRCFAILC
    $01 constant SDMMC_DCRCFAILC                \ [0x01] DCRCFAILC
    $02 constant SDMMC_CTIMEOUTC                \ [0x02] CTIMEOUTC
    $03 constant SDMMC_DTIMEOUTC                \ [0x03] DTIMEOUTC
    $04 constant SDMMC_TXUNDERRC                \ [0x04] TXUNDERRC
    $05 constant SDMMC_RXOVERRC                 \ [0x05] RXOVERRC
    $06 constant SDMMC_CMDRENDC                 \ [0x06] CMDRENDC
    $07 constant SDMMC_CMDSENTC                 \ [0x07] CMDSENTC
    $08 constant SDMMC_DATAENDC                 \ [0x08] DATAENDC
    $09 constant SDMMC_DHOLDC                   \ [0x09] DHOLDC
    $0a constant SDMMC_DBCKENDC                 \ [0x0a] DBCKENDC
    $0b constant SDMMC_DABORTC                  \ [0x0b] DABORTC
    $15 constant SDMMC_BUSYD0ENDC               \ [0x15] BUSYD0ENDC
    $16 constant SDMMC_SDIOITC                  \ [0x16] SDIOITC
    $17 constant SDMMC_ACKFAILC                 \ [0x17] ACKFAILC
    $18 constant SDMMC_ACKTIMEOUTC              \ [0x18] ACKTIMEOUTC
    $19 constant SDMMC_VSWENDC                  \ [0x19] VSWENDC
    $1a constant SDMMC_CKSTOPC                  \ [0x1a] CKSTOPC
    $1b constant SDMMC_IDMATEC                  \ [0x1b] IDMATEC
    $1c constant SDMMC_IDMABTCC                 \ [0x1c] IDMABTCC
  [then]


  [ifdef] SDMMC_SDMMC_MASKR_DEF
    \
    \ @brief The interrupt mask register determines which status flags generate an interrupt request by setting the corresponding bit to 1.
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CCRCFAILIE               \ [0x00] CCRCFAILIE
    $01 constant SDMMC_DCRCFAILIE               \ [0x01] DCRCFAILIE
    $02 constant SDMMC_CTIMEOUTIE               \ [0x02] CTIMEOUTIE
    $03 constant SDMMC_DTIMEOUTIE               \ [0x03] DTIMEOUTIE
    $04 constant SDMMC_TXUNDERRIE               \ [0x04] TXUNDERRIE
    $05 constant SDMMC_RXOVERRIE                \ [0x05] RXOVERRIE
    $06 constant SDMMC_CMDRENDIE                \ [0x06] CMDRENDIE
    $07 constant SDMMC_CMDSENTIE                \ [0x07] CMDSENTIE
    $08 constant SDMMC_DATAENDIE                \ [0x08] DATAENDIE
    $09 constant SDMMC_DHOLDIE                  \ [0x09] DHOLDIE
    $0a constant SDMMC_DBCKENDIE                \ [0x0a] DBCKENDIE
    $0b constant SDMMC_DABORTIE                 \ [0x0b] DABORTIE
    $0e constant SDMMC_TXFIFOHEIE               \ [0x0e] TXFIFOHEIE
    $0f constant SDMMC_RXFIFOHFIE               \ [0x0f] RXFIFOHFIE
    $11 constant SDMMC_RXFIFOFIE                \ [0x11] RXFIFOFIE
    $12 constant SDMMC_TXFIFOEIE                \ [0x12] TXFIFOEIE
    $15 constant SDMMC_BUSYD0ENDIE              \ [0x15] BUSYD0ENDIE
    $16 constant SDMMC_SDIOITIE                 \ [0x16] SDIOITIE
    $17 constant SDMMC_ACKFAILIE                \ [0x17] ACKFAILIE
    $18 constant SDMMC_ACKTIMEOUTIE             \ [0x18] ACKTIMEOUTIE
    $19 constant SDMMC_VSWENDIE                 \ [0x19] VSWENDIE
    $1a constant SDMMC_CKSTOPIE                 \ [0x1a] CKSTOPIE
    $1c constant SDMMC_IDMABTCIE                \ [0x1c] IDMABTCIE
  [then]


  [ifdef] SDMMC_SDMMC_ACKTIMER_DEF
    \
    \ @brief The SDMMC_ACKTIMER register contains the acknowledgment timeout period, in SDMMC_CK bus clock periods. A counter loads the value from the SDMMC_ACKTIMER register, and starts decrementing when the data path state machine (DPSM) enters the Wait_Ack state. If the timer reaches 0 while the DPSM is in this states, the acknowledgment timeout status flag is set.
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_ACKTIME                  \ [0x00 : 25] ACKTIME
  [then]


  [ifdef] SDMMC_SDMMC_IDMACTRLR_DEF
    \
    \ @brief The receive and transmit FIFOs can be read or written as 32-bit wide registers. The FIFOs contain 32 entries on 32 sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO.
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_IDMAEN                   \ [0x00] IDMAEN
    $01 constant SDMMC_IDMABMODE                \ [0x01] IDMABMODE
  [then]


  [ifdef] SDMMC_SDMMC_IDMABSIZER_DEF
    \
    \ @brief The SDMMC_IDMABSIZER register contains the buffer size when in linked list configuration.
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $05 constant SDMMC_IDMABNDT                 \ [0x05 : 12] IDMABNDT
  [then]


  [ifdef] SDMMC_SDMMC_IDMABASER_DEF
    \
    \ @brief The SDMMC_IDMABASER register contains the memory buffer base address in single buffer configuration and linked list configuration.
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_IDMABASE                 \ [0x00 : 32] IDMABASE
  [then]


  [ifdef] SDMMC_SDMMC_IDMALAR_DEF
    \
    \ @brief SDMMC IDMA linked list address register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $02 constant SDMMC_IDMALA                   \ [0x02 : 14] IDMALA
    $1d constant SDMMC_ABR                      \ [0x1d] ABR
    $1e constant SDMMC_ULS                      \ [0x1e] ULS
    $1f constant SDMMC_ULA                      \ [0x1f] ULA
  [then]


  [ifdef] SDMMC_SDMMC_IDMABAR_DEF
    \
    \ @brief SDMMC IDMA linked list memory base register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $02 constant SDMMC_IDMABA                   \ [0x02 : 30] IDMABA
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR0_DEF
    \
    \ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] FIFODATA
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR1_DEF
    \
    \ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] FIFODATA
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR2_DEF
    \
    \ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] FIFODATA
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR3_DEF
    \
    \ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] FIFODATA
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR4_DEF
    \
    \ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] FIFODATA
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR5_DEF
    \
    \ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] FIFODATA
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR6_DEF
    \
    \ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] FIFODATA
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR7_DEF
    \
    \ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] FIFODATA
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR8_DEF
    \
    \ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] FIFODATA
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR9_DEF
    \
    \ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] FIFODATA
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR10_DEF
    \
    \ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] FIFODATA
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR11_DEF
    \
    \ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] FIFODATA
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR12_DEF
    \
    \ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] FIFODATA
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR13_DEF
    \
    \ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] FIFODATA
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR14_DEF
    \
    \ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] FIFODATA
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR15_DEF
    \
    \ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] FIFODATA
  [then]


  [ifdef] SDMMC_SDMMC_VERR_DEF
    \
    \ @brief SDMMC version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000020
    \
    $00 constant SDMMC_MINREV                   \ [0x00 : 4] MINREV
    $04 constant SDMMC_MAJREV                   \ [0x04 : 4] MAJREV
  [then]


  [ifdef] SDMMC_SDMMC_IPIDR_DEF
    \
    \ @brief SDMMC identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00140022
    \
    $00 constant SDMMC_IP_ID                    \ [0x00 : 32] IP_ID
  [then]


  [ifdef] SDMMC_SDMMC_SIDR_DEF
    \
    \ @brief SDMMC size ID register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant SDMMC_SID                      \ [0x00 : 32] SID
  [then]

  \
  \ @brief SDMMC1
  \
  $00 constant SDMMC_SDMMC_POWER        \ SDMMC power control register
  $04 constant SDMMC_SDMMC_CLKCR        \ The SDMMC_CLKCR register controls the SDMMC_CK output clock, the sdmmc_rx_ck receive clock, and the bus width.
  $08 constant SDMMC_SDMMC_ARGR         \ The SDMMC_ARGR register contains a 32-bit command argument, which is sent to a card as part of a command message.
  $0C constant SDMMC_SDMMC_CMDR         \ The SDMMC_CMDR register contains the command index and command type bits. The command index is sent to a card as part of a command message. The command type bits control the command path state machine (CPSM).
  $10 constant SDMMC_SDMMC_RESPCMDR     \ The SDMMC_RESPCMDR register contains the command index field of the last command response received. If the command response transmission does not contain the command index field (long or OCR response), the RESPCMD field is unknown, although it must contain 111111b (the value of the reserved field from the response).
  $14 constant SDMMC_SDMMC_RESP1R       \ The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
  $18 constant SDMMC_SDMMC_RESP2R       \ The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
  $1C constant SDMMC_SDMMC_RESP3R       \ The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
  $20 constant SDMMC_SDMMC_RESP4R       \ The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
  $24 constant SDMMC_SDMMC_DTIMER       \ The SDMMC_DTIMER register contains the data timeout period, in card bus clock periods. A counter loads the value from the SDMMC_DTIMER register, and starts decrementing when the data path state machine (DPSM) enters the Wait_R or Busy state. If the timer reaches 0 while the DPSM is in either of these states, the timeout status flag is set.
  $28 constant SDMMC_SDMMC_DLENR        \ The SDMMC_DLENR register contains the number of data bytes to be transferred. The value is loaded into the data counter when data transfer starts.
  $2C constant SDMMC_SDMMC_DCTRL        \ The SDMMC_DCTRL register control the data path state machine (DPSM).
  $30 constant SDMMC_SDMMC_DCNTR        \ The SDMMC_DCNTR register loads the value from the data length register (see SDMMC_DLENR) when the DPSM moves from the Idle state to the Wait_R or Wait_S state. As data is transferred, the counter decrements the value until it reaches 0. The DPSM then moves to the Idle state and when there has been no error, the data status end flag (DATAEND) is set.
  $34 constant SDMMC_SDMMC_STAR         \ The SDMMC_STAR register is a read-only register. It contains two types of flag: Static flags (bits [28, 21, 11:0]): these bits remain asserted until they are cleared by writing to the SDMMC interrupt Clear register (see SDMMC_ICR) Dynamic flags (bits [20:12]): these bits change state depending on the state of the underlying logic (for example, FIFO full and empty flags are asserted and de-asserted as data while written to the FIFO)
  $38 constant SDMMC_SDMMC_ICR          \ The SDMMC_ICR register is a write-only register. Writing a bit with 1 clears the corresponding bit in the SDMMC_STAR status register.
  $3C constant SDMMC_SDMMC_MASKR        \ The interrupt mask register determines which status flags generate an interrupt request by setting the corresponding bit to 1.
  $40 constant SDMMC_SDMMC_ACKTIMER     \ The SDMMC_ACKTIMER register contains the acknowledgment timeout period, in SDMMC_CK bus clock periods. A counter loads the value from the SDMMC_ACKTIMER register, and starts decrementing when the data path state machine (DPSM) enters the Wait_Ack state. If the timer reaches 0 while the DPSM is in this states, the acknowledgment timeout status flag is set.
  $50 constant SDMMC_SDMMC_IDMACTRLR    \ The receive and transmit FIFOs can be read or written as 32-bit wide registers. The FIFOs contain 32 entries on 32 sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO.
  $54 constant SDMMC_SDMMC_IDMABSIZER   \ The SDMMC_IDMABSIZER register contains the buffer size when in linked list configuration.
  $58 constant SDMMC_SDMMC_IDMABASER    \ The SDMMC_IDMABASER register contains the memory buffer base address in single buffer configuration and linked list configuration.
  $64 constant SDMMC_SDMMC_IDMALAR      \ SDMMC IDMA linked list address register
  $68 constant SDMMC_SDMMC_IDMABAR      \ SDMMC IDMA linked list memory base register
  $80 constant SDMMC_SDMMC_FIFOR0       \ The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
  $84 constant SDMMC_SDMMC_FIFOR1       \ The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
  $88 constant SDMMC_SDMMC_FIFOR2       \ The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
  $8C constant SDMMC_SDMMC_FIFOR3       \ The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
  $90 constant SDMMC_SDMMC_FIFOR4       \ The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
  $94 constant SDMMC_SDMMC_FIFOR5       \ The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
  $98 constant SDMMC_SDMMC_FIFOR6       \ The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
  $9C constant SDMMC_SDMMC_FIFOR7       \ The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
  $A0 constant SDMMC_SDMMC_FIFOR8       \ The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
  $A4 constant SDMMC_SDMMC_FIFOR9       \ The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
  $A8 constant SDMMC_SDMMC_FIFOR10      \ The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
  $AC constant SDMMC_SDMMC_FIFOR11      \ The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
  $B0 constant SDMMC_SDMMC_FIFOR12      \ The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
  $B4 constant SDMMC_SDMMC_FIFOR13      \ The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
  $B8 constant SDMMC_SDMMC_FIFOR14      \ The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
  $BC constant SDMMC_SDMMC_FIFOR15      \ The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
  $3F4 constant SDMMC_SDMMC_VERR        \ SDMMC version register
  $3F8 constant SDMMC_SDMMC_IPIDR       \ SDMMC identification register
  $3FC constant SDMMC_SDMMC_SIDR        \ SDMMC size ID register

: SDMMC_DEF ; [then]
