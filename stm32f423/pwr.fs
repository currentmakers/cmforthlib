\
\ @file pwr.fs
\ @brief Power control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief power control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant PWR_CR_LPDS                                      \ Low-power deep sleep
$00000002 constant PWR_CR_PDDS                                      \ Power down deepsleep
$00000004 constant PWR_CR_CWUF                                      \ Clear wakeup flag
$00000008 constant PWR_CR_CSBF                                      \ Clear standby flag
$00000010 constant PWR_CR_PVDE                                      \ Power voltage detector enable
$000000e0 constant PWR_CR_PLS                                       \ PVD level selection
$00000100 constant PWR_CR_DBP                                       \ Disable backup domain write protection
$00000200 constant PWR_CR_FPDS                                      \ Flash power down in Stop mode
$00002000 constant PWR_CR_ADCDC1                                    \ ADCDC1
$0000c000 constant PWR_CR_VOS                                       \ Regulator voltage scaling output selection


\
\ @brief power control/status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant PWR_CSR_WUF                                      \ Wakeup flag
$00000002 constant PWR_CSR_SBF                                      \ Standby flag
$00000004 constant PWR_CSR_PVDO                                     \ PVD output
$00000008 constant PWR_CSR_BRR                                      \ Backup regulator ready
$00000100 constant PWR_CSR_EWUP                                     \ Enable WKUP pin
$00000200 constant PWR_CSR_BRE                                      \ Backup regulator enable
$00004000 constant PWR_CSR_VOSRDY                                   \ Regulator voltage scaling output selection ready bit


\
\ @brief Power control
\
$40007000 constant PWR_CR         \ offset: 0x00 : power control register
$40007004 constant PWR_CSR        \ offset: 0x04 : power control/status register

