\
\ @file quadspi.fs
\ @brief QuadSPI interface
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

$00000001 constant QUADSPI_CR_EN                                    \ Enable
$00000002 constant QUADSPI_CR_ABORT                                 \ Abort request
$00000004 constant QUADSPI_CR_DMAEN                                 \ DMA enable
$00000008 constant QUADSPI_CR_TCEN                                  \ Timeout counter enable
$00000010 constant QUADSPI_CR_SSHIFT                                \ Sample shift
$00000040 constant QUADSPI_CR_DFM                                   \ Dual-flash mode
$00000080 constant QUADSPI_CR_FSEL                                  \ Flash memory selection
$00000f00 constant QUADSPI_CR_FTHRES                                \ FIFO threshold level
$00010000 constant QUADSPI_CR_TEIE                                  \ Transfer error interrupt enable
$00020000 constant QUADSPI_CR_TCIE                                  \ Transfer complete interrupt enable
$00040000 constant QUADSPI_CR_FTIE                                  \ FIFO threshold interrupt enable
$00080000 constant QUADSPI_CR_SMIE                                  \ Status match interrupt enable
$00100000 constant QUADSPI_CR_TOIE                                  \ TimeOut interrupt enable
$00400000 constant QUADSPI_CR_APMS                                  \ Automatic poll mode stop
$00800000 constant QUADSPI_CR_PMM                                   \ Polling match mode
$ff000000 constant QUADSPI_CR_PRESCALER                             \ Clock prescaler


\
\ @brief device configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant QUADSPI_DCR_CKMODE                               \ Mode 0 / mode 3
$00000700 constant QUADSPI_DCR_CSHT                                 \ Chip select high time
$001f0000 constant QUADSPI_DCR_FSIZE                                \ FLASH memory size


\
\ @brief status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant QUADSPI_SR_TEF                                   \ Transfer error flag
$00000002 constant QUADSPI_SR_TCF                                   \ Transfer complete flag
$00000004 constant QUADSPI_SR_FTF                                   \ FIFO threshold flag
$00000008 constant QUADSPI_SR_SMF                                   \ Status match flag
$00000010 constant QUADSPI_SR_TOF                                   \ Timeout flag
$00000020 constant QUADSPI_SR_BUSY                                  \ Busy
$00001f00 constant QUADSPI_SR_FLEVEL                                \ FIFO level


\
\ @brief flag clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant QUADSPI_FCR_CTEF                                 \ Clear transfer error flag
$00000002 constant QUADSPI_FCR_CTCF                                 \ Clear transfer complete flag
$00000008 constant QUADSPI_FCR_CSMF                                 \ Clear status match flag
$00000010 constant QUADSPI_FCR_CTOF                                 \ Clear timeout flag


\
\ @brief data length register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant QUADSPI_DLR_DL                                   \ Data length


\
\ @brief communication configuration register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant QUADSPI_CCR_INSTRUCTION                          \ Instruction
$00000300 constant QUADSPI_CCR_IMODE                                \ Instruction mode
$00000c00 constant QUADSPI_CCR_ADMODE                               \ Address mode
$00003000 constant QUADSPI_CCR_ADSIZE                               \ Address size
$0000c000 constant QUADSPI_CCR_ABMODE                               \ Alternate bytes mode
$00030000 constant QUADSPI_CCR_ABSIZE                               \ Alternate bytes size
$007c0000 constant QUADSPI_CCR_DCYC                                 \ Number of dummy cycles
$03000000 constant QUADSPI_CCR_DMODE                                \ Data mode
$0c000000 constant QUADSPI_CCR_FMODE                                \ Functional mode
$10000000 constant QUADSPI_CCR_SIOO                                 \ Send instruction only once mode
$40000000 constant QUADSPI_CCR_DHHC                                 \ DDR hold
$80000000 constant QUADSPI_CCR_DDRM                                 \ Double data rate mode


\
\ @brief address register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant QUADSPI_AR_ADDRESS                               \ Address


\
\ @brief ABR
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant QUADSPI_ABR_ALTERNATE                            \ ALTERNATE


\
\ @brief data register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant QUADSPI_DR_DATA                                  \ Data


\
\ @brief polling status mask register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant QUADSPI_PSMKR_MASK                               \ Status mask


\
\ @brief polling status match register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant QUADSPI_PSMAR_MATCH                              \ Status match


\
\ @brief polling interval register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant QUADSPI_PIR_INTERVAL                             \ Polling interval


\
\ @brief low-power timeout register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant QUADSPI_LPTR_TIMEOUT                             \ Timeout period


\
\ @brief QuadSPI interface
\
$a0001000 constant QUADSPI_CR     \ offset: 0x00 : control register
$a0001004 constant QUADSPI_DCR    \ offset: 0x04 : device configuration register
$a0001008 constant QUADSPI_SR     \ offset: 0x08 : status register
$a000100c constant QUADSPI_FCR    \ offset: 0x0C : flag clear register
$a0001010 constant QUADSPI_DLR    \ offset: 0x10 : data length register
$a0001014 constant QUADSPI_CCR    \ offset: 0x14 : communication configuration register
$a0001018 constant QUADSPI_AR     \ offset: 0x18 : address register
$a000101c constant QUADSPI_ABR    \ offset: 0x1C : ABR
$a0001020 constant QUADSPI_DR     \ offset: 0x20 : data register
$a0001024 constant QUADSPI_PSMKR  \ offset: 0x24 : polling status mask register
$a0001028 constant QUADSPI_PSMAR  \ offset: 0x28 : polling status match register
$a000102c constant QUADSPI_PIR    \ offset: 0x2C : polling interval register
$a0001030 constant QUADSPI_LPTR   \ offset: 0x30 : low-power timeout register

