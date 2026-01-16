\
\ @file octospi2.fs
\ @brief OCTOSPI2 global interrupt
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

$00000001 constant OCTOSPI2_CR_EN                                   \ Enable
$00000002 constant OCTOSPI2_CR_ABORT                                \ Abort request
$00000004 constant OCTOSPI2_CR_DMAEN                                \ DMA enable
$00000008 constant OCTOSPI2_CR_TCEN                                 \ Timeout counter enable
$00000040 constant OCTOSPI2_CR_DQM                                  \ Dual-quad mode
$00000080 constant OCTOSPI2_CR_FSEL                                 \ FLASH memory selection
$00001f00 constant OCTOSPI2_CR_FTHRES                               \ IFO threshold level
$00010000 constant OCTOSPI2_CR_TEIE                                 \ Transfer error interrupt enable
$00020000 constant OCTOSPI2_CR_TCIE                                 \ Transfer complete interrupt enable
$00040000 constant OCTOSPI2_CR_FTIE                                 \ FIFO threshold interrupt enable
$00080000 constant OCTOSPI2_CR_SMIE                                 \ Status match interrupt enable
$00100000 constant OCTOSPI2_CR_TOIE                                 \ TimeOut interrupt enable
$00400000 constant OCTOSPI2_CR_APMS                                 \ Automatic poll mode stop
$00800000 constant OCTOSPI2_CR_PMM                                  \ Polling match mode
$30000000 constant OCTOSPI2_CR_FMODE                                \ Functional mode


\
\ @brief device configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant OCTOSPI2_DCR1_CKMODE                             \ Mode 0 / mode 3
$00000002 constant OCTOSPI2_DCR1_FRCK                               \ Free running clock
$00000008 constant OCTOSPI2_DCR1_DLYBYP                             \ Delay block bypass
$00003f00 constant OCTOSPI2_DCR1_CSHT                               \ Chip-select high time
$001f0000 constant OCTOSPI2_DCR1_DEVSIZE                            \ Device size
$07000000 constant OCTOSPI2_DCR1_MTYP                               \ Memory type


\
\ @brief device configuration register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000ff constant OCTOSPI2_DCR2_PRESCALER                          \ Clock prescaler
$00070000 constant OCTOSPI2_DCR2_WRAPSIZE                           \ Wrap size


\
\ @brief device configuration register 3
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant OCTOSPI2_DCR3_MAXTRAN                            \ Maximum transfer
$001f0000 constant OCTOSPI2_DCR3_CSBOUND                            \ CS boundary


\
\ @brief DCR4
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI2_DCR4_REFRESH                            \ Refresh rate


\
\ @brief status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant OCTOSPI2_SR_TEF                                  \ transfer error flag
$00000002 constant OCTOSPI2_SR_TCF                                  \ transfer complete flag
$00000004 constant OCTOSPI2_SR_FTF                                  \ FIFO threshold flag
$00000008 constant OCTOSPI2_SR_SMF                                  \ status match flag
$00000010 constant OCTOSPI2_SR_TOF                                  \ timeout flag
$00000020 constant OCTOSPI2_SR_BUSY                                 \ Busy
$00003f00 constant OCTOSPI2_SR_FLEVEL                               \ FIFO level


\
\ @brief flag clear register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant OCTOSPI2_FCR_CTEF                                \ Clear transfer error flag
$00000002 constant OCTOSPI2_FCR_CTCF                                \ Clear transfer complete flag
$00000008 constant OCTOSPI2_FCR_CSMF                                \ Clear status match flag
$00000010 constant OCTOSPI2_FCR_CTOF                                \ Clear timeout flag


\
\ @brief data length register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI2_DLR_DL                                  \ Data length


\
\ @brief address register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI2_AR_ADRESS                               \ Adress


\
\ @brief data register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI2_DR_DATA                                 \ Data


\
\ @brief polling status mask register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI2_PSMKR_MASK                              \ Status mask


\
\ @brief polling status match register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI2_PSMAR_MATCH                             \ Match


\
\ @brief OCTOSPI polling interval register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$0000ffff constant OCTOSPI2_PIR_INTERVAL                            \ Polling interval


\
\ @brief polling interval register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000007 constant OCTOSPI2_CCR_IMODE                               \ Instruction mode
$00000008 constant OCTOSPI2_CCR_IDTR                                \ Instruction double transfer rate
$00000030 constant OCTOSPI2_CCR_ISIZE                               \ Instruction size
$00000700 constant OCTOSPI2_CCR_ADMODE                              \ Address mode
$00000800 constant OCTOSPI2_CCR_ADDTR                               \ Address double transfer rate
$00003000 constant OCTOSPI2_CCR_ADSIZE                              \ Address size
$00070000 constant OCTOSPI2_CCR_ABMODE                              \ Alternate byte mode
$00080000 constant OCTOSPI2_CCR_ABDTR                               \ Alternate bytes double transfer rate
$00300000 constant OCTOSPI2_CCR_ABSIZE                              \ Alternate bytes size
$07000000 constant OCTOSPI2_CCR_DMODE                               \ Data mode
$08000000 constant OCTOSPI2_CCR_DDTR                                \ Alternate bytes double transfer rate
$20000000 constant OCTOSPI2_CCR_DQSE                                \ DQS enable
$80000000 constant OCTOSPI2_CCR_SIOO                                \ Send instruction only once mode


\
\ @brief communication configuration register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$0000001f constant OCTOSPI2_TCR_DCYC                                \ Number of dummy cycles
$10000000 constant OCTOSPI2_TCR_DHQC                                \ Delay hold quarter cycle
$40000000 constant OCTOSPI2_TCR_SSHIFT                              \ Sample shift


\
\ @brief timing configuration register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI2_IR_INSTRUCTION                          \ INSTRUCTION


\
\ @brief instruction register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI2_ABR_ALTERNATE                           \ Alternate bytes


\
\ @brief alternate bytes register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$0000ffff constant OCTOSPI2_LPTR_TIMEOUT                            \ Timeout period


\
\ @brief low-power timeout register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000007 constant OCTOSPI2_WPCCR_IMODE                             \ Instruction mode
$00000008 constant OCTOSPI2_WPCCR_IDTR                              \ Instruction double transfer rate
$00000030 constant OCTOSPI2_WPCCR_ISIZE                             \ Instruction size
$00000700 constant OCTOSPI2_WPCCR_ADMODE                            \ Address mode
$00000800 constant OCTOSPI2_WPCCR_ADDTR                             \ Address double transfer rate
$00003000 constant OCTOSPI2_WPCCR_ADSIZE                            \ Address size
$00070000 constant OCTOSPI2_WPCCR_ABMODE                            \ Alternate byte mode
$00080000 constant OCTOSPI2_WPCCR_ABDTR                             \ Alternate bytes double transfer rate
$00300000 constant OCTOSPI2_WPCCR_ABSIZE                            \ Alternate bytes size
$07000000 constant OCTOSPI2_WPCCR_DMODE                             \ Data mode
$08000000 constant OCTOSPI2_WPCCR_DDTR                              \ alternate bytes double transfer rate
$20000000 constant OCTOSPI2_WPCCR_DQSE                              \ DQS enable


\
\ @brief wrap timing configuration register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$0000001f constant OCTOSPI2_WPTCR_DCYC                              \ Number of dummy cycles
$10000000 constant OCTOSPI2_WPTCR_DHQC                              \ Delay hold quarter cycle
$40000000 constant OCTOSPI2_WPTCR_SSHIFT                            \ Sample shift


\
\ @brief wrap instruction register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI2_WPIR_INSTRUCTION                        \ INSTRUCTION


\
\ @brief wrap alternate bytes register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI2_WPABR_ALTERNATE                         \ Alternate bytes


\
\ @brief write communication configuration register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000007 constant OCTOSPI2_WCCR_IMODE                              \ Instruction mode
$00000008 constant OCTOSPI2_WCCR_IDTR                               \ Instruction double transfer rate
$00000030 constant OCTOSPI2_WCCR_ISIZE                              \ Instruction size
$00000700 constant OCTOSPI2_WCCR_ADMODE                             \ Address mode
$00000800 constant OCTOSPI2_WCCR_ADDTR                              \ Address double transfer rate
$00003000 constant OCTOSPI2_WCCR_ADSIZE                             \ Address size
$00070000 constant OCTOSPI2_WCCR_ABMODE                             \ Alternate-byte mode
$00080000 constant OCTOSPI2_WCCR_ABDTR                              \ Alternate bytes double transfer rate
$00300000 constant OCTOSPI2_WCCR_ABSIZE                             \ Alternate bytes size
$07000000 constant OCTOSPI2_WCCR_DMODE                              \ Data mode
$08000000 constant OCTOSPI2_WCCR_DDTR                               \ DDTR
$20000000 constant OCTOSPI2_WCCR_DQSE                               \ DQSE


\
\ @brief write timing configuration register
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$0000001f constant OCTOSPI2_WTCR_DCYC                               \ DCYC


\
\ @brief OCTOSPI write instruction register
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI2_WIR_INSTRUCTION                         \ Instruction Instruction to be sent to the external SPI device


\
\ @brief write alternate bytes register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI2_WABR_ALTERNATE                          \ Alternate bytes


\
\ @brief HyperBusTM latency configuration register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant OCTOSPI2_HLCR_LM                                 \ Latency mode
$00000002 constant OCTOSPI2_HLCR_WZL                                \ Write zero latency
$0000ff00 constant OCTOSPI2_HLCR_TACC                               \ Access time
$00ff0000 constant OCTOSPI2_HLCR_TRWR                               \ Read write recovery time


\
\ @brief OCTOSPI2 global interrupt
\
$5200a000 constant OCTOSPI2_CR    \ offset: 0x00 : control register
$5200a008 constant OCTOSPI2_DCR1  \ offset: 0x08 : device configuration register
$5200a00c constant OCTOSPI2_DCR2  \ offset: 0x0C : device configuration register 2
$5200a010 constant OCTOSPI2_DCR3  \ offset: 0x10 : device configuration register 3
$5200a014 constant OCTOSPI2_DCR4  \ offset: 0x14 : DCR4
$5200a020 constant OCTOSPI2_SR    \ offset: 0x20 : status register
$5200a024 constant OCTOSPI2_FCR   \ offset: 0x24 : flag clear register
$5200a040 constant OCTOSPI2_DLR   \ offset: 0x40 : data length register
$5200a048 constant OCTOSPI2_AR    \ offset: 0x48 : address register
$5200a050 constant OCTOSPI2_DR    \ offset: 0x50 : data register
$5200a080 constant OCTOSPI2_PSMKR  \ offset: 0x80 : polling status mask register
$5200a088 constant OCTOSPI2_PSMAR  \ offset: 0x88 : polling status match register
$5200a090 constant OCTOSPI2_PIR   \ offset: 0x90 : OCTOSPI polling interval register
$5200a100 constant OCTOSPI2_CCR   \ offset: 0x100 : polling interval register
$5200a108 constant OCTOSPI2_TCR   \ offset: 0x108 : communication configuration register
$5200a110 constant OCTOSPI2_IR    \ offset: 0x110 : timing configuration register
$5200a120 constant OCTOSPI2_ABR   \ offset: 0x120 : instruction register
$5200a130 constant OCTOSPI2_LPTR  \ offset: 0x130 : alternate bytes register
$5200a140 constant OCTOSPI2_WPCCR  \ offset: 0x140 : low-power timeout register
$5200a148 constant OCTOSPI2_WPTCR  \ offset: 0x148 : wrap timing configuration register
$5200a150 constant OCTOSPI2_WPIR  \ offset: 0x150 : wrap instruction register
$5200a160 constant OCTOSPI2_WPABR  \ offset: 0x160 : wrap alternate bytes register
$5200a180 constant OCTOSPI2_WCCR  \ offset: 0x180 : write communication configuration register
$5200a188 constant OCTOSPI2_WTCR  \ offset: 0x188 : write timing configuration register
$5200a190 constant OCTOSPI2_WIR   \ offset: 0x190 : OCTOSPI write instruction register
$5200a1a0 constant OCTOSPI2_WABR  \ offset: 0x1A0 : write alternate bytes register
$5200a200 constant OCTOSPI2_HLCR  \ offset: 0x200 : HyperBusTM latency configuration register

