\
\ @file sdmmc3.fs
\ @brief SDMMC3 global interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SDMMC power control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant SDMMC3_SDMMC_POWER_PWRCTRL                       \ PWRCTRL
$00000004 constant SDMMC3_SDMMC_POWER_VSWITCH                       \ VSWITCH
$00000008 constant SDMMC3_SDMMC_POWER_VSWITCHEN                     \ VSWITCHEN
$00000010 constant SDMMC3_SDMMC_POWER_DIRPOL                        \ DIRPOL


\
\ @brief The SDMMC_CLKCR register controls the SDMMC_CK output clock, the sdmmc_rx_ck receive clock, and the bus width.
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000003ff constant SDMMC3_SDMMC_CLKCR_CLKDIV                        \ CLKDIV
$00001000 constant SDMMC3_SDMMC_CLKCR_PWRSAV                        \ PWRSAV
$0000c000 constant SDMMC3_SDMMC_CLKCR_WIDBUS                        \ WIDBUS
$00010000 constant SDMMC3_SDMMC_CLKCR_NEGEDGE                       \ NEGEDGE
$00020000 constant SDMMC3_SDMMC_CLKCR_HWFC_EN                       \ HWFC_EN
$00040000 constant SDMMC3_SDMMC_CLKCR_DDR                           \ DDR
$00080000 constant SDMMC3_SDMMC_CLKCR_BUSSPEED                      \ BUSSPEED
$00300000 constant SDMMC3_SDMMC_CLKCR_SELCLKRX                      \ SELCLKRX


\
\ @brief The SDMMC_ARGR register contains a 32-bit command argument, which is sent to a card as part of a command message.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_ARGR_CMDARG                         \ CMDARG


\
\ @brief The SDMMC_CMDR register contains the command index and command type bits. The command index is sent to a card as part of a command message. The command type bits control the command path state machine (CPSM).
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000003f constant SDMMC3_SDMMC_CMDR_CMDINDEX                       \ CMDINDEX
$00000040 constant SDMMC3_SDMMC_CMDR_CMDTRANS                       \ CMDTRANS
$00000080 constant SDMMC3_SDMMC_CMDR_CMDSTOP                        \ CMDSTOP
$00000300 constant SDMMC3_SDMMC_CMDR_WAITRESP                       \ WAITRESP
$00000400 constant SDMMC3_SDMMC_CMDR_WAITINT                        \ WAITINT
$00000800 constant SDMMC3_SDMMC_CMDR_WAITPEND                       \ WAITPEND
$00001000 constant SDMMC3_SDMMC_CMDR_CPSMEN                         \ CPSMEN
$00002000 constant SDMMC3_SDMMC_CMDR_DTHOLD                         \ DTHOLD
$00004000 constant SDMMC3_SDMMC_CMDR_BOOTMODE                       \ BOOTMODE
$00008000 constant SDMMC3_SDMMC_CMDR_BOOTEN                         \ BOOTEN
$00010000 constant SDMMC3_SDMMC_CMDR_CMDSUSPEND                     \ CMDSUSPEND


\
\ @brief The SDMMC_RESPCMDR register contains the command index field of the last command response received. If the command response transmission does not contain the command index field (long or OCR response), the RESPCMD field is unknown, although it must contain 111111b (the value of the reserved field from the response).
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000003f constant SDMMC3_SDMMC_RESPCMDR_RESPCMD                    \ RESPCMD


\
\ @brief The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_RESP1R_CARDSTATUS1                  \ CARDSTATUS1


\
\ @brief The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_RESP2R_CARDSTATUS2                  \ CARDSTATUS2


\
\ @brief The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_RESP3R_CARDSTATUS3                  \ CARDSTATUS3


\
\ @brief The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_RESP4R_CARDSTATUS4                  \ CARDSTATUS4


\
\ @brief The SDMMC_DTIMER register contains the data timeout period, in card bus clock periods. A counter loads the value from the SDMMC_DTIMER register, and starts decrementing when the data path state machine (DPSM) enters the Wait_R or Busy state. If the timer reaches 0 while the DPSM is in either of these states, the timeout status flag is set.
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_DTIMER_DATATIME                     \ DATATIME


\
\ @brief The SDMMC_DLENR register contains the number of data bytes to be transferred. The value is loaded into the data counter when data transfer starts.
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$01ffffff constant SDMMC3_SDMMC_DLENR_DATALENGTH                    \ DATALENGTH


\
\ @brief The SDMMC_DCTRL register control the data path state machine (DPSM).
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant SDMMC3_SDMMC_DCTRL_DTEN                          \ DTEN
$00000002 constant SDMMC3_SDMMC_DCTRL_DTDIR                         \ DTDIR
$0000000c constant SDMMC3_SDMMC_DCTRL_DTMODE                        \ DTMODE
$000000f0 constant SDMMC3_SDMMC_DCTRL_DBLOCKSIZE                    \ DBLOCKSIZE
$00000100 constant SDMMC3_SDMMC_DCTRL_RWSTART                       \ RWSTART
$00000200 constant SDMMC3_SDMMC_DCTRL_RWSTOP                        \ RWSTOP
$00000400 constant SDMMC3_SDMMC_DCTRL_RWMOD                         \ RWMOD
$00000800 constant SDMMC3_SDMMC_DCTRL_SDIOEN                        \ SDIOEN
$00001000 constant SDMMC3_SDMMC_DCTRL_BOOTACKEN                     \ BOOTACKEN
$00002000 constant SDMMC3_SDMMC_DCTRL_FIFORST                       \ FIFORST


\
\ @brief The SDMMC_DCNTR register loads the value from the data length register (see SDMMC_DLENR) when the DPSM moves from the Idle state to the Wait_R or Wait_S state. As data is transferred, the counter decrements the value until it reaches 0. The DPSM then moves to the Idle state and when there has been no error, the data status end flag (DATAEND) is set.
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$01ffffff constant SDMMC3_SDMMC_DCNTR_DATACOUNT                     \ DATACOUNT


\
\ @brief The SDMMC_STAR register is a read-only register. It contains two types of flag: Static flags (bits [28, 21, 11:0]): these bits remain asserted until they are cleared by writing to the SDMMC interrupt Clear register (see SDMMC_ICR) Dynamic flags (bits [20:12]): these bits change state depending on the state of the underlying logic (for example, FIFO full and empty flags are asserted and de-asserted as data while written to the FIFO)
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant SDMMC3_SDMMC_STAR_CCRCFAIL                       \ CCRCFAIL
$00000002 constant SDMMC3_SDMMC_STAR_DCRCFAIL                       \ DCRCFAIL
$00000004 constant SDMMC3_SDMMC_STAR_CTIMEOUT                       \ CTIMEOUT
$00000008 constant SDMMC3_SDMMC_STAR_DTIMEOUT                       \ DTIMEOUT
$00000010 constant SDMMC3_SDMMC_STAR_TXUNDERR                       \ TXUNDERR
$00000020 constant SDMMC3_SDMMC_STAR_RXOVERR                        \ RXOVERR
$00000040 constant SDMMC3_SDMMC_STAR_CMDREND                        \ CMDREND
$00000080 constant SDMMC3_SDMMC_STAR_CMDSENT                        \ CMDSENT
$00000100 constant SDMMC3_SDMMC_STAR_DATAEND                        \ DATAEND
$00000200 constant SDMMC3_SDMMC_STAR_DHOLD                          \ DHOLD
$00000400 constant SDMMC3_SDMMC_STAR_DBCKEND                        \ DBCKEND
$00000800 constant SDMMC3_SDMMC_STAR_DABORT                         \ DABORT
$00001000 constant SDMMC3_SDMMC_STAR_DPSMACT                        \ DPSMACT
$00002000 constant SDMMC3_SDMMC_STAR_CPSMACT                        \ CPSMACT
$00004000 constant SDMMC3_SDMMC_STAR_TXFIFOHE                       \ TXFIFOHE
$00008000 constant SDMMC3_SDMMC_STAR_RXFIFOHF                       \ RXFIFOHF
$00010000 constant SDMMC3_SDMMC_STAR_TXFIFOF                        \ TXFIFOF
$00020000 constant SDMMC3_SDMMC_STAR_RXFIFOF                        \ RXFIFOF
$00040000 constant SDMMC3_SDMMC_STAR_TXFIFOE                        \ TXFIFOE
$00080000 constant SDMMC3_SDMMC_STAR_RXFIFOE                        \ RXFIFOE
$00100000 constant SDMMC3_SDMMC_STAR_BUSYD0                         \ BUSYD0
$00200000 constant SDMMC3_SDMMC_STAR_BUSYD0END                      \ BUSYD0END
$00400000 constant SDMMC3_SDMMC_STAR_SDIOIT                         \ SDIOIT
$00800000 constant SDMMC3_SDMMC_STAR_ACKFAIL                        \ ACKFAIL
$01000000 constant SDMMC3_SDMMC_STAR_ACKTIMEOUT                     \ ACKTIMEOUT
$02000000 constant SDMMC3_SDMMC_STAR_VSWEND                         \ VSWEND
$04000000 constant SDMMC3_SDMMC_STAR_CKSTOP                         \ CKSTOP
$08000000 constant SDMMC3_SDMMC_STAR_IDMATE                         \ IDMATE
$10000000 constant SDMMC3_SDMMC_STAR_IDMABTC                        \ IDMABTC


\
\ @brief The SDMMC_ICR register is a write-only register. Writing a bit with 1 clears the corresponding bit in the SDMMC_STAR status register.
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant SDMMC3_SDMMC_ICR_CCRCFAILC                       \ CCRCFAILC
$00000002 constant SDMMC3_SDMMC_ICR_DCRCFAILC                       \ DCRCFAILC
$00000004 constant SDMMC3_SDMMC_ICR_CTIMEOUTC                       \ CTIMEOUTC
$00000008 constant SDMMC3_SDMMC_ICR_DTIMEOUTC                       \ DTIMEOUTC
$00000010 constant SDMMC3_SDMMC_ICR_TXUNDERRC                       \ TXUNDERRC
$00000020 constant SDMMC3_SDMMC_ICR_RXOVERRC                        \ RXOVERRC
$00000040 constant SDMMC3_SDMMC_ICR_CMDRENDC                        \ CMDRENDC
$00000080 constant SDMMC3_SDMMC_ICR_CMDSENTC                        \ CMDSENTC
$00000100 constant SDMMC3_SDMMC_ICR_DATAENDC                        \ DATAENDC
$00000200 constant SDMMC3_SDMMC_ICR_DHOLDC                          \ DHOLDC
$00000400 constant SDMMC3_SDMMC_ICR_DBCKENDC                        \ DBCKENDC
$00000800 constant SDMMC3_SDMMC_ICR_DABORTC                         \ DABORTC
$00200000 constant SDMMC3_SDMMC_ICR_BUSYD0ENDC                      \ BUSYD0ENDC
$00400000 constant SDMMC3_SDMMC_ICR_SDIOITC                         \ SDIOITC
$00800000 constant SDMMC3_SDMMC_ICR_ACKFAILC                        \ ACKFAILC
$01000000 constant SDMMC3_SDMMC_ICR_ACKTIMEOUTC                     \ ACKTIMEOUTC
$02000000 constant SDMMC3_SDMMC_ICR_VSWENDC                         \ VSWENDC
$04000000 constant SDMMC3_SDMMC_ICR_CKSTOPC                         \ CKSTOPC
$08000000 constant SDMMC3_SDMMC_ICR_IDMATEC                         \ IDMATEC
$10000000 constant SDMMC3_SDMMC_ICR_IDMABTCC                        \ IDMABTCC


\
\ @brief The interrupt mask register determines which status flags generate an interrupt request by setting the corresponding bit to 1.
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant SDMMC3_SDMMC_MASKR_CCRCFAILIE                    \ CCRCFAILIE
$00000002 constant SDMMC3_SDMMC_MASKR_DCRCFAILIE                    \ DCRCFAILIE
$00000004 constant SDMMC3_SDMMC_MASKR_CTIMEOUTIE                    \ CTIMEOUTIE
$00000008 constant SDMMC3_SDMMC_MASKR_DTIMEOUTIE                    \ DTIMEOUTIE
$00000010 constant SDMMC3_SDMMC_MASKR_TXUNDERRIE                    \ TXUNDERRIE
$00000020 constant SDMMC3_SDMMC_MASKR_RXOVERRIE                     \ RXOVERRIE
$00000040 constant SDMMC3_SDMMC_MASKR_CMDRENDIE                     \ CMDRENDIE
$00000080 constant SDMMC3_SDMMC_MASKR_CMDSENTIE                     \ CMDSENTIE
$00000100 constant SDMMC3_SDMMC_MASKR_DATAENDIE                     \ DATAENDIE
$00000200 constant SDMMC3_SDMMC_MASKR_DHOLDIE                       \ DHOLDIE
$00000400 constant SDMMC3_SDMMC_MASKR_DBCKENDIE                     \ DBCKENDIE
$00000800 constant SDMMC3_SDMMC_MASKR_DABORTIE                      \ DABORTIE
$00004000 constant SDMMC3_SDMMC_MASKR_TXFIFOHEIE                    \ TXFIFOHEIE
$00008000 constant SDMMC3_SDMMC_MASKR_RXFIFOHFIE                    \ RXFIFOHFIE
$00020000 constant SDMMC3_SDMMC_MASKR_RXFIFOFIE                     \ RXFIFOFIE
$00040000 constant SDMMC3_SDMMC_MASKR_TXFIFOEIE                     \ TXFIFOEIE
$00200000 constant SDMMC3_SDMMC_MASKR_BUSYD0ENDIE                   \ BUSYD0ENDIE
$00400000 constant SDMMC3_SDMMC_MASKR_SDIOITIE                      \ SDIOITIE
$00800000 constant SDMMC3_SDMMC_MASKR_ACKFAILIE                     \ ACKFAILIE
$01000000 constant SDMMC3_SDMMC_MASKR_ACKTIMEOUTIE                  \ ACKTIMEOUTIE
$02000000 constant SDMMC3_SDMMC_MASKR_VSWENDIE                      \ VSWENDIE
$04000000 constant SDMMC3_SDMMC_MASKR_CKSTOPIE                      \ CKSTOPIE
$10000000 constant SDMMC3_SDMMC_MASKR_IDMABTCIE                     \ IDMABTCIE


\
\ @brief The SDMMC_ACKTIMER register contains the acknowledgment timeout period, in SDMMC_CK bus clock periods. A counter loads the value from the SDMMC_ACKTIMER register, and starts decrementing when the data path state machine (DPSM) enters the Wait_Ack state. If the timer reaches 0 while the DPSM is in this states, the acknowledgment timeout status flag is set.
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$01ffffff constant SDMMC3_SDMMC_ACKTIMER_ACKTIME                    \ ACKTIME


\
\ @brief The receive and transmit FIFOs can be read or written as 32-bit wide registers. The FIFOs contain 32 entries on 32 sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO.
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant SDMMC3_SDMMC_IDMACTRLR_IDMAEN                    \ IDMAEN
$00000002 constant SDMMC3_SDMMC_IDMACTRLR_IDMABMODE                 \ IDMABMODE


\
\ @brief The SDMMC_IDMABSIZER register contains the buffer size when in linked list configuration.
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$0001ffe0 constant SDMMC3_SDMMC_IDMABSIZER_IDMABNDT                 \ IDMABNDT


\
\ @brief The SDMMC_IDMABASER register contains the memory buffer base address in single buffer configuration and linked list configuration.
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_IDMABASER_IDMABASE                  \ IDMABASE


\
\ @brief SDMMC IDMA linked list address register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$0000fffc constant SDMMC3_SDMMC_IDMALAR_IDMALA                      \ IDMALA
$20000000 constant SDMMC3_SDMMC_IDMALAR_ABR                         \ ABR
$40000000 constant SDMMC3_SDMMC_IDMALAR_ULS                         \ ULS
$80000000 constant SDMMC3_SDMMC_IDMALAR_ULA                         \ ULA


\
\ @brief SDMMC IDMA linked list memory base register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$fffffffc constant SDMMC3_SDMMC_IDMABAR_IDMABA                      \ IDMABA


\
\ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_FIFOR0_FIFODATA                     \ FIFODATA


\
\ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_FIFOR1_FIFODATA                     \ FIFODATA


\
\ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_FIFOR2_FIFODATA                     \ FIFODATA


\
\ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_FIFOR3_FIFODATA                     \ FIFODATA


\
\ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_FIFOR4_FIFODATA                     \ FIFODATA


\
\ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_FIFOR5_FIFODATA                     \ FIFODATA


\
\ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_FIFOR6_FIFODATA                     \ FIFODATA


\
\ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_FIFOR7_FIFODATA                     \ FIFODATA


\
\ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_FIFOR8_FIFODATA                     \ FIFODATA


\
\ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_FIFOR9_FIFODATA                     \ FIFODATA


\
\ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_FIFOR10_FIFODATA                    \ FIFODATA


\
\ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_FIFOR11_FIFODATA                    \ FIFODATA


\
\ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_FIFOR12_FIFODATA                    \ FIFODATA


\
\ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_FIFOR13_FIFODATA                    \ FIFODATA


\
\ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_FIFOR14_FIFODATA                    \ FIFODATA


\
\ @brief The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000000 constant SDMMC3_SDMMC_FIFOR15_FIFODATA                    \ FIFODATA


\
\ @brief SDMMC version register
\ Address offset: 0x3F4
\ Reset value: 0x00000020
\

$0000000f constant SDMMC3_SDMMC_VERR_MINREV                         \ MINREV
$000000f0 constant SDMMC3_SDMMC_VERR_MAJREV                         \ MAJREV


\
\ @brief SDMMC identification register
\ Address offset: 0x3F8
\ Reset value: 0x00140022
\

$00000000 constant SDMMC3_SDMMC_IPIDR_IP_ID                         \ IP_ID


\
\ @brief SDMMC size ID register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant SDMMC3_SDMMC_SIDR_SID                            \ SID


\
\ @brief SDMMC3 global interrupt
\
$48004000 constant SDMMC3_SDMMC_POWER  \ offset: 0x00 : SDMMC power control register
$48004004 constant SDMMC3_SDMMC_CLKCR  \ offset: 0x04 : The SDMMC_CLKCR register controls the SDMMC_CK output clock, the sdmmc_rx_ck receive clock, and the bus width.
$48004008 constant SDMMC3_SDMMC_ARGR  \ offset: 0x08 : The SDMMC_ARGR register contains a 32-bit command argument, which is sent to a card as part of a command message.
$4800400c constant SDMMC3_SDMMC_CMDR  \ offset: 0x0C : The SDMMC_CMDR register contains the command index and command type bits. The command index is sent to a card as part of a command message. The command type bits control the command path state machine (CPSM).
$48004010 constant SDMMC3_SDMMC_RESPCMDR  \ offset: 0x10 : The SDMMC_RESPCMDR register contains the command index field of the last command response received. If the command response transmission does not contain the command index field (long or OCR response), the RESPCMD field is unknown, although it must contain 111111b (the value of the reserved field from the response).
$48004014 constant SDMMC3_SDMMC_RESP1R  \ offset: 0x14 : The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
$48004018 constant SDMMC3_SDMMC_RESP2R  \ offset: 0x18 : The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
$4800401c constant SDMMC3_SDMMC_RESP3R  \ offset: 0x1C : The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
$48004020 constant SDMMC3_SDMMC_RESP4R  \ offset: 0x20 : The SDMMC_RESP1/2/3/4R registers contain the status of a card, which is part of the received response.
$48004024 constant SDMMC3_SDMMC_DTIMER  \ offset: 0x24 : The SDMMC_DTIMER register contains the data timeout period, in card bus clock periods. A counter loads the value from the SDMMC_DTIMER register, and starts decrementing when the data path state machine (DPSM) enters the Wait_R or Busy state. If the timer reaches 0 while the DPSM is in either of these states, the timeout status flag is set.
$48004028 constant SDMMC3_SDMMC_DLENR  \ offset: 0x28 : The SDMMC_DLENR register contains the number of data bytes to be transferred. The value is loaded into the data counter when data transfer starts.
$4800402c constant SDMMC3_SDMMC_DCTRL  \ offset: 0x2C : The SDMMC_DCTRL register control the data path state machine (DPSM).
$48004030 constant SDMMC3_SDMMC_DCNTR  \ offset: 0x30 : The SDMMC_DCNTR register loads the value from the data length register (see SDMMC_DLENR) when the DPSM moves from the Idle state to the Wait_R or Wait_S state. As data is transferred, the counter decrements the value until it reaches 0. The DPSM then moves to the Idle state and when there has been no error, the data status end flag (DATAEND) is set.
$48004034 constant SDMMC3_SDMMC_STAR  \ offset: 0x34 : The SDMMC_STAR register is a read-only register. It contains two types of flag: Static flags (bits [28, 21, 11:0]): these bits remain asserted until they are cleared by writing to the SDMMC interrupt Clear register (see SDMMC_ICR) Dynamic flags (bits [20:12]): these bits change state depending on the state of the underlying logic (for example, FIFO full and empty flags are asserted and de-asserted as data while written to the FIFO)
$48004038 constant SDMMC3_SDMMC_ICR  \ offset: 0x38 : The SDMMC_ICR register is a write-only register. Writing a bit with 1 clears the corresponding bit in the SDMMC_STAR status register.
$4800403c constant SDMMC3_SDMMC_MASKR  \ offset: 0x3C : The interrupt mask register determines which status flags generate an interrupt request by setting the corresponding bit to 1.
$48004040 constant SDMMC3_SDMMC_ACKTIMER  \ offset: 0x40 : The SDMMC_ACKTIMER register contains the acknowledgment timeout period, in SDMMC_CK bus clock periods. A counter loads the value from the SDMMC_ACKTIMER register, and starts decrementing when the data path state machine (DPSM) enters the Wait_Ack state. If the timer reaches 0 while the DPSM is in this states, the acknowledgment timeout status flag is set.
$48004050 constant SDMMC3_SDMMC_IDMACTRLR  \ offset: 0x50 : The receive and transmit FIFOs can be read or written as 32-bit wide registers. The FIFOs contain 32 entries on 32 sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO.
$48004054 constant SDMMC3_SDMMC_IDMABSIZER  \ offset: 0x54 : The SDMMC_IDMABSIZER register contains the buffer size when in linked list configuration.
$48004058 constant SDMMC3_SDMMC_IDMABASER  \ offset: 0x58 : The SDMMC_IDMABASER register contains the memory buffer base address in single buffer configuration and linked list configuration.
$48004064 constant SDMMC3_SDMMC_IDMALAR  \ offset: 0x64 : SDMMC IDMA linked list address register
$48004068 constant SDMMC3_SDMMC_IDMABAR  \ offset: 0x68 : SDMMC IDMA linked list memory base register
$48004080 constant SDMMC3_SDMMC_FIFOR0  \ offset: 0x80 : The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
$48004084 constant SDMMC3_SDMMC_FIFOR1  \ offset: 0x84 : The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
$48004088 constant SDMMC3_SDMMC_FIFOR2  \ offset: 0x88 : The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
$4800408c constant SDMMC3_SDMMC_FIFOR3  \ offset: 0x8C : The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
$48004090 constant SDMMC3_SDMMC_FIFOR4  \ offset: 0x90 : The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
$48004094 constant SDMMC3_SDMMC_FIFOR5  \ offset: 0x94 : The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
$48004098 constant SDMMC3_SDMMC_FIFOR6  \ offset: 0x98 : The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
$4800409c constant SDMMC3_SDMMC_FIFOR7  \ offset: 0x9C : The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
$480040a0 constant SDMMC3_SDMMC_FIFOR8  \ offset: 0xA0 : The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
$480040a4 constant SDMMC3_SDMMC_FIFOR9  \ offset: 0xA4 : The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
$480040a8 constant SDMMC3_SDMMC_FIFOR10  \ offset: 0xA8 : The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
$480040ac constant SDMMC3_SDMMC_FIFOR11  \ offset: 0xAC : The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
$480040b0 constant SDMMC3_SDMMC_FIFOR12  \ offset: 0xB0 : The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
$480040b4 constant SDMMC3_SDMMC_FIFOR13  \ offset: 0xB4 : The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
$480040b8 constant SDMMC3_SDMMC_FIFOR14  \ offset: 0xB8 : The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
$480040bc constant SDMMC3_SDMMC_FIFOR15  \ offset: 0xBC : The receive and transmit FIFOs can be only read or written as word (32-bit) wide registers. The FIFOs contain 16 entries on sequential addresses. This allows the CPU to use its load and store multiple operands to read from/write to the FIFO. The FIFO register interface takes care of correct data alignment inside the FIFO, the FIFO register address used by the CPU does matter. When accessing SDMMC_FIFOR with half word or byte access an AHB bus fault is generated.
$480043f4 constant SDMMC3_SDMMC_VERR  \ offset: 0x3F4 : SDMMC version register
$480043f8 constant SDMMC3_SDMMC_IPIDR  \ offset: 0x3F8 : SDMMC identification register
$480043fc constant SDMMC3_SDMMC_SIDR  \ offset: 0x3FC : SDMMC size ID register

