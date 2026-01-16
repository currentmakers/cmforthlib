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
\ Reset value: 0x00001000
\

$00000001 constant PWR_CR_LPSDSR                                    \ Low-power deepsleep/Sleep/Low-power run
$00000002 constant PWR_CR_PDDS                                      \ Power down deepsleep
$00000004 constant PWR_CR_CWUF                                      \ Clear wakeup flag
$00000008 constant PWR_CR_CSBF                                      \ Clear standby flag
$00000010 constant PWR_CR_PVDE                                      \ Power voltage detector enable
$000000e0 constant PWR_CR_PLS                                       \ PVD level selection
$00000100 constant PWR_CR_DBP                                       \ Disable backup domain write protection
$00000200 constant PWR_CR_ULP                                       \ Ultra-low-power mode
$00000400 constant PWR_CR_FWU                                       \ Fast wakeup
$00001800 constant PWR_CR_VOS                                       \ Voltage scaling range selection
$00002000 constant PWR_CR_DS_EE_KOFF                                \ Deep sleep mode with Flash memory kept off
$00004000 constant PWR_CR_LPRUN                                     \ Low power run mode
$00010000 constant PWR_CR_LPDS                                      \ Regulator in Low-power deepsleep mode This bit allows switching the regulator to low-power mode when the CPU enters Stop mode. Its behavior depends on LPSDSR bit


\
\ @brief power control/status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant PWR_CSR_WUF                                      \ Wakeup flag
$00000002 constant PWR_CSR_SBF                                      \ Standby flag
$00000004 constant PWR_CSR_PVDO                                     \ PVD output
$00000008 constant PWR_CSR_VREFINTRDYF                              \ Internal voltage reference (VREFINT) ready flag This bit indicates the state of the internal voltage reference, VREFINT.
$00000010 constant PWR_CSR_VOSF                                     \ Voltage Scaling select flag
$00000020 constant PWR_CSR_REGLPF                                   \ Regulator LP flag
$00000100 constant PWR_CSR_EWUP1                                    \ Enable WKUP pin 1
$00000200 constant PWR_CSR_EWUP2                                    \ Enable WKUP pin 2
$00000400 constant PWR_CSR_EWUP3                                    \ Enable WKUP pin 3


\
\ @brief Power control
\
$40007000 constant PWR_CR         \ offset: 0x00 : power control register
$40007004 constant PWR_CSR        \ offset: 0x04 : power control/status register

