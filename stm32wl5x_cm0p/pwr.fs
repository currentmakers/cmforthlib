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

$00000007 constant PWR_CR1_LPMS                                     \ Low-power mode selection for CPU1
$00000008 constant PWR_CR1_SUBGHZSPINSSSEL                          \ sub-GHz SPI NSS source select
$00000010 constant PWR_CR1_FPDR                                     \ Flash memory power down mode during LPRun for CPU1
$00000020 constant PWR_CR1_FPDS                                     \ Flash memory power down mode during LPSleep for CPU1
$00000100 constant PWR_CR1_DBP                                      \ Disable backup domain write protection
$00000600 constant PWR_CR1_VOS                                      \ Voltage scaling range selection
$00004000 constant PWR_CR1_LPR                                      \ Low-power run


\
\ @brief Power control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant PWR_CR2_PVDE                                     \ Power voltage detector enable
$0000000e constant PWR_CR2_PLS                                      \ Power voltage detector level selection.
$00000040 constant PWR_CR2_PVME3                                    \ Peripheral voltage monitoring 3 enable: VDDA vs. 1.62V


\
\ @brief Power control register 3
\ Address offset: 0x08
\ Reset value: 0x00008000
\

$00000001 constant PWR_CR3_EWUP1                                    \ Enable Wakeup pin WKUP1 for CPU1
$00000002 constant PWR_CR3_EWUP2                                    \ Enable Wakeup pin WKUP2 for CPU1
$00000004 constant PWR_CR3_EWUP3                                    \ Enable Wakeup pin WKUP3 for CPU1
$00000080 constant PWR_CR3_EULPEN                                   \ Ultra-low-power enable
$00000100 constant PWR_CR3_EWPVD                                    \ Enable wakeup PVD for CPU1
$00000200 constant PWR_CR3_RRS                                      \ SRAM2 retention in Standby mode
$00000400 constant PWR_CR3_APC                                      \ Apply pull-up and pull-down configuration from CPU1
$00000800 constant PWR_CR3_EWRFBUSY                                 \ Enable Radio BUSY Wakeup from Standby for CPU1
$00002000 constant PWR_CR3_EWRFIRQ                                  \ akeup for CPU1
$00004000 constant PWR_CR3_EC2H                                     \ nable CPU2 Hold interrupt for CPU1
$00008000 constant PWR_CR3_EIWUL                                    \ Enable internal wakeup line for CPU1


\
\ @brief Power control register 4
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant PWR_CR4_WP1                                      \ Wakeup pin WKUP1 polarity
$00000002 constant PWR_CR4_WP2                                      \ Wakeup pin WKUP2 polarity
$00000004 constant PWR_CR4_WP3                                      \ Wakeup pin WKUP3 polarity
$00000100 constant PWR_CR4_VBE                                      \ VBAT battery charging enable
$00000200 constant PWR_CR4_VBRS                                     \ VBAT battery charging resistor selection
$00000800 constant PWR_CR4_WRFBUSYP                                 \ Wakeup Radio BUSY polarity
$00008000 constant PWR_CR4_C2BOOT                                   \ oot CPU2 after reset or wakeup from Stop or Standby modes.


\
\ @brief Power status register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant PWR_SR1_WUF1                                     \ Wakeup flag 1
$00000002 constant PWR_SR1_WUF2                                     \ Wakeup flag 2
$00000004 constant PWR_SR1_WUF3                                     \ Wakeup flag 3
$00000100 constant PWR_SR1_WPVDF                                    \ Wakeup PVD flag
$00000800 constant PWR_SR1_WRFBUSYF                                 \ Radio BUSY wakeup flag
$00004000 constant PWR_SR1_C2HF                                     \ PU2 Hold interrupt flag
$00008000 constant PWR_SR1_WUFI                                     \ Internal wakeup interrupt flag


\
\ @brief Power status register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant PWR_SR2_C2BOOTS                                  \ PU2 boot/wakeup request source information
$00000002 constant PWR_SR2_RFBUSYS                                  \ Radio BUSY signal status
$00000004 constant PWR_SR2_RFBUSYMS                                 \ Radio BUSY masked signal status
$00000008 constant PWR_SR2_SMPSRDY                                  \ SMPS ready flag
$00000010 constant PWR_SR2_LDORDY                                   \ LDO ready flag
$00000020 constant PWR_SR2_RFEOLF                                   \ Radio end of life flag
$00000040 constant PWR_SR2_REGMRS                                   \ regulator2 low power flag
$00000080 constant PWR_SR2_FLASHRDY                                 \ Flash ready
$00000100 constant PWR_SR2_REGLPS                                   \ regulator1 started
$00000200 constant PWR_SR2_REGLPF                                   \ regulator1 low power flag
$00000400 constant PWR_SR2_VOSF                                     \ Voltage scaling flag
$00000800 constant PWR_SR2_PVDO                                     \ Power voltage detector output
$00004000 constant PWR_SR2_PVMO3                                    \ Peripheral voltage monitoring output: VDDA vs. 1.62 V


\
\ @brief Power status clear register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant PWR_SCR_CWUF1                                    \ Clear wakeup flag 1
$00000002 constant PWR_SCR_CWUF2                                    \ Clear wakeup flag 2
$00000004 constant PWR_SCR_CWUF3                                    \ Clear wakeup flag 3
$00000100 constant PWR_SCR_CWPVDF                                   \ Clear wakeup PVD interrupt flag
$00000800 constant PWR_SCR_CWRFBUSYF                                \ Clear wakeup Radio BUSY flag
$00004000 constant PWR_SCR_CC2HF                                    \ lear CPU2 Hold interrupt flag


\
\ @brief Power control register 5
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00004000 constant PWR_CR5_RFEOLEN                                  \ Enable Radio End Of Life detector enabled
$00008000 constant PWR_CR5_SMPSEN                                   \ Enable SMPS Step Down converter SMPS mode enabled.


\
\ @brief Power Port A pull-up control register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant PWR_PUCRA_PU0                                    \ PU0
$00000002 constant PWR_PUCRA_PU1                                    \ PU1
$00000004 constant PWR_PUCRA_PU2                                    \ PU2
$00000008 constant PWR_PUCRA_PU3                                    \ PU3
$00000010 constant PWR_PUCRA_PU4                                    \ PU4
$00000020 constant PWR_PUCRA_PU5                                    \ PU5
$00000040 constant PWR_PUCRA_PU6                                    \ PU6
$00000080 constant PWR_PUCRA_PU7                                    \ PU7
$00000100 constant PWR_PUCRA_PU8                                    \ PU8
$00000200 constant PWR_PUCRA_PU9                                    \ PU9
$00000400 constant PWR_PUCRA_PU10                                   \ PU10
$00000800 constant PWR_PUCRA_PU11                                   \ PU11
$00001000 constant PWR_PUCRA_PU12                                   \ PU12
$00002000 constant PWR_PUCRA_PU13                                   \ Port PA[y] pull-up bit y (y=0 to 13)
$00004000 constant PWR_PUCRA_PU14                                   \ PU14
$00008000 constant PWR_PUCRA_PU15                                   \ Port PA15 pull-up


\
\ @brief Power Port A pull-down control register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant PWR_PDCRA_PD0                                    \ PD0
$00000002 constant PWR_PDCRA_PD1                                    \ PD1
$00000004 constant PWR_PDCRA_PD2                                    \ PD2
$00000008 constant PWR_PDCRA_PD3                                    \ PD3
$00000010 constant PWR_PDCRA_PD4                                    \ PD4
$00000020 constant PWR_PDCRA_PD5                                    \ PD5
$00000040 constant PWR_PDCRA_PD6                                    \ PD6
$00000080 constant PWR_PDCRA_PD7                                    \ PD7
$00000100 constant PWR_PDCRA_PD8                                    \ PD8
$00000200 constant PWR_PDCRA_PD9                                    \ PD9
$00000400 constant PWR_PDCRA_PD10                                   \ PD10
$00000800 constant PWR_PDCRA_PD11                                   \ PD11
$00001000 constant PWR_PDCRA_PD12                                   \ Port PA[y] pull-down (y=0 to 12)
$00002000 constant PWR_PDCRA_PD13                                   \ PD13
$00004000 constant PWR_PDCRA_PD14                                   \ ull-down
$00008000 constant PWR_PDCRA_PD15                                   \ PD15


\
\ @brief Power Port B pull-up control register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant PWR_PUCRB_PU0                                    \ PU0
$00000002 constant PWR_PUCRB_PU1                                    \ PU1
$00000004 constant PWR_PUCRB_PU2                                    \ PU2
$00000008 constant PWR_PUCRB_PU3                                    \ PU3
$00000010 constant PWR_PUCRB_PU4                                    \ PU4
$00000020 constant PWR_PUCRB_PU5                                    \ PU5
$00000040 constant PWR_PUCRB_PU6                                    \ PU6
$00000080 constant PWR_PUCRB_PU7                                    \ PU7
$00000100 constant PWR_PUCRB_PU8                                    \ PU8
$00000200 constant PWR_PUCRB_PU9                                    \ PU9
$00000400 constant PWR_PUCRB_PU10                                   \ PU10
$00000800 constant PWR_PUCRB_PU11                                   \ PU11
$00001000 constant PWR_PUCRB_PU12                                   \ PU12
$00002000 constant PWR_PUCRB_PU13                                   \ PU13
$00004000 constant PWR_PUCRB_PU14                                   \ PU14
$00008000 constant PWR_PUCRB_PU15                                   \ Port PB[y] pull-up (y=0 to 15)


\
\ @brief Power Port B pull-down control register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant PWR_PDCRB_PD0                                    \ PD0
$00000002 constant PWR_PDCRB_PD1                                    \ PD1
$00000004 constant PWR_PDCRB_PD2                                    \ PD2
$00000008 constant PWR_PDCRB_PD3                                    \ Port PB[y] pull-down (y=0 to 3)
$00000010 constant PWR_PDCRB_PD4                                    \ PD4
$00000020 constant PWR_PDCRB_PD5                                    \ PD5
$00000040 constant PWR_PDCRB_PD6                                    \ PD6
$00000080 constant PWR_PDCRB_PD7                                    \ PD7
$00000100 constant PWR_PDCRB_PD8                                    \ PD8
$00000200 constant PWR_PDCRB_PD9                                    \ PD9
$00000400 constant PWR_PDCRB_PD10                                   \ PD10
$00000800 constant PWR_PDCRB_PD11                                   \ PD11
$00001000 constant PWR_PDCRB_PD12                                   \ PD12
$00002000 constant PWR_PDCRB_PD13                                   \ PD13
$00004000 constant PWR_PDCRB_PD14                                   \ PD14
$00008000 constant PWR_PDCRB_PD15                                   \ Port PB[y] pull-down (y=5 to 15)


\
\ @brief Power Port C pull-up control register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant PWR_PUCRC_PU0                                    \ PU0
$00000002 constant PWR_PUCRC_PU1                                    \ PU1
$00000004 constant PWR_PUCRC_PU2                                    \ PU2
$00000008 constant PWR_PUCRC_PU3                                    \ PU3
$00000010 constant PWR_PUCRC_PU4                                    \ PU4
$00000020 constant PWR_PUCRC_PU5                                    \ PU5
$00000040 constant PWR_PUCRC_PU6                                    \ PU6
$00002000 constant PWR_PUCRC_PU13                                   \ PU13
$00004000 constant PWR_PUCRC_PU14                                   \ PU14
$00008000 constant PWR_PUCRC_PU15                                   \ Port PC[y] pull-up (y=13 to 15)


\
\ @brief Power Port C pull-down control register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant PWR_PDCRC_PD0                                    \ PD0
$00000002 constant PWR_PDCRC_PD1                                    \ PD1
$00000004 constant PWR_PDCRC_PD2                                    \ PD2
$00000008 constant PWR_PDCRC_PD3                                    \ PD3
$00000010 constant PWR_PDCRC_PD4                                    \ PD4
$00000020 constant PWR_PDCRC_PD5                                    \ PD5
$00000040 constant PWR_PDCRC_PD6                                    \ PD6
$00002000 constant PWR_PDCRC_PD13                                   \ PD13
$00004000 constant PWR_PDCRC_PD14                                   \ PD14
$00008000 constant PWR_PDCRC_PD15                                   \ Port PC[y] pull-down (y=13 to 15)


\
\ @brief Power Port H pull-up control register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000008 constant PWR_PUCRH_PU3                                    \ pull-up


\
\ @brief Power Port H pull-down control register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000008 constant PWR_PDCRH_PD3                                    \ pull-down


\
\ @brief Power CPU2 control register 1 [dual core device only]
\ Address offset: 0x80
\ Reset value: 0x00000007
\

$00000007 constant PWR_C2CR1_LPMS                                   \ Low-power mode selection for CPU2
$00000010 constant PWR_C2CR1_FPDR                                   \ Flash memory power down mode during LPRun for CPU2
$00000020 constant PWR_C2CR1_FPDS                                   \ Flash memory power down mode during LPSleep for CPU2


\
\ @brief Power CPU2 control register 3 [dual core device only]
\ Address offset: 0x84
\ Reset value: 0x00008000
\

$00000001 constant PWR_C2CR3_EWUP1                                  \ Enable Wakeup pin WKUP1 for CPU2
$00000002 constant PWR_C2CR3_EWUP2                                  \ Enable Wakeup pin WKUP2 for CPU2
$00000004 constant PWR_C2CR3_EWUP3                                  \ Enable Wakeup pin WKUP3 for CPU2
$00000100 constant PWR_C2CR3_EWPVD                                  \ Enable wakeup PVD for CPU2
$00000400 constant PWR_C2CR3_APC                                    \ Apply pull-up and pull-down configuration for CPU2
$00000800 constant PWR_C2CR3_EWRFBUSY                               \ EWRFBUSY
$00002000 constant PWR_C2CR3_EWRFIRQ                                \ akeup for CPU2
$00008000 constant PWR_C2CR3_EIWUL                                  \ Enable internal wakeup line for CPU2


\
\ @brief Power extended status and status clear register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant PWR_EXTSCR_C1CSSF                                \ Clear CPU1 Stop Standby flags
$00000002 constant PWR_EXTSCR_C2CSSF                                \ lear CPU2 Stop Standby flags
$00000100 constant PWR_EXTSCR_C1SBF                                 \ System Standby flag for CPU1. (no core states retained)
$00000200 constant PWR_EXTSCR_C1STOP2F                              \ System Stop2 flag for CPU1. (partial core states retained)
$00000400 constant PWR_EXTSCR_C1STOPF                               \ System Stop0, 1 flag for CPU1. (All core states retained)
$00000800 constant PWR_EXTSCR_C2SBF                                 \ ystem Standby flag for CPU2. (no core states retained)
$00001000 constant PWR_EXTSCR_C2STOP2F                              \ ystem Stop2 flag for CPU2. (partial core states retained)
$00002000 constant PWR_EXTSCR_C2STOPF                               \ ystem Stop0, 1 flag for CPU2. (All core states retained)
$00004000 constant PWR_EXTSCR_C1DS                                  \ CPU1 deepsleep mode
$00008000 constant PWR_EXTSCR_C2DS                                  \ PU2 deepsleep mode


\
\ @brief Power security configuration register [dual core device only]
\ Address offset: 0x8C
\ Reset value: 0x00008000
\

$00008000 constant PWR_SECCFGR_C2EWILA                              \ wakeup on CPU2 illegal access interrupt enable


\
\ @brief Power SPI3 control register
\ Address offset: 0x90
\ Reset value: 0x00008000
\

$00008000 constant PWR_SUBGHZSPICR_NSS                              \ sub-GHz SPI NSS control


\
\ @brief RSS Command register [dual core device only]
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$000000ff constant PWR_RSSCMDR_RSSCMD                               \ RSS command


\
\ @brief Power control
\
$58000400 constant PWR_CR1        \ offset: 0x00 : Power control register 1
$58000404 constant PWR_CR2        \ offset: 0x04 : Power control register 2
$58000408 constant PWR_CR3        \ offset: 0x08 : Power control register 3
$5800040c constant PWR_CR4        \ offset: 0x0C : Power control register 4
$58000410 constant PWR_SR1        \ offset: 0x10 : Power status register 1
$58000414 constant PWR_SR2        \ offset: 0x14 : Power status register 2
$58000418 constant PWR_SCR        \ offset: 0x18 : Power status clear register
$5800041c constant PWR_CR5        \ offset: 0x1C : Power control register 5
$58000420 constant PWR_PUCRA      \ offset: 0x20 : Power Port A pull-up control register
$58000424 constant PWR_PDCRA      \ offset: 0x24 : Power Port A pull-down control register
$58000428 constant PWR_PUCRB      \ offset: 0x28 : Power Port B pull-up control register
$5800042c constant PWR_PDCRB      \ offset: 0x2C : Power Port B pull-down control register
$58000430 constant PWR_PUCRC      \ offset: 0x30 : Power Port C pull-up control register
$58000434 constant PWR_PDCRC      \ offset: 0x34 : Power Port C pull-down control register
$58000458 constant PWR_PUCRH      \ offset: 0x58 : Power Port H pull-up control register
$5800045c constant PWR_PDCRH      \ offset: 0x5C : Power Port H pull-down control register
$58000480 constant PWR_C2CR1      \ offset: 0x80 : Power CPU2 control register 1 [dual core device only]
$58000484 constant PWR_C2CR3      \ offset: 0x84 : Power CPU2 control register 3 [dual core device only]
$58000488 constant PWR_EXTSCR     \ offset: 0x88 : Power extended status and status clear register
$5800048c constant PWR_SECCFGR    \ offset: 0x8C : Power security configuration register [dual core device only]
$58000490 constant PWR_SUBGHZSPICR  \ offset: 0x90 : Power SPI3 control register
$58000498 constant PWR_RSSCMDR    \ offset: 0x98 : RSS Command register [dual core device only]

