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
$00000100 constant PWR_CR_DBP                                       \ Disable backup domain write protection


\
\ @brief power control/status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant PWR_CSR_WUF                                      \ Wakeup flag
$00000002 constant PWR_CSR_SBF                                      \ Standby flag
$00000100 constant PWR_CSR_EWUP1                                    \ Enable WKUP pin 1
$00000200 constant PWR_CSR_EWUP2                                    \ Enable WKUP pin 2
$00000800 constant PWR_CSR_EWUP4                                    \ Enable WKUP pin 4
$00001000 constant PWR_CSR_EWUP5                                    \ Enable WKUP pin 5
$00002000 constant PWR_CSR_EWUP6                                    \ Enable WKUP pin 6
$00004000 constant PWR_CSR_EWUP7                                    \ Enable WKUP pin 7


\
\ @brief Power control
\
$40007000 constant PWR_CR         \ offset: 0x00 : power control register
$40007004 constant PWR_CSR        \ offset: 0x04 : power control/status register

