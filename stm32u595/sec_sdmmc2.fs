\
\ @file sec_sdmmc2.fs
\ @brief Secure digital input/output MultiMediaCard interface
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

$00000003 constant SEC_SDMMC2_POWER_PWRCTRL                         \ SDMMC state control bits
$00000004 constant SEC_SDMMC2_POWER_VSWITCH                         \ Voltage switch sequence start
$00000008 constant SEC_SDMMC2_POWER_VSWITCHEN                       \ Voltage switch procedure enable
$00000010 constant SEC_SDMMC2_POWER_DIRPOL                          \ Data and command direction signals polarity selection


\
\ @brief clock control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000003ff constant SEC_SDMMC2_CLKCR_CLKDIV                          \ Clock divide factor
$00001000 constant SEC_SDMMC2_CLKCR_PWRSAV                          \ Power saving configuration bit
$0000c000 constant SEC_SDMMC2_CLKCR_WIDBUS                          \ Wide bus mode enable bit
$00010000 constant SEC_SDMMC2_CLKCR_NEGEDGE                         \ SDIO_CK dephasing selection bit
$00020000 constant SEC_SDMMC2_CLKCR_HWFC_EN                         \ HW Flow Control enable
$00040000 constant SEC_SDMMC2_CLKCR_DDR                             \ Data rate signaling selection
$00080000 constant SEC_SDMMC2_CLKCR_BUSSPEED                        \ Bus speed mode selection between DS, HS, SDR12, SDR25 and SDR50,DDR50, SDR104
$00300000 constant SEC_SDMMC2_CLKCR_SELCLKRX                        \ Receive clock selection


\
\ @brief argument register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_ARGR_CMDARG                           \ Command argument


\
\ @brief command register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000003f constant SEC_SDMMC2_CMDR_CMDINDEX                         \ Command index
$00000040 constant SEC_SDMMC2_CMDR_CMDTRANS                         \ The CPSM treats the command as a data transfer command, stops the interrupt period, and signals DataEnable to the DPSM
$00000080 constant SEC_SDMMC2_CMDR_CMDSTOP                          \ The CPSM treats the command as a Stop Transmission command and signals Abort to the DPSM
$00000300 constant SEC_SDMMC2_CMDR_WAITRESP                         \ Wait for response bits
$00000400 constant SEC_SDMMC2_CMDR_WAITINT                          \ CPSM waits for interrupt request
$00000800 constant SEC_SDMMC2_CMDR_WAITPEND                         \ CPSM Waits for ends of data transfer (CmdPend internal signal) from DPSM
$00001000 constant SEC_SDMMC2_CMDR_CPSMEN                           \ Command path state machine (CPSM) Enable bit
$00002000 constant SEC_SDMMC2_CMDR_DTHOLD                           \ Hold new data block transmission and reception in the DPSM
$00004000 constant SEC_SDMMC2_CMDR_BOOTMODE                         \ Select the boot mode procedure to be used
$00008000 constant SEC_SDMMC2_CMDR_BOOTEN                           \ Enable boot mode procedure
$00010000 constant SEC_SDMMC2_CMDR_CMDSUSPEND                       \ The CPSM treats the command as a Suspend or Resume command and signals interrupt period start/end


\
\ @brief command response register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000003f constant SEC_SDMMC2_RESPCMDR_RESPCMD                      \ Response command index


\
\ @brief response 1 register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_RESP1_CARDSTATUS1                     \ CARDSTATUS1


\
\ @brief response 2 register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_RESP2_CARDSTATUS2                     \ CARDSTATUS2


\
\ @brief response 3 register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_RESP3_CARDSTATUS3                     \ CARDSTATUS3


\
\ @brief response 4 register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_RESP4_CARDSTATUS4                     \ CARDSTATUS4


\
\ @brief data timer register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_DTIMER_DATATIME                       \ Data and R1b busy timeout period


\
\ @brief data length register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$01ffffff constant SEC_SDMMC2_DLENR_DATALENGTH                      \ Data length value


\
\ @brief data control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant SEC_SDMMC2_DCTRL_DTEN                            \ DTEN
$00000002 constant SEC_SDMMC2_DCTRL_DTDIR                           \ Data transfer direction selection
$0000000c constant SEC_SDMMC2_DCTRL_DTMODE                          \ Data transfer mode selection
$000000f0 constant SEC_SDMMC2_DCTRL_DBLOCKSIZE                      \ Data block size
$00000100 constant SEC_SDMMC2_DCTRL_RWSTART                         \ Read wait start
$00000200 constant SEC_SDMMC2_DCTRL_RWSTOP                          \ Read wait stop
$00000400 constant SEC_SDMMC2_DCTRL_RWMOD                           \ Read wait mode
$00000800 constant SEC_SDMMC2_DCTRL_SDIOEN                          \ SD I/O enable functions
$00001000 constant SEC_SDMMC2_DCTRL_BOOTACKEN                       \ Enable the reception of the boot acknowledgment
$00002000 constant SEC_SDMMC2_DCTRL_FIFORST                         \ FIFO reset, will flush any remaining data


\
\ @brief data counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$01ffffff constant SEC_SDMMC2_DCNTR_DATACOUNT                       \ Data count value


\
\ @brief status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant SEC_SDMMC2_STAR_CCRCFAIL                         \ Command response received (CRC check failed)
$00000002 constant SEC_SDMMC2_STAR_DCRCFAIL                         \ Data block sent/received (CRC check failed)
$00000004 constant SEC_SDMMC2_STAR_CTIMEOUT                         \ Command response timeout
$00000008 constant SEC_SDMMC2_STAR_DTIMEOUT                         \ Data timeout
$00000010 constant SEC_SDMMC2_STAR_TXUNDERR                         \ Transmit FIFO underrun error (masked by hardware when IDMA is enabled)
$00000020 constant SEC_SDMMC2_STAR_RXOVERR                          \ Received FIFO overrun error (masked by hardware when IDMA is enabled)
$00000040 constant SEC_SDMMC2_STAR_CMDREND                          \ Command response received (CRC check passed, or no CRC)
$00000080 constant SEC_SDMMC2_STAR_CMDSENT                          \ Command sent (no response required)
$00000100 constant SEC_SDMMC2_STAR_DATAEND                          \ Data transfer ended correctly
$00000200 constant SEC_SDMMC2_STAR_DHOLD                            \ Data transfer Hold
$00000400 constant SEC_SDMMC2_STAR_DBCKEND                          \ Data block sent/received
$00000800 constant SEC_SDMMC2_STAR_DABORT                           \ Data transfer aborted by CMD12
$00001000 constant SEC_SDMMC2_STAR_DPSMACT                          \ Data path state machine active, i.e. not in Idle state
$00002000 constant SEC_SDMMC2_STAR_CPSMACT                          \ Command path state machine active, i.e. not in Idle state
$00004000 constant SEC_SDMMC2_STAR_TXFIFOHE                         \ Transmit FIFO half empty
$00008000 constant SEC_SDMMC2_STAR_RXFIFOHF                         \ Receive FIFO half full
$00010000 constant SEC_SDMMC2_STAR_TXFIFOF                          \ Transmit FIFO full
$00020000 constant SEC_SDMMC2_STAR_RXFIFOF                          \ Receive FIFO full
$00040000 constant SEC_SDMMC2_STAR_TXFIFOE                          \ Transmit FIFO empty
$00080000 constant SEC_SDMMC2_STAR_RXFIFOE                          \ Receive FIFO empty
$00100000 constant SEC_SDMMC2_STAR_BUSYD0                           \ Inverted value of SDMMC_D0 line (Busy), sampled at the end of a CMD response and a second time 2 SDMMC_CK cycles after the CMD response
$00200000 constant SEC_SDMMC2_STAR_BUSYD0END                        \ end of SDMMC_D0 Busy following a CMD response detected
$00400000 constant SEC_SDMMC2_STAR_SDIOIT                           \ SDIO interrupt received
$00800000 constant SEC_SDMMC2_STAR_ACKFAIL                          \ Boot acknowledgment received (boot acknowledgment check fail)
$01000000 constant SEC_SDMMC2_STAR_ACKTIMEOUT                       \ Boot acknowledgment timeout
$02000000 constant SEC_SDMMC2_STAR_VSWEND                           \ Voltage switch critical timing section completion
$04000000 constant SEC_SDMMC2_STAR_CKSTOP                           \ SDMMC_CK stopped in Voltage switch procedure
$08000000 constant SEC_SDMMC2_STAR_IDMATE                           \ IDMA transfer error
$10000000 constant SEC_SDMMC2_STAR_IDMABTC                          \ IDMA buffer transfer complete


\
\ @brief interrupt clear register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant SEC_SDMMC2_ICR_CCRCFAILC                         \ CCRCFAIL flag clear bit
$00000002 constant SEC_SDMMC2_ICR_DCRCFAILC                         \ DCRCFAIL flag clear bit
$00000004 constant SEC_SDMMC2_ICR_CTIMEOUTC                         \ CTIMEOUT flag clear bit
$00000008 constant SEC_SDMMC2_ICR_DTIMEOUTC                         \ DTIMEOUT flag clear bit
$00000010 constant SEC_SDMMC2_ICR_TXUNDERRC                         \ TXUNDERR flag clear bit
$00000020 constant SEC_SDMMC2_ICR_RXOVERRC                          \ RXOVERR flag clear bit
$00000040 constant SEC_SDMMC2_ICR_CMDRENDC                          \ CMDREND flag clear bit
$00000080 constant SEC_SDMMC2_ICR_CMDSENTC                          \ CMDSENT flag clear bit
$00000100 constant SEC_SDMMC2_ICR_DATAENDC                          \ DATAEND flag clear bit
$00000200 constant SEC_SDMMC2_ICR_DHOLDC                            \ DHOLD flag clear bit
$00000400 constant SEC_SDMMC2_ICR_DBCKENDC                          \ DBCKEND flag clear bit
$00000800 constant SEC_SDMMC2_ICR_DABORTC                           \ DABORT flag clear bit
$00200000 constant SEC_SDMMC2_ICR_BUSYD0ENDC                        \ BUSYD0END flag clear bit
$00400000 constant SEC_SDMMC2_ICR_SDIOITC                           \ SDIOIT flag clear bit
$00800000 constant SEC_SDMMC2_ICR_ACKFAILC                          \ ACKFAIL flag clear bit
$01000000 constant SEC_SDMMC2_ICR_ACKTIMEOUTC                       \ ACKTIMEOUT flag clear bit
$02000000 constant SEC_SDMMC2_ICR_VSWENDC                           \ VSWEND flag clear bit
$04000000 constant SEC_SDMMC2_ICR_CKSTOPC                           \ CKSTOP flag clear bit
$08000000 constant SEC_SDMMC2_ICR_IDMATEC                           \ IDMA transfer error clear bit
$10000000 constant SEC_SDMMC2_ICR_IDMABTCC                          \ IDMA buffer transfer complete clear bit


\
\ @brief mask register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant SEC_SDMMC2_MASKR_CCRCFAILIE                      \ Command CRC fail interrupt enable
$00000002 constant SEC_SDMMC2_MASKR_DCRCFAILIE                      \ Data CRC fail interrupt enable
$00000004 constant SEC_SDMMC2_MASKR_CTIMEOUTIE                      \ Command timeout interrupt enable
$00000008 constant SEC_SDMMC2_MASKR_DTIMEOUTIE                      \ Data timeout interrupt enable
$00000010 constant SEC_SDMMC2_MASKR_TXUNDERRIE                      \ Tx FIFO underrun error interrupt enable
$00000020 constant SEC_SDMMC2_MASKR_RXOVERRIE                       \ Rx FIFO overrun error interrupt enable
$00000040 constant SEC_SDMMC2_MASKR_CMDRENDIE                       \ Command response received interrupt enable
$00000080 constant SEC_SDMMC2_MASKR_CMDSENTIE                       \ Command sent interrupt enable
$00000100 constant SEC_SDMMC2_MASKR_DATAENDIE                       \ Data end interrupt enable
$00000200 constant SEC_SDMMC2_MASKR_DHOLDIE                         \ Data hold interrupt enable
$00000400 constant SEC_SDMMC2_MASKR_DBCKENDIE                       \ Data block end interrupt enable
$00000800 constant SEC_SDMMC2_MASKR_DABORTIE                        \ Data transfer aborted interrupt enable
$00004000 constant SEC_SDMMC2_MASKR_TXFIFOHEIE                      \ Tx FIFO half empty interrupt enable
$00008000 constant SEC_SDMMC2_MASKR_RXFIFOHFIE                      \ Rx FIFO half full interrupt enable
$00020000 constant SEC_SDMMC2_MASKR_RXFIFOFIE                       \ Rx FIFO full interrupt enable
$00040000 constant SEC_SDMMC2_MASKR_TXFIFOEIE                       \ Tx FIFO empty interrupt enable
$00200000 constant SEC_SDMMC2_MASKR_BUSYD0ENDIE                     \ BUSYD0END interrupt enable
$00400000 constant SEC_SDMMC2_MASKR_SDIOITIE                        \ SDIO mode interrupt received interrupt enable
$00800000 constant SEC_SDMMC2_MASKR_ACKFAILIE                       \ Acknowledgment Fail interrupt enable
$01000000 constant SEC_SDMMC2_MASKR_ACKTIMEOUTIE                    \ Acknowledgment timeout interrupt enable
$02000000 constant SEC_SDMMC2_MASKR_VSWENDIE                        \ Voltage switch critical timing section completion interrupt enable
$04000000 constant SEC_SDMMC2_MASKR_CKSTOPIE                        \ Voltage Switch clock stopped interrupt enable
$10000000 constant SEC_SDMMC2_MASKR_IDMABTCIE                       \ IDMA buffer transfer complete interrupt enable


\
\ @brief acknowledgment timer register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$01ffffff constant SEC_SDMMC2_ACKTIMER_ACKTIME                      \ Boot acknowledgment timeout period


\
\ @brief DMA control register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant SEC_SDMMC2_SDMMC_IDMACTRLR_IDMAEN                \ IDMA enable This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).
$00000002 constant SEC_SDMMC2_SDMMC_IDMACTRLR_IDMABMODE             \ Buffer mode selection. This bit can only be written by firmware when DPSM is inactive (DPSMACT = 0).


\
\ @brief buffer size register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$0001ffe0 constant SEC_SDMMC2_SDMMC_IDMABSIZER_IDMABNDT             \ Number of bytes per buffer


\
\ @brief buffer base address register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_SDMMC_IDMABASER_IDMABASE              \ Buffer memory base address bits [31:2], shall be word aligned (bit [1:0] are always 0 and read only)


\
\ @brief linked list address register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$0000fffc constant SEC_SDMMC2_SDMMC_IDMALAR_IDMALA                  \ Acknowledge linked list buffer ready
$20000000 constant SEC_SDMMC2_SDMMC_IDMALAR_ABR                     \ Acknowledge linked list buffer ready
$40000000 constant SEC_SDMMC2_SDMMC_IDMALAR_ULS                     \ Update SDMMC_IDMABSIZE from the next linked list when in linked list mode (SDMMC_IDMACTRLR.IDMABMODE select linked list mode and ULA = 1)
$80000000 constant SEC_SDMMC2_SDMMC_IDMALAR_ULA                     \ Update SDMMC_IDMALAR from linked list when in linked list mode (SDMMC_IDMACTRLR.IDMABMODE select linked list mode)


\
\ @brief linked list memory base register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$fffffffc constant SEC_SDMMC2_SDMMC_IDMABAR_IDMABA                  \ Word aligned Linked list memory base address


\
\ @brief data FIFO register 0
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_FIFOR0_FIFODATA                       \ Receive and transmit FIFO data


\
\ @brief data FIFO register 1
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_FIFOR1_FIFODATA                       \ Receive and transmit FIFO data


\
\ @brief data FIFO register 2
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_FIFOR2_FIFODATA                       \ Receive and transmit FIFO data


\
\ @brief data FIFO register 3
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_FIFOR3_FIFODATA                       \ Receive and transmit FIFO data


\
\ @brief data FIFO register 4
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_FIFOR4_FIFODATA                       \ Receive and transmit FIFO data


\
\ @brief data FIFO register 5
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_FIFOR5_FIFODATA                       \ Receive and transmit FIFO data


\
\ @brief data FIFO register 6
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_FIFOR6_FIFODATA                       \ Receive and transmit FIFO data


\
\ @brief data FIFO register 7
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_FIFOR7_FIFODATA                       \ Receive and transmit FIFO data


\
\ @brief data FIFO register 8
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_FIFOR8_FIFODATA                       \ Receive and transmit FIFO data


\
\ @brief data FIFO register 9
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_FIFOR9_FIFODATA                       \ Receive and transmit FIFO data


\
\ @brief data FIFO register 10
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_FIFOR10_FIFODATA                      \ Receive and transmit FIFO data


\
\ @brief data FIFO register 11
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_FIFOR11_FIFODATA                      \ Receive and transmit FIFO data


\
\ @brief data FIFO register 12
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_FIFOR12_FIFODATA                      \ Receive and transmit FIFO data


\
\ @brief data FIFO register 13
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_FIFOR13_FIFODATA                      \ Receive and transmit FIFO data


\
\ @brief data FIFO register 14
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_FIFOR14_FIFODATA                      \ Receive and transmit FIFO data


\
\ @brief data FIFO register 15
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000000 constant SEC_SDMMC2_FIFOR15_FIFODATA                      \ Receive and transmit FIFO data


\
\ @brief Secure digital input/output MultiMediaCard interface
\
$520c8c00 constant SEC_SDMMC2_POWER  \ offset: 0x00 : power control register
$520c8c04 constant SEC_SDMMC2_CLKCR  \ offset: 0x04 : clock control register
$520c8c08 constant SEC_SDMMC2_ARGR  \ offset: 0x08 : argument register
$520c8c0c constant SEC_SDMMC2_CMDR  \ offset: 0x0C : command register
$520c8c10 constant SEC_SDMMC2_RESPCMDR  \ offset: 0x10 : command response register
$520c8c14 constant SEC_SDMMC2_RESP1  \ offset: 0x14 : response 1 register
$520c8c18 constant SEC_SDMMC2_RESP2  \ offset: 0x18 : response 2 register
$520c8c1c constant SEC_SDMMC2_RESP3  \ offset: 0x1C : response 3 register
$520c8c20 constant SEC_SDMMC2_RESP4  \ offset: 0x20 : response 4 register
$520c8c24 constant SEC_SDMMC2_DTIMER  \ offset: 0x24 : data timer register
$520c8c28 constant SEC_SDMMC2_DLENR  \ offset: 0x28 : data length register
$520c8c2c constant SEC_SDMMC2_DCTRL  \ offset: 0x2C : data control register
$520c8c30 constant SEC_SDMMC2_DCNTR  \ offset: 0x30 : data counter register
$520c8c34 constant SEC_SDMMC2_STAR  \ offset: 0x34 : status register
$520c8c38 constant SEC_SDMMC2_ICR  \ offset: 0x38 : interrupt clear register
$520c8c3c constant SEC_SDMMC2_MASKR  \ offset: 0x3C : mask register
$520c8c40 constant SEC_SDMMC2_ACKTIMER  \ offset: 0x40 : acknowledgment timer register
$520c8c50 constant SEC_SDMMC2_SDMMC_IDMACTRLR  \ offset: 0x50 : DMA control register
$520c8c54 constant SEC_SDMMC2_SDMMC_IDMABSIZER  \ offset: 0x54 : buffer size register
$520c8c58 constant SEC_SDMMC2_SDMMC_IDMABASER  \ offset: 0x58 : buffer base address register
$520c8c64 constant SEC_SDMMC2_SDMMC_IDMALAR  \ offset: 0x64 : linked list address register
$520c8c68 constant SEC_SDMMC2_SDMMC_IDMABAR  \ offset: 0x68 : linked list memory base register
$520c8c80 constant SEC_SDMMC2_FIFOR0  \ offset: 0x80 : data FIFO register 0
$520c8c84 constant SEC_SDMMC2_FIFOR1  \ offset: 0x84 : data FIFO register 1
$520c8c88 constant SEC_SDMMC2_FIFOR2  \ offset: 0x88 : data FIFO register 2
$520c8c8c constant SEC_SDMMC2_FIFOR3  \ offset: 0x8C : data FIFO register 3
$520c8c90 constant SEC_SDMMC2_FIFOR4  \ offset: 0x90 : data FIFO register 4
$520c8c94 constant SEC_SDMMC2_FIFOR5  \ offset: 0x94 : data FIFO register 5
$520c8c98 constant SEC_SDMMC2_FIFOR6  \ offset: 0x98 : data FIFO register 6
$520c8c9c constant SEC_SDMMC2_FIFOR7  \ offset: 0x9C : data FIFO register 7
$520c8ca0 constant SEC_SDMMC2_FIFOR8  \ offset: 0xA0 : data FIFO register 8
$520c8ca4 constant SEC_SDMMC2_FIFOR9  \ offset: 0xA4 : data FIFO register 9
$520c8ca8 constant SEC_SDMMC2_FIFOR10  \ offset: 0xA8 : data FIFO register 10
$520c8cac constant SEC_SDMMC2_FIFOR11  \ offset: 0xAC : data FIFO register 11
$520c8cb0 constant SEC_SDMMC2_FIFOR12  \ offset: 0xB0 : data FIFO register 12
$520c8cb4 constant SEC_SDMMC2_FIFOR13  \ offset: 0xB4 : data FIFO register 13
$520c8cb8 constant SEC_SDMMC2_FIFOR14  \ offset: 0xB8 : data FIFO register 14
$520c8cbc constant SEC_SDMMC2_FIFOR15  \ offset: 0xBC : data FIFO register 15

