\
\ @file xspi1_s.fs
\ @brief Extended-SPI interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief XSPI control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant XSPI1_S_XSPI_CR_EN                               \ Enable
$00000002 constant XSPI1_S_XSPI_CR_ABORT                            \ Abort request
$00000004 constant XSPI1_S_XSPI_CR_DMAEN                            \ DMA enable
$00000008 constant XSPI1_S_XSPI_CR_TCEN                             \ Timeout counter enable
$00000040 constant XSPI1_S_XSPI_CR_DMM                              \ Dual-memory configuration
$00003f00 constant XSPI1_S_XSPI_CR_FTHRES                           \ FIFO threshold level
$00010000 constant XSPI1_S_XSPI_CR_TEIE                             \ Transfer error interrupt enable
$00020000 constant XSPI1_S_XSPI_CR_TCIE                             \ Transfer complete interrupt enable
$00040000 constant XSPI1_S_XSPI_CR_FTIE                             \ FIFO threshold interrupt enable
$00080000 constant XSPI1_S_XSPI_CR_SMIE                             \ Status match interrupt enable
$00100000 constant XSPI1_S_XSPI_CR_TOIE                             \ Timeout interrupt enable
$00400000 constant XSPI1_S_XSPI_CR_APMS                             \ Automatic status-polling mode stop
$00800000 constant XSPI1_S_XSPI_CR_PMM                              \ Polling match mode
$01000000 constant XSPI1_S_XSPI_CR_CSSEL                            \ chip select selection
$02000000 constant XSPI1_S_XSPI_CR_NOPREF                           \ no prefetch data
$04000000 constant XSPI1_S_XSPI_CR_NOPREF_AXI                       \ no prefetch for signaled AXI transactions
$30000000 constant XSPI1_S_XSPI_CR_FMODE                            \ Functional mode
$c0000000 constant XSPI1_S_XSPI_CR_MSEL                             \ Flash select


\
\ @brief XSPI device configuration register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant XSPI1_S_XSPI_DCR1_CKMODE                         \ clock mode 0
$00000002 constant XSPI1_S_XSPI_DCR1_FRCK                           \ Free running clock
$00003f00 constant XSPI1_S_XSPI_DCR1_CSHT                           \ Chip-select high time
$001f0000 constant XSPI1_S_XSPI_DCR1_DEVSIZE                        \ Device size
$00200000 constant XSPI1_S_XSPI_DCR1_EXTENDMEM                      \ extended memory support
$07000000 constant XSPI1_S_XSPI_DCR1_MTYP                           \ Memory type


\
\ @brief XSPI device configuration register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000ff constant XSPI1_S_XSPI_DCR2_PRESCALER                      \ Clock prescaler
$00070000 constant XSPI1_S_XSPI_DCR2_WRAPSIZE                       \ Wrap size


\
\ @brief XSPI device configuration register 3
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant XSPI1_S_XSPI_DCR3_MAXTRAN                        \ Maximum transfer
$001f0000 constant XSPI1_S_XSPI_DCR3_CSBOUND                        \ NCS boundary


\
\ @brief XSPI device configuration register 4
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_S_XSPI_DCR4_REFRESH                        \ Refresh rate


\
\ @brief XSPI status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant XSPI1_S_XSPI_SR_TEF                              \ Transfer error flag
$00000002 constant XSPI1_S_XSPI_SR_TCF                              \ Transfer complete flag
$00000004 constant XSPI1_S_XSPI_SR_FTF                              \ FIFO threshold flag
$00000008 constant XSPI1_S_XSPI_SR_SMF                              \ Status match flag
$00000010 constant XSPI1_S_XSPI_SR_TOF                              \ Timeout flag
$00000020 constant XSPI1_S_XSPI_SR_BUSY                             \ Busy
$00007f00 constant XSPI1_S_XSPI_SR_FLEVEL                           \ FIFO level


\
\ @brief XSPI flag clear register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant XSPI1_S_XSPI_FCR_CTEF                            \ Clear transfer error flag
$00000002 constant XSPI1_S_XSPI_FCR_CTCF                            \ Clear transfer complete flag
$00000008 constant XSPI1_S_XSPI_FCR_CSMF                            \ Clear status match flag
$00000010 constant XSPI1_S_XSPI_FCR_CTOF                            \ Clear timeout flag


\
\ @brief XSPI data length register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_S_XSPI_DLR_DL                              \ None


\
\ @brief XSPIaddress register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_S_XSPI_AR_ADDRESS                          \ Address


\
\ @brief XSPI data register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_S_XSPI_DR_DATA                             \ None


\
\ @brief XSPI polling status mask register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_S_XSPI_PSMKR_MASK                          \ Status mask


\
\ @brief XSPI polling status match register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_S_XSPI_PSMAR_MATCH                         \ None


\
\ @brief XSPI polling interval register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$0000ffff constant XSPI1_S_XSPI_PIR_INTERVAL                        \ None


\
\ @brief XSPI communication configuration register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000007 constant XSPI1_S_XSPI_CCR_IMODE                           \ Instruction mode
$00000008 constant XSPI1_S_XSPI_CCR_IDTR                            \ Instruction double transfer rate
$00000030 constant XSPI1_S_XSPI_CCR_ISIZE                           \ Instruction size
$00000700 constant XSPI1_S_XSPI_CCR_ADMODE                          \ Address mode
$00000800 constant XSPI1_S_XSPI_CCR_ADDTR                           \ Address double transfer rate
$00003000 constant XSPI1_S_XSPI_CCR_ADSIZE                          \ Address size
$00070000 constant XSPI1_S_XSPI_CCR_ABMODE                          \ Alternate-byte mode
$00080000 constant XSPI1_S_XSPI_CCR_ABDTR                           \ Alternate bytes double transfer rate
$00300000 constant XSPI1_S_XSPI_CCR_ABSIZE                          \ Alternate bytes size
$07000000 constant XSPI1_S_XSPI_CCR_DMODE                           \ Data mode
$08000000 constant XSPI1_S_XSPI_CCR_DDTR                            \ Data double transfer rate
$20000000 constant XSPI1_S_XSPI_CCR_DQSE                            \ DQS enable


\
\ @brief XSPI timing configuration register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$0000001f constant XSPI1_S_XSPI_TCR_DCYC                            \ Number of dummy cycles
$10000000 constant XSPI1_S_XSPI_TCR_DHQC                            \ Delay hold quarter cycle
$40000000 constant XSPI1_S_XSPI_TCR_SSHIFT                          \ Sample shift


\
\ @brief XSPI instruction register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_S_XSPI_IR_INSTRUCTION                      \ Instruction


\
\ @brief XSPI alternate bytes register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_S_XSPI_ABR_ALTERNATE                       \ None


\
\ @brief XSPI low-power timeout register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$0000ffff constant XSPI1_S_XSPI_LPTR_TIMEOUT                        \ None


\
\ @brief XSPI wrap communication configuration register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000007 constant XSPI1_S_XSPI_WPCCR_IMODE                         \ Instruction mode
$00000008 constant XSPI1_S_XSPI_WPCCR_IDTR                          \ Instruction double transfer rate
$00000030 constant XSPI1_S_XSPI_WPCCR_ISIZE                         \ Instruction size
$00000700 constant XSPI1_S_XSPI_WPCCR_ADMODE                        \ Address mode
$00000800 constant XSPI1_S_XSPI_WPCCR_ADDTR                         \ Address double transfer rate
$00003000 constant XSPI1_S_XSPI_WPCCR_ADSIZE                        \ Address size
$00070000 constant XSPI1_S_XSPI_WPCCR_ABMODE                        \ Alternate-byte mode
$00080000 constant XSPI1_S_XSPI_WPCCR_ABDTR                         \ Alternate bytes double transfer rate
$00300000 constant XSPI1_S_XSPI_WPCCR_ABSIZE                        \ Alternate bytes size
$07000000 constant XSPI1_S_XSPI_WPCCR_DMODE                         \ Data mode
$08000000 constant XSPI1_S_XSPI_WPCCR_DDTR                          \ Data double transfer rate
$20000000 constant XSPI1_S_XSPI_WPCCR_DQSE                          \ DQS enable


\
\ @brief XSPI wrap timing configuration register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$0000001f constant XSPI1_S_XSPI_WPTCR_DCYC                          \ Number of dummy cycles
$10000000 constant XSPI1_S_XSPI_WPTCR_DHQC                          \ Delay hold quarter cycle
$40000000 constant XSPI1_S_XSPI_WPTCR_SSHIFT                        \ Sample shift


\
\ @brief XSPI wrap instruction register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_S_XSPI_WPIR_INSTRUCTION                    \ None


\
\ @brief XSPI wrap alternate byte register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_S_XSPI_WPABR_ALTERNATE                     \ None


\
\ @brief XSPI write communication configuration register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$00000007 constant XSPI1_S_XSPI_WCCR_IMODE                          \ Instruction mode
$00000008 constant XSPI1_S_XSPI_WCCR_IDTR                           \ Instruction double transfer rate
$00000030 constant XSPI1_S_XSPI_WCCR_ISIZE                          \ Instruction size
$00000700 constant XSPI1_S_XSPI_WCCR_ADMODE                         \ Address mode
$00000800 constant XSPI1_S_XSPI_WCCR_ADDTR                          \ Address double transfer rate
$00003000 constant XSPI1_S_XSPI_WCCR_ADSIZE                         \ Address size
$00070000 constant XSPI1_S_XSPI_WCCR_ABMODE                         \ Alternate-byte mode
$00080000 constant XSPI1_S_XSPI_WCCR_ABDTR                          \ Alternate bytes double-transfer rate
$00300000 constant XSPI1_S_XSPI_WCCR_ABSIZE                         \ Alternate bytes size
$07000000 constant XSPI1_S_XSPI_WCCR_DMODE                          \ Data mode
$08000000 constant XSPI1_S_XSPI_WCCR_DDTR                           \ data double transfer rate
$20000000 constant XSPI1_S_XSPI_WCCR_DQSE                           \ DQS enable


\
\ @brief XSPI write timing configuration register
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$0000001f constant XSPI1_S_XSPI_WTCR_DCYC                           \ Number of dummy cycles


\
\ @brief XSPI write instruction register
\ Address offset: 0x190
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_S_XSPI_WIR_INSTRUCTION                     \ Instruction


\
\ @brief XSPI write alternate byte register
\ Address offset: 0x1A0
\ Reset value: 0x00000000
\

$00000000 constant XSPI1_S_XSPI_WABR_ALTERNATE                      \ None


\
\ @brief XSPI HyperBus latency configuration register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant XSPI1_S_XSPI_HLCR_LM                             \ Latency mode
$00000002 constant XSPI1_S_XSPI_HLCR_WZL                            \ Write zero latency
$0000ff00 constant XSPI1_S_XSPI_HLCR_TACC                           \ None
$00ff0000 constant XSPI1_S_XSPI_HLCR_TRWR                           \ Read write recovery time


\
\ @brief XSPI full-cycle calibration configuration
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$0000007f constant XSPI1_S_XSPI_CALFCR_FINE                         \ None
$001f0000 constant XSPI1_S_XSPI_CALFCR_COARSE                       \ None
$80000000 constant XSPI1_S_XSPI_CALFCR_CALMAX                       \ Max value


\
\ @brief XSPI DLL master calibration configuration
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$0000007f constant XSPI1_S_XSPI_CALMR_FINE                          \ None
$001f0000 constant XSPI1_S_XSPI_CALMR_COARSE                        \ None


\
\ @brief XSPI DLL slave output calibration configuration
\ Address offset: 0x220
\ Reset value: 0x00000000
\

$0000007f constant XSPI1_S_XSPI_CALSOR_FINE                         \ None
$001f0000 constant XSPI1_S_XSPI_CALSOR_COARSE                       \ None


\
\ @brief XSPI DLL slave input calibration configuration
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$0000007f constant XSPI1_S_XSPI_CALSIR_FINE                         \ None
$001f0000 constant XSPI1_S_XSPI_CALSIR_COARSE                       \ None


\
\ @brief Extended-SPI interface
\
$58025000 constant XSPI1_S_XSPI_CR  \ offset: 0x00 : XSPI control register
$58025008 constant XSPI1_S_XSPI_DCR1  \ offset: 0x08 : XSPI device configuration register 1
$5802500c constant XSPI1_S_XSPI_DCR2  \ offset: 0x0C : XSPI device configuration register 2
$58025010 constant XSPI1_S_XSPI_DCR3  \ offset: 0x10 : XSPI device configuration register 3
$58025014 constant XSPI1_S_XSPI_DCR4  \ offset: 0x14 : XSPI device configuration register 4
$58025020 constant XSPI1_S_XSPI_SR  \ offset: 0x20 : XSPI status register
$58025024 constant XSPI1_S_XSPI_FCR  \ offset: 0x24 : XSPI flag clear register
$58025040 constant XSPI1_S_XSPI_DLR  \ offset: 0x40 : XSPI data length register
$58025048 constant XSPI1_S_XSPI_AR  \ offset: 0x48 : XSPIaddress register
$58025050 constant XSPI1_S_XSPI_DR  \ offset: 0x50 : XSPI data register
$58025080 constant XSPI1_S_XSPI_PSMKR  \ offset: 0x80 : XSPI polling status mask register
$58025088 constant XSPI1_S_XSPI_PSMAR  \ offset: 0x88 : XSPI polling status match register
$58025090 constant XSPI1_S_XSPI_PIR  \ offset: 0x90 : XSPI polling interval register
$58025100 constant XSPI1_S_XSPI_CCR  \ offset: 0x100 : XSPI communication configuration register
$58025108 constant XSPI1_S_XSPI_TCR  \ offset: 0x108 : XSPI timing configuration register
$58025110 constant XSPI1_S_XSPI_IR  \ offset: 0x110 : XSPI instruction register
$58025120 constant XSPI1_S_XSPI_ABR  \ offset: 0x120 : XSPI alternate bytes register
$58025130 constant XSPI1_S_XSPI_LPTR  \ offset: 0x130 : XSPI low-power timeout register
$58025140 constant XSPI1_S_XSPI_WPCCR  \ offset: 0x140 : XSPI wrap communication configuration register
$58025148 constant XSPI1_S_XSPI_WPTCR  \ offset: 0x148 : XSPI wrap timing configuration register
$58025150 constant XSPI1_S_XSPI_WPIR  \ offset: 0x150 : XSPI wrap instruction register
$58025160 constant XSPI1_S_XSPI_WPABR  \ offset: 0x160 : XSPI wrap alternate byte register
$58025180 constant XSPI1_S_XSPI_WCCR  \ offset: 0x180 : XSPI write communication configuration register
$58025188 constant XSPI1_S_XSPI_WTCR  \ offset: 0x188 : XSPI write timing configuration register
$58025190 constant XSPI1_S_XSPI_WIR  \ offset: 0x190 : XSPI write instruction register
$580251a0 constant XSPI1_S_XSPI_WABR  \ offset: 0x1A0 : XSPI write alternate byte register
$58025200 constant XSPI1_S_XSPI_HLCR  \ offset: 0x200 : XSPI HyperBus latency configuration register
$58025210 constant XSPI1_S_XSPI_CALFCR  \ offset: 0x210 : XSPI full-cycle calibration configuration
$58025218 constant XSPI1_S_XSPI_CALMR  \ offset: 0x218 : XSPI DLL master calibration configuration
$58025220 constant XSPI1_S_XSPI_CALSOR  \ offset: 0x220 : XSPI DLL slave output calibration configuration
$58025228 constant XSPI1_S_XSPI_CALSIR  \ offset: 0x228 : XSPI DLL slave input calibration configuration

