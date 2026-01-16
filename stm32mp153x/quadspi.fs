\
\ @file quadspi.fs
\ @brief QUADSPI1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief QUADSPI control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant QUADSPI_QUADSPI_CR_EN                            \ EN
$00000002 constant QUADSPI_QUADSPI_CR_ABORT                         \ ABORT
$00000004 constant QUADSPI_QUADSPI_CR_DMAEN                         \ DMAEN
$00000008 constant QUADSPI_QUADSPI_CR_TCEN                          \ TCEN
$00000010 constant QUADSPI_QUADSPI_CR_SSHIFT                        \ SSHIFT
$00000040 constant QUADSPI_QUADSPI_CR_DFM                           \ DFM
$00000080 constant QUADSPI_QUADSPI_CR_FSEL                          \ FSEL
$00000f00 constant QUADSPI_QUADSPI_CR_FTHRES                        \ FTHRES
$00010000 constant QUADSPI_QUADSPI_CR_TEIE                          \ TEIE
$00020000 constant QUADSPI_QUADSPI_CR_TCIE                          \ TCIE
$00040000 constant QUADSPI_QUADSPI_CR_FTIE                          \ FTIE
$00080000 constant QUADSPI_QUADSPI_CR_SMIE                          \ SMIE
$00100000 constant QUADSPI_QUADSPI_CR_TOIE                          \ TOIE
$00400000 constant QUADSPI_QUADSPI_CR_APMS                          \ APMS
$00800000 constant QUADSPI_QUADSPI_CR_PMM                           \ PMM
$ff000000 constant QUADSPI_QUADSPI_CR_PRESCALER                     \ PRESCALER


\
\ @brief QUADSPI device configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant QUADSPI_QUADSPI_DCR_CKMODE                       \ CKMODE
$00000700 constant QUADSPI_QUADSPI_DCR_CSHT                         \ CSHT
$001f0000 constant QUADSPI_QUADSPI_DCR_FSIZE                        \ FSIZE


\
\ @brief QUADSPI status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant QUADSPI_QUADSPI_SR_TEF                           \ TEF
$00000002 constant QUADSPI_QUADSPI_SR_TCF                           \ TCF
$00000004 constant QUADSPI_QUADSPI_SR_FTF                           \ FTF
$00000008 constant QUADSPI_QUADSPI_SR_SMF                           \ SMF
$00000010 constant QUADSPI_QUADSPI_SR_TOF                           \ TOF
$00000020 constant QUADSPI_QUADSPI_SR_BUSY                          \ BUSY
$00001f00 constant QUADSPI_QUADSPI_SR_FLEVEL                        \ FLEVEL


\
\ @brief QUADSPI flag clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant QUADSPI_QUADSPI_FCR_CTEF                         \ CTEF
$00000002 constant QUADSPI_QUADSPI_FCR_CTCF                         \ CTCF
$00000008 constant QUADSPI_QUADSPI_FCR_CSMF                         \ CSMF
$00000010 constant QUADSPI_QUADSPI_FCR_CTOF                         \ CTOF


\
\ @brief QUADSPI data length register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant QUADSPI_QUADSPI_DLR_DL                           \ DL


\
\ @brief QUADSPI communication configuration register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant QUADSPI_QUADSPI_CCR_INSTRUCTION                  \ INSTRUCTION
$00000300 constant QUADSPI_QUADSPI_CCR_IMODE                        \ IMODE
$00000c00 constant QUADSPI_QUADSPI_CCR_ADMODE                       \ ADMODE
$00003000 constant QUADSPI_QUADSPI_CCR_ADSIZE                       \ ADSIZE
$0000c000 constant QUADSPI_QUADSPI_CCR_ABMODE                       \ ABMODE
$00030000 constant QUADSPI_QUADSPI_CCR_ABSIZE                       \ ABSIZE
$007c0000 constant QUADSPI_QUADSPI_CCR_DCYC                         \ DCYC
$03000000 constant QUADSPI_QUADSPI_CCR_DMODE                        \ DMODE
$0c000000 constant QUADSPI_QUADSPI_CCR_FMODE                        \ FMODE
$10000000 constant QUADSPI_QUADSPI_CCR_SIOO                         \ SIOO
$20000000 constant QUADSPI_QUADSPI_CCR_FRCM                         \ FRCM
$40000000 constant QUADSPI_QUADSPI_CCR_DHHC                         \ DHHC
$80000000 constant QUADSPI_QUADSPI_CCR_DDRM                         \ DDRM


\
\ @brief QUADSPI address register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000000 constant QUADSPI_QUADSPI_AR_ADDRESS                       \ ADDRESS


\
\ @brief QUADSPI alternate bytes registers
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000000 constant QUADSPI_QUADSPI_ABR_ALTERNATE                    \ ALTERNATE


\
\ @brief QUADSPI data register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant QUADSPI_QUADSPI_DR_DATA                          \ DATA


\
\ @brief QUADSPI polling status mask register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant QUADSPI_QUADSPI_PSMKR_MASK                       \ MASK


\
\ @brief QUADSPI polling status match register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant QUADSPI_QUADSPI_PSMAR_MATCH                      \ MATCH


\
\ @brief QUADSPI polling interval register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant QUADSPI_QUADSPI_PIR_INTERVAL                     \ INTERVAL


\
\ @brief QUADSPI low-power timeout register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant QUADSPI_QUADSPI_LPTR_TIMEOUT                     \ TIMEOUT


\
\ @brief QUADSPI HW configuration register
\ Address offset: 0x3F0
\ Reset value: 0x0000B058
\

$0000000f constant QUADSPI_QUADSPI_HWCFGR_FIFOSIZE                  \ FIFOSIZE
$000000f0 constant QUADSPI_QUADSPI_HWCFGR_FIFOPTR                   \ FIFOPTR
$00000f00 constant QUADSPI_QUADSPI_HWCFGR_PRESCVAL                  \ PRESCVAL
$0000f000 constant QUADSPI_QUADSPI_HWCFGR_IDLENGTH                  \ IDLENGTH


\
\ @brief QUADSPI version register
\ Address offset: 0x3F4
\ Reset value: 0x00000041
\

$0000000f constant QUADSPI_QUADSPI_VERR_MINREV                      \ MINREV
$000000f0 constant QUADSPI_QUADSPI_VERR_MAJREV                      \ MAJREV


\
\ @brief QUADSPI identification register
\ Address offset: 0x3F8
\ Reset value: 0x00140031
\

$00000000 constant QUADSPI_QUADSPI_IPIDR_ID                         \ ID


\
\ @brief QUADSPI size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant QUADSPI_QUADSPI_SIDR_SID                         \ SID


\
\ @brief QUADSPI1
\
$58003000 constant QUADSPI_QUADSPI_CR  \ offset: 0x00 : QUADSPI control register
$58003004 constant QUADSPI_QUADSPI_DCR  \ offset: 0x04 : QUADSPI device configuration register
$58003008 constant QUADSPI_QUADSPI_SR  \ offset: 0x08 : QUADSPI status register
$5800300c constant QUADSPI_QUADSPI_FCR  \ offset: 0x0C : QUADSPI flag clear register
$58003010 constant QUADSPI_QUADSPI_DLR  \ offset: 0x10 : QUADSPI data length register
$58003014 constant QUADSPI_QUADSPI_CCR  \ offset: 0x14 : QUADSPI communication configuration register
$58003018 constant QUADSPI_QUADSPI_AR  \ offset: 0x18 : QUADSPI address register
$5800301c constant QUADSPI_QUADSPI_ABR  \ offset: 0x1C : QUADSPI alternate bytes registers
$58003020 constant QUADSPI_QUADSPI_DR  \ offset: 0x20 : QUADSPI data register
$58003024 constant QUADSPI_QUADSPI_PSMKR  \ offset: 0x24 : QUADSPI polling status mask register
$58003028 constant QUADSPI_QUADSPI_PSMAR  \ offset: 0x28 : QUADSPI polling status match register
$5800302c constant QUADSPI_QUADSPI_PIR  \ offset: 0x2C : QUADSPI polling interval register
$58003030 constant QUADSPI_QUADSPI_LPTR  \ offset: 0x30 : QUADSPI low-power timeout register
$580033f0 constant QUADSPI_QUADSPI_HWCFGR  \ offset: 0x3F0 : QUADSPI HW configuration register
$580033f4 constant QUADSPI_QUADSPI_VERR  \ offset: 0x3F4 : QUADSPI version register
$580033f8 constant QUADSPI_QUADSPI_IPIDR  \ offset: 0x3F8 : QUADSPI identification register
$580033fc constant QUADSPI_QUADSPI_SIDR  \ offset: 0x3FC : QUADSPI size identification register

