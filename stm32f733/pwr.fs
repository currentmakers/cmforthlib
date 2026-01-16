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
\ Reset value: 0x0000C000
\

$00000001 constant PWR_CR1_LPDS                                     \ Low-power deep sleep
$00000002 constant PWR_CR1_PDDS                                     \ Power down deepsleep
$00000008 constant PWR_CR1_CSBF                                     \ Clear standby flag
$00000010 constant PWR_CR1_PVDE                                     \ Power voltage detector enable
$000000e0 constant PWR_CR1_PLS                                      \ PVD level selection
$00000100 constant PWR_CR1_DBP                                      \ Disable backup domain write protection
$00000200 constant PWR_CR1_FPDS                                     \ Flash power down in Stop mode
$00000400 constant PWR_CR1_LPUDS                                    \ Low-power regulator in deepsleep under-drive mode
$00000800 constant PWR_CR1_MRUDS                                    \ Main regulator in deepsleep under-drive mode
$00002000 constant PWR_CR1_ADCDC1                                   \ ADCDC1
$0000c000 constant PWR_CR1_VOS                                      \ Regulator voltage scaling output selection
$00010000 constant PWR_CR1_ODEN                                     \ Over-drive enable
$00020000 constant PWR_CR1_ODSWEN                                   \ Over-drive switching enabled
$000c0000 constant PWR_CR1_UDEN                                     \ Under-drive enable in stop mode


\
\ @brief power control/status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant PWR_CSR1_WUIF                                    \ Wakeup internal flag
$00000002 constant PWR_CSR1_SBF                                     \ Standby flag
$00000004 constant PWR_CSR1_PVDO                                    \ PVD output
$00000008 constant PWR_CSR1_BRR                                     \ Backup regulator ready
$00000100 constant PWR_CSR1_EIWUP                                   \ Enable internal wakeup
$00000200 constant PWR_CSR1_BRE                                     \ Backup regulator enable
$00004000 constant PWR_CSR1_VOSRDY                                  \ Regulator voltage scaling output selection ready bit
$00010000 constant PWR_CSR1_ODRDY                                   \ Over-drive mode ready
$00020000 constant PWR_CSR1_ODSWRDY                                 \ Over-drive mode switching ready
$000c0000 constant PWR_CSR1_UDRDY                                   \ Under-drive ready flag


\
\ @brief power control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant PWR_CR2_CWUPF1                                   \ Clear Wakeup Pin flag for PA0
$00000002 constant PWR_CR2_CWUPF2                                   \ Clear Wakeup Pin flag for PA2
$00000004 constant PWR_CR2_CWUPF3                                   \ Clear Wakeup Pin flag for PC1
$00000008 constant PWR_CR2_CWUPF4                                   \ Clear Wakeup Pin flag for PC13
$00000010 constant PWR_CR2_CWUPF5                                   \ Clear Wakeup Pin flag for PI8
$00000020 constant PWR_CR2_CWUPF6                                   \ Clear Wakeup Pin flag for PI11
$00000100 constant PWR_CR2_WUPP1                                    \ Wakeup pin polarity bit for PA0
$00000200 constant PWR_CR2_WUPP2                                    \ Wakeup pin polarity bit for PA2
$00000400 constant PWR_CR2_WUPP3                                    \ Wakeup pin polarity bit for PC1
$00000800 constant PWR_CR2_WUPP4                                    \ Wakeup pin polarity bit for PC13
$00001000 constant PWR_CR2_WUPP5                                    \ Wakeup pin polarity bit for PI8
$00002000 constant PWR_CR2_WUPP6                                    \ Wakeup pin polarity bit for PI11


\
\ @brief power control/status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant PWR_CSR2_WUPF1                                   \ Wakeup Pin flag for PA0
$00000002 constant PWR_CSR2_WUPF2                                   \ Wakeup Pin flag for PA2
$00000004 constant PWR_CSR2_WUPF3                                   \ Wakeup Pin flag for PC1
$00000008 constant PWR_CSR2_WUPF4                                   \ Wakeup Pin flag for PC13
$00000010 constant PWR_CSR2_WUPF5                                   \ Wakeup Pin flag for PI8
$00000020 constant PWR_CSR2_WUPF6                                   \ Wakeup Pin flag for PI11
$00000100 constant PWR_CSR2_EWUP1                                   \ Enable Wakeup pin for PA0
$00000200 constant PWR_CSR2_EWUP2                                   \ Enable Wakeup pin for PA2
$00000400 constant PWR_CSR2_EWUP3                                   \ Enable Wakeup pin for PC1
$00000800 constant PWR_CSR2_EWUP4                                   \ Enable Wakeup pin for PC13
$00001000 constant PWR_CSR2_EWUP5                                   \ Enable Wakeup pin for PI8
$00002000 constant PWR_CSR2_EWUP6                                   \ Enable Wakeup pin for PI11


\
\ @brief Power control
\
$40007000 constant PWR_CR1        \ offset: 0x00 : power control register
$40007004 constant PWR_CSR1       \ offset: 0x04 : power control/status register
$40007008 constant PWR_CR2        \ offset: 0x08 : power control register
$4000700c constant PWR_CSR2       \ offset: 0x0C : power control/status register

