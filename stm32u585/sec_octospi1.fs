\
\ @file sec_octospi1.fs
\ @brief OctoSPI
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_OCTOSPI1_CR_EN                               \ Enable
$00000002 constant SEC_OCTOSPI1_CR_ABORT                            \ Abort request
$00000004 constant SEC_OCTOSPI1_CR_DMAEN                            \ DMA enable
$00000008 constant SEC_OCTOSPI1_CR_TCEN                             \ Timeout counter enable
$00000040 constant SEC_OCTOSPI1_CR_DQM                              \ Dual-quad mode
$00000080 constant SEC_OCTOSPI1_CR_FSEL                             \ FLASH memory selection
$00001f00 constant SEC_OCTOSPI1_CR_FTHRES                           \ IFO threshold level
$00010000 constant SEC_OCTOSPI1_CR_TEIE                             \ Transfer error interrupt enable
$00020000 constant SEC_OCTOSPI1_CR_TCIE                             \ Transfer complete interrupt enable
$00040000 constant SEC_OCTOSPI1_CR_FTIE                             \ FIFO threshold interrupt enable
$00080000 constant SEC_OCTOSPI1_CR_SMIE                             \ Status match interrupt enable
$00100000 constant SEC_OCTOSPI1_CR_TOIE                             \ TimeOut interrupt enable
$00400000 constant SEC_OCTOSPI1_CR_APMS                             \ Automatic poll mode stop
$00800000 constant SEC_OCTOSPI1_CR_PMM                              \ Polling match mode
$30000000 constant SEC_OCTOSPI1_CR_FMODE                            \ Functional mode


\
\ @brief device configuration register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SEC_OCTOSPI1_DCR1_CKMODE                         \ Mode 0 / mode 3
$00000002 constant SEC_OCTOSPI1_DCR1_FRCK                           \ Free running clock
$00000008 constant SEC_OCTOSPI1_DCR1_DLYBYP                         \ Delay block bypass
$00003f00 constant SEC_OCTOSPI1_DCR1_CSHT                           \ Chip-select high time
$001f0000 constant SEC_OCTOSPI1_DCR1_DEVSIZE                        \ Device size
$07000000 constant SEC_OCTOSPI1_DCR1_MTYP                           \ Memory type


\
\ @brief device configuration register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000ff constant SEC_OCTOSPI1_DCR2_PRESCALER                      \ Clock prescaler
$00070000 constant SEC_OCTOSPI1_DCR2_WRAPSIZE                       \ Wrap size


\
\ @brief device configuration register 3
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant SEC_OCTOSPI1_DCR3_MAXTRAN                        \ Maximum transfer
$001f0000 constant SEC_OCTOSPI1_DCR3_CSBOUND                        \ CS boundary


\
\ @brief DCR4
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant SEC_OCTOSPI1_DCR4_REFRESH                        \ Refresh rate


\
\ @brief status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SEC_OCTOSPI1_SR_TEF                              \ Transfer error flag
$00000002 constant SEC_OCTOSPI1_SR_TCF                              \ transfer complete flag
$00000004 constant SEC_OCTOSPI1_SR_FTF                              \ FIFO threshold flag
$00000008 constant SEC_OCTOSPI1_SR_SMF                              \ status match flag
$00000010 constant SEC_OCTOSPI1_SR_TOF                              \ timeout flag
$00000020 constant SEC_OCTOSPI1_SR_BUSY                             \ BUSY
$00003f00 constant SEC_OCTOSPI1_SR_FLEVEL                           \ FIFO level


\
\ @brief flag clear register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant SEC_OCTOSPI1_FCR_CTEF                            \ Clear Transfer error flag
$00000002 constant SEC_OCTOSPI1_FCR_CTCF                            \ Clear transfer complete flag
$00000008 constant SEC_OCTOSPI1_FCR_CSMF                            \ Clear status match flag
$00000010 constant SEC_OCTOSPI1_FCR_CTOF                            \ Clear timeout flag


\
\ @brief data length register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant SEC_OCTOSPI1_DLR_DL                              \ Data length


\
\ @brief address register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant SEC_OCTOSPI1_AR_ADDRESS                          \ ADDRESS


\
\ @brief data register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant SEC_OCTOSPI1_DR_DATA                             \ DATA


\
\ @brief polling status mask register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant SEC_OCTOSPI1_PSMKR_MASK                          \ Status MASK


\
\ @brief polling status match register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant SEC_OCTOSPI1_PSMAR_MATCH                         \ Status match


\
\ @brief polling interval register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$0000ffff constant SEC_OCTOSPI1_PIR_INTERVAL                        \ polling interval


\
\ @brief communication configuration register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000007 constant SEC_OCTOSPI1_CCR_IMODE                           \ Instruction mode
$00000008 constant SEC_OCTOSPI1_CCR_IDTR                            \ Instruction double transfer rate
$00000030 constant SEC_OCTOSPI1_CCR_ISIZE                           \ Instruction size
$00000700 constant SEC_OCTOSPI1_CCR_ADMODE                          \ Address mode
$00000800 constant SEC_OCTOSPI1_CCR_ADDTR                           \ Address double transfer rate
$00003000 constant SEC_OCTOSPI1_CCR_ADSIZE                          \ Address size
$00070000 constant SEC_OCTOSPI1_CCR_ABMODE                          \ Alternate byte mode
$00080000 constant SEC_OCTOSPI1_CCR_ABDTR                           \ Alternate bytes double transfer rate
$00300000 constant SEC_OCTOSPI1_CCR_ABSIZE                          \ Alternate bytes size
$07000000 constant SEC_OCTOSPI1_CCR_DMODE                           \ Data mode
$08000000 constant SEC_OCTOSPI1_CCR_DDTR                            \ Alternate bytes double transfer rate
$20000000 constant SEC_OCTOSPI1_CCR_DQSE                            \ DQS enable
$80000000 constant SEC_OCTOSPI1_CCR_SIOO                            \ Send instruction only once mode


\
\ @brief timing configuration register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$0000001f constant SEC_OCTOSPI1_TCR_DCYC                            \ Number of dummy cycles
$10000000 constant SEC_OCTOSPI1_TCR_DHQC                            \ Delay hold quarter cycle
$40000000 constant SEC_OCTOSPI1_TCR_SSHIFT                          \ Sample shift


\
\ @brief instruction register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant SEC_OCTOSPI1_IR_INSTRUCTION                      \ INSTRUCTION


\
\ @brief alternate bytes register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant SEC_OCTOSPI1_ABR_ALTERNATE                       \ Alternate bytes


\
\ @brief low-power timeout register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$0000ffff constant SEC_OCTOSPI1_LPTR_TIMEOUT                        \ Timeout period


\
\ @brief wrap communication configuration register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000007 constant SEC_OCTOSPI1_WPCCR_IMODE                         \ Instruction mode
$00000008 constant SEC_OCTOSPI1_WPCCR_IDTR                          \ Instruction double transfer rate
$00000030 constant SEC_OCTOSPI1_WPCCR_ISIZE                         \ Instruction size
$00000700 constant SEC_OCTOSPI1_WPCCR_ADMODE                        \ Address mode
$00000800 constant SEC_OCTOSPI1_WPCCR_ADDTR                         \ Address double transfer rate
$00003000 constant SEC_OCTOSPI1_WPCCR_ADSIZE                        \ Address size
$00070000 constant SEC_OCTOSPI1_WPCCR_ABMODE                        \ Alternate byte mode
$00080000 constant SEC_OCTOSPI1_WPCCR_ABDTR                         \ Alternate bytes double transfer rate
$00300000 constant SEC_OCTOSPI1_WPCCR_ABSIZE                        \ Alternate bytes size
$07000000 constant SEC_OCTOSPI1_WPCCR_DMODE                         \ Data mode
$08000000 constant SEC_OCTOSPI1_WPCCR_DDTR                          \ alternate bytes double transfer rate
$20000000 constant SEC_OCTOSPI1_WPCCR_DQSE                          \ DQS enable


\
\ @brief wrap timing configuration register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$0000001f constant SEC_OCTOSPI1_WPTCR_DCYC                          \ Number of dummy cycles
$10000000 constant SEC_OCTOSPI1_WPTCR_DHQC                          \ Delay hold quarter cycle
$40000000 constant SEC_OCTOSPI1_WPTCR_SSHIFT                        \ Sample shift


\
\ @brief wrap instruction register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000000 constant SEC_OCTOSPI1_WPIR_INSTRUCTION                    \ INSTRUCTION


\
\ @brief wrap alternate bytes register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000000 constant SEC_OCTOSPI1_WPABR_ALTERNATE                     \ Alternate bytes


\
\ @brief write communication configuration register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000007 constant SEC_OCTOSPI1_WCCR_IMODE                          \ Instruction mode
$00000008 constant SEC_OCTOSPI1_WCCR_IDTR                           \ Instruction double transfer rate
$00000030 constant SEC_OCTOSPI1_WCCR_ISIZE                          \ Instruction size
$00000700 constant SEC_OCTOSPI1_WCCR_ADMODE                         \ Address mode
$00000800 constant SEC_OCTOSPI1_WCCR_ADDTR                          \ Address double transfer rate
$00003000 constant SEC_OCTOSPI1_WCCR_ADSIZE                         \ Address size
$00070000 constant SEC_OCTOSPI1_WCCR_ABMODE                         \ Alternate byte mode
$00080000 constant SEC_OCTOSPI1_WCCR_ABDTR                          \ Alternate bytes double transfer rate
$00300000 constant SEC_OCTOSPI1_WCCR_ABSIZE                         \ Alternate bytes size
$07000000 constant SEC_OCTOSPI1_WCCR_DMODE                          \ Data mode
$08000000 constant SEC_OCTOSPI1_WCCR_DDTR                           \ alternate bytes double transfer rate
$20000000 constant SEC_OCTOSPI1_WCCR_DQSE                           \ DQS enable


\
\ @brief write timing configuration register
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$0000001f constant SEC_OCTOSPI1_WTCR_DCYC                           \ Number of dummy cycles


\
\ @brief write instruction register
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000000 constant SEC_OCTOSPI1_WIR_INSTRUCTION                     \ INSTRUCTION


\
\ @brief write alternate bytes register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant SEC_OCTOSPI1_WABR_ALTERNATE                      \ ALTERNATE


\
\ @brief HyperBus latency configuration register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant SEC_OCTOSPI1_HLCR_LM                             \ Latency mode
$00000002 constant SEC_OCTOSPI1_HLCR_WZL                            \ Write zero latency
$0000ff00 constant SEC_OCTOSPI1_HLCR_TACC                           \ Access time
$00ff0000 constant SEC_OCTOSPI1_HLCR_TRWR                           \ Read write recovery time


\
\ @brief OctoSPI
\
$520d1400 constant SEC_OCTOSPI1_CR  \ offset: 0x00 : control register
$520d1408 constant SEC_OCTOSPI1_DCR1  \ offset: 0x08 : device configuration register 1
$520d140c constant SEC_OCTOSPI1_DCR2  \ offset: 0x0C : device configuration register 2
$520d1410 constant SEC_OCTOSPI1_DCR3  \ offset: 0x10 : device configuration register 3
$520d1414 constant SEC_OCTOSPI1_DCR4  \ offset: 0x14 : DCR4
$520d1420 constant SEC_OCTOSPI1_SR  \ offset: 0x20 : status register
$520d1424 constant SEC_OCTOSPI1_FCR  \ offset: 0x24 : flag clear register
$520d1440 constant SEC_OCTOSPI1_DLR  \ offset: 0x40 : data length register
$520d1448 constant SEC_OCTOSPI1_AR  \ offset: 0x48 : address register
$520d1450 constant SEC_OCTOSPI1_DR  \ offset: 0x50 : data register
$520d1480 constant SEC_OCTOSPI1_PSMKR  \ offset: 0x80 : polling status mask register
$520d1488 constant SEC_OCTOSPI1_PSMAR  \ offset: 0x88 : polling status match register
$520d1490 constant SEC_OCTOSPI1_PIR  \ offset: 0x90 : polling interval register
$520d1500 constant SEC_OCTOSPI1_CCR  \ offset: 0x100 : communication configuration register
$520d1508 constant SEC_OCTOSPI1_TCR  \ offset: 0x108 : timing configuration register
$520d1510 constant SEC_OCTOSPI1_IR  \ offset: 0x110 : instruction register
$520d1520 constant SEC_OCTOSPI1_ABR  \ offset: 0x120 : alternate bytes register
$520d1530 constant SEC_OCTOSPI1_LPTR  \ offset: 0x130 : low-power timeout register
$520d1540 constant SEC_OCTOSPI1_WPCCR  \ offset: 0x140 : wrap communication configuration register
$520d1548 constant SEC_OCTOSPI1_WPTCR  \ offset: 0x148 : wrap timing configuration register
$520d1550 constant SEC_OCTOSPI1_WPIR  \ offset: 0x150 : wrap instruction register
$520d1560 constant SEC_OCTOSPI1_WPABR  \ offset: 0x160 : wrap alternate bytes register
$520d1580 constant SEC_OCTOSPI1_WCCR  \ offset: 0x180 : write communication configuration register
$520d1588 constant SEC_OCTOSPI1_WTCR  \ offset: 0x188 : write timing configuration register
$520d1590 constant SEC_OCTOSPI1_WIR  \ offset: 0x190 : write instruction register
$520d15a0 constant SEC_OCTOSPI1_WABR  \ offset: 0x1A0 : write alternate bytes register
$520d1600 constant SEC_OCTOSPI1_HLCR  \ offset: 0x200 : HyperBus latency configuration register

