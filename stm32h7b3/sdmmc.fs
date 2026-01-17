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
    $00 constant SDMMC_PWRCTRL                  \ [0x00 : 2] SDMMC state control bits. These bits can only be written when the SDMMC is not in the power-on state (PWRCTRL?11). These bits are used to define the functional state of the SDMMC signals: Any further write will be ignored, PWRCTRL value will keep 11.
    $02 constant SDMMC_VSWITCH                  \ [0x02] Voltage switch sequence start. This bit is used to start the timing critical section of the voltage switch sequence:
    $03 constant SDMMC_VSWITCHEN                \ [0x03] Voltage switch procedure enable. This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0). This bit is used to stop the SDMMC_CK after the voltage switch command response:
    $04 constant SDMMC_DIRPOL                   \ [0x04] Data and command direction signals polarity selection. This bit can only be written when the SDMMC is in the power-off state (PWRCTRL = 00).
  [then]


  [ifdef] SDMMC_SDMMC_CLKCR_DEF
    \
    \ @brief The SDMMC_CLKCR register controls the SDMMC_CK output clock, the SDMMC_RX_CLK receive clock, and the bus width.
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CLKDIV                   \ [0x00 : 10] Clock divide factor This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0). This field defines the divide factor between the input clock (SDMMCCLK) and the output clock (SDMMC_CK): SDMMC_CK frequency = SDMMCCLK / [2 * CLKDIV]. 0xx: etc.. xxx: etc..
    $0c constant SDMMC_PWRSAV                   \ [0x0c] Power saving configuration bit This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0) For power saving, the SDMMC_CK clock output can be disabled when the bus is idle by setting PWRSAV:
    $0e constant SDMMC_WIDBUS                   \ [0x0e : 2] Wide bus mode enable bit This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0)
    $10 constant SDMMC_NEGEDGE                  \ [0x10] SDMMC_CK dephasing selection bit for data and Command. This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0). When clock division = 1 (CLKDIV = 0), this bit has no effect. Data and Command change on SDMMC_CK falling edge. When clock division &gt;1 (CLKDIV &gt; 0) &amp; DDR = 0: - SDMMC_CK edge occurs on SDMMCCLK rising edge. When clock division >1 (CLKDIV > 0) & DDR = 1: - Data changed on the SDMMCCLK falling edge succeeding a SDMMC_CK edge. - SDMMC_CK edge occurs on SDMMCCLK rising edge. - Data changed on the SDMMC_CK falling edge succeeding a SDMMC_CK edge. - SDMMC_CK edge occurs on SDMMCCLK rising edge.
    $11 constant SDMMC_HWFC_EN                  \ [0x11] Hardware flow control enable This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0) When Hardware flow control is enabled, the meaning of the TXFIFOE and RXFIFOF flags change, please see SDMMC status register definition in Section56.8.11.
    $12 constant SDMMC_DDR                      \ [0x12] Data rate signaling selection This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0) DDR rate shall only be selected with 4-bit or 8-bit wide bus mode. (WIDBUS &gt; 00). DDR = 1 has no effect when WIDBUS = 00 (1-bit wide bus). DDR rate shall only be selected with clock division &gt;1. (CLKDIV &gt; 0)
    $13 constant SDMMC_BUSSPEED                 \ [0x13] Bus speed mode selection between DS, HS, SDR12, SDR25 and SDR50, DDR50, SDR104. This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0)
    $14 constant SDMMC_SELCLKRX                 \ [0x14 : 2] Receive clock selection. These bits can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0)
  [then]


  [ifdef] SDMMC_SDMMC_ARGR_DEF
    \
    \ @brief The SDMMC_ARGR register contains a 32-bit command argument, which is sent to a card as part of a command message.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CMDARG                   \ [0x00 : 32] Command argument. These bits can only be written by firmware when CPSM is disabled (CPSMEN = 0). Command argument sent to a card as part of a command message. If a command contains an argument, it must be loaded into this register before writing a command to the command register.
  [then]


  [ifdef] SDMMC_SDMMC_CMDR_DEF
    \
    \ @brief The SDMMC_CMDR register contains the command index and command type bits. The command index is sent to a card as part of a command message. The command type bits control the command path state machine (CPSM).
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CMDINDEX                 \ [0x00 : 6] Command index. This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0). The command index is sent to the card as part of a command message.
    $06 constant SDMMC_CMDTRANS                 \ [0x06] The CPSM treats the command as a data transfer command, stops the interrupt period, and signals DataEnable to the DPSM This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0). If this bit is set, the CPSM issues an end of interrupt period and issues DataEnable signal to the DPSM when the command is sent.
    $07 constant SDMMC_CMDSTOP                  \ [0x07] The CPSM treats the command as a Stop Transmission command and signals Abort to the DPSM. This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0). If this bit is set, the CPSM issues the Abort signal to the DPSM when the command is sent.
    $08 constant SDMMC_WAITRESP                 \ [0x08 : 2] Wait for response bits. This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0). They are used to configure whether the CPSM is to wait for a response, and if yes, which kind of response.
    $0a constant SDMMC_WAITINT                  \ [0x0a] CPSM waits for interrupt request. If this bit is set, the CPSM disables command timeout and waits for an card interrupt request (Response). If this bit is cleared in the CPSM Wait state, will cause the abort of the interrupt mode.
    $0b constant SDMMC_WAITPEND                 \ [0x0b] CPSM Waits for end of data transfer (CmdPend internal signal) from DPSM. This bit when set, the CPSM waits for the end of data transfer trigger before it starts sending a command. WAITPEND is only taken into account when DTMODE = MMC stream data transfer, WIDBUS = 1-bit wide bus mode, DPSMACT = 1 and DTDIR = from host to card.
    $0c constant SDMMC_CPSMEN                   \ [0x0c] Command path state machine (CPSM) Enable bit This bit is written 1 by firmware, and cleared by hardware when the CPSM enters the Idle state. If this bit is set, the CPSM is enabled. When DTEN = 1, no command will be transfered nor boot procedure will be started. CPSMEN is cleared to 0.
    $0d constant SDMMC_DTHOLD                   \ [0x0d] Hold new data block transmission and reception in the DPSM. If this bit is set, the DPSM will not move from the Wait_S state to the Send state or from the Wait_R state to the Receive state.
    $0e constant SDMMC_BOOTMODE                 \ [0x0e] Select the boot mode procedure to be used. This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0)
    $0f constant SDMMC_BOOTEN                   \ [0x0f] Enable boot mode procedure.
    $10 constant SDMMC_CMDSUSPEND               \ [0x10] The CPSM treats the command as a Suspend or Resume command and signals interrupt period start/end. This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0). CMDSUSPEND = 1 and CMDTRANS = 0 Suspend command, start interrupt period when response bit BS=0. CMDSUSPEND = 1 and CMDTRANS = 1 Resume command with data, end interrupt period when response bit DF=1.
  [then]


  [ifdef] SDMMC_SDMMC_RESPCMDR_DEF
    \
    \ @brief SDMMC command response register
    \ Address offset: 0x10
    \ Reset value: 0xA3C5DD01
    \
    $00 constant SDMMC_RESPCMD                  \ [0x00 : 6] Response command index
  [then]


  [ifdef] SDMMC_SDMMC_RESP1R_DEF
    \
    \ @brief The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CARDSTATUS1              \ [0x00 : 32] see Table 432
  [then]


  [ifdef] SDMMC_SDMMC_RESP2R_DEF
    \
    \ @brief The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CARDSTATUS2              \ [0x00 : 32] see Table404.
  [then]


  [ifdef] SDMMC_SDMMC_RESP3R_DEF
    \
    \ @brief The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CARDSTATUS3              \ [0x00 : 32] see Table404.
  [then]


  [ifdef] SDMMC_SDMMC_RESP4R_DEF
    \
    \ @brief The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CARDSTATUS4              \ [0x00 : 32] see Table404.
  [then]


  [ifdef] SDMMC_SDMMC_DTIMER_DEF
    \
    \ @brief The SDMMC_DTIMER register contains the data timeout period, in card bus clock periods. A counter loads the value from the SDMMC_DTIMER register, and starts decrementing when the data path state machine (DPSM) enters the Wait_R or Busy state. If the timer reaches 0 while the DPSM is in either of these states, the timeout status flag is set.
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_DATATIME                 \ [0x00 : 32] Data and R1b busy timeout period This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0). Data and R1b busy timeout period expressed in card bus clock periods.
  [then]


  [ifdef] SDMMC_SDMMC_DLENR_DEF
    \
    \ @brief The SDMMC_DLENR register contains the number of data bytes to be transferred. The value is loaded into the data counter when data transfer starts.
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_DATALENGTH               \ [0x00 : 25] Data length value This register can only be written by firmware when DPSM is inactive (DPSMACT = 0). Number of data bytes to be transferred. When DDR = 1 DATALENGTH is truncated to a multiple of 2. (The last odd byte is not transfered) When DATALENGTH = 0 no data will be transfered, when requested by a CPSMEN and CMDTRANS = 1 also no command will be transfered. DTEN and CPSMEN are cleared to 0.
  [then]


  [ifdef] SDMMC_SDMMC_DCTRL_DEF
    \
    \ @brief The SDMMC_DCTRL register control the data path state machine (DPSM).
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_DTEN                     \ [0x00] Data transfer enable bit This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0). This bit is cleared by Hardware when data transfer completes. This bit shall only be used to transfer data when no associated data transfer command is used, i.e. shall not be used with SD or eMMC cards.
    $01 constant SDMMC_DTDIR                    \ [0x01] Data transfer direction selection This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
    $02 constant SDMMC_DTMODE                   \ [0x02 : 2] Data transfer mode selection. This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
    $04 constant SDMMC_DBLOCKSIZE               \ [0x04 : 4] Data block size This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0). Define the data block length when the block data transfer mode is selected: When DATALENGTH is not a multiple of DBLOCKSIZE, the transfered data is truncated at a multiple of DBLOCKSIZE. (Any remain data will not be transfered.) When DDR = 1, DBLOCKSIZE = 0000 shall not be used. (No data will be transfered)
    $08 constant SDMMC_RWSTART                  \ [0x08] Read wait start. If this bit is set, read wait operation starts.
    $09 constant SDMMC_RWSTOP                   \ [0x09] Read wait stop This bit is written by firmware and auto cleared by hardware when the DPSM moves from the READ_WAIT state to the WAIT_R or IDLE state.
    $0a constant SDMMC_RWMOD                    \ [0x0a] Read wait mode. This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
    $0b constant SDMMC_SDIOEN                   \ [0x0b] SD I/O interrupt enable functions This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0). If this bit is set, the DPSM enables the SD I/O card specific interrupt operation.
    $0c constant SDMMC_BOOTACKEN                \ [0x0c] Enable the reception of the boot acknowledgment. This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
    $0d constant SDMMC_FIFORST                  \ [0x0d] FIFO reset, will flush any remaining data. This bit can only be written by firmware when IDMAEN= 0 and DPSM is active (DPSMACT = 1). This bit will only take effect when a transfer error or transfer hold occurs.
  [then]


  [ifdef] SDMMC_SDMMC_DCNTR_DEF
    \
    \ @brief The SDMMC_DCNTR register loads the value from the data length register (see SDMMC_DLENR) when the DPSM moves from the Idle state to the Wait_R or Wait_S state. As data is transferred, the counter decrements the value until it reaches 0. The DPSM then moves to the Idle state and when there has been no error, the data status end flag (DATAEND) is set.
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_DATACOUNT                \ [0x00 : 25] Data count value When read, the number of remaining data bytes to be transferred is returned. Write has no effect.
  [then]


  [ifdef] SDMMC_SDMMC_STAR_DEF
    \
    \ @brief The SDMMC_STAR register is a read-only register. It contains two types of flag:Static flags (bits [29,21,11:0]): these bits remain asserted until they are cleared by writing to the SDMMC interrupt Clear register (see SDMMC_ICR)Dynamic flags (bits [20:12]): these bits change state depending on the state of the underlying logic (for example, FIFO full and empty flags are asserted and de-asserted as data while written to the FIFO)
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_CCRCFAIL                 \ [0x00] Command response received (CRC check failed). Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $01 constant SDMMC_DCRCFAIL                 \ [0x01] Data block sent/received (CRC check failed). Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $02 constant SDMMC_CTIMEOUT                 \ [0x02] Command response timeout. Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR. The Command Timeout period has a fixed value of 64 SDMMC_CK clock periods.
    $03 constant SDMMC_DTIMEOUT                 \ [0x03] Data timeout. Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $04 constant SDMMC_TXUNDERR                 \ [0x04] Transmit FIFO underrun error or IDMA read transfer error. Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $05 constant SDMMC_RXOVERR                  \ [0x05] Received FIFO overrun error or IDMA write transfer error. Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $06 constant SDMMC_CMDREND                  \ [0x06] Command response received (CRC check passed, or no CRC). Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $07 constant SDMMC_CMDSENT                  \ [0x07] Command sent (no response required). Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $08 constant SDMMC_DATAEND                  \ [0x08] Data transfer ended correctly. (data counter, DATACOUNT is zero and no errors occur). Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $09 constant SDMMC_DHOLD                    \ [0x09] Data transfer Hold. Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $0a constant SDMMC_DBCKEND                  \ [0x0a] Data block sent/received. (CRC check passed) and DPSM moves to the READWAIT state. Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $0b constant SDMMC_DABORT                   \ [0x0b] Data transfer aborted by CMD12. Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $0c constant SDMMC_DPSMACT                  \ [0x0c] Data path state machine active, i.e. not in Idle state. This is a hardware status flag only, does not generate an interrupt.
    $0d constant SDMMC_CPSMACT                  \ [0x0d] Command path state machine active, i.e. not in Idle state. This is a hardware status flag only, does not generate an interrupt.
    $0e constant SDMMC_TXFIFOHE                 \ [0x0e] Transmit FIFO half empty At least half the number of words can be written into the FIFO. This bit is cleared when the FIFO becomes half+1 full.
    $0f constant SDMMC_RXFIFOHF                 \ [0x0f] Receive FIFO half full There are at least half the number of words in the FIFO. This bit is cleared when the FIFO becomes half+1 empty.
    $10 constant SDMMC_TXFIFOF                  \ [0x10] Transmit FIFO full This is a hardware status flag only, does not generate an interrupt. This bit is cleared when one FIFO location becomes empty.
    $11 constant SDMMC_RXFIFOF                  \ [0x11] Receive FIFO full This bit is cleared when one FIFO location becomes empty.
    $12 constant SDMMC_TXFIFOE                  \ [0x12] Transmit FIFO empty This bit is cleared when one FIFO location becomes full.
    $13 constant SDMMC_RXFIFOE                  \ [0x13] Receive FIFO empty This is a hardware status flag only, does not generate an interrupt. This bit is cleared when one FIFO location becomes full.
    $14 constant SDMMC_BUSYD0                   \ [0x14] Inverted value of SDMMC_D0 line (Busy), sampled at the end of a CMD response and a second time 2 SDMMC_CK cycles after the CMD response. This bit is reset to not busy when the SDMMCD0 line changes from busy to not busy. This bit does not signal busy due to data transfer. This is a hardware status flag only, it does not generate an interrupt.
    $15 constant SDMMC_BUSYD0END                \ [0x15] end of SDMMC_D0 Busy following a CMD response detected. This indicates only end of busy following a CMD response. This bit does not signal busy due to data transfer. Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $16 constant SDMMC_SDIOIT                   \ [0x16] SDIO interrupt received. Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $17 constant SDMMC_ACKFAIL                  \ [0x17] Boot acknowledgment received (boot acknowledgment check fail). Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $18 constant SDMMC_ACKTIMEOUT               \ [0x18] Boot acknowledgment timeout. Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $19 constant SDMMC_VSWEND                   \ [0x19] Voltage switch critical timing section completion. Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $1a constant SDMMC_CKSTOP                   \ [0x1a] SDMMC_CK stopped in Voltage switch procedure. Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $1b constant SDMMC_IDMATE                   \ [0x1b] IDMA transfer error. Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
    $1c constant SDMMC_IDMABTC                  \ [0x1c] IDMA buffer transfer complete. interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
  [then]


  [ifdef] SDMMC_SDMMC_ICR_DEF
    \
    \ @brief The SDMMC_ICR register is a write-only register. Writing a bit with 1 clears the corresponding bit in the SDMMC_STAR status register.
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
    \ @brief The interrupt mask register determines which status flags generate an interrupt request by setting the corresponding bit to 1.
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
    \ @brief The SDMMC_ACKTIMER register contains the acknowledgment timeout period, in SDMMC_CK bus clock periods. A counter loads the value from the SDMMC_ACKTIMER register, and starts decrementing when the data path state machine (DPSM) enters the Wait_Ack state. If the timer reaches 0 while the DPSM is in this states, the acknowledgment timeout status flag is set.
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_ACKTIME                  \ [0x00 : 25] Boot acknowledgment timeout period This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0). Boot acknowledgment timeout period expressed in card bus clock periods.
  [then]


  [ifdef] SDMMC_SDMMC_IDMACTRLR_DEF
    \
    \ @brief The receive and transmit FIFOs can be read or written as 32-bit wide registers. The FIFOs contain 32 entries on 32 sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO.
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_IDMAEN                   \ [0x00] IDMA enable This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
    $01 constant SDMMC_IDMABMODE                \ [0x01] Buffer mode selection. This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
    $02 constant SDMMC_IDMABACT                 \ [0x02] Double buffer mode active buffer indication This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0). When IDMA is enabled this bit is toggled by hardware.
  [then]


  [ifdef] SDMMC_SDMMC_IDMABSIZER_DEF
    \
    \ @brief The SDMMC_IDMABSIZER register contains the buffers size when in double buffer configuration.
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $05 constant SDMMC_IDMABNDT                 \ [0x05 : 8] Number of transfers per buffer. This 8-bit value shall be multiplied by 8 to get the size of the buffer in 32-bit words and by 32 to get the size of the buffer in bytes. Example: IDMABNDT = 0x01: buffer size = 8 words = 32 bytes. These bits can only be written by firmware when DPSM is inactive (DPSMACT = 0).
  [then]


  [ifdef] SDMMC_SDMMC_IDMABASE0R_DEF
    \
    \ @brief The SDMMC_IDMABASE0R register contains the memory buffer base address in single buffer configuration and the buffer 0 base address in double buffer configuration.
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_IDMABASE0                \ [0x00 : 32] Buffer 0 memory base address bits [31:2], shall be word aligned (bit [1:0] are always 0 and read only). This register can be written by firmware when DPSM is inactive (DPSMACT = 0), and can dynamically be written by firmware when DPSM active (DPSMACT = 1) and memory buffer 0 is inactive (IDMABACT = 1).
  [then]


  [ifdef] SDMMC_SDMMC_IDMABASE1R_DEF
    \
    \ @brief The SDMMC_IDMABASE1R register contains the double buffer configuration second buffer memory base address.
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_IDMABASE1                \ [0x00 : 32] Buffer 1 memory base address, shall be word aligned (bit [1:0] are always 0 and read only). This register can be written by firmware when DPSM is inactive (DPSMACT = 0), and can dynamically be written by firmware when DPSM active (DPSMACT = 1) and memory buffer 1 is inactive (IDMABACT = 0).
  [then]


  [ifdef] SDMMC_SDMMC_FIFOR_DEF
    \
    \ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO.When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant SDMMC_FIFODATA                 \ [0x00 : 32] Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT=1). The FIFO data occupies 16 entries of 32-bit words.
  [then]


  [ifdef] SDMMC_SDMMC_VER_DEF
    \
    \ @brief SDMMC IP version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant SDMMC_MINREV                   \ [0x00 : 4] IP minor revision number.
    $04 constant SDMMC_MAJREV                   \ [0x04 : 4] IP major revision number.
  [then]


  [ifdef] SDMMC_SDMMC_ID_DEF
    \
    \ @brief SDMMC IP identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00140022
    \
    $00 constant SDMMC_IP_ID                    \ [0x00 : 32] SDMMC IP identification.
  [then]

  \
  \ @brief SDMMC1
  \
  $00 constant SDMMC_SDMMC_POWER        \ SDMMC power control register
  $04 constant SDMMC_SDMMC_CLKCR        \ The SDMMC_CLKCR register controls the SDMMC_CK output clock, the SDMMC_RX_CLK receive clock, and the bus width.
  $08 constant SDMMC_SDMMC_ARGR         \ The SDMMC_ARGR register contains a 32-bit command argument, which is sent to a card as part of a command message.
  $0C constant SDMMC_SDMMC_CMDR         \ The SDMMC_CMDR register contains the command index and command type bits. The command index is sent to a card as part of a command message. The command type bits control the command path state machine (CPSM).
  $10 constant SDMMC_SDMMC_RESPCMDR     \ SDMMC command response register
  $14 constant SDMMC_SDMMC_RESP1R       \ The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
  $18 constant SDMMC_SDMMC_RESP2R       \ The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
  $1C constant SDMMC_SDMMC_RESP3R       \ The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
  $20 constant SDMMC_SDMMC_RESP4R       \ The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
  $24 constant SDMMC_SDMMC_DTIMER       \ The SDMMC_DTIMER register contains the data timeout period, in card bus clock periods. A counter loads the value from the SDMMC_DTIMER register, and starts decrementing when the data path state machine (DPSM) enters the Wait_R or Busy state. If the timer reaches 0 while the DPSM is in either of these states, the timeout status flag is set.
  $28 constant SDMMC_SDMMC_DLENR        \ The SDMMC_DLENR register contains the number of data bytes to be transferred. The value is loaded into the data counter when data transfer starts.
  $2C constant SDMMC_SDMMC_DCTRL        \ The SDMMC_DCTRL register control the data path state machine (DPSM).
  $30 constant SDMMC_SDMMC_DCNTR        \ The SDMMC_DCNTR register loads the value from the data length register (see SDMMC_DLENR) when the DPSM moves from the Idle state to the Wait_R or Wait_S state. As data is transferred, the counter decrements the value until it reaches 0. The DPSM then moves to the Idle state and when there has been no error, the data status end flag (DATAEND) is set.
  $34 constant SDMMC_SDMMC_STAR         \ The SDMMC_STAR register is a read-only register. It contains two types of flag:Static flags (bits [29,21,11:0]): these bits remain asserted until they are cleared by writing to the SDMMC interrupt Clear register (see SDMMC_ICR)Dynamic flags (bits [20:12]): these bits change state depending on the state of the underlying logic (for example, FIFO full and empty flags are asserted and de-asserted as data while written to the FIFO)
  $38 constant SDMMC_SDMMC_ICR          \ The SDMMC_ICR register is a write-only register. Writing a bit with 1 clears the corresponding bit in the SDMMC_STAR status register.
  $3C constant SDMMC_SDMMC_MASKR        \ The interrupt mask register determines which status flags generate an interrupt request by setting the corresponding bit to 1.
  $40 constant SDMMC_SDMMC_ACKTIMER     \ The SDMMC_ACKTIMER register contains the acknowledgment timeout period, in SDMMC_CK bus clock periods. A counter loads the value from the SDMMC_ACKTIMER register, and starts decrementing when the data path state machine (DPSM) enters the Wait_Ack state. If the timer reaches 0 while the DPSM is in this states, the acknowledgment timeout status flag is set.
  $50 constant SDMMC_SDMMC_IDMACTRLR    \ The receive and transmit FIFOs can be read or written as 32-bit wide registers. The FIFOs contain 32 entries on 32 sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO.
  $54 constant SDMMC_SDMMC_IDMABSIZER   \ The SDMMC_IDMABSIZER register contains the buffers size when in double buffer configuration.
  $58 constant SDMMC_SDMMC_IDMABASE0R   \ The SDMMC_IDMABASE0R register contains the memory buffer base address in single buffer configuration and the buffer 0 base address in double buffer configuration.
  $5C constant SDMMC_SDMMC_IDMABASE1R   \ The SDMMC_IDMABASE1R register contains the double buffer configuration second buffer memory base address.
  $80 constant SDMMC_SDMMC_FIFOR        \ The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO.When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
  $3F4 constant SDMMC_SDMMC_VER         \ SDMMC IP version register
  $3F8 constant SDMMC_SDMMC_ID          \ SDMMC IP identification register

: SDMMC_DEF ; [then]
