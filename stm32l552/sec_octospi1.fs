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
\ @brief device configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SEC_OCTOSPI1_DCR1_CKMODE                         \ Mode 0 / mode 3
$00000002 constant SEC_OCTOSPI1_DCR1_FRCK                           \ Free running clock
$00000008 constant SEC_OCTOSPI1_DCR1_DLYBYP                         \ Delay block bypass
$00000700 constant SEC_OCTOSPI1_DCR1_CSHT                           \ Chip-select high time
$001f0000 constant SEC_OCTOSPI1_DCR1_DEVSIZE                        \ Device size
$03000000 constant SEC_OCTOSPI1_DCR1_MTYP                           \ Memory type


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

$001f0000 constant SEC_OCTOSPI1_DCR3_CSBOUND                        \ CS boundary


\
\ @brief device configuration register 4
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant SEC_OCTOSPI1_DCR4_REFRESH                        \ REFRESH


\
\ @brief status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SEC_OCTOSPI1_SR_TEF                              \ Transfer error flag
$00000002 constant SEC_OCTOSPI1_SR_TCF                              \ Transfer complete flag
$00000004 constant SEC_OCTOSPI1_SR_FTF                              \ FIFO threshold flag
$00000008 constant SEC_OCTOSPI1_SR_SMF                              \ Status match flag
$00000010 constant SEC_OCTOSPI1_SR_TOF                              \ Timeout flag
$00000020 constant SEC_OCTOSPI1_SR_BUSY                             \ BUSY
$00003f00 constant SEC_OCTOSPI1_SR_FLEVEL                           \ FIFO level


\
\ @brief flag clear register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant SEC_OCTOSPI1_FCR_CTEF                            \ Clear transfer error flag
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

$00000000 constant SEC_OCTOSPI1_DR_DATA                             \ Data


\
\ @brief polling status mask register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant SEC_OCTOSPI1_PSMKR_MASK                          \ Status mask


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

$0000ffff constant SEC_OCTOSPI1_PIR_INTERVAL                        \ Polling interval


\
\ @brief communication configuration
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
\ @brief WCCR
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000007 constant SEC_OCTOSPI1_WCCR_IMODE                          \ IMODE
$00000008 constant SEC_OCTOSPI1_WCCR_IDTR                           \ IDTR
$00000030 constant SEC_OCTOSPI1_WCCR_ISIZE                          \ ISIZE
$00000700 constant SEC_OCTOSPI1_WCCR_ADMODE                         \ ADMODE
$00000800 constant SEC_OCTOSPI1_WCCR_ADDTR                          \ ADDTR
$00003000 constant SEC_OCTOSPI1_WCCR_ADSIZE                         \ ADSIZE
$00070000 constant SEC_OCTOSPI1_WCCR_ABMODE                         \ ABMODE
$00080000 constant SEC_OCTOSPI1_WCCR_ABDTR                          \ ABDTR
$00300000 constant SEC_OCTOSPI1_WCCR_ABSIZE                         \ ABSIZE
$07000000 constant SEC_OCTOSPI1_WCCR_DMODE                          \ DMODE
$08000000 constant SEC_OCTOSPI1_WCCR_DDTR                           \ DDTR
$20000000 constant SEC_OCTOSPI1_WCCR_DQSE                           \ DQSE


\
\ @brief WTCR
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$0000001f constant SEC_OCTOSPI1_WTCR_DCYC                           \ DCYC


\
\ @brief WIR
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000000 constant SEC_OCTOSPI1_WIR_INSTRUCTION                     \ INSTRUCTION


\
\ @brief write alternate bytes register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant SEC_OCTOSPI1_WABR_ALTERNATE                      \ Alternate bytes


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
$54021000 constant SEC_OCTOSPI1_CR  \ offset: 0x00 : control register
$54021008 constant SEC_OCTOSPI1_DCR1  \ offset: 0x08 : device configuration register
$5402100c constant SEC_OCTOSPI1_DCR2  \ offset: 0x0C : device configuration register 2
$54021010 constant SEC_OCTOSPI1_DCR3  \ offset: 0x10 : device configuration register 3
$54021014 constant SEC_OCTOSPI1_DCR4  \ offset: 0x14 : device configuration register 4
$54021020 constant SEC_OCTOSPI1_SR  \ offset: 0x20 : status register
$54021024 constant SEC_OCTOSPI1_FCR  \ offset: 0x24 : flag clear register
$54021040 constant SEC_OCTOSPI1_DLR  \ offset: 0x40 : data length register
$54021048 constant SEC_OCTOSPI1_AR  \ offset: 0x48 : address register
$54021050 constant SEC_OCTOSPI1_DR  \ offset: 0x50 : data register
$54021080 constant SEC_OCTOSPI1_PSMKR  \ offset: 0x80 : polling status mask register
$54021088 constant SEC_OCTOSPI1_PSMAR  \ offset: 0x88 : polling status match register
$54021090 constant SEC_OCTOSPI1_PIR  \ offset: 0x90 : polling interval register
$54021100 constant SEC_OCTOSPI1_CCR  \ offset: 0x100 : communication configuration
$54021108 constant SEC_OCTOSPI1_TCR  \ offset: 0x108 : timing configuration register
$54021110 constant SEC_OCTOSPI1_IR  \ offset: 0x110 : instruction register
$54021120 constant SEC_OCTOSPI1_ABR  \ offset: 0x120 : alternate bytes register
$54021130 constant SEC_OCTOSPI1_LPTR  \ offset: 0x130 : low-power timeout register
$54021140 constant SEC_OCTOSPI1_WPCCR  \ offset: 0x140 : wrap communication configuration register
$54021148 constant SEC_OCTOSPI1_WPTCR  \ offset: 0x148 : wrap timing configuration register
$54021150 constant SEC_OCTOSPI1_WPIR  \ offset: 0x150 : wrap instruction register
$54021160 constant SEC_OCTOSPI1_WPABR  \ offset: 0x160 : wrap alternate bytes register
$54021180 constant SEC_OCTOSPI1_WCCR  \ offset: 0x180 : WCCR
$54021188 constant SEC_OCTOSPI1_WTCR  \ offset: 0x188 : WTCR
$54021190 constant SEC_OCTOSPI1_WIR  \ offset: 0x190 : WIR
$540211a0 constant SEC_OCTOSPI1_WABR  \ offset: 0x1A0 : write alternate bytes register
$54021200 constant SEC_OCTOSPI1_HLCR  \ offset: 0x200 : HyperBus latency configuration register

