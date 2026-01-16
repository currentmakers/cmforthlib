\
\ @file pwr.fs
\ @brief Power control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Power control register 1
\ Address offset: 0x00
\ Reset value: 0x00000200
\

$00000007 constant PWR_CR1_LPMS                                     \ Low-power mode selection
$00000100 constant PWR_CR1_DBP                                      \ Disable backup domain write protection
$00000600 constant PWR_CR1_VOS                                      \ Voltage scaling range selection
$00004000 constant PWR_CR1_LPR                                      \ Low-power run


\
\ @brief Power control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant PWR_CR2_PVDE                                     \ Power voltage detector enable
$0000000e constant PWR_CR2_PLS                                      \ Power voltage detector level selection
$00000010 constant PWR_CR2_PVME1                                    \ Peripheral voltage monitoring 1 enable: VDDUSB vs. 1.2V
$00000020 constant PWR_CR2_PVME2                                    \ Peripheral voltage monitoring 2 enable: VDDIO2 vs. 0.9V
$00000040 constant PWR_CR2_PVME3                                    \ Peripheral voltage monitoring 3 enable: VDDA vs. 1.62V
$00000080 constant PWR_CR2_PVME4                                    \ Peripheral voltage monitoring 4 enable: VDDA vs. 2.2V
$00000200 constant PWR_CR2_IOSV                                     \ VDDIO2 Independent I/Os supply valid
$00000400 constant PWR_CR2_USV                                      \ VDDUSB USB supply valid


\
\ @brief Power control register 3
\ Address offset: 0x08
\ Reset value: 0x00008000
\

$00000001 constant PWR_CR3_EWUP1                                    \ Enable Wakeup pin WKUP1
$00000002 constant PWR_CR3_EWUP2                                    \ Enable Wakeup pin WKUP2
$00000004 constant PWR_CR3_EWUP3                                    \ Enable Wakeup pin WKUP3
$00000008 constant PWR_CR3_EWUP4                                    \ Enable Wakeup pin WKUP4
$00000010 constant PWR_CR3_EWUP5                                    \ Enable Wakeup pin WKUP5
$00000100 constant PWR_CR3_RRS                                      \ SRAM2 retention in Standby mode
$00000400 constant PWR_CR3_APC                                      \ Apply pull-up and pull-down configuration
$00008000 constant PWR_CR3_EWF                                      \ Enable internal wakeup line


\
\ @brief Power control register 4
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant PWR_CR4_WP1                                      \ Wakeup pin WKUP1 polarity
$00000002 constant PWR_CR4_WP2                                      \ Wakeup pin WKUP2 polarity
$00000004 constant PWR_CR4_WP3                                      \ Wakeup pin WKUP3 polarity
$00000008 constant PWR_CR4_WP4                                      \ Wakeup pin WKUP4 polarity
$00000010 constant PWR_CR4_WP5                                      \ Wakeup pin WKUP5 polarity
$00000100 constant PWR_CR4_VBE                                      \ VBAT battery charging enable
$00000200 constant PWR_CR4_VBRS                                     \ VBAT battery charging resistor selection


\
\ @brief Power status register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant PWR_SR1_CWUF1                                    \ Wakeup flag 1
$00000002 constant PWR_SR1_CWUF2                                    \ Wakeup flag 2
$00000004 constant PWR_SR1_CWUF3                                    \ Wakeup flag 3
$00000008 constant PWR_SR1_CWUF4                                    \ Wakeup flag 4
$00000010 constant PWR_SR1_CWUF5                                    \ Wakeup flag 5
$00000100 constant PWR_SR1_CSBF                                     \ Standby flag
$00008000 constant PWR_SR1_WUFI                                     \ Wakeup flag internal


\
\ @brief Power status register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000100 constant PWR_SR2_REGLPS                                   \ Low-power regulator started
$00000200 constant PWR_SR2_REGLPF                                   \ Low-power regulator flag
$00000400 constant PWR_SR2_VOSF                                     \ Voltage scaling flag
$00000800 constant PWR_SR2_PVDO                                     \ Power voltage detector output
$00001000 constant PWR_SR2_PVMO1                                    \ Peripheral voltage monitoring output: VDDUSB vs. 1.2 V
$00002000 constant PWR_SR2_PVMO2                                    \ Peripheral voltage monitoring output: VDDIO2 vs. 0.9 V
$00004000 constant PWR_SR2_PVMO3                                    \ Peripheral voltage monitoring output: VDDA vs. 1.62 V
$00008000 constant PWR_SR2_PVMO4                                    \ Peripheral voltage monitoring output: VDDA vs. 2.2 V


\
\ @brief Power status clear register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant PWR_SCR_WUF1                                     \ Clear wakeup flag 1
$00000002 constant PWR_SCR_WUF2                                     \ Clear wakeup flag 2
$00000004 constant PWR_SCR_WUF3                                     \ Clear wakeup flag 3
$00000008 constant PWR_SCR_WUF4                                     \ Clear wakeup flag 4
$00000010 constant PWR_SCR_WUF5                                     \ Clear wakeup flag 5
$00000100 constant PWR_SCR_SBF                                      \ Clear standby flag


\
\ @brief Power Port A pull-up control register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant PWR_PUCRA_PU0                                    \ Port A pull-up bit y (y=0..15)
$00000002 constant PWR_PUCRA_PU1                                    \ Port A pull-up bit y (y=0..15)
$00000004 constant PWR_PUCRA_PU2                                    \ Port A pull-up bit y (y=0..15)
$00000008 constant PWR_PUCRA_PU3                                    \ Port A pull-up bit y (y=0..15)
$00000010 constant PWR_PUCRA_PU4                                    \ Port A pull-up bit y (y=0..15)
$00000020 constant PWR_PUCRA_PU5                                    \ Port A pull-up bit y (y=0..15)
$00000040 constant PWR_PUCRA_PU6                                    \ Port A pull-up bit y (y=0..15)
$00000080 constant PWR_PUCRA_PU7                                    \ Port A pull-up bit y (y=0..15)
$00000100 constant PWR_PUCRA_PU8                                    \ Port A pull-up bit y (y=0..15)
$00000200 constant PWR_PUCRA_PU9                                    \ Port A pull-up bit y (y=0..15)
$00000400 constant PWR_PUCRA_PU10                                   \ Port A pull-up bit y (y=0..15)
$00000800 constant PWR_PUCRA_PU11                                   \ Port A pull-up bit y (y=0..15)
$00001000 constant PWR_PUCRA_PU12                                   \ Port A pull-up bit y (y=0..15)
$00002000 constant PWR_PUCRA_PU13                                   \ Port A pull-up bit y (y=0..15)
$00004000 constant PWR_PUCRA_PU14                                   \ Port A pull-up bit y (y=0..15)
$00008000 constant PWR_PUCRA_PU15                                   \ Port A pull-up bit y (y=0..15)


\
\ @brief Power Port A pull-down control register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant PWR_PDCRA_PD0                                    \ Port A pull-down bit y (y=0..15)
$00000002 constant PWR_PDCRA_PD1                                    \ Port A pull-down bit y (y=0..15)
$00000004 constant PWR_PDCRA_PD2                                    \ Port A pull-down bit y (y=0..15)
$00000008 constant PWR_PDCRA_PD3                                    \ Port A pull-down bit y (y=0..15)
$00000010 constant PWR_PDCRA_PD4                                    \ Port A pull-down bit y (y=0..15)
$00000020 constant PWR_PDCRA_PD5                                    \ Port A pull-down bit y (y=0..15)
$00000040 constant PWR_PDCRA_PD6                                    \ Port A pull-down bit y (y=0..15)
$00000080 constant PWR_PDCRA_PD7                                    \ Port A pull-down bit y (y=0..15)
$00000100 constant PWR_PDCRA_PD8                                    \ Port A pull-down bit y (y=0..15)
$00000200 constant PWR_PDCRA_PD9                                    \ Port A pull-down bit y (y=0..15)
$00000400 constant PWR_PDCRA_PD10                                   \ Port A pull-down bit y (y=0..15)
$00000800 constant PWR_PDCRA_PD11                                   \ Port A pull-down bit y (y=0..15)
$00001000 constant PWR_PDCRA_PD12                                   \ Port A pull-down bit y (y=0..15)
$00002000 constant PWR_PDCRA_PD13                                   \ Port A pull-down bit y (y=0..15)
$00004000 constant PWR_PDCRA_PD14                                   \ Port A pull-down bit y (y=0..15)
$00008000 constant PWR_PDCRA_PD15                                   \ Port A pull-down bit y (y=0..15)


\
\ @brief Power Port B pull-up control register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant PWR_PUCRB_PU0                                    \ Port B pull-up bit y (y=0..15)
$00000002 constant PWR_PUCRB_PU1                                    \ Port B pull-up bit y (y=0..15)
$00000004 constant PWR_PUCRB_PU2                                    \ Port B pull-up bit y (y=0..15)
$00000008 constant PWR_PUCRB_PU3                                    \ Port B pull-up bit y (y=0..15)
$00000010 constant PWR_PUCRB_PU4                                    \ Port B pull-up bit y (y=0..15)
$00000020 constant PWR_PUCRB_PU5                                    \ Port B pull-up bit y (y=0..15)
$00000040 constant PWR_PUCRB_PU6                                    \ Port B pull-up bit y (y=0..15)
$00000080 constant PWR_PUCRB_PU7                                    \ Port B pull-up bit y (y=0..15)
$00000100 constant PWR_PUCRB_PU8                                    \ Port B pull-up bit y (y=0..15)
$00000200 constant PWR_PUCRB_PU9                                    \ Port B pull-up bit y (y=0..15)
$00000400 constant PWR_PUCRB_PU10                                   \ Port B pull-up bit y (y=0..15)
$00000800 constant PWR_PUCRB_PU11                                   \ Port B pull-up bit y (y=0..15)
$00001000 constant PWR_PUCRB_PU12                                   \ Port B pull-up bit y (y=0..15)
$00002000 constant PWR_PUCRB_PU13                                   \ Port B pull-up bit y (y=0..15)
$00004000 constant PWR_PUCRB_PU14                                   \ Port B pull-up bit y (y=0..15)
$00008000 constant PWR_PUCRB_PU15                                   \ Port B pull-up bit y (y=0..15)


\
\ @brief Power Port B pull-down control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PDCRB_PD0                                    \ Port B pull-down bit y (y=0..15)
$00000002 constant PWR_PDCRB_PD1                                    \ Port B pull-down bit y (y=0..15)
$00000004 constant PWR_PDCRB_PD2                                    \ Port B pull-down bit y (y=0..15)
$00000008 constant PWR_PDCRB_PD3                                    \ Port B pull-down bit y (y=0..15)
$00000010 constant PWR_PDCRB_PD4                                    \ Port B pull-down bit y (y=0..15)
$00000020 constant PWR_PDCRB_PD5                                    \ Port B pull-down bit y (y=0..15)
$00000040 constant PWR_PDCRB_PD6                                    \ Port B pull-down bit y (y=0..15)
$00000080 constant PWR_PDCRB_PD7                                    \ Port B pull-down bit y (y=0..15)
$00000100 constant PWR_PDCRB_PD8                                    \ Port B pull-down bit y (y=0..15)
$00000200 constant PWR_PDCRB_PD9                                    \ Port B pull-down bit y (y=0..15)
$00000400 constant PWR_PDCRB_PD10                                   \ Port B pull-down bit y (y=0..15)
$00000800 constant PWR_PDCRB_PD11                                   \ Port B pull-down bit y (y=0..15)
$00001000 constant PWR_PDCRB_PD12                                   \ Port B pull-down bit y (y=0..15)
$00002000 constant PWR_PDCRB_PD13                                   \ Port B pull-down bit y (y=0..15)
$00004000 constant PWR_PDCRB_PD14                                   \ Port B pull-down bit y (y=0..15)
$00008000 constant PWR_PDCRB_PD15                                   \ Port B pull-down bit y (y=0..15)


\
\ @brief Power Port C pull-up control register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant PWR_PUCRC_PU0                                    \ Port C pull-up bit y (y=0..15)
$00000002 constant PWR_PUCRC_PU1                                    \ Port C pull-up bit y (y=0..15)
$00000004 constant PWR_PUCRC_PU2                                    \ Port C pull-up bit y (y=0..15)
$00000008 constant PWR_PUCRC_PU3                                    \ Port C pull-up bit y (y=0..15)
$00000010 constant PWR_PUCRC_PU4                                    \ Port C pull-up bit y (y=0..15)
$00000020 constant PWR_PUCRC_PU5                                    \ Port C pull-up bit y (y=0..15)
$00000040 constant PWR_PUCRC_PU6                                    \ Port C pull-up bit y (y=0..15)
$00000080 constant PWR_PUCRC_PU7                                    \ Port C pull-up bit y (y=0..15)
$00000100 constant PWR_PUCRC_PU8                                    \ Port C pull-up bit y (y=0..15)
$00000200 constant PWR_PUCRC_PU9                                    \ Port C pull-up bit y (y=0..15)
$00000400 constant PWR_PUCRC_PU10                                   \ Port C pull-up bit y (y=0..15)
$00000800 constant PWR_PUCRC_PU11                                   \ Port C pull-up bit y (y=0..15)
$00001000 constant PWR_PUCRC_PU12                                   \ Port C pull-up bit y (y=0..15)
$00002000 constant PWR_PUCRC_PU13                                   \ Port C pull-up bit y (y=0..15)
$00004000 constant PWR_PUCRC_PU14                                   \ Port C pull-up bit y (y=0..15)
$00008000 constant PWR_PUCRC_PU15                                   \ Port C pull-up bit y (y=0..15)


\
\ @brief Power Port C pull-down control register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant PWR_PDCRC_PD0                                    \ Port C pull-down bit y (y=0..15)
$00000002 constant PWR_PDCRC_PD1                                    \ Port C pull-down bit y (y=0..15)
$00000004 constant PWR_PDCRC_PD2                                    \ Port C pull-down bit y (y=0..15)
$00000008 constant PWR_PDCRC_PD3                                    \ Port C pull-down bit y (y=0..15)
$00000010 constant PWR_PDCRC_PD4                                    \ Port C pull-down bit y (y=0..15)
$00000020 constant PWR_PDCRC_PD5                                    \ Port C pull-down bit y (y=0..15)
$00000040 constant PWR_PDCRC_PD6                                    \ Port C pull-down bit y (y=0..15)
$00000080 constant PWR_PDCRC_PD7                                    \ Port C pull-down bit y (y=0..15)
$00000100 constant PWR_PDCRC_PD8                                    \ Port C pull-down bit y (y=0..15)
$00000200 constant PWR_PDCRC_PD9                                    \ Port C pull-down bit y (y=0..15)
$00000400 constant PWR_PDCRC_PD10                                   \ Port C pull-down bit y (y=0..15)
$00000800 constant PWR_PDCRC_PD11                                   \ Port C pull-down bit y (y=0..15)
$00001000 constant PWR_PDCRC_PD12                                   \ Port C pull-down bit y (y=0..15)
$00002000 constant PWR_PDCRC_PD13                                   \ Port C pull-down bit y (y=0..15)
$00004000 constant PWR_PDCRC_PD14                                   \ Port C pull-down bit y (y=0..15)
$00008000 constant PWR_PDCRC_PD15                                   \ Port C pull-down bit y (y=0..15)


\
\ @brief Power Port D pull-up control register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant PWR_PUCRD_PU0                                    \ Port D pull-up bit y (y=0..15)
$00000002 constant PWR_PUCRD_PU1                                    \ Port D pull-up bit y (y=0..15)
$00000004 constant PWR_PUCRD_PU2                                    \ Port D pull-up bit y (y=0..15)
$00000008 constant PWR_PUCRD_PU3                                    \ Port D pull-up bit y (y=0..15)
$00000010 constant PWR_PUCRD_PU4                                    \ Port D pull-up bit y (y=0..15)
$00000020 constant PWR_PUCRD_PU5                                    \ Port D pull-up bit y (y=0..15)
$00000040 constant PWR_PUCRD_PU6                                    \ Port D pull-up bit y (y=0..15)
$00000080 constant PWR_PUCRD_PU7                                    \ Port D pull-up bit y (y=0..15)
$00000100 constant PWR_PUCRD_PU8                                    \ Port D pull-up bit y (y=0..15)
$00000200 constant PWR_PUCRD_PU9                                    \ Port D pull-up bit y (y=0..15)
$00000400 constant PWR_PUCRD_PU10                                   \ Port D pull-up bit y (y=0..15)
$00000800 constant PWR_PUCRD_PU11                                   \ Port D pull-up bit y (y=0..15)
$00001000 constant PWR_PUCRD_PU12                                   \ Port D pull-up bit y (y=0..15)
$00002000 constant PWR_PUCRD_PU13                                   \ Port D pull-up bit y (y=0..15)
$00004000 constant PWR_PUCRD_PU14                                   \ Port D pull-up bit y (y=0..15)
$00008000 constant PWR_PUCRD_PU15                                   \ Port D pull-up bit y (y=0..15)


\
\ @brief Power Port D pull-down control register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PDCRD_PD0                                    \ Port D pull-down bit y (y=0..15)
$00000002 constant PWR_PDCRD_PD1                                    \ Port D pull-down bit y (y=0..15)
$00000004 constant PWR_PDCRD_PD2                                    \ Port D pull-down bit y (y=0..15)
$00000008 constant PWR_PDCRD_PD3                                    \ Port D pull-down bit y (y=0..15)
$00000010 constant PWR_PDCRD_PD4                                    \ Port D pull-down bit y (y=0..15)
$00000020 constant PWR_PDCRD_PD5                                    \ Port D pull-down bit y (y=0..15)
$00000040 constant PWR_PDCRD_PD6                                    \ Port D pull-down bit y (y=0..15)
$00000080 constant PWR_PDCRD_PD7                                    \ Port D pull-down bit y (y=0..15)
$00000100 constant PWR_PDCRD_PD8                                    \ Port D pull-down bit y (y=0..15)
$00000200 constant PWR_PDCRD_PD9                                    \ Port D pull-down bit y (y=0..15)
$00000400 constant PWR_PDCRD_PD10                                   \ Port D pull-down bit y (y=0..15)
$00000800 constant PWR_PDCRD_PD11                                   \ Port D pull-down bit y (y=0..15)
$00001000 constant PWR_PDCRD_PD12                                   \ Port D pull-down bit y (y=0..15)
$00002000 constant PWR_PDCRD_PD13                                   \ Port D pull-down bit y (y=0..15)
$00004000 constant PWR_PDCRD_PD14                                   \ Port D pull-down bit y (y=0..15)
$00008000 constant PWR_PDCRD_PD15                                   \ Port D pull-down bit y (y=0..15)


\
\ @brief Power Port E pull-up control register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant PWR_PUCRE_PU0                                    \ Port E pull-up bit y (y=0..15)
$00000002 constant PWR_PUCRE_PU1                                    \ Port E pull-up bit y (y=0..15)
$00000004 constant PWR_PUCRE_PU2                                    \ Port E pull-up bit y (y=0..15)
$00000008 constant PWR_PUCRE_PU3                                    \ Port E pull-up bit y (y=0..15)
$00000010 constant PWR_PUCRE_PU4                                    \ Port E pull-up bit y (y=0..15)
$00000020 constant PWR_PUCRE_PU5                                    \ Port E pull-up bit y (y=0..15)
$00000040 constant PWR_PUCRE_PU6                                    \ Port E pull-up bit y (y=0..15)
$00000080 constant PWR_PUCRE_PU7                                    \ Port E pull-up bit y (y=0..15)
$00000100 constant PWR_PUCRE_PU8                                    \ Port E pull-up bit y (y=0..15)
$00000200 constant PWR_PUCRE_PU9                                    \ Port E pull-up bit y (y=0..15)
$00000400 constant PWR_PUCRE_PU10                                   \ Port E pull-up bit y (y=0..15)
$00000800 constant PWR_PUCRE_PU11                                   \ Port E pull-up bit y (y=0..15)
$00001000 constant PWR_PUCRE_PU12                                   \ Port E pull-up bit y (y=0..15)
$00002000 constant PWR_PUCRE_PU13                                   \ Port E pull-up bit y (y=0..15)
$00004000 constant PWR_PUCRE_PU14                                   \ Port E pull-up bit y (y=0..15)
$00008000 constant PWR_PUCRE_PU15                                   \ Port E pull-up bit y (y=0..15)


\
\ @brief Power Port E pull-down control register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant PWR_PDCRE_PD0                                    \ Port E pull-down bit y (y=0..15)
$00000002 constant PWR_PDCRE_PD1                                    \ Port E pull-down bit y (y=0..15)
$00000004 constant PWR_PDCRE_PD2                                    \ Port E pull-down bit y (y=0..15)
$00000008 constant PWR_PDCRE_PD3                                    \ Port E pull-down bit y (y=0..15)
$00000010 constant PWR_PDCRE_PD4                                    \ Port E pull-down bit y (y=0..15)
$00000020 constant PWR_PDCRE_PD5                                    \ Port E pull-down bit y (y=0..15)
$00000040 constant PWR_PDCRE_PD6                                    \ Port E pull-down bit y (y=0..15)
$00000080 constant PWR_PDCRE_PD7                                    \ Port E pull-down bit y (y=0..15)
$00000100 constant PWR_PDCRE_PD8                                    \ Port E pull-down bit y (y=0..15)
$00000200 constant PWR_PDCRE_PD9                                    \ Port E pull-down bit y (y=0..15)
$00000400 constant PWR_PDCRE_PD10                                   \ Port E pull-down bit y (y=0..15)
$00000800 constant PWR_PDCRE_PD11                                   \ Port E pull-down bit y (y=0..15)
$00001000 constant PWR_PDCRE_PD12                                   \ Port E pull-down bit y (y=0..15)
$00002000 constant PWR_PDCRE_PD13                                   \ Port E pull-down bit y (y=0..15)
$00004000 constant PWR_PDCRE_PD14                                   \ Port E pull-down bit y (y=0..15)
$00008000 constant PWR_PDCRE_PD15                                   \ Port E pull-down bit y (y=0..15)


\
\ @brief Power Port F pull-up control register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant PWR_PUCRF_PU0                                    \ Port F pull-up bit y (y=0..15)
$00000002 constant PWR_PUCRF_PU1                                    \ Port F pull-up bit y (y=0..15)
$00000004 constant PWR_PUCRF_PU2                                    \ Port F pull-up bit y (y=0..15)
$00000008 constant PWR_PUCRF_PU3                                    \ Port F pull-up bit y (y=0..15)
$00000010 constant PWR_PUCRF_PU4                                    \ Port F pull-up bit y (y=0..15)
$00000020 constant PWR_PUCRF_PU5                                    \ Port F pull-up bit y (y=0..15)
$00000040 constant PWR_PUCRF_PU6                                    \ Port F pull-up bit y (y=0..15)
$00000080 constant PWR_PUCRF_PU7                                    \ Port F pull-up bit y (y=0..15)
$00000100 constant PWR_PUCRF_PU8                                    \ Port F pull-up bit y (y=0..15)
$00000200 constant PWR_PUCRF_PU9                                    \ Port F pull-up bit y (y=0..15)
$00000400 constant PWR_PUCRF_PU10                                   \ Port F pull-up bit y (y=0..15)
$00000800 constant PWR_PUCRF_PU11                                   \ Port F pull-up bit y (y=0..15)
$00001000 constant PWR_PUCRF_PU12                                   \ Port F pull-up bit y (y=0..15)
$00002000 constant PWR_PUCRF_PU13                                   \ Port F pull-up bit y (y=0..15)
$00004000 constant PWR_PUCRF_PU14                                   \ Port F pull-up bit y (y=0..15)
$00008000 constant PWR_PUCRF_PU15                                   \ Port F pull-up bit y (y=0..15)


\
\ @brief Power Port F pull-down control register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PDCRF_PD0                                    \ Port F pull-down bit y (y=0..15)
$00000002 constant PWR_PDCRF_PD1                                    \ Port F pull-down bit y (y=0..15)
$00000004 constant PWR_PDCRF_PD2                                    \ Port F pull-down bit y (y=0..15)
$00000008 constant PWR_PDCRF_PD3                                    \ Port F pull-down bit y (y=0..15)
$00000010 constant PWR_PDCRF_PD4                                    \ Port F pull-down bit y (y=0..15)
$00000020 constant PWR_PDCRF_PD5                                    \ Port F pull-down bit y (y=0..15)
$00000040 constant PWR_PDCRF_PD6                                    \ Port F pull-down bit y (y=0..15)
$00000080 constant PWR_PDCRF_PD7                                    \ Port F pull-down bit y (y=0..15)
$00000100 constant PWR_PDCRF_PD8                                    \ Port F pull-down bit y (y=0..15)
$00000200 constant PWR_PDCRF_PD9                                    \ Port F pull-down bit y (y=0..15)
$00000400 constant PWR_PDCRF_PD10                                   \ Port F pull-down bit y (y=0..15)
$00000800 constant PWR_PDCRF_PD11                                   \ Port F pull-down bit y (y=0..15)
$00001000 constant PWR_PDCRF_PD12                                   \ Port F pull-down bit y (y=0..15)
$00002000 constant PWR_PDCRF_PD13                                   \ Port F pull-down bit y (y=0..15)
$00004000 constant PWR_PDCRF_PD14                                   \ Port F pull-down bit y (y=0..15)
$00008000 constant PWR_PDCRF_PD15                                   \ Port F pull-down bit y (y=0..15)


\
\ @brief Power Port G pull-up control register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant PWR_PUCRG_PU0                                    \ Port G pull-up bit y (y=0..15)
$00000002 constant PWR_PUCRG_PU1                                    \ Port G pull-up bit y (y=0..15)
$00000004 constant PWR_PUCRG_PU2                                    \ Port G pull-up bit y (y=0..15)
$00000008 constant PWR_PUCRG_PU3                                    \ Port G pull-up bit y (y=0..15)
$00000010 constant PWR_PUCRG_PU4                                    \ Port G pull-up bit y (y=0..15)
$00000020 constant PWR_PUCRG_PU5                                    \ Port G pull-up bit y (y=0..15)
$00000040 constant PWR_PUCRG_PU6                                    \ Port G pull-up bit y (y=0..15)
$00000080 constant PWR_PUCRG_PU7                                    \ Port G pull-up bit y (y=0..15)
$00000100 constant PWR_PUCRG_PU8                                    \ Port G pull-up bit y (y=0..15)
$00000200 constant PWR_PUCRG_PU9                                    \ Port G pull-up bit y (y=0..15)
$00000400 constant PWR_PUCRG_PU10                                   \ Port G pull-up bit y (y=0..15)
$00000800 constant PWR_PUCRG_PU11                                   \ Port G pull-up bit y (y=0..15)
$00001000 constant PWR_PUCRG_PU12                                   \ Port G pull-up bit y (y=0..15)
$00002000 constant PWR_PUCRG_PU13                                   \ Port G pull-up bit y (y=0..15)
$00004000 constant PWR_PUCRG_PU14                                   \ Port G pull-up bit y (y=0..15)
$00008000 constant PWR_PUCRG_PU15                                   \ Port G pull-up bit y (y=0..15)


\
\ @brief Power Port G pull-down control register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant PWR_PDCRG_PD0                                    \ Port G pull-down bit y (y=0..15)
$00000002 constant PWR_PDCRG_PD1                                    \ Port G pull-down bit y (y=0..15)
$00000004 constant PWR_PDCRG_PD2                                    \ Port G pull-down bit y (y=0..15)
$00000008 constant PWR_PDCRG_PD3                                    \ Port G pull-down bit y (y=0..15)
$00000010 constant PWR_PDCRG_PD4                                    \ Port G pull-down bit y (y=0..15)
$00000020 constant PWR_PDCRG_PD5                                    \ Port G pull-down bit y (y=0..15)
$00000040 constant PWR_PDCRG_PD6                                    \ Port G pull-down bit y (y=0..15)
$00000080 constant PWR_PDCRG_PD7                                    \ Port G pull-down bit y (y=0..15)
$00000100 constant PWR_PDCRG_PD8                                    \ Port G pull-down bit y (y=0..15)
$00000200 constant PWR_PDCRG_PD9                                    \ Port G pull-down bit y (y=0..15)
$00000400 constant PWR_PDCRG_PD10                                   \ Port G pull-down bit y (y=0..15)
$00000800 constant PWR_PDCRG_PD11                                   \ Port G pull-down bit y (y=0..15)
$00001000 constant PWR_PDCRG_PD12                                   \ Port G pull-down bit y (y=0..15)
$00002000 constant PWR_PDCRG_PD13                                   \ Port G pull-down bit y (y=0..15)
$00004000 constant PWR_PDCRG_PD14                                   \ Port G pull-down bit y (y=0..15)
$00008000 constant PWR_PDCRG_PD15                                   \ Port G pull-down bit y (y=0..15)


\
\ @brief Power Port H pull-up control register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant PWR_PUCRH_PU0                                    \ Port H pull-up bit y (y=0..1)
$00000002 constant PWR_PUCRH_PU1                                    \ Port H pull-up bit y (y=0..1)


\
\ @brief Power Port H pull-down control register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PDCRH_PD0                                    \ Port H pull-down bit y (y=0..1)
$00000002 constant PWR_PDCRH_PD1                                    \ Port H pull-down bit y (y=0..1)


\
\ @brief Power control
\
$40007000 constant PWR_CR1        \ offset: 0x00 : Power control register 1
$40007004 constant PWR_CR2        \ offset: 0x04 : Power control register 2
$40007008 constant PWR_CR3        \ offset: 0x08 : Power control register 3
$4000700c constant PWR_CR4        \ offset: 0x0C : Power control register 4
$40007010 constant PWR_SR1        \ offset: 0x10 : Power status register 1
$40007014 constant PWR_SR2        \ offset: 0x14 : Power status register 2
$40007018 constant PWR_SCR        \ offset: 0x18 : Power status clear register
$40007020 constant PWR_PUCRA      \ offset: 0x20 : Power Port A pull-up control register
$40007024 constant PWR_PDCRA      \ offset: 0x24 : Power Port A pull-down control register
$40007028 constant PWR_PUCRB      \ offset: 0x28 : Power Port B pull-up control register
$4000702c constant PWR_PDCRB      \ offset: 0x2C : Power Port B pull-down control register
$40007030 constant PWR_PUCRC      \ offset: 0x30 : Power Port C pull-up control register
$40007034 constant PWR_PDCRC      \ offset: 0x34 : Power Port C pull-down control register
$40007038 constant PWR_PUCRD      \ offset: 0x38 : Power Port D pull-up control register
$4000703c constant PWR_PDCRD      \ offset: 0x3C : Power Port D pull-down control register
$40007040 constant PWR_PUCRE      \ offset: 0x40 : Power Port E pull-up control register
$40007044 constant PWR_PDCRE      \ offset: 0x44 : Power Port E pull-down control register
$40007048 constant PWR_PUCRF      \ offset: 0x48 : Power Port F pull-up control register
$4000704c constant PWR_PDCRF      \ offset: 0x4C : Power Port F pull-down control register
$40007050 constant PWR_PUCRG      \ offset: 0x50 : Power Port G pull-up control register
$40007054 constant PWR_PDCRG      \ offset: 0x54 : Power Port G pull-down control register
$40007058 constant PWR_PUCRH      \ offset: 0x58 : Power Port H pull-up control register
$4000705c constant PWR_PDCRH      \ offset: 0x5C : Power Port H pull-down control register

