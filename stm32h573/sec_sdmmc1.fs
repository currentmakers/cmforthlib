\
\ @file sec_sdmmc1.fs
\ @brief Secure digital input/output MultiMediaCard interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SDMMC_POWER
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant SEC_SDMMC1_SDMMC_POWER_PWRCTRL                   \ SDMMC state control bits These bits can only be written when the SDMMC is not in the power-on state (PWRCTRL different 11). These bits are used to define the functional state of the SDMMC signals: stopped, SDMMC_D[7:0], SDMMC_CMD and SDMMC_CK are driven high. Any further write is ignored, PWRCTRL value keeps 11.
$00000004 constant SEC_SDMMC1_SDMMC_POWER_VSWITCH                   \ Voltage switch sequence start This bit is used to start the timing critical section of the voltage switch sequence:
$00000008 constant SEC_SDMMC1_SDMMC_POWER_VSWITCHEN                 \ Voltage switch procedure enable This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0). This bit is used to stop the SDMMC_CK after the voltage switch command response:
$00000010 constant SEC_SDMMC1_SDMMC_POWER_DIRPOL                    \ Data and command direction signals polarity selection This bit can only be written when the SDMMC is in the power-off state (PWRCTRL = 00).


\
\ @brief SDMMC clock control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000003ff constant SEC_SDMMC1_SDMMC_CLKCR_CLKDIV                    \ Clock divide factor This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0). This field defines the divide factor between the input clock (sdmmc_ker_ck) and the output clock (SDMMC_CK): SDMMC_CK frequency = sdmmc_ker_ck / [2 * CLKDIV]. 0x0XX: etc.. 0xXXX: etc..
$00001000 constant SEC_SDMMC1_SDMMC_CLKCR_PWRSAV                    \ Power saving configuration bit This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0) For power saving, the SDMMC_CK clock output can be disabled when the bus is idle by setting PWRSAV:
$0000c000 constant SEC_SDMMC1_SDMMC_CLKCR_WIDBUS                    \ Wide bus mode enable bit This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0)
$00010000 constant SEC_SDMMC1_SDMMC_CLKCR_NEGEDGE                   \ SDMMC_CK dephasing selection bit for data and command This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0). When clock division = 1 (CLKDIV = 0), this bit has no effect. Data and Command change on SDMMC_CK falling edge. Command and data changed on the sdmmc_ker_ck falling edge succeeding the rising edge of SDMMC_CK. SDMMC_CK edge occurs on sdmmc_ker_ck rising edge. When clock division 1 (CLKDIV 0) & DDR = 1: Command changed on the sdmmc_ker_ck falling edge succeeding the rising edge of SDMMC_CK. Data changed on the sdmmc_ker_ck falling edge succeeding a SDMMC_CK edge. SDMMC_CK edge occurs on sdmmc_ker_ck rising edge. Command and data changed on the same sdmmc_ker_ck rising edge generating the SDMMC_CK falling edge. When clock division 1 (CLKDIV 0) & DDR = 1: Command changed on the same sdmmc_ker_ck rising edge generating the SDMMC_CK falling edge. Data changed on the SDMMC_CK falling edge succeeding a SDMMC_CK edge. SDMMC_CK edge occurs on sdmmc_ker_ck rising edge.
$00020000 constant SEC_SDMMC1_SDMMC_CLKCR_HWFC_EN                   \ Hardware flow control enable This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0) When Hardware flow control is enabled, the meaning of the TXFIFOE and RXFIFOF flags change, please see SDMMC status register definition in .
$00040000 constant SEC_SDMMC1_SDMMC_CLKCR_DDR                       \ Data rate signaling selection This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0) DDR rate must only be selected with 4-bit or 8-bit wide bus mode. (WIDBUS 00). DDR = 1 has no effect when WIDBUS = 00 (1-bit wide bus). DDR rate must only be selected with clock division 1. (CLKDIV 0)
$00080000 constant SEC_SDMMC1_SDMMC_CLKCR_BUSSPEED                  \ Bus speed for selection of SDMMC operating modes This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0)
$00300000 constant SEC_SDMMC1_SDMMC_CLKCR_SELCLKRX                  \ Receive clock selection These bits can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0)


\
\ @brief SDMMC argument register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_ARGR_CMDARG                     \ Command argument These bits can only be written by firmware when CPSM is disabled (CPSMEN = 0). Command argument sent to a card as part of a command message. If a command contains an argument, it must be loaded into this register before writing a command to the command register.


\
\ @brief SDMMC command register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000003f constant SEC_SDMMC1_SDMMC_CMDR_CMDINDEX                   \ Command index This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0). The command index is sent to the card as part of a command message.
$00000040 constant SEC_SDMMC1_SDMMC_CMDR_CMDTRANS                   \ The CPSM treats the command as a data transfer command, stops the interrupt period, and signals DataEnable to the DPSM This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0). If this bit is set, the CPSM issues an end of interrupt period and issues DataEnable signal to the DPSM when the command is sent.
$00000080 constant SEC_SDMMC1_SDMMC_CMDR_CMDSTOP                    \ The CPSM treats the command as a Stop Transmission command and signals abort to the DPSM This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0). If this bit is set, the CPSM issues the abort signal to the DPSM when the command is sent.
$00000300 constant SEC_SDMMC1_SDMMC_CMDR_WAITRESP                   \ Wait for response bits This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0). They are used to configure whether the CPSM is to wait for a response, and if yes, which kind of response.
$00000400 constant SEC_SDMMC1_SDMMC_CMDR_WAITINT                    \ CPSM waits for interrupt request If this bit is set, the CPSM disables command timeout and waits for an card interrupt request (Response). If this bit is cleared in the CPSM Wait state, it causes the abort of the interrupt mode.
$00000800 constant SEC_SDMMC1_SDMMC_CMDR_WAITPEND                   \ CPSM waits for end of data transfer (CmdPend internal signal) from DPSM This bit when set, the CPSM waits for the end of data transfer trigger before it starts sending a command. WAITPEND is only taken into account when DTMODE = eMMC stream data transfer, WIDBUS = 1-bit wide bus mode, DPSMACT = 1 and DTDIR = from host to card.
$00001000 constant SEC_SDMMC1_SDMMC_CMDR_CPSMEN                     \ Command path state machine (CPSM) enable bit This bit is written 1 by firmware, and cleared by hardware when the CPSM enters the Idle state. If this bit is set, the CPSM is enabled. When DTEN = 1, no command is transfered nor boot procedure is started. CPSMEN is cleared to 0. During Read Wait with SDMMC_CK stopped no command is sent and CPSMEN is kept 0.
$00002000 constant SEC_SDMMC1_SDMMC_CMDR_DTHOLD                     \ Hold new data block transmission and reception in the DPSM If this bit is set, the DPSM does not move from the Wait_S state to the Send state or from the Wait_R state to the Receive state.
$00004000 constant SEC_SDMMC1_SDMMC_CMDR_BOOTMODE                   \ Select the boot mode procedure to be used This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0)
$00008000 constant SEC_SDMMC1_SDMMC_CMDR_BOOTEN                     \ Enable boot mode procedure
$00010000 constant SEC_SDMMC1_SDMMC_CMDR_CMDSUSPEND                 \ The CPSM treats the command as a Suspend or Resume command and signals interrupt period start/end This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0). CMDSUSPEND = 1 and CMDTRANS = 0 Suspend command, start interrupt period when response bit BS=0. CMDSUSPEND = 1 and CMDTRANS = 1 Resume command with data, end interrupt period when response bit DF=1.


\
\ @brief SDMMC command response register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000003f constant SEC_SDMMC1_SDMMC_RESPCMDR_RESPCMD                \ Response command index Read-only bit field. Contains the command index of the last command response received.


\
\ @brief SDMMC response 1 register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_RESP1R_CARDSTATUSX              \ Card status x See .


\
\ @brief SDMMC response 2 register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_RESP2R_CARDSTATUSX              \ Card status x See .


\
\ @brief SDMMC response 3 register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_RESP3R_CARDSTATUSX              \ Card status x See .


\
\ @brief SDMMC response 4 register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_RESP4R_CARDSTATUSX              \ Card status x See .


\
\ @brief SDMMC data timer register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_DTIMER_DATATIME                 \ Data and R1b busy timeout period This bit can only be written when the CPSM and DPSM are not active (CPSMACT = 0 and DPSMACT = 0). Data and R1b busy timeout period expressed in card bus clock periods.


\
\ @brief SDMMC data length register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$01ffffff constant SEC_SDMMC1_SDMMC_DLENR_DATALENGTH                \ Data length value This register can only be written by firmware when DPSM is inactive (DPSMACT = 0). Number of data bytes to be transferred. When DDR = 1 DATALENGTH is truncated to a multiple of 2. (The last odd byte is not transfered) When DATALENGTH = 0 no data are transfered, when requested by a CPSMEN and CMDTRANS = 1 also no command is transfered. DTEN and CPSMEN are cleared to 0.


\
\ @brief SDMMC data control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant SEC_SDMMC1_SDMMC_DCTRL_DTEN                      \ Data transfer enable bit This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0). This bit is cleared by Hardware when data transfer completes. This bit must only be used to transfer data when no associated data transfer command is used, i.e. must not be used with SD or eMMC cards.
$00000002 constant SEC_SDMMC1_SDMMC_DCTRL_DTDIR                     \ Data transfer direction selection This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
$0000000c constant SEC_SDMMC1_SDMMC_DCTRL_DTMODE                    \ Data transfer mode selection This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
$000000f0 constant SEC_SDMMC1_SDMMC_DCTRL_DBLOCKSIZE                \ Data block size This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0). Define the data block length when the block data transfer mode is selected: When DATALENGTH is not a multiple of DBLOCKSIZE, the transfered data is truncated at a multiple of DBLOCKSIZE. (None of the remaining data are transfered.) When DDR = 1, DBLOCKSIZE = 0000 must not be used. (No data are transfered)
$00000100 constant SEC_SDMMC1_SDMMC_DCTRL_RWSTART                   \ Read Wait start If this bit is set, Read Wait operation starts.
$00000200 constant SEC_SDMMC1_SDMMC_DCTRL_RWSTOP                    \ Read Wait stop This bit is written by firmware and auto cleared by hardware when the DPSM moves from the R_W state to the Wait_R or Idle state.
$00000400 constant SEC_SDMMC1_SDMMC_DCTRL_RWMOD                     \ Read Wait mode This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
$00000800 constant SEC_SDMMC1_SDMMC_DCTRL_SDIOEN                    \ SD I/O interrupt enable functions This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0). If this bit is set, the DPSM enables the SD I/O card specific interrupt operation.
$00001000 constant SEC_SDMMC1_SDMMC_DCTRL_BOOTACKEN                 \ Enable the reception of the boot acknowledgment This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
$00002000 constant SEC_SDMMC1_SDMMC_DCTRL_FIFORST                   \ FIFO reset, flushes any remaining data This bit can only be written by firmware when IDMAEN= 0 and DPSM is active (DPSMACT = 1). This bit only takes effect when a transfer error or transfer hold occurs.


\
\ @brief SDMMC data counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$01ffffff constant SEC_SDMMC1_SDMMC_DCNTR_DATACOUNT                 \ Data count value When read, the number of remaining data bytes to be transferred is returned. Write has no effect.


\
\ @brief SDMMC status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant SEC_SDMMC1_SDMMC_STAR_CCRCFAIL                   \ Command response received (CRC check failed) Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
$00000002 constant SEC_SDMMC1_SDMMC_STAR_DCRCFAIL                   \ Data block sent/received (CRC check failed) Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
$00000004 constant SEC_SDMMC1_SDMMC_STAR_CTIMEOUT                   \ Command response timeout Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR. The Command Timeout period has a fixed value of 64 SDMMC_CK clock periods.
$00000008 constant SEC_SDMMC1_SDMMC_STAR_DTIMEOUT                   \ Data timeout Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
$00000010 constant SEC_SDMMC1_SDMMC_STAR_TXUNDERR                   \ Transmit FIFO underrun error (masked by hardware when IDMA is enabled) Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
$00000020 constant SEC_SDMMC1_SDMMC_STAR_RXOVERR                    \ Received FIFO overrun error (masked by hardware when IDMA is enabled) Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
$00000040 constant SEC_SDMMC1_SDMMC_STAR_CMDREND                    \ Command response received (CRC check passed, or no CRC) Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
$00000080 constant SEC_SDMMC1_SDMMC_STAR_CMDSENT                    \ Command sent (no response required) Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
$00000100 constant SEC_SDMMC1_SDMMC_STAR_DATAEND                    \ Data transfer ended correctly DATAEND is set if data counter DATACOUNT is zero and no errors occur, and no transmit data transfer hold. Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
$00000200 constant SEC_SDMMC1_SDMMC_STAR_DHOLD                      \ Data transfer Hold Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
$00000400 constant SEC_SDMMC1_SDMMC_STAR_DBCKEND                    \ Data block sent/received DBCKEND is set when: - CRC check passed and DPSM moves to the R_W state or - IDMAEN = 0 and transmit data transfer hold and DATACOUNT 0 and DPSM moves to Wait_S. Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
$00000800 constant SEC_SDMMC1_SDMMC_STAR_DABORT                     \ Data transfer aborted by CMD12 Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
$00001000 constant SEC_SDMMC1_SDMMC_STAR_DPSMACT                    \ Data path state machine active, i.e. not in Idle state This is a hardware status flag only, does not generate an interrupt.
$00002000 constant SEC_SDMMC1_SDMMC_STAR_CPSMACT                    \ Command path state machine active, i.e. not in Idle state This is a hardware status flag only, does not generate an interrupt.
$00004000 constant SEC_SDMMC1_SDMMC_STAR_TXFIFOHE                   \ Transmit FIFO half empty At least half the number of words can be written into the FIFO. This bit is cleared when the FIFO becomes half+1 full.
$00008000 constant SEC_SDMMC1_SDMMC_STAR_RXFIFOHF                   \ Receive FIFO half full There are at least half the number of words in the FIFO. This bit is cleared when the FIFO becomes half+1 empty.
$00010000 constant SEC_SDMMC1_SDMMC_STAR_TXFIFOF                    \ Transmit FIFO full This is a hardware status flag only, does not generate an interrupt. This bit is cleared when one FIFO location becomes empty.
$00020000 constant SEC_SDMMC1_SDMMC_STAR_RXFIFOF                    \ Receive FIFO full This bit is cleared when one FIFO location becomes empty.
$00040000 constant SEC_SDMMC1_SDMMC_STAR_TXFIFOE                    \ Transmit FIFO empty This bit is cleared when one FIFO location becomes full.
$00080000 constant SEC_SDMMC1_SDMMC_STAR_RXFIFOE                    \ Receive FIFO empty This is a hardware status flag only, does not generate an interrupt. This bit is cleared when one FIFO location becomes full.
$00100000 constant SEC_SDMMC1_SDMMC_STAR_BUSYD0                     \ Inverted value of SDMMC_D0 line (Busy), sampled at the end of a CMD response and a second time 2 SDMMC_CK cycles after the CMD response This bit is reset to not busy when the SDMMCD0 line changes from busy to not busy. This bit does not signal busy due to data transfer. This is a hardware status flag only, it does not generate an interrupt.
$00200000 constant SEC_SDMMC1_SDMMC_STAR_BUSYD0END                  \ end of SDMMC_D0 Busy following a CMD response detected This indicates only end of busy following a CMD response. This bit does not signal busy due to data transfer. Interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
$00400000 constant SEC_SDMMC1_SDMMC_STAR_SDIOIT                     \ SDIO interrupt received The interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
$00800000 constant SEC_SDMMC1_SDMMC_STAR_ACKFAIL                    \ Boot acknowledgment received (boot acknowledgment check fail) The interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
$01000000 constant SEC_SDMMC1_SDMMC_STAR_ACKTIMEOUT                 \ Boot acknowledgment timeout The interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
$02000000 constant SEC_SDMMC1_SDMMC_STAR_VSWEND                     \ Voltage switch critical timing section completion The interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
$04000000 constant SEC_SDMMC1_SDMMC_STAR_CKSTOP                     \ SDMMC_CK stopped in Voltage switch procedure The interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
$08000000 constant SEC_SDMMC1_SDMMC_STAR_IDMATE                     \ IDMA transfer error The interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.
$10000000 constant SEC_SDMMC1_SDMMC_STAR_IDMABTC                    \ IDMA buffer transfer complete The interrupt flag is cleared by writing corresponding interrupt clear bit in SDMMC_ICR.


\
\ @brief SDMMC interrupt clear register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant SEC_SDMMC1_SDMMC_ICR_CCRCFAILC                   \ CCRCFAIL flag clear bit Set by software to clear the CCRCFAIL flag.
$00000002 constant SEC_SDMMC1_SDMMC_ICR_DCRCFAILC                   \ DCRCFAIL flag clear bit Set by software to clear the DCRCFAIL flag.
$00000004 constant SEC_SDMMC1_SDMMC_ICR_CTIMEOUTC                   \ CTIMEOUT flag clear bit Set by software to clear the CTIMEOUT flag.
$00000008 constant SEC_SDMMC1_SDMMC_ICR_DTIMEOUTC                   \ DTIMEOUT flag clear bit Set by software to clear the DTIMEOUT flag.
$00000010 constant SEC_SDMMC1_SDMMC_ICR_TXUNDERRC                   \ TXUNDERR flag clear bit Set by software to clear TXUNDERR flag.
$00000020 constant SEC_SDMMC1_SDMMC_ICR_RXOVERRC                    \ RXOVERR flag clear bit Set by software to clear the RXOVERR flag.
$00000040 constant SEC_SDMMC1_SDMMC_ICR_CMDRENDC                    \ CMDREND flag clear bit Set by software to clear the CMDREND flag.
$00000080 constant SEC_SDMMC1_SDMMC_ICR_CMDSENTC                    \ CMDSENT flag clear bit Set by software to clear the CMDSENT flag.
$00000100 constant SEC_SDMMC1_SDMMC_ICR_DATAENDC                    \ DATAEND flag clear bit Set by software to clear the DATAEND flag.
$00000200 constant SEC_SDMMC1_SDMMC_ICR_DHOLDC                      \ DHOLD flag clear bit Set by software to clear the DHOLD flag.
$00000400 constant SEC_SDMMC1_SDMMC_ICR_DBCKENDC                    \ DBCKEND flag clear bit Set by software to clear the DBCKEND flag.
$00000800 constant SEC_SDMMC1_SDMMC_ICR_DABORTC                     \ DABORT flag clear bit Set by software to clear the DABORT flag.
$00200000 constant SEC_SDMMC1_SDMMC_ICR_BUSYD0ENDC                  \ BUSYD0END flag clear bit Set by software to clear the BUSYD0END flag.
$00400000 constant SEC_SDMMC1_SDMMC_ICR_SDIOITC                     \ SDIOIT flag clear bit Set by software to clear the SDIOIT flag.
$00800000 constant SEC_SDMMC1_SDMMC_ICR_ACKFAILC                    \ ACKFAIL flag clear bit Set by software to clear the ACKFAIL flag.
$01000000 constant SEC_SDMMC1_SDMMC_ICR_ACKTIMEOUTC                 \ ACKTIMEOUT flag clear bit Set by software to clear the ACKTIMEOUT flag.
$02000000 constant SEC_SDMMC1_SDMMC_ICR_VSWENDC                     \ VSWEND flag clear bit Set by software to clear the VSWEND flag.
$04000000 constant SEC_SDMMC1_SDMMC_ICR_CKSTOPC                     \ CKSTOP flag clear bit Set by software to clear the CKSTOP flag.
$08000000 constant SEC_SDMMC1_SDMMC_ICR_IDMATEC                     \ IDMA transfer error clear bit Set by software to clear the IDMATE flag.
$10000000 constant SEC_SDMMC1_SDMMC_ICR_IDMABTCC                    \ IDMA buffer transfer complete clear bit Set by software to clear the IDMABTC flag.


\
\ @brief SDMMC mask register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant SEC_SDMMC1_SDMMC_MASKR_CCRCFAILIE                \ Command CRC fail interrupt enable Set and cleared by software to enable/disable interrupt caused by command CRC failure.
$00000002 constant SEC_SDMMC1_SDMMC_MASKR_DCRCFAILIE                \ Data CRC fail interrupt enable Set and cleared by software to enable/disable interrupt caused by data CRC failure.
$00000004 constant SEC_SDMMC1_SDMMC_MASKR_CTIMEOUTIE                \ Command timeout interrupt enable Set and cleared by software to enable/disable interrupt caused by command timeout.
$00000008 constant SEC_SDMMC1_SDMMC_MASKR_DTIMEOUTIE                \ Data timeout interrupt enable Set and cleared by software to enable/disable interrupt caused by data timeout.
$00000010 constant SEC_SDMMC1_SDMMC_MASKR_TXUNDERRIE                \ Tx FIFO underrun error interrupt enable Set and cleared by software to enable/disable interrupt caused by Tx FIFO underrun error.
$00000020 constant SEC_SDMMC1_SDMMC_MASKR_RXOVERRIE                 \ Rx FIFO overrun error interrupt enable Set and cleared by software to enable/disable interrupt caused by Rx FIFO overrun error.
$00000040 constant SEC_SDMMC1_SDMMC_MASKR_CMDRENDIE                 \ Command response received interrupt enable Set and cleared by software to enable/disable interrupt caused by receiving command response.
$00000080 constant SEC_SDMMC1_SDMMC_MASKR_CMDSENTIE                 \ Command sent interrupt enable Set and cleared by software to enable/disable interrupt caused by sending command.
$00000100 constant SEC_SDMMC1_SDMMC_MASKR_DATAENDIE                 \ Data end interrupt enable Set and cleared by software to enable/disable interrupt caused by data end.
$00000200 constant SEC_SDMMC1_SDMMC_MASKR_DHOLDIE                   \ Data hold interrupt enable Set and cleared by software to enable/disable the interrupt generated when sending new data is hold in the DPSM Wait_S state.
$00000400 constant SEC_SDMMC1_SDMMC_MASKR_DBCKENDIE                 \ Data block end interrupt enable Set and cleared by software to enable/disable interrupt caused by data block end.
$00000800 constant SEC_SDMMC1_SDMMC_MASKR_DABORTIE                  \ Data transfer aborted interrupt enable Set and cleared by software to enable/disable interrupt caused by a data transfer being aborted.
$00004000 constant SEC_SDMMC1_SDMMC_MASKR_TXFIFOHEIE                \ Tx FIFO half empty interrupt enable Set and cleared by software to enable/disable interrupt caused by Tx FIFO half empty.
$00008000 constant SEC_SDMMC1_SDMMC_MASKR_RXFIFOHFIE                \ Rx FIFO half full interrupt enable Set and cleared by software to enable/disable interrupt caused by Rx FIFO half full.
$00020000 constant SEC_SDMMC1_SDMMC_MASKR_RXFIFOFIE                 \ Rx FIFO full interrupt enable Set and cleared by software to enable/disable interrupt caused by Rx FIFO full.
$00040000 constant SEC_SDMMC1_SDMMC_MASKR_TXFIFOEIE                 \ Tx FIFO empty interrupt enable Set and cleared by software to enable/disable interrupt caused by Tx FIFO empty.
$00200000 constant SEC_SDMMC1_SDMMC_MASKR_BUSYD0ENDIE               \ BUSYD0END interrupt enable Set and cleared by software to enable/disable the interrupt generated when SDMMC_D0 signal changes from busy to NOT busy following a CMD response.
$00400000 constant SEC_SDMMC1_SDMMC_MASKR_SDIOITIE                  \ SDIO mode interrupt received interrupt enable Set and cleared by software to enable/disable the interrupt generated when receiving the SDIO mode interrupt.
$00800000 constant SEC_SDMMC1_SDMMC_MASKR_ACKFAILIE                 \ Acknowledgment Fail interrupt enable Set and cleared by software to enable/disable interrupt caused by acknowledgment Fail.
$01000000 constant SEC_SDMMC1_SDMMC_MASKR_ACKTIMEOUTIE              \ Acknowledgment timeout interrupt enable Set and cleared by software to enable/disable interrupt caused by acknowledgment timeout.
$02000000 constant SEC_SDMMC1_SDMMC_MASKR_VSWENDIE                  \ Voltage switch critical timing section completion interrupt enable Set and cleared by software to enable/disable the interrupt generated when voltage switch critical timing section completion.
$04000000 constant SEC_SDMMC1_SDMMC_MASKR_CKSTOPIE                  \ Voltage Switch clock stopped interrupt enable Set and cleared by software to enable/disable interrupt caused by Voltage Switch clock stopped.
$10000000 constant SEC_SDMMC1_SDMMC_MASKR_IDMABTCIE                 \ IDMA buffer transfer complete interrupt enable Set and cleared by software to enable/disable the interrupt generated when the IDMA has transferred all data belonging to a memory buffer.


\
\ @brief SDMMC acknowledgment timer register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$01ffffff constant SEC_SDMMC1_SDMMC_ACKTIMER_ACKTIME                \ Boot acknowledgment timeout period This bit can only be written by firmware when CPSM is disabled (CPSMEN = 0). Boot acknowledgment timeout period expressed in card bus clock periods.


\
\ @brief SDMMC DMA control register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant SEC_SDMMC1_SDMMC_IDMACTRLR_IDMAEN                \ IDMA enable This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
$00000002 constant SEC_SDMMC1_SDMMC_IDMACTRLR_IDMABMODE             \ Buffer mode selection This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).


\
\ @brief SDMMC IDMA buffer size register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$0001ffe0 constant SEC_SDMMC1_SDMMC_IDMABSIZER_IDMABNDT             \ Number of bytes per buffer This 12-bit value must be multiplied by 8 to get the size of the buffer in 32-bit words and by 32 to get the size of the buffer in bytes. Example: IDMABNDT = 0x001: buffer size = 8 words = 32 bytes. Example: IDMABNDT = 0x800: buffer size = 16384 words = 64 Kbyte. These bits can only be written by firmware when DPSM is inactive (DPSMACT = 0).


\
\ @brief SDMMC IDMA buffer base address register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_IDMABASER_IDMABASE              \ Buffer memory base address bits [31:2], must be word aligned (bit [1:0] are always 0 and read only) This register can be written by firmware when DPSM is inactive (DPSMACT = 0), and can dynamically be written by firmware when DPSM active (DPSMACT = 1).


\
\ @brief SDMMC_IDMALAR
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$0000fffc constant SEC_SDMMC1_SDMMC_IDMALAR_IDMALA                  \ Word aligned linked list item address offset Linked list item offset pointer to the base of the next linked list item structure. Linked list item base address is IDMABA + IDMALA. These bits can only be written by firmware when DPSM is inactive (DPSMACT = 0).
$20000000 constant SEC_SDMMC1_SDMMC_IDMALAR_ABR                     \ Acknowledge linked list buffer ready This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0). This bit is not taken into account when starting the first linked list buffer from the software programmed register information. ABR is only taken into account on subsequent loaded linked list items.
$40000000 constant SEC_SDMMC1_SDMMC_IDMALAR_ULS                     \ Update SDMMC_IDMABSIZE from the next linked list when in linked list mode (SDMMC_IDMACTRLR.IDMABMODE select linked list mode and ULA = 1) This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
$80000000 constant SEC_SDMMC1_SDMMC_IDMALAR_ULA                     \ Update SDMMC_IDMALAR from linked list when in linked list mode (SDMMC_IDMACTRLR.IDMABMODE select linked list mode) This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).


\
\ @brief SDMMC_IDMABAR
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$fffffffc constant SEC_SDMMC1_SDMMC_IDMABAR_IDMABA                  \ Word aligned Linked list memory base address Linked list memory base pointer. These bits can only be written by firmware when DPSM is inactive (DPSMACT = 0).


\
\ @brief SDMMC data FIFO registers 0
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_FIFOR0_FIFODATA                 \ Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.


\
\ @brief SDMMC data FIFO registers 1
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_FIFOR1_FIFODATA                 \ Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.


\
\ @brief SDMMC data FIFO registers 2
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_FIFOR2_FIFODATA                 \ Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.


\
\ @brief SDMMC data FIFO registers 3
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_FIFOR3_FIFODATA                 \ Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.


\
\ @brief SDMMC data FIFO registers 4
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_FIFOR4_FIFODATA                 \ Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.


\
\ @brief SDMMC data FIFO registers 5
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_FIFOR5_FIFODATA                 \ Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.


\
\ @brief SDMMC data FIFO registers 6
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_FIFOR6_FIFODATA                 \ Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.


\
\ @brief SDMMC data FIFO registers 7
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_FIFOR7_FIFODATA                 \ Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.


\
\ @brief SDMMC data FIFO registers 8
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_FIFOR8_FIFODATA                 \ Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.


\
\ @brief SDMMC data FIFO registers 9
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_FIFOR9_FIFODATA                 \ Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.


\
\ @brief SDMMC data FIFO registers 10
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_FIFOR10_FIFODATA                \ Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.


\
\ @brief SDMMC data FIFO registers 11
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_FIFOR11_FIFODATA                \ Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.


\
\ @brief SDMMC data FIFO registers 12
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_FIFOR12_FIFODATA                \ Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.


\
\ @brief SDMMC data FIFO registers 13
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_FIFOR13_FIFODATA                \ Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.


\
\ @brief SDMMC data FIFO registers 14
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_FIFOR14_FIFODATA                \ Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.


\
\ @brief SDMMC data FIFO registers 15
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC1_SDMMC_FIFOR15_FIFODATA                \ Receive and transmit FIFO data This register can only be read or written by firmware when the DPSM is active (DPSMACT = 1). The FIFO data occupies 16 entries of 32-bit words.


\
\ @brief Secure digital input/output MultiMediaCard interface
\
$56008000 constant SEC_SDMMC1_SDMMC_POWER  \ offset: 0x00 : SDMMC_POWER
$56008004 constant SEC_SDMMC1_SDMMC_CLKCR  \ offset: 0x04 : SDMMC clock control register
$56008008 constant SEC_SDMMC1_SDMMC_ARGR  \ offset: 0x08 : SDMMC argument register
$5600800c constant SEC_SDMMC1_SDMMC_CMDR  \ offset: 0x0C : SDMMC command register
$56008010 constant SEC_SDMMC1_SDMMC_RESPCMDR  \ offset: 0x10 : SDMMC command response register
$56008014 constant SEC_SDMMC1_SDMMC_RESP1R  \ offset: 0x14 : SDMMC response 1 register
$56008018 constant SEC_SDMMC1_SDMMC_RESP2R  \ offset: 0x18 : SDMMC response 2 register
$5600801c constant SEC_SDMMC1_SDMMC_RESP3R  \ offset: 0x1C : SDMMC response 3 register
$56008020 constant SEC_SDMMC1_SDMMC_RESP4R  \ offset: 0x20 : SDMMC response 4 register
$56008024 constant SEC_SDMMC1_SDMMC_DTIMER  \ offset: 0x24 : SDMMC data timer register
$56008028 constant SEC_SDMMC1_SDMMC_DLENR  \ offset: 0x28 : SDMMC data length register
$5600802c constant SEC_SDMMC1_SDMMC_DCTRL  \ offset: 0x2C : SDMMC data control register
$56008030 constant SEC_SDMMC1_SDMMC_DCNTR  \ offset: 0x30 : SDMMC data counter register
$56008034 constant SEC_SDMMC1_SDMMC_STAR  \ offset: 0x34 : SDMMC status register
$56008038 constant SEC_SDMMC1_SDMMC_ICR  \ offset: 0x38 : SDMMC interrupt clear register
$5600803c constant SEC_SDMMC1_SDMMC_MASKR  \ offset: 0x3C : SDMMC mask register
$56008040 constant SEC_SDMMC1_SDMMC_ACKTIMER  \ offset: 0x40 : SDMMC acknowledgment timer register
$56008050 constant SEC_SDMMC1_SDMMC_IDMACTRLR  \ offset: 0x50 : SDMMC DMA control register
$56008054 constant SEC_SDMMC1_SDMMC_IDMABSIZER  \ offset: 0x54 : SDMMC IDMA buffer size register
$56008058 constant SEC_SDMMC1_SDMMC_IDMABASER  \ offset: 0x58 : SDMMC IDMA buffer base address register
$56008064 constant SEC_SDMMC1_SDMMC_IDMALAR  \ offset: 0x64 : SDMMC_IDMALAR
$56008068 constant SEC_SDMMC1_SDMMC_IDMABAR  \ offset: 0x68 : SDMMC_IDMABAR
$56008080 constant SEC_SDMMC1_SDMMC_FIFOR0  \ offset: 0x80 : SDMMC data FIFO registers 0
$56008084 constant SEC_SDMMC1_SDMMC_FIFOR1  \ offset: 0x84 : SDMMC data FIFO registers 1
$56008088 constant SEC_SDMMC1_SDMMC_FIFOR2  \ offset: 0x88 : SDMMC data FIFO registers 2
$5600808c constant SEC_SDMMC1_SDMMC_FIFOR3  \ offset: 0x8C : SDMMC data FIFO registers 3
$56008090 constant SEC_SDMMC1_SDMMC_FIFOR4  \ offset: 0x90 : SDMMC data FIFO registers 4
$56008094 constant SEC_SDMMC1_SDMMC_FIFOR5  \ offset: 0x94 : SDMMC data FIFO registers 5
$56008098 constant SEC_SDMMC1_SDMMC_FIFOR6  \ offset: 0x98 : SDMMC data FIFO registers 6
$5600809c constant SEC_SDMMC1_SDMMC_FIFOR7  \ offset: 0x9C : SDMMC data FIFO registers 7
$560080a0 constant SEC_SDMMC1_SDMMC_FIFOR8  \ offset: 0xA0 : SDMMC data FIFO registers 8
$560080a4 constant SEC_SDMMC1_SDMMC_FIFOR9  \ offset: 0xA4 : SDMMC data FIFO registers 9
$560080a8 constant SEC_SDMMC1_SDMMC_FIFOR10  \ offset: 0xA8 : SDMMC data FIFO registers 10
$560080ac constant SEC_SDMMC1_SDMMC_FIFOR11  \ offset: 0xAC : SDMMC data FIFO registers 11
$560080b0 constant SEC_SDMMC1_SDMMC_FIFOR12  \ offset: 0xB0 : SDMMC data FIFO registers 12
$560080b4 constant SEC_SDMMC1_SDMMC_FIFOR13  \ offset: 0xB4 : SDMMC data FIFO registers 13
$560080b8 constant SEC_SDMMC1_SDMMC_FIFOR14  \ offset: 0xB8 : SDMMC data FIFO registers 14
$560080bc constant SEC_SDMMC1_SDMMC_FIFOR15  \ offset: 0xBC : SDMMC data FIFO registers 15

