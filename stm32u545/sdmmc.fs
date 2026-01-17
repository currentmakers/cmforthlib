\
\ @file sdmmc.fs
\ @brief Secure digital input/output MultiMediaCard interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SDMMC_DEF

  [ifdef] SDMMC_POWER_DEF
    \
    \ @brief power control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_PWRCTRL                  \ [0x00 : 2] SDMMC state control bits
    $02 constant SDMMC_VSWITCH                  \ [0x02] Voltage switch sequence start
    $03 constant SDMMC_VSWITCHEN                \ [0x03] Voltage switch procedure enable
    $04 constant SDMMC_DIRPOL                   \ [0x04] Data and command direction signals polarity selection
  [then]


  [ifdef] SDMMC_CLKCR_DEF
    \
    \ @brief clock control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CLKDIV                   \ [0x00 : 10] Clock divide factor
    $0c constant SDMMC_PWRSAV                   \ [0x0c] Power saving configuration bit
    $0e constant SDMMC_WIDBUS                   \ [0x0e : 2] Wide bus mode enable bit
    $10 constant SDMMC_NEGEDGE                  \ [0x10] SDIO_CK dephasing selection bit
    $11 constant SDMMC_HWFC_EN                  \ [0x11] HW Flow Control enable
    $12 constant SDMMC_DDR                      \ [0x12] Data rate signaling selection
    $13 constant SDMMC_BUSSPEED                 \ [0x13] Bus speed mode selection between DS, HS, SDR12, SDR25 and SDR50,DDR50, SDR104
    $14 constant SDMMC_SELCLKRX                 \ [0x14 : 2] Receive clock selection
  [then]


  [ifdef] SDMMC_ARGR_DEF
    \
    \ @brief argument register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CMDARG                   \ [0x00 : 32] Command argument
  [then]


  [ifdef] SDMMC_CMDR_DEF
    \
    \ @brief command register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CMDINDEX                 \ [0x00 : 6] Command index
    $06 constant SDMMC_CMDTRANS                 \ [0x06] The CPSM treats the command as a data transfer command, stops the interrupt period, and signals DataEnable to the DPSM
    $07 constant SDMMC_CMDSTOP                  \ [0x07] The CPSM treats the command as a Stop Transmission command and signals Abort to the DPSM
    $08 constant SDMMC_WAITRESP                 \ [0x08 : 2] Wait for response bits
    $0a constant SDMMC_WAITINT                  \ [0x0a] CPSM waits for interrupt request
    $0b constant SDMMC_WAITPEND                 \ [0x0b] CPSM Waits for ends of data transfer (CmdPend internal signal) from DPSM
    $0c constant SDMMC_CPSMEN                   \ [0x0c] Command path state machine (CPSM) Enable bit
    $0d constant SDMMC_DTHOLD                   \ [0x0d] Hold new data block transmission and reception in the DPSM
    $0e constant SDMMC_BOOTMODE                 \ [0x0e] Select the boot mode procedure to be used
    $0f constant SDMMC_BOOTEN                   \ [0x0f] Enable boot mode procedure
    $10 constant SDMMC_CMDSUSPEND               \ [0x10] The CPSM treats the command as a Suspend or Resume command and signals interrupt period start/end
  [then]


  [ifdef] SDMMC_RESPCMDR_DEF
    \
    \ @brief command response register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_RESPCMD                  \ [0x00 : 6] Response command index
  [then]


  [ifdef] SDMMC_RESP1_DEF
    \
    \ @brief response 1 register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CARDSTATUS1              \ [0x00 : 32] CARDSTATUS1
  [then]


  [ifdef] SDMMC_RESP2_DEF
    \
    \ @brief response 2 register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CARDSTATUS2              \ [0x00 : 32] CARDSTATUS2
  [then]


  [ifdef] SDMMC_RESP3_DEF
    \
    \ @brief response 3 register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CARDSTATUS3              \ [0x00 : 32] CARDSTATUS3
  [then]


  [ifdef] SDMMC_RESP4_DEF
    \
    \ @brief response 4 register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CARDSTATUS4              \ [0x00 : 32] CARDSTATUS4
  [then]


  [ifdef] SDMMC_DTIMER_DEF
    \
    \ @brief data timer register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_DATATIME                 \ [0x00 : 32] Data and R1b busy timeout period
  [then]


  [ifdef] SDMMC_DLENR_DEF
    \
    \ @brief data length register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_DATALENGTH               \ [0x00 : 25] Data length value
  [then]


  [ifdef] SDMMC_DCTRL_DEF
    \
    \ @brief data control register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_DTEN                     \ [0x00] DTEN
    $01 constant SDMMC_DTDIR                    \ [0x01] Data transfer direction selection
    $02 constant SDMMC_DTMODE                   \ [0x02 : 2] Data transfer mode selection
    $04 constant SDMMC_DBLOCKSIZE               \ [0x04 : 4] Data block size
    $08 constant SDMMC_RWSTART                  \ [0x08] Read wait start
    $09 constant SDMMC_RWSTOP                   \ [0x09] Read wait stop
    $0a constant SDMMC_RWMOD                    \ [0x0a] Read wait mode
    $0b constant SDMMC_SDIOEN                   \ [0x0b] SD I/O enable functions
    $0c constant SDMMC_BOOTACKEN                \ [0x0c] Enable the reception of the boot acknowledgment
    $0d constant SDMMC_FIFORST                  \ [0x0d] FIFO reset, will flush any remaining data
  [then]


  [ifdef] SDMMC_DCNTR_DEF
    \
    \ @brief data counter register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_DATACOUNT                \ [0x00 : 25] Data count value
  [then]


  [ifdef] SDMMC_STAR_DEF
    \
    \ @brief status register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CCRCFAIL                 \ [0x00] Command response received (CRC check failed)
    $01 constant SDMMC_DCRCFAIL                 \ [0x01] Data block sent/received (CRC check failed)
    $02 constant SDMMC_CTIMEOUT                 \ [0x02] Command response timeout
    $03 constant SDMMC_DTIMEOUT                 \ [0x03] Data timeout
    $04 constant SDMMC_TXUNDERR                 \ [0x04] Transmit FIFO underrun error (masked by hardware when IDMA is enabled)
    $05 constant SDMMC_RXOVERR                  \ [0x05] Received FIFO overrun error (masked by hardware when IDMA is enabled)
    $06 constant SDMMC_CMDREND                  \ [0x06] Command response received (CRC check passed, or no CRC)
    $07 constant SDMMC_CMDSENT                  \ [0x07] Command sent (no response required)
    $08 constant SDMMC_DATAEND                  \ [0x08] Data transfer ended correctly
    $09 constant SDMMC_DHOLD                    \ [0x09] Data transfer Hold
    $0a constant SDMMC_DBCKEND                  \ [0x0a] Data block sent/received
    $0b constant SDMMC_DABORT                   \ [0x0b] Data transfer aborted by CMD12
    $0c constant SDMMC_DPSMACT                  \ [0x0c] Data path state machine active, i.e. not in Idle state
    $0d constant SDMMC_CPSMACT                  \ [0x0d] Command path state machine active, i.e. not in Idle state
    $0e constant SDMMC_TXFIFOHE                 \ [0x0e] Transmit FIFO half empty
    $0f constant SDMMC_RXFIFOHF                 \ [0x0f] Receive FIFO half full
    $10 constant SDMMC_TXFIFOF                  \ [0x10] Transmit FIFO full
    $11 constant SDMMC_RXFIFOF                  \ [0x11] Receive FIFO full
    $12 constant SDMMC_TXFIFOE                  \ [0x12] Transmit FIFO empty
    $13 constant SDMMC_RXFIFOE                  \ [0x13] Receive FIFO empty
    $14 constant SDMMC_BUSYD0                   \ [0x14] Inverted value of SDMMC_D0 line (Busy), sampled at the end of a CMD response and a second time 2 SDMMC_CK cycles after the CMD response
    $15 constant SDMMC_BUSYD0END                \ [0x15] end of SDMMC_D0 Busy following a CMD response detected
    $16 constant SDMMC_SDIOIT                   \ [0x16] SDIO interrupt received
    $17 constant SDMMC_ACKFAIL                  \ [0x17] Boot acknowledgment received (boot acknowledgment check fail)
    $18 constant SDMMC_ACKTIMEOUT               \ [0x18] Boot acknowledgment timeout
    $19 constant SDMMC_VSWEND                   \ [0x19] Voltage switch critical timing section completion
    $1a constant SDMMC_CKSTOP                   \ [0x1a] SDMMC_CK stopped in Voltage switch procedure
    $1b constant SDMMC_IDMATE                   \ [0x1b] IDMA transfer error
    $1c constant SDMMC_IDMABTC                  \ [0x1c] IDMA buffer transfer complete
  [then]


  [ifdef] SDMMC_ICR_DEF
    \
    \ @brief interrupt clear register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CCRCFAILC                \ [0x00] CCRCFAIL flag clear bit
    $01 constant SDMMC_DCRCFAILC                \ [0x01] DCRCFAIL flag clear bit
    $02 constant SDMMC_CTIMEOUTC                \ [0x02] CTIMEOUT flag clear bit
    $03 constant SDMMC_DTIMEOUTC                \ [0x03] DTIMEOUT flag clear bit
    $04 constant SDMMC_TXUNDERRC                \ [0x04] TXUNDERR flag clear bit
    $05 constant SDMMC_RXOVERRC                 \ [0x05] RXOVERR flag clear bit
    $06 constant SDMMC_CMDRENDC                 \ [0x06] CMDREND flag clear bit
    $07 constant SDMMC_CMDSENTC                 \ [0x07] CMDSENT flag clear bit
    $08 constant SDMMC_DATAENDC                 \ [0x08] DATAEND flag clear bit
    $09 constant SDMMC_DHOLDC                   \ [0x09] DHOLD flag clear bit
    $0a constant SDMMC_DBCKENDC                 \ [0x0a] DBCKEND flag clear bit
    $0b constant SDMMC_DABORTC                  \ [0x0b] DABORT flag clear bit
    $15 constant SDMMC_BUSYD0ENDC               \ [0x15] BUSYD0END flag clear bit
    $16 constant SDMMC_SDIOITC                  \ [0x16] SDIOIT flag clear bit
    $17 constant SDMMC_ACKFAILC                 \ [0x17] ACKFAIL flag clear bit
    $18 constant SDMMC_ACKTIMEOUTC              \ [0x18] ACKTIMEOUT flag clear bit
    $19 constant SDMMC_VSWENDC                  \ [0x19] VSWEND flag clear bit
    $1a constant SDMMC_CKSTOPC                  \ [0x1a] CKSTOP flag clear bit
    $1b constant SDMMC_IDMATEC                  \ [0x1b] IDMA transfer error clear bit
    $1c constant SDMMC_IDMABTCC                 \ [0x1c] IDMA buffer transfer complete clear bit
  [then]


  [ifdef] SDMMC_MASKR_DEF
    \
    \ @brief mask register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CCRCFAILIE               \ [0x00] Command CRC fail interrupt enable
    $01 constant SDMMC_DCRCFAILIE               \ [0x01] Data CRC fail interrupt enable
    $02 constant SDMMC_CTIMEOUTIE               \ [0x02] Command timeout interrupt enable
    $03 constant SDMMC_DTIMEOUTIE               \ [0x03] Data timeout interrupt enable
    $04 constant SDMMC_TXUNDERRIE               \ [0x04] Tx FIFO underrun error interrupt enable
    $05 constant SDMMC_RXOVERRIE                \ [0x05] Rx FIFO overrun error interrupt enable
    $06 constant SDMMC_CMDRENDIE                \ [0x06] Command response received interrupt enable
    $07 constant SDMMC_CMDSENTIE                \ [0x07] Command sent interrupt enable
    $08 constant SDMMC_DATAENDIE                \ [0x08] Data end interrupt enable
    $09 constant SDMMC_DHOLDIE                  \ [0x09] Data hold interrupt enable
    $0a constant SDMMC_DBCKENDIE                \ [0x0a] Data block end interrupt enable
    $0b constant SDMMC_DABORTIE                 \ [0x0b] Data transfer aborted interrupt enable
    $0e constant SDMMC_TXFIFOHEIE               \ [0x0e] Tx FIFO half empty interrupt enable
    $0f constant SDMMC_RXFIFOHFIE               \ [0x0f] Rx FIFO half full interrupt enable
    $11 constant SDMMC_RXFIFOFIE                \ [0x11] Rx FIFO full interrupt enable
    $12 constant SDMMC_TXFIFOEIE                \ [0x12] Tx FIFO empty interrupt enable
    $15 constant SDMMC_BUSYD0ENDIE              \ [0x15] BUSYD0END interrupt enable
    $16 constant SDMMC_SDIOITIE                 \ [0x16] SDIO mode interrupt received interrupt enable
    $17 constant SDMMC_ACKFAILIE                \ [0x17] Acknowledgment Fail interrupt enable
    $18 constant SDMMC_ACKTIMEOUTIE             \ [0x18] Acknowledgment timeout interrupt enable
    $19 constant SDMMC_VSWENDIE                 \ [0x19] Voltage switch critical timing section completion interrupt enable
    $1a constant SDMMC_CKSTOPIE                 \ [0x1a] Voltage Switch clock stopped interrupt enable
    $1c constant SDMMC_IDMABTCIE                \ [0x1c] IDMA buffer transfer complete interrupt enable
  [then]


  [ifdef] SDMMC_ACKTIMER_DEF
    \
    \ @brief acknowledgment timer register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_ACKTIME                  \ [0x00 : 25] Boot acknowledgment timeout period
  [then]


  [ifdef] SDMMC_SDMMC_IDMACTRLR_DEF
    \
    \ @brief DMA control register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_IDMAEN                   \ [0x00] IDMA enable This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
    $01 constant SDMMC_IDMABMODE                \ [0x01] Buffer mode selection. This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
  [then]


  [ifdef] SDMMC_SDMMC_IDMABSIZER_DEF
    \
    \ @brief buffer size register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $05 constant SDMMC_IDMABNDT                 \ [0x05 : 12] Number of bytes per buffer
  [then]


  [ifdef] SDMMC_SDMMC_IDMABASER_DEF
    \
    \ @brief buffer base address register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_IDMABASE                 \ [0x00 : 32] Buffer memory base address bits [31:2], shall be word aligned (bit [1:0] are always 0 and read only)
  [then]


  [ifdef] SDMMC_SDMMC_IDMALAR_DEF
    \
    \ @brief linked list address register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $02 constant SDMMC_IDMALA                   \ [0x02 : 14] Acknowledge linked list buffer ready
    $1d constant SDMMC_ABR                      \ [0x1d] Acknowledge linked list buffer ready
    $1e constant SDMMC_ULS                      \ [0x1e] Update SDMMC_IDMABSIZE from the next linked list when in linked list mode (SDMMC_IDMACTRLR.IDMABMODE select linked list mode and ULA = 1)
    $1f constant SDMMC_ULA                      \ [0x1f] Update SDMMC_IDMALAR from linked list when in linked list mode (SDMMC_IDMACTRLR.IDMABMODE select linked list mode)
  [then]


  [ifdef] SDMMC_SDMMC_IDMABAR_DEF
    \
    \ @brief linked list memory base register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $02 constant SDMMC_IDMABA                   \ [0x02 : 30] Word aligned Linked list memory base address
  [then]


  [ifdef] SDMMC_FIFOR0_DEF
    \
    \ @brief data FIFO register 0
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data
  [then]


  [ifdef] SDMMC_FIFOR1_DEF
    \
    \ @brief data FIFO register 1
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data
  [then]


  [ifdef] SDMMC_FIFOR2_DEF
    \
    \ @brief data FIFO register 2
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data
  [then]


  [ifdef] SDMMC_FIFOR3_DEF
    \
    \ @brief data FIFO register 3
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data
  [then]


  [ifdef] SDMMC_FIFOR4_DEF
    \
    \ @brief data FIFO register 4
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data
  [then]


  [ifdef] SDMMC_FIFOR5_DEF
    \
    \ @brief data FIFO register 5
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data
  [then]


  [ifdef] SDMMC_FIFOR6_DEF
    \
    \ @brief data FIFO register 6
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data
  [then]


  [ifdef] SDMMC_FIFOR7_DEF
    \
    \ @brief data FIFO register 7
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data
  [then]


  [ifdef] SDMMC_FIFOR8_DEF
    \
    \ @brief data FIFO register 8
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data
  [then]


  [ifdef] SDMMC_FIFOR9_DEF
    \
    \ @brief data FIFO register 9
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data
  [then]


  [ifdef] SDMMC_FIFOR10_DEF
    \
    \ @brief data FIFO register 10
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data
  [then]


  [ifdef] SDMMC_FIFOR11_DEF
    \
    \ @brief data FIFO register 11
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data
  [then]


  [ifdef] SDMMC_FIFOR12_DEF
    \
    \ @brief data FIFO register 12
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data
  [then]


  [ifdef] SDMMC_FIFOR13_DEF
    \
    \ @brief data FIFO register 13
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data
  [then]


  [ifdef] SDMMC_FIFOR14_DEF
    \
    \ @brief data FIFO register 14
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data
  [then]


  [ifdef] SDMMC_FIFOR15_DEF
    \
    \ @brief data FIFO register 15
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data
  [then]

  \
  \ @brief Secure digital input/output MultiMediaCard interface
  \
  $00 constant SDMMC_POWER              \ power control register
  $04 constant SDMMC_CLKCR              \ clock control register
  $08 constant SDMMC_ARGR               \ argument register
  $0C constant SDMMC_CMDR               \ command register
  $10 constant SDMMC_RESPCMDR           \ command response register
  $14 constant SDMMC_RESP1              \ response 1 register
  $18 constant SDMMC_RESP2              \ response 2 register
  $1C constant SDMMC_RESP3              \ response 3 register
  $20 constant SDMMC_RESP4              \ response 4 register
  $24 constant SDMMC_DTIMER             \ data timer register
  $28 constant SDMMC_DLENR              \ data length register
  $2C constant SDMMC_DCTRL              \ data control register
  $30 constant SDMMC_DCNTR              \ data counter register
  $34 constant SDMMC_STAR               \ status register
  $38 constant SDMMC_ICR                \ interrupt clear register
  $3C constant SDMMC_MASKR              \ mask register
  $40 constant SDMMC_ACKTIMER           \ acknowledgment timer register
  $50 constant SDMMC_SDMMC_IDMACTRLR    \ DMA control register
  $54 constant SDMMC_SDMMC_IDMABSIZER   \ buffer size register
  $58 constant SDMMC_SDMMC_IDMABASER    \ buffer base address register
  $64 constant SDMMC_SDMMC_IDMALAR      \ linked list address register
  $68 constant SDMMC_SDMMC_IDMABAR      \ linked list memory base register
  $80 constant SDMMC_FIFOR0             \ data FIFO register 0
  $84 constant SDMMC_FIFOR1             \ data FIFO register 1
  $88 constant SDMMC_FIFOR2             \ data FIFO register 2
  $8C constant SDMMC_FIFOR3             \ data FIFO register 3
  $90 constant SDMMC_FIFOR4             \ data FIFO register 4
  $94 constant SDMMC_FIFOR5             \ data FIFO register 5
  $98 constant SDMMC_FIFOR6             \ data FIFO register 6
  $9C constant SDMMC_FIFOR7             \ data FIFO register 7
  $A0 constant SDMMC_FIFOR8             \ data FIFO register 8
  $A4 constant SDMMC_FIFOR9             \ data FIFO register 9
  $A8 constant SDMMC_FIFOR10            \ data FIFO register 10
  $AC constant SDMMC_FIFOR11            \ data FIFO register 11
  $B0 constant SDMMC_FIFOR12            \ data FIFO register 12
  $B4 constant SDMMC_FIFOR13            \ data FIFO register 13
  $B8 constant SDMMC_FIFOR14            \ data FIFO register 14
  $BC constant SDMMC_FIFOR15            \ data FIFO register 15

: SDMMC_DEF ; [then]
