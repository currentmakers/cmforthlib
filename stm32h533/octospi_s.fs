\
\ @file octospi_s.fs
\ @brief OCTOSPI register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief OCTOSPI control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant OCTOSPI_S_OCTOSPI_CR_EN                          \ Enable
$00000002 constant OCTOSPI_S_OCTOSPI_CR_ABORT                       \ Abort request
$00000004 constant OCTOSPI_S_OCTOSPI_CR_DMAEN                       \ DMA enable
$00000008 constant OCTOSPI_S_OCTOSPI_CR_TCEN                        \ Timeout counter enable
$00000040 constant OCTOSPI_S_OCTOSPI_CR_DMM                         \ Dual-memory configuration
$00000080 constant OCTOSPI_S_OCTOSPI_CR_MSEL                        \ External memory select
$00001f00 constant OCTOSPI_S_OCTOSPI_CR_FTHRES                      \ FIFO threshold level
$00010000 constant OCTOSPI_S_OCTOSPI_CR_TEIE                        \ Transfer error interrupt enable
$00020000 constant OCTOSPI_S_OCTOSPI_CR_TCIE                        \ Transfer complete interrupt enable
$00040000 constant OCTOSPI_S_OCTOSPI_CR_FTIE                        \ FIFO threshold interrupt enable
$00080000 constant OCTOSPI_S_OCTOSPI_CR_SMIE                        \ Status-match interrupt enable
$00100000 constant OCTOSPI_S_OCTOSPI_CR_TOIE                        \ Timeout interrupt enable
$00400000 constant OCTOSPI_S_OCTOSPI_CR_APMS                        \ Automatic status-polling mode stop
$00800000 constant OCTOSPI_S_OCTOSPI_CR_PMM                         \ Polling match mode
$30000000 constant OCTOSPI_S_OCTOSPI_CR_FMODE                       \ Functional mode


\
\ @brief OCTOSPI device configuration register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant OCTOSPI_S_OCTOSPI_DCR1_CKMODE                    \ Clock mode 0/mode 3
$00000002 constant OCTOSPI_S_OCTOSPI_DCR1_FRCK                      \ Free running clock
$00000008 constant OCTOSPI_S_OCTOSPI_DCR1_DLYBYP                    \ Delay block bypass
$00003f00 constant OCTOSPI_S_OCTOSPI_DCR1_CSHT                      \ Chip-select high time
$001f0000 constant OCTOSPI_S_OCTOSPI_DCR1_DEVSIZE                   \ Device size
$07000000 constant OCTOSPI_S_OCTOSPI_DCR1_MTYP                      \ Memory type


\
\ @brief OCTOSPI device configuration register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000ff constant OCTOSPI_S_OCTOSPI_DCR2_PRESCALER                 \ Clock prescaler
$00070000 constant OCTOSPI_S_OCTOSPI_DCR2_WRAPSIZE                  \ Wrap size


\
\ @brief OCTOSPI device configuration register 3
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$001f0000 constant OCTOSPI_S_OCTOSPI_DCR3_CSBOUND                   \ NCS boundary


\
\ @brief OCTOSPI device configuration register 4
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI_S_OCTOSPI_DCR4_REFRESH                   \ Refresh rate


\
\ @brief OCTOSPI status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant OCTOSPI_S_OCTOSPI_SR_TEF                         \ Transfer error flag
$00000002 constant OCTOSPI_S_OCTOSPI_SR_TCF                         \ Transfer complete flag
$00000004 constant OCTOSPI_S_OCTOSPI_SR_FTF                         \ FIFO threshold flag
$00000008 constant OCTOSPI_S_OCTOSPI_SR_SMF                         \ Status match flag
$00000010 constant OCTOSPI_S_OCTOSPI_SR_TOF                         \ Timeout flag
$00000020 constant OCTOSPI_S_OCTOSPI_SR_BUSY                        \ Busy
$00003f00 constant OCTOSPI_S_OCTOSPI_SR_FLEVEL                      \ FIFO level


\
\ @brief OCTOSPI flag clear register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant OCTOSPI_S_OCTOSPI_FCR_CTEF                       \ Clear transfer error flag
$00000002 constant OCTOSPI_S_OCTOSPI_FCR_CTCF                       \ Clear transfer complete flag
$00000008 constant OCTOSPI_S_OCTOSPI_FCR_CSMF                       \ Clear status match flag
$00000010 constant OCTOSPI_S_OCTOSPI_FCR_CTOF                       \ Clear timeout flag


\
\ @brief OCTOSPI data length register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI_S_OCTOSPI_DLR_DL                         \ Data length


\
\ @brief OCTOSPI address register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI_S_OCTOSPI_AR_ADDRESS                     \ Address


\
\ @brief OCTOSPI data register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI_S_OCTOSPI_DR_DATA                        \ Data


\
\ @brief OCTOSPI polling status mask register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI_S_OCTOSPI_PSMKR_MASK                     \ Status mask


\
\ @brief OCTOSPI polling status match register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI_S_OCTOSPI_PSMAR_MATCH                    \ Status match


\
\ @brief OCTOSPI polling interval register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$0000ffff constant OCTOSPI_S_OCTOSPI_PIR_INTERVAL                   \ Polling interval


\
\ @brief OCTOSPI communication configuration register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000007 constant OCTOSPI_S_OCTOSPI_CCR_IMODE                      \ Instruction mode
$00000008 constant OCTOSPI_S_OCTOSPI_CCR_IDTR                       \ Instruction double transfer rate
$00000030 constant OCTOSPI_S_OCTOSPI_CCR_ISIZE                      \ Instruction size
$00000700 constant OCTOSPI_S_OCTOSPI_CCR_ADMODE                     \ Address mode
$00000800 constant OCTOSPI_S_OCTOSPI_CCR_ADDTR                      \ Address double transfer rate
$00003000 constant OCTOSPI_S_OCTOSPI_CCR_ADSIZE                     \ Address size
$00070000 constant OCTOSPI_S_OCTOSPI_CCR_ABMODE                     \ Alternate-byte mode
$00080000 constant OCTOSPI_S_OCTOSPI_CCR_ABDTR                      \ Alternate- byte double transfer rate
$00300000 constant OCTOSPI_S_OCTOSPI_CCR_ABSIZE                     \ Alternate-byte size
$07000000 constant OCTOSPI_S_OCTOSPI_CCR_DMODE                      \ Data mode
$08000000 constant OCTOSPI_S_OCTOSPI_CCR_DDTR                       \ Data double transfer rate
$20000000 constant OCTOSPI_S_OCTOSPI_CCR_DQSE                       \ DQS enable


\
\ @brief OCTOSPI timing configuration register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$0000001f constant OCTOSPI_S_OCTOSPI_TCR_DCYC                       \ Number of dummy cycles
$10000000 constant OCTOSPI_S_OCTOSPI_TCR_DHQC                       \ Delay hold quarter cycle
$40000000 constant OCTOSPI_S_OCTOSPI_TCR_SSHIFT                     \ Sample shift


\
\ @brief OCTOSPI instruction register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI_S_OCTOSPI_IR_INSTRUCTION                 \ Instruction


\
\ @brief OCTOSPI alternate bytes register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI_S_OCTOSPI_ABR_ALTERNATE                  \ Alternate bytes


\
\ @brief OCTOSPI low-power timeout register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$0000ffff constant OCTOSPI_S_OCTOSPI_LPTR_TIMEOUT                   \ Timeout period


\
\ @brief OCTOSPI wrap communication configuration register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000007 constant OCTOSPI_S_OCTOSPI_WPCCR_IMODE                    \ Instruction mode
$00000008 constant OCTOSPI_S_OCTOSPI_WPCCR_IDTR                     \ Instruction double transfer rate
$00000030 constant OCTOSPI_S_OCTOSPI_WPCCR_ISIZE                    \ Instruction size
$00000700 constant OCTOSPI_S_OCTOSPI_WPCCR_ADMODE                   \ Address mode
$00000800 constant OCTOSPI_S_OCTOSPI_WPCCR_ADDTR                    \ Address double transfer rate
$00003000 constant OCTOSPI_S_OCTOSPI_WPCCR_ADSIZE                   \ Address size
$00070000 constant OCTOSPI_S_OCTOSPI_WPCCR_ABMODE                   \ Alternate-byte mode
$00080000 constant OCTOSPI_S_OCTOSPI_WPCCR_ABDTR                    \ Alternate-byte double transfer rate
$00300000 constant OCTOSPI_S_OCTOSPI_WPCCR_ABSIZE                   \ Alternate-byte size
$07000000 constant OCTOSPI_S_OCTOSPI_WPCCR_DMODE                    \ Data mode
$08000000 constant OCTOSPI_S_OCTOSPI_WPCCR_DDTR                     \ Data double transfer rate
$20000000 constant OCTOSPI_S_OCTOSPI_WPCCR_DQSE                     \ DQS enable


\
\ @brief OCTOSPI wrap timing configuration register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$0000001f constant OCTOSPI_S_OCTOSPI_WPTCR_DCYC                     \ Number of dummy cycles
$10000000 constant OCTOSPI_S_OCTOSPI_WPTCR_DHQC                     \ Delay hold quarter cycle
$40000000 constant OCTOSPI_S_OCTOSPI_WPTCR_SSHIFT                   \ Sample shift


\
\ @brief OCTOSPI wrap instruction register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI_S_OCTOSPI_WPIR_INSTRUCTION               \ Instruction


\
\ @brief OCTOSPI wrap alternate bytes register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI_S_OCTOSPI_WPABR_ALTERNATE                \ Alternate bytes


\
\ @brief OCTOSPI write communication configuration register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000007 constant OCTOSPI_S_OCTOSPI_WCCR_IMODE                     \ Instruction mode
$00000008 constant OCTOSPI_S_OCTOSPI_WCCR_IDTR                      \ Instruction double transfer rate
$00000030 constant OCTOSPI_S_OCTOSPI_WCCR_ISIZE                     \ Instruction size
$00000700 constant OCTOSPI_S_OCTOSPI_WCCR_ADMODE                    \ Address mode
$00000800 constant OCTOSPI_S_OCTOSPI_WCCR_ADDTR                     \ Address double transfer rate
$00003000 constant OCTOSPI_S_OCTOSPI_WCCR_ADSIZE                    \ Address size
$00070000 constant OCTOSPI_S_OCTOSPI_WCCR_ABMODE                    \ Alternate-byte mode
$00080000 constant OCTOSPI_S_OCTOSPI_WCCR_ABDTR                     \ Alternate bytes double transfer rate
$00300000 constant OCTOSPI_S_OCTOSPI_WCCR_ABSIZE                    \ Alternate-byte size
$07000000 constant OCTOSPI_S_OCTOSPI_WCCR_DMODE                     \ Data mode
$08000000 constant OCTOSPI_S_OCTOSPI_WCCR_DDTR                      \ data double transfer rate
$20000000 constant OCTOSPI_S_OCTOSPI_WCCR_DQSE                      \ DQS enable


\
\ @brief OCTOSPI write timing configuration register
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$0000001f constant OCTOSPI_S_OCTOSPI_WTCR_DCYC                      \ Number of dummy cycles


\
\ @brief OCTOSPI write instruction register
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI_S_OCTOSPI_WIR_INSTRUCTION                \ Instruction


\
\ @brief OCTOSPI write alternate bytes register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant OCTOSPI_S_OCTOSPI_WABR_ALTERNATE                 \ Alternate bytes


\
\ @brief OCTOSPI HyperBus latency configuration register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant OCTOSPI_S_OCTOSPI_HLCR_LM                        \ Latency mode
$00000002 constant OCTOSPI_S_OCTOSPI_HLCR_WZL                       \ Write zero latency
$0000ff00 constant OCTOSPI_S_OCTOSPI_HLCR_TACC                      \ Access time
$00ff0000 constant OCTOSPI_S_OCTOSPI_HLCR_TRWR                      \ Read-write minimum recovery time


\
\ @brief OCTOSPI register block
\
$57001400 constant OCTOSPI_S_OCTOSPI_CR  \ offset: 0x00 : OCTOSPI control register
$57001408 constant OCTOSPI_S_OCTOSPI_DCR1  \ offset: 0x08 : OCTOSPI device configuration register 1
$5700140c constant OCTOSPI_S_OCTOSPI_DCR2  \ offset: 0x0C : OCTOSPI device configuration register 2
$57001410 constant OCTOSPI_S_OCTOSPI_DCR3  \ offset: 0x10 : OCTOSPI device configuration register 3
$57001414 constant OCTOSPI_S_OCTOSPI_DCR4  \ offset: 0x14 : OCTOSPI device configuration register 4
$57001420 constant OCTOSPI_S_OCTOSPI_SR  \ offset: 0x20 : OCTOSPI status register
$57001424 constant OCTOSPI_S_OCTOSPI_FCR  \ offset: 0x24 : OCTOSPI flag clear register
$57001440 constant OCTOSPI_S_OCTOSPI_DLR  \ offset: 0x40 : OCTOSPI data length register
$57001448 constant OCTOSPI_S_OCTOSPI_AR  \ offset: 0x48 : OCTOSPI address register
$57001450 constant OCTOSPI_S_OCTOSPI_DR  \ offset: 0x50 : OCTOSPI data register
$57001480 constant OCTOSPI_S_OCTOSPI_PSMKR  \ offset: 0x80 : OCTOSPI polling status mask register
$57001488 constant OCTOSPI_S_OCTOSPI_PSMAR  \ offset: 0x88 : OCTOSPI polling status match register
$57001490 constant OCTOSPI_S_OCTOSPI_PIR  \ offset: 0x90 : OCTOSPI polling interval register
$57001500 constant OCTOSPI_S_OCTOSPI_CCR  \ offset: 0x100 : OCTOSPI communication configuration register
$57001508 constant OCTOSPI_S_OCTOSPI_TCR  \ offset: 0x108 : OCTOSPI timing configuration register
$57001510 constant OCTOSPI_S_OCTOSPI_IR  \ offset: 0x110 : OCTOSPI instruction register
$57001520 constant OCTOSPI_S_OCTOSPI_ABR  \ offset: 0x120 : OCTOSPI alternate bytes register
$57001530 constant OCTOSPI_S_OCTOSPI_LPTR  \ offset: 0x130 : OCTOSPI low-power timeout register
$57001540 constant OCTOSPI_S_OCTOSPI_WPCCR  \ offset: 0x140 : OCTOSPI wrap communication configuration register
$57001548 constant OCTOSPI_S_OCTOSPI_WPTCR  \ offset: 0x148 : OCTOSPI wrap timing configuration register
$57001550 constant OCTOSPI_S_OCTOSPI_WPIR  \ offset: 0x150 : OCTOSPI wrap instruction register
$57001560 constant OCTOSPI_S_OCTOSPI_WPABR  \ offset: 0x160 : OCTOSPI wrap alternate bytes register
$57001580 constant OCTOSPI_S_OCTOSPI_WCCR  \ offset: 0x180 : OCTOSPI write communication configuration register
$57001588 constant OCTOSPI_S_OCTOSPI_WTCR  \ offset: 0x188 : OCTOSPI write timing configuration register
$57001590 constant OCTOSPI_S_OCTOSPI_WIR  \ offset: 0x190 : OCTOSPI write instruction register
$570015a0 constant OCTOSPI_S_OCTOSPI_WABR  \ offset: 0x1A0 : OCTOSPI write alternate bytes register
$57001600 constant OCTOSPI_S_OCTOSPI_HLCR  \ offset: 0x200 : OCTOSPI HyperBus latency configuration register

