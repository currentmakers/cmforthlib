\
\ @file spdifrx.fs
\ @brief SPDIFRX
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant SPDIFRX_SPDIFRX_CR_SPDIFRXEN                     \ SPDIFRXEN
$00000004 constant SPDIFRX_SPDIFRX_CR_RXDMAEN                       \ RXDMAEN
$00000008 constant SPDIFRX_SPDIFRX_CR_RXSTEO                        \ RXSTEO
$00000030 constant SPDIFRX_SPDIFRX_CR_DRFMT                         \ DRFMT
$00000040 constant SPDIFRX_SPDIFRX_CR_PMSK                          \ PMSK
$00000080 constant SPDIFRX_SPDIFRX_CR_VMSK                          \ VMSK
$00000100 constant SPDIFRX_SPDIFRX_CR_CUMSK                         \ CUMSK
$00000200 constant SPDIFRX_SPDIFRX_CR_PTMSK                         \ PTMSK
$00000400 constant SPDIFRX_SPDIFRX_CR_CBDMAEN                       \ CBDMAEN
$00000800 constant SPDIFRX_SPDIFRX_CR_CHSEL                         \ CHSEL
$00003000 constant SPDIFRX_SPDIFRX_CR_NBTR                          \ NBTR
$00004000 constant SPDIFRX_SPDIFRX_CR_WFA                           \ WFA
$00070000 constant SPDIFRX_SPDIFRX_CR_INSEL                         \ INSEL
$00100000 constant SPDIFRX_SPDIFRX_CR_CKSEN                         \ CKSEN
$00200000 constant SPDIFRX_SPDIFRX_CR_CKSBKPEN                      \ CKSBKPEN


\
\ @brief Interrupt mask register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SPDIFRX_SPDIFRX_IMR_RXNEIE                       \ RXNEIE
$00000002 constant SPDIFRX_SPDIFRX_IMR_CSRNEIE                      \ CSRNEIE
$00000004 constant SPDIFRX_SPDIFRX_IMR_PERRIE                       \ PERRIE
$00000008 constant SPDIFRX_SPDIFRX_IMR_OVRIE                        \ OVRIE
$00000010 constant SPDIFRX_SPDIFRX_IMR_SBLKIE                       \ SBLKIE
$00000020 constant SPDIFRX_SPDIFRX_IMR_SYNCDIE                      \ SYNCDIE
$00000040 constant SPDIFRX_SPDIFRX_IMR_IFEIE                        \ IFEIE


\
\ @brief Status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SPDIFRX_SPDIFRX_SR_RXNE                          \ RXNE
$00000002 constant SPDIFRX_SPDIFRX_SR_CSRNE                         \ CSRNE
$00000004 constant SPDIFRX_SPDIFRX_SR_PERR                          \ PERR
$00000008 constant SPDIFRX_SPDIFRX_SR_OVR                           \ OVR
$00000010 constant SPDIFRX_SPDIFRX_SR_SBD                           \ SBD
$00000020 constant SPDIFRX_SPDIFRX_SR_SYNCD                         \ SYNCD
$00000040 constant SPDIFRX_SPDIFRX_SR_FERR                          \ FERR
$00000080 constant SPDIFRX_SPDIFRX_SR_SERR                          \ SERR
$00000100 constant SPDIFRX_SPDIFRX_SR_TERR                          \ TERR
$7fff0000 constant SPDIFRX_SPDIFRX_SR_WIDTH5                        \ WIDTH5


\
\ @brief Interrupt flag clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000004 constant SPDIFRX_SPDIFRX_IFCR_PERRCF                      \ PERRCF
$00000008 constant SPDIFRX_SPDIFRX_IFCR_OVRCF                       \ OVRCF
$00000010 constant SPDIFRX_SPDIFRX_IFCR_SBDCF                       \ SBDCF
$00000020 constant SPDIFRX_SPDIFRX_IFCR_SYNCDCF                     \ SYNCDCF


\
\ @brief This register can take 3 different formats according to DRFMT. Here is the format when DRFMT = 00:
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00ffffff constant SPDIFRX_SPDIFRX_FMT0_DR_DR                       \ DR
$01000000 constant SPDIFRX_SPDIFRX_FMT0_DR_PE                       \ PE
$02000000 constant SPDIFRX_SPDIFRX_FMT0_DR_V                        \ V
$04000000 constant SPDIFRX_SPDIFRX_FMT0_DR_U                        \ U
$08000000 constant SPDIFRX_SPDIFRX_FMT0_DR_C                        \ C
$30000000 constant SPDIFRX_SPDIFRX_FMT0_DR_PT                       \ PT


\
\ @brief Channel status register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant SPDIFRX_SPDIFRX_CSR_USR                          \ USR
$00ff0000 constant SPDIFRX_SPDIFRX_CSR_CS                           \ CS
$01000000 constant SPDIFRX_SPDIFRX_CSR_SOB                          \ SOB


\
\ @brief Debug information register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00001fff constant SPDIFRX_SPDIFRX_DIR_THI                          \ THI
$1fff0000 constant SPDIFRX_SPDIFRX_DIR_TLO                          \ TLO


\
\ @brief SPDIFRX version register
\ Address offset: 0x3F4
\ Reset value: 0x00000012
\

$0000000f constant SPDIFRX_SPDIFRX_VERR_MINREV                      \ MINREV
$000000f0 constant SPDIFRX_SPDIFRX_VERR_MAJREV                      \ MAJREV


\
\ @brief SPDIFRX identification register
\ Address offset: 0x3F8
\ Reset value: 0x00130041
\

$00000000 constant SPDIFRX_SPDIFRX_IPIDR_ID                         \ ID


\
\ @brief SPDIFRX size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant SPDIFRX_SPDIFRX_SIDR_SID                         \ SID


\
\ @brief SPDIFRX
\
$4000d000 constant SPDIFRX_SPDIFRX_CR  \ offset: 0x00 : Control register
$4000d004 constant SPDIFRX_SPDIFRX_IMR  \ offset: 0x04 : Interrupt mask register
$4000d008 constant SPDIFRX_SPDIFRX_SR  \ offset: 0x08 : Status register
$4000d00c constant SPDIFRX_SPDIFRX_IFCR  \ offset: 0x0C : Interrupt flag clear register
$4000d010 constant SPDIFRX_SPDIFRX_FMT0_DR  \ offset: 0x10 : This register can take 3 different formats according to DRFMT. Here is the format when DRFMT = 00:
$4000d014 constant SPDIFRX_SPDIFRX_CSR  \ offset: 0x14 : Channel status register
$4000d018 constant SPDIFRX_SPDIFRX_DIR  \ offset: 0x18 : Debug information register
$4000d3f4 constant SPDIFRX_SPDIFRX_VERR  \ offset: 0x3F4 : SPDIFRX version register
$4000d3f8 constant SPDIFRX_SPDIFRX_IPIDR  \ offset: 0x3F8 : SPDIFRX identification register
$4000d3fc constant SPDIFRX_SPDIFRX_SIDR  \ offset: 0x3FC : SPDIFRX size identification register

