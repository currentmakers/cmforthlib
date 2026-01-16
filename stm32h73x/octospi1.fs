\
\ @file octospi1.fs
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

$00000001 constant OCTOSPI1_CR_EN                                   \ Enable
$00000002 constant OCTOSPI1_CR_ABORT                                \ Abort request
$00000004 constant OCTOSPI1_CR_DMAEN                                \ DMA enable
$00000008 constant OCTOSPI1_CR_TCEN                                 \ Timeout counter enable
$00000040 constant OCTOSPI1_CR_DQM                                  \ Dual-quad mode
$00000080 constant OCTOSPI1_CR_FSEL                                 \ FLASH memory selection
$00001f00 constant OCTOSPI1_CR_FTHRES                               \ IFO threshold level
$00010000 constant OCTOSPI1_CR_TEIE                                 \ Transfer error interrupt enable
$00020000 constant OCTOSPI1_CR_TCIE                                 \ Transfer complete interrupt enable
$00040000 constant OCTOSPI1_CR_FTIE                                 \ FIFO threshold interrupt enable
$00080000 constant OCTOSPI1_CR_SMIE                                 \ Status match interrupt enable
$00100000 constant OCTOSPI1_CR_TOIE                                 \ TimeOut interrupt enable
$00400000 constant OCTOSPI1_CR_APMS                                 \ Automatic poll mode stop
$00800000 constant OCTOSPI1_CR_PMM                                  \ Polling match mode
$30000000 constant OCTOSPI1_CR_FMODE                                \ Functional mode


\
\ @brief device configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant OCTOSPI1_DCR1_CKMODE                             \ Mode 0 / mode 3
$00000002 constant OCTOSPI1_DCR1_FRCK                               \ Free running clock
$00000008 constant OCTOSPI1_DCR1_DLYBYP                             \ Delay block bypass
$00003f00 constant OCTOSPI1_DCR1_CSHT                               \ Chip-select high time
$001f0000 constant OCTOSPI1_DCR1_DEVSIZE                            \ Device size
$07000000 constant OCTOSPI1_DCR1_MTYP                               \ Memory type


\
\ @brief device configuration register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000ff constant OCTOSPI1_DCR2_PRESCALER                          \ Clock prescaler
$00070000 constant OCTOSPI1_DCR2_WRAPSIZE                           \ Wrap size


\
\ @brief device configuration register 3
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant OCTOSPI1_DCR3_MAXTRAN                            \ Maximum transfer
$001f0000 constant OCTOSPI1_DCR3_CSBOUND                            \ CS boundary


\
\ @brief DCR4
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI1_DCR4_REFRESH                            \ Refresh rate


\
\ @brief status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant OCTOSPI1_SR_TEF                                  \ transfer error flag
$00000002 constant OCTOSPI1_SR_TCF                                  \ transfer complete flag
$00000004 constant OCTOSPI1_SR_FTF                                  \ FIFO threshold flag
$00000008 constant OCTOSPI1_SR_SMF                                  \ status match flag
$00000010 constant OCTOSPI1_SR_TOF                                  \ timeout flag
$00000020 constant OCTOSPI1_SR_BUSY                                 \ Busy
$00003f00 constant OCTOSPI1_SR_FLEVEL                               \ FIFO level


\
\ @brief flag clear register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant OCTOSPI1_FCR_CTEF                                \ Clear transfer error flag
$00000002 constant OCTOSPI1_FCR_CTCF                                \ Clear transfer complete flag
$00000008 constant OCTOSPI1_FCR_CSMF                                \ Clear status match flag
$00000010 constant OCTOSPI1_FCR_CTOF                                \ Clear timeout flag


\
\ @brief data length register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI1_DLR_DL                                  \ Data length


\
\ @brief address register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI1_AR_ADRESS                               \ Adress


\
\ @brief data register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI1_DR_DATA                                 \ Data


\
\ @brief polling status mask register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI1_PSMKR_MASK                              \ Status mask


\
\ @brief polling status match register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI1_PSMAR_MATCH                             \ Match


\
\ @brief OCTOSPI polling interval register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$0000ffff constant OCTOSPI1_PIR_INTERVAL                            \ Polling interval


\
\ @brief polling interval register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000007 constant OCTOSPI1_CCR_IMODE                               \ Instruction mode
$00000008 constant OCTOSPI1_CCR_IDTR                                \ Instruction double transfer rate
$00000030 constant OCTOSPI1_CCR_ISIZE                               \ Instruction size
$00000700 constant OCTOSPI1_CCR_ADMODE                              \ Address mode
$00000800 constant OCTOSPI1_CCR_ADDTR                               \ Address double transfer rate
$00003000 constant OCTOSPI1_CCR_ADSIZE                              \ Address size
$00070000 constant OCTOSPI1_CCR_ABMODE                              \ Alternate byte mode
$00080000 constant OCTOSPI1_CCR_ABDTR                               \ Alternate bytes double transfer rate
$00300000 constant OCTOSPI1_CCR_ABSIZE                              \ Alternate bytes size
$07000000 constant OCTOSPI1_CCR_DMODE                               \ Data mode
$08000000 constant OCTOSPI1_CCR_DDTR                                \ Alternate bytes double transfer rate
$20000000 constant OCTOSPI1_CCR_DQSE                                \ DQS enable
$80000000 constant OCTOSPI1_CCR_SIOO                                \ Send instruction only once mode


\
\ @brief communication configuration register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$0000001f constant OCTOSPI1_TCR_DCYC                                \ Number of dummy cycles
$10000000 constant OCTOSPI1_TCR_DHQC                                \ Delay hold quarter cycle
$40000000 constant OCTOSPI1_TCR_SSHIFT                              \ Sample shift


\
\ @brief timing configuration register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI1_IR_INSTRUCTION                          \ INSTRUCTION


\
\ @brief instruction register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI1_ABR_ALTERNATE                           \ Alternate bytes


\
\ @brief alternate bytes register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$0000ffff constant OCTOSPI1_LPTR_TIMEOUT                            \ Timeout period


\
\ @brief low-power timeout register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000007 constant OCTOSPI1_WPCCR_IMODE                             \ Instruction mode
$00000008 constant OCTOSPI1_WPCCR_IDTR                              \ Instruction double transfer rate
$00000030 constant OCTOSPI1_WPCCR_ISIZE                             \ Instruction size
$00000700 constant OCTOSPI1_WPCCR_ADMODE                            \ Address mode
$00000800 constant OCTOSPI1_WPCCR_ADDTR                             \ Address double transfer rate
$00003000 constant OCTOSPI1_WPCCR_ADSIZE                            \ Address size
$00070000 constant OCTOSPI1_WPCCR_ABMODE                            \ Alternate byte mode
$00080000 constant OCTOSPI1_WPCCR_ABDTR                             \ Alternate bytes double transfer rate
$00300000 constant OCTOSPI1_WPCCR_ABSIZE                            \ Alternate bytes size
$07000000 constant OCTOSPI1_WPCCR_DMODE                             \ Data mode
$08000000 constant OCTOSPI1_WPCCR_DDTR                              \ alternate bytes double transfer rate
$20000000 constant OCTOSPI1_WPCCR_DQSE                              \ DQS enable


\
\ @brief wrap timing configuration register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$0000001f constant OCTOSPI1_WPTCR_DCYC                              \ Number of dummy cycles
$10000000 constant OCTOSPI1_WPTCR_DHQC                              \ Delay hold quarter cycle
$40000000 constant OCTOSPI1_WPTCR_SSHIFT                            \ Sample shift


\
\ @brief wrap instruction register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI1_WPIR_INSTRUCTION                        \ INSTRUCTION


\
\ @brief wrap alternate bytes register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI1_WPABR_ALTERNATE                         \ Alternate bytes


\
\ @brief write communication configuration register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000007 constant OCTOSPI1_WCCR_IMODE                              \ Instruction mode
$00000008 constant OCTOSPI1_WCCR_IDTR                               \ Instruction double transfer rate
$00000030 constant OCTOSPI1_WCCR_ISIZE                              \ Instruction size
$00000700 constant OCTOSPI1_WCCR_ADMODE                             \ Address mode
$00000800 constant OCTOSPI1_WCCR_ADDTR                              \ Address double transfer rate
$00003000 constant OCTOSPI1_WCCR_ADSIZE                             \ Address size
$00070000 constant OCTOSPI1_WCCR_ABMODE                             \ Alternate-byte mode
$00080000 constant OCTOSPI1_WCCR_ABDTR                              \ Alternate bytes double transfer rate
$00300000 constant OCTOSPI1_WCCR_ABSIZE                             \ Alternate bytes size
$07000000 constant OCTOSPI1_WCCR_DMODE                              \ Data mode
$08000000 constant OCTOSPI1_WCCR_DDTR                               \ DDTR
$20000000 constant OCTOSPI1_WCCR_DQSE                               \ DQSE


\
\ @brief write timing configuration register
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$0000001f constant OCTOSPI1_WTCR_DCYC                               \ DCYC


\
\ @brief OCTOSPI write instruction register
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI1_WIR_INSTRUCTION                         \ Instruction Instruction to be sent to the external SPI device


\
\ @brief write alternate bytes register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI1_WABR_ALTERNATE                          \ Alternate bytes


\
\ @brief HyperBusTM latency configuration register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant OCTOSPI1_HLCR_LM                                 \ Latency mode
$00000002 constant OCTOSPI1_HLCR_WZL                                \ Write zero latency
$0000ff00 constant OCTOSPI1_HLCR_TACC                               \ Access time
$00ff0000 constant OCTOSPI1_HLCR_TRWR                               \ Read write recovery time


\
\ @brief OctoSPI
\
$52005000 constant OCTOSPI1_CR    \ offset: 0x00 : control register
$52005008 constant OCTOSPI1_DCR1  \ offset: 0x08 : device configuration register
$5200500c constant OCTOSPI1_DCR2  \ offset: 0x0C : device configuration register 2
$52005010 constant OCTOSPI1_DCR3  \ offset: 0x10 : device configuration register 3
$52005014 constant OCTOSPI1_DCR4  \ offset: 0x14 : DCR4
$52005020 constant OCTOSPI1_SR    \ offset: 0x20 : status register
$52005024 constant OCTOSPI1_FCR   \ offset: 0x24 : flag clear register
$52005040 constant OCTOSPI1_DLR   \ offset: 0x40 : data length register
$52005048 constant OCTOSPI1_AR    \ offset: 0x48 : address register
$52005050 constant OCTOSPI1_DR    \ offset: 0x50 : data register
$52005080 constant OCTOSPI1_PSMKR  \ offset: 0x80 : polling status mask register
$52005088 constant OCTOSPI1_PSMAR  \ offset: 0x88 : polling status match register
$52005090 constant OCTOSPI1_PIR   \ offset: 0x90 : OCTOSPI polling interval register
$52005100 constant OCTOSPI1_CCR   \ offset: 0x100 : polling interval register
$52005108 constant OCTOSPI1_TCR   \ offset: 0x108 : communication configuration register
$52005110 constant OCTOSPI1_IR    \ offset: 0x110 : timing configuration register
$52005120 constant OCTOSPI1_ABR   \ offset: 0x120 : instruction register
$52005130 constant OCTOSPI1_LPTR  \ offset: 0x130 : alternate bytes register
$52005140 constant OCTOSPI1_WPCCR  \ offset: 0x140 : low-power timeout register
$52005148 constant OCTOSPI1_WPTCR  \ offset: 0x148 : wrap timing configuration register
$52005150 constant OCTOSPI1_WPIR  \ offset: 0x150 : wrap instruction register
$52005160 constant OCTOSPI1_WPABR  \ offset: 0x160 : wrap alternate bytes register
$52005180 constant OCTOSPI1_WCCR  \ offset: 0x180 : write communication configuration register
$52005188 constant OCTOSPI1_WTCR  \ offset: 0x188 : write timing configuration register
$52005190 constant OCTOSPI1_WIR   \ offset: 0x190 : OCTOSPI write instruction register
$520051a0 constant OCTOSPI1_WABR  \ offset: 0x1A0 : write alternate bytes register
$52005200 constant OCTOSPI1_HLCR  \ offset: 0x200 : HyperBusTM latency configuration register

