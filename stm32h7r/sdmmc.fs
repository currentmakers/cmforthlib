\
\ @file sdmmc.fs
\ @brief Secure digital input/output MultiMediaCard interface
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
    $00 constant SDMMC_PWRCTRL                  \ [0x00 : 2] SDMMC state control bits These bits can only be written when the SDMMC is not in the power-on state (PWRCTRL different from 11). These bits are used to define the functional state of the SDMMC signals: When written 00, power-off: the SDMMC is disabled and the clock to the card is stopped, SDMMC_D[7:0], SDMMC_CMD and SDMMC_CK are driven high. Any further write is ignored, PWRCTRL value keeps 11.
    $02 constant SDMMC_VSWITCH                  \ [0x02] Voltage switch sequence start This bit is used to start the timing critical section of the voltage switch sequence:
    $03 constant SDMMC_VSWITCHEN                \ [0x03] Voltage switch procedure enable This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0). This bit is used to stop the SDMMC_CK after the voltage switch command response:
    $04 constant SDMMC_DIRPOL                   \ [0x04] Data and command direction signals polarity selection This bit can only be written when the SDMMC is in the power-off state (PWRCTRL = 00).
  [then]


  [ifdef] SDMMC_SDMMC_CLKCR_DEF
    \
    \ @brief SDMMC clock control register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CLKDIV                   \ [0x00 : 10] Clock divide factor This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0). This field defines the divide factor between the input clock (sdmmc_ker_ck) and the output clock (SDMMC_CK): SDMMC_CK frequency = sdmmc_ker_ck / [2 * CLKDIV]. 0x0XX: etc.. 0xXXX: etc..
    $0c constant SDMMC_PWRSAV                   \ [0x0c] Power saving configuration bit This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0) For power saving, the SDMMC_CK clock output can be disabled when the bus is idle by setting PWRSAV:
    $0e constant SDMMC_WIDBUS                   \ [0x0e : 2] Wide bus mode enable bit This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0)
    $10 constant SDMMC_NEGEDGE                  \ [0x10] SDMMC_CK dephasing selection bit for data and command This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0). When clock division = 1 (CLKDIV = 0), this bit has no effect. Data and Command change on SDMMC_CK falling edge. Command and data changed on the sdmmc_ker_ck falling edge succeeding the rising edge of SDMMC_CK. SDMMC_CK edge occurs on sdmmc_ker_ck rising edge. When clock division >1 (CLKDIV > 0) & DDR = 1: Command changed on the sdmmc_ker_ck falling edge succeeding the rising edge of SDMMC_CK. Data changed on the sdmmc_ker_ck falling edge succeeding a SDMMC_CK edge. SDMMC_CK edge occurs on sdmmc_ker_ck rising edge. Command and data changed on the same sdmmc_ker_ck rising edge generating the SDMMC_CK falling edge. When clock division >1 (CLKDIV > 0) & DDR = 1: Command changed on the same sdmmc_ker_ck rising edge generating the SDMMC_CK falling edge. Data changed on the SDMMC_CK falling edge succeeding a SDMMC_CK edge. SDMMC_CK edge occurs on sdmmc_ker_ck rising edge.
    $11 constant SDMMC_HWFC_EN                  \ [0x11] Hardware flow control enable This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0) When Hardware flow control is enabled, the meaning of the TXFIFOE and RXFIFOF flags change, see SDMMC status register definition in Section 58.10.11.
    $12 constant SDMMC_DDR                      \ [0x12] Data rate signaling selection This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0) DDR rate must only be selected with 4-bit or 8-bit wide bus mode. (WIDBUS > 00). DDR = 1 has no effect when WIDBUS = 00 (1-bit wide bus). DDR rate must only be selected with clock division >1. (CLKDIV > 0)
    $13 constant SDMMC_BUSSPEED                 \ [0x13] Bus speed for selection of SDMMC operating modes This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0)
    $14 constant SDMMC_SELCLKRX                 \ [0x14 : 2] Receive clock selection These bits can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0)
  [then]


  [ifdef] SDMMC_SDMMC_ARGR_DEF
    \
    \ @brief SDMMC argument register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CMDARG                   \ [0x00 : 32] Command argument These bits can only be written by firmware when CPSM is disabled (CPSMEN = 0). Command argument sent to a card as part of a command message. If a command contains an argument, it must be loaded into this register before writing a command to the command register.
  [then]


  [ifdef] SDMMC_SDMMC_CMDR_DEF
    \
    \ @brief SDMMC command register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CMDINDEX                 \ [0x00 : 6] Command index This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0). The command index is sent to the card as part of a command message.
    $06 constant SDMMC_CMDTRANS                 \ [0x06] The CPSM treats the command as a data transfer command, stops the interrupt period, and signals DataEnable to the DPSM This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0). If this bit is set, the CPSM issues an end of interrupt period and issues DataEnable signal to the DPSM when the command is sent.
    $07 constant SDMMC_CMDSTOP                  \ [0x07] The CPSM treats the command as a Stop Transmission command and signals abort to the DPSM This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0). If this bit is set, the CPSM issues the abort signal to the DPSM when the command is sent.
    $08 constant SDMMC_WAITRESP                 \ [0x08 : 2] Wait for response bits This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0). They are used to configure whether the CPSM is to wait for a response, and if yes, which kind of response.
    $0a constant SDMMC_WAITINT                  \ [0x0a] CPSM waits for interrupt request If this bit is set, the CPSM disables command timeout and waits for an card interrupt request (Response). If this bit is cleared in the CPSM Wait state, it causes the abort of the interrupt mode.
    $0b constant SDMMC_WAITPEND                 \ [0x0b] CPSM waits for end of data transfer (CmdPend internal signal) from DPSM This bit when set, the CPSM waits for the end of data transfer trigger before it starts sending a command. WAITPEND is only taken into account when DTMODE = e.MMC stream data transfer, WIDBUS = 1-bit wide bus mode, DPSMACT = 1 and DTDIR = from host to card.
    $0c constant SDMMC_CPSMEN                   \ [0x0c] Command path state machine (CPSM) enable bit This bit is written 1 by firmware, and cleared by hardware when the CPSM enters the Idle state. If this bit is set, the CPSM is enabled. When DTEN = 1, no command is transfered nor boot procedure is started. CPSMEN is cleared to 0. During Read Wait with SDMMC_CK stopped no command is sent and CPSMEN is kept 0.
    $0d constant SDMMC_DTHOLD                   \ [0x0d] Hold new data block transmission and reception in the DPSM If this bit is set, the DPSM does not move from the Wait_S state to the Send state or from the Wait_R state to the Receive state.
    $0e constant SDMMC_BOOTMODE                 \ [0x0e] Select the boot mode procedure to be used This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0)
    $0f constant SDMMC_BOOTEN                   \ [0x0f] Enable boot mode procedure
    $10 constant SDMMC_CMDSUSPEND               \ [0x10] The CPSM treats the command as a Suspend or Resume command and signals interrupt period start/end This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0). CMDSUSPEND = 1 and CMDTRANS = 0 Suspend command, start interrupt period when response bit BS=0. CMDSUSPEND = 1 and CMDTRANS = 1 Resume command with data, end interrupt period when response bit DF=1.
  [then]


  [ifdef] SDMMC_SDMMC_RESPCMDR_DEF
    \
    \ @brief SDMMC command response register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_RESPCMD                  \ [0x00 : 6] Response command index Read-only bit field. Contains the command index of the last command response received.
  [then]


  [ifdef] SDMMC_SDMMC_RESP1R_DEF
    \
    \ @brief SDMMC response 1 register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CARDSTATUS               \ [0x00 : 32] Card status according table below See Table 444.
  [then]


  [ifdef] SDMMC_SDMMC_RESP2R_DEF
    \
    \ @brief SDMMC response 2 register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CARDSTATUS               \ [0x00 : 32] Card status according table below See Table 444.
  [then]


  [ifdef] SDMMC_SDMMC_RESP3R_DEF
    \
    \ @brief SDMMC response 3 register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CARDSTATUS               \ [0x00 : 32] Card status according table below See Table 444.
  [then]


  [ifdef] SDMMC_SDMMC_RESP4R_DEF
    \
    \ @brief SDMMC response 4 register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CARDSTATUS               \ [0x00 : 32] Card status according table below See Table 444.
  [then]


  [ifdef] SDMMC_SDMMC_DTIMER_DEF
    \
    \ @brief SDMMC data timer register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_DATATIME                 \ [0x00 : 32] Data and R1b busy timeout period This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0). Data and R1b busy timeout period expressed in card bus clock periods.
  [then]


  [ifdef] SDMMC_SDMMC_DLENR_DEF
    \
    \ @brief SDMMC data length register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_DATALENGTH               \ [0x00 : 25] Data length value This register can only be written by firmware when DPSM is inactive (DPSMACT = 0). Number of data bytes to be transferred. When DDR = 1 DATALENGTH is truncated to a multiple of 2. (The last odd byte is not transfered) When DATALENGTH = 0 no data are transfered, when requested by a CPSMEN and CMDTRANS = 1 also no command is transfered. DTEN and CPSMEN are cleared to 0.
  [then]


  [ifdef] SDMMC_SDMMC_DCTRL_DEF
    \
    \ @brief SDMMC data control register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_DTEN                     \ [0x00] Data transfer enable bit This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0). This bit is cleared by Hardware when data transfer completes. This bit must only be used to transfer data when no associated data transfer command is used, i.e. must not be used with SD or e.MMC cards.
    $01 constant SDMMC_DTDIR                    \ [0x01] Data transfer direction selection This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
    $02 constant SDMMC_DTMODE                   \ [0x02 : 2] Data transfer mode selection This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
    $04 constant SDMMC_DBLOCKSIZE               \ [0x04 : 4] Data block size This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0). Define the data block length when the block data transfer mode is selected: When DATALENGTH is not a multiple of DBLOCKSIZE, the transfered data is truncated at a multiple of DBLOCKSIZE. (None of the remaining data are transfered.) When DDR = 1, DBLOCKSIZE = 0000 must not be used. (No data are transfered)
    $08 constant SDMMC_RWSTART                  \ [0x08] Read Wait start If this bit is set, Read Wait operation starts.
    $09 constant SDMMC_RWSTOP                   \ [0x09] Read Wait stop This bit is written by firmware and auto cleared by hardware when the DPSM moves from the R_W state to the Wait_R or Idle state.
    $0a constant SDMMC_RWMOD                    \ [0x0a] Read Wait mode This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
    $0b constant SDMMC_SDIOEN                   \ [0x0b] SD I/O interrupt enable functions This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0). If this bit is set, the DPSM enables the SD I/O card specific interrupt operation.
    $0c constant SDMMC_BOOTACKEN                \ [0x0c] Enable the reception of the boot acknowledgment This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
    $0d constant SDMMC_FIFORST                  \ [0x0d] FIFO reset, flushes any remaining data This bit can only be written by firmware when IDMAEN= 0 and DPSM is active (DPSMACT = 1). This bit only takes effect when a transfer error or transfer hold occurs.
  [then]


  [ifdef] SDMMC_SDMMC_DCNTR_DEF
    \
    \ @brief SDMMC data counter register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_DATACOUNT                \ [0x00 : 25] Data count value When read, the number of remaining data bytes to be transferred is returned. Write has no effect.
  [then]


  [ifdef] SDMMC_SDMMC_STAR_DEF
    \
    \ @brief SDMMC status register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CCRCFAIL                 \ [0x00] Command response received (CRC check failed) Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $01 constant SDMMC_DCRCFAIL                 \ [0x01] Data block sent/received (CRC check failed) Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $02 constant SDMMC_CTIMEOUT                 \ [0x02] Command response timeout Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR. The Command Timeout period has a fixed value of 64 SDMMC_CK clock periods.
    $03 constant SDMMC_DTIMEOUT                 \ [0x03] Data timeout Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $04 constant SDMMC_TXUNDERR                 \ [0x04] Transmit FIFO underrun error (masked by hardware when IDMA is enabled) Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $05 constant SDMMC_RXOVERR                  \ [0x05] Received FIFO overrun error (masked by hardware when IDMA is enabled) Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $06 constant SDMMC_CMDREND                  \ [0x06] Command response received (CRC check passed, or no CRC) Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $07 constant SDMMC_CMDSENT                  \ [0x07] Command sent (no response required) Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $08 constant SDMMC_DATAEND                  \ [0x08] Data transfer ended correctly DATAEND is set if data counter DATACOUNT is zero and no errors occur, and no transmit data transfer hold. Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $09 constant SDMMC_DHOLD                    \ [0x09] Data transfer Hold Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $0a constant SDMMC_DBCKEND                  \ [0x0a] Data block sent/received DBCKEND is set when: - CRC check passed and DPSM moves to the R_W state or - IDMAEN = 0 and transmit data transfer hold and DATACOUNT >0 and DPSM moves to Wait_S. Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $0b constant SDMMC_DABORT                   \ [0x0b] Data transfer aborted by CMD12 Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $0c constant SDMMC_DPSMACT                  \ [0x0c] Data path state machine active, i.e. not in Idle state This is a hardware status flag only, does not generate an interrupt.
    $0d constant SDMMC_CPSMACT                  \ [0x0d] Command path state machine active, i.e. not in Idle state This is a hardware status flag only, does not generate an interrupt.
    $0e constant SDMMC_TXFIFOHE                 \ [0x0e] Transmit FIFO half empty At least half the number of words can be written into the FIFO. This bit is cleared when the FIFO becomes half+1 full.
    $0f constant SDMMC_RXFIFOHF                 \ [0x0f] Receive FIFO half full There are at least half the number of words in the FIFO. This bit is cleared when the FIFO becomes half+1 empty.
    $10 constant SDMMC_TXFIFOF                  \ [0x10] Transmit FIFO full This is a hardware status flag only, does not generate an interrupt. This bit is cleared when one FIFO location becomes empty.
    $11 constant SDMMC_RXFIFOF                  \ [0x11] Receive FIFO full This bit is cleared when one FIFO location becomes empty.
    $12 constant SDMMC_TXFIFOE                  \ [0x12] Transmit FIFO empty This bit is cleared when one FIFO location becomes full.
    $13 constant SDMMC_RXFIFOE                  \ [0x13] Receive FIFO empty This is a hardware status flag only, does not generate an interrupt. This bit is cleared when one FIFO location becomes full.
    $14 constant SDMMC_BUSYD0                   \ [0x14] Inverted value of SDMMC_D0 line (Busy), sampled at the end of a CMD response and a second time 2 SDMMC_CK cycles after the CMD response This bit is reset to not busy when the SDMMCD0 line changes from busy to not busy. This bit does not signal busy due to data transfer. This is a hardware status flag only, it does not generate an interrupt.
    $15 constant SDMMC_BUSYD0END                \ [0x15] end of SDMMC_D0 Busy following a CMD response detected This indicates only end of busy following a CMD response. This bit does not signal busy due to data transfer. Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $16 constant SDMMC_SDIOIT                   \ [0x16] SDIO interrupt received The interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $17 constant SDMMC_ACKFAIL                  \ [0x17] Boot acknowledgment received (boot acknowledgment check fail) The interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $18 constant SDMMC_ACKTIMEOUT               \ [0x18] Boot acknowledgment timeout The interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $19 constant SDMMC_VSWEND                   \ [0x19] Voltage switch critical timing section completion The interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $1a constant SDMMC_CKSTOP                   \ [0x1a] SDMMC_CK stopped in Voltage switch procedure The interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $1b constant SDMMC_IDMATE                   \ [0x1b] IDMA transfer error The interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $1c constant SDMMC_IDMABTC                  \ [0x1c] IDMA buffer transfer complete The interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
  [then]


  [ifdef] SDMMC_SDMMC_ICR_DEF
    \
    \ @brief SDMMC interrupt clear register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CCRCFAILC                \ [0x00] CCRCFAIL flag clear bit Set by software to clear the CCRCFAIL flag.
    $01 constant SDMMC_DCRCFAILC                \ [0x01] DCRCFAIL flag clear bit Set by software to clear the DCRCFAIL flag.
    $02 constant SDMMC_CTIMEOUTC                \ [0x02] CTIMEOUT flag clear bit Set by software to clear the CTIMEOUT flag.
    $03 constant SDMMC_DTIMEOUTC                \ [0x03] DTIMEOUT flag clear bit Set by software to clear the DTIMEOUT flag.
    $04 constant SDMMC_TXUNDERRC                \ [0x04] TXUNDERR flag clear bit Set by software to clear TXUNDERR flag.
    $05 constant SDMMC_RXOVERRC                 \ [0x05] RXOVERR flag clear bit Set by software to clear the RXOVERR flag.
    $06 constant SDMMC_CMDRENDC                 \ [0x06] CMDREND flag clear bit Set by software to clear the CMDREND flag.
    $07 constant SDMMC_CMDSENTC                 \ [0x07] CMDSENT flag clear bit Set by software to clear the CMDSENT flag.
    $08 constant SDMMC_DATAENDC                 \ [0x08] DATAEND flag clear bit Set by software to clear the DATAEND flag.
    $09 constant SDMMC_DHOLDC                   \ [0x09] DHOLD flag clear bit Set by software to clear the DHOLD flag.
    $0a constant SDMMC_DBCKENDC                 \ [0x0a] DBCKEND flag clear bit Set by software to clear the DBCKEND flag.
    $0b constant SDMMC_DABORTC                  \ [0x0b] DABORT flag clear bit Set by software to clear the DABORT flag.
    $15 constant SDMMC_BUSYD0ENDC               \ [0x15] BUSYD0END flag clear bit Set by software to clear the BUSYD0END flag.
    $16 constant SDMMC_SDIOITC                  \ [0x16] SDIOIT flag clear bit Set by software to clear the SDIOIT flag.
    $17 constant SDMMC_ACKFAILC                 \ [0x17] ACKFAIL flag clear bit Set by software to clear the ACKFAIL flag.
    $18 constant SDMMC_ACKTIMEOUTC              \ [0x18] ACKTIMEOUT flag clear bit Set by software to clear the ACKTIMEOUT flag.
    $19 constant SDMMC_VSWENDC                  \ [0x19] VSWEND flag clear bit Set by software to clear the VSWEND flag.
    $1a constant SDMMC_CKSTOPC                  \ [0x1a] CKSTOP flag clear bit Set by software to clear the CKSTOP flag.
    $1b constant SDMMC_IDMATEC                  \ [0x1b] IDMA transfer error clear bit Set by software to clear the IDMATE flag.
    $1c constant SDMMC_IDMABTCC                 \ [0x1c] IDMA buffer transfer complete clear bit Set by software to clear the IDMABTC flag.
  [then]


  [ifdef] SDMMC_SDMMC_MASKR_DEF
    \
    \ @brief SDMMC mask register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CCRCFAILIE               \ [0x00] Command CRC fail interrupt enable Set and cleared by software to enable/disable interrupt caused by command CRC failure.
    $01 constant SDMMC_DCRCFAILIE               \ [0x01] Data CRC fail interrupt enable Set and cleared by software to enable/disable interrupt caused by data CRC failure.
    $02 constant SDMMC_CTIMEOUTIE               \ [0x02] Command timeout interrupt enable Set and cleared by software to enable/disable interrupt caused by command timeout.
    $03 constant SDMMC_DTIMEOUTIE               \ [0x03] Data timeout interrupt enable Set and cleared by software to enable/disable interrupt caused by data timeout.
    $04 constant SDMMC_TXUNDERRIE               \ [0x04] Tx FIFO underrun error interrupt enable Set and cleared by software to enable/disable interrupt caused by Tx FIFO underrun error.
    $05 constant SDMMC_RXOVERRIE                \ [0x05] Rx FIFO overrun error interrupt enable Set and cleared by software to enable/disable interrupt caused by Rx FIFO overrun error.
    $06 constant SDMMC_CMDRENDIE                \ [0x06] Command response received interrupt enable Set and cleared by software to enable/disable interrupt caused by receiving command response.
    $07 constant SDMMC_CMDSENTIE                \ [0x07] Command sent interrupt enable Set and cleared by software to enable/disable interrupt caused by sending command.
    $08 constant SDMMC_DATAENDIE                \ [0x08] Data end interrupt enable Set and cleared by software to enable/disable interrupt caused by data end.
    $09 constant SDMMC_DHOLDIE                  \ [0x09] Data hold interrupt enable Set and cleared by software to enable/disable the interrupt generated when sending new data is hold in the DPSM Wait_S state.
    $0a constant SDMMC_DBCKENDIE                \ [0x0a] Data block end interrupt enable Set and cleared by software to enable/disable interrupt caused by data block end.
    $0b constant SDMMC_DABORTIE                 \ [0x0b] Data transfer aborted interrupt enable Set and cleared by software to enable/disable interrupt caused by a data transfer being aborted.
    $0e constant SDMMC_TXFIFOHEIE               \ [0x0e] Tx FIFO half empty interrupt enable Set and cleared by software to enable/disable interrupt caused by Tx FIFO half empty.
    $0f constant SDMMC_RXFIFOHFIE               \ [0x0f] Rx FIFO half full interrupt enable Set and cleared by software to enable/disable interrupt caused by Rx FIFO half full.
    $11 constant SDMMC_RXFIFOFIE                \ [0x11] Rx FIFO full interrupt enable Set and cleared by software to enable/disable interrupt caused by Rx FIFO full.
    $12 constant SDMMC_TXFIFOEIE                \ [0x12] Tx FIFO empty interrupt enable Set and cleared by software to enable/disable interrupt caused by Tx FIFO empty.
    $15 constant SDMMC_BUSYD0ENDIE              \ [0x15] BUSYD0END interrupt enable Set and cleared by software to enable/disable the interrupt generated when SDMMC_D0 signal changes from busy to NOT busy following a CMD response.
    $16 constant SDMMC_SDIOITIE                 \ [0x16] SDIO mode interrupt received interrupt enable Set and cleared by software to enable/disable the interrupt generated when receiving the SDIO mode interrupt.
    $17 constant SDMMC_ACKFAILIE                \ [0x17] Acknowledgment Fail interrupt enable Set and cleared by software to enable/disable interrupt caused by acknowledgment Fail.
    $18 constant SDMMC_ACKTIMEOUTIE             \ [0x18] Acknowledgment timeout interrupt enable Set and cleared by software to enable/disable interrupt caused by acknowledgment timeout.
    $19 constant SDMMC_VSWENDIE                 \ [0x19] Voltage switch critical timing section completion interrupt enable Set and cleared by software to enable/disable the interrupt generated when voltage switch critical timing section completion.
    $1a constant SDMMC_CKSTOPIE                 \ [0x1a] Voltage Switch clock stopped interrupt enable Set and cleared by software to enable/disable interrupt caused by Voltage Switch clock stopped.
    $1c constant SDMMC_IDMABTCIE                \ [0x1c] IDMA buffer transfer complete interrupt enable Set and cleared by software to enable/disable the interrupt generated when the IDMA has transferred all data belonging to a memory buffer.
  [then]


  [ifdef] SDMMC_SDMMC_ACKTIMER_DEF
    \
    \ @brief SDMMC acknowledgment timer register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_ACKTIME                  \ [0x00 : 25] Boot acknowledgment timeout period This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0). Boot acknowledgment timeout period expressed in card bus clock periods.
  [then]


  [ifdef] SDMMC_SDMMC_IDMACTRLR_DEF
    \
    \ @brief SDMMC DMA control register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_IDMAEN                   \ [0x00] IDMA enable This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
    $01 constant SDMMC_IDMABMODE                \ [0x01] Buffer mode selection This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
  [then]


  [ifdef] SDMMC_SDMMC_IDMABSIZER_DEF
    \
    \ @brief SDMMC IDMA buffer size register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $05 constant SDMMC_IDMABNDT                 \ [0x05 : 12] Number of bytes per buffer This 12-bit value must be multiplied by 8 to get the size of the buffer in 32-bit words and by 32 to get the size of the buffer in bytes. Example: IDMABNDT = 0x001: buffer size = 8 words = 32 bytes. Example: IDMABNDT = 0x800: buffer size = 16384 words = 64 Kbyte. These bits can only be written by firmware when DPSM is inactive (DPSMACT = 0).
  [then]


  [ifdef] SDMMC_SDMMC_IDMABASER_DEF
    \
    \ @brief SDMMC IDMA buffer base address register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_IDMABASE                 \ [0x00 : 32] Buffer memory base address bits [31:2], must be word aligned (bit [1:0] are always 0 and read only) This register can be written by firmware when DPSM is inactive (DPSMACT = 0), and can dynamically be written by firmware when DPSM active (DPSMACT = 1).
  [then]


  [ifdef] SDMMC_SDMMC_IDMALAR_DEF
    \
    \ @brief SDMMC IDMA linked list address register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $02 constant SDMMC_IDMALA                   \ [0x02 : 14] Word aligned linked list item address offset Linked list item offset pointer to the base of the next linked list item structure. Linked list item base address is IDMABA + IDMALA. These bits can only be written by firmware when DPSM is inactive (DPSMACT = 0).
    $1d constant SDMMC_ABR                      \ [0x1d] Acknowledge linked list buffer ready This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0). This bit is not taken into account when starting the first linked list buffer from the software programmed register information. ABR is only taken into account on subsequent loaded linked list items.
    $1e constant SDMMC_ULS                      \ [0x1e] Update SDMMC_IDMABSIZE from the next linked list when in linked list mode (SDMMC_IDMACTRLR.IDMABMODE select linked list mode and ULA = 1) This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
    $1f constant SDMMC_ULA                      \ [0x1f] Update SDMMC_IDMALAR from linked list when in linked list mode (SDMMC_IDMACTRLR.IDMABMODE select linked list mode) This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
  [then]


  [ifdef] SDMMC_SDMMC_IDMABAR_DEF
    \
    \ @brief SDMMC IDMA linked list memory base register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $02 constant SDMMC_IDMABA                   \ [0x02 : 30] Word aligned Linked list memory base address Linked list memory base pointer. These bits can only be written by firmware when DPSM is inactive (DPSMACT = 0).
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR0_DEF
    \
    \ @brief SDMMC data FIFO registers 0
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR1_DEF
    \
    \ @brief SDMMC data FIFO registers 1
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR2_DEF
    \
    \ @brief SDMMC data FIFO registers 2
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR3_DEF
    \
    \ @brief SDMMC data FIFO registers 3
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR4_DEF
    \
    \ @brief SDMMC data FIFO registers 4
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR5_DEF
    \
    \ @brief SDMMC data FIFO registers 5
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR6_DEF
    \
    \ @brief SDMMC data FIFO registers 6
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR7_DEF
    \
    \ @brief SDMMC data FIFO registers 7
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR8_DEF
    \
    \ @brief SDMMC data FIFO registers 8
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR9_DEF
    \
    \ @brief SDMMC data FIFO registers 9
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR10_DEF
    \
    \ @brief SDMMC data FIFO registers 10
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR11_DEF
    \
    \ @brief SDMMC data FIFO registers 11
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR12_DEF
    \
    \ @brief SDMMC data FIFO registers 12
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR13_DEF
    \
    \ @brief SDMMC data FIFO registers 13
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR14_DEF
    \
    \ @brief SDMMC data FIFO registers 14
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR15_DEF
    \
    \ @brief SDMMC data FIFO registers 15
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.
  [then]

  \
  \ @brief Secure digital input/output MultiMediaCard interface
  \
  $00 constant SDMMC_SDMMC_POWER        \ SDMMC power control register
  $04 constant SDMMC_SDMMC_CLKCR        \ SDMMC clock control register
  $08 constant SDMMC_SDMMC_ARGR         \ SDMMC argument register
  $0C constant SDMMC_SDMMC_CMDR         \ SDMMC command register
  $10 constant SDMMC_SDMMC_RESPCMDR     \ SDMMC command response register
  $14 constant SDMMC_SDMMC_RESP1R       \ SDMMC response 1 register
  $18 constant SDMMC_SDMMC_RESP2R       \ SDMMC response 2 register
  $1C constant SDMMC_SDMMC_RESP3R       \ SDMMC response 3 register
  $20 constant SDMMC_SDMMC_RESP4R       \ SDMMC response 4 register
  $24 constant SDMMC_SDMMC_DTIMER       \ SDMMC data timer register
  $28 constant SDMMC_SDMMC_DLENR        \ SDMMC data length register
  $2C constant SDMMC_SDMMC_DCTRL        \ SDMMC data control register
  $30 constant SDMMC_SDMMC_DCNTR        \ SDMMC data counter register
  $34 constant SDMMC_SDMMC_STAR         \ SDMMC status register
  $38 constant SDMMC_SDMMC_ICR          \ SDMMC interrupt clear register
  $3C constant SDMMC_SDMMC_MASKR        \ SDMMC mask register
  $40 constant SDMMC_SDMMC_ACKTIMER     \ SDMMC acknowledgment timer register
  $50 constant SDMMC_SDMMC_IDMACTRLR    \ SDMMC DMA control register
  $54 constant SDMMC_SDMMC_IDMABSIZER   \ SDMMC IDMA buffer size register
  $58 constant SDMMC_SDMMC_IDMABASER    \ SDMMC IDMA buffer base address register
  $64 constant SDMMC_SDMMC_IDMALAR      \ SDMMC IDMA linked list address register
  $68 constant SDMMC_SDMMC_IDMABAR      \ SDMMC IDMA linked list memory base register
  $80 constant SDMMC_SDMMC_FIFOR0       \ SDMMC data FIFO registers 0
  $84 constant SDMMC_SDMMC_FIFOR1       \ SDMMC data FIFO registers 1
  $88 constant SDMMC_SDMMC_FIFOR2       \ SDMMC data FIFO registers 2
  $8C constant SDMMC_SDMMC_FIFOR3       \ SDMMC data FIFO registers 3
  $90 constant SDMMC_SDMMC_FIFOR4       \ SDMMC data FIFO registers 4
  $94 constant SDMMC_SDMMC_FIFOR5       \ SDMMC data FIFO registers 5
  $98 constant SDMMC_SDMMC_FIFOR6       \ SDMMC data FIFO registers 6
  $9C constant SDMMC_SDMMC_FIFOR7       \ SDMMC data FIFO registers 7
  $A0 constant SDMMC_SDMMC_FIFOR8       \ SDMMC data FIFO registers 8
  $A4 constant SDMMC_SDMMC_FIFOR9       \ SDMMC data FIFO registers 9
  $A8 constant SDMMC_SDMMC_FIFOR10      \ SDMMC data FIFO registers 10
  $AC constant SDMMC_SDMMC_FIFOR11      \ SDMMC data FIFO registers 11
  $B0 constant SDMMC_SDMMC_FIFOR12      \ SDMMC data FIFO registers 12
  $B4 constant SDMMC_SDMMC_FIFOR13      \ SDMMC data FIFO registers 13
  $B8 constant SDMMC_SDMMC_FIFOR14      \ SDMMC data FIFO registers 14
  $BC constant SDMMC_SDMMC_FIFOR15      \ SDMMC data FIFO registers 15

: SDMMC_DEF ; [then]
