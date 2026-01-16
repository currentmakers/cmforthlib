\
\ @file pka.fs
\ @brief PKA
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

$00000001 constant PKA_CR_EN                                        \ Peripheral Enable
$00000002 constant PKA_CR_START                                     \ Start the operation
$00000004 constant PKA_CR_SECLVL                                    \ Security Enable
$00003f00 constant PKA_CR_MODE                                      \ PKA Operation Mode
$00020000 constant PKA_CR_PROCENDIE                                 \ End of operation interrupt enable
$00080000 constant PKA_CR_RAMERRIE                                  \ RAM error interrupt enable
$00100000 constant PKA_CR_ADDRERRIE                                 \ Address error interrupt enable


\
\ @brief PKA status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00010000 constant PKA_SR_BUSY                                      \ PKA Operation in progress
$00020000 constant PKA_SR_PROCENDF                                  \ PKA End of Operation flag
$00080000 constant PKA_SR_RAMERRF                                   \ RAM error flag
$00100000 constant PKA_SR_ADDRERRF                                  \ Address error flag


\
\ @brief PKA clear flag register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00020000 constant PKA_CLRFR_PROCENDFC                              \ Clear PKA End of Operation flag
$00080000 constant PKA_CLRFR_RAMERRFC                               \ Clear RAM error flag
$00100000 constant PKA_CLRFR_ADDRERRFC                              \ Clear Address error flag


\
\ @brief PKA version register
\ Address offset: 0x1FF4
\ Reset value: 0x00000010
\

$0000000f constant PKA_VERR_MINREV                                  \ Minor revision
$000000f0 constant PKA_VERR_MAJREV                                  \ Major revision


\
\ @brief PKA identification register
\ Address offset: 0x1FF8
\ Reset value: 0x00170061
\

$00000000 constant PKA_IPIDR_ID                                     \ Identification Code


\
\ @brief PKA size ID register
\ Address offset: 0x1FFC
\ Reset value: 0xA3C5DD08
\

$00000000 constant PKA_SIDR_SID                                     \ Side Identification Code


\
\ @brief PKA
\
$58002000 constant PKA_CR         \ offset: 0x00 : Control register
$58002004 constant PKA_SR         \ offset: 0x04 : PKA status register
$58002008 constant PKA_CLRFR      \ offset: 0x08 : PKA clear flag register
$58003ff4 constant PKA_VERR       \ offset: 0x1FF4 : PKA version register
$58003ff8 constant PKA_IPIDR      \ offset: 0x1FF8 : PKA identification register
$58003ffc constant PKA_SIDR       \ offset: 0x1FFC : PKA size ID register

