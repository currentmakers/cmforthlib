\
\ @file pwr.fs
\ @brief Power control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Power control register (PWR_CR)
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant PWR_CR_LPDS                                      \ Low Power Deep Sleep
$00000002 constant PWR_CR_PDDS                                      \ Power Down Deep Sleep
$00000004 constant PWR_CR_CWUF                                      \ Clear Wake-up Flag
$00000008 constant PWR_CR_CSBF                                      \ Clear STANDBY Flag
$00000010 constant PWR_CR_PVDE                                      \ Power Voltage Detector Enable
$000000e0 constant PWR_CR_PLS                                       \ PVD Level Selection
$00000100 constant PWR_CR_DBP                                       \ Disable Backup Domain write protection


\
\ @brief Power control register (PWR_CR)
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant PWR_CSR_WUF                                      \ Wake-Up Flag
$00000002 constant PWR_CSR_SBF                                      \ STANDBY Flag
$00000004 constant PWR_CSR_PVDO                                     \ PVD Output
$00000100 constant PWR_CSR_EWUP                                     \ Enable WKUP pin


\
\ @brief Power control
\
$40007000 constant PWR_CR         \ offset: 0x00 : Power control register (PWR_CR)
$40007004 constant PWR_CSR        \ offset: 0x04 : Power control register (PWR_CR)

